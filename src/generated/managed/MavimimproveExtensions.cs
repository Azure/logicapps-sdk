//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Mavimimprove
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class MavimimproveActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IBodyWorkflowAction<IChart[]> GetTopicCharts(Expression<Func<string>> dbId, Expression<Func<dataLanguageInput>> dataLanguage, Expression<Func<string>> topicId)
        {
            var __workflow_dbId = WorkflowExpression.Compile(dbId, nameof(dbId), required: true);
            var __workflow_dataLanguage = WorkflowExpression.Compile(dataLanguage, nameof(dataLanguage), required: true);
            var __workflow_topicId = WorkflowExpression.Compile(topicId, nameof(topicId), required: true);
            return new DeferredBodyAction<IChart[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/{0}/{1}/topic/{2}/charts", ExpressionConverter.ConvertWithUrlEncoding(__workflow_dbId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_dataLanguage, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_topicId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<IChart[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IBodyWorkflowAction<ITopic> CreateTopicAfter(Expression<Func<string>> dbId, Expression<Func<dataLanguageInput>> dataLanguage, Expression<Func<string>> topicId, Expression<Func<string>> bodyname, Expression<Func<string>> bodytype, Expression<Func<string>> bodyicon)
        {
            var __workflow_dbId = WorkflowExpression.Compile(dbId, nameof(dbId), required: true);
            var __workflow_dataLanguage = WorkflowExpression.Compile(dataLanguage, nameof(dataLanguage), required: true);
            var __workflow_topicId = WorkflowExpression.Compile(topicId, nameof(topicId), required: true);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: true);
            var __workflow_bodytype = WorkflowExpression.Compile(bodytype, nameof(bodytype), required: true);
            var __workflow_bodyicon = WorkflowExpression.Compile(bodyicon, nameof(bodyicon), required: true);
            return new DeferredBodyAction<ITopic>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/{0}/{1}/topic/{2}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_dbId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_dataLanguage, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_topicId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                bodypropCount++;
                body["type"] = ExpressionConverter.ConvertO(__workflow_bodytype);
                bodypropCount++;
                body["icon"] = ExpressionConverter.ConvertO(__workflow_bodyicon);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ITopic>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IBodyWorkflowAction<ITopic> DeleteTopic(Expression<Func<string>> dbId, Expression<Func<dataLanguageInput>> dataLanguage, Expression<Func<string>> topicId)
        {
            var __workflow_dbId = WorkflowExpression.Compile(dbId, nameof(dbId), required: true);
            var __workflow_dataLanguage = WorkflowExpression.Compile(dataLanguage, nameof(dataLanguage), required: true);
            var __workflow_topicId = WorkflowExpression.Compile(topicId, nameof(topicId), required: true);
            return new DeferredBodyAction<ITopic>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/{0}/{1}/topic/{2}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_dbId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_dataLanguage, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_topicId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ITopic>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IBodyWorkflowAction<ITopic> GetTopic(Expression<Func<string>> dbId, Expression<Func<dataLanguageInput>> dataLanguage, Expression<Func<string>> topicId)
        {
            var __workflow_dbId = WorkflowExpression.Compile(dbId, nameof(dbId), required: true);
            var __workflow_dataLanguage = WorkflowExpression.Compile(dataLanguage, nameof(dataLanguage), required: true);
            var __workflow_topicId = WorkflowExpression.Compile(topicId, nameof(topicId), required: true);
            return new DeferredBodyAction<ITopic>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/{0}/{1}/topic/{2}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_dbId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_dataLanguage, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_topicId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ITopic>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IBodyWorkflowAction<ITopic> UpdateTopic(Expression<Func<string>> dbId, Expression<Func<dataLanguageInput>> dataLanguage, Expression<Func<string>> topicId, Expression<Func<string>> bodyname = null)
        {
            var __workflow_dbId = WorkflowExpression.Compile(dbId, nameof(dbId), required: true);
            var __workflow_dataLanguage = WorkflowExpression.Compile(dataLanguage, nameof(dataLanguage), required: true);
            var __workflow_topicId = WorkflowExpression.Compile(topicId, nameof(topicId), required: true);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            return new DeferredBodyAction<ITopic>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/{0}/{1}/topic/{2}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_dbId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_dataLanguage, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_topicId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
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
        public IBodyWorkflowAction<ITopic> CreateChildTopic(Expression<Func<string>> dbId, Expression<Func<dataLanguageInput>> dataLanguage, Expression<Func<string>> topicId, Expression<Func<string>> bodyname, Expression<Func<string>> bodytype, Expression<Func<string>> bodyicon)
        {
            var __workflow_dbId = WorkflowExpression.Compile(dbId, nameof(dbId), required: true);
            var __workflow_dataLanguage = WorkflowExpression.Compile(dataLanguage, nameof(dataLanguage), required: true);
            var __workflow_topicId = WorkflowExpression.Compile(topicId, nameof(topicId), required: true);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: true);
            var __workflow_bodytype = WorkflowExpression.Compile(bodytype, nameof(bodytype), required: true);
            var __workflow_bodyicon = WorkflowExpression.Compile(bodyicon, nameof(bodyicon), required: true);
            return new DeferredBodyAction<ITopic>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/{0}/{1}/topic/{2}/children", ExpressionConverter.ConvertWithUrlEncoding(__workflow_dbId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_dataLanguage, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_topicId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                bodypropCount++;
                body["type"] = ExpressionConverter.ConvertO(__workflow_bodytype);
                bodypropCount++;
                body["icon"] = ExpressionConverter.ConvertO(__workflow_bodyicon);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ITopic>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IBodyWorkflowAction<ITopic[]> GetTopicChildren(Expression<Func<string>> dbId, Expression<Func<dataLanguageInput>> dataLanguage, Expression<Func<string>> topicId)
        {
            var __workflow_dbId = WorkflowExpression.Compile(dbId, nameof(dbId), required: true);
            var __workflow_dataLanguage = WorkflowExpression.Compile(dataLanguage, nameof(dataLanguage), required: true);
            var __workflow_topicId = WorkflowExpression.Compile(topicId, nameof(topicId), required: true);
            return new DeferredBodyAction<ITopic[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/{0}/{1}/topic/{2}/children", ExpressionConverter.ConvertWithUrlEncoding(__workflow_dbId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_dataLanguage, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_topicId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ITopic[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IBodyWorkflowAction<IField[]> GetTopicFields(Expression<Func<string>> dbId, Expression<Func<dataLanguageInput>> dataLanguage, Expression<Func<string>> topicId)
        {
            var __workflow_dbId = WorkflowExpression.Compile(dbId, nameof(dbId), required: true);
            var __workflow_dataLanguage = WorkflowExpression.Compile(dataLanguage, nameof(dataLanguage), required: true);
            var __workflow_topicId = WorkflowExpression.Compile(topicId, nameof(topicId), required: true);
            return new DeferredBodyAction<IField[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/{0}/{1}/topic/{2}/fieldsets", ExpressionConverter.ConvertWithUrlEncoding(__workflow_dbId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_dataLanguage, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_topicId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<IField[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IBodyWorkflowAction<IField> GetFieldByDcvAndFieldsetId(Expression<Func<string>> dbId, Expression<Func<dataLanguageInput>> dataLanguage, Expression<Func<string>> topicId, Expression<Func<string>> fieldsetId, Expression<Func<string>> fieldId)
        {
            var __workflow_dbId = WorkflowExpression.Compile(dbId, nameof(dbId), required: true);
            var __workflow_dataLanguage = WorkflowExpression.Compile(dataLanguage, nameof(dataLanguage), required: true);
            var __workflow_topicId = WorkflowExpression.Compile(topicId, nameof(topicId), required: true);
            var __workflow_fieldsetId = WorkflowExpression.Compile(fieldsetId, nameof(fieldsetId), required: true);
            var __workflow_fieldId = WorkflowExpression.Compile(fieldId, nameof(fieldId), required: true);
            return new DeferredBodyAction<IField>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/{0}/{1}/topic/{2}/fieldsets/{3}/{4}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_dbId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_dataLanguage, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_topicId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_fieldsetId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_fieldId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<IField>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IBodyWorkflowAction<IField> UpdateBooleanSingleField(Expression<Func<string>> dbId, Expression<Func<dataLanguageInput>> dataLanguage, Expression<Func<string>> topicId, Expression<Func<string>> fieldsetId, Expression<Func<string>> fieldId, Expression<Func<string>> bodyfieldsetId = null, Expression<Func<string>> bodyfieldId = null, Expression<Func<int>> bodysetOrder = null, Expression<Func<int>> bodyorder = null, Expression<Func<string>> bodytopicId = null, Expression<Func<string>> bodysetName = null, Expression<Func<string>> bodyfieldName = null, Expression<Func<bodyfieldValueTypeInput>> bodyfieldValueType = null, Expression<Func<bool>> bodyrequired = null, Expression<Func<bool>> bodyreadonly = null, Expression<Func<string>> bodyusage = null, Expression<Func<string>> bodyrelationshipCategorydcv = null, Expression<Func<string>> bodyrelationshipCategoryname = null, Expression<Func<string>> bodyrelationshipCategoryicon = null, Expression<Func<string>> bodycharacteristicdcv = null, Expression<Func<string>> bodycharacteristicname = null, Expression<Func<string>> bodycharacteristicicon = null, Expression<Func<string>> bodyopenLocation = null, Expression<Func<bool>> bodydata = null)
        {
            var __workflow_dbId = WorkflowExpression.Compile(dbId, nameof(dbId), required: true);
            var __workflow_dataLanguage = WorkflowExpression.Compile(dataLanguage, nameof(dataLanguage), required: true);
            var __workflow_topicId = WorkflowExpression.Compile(topicId, nameof(topicId), required: true);
            var __workflow_fieldsetId = WorkflowExpression.Compile(fieldsetId, nameof(fieldsetId), required: true);
            var __workflow_fieldId = WorkflowExpression.Compile(fieldId, nameof(fieldId), required: true);
            var __workflow_bodyfieldsetId = WorkflowExpression.Compile(bodyfieldsetId, nameof(bodyfieldsetId), required: false);
            var __workflow_bodyfieldId = WorkflowExpression.Compile(bodyfieldId, nameof(bodyfieldId), required: false);
            var __workflow_bodysetOrder = WorkflowExpression.Compile(bodysetOrder, nameof(bodysetOrder), required: false);
            var __workflow_bodyorder = WorkflowExpression.Compile(bodyorder, nameof(bodyorder), required: false);
            var __workflow_bodytopicId = WorkflowExpression.Compile(bodytopicId, nameof(bodytopicId), required: false);
            var __workflow_bodysetName = WorkflowExpression.Compile(bodysetName, nameof(bodysetName), required: false);
            var __workflow_bodyfieldName = WorkflowExpression.Compile(bodyfieldName, nameof(bodyfieldName), required: false);
            var __workflow_bodyfieldValueType = WorkflowExpression.Compile(bodyfieldValueType, nameof(bodyfieldValueType), required: false);
            var __workflow_bodyrequired = WorkflowExpression.Compile(bodyrequired, nameof(bodyrequired), required: false);
            var __workflow_bodyreadonly = WorkflowExpression.Compile(bodyreadonly, nameof(bodyreadonly), required: false);
            var __workflow_bodyusage = WorkflowExpression.Compile(bodyusage, nameof(bodyusage), required: false);
            var __workflow_bodyrelationshipCategorydcv = WorkflowExpression.Compile(bodyrelationshipCategorydcv, nameof(bodyrelationshipCategorydcv), required: false);
            var __workflow_bodyrelationshipCategoryname = WorkflowExpression.Compile(bodyrelationshipCategoryname, nameof(bodyrelationshipCategoryname), required: false);
            var __workflow_bodyrelationshipCategoryicon = WorkflowExpression.Compile(bodyrelationshipCategoryicon, nameof(bodyrelationshipCategoryicon), required: false);
            var __workflow_bodycharacteristicdcv = WorkflowExpression.Compile(bodycharacteristicdcv, nameof(bodycharacteristicdcv), required: false);
            var __workflow_bodycharacteristicname = WorkflowExpression.Compile(bodycharacteristicname, nameof(bodycharacteristicname), required: false);
            var __workflow_bodycharacteristicicon = WorkflowExpression.Compile(bodycharacteristicicon, nameof(bodycharacteristicicon), required: false);
            var __workflow_bodyopenLocation = WorkflowExpression.Compile(bodyopenLocation, nameof(bodyopenLocation), required: false);
            var __workflow_bodydata = WorkflowExpression.Compile(bodydata, nameof(bodydata), required: false);
            return new DeferredBodyAction<IField>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/{0}/{1}/topic/{2}/fieldsets/{3}/bool/{4}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_dbId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_dataLanguage, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_topicId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_fieldsetId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_fieldId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyfieldsetId != null)
                {
                    body["fieldsetId"] = ExpressionConverter.ConvertO(__workflow_bodyfieldsetId);
                    bodypropCount++;
                }

                if (__workflow_bodyfieldId != null)
                {
                    body["fieldId"] = ExpressionConverter.ConvertO(__workflow_bodyfieldId);
                    bodypropCount++;
                }

                if (__workflow_bodysetOrder != null)
                {
                    body["setOrder"] = ExpressionConverter.ConvertO(__workflow_bodysetOrder);
                    bodypropCount++;
                }

                if (__workflow_bodyorder != null)
                {
                    body["order"] = ExpressionConverter.ConvertO(__workflow_bodyorder);
                    bodypropCount++;
                }

                if (__workflow_bodytopicId != null)
                {
                    body["topicId"] = ExpressionConverter.ConvertO(__workflow_bodytopicId);
                    bodypropCount++;
                }

                if (__workflow_bodysetName != null)
                {
                    body["setName"] = ExpressionConverter.ConvertO(__workflow_bodysetName);
                    bodypropCount++;
                }

                if (__workflow_bodyfieldName != null)
                {
                    body["fieldName"] = ExpressionConverter.ConvertO(__workflow_bodyfieldName);
                    bodypropCount++;
                }

                if (__workflow_bodyfieldValueType != null)
                {
                    body["fieldValueType"] = ExpressionConverter.ConvertO(__workflow_bodyfieldValueType);
                    bodypropCount++;
                }

                if (__workflow_bodyrequired != null)
                {
                    body["required"] = ExpressionConverter.ConvertO(__workflow_bodyrequired);
                    bodypropCount++;
                }

                if (__workflow_bodyreadonly != null)
                {
                    body["readonly"] = ExpressionConverter.ConvertO(__workflow_bodyreadonly);
                    bodypropCount++;
                }

                if (__workflow_bodyusage != null)
                {
                    body["usage"] = ExpressionConverter.ConvertO(__workflow_bodyusage);
                    bodypropCount++;
                }

                var relationshipCategoryObject = new JObject();
                var relationshipCategoryObjectpropCount = 0;
                if (__workflow_bodyrelationshipCategorydcv != null)
                {
                    relationshipCategoryObject["dcv"] = ExpressionConverter.ConvertO(__workflow_bodyrelationshipCategorydcv);
                    relationshipCategoryObjectpropCount++;
                }

                if (__workflow_bodyrelationshipCategoryname != null)
                {
                    relationshipCategoryObject["name"] = ExpressionConverter.ConvertO(__workflow_bodyrelationshipCategoryname);
                    relationshipCategoryObjectpropCount++;
                }

                if (__workflow_bodyrelationshipCategoryicon != null)
                {
                    relationshipCategoryObject["icon"] = ExpressionConverter.ConvertO(__workflow_bodyrelationshipCategoryicon);
                    relationshipCategoryObjectpropCount++;
                }

                if (relationshipCategoryObjectpropCount > 0)
                {
                    body["relationshipCategory"] = relationshipCategoryObject;
                    bodypropCount++;
                }

                var characteristicObject = new JObject();
                var characteristicObjectpropCount = 0;
                if (__workflow_bodyrelationshipCategorydcv != null)
                {
                    characteristicObject["dcv"] = ExpressionConverter.ConvertO(__workflow_bodyrelationshipCategorydcv);
                    characteristicObjectpropCount++;
                }

                if (__workflow_bodyrelationshipCategoryname != null)
                {
                    characteristicObject["name"] = ExpressionConverter.ConvertO(__workflow_bodyrelationshipCategoryname);
                    characteristicObjectpropCount++;
                }

                if (__workflow_bodyrelationshipCategoryicon != null)
                {
                    characteristicObject["icon"] = ExpressionConverter.ConvertO(__workflow_bodyrelationshipCategoryicon);
                    characteristicObjectpropCount++;
                }

                if (characteristicObjectpropCount > 0)
                {
                    body["characteristic"] = characteristicObject;
                    bodypropCount++;
                }

                if (__workflow_bodyopenLocation != null)
                {
                    body["openLocation"] = ExpressionConverter.ConvertO(__workflow_bodyopenLocation);
                    bodypropCount++;
                }

                if (__workflow_bodydata != null)
                {
                    body["data"] = ExpressionConverter.ConvertO(__workflow_bodydata);
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
        public IBodyWorkflowAction<IField> UpdateTextSingleField(Expression<Func<string>> dbId, Expression<Func<dataLanguageInput>> dataLanguage, Expression<Func<string>> topicId, Expression<Func<string>> fieldsetId, Expression<Func<string>> fieldId, Expression<Func<string>> bodyfieldsetId = null, Expression<Func<string>> bodyfieldId = null, Expression<Func<int>> bodysetOrder = null, Expression<Func<int>> bodyorder = null, Expression<Func<string>> bodytopicId = null, Expression<Func<string>> bodysetName = null, Expression<Func<string>> bodyfieldName = null, Expression<Func<bodyfieldValueTypeInput>> bodyfieldValueType = null, Expression<Func<bool>> bodyrequired = null, Expression<Func<bool>> bodyreadonly = null, Expression<Func<string>> bodyusage = null, Expression<Func<string>> bodyrelationshipCategorydcv = null, Expression<Func<string>> bodyrelationshipCategoryname = null, Expression<Func<string>> bodyrelationshipCategoryicon = null, Expression<Func<string>> bodycharacteristicdcv = null, Expression<Func<string>> bodycharacteristicname = null, Expression<Func<string>> bodycharacteristicicon = null, Expression<Func<string>> bodyopenLocation = null, Expression<Func<string>> bodydata = null)
        {
            var __workflow_dbId = WorkflowExpression.Compile(dbId, nameof(dbId), required: true);
            var __workflow_dataLanguage = WorkflowExpression.Compile(dataLanguage, nameof(dataLanguage), required: true);
            var __workflow_topicId = WorkflowExpression.Compile(topicId, nameof(topicId), required: true);
            var __workflow_fieldsetId = WorkflowExpression.Compile(fieldsetId, nameof(fieldsetId), required: true);
            var __workflow_fieldId = WorkflowExpression.Compile(fieldId, nameof(fieldId), required: true);
            var __workflow_bodyfieldsetId = WorkflowExpression.Compile(bodyfieldsetId, nameof(bodyfieldsetId), required: false);
            var __workflow_bodyfieldId = WorkflowExpression.Compile(bodyfieldId, nameof(bodyfieldId), required: false);
            var __workflow_bodysetOrder = WorkflowExpression.Compile(bodysetOrder, nameof(bodysetOrder), required: false);
            var __workflow_bodyorder = WorkflowExpression.Compile(bodyorder, nameof(bodyorder), required: false);
            var __workflow_bodytopicId = WorkflowExpression.Compile(bodytopicId, nameof(bodytopicId), required: false);
            var __workflow_bodysetName = WorkflowExpression.Compile(bodysetName, nameof(bodysetName), required: false);
            var __workflow_bodyfieldName = WorkflowExpression.Compile(bodyfieldName, nameof(bodyfieldName), required: false);
            var __workflow_bodyfieldValueType = WorkflowExpression.Compile(bodyfieldValueType, nameof(bodyfieldValueType), required: false);
            var __workflow_bodyrequired = WorkflowExpression.Compile(bodyrequired, nameof(bodyrequired), required: false);
            var __workflow_bodyreadonly = WorkflowExpression.Compile(bodyreadonly, nameof(bodyreadonly), required: false);
            var __workflow_bodyusage = WorkflowExpression.Compile(bodyusage, nameof(bodyusage), required: false);
            var __workflow_bodyrelationshipCategorydcv = WorkflowExpression.Compile(bodyrelationshipCategorydcv, nameof(bodyrelationshipCategorydcv), required: false);
            var __workflow_bodyrelationshipCategoryname = WorkflowExpression.Compile(bodyrelationshipCategoryname, nameof(bodyrelationshipCategoryname), required: false);
            var __workflow_bodyrelationshipCategoryicon = WorkflowExpression.Compile(bodyrelationshipCategoryicon, nameof(bodyrelationshipCategoryicon), required: false);
            var __workflow_bodycharacteristicdcv = WorkflowExpression.Compile(bodycharacteristicdcv, nameof(bodycharacteristicdcv), required: false);
            var __workflow_bodycharacteristicname = WorkflowExpression.Compile(bodycharacteristicname, nameof(bodycharacteristicname), required: false);
            var __workflow_bodycharacteristicicon = WorkflowExpression.Compile(bodycharacteristicicon, nameof(bodycharacteristicicon), required: false);
            var __workflow_bodyopenLocation = WorkflowExpression.Compile(bodyopenLocation, nameof(bodyopenLocation), required: false);
            var __workflow_bodydata = WorkflowExpression.Compile(bodydata, nameof(bodydata), required: false);
            return new DeferredBodyAction<IField>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/{0}/{1}/topic/{2}/fieldsets/{3}/text/{4}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_dbId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_dataLanguage, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_topicId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_fieldsetId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_fieldId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyfieldsetId != null)
                {
                    body["fieldsetId"] = ExpressionConverter.ConvertO(__workflow_bodyfieldsetId);
                    bodypropCount++;
                }

                if (__workflow_bodyfieldId != null)
                {
                    body["fieldId"] = ExpressionConverter.ConvertO(__workflow_bodyfieldId);
                    bodypropCount++;
                }

                if (__workflow_bodysetOrder != null)
                {
                    body["setOrder"] = ExpressionConverter.ConvertO(__workflow_bodysetOrder);
                    bodypropCount++;
                }

                if (__workflow_bodyorder != null)
                {
                    body["order"] = ExpressionConverter.ConvertO(__workflow_bodyorder);
                    bodypropCount++;
                }

                if (__workflow_bodytopicId != null)
                {
                    body["topicId"] = ExpressionConverter.ConvertO(__workflow_bodytopicId);
                    bodypropCount++;
                }

                if (__workflow_bodysetName != null)
                {
                    body["setName"] = ExpressionConverter.ConvertO(__workflow_bodysetName);
                    bodypropCount++;
                }

                if (__workflow_bodyfieldName != null)
                {
                    body["fieldName"] = ExpressionConverter.ConvertO(__workflow_bodyfieldName);
                    bodypropCount++;
                }

                if (__workflow_bodyfieldValueType != null)
                {
                    body["fieldValueType"] = ExpressionConverter.ConvertO(__workflow_bodyfieldValueType);
                    bodypropCount++;
                }

                if (__workflow_bodyrequired != null)
                {
                    body["required"] = ExpressionConverter.ConvertO(__workflow_bodyrequired);
                    bodypropCount++;
                }

                if (__workflow_bodyreadonly != null)
                {
                    body["readonly"] = ExpressionConverter.ConvertO(__workflow_bodyreadonly);
                    bodypropCount++;
                }

                if (__workflow_bodyusage != null)
                {
                    body["usage"] = ExpressionConverter.ConvertO(__workflow_bodyusage);
                    bodypropCount++;
                }

                var relationshipCategoryObject = new JObject();
                var relationshipCategoryObjectpropCount = 0;
                if (__workflow_bodyrelationshipCategorydcv != null)
                {
                    relationshipCategoryObject["dcv"] = ExpressionConverter.ConvertO(__workflow_bodyrelationshipCategorydcv);
                    relationshipCategoryObjectpropCount++;
                }

                if (__workflow_bodyrelationshipCategoryname != null)
                {
                    relationshipCategoryObject["name"] = ExpressionConverter.ConvertO(__workflow_bodyrelationshipCategoryname);
                    relationshipCategoryObjectpropCount++;
                }

                if (__workflow_bodyrelationshipCategoryicon != null)
                {
                    relationshipCategoryObject["icon"] = ExpressionConverter.ConvertO(__workflow_bodyrelationshipCategoryicon);
                    relationshipCategoryObjectpropCount++;
                }

                if (relationshipCategoryObjectpropCount > 0)
                {
                    body["relationshipCategory"] = relationshipCategoryObject;
                    bodypropCount++;
                }

                var characteristicObject = new JObject();
                var characteristicObjectpropCount = 0;
                if (__workflow_bodyrelationshipCategorydcv != null)
                {
                    characteristicObject["dcv"] = ExpressionConverter.ConvertO(__workflow_bodyrelationshipCategorydcv);
                    characteristicObjectpropCount++;
                }

                if (__workflow_bodyrelationshipCategoryname != null)
                {
                    characteristicObject["name"] = ExpressionConverter.ConvertO(__workflow_bodyrelationshipCategoryname);
                    characteristicObjectpropCount++;
                }

                if (__workflow_bodyrelationshipCategoryicon != null)
                {
                    characteristicObject["icon"] = ExpressionConverter.ConvertO(__workflow_bodyrelationshipCategoryicon);
                    characteristicObjectpropCount++;
                }

                if (characteristicObjectpropCount > 0)
                {
                    body["characteristic"] = characteristicObject;
                    bodypropCount++;
                }

                if (__workflow_bodyopenLocation != null)
                {
                    body["openLocation"] = ExpressionConverter.ConvertO(__workflow_bodyopenLocation);
                    bodypropCount++;
                }

                if (__workflow_bodydata != null)
                {
                    body["data"] = ExpressionConverter.ConvertO(__workflow_bodydata);
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
        public IBodyWorkflowAction<IField> UpdateTextMultiField(Expression<Func<string>> dbId, Expression<Func<dataLanguageInput>> dataLanguage, Expression<Func<string>> topicId, Expression<Func<string>> fieldsetId, Expression<Func<string>> fieldId, Expression<Func<string>> bodyfieldsetId = null, Expression<Func<string>> bodyfieldId = null, Expression<Func<int>> bodysetOrder = null, Expression<Func<int>> bodyorder = null, Expression<Func<string>> bodytopicId = null, Expression<Func<string>> bodysetName = null, Expression<Func<string>> bodyfieldName = null, Expression<Func<bodyfieldValueTypeInput>> bodyfieldValueType = null, Expression<Func<bool>> bodyrequired = null, Expression<Func<bool>> bodyreadonly = null, Expression<Func<string>> bodyusage = null, Expression<Func<string>> bodyrelationshipCategorydcv = null, Expression<Func<string>> bodyrelationshipCategoryname = null, Expression<Func<string>> bodyrelationshipCategoryicon = null, Expression<Func<string>> bodycharacteristicdcv = null, Expression<Func<string>> bodycharacteristicname = null, Expression<Func<string>> bodycharacteristicicon = null, Expression<Func<string>> bodyopenLocation = null, Expression<Func<string[]>> bodydata = null)
        {
            var __workflow_dbId = WorkflowExpression.Compile(dbId, nameof(dbId), required: true);
            var __workflow_dataLanguage = WorkflowExpression.Compile(dataLanguage, nameof(dataLanguage), required: true);
            var __workflow_topicId = WorkflowExpression.Compile(topicId, nameof(topicId), required: true);
            var __workflow_fieldsetId = WorkflowExpression.Compile(fieldsetId, nameof(fieldsetId), required: true);
            var __workflow_fieldId = WorkflowExpression.Compile(fieldId, nameof(fieldId), required: true);
            var __workflow_bodyfieldsetId = WorkflowExpression.Compile(bodyfieldsetId, nameof(bodyfieldsetId), required: false);
            var __workflow_bodyfieldId = WorkflowExpression.Compile(bodyfieldId, nameof(bodyfieldId), required: false);
            var __workflow_bodysetOrder = WorkflowExpression.Compile(bodysetOrder, nameof(bodysetOrder), required: false);
            var __workflow_bodyorder = WorkflowExpression.Compile(bodyorder, nameof(bodyorder), required: false);
            var __workflow_bodytopicId = WorkflowExpression.Compile(bodytopicId, nameof(bodytopicId), required: false);
            var __workflow_bodysetName = WorkflowExpression.Compile(bodysetName, nameof(bodysetName), required: false);
            var __workflow_bodyfieldName = WorkflowExpression.Compile(bodyfieldName, nameof(bodyfieldName), required: false);
            var __workflow_bodyfieldValueType = WorkflowExpression.Compile(bodyfieldValueType, nameof(bodyfieldValueType), required: false);
            var __workflow_bodyrequired = WorkflowExpression.Compile(bodyrequired, nameof(bodyrequired), required: false);
            var __workflow_bodyreadonly = WorkflowExpression.Compile(bodyreadonly, nameof(bodyreadonly), required: false);
            var __workflow_bodyusage = WorkflowExpression.Compile(bodyusage, nameof(bodyusage), required: false);
            var __workflow_bodyrelationshipCategorydcv = WorkflowExpression.Compile(bodyrelationshipCategorydcv, nameof(bodyrelationshipCategorydcv), required: false);
            var __workflow_bodyrelationshipCategoryname = WorkflowExpression.Compile(bodyrelationshipCategoryname, nameof(bodyrelationshipCategoryname), required: false);
            var __workflow_bodyrelationshipCategoryicon = WorkflowExpression.Compile(bodyrelationshipCategoryicon, nameof(bodyrelationshipCategoryicon), required: false);
            var __workflow_bodycharacteristicdcv = WorkflowExpression.Compile(bodycharacteristicdcv, nameof(bodycharacteristicdcv), required: false);
            var __workflow_bodycharacteristicname = WorkflowExpression.Compile(bodycharacteristicname, nameof(bodycharacteristicname), required: false);
            var __workflow_bodycharacteristicicon = WorkflowExpression.Compile(bodycharacteristicicon, nameof(bodycharacteristicicon), required: false);
            var __workflow_bodyopenLocation = WorkflowExpression.Compile(bodyopenLocation, nameof(bodyopenLocation), required: false);
            var __workflow_bodydata = WorkflowExpression.Compile(bodydata, nameof(bodydata), required: false);
            return new DeferredBodyAction<IField>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/{0}/{1}/topic/{2}/fieldsets/{3}/multitext/{4}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_dbId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_dataLanguage, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_topicId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_fieldsetId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_fieldId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyfieldsetId != null)
                {
                    body["fieldsetId"] = ExpressionConverter.ConvertO(__workflow_bodyfieldsetId);
                    bodypropCount++;
                }

                if (__workflow_bodyfieldId != null)
                {
                    body["fieldId"] = ExpressionConverter.ConvertO(__workflow_bodyfieldId);
                    bodypropCount++;
                }

                if (__workflow_bodysetOrder != null)
                {
                    body["setOrder"] = ExpressionConverter.ConvertO(__workflow_bodysetOrder);
                    bodypropCount++;
                }

                if (__workflow_bodyorder != null)
                {
                    body["order"] = ExpressionConverter.ConvertO(__workflow_bodyorder);
                    bodypropCount++;
                }

                if (__workflow_bodytopicId != null)
                {
                    body["topicId"] = ExpressionConverter.ConvertO(__workflow_bodytopicId);
                    bodypropCount++;
                }

                if (__workflow_bodysetName != null)
                {
                    body["setName"] = ExpressionConverter.ConvertO(__workflow_bodysetName);
                    bodypropCount++;
                }

                if (__workflow_bodyfieldName != null)
                {
                    body["fieldName"] = ExpressionConverter.ConvertO(__workflow_bodyfieldName);
                    bodypropCount++;
                }

                if (__workflow_bodyfieldValueType != null)
                {
                    body["fieldValueType"] = ExpressionConverter.ConvertO(__workflow_bodyfieldValueType);
                    bodypropCount++;
                }

                if (__workflow_bodyrequired != null)
                {
                    body["required"] = ExpressionConverter.ConvertO(__workflow_bodyrequired);
                    bodypropCount++;
                }

                if (__workflow_bodyreadonly != null)
                {
                    body["readonly"] = ExpressionConverter.ConvertO(__workflow_bodyreadonly);
                    bodypropCount++;
                }

                if (__workflow_bodyusage != null)
                {
                    body["usage"] = ExpressionConverter.ConvertO(__workflow_bodyusage);
                    bodypropCount++;
                }

                var relationshipCategoryObject = new JObject();
                var relationshipCategoryObjectpropCount = 0;
                if (__workflow_bodyrelationshipCategorydcv != null)
                {
                    relationshipCategoryObject["dcv"] = ExpressionConverter.ConvertO(__workflow_bodyrelationshipCategorydcv);
                    relationshipCategoryObjectpropCount++;
                }

                if (__workflow_bodyrelationshipCategoryname != null)
                {
                    relationshipCategoryObject["name"] = ExpressionConverter.ConvertO(__workflow_bodyrelationshipCategoryname);
                    relationshipCategoryObjectpropCount++;
                }

                if (__workflow_bodyrelationshipCategoryicon != null)
                {
                    relationshipCategoryObject["icon"] = ExpressionConverter.ConvertO(__workflow_bodyrelationshipCategoryicon);
                    relationshipCategoryObjectpropCount++;
                }

                if (relationshipCategoryObjectpropCount > 0)
                {
                    body["relationshipCategory"] = relationshipCategoryObject;
                    bodypropCount++;
                }

                var characteristicObject = new JObject();
                var characteristicObjectpropCount = 0;
                if (__workflow_bodyrelationshipCategorydcv != null)
                {
                    characteristicObject["dcv"] = ExpressionConverter.ConvertO(__workflow_bodyrelationshipCategorydcv);
                    characteristicObjectpropCount++;
                }

                if (__workflow_bodyrelationshipCategoryname != null)
                {
                    characteristicObject["name"] = ExpressionConverter.ConvertO(__workflow_bodyrelationshipCategoryname);
                    characteristicObjectpropCount++;
                }

                if (__workflow_bodyrelationshipCategoryicon != null)
                {
                    characteristicObject["icon"] = ExpressionConverter.ConvertO(__workflow_bodyrelationshipCategoryicon);
                    characteristicObjectpropCount++;
                }

                if (characteristicObjectpropCount > 0)
                {
                    body["characteristic"] = characteristicObject;
                    bodypropCount++;
                }

                if (__workflow_bodyopenLocation != null)
                {
                    body["openLocation"] = ExpressionConverter.ConvertO(__workflow_bodyopenLocation);
                    bodypropCount++;
                }

                if (__workflow_bodydata != null)
                {
                    body["data"] = ExpressionConverter.ConvertO(__workflow_bodydata);
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
        public IBodyWorkflowAction<IField> UpdateNumberSingleField(Expression<Func<string>> dbId, Expression<Func<dataLanguageInput>> dataLanguage, Expression<Func<string>> topicId, Expression<Func<string>> fieldsetId, Expression<Func<string>> fieldId, Expression<Func<string>> bodyfieldsetId = null, Expression<Func<string>> bodyfieldId = null, Expression<Func<int>> bodysetOrder = null, Expression<Func<int>> bodyorder = null, Expression<Func<string>> bodytopicId = null, Expression<Func<string>> bodysetName = null, Expression<Func<string>> bodyfieldName = null, Expression<Func<bodyfieldValueTypeInput>> bodyfieldValueType = null, Expression<Func<bool>> bodyrequired = null, Expression<Func<bool>> bodyreadonly = null, Expression<Func<string>> bodyusage = null, Expression<Func<string>> bodyrelationshipCategorydcv = null, Expression<Func<string>> bodyrelationshipCategoryname = null, Expression<Func<string>> bodyrelationshipCategoryicon = null, Expression<Func<string>> bodycharacteristicdcv = null, Expression<Func<string>> bodycharacteristicname = null, Expression<Func<string>> bodycharacteristicicon = null, Expression<Func<string>> bodyopenLocation = null, Expression<Func<int>> bodydata = null)
        {
            var __workflow_dbId = WorkflowExpression.Compile(dbId, nameof(dbId), required: true);
            var __workflow_dataLanguage = WorkflowExpression.Compile(dataLanguage, nameof(dataLanguage), required: true);
            var __workflow_topicId = WorkflowExpression.Compile(topicId, nameof(topicId), required: true);
            var __workflow_fieldsetId = WorkflowExpression.Compile(fieldsetId, nameof(fieldsetId), required: true);
            var __workflow_fieldId = WorkflowExpression.Compile(fieldId, nameof(fieldId), required: true);
            var __workflow_bodyfieldsetId = WorkflowExpression.Compile(bodyfieldsetId, nameof(bodyfieldsetId), required: false);
            var __workflow_bodyfieldId = WorkflowExpression.Compile(bodyfieldId, nameof(bodyfieldId), required: false);
            var __workflow_bodysetOrder = WorkflowExpression.Compile(bodysetOrder, nameof(bodysetOrder), required: false);
            var __workflow_bodyorder = WorkflowExpression.Compile(bodyorder, nameof(bodyorder), required: false);
            var __workflow_bodytopicId = WorkflowExpression.Compile(bodytopicId, nameof(bodytopicId), required: false);
            var __workflow_bodysetName = WorkflowExpression.Compile(bodysetName, nameof(bodysetName), required: false);
            var __workflow_bodyfieldName = WorkflowExpression.Compile(bodyfieldName, nameof(bodyfieldName), required: false);
            var __workflow_bodyfieldValueType = WorkflowExpression.Compile(bodyfieldValueType, nameof(bodyfieldValueType), required: false);
            var __workflow_bodyrequired = WorkflowExpression.Compile(bodyrequired, nameof(bodyrequired), required: false);
            var __workflow_bodyreadonly = WorkflowExpression.Compile(bodyreadonly, nameof(bodyreadonly), required: false);
            var __workflow_bodyusage = WorkflowExpression.Compile(bodyusage, nameof(bodyusage), required: false);
            var __workflow_bodyrelationshipCategorydcv = WorkflowExpression.Compile(bodyrelationshipCategorydcv, nameof(bodyrelationshipCategorydcv), required: false);
            var __workflow_bodyrelationshipCategoryname = WorkflowExpression.Compile(bodyrelationshipCategoryname, nameof(bodyrelationshipCategoryname), required: false);
            var __workflow_bodyrelationshipCategoryicon = WorkflowExpression.Compile(bodyrelationshipCategoryicon, nameof(bodyrelationshipCategoryicon), required: false);
            var __workflow_bodycharacteristicdcv = WorkflowExpression.Compile(bodycharacteristicdcv, nameof(bodycharacteristicdcv), required: false);
            var __workflow_bodycharacteristicname = WorkflowExpression.Compile(bodycharacteristicname, nameof(bodycharacteristicname), required: false);
            var __workflow_bodycharacteristicicon = WorkflowExpression.Compile(bodycharacteristicicon, nameof(bodycharacteristicicon), required: false);
            var __workflow_bodyopenLocation = WorkflowExpression.Compile(bodyopenLocation, nameof(bodyopenLocation), required: false);
            var __workflow_bodydata = WorkflowExpression.Compile(bodydata, nameof(bodydata), required: false);
            return new DeferredBodyAction<IField>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/{0}/{1}/topic/{2}/fieldsets/{3}/number/{4}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_dbId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_dataLanguage, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_topicId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_fieldsetId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_fieldId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyfieldsetId != null)
                {
                    body["fieldsetId"] = ExpressionConverter.ConvertO(__workflow_bodyfieldsetId);
                    bodypropCount++;
                }

                if (__workflow_bodyfieldId != null)
                {
                    body["fieldId"] = ExpressionConverter.ConvertO(__workflow_bodyfieldId);
                    bodypropCount++;
                }

                if (__workflow_bodysetOrder != null)
                {
                    body["setOrder"] = ExpressionConverter.ConvertO(__workflow_bodysetOrder);
                    bodypropCount++;
                }

                if (__workflow_bodyorder != null)
                {
                    body["order"] = ExpressionConverter.ConvertO(__workflow_bodyorder);
                    bodypropCount++;
                }

                if (__workflow_bodytopicId != null)
                {
                    body["topicId"] = ExpressionConverter.ConvertO(__workflow_bodytopicId);
                    bodypropCount++;
                }

                if (__workflow_bodysetName != null)
                {
                    body["setName"] = ExpressionConverter.ConvertO(__workflow_bodysetName);
                    bodypropCount++;
                }

                if (__workflow_bodyfieldName != null)
                {
                    body["fieldName"] = ExpressionConverter.ConvertO(__workflow_bodyfieldName);
                    bodypropCount++;
                }

                if (__workflow_bodyfieldValueType != null)
                {
                    body["fieldValueType"] = ExpressionConverter.ConvertO(__workflow_bodyfieldValueType);
                    bodypropCount++;
                }

                if (__workflow_bodyrequired != null)
                {
                    body["required"] = ExpressionConverter.ConvertO(__workflow_bodyrequired);
                    bodypropCount++;
                }

                if (__workflow_bodyreadonly != null)
                {
                    body["readonly"] = ExpressionConverter.ConvertO(__workflow_bodyreadonly);
                    bodypropCount++;
                }

                if (__workflow_bodyusage != null)
                {
                    body["usage"] = ExpressionConverter.ConvertO(__workflow_bodyusage);
                    bodypropCount++;
                }

                var relationshipCategoryObject = new JObject();
                var relationshipCategoryObjectpropCount = 0;
                if (__workflow_bodyrelationshipCategorydcv != null)
                {
                    relationshipCategoryObject["dcv"] = ExpressionConverter.ConvertO(__workflow_bodyrelationshipCategorydcv);
                    relationshipCategoryObjectpropCount++;
                }

                if (__workflow_bodyrelationshipCategoryname != null)
                {
                    relationshipCategoryObject["name"] = ExpressionConverter.ConvertO(__workflow_bodyrelationshipCategoryname);
                    relationshipCategoryObjectpropCount++;
                }

                if (__workflow_bodyrelationshipCategoryicon != null)
                {
                    relationshipCategoryObject["icon"] = ExpressionConverter.ConvertO(__workflow_bodyrelationshipCategoryicon);
                    relationshipCategoryObjectpropCount++;
                }

                if (relationshipCategoryObjectpropCount > 0)
                {
                    body["relationshipCategory"] = relationshipCategoryObject;
                    bodypropCount++;
                }

                var characteristicObject = new JObject();
                var characteristicObjectpropCount = 0;
                if (__workflow_bodyrelationshipCategorydcv != null)
                {
                    characteristicObject["dcv"] = ExpressionConverter.ConvertO(__workflow_bodyrelationshipCategorydcv);
                    characteristicObjectpropCount++;
                }

                if (__workflow_bodyrelationshipCategoryname != null)
                {
                    characteristicObject["name"] = ExpressionConverter.ConvertO(__workflow_bodyrelationshipCategoryname);
                    characteristicObjectpropCount++;
                }

                if (__workflow_bodyrelationshipCategoryicon != null)
                {
                    characteristicObject["icon"] = ExpressionConverter.ConvertO(__workflow_bodyrelationshipCategoryicon);
                    characteristicObjectpropCount++;
                }

                if (characteristicObjectpropCount > 0)
                {
                    body["characteristic"] = characteristicObject;
                    bodypropCount++;
                }

                if (__workflow_bodyopenLocation != null)
                {
                    body["openLocation"] = ExpressionConverter.ConvertO(__workflow_bodyopenLocation);
                    bodypropCount++;
                }

                if (__workflow_bodydata != null)
                {
                    body["data"] = ExpressionConverter.ConvertO(__workflow_bodydata);
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
        public IBodyWorkflowAction<IField> UpdateNumberMultiField(Expression<Func<string>> dbId, Expression<Func<dataLanguageInput>> dataLanguage, Expression<Func<string>> topicId, Expression<Func<string>> fieldsetId, Expression<Func<string>> fieldId, Expression<Func<string>> bodyfieldsetId = null, Expression<Func<string>> bodyfieldId = null, Expression<Func<int>> bodysetOrder = null, Expression<Func<int>> bodyorder = null, Expression<Func<string>> bodytopicId = null, Expression<Func<string>> bodysetName = null, Expression<Func<string>> bodyfieldName = null, Expression<Func<bodyfieldValueTypeInput>> bodyfieldValueType = null, Expression<Func<bool>> bodyrequired = null, Expression<Func<bool>> bodyreadonly = null, Expression<Func<string>> bodyusage = null, Expression<Func<string>> bodyrelationshipCategorydcv = null, Expression<Func<string>> bodyrelationshipCategoryname = null, Expression<Func<string>> bodyrelationshipCategoryicon = null, Expression<Func<string>> bodycharacteristicdcv = null, Expression<Func<string>> bodycharacteristicname = null, Expression<Func<string>> bodycharacteristicicon = null, Expression<Func<string>> bodyopenLocation = null, Expression<Func<int[]>> bodydata = null)
        {
            var __workflow_dbId = WorkflowExpression.Compile(dbId, nameof(dbId), required: true);
            var __workflow_dataLanguage = WorkflowExpression.Compile(dataLanguage, nameof(dataLanguage), required: true);
            var __workflow_topicId = WorkflowExpression.Compile(topicId, nameof(topicId), required: true);
            var __workflow_fieldsetId = WorkflowExpression.Compile(fieldsetId, nameof(fieldsetId), required: true);
            var __workflow_fieldId = WorkflowExpression.Compile(fieldId, nameof(fieldId), required: true);
            var __workflow_bodyfieldsetId = WorkflowExpression.Compile(bodyfieldsetId, nameof(bodyfieldsetId), required: false);
            var __workflow_bodyfieldId = WorkflowExpression.Compile(bodyfieldId, nameof(bodyfieldId), required: false);
            var __workflow_bodysetOrder = WorkflowExpression.Compile(bodysetOrder, nameof(bodysetOrder), required: false);
            var __workflow_bodyorder = WorkflowExpression.Compile(bodyorder, nameof(bodyorder), required: false);
            var __workflow_bodytopicId = WorkflowExpression.Compile(bodytopicId, nameof(bodytopicId), required: false);
            var __workflow_bodysetName = WorkflowExpression.Compile(bodysetName, nameof(bodysetName), required: false);
            var __workflow_bodyfieldName = WorkflowExpression.Compile(bodyfieldName, nameof(bodyfieldName), required: false);
            var __workflow_bodyfieldValueType = WorkflowExpression.Compile(bodyfieldValueType, nameof(bodyfieldValueType), required: false);
            var __workflow_bodyrequired = WorkflowExpression.Compile(bodyrequired, nameof(bodyrequired), required: false);
            var __workflow_bodyreadonly = WorkflowExpression.Compile(bodyreadonly, nameof(bodyreadonly), required: false);
            var __workflow_bodyusage = WorkflowExpression.Compile(bodyusage, nameof(bodyusage), required: false);
            var __workflow_bodyrelationshipCategorydcv = WorkflowExpression.Compile(bodyrelationshipCategorydcv, nameof(bodyrelationshipCategorydcv), required: false);
            var __workflow_bodyrelationshipCategoryname = WorkflowExpression.Compile(bodyrelationshipCategoryname, nameof(bodyrelationshipCategoryname), required: false);
            var __workflow_bodyrelationshipCategoryicon = WorkflowExpression.Compile(bodyrelationshipCategoryicon, nameof(bodyrelationshipCategoryicon), required: false);
            var __workflow_bodycharacteristicdcv = WorkflowExpression.Compile(bodycharacteristicdcv, nameof(bodycharacteristicdcv), required: false);
            var __workflow_bodycharacteristicname = WorkflowExpression.Compile(bodycharacteristicname, nameof(bodycharacteristicname), required: false);
            var __workflow_bodycharacteristicicon = WorkflowExpression.Compile(bodycharacteristicicon, nameof(bodycharacteristicicon), required: false);
            var __workflow_bodyopenLocation = WorkflowExpression.Compile(bodyopenLocation, nameof(bodyopenLocation), required: false);
            var __workflow_bodydata = WorkflowExpression.Compile(bodydata, nameof(bodydata), required: false);
            return new DeferredBodyAction<IField>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/{0}/{1}/topic/{2}/fieldsets/{3}/multinumber/{4}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_dbId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_dataLanguage, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_topicId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_fieldsetId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_fieldId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyfieldsetId != null)
                {
                    body["fieldsetId"] = ExpressionConverter.ConvertO(__workflow_bodyfieldsetId);
                    bodypropCount++;
                }

                if (__workflow_bodyfieldId != null)
                {
                    body["fieldId"] = ExpressionConverter.ConvertO(__workflow_bodyfieldId);
                    bodypropCount++;
                }

                if (__workflow_bodysetOrder != null)
                {
                    body["setOrder"] = ExpressionConverter.ConvertO(__workflow_bodysetOrder);
                    bodypropCount++;
                }

                if (__workflow_bodyorder != null)
                {
                    body["order"] = ExpressionConverter.ConvertO(__workflow_bodyorder);
                    bodypropCount++;
                }

                if (__workflow_bodytopicId != null)
                {
                    body["topicId"] = ExpressionConverter.ConvertO(__workflow_bodytopicId);
                    bodypropCount++;
                }

                if (__workflow_bodysetName != null)
                {
                    body["setName"] = ExpressionConverter.ConvertO(__workflow_bodysetName);
                    bodypropCount++;
                }

                if (__workflow_bodyfieldName != null)
                {
                    body["fieldName"] = ExpressionConverter.ConvertO(__workflow_bodyfieldName);
                    bodypropCount++;
                }

                if (__workflow_bodyfieldValueType != null)
                {
                    body["fieldValueType"] = ExpressionConverter.ConvertO(__workflow_bodyfieldValueType);
                    bodypropCount++;
                }

                if (__workflow_bodyrequired != null)
                {
                    body["required"] = ExpressionConverter.ConvertO(__workflow_bodyrequired);
                    bodypropCount++;
                }

                if (__workflow_bodyreadonly != null)
                {
                    body["readonly"] = ExpressionConverter.ConvertO(__workflow_bodyreadonly);
                    bodypropCount++;
                }

                if (__workflow_bodyusage != null)
                {
                    body["usage"] = ExpressionConverter.ConvertO(__workflow_bodyusage);
                    bodypropCount++;
                }

                var relationshipCategoryObject = new JObject();
                var relationshipCategoryObjectpropCount = 0;
                if (__workflow_bodyrelationshipCategorydcv != null)
                {
                    relationshipCategoryObject["dcv"] = ExpressionConverter.ConvertO(__workflow_bodyrelationshipCategorydcv);
                    relationshipCategoryObjectpropCount++;
                }

                if (__workflow_bodyrelationshipCategoryname != null)
                {
                    relationshipCategoryObject["name"] = ExpressionConverter.ConvertO(__workflow_bodyrelationshipCategoryname);
                    relationshipCategoryObjectpropCount++;
                }

                if (__workflow_bodyrelationshipCategoryicon != null)
                {
                    relationshipCategoryObject["icon"] = ExpressionConverter.ConvertO(__workflow_bodyrelationshipCategoryicon);
                    relationshipCategoryObjectpropCount++;
                }

                if (relationshipCategoryObjectpropCount > 0)
                {
                    body["relationshipCategory"] = relationshipCategoryObject;
                    bodypropCount++;
                }

                var characteristicObject = new JObject();
                var characteristicObjectpropCount = 0;
                if (__workflow_bodyrelationshipCategorydcv != null)
                {
                    characteristicObject["dcv"] = ExpressionConverter.ConvertO(__workflow_bodyrelationshipCategorydcv);
                    characteristicObjectpropCount++;
                }

                if (__workflow_bodyrelationshipCategoryname != null)
                {
                    characteristicObject["name"] = ExpressionConverter.ConvertO(__workflow_bodyrelationshipCategoryname);
                    characteristicObjectpropCount++;
                }

                if (__workflow_bodyrelationshipCategoryicon != null)
                {
                    characteristicObject["icon"] = ExpressionConverter.ConvertO(__workflow_bodyrelationshipCategoryicon);
                    characteristicObjectpropCount++;
                }

                if (characteristicObjectpropCount > 0)
                {
                    body["characteristic"] = characteristicObject;
                    bodypropCount++;
                }

                if (__workflow_bodyopenLocation != null)
                {
                    body["openLocation"] = ExpressionConverter.ConvertO(__workflow_bodyopenLocation);
                    bodypropCount++;
                }

                if (__workflow_bodydata != null)
                {
                    body["data"] = ExpressionConverter.ConvertO(__workflow_bodydata);
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
        public IBodyWorkflowAction<IField> UpdateDecimalSingleField(Expression<Func<string>> dbId, Expression<Func<dataLanguageInput>> dataLanguage, Expression<Func<string>> topicId, Expression<Func<string>> fieldsetId, Expression<Func<string>> fieldId, Expression<Func<string>> bodyfieldsetId = null, Expression<Func<string>> bodyfieldId = null, Expression<Func<int>> bodysetOrder = null, Expression<Func<int>> bodyorder = null, Expression<Func<string>> bodytopicId = null, Expression<Func<string>> bodysetName = null, Expression<Func<string>> bodyfieldName = null, Expression<Func<bodyfieldValueTypeInput>> bodyfieldValueType = null, Expression<Func<bool>> bodyrequired = null, Expression<Func<bool>> bodyreadonly = null, Expression<Func<string>> bodyusage = null, Expression<Func<string>> bodyrelationshipCategorydcv = null, Expression<Func<string>> bodyrelationshipCategoryname = null, Expression<Func<string>> bodyrelationshipCategoryicon = null, Expression<Func<string>> bodycharacteristicdcv = null, Expression<Func<string>> bodycharacteristicname = null, Expression<Func<string>> bodycharacteristicicon = null, Expression<Func<string>> bodyopenLocation = null, Expression<Func<double>> bodydata = null)
        {
            var __workflow_dbId = WorkflowExpression.Compile(dbId, nameof(dbId), required: true);
            var __workflow_dataLanguage = WorkflowExpression.Compile(dataLanguage, nameof(dataLanguage), required: true);
            var __workflow_topicId = WorkflowExpression.Compile(topicId, nameof(topicId), required: true);
            var __workflow_fieldsetId = WorkflowExpression.Compile(fieldsetId, nameof(fieldsetId), required: true);
            var __workflow_fieldId = WorkflowExpression.Compile(fieldId, nameof(fieldId), required: true);
            var __workflow_bodyfieldsetId = WorkflowExpression.Compile(bodyfieldsetId, nameof(bodyfieldsetId), required: false);
            var __workflow_bodyfieldId = WorkflowExpression.Compile(bodyfieldId, nameof(bodyfieldId), required: false);
            var __workflow_bodysetOrder = WorkflowExpression.Compile(bodysetOrder, nameof(bodysetOrder), required: false);
            var __workflow_bodyorder = WorkflowExpression.Compile(bodyorder, nameof(bodyorder), required: false);
            var __workflow_bodytopicId = WorkflowExpression.Compile(bodytopicId, nameof(bodytopicId), required: false);
            var __workflow_bodysetName = WorkflowExpression.Compile(bodysetName, nameof(bodysetName), required: false);
            var __workflow_bodyfieldName = WorkflowExpression.Compile(bodyfieldName, nameof(bodyfieldName), required: false);
            var __workflow_bodyfieldValueType = WorkflowExpression.Compile(bodyfieldValueType, nameof(bodyfieldValueType), required: false);
            var __workflow_bodyrequired = WorkflowExpression.Compile(bodyrequired, nameof(bodyrequired), required: false);
            var __workflow_bodyreadonly = WorkflowExpression.Compile(bodyreadonly, nameof(bodyreadonly), required: false);
            var __workflow_bodyusage = WorkflowExpression.Compile(bodyusage, nameof(bodyusage), required: false);
            var __workflow_bodyrelationshipCategorydcv = WorkflowExpression.Compile(bodyrelationshipCategorydcv, nameof(bodyrelationshipCategorydcv), required: false);
            var __workflow_bodyrelationshipCategoryname = WorkflowExpression.Compile(bodyrelationshipCategoryname, nameof(bodyrelationshipCategoryname), required: false);
            var __workflow_bodyrelationshipCategoryicon = WorkflowExpression.Compile(bodyrelationshipCategoryicon, nameof(bodyrelationshipCategoryicon), required: false);
            var __workflow_bodycharacteristicdcv = WorkflowExpression.Compile(bodycharacteristicdcv, nameof(bodycharacteristicdcv), required: false);
            var __workflow_bodycharacteristicname = WorkflowExpression.Compile(bodycharacteristicname, nameof(bodycharacteristicname), required: false);
            var __workflow_bodycharacteristicicon = WorkflowExpression.Compile(bodycharacteristicicon, nameof(bodycharacteristicicon), required: false);
            var __workflow_bodyopenLocation = WorkflowExpression.Compile(bodyopenLocation, nameof(bodyopenLocation), required: false);
            var __workflow_bodydata = WorkflowExpression.Compile(bodydata, nameof(bodydata), required: false);
            return new DeferredBodyAction<IField>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/{0}/{1}/topic/{2}/fieldsets/{3}/decimal/{4}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_dbId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_dataLanguage, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_topicId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_fieldsetId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_fieldId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyfieldsetId != null)
                {
                    body["fieldsetId"] = ExpressionConverter.ConvertO(__workflow_bodyfieldsetId);
                    bodypropCount++;
                }

                if (__workflow_bodyfieldId != null)
                {
                    body["fieldId"] = ExpressionConverter.ConvertO(__workflow_bodyfieldId);
                    bodypropCount++;
                }

                if (__workflow_bodysetOrder != null)
                {
                    body["setOrder"] = ExpressionConverter.ConvertO(__workflow_bodysetOrder);
                    bodypropCount++;
                }

                if (__workflow_bodyorder != null)
                {
                    body["order"] = ExpressionConverter.ConvertO(__workflow_bodyorder);
                    bodypropCount++;
                }

                if (__workflow_bodytopicId != null)
                {
                    body["topicId"] = ExpressionConverter.ConvertO(__workflow_bodytopicId);
                    bodypropCount++;
                }

                if (__workflow_bodysetName != null)
                {
                    body["setName"] = ExpressionConverter.ConvertO(__workflow_bodysetName);
                    bodypropCount++;
                }

                if (__workflow_bodyfieldName != null)
                {
                    body["fieldName"] = ExpressionConverter.ConvertO(__workflow_bodyfieldName);
                    bodypropCount++;
                }

                if (__workflow_bodyfieldValueType != null)
                {
                    body["fieldValueType"] = ExpressionConverter.ConvertO(__workflow_bodyfieldValueType);
                    bodypropCount++;
                }

                if (__workflow_bodyrequired != null)
                {
                    body["required"] = ExpressionConverter.ConvertO(__workflow_bodyrequired);
                    bodypropCount++;
                }

                if (__workflow_bodyreadonly != null)
                {
                    body["readonly"] = ExpressionConverter.ConvertO(__workflow_bodyreadonly);
                    bodypropCount++;
                }

                if (__workflow_bodyusage != null)
                {
                    body["usage"] = ExpressionConverter.ConvertO(__workflow_bodyusage);
                    bodypropCount++;
                }

                var relationshipCategoryObject = new JObject();
                var relationshipCategoryObjectpropCount = 0;
                if (__workflow_bodyrelationshipCategorydcv != null)
                {
                    relationshipCategoryObject["dcv"] = ExpressionConverter.ConvertO(__workflow_bodyrelationshipCategorydcv);
                    relationshipCategoryObjectpropCount++;
                }

                if (__workflow_bodyrelationshipCategoryname != null)
                {
                    relationshipCategoryObject["name"] = ExpressionConverter.ConvertO(__workflow_bodyrelationshipCategoryname);
                    relationshipCategoryObjectpropCount++;
                }

                if (__workflow_bodyrelationshipCategoryicon != null)
                {
                    relationshipCategoryObject["icon"] = ExpressionConverter.ConvertO(__workflow_bodyrelationshipCategoryicon);
                    relationshipCategoryObjectpropCount++;
                }

                if (relationshipCategoryObjectpropCount > 0)
                {
                    body["relationshipCategory"] = relationshipCategoryObject;
                    bodypropCount++;
                }

                var characteristicObject = new JObject();
                var characteristicObjectpropCount = 0;
                if (__workflow_bodyrelationshipCategorydcv != null)
                {
                    characteristicObject["dcv"] = ExpressionConverter.ConvertO(__workflow_bodyrelationshipCategorydcv);
                    characteristicObjectpropCount++;
                }

                if (__workflow_bodyrelationshipCategoryname != null)
                {
                    characteristicObject["name"] = ExpressionConverter.ConvertO(__workflow_bodyrelationshipCategoryname);
                    characteristicObjectpropCount++;
                }

                if (__workflow_bodyrelationshipCategoryicon != null)
                {
                    characteristicObject["icon"] = ExpressionConverter.ConvertO(__workflow_bodyrelationshipCategoryicon);
                    characteristicObjectpropCount++;
                }

                if (characteristicObjectpropCount > 0)
                {
                    body["characteristic"] = characteristicObject;
                    bodypropCount++;
                }

                if (__workflow_bodyopenLocation != null)
                {
                    body["openLocation"] = ExpressionConverter.ConvertO(__workflow_bodyopenLocation);
                    bodypropCount++;
                }

                if (__workflow_bodydata != null)
                {
                    body["data"] = ExpressionConverter.ConvertO(__workflow_bodydata);
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
        public IBodyWorkflowAction<IField> UpdateDecimalMultiField(Expression<Func<string>> dbId, Expression<Func<dataLanguageInput>> dataLanguage, Expression<Func<string>> topicId, Expression<Func<string>> fieldsetId, Expression<Func<string>> fieldId, Expression<Func<string>> bodyfieldsetId = null, Expression<Func<string>> bodyfieldId = null, Expression<Func<int>> bodysetOrder = null, Expression<Func<int>> bodyorder = null, Expression<Func<string>> bodytopicId = null, Expression<Func<string>> bodysetName = null, Expression<Func<string>> bodyfieldName = null, Expression<Func<bodyfieldValueTypeInput>> bodyfieldValueType = null, Expression<Func<bool>> bodyrequired = null, Expression<Func<bool>> bodyreadonly = null, Expression<Func<string>> bodyusage = null, Expression<Func<string>> bodyrelationshipCategorydcv = null, Expression<Func<string>> bodyrelationshipCategoryname = null, Expression<Func<string>> bodyrelationshipCategoryicon = null, Expression<Func<string>> bodycharacteristicdcv = null, Expression<Func<string>> bodycharacteristicname = null, Expression<Func<string>> bodycharacteristicicon = null, Expression<Func<string>> bodyopenLocation = null, Expression<Func<double[]>> bodydata = null)
        {
            var __workflow_dbId = WorkflowExpression.Compile(dbId, nameof(dbId), required: true);
            var __workflow_dataLanguage = WorkflowExpression.Compile(dataLanguage, nameof(dataLanguage), required: true);
            var __workflow_topicId = WorkflowExpression.Compile(topicId, nameof(topicId), required: true);
            var __workflow_fieldsetId = WorkflowExpression.Compile(fieldsetId, nameof(fieldsetId), required: true);
            var __workflow_fieldId = WorkflowExpression.Compile(fieldId, nameof(fieldId), required: true);
            var __workflow_bodyfieldsetId = WorkflowExpression.Compile(bodyfieldsetId, nameof(bodyfieldsetId), required: false);
            var __workflow_bodyfieldId = WorkflowExpression.Compile(bodyfieldId, nameof(bodyfieldId), required: false);
            var __workflow_bodysetOrder = WorkflowExpression.Compile(bodysetOrder, nameof(bodysetOrder), required: false);
            var __workflow_bodyorder = WorkflowExpression.Compile(bodyorder, nameof(bodyorder), required: false);
            var __workflow_bodytopicId = WorkflowExpression.Compile(bodytopicId, nameof(bodytopicId), required: false);
            var __workflow_bodysetName = WorkflowExpression.Compile(bodysetName, nameof(bodysetName), required: false);
            var __workflow_bodyfieldName = WorkflowExpression.Compile(bodyfieldName, nameof(bodyfieldName), required: false);
            var __workflow_bodyfieldValueType = WorkflowExpression.Compile(bodyfieldValueType, nameof(bodyfieldValueType), required: false);
            var __workflow_bodyrequired = WorkflowExpression.Compile(bodyrequired, nameof(bodyrequired), required: false);
            var __workflow_bodyreadonly = WorkflowExpression.Compile(bodyreadonly, nameof(bodyreadonly), required: false);
            var __workflow_bodyusage = WorkflowExpression.Compile(bodyusage, nameof(bodyusage), required: false);
            var __workflow_bodyrelationshipCategorydcv = WorkflowExpression.Compile(bodyrelationshipCategorydcv, nameof(bodyrelationshipCategorydcv), required: false);
            var __workflow_bodyrelationshipCategoryname = WorkflowExpression.Compile(bodyrelationshipCategoryname, nameof(bodyrelationshipCategoryname), required: false);
            var __workflow_bodyrelationshipCategoryicon = WorkflowExpression.Compile(bodyrelationshipCategoryicon, nameof(bodyrelationshipCategoryicon), required: false);
            var __workflow_bodycharacteristicdcv = WorkflowExpression.Compile(bodycharacteristicdcv, nameof(bodycharacteristicdcv), required: false);
            var __workflow_bodycharacteristicname = WorkflowExpression.Compile(bodycharacteristicname, nameof(bodycharacteristicname), required: false);
            var __workflow_bodycharacteristicicon = WorkflowExpression.Compile(bodycharacteristicicon, nameof(bodycharacteristicicon), required: false);
            var __workflow_bodyopenLocation = WorkflowExpression.Compile(bodyopenLocation, nameof(bodyopenLocation), required: false);
            var __workflow_bodydata = WorkflowExpression.Compile(bodydata, nameof(bodydata), required: false);
            return new DeferredBodyAction<IField>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/{0}/{1}/topic/{2}/fieldsets/{3}/multidecimal/{4}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_dbId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_dataLanguage, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_topicId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_fieldsetId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_fieldId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyfieldsetId != null)
                {
                    body["fieldsetId"] = ExpressionConverter.ConvertO(__workflow_bodyfieldsetId);
                    bodypropCount++;
                }

                if (__workflow_bodyfieldId != null)
                {
                    body["fieldId"] = ExpressionConverter.ConvertO(__workflow_bodyfieldId);
                    bodypropCount++;
                }

                if (__workflow_bodysetOrder != null)
                {
                    body["setOrder"] = ExpressionConverter.ConvertO(__workflow_bodysetOrder);
                    bodypropCount++;
                }

                if (__workflow_bodyorder != null)
                {
                    body["order"] = ExpressionConverter.ConvertO(__workflow_bodyorder);
                    bodypropCount++;
                }

                if (__workflow_bodytopicId != null)
                {
                    body["topicId"] = ExpressionConverter.ConvertO(__workflow_bodytopicId);
                    bodypropCount++;
                }

                if (__workflow_bodysetName != null)
                {
                    body["setName"] = ExpressionConverter.ConvertO(__workflow_bodysetName);
                    bodypropCount++;
                }

                if (__workflow_bodyfieldName != null)
                {
                    body["fieldName"] = ExpressionConverter.ConvertO(__workflow_bodyfieldName);
                    bodypropCount++;
                }

                if (__workflow_bodyfieldValueType != null)
                {
                    body["fieldValueType"] = ExpressionConverter.ConvertO(__workflow_bodyfieldValueType);
                    bodypropCount++;
                }

                if (__workflow_bodyrequired != null)
                {
                    body["required"] = ExpressionConverter.ConvertO(__workflow_bodyrequired);
                    bodypropCount++;
                }

                if (__workflow_bodyreadonly != null)
                {
                    body["readonly"] = ExpressionConverter.ConvertO(__workflow_bodyreadonly);
                    bodypropCount++;
                }

                if (__workflow_bodyusage != null)
                {
                    body["usage"] = ExpressionConverter.ConvertO(__workflow_bodyusage);
                    bodypropCount++;
                }

                var relationshipCategoryObject = new JObject();
                var relationshipCategoryObjectpropCount = 0;
                if (__workflow_bodyrelationshipCategorydcv != null)
                {
                    relationshipCategoryObject["dcv"] = ExpressionConverter.ConvertO(__workflow_bodyrelationshipCategorydcv);
                    relationshipCategoryObjectpropCount++;
                }

                if (__workflow_bodyrelationshipCategoryname != null)
                {
                    relationshipCategoryObject["name"] = ExpressionConverter.ConvertO(__workflow_bodyrelationshipCategoryname);
                    relationshipCategoryObjectpropCount++;
                }

                if (__workflow_bodyrelationshipCategoryicon != null)
                {
                    relationshipCategoryObject["icon"] = ExpressionConverter.ConvertO(__workflow_bodyrelationshipCategoryicon);
                    relationshipCategoryObjectpropCount++;
                }

                if (relationshipCategoryObjectpropCount > 0)
                {
                    body["relationshipCategory"] = relationshipCategoryObject;
                    bodypropCount++;
                }

                var characteristicObject = new JObject();
                var characteristicObjectpropCount = 0;
                if (__workflow_bodyrelationshipCategorydcv != null)
                {
                    characteristicObject["dcv"] = ExpressionConverter.ConvertO(__workflow_bodyrelationshipCategorydcv);
                    characteristicObjectpropCount++;
                }

                if (__workflow_bodyrelationshipCategoryname != null)
                {
                    characteristicObject["name"] = ExpressionConverter.ConvertO(__workflow_bodyrelationshipCategoryname);
                    characteristicObjectpropCount++;
                }

                if (__workflow_bodyrelationshipCategoryicon != null)
                {
                    characteristicObject["icon"] = ExpressionConverter.ConvertO(__workflow_bodyrelationshipCategoryicon);
                    characteristicObjectpropCount++;
                }

                if (characteristicObjectpropCount > 0)
                {
                    body["characteristic"] = characteristicObject;
                    bodypropCount++;
                }

                if (__workflow_bodyopenLocation != null)
                {
                    body["openLocation"] = ExpressionConverter.ConvertO(__workflow_bodyopenLocation);
                    bodypropCount++;
                }

                if (__workflow_bodydata != null)
                {
                    body["data"] = ExpressionConverter.ConvertO(__workflow_bodydata);
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
        public IBodyWorkflowAction<IField> UpdateDateSingleField(Expression<Func<string>> dbId, Expression<Func<dataLanguageInput>> dataLanguage, Expression<Func<string>> topicId, Expression<Func<string>> fieldsetId, Expression<Func<string>> fieldId, Expression<Func<string>> bodyfieldsetId = null, Expression<Func<string>> bodyfieldId = null, Expression<Func<int>> bodysetOrder = null, Expression<Func<int>> bodyorder = null, Expression<Func<string>> bodytopicId = null, Expression<Func<string>> bodysetName = null, Expression<Func<string>> bodyfieldName = null, Expression<Func<bodyfieldValueTypeInput>> bodyfieldValueType = null, Expression<Func<bool>> bodyrequired = null, Expression<Func<bool>> bodyreadonly = null, Expression<Func<string>> bodyusage = null, Expression<Func<string>> bodyrelationshipCategorydcv = null, Expression<Func<string>> bodyrelationshipCategoryname = null, Expression<Func<string>> bodyrelationshipCategoryicon = null, Expression<Func<string>> bodycharacteristicdcv = null, Expression<Func<string>> bodycharacteristicname = null, Expression<Func<string>> bodycharacteristicicon = null, Expression<Func<string>> bodyopenLocation = null, Expression<Func<string>> bodydata = null)
        {
            var __workflow_dbId = WorkflowExpression.Compile(dbId, nameof(dbId), required: true);
            var __workflow_dataLanguage = WorkflowExpression.Compile(dataLanguage, nameof(dataLanguage), required: true);
            var __workflow_topicId = WorkflowExpression.Compile(topicId, nameof(topicId), required: true);
            var __workflow_fieldsetId = WorkflowExpression.Compile(fieldsetId, nameof(fieldsetId), required: true);
            var __workflow_fieldId = WorkflowExpression.Compile(fieldId, nameof(fieldId), required: true);
            var __workflow_bodyfieldsetId = WorkflowExpression.Compile(bodyfieldsetId, nameof(bodyfieldsetId), required: false);
            var __workflow_bodyfieldId = WorkflowExpression.Compile(bodyfieldId, nameof(bodyfieldId), required: false);
            var __workflow_bodysetOrder = WorkflowExpression.Compile(bodysetOrder, nameof(bodysetOrder), required: false);
            var __workflow_bodyorder = WorkflowExpression.Compile(bodyorder, nameof(bodyorder), required: false);
            var __workflow_bodytopicId = WorkflowExpression.Compile(bodytopicId, nameof(bodytopicId), required: false);
            var __workflow_bodysetName = WorkflowExpression.Compile(bodysetName, nameof(bodysetName), required: false);
            var __workflow_bodyfieldName = WorkflowExpression.Compile(bodyfieldName, nameof(bodyfieldName), required: false);
            var __workflow_bodyfieldValueType = WorkflowExpression.Compile(bodyfieldValueType, nameof(bodyfieldValueType), required: false);
            var __workflow_bodyrequired = WorkflowExpression.Compile(bodyrequired, nameof(bodyrequired), required: false);
            var __workflow_bodyreadonly = WorkflowExpression.Compile(bodyreadonly, nameof(bodyreadonly), required: false);
            var __workflow_bodyusage = WorkflowExpression.Compile(bodyusage, nameof(bodyusage), required: false);
            var __workflow_bodyrelationshipCategorydcv = WorkflowExpression.Compile(bodyrelationshipCategorydcv, nameof(bodyrelationshipCategorydcv), required: false);
            var __workflow_bodyrelationshipCategoryname = WorkflowExpression.Compile(bodyrelationshipCategoryname, nameof(bodyrelationshipCategoryname), required: false);
            var __workflow_bodyrelationshipCategoryicon = WorkflowExpression.Compile(bodyrelationshipCategoryicon, nameof(bodyrelationshipCategoryicon), required: false);
            var __workflow_bodycharacteristicdcv = WorkflowExpression.Compile(bodycharacteristicdcv, nameof(bodycharacteristicdcv), required: false);
            var __workflow_bodycharacteristicname = WorkflowExpression.Compile(bodycharacteristicname, nameof(bodycharacteristicname), required: false);
            var __workflow_bodycharacteristicicon = WorkflowExpression.Compile(bodycharacteristicicon, nameof(bodycharacteristicicon), required: false);
            var __workflow_bodyopenLocation = WorkflowExpression.Compile(bodyopenLocation, nameof(bodyopenLocation), required: false);
            var __workflow_bodydata = WorkflowExpression.Compile(bodydata, nameof(bodydata), required: false);
            return new DeferredBodyAction<IField>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/{0}/{1}/topic/{2}/fieldsets/{3}/date/{4}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_dbId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_dataLanguage, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_topicId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_fieldsetId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_fieldId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyfieldsetId != null)
                {
                    body["fieldsetId"] = ExpressionConverter.ConvertO(__workflow_bodyfieldsetId);
                    bodypropCount++;
                }

                if (__workflow_bodyfieldId != null)
                {
                    body["fieldId"] = ExpressionConverter.ConvertO(__workflow_bodyfieldId);
                    bodypropCount++;
                }

                if (__workflow_bodysetOrder != null)
                {
                    body["setOrder"] = ExpressionConverter.ConvertO(__workflow_bodysetOrder);
                    bodypropCount++;
                }

                if (__workflow_bodyorder != null)
                {
                    body["order"] = ExpressionConverter.ConvertO(__workflow_bodyorder);
                    bodypropCount++;
                }

                if (__workflow_bodytopicId != null)
                {
                    body["topicId"] = ExpressionConverter.ConvertO(__workflow_bodytopicId);
                    bodypropCount++;
                }

                if (__workflow_bodysetName != null)
                {
                    body["setName"] = ExpressionConverter.ConvertO(__workflow_bodysetName);
                    bodypropCount++;
                }

                if (__workflow_bodyfieldName != null)
                {
                    body["fieldName"] = ExpressionConverter.ConvertO(__workflow_bodyfieldName);
                    bodypropCount++;
                }

                if (__workflow_bodyfieldValueType != null)
                {
                    body["fieldValueType"] = ExpressionConverter.ConvertO(__workflow_bodyfieldValueType);
                    bodypropCount++;
                }

                if (__workflow_bodyrequired != null)
                {
                    body["required"] = ExpressionConverter.ConvertO(__workflow_bodyrequired);
                    bodypropCount++;
                }

                if (__workflow_bodyreadonly != null)
                {
                    body["readonly"] = ExpressionConverter.ConvertO(__workflow_bodyreadonly);
                    bodypropCount++;
                }

                if (__workflow_bodyusage != null)
                {
                    body["usage"] = ExpressionConverter.ConvertO(__workflow_bodyusage);
                    bodypropCount++;
                }

                var relationshipCategoryObject = new JObject();
                var relationshipCategoryObjectpropCount = 0;
                if (__workflow_bodyrelationshipCategorydcv != null)
                {
                    relationshipCategoryObject["dcv"] = ExpressionConverter.ConvertO(__workflow_bodyrelationshipCategorydcv);
                    relationshipCategoryObjectpropCount++;
                }

                if (__workflow_bodyrelationshipCategoryname != null)
                {
                    relationshipCategoryObject["name"] = ExpressionConverter.ConvertO(__workflow_bodyrelationshipCategoryname);
                    relationshipCategoryObjectpropCount++;
                }

                if (__workflow_bodyrelationshipCategoryicon != null)
                {
                    relationshipCategoryObject["icon"] = ExpressionConverter.ConvertO(__workflow_bodyrelationshipCategoryicon);
                    relationshipCategoryObjectpropCount++;
                }

                if (relationshipCategoryObjectpropCount > 0)
                {
                    body["relationshipCategory"] = relationshipCategoryObject;
                    bodypropCount++;
                }

                var characteristicObject = new JObject();
                var characteristicObjectpropCount = 0;
                if (__workflow_bodyrelationshipCategorydcv != null)
                {
                    characteristicObject["dcv"] = ExpressionConverter.ConvertO(__workflow_bodyrelationshipCategorydcv);
                    characteristicObjectpropCount++;
                }

                if (__workflow_bodyrelationshipCategoryname != null)
                {
                    characteristicObject["name"] = ExpressionConverter.ConvertO(__workflow_bodyrelationshipCategoryname);
                    characteristicObjectpropCount++;
                }

                if (__workflow_bodyrelationshipCategoryicon != null)
                {
                    characteristicObject["icon"] = ExpressionConverter.ConvertO(__workflow_bodyrelationshipCategoryicon);
                    characteristicObjectpropCount++;
                }

                if (characteristicObjectpropCount > 0)
                {
                    body["characteristic"] = characteristicObject;
                    bodypropCount++;
                }

                if (__workflow_bodyopenLocation != null)
                {
                    body["openLocation"] = ExpressionConverter.ConvertO(__workflow_bodyopenLocation);
                    bodypropCount++;
                }

                if (__workflow_bodydata != null)
                {
                    body["data"] = ExpressionConverter.ConvertO(__workflow_bodydata);
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
        public IBodyWorkflowAction<IField> UpdateDateMultiField(Expression<Func<string>> dbId, Expression<Func<dataLanguageInput>> dataLanguage, Expression<Func<string>> topicId, Expression<Func<string>> fieldsetId, Expression<Func<string>> fieldId, Expression<Func<string>> bodyfieldsetId = null, Expression<Func<string>> bodyfieldId = null, Expression<Func<int>> bodysetOrder = null, Expression<Func<int>> bodyorder = null, Expression<Func<string>> bodytopicId = null, Expression<Func<string>> bodysetName = null, Expression<Func<string>> bodyfieldName = null, Expression<Func<bodyfieldValueTypeInput>> bodyfieldValueType = null, Expression<Func<bool>> bodyrequired = null, Expression<Func<bool>> bodyreadonly = null, Expression<Func<string>> bodyusage = null, Expression<Func<string>> bodyrelationshipCategorydcv = null, Expression<Func<string>> bodyrelationshipCategoryname = null, Expression<Func<string>> bodyrelationshipCategoryicon = null, Expression<Func<string>> bodycharacteristicdcv = null, Expression<Func<string>> bodycharacteristicname = null, Expression<Func<string>> bodycharacteristicicon = null, Expression<Func<string>> bodyopenLocation = null, Expression<Func<string[]>> bodydata = null)
        {
            var __workflow_dbId = WorkflowExpression.Compile(dbId, nameof(dbId), required: true);
            var __workflow_dataLanguage = WorkflowExpression.Compile(dataLanguage, nameof(dataLanguage), required: true);
            var __workflow_topicId = WorkflowExpression.Compile(topicId, nameof(topicId), required: true);
            var __workflow_fieldsetId = WorkflowExpression.Compile(fieldsetId, nameof(fieldsetId), required: true);
            var __workflow_fieldId = WorkflowExpression.Compile(fieldId, nameof(fieldId), required: true);
            var __workflow_bodyfieldsetId = WorkflowExpression.Compile(bodyfieldsetId, nameof(bodyfieldsetId), required: false);
            var __workflow_bodyfieldId = WorkflowExpression.Compile(bodyfieldId, nameof(bodyfieldId), required: false);
            var __workflow_bodysetOrder = WorkflowExpression.Compile(bodysetOrder, nameof(bodysetOrder), required: false);
            var __workflow_bodyorder = WorkflowExpression.Compile(bodyorder, nameof(bodyorder), required: false);
            var __workflow_bodytopicId = WorkflowExpression.Compile(bodytopicId, nameof(bodytopicId), required: false);
            var __workflow_bodysetName = WorkflowExpression.Compile(bodysetName, nameof(bodysetName), required: false);
            var __workflow_bodyfieldName = WorkflowExpression.Compile(bodyfieldName, nameof(bodyfieldName), required: false);
            var __workflow_bodyfieldValueType = WorkflowExpression.Compile(bodyfieldValueType, nameof(bodyfieldValueType), required: false);
            var __workflow_bodyrequired = WorkflowExpression.Compile(bodyrequired, nameof(bodyrequired), required: false);
            var __workflow_bodyreadonly = WorkflowExpression.Compile(bodyreadonly, nameof(bodyreadonly), required: false);
            var __workflow_bodyusage = WorkflowExpression.Compile(bodyusage, nameof(bodyusage), required: false);
            var __workflow_bodyrelationshipCategorydcv = WorkflowExpression.Compile(bodyrelationshipCategorydcv, nameof(bodyrelationshipCategorydcv), required: false);
            var __workflow_bodyrelationshipCategoryname = WorkflowExpression.Compile(bodyrelationshipCategoryname, nameof(bodyrelationshipCategoryname), required: false);
            var __workflow_bodyrelationshipCategoryicon = WorkflowExpression.Compile(bodyrelationshipCategoryicon, nameof(bodyrelationshipCategoryicon), required: false);
            var __workflow_bodycharacteristicdcv = WorkflowExpression.Compile(bodycharacteristicdcv, nameof(bodycharacteristicdcv), required: false);
            var __workflow_bodycharacteristicname = WorkflowExpression.Compile(bodycharacteristicname, nameof(bodycharacteristicname), required: false);
            var __workflow_bodycharacteristicicon = WorkflowExpression.Compile(bodycharacteristicicon, nameof(bodycharacteristicicon), required: false);
            var __workflow_bodyopenLocation = WorkflowExpression.Compile(bodyopenLocation, nameof(bodyopenLocation), required: false);
            var __workflow_bodydata = WorkflowExpression.Compile(bodydata, nameof(bodydata), required: false);
            return new DeferredBodyAction<IField>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/{0}/{1}/topic/{2}/fieldsets/{3}/multidate/{4}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_dbId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_dataLanguage, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_topicId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_fieldsetId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_fieldId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyfieldsetId != null)
                {
                    body["fieldsetId"] = ExpressionConverter.ConvertO(__workflow_bodyfieldsetId);
                    bodypropCount++;
                }

                if (__workflow_bodyfieldId != null)
                {
                    body["fieldId"] = ExpressionConverter.ConvertO(__workflow_bodyfieldId);
                    bodypropCount++;
                }

                if (__workflow_bodysetOrder != null)
                {
                    body["setOrder"] = ExpressionConverter.ConvertO(__workflow_bodysetOrder);
                    bodypropCount++;
                }

                if (__workflow_bodyorder != null)
                {
                    body["order"] = ExpressionConverter.ConvertO(__workflow_bodyorder);
                    bodypropCount++;
                }

                if (__workflow_bodytopicId != null)
                {
                    body["topicId"] = ExpressionConverter.ConvertO(__workflow_bodytopicId);
                    bodypropCount++;
                }

                if (__workflow_bodysetName != null)
                {
                    body["setName"] = ExpressionConverter.ConvertO(__workflow_bodysetName);
                    bodypropCount++;
                }

                if (__workflow_bodyfieldName != null)
                {
                    body["fieldName"] = ExpressionConverter.ConvertO(__workflow_bodyfieldName);
                    bodypropCount++;
                }

                if (__workflow_bodyfieldValueType != null)
                {
                    body["fieldValueType"] = ExpressionConverter.ConvertO(__workflow_bodyfieldValueType);
                    bodypropCount++;
                }

                if (__workflow_bodyrequired != null)
                {
                    body["required"] = ExpressionConverter.ConvertO(__workflow_bodyrequired);
                    bodypropCount++;
                }

                if (__workflow_bodyreadonly != null)
                {
                    body["readonly"] = ExpressionConverter.ConvertO(__workflow_bodyreadonly);
                    bodypropCount++;
                }

                if (__workflow_bodyusage != null)
                {
                    body["usage"] = ExpressionConverter.ConvertO(__workflow_bodyusage);
                    bodypropCount++;
                }

                var relationshipCategoryObject = new JObject();
                var relationshipCategoryObjectpropCount = 0;
                if (__workflow_bodyrelationshipCategorydcv != null)
                {
                    relationshipCategoryObject["dcv"] = ExpressionConverter.ConvertO(__workflow_bodyrelationshipCategorydcv);
                    relationshipCategoryObjectpropCount++;
                }

                if (__workflow_bodyrelationshipCategoryname != null)
                {
                    relationshipCategoryObject["name"] = ExpressionConverter.ConvertO(__workflow_bodyrelationshipCategoryname);
                    relationshipCategoryObjectpropCount++;
                }

                if (__workflow_bodyrelationshipCategoryicon != null)
                {
                    relationshipCategoryObject["icon"] = ExpressionConverter.ConvertO(__workflow_bodyrelationshipCategoryicon);
                    relationshipCategoryObjectpropCount++;
                }

                if (relationshipCategoryObjectpropCount > 0)
                {
                    body["relationshipCategory"] = relationshipCategoryObject;
                    bodypropCount++;
                }

                var characteristicObject = new JObject();
                var characteristicObjectpropCount = 0;
                if (__workflow_bodyrelationshipCategorydcv != null)
                {
                    characteristicObject["dcv"] = ExpressionConverter.ConvertO(__workflow_bodyrelationshipCategorydcv);
                    characteristicObjectpropCount++;
                }

                if (__workflow_bodyrelationshipCategoryname != null)
                {
                    characteristicObject["name"] = ExpressionConverter.ConvertO(__workflow_bodyrelationshipCategoryname);
                    characteristicObjectpropCount++;
                }

                if (__workflow_bodyrelationshipCategoryicon != null)
                {
                    characteristicObject["icon"] = ExpressionConverter.ConvertO(__workflow_bodyrelationshipCategoryicon);
                    characteristicObjectpropCount++;
                }

                if (characteristicObjectpropCount > 0)
                {
                    body["characteristic"] = characteristicObject;
                    bodypropCount++;
                }

                if (__workflow_bodyopenLocation != null)
                {
                    body["openLocation"] = ExpressionConverter.ConvertO(__workflow_bodyopenLocation);
                    bodypropCount++;
                }

                if (__workflow_bodydata != null)
                {
                    body["data"] = ExpressionConverter.ConvertO(__workflow_bodydata);
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
        public IBodyWorkflowAction<IField> UpdateListSingleField(Expression<Func<string>> dbId, Expression<Func<dataLanguageInput>> dataLanguage, Expression<Func<string>> topicId, Expression<Func<string>> fieldsetId, Expression<Func<string>> fieldId, Expression<Func<string>> bodyfieldsetId = null, Expression<Func<string>> bodyfieldId = null, Expression<Func<int>> bodysetOrder = null, Expression<Func<int>> bodyorder = null, Expression<Func<string>> bodytopicId = null, Expression<Func<string>> bodysetName = null, Expression<Func<string>> bodyfieldName = null, Expression<Func<bodyfieldValueTypeInput>> bodyfieldValueType = null, Expression<Func<bool>> bodyrequired = null, Expression<Func<bool>> bodyreadonly = null, Expression<Func<string>> bodyusage = null, Expression<Func<string>> bodyrelationshipCategorydcv = null, Expression<Func<string>> bodyrelationshipCategoryname = null, Expression<Func<string>> bodyrelationshipCategoryicon = null, Expression<Func<string>> bodycharacteristicdcv = null, Expression<Func<string>> bodycharacteristicname = null, Expression<Func<string>> bodycharacteristicicon = null, Expression<Func<string>> bodyopenLocation = null)
        {
            var __workflow_dbId = WorkflowExpression.Compile(dbId, nameof(dbId), required: true);
            var __workflow_dataLanguage = WorkflowExpression.Compile(dataLanguage, nameof(dataLanguage), required: true);
            var __workflow_topicId = WorkflowExpression.Compile(topicId, nameof(topicId), required: true);
            var __workflow_fieldsetId = WorkflowExpression.Compile(fieldsetId, nameof(fieldsetId), required: true);
            var __workflow_fieldId = WorkflowExpression.Compile(fieldId, nameof(fieldId), required: true);
            var __workflow_bodyfieldsetId = WorkflowExpression.Compile(bodyfieldsetId, nameof(bodyfieldsetId), required: false);
            var __workflow_bodyfieldId = WorkflowExpression.Compile(bodyfieldId, nameof(bodyfieldId), required: false);
            var __workflow_bodysetOrder = WorkflowExpression.Compile(bodysetOrder, nameof(bodysetOrder), required: false);
            var __workflow_bodyorder = WorkflowExpression.Compile(bodyorder, nameof(bodyorder), required: false);
            var __workflow_bodytopicId = WorkflowExpression.Compile(bodytopicId, nameof(bodytopicId), required: false);
            var __workflow_bodysetName = WorkflowExpression.Compile(bodysetName, nameof(bodysetName), required: false);
            var __workflow_bodyfieldName = WorkflowExpression.Compile(bodyfieldName, nameof(bodyfieldName), required: false);
            var __workflow_bodyfieldValueType = WorkflowExpression.Compile(bodyfieldValueType, nameof(bodyfieldValueType), required: false);
            var __workflow_bodyrequired = WorkflowExpression.Compile(bodyrequired, nameof(bodyrequired), required: false);
            var __workflow_bodyreadonly = WorkflowExpression.Compile(bodyreadonly, nameof(bodyreadonly), required: false);
            var __workflow_bodyusage = WorkflowExpression.Compile(bodyusage, nameof(bodyusage), required: false);
            var __workflow_bodyrelationshipCategorydcv = WorkflowExpression.Compile(bodyrelationshipCategorydcv, nameof(bodyrelationshipCategorydcv), required: false);
            var __workflow_bodyrelationshipCategoryname = WorkflowExpression.Compile(bodyrelationshipCategoryname, nameof(bodyrelationshipCategoryname), required: false);
            var __workflow_bodyrelationshipCategoryicon = WorkflowExpression.Compile(bodyrelationshipCategoryicon, nameof(bodyrelationshipCategoryicon), required: false);
            var __workflow_bodycharacteristicdcv = WorkflowExpression.Compile(bodycharacteristicdcv, nameof(bodycharacteristicdcv), required: false);
            var __workflow_bodycharacteristicname = WorkflowExpression.Compile(bodycharacteristicname, nameof(bodycharacteristicname), required: false);
            var __workflow_bodycharacteristicicon = WorkflowExpression.Compile(bodycharacteristicicon, nameof(bodycharacteristicicon), required: false);
            var __workflow_bodyopenLocation = WorkflowExpression.Compile(bodyopenLocation, nameof(bodyopenLocation), required: false);
            return new DeferredBodyAction<IField>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/{0}/{1}/topic/{2}/fieldsets/{3}/list/{4}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_dbId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_dataLanguage, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_topicId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_fieldsetId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_fieldId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyfieldsetId != null)
                {
                    body["fieldsetId"] = ExpressionConverter.ConvertO(__workflow_bodyfieldsetId);
                    bodypropCount++;
                }

                if (__workflow_bodyfieldId != null)
                {
                    body["fieldId"] = ExpressionConverter.ConvertO(__workflow_bodyfieldId);
                    bodypropCount++;
                }

                if (__workflow_bodysetOrder != null)
                {
                    body["setOrder"] = ExpressionConverter.ConvertO(__workflow_bodysetOrder);
                    bodypropCount++;
                }

                if (__workflow_bodyorder != null)
                {
                    body["order"] = ExpressionConverter.ConvertO(__workflow_bodyorder);
                    bodypropCount++;
                }

                if (__workflow_bodytopicId != null)
                {
                    body["topicId"] = ExpressionConverter.ConvertO(__workflow_bodytopicId);
                    bodypropCount++;
                }

                if (__workflow_bodysetName != null)
                {
                    body["setName"] = ExpressionConverter.ConvertO(__workflow_bodysetName);
                    bodypropCount++;
                }

                if (__workflow_bodyfieldName != null)
                {
                    body["fieldName"] = ExpressionConverter.ConvertO(__workflow_bodyfieldName);
                    bodypropCount++;
                }

                if (__workflow_bodyfieldValueType != null)
                {
                    body["fieldValueType"] = ExpressionConverter.ConvertO(__workflow_bodyfieldValueType);
                    bodypropCount++;
                }

                if (__workflow_bodyrequired != null)
                {
                    body["required"] = ExpressionConverter.ConvertO(__workflow_bodyrequired);
                    bodypropCount++;
                }

                if (__workflow_bodyreadonly != null)
                {
                    body["readonly"] = ExpressionConverter.ConvertO(__workflow_bodyreadonly);
                    bodypropCount++;
                }

                if (__workflow_bodyusage != null)
                {
                    body["usage"] = ExpressionConverter.ConvertO(__workflow_bodyusage);
                    bodypropCount++;
                }

                var relationshipCategoryObject = new JObject();
                var relationshipCategoryObjectpropCount = 0;
                if (__workflow_bodyrelationshipCategorydcv != null)
                {
                    relationshipCategoryObject["dcv"] = ExpressionConverter.ConvertO(__workflow_bodyrelationshipCategorydcv);
                    relationshipCategoryObjectpropCount++;
                }

                if (__workflow_bodyrelationshipCategoryname != null)
                {
                    relationshipCategoryObject["name"] = ExpressionConverter.ConvertO(__workflow_bodyrelationshipCategoryname);
                    relationshipCategoryObjectpropCount++;
                }

                if (__workflow_bodyrelationshipCategoryicon != null)
                {
                    relationshipCategoryObject["icon"] = ExpressionConverter.ConvertO(__workflow_bodyrelationshipCategoryicon);
                    relationshipCategoryObjectpropCount++;
                }

                if (relationshipCategoryObjectpropCount > 0)
                {
                    body["relationshipCategory"] = relationshipCategoryObject;
                    bodypropCount++;
                }

                var characteristicObject = new JObject();
                var characteristicObjectpropCount = 0;
                if (__workflow_bodyrelationshipCategorydcv != null)
                {
                    characteristicObject["dcv"] = ExpressionConverter.ConvertO(__workflow_bodyrelationshipCategorydcv);
                    characteristicObjectpropCount++;
                }

                if (__workflow_bodyrelationshipCategoryname != null)
                {
                    characteristicObject["name"] = ExpressionConverter.ConvertO(__workflow_bodyrelationshipCategoryname);
                    characteristicObjectpropCount++;
                }

                if (__workflow_bodyrelationshipCategoryicon != null)
                {
                    characteristicObject["icon"] = ExpressionConverter.ConvertO(__workflow_bodyrelationshipCategoryicon);
                    characteristicObjectpropCount++;
                }

                if (characteristicObjectpropCount > 0)
                {
                    body["characteristic"] = characteristicObject;
                    bodypropCount++;
                }

                if (__workflow_bodyopenLocation != null)
                {
                    body["openLocation"] = ExpressionConverter.ConvertO(__workflow_bodyopenLocation);
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
        public IBodyWorkflowAction<IField> UpdateRelationshipSingleField(Expression<Func<string>> dbId, Expression<Func<dataLanguageInput>> dataLanguage, Expression<Func<string>> topicId, Expression<Func<string>> fieldsetId, Expression<Func<string>> fieldId, Expression<Func<string>> bodyfieldId = null, Expression<Func<string>> bodyfieldsetId = null, Expression<Func<string>> bodydatadcv = null, Expression<Func<string>> bodydataname = null, Expression<Func<string>> bodydataicon = null)
        {
            var __workflow_dbId = WorkflowExpression.Compile(dbId, nameof(dbId), required: true);
            var __workflow_dataLanguage = WorkflowExpression.Compile(dataLanguage, nameof(dataLanguage), required: true);
            var __workflow_topicId = WorkflowExpression.Compile(topicId, nameof(topicId), required: true);
            var __workflow_fieldsetId = WorkflowExpression.Compile(fieldsetId, nameof(fieldsetId), required: true);
            var __workflow_fieldId = WorkflowExpression.Compile(fieldId, nameof(fieldId), required: true);
            var __workflow_bodyfieldId = WorkflowExpression.Compile(bodyfieldId, nameof(bodyfieldId), required: false);
            var __workflow_bodyfieldsetId = WorkflowExpression.Compile(bodyfieldsetId, nameof(bodyfieldsetId), required: false);
            var __workflow_bodydatadcv = WorkflowExpression.Compile(bodydatadcv, nameof(bodydatadcv), required: false);
            var __workflow_bodydataname = WorkflowExpression.Compile(bodydataname, nameof(bodydataname), required: false);
            var __workflow_bodydataicon = WorkflowExpression.Compile(bodydataicon, nameof(bodydataicon), required: false);
            return new DeferredBodyAction<IField>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/{0}/{1}/topic/{2}/fieldsets/{3}/relationship/{4}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_dbId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_dataLanguage, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_topicId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_fieldsetId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_fieldId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyfieldId != null)
                {
                    body["fieldId"] = ExpressionConverter.ConvertO(__workflow_bodyfieldId);
                    bodypropCount++;
                }

                if (__workflow_bodyfieldsetId != null)
                {
                    body["fieldsetId"] = ExpressionConverter.ConvertO(__workflow_bodyfieldsetId);
                    bodypropCount++;
                }

                var dataObject = new JObject();
                var dataObjectpropCount = 0;
                if (__workflow_bodydatadcv != null)
                {
                    dataObject["dcv"] = ExpressionConverter.ConvertO(__workflow_bodydatadcv);
                    dataObjectpropCount++;
                }

                if (__workflow_bodydataname != null)
                {
                    dataObject["name"] = ExpressionConverter.ConvertO(__workflow_bodydataname);
                    dataObjectpropCount++;
                }

                if (__workflow_bodydataicon != null)
                {
                    dataObject["icon"] = ExpressionConverter.ConvertO(__workflow_bodydataicon);
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
        public IBodyWorkflowAction<IField> UpdateRelationshipMultiField(Expression<Func<string>> dbId, Expression<Func<dataLanguageInput>> dataLanguage, Expression<Func<string>> topicId, Expression<Func<string>> fieldsetId, Expression<Func<string>> fieldId, Expression<Func<string>> bodyfieldId = null, Expression<Func<string>> bodyfieldsetId = null, Expression<Func<RelationshipElement[]>> bodydata = null)
        {
            var __workflow_dbId = WorkflowExpression.Compile(dbId, nameof(dbId), required: true);
            var __workflow_dataLanguage = WorkflowExpression.Compile(dataLanguage, nameof(dataLanguage), required: true);
            var __workflow_topicId = WorkflowExpression.Compile(topicId, nameof(topicId), required: true);
            var __workflow_fieldsetId = WorkflowExpression.Compile(fieldsetId, nameof(fieldsetId), required: true);
            var __workflow_fieldId = WorkflowExpression.Compile(fieldId, nameof(fieldId), required: true);
            var __workflow_bodyfieldId = WorkflowExpression.Compile(bodyfieldId, nameof(bodyfieldId), required: false);
            var __workflow_bodyfieldsetId = WorkflowExpression.Compile(bodyfieldsetId, nameof(bodyfieldsetId), required: false);
            var __workflow_bodydata = WorkflowExpression.Compile(bodydata, nameof(bodydata), required: false);
            return new DeferredBodyAction<IField>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/{0}/{1}/topic/{2}/fieldsets/{3}/multirelationship/{4}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_dbId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_dataLanguage, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_topicId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_fieldsetId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_fieldId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyfieldId != null)
                {
                    body["fieldId"] = ExpressionConverter.ConvertO(__workflow_bodyfieldId);
                    bodypropCount++;
                }

                if (__workflow_bodyfieldsetId != null)
                {
                    body["fieldsetId"] = ExpressionConverter.ConvertO(__workflow_bodyfieldsetId);
                    bodypropCount++;
                }

                if (__workflow_bodydata != null)
                {
                    body["data"] = ExpressionConverter.ConvertO(__workflow_bodydata);
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
        public IBodyWorkflowAction<IField> UpdateRelationshipListField(Expression<Func<string>> dbId, Expression<Func<dataLanguageInput>> dataLanguage, Expression<Func<string>> topicId, Expression<Func<string>> fieldsetId, Expression<Func<string>> fieldId, Expression<Func<string>> bodyfieldId = null, Expression<Func<string>> bodyfieldsetId = null)
        {
            var __workflow_dbId = WorkflowExpression.Compile(dbId, nameof(dbId), required: true);
            var __workflow_dataLanguage = WorkflowExpression.Compile(dataLanguage, nameof(dataLanguage), required: true);
            var __workflow_topicId = WorkflowExpression.Compile(topicId, nameof(topicId), required: true);
            var __workflow_fieldsetId = WorkflowExpression.Compile(fieldsetId, nameof(fieldsetId), required: true);
            var __workflow_fieldId = WorkflowExpression.Compile(fieldId, nameof(fieldId), required: true);
            var __workflow_bodyfieldId = WorkflowExpression.Compile(bodyfieldId, nameof(bodyfieldId), required: false);
            var __workflow_bodyfieldsetId = WorkflowExpression.Compile(bodyfieldsetId, nameof(bodyfieldsetId), required: false);
            return new DeferredBodyAction<IField>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/{0}/{1}/topic/{2}/fieldsets/{3}/relationshiplist/{4}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_dbId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_dataLanguage, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_topicId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_fieldsetId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_fieldId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyfieldId != null)
                {
                    body["fieldId"] = ExpressionConverter.ConvertO(__workflow_bodyfieldId);
                    bodypropCount++;
                }

                if (__workflow_bodyfieldsetId != null)
                {
                    body["fieldsetId"] = ExpressionConverter.ConvertO(__workflow_bodyfieldsetId);
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
        public IBodyWorkflowAction<IField> UpdateFields(Expression<Func<string>> dbId, Expression<Func<dataLanguageInput>> dataLanguage, Expression<Func<string>> topicId, Expression<Func<SingleTextField[]>> bodysingleTextFields = null, Expression<Func<MultiTextField[]>> bodymultiTextFields = null, Expression<Func<SingleNumberField[]>> bodysingleNumberFields = null, Expression<Func<MultiNumberField[]>> bodymultiNumberFields = null, Expression<Func<SingleBooleanField[]>> bodysingleBooleanFields = null, Expression<Func<SingleDecimalField[]>> bodysingleDecimalFields = null, Expression<Func<MultiDecimalField[]>> bodymultiDecimalFields = null, Expression<Func<SingleDateField[]>> bodysingleDateFields = null, Expression<Func<MultiDateField[]>> bodymultiDateFields = null, Expression<Func<SingleListField[]>> bodysingleListFields = null, Expression<Func<RelationshipField[]>> bodysingleRelationshipFields = null, Expression<Func<MultiRelationshipField[]>> bodymultiRelationshipFields = null, Expression<Func<RelationshipListField[]>> bodysingleRelationshipListFields = null, Expression<Func<SingleHyperlinkField[]>> bodysingleHyperlinkFields = null, Expression<Func<MultiHyperlinkField[]>> bodymultiHyperlinkFields = null)
        {
            var __workflow_dbId = WorkflowExpression.Compile(dbId, nameof(dbId), required: true);
            var __workflow_dataLanguage = WorkflowExpression.Compile(dataLanguage, nameof(dataLanguage), required: true);
            var __workflow_topicId = WorkflowExpression.Compile(topicId, nameof(topicId), required: true);
            var __workflow_bodysingleTextFields = WorkflowExpression.Compile(bodysingleTextFields, nameof(bodysingleTextFields), required: false);
            var __workflow_bodymultiTextFields = WorkflowExpression.Compile(bodymultiTextFields, nameof(bodymultiTextFields), required: false);
            var __workflow_bodysingleNumberFields = WorkflowExpression.Compile(bodysingleNumberFields, nameof(bodysingleNumberFields), required: false);
            var __workflow_bodymultiNumberFields = WorkflowExpression.Compile(bodymultiNumberFields, nameof(bodymultiNumberFields), required: false);
            var __workflow_bodysingleBooleanFields = WorkflowExpression.Compile(bodysingleBooleanFields, nameof(bodysingleBooleanFields), required: false);
            var __workflow_bodysingleDecimalFields = WorkflowExpression.Compile(bodysingleDecimalFields, nameof(bodysingleDecimalFields), required: false);
            var __workflow_bodymultiDecimalFields = WorkflowExpression.Compile(bodymultiDecimalFields, nameof(bodymultiDecimalFields), required: false);
            var __workflow_bodysingleDateFields = WorkflowExpression.Compile(bodysingleDateFields, nameof(bodysingleDateFields), required: false);
            var __workflow_bodymultiDateFields = WorkflowExpression.Compile(bodymultiDateFields, nameof(bodymultiDateFields), required: false);
            var __workflow_bodysingleListFields = WorkflowExpression.Compile(bodysingleListFields, nameof(bodysingleListFields), required: false);
            var __workflow_bodysingleRelationshipFields = WorkflowExpression.Compile(bodysingleRelationshipFields, nameof(bodysingleRelationshipFields), required: false);
            var __workflow_bodymultiRelationshipFields = WorkflowExpression.Compile(bodymultiRelationshipFields, nameof(bodymultiRelationshipFields), required: false);
            var __workflow_bodysingleRelationshipListFields = WorkflowExpression.Compile(bodysingleRelationshipListFields, nameof(bodysingleRelationshipListFields), required: false);
            var __workflow_bodysingleHyperlinkFields = WorkflowExpression.Compile(bodysingleHyperlinkFields, nameof(bodysingleHyperlinkFields), required: false);
            var __workflow_bodymultiHyperlinkFields = WorkflowExpression.Compile(bodymultiHyperlinkFields, nameof(bodymultiHyperlinkFields), required: false);
            return new DeferredBodyAction<IField>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/{0}/{1}/topic/{2}/fields", ExpressionConverter.ConvertWithUrlEncoding(__workflow_dbId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_dataLanguage, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_topicId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodysingleTextFields != null)
                {
                    body["singleTextFields"] = ExpressionConverter.ConvertO(__workflow_bodysingleTextFields);
                    bodypropCount++;
                }

                if (__workflow_bodymultiTextFields != null)
                {
                    body["multiTextFields"] = ExpressionConverter.ConvertO(__workflow_bodymultiTextFields);
                    bodypropCount++;
                }

                if (__workflow_bodysingleNumberFields != null)
                {
                    body["singleNumberFields"] = ExpressionConverter.ConvertO(__workflow_bodysingleNumberFields);
                    bodypropCount++;
                }

                if (__workflow_bodymultiNumberFields != null)
                {
                    body["multiNumberFields"] = ExpressionConverter.ConvertO(__workflow_bodymultiNumberFields);
                    bodypropCount++;
                }

                if (__workflow_bodysingleBooleanFields != null)
                {
                    body["singleBooleanFields"] = ExpressionConverter.ConvertO(__workflow_bodysingleBooleanFields);
                    bodypropCount++;
                }

                if (__workflow_bodysingleDecimalFields != null)
                {
                    body["singleDecimalFields"] = ExpressionConverter.ConvertO(__workflow_bodysingleDecimalFields);
                    bodypropCount++;
                }

                if (__workflow_bodymultiDecimalFields != null)
                {
                    body["multiDecimalFields"] = ExpressionConverter.ConvertO(__workflow_bodymultiDecimalFields);
                    bodypropCount++;
                }

                if (__workflow_bodysingleDateFields != null)
                {
                    body["singleDateFields"] = ExpressionConverter.ConvertO(__workflow_bodysingleDateFields);
                    bodypropCount++;
                }

                if (__workflow_bodymultiDateFields != null)
                {
                    body["multiDateFields"] = ExpressionConverter.ConvertO(__workflow_bodymultiDateFields);
                    bodypropCount++;
                }

                if (__workflow_bodysingleListFields != null)
                {
                    body["singleListFields"] = ExpressionConverter.ConvertO(__workflow_bodysingleListFields);
                    bodypropCount++;
                }

                if (__workflow_bodysingleRelationshipFields != null)
                {
                    body["singleRelationshipFields"] = ExpressionConverter.ConvertO(__workflow_bodysingleRelationshipFields);
                    bodypropCount++;
                }

                if (__workflow_bodymultiRelationshipFields != null)
                {
                    body["multiRelationshipFields"] = ExpressionConverter.ConvertO(__workflow_bodymultiRelationshipFields);
                    bodypropCount++;
                }

                if (__workflow_bodysingleRelationshipListFields != null)
                {
                    body["singleRelationshipListFields"] = ExpressionConverter.ConvertO(__workflow_bodysingleRelationshipListFields);
                    bodypropCount++;
                }

                if (__workflow_bodysingleHyperlinkFields != null)
                {
                    body["singleHyperlinkFields"] = ExpressionConverter.ConvertO(__workflow_bodysingleHyperlinkFields);
                    bodypropCount++;
                }

                if (__workflow_bodymultiHyperlinkFields != null)
                {
                    body["multiHyperlinkFields"] = ExpressionConverter.ConvertO(__workflow_bodymultiHyperlinkFields);
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
        public IBodyWorkflowAction<IField> UpdateSingleHyperlinkField(Expression<Func<string>> dbId, Expression<Func<dataLanguageInput>> dataLanguage, Expression<Func<string>> topicId, Expression<Func<string>> fieldsetId, Expression<Func<string>> fieldId, Expression<Func<string>> bodydata = null)
        {
            var __workflow_dbId = WorkflowExpression.Compile(dbId, nameof(dbId), required: true);
            var __workflow_dataLanguage = WorkflowExpression.Compile(dataLanguage, nameof(dataLanguage), required: true);
            var __workflow_topicId = WorkflowExpression.Compile(topicId, nameof(topicId), required: true);
            var __workflow_fieldsetId = WorkflowExpression.Compile(fieldsetId, nameof(fieldsetId), required: true);
            var __workflow_fieldId = WorkflowExpression.Compile(fieldId, nameof(fieldId), required: true);
            var __workflow_bodydata = WorkflowExpression.Compile(bodydata, nameof(bodydata), required: false);
            return new DeferredBodyAction<IField>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/{0}/{1}/topic/{2}/fieldsets/{3}/hyperlink/{4}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_dbId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_dataLanguage, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_topicId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_fieldsetId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_fieldId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodydata != null)
                {
                    body["data"] = ExpressionConverter.ConvertO(__workflow_bodydata);
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
        public IBodyWorkflowAction<IField> UpdateMultiHyperlinkField(Expression<Func<string>> dbId, Expression<Func<dataLanguageInput>> dataLanguage, Expression<Func<string>> topicId, Expression<Func<string>> fieldsetId, Expression<Func<string>> fieldId, Expression<Func<string[]>> bodydata = null)
        {
            var __workflow_dbId = WorkflowExpression.Compile(dbId, nameof(dbId), required: true);
            var __workflow_dataLanguage = WorkflowExpression.Compile(dataLanguage, nameof(dataLanguage), required: true);
            var __workflow_topicId = WorkflowExpression.Compile(topicId, nameof(topicId), required: true);
            var __workflow_fieldsetId = WorkflowExpression.Compile(fieldsetId, nameof(fieldsetId), required: true);
            var __workflow_fieldId = WorkflowExpression.Compile(fieldId, nameof(fieldId), required: true);
            var __workflow_bodydata = WorkflowExpression.Compile(bodydata, nameof(bodydata), required: false);
            return new DeferredBodyAction<IField>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/{0}/{1}/topic/{2}/fieldsets/{3}/multihyperlink/{4}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_dbId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_dataLanguage, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_topicId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_fieldsetId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_fieldId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodydata != null)
                {
                    body["data"] = ExpressionConverter.ConvertO(__workflow_bodydata);
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
        public IWorkflowAction MoveTopicToTop(Expression<Func<string>> dbId, Expression<Func<dataLanguageInput>> dataLanguage, Expression<Func<string>> topicId)
        {
            var __workflow_dbId = WorkflowExpression.Compile(dbId, nameof(dbId), required: true);
            var __workflow_dataLanguage = WorkflowExpression.Compile(dataLanguage, nameof(dataLanguage), required: true);
            var __workflow_topicId = WorkflowExpression.Compile(topicId, nameof(topicId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/{0}/{1}/topic/{2}/movetotop", ExpressionConverter.ConvertWithUrlEncoding(__workflow_dbId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_dataLanguage, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_topicId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IWorkflowAction MoveTopicToBottom(Expression<Func<string>> dbId, Expression<Func<dataLanguageInput>> dataLanguage, Expression<Func<string>> topicId)
        {
            var __workflow_dbId = WorkflowExpression.Compile(dbId, nameof(dbId), required: true);
            var __workflow_dataLanguage = WorkflowExpression.Compile(dataLanguage, nameof(dataLanguage), required: true);
            var __workflow_topicId = WorkflowExpression.Compile(topicId, nameof(topicId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/{0}/{1}/topic/{2}/movetobottom", ExpressionConverter.ConvertWithUrlEncoding(__workflow_dbId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_dataLanguage, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_topicId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IWorkflowAction MoveTopicUp(Expression<Func<string>> dbId, Expression<Func<dataLanguageInput>> dataLanguage, Expression<Func<string>> topicId)
        {
            var __workflow_dbId = WorkflowExpression.Compile(dbId, nameof(dbId), required: true);
            var __workflow_dataLanguage = WorkflowExpression.Compile(dataLanguage, nameof(dataLanguage), required: true);
            var __workflow_topicId = WorkflowExpression.Compile(topicId, nameof(topicId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/{0}/{1}/topic/{2}/moveup", ExpressionConverter.ConvertWithUrlEncoding(__workflow_dbId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_dataLanguage, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_topicId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IWorkflowAction MoveTopicDown(Expression<Func<string>> dbId, Expression<Func<dataLanguageInput>> dataLanguage, Expression<Func<string>> topicId)
        {
            var __workflow_dbId = WorkflowExpression.Compile(dbId, nameof(dbId), required: true);
            var __workflow_dataLanguage = WorkflowExpression.Compile(dataLanguage, nameof(dataLanguage), required: true);
            var __workflow_topicId = WorkflowExpression.Compile(topicId, nameof(topicId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/{0}/{1}/topic/{2}/movedown", ExpressionConverter.ConvertWithUrlEncoding(__workflow_dbId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_dataLanguage, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_topicId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IWorkflowAction MoveTopicLevelUp(Expression<Func<string>> dbId, Expression<Func<dataLanguageInput>> dataLanguage, Expression<Func<string>> topicId)
        {
            var __workflow_dbId = WorkflowExpression.Compile(dbId, nameof(dbId), required: true);
            var __workflow_dataLanguage = WorkflowExpression.Compile(dataLanguage, nameof(dataLanguage), required: true);
            var __workflow_topicId = WorkflowExpression.Compile(topicId, nameof(topicId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/{0}/{1}/topic/{2}/movelevelup", ExpressionConverter.ConvertWithUrlEncoding(__workflow_dbId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_dataLanguage, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_topicId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IWorkflowAction MoveTopicLevelDown(Expression<Func<string>> dbId, Expression<Func<dataLanguageInput>> dataLanguage, Expression<Func<string>> topicId)
        {
            var __workflow_dbId = WorkflowExpression.Compile(dbId, nameof(dbId), required: true);
            var __workflow_dataLanguage = WorkflowExpression.Compile(dataLanguage, nameof(dataLanguage), required: true);
            var __workflow_topicId = WorkflowExpression.Compile(topicId, nameof(topicId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/{0}/{1}/topic/{2}/moveleveldown", ExpressionConverter.ConvertWithUrlEncoding(__workflow_dbId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_dataLanguage, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_topicId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IBodyWorkflowAction<IRelationship[]> GetTopicRelations(Expression<Func<string>> dbId, Expression<Func<dataLanguageInput>> dataLanguage, Expression<Func<string>> topicId)
        {
            var __workflow_dbId = WorkflowExpression.Compile(dbId, nameof(dbId), required: true);
            var __workflow_dataLanguage = WorkflowExpression.Compile(dataLanguage, nameof(dataLanguage), required: true);
            var __workflow_topicId = WorkflowExpression.Compile(topicId, nameof(topicId), required: true);
            return new DeferredBodyAction<IRelationship[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/{0}/{1}/topic/{2}/relations", ExpressionConverter.ConvertWithUrlEncoding(__workflow_dbId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_dataLanguage, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_topicId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<IRelationship[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IBodyWorkflowAction<IRelationship> SaveRelation(Expression<Func<string>> dbId, Expression<Func<dataLanguageInput>> dataLanguage, Expression<Func<string>> bodyfromElementDcv = null, Expression<Func<string>> bodytoElementDcv = null, Expression<Func<bodyrelationshipTypeInput>> bodyrelationshipType = null)
        {
            var __workflow_dbId = WorkflowExpression.Compile(dbId, nameof(dbId), required: true);
            var __workflow_dataLanguage = WorkflowExpression.Compile(dataLanguage, nameof(dataLanguage), required: true);
            var __workflow_bodyfromElementDcv = WorkflowExpression.Compile(bodyfromElementDcv, nameof(bodyfromElementDcv), required: false);
            var __workflow_bodytoElementDcv = WorkflowExpression.Compile(bodytoElementDcv, nameof(bodytoElementDcv), required: false);
            var __workflow_bodyrelationshipType = WorkflowExpression.Compile(bodyrelationshipType, nameof(bodyrelationshipType), required: false);
            return new DeferredBodyAction<IRelationship>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/{0}/{1}/relation", ExpressionConverter.ConvertWithUrlEncoding(__workflow_dbId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_dataLanguage, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyfromElementDcv != null)
                {
                    body["fromElementDcv"] = ExpressionConverter.ConvertO(__workflow_bodyfromElementDcv);
                    bodypropCount++;
                }

                if (__workflow_bodytoElementDcv != null)
                {
                    body["toElementDcv"] = ExpressionConverter.ConvertO(__workflow_bodytoElementDcv);
                    bodypropCount++;
                }

                if (__workflow_bodyrelationshipType != null)
                {
                    body["relationshipType"] = ExpressionConverter.ConvertO(__workflow_bodyrelationshipType);
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
        public IWorkflowAction DeleteRelation(Expression<Func<string>> dbId, Expression<Func<dataLanguageInput>> dataLanguage, Expression<Func<string>> topicId, Expression<Func<string>> relationId)
        {
            var __workflow_dbId = WorkflowExpression.Compile(dbId, nameof(dbId), required: true);
            var __workflow_dataLanguage = WorkflowExpression.Compile(dataLanguage, nameof(dataLanguage), required: true);
            var __workflow_topicId = WorkflowExpression.Compile(topicId, nameof(topicId), required: true);
            var __workflow_relationId = WorkflowExpression.Compile(relationId, nameof(relationId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/{0}/{1}/topic/{2}/relation/{3}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_dbId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_dataLanguage, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_topicId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_relationId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IBodyWorkflowAction<ITopic> GetTopicRoot(Expression<Func<string>> dbId, Expression<Func<dataLanguageInput>> dataLanguage)
        {
            var __workflow_dbId = WorkflowExpression.Compile(dbId, nameof(dbId), required: true);
            var __workflow_dataLanguage = WorkflowExpression.Compile(dataLanguage, nameof(dataLanguage), required: true);
            return new DeferredBodyAction<ITopic>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/{0}/{1}/root", ExpressionConverter.ConvertWithUrlEncoding(__workflow_dbId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_dataLanguage, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ITopic>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IBodyWorkflowAction<ITopicPath> GetPathToRoot(Expression<Func<string>> dbId, Expression<Func<dataLanguageInput>> dataLanguage, Expression<Func<string>> topicId)
        {
            var __workflow_dbId = WorkflowExpression.Compile(dbId, nameof(dbId), required: true);
            var __workflow_dataLanguage = WorkflowExpression.Compile(dataLanguage, nameof(dataLanguage), required: true);
            var __workflow_topicId = WorkflowExpression.Compile(topicId, nameof(topicId), required: true);
            return new DeferredBodyAction<ITopicPath>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/{0}/{1}/path/{2}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_dbId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_dataLanguage, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_topicId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ITopicPath>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IBodyWorkflowAction<ITopic[]> GetTopicSiblings(Expression<Func<string>> dbId, Expression<Func<dataLanguageInput>> dataLanguage, Expression<Func<string>> topicId)
        {
            var __workflow_dbId = WorkflowExpression.Compile(dbId, nameof(dbId), required: true);
            var __workflow_dataLanguage = WorkflowExpression.Compile(dataLanguage, nameof(dataLanguage), required: true);
            var __workflow_topicId = WorkflowExpression.Compile(topicId, nameof(topicId), required: true);
            return new DeferredBodyAction<ITopic[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/{0}/{1}/topic/{2}/siblings", ExpressionConverter.ConvertWithUrlEncoding(__workflow_dbId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_dataLanguage, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_topicId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ITopic[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IBodyWorkflowAction<ITopic[]> GetRelationCategories(Expression<Func<string>> dbId, Expression<Func<dataLanguageInput>> dataLanguage)
        {
            var __workflow_dbId = WorkflowExpression.Compile(dbId, nameof(dbId), required: true);
            var __workflow_dataLanguage = WorkflowExpression.Compile(dataLanguage, nameof(dataLanguage), required: true);
            return new DeferredBodyAction<ITopic[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/{0}/{1}/topic/categories", ExpressionConverter.ConvertWithUrlEncoding(__workflow_dbId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_dataLanguage, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ITopic[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IBodyWorkflowAction<JToken> GetTopicTypes(Expression<Func<string>> dbId, Expression<Func<dataLanguageInput>> dataLanguage, Expression<Func<string>> topicId)
        {
            var __workflow_dbId = WorkflowExpression.Compile(dbId, nameof(dbId), required: true);
            var __workflow_dataLanguage = WorkflowExpression.Compile(dataLanguage, nameof(dataLanguage), required: true);
            var __workflow_topicId = WorkflowExpression.Compile(topicId, nameof(topicId), required: true);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/{0}/{1}/topic/{2}/types", ExpressionConverter.ConvertWithUrlEncoding(__workflow_dbId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_dataLanguage, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_topicId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mavimimprove")]
        public IBodyWorkflowAction<JToken> GetTopicIcons(Expression<Func<string>> dbId, Expression<Func<dataLanguageInput>> dataLanguage, Expression<Func<string>> topicType)
        {
            var __workflow_dbId = WorkflowExpression.Compile(dbId, nameof(dbId), required: true);
            var __workflow_dataLanguage = WorkflowExpression.Compile(dataLanguage, nameof(dataLanguage), required: true);
            var __workflow_topicType = WorkflowExpression.Compile(topicType, nameof(topicType), required: true);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/{0}/{1}/types/{2}/icons", ExpressionConverter.ConvertWithUrlEncoding(__workflow_dbId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_dataLanguage, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_topicType, 1));
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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
