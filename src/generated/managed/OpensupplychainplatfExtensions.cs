//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Opensupplychainplatf
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class OpensupplychainplatfActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opensupplychainplatf")]
        public IBodyWorkflowAction<Carrier> CarrierGet(Expression<Func<string>> carrierId)
        {
            var apiCallPath = String.Format("/carriers/{0}", ExpressionConverter.ConvertWithUrlEncoding(carrierId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<Carrier>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opensupplychainplatf")]
        public IBodyWorkflowAction<object> CarrierDelete(Expression<Func<string>> carrierId)
        {
            var apiCallPath = String.Format("/carriers/{0}", ExpressionConverter.ConvertWithUrlEncoding(carrierId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<object>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opensupplychainplatf")]
        public IBodyWorkflowAction<Carrier> CarrierPut(Expression<Func<string>> carrierId, Expression<Func<string>> carrierid, Expression<Func<string>> carriertype, Expression<Func<Note[]>> carriernotes = null)
        {
            var apiCallPath = String.Format("/carriers/{0}", ExpressionConverter.ConvertWithUrlEncoding(carrierId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var carrier = new JObject();
            var carrierpropCount = 0;
            carrierpropCount++;
            carrier["id"] = ExpressionConverter.ConvertO(carrierid);
            carrierpropCount++;
            carrier["type"] = ExpressionConverter.ConvertO(carriertype);
            if (carriernotes != null)
            {
                carrier["notes"] = ExpressionConverter.ConvertO(carriernotes);
                carrierpropCount++;
            }

            if (carrierpropCount > 0)
            {
                callPayload.Body = carrier;
            }

            return new ApiConnectionAction<Carrier>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opensupplychainplatf")]
        public IBodyWorkflowAction<DataInflow> DataInflowGetDataInflow(Expression<Func<string>> name)
        {
            var apiCallPath = String.Format("/dataInflows/{0}", ExpressionConverter.ConvertWithUrlEncoding(name, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<DataInflow>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opensupplychainplatf")]
        public IBodyWorkflowAction<DataInflow> DataInflowDeleteDataInflow(Expression<Func<string>> name)
        {
            var apiCallPath = String.Format("/dataInflows/{0}", ExpressionConverter.ConvertWithUrlEncoding(name, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<DataInflow>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opensupplychainplatf")]
        public IBodyWorkflowAction<DataInflow> DataInflowPutDataInflow(Expression<Func<string>> name, Expression<Func<string>> dataInflowname, Expression<Func<string>> dataInflowdisplayName, Expression<Func<string>> dataInflowdatasetName, Expression<Func<string>> dataInflowconnectortype, Expression<Func<string>> dataInflowtransformertype = null, Expression<Func<string>> dataInflowstate = null)
        {
            var apiCallPath = String.Format("/dataInflows/{0}", ExpressionConverter.ConvertWithUrlEncoding(name, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var dataInflow = new JObject();
            var dataInflowpropCount = 0;
            dataInflowpropCount++;
            dataInflow["name"] = ExpressionConverter.ConvertO(dataInflowname);
            dataInflowpropCount++;
            dataInflow["displayName"] = ExpressionConverter.ConvertO(dataInflowdisplayName);
            dataInflowpropCount++;
            dataInflow["datasetName"] = ExpressionConverter.ConvertO(dataInflowdatasetName);
            var connectorObject = new JObject();
            var connectorObjectpropCount = 0;
            connectorObjectpropCount++;
            connectorObject["type"] = ExpressionConverter.ConvertO(dataInflowconnectortype);
            var typePropertiesObject = new JObject();
            var typePropertiesObjectpropCount = 0;
            if (typePropertiesObjectpropCount > 0)
            {
                connectorObject["typeProperties"] = typePropertiesObject;
                connectorObjectpropCount++;
            }

            var outputObject = new JObject();
            var outputObjectpropCount = 0;
            if (outputObjectpropCount > 0)
            {
                connectorObject["output"] = outputObject;
                connectorObjectpropCount++;
            }

            if (connectorObjectpropCount > 0)
            {
                dataInflow["connector"] = connectorObject;
                dataInflowpropCount++;
            }

            var transformerObject = new JObject();
            var transformerObjectpropCount = 0;
            if (dataInflowtransformertype != null)
            {
                transformerObject["type"] = ExpressionConverter.ConvertO(dataInflowtransformertype);
                transformerObjectpropCount++;
            }

            var typePropertiesObject = new JObject();
            var typePropertiesObjectpropCount = 0;
            if (typePropertiesObjectpropCount > 0)
            {
                transformerObject["typeProperties"] = typePropertiesObject;
                transformerObjectpropCount++;
            }

            if (transformerObjectpropCount > 0)
            {
                dataInflow["transformer"] = transformerObject;
                dataInflowpropCount++;
            }

            if (dataInflowstate != null)
            {
                dataInflow["state"] = ExpressionConverter.ConvertO(dataInflowstate);
                dataInflowpropCount++;
            }

            if (dataInflowpropCount > 0)
            {
                callPayload.Body = dataInflow;
            }

            return new ApiConnectionAction<DataInflow>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opensupplychainplatf")]
        public IBodyWorkflowAction<DataInflow[]> DataInflowGetAllDataInflows()
        {
            var apiCallPath = "/dataInflows";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<DataInflow[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opensupplychainplatf")]
        public IBodyWorkflowAction<DataInflowRun> DataInflowPostDataInflowRun(Expression<Func<string>> name, Expression<Func<string>> dataInflowRundataInflowName = null, Expression<Func<string>> dataInflowRundataInflowRunId = null, Expression<Func<string>> dataInflowRuntriggeredAt = null, Expression<Func<string>> dataInflowRuncompletedAt = null, Expression<Func<string>> dataInflowRunstatus = null)
        {
            var apiCallPath = String.Format("/dataInflows/{0}/run", ExpressionConverter.ConvertWithUrlEncoding(name, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var dataInflowRun = new JObject();
            var dataInflowRunpropCount = 0;
            if (dataInflowRundataInflowName != null)
            {
                dataInflowRun["dataInflowName"] = ExpressionConverter.ConvertO(dataInflowRundataInflowName);
                dataInflowRunpropCount++;
            }

            var runParamsObject = new JObject();
            var runParamsObjectpropCount = 0;
            if (runParamsObjectpropCount > 0)
            {
                dataInflowRun["runParams"] = runParamsObject;
                dataInflowRunpropCount++;
            }

            if (dataInflowRundataInflowRunId != null)
            {
                dataInflowRun["dataInflowRunId"] = ExpressionConverter.ConvertO(dataInflowRundataInflowRunId);
                dataInflowRunpropCount++;
            }

            if (dataInflowRuntriggeredAt != null)
            {
                dataInflowRun["triggeredAt"] = ExpressionConverter.ConvertO(dataInflowRuntriggeredAt);
                dataInflowRunpropCount++;
            }

            if (dataInflowRuncompletedAt != null)
            {
                dataInflowRun["completedAt"] = ExpressionConverter.ConvertO(dataInflowRuncompletedAt);
                dataInflowRunpropCount++;
            }

            if (dataInflowRunstatus != null)
            {
                dataInflowRun["status"] = ExpressionConverter.ConvertO(dataInflowRunstatus);
                dataInflowRunpropCount++;
            }

            if (dataInflowRunpropCount > 0)
            {
                callPayload.Body = dataInflowRun;
            }

            return new ApiConnectionAction<DataInflowRun>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opensupplychainplatf")]
        public IBodyWorkflowAction<DataInflowRun> DataInflowRunGetDataInflowRun(Expression<Func<string>> name, Expression<Func<string>> dataInflowRunId)
        {
            var apiCallPath = String.Format("/dataInflows/{0}/dataInflowRuns/{1}", ExpressionConverter.ConvertWithUrlEncoding(name, 1), ExpressionConverter.ConvertWithUrlEncoding(dataInflowRunId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<DataInflowRun>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opensupplychainplatf")]
        public IBodyWorkflowAction<DataInflowRun[]> DataInflowRunListDataInflowRuns(Expression<Func<string>> name)
        {
            var apiCallPath = String.Format("/dataInflows/{0}/dataInflowRuns", ExpressionConverter.ConvertWithUrlEncoding(name, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<DataInflowRun[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opensupplychainplatf")]
        public IBodyWorkflowAction<DataOutflow> DataOutflowGetDataOutflow(Expression<Func<string>> name)
        {
            var apiCallPath = String.Format("/dataOutflows/{0}", ExpressionConverter.ConvertWithUrlEncoding(name, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<DataOutflow>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opensupplychainplatf")]
        public IBodyWorkflowAction<DataOutflow> DataOutflowDeleteDataOutflow(Expression<Func<string>> name)
        {
            var apiCallPath = String.Format("/dataOutflows/{0}", ExpressionConverter.ConvertWithUrlEncoding(name, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<DataOutflow>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opensupplychainplatf")]
        public IBodyWorkflowAction<DataOutflow> DataOutflowPutDataOutflow(Expression<Func<string>> name, Expression<Func<string>> dataOutflowname, Expression<Func<string>> dataOutflowdisplayName, Expression<Func<string>> dataOutflowdescription, Expression<Func<string>> dataOutflowdatasetName, Expression<Func<string>> dataOutflowconnectortype, Expression<Func<DataSchema[]>> dataOutflowfilteredEntities = null, Expression<Func<string>> dataOutflowtransformertype = null, Expression<Func<string>> dataOutflowstate = null)
        {
            var apiCallPath = String.Format("/dataOutflows/{0}", ExpressionConverter.ConvertWithUrlEncoding(name, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var dataOutflow = new JObject();
            var dataOutflowpropCount = 0;
            dataOutflowpropCount++;
            dataOutflow["name"] = ExpressionConverter.ConvertO(dataOutflowname);
            dataOutflowpropCount++;
            dataOutflow["displayName"] = ExpressionConverter.ConvertO(dataOutflowdisplayName);
            dataOutflowpropCount++;
            dataOutflow["description"] = ExpressionConverter.ConvertO(dataOutflowdescription);
            dataOutflowpropCount++;
            dataOutflow["datasetName"] = ExpressionConverter.ConvertO(dataOutflowdatasetName);
            if (dataOutflowfilteredEntities != null)
            {
                dataOutflow["filteredEntities"] = ExpressionConverter.ConvertO(dataOutflowfilteredEntities);
                dataOutflowpropCount++;
            }

            var connectorObject = new JObject();
            var connectorObjectpropCount = 0;
            connectorObjectpropCount++;
            connectorObject["type"] = ExpressionConverter.ConvertO(dataOutflowconnectortype);
            var typePropertiesObject = new JObject();
            var typePropertiesObjectpropCount = 0;
            if (typePropertiesObjectpropCount > 0)
            {
                connectorObject["typeProperties"] = typePropertiesObject;
                connectorObjectpropCount++;
            }

            var outputObject = new JObject();
            var outputObjectpropCount = 0;
            if (outputObjectpropCount > 0)
            {
                connectorObject["output"] = outputObject;
                connectorObjectpropCount++;
            }

            if (connectorObjectpropCount > 0)
            {
                dataOutflow["connector"] = connectorObject;
                dataOutflowpropCount++;
            }

            var transformerObject = new JObject();
            var transformerObjectpropCount = 0;
            if (dataOutflowtransformertype != null)
            {
                transformerObject["type"] = ExpressionConverter.ConvertO(dataOutflowtransformertype);
                transformerObjectpropCount++;
            }

            var typePropertiesObject = new JObject();
            var typePropertiesObjectpropCount = 0;
            if (typePropertiesObjectpropCount > 0)
            {
                transformerObject["typeProperties"] = typePropertiesObject;
                transformerObjectpropCount++;
            }

            if (transformerObjectpropCount > 0)
            {
                dataOutflow["transformer"] = transformerObject;
                dataOutflowpropCount++;
            }

            if (dataOutflowstate != null)
            {
                dataOutflow["state"] = ExpressionConverter.ConvertO(dataOutflowstate);
                dataOutflowpropCount++;
            }

            if (dataOutflowpropCount > 0)
            {
                callPayload.Body = dataOutflow;
            }

            return new ApiConnectionAction<DataOutflow>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opensupplychainplatf")]
        public IBodyWorkflowAction<DataOutflow[]> DataOutflowGetAllDataOutflows()
        {
            var apiCallPath = "/dataOutflows";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<DataOutflow[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opensupplychainplatf")]
        public IBodyWorkflowAction<DataOutflowRun> DataOutflowPostDataOutflowRun(Expression<Func<string>> name, Expression<Func<string>> dataOutflowRundataOutflowName = null, Expression<Func<string>> dataOutflowRundataOutflowRunId = null, Expression<Func<string>> dataOutflowRunstatus = null, Expression<Func<string>> dataOutflowRuntriggeredAt = null, Expression<Func<string>> dataOutflowRuncompletedAt = null, Expression<Func<string>> dataOutflowRuntriggeredBy = null, Expression<Func<string>> dataOutflowRuntriggerId = null)
        {
            var apiCallPath = String.Format("/dataOutflows/{0}/run", ExpressionConverter.ConvertWithUrlEncoding(name, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var dataOutflowRun = new JObject();
            var dataOutflowRunpropCount = 0;
            if (dataOutflowRundataOutflowName != null)
            {
                dataOutflowRun["dataOutflowName"] = ExpressionConverter.ConvertO(dataOutflowRundataOutflowName);
                dataOutflowRunpropCount++;
            }

            if (dataOutflowRundataOutflowRunId != null)
            {
                dataOutflowRun["dataOutflowRunId"] = ExpressionConverter.ConvertO(dataOutflowRundataOutflowRunId);
                dataOutflowRunpropCount++;
            }

            var runParamsObject = new JObject();
            var runParamsObjectpropCount = 0;
            if (runParamsObjectpropCount > 0)
            {
                dataOutflowRun["runParams"] = runParamsObject;
                dataOutflowRunpropCount++;
            }

            if (dataOutflowRunstatus != null)
            {
                dataOutflowRun["status"] = ExpressionConverter.ConvertO(dataOutflowRunstatus);
                dataOutflowRunpropCount++;
            }

            if (dataOutflowRuntriggeredAt != null)
            {
                dataOutflowRun["triggeredAt"] = ExpressionConverter.ConvertO(dataOutflowRuntriggeredAt);
                dataOutflowRunpropCount++;
            }

            if (dataOutflowRuncompletedAt != null)
            {
                dataOutflowRun["completedAt"] = ExpressionConverter.ConvertO(dataOutflowRuncompletedAt);
                dataOutflowRunpropCount++;
            }

            if (dataOutflowRuntriggeredBy != null)
            {
                dataOutflowRun["triggeredBy"] = ExpressionConverter.ConvertO(dataOutflowRuntriggeredBy);
                dataOutflowRunpropCount++;
            }

            if (dataOutflowRuntriggerId != null)
            {
                dataOutflowRun["triggerId"] = ExpressionConverter.ConvertO(dataOutflowRuntriggerId);
                dataOutflowRunpropCount++;
            }

            if (dataOutflowRunpropCount > 0)
            {
                callPayload.Body = dataOutflowRun;
            }

            return new ApiConnectionAction<DataOutflowRun>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opensupplychainplatf")]
        public IBodyWorkflowAction<DataOutflowRun> DataOutflowRunGetDataOutflowRun(Expression<Func<string>> name, Expression<Func<string>> dataOutflowRunId)
        {
            var apiCallPath = String.Format("/dataOutflows/{0}/dataOutflowRuns/{1}", ExpressionConverter.ConvertWithUrlEncoding(name, 1), ExpressionConverter.ConvertWithUrlEncoding(dataOutflowRunId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<DataOutflowRun>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opensupplychainplatf")]
        public IBodyWorkflowAction<DataOutflowRun[]> DataOutflowRunListDataOutflowRuns(Expression<Func<string>> name)
        {
            var apiCallPath = String.Format("/dataOutflows/{0}/dataOutflowRuns", ExpressionConverter.ConvertWithUrlEncoding(name, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<DataOutflowRun[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opensupplychainplatf")]
        public IBodyWorkflowAction<Dataset[]> DatasetGetAllDatasets()
        {
            var apiCallPath = "/datasets";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<Dataset[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opensupplychainplatf")]
        public IBodyWorkflowAction<Dataset> DatasetGet(Expression<Func<string>> name)
        {
            var apiCallPath = String.Format("/datasets/{0}", ExpressionConverter.ConvertWithUrlEncoding(name, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<Dataset>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opensupplychainplatf")]
        public IBodyWorkflowAction<Dataset> DatasetDelete(Expression<Func<string>> name)
        {
            var apiCallPath = String.Format("/datasets/{0}", ExpressionConverter.ConvertWithUrlEncoding(name, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<Dataset>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opensupplychainplatf")]
        public IBodyWorkflowAction<Dataset> DatasetPut(Expression<Func<string>> datasetname, Expression<Func<bool>> datasetisDisabled, Expression<Func<string>> datasetschemaReferencedataModelId, Expression<Func<string>> name, Expression<Func<DataSchema[]>> datasetdataSchema = null, Expression<Func<string>> datasetoperationalType = null, Expression<Func<string>> datasetschemaReferencedataModelVersion = null, Expression<Func<string>> datasetschemaReferencedataModelType = null, Expression<Func<string[]>> datasetlabels = null)
        {
            var apiCallPath = String.Format("/datasets/{0}", ExpressionConverter.ConvertWithUrlEncoding(name, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var dataset = new JObject();
            var datasetpropCount = 0;
            datasetpropCount++;
            dataset["name"] = ExpressionConverter.ConvertO(datasetname);
            if (datasetdataSchema != null)
            {
                dataset["dataSchema"] = ExpressionConverter.ConvertO(datasetdataSchema);
                datasetpropCount++;
            }

            datasetpropCount++;
            dataset["isDisabled"] = ExpressionConverter.ConvertO(datasetisDisabled);
            if (datasetoperationalType != null)
            {
                dataset["operationalType"] = ExpressionConverter.ConvertO(datasetoperationalType);
                datasetpropCount++;
            }

            var schemaReferenceObject = new JObject();
            var schemaReferenceObjectpropCount = 0;
            schemaReferenceObjectpropCount++;
            schemaReferenceObject["dataModelId"] = ExpressionConverter.ConvertO(datasetschemaReferencedataModelId);
            if (datasetschemaReferencedataModelVersion != null)
            {
                schemaReferenceObject["dataModelVersion"] = ExpressionConverter.ConvertO(datasetschemaReferencedataModelVersion);
                schemaReferenceObjectpropCount++;
            }

            if (datasetschemaReferencedataModelType != null)
            {
                schemaReferenceObject["dataModelType"] = ExpressionConverter.ConvertO(datasetschemaReferencedataModelType);
                schemaReferenceObjectpropCount++;
            }

            if (schemaReferenceObjectpropCount > 0)
            {
                dataset["schemaReference"] = schemaReferenceObject;
                datasetpropCount++;
            }

            if (datasetlabels != null)
            {
                dataset["labels"] = ExpressionConverter.ConvertO(datasetlabels);
                datasetpropCount++;
            }

            if (datasetpropCount > 0)
            {
                callPayload.Body = dataset;
            }

            return new ApiConnectionAction<Dataset>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opensupplychainplatf")]
        public IBodyWorkflowAction<Directory[]> DatasetGetSubDirectoriesOfDataset(Expression<Func<string>> name)
        {
            var apiCallPath = String.Format("/datasets/{0}/list", ExpressionConverter.ConvertWithUrlEncoding(name, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<Directory[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opensupplychainplatf")]
        public IBodyWorkflowAction<DeliveryNode> DeliveryNodeGet(Expression<Func<string>> deliveryNodeId)
        {
            var apiCallPath = String.Format("/deliveryNodes/{0}", ExpressionConverter.ConvertWithUrlEncoding(deliveryNodeId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<DeliveryNode>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opensupplychainplatf")]
        public IBodyWorkflowAction<object> DeliveryNodeDelete(Expression<Func<string>> deliveryNodeId)
        {
            var apiCallPath = String.Format("/deliveryNodes/{0}", ExpressionConverter.ConvertWithUrlEncoding(deliveryNodeId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<object>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opensupplychainplatf")]
        public IBodyWorkflowAction<DeliveryNode> DeliveryNodePut(Expression<Func<string>> deliveryNodeId, Expression<Func<string>> deliveryNodeid, Expression<Func<HoursOfOperation[]>> deliveryNodehoursOfOperations, Expression<Func<string>> deliveryNodelocationaddressLine1, Expression<Func<string>> deliveryNodelocationcityName, Expression<Func<string>> deliveryNodelocationstateName, Expression<Func<string>> deliveryNodelocationcountryName, Expression<Func<string>> deliveryNodelocationpostalCode, Expression<Func<string>> deliveryNodelocationtimeZoneName = null, Expression<Func<string>> deliveryNodelocationaddressLine2 = null, Expression<Func<Note[]>> deliveryNodelocationnotes = null, Expression<Func<string[]>> deliveryNodelabels = null, Expression<Func<string>> deliveryNodelastModifiedTime = null)
        {
            var apiCallPath = String.Format("/deliveryNodes/{0}", ExpressionConverter.ConvertWithUrlEncoding(deliveryNodeId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var deliveryNode = new JObject();
            var deliveryNodepropCount = 0;
            deliveryNodepropCount++;
            deliveryNode["id"] = ExpressionConverter.ConvertO(deliveryNodeid);
            deliveryNodepropCount++;
            deliveryNode["hoursOfOperations"] = ExpressionConverter.ConvertO(deliveryNodehoursOfOperations);
            var locationObject = new JObject();
            var locationObjectpropCount = 0;
            if (deliveryNodelocationtimeZoneName != null)
            {
                locationObject["timeZoneName"] = ExpressionConverter.ConvertO(deliveryNodelocationtimeZoneName);
                locationObjectpropCount++;
            }

            locationObjectpropCount++;
            locationObject["addressLine1"] = ExpressionConverter.ConvertO(deliveryNodelocationaddressLine1);
            if (deliveryNodelocationaddressLine2 != null)
            {
                locationObject["addressLine2"] = ExpressionConverter.ConvertO(deliveryNodelocationaddressLine2);
                locationObjectpropCount++;
            }

            locationObjectpropCount++;
            locationObject["cityName"] = ExpressionConverter.ConvertO(deliveryNodelocationcityName);
            locationObjectpropCount++;
            locationObject["stateName"] = ExpressionConverter.ConvertO(deliveryNodelocationstateName);
            locationObjectpropCount++;
            locationObject["countryName"] = ExpressionConverter.ConvertO(deliveryNodelocationcountryName);
            locationObjectpropCount++;
            locationObject["postalCode"] = ExpressionConverter.ConvertO(deliveryNodelocationpostalCode);
            if (deliveryNodelocationnotes != null)
            {
                locationObject["notes"] = ExpressionConverter.ConvertO(deliveryNodelocationnotes);
                locationObjectpropCount++;
            }

            if (locationObjectpropCount > 0)
            {
                deliveryNode["location"] = locationObject;
                deliveryNodepropCount++;
            }

            if (deliveryNodelabels != null)
            {
                deliveryNode["labels"] = ExpressionConverter.ConvertO(deliveryNodelabels);
                deliveryNodepropCount++;
            }

            if (deliveryNodelastModifiedTime != null)
            {
                deliveryNode["lastModifiedTime"] = ExpressionConverter.ConvertO(deliveryNodelastModifiedTime);
                deliveryNodepropCount++;
            }

            if (deliveryNodepropCount > 0)
            {
                callPayload.Body = deliveryNode;
            }

            return new ApiConnectionAction<DeliveryNode>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opensupplychainplatf")]
        public IBodyWorkflowAction<DeliveryNode[]> DeliveryNodeGetAllDeliveryNodes()
        {
            var apiCallPath = "/deliveryNodes";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<DeliveryNode[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opensupplychainplatf")]
        public IBodyWorkflowAction<BulkResponseItemOfString[]> DeliveryNodeBulkDelete(Expression<Func<string[]>> deliveryNodeIds = null)
        {
            var apiCallPath = "/deliveryNodes";
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(deliveryNodeIds);
            return new ApiConnectionAction<BulkResponseItemOfString[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opensupplychainplatf")]
        public IBodyWorkflowAction<BulkResponseItemOfDeliveryNode[]> DeliveryNodeBulkPut(Expression<Func<DeliveryNode[]>> deliveryNodes = null)
        {
            var apiCallPath = "/deliveryNodes";
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(deliveryNodes);
            return new ApiConnectionAction<BulkResponseItemOfDeliveryNode[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opensupplychainplatf")]
        public IBodyWorkflowAction<GenerateFulfillmentOptionsResponse> FulfillmentOptionGenerateFulfillmentOptions(Expression<Func<OrderLine[]>> requestorderLines, Expression<Func<string>> requestshipmentToLocationaddressLine1, Expression<Func<string>> requestshipmentToLocationcityName, Expression<Func<string>> requestshipmentToLocationstateName, Expression<Func<string>> requestshipmentToLocationcountryName, Expression<Func<string>> requestshipmentToLocationpostalCode, Expression<Func<int>> requestmaxNumOfFulfillmentOptions, Expression<Func<string>> requestshipmentToLocationtimeZoneName = null, Expression<Func<string>> requestshipmentToLocationaddressLine2 = null, Expression<Func<Note[]>> requestshipmentToLocationnotes = null, Expression<Func<Item[]>> requestorderFulfillmentReferenceDataitemReferenceDataitems = null, Expression<Func<AvailableWarehouseItems[]>> requestorderFulfillmentReferenceDatawarehouseItemReferenceDataavailableWarehouseItemsData = null, Expression<Func<Note[]>> requestnotes = null)
        {
            var apiCallPath = "/orderFulfillmentOptions";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            requestpropCount++;
            request["orderLines"] = ExpressionConverter.ConvertO(requestorderLines);
            var shipmentToLocationObject = new JObject();
            var shipmentToLocationObjectpropCount = 0;
            if (requestshipmentToLocationtimeZoneName != null)
            {
                shipmentToLocationObject["timeZoneName"] = ExpressionConverter.ConvertO(requestshipmentToLocationtimeZoneName);
                shipmentToLocationObjectpropCount++;
            }

            shipmentToLocationObjectpropCount++;
            shipmentToLocationObject["addressLine1"] = ExpressionConverter.ConvertO(requestshipmentToLocationaddressLine1);
            if (requestshipmentToLocationaddressLine2 != null)
            {
                shipmentToLocationObject["addressLine2"] = ExpressionConverter.ConvertO(requestshipmentToLocationaddressLine2);
                shipmentToLocationObjectpropCount++;
            }

            shipmentToLocationObjectpropCount++;
            shipmentToLocationObject["cityName"] = ExpressionConverter.ConvertO(requestshipmentToLocationcityName);
            shipmentToLocationObjectpropCount++;
            shipmentToLocationObject["stateName"] = ExpressionConverter.ConvertO(requestshipmentToLocationstateName);
            shipmentToLocationObjectpropCount++;
            shipmentToLocationObject["countryName"] = ExpressionConverter.ConvertO(requestshipmentToLocationcountryName);
            shipmentToLocationObjectpropCount++;
            shipmentToLocationObject["postalCode"] = ExpressionConverter.ConvertO(requestshipmentToLocationpostalCode);
            if (requestshipmentToLocationnotes != null)
            {
                shipmentToLocationObject["notes"] = ExpressionConverter.ConvertO(requestshipmentToLocationnotes);
                shipmentToLocationObjectpropCount++;
            }

            if (shipmentToLocationObjectpropCount > 0)
            {
                request["shipmentToLocation"] = shipmentToLocationObject;
                requestpropCount++;
            }

            requestpropCount++;
            request["maxNumOfFulfillmentOptions"] = ExpressionConverter.ConvertO(requestmaxNumOfFulfillmentOptions);
            var orderFulfillmentReferenceDataObject = new JObject();
            var orderFulfillmentReferenceDataObjectpropCount = 0;
            var itemReferenceDataObject = new JObject();
            var itemReferenceDataObjectpropCount = 0;
            if (requestorderFulfillmentReferenceDataitemReferenceDataitems != null)
            {
                itemReferenceDataObject["items"] = ExpressionConverter.ConvertO(requestorderFulfillmentReferenceDataitemReferenceDataitems);
                itemReferenceDataObjectpropCount++;
            }

            if (itemReferenceDataObjectpropCount > 0)
            {
                orderFulfillmentReferenceDataObject["itemReferenceData"] = itemReferenceDataObject;
                orderFulfillmentReferenceDataObjectpropCount++;
            }

            var warehouseItemReferenceDataObject = new JObject();
            var warehouseItemReferenceDataObjectpropCount = 0;
            if (requestorderFulfillmentReferenceDatawarehouseItemReferenceDataavailableWarehouseItemsData != null)
            {
                warehouseItemReferenceDataObject["availableWarehouseItemsData"] = ExpressionConverter.ConvertO(requestorderFulfillmentReferenceDatawarehouseItemReferenceDataavailableWarehouseItemsData);
                warehouseItemReferenceDataObjectpropCount++;
            }

            if (warehouseItemReferenceDataObjectpropCount > 0)
            {
                orderFulfillmentReferenceDataObject["warehouseItemReferenceData"] = warehouseItemReferenceDataObject;
                orderFulfillmentReferenceDataObjectpropCount++;
            }

            if (orderFulfillmentReferenceDataObjectpropCount > 0)
            {
                request["orderFulfillmentReferenceData"] = orderFulfillmentReferenceDataObject;
                requestpropCount++;
            }

            if (requestnotes != null)
            {
                request["notes"] = ExpressionConverter.ConvertO(requestnotes);
                requestpropCount++;
            }

            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionAction<GenerateFulfillmentOptionsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opensupplychainplatf")]
        public IBodyWorkflowAction<FulfillmentPlan> FulfillmentPlanGetPlan(Expression<Func<string>> fulfillmentPlanId)
        {
            var apiCallPath = String.Format("/fulfillmentPlans/{0}", ExpressionConverter.ConvertWithUrlEncoding(fulfillmentPlanId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<FulfillmentPlan>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opensupplychainplatf")]
        public IBodyWorkflowAction<FulfillmentPlan[]> FulfillmentPlanGetPlans(Expression<Func<string>> warehouseId = null, Expression<Func<string>> status = null)
        {
            var apiCallPath = "/fulfillmentPlans";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (warehouseId != null)
                callPayload.Queries["warehouseId"] = ExpressionConverter.Convert(warehouseId);
            if (status != null)
                callPayload.Queries["status"] = ExpressionConverter.Convert(status);
            return new ApiConnectionAction<FulfillmentPlan[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opensupplychainplatf")]
        public IBodyWorkflowAction<Item> ItemGet(Expression<Func<string>> sku)
        {
            var apiCallPath = String.Format("/items/{0}", ExpressionConverter.ConvertWithUrlEncoding(sku, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<Item>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opensupplychainplatf")]
        public IBodyWorkflowAction<object> ItemDelete(Expression<Func<string>> sku)
        {
            var apiCallPath = String.Format("/items/{0}", ExpressionConverter.ConvertWithUrlEncoding(sku, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<object>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opensupplychainplatf")]
        public IBodyWorkflowAction<Item> ItemPut(Expression<Func<string>> sku, Expression<Func<double>> itemweight, Expression<Func<double>> itemlength, Expression<Func<double>> itemwidth, Expression<Func<double>> itemdepth, Expression<Func<string>> itemlwhUnitOfMeasureabbreviation, Expression<Func<string>> itemweightUnitOfMeasureabbreviation, Expression<Func<string>> itemsku, Expression<Func<string>> itemname = null, Expression<Func<string>> itemdescription = null, Expression<Func<Barcode[]>> itembarcodes = null, Expression<Func<string>> itemlastModifiedTime = null, Expression<Func<string[]>> itemlabels = null)
        {
            var apiCallPath = String.Format("/items/{0}", ExpressionConverter.ConvertWithUrlEncoding(sku, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var item = new JObject();
            var itempropCount = 0;
            if (itemname != null)
            {
                item["name"] = ExpressionConverter.ConvertO(itemname);
                itempropCount++;
            }

            if (itemdescription != null)
            {
                item["description"] = ExpressionConverter.ConvertO(itemdescription);
                itempropCount++;
            }

            if (itembarcodes != null)
            {
                item["barcodes"] = ExpressionConverter.ConvertO(itembarcodes);
                itempropCount++;
            }

            itempropCount++;
            item["weight"] = ExpressionConverter.ConvertO(itemweight);
            itempropCount++;
            item["length"] = ExpressionConverter.ConvertO(itemlength);
            itempropCount++;
            item["width"] = ExpressionConverter.ConvertO(itemwidth);
            itempropCount++;
            item["depth"] = ExpressionConverter.ConvertO(itemdepth);
            var lwhUnitOfMeasureObject = new JObject();
            var lwhUnitOfMeasureObjectpropCount = 0;
            lwhUnitOfMeasureObjectpropCount++;
            lwhUnitOfMeasureObject["abbreviation"] = ExpressionConverter.ConvertO(itemlwhUnitOfMeasureabbreviation);
            if (lwhUnitOfMeasureObjectpropCount > 0)
            {
                item["lwhUnitOfMeasure"] = lwhUnitOfMeasureObject;
                itempropCount++;
            }

            var weightUnitOfMeasureObject = new JObject();
            var weightUnitOfMeasureObjectpropCount = 0;
            weightUnitOfMeasureObjectpropCount++;
            weightUnitOfMeasureObject["abbreviation"] = ExpressionConverter.ConvertO(itemweightUnitOfMeasureabbreviation);
            if (weightUnitOfMeasureObjectpropCount > 0)
            {
                item["weightUnitOfMeasure"] = weightUnitOfMeasureObject;
                itempropCount++;
            }

            if (itemlastModifiedTime != null)
            {
                item["lastModifiedTime"] = ExpressionConverter.ConvertO(itemlastModifiedTime);
                itempropCount++;
            }

            itempropCount++;
            item["sku"] = ExpressionConverter.ConvertO(itemsku);
            if (itemlabels != null)
            {
                item["labels"] = ExpressionConverter.ConvertO(itemlabels);
                itempropCount++;
            }

            if (itempropCount > 0)
            {
                callPayload.Body = item;
            }

            return new ApiConnectionAction<Item>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opensupplychainplatf")]
        public IBodyWorkflowAction<BulkResponseItemOfString[]> ItemBulkDelete(Expression<Func<string[]>> skus = null)
        {
            var apiCallPath = "/items";
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(skus);
            return new ApiConnectionAction<BulkResponseItemOfString[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opensupplychainplatf")]
        public IBodyWorkflowAction<BulkResponseItemOfItem[]> ItemBulkPut(Expression<Func<Item[]>> items = null)
        {
            var apiCallPath = "/items";
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(items);
            return new ApiConnectionAction<BulkResponseItemOfItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opensupplychainplatf")]
        public IBodyWorkflowAction<OrderFulfillment> OrderFulfillmentGetOrderFulfillment(Expression<Func<string>> orderFulfillmentId)
        {
            var apiCallPath = String.Format("/orderFulfillments/{0}", ExpressionConverter.ConvertWithUrlEncoding(orderFulfillmentId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<OrderFulfillment>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opensupplychainplatf")]
        public IBodyWorkflowAction<Shipment> ShipmentGet(Expression<Func<string>> shipmentId)
        {
            var apiCallPath = String.Format("/shipments/{0}", ExpressionConverter.ConvertWithUrlEncoding(shipmentId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<Shipment>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opensupplychainplatf")]
        public IBodyWorkflowAction<Shipment> ShipmentPut(Expression<Func<string>> shipmentId, Expression<Func<string>> shipmentid, Expression<Func<ShipmentLocation[]>> shipmentshipmentLocationData, Expression<Func<double>> shipmentshipmentPackingDatashipmentVolume, Expression<Func<double>> shipmentshipmentPackingDatashipmentNetWeight, Expression<Func<double>> shipmentshipmentPackingDatashipmentLength, Expression<Func<double>> shipmentshipmentPackingDatashipmentWidth, Expression<Func<double>> shipmentshipmentPackingDatashipmentHeight, Expression<Func<double>> shipmentshipmentChargeestimatedCost, Expression<Func<string>> shipmentshipmentChargecurrencyCode, Expression<Func<bool>> shipmentshipmentContentDataisFragile, Expression<Func<bool>> shipmentshipmentContentDataincludesBattery, Expression<Func<string>> shipmentstatus = null, Expression<Func<string[]>> shipmentshipmentOrderIds = null, Expression<Func<string>> shipmentshipmentPackingDatavolumeUnitOfMeasure = null, Expression<Func<string>> shipmentshipmentPackingDataweightUnitOfMeasure = null, Expression<Func<string>> shipmentshipmentPackingDatalwhUnitOfMeasure = null, Expression<Func<string>> shipmentshipmentPackingDatashipmentPackingType = null, Expression<Func<string>> shipmentshipmentChargebillingDatacustomerId = null, Expression<Func<string>> shipmentshipmentChargebillingDatacustomerName = null, Expression<Func<ComponentCharge[]>> shipmentshipmentChargecomponentCharges = null, Expression<Func<string>> shipmentshipmentReferenceDatatrackingNumber = null, Expression<Func<string>> shipmentshipmentReferenceDatatrackingUrl = null, Expression<Func<string>> shipmentshipmentReferenceDatashipLabelUrl = null, Expression<Func<ShipmentItem[]>> shipmentshipmentItems = null, Expression<Func<string>> shipmentestimatedPickupTime = null, Expression<Func<string>> shipmentestimatedEarliestPickupTime = null, Expression<Func<string>> shipmentestimatedLatestPickupTime = null, Expression<Func<string>> shipmentestimatedDeliveryTime = null, Expression<Func<string>> shipmentestimatedEarliestDeliveryTime = null, Expression<Func<string>> shipmentestimatedLatestDeliveryTime = null, Expression<Func<string>> shipmentlastModifiedTime = null, Expression<Func<string>> shipmentcarrierName = null)
        {
            var apiCallPath = String.Format("/shipments/{0}", ExpressionConverter.ConvertWithUrlEncoding(shipmentId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var shipment = new JObject();
            var shipmentpropCount = 0;
            shipmentpropCount++;
            shipment["id"] = ExpressionConverter.ConvertO(shipmentid);
            if (shipmentstatus != null)
            {
                shipment["status"] = ExpressionConverter.ConvertO(shipmentstatus);
                shipmentpropCount++;
            }

            if (shipmentshipmentOrderIds != null)
            {
                shipment["shipmentOrderIds"] = ExpressionConverter.ConvertO(shipmentshipmentOrderIds);
                shipmentpropCount++;
            }

            shipmentpropCount++;
            shipment["shipmentLocationData"] = ExpressionConverter.ConvertO(shipmentshipmentLocationData);
            var shipmentPackingDataObject = new JObject();
            var shipmentPackingDataObjectpropCount = 0;
            shipmentPackingDataObjectpropCount++;
            shipmentPackingDataObject["shipmentVolume"] = ExpressionConverter.ConvertO(shipmentshipmentPackingDatashipmentVolume);
            shipmentPackingDataObjectpropCount++;
            shipmentPackingDataObject["shipmentNetWeight"] = ExpressionConverter.ConvertO(shipmentshipmentPackingDatashipmentNetWeight);
            if (shipmentshipmentPackingDatavolumeUnitOfMeasure != null)
            {
                shipmentPackingDataObject["volumeUnitOfMeasure"] = ExpressionConverter.ConvertO(shipmentshipmentPackingDatavolumeUnitOfMeasure);
                shipmentPackingDataObjectpropCount++;
            }

            if (shipmentshipmentPackingDataweightUnitOfMeasure != null)
            {
                shipmentPackingDataObject["weightUnitOfMeasure"] = ExpressionConverter.ConvertO(shipmentshipmentPackingDataweightUnitOfMeasure);
                shipmentPackingDataObjectpropCount++;
            }

            shipmentPackingDataObjectpropCount++;
            shipmentPackingDataObject["shipmentLength"] = ExpressionConverter.ConvertO(shipmentshipmentPackingDatashipmentLength);
            shipmentPackingDataObjectpropCount++;
            shipmentPackingDataObject["shipmentWidth"] = ExpressionConverter.ConvertO(shipmentshipmentPackingDatashipmentWidth);
            shipmentPackingDataObjectpropCount++;
            shipmentPackingDataObject["shipmentHeight"] = ExpressionConverter.ConvertO(shipmentshipmentPackingDatashipmentHeight);
            if (shipmentshipmentPackingDatalwhUnitOfMeasure != null)
            {
                shipmentPackingDataObject["lwhUnitOfMeasure"] = ExpressionConverter.ConvertO(shipmentshipmentPackingDatalwhUnitOfMeasure);
                shipmentPackingDataObjectpropCount++;
            }

            if (shipmentshipmentPackingDatashipmentPackingType != null)
            {
                shipmentPackingDataObject["shipmentPackingType"] = ExpressionConverter.ConvertO(shipmentshipmentPackingDatashipmentPackingType);
                shipmentPackingDataObjectpropCount++;
            }

            if (shipmentPackingDataObjectpropCount > 0)
            {
                shipment["shipmentPackingData"] = shipmentPackingDataObject;
                shipmentpropCount++;
            }

            var shipmentChargeObject = new JObject();
            var shipmentChargeObjectpropCount = 0;
            shipmentChargeObjectpropCount++;
            shipmentChargeObject["estimatedCost"] = ExpressionConverter.ConvertO(shipmentshipmentChargeestimatedCost);
            shipmentChargeObjectpropCount++;
            shipmentChargeObject["currencyCode"] = ExpressionConverter.ConvertO(shipmentshipmentChargecurrencyCode);
            var billingDataObject = new JObject();
            var billingDataObjectpropCount = 0;
            if (shipmentshipmentChargebillingDatacustomerId != null)
            {
                billingDataObject["customerId"] = ExpressionConverter.ConvertO(shipmentshipmentChargebillingDatacustomerId);
                billingDataObjectpropCount++;
            }

            if (shipmentshipmentChargebillingDatacustomerName != null)
            {
                billingDataObject["customerName"] = ExpressionConverter.ConvertO(shipmentshipmentChargebillingDatacustomerName);
                billingDataObjectpropCount++;
            }

            var customAttributesObject = new JObject();
            var customAttributesObjectpropCount = 0;
            if (customAttributesObjectpropCount > 0)
            {
                billingDataObject["customAttributes"] = customAttributesObject;
                billingDataObjectpropCount++;
            }

            if (billingDataObjectpropCount > 0)
            {
                shipmentChargeObject["billingData"] = billingDataObject;
                shipmentChargeObjectpropCount++;
            }

            if (shipmentshipmentChargecomponentCharges != null)
            {
                shipmentChargeObject["componentCharges"] = ExpressionConverter.ConvertO(shipmentshipmentChargecomponentCharges);
                shipmentChargeObjectpropCount++;
            }

            if (shipmentChargeObjectpropCount > 0)
            {
                shipment["shipmentCharge"] = shipmentChargeObject;
                shipmentpropCount++;
            }

            var shipmentReferenceDataObject = new JObject();
            var shipmentReferenceDataObjectpropCount = 0;
            if (shipmentshipmentReferenceDatatrackingNumber != null)
            {
                shipmentReferenceDataObject["trackingNumber"] = ExpressionConverter.ConvertO(shipmentshipmentReferenceDatatrackingNumber);
                shipmentReferenceDataObjectpropCount++;
            }

            if (shipmentshipmentReferenceDatatrackingUrl != null)
            {
                shipmentReferenceDataObject["trackingUrl"] = ExpressionConverter.ConvertO(shipmentshipmentReferenceDatatrackingUrl);
                shipmentReferenceDataObjectpropCount++;
            }

            if (shipmentshipmentReferenceDatashipLabelUrl != null)
            {
                shipmentReferenceDataObject["shipLabelUrl"] = ExpressionConverter.ConvertO(shipmentshipmentReferenceDatashipLabelUrl);
                shipmentReferenceDataObjectpropCount++;
            }

            if (shipmentReferenceDataObjectpropCount > 0)
            {
                shipment["shipmentReferenceData"] = shipmentReferenceDataObject;
                shipmentpropCount++;
            }

            if (shipmentshipmentItems != null)
            {
                shipment["shipmentItems"] = ExpressionConverter.ConvertO(shipmentshipmentItems);
                shipmentpropCount++;
            }

            if (shipmentestimatedPickupTime != null)
            {
                shipment["estimatedPickupTime"] = ExpressionConverter.ConvertO(shipmentestimatedPickupTime);
                shipmentpropCount++;
            }

            if (shipmentestimatedEarliestPickupTime != null)
            {
                shipment["estimatedEarliestPickupTime"] = ExpressionConverter.ConvertO(shipmentestimatedEarliestPickupTime);
                shipmentpropCount++;
            }

            if (shipmentestimatedLatestPickupTime != null)
            {
                shipment["estimatedLatestPickupTime"] = ExpressionConverter.ConvertO(shipmentestimatedLatestPickupTime);
                shipmentpropCount++;
            }

            if (shipmentestimatedDeliveryTime != null)
            {
                shipment["estimatedDeliveryTime"] = ExpressionConverter.ConvertO(shipmentestimatedDeliveryTime);
                shipmentpropCount++;
            }

            if (shipmentestimatedEarliestDeliveryTime != null)
            {
                shipment["estimatedEarliestDeliveryTime"] = ExpressionConverter.ConvertO(shipmentestimatedEarliestDeliveryTime);
                shipmentpropCount++;
            }

            if (shipmentestimatedLatestDeliveryTime != null)
            {
                shipment["estimatedLatestDeliveryTime"] = ExpressionConverter.ConvertO(shipmentestimatedLatestDeliveryTime);
                shipmentpropCount++;
            }

            var shipmentContentDataObject = new JObject();
            var shipmentContentDataObjectpropCount = 0;
            shipmentContentDataObjectpropCount++;
            shipmentContentDataObject["isFragile"] = ExpressionConverter.ConvertO(shipmentshipmentContentDataisFragile);
            shipmentContentDataObjectpropCount++;
            shipmentContentDataObject["includesBattery"] = ExpressionConverter.ConvertO(shipmentshipmentContentDataincludesBattery);
            if (shipmentContentDataObjectpropCount > 0)
            {
                shipment["shipmentContentData"] = shipmentContentDataObject;
                shipmentpropCount++;
            }

            if (shipmentlastModifiedTime != null)
            {
                shipment["lastModifiedTime"] = ExpressionConverter.ConvertO(shipmentlastModifiedTime);
                shipmentpropCount++;
            }

            var deliveryInstructionsObject = new JObject();
            var deliveryInstructionsObjectpropCount = 0;
            if (deliveryInstructionsObjectpropCount > 0)
            {
                shipment["deliveryInstructions"] = deliveryInstructionsObject;
                shipmentpropCount++;
            }

            var customAttributesObject = new JObject();
            var customAttributesObjectpropCount = 0;
            if (customAttributesObjectpropCount > 0)
            {
                shipment["customAttributes"] = customAttributesObject;
                shipmentpropCount++;
            }

            if (shipmentcarrierName != null)
            {
                shipment["carrierName"] = ExpressionConverter.ConvertO(shipmentcarrierName);
                shipmentpropCount++;
            }

            if (shipmentpropCount > 0)
            {
                callPayload.Body = shipment;
            }

            return new ApiConnectionAction<Shipment>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opensupplychainplatf")]
        public IBodyWorkflowAction<Shipment> ShipmentUpdateShipment(Expression<Func<string>> shipmentId, Expression<Func<string>> shipmentid, Expression<Func<ShipmentLocation[]>> shipmentshipmentLocationData, Expression<Func<double>> shipmentshipmentPackingDatashipmentVolume, Expression<Func<double>> shipmentshipmentPackingDatashipmentNetWeight, Expression<Func<double>> shipmentshipmentPackingDatashipmentLength, Expression<Func<double>> shipmentshipmentPackingDatashipmentWidth, Expression<Func<double>> shipmentshipmentPackingDatashipmentHeight, Expression<Func<double>> shipmentshipmentChargeestimatedCost, Expression<Func<string>> shipmentshipmentChargecurrencyCode, Expression<Func<bool>> shipmentshipmentContentDataisFragile, Expression<Func<bool>> shipmentshipmentContentDataincludesBattery, Expression<Func<string>> shipmentstatus = null, Expression<Func<string[]>> shipmentshipmentOrderIds = null, Expression<Func<string>> shipmentshipmentPackingDatavolumeUnitOfMeasure = null, Expression<Func<string>> shipmentshipmentPackingDataweightUnitOfMeasure = null, Expression<Func<string>> shipmentshipmentPackingDatalwhUnitOfMeasure = null, Expression<Func<string>> shipmentshipmentPackingDatashipmentPackingType = null, Expression<Func<string>> shipmentshipmentChargebillingDatacustomerId = null, Expression<Func<string>> shipmentshipmentChargebillingDatacustomerName = null, Expression<Func<ComponentCharge[]>> shipmentshipmentChargecomponentCharges = null, Expression<Func<string>> shipmentshipmentReferenceDatatrackingNumber = null, Expression<Func<string>> shipmentshipmentReferenceDatatrackingUrl = null, Expression<Func<string>> shipmentshipmentReferenceDatashipLabelUrl = null, Expression<Func<ShipmentItem[]>> shipmentshipmentItems = null, Expression<Func<string>> shipmentestimatedPickupTime = null, Expression<Func<string>> shipmentestimatedEarliestPickupTime = null, Expression<Func<string>> shipmentestimatedLatestPickupTime = null, Expression<Func<string>> shipmentestimatedDeliveryTime = null, Expression<Func<string>> shipmentestimatedEarliestDeliveryTime = null, Expression<Func<string>> shipmentestimatedLatestDeliveryTime = null, Expression<Func<string>> shipmentlastModifiedTime = null, Expression<Func<string>> shipmentcarrierName = null)
        {
            var apiCallPath = String.Format("/shipments/{0}", ExpressionConverter.ConvertWithUrlEncoding(shipmentId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var shipment = new JObject();
            var shipmentpropCount = 0;
            shipmentpropCount++;
            shipment["id"] = ExpressionConverter.ConvertO(shipmentid);
            if (shipmentstatus != null)
            {
                shipment["status"] = ExpressionConverter.ConvertO(shipmentstatus);
                shipmentpropCount++;
            }

            if (shipmentshipmentOrderIds != null)
            {
                shipment["shipmentOrderIds"] = ExpressionConverter.ConvertO(shipmentshipmentOrderIds);
                shipmentpropCount++;
            }

            shipmentpropCount++;
            shipment["shipmentLocationData"] = ExpressionConverter.ConvertO(shipmentshipmentLocationData);
            var shipmentPackingDataObject = new JObject();
            var shipmentPackingDataObjectpropCount = 0;
            shipmentPackingDataObjectpropCount++;
            shipmentPackingDataObject["shipmentVolume"] = ExpressionConverter.ConvertO(shipmentshipmentPackingDatashipmentVolume);
            shipmentPackingDataObjectpropCount++;
            shipmentPackingDataObject["shipmentNetWeight"] = ExpressionConverter.ConvertO(shipmentshipmentPackingDatashipmentNetWeight);
            if (shipmentshipmentPackingDatavolumeUnitOfMeasure != null)
            {
                shipmentPackingDataObject["volumeUnitOfMeasure"] = ExpressionConverter.ConvertO(shipmentshipmentPackingDatavolumeUnitOfMeasure);
                shipmentPackingDataObjectpropCount++;
            }

            if (shipmentshipmentPackingDataweightUnitOfMeasure != null)
            {
                shipmentPackingDataObject["weightUnitOfMeasure"] = ExpressionConverter.ConvertO(shipmentshipmentPackingDataweightUnitOfMeasure);
                shipmentPackingDataObjectpropCount++;
            }

            shipmentPackingDataObjectpropCount++;
            shipmentPackingDataObject["shipmentLength"] = ExpressionConverter.ConvertO(shipmentshipmentPackingDatashipmentLength);
            shipmentPackingDataObjectpropCount++;
            shipmentPackingDataObject["shipmentWidth"] = ExpressionConverter.ConvertO(shipmentshipmentPackingDatashipmentWidth);
            shipmentPackingDataObjectpropCount++;
            shipmentPackingDataObject["shipmentHeight"] = ExpressionConverter.ConvertO(shipmentshipmentPackingDatashipmentHeight);
            if (shipmentshipmentPackingDatalwhUnitOfMeasure != null)
            {
                shipmentPackingDataObject["lwhUnitOfMeasure"] = ExpressionConverter.ConvertO(shipmentshipmentPackingDatalwhUnitOfMeasure);
                shipmentPackingDataObjectpropCount++;
            }

            if (shipmentshipmentPackingDatashipmentPackingType != null)
            {
                shipmentPackingDataObject["shipmentPackingType"] = ExpressionConverter.ConvertO(shipmentshipmentPackingDatashipmentPackingType);
                shipmentPackingDataObjectpropCount++;
            }

            if (shipmentPackingDataObjectpropCount > 0)
            {
                shipment["shipmentPackingData"] = shipmentPackingDataObject;
                shipmentpropCount++;
            }

            var shipmentChargeObject = new JObject();
            var shipmentChargeObjectpropCount = 0;
            shipmentChargeObjectpropCount++;
            shipmentChargeObject["estimatedCost"] = ExpressionConverter.ConvertO(shipmentshipmentChargeestimatedCost);
            shipmentChargeObjectpropCount++;
            shipmentChargeObject["currencyCode"] = ExpressionConverter.ConvertO(shipmentshipmentChargecurrencyCode);
            var billingDataObject = new JObject();
            var billingDataObjectpropCount = 0;
            if (shipmentshipmentChargebillingDatacustomerId != null)
            {
                billingDataObject["customerId"] = ExpressionConverter.ConvertO(shipmentshipmentChargebillingDatacustomerId);
                billingDataObjectpropCount++;
            }

            if (shipmentshipmentChargebillingDatacustomerName != null)
            {
                billingDataObject["customerName"] = ExpressionConverter.ConvertO(shipmentshipmentChargebillingDatacustomerName);
                billingDataObjectpropCount++;
            }

            var customAttributesObject = new JObject();
            var customAttributesObjectpropCount = 0;
            if (customAttributesObjectpropCount > 0)
            {
                billingDataObject["customAttributes"] = customAttributesObject;
                billingDataObjectpropCount++;
            }

            if (billingDataObjectpropCount > 0)
            {
                shipmentChargeObject["billingData"] = billingDataObject;
                shipmentChargeObjectpropCount++;
            }

            if (shipmentshipmentChargecomponentCharges != null)
            {
                shipmentChargeObject["componentCharges"] = ExpressionConverter.ConvertO(shipmentshipmentChargecomponentCharges);
                shipmentChargeObjectpropCount++;
            }

            if (shipmentChargeObjectpropCount > 0)
            {
                shipment["shipmentCharge"] = shipmentChargeObject;
                shipmentpropCount++;
            }

            var shipmentReferenceDataObject = new JObject();
            var shipmentReferenceDataObjectpropCount = 0;
            if (shipmentshipmentReferenceDatatrackingNumber != null)
            {
                shipmentReferenceDataObject["trackingNumber"] = ExpressionConverter.ConvertO(shipmentshipmentReferenceDatatrackingNumber);
                shipmentReferenceDataObjectpropCount++;
            }

            if (shipmentshipmentReferenceDatatrackingUrl != null)
            {
                shipmentReferenceDataObject["trackingUrl"] = ExpressionConverter.ConvertO(shipmentshipmentReferenceDatatrackingUrl);
                shipmentReferenceDataObjectpropCount++;
            }

            if (shipmentshipmentReferenceDatashipLabelUrl != null)
            {
                shipmentReferenceDataObject["shipLabelUrl"] = ExpressionConverter.ConvertO(shipmentshipmentReferenceDatashipLabelUrl);
                shipmentReferenceDataObjectpropCount++;
            }

            if (shipmentReferenceDataObjectpropCount > 0)
            {
                shipment["shipmentReferenceData"] = shipmentReferenceDataObject;
                shipmentpropCount++;
            }

            if (shipmentshipmentItems != null)
            {
                shipment["shipmentItems"] = ExpressionConverter.ConvertO(shipmentshipmentItems);
                shipmentpropCount++;
            }

            if (shipmentestimatedPickupTime != null)
            {
                shipment["estimatedPickupTime"] = ExpressionConverter.ConvertO(shipmentestimatedPickupTime);
                shipmentpropCount++;
            }

            if (shipmentestimatedEarliestPickupTime != null)
            {
                shipment["estimatedEarliestPickupTime"] = ExpressionConverter.ConvertO(shipmentestimatedEarliestPickupTime);
                shipmentpropCount++;
            }

            if (shipmentestimatedLatestPickupTime != null)
            {
                shipment["estimatedLatestPickupTime"] = ExpressionConverter.ConvertO(shipmentestimatedLatestPickupTime);
                shipmentpropCount++;
            }

            if (shipmentestimatedDeliveryTime != null)
            {
                shipment["estimatedDeliveryTime"] = ExpressionConverter.ConvertO(shipmentestimatedDeliveryTime);
                shipmentpropCount++;
            }

            if (shipmentestimatedEarliestDeliveryTime != null)
            {
                shipment["estimatedEarliestDeliveryTime"] = ExpressionConverter.ConvertO(shipmentestimatedEarliestDeliveryTime);
                shipmentpropCount++;
            }

            if (shipmentestimatedLatestDeliveryTime != null)
            {
                shipment["estimatedLatestDeliveryTime"] = ExpressionConverter.ConvertO(shipmentestimatedLatestDeliveryTime);
                shipmentpropCount++;
            }

            var shipmentContentDataObject = new JObject();
            var shipmentContentDataObjectpropCount = 0;
            shipmentContentDataObjectpropCount++;
            shipmentContentDataObject["isFragile"] = ExpressionConverter.ConvertO(shipmentshipmentContentDataisFragile);
            shipmentContentDataObjectpropCount++;
            shipmentContentDataObject["includesBattery"] = ExpressionConverter.ConvertO(shipmentshipmentContentDataincludesBattery);
            if (shipmentContentDataObjectpropCount > 0)
            {
                shipment["shipmentContentData"] = shipmentContentDataObject;
                shipmentpropCount++;
            }

            if (shipmentlastModifiedTime != null)
            {
                shipment["lastModifiedTime"] = ExpressionConverter.ConvertO(shipmentlastModifiedTime);
                shipmentpropCount++;
            }

            var deliveryInstructionsObject = new JObject();
            var deliveryInstructionsObjectpropCount = 0;
            if (deliveryInstructionsObjectpropCount > 0)
            {
                shipment["deliveryInstructions"] = deliveryInstructionsObject;
                shipmentpropCount++;
            }

            var customAttributesObject = new JObject();
            var customAttributesObjectpropCount = 0;
            if (customAttributesObjectpropCount > 0)
            {
                shipment["customAttributes"] = customAttributesObject;
                shipmentpropCount++;
            }

            if (shipmentcarrierName != null)
            {
                shipment["carrierName"] = ExpressionConverter.ConvertO(shipmentcarrierName);
                shipmentpropCount++;
            }

            if (shipmentpropCount > 0)
            {
                callPayload.Body = shipment;
            }

            return new ApiConnectionAction<Shipment>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opensupplychainplatf")]
        public IBodyWorkflowAction<ShipmentOrder> ShipmentOrderGet(Expression<Func<string>> shipmentOrderId)
        {
            var apiCallPath = String.Format("/shipmentOrders/{0}", ExpressionConverter.ConvertWithUrlEncoding(shipmentOrderId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ShipmentOrder>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opensupplychainplatf")]
        public IBodyWorkflowAction<ShipmentOrder> ShipmentOrderPut(Expression<Func<string>> shipmentOrderId, Expression<Func<string>> shipmentOrderid, Expression<Func<ShipmentItem[]>> shipmentOrdershipmentItems, Expression<Func<ShipmentLocation[]>> shipmentOrdershipmentLocationData, Expression<Func<double>> shipmentOrdershipmentPackingDatashipmentVolume, Expression<Func<double>> shipmentOrdershipmentPackingDatashipmentNetWeight, Expression<Func<double>> shipmentOrdershipmentPackingDatashipmentLength, Expression<Func<double>> shipmentOrdershipmentPackingDatashipmentWidth, Expression<Func<double>> shipmentOrdershipmentPackingDatashipmentHeight, Expression<Func<double>> shipmentOrdershipmentChargeestimatedCost, Expression<Func<string>> shipmentOrdershipmentChargecurrencyCode, Expression<Func<bool>> shipmentOrdershipmentContentDataisFragile, Expression<Func<bool>> shipmentOrdershipmentContentDataincludesBattery, Expression<Func<string>> shipmentOrdershipmentId = null, Expression<Func<string>> shipmentOrderstatus = null, Expression<Func<string>> shipmentOrdershipmentPackingDatavolumeUnitOfMeasure = null, Expression<Func<string>> shipmentOrdershipmentPackingDataweightUnitOfMeasure = null, Expression<Func<string>> shipmentOrdershipmentPackingDatalwhUnitOfMeasure = null, Expression<Func<string>> shipmentOrdershipmentPackingDatashipmentPackingType = null, Expression<Func<string>> shipmentOrdershipmentChargebillingDatacustomerId = null, Expression<Func<string>> shipmentOrdershipmentChargebillingDatacustomerName = null, Expression<Func<ComponentCharge[]>> shipmentOrdershipmentChargecomponentCharges = null, Expression<Func<string>> shipmentOrderplannedPickupTime = null, Expression<Func<string>> shipmentOrderplannedEarliestPickupTime = null, Expression<Func<string>> shipmentOrderplannedLatestPickupTime = null, Expression<Func<string>> shipmentOrderplannedDeliveryTime = null, Expression<Func<string>> shipmentOrderplannedEarliestDeliveryTime = null, Expression<Func<string>> shipmentOrderplannedLatestDeliveryTime = null, Expression<Func<string>> shipmentOrderlastModifiedTime = null)
        {
            var apiCallPath = String.Format("/shipmentOrders/{0}", ExpressionConverter.ConvertWithUrlEncoding(shipmentOrderId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var shipmentOrder = new JObject();
            var shipmentOrderpropCount = 0;
            shipmentOrderpropCount++;
            shipmentOrder["id"] = ExpressionConverter.ConvertO(shipmentOrderid);
            if (shipmentOrdershipmentId != null)
            {
                shipmentOrder["shipmentId"] = ExpressionConverter.ConvertO(shipmentOrdershipmentId);
                shipmentOrderpropCount++;
            }

            if (shipmentOrderstatus != null)
            {
                shipmentOrder["status"] = ExpressionConverter.ConvertO(shipmentOrderstatus);
                shipmentOrderpropCount++;
            }

            shipmentOrderpropCount++;
            shipmentOrder["shipmentItems"] = ExpressionConverter.ConvertO(shipmentOrdershipmentItems);
            shipmentOrderpropCount++;
            shipmentOrder["shipmentLocationData"] = ExpressionConverter.ConvertO(shipmentOrdershipmentLocationData);
            var shipmentPackingDataObject = new JObject();
            var shipmentPackingDataObjectpropCount = 0;
            shipmentPackingDataObjectpropCount++;
            shipmentPackingDataObject["shipmentVolume"] = ExpressionConverter.ConvertO(shipmentOrdershipmentPackingDatashipmentVolume);
            shipmentPackingDataObjectpropCount++;
            shipmentPackingDataObject["shipmentNetWeight"] = ExpressionConverter.ConvertO(shipmentOrdershipmentPackingDatashipmentNetWeight);
            if (shipmentOrdershipmentPackingDatavolumeUnitOfMeasure != null)
            {
                shipmentPackingDataObject["volumeUnitOfMeasure"] = ExpressionConverter.ConvertO(shipmentOrdershipmentPackingDatavolumeUnitOfMeasure);
                shipmentPackingDataObjectpropCount++;
            }

            if (shipmentOrdershipmentPackingDataweightUnitOfMeasure != null)
            {
                shipmentPackingDataObject["weightUnitOfMeasure"] = ExpressionConverter.ConvertO(shipmentOrdershipmentPackingDataweightUnitOfMeasure);
                shipmentPackingDataObjectpropCount++;
            }

            shipmentPackingDataObjectpropCount++;
            shipmentPackingDataObject["shipmentLength"] = ExpressionConverter.ConvertO(shipmentOrdershipmentPackingDatashipmentLength);
            shipmentPackingDataObjectpropCount++;
            shipmentPackingDataObject["shipmentWidth"] = ExpressionConverter.ConvertO(shipmentOrdershipmentPackingDatashipmentWidth);
            shipmentPackingDataObjectpropCount++;
            shipmentPackingDataObject["shipmentHeight"] = ExpressionConverter.ConvertO(shipmentOrdershipmentPackingDatashipmentHeight);
            if (shipmentOrdershipmentPackingDatalwhUnitOfMeasure != null)
            {
                shipmentPackingDataObject["lwhUnitOfMeasure"] = ExpressionConverter.ConvertO(shipmentOrdershipmentPackingDatalwhUnitOfMeasure);
                shipmentPackingDataObjectpropCount++;
            }

            if (shipmentOrdershipmentPackingDatashipmentPackingType != null)
            {
                shipmentPackingDataObject["shipmentPackingType"] = ExpressionConverter.ConvertO(shipmentOrdershipmentPackingDatashipmentPackingType);
                shipmentPackingDataObjectpropCount++;
            }

            if (shipmentPackingDataObjectpropCount > 0)
            {
                shipmentOrder["shipmentPackingData"] = shipmentPackingDataObject;
                shipmentOrderpropCount++;
            }

            var shipmentChargeObject = new JObject();
            var shipmentChargeObjectpropCount = 0;
            shipmentChargeObjectpropCount++;
            shipmentChargeObject["estimatedCost"] = ExpressionConverter.ConvertO(shipmentOrdershipmentChargeestimatedCost);
            shipmentChargeObjectpropCount++;
            shipmentChargeObject["currencyCode"] = ExpressionConverter.ConvertO(shipmentOrdershipmentChargecurrencyCode);
            var billingDataObject = new JObject();
            var billingDataObjectpropCount = 0;
            if (shipmentOrdershipmentChargebillingDatacustomerId != null)
            {
                billingDataObject["customerId"] = ExpressionConverter.ConvertO(shipmentOrdershipmentChargebillingDatacustomerId);
                billingDataObjectpropCount++;
            }

            if (shipmentOrdershipmentChargebillingDatacustomerName != null)
            {
                billingDataObject["customerName"] = ExpressionConverter.ConvertO(shipmentOrdershipmentChargebillingDatacustomerName);
                billingDataObjectpropCount++;
            }

            var customAttributesObject = new JObject();
            var customAttributesObjectpropCount = 0;
            if (customAttributesObjectpropCount > 0)
            {
                billingDataObject["customAttributes"] = customAttributesObject;
                billingDataObjectpropCount++;
            }

            if (billingDataObjectpropCount > 0)
            {
                shipmentChargeObject["billingData"] = billingDataObject;
                shipmentChargeObjectpropCount++;
            }

            if (shipmentOrdershipmentChargecomponentCharges != null)
            {
                shipmentChargeObject["componentCharges"] = ExpressionConverter.ConvertO(shipmentOrdershipmentChargecomponentCharges);
                shipmentChargeObjectpropCount++;
            }

            if (shipmentChargeObjectpropCount > 0)
            {
                shipmentOrder["shipmentCharge"] = shipmentChargeObject;
                shipmentOrderpropCount++;
            }

            if (shipmentOrderplannedPickupTime != null)
            {
                shipmentOrder["plannedPickupTime"] = ExpressionConverter.ConvertO(shipmentOrderplannedPickupTime);
                shipmentOrderpropCount++;
            }

            if (shipmentOrderplannedEarliestPickupTime != null)
            {
                shipmentOrder["plannedEarliestPickupTime"] = ExpressionConverter.ConvertO(shipmentOrderplannedEarliestPickupTime);
                shipmentOrderpropCount++;
            }

            if (shipmentOrderplannedLatestPickupTime != null)
            {
                shipmentOrder["plannedLatestPickupTime"] = ExpressionConverter.ConvertO(shipmentOrderplannedLatestPickupTime);
                shipmentOrderpropCount++;
            }

            if (shipmentOrderplannedDeliveryTime != null)
            {
                shipmentOrder["plannedDeliveryTime"] = ExpressionConverter.ConvertO(shipmentOrderplannedDeliveryTime);
                shipmentOrderpropCount++;
            }

            if (shipmentOrderplannedEarliestDeliveryTime != null)
            {
                shipmentOrder["plannedEarliestDeliveryTime"] = ExpressionConverter.ConvertO(shipmentOrderplannedEarliestDeliveryTime);
                shipmentOrderpropCount++;
            }

            if (shipmentOrderplannedLatestDeliveryTime != null)
            {
                shipmentOrder["plannedLatestDeliveryTime"] = ExpressionConverter.ConvertO(shipmentOrderplannedLatestDeliveryTime);
                shipmentOrderpropCount++;
            }

            var shipmentContentDataObject = new JObject();
            var shipmentContentDataObjectpropCount = 0;
            shipmentContentDataObjectpropCount++;
            shipmentContentDataObject["isFragile"] = ExpressionConverter.ConvertO(shipmentOrdershipmentContentDataisFragile);
            shipmentContentDataObjectpropCount++;
            shipmentContentDataObject["includesBattery"] = ExpressionConverter.ConvertO(shipmentOrdershipmentContentDataincludesBattery);
            if (shipmentContentDataObjectpropCount > 0)
            {
                shipmentOrder["shipmentContentData"] = shipmentContentDataObject;
                shipmentOrderpropCount++;
            }

            var deliveryInstructionsObject = new JObject();
            var deliveryInstructionsObjectpropCount = 0;
            if (deliveryInstructionsObjectpropCount > 0)
            {
                shipmentOrder["deliveryInstructions"] = deliveryInstructionsObject;
                shipmentOrderpropCount++;
            }

            var customAttributesObject = new JObject();
            var customAttributesObjectpropCount = 0;
            if (customAttributesObjectpropCount > 0)
            {
                shipmentOrder["customAttributes"] = customAttributesObject;
                shipmentOrderpropCount++;
            }

            if (shipmentOrderlastModifiedTime != null)
            {
                shipmentOrder["lastModifiedTime"] = ExpressionConverter.ConvertO(shipmentOrderlastModifiedTime);
                shipmentOrderpropCount++;
            }

            if (shipmentOrderpropCount > 0)
            {
                callPayload.Body = shipmentOrder;
            }

            return new ApiConnectionAction<ShipmentOrder>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opensupplychainplatf")]
        public IBodyWorkflowAction<ShipmentOrder> ShipmentOrderUpdateShipmentOrder(Expression<Func<string>> shipmentOrderId, Expression<Func<string>> shipmentOrderid, Expression<Func<ShipmentItem[]>> shipmentOrdershipmentItems, Expression<Func<ShipmentLocation[]>> shipmentOrdershipmentLocationData, Expression<Func<double>> shipmentOrdershipmentPackingDatashipmentVolume, Expression<Func<double>> shipmentOrdershipmentPackingDatashipmentNetWeight, Expression<Func<double>> shipmentOrdershipmentPackingDatashipmentLength, Expression<Func<double>> shipmentOrdershipmentPackingDatashipmentWidth, Expression<Func<double>> shipmentOrdershipmentPackingDatashipmentHeight, Expression<Func<double>> shipmentOrdershipmentChargeestimatedCost, Expression<Func<string>> shipmentOrdershipmentChargecurrencyCode, Expression<Func<bool>> shipmentOrdershipmentContentDataisFragile, Expression<Func<bool>> shipmentOrdershipmentContentDataincludesBattery, Expression<Func<string>> shipmentOrdershipmentId = null, Expression<Func<string>> shipmentOrderstatus = null, Expression<Func<string>> shipmentOrdershipmentPackingDatavolumeUnitOfMeasure = null, Expression<Func<string>> shipmentOrdershipmentPackingDataweightUnitOfMeasure = null, Expression<Func<string>> shipmentOrdershipmentPackingDatalwhUnitOfMeasure = null, Expression<Func<string>> shipmentOrdershipmentPackingDatashipmentPackingType = null, Expression<Func<string>> shipmentOrdershipmentChargebillingDatacustomerId = null, Expression<Func<string>> shipmentOrdershipmentChargebillingDatacustomerName = null, Expression<Func<ComponentCharge[]>> shipmentOrdershipmentChargecomponentCharges = null, Expression<Func<string>> shipmentOrderplannedPickupTime = null, Expression<Func<string>> shipmentOrderplannedEarliestPickupTime = null, Expression<Func<string>> shipmentOrderplannedLatestPickupTime = null, Expression<Func<string>> shipmentOrderplannedDeliveryTime = null, Expression<Func<string>> shipmentOrderplannedEarliestDeliveryTime = null, Expression<Func<string>> shipmentOrderplannedLatestDeliveryTime = null, Expression<Func<string>> shipmentOrderlastModifiedTime = null)
        {
            var apiCallPath = String.Format("/shipmentOrders/{0}", ExpressionConverter.ConvertWithUrlEncoding(shipmentOrderId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var shipmentOrder = new JObject();
            var shipmentOrderpropCount = 0;
            shipmentOrderpropCount++;
            shipmentOrder["id"] = ExpressionConverter.ConvertO(shipmentOrderid);
            if (shipmentOrdershipmentId != null)
            {
                shipmentOrder["shipmentId"] = ExpressionConverter.ConvertO(shipmentOrdershipmentId);
                shipmentOrderpropCount++;
            }

            if (shipmentOrderstatus != null)
            {
                shipmentOrder["status"] = ExpressionConverter.ConvertO(shipmentOrderstatus);
                shipmentOrderpropCount++;
            }

            shipmentOrderpropCount++;
            shipmentOrder["shipmentItems"] = ExpressionConverter.ConvertO(shipmentOrdershipmentItems);
            shipmentOrderpropCount++;
            shipmentOrder["shipmentLocationData"] = ExpressionConverter.ConvertO(shipmentOrdershipmentLocationData);
            var shipmentPackingDataObject = new JObject();
            var shipmentPackingDataObjectpropCount = 0;
            shipmentPackingDataObjectpropCount++;
            shipmentPackingDataObject["shipmentVolume"] = ExpressionConverter.ConvertO(shipmentOrdershipmentPackingDatashipmentVolume);
            shipmentPackingDataObjectpropCount++;
            shipmentPackingDataObject["shipmentNetWeight"] = ExpressionConverter.ConvertO(shipmentOrdershipmentPackingDatashipmentNetWeight);
            if (shipmentOrdershipmentPackingDatavolumeUnitOfMeasure != null)
            {
                shipmentPackingDataObject["volumeUnitOfMeasure"] = ExpressionConverter.ConvertO(shipmentOrdershipmentPackingDatavolumeUnitOfMeasure);
                shipmentPackingDataObjectpropCount++;
            }

            if (shipmentOrdershipmentPackingDataweightUnitOfMeasure != null)
            {
                shipmentPackingDataObject["weightUnitOfMeasure"] = ExpressionConverter.ConvertO(shipmentOrdershipmentPackingDataweightUnitOfMeasure);
                shipmentPackingDataObjectpropCount++;
            }

            shipmentPackingDataObjectpropCount++;
            shipmentPackingDataObject["shipmentLength"] = ExpressionConverter.ConvertO(shipmentOrdershipmentPackingDatashipmentLength);
            shipmentPackingDataObjectpropCount++;
            shipmentPackingDataObject["shipmentWidth"] = ExpressionConverter.ConvertO(shipmentOrdershipmentPackingDatashipmentWidth);
            shipmentPackingDataObjectpropCount++;
            shipmentPackingDataObject["shipmentHeight"] = ExpressionConverter.ConvertO(shipmentOrdershipmentPackingDatashipmentHeight);
            if (shipmentOrdershipmentPackingDatalwhUnitOfMeasure != null)
            {
                shipmentPackingDataObject["lwhUnitOfMeasure"] = ExpressionConverter.ConvertO(shipmentOrdershipmentPackingDatalwhUnitOfMeasure);
                shipmentPackingDataObjectpropCount++;
            }

            if (shipmentOrdershipmentPackingDatashipmentPackingType != null)
            {
                shipmentPackingDataObject["shipmentPackingType"] = ExpressionConverter.ConvertO(shipmentOrdershipmentPackingDatashipmentPackingType);
                shipmentPackingDataObjectpropCount++;
            }

            if (shipmentPackingDataObjectpropCount > 0)
            {
                shipmentOrder["shipmentPackingData"] = shipmentPackingDataObject;
                shipmentOrderpropCount++;
            }

            var shipmentChargeObject = new JObject();
            var shipmentChargeObjectpropCount = 0;
            shipmentChargeObjectpropCount++;
            shipmentChargeObject["estimatedCost"] = ExpressionConverter.ConvertO(shipmentOrdershipmentChargeestimatedCost);
            shipmentChargeObjectpropCount++;
            shipmentChargeObject["currencyCode"] = ExpressionConverter.ConvertO(shipmentOrdershipmentChargecurrencyCode);
            var billingDataObject = new JObject();
            var billingDataObjectpropCount = 0;
            if (shipmentOrdershipmentChargebillingDatacustomerId != null)
            {
                billingDataObject["customerId"] = ExpressionConverter.ConvertO(shipmentOrdershipmentChargebillingDatacustomerId);
                billingDataObjectpropCount++;
            }

            if (shipmentOrdershipmentChargebillingDatacustomerName != null)
            {
                billingDataObject["customerName"] = ExpressionConverter.ConvertO(shipmentOrdershipmentChargebillingDatacustomerName);
                billingDataObjectpropCount++;
            }

            var customAttributesObject = new JObject();
            var customAttributesObjectpropCount = 0;
            if (customAttributesObjectpropCount > 0)
            {
                billingDataObject["customAttributes"] = customAttributesObject;
                billingDataObjectpropCount++;
            }

            if (billingDataObjectpropCount > 0)
            {
                shipmentChargeObject["billingData"] = billingDataObject;
                shipmentChargeObjectpropCount++;
            }

            if (shipmentOrdershipmentChargecomponentCharges != null)
            {
                shipmentChargeObject["componentCharges"] = ExpressionConverter.ConvertO(shipmentOrdershipmentChargecomponentCharges);
                shipmentChargeObjectpropCount++;
            }

            if (shipmentChargeObjectpropCount > 0)
            {
                shipmentOrder["shipmentCharge"] = shipmentChargeObject;
                shipmentOrderpropCount++;
            }

            if (shipmentOrderplannedPickupTime != null)
            {
                shipmentOrder["plannedPickupTime"] = ExpressionConverter.ConvertO(shipmentOrderplannedPickupTime);
                shipmentOrderpropCount++;
            }

            if (shipmentOrderplannedEarliestPickupTime != null)
            {
                shipmentOrder["plannedEarliestPickupTime"] = ExpressionConverter.ConvertO(shipmentOrderplannedEarliestPickupTime);
                shipmentOrderpropCount++;
            }

            if (shipmentOrderplannedLatestPickupTime != null)
            {
                shipmentOrder["plannedLatestPickupTime"] = ExpressionConverter.ConvertO(shipmentOrderplannedLatestPickupTime);
                shipmentOrderpropCount++;
            }

            if (shipmentOrderplannedDeliveryTime != null)
            {
                shipmentOrder["plannedDeliveryTime"] = ExpressionConverter.ConvertO(shipmentOrderplannedDeliveryTime);
                shipmentOrderpropCount++;
            }

            if (shipmentOrderplannedEarliestDeliveryTime != null)
            {
                shipmentOrder["plannedEarliestDeliveryTime"] = ExpressionConverter.ConvertO(shipmentOrderplannedEarliestDeliveryTime);
                shipmentOrderpropCount++;
            }

            if (shipmentOrderplannedLatestDeliveryTime != null)
            {
                shipmentOrder["plannedLatestDeliveryTime"] = ExpressionConverter.ConvertO(shipmentOrderplannedLatestDeliveryTime);
                shipmentOrderpropCount++;
            }

            var shipmentContentDataObject = new JObject();
            var shipmentContentDataObjectpropCount = 0;
            shipmentContentDataObjectpropCount++;
            shipmentContentDataObject["isFragile"] = ExpressionConverter.ConvertO(shipmentOrdershipmentContentDataisFragile);
            shipmentContentDataObjectpropCount++;
            shipmentContentDataObject["includesBattery"] = ExpressionConverter.ConvertO(shipmentOrdershipmentContentDataincludesBattery);
            if (shipmentContentDataObjectpropCount > 0)
            {
                shipmentOrder["shipmentContentData"] = shipmentContentDataObject;
                shipmentOrderpropCount++;
            }

            var deliveryInstructionsObject = new JObject();
            var deliveryInstructionsObjectpropCount = 0;
            if (deliveryInstructionsObjectpropCount > 0)
            {
                shipmentOrder["deliveryInstructions"] = deliveryInstructionsObject;
                shipmentOrderpropCount++;
            }

            var customAttributesObject = new JObject();
            var customAttributesObjectpropCount = 0;
            if (customAttributesObjectpropCount > 0)
            {
                shipmentOrder["customAttributes"] = customAttributesObject;
                shipmentOrderpropCount++;
            }

            if (shipmentOrderlastModifiedTime != null)
            {
                shipmentOrder["lastModifiedTime"] = ExpressionConverter.ConvertO(shipmentOrderlastModifiedTime);
                shipmentOrderpropCount++;
            }

            if (shipmentOrderpropCount > 0)
            {
                callPayload.Body = shipmentOrder;
            }

            return new ApiConnectionAction<ShipmentOrder>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opensupplychainplatf")]
        public IBodyWorkflowAction<BulkResponseItemOfShipmentOrder[]> ShipmentOrderBulkPut(Expression<Func<ShipmentOrder[]>> shipmentOrders = null)
        {
            var apiCallPath = "/shipmentOrders";
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(shipmentOrders);
            return new ApiConnectionAction<BulkResponseItemOfShipmentOrder[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opensupplychainplatf")]
        public IBodyWorkflowAction<ShipmentQuote> ShipmentQuoteGet(Expression<Func<string>> shipmentQuoteId)
        {
            var apiCallPath = String.Format("/shipmentQuotes/{0}", ExpressionConverter.ConvertWithUrlEncoding(shipmentQuoteId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ShipmentQuote>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opensupplychainplatf")]
        public IBodyWorkflowAction<ShipmentQuote> ShipmentQuotePut(Expression<Func<string>> shipmentQuoteId, Expression<Func<string>> shipmentQuoteid, Expression<Func<string>> shipmentQuoteshipmentQuoteRequestId, Expression<Func<double>> shipmentQuoteshipmentChargeestimatedCost, Expression<Func<string>> shipmentQuoteshipmentChargecurrencyCode, Expression<Func<string>> shipmentQuotecarrierDatacarrierId, Expression<Func<string>> shipmentQuotecarrierDatacarrierName, Expression<Func<string>> shipmentQuoteshipmentChargebillingDatacustomerId = null, Expression<Func<string>> shipmentQuoteshipmentChargebillingDatacustomerName = null, Expression<Func<ComponentCharge[]>> shipmentQuoteshipmentChargecomponentCharges = null, Expression<Func<string>> shipmentQuoteplannedPickupTime = null, Expression<Func<string>> shipmentQuoteplannedDeliveryTime = null, Expression<Func<string>> shipmentQuotelastModifiedTime = null)
        {
            var apiCallPath = String.Format("/shipmentQuotes/{0}", ExpressionConverter.ConvertWithUrlEncoding(shipmentQuoteId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var shipmentQuote = new JObject();
            var shipmentQuotepropCount = 0;
            shipmentQuotepropCount++;
            shipmentQuote["id"] = ExpressionConverter.ConvertO(shipmentQuoteid);
            shipmentQuotepropCount++;
            shipmentQuote["shipmentQuoteRequestId"] = ExpressionConverter.ConvertO(shipmentQuoteshipmentQuoteRequestId);
            var shipmentChargeObject = new JObject();
            var shipmentChargeObjectpropCount = 0;
            shipmentChargeObjectpropCount++;
            shipmentChargeObject["estimatedCost"] = ExpressionConverter.ConvertO(shipmentQuoteshipmentChargeestimatedCost);
            shipmentChargeObjectpropCount++;
            shipmentChargeObject["currencyCode"] = ExpressionConverter.ConvertO(shipmentQuoteshipmentChargecurrencyCode);
            var billingDataObject = new JObject();
            var billingDataObjectpropCount = 0;
            if (shipmentQuoteshipmentChargebillingDatacustomerId != null)
            {
                billingDataObject["customerId"] = ExpressionConverter.ConvertO(shipmentQuoteshipmentChargebillingDatacustomerId);
                billingDataObjectpropCount++;
            }

            if (shipmentQuoteshipmentChargebillingDatacustomerName != null)
            {
                billingDataObject["customerName"] = ExpressionConverter.ConvertO(shipmentQuoteshipmentChargebillingDatacustomerName);
                billingDataObjectpropCount++;
            }

            var customAttributesObject = new JObject();
            var customAttributesObjectpropCount = 0;
            if (customAttributesObjectpropCount > 0)
            {
                billingDataObject["customAttributes"] = customAttributesObject;
                billingDataObjectpropCount++;
            }

            if (billingDataObjectpropCount > 0)
            {
                shipmentChargeObject["billingData"] = billingDataObject;
                shipmentChargeObjectpropCount++;
            }

            if (shipmentQuoteshipmentChargecomponentCharges != null)
            {
                shipmentChargeObject["componentCharges"] = ExpressionConverter.ConvertO(shipmentQuoteshipmentChargecomponentCharges);
                shipmentChargeObjectpropCount++;
            }

            if (shipmentChargeObjectpropCount > 0)
            {
                shipmentQuote["shipmentCharge"] = shipmentChargeObject;
                shipmentQuotepropCount++;
            }

            if (shipmentQuoteplannedPickupTime != null)
            {
                shipmentQuote["plannedPickupTime"] = ExpressionConverter.ConvertO(shipmentQuoteplannedPickupTime);
                shipmentQuotepropCount++;
            }

            if (shipmentQuoteplannedDeliveryTime != null)
            {
                shipmentQuote["plannedDeliveryTime"] = ExpressionConverter.ConvertO(shipmentQuoteplannedDeliveryTime);
                shipmentQuotepropCount++;
            }

            var carrierDataObject = new JObject();
            var carrierDataObjectpropCount = 0;
            carrierDataObjectpropCount++;
            carrierDataObject["carrierId"] = ExpressionConverter.ConvertO(shipmentQuotecarrierDatacarrierId);
            carrierDataObjectpropCount++;
            carrierDataObject["carrierName"] = ExpressionConverter.ConvertO(shipmentQuotecarrierDatacarrierName);
            if (carrierDataObjectpropCount > 0)
            {
                shipmentQuote["carrierData"] = carrierDataObject;
                shipmentQuotepropCount++;
            }

            var customAttributesObject = new JObject();
            var customAttributesObjectpropCount = 0;
            if (customAttributesObjectpropCount > 0)
            {
                shipmentQuote["customAttributes"] = customAttributesObject;
                shipmentQuotepropCount++;
            }

            if (shipmentQuotelastModifiedTime != null)
            {
                shipmentQuote["lastModifiedTime"] = ExpressionConverter.ConvertO(shipmentQuotelastModifiedTime);
                shipmentQuotepropCount++;
            }

            if (shipmentQuotepropCount > 0)
            {
                callPayload.Body = shipmentQuote;
            }

            return new ApiConnectionAction<ShipmentQuote>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opensupplychainplatf")]
        public IBodyWorkflowAction<ShipmentQuoteRequest> ShipmentQuoteRequestGet(Expression<Func<string>> shipmentQuoteRequestId)
        {
            var apiCallPath = String.Format("/shipmentQuoteRequests/{0}", ExpressionConverter.ConvertWithUrlEncoding(shipmentQuoteRequestId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ShipmentQuoteRequest>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opensupplychainplatf")]
        public IBodyWorkflowAction<ShipmentQuoteRequest> ShipmentQuoteRequestPut(Expression<Func<string>> shipmentQuoteRequestId, Expression<Func<string>> shipmentQuoteRequestid, Expression<Func<ShipmentItem[]>> shipmentQuoteRequestshipmentItems, Expression<Func<ShipmentLocation[]>> shipmentQuoteRequestshipmentLocationData, Expression<Func<double>> shipmentQuoteRequestshipmentPackingDatashipmentVolume, Expression<Func<double>> shipmentQuoteRequestshipmentPackingDatashipmentNetWeight, Expression<Func<double>> shipmentQuoteRequestshipmentPackingDatashipmentLength, Expression<Func<double>> shipmentQuoteRequestshipmentPackingDatashipmentWidth, Expression<Func<double>> shipmentQuoteRequestshipmentPackingDatashipmentHeight, Expression<Func<string>> shipmentQuoteRequestshipmentPackingDatavolumeUnitOfMeasure = null, Expression<Func<string>> shipmentQuoteRequestshipmentPackingDataweightUnitOfMeasure = null, Expression<Func<string>> shipmentQuoteRequestshipmentPackingDatalwhUnitOfMeasure = null, Expression<Func<string>> shipmentQuoteRequestshipmentPackingDatashipmentPackingType = null, Expression<Func<string[]>> shipmentQuoteRequestshipmentQuoteIds = null, Expression<Func<string>> shipmentQuoteRequestplannedPickupTime = null, Expression<Func<string>> shipmentQuoteRequestplannedDeliveryTime = null, Expression<Func<string>> shipmentQuoteRequestlastModifiedTime = null)
        {
            var apiCallPath = String.Format("/shipmentQuoteRequests/{0}", ExpressionConverter.ConvertWithUrlEncoding(shipmentQuoteRequestId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var shipmentQuoteRequest = new JObject();
            var shipmentQuoteRequestpropCount = 0;
            shipmentQuoteRequestpropCount++;
            shipmentQuoteRequest["id"] = ExpressionConverter.ConvertO(shipmentQuoteRequestid);
            shipmentQuoteRequestpropCount++;
            shipmentQuoteRequest["shipmentItems"] = ExpressionConverter.ConvertO(shipmentQuoteRequestshipmentItems);
            shipmentQuoteRequestpropCount++;
            shipmentQuoteRequest["shipmentLocationData"] = ExpressionConverter.ConvertO(shipmentQuoteRequestshipmentLocationData);
            var shipmentPackingDataObject = new JObject();
            var shipmentPackingDataObjectpropCount = 0;
            shipmentPackingDataObjectpropCount++;
            shipmentPackingDataObject["shipmentVolume"] = ExpressionConverter.ConvertO(shipmentQuoteRequestshipmentPackingDatashipmentVolume);
            shipmentPackingDataObjectpropCount++;
            shipmentPackingDataObject["shipmentNetWeight"] = ExpressionConverter.ConvertO(shipmentQuoteRequestshipmentPackingDatashipmentNetWeight);
            if (shipmentQuoteRequestshipmentPackingDatavolumeUnitOfMeasure != null)
            {
                shipmentPackingDataObject["volumeUnitOfMeasure"] = ExpressionConverter.ConvertO(shipmentQuoteRequestshipmentPackingDatavolumeUnitOfMeasure);
                shipmentPackingDataObjectpropCount++;
            }

            if (shipmentQuoteRequestshipmentPackingDataweightUnitOfMeasure != null)
            {
                shipmentPackingDataObject["weightUnitOfMeasure"] = ExpressionConverter.ConvertO(shipmentQuoteRequestshipmentPackingDataweightUnitOfMeasure);
                shipmentPackingDataObjectpropCount++;
            }

            shipmentPackingDataObjectpropCount++;
            shipmentPackingDataObject["shipmentLength"] = ExpressionConverter.ConvertO(shipmentQuoteRequestshipmentPackingDatashipmentLength);
            shipmentPackingDataObjectpropCount++;
            shipmentPackingDataObject["shipmentWidth"] = ExpressionConverter.ConvertO(shipmentQuoteRequestshipmentPackingDatashipmentWidth);
            shipmentPackingDataObjectpropCount++;
            shipmentPackingDataObject["shipmentHeight"] = ExpressionConverter.ConvertO(shipmentQuoteRequestshipmentPackingDatashipmentHeight);
            if (shipmentQuoteRequestshipmentPackingDatalwhUnitOfMeasure != null)
            {
                shipmentPackingDataObject["lwhUnitOfMeasure"] = ExpressionConverter.ConvertO(shipmentQuoteRequestshipmentPackingDatalwhUnitOfMeasure);
                shipmentPackingDataObjectpropCount++;
            }

            if (shipmentQuoteRequestshipmentPackingDatashipmentPackingType != null)
            {
                shipmentPackingDataObject["shipmentPackingType"] = ExpressionConverter.ConvertO(shipmentQuoteRequestshipmentPackingDatashipmentPackingType);
                shipmentPackingDataObjectpropCount++;
            }

            if (shipmentPackingDataObjectpropCount > 0)
            {
                shipmentQuoteRequest["shipmentPackingData"] = shipmentPackingDataObject;
                shipmentQuoteRequestpropCount++;
            }

            if (shipmentQuoteRequestshipmentQuoteIds != null)
            {
                shipmentQuoteRequest["shipmentQuoteIds"] = ExpressionConverter.ConvertO(shipmentQuoteRequestshipmentQuoteIds);
                shipmentQuoteRequestpropCount++;
            }

            if (shipmentQuoteRequestplannedPickupTime != null)
            {
                shipmentQuoteRequest["plannedPickupTime"] = ExpressionConverter.ConvertO(shipmentQuoteRequestplannedPickupTime);
                shipmentQuoteRequestpropCount++;
            }

            if (shipmentQuoteRequestplannedDeliveryTime != null)
            {
                shipmentQuoteRequest["plannedDeliveryTime"] = ExpressionConverter.ConvertO(shipmentQuoteRequestplannedDeliveryTime);
                shipmentQuoteRequestpropCount++;
            }

            if (shipmentQuoteRequestlastModifiedTime != null)
            {
                shipmentQuoteRequest["lastModifiedTime"] = ExpressionConverter.ConvertO(shipmentQuoteRequestlastModifiedTime);
                shipmentQuoteRequestpropCount++;
            }

            if (shipmentQuoteRequestpropCount > 0)
            {
                callPayload.Body = shipmentQuoteRequest;
            }

            return new ApiConnectionAction<ShipmentQuoteRequest>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opensupplychainplatf")]
        public IBodyWorkflowAction<ShipmentQuoteRequest> ShipmentQuoteRequestUpdateShipmentQuoteRequest(Expression<Func<string>> shipmentQuoteRequestId, Expression<Func<string>> shipmentQuoteRequestid, Expression<Func<ShipmentItem[]>> shipmentQuoteRequestshipmentItems, Expression<Func<ShipmentLocation[]>> shipmentQuoteRequestshipmentLocationData, Expression<Func<double>> shipmentQuoteRequestshipmentPackingDatashipmentVolume, Expression<Func<double>> shipmentQuoteRequestshipmentPackingDatashipmentNetWeight, Expression<Func<double>> shipmentQuoteRequestshipmentPackingDatashipmentLength, Expression<Func<double>> shipmentQuoteRequestshipmentPackingDatashipmentWidth, Expression<Func<double>> shipmentQuoteRequestshipmentPackingDatashipmentHeight, Expression<Func<string>> shipmentQuoteRequestshipmentPackingDatavolumeUnitOfMeasure = null, Expression<Func<string>> shipmentQuoteRequestshipmentPackingDataweightUnitOfMeasure = null, Expression<Func<string>> shipmentQuoteRequestshipmentPackingDatalwhUnitOfMeasure = null, Expression<Func<string>> shipmentQuoteRequestshipmentPackingDatashipmentPackingType = null, Expression<Func<string[]>> shipmentQuoteRequestshipmentQuoteIds = null, Expression<Func<string>> shipmentQuoteRequestplannedPickupTime = null, Expression<Func<string>> shipmentQuoteRequestplannedDeliveryTime = null, Expression<Func<string>> shipmentQuoteRequestlastModifiedTime = null)
        {
            var apiCallPath = String.Format("/shipmentQuoteRequests/{0}", ExpressionConverter.ConvertWithUrlEncoding(shipmentQuoteRequestId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var shipmentQuoteRequest = new JObject();
            var shipmentQuoteRequestpropCount = 0;
            shipmentQuoteRequestpropCount++;
            shipmentQuoteRequest["id"] = ExpressionConverter.ConvertO(shipmentQuoteRequestid);
            shipmentQuoteRequestpropCount++;
            shipmentQuoteRequest["shipmentItems"] = ExpressionConverter.ConvertO(shipmentQuoteRequestshipmentItems);
            shipmentQuoteRequestpropCount++;
            shipmentQuoteRequest["shipmentLocationData"] = ExpressionConverter.ConvertO(shipmentQuoteRequestshipmentLocationData);
            var shipmentPackingDataObject = new JObject();
            var shipmentPackingDataObjectpropCount = 0;
            shipmentPackingDataObjectpropCount++;
            shipmentPackingDataObject["shipmentVolume"] = ExpressionConverter.ConvertO(shipmentQuoteRequestshipmentPackingDatashipmentVolume);
            shipmentPackingDataObjectpropCount++;
            shipmentPackingDataObject["shipmentNetWeight"] = ExpressionConverter.ConvertO(shipmentQuoteRequestshipmentPackingDatashipmentNetWeight);
            if (shipmentQuoteRequestshipmentPackingDatavolumeUnitOfMeasure != null)
            {
                shipmentPackingDataObject["volumeUnitOfMeasure"] = ExpressionConverter.ConvertO(shipmentQuoteRequestshipmentPackingDatavolumeUnitOfMeasure);
                shipmentPackingDataObjectpropCount++;
            }

            if (shipmentQuoteRequestshipmentPackingDataweightUnitOfMeasure != null)
            {
                shipmentPackingDataObject["weightUnitOfMeasure"] = ExpressionConverter.ConvertO(shipmentQuoteRequestshipmentPackingDataweightUnitOfMeasure);
                shipmentPackingDataObjectpropCount++;
            }

            shipmentPackingDataObjectpropCount++;
            shipmentPackingDataObject["shipmentLength"] = ExpressionConverter.ConvertO(shipmentQuoteRequestshipmentPackingDatashipmentLength);
            shipmentPackingDataObjectpropCount++;
            shipmentPackingDataObject["shipmentWidth"] = ExpressionConverter.ConvertO(shipmentQuoteRequestshipmentPackingDatashipmentWidth);
            shipmentPackingDataObjectpropCount++;
            shipmentPackingDataObject["shipmentHeight"] = ExpressionConverter.ConvertO(shipmentQuoteRequestshipmentPackingDatashipmentHeight);
            if (shipmentQuoteRequestshipmentPackingDatalwhUnitOfMeasure != null)
            {
                shipmentPackingDataObject["lwhUnitOfMeasure"] = ExpressionConverter.ConvertO(shipmentQuoteRequestshipmentPackingDatalwhUnitOfMeasure);
                shipmentPackingDataObjectpropCount++;
            }

            if (shipmentQuoteRequestshipmentPackingDatashipmentPackingType != null)
            {
                shipmentPackingDataObject["shipmentPackingType"] = ExpressionConverter.ConvertO(shipmentQuoteRequestshipmentPackingDatashipmentPackingType);
                shipmentPackingDataObjectpropCount++;
            }

            if (shipmentPackingDataObjectpropCount > 0)
            {
                shipmentQuoteRequest["shipmentPackingData"] = shipmentPackingDataObject;
                shipmentQuoteRequestpropCount++;
            }

            if (shipmentQuoteRequestshipmentQuoteIds != null)
            {
                shipmentQuoteRequest["shipmentQuoteIds"] = ExpressionConverter.ConvertO(shipmentQuoteRequestshipmentQuoteIds);
                shipmentQuoteRequestpropCount++;
            }

            if (shipmentQuoteRequestplannedPickupTime != null)
            {
                shipmentQuoteRequest["plannedPickupTime"] = ExpressionConverter.ConvertO(shipmentQuoteRequestplannedPickupTime);
                shipmentQuoteRequestpropCount++;
            }

            if (shipmentQuoteRequestplannedDeliveryTime != null)
            {
                shipmentQuoteRequest["plannedDeliveryTime"] = ExpressionConverter.ConvertO(shipmentQuoteRequestplannedDeliveryTime);
                shipmentQuoteRequestpropCount++;
            }

            if (shipmentQuoteRequestlastModifiedTime != null)
            {
                shipmentQuoteRequest["lastModifiedTime"] = ExpressionConverter.ConvertO(shipmentQuoteRequestlastModifiedTime);
                shipmentQuoteRequestpropCount++;
            }

            if (shipmentQuoteRequestpropCount > 0)
            {
                callPayload.Body = shipmentQuoteRequest;
            }

            return new ApiConnectionAction<ShipmentQuoteRequest>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opensupplychainplatf")]
        public IBodyWorkflowAction<Warehouse> WarehouseGet(Expression<Func<string>> warehouseId)
        {
            var apiCallPath = String.Format("/warehouses/{0}", ExpressionConverter.ConvertWithUrlEncoding(warehouseId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<Warehouse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opensupplychainplatf")]
        public IBodyWorkflowAction<object> WarehouseDelete(Expression<Func<string>> warehouseId)
        {
            var apiCallPath = String.Format("/warehouses/{0}", ExpressionConverter.ConvertWithUrlEncoding(warehouseId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<object>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opensupplychainplatf")]
        public IBodyWorkflowAction<Warehouse> WarehousePut(Expression<Func<string>> warehouseId, Expression<Func<string>> warehouseid, Expression<Func<HoursOfOperation[]>> warehousehoursOfOperations, Expression<Func<string>> warehouselocationaddressLine1, Expression<Func<string>> warehouselocationcityName, Expression<Func<string>> warehouselocationstateName, Expression<Func<string>> warehouselocationcountryName, Expression<Func<string>> warehouselocationpostalCode, Expression<Func<int>> warehousepickAndPackLeadTime, Expression<Func<CarrierReference[]>> warehousecarrierReferences, Expression<Func<string>> warehouselocationtimeZoneName = null, Expression<Func<string>> warehouselocationaddressLine2 = null, Expression<Func<Note[]>> warehouselocationnotes = null, Expression<Func<string[]>> warehouselabels = null, Expression<Func<string>> warehouselastModifiedTime = null)
        {
            var apiCallPath = String.Format("/warehouses/{0}", ExpressionConverter.ConvertWithUrlEncoding(warehouseId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var warehouse = new JObject();
            var warehousepropCount = 0;
            warehousepropCount++;
            warehouse["id"] = ExpressionConverter.ConvertO(warehouseid);
            warehousepropCount++;
            warehouse["hoursOfOperations"] = ExpressionConverter.ConvertO(warehousehoursOfOperations);
            var locationObject = new JObject();
            var locationObjectpropCount = 0;
            if (warehouselocationtimeZoneName != null)
            {
                locationObject["timeZoneName"] = ExpressionConverter.ConvertO(warehouselocationtimeZoneName);
                locationObjectpropCount++;
            }

            locationObjectpropCount++;
            locationObject["addressLine1"] = ExpressionConverter.ConvertO(warehouselocationaddressLine1);
            if (warehouselocationaddressLine2 != null)
            {
                locationObject["addressLine2"] = ExpressionConverter.ConvertO(warehouselocationaddressLine2);
                locationObjectpropCount++;
            }

            locationObjectpropCount++;
            locationObject["cityName"] = ExpressionConverter.ConvertO(warehouselocationcityName);
            locationObjectpropCount++;
            locationObject["stateName"] = ExpressionConverter.ConvertO(warehouselocationstateName);
            locationObjectpropCount++;
            locationObject["countryName"] = ExpressionConverter.ConvertO(warehouselocationcountryName);
            locationObjectpropCount++;
            locationObject["postalCode"] = ExpressionConverter.ConvertO(warehouselocationpostalCode);
            if (warehouselocationnotes != null)
            {
                locationObject["notes"] = ExpressionConverter.ConvertO(warehouselocationnotes);
                locationObjectpropCount++;
            }

            if (locationObjectpropCount > 0)
            {
                warehouse["location"] = locationObject;
                warehousepropCount++;
            }

            if (warehouselabels != null)
            {
                warehouse["labels"] = ExpressionConverter.ConvertO(warehouselabels);
                warehousepropCount++;
            }

            if (warehouselastModifiedTime != null)
            {
                warehouse["lastModifiedTime"] = ExpressionConverter.ConvertO(warehouselastModifiedTime);
                warehousepropCount++;
            }

            warehousepropCount++;
            warehouse["pickAndPackLeadTime"] = ExpressionConverter.ConvertO(warehousepickAndPackLeadTime);
            warehousepropCount++;
            warehouse["carrierReferences"] = ExpressionConverter.ConvertO(warehousecarrierReferences);
            if (warehousepropCount > 0)
            {
                callPayload.Body = warehouse;
            }

            return new ApiConnectionAction<Warehouse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opensupplychainplatf")]
        public IBodyWorkflowAction<Warehouse[]> WarehouseGetAllWarehouses()
        {
            var apiCallPath = "/warehouses";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<Warehouse[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opensupplychainplatf")]
        public IBodyWorkflowAction<BulkResponseItemOfString[]> WarehouseBulkDelete(Expression<Func<string[]>> warehouseIds = null)
        {
            var apiCallPath = "/warehouses";
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(warehouseIds);
            return new ApiConnectionAction<BulkResponseItemOfString[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opensupplychainplatf")]
        public IBodyWorkflowAction<BulkResponseItemOfWarehouse[]> WarehouseBulkPut(Expression<Func<Warehouse[]>> warehouses = null)
        {
            var apiCallPath = "/warehouses";
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(warehouses);
            return new ApiConnectionAction<BulkResponseItemOfWarehouse[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opensupplychainplatf")]
        public IBodyWorkflowAction<WarehouseItem> WarehouseItemGet(Expression<Func<string>> warehouseId, Expression<Func<string>> itemSKU)
        {
            var apiCallPath = String.Format("/warehouses/{0}/warehouseItems/{1}", ExpressionConverter.ConvertWithUrlEncoding(warehouseId, 1), ExpressionConverter.ConvertWithUrlEncoding(itemSKU, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<WarehouseItem>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opensupplychainplatf")]
        public IBodyWorkflowAction<object> WarehouseItemDelete(Expression<Func<string>> warehouseId, Expression<Func<string>> itemSKU)
        {
            var apiCallPath = String.Format("/warehouses/{0}/warehouseItems/{1}", ExpressionConverter.ConvertWithUrlEncoding(warehouseId, 1), ExpressionConverter.ConvertWithUrlEncoding(itemSKU, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<object>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opensupplychainplatf")]
        public IBodyWorkflowAction<BulkResponseItemOfString[]> WarehouseItemBulkDelete(Expression<Func<string>> warehouseId, Expression<Func<string[]>> itemSKUs = null)
        {
            var apiCallPath = String.Format("/warehouses/{0}/warehouseItems", ExpressionConverter.ConvertWithUrlEncoding(warehouseId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(itemSKUs);
            return new ApiConnectionAction<BulkResponseItemOfString[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opensupplychainplatf")]
        public IBodyWorkflowAction<BulkResponseItemOfWarehouseItem[]> WarehouseItemBulkPut(Expression<Func<string>> warehouseId, Expression<Func<WarehouseItem[]>> warehouseItems = null)
        {
            var apiCallPath = String.Format("/warehouses/{0}/warehouseItems", ExpressionConverter.ConvertWithUrlEncoding(warehouseId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(warehouseItems);
            return new ApiConnectionAction<BulkResponseItemOfWarehouseItem[]>(callPayload);
        }
    }

    public class OpensupplychainplatfTriggers([ConnectionName] string connectionId)
    {
    }

    public class Carrier
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("notes")]
        public Note[] Notes { get; set; }
    }

    public class Note
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class DataInflow
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("datasetName")]
        public string DatasetName { get; set; }

        [JsonProperty("connector")]
        public Connector Connector { get; set; }

        [JsonProperty("transformer")]
        public Transformer Transformer { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }
    }

    public class Connector
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("typeProperties")]
        public JToken TypeProperties { get; set; }

        [JsonProperty("output")]
        public JToken Output { get; set; }
    }

    public class Transformer
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("typeProperties")]
        public JToken TypeProperties { get; set; }
    }

    public class DataInflowRun
    {
        [JsonProperty("dataInflowName")]
        public string DataInflowName { get; set; }

        [JsonProperty("runParams")]
        public JToken RunParams { get; set; }

        [JsonProperty("dataInflowRunId")]
        public string DataInflowRunId { get; set; }

        [JsonProperty("triggeredAt")]
        public string TriggeredAt { get; set; }

        [JsonProperty("completedAt")]
        public string CompletedAt { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class DataOutflow
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("datasetName")]
        public string DatasetName { get; set; }

        [JsonProperty("filteredEntities")]
        public DataSchema[] FilteredEntities { get; set; }

        [JsonProperty("connector")]
        public Connector Connector { get; set; }

        [JsonProperty("transformer")]
        public Transformer Transformer { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }
    }

    public class DataSchema
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("attributes")]
        public DataSchemaAttribute[] Attributes { get; set; }
    }

    public class DataSchemaAttribute
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class DataOutflowRun
    {
        [JsonProperty("dataOutflowName")]
        public string DataOutflowName { get; set; }

        [JsonProperty("dataOutflowRunId")]
        public string DataOutflowRunId { get; set; }

        [JsonProperty("runParams")]
        public JToken RunParams { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("triggeredAt")]
        public string TriggeredAt { get; set; }

        [JsonProperty("completedAt")]
        public string CompletedAt { get; set; }

        [JsonProperty("triggeredBy")]
        public string TriggeredBy { get; set; }

        [JsonProperty("triggerId")]
        public string TriggerId { get; set; }
    }

    public class Dataset
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("dataSchema")]
        public DataSchema[] DataSchema { get; set; }

        [JsonProperty("isDisabled")]
        public bool IsDisabled { get; set; }

        [JsonProperty("operationalType")]
        public string OperationalType { get; set; }

        [JsonProperty("schemaReference")]
        public SchemaReference SchemaReference { get; set; }

        [JsonProperty("labels")]
        public string[] Labels { get; set; }
    }

    public class SchemaReference
    {
        [JsonProperty("dataModelId")]
        public string DataModelId { get; set; }

        [JsonProperty("dataModelVersion")]
        public string DataModelVersion { get; set; }

        [JsonProperty("dataModelType")]
        public string DataModelType { get; set; }
    }

    public class Directory
    {
        [JsonProperty("ingestionTime")]
        public string IngestionTime { get; set; }

        [JsonProperty("incrementType")]
        public string IncrementType { get; set; }
    }

    public class DeliveryNode
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("hoursOfOperations")]
        public HoursOfOperation[] HoursOfOperations { get; set; }

        [JsonProperty("location")]
        public Location Location { get; set; }

        [JsonProperty("labels")]
        public string[] Labels { get; set; }

        [JsonProperty("lastModifiedTime")]
        public string LastModifiedTime { get; set; }
    }

    public class HoursOfOperation
    {
        [JsonProperty("dayOfWeekName")]
        public string DayOfWeekName { get; set; }

        [JsonProperty("startTime")]
        public string StartTime { get; set; }

        [JsonProperty("endTime")]
        public string EndTime { get; set; }
    }

    public class Location
    {
        [JsonProperty("timeZoneName")]
        public string TimeZoneName { get; set; }

        [JsonProperty("addressLine1")]
        public string AddressLine1 { get; set; }

        [JsonProperty("addressLine2")]
        public string AddressLine2 { get; set; }

        [JsonProperty("cityName")]
        public string CityName { get; set; }

        [JsonProperty("stateName")]
        public string StateName { get; set; }

        [JsonProperty("countryName")]
        public string CountryName { get; set; }

        [JsonProperty("postalCode")]
        public string PostalCode { get; set; }

        [JsonProperty("notes")]
        public Note[] Notes { get; set; }
    }

    public class BulkResponseItemOfString
    {
        [JsonProperty("statusCode")]
        public int StatusCode { get; set; }

        [JsonProperty("response")]
        public string Response { get; set; }

        [JsonProperty("error")]
        public ErrorObject Error { get; set; }

        [JsonProperty("request")]
        public string Request { get; set; }
    }

    public class ErrorObject
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class BulkResponseItemOfDeliveryNode
    {
        [JsonProperty("statusCode")]
        public int StatusCode { get; set; }

        [JsonProperty("response")]
        public DeliveryNode Response { get; set; }

        [JsonProperty("error")]
        public ErrorObject Error { get; set; }

        [JsonProperty("request")]
        public DeliveryNode Request { get; set; }
    }

    public class GenerateFulfillmentOptionsResponse
    {
        [JsonProperty("fulfillmentOptions")]
        public FulfillmentOption[] FulfillmentOptions { get; set; }
    }

    public class FulfillmentOption
    {
        [JsonProperty("fulfillmentOptionId")]
        public string FulfillmentOptionId { get; set; }

        [JsonProperty("shipmentToLocation")]
        public Location ShipmentToLocation { get; set; }

        [JsonProperty("overallCost")]
        public Amount OverallCost { get; set; }

        [JsonProperty("earliestDeliveryTime")]
        public string EarliestDeliveryTime { get; set; }

        [JsonProperty("latestDeliveryTime")]
        public string LatestDeliveryTime { get; set; }

        [JsonProperty("expirationTime")]
        public string ExpirationTime { get; set; }

        [JsonProperty("fulfillmentPlans")]
        public FulfillmentPlan[] FulfillmentPlans { get; set; }
    }

    public class Amount
    {
        [JsonProperty("value")]
        public double Value { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class FulfillmentPlan
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("warehouseId")]
        public string WarehouseId { get; set; }

        [JsonProperty("scheduledExecutionTime")]
        public string ScheduledExecutionTime { get; set; }

        [JsonProperty("orderLines")]
        public OrderLine[] OrderLines { get; set; }

        [JsonProperty("shipments")]
        public Shipment[] Shipments { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("statusReason")]
        public string StatusReason { get; set; }

        [JsonProperty("creationTime")]
        public string CreationTime { get; set; }
    }

    public class OrderLine
    {
        [JsonProperty("orderId")]
        public string OrderId { get; set; }

        [JsonProperty("itemSKU")]
        public string ItemSKU { get; set; }

        [JsonProperty("quantity")]
        public int Quantity { get; set; }

        [JsonProperty("plannedEarliestDeliveryDateTime")]
        public string PlannedEarliestDeliveryDateTime { get; set; }

        [JsonProperty("plannedLatestDeliveryDateTime")]
        public string PlannedLatestDeliveryDateTime { get; set; }
    }

    public class Shipment
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("shipmentOrderIds")]
        public string[] ShipmentOrderIds { get; set; }

        [JsonProperty("shipmentLocationData")]
        public ShipmentLocation[] ShipmentLocationData { get; set; }

        [JsonProperty("shipmentPackingData")]
        public ShipmentPackingData ShipmentPackingData { get; set; }

        [JsonProperty("shipmentCharge")]
        public ShipmentCharge ShipmentCharge { get; set; }

        [JsonProperty("shipmentReferenceData")]
        public ShipmentReferenceData ShipmentReferenceData { get; set; }

        [JsonProperty("shipmentItems")]
        public ShipmentItem[] ShipmentItems { get; set; }

        [JsonProperty("estimatedPickupTime")]
        public string EstimatedPickupTime { get; set; }

        [JsonProperty("estimatedEarliestPickupTime")]
        public string EstimatedEarliestPickupTime { get; set; }

        [JsonProperty("estimatedLatestPickupTime")]
        public string EstimatedLatestPickupTime { get; set; }

        [JsonProperty("estimatedDeliveryTime")]
        public string EstimatedDeliveryTime { get; set; }

        [JsonProperty("estimatedEarliestDeliveryTime")]
        public string EstimatedEarliestDeliveryTime { get; set; }

        [JsonProperty("estimatedLatestDeliveryTime")]
        public string EstimatedLatestDeliveryTime { get; set; }

        [JsonProperty("shipmentContentData")]
        public ShipmentContentData ShipmentContentData { get; set; }

        [JsonProperty("lastModifiedTime")]
        public string LastModifiedTime { get; set; }

        [JsonProperty("deliveryInstructions")]
        public JToken DeliveryInstructions { get; set; }

        [JsonProperty("customAttributes")]
        public JToken CustomAttributes { get; set; }

        [JsonProperty("carrierName")]
        public string CarrierName { get; set; }
    }

    public class ShipmentLocation
    {
        [JsonProperty("shipmentNodeType")]
        public string ShipmentNodeType { get; set; }

        [JsonProperty("locationType")]
        public string LocationType { get; set; }

        [JsonProperty("contactName")]
        public string ContactName { get; set; }

        [JsonProperty("contactNumber")]
        public string ContactNumber { get; set; }

        [JsonProperty("location")]
        public Location Location { get; set; }

        [JsonProperty("customAttributes")]
        public JToken CustomAttributes { get; set; }
    }

    public class ShipmentPackingData
    {
        [JsonProperty("shipmentVolume")]
        public double ShipmentVolume { get; set; }

        [JsonProperty("shipmentNetWeight")]
        public double ShipmentNetWeight { get; set; }

        [JsonProperty("volumeUnitOfMeasure")]
        public string VolumeUnitOfMeasure { get; set; }

        [JsonProperty("weightUnitOfMeasure")]
        public string WeightUnitOfMeasure { get; set; }

        [JsonProperty("shipmentLength")]
        public double ShipmentLength { get; set; }

        [JsonProperty("shipmentWidth")]
        public double ShipmentWidth { get; set; }

        [JsonProperty("shipmentHeight")]
        public double ShipmentHeight { get; set; }

        [JsonProperty("lwhUnitOfMeasure")]
        public string LwhUnitOfMeasure { get; set; }

        [JsonProperty("shipmentPackingType")]
        public string ShipmentPackingType { get; set; }
    }

    public class ShipmentCharge
    {
        [JsonProperty("estimatedCost")]
        public double EstimatedCost { get; set; }

        [JsonProperty("currencyCode")]
        public string CurrencyCode { get; set; }

        [JsonProperty("billingData")]
        public BillingData BillingData { get; set; }

        [JsonProperty("componentCharges")]
        public ComponentCharge[] ComponentCharges { get; set; }
    }

    public class BillingData
    {
        [JsonProperty("customerId")]
        public string CustomerId { get; set; }

        [JsonProperty("customerName")]
        public string CustomerName { get; set; }

        [JsonProperty("customAttributes")]
        public JToken CustomAttributes { get; set; }
    }

    public class ComponentCharge
    {
        [JsonProperty("totalComponentCharge")]
        public double TotalComponentCharge { get; set; }

        [JsonProperty("chargeTypeId")]
        public string ChargeTypeId { get; set; }

        [JsonProperty("chargeTypeName")]
        public string ChargeTypeName { get; set; }

        [JsonProperty("isOptional")]
        public bool IsOptional { get; set; }
    }

    public class ShipmentReferenceData
    {
        [JsonProperty("trackingNumber")]
        public string TrackingNumber { get; set; }

        [JsonProperty("trackingUrl")]
        public string TrackingUrl { get; set; }

        [JsonProperty("shipLabelUrl")]
        public string ShipLabelUrl { get; set; }
    }

    public class ShipmentItem
    {
        [JsonProperty("itemSKU")]
        public string ItemSKU { get; set; }

        [JsonProperty("quantity")]
        public int Quantity { get; set; }
    }

    public class ShipmentContentData
    {
        [JsonProperty("isFragile")]
        public bool IsFragile { get; set; }

        [JsonProperty("includesBattery")]
        public bool IncludesBattery { get; set; }
    }

    public class Item
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("barcodes")]
        public Barcode[] Barcodes { get; set; }

        [JsonProperty("weight")]
        public double Weight { get; set; }

        [JsonProperty("length")]
        public double Length { get; set; }

        [JsonProperty("width")]
        public double Width { get; set; }

        [JsonProperty("depth")]
        public double Depth { get; set; }

        [JsonProperty("lwhUnitOfMeasure")]
        public ItemLwhUnitOfMeasureType LwhUnitOfMeasure { get; set; }

        [JsonProperty("weightUnitOfMeasure")]
        public ItemWeightUnitOfMeasureType WeightUnitOfMeasure { get; set; }

        [JsonProperty("lastModifiedTime")]
        public string LastModifiedTime { get; set; }

        [JsonProperty("sku")]
        public string Sku { get; set; }

        [JsonProperty("labels")]
        public string[] Labels { get; set; }
    }

    public class Barcode
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("standardName")]
        public string StandardName { get; set; }
    }

    public class ItemLwhUnitOfMeasureType
    {
        [JsonProperty("abbreviation")]
        public string Abbreviation { get; set; }
    }

    public class ItemWeightUnitOfMeasureType
    {
        [JsonProperty("abbreviation")]
        public string Abbreviation { get; set; }
    }

    public class AvailableWarehouseItems
    {
        [JsonProperty("warehouseId")]
        public string WarehouseId { get; set; }

        [JsonProperty("availableItems")]
        public WarehouseItem[] AvailableItems { get; set; }
    }

    public class WarehouseItem
    {
        [JsonProperty("availableToPromiseQuantity")]
        public int AvailableToPromiseQuantity { get; set; }

        [JsonProperty("itemSKU")]
        public string ItemSKU { get; set; }

        [JsonProperty("warehouseId")]
        public string WarehouseId { get; set; }

        [JsonProperty("lastModifiedTime")]
        public string LastModifiedTime { get; set; }
    }

    public class BulkResponseItemOfItem
    {
        [JsonProperty("statusCode")]
        public int StatusCode { get; set; }

        [JsonProperty("response")]
        public Item Response { get; set; }

        [JsonProperty("error")]
        public ErrorObject Error { get; set; }

        [JsonProperty("request")]
        public Item Request { get; set; }
    }

    public class OrderFulfillment
    {
        [JsonProperty("orderLines")]
        public OrderLine[] OrderLines { get; set; }

        [JsonProperty("shipmentToLocation")]
        public Location ShipmentToLocation { get; set; }

        [JsonProperty("shipmentToName")]
        public string ShipmentToName { get; set; }

        [JsonProperty("shipmentReceiverContact")]
        public string ShipmentReceiverContact { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("fulfillmentPlanIds")]
        public string[] FulfillmentPlanIds { get; set; }

        [JsonProperty("creationTime")]
        public string CreationTime { get; set; }

        [JsonProperty("lastModifiedTime")]
        public string LastModifiedTime { get; set; }

        [JsonProperty("notes")]
        public Note[] Notes { get; set; }
    }

    public class ShipmentOrder
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("shipmentId")]
        public string ShipmentId { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("shipmentItems")]
        public ShipmentItem[] ShipmentItems { get; set; }

        [JsonProperty("shipmentLocationData")]
        public ShipmentLocation[] ShipmentLocationData { get; set; }

        [JsonProperty("shipmentPackingData")]
        public ShipmentPackingData ShipmentPackingData { get; set; }

        [JsonProperty("shipmentCharge")]
        public ShipmentCharge ShipmentCharge { get; set; }

        [JsonProperty("plannedPickupTime")]
        public string PlannedPickupTime { get; set; }

        [JsonProperty("plannedEarliestPickupTime")]
        public string PlannedEarliestPickupTime { get; set; }

        [JsonProperty("plannedLatestPickupTime")]
        public string PlannedLatestPickupTime { get; set; }

        [JsonProperty("plannedDeliveryTime")]
        public string PlannedDeliveryTime { get; set; }

        [JsonProperty("plannedEarliestDeliveryTime")]
        public string PlannedEarliestDeliveryTime { get; set; }

        [JsonProperty("plannedLatestDeliveryTime")]
        public string PlannedLatestDeliveryTime { get; set; }

        [JsonProperty("shipmentContentData")]
        public ShipmentContentData ShipmentContentData { get; set; }

        [JsonProperty("deliveryInstructions")]
        public JToken DeliveryInstructions { get; set; }

        [JsonProperty("customAttributes")]
        public JToken CustomAttributes { get; set; }

        [JsonProperty("lastModifiedTime")]
        public string LastModifiedTime { get; set; }
    }

    public class BulkResponseItemOfShipmentOrder
    {
        [JsonProperty("statusCode")]
        public int StatusCode { get; set; }

        [JsonProperty("response")]
        public ShipmentOrder Response { get; set; }

        [JsonProperty("error")]
        public ErrorObject Error { get; set; }

        [JsonProperty("request")]
        public ShipmentOrder Request { get; set; }
    }

    public class ShipmentQuote
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("shipmentQuoteRequestId")]
        public string ShipmentQuoteRequestId { get; set; }

        [JsonProperty("shipmentCharge")]
        public ShipmentCharge ShipmentCharge { get; set; }

        [JsonProperty("plannedPickupTime")]
        public string PlannedPickupTime { get; set; }

        [JsonProperty("plannedDeliveryTime")]
        public string PlannedDeliveryTime { get; set; }

        [JsonProperty("carrierData")]
        public CarrierData CarrierData { get; set; }

        [JsonProperty("customAttributes")]
        public JToken CustomAttributes { get; set; }

        [JsonProperty("lastModifiedTime")]
        public string LastModifiedTime { get; set; }
    }

    public class CarrierData
    {
        [JsonProperty("carrierId")]
        public string CarrierId { get; set; }

        [JsonProperty("carrierName")]
        public string CarrierName { get; set; }
    }

    public class ShipmentQuoteRequest
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("shipmentItems")]
        public ShipmentItem[] ShipmentItems { get; set; }

        [JsonProperty("shipmentLocationData")]
        public ShipmentLocation[] ShipmentLocationData { get; set; }

        [JsonProperty("shipmentPackingData")]
        public ShipmentPackingData ShipmentPackingData { get; set; }

        [JsonProperty("shipmentQuoteIds")]
        public string[] ShipmentQuoteIds { get; set; }

        [JsonProperty("plannedPickupTime")]
        public string PlannedPickupTime { get; set; }

        [JsonProperty("plannedDeliveryTime")]
        public string PlannedDeliveryTime { get; set; }

        [JsonProperty("lastModifiedTime")]
        public string LastModifiedTime { get; set; }
    }

    public class Warehouse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("hoursOfOperations")]
        public HoursOfOperation[] HoursOfOperations { get; set; }

        [JsonProperty("location")]
        public Location Location { get; set; }

        [JsonProperty("labels")]
        public string[] Labels { get; set; }

        [JsonProperty("lastModifiedTime")]
        public string LastModifiedTime { get; set; }

        [JsonProperty("pickAndPackLeadTime")]
        public int PickAndPackLeadTime { get; set; }

        [JsonProperty("carrierReferences")]
        public CarrierReference[] CarrierReferences { get; set; }
    }

    public class CarrierReference
    {
        [JsonProperty("carrierId")]
        public string CarrierId { get; set; }

        [JsonProperty("cutoffTime")]
        public string CutoffTime { get; set; }

        [JsonProperty("servingLocations")]
        public Location[] ServingLocations { get; set; }

        [JsonProperty("servingNodeIds")]
        public string[] ServingNodeIds { get; set; }
    }

    public class BulkResponseItemOfWarehouse
    {
        [JsonProperty("statusCode")]
        public int StatusCode { get; set; }

        [JsonProperty("response")]
        public Warehouse Response { get; set; }

        [JsonProperty("error")]
        public ErrorObject Error { get; set; }

        [JsonProperty("request")]
        public Warehouse Request { get; set; }
    }

    public class BulkResponseItemOfWarehouseItem
    {
        [JsonProperty("statusCode")]
        public int StatusCode { get; set; }

        [JsonProperty("response")]
        public WarehouseItem Response { get; set; }

        [JsonProperty("error")]
        public ErrorObject Error { get; set; }

        [JsonProperty("request")]
        public WarehouseItem Request { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Opensupplychainplatf;

    public partial class WorkflowManagedActions
    {
        public OpensupplychainplatfActions Opensupplychainplatf(string connectionId) => new OpensupplychainplatfActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public OpensupplychainplatfTriggers Opensupplychainplatf(string connectionId) => new OpensupplychainplatfTriggers(connectionId);
    }
}