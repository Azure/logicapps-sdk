//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Mavimimprove
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class MavimimproveActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IBodyWorkflowAction<IChart[], ApiConnectionActionConfiguration> GetTopicCharts(Expression<Func<string>> dbId, Expression<Func<dataLanguageInput>> dataLanguage, Expression<Func<string>> topicId)
        {
            var __workflow_dbId = WorkflowExpression.Compile(dbId, nameof(dbId), required: true);
            var __workflow_dataLanguage = WorkflowExpression.Compile(dataLanguage, nameof(dataLanguage), required: true);
            var __workflow_topicId = WorkflowExpression.Compile(topicId, nameof(topicId), required: true);
            return new DeferredBodyAction<IChart[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/{0}/{1}/topic/{2}/charts", __workflow_dbId.WithUrlEncoding(1), __workflow_dataLanguage.WithUrlEncoding(1), __workflow_topicId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<IChart[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IBodyWorkflowAction<ITopic, ApiConnectionActionConfiguration> CreateTopicAfter(Expression<Func<string>> dbId, Expression<Func<dataLanguageInput>> dataLanguage, Expression<Func<string>> topicId, Expression<Func<CreateTopicAfterInput>> body = null)
        {
            var __workflow_dbId = WorkflowExpression.Compile(dbId, nameof(dbId), required: true);
            var __workflow_dataLanguage = WorkflowExpression.Compile(dataLanguage, nameof(dataLanguage), required: true);
            var __workflow_topicId = WorkflowExpression.Compile(topicId, nameof(topicId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<ITopic, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/{0}/{1}/topic/{2}", __workflow_dbId.WithUrlEncoding(1), __workflow_dataLanguage.WithUrlEncoding(1), __workflow_topicId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ITopic>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IBodyWorkflowAction<ITopic, ApiConnectionActionConfiguration> DeleteTopic(Expression<Func<string>> dbId, Expression<Func<dataLanguageInput>> dataLanguage, Expression<Func<string>> topicId)
        {
            var __workflow_dbId = WorkflowExpression.Compile(dbId, nameof(dbId), required: true);
            var __workflow_dataLanguage = WorkflowExpression.Compile(dataLanguage, nameof(dataLanguage), required: true);
            var __workflow_topicId = WorkflowExpression.Compile(topicId, nameof(topicId), required: true);
            return new DeferredBodyAction<ITopic, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/{0}/{1}/topic/{2}", __workflow_dbId.WithUrlEncoding(1), __workflow_dataLanguage.WithUrlEncoding(1), __workflow_topicId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ITopic>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IBodyWorkflowAction<ITopic, ApiConnectionActionConfiguration> GetTopic(Expression<Func<string>> dbId, Expression<Func<dataLanguageInput>> dataLanguage, Expression<Func<string>> topicId)
        {
            var __workflow_dbId = WorkflowExpression.Compile(dbId, nameof(dbId), required: true);
            var __workflow_dataLanguage = WorkflowExpression.Compile(dataLanguage, nameof(dataLanguage), required: true);
            var __workflow_topicId = WorkflowExpression.Compile(topicId, nameof(topicId), required: true);
            return new DeferredBodyAction<ITopic, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/{0}/{1}/topic/{2}", __workflow_dbId.WithUrlEncoding(1), __workflow_dataLanguage.WithUrlEncoding(1), __workflow_topicId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ITopic>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IBodyWorkflowAction<ITopic, ApiConnectionActionConfiguration> UpdateTopic(Expression<Func<string>> dbId, Expression<Func<dataLanguageInput>> dataLanguage, Expression<Func<string>> topicId, Expression<Func<UpdateTopicInput>> body = null)
        {
            var __workflow_dbId = WorkflowExpression.Compile(dbId, nameof(dbId), required: true);
            var __workflow_dataLanguage = WorkflowExpression.Compile(dataLanguage, nameof(dataLanguage), required: true);
            var __workflow_topicId = WorkflowExpression.Compile(topicId, nameof(topicId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<ITopic, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/{0}/{1}/topic/{2}", __workflow_dbId.WithUrlEncoding(1), __workflow_dataLanguage.WithUrlEncoding(1), __workflow_topicId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ITopic>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IBodyWorkflowAction<ITopic, ApiConnectionActionConfiguration> CreateChildTopic(Expression<Func<string>> dbId, Expression<Func<dataLanguageInput>> dataLanguage, Expression<Func<string>> topicId, Expression<Func<CreateChildTopicInput>> body = null)
        {
            var __workflow_dbId = WorkflowExpression.Compile(dbId, nameof(dbId), required: true);
            var __workflow_dataLanguage = WorkflowExpression.Compile(dataLanguage, nameof(dataLanguage), required: true);
            var __workflow_topicId = WorkflowExpression.Compile(topicId, nameof(topicId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<ITopic, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/{0}/{1}/topic/{2}/children", __workflow_dbId.WithUrlEncoding(1), __workflow_dataLanguage.WithUrlEncoding(1), __workflow_topicId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ITopic>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IBodyWorkflowAction<ITopic[], ApiConnectionActionConfiguration> GetTopicChildren(Expression<Func<string>> dbId, Expression<Func<dataLanguageInput>> dataLanguage, Expression<Func<string>> topicId)
        {
            var __workflow_dbId = WorkflowExpression.Compile(dbId, nameof(dbId), required: true);
            var __workflow_dataLanguage = WorkflowExpression.Compile(dataLanguage, nameof(dataLanguage), required: true);
            var __workflow_topicId = WorkflowExpression.Compile(topicId, nameof(topicId), required: true);
            return new DeferredBodyAction<ITopic[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/{0}/{1}/topic/{2}/children", __workflow_dbId.WithUrlEncoding(1), __workflow_dataLanguage.WithUrlEncoding(1), __workflow_topicId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ITopic[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IBodyWorkflowAction<IField[], ApiConnectionActionConfiguration> GetTopicFields(Expression<Func<string>> dbId, Expression<Func<dataLanguageInput>> dataLanguage, Expression<Func<string>> topicId)
        {
            var __workflow_dbId = WorkflowExpression.Compile(dbId, nameof(dbId), required: true);
            var __workflow_dataLanguage = WorkflowExpression.Compile(dataLanguage, nameof(dataLanguage), required: true);
            var __workflow_topicId = WorkflowExpression.Compile(topicId, nameof(topicId), required: true);
            return new DeferredBodyAction<IField[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/{0}/{1}/topic/{2}/fieldsets", __workflow_dbId.WithUrlEncoding(1), __workflow_dataLanguage.WithUrlEncoding(1), __workflow_topicId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<IField[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IBodyWorkflowAction<IField, ApiConnectionActionConfiguration> GetFieldByDcvAndFieldsetId(Expression<Func<string>> dbId, Expression<Func<dataLanguageInput>> dataLanguage, Expression<Func<string>> topicId, Expression<Func<string>> fieldsetId, Expression<Func<string>> fieldId)
        {
            var __workflow_dbId = WorkflowExpression.Compile(dbId, nameof(dbId), required: true);
            var __workflow_dataLanguage = WorkflowExpression.Compile(dataLanguage, nameof(dataLanguage), required: true);
            var __workflow_topicId = WorkflowExpression.Compile(topicId, nameof(topicId), required: true);
            var __workflow_fieldsetId = WorkflowExpression.Compile(fieldsetId, nameof(fieldsetId), required: true);
            var __workflow_fieldId = WorkflowExpression.Compile(fieldId, nameof(fieldId), required: true);
            return new DeferredBodyAction<IField, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/{0}/{1}/topic/{2}/fieldsets/{3}/{4}", __workflow_dbId.WithUrlEncoding(1), __workflow_dataLanguage.WithUrlEncoding(1), __workflow_topicId.WithUrlEncoding(1), __workflow_fieldsetId.WithUrlEncoding(1), __workflow_fieldId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<IField>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IBodyWorkflowAction<IField, ApiConnectionActionConfiguration> UpdateBooleanSingleField(Expression<Func<string>> dbId, Expression<Func<dataLanguageInput>> dataLanguage, Expression<Func<string>> topicId, Expression<Func<string>> fieldsetId, Expression<Func<string>> fieldId, Expression<Func<UpdateBooleanSingleFieldInput>> body = null)
        {
            var __workflow_dbId = WorkflowExpression.Compile(dbId, nameof(dbId), required: true);
            var __workflow_dataLanguage = WorkflowExpression.Compile(dataLanguage, nameof(dataLanguage), required: true);
            var __workflow_topicId = WorkflowExpression.Compile(topicId, nameof(topicId), required: true);
            var __workflow_fieldsetId = WorkflowExpression.Compile(fieldsetId, nameof(fieldsetId), required: true);
            var __workflow_fieldId = WorkflowExpression.Compile(fieldId, nameof(fieldId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<IField, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/{0}/{1}/topic/{2}/fieldsets/{3}/bool/{4}", __workflow_dbId.WithUrlEncoding(1), __workflow_dataLanguage.WithUrlEncoding(1), __workflow_topicId.WithUrlEncoding(1), __workflow_fieldsetId.WithUrlEncoding(1), __workflow_fieldId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<IField>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IBodyWorkflowAction<IField, ApiConnectionActionConfiguration> UpdateTextSingleField(Expression<Func<string>> dbId, Expression<Func<dataLanguageInput>> dataLanguage, Expression<Func<string>> topicId, Expression<Func<string>> fieldsetId, Expression<Func<string>> fieldId, Expression<Func<UpdateTextSingleFieldInput>> body = null)
        {
            var __workflow_dbId = WorkflowExpression.Compile(dbId, nameof(dbId), required: true);
            var __workflow_dataLanguage = WorkflowExpression.Compile(dataLanguage, nameof(dataLanguage), required: true);
            var __workflow_topicId = WorkflowExpression.Compile(topicId, nameof(topicId), required: true);
            var __workflow_fieldsetId = WorkflowExpression.Compile(fieldsetId, nameof(fieldsetId), required: true);
            var __workflow_fieldId = WorkflowExpression.Compile(fieldId, nameof(fieldId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<IField, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/{0}/{1}/topic/{2}/fieldsets/{3}/text/{4}", __workflow_dbId.WithUrlEncoding(1), __workflow_dataLanguage.WithUrlEncoding(1), __workflow_topicId.WithUrlEncoding(1), __workflow_fieldsetId.WithUrlEncoding(1), __workflow_fieldId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<IField>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IBodyWorkflowAction<IField, ApiConnectionActionConfiguration> UpdateTextMultiField(Expression<Func<string>> dbId, Expression<Func<dataLanguageInput>> dataLanguage, Expression<Func<string>> topicId, Expression<Func<string>> fieldsetId, Expression<Func<string>> fieldId, Expression<Func<UpdateTextMultiFieldInput>> body = null)
        {
            var __workflow_dbId = WorkflowExpression.Compile(dbId, nameof(dbId), required: true);
            var __workflow_dataLanguage = WorkflowExpression.Compile(dataLanguage, nameof(dataLanguage), required: true);
            var __workflow_topicId = WorkflowExpression.Compile(topicId, nameof(topicId), required: true);
            var __workflow_fieldsetId = WorkflowExpression.Compile(fieldsetId, nameof(fieldsetId), required: true);
            var __workflow_fieldId = WorkflowExpression.Compile(fieldId, nameof(fieldId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<IField, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/{0}/{1}/topic/{2}/fieldsets/{3}/multitext/{4}", __workflow_dbId.WithUrlEncoding(1), __workflow_dataLanguage.WithUrlEncoding(1), __workflow_topicId.WithUrlEncoding(1), __workflow_fieldsetId.WithUrlEncoding(1), __workflow_fieldId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<IField>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IBodyWorkflowAction<IField, ApiConnectionActionConfiguration> UpdateNumberSingleField(Expression<Func<string>> dbId, Expression<Func<dataLanguageInput>> dataLanguage, Expression<Func<string>> topicId, Expression<Func<string>> fieldsetId, Expression<Func<string>> fieldId, Expression<Func<UpdateNumberSingleFieldInput>> body = null)
        {
            var __workflow_dbId = WorkflowExpression.Compile(dbId, nameof(dbId), required: true);
            var __workflow_dataLanguage = WorkflowExpression.Compile(dataLanguage, nameof(dataLanguage), required: true);
            var __workflow_topicId = WorkflowExpression.Compile(topicId, nameof(topicId), required: true);
            var __workflow_fieldsetId = WorkflowExpression.Compile(fieldsetId, nameof(fieldsetId), required: true);
            var __workflow_fieldId = WorkflowExpression.Compile(fieldId, nameof(fieldId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<IField, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/{0}/{1}/topic/{2}/fieldsets/{3}/number/{4}", __workflow_dbId.WithUrlEncoding(1), __workflow_dataLanguage.WithUrlEncoding(1), __workflow_topicId.WithUrlEncoding(1), __workflow_fieldsetId.WithUrlEncoding(1), __workflow_fieldId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<IField>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IBodyWorkflowAction<IField, ApiConnectionActionConfiguration> UpdateNumberMultiField(Expression<Func<string>> dbId, Expression<Func<dataLanguageInput>> dataLanguage, Expression<Func<string>> topicId, Expression<Func<string>> fieldsetId, Expression<Func<string>> fieldId, Expression<Func<UpdateNumberMultiFieldInput>> body = null)
        {
            var __workflow_dbId = WorkflowExpression.Compile(dbId, nameof(dbId), required: true);
            var __workflow_dataLanguage = WorkflowExpression.Compile(dataLanguage, nameof(dataLanguage), required: true);
            var __workflow_topicId = WorkflowExpression.Compile(topicId, nameof(topicId), required: true);
            var __workflow_fieldsetId = WorkflowExpression.Compile(fieldsetId, nameof(fieldsetId), required: true);
            var __workflow_fieldId = WorkflowExpression.Compile(fieldId, nameof(fieldId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<IField, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/{0}/{1}/topic/{2}/fieldsets/{3}/multinumber/{4}", __workflow_dbId.WithUrlEncoding(1), __workflow_dataLanguage.WithUrlEncoding(1), __workflow_topicId.WithUrlEncoding(1), __workflow_fieldsetId.WithUrlEncoding(1), __workflow_fieldId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<IField>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IBodyWorkflowAction<IField, ApiConnectionActionConfiguration> UpdateDecimalSingleField(Expression<Func<string>> dbId, Expression<Func<dataLanguageInput>> dataLanguage, Expression<Func<string>> topicId, Expression<Func<string>> fieldsetId, Expression<Func<string>> fieldId, Expression<Func<UpdateDecimalSingleFieldInput>> body = null)
        {
            var __workflow_dbId = WorkflowExpression.Compile(dbId, nameof(dbId), required: true);
            var __workflow_dataLanguage = WorkflowExpression.Compile(dataLanguage, nameof(dataLanguage), required: true);
            var __workflow_topicId = WorkflowExpression.Compile(topicId, nameof(topicId), required: true);
            var __workflow_fieldsetId = WorkflowExpression.Compile(fieldsetId, nameof(fieldsetId), required: true);
            var __workflow_fieldId = WorkflowExpression.Compile(fieldId, nameof(fieldId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<IField, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/{0}/{1}/topic/{2}/fieldsets/{3}/decimal/{4}", __workflow_dbId.WithUrlEncoding(1), __workflow_dataLanguage.WithUrlEncoding(1), __workflow_topicId.WithUrlEncoding(1), __workflow_fieldsetId.WithUrlEncoding(1), __workflow_fieldId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<IField>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IBodyWorkflowAction<IField, ApiConnectionActionConfiguration> UpdateDecimalMultiField(Expression<Func<string>> dbId, Expression<Func<dataLanguageInput>> dataLanguage, Expression<Func<string>> topicId, Expression<Func<string>> fieldsetId, Expression<Func<string>> fieldId, Expression<Func<UpdateDecimalMultiFieldInput>> body = null)
        {
            var __workflow_dbId = WorkflowExpression.Compile(dbId, nameof(dbId), required: true);
            var __workflow_dataLanguage = WorkflowExpression.Compile(dataLanguage, nameof(dataLanguage), required: true);
            var __workflow_topicId = WorkflowExpression.Compile(topicId, nameof(topicId), required: true);
            var __workflow_fieldsetId = WorkflowExpression.Compile(fieldsetId, nameof(fieldsetId), required: true);
            var __workflow_fieldId = WorkflowExpression.Compile(fieldId, nameof(fieldId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<IField, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/{0}/{1}/topic/{2}/fieldsets/{3}/multidecimal/{4}", __workflow_dbId.WithUrlEncoding(1), __workflow_dataLanguage.WithUrlEncoding(1), __workflow_topicId.WithUrlEncoding(1), __workflow_fieldsetId.WithUrlEncoding(1), __workflow_fieldId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<IField>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IBodyWorkflowAction<IField, ApiConnectionActionConfiguration> UpdateDateSingleField(Expression<Func<string>> dbId, Expression<Func<dataLanguageInput>> dataLanguage, Expression<Func<string>> topicId, Expression<Func<string>> fieldsetId, Expression<Func<string>> fieldId, Expression<Func<UpdateDateSingleFieldInput>> body = null)
        {
            var __workflow_dbId = WorkflowExpression.Compile(dbId, nameof(dbId), required: true);
            var __workflow_dataLanguage = WorkflowExpression.Compile(dataLanguage, nameof(dataLanguage), required: true);
            var __workflow_topicId = WorkflowExpression.Compile(topicId, nameof(topicId), required: true);
            var __workflow_fieldsetId = WorkflowExpression.Compile(fieldsetId, nameof(fieldsetId), required: true);
            var __workflow_fieldId = WorkflowExpression.Compile(fieldId, nameof(fieldId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<IField, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/{0}/{1}/topic/{2}/fieldsets/{3}/date/{4}", __workflow_dbId.WithUrlEncoding(1), __workflow_dataLanguage.WithUrlEncoding(1), __workflow_topicId.WithUrlEncoding(1), __workflow_fieldsetId.WithUrlEncoding(1), __workflow_fieldId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<IField>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IBodyWorkflowAction<IField, ApiConnectionActionConfiguration> UpdateDateMultiField(Expression<Func<string>> dbId, Expression<Func<dataLanguageInput>> dataLanguage, Expression<Func<string>> topicId, Expression<Func<string>> fieldsetId, Expression<Func<string>> fieldId, Expression<Func<UpdateDateMultiFieldInput>> body = null)
        {
            var __workflow_dbId = WorkflowExpression.Compile(dbId, nameof(dbId), required: true);
            var __workflow_dataLanguage = WorkflowExpression.Compile(dataLanguage, nameof(dataLanguage), required: true);
            var __workflow_topicId = WorkflowExpression.Compile(topicId, nameof(topicId), required: true);
            var __workflow_fieldsetId = WorkflowExpression.Compile(fieldsetId, nameof(fieldsetId), required: true);
            var __workflow_fieldId = WorkflowExpression.Compile(fieldId, nameof(fieldId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<IField, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/{0}/{1}/topic/{2}/fieldsets/{3}/multidate/{4}", __workflow_dbId.WithUrlEncoding(1), __workflow_dataLanguage.WithUrlEncoding(1), __workflow_topicId.WithUrlEncoding(1), __workflow_fieldsetId.WithUrlEncoding(1), __workflow_fieldId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<IField>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IBodyWorkflowAction<IField, ApiConnectionActionConfiguration> UpdateListSingleField(Expression<Func<string>> dbId, Expression<Func<dataLanguageInput>> dataLanguage, Expression<Func<string>> topicId, Expression<Func<string>> fieldsetId, Expression<Func<string>> fieldId, Expression<Func<UpdateListSingleFieldInput>> body = null)
        {
            var __workflow_dbId = WorkflowExpression.Compile(dbId, nameof(dbId), required: true);
            var __workflow_dataLanguage = WorkflowExpression.Compile(dataLanguage, nameof(dataLanguage), required: true);
            var __workflow_topicId = WorkflowExpression.Compile(topicId, nameof(topicId), required: true);
            var __workflow_fieldsetId = WorkflowExpression.Compile(fieldsetId, nameof(fieldsetId), required: true);
            var __workflow_fieldId = WorkflowExpression.Compile(fieldId, nameof(fieldId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<IField, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/{0}/{1}/topic/{2}/fieldsets/{3}/list/{4}", __workflow_dbId.WithUrlEncoding(1), __workflow_dataLanguage.WithUrlEncoding(1), __workflow_topicId.WithUrlEncoding(1), __workflow_fieldsetId.WithUrlEncoding(1), __workflow_fieldId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<IField>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IBodyWorkflowAction<IField, ApiConnectionActionConfiguration> UpdateRelationshipSingleField(Expression<Func<string>> dbId, Expression<Func<dataLanguageInput>> dataLanguage, Expression<Func<string>> topicId, Expression<Func<string>> fieldsetId, Expression<Func<string>> fieldId, Expression<Func<UpdateRelationshipSingleFieldInput>> body = null)
        {
            var __workflow_dbId = WorkflowExpression.Compile(dbId, nameof(dbId), required: true);
            var __workflow_dataLanguage = WorkflowExpression.Compile(dataLanguage, nameof(dataLanguage), required: true);
            var __workflow_topicId = WorkflowExpression.Compile(topicId, nameof(topicId), required: true);
            var __workflow_fieldsetId = WorkflowExpression.Compile(fieldsetId, nameof(fieldsetId), required: true);
            var __workflow_fieldId = WorkflowExpression.Compile(fieldId, nameof(fieldId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<IField, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/{0}/{1}/topic/{2}/fieldsets/{3}/relationship/{4}", __workflow_dbId.WithUrlEncoding(1), __workflow_dataLanguage.WithUrlEncoding(1), __workflow_topicId.WithUrlEncoding(1), __workflow_fieldsetId.WithUrlEncoding(1), __workflow_fieldId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<IField>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IBodyWorkflowAction<IField, ApiConnectionActionConfiguration> UpdateRelationshipMultiField(Expression<Func<string>> dbId, Expression<Func<dataLanguageInput>> dataLanguage, Expression<Func<string>> topicId, Expression<Func<string>> fieldsetId, Expression<Func<string>> fieldId, Expression<Func<UpdateRelationshipMultiFieldInput>> body = null)
        {
            var __workflow_dbId = WorkflowExpression.Compile(dbId, nameof(dbId), required: true);
            var __workflow_dataLanguage = WorkflowExpression.Compile(dataLanguage, nameof(dataLanguage), required: true);
            var __workflow_topicId = WorkflowExpression.Compile(topicId, nameof(topicId), required: true);
            var __workflow_fieldsetId = WorkflowExpression.Compile(fieldsetId, nameof(fieldsetId), required: true);
            var __workflow_fieldId = WorkflowExpression.Compile(fieldId, nameof(fieldId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<IField, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/{0}/{1}/topic/{2}/fieldsets/{3}/multirelationship/{4}", __workflow_dbId.WithUrlEncoding(1), __workflow_dataLanguage.WithUrlEncoding(1), __workflow_topicId.WithUrlEncoding(1), __workflow_fieldsetId.WithUrlEncoding(1), __workflow_fieldId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<IField>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IBodyWorkflowAction<IField, ApiConnectionActionConfiguration> UpdateRelationshipListField(Expression<Func<string>> dbId, Expression<Func<dataLanguageInput>> dataLanguage, Expression<Func<string>> topicId, Expression<Func<string>> fieldsetId, Expression<Func<string>> fieldId, Expression<Func<UpdateRelationshipListFieldInput>> body = null)
        {
            var __workflow_dbId = WorkflowExpression.Compile(dbId, nameof(dbId), required: true);
            var __workflow_dataLanguage = WorkflowExpression.Compile(dataLanguage, nameof(dataLanguage), required: true);
            var __workflow_topicId = WorkflowExpression.Compile(topicId, nameof(topicId), required: true);
            var __workflow_fieldsetId = WorkflowExpression.Compile(fieldsetId, nameof(fieldsetId), required: true);
            var __workflow_fieldId = WorkflowExpression.Compile(fieldId, nameof(fieldId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<IField, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/{0}/{1}/topic/{2}/fieldsets/{3}/relationshiplist/{4}", __workflow_dbId.WithUrlEncoding(1), __workflow_dataLanguage.WithUrlEncoding(1), __workflow_topicId.WithUrlEncoding(1), __workflow_fieldsetId.WithUrlEncoding(1), __workflow_fieldId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<IField>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IBodyWorkflowAction<IField, ApiConnectionActionConfiguration> UpdateFields(Expression<Func<string>> dbId, Expression<Func<dataLanguageInput>> dataLanguage, Expression<Func<string>> topicId, Expression<Func<UpdateFieldsInput>> body = null)
        {
            var __workflow_dbId = WorkflowExpression.Compile(dbId, nameof(dbId), required: true);
            var __workflow_dataLanguage = WorkflowExpression.Compile(dataLanguage, nameof(dataLanguage), required: true);
            var __workflow_topicId = WorkflowExpression.Compile(topicId, nameof(topicId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<IField, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/{0}/{1}/topic/{2}/fields", __workflow_dbId.WithUrlEncoding(1), __workflow_dataLanguage.WithUrlEncoding(1), __workflow_topicId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<IField>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IBodyWorkflowAction<IField, ApiConnectionActionConfiguration> UpdateSingleHyperlinkField(Expression<Func<string>> dbId, Expression<Func<dataLanguageInput>> dataLanguage, Expression<Func<string>> topicId, Expression<Func<string>> fieldsetId, Expression<Func<string>> fieldId, Expression<Func<UpdateSingleHyperlinkFieldInput>> body = null)
        {
            var __workflow_dbId = WorkflowExpression.Compile(dbId, nameof(dbId), required: true);
            var __workflow_dataLanguage = WorkflowExpression.Compile(dataLanguage, nameof(dataLanguage), required: true);
            var __workflow_topicId = WorkflowExpression.Compile(topicId, nameof(topicId), required: true);
            var __workflow_fieldsetId = WorkflowExpression.Compile(fieldsetId, nameof(fieldsetId), required: true);
            var __workflow_fieldId = WorkflowExpression.Compile(fieldId, nameof(fieldId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<IField, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/{0}/{1}/topic/{2}/fieldsets/{3}/hyperlink/{4}", __workflow_dbId.WithUrlEncoding(1), __workflow_dataLanguage.WithUrlEncoding(1), __workflow_topicId.WithUrlEncoding(1), __workflow_fieldsetId.WithUrlEncoding(1), __workflow_fieldId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<IField>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IBodyWorkflowAction<IField, ApiConnectionActionConfiguration> UpdateMultiHyperlinkField(Expression<Func<string>> dbId, Expression<Func<dataLanguageInput>> dataLanguage, Expression<Func<string>> topicId, Expression<Func<string>> fieldsetId, Expression<Func<string>> fieldId, Expression<Func<UpdateMultiHyperlinkFieldInput>> body = null)
        {
            var __workflow_dbId = WorkflowExpression.Compile(dbId, nameof(dbId), required: true);
            var __workflow_dataLanguage = WorkflowExpression.Compile(dataLanguage, nameof(dataLanguage), required: true);
            var __workflow_topicId = WorkflowExpression.Compile(topicId, nameof(topicId), required: true);
            var __workflow_fieldsetId = WorkflowExpression.Compile(fieldsetId, nameof(fieldsetId), required: true);
            var __workflow_fieldId = WorkflowExpression.Compile(fieldId, nameof(fieldId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<IField, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/{0}/{1}/topic/{2}/fieldsets/{3}/multihyperlink/{4}", __workflow_dbId.WithUrlEncoding(1), __workflow_dataLanguage.WithUrlEncoding(1), __workflow_topicId.WithUrlEncoding(1), __workflow_fieldsetId.WithUrlEncoding(1), __workflow_fieldId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<IField>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IWorkflowAction<ApiConnectionActionConfiguration> MoveTopicToTop(Expression<Func<string>> dbId, Expression<Func<dataLanguageInput>> dataLanguage, Expression<Func<string>> topicId)
        {
            var __workflow_dbId = WorkflowExpression.Compile(dbId, nameof(dbId), required: true);
            var __workflow_dataLanguage = WorkflowExpression.Compile(dataLanguage, nameof(dataLanguage), required: true);
            var __workflow_topicId = WorkflowExpression.Compile(topicId, nameof(topicId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/{0}/{1}/topic/{2}/movetotop", __workflow_dbId.WithUrlEncoding(1), __workflow_dataLanguage.WithUrlEncoding(1), __workflow_topicId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IWorkflowAction<ApiConnectionActionConfiguration> MoveTopicToBottom(Expression<Func<string>> dbId, Expression<Func<dataLanguageInput>> dataLanguage, Expression<Func<string>> topicId)
        {
            var __workflow_dbId = WorkflowExpression.Compile(dbId, nameof(dbId), required: true);
            var __workflow_dataLanguage = WorkflowExpression.Compile(dataLanguage, nameof(dataLanguage), required: true);
            var __workflow_topicId = WorkflowExpression.Compile(topicId, nameof(topicId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/{0}/{1}/topic/{2}/movetobottom", __workflow_dbId.WithUrlEncoding(1), __workflow_dataLanguage.WithUrlEncoding(1), __workflow_topicId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IWorkflowAction<ApiConnectionActionConfiguration> MoveTopicUp(Expression<Func<string>> dbId, Expression<Func<dataLanguageInput>> dataLanguage, Expression<Func<string>> topicId)
        {
            var __workflow_dbId = WorkflowExpression.Compile(dbId, nameof(dbId), required: true);
            var __workflow_dataLanguage = WorkflowExpression.Compile(dataLanguage, nameof(dataLanguage), required: true);
            var __workflow_topicId = WorkflowExpression.Compile(topicId, nameof(topicId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/{0}/{1}/topic/{2}/moveup", __workflow_dbId.WithUrlEncoding(1), __workflow_dataLanguage.WithUrlEncoding(1), __workflow_topicId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IWorkflowAction<ApiConnectionActionConfiguration> MoveTopicDown(Expression<Func<string>> dbId, Expression<Func<dataLanguageInput>> dataLanguage, Expression<Func<string>> topicId)
        {
            var __workflow_dbId = WorkflowExpression.Compile(dbId, nameof(dbId), required: true);
            var __workflow_dataLanguage = WorkflowExpression.Compile(dataLanguage, nameof(dataLanguage), required: true);
            var __workflow_topicId = WorkflowExpression.Compile(topicId, nameof(topicId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/{0}/{1}/topic/{2}/movedown", __workflow_dbId.WithUrlEncoding(1), __workflow_dataLanguage.WithUrlEncoding(1), __workflow_topicId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IWorkflowAction<ApiConnectionActionConfiguration> MoveTopicLevelUp(Expression<Func<string>> dbId, Expression<Func<dataLanguageInput>> dataLanguage, Expression<Func<string>> topicId)
        {
            var __workflow_dbId = WorkflowExpression.Compile(dbId, nameof(dbId), required: true);
            var __workflow_dataLanguage = WorkflowExpression.Compile(dataLanguage, nameof(dataLanguage), required: true);
            var __workflow_topicId = WorkflowExpression.Compile(topicId, nameof(topicId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/{0}/{1}/topic/{2}/movelevelup", __workflow_dbId.WithUrlEncoding(1), __workflow_dataLanguage.WithUrlEncoding(1), __workflow_topicId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IWorkflowAction<ApiConnectionActionConfiguration> MoveTopicLevelDown(Expression<Func<string>> dbId, Expression<Func<dataLanguageInput>> dataLanguage, Expression<Func<string>> topicId)
        {
            var __workflow_dbId = WorkflowExpression.Compile(dbId, nameof(dbId), required: true);
            var __workflow_dataLanguage = WorkflowExpression.Compile(dataLanguage, nameof(dataLanguage), required: true);
            var __workflow_topicId = WorkflowExpression.Compile(topicId, nameof(topicId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/{0}/{1}/topic/{2}/moveleveldown", __workflow_dbId.WithUrlEncoding(1), __workflow_dataLanguage.WithUrlEncoding(1), __workflow_topicId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IBodyWorkflowAction<IRelationship[], ApiConnectionActionConfiguration> GetTopicRelations(Expression<Func<string>> dbId, Expression<Func<dataLanguageInput>> dataLanguage, Expression<Func<string>> topicId)
        {
            var __workflow_dbId = WorkflowExpression.Compile(dbId, nameof(dbId), required: true);
            var __workflow_dataLanguage = WorkflowExpression.Compile(dataLanguage, nameof(dataLanguage), required: true);
            var __workflow_topicId = WorkflowExpression.Compile(topicId, nameof(topicId), required: true);
            return new DeferredBodyAction<IRelationship[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/{0}/{1}/topic/{2}/relations", __workflow_dbId.WithUrlEncoding(1), __workflow_dataLanguage.WithUrlEncoding(1), __workflow_topicId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<IRelationship[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IBodyWorkflowAction<IRelationship, ApiConnectionActionConfiguration> SaveRelation(Expression<Func<string>> dbId, Expression<Func<dataLanguageInput>> dataLanguage, Expression<Func<SaveRelationInput>> body = null)
        {
            var __workflow_dbId = WorkflowExpression.Compile(dbId, nameof(dbId), required: true);
            var __workflow_dataLanguage = WorkflowExpression.Compile(dataLanguage, nameof(dataLanguage), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<IRelationship, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/{0}/{1}/relation", __workflow_dbId.WithUrlEncoding(1), __workflow_dataLanguage.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<IRelationship>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteRelation(Expression<Func<string>> dbId, Expression<Func<dataLanguageInput>> dataLanguage, Expression<Func<string>> topicId, Expression<Func<string>> relationId)
        {
            var __workflow_dbId = WorkflowExpression.Compile(dbId, nameof(dbId), required: true);
            var __workflow_dataLanguage = WorkflowExpression.Compile(dataLanguage, nameof(dataLanguage), required: true);
            var __workflow_topicId = WorkflowExpression.Compile(topicId, nameof(topicId), required: true);
            var __workflow_relationId = WorkflowExpression.Compile(relationId, nameof(relationId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/{0}/{1}/topic/{2}/relation/{3}", __workflow_dbId.WithUrlEncoding(1), __workflow_dataLanguage.WithUrlEncoding(1), __workflow_topicId.WithUrlEncoding(1), __workflow_relationId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IBodyWorkflowAction<ITopic, ApiConnectionActionConfiguration> GetTopicRoot(Expression<Func<string>> dbId, Expression<Func<dataLanguageInput>> dataLanguage)
        {
            var __workflow_dbId = WorkflowExpression.Compile(dbId, nameof(dbId), required: true);
            var __workflow_dataLanguage = WorkflowExpression.Compile(dataLanguage, nameof(dataLanguage), required: true);
            return new DeferredBodyAction<ITopic, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/{0}/{1}/root", __workflow_dbId.WithUrlEncoding(1), __workflow_dataLanguage.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ITopic>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IBodyWorkflowAction<ITopicPath, ApiConnectionActionConfiguration> GetPathToRoot(Expression<Func<string>> dbId, Expression<Func<dataLanguageInput>> dataLanguage, Expression<Func<string>> topicId)
        {
            var __workflow_dbId = WorkflowExpression.Compile(dbId, nameof(dbId), required: true);
            var __workflow_dataLanguage = WorkflowExpression.Compile(dataLanguage, nameof(dataLanguage), required: true);
            var __workflow_topicId = WorkflowExpression.Compile(topicId, nameof(topicId), required: true);
            return new DeferredBodyAction<ITopicPath, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/{0}/{1}/path/{2}", __workflow_dbId.WithUrlEncoding(1), __workflow_dataLanguage.WithUrlEncoding(1), __workflow_topicId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ITopicPath>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IBodyWorkflowAction<ITopic[], ApiConnectionActionConfiguration> GetTopicSiblings(Expression<Func<string>> dbId, Expression<Func<dataLanguageInput>> dataLanguage, Expression<Func<string>> topicId)
        {
            var __workflow_dbId = WorkflowExpression.Compile(dbId, nameof(dbId), required: true);
            var __workflow_dataLanguage = WorkflowExpression.Compile(dataLanguage, nameof(dataLanguage), required: true);
            var __workflow_topicId = WorkflowExpression.Compile(topicId, nameof(topicId), required: true);
            return new DeferredBodyAction<ITopic[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/{0}/{1}/topic/{2}/siblings", __workflow_dbId.WithUrlEncoding(1), __workflow_dataLanguage.WithUrlEncoding(1), __workflow_topicId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ITopic[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IBodyWorkflowAction<ITopic[], ApiConnectionActionConfiguration> GetRelationCategories(Expression<Func<string>> dbId, Expression<Func<dataLanguageInput>> dataLanguage)
        {
            var __workflow_dbId = WorkflowExpression.Compile(dbId, nameof(dbId), required: true);
            var __workflow_dataLanguage = WorkflowExpression.Compile(dataLanguage, nameof(dataLanguage), required: true);
            return new DeferredBodyAction<ITopic[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/{0}/{1}/topic/categories", __workflow_dbId.WithUrlEncoding(1), __workflow_dataLanguage.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ITopic[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> GetTopicTypes(Expression<Func<string>> dbId, Expression<Func<dataLanguageInput>> dataLanguage, Expression<Func<string>> topicId)
        {
            var __workflow_dbId = WorkflowExpression.Compile(dbId, nameof(dbId), required: true);
            var __workflow_dataLanguage = WorkflowExpression.Compile(dataLanguage, nameof(dataLanguage), required: true);
            var __workflow_topicId = WorkflowExpression.Compile(topicId, nameof(topicId), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/{0}/{1}/topic/{2}/types", __workflow_dbId.WithUrlEncoding(1), __workflow_dataLanguage.WithUrlEncoding(1), __workflow_topicId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> GetTopicIcons(Expression<Func<string>> dbId, Expression<Func<dataLanguageInput>> dataLanguage, Expression<Func<string>> topicType)
        {
            var __workflow_dbId = WorkflowExpression.Compile(dbId, nameof(dbId), required: true);
            var __workflow_dataLanguage = WorkflowExpression.Compile(dataLanguage, nameof(dataLanguage), required: true);
            var __workflow_topicType = WorkflowExpression.Compile(topicType, nameof(topicType), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/{0}/{1}/types/{2}/icons", __workflow_dbId.WithUrlEncoding(1), __workflow_dataLanguage.WithUrlEncoding(1), __workflow_topicType.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> Version()
        {
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/version";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }
    }

    public class MavimimproveTriggers([ConnectionName] string connectionId)
    {
    }

    public class IChart
    {
        [JsonProperty("dcv")]
        public string Dcv { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum dataLanguageInput
    {
        [EnumMember(Value = "en")]
        En,
        [EnumMember(Value = "nl")]
        Nl
    }

    public class ITopic
    {
        [JsonProperty("dcv")]
        public string Dcv { get; set; }

        [JsonProperty("parent")]
        public string Parent { get; set; }

        [JsonProperty("hasChildren")]
        public bool HasChildren { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("typeCategory")]
        public TopicType TypeCategory { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("orderNumber")]
        public int OrderNumber { get; set; }

        [JsonProperty("resources")]
        public TopicResource[] Resources { get; set; }

        [JsonProperty("isInRecycleBin")]
        public bool IsInRecycleBin { get; set; }

        [JsonProperty("business")]
        public ITopicBusiness Business { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum TopicType
    {
        Unknown,
        Virtual,
        MavimElementContainer,
        RelationCategories,
        WithWhat,
        Who,
        Where,
        When,
        Why,
        WhereTo,
        RecycleBin
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum TopicResource
    {
        Chart,
        Description,
        Fields,
        Relations,
        SubTopics
    }

    public class ITopicBusiness
    {
        [JsonProperty("isReadOnly")]
        public bool IsReadOnly { get; set; }

        [JsonProperty("canDelete")]
        public bool CanDelete { get; set; }

        [JsonProperty("canCreateChildTopic")]
        public bool CanCreateChildTopic { get; set; }

        [JsonProperty("canCreateTopicAfter")]
        public bool CanCreateTopicAfter { get; set; }
    }

    public class CreateTopicAfterInput
    {
        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Type { get; set; }

        [JsonProperty("icon", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Icon { get; set; }
    }

    public class UpdateTopicInput
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class CreateChildTopicInput
    {
        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Type { get; set; }

        [JsonProperty("icon", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Icon { get; set; }
    }

    public class IField
    {
        [JsonProperty("fieldsetId")]
        public string FieldsetId { get; set; }

        [JsonProperty("fieldId")]
        public string FieldId { get; set; }

        [JsonProperty("setOrder")]
        public int SetOrder { get; set; }

        [JsonProperty("order")]
        public int Order { get; set; }

        [JsonProperty("setName")]
        public string SetName { get; set; }

        [JsonProperty("fieldName")]
        public string FieldName { get; set; }

        [JsonProperty("topicId")]
        public string TopicId { get; set; }

        [JsonProperty("fieldValueType")]
        public FieldType FieldValueType { get; set; }

        [JsonProperty("required")]
        public bool Required { get; set; }

        [JsonProperty("readonly")]
        public bool Readonly { get; set; }

        [JsonProperty("usage")]
        public string Usage { get; set; }

        [JsonProperty("relationshipCategory")]
        public IRelationshipElement RelationshipCategory { get; set; }

        [JsonProperty("characteristic")]
        public IRelationshipElement Characteristic { get; set; }

        [JsonProperty("openLocation")]
        public string OpenLocation { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum FieldType
    {
        Unknown,
        Text,
        MultiText,
        Number,
        MultiNumber,
        Decimal,
        MultiDecimal,
        Boolean,
        Date,
        MultiDate,
        List,
        Relationship,
        MultiRelationship,
        RelationshipList,
        Hyperlink,
        MultiHyperlink
    }

    public class IRelationshipElement
    {
        [JsonProperty("dcv")]
        public string Dcv { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }
    }

    public class UpdateBooleanSingleFieldInput
    {
        [JsonProperty("fieldsetId")]
        public string FieldsetId { get; set; }

        [JsonProperty("fieldId")]
        public string FieldId { get; set; }

        [JsonProperty("setOrder")]
        public int? SetOrder { get; set; }

        [JsonProperty("order")]
        public int? Order { get; set; }

        [JsonProperty("topicId")]
        public string TopicId { get; set; }

        [JsonProperty("setName")]
        public string SetName { get; set; }

        [JsonProperty("fieldName")]
        public string FieldName { get; set; }

        [JsonProperty("fieldValueType")]
        public FieldType? FieldValueType { get; set; }

        [JsonProperty("required")]
        public bool? Required { get; set; }

        [JsonProperty("readonly")]
        public bool? Readonly { get; set; }

        [JsonProperty("usage")]
        public string Usage { get; set; }

        [JsonProperty("relationshipCategory")]
        public IRelationshipElement RelationshipCategory { get; set; }

        [JsonProperty("characteristic")]
        public IRelationshipElement Characteristic { get; set; }

        [JsonProperty("openLocation")]
        public string OpenLocation { get; set; }

        [JsonProperty("data")]
        public bool? Data { get; set; }
    }

    public class UpdateTextSingleFieldInput
    {
        [JsonProperty("fieldsetId")]
        public string FieldsetId { get; set; }

        [JsonProperty("fieldId")]
        public string FieldId { get; set; }

        [JsonProperty("setOrder")]
        public int? SetOrder { get; set; }

        [JsonProperty("order")]
        public int? Order { get; set; }

        [JsonProperty("topicId")]
        public string TopicId { get; set; }

        [JsonProperty("setName")]
        public string SetName { get; set; }

        [JsonProperty("fieldName")]
        public string FieldName { get; set; }

        [JsonProperty("fieldValueType")]
        public FieldType? FieldValueType { get; set; }

        [JsonProperty("required")]
        public bool? Required { get; set; }

        [JsonProperty("readonly")]
        public bool? Readonly { get; set; }

        [JsonProperty("usage")]
        public string Usage { get; set; }

        [JsonProperty("relationshipCategory")]
        public IRelationshipElement RelationshipCategory { get; set; }

        [JsonProperty("characteristic")]
        public IRelationshipElement Characteristic { get; set; }

        [JsonProperty("openLocation")]
        public string OpenLocation { get; set; }

        [JsonProperty("data")]
        public string Data { get; set; }
    }

    public class UpdateTextMultiFieldInput
    {
        [JsonProperty("fieldsetId")]
        public string FieldsetId { get; set; }

        [JsonProperty("fieldId")]
        public string FieldId { get; set; }

        [JsonProperty("setOrder")]
        public int? SetOrder { get; set; }

        [JsonProperty("order")]
        public int? Order { get; set; }

        [JsonProperty("topicId")]
        public string TopicId { get; set; }

        [JsonProperty("setName")]
        public string SetName { get; set; }

        [JsonProperty("fieldName")]
        public string FieldName { get; set; }

        [JsonProperty("fieldValueType")]
        public FieldType? FieldValueType { get; set; }

        [JsonProperty("required")]
        public bool? Required { get; set; }

        [JsonProperty("readonly")]
        public bool? Readonly { get; set; }

        [JsonProperty("usage")]
        public string Usage { get; set; }

        [JsonProperty("relationshipCategory")]
        public IRelationshipElement RelationshipCategory { get; set; }

        [JsonProperty("characteristic")]
        public IRelationshipElement Characteristic { get; set; }

        [JsonProperty("openLocation")]
        public string OpenLocation { get; set; }

        [JsonProperty("data")]
        public string[] Data { get; set; }
    }

    public class UpdateNumberSingleFieldInput
    {
        [JsonProperty("fieldsetId")]
        public string FieldsetId { get; set; }

        [JsonProperty("fieldId")]
        public string FieldId { get; set; }

        [JsonProperty("setOrder")]
        public int? SetOrder { get; set; }

        [JsonProperty("order")]
        public int? Order { get; set; }

        [JsonProperty("topicId")]
        public string TopicId { get; set; }

        [JsonProperty("setName")]
        public string SetName { get; set; }

        [JsonProperty("fieldName")]
        public string FieldName { get; set; }

        [JsonProperty("fieldValueType")]
        public FieldType? FieldValueType { get; set; }

        [JsonProperty("required")]
        public bool? Required { get; set; }

        [JsonProperty("readonly")]
        public bool? Readonly { get; set; }

        [JsonProperty("usage")]
        public string Usage { get; set; }

        [JsonProperty("relationshipCategory")]
        public IRelationshipElement RelationshipCategory { get; set; }

        [JsonProperty("characteristic")]
        public IRelationshipElement Characteristic { get; set; }

        [JsonProperty("openLocation")]
        public string OpenLocation { get; set; }

        [JsonProperty("data")]
        public int? Data { get; set; }
    }

    public class UpdateNumberMultiFieldInput
    {
        [JsonProperty("fieldsetId")]
        public string FieldsetId { get; set; }

        [JsonProperty("fieldId")]
        public string FieldId { get; set; }

        [JsonProperty("setOrder")]
        public int? SetOrder { get; set; }

        [JsonProperty("order")]
        public int? Order { get; set; }

        [JsonProperty("topicId")]
        public string TopicId { get; set; }

        [JsonProperty("setName")]
        public string SetName { get; set; }

        [JsonProperty("fieldName")]
        public string FieldName { get; set; }

        [JsonProperty("fieldValueType")]
        public FieldType? FieldValueType { get; set; }

        [JsonProperty("required")]
        public bool? Required { get; set; }

        [JsonProperty("readonly")]
        public bool? Readonly { get; set; }

        [JsonProperty("usage")]
        public string Usage { get; set; }

        [JsonProperty("relationshipCategory")]
        public IRelationshipElement RelationshipCategory { get; set; }

        [JsonProperty("characteristic")]
        public IRelationshipElement Characteristic { get; set; }

        [JsonProperty("openLocation")]
        public string OpenLocation { get; set; }

        [JsonProperty("data")]
        public int[] Data { get; set; }
    }

    public class UpdateDecimalSingleFieldInput
    {
        [JsonProperty("fieldsetId")]
        public string FieldsetId { get; set; }

        [JsonProperty("fieldId")]
        public string FieldId { get; set; }

        [JsonProperty("setOrder")]
        public int? SetOrder { get; set; }

        [JsonProperty("order")]
        public int? Order { get; set; }

        [JsonProperty("topicId")]
        public string TopicId { get; set; }

        [JsonProperty("setName")]
        public string SetName { get; set; }

        [JsonProperty("fieldName")]
        public string FieldName { get; set; }

        [JsonProperty("fieldValueType")]
        public FieldType? FieldValueType { get; set; }

        [JsonProperty("required")]
        public bool? Required { get; set; }

        [JsonProperty("readonly")]
        public bool? Readonly { get; set; }

        [JsonProperty("usage")]
        public string Usage { get; set; }

        [JsonProperty("relationshipCategory")]
        public IRelationshipElement RelationshipCategory { get; set; }

        [JsonProperty("characteristic")]
        public IRelationshipElement Characteristic { get; set; }

        [JsonProperty("openLocation")]
        public string OpenLocation { get; set; }

        [JsonProperty("data")]
        public double? Data { get; set; }
    }

    public class UpdateDecimalMultiFieldInput
    {
        [JsonProperty("fieldsetId")]
        public string FieldsetId { get; set; }

        [JsonProperty("fieldId")]
        public string FieldId { get; set; }

        [JsonProperty("setOrder")]
        public int? SetOrder { get; set; }

        [JsonProperty("order")]
        public int? Order { get; set; }

        [JsonProperty("topicId")]
        public string TopicId { get; set; }

        [JsonProperty("setName")]
        public string SetName { get; set; }

        [JsonProperty("fieldName")]
        public string FieldName { get; set; }

        [JsonProperty("fieldValueType")]
        public FieldType? FieldValueType { get; set; }

        [JsonProperty("required")]
        public bool? Required { get; set; }

        [JsonProperty("readonly")]
        public bool? Readonly { get; set; }

        [JsonProperty("usage")]
        public string Usage { get; set; }

        [JsonProperty("relationshipCategory")]
        public IRelationshipElement RelationshipCategory { get; set; }

        [JsonProperty("characteristic")]
        public IRelationshipElement Characteristic { get; set; }

        [JsonProperty("openLocation")]
        public string OpenLocation { get; set; }

        [JsonProperty("data")]
        public double[] Data { get; set; }
    }

    public class UpdateDateSingleFieldInput
    {
        [JsonProperty("fieldsetId")]
        public string FieldsetId { get; set; }

        [JsonProperty("fieldId")]
        public string FieldId { get; set; }

        [JsonProperty("setOrder")]
        public int? SetOrder { get; set; }

        [JsonProperty("order")]
        public int? Order { get; set; }

        [JsonProperty("topicId")]
        public string TopicId { get; set; }

        [JsonProperty("setName")]
        public string SetName { get; set; }

        [JsonProperty("fieldName")]
        public string FieldName { get; set; }

        [JsonProperty("fieldValueType")]
        public FieldType? FieldValueType { get; set; }

        [JsonProperty("required")]
        public bool? Required { get; set; }

        [JsonProperty("readonly")]
        public bool? Readonly { get; set; }

        [JsonProperty("usage")]
        public string Usage { get; set; }

        [JsonProperty("relationshipCategory")]
        public IRelationshipElement RelationshipCategory { get; set; }

        [JsonProperty("characteristic")]
        public IRelationshipElement Characteristic { get; set; }

        [JsonProperty("openLocation")]
        public string OpenLocation { get; set; }

        [JsonProperty("data")]
        public string Data { get; set; }
    }

    public class UpdateDateMultiFieldInput
    {
        [JsonProperty("fieldsetId")]
        public string FieldsetId { get; set; }

        [JsonProperty("fieldId")]
        public string FieldId { get; set; }

        [JsonProperty("setOrder")]
        public int? SetOrder { get; set; }

        [JsonProperty("order")]
        public int? Order { get; set; }

        [JsonProperty("topicId")]
        public string TopicId { get; set; }

        [JsonProperty("setName")]
        public string SetName { get; set; }

        [JsonProperty("fieldName")]
        public string FieldName { get; set; }

        [JsonProperty("fieldValueType")]
        public FieldType? FieldValueType { get; set; }

        [JsonProperty("required")]
        public bool? Required { get; set; }

        [JsonProperty("readonly")]
        public bool? Readonly { get; set; }

        [JsonProperty("usage")]
        public string Usage { get; set; }

        [JsonProperty("relationshipCategory")]
        public IRelationshipElement RelationshipCategory { get; set; }

        [JsonProperty("characteristic")]
        public IRelationshipElement Characteristic { get; set; }

        [JsonProperty("openLocation")]
        public string OpenLocation { get; set; }

        [JsonProperty("data")]
        public string[] Data { get; set; }
    }

    public class UpdateListSingleFieldInput
    {
        [JsonProperty("fieldsetId")]
        public string FieldsetId { get; set; }

        [JsonProperty("fieldId")]
        public string FieldId { get; set; }

        [JsonProperty("setOrder")]
        public int? SetOrder { get; set; }

        [JsonProperty("order")]
        public int? Order { get; set; }

        [JsonProperty("topicId")]
        public string TopicId { get; set; }

        [JsonProperty("setName")]
        public string SetName { get; set; }

        [JsonProperty("fieldName")]
        public string FieldName { get; set; }

        [JsonProperty("fieldValueType")]
        public FieldType? FieldValueType { get; set; }

        [JsonProperty("required")]
        public bool? Required { get; set; }

        [JsonProperty("readonly")]
        public bool? Readonly { get; set; }

        [JsonProperty("usage")]
        public string Usage { get; set; }

        [JsonProperty("relationshipCategory")]
        public IRelationshipElement RelationshipCategory { get; set; }

        [JsonProperty("characteristic")]
        public IRelationshipElement Characteristic { get; set; }

        [JsonProperty("openLocation")]
        public string OpenLocation { get; set; }

        [JsonProperty("data")]
        public JToken Data { get; set; }

        [JsonProperty("options")]
        public JToken Options { get; set; }
    }

    public class UpdateRelationshipSingleFieldInput
    {
        [JsonProperty("fieldId")]
        public string FieldId { get; set; }

        [JsonProperty("fieldsetId")]
        public string FieldsetId { get; set; }

        [JsonProperty("data")]
        public RelationshipElement Data { get; set; }
    }

    public class RelationshipElement
    {
        [JsonProperty("dcv")]
        public string Dcv { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }
    }

    public class UpdateRelationshipMultiFieldInput
    {
        [JsonProperty("fieldId")]
        public string FieldId { get; set; }

        [JsonProperty("fieldsetId")]
        public string FieldsetId { get; set; }

        [JsonProperty("data")]
        public RelationshipElement[] Data { get; set; }
    }

    public class UpdateRelationshipListFieldInput
    {
        [JsonProperty("fieldId")]
        public string FieldId { get; set; }

        [JsonProperty("fieldsetId")]
        public string FieldsetId { get; set; }

        [JsonProperty("data")]
        public JToken Data { get; set; }
    }

    public class UpdateFieldsInput
    {
        [JsonProperty("singleTextFields")]
        public SingleTextField[] SingleTextFields { get; set; }

        [JsonProperty("multiTextFields")]
        public MultiTextField[] MultiTextFields { get; set; }

        [JsonProperty("singleNumberFields")]
        public SingleNumberField[] SingleNumberFields { get; set; }

        [JsonProperty("multiNumberFields")]
        public MultiNumberField[] MultiNumberFields { get; set; }

        [JsonProperty("singleBooleanFields")]
        public SingleBooleanField[] SingleBooleanFields { get; set; }

        [JsonProperty("singleDecimalFields")]
        public SingleDecimalField[] SingleDecimalFields { get; set; }

        [JsonProperty("multiDecimalFields")]
        public MultiDecimalField[] MultiDecimalFields { get; set; }

        [JsonProperty("singleDateFields")]
        public SingleDateField[] SingleDateFields { get; set; }

        [JsonProperty("multiDateFields")]
        public MultiDateField[] MultiDateFields { get; set; }

        [JsonProperty("singleListFields")]
        public SingleListField[] SingleListFields { get; set; }

        [JsonProperty("singleRelationshipFields")]
        public RelationshipField[] SingleRelationshipFields { get; set; }

        [JsonProperty("multiRelationshipFields")]
        public MultiRelationshipField[] MultiRelationshipFields { get; set; }

        [JsonProperty("singleRelationshipListFields")]
        public RelationshipListField[] SingleRelationshipListFields { get; set; }

        [JsonProperty("singleHyperlinkFields")]
        public SingleHyperlinkField[] SingleHyperlinkFields { get; set; }

        [JsonProperty("multiHyperlinkFields")]
        public MultiHyperlinkField[] MultiHyperlinkFields { get; set; }
    }

    public class SingleTextField
    {
        [JsonProperty("fieldsetId")]
        public string FieldsetId { get; set; }

        [JsonProperty("fieldId")]
        public string FieldId { get; set; }

        [JsonProperty("setOrder")]
        public int SetOrder { get; set; }

        [JsonProperty("order")]
        public int Order { get; set; }

        [JsonProperty("topicId")]
        public string TopicId { get; set; }

        [JsonProperty("setName")]
        public string SetName { get; set; }

        [JsonProperty("fieldName")]
        public string FieldName { get; set; }

        [JsonProperty("fieldValueType")]
        public FieldType FieldValueType { get; set; }

        [JsonProperty("required")]
        public bool Required { get; set; }

        [JsonProperty("readonly")]
        public bool Readonly { get; set; }

        [JsonProperty("usage")]
        public string Usage { get; set; }

        [JsonProperty("relationshipCategory")]
        public IRelationshipElement RelationshipCategory { get; set; }

        [JsonProperty("characteristic")]
        public IRelationshipElement Characteristic { get; set; }

        [JsonProperty("openLocation")]
        public string OpenLocation { get; set; }

        [JsonProperty("data")]
        public string Data { get; set; }
    }

    public class MultiTextField
    {
        [JsonProperty("fieldsetId")]
        public string FieldsetId { get; set; }

        [JsonProperty("fieldId")]
        public string FieldId { get; set; }

        [JsonProperty("setOrder")]
        public int SetOrder { get; set; }

        [JsonProperty("order")]
        public int Order { get; set; }

        [JsonProperty("topicId")]
        public string TopicId { get; set; }

        [JsonProperty("setName")]
        public string SetName { get; set; }

        [JsonProperty("fieldName")]
        public string FieldName { get; set; }

        [JsonProperty("fieldValueType")]
        public FieldType FieldValueType { get; set; }

        [JsonProperty("required")]
        public bool Required { get; set; }

        [JsonProperty("readonly")]
        public bool Readonly { get; set; }

        [JsonProperty("usage")]
        public string Usage { get; set; }

        [JsonProperty("relationshipCategory")]
        public IRelationshipElement RelationshipCategory { get; set; }

        [JsonProperty("characteristic")]
        public IRelationshipElement Characteristic { get; set; }

        [JsonProperty("openLocation")]
        public string OpenLocation { get; set; }

        [JsonProperty("data")]
        public string[] Data { get; set; }
    }

    public class SingleNumberField
    {
        [JsonProperty("fieldsetId")]
        public string FieldsetId { get; set; }

        [JsonProperty("fieldId")]
        public string FieldId { get; set; }

        [JsonProperty("setOrder")]
        public int SetOrder { get; set; }

        [JsonProperty("order")]
        public int Order { get; set; }

        [JsonProperty("topicId")]
        public string TopicId { get; set; }

        [JsonProperty("setName")]
        public string SetName { get; set; }

        [JsonProperty("fieldName")]
        public string FieldName { get; set; }

        [JsonProperty("fieldValueType")]
        public FieldType FieldValueType { get; set; }

        [JsonProperty("required")]
        public bool Required { get; set; }

        [JsonProperty("readonly")]
        public bool Readonly { get; set; }

        [JsonProperty("usage")]
        public string Usage { get; set; }

        [JsonProperty("relationshipCategory")]
        public IRelationshipElement RelationshipCategory { get; set; }

        [JsonProperty("characteristic")]
        public IRelationshipElement Characteristic { get; set; }

        [JsonProperty("openLocation")]
        public string OpenLocation { get; set; }

        [JsonProperty("data")]
        public int Data { get; set; }
    }

    public class MultiNumberField
    {
        [JsonProperty("fieldsetId")]
        public string FieldsetId { get; set; }

        [JsonProperty("fieldId")]
        public string FieldId { get; set; }

        [JsonProperty("setOrder")]
        public int SetOrder { get; set; }

        [JsonProperty("order")]
        public int Order { get; set; }

        [JsonProperty("topicId")]
        public string TopicId { get; set; }

        [JsonProperty("setName")]
        public string SetName { get; set; }

        [JsonProperty("fieldName")]
        public string FieldName { get; set; }

        [JsonProperty("fieldValueType")]
        public FieldType FieldValueType { get; set; }

        [JsonProperty("required")]
        public bool Required { get; set; }

        [JsonProperty("readonly")]
        public bool Readonly { get; set; }

        [JsonProperty("usage")]
        public string Usage { get; set; }

        [JsonProperty("relationshipCategory")]
        public IRelationshipElement RelationshipCategory { get; set; }

        [JsonProperty("characteristic")]
        public IRelationshipElement Characteristic { get; set; }

        [JsonProperty("openLocation")]
        public string OpenLocation { get; set; }

        [JsonProperty("data")]
        public int[] Data { get; set; }
    }

    public class SingleBooleanField
    {
        [JsonProperty("fieldsetId")]
        public string FieldsetId { get; set; }

        [JsonProperty("fieldId")]
        public string FieldId { get; set; }

        [JsonProperty("setOrder")]
        public int SetOrder { get; set; }

        [JsonProperty("order")]
        public int Order { get; set; }

        [JsonProperty("topicId")]
        public string TopicId { get; set; }

        [JsonProperty("setName")]
        public string SetName { get; set; }

        [JsonProperty("fieldName")]
        public string FieldName { get; set; }

        [JsonProperty("fieldValueType")]
        public FieldType FieldValueType { get; set; }

        [JsonProperty("required")]
        public bool Required { get; set; }

        [JsonProperty("readonly")]
        public bool Readonly { get; set; }

        [JsonProperty("usage")]
        public string Usage { get; set; }

        [JsonProperty("relationshipCategory")]
        public IRelationshipElement RelationshipCategory { get; set; }

        [JsonProperty("characteristic")]
        public IRelationshipElement Characteristic { get; set; }

        [JsonProperty("openLocation")]
        public string OpenLocation { get; set; }

        [JsonProperty("data")]
        public bool Data { get; set; }
    }

    public class SingleDecimalField
    {
        [JsonProperty("fieldsetId")]
        public string FieldsetId { get; set; }

        [JsonProperty("fieldId")]
        public string FieldId { get; set; }

        [JsonProperty("setOrder")]
        public int SetOrder { get; set; }

        [JsonProperty("order")]
        public int Order { get; set; }

        [JsonProperty("topicId")]
        public string TopicId { get; set; }

        [JsonProperty("setName")]
        public string SetName { get; set; }

        [JsonProperty("fieldName")]
        public string FieldName { get; set; }

        [JsonProperty("fieldValueType")]
        public FieldType FieldValueType { get; set; }

        [JsonProperty("required")]
        public bool Required { get; set; }

        [JsonProperty("readonly")]
        public bool Readonly { get; set; }

        [JsonProperty("usage")]
        public string Usage { get; set; }

        [JsonProperty("relationshipCategory")]
        public IRelationshipElement RelationshipCategory { get; set; }

        [JsonProperty("characteristic")]
        public IRelationshipElement Characteristic { get; set; }

        [JsonProperty("openLocation")]
        public string OpenLocation { get; set; }

        [JsonProperty("data")]
        public double Data { get; set; }
    }

    public class MultiDecimalField
    {
        [JsonProperty("fieldsetId")]
        public string FieldsetId { get; set; }

        [JsonProperty("fieldId")]
        public string FieldId { get; set; }

        [JsonProperty("setOrder")]
        public int SetOrder { get; set; }

        [JsonProperty("order")]
        public int Order { get; set; }

        [JsonProperty("topicId")]
        public string TopicId { get; set; }

        [JsonProperty("setName")]
        public string SetName { get; set; }

        [JsonProperty("fieldName")]
        public string FieldName { get; set; }

        [JsonProperty("fieldValueType")]
        public FieldType FieldValueType { get; set; }

        [JsonProperty("required")]
        public bool Required { get; set; }

        [JsonProperty("readonly")]
        public bool Readonly { get; set; }

        [JsonProperty("usage")]
        public string Usage { get; set; }

        [JsonProperty("relationshipCategory")]
        public IRelationshipElement RelationshipCategory { get; set; }

        [JsonProperty("characteristic")]
        public IRelationshipElement Characteristic { get; set; }

        [JsonProperty("openLocation")]
        public string OpenLocation { get; set; }

        [JsonProperty("data")]
        public double[] Data { get; set; }
    }

    public class SingleDateField
    {
        [JsonProperty("fieldsetId")]
        public string FieldsetId { get; set; }

        [JsonProperty("fieldId")]
        public string FieldId { get; set; }

        [JsonProperty("setOrder")]
        public int SetOrder { get; set; }

        [JsonProperty("order")]
        public int Order { get; set; }

        [JsonProperty("topicId")]
        public string TopicId { get; set; }

        [JsonProperty("setName")]
        public string SetName { get; set; }

        [JsonProperty("fieldName")]
        public string FieldName { get; set; }

        [JsonProperty("fieldValueType")]
        public FieldType FieldValueType { get; set; }

        [JsonProperty("required")]
        public bool Required { get; set; }

        [JsonProperty("readonly")]
        public bool Readonly { get; set; }

        [JsonProperty("usage")]
        public string Usage { get; set; }

        [JsonProperty("relationshipCategory")]
        public IRelationshipElement RelationshipCategory { get; set; }

        [JsonProperty("characteristic")]
        public IRelationshipElement Characteristic { get; set; }

        [JsonProperty("openLocation")]
        public string OpenLocation { get; set; }

        [JsonProperty("data")]
        public string Data { get; set; }
    }

    public class MultiDateField
    {
        [JsonProperty("fieldsetId")]
        public string FieldsetId { get; set; }

        [JsonProperty("fieldId")]
        public string FieldId { get; set; }

        [JsonProperty("setOrder")]
        public int SetOrder { get; set; }

        [JsonProperty("order")]
        public int Order { get; set; }

        [JsonProperty("topicId")]
        public string TopicId { get; set; }

        [JsonProperty("setName")]
        public string SetName { get; set; }

        [JsonProperty("fieldName")]
        public string FieldName { get; set; }

        [JsonProperty("fieldValueType")]
        public FieldType FieldValueType { get; set; }

        [JsonProperty("required")]
        public bool Required { get; set; }

        [JsonProperty("readonly")]
        public bool Readonly { get; set; }

        [JsonProperty("usage")]
        public string Usage { get; set; }

        [JsonProperty("relationshipCategory")]
        public IRelationshipElement RelationshipCategory { get; set; }

        [JsonProperty("characteristic")]
        public IRelationshipElement Characteristic { get; set; }

        [JsonProperty("openLocation")]
        public string OpenLocation { get; set; }

        [JsonProperty("data")]
        public string[] Data { get; set; }
    }

    public class SingleListField
    {
        [JsonProperty("fieldsetId")]
        public string FieldsetId { get; set; }

        [JsonProperty("fieldId")]
        public string FieldId { get; set; }

        [JsonProperty("setOrder")]
        public int SetOrder { get; set; }

        [JsonProperty("order")]
        public int Order { get; set; }

        [JsonProperty("topicId")]
        public string TopicId { get; set; }

        [JsonProperty("setName")]
        public string SetName { get; set; }

        [JsonProperty("fieldName")]
        public string FieldName { get; set; }

        [JsonProperty("fieldValueType")]
        public FieldType FieldValueType { get; set; }

        [JsonProperty("required")]
        public bool Required { get; set; }

        [JsonProperty("readonly")]
        public bool Readonly { get; set; }

        [JsonProperty("usage")]
        public string Usage { get; set; }

        [JsonProperty("relationshipCategory")]
        public IRelationshipElement RelationshipCategory { get; set; }

        [JsonProperty("characteristic")]
        public IRelationshipElement Characteristic { get; set; }

        [JsonProperty("openLocation")]
        public string OpenLocation { get; set; }

        [JsonProperty("data")]
        public JToken Data { get; set; }

        [JsonProperty("options")]
        public JToken Options { get; set; }
    }

    public class RelationshipField
    {
        [JsonProperty("fieldId")]
        public string FieldId { get; set; }

        [JsonProperty("fieldsetId")]
        public string FieldsetId { get; set; }

        [JsonProperty("data")]
        public RelationshipElement Data { get; set; }
    }

    public class MultiRelationshipField
    {
        [JsonProperty("fieldId")]
        public string FieldId { get; set; }

        [JsonProperty("fieldsetId")]
        public string FieldsetId { get; set; }

        [JsonProperty("data")]
        public RelationshipElement[] Data { get; set; }
    }

    public class RelationshipListField
    {
        [JsonProperty("fieldId")]
        public string FieldId { get; set; }

        [JsonProperty("fieldsetId")]
        public string FieldsetId { get; set; }

        [JsonProperty("data")]
        public JToken Data { get; set; }
    }

    public class SingleHyperlinkField
    {
        [JsonProperty("fieldsetId")]
        public string FieldsetId { get; set; }

        [JsonProperty("fieldId")]
        public string FieldId { get; set; }

        [JsonProperty("setOrder")]
        public int SetOrder { get; set; }

        [JsonProperty("order")]
        public int Order { get; set; }

        [JsonProperty("topicId")]
        public string TopicId { get; set; }

        [JsonProperty("setName")]
        public string SetName { get; set; }

        [JsonProperty("fieldName")]
        public string FieldName { get; set; }

        [JsonProperty("fieldValueType")]
        public FieldType FieldValueType { get; set; }

        [JsonProperty("required")]
        public bool Required { get; set; }

        [JsonProperty("readonly")]
        public bool Readonly { get; set; }

        [JsonProperty("usage")]
        public string Usage { get; set; }

        [JsonProperty("relationshipCategory")]
        public IRelationshipElement RelationshipCategory { get; set; }

        [JsonProperty("characteristic")]
        public IRelationshipElement Characteristic { get; set; }

        [JsonProperty("openLocation")]
        public string OpenLocation { get; set; }

        [JsonProperty("data")]
        public string Data { get; set; }
    }

    public class MultiHyperlinkField
    {
        [JsonProperty("fieldsetId")]
        public string FieldsetId { get; set; }

        [JsonProperty("fieldId")]
        public string FieldId { get; set; }

        [JsonProperty("setOrder")]
        public int SetOrder { get; set; }

        [JsonProperty("order")]
        public int Order { get; set; }

        [JsonProperty("topicId")]
        public string TopicId { get; set; }

        [JsonProperty("setName")]
        public string SetName { get; set; }

        [JsonProperty("fieldName")]
        public string FieldName { get; set; }

        [JsonProperty("fieldValueType")]
        public FieldType FieldValueType { get; set; }

        [JsonProperty("required")]
        public bool Required { get; set; }

        [JsonProperty("readonly")]
        public bool Readonly { get; set; }

        [JsonProperty("usage")]
        public string Usage { get; set; }

        [JsonProperty("relationshipCategory")]
        public IRelationshipElement RelationshipCategory { get; set; }

        [JsonProperty("characteristic")]
        public IRelationshipElement Characteristic { get; set; }

        [JsonProperty("openLocation")]
        public string OpenLocation { get; set; }

        [JsonProperty("data")]
        public string[] Data { get; set; }
    }

    public class UpdateSingleHyperlinkFieldInput
    {
        [JsonProperty("data")]
        public string Data { get; set; }
    }

    public class UpdateMultiHyperlinkFieldInput
    {
        [JsonProperty("data")]
        public string[] Data { get; set; }
    }

    public class IRelationship
    {
        [JsonProperty("dcv")]
        public string Dcv { get; set; }

        [JsonProperty("isTypeOfTopic")]
        public bool IsTypeOfTopic { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("categoryType")]
        public CategoryType CategoryType { get; set; }

        [JsonProperty("relationshipType")]
        public RelationshipType RelationshipType { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("userInstruction")]
        public IRelationshipElement UserInstruction { get; set; }

        [JsonProperty("dispatchInstructions")]
        public ISimpleDispatchInstruction[] DispatchInstructions { get; set; }

        [JsonProperty("characteristic")]
        public IRelationshipElement Characteristic { get; set; }

        [JsonProperty("withElement")]
        public IRelationshipElement WithElement { get; set; }

        [JsonProperty("withElementParent")]
        public IRelationshipElement WithElementParent { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CategoryType
    {
        Unknown,
        With,
        Goto,
        From,
        Who,
        When,
        Where,
        Why,
        HypTo,
        HypFrom,
        Chart,
        Matrix,
        Report
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum RelationshipType
    {
        Unknown,
        WithWhat,
        Who,
        When,
        Where,
        Why,
        WhereTo
    }

    public class ISimpleDispatchInstruction
    {
        [JsonProperty("typeName")]
        public string TypeName { get; set; }

        [JsonProperty("dcv")]
        public string Dcv { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }
    }

    public class SaveRelationInput
    {
        [JsonProperty("fromElementDcv")]
        public string FromElementDcv { get; set; }

        [JsonProperty("toElementDcv")]
        public string ToElementDcv { get; set; }

        [JsonProperty("relationshipType")]
        public RelationshipType? RelationshipType { get; set; }
    }

    public class ITopicPath
    {
        [JsonProperty("path")]
        public IPathItem[] Path { get; set; }

        [JsonProperty("data")]
        public ITopic[] Data { get; set; }
    }

    public class IPathItem
    {
        [JsonProperty("order")]
        public int Order { get; set; }

        [JsonProperty("dcvId")]
        public string DcvId { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Mavimimprove;

    public partial class WorkflowManagedActions
    {
        public MavimimproveActions Mavimimprove(string connectionId) => new MavimimproveActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public MavimimproveTriggers Mavimimprove(string connectionId) => new MavimimproveTriggers(connectionId);
    }
}