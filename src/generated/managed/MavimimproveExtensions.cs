//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Mavimimprove
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class MavimimproveActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        [WorkflowExpressionFactory(nameof(__BuildGetTopicCharts))]
        public IBodyWorkflowAction<IChart[]> GetTopicCharts([WorkflowExpression] Func<string> dbId, [WorkflowExpression] Func<dataLanguageInput> dataLanguage, [WorkflowExpression] Func<string> topicId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<IChart[]> __BuildGetTopicCharts(WorkflowExpression<string> dbId, WorkflowExpression<dataLanguageInput> dataLanguage, WorkflowExpression<string> topicId)
        {
            WorkflowExpression.Validate(dbId, nameof(dbId), required: true);
            WorkflowExpression.Validate(dataLanguage, nameof(dataLanguage), required: true);
            WorkflowExpression.Validate(topicId, nameof(topicId), required: true);
            return new DeferredBodyAction<IChart[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/{0}/{1}/topic/{2}/charts", ExpressionConverter.ConvertWithUrlEncoding(dbId, 1), ExpressionConverter.ConvertWithUrlEncoding(dataLanguage, 1), ExpressionConverter.ConvertWithUrlEncoding(topicId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<IChart[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        [WorkflowExpressionFactory(nameof(__BuildCreateTopicAfter))]
        public IBodyWorkflowAction<ITopic> CreateTopicAfter([WorkflowExpression] Func<string> dbId, [WorkflowExpression] Func<dataLanguageInput> dataLanguage, [WorkflowExpression] Func<string> topicId, [WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<string> bodytype, [WorkflowExpression] Func<string> bodyicon)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ITopic> __BuildCreateTopicAfter(WorkflowExpression<string> dbId, WorkflowExpression<dataLanguageInput> dataLanguage, WorkflowExpression<string> topicId, WorkflowExpression<string> bodyname, WorkflowExpression<string> bodytype, WorkflowExpression<string> bodyicon)
        {
            WorkflowExpression.Validate(dbId, nameof(dbId), required: true);
            WorkflowExpression.Validate(dataLanguage, nameof(dataLanguage), required: true);
            WorkflowExpression.Validate(topicId, nameof(topicId), required: true);
            WorkflowExpression.Validate(bodyname, nameof(bodyname), required: true);
            WorkflowExpression.Validate(bodytype, nameof(bodytype), required: true);
            WorkflowExpression.Validate(bodyicon, nameof(bodyicon), required: true);
            return new DeferredBodyAction<ITopic>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/{0}/{1}/topic/{2}", ExpressionConverter.ConvertWithUrlEncoding(dbId, 1), ExpressionConverter.ConvertWithUrlEncoding(dataLanguage, 1), ExpressionConverter.ConvertWithUrlEncoding(topicId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
                body["type"] = ExpressionConverter.ConvertO(bodytype);
                bodypropCount++;
                body["icon"] = ExpressionConverter.ConvertO(bodyicon);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ITopic>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteTopic))]
        public IBodyWorkflowAction<ITopic> DeleteTopic([WorkflowExpression] Func<string> dbId, [WorkflowExpression] Func<dataLanguageInput> dataLanguage, [WorkflowExpression] Func<string> topicId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ITopic> __BuildDeleteTopic(WorkflowExpression<string> dbId, WorkflowExpression<dataLanguageInput> dataLanguage, WorkflowExpression<string> topicId)
        {
            WorkflowExpression.Validate(dbId, nameof(dbId), required: true);
            WorkflowExpression.Validate(dataLanguage, nameof(dataLanguage), required: true);
            WorkflowExpression.Validate(topicId, nameof(topicId), required: true);
            return new DeferredBodyAction<ITopic>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/{0}/{1}/topic/{2}", ExpressionConverter.ConvertWithUrlEncoding(dbId, 1), ExpressionConverter.ConvertWithUrlEncoding(dataLanguage, 1), ExpressionConverter.ConvertWithUrlEncoding(topicId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ITopic>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        [WorkflowExpressionFactory(nameof(__BuildGetTopic))]
        public IBodyWorkflowAction<ITopic> GetTopic([WorkflowExpression] Func<string> dbId, [WorkflowExpression] Func<dataLanguageInput> dataLanguage, [WorkflowExpression] Func<string> topicId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ITopic> __BuildGetTopic(WorkflowExpression<string> dbId, WorkflowExpression<dataLanguageInput> dataLanguage, WorkflowExpression<string> topicId)
        {
            WorkflowExpression.Validate(dbId, nameof(dbId), required: true);
            WorkflowExpression.Validate(dataLanguage, nameof(dataLanguage), required: true);
            WorkflowExpression.Validate(topicId, nameof(topicId), required: true);
            return new DeferredBodyAction<ITopic>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/{0}/{1}/topic/{2}", ExpressionConverter.ConvertWithUrlEncoding(dbId, 1), ExpressionConverter.ConvertWithUrlEncoding(dataLanguage, 1), ExpressionConverter.ConvertWithUrlEncoding(topicId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ITopic>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateTopic))]
        public IBodyWorkflowAction<ITopic> UpdateTopic([WorkflowExpression] Func<string> dbId, [WorkflowExpression] Func<dataLanguageInput> dataLanguage, [WorkflowExpression] Func<string> topicId, [WorkflowExpression] Func<string> bodyname = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ITopic> __BuildUpdateTopic(WorkflowExpression<string> dbId, WorkflowExpression<dataLanguageInput> dataLanguage, WorkflowExpression<string> topicId, WorkflowExpression<string> bodyname = null)
        {
            WorkflowExpression.Validate(dbId, nameof(dbId), required: true);
            WorkflowExpression.Validate(dataLanguage, nameof(dataLanguage), required: true);
            WorkflowExpression.Validate(topicId, nameof(topicId), required: true);
            WorkflowExpression.Validate(bodyname, nameof(bodyname), required: false);
            return new DeferredBodyAction<ITopic>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/{0}/{1}/topic/{2}", ExpressionConverter.ConvertWithUrlEncoding(dbId, 1), ExpressionConverter.ConvertWithUrlEncoding(dataLanguage, 1), ExpressionConverter.ConvertWithUrlEncoding(topicId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(bodyname);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ITopic>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        [WorkflowExpressionFactory(nameof(__BuildCreateChildTopic))]
        public IBodyWorkflowAction<ITopic> CreateChildTopic([WorkflowExpression] Func<string> dbId, [WorkflowExpression] Func<dataLanguageInput> dataLanguage, [WorkflowExpression] Func<string> topicId, [WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<string> bodytype, [WorkflowExpression] Func<string> bodyicon)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ITopic> __BuildCreateChildTopic(WorkflowExpression<string> dbId, WorkflowExpression<dataLanguageInput> dataLanguage, WorkflowExpression<string> topicId, WorkflowExpression<string> bodyname, WorkflowExpression<string> bodytype, WorkflowExpression<string> bodyicon)
        {
            WorkflowExpression.Validate(dbId, nameof(dbId), required: true);
            WorkflowExpression.Validate(dataLanguage, nameof(dataLanguage), required: true);
            WorkflowExpression.Validate(topicId, nameof(topicId), required: true);
            WorkflowExpression.Validate(bodyname, nameof(bodyname), required: true);
            WorkflowExpression.Validate(bodytype, nameof(bodytype), required: true);
            WorkflowExpression.Validate(bodyicon, nameof(bodyicon), required: true);
            return new DeferredBodyAction<ITopic>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/{0}/{1}/topic/{2}/children", ExpressionConverter.ConvertWithUrlEncoding(dbId, 1), ExpressionConverter.ConvertWithUrlEncoding(dataLanguage, 1), ExpressionConverter.ConvertWithUrlEncoding(topicId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
                body["type"] = ExpressionConverter.ConvertO(bodytype);
                bodypropCount++;
                body["icon"] = ExpressionConverter.ConvertO(bodyicon);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ITopic>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        [WorkflowExpressionFactory(nameof(__BuildGetTopicChildren))]
        public IBodyWorkflowAction<ITopic[]> GetTopicChildren([WorkflowExpression] Func<string> dbId, [WorkflowExpression] Func<dataLanguageInput> dataLanguage, [WorkflowExpression] Func<string> topicId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ITopic[]> __BuildGetTopicChildren(WorkflowExpression<string> dbId, WorkflowExpression<dataLanguageInput> dataLanguage, WorkflowExpression<string> topicId)
        {
            WorkflowExpression.Validate(dbId, nameof(dbId), required: true);
            WorkflowExpression.Validate(dataLanguage, nameof(dataLanguage), required: true);
            WorkflowExpression.Validate(topicId, nameof(topicId), required: true);
            return new DeferredBodyAction<ITopic[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/{0}/{1}/topic/{2}/children", ExpressionConverter.ConvertWithUrlEncoding(dbId, 1), ExpressionConverter.ConvertWithUrlEncoding(dataLanguage, 1), ExpressionConverter.ConvertWithUrlEncoding(topicId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ITopic[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        [WorkflowExpressionFactory(nameof(__BuildGetTopicFields))]
        public IBodyWorkflowAction<IField[]> GetTopicFields([WorkflowExpression] Func<string> dbId, [WorkflowExpression] Func<dataLanguageInput> dataLanguage, [WorkflowExpression] Func<string> topicId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<IField[]> __BuildGetTopicFields(WorkflowExpression<string> dbId, WorkflowExpression<dataLanguageInput> dataLanguage, WorkflowExpression<string> topicId)
        {
            WorkflowExpression.Validate(dbId, nameof(dbId), required: true);
            WorkflowExpression.Validate(dataLanguage, nameof(dataLanguage), required: true);
            WorkflowExpression.Validate(topicId, nameof(topicId), required: true);
            return new DeferredBodyAction<IField[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/{0}/{1}/topic/{2}/fieldsets", ExpressionConverter.ConvertWithUrlEncoding(dbId, 1), ExpressionConverter.ConvertWithUrlEncoding(dataLanguage, 1), ExpressionConverter.ConvertWithUrlEncoding(topicId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<IField[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        [WorkflowExpressionFactory(nameof(__BuildGetFieldByDcvAndFieldsetId))]
        public IBodyWorkflowAction<IField> GetFieldByDcvAndFieldsetId([WorkflowExpression] Func<string> dbId, [WorkflowExpression] Func<dataLanguageInput> dataLanguage, [WorkflowExpression] Func<string> topicId, [WorkflowExpression] Func<string> fieldsetId, [WorkflowExpression] Func<string> fieldId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<IField> __BuildGetFieldByDcvAndFieldsetId(WorkflowExpression<string> dbId, WorkflowExpression<dataLanguageInput> dataLanguage, WorkflowExpression<string> topicId, WorkflowExpression<string> fieldsetId, WorkflowExpression<string> fieldId)
        {
            WorkflowExpression.Validate(dbId, nameof(dbId), required: true);
            WorkflowExpression.Validate(dataLanguage, nameof(dataLanguage), required: true);
            WorkflowExpression.Validate(topicId, nameof(topicId), required: true);
            WorkflowExpression.Validate(fieldsetId, nameof(fieldsetId), required: true);
            WorkflowExpression.Validate(fieldId, nameof(fieldId), required: true);
            return new DeferredBodyAction<IField>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/{0}/{1}/topic/{2}/fieldsets/{3}/{4}", ExpressionConverter.ConvertWithUrlEncoding(dbId, 1), ExpressionConverter.ConvertWithUrlEncoding(dataLanguage, 1), ExpressionConverter.ConvertWithUrlEncoding(topicId, 1), ExpressionConverter.ConvertWithUrlEncoding(fieldsetId, 1), ExpressionConverter.ConvertWithUrlEncoding(fieldId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<IField>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateBooleanSingleField))]
        public IBodyWorkflowAction<IField> UpdateBooleanSingleField([WorkflowExpression] Func<string> dbId, [WorkflowExpression] Func<dataLanguageInput> dataLanguage, [WorkflowExpression] Func<string> topicId, [WorkflowExpression] Func<string> fieldsetId, [WorkflowExpression] Func<string> fieldId, [WorkflowExpression] Func<string> bodyfieldsetId = null, [WorkflowExpression] Func<string> bodyfieldId = null, [WorkflowExpression] Func<int> bodysetOrder = null, [WorkflowExpression] Func<int> bodyorder = null, [WorkflowExpression] Func<string> bodytopicId = null, [WorkflowExpression] Func<string> bodysetName = null, [WorkflowExpression] Func<string> bodyfieldName = null, [WorkflowExpression] Func<bodyfieldValueTypeInput> bodyfieldValueType = null, [WorkflowExpression] Func<bool> bodyrequired = null, [WorkflowExpression] Func<bool> bodyreadonly = null, [WorkflowExpression] Func<string> bodyusage = null, [WorkflowExpression] Func<string> bodyrelationshipCategorydcv = null, [WorkflowExpression] Func<string> bodyrelationshipCategoryname = null, [WorkflowExpression] Func<string> bodyrelationshipCategoryicon = null, [WorkflowExpression] Func<string> bodycharacteristicdcv = null, [WorkflowExpression] Func<string> bodycharacteristicname = null, [WorkflowExpression] Func<string> bodycharacteristicicon = null, [WorkflowExpression] Func<string> bodyopenLocation = null, [WorkflowExpression] Func<bool> bodydata = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<IField> __BuildUpdateBooleanSingleField(WorkflowExpression<string> dbId, WorkflowExpression<dataLanguageInput> dataLanguage, WorkflowExpression<string> topicId, WorkflowExpression<string> fieldsetId, WorkflowExpression<string> fieldId, WorkflowExpression<string> bodyfieldsetId = null, WorkflowExpression<string> bodyfieldId = null, WorkflowExpression<int> bodysetOrder = null, WorkflowExpression<int> bodyorder = null, WorkflowExpression<string> bodytopicId = null, WorkflowExpression<string> bodysetName = null, WorkflowExpression<string> bodyfieldName = null, WorkflowExpression<bodyfieldValueTypeInput> bodyfieldValueType = null, WorkflowExpression<bool> bodyrequired = null, WorkflowExpression<bool> bodyreadonly = null, WorkflowExpression<string> bodyusage = null, WorkflowExpression<string> bodyrelationshipCategorydcv = null, WorkflowExpression<string> bodyrelationshipCategoryname = null, WorkflowExpression<string> bodyrelationshipCategoryicon = null, WorkflowExpression<string> bodycharacteristicdcv = null, WorkflowExpression<string> bodycharacteristicname = null, WorkflowExpression<string> bodycharacteristicicon = null, WorkflowExpression<string> bodyopenLocation = null, WorkflowExpression<bool> bodydata = null)
        {
            WorkflowExpression.Validate(dbId, nameof(dbId), required: true);
            WorkflowExpression.Validate(dataLanguage, nameof(dataLanguage), required: true);
            WorkflowExpression.Validate(topicId, nameof(topicId), required: true);
            WorkflowExpression.Validate(fieldsetId, nameof(fieldsetId), required: true);
            WorkflowExpression.Validate(fieldId, nameof(fieldId), required: true);
            WorkflowExpression.Validate(bodyfieldsetId, nameof(bodyfieldsetId), required: false);
            WorkflowExpression.Validate(bodyfieldId, nameof(bodyfieldId), required: false);
            WorkflowExpression.Validate(bodysetOrder, nameof(bodysetOrder), required: false);
            WorkflowExpression.Validate(bodyorder, nameof(bodyorder), required: false);
            WorkflowExpression.Validate(bodytopicId, nameof(bodytopicId), required: false);
            WorkflowExpression.Validate(bodysetName, nameof(bodysetName), required: false);
            WorkflowExpression.Validate(bodyfieldName, nameof(bodyfieldName), required: false);
            WorkflowExpression.Validate(bodyfieldValueType, nameof(bodyfieldValueType), required: false);
            WorkflowExpression.Validate(bodyrequired, nameof(bodyrequired), required: false);
            WorkflowExpression.Validate(bodyreadonly, nameof(bodyreadonly), required: false);
            WorkflowExpression.Validate(bodyusage, nameof(bodyusage), required: false);
            WorkflowExpression.Validate(bodyrelationshipCategorydcv, nameof(bodyrelationshipCategorydcv), required: false);
            WorkflowExpression.Validate(bodyrelationshipCategoryname, nameof(bodyrelationshipCategoryname), required: false);
            WorkflowExpression.Validate(bodyrelationshipCategoryicon, nameof(bodyrelationshipCategoryicon), required: false);
            WorkflowExpression.Validate(bodycharacteristicdcv, nameof(bodycharacteristicdcv), required: false);
            WorkflowExpression.Validate(bodycharacteristicname, nameof(bodycharacteristicname), required: false);
            WorkflowExpression.Validate(bodycharacteristicicon, nameof(bodycharacteristicicon), required: false);
            WorkflowExpression.Validate(bodyopenLocation, nameof(bodyopenLocation), required: false);
            WorkflowExpression.Validate(bodydata, nameof(bodydata), required: false);
            return new DeferredBodyAction<IField>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/{0}/{1}/topic/{2}/fieldsets/{3}/bool/{4}", ExpressionConverter.ConvertWithUrlEncoding(dbId, 1), ExpressionConverter.ConvertWithUrlEncoding(dataLanguage, 1), ExpressionConverter.ConvertWithUrlEncoding(topicId, 1), ExpressionConverter.ConvertWithUrlEncoding(fieldsetId, 1), ExpressionConverter.ConvertWithUrlEncoding(fieldId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfieldsetId != null)
                {
                    body["fieldsetId"] = ExpressionConverter.ConvertO(bodyfieldsetId);
                    bodypropCount++;
                }

                if (bodyfieldId != null)
                {
                    body["fieldId"] = ExpressionConverter.ConvertO(bodyfieldId);
                    bodypropCount++;
                }

                if (bodysetOrder != null)
                {
                    body["setOrder"] = ExpressionConverter.ConvertO(bodysetOrder);
                    bodypropCount++;
                }

                if (bodyorder != null)
                {
                    body["order"] = ExpressionConverter.ConvertO(bodyorder);
                    bodypropCount++;
                }

                if (bodytopicId != null)
                {
                    body["topicId"] = ExpressionConverter.ConvertO(bodytopicId);
                    bodypropCount++;
                }

                if (bodysetName != null)
                {
                    body["setName"] = ExpressionConverter.ConvertO(bodysetName);
                    bodypropCount++;
                }

                if (bodyfieldName != null)
                {
                    body["fieldName"] = ExpressionConverter.ConvertO(bodyfieldName);
                    bodypropCount++;
                }

                if (bodyfieldValueType != null)
                {
                    body["fieldValueType"] = ExpressionConverter.ConvertO(bodyfieldValueType);
                    bodypropCount++;
                }

                if (bodyrequired != null)
                {
                    body["required"] = ExpressionConverter.ConvertO(bodyrequired);
                    bodypropCount++;
                }

                if (bodyreadonly != null)
                {
                    body["readonly"] = ExpressionConverter.ConvertO(bodyreadonly);
                    bodypropCount++;
                }

                if (bodyusage != null)
                {
                    body["usage"] = ExpressionConverter.ConvertO(bodyusage);
                    bodypropCount++;
                }

                var relationshipCategoryObject = new JObject();
                var relationshipCategoryObjectpropCount = 0;
                if (bodyrelationshipCategorydcv != null)
                {
                    relationshipCategoryObject["dcv"] = ExpressionConverter.ConvertO(bodyrelationshipCategorydcv);
                    relationshipCategoryObjectpropCount++;
                }

                if (bodyrelationshipCategoryname != null)
                {
                    relationshipCategoryObject["name"] = ExpressionConverter.ConvertO(bodyrelationshipCategoryname);
                    relationshipCategoryObjectpropCount++;
                }

                if (bodyrelationshipCategoryicon != null)
                {
                    relationshipCategoryObject["icon"] = ExpressionConverter.ConvertO(bodyrelationshipCategoryicon);
                    relationshipCategoryObjectpropCount++;
                }

                if (relationshipCategoryObjectpropCount > 0)
                {
                    body["relationshipCategory"] = relationshipCategoryObject;
                    bodypropCount++;
                }

                var characteristicObject = new JObject();
                var characteristicObjectpropCount = 0;
                if (bodyrelationshipCategorydcv != null)
                {
                    characteristicObject["dcv"] = ExpressionConverter.ConvertO(bodyrelationshipCategorydcv);
                    characteristicObjectpropCount++;
                }

                if (bodyrelationshipCategoryname != null)
                {
                    characteristicObject["name"] = ExpressionConverter.ConvertO(bodyrelationshipCategoryname);
                    characteristicObjectpropCount++;
                }

                if (bodyrelationshipCategoryicon != null)
                {
                    characteristicObject["icon"] = ExpressionConverter.ConvertO(bodyrelationshipCategoryicon);
                    characteristicObjectpropCount++;
                }

                if (characteristicObjectpropCount > 0)
                {
                    body["characteristic"] = characteristicObject;
                    bodypropCount++;
                }

                if (bodyopenLocation != null)
                {
                    body["openLocation"] = ExpressionConverter.ConvertO(bodyopenLocation);
                    bodypropCount++;
                }

                if (bodydata != null)
                {
                    body["data"] = ExpressionConverter.ConvertO(bodydata);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<IField>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateTextSingleField))]
        public IBodyWorkflowAction<IField> UpdateTextSingleField([WorkflowExpression] Func<string> dbId, [WorkflowExpression] Func<dataLanguageInput> dataLanguage, [WorkflowExpression] Func<string> topicId, [WorkflowExpression] Func<string> fieldsetId, [WorkflowExpression] Func<string> fieldId, [WorkflowExpression] Func<string> bodyfieldsetId = null, [WorkflowExpression] Func<string> bodyfieldId = null, [WorkflowExpression] Func<int> bodysetOrder = null, [WorkflowExpression] Func<int> bodyorder = null, [WorkflowExpression] Func<string> bodytopicId = null, [WorkflowExpression] Func<string> bodysetName = null, [WorkflowExpression] Func<string> bodyfieldName = null, [WorkflowExpression] Func<bodyfieldValueTypeInput> bodyfieldValueType = null, [WorkflowExpression] Func<bool> bodyrequired = null, [WorkflowExpression] Func<bool> bodyreadonly = null, [WorkflowExpression] Func<string> bodyusage = null, [WorkflowExpression] Func<string> bodyrelationshipCategorydcv = null, [WorkflowExpression] Func<string> bodyrelationshipCategoryname = null, [WorkflowExpression] Func<string> bodyrelationshipCategoryicon = null, [WorkflowExpression] Func<string> bodycharacteristicdcv = null, [WorkflowExpression] Func<string> bodycharacteristicname = null, [WorkflowExpression] Func<string> bodycharacteristicicon = null, [WorkflowExpression] Func<string> bodyopenLocation = null, [WorkflowExpression] Func<string> bodydata = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<IField> __BuildUpdateTextSingleField(WorkflowExpression<string> dbId, WorkflowExpression<dataLanguageInput> dataLanguage, WorkflowExpression<string> topicId, WorkflowExpression<string> fieldsetId, WorkflowExpression<string> fieldId, WorkflowExpression<string> bodyfieldsetId = null, WorkflowExpression<string> bodyfieldId = null, WorkflowExpression<int> bodysetOrder = null, WorkflowExpression<int> bodyorder = null, WorkflowExpression<string> bodytopicId = null, WorkflowExpression<string> bodysetName = null, WorkflowExpression<string> bodyfieldName = null, WorkflowExpression<bodyfieldValueTypeInput> bodyfieldValueType = null, WorkflowExpression<bool> bodyrequired = null, WorkflowExpression<bool> bodyreadonly = null, WorkflowExpression<string> bodyusage = null, WorkflowExpression<string> bodyrelationshipCategorydcv = null, WorkflowExpression<string> bodyrelationshipCategoryname = null, WorkflowExpression<string> bodyrelationshipCategoryicon = null, WorkflowExpression<string> bodycharacteristicdcv = null, WorkflowExpression<string> bodycharacteristicname = null, WorkflowExpression<string> bodycharacteristicicon = null, WorkflowExpression<string> bodyopenLocation = null, WorkflowExpression<string> bodydata = null)
        {
            WorkflowExpression.Validate(dbId, nameof(dbId), required: true);
            WorkflowExpression.Validate(dataLanguage, nameof(dataLanguage), required: true);
            WorkflowExpression.Validate(topicId, nameof(topicId), required: true);
            WorkflowExpression.Validate(fieldsetId, nameof(fieldsetId), required: true);
            WorkflowExpression.Validate(fieldId, nameof(fieldId), required: true);
            WorkflowExpression.Validate(bodyfieldsetId, nameof(bodyfieldsetId), required: false);
            WorkflowExpression.Validate(bodyfieldId, nameof(bodyfieldId), required: false);
            WorkflowExpression.Validate(bodysetOrder, nameof(bodysetOrder), required: false);
            WorkflowExpression.Validate(bodyorder, nameof(bodyorder), required: false);
            WorkflowExpression.Validate(bodytopicId, nameof(bodytopicId), required: false);
            WorkflowExpression.Validate(bodysetName, nameof(bodysetName), required: false);
            WorkflowExpression.Validate(bodyfieldName, nameof(bodyfieldName), required: false);
            WorkflowExpression.Validate(bodyfieldValueType, nameof(bodyfieldValueType), required: false);
            WorkflowExpression.Validate(bodyrequired, nameof(bodyrequired), required: false);
            WorkflowExpression.Validate(bodyreadonly, nameof(bodyreadonly), required: false);
            WorkflowExpression.Validate(bodyusage, nameof(bodyusage), required: false);
            WorkflowExpression.Validate(bodyrelationshipCategorydcv, nameof(bodyrelationshipCategorydcv), required: false);
            WorkflowExpression.Validate(bodyrelationshipCategoryname, nameof(bodyrelationshipCategoryname), required: false);
            WorkflowExpression.Validate(bodyrelationshipCategoryicon, nameof(bodyrelationshipCategoryicon), required: false);
            WorkflowExpression.Validate(bodycharacteristicdcv, nameof(bodycharacteristicdcv), required: false);
            WorkflowExpression.Validate(bodycharacteristicname, nameof(bodycharacteristicname), required: false);
            WorkflowExpression.Validate(bodycharacteristicicon, nameof(bodycharacteristicicon), required: false);
            WorkflowExpression.Validate(bodyopenLocation, nameof(bodyopenLocation), required: false);
            WorkflowExpression.Validate(bodydata, nameof(bodydata), required: false);
            return new DeferredBodyAction<IField>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/{0}/{1}/topic/{2}/fieldsets/{3}/text/{4}", ExpressionConverter.ConvertWithUrlEncoding(dbId, 1), ExpressionConverter.ConvertWithUrlEncoding(dataLanguage, 1), ExpressionConverter.ConvertWithUrlEncoding(topicId, 1), ExpressionConverter.ConvertWithUrlEncoding(fieldsetId, 1), ExpressionConverter.ConvertWithUrlEncoding(fieldId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfieldsetId != null)
                {
                    body["fieldsetId"] = ExpressionConverter.ConvertO(bodyfieldsetId);
                    bodypropCount++;
                }

                if (bodyfieldId != null)
                {
                    body["fieldId"] = ExpressionConverter.ConvertO(bodyfieldId);
                    bodypropCount++;
                }

                if (bodysetOrder != null)
                {
                    body["setOrder"] = ExpressionConverter.ConvertO(bodysetOrder);
                    bodypropCount++;
                }

                if (bodyorder != null)
                {
                    body["order"] = ExpressionConverter.ConvertO(bodyorder);
                    bodypropCount++;
                }

                if (bodytopicId != null)
                {
                    body["topicId"] = ExpressionConverter.ConvertO(bodytopicId);
                    bodypropCount++;
                }

                if (bodysetName != null)
                {
                    body["setName"] = ExpressionConverter.ConvertO(bodysetName);
                    bodypropCount++;
                }

                if (bodyfieldName != null)
                {
                    body["fieldName"] = ExpressionConverter.ConvertO(bodyfieldName);
                    bodypropCount++;
                }

                if (bodyfieldValueType != null)
                {
                    body["fieldValueType"] = ExpressionConverter.ConvertO(bodyfieldValueType);
                    bodypropCount++;
                }

                if (bodyrequired != null)
                {
                    body["required"] = ExpressionConverter.ConvertO(bodyrequired);
                    bodypropCount++;
                }

                if (bodyreadonly != null)
                {
                    body["readonly"] = ExpressionConverter.ConvertO(bodyreadonly);
                    bodypropCount++;
                }

                if (bodyusage != null)
                {
                    body["usage"] = ExpressionConverter.ConvertO(bodyusage);
                    bodypropCount++;
                }

                var relationshipCategoryObject = new JObject();
                var relationshipCategoryObjectpropCount = 0;
                if (bodyrelationshipCategorydcv != null)
                {
                    relationshipCategoryObject["dcv"] = ExpressionConverter.ConvertO(bodyrelationshipCategorydcv);
                    relationshipCategoryObjectpropCount++;
                }

                if (bodyrelationshipCategoryname != null)
                {
                    relationshipCategoryObject["name"] = ExpressionConverter.ConvertO(bodyrelationshipCategoryname);
                    relationshipCategoryObjectpropCount++;
                }

                if (bodyrelationshipCategoryicon != null)
                {
                    relationshipCategoryObject["icon"] = ExpressionConverter.ConvertO(bodyrelationshipCategoryicon);
                    relationshipCategoryObjectpropCount++;
                }

                if (relationshipCategoryObjectpropCount > 0)
                {
                    body["relationshipCategory"] = relationshipCategoryObject;
                    bodypropCount++;
                }

                var characteristicObject = new JObject();
                var characteristicObjectpropCount = 0;
                if (bodyrelationshipCategorydcv != null)
                {
                    characteristicObject["dcv"] = ExpressionConverter.ConvertO(bodyrelationshipCategorydcv);
                    characteristicObjectpropCount++;
                }

                if (bodyrelationshipCategoryname != null)
                {
                    characteristicObject["name"] = ExpressionConverter.ConvertO(bodyrelationshipCategoryname);
                    characteristicObjectpropCount++;
                }

                if (bodyrelationshipCategoryicon != null)
                {
                    characteristicObject["icon"] = ExpressionConverter.ConvertO(bodyrelationshipCategoryicon);
                    characteristicObjectpropCount++;
                }

                if (characteristicObjectpropCount > 0)
                {
                    body["characteristic"] = characteristicObject;
                    bodypropCount++;
                }

                if (bodyopenLocation != null)
                {
                    body["openLocation"] = ExpressionConverter.ConvertO(bodyopenLocation);
                    bodypropCount++;
                }

                if (bodydata != null)
                {
                    body["data"] = ExpressionConverter.ConvertO(bodydata);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<IField>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateTextMultiField))]
        public IBodyWorkflowAction<IField> UpdateTextMultiField([WorkflowExpression] Func<string> dbId, [WorkflowExpression] Func<dataLanguageInput> dataLanguage, [WorkflowExpression] Func<string> topicId, [WorkflowExpression] Func<string> fieldsetId, [WorkflowExpression] Func<string> fieldId, [WorkflowExpression] Func<string> bodyfieldsetId = null, [WorkflowExpression] Func<string> bodyfieldId = null, [WorkflowExpression] Func<int> bodysetOrder = null, [WorkflowExpression] Func<int> bodyorder = null, [WorkflowExpression] Func<string> bodytopicId = null, [WorkflowExpression] Func<string> bodysetName = null, [WorkflowExpression] Func<string> bodyfieldName = null, [WorkflowExpression] Func<bodyfieldValueTypeInput> bodyfieldValueType = null, [WorkflowExpression] Func<bool> bodyrequired = null, [WorkflowExpression] Func<bool> bodyreadonly = null, [WorkflowExpression] Func<string> bodyusage = null, [WorkflowExpression] Func<string> bodyrelationshipCategorydcv = null, [WorkflowExpression] Func<string> bodyrelationshipCategoryname = null, [WorkflowExpression] Func<string> bodyrelationshipCategoryicon = null, [WorkflowExpression] Func<string> bodycharacteristicdcv = null, [WorkflowExpression] Func<string> bodycharacteristicname = null, [WorkflowExpression] Func<string> bodycharacteristicicon = null, [WorkflowExpression] Func<string> bodyopenLocation = null, [WorkflowExpression] Func<string[]> bodydata = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<IField> __BuildUpdateTextMultiField(WorkflowExpression<string> dbId, WorkflowExpression<dataLanguageInput> dataLanguage, WorkflowExpression<string> topicId, WorkflowExpression<string> fieldsetId, WorkflowExpression<string> fieldId, WorkflowExpression<string> bodyfieldsetId = null, WorkflowExpression<string> bodyfieldId = null, WorkflowExpression<int> bodysetOrder = null, WorkflowExpression<int> bodyorder = null, WorkflowExpression<string> bodytopicId = null, WorkflowExpression<string> bodysetName = null, WorkflowExpression<string> bodyfieldName = null, WorkflowExpression<bodyfieldValueTypeInput> bodyfieldValueType = null, WorkflowExpression<bool> bodyrequired = null, WorkflowExpression<bool> bodyreadonly = null, WorkflowExpression<string> bodyusage = null, WorkflowExpression<string> bodyrelationshipCategorydcv = null, WorkflowExpression<string> bodyrelationshipCategoryname = null, WorkflowExpression<string> bodyrelationshipCategoryicon = null, WorkflowExpression<string> bodycharacteristicdcv = null, WorkflowExpression<string> bodycharacteristicname = null, WorkflowExpression<string> bodycharacteristicicon = null, WorkflowExpression<string> bodyopenLocation = null, WorkflowExpression<string[]> bodydata = null)
        {
            WorkflowExpression.Validate(dbId, nameof(dbId), required: true);
            WorkflowExpression.Validate(dataLanguage, nameof(dataLanguage), required: true);
            WorkflowExpression.Validate(topicId, nameof(topicId), required: true);
            WorkflowExpression.Validate(fieldsetId, nameof(fieldsetId), required: true);
            WorkflowExpression.Validate(fieldId, nameof(fieldId), required: true);
            WorkflowExpression.Validate(bodyfieldsetId, nameof(bodyfieldsetId), required: false);
            WorkflowExpression.Validate(bodyfieldId, nameof(bodyfieldId), required: false);
            WorkflowExpression.Validate(bodysetOrder, nameof(bodysetOrder), required: false);
            WorkflowExpression.Validate(bodyorder, nameof(bodyorder), required: false);
            WorkflowExpression.Validate(bodytopicId, nameof(bodytopicId), required: false);
            WorkflowExpression.Validate(bodysetName, nameof(bodysetName), required: false);
            WorkflowExpression.Validate(bodyfieldName, nameof(bodyfieldName), required: false);
            WorkflowExpression.Validate(bodyfieldValueType, nameof(bodyfieldValueType), required: false);
            WorkflowExpression.Validate(bodyrequired, nameof(bodyrequired), required: false);
            WorkflowExpression.Validate(bodyreadonly, nameof(bodyreadonly), required: false);
            WorkflowExpression.Validate(bodyusage, nameof(bodyusage), required: false);
            WorkflowExpression.Validate(bodyrelationshipCategorydcv, nameof(bodyrelationshipCategorydcv), required: false);
            WorkflowExpression.Validate(bodyrelationshipCategoryname, nameof(bodyrelationshipCategoryname), required: false);
            WorkflowExpression.Validate(bodyrelationshipCategoryicon, nameof(bodyrelationshipCategoryicon), required: false);
            WorkflowExpression.Validate(bodycharacteristicdcv, nameof(bodycharacteristicdcv), required: false);
            WorkflowExpression.Validate(bodycharacteristicname, nameof(bodycharacteristicname), required: false);
            WorkflowExpression.Validate(bodycharacteristicicon, nameof(bodycharacteristicicon), required: false);
            WorkflowExpression.Validate(bodyopenLocation, nameof(bodyopenLocation), required: false);
            WorkflowExpression.Validate(bodydata, nameof(bodydata), required: false);
            return new DeferredBodyAction<IField>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/{0}/{1}/topic/{2}/fieldsets/{3}/multitext/{4}", ExpressionConverter.ConvertWithUrlEncoding(dbId, 1), ExpressionConverter.ConvertWithUrlEncoding(dataLanguage, 1), ExpressionConverter.ConvertWithUrlEncoding(topicId, 1), ExpressionConverter.ConvertWithUrlEncoding(fieldsetId, 1), ExpressionConverter.ConvertWithUrlEncoding(fieldId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfieldsetId != null)
                {
                    body["fieldsetId"] = ExpressionConverter.ConvertO(bodyfieldsetId);
                    bodypropCount++;
                }

                if (bodyfieldId != null)
                {
                    body["fieldId"] = ExpressionConverter.ConvertO(bodyfieldId);
                    bodypropCount++;
                }

                if (bodysetOrder != null)
                {
                    body["setOrder"] = ExpressionConverter.ConvertO(bodysetOrder);
                    bodypropCount++;
                }

                if (bodyorder != null)
                {
                    body["order"] = ExpressionConverter.ConvertO(bodyorder);
                    bodypropCount++;
                }

                if (bodytopicId != null)
                {
                    body["topicId"] = ExpressionConverter.ConvertO(bodytopicId);
                    bodypropCount++;
                }

                if (bodysetName != null)
                {
                    body["setName"] = ExpressionConverter.ConvertO(bodysetName);
                    bodypropCount++;
                }

                if (bodyfieldName != null)
                {
                    body["fieldName"] = ExpressionConverter.ConvertO(bodyfieldName);
                    bodypropCount++;
                }

                if (bodyfieldValueType != null)
                {
                    body["fieldValueType"] = ExpressionConverter.ConvertO(bodyfieldValueType);
                    bodypropCount++;
                }

                if (bodyrequired != null)
                {
                    body["required"] = ExpressionConverter.ConvertO(bodyrequired);
                    bodypropCount++;
                }

                if (bodyreadonly != null)
                {
                    body["readonly"] = ExpressionConverter.ConvertO(bodyreadonly);
                    bodypropCount++;
                }

                if (bodyusage != null)
                {
                    body["usage"] = ExpressionConverter.ConvertO(bodyusage);
                    bodypropCount++;
                }

                var relationshipCategoryObject = new JObject();
                var relationshipCategoryObjectpropCount = 0;
                if (bodyrelationshipCategorydcv != null)
                {
                    relationshipCategoryObject["dcv"] = ExpressionConverter.ConvertO(bodyrelationshipCategorydcv);
                    relationshipCategoryObjectpropCount++;
                }

                if (bodyrelationshipCategoryname != null)
                {
                    relationshipCategoryObject["name"] = ExpressionConverter.ConvertO(bodyrelationshipCategoryname);
                    relationshipCategoryObjectpropCount++;
                }

                if (bodyrelationshipCategoryicon != null)
                {
                    relationshipCategoryObject["icon"] = ExpressionConverter.ConvertO(bodyrelationshipCategoryicon);
                    relationshipCategoryObjectpropCount++;
                }

                if (relationshipCategoryObjectpropCount > 0)
                {
                    body["relationshipCategory"] = relationshipCategoryObject;
                    bodypropCount++;
                }

                var characteristicObject = new JObject();
                var characteristicObjectpropCount = 0;
                if (bodyrelationshipCategorydcv != null)
                {
                    characteristicObject["dcv"] = ExpressionConverter.ConvertO(bodyrelationshipCategorydcv);
                    characteristicObjectpropCount++;
                }

                if (bodyrelationshipCategoryname != null)
                {
                    characteristicObject["name"] = ExpressionConverter.ConvertO(bodyrelationshipCategoryname);
                    characteristicObjectpropCount++;
                }

                if (bodyrelationshipCategoryicon != null)
                {
                    characteristicObject["icon"] = ExpressionConverter.ConvertO(bodyrelationshipCategoryicon);
                    characteristicObjectpropCount++;
                }

                if (characteristicObjectpropCount > 0)
                {
                    body["characteristic"] = characteristicObject;
                    bodypropCount++;
                }

                if (bodyopenLocation != null)
                {
                    body["openLocation"] = ExpressionConverter.ConvertO(bodyopenLocation);
                    bodypropCount++;
                }

                if (bodydata != null)
                {
                    body["data"] = ExpressionConverter.ConvertO(bodydata);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<IField>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateNumberSingleField))]
        public IBodyWorkflowAction<IField> UpdateNumberSingleField([WorkflowExpression] Func<string> dbId, [WorkflowExpression] Func<dataLanguageInput> dataLanguage, [WorkflowExpression] Func<string> topicId, [WorkflowExpression] Func<string> fieldsetId, [WorkflowExpression] Func<string> fieldId, [WorkflowExpression] Func<string> bodyfieldsetId = null, [WorkflowExpression] Func<string> bodyfieldId = null, [WorkflowExpression] Func<int> bodysetOrder = null, [WorkflowExpression] Func<int> bodyorder = null, [WorkflowExpression] Func<string> bodytopicId = null, [WorkflowExpression] Func<string> bodysetName = null, [WorkflowExpression] Func<string> bodyfieldName = null, [WorkflowExpression] Func<bodyfieldValueTypeInput> bodyfieldValueType = null, [WorkflowExpression] Func<bool> bodyrequired = null, [WorkflowExpression] Func<bool> bodyreadonly = null, [WorkflowExpression] Func<string> bodyusage = null, [WorkflowExpression] Func<string> bodyrelationshipCategorydcv = null, [WorkflowExpression] Func<string> bodyrelationshipCategoryname = null, [WorkflowExpression] Func<string> bodyrelationshipCategoryicon = null, [WorkflowExpression] Func<string> bodycharacteristicdcv = null, [WorkflowExpression] Func<string> bodycharacteristicname = null, [WorkflowExpression] Func<string> bodycharacteristicicon = null, [WorkflowExpression] Func<string> bodyopenLocation = null, [WorkflowExpression] Func<int> bodydata = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<IField> __BuildUpdateNumberSingleField(WorkflowExpression<string> dbId, WorkflowExpression<dataLanguageInput> dataLanguage, WorkflowExpression<string> topicId, WorkflowExpression<string> fieldsetId, WorkflowExpression<string> fieldId, WorkflowExpression<string> bodyfieldsetId = null, WorkflowExpression<string> bodyfieldId = null, WorkflowExpression<int> bodysetOrder = null, WorkflowExpression<int> bodyorder = null, WorkflowExpression<string> bodytopicId = null, WorkflowExpression<string> bodysetName = null, WorkflowExpression<string> bodyfieldName = null, WorkflowExpression<bodyfieldValueTypeInput> bodyfieldValueType = null, WorkflowExpression<bool> bodyrequired = null, WorkflowExpression<bool> bodyreadonly = null, WorkflowExpression<string> bodyusage = null, WorkflowExpression<string> bodyrelationshipCategorydcv = null, WorkflowExpression<string> bodyrelationshipCategoryname = null, WorkflowExpression<string> bodyrelationshipCategoryicon = null, WorkflowExpression<string> bodycharacteristicdcv = null, WorkflowExpression<string> bodycharacteristicname = null, WorkflowExpression<string> bodycharacteristicicon = null, WorkflowExpression<string> bodyopenLocation = null, WorkflowExpression<int> bodydata = null)
        {
            WorkflowExpression.Validate(dbId, nameof(dbId), required: true);
            WorkflowExpression.Validate(dataLanguage, nameof(dataLanguage), required: true);
            WorkflowExpression.Validate(topicId, nameof(topicId), required: true);
            WorkflowExpression.Validate(fieldsetId, nameof(fieldsetId), required: true);
            WorkflowExpression.Validate(fieldId, nameof(fieldId), required: true);
            WorkflowExpression.Validate(bodyfieldsetId, nameof(bodyfieldsetId), required: false);
            WorkflowExpression.Validate(bodyfieldId, nameof(bodyfieldId), required: false);
            WorkflowExpression.Validate(bodysetOrder, nameof(bodysetOrder), required: false);
            WorkflowExpression.Validate(bodyorder, nameof(bodyorder), required: false);
            WorkflowExpression.Validate(bodytopicId, nameof(bodytopicId), required: false);
            WorkflowExpression.Validate(bodysetName, nameof(bodysetName), required: false);
            WorkflowExpression.Validate(bodyfieldName, nameof(bodyfieldName), required: false);
            WorkflowExpression.Validate(bodyfieldValueType, nameof(bodyfieldValueType), required: false);
            WorkflowExpression.Validate(bodyrequired, nameof(bodyrequired), required: false);
            WorkflowExpression.Validate(bodyreadonly, nameof(bodyreadonly), required: false);
            WorkflowExpression.Validate(bodyusage, nameof(bodyusage), required: false);
            WorkflowExpression.Validate(bodyrelationshipCategorydcv, nameof(bodyrelationshipCategorydcv), required: false);
            WorkflowExpression.Validate(bodyrelationshipCategoryname, nameof(bodyrelationshipCategoryname), required: false);
            WorkflowExpression.Validate(bodyrelationshipCategoryicon, nameof(bodyrelationshipCategoryicon), required: false);
            WorkflowExpression.Validate(bodycharacteristicdcv, nameof(bodycharacteristicdcv), required: false);
            WorkflowExpression.Validate(bodycharacteristicname, nameof(bodycharacteristicname), required: false);
            WorkflowExpression.Validate(bodycharacteristicicon, nameof(bodycharacteristicicon), required: false);
            WorkflowExpression.Validate(bodyopenLocation, nameof(bodyopenLocation), required: false);
            WorkflowExpression.Validate(bodydata, nameof(bodydata), required: false);
            return new DeferredBodyAction<IField>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/{0}/{1}/topic/{2}/fieldsets/{3}/number/{4}", ExpressionConverter.ConvertWithUrlEncoding(dbId, 1), ExpressionConverter.ConvertWithUrlEncoding(dataLanguage, 1), ExpressionConverter.ConvertWithUrlEncoding(topicId, 1), ExpressionConverter.ConvertWithUrlEncoding(fieldsetId, 1), ExpressionConverter.ConvertWithUrlEncoding(fieldId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfieldsetId != null)
                {
                    body["fieldsetId"] = ExpressionConverter.ConvertO(bodyfieldsetId);
                    bodypropCount++;
                }

                if (bodyfieldId != null)
                {
                    body["fieldId"] = ExpressionConverter.ConvertO(bodyfieldId);
                    bodypropCount++;
                }

                if (bodysetOrder != null)
                {
                    body["setOrder"] = ExpressionConverter.ConvertO(bodysetOrder);
                    bodypropCount++;
                }

                if (bodyorder != null)
                {
                    body["order"] = ExpressionConverter.ConvertO(bodyorder);
                    bodypropCount++;
                }

                if (bodytopicId != null)
                {
                    body["topicId"] = ExpressionConverter.ConvertO(bodytopicId);
                    bodypropCount++;
                }

                if (bodysetName != null)
                {
                    body["setName"] = ExpressionConverter.ConvertO(bodysetName);
                    bodypropCount++;
                }

                if (bodyfieldName != null)
                {
                    body["fieldName"] = ExpressionConverter.ConvertO(bodyfieldName);
                    bodypropCount++;
                }

                if (bodyfieldValueType != null)
                {
                    body["fieldValueType"] = ExpressionConverter.ConvertO(bodyfieldValueType);
                    bodypropCount++;
                }

                if (bodyrequired != null)
                {
                    body["required"] = ExpressionConverter.ConvertO(bodyrequired);
                    bodypropCount++;
                }

                if (bodyreadonly != null)
                {
                    body["readonly"] = ExpressionConverter.ConvertO(bodyreadonly);
                    bodypropCount++;
                }

                if (bodyusage != null)
                {
                    body["usage"] = ExpressionConverter.ConvertO(bodyusage);
                    bodypropCount++;
                }

                var relationshipCategoryObject = new JObject();
                var relationshipCategoryObjectpropCount = 0;
                if (bodyrelationshipCategorydcv != null)
                {
                    relationshipCategoryObject["dcv"] = ExpressionConverter.ConvertO(bodyrelationshipCategorydcv);
                    relationshipCategoryObjectpropCount++;
                }

                if (bodyrelationshipCategoryname != null)
                {
                    relationshipCategoryObject["name"] = ExpressionConverter.ConvertO(bodyrelationshipCategoryname);
                    relationshipCategoryObjectpropCount++;
                }

                if (bodyrelationshipCategoryicon != null)
                {
                    relationshipCategoryObject["icon"] = ExpressionConverter.ConvertO(bodyrelationshipCategoryicon);
                    relationshipCategoryObjectpropCount++;
                }

                if (relationshipCategoryObjectpropCount > 0)
                {
                    body["relationshipCategory"] = relationshipCategoryObject;
                    bodypropCount++;
                }

                var characteristicObject = new JObject();
                var characteristicObjectpropCount = 0;
                if (bodyrelationshipCategorydcv != null)
                {
                    characteristicObject["dcv"] = ExpressionConverter.ConvertO(bodyrelationshipCategorydcv);
                    characteristicObjectpropCount++;
                }

                if (bodyrelationshipCategoryname != null)
                {
                    characteristicObject["name"] = ExpressionConverter.ConvertO(bodyrelationshipCategoryname);
                    characteristicObjectpropCount++;
                }

                if (bodyrelationshipCategoryicon != null)
                {
                    characteristicObject["icon"] = ExpressionConverter.ConvertO(bodyrelationshipCategoryicon);
                    characteristicObjectpropCount++;
                }

                if (characteristicObjectpropCount > 0)
                {
                    body["characteristic"] = characteristicObject;
                    bodypropCount++;
                }

                if (bodyopenLocation != null)
                {
                    body["openLocation"] = ExpressionConverter.ConvertO(bodyopenLocation);
                    bodypropCount++;
                }

                if (bodydata != null)
                {
                    body["data"] = ExpressionConverter.ConvertO(bodydata);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<IField>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateNumberMultiField))]
        public IBodyWorkflowAction<IField> UpdateNumberMultiField([WorkflowExpression] Func<string> dbId, [WorkflowExpression] Func<dataLanguageInput> dataLanguage, [WorkflowExpression] Func<string> topicId, [WorkflowExpression] Func<string> fieldsetId, [WorkflowExpression] Func<string> fieldId, [WorkflowExpression] Func<string> bodyfieldsetId = null, [WorkflowExpression] Func<string> bodyfieldId = null, [WorkflowExpression] Func<int> bodysetOrder = null, [WorkflowExpression] Func<int> bodyorder = null, [WorkflowExpression] Func<string> bodytopicId = null, [WorkflowExpression] Func<string> bodysetName = null, [WorkflowExpression] Func<string> bodyfieldName = null, [WorkflowExpression] Func<bodyfieldValueTypeInput> bodyfieldValueType = null, [WorkflowExpression] Func<bool> bodyrequired = null, [WorkflowExpression] Func<bool> bodyreadonly = null, [WorkflowExpression] Func<string> bodyusage = null, [WorkflowExpression] Func<string> bodyrelationshipCategorydcv = null, [WorkflowExpression] Func<string> bodyrelationshipCategoryname = null, [WorkflowExpression] Func<string> bodyrelationshipCategoryicon = null, [WorkflowExpression] Func<string> bodycharacteristicdcv = null, [WorkflowExpression] Func<string> bodycharacteristicname = null, [WorkflowExpression] Func<string> bodycharacteristicicon = null, [WorkflowExpression] Func<string> bodyopenLocation = null, [WorkflowExpression] Func<int[]> bodydata = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<IField> __BuildUpdateNumberMultiField(WorkflowExpression<string> dbId, WorkflowExpression<dataLanguageInput> dataLanguage, WorkflowExpression<string> topicId, WorkflowExpression<string> fieldsetId, WorkflowExpression<string> fieldId, WorkflowExpression<string> bodyfieldsetId = null, WorkflowExpression<string> bodyfieldId = null, WorkflowExpression<int> bodysetOrder = null, WorkflowExpression<int> bodyorder = null, WorkflowExpression<string> bodytopicId = null, WorkflowExpression<string> bodysetName = null, WorkflowExpression<string> bodyfieldName = null, WorkflowExpression<bodyfieldValueTypeInput> bodyfieldValueType = null, WorkflowExpression<bool> bodyrequired = null, WorkflowExpression<bool> bodyreadonly = null, WorkflowExpression<string> bodyusage = null, WorkflowExpression<string> bodyrelationshipCategorydcv = null, WorkflowExpression<string> bodyrelationshipCategoryname = null, WorkflowExpression<string> bodyrelationshipCategoryicon = null, WorkflowExpression<string> bodycharacteristicdcv = null, WorkflowExpression<string> bodycharacteristicname = null, WorkflowExpression<string> bodycharacteristicicon = null, WorkflowExpression<string> bodyopenLocation = null, WorkflowExpression<int[]> bodydata = null)
        {
            WorkflowExpression.Validate(dbId, nameof(dbId), required: true);
            WorkflowExpression.Validate(dataLanguage, nameof(dataLanguage), required: true);
            WorkflowExpression.Validate(topicId, nameof(topicId), required: true);
            WorkflowExpression.Validate(fieldsetId, nameof(fieldsetId), required: true);
            WorkflowExpression.Validate(fieldId, nameof(fieldId), required: true);
            WorkflowExpression.Validate(bodyfieldsetId, nameof(bodyfieldsetId), required: false);
            WorkflowExpression.Validate(bodyfieldId, nameof(bodyfieldId), required: false);
            WorkflowExpression.Validate(bodysetOrder, nameof(bodysetOrder), required: false);
            WorkflowExpression.Validate(bodyorder, nameof(bodyorder), required: false);
            WorkflowExpression.Validate(bodytopicId, nameof(bodytopicId), required: false);
            WorkflowExpression.Validate(bodysetName, nameof(bodysetName), required: false);
            WorkflowExpression.Validate(bodyfieldName, nameof(bodyfieldName), required: false);
            WorkflowExpression.Validate(bodyfieldValueType, nameof(bodyfieldValueType), required: false);
            WorkflowExpression.Validate(bodyrequired, nameof(bodyrequired), required: false);
            WorkflowExpression.Validate(bodyreadonly, nameof(bodyreadonly), required: false);
            WorkflowExpression.Validate(bodyusage, nameof(bodyusage), required: false);
            WorkflowExpression.Validate(bodyrelationshipCategorydcv, nameof(bodyrelationshipCategorydcv), required: false);
            WorkflowExpression.Validate(bodyrelationshipCategoryname, nameof(bodyrelationshipCategoryname), required: false);
            WorkflowExpression.Validate(bodyrelationshipCategoryicon, nameof(bodyrelationshipCategoryicon), required: false);
            WorkflowExpression.Validate(bodycharacteristicdcv, nameof(bodycharacteristicdcv), required: false);
            WorkflowExpression.Validate(bodycharacteristicname, nameof(bodycharacteristicname), required: false);
            WorkflowExpression.Validate(bodycharacteristicicon, nameof(bodycharacteristicicon), required: false);
            WorkflowExpression.Validate(bodyopenLocation, nameof(bodyopenLocation), required: false);
            WorkflowExpression.Validate(bodydata, nameof(bodydata), required: false);
            return new DeferredBodyAction<IField>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/{0}/{1}/topic/{2}/fieldsets/{3}/multinumber/{4}", ExpressionConverter.ConvertWithUrlEncoding(dbId, 1), ExpressionConverter.ConvertWithUrlEncoding(dataLanguage, 1), ExpressionConverter.ConvertWithUrlEncoding(topicId, 1), ExpressionConverter.ConvertWithUrlEncoding(fieldsetId, 1), ExpressionConverter.ConvertWithUrlEncoding(fieldId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfieldsetId != null)
                {
                    body["fieldsetId"] = ExpressionConverter.ConvertO(bodyfieldsetId);
                    bodypropCount++;
                }

                if (bodyfieldId != null)
                {
                    body["fieldId"] = ExpressionConverter.ConvertO(bodyfieldId);
                    bodypropCount++;
                }

                if (bodysetOrder != null)
                {
                    body["setOrder"] = ExpressionConverter.ConvertO(bodysetOrder);
                    bodypropCount++;
                }

                if (bodyorder != null)
                {
                    body["order"] = ExpressionConverter.ConvertO(bodyorder);
                    bodypropCount++;
                }

                if (bodytopicId != null)
                {
                    body["topicId"] = ExpressionConverter.ConvertO(bodytopicId);
                    bodypropCount++;
                }

                if (bodysetName != null)
                {
                    body["setName"] = ExpressionConverter.ConvertO(bodysetName);
                    bodypropCount++;
                }

                if (bodyfieldName != null)
                {
                    body["fieldName"] = ExpressionConverter.ConvertO(bodyfieldName);
                    bodypropCount++;
                }

                if (bodyfieldValueType != null)
                {
                    body["fieldValueType"] = ExpressionConverter.ConvertO(bodyfieldValueType);
                    bodypropCount++;
                }

                if (bodyrequired != null)
                {
                    body["required"] = ExpressionConverter.ConvertO(bodyrequired);
                    bodypropCount++;
                }

                if (bodyreadonly != null)
                {
                    body["readonly"] = ExpressionConverter.ConvertO(bodyreadonly);
                    bodypropCount++;
                }

                if (bodyusage != null)
                {
                    body["usage"] = ExpressionConverter.ConvertO(bodyusage);
                    bodypropCount++;
                }

                var relationshipCategoryObject = new JObject();
                var relationshipCategoryObjectpropCount = 0;
                if (bodyrelationshipCategorydcv != null)
                {
                    relationshipCategoryObject["dcv"] = ExpressionConverter.ConvertO(bodyrelationshipCategorydcv);
                    relationshipCategoryObjectpropCount++;
                }

                if (bodyrelationshipCategoryname != null)
                {
                    relationshipCategoryObject["name"] = ExpressionConverter.ConvertO(bodyrelationshipCategoryname);
                    relationshipCategoryObjectpropCount++;
                }

                if (bodyrelationshipCategoryicon != null)
                {
                    relationshipCategoryObject["icon"] = ExpressionConverter.ConvertO(bodyrelationshipCategoryicon);
                    relationshipCategoryObjectpropCount++;
                }

                if (relationshipCategoryObjectpropCount > 0)
                {
                    body["relationshipCategory"] = relationshipCategoryObject;
                    bodypropCount++;
                }

                var characteristicObject = new JObject();
                var characteristicObjectpropCount = 0;
                if (bodyrelationshipCategorydcv != null)
                {
                    characteristicObject["dcv"] = ExpressionConverter.ConvertO(bodyrelationshipCategorydcv);
                    characteristicObjectpropCount++;
                }

                if (bodyrelationshipCategoryname != null)
                {
                    characteristicObject["name"] = ExpressionConverter.ConvertO(bodyrelationshipCategoryname);
                    characteristicObjectpropCount++;
                }

                if (bodyrelationshipCategoryicon != null)
                {
                    characteristicObject["icon"] = ExpressionConverter.ConvertO(bodyrelationshipCategoryicon);
                    characteristicObjectpropCount++;
                }

                if (characteristicObjectpropCount > 0)
                {
                    body["characteristic"] = characteristicObject;
                    bodypropCount++;
                }

                if (bodyopenLocation != null)
                {
                    body["openLocation"] = ExpressionConverter.ConvertO(bodyopenLocation);
                    bodypropCount++;
                }

                if (bodydata != null)
                {
                    body["data"] = ExpressionConverter.ConvertO(bodydata);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<IField>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateDecimalSingleField))]
        public IBodyWorkflowAction<IField> UpdateDecimalSingleField([WorkflowExpression] Func<string> dbId, [WorkflowExpression] Func<dataLanguageInput> dataLanguage, [WorkflowExpression] Func<string> topicId, [WorkflowExpression] Func<string> fieldsetId, [WorkflowExpression] Func<string> fieldId, [WorkflowExpression] Func<string> bodyfieldsetId = null, [WorkflowExpression] Func<string> bodyfieldId = null, [WorkflowExpression] Func<int> bodysetOrder = null, [WorkflowExpression] Func<int> bodyorder = null, [WorkflowExpression] Func<string> bodytopicId = null, [WorkflowExpression] Func<string> bodysetName = null, [WorkflowExpression] Func<string> bodyfieldName = null, [WorkflowExpression] Func<bodyfieldValueTypeInput> bodyfieldValueType = null, [WorkflowExpression] Func<bool> bodyrequired = null, [WorkflowExpression] Func<bool> bodyreadonly = null, [WorkflowExpression] Func<string> bodyusage = null, [WorkflowExpression] Func<string> bodyrelationshipCategorydcv = null, [WorkflowExpression] Func<string> bodyrelationshipCategoryname = null, [WorkflowExpression] Func<string> bodyrelationshipCategoryicon = null, [WorkflowExpression] Func<string> bodycharacteristicdcv = null, [WorkflowExpression] Func<string> bodycharacteristicname = null, [WorkflowExpression] Func<string> bodycharacteristicicon = null, [WorkflowExpression] Func<string> bodyopenLocation = null, [WorkflowExpression] Func<double> bodydata = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<IField> __BuildUpdateDecimalSingleField(WorkflowExpression<string> dbId, WorkflowExpression<dataLanguageInput> dataLanguage, WorkflowExpression<string> topicId, WorkflowExpression<string> fieldsetId, WorkflowExpression<string> fieldId, WorkflowExpression<string> bodyfieldsetId = null, WorkflowExpression<string> bodyfieldId = null, WorkflowExpression<int> bodysetOrder = null, WorkflowExpression<int> bodyorder = null, WorkflowExpression<string> bodytopicId = null, WorkflowExpression<string> bodysetName = null, WorkflowExpression<string> bodyfieldName = null, WorkflowExpression<bodyfieldValueTypeInput> bodyfieldValueType = null, WorkflowExpression<bool> bodyrequired = null, WorkflowExpression<bool> bodyreadonly = null, WorkflowExpression<string> bodyusage = null, WorkflowExpression<string> bodyrelationshipCategorydcv = null, WorkflowExpression<string> bodyrelationshipCategoryname = null, WorkflowExpression<string> bodyrelationshipCategoryicon = null, WorkflowExpression<string> bodycharacteristicdcv = null, WorkflowExpression<string> bodycharacteristicname = null, WorkflowExpression<string> bodycharacteristicicon = null, WorkflowExpression<string> bodyopenLocation = null, WorkflowExpression<double> bodydata = null)
        {
            WorkflowExpression.Validate(dbId, nameof(dbId), required: true);
            WorkflowExpression.Validate(dataLanguage, nameof(dataLanguage), required: true);
            WorkflowExpression.Validate(topicId, nameof(topicId), required: true);
            WorkflowExpression.Validate(fieldsetId, nameof(fieldsetId), required: true);
            WorkflowExpression.Validate(fieldId, nameof(fieldId), required: true);
            WorkflowExpression.Validate(bodyfieldsetId, nameof(bodyfieldsetId), required: false);
            WorkflowExpression.Validate(bodyfieldId, nameof(bodyfieldId), required: false);
            WorkflowExpression.Validate(bodysetOrder, nameof(bodysetOrder), required: false);
            WorkflowExpression.Validate(bodyorder, nameof(bodyorder), required: false);
            WorkflowExpression.Validate(bodytopicId, nameof(bodytopicId), required: false);
            WorkflowExpression.Validate(bodysetName, nameof(bodysetName), required: false);
            WorkflowExpression.Validate(bodyfieldName, nameof(bodyfieldName), required: false);
            WorkflowExpression.Validate(bodyfieldValueType, nameof(bodyfieldValueType), required: false);
            WorkflowExpression.Validate(bodyrequired, nameof(bodyrequired), required: false);
            WorkflowExpression.Validate(bodyreadonly, nameof(bodyreadonly), required: false);
            WorkflowExpression.Validate(bodyusage, nameof(bodyusage), required: false);
            WorkflowExpression.Validate(bodyrelationshipCategorydcv, nameof(bodyrelationshipCategorydcv), required: false);
            WorkflowExpression.Validate(bodyrelationshipCategoryname, nameof(bodyrelationshipCategoryname), required: false);
            WorkflowExpression.Validate(bodyrelationshipCategoryicon, nameof(bodyrelationshipCategoryicon), required: false);
            WorkflowExpression.Validate(bodycharacteristicdcv, nameof(bodycharacteristicdcv), required: false);
            WorkflowExpression.Validate(bodycharacteristicname, nameof(bodycharacteristicname), required: false);
            WorkflowExpression.Validate(bodycharacteristicicon, nameof(bodycharacteristicicon), required: false);
            WorkflowExpression.Validate(bodyopenLocation, nameof(bodyopenLocation), required: false);
            WorkflowExpression.Validate(bodydata, nameof(bodydata), required: false);
            return new DeferredBodyAction<IField>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/{0}/{1}/topic/{2}/fieldsets/{3}/decimal/{4}", ExpressionConverter.ConvertWithUrlEncoding(dbId, 1), ExpressionConverter.ConvertWithUrlEncoding(dataLanguage, 1), ExpressionConverter.ConvertWithUrlEncoding(topicId, 1), ExpressionConverter.ConvertWithUrlEncoding(fieldsetId, 1), ExpressionConverter.ConvertWithUrlEncoding(fieldId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfieldsetId != null)
                {
                    body["fieldsetId"] = ExpressionConverter.ConvertO(bodyfieldsetId);
                    bodypropCount++;
                }

                if (bodyfieldId != null)
                {
                    body["fieldId"] = ExpressionConverter.ConvertO(bodyfieldId);
                    bodypropCount++;
                }

                if (bodysetOrder != null)
                {
                    body["setOrder"] = ExpressionConverter.ConvertO(bodysetOrder);
                    bodypropCount++;
                }

                if (bodyorder != null)
                {
                    body["order"] = ExpressionConverter.ConvertO(bodyorder);
                    bodypropCount++;
                }

                if (bodytopicId != null)
                {
                    body["topicId"] = ExpressionConverter.ConvertO(bodytopicId);
                    bodypropCount++;
                }

                if (bodysetName != null)
                {
                    body["setName"] = ExpressionConverter.ConvertO(bodysetName);
                    bodypropCount++;
                }

                if (bodyfieldName != null)
                {
                    body["fieldName"] = ExpressionConverter.ConvertO(bodyfieldName);
                    bodypropCount++;
                }

                if (bodyfieldValueType != null)
                {
                    body["fieldValueType"] = ExpressionConverter.ConvertO(bodyfieldValueType);
                    bodypropCount++;
                }

                if (bodyrequired != null)
                {
                    body["required"] = ExpressionConverter.ConvertO(bodyrequired);
                    bodypropCount++;
                }

                if (bodyreadonly != null)
                {
                    body["readonly"] = ExpressionConverter.ConvertO(bodyreadonly);
                    bodypropCount++;
                }

                if (bodyusage != null)
                {
                    body["usage"] = ExpressionConverter.ConvertO(bodyusage);
                    bodypropCount++;
                }

                var relationshipCategoryObject = new JObject();
                var relationshipCategoryObjectpropCount = 0;
                if (bodyrelationshipCategorydcv != null)
                {
                    relationshipCategoryObject["dcv"] = ExpressionConverter.ConvertO(bodyrelationshipCategorydcv);
                    relationshipCategoryObjectpropCount++;
                }

                if (bodyrelationshipCategoryname != null)
                {
                    relationshipCategoryObject["name"] = ExpressionConverter.ConvertO(bodyrelationshipCategoryname);
                    relationshipCategoryObjectpropCount++;
                }

                if (bodyrelationshipCategoryicon != null)
                {
                    relationshipCategoryObject["icon"] = ExpressionConverter.ConvertO(bodyrelationshipCategoryicon);
                    relationshipCategoryObjectpropCount++;
                }

                if (relationshipCategoryObjectpropCount > 0)
                {
                    body["relationshipCategory"] = relationshipCategoryObject;
                    bodypropCount++;
                }

                var characteristicObject = new JObject();
                var characteristicObjectpropCount = 0;
                if (bodyrelationshipCategorydcv != null)
                {
                    characteristicObject["dcv"] = ExpressionConverter.ConvertO(bodyrelationshipCategorydcv);
                    characteristicObjectpropCount++;
                }

                if (bodyrelationshipCategoryname != null)
                {
                    characteristicObject["name"] = ExpressionConverter.ConvertO(bodyrelationshipCategoryname);
                    characteristicObjectpropCount++;
                }

                if (bodyrelationshipCategoryicon != null)
                {
                    characteristicObject["icon"] = ExpressionConverter.ConvertO(bodyrelationshipCategoryicon);
                    characteristicObjectpropCount++;
                }

                if (characteristicObjectpropCount > 0)
                {
                    body["characteristic"] = characteristicObject;
                    bodypropCount++;
                }

                if (bodyopenLocation != null)
                {
                    body["openLocation"] = ExpressionConverter.ConvertO(bodyopenLocation);
                    bodypropCount++;
                }

                if (bodydata != null)
                {
                    body["data"] = ExpressionConverter.ConvertO(bodydata);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<IField>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateDecimalMultiField))]
        public IBodyWorkflowAction<IField> UpdateDecimalMultiField([WorkflowExpression] Func<string> dbId, [WorkflowExpression] Func<dataLanguageInput> dataLanguage, [WorkflowExpression] Func<string> topicId, [WorkflowExpression] Func<string> fieldsetId, [WorkflowExpression] Func<string> fieldId, [WorkflowExpression] Func<string> bodyfieldsetId = null, [WorkflowExpression] Func<string> bodyfieldId = null, [WorkflowExpression] Func<int> bodysetOrder = null, [WorkflowExpression] Func<int> bodyorder = null, [WorkflowExpression] Func<string> bodytopicId = null, [WorkflowExpression] Func<string> bodysetName = null, [WorkflowExpression] Func<string> bodyfieldName = null, [WorkflowExpression] Func<bodyfieldValueTypeInput> bodyfieldValueType = null, [WorkflowExpression] Func<bool> bodyrequired = null, [WorkflowExpression] Func<bool> bodyreadonly = null, [WorkflowExpression] Func<string> bodyusage = null, [WorkflowExpression] Func<string> bodyrelationshipCategorydcv = null, [WorkflowExpression] Func<string> bodyrelationshipCategoryname = null, [WorkflowExpression] Func<string> bodyrelationshipCategoryicon = null, [WorkflowExpression] Func<string> bodycharacteristicdcv = null, [WorkflowExpression] Func<string> bodycharacteristicname = null, [WorkflowExpression] Func<string> bodycharacteristicicon = null, [WorkflowExpression] Func<string> bodyopenLocation = null, [WorkflowExpression] Func<double[]> bodydata = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<IField> __BuildUpdateDecimalMultiField(WorkflowExpression<string> dbId, WorkflowExpression<dataLanguageInput> dataLanguage, WorkflowExpression<string> topicId, WorkflowExpression<string> fieldsetId, WorkflowExpression<string> fieldId, WorkflowExpression<string> bodyfieldsetId = null, WorkflowExpression<string> bodyfieldId = null, WorkflowExpression<int> bodysetOrder = null, WorkflowExpression<int> bodyorder = null, WorkflowExpression<string> bodytopicId = null, WorkflowExpression<string> bodysetName = null, WorkflowExpression<string> bodyfieldName = null, WorkflowExpression<bodyfieldValueTypeInput> bodyfieldValueType = null, WorkflowExpression<bool> bodyrequired = null, WorkflowExpression<bool> bodyreadonly = null, WorkflowExpression<string> bodyusage = null, WorkflowExpression<string> bodyrelationshipCategorydcv = null, WorkflowExpression<string> bodyrelationshipCategoryname = null, WorkflowExpression<string> bodyrelationshipCategoryicon = null, WorkflowExpression<string> bodycharacteristicdcv = null, WorkflowExpression<string> bodycharacteristicname = null, WorkflowExpression<string> bodycharacteristicicon = null, WorkflowExpression<string> bodyopenLocation = null, WorkflowExpression<double[]> bodydata = null)
        {
            WorkflowExpression.Validate(dbId, nameof(dbId), required: true);
            WorkflowExpression.Validate(dataLanguage, nameof(dataLanguage), required: true);
            WorkflowExpression.Validate(topicId, nameof(topicId), required: true);
            WorkflowExpression.Validate(fieldsetId, nameof(fieldsetId), required: true);
            WorkflowExpression.Validate(fieldId, nameof(fieldId), required: true);
            WorkflowExpression.Validate(bodyfieldsetId, nameof(bodyfieldsetId), required: false);
            WorkflowExpression.Validate(bodyfieldId, nameof(bodyfieldId), required: false);
            WorkflowExpression.Validate(bodysetOrder, nameof(bodysetOrder), required: false);
            WorkflowExpression.Validate(bodyorder, nameof(bodyorder), required: false);
            WorkflowExpression.Validate(bodytopicId, nameof(bodytopicId), required: false);
            WorkflowExpression.Validate(bodysetName, nameof(bodysetName), required: false);
            WorkflowExpression.Validate(bodyfieldName, nameof(bodyfieldName), required: false);
            WorkflowExpression.Validate(bodyfieldValueType, nameof(bodyfieldValueType), required: false);
            WorkflowExpression.Validate(bodyrequired, nameof(bodyrequired), required: false);
            WorkflowExpression.Validate(bodyreadonly, nameof(bodyreadonly), required: false);
            WorkflowExpression.Validate(bodyusage, nameof(bodyusage), required: false);
            WorkflowExpression.Validate(bodyrelationshipCategorydcv, nameof(bodyrelationshipCategorydcv), required: false);
            WorkflowExpression.Validate(bodyrelationshipCategoryname, nameof(bodyrelationshipCategoryname), required: false);
            WorkflowExpression.Validate(bodyrelationshipCategoryicon, nameof(bodyrelationshipCategoryicon), required: false);
            WorkflowExpression.Validate(bodycharacteristicdcv, nameof(bodycharacteristicdcv), required: false);
            WorkflowExpression.Validate(bodycharacteristicname, nameof(bodycharacteristicname), required: false);
            WorkflowExpression.Validate(bodycharacteristicicon, nameof(bodycharacteristicicon), required: false);
            WorkflowExpression.Validate(bodyopenLocation, nameof(bodyopenLocation), required: false);
            WorkflowExpression.Validate(bodydata, nameof(bodydata), required: false);
            return new DeferredBodyAction<IField>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/{0}/{1}/topic/{2}/fieldsets/{3}/multidecimal/{4}", ExpressionConverter.ConvertWithUrlEncoding(dbId, 1), ExpressionConverter.ConvertWithUrlEncoding(dataLanguage, 1), ExpressionConverter.ConvertWithUrlEncoding(topicId, 1), ExpressionConverter.ConvertWithUrlEncoding(fieldsetId, 1), ExpressionConverter.ConvertWithUrlEncoding(fieldId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfieldsetId != null)
                {
                    body["fieldsetId"] = ExpressionConverter.ConvertO(bodyfieldsetId);
                    bodypropCount++;
                }

                if (bodyfieldId != null)
                {
                    body["fieldId"] = ExpressionConverter.ConvertO(bodyfieldId);
                    bodypropCount++;
                }

                if (bodysetOrder != null)
                {
                    body["setOrder"] = ExpressionConverter.ConvertO(bodysetOrder);
                    bodypropCount++;
                }

                if (bodyorder != null)
                {
                    body["order"] = ExpressionConverter.ConvertO(bodyorder);
                    bodypropCount++;
                }

                if (bodytopicId != null)
                {
                    body["topicId"] = ExpressionConverter.ConvertO(bodytopicId);
                    bodypropCount++;
                }

                if (bodysetName != null)
                {
                    body["setName"] = ExpressionConverter.ConvertO(bodysetName);
                    bodypropCount++;
                }

                if (bodyfieldName != null)
                {
                    body["fieldName"] = ExpressionConverter.ConvertO(bodyfieldName);
                    bodypropCount++;
                }

                if (bodyfieldValueType != null)
                {
                    body["fieldValueType"] = ExpressionConverter.ConvertO(bodyfieldValueType);
                    bodypropCount++;
                }

                if (bodyrequired != null)
                {
                    body["required"] = ExpressionConverter.ConvertO(bodyrequired);
                    bodypropCount++;
                }

                if (bodyreadonly != null)
                {
                    body["readonly"] = ExpressionConverter.ConvertO(bodyreadonly);
                    bodypropCount++;
                }

                if (bodyusage != null)
                {
                    body["usage"] = ExpressionConverter.ConvertO(bodyusage);
                    bodypropCount++;
                }

                var relationshipCategoryObject = new JObject();
                var relationshipCategoryObjectpropCount = 0;
                if (bodyrelationshipCategorydcv != null)
                {
                    relationshipCategoryObject["dcv"] = ExpressionConverter.ConvertO(bodyrelationshipCategorydcv);
                    relationshipCategoryObjectpropCount++;
                }

                if (bodyrelationshipCategoryname != null)
                {
                    relationshipCategoryObject["name"] = ExpressionConverter.ConvertO(bodyrelationshipCategoryname);
                    relationshipCategoryObjectpropCount++;
                }

                if (bodyrelationshipCategoryicon != null)
                {
                    relationshipCategoryObject["icon"] = ExpressionConverter.ConvertO(bodyrelationshipCategoryicon);
                    relationshipCategoryObjectpropCount++;
                }

                if (relationshipCategoryObjectpropCount > 0)
                {
                    body["relationshipCategory"] = relationshipCategoryObject;
                    bodypropCount++;
                }

                var characteristicObject = new JObject();
                var characteristicObjectpropCount = 0;
                if (bodyrelationshipCategorydcv != null)
                {
                    characteristicObject["dcv"] = ExpressionConverter.ConvertO(bodyrelationshipCategorydcv);
                    characteristicObjectpropCount++;
                }

                if (bodyrelationshipCategoryname != null)
                {
                    characteristicObject["name"] = ExpressionConverter.ConvertO(bodyrelationshipCategoryname);
                    characteristicObjectpropCount++;
                }

                if (bodyrelationshipCategoryicon != null)
                {
                    characteristicObject["icon"] = ExpressionConverter.ConvertO(bodyrelationshipCategoryicon);
                    characteristicObjectpropCount++;
                }

                if (characteristicObjectpropCount > 0)
                {
                    body["characteristic"] = characteristicObject;
                    bodypropCount++;
                }

                if (bodyopenLocation != null)
                {
                    body["openLocation"] = ExpressionConverter.ConvertO(bodyopenLocation);
                    bodypropCount++;
                }

                if (bodydata != null)
                {
                    body["data"] = ExpressionConverter.ConvertO(bodydata);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<IField>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateDateSingleField))]
        public IBodyWorkflowAction<IField> UpdateDateSingleField([WorkflowExpression] Func<string> dbId, [WorkflowExpression] Func<dataLanguageInput> dataLanguage, [WorkflowExpression] Func<string> topicId, [WorkflowExpression] Func<string> fieldsetId, [WorkflowExpression] Func<string> fieldId, [WorkflowExpression] Func<string> bodyfieldsetId = null, [WorkflowExpression] Func<string> bodyfieldId = null, [WorkflowExpression] Func<int> bodysetOrder = null, [WorkflowExpression] Func<int> bodyorder = null, [WorkflowExpression] Func<string> bodytopicId = null, [WorkflowExpression] Func<string> bodysetName = null, [WorkflowExpression] Func<string> bodyfieldName = null, [WorkflowExpression] Func<bodyfieldValueTypeInput> bodyfieldValueType = null, [WorkflowExpression] Func<bool> bodyrequired = null, [WorkflowExpression] Func<bool> bodyreadonly = null, [WorkflowExpression] Func<string> bodyusage = null, [WorkflowExpression] Func<string> bodyrelationshipCategorydcv = null, [WorkflowExpression] Func<string> bodyrelationshipCategoryname = null, [WorkflowExpression] Func<string> bodyrelationshipCategoryicon = null, [WorkflowExpression] Func<string> bodycharacteristicdcv = null, [WorkflowExpression] Func<string> bodycharacteristicname = null, [WorkflowExpression] Func<string> bodycharacteristicicon = null, [WorkflowExpression] Func<string> bodyopenLocation = null, [WorkflowExpression] Func<string> bodydata = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<IField> __BuildUpdateDateSingleField(WorkflowExpression<string> dbId, WorkflowExpression<dataLanguageInput> dataLanguage, WorkflowExpression<string> topicId, WorkflowExpression<string> fieldsetId, WorkflowExpression<string> fieldId, WorkflowExpression<string> bodyfieldsetId = null, WorkflowExpression<string> bodyfieldId = null, WorkflowExpression<int> bodysetOrder = null, WorkflowExpression<int> bodyorder = null, WorkflowExpression<string> bodytopicId = null, WorkflowExpression<string> bodysetName = null, WorkflowExpression<string> bodyfieldName = null, WorkflowExpression<bodyfieldValueTypeInput> bodyfieldValueType = null, WorkflowExpression<bool> bodyrequired = null, WorkflowExpression<bool> bodyreadonly = null, WorkflowExpression<string> bodyusage = null, WorkflowExpression<string> bodyrelationshipCategorydcv = null, WorkflowExpression<string> bodyrelationshipCategoryname = null, WorkflowExpression<string> bodyrelationshipCategoryicon = null, WorkflowExpression<string> bodycharacteristicdcv = null, WorkflowExpression<string> bodycharacteristicname = null, WorkflowExpression<string> bodycharacteristicicon = null, WorkflowExpression<string> bodyopenLocation = null, WorkflowExpression<string> bodydata = null)
        {
            WorkflowExpression.Validate(dbId, nameof(dbId), required: true);
            WorkflowExpression.Validate(dataLanguage, nameof(dataLanguage), required: true);
            WorkflowExpression.Validate(topicId, nameof(topicId), required: true);
            WorkflowExpression.Validate(fieldsetId, nameof(fieldsetId), required: true);
            WorkflowExpression.Validate(fieldId, nameof(fieldId), required: true);
            WorkflowExpression.Validate(bodyfieldsetId, nameof(bodyfieldsetId), required: false);
            WorkflowExpression.Validate(bodyfieldId, nameof(bodyfieldId), required: false);
            WorkflowExpression.Validate(bodysetOrder, nameof(bodysetOrder), required: false);
            WorkflowExpression.Validate(bodyorder, nameof(bodyorder), required: false);
            WorkflowExpression.Validate(bodytopicId, nameof(bodytopicId), required: false);
            WorkflowExpression.Validate(bodysetName, nameof(bodysetName), required: false);
            WorkflowExpression.Validate(bodyfieldName, nameof(bodyfieldName), required: false);
            WorkflowExpression.Validate(bodyfieldValueType, nameof(bodyfieldValueType), required: false);
            WorkflowExpression.Validate(bodyrequired, nameof(bodyrequired), required: false);
            WorkflowExpression.Validate(bodyreadonly, nameof(bodyreadonly), required: false);
            WorkflowExpression.Validate(bodyusage, nameof(bodyusage), required: false);
            WorkflowExpression.Validate(bodyrelationshipCategorydcv, nameof(bodyrelationshipCategorydcv), required: false);
            WorkflowExpression.Validate(bodyrelationshipCategoryname, nameof(bodyrelationshipCategoryname), required: false);
            WorkflowExpression.Validate(bodyrelationshipCategoryicon, nameof(bodyrelationshipCategoryicon), required: false);
            WorkflowExpression.Validate(bodycharacteristicdcv, nameof(bodycharacteristicdcv), required: false);
            WorkflowExpression.Validate(bodycharacteristicname, nameof(bodycharacteristicname), required: false);
            WorkflowExpression.Validate(bodycharacteristicicon, nameof(bodycharacteristicicon), required: false);
            WorkflowExpression.Validate(bodyopenLocation, nameof(bodyopenLocation), required: false);
            WorkflowExpression.Validate(bodydata, nameof(bodydata), required: false);
            return new DeferredBodyAction<IField>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/{0}/{1}/topic/{2}/fieldsets/{3}/date/{4}", ExpressionConverter.ConvertWithUrlEncoding(dbId, 1), ExpressionConverter.ConvertWithUrlEncoding(dataLanguage, 1), ExpressionConverter.ConvertWithUrlEncoding(topicId, 1), ExpressionConverter.ConvertWithUrlEncoding(fieldsetId, 1), ExpressionConverter.ConvertWithUrlEncoding(fieldId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfieldsetId != null)
                {
                    body["fieldsetId"] = ExpressionConverter.ConvertO(bodyfieldsetId);
                    bodypropCount++;
                }

                if (bodyfieldId != null)
                {
                    body["fieldId"] = ExpressionConverter.ConvertO(bodyfieldId);
                    bodypropCount++;
                }

                if (bodysetOrder != null)
                {
                    body["setOrder"] = ExpressionConverter.ConvertO(bodysetOrder);
                    bodypropCount++;
                }

                if (bodyorder != null)
                {
                    body["order"] = ExpressionConverter.ConvertO(bodyorder);
                    bodypropCount++;
                }

                if (bodytopicId != null)
                {
                    body["topicId"] = ExpressionConverter.ConvertO(bodytopicId);
                    bodypropCount++;
                }

                if (bodysetName != null)
                {
                    body["setName"] = ExpressionConverter.ConvertO(bodysetName);
                    bodypropCount++;
                }

                if (bodyfieldName != null)
                {
                    body["fieldName"] = ExpressionConverter.ConvertO(bodyfieldName);
                    bodypropCount++;
                }

                if (bodyfieldValueType != null)
                {
                    body["fieldValueType"] = ExpressionConverter.ConvertO(bodyfieldValueType);
                    bodypropCount++;
                }

                if (bodyrequired != null)
                {
                    body["required"] = ExpressionConverter.ConvertO(bodyrequired);
                    bodypropCount++;
                }

                if (bodyreadonly != null)
                {
                    body["readonly"] = ExpressionConverter.ConvertO(bodyreadonly);
                    bodypropCount++;
                }

                if (bodyusage != null)
                {
                    body["usage"] = ExpressionConverter.ConvertO(bodyusage);
                    bodypropCount++;
                }

                var relationshipCategoryObject = new JObject();
                var relationshipCategoryObjectpropCount = 0;
                if (bodyrelationshipCategorydcv != null)
                {
                    relationshipCategoryObject["dcv"] = ExpressionConverter.ConvertO(bodyrelationshipCategorydcv);
                    relationshipCategoryObjectpropCount++;
                }

                if (bodyrelationshipCategoryname != null)
                {
                    relationshipCategoryObject["name"] = ExpressionConverter.ConvertO(bodyrelationshipCategoryname);
                    relationshipCategoryObjectpropCount++;
                }

                if (bodyrelationshipCategoryicon != null)
                {
                    relationshipCategoryObject["icon"] = ExpressionConverter.ConvertO(bodyrelationshipCategoryicon);
                    relationshipCategoryObjectpropCount++;
                }

                if (relationshipCategoryObjectpropCount > 0)
                {
                    body["relationshipCategory"] = relationshipCategoryObject;
                    bodypropCount++;
                }

                var characteristicObject = new JObject();
                var characteristicObjectpropCount = 0;
                if (bodyrelationshipCategorydcv != null)
                {
                    characteristicObject["dcv"] = ExpressionConverter.ConvertO(bodyrelationshipCategorydcv);
                    characteristicObjectpropCount++;
                }

                if (bodyrelationshipCategoryname != null)
                {
                    characteristicObject["name"] = ExpressionConverter.ConvertO(bodyrelationshipCategoryname);
                    characteristicObjectpropCount++;
                }

                if (bodyrelationshipCategoryicon != null)
                {
                    characteristicObject["icon"] = ExpressionConverter.ConvertO(bodyrelationshipCategoryicon);
                    characteristicObjectpropCount++;
                }

                if (characteristicObjectpropCount > 0)
                {
                    body["characteristic"] = characteristicObject;
                    bodypropCount++;
                }

                if (bodyopenLocation != null)
                {
                    body["openLocation"] = ExpressionConverter.ConvertO(bodyopenLocation);
                    bodypropCount++;
                }

                if (bodydata != null)
                {
                    body["data"] = ExpressionConverter.ConvertO(bodydata);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<IField>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateDateMultiField))]
        public IBodyWorkflowAction<IField> UpdateDateMultiField([WorkflowExpression] Func<string> dbId, [WorkflowExpression] Func<dataLanguageInput> dataLanguage, [WorkflowExpression] Func<string> topicId, [WorkflowExpression] Func<string> fieldsetId, [WorkflowExpression] Func<string> fieldId, [WorkflowExpression] Func<string> bodyfieldsetId = null, [WorkflowExpression] Func<string> bodyfieldId = null, [WorkflowExpression] Func<int> bodysetOrder = null, [WorkflowExpression] Func<int> bodyorder = null, [WorkflowExpression] Func<string> bodytopicId = null, [WorkflowExpression] Func<string> bodysetName = null, [WorkflowExpression] Func<string> bodyfieldName = null, [WorkflowExpression] Func<bodyfieldValueTypeInput> bodyfieldValueType = null, [WorkflowExpression] Func<bool> bodyrequired = null, [WorkflowExpression] Func<bool> bodyreadonly = null, [WorkflowExpression] Func<string> bodyusage = null, [WorkflowExpression] Func<string> bodyrelationshipCategorydcv = null, [WorkflowExpression] Func<string> bodyrelationshipCategoryname = null, [WorkflowExpression] Func<string> bodyrelationshipCategoryicon = null, [WorkflowExpression] Func<string> bodycharacteristicdcv = null, [WorkflowExpression] Func<string> bodycharacteristicname = null, [WorkflowExpression] Func<string> bodycharacteristicicon = null, [WorkflowExpression] Func<string> bodyopenLocation = null, [WorkflowExpression] Func<string[]> bodydata = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<IField> __BuildUpdateDateMultiField(WorkflowExpression<string> dbId, WorkflowExpression<dataLanguageInput> dataLanguage, WorkflowExpression<string> topicId, WorkflowExpression<string> fieldsetId, WorkflowExpression<string> fieldId, WorkflowExpression<string> bodyfieldsetId = null, WorkflowExpression<string> bodyfieldId = null, WorkflowExpression<int> bodysetOrder = null, WorkflowExpression<int> bodyorder = null, WorkflowExpression<string> bodytopicId = null, WorkflowExpression<string> bodysetName = null, WorkflowExpression<string> bodyfieldName = null, WorkflowExpression<bodyfieldValueTypeInput> bodyfieldValueType = null, WorkflowExpression<bool> bodyrequired = null, WorkflowExpression<bool> bodyreadonly = null, WorkflowExpression<string> bodyusage = null, WorkflowExpression<string> bodyrelationshipCategorydcv = null, WorkflowExpression<string> bodyrelationshipCategoryname = null, WorkflowExpression<string> bodyrelationshipCategoryicon = null, WorkflowExpression<string> bodycharacteristicdcv = null, WorkflowExpression<string> bodycharacteristicname = null, WorkflowExpression<string> bodycharacteristicicon = null, WorkflowExpression<string> bodyopenLocation = null, WorkflowExpression<string[]> bodydata = null)
        {
            WorkflowExpression.Validate(dbId, nameof(dbId), required: true);
            WorkflowExpression.Validate(dataLanguage, nameof(dataLanguage), required: true);
            WorkflowExpression.Validate(topicId, nameof(topicId), required: true);
            WorkflowExpression.Validate(fieldsetId, nameof(fieldsetId), required: true);
            WorkflowExpression.Validate(fieldId, nameof(fieldId), required: true);
            WorkflowExpression.Validate(bodyfieldsetId, nameof(bodyfieldsetId), required: false);
            WorkflowExpression.Validate(bodyfieldId, nameof(bodyfieldId), required: false);
            WorkflowExpression.Validate(bodysetOrder, nameof(bodysetOrder), required: false);
            WorkflowExpression.Validate(bodyorder, nameof(bodyorder), required: false);
            WorkflowExpression.Validate(bodytopicId, nameof(bodytopicId), required: false);
            WorkflowExpression.Validate(bodysetName, nameof(bodysetName), required: false);
            WorkflowExpression.Validate(bodyfieldName, nameof(bodyfieldName), required: false);
            WorkflowExpression.Validate(bodyfieldValueType, nameof(bodyfieldValueType), required: false);
            WorkflowExpression.Validate(bodyrequired, nameof(bodyrequired), required: false);
            WorkflowExpression.Validate(bodyreadonly, nameof(bodyreadonly), required: false);
            WorkflowExpression.Validate(bodyusage, nameof(bodyusage), required: false);
            WorkflowExpression.Validate(bodyrelationshipCategorydcv, nameof(bodyrelationshipCategorydcv), required: false);
            WorkflowExpression.Validate(bodyrelationshipCategoryname, nameof(bodyrelationshipCategoryname), required: false);
            WorkflowExpression.Validate(bodyrelationshipCategoryicon, nameof(bodyrelationshipCategoryicon), required: false);
            WorkflowExpression.Validate(bodycharacteristicdcv, nameof(bodycharacteristicdcv), required: false);
            WorkflowExpression.Validate(bodycharacteristicname, nameof(bodycharacteristicname), required: false);
            WorkflowExpression.Validate(bodycharacteristicicon, nameof(bodycharacteristicicon), required: false);
            WorkflowExpression.Validate(bodyopenLocation, nameof(bodyopenLocation), required: false);
            WorkflowExpression.Validate(bodydata, nameof(bodydata), required: false);
            return new DeferredBodyAction<IField>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/{0}/{1}/topic/{2}/fieldsets/{3}/multidate/{4}", ExpressionConverter.ConvertWithUrlEncoding(dbId, 1), ExpressionConverter.ConvertWithUrlEncoding(dataLanguage, 1), ExpressionConverter.ConvertWithUrlEncoding(topicId, 1), ExpressionConverter.ConvertWithUrlEncoding(fieldsetId, 1), ExpressionConverter.ConvertWithUrlEncoding(fieldId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfieldsetId != null)
                {
                    body["fieldsetId"] = ExpressionConverter.ConvertO(bodyfieldsetId);
                    bodypropCount++;
                }

                if (bodyfieldId != null)
                {
                    body["fieldId"] = ExpressionConverter.ConvertO(bodyfieldId);
                    bodypropCount++;
                }

                if (bodysetOrder != null)
                {
                    body["setOrder"] = ExpressionConverter.ConvertO(bodysetOrder);
                    bodypropCount++;
                }

                if (bodyorder != null)
                {
                    body["order"] = ExpressionConverter.ConvertO(bodyorder);
                    bodypropCount++;
                }

                if (bodytopicId != null)
                {
                    body["topicId"] = ExpressionConverter.ConvertO(bodytopicId);
                    bodypropCount++;
                }

                if (bodysetName != null)
                {
                    body["setName"] = ExpressionConverter.ConvertO(bodysetName);
                    bodypropCount++;
                }

                if (bodyfieldName != null)
                {
                    body["fieldName"] = ExpressionConverter.ConvertO(bodyfieldName);
                    bodypropCount++;
                }

                if (bodyfieldValueType != null)
                {
                    body["fieldValueType"] = ExpressionConverter.ConvertO(bodyfieldValueType);
                    bodypropCount++;
                }

                if (bodyrequired != null)
                {
                    body["required"] = ExpressionConverter.ConvertO(bodyrequired);
                    bodypropCount++;
                }

                if (bodyreadonly != null)
                {
                    body["readonly"] = ExpressionConverter.ConvertO(bodyreadonly);
                    bodypropCount++;
                }

                if (bodyusage != null)
                {
                    body["usage"] = ExpressionConverter.ConvertO(bodyusage);
                    bodypropCount++;
                }

                var relationshipCategoryObject = new JObject();
                var relationshipCategoryObjectpropCount = 0;
                if (bodyrelationshipCategorydcv != null)
                {
                    relationshipCategoryObject["dcv"] = ExpressionConverter.ConvertO(bodyrelationshipCategorydcv);
                    relationshipCategoryObjectpropCount++;
                }

                if (bodyrelationshipCategoryname != null)
                {
                    relationshipCategoryObject["name"] = ExpressionConverter.ConvertO(bodyrelationshipCategoryname);
                    relationshipCategoryObjectpropCount++;
                }

                if (bodyrelationshipCategoryicon != null)
                {
                    relationshipCategoryObject["icon"] = ExpressionConverter.ConvertO(bodyrelationshipCategoryicon);
                    relationshipCategoryObjectpropCount++;
                }

                if (relationshipCategoryObjectpropCount > 0)
                {
                    body["relationshipCategory"] = relationshipCategoryObject;
                    bodypropCount++;
                }

                var characteristicObject = new JObject();
                var characteristicObjectpropCount = 0;
                if (bodyrelationshipCategorydcv != null)
                {
                    characteristicObject["dcv"] = ExpressionConverter.ConvertO(bodyrelationshipCategorydcv);
                    characteristicObjectpropCount++;
                }

                if (bodyrelationshipCategoryname != null)
                {
                    characteristicObject["name"] = ExpressionConverter.ConvertO(bodyrelationshipCategoryname);
                    characteristicObjectpropCount++;
                }

                if (bodyrelationshipCategoryicon != null)
                {
                    characteristicObject["icon"] = ExpressionConverter.ConvertO(bodyrelationshipCategoryicon);
                    characteristicObjectpropCount++;
                }

                if (characteristicObjectpropCount > 0)
                {
                    body["characteristic"] = characteristicObject;
                    bodypropCount++;
                }

                if (bodyopenLocation != null)
                {
                    body["openLocation"] = ExpressionConverter.ConvertO(bodyopenLocation);
                    bodypropCount++;
                }

                if (bodydata != null)
                {
                    body["data"] = ExpressionConverter.ConvertO(bodydata);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<IField>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateListSingleField))]
        public IBodyWorkflowAction<IField> UpdateListSingleField([WorkflowExpression] Func<string> dbId, [WorkflowExpression] Func<dataLanguageInput> dataLanguage, [WorkflowExpression] Func<string> topicId, [WorkflowExpression] Func<string> fieldsetId, [WorkflowExpression] Func<string> fieldId, [WorkflowExpression] Func<string> bodyfieldsetId = null, [WorkflowExpression] Func<string> bodyfieldId = null, [WorkflowExpression] Func<int> bodysetOrder = null, [WorkflowExpression] Func<int> bodyorder = null, [WorkflowExpression] Func<string> bodytopicId = null, [WorkflowExpression] Func<string> bodysetName = null, [WorkflowExpression] Func<string> bodyfieldName = null, [WorkflowExpression] Func<bodyfieldValueTypeInput> bodyfieldValueType = null, [WorkflowExpression] Func<bool> bodyrequired = null, [WorkflowExpression] Func<bool> bodyreadonly = null, [WorkflowExpression] Func<string> bodyusage = null, [WorkflowExpression] Func<string> bodyrelationshipCategorydcv = null, [WorkflowExpression] Func<string> bodyrelationshipCategoryname = null, [WorkflowExpression] Func<string> bodyrelationshipCategoryicon = null, [WorkflowExpression] Func<string> bodycharacteristicdcv = null, [WorkflowExpression] Func<string> bodycharacteristicname = null, [WorkflowExpression] Func<string> bodycharacteristicicon = null, [WorkflowExpression] Func<string> bodyopenLocation = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<IField> __BuildUpdateListSingleField(WorkflowExpression<string> dbId, WorkflowExpression<dataLanguageInput> dataLanguage, WorkflowExpression<string> topicId, WorkflowExpression<string> fieldsetId, WorkflowExpression<string> fieldId, WorkflowExpression<string> bodyfieldsetId = null, WorkflowExpression<string> bodyfieldId = null, WorkflowExpression<int> bodysetOrder = null, WorkflowExpression<int> bodyorder = null, WorkflowExpression<string> bodytopicId = null, WorkflowExpression<string> bodysetName = null, WorkflowExpression<string> bodyfieldName = null, WorkflowExpression<bodyfieldValueTypeInput> bodyfieldValueType = null, WorkflowExpression<bool> bodyrequired = null, WorkflowExpression<bool> bodyreadonly = null, WorkflowExpression<string> bodyusage = null, WorkflowExpression<string> bodyrelationshipCategorydcv = null, WorkflowExpression<string> bodyrelationshipCategoryname = null, WorkflowExpression<string> bodyrelationshipCategoryicon = null, WorkflowExpression<string> bodycharacteristicdcv = null, WorkflowExpression<string> bodycharacteristicname = null, WorkflowExpression<string> bodycharacteristicicon = null, WorkflowExpression<string> bodyopenLocation = null)
        {
            WorkflowExpression.Validate(dbId, nameof(dbId), required: true);
            WorkflowExpression.Validate(dataLanguage, nameof(dataLanguage), required: true);
            WorkflowExpression.Validate(topicId, nameof(topicId), required: true);
            WorkflowExpression.Validate(fieldsetId, nameof(fieldsetId), required: true);
            WorkflowExpression.Validate(fieldId, nameof(fieldId), required: true);
            WorkflowExpression.Validate(bodyfieldsetId, nameof(bodyfieldsetId), required: false);
            WorkflowExpression.Validate(bodyfieldId, nameof(bodyfieldId), required: false);
            WorkflowExpression.Validate(bodysetOrder, nameof(bodysetOrder), required: false);
            WorkflowExpression.Validate(bodyorder, nameof(bodyorder), required: false);
            WorkflowExpression.Validate(bodytopicId, nameof(bodytopicId), required: false);
            WorkflowExpression.Validate(bodysetName, nameof(bodysetName), required: false);
            WorkflowExpression.Validate(bodyfieldName, nameof(bodyfieldName), required: false);
            WorkflowExpression.Validate(bodyfieldValueType, nameof(bodyfieldValueType), required: false);
            WorkflowExpression.Validate(bodyrequired, nameof(bodyrequired), required: false);
            WorkflowExpression.Validate(bodyreadonly, nameof(bodyreadonly), required: false);
            WorkflowExpression.Validate(bodyusage, nameof(bodyusage), required: false);
            WorkflowExpression.Validate(bodyrelationshipCategorydcv, nameof(bodyrelationshipCategorydcv), required: false);
            WorkflowExpression.Validate(bodyrelationshipCategoryname, nameof(bodyrelationshipCategoryname), required: false);
            WorkflowExpression.Validate(bodyrelationshipCategoryicon, nameof(bodyrelationshipCategoryicon), required: false);
            WorkflowExpression.Validate(bodycharacteristicdcv, nameof(bodycharacteristicdcv), required: false);
            WorkflowExpression.Validate(bodycharacteristicname, nameof(bodycharacteristicname), required: false);
            WorkflowExpression.Validate(bodycharacteristicicon, nameof(bodycharacteristicicon), required: false);
            WorkflowExpression.Validate(bodyopenLocation, nameof(bodyopenLocation), required: false);
            return new DeferredBodyAction<IField>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/{0}/{1}/topic/{2}/fieldsets/{3}/list/{4}", ExpressionConverter.ConvertWithUrlEncoding(dbId, 1), ExpressionConverter.ConvertWithUrlEncoding(dataLanguage, 1), ExpressionConverter.ConvertWithUrlEncoding(topicId, 1), ExpressionConverter.ConvertWithUrlEncoding(fieldsetId, 1), ExpressionConverter.ConvertWithUrlEncoding(fieldId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfieldsetId != null)
                {
                    body["fieldsetId"] = ExpressionConverter.ConvertO(bodyfieldsetId);
                    bodypropCount++;
                }

                if (bodyfieldId != null)
                {
                    body["fieldId"] = ExpressionConverter.ConvertO(bodyfieldId);
                    bodypropCount++;
                }

                if (bodysetOrder != null)
                {
                    body["setOrder"] = ExpressionConverter.ConvertO(bodysetOrder);
                    bodypropCount++;
                }

                if (bodyorder != null)
                {
                    body["order"] = ExpressionConverter.ConvertO(bodyorder);
                    bodypropCount++;
                }

                if (bodytopicId != null)
                {
                    body["topicId"] = ExpressionConverter.ConvertO(bodytopicId);
                    bodypropCount++;
                }

                if (bodysetName != null)
                {
                    body["setName"] = ExpressionConverter.ConvertO(bodysetName);
                    bodypropCount++;
                }

                if (bodyfieldName != null)
                {
                    body["fieldName"] = ExpressionConverter.ConvertO(bodyfieldName);
                    bodypropCount++;
                }

                if (bodyfieldValueType != null)
                {
                    body["fieldValueType"] = ExpressionConverter.ConvertO(bodyfieldValueType);
                    bodypropCount++;
                }

                if (bodyrequired != null)
                {
                    body["required"] = ExpressionConverter.ConvertO(bodyrequired);
                    bodypropCount++;
                }

                if (bodyreadonly != null)
                {
                    body["readonly"] = ExpressionConverter.ConvertO(bodyreadonly);
                    bodypropCount++;
                }

                if (bodyusage != null)
                {
                    body["usage"] = ExpressionConverter.ConvertO(bodyusage);
                    bodypropCount++;
                }

                var relationshipCategoryObject = new JObject();
                var relationshipCategoryObjectpropCount = 0;
                if (bodyrelationshipCategorydcv != null)
                {
                    relationshipCategoryObject["dcv"] = ExpressionConverter.ConvertO(bodyrelationshipCategorydcv);
                    relationshipCategoryObjectpropCount++;
                }

                if (bodyrelationshipCategoryname != null)
                {
                    relationshipCategoryObject["name"] = ExpressionConverter.ConvertO(bodyrelationshipCategoryname);
                    relationshipCategoryObjectpropCount++;
                }

                if (bodyrelationshipCategoryicon != null)
                {
                    relationshipCategoryObject["icon"] = ExpressionConverter.ConvertO(bodyrelationshipCategoryicon);
                    relationshipCategoryObjectpropCount++;
                }

                if (relationshipCategoryObjectpropCount > 0)
                {
                    body["relationshipCategory"] = relationshipCategoryObject;
                    bodypropCount++;
                }

                var characteristicObject = new JObject();
                var characteristicObjectpropCount = 0;
                if (bodyrelationshipCategorydcv != null)
                {
                    characteristicObject["dcv"] = ExpressionConverter.ConvertO(bodyrelationshipCategorydcv);
                    characteristicObjectpropCount++;
                }

                if (bodyrelationshipCategoryname != null)
                {
                    characteristicObject["name"] = ExpressionConverter.ConvertO(bodyrelationshipCategoryname);
                    characteristicObjectpropCount++;
                }

                if (bodyrelationshipCategoryicon != null)
                {
                    characteristicObject["icon"] = ExpressionConverter.ConvertO(bodyrelationshipCategoryicon);
                    characteristicObjectpropCount++;
                }

                if (characteristicObjectpropCount > 0)
                {
                    body["characteristic"] = characteristicObject;
                    bodypropCount++;
                }

                if (bodyopenLocation != null)
                {
                    body["openLocation"] = ExpressionConverter.ConvertO(bodyopenLocation);
                    bodypropCount++;
                }

                var dataObject = new JObject();
                var dataObjectpropCount = 0;
                if (dataObjectpropCount > 0)
                {
                    body["data"] = dataObject;
                    bodypropCount++;
                }

                var optionsObject = new JObject();
                var optionsObjectpropCount = 0;
                if (optionsObjectpropCount > 0)
                {
                    body["options"] = optionsObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<IField>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateRelationshipSingleField))]
        public IBodyWorkflowAction<IField> UpdateRelationshipSingleField([WorkflowExpression] Func<string> dbId, [WorkflowExpression] Func<dataLanguageInput> dataLanguage, [WorkflowExpression] Func<string> topicId, [WorkflowExpression] Func<string> fieldsetId, [WorkflowExpression] Func<string> fieldId, [WorkflowExpression] Func<string> bodyfieldId = null, [WorkflowExpression] Func<string> bodyfieldsetId = null, [WorkflowExpression] Func<string> bodydatadcv = null, [WorkflowExpression] Func<string> bodydataname = null, [WorkflowExpression] Func<string> bodydataicon = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<IField> __BuildUpdateRelationshipSingleField(WorkflowExpression<string> dbId, WorkflowExpression<dataLanguageInput> dataLanguage, WorkflowExpression<string> topicId, WorkflowExpression<string> fieldsetId, WorkflowExpression<string> fieldId, WorkflowExpression<string> bodyfieldId = null, WorkflowExpression<string> bodyfieldsetId = null, WorkflowExpression<string> bodydatadcv = null, WorkflowExpression<string> bodydataname = null, WorkflowExpression<string> bodydataicon = null)
        {
            WorkflowExpression.Validate(dbId, nameof(dbId), required: true);
            WorkflowExpression.Validate(dataLanguage, nameof(dataLanguage), required: true);
            WorkflowExpression.Validate(topicId, nameof(topicId), required: true);
            WorkflowExpression.Validate(fieldsetId, nameof(fieldsetId), required: true);
            WorkflowExpression.Validate(fieldId, nameof(fieldId), required: true);
            WorkflowExpression.Validate(bodyfieldId, nameof(bodyfieldId), required: false);
            WorkflowExpression.Validate(bodyfieldsetId, nameof(bodyfieldsetId), required: false);
            WorkflowExpression.Validate(bodydatadcv, nameof(bodydatadcv), required: false);
            WorkflowExpression.Validate(bodydataname, nameof(bodydataname), required: false);
            WorkflowExpression.Validate(bodydataicon, nameof(bodydataicon), required: false);
            return new DeferredBodyAction<IField>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/{0}/{1}/topic/{2}/fieldsets/{3}/relationship/{4}", ExpressionConverter.ConvertWithUrlEncoding(dbId, 1), ExpressionConverter.ConvertWithUrlEncoding(dataLanguage, 1), ExpressionConverter.ConvertWithUrlEncoding(topicId, 1), ExpressionConverter.ConvertWithUrlEncoding(fieldsetId, 1), ExpressionConverter.ConvertWithUrlEncoding(fieldId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfieldId != null)
                {
                    body["fieldId"] = ExpressionConverter.ConvertO(bodyfieldId);
                    bodypropCount++;
                }

                if (bodyfieldsetId != null)
                {
                    body["fieldsetId"] = ExpressionConverter.ConvertO(bodyfieldsetId);
                    bodypropCount++;
                }

                var dataObject = new JObject();
                var dataObjectpropCount = 0;
                if (bodydatadcv != null)
                {
                    dataObject["dcv"] = ExpressionConverter.ConvertO(bodydatadcv);
                    dataObjectpropCount++;
                }

                if (bodydataname != null)
                {
                    dataObject["name"] = ExpressionConverter.ConvertO(bodydataname);
                    dataObjectpropCount++;
                }

                if (bodydataicon != null)
                {
                    dataObject["icon"] = ExpressionConverter.ConvertO(bodydataicon);
                    dataObjectpropCount++;
                }

                if (dataObjectpropCount > 0)
                {
                    body["data"] = dataObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<IField>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateRelationshipMultiField))]
        public IBodyWorkflowAction<IField> UpdateRelationshipMultiField([WorkflowExpression] Func<string> dbId, [WorkflowExpression] Func<dataLanguageInput> dataLanguage, [WorkflowExpression] Func<string> topicId, [WorkflowExpression] Func<string> fieldsetId, [WorkflowExpression] Func<string> fieldId, [WorkflowExpression] Func<string> bodyfieldId = null, [WorkflowExpression] Func<string> bodyfieldsetId = null, [WorkflowExpression] Func<RelationshipElement[]> bodydata = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<IField> __BuildUpdateRelationshipMultiField(WorkflowExpression<string> dbId, WorkflowExpression<dataLanguageInput> dataLanguage, WorkflowExpression<string> topicId, WorkflowExpression<string> fieldsetId, WorkflowExpression<string> fieldId, WorkflowExpression<string> bodyfieldId = null, WorkflowExpression<string> bodyfieldsetId = null, WorkflowExpression<RelationshipElement[]> bodydata = null)
        {
            WorkflowExpression.Validate(dbId, nameof(dbId), required: true);
            WorkflowExpression.Validate(dataLanguage, nameof(dataLanguage), required: true);
            WorkflowExpression.Validate(topicId, nameof(topicId), required: true);
            WorkflowExpression.Validate(fieldsetId, nameof(fieldsetId), required: true);
            WorkflowExpression.Validate(fieldId, nameof(fieldId), required: true);
            WorkflowExpression.Validate(bodyfieldId, nameof(bodyfieldId), required: false);
            WorkflowExpression.Validate(bodyfieldsetId, nameof(bodyfieldsetId), required: false);
            WorkflowExpression.Validate(bodydata, nameof(bodydata), required: false);
            return new DeferredBodyAction<IField>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/{0}/{1}/topic/{2}/fieldsets/{3}/multirelationship/{4}", ExpressionConverter.ConvertWithUrlEncoding(dbId, 1), ExpressionConverter.ConvertWithUrlEncoding(dataLanguage, 1), ExpressionConverter.ConvertWithUrlEncoding(topicId, 1), ExpressionConverter.ConvertWithUrlEncoding(fieldsetId, 1), ExpressionConverter.ConvertWithUrlEncoding(fieldId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfieldId != null)
                {
                    body["fieldId"] = ExpressionConverter.ConvertO(bodyfieldId);
                    bodypropCount++;
                }

                if (bodyfieldsetId != null)
                {
                    body["fieldsetId"] = ExpressionConverter.ConvertO(bodyfieldsetId);
                    bodypropCount++;
                }

                if (bodydata != null)
                {
                    body["data"] = ExpressionConverter.ConvertO(bodydata);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<IField>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateRelationshipListField))]
        public IBodyWorkflowAction<IField> UpdateRelationshipListField([WorkflowExpression] Func<string> dbId, [WorkflowExpression] Func<dataLanguageInput> dataLanguage, [WorkflowExpression] Func<string> topicId, [WorkflowExpression] Func<string> fieldsetId, [WorkflowExpression] Func<string> fieldId, [WorkflowExpression] Func<string> bodyfieldId = null, [WorkflowExpression] Func<string> bodyfieldsetId = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<IField> __BuildUpdateRelationshipListField(WorkflowExpression<string> dbId, WorkflowExpression<dataLanguageInput> dataLanguage, WorkflowExpression<string> topicId, WorkflowExpression<string> fieldsetId, WorkflowExpression<string> fieldId, WorkflowExpression<string> bodyfieldId = null, WorkflowExpression<string> bodyfieldsetId = null)
        {
            WorkflowExpression.Validate(dbId, nameof(dbId), required: true);
            WorkflowExpression.Validate(dataLanguage, nameof(dataLanguage), required: true);
            WorkflowExpression.Validate(topicId, nameof(topicId), required: true);
            WorkflowExpression.Validate(fieldsetId, nameof(fieldsetId), required: true);
            WorkflowExpression.Validate(fieldId, nameof(fieldId), required: true);
            WorkflowExpression.Validate(bodyfieldId, nameof(bodyfieldId), required: false);
            WorkflowExpression.Validate(bodyfieldsetId, nameof(bodyfieldsetId), required: false);
            return new DeferredBodyAction<IField>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/{0}/{1}/topic/{2}/fieldsets/{3}/relationshiplist/{4}", ExpressionConverter.ConvertWithUrlEncoding(dbId, 1), ExpressionConverter.ConvertWithUrlEncoding(dataLanguage, 1), ExpressionConverter.ConvertWithUrlEncoding(topicId, 1), ExpressionConverter.ConvertWithUrlEncoding(fieldsetId, 1), ExpressionConverter.ConvertWithUrlEncoding(fieldId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfieldId != null)
                {
                    body["fieldId"] = ExpressionConverter.ConvertO(bodyfieldId);
                    bodypropCount++;
                }

                if (bodyfieldsetId != null)
                {
                    body["fieldsetId"] = ExpressionConverter.ConvertO(bodyfieldsetId);
                    bodypropCount++;
                }

                var dataObject = new JObject();
                var dataObjectpropCount = 0;
                if (dataObjectpropCount > 0)
                {
                    body["data"] = dataObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<IField>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateFields))]
        public IBodyWorkflowAction<IField> UpdateFields([WorkflowExpression] Func<string> dbId, [WorkflowExpression] Func<dataLanguageInput> dataLanguage, [WorkflowExpression] Func<string> topicId, [WorkflowExpression] Func<SingleTextField[]> bodysingleTextFields = null, [WorkflowExpression] Func<MultiTextField[]> bodymultiTextFields = null, [WorkflowExpression] Func<SingleNumberField[]> bodysingleNumberFields = null, [WorkflowExpression] Func<MultiNumberField[]> bodymultiNumberFields = null, [WorkflowExpression] Func<SingleBooleanField[]> bodysingleBooleanFields = null, [WorkflowExpression] Func<SingleDecimalField[]> bodysingleDecimalFields = null, [WorkflowExpression] Func<MultiDecimalField[]> bodymultiDecimalFields = null, [WorkflowExpression] Func<SingleDateField[]> bodysingleDateFields = null, [WorkflowExpression] Func<MultiDateField[]> bodymultiDateFields = null, [WorkflowExpression] Func<SingleListField[]> bodysingleListFields = null, [WorkflowExpression] Func<RelationshipField[]> bodysingleRelationshipFields = null, [WorkflowExpression] Func<MultiRelationshipField[]> bodymultiRelationshipFields = null, [WorkflowExpression] Func<RelationshipListField[]> bodysingleRelationshipListFields = null, [WorkflowExpression] Func<SingleHyperlinkField[]> bodysingleHyperlinkFields = null, [WorkflowExpression] Func<MultiHyperlinkField[]> bodymultiHyperlinkFields = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<IField> __BuildUpdateFields(WorkflowExpression<string> dbId, WorkflowExpression<dataLanguageInput> dataLanguage, WorkflowExpression<string> topicId, WorkflowExpression<SingleTextField[]> bodysingleTextFields = null, WorkflowExpression<MultiTextField[]> bodymultiTextFields = null, WorkflowExpression<SingleNumberField[]> bodysingleNumberFields = null, WorkflowExpression<MultiNumberField[]> bodymultiNumberFields = null, WorkflowExpression<SingleBooleanField[]> bodysingleBooleanFields = null, WorkflowExpression<SingleDecimalField[]> bodysingleDecimalFields = null, WorkflowExpression<MultiDecimalField[]> bodymultiDecimalFields = null, WorkflowExpression<SingleDateField[]> bodysingleDateFields = null, WorkflowExpression<MultiDateField[]> bodymultiDateFields = null, WorkflowExpression<SingleListField[]> bodysingleListFields = null, WorkflowExpression<RelationshipField[]> bodysingleRelationshipFields = null, WorkflowExpression<MultiRelationshipField[]> bodymultiRelationshipFields = null, WorkflowExpression<RelationshipListField[]> bodysingleRelationshipListFields = null, WorkflowExpression<SingleHyperlinkField[]> bodysingleHyperlinkFields = null, WorkflowExpression<MultiHyperlinkField[]> bodymultiHyperlinkFields = null)
        {
            WorkflowExpression.Validate(dbId, nameof(dbId), required: true);
            WorkflowExpression.Validate(dataLanguage, nameof(dataLanguage), required: true);
            WorkflowExpression.Validate(topicId, nameof(topicId), required: true);
            WorkflowExpression.Validate(bodysingleTextFields, nameof(bodysingleTextFields), required: false);
            WorkflowExpression.Validate(bodymultiTextFields, nameof(bodymultiTextFields), required: false);
            WorkflowExpression.Validate(bodysingleNumberFields, nameof(bodysingleNumberFields), required: false);
            WorkflowExpression.Validate(bodymultiNumberFields, nameof(bodymultiNumberFields), required: false);
            WorkflowExpression.Validate(bodysingleBooleanFields, nameof(bodysingleBooleanFields), required: false);
            WorkflowExpression.Validate(bodysingleDecimalFields, nameof(bodysingleDecimalFields), required: false);
            WorkflowExpression.Validate(bodymultiDecimalFields, nameof(bodymultiDecimalFields), required: false);
            WorkflowExpression.Validate(bodysingleDateFields, nameof(bodysingleDateFields), required: false);
            WorkflowExpression.Validate(bodymultiDateFields, nameof(bodymultiDateFields), required: false);
            WorkflowExpression.Validate(bodysingleListFields, nameof(bodysingleListFields), required: false);
            WorkflowExpression.Validate(bodysingleRelationshipFields, nameof(bodysingleRelationshipFields), required: false);
            WorkflowExpression.Validate(bodymultiRelationshipFields, nameof(bodymultiRelationshipFields), required: false);
            WorkflowExpression.Validate(bodysingleRelationshipListFields, nameof(bodysingleRelationshipListFields), required: false);
            WorkflowExpression.Validate(bodysingleHyperlinkFields, nameof(bodysingleHyperlinkFields), required: false);
            WorkflowExpression.Validate(bodymultiHyperlinkFields, nameof(bodymultiHyperlinkFields), required: false);
            return new DeferredBodyAction<IField>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/{0}/{1}/topic/{2}/fields", ExpressionConverter.ConvertWithUrlEncoding(dbId, 1), ExpressionConverter.ConvertWithUrlEncoding(dataLanguage, 1), ExpressionConverter.ConvertWithUrlEncoding(topicId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodysingleTextFields != null)
                {
                    body["singleTextFields"] = ExpressionConverter.ConvertO(bodysingleTextFields);
                    bodypropCount++;
                }

                if (bodymultiTextFields != null)
                {
                    body["multiTextFields"] = ExpressionConverter.ConvertO(bodymultiTextFields);
                    bodypropCount++;
                }

                if (bodysingleNumberFields != null)
                {
                    body["singleNumberFields"] = ExpressionConverter.ConvertO(bodysingleNumberFields);
                    bodypropCount++;
                }

                if (bodymultiNumberFields != null)
                {
                    body["multiNumberFields"] = ExpressionConverter.ConvertO(bodymultiNumberFields);
                    bodypropCount++;
                }

                if (bodysingleBooleanFields != null)
                {
                    body["singleBooleanFields"] = ExpressionConverter.ConvertO(bodysingleBooleanFields);
                    bodypropCount++;
                }

                if (bodysingleDecimalFields != null)
                {
                    body["singleDecimalFields"] = ExpressionConverter.ConvertO(bodysingleDecimalFields);
                    bodypropCount++;
                }

                if (bodymultiDecimalFields != null)
                {
                    body["multiDecimalFields"] = ExpressionConverter.ConvertO(bodymultiDecimalFields);
                    bodypropCount++;
                }

                if (bodysingleDateFields != null)
                {
                    body["singleDateFields"] = ExpressionConverter.ConvertO(bodysingleDateFields);
                    bodypropCount++;
                }

                if (bodymultiDateFields != null)
                {
                    body["multiDateFields"] = ExpressionConverter.ConvertO(bodymultiDateFields);
                    bodypropCount++;
                }

                if (bodysingleListFields != null)
                {
                    body["singleListFields"] = ExpressionConverter.ConvertO(bodysingleListFields);
                    bodypropCount++;
                }

                if (bodysingleRelationshipFields != null)
                {
                    body["singleRelationshipFields"] = ExpressionConverter.ConvertO(bodysingleRelationshipFields);
                    bodypropCount++;
                }

                if (bodymultiRelationshipFields != null)
                {
                    body["multiRelationshipFields"] = ExpressionConverter.ConvertO(bodymultiRelationshipFields);
                    bodypropCount++;
                }

                if (bodysingleRelationshipListFields != null)
                {
                    body["singleRelationshipListFields"] = ExpressionConverter.ConvertO(bodysingleRelationshipListFields);
                    bodypropCount++;
                }

                if (bodysingleHyperlinkFields != null)
                {
                    body["singleHyperlinkFields"] = ExpressionConverter.ConvertO(bodysingleHyperlinkFields);
                    bodypropCount++;
                }

                if (bodymultiHyperlinkFields != null)
                {
                    body["multiHyperlinkFields"] = ExpressionConverter.ConvertO(bodymultiHyperlinkFields);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<IField>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateSingleHyperlinkField))]
        public IBodyWorkflowAction<IField> UpdateSingleHyperlinkField([WorkflowExpression] Func<string> dbId, [WorkflowExpression] Func<dataLanguageInput> dataLanguage, [WorkflowExpression] Func<string> topicId, [WorkflowExpression] Func<string> fieldsetId, [WorkflowExpression] Func<string> fieldId, [WorkflowExpression] Func<string> bodydata = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<IField> __BuildUpdateSingleHyperlinkField(WorkflowExpression<string> dbId, WorkflowExpression<dataLanguageInput> dataLanguage, WorkflowExpression<string> topicId, WorkflowExpression<string> fieldsetId, WorkflowExpression<string> fieldId, WorkflowExpression<string> bodydata = null)
        {
            WorkflowExpression.Validate(dbId, nameof(dbId), required: true);
            WorkflowExpression.Validate(dataLanguage, nameof(dataLanguage), required: true);
            WorkflowExpression.Validate(topicId, nameof(topicId), required: true);
            WorkflowExpression.Validate(fieldsetId, nameof(fieldsetId), required: true);
            WorkflowExpression.Validate(fieldId, nameof(fieldId), required: true);
            WorkflowExpression.Validate(bodydata, nameof(bodydata), required: false);
            return new DeferredBodyAction<IField>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/{0}/{1}/topic/{2}/fieldsets/{3}/hyperlink/{4}", ExpressionConverter.ConvertWithUrlEncoding(dbId, 1), ExpressionConverter.ConvertWithUrlEncoding(dataLanguage, 1), ExpressionConverter.ConvertWithUrlEncoding(topicId, 1), ExpressionConverter.ConvertWithUrlEncoding(fieldsetId, 1), ExpressionConverter.ConvertWithUrlEncoding(fieldId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodydata != null)
                {
                    body["data"] = ExpressionConverter.ConvertO(bodydata);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<IField>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateMultiHyperlinkField))]
        public IBodyWorkflowAction<IField> UpdateMultiHyperlinkField([WorkflowExpression] Func<string> dbId, [WorkflowExpression] Func<dataLanguageInput> dataLanguage, [WorkflowExpression] Func<string> topicId, [WorkflowExpression] Func<string> fieldsetId, [WorkflowExpression] Func<string> fieldId, [WorkflowExpression] Func<string[]> bodydata = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<IField> __BuildUpdateMultiHyperlinkField(WorkflowExpression<string> dbId, WorkflowExpression<dataLanguageInput> dataLanguage, WorkflowExpression<string> topicId, WorkflowExpression<string> fieldsetId, WorkflowExpression<string> fieldId, WorkflowExpression<string[]> bodydata = null)
        {
            WorkflowExpression.Validate(dbId, nameof(dbId), required: true);
            WorkflowExpression.Validate(dataLanguage, nameof(dataLanguage), required: true);
            WorkflowExpression.Validate(topicId, nameof(topicId), required: true);
            WorkflowExpression.Validate(fieldsetId, nameof(fieldsetId), required: true);
            WorkflowExpression.Validate(fieldId, nameof(fieldId), required: true);
            WorkflowExpression.Validate(bodydata, nameof(bodydata), required: false);
            return new DeferredBodyAction<IField>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/{0}/{1}/topic/{2}/fieldsets/{3}/multihyperlink/{4}", ExpressionConverter.ConvertWithUrlEncoding(dbId, 1), ExpressionConverter.ConvertWithUrlEncoding(dataLanguage, 1), ExpressionConverter.ConvertWithUrlEncoding(topicId, 1), ExpressionConverter.ConvertWithUrlEncoding(fieldsetId, 1), ExpressionConverter.ConvertWithUrlEncoding(fieldId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodydata != null)
                {
                    body["data"] = ExpressionConverter.ConvertO(bodydata);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<IField>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        [WorkflowExpressionFactory(nameof(__BuildMoveTopicToTop))]
        public IWorkflowAction MoveTopicToTop([WorkflowExpression] Func<string> dbId, [WorkflowExpression] Func<dataLanguageInput> dataLanguage, [WorkflowExpression] Func<string> topicId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildMoveTopicToTop(WorkflowExpression<string> dbId, WorkflowExpression<dataLanguageInput> dataLanguage, WorkflowExpression<string> topicId)
        {
            WorkflowExpression.Validate(dbId, nameof(dbId), required: true);
            WorkflowExpression.Validate(dataLanguage, nameof(dataLanguage), required: true);
            WorkflowExpression.Validate(topicId, nameof(topicId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/{0}/{1}/topic/{2}/movetotop", ExpressionConverter.ConvertWithUrlEncoding(dbId, 1), ExpressionConverter.ConvertWithUrlEncoding(dataLanguage, 1), ExpressionConverter.ConvertWithUrlEncoding(topicId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        [WorkflowExpressionFactory(nameof(__BuildMoveTopicToBottom))]
        public IWorkflowAction MoveTopicToBottom([WorkflowExpression] Func<string> dbId, [WorkflowExpression] Func<dataLanguageInput> dataLanguage, [WorkflowExpression] Func<string> topicId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildMoveTopicToBottom(WorkflowExpression<string> dbId, WorkflowExpression<dataLanguageInput> dataLanguage, WorkflowExpression<string> topicId)
        {
            WorkflowExpression.Validate(dbId, nameof(dbId), required: true);
            WorkflowExpression.Validate(dataLanguage, nameof(dataLanguage), required: true);
            WorkflowExpression.Validate(topicId, nameof(topicId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/{0}/{1}/topic/{2}/movetobottom", ExpressionConverter.ConvertWithUrlEncoding(dbId, 1), ExpressionConverter.ConvertWithUrlEncoding(dataLanguage, 1), ExpressionConverter.ConvertWithUrlEncoding(topicId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        [WorkflowExpressionFactory(nameof(__BuildMoveTopicUp))]
        public IWorkflowAction MoveTopicUp([WorkflowExpression] Func<string> dbId, [WorkflowExpression] Func<dataLanguageInput> dataLanguage, [WorkflowExpression] Func<string> topicId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildMoveTopicUp(WorkflowExpression<string> dbId, WorkflowExpression<dataLanguageInput> dataLanguage, WorkflowExpression<string> topicId)
        {
            WorkflowExpression.Validate(dbId, nameof(dbId), required: true);
            WorkflowExpression.Validate(dataLanguage, nameof(dataLanguage), required: true);
            WorkflowExpression.Validate(topicId, nameof(topicId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/{0}/{1}/topic/{2}/moveup", ExpressionConverter.ConvertWithUrlEncoding(dbId, 1), ExpressionConverter.ConvertWithUrlEncoding(dataLanguage, 1), ExpressionConverter.ConvertWithUrlEncoding(topicId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        [WorkflowExpressionFactory(nameof(__BuildMoveTopicDown))]
        public IWorkflowAction MoveTopicDown([WorkflowExpression] Func<string> dbId, [WorkflowExpression] Func<dataLanguageInput> dataLanguage, [WorkflowExpression] Func<string> topicId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildMoveTopicDown(WorkflowExpression<string> dbId, WorkflowExpression<dataLanguageInput> dataLanguage, WorkflowExpression<string> topicId)
        {
            WorkflowExpression.Validate(dbId, nameof(dbId), required: true);
            WorkflowExpression.Validate(dataLanguage, nameof(dataLanguage), required: true);
            WorkflowExpression.Validate(topicId, nameof(topicId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/{0}/{1}/topic/{2}/movedown", ExpressionConverter.ConvertWithUrlEncoding(dbId, 1), ExpressionConverter.ConvertWithUrlEncoding(dataLanguage, 1), ExpressionConverter.ConvertWithUrlEncoding(topicId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        [WorkflowExpressionFactory(nameof(__BuildMoveTopicLevelUp))]
        public IWorkflowAction MoveTopicLevelUp([WorkflowExpression] Func<string> dbId, [WorkflowExpression] Func<dataLanguageInput> dataLanguage, [WorkflowExpression] Func<string> topicId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildMoveTopicLevelUp(WorkflowExpression<string> dbId, WorkflowExpression<dataLanguageInput> dataLanguage, WorkflowExpression<string> topicId)
        {
            WorkflowExpression.Validate(dbId, nameof(dbId), required: true);
            WorkflowExpression.Validate(dataLanguage, nameof(dataLanguage), required: true);
            WorkflowExpression.Validate(topicId, nameof(topicId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/{0}/{1}/topic/{2}/movelevelup", ExpressionConverter.ConvertWithUrlEncoding(dbId, 1), ExpressionConverter.ConvertWithUrlEncoding(dataLanguage, 1), ExpressionConverter.ConvertWithUrlEncoding(topicId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        [WorkflowExpressionFactory(nameof(__BuildMoveTopicLevelDown))]
        public IWorkflowAction MoveTopicLevelDown([WorkflowExpression] Func<string> dbId, [WorkflowExpression] Func<dataLanguageInput> dataLanguage, [WorkflowExpression] Func<string> topicId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildMoveTopicLevelDown(WorkflowExpression<string> dbId, WorkflowExpression<dataLanguageInput> dataLanguage, WorkflowExpression<string> topicId)
        {
            WorkflowExpression.Validate(dbId, nameof(dbId), required: true);
            WorkflowExpression.Validate(dataLanguage, nameof(dataLanguage), required: true);
            WorkflowExpression.Validate(topicId, nameof(topicId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/{0}/{1}/topic/{2}/moveleveldown", ExpressionConverter.ConvertWithUrlEncoding(dbId, 1), ExpressionConverter.ConvertWithUrlEncoding(dataLanguage, 1), ExpressionConverter.ConvertWithUrlEncoding(topicId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        [WorkflowExpressionFactory(nameof(__BuildGetTopicRelations))]
        public IBodyWorkflowAction<IRelationship[]> GetTopicRelations([WorkflowExpression] Func<string> dbId, [WorkflowExpression] Func<dataLanguageInput> dataLanguage, [WorkflowExpression] Func<string> topicId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<IRelationship[]> __BuildGetTopicRelations(WorkflowExpression<string> dbId, WorkflowExpression<dataLanguageInput> dataLanguage, WorkflowExpression<string> topicId)
        {
            WorkflowExpression.Validate(dbId, nameof(dbId), required: true);
            WorkflowExpression.Validate(dataLanguage, nameof(dataLanguage), required: true);
            WorkflowExpression.Validate(topicId, nameof(topicId), required: true);
            return new DeferredBodyAction<IRelationship[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/{0}/{1}/topic/{2}/relations", ExpressionConverter.ConvertWithUrlEncoding(dbId, 1), ExpressionConverter.ConvertWithUrlEncoding(dataLanguage, 1), ExpressionConverter.ConvertWithUrlEncoding(topicId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<IRelationship[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        [WorkflowExpressionFactory(nameof(__BuildSaveRelation))]
        public IBodyWorkflowAction<IRelationship> SaveRelation([WorkflowExpression] Func<string> dbId, [WorkflowExpression] Func<dataLanguageInput> dataLanguage, [WorkflowExpression] Func<string> bodyfromElementDcv = null, [WorkflowExpression] Func<string> bodytoElementDcv = null, [WorkflowExpression] Func<bodyrelationshipTypeInput> bodyrelationshipType = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<IRelationship> __BuildSaveRelation(WorkflowExpression<string> dbId, WorkflowExpression<dataLanguageInput> dataLanguage, WorkflowExpression<string> bodyfromElementDcv = null, WorkflowExpression<string> bodytoElementDcv = null, WorkflowExpression<bodyrelationshipTypeInput> bodyrelationshipType = null)
        {
            WorkflowExpression.Validate(dbId, nameof(dbId), required: true);
            WorkflowExpression.Validate(dataLanguage, nameof(dataLanguage), required: true);
            WorkflowExpression.Validate(bodyfromElementDcv, nameof(bodyfromElementDcv), required: false);
            WorkflowExpression.Validate(bodytoElementDcv, nameof(bodytoElementDcv), required: false);
            WorkflowExpression.Validate(bodyrelationshipType, nameof(bodyrelationshipType), required: false);
            return new DeferredBodyAction<IRelationship>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/{0}/{1}/relation", ExpressionConverter.ConvertWithUrlEncoding(dbId, 1), ExpressionConverter.ConvertWithUrlEncoding(dataLanguage, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfromElementDcv != null)
                {
                    body["fromElementDcv"] = ExpressionConverter.ConvertO(bodyfromElementDcv);
                    bodypropCount++;
                }

                if (bodytoElementDcv != null)
                {
                    body["toElementDcv"] = ExpressionConverter.ConvertO(bodytoElementDcv);
                    bodypropCount++;
                }

                if (bodyrelationshipType != null)
                {
                    body["relationshipType"] = ExpressionConverter.ConvertO(bodyrelationshipType);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<IRelationship>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteRelation))]
        public IWorkflowAction DeleteRelation([WorkflowExpression] Func<string> dbId, [WorkflowExpression] Func<dataLanguageInput> dataLanguage, [WorkflowExpression] Func<string> topicId, [WorkflowExpression] Func<string> relationId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeleteRelation(WorkflowExpression<string> dbId, WorkflowExpression<dataLanguageInput> dataLanguage, WorkflowExpression<string> topicId, WorkflowExpression<string> relationId)
        {
            WorkflowExpression.Validate(dbId, nameof(dbId), required: true);
            WorkflowExpression.Validate(dataLanguage, nameof(dataLanguage), required: true);
            WorkflowExpression.Validate(topicId, nameof(topicId), required: true);
            WorkflowExpression.Validate(relationId, nameof(relationId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/{0}/{1}/topic/{2}/relation/{3}", ExpressionConverter.ConvertWithUrlEncoding(dbId, 1), ExpressionConverter.ConvertWithUrlEncoding(dataLanguage, 1), ExpressionConverter.ConvertWithUrlEncoding(topicId, 1), ExpressionConverter.ConvertWithUrlEncoding(relationId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        [WorkflowExpressionFactory(nameof(__BuildGetTopicRoot))]
        public IBodyWorkflowAction<ITopic> GetTopicRoot([WorkflowExpression] Func<string> dbId, [WorkflowExpression] Func<dataLanguageInput> dataLanguage)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ITopic> __BuildGetTopicRoot(WorkflowExpression<string> dbId, WorkflowExpression<dataLanguageInput> dataLanguage)
        {
            WorkflowExpression.Validate(dbId, nameof(dbId), required: true);
            WorkflowExpression.Validate(dataLanguage, nameof(dataLanguage), required: true);
            return new DeferredBodyAction<ITopic>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/{0}/{1}/root", ExpressionConverter.ConvertWithUrlEncoding(dbId, 1), ExpressionConverter.ConvertWithUrlEncoding(dataLanguage, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ITopic>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        [WorkflowExpressionFactory(nameof(__BuildGetPathToRoot))]
        public IBodyWorkflowAction<ITopicPath> GetPathToRoot([WorkflowExpression] Func<string> dbId, [WorkflowExpression] Func<dataLanguageInput> dataLanguage, [WorkflowExpression] Func<string> topicId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ITopicPath> __BuildGetPathToRoot(WorkflowExpression<string> dbId, WorkflowExpression<dataLanguageInput> dataLanguage, WorkflowExpression<string> topicId)
        {
            WorkflowExpression.Validate(dbId, nameof(dbId), required: true);
            WorkflowExpression.Validate(dataLanguage, nameof(dataLanguage), required: true);
            WorkflowExpression.Validate(topicId, nameof(topicId), required: true);
            return new DeferredBodyAction<ITopicPath>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/{0}/{1}/path/{2}", ExpressionConverter.ConvertWithUrlEncoding(dbId, 1), ExpressionConverter.ConvertWithUrlEncoding(dataLanguage, 1), ExpressionConverter.ConvertWithUrlEncoding(topicId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ITopicPath>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        [WorkflowExpressionFactory(nameof(__BuildGetTopicSiblings))]
        public IBodyWorkflowAction<ITopic[]> GetTopicSiblings([WorkflowExpression] Func<string> dbId, [WorkflowExpression] Func<dataLanguageInput> dataLanguage, [WorkflowExpression] Func<string> topicId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ITopic[]> __BuildGetTopicSiblings(WorkflowExpression<string> dbId, WorkflowExpression<dataLanguageInput> dataLanguage, WorkflowExpression<string> topicId)
        {
            WorkflowExpression.Validate(dbId, nameof(dbId), required: true);
            WorkflowExpression.Validate(dataLanguage, nameof(dataLanguage), required: true);
            WorkflowExpression.Validate(topicId, nameof(topicId), required: true);
            return new DeferredBodyAction<ITopic[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/{0}/{1}/topic/{2}/siblings", ExpressionConverter.ConvertWithUrlEncoding(dbId, 1), ExpressionConverter.ConvertWithUrlEncoding(dataLanguage, 1), ExpressionConverter.ConvertWithUrlEncoding(topicId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ITopic[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        [WorkflowExpressionFactory(nameof(__BuildGetRelationCategories))]
        public IBodyWorkflowAction<ITopic[]> GetRelationCategories([WorkflowExpression] Func<string> dbId, [WorkflowExpression] Func<dataLanguageInput> dataLanguage)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ITopic[]> __BuildGetRelationCategories(WorkflowExpression<string> dbId, WorkflowExpression<dataLanguageInput> dataLanguage)
        {
            WorkflowExpression.Validate(dbId, nameof(dbId), required: true);
            WorkflowExpression.Validate(dataLanguage, nameof(dataLanguage), required: true);
            return new DeferredBodyAction<ITopic[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/{0}/{1}/topic/categories", ExpressionConverter.ConvertWithUrlEncoding(dbId, 1), ExpressionConverter.ConvertWithUrlEncoding(dataLanguage, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ITopic[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        [WorkflowExpressionFactory(nameof(__BuildGetTopicTypes))]
        public IBodyWorkflowAction<JToken> GetTopicTypes([WorkflowExpression] Func<string> dbId, [WorkflowExpression] Func<dataLanguageInput> dataLanguage, [WorkflowExpression] Func<string> topicId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildGetTopicTypes(WorkflowExpression<string> dbId, WorkflowExpression<dataLanguageInput> dataLanguage, WorkflowExpression<string> topicId)
        {
            WorkflowExpression.Validate(dbId, nameof(dbId), required: true);
            WorkflowExpression.Validate(dataLanguage, nameof(dataLanguage), required: true);
            WorkflowExpression.Validate(topicId, nameof(topicId), required: true);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/{0}/{1}/topic/{2}/types", ExpressionConverter.ConvertWithUrlEncoding(dbId, 1), ExpressionConverter.ConvertWithUrlEncoding(dataLanguage, 1), ExpressionConverter.ConvertWithUrlEncoding(topicId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        [WorkflowExpressionFactory(nameof(__BuildGetTopicIcons))]
        public IBodyWorkflowAction<JToken> GetTopicIcons([WorkflowExpression] Func<string> dbId, [WorkflowExpression] Func<dataLanguageInput> dataLanguage, [WorkflowExpression] Func<string> topicType)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildGetTopicIcons(WorkflowExpression<string> dbId, WorkflowExpression<dataLanguageInput> dataLanguage, WorkflowExpression<string> topicType)
        {
            WorkflowExpression.Validate(dbId, nameof(dbId), required: true);
            WorkflowExpression.Validate(dataLanguage, nameof(dataLanguage), required: true);
            WorkflowExpression.Validate(topicType, nameof(topicType), required: true);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/{0}/{1}/types/{2}/icons", ExpressionConverter.ConvertWithUrlEncoding(dbId, 1), ExpressionConverter.ConvertWithUrlEncoding(dataLanguage, 1), ExpressionConverter.ConvertWithUrlEncoding(topicType, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IBodyWorkflowAction<string> Version()
        {
            var apiCallPath = "/v1/version";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string>(callPayload);
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

    public enum bodyfieldValueTypeInput
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

    public class RelationshipElement
    {
        [JsonProperty("dcv")]
        public string Dcv { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }
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

    public enum bodyrelationshipTypeInput
    {
        Unknown,
        WithWhat,
        Who,
        When,
        Where,
        Why,
        WhereTo
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