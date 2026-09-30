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
        public IBodyWorkflowAction<IChart[]> GetTopicCharts([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> dbId, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<dataLanguageInput> dataLanguage, [WorkflowExpression] Func<string> topicId)
        {
            var apiCallPath = String.Format("/v1/{0}/{1}/topic/{2}/charts", ExpressionConverter.ConvertWithUrlEncoding(dbId, 1), ExpressionConverter.ConvertWithUrlEncoding(dataLanguage, 1), ExpressionConverter.ConvertWithUrlEncoding(topicId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<IChart[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IBodyWorkflowAction<ITopic> CreateTopicAfter([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> dbId, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<dataLanguageInput> dataLanguage, [WorkflowExpression] Func<string> topicId, [WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<string> bodytype, [WorkflowExpression] Func<string> bodyicon)
        {
            var apiCallPath = String.Format("/v1/{0}/{1}/topic/{2}", ExpressionConverter.ConvertWithUrlEncoding(dbId, 1), ExpressionConverter.ConvertWithUrlEncoding(dataLanguage, 1), ExpressionConverter.ConvertWithUrlEncoding(topicId, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IBodyWorkflowAction<ITopic> DeleteTopic([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> dbId, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<dataLanguageInput> dataLanguage, [WorkflowExpression] Func<string> topicId)
        {
            var apiCallPath = String.Format("/v1/{0}/{1}/topic/{2}", ExpressionConverter.ConvertWithUrlEncoding(dbId, 1), ExpressionConverter.ConvertWithUrlEncoding(dataLanguage, 1), ExpressionConverter.ConvertWithUrlEncoding(topicId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ITopic>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IBodyWorkflowAction<ITopic> GetTopic([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> dbId, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<dataLanguageInput> dataLanguage, [WorkflowExpression] Func<string> topicId)
        {
            var apiCallPath = String.Format("/v1/{0}/{1}/topic/{2}", ExpressionConverter.ConvertWithUrlEncoding(dbId, 1), ExpressionConverter.ConvertWithUrlEncoding(dataLanguage, 1), ExpressionConverter.ConvertWithUrlEncoding(topicId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ITopic>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IBodyWorkflowAction<ITopic> UpdateTopic([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> dbId, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<dataLanguageInput> dataLanguage, [WorkflowExpression] Func<string> topicId, [WorkflowExpression] Func<string> bodyname = null)
        {
            var apiCallPath = String.Format("/v1/{0}/{1}/topic/{2}", ExpressionConverter.ConvertWithUrlEncoding(dbId, 1), ExpressionConverter.ConvertWithUrlEncoding(dataLanguage, 1), ExpressionConverter.ConvertWithUrlEncoding(topicId, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IBodyWorkflowAction<ITopic> CreateChildTopic([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> dbId, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<dataLanguageInput> dataLanguage, [WorkflowExpression] Func<string> topicId, [WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<string> bodytype, [WorkflowExpression] Func<string> bodyicon)
        {
            var apiCallPath = String.Format("/v1/{0}/{1}/topic/{2}/children", ExpressionConverter.ConvertWithUrlEncoding(dbId, 1), ExpressionConverter.ConvertWithUrlEncoding(dataLanguage, 1), ExpressionConverter.ConvertWithUrlEncoding(topicId, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IBodyWorkflowAction<ITopic[]> GetTopicChildren([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> dbId, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<dataLanguageInput> dataLanguage, [WorkflowExpression] Func<string> topicId)
        {
            var apiCallPath = String.Format("/v1/{0}/{1}/topic/{2}/children", ExpressionConverter.ConvertWithUrlEncoding(dbId, 1), ExpressionConverter.ConvertWithUrlEncoding(dataLanguage, 1), ExpressionConverter.ConvertWithUrlEncoding(topicId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ITopic[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IBodyWorkflowAction<IField[]> GetTopicFields([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> dbId, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<dataLanguageInput> dataLanguage, [WorkflowExpression] Func<string> topicId)
        {
            var apiCallPath = String.Format("/v1/{0}/{1}/topic/{2}/fieldsets", ExpressionConverter.ConvertWithUrlEncoding(dbId, 1), ExpressionConverter.ConvertWithUrlEncoding(dataLanguage, 1), ExpressionConverter.ConvertWithUrlEncoding(topicId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<IField[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IBodyWorkflowAction<IField> GetFieldByDcvAndFieldsetId([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> dbId, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<dataLanguageInput> dataLanguage, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> topicId, [WorkflowExpression] Func<string> fieldsetId, [WorkflowExpression] Func<string> fieldId)
        {
            var apiCallPath = String.Format("/v1/{0}/{1}/topic/{2}/fieldsets/{3}/{4}", ExpressionConverter.ConvertWithUrlEncoding(dbId, 1), ExpressionConverter.ConvertWithUrlEncoding(dataLanguage, 1), ExpressionConverter.ConvertWithUrlEncoding(topicId, 1), ExpressionConverter.ConvertWithUrlEncoding(fieldsetId, 1), ExpressionConverter.ConvertWithUrlEncoding(fieldId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<IField>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IBodyWorkflowAction<IField> UpdateBooleanSingleField([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> dbId, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<dataLanguageInput> dataLanguage, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> topicId, [WorkflowExpression] Func<string> fieldsetId, [WorkflowExpression] Func<string> fieldId, [WorkflowExpression] Func<string> bodyfieldsetId = null, [WorkflowExpression] Func<string> bodyfieldId = null, [WorkflowExpression] Func<int> bodysetOrder = null, [WorkflowExpression] Func<int> bodyorder = null, [WorkflowExpression] Func<string> bodytopicId = null, [WorkflowExpression] Func<string> bodysetName = null, [WorkflowExpression] Func<string> bodyfieldName = null, [WorkflowExpression] Func<bodyfieldValueTypeInput> bodyfieldValueType = null, [WorkflowExpression] Func<bool> bodyrequired = null, [WorkflowExpression] Func<bool> bodyreadonly = null, [WorkflowExpression] Func<string> bodyusage = null, [WorkflowExpression] Func<string> bodyrelationshipCategorydcv = null, [WorkflowExpression] Func<string> bodyrelationshipCategoryname = null, [WorkflowExpression] Func<string> bodyrelationshipCategoryicon = null, [WorkflowExpression] Func<string> bodycharacteristicdcv = null, [WorkflowExpression] Func<string> bodycharacteristicname = null, [WorkflowExpression] Func<string> bodycharacteristicicon = null, [WorkflowExpression] Func<string> bodyopenLocation = null, [WorkflowExpression] Func<bool> bodydata = null)
        {
            var apiCallPath = String.Format("/v1/{0}/{1}/topic/{2}/fieldsets/{3}/bool/{4}", ExpressionConverter.ConvertWithUrlEncoding(dbId, 1), ExpressionConverter.ConvertWithUrlEncoding(dataLanguage, 1), ExpressionConverter.ConvertWithUrlEncoding(topicId, 1), ExpressionConverter.ConvertWithUrlEncoding(fieldsetId, 1), ExpressionConverter.ConvertWithUrlEncoding(fieldId, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IBodyWorkflowAction<IField> UpdateTextSingleField([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> dbId, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<dataLanguageInput> dataLanguage, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> topicId, [WorkflowExpression] Func<string> fieldsetId, [WorkflowExpression] Func<string> fieldId, [WorkflowExpression] Func<string> bodyfieldsetId = null, [WorkflowExpression] Func<string> bodyfieldId = null, [WorkflowExpression] Func<int> bodysetOrder = null, [WorkflowExpression] Func<int> bodyorder = null, [WorkflowExpression] Func<string> bodytopicId = null, [WorkflowExpression] Func<string> bodysetName = null, [WorkflowExpression] Func<string> bodyfieldName = null, [WorkflowExpression] Func<bodyfieldValueTypeInput> bodyfieldValueType = null, [WorkflowExpression] Func<bool> bodyrequired = null, [WorkflowExpression] Func<bool> bodyreadonly = null, [WorkflowExpression] Func<string> bodyusage = null, [WorkflowExpression] Func<string> bodyrelationshipCategorydcv = null, [WorkflowExpression] Func<string> bodyrelationshipCategoryname = null, [WorkflowExpression] Func<string> bodyrelationshipCategoryicon = null, [WorkflowExpression] Func<string> bodycharacteristicdcv = null, [WorkflowExpression] Func<string> bodycharacteristicname = null, [WorkflowExpression] Func<string> bodycharacteristicicon = null, [WorkflowExpression] Func<string> bodyopenLocation = null, [WorkflowExpression] Func<string> bodydata = null)
        {
            var apiCallPath = String.Format("/v1/{0}/{1}/topic/{2}/fieldsets/{3}/text/{4}", ExpressionConverter.ConvertWithUrlEncoding(dbId, 1), ExpressionConverter.ConvertWithUrlEncoding(dataLanguage, 1), ExpressionConverter.ConvertWithUrlEncoding(topicId, 1), ExpressionConverter.ConvertWithUrlEncoding(fieldsetId, 1), ExpressionConverter.ConvertWithUrlEncoding(fieldId, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IBodyWorkflowAction<IField> UpdateTextMultiField([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> dbId, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<dataLanguageInput> dataLanguage, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> topicId, [WorkflowExpression] Func<string> fieldsetId, [WorkflowExpression] Func<string> fieldId, [WorkflowExpression] Func<string> bodyfieldsetId = null, [WorkflowExpression] Func<string> bodyfieldId = null, [WorkflowExpression] Func<int> bodysetOrder = null, [WorkflowExpression] Func<int> bodyorder = null, [WorkflowExpression] Func<string> bodytopicId = null, [WorkflowExpression] Func<string> bodysetName = null, [WorkflowExpression] Func<string> bodyfieldName = null, [WorkflowExpression] Func<bodyfieldValueTypeInput> bodyfieldValueType = null, [WorkflowExpression] Func<bool> bodyrequired = null, [WorkflowExpression] Func<bool> bodyreadonly = null, [WorkflowExpression] Func<string> bodyusage = null, [WorkflowExpression] Func<string> bodyrelationshipCategorydcv = null, [WorkflowExpression] Func<string> bodyrelationshipCategoryname = null, [WorkflowExpression] Func<string> bodyrelationshipCategoryicon = null, [WorkflowExpression] Func<string> bodycharacteristicdcv = null, [WorkflowExpression] Func<string> bodycharacteristicname = null, [WorkflowExpression] Func<string> bodycharacteristicicon = null, [WorkflowExpression] Func<string> bodyopenLocation = null, [WorkflowExpression] Func<string[]> bodydata = null)
        {
            var apiCallPath = String.Format("/v1/{0}/{1}/topic/{2}/fieldsets/{3}/multitext/{4}", ExpressionConverter.ConvertWithUrlEncoding(dbId, 1), ExpressionConverter.ConvertWithUrlEncoding(dataLanguage, 1), ExpressionConverter.ConvertWithUrlEncoding(topicId, 1), ExpressionConverter.ConvertWithUrlEncoding(fieldsetId, 1), ExpressionConverter.ConvertWithUrlEncoding(fieldId, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IBodyWorkflowAction<IField> UpdateNumberSingleField([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> dbId, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<dataLanguageInput> dataLanguage, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> topicId, [WorkflowExpression] Func<string> fieldsetId, [WorkflowExpression] Func<string> fieldId, [WorkflowExpression] Func<string> bodyfieldsetId = null, [WorkflowExpression] Func<string> bodyfieldId = null, [WorkflowExpression] Func<int> bodysetOrder = null, [WorkflowExpression] Func<int> bodyorder = null, [WorkflowExpression] Func<string> bodytopicId = null, [WorkflowExpression] Func<string> bodysetName = null, [WorkflowExpression] Func<string> bodyfieldName = null, [WorkflowExpression] Func<bodyfieldValueTypeInput> bodyfieldValueType = null, [WorkflowExpression] Func<bool> bodyrequired = null, [WorkflowExpression] Func<bool> bodyreadonly = null, [WorkflowExpression] Func<string> bodyusage = null, [WorkflowExpression] Func<string> bodyrelationshipCategorydcv = null, [WorkflowExpression] Func<string> bodyrelationshipCategoryname = null, [WorkflowExpression] Func<string> bodyrelationshipCategoryicon = null, [WorkflowExpression] Func<string> bodycharacteristicdcv = null, [WorkflowExpression] Func<string> bodycharacteristicname = null, [WorkflowExpression] Func<string> bodycharacteristicicon = null, [WorkflowExpression] Func<string> bodyopenLocation = null, [WorkflowExpression] Func<int> bodydata = null)
        {
            var apiCallPath = String.Format("/v1/{0}/{1}/topic/{2}/fieldsets/{3}/number/{4}", ExpressionConverter.ConvertWithUrlEncoding(dbId, 1), ExpressionConverter.ConvertWithUrlEncoding(dataLanguage, 1), ExpressionConverter.ConvertWithUrlEncoding(topicId, 1), ExpressionConverter.ConvertWithUrlEncoding(fieldsetId, 1), ExpressionConverter.ConvertWithUrlEncoding(fieldId, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IBodyWorkflowAction<IField> UpdateNumberMultiField([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> dbId, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<dataLanguageInput> dataLanguage, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> topicId, [WorkflowExpression] Func<string> fieldsetId, [WorkflowExpression] Func<string> fieldId, [WorkflowExpression] Func<string> bodyfieldsetId = null, [WorkflowExpression] Func<string> bodyfieldId = null, [WorkflowExpression] Func<int> bodysetOrder = null, [WorkflowExpression] Func<int> bodyorder = null, [WorkflowExpression] Func<string> bodytopicId = null, [WorkflowExpression] Func<string> bodysetName = null, [WorkflowExpression] Func<string> bodyfieldName = null, [WorkflowExpression] Func<bodyfieldValueTypeInput> bodyfieldValueType = null, [WorkflowExpression] Func<bool> bodyrequired = null, [WorkflowExpression] Func<bool> bodyreadonly = null, [WorkflowExpression] Func<string> bodyusage = null, [WorkflowExpression] Func<string> bodyrelationshipCategorydcv = null, [WorkflowExpression] Func<string> bodyrelationshipCategoryname = null, [WorkflowExpression] Func<string> bodyrelationshipCategoryicon = null, [WorkflowExpression] Func<string> bodycharacteristicdcv = null, [WorkflowExpression] Func<string> bodycharacteristicname = null, [WorkflowExpression] Func<string> bodycharacteristicicon = null, [WorkflowExpression] Func<string> bodyopenLocation = null, [WorkflowExpression] Func<int[]> bodydata = null)
        {
            var apiCallPath = String.Format("/v1/{0}/{1}/topic/{2}/fieldsets/{3}/multinumber/{4}", ExpressionConverter.ConvertWithUrlEncoding(dbId, 1), ExpressionConverter.ConvertWithUrlEncoding(dataLanguage, 1), ExpressionConverter.ConvertWithUrlEncoding(topicId, 1), ExpressionConverter.ConvertWithUrlEncoding(fieldsetId, 1), ExpressionConverter.ConvertWithUrlEncoding(fieldId, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IBodyWorkflowAction<IField> UpdateDecimalSingleField([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> dbId, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<dataLanguageInput> dataLanguage, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> topicId, [WorkflowExpression] Func<string> fieldsetId, [WorkflowExpression] Func<string> fieldId, [WorkflowExpression] Func<string> bodyfieldsetId = null, [WorkflowExpression] Func<string> bodyfieldId = null, [WorkflowExpression] Func<int> bodysetOrder = null, [WorkflowExpression] Func<int> bodyorder = null, [WorkflowExpression] Func<string> bodytopicId = null, [WorkflowExpression] Func<string> bodysetName = null, [WorkflowExpression] Func<string> bodyfieldName = null, [WorkflowExpression] Func<bodyfieldValueTypeInput> bodyfieldValueType = null, [WorkflowExpression] Func<bool> bodyrequired = null, [WorkflowExpression] Func<bool> bodyreadonly = null, [WorkflowExpression] Func<string> bodyusage = null, [WorkflowExpression] Func<string> bodyrelationshipCategorydcv = null, [WorkflowExpression] Func<string> bodyrelationshipCategoryname = null, [WorkflowExpression] Func<string> bodyrelationshipCategoryicon = null, [WorkflowExpression] Func<string> bodycharacteristicdcv = null, [WorkflowExpression] Func<string> bodycharacteristicname = null, [WorkflowExpression] Func<string> bodycharacteristicicon = null, [WorkflowExpression] Func<string> bodyopenLocation = null, [WorkflowExpression] Func<double> bodydata = null)
        {
            var apiCallPath = String.Format("/v1/{0}/{1}/topic/{2}/fieldsets/{3}/decimal/{4}", ExpressionConverter.ConvertWithUrlEncoding(dbId, 1), ExpressionConverter.ConvertWithUrlEncoding(dataLanguage, 1), ExpressionConverter.ConvertWithUrlEncoding(topicId, 1), ExpressionConverter.ConvertWithUrlEncoding(fieldsetId, 1), ExpressionConverter.ConvertWithUrlEncoding(fieldId, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IBodyWorkflowAction<IField> UpdateDecimalMultiField([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> dbId, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<dataLanguageInput> dataLanguage, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> topicId, [WorkflowExpression] Func<string> fieldsetId, [WorkflowExpression] Func<string> fieldId, [WorkflowExpression] Func<string> bodyfieldsetId = null, [WorkflowExpression] Func<string> bodyfieldId = null, [WorkflowExpression] Func<int> bodysetOrder = null, [WorkflowExpression] Func<int> bodyorder = null, [WorkflowExpression] Func<string> bodytopicId = null, [WorkflowExpression] Func<string> bodysetName = null, [WorkflowExpression] Func<string> bodyfieldName = null, [WorkflowExpression] Func<bodyfieldValueTypeInput> bodyfieldValueType = null, [WorkflowExpression] Func<bool> bodyrequired = null, [WorkflowExpression] Func<bool> bodyreadonly = null, [WorkflowExpression] Func<string> bodyusage = null, [WorkflowExpression] Func<string> bodyrelationshipCategorydcv = null, [WorkflowExpression] Func<string> bodyrelationshipCategoryname = null, [WorkflowExpression] Func<string> bodyrelationshipCategoryicon = null, [WorkflowExpression] Func<string> bodycharacteristicdcv = null, [WorkflowExpression] Func<string> bodycharacteristicname = null, [WorkflowExpression] Func<string> bodycharacteristicicon = null, [WorkflowExpression] Func<string> bodyopenLocation = null, [WorkflowExpression] Func<double[]> bodydata = null)
        {
            var apiCallPath = String.Format("/v1/{0}/{1}/topic/{2}/fieldsets/{3}/multidecimal/{4}", ExpressionConverter.ConvertWithUrlEncoding(dbId, 1), ExpressionConverter.ConvertWithUrlEncoding(dataLanguage, 1), ExpressionConverter.ConvertWithUrlEncoding(topicId, 1), ExpressionConverter.ConvertWithUrlEncoding(fieldsetId, 1), ExpressionConverter.ConvertWithUrlEncoding(fieldId, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IBodyWorkflowAction<IField> UpdateDateSingleField([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> dbId, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<dataLanguageInput> dataLanguage, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> topicId, [WorkflowExpression] Func<string> fieldsetId, [WorkflowExpression] Func<string> fieldId, [WorkflowExpression] Func<string> bodyfieldsetId = null, [WorkflowExpression] Func<string> bodyfieldId = null, [WorkflowExpression] Func<int> bodysetOrder = null, [WorkflowExpression] Func<int> bodyorder = null, [WorkflowExpression] Func<string> bodytopicId = null, [WorkflowExpression] Func<string> bodysetName = null, [WorkflowExpression] Func<string> bodyfieldName = null, [WorkflowExpression] Func<bodyfieldValueTypeInput> bodyfieldValueType = null, [WorkflowExpression] Func<bool> bodyrequired = null, [WorkflowExpression] Func<bool> bodyreadonly = null, [WorkflowExpression] Func<string> bodyusage = null, [WorkflowExpression] Func<string> bodyrelationshipCategorydcv = null, [WorkflowExpression] Func<string> bodyrelationshipCategoryname = null, [WorkflowExpression] Func<string> bodyrelationshipCategoryicon = null, [WorkflowExpression] Func<string> bodycharacteristicdcv = null, [WorkflowExpression] Func<string> bodycharacteristicname = null, [WorkflowExpression] Func<string> bodycharacteristicicon = null, [WorkflowExpression] Func<string> bodyopenLocation = null, [WorkflowExpression] Func<string> bodydata = null)
        {
            var apiCallPath = String.Format("/v1/{0}/{1}/topic/{2}/fieldsets/{3}/date/{4}", ExpressionConverter.ConvertWithUrlEncoding(dbId, 1), ExpressionConverter.ConvertWithUrlEncoding(dataLanguage, 1), ExpressionConverter.ConvertWithUrlEncoding(topicId, 1), ExpressionConverter.ConvertWithUrlEncoding(fieldsetId, 1), ExpressionConverter.ConvertWithUrlEncoding(fieldId, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IBodyWorkflowAction<IField> UpdateDateMultiField([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> dbId, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<dataLanguageInput> dataLanguage, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> topicId, [WorkflowExpression] Func<string> fieldsetId, [WorkflowExpression] Func<string> fieldId, [WorkflowExpression] Func<string> bodyfieldsetId = null, [WorkflowExpression] Func<string> bodyfieldId = null, [WorkflowExpression] Func<int> bodysetOrder = null, [WorkflowExpression] Func<int> bodyorder = null, [WorkflowExpression] Func<string> bodytopicId = null, [WorkflowExpression] Func<string> bodysetName = null, [WorkflowExpression] Func<string> bodyfieldName = null, [WorkflowExpression] Func<bodyfieldValueTypeInput> bodyfieldValueType = null, [WorkflowExpression] Func<bool> bodyrequired = null, [WorkflowExpression] Func<bool> bodyreadonly = null, [WorkflowExpression] Func<string> bodyusage = null, [WorkflowExpression] Func<string> bodyrelationshipCategorydcv = null, [WorkflowExpression] Func<string> bodyrelationshipCategoryname = null, [WorkflowExpression] Func<string> bodyrelationshipCategoryicon = null, [WorkflowExpression] Func<string> bodycharacteristicdcv = null, [WorkflowExpression] Func<string> bodycharacteristicname = null, [WorkflowExpression] Func<string> bodycharacteristicicon = null, [WorkflowExpression] Func<string> bodyopenLocation = null, [WorkflowExpression] Func<string[]> bodydata = null)
        {
            var apiCallPath = String.Format("/v1/{0}/{1}/topic/{2}/fieldsets/{3}/multidate/{4}", ExpressionConverter.ConvertWithUrlEncoding(dbId, 1), ExpressionConverter.ConvertWithUrlEncoding(dataLanguage, 1), ExpressionConverter.ConvertWithUrlEncoding(topicId, 1), ExpressionConverter.ConvertWithUrlEncoding(fieldsetId, 1), ExpressionConverter.ConvertWithUrlEncoding(fieldId, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IBodyWorkflowAction<IField> UpdateListSingleField([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> dbId, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<dataLanguageInput> dataLanguage, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> topicId, [WorkflowExpression] Func<string> fieldsetId, [WorkflowExpression] Func<string> fieldId, [WorkflowExpression] Func<string> bodyfieldsetId = null, [WorkflowExpression] Func<string> bodyfieldId = null, [WorkflowExpression] Func<int> bodysetOrder = null, [WorkflowExpression] Func<int> bodyorder = null, [WorkflowExpression] Func<string> bodytopicId = null, [WorkflowExpression] Func<string> bodysetName = null, [WorkflowExpression] Func<string> bodyfieldName = null, [WorkflowExpression] Func<bodyfieldValueTypeInput> bodyfieldValueType = null, [WorkflowExpression] Func<bool> bodyrequired = null, [WorkflowExpression] Func<bool> bodyreadonly = null, [WorkflowExpression] Func<string> bodyusage = null, [WorkflowExpression] Func<string> bodyrelationshipCategorydcv = null, [WorkflowExpression] Func<string> bodyrelationshipCategoryname = null, [WorkflowExpression] Func<string> bodyrelationshipCategoryicon = null, [WorkflowExpression] Func<string> bodycharacteristicdcv = null, [WorkflowExpression] Func<string> bodycharacteristicname = null, [WorkflowExpression] Func<string> bodycharacteristicicon = null, [WorkflowExpression] Func<string> bodyopenLocation = null)
        {
            var apiCallPath = String.Format("/v1/{0}/{1}/topic/{2}/fieldsets/{3}/list/{4}", ExpressionConverter.ConvertWithUrlEncoding(dbId, 1), ExpressionConverter.ConvertWithUrlEncoding(dataLanguage, 1), ExpressionConverter.ConvertWithUrlEncoding(topicId, 1), ExpressionConverter.ConvertWithUrlEncoding(fieldsetId, 1), ExpressionConverter.ConvertWithUrlEncoding(fieldId, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IBodyWorkflowAction<IField> UpdateRelationshipSingleField([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> dbId, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<dataLanguageInput> dataLanguage, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> topicId, [WorkflowExpression] Func<string> fieldsetId, [WorkflowExpression] Func<string> fieldId, [WorkflowExpression] Func<string> bodyfieldId = null, [WorkflowExpression] Func<string> bodyfieldsetId = null, [WorkflowExpression] Func<string> bodydatadcv = null, [WorkflowExpression] Func<string> bodydataname = null, [WorkflowExpression] Func<string> bodydataicon = null)
        {
            var apiCallPath = String.Format("/v1/{0}/{1}/topic/{2}/fieldsets/{3}/relationship/{4}", ExpressionConverter.ConvertWithUrlEncoding(dbId, 1), ExpressionConverter.ConvertWithUrlEncoding(dataLanguage, 1), ExpressionConverter.ConvertWithUrlEncoding(topicId, 1), ExpressionConverter.ConvertWithUrlEncoding(fieldsetId, 1), ExpressionConverter.ConvertWithUrlEncoding(fieldId, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IBodyWorkflowAction<IField> UpdateRelationshipMultiField([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> dbId, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<dataLanguageInput> dataLanguage, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> topicId, [WorkflowExpression] Func<string> fieldsetId, [WorkflowExpression] Func<string> fieldId, [WorkflowExpression] Func<string> bodyfieldId = null, [WorkflowExpression] Func<string> bodyfieldsetId = null, [WorkflowExpression] Func<RelationshipElement[]> bodydata = null)
        {
            var apiCallPath = String.Format("/v1/{0}/{1}/topic/{2}/fieldsets/{3}/multirelationship/{4}", ExpressionConverter.ConvertWithUrlEncoding(dbId, 1), ExpressionConverter.ConvertWithUrlEncoding(dataLanguage, 1), ExpressionConverter.ConvertWithUrlEncoding(topicId, 1), ExpressionConverter.ConvertWithUrlEncoding(fieldsetId, 1), ExpressionConverter.ConvertWithUrlEncoding(fieldId, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IBodyWorkflowAction<IField> UpdateRelationshipListField([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> dbId, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<dataLanguageInput> dataLanguage, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> topicId, [WorkflowExpression] Func<string> fieldsetId, [WorkflowExpression] Func<string> fieldId, [WorkflowExpression] Func<string> bodyfieldId = null, [WorkflowExpression] Func<string> bodyfieldsetId = null)
        {
            var apiCallPath = String.Format("/v1/{0}/{1}/topic/{2}/fieldsets/{3}/relationshiplist/{4}", ExpressionConverter.ConvertWithUrlEncoding(dbId, 1), ExpressionConverter.ConvertWithUrlEncoding(dataLanguage, 1), ExpressionConverter.ConvertWithUrlEncoding(topicId, 1), ExpressionConverter.ConvertWithUrlEncoding(fieldsetId, 1), ExpressionConverter.ConvertWithUrlEncoding(fieldId, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IBodyWorkflowAction<IField> UpdateFields([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> dbId, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<dataLanguageInput> dataLanguage, [WorkflowExpression] Func<string> topicId, [WorkflowExpression] Func<SingleTextField[]> bodysingleTextFields = null, [WorkflowExpression] Func<MultiTextField[]> bodymultiTextFields = null, [WorkflowExpression] Func<SingleNumberField[]> bodysingleNumberFields = null, [WorkflowExpression] Func<MultiNumberField[]> bodymultiNumberFields = null, [WorkflowExpression] Func<SingleBooleanField[]> bodysingleBooleanFields = null, [WorkflowExpression] Func<SingleDecimalField[]> bodysingleDecimalFields = null, [WorkflowExpression] Func<MultiDecimalField[]> bodymultiDecimalFields = null, [WorkflowExpression] Func<SingleDateField[]> bodysingleDateFields = null, [WorkflowExpression] Func<MultiDateField[]> bodymultiDateFields = null, [WorkflowExpression] Func<SingleListField[]> bodysingleListFields = null, [WorkflowExpression] Func<RelationshipField[]> bodysingleRelationshipFields = null, [WorkflowExpression] Func<MultiRelationshipField[]> bodymultiRelationshipFields = null, [WorkflowExpression] Func<RelationshipListField[]> bodysingleRelationshipListFields = null, [WorkflowExpression] Func<SingleHyperlinkField[]> bodysingleHyperlinkFields = null, [WorkflowExpression] Func<MultiHyperlinkField[]> bodymultiHyperlinkFields = null)
        {
            var apiCallPath = String.Format("/v1/{0}/{1}/topic/{2}/fields", ExpressionConverter.ConvertWithUrlEncoding(dbId, 1), ExpressionConverter.ConvertWithUrlEncoding(dataLanguage, 1), ExpressionConverter.ConvertWithUrlEncoding(topicId, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IBodyWorkflowAction<IField> UpdateSingleHyperlinkField([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> dbId, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<dataLanguageInput> dataLanguage, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> topicId, [WorkflowExpression] Func<string> fieldsetId, [WorkflowExpression] Func<string> fieldId, [WorkflowExpression] Func<string> bodydata = null)
        {
            var apiCallPath = String.Format("/v1/{0}/{1}/topic/{2}/fieldsets/{3}/hyperlink/{4}", ExpressionConverter.ConvertWithUrlEncoding(dbId, 1), ExpressionConverter.ConvertWithUrlEncoding(dataLanguage, 1), ExpressionConverter.ConvertWithUrlEncoding(topicId, 1), ExpressionConverter.ConvertWithUrlEncoding(fieldsetId, 1), ExpressionConverter.ConvertWithUrlEncoding(fieldId, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IBodyWorkflowAction<IField> UpdateMultiHyperlinkField([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> dbId, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<dataLanguageInput> dataLanguage, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> topicId, [WorkflowExpression] Func<string> fieldsetId, [WorkflowExpression] Func<string> fieldId, [WorkflowExpression] Func<string[]> bodydata = null)
        {
            var apiCallPath = String.Format("/v1/{0}/{1}/topic/{2}/fieldsets/{3}/multihyperlink/{4}", ExpressionConverter.ConvertWithUrlEncoding(dbId, 1), ExpressionConverter.ConvertWithUrlEncoding(dataLanguage, 1), ExpressionConverter.ConvertWithUrlEncoding(topicId, 1), ExpressionConverter.ConvertWithUrlEncoding(fieldsetId, 1), ExpressionConverter.ConvertWithUrlEncoding(fieldId, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IWorkflowAction MoveTopicToTop([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> dbId, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<dataLanguageInput> dataLanguage, [WorkflowExpression] Func<string> topicId)
        {
            var apiCallPath = String.Format("/v1/{0}/{1}/topic/{2}/movetotop", ExpressionConverter.ConvertWithUrlEncoding(dbId, 1), ExpressionConverter.ConvertWithUrlEncoding(dataLanguage, 1), ExpressionConverter.ConvertWithUrlEncoding(topicId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IWorkflowAction MoveTopicToBottom([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> dbId, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<dataLanguageInput> dataLanguage, [WorkflowExpression] Func<string> topicId)
        {
            var apiCallPath = String.Format("/v1/{0}/{1}/topic/{2}/movetobottom", ExpressionConverter.ConvertWithUrlEncoding(dbId, 1), ExpressionConverter.ConvertWithUrlEncoding(dataLanguage, 1), ExpressionConverter.ConvertWithUrlEncoding(topicId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IWorkflowAction MoveTopicUp([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> dbId, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<dataLanguageInput> dataLanguage, [WorkflowExpression] Func<string> topicId)
        {
            var apiCallPath = String.Format("/v1/{0}/{1}/topic/{2}/moveup", ExpressionConverter.ConvertWithUrlEncoding(dbId, 1), ExpressionConverter.ConvertWithUrlEncoding(dataLanguage, 1), ExpressionConverter.ConvertWithUrlEncoding(topicId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IWorkflowAction MoveTopicDown([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> dbId, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<dataLanguageInput> dataLanguage, [WorkflowExpression] Func<string> topicId)
        {
            var apiCallPath = String.Format("/v1/{0}/{1}/topic/{2}/movedown", ExpressionConverter.ConvertWithUrlEncoding(dbId, 1), ExpressionConverter.ConvertWithUrlEncoding(dataLanguage, 1), ExpressionConverter.ConvertWithUrlEncoding(topicId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IWorkflowAction MoveTopicLevelUp([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> dbId, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<dataLanguageInput> dataLanguage, [WorkflowExpression] Func<string> topicId)
        {
            var apiCallPath = String.Format("/v1/{0}/{1}/topic/{2}/movelevelup", ExpressionConverter.ConvertWithUrlEncoding(dbId, 1), ExpressionConverter.ConvertWithUrlEncoding(dataLanguage, 1), ExpressionConverter.ConvertWithUrlEncoding(topicId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IWorkflowAction MoveTopicLevelDown([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> dbId, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<dataLanguageInput> dataLanguage, [WorkflowExpression] Func<string> topicId)
        {
            var apiCallPath = String.Format("/v1/{0}/{1}/topic/{2}/moveleveldown", ExpressionConverter.ConvertWithUrlEncoding(dbId, 1), ExpressionConverter.ConvertWithUrlEncoding(dataLanguage, 1), ExpressionConverter.ConvertWithUrlEncoding(topicId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IBodyWorkflowAction<IRelationship[]> GetTopicRelations([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> dbId, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<dataLanguageInput> dataLanguage, [WorkflowExpression] Func<string> topicId)
        {
            var apiCallPath = String.Format("/v1/{0}/{1}/topic/{2}/relations", ExpressionConverter.ConvertWithUrlEncoding(dbId, 1), ExpressionConverter.ConvertWithUrlEncoding(dataLanguage, 1), ExpressionConverter.ConvertWithUrlEncoding(topicId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<IRelationship[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IBodyWorkflowAction<IRelationship> SaveRelation([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> dbId, [WorkflowExpression] Func<dataLanguageInput> dataLanguage, [WorkflowExpression] Func<string> bodyfromElementDcv = null, [WorkflowExpression] Func<string> bodytoElementDcv = null, [WorkflowExpression] Func<bodyrelationshipTypeInput> bodyrelationshipType = null)
        {
            var apiCallPath = String.Format("/v1/{0}/{1}/relation", ExpressionConverter.ConvertWithUrlEncoding(dbId, 1), ExpressionConverter.ConvertWithUrlEncoding(dataLanguage, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IWorkflowAction DeleteRelation([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> dbId, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<dataLanguageInput> dataLanguage, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> topicId, [WorkflowExpression] Func<string> relationId)
        {
            var apiCallPath = String.Format("/v1/{0}/{1}/topic/{2}/relation/{3}", ExpressionConverter.ConvertWithUrlEncoding(dbId, 1), ExpressionConverter.ConvertWithUrlEncoding(dataLanguage, 1), ExpressionConverter.ConvertWithUrlEncoding(topicId, 1), ExpressionConverter.ConvertWithUrlEncoding(relationId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IBodyWorkflowAction<ITopic> GetTopicRoot([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> dbId, [WorkflowExpression] Func<dataLanguageInput> dataLanguage)
        {
            var apiCallPath = String.Format("/v1/{0}/{1}/root", ExpressionConverter.ConvertWithUrlEncoding(dbId, 1), ExpressionConverter.ConvertWithUrlEncoding(dataLanguage, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ITopic>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IBodyWorkflowAction<ITopicPath> GetPathToRoot([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> dbId, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<dataLanguageInput> dataLanguage, [WorkflowExpression] Func<string> topicId)
        {
            var apiCallPath = String.Format("/v1/{0}/{1}/path/{2}", ExpressionConverter.ConvertWithUrlEncoding(dbId, 1), ExpressionConverter.ConvertWithUrlEncoding(dataLanguage, 1), ExpressionConverter.ConvertWithUrlEncoding(topicId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ITopicPath>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IBodyWorkflowAction<ITopic[]> GetTopicSiblings([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> dbId, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<dataLanguageInput> dataLanguage, [WorkflowExpression] Func<string> topicId)
        {
            var apiCallPath = String.Format("/v1/{0}/{1}/topic/{2}/siblings", ExpressionConverter.ConvertWithUrlEncoding(dbId, 1), ExpressionConverter.ConvertWithUrlEncoding(dataLanguage, 1), ExpressionConverter.ConvertWithUrlEncoding(topicId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ITopic[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IBodyWorkflowAction<ITopic[]> GetRelationCategories([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> dbId, [WorkflowExpression] Func<dataLanguageInput> dataLanguage)
        {
            var apiCallPath = String.Format("/v1/{0}/{1}/topic/categories", ExpressionConverter.ConvertWithUrlEncoding(dbId, 1), ExpressionConverter.ConvertWithUrlEncoding(dataLanguage, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ITopic[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IBodyWorkflowAction<JToken> GetTopicTypes([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> dbId, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<dataLanguageInput> dataLanguage, [WorkflowExpression] Func<string> topicId)
        {
            var apiCallPath = String.Format("/v1/{0}/{1}/topic/{2}/types", ExpressionConverter.ConvertWithUrlEncoding(dbId, 1), ExpressionConverter.ConvertWithUrlEncoding(dataLanguage, 1), ExpressionConverter.ConvertWithUrlEncoding(topicId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IBodyWorkflowAction<JToken> GetTopicIcons([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> dbId, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<dataLanguageInput> dataLanguage, [WorkflowExpression] Func<string> topicType)
        {
            var apiCallPath = String.Format("/v1/{0}/{1}/types/{2}/icons", ExpressionConverter.ConvertWithUrlEncoding(dbId, 1), ExpressionConverter.ConvertWithUrlEncoding(dataLanguage, 1), ExpressionConverter.ConvertWithUrlEncoding(topicType, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<JToken>(callPayload);
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