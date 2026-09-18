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
        public IBodyWorkflowAction<Booth> BoothsGet([WorkflowExpression] Func<string> clientName, [WorkflowExpression] Func<string> boothNumber, [WorkflowExpression] Func<string> databaseName)
        {
            SourceExpression.Validate(clientName, nameof(clientName), required: true);
            SourceExpression.Validate(boothNumber, nameof(boothNumber), required: true);
            SourceExpression.Validate(databaseName, nameof(databaseName), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/booths", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(clientName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["boothNumber"] = SourceExpressionConverter.ConvertO(boothNumber);
                callPayload.Queries["databaseName"] = SourceExpressionConverter.ConvertO(databaseName);
                return callPayload;
            }

            return new ApiConnectionAction<Booth>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<Booth[]> BoothsGetAllBooths([WorkflowExpression] Func<string> clientName, [WorkflowExpression] Func<string> databaseName, [WorkflowExpression] Func<deletedFilterInput> deletedFilter = null)
        {
            SourceExpression.Validate(clientName, nameof(clientName), required: true);
            SourceExpression.Validate(databaseName, nameof(databaseName), required: true);
            SourceExpression.Validate(deletedFilter, nameof(deletedFilter), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/booths/all", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(clientName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["databaseName"] = SourceExpressionConverter.ConvertO(databaseName);
                if (deletedFilter != null)
                    callPayload.Queries["deletedFilter"] = SourceExpressionConverter.Convert(deletedFilter);
                return callPayload;
            }

            return new ApiConnectionAction<Booth[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<Booth[]> BoothsGetAllAvailableBooths([WorkflowExpression] Func<string> clientName, [WorkflowExpression] Func<string> databaseName)
        {
            SourceExpression.Validate(clientName, nameof(clientName), required: true);
            SourceExpression.Validate(databaseName, nameof(databaseName), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/booths/all/available", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(clientName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["databaseName"] = SourceExpressionConverter.ConvertO(databaseName);
                return callPayload;
            }

            return new ApiConnectionAction<Booth[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<Booth[]> BoothsGetAllRentedBooths([WorkflowExpression] Func<string> clientName, [WorkflowExpression] Func<string> databaseName)
        {
            SourceExpression.Validate(clientName, nameof(clientName), required: true);
            SourceExpression.Validate(databaseName, nameof(databaseName), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/booths/all/rented", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(clientName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["databaseName"] = SourceExpressionConverter.ConvertO(databaseName);
                return callPayload;
            }

            return new ApiConnectionAction<Booth[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<JToken> BoothsRentBooth([WorkflowExpression] Func<string> clientName, [WorkflowExpression] Func<string> boothNumber, [WorkflowExpression] Func<string> exhibitorId, [WorkflowExpression] Func<string> databaseName, [WorkflowExpression] Func<string> ratePlan = null, [WorkflowExpression] Func<string> status = null, [WorkflowExpression] Func<string> comment = null)
        {
            SourceExpression.Validate(clientName, nameof(clientName), required: true);
            SourceExpression.Validate(boothNumber, nameof(boothNumber), required: true);
            SourceExpression.Validate(exhibitorId, nameof(exhibitorId), required: true);
            SourceExpression.Validate(databaseName, nameof(databaseName), required: true);
            SourceExpression.Validate(ratePlan, nameof(ratePlan), required: false);
            SourceExpression.Validate(status, nameof(status), required: false);
            SourceExpression.Validate(comment, nameof(comment), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/booths/rent", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(clientName, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["boothNumber"] = SourceExpressionConverter.ConvertO(boothNumber);
                callPayload.Queries["exhibitorId"] = SourceExpressionConverter.ConvertO(exhibitorId);
                callPayload.Queries["databaseName"] = SourceExpressionConverter.ConvertO(databaseName);
                if (ratePlan != null)
                    callPayload.Queries["ratePlan"] = SourceExpressionConverter.ConvertO(ratePlan);
                if (status != null)
                    callPayload.Queries["status"] = SourceExpressionConverter.ConvertO(status);
                if (comment != null)
                    callPayload.Queries["comment"] = SourceExpressionConverter.ConvertO(comment);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<JToken> BoothsUnRentBooth([WorkflowExpression] Func<string> clientName, [WorkflowExpression] Func<string> boothNumber, [WorkflowExpression] Func<string> databaseName)
        {
            SourceExpression.Validate(clientName, nameof(clientName), required: true);
            SourceExpression.Validate(boothNumber, nameof(boothNumber), required: true);
            SourceExpression.Validate(databaseName, nameof(databaseName), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/booths/unrent", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(clientName, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["boothNumber"] = SourceExpressionConverter.ConvertO(boothNumber);
                callPayload.Queries["databaseName"] = SourceExpressionConverter.ConvertO(databaseName);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<JToken> BoothsHoldBooth([WorkflowExpression] Func<string> clientName, [WorkflowExpression] Func<string> boothNumber, [WorkflowExpression] Func<string> databaseName, [WorkflowExpression] Func<string> exhibitorId = null, [WorkflowExpression] Func<string> exhibitorName = null, [WorkflowExpression] Func<string> comment = null)
        {
            SourceExpression.Validate(clientName, nameof(clientName), required: true);
            SourceExpression.Validate(boothNumber, nameof(boothNumber), required: true);
            SourceExpression.Validate(databaseName, nameof(databaseName), required: true);
            SourceExpression.Validate(exhibitorId, nameof(exhibitorId), required: false);
            SourceExpression.Validate(exhibitorName, nameof(exhibitorName), required: false);
            SourceExpression.Validate(comment, nameof(comment), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/booths/hold", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(clientName, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["boothNumber"] = SourceExpressionConverter.ConvertO(boothNumber);
                callPayload.Queries["databaseName"] = SourceExpressionConverter.ConvertO(databaseName);
                if (exhibitorId != null)
                    callPayload.Queries["exhibitorId"] = SourceExpressionConverter.ConvertO(exhibitorId);
                if (exhibitorName != null)
                    callPayload.Queries["exhibitorName"] = SourceExpressionConverter.ConvertO(exhibitorName);
                if (comment != null)
                    callPayload.Queries["comment"] = SourceExpressionConverter.ConvertO(comment);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<JToken> BoothsUnHoldBooth([WorkflowExpression] Func<string> clientName, [WorkflowExpression] Func<string> boothNumber, [WorkflowExpression] Func<string> databaseName)
        {
            SourceExpression.Validate(clientName, nameof(clientName), required: true);
            SourceExpression.Validate(boothNumber, nameof(boothNumber), required: true);
            SourceExpression.Validate(databaseName, nameof(databaseName), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/booths/unhold", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(clientName, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["boothNumber"] = SourceExpressionConverter.ConvertO(boothNumber);
                callPayload.Queries["databaseName"] = SourceExpressionConverter.ConvertO(databaseName);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<JToken> BoothsRentToHold([WorkflowExpression] Func<string> clientName, [WorkflowExpression] Func<string> boothNumber, [WorkflowExpression] Func<string> databaseName)
        {
            SourceExpression.Validate(clientName, nameof(clientName), required: true);
            SourceExpression.Validate(boothNumber, nameof(boothNumber), required: true);
            SourceExpression.Validate(databaseName, nameof(databaseName), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/booths/rentToHold", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(clientName, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["boothNumber"] = SourceExpressionConverter.ConvertO(boothNumber);
                callPayload.Queries["databaseName"] = SourceExpressionConverter.ConvertO(databaseName);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<JToken> BoothsHoldToRent([WorkflowExpression] Func<string> clientName, [WorkflowExpression] Func<string> boothNumber, [WorkflowExpression] Func<string> databaseName, [WorkflowExpression] Func<string> ratePlan = null)
        {
            SourceExpression.Validate(clientName, nameof(clientName), required: true);
            SourceExpression.Validate(boothNumber, nameof(boothNumber), required: true);
            SourceExpression.Validate(databaseName, nameof(databaseName), required: true);
            SourceExpression.Validate(ratePlan, nameof(ratePlan), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/booths/holdToRent", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(clientName, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["boothNumber"] = SourceExpressionConverter.ConvertO(boothNumber);
                callPayload.Queries["databaseName"] = SourceExpressionConverter.ConvertO(databaseName);
                if (ratePlan != null)
                    callPayload.Queries["ratePlan"] = SourceExpressionConverter.ConvertO(ratePlan);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<JToken> BoothsCombineBooths([WorkflowExpression] Func<string> clientName, [WorkflowExpression] Func<string> databaseName, [WorkflowExpression] Func<int> boundary, [WorkflowExpression] Func<string[]> boothNumbers = null)
        {
            SourceExpression.Validate(clientName, nameof(clientName), required: true);
            SourceExpression.Validate(databaseName, nameof(databaseName), required: true);
            SourceExpression.Validate(boundary, nameof(boundary), required: true);
            SourceExpression.Validate(boothNumbers, nameof(boothNumbers), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/booths/combine", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(clientName, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["databaseName"] = SourceExpressionConverter.ConvertO(databaseName);
                callPayload.Queries["boundary"] = SourceExpressionConverter.ConvertO(boundary);
                callPayload.Body = SourceExpressionConverter.ConvertToken(boothNumbers);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<JToken> BoothsUncombineBooth([WorkflowExpression] Func<string> clientName, [WorkflowExpression] Func<string> boothNumber, [WorkflowExpression] Func<string> databaseName)
        {
            SourceExpression.Validate(clientName, nameof(clientName), required: true);
            SourceExpression.Validate(boothNumber, nameof(boothNumber), required: true);
            SourceExpression.Validate(databaseName, nameof(databaseName), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/booths/uncombine", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(clientName, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["boothNumber"] = SourceExpressionConverter.ConvertO(boothNumber);
                callPayload.Queries["databaseName"] = SourceExpressionConverter.ConvertO(databaseName);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<JToken> BoothsDeleteBooths([WorkflowExpression] Func<string> clientName, [WorkflowExpression] Func<string> databaseName, [WorkflowExpression] Func<string[]> boothNumbers = null)
        {
            SourceExpression.Validate(clientName, nameof(clientName), required: true);
            SourceExpression.Validate(databaseName, nameof(databaseName), required: true);
            SourceExpression.Validate(boothNumbers, nameof(boothNumbers), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/booths/delete", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(clientName, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["databaseName"] = SourceExpressionConverter.ConvertO(databaseName);
                callPayload.Body = SourceExpressionConverter.ConvertToken(boothNumbers);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<JToken> BoothsUndeleteBooths([WorkflowExpression] Func<string> clientName, [WorkflowExpression] Func<string> databaseName, [WorkflowExpression] Func<string[]> boothNumbers = null)
        {
            SourceExpression.Validate(clientName, nameof(clientName), required: true);
            SourceExpression.Validate(databaseName, nameof(databaseName), required: true);
            SourceExpression.Validate(boothNumbers, nameof(boothNumbers), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/booths/undelete", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(clientName, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["databaseName"] = SourceExpressionConverter.ConvertO(databaseName);
                callPayload.Body = SourceExpressionConverter.ConvertToken(boothNumbers);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<JToken> BoothsChangeBoothNumber([WorkflowExpression] Func<string> clientName, [WorkflowExpression] Func<string> oldNumber, [WorkflowExpression] Func<string> newNumber, [WorkflowExpression] Func<string> databaseName)
        {
            SourceExpression.Validate(clientName, nameof(clientName), required: true);
            SourceExpression.Validate(oldNumber, nameof(oldNumber), required: true);
            SourceExpression.Validate(newNumber, nameof(newNumber), required: true);
            SourceExpression.Validate(databaseName, nameof(databaseName), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/booths/changenumber", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(clientName, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["oldNumber"] = SourceExpressionConverter.ConvertO(oldNumber);
                callPayload.Queries["newNumber"] = SourceExpressionConverter.ConvertO(newNumber);
                callPayload.Queries["databaseName"] = SourceExpressionConverter.ConvertO(databaseName);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<JToken> BoothsSetBoothClass([WorkflowExpression] Func<string> clientName, [WorkflowExpression] Func<string> classId, [WorkflowExpression] Func<string> boothNumber, [WorkflowExpression] Func<string> databaseName)
        {
            SourceExpression.Validate(clientName, nameof(clientName), required: true);
            SourceExpression.Validate(classId, nameof(classId), required: true);
            SourceExpression.Validate(boothNumber, nameof(boothNumber), required: true);
            SourceExpression.Validate(databaseName, nameof(databaseName), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/booths/classes/apply", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(clientName, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["classId"] = SourceExpressionConverter.ConvertO(classId);
                callPayload.Queries["boothNumber"] = SourceExpressionConverter.ConvertO(boothNumber);
                callPayload.Queries["databaseName"] = SourceExpressionConverter.ConvertO(databaseName);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<JToken> BoothsClearBoothClass([WorkflowExpression] Func<string> clientName, [WorkflowExpression] Func<string> classId, [WorkflowExpression] Func<string> boothNumber, [WorkflowExpression] Func<string> databaseName)
        {
            SourceExpression.Validate(clientName, nameof(clientName), required: true);
            SourceExpression.Validate(classId, nameof(classId), required: true);
            SourceExpression.Validate(boothNumber, nameof(boothNumber), required: true);
            SourceExpression.Validate(databaseName, nameof(databaseName), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/booths/classes/remove", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(clientName, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["classId"] = SourceExpressionConverter.ConvertO(classId);
                callPayload.Queries["boothNumber"] = SourceExpressionConverter.ConvertO(boothNumber);
                callPayload.Queries["databaseName"] = SourceExpressionConverter.ConvertO(databaseName);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<JToken> BoothsSetBoothDisplayName([WorkflowExpression] Func<string> clientName, [WorkflowExpression] Func<string> text, [WorkflowExpression] Func<string> boothNumber, [WorkflowExpression] Func<string> databaseName)
        {
            SourceExpression.Validate(clientName, nameof(clientName), required: true);
            SourceExpression.Validate(text, nameof(text), required: true);
            SourceExpression.Validate(boothNumber, nameof(boothNumber), required: true);
            SourceExpression.Validate(databaseName, nameof(databaseName), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/booths/displayNameOverride/set", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(clientName, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["text"] = SourceExpressionConverter.ConvertO(text);
                callPayload.Queries["boothNumber"] = SourceExpressionConverter.ConvertO(boothNumber);
                callPayload.Queries["databaseName"] = SourceExpressionConverter.ConvertO(databaseName);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<JToken> BoothsClearBoothDisplayName([WorkflowExpression] Func<string> clientName, [WorkflowExpression] Func<string> boothNumber, [WorkflowExpression] Func<string> databaseName)
        {
            SourceExpression.Validate(clientName, nameof(clientName), required: true);
            SourceExpression.Validate(boothNumber, nameof(boothNumber), required: true);
            SourceExpression.Validate(databaseName, nameof(databaseName), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/booths/displayNameOverride/reset", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(clientName, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["boothNumber"] = SourceExpressionConverter.ConvertO(boothNumber);
                callPayload.Queries["databaseName"] = SourceExpressionConverter.ConvertO(databaseName);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<JToken> BoothsAddChildExhibitor([WorkflowExpression] Func<string> clientName, [WorkflowExpression] Func<string> childExhibitorId, [WorkflowExpression] Func<string> boothNumber, [WorkflowExpression] Func<string> databaseName)
        {
            SourceExpression.Validate(clientName, nameof(clientName), required: true);
            SourceExpression.Validate(childExhibitorId, nameof(childExhibitorId), required: true);
            SourceExpression.Validate(boothNumber, nameof(boothNumber), required: true);
            SourceExpression.Validate(databaseName, nameof(databaseName), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/booths/childExhibitor/add", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(clientName, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["childExhibitorId"] = SourceExpressionConverter.ConvertO(childExhibitorId);
                callPayload.Queries["boothNumber"] = SourceExpressionConverter.ConvertO(boothNumber);
                callPayload.Queries["databaseName"] = SourceExpressionConverter.ConvertO(databaseName);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<JToken> BoothsRemoveChildExhibitor([WorkflowExpression] Func<string> clientName, [WorkflowExpression] Func<string> childExhibitorId, [WorkflowExpression] Func<string> boothNumber, [WorkflowExpression] Func<string> databaseName)
        {
            SourceExpression.Validate(clientName, nameof(clientName), required: true);
            SourceExpression.Validate(childExhibitorId, nameof(childExhibitorId), required: true);
            SourceExpression.Validate(boothNumber, nameof(boothNumber), required: true);
            SourceExpression.Validate(databaseName, nameof(databaseName), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/booths/childExhibitor/remove", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(clientName, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["childExhibitorId"] = SourceExpressionConverter.ConvertO(childExhibitorId);
                callPayload.Queries["boothNumber"] = SourceExpressionConverter.ConvertO(boothNumber);
                callPayload.Queries["databaseName"] = SourceExpressionConverter.ConvertO(databaseName);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<BoothClass> ClassesGet([WorkflowExpression] Func<string> clientName, [WorkflowExpression] Func<string> classId, [WorkflowExpression] Func<string> databaseName)
        {
            SourceExpression.Validate(clientName, nameof(clientName), required: true);
            SourceExpression.Validate(classId, nameof(classId), required: true);
            SourceExpression.Validate(databaseName, nameof(databaseName), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/classes", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(clientName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["classId"] = SourceExpressionConverter.ConvertO(classId);
                callPayload.Queries["databaseName"] = SourceExpressionConverter.ConvertO(databaseName);
                return callPayload;
            }

            return new ApiConnectionAction<BoothClass>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<BoothClass[]> ClassesGetAllBoothClasses([WorkflowExpression] Func<string> clientName, [WorkflowExpression] Func<string> databaseName)
        {
            SourceExpression.Validate(clientName, nameof(clientName), required: true);
            SourceExpression.Validate(databaseName, nameof(databaseName), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/classes/all", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(clientName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["databaseName"] = SourceExpressionConverter.ConvertO(databaseName);
                return callPayload;
            }

            return new ApiConnectionAction<BoothClass[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<BoothClass> ClassesCreate([WorkflowExpression] Func<string> clientName, [WorkflowExpression] Func<string> boothClassid, [WorkflowExpression] Func<int> boothClasskeepWhenCombined, [WorkflowExpression] Func<int> boothClasscountAsInventory, [WorkflowExpression] Func<string> databaseName, [WorkflowExpression] Func<string> boothClassname = null, [WorkflowExpression] Func<string> boothClassdescription = null, [WorkflowExpression] Func<string> boothClassprioritity = null, [WorkflowExpression] Func<int> boothClasscolor = null)
        {
            SourceExpression.Validate(clientName, nameof(clientName), required: true);
            SourceExpression.Validate(boothClassid, nameof(boothClassid), required: true);
            SourceExpression.Validate(boothClasskeepWhenCombined, nameof(boothClasskeepWhenCombined), required: true);
            SourceExpression.Validate(boothClasscountAsInventory, nameof(boothClasscountAsInventory), required: true);
            SourceExpression.Validate(databaseName, nameof(databaseName), required: true);
            SourceExpression.Validate(boothClassname, nameof(boothClassname), required: false);
            SourceExpression.Validate(boothClassdescription, nameof(boothClassdescription), required: false);
            SourceExpression.Validate(boothClassprioritity, nameof(boothClassprioritity), required: false);
            SourceExpression.Validate(boothClasscolor, nameof(boothClasscolor), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/classes/add", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(clientName, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["databaseName"] = SourceExpressionConverter.ConvertO(databaseName);
                var boothClass = new JObject();
                var boothClasspropCount = 0;
                boothClasspropCount++;
                boothClass["Id"] = SourceExpressionConverter.ConvertToken(boothClassid);
                if (boothClassname != null)
                {
                    boothClass["Name"] = SourceExpressionConverter.ConvertToken(boothClassname);
                    boothClasspropCount++;
                }

                if (boothClassdescription != null)
                {
                    boothClass["Description"] = SourceExpressionConverter.ConvertToken(boothClassdescription);
                    boothClasspropCount++;
                }

                boothClasspropCount++;
                boothClass["KeepWhenCombined"] = SourceExpressionConverter.ConvertToken(boothClasskeepWhenCombined);
                boothClasspropCount++;
                boothClass["CountAsInventory"] = SourceExpressionConverter.ConvertToken(boothClasscountAsInventory);
                if (boothClassprioritity != null)
                {
                    boothClass["Prioritity"] = SourceExpressionConverter.ConvertToken(boothClassprioritity);
                    boothClasspropCount++;
                }

                if (boothClasscolor != null)
                {
                    boothClass["Color"] = SourceExpressionConverter.ConvertToken(boothClasscolor);
                    boothClasspropCount++;
                }

                if (boothClasspropCount > 0)
                {
                    callPayload.Body = boothClass;
                }
                return callPayload;
            }

            return new ApiConnectionAction<BoothClass>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<BoothClass> ClassesUpdate([WorkflowExpression] Func<string> clientName, [WorkflowExpression] Func<string> boothClassid, [WorkflowExpression] Func<int> boothClasskeepWhenCombined, [WorkflowExpression] Func<int> boothClasscountAsInventory, [WorkflowExpression] Func<string> classId, [WorkflowExpression] Func<string> databaseName, [WorkflowExpression] Func<string> boothClassname = null, [WorkflowExpression] Func<string> boothClassdescription = null, [WorkflowExpression] Func<string> boothClassprioritity = null, [WorkflowExpression] Func<int> boothClasscolor = null)
        {
            SourceExpression.Validate(clientName, nameof(clientName), required: true);
            SourceExpression.Validate(boothClassid, nameof(boothClassid), required: true);
            SourceExpression.Validate(boothClasskeepWhenCombined, nameof(boothClasskeepWhenCombined), required: true);
            SourceExpression.Validate(boothClasscountAsInventory, nameof(boothClasscountAsInventory), required: true);
            SourceExpression.Validate(classId, nameof(classId), required: true);
            SourceExpression.Validate(databaseName, nameof(databaseName), required: true);
            SourceExpression.Validate(boothClassname, nameof(boothClassname), required: false);
            SourceExpression.Validate(boothClassdescription, nameof(boothClassdescription), required: false);
            SourceExpression.Validate(boothClassprioritity, nameof(boothClassprioritity), required: false);
            SourceExpression.Validate(boothClasscolor, nameof(boothClasscolor), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/classes/update", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(clientName, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["classId"] = SourceExpressionConverter.ConvertO(classId);
                callPayload.Queries["databaseName"] = SourceExpressionConverter.ConvertO(databaseName);
                var boothClass = new JObject();
                var boothClasspropCount = 0;
                boothClasspropCount++;
                boothClass["Id"] = SourceExpressionConverter.ConvertToken(boothClassid);
                if (boothClassname != null)
                {
                    boothClass["Name"] = SourceExpressionConverter.ConvertToken(boothClassname);
                    boothClasspropCount++;
                }

                if (boothClassdescription != null)
                {
                    boothClass["Description"] = SourceExpressionConverter.ConvertToken(boothClassdescription);
                    boothClasspropCount++;
                }

                boothClasspropCount++;
                boothClass["KeepWhenCombined"] = SourceExpressionConverter.ConvertToken(boothClasskeepWhenCombined);
                boothClasspropCount++;
                boothClass["CountAsInventory"] = SourceExpressionConverter.ConvertToken(boothClasscountAsInventory);
                if (boothClassprioritity != null)
                {
                    boothClass["Prioritity"] = SourceExpressionConverter.ConvertToken(boothClassprioritity);
                    boothClasspropCount++;
                }

                if (boothClasscolor != null)
                {
                    boothClass["Color"] = SourceExpressionConverter.ConvertToken(boothClasscolor);
                    boothClasspropCount++;
                }

                if (boothClasspropCount > 0)
                {
                    callPayload.Body = boothClass;
                }
                return callPayload;
            }

            return new ApiConnectionAction<BoothClass>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<JToken> ClassesDelete([WorkflowExpression] Func<string> clientName, [WorkflowExpression] Func<string> classId, [WorkflowExpression] Func<string> databaseName)
        {
            SourceExpression.Validate(clientName, nameof(clientName), required: true);
            SourceExpression.Validate(classId, nameof(classId), required: true);
            SourceExpression.Validate(databaseName, nameof(databaseName), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/classes/delete", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(clientName, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["classId"] = SourceExpressionConverter.ConvertO(classId);
                callPayload.Queries["databaseName"] = SourceExpressionConverter.ConvertO(databaseName);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<ExpocadEvent[]> EventsGetAllEvents([WorkflowExpression] Func<string> clientName)
        {
            SourceExpression.Validate(clientName, nameof(clientName), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/events", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(clientName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ExpocadEvent[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<EventStats> EventsGetEventStatistics([WorkflowExpression] Func<string> clientName, [WorkflowExpression] Func<string> databaseName)
        {
            SourceExpression.Validate(clientName, nameof(clientName), required: true);
            SourceExpression.Validate(databaseName, nameof(databaseName), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/events/stats", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(clientName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["databaseName"] = SourceExpressionConverter.ConvertO(databaseName);
                return callPayload;
            }

            return new ApiConnectionAction<EventStats>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<ExpoEventInformation> EventsGetEventInformation([WorkflowExpression] Func<string> clientName, [WorkflowExpression] Func<string> databaseName)
        {
            SourceExpression.Validate(clientName, nameof(clientName), required: true);
            SourceExpression.Validate(databaseName, nameof(databaseName), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/events/info", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(clientName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["databaseName"] = SourceExpressionConverter.ConvertO(databaseName);
                return callPayload;
            }

            return new ApiConnectionAction<ExpoEventInformation>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<Exhibitor> ExhibitorsGet([WorkflowExpression] Func<string> clientName, [WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> databaseName)
        {
            SourceExpression.Validate(clientName, nameof(clientName), required: true);
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(databaseName, nameof(databaseName), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/exhibitors", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(clientName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = SourceExpressionConverter.ConvertO(id);
                callPayload.Queries["databaseName"] = SourceExpressionConverter.ConvertO(databaseName);
                return callPayload;
            }

            return new ApiConnectionAction<Exhibitor>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<Exhibitor[]> ExhibitorsGetAllExhibitors([WorkflowExpression] Func<string> clientName, [WorkflowExpression] Func<string> databaseName)
        {
            SourceExpression.Validate(clientName, nameof(clientName), required: true);
            SourceExpression.Validate(databaseName, nameof(databaseName), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/exhibitors/all", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(clientName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["databaseName"] = SourceExpressionConverter.ConvertO(databaseName);
                return callPayload;
            }

            return new ApiConnectionAction<Exhibitor[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<Exhibitor> ExhibitorsAddExhibitor([WorkflowExpression] Func<string> clientName, [WorkflowExpression] Func<string> exhibitorexhibitorId, [WorkflowExpression] Func<string> databaseName, [WorkflowExpression] Func<string> exhibitoraddress1 = null, [WorkflowExpression] Func<string> exhibitoraddress2 = null, [WorkflowExpression] Func<string> exhibitorcity = null, [WorkflowExpression] Func<string> exhibitorcomments = null, [WorkflowExpression] Func<string> exhibitorcomments2 = null, [WorkflowExpression] Func<string> exhibitorcontact = null, [WorkflowExpression] Func<string> exhibitorcountry = null, [WorkflowExpression] Func<string> exhibitorcellPhone = null, [WorkflowExpression] Func<string> exhibitordisplayOnDrawing = null, [WorkflowExpression] Func<string> exhibitordoingBusinessAs = null, [WorkflowExpression] Func<string> exhibitordoingBusinessAsDisplayOnDrawing = null, [WorkflowExpression] Func<string> exhibitoremail = null, [WorkflowExpression] Func<string> exhibitorexhibitorName = null, [WorkflowExpression] Func<string> exhibitorexhibitorNameLine2 = null, [WorkflowExpression] Func<string> exhibitorfax = null, [WorkflowExpression] Func<string> exhibitorfield1 = null, [WorkflowExpression] Func<string> exhibitorfield2 = null, [WorkflowExpression] Func<string> exhibitorfield3 = null, [WorkflowExpression] Func<string> exhibitorfield4 = null, [WorkflowExpression] Func<string> exhibitorfield5 = null, [WorkflowExpression] Func<string> exhibitorfield6 = null, [WorkflowExpression] Func<string> exhibitorfield7 = null, [WorkflowExpression] Func<string> exhibitorfield8 = null, [WorkflowExpression] Func<string> exhibitorfield9 = null, [WorkflowExpression] Func<string> exhibitornickName = null, [WorkflowExpression] Func<string> exhibitorsalutation = null, [WorkflowExpression] Func<string> exhibitortitle = null, [WorkflowExpression] Func<string> exhibitorphone = null, [WorkflowExpression] Func<string> exhibitorpostalCode = null, [WorkflowExpression] Func<string> exhibitorprimaryGroup = null, [WorkflowExpression] Func<string> exhibitorpriorityPoints = null, [WorkflowExpression] Func<string> exhibitorproductDescription = null, [WorkflowExpression] Func<string> exhibitorstate = null, [WorkflowExpression] Func<string> exhibitorwebSite = null)
        {
            SourceExpression.Validate(clientName, nameof(clientName), required: true);
            SourceExpression.Validate(exhibitorexhibitorId, nameof(exhibitorexhibitorId), required: true);
            SourceExpression.Validate(databaseName, nameof(databaseName), required: true);
            SourceExpression.Validate(exhibitoraddress1, nameof(exhibitoraddress1), required: false);
            SourceExpression.Validate(exhibitoraddress2, nameof(exhibitoraddress2), required: false);
            SourceExpression.Validate(exhibitorcity, nameof(exhibitorcity), required: false);
            SourceExpression.Validate(exhibitorcomments, nameof(exhibitorcomments), required: false);
            SourceExpression.Validate(exhibitorcomments2, nameof(exhibitorcomments2), required: false);
            SourceExpression.Validate(exhibitorcontact, nameof(exhibitorcontact), required: false);
            SourceExpression.Validate(exhibitorcountry, nameof(exhibitorcountry), required: false);
            SourceExpression.Validate(exhibitorcellPhone, nameof(exhibitorcellPhone), required: false);
            SourceExpression.Validate(exhibitordisplayOnDrawing, nameof(exhibitordisplayOnDrawing), required: false);
            SourceExpression.Validate(exhibitordoingBusinessAs, nameof(exhibitordoingBusinessAs), required: false);
            SourceExpression.Validate(exhibitordoingBusinessAsDisplayOnDrawing, nameof(exhibitordoingBusinessAsDisplayOnDrawing), required: false);
            SourceExpression.Validate(exhibitoremail, nameof(exhibitoremail), required: false);
            SourceExpression.Validate(exhibitorexhibitorName, nameof(exhibitorexhibitorName), required: false);
            SourceExpression.Validate(exhibitorexhibitorNameLine2, nameof(exhibitorexhibitorNameLine2), required: false);
            SourceExpression.Validate(exhibitorfax, nameof(exhibitorfax), required: false);
            SourceExpression.Validate(exhibitorfield1, nameof(exhibitorfield1), required: false);
            SourceExpression.Validate(exhibitorfield2, nameof(exhibitorfield2), required: false);
            SourceExpression.Validate(exhibitorfield3, nameof(exhibitorfield3), required: false);
            SourceExpression.Validate(exhibitorfield4, nameof(exhibitorfield4), required: false);
            SourceExpression.Validate(exhibitorfield5, nameof(exhibitorfield5), required: false);
            SourceExpression.Validate(exhibitorfield6, nameof(exhibitorfield6), required: false);
            SourceExpression.Validate(exhibitorfield7, nameof(exhibitorfield7), required: false);
            SourceExpression.Validate(exhibitorfield8, nameof(exhibitorfield8), required: false);
            SourceExpression.Validate(exhibitorfield9, nameof(exhibitorfield9), required: false);
            SourceExpression.Validate(exhibitornickName, nameof(exhibitornickName), required: false);
            SourceExpression.Validate(exhibitorsalutation, nameof(exhibitorsalutation), required: false);
            SourceExpression.Validate(exhibitortitle, nameof(exhibitortitle), required: false);
            SourceExpression.Validate(exhibitorphone, nameof(exhibitorphone), required: false);
            SourceExpression.Validate(exhibitorpostalCode, nameof(exhibitorpostalCode), required: false);
            SourceExpression.Validate(exhibitorprimaryGroup, nameof(exhibitorprimaryGroup), required: false);
            SourceExpression.Validate(exhibitorpriorityPoints, nameof(exhibitorpriorityPoints), required: false);
            SourceExpression.Validate(exhibitorproductDescription, nameof(exhibitorproductDescription), required: false);
            SourceExpression.Validate(exhibitorstate, nameof(exhibitorstate), required: false);
            SourceExpression.Validate(exhibitorwebSite, nameof(exhibitorwebSite), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/exhibitors/add", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(clientName, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["databaseName"] = SourceExpressionConverter.ConvertO(databaseName);
                var exhibitor = new JObject();
                var exhibitorpropCount = 0;
                if (exhibitoraddress1 != null)
                {
                    exhibitor["Address1"] = SourceExpressionConverter.ConvertToken(exhibitoraddress1);
                    exhibitorpropCount++;
                }

                if (exhibitoraddress2 != null)
                {
                    exhibitor["Address2"] = SourceExpressionConverter.ConvertToken(exhibitoraddress2);
                    exhibitorpropCount++;
                }

                if (exhibitorcity != null)
                {
                    exhibitor["City"] = SourceExpressionConverter.ConvertToken(exhibitorcity);
                    exhibitorpropCount++;
                }

                if (exhibitorcomments != null)
                {
                    exhibitor["Comments"] = SourceExpressionConverter.ConvertToken(exhibitorcomments);
                    exhibitorpropCount++;
                }

                if (exhibitorcomments2 != null)
                {
                    exhibitor["Comments2"] = SourceExpressionConverter.ConvertToken(exhibitorcomments2);
                    exhibitorpropCount++;
                }

                if (exhibitorcontact != null)
                {
                    exhibitor["Contact"] = SourceExpressionConverter.ConvertToken(exhibitorcontact);
                    exhibitorpropCount++;
                }

                if (exhibitorcountry != null)
                {
                    exhibitor["Country"] = SourceExpressionConverter.ConvertToken(exhibitorcountry);
                    exhibitorpropCount++;
                }

                if (exhibitorcellPhone != null)
                {
                    exhibitor["CellPhone"] = SourceExpressionConverter.ConvertToken(exhibitorcellPhone);
                    exhibitorpropCount++;
                }

                if (exhibitordisplayOnDrawing != null)
                {
                    exhibitor["DisplayOnDrawing"] = SourceExpressionConverter.ConvertToken(exhibitordisplayOnDrawing);
                    exhibitorpropCount++;
                }

                if (exhibitordoingBusinessAs != null)
                {
                    exhibitor["DoingBusinessAs"] = SourceExpressionConverter.ConvertToken(exhibitordoingBusinessAs);
                    exhibitorpropCount++;
                }

                if (exhibitordoingBusinessAsDisplayOnDrawing != null)
                {
                    exhibitor["DoingBusinessAsDisplayOnDrawing"] = SourceExpressionConverter.ConvertToken(exhibitordoingBusinessAsDisplayOnDrawing);
                    exhibitorpropCount++;
                }

                if (exhibitoremail != null)
                {
                    exhibitor["Email"] = SourceExpressionConverter.ConvertToken(exhibitoremail);
                    exhibitorpropCount++;
                }

                exhibitorpropCount++;
                exhibitor["ExhibitorId"] = SourceExpressionConverter.ConvertToken(exhibitorexhibitorId);
                if (exhibitorexhibitorName != null)
                {
                    exhibitor["ExhibitorName"] = SourceExpressionConverter.ConvertToken(exhibitorexhibitorName);
                    exhibitorpropCount++;
                }

                if (exhibitorexhibitorNameLine2 != null)
                {
                    exhibitor["ExhibitorNameLine2"] = SourceExpressionConverter.ConvertToken(exhibitorexhibitorNameLine2);
                    exhibitorpropCount++;
                }

                if (exhibitorfax != null)
                {
                    exhibitor["Fax"] = SourceExpressionConverter.ConvertToken(exhibitorfax);
                    exhibitorpropCount++;
                }

                if (exhibitorfield1 != null)
                {
                    exhibitor["Field1"] = SourceExpressionConverter.ConvertToken(exhibitorfield1);
                    exhibitorpropCount++;
                }

                if (exhibitorfield2 != null)
                {
                    exhibitor["Field2"] = SourceExpressionConverter.ConvertToken(exhibitorfield2);
                    exhibitorpropCount++;
                }

                if (exhibitorfield3 != null)
                {
                    exhibitor["Field3"] = SourceExpressionConverter.ConvertToken(exhibitorfield3);
                    exhibitorpropCount++;
                }

                if (exhibitorfield4 != null)
                {
                    exhibitor["Field4"] = SourceExpressionConverter.ConvertToken(exhibitorfield4);
                    exhibitorpropCount++;
                }

                if (exhibitorfield5 != null)
                {
                    exhibitor["Field5"] = SourceExpressionConverter.ConvertToken(exhibitorfield5);
                    exhibitorpropCount++;
                }

                if (exhibitorfield6 != null)
                {
                    exhibitor["Field6"] = SourceExpressionConverter.ConvertToken(exhibitorfield6);
                    exhibitorpropCount++;
                }

                if (exhibitorfield7 != null)
                {
                    exhibitor["Field7"] = SourceExpressionConverter.ConvertToken(exhibitorfield7);
                    exhibitorpropCount++;
                }

                if (exhibitorfield8 != null)
                {
                    exhibitor["Field8"] = SourceExpressionConverter.ConvertToken(exhibitorfield8);
                    exhibitorpropCount++;
                }

                if (exhibitorfield9 != null)
                {
                    exhibitor["Field9"] = SourceExpressionConverter.ConvertToken(exhibitorfield9);
                    exhibitorpropCount++;
                }

                if (exhibitornickName != null)
                {
                    exhibitor["NickName"] = SourceExpressionConverter.ConvertToken(exhibitornickName);
                    exhibitorpropCount++;
                }

                if (exhibitorsalutation != null)
                {
                    exhibitor["Salutation"] = SourceExpressionConverter.ConvertToken(exhibitorsalutation);
                    exhibitorpropCount++;
                }

                if (exhibitortitle != null)
                {
                    exhibitor["Title"] = SourceExpressionConverter.ConvertToken(exhibitortitle);
                    exhibitorpropCount++;
                }

                if (exhibitorphone != null)
                {
                    exhibitor["Phone"] = SourceExpressionConverter.ConvertToken(exhibitorphone);
                    exhibitorpropCount++;
                }

                if (exhibitorpostalCode != null)
                {
                    exhibitor["PostalCode"] = SourceExpressionConverter.ConvertToken(exhibitorpostalCode);
                    exhibitorpropCount++;
                }

                if (exhibitorprimaryGroup != null)
                {
                    exhibitor["PrimaryGroup"] = SourceExpressionConverter.ConvertToken(exhibitorprimaryGroup);
                    exhibitorpropCount++;
                }

                if (exhibitorpriorityPoints != null)
                {
                    exhibitor["PriorityPoints"] = SourceExpressionConverter.ConvertToken(exhibitorpriorityPoints);
                    exhibitorpropCount++;
                }

                if (exhibitorproductDescription != null)
                {
                    exhibitor["ProductDescription"] = SourceExpressionConverter.ConvertToken(exhibitorproductDescription);
                    exhibitorpropCount++;
                }

                if (exhibitorstate != null)
                {
                    exhibitor["State"] = SourceExpressionConverter.ConvertToken(exhibitorstate);
                    exhibitorpropCount++;
                }

                if (exhibitorwebSite != null)
                {
                    exhibitor["WebSite"] = SourceExpressionConverter.ConvertToken(exhibitorwebSite);
                    exhibitorpropCount++;
                }

                if (exhibitorpropCount > 0)
                {
                    callPayload.Body = exhibitor;
                }
                return callPayload;
            }

            return new ApiConnectionAction<Exhibitor>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<Exhibitor> ExhibitorsUpdateExhibitor([WorkflowExpression] Func<string> clientName, [WorkflowExpression] Func<string> exhibitorexhibitorId, [WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> databaseName, [WorkflowExpression] Func<string> exhibitoraddress1 = null, [WorkflowExpression] Func<string> exhibitoraddress2 = null, [WorkflowExpression] Func<string> exhibitorcity = null, [WorkflowExpression] Func<string> exhibitorcomments = null, [WorkflowExpression] Func<string> exhibitorcomments2 = null, [WorkflowExpression] Func<string> exhibitorcontact = null, [WorkflowExpression] Func<string> exhibitorcountry = null, [WorkflowExpression] Func<string> exhibitorcellPhone = null, [WorkflowExpression] Func<string> exhibitordisplayOnDrawing = null, [WorkflowExpression] Func<string> exhibitordoingBusinessAs = null, [WorkflowExpression] Func<string> exhibitordoingBusinessAsDisplayOnDrawing = null, [WorkflowExpression] Func<string> exhibitoremail = null, [WorkflowExpression] Func<string> exhibitorexhibitorName = null, [WorkflowExpression] Func<string> exhibitorexhibitorNameLine2 = null, [WorkflowExpression] Func<string> exhibitorfax = null, [WorkflowExpression] Func<string> exhibitorfield1 = null, [WorkflowExpression] Func<string> exhibitorfield2 = null, [WorkflowExpression] Func<string> exhibitorfield3 = null, [WorkflowExpression] Func<string> exhibitorfield4 = null, [WorkflowExpression] Func<string> exhibitorfield5 = null, [WorkflowExpression] Func<string> exhibitorfield6 = null, [WorkflowExpression] Func<string> exhibitorfield7 = null, [WorkflowExpression] Func<string> exhibitorfield8 = null, [WorkflowExpression] Func<string> exhibitorfield9 = null, [WorkflowExpression] Func<string> exhibitornickName = null, [WorkflowExpression] Func<string> exhibitorsalutation = null, [WorkflowExpression] Func<string> exhibitortitle = null, [WorkflowExpression] Func<string> exhibitorphone = null, [WorkflowExpression] Func<string> exhibitorpostalCode = null, [WorkflowExpression] Func<string> exhibitorprimaryGroup = null, [WorkflowExpression] Func<string> exhibitorpriorityPoints = null, [WorkflowExpression] Func<string> exhibitorproductDescription = null, [WorkflowExpression] Func<string> exhibitorstate = null, [WorkflowExpression] Func<string> exhibitorwebSite = null)
        {
            SourceExpression.Validate(clientName, nameof(clientName), required: true);
            SourceExpression.Validate(exhibitorexhibitorId, nameof(exhibitorexhibitorId), required: true);
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(databaseName, nameof(databaseName), required: true);
            SourceExpression.Validate(exhibitoraddress1, nameof(exhibitoraddress1), required: false);
            SourceExpression.Validate(exhibitoraddress2, nameof(exhibitoraddress2), required: false);
            SourceExpression.Validate(exhibitorcity, nameof(exhibitorcity), required: false);
            SourceExpression.Validate(exhibitorcomments, nameof(exhibitorcomments), required: false);
            SourceExpression.Validate(exhibitorcomments2, nameof(exhibitorcomments2), required: false);
            SourceExpression.Validate(exhibitorcontact, nameof(exhibitorcontact), required: false);
            SourceExpression.Validate(exhibitorcountry, nameof(exhibitorcountry), required: false);
            SourceExpression.Validate(exhibitorcellPhone, nameof(exhibitorcellPhone), required: false);
            SourceExpression.Validate(exhibitordisplayOnDrawing, nameof(exhibitordisplayOnDrawing), required: false);
            SourceExpression.Validate(exhibitordoingBusinessAs, nameof(exhibitordoingBusinessAs), required: false);
            SourceExpression.Validate(exhibitordoingBusinessAsDisplayOnDrawing, nameof(exhibitordoingBusinessAsDisplayOnDrawing), required: false);
            SourceExpression.Validate(exhibitoremail, nameof(exhibitoremail), required: false);
            SourceExpression.Validate(exhibitorexhibitorName, nameof(exhibitorexhibitorName), required: false);
            SourceExpression.Validate(exhibitorexhibitorNameLine2, nameof(exhibitorexhibitorNameLine2), required: false);
            SourceExpression.Validate(exhibitorfax, nameof(exhibitorfax), required: false);
            SourceExpression.Validate(exhibitorfield1, nameof(exhibitorfield1), required: false);
            SourceExpression.Validate(exhibitorfield2, nameof(exhibitorfield2), required: false);
            SourceExpression.Validate(exhibitorfield3, nameof(exhibitorfield3), required: false);
            SourceExpression.Validate(exhibitorfield4, nameof(exhibitorfield4), required: false);
            SourceExpression.Validate(exhibitorfield5, nameof(exhibitorfield5), required: false);
            SourceExpression.Validate(exhibitorfield6, nameof(exhibitorfield6), required: false);
            SourceExpression.Validate(exhibitorfield7, nameof(exhibitorfield7), required: false);
            SourceExpression.Validate(exhibitorfield8, nameof(exhibitorfield8), required: false);
            SourceExpression.Validate(exhibitorfield9, nameof(exhibitorfield9), required: false);
            SourceExpression.Validate(exhibitornickName, nameof(exhibitornickName), required: false);
            SourceExpression.Validate(exhibitorsalutation, nameof(exhibitorsalutation), required: false);
            SourceExpression.Validate(exhibitortitle, nameof(exhibitortitle), required: false);
            SourceExpression.Validate(exhibitorphone, nameof(exhibitorphone), required: false);
            SourceExpression.Validate(exhibitorpostalCode, nameof(exhibitorpostalCode), required: false);
            SourceExpression.Validate(exhibitorprimaryGroup, nameof(exhibitorprimaryGroup), required: false);
            SourceExpression.Validate(exhibitorpriorityPoints, nameof(exhibitorpriorityPoints), required: false);
            SourceExpression.Validate(exhibitorproductDescription, nameof(exhibitorproductDescription), required: false);
            SourceExpression.Validate(exhibitorstate, nameof(exhibitorstate), required: false);
            SourceExpression.Validate(exhibitorwebSite, nameof(exhibitorwebSite), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/exhibitors/update", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(clientName, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = SourceExpressionConverter.ConvertO(id);
                callPayload.Queries["databaseName"] = SourceExpressionConverter.ConvertO(databaseName);
                var exhibitor = new JObject();
                var exhibitorpropCount = 0;
                if (exhibitoraddress1 != null)
                {
                    exhibitor["Address1"] = SourceExpressionConverter.ConvertToken(exhibitoraddress1);
                    exhibitorpropCount++;
                }

                if (exhibitoraddress2 != null)
                {
                    exhibitor["Address2"] = SourceExpressionConverter.ConvertToken(exhibitoraddress2);
                    exhibitorpropCount++;
                }

                if (exhibitorcity != null)
                {
                    exhibitor["City"] = SourceExpressionConverter.ConvertToken(exhibitorcity);
                    exhibitorpropCount++;
                }

                if (exhibitorcomments != null)
                {
                    exhibitor["Comments"] = SourceExpressionConverter.ConvertToken(exhibitorcomments);
                    exhibitorpropCount++;
                }

                if (exhibitorcomments2 != null)
                {
                    exhibitor["Comments2"] = SourceExpressionConverter.ConvertToken(exhibitorcomments2);
                    exhibitorpropCount++;
                }

                if (exhibitorcontact != null)
                {
                    exhibitor["Contact"] = SourceExpressionConverter.ConvertToken(exhibitorcontact);
                    exhibitorpropCount++;
                }

                if (exhibitorcountry != null)
                {
                    exhibitor["Country"] = SourceExpressionConverter.ConvertToken(exhibitorcountry);
                    exhibitorpropCount++;
                }

                if (exhibitorcellPhone != null)
                {
                    exhibitor["CellPhone"] = SourceExpressionConverter.ConvertToken(exhibitorcellPhone);
                    exhibitorpropCount++;
                }

                if (exhibitordisplayOnDrawing != null)
                {
                    exhibitor["DisplayOnDrawing"] = SourceExpressionConverter.ConvertToken(exhibitordisplayOnDrawing);
                    exhibitorpropCount++;
                }

                if (exhibitordoingBusinessAs != null)
                {
                    exhibitor["DoingBusinessAs"] = SourceExpressionConverter.ConvertToken(exhibitordoingBusinessAs);
                    exhibitorpropCount++;
                }

                if (exhibitordoingBusinessAsDisplayOnDrawing != null)
                {
                    exhibitor["DoingBusinessAsDisplayOnDrawing"] = SourceExpressionConverter.ConvertToken(exhibitordoingBusinessAsDisplayOnDrawing);
                    exhibitorpropCount++;
                }

                if (exhibitoremail != null)
                {
                    exhibitor["Email"] = SourceExpressionConverter.ConvertToken(exhibitoremail);
                    exhibitorpropCount++;
                }

                exhibitorpropCount++;
                exhibitor["ExhibitorId"] = SourceExpressionConverter.ConvertToken(exhibitorexhibitorId);
                if (exhibitorexhibitorName != null)
                {
                    exhibitor["ExhibitorName"] = SourceExpressionConverter.ConvertToken(exhibitorexhibitorName);
                    exhibitorpropCount++;
                }

                if (exhibitorexhibitorNameLine2 != null)
                {
                    exhibitor["ExhibitorNameLine2"] = SourceExpressionConverter.ConvertToken(exhibitorexhibitorNameLine2);
                    exhibitorpropCount++;
                }

                if (exhibitorfax != null)
                {
                    exhibitor["Fax"] = SourceExpressionConverter.ConvertToken(exhibitorfax);
                    exhibitorpropCount++;
                }

                if (exhibitorfield1 != null)
                {
                    exhibitor["Field1"] = SourceExpressionConverter.ConvertToken(exhibitorfield1);
                    exhibitorpropCount++;
                }

                if (exhibitorfield2 != null)
                {
                    exhibitor["Field2"] = SourceExpressionConverter.ConvertToken(exhibitorfield2);
                    exhibitorpropCount++;
                }

                if (exhibitorfield3 != null)
                {
                    exhibitor["Field3"] = SourceExpressionConverter.ConvertToken(exhibitorfield3);
                    exhibitorpropCount++;
                }

                if (exhibitorfield4 != null)
                {
                    exhibitor["Field4"] = SourceExpressionConverter.ConvertToken(exhibitorfield4);
                    exhibitorpropCount++;
                }

                if (exhibitorfield5 != null)
                {
                    exhibitor["Field5"] = SourceExpressionConverter.ConvertToken(exhibitorfield5);
                    exhibitorpropCount++;
                }

                if (exhibitorfield6 != null)
                {
                    exhibitor["Field6"] = SourceExpressionConverter.ConvertToken(exhibitorfield6);
                    exhibitorpropCount++;
                }

                if (exhibitorfield7 != null)
                {
                    exhibitor["Field7"] = SourceExpressionConverter.ConvertToken(exhibitorfield7);
                    exhibitorpropCount++;
                }

                if (exhibitorfield8 != null)
                {
                    exhibitor["Field8"] = SourceExpressionConverter.ConvertToken(exhibitorfield8);
                    exhibitorpropCount++;
                }

                if (exhibitorfield9 != null)
                {
                    exhibitor["Field9"] = SourceExpressionConverter.ConvertToken(exhibitorfield9);
                    exhibitorpropCount++;
                }

                if (exhibitornickName != null)
                {
                    exhibitor["NickName"] = SourceExpressionConverter.ConvertToken(exhibitornickName);
                    exhibitorpropCount++;
                }

                if (exhibitorsalutation != null)
                {
                    exhibitor["Salutation"] = SourceExpressionConverter.ConvertToken(exhibitorsalutation);
                    exhibitorpropCount++;
                }

                if (exhibitortitle != null)
                {
                    exhibitor["Title"] = SourceExpressionConverter.ConvertToken(exhibitortitle);
                    exhibitorpropCount++;
                }

                if (exhibitorphone != null)
                {
                    exhibitor["Phone"] = SourceExpressionConverter.ConvertToken(exhibitorphone);
                    exhibitorpropCount++;
                }

                if (exhibitorpostalCode != null)
                {
                    exhibitor["PostalCode"] = SourceExpressionConverter.ConvertToken(exhibitorpostalCode);
                    exhibitorpropCount++;
                }

                if (exhibitorprimaryGroup != null)
                {
                    exhibitor["PrimaryGroup"] = SourceExpressionConverter.ConvertToken(exhibitorprimaryGroup);
                    exhibitorpropCount++;
                }

                if (exhibitorpriorityPoints != null)
                {
                    exhibitor["PriorityPoints"] = SourceExpressionConverter.ConvertToken(exhibitorpriorityPoints);
                    exhibitorpropCount++;
                }

                if (exhibitorproductDescription != null)
                {
                    exhibitor["ProductDescription"] = SourceExpressionConverter.ConvertToken(exhibitorproductDescription);
                    exhibitorpropCount++;
                }

                if (exhibitorstate != null)
                {
                    exhibitor["State"] = SourceExpressionConverter.ConvertToken(exhibitorstate);
                    exhibitorpropCount++;
                }

                if (exhibitorwebSite != null)
                {
                    exhibitor["WebSite"] = SourceExpressionConverter.ConvertToken(exhibitorwebSite);
                    exhibitorpropCount++;
                }

                if (exhibitorpropCount > 0)
                {
                    callPayload.Body = exhibitor;
                }
                return callPayload;
            }

            return new ApiConnectionAction<Exhibitor>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<JToken> ExhibitorsDeleteExhibitor([WorkflowExpression] Func<string> clientName, [WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> databaseName)
        {
            SourceExpression.Validate(clientName, nameof(clientName), required: true);
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(databaseName, nameof(databaseName), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/exhibitors/delete", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(clientName, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = SourceExpressionConverter.ConvertO(id);
                callPayload.Queries["databaseName"] = SourceExpressionConverter.ConvertO(databaseName);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<Transaction[]> FinancialsGetAllTransactions([WorkflowExpression] Func<string> clientName, [WorkflowExpression] Func<string> databaseName, [WorkflowExpression] Func<string> startDate = null, [WorkflowExpression] Func<string> endDate = null, [WorkflowExpression] Func<string> exhibitorId = null, [WorkflowExpression] Func<string> boothNumber = null, [WorkflowExpression] Func<string> expocadUser = null, [WorkflowExpression] Func<string> glCode = null, [WorkflowExpression] Func<reversedFilterInput> reversedFilter = null)
        {
            SourceExpression.Validate(clientName, nameof(clientName), required: true);
            SourceExpression.Validate(databaseName, nameof(databaseName), required: true);
            SourceExpression.Validate(startDate, nameof(startDate), required: false);
            SourceExpression.Validate(endDate, nameof(endDate), required: false);
            SourceExpression.Validate(exhibitorId, nameof(exhibitorId), required: false);
            SourceExpression.Validate(boothNumber, nameof(boothNumber), required: false);
            SourceExpression.Validate(expocadUser, nameof(expocadUser), required: false);
            SourceExpression.Validate(glCode, nameof(glCode), required: false);
            SourceExpression.Validate(reversedFilter, nameof(reversedFilter), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/financials/transactions", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(clientName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["databaseName"] = SourceExpressionConverter.ConvertO(databaseName);
                if (startDate != null)
                    callPayload.Queries["startDate"] = SourceExpressionConverter.ConvertO(startDate);
                if (endDate != null)
                    callPayload.Queries["endDate"] = SourceExpressionConverter.ConvertO(endDate);
                if (exhibitorId != null)
                    callPayload.Queries["exhibitorId"] = SourceExpressionConverter.ConvertO(exhibitorId);
                if (boothNumber != null)
                    callPayload.Queries["boothNumber"] = SourceExpressionConverter.ConvertO(boothNumber);
                if (expocadUser != null)
                    callPayload.Queries["expocadUser"] = SourceExpressionConverter.ConvertO(expocadUser);
                if (glCode != null)
                    callPayload.Queries["glCode"] = SourceExpressionConverter.ConvertO(glCode);
                if (reversedFilter != null)
                    callPayload.Queries["reversedFilter"] = SourceExpressionConverter.Convert(reversedFilter);
                return callPayload;
            }

            return new ApiConnectionAction<Transaction[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<BoothFinancial> FinancialsGet([WorkflowExpression] Func<string> clientName, [WorkflowExpression] Func<string> boothNumber, [WorkflowExpression] Func<string> databaseName)
        {
            SourceExpression.Validate(clientName, nameof(clientName), required: true);
            SourceExpression.Validate(boothNumber, nameof(boothNumber), required: true);
            SourceExpression.Validate(databaseName, nameof(databaseName), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/financials/booths", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(clientName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["boothNumber"] = SourceExpressionConverter.ConvertO(boothNumber);
                callPayload.Queries["databaseName"] = SourceExpressionConverter.ConvertO(databaseName);
                return callPayload;
            }

            return new ApiConnectionAction<BoothFinancial>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<Invoice> FinancialsGetInvoice([WorkflowExpression] Func<string> clientName, [WorkflowExpression] Func<string> databaseName, [WorkflowExpression] Func<string> invoiceNo = null, [WorkflowExpression] Func<string> exhibitorId = null)
        {
            SourceExpression.Validate(clientName, nameof(clientName), required: true);
            SourceExpression.Validate(databaseName, nameof(databaseName), required: true);
            SourceExpression.Validate(invoiceNo, nameof(invoiceNo), required: false);
            SourceExpression.Validate(exhibitorId, nameof(exhibitorId), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/financials/invoices", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(clientName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["databaseName"] = SourceExpressionConverter.ConvertO(databaseName);
                if (invoiceNo != null)
                    callPayload.Queries["invoiceNo"] = SourceExpressionConverter.ConvertO(invoiceNo);
                if (exhibitorId != null)
                    callPayload.Queries["exhibitorId"] = SourceExpressionConverter.ConvertO(exhibitorId);
                return callPayload;
            }

            return new ApiConnectionAction<Invoice>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<Invoice[]> FinancialsGetAllInvoices([WorkflowExpression] Func<string> clientName, [WorkflowExpression] Func<string> databaseName)
        {
            SourceExpression.Validate(clientName, nameof(clientName), required: true);
            SourceExpression.Validate(databaseName, nameof(databaseName), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/financials/invoices/all", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(clientName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["databaseName"] = SourceExpressionConverter.ConvertO(databaseName);
                return callPayload;
            }

            return new ApiConnectionAction<Invoice[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<MasterRequestItem[]> FinancialsGetRequestItemList([WorkflowExpression] Func<string> clientName, [WorkflowExpression] Func<string> databaseName, [WorkflowExpression] Func<string> glCode = null, [WorkflowExpression] Func<string> transactionCode = null)
        {
            SourceExpression.Validate(clientName, nameof(clientName), required: true);
            SourceExpression.Validate(databaseName, nameof(databaseName), required: true);
            SourceExpression.Validate(glCode, nameof(glCode), required: false);
            SourceExpression.Validate(transactionCode, nameof(transactionCode), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/financials/requestitemlist", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(clientName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["databaseName"] = SourceExpressionConverter.ConvertO(databaseName);
                if (glCode != null)
                    callPayload.Queries["glCode"] = SourceExpressionConverter.ConvertO(glCode);
                if (transactionCode != null)
                    callPayload.Queries["transactionCode"] = SourceExpressionConverter.ConvertO(transactionCode);
                return callPayload;
            }

            return new ApiConnectionAction<MasterRequestItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<InvoiceRequestItem[]> FinancialsGetAssignedRequestItems([WorkflowExpression] Func<string> clientName, [WorkflowExpression] Func<string> databaseName, [WorkflowExpression] Func<string> exhibitorId = null, [WorkflowExpression] Func<string> invoiceNumber = null, [WorkflowExpression] Func<string> startDate = null, [WorkflowExpression] Func<string> endDate = null, [WorkflowExpression] Func<string> booth = null, [WorkflowExpression] Func<string> glCode = null, [WorkflowExpression] Func<string> transactionCode = null)
        {
            SourceExpression.Validate(clientName, nameof(clientName), required: true);
            SourceExpression.Validate(databaseName, nameof(databaseName), required: true);
            SourceExpression.Validate(exhibitorId, nameof(exhibitorId), required: false);
            SourceExpression.Validate(invoiceNumber, nameof(invoiceNumber), required: false);
            SourceExpression.Validate(startDate, nameof(startDate), required: false);
            SourceExpression.Validate(endDate, nameof(endDate), required: false);
            SourceExpression.Validate(booth, nameof(booth), required: false);
            SourceExpression.Validate(glCode, nameof(glCode), required: false);
            SourceExpression.Validate(transactionCode, nameof(transactionCode), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/financials/requestitems", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(clientName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["databaseName"] = SourceExpressionConverter.ConvertO(databaseName);
                if (exhibitorId != null)
                    callPayload.Queries["exhibitorId"] = SourceExpressionConverter.ConvertO(exhibitorId);
                if (invoiceNumber != null)
                    callPayload.Queries["invoiceNumber"] = SourceExpressionConverter.ConvertO(invoiceNumber);
                if (startDate != null)
                    callPayload.Queries["startDate"] = SourceExpressionConverter.ConvertO(startDate);
                if (endDate != null)
                    callPayload.Queries["endDate"] = SourceExpressionConverter.ConvertO(endDate);
                if (booth != null)
                    callPayload.Queries["booth"] = SourceExpressionConverter.ConvertO(booth);
                if (glCode != null)
                    callPayload.Queries["glCode"] = SourceExpressionConverter.ConvertO(glCode);
                if (transactionCode != null)
                    callPayload.Queries["transactionCode"] = SourceExpressionConverter.ConvertO(transactionCode);
                return callPayload;
            }

            return new ApiConnectionAction<InvoiceRequestItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<PaymentTypeItem[]> FinancialsGetPaymentTypeList([WorkflowExpression] Func<string> clientName, [WorkflowExpression] Func<string> databaseName)
        {
            SourceExpression.Validate(clientName, nameof(clientName), required: true);
            SourceExpression.Validate(databaseName, nameof(databaseName), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/financials/paymenttypelist", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(clientName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["databaseName"] = SourceExpressionConverter.ConvertO(databaseName);
                return callPayload;
            }

            return new ApiConnectionAction<PaymentTypeItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<InvoicePayment[]> FinancialsGetPayments([WorkflowExpression] Func<string> clientName, [WorkflowExpression] Func<string> databaseName, [WorkflowExpression] Func<string> exhibitorId = null, [WorkflowExpression] Func<string> depositId = null, [WorkflowExpression] Func<string> invoiceNumber = null, [WorkflowExpression] Func<string> startDate = null, [WorkflowExpression] Func<string> endDate = null, [WorkflowExpression] Func<string> paymentTypeCategory = null)
        {
            SourceExpression.Validate(clientName, nameof(clientName), required: true);
            SourceExpression.Validate(databaseName, nameof(databaseName), required: true);
            SourceExpression.Validate(exhibitorId, nameof(exhibitorId), required: false);
            SourceExpression.Validate(depositId, nameof(depositId), required: false);
            SourceExpression.Validate(invoiceNumber, nameof(invoiceNumber), required: false);
            SourceExpression.Validate(startDate, nameof(startDate), required: false);
            SourceExpression.Validate(endDate, nameof(endDate), required: false);
            SourceExpression.Validate(paymentTypeCategory, nameof(paymentTypeCategory), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/financials/payments", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(clientName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["databaseName"] = SourceExpressionConverter.ConvertO(databaseName);
                if (exhibitorId != null)
                    callPayload.Queries["ExhibitorId"] = SourceExpressionConverter.ConvertO(exhibitorId);
                if (depositId != null)
                    callPayload.Queries["DepositId"] = SourceExpressionConverter.ConvertO(depositId);
                if (invoiceNumber != null)
                    callPayload.Queries["InvoiceNumber"] = SourceExpressionConverter.ConvertO(invoiceNumber);
                if (startDate != null)
                    callPayload.Queries["StartDate"] = SourceExpressionConverter.ConvertO(startDate);
                if (endDate != null)
                    callPayload.Queries["EndDate"] = SourceExpressionConverter.ConvertO(endDate);
                if (paymentTypeCategory != null)
                    callPayload.Queries["PaymentTypeCategory"] = SourceExpressionConverter.ConvertO(paymentTypeCategory);
                return callPayload;
            }

            return new ApiConnectionAction<InvoicePayment[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<Pavilion[]> PavilionsGetAllPavilions([WorkflowExpression] Func<string> clientName, [WorkflowExpression] Func<string> databaseName)
        {
            SourceExpression.Validate(clientName, nameof(clientName), required: true);
            SourceExpression.Validate(databaseName, nameof(databaseName), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/pavilions/all", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(clientName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["databaseName"] = SourceExpressionConverter.ConvertO(databaseName);
                return callPayload;
            }

            return new ApiConnectionAction<Pavilion[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<RatePlan> RatePlansGetDefaultRatePlan([WorkflowExpression] Func<string> clientName, [WorkflowExpression] Func<string> databaseName)
        {
            SourceExpression.Validate(clientName, nameof(clientName), required: true);
            SourceExpression.Validate(databaseName, nameof(databaseName), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/rateplans/default", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(clientName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["databaseName"] = SourceExpressionConverter.ConvertO(databaseName);
                return callPayload;
            }

            return new ApiConnectionAction<RatePlan>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<JToken> RatePlansSetDefaultRatePlan([WorkflowExpression] Func<string> clientName, [WorkflowExpression] Func<string> databaseName, [WorkflowExpression] Func<string> name)
        {
            SourceExpression.Validate(clientName, nameof(clientName), required: true);
            SourceExpression.Validate(databaseName, nameof(databaseName), required: true);
            SourceExpression.Validate(name, nameof(name), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/rateplans/default", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(clientName, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["databaseName"] = SourceExpressionConverter.ConvertO(databaseName);
                callPayload.Queries["name"] = SourceExpressionConverter.ConvertO(name);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<RatePlan[]> RatePlansGetAllRatePlans([WorkflowExpression] Func<string> clientName, [WorkflowExpression] Func<string> databaseName)
        {
            SourceExpression.Validate(clientName, nameof(clientName), required: true);
            SourceExpression.Validate(databaseName, nameof(databaseName), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/rateplans/all", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(clientName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["databaseName"] = SourceExpressionConverter.ConvertO(databaseName);
                return callPayload;
            }

            return new ApiConnectionAction<RatePlan[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<RatePlan> RatePlansAddRatePlan([WorkflowExpression] Func<string> clientName, [WorkflowExpression] Func<string> databaseName, [WorkflowExpression] Func<string> ratePlanname, [WorkflowExpression] Func<string> ratePlanshortCode, [WorkflowExpression] Func<double> ratePlangrossRate, [WorkflowExpression] Func<double> ratePlanfixedDiscountRate, [WorkflowExpression] Func<double> ratePlanpercentDiscountRate, [WorkflowExpression] Func<bool> ratePlanisFixed)
        {
            SourceExpression.Validate(clientName, nameof(clientName), required: true);
            SourceExpression.Validate(databaseName, nameof(databaseName), required: true);
            SourceExpression.Validate(ratePlanname, nameof(ratePlanname), required: true);
            SourceExpression.Validate(ratePlanshortCode, nameof(ratePlanshortCode), required: true);
            SourceExpression.Validate(ratePlangrossRate, nameof(ratePlangrossRate), required: true);
            SourceExpression.Validate(ratePlanfixedDiscountRate, nameof(ratePlanfixedDiscountRate), required: true);
            SourceExpression.Validate(ratePlanpercentDiscountRate, nameof(ratePlanpercentDiscountRate), required: true);
            SourceExpression.Validate(ratePlanisFixed, nameof(ratePlanisFixed), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/rateplans/add", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(clientName, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["databaseName"] = SourceExpressionConverter.ConvertO(databaseName);
                var ratePlan = new JObject();
                var ratePlanpropCount = 0;
                ratePlanpropCount++;
                ratePlan["Name"] = SourceExpressionConverter.ConvertToken(ratePlanname);
                ratePlanpropCount++;
                ratePlan["ShortCode"] = SourceExpressionConverter.ConvertToken(ratePlanshortCode);
                ratePlanpropCount++;
                ratePlan["GrossRate"] = SourceExpressionConverter.ConvertToken(ratePlangrossRate);
                ratePlanpropCount++;
                ratePlan["FixedDiscountRate"] = SourceExpressionConverter.ConvertToken(ratePlanfixedDiscountRate);
                ratePlanpropCount++;
                ratePlan["PercentDiscountRate"] = SourceExpressionConverter.ConvertToken(ratePlanpercentDiscountRate);
                ratePlanpropCount++;
                ratePlan["IsFixed"] = SourceExpressionConverter.ConvertToken(ratePlanisFixed);
                if (ratePlanpropCount > 0)
                {
                    callPayload.Body = ratePlan;
                }
                return callPayload;
            }

            return new ApiConnectionAction<RatePlan>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<ShowInShow[]> ShowInShowsGetAllShowinShows([WorkflowExpression] Func<string> clientName, [WorkflowExpression] Func<string> databaseName)
        {
            SourceExpression.Validate(clientName, nameof(clientName), required: true);
            SourceExpression.Validate(databaseName, nameof(databaseName), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/showinshows/all", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(clientName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["databaseName"] = SourceExpressionConverter.ConvertO(databaseName);
                return callPayload;
            }

            return new ApiConnectionAction<ShowInShow[]>(BuildSourceInput);
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