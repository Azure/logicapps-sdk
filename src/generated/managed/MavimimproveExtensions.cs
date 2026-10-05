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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<IChart[]> __BuildGetTopicCharts(WorkflowValue<string> dbId, WorkflowValue<dataLanguageInput> dataLanguage, WorkflowValue<string> topicId)
        {
            WorkflowValue.Validate(dbId, nameof(dbId), required: true);
            WorkflowValue.Validate(dataLanguage, nameof(dataLanguage), required: true);
            WorkflowValue.Validate(topicId, nameof(topicId), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ITopic> __BuildCreateTopicAfter(WorkflowValue<string> dbId, WorkflowValue<dataLanguageInput> dataLanguage, WorkflowValue<string> topicId, WorkflowValue<string> bodyname, WorkflowValue<string> bodytype, WorkflowValue<string> bodyicon)
        {
            WorkflowValue.Validate(dbId, nameof(dbId), required: true);
            WorkflowValue.Validate(dataLanguage, nameof(dataLanguage), required: true);
            WorkflowValue.Validate(topicId, nameof(topicId), required: true);
            WorkflowValue.Validate(bodyname, nameof(bodyname), required: true);
            WorkflowValue.Validate(bodytype, nameof(bodytype), required: true);
            WorkflowValue.Validate(bodyicon, nameof(bodyicon), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ITopic> __BuildDeleteTopic(WorkflowValue<string> dbId, WorkflowValue<dataLanguageInput> dataLanguage, WorkflowValue<string> topicId)
        {
            WorkflowValue.Validate(dbId, nameof(dbId), required: true);
            WorkflowValue.Validate(dataLanguage, nameof(dataLanguage), required: true);
            WorkflowValue.Validate(topicId, nameof(topicId), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ITopic> __BuildGetTopic(WorkflowValue<string> dbId, WorkflowValue<dataLanguageInput> dataLanguage, WorkflowValue<string> topicId)
        {
            WorkflowValue.Validate(dbId, nameof(dbId), required: true);
            WorkflowValue.Validate(dataLanguage, nameof(dataLanguage), required: true);
            WorkflowValue.Validate(topicId, nameof(topicId), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ITopic> __BuildUpdateTopic(WorkflowValue<string> dbId, WorkflowValue<dataLanguageInput> dataLanguage, WorkflowValue<string> topicId, WorkflowValue<string> bodyname = null)
        {
            WorkflowValue.Validate(dbId, nameof(dbId), required: true);
            WorkflowValue.Validate(dataLanguage, nameof(dataLanguage), required: true);
            WorkflowValue.Validate(topicId, nameof(topicId), required: true);
            WorkflowValue.Validate(bodyname, nameof(bodyname), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ITopic> __BuildCreateChildTopic(WorkflowValue<string> dbId, WorkflowValue<dataLanguageInput> dataLanguage, WorkflowValue<string> topicId, WorkflowValue<string> bodyname, WorkflowValue<string> bodytype, WorkflowValue<string> bodyicon)
        {
            WorkflowValue.Validate(dbId, nameof(dbId), required: true);
            WorkflowValue.Validate(dataLanguage, nameof(dataLanguage), required: true);
            WorkflowValue.Validate(topicId, nameof(topicId), required: true);
            WorkflowValue.Validate(bodyname, nameof(bodyname), required: true);
            WorkflowValue.Validate(bodytype, nameof(bodytype), required: true);
            WorkflowValue.Validate(bodyicon, nameof(bodyicon), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ITopic[]> __BuildGetTopicChildren(WorkflowValue<string> dbId, WorkflowValue<dataLanguageInput> dataLanguage, WorkflowValue<string> topicId)
        {
            WorkflowValue.Validate(dbId, nameof(dbId), required: true);
            WorkflowValue.Validate(dataLanguage, nameof(dataLanguage), required: true);
            WorkflowValue.Validate(topicId, nameof(topicId), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<IField[]> __BuildGetTopicFields(WorkflowValue<string> dbId, WorkflowValue<dataLanguageInput> dataLanguage, WorkflowValue<string> topicId)
        {
            WorkflowValue.Validate(dbId, nameof(dbId), required: true);
            WorkflowValue.Validate(dataLanguage, nameof(dataLanguage), required: true);
            WorkflowValue.Validate(topicId, nameof(topicId), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<IField> __BuildGetFieldByDcvAndFieldsetId(WorkflowValue<string> dbId, WorkflowValue<dataLanguageInput> dataLanguage, WorkflowValue<string> topicId, WorkflowValue<string> fieldsetId, WorkflowValue<string> fieldId)
        {
            WorkflowValue.Validate(dbId, nameof(dbId), required: true);
            WorkflowValue.Validate(dataLanguage, nameof(dataLanguage), required: true);
            WorkflowValue.Validate(topicId, nameof(topicId), required: true);
            WorkflowValue.Validate(fieldsetId, nameof(fieldsetId), required: true);
            WorkflowValue.Validate(fieldId, nameof(fieldId), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<IField> __BuildUpdateBooleanSingleField(WorkflowValue<string> dbId, WorkflowValue<dataLanguageInput> dataLanguage, WorkflowValue<string> topicId, WorkflowValue<string> fieldsetId, WorkflowValue<string> fieldId, WorkflowValue<string> bodyfieldsetId = null, WorkflowValue<string> bodyfieldId = null, WorkflowValue<int> bodysetOrder = null, WorkflowValue<int> bodyorder = null, WorkflowValue<string> bodytopicId = null, WorkflowValue<string> bodysetName = null, WorkflowValue<string> bodyfieldName = null, WorkflowValue<bodyfieldValueTypeInput> bodyfieldValueType = null, WorkflowValue<bool> bodyrequired = null, WorkflowValue<bool> bodyreadonly = null, WorkflowValue<string> bodyusage = null, WorkflowValue<string> bodyrelationshipCategorydcv = null, WorkflowValue<string> bodyrelationshipCategoryname = null, WorkflowValue<string> bodyrelationshipCategoryicon = null, WorkflowValue<string> bodycharacteristicdcv = null, WorkflowValue<string> bodycharacteristicname = null, WorkflowValue<string> bodycharacteristicicon = null, WorkflowValue<string> bodyopenLocation = null, WorkflowValue<bool> bodydata = null)
        {
            WorkflowValue.Validate(dbId, nameof(dbId), required: true);
            WorkflowValue.Validate(dataLanguage, nameof(dataLanguage), required: true);
            WorkflowValue.Validate(topicId, nameof(topicId), required: true);
            WorkflowValue.Validate(fieldsetId, nameof(fieldsetId), required: true);
            WorkflowValue.Validate(fieldId, nameof(fieldId), required: true);
            WorkflowValue.Validate(bodyfieldsetId, nameof(bodyfieldsetId), required: false);
            WorkflowValue.Validate(bodyfieldId, nameof(bodyfieldId), required: false);
            WorkflowValue.Validate(bodysetOrder, nameof(bodysetOrder), required: false);
            WorkflowValue.Validate(bodyorder, nameof(bodyorder), required: false);
            WorkflowValue.Validate(bodytopicId, nameof(bodytopicId), required: false);
            WorkflowValue.Validate(bodysetName, nameof(bodysetName), required: false);
            WorkflowValue.Validate(bodyfieldName, nameof(bodyfieldName), required: false);
            WorkflowValue.Validate(bodyfieldValueType, nameof(bodyfieldValueType), required: false);
            WorkflowValue.Validate(bodyrequired, nameof(bodyrequired), required: false);
            WorkflowValue.Validate(bodyreadonly, nameof(bodyreadonly), required: false);
            WorkflowValue.Validate(bodyusage, nameof(bodyusage), required: false);
            WorkflowValue.Validate(bodyrelationshipCategorydcv, nameof(bodyrelationshipCategorydcv), required: false);
            WorkflowValue.Validate(bodyrelationshipCategoryname, nameof(bodyrelationshipCategoryname), required: false);
            WorkflowValue.Validate(bodyrelationshipCategoryicon, nameof(bodyrelationshipCategoryicon), required: false);
            WorkflowValue.Validate(bodycharacteristicdcv, nameof(bodycharacteristicdcv), required: false);
            WorkflowValue.Validate(bodycharacteristicname, nameof(bodycharacteristicname), required: false);
            WorkflowValue.Validate(bodycharacteristicicon, nameof(bodycharacteristicicon), required: false);
            WorkflowValue.Validate(bodyopenLocation, nameof(bodyopenLocation), required: false);
            WorkflowValue.Validate(bodydata, nameof(bodydata), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<IField> __BuildUpdateTextSingleField(WorkflowValue<string> dbId, WorkflowValue<dataLanguageInput> dataLanguage, WorkflowValue<string> topicId, WorkflowValue<string> fieldsetId, WorkflowValue<string> fieldId, WorkflowValue<string> bodyfieldsetId = null, WorkflowValue<string> bodyfieldId = null, WorkflowValue<int> bodysetOrder = null, WorkflowValue<int> bodyorder = null, WorkflowValue<string> bodytopicId = null, WorkflowValue<string> bodysetName = null, WorkflowValue<string> bodyfieldName = null, WorkflowValue<bodyfieldValueTypeInput> bodyfieldValueType = null, WorkflowValue<bool> bodyrequired = null, WorkflowValue<bool> bodyreadonly = null, WorkflowValue<string> bodyusage = null, WorkflowValue<string> bodyrelationshipCategorydcv = null, WorkflowValue<string> bodyrelationshipCategoryname = null, WorkflowValue<string> bodyrelationshipCategoryicon = null, WorkflowValue<string> bodycharacteristicdcv = null, WorkflowValue<string> bodycharacteristicname = null, WorkflowValue<string> bodycharacteristicicon = null, WorkflowValue<string> bodyopenLocation = null, WorkflowValue<string> bodydata = null)
        {
            WorkflowValue.Validate(dbId, nameof(dbId), required: true);
            WorkflowValue.Validate(dataLanguage, nameof(dataLanguage), required: true);
            WorkflowValue.Validate(topicId, nameof(topicId), required: true);
            WorkflowValue.Validate(fieldsetId, nameof(fieldsetId), required: true);
            WorkflowValue.Validate(fieldId, nameof(fieldId), required: true);
            WorkflowValue.Validate(bodyfieldsetId, nameof(bodyfieldsetId), required: false);
            WorkflowValue.Validate(bodyfieldId, nameof(bodyfieldId), required: false);
            WorkflowValue.Validate(bodysetOrder, nameof(bodysetOrder), required: false);
            WorkflowValue.Validate(bodyorder, nameof(bodyorder), required: false);
            WorkflowValue.Validate(bodytopicId, nameof(bodytopicId), required: false);
            WorkflowValue.Validate(bodysetName, nameof(bodysetName), required: false);
            WorkflowValue.Validate(bodyfieldName, nameof(bodyfieldName), required: false);
            WorkflowValue.Validate(bodyfieldValueType, nameof(bodyfieldValueType), required: false);
            WorkflowValue.Validate(bodyrequired, nameof(bodyrequired), required: false);
            WorkflowValue.Validate(bodyreadonly, nameof(bodyreadonly), required: false);
            WorkflowValue.Validate(bodyusage, nameof(bodyusage), required: false);
            WorkflowValue.Validate(bodyrelationshipCategorydcv, nameof(bodyrelationshipCategorydcv), required: false);
            WorkflowValue.Validate(bodyrelationshipCategoryname, nameof(bodyrelationshipCategoryname), required: false);
            WorkflowValue.Validate(bodyrelationshipCategoryicon, nameof(bodyrelationshipCategoryicon), required: false);
            WorkflowValue.Validate(bodycharacteristicdcv, nameof(bodycharacteristicdcv), required: false);
            WorkflowValue.Validate(bodycharacteristicname, nameof(bodycharacteristicname), required: false);
            WorkflowValue.Validate(bodycharacteristicicon, nameof(bodycharacteristicicon), required: false);
            WorkflowValue.Validate(bodyopenLocation, nameof(bodyopenLocation), required: false);
            WorkflowValue.Validate(bodydata, nameof(bodydata), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<IField> __BuildUpdateTextMultiField(WorkflowValue<string> dbId, WorkflowValue<dataLanguageInput> dataLanguage, WorkflowValue<string> topicId, WorkflowValue<string> fieldsetId, WorkflowValue<string> fieldId, WorkflowValue<string> bodyfieldsetId = null, WorkflowValue<string> bodyfieldId = null, WorkflowValue<int> bodysetOrder = null, WorkflowValue<int> bodyorder = null, WorkflowValue<string> bodytopicId = null, WorkflowValue<string> bodysetName = null, WorkflowValue<string> bodyfieldName = null, WorkflowValue<bodyfieldValueTypeInput> bodyfieldValueType = null, WorkflowValue<bool> bodyrequired = null, WorkflowValue<bool> bodyreadonly = null, WorkflowValue<string> bodyusage = null, WorkflowValue<string> bodyrelationshipCategorydcv = null, WorkflowValue<string> bodyrelationshipCategoryname = null, WorkflowValue<string> bodyrelationshipCategoryicon = null, WorkflowValue<string> bodycharacteristicdcv = null, WorkflowValue<string> bodycharacteristicname = null, WorkflowValue<string> bodycharacteristicicon = null, WorkflowValue<string> bodyopenLocation = null, WorkflowValue<string[]> bodydata = null)
        {
            WorkflowValue.Validate(dbId, nameof(dbId), required: true);
            WorkflowValue.Validate(dataLanguage, nameof(dataLanguage), required: true);
            WorkflowValue.Validate(topicId, nameof(topicId), required: true);
            WorkflowValue.Validate(fieldsetId, nameof(fieldsetId), required: true);
            WorkflowValue.Validate(fieldId, nameof(fieldId), required: true);
            WorkflowValue.Validate(bodyfieldsetId, nameof(bodyfieldsetId), required: false);
            WorkflowValue.Validate(bodyfieldId, nameof(bodyfieldId), required: false);
            WorkflowValue.Validate(bodysetOrder, nameof(bodysetOrder), required: false);
            WorkflowValue.Validate(bodyorder, nameof(bodyorder), required: false);
            WorkflowValue.Validate(bodytopicId, nameof(bodytopicId), required: false);
            WorkflowValue.Validate(bodysetName, nameof(bodysetName), required: false);
            WorkflowValue.Validate(bodyfieldName, nameof(bodyfieldName), required: false);
            WorkflowValue.Validate(bodyfieldValueType, nameof(bodyfieldValueType), required: false);
            WorkflowValue.Validate(bodyrequired, nameof(bodyrequired), required: false);
            WorkflowValue.Validate(bodyreadonly, nameof(bodyreadonly), required: false);
            WorkflowValue.Validate(bodyusage, nameof(bodyusage), required: false);
            WorkflowValue.Validate(bodyrelationshipCategorydcv, nameof(bodyrelationshipCategorydcv), required: false);
            WorkflowValue.Validate(bodyrelationshipCategoryname, nameof(bodyrelationshipCategoryname), required: false);
            WorkflowValue.Validate(bodyrelationshipCategoryicon, nameof(bodyrelationshipCategoryicon), required: false);
            WorkflowValue.Validate(bodycharacteristicdcv, nameof(bodycharacteristicdcv), required: false);
            WorkflowValue.Validate(bodycharacteristicname, nameof(bodycharacteristicname), required: false);
            WorkflowValue.Validate(bodycharacteristicicon, nameof(bodycharacteristicicon), required: false);
            WorkflowValue.Validate(bodyopenLocation, nameof(bodyopenLocation), required: false);
            WorkflowValue.Validate(bodydata, nameof(bodydata), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<IField> __BuildUpdateNumberSingleField(WorkflowValue<string> dbId, WorkflowValue<dataLanguageInput> dataLanguage, WorkflowValue<string> topicId, WorkflowValue<string> fieldsetId, WorkflowValue<string> fieldId, WorkflowValue<string> bodyfieldsetId = null, WorkflowValue<string> bodyfieldId = null, WorkflowValue<int> bodysetOrder = null, WorkflowValue<int> bodyorder = null, WorkflowValue<string> bodytopicId = null, WorkflowValue<string> bodysetName = null, WorkflowValue<string> bodyfieldName = null, WorkflowValue<bodyfieldValueTypeInput> bodyfieldValueType = null, WorkflowValue<bool> bodyrequired = null, WorkflowValue<bool> bodyreadonly = null, WorkflowValue<string> bodyusage = null, WorkflowValue<string> bodyrelationshipCategorydcv = null, WorkflowValue<string> bodyrelationshipCategoryname = null, WorkflowValue<string> bodyrelationshipCategoryicon = null, WorkflowValue<string> bodycharacteristicdcv = null, WorkflowValue<string> bodycharacteristicname = null, WorkflowValue<string> bodycharacteristicicon = null, WorkflowValue<string> bodyopenLocation = null, WorkflowValue<int> bodydata = null)
        {
            WorkflowValue.Validate(dbId, nameof(dbId), required: true);
            WorkflowValue.Validate(dataLanguage, nameof(dataLanguage), required: true);
            WorkflowValue.Validate(topicId, nameof(topicId), required: true);
            WorkflowValue.Validate(fieldsetId, nameof(fieldsetId), required: true);
            WorkflowValue.Validate(fieldId, nameof(fieldId), required: true);
            WorkflowValue.Validate(bodyfieldsetId, nameof(bodyfieldsetId), required: false);
            WorkflowValue.Validate(bodyfieldId, nameof(bodyfieldId), required: false);
            WorkflowValue.Validate(bodysetOrder, nameof(bodysetOrder), required: false);
            WorkflowValue.Validate(bodyorder, nameof(bodyorder), required: false);
            WorkflowValue.Validate(bodytopicId, nameof(bodytopicId), required: false);
            WorkflowValue.Validate(bodysetName, nameof(bodysetName), required: false);
            WorkflowValue.Validate(bodyfieldName, nameof(bodyfieldName), required: false);
            WorkflowValue.Validate(bodyfieldValueType, nameof(bodyfieldValueType), required: false);
            WorkflowValue.Validate(bodyrequired, nameof(bodyrequired), required: false);
            WorkflowValue.Validate(bodyreadonly, nameof(bodyreadonly), required: false);
            WorkflowValue.Validate(bodyusage, nameof(bodyusage), required: false);
            WorkflowValue.Validate(bodyrelationshipCategorydcv, nameof(bodyrelationshipCategorydcv), required: false);
            WorkflowValue.Validate(bodyrelationshipCategoryname, nameof(bodyrelationshipCategoryname), required: false);
            WorkflowValue.Validate(bodyrelationshipCategoryicon, nameof(bodyrelationshipCategoryicon), required: false);
            WorkflowValue.Validate(bodycharacteristicdcv, nameof(bodycharacteristicdcv), required: false);
            WorkflowValue.Validate(bodycharacteristicname, nameof(bodycharacteristicname), required: false);
            WorkflowValue.Validate(bodycharacteristicicon, nameof(bodycharacteristicicon), required: false);
            WorkflowValue.Validate(bodyopenLocation, nameof(bodyopenLocation), required: false);
            WorkflowValue.Validate(bodydata, nameof(bodydata), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<IField> __BuildUpdateNumberMultiField(WorkflowValue<string> dbId, WorkflowValue<dataLanguageInput> dataLanguage, WorkflowValue<string> topicId, WorkflowValue<string> fieldsetId, WorkflowValue<string> fieldId, WorkflowValue<string> bodyfieldsetId = null, WorkflowValue<string> bodyfieldId = null, WorkflowValue<int> bodysetOrder = null, WorkflowValue<int> bodyorder = null, WorkflowValue<string> bodytopicId = null, WorkflowValue<string> bodysetName = null, WorkflowValue<string> bodyfieldName = null, WorkflowValue<bodyfieldValueTypeInput> bodyfieldValueType = null, WorkflowValue<bool> bodyrequired = null, WorkflowValue<bool> bodyreadonly = null, WorkflowValue<string> bodyusage = null, WorkflowValue<string> bodyrelationshipCategorydcv = null, WorkflowValue<string> bodyrelationshipCategoryname = null, WorkflowValue<string> bodyrelationshipCategoryicon = null, WorkflowValue<string> bodycharacteristicdcv = null, WorkflowValue<string> bodycharacteristicname = null, WorkflowValue<string> bodycharacteristicicon = null, WorkflowValue<string> bodyopenLocation = null, WorkflowValue<int[]> bodydata = null)
        {
            WorkflowValue.Validate(dbId, nameof(dbId), required: true);
            WorkflowValue.Validate(dataLanguage, nameof(dataLanguage), required: true);
            WorkflowValue.Validate(topicId, nameof(topicId), required: true);
            WorkflowValue.Validate(fieldsetId, nameof(fieldsetId), required: true);
            WorkflowValue.Validate(fieldId, nameof(fieldId), required: true);
            WorkflowValue.Validate(bodyfieldsetId, nameof(bodyfieldsetId), required: false);
            WorkflowValue.Validate(bodyfieldId, nameof(bodyfieldId), required: false);
            WorkflowValue.Validate(bodysetOrder, nameof(bodysetOrder), required: false);
            WorkflowValue.Validate(bodyorder, nameof(bodyorder), required: false);
            WorkflowValue.Validate(bodytopicId, nameof(bodytopicId), required: false);
            WorkflowValue.Validate(bodysetName, nameof(bodysetName), required: false);
            WorkflowValue.Validate(bodyfieldName, nameof(bodyfieldName), required: false);
            WorkflowValue.Validate(bodyfieldValueType, nameof(bodyfieldValueType), required: false);
            WorkflowValue.Validate(bodyrequired, nameof(bodyrequired), required: false);
            WorkflowValue.Validate(bodyreadonly, nameof(bodyreadonly), required: false);
            WorkflowValue.Validate(bodyusage, nameof(bodyusage), required: false);
            WorkflowValue.Validate(bodyrelationshipCategorydcv, nameof(bodyrelationshipCategorydcv), required: false);
            WorkflowValue.Validate(bodyrelationshipCategoryname, nameof(bodyrelationshipCategoryname), required: false);
            WorkflowValue.Validate(bodyrelationshipCategoryicon, nameof(bodyrelationshipCategoryicon), required: false);
            WorkflowValue.Validate(bodycharacteristicdcv, nameof(bodycharacteristicdcv), required: false);
            WorkflowValue.Validate(bodycharacteristicname, nameof(bodycharacteristicname), required: false);
            WorkflowValue.Validate(bodycharacteristicicon, nameof(bodycharacteristicicon), required: false);
            WorkflowValue.Validate(bodyopenLocation, nameof(bodyopenLocation), required: false);
            WorkflowValue.Validate(bodydata, nameof(bodydata), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<IField> __BuildUpdateDecimalSingleField(WorkflowValue<string> dbId, WorkflowValue<dataLanguageInput> dataLanguage, WorkflowValue<string> topicId, WorkflowValue<string> fieldsetId, WorkflowValue<string> fieldId, WorkflowValue<string> bodyfieldsetId = null, WorkflowValue<string> bodyfieldId = null, WorkflowValue<int> bodysetOrder = null, WorkflowValue<int> bodyorder = null, WorkflowValue<string> bodytopicId = null, WorkflowValue<string> bodysetName = null, WorkflowValue<string> bodyfieldName = null, WorkflowValue<bodyfieldValueTypeInput> bodyfieldValueType = null, WorkflowValue<bool> bodyrequired = null, WorkflowValue<bool> bodyreadonly = null, WorkflowValue<string> bodyusage = null, WorkflowValue<string> bodyrelationshipCategorydcv = null, WorkflowValue<string> bodyrelationshipCategoryname = null, WorkflowValue<string> bodyrelationshipCategoryicon = null, WorkflowValue<string> bodycharacteristicdcv = null, WorkflowValue<string> bodycharacteristicname = null, WorkflowValue<string> bodycharacteristicicon = null, WorkflowValue<string> bodyopenLocation = null, WorkflowValue<double> bodydata = null)
        {
            WorkflowValue.Validate(dbId, nameof(dbId), required: true);
            WorkflowValue.Validate(dataLanguage, nameof(dataLanguage), required: true);
            WorkflowValue.Validate(topicId, nameof(topicId), required: true);
            WorkflowValue.Validate(fieldsetId, nameof(fieldsetId), required: true);
            WorkflowValue.Validate(fieldId, nameof(fieldId), required: true);
            WorkflowValue.Validate(bodyfieldsetId, nameof(bodyfieldsetId), required: false);
            WorkflowValue.Validate(bodyfieldId, nameof(bodyfieldId), required: false);
            WorkflowValue.Validate(bodysetOrder, nameof(bodysetOrder), required: false);
            WorkflowValue.Validate(bodyorder, nameof(bodyorder), required: false);
            WorkflowValue.Validate(bodytopicId, nameof(bodytopicId), required: false);
            WorkflowValue.Validate(bodysetName, nameof(bodysetName), required: false);
            WorkflowValue.Validate(bodyfieldName, nameof(bodyfieldName), required: false);
            WorkflowValue.Validate(bodyfieldValueType, nameof(bodyfieldValueType), required: false);
            WorkflowValue.Validate(bodyrequired, nameof(bodyrequired), required: false);
            WorkflowValue.Validate(bodyreadonly, nameof(bodyreadonly), required: false);
            WorkflowValue.Validate(bodyusage, nameof(bodyusage), required: false);
            WorkflowValue.Validate(bodyrelationshipCategorydcv, nameof(bodyrelationshipCategorydcv), required: false);
            WorkflowValue.Validate(bodyrelationshipCategoryname, nameof(bodyrelationshipCategoryname), required: false);
            WorkflowValue.Validate(bodyrelationshipCategoryicon, nameof(bodyrelationshipCategoryicon), required: false);
            WorkflowValue.Validate(bodycharacteristicdcv, nameof(bodycharacteristicdcv), required: false);
            WorkflowValue.Validate(bodycharacteristicname, nameof(bodycharacteristicname), required: false);
            WorkflowValue.Validate(bodycharacteristicicon, nameof(bodycharacteristicicon), required: false);
            WorkflowValue.Validate(bodyopenLocation, nameof(bodyopenLocation), required: false);
            WorkflowValue.Validate(bodydata, nameof(bodydata), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<IField> __BuildUpdateDecimalMultiField(WorkflowValue<string> dbId, WorkflowValue<dataLanguageInput> dataLanguage, WorkflowValue<string> topicId, WorkflowValue<string> fieldsetId, WorkflowValue<string> fieldId, WorkflowValue<string> bodyfieldsetId = null, WorkflowValue<string> bodyfieldId = null, WorkflowValue<int> bodysetOrder = null, WorkflowValue<int> bodyorder = null, WorkflowValue<string> bodytopicId = null, WorkflowValue<string> bodysetName = null, WorkflowValue<string> bodyfieldName = null, WorkflowValue<bodyfieldValueTypeInput> bodyfieldValueType = null, WorkflowValue<bool> bodyrequired = null, WorkflowValue<bool> bodyreadonly = null, WorkflowValue<string> bodyusage = null, WorkflowValue<string> bodyrelationshipCategorydcv = null, WorkflowValue<string> bodyrelationshipCategoryname = null, WorkflowValue<string> bodyrelationshipCategoryicon = null, WorkflowValue<string> bodycharacteristicdcv = null, WorkflowValue<string> bodycharacteristicname = null, WorkflowValue<string> bodycharacteristicicon = null, WorkflowValue<string> bodyopenLocation = null, WorkflowValue<double[]> bodydata = null)
        {
            WorkflowValue.Validate(dbId, nameof(dbId), required: true);
            WorkflowValue.Validate(dataLanguage, nameof(dataLanguage), required: true);
            WorkflowValue.Validate(topicId, nameof(topicId), required: true);
            WorkflowValue.Validate(fieldsetId, nameof(fieldsetId), required: true);
            WorkflowValue.Validate(fieldId, nameof(fieldId), required: true);
            WorkflowValue.Validate(bodyfieldsetId, nameof(bodyfieldsetId), required: false);
            WorkflowValue.Validate(bodyfieldId, nameof(bodyfieldId), required: false);
            WorkflowValue.Validate(bodysetOrder, nameof(bodysetOrder), required: false);
            WorkflowValue.Validate(bodyorder, nameof(bodyorder), required: false);
            WorkflowValue.Validate(bodytopicId, nameof(bodytopicId), required: false);
            WorkflowValue.Validate(bodysetName, nameof(bodysetName), required: false);
            WorkflowValue.Validate(bodyfieldName, nameof(bodyfieldName), required: false);
            WorkflowValue.Validate(bodyfieldValueType, nameof(bodyfieldValueType), required: false);
            WorkflowValue.Validate(bodyrequired, nameof(bodyrequired), required: false);
            WorkflowValue.Validate(bodyreadonly, nameof(bodyreadonly), required: false);
            WorkflowValue.Validate(bodyusage, nameof(bodyusage), required: false);
            WorkflowValue.Validate(bodyrelationshipCategorydcv, nameof(bodyrelationshipCategorydcv), required: false);
            WorkflowValue.Validate(bodyrelationshipCategoryname, nameof(bodyrelationshipCategoryname), required: false);
            WorkflowValue.Validate(bodyrelationshipCategoryicon, nameof(bodyrelationshipCategoryicon), required: false);
            WorkflowValue.Validate(bodycharacteristicdcv, nameof(bodycharacteristicdcv), required: false);
            WorkflowValue.Validate(bodycharacteristicname, nameof(bodycharacteristicname), required: false);
            WorkflowValue.Validate(bodycharacteristicicon, nameof(bodycharacteristicicon), required: false);
            WorkflowValue.Validate(bodyopenLocation, nameof(bodyopenLocation), required: false);
            WorkflowValue.Validate(bodydata, nameof(bodydata), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<IField> __BuildUpdateDateSingleField(WorkflowValue<string> dbId, WorkflowValue<dataLanguageInput> dataLanguage, WorkflowValue<string> topicId, WorkflowValue<string> fieldsetId, WorkflowValue<string> fieldId, WorkflowValue<string> bodyfieldsetId = null, WorkflowValue<string> bodyfieldId = null, WorkflowValue<int> bodysetOrder = null, WorkflowValue<int> bodyorder = null, WorkflowValue<string> bodytopicId = null, WorkflowValue<string> bodysetName = null, WorkflowValue<string> bodyfieldName = null, WorkflowValue<bodyfieldValueTypeInput> bodyfieldValueType = null, WorkflowValue<bool> bodyrequired = null, WorkflowValue<bool> bodyreadonly = null, WorkflowValue<string> bodyusage = null, WorkflowValue<string> bodyrelationshipCategorydcv = null, WorkflowValue<string> bodyrelationshipCategoryname = null, WorkflowValue<string> bodyrelationshipCategoryicon = null, WorkflowValue<string> bodycharacteristicdcv = null, WorkflowValue<string> bodycharacteristicname = null, WorkflowValue<string> bodycharacteristicicon = null, WorkflowValue<string> bodyopenLocation = null, WorkflowValue<string> bodydata = null)
        {
            WorkflowValue.Validate(dbId, nameof(dbId), required: true);
            WorkflowValue.Validate(dataLanguage, nameof(dataLanguage), required: true);
            WorkflowValue.Validate(topicId, nameof(topicId), required: true);
            WorkflowValue.Validate(fieldsetId, nameof(fieldsetId), required: true);
            WorkflowValue.Validate(fieldId, nameof(fieldId), required: true);
            WorkflowValue.Validate(bodyfieldsetId, nameof(bodyfieldsetId), required: false);
            WorkflowValue.Validate(bodyfieldId, nameof(bodyfieldId), required: false);
            WorkflowValue.Validate(bodysetOrder, nameof(bodysetOrder), required: false);
            WorkflowValue.Validate(bodyorder, nameof(bodyorder), required: false);
            WorkflowValue.Validate(bodytopicId, nameof(bodytopicId), required: false);
            WorkflowValue.Validate(bodysetName, nameof(bodysetName), required: false);
            WorkflowValue.Validate(bodyfieldName, nameof(bodyfieldName), required: false);
            WorkflowValue.Validate(bodyfieldValueType, nameof(bodyfieldValueType), required: false);
            WorkflowValue.Validate(bodyrequired, nameof(bodyrequired), required: false);
            WorkflowValue.Validate(bodyreadonly, nameof(bodyreadonly), required: false);
            WorkflowValue.Validate(bodyusage, nameof(bodyusage), required: false);
            WorkflowValue.Validate(bodyrelationshipCategorydcv, nameof(bodyrelationshipCategorydcv), required: false);
            WorkflowValue.Validate(bodyrelationshipCategoryname, nameof(bodyrelationshipCategoryname), required: false);
            WorkflowValue.Validate(bodyrelationshipCategoryicon, nameof(bodyrelationshipCategoryicon), required: false);
            WorkflowValue.Validate(bodycharacteristicdcv, nameof(bodycharacteristicdcv), required: false);
            WorkflowValue.Validate(bodycharacteristicname, nameof(bodycharacteristicname), required: false);
            WorkflowValue.Validate(bodycharacteristicicon, nameof(bodycharacteristicicon), required: false);
            WorkflowValue.Validate(bodyopenLocation, nameof(bodyopenLocation), required: false);
            WorkflowValue.Validate(bodydata, nameof(bodydata), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<IField> __BuildUpdateDateMultiField(WorkflowValue<string> dbId, WorkflowValue<dataLanguageInput> dataLanguage, WorkflowValue<string> topicId, WorkflowValue<string> fieldsetId, WorkflowValue<string> fieldId, WorkflowValue<string> bodyfieldsetId = null, WorkflowValue<string> bodyfieldId = null, WorkflowValue<int> bodysetOrder = null, WorkflowValue<int> bodyorder = null, WorkflowValue<string> bodytopicId = null, WorkflowValue<string> bodysetName = null, WorkflowValue<string> bodyfieldName = null, WorkflowValue<bodyfieldValueTypeInput> bodyfieldValueType = null, WorkflowValue<bool> bodyrequired = null, WorkflowValue<bool> bodyreadonly = null, WorkflowValue<string> bodyusage = null, WorkflowValue<string> bodyrelationshipCategorydcv = null, WorkflowValue<string> bodyrelationshipCategoryname = null, WorkflowValue<string> bodyrelationshipCategoryicon = null, WorkflowValue<string> bodycharacteristicdcv = null, WorkflowValue<string> bodycharacteristicname = null, WorkflowValue<string> bodycharacteristicicon = null, WorkflowValue<string> bodyopenLocation = null, WorkflowValue<string[]> bodydata = null)
        {
            WorkflowValue.Validate(dbId, nameof(dbId), required: true);
            WorkflowValue.Validate(dataLanguage, nameof(dataLanguage), required: true);
            WorkflowValue.Validate(topicId, nameof(topicId), required: true);
            WorkflowValue.Validate(fieldsetId, nameof(fieldsetId), required: true);
            WorkflowValue.Validate(fieldId, nameof(fieldId), required: true);
            WorkflowValue.Validate(bodyfieldsetId, nameof(bodyfieldsetId), required: false);
            WorkflowValue.Validate(bodyfieldId, nameof(bodyfieldId), required: false);
            WorkflowValue.Validate(bodysetOrder, nameof(bodysetOrder), required: false);
            WorkflowValue.Validate(bodyorder, nameof(bodyorder), required: false);
            WorkflowValue.Validate(bodytopicId, nameof(bodytopicId), required: false);
            WorkflowValue.Validate(bodysetName, nameof(bodysetName), required: false);
            WorkflowValue.Validate(bodyfieldName, nameof(bodyfieldName), required: false);
            WorkflowValue.Validate(bodyfieldValueType, nameof(bodyfieldValueType), required: false);
            WorkflowValue.Validate(bodyrequired, nameof(bodyrequired), required: false);
            WorkflowValue.Validate(bodyreadonly, nameof(bodyreadonly), required: false);
            WorkflowValue.Validate(bodyusage, nameof(bodyusage), required: false);
            WorkflowValue.Validate(bodyrelationshipCategorydcv, nameof(bodyrelationshipCategorydcv), required: false);
            WorkflowValue.Validate(bodyrelationshipCategoryname, nameof(bodyrelationshipCategoryname), required: false);
            WorkflowValue.Validate(bodyrelationshipCategoryicon, nameof(bodyrelationshipCategoryicon), required: false);
            WorkflowValue.Validate(bodycharacteristicdcv, nameof(bodycharacteristicdcv), required: false);
            WorkflowValue.Validate(bodycharacteristicname, nameof(bodycharacteristicname), required: false);
            WorkflowValue.Validate(bodycharacteristicicon, nameof(bodycharacteristicicon), required: false);
            WorkflowValue.Validate(bodyopenLocation, nameof(bodyopenLocation), required: false);
            WorkflowValue.Validate(bodydata, nameof(bodydata), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<IField> __BuildUpdateListSingleField(WorkflowValue<string> dbId, WorkflowValue<dataLanguageInput> dataLanguage, WorkflowValue<string> topicId, WorkflowValue<string> fieldsetId, WorkflowValue<string> fieldId, WorkflowValue<string> bodyfieldsetId = null, WorkflowValue<string> bodyfieldId = null, WorkflowValue<int> bodysetOrder = null, WorkflowValue<int> bodyorder = null, WorkflowValue<string> bodytopicId = null, WorkflowValue<string> bodysetName = null, WorkflowValue<string> bodyfieldName = null, WorkflowValue<bodyfieldValueTypeInput> bodyfieldValueType = null, WorkflowValue<bool> bodyrequired = null, WorkflowValue<bool> bodyreadonly = null, WorkflowValue<string> bodyusage = null, WorkflowValue<string> bodyrelationshipCategorydcv = null, WorkflowValue<string> bodyrelationshipCategoryname = null, WorkflowValue<string> bodyrelationshipCategoryicon = null, WorkflowValue<string> bodycharacteristicdcv = null, WorkflowValue<string> bodycharacteristicname = null, WorkflowValue<string> bodycharacteristicicon = null, WorkflowValue<string> bodyopenLocation = null)
        {
            WorkflowValue.Validate(dbId, nameof(dbId), required: true);
            WorkflowValue.Validate(dataLanguage, nameof(dataLanguage), required: true);
            WorkflowValue.Validate(topicId, nameof(topicId), required: true);
            WorkflowValue.Validate(fieldsetId, nameof(fieldsetId), required: true);
            WorkflowValue.Validate(fieldId, nameof(fieldId), required: true);
            WorkflowValue.Validate(bodyfieldsetId, nameof(bodyfieldsetId), required: false);
            WorkflowValue.Validate(bodyfieldId, nameof(bodyfieldId), required: false);
            WorkflowValue.Validate(bodysetOrder, nameof(bodysetOrder), required: false);
            WorkflowValue.Validate(bodyorder, nameof(bodyorder), required: false);
            WorkflowValue.Validate(bodytopicId, nameof(bodytopicId), required: false);
            WorkflowValue.Validate(bodysetName, nameof(bodysetName), required: false);
            WorkflowValue.Validate(bodyfieldName, nameof(bodyfieldName), required: false);
            WorkflowValue.Validate(bodyfieldValueType, nameof(bodyfieldValueType), required: false);
            WorkflowValue.Validate(bodyrequired, nameof(bodyrequired), required: false);
            WorkflowValue.Validate(bodyreadonly, nameof(bodyreadonly), required: false);
            WorkflowValue.Validate(bodyusage, nameof(bodyusage), required: false);
            WorkflowValue.Validate(bodyrelationshipCategorydcv, nameof(bodyrelationshipCategorydcv), required: false);
            WorkflowValue.Validate(bodyrelationshipCategoryname, nameof(bodyrelationshipCategoryname), required: false);
            WorkflowValue.Validate(bodyrelationshipCategoryicon, nameof(bodyrelationshipCategoryicon), required: false);
            WorkflowValue.Validate(bodycharacteristicdcv, nameof(bodycharacteristicdcv), required: false);
            WorkflowValue.Validate(bodycharacteristicname, nameof(bodycharacteristicname), required: false);
            WorkflowValue.Validate(bodycharacteristicicon, nameof(bodycharacteristicicon), required: false);
            WorkflowValue.Validate(bodyopenLocation, nameof(bodyopenLocation), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<IField> __BuildUpdateRelationshipSingleField(WorkflowValue<string> dbId, WorkflowValue<dataLanguageInput> dataLanguage, WorkflowValue<string> topicId, WorkflowValue<string> fieldsetId, WorkflowValue<string> fieldId, WorkflowValue<string> bodyfieldId = null, WorkflowValue<string> bodyfieldsetId = null, WorkflowValue<string> bodydatadcv = null, WorkflowValue<string> bodydataname = null, WorkflowValue<string> bodydataicon = null)
        {
            WorkflowValue.Validate(dbId, nameof(dbId), required: true);
            WorkflowValue.Validate(dataLanguage, nameof(dataLanguage), required: true);
            WorkflowValue.Validate(topicId, nameof(topicId), required: true);
            WorkflowValue.Validate(fieldsetId, nameof(fieldsetId), required: true);
            WorkflowValue.Validate(fieldId, nameof(fieldId), required: true);
            WorkflowValue.Validate(bodyfieldId, nameof(bodyfieldId), required: false);
            WorkflowValue.Validate(bodyfieldsetId, nameof(bodyfieldsetId), required: false);
            WorkflowValue.Validate(bodydatadcv, nameof(bodydatadcv), required: false);
            WorkflowValue.Validate(bodydataname, nameof(bodydataname), required: false);
            WorkflowValue.Validate(bodydataicon, nameof(bodydataicon), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<IField> __BuildUpdateRelationshipMultiField(WorkflowValue<string> dbId, WorkflowValue<dataLanguageInput> dataLanguage, WorkflowValue<string> topicId, WorkflowValue<string> fieldsetId, WorkflowValue<string> fieldId, WorkflowValue<string> bodyfieldId = null, WorkflowValue<string> bodyfieldsetId = null, WorkflowValue<RelationshipElement[]> bodydata = null)
        {
            WorkflowValue.Validate(dbId, nameof(dbId), required: true);
            WorkflowValue.Validate(dataLanguage, nameof(dataLanguage), required: true);
            WorkflowValue.Validate(topicId, nameof(topicId), required: true);
            WorkflowValue.Validate(fieldsetId, nameof(fieldsetId), required: true);
            WorkflowValue.Validate(fieldId, nameof(fieldId), required: true);
            WorkflowValue.Validate(bodyfieldId, nameof(bodyfieldId), required: false);
            WorkflowValue.Validate(bodyfieldsetId, nameof(bodyfieldsetId), required: false);
            WorkflowValue.Validate(bodydata, nameof(bodydata), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<IField> __BuildUpdateRelationshipListField(WorkflowValue<string> dbId, WorkflowValue<dataLanguageInput> dataLanguage, WorkflowValue<string> topicId, WorkflowValue<string> fieldsetId, WorkflowValue<string> fieldId, WorkflowValue<string> bodyfieldId = null, WorkflowValue<string> bodyfieldsetId = null)
        {
            WorkflowValue.Validate(dbId, nameof(dbId), required: true);
            WorkflowValue.Validate(dataLanguage, nameof(dataLanguage), required: true);
            WorkflowValue.Validate(topicId, nameof(topicId), required: true);
            WorkflowValue.Validate(fieldsetId, nameof(fieldsetId), required: true);
            WorkflowValue.Validate(fieldId, nameof(fieldId), required: true);
            WorkflowValue.Validate(bodyfieldId, nameof(bodyfieldId), required: false);
            WorkflowValue.Validate(bodyfieldsetId, nameof(bodyfieldsetId), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<IField> __BuildUpdateFields(WorkflowValue<string> dbId, WorkflowValue<dataLanguageInput> dataLanguage, WorkflowValue<string> topicId, WorkflowValue<SingleTextField[]> bodysingleTextFields = null, WorkflowValue<MultiTextField[]> bodymultiTextFields = null, WorkflowValue<SingleNumberField[]> bodysingleNumberFields = null, WorkflowValue<MultiNumberField[]> bodymultiNumberFields = null, WorkflowValue<SingleBooleanField[]> bodysingleBooleanFields = null, WorkflowValue<SingleDecimalField[]> bodysingleDecimalFields = null, WorkflowValue<MultiDecimalField[]> bodymultiDecimalFields = null, WorkflowValue<SingleDateField[]> bodysingleDateFields = null, WorkflowValue<MultiDateField[]> bodymultiDateFields = null, WorkflowValue<SingleListField[]> bodysingleListFields = null, WorkflowValue<RelationshipField[]> bodysingleRelationshipFields = null, WorkflowValue<MultiRelationshipField[]> bodymultiRelationshipFields = null, WorkflowValue<RelationshipListField[]> bodysingleRelationshipListFields = null, WorkflowValue<SingleHyperlinkField[]> bodysingleHyperlinkFields = null, WorkflowValue<MultiHyperlinkField[]> bodymultiHyperlinkFields = null)
        {
            WorkflowValue.Validate(dbId, nameof(dbId), required: true);
            WorkflowValue.Validate(dataLanguage, nameof(dataLanguage), required: true);
            WorkflowValue.Validate(topicId, nameof(topicId), required: true);
            WorkflowValue.Validate(bodysingleTextFields, nameof(bodysingleTextFields), required: false);
            WorkflowValue.Validate(bodymultiTextFields, nameof(bodymultiTextFields), required: false);
            WorkflowValue.Validate(bodysingleNumberFields, nameof(bodysingleNumberFields), required: false);
            WorkflowValue.Validate(bodymultiNumberFields, nameof(bodymultiNumberFields), required: false);
            WorkflowValue.Validate(bodysingleBooleanFields, nameof(bodysingleBooleanFields), required: false);
            WorkflowValue.Validate(bodysingleDecimalFields, nameof(bodysingleDecimalFields), required: false);
            WorkflowValue.Validate(bodymultiDecimalFields, nameof(bodymultiDecimalFields), required: false);
            WorkflowValue.Validate(bodysingleDateFields, nameof(bodysingleDateFields), required: false);
            WorkflowValue.Validate(bodymultiDateFields, nameof(bodymultiDateFields), required: false);
            WorkflowValue.Validate(bodysingleListFields, nameof(bodysingleListFields), required: false);
            WorkflowValue.Validate(bodysingleRelationshipFields, nameof(bodysingleRelationshipFields), required: false);
            WorkflowValue.Validate(bodymultiRelationshipFields, nameof(bodymultiRelationshipFields), required: false);
            WorkflowValue.Validate(bodysingleRelationshipListFields, nameof(bodysingleRelationshipListFields), required: false);
            WorkflowValue.Validate(bodysingleHyperlinkFields, nameof(bodysingleHyperlinkFields), required: false);
            WorkflowValue.Validate(bodymultiHyperlinkFields, nameof(bodymultiHyperlinkFields), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<IField> __BuildUpdateSingleHyperlinkField(WorkflowValue<string> dbId, WorkflowValue<dataLanguageInput> dataLanguage, WorkflowValue<string> topicId, WorkflowValue<string> fieldsetId, WorkflowValue<string> fieldId, WorkflowValue<string> bodydata = null)
        {
            WorkflowValue.Validate(dbId, nameof(dbId), required: true);
            WorkflowValue.Validate(dataLanguage, nameof(dataLanguage), required: true);
            WorkflowValue.Validate(topicId, nameof(topicId), required: true);
            WorkflowValue.Validate(fieldsetId, nameof(fieldsetId), required: true);
            WorkflowValue.Validate(fieldId, nameof(fieldId), required: true);
            WorkflowValue.Validate(bodydata, nameof(bodydata), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<IField> __BuildUpdateMultiHyperlinkField(WorkflowValue<string> dbId, WorkflowValue<dataLanguageInput> dataLanguage, WorkflowValue<string> topicId, WorkflowValue<string> fieldsetId, WorkflowValue<string> fieldId, WorkflowValue<string[]> bodydata = null)
        {
            WorkflowValue.Validate(dbId, nameof(dbId), required: true);
            WorkflowValue.Validate(dataLanguage, nameof(dataLanguage), required: true);
            WorkflowValue.Validate(topicId, nameof(topicId), required: true);
            WorkflowValue.Validate(fieldsetId, nameof(fieldsetId), required: true);
            WorkflowValue.Validate(fieldId, nameof(fieldId), required: true);
            WorkflowValue.Validate(bodydata, nameof(bodydata), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildMoveTopicToTop(WorkflowValue<string> dbId, WorkflowValue<dataLanguageInput> dataLanguage, WorkflowValue<string> topicId)
        {
            WorkflowValue.Validate(dbId, nameof(dbId), required: true);
            WorkflowValue.Validate(dataLanguage, nameof(dataLanguage), required: true);
            WorkflowValue.Validate(topicId, nameof(topicId), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildMoveTopicToBottom(WorkflowValue<string> dbId, WorkflowValue<dataLanguageInput> dataLanguage, WorkflowValue<string> topicId)
        {
            WorkflowValue.Validate(dbId, nameof(dbId), required: true);
            WorkflowValue.Validate(dataLanguage, nameof(dataLanguage), required: true);
            WorkflowValue.Validate(topicId, nameof(topicId), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildMoveTopicUp(WorkflowValue<string> dbId, WorkflowValue<dataLanguageInput> dataLanguage, WorkflowValue<string> topicId)
        {
            WorkflowValue.Validate(dbId, nameof(dbId), required: true);
            WorkflowValue.Validate(dataLanguage, nameof(dataLanguage), required: true);
            WorkflowValue.Validate(topicId, nameof(topicId), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildMoveTopicDown(WorkflowValue<string> dbId, WorkflowValue<dataLanguageInput> dataLanguage, WorkflowValue<string> topicId)
        {
            WorkflowValue.Validate(dbId, nameof(dbId), required: true);
            WorkflowValue.Validate(dataLanguage, nameof(dataLanguage), required: true);
            WorkflowValue.Validate(topicId, nameof(topicId), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildMoveTopicLevelUp(WorkflowValue<string> dbId, WorkflowValue<dataLanguageInput> dataLanguage, WorkflowValue<string> topicId)
        {
            WorkflowValue.Validate(dbId, nameof(dbId), required: true);
            WorkflowValue.Validate(dataLanguage, nameof(dataLanguage), required: true);
            WorkflowValue.Validate(topicId, nameof(topicId), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildMoveTopicLevelDown(WorkflowValue<string> dbId, WorkflowValue<dataLanguageInput> dataLanguage, WorkflowValue<string> topicId)
        {
            WorkflowValue.Validate(dbId, nameof(dbId), required: true);
            WorkflowValue.Validate(dataLanguage, nameof(dataLanguage), required: true);
            WorkflowValue.Validate(topicId, nameof(topicId), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<IRelationship[]> __BuildGetTopicRelations(WorkflowValue<string> dbId, WorkflowValue<dataLanguageInput> dataLanguage, WorkflowValue<string> topicId)
        {
            WorkflowValue.Validate(dbId, nameof(dbId), required: true);
            WorkflowValue.Validate(dataLanguage, nameof(dataLanguage), required: true);
            WorkflowValue.Validate(topicId, nameof(topicId), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<IRelationship> __BuildSaveRelation(WorkflowValue<string> dbId, WorkflowValue<dataLanguageInput> dataLanguage, WorkflowValue<string> bodyfromElementDcv = null, WorkflowValue<string> bodytoElementDcv = null, WorkflowValue<bodyrelationshipTypeInput> bodyrelationshipType = null)
        {
            WorkflowValue.Validate(dbId, nameof(dbId), required: true);
            WorkflowValue.Validate(dataLanguage, nameof(dataLanguage), required: true);
            WorkflowValue.Validate(bodyfromElementDcv, nameof(bodyfromElementDcv), required: false);
            WorkflowValue.Validate(bodytoElementDcv, nameof(bodytoElementDcv), required: false);
            WorkflowValue.Validate(bodyrelationshipType, nameof(bodyrelationshipType), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeleteRelation(WorkflowValue<string> dbId, WorkflowValue<dataLanguageInput> dataLanguage, WorkflowValue<string> topicId, WorkflowValue<string> relationId)
        {
            WorkflowValue.Validate(dbId, nameof(dbId), required: true);
            WorkflowValue.Validate(dataLanguage, nameof(dataLanguage), required: true);
            WorkflowValue.Validate(topicId, nameof(topicId), required: true);
            WorkflowValue.Validate(relationId, nameof(relationId), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ITopic> __BuildGetTopicRoot(WorkflowValue<string> dbId, WorkflowValue<dataLanguageInput> dataLanguage)
        {
            WorkflowValue.Validate(dbId, nameof(dbId), required: true);
            WorkflowValue.Validate(dataLanguage, nameof(dataLanguage), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ITopicPath> __BuildGetPathToRoot(WorkflowValue<string> dbId, WorkflowValue<dataLanguageInput> dataLanguage, WorkflowValue<string> topicId)
        {
            WorkflowValue.Validate(dbId, nameof(dbId), required: true);
            WorkflowValue.Validate(dataLanguage, nameof(dataLanguage), required: true);
            WorkflowValue.Validate(topicId, nameof(topicId), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ITopic[]> __BuildGetTopicSiblings(WorkflowValue<string> dbId, WorkflowValue<dataLanguageInput> dataLanguage, WorkflowValue<string> topicId)
        {
            WorkflowValue.Validate(dbId, nameof(dbId), required: true);
            WorkflowValue.Validate(dataLanguage, nameof(dataLanguage), required: true);
            WorkflowValue.Validate(topicId, nameof(topicId), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ITopic[]> __BuildGetRelationCategories(WorkflowValue<string> dbId, WorkflowValue<dataLanguageInput> dataLanguage)
        {
            WorkflowValue.Validate(dbId, nameof(dbId), required: true);
            WorkflowValue.Validate(dataLanguage, nameof(dataLanguage), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildGetTopicTypes(WorkflowValue<string> dbId, WorkflowValue<dataLanguageInput> dataLanguage, WorkflowValue<string> topicId)
        {
            WorkflowValue.Validate(dbId, nameof(dbId), required: true);
            WorkflowValue.Validate(dataLanguage, nameof(dataLanguage), required: true);
            WorkflowValue.Validate(topicId, nameof(topicId), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildGetTopicIcons(WorkflowValue<string> dbId, WorkflowValue<dataLanguageInput> dataLanguage, WorkflowValue<string> topicType)
        {
            WorkflowValue.Validate(dbId, nameof(dbId), required: true);
            WorkflowValue.Validate(dataLanguage, nameof(dataLanguage), required: true);
            WorkflowValue.Validate(topicType, nameof(topicType), required: true);
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
