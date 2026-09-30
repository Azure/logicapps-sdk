//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Nasafirms
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class NasafirmsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nasafirms")]
        public IWorkflowAction GetArea([WorkflowExpression] Func<string> source, [WorkflowExpression] Func<string> areaCoord, [WorkflowExpression] Func<dayRangeInput> dayRange)
        {
            SourceExpression.Validate(source, nameof(source), required: true);
            SourceExpression.Validate(areaCoord, nameof(areaCoord), required: true);
            SourceExpression.Validate(dayRange, nameof(dayRange), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/area/csv/api_key/{0}/{1}/{2}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(source, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(areaCoord, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dayRange, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nasafirms")]
        public IWorkflowAction GetCountry([WorkflowExpression] Func<string> source, [WorkflowExpression] Func<string> country, [WorkflowExpression] Func<dayRangeInput> dayRange)
        {
            SourceExpression.Validate(source, nameof(source), required: true);
            SourceExpression.Validate(country, nameof(country), required: true);
            SourceExpression.Validate(dayRange, nameof(dayRange), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/country/csv/api_key/{0}/{1}/{2}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(source, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(country, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dayRange, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nasafirms")]
        public IBodyWorkflowAction<CheckMapKeyResponse> CheckMapKey([WorkflowExpression] Func<string> mAPKEY)
        {
            SourceExpression.Validate(mAPKEY, nameof(mAPKEY), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/mapserver/mapkey_status/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["MAP_KEY"] = SourceExpressionConverter.ConvertO(mAPKEY);
                return callPayload;
            }

            return new ApiConnectionAction<CheckMapKeyResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nasafirms")]
        public IWorkflowAction ListCountries()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/countries/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nasafirms")]
        public IWorkflowAction ListDataSources()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/data_availability/csv/api_key/ALL";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }
    }

    public class NasafirmsTriggers([ConnectionName] string connectionId)
    {
    }

    public enum dayRangeInput
    {
        _1 = 1,
        _2 = 2,
        _3 = 3,
        _4 = 4,
        _5 = 5,
        _6 = 6,
        _7 = 7,
        _8 = 8,
        _9 = 9,
        _10 = 10
    }

    public class CheckMapKeyResponse
    {
        [JsonProperty("transaction_limit")]
        public int TransactionLimit { get; set; }

        [JsonProperty("current_transactions")]
        public int CurrentTransactions { get; set; }

        [JsonProperty("transaction_interval")]
        public string TransactionInterval { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Nasafirms;

    public partial class WorkflowManagedActions
    {
        public NasafirmsActions Nasafirms(string connectionId) => new NasafirmsActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public NasafirmsTriggers Nasafirms(string connectionId) => new NasafirmsTriggers(connectionId);
    }
}