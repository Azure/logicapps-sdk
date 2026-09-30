//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Mavimimprove
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class MavimimproveActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IBodyWorkflowAction<IChart[]> GetTopicCharts([WorkflowExpression] Func<string> dbId, [WorkflowExpression] Func<dataLanguageInput> dataLanguage, [WorkflowExpression] Func<string> topicId)
        {
            SourceExpression.Validate(dbId, nameof(dbId), required: true);
            SourceExpression.Validate(dataLanguage, nameof(dataLanguage), required: true);
            SourceExpression.Validate(topicId, nameof(topicId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/{0}/{1}/topic/{2}/charts", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dbId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataLanguage, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(topicId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<IChart[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IBodyWorkflowAction<ITopic> CreateTopicAfter([WorkflowExpression] Func<string> dbId, [WorkflowExpression] Func<dataLanguageInput> dataLanguage, [WorkflowExpression] Func<string> topicId, [WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<string> bodytype, [WorkflowExpression] Func<string> bodyicon)
        {
            SourceExpression.Validate(dbId, nameof(dbId), required: true);
            SourceExpression.Validate(dataLanguage, nameof(dataLanguage), required: true);
            SourceExpression.Validate(topicId, nameof(topicId), required: true);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: true);
            SourceExpression.Validate(bodytype, nameof(bodytype), required: true);
            SourceExpression.Validate(bodyicon, nameof(bodyicon), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/{0}/{1}/topic/{2}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dbId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataLanguage, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(topicId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                bodypropCount++;
                body["type"] = SourceExpressionConverter.ConvertToken(bodytype);
                bodypropCount++;
                body["icon"] = SourceExpressionConverter.ConvertToken(bodyicon);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ITopic>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IBodyWorkflowAction<ITopic> DeleteTopic([WorkflowExpression] Func<string> dbId, [WorkflowExpression] Func<dataLanguageInput> dataLanguage, [WorkflowExpression] Func<string> topicId)
        {
            SourceExpression.Validate(dbId, nameof(dbId), required: true);
            SourceExpression.Validate(dataLanguage, nameof(dataLanguage), required: true);
            SourceExpression.Validate(topicId, nameof(topicId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/{0}/{1}/topic/{2}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dbId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataLanguage, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(topicId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ITopic>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IBodyWorkflowAction<ITopic> GetTopic([WorkflowExpression] Func<string> dbId, [WorkflowExpression] Func<dataLanguageInput> dataLanguage, [WorkflowExpression] Func<string> topicId)
        {
            SourceExpression.Validate(dbId, nameof(dbId), required: true);
            SourceExpression.Validate(dataLanguage, nameof(dataLanguage), required: true);
            SourceExpression.Validate(topicId, nameof(topicId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/{0}/{1}/topic/{2}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dbId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataLanguage, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(topicId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ITopic>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IBodyWorkflowAction<ITopic> UpdateTopic([WorkflowExpression] Func<string> dbId, [WorkflowExpression] Func<dataLanguageInput> dataLanguage, [WorkflowExpression] Func<string> topicId, [WorkflowExpression] Func<string> bodyname = null)
        {
            SourceExpression.Validate(dbId, nameof(dbId), required: true);
            SourceExpression.Validate(dataLanguage, nameof(dataLanguage), required: true);
            SourceExpression.Validate(topicId, nameof(topicId), required: true);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/{0}/{1}/topic/{2}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dbId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataLanguage, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(topicId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ITopic>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IBodyWorkflowAction<ITopic> CreateChildTopic([WorkflowExpression] Func<string> dbId, [WorkflowExpression] Func<dataLanguageInput> dataLanguage, [WorkflowExpression] Func<string> topicId, [WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<string> bodytype, [WorkflowExpression] Func<string> bodyicon)
        {
            SourceExpression.Validate(dbId, nameof(dbId), required: true);
            SourceExpression.Validate(dataLanguage, nameof(dataLanguage), required: true);
            SourceExpression.Validate(topicId, nameof(topicId), required: true);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: true);
            SourceExpression.Validate(bodytype, nameof(bodytype), required: true);
            SourceExpression.Validate(bodyicon, nameof(bodyicon), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/{0}/{1}/topic/{2}/children", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dbId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataLanguage, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(topicId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                bodypropCount++;
                body["type"] = SourceExpressionConverter.ConvertToken(bodytype);
                bodypropCount++;
                body["icon"] = SourceExpressionConverter.ConvertToken(bodyicon);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ITopic>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IBodyWorkflowAction<ITopic[]> GetTopicChildren([WorkflowExpression] Func<string> dbId, [WorkflowExpression] Func<dataLanguageInput> dataLanguage, [WorkflowExpression] Func<string> topicId)
        {
            SourceExpression.Validate(dbId, nameof(dbId), required: true);
            SourceExpression.Validate(dataLanguage, nameof(dataLanguage), required: true);
            SourceExpression.Validate(topicId, nameof(topicId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/{0}/{1}/topic/{2}/children", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dbId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataLanguage, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(topicId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ITopic[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IBodyWorkflowAction<IField[]> GetTopicFields([WorkflowExpression] Func<string> dbId, [WorkflowExpression] Func<dataLanguageInput> dataLanguage, [WorkflowExpression] Func<string> topicId)
        {
            SourceExpression.Validate(dbId, nameof(dbId), required: true);
            SourceExpression.Validate(dataLanguage, nameof(dataLanguage), required: true);
            SourceExpression.Validate(topicId, nameof(topicId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/{0}/{1}/topic/{2}/fieldsets", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dbId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataLanguage, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(topicId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<IField[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IBodyWorkflowAction<IField> GetFieldByDcvAndFieldsetId([WorkflowExpression] Func<string> dbId, [WorkflowExpression] Func<dataLanguageInput> dataLanguage, [WorkflowExpression] Func<string> topicId, [WorkflowExpression] Func<string> fieldsetId, [WorkflowExpression] Func<string> fieldId)
        {
            SourceExpression.Validate(dbId, nameof(dbId), required: true);
            SourceExpression.Validate(dataLanguage, nameof(dataLanguage), required: true);
            SourceExpression.Validate(topicId, nameof(topicId), required: true);
            SourceExpression.Validate(fieldsetId, nameof(fieldsetId), required: true);
            SourceExpression.Validate(fieldId, nameof(fieldId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/{0}/{1}/topic/{2}/fieldsets/{3}/{4}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dbId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataLanguage, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(topicId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(fieldsetId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(fieldId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<IField>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IBodyWorkflowAction<IField> UpdateBooleanSingleField([WorkflowExpression] Func<string> dbId, [WorkflowExpression] Func<dataLanguageInput> dataLanguage, [WorkflowExpression] Func<string> topicId, [WorkflowExpression] Func<string> fieldsetId, [WorkflowExpression] Func<string> fieldId, [WorkflowExpression] Func<string> bodyfieldsetId = null, [WorkflowExpression] Func<string> bodyfieldId = null, [WorkflowExpression] Func<int> bodysetOrder = null, [WorkflowExpression] Func<int> bodyorder = null, [WorkflowExpression] Func<string> bodytopicId = null, [WorkflowExpression] Func<string> bodysetName = null, [WorkflowExpression] Func<string> bodyfieldName = null, [WorkflowExpression] Func<bodyfieldValueTypeInput> bodyfieldValueType = null, [WorkflowExpression] Func<bool> bodyRequired = null, [WorkflowExpression] Func<bool> bodyReadonly = null, [WorkflowExpression] Func<string> bodyusage = null, [WorkflowExpression] Func<string> bodyrelationshipCategorydcv = null, [WorkflowExpression] Func<string> bodyrelationshipCategoryname = null, [WorkflowExpression] Func<string> bodyrelationshipCategoryicon = null, [WorkflowExpression] Func<string> bodycharacteristicdcv = null, [WorkflowExpression] Func<string> bodycharacteristicname = null, [WorkflowExpression] Func<string> bodycharacteristicicon = null, [WorkflowExpression] Func<string> bodyopenLocation = null, [WorkflowExpression] Func<bool> bodydata = null)
        {
            SourceExpression.Validate(dbId, nameof(dbId), required: true);
            SourceExpression.Validate(dataLanguage, nameof(dataLanguage), required: true);
            SourceExpression.Validate(topicId, nameof(topicId), required: true);
            SourceExpression.Validate(fieldsetId, nameof(fieldsetId), required: true);
            SourceExpression.Validate(fieldId, nameof(fieldId), required: true);
            SourceExpression.Validate(bodyfieldsetId, nameof(bodyfieldsetId), required: false);
            SourceExpression.Validate(bodyfieldId, nameof(bodyfieldId), required: false);
            SourceExpression.Validate(bodysetOrder, nameof(bodysetOrder), required: false);
            SourceExpression.Validate(bodyorder, nameof(bodyorder), required: false);
            SourceExpression.Validate(bodytopicId, nameof(bodytopicId), required: false);
            SourceExpression.Validate(bodysetName, nameof(bodysetName), required: false);
            SourceExpression.Validate(bodyfieldName, nameof(bodyfieldName), required: false);
            SourceExpression.Validate(bodyfieldValueType, nameof(bodyfieldValueType), required: false);
            SourceExpression.Validate(bodyRequired, nameof(bodyRequired), required: false);
            SourceExpression.Validate(bodyReadonly, nameof(bodyReadonly), required: false);
            SourceExpression.Validate(bodyusage, nameof(bodyusage), required: false);
            SourceExpression.Validate(bodyrelationshipCategorydcv, nameof(bodyrelationshipCategorydcv), required: false);
            SourceExpression.Validate(bodyrelationshipCategoryname, nameof(bodyrelationshipCategoryname), required: false);
            SourceExpression.Validate(bodyrelationshipCategoryicon, nameof(bodyrelationshipCategoryicon), required: false);
            SourceExpression.Validate(bodycharacteristicdcv, nameof(bodycharacteristicdcv), required: false);
            SourceExpression.Validate(bodycharacteristicname, nameof(bodycharacteristicname), required: false);
            SourceExpression.Validate(bodycharacteristicicon, nameof(bodycharacteristicicon), required: false);
            SourceExpression.Validate(bodyopenLocation, nameof(bodyopenLocation), required: false);
            SourceExpression.Validate(bodydata, nameof(bodydata), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/{0}/{1}/topic/{2}/fieldsets/{3}/bool/{4}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dbId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataLanguage, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(topicId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(fieldsetId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(fieldId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfieldsetId != null)
                {
                    body["fieldsetId"] = SourceExpressionConverter.ConvertToken(bodyfieldsetId);
                    bodypropCount++;
                }

                if (bodyfieldId != null)
                {
                    body["fieldId"] = SourceExpressionConverter.ConvertToken(bodyfieldId);
                    bodypropCount++;
                }

                if (bodysetOrder != null)
                {
                    body["setOrder"] = SourceExpressionConverter.ConvertToken(bodysetOrder);
                    bodypropCount++;
                }

                if (bodyorder != null)
                {
                    body["order"] = SourceExpressionConverter.ConvertToken(bodyorder);
                    bodypropCount++;
                }

                if (bodytopicId != null)
                {
                    body["topicId"] = SourceExpressionConverter.ConvertToken(bodytopicId);
                    bodypropCount++;
                }

                if (bodysetName != null)
                {
                    body["setName"] = SourceExpressionConverter.ConvertToken(bodysetName);
                    bodypropCount++;
                }

                if (bodyfieldName != null)
                {
                    body["fieldName"] = SourceExpressionConverter.ConvertToken(bodyfieldName);
                    bodypropCount++;
                }

                if (bodyfieldValueType != null)
                {
                    body["fieldValueType"] = SourceExpressionConverter.Convert(bodyfieldValueType);
                    bodypropCount++;
                }

                if (bodyRequired != null)
                {
                    body["required"] = SourceExpressionConverter.ConvertToken(bodyRequired);
                    bodypropCount++;
                }

                if (bodyReadonly != null)
                {
                    body["readonly"] = SourceExpressionConverter.ConvertToken(bodyReadonly);
                    bodypropCount++;
                }

                if (bodyusage != null)
                {
                    body["usage"] = SourceExpressionConverter.ConvertToken(bodyusage);
                    bodypropCount++;
                }

                var relationshipCategoryObject = new JObject();
                var relationshipCategoryObjectpropCount = 0;
                if (bodyrelationshipCategorydcv != null)
                {
                    relationshipCategoryObject["dcv"] = SourceExpressionConverter.ConvertToken(bodyrelationshipCategorydcv);
                    relationshipCategoryObjectpropCount++;
                }

                if (bodyrelationshipCategoryname != null)
                {
                    relationshipCategoryObject["name"] = SourceExpressionConverter.ConvertToken(bodyrelationshipCategoryname);
                    relationshipCategoryObjectpropCount++;
                }

                if (bodyrelationshipCategoryicon != null)
                {
                    relationshipCategoryObject["icon"] = SourceExpressionConverter.ConvertToken(bodyrelationshipCategoryicon);
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
                    characteristicObject["dcv"] = SourceExpressionConverter.ConvertToken(bodyrelationshipCategorydcv);
                    characteristicObjectpropCount++;
                }

                if (bodyrelationshipCategoryname != null)
                {
                    characteristicObject["name"] = SourceExpressionConverter.ConvertToken(bodyrelationshipCategoryname);
                    characteristicObjectpropCount++;
                }

                if (bodyrelationshipCategoryicon != null)
                {
                    characteristicObject["icon"] = SourceExpressionConverter.ConvertToken(bodyrelationshipCategoryicon);
                    characteristicObjectpropCount++;
                }

                if (characteristicObjectpropCount > 0)
                {
                    body["characteristic"] = characteristicObject;
                    bodypropCount++;
                }

                if (bodyopenLocation != null)
                {
                    body["openLocation"] = SourceExpressionConverter.ConvertToken(bodyopenLocation);
                    bodypropCount++;
                }

                if (bodydata != null)
                {
                    body["data"] = SourceExpressionConverter.ConvertToken(bodydata);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<IField>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IBodyWorkflowAction<IField> UpdateTextSingleField([WorkflowExpression] Func<string> dbId, [WorkflowExpression] Func<dataLanguageInput> dataLanguage, [WorkflowExpression] Func<string> topicId, [WorkflowExpression] Func<string> fieldsetId, [WorkflowExpression] Func<string> fieldId, [WorkflowExpression] Func<string> bodyfieldsetId = null, [WorkflowExpression] Func<string> bodyfieldId = null, [WorkflowExpression] Func<int> bodysetOrder = null, [WorkflowExpression] Func<int> bodyorder = null, [WorkflowExpression] Func<string> bodytopicId = null, [WorkflowExpression] Func<string> bodysetName = null, [WorkflowExpression] Func<string> bodyfieldName = null, [WorkflowExpression] Func<bodyfieldValueTypeInput> bodyfieldValueType = null, [WorkflowExpression] Func<bool> bodyRequired = null, [WorkflowExpression] Func<bool> bodyReadonly = null, [WorkflowExpression] Func<string> bodyusage = null, [WorkflowExpression] Func<string> bodyrelationshipCategorydcv = null, [WorkflowExpression] Func<string> bodyrelationshipCategoryname = null, [WorkflowExpression] Func<string> bodyrelationshipCategoryicon = null, [WorkflowExpression] Func<string> bodycharacteristicdcv = null, [WorkflowExpression] Func<string> bodycharacteristicname = null, [WorkflowExpression] Func<string> bodycharacteristicicon = null, [WorkflowExpression] Func<string> bodyopenLocation = null, [WorkflowExpression] Func<string> bodydata = null)
        {
            SourceExpression.Validate(dbId, nameof(dbId), required: true);
            SourceExpression.Validate(dataLanguage, nameof(dataLanguage), required: true);
            SourceExpression.Validate(topicId, nameof(topicId), required: true);
            SourceExpression.Validate(fieldsetId, nameof(fieldsetId), required: true);
            SourceExpression.Validate(fieldId, nameof(fieldId), required: true);
            SourceExpression.Validate(bodyfieldsetId, nameof(bodyfieldsetId), required: false);
            SourceExpression.Validate(bodyfieldId, nameof(bodyfieldId), required: false);
            SourceExpression.Validate(bodysetOrder, nameof(bodysetOrder), required: false);
            SourceExpression.Validate(bodyorder, nameof(bodyorder), required: false);
            SourceExpression.Validate(bodytopicId, nameof(bodytopicId), required: false);
            SourceExpression.Validate(bodysetName, nameof(bodysetName), required: false);
            SourceExpression.Validate(bodyfieldName, nameof(bodyfieldName), required: false);
            SourceExpression.Validate(bodyfieldValueType, nameof(bodyfieldValueType), required: false);
            SourceExpression.Validate(bodyRequired, nameof(bodyRequired), required: false);
            SourceExpression.Validate(bodyReadonly, nameof(bodyReadonly), required: false);
            SourceExpression.Validate(bodyusage, nameof(bodyusage), required: false);
            SourceExpression.Validate(bodyrelationshipCategorydcv, nameof(bodyrelationshipCategorydcv), required: false);
            SourceExpression.Validate(bodyrelationshipCategoryname, nameof(bodyrelationshipCategoryname), required: false);
            SourceExpression.Validate(bodyrelationshipCategoryicon, nameof(bodyrelationshipCategoryicon), required: false);
            SourceExpression.Validate(bodycharacteristicdcv, nameof(bodycharacteristicdcv), required: false);
            SourceExpression.Validate(bodycharacteristicname, nameof(bodycharacteristicname), required: false);
            SourceExpression.Validate(bodycharacteristicicon, nameof(bodycharacteristicicon), required: false);
            SourceExpression.Validate(bodyopenLocation, nameof(bodyopenLocation), required: false);
            SourceExpression.Validate(bodydata, nameof(bodydata), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/{0}/{1}/topic/{2}/fieldsets/{3}/text/{4}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dbId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataLanguage, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(topicId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(fieldsetId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(fieldId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfieldsetId != null)
                {
                    body["fieldsetId"] = SourceExpressionConverter.ConvertToken(bodyfieldsetId);
                    bodypropCount++;
                }

                if (bodyfieldId != null)
                {
                    body["fieldId"] = SourceExpressionConverter.ConvertToken(bodyfieldId);
                    bodypropCount++;
                }

                if (bodysetOrder != null)
                {
                    body["setOrder"] = SourceExpressionConverter.ConvertToken(bodysetOrder);
                    bodypropCount++;
                }

                if (bodyorder != null)
                {
                    body["order"] = SourceExpressionConverter.ConvertToken(bodyorder);
                    bodypropCount++;
                }

                if (bodytopicId != null)
                {
                    body["topicId"] = SourceExpressionConverter.ConvertToken(bodytopicId);
                    bodypropCount++;
                }

                if (bodysetName != null)
                {
                    body["setName"] = SourceExpressionConverter.ConvertToken(bodysetName);
                    bodypropCount++;
                }

                if (bodyfieldName != null)
                {
                    body["fieldName"] = SourceExpressionConverter.ConvertToken(bodyfieldName);
                    bodypropCount++;
                }

                if (bodyfieldValueType != null)
                {
                    body["fieldValueType"] = SourceExpressionConverter.Convert(bodyfieldValueType);
                    bodypropCount++;
                }

                if (bodyRequired != null)
                {
                    body["required"] = SourceExpressionConverter.ConvertToken(bodyRequired);
                    bodypropCount++;
                }

                if (bodyReadonly != null)
                {
                    body["readonly"] = SourceExpressionConverter.ConvertToken(bodyReadonly);
                    bodypropCount++;
                }

                if (bodyusage != null)
                {
                    body["usage"] = SourceExpressionConverter.ConvertToken(bodyusage);
                    bodypropCount++;
                }

                var relationshipCategoryObject = new JObject();
                var relationshipCategoryObjectpropCount = 0;
                if (bodyrelationshipCategorydcv != null)
                {
                    relationshipCategoryObject["dcv"] = SourceExpressionConverter.ConvertToken(bodyrelationshipCategorydcv);
                    relationshipCategoryObjectpropCount++;
                }

                if (bodyrelationshipCategoryname != null)
                {
                    relationshipCategoryObject["name"] = SourceExpressionConverter.ConvertToken(bodyrelationshipCategoryname);
                    relationshipCategoryObjectpropCount++;
                }

                if (bodyrelationshipCategoryicon != null)
                {
                    relationshipCategoryObject["icon"] = SourceExpressionConverter.ConvertToken(bodyrelationshipCategoryicon);
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
                    characteristicObject["dcv"] = SourceExpressionConverter.ConvertToken(bodyrelationshipCategorydcv);
                    characteristicObjectpropCount++;
                }

                if (bodyrelationshipCategoryname != null)
                {
                    characteristicObject["name"] = SourceExpressionConverter.ConvertToken(bodyrelationshipCategoryname);
                    characteristicObjectpropCount++;
                }

                if (bodyrelationshipCategoryicon != null)
                {
                    characteristicObject["icon"] = SourceExpressionConverter.ConvertToken(bodyrelationshipCategoryicon);
                    characteristicObjectpropCount++;
                }

                if (characteristicObjectpropCount > 0)
                {
                    body["characteristic"] = characteristicObject;
                    bodypropCount++;
                }

                if (bodyopenLocation != null)
                {
                    body["openLocation"] = SourceExpressionConverter.ConvertToken(bodyopenLocation);
                    bodypropCount++;
                }

                if (bodydata != null)
                {
                    body["data"] = SourceExpressionConverter.ConvertToken(bodydata);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<IField>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IBodyWorkflowAction<IField> UpdateTextMultiField([WorkflowExpression] Func<string> dbId, [WorkflowExpression] Func<dataLanguageInput> dataLanguage, [WorkflowExpression] Func<string> topicId, [WorkflowExpression] Func<string> fieldsetId, [WorkflowExpression] Func<string> fieldId, [WorkflowExpression] Func<string> bodyfieldsetId = null, [WorkflowExpression] Func<string> bodyfieldId = null, [WorkflowExpression] Func<int> bodysetOrder = null, [WorkflowExpression] Func<int> bodyorder = null, [WorkflowExpression] Func<string> bodytopicId = null, [WorkflowExpression] Func<string> bodysetName = null, [WorkflowExpression] Func<string> bodyfieldName = null, [WorkflowExpression] Func<bodyfieldValueTypeInput> bodyfieldValueType = null, [WorkflowExpression] Func<bool> bodyRequired = null, [WorkflowExpression] Func<bool> bodyReadonly = null, [WorkflowExpression] Func<string> bodyusage = null, [WorkflowExpression] Func<string> bodyrelationshipCategorydcv = null, [WorkflowExpression] Func<string> bodyrelationshipCategoryname = null, [WorkflowExpression] Func<string> bodyrelationshipCategoryicon = null, [WorkflowExpression] Func<string> bodycharacteristicdcv = null, [WorkflowExpression] Func<string> bodycharacteristicname = null, [WorkflowExpression] Func<string> bodycharacteristicicon = null, [WorkflowExpression] Func<string> bodyopenLocation = null, [WorkflowExpression] Func<string[]> bodydata = null)
        {
            SourceExpression.Validate(dbId, nameof(dbId), required: true);
            SourceExpression.Validate(dataLanguage, nameof(dataLanguage), required: true);
            SourceExpression.Validate(topicId, nameof(topicId), required: true);
            SourceExpression.Validate(fieldsetId, nameof(fieldsetId), required: true);
            SourceExpression.Validate(fieldId, nameof(fieldId), required: true);
            SourceExpression.Validate(bodyfieldsetId, nameof(bodyfieldsetId), required: false);
            SourceExpression.Validate(bodyfieldId, nameof(bodyfieldId), required: false);
            SourceExpression.Validate(bodysetOrder, nameof(bodysetOrder), required: false);
            SourceExpression.Validate(bodyorder, nameof(bodyorder), required: false);
            SourceExpression.Validate(bodytopicId, nameof(bodytopicId), required: false);
            SourceExpression.Validate(bodysetName, nameof(bodysetName), required: false);
            SourceExpression.Validate(bodyfieldName, nameof(bodyfieldName), required: false);
            SourceExpression.Validate(bodyfieldValueType, nameof(bodyfieldValueType), required: false);
            SourceExpression.Validate(bodyRequired, nameof(bodyRequired), required: false);
            SourceExpression.Validate(bodyReadonly, nameof(bodyReadonly), required: false);
            SourceExpression.Validate(bodyusage, nameof(bodyusage), required: false);
            SourceExpression.Validate(bodyrelationshipCategorydcv, nameof(bodyrelationshipCategorydcv), required: false);
            SourceExpression.Validate(bodyrelationshipCategoryname, nameof(bodyrelationshipCategoryname), required: false);
            SourceExpression.Validate(bodyrelationshipCategoryicon, nameof(bodyrelationshipCategoryicon), required: false);
            SourceExpression.Validate(bodycharacteristicdcv, nameof(bodycharacteristicdcv), required: false);
            SourceExpression.Validate(bodycharacteristicname, nameof(bodycharacteristicname), required: false);
            SourceExpression.Validate(bodycharacteristicicon, nameof(bodycharacteristicicon), required: false);
            SourceExpression.Validate(bodyopenLocation, nameof(bodyopenLocation), required: false);
            SourceExpression.Validate(bodydata, nameof(bodydata), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/{0}/{1}/topic/{2}/fieldsets/{3}/multitext/{4}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dbId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataLanguage, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(topicId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(fieldsetId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(fieldId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfieldsetId != null)
                {
                    body["fieldsetId"] = SourceExpressionConverter.ConvertToken(bodyfieldsetId);
                    bodypropCount++;
                }

                if (bodyfieldId != null)
                {
                    body["fieldId"] = SourceExpressionConverter.ConvertToken(bodyfieldId);
                    bodypropCount++;
                }

                if (bodysetOrder != null)
                {
                    body["setOrder"] = SourceExpressionConverter.ConvertToken(bodysetOrder);
                    bodypropCount++;
                }

                if (bodyorder != null)
                {
                    body["order"] = SourceExpressionConverter.ConvertToken(bodyorder);
                    bodypropCount++;
                }

                if (bodytopicId != null)
                {
                    body["topicId"] = SourceExpressionConverter.ConvertToken(bodytopicId);
                    bodypropCount++;
                }

                if (bodysetName != null)
                {
                    body["setName"] = SourceExpressionConverter.ConvertToken(bodysetName);
                    bodypropCount++;
                }

                if (bodyfieldName != null)
                {
                    body["fieldName"] = SourceExpressionConverter.ConvertToken(bodyfieldName);
                    bodypropCount++;
                }

                if (bodyfieldValueType != null)
                {
                    body["fieldValueType"] = SourceExpressionConverter.Convert(bodyfieldValueType);
                    bodypropCount++;
                }

                if (bodyRequired != null)
                {
                    body["required"] = SourceExpressionConverter.ConvertToken(bodyRequired);
                    bodypropCount++;
                }

                if (bodyReadonly != null)
                {
                    body["readonly"] = SourceExpressionConverter.ConvertToken(bodyReadonly);
                    bodypropCount++;
                }

                if (bodyusage != null)
                {
                    body["usage"] = SourceExpressionConverter.ConvertToken(bodyusage);
                    bodypropCount++;
                }

                var relationshipCategoryObject = new JObject();
                var relationshipCategoryObjectpropCount = 0;
                if (bodyrelationshipCategorydcv != null)
                {
                    relationshipCategoryObject["dcv"] = SourceExpressionConverter.ConvertToken(bodyrelationshipCategorydcv);
                    relationshipCategoryObjectpropCount++;
                }

                if (bodyrelationshipCategoryname != null)
                {
                    relationshipCategoryObject["name"] = SourceExpressionConverter.ConvertToken(bodyrelationshipCategoryname);
                    relationshipCategoryObjectpropCount++;
                }

                if (bodyrelationshipCategoryicon != null)
                {
                    relationshipCategoryObject["icon"] = SourceExpressionConverter.ConvertToken(bodyrelationshipCategoryicon);
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
                    characteristicObject["dcv"] = SourceExpressionConverter.ConvertToken(bodyrelationshipCategorydcv);
                    characteristicObjectpropCount++;
                }

                if (bodyrelationshipCategoryname != null)
                {
                    characteristicObject["name"] = SourceExpressionConverter.ConvertToken(bodyrelationshipCategoryname);
                    characteristicObjectpropCount++;
                }

                if (bodyrelationshipCategoryicon != null)
                {
                    characteristicObject["icon"] = SourceExpressionConverter.ConvertToken(bodyrelationshipCategoryicon);
                    characteristicObjectpropCount++;
                }

                if (characteristicObjectpropCount > 0)
                {
                    body["characteristic"] = characteristicObject;
                    bodypropCount++;
                }

                if (bodyopenLocation != null)
                {
                    body["openLocation"] = SourceExpressionConverter.ConvertToken(bodyopenLocation);
                    bodypropCount++;
                }

                if (bodydata != null)
                {
                    body["data"] = SourceExpressionConverter.ConvertToken(bodydata);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<IField>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IBodyWorkflowAction<IField> UpdateNumberSingleField([WorkflowExpression] Func<string> dbId, [WorkflowExpression] Func<dataLanguageInput> dataLanguage, [WorkflowExpression] Func<string> topicId, [WorkflowExpression] Func<string> fieldsetId, [WorkflowExpression] Func<string> fieldId, [WorkflowExpression] Func<string> bodyfieldsetId = null, [WorkflowExpression] Func<string> bodyfieldId = null, [WorkflowExpression] Func<int> bodysetOrder = null, [WorkflowExpression] Func<int> bodyorder = null, [WorkflowExpression] Func<string> bodytopicId = null, [WorkflowExpression] Func<string> bodysetName = null, [WorkflowExpression] Func<string> bodyfieldName = null, [WorkflowExpression] Func<bodyfieldValueTypeInput> bodyfieldValueType = null, [WorkflowExpression] Func<bool> bodyRequired = null, [WorkflowExpression] Func<bool> bodyReadonly = null, [WorkflowExpression] Func<string> bodyusage = null, [WorkflowExpression] Func<string> bodyrelationshipCategorydcv = null, [WorkflowExpression] Func<string> bodyrelationshipCategoryname = null, [WorkflowExpression] Func<string> bodyrelationshipCategoryicon = null, [WorkflowExpression] Func<string> bodycharacteristicdcv = null, [WorkflowExpression] Func<string> bodycharacteristicname = null, [WorkflowExpression] Func<string> bodycharacteristicicon = null, [WorkflowExpression] Func<string> bodyopenLocation = null, [WorkflowExpression] Func<int> bodydata = null)
        {
            SourceExpression.Validate(dbId, nameof(dbId), required: true);
            SourceExpression.Validate(dataLanguage, nameof(dataLanguage), required: true);
            SourceExpression.Validate(topicId, nameof(topicId), required: true);
            SourceExpression.Validate(fieldsetId, nameof(fieldsetId), required: true);
            SourceExpression.Validate(fieldId, nameof(fieldId), required: true);
            SourceExpression.Validate(bodyfieldsetId, nameof(bodyfieldsetId), required: false);
            SourceExpression.Validate(bodyfieldId, nameof(bodyfieldId), required: false);
            SourceExpression.Validate(bodysetOrder, nameof(bodysetOrder), required: false);
            SourceExpression.Validate(bodyorder, nameof(bodyorder), required: false);
            SourceExpression.Validate(bodytopicId, nameof(bodytopicId), required: false);
            SourceExpression.Validate(bodysetName, nameof(bodysetName), required: false);
            SourceExpression.Validate(bodyfieldName, nameof(bodyfieldName), required: false);
            SourceExpression.Validate(bodyfieldValueType, nameof(bodyfieldValueType), required: false);
            SourceExpression.Validate(bodyRequired, nameof(bodyRequired), required: false);
            SourceExpression.Validate(bodyReadonly, nameof(bodyReadonly), required: false);
            SourceExpression.Validate(bodyusage, nameof(bodyusage), required: false);
            SourceExpression.Validate(bodyrelationshipCategorydcv, nameof(bodyrelationshipCategorydcv), required: false);
            SourceExpression.Validate(bodyrelationshipCategoryname, nameof(bodyrelationshipCategoryname), required: false);
            SourceExpression.Validate(bodyrelationshipCategoryicon, nameof(bodyrelationshipCategoryicon), required: false);
            SourceExpression.Validate(bodycharacteristicdcv, nameof(bodycharacteristicdcv), required: false);
            SourceExpression.Validate(bodycharacteristicname, nameof(bodycharacteristicname), required: false);
            SourceExpression.Validate(bodycharacteristicicon, nameof(bodycharacteristicicon), required: false);
            SourceExpression.Validate(bodyopenLocation, nameof(bodyopenLocation), required: false);
            SourceExpression.Validate(bodydata, nameof(bodydata), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/{0}/{1}/topic/{2}/fieldsets/{3}/number/{4}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dbId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataLanguage, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(topicId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(fieldsetId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(fieldId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfieldsetId != null)
                {
                    body["fieldsetId"] = SourceExpressionConverter.ConvertToken(bodyfieldsetId);
                    bodypropCount++;
                }

                if (bodyfieldId != null)
                {
                    body["fieldId"] = SourceExpressionConverter.ConvertToken(bodyfieldId);
                    bodypropCount++;
                }

                if (bodysetOrder != null)
                {
                    body["setOrder"] = SourceExpressionConverter.ConvertToken(bodysetOrder);
                    bodypropCount++;
                }

                if (bodyorder != null)
                {
                    body["order"] = SourceExpressionConverter.ConvertToken(bodyorder);
                    bodypropCount++;
                }

                if (bodytopicId != null)
                {
                    body["topicId"] = SourceExpressionConverter.ConvertToken(bodytopicId);
                    bodypropCount++;
                }

                if (bodysetName != null)
                {
                    body["setName"] = SourceExpressionConverter.ConvertToken(bodysetName);
                    bodypropCount++;
                }

                if (bodyfieldName != null)
                {
                    body["fieldName"] = SourceExpressionConverter.ConvertToken(bodyfieldName);
                    bodypropCount++;
                }

                if (bodyfieldValueType != null)
                {
                    body["fieldValueType"] = SourceExpressionConverter.Convert(bodyfieldValueType);
                    bodypropCount++;
                }

                if (bodyRequired != null)
                {
                    body["required"] = SourceExpressionConverter.ConvertToken(bodyRequired);
                    bodypropCount++;
                }

                if (bodyReadonly != null)
                {
                    body["readonly"] = SourceExpressionConverter.ConvertToken(bodyReadonly);
                    bodypropCount++;
                }

                if (bodyusage != null)
                {
                    body["usage"] = SourceExpressionConverter.ConvertToken(bodyusage);
                    bodypropCount++;
                }

                var relationshipCategoryObject = new JObject();
                var relationshipCategoryObjectpropCount = 0;
                if (bodyrelationshipCategorydcv != null)
                {
                    relationshipCategoryObject["dcv"] = SourceExpressionConverter.ConvertToken(bodyrelationshipCategorydcv);
                    relationshipCategoryObjectpropCount++;
                }

                if (bodyrelationshipCategoryname != null)
                {
                    relationshipCategoryObject["name"] = SourceExpressionConverter.ConvertToken(bodyrelationshipCategoryname);
                    relationshipCategoryObjectpropCount++;
                }

                if (bodyrelationshipCategoryicon != null)
                {
                    relationshipCategoryObject["icon"] = SourceExpressionConverter.ConvertToken(bodyrelationshipCategoryicon);
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
                    characteristicObject["dcv"] = SourceExpressionConverter.ConvertToken(bodyrelationshipCategorydcv);
                    characteristicObjectpropCount++;
                }

                if (bodyrelationshipCategoryname != null)
                {
                    characteristicObject["name"] = SourceExpressionConverter.ConvertToken(bodyrelationshipCategoryname);
                    characteristicObjectpropCount++;
                }

                if (bodyrelationshipCategoryicon != null)
                {
                    characteristicObject["icon"] = SourceExpressionConverter.ConvertToken(bodyrelationshipCategoryicon);
                    characteristicObjectpropCount++;
                }

                if (characteristicObjectpropCount > 0)
                {
                    body["characteristic"] = characteristicObject;
                    bodypropCount++;
                }

                if (bodyopenLocation != null)
                {
                    body["openLocation"] = SourceExpressionConverter.ConvertToken(bodyopenLocation);
                    bodypropCount++;
                }

                if (bodydata != null)
                {
                    body["data"] = SourceExpressionConverter.ConvertToken(bodydata);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<IField>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IBodyWorkflowAction<IField> UpdateNumberMultiField([WorkflowExpression] Func<string> dbId, [WorkflowExpression] Func<dataLanguageInput> dataLanguage, [WorkflowExpression] Func<string> topicId, [WorkflowExpression] Func<string> fieldsetId, [WorkflowExpression] Func<string> fieldId, [WorkflowExpression] Func<string> bodyfieldsetId = null, [WorkflowExpression] Func<string> bodyfieldId = null, [WorkflowExpression] Func<int> bodysetOrder = null, [WorkflowExpression] Func<int> bodyorder = null, [WorkflowExpression] Func<string> bodytopicId = null, [WorkflowExpression] Func<string> bodysetName = null, [WorkflowExpression] Func<string> bodyfieldName = null, [WorkflowExpression] Func<bodyfieldValueTypeInput> bodyfieldValueType = null, [WorkflowExpression] Func<bool> bodyRequired = null, [WorkflowExpression] Func<bool> bodyReadonly = null, [WorkflowExpression] Func<string> bodyusage = null, [WorkflowExpression] Func<string> bodyrelationshipCategorydcv = null, [WorkflowExpression] Func<string> bodyrelationshipCategoryname = null, [WorkflowExpression] Func<string> bodyrelationshipCategoryicon = null, [WorkflowExpression] Func<string> bodycharacteristicdcv = null, [WorkflowExpression] Func<string> bodycharacteristicname = null, [WorkflowExpression] Func<string> bodycharacteristicicon = null, [WorkflowExpression] Func<string> bodyopenLocation = null, [WorkflowExpression] Func<int[]> bodydata = null)
        {
            SourceExpression.Validate(dbId, nameof(dbId), required: true);
            SourceExpression.Validate(dataLanguage, nameof(dataLanguage), required: true);
            SourceExpression.Validate(topicId, nameof(topicId), required: true);
            SourceExpression.Validate(fieldsetId, nameof(fieldsetId), required: true);
            SourceExpression.Validate(fieldId, nameof(fieldId), required: true);
            SourceExpression.Validate(bodyfieldsetId, nameof(bodyfieldsetId), required: false);
            SourceExpression.Validate(bodyfieldId, nameof(bodyfieldId), required: false);
            SourceExpression.Validate(bodysetOrder, nameof(bodysetOrder), required: false);
            SourceExpression.Validate(bodyorder, nameof(bodyorder), required: false);
            SourceExpression.Validate(bodytopicId, nameof(bodytopicId), required: false);
            SourceExpression.Validate(bodysetName, nameof(bodysetName), required: false);
            SourceExpression.Validate(bodyfieldName, nameof(bodyfieldName), required: false);
            SourceExpression.Validate(bodyfieldValueType, nameof(bodyfieldValueType), required: false);
            SourceExpression.Validate(bodyRequired, nameof(bodyRequired), required: false);
            SourceExpression.Validate(bodyReadonly, nameof(bodyReadonly), required: false);
            SourceExpression.Validate(bodyusage, nameof(bodyusage), required: false);
            SourceExpression.Validate(bodyrelationshipCategorydcv, nameof(bodyrelationshipCategorydcv), required: false);
            SourceExpression.Validate(bodyrelationshipCategoryname, nameof(bodyrelationshipCategoryname), required: false);
            SourceExpression.Validate(bodyrelationshipCategoryicon, nameof(bodyrelationshipCategoryicon), required: false);
            SourceExpression.Validate(bodycharacteristicdcv, nameof(bodycharacteristicdcv), required: false);
            SourceExpression.Validate(bodycharacteristicname, nameof(bodycharacteristicname), required: false);
            SourceExpression.Validate(bodycharacteristicicon, nameof(bodycharacteristicicon), required: false);
            SourceExpression.Validate(bodyopenLocation, nameof(bodyopenLocation), required: false);
            SourceExpression.Validate(bodydata, nameof(bodydata), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/{0}/{1}/topic/{2}/fieldsets/{3}/multinumber/{4}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dbId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataLanguage, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(topicId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(fieldsetId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(fieldId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfieldsetId != null)
                {
                    body["fieldsetId"] = SourceExpressionConverter.ConvertToken(bodyfieldsetId);
                    bodypropCount++;
                }

                if (bodyfieldId != null)
                {
                    body["fieldId"] = SourceExpressionConverter.ConvertToken(bodyfieldId);
                    bodypropCount++;
                }

                if (bodysetOrder != null)
                {
                    body["setOrder"] = SourceExpressionConverter.ConvertToken(bodysetOrder);
                    bodypropCount++;
                }

                if (bodyorder != null)
                {
                    body["order"] = SourceExpressionConverter.ConvertToken(bodyorder);
                    bodypropCount++;
                }

                if (bodytopicId != null)
                {
                    body["topicId"] = SourceExpressionConverter.ConvertToken(bodytopicId);
                    bodypropCount++;
                }

                if (bodysetName != null)
                {
                    body["setName"] = SourceExpressionConverter.ConvertToken(bodysetName);
                    bodypropCount++;
                }

                if (bodyfieldName != null)
                {
                    body["fieldName"] = SourceExpressionConverter.ConvertToken(bodyfieldName);
                    bodypropCount++;
                }

                if (bodyfieldValueType != null)
                {
                    body["fieldValueType"] = SourceExpressionConverter.Convert(bodyfieldValueType);
                    bodypropCount++;
                }

                if (bodyRequired != null)
                {
                    body["required"] = SourceExpressionConverter.ConvertToken(bodyRequired);
                    bodypropCount++;
                }

                if (bodyReadonly != null)
                {
                    body["readonly"] = SourceExpressionConverter.ConvertToken(bodyReadonly);
                    bodypropCount++;
                }

                if (bodyusage != null)
                {
                    body["usage"] = SourceExpressionConverter.ConvertToken(bodyusage);
                    bodypropCount++;
                }

                var relationshipCategoryObject = new JObject();
                var relationshipCategoryObjectpropCount = 0;
                if (bodyrelationshipCategorydcv != null)
                {
                    relationshipCategoryObject["dcv"] = SourceExpressionConverter.ConvertToken(bodyrelationshipCategorydcv);
                    relationshipCategoryObjectpropCount++;
                }

                if (bodyrelationshipCategoryname != null)
                {
                    relationshipCategoryObject["name"] = SourceExpressionConverter.ConvertToken(bodyrelationshipCategoryname);
                    relationshipCategoryObjectpropCount++;
                }

                if (bodyrelationshipCategoryicon != null)
                {
                    relationshipCategoryObject["icon"] = SourceExpressionConverter.ConvertToken(bodyrelationshipCategoryicon);
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
                    characteristicObject["dcv"] = SourceExpressionConverter.ConvertToken(bodyrelationshipCategorydcv);
                    characteristicObjectpropCount++;
                }

                if (bodyrelationshipCategoryname != null)
                {
                    characteristicObject["name"] = SourceExpressionConverter.ConvertToken(bodyrelationshipCategoryname);
                    characteristicObjectpropCount++;
                }

                if (bodyrelationshipCategoryicon != null)
                {
                    characteristicObject["icon"] = SourceExpressionConverter.ConvertToken(bodyrelationshipCategoryicon);
                    characteristicObjectpropCount++;
                }

                if (characteristicObjectpropCount > 0)
                {
                    body["characteristic"] = characteristicObject;
                    bodypropCount++;
                }

                if (bodyopenLocation != null)
                {
                    body["openLocation"] = SourceExpressionConverter.ConvertToken(bodyopenLocation);
                    bodypropCount++;
                }

                if (bodydata != null)
                {
                    body["data"] = SourceExpressionConverter.ConvertToken(bodydata);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<IField>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IBodyWorkflowAction<IField> UpdateDecimalSingleField([WorkflowExpression] Func<string> dbId, [WorkflowExpression] Func<dataLanguageInput> dataLanguage, [WorkflowExpression] Func<string> topicId, [WorkflowExpression] Func<string> fieldsetId, [WorkflowExpression] Func<string> fieldId, [WorkflowExpression] Func<string> bodyfieldsetId = null, [WorkflowExpression] Func<string> bodyfieldId = null, [WorkflowExpression] Func<int> bodysetOrder = null, [WorkflowExpression] Func<int> bodyorder = null, [WorkflowExpression] Func<string> bodytopicId = null, [WorkflowExpression] Func<string> bodysetName = null, [WorkflowExpression] Func<string> bodyfieldName = null, [WorkflowExpression] Func<bodyfieldValueTypeInput> bodyfieldValueType = null, [WorkflowExpression] Func<bool> bodyRequired = null, [WorkflowExpression] Func<bool> bodyReadonly = null, [WorkflowExpression] Func<string> bodyusage = null, [WorkflowExpression] Func<string> bodyrelationshipCategorydcv = null, [WorkflowExpression] Func<string> bodyrelationshipCategoryname = null, [WorkflowExpression] Func<string> bodyrelationshipCategoryicon = null, [WorkflowExpression] Func<string> bodycharacteristicdcv = null, [WorkflowExpression] Func<string> bodycharacteristicname = null, [WorkflowExpression] Func<string> bodycharacteristicicon = null, [WorkflowExpression] Func<string> bodyopenLocation = null, [WorkflowExpression] Func<double> bodydata = null)
        {
            SourceExpression.Validate(dbId, nameof(dbId), required: true);
            SourceExpression.Validate(dataLanguage, nameof(dataLanguage), required: true);
            SourceExpression.Validate(topicId, nameof(topicId), required: true);
            SourceExpression.Validate(fieldsetId, nameof(fieldsetId), required: true);
            SourceExpression.Validate(fieldId, nameof(fieldId), required: true);
            SourceExpression.Validate(bodyfieldsetId, nameof(bodyfieldsetId), required: false);
            SourceExpression.Validate(bodyfieldId, nameof(bodyfieldId), required: false);
            SourceExpression.Validate(bodysetOrder, nameof(bodysetOrder), required: false);
            SourceExpression.Validate(bodyorder, nameof(bodyorder), required: false);
            SourceExpression.Validate(bodytopicId, nameof(bodytopicId), required: false);
            SourceExpression.Validate(bodysetName, nameof(bodysetName), required: false);
            SourceExpression.Validate(bodyfieldName, nameof(bodyfieldName), required: false);
            SourceExpression.Validate(bodyfieldValueType, nameof(bodyfieldValueType), required: false);
            SourceExpression.Validate(bodyRequired, nameof(bodyRequired), required: false);
            SourceExpression.Validate(bodyReadonly, nameof(bodyReadonly), required: false);
            SourceExpression.Validate(bodyusage, nameof(bodyusage), required: false);
            SourceExpression.Validate(bodyrelationshipCategorydcv, nameof(bodyrelationshipCategorydcv), required: false);
            SourceExpression.Validate(bodyrelationshipCategoryname, nameof(bodyrelationshipCategoryname), required: false);
            SourceExpression.Validate(bodyrelationshipCategoryicon, nameof(bodyrelationshipCategoryicon), required: false);
            SourceExpression.Validate(bodycharacteristicdcv, nameof(bodycharacteristicdcv), required: false);
            SourceExpression.Validate(bodycharacteristicname, nameof(bodycharacteristicname), required: false);
            SourceExpression.Validate(bodycharacteristicicon, nameof(bodycharacteristicicon), required: false);
            SourceExpression.Validate(bodyopenLocation, nameof(bodyopenLocation), required: false);
            SourceExpression.Validate(bodydata, nameof(bodydata), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/{0}/{1}/topic/{2}/fieldsets/{3}/decimal/{4}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dbId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataLanguage, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(topicId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(fieldsetId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(fieldId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfieldsetId != null)
                {
                    body["fieldsetId"] = SourceExpressionConverter.ConvertToken(bodyfieldsetId);
                    bodypropCount++;
                }

                if (bodyfieldId != null)
                {
                    body["fieldId"] = SourceExpressionConverter.ConvertToken(bodyfieldId);
                    bodypropCount++;
                }

                if (bodysetOrder != null)
                {
                    body["setOrder"] = SourceExpressionConverter.ConvertToken(bodysetOrder);
                    bodypropCount++;
                }

                if (bodyorder != null)
                {
                    body["order"] = SourceExpressionConverter.ConvertToken(bodyorder);
                    bodypropCount++;
                }

                if (bodytopicId != null)
                {
                    body["topicId"] = SourceExpressionConverter.ConvertToken(bodytopicId);
                    bodypropCount++;
                }

                if (bodysetName != null)
                {
                    body["setName"] = SourceExpressionConverter.ConvertToken(bodysetName);
                    bodypropCount++;
                }

                if (bodyfieldName != null)
                {
                    body["fieldName"] = SourceExpressionConverter.ConvertToken(bodyfieldName);
                    bodypropCount++;
                }

                if (bodyfieldValueType != null)
                {
                    body["fieldValueType"] = SourceExpressionConverter.Convert(bodyfieldValueType);
                    bodypropCount++;
                }

                if (bodyRequired != null)
                {
                    body["required"] = SourceExpressionConverter.ConvertToken(bodyRequired);
                    bodypropCount++;
                }

                if (bodyReadonly != null)
                {
                    body["readonly"] = SourceExpressionConverter.ConvertToken(bodyReadonly);
                    bodypropCount++;
                }

                if (bodyusage != null)
                {
                    body["usage"] = SourceExpressionConverter.ConvertToken(bodyusage);
                    bodypropCount++;
                }

                var relationshipCategoryObject = new JObject();
                var relationshipCategoryObjectpropCount = 0;
                if (bodyrelationshipCategorydcv != null)
                {
                    relationshipCategoryObject["dcv"] = SourceExpressionConverter.ConvertToken(bodyrelationshipCategorydcv);
                    relationshipCategoryObjectpropCount++;
                }

                if (bodyrelationshipCategoryname != null)
                {
                    relationshipCategoryObject["name"] = SourceExpressionConverter.ConvertToken(bodyrelationshipCategoryname);
                    relationshipCategoryObjectpropCount++;
                }

                if (bodyrelationshipCategoryicon != null)
                {
                    relationshipCategoryObject["icon"] = SourceExpressionConverter.ConvertToken(bodyrelationshipCategoryicon);
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
                    characteristicObject["dcv"] = SourceExpressionConverter.ConvertToken(bodyrelationshipCategorydcv);
                    characteristicObjectpropCount++;
                }

                if (bodyrelationshipCategoryname != null)
                {
                    characteristicObject["name"] = SourceExpressionConverter.ConvertToken(bodyrelationshipCategoryname);
                    characteristicObjectpropCount++;
                }

                if (bodyrelationshipCategoryicon != null)
                {
                    characteristicObject["icon"] = SourceExpressionConverter.ConvertToken(bodyrelationshipCategoryicon);
                    characteristicObjectpropCount++;
                }

                if (characteristicObjectpropCount > 0)
                {
                    body["characteristic"] = characteristicObject;
                    bodypropCount++;
                }

                if (bodyopenLocation != null)
                {
                    body["openLocation"] = SourceExpressionConverter.ConvertToken(bodyopenLocation);
                    bodypropCount++;
                }

                if (bodydata != null)
                {
                    body["data"] = SourceExpressionConverter.ConvertToken(bodydata);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<IField>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IBodyWorkflowAction<IField> UpdateDecimalMultiField([WorkflowExpression] Func<string> dbId, [WorkflowExpression] Func<dataLanguageInput> dataLanguage, [WorkflowExpression] Func<string> topicId, [WorkflowExpression] Func<string> fieldsetId, [WorkflowExpression] Func<string> fieldId, [WorkflowExpression] Func<string> bodyfieldsetId = null, [WorkflowExpression] Func<string> bodyfieldId = null, [WorkflowExpression] Func<int> bodysetOrder = null, [WorkflowExpression] Func<int> bodyorder = null, [WorkflowExpression] Func<string> bodytopicId = null, [WorkflowExpression] Func<string> bodysetName = null, [WorkflowExpression] Func<string> bodyfieldName = null, [WorkflowExpression] Func<bodyfieldValueTypeInput> bodyfieldValueType = null, [WorkflowExpression] Func<bool> bodyRequired = null, [WorkflowExpression] Func<bool> bodyReadonly = null, [WorkflowExpression] Func<string> bodyusage = null, [WorkflowExpression] Func<string> bodyrelationshipCategorydcv = null, [WorkflowExpression] Func<string> bodyrelationshipCategoryname = null, [WorkflowExpression] Func<string> bodyrelationshipCategoryicon = null, [WorkflowExpression] Func<string> bodycharacteristicdcv = null, [WorkflowExpression] Func<string> bodycharacteristicname = null, [WorkflowExpression] Func<string> bodycharacteristicicon = null, [WorkflowExpression] Func<string> bodyopenLocation = null, [WorkflowExpression] Func<double[]> bodydata = null)
        {
            SourceExpression.Validate(dbId, nameof(dbId), required: true);
            SourceExpression.Validate(dataLanguage, nameof(dataLanguage), required: true);
            SourceExpression.Validate(topicId, nameof(topicId), required: true);
            SourceExpression.Validate(fieldsetId, nameof(fieldsetId), required: true);
            SourceExpression.Validate(fieldId, nameof(fieldId), required: true);
            SourceExpression.Validate(bodyfieldsetId, nameof(bodyfieldsetId), required: false);
            SourceExpression.Validate(bodyfieldId, nameof(bodyfieldId), required: false);
            SourceExpression.Validate(bodysetOrder, nameof(bodysetOrder), required: false);
            SourceExpression.Validate(bodyorder, nameof(bodyorder), required: false);
            SourceExpression.Validate(bodytopicId, nameof(bodytopicId), required: false);
            SourceExpression.Validate(bodysetName, nameof(bodysetName), required: false);
            SourceExpression.Validate(bodyfieldName, nameof(bodyfieldName), required: false);
            SourceExpression.Validate(bodyfieldValueType, nameof(bodyfieldValueType), required: false);
            SourceExpression.Validate(bodyRequired, nameof(bodyRequired), required: false);
            SourceExpression.Validate(bodyReadonly, nameof(bodyReadonly), required: false);
            SourceExpression.Validate(bodyusage, nameof(bodyusage), required: false);
            SourceExpression.Validate(bodyrelationshipCategorydcv, nameof(bodyrelationshipCategorydcv), required: false);
            SourceExpression.Validate(bodyrelationshipCategoryname, nameof(bodyrelationshipCategoryname), required: false);
            SourceExpression.Validate(bodyrelationshipCategoryicon, nameof(bodyrelationshipCategoryicon), required: false);
            SourceExpression.Validate(bodycharacteristicdcv, nameof(bodycharacteristicdcv), required: false);
            SourceExpression.Validate(bodycharacteristicname, nameof(bodycharacteristicname), required: false);
            SourceExpression.Validate(bodycharacteristicicon, nameof(bodycharacteristicicon), required: false);
            SourceExpression.Validate(bodyopenLocation, nameof(bodyopenLocation), required: false);
            SourceExpression.Validate(bodydata, nameof(bodydata), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/{0}/{1}/topic/{2}/fieldsets/{3}/multidecimal/{4}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dbId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataLanguage, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(topicId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(fieldsetId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(fieldId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfieldsetId != null)
                {
                    body["fieldsetId"] = SourceExpressionConverter.ConvertToken(bodyfieldsetId);
                    bodypropCount++;
                }

                if (bodyfieldId != null)
                {
                    body["fieldId"] = SourceExpressionConverter.ConvertToken(bodyfieldId);
                    bodypropCount++;
                }

                if (bodysetOrder != null)
                {
                    body["setOrder"] = SourceExpressionConverter.ConvertToken(bodysetOrder);
                    bodypropCount++;
                }

                if (bodyorder != null)
                {
                    body["order"] = SourceExpressionConverter.ConvertToken(bodyorder);
                    bodypropCount++;
                }

                if (bodytopicId != null)
                {
                    body["topicId"] = SourceExpressionConverter.ConvertToken(bodytopicId);
                    bodypropCount++;
                }

                if (bodysetName != null)
                {
                    body["setName"] = SourceExpressionConverter.ConvertToken(bodysetName);
                    bodypropCount++;
                }

                if (bodyfieldName != null)
                {
                    body["fieldName"] = SourceExpressionConverter.ConvertToken(bodyfieldName);
                    bodypropCount++;
                }

                if (bodyfieldValueType != null)
                {
                    body["fieldValueType"] = SourceExpressionConverter.Convert(bodyfieldValueType);
                    bodypropCount++;
                }

                if (bodyRequired != null)
                {
                    body["required"] = SourceExpressionConverter.ConvertToken(bodyRequired);
                    bodypropCount++;
                }

                if (bodyReadonly != null)
                {
                    body["readonly"] = SourceExpressionConverter.ConvertToken(bodyReadonly);
                    bodypropCount++;
                }

                if (bodyusage != null)
                {
                    body["usage"] = SourceExpressionConverter.ConvertToken(bodyusage);
                    bodypropCount++;
                }

                var relationshipCategoryObject = new JObject();
                var relationshipCategoryObjectpropCount = 0;
                if (bodyrelationshipCategorydcv != null)
                {
                    relationshipCategoryObject["dcv"] = SourceExpressionConverter.ConvertToken(bodyrelationshipCategorydcv);
                    relationshipCategoryObjectpropCount++;
                }

                if (bodyrelationshipCategoryname != null)
                {
                    relationshipCategoryObject["name"] = SourceExpressionConverter.ConvertToken(bodyrelationshipCategoryname);
                    relationshipCategoryObjectpropCount++;
                }

                if (bodyrelationshipCategoryicon != null)
                {
                    relationshipCategoryObject["icon"] = SourceExpressionConverter.ConvertToken(bodyrelationshipCategoryicon);
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
                    characteristicObject["dcv"] = SourceExpressionConverter.ConvertToken(bodyrelationshipCategorydcv);
                    characteristicObjectpropCount++;
                }

                if (bodyrelationshipCategoryname != null)
                {
                    characteristicObject["name"] = SourceExpressionConverter.ConvertToken(bodyrelationshipCategoryname);
                    characteristicObjectpropCount++;
                }

                if (bodyrelationshipCategoryicon != null)
                {
                    characteristicObject["icon"] = SourceExpressionConverter.ConvertToken(bodyrelationshipCategoryicon);
                    characteristicObjectpropCount++;
                }

                if (characteristicObjectpropCount > 0)
                {
                    body["characteristic"] = characteristicObject;
                    bodypropCount++;
                }

                if (bodyopenLocation != null)
                {
                    body["openLocation"] = SourceExpressionConverter.ConvertToken(bodyopenLocation);
                    bodypropCount++;
                }

                if (bodydata != null)
                {
                    body["data"] = SourceExpressionConverter.ConvertToken(bodydata);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<IField>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IBodyWorkflowAction<IField> UpdateDateSingleField([WorkflowExpression] Func<string> dbId, [WorkflowExpression] Func<dataLanguageInput> dataLanguage, [WorkflowExpression] Func<string> topicId, [WorkflowExpression] Func<string> fieldsetId, [WorkflowExpression] Func<string> fieldId, [WorkflowExpression] Func<string> bodyfieldsetId = null, [WorkflowExpression] Func<string> bodyfieldId = null, [WorkflowExpression] Func<int> bodysetOrder = null, [WorkflowExpression] Func<int> bodyorder = null, [WorkflowExpression] Func<string> bodytopicId = null, [WorkflowExpression] Func<string> bodysetName = null, [WorkflowExpression] Func<string> bodyfieldName = null, [WorkflowExpression] Func<bodyfieldValueTypeInput> bodyfieldValueType = null, [WorkflowExpression] Func<bool> bodyRequired = null, [WorkflowExpression] Func<bool> bodyReadonly = null, [WorkflowExpression] Func<string> bodyusage = null, [WorkflowExpression] Func<string> bodyrelationshipCategorydcv = null, [WorkflowExpression] Func<string> bodyrelationshipCategoryname = null, [WorkflowExpression] Func<string> bodyrelationshipCategoryicon = null, [WorkflowExpression] Func<string> bodycharacteristicdcv = null, [WorkflowExpression] Func<string> bodycharacteristicname = null, [WorkflowExpression] Func<string> bodycharacteristicicon = null, [WorkflowExpression] Func<string> bodyopenLocation = null, [WorkflowExpression] Func<string> bodydata = null)
        {
            SourceExpression.Validate(dbId, nameof(dbId), required: true);
            SourceExpression.Validate(dataLanguage, nameof(dataLanguage), required: true);
            SourceExpression.Validate(topicId, nameof(topicId), required: true);
            SourceExpression.Validate(fieldsetId, nameof(fieldsetId), required: true);
            SourceExpression.Validate(fieldId, nameof(fieldId), required: true);
            SourceExpression.Validate(bodyfieldsetId, nameof(bodyfieldsetId), required: false);
            SourceExpression.Validate(bodyfieldId, nameof(bodyfieldId), required: false);
            SourceExpression.Validate(bodysetOrder, nameof(bodysetOrder), required: false);
            SourceExpression.Validate(bodyorder, nameof(bodyorder), required: false);
            SourceExpression.Validate(bodytopicId, nameof(bodytopicId), required: false);
            SourceExpression.Validate(bodysetName, nameof(bodysetName), required: false);
            SourceExpression.Validate(bodyfieldName, nameof(bodyfieldName), required: false);
            SourceExpression.Validate(bodyfieldValueType, nameof(bodyfieldValueType), required: false);
            SourceExpression.Validate(bodyRequired, nameof(bodyRequired), required: false);
            SourceExpression.Validate(bodyReadonly, nameof(bodyReadonly), required: false);
            SourceExpression.Validate(bodyusage, nameof(bodyusage), required: false);
            SourceExpression.Validate(bodyrelationshipCategorydcv, nameof(bodyrelationshipCategorydcv), required: false);
            SourceExpression.Validate(bodyrelationshipCategoryname, nameof(bodyrelationshipCategoryname), required: false);
            SourceExpression.Validate(bodyrelationshipCategoryicon, nameof(bodyrelationshipCategoryicon), required: false);
            SourceExpression.Validate(bodycharacteristicdcv, nameof(bodycharacteristicdcv), required: false);
            SourceExpression.Validate(bodycharacteristicname, nameof(bodycharacteristicname), required: false);
            SourceExpression.Validate(bodycharacteristicicon, nameof(bodycharacteristicicon), required: false);
            SourceExpression.Validate(bodyopenLocation, nameof(bodyopenLocation), required: false);
            SourceExpression.Validate(bodydata, nameof(bodydata), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/{0}/{1}/topic/{2}/fieldsets/{3}/date/{4}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dbId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataLanguage, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(topicId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(fieldsetId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(fieldId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfieldsetId != null)
                {
                    body["fieldsetId"] = SourceExpressionConverter.ConvertToken(bodyfieldsetId);
                    bodypropCount++;
                }

                if (bodyfieldId != null)
                {
                    body["fieldId"] = SourceExpressionConverter.ConvertToken(bodyfieldId);
                    bodypropCount++;
                }

                if (bodysetOrder != null)
                {
                    body["setOrder"] = SourceExpressionConverter.ConvertToken(bodysetOrder);
                    bodypropCount++;
                }

                if (bodyorder != null)
                {
                    body["order"] = SourceExpressionConverter.ConvertToken(bodyorder);
                    bodypropCount++;
                }

                if (bodytopicId != null)
                {
                    body["topicId"] = SourceExpressionConverter.ConvertToken(bodytopicId);
                    bodypropCount++;
                }

                if (bodysetName != null)
                {
                    body["setName"] = SourceExpressionConverter.ConvertToken(bodysetName);
                    bodypropCount++;
                }

                if (bodyfieldName != null)
                {
                    body["fieldName"] = SourceExpressionConverter.ConvertToken(bodyfieldName);
                    bodypropCount++;
                }

                if (bodyfieldValueType != null)
                {
                    body["fieldValueType"] = SourceExpressionConverter.Convert(bodyfieldValueType);
                    bodypropCount++;
                }

                if (bodyRequired != null)
                {
                    body["required"] = SourceExpressionConverter.ConvertToken(bodyRequired);
                    bodypropCount++;
                }

                if (bodyReadonly != null)
                {
                    body["readonly"] = SourceExpressionConverter.ConvertToken(bodyReadonly);
                    bodypropCount++;
                }

                if (bodyusage != null)
                {
                    body["usage"] = SourceExpressionConverter.ConvertToken(bodyusage);
                    bodypropCount++;
                }

                var relationshipCategoryObject = new JObject();
                var relationshipCategoryObjectpropCount = 0;
                if (bodyrelationshipCategorydcv != null)
                {
                    relationshipCategoryObject["dcv"] = SourceExpressionConverter.ConvertToken(bodyrelationshipCategorydcv);
                    relationshipCategoryObjectpropCount++;
                }

                if (bodyrelationshipCategoryname != null)
                {
                    relationshipCategoryObject["name"] = SourceExpressionConverter.ConvertToken(bodyrelationshipCategoryname);
                    relationshipCategoryObjectpropCount++;
                }

                if (bodyrelationshipCategoryicon != null)
                {
                    relationshipCategoryObject["icon"] = SourceExpressionConverter.ConvertToken(bodyrelationshipCategoryicon);
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
                    characteristicObject["dcv"] = SourceExpressionConverter.ConvertToken(bodyrelationshipCategorydcv);
                    characteristicObjectpropCount++;
                }

                if (bodyrelationshipCategoryname != null)
                {
                    characteristicObject["name"] = SourceExpressionConverter.ConvertToken(bodyrelationshipCategoryname);
                    characteristicObjectpropCount++;
                }

                if (bodyrelationshipCategoryicon != null)
                {
                    characteristicObject["icon"] = SourceExpressionConverter.ConvertToken(bodyrelationshipCategoryicon);
                    characteristicObjectpropCount++;
                }

                if (characteristicObjectpropCount > 0)
                {
                    body["characteristic"] = characteristicObject;
                    bodypropCount++;
                }

                if (bodyopenLocation != null)
                {
                    body["openLocation"] = SourceExpressionConverter.ConvertToken(bodyopenLocation);
                    bodypropCount++;
                }

                if (bodydata != null)
                {
                    body["data"] = SourceExpressionConverter.ConvertToken(bodydata);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<IField>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IBodyWorkflowAction<IField> UpdateDateMultiField([WorkflowExpression] Func<string> dbId, [WorkflowExpression] Func<dataLanguageInput> dataLanguage, [WorkflowExpression] Func<string> topicId, [WorkflowExpression] Func<string> fieldsetId, [WorkflowExpression] Func<string> fieldId, [WorkflowExpression] Func<string> bodyfieldsetId = null, [WorkflowExpression] Func<string> bodyfieldId = null, [WorkflowExpression] Func<int> bodysetOrder = null, [WorkflowExpression] Func<int> bodyorder = null, [WorkflowExpression] Func<string> bodytopicId = null, [WorkflowExpression] Func<string> bodysetName = null, [WorkflowExpression] Func<string> bodyfieldName = null, [WorkflowExpression] Func<bodyfieldValueTypeInput> bodyfieldValueType = null, [WorkflowExpression] Func<bool> bodyRequired = null, [WorkflowExpression] Func<bool> bodyReadonly = null, [WorkflowExpression] Func<string> bodyusage = null, [WorkflowExpression] Func<string> bodyrelationshipCategorydcv = null, [WorkflowExpression] Func<string> bodyrelationshipCategoryname = null, [WorkflowExpression] Func<string> bodyrelationshipCategoryicon = null, [WorkflowExpression] Func<string> bodycharacteristicdcv = null, [WorkflowExpression] Func<string> bodycharacteristicname = null, [WorkflowExpression] Func<string> bodycharacteristicicon = null, [WorkflowExpression] Func<string> bodyopenLocation = null, [WorkflowExpression] Func<string[]> bodydata = null)
        {
            SourceExpression.Validate(dbId, nameof(dbId), required: true);
            SourceExpression.Validate(dataLanguage, nameof(dataLanguage), required: true);
            SourceExpression.Validate(topicId, nameof(topicId), required: true);
            SourceExpression.Validate(fieldsetId, nameof(fieldsetId), required: true);
            SourceExpression.Validate(fieldId, nameof(fieldId), required: true);
            SourceExpression.Validate(bodyfieldsetId, nameof(bodyfieldsetId), required: false);
            SourceExpression.Validate(bodyfieldId, nameof(bodyfieldId), required: false);
            SourceExpression.Validate(bodysetOrder, nameof(bodysetOrder), required: false);
            SourceExpression.Validate(bodyorder, nameof(bodyorder), required: false);
            SourceExpression.Validate(bodytopicId, nameof(bodytopicId), required: false);
            SourceExpression.Validate(bodysetName, nameof(bodysetName), required: false);
            SourceExpression.Validate(bodyfieldName, nameof(bodyfieldName), required: false);
            SourceExpression.Validate(bodyfieldValueType, nameof(bodyfieldValueType), required: false);
            SourceExpression.Validate(bodyRequired, nameof(bodyRequired), required: false);
            SourceExpression.Validate(bodyReadonly, nameof(bodyReadonly), required: false);
            SourceExpression.Validate(bodyusage, nameof(bodyusage), required: false);
            SourceExpression.Validate(bodyrelationshipCategorydcv, nameof(bodyrelationshipCategorydcv), required: false);
            SourceExpression.Validate(bodyrelationshipCategoryname, nameof(bodyrelationshipCategoryname), required: false);
            SourceExpression.Validate(bodyrelationshipCategoryicon, nameof(bodyrelationshipCategoryicon), required: false);
            SourceExpression.Validate(bodycharacteristicdcv, nameof(bodycharacteristicdcv), required: false);
            SourceExpression.Validate(bodycharacteristicname, nameof(bodycharacteristicname), required: false);
            SourceExpression.Validate(bodycharacteristicicon, nameof(bodycharacteristicicon), required: false);
            SourceExpression.Validate(bodyopenLocation, nameof(bodyopenLocation), required: false);
            SourceExpression.Validate(bodydata, nameof(bodydata), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/{0}/{1}/topic/{2}/fieldsets/{3}/multidate/{4}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dbId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataLanguage, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(topicId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(fieldsetId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(fieldId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfieldsetId != null)
                {
                    body["fieldsetId"] = SourceExpressionConverter.ConvertToken(bodyfieldsetId);
                    bodypropCount++;
                }

                if (bodyfieldId != null)
                {
                    body["fieldId"] = SourceExpressionConverter.ConvertToken(bodyfieldId);
                    bodypropCount++;
                }

                if (bodysetOrder != null)
                {
                    body["setOrder"] = SourceExpressionConverter.ConvertToken(bodysetOrder);
                    bodypropCount++;
                }

                if (bodyorder != null)
                {
                    body["order"] = SourceExpressionConverter.ConvertToken(bodyorder);
                    bodypropCount++;
                }

                if (bodytopicId != null)
                {
                    body["topicId"] = SourceExpressionConverter.ConvertToken(bodytopicId);
                    bodypropCount++;
                }

                if (bodysetName != null)
                {
                    body["setName"] = SourceExpressionConverter.ConvertToken(bodysetName);
                    bodypropCount++;
                }

                if (bodyfieldName != null)
                {
                    body["fieldName"] = SourceExpressionConverter.ConvertToken(bodyfieldName);
                    bodypropCount++;
                }

                if (bodyfieldValueType != null)
                {
                    body["fieldValueType"] = SourceExpressionConverter.Convert(bodyfieldValueType);
                    bodypropCount++;
                }

                if (bodyRequired != null)
                {
                    body["required"] = SourceExpressionConverter.ConvertToken(bodyRequired);
                    bodypropCount++;
                }

                if (bodyReadonly != null)
                {
                    body["readonly"] = SourceExpressionConverter.ConvertToken(bodyReadonly);
                    bodypropCount++;
                }

                if (bodyusage != null)
                {
                    body["usage"] = SourceExpressionConverter.ConvertToken(bodyusage);
                    bodypropCount++;
                }

                var relationshipCategoryObject = new JObject();
                var relationshipCategoryObjectpropCount = 0;
                if (bodyrelationshipCategorydcv != null)
                {
                    relationshipCategoryObject["dcv"] = SourceExpressionConverter.ConvertToken(bodyrelationshipCategorydcv);
                    relationshipCategoryObjectpropCount++;
                }

                if (bodyrelationshipCategoryname != null)
                {
                    relationshipCategoryObject["name"] = SourceExpressionConverter.ConvertToken(bodyrelationshipCategoryname);
                    relationshipCategoryObjectpropCount++;
                }

                if (bodyrelationshipCategoryicon != null)
                {
                    relationshipCategoryObject["icon"] = SourceExpressionConverter.ConvertToken(bodyrelationshipCategoryicon);
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
                    characteristicObject["dcv"] = SourceExpressionConverter.ConvertToken(bodyrelationshipCategorydcv);
                    characteristicObjectpropCount++;
                }

                if (bodyrelationshipCategoryname != null)
                {
                    characteristicObject["name"] = SourceExpressionConverter.ConvertToken(bodyrelationshipCategoryname);
                    characteristicObjectpropCount++;
                }

                if (bodyrelationshipCategoryicon != null)
                {
                    characteristicObject["icon"] = SourceExpressionConverter.ConvertToken(bodyrelationshipCategoryicon);
                    characteristicObjectpropCount++;
                }

                if (characteristicObjectpropCount > 0)
                {
                    body["characteristic"] = characteristicObject;
                    bodypropCount++;
                }

                if (bodyopenLocation != null)
                {
                    body["openLocation"] = SourceExpressionConverter.ConvertToken(bodyopenLocation);
                    bodypropCount++;
                }

                if (bodydata != null)
                {
                    body["data"] = SourceExpressionConverter.ConvertToken(bodydata);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<IField>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IBodyWorkflowAction<IField> UpdateListSingleField([WorkflowExpression] Func<string> dbId, [WorkflowExpression] Func<dataLanguageInput> dataLanguage, [WorkflowExpression] Func<string> topicId, [WorkflowExpression] Func<string> fieldsetId, [WorkflowExpression] Func<string> fieldId, [WorkflowExpression] Func<string> bodyfieldsetId = null, [WorkflowExpression] Func<string> bodyfieldId = null, [WorkflowExpression] Func<int> bodysetOrder = null, [WorkflowExpression] Func<int> bodyorder = null, [WorkflowExpression] Func<string> bodytopicId = null, [WorkflowExpression] Func<string> bodysetName = null, [WorkflowExpression] Func<string> bodyfieldName = null, [WorkflowExpression] Func<bodyfieldValueTypeInput> bodyfieldValueType = null, [WorkflowExpression] Func<bool> bodyRequired = null, [WorkflowExpression] Func<bool> bodyReadonly = null, [WorkflowExpression] Func<string> bodyusage = null, [WorkflowExpression] Func<string> bodyrelationshipCategorydcv = null, [WorkflowExpression] Func<string> bodyrelationshipCategoryname = null, [WorkflowExpression] Func<string> bodyrelationshipCategoryicon = null, [WorkflowExpression] Func<string> bodycharacteristicdcv = null, [WorkflowExpression] Func<string> bodycharacteristicname = null, [WorkflowExpression] Func<string> bodycharacteristicicon = null, [WorkflowExpression] Func<string> bodyopenLocation = null)
        {
            SourceExpression.Validate(dbId, nameof(dbId), required: true);
            SourceExpression.Validate(dataLanguage, nameof(dataLanguage), required: true);
            SourceExpression.Validate(topicId, nameof(topicId), required: true);
            SourceExpression.Validate(fieldsetId, nameof(fieldsetId), required: true);
            SourceExpression.Validate(fieldId, nameof(fieldId), required: true);
            SourceExpression.Validate(bodyfieldsetId, nameof(bodyfieldsetId), required: false);
            SourceExpression.Validate(bodyfieldId, nameof(bodyfieldId), required: false);
            SourceExpression.Validate(bodysetOrder, nameof(bodysetOrder), required: false);
            SourceExpression.Validate(bodyorder, nameof(bodyorder), required: false);
            SourceExpression.Validate(bodytopicId, nameof(bodytopicId), required: false);
            SourceExpression.Validate(bodysetName, nameof(bodysetName), required: false);
            SourceExpression.Validate(bodyfieldName, nameof(bodyfieldName), required: false);
            SourceExpression.Validate(bodyfieldValueType, nameof(bodyfieldValueType), required: false);
            SourceExpression.Validate(bodyRequired, nameof(bodyRequired), required: false);
            SourceExpression.Validate(bodyReadonly, nameof(bodyReadonly), required: false);
            SourceExpression.Validate(bodyusage, nameof(bodyusage), required: false);
            SourceExpression.Validate(bodyrelationshipCategorydcv, nameof(bodyrelationshipCategorydcv), required: false);
            SourceExpression.Validate(bodyrelationshipCategoryname, nameof(bodyrelationshipCategoryname), required: false);
            SourceExpression.Validate(bodyrelationshipCategoryicon, nameof(bodyrelationshipCategoryicon), required: false);
            SourceExpression.Validate(bodycharacteristicdcv, nameof(bodycharacteristicdcv), required: false);
            SourceExpression.Validate(bodycharacteristicname, nameof(bodycharacteristicname), required: false);
            SourceExpression.Validate(bodycharacteristicicon, nameof(bodycharacteristicicon), required: false);
            SourceExpression.Validate(bodyopenLocation, nameof(bodyopenLocation), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/{0}/{1}/topic/{2}/fieldsets/{3}/list/{4}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dbId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataLanguage, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(topicId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(fieldsetId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(fieldId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfieldsetId != null)
                {
                    body["fieldsetId"] = SourceExpressionConverter.ConvertToken(bodyfieldsetId);
                    bodypropCount++;
                }

                if (bodyfieldId != null)
                {
                    body["fieldId"] = SourceExpressionConverter.ConvertToken(bodyfieldId);
                    bodypropCount++;
                }

                if (bodysetOrder != null)
                {
                    body["setOrder"] = SourceExpressionConverter.ConvertToken(bodysetOrder);
                    bodypropCount++;
                }

                if (bodyorder != null)
                {
                    body["order"] = SourceExpressionConverter.ConvertToken(bodyorder);
                    bodypropCount++;
                }

                if (bodytopicId != null)
                {
                    body["topicId"] = SourceExpressionConverter.ConvertToken(bodytopicId);
                    bodypropCount++;
                }

                if (bodysetName != null)
                {
                    body["setName"] = SourceExpressionConverter.ConvertToken(bodysetName);
                    bodypropCount++;
                }

                if (bodyfieldName != null)
                {
                    body["fieldName"] = SourceExpressionConverter.ConvertToken(bodyfieldName);
                    bodypropCount++;
                }

                if (bodyfieldValueType != null)
                {
                    body["fieldValueType"] = SourceExpressionConverter.Convert(bodyfieldValueType);
                    bodypropCount++;
                }

                if (bodyRequired != null)
                {
                    body["required"] = SourceExpressionConverter.ConvertToken(bodyRequired);
                    bodypropCount++;
                }

                if (bodyReadonly != null)
                {
                    body["readonly"] = SourceExpressionConverter.ConvertToken(bodyReadonly);
                    bodypropCount++;
                }

                if (bodyusage != null)
                {
                    body["usage"] = SourceExpressionConverter.ConvertToken(bodyusage);
                    bodypropCount++;
                }

                var relationshipCategoryObject = new JObject();
                var relationshipCategoryObjectpropCount = 0;
                if (bodyrelationshipCategorydcv != null)
                {
                    relationshipCategoryObject["dcv"] = SourceExpressionConverter.ConvertToken(bodyrelationshipCategorydcv);
                    relationshipCategoryObjectpropCount++;
                }

                if (bodyrelationshipCategoryname != null)
                {
                    relationshipCategoryObject["name"] = SourceExpressionConverter.ConvertToken(bodyrelationshipCategoryname);
                    relationshipCategoryObjectpropCount++;
                }

                if (bodyrelationshipCategoryicon != null)
                {
                    relationshipCategoryObject["icon"] = SourceExpressionConverter.ConvertToken(bodyrelationshipCategoryicon);
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
                    characteristicObject["dcv"] = SourceExpressionConverter.ConvertToken(bodyrelationshipCategorydcv);
                    characteristicObjectpropCount++;
                }

                if (bodyrelationshipCategoryname != null)
                {
                    characteristicObject["name"] = SourceExpressionConverter.ConvertToken(bodyrelationshipCategoryname);
                    characteristicObjectpropCount++;
                }

                if (bodyrelationshipCategoryicon != null)
                {
                    characteristicObject["icon"] = SourceExpressionConverter.ConvertToken(bodyrelationshipCategoryicon);
                    characteristicObjectpropCount++;
                }

                if (characteristicObjectpropCount > 0)
                {
                    body["characteristic"] = characteristicObject;
                    bodypropCount++;
                }

                if (bodyopenLocation != null)
                {
                    body["openLocation"] = SourceExpressionConverter.ConvertToken(bodyopenLocation);
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
                return callPayload;
            }

            return new ApiConnectionAction<IField>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IBodyWorkflowAction<IField> UpdateRelationshipSingleField([WorkflowExpression] Func<string> dbId, [WorkflowExpression] Func<dataLanguageInput> dataLanguage, [WorkflowExpression] Func<string> topicId, [WorkflowExpression] Func<string> fieldsetId, [WorkflowExpression] Func<string> fieldId, [WorkflowExpression] Func<string> bodyfieldId = null, [WorkflowExpression] Func<string> bodyfieldsetId = null, [WorkflowExpression] Func<string> bodydatadcv = null, [WorkflowExpression] Func<string> bodydataname = null, [WorkflowExpression] Func<string> bodydataicon = null)
        {
            SourceExpression.Validate(dbId, nameof(dbId), required: true);
            SourceExpression.Validate(dataLanguage, nameof(dataLanguage), required: true);
            SourceExpression.Validate(topicId, nameof(topicId), required: true);
            SourceExpression.Validate(fieldsetId, nameof(fieldsetId), required: true);
            SourceExpression.Validate(fieldId, nameof(fieldId), required: true);
            SourceExpression.Validate(bodyfieldId, nameof(bodyfieldId), required: false);
            SourceExpression.Validate(bodyfieldsetId, nameof(bodyfieldsetId), required: false);
            SourceExpression.Validate(bodydatadcv, nameof(bodydatadcv), required: false);
            SourceExpression.Validate(bodydataname, nameof(bodydataname), required: false);
            SourceExpression.Validate(bodydataicon, nameof(bodydataicon), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/{0}/{1}/topic/{2}/fieldsets/{3}/relationship/{4}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dbId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataLanguage, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(topicId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(fieldsetId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(fieldId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfieldId != null)
                {
                    body["fieldId"] = SourceExpressionConverter.ConvertToken(bodyfieldId);
                    bodypropCount++;
                }

                if (bodyfieldsetId != null)
                {
                    body["fieldsetId"] = SourceExpressionConverter.ConvertToken(bodyfieldsetId);
                    bodypropCount++;
                }

                var dataObject = new JObject();
                var dataObjectpropCount = 0;
                if (bodydatadcv != null)
                {
                    dataObject["dcv"] = SourceExpressionConverter.ConvertToken(bodydatadcv);
                    dataObjectpropCount++;
                }

                if (bodydataname != null)
                {
                    dataObject["name"] = SourceExpressionConverter.ConvertToken(bodydataname);
                    dataObjectpropCount++;
                }

                if (bodydataicon != null)
                {
                    dataObject["icon"] = SourceExpressionConverter.ConvertToken(bodydataicon);
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
                return callPayload;
            }

            return new ApiConnectionAction<IField>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IBodyWorkflowAction<IField> UpdateRelationshipMultiField([WorkflowExpression] Func<string> dbId, [WorkflowExpression] Func<dataLanguageInput> dataLanguage, [WorkflowExpression] Func<string> topicId, [WorkflowExpression] Func<string> fieldsetId, [WorkflowExpression] Func<string> fieldId, [WorkflowExpression] Func<string> bodyfieldId = null, [WorkflowExpression] Func<string> bodyfieldsetId = null, [WorkflowExpression] Func<RelationshipElement[]> bodydata = null)
        {
            SourceExpression.Validate(dbId, nameof(dbId), required: true);
            SourceExpression.Validate(dataLanguage, nameof(dataLanguage), required: true);
            SourceExpression.Validate(topicId, nameof(topicId), required: true);
            SourceExpression.Validate(fieldsetId, nameof(fieldsetId), required: true);
            SourceExpression.Validate(fieldId, nameof(fieldId), required: true);
            SourceExpression.Validate(bodyfieldId, nameof(bodyfieldId), required: false);
            SourceExpression.Validate(bodyfieldsetId, nameof(bodyfieldsetId), required: false);
            SourceExpression.Validate(bodydata, nameof(bodydata), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/{0}/{1}/topic/{2}/fieldsets/{3}/multirelationship/{4}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dbId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataLanguage, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(topicId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(fieldsetId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(fieldId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfieldId != null)
                {
                    body["fieldId"] = SourceExpressionConverter.ConvertToken(bodyfieldId);
                    bodypropCount++;
                }

                if (bodyfieldsetId != null)
                {
                    body["fieldsetId"] = SourceExpressionConverter.ConvertToken(bodyfieldsetId);
                    bodypropCount++;
                }

                if (bodydata != null)
                {
                    body["data"] = SourceExpressionConverter.ConvertToken(bodydata);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<IField>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IBodyWorkflowAction<IField> UpdateRelationshipListField([WorkflowExpression] Func<string> dbId, [WorkflowExpression] Func<dataLanguageInput> dataLanguage, [WorkflowExpression] Func<string> topicId, [WorkflowExpression] Func<string> fieldsetId, [WorkflowExpression] Func<string> fieldId, [WorkflowExpression] Func<string> bodyfieldId = null, [WorkflowExpression] Func<string> bodyfieldsetId = null)
        {
            SourceExpression.Validate(dbId, nameof(dbId), required: true);
            SourceExpression.Validate(dataLanguage, nameof(dataLanguage), required: true);
            SourceExpression.Validate(topicId, nameof(topicId), required: true);
            SourceExpression.Validate(fieldsetId, nameof(fieldsetId), required: true);
            SourceExpression.Validate(fieldId, nameof(fieldId), required: true);
            SourceExpression.Validate(bodyfieldId, nameof(bodyfieldId), required: false);
            SourceExpression.Validate(bodyfieldsetId, nameof(bodyfieldsetId), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/{0}/{1}/topic/{2}/fieldsets/{3}/relationshiplist/{4}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dbId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataLanguage, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(topicId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(fieldsetId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(fieldId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfieldId != null)
                {
                    body["fieldId"] = SourceExpressionConverter.ConvertToken(bodyfieldId);
                    bodypropCount++;
                }

                if (bodyfieldsetId != null)
                {
                    body["fieldsetId"] = SourceExpressionConverter.ConvertToken(bodyfieldsetId);
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
                return callPayload;
            }

            return new ApiConnectionAction<IField>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IBodyWorkflowAction<IField> UpdateFields([WorkflowExpression] Func<string> dbId, [WorkflowExpression] Func<dataLanguageInput> dataLanguage, [WorkflowExpression] Func<string> topicId, [WorkflowExpression] Func<SingleTextField[]> bodysingleTextFields = null, [WorkflowExpression] Func<MultiTextField[]> bodymultiTextFields = null, [WorkflowExpression] Func<SingleNumberField[]> bodysingleNumberFields = null, [WorkflowExpression] Func<MultiNumberField[]> bodymultiNumberFields = null, [WorkflowExpression] Func<SingleBooleanField[]> bodysingleBooleanFields = null, [WorkflowExpression] Func<SingleDecimalField[]> bodysingleDecimalFields = null, [WorkflowExpression] Func<MultiDecimalField[]> bodymultiDecimalFields = null, [WorkflowExpression] Func<SingleDateField[]> bodysingleDateFields = null, [WorkflowExpression] Func<MultiDateField[]> bodymultiDateFields = null, [WorkflowExpression] Func<SingleListField[]> bodysingleListFields = null, [WorkflowExpression] Func<RelationshipField[]> bodysingleRelationshipFields = null, [WorkflowExpression] Func<MultiRelationshipField[]> bodymultiRelationshipFields = null, [WorkflowExpression] Func<RelationshipListField[]> bodysingleRelationshipListFields = null, [WorkflowExpression] Func<SingleHyperlinkField[]> bodysingleHyperlinkFields = null, [WorkflowExpression] Func<MultiHyperlinkField[]> bodymultiHyperlinkFields = null)
        {
            SourceExpression.Validate(dbId, nameof(dbId), required: true);
            SourceExpression.Validate(dataLanguage, nameof(dataLanguage), required: true);
            SourceExpression.Validate(topicId, nameof(topicId), required: true);
            SourceExpression.Validate(bodysingleTextFields, nameof(bodysingleTextFields), required: false);
            SourceExpression.Validate(bodymultiTextFields, nameof(bodymultiTextFields), required: false);
            SourceExpression.Validate(bodysingleNumberFields, nameof(bodysingleNumberFields), required: false);
            SourceExpression.Validate(bodymultiNumberFields, nameof(bodymultiNumberFields), required: false);
            SourceExpression.Validate(bodysingleBooleanFields, nameof(bodysingleBooleanFields), required: false);
            SourceExpression.Validate(bodysingleDecimalFields, nameof(bodysingleDecimalFields), required: false);
            SourceExpression.Validate(bodymultiDecimalFields, nameof(bodymultiDecimalFields), required: false);
            SourceExpression.Validate(bodysingleDateFields, nameof(bodysingleDateFields), required: false);
            SourceExpression.Validate(bodymultiDateFields, nameof(bodymultiDateFields), required: false);
            SourceExpression.Validate(bodysingleListFields, nameof(bodysingleListFields), required: false);
            SourceExpression.Validate(bodysingleRelationshipFields, nameof(bodysingleRelationshipFields), required: false);
            SourceExpression.Validate(bodymultiRelationshipFields, nameof(bodymultiRelationshipFields), required: false);
            SourceExpression.Validate(bodysingleRelationshipListFields, nameof(bodysingleRelationshipListFields), required: false);
            SourceExpression.Validate(bodysingleHyperlinkFields, nameof(bodysingleHyperlinkFields), required: false);
            SourceExpression.Validate(bodymultiHyperlinkFields, nameof(bodymultiHyperlinkFields), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/{0}/{1}/topic/{2}/fields", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dbId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataLanguage, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(topicId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodysingleTextFields != null)
                {
                    body["singleTextFields"] = SourceExpressionConverter.ConvertToken(bodysingleTextFields);
                    bodypropCount++;
                }

                if (bodymultiTextFields != null)
                {
                    body["multiTextFields"] = SourceExpressionConverter.ConvertToken(bodymultiTextFields);
                    bodypropCount++;
                }

                if (bodysingleNumberFields != null)
                {
                    body["singleNumberFields"] = SourceExpressionConverter.ConvertToken(bodysingleNumberFields);
                    bodypropCount++;
                }

                if (bodymultiNumberFields != null)
                {
                    body["multiNumberFields"] = SourceExpressionConverter.ConvertToken(bodymultiNumberFields);
                    bodypropCount++;
                }

                if (bodysingleBooleanFields != null)
                {
                    body["singleBooleanFields"] = SourceExpressionConverter.ConvertToken(bodysingleBooleanFields);
                    bodypropCount++;
                }

                if (bodysingleDecimalFields != null)
                {
                    body["singleDecimalFields"] = SourceExpressionConverter.ConvertToken(bodysingleDecimalFields);
                    bodypropCount++;
                }

                if (bodymultiDecimalFields != null)
                {
                    body["multiDecimalFields"] = SourceExpressionConverter.ConvertToken(bodymultiDecimalFields);
                    bodypropCount++;
                }

                if (bodysingleDateFields != null)
                {
                    body["singleDateFields"] = SourceExpressionConverter.ConvertToken(bodysingleDateFields);
                    bodypropCount++;
                }

                if (bodymultiDateFields != null)
                {
                    body["multiDateFields"] = SourceExpressionConverter.ConvertToken(bodymultiDateFields);
                    bodypropCount++;
                }

                if (bodysingleListFields != null)
                {
                    body["singleListFields"] = SourceExpressionConverter.ConvertToken(bodysingleListFields);
                    bodypropCount++;
                }

                if (bodysingleRelationshipFields != null)
                {
                    body["singleRelationshipFields"] = SourceExpressionConverter.ConvertToken(bodysingleRelationshipFields);
                    bodypropCount++;
                }

                if (bodymultiRelationshipFields != null)
                {
                    body["multiRelationshipFields"] = SourceExpressionConverter.ConvertToken(bodymultiRelationshipFields);
                    bodypropCount++;
                }

                if (bodysingleRelationshipListFields != null)
                {
                    body["singleRelationshipListFields"] = SourceExpressionConverter.ConvertToken(bodysingleRelationshipListFields);
                    bodypropCount++;
                }

                if (bodysingleHyperlinkFields != null)
                {
                    body["singleHyperlinkFields"] = SourceExpressionConverter.ConvertToken(bodysingleHyperlinkFields);
                    bodypropCount++;
                }

                if (bodymultiHyperlinkFields != null)
                {
                    body["multiHyperlinkFields"] = SourceExpressionConverter.ConvertToken(bodymultiHyperlinkFields);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<IField>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IBodyWorkflowAction<IField> UpdateSingleHyperlinkField([WorkflowExpression] Func<string> dbId, [WorkflowExpression] Func<dataLanguageInput> dataLanguage, [WorkflowExpression] Func<string> topicId, [WorkflowExpression] Func<string> fieldsetId, [WorkflowExpression] Func<string> fieldId, [WorkflowExpression] Func<string> bodydata = null)
        {
            SourceExpression.Validate(dbId, nameof(dbId), required: true);
            SourceExpression.Validate(dataLanguage, nameof(dataLanguage), required: true);
            SourceExpression.Validate(topicId, nameof(topicId), required: true);
            SourceExpression.Validate(fieldsetId, nameof(fieldsetId), required: true);
            SourceExpression.Validate(fieldId, nameof(fieldId), required: true);
            SourceExpression.Validate(bodydata, nameof(bodydata), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/{0}/{1}/topic/{2}/fieldsets/{3}/hyperlink/{4}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dbId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataLanguage, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(topicId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(fieldsetId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(fieldId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodydata != null)
                {
                    body["data"] = SourceExpressionConverter.ConvertToken(bodydata);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<IField>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IBodyWorkflowAction<IField> UpdateMultiHyperlinkField([WorkflowExpression] Func<string> dbId, [WorkflowExpression] Func<dataLanguageInput> dataLanguage, [WorkflowExpression] Func<string> topicId, [WorkflowExpression] Func<string> fieldsetId, [WorkflowExpression] Func<string> fieldId, [WorkflowExpression] Func<string[]> bodydata = null)
        {
            SourceExpression.Validate(dbId, nameof(dbId), required: true);
            SourceExpression.Validate(dataLanguage, nameof(dataLanguage), required: true);
            SourceExpression.Validate(topicId, nameof(topicId), required: true);
            SourceExpression.Validate(fieldsetId, nameof(fieldsetId), required: true);
            SourceExpression.Validate(fieldId, nameof(fieldId), required: true);
            SourceExpression.Validate(bodydata, nameof(bodydata), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/{0}/{1}/topic/{2}/fieldsets/{3}/multihyperlink/{4}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dbId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataLanguage, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(topicId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(fieldsetId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(fieldId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodydata != null)
                {
                    body["data"] = SourceExpressionConverter.ConvertToken(bodydata);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<IField>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IWorkflowAction MoveTopicToTop([WorkflowExpression] Func<string> dbId, [WorkflowExpression] Func<dataLanguageInput> dataLanguage, [WorkflowExpression] Func<string> topicId)
        {
            SourceExpression.Validate(dbId, nameof(dbId), required: true);
            SourceExpression.Validate(dataLanguage, nameof(dataLanguage), required: true);
            SourceExpression.Validate(topicId, nameof(topicId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/{0}/{1}/topic/{2}/movetotop", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dbId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataLanguage, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(topicId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IWorkflowAction MoveTopicToBottom([WorkflowExpression] Func<string> dbId, [WorkflowExpression] Func<dataLanguageInput> dataLanguage, [WorkflowExpression] Func<string> topicId)
        {
            SourceExpression.Validate(dbId, nameof(dbId), required: true);
            SourceExpression.Validate(dataLanguage, nameof(dataLanguage), required: true);
            SourceExpression.Validate(topicId, nameof(topicId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/{0}/{1}/topic/{2}/movetobottom", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dbId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataLanguage, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(topicId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IWorkflowAction MoveTopicUp([WorkflowExpression] Func<string> dbId, [WorkflowExpression] Func<dataLanguageInput> dataLanguage, [WorkflowExpression] Func<string> topicId)
        {
            SourceExpression.Validate(dbId, nameof(dbId), required: true);
            SourceExpression.Validate(dataLanguage, nameof(dataLanguage), required: true);
            SourceExpression.Validate(topicId, nameof(topicId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/{0}/{1}/topic/{2}/moveup", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dbId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataLanguage, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(topicId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IWorkflowAction MoveTopicDown([WorkflowExpression] Func<string> dbId, [WorkflowExpression] Func<dataLanguageInput> dataLanguage, [WorkflowExpression] Func<string> topicId)
        {
            SourceExpression.Validate(dbId, nameof(dbId), required: true);
            SourceExpression.Validate(dataLanguage, nameof(dataLanguage), required: true);
            SourceExpression.Validate(topicId, nameof(topicId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/{0}/{1}/topic/{2}/movedown", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dbId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataLanguage, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(topicId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IWorkflowAction MoveTopicLevelUp([WorkflowExpression] Func<string> dbId, [WorkflowExpression] Func<dataLanguageInput> dataLanguage, [WorkflowExpression] Func<string> topicId)
        {
            SourceExpression.Validate(dbId, nameof(dbId), required: true);
            SourceExpression.Validate(dataLanguage, nameof(dataLanguage), required: true);
            SourceExpression.Validate(topicId, nameof(topicId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/{0}/{1}/topic/{2}/movelevelup", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dbId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataLanguage, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(topicId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IWorkflowAction MoveTopicLevelDown([WorkflowExpression] Func<string> dbId, [WorkflowExpression] Func<dataLanguageInput> dataLanguage, [WorkflowExpression] Func<string> topicId)
        {
            SourceExpression.Validate(dbId, nameof(dbId), required: true);
            SourceExpression.Validate(dataLanguage, nameof(dataLanguage), required: true);
            SourceExpression.Validate(topicId, nameof(topicId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/{0}/{1}/topic/{2}/moveleveldown", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dbId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataLanguage, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(topicId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IBodyWorkflowAction<IRelationship[]> GetTopicRelations([WorkflowExpression] Func<string> dbId, [WorkflowExpression] Func<dataLanguageInput> dataLanguage, [WorkflowExpression] Func<string> topicId)
        {
            SourceExpression.Validate(dbId, nameof(dbId), required: true);
            SourceExpression.Validate(dataLanguage, nameof(dataLanguage), required: true);
            SourceExpression.Validate(topicId, nameof(topicId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/{0}/{1}/topic/{2}/relations", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dbId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataLanguage, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(topicId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<IRelationship[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IBodyWorkflowAction<IRelationship> SaveRelation([WorkflowExpression] Func<string> dbId, [WorkflowExpression] Func<dataLanguageInput> dataLanguage, [WorkflowExpression] Func<string> bodyfromElementDcv = null, [WorkflowExpression] Func<string> bodytoElementDcv = null, [WorkflowExpression] Func<bodyrelationshipTypeInput> bodyrelationshipType = null)
        {
            SourceExpression.Validate(dbId, nameof(dbId), required: true);
            SourceExpression.Validate(dataLanguage, nameof(dataLanguage), required: true);
            SourceExpression.Validate(bodyfromElementDcv, nameof(bodyfromElementDcv), required: false);
            SourceExpression.Validate(bodytoElementDcv, nameof(bodytoElementDcv), required: false);
            SourceExpression.Validate(bodyrelationshipType, nameof(bodyrelationshipType), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/{0}/{1}/relation", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dbId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataLanguage, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfromElementDcv != null)
                {
                    body["fromElementDcv"] = SourceExpressionConverter.ConvertToken(bodyfromElementDcv);
                    bodypropCount++;
                }

                if (bodytoElementDcv != null)
                {
                    body["toElementDcv"] = SourceExpressionConverter.ConvertToken(bodytoElementDcv);
                    bodypropCount++;
                }

                if (bodyrelationshipType != null)
                {
                    body["relationshipType"] = SourceExpressionConverter.Convert(bodyrelationshipType);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<IRelationship>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IWorkflowAction DeleteRelation([WorkflowExpression] Func<string> dbId, [WorkflowExpression] Func<dataLanguageInput> dataLanguage, [WorkflowExpression] Func<string> topicId, [WorkflowExpression] Func<string> relationId)
        {
            SourceExpression.Validate(dbId, nameof(dbId), required: true);
            SourceExpression.Validate(dataLanguage, nameof(dataLanguage), required: true);
            SourceExpression.Validate(topicId, nameof(topicId), required: true);
            SourceExpression.Validate(relationId, nameof(relationId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/{0}/{1}/topic/{2}/relation/{3}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dbId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataLanguage, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(topicId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(relationId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IBodyWorkflowAction<ITopic> GetTopicRoot([WorkflowExpression] Func<string> dbId, [WorkflowExpression] Func<dataLanguageInput> dataLanguage)
        {
            SourceExpression.Validate(dbId, nameof(dbId), required: true);
            SourceExpression.Validate(dataLanguage, nameof(dataLanguage), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/{0}/{1}/root", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dbId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataLanguage, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ITopic>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IBodyWorkflowAction<ITopicPath> GetPathToRoot([WorkflowExpression] Func<string> dbId, [WorkflowExpression] Func<dataLanguageInput> dataLanguage, [WorkflowExpression] Func<string> topicId)
        {
            SourceExpression.Validate(dbId, nameof(dbId), required: true);
            SourceExpression.Validate(dataLanguage, nameof(dataLanguage), required: true);
            SourceExpression.Validate(topicId, nameof(topicId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/{0}/{1}/path/{2}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dbId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataLanguage, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(topicId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ITopicPath>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IBodyWorkflowAction<ITopic[]> GetTopicSiblings([WorkflowExpression] Func<string> dbId, [WorkflowExpression] Func<dataLanguageInput> dataLanguage, [WorkflowExpression] Func<string> topicId)
        {
            SourceExpression.Validate(dbId, nameof(dbId), required: true);
            SourceExpression.Validate(dataLanguage, nameof(dataLanguage), required: true);
            SourceExpression.Validate(topicId, nameof(topicId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/{0}/{1}/topic/{2}/siblings", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dbId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataLanguage, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(topicId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ITopic[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IBodyWorkflowAction<ITopic[]> GetRelationCategories([WorkflowExpression] Func<string> dbId, [WorkflowExpression] Func<dataLanguageInput> dataLanguage)
        {
            SourceExpression.Validate(dbId, nameof(dbId), required: true);
            SourceExpression.Validate(dataLanguage, nameof(dataLanguage), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/{0}/{1}/topic/categories", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dbId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataLanguage, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ITopic[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IBodyWorkflowAction<JToken> GetTopicTypes([WorkflowExpression] Func<string> dbId, [WorkflowExpression] Func<dataLanguageInput> dataLanguage, [WorkflowExpression] Func<string> topicId)
        {
            SourceExpression.Validate(dbId, nameof(dbId), required: true);
            SourceExpression.Validate(dataLanguage, nameof(dataLanguage), required: true);
            SourceExpression.Validate(topicId, nameof(topicId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/{0}/{1}/topic/{2}/types", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dbId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataLanguage, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(topicId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IBodyWorkflowAction<JToken> GetTopicIcons([WorkflowExpression] Func<string> dbId, [WorkflowExpression] Func<dataLanguageInput> dataLanguage, [WorkflowExpression] Func<string> topicType)
        {
            SourceExpression.Validate(dbId, nameof(dbId), required: true);
            SourceExpression.Validate(dataLanguage, nameof(dataLanguage), required: true);
            SourceExpression.Validate(topicType, nameof(topicType), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/{0}/{1}/types/{2}/icons", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dbId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataLanguage, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(topicType, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IBodyWorkflowAction<string> Version()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/version";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
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