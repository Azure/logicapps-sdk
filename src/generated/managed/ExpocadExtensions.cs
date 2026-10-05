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
        [WorkflowExpressionFactory(nameof(__BuildBoothsGet))]
        public IBodyWorkflowAction<Booth> BoothsGet([WorkflowExpression] Func<string> clientName, [WorkflowExpression] Func<string> boothNumber, [WorkflowExpression] Func<string> databaseName)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Booth> __BuildBoothsGet(WorkflowValue<string> clientName, WorkflowValue<string> boothNumber, WorkflowValue<string> databaseName)
        {
            WorkflowValue.Validate(clientName, nameof(clientName), required: true);
            WorkflowValue.Validate(boothNumber, nameof(boothNumber), required: true);
            WorkflowValue.Validate(databaseName, nameof(databaseName), required: true);
            return new DeferredBodyAction<Booth>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/booths", ExpressionConverter.ConvertWithUrlEncoding(clientName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["boothNumber"] = ExpressionConverter.Convert(boothNumber);
                callPayload.Queries["databaseName"] = ExpressionConverter.Convert(databaseName);
                return new ApiConnectionAction<Booth>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        [WorkflowExpressionFactory(nameof(__BuildBoothsGetAllBooths))]
        public IBodyWorkflowAction<Booth[]> BoothsGetAllBooths([WorkflowExpression] Func<string> clientName, [WorkflowExpression] Func<string> databaseName, [WorkflowExpression] Func<deletedFilterInput> deletedFilter = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Booth[]> __BuildBoothsGetAllBooths(WorkflowValue<string> clientName, WorkflowValue<string> databaseName, WorkflowValue<deletedFilterInput> deletedFilter = null)
        {
            WorkflowValue.Validate(clientName, nameof(clientName), required: true);
            WorkflowValue.Validate(databaseName, nameof(databaseName), required: true);
            WorkflowValue.Validate(deletedFilter, nameof(deletedFilter), required: false);
            return new DeferredBodyAction<Booth[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/booths/all", ExpressionConverter.ConvertWithUrlEncoding(clientName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["databaseName"] = ExpressionConverter.Convert(databaseName);
                if (deletedFilter != null)
                    callPayload.Queries["deletedFilter"] = ExpressionConverter.Convert(deletedFilter);
                return new ApiConnectionAction<Booth[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        [WorkflowExpressionFactory(nameof(__BuildBoothsGetAllAvailableBooths))]
        public IBodyWorkflowAction<Booth[]> BoothsGetAllAvailableBooths([WorkflowExpression] Func<string> clientName, [WorkflowExpression] Func<string> databaseName)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Booth[]> __BuildBoothsGetAllAvailableBooths(WorkflowValue<string> clientName, WorkflowValue<string> databaseName)
        {
            WorkflowValue.Validate(clientName, nameof(clientName), required: true);
            WorkflowValue.Validate(databaseName, nameof(databaseName), required: true);
            return new DeferredBodyAction<Booth[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/booths/all/available", ExpressionConverter.ConvertWithUrlEncoding(clientName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["databaseName"] = ExpressionConverter.Convert(databaseName);
                return new ApiConnectionAction<Booth[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        [WorkflowExpressionFactory(nameof(__BuildBoothsGetAllRentedBooths))]
        public IBodyWorkflowAction<Booth[]> BoothsGetAllRentedBooths([WorkflowExpression] Func<string> clientName, [WorkflowExpression] Func<string> databaseName)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Booth[]> __BuildBoothsGetAllRentedBooths(WorkflowValue<string> clientName, WorkflowValue<string> databaseName)
        {
            WorkflowValue.Validate(clientName, nameof(clientName), required: true);
            WorkflowValue.Validate(databaseName, nameof(databaseName), required: true);
            return new DeferredBodyAction<Booth[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/booths/all/rented", ExpressionConverter.ConvertWithUrlEncoding(clientName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["databaseName"] = ExpressionConverter.Convert(databaseName);
                return new ApiConnectionAction<Booth[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        [WorkflowExpressionFactory(nameof(__BuildBoothsRentBooth))]
        public IBodyWorkflowAction<JToken> BoothsRentBooth([WorkflowExpression] Func<string> clientName, [WorkflowExpression] Func<string> boothNumber, [WorkflowExpression] Func<string> exhibitorId, [WorkflowExpression] Func<string> databaseName, [WorkflowExpression] Func<string> ratePlan = null, [WorkflowExpression] Func<string> status = null, [WorkflowExpression] Func<string> comment = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildBoothsRentBooth(WorkflowValue<string> clientName, WorkflowValue<string> boothNumber, WorkflowValue<string> exhibitorId, WorkflowValue<string> databaseName, WorkflowValue<string> ratePlan = null, WorkflowValue<string> status = null, WorkflowValue<string> comment = null)
        {
            WorkflowValue.Validate(clientName, nameof(clientName), required: true);
            WorkflowValue.Validate(boothNumber, nameof(boothNumber), required: true);
            WorkflowValue.Validate(exhibitorId, nameof(exhibitorId), required: true);
            WorkflowValue.Validate(databaseName, nameof(databaseName), required: true);
            WorkflowValue.Validate(ratePlan, nameof(ratePlan), required: false);
            WorkflowValue.Validate(status, nameof(status), required: false);
            WorkflowValue.Validate(comment, nameof(comment), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/booths/rent", ExpressionConverter.ConvertWithUrlEncoding(clientName, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        [WorkflowExpressionFactory(nameof(__BuildBoothsUnRentBooth))]
        public IBodyWorkflowAction<JToken> BoothsUnRentBooth([WorkflowExpression] Func<string> clientName, [WorkflowExpression] Func<string> boothNumber, [WorkflowExpression] Func<string> databaseName)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildBoothsUnRentBooth(WorkflowValue<string> clientName, WorkflowValue<string> boothNumber, WorkflowValue<string> databaseName)
        {
            WorkflowValue.Validate(clientName, nameof(clientName), required: true);
            WorkflowValue.Validate(boothNumber, nameof(boothNumber), required: true);
            WorkflowValue.Validate(databaseName, nameof(databaseName), required: true);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/booths/unrent", ExpressionConverter.ConvertWithUrlEncoding(clientName, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["boothNumber"] = ExpressionConverter.Convert(boothNumber);
                callPayload.Queries["databaseName"] = ExpressionConverter.Convert(databaseName);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        [WorkflowExpressionFactory(nameof(__BuildBoothsHoldBooth))]
        public IBodyWorkflowAction<JToken> BoothsHoldBooth([WorkflowExpression] Func<string> clientName, [WorkflowExpression] Func<string> boothNumber, [WorkflowExpression] Func<string> databaseName, [WorkflowExpression] Func<string> exhibitorId = null, [WorkflowExpression] Func<string> exhibitorName = null, [WorkflowExpression] Func<string> comment = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildBoothsHoldBooth(WorkflowValue<string> clientName, WorkflowValue<string> boothNumber, WorkflowValue<string> databaseName, WorkflowValue<string> exhibitorId = null, WorkflowValue<string> exhibitorName = null, WorkflowValue<string> comment = null)
        {
            WorkflowValue.Validate(clientName, nameof(clientName), required: true);
            WorkflowValue.Validate(boothNumber, nameof(boothNumber), required: true);
            WorkflowValue.Validate(databaseName, nameof(databaseName), required: true);
            WorkflowValue.Validate(exhibitorId, nameof(exhibitorId), required: false);
            WorkflowValue.Validate(exhibitorName, nameof(exhibitorName), required: false);
            WorkflowValue.Validate(comment, nameof(comment), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/booths/hold", ExpressionConverter.ConvertWithUrlEncoding(clientName, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        [WorkflowExpressionFactory(nameof(__BuildBoothsUnHoldBooth))]
        public IBodyWorkflowAction<JToken> BoothsUnHoldBooth([WorkflowExpression] Func<string> clientName, [WorkflowExpression] Func<string> boothNumber, [WorkflowExpression] Func<string> databaseName)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildBoothsUnHoldBooth(WorkflowValue<string> clientName, WorkflowValue<string> boothNumber, WorkflowValue<string> databaseName)
        {
            WorkflowValue.Validate(clientName, nameof(clientName), required: true);
            WorkflowValue.Validate(boothNumber, nameof(boothNumber), required: true);
            WorkflowValue.Validate(databaseName, nameof(databaseName), required: true);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/booths/unhold", ExpressionConverter.ConvertWithUrlEncoding(clientName, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["boothNumber"] = ExpressionConverter.Convert(boothNumber);
                callPayload.Queries["databaseName"] = ExpressionConverter.Convert(databaseName);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        [WorkflowExpressionFactory(nameof(__BuildBoothsRentToHold))]
        public IBodyWorkflowAction<JToken> BoothsRentToHold([WorkflowExpression] Func<string> clientName, [WorkflowExpression] Func<string> boothNumber, [WorkflowExpression] Func<string> databaseName)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildBoothsRentToHold(WorkflowValue<string> clientName, WorkflowValue<string> boothNumber, WorkflowValue<string> databaseName)
        {
            WorkflowValue.Validate(clientName, nameof(clientName), required: true);
            WorkflowValue.Validate(boothNumber, nameof(boothNumber), required: true);
            WorkflowValue.Validate(databaseName, nameof(databaseName), required: true);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/booths/rentToHold", ExpressionConverter.ConvertWithUrlEncoding(clientName, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["boothNumber"] = ExpressionConverter.Convert(boothNumber);
                callPayload.Queries["databaseName"] = ExpressionConverter.Convert(databaseName);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        [WorkflowExpressionFactory(nameof(__BuildBoothsHoldToRent))]
        public IBodyWorkflowAction<JToken> BoothsHoldToRent([WorkflowExpression] Func<string> clientName, [WorkflowExpression] Func<string> boothNumber, [WorkflowExpression] Func<string> databaseName, [WorkflowExpression] Func<string> ratePlan = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildBoothsHoldToRent(WorkflowValue<string> clientName, WorkflowValue<string> boothNumber, WorkflowValue<string> databaseName, WorkflowValue<string> ratePlan = null)
        {
            WorkflowValue.Validate(clientName, nameof(clientName), required: true);
            WorkflowValue.Validate(boothNumber, nameof(boothNumber), required: true);
            WorkflowValue.Validate(databaseName, nameof(databaseName), required: true);
            WorkflowValue.Validate(ratePlan, nameof(ratePlan), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/booths/holdToRent", ExpressionConverter.ConvertWithUrlEncoding(clientName, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["boothNumber"] = ExpressionConverter.Convert(boothNumber);
                callPayload.Queries["databaseName"] = ExpressionConverter.Convert(databaseName);
                if (ratePlan != null)
                    callPayload.Queries["ratePlan"] = ExpressionConverter.Convert(ratePlan);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        [WorkflowExpressionFactory(nameof(__BuildBoothsCombineBooths))]
        public IBodyWorkflowAction<JToken> BoothsCombineBooths([WorkflowExpression] Func<string> clientName, [WorkflowExpression] Func<string> databaseName, [WorkflowExpression] Func<int> boundary, [WorkflowExpression] Func<string[]> boothNumbers = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildBoothsCombineBooths(WorkflowValue<string> clientName, WorkflowValue<string> databaseName, WorkflowValue<int> boundary, WorkflowValue<string[]> boothNumbers = null)
        {
            WorkflowValue.Validate(clientName, nameof(clientName), required: true);
            WorkflowValue.Validate(databaseName, nameof(databaseName), required: true);
            WorkflowValue.Validate(boundary, nameof(boundary), required: true);
            WorkflowValue.Validate(boothNumbers, nameof(boothNumbers), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/booths/combine", ExpressionConverter.ConvertWithUrlEncoding(clientName, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["databaseName"] = ExpressionConverter.Convert(databaseName);
                callPayload.Queries["boundary"] = ExpressionConverter.Convert(boundary);
                callPayload.Body = ExpressionConverter.ConvertO(boothNumbers);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        [WorkflowExpressionFactory(nameof(__BuildBoothsUncombineBooth))]
        public IBodyWorkflowAction<JToken> BoothsUncombineBooth([WorkflowExpression] Func<string> clientName, [WorkflowExpression] Func<string> boothNumber, [WorkflowExpression] Func<string> databaseName)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildBoothsUncombineBooth(WorkflowValue<string> clientName, WorkflowValue<string> boothNumber, WorkflowValue<string> databaseName)
        {
            WorkflowValue.Validate(clientName, nameof(clientName), required: true);
            WorkflowValue.Validate(boothNumber, nameof(boothNumber), required: true);
            WorkflowValue.Validate(databaseName, nameof(databaseName), required: true);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/booths/uncombine", ExpressionConverter.ConvertWithUrlEncoding(clientName, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["boothNumber"] = ExpressionConverter.Convert(boothNumber);
                callPayload.Queries["databaseName"] = ExpressionConverter.Convert(databaseName);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        [WorkflowExpressionFactory(nameof(__BuildBoothsDeleteBooths))]
        public IBodyWorkflowAction<JToken> BoothsDeleteBooths([WorkflowExpression] Func<string> clientName, [WorkflowExpression] Func<string> databaseName, [WorkflowExpression] Func<string[]> boothNumbers = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildBoothsDeleteBooths(WorkflowValue<string> clientName, WorkflowValue<string> databaseName, WorkflowValue<string[]> boothNumbers = null)
        {
            WorkflowValue.Validate(clientName, nameof(clientName), required: true);
            WorkflowValue.Validate(databaseName, nameof(databaseName), required: true);
            WorkflowValue.Validate(boothNumbers, nameof(boothNumbers), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/booths/delete", ExpressionConverter.ConvertWithUrlEncoding(clientName, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["databaseName"] = ExpressionConverter.Convert(databaseName);
                callPayload.Body = ExpressionConverter.ConvertO(boothNumbers);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        [WorkflowExpressionFactory(nameof(__BuildBoothsUndeleteBooths))]
        public IBodyWorkflowAction<JToken> BoothsUndeleteBooths([WorkflowExpression] Func<string> clientName, [WorkflowExpression] Func<string> databaseName, [WorkflowExpression] Func<string[]> boothNumbers = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildBoothsUndeleteBooths(WorkflowValue<string> clientName, WorkflowValue<string> databaseName, WorkflowValue<string[]> boothNumbers = null)
        {
            WorkflowValue.Validate(clientName, nameof(clientName), required: true);
            WorkflowValue.Validate(databaseName, nameof(databaseName), required: true);
            WorkflowValue.Validate(boothNumbers, nameof(boothNumbers), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/booths/undelete", ExpressionConverter.ConvertWithUrlEncoding(clientName, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["databaseName"] = ExpressionConverter.Convert(databaseName);
                callPayload.Body = ExpressionConverter.ConvertO(boothNumbers);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        [WorkflowExpressionFactory(nameof(__BuildBoothsChangeBoothNumber))]
        public IBodyWorkflowAction<JToken> BoothsChangeBoothNumber([WorkflowExpression] Func<string> clientName, [WorkflowExpression] Func<string> oldNumber, [WorkflowExpression] Func<string> newNumber, [WorkflowExpression] Func<string> databaseName)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildBoothsChangeBoothNumber(WorkflowValue<string> clientName, WorkflowValue<string> oldNumber, WorkflowValue<string> newNumber, WorkflowValue<string> databaseName)
        {
            WorkflowValue.Validate(clientName, nameof(clientName), required: true);
            WorkflowValue.Validate(oldNumber, nameof(oldNumber), required: true);
            WorkflowValue.Validate(newNumber, nameof(newNumber), required: true);
            WorkflowValue.Validate(databaseName, nameof(databaseName), required: true);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/booths/changenumber", ExpressionConverter.ConvertWithUrlEncoding(clientName, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["oldNumber"] = ExpressionConverter.Convert(oldNumber);
                callPayload.Queries["newNumber"] = ExpressionConverter.Convert(newNumber);
                callPayload.Queries["databaseName"] = ExpressionConverter.Convert(databaseName);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        [WorkflowExpressionFactory(nameof(__BuildBoothsSetBoothClass))]
        public IBodyWorkflowAction<JToken> BoothsSetBoothClass([WorkflowExpression] Func<string> clientName, [WorkflowExpression] Func<string> classId, [WorkflowExpression] Func<string> boothNumber, [WorkflowExpression] Func<string> databaseName)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildBoothsSetBoothClass(WorkflowValue<string> clientName, WorkflowValue<string> classId, WorkflowValue<string> boothNumber, WorkflowValue<string> databaseName)
        {
            WorkflowValue.Validate(clientName, nameof(clientName), required: true);
            WorkflowValue.Validate(classId, nameof(classId), required: true);
            WorkflowValue.Validate(boothNumber, nameof(boothNumber), required: true);
            WorkflowValue.Validate(databaseName, nameof(databaseName), required: true);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/booths/classes/apply", ExpressionConverter.ConvertWithUrlEncoding(clientName, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["classId"] = ExpressionConverter.Convert(classId);
                callPayload.Queries["boothNumber"] = ExpressionConverter.Convert(boothNumber);
                callPayload.Queries["databaseName"] = ExpressionConverter.Convert(databaseName);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        [WorkflowExpressionFactory(nameof(__BuildBoothsClearBoothClass))]
        public IBodyWorkflowAction<JToken> BoothsClearBoothClass([WorkflowExpression] Func<string> clientName, [WorkflowExpression] Func<string> classId, [WorkflowExpression] Func<string> boothNumber, [WorkflowExpression] Func<string> databaseName)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildBoothsClearBoothClass(WorkflowValue<string> clientName, WorkflowValue<string> classId, WorkflowValue<string> boothNumber, WorkflowValue<string> databaseName)
        {
            WorkflowValue.Validate(clientName, nameof(clientName), required: true);
            WorkflowValue.Validate(classId, nameof(classId), required: true);
            WorkflowValue.Validate(boothNumber, nameof(boothNumber), required: true);
            WorkflowValue.Validate(databaseName, nameof(databaseName), required: true);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/booths/classes/remove", ExpressionConverter.ConvertWithUrlEncoding(clientName, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["classId"] = ExpressionConverter.Convert(classId);
                callPayload.Queries["boothNumber"] = ExpressionConverter.Convert(boothNumber);
                callPayload.Queries["databaseName"] = ExpressionConverter.Convert(databaseName);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        [WorkflowExpressionFactory(nameof(__BuildBoothsSetBoothDisplayName))]
        public IBodyWorkflowAction<JToken> BoothsSetBoothDisplayName([WorkflowExpression] Func<string> clientName, [WorkflowExpression] Func<string> text, [WorkflowExpression] Func<string> boothNumber, [WorkflowExpression] Func<string> databaseName)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildBoothsSetBoothDisplayName(WorkflowValue<string> clientName, WorkflowValue<string> text, WorkflowValue<string> boothNumber, WorkflowValue<string> databaseName)
        {
            WorkflowValue.Validate(clientName, nameof(clientName), required: true);
            WorkflowValue.Validate(text, nameof(text), required: true);
            WorkflowValue.Validate(boothNumber, nameof(boothNumber), required: true);
            WorkflowValue.Validate(databaseName, nameof(databaseName), required: true);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/booths/displayNameOverride/set", ExpressionConverter.ConvertWithUrlEncoding(clientName, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["text"] = ExpressionConverter.Convert(text);
                callPayload.Queries["boothNumber"] = ExpressionConverter.Convert(boothNumber);
                callPayload.Queries["databaseName"] = ExpressionConverter.Convert(databaseName);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        [WorkflowExpressionFactory(nameof(__BuildBoothsClearBoothDisplayName))]
        public IBodyWorkflowAction<JToken> BoothsClearBoothDisplayName([WorkflowExpression] Func<string> clientName, [WorkflowExpression] Func<string> boothNumber, [WorkflowExpression] Func<string> databaseName)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildBoothsClearBoothDisplayName(WorkflowValue<string> clientName, WorkflowValue<string> boothNumber, WorkflowValue<string> databaseName)
        {
            WorkflowValue.Validate(clientName, nameof(clientName), required: true);
            WorkflowValue.Validate(boothNumber, nameof(boothNumber), required: true);
            WorkflowValue.Validate(databaseName, nameof(databaseName), required: true);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/booths/displayNameOverride/reset", ExpressionConverter.ConvertWithUrlEncoding(clientName, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["boothNumber"] = ExpressionConverter.Convert(boothNumber);
                callPayload.Queries["databaseName"] = ExpressionConverter.Convert(databaseName);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        [WorkflowExpressionFactory(nameof(__BuildBoothsAddChildExhibitor))]
        public IBodyWorkflowAction<JToken> BoothsAddChildExhibitor([WorkflowExpression] Func<string> clientName, [WorkflowExpression] Func<string> childExhibitorId, [WorkflowExpression] Func<string> boothNumber, [WorkflowExpression] Func<string> databaseName)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildBoothsAddChildExhibitor(WorkflowValue<string> clientName, WorkflowValue<string> childExhibitorId, WorkflowValue<string> boothNumber, WorkflowValue<string> databaseName)
        {
            WorkflowValue.Validate(clientName, nameof(clientName), required: true);
            WorkflowValue.Validate(childExhibitorId, nameof(childExhibitorId), required: true);
            WorkflowValue.Validate(boothNumber, nameof(boothNumber), required: true);
            WorkflowValue.Validate(databaseName, nameof(databaseName), required: true);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/booths/childExhibitor/add", ExpressionConverter.ConvertWithUrlEncoding(clientName, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["childExhibitorId"] = ExpressionConverter.Convert(childExhibitorId);
                callPayload.Queries["boothNumber"] = ExpressionConverter.Convert(boothNumber);
                callPayload.Queries["databaseName"] = ExpressionConverter.Convert(databaseName);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        [WorkflowExpressionFactory(nameof(__BuildBoothsRemoveChildExhibitor))]
        public IBodyWorkflowAction<JToken> BoothsRemoveChildExhibitor([WorkflowExpression] Func<string> clientName, [WorkflowExpression] Func<string> childExhibitorId, [WorkflowExpression] Func<string> boothNumber, [WorkflowExpression] Func<string> databaseName)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildBoothsRemoveChildExhibitor(WorkflowValue<string> clientName, WorkflowValue<string> childExhibitorId, WorkflowValue<string> boothNumber, WorkflowValue<string> databaseName)
        {
            WorkflowValue.Validate(clientName, nameof(clientName), required: true);
            WorkflowValue.Validate(childExhibitorId, nameof(childExhibitorId), required: true);
            WorkflowValue.Validate(boothNumber, nameof(boothNumber), required: true);
            WorkflowValue.Validate(databaseName, nameof(databaseName), required: true);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/booths/childExhibitor/remove", ExpressionConverter.ConvertWithUrlEncoding(clientName, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["childExhibitorId"] = ExpressionConverter.Convert(childExhibitorId);
                callPayload.Queries["boothNumber"] = ExpressionConverter.Convert(boothNumber);
                callPayload.Queries["databaseName"] = ExpressionConverter.Convert(databaseName);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        [WorkflowExpressionFactory(nameof(__BuildClassesGet))]
        public IBodyWorkflowAction<BoothClass> ClassesGet([WorkflowExpression] Func<string> clientName, [WorkflowExpression] Func<string> classId, [WorkflowExpression] Func<string> databaseName)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BoothClass> __BuildClassesGet(WorkflowValue<string> clientName, WorkflowValue<string> classId, WorkflowValue<string> databaseName)
        {
            WorkflowValue.Validate(clientName, nameof(clientName), required: true);
            WorkflowValue.Validate(classId, nameof(classId), required: true);
            WorkflowValue.Validate(databaseName, nameof(databaseName), required: true);
            return new DeferredBodyAction<BoothClass>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/classes", ExpressionConverter.ConvertWithUrlEncoding(clientName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["classId"] = ExpressionConverter.Convert(classId);
                callPayload.Queries["databaseName"] = ExpressionConverter.Convert(databaseName);
                return new ApiConnectionAction<BoothClass>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        [WorkflowExpressionFactory(nameof(__BuildClassesGetAllBoothClasses))]
        public IBodyWorkflowAction<BoothClass[]> ClassesGetAllBoothClasses([WorkflowExpression] Func<string> clientName, [WorkflowExpression] Func<string> databaseName)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BoothClass[]> __BuildClassesGetAllBoothClasses(WorkflowValue<string> clientName, WorkflowValue<string> databaseName)
        {
            WorkflowValue.Validate(clientName, nameof(clientName), required: true);
            WorkflowValue.Validate(databaseName, nameof(databaseName), required: true);
            return new DeferredBodyAction<BoothClass[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/classes/all", ExpressionConverter.ConvertWithUrlEncoding(clientName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["databaseName"] = ExpressionConverter.Convert(databaseName);
                return new ApiConnectionAction<BoothClass[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        [WorkflowExpressionFactory(nameof(__BuildClassesCreate))]
        public IBodyWorkflowAction<BoothClass> ClassesCreate([WorkflowExpression] Func<string> clientName, [WorkflowExpression] Func<string> boothClassid, [WorkflowExpression] Func<int> boothClasskeepWhenCombined, [WorkflowExpression] Func<int> boothClasscountAsInventory, [WorkflowExpression] Func<string> databaseName, [WorkflowExpression] Func<string> boothClassname = null, [WorkflowExpression] Func<string> boothClassdescription = null, [WorkflowExpression] Func<string> boothClassprioritity = null, [WorkflowExpression] Func<int> boothClasscolor = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BoothClass> __BuildClassesCreate(WorkflowValue<string> clientName, WorkflowValue<string> boothClassid, WorkflowValue<int> boothClasskeepWhenCombined, WorkflowValue<int> boothClasscountAsInventory, WorkflowValue<string> databaseName, WorkflowValue<string> boothClassname = null, WorkflowValue<string> boothClassdescription = null, WorkflowValue<string> boothClassprioritity = null, WorkflowValue<int> boothClasscolor = null)
        {
            WorkflowValue.Validate(clientName, nameof(clientName), required: true);
            WorkflowValue.Validate(boothClassid, nameof(boothClassid), required: true);
            WorkflowValue.Validate(boothClasskeepWhenCombined, nameof(boothClasskeepWhenCombined), required: true);
            WorkflowValue.Validate(boothClasscountAsInventory, nameof(boothClasscountAsInventory), required: true);
            WorkflowValue.Validate(databaseName, nameof(databaseName), required: true);
            WorkflowValue.Validate(boothClassname, nameof(boothClassname), required: false);
            WorkflowValue.Validate(boothClassdescription, nameof(boothClassdescription), required: false);
            WorkflowValue.Validate(boothClassprioritity, nameof(boothClassprioritity), required: false);
            WorkflowValue.Validate(boothClasscolor, nameof(boothClasscolor), required: false);
            return new DeferredBodyAction<BoothClass>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/classes/add", ExpressionConverter.ConvertWithUrlEncoding(clientName, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        [WorkflowExpressionFactory(nameof(__BuildClassesUpdate))]
        public IBodyWorkflowAction<BoothClass> ClassesUpdate([WorkflowExpression] Func<string> clientName, [WorkflowExpression] Func<string> boothClassid, [WorkflowExpression] Func<int> boothClasskeepWhenCombined, [WorkflowExpression] Func<int> boothClasscountAsInventory, [WorkflowExpression] Func<string> classId, [WorkflowExpression] Func<string> databaseName, [WorkflowExpression] Func<string> boothClassname = null, [WorkflowExpression] Func<string> boothClassdescription = null, [WorkflowExpression] Func<string> boothClassprioritity = null, [WorkflowExpression] Func<int> boothClasscolor = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BoothClass> __BuildClassesUpdate(WorkflowValue<string> clientName, WorkflowValue<string> boothClassid, WorkflowValue<int> boothClasskeepWhenCombined, WorkflowValue<int> boothClasscountAsInventory, WorkflowValue<string> classId, WorkflowValue<string> databaseName, WorkflowValue<string> boothClassname = null, WorkflowValue<string> boothClassdescription = null, WorkflowValue<string> boothClassprioritity = null, WorkflowValue<int> boothClasscolor = null)
        {
            WorkflowValue.Validate(clientName, nameof(clientName), required: true);
            WorkflowValue.Validate(boothClassid, nameof(boothClassid), required: true);
            WorkflowValue.Validate(boothClasskeepWhenCombined, nameof(boothClasskeepWhenCombined), required: true);
            WorkflowValue.Validate(boothClasscountAsInventory, nameof(boothClasscountAsInventory), required: true);
            WorkflowValue.Validate(classId, nameof(classId), required: true);
            WorkflowValue.Validate(databaseName, nameof(databaseName), required: true);
            WorkflowValue.Validate(boothClassname, nameof(boothClassname), required: false);
            WorkflowValue.Validate(boothClassdescription, nameof(boothClassdescription), required: false);
            WorkflowValue.Validate(boothClassprioritity, nameof(boothClassprioritity), required: false);
            WorkflowValue.Validate(boothClasscolor, nameof(boothClasscolor), required: false);
            return new DeferredBodyAction<BoothClass>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/classes/update", ExpressionConverter.ConvertWithUrlEncoding(clientName, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        [WorkflowExpressionFactory(nameof(__BuildClassesDelete))]
        public IBodyWorkflowAction<JToken> ClassesDelete([WorkflowExpression] Func<string> clientName, [WorkflowExpression] Func<string> classId, [WorkflowExpression] Func<string> databaseName)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildClassesDelete(WorkflowValue<string> clientName, WorkflowValue<string> classId, WorkflowValue<string> databaseName)
        {
            WorkflowValue.Validate(clientName, nameof(clientName), required: true);
            WorkflowValue.Validate(classId, nameof(classId), required: true);
            WorkflowValue.Validate(databaseName, nameof(databaseName), required: true);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/classes/delete", ExpressionConverter.ConvertWithUrlEncoding(clientName, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["classId"] = ExpressionConverter.Convert(classId);
                callPayload.Queries["databaseName"] = ExpressionConverter.Convert(databaseName);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        [WorkflowExpressionFactory(nameof(__BuildEventsGetAllEvents))]
        public IBodyWorkflowAction<ExpocadEvent[]> EventsGetAllEvents([WorkflowExpression] Func<string> clientName)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ExpocadEvent[]> __BuildEventsGetAllEvents(WorkflowValue<string> clientName)
        {
            WorkflowValue.Validate(clientName, nameof(clientName), required: true);
            return new DeferredBodyAction<ExpocadEvent[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/events", ExpressionConverter.ConvertWithUrlEncoding(clientName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ExpocadEvent[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        [WorkflowExpressionFactory(nameof(__BuildEventsGetEventStatistics))]
        public IBodyWorkflowAction<EventStats> EventsGetEventStatistics([WorkflowExpression] Func<string> clientName, [WorkflowExpression] Func<string> databaseName)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<EventStats> __BuildEventsGetEventStatistics(WorkflowValue<string> clientName, WorkflowValue<string> databaseName)
        {
            WorkflowValue.Validate(clientName, nameof(clientName), required: true);
            WorkflowValue.Validate(databaseName, nameof(databaseName), required: true);
            return new DeferredBodyAction<EventStats>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/events/stats", ExpressionConverter.ConvertWithUrlEncoding(clientName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["databaseName"] = ExpressionConverter.Convert(databaseName);
                return new ApiConnectionAction<EventStats>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        [WorkflowExpressionFactory(nameof(__BuildEventsGetEventInformation))]
        public IBodyWorkflowAction<ExpoEventInformation> EventsGetEventInformation([WorkflowExpression] Func<string> clientName, [WorkflowExpression] Func<string> databaseName)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ExpoEventInformation> __BuildEventsGetEventInformation(WorkflowValue<string> clientName, WorkflowValue<string> databaseName)
        {
            WorkflowValue.Validate(clientName, nameof(clientName), required: true);
            WorkflowValue.Validate(databaseName, nameof(databaseName), required: true);
            return new DeferredBodyAction<ExpoEventInformation>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/events/info", ExpressionConverter.ConvertWithUrlEncoding(clientName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["databaseName"] = ExpressionConverter.Convert(databaseName);
                return new ApiConnectionAction<ExpoEventInformation>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        [WorkflowExpressionFactory(nameof(__BuildExhibitorsGet))]
        public IBodyWorkflowAction<Exhibitor> ExhibitorsGet([WorkflowExpression] Func<string> clientName, [WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> databaseName)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Exhibitor> __BuildExhibitorsGet(WorkflowValue<string> clientName, WorkflowValue<string> id, WorkflowValue<string> databaseName)
        {
            WorkflowValue.Validate(clientName, nameof(clientName), required: true);
            WorkflowValue.Validate(id, nameof(id), required: true);
            WorkflowValue.Validate(databaseName, nameof(databaseName), required: true);
            return new DeferredBodyAction<Exhibitor>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/exhibitors", ExpressionConverter.ConvertWithUrlEncoding(clientName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = ExpressionConverter.Convert(id);
                callPayload.Queries["databaseName"] = ExpressionConverter.Convert(databaseName);
                return new ApiConnectionAction<Exhibitor>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        [WorkflowExpressionFactory(nameof(__BuildExhibitorsGetAllExhibitors))]
        public IBodyWorkflowAction<Exhibitor[]> ExhibitorsGetAllExhibitors([WorkflowExpression] Func<string> clientName, [WorkflowExpression] Func<string> databaseName)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Exhibitor[]> __BuildExhibitorsGetAllExhibitors(WorkflowValue<string> clientName, WorkflowValue<string> databaseName)
        {
            WorkflowValue.Validate(clientName, nameof(clientName), required: true);
            WorkflowValue.Validate(databaseName, nameof(databaseName), required: true);
            return new DeferredBodyAction<Exhibitor[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/exhibitors/all", ExpressionConverter.ConvertWithUrlEncoding(clientName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["databaseName"] = ExpressionConverter.Convert(databaseName);
                return new ApiConnectionAction<Exhibitor[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        [WorkflowExpressionFactory(nameof(__BuildExhibitorsAddExhibitor))]
        public IBodyWorkflowAction<Exhibitor> ExhibitorsAddExhibitor([WorkflowExpression] Func<string> clientName, [WorkflowExpression] Func<string> exhibitorexhibitorId, [WorkflowExpression] Func<string> databaseName, [WorkflowExpression] Func<string> exhibitoraddress1 = null, [WorkflowExpression] Func<string> exhibitoraddress2 = null, [WorkflowExpression] Func<string> exhibitorcity = null, [WorkflowExpression] Func<string> exhibitorcomments = null, [WorkflowExpression] Func<string> exhibitorcomments2 = null, [WorkflowExpression] Func<string> exhibitorcontact = null, [WorkflowExpression] Func<string> exhibitorcountry = null, [WorkflowExpression] Func<string> exhibitorcellPhone = null, [WorkflowExpression] Func<string> exhibitordisplayOnDrawing = null, [WorkflowExpression] Func<string> exhibitordoingBusinessAs = null, [WorkflowExpression] Func<string> exhibitordoingBusinessAsDisplayOnDrawing = null, [WorkflowExpression] Func<string> exhibitoremail = null, [WorkflowExpression] Func<string> exhibitorexhibitorName = null, [WorkflowExpression] Func<string> exhibitorexhibitorNameLine2 = null, [WorkflowExpression] Func<string> exhibitorfax = null, [WorkflowExpression] Func<string> exhibitorfield1 = null, [WorkflowExpression] Func<string> exhibitorfield2 = null, [WorkflowExpression] Func<string> exhibitorfield3 = null, [WorkflowExpression] Func<string> exhibitorfield4 = null, [WorkflowExpression] Func<string> exhibitorfield5 = null, [WorkflowExpression] Func<string> exhibitorfield6 = null, [WorkflowExpression] Func<string> exhibitorfield7 = null, [WorkflowExpression] Func<string> exhibitorfield8 = null, [WorkflowExpression] Func<string> exhibitorfield9 = null, [WorkflowExpression] Func<string> exhibitornickName = null, [WorkflowExpression] Func<string> exhibitorsalutation = null, [WorkflowExpression] Func<string> exhibitortitle = null, [WorkflowExpression] Func<string> exhibitorphone = null, [WorkflowExpression] Func<string> exhibitorpostalCode = null, [WorkflowExpression] Func<string> exhibitorprimaryGroup = null, [WorkflowExpression] Func<string> exhibitorpriorityPoints = null, [WorkflowExpression] Func<string> exhibitorproductDescription = null, [WorkflowExpression] Func<string> exhibitorstate = null, [WorkflowExpression] Func<string> exhibitorwebSite = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Exhibitor> __BuildExhibitorsAddExhibitor(WorkflowValue<string> clientName, WorkflowValue<string> exhibitorexhibitorId, WorkflowValue<string> databaseName, WorkflowValue<string> exhibitoraddress1 = null, WorkflowValue<string> exhibitoraddress2 = null, WorkflowValue<string> exhibitorcity = null, WorkflowValue<string> exhibitorcomments = null, WorkflowValue<string> exhibitorcomments2 = null, WorkflowValue<string> exhibitorcontact = null, WorkflowValue<string> exhibitorcountry = null, WorkflowValue<string> exhibitorcellPhone = null, WorkflowValue<string> exhibitordisplayOnDrawing = null, WorkflowValue<string> exhibitordoingBusinessAs = null, WorkflowValue<string> exhibitordoingBusinessAsDisplayOnDrawing = null, WorkflowValue<string> exhibitoremail = null, WorkflowValue<string> exhibitorexhibitorName = null, WorkflowValue<string> exhibitorexhibitorNameLine2 = null, WorkflowValue<string> exhibitorfax = null, WorkflowValue<string> exhibitorfield1 = null, WorkflowValue<string> exhibitorfield2 = null, WorkflowValue<string> exhibitorfield3 = null, WorkflowValue<string> exhibitorfield4 = null, WorkflowValue<string> exhibitorfield5 = null, WorkflowValue<string> exhibitorfield6 = null, WorkflowValue<string> exhibitorfield7 = null, WorkflowValue<string> exhibitorfield8 = null, WorkflowValue<string> exhibitorfield9 = null, WorkflowValue<string> exhibitornickName = null, WorkflowValue<string> exhibitorsalutation = null, WorkflowValue<string> exhibitortitle = null, WorkflowValue<string> exhibitorphone = null, WorkflowValue<string> exhibitorpostalCode = null, WorkflowValue<string> exhibitorprimaryGroup = null, WorkflowValue<string> exhibitorpriorityPoints = null, WorkflowValue<string> exhibitorproductDescription = null, WorkflowValue<string> exhibitorstate = null, WorkflowValue<string> exhibitorwebSite = null)
        {
            WorkflowValue.Validate(clientName, nameof(clientName), required: true);
            WorkflowValue.Validate(exhibitorexhibitorId, nameof(exhibitorexhibitorId), required: true);
            WorkflowValue.Validate(databaseName, nameof(databaseName), required: true);
            WorkflowValue.Validate(exhibitoraddress1, nameof(exhibitoraddress1), required: false);
            WorkflowValue.Validate(exhibitoraddress2, nameof(exhibitoraddress2), required: false);
            WorkflowValue.Validate(exhibitorcity, nameof(exhibitorcity), required: false);
            WorkflowValue.Validate(exhibitorcomments, nameof(exhibitorcomments), required: false);
            WorkflowValue.Validate(exhibitorcomments2, nameof(exhibitorcomments2), required: false);
            WorkflowValue.Validate(exhibitorcontact, nameof(exhibitorcontact), required: false);
            WorkflowValue.Validate(exhibitorcountry, nameof(exhibitorcountry), required: false);
            WorkflowValue.Validate(exhibitorcellPhone, nameof(exhibitorcellPhone), required: false);
            WorkflowValue.Validate(exhibitordisplayOnDrawing, nameof(exhibitordisplayOnDrawing), required: false);
            WorkflowValue.Validate(exhibitordoingBusinessAs, nameof(exhibitordoingBusinessAs), required: false);
            WorkflowValue.Validate(exhibitordoingBusinessAsDisplayOnDrawing, nameof(exhibitordoingBusinessAsDisplayOnDrawing), required: false);
            WorkflowValue.Validate(exhibitoremail, nameof(exhibitoremail), required: false);
            WorkflowValue.Validate(exhibitorexhibitorName, nameof(exhibitorexhibitorName), required: false);
            WorkflowValue.Validate(exhibitorexhibitorNameLine2, nameof(exhibitorexhibitorNameLine2), required: false);
            WorkflowValue.Validate(exhibitorfax, nameof(exhibitorfax), required: false);
            WorkflowValue.Validate(exhibitorfield1, nameof(exhibitorfield1), required: false);
            WorkflowValue.Validate(exhibitorfield2, nameof(exhibitorfield2), required: false);
            WorkflowValue.Validate(exhibitorfield3, nameof(exhibitorfield3), required: false);
            WorkflowValue.Validate(exhibitorfield4, nameof(exhibitorfield4), required: false);
            WorkflowValue.Validate(exhibitorfield5, nameof(exhibitorfield5), required: false);
            WorkflowValue.Validate(exhibitorfield6, nameof(exhibitorfield6), required: false);
            WorkflowValue.Validate(exhibitorfield7, nameof(exhibitorfield7), required: false);
            WorkflowValue.Validate(exhibitorfield8, nameof(exhibitorfield8), required: false);
            WorkflowValue.Validate(exhibitorfield9, nameof(exhibitorfield9), required: false);
            WorkflowValue.Validate(exhibitornickName, nameof(exhibitornickName), required: false);
            WorkflowValue.Validate(exhibitorsalutation, nameof(exhibitorsalutation), required: false);
            WorkflowValue.Validate(exhibitortitle, nameof(exhibitortitle), required: false);
            WorkflowValue.Validate(exhibitorphone, nameof(exhibitorphone), required: false);
            WorkflowValue.Validate(exhibitorpostalCode, nameof(exhibitorpostalCode), required: false);
            WorkflowValue.Validate(exhibitorprimaryGroup, nameof(exhibitorprimaryGroup), required: false);
            WorkflowValue.Validate(exhibitorpriorityPoints, nameof(exhibitorpriorityPoints), required: false);
            WorkflowValue.Validate(exhibitorproductDescription, nameof(exhibitorproductDescription), required: false);
            WorkflowValue.Validate(exhibitorstate, nameof(exhibitorstate), required: false);
            WorkflowValue.Validate(exhibitorwebSite, nameof(exhibitorwebSite), required: false);
            return new DeferredBodyAction<Exhibitor>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/exhibitors/add", ExpressionConverter.ConvertWithUrlEncoding(clientName, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        [WorkflowExpressionFactory(nameof(__BuildExhibitorsUpdateExhibitor))]
        public IBodyWorkflowAction<Exhibitor> ExhibitorsUpdateExhibitor([WorkflowExpression] Func<string> clientName, [WorkflowExpression] Func<string> exhibitorexhibitorId, [WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> databaseName, [WorkflowExpression] Func<string> exhibitoraddress1 = null, [WorkflowExpression] Func<string> exhibitoraddress2 = null, [WorkflowExpression] Func<string> exhibitorcity = null, [WorkflowExpression] Func<string> exhibitorcomments = null, [WorkflowExpression] Func<string> exhibitorcomments2 = null, [WorkflowExpression] Func<string> exhibitorcontact = null, [WorkflowExpression] Func<string> exhibitorcountry = null, [WorkflowExpression] Func<string> exhibitorcellPhone = null, [WorkflowExpression] Func<string> exhibitordisplayOnDrawing = null, [WorkflowExpression] Func<string> exhibitordoingBusinessAs = null, [WorkflowExpression] Func<string> exhibitordoingBusinessAsDisplayOnDrawing = null, [WorkflowExpression] Func<string> exhibitoremail = null, [WorkflowExpression] Func<string> exhibitorexhibitorName = null, [WorkflowExpression] Func<string> exhibitorexhibitorNameLine2 = null, [WorkflowExpression] Func<string> exhibitorfax = null, [WorkflowExpression] Func<string> exhibitorfield1 = null, [WorkflowExpression] Func<string> exhibitorfield2 = null, [WorkflowExpression] Func<string> exhibitorfield3 = null, [WorkflowExpression] Func<string> exhibitorfield4 = null, [WorkflowExpression] Func<string> exhibitorfield5 = null, [WorkflowExpression] Func<string> exhibitorfield6 = null, [WorkflowExpression] Func<string> exhibitorfield7 = null, [WorkflowExpression] Func<string> exhibitorfield8 = null, [WorkflowExpression] Func<string> exhibitorfield9 = null, [WorkflowExpression] Func<string> exhibitornickName = null, [WorkflowExpression] Func<string> exhibitorsalutation = null, [WorkflowExpression] Func<string> exhibitortitle = null, [WorkflowExpression] Func<string> exhibitorphone = null, [WorkflowExpression] Func<string> exhibitorpostalCode = null, [WorkflowExpression] Func<string> exhibitorprimaryGroup = null, [WorkflowExpression] Func<string> exhibitorpriorityPoints = null, [WorkflowExpression] Func<string> exhibitorproductDescription = null, [WorkflowExpression] Func<string> exhibitorstate = null, [WorkflowExpression] Func<string> exhibitorwebSite = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Exhibitor> __BuildExhibitorsUpdateExhibitor(WorkflowValue<string> clientName, WorkflowValue<string> exhibitorexhibitorId, WorkflowValue<string> id, WorkflowValue<string> databaseName, WorkflowValue<string> exhibitoraddress1 = null, WorkflowValue<string> exhibitoraddress2 = null, WorkflowValue<string> exhibitorcity = null, WorkflowValue<string> exhibitorcomments = null, WorkflowValue<string> exhibitorcomments2 = null, WorkflowValue<string> exhibitorcontact = null, WorkflowValue<string> exhibitorcountry = null, WorkflowValue<string> exhibitorcellPhone = null, WorkflowValue<string> exhibitordisplayOnDrawing = null, WorkflowValue<string> exhibitordoingBusinessAs = null, WorkflowValue<string> exhibitordoingBusinessAsDisplayOnDrawing = null, WorkflowValue<string> exhibitoremail = null, WorkflowValue<string> exhibitorexhibitorName = null, WorkflowValue<string> exhibitorexhibitorNameLine2 = null, WorkflowValue<string> exhibitorfax = null, WorkflowValue<string> exhibitorfield1 = null, WorkflowValue<string> exhibitorfield2 = null, WorkflowValue<string> exhibitorfield3 = null, WorkflowValue<string> exhibitorfield4 = null, WorkflowValue<string> exhibitorfield5 = null, WorkflowValue<string> exhibitorfield6 = null, WorkflowValue<string> exhibitorfield7 = null, WorkflowValue<string> exhibitorfield8 = null, WorkflowValue<string> exhibitorfield9 = null, WorkflowValue<string> exhibitornickName = null, WorkflowValue<string> exhibitorsalutation = null, WorkflowValue<string> exhibitortitle = null, WorkflowValue<string> exhibitorphone = null, WorkflowValue<string> exhibitorpostalCode = null, WorkflowValue<string> exhibitorprimaryGroup = null, WorkflowValue<string> exhibitorpriorityPoints = null, WorkflowValue<string> exhibitorproductDescription = null, WorkflowValue<string> exhibitorstate = null, WorkflowValue<string> exhibitorwebSite = null)
        {
            WorkflowValue.Validate(clientName, nameof(clientName), required: true);
            WorkflowValue.Validate(exhibitorexhibitorId, nameof(exhibitorexhibitorId), required: true);
            WorkflowValue.Validate(id, nameof(id), required: true);
            WorkflowValue.Validate(databaseName, nameof(databaseName), required: true);
            WorkflowValue.Validate(exhibitoraddress1, nameof(exhibitoraddress1), required: false);
            WorkflowValue.Validate(exhibitoraddress2, nameof(exhibitoraddress2), required: false);
            WorkflowValue.Validate(exhibitorcity, nameof(exhibitorcity), required: false);
            WorkflowValue.Validate(exhibitorcomments, nameof(exhibitorcomments), required: false);
            WorkflowValue.Validate(exhibitorcomments2, nameof(exhibitorcomments2), required: false);
            WorkflowValue.Validate(exhibitorcontact, nameof(exhibitorcontact), required: false);
            WorkflowValue.Validate(exhibitorcountry, nameof(exhibitorcountry), required: false);
            WorkflowValue.Validate(exhibitorcellPhone, nameof(exhibitorcellPhone), required: false);
            WorkflowValue.Validate(exhibitordisplayOnDrawing, nameof(exhibitordisplayOnDrawing), required: false);
            WorkflowValue.Validate(exhibitordoingBusinessAs, nameof(exhibitordoingBusinessAs), required: false);
            WorkflowValue.Validate(exhibitordoingBusinessAsDisplayOnDrawing, nameof(exhibitordoingBusinessAsDisplayOnDrawing), required: false);
            WorkflowValue.Validate(exhibitoremail, nameof(exhibitoremail), required: false);
            WorkflowValue.Validate(exhibitorexhibitorName, nameof(exhibitorexhibitorName), required: false);
            WorkflowValue.Validate(exhibitorexhibitorNameLine2, nameof(exhibitorexhibitorNameLine2), required: false);
            WorkflowValue.Validate(exhibitorfax, nameof(exhibitorfax), required: false);
            WorkflowValue.Validate(exhibitorfield1, nameof(exhibitorfield1), required: false);
            WorkflowValue.Validate(exhibitorfield2, nameof(exhibitorfield2), required: false);
            WorkflowValue.Validate(exhibitorfield3, nameof(exhibitorfield3), required: false);
            WorkflowValue.Validate(exhibitorfield4, nameof(exhibitorfield4), required: false);
            WorkflowValue.Validate(exhibitorfield5, nameof(exhibitorfield5), required: false);
            WorkflowValue.Validate(exhibitorfield6, nameof(exhibitorfield6), required: false);
            WorkflowValue.Validate(exhibitorfield7, nameof(exhibitorfield7), required: false);
            WorkflowValue.Validate(exhibitorfield8, nameof(exhibitorfield8), required: false);
            WorkflowValue.Validate(exhibitorfield9, nameof(exhibitorfield9), required: false);
            WorkflowValue.Validate(exhibitornickName, nameof(exhibitornickName), required: false);
            WorkflowValue.Validate(exhibitorsalutation, nameof(exhibitorsalutation), required: false);
            WorkflowValue.Validate(exhibitortitle, nameof(exhibitortitle), required: false);
            WorkflowValue.Validate(exhibitorphone, nameof(exhibitorphone), required: false);
            WorkflowValue.Validate(exhibitorpostalCode, nameof(exhibitorpostalCode), required: false);
            WorkflowValue.Validate(exhibitorprimaryGroup, nameof(exhibitorprimaryGroup), required: false);
            WorkflowValue.Validate(exhibitorpriorityPoints, nameof(exhibitorpriorityPoints), required: false);
            WorkflowValue.Validate(exhibitorproductDescription, nameof(exhibitorproductDescription), required: false);
            WorkflowValue.Validate(exhibitorstate, nameof(exhibitorstate), required: false);
            WorkflowValue.Validate(exhibitorwebSite, nameof(exhibitorwebSite), required: false);
            return new DeferredBodyAction<Exhibitor>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/exhibitors/update", ExpressionConverter.ConvertWithUrlEncoding(clientName, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        [WorkflowExpressionFactory(nameof(__BuildExhibitorsDeleteExhibitor))]
        public IBodyWorkflowAction<JToken> ExhibitorsDeleteExhibitor([WorkflowExpression] Func<string> clientName, [WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> databaseName)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildExhibitorsDeleteExhibitor(WorkflowValue<string> clientName, WorkflowValue<string> id, WorkflowValue<string> databaseName)
        {
            WorkflowValue.Validate(clientName, nameof(clientName), required: true);
            WorkflowValue.Validate(id, nameof(id), required: true);
            WorkflowValue.Validate(databaseName, nameof(databaseName), required: true);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/exhibitors/delete", ExpressionConverter.ConvertWithUrlEncoding(clientName, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = ExpressionConverter.Convert(id);
                callPayload.Queries["databaseName"] = ExpressionConverter.Convert(databaseName);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        [WorkflowExpressionFactory(nameof(__BuildFinancialsGetAllTransactions))]
        public IBodyWorkflowAction<Transaction[]> FinancialsGetAllTransactions([WorkflowExpression] Func<string> clientName, [WorkflowExpression] Func<string> databaseName, [WorkflowExpression] Func<string> startDate = null, [WorkflowExpression] Func<string> endDate = null, [WorkflowExpression] Func<string> exhibitorId = null, [WorkflowExpression] Func<string> boothNumber = null, [WorkflowExpression] Func<string> expocadUser = null, [WorkflowExpression] Func<string> glCode = null, [WorkflowExpression] Func<reversedFilterInput> reversedFilter = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Transaction[]> __BuildFinancialsGetAllTransactions(WorkflowValue<string> clientName, WorkflowValue<string> databaseName, WorkflowValue<string> startDate = null, WorkflowValue<string> endDate = null, WorkflowValue<string> exhibitorId = null, WorkflowValue<string> boothNumber = null, WorkflowValue<string> expocadUser = null, WorkflowValue<string> glCode = null, WorkflowValue<reversedFilterInput> reversedFilter = null)
        {
            WorkflowValue.Validate(clientName, nameof(clientName), required: true);
            WorkflowValue.Validate(databaseName, nameof(databaseName), required: true);
            WorkflowValue.Validate(startDate, nameof(startDate), required: false);
            WorkflowValue.Validate(endDate, nameof(endDate), required: false);
            WorkflowValue.Validate(exhibitorId, nameof(exhibitorId), required: false);
            WorkflowValue.Validate(boothNumber, nameof(boothNumber), required: false);
            WorkflowValue.Validate(expocadUser, nameof(expocadUser), required: false);
            WorkflowValue.Validate(glCode, nameof(glCode), required: false);
            WorkflowValue.Validate(reversedFilter, nameof(reversedFilter), required: false);
            return new DeferredBodyAction<Transaction[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/financials/transactions", ExpressionConverter.ConvertWithUrlEncoding(clientName, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        [WorkflowExpressionFactory(nameof(__BuildFinancialsGet))]
        public IBodyWorkflowAction<BoothFinancial> FinancialsGet([WorkflowExpression] Func<string> clientName, [WorkflowExpression] Func<string> boothNumber, [WorkflowExpression] Func<string> databaseName)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BoothFinancial> __BuildFinancialsGet(WorkflowValue<string> clientName, WorkflowValue<string> boothNumber, WorkflowValue<string> databaseName)
        {
            WorkflowValue.Validate(clientName, nameof(clientName), required: true);
            WorkflowValue.Validate(boothNumber, nameof(boothNumber), required: true);
            WorkflowValue.Validate(databaseName, nameof(databaseName), required: true);
            return new DeferredBodyAction<BoothFinancial>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/financials/booths", ExpressionConverter.ConvertWithUrlEncoding(clientName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["boothNumber"] = ExpressionConverter.Convert(boothNumber);
                callPayload.Queries["databaseName"] = ExpressionConverter.Convert(databaseName);
                return new ApiConnectionAction<BoothFinancial>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        [WorkflowExpressionFactory(nameof(__BuildFinancialsGetInvoice))]
        public IBodyWorkflowAction<Invoice> FinancialsGetInvoice([WorkflowExpression] Func<string> clientName, [WorkflowExpression] Func<string> databaseName, [WorkflowExpression] Func<string> invoiceNo = null, [WorkflowExpression] Func<string> exhibitorId = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Invoice> __BuildFinancialsGetInvoice(WorkflowValue<string> clientName, WorkflowValue<string> databaseName, WorkflowValue<string> invoiceNo = null, WorkflowValue<string> exhibitorId = null)
        {
            WorkflowValue.Validate(clientName, nameof(clientName), required: true);
            WorkflowValue.Validate(databaseName, nameof(databaseName), required: true);
            WorkflowValue.Validate(invoiceNo, nameof(invoiceNo), required: false);
            WorkflowValue.Validate(exhibitorId, nameof(exhibitorId), required: false);
            return new DeferredBodyAction<Invoice>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/financials/invoices", ExpressionConverter.ConvertWithUrlEncoding(clientName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["databaseName"] = ExpressionConverter.Convert(databaseName);
                if (invoiceNo != null)
                    callPayload.Queries["invoiceNo"] = ExpressionConverter.Convert(invoiceNo);
                if (exhibitorId != null)
                    callPayload.Queries["exhibitorId"] = ExpressionConverter.Convert(exhibitorId);
                return new ApiConnectionAction<Invoice>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        [WorkflowExpressionFactory(nameof(__BuildFinancialsGetAllInvoices))]
        public IBodyWorkflowAction<Invoice[]> FinancialsGetAllInvoices([WorkflowExpression] Func<string> clientName, [WorkflowExpression] Func<string> databaseName)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Invoice[]> __BuildFinancialsGetAllInvoices(WorkflowValue<string> clientName, WorkflowValue<string> databaseName)
        {
            WorkflowValue.Validate(clientName, nameof(clientName), required: true);
            WorkflowValue.Validate(databaseName, nameof(databaseName), required: true);
            return new DeferredBodyAction<Invoice[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/financials/invoices/all", ExpressionConverter.ConvertWithUrlEncoding(clientName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["databaseName"] = ExpressionConverter.Convert(databaseName);
                return new ApiConnectionAction<Invoice[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        [WorkflowExpressionFactory(nameof(__BuildFinancialsGetRequestItemList))]
        public IBodyWorkflowAction<MasterRequestItem[]> FinancialsGetRequestItemList([WorkflowExpression] Func<string> clientName, [WorkflowExpression] Func<string> databaseName, [WorkflowExpression] Func<string> glCode = null, [WorkflowExpression] Func<string> transactionCode = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MasterRequestItem[]> __BuildFinancialsGetRequestItemList(WorkflowValue<string> clientName, WorkflowValue<string> databaseName, WorkflowValue<string> glCode = null, WorkflowValue<string> transactionCode = null)
        {
            WorkflowValue.Validate(clientName, nameof(clientName), required: true);
            WorkflowValue.Validate(databaseName, nameof(databaseName), required: true);
            WorkflowValue.Validate(glCode, nameof(glCode), required: false);
            WorkflowValue.Validate(transactionCode, nameof(transactionCode), required: false);
            return new DeferredBodyAction<MasterRequestItem[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/financials/requestitemlist", ExpressionConverter.ConvertWithUrlEncoding(clientName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["databaseName"] = ExpressionConverter.Convert(databaseName);
                if (glCode != null)
                    callPayload.Queries["glCode"] = ExpressionConverter.Convert(glCode);
                if (transactionCode != null)
                    callPayload.Queries["transactionCode"] = ExpressionConverter.Convert(transactionCode);
                return new ApiConnectionAction<MasterRequestItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        [WorkflowExpressionFactory(nameof(__BuildFinancialsGetAssignedRequestItems))]
        public IBodyWorkflowAction<InvoiceRequestItem[]> FinancialsGetAssignedRequestItems([WorkflowExpression] Func<string> clientName, [WorkflowExpression] Func<string> databaseName, [WorkflowExpression] Func<string> exhibitorId = null, [WorkflowExpression] Func<string> invoiceNumber = null, [WorkflowExpression] Func<string> startDate = null, [WorkflowExpression] Func<string> endDate = null, [WorkflowExpression] Func<string> booth = null, [WorkflowExpression] Func<string> glCode = null, [WorkflowExpression] Func<string> transactionCode = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<InvoiceRequestItem[]> __BuildFinancialsGetAssignedRequestItems(WorkflowValue<string> clientName, WorkflowValue<string> databaseName, WorkflowValue<string> exhibitorId = null, WorkflowValue<string> invoiceNumber = null, WorkflowValue<string> startDate = null, WorkflowValue<string> endDate = null, WorkflowValue<string> booth = null, WorkflowValue<string> glCode = null, WorkflowValue<string> transactionCode = null)
        {
            WorkflowValue.Validate(clientName, nameof(clientName), required: true);
            WorkflowValue.Validate(databaseName, nameof(databaseName), required: true);
            WorkflowValue.Validate(exhibitorId, nameof(exhibitorId), required: false);
            WorkflowValue.Validate(invoiceNumber, nameof(invoiceNumber), required: false);
            WorkflowValue.Validate(startDate, nameof(startDate), required: false);
            WorkflowValue.Validate(endDate, nameof(endDate), required: false);
            WorkflowValue.Validate(booth, nameof(booth), required: false);
            WorkflowValue.Validate(glCode, nameof(glCode), required: false);
            WorkflowValue.Validate(transactionCode, nameof(transactionCode), required: false);
            return new DeferredBodyAction<InvoiceRequestItem[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/financials/requestitems", ExpressionConverter.ConvertWithUrlEncoding(clientName, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        [WorkflowExpressionFactory(nameof(__BuildFinancialsGetPaymentTypeList))]
        public IBodyWorkflowAction<PaymentTypeItem[]> FinancialsGetPaymentTypeList([WorkflowExpression] Func<string> clientName, [WorkflowExpression] Func<string> databaseName)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PaymentTypeItem[]> __BuildFinancialsGetPaymentTypeList(WorkflowValue<string> clientName, WorkflowValue<string> databaseName)
        {
            WorkflowValue.Validate(clientName, nameof(clientName), required: true);
            WorkflowValue.Validate(databaseName, nameof(databaseName), required: true);
            return new DeferredBodyAction<PaymentTypeItem[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/financials/paymenttypelist", ExpressionConverter.ConvertWithUrlEncoding(clientName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["databaseName"] = ExpressionConverter.Convert(databaseName);
                return new ApiConnectionAction<PaymentTypeItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        [WorkflowExpressionFactory(nameof(__BuildFinancialsGetPayments))]
        public IBodyWorkflowAction<InvoicePayment[]> FinancialsGetPayments([WorkflowExpression] Func<string> clientName, [WorkflowExpression] Func<string> databaseName, [WorkflowExpression] Func<string> exhibitorId = null, [WorkflowExpression] Func<string> depositId = null, [WorkflowExpression] Func<string> invoiceNumber = null, [WorkflowExpression] Func<string> startDate = null, [WorkflowExpression] Func<string> endDate = null, [WorkflowExpression] Func<string> paymentTypeCategory = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<InvoicePayment[]> __BuildFinancialsGetPayments(WorkflowValue<string> clientName, WorkflowValue<string> databaseName, WorkflowValue<string> exhibitorId = null, WorkflowValue<string> depositId = null, WorkflowValue<string> invoiceNumber = null, WorkflowValue<string> startDate = null, WorkflowValue<string> endDate = null, WorkflowValue<string> paymentTypeCategory = null)
        {
            WorkflowValue.Validate(clientName, nameof(clientName), required: true);
            WorkflowValue.Validate(databaseName, nameof(databaseName), required: true);
            WorkflowValue.Validate(exhibitorId, nameof(exhibitorId), required: false);
            WorkflowValue.Validate(depositId, nameof(depositId), required: false);
            WorkflowValue.Validate(invoiceNumber, nameof(invoiceNumber), required: false);
            WorkflowValue.Validate(startDate, nameof(startDate), required: false);
            WorkflowValue.Validate(endDate, nameof(endDate), required: false);
            WorkflowValue.Validate(paymentTypeCategory, nameof(paymentTypeCategory), required: false);
            return new DeferredBodyAction<InvoicePayment[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/financials/payments", ExpressionConverter.ConvertWithUrlEncoding(clientName, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        [WorkflowExpressionFactory(nameof(__BuildPavilionsGetAllPavilions))]
        public IBodyWorkflowAction<Pavilion[]> PavilionsGetAllPavilions([WorkflowExpression] Func<string> clientName, [WorkflowExpression] Func<string> databaseName)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Pavilion[]> __BuildPavilionsGetAllPavilions(WorkflowValue<string> clientName, WorkflowValue<string> databaseName)
        {
            WorkflowValue.Validate(clientName, nameof(clientName), required: true);
            WorkflowValue.Validate(databaseName, nameof(databaseName), required: true);
            return new DeferredBodyAction<Pavilion[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/pavilions/all", ExpressionConverter.ConvertWithUrlEncoding(clientName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["databaseName"] = ExpressionConverter.Convert(databaseName);
                return new ApiConnectionAction<Pavilion[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        [WorkflowExpressionFactory(nameof(__BuildRatePlansGetDefaultRatePlan))]
        public IBodyWorkflowAction<RatePlan> RatePlansGetDefaultRatePlan([WorkflowExpression] Func<string> clientName, [WorkflowExpression] Func<string> databaseName)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<RatePlan> __BuildRatePlansGetDefaultRatePlan(WorkflowValue<string> clientName, WorkflowValue<string> databaseName)
        {
            WorkflowValue.Validate(clientName, nameof(clientName), required: true);
            WorkflowValue.Validate(databaseName, nameof(databaseName), required: true);
            return new DeferredBodyAction<RatePlan>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/rateplans/default", ExpressionConverter.ConvertWithUrlEncoding(clientName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["databaseName"] = ExpressionConverter.Convert(databaseName);
                return new ApiConnectionAction<RatePlan>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        [WorkflowExpressionFactory(nameof(__BuildRatePlansSetDefaultRatePlan))]
        public IBodyWorkflowAction<JToken> RatePlansSetDefaultRatePlan([WorkflowExpression] Func<string> clientName, [WorkflowExpression] Func<string> databaseName, [WorkflowExpression] Func<string> name)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildRatePlansSetDefaultRatePlan(WorkflowValue<string> clientName, WorkflowValue<string> databaseName, WorkflowValue<string> name)
        {
            WorkflowValue.Validate(clientName, nameof(clientName), required: true);
            WorkflowValue.Validate(databaseName, nameof(databaseName), required: true);
            WorkflowValue.Validate(name, nameof(name), required: true);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/rateplans/default", ExpressionConverter.ConvertWithUrlEncoding(clientName, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["databaseName"] = ExpressionConverter.Convert(databaseName);
                callPayload.Queries["name"] = ExpressionConverter.Convert(name);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        [WorkflowExpressionFactory(nameof(__BuildRatePlansGetAllRatePlans))]
        public IBodyWorkflowAction<RatePlan[]> RatePlansGetAllRatePlans([WorkflowExpression] Func<string> clientName, [WorkflowExpression] Func<string> databaseName)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<RatePlan[]> __BuildRatePlansGetAllRatePlans(WorkflowValue<string> clientName, WorkflowValue<string> databaseName)
        {
            WorkflowValue.Validate(clientName, nameof(clientName), required: true);
            WorkflowValue.Validate(databaseName, nameof(databaseName), required: true);
            return new DeferredBodyAction<RatePlan[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/rateplans/all", ExpressionConverter.ConvertWithUrlEncoding(clientName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["databaseName"] = ExpressionConverter.Convert(databaseName);
                return new ApiConnectionAction<RatePlan[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        [WorkflowExpressionFactory(nameof(__BuildRatePlansAddRatePlan))]
        public IBodyWorkflowAction<RatePlan> RatePlansAddRatePlan([WorkflowExpression] Func<string> clientName, [WorkflowExpression] Func<string> databaseName, [WorkflowExpression] Func<string> ratePlanname, [WorkflowExpression] Func<string> ratePlanshortCode, [WorkflowExpression] Func<double> ratePlangrossRate, [WorkflowExpression] Func<double> ratePlanfixedDiscountRate, [WorkflowExpression] Func<double> ratePlanpercentDiscountRate, [WorkflowExpression] Func<bool> ratePlanisFixed)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<RatePlan> __BuildRatePlansAddRatePlan(WorkflowValue<string> clientName, WorkflowValue<string> databaseName, WorkflowValue<string> ratePlanname, WorkflowValue<string> ratePlanshortCode, WorkflowValue<double> ratePlangrossRate, WorkflowValue<double> ratePlanfixedDiscountRate, WorkflowValue<double> ratePlanpercentDiscountRate, WorkflowValue<bool> ratePlanisFixed)
        {
            WorkflowValue.Validate(clientName, nameof(clientName), required: true);
            WorkflowValue.Validate(databaseName, nameof(databaseName), required: true);
            WorkflowValue.Validate(ratePlanname, nameof(ratePlanname), required: true);
            WorkflowValue.Validate(ratePlanshortCode, nameof(ratePlanshortCode), required: true);
            WorkflowValue.Validate(ratePlangrossRate, nameof(ratePlangrossRate), required: true);
            WorkflowValue.Validate(ratePlanfixedDiscountRate, nameof(ratePlanfixedDiscountRate), required: true);
            WorkflowValue.Validate(ratePlanpercentDiscountRate, nameof(ratePlanpercentDiscountRate), required: true);
            WorkflowValue.Validate(ratePlanisFixed, nameof(ratePlanisFixed), required: true);
            return new DeferredBodyAction<RatePlan>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/rateplans/add", ExpressionConverter.ConvertWithUrlEncoding(clientName, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        [WorkflowExpressionFactory(nameof(__BuildShowInShowsGetAllShowinShows))]
        public IBodyWorkflowAction<ShowInShow[]> ShowInShowsGetAllShowinShows([WorkflowExpression] Func<string> clientName, [WorkflowExpression] Func<string> databaseName)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ShowInShow[]> __BuildShowInShowsGetAllShowinShows(WorkflowValue<string> clientName, WorkflowValue<string> databaseName)
        {
            WorkflowValue.Validate(clientName, nameof(clientName), required: true);
            WorkflowValue.Validate(databaseName, nameof(databaseName), required: true);
            return new DeferredBodyAction<ShowInShow[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/showinshows/all", ExpressionConverter.ConvertWithUrlEncoding(clientName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["databaseName"] = ExpressionConverter.Convert(databaseName);
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
