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
        public IBodyWorkflowAction<IChart[]> GetTopicCharts(Expression<Func<string>> dbId, Expression<Func<dataLanguageInput>> dataLanguage, Expression<Func<string>> topicId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v1/{0}/{1}/topic/{2}/charts", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dbId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataLanguage, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(topicId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<IChart[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IBodyWorkflowAction<ITopic> CreateTopicAfter(Expression<Func<string>> dbId, Expression<Func<dataLanguageInput>> dataLanguage, Expression<Func<string>> topicId, Expression<Func<string>> bodyname, Expression<Func<string>> bodytype, Expression<Func<string>> bodyicon)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v1/{0}/{1}/topic/{2}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dbId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataLanguage, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(topicId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["name"] = CSharpExpressionConverter.ConvertToken(bodyname);
            bodypropCount++;
            body["type"] = CSharpExpressionConverter.ConvertToken(bodytype);
            bodypropCount++;
            body["icon"] = CSharpExpressionConverter.ConvertToken(bodyicon);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ITopic>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IBodyWorkflowAction<ITopic> DeleteTopic(Expression<Func<string>> dbId, Expression<Func<dataLanguageInput>> dataLanguage, Expression<Func<string>> topicId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v1/{0}/{1}/topic/{2}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dbId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataLanguage, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(topicId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ITopic>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IBodyWorkflowAction<ITopic> GetTopic(Expression<Func<string>> dbId, Expression<Func<dataLanguageInput>> dataLanguage, Expression<Func<string>> topicId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v1/{0}/{1}/topic/{2}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dbId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataLanguage, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(topicId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ITopic>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IBodyWorkflowAction<ITopic> UpdateTopic(Expression<Func<string>> dbId, Expression<Func<dataLanguageInput>> dataLanguage, Expression<Func<string>> topicId, Expression<Func<string>> bodyname = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v1/{0}/{1}/topic/{2}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dbId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataLanguage, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(topicId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyname != null)
            {
                body["name"] = CSharpExpressionConverter.ConvertToken(bodyname);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ITopic>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IBodyWorkflowAction<ITopic> CreateChildTopic(Expression<Func<string>> dbId, Expression<Func<dataLanguageInput>> dataLanguage, Expression<Func<string>> topicId, Expression<Func<string>> bodyname, Expression<Func<string>> bodytype, Expression<Func<string>> bodyicon)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v1/{0}/{1}/topic/{2}/children", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dbId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataLanguage, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(topicId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["name"] = CSharpExpressionConverter.ConvertToken(bodyname);
            bodypropCount++;
            body["type"] = CSharpExpressionConverter.ConvertToken(bodytype);
            bodypropCount++;
            body["icon"] = CSharpExpressionConverter.ConvertToken(bodyicon);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ITopic>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IBodyWorkflowAction<ITopic[]> GetTopicChildren(Expression<Func<string>> dbId, Expression<Func<dataLanguageInput>> dataLanguage, Expression<Func<string>> topicId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v1/{0}/{1}/topic/{2}/children", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dbId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataLanguage, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(topicId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ITopic[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IBodyWorkflowAction<IField[]> GetTopicFields(Expression<Func<string>> dbId, Expression<Func<dataLanguageInput>> dataLanguage, Expression<Func<string>> topicId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v1/{0}/{1}/topic/{2}/fieldsets", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dbId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataLanguage, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(topicId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<IField[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IBodyWorkflowAction<IField> GetFieldByDcvAndFieldsetId(Expression<Func<string>> dbId, Expression<Func<dataLanguageInput>> dataLanguage, Expression<Func<string>> topicId, Expression<Func<string>> fieldsetId, Expression<Func<string>> fieldId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v1/{0}/{1}/topic/{2}/fieldsets/{3}/{4}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dbId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataLanguage, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(topicId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(fieldsetId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(fieldId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<IField>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IBodyWorkflowAction<IField> UpdateBooleanSingleField(Expression<Func<string>> dbId, Expression<Func<dataLanguageInput>> dataLanguage, Expression<Func<string>> topicId, Expression<Func<string>> fieldsetId, Expression<Func<string>> fieldId, Expression<Func<string>> bodyfieldsetId = null, Expression<Func<string>> bodyfieldId = null, Expression<Func<int>> bodysetOrder = null, Expression<Func<int>> bodyorder = null, Expression<Func<string>> bodytopicId = null, Expression<Func<string>> bodysetName = null, Expression<Func<string>> bodyfieldName = null, Expression<Func<bodyfieldValueTypeInput>> bodyfieldValueType = null, Expression<Func<bool>> bodyrequired = null, Expression<Func<bool>> bodyreadonly = null, Expression<Func<string>> bodyusage = null, Expression<Func<string>> bodyrelationshipCategorydcv = null, Expression<Func<string>> bodyrelationshipCategoryname = null, Expression<Func<string>> bodyrelationshipCategoryicon = null, Expression<Func<string>> bodycharacteristicdcv = null, Expression<Func<string>> bodycharacteristicname = null, Expression<Func<string>> bodycharacteristicicon = null, Expression<Func<string>> bodyopenLocation = null, Expression<Func<bool>> bodydata = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v1/{0}/{1}/topic/{2}/fieldsets/{3}/bool/{4}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dbId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataLanguage, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(topicId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(fieldsetId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(fieldId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyfieldsetId != null)
            {
                body["fieldsetId"] = CSharpExpressionConverter.ConvertToken(bodyfieldsetId);
                bodypropCount++;
            }

            if (bodyfieldId != null)
            {
                body["fieldId"] = CSharpExpressionConverter.ConvertToken(bodyfieldId);
                bodypropCount++;
            }

            if (bodysetOrder != null)
            {
                body["setOrder"] = CSharpExpressionConverter.ConvertToken(bodysetOrder);
                bodypropCount++;
            }

            if (bodyorder != null)
            {
                body["order"] = CSharpExpressionConverter.ConvertToken(bodyorder);
                bodypropCount++;
            }

            if (bodytopicId != null)
            {
                body["topicId"] = CSharpExpressionConverter.ConvertToken(bodytopicId);
                bodypropCount++;
            }

            if (bodysetName != null)
            {
                body["setName"] = CSharpExpressionConverter.ConvertToken(bodysetName);
                bodypropCount++;
            }

            if (bodyfieldName != null)
            {
                body["fieldName"] = CSharpExpressionConverter.ConvertToken(bodyfieldName);
                bodypropCount++;
            }

            if (bodyfieldValueType != null)
            {
                body["fieldValueType"] = CSharpExpressionConverter.Convert(bodyfieldValueType);
                bodypropCount++;
            }

            if (bodyrequired != null)
            {
                body["required"] = CSharpExpressionConverter.ConvertToken(bodyrequired);
                bodypropCount++;
            }

            if (bodyreadonly != null)
            {
                body["readonly"] = CSharpExpressionConverter.ConvertToken(bodyreadonly);
                bodypropCount++;
            }

            if (bodyusage != null)
            {
                body["usage"] = CSharpExpressionConverter.ConvertToken(bodyusage);
                bodypropCount++;
            }

            var relationshipCategoryObject = new JObject();
            var relationshipCategoryObjectpropCount = 0;
            if (bodyrelationshipCategorydcv != null)
            {
                relationshipCategoryObject["dcv"] = CSharpExpressionConverter.ConvertToken(bodyrelationshipCategorydcv);
                relationshipCategoryObjectpropCount++;
            }

            if (bodyrelationshipCategoryname != null)
            {
                relationshipCategoryObject["name"] = CSharpExpressionConverter.ConvertToken(bodyrelationshipCategoryname);
                relationshipCategoryObjectpropCount++;
            }

            if (bodyrelationshipCategoryicon != null)
            {
                relationshipCategoryObject["icon"] = CSharpExpressionConverter.ConvertToken(bodyrelationshipCategoryicon);
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
                characteristicObject["dcv"] = CSharpExpressionConverter.ConvertToken(bodyrelationshipCategorydcv);
                characteristicObjectpropCount++;
            }

            if (bodyrelationshipCategoryname != null)
            {
                characteristicObject["name"] = CSharpExpressionConverter.ConvertToken(bodyrelationshipCategoryname);
                characteristicObjectpropCount++;
            }

            if (bodyrelationshipCategoryicon != null)
            {
                characteristicObject["icon"] = CSharpExpressionConverter.ConvertToken(bodyrelationshipCategoryicon);
                characteristicObjectpropCount++;
            }

            if (characteristicObjectpropCount > 0)
            {
                body["characteristic"] = characteristicObject;
                bodypropCount++;
            }

            if (bodyopenLocation != null)
            {
                body["openLocation"] = CSharpExpressionConverter.ConvertToken(bodyopenLocation);
                bodypropCount++;
            }

            if (bodydata != null)
            {
                body["data"] = CSharpExpressionConverter.ConvertToken(bodydata);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<IField>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IBodyWorkflowAction<IField> UpdateTextSingleField(Expression<Func<string>> dbId, Expression<Func<dataLanguageInput>> dataLanguage, Expression<Func<string>> topicId, Expression<Func<string>> fieldsetId, Expression<Func<string>> fieldId, Expression<Func<string>> bodyfieldsetId = null, Expression<Func<string>> bodyfieldId = null, Expression<Func<int>> bodysetOrder = null, Expression<Func<int>> bodyorder = null, Expression<Func<string>> bodytopicId = null, Expression<Func<string>> bodysetName = null, Expression<Func<string>> bodyfieldName = null, Expression<Func<bodyfieldValueTypeInput>> bodyfieldValueType = null, Expression<Func<bool>> bodyrequired = null, Expression<Func<bool>> bodyreadonly = null, Expression<Func<string>> bodyusage = null, Expression<Func<string>> bodyrelationshipCategorydcv = null, Expression<Func<string>> bodyrelationshipCategoryname = null, Expression<Func<string>> bodyrelationshipCategoryicon = null, Expression<Func<string>> bodycharacteristicdcv = null, Expression<Func<string>> bodycharacteristicname = null, Expression<Func<string>> bodycharacteristicicon = null, Expression<Func<string>> bodyopenLocation = null, Expression<Func<string>> bodydata = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v1/{0}/{1}/topic/{2}/fieldsets/{3}/text/{4}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dbId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataLanguage, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(topicId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(fieldsetId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(fieldId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyfieldsetId != null)
            {
                body["fieldsetId"] = CSharpExpressionConverter.ConvertToken(bodyfieldsetId);
                bodypropCount++;
            }

            if (bodyfieldId != null)
            {
                body["fieldId"] = CSharpExpressionConverter.ConvertToken(bodyfieldId);
                bodypropCount++;
            }

            if (bodysetOrder != null)
            {
                body["setOrder"] = CSharpExpressionConverter.ConvertToken(bodysetOrder);
                bodypropCount++;
            }

            if (bodyorder != null)
            {
                body["order"] = CSharpExpressionConverter.ConvertToken(bodyorder);
                bodypropCount++;
            }

            if (bodytopicId != null)
            {
                body["topicId"] = CSharpExpressionConverter.ConvertToken(bodytopicId);
                bodypropCount++;
            }

            if (bodysetName != null)
            {
                body["setName"] = CSharpExpressionConverter.ConvertToken(bodysetName);
                bodypropCount++;
            }

            if (bodyfieldName != null)
            {
                body["fieldName"] = CSharpExpressionConverter.ConvertToken(bodyfieldName);
                bodypropCount++;
            }

            if (bodyfieldValueType != null)
            {
                body["fieldValueType"] = CSharpExpressionConverter.Convert(bodyfieldValueType);
                bodypropCount++;
            }

            if (bodyrequired != null)
            {
                body["required"] = CSharpExpressionConverter.ConvertToken(bodyrequired);
                bodypropCount++;
            }

            if (bodyreadonly != null)
            {
                body["readonly"] = CSharpExpressionConverter.ConvertToken(bodyreadonly);
                bodypropCount++;
            }

            if (bodyusage != null)
            {
                body["usage"] = CSharpExpressionConverter.ConvertToken(bodyusage);
                bodypropCount++;
            }

            var relationshipCategoryObject = new JObject();
            var relationshipCategoryObjectpropCount = 0;
            if (bodyrelationshipCategorydcv != null)
            {
                relationshipCategoryObject["dcv"] = CSharpExpressionConverter.ConvertToken(bodyrelationshipCategorydcv);
                relationshipCategoryObjectpropCount++;
            }

            if (bodyrelationshipCategoryname != null)
            {
                relationshipCategoryObject["name"] = CSharpExpressionConverter.ConvertToken(bodyrelationshipCategoryname);
                relationshipCategoryObjectpropCount++;
            }

            if (bodyrelationshipCategoryicon != null)
            {
                relationshipCategoryObject["icon"] = CSharpExpressionConverter.ConvertToken(bodyrelationshipCategoryicon);
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
                characteristicObject["dcv"] = CSharpExpressionConverter.ConvertToken(bodyrelationshipCategorydcv);
                characteristicObjectpropCount++;
            }

            if (bodyrelationshipCategoryname != null)
            {
                characteristicObject["name"] = CSharpExpressionConverter.ConvertToken(bodyrelationshipCategoryname);
                characteristicObjectpropCount++;
            }

            if (bodyrelationshipCategoryicon != null)
            {
                characteristicObject["icon"] = CSharpExpressionConverter.ConvertToken(bodyrelationshipCategoryicon);
                characteristicObjectpropCount++;
            }

            if (characteristicObjectpropCount > 0)
            {
                body["characteristic"] = characteristicObject;
                bodypropCount++;
            }

            if (bodyopenLocation != null)
            {
                body["openLocation"] = CSharpExpressionConverter.ConvertToken(bodyopenLocation);
                bodypropCount++;
            }

            if (bodydata != null)
            {
                body["data"] = CSharpExpressionConverter.ConvertToken(bodydata);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<IField>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IBodyWorkflowAction<IField> UpdateTextMultiField(Expression<Func<string>> dbId, Expression<Func<dataLanguageInput>> dataLanguage, Expression<Func<string>> topicId, Expression<Func<string>> fieldsetId, Expression<Func<string>> fieldId, Expression<Func<string>> bodyfieldsetId = null, Expression<Func<string>> bodyfieldId = null, Expression<Func<int>> bodysetOrder = null, Expression<Func<int>> bodyorder = null, Expression<Func<string>> bodytopicId = null, Expression<Func<string>> bodysetName = null, Expression<Func<string>> bodyfieldName = null, Expression<Func<bodyfieldValueTypeInput>> bodyfieldValueType = null, Expression<Func<bool>> bodyrequired = null, Expression<Func<bool>> bodyreadonly = null, Expression<Func<string>> bodyusage = null, Expression<Func<string>> bodyrelationshipCategorydcv = null, Expression<Func<string>> bodyrelationshipCategoryname = null, Expression<Func<string>> bodyrelationshipCategoryicon = null, Expression<Func<string>> bodycharacteristicdcv = null, Expression<Func<string>> bodycharacteristicname = null, Expression<Func<string>> bodycharacteristicicon = null, Expression<Func<string>> bodyopenLocation = null, Expression<Func<string[]>> bodydata = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v1/{0}/{1}/topic/{2}/fieldsets/{3}/multitext/{4}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dbId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataLanguage, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(topicId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(fieldsetId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(fieldId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyfieldsetId != null)
            {
                body["fieldsetId"] = CSharpExpressionConverter.ConvertToken(bodyfieldsetId);
                bodypropCount++;
            }

            if (bodyfieldId != null)
            {
                body["fieldId"] = CSharpExpressionConverter.ConvertToken(bodyfieldId);
                bodypropCount++;
            }

            if (bodysetOrder != null)
            {
                body["setOrder"] = CSharpExpressionConverter.ConvertToken(bodysetOrder);
                bodypropCount++;
            }

            if (bodyorder != null)
            {
                body["order"] = CSharpExpressionConverter.ConvertToken(bodyorder);
                bodypropCount++;
            }

            if (bodytopicId != null)
            {
                body["topicId"] = CSharpExpressionConverter.ConvertToken(bodytopicId);
                bodypropCount++;
            }

            if (bodysetName != null)
            {
                body["setName"] = CSharpExpressionConverter.ConvertToken(bodysetName);
                bodypropCount++;
            }

            if (bodyfieldName != null)
            {
                body["fieldName"] = CSharpExpressionConverter.ConvertToken(bodyfieldName);
                bodypropCount++;
            }

            if (bodyfieldValueType != null)
            {
                body["fieldValueType"] = CSharpExpressionConverter.Convert(bodyfieldValueType);
                bodypropCount++;
            }

            if (bodyrequired != null)
            {
                body["required"] = CSharpExpressionConverter.ConvertToken(bodyrequired);
                bodypropCount++;
            }

            if (bodyreadonly != null)
            {
                body["readonly"] = CSharpExpressionConverter.ConvertToken(bodyreadonly);
                bodypropCount++;
            }

            if (bodyusage != null)
            {
                body["usage"] = CSharpExpressionConverter.ConvertToken(bodyusage);
                bodypropCount++;
            }

            var relationshipCategoryObject = new JObject();
            var relationshipCategoryObjectpropCount = 0;
            if (bodyrelationshipCategorydcv != null)
            {
                relationshipCategoryObject["dcv"] = CSharpExpressionConverter.ConvertToken(bodyrelationshipCategorydcv);
                relationshipCategoryObjectpropCount++;
            }

            if (bodyrelationshipCategoryname != null)
            {
                relationshipCategoryObject["name"] = CSharpExpressionConverter.ConvertToken(bodyrelationshipCategoryname);
                relationshipCategoryObjectpropCount++;
            }

            if (bodyrelationshipCategoryicon != null)
            {
                relationshipCategoryObject["icon"] = CSharpExpressionConverter.ConvertToken(bodyrelationshipCategoryicon);
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
                characteristicObject["dcv"] = CSharpExpressionConverter.ConvertToken(bodyrelationshipCategorydcv);
                characteristicObjectpropCount++;
            }

            if (bodyrelationshipCategoryname != null)
            {
                characteristicObject["name"] = CSharpExpressionConverter.ConvertToken(bodyrelationshipCategoryname);
                characteristicObjectpropCount++;
            }

            if (bodyrelationshipCategoryicon != null)
            {
                characteristicObject["icon"] = CSharpExpressionConverter.ConvertToken(bodyrelationshipCategoryicon);
                characteristicObjectpropCount++;
            }

            if (characteristicObjectpropCount > 0)
            {
                body["characteristic"] = characteristicObject;
                bodypropCount++;
            }

            if (bodyopenLocation != null)
            {
                body["openLocation"] = CSharpExpressionConverter.ConvertToken(bodyopenLocation);
                bodypropCount++;
            }

            if (bodydata != null)
            {
                body["data"] = CSharpExpressionConverter.ConvertToken(bodydata);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<IField>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IBodyWorkflowAction<IField> UpdateNumberSingleField(Expression<Func<string>> dbId, Expression<Func<dataLanguageInput>> dataLanguage, Expression<Func<string>> topicId, Expression<Func<string>> fieldsetId, Expression<Func<string>> fieldId, Expression<Func<string>> bodyfieldsetId = null, Expression<Func<string>> bodyfieldId = null, Expression<Func<int>> bodysetOrder = null, Expression<Func<int>> bodyorder = null, Expression<Func<string>> bodytopicId = null, Expression<Func<string>> bodysetName = null, Expression<Func<string>> bodyfieldName = null, Expression<Func<bodyfieldValueTypeInput>> bodyfieldValueType = null, Expression<Func<bool>> bodyrequired = null, Expression<Func<bool>> bodyreadonly = null, Expression<Func<string>> bodyusage = null, Expression<Func<string>> bodyrelationshipCategorydcv = null, Expression<Func<string>> bodyrelationshipCategoryname = null, Expression<Func<string>> bodyrelationshipCategoryicon = null, Expression<Func<string>> bodycharacteristicdcv = null, Expression<Func<string>> bodycharacteristicname = null, Expression<Func<string>> bodycharacteristicicon = null, Expression<Func<string>> bodyopenLocation = null, Expression<Func<int>> bodydata = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v1/{0}/{1}/topic/{2}/fieldsets/{3}/number/{4}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dbId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataLanguage, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(topicId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(fieldsetId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(fieldId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyfieldsetId != null)
            {
                body["fieldsetId"] = CSharpExpressionConverter.ConvertToken(bodyfieldsetId);
                bodypropCount++;
            }

            if (bodyfieldId != null)
            {
                body["fieldId"] = CSharpExpressionConverter.ConvertToken(bodyfieldId);
                bodypropCount++;
            }

            if (bodysetOrder != null)
            {
                body["setOrder"] = CSharpExpressionConverter.ConvertToken(bodysetOrder);
                bodypropCount++;
            }

            if (bodyorder != null)
            {
                body["order"] = CSharpExpressionConverter.ConvertToken(bodyorder);
                bodypropCount++;
            }

            if (bodytopicId != null)
            {
                body["topicId"] = CSharpExpressionConverter.ConvertToken(bodytopicId);
                bodypropCount++;
            }

            if (bodysetName != null)
            {
                body["setName"] = CSharpExpressionConverter.ConvertToken(bodysetName);
                bodypropCount++;
            }

            if (bodyfieldName != null)
            {
                body["fieldName"] = CSharpExpressionConverter.ConvertToken(bodyfieldName);
                bodypropCount++;
            }

            if (bodyfieldValueType != null)
            {
                body["fieldValueType"] = CSharpExpressionConverter.Convert(bodyfieldValueType);
                bodypropCount++;
            }

            if (bodyrequired != null)
            {
                body["required"] = CSharpExpressionConverter.ConvertToken(bodyrequired);
                bodypropCount++;
            }

            if (bodyreadonly != null)
            {
                body["readonly"] = CSharpExpressionConverter.ConvertToken(bodyreadonly);
                bodypropCount++;
            }

            if (bodyusage != null)
            {
                body["usage"] = CSharpExpressionConverter.ConvertToken(bodyusage);
                bodypropCount++;
            }

            var relationshipCategoryObject = new JObject();
            var relationshipCategoryObjectpropCount = 0;
            if (bodyrelationshipCategorydcv != null)
            {
                relationshipCategoryObject["dcv"] = CSharpExpressionConverter.ConvertToken(bodyrelationshipCategorydcv);
                relationshipCategoryObjectpropCount++;
            }

            if (bodyrelationshipCategoryname != null)
            {
                relationshipCategoryObject["name"] = CSharpExpressionConverter.ConvertToken(bodyrelationshipCategoryname);
                relationshipCategoryObjectpropCount++;
            }

            if (bodyrelationshipCategoryicon != null)
            {
                relationshipCategoryObject["icon"] = CSharpExpressionConverter.ConvertToken(bodyrelationshipCategoryicon);
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
                characteristicObject["dcv"] = CSharpExpressionConverter.ConvertToken(bodyrelationshipCategorydcv);
                characteristicObjectpropCount++;
            }

            if (bodyrelationshipCategoryname != null)
            {
                characteristicObject["name"] = CSharpExpressionConverter.ConvertToken(bodyrelationshipCategoryname);
                characteristicObjectpropCount++;
            }

            if (bodyrelationshipCategoryicon != null)
            {
                characteristicObject["icon"] = CSharpExpressionConverter.ConvertToken(bodyrelationshipCategoryicon);
                characteristicObjectpropCount++;
            }

            if (characteristicObjectpropCount > 0)
            {
                body["characteristic"] = characteristicObject;
                bodypropCount++;
            }

            if (bodyopenLocation != null)
            {
                body["openLocation"] = CSharpExpressionConverter.ConvertToken(bodyopenLocation);
                bodypropCount++;
            }

            if (bodydata != null)
            {
                body["data"] = CSharpExpressionConverter.ConvertToken(bodydata);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<IField>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IBodyWorkflowAction<IField> UpdateNumberMultiField(Expression<Func<string>> dbId, Expression<Func<dataLanguageInput>> dataLanguage, Expression<Func<string>> topicId, Expression<Func<string>> fieldsetId, Expression<Func<string>> fieldId, Expression<Func<string>> bodyfieldsetId = null, Expression<Func<string>> bodyfieldId = null, Expression<Func<int>> bodysetOrder = null, Expression<Func<int>> bodyorder = null, Expression<Func<string>> bodytopicId = null, Expression<Func<string>> bodysetName = null, Expression<Func<string>> bodyfieldName = null, Expression<Func<bodyfieldValueTypeInput>> bodyfieldValueType = null, Expression<Func<bool>> bodyrequired = null, Expression<Func<bool>> bodyreadonly = null, Expression<Func<string>> bodyusage = null, Expression<Func<string>> bodyrelationshipCategorydcv = null, Expression<Func<string>> bodyrelationshipCategoryname = null, Expression<Func<string>> bodyrelationshipCategoryicon = null, Expression<Func<string>> bodycharacteristicdcv = null, Expression<Func<string>> bodycharacteristicname = null, Expression<Func<string>> bodycharacteristicicon = null, Expression<Func<string>> bodyopenLocation = null, Expression<Func<int[]>> bodydata = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v1/{0}/{1}/topic/{2}/fieldsets/{3}/multinumber/{4}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dbId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataLanguage, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(topicId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(fieldsetId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(fieldId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyfieldsetId != null)
            {
                body["fieldsetId"] = CSharpExpressionConverter.ConvertToken(bodyfieldsetId);
                bodypropCount++;
            }

            if (bodyfieldId != null)
            {
                body["fieldId"] = CSharpExpressionConverter.ConvertToken(bodyfieldId);
                bodypropCount++;
            }

            if (bodysetOrder != null)
            {
                body["setOrder"] = CSharpExpressionConverter.ConvertToken(bodysetOrder);
                bodypropCount++;
            }

            if (bodyorder != null)
            {
                body["order"] = CSharpExpressionConverter.ConvertToken(bodyorder);
                bodypropCount++;
            }

            if (bodytopicId != null)
            {
                body["topicId"] = CSharpExpressionConverter.ConvertToken(bodytopicId);
                bodypropCount++;
            }

            if (bodysetName != null)
            {
                body["setName"] = CSharpExpressionConverter.ConvertToken(bodysetName);
                bodypropCount++;
            }

            if (bodyfieldName != null)
            {
                body["fieldName"] = CSharpExpressionConverter.ConvertToken(bodyfieldName);
                bodypropCount++;
            }

            if (bodyfieldValueType != null)
            {
                body["fieldValueType"] = CSharpExpressionConverter.Convert(bodyfieldValueType);
                bodypropCount++;
            }

            if (bodyrequired != null)
            {
                body["required"] = CSharpExpressionConverter.ConvertToken(bodyrequired);
                bodypropCount++;
            }

            if (bodyreadonly != null)
            {
                body["readonly"] = CSharpExpressionConverter.ConvertToken(bodyreadonly);
                bodypropCount++;
            }

            if (bodyusage != null)
            {
                body["usage"] = CSharpExpressionConverter.ConvertToken(bodyusage);
                bodypropCount++;
            }

            var relationshipCategoryObject = new JObject();
            var relationshipCategoryObjectpropCount = 0;
            if (bodyrelationshipCategorydcv != null)
            {
                relationshipCategoryObject["dcv"] = CSharpExpressionConverter.ConvertToken(bodyrelationshipCategorydcv);
                relationshipCategoryObjectpropCount++;
            }

            if (bodyrelationshipCategoryname != null)
            {
                relationshipCategoryObject["name"] = CSharpExpressionConverter.ConvertToken(bodyrelationshipCategoryname);
                relationshipCategoryObjectpropCount++;
            }

            if (bodyrelationshipCategoryicon != null)
            {
                relationshipCategoryObject["icon"] = CSharpExpressionConverter.ConvertToken(bodyrelationshipCategoryicon);
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
                characteristicObject["dcv"] = CSharpExpressionConverter.ConvertToken(bodyrelationshipCategorydcv);
                characteristicObjectpropCount++;
            }

            if (bodyrelationshipCategoryname != null)
            {
                characteristicObject["name"] = CSharpExpressionConverter.ConvertToken(bodyrelationshipCategoryname);
                characteristicObjectpropCount++;
            }

            if (bodyrelationshipCategoryicon != null)
            {
                characteristicObject["icon"] = CSharpExpressionConverter.ConvertToken(bodyrelationshipCategoryicon);
                characteristicObjectpropCount++;
            }

            if (characteristicObjectpropCount > 0)
            {
                body["characteristic"] = characteristicObject;
                bodypropCount++;
            }

            if (bodyopenLocation != null)
            {
                body["openLocation"] = CSharpExpressionConverter.ConvertToken(bodyopenLocation);
                bodypropCount++;
            }

            if (bodydata != null)
            {
                body["data"] = CSharpExpressionConverter.ConvertToken(bodydata);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<IField>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IBodyWorkflowAction<IField> UpdateDecimalSingleField(Expression<Func<string>> dbId, Expression<Func<dataLanguageInput>> dataLanguage, Expression<Func<string>> topicId, Expression<Func<string>> fieldsetId, Expression<Func<string>> fieldId, Expression<Func<string>> bodyfieldsetId = null, Expression<Func<string>> bodyfieldId = null, Expression<Func<int>> bodysetOrder = null, Expression<Func<int>> bodyorder = null, Expression<Func<string>> bodytopicId = null, Expression<Func<string>> bodysetName = null, Expression<Func<string>> bodyfieldName = null, Expression<Func<bodyfieldValueTypeInput>> bodyfieldValueType = null, Expression<Func<bool>> bodyrequired = null, Expression<Func<bool>> bodyreadonly = null, Expression<Func<string>> bodyusage = null, Expression<Func<string>> bodyrelationshipCategorydcv = null, Expression<Func<string>> bodyrelationshipCategoryname = null, Expression<Func<string>> bodyrelationshipCategoryicon = null, Expression<Func<string>> bodycharacteristicdcv = null, Expression<Func<string>> bodycharacteristicname = null, Expression<Func<string>> bodycharacteristicicon = null, Expression<Func<string>> bodyopenLocation = null, Expression<Func<double>> bodydata = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v1/{0}/{1}/topic/{2}/fieldsets/{3}/decimal/{4}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dbId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataLanguage, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(topicId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(fieldsetId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(fieldId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyfieldsetId != null)
            {
                body["fieldsetId"] = CSharpExpressionConverter.ConvertToken(bodyfieldsetId);
                bodypropCount++;
            }

            if (bodyfieldId != null)
            {
                body["fieldId"] = CSharpExpressionConverter.ConvertToken(bodyfieldId);
                bodypropCount++;
            }

            if (bodysetOrder != null)
            {
                body["setOrder"] = CSharpExpressionConverter.ConvertToken(bodysetOrder);
                bodypropCount++;
            }

            if (bodyorder != null)
            {
                body["order"] = CSharpExpressionConverter.ConvertToken(bodyorder);
                bodypropCount++;
            }

            if (bodytopicId != null)
            {
                body["topicId"] = CSharpExpressionConverter.ConvertToken(bodytopicId);
                bodypropCount++;
            }

            if (bodysetName != null)
            {
                body["setName"] = CSharpExpressionConverter.ConvertToken(bodysetName);
                bodypropCount++;
            }

            if (bodyfieldName != null)
            {
                body["fieldName"] = CSharpExpressionConverter.ConvertToken(bodyfieldName);
                bodypropCount++;
            }

            if (bodyfieldValueType != null)
            {
                body["fieldValueType"] = CSharpExpressionConverter.Convert(bodyfieldValueType);
                bodypropCount++;
            }

            if (bodyrequired != null)
            {
                body["required"] = CSharpExpressionConverter.ConvertToken(bodyrequired);
                bodypropCount++;
            }

            if (bodyreadonly != null)
            {
                body["readonly"] = CSharpExpressionConverter.ConvertToken(bodyreadonly);
                bodypropCount++;
            }

            if (bodyusage != null)
            {
                body["usage"] = CSharpExpressionConverter.ConvertToken(bodyusage);
                bodypropCount++;
            }

            var relationshipCategoryObject = new JObject();
            var relationshipCategoryObjectpropCount = 0;
            if (bodyrelationshipCategorydcv != null)
            {
                relationshipCategoryObject["dcv"] = CSharpExpressionConverter.ConvertToken(bodyrelationshipCategorydcv);
                relationshipCategoryObjectpropCount++;
            }

            if (bodyrelationshipCategoryname != null)
            {
                relationshipCategoryObject["name"] = CSharpExpressionConverter.ConvertToken(bodyrelationshipCategoryname);
                relationshipCategoryObjectpropCount++;
            }

            if (bodyrelationshipCategoryicon != null)
            {
                relationshipCategoryObject["icon"] = CSharpExpressionConverter.ConvertToken(bodyrelationshipCategoryicon);
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
                characteristicObject["dcv"] = CSharpExpressionConverter.ConvertToken(bodyrelationshipCategorydcv);
                characteristicObjectpropCount++;
            }

            if (bodyrelationshipCategoryname != null)
            {
                characteristicObject["name"] = CSharpExpressionConverter.ConvertToken(bodyrelationshipCategoryname);
                characteristicObjectpropCount++;
            }

            if (bodyrelationshipCategoryicon != null)
            {
                characteristicObject["icon"] = CSharpExpressionConverter.ConvertToken(bodyrelationshipCategoryicon);
                characteristicObjectpropCount++;
            }

            if (characteristicObjectpropCount > 0)
            {
                body["characteristic"] = characteristicObject;
                bodypropCount++;
            }

            if (bodyopenLocation != null)
            {
                body["openLocation"] = CSharpExpressionConverter.ConvertToken(bodyopenLocation);
                bodypropCount++;
            }

            if (bodydata != null)
            {
                body["data"] = CSharpExpressionConverter.ConvertToken(bodydata);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<IField>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IBodyWorkflowAction<IField> UpdateDecimalMultiField(Expression<Func<string>> dbId, Expression<Func<dataLanguageInput>> dataLanguage, Expression<Func<string>> topicId, Expression<Func<string>> fieldsetId, Expression<Func<string>> fieldId, Expression<Func<string>> bodyfieldsetId = null, Expression<Func<string>> bodyfieldId = null, Expression<Func<int>> bodysetOrder = null, Expression<Func<int>> bodyorder = null, Expression<Func<string>> bodytopicId = null, Expression<Func<string>> bodysetName = null, Expression<Func<string>> bodyfieldName = null, Expression<Func<bodyfieldValueTypeInput>> bodyfieldValueType = null, Expression<Func<bool>> bodyrequired = null, Expression<Func<bool>> bodyreadonly = null, Expression<Func<string>> bodyusage = null, Expression<Func<string>> bodyrelationshipCategorydcv = null, Expression<Func<string>> bodyrelationshipCategoryname = null, Expression<Func<string>> bodyrelationshipCategoryicon = null, Expression<Func<string>> bodycharacteristicdcv = null, Expression<Func<string>> bodycharacteristicname = null, Expression<Func<string>> bodycharacteristicicon = null, Expression<Func<string>> bodyopenLocation = null, Expression<Func<double[]>> bodydata = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v1/{0}/{1}/topic/{2}/fieldsets/{3}/multidecimal/{4}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dbId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataLanguage, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(topicId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(fieldsetId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(fieldId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyfieldsetId != null)
            {
                body["fieldsetId"] = CSharpExpressionConverter.ConvertToken(bodyfieldsetId);
                bodypropCount++;
            }

            if (bodyfieldId != null)
            {
                body["fieldId"] = CSharpExpressionConverter.ConvertToken(bodyfieldId);
                bodypropCount++;
            }

            if (bodysetOrder != null)
            {
                body["setOrder"] = CSharpExpressionConverter.ConvertToken(bodysetOrder);
                bodypropCount++;
            }

            if (bodyorder != null)
            {
                body["order"] = CSharpExpressionConverter.ConvertToken(bodyorder);
                bodypropCount++;
            }

            if (bodytopicId != null)
            {
                body["topicId"] = CSharpExpressionConverter.ConvertToken(bodytopicId);
                bodypropCount++;
            }

            if (bodysetName != null)
            {
                body["setName"] = CSharpExpressionConverter.ConvertToken(bodysetName);
                bodypropCount++;
            }

            if (bodyfieldName != null)
            {
                body["fieldName"] = CSharpExpressionConverter.ConvertToken(bodyfieldName);
                bodypropCount++;
            }

            if (bodyfieldValueType != null)
            {
                body["fieldValueType"] = CSharpExpressionConverter.Convert(bodyfieldValueType);
                bodypropCount++;
            }

            if (bodyrequired != null)
            {
                body["required"] = CSharpExpressionConverter.ConvertToken(bodyrequired);
                bodypropCount++;
            }

            if (bodyreadonly != null)
            {
                body["readonly"] = CSharpExpressionConverter.ConvertToken(bodyreadonly);
                bodypropCount++;
            }

            if (bodyusage != null)
            {
                body["usage"] = CSharpExpressionConverter.ConvertToken(bodyusage);
                bodypropCount++;
            }

            var relationshipCategoryObject = new JObject();
            var relationshipCategoryObjectpropCount = 0;
            if (bodyrelationshipCategorydcv != null)
            {
                relationshipCategoryObject["dcv"] = CSharpExpressionConverter.ConvertToken(bodyrelationshipCategorydcv);
                relationshipCategoryObjectpropCount++;
            }

            if (bodyrelationshipCategoryname != null)
            {
                relationshipCategoryObject["name"] = CSharpExpressionConverter.ConvertToken(bodyrelationshipCategoryname);
                relationshipCategoryObjectpropCount++;
            }

            if (bodyrelationshipCategoryicon != null)
            {
                relationshipCategoryObject["icon"] = CSharpExpressionConverter.ConvertToken(bodyrelationshipCategoryicon);
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
                characteristicObject["dcv"] = CSharpExpressionConverter.ConvertToken(bodyrelationshipCategorydcv);
                characteristicObjectpropCount++;
            }

            if (bodyrelationshipCategoryname != null)
            {
                characteristicObject["name"] = CSharpExpressionConverter.ConvertToken(bodyrelationshipCategoryname);
                characteristicObjectpropCount++;
            }

            if (bodyrelationshipCategoryicon != null)
            {
                characteristicObject["icon"] = CSharpExpressionConverter.ConvertToken(bodyrelationshipCategoryicon);
                characteristicObjectpropCount++;
            }

            if (characteristicObjectpropCount > 0)
            {
                body["characteristic"] = characteristicObject;
                bodypropCount++;
            }

            if (bodyopenLocation != null)
            {
                body["openLocation"] = CSharpExpressionConverter.ConvertToken(bodyopenLocation);
                bodypropCount++;
            }

            if (bodydata != null)
            {
                body["data"] = CSharpExpressionConverter.ConvertToken(bodydata);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<IField>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IBodyWorkflowAction<IField> UpdateDateSingleField(Expression<Func<string>> dbId, Expression<Func<dataLanguageInput>> dataLanguage, Expression<Func<string>> topicId, Expression<Func<string>> fieldsetId, Expression<Func<string>> fieldId, Expression<Func<string>> bodyfieldsetId = null, Expression<Func<string>> bodyfieldId = null, Expression<Func<int>> bodysetOrder = null, Expression<Func<int>> bodyorder = null, Expression<Func<string>> bodytopicId = null, Expression<Func<string>> bodysetName = null, Expression<Func<string>> bodyfieldName = null, Expression<Func<bodyfieldValueTypeInput>> bodyfieldValueType = null, Expression<Func<bool>> bodyrequired = null, Expression<Func<bool>> bodyreadonly = null, Expression<Func<string>> bodyusage = null, Expression<Func<string>> bodyrelationshipCategorydcv = null, Expression<Func<string>> bodyrelationshipCategoryname = null, Expression<Func<string>> bodyrelationshipCategoryicon = null, Expression<Func<string>> bodycharacteristicdcv = null, Expression<Func<string>> bodycharacteristicname = null, Expression<Func<string>> bodycharacteristicicon = null, Expression<Func<string>> bodyopenLocation = null, Expression<Func<string>> bodydata = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v1/{0}/{1}/topic/{2}/fieldsets/{3}/date/{4}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dbId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataLanguage, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(topicId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(fieldsetId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(fieldId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyfieldsetId != null)
            {
                body["fieldsetId"] = CSharpExpressionConverter.ConvertToken(bodyfieldsetId);
                bodypropCount++;
            }

            if (bodyfieldId != null)
            {
                body["fieldId"] = CSharpExpressionConverter.ConvertToken(bodyfieldId);
                bodypropCount++;
            }

            if (bodysetOrder != null)
            {
                body["setOrder"] = CSharpExpressionConverter.ConvertToken(bodysetOrder);
                bodypropCount++;
            }

            if (bodyorder != null)
            {
                body["order"] = CSharpExpressionConverter.ConvertToken(bodyorder);
                bodypropCount++;
            }

            if (bodytopicId != null)
            {
                body["topicId"] = CSharpExpressionConverter.ConvertToken(bodytopicId);
                bodypropCount++;
            }

            if (bodysetName != null)
            {
                body["setName"] = CSharpExpressionConverter.ConvertToken(bodysetName);
                bodypropCount++;
            }

            if (bodyfieldName != null)
            {
                body["fieldName"] = CSharpExpressionConverter.ConvertToken(bodyfieldName);
                bodypropCount++;
            }

            if (bodyfieldValueType != null)
            {
                body["fieldValueType"] = CSharpExpressionConverter.Convert(bodyfieldValueType);
                bodypropCount++;
            }

            if (bodyrequired != null)
            {
                body["required"] = CSharpExpressionConverter.ConvertToken(bodyrequired);
                bodypropCount++;
            }

            if (bodyreadonly != null)
            {
                body["readonly"] = CSharpExpressionConverter.ConvertToken(bodyreadonly);
                bodypropCount++;
            }

            if (bodyusage != null)
            {
                body["usage"] = CSharpExpressionConverter.ConvertToken(bodyusage);
                bodypropCount++;
            }

            var relationshipCategoryObject = new JObject();
            var relationshipCategoryObjectpropCount = 0;
            if (bodyrelationshipCategorydcv != null)
            {
                relationshipCategoryObject["dcv"] = CSharpExpressionConverter.ConvertToken(bodyrelationshipCategorydcv);
                relationshipCategoryObjectpropCount++;
            }

            if (bodyrelationshipCategoryname != null)
            {
                relationshipCategoryObject["name"] = CSharpExpressionConverter.ConvertToken(bodyrelationshipCategoryname);
                relationshipCategoryObjectpropCount++;
            }

            if (bodyrelationshipCategoryicon != null)
            {
                relationshipCategoryObject["icon"] = CSharpExpressionConverter.ConvertToken(bodyrelationshipCategoryicon);
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
                characteristicObject["dcv"] = CSharpExpressionConverter.ConvertToken(bodyrelationshipCategorydcv);
                characteristicObjectpropCount++;
            }

            if (bodyrelationshipCategoryname != null)
            {
                characteristicObject["name"] = CSharpExpressionConverter.ConvertToken(bodyrelationshipCategoryname);
                characteristicObjectpropCount++;
            }

            if (bodyrelationshipCategoryicon != null)
            {
                characteristicObject["icon"] = CSharpExpressionConverter.ConvertToken(bodyrelationshipCategoryicon);
                characteristicObjectpropCount++;
            }

            if (characteristicObjectpropCount > 0)
            {
                body["characteristic"] = characteristicObject;
                bodypropCount++;
            }

            if (bodyopenLocation != null)
            {
                body["openLocation"] = CSharpExpressionConverter.ConvertToken(bodyopenLocation);
                bodypropCount++;
            }

            if (bodydata != null)
            {
                body["data"] = CSharpExpressionConverter.ConvertToken(bodydata);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<IField>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IBodyWorkflowAction<IField> UpdateDateMultiField(Expression<Func<string>> dbId, Expression<Func<dataLanguageInput>> dataLanguage, Expression<Func<string>> topicId, Expression<Func<string>> fieldsetId, Expression<Func<string>> fieldId, Expression<Func<string>> bodyfieldsetId = null, Expression<Func<string>> bodyfieldId = null, Expression<Func<int>> bodysetOrder = null, Expression<Func<int>> bodyorder = null, Expression<Func<string>> bodytopicId = null, Expression<Func<string>> bodysetName = null, Expression<Func<string>> bodyfieldName = null, Expression<Func<bodyfieldValueTypeInput>> bodyfieldValueType = null, Expression<Func<bool>> bodyrequired = null, Expression<Func<bool>> bodyreadonly = null, Expression<Func<string>> bodyusage = null, Expression<Func<string>> bodyrelationshipCategorydcv = null, Expression<Func<string>> bodyrelationshipCategoryname = null, Expression<Func<string>> bodyrelationshipCategoryicon = null, Expression<Func<string>> bodycharacteristicdcv = null, Expression<Func<string>> bodycharacteristicname = null, Expression<Func<string>> bodycharacteristicicon = null, Expression<Func<string>> bodyopenLocation = null, Expression<Func<string[]>> bodydata = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v1/{0}/{1}/topic/{2}/fieldsets/{3}/multidate/{4}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dbId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataLanguage, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(topicId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(fieldsetId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(fieldId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyfieldsetId != null)
            {
                body["fieldsetId"] = CSharpExpressionConverter.ConvertToken(bodyfieldsetId);
                bodypropCount++;
            }

            if (bodyfieldId != null)
            {
                body["fieldId"] = CSharpExpressionConverter.ConvertToken(bodyfieldId);
                bodypropCount++;
            }

            if (bodysetOrder != null)
            {
                body["setOrder"] = CSharpExpressionConverter.ConvertToken(bodysetOrder);
                bodypropCount++;
            }

            if (bodyorder != null)
            {
                body["order"] = CSharpExpressionConverter.ConvertToken(bodyorder);
                bodypropCount++;
            }

            if (bodytopicId != null)
            {
                body["topicId"] = CSharpExpressionConverter.ConvertToken(bodytopicId);
                bodypropCount++;
            }

            if (bodysetName != null)
            {
                body["setName"] = CSharpExpressionConverter.ConvertToken(bodysetName);
                bodypropCount++;
            }

            if (bodyfieldName != null)
            {
                body["fieldName"] = CSharpExpressionConverter.ConvertToken(bodyfieldName);
                bodypropCount++;
            }

            if (bodyfieldValueType != null)
            {
                body["fieldValueType"] = CSharpExpressionConverter.Convert(bodyfieldValueType);
                bodypropCount++;
            }

            if (bodyrequired != null)
            {
                body["required"] = CSharpExpressionConverter.ConvertToken(bodyrequired);
                bodypropCount++;
            }

            if (bodyreadonly != null)
            {
                body["readonly"] = CSharpExpressionConverter.ConvertToken(bodyreadonly);
                bodypropCount++;
            }

            if (bodyusage != null)
            {
                body["usage"] = CSharpExpressionConverter.ConvertToken(bodyusage);
                bodypropCount++;
            }

            var relationshipCategoryObject = new JObject();
            var relationshipCategoryObjectpropCount = 0;
            if (bodyrelationshipCategorydcv != null)
            {
                relationshipCategoryObject["dcv"] = CSharpExpressionConverter.ConvertToken(bodyrelationshipCategorydcv);
                relationshipCategoryObjectpropCount++;
            }

            if (bodyrelationshipCategoryname != null)
            {
                relationshipCategoryObject["name"] = CSharpExpressionConverter.ConvertToken(bodyrelationshipCategoryname);
                relationshipCategoryObjectpropCount++;
            }

            if (bodyrelationshipCategoryicon != null)
            {
                relationshipCategoryObject["icon"] = CSharpExpressionConverter.ConvertToken(bodyrelationshipCategoryicon);
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
                characteristicObject["dcv"] = CSharpExpressionConverter.ConvertToken(bodyrelationshipCategorydcv);
                characteristicObjectpropCount++;
            }

            if (bodyrelationshipCategoryname != null)
            {
                characteristicObject["name"] = CSharpExpressionConverter.ConvertToken(bodyrelationshipCategoryname);
                characteristicObjectpropCount++;
            }

            if (bodyrelationshipCategoryicon != null)
            {
                characteristicObject["icon"] = CSharpExpressionConverter.ConvertToken(bodyrelationshipCategoryicon);
                characteristicObjectpropCount++;
            }

            if (characteristicObjectpropCount > 0)
            {
                body["characteristic"] = characteristicObject;
                bodypropCount++;
            }

            if (bodyopenLocation != null)
            {
                body["openLocation"] = CSharpExpressionConverter.ConvertToken(bodyopenLocation);
                bodypropCount++;
            }

            if (bodydata != null)
            {
                body["data"] = CSharpExpressionConverter.ConvertToken(bodydata);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<IField>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IBodyWorkflowAction<IField> UpdateListSingleField(Expression<Func<string>> dbId, Expression<Func<dataLanguageInput>> dataLanguage, Expression<Func<string>> topicId, Expression<Func<string>> fieldsetId, Expression<Func<string>> fieldId, Expression<Func<string>> bodyfieldsetId = null, Expression<Func<string>> bodyfieldId = null, Expression<Func<int>> bodysetOrder = null, Expression<Func<int>> bodyorder = null, Expression<Func<string>> bodytopicId = null, Expression<Func<string>> bodysetName = null, Expression<Func<string>> bodyfieldName = null, Expression<Func<bodyfieldValueTypeInput>> bodyfieldValueType = null, Expression<Func<bool>> bodyrequired = null, Expression<Func<bool>> bodyreadonly = null, Expression<Func<string>> bodyusage = null, Expression<Func<string>> bodyrelationshipCategorydcv = null, Expression<Func<string>> bodyrelationshipCategoryname = null, Expression<Func<string>> bodyrelationshipCategoryicon = null, Expression<Func<string>> bodycharacteristicdcv = null, Expression<Func<string>> bodycharacteristicname = null, Expression<Func<string>> bodycharacteristicicon = null, Expression<Func<string>> bodyopenLocation = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v1/{0}/{1}/topic/{2}/fieldsets/{3}/list/{4}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dbId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataLanguage, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(topicId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(fieldsetId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(fieldId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyfieldsetId != null)
            {
                body["fieldsetId"] = CSharpExpressionConverter.ConvertToken(bodyfieldsetId);
                bodypropCount++;
            }

            if (bodyfieldId != null)
            {
                body["fieldId"] = CSharpExpressionConverter.ConvertToken(bodyfieldId);
                bodypropCount++;
            }

            if (bodysetOrder != null)
            {
                body["setOrder"] = CSharpExpressionConverter.ConvertToken(bodysetOrder);
                bodypropCount++;
            }

            if (bodyorder != null)
            {
                body["order"] = CSharpExpressionConverter.ConvertToken(bodyorder);
                bodypropCount++;
            }

            if (bodytopicId != null)
            {
                body["topicId"] = CSharpExpressionConverter.ConvertToken(bodytopicId);
                bodypropCount++;
            }

            if (bodysetName != null)
            {
                body["setName"] = CSharpExpressionConverter.ConvertToken(bodysetName);
                bodypropCount++;
            }

            if (bodyfieldName != null)
            {
                body["fieldName"] = CSharpExpressionConverter.ConvertToken(bodyfieldName);
                bodypropCount++;
            }

            if (bodyfieldValueType != null)
            {
                body["fieldValueType"] = CSharpExpressionConverter.Convert(bodyfieldValueType);
                bodypropCount++;
            }

            if (bodyrequired != null)
            {
                body["required"] = CSharpExpressionConverter.ConvertToken(bodyrequired);
                bodypropCount++;
            }

            if (bodyreadonly != null)
            {
                body["readonly"] = CSharpExpressionConverter.ConvertToken(bodyreadonly);
                bodypropCount++;
            }

            if (bodyusage != null)
            {
                body["usage"] = CSharpExpressionConverter.ConvertToken(bodyusage);
                bodypropCount++;
            }

            var relationshipCategoryObject = new JObject();
            var relationshipCategoryObjectpropCount = 0;
            if (bodyrelationshipCategorydcv != null)
            {
                relationshipCategoryObject["dcv"] = CSharpExpressionConverter.ConvertToken(bodyrelationshipCategorydcv);
                relationshipCategoryObjectpropCount++;
            }

            if (bodyrelationshipCategoryname != null)
            {
                relationshipCategoryObject["name"] = CSharpExpressionConverter.ConvertToken(bodyrelationshipCategoryname);
                relationshipCategoryObjectpropCount++;
            }

            if (bodyrelationshipCategoryicon != null)
            {
                relationshipCategoryObject["icon"] = CSharpExpressionConverter.ConvertToken(bodyrelationshipCategoryicon);
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
                characteristicObject["dcv"] = CSharpExpressionConverter.ConvertToken(bodyrelationshipCategorydcv);
                characteristicObjectpropCount++;
            }

            if (bodyrelationshipCategoryname != null)
            {
                characteristicObject["name"] = CSharpExpressionConverter.ConvertToken(bodyrelationshipCategoryname);
                characteristicObjectpropCount++;
            }

            if (bodyrelationshipCategoryicon != null)
            {
                characteristicObject["icon"] = CSharpExpressionConverter.ConvertToken(bodyrelationshipCategoryicon);
                characteristicObjectpropCount++;
            }

            if (characteristicObjectpropCount > 0)
            {
                body["characteristic"] = characteristicObject;
                bodypropCount++;
            }

            if (bodyopenLocation != null)
            {
                body["openLocation"] = CSharpExpressionConverter.ConvertToken(bodyopenLocation);
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
        public IBodyWorkflowAction<IField> UpdateRelationshipSingleField(Expression<Func<string>> dbId, Expression<Func<dataLanguageInput>> dataLanguage, Expression<Func<string>> topicId, Expression<Func<string>> fieldsetId, Expression<Func<string>> fieldId, Expression<Func<string>> bodyfieldId = null, Expression<Func<string>> bodyfieldsetId = null, Expression<Func<string>> bodydatadcv = null, Expression<Func<string>> bodydataname = null, Expression<Func<string>> bodydataicon = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v1/{0}/{1}/topic/{2}/fieldsets/{3}/relationship/{4}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dbId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataLanguage, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(topicId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(fieldsetId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(fieldId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyfieldId != null)
            {
                body["fieldId"] = CSharpExpressionConverter.ConvertToken(bodyfieldId);
                bodypropCount++;
            }

            if (bodyfieldsetId != null)
            {
                body["fieldsetId"] = CSharpExpressionConverter.ConvertToken(bodyfieldsetId);
                bodypropCount++;
            }

            var dataObject = new JObject();
            var dataObjectpropCount = 0;
            if (bodydatadcv != null)
            {
                dataObject["dcv"] = CSharpExpressionConverter.ConvertToken(bodydatadcv);
                dataObjectpropCount++;
            }

            if (bodydataname != null)
            {
                dataObject["name"] = CSharpExpressionConverter.ConvertToken(bodydataname);
                dataObjectpropCount++;
            }

            if (bodydataicon != null)
            {
                dataObject["icon"] = CSharpExpressionConverter.ConvertToken(bodydataicon);
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
        public IBodyWorkflowAction<IField> UpdateRelationshipMultiField(Expression<Func<string>> dbId, Expression<Func<dataLanguageInput>> dataLanguage, Expression<Func<string>> topicId, Expression<Func<string>> fieldsetId, Expression<Func<string>> fieldId, Expression<Func<string>> bodyfieldId = null, Expression<Func<string>> bodyfieldsetId = null, Expression<Func<RelationshipElement[]>> bodydata = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v1/{0}/{1}/topic/{2}/fieldsets/{3}/multirelationship/{4}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dbId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataLanguage, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(topicId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(fieldsetId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(fieldId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyfieldId != null)
            {
                body["fieldId"] = CSharpExpressionConverter.ConvertToken(bodyfieldId);
                bodypropCount++;
            }

            if (bodyfieldsetId != null)
            {
                body["fieldsetId"] = CSharpExpressionConverter.ConvertToken(bodyfieldsetId);
                bodypropCount++;
            }

            if (bodydata != null)
            {
                body["data"] = CSharpExpressionConverter.ConvertToken(bodydata);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<IField>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IBodyWorkflowAction<IField> UpdateRelationshipListField(Expression<Func<string>> dbId, Expression<Func<dataLanguageInput>> dataLanguage, Expression<Func<string>> topicId, Expression<Func<string>> fieldsetId, Expression<Func<string>> fieldId, Expression<Func<string>> bodyfieldId = null, Expression<Func<string>> bodyfieldsetId = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v1/{0}/{1}/topic/{2}/fieldsets/{3}/relationshiplist/{4}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dbId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataLanguage, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(topicId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(fieldsetId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(fieldId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyfieldId != null)
            {
                body["fieldId"] = CSharpExpressionConverter.ConvertToken(bodyfieldId);
                bodypropCount++;
            }

            if (bodyfieldsetId != null)
            {
                body["fieldsetId"] = CSharpExpressionConverter.ConvertToken(bodyfieldsetId);
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
        public IBodyWorkflowAction<IField> UpdateFields(Expression<Func<string>> dbId, Expression<Func<dataLanguageInput>> dataLanguage, Expression<Func<string>> topicId, Expression<Func<SingleTextField[]>> bodysingleTextFields = null, Expression<Func<MultiTextField[]>> bodymultiTextFields = null, Expression<Func<SingleNumberField[]>> bodysingleNumberFields = null, Expression<Func<MultiNumberField[]>> bodymultiNumberFields = null, Expression<Func<SingleBooleanField[]>> bodysingleBooleanFields = null, Expression<Func<SingleDecimalField[]>> bodysingleDecimalFields = null, Expression<Func<MultiDecimalField[]>> bodymultiDecimalFields = null, Expression<Func<SingleDateField[]>> bodysingleDateFields = null, Expression<Func<MultiDateField[]>> bodymultiDateFields = null, Expression<Func<SingleListField[]>> bodysingleListFields = null, Expression<Func<RelationshipField[]>> bodysingleRelationshipFields = null, Expression<Func<MultiRelationshipField[]>> bodymultiRelationshipFields = null, Expression<Func<RelationshipListField[]>> bodysingleRelationshipListFields = null, Expression<Func<SingleHyperlinkField[]>> bodysingleHyperlinkFields = null, Expression<Func<MultiHyperlinkField[]>> bodymultiHyperlinkFields = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v1/{0}/{1}/topic/{2}/fields", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dbId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataLanguage, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(topicId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodysingleTextFields != null)
            {
                body["singleTextFields"] = CSharpExpressionConverter.ConvertToken(bodysingleTextFields);
                bodypropCount++;
            }

            if (bodymultiTextFields != null)
            {
                body["multiTextFields"] = CSharpExpressionConverter.ConvertToken(bodymultiTextFields);
                bodypropCount++;
            }

            if (bodysingleNumberFields != null)
            {
                body["singleNumberFields"] = CSharpExpressionConverter.ConvertToken(bodysingleNumberFields);
                bodypropCount++;
            }

            if (bodymultiNumberFields != null)
            {
                body["multiNumberFields"] = CSharpExpressionConverter.ConvertToken(bodymultiNumberFields);
                bodypropCount++;
            }

            if (bodysingleBooleanFields != null)
            {
                body["singleBooleanFields"] = CSharpExpressionConverter.ConvertToken(bodysingleBooleanFields);
                bodypropCount++;
            }

            if (bodysingleDecimalFields != null)
            {
                body["singleDecimalFields"] = CSharpExpressionConverter.ConvertToken(bodysingleDecimalFields);
                bodypropCount++;
            }

            if (bodymultiDecimalFields != null)
            {
                body["multiDecimalFields"] = CSharpExpressionConverter.ConvertToken(bodymultiDecimalFields);
                bodypropCount++;
            }

            if (bodysingleDateFields != null)
            {
                body["singleDateFields"] = CSharpExpressionConverter.ConvertToken(bodysingleDateFields);
                bodypropCount++;
            }

            if (bodymultiDateFields != null)
            {
                body["multiDateFields"] = CSharpExpressionConverter.ConvertToken(bodymultiDateFields);
                bodypropCount++;
            }

            if (bodysingleListFields != null)
            {
                body["singleListFields"] = CSharpExpressionConverter.ConvertToken(bodysingleListFields);
                bodypropCount++;
            }

            if (bodysingleRelationshipFields != null)
            {
                body["singleRelationshipFields"] = CSharpExpressionConverter.ConvertToken(bodysingleRelationshipFields);
                bodypropCount++;
            }

            if (bodymultiRelationshipFields != null)
            {
                body["multiRelationshipFields"] = CSharpExpressionConverter.ConvertToken(bodymultiRelationshipFields);
                bodypropCount++;
            }

            if (bodysingleRelationshipListFields != null)
            {
                body["singleRelationshipListFields"] = CSharpExpressionConverter.ConvertToken(bodysingleRelationshipListFields);
                bodypropCount++;
            }

            if (bodysingleHyperlinkFields != null)
            {
                body["singleHyperlinkFields"] = CSharpExpressionConverter.ConvertToken(bodysingleHyperlinkFields);
                bodypropCount++;
            }

            if (bodymultiHyperlinkFields != null)
            {
                body["multiHyperlinkFields"] = CSharpExpressionConverter.ConvertToken(bodymultiHyperlinkFields);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<IField>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IBodyWorkflowAction<IField> UpdateSingleHyperlinkField(Expression<Func<string>> dbId, Expression<Func<dataLanguageInput>> dataLanguage, Expression<Func<string>> topicId, Expression<Func<string>> fieldsetId, Expression<Func<string>> fieldId, Expression<Func<string>> bodydata = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v1/{0}/{1}/topic/{2}/fieldsets/{3}/hyperlink/{4}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dbId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataLanguage, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(topicId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(fieldsetId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(fieldId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodydata != null)
            {
                body["data"] = CSharpExpressionConverter.ConvertToken(bodydata);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<IField>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IBodyWorkflowAction<IField> UpdateMultiHyperlinkField(Expression<Func<string>> dbId, Expression<Func<dataLanguageInput>> dataLanguage, Expression<Func<string>> topicId, Expression<Func<string>> fieldsetId, Expression<Func<string>> fieldId, Expression<Func<string[]>> bodydata = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v1/{0}/{1}/topic/{2}/fieldsets/{3}/multihyperlink/{4}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dbId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataLanguage, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(topicId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(fieldsetId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(fieldId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodydata != null)
            {
                body["data"] = CSharpExpressionConverter.ConvertToken(bodydata);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<IField>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IWorkflowAction MoveTopicToTop(Expression<Func<string>> dbId, Expression<Func<dataLanguageInput>> dataLanguage, Expression<Func<string>> topicId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v1/{0}/{1}/topic/{2}/movetotop", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dbId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataLanguage, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(topicId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IWorkflowAction MoveTopicToBottom(Expression<Func<string>> dbId, Expression<Func<dataLanguageInput>> dataLanguage, Expression<Func<string>> topicId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v1/{0}/{1}/topic/{2}/movetobottom", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dbId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataLanguage, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(topicId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IWorkflowAction MoveTopicUp(Expression<Func<string>> dbId, Expression<Func<dataLanguageInput>> dataLanguage, Expression<Func<string>> topicId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v1/{0}/{1}/topic/{2}/moveup", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dbId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataLanguage, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(topicId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IWorkflowAction MoveTopicDown(Expression<Func<string>> dbId, Expression<Func<dataLanguageInput>> dataLanguage, Expression<Func<string>> topicId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v1/{0}/{1}/topic/{2}/movedown", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dbId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataLanguage, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(topicId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IWorkflowAction MoveTopicLevelUp(Expression<Func<string>> dbId, Expression<Func<dataLanguageInput>> dataLanguage, Expression<Func<string>> topicId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v1/{0}/{1}/topic/{2}/movelevelup", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dbId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataLanguage, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(topicId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IWorkflowAction MoveTopicLevelDown(Expression<Func<string>> dbId, Expression<Func<dataLanguageInput>> dataLanguage, Expression<Func<string>> topicId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v1/{0}/{1}/topic/{2}/moveleveldown", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dbId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataLanguage, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(topicId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IBodyWorkflowAction<IRelationship[]> GetTopicRelations(Expression<Func<string>> dbId, Expression<Func<dataLanguageInput>> dataLanguage, Expression<Func<string>> topicId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v1/{0}/{1}/topic/{2}/relations", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dbId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataLanguage, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(topicId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<IRelationship[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IBodyWorkflowAction<IRelationship> SaveRelation(Expression<Func<string>> dbId, Expression<Func<dataLanguageInput>> dataLanguage, Expression<Func<string>> bodyfromElementDcv = null, Expression<Func<string>> bodytoElementDcv = null, Expression<Func<bodyrelationshipTypeInput>> bodyrelationshipType = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v1/{0}/{1}/relation", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dbId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataLanguage, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyfromElementDcv != null)
            {
                body["fromElementDcv"] = CSharpExpressionConverter.ConvertToken(bodyfromElementDcv);
                bodypropCount++;
            }

            if (bodytoElementDcv != null)
            {
                body["toElementDcv"] = CSharpExpressionConverter.ConvertToken(bodytoElementDcv);
                bodypropCount++;
            }

            if (bodyrelationshipType != null)
            {
                body["relationshipType"] = CSharpExpressionConverter.Convert(bodyrelationshipType);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<IRelationship>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IWorkflowAction DeleteRelation(Expression<Func<string>> dbId, Expression<Func<dataLanguageInput>> dataLanguage, Expression<Func<string>> topicId, Expression<Func<string>> relationId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v1/{0}/{1}/topic/{2}/relation/{3}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dbId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataLanguage, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(topicId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(relationId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IBodyWorkflowAction<ITopic> GetTopicRoot(Expression<Func<string>> dbId, Expression<Func<dataLanguageInput>> dataLanguage)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v1/{0}/{1}/root", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dbId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataLanguage, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ITopic>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IBodyWorkflowAction<ITopicPath> GetPathToRoot(Expression<Func<string>> dbId, Expression<Func<dataLanguageInput>> dataLanguage, Expression<Func<string>> topicId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v1/{0}/{1}/path/{2}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dbId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataLanguage, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(topicId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ITopicPath>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IBodyWorkflowAction<ITopic[]> GetTopicSiblings(Expression<Func<string>> dbId, Expression<Func<dataLanguageInput>> dataLanguage, Expression<Func<string>> topicId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v1/{0}/{1}/topic/{2}/siblings", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dbId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataLanguage, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(topicId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ITopic[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IBodyWorkflowAction<ITopic[]> GetRelationCategories(Expression<Func<string>> dbId, Expression<Func<dataLanguageInput>> dataLanguage)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v1/{0}/{1}/topic/categories", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dbId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataLanguage, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ITopic[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IBodyWorkflowAction<JToken> GetTopicTypes(Expression<Func<string>> dbId, Expression<Func<dataLanguageInput>> dataLanguage, Expression<Func<string>> topicId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v1/{0}/{1}/topic/{2}/types", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dbId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataLanguage, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(topicId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IBodyWorkflowAction<JToken> GetTopicIcons(Expression<Func<string>> dbId, Expression<Func<dataLanguageInput>> dataLanguage, Expression<Func<string>> topicType)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v1/{0}/{1}/types/{2}/icons", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dbId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataLanguage, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(topicType, 1));
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