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
        public IBodyWorkflowAction<Booth> BoothsGet(Expression<Func<string>> clientName, Expression<Func<string>> boothNumber, Expression<Func<string>> databaseName)
        {
            var __workflow_clientName = WorkflowExpression.Compile(clientName, nameof(clientName), required: true);
            var __workflow_boothNumber = WorkflowExpression.Compile(boothNumber, nameof(boothNumber), required: true);
            var __workflow_databaseName = WorkflowExpression.Compile(databaseName, nameof(databaseName), required: true);
            return new DeferredBodyAction<Booth>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/booths", __workflow_clientName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["boothNumber"] = ExpressionConverter.Convert(__workflow_boothNumber);
                callPayload.Queries["databaseName"] = ExpressionConverter.Convert(__workflow_databaseName);
                return new ApiConnectionAction<Booth>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<Booth[]> BoothsGetAllBooths(Expression<Func<string>> clientName, Expression<Func<string>> databaseName, Expression<Func<deletedFilterInput>> deletedFilter = null)
        {
            var __workflow_clientName = WorkflowExpression.Compile(clientName, nameof(clientName), required: true);
            var __workflow_databaseName = WorkflowExpression.Compile(databaseName, nameof(databaseName), required: true);
            var __workflow_deletedFilter = WorkflowExpression.Compile(deletedFilter, nameof(deletedFilter), required: false);
            return new DeferredBodyAction<Booth[]>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/booths/all", __workflow_clientName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["databaseName"] = ExpressionConverter.Convert(__workflow_databaseName);
                if (__workflow_deletedFilter != null)
                    callPayload.Queries["deletedFilter"] = ExpressionConverter.Convert(__workflow_deletedFilter);
                return new ApiConnectionAction<Booth[]>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<Booth[]> BoothsGetAllAvailableBooths(Expression<Func<string>> clientName, Expression<Func<string>> databaseName)
        {
            var __workflow_clientName = WorkflowExpression.Compile(clientName, nameof(clientName), required: true);
            var __workflow_databaseName = WorkflowExpression.Compile(databaseName, nameof(databaseName), required: true);
            return new DeferredBodyAction<Booth[]>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/booths/all/available", __workflow_clientName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["databaseName"] = ExpressionConverter.Convert(__workflow_databaseName);
                return new ApiConnectionAction<Booth[]>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<Booth[]> BoothsGetAllRentedBooths(Expression<Func<string>> clientName, Expression<Func<string>> databaseName)
        {
            var __workflow_clientName = WorkflowExpression.Compile(clientName, nameof(clientName), required: true);
            var __workflow_databaseName = WorkflowExpression.Compile(databaseName, nameof(databaseName), required: true);
            return new DeferredBodyAction<Booth[]>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/booths/all/rented", __workflow_clientName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["databaseName"] = ExpressionConverter.Convert(__workflow_databaseName);
                return new ApiConnectionAction<Booth[]>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<JToken> BoothsRentBooth(Expression<Func<string>> clientName, Expression<Func<string>> boothNumber, Expression<Func<string>> exhibitorId, Expression<Func<string>> databaseName, Expression<Func<string>> ratePlan = null, Expression<Func<string>> status = null, Expression<Func<string>> comment = null)
        {
            var __workflow_clientName = WorkflowExpression.Compile(clientName, nameof(clientName), required: true);
            var __workflow_boothNumber = WorkflowExpression.Compile(boothNumber, nameof(boothNumber), required: true);
            var __workflow_exhibitorId = WorkflowExpression.Compile(exhibitorId, nameof(exhibitorId), required: true);
            var __workflow_databaseName = WorkflowExpression.Compile(databaseName, nameof(databaseName), required: true);
            var __workflow_ratePlan = WorkflowExpression.Compile(ratePlan, nameof(ratePlan), required: false);
            var __workflow_status = WorkflowExpression.Compile(status, nameof(status), required: false);
            var __workflow_comment = WorkflowExpression.Compile(comment, nameof(comment), required: false);
            return new DeferredBodyAction<JToken>(() =>
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
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<JToken> BoothsUnRentBooth(Expression<Func<string>> clientName, Expression<Func<string>> boothNumber, Expression<Func<string>> databaseName)
        {
            var __workflow_clientName = WorkflowExpression.Compile(clientName, nameof(clientName), required: true);
            var __workflow_boothNumber = WorkflowExpression.Compile(boothNumber, nameof(boothNumber), required: true);
            var __workflow_databaseName = WorkflowExpression.Compile(databaseName, nameof(databaseName), required: true);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/booths/unrent", __workflow_clientName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["boothNumber"] = ExpressionConverter.Convert(__workflow_boothNumber);
                callPayload.Queries["databaseName"] = ExpressionConverter.Convert(__workflow_databaseName);
                return new ApiConnectionAction<JToken>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<JToken> BoothsHoldBooth(Expression<Func<string>> clientName, Expression<Func<string>> boothNumber, Expression<Func<string>> databaseName, Expression<Func<string>> exhibitorId = null, Expression<Func<string>> exhibitorName = null, Expression<Func<string>> comment = null)
        {
            var __workflow_clientName = WorkflowExpression.Compile(clientName, nameof(clientName), required: true);
            var __workflow_boothNumber = WorkflowExpression.Compile(boothNumber, nameof(boothNumber), required: true);
            var __workflow_databaseName = WorkflowExpression.Compile(databaseName, nameof(databaseName), required: true);
            var __workflow_exhibitorId = WorkflowExpression.Compile(exhibitorId, nameof(exhibitorId), required: false);
            var __workflow_exhibitorName = WorkflowExpression.Compile(exhibitorName, nameof(exhibitorName), required: false);
            var __workflow_comment = WorkflowExpression.Compile(comment, nameof(comment), required: false);
            return new DeferredBodyAction<JToken>(() =>
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
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<JToken> BoothsUnHoldBooth(Expression<Func<string>> clientName, Expression<Func<string>> boothNumber, Expression<Func<string>> databaseName)
        {
            var __workflow_clientName = WorkflowExpression.Compile(clientName, nameof(clientName), required: true);
            var __workflow_boothNumber = WorkflowExpression.Compile(boothNumber, nameof(boothNumber), required: true);
            var __workflow_databaseName = WorkflowExpression.Compile(databaseName, nameof(databaseName), required: true);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/booths/unhold", __workflow_clientName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["boothNumber"] = ExpressionConverter.Convert(__workflow_boothNumber);
                callPayload.Queries["databaseName"] = ExpressionConverter.Convert(__workflow_databaseName);
                return new ApiConnectionAction<JToken>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<JToken> BoothsRentToHold(Expression<Func<string>> clientName, Expression<Func<string>> boothNumber, Expression<Func<string>> databaseName)
        {
            var __workflow_clientName = WorkflowExpression.Compile(clientName, nameof(clientName), required: true);
            var __workflow_boothNumber = WorkflowExpression.Compile(boothNumber, nameof(boothNumber), required: true);
            var __workflow_databaseName = WorkflowExpression.Compile(databaseName, nameof(databaseName), required: true);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/booths/rentToHold", __workflow_clientName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["boothNumber"] = ExpressionConverter.Convert(__workflow_boothNumber);
                callPayload.Queries["databaseName"] = ExpressionConverter.Convert(__workflow_databaseName);
                return new ApiConnectionAction<JToken>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<JToken> BoothsHoldToRent(Expression<Func<string>> clientName, Expression<Func<string>> boothNumber, Expression<Func<string>> databaseName, Expression<Func<string>> ratePlan = null)
        {
            var __workflow_clientName = WorkflowExpression.Compile(clientName, nameof(clientName), required: true);
            var __workflow_boothNumber = WorkflowExpression.Compile(boothNumber, nameof(boothNumber), required: true);
            var __workflow_databaseName = WorkflowExpression.Compile(databaseName, nameof(databaseName), required: true);
            var __workflow_ratePlan = WorkflowExpression.Compile(ratePlan, nameof(ratePlan), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/booths/holdToRent", __workflow_clientName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["boothNumber"] = ExpressionConverter.Convert(__workflow_boothNumber);
                callPayload.Queries["databaseName"] = ExpressionConverter.Convert(__workflow_databaseName);
                if (__workflow_ratePlan != null)
                    callPayload.Queries["ratePlan"] = ExpressionConverter.Convert(__workflow_ratePlan);
                return new ApiConnectionAction<JToken>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<JToken> BoothsCombineBooths(Expression<Func<string>> clientName, Expression<Func<string>> databaseName, Expression<Func<int>> boundary, Expression<Func<string[]>> boothNumbers = null)
        {
            var __workflow_clientName = WorkflowExpression.Compile(clientName, nameof(clientName), required: true);
            var __workflow_databaseName = WorkflowExpression.Compile(databaseName, nameof(databaseName), required: true);
            var __workflow_boundary = WorkflowExpression.Compile(boundary, nameof(boundary), required: true);
            var __workflow_boothNumbers = WorkflowExpression.Compile(boothNumbers, nameof(boothNumbers), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/booths/combine", __workflow_clientName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["databaseName"] = ExpressionConverter.Convert(__workflow_databaseName);
                callPayload.Queries["boundary"] = ExpressionConverter.Convert(__workflow_boundary);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_boothNumbers);
                return new ApiConnectionAction<JToken>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<JToken> BoothsUncombineBooth(Expression<Func<string>> clientName, Expression<Func<string>> boothNumber, Expression<Func<string>> databaseName)
        {
            var __workflow_clientName = WorkflowExpression.Compile(clientName, nameof(clientName), required: true);
            var __workflow_boothNumber = WorkflowExpression.Compile(boothNumber, nameof(boothNumber), required: true);
            var __workflow_databaseName = WorkflowExpression.Compile(databaseName, nameof(databaseName), required: true);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/booths/uncombine", __workflow_clientName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["boothNumber"] = ExpressionConverter.Convert(__workflow_boothNumber);
                callPayload.Queries["databaseName"] = ExpressionConverter.Convert(__workflow_databaseName);
                return new ApiConnectionAction<JToken>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<JToken> BoothsDeleteBooths(Expression<Func<string>> clientName, Expression<Func<string>> databaseName, Expression<Func<string[]>> boothNumbers = null)
        {
            var __workflow_clientName = WorkflowExpression.Compile(clientName, nameof(clientName), required: true);
            var __workflow_databaseName = WorkflowExpression.Compile(databaseName, nameof(databaseName), required: true);
            var __workflow_boothNumbers = WorkflowExpression.Compile(boothNumbers, nameof(boothNumbers), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/booths/delete", __workflow_clientName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["databaseName"] = ExpressionConverter.Convert(__workflow_databaseName);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_boothNumbers);
                return new ApiConnectionAction<JToken>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<JToken> BoothsUndeleteBooths(Expression<Func<string>> clientName, Expression<Func<string>> databaseName, Expression<Func<string[]>> boothNumbers = null)
        {
            var __workflow_clientName = WorkflowExpression.Compile(clientName, nameof(clientName), required: true);
            var __workflow_databaseName = WorkflowExpression.Compile(databaseName, nameof(databaseName), required: true);
            var __workflow_boothNumbers = WorkflowExpression.Compile(boothNumbers, nameof(boothNumbers), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/booths/undelete", __workflow_clientName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["databaseName"] = ExpressionConverter.Convert(__workflow_databaseName);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_boothNumbers);
                return new ApiConnectionAction<JToken>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<JToken> BoothsChangeBoothNumber(Expression<Func<string>> clientName, Expression<Func<string>> oldNumber, Expression<Func<string>> newNumber, Expression<Func<string>> databaseName)
        {
            var __workflow_clientName = WorkflowExpression.Compile(clientName, nameof(clientName), required: true);
            var __workflow_oldNumber = WorkflowExpression.Compile(oldNumber, nameof(oldNumber), required: true);
            var __workflow_newNumber = WorkflowExpression.Compile(newNumber, nameof(newNumber), required: true);
            var __workflow_databaseName = WorkflowExpression.Compile(databaseName, nameof(databaseName), required: true);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/booths/changenumber", __workflow_clientName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["oldNumber"] = ExpressionConverter.Convert(__workflow_oldNumber);
                callPayload.Queries["newNumber"] = ExpressionConverter.Convert(__workflow_newNumber);
                callPayload.Queries["databaseName"] = ExpressionConverter.Convert(__workflow_databaseName);
                return new ApiConnectionAction<JToken>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<JToken> BoothsSetBoothClass(Expression<Func<string>> clientName, Expression<Func<string>> classId, Expression<Func<string>> boothNumber, Expression<Func<string>> databaseName)
        {
            var __workflow_clientName = WorkflowExpression.Compile(clientName, nameof(clientName), required: true);
            var __workflow_classId = WorkflowExpression.Compile(classId, nameof(classId), required: true);
            var __workflow_boothNumber = WorkflowExpression.Compile(boothNumber, nameof(boothNumber), required: true);
            var __workflow_databaseName = WorkflowExpression.Compile(databaseName, nameof(databaseName), required: true);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/booths/classes/apply", __workflow_clientName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["classId"] = ExpressionConverter.Convert(__workflow_classId);
                callPayload.Queries["boothNumber"] = ExpressionConverter.Convert(__workflow_boothNumber);
                callPayload.Queries["databaseName"] = ExpressionConverter.Convert(__workflow_databaseName);
                return new ApiConnectionAction<JToken>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<JToken> BoothsClearBoothClass(Expression<Func<string>> clientName, Expression<Func<string>> classId, Expression<Func<string>> boothNumber, Expression<Func<string>> databaseName)
        {
            var __workflow_clientName = WorkflowExpression.Compile(clientName, nameof(clientName), required: true);
            var __workflow_classId = WorkflowExpression.Compile(classId, nameof(classId), required: true);
            var __workflow_boothNumber = WorkflowExpression.Compile(boothNumber, nameof(boothNumber), required: true);
            var __workflow_databaseName = WorkflowExpression.Compile(databaseName, nameof(databaseName), required: true);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/booths/classes/remove", __workflow_clientName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["classId"] = ExpressionConverter.Convert(__workflow_classId);
                callPayload.Queries["boothNumber"] = ExpressionConverter.Convert(__workflow_boothNumber);
                callPayload.Queries["databaseName"] = ExpressionConverter.Convert(__workflow_databaseName);
                return new ApiConnectionAction<JToken>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<JToken> BoothsSetBoothDisplayName(Expression<Func<string>> clientName, Expression<Func<string>> text, Expression<Func<string>> boothNumber, Expression<Func<string>> databaseName)
        {
            var __workflow_clientName = WorkflowExpression.Compile(clientName, nameof(clientName), required: true);
            var __workflow_text = WorkflowExpression.Compile(text, nameof(text), required: true);
            var __workflow_boothNumber = WorkflowExpression.Compile(boothNumber, nameof(boothNumber), required: true);
            var __workflow_databaseName = WorkflowExpression.Compile(databaseName, nameof(databaseName), required: true);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/booths/displayNameOverride/set", __workflow_clientName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["text"] = ExpressionConverter.Convert(__workflow_text);
                callPayload.Queries["boothNumber"] = ExpressionConverter.Convert(__workflow_boothNumber);
                callPayload.Queries["databaseName"] = ExpressionConverter.Convert(__workflow_databaseName);
                return new ApiConnectionAction<JToken>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<JToken> BoothsClearBoothDisplayName(Expression<Func<string>> clientName, Expression<Func<string>> boothNumber, Expression<Func<string>> databaseName)
        {
            var __workflow_clientName = WorkflowExpression.Compile(clientName, nameof(clientName), required: true);
            var __workflow_boothNumber = WorkflowExpression.Compile(boothNumber, nameof(boothNumber), required: true);
            var __workflow_databaseName = WorkflowExpression.Compile(databaseName, nameof(databaseName), required: true);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/booths/displayNameOverride/reset", __workflow_clientName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["boothNumber"] = ExpressionConverter.Convert(__workflow_boothNumber);
                callPayload.Queries["databaseName"] = ExpressionConverter.Convert(__workflow_databaseName);
                return new ApiConnectionAction<JToken>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<JToken> BoothsAddChildExhibitor(Expression<Func<string>> clientName, Expression<Func<string>> childExhibitorId, Expression<Func<string>> boothNumber, Expression<Func<string>> databaseName)
        {
            var __workflow_clientName = WorkflowExpression.Compile(clientName, nameof(clientName), required: true);
            var __workflow_childExhibitorId = WorkflowExpression.Compile(childExhibitorId, nameof(childExhibitorId), required: true);
            var __workflow_boothNumber = WorkflowExpression.Compile(boothNumber, nameof(boothNumber), required: true);
            var __workflow_databaseName = WorkflowExpression.Compile(databaseName, nameof(databaseName), required: true);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/booths/childExhibitor/add", __workflow_clientName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["childExhibitorId"] = ExpressionConverter.Convert(__workflow_childExhibitorId);
                callPayload.Queries["boothNumber"] = ExpressionConverter.Convert(__workflow_boothNumber);
                callPayload.Queries["databaseName"] = ExpressionConverter.Convert(__workflow_databaseName);
                return new ApiConnectionAction<JToken>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<JToken> BoothsRemoveChildExhibitor(Expression<Func<string>> clientName, Expression<Func<string>> childExhibitorId, Expression<Func<string>> boothNumber, Expression<Func<string>> databaseName)
        {
            var __workflow_clientName = WorkflowExpression.Compile(clientName, nameof(clientName), required: true);
            var __workflow_childExhibitorId = WorkflowExpression.Compile(childExhibitorId, nameof(childExhibitorId), required: true);
            var __workflow_boothNumber = WorkflowExpression.Compile(boothNumber, nameof(boothNumber), required: true);
            var __workflow_databaseName = WorkflowExpression.Compile(databaseName, nameof(databaseName), required: true);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/booths/childExhibitor/remove", __workflow_clientName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["childExhibitorId"] = ExpressionConverter.Convert(__workflow_childExhibitorId);
                callPayload.Queries["boothNumber"] = ExpressionConverter.Convert(__workflow_boothNumber);
                callPayload.Queries["databaseName"] = ExpressionConverter.Convert(__workflow_databaseName);
                return new ApiConnectionAction<JToken>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<BoothClass> ClassesGet(Expression<Func<string>> clientName, Expression<Func<string>> classId, Expression<Func<string>> databaseName)
        {
            var __workflow_clientName = WorkflowExpression.Compile(clientName, nameof(clientName), required: true);
            var __workflow_classId = WorkflowExpression.Compile(classId, nameof(classId), required: true);
            var __workflow_databaseName = WorkflowExpression.Compile(databaseName, nameof(databaseName), required: true);
            return new DeferredBodyAction<BoothClass>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/classes", __workflow_clientName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["classId"] = ExpressionConverter.Convert(__workflow_classId);
                callPayload.Queries["databaseName"] = ExpressionConverter.Convert(__workflow_databaseName);
                return new ApiConnectionAction<BoothClass>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<BoothClass[]> ClassesGetAllBoothClasses(Expression<Func<string>> clientName, Expression<Func<string>> databaseName)
        {
            var __workflow_clientName = WorkflowExpression.Compile(clientName, nameof(clientName), required: true);
            var __workflow_databaseName = WorkflowExpression.Compile(databaseName, nameof(databaseName), required: true);
            return new DeferredBodyAction<BoothClass[]>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/classes/all", __workflow_clientName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["databaseName"] = ExpressionConverter.Convert(__workflow_databaseName);
                return new ApiConnectionAction<BoothClass[]>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<BoothClass> ClassesCreate(Expression<Func<string>> clientName, Expression<Func<string>> boothClassid, Expression<Func<int>> boothClasskeepWhenCombined, Expression<Func<int>> boothClasscountAsInventory, Expression<Func<string>> databaseName, Expression<Func<string>> boothClassname = null, Expression<Func<string>> boothClassdescription = null, Expression<Func<string>> boothClassprioritity = null, Expression<Func<int>> boothClasscolor = null)
        {
            var __workflow_clientName = WorkflowExpression.Compile(clientName, nameof(clientName), required: true);
            var __workflow_boothClassid = WorkflowExpression.Compile(boothClassid, nameof(boothClassid), required: true);
            var __workflow_boothClasskeepWhenCombined = WorkflowExpression.Compile(boothClasskeepWhenCombined, nameof(boothClasskeepWhenCombined), required: true);
            var __workflow_boothClasscountAsInventory = WorkflowExpression.Compile(boothClasscountAsInventory, nameof(boothClasscountAsInventory), required: true);
            var __workflow_databaseName = WorkflowExpression.Compile(databaseName, nameof(databaseName), required: true);
            var __workflow_boothClassname = WorkflowExpression.Compile(boothClassname, nameof(boothClassname), required: false);
            var __workflow_boothClassdescription = WorkflowExpression.Compile(boothClassdescription, nameof(boothClassdescription), required: false);
            var __workflow_boothClassprioritity = WorkflowExpression.Compile(boothClassprioritity, nameof(boothClassprioritity), required: false);
            var __workflow_boothClasscolor = WorkflowExpression.Compile(boothClasscolor, nameof(boothClasscolor), required: false);
            return new DeferredBodyAction<BoothClass>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/classes/add", __workflow_clientName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["databaseName"] = ExpressionConverter.Convert(__workflow_databaseName);
                var boothClass = new JObject();
                var boothClasspropCount = 0;
                boothClasspropCount++;
                boothClass["Id"] = ExpressionConverter.ConvertO(__workflow_boothClassid);
                if (__workflow_boothClassname != null)
                {
                    boothClass["Name"] = ExpressionConverter.ConvertO(__workflow_boothClassname);
                    boothClasspropCount++;
                }

                if (__workflow_boothClassdescription != null)
                {
                    boothClass["Description"] = ExpressionConverter.ConvertO(__workflow_boothClassdescription);
                    boothClasspropCount++;
                }

                boothClasspropCount++;
                boothClass["KeepWhenCombined"] = ExpressionConverter.ConvertO(__workflow_boothClasskeepWhenCombined);
                boothClasspropCount++;
                boothClass["CountAsInventory"] = ExpressionConverter.ConvertO(__workflow_boothClasscountAsInventory);
                if (__workflow_boothClassprioritity != null)
                {
                    boothClass["Prioritity"] = ExpressionConverter.ConvertO(__workflow_boothClassprioritity);
                    boothClasspropCount++;
                }

                if (__workflow_boothClasscolor != null)
                {
                    boothClass["Color"] = ExpressionConverter.ConvertO(__workflow_boothClasscolor);
                    boothClasspropCount++;
                }

                if (boothClasspropCount > 0)
                {
                    callPayload.Body = boothClass;
                }

                return new ApiConnectionAction<BoothClass>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<BoothClass> ClassesUpdate(Expression<Func<string>> clientName, Expression<Func<string>> boothClassid, Expression<Func<int>> boothClasskeepWhenCombined, Expression<Func<int>> boothClasscountAsInventory, Expression<Func<string>> classId, Expression<Func<string>> databaseName, Expression<Func<string>> boothClassname = null, Expression<Func<string>> boothClassdescription = null, Expression<Func<string>> boothClassprioritity = null, Expression<Func<int>> boothClasscolor = null)
        {
            var __workflow_clientName = WorkflowExpression.Compile(clientName, nameof(clientName), required: true);
            var __workflow_boothClassid = WorkflowExpression.Compile(boothClassid, nameof(boothClassid), required: true);
            var __workflow_boothClasskeepWhenCombined = WorkflowExpression.Compile(boothClasskeepWhenCombined, nameof(boothClasskeepWhenCombined), required: true);
            var __workflow_boothClasscountAsInventory = WorkflowExpression.Compile(boothClasscountAsInventory, nameof(boothClasscountAsInventory), required: true);
            var __workflow_classId = WorkflowExpression.Compile(classId, nameof(classId), required: true);
            var __workflow_databaseName = WorkflowExpression.Compile(databaseName, nameof(databaseName), required: true);
            var __workflow_boothClassname = WorkflowExpression.Compile(boothClassname, nameof(boothClassname), required: false);
            var __workflow_boothClassdescription = WorkflowExpression.Compile(boothClassdescription, nameof(boothClassdescription), required: false);
            var __workflow_boothClassprioritity = WorkflowExpression.Compile(boothClassprioritity, nameof(boothClassprioritity), required: false);
            var __workflow_boothClasscolor = WorkflowExpression.Compile(boothClasscolor, nameof(boothClasscolor), required: false);
            return new DeferredBodyAction<BoothClass>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/classes/update", __workflow_clientName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["classId"] = ExpressionConverter.Convert(__workflow_classId);
                callPayload.Queries["databaseName"] = ExpressionConverter.Convert(__workflow_databaseName);
                var boothClass = new JObject();
                var boothClasspropCount = 0;
                boothClasspropCount++;
                boothClass["Id"] = ExpressionConverter.ConvertO(__workflow_boothClassid);
                if (__workflow_boothClassname != null)
                {
                    boothClass["Name"] = ExpressionConverter.ConvertO(__workflow_boothClassname);
                    boothClasspropCount++;
                }

                if (__workflow_boothClassdescription != null)
                {
                    boothClass["Description"] = ExpressionConverter.ConvertO(__workflow_boothClassdescription);
                    boothClasspropCount++;
                }

                boothClasspropCount++;
                boothClass["KeepWhenCombined"] = ExpressionConverter.ConvertO(__workflow_boothClasskeepWhenCombined);
                boothClasspropCount++;
                boothClass["CountAsInventory"] = ExpressionConverter.ConvertO(__workflow_boothClasscountAsInventory);
                if (__workflow_boothClassprioritity != null)
                {
                    boothClass["Prioritity"] = ExpressionConverter.ConvertO(__workflow_boothClassprioritity);
                    boothClasspropCount++;
                }

                if (__workflow_boothClasscolor != null)
                {
                    boothClass["Color"] = ExpressionConverter.ConvertO(__workflow_boothClasscolor);
                    boothClasspropCount++;
                }

                if (boothClasspropCount > 0)
                {
                    callPayload.Body = boothClass;
                }

                return new ApiConnectionAction<BoothClass>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<JToken> ClassesDelete(Expression<Func<string>> clientName, Expression<Func<string>> classId, Expression<Func<string>> databaseName)
        {
            var __workflow_clientName = WorkflowExpression.Compile(clientName, nameof(clientName), required: true);
            var __workflow_classId = WorkflowExpression.Compile(classId, nameof(classId), required: true);
            var __workflow_databaseName = WorkflowExpression.Compile(databaseName, nameof(databaseName), required: true);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/classes/delete", __workflow_clientName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["classId"] = ExpressionConverter.Convert(__workflow_classId);
                callPayload.Queries["databaseName"] = ExpressionConverter.Convert(__workflow_databaseName);
                return new ApiConnectionAction<JToken>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<ExpocadEvent[]> EventsGetAllEvents(Expression<Func<string>> clientName)
        {
            var __workflow_clientName = WorkflowExpression.Compile(clientName, nameof(clientName), required: true);
            return new DeferredBodyAction<ExpocadEvent[]>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/events", __workflow_clientName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ExpocadEvent[]>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<EventStats> EventsGetEventStatistics(Expression<Func<string>> clientName, Expression<Func<string>> databaseName)
        {
            var __workflow_clientName = WorkflowExpression.Compile(clientName, nameof(clientName), required: true);
            var __workflow_databaseName = WorkflowExpression.Compile(databaseName, nameof(databaseName), required: true);
            return new DeferredBodyAction<EventStats>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/events/stats", __workflow_clientName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["databaseName"] = ExpressionConverter.Convert(__workflow_databaseName);
                return new ApiConnectionAction<EventStats>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<ExpoEventInformation> EventsGetEventInformation(Expression<Func<string>> clientName, Expression<Func<string>> databaseName)
        {
            var __workflow_clientName = WorkflowExpression.Compile(clientName, nameof(clientName), required: true);
            var __workflow_databaseName = WorkflowExpression.Compile(databaseName, nameof(databaseName), required: true);
            return new DeferredBodyAction<ExpoEventInformation>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/events/info", __workflow_clientName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["databaseName"] = ExpressionConverter.Convert(__workflow_databaseName);
                return new ApiConnectionAction<ExpoEventInformation>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<Exhibitor> ExhibitorsGet(Expression<Func<string>> clientName, Expression<Func<string>> id, Expression<Func<string>> databaseName)
        {
            var __workflow_clientName = WorkflowExpression.Compile(clientName, nameof(clientName), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_databaseName = WorkflowExpression.Compile(databaseName, nameof(databaseName), required: true);
            return new DeferredBodyAction<Exhibitor>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/exhibitors", __workflow_clientName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                callPayload.Queries["databaseName"] = ExpressionConverter.Convert(__workflow_databaseName);
                return new ApiConnectionAction<Exhibitor>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<Exhibitor[]> ExhibitorsGetAllExhibitors(Expression<Func<string>> clientName, Expression<Func<string>> databaseName)
        {
            var __workflow_clientName = WorkflowExpression.Compile(clientName, nameof(clientName), required: true);
            var __workflow_databaseName = WorkflowExpression.Compile(databaseName, nameof(databaseName), required: true);
            return new DeferredBodyAction<Exhibitor[]>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/exhibitors/all", __workflow_clientName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["databaseName"] = ExpressionConverter.Convert(__workflow_databaseName);
                return new ApiConnectionAction<Exhibitor[]>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<Exhibitor> ExhibitorsAddExhibitor(Expression<Func<string>> clientName, Expression<Func<string>> exhibitorexhibitorId, Expression<Func<string>> databaseName, Expression<Func<string>> exhibitoraddress1 = null, Expression<Func<string>> exhibitoraddress2 = null, Expression<Func<string>> exhibitorcity = null, Expression<Func<string>> exhibitorcomments = null, Expression<Func<string>> exhibitorcomments2 = null, Expression<Func<string>> exhibitorcontact = null, Expression<Func<string>> exhibitorcountry = null, Expression<Func<string>> exhibitorcellPhone = null, Expression<Func<string>> exhibitordisplayOnDrawing = null, Expression<Func<string>> exhibitordoingBusinessAs = null, Expression<Func<string>> exhibitordoingBusinessAsDisplayOnDrawing = null, Expression<Func<string>> exhibitoremail = null, Expression<Func<string>> exhibitorexhibitorName = null, Expression<Func<string>> exhibitorexhibitorNameLine2 = null, Expression<Func<string>> exhibitorfax = null, Expression<Func<string>> exhibitorfield1 = null, Expression<Func<string>> exhibitorfield2 = null, Expression<Func<string>> exhibitorfield3 = null, Expression<Func<string>> exhibitorfield4 = null, Expression<Func<string>> exhibitorfield5 = null, Expression<Func<string>> exhibitorfield6 = null, Expression<Func<string>> exhibitorfield7 = null, Expression<Func<string>> exhibitorfield8 = null, Expression<Func<string>> exhibitorfield9 = null, Expression<Func<string>> exhibitornickName = null, Expression<Func<string>> exhibitorsalutation = null, Expression<Func<string>> exhibitortitle = null, Expression<Func<string>> exhibitorphone = null, Expression<Func<string>> exhibitorpostalCode = null, Expression<Func<string>> exhibitorprimaryGroup = null, Expression<Func<string>> exhibitorpriorityPoints = null, Expression<Func<string>> exhibitorproductDescription = null, Expression<Func<string>> exhibitorstate = null, Expression<Func<string>> exhibitorwebSite = null)
        {
            var __workflow_clientName = WorkflowExpression.Compile(clientName, nameof(clientName), required: true);
            var __workflow_exhibitorexhibitorId = WorkflowExpression.Compile(exhibitorexhibitorId, nameof(exhibitorexhibitorId), required: true);
            var __workflow_databaseName = WorkflowExpression.Compile(databaseName, nameof(databaseName), required: true);
            var __workflow_exhibitoraddress1 = WorkflowExpression.Compile(exhibitoraddress1, nameof(exhibitoraddress1), required: false);
            var __workflow_exhibitoraddress2 = WorkflowExpression.Compile(exhibitoraddress2, nameof(exhibitoraddress2), required: false);
            var __workflow_exhibitorcity = WorkflowExpression.Compile(exhibitorcity, nameof(exhibitorcity), required: false);
            var __workflow_exhibitorcomments = WorkflowExpression.Compile(exhibitorcomments, nameof(exhibitorcomments), required: false);
            var __workflow_exhibitorcomments2 = WorkflowExpression.Compile(exhibitorcomments2, nameof(exhibitorcomments2), required: false);
            var __workflow_exhibitorcontact = WorkflowExpression.Compile(exhibitorcontact, nameof(exhibitorcontact), required: false);
            var __workflow_exhibitorcountry = WorkflowExpression.Compile(exhibitorcountry, nameof(exhibitorcountry), required: false);
            var __workflow_exhibitorcellPhone = WorkflowExpression.Compile(exhibitorcellPhone, nameof(exhibitorcellPhone), required: false);
            var __workflow_exhibitordisplayOnDrawing = WorkflowExpression.Compile(exhibitordisplayOnDrawing, nameof(exhibitordisplayOnDrawing), required: false);
            var __workflow_exhibitordoingBusinessAs = WorkflowExpression.Compile(exhibitordoingBusinessAs, nameof(exhibitordoingBusinessAs), required: false);
            var __workflow_exhibitordoingBusinessAsDisplayOnDrawing = WorkflowExpression.Compile(exhibitordoingBusinessAsDisplayOnDrawing, nameof(exhibitordoingBusinessAsDisplayOnDrawing), required: false);
            var __workflow_exhibitoremail = WorkflowExpression.Compile(exhibitoremail, nameof(exhibitoremail), required: false);
            var __workflow_exhibitorexhibitorName = WorkflowExpression.Compile(exhibitorexhibitorName, nameof(exhibitorexhibitorName), required: false);
            var __workflow_exhibitorexhibitorNameLine2 = WorkflowExpression.Compile(exhibitorexhibitorNameLine2, nameof(exhibitorexhibitorNameLine2), required: false);
            var __workflow_exhibitorfax = WorkflowExpression.Compile(exhibitorfax, nameof(exhibitorfax), required: false);
            var __workflow_exhibitorfield1 = WorkflowExpression.Compile(exhibitorfield1, nameof(exhibitorfield1), required: false);
            var __workflow_exhibitorfield2 = WorkflowExpression.Compile(exhibitorfield2, nameof(exhibitorfield2), required: false);
            var __workflow_exhibitorfield3 = WorkflowExpression.Compile(exhibitorfield3, nameof(exhibitorfield3), required: false);
            var __workflow_exhibitorfield4 = WorkflowExpression.Compile(exhibitorfield4, nameof(exhibitorfield4), required: false);
            var __workflow_exhibitorfield5 = WorkflowExpression.Compile(exhibitorfield5, nameof(exhibitorfield5), required: false);
            var __workflow_exhibitorfield6 = WorkflowExpression.Compile(exhibitorfield6, nameof(exhibitorfield6), required: false);
            var __workflow_exhibitorfield7 = WorkflowExpression.Compile(exhibitorfield7, nameof(exhibitorfield7), required: false);
            var __workflow_exhibitorfield8 = WorkflowExpression.Compile(exhibitorfield8, nameof(exhibitorfield8), required: false);
            var __workflow_exhibitorfield9 = WorkflowExpression.Compile(exhibitorfield9, nameof(exhibitorfield9), required: false);
            var __workflow_exhibitornickName = WorkflowExpression.Compile(exhibitornickName, nameof(exhibitornickName), required: false);
            var __workflow_exhibitorsalutation = WorkflowExpression.Compile(exhibitorsalutation, nameof(exhibitorsalutation), required: false);
            var __workflow_exhibitortitle = WorkflowExpression.Compile(exhibitortitle, nameof(exhibitortitle), required: false);
            var __workflow_exhibitorphone = WorkflowExpression.Compile(exhibitorphone, nameof(exhibitorphone), required: false);
            var __workflow_exhibitorpostalCode = WorkflowExpression.Compile(exhibitorpostalCode, nameof(exhibitorpostalCode), required: false);
            var __workflow_exhibitorprimaryGroup = WorkflowExpression.Compile(exhibitorprimaryGroup, nameof(exhibitorprimaryGroup), required: false);
            var __workflow_exhibitorpriorityPoints = WorkflowExpression.Compile(exhibitorpriorityPoints, nameof(exhibitorpriorityPoints), required: false);
            var __workflow_exhibitorproductDescription = WorkflowExpression.Compile(exhibitorproductDescription, nameof(exhibitorproductDescription), required: false);
            var __workflow_exhibitorstate = WorkflowExpression.Compile(exhibitorstate, nameof(exhibitorstate), required: false);
            var __workflow_exhibitorwebSite = WorkflowExpression.Compile(exhibitorwebSite, nameof(exhibitorwebSite), required: false);
            return new DeferredBodyAction<Exhibitor>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/exhibitors/add", __workflow_clientName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["databaseName"] = ExpressionConverter.Convert(__workflow_databaseName);
                var exhibitor = new JObject();
                var exhibitorpropCount = 0;
                if (__workflow_exhibitoraddress1 != null)
                {
                    exhibitor["Address1"] = ExpressionConverter.ConvertO(__workflow_exhibitoraddress1);
                    exhibitorpropCount++;
                }

                if (__workflow_exhibitoraddress2 != null)
                {
                    exhibitor["Address2"] = ExpressionConverter.ConvertO(__workflow_exhibitoraddress2);
                    exhibitorpropCount++;
                }

                if (__workflow_exhibitorcity != null)
                {
                    exhibitor["City"] = ExpressionConverter.ConvertO(__workflow_exhibitorcity);
                    exhibitorpropCount++;
                }

                if (__workflow_exhibitorcomments != null)
                {
                    exhibitor["Comments"] = ExpressionConverter.ConvertO(__workflow_exhibitorcomments);
                    exhibitorpropCount++;
                }

                if (__workflow_exhibitorcomments2 != null)
                {
                    exhibitor["Comments2"] = ExpressionConverter.ConvertO(__workflow_exhibitorcomments2);
                    exhibitorpropCount++;
                }

                if (__workflow_exhibitorcontact != null)
                {
                    exhibitor["Contact"] = ExpressionConverter.ConvertO(__workflow_exhibitorcontact);
                    exhibitorpropCount++;
                }

                if (__workflow_exhibitorcountry != null)
                {
                    exhibitor["Country"] = ExpressionConverter.ConvertO(__workflow_exhibitorcountry);
                    exhibitorpropCount++;
                }

                if (__workflow_exhibitorcellPhone != null)
                {
                    exhibitor["CellPhone"] = ExpressionConverter.ConvertO(__workflow_exhibitorcellPhone);
                    exhibitorpropCount++;
                }

                if (__workflow_exhibitordisplayOnDrawing != null)
                {
                    exhibitor["DisplayOnDrawing"] = ExpressionConverter.ConvertO(__workflow_exhibitordisplayOnDrawing);
                    exhibitorpropCount++;
                }

                if (__workflow_exhibitordoingBusinessAs != null)
                {
                    exhibitor["DoingBusinessAs"] = ExpressionConverter.ConvertO(__workflow_exhibitordoingBusinessAs);
                    exhibitorpropCount++;
                }

                if (__workflow_exhibitordoingBusinessAsDisplayOnDrawing != null)
                {
                    exhibitor["DoingBusinessAsDisplayOnDrawing"] = ExpressionConverter.ConvertO(__workflow_exhibitordoingBusinessAsDisplayOnDrawing);
                    exhibitorpropCount++;
                }

                if (__workflow_exhibitoremail != null)
                {
                    exhibitor["Email"] = ExpressionConverter.ConvertO(__workflow_exhibitoremail);
                    exhibitorpropCount++;
                }

                exhibitorpropCount++;
                exhibitor["ExhibitorId"] = ExpressionConverter.ConvertO(__workflow_exhibitorexhibitorId);
                if (__workflow_exhibitorexhibitorName != null)
                {
                    exhibitor["ExhibitorName"] = ExpressionConverter.ConvertO(__workflow_exhibitorexhibitorName);
                    exhibitorpropCount++;
                }

                if (__workflow_exhibitorexhibitorNameLine2 != null)
                {
                    exhibitor["ExhibitorNameLine2"] = ExpressionConverter.ConvertO(__workflow_exhibitorexhibitorNameLine2);
                    exhibitorpropCount++;
                }

                if (__workflow_exhibitorfax != null)
                {
                    exhibitor["Fax"] = ExpressionConverter.ConvertO(__workflow_exhibitorfax);
                    exhibitorpropCount++;
                }

                if (__workflow_exhibitorfield1 != null)
                {
                    exhibitor["Field1"] = ExpressionConverter.ConvertO(__workflow_exhibitorfield1);
                    exhibitorpropCount++;
                }

                if (__workflow_exhibitorfield2 != null)
                {
                    exhibitor["Field2"] = ExpressionConverter.ConvertO(__workflow_exhibitorfield2);
                    exhibitorpropCount++;
                }

                if (__workflow_exhibitorfield3 != null)
                {
                    exhibitor["Field3"] = ExpressionConverter.ConvertO(__workflow_exhibitorfield3);
                    exhibitorpropCount++;
                }

                if (__workflow_exhibitorfield4 != null)
                {
                    exhibitor["Field4"] = ExpressionConverter.ConvertO(__workflow_exhibitorfield4);
                    exhibitorpropCount++;
                }

                if (__workflow_exhibitorfield5 != null)
                {
                    exhibitor["Field5"] = ExpressionConverter.ConvertO(__workflow_exhibitorfield5);
                    exhibitorpropCount++;
                }

                if (__workflow_exhibitorfield6 != null)
                {
                    exhibitor["Field6"] = ExpressionConverter.ConvertO(__workflow_exhibitorfield6);
                    exhibitorpropCount++;
                }

                if (__workflow_exhibitorfield7 != null)
                {
                    exhibitor["Field7"] = ExpressionConverter.ConvertO(__workflow_exhibitorfield7);
                    exhibitorpropCount++;
                }

                if (__workflow_exhibitorfield8 != null)
                {
                    exhibitor["Field8"] = ExpressionConverter.ConvertO(__workflow_exhibitorfield8);
                    exhibitorpropCount++;
                }

                if (__workflow_exhibitorfield9 != null)
                {
                    exhibitor["Field9"] = ExpressionConverter.ConvertO(__workflow_exhibitorfield9);
                    exhibitorpropCount++;
                }

                if (__workflow_exhibitornickName != null)
                {
                    exhibitor["NickName"] = ExpressionConverter.ConvertO(__workflow_exhibitornickName);
                    exhibitorpropCount++;
                }

                if (__workflow_exhibitorsalutation != null)
                {
                    exhibitor["Salutation"] = ExpressionConverter.ConvertO(__workflow_exhibitorsalutation);
                    exhibitorpropCount++;
                }

                if (__workflow_exhibitortitle != null)
                {
                    exhibitor["Title"] = ExpressionConverter.ConvertO(__workflow_exhibitortitle);
                    exhibitorpropCount++;
                }

                if (__workflow_exhibitorphone != null)
                {
                    exhibitor["Phone"] = ExpressionConverter.ConvertO(__workflow_exhibitorphone);
                    exhibitorpropCount++;
                }

                if (__workflow_exhibitorpostalCode != null)
                {
                    exhibitor["PostalCode"] = ExpressionConverter.ConvertO(__workflow_exhibitorpostalCode);
                    exhibitorpropCount++;
                }

                if (__workflow_exhibitorprimaryGroup != null)
                {
                    exhibitor["PrimaryGroup"] = ExpressionConverter.ConvertO(__workflow_exhibitorprimaryGroup);
                    exhibitorpropCount++;
                }

                if (__workflow_exhibitorpriorityPoints != null)
                {
                    exhibitor["PriorityPoints"] = ExpressionConverter.ConvertO(__workflow_exhibitorpriorityPoints);
                    exhibitorpropCount++;
                }

                if (__workflow_exhibitorproductDescription != null)
                {
                    exhibitor["ProductDescription"] = ExpressionConverter.ConvertO(__workflow_exhibitorproductDescription);
                    exhibitorpropCount++;
                }

                if (__workflow_exhibitorstate != null)
                {
                    exhibitor["State"] = ExpressionConverter.ConvertO(__workflow_exhibitorstate);
                    exhibitorpropCount++;
                }

                if (__workflow_exhibitorwebSite != null)
                {
                    exhibitor["WebSite"] = ExpressionConverter.ConvertO(__workflow_exhibitorwebSite);
                    exhibitorpropCount++;
                }

                if (exhibitorpropCount > 0)
                {
                    callPayload.Body = exhibitor;
                }

                return new ApiConnectionAction<Exhibitor>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<Exhibitor> ExhibitorsUpdateExhibitor(Expression<Func<string>> clientName, Expression<Func<string>> exhibitorexhibitorId, Expression<Func<string>> id, Expression<Func<string>> databaseName, Expression<Func<string>> exhibitoraddress1 = null, Expression<Func<string>> exhibitoraddress2 = null, Expression<Func<string>> exhibitorcity = null, Expression<Func<string>> exhibitorcomments = null, Expression<Func<string>> exhibitorcomments2 = null, Expression<Func<string>> exhibitorcontact = null, Expression<Func<string>> exhibitorcountry = null, Expression<Func<string>> exhibitorcellPhone = null, Expression<Func<string>> exhibitordisplayOnDrawing = null, Expression<Func<string>> exhibitordoingBusinessAs = null, Expression<Func<string>> exhibitordoingBusinessAsDisplayOnDrawing = null, Expression<Func<string>> exhibitoremail = null, Expression<Func<string>> exhibitorexhibitorName = null, Expression<Func<string>> exhibitorexhibitorNameLine2 = null, Expression<Func<string>> exhibitorfax = null, Expression<Func<string>> exhibitorfield1 = null, Expression<Func<string>> exhibitorfield2 = null, Expression<Func<string>> exhibitorfield3 = null, Expression<Func<string>> exhibitorfield4 = null, Expression<Func<string>> exhibitorfield5 = null, Expression<Func<string>> exhibitorfield6 = null, Expression<Func<string>> exhibitorfield7 = null, Expression<Func<string>> exhibitorfield8 = null, Expression<Func<string>> exhibitorfield9 = null, Expression<Func<string>> exhibitornickName = null, Expression<Func<string>> exhibitorsalutation = null, Expression<Func<string>> exhibitortitle = null, Expression<Func<string>> exhibitorphone = null, Expression<Func<string>> exhibitorpostalCode = null, Expression<Func<string>> exhibitorprimaryGroup = null, Expression<Func<string>> exhibitorpriorityPoints = null, Expression<Func<string>> exhibitorproductDescription = null, Expression<Func<string>> exhibitorstate = null, Expression<Func<string>> exhibitorwebSite = null)
        {
            var __workflow_clientName = WorkflowExpression.Compile(clientName, nameof(clientName), required: true);
            var __workflow_exhibitorexhibitorId = WorkflowExpression.Compile(exhibitorexhibitorId, nameof(exhibitorexhibitorId), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_databaseName = WorkflowExpression.Compile(databaseName, nameof(databaseName), required: true);
            var __workflow_exhibitoraddress1 = WorkflowExpression.Compile(exhibitoraddress1, nameof(exhibitoraddress1), required: false);
            var __workflow_exhibitoraddress2 = WorkflowExpression.Compile(exhibitoraddress2, nameof(exhibitoraddress2), required: false);
            var __workflow_exhibitorcity = WorkflowExpression.Compile(exhibitorcity, nameof(exhibitorcity), required: false);
            var __workflow_exhibitorcomments = WorkflowExpression.Compile(exhibitorcomments, nameof(exhibitorcomments), required: false);
            var __workflow_exhibitorcomments2 = WorkflowExpression.Compile(exhibitorcomments2, nameof(exhibitorcomments2), required: false);
            var __workflow_exhibitorcontact = WorkflowExpression.Compile(exhibitorcontact, nameof(exhibitorcontact), required: false);
            var __workflow_exhibitorcountry = WorkflowExpression.Compile(exhibitorcountry, nameof(exhibitorcountry), required: false);
            var __workflow_exhibitorcellPhone = WorkflowExpression.Compile(exhibitorcellPhone, nameof(exhibitorcellPhone), required: false);
            var __workflow_exhibitordisplayOnDrawing = WorkflowExpression.Compile(exhibitordisplayOnDrawing, nameof(exhibitordisplayOnDrawing), required: false);
            var __workflow_exhibitordoingBusinessAs = WorkflowExpression.Compile(exhibitordoingBusinessAs, nameof(exhibitordoingBusinessAs), required: false);
            var __workflow_exhibitordoingBusinessAsDisplayOnDrawing = WorkflowExpression.Compile(exhibitordoingBusinessAsDisplayOnDrawing, nameof(exhibitordoingBusinessAsDisplayOnDrawing), required: false);
            var __workflow_exhibitoremail = WorkflowExpression.Compile(exhibitoremail, nameof(exhibitoremail), required: false);
            var __workflow_exhibitorexhibitorName = WorkflowExpression.Compile(exhibitorexhibitorName, nameof(exhibitorexhibitorName), required: false);
            var __workflow_exhibitorexhibitorNameLine2 = WorkflowExpression.Compile(exhibitorexhibitorNameLine2, nameof(exhibitorexhibitorNameLine2), required: false);
            var __workflow_exhibitorfax = WorkflowExpression.Compile(exhibitorfax, nameof(exhibitorfax), required: false);
            var __workflow_exhibitorfield1 = WorkflowExpression.Compile(exhibitorfield1, nameof(exhibitorfield1), required: false);
            var __workflow_exhibitorfield2 = WorkflowExpression.Compile(exhibitorfield2, nameof(exhibitorfield2), required: false);
            var __workflow_exhibitorfield3 = WorkflowExpression.Compile(exhibitorfield3, nameof(exhibitorfield3), required: false);
            var __workflow_exhibitorfield4 = WorkflowExpression.Compile(exhibitorfield4, nameof(exhibitorfield4), required: false);
            var __workflow_exhibitorfield5 = WorkflowExpression.Compile(exhibitorfield5, nameof(exhibitorfield5), required: false);
            var __workflow_exhibitorfield6 = WorkflowExpression.Compile(exhibitorfield6, nameof(exhibitorfield6), required: false);
            var __workflow_exhibitorfield7 = WorkflowExpression.Compile(exhibitorfield7, nameof(exhibitorfield7), required: false);
            var __workflow_exhibitorfield8 = WorkflowExpression.Compile(exhibitorfield8, nameof(exhibitorfield8), required: false);
            var __workflow_exhibitorfield9 = WorkflowExpression.Compile(exhibitorfield9, nameof(exhibitorfield9), required: false);
            var __workflow_exhibitornickName = WorkflowExpression.Compile(exhibitornickName, nameof(exhibitornickName), required: false);
            var __workflow_exhibitorsalutation = WorkflowExpression.Compile(exhibitorsalutation, nameof(exhibitorsalutation), required: false);
            var __workflow_exhibitortitle = WorkflowExpression.Compile(exhibitortitle, nameof(exhibitortitle), required: false);
            var __workflow_exhibitorphone = WorkflowExpression.Compile(exhibitorphone, nameof(exhibitorphone), required: false);
            var __workflow_exhibitorpostalCode = WorkflowExpression.Compile(exhibitorpostalCode, nameof(exhibitorpostalCode), required: false);
            var __workflow_exhibitorprimaryGroup = WorkflowExpression.Compile(exhibitorprimaryGroup, nameof(exhibitorprimaryGroup), required: false);
            var __workflow_exhibitorpriorityPoints = WorkflowExpression.Compile(exhibitorpriorityPoints, nameof(exhibitorpriorityPoints), required: false);
            var __workflow_exhibitorproductDescription = WorkflowExpression.Compile(exhibitorproductDescription, nameof(exhibitorproductDescription), required: false);
            var __workflow_exhibitorstate = WorkflowExpression.Compile(exhibitorstate, nameof(exhibitorstate), required: false);
            var __workflow_exhibitorwebSite = WorkflowExpression.Compile(exhibitorwebSite, nameof(exhibitorwebSite), required: false);
            return new DeferredBodyAction<Exhibitor>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/exhibitors/update", __workflow_clientName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                callPayload.Queries["databaseName"] = ExpressionConverter.Convert(__workflow_databaseName);
                var exhibitor = new JObject();
                var exhibitorpropCount = 0;
                if (__workflow_exhibitoraddress1 != null)
                {
                    exhibitor["Address1"] = ExpressionConverter.ConvertO(__workflow_exhibitoraddress1);
                    exhibitorpropCount++;
                }

                if (__workflow_exhibitoraddress2 != null)
                {
                    exhibitor["Address2"] = ExpressionConverter.ConvertO(__workflow_exhibitoraddress2);
                    exhibitorpropCount++;
                }

                if (__workflow_exhibitorcity != null)
                {
                    exhibitor["City"] = ExpressionConverter.ConvertO(__workflow_exhibitorcity);
                    exhibitorpropCount++;
                }

                if (__workflow_exhibitorcomments != null)
                {
                    exhibitor["Comments"] = ExpressionConverter.ConvertO(__workflow_exhibitorcomments);
                    exhibitorpropCount++;
                }

                if (__workflow_exhibitorcomments2 != null)
                {
                    exhibitor["Comments2"] = ExpressionConverter.ConvertO(__workflow_exhibitorcomments2);
                    exhibitorpropCount++;
                }

                if (__workflow_exhibitorcontact != null)
                {
                    exhibitor["Contact"] = ExpressionConverter.ConvertO(__workflow_exhibitorcontact);
                    exhibitorpropCount++;
                }

                if (__workflow_exhibitorcountry != null)
                {
                    exhibitor["Country"] = ExpressionConverter.ConvertO(__workflow_exhibitorcountry);
                    exhibitorpropCount++;
                }

                if (__workflow_exhibitorcellPhone != null)
                {
                    exhibitor["CellPhone"] = ExpressionConverter.ConvertO(__workflow_exhibitorcellPhone);
                    exhibitorpropCount++;
                }

                if (__workflow_exhibitordisplayOnDrawing != null)
                {
                    exhibitor["DisplayOnDrawing"] = ExpressionConverter.ConvertO(__workflow_exhibitordisplayOnDrawing);
                    exhibitorpropCount++;
                }

                if (__workflow_exhibitordoingBusinessAs != null)
                {
                    exhibitor["DoingBusinessAs"] = ExpressionConverter.ConvertO(__workflow_exhibitordoingBusinessAs);
                    exhibitorpropCount++;
                }

                if (__workflow_exhibitordoingBusinessAsDisplayOnDrawing != null)
                {
                    exhibitor["DoingBusinessAsDisplayOnDrawing"] = ExpressionConverter.ConvertO(__workflow_exhibitordoingBusinessAsDisplayOnDrawing);
                    exhibitorpropCount++;
                }

                if (__workflow_exhibitoremail != null)
                {
                    exhibitor["Email"] = ExpressionConverter.ConvertO(__workflow_exhibitoremail);
                    exhibitorpropCount++;
                }

                exhibitorpropCount++;
                exhibitor["ExhibitorId"] = ExpressionConverter.ConvertO(__workflow_exhibitorexhibitorId);
                if (__workflow_exhibitorexhibitorName != null)
                {
                    exhibitor["ExhibitorName"] = ExpressionConverter.ConvertO(__workflow_exhibitorexhibitorName);
                    exhibitorpropCount++;
                }

                if (__workflow_exhibitorexhibitorNameLine2 != null)
                {
                    exhibitor["ExhibitorNameLine2"] = ExpressionConverter.ConvertO(__workflow_exhibitorexhibitorNameLine2);
                    exhibitorpropCount++;
                }

                if (__workflow_exhibitorfax != null)
                {
                    exhibitor["Fax"] = ExpressionConverter.ConvertO(__workflow_exhibitorfax);
                    exhibitorpropCount++;
                }

                if (__workflow_exhibitorfield1 != null)
                {
                    exhibitor["Field1"] = ExpressionConverter.ConvertO(__workflow_exhibitorfield1);
                    exhibitorpropCount++;
                }

                if (__workflow_exhibitorfield2 != null)
                {
                    exhibitor["Field2"] = ExpressionConverter.ConvertO(__workflow_exhibitorfield2);
                    exhibitorpropCount++;
                }

                if (__workflow_exhibitorfield3 != null)
                {
                    exhibitor["Field3"] = ExpressionConverter.ConvertO(__workflow_exhibitorfield3);
                    exhibitorpropCount++;
                }

                if (__workflow_exhibitorfield4 != null)
                {
                    exhibitor["Field4"] = ExpressionConverter.ConvertO(__workflow_exhibitorfield4);
                    exhibitorpropCount++;
                }

                if (__workflow_exhibitorfield5 != null)
                {
                    exhibitor["Field5"] = ExpressionConverter.ConvertO(__workflow_exhibitorfield5);
                    exhibitorpropCount++;
                }

                if (__workflow_exhibitorfield6 != null)
                {
                    exhibitor["Field6"] = ExpressionConverter.ConvertO(__workflow_exhibitorfield6);
                    exhibitorpropCount++;
                }

                if (__workflow_exhibitorfield7 != null)
                {
                    exhibitor["Field7"] = ExpressionConverter.ConvertO(__workflow_exhibitorfield7);
                    exhibitorpropCount++;
                }

                if (__workflow_exhibitorfield8 != null)
                {
                    exhibitor["Field8"] = ExpressionConverter.ConvertO(__workflow_exhibitorfield8);
                    exhibitorpropCount++;
                }

                if (__workflow_exhibitorfield9 != null)
                {
                    exhibitor["Field9"] = ExpressionConverter.ConvertO(__workflow_exhibitorfield9);
                    exhibitorpropCount++;
                }

                if (__workflow_exhibitornickName != null)
                {
                    exhibitor["NickName"] = ExpressionConverter.ConvertO(__workflow_exhibitornickName);
                    exhibitorpropCount++;
                }

                if (__workflow_exhibitorsalutation != null)
                {
                    exhibitor["Salutation"] = ExpressionConverter.ConvertO(__workflow_exhibitorsalutation);
                    exhibitorpropCount++;
                }

                if (__workflow_exhibitortitle != null)
                {
                    exhibitor["Title"] = ExpressionConverter.ConvertO(__workflow_exhibitortitle);
                    exhibitorpropCount++;
                }

                if (__workflow_exhibitorphone != null)
                {
                    exhibitor["Phone"] = ExpressionConverter.ConvertO(__workflow_exhibitorphone);
                    exhibitorpropCount++;
                }

                if (__workflow_exhibitorpostalCode != null)
                {
                    exhibitor["PostalCode"] = ExpressionConverter.ConvertO(__workflow_exhibitorpostalCode);
                    exhibitorpropCount++;
                }

                if (__workflow_exhibitorprimaryGroup != null)
                {
                    exhibitor["PrimaryGroup"] = ExpressionConverter.ConvertO(__workflow_exhibitorprimaryGroup);
                    exhibitorpropCount++;
                }

                if (__workflow_exhibitorpriorityPoints != null)
                {
                    exhibitor["PriorityPoints"] = ExpressionConverter.ConvertO(__workflow_exhibitorpriorityPoints);
                    exhibitorpropCount++;
                }

                if (__workflow_exhibitorproductDescription != null)
                {
                    exhibitor["ProductDescription"] = ExpressionConverter.ConvertO(__workflow_exhibitorproductDescription);
                    exhibitorpropCount++;
                }

                if (__workflow_exhibitorstate != null)
                {
                    exhibitor["State"] = ExpressionConverter.ConvertO(__workflow_exhibitorstate);
                    exhibitorpropCount++;
                }

                if (__workflow_exhibitorwebSite != null)
                {
                    exhibitor["WebSite"] = ExpressionConverter.ConvertO(__workflow_exhibitorwebSite);
                    exhibitorpropCount++;
                }

                if (exhibitorpropCount > 0)
                {
                    callPayload.Body = exhibitor;
                }

                return new ApiConnectionAction<Exhibitor>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<JToken> ExhibitorsDeleteExhibitor(Expression<Func<string>> clientName, Expression<Func<string>> id, Expression<Func<string>> databaseName)
        {
            var __workflow_clientName = WorkflowExpression.Compile(clientName, nameof(clientName), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_databaseName = WorkflowExpression.Compile(databaseName, nameof(databaseName), required: true);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/exhibitors/delete", __workflow_clientName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                callPayload.Queries["databaseName"] = ExpressionConverter.Convert(__workflow_databaseName);
                return new ApiConnectionAction<JToken>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<Transaction[]> FinancialsGetAllTransactions(Expression<Func<string>> clientName, Expression<Func<string>> databaseName, Expression<Func<string>> startDate = null, Expression<Func<string>> endDate = null, Expression<Func<string>> exhibitorId = null, Expression<Func<string>> boothNumber = null, Expression<Func<string>> expocadUser = null, Expression<Func<string>> glCode = null, Expression<Func<reversedFilterInput>> reversedFilter = null)
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
            return new DeferredBodyAction<Transaction[]>(() =>
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
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<BoothFinancial> FinancialsGet(Expression<Func<string>> clientName, Expression<Func<string>> boothNumber, Expression<Func<string>> databaseName)
        {
            var __workflow_clientName = WorkflowExpression.Compile(clientName, nameof(clientName), required: true);
            var __workflow_boothNumber = WorkflowExpression.Compile(boothNumber, nameof(boothNumber), required: true);
            var __workflow_databaseName = WorkflowExpression.Compile(databaseName, nameof(databaseName), required: true);
            return new DeferredBodyAction<BoothFinancial>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/financials/booths", __workflow_clientName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["boothNumber"] = ExpressionConverter.Convert(__workflow_boothNumber);
                callPayload.Queries["databaseName"] = ExpressionConverter.Convert(__workflow_databaseName);
                return new ApiConnectionAction<BoothFinancial>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<Invoice> FinancialsGetInvoice(Expression<Func<string>> clientName, Expression<Func<string>> databaseName, Expression<Func<string>> invoiceNo = null, Expression<Func<string>> exhibitorId = null)
        {
            var __workflow_clientName = WorkflowExpression.Compile(clientName, nameof(clientName), required: true);
            var __workflow_databaseName = WorkflowExpression.Compile(databaseName, nameof(databaseName), required: true);
            var __workflow_invoiceNo = WorkflowExpression.Compile(invoiceNo, nameof(invoiceNo), required: false);
            var __workflow_exhibitorId = WorkflowExpression.Compile(exhibitorId, nameof(exhibitorId), required: false);
            return new DeferredBodyAction<Invoice>(() =>
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
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<Invoice[]> FinancialsGetAllInvoices(Expression<Func<string>> clientName, Expression<Func<string>> databaseName)
        {
            var __workflow_clientName = WorkflowExpression.Compile(clientName, nameof(clientName), required: true);
            var __workflow_databaseName = WorkflowExpression.Compile(databaseName, nameof(databaseName), required: true);
            return new DeferredBodyAction<Invoice[]>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/financials/invoices/all", __workflow_clientName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["databaseName"] = ExpressionConverter.Convert(__workflow_databaseName);
                return new ApiConnectionAction<Invoice[]>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<MasterRequestItem[]> FinancialsGetRequestItemList(Expression<Func<string>> clientName, Expression<Func<string>> databaseName, Expression<Func<string>> glCode = null, Expression<Func<string>> transactionCode = null)
        {
            var __workflow_clientName = WorkflowExpression.Compile(clientName, nameof(clientName), required: true);
            var __workflow_databaseName = WorkflowExpression.Compile(databaseName, nameof(databaseName), required: true);
            var __workflow_glCode = WorkflowExpression.Compile(glCode, nameof(glCode), required: false);
            var __workflow_transactionCode = WorkflowExpression.Compile(transactionCode, nameof(transactionCode), required: false);
            return new DeferredBodyAction<MasterRequestItem[]>(() =>
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
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<InvoiceRequestItem[]> FinancialsGetAssignedRequestItems(Expression<Func<string>> clientName, Expression<Func<string>> databaseName, Expression<Func<string>> exhibitorId = null, Expression<Func<string>> invoiceNumber = null, Expression<Func<string>> startDate = null, Expression<Func<string>> endDate = null, Expression<Func<string>> booth = null, Expression<Func<string>> glCode = null, Expression<Func<string>> transactionCode = null)
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
            return new DeferredBodyAction<InvoiceRequestItem[]>(() =>
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
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<PaymentTypeItem[]> FinancialsGetPaymentTypeList(Expression<Func<string>> clientName, Expression<Func<string>> databaseName)
        {
            var __workflow_clientName = WorkflowExpression.Compile(clientName, nameof(clientName), required: true);
            var __workflow_databaseName = WorkflowExpression.Compile(databaseName, nameof(databaseName), required: true);
            return new DeferredBodyAction<PaymentTypeItem[]>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/financials/paymenttypelist", __workflow_clientName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["databaseName"] = ExpressionConverter.Convert(__workflow_databaseName);
                return new ApiConnectionAction<PaymentTypeItem[]>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<InvoicePayment[]> FinancialsGetPayments(Expression<Func<string>> clientName, Expression<Func<string>> databaseName, Expression<Func<string>> exhibitorId = null, Expression<Func<string>> depositId = null, Expression<Func<string>> invoiceNumber = null, Expression<Func<string>> startDate = null, Expression<Func<string>> endDate = null, Expression<Func<string>> paymentTypeCategory = null)
        {
            var __workflow_clientName = WorkflowExpression.Compile(clientName, nameof(clientName), required: true);
            var __workflow_databaseName = WorkflowExpression.Compile(databaseName, nameof(databaseName), required: true);
            var __workflow_exhibitorId = WorkflowExpression.Compile(exhibitorId, nameof(exhibitorId), required: false);
            var __workflow_depositId = WorkflowExpression.Compile(depositId, nameof(depositId), required: false);
            var __workflow_invoiceNumber = WorkflowExpression.Compile(invoiceNumber, nameof(invoiceNumber), required: false);
            var __workflow_startDate = WorkflowExpression.Compile(startDate, nameof(startDate), required: false);
            var __workflow_endDate = WorkflowExpression.Compile(endDate, nameof(endDate), required: false);
            var __workflow_paymentTypeCategory = WorkflowExpression.Compile(paymentTypeCategory, nameof(paymentTypeCategory), required: false);
            return new DeferredBodyAction<InvoicePayment[]>(() =>
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
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<Pavilion[]> PavilionsGetAllPavilions(Expression<Func<string>> clientName, Expression<Func<string>> databaseName)
        {
            var __workflow_clientName = WorkflowExpression.Compile(clientName, nameof(clientName), required: true);
            var __workflow_databaseName = WorkflowExpression.Compile(databaseName, nameof(databaseName), required: true);
            return new DeferredBodyAction<Pavilion[]>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/pavilions/all", __workflow_clientName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["databaseName"] = ExpressionConverter.Convert(__workflow_databaseName);
                return new ApiConnectionAction<Pavilion[]>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<RatePlan> RatePlansGetDefaultRatePlan(Expression<Func<string>> clientName, Expression<Func<string>> databaseName)
        {
            var __workflow_clientName = WorkflowExpression.Compile(clientName, nameof(clientName), required: true);
            var __workflow_databaseName = WorkflowExpression.Compile(databaseName, nameof(databaseName), required: true);
            return new DeferredBodyAction<RatePlan>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/rateplans/default", __workflow_clientName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["databaseName"] = ExpressionConverter.Convert(__workflow_databaseName);
                return new ApiConnectionAction<RatePlan>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<JToken> RatePlansSetDefaultRatePlan(Expression<Func<string>> clientName, Expression<Func<string>> databaseName, Expression<Func<string>> name)
        {
            var __workflow_clientName = WorkflowExpression.Compile(clientName, nameof(clientName), required: true);
            var __workflow_databaseName = WorkflowExpression.Compile(databaseName, nameof(databaseName), required: true);
            var __workflow_name = WorkflowExpression.Compile(name, nameof(name), required: true);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/rateplans/default", __workflow_clientName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["databaseName"] = ExpressionConverter.Convert(__workflow_databaseName);
                callPayload.Queries["name"] = ExpressionConverter.Convert(__workflow_name);
                return new ApiConnectionAction<JToken>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<RatePlan[]> RatePlansGetAllRatePlans(Expression<Func<string>> clientName, Expression<Func<string>> databaseName)
        {
            var __workflow_clientName = WorkflowExpression.Compile(clientName, nameof(clientName), required: true);
            var __workflow_databaseName = WorkflowExpression.Compile(databaseName, nameof(databaseName), required: true);
            return new DeferredBodyAction<RatePlan[]>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/rateplans/all", __workflow_clientName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["databaseName"] = ExpressionConverter.Convert(__workflow_databaseName);
                return new ApiConnectionAction<RatePlan[]>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<RatePlan> RatePlansAddRatePlan(Expression<Func<string>> clientName, Expression<Func<string>> databaseName, Expression<Func<string>> ratePlanname, Expression<Func<string>> ratePlanshortCode, Expression<Func<double>> ratePlangrossRate, Expression<Func<double>> ratePlanfixedDiscountRate, Expression<Func<double>> ratePlanpercentDiscountRate, Expression<Func<bool>> ratePlanisFixed)
        {
            var __workflow_clientName = WorkflowExpression.Compile(clientName, nameof(clientName), required: true);
            var __workflow_databaseName = WorkflowExpression.Compile(databaseName, nameof(databaseName), required: true);
            var __workflow_ratePlanname = WorkflowExpression.Compile(ratePlanname, nameof(ratePlanname), required: true);
            var __workflow_ratePlanshortCode = WorkflowExpression.Compile(ratePlanshortCode, nameof(ratePlanshortCode), required: true);
            var __workflow_ratePlangrossRate = WorkflowExpression.Compile(ratePlangrossRate, nameof(ratePlangrossRate), required: true);
            var __workflow_ratePlanfixedDiscountRate = WorkflowExpression.Compile(ratePlanfixedDiscountRate, nameof(ratePlanfixedDiscountRate), required: true);
            var __workflow_ratePlanpercentDiscountRate = WorkflowExpression.Compile(ratePlanpercentDiscountRate, nameof(ratePlanpercentDiscountRate), required: true);
            var __workflow_ratePlanisFixed = WorkflowExpression.Compile(ratePlanisFixed, nameof(ratePlanisFixed), required: true);
            return new DeferredBodyAction<RatePlan>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/rateplans/add", __workflow_clientName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["databaseName"] = ExpressionConverter.Convert(__workflow_databaseName);
                var ratePlan = new JObject();
                var ratePlanpropCount = 0;
                ratePlanpropCount++;
                ratePlan["Name"] = ExpressionConverter.ConvertO(__workflow_ratePlanname);
                ratePlanpropCount++;
                ratePlan["ShortCode"] = ExpressionConverter.ConvertO(__workflow_ratePlanshortCode);
                ratePlanpropCount++;
                ratePlan["GrossRate"] = ExpressionConverter.ConvertO(__workflow_ratePlangrossRate);
                ratePlanpropCount++;
                ratePlan["FixedDiscountRate"] = ExpressionConverter.ConvertO(__workflow_ratePlanfixedDiscountRate);
                ratePlanpropCount++;
                ratePlan["PercentDiscountRate"] = ExpressionConverter.ConvertO(__workflow_ratePlanpercentDiscountRate);
                ratePlanpropCount++;
                ratePlan["IsFixed"] = ExpressionConverter.ConvertO(__workflow_ratePlanisFixed);
                if (ratePlanpropCount > 0)
                {
                    callPayload.Body = ratePlan;
                }

                return new ApiConnectionAction<RatePlan>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<ShowInShow[]> ShowInShowsGetAllShowinShows(Expression<Func<string>> clientName, Expression<Func<string>> databaseName)
        {
            var __workflow_clientName = WorkflowExpression.Compile(clientName, nameof(clientName), required: true);
            var __workflow_databaseName = WorkflowExpression.Compile(databaseName, nameof(databaseName), required: true);
            return new DeferredBodyAction<ShowInShow[]>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/showinshows/all", __workflow_clientName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["databaseName"] = ExpressionConverter.Convert(__workflow_databaseName);
                return new ApiConnectionAction<ShowInShow[]>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
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
