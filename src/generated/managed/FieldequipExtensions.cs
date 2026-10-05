//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Fieldequip
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class FieldequipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fieldequip")]
        [WorkflowExpressionFactory(nameof(__BuildCreateCustomer))]
        public IWorkflowAction CreateCustomer([WorkflowExpression] Func<string> xApiKey, [WorkflowExpression] Func<string> xOrigin, [WorkflowExpression] Func<string> companyId = null, [WorkflowExpression] Func<bodyInputItem[]> body = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildCreateCustomer(WorkflowValue<string> xApiKey, WorkflowValue<string> xOrigin, WorkflowValue<string> companyId = null, WorkflowValue<bodyInputItem[]> body = null)
        {
            WorkflowValue.Validate(xApiKey, nameof(xApiKey), required: true);
            WorkflowValue.Validate(xOrigin, nameof(xOrigin), required: true);
            WorkflowValue.Validate(companyId, nameof(companyId), required: false);
            WorkflowValue.Validate(body, nameof(body), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/api/v1/customer/create";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (companyId != null)
                    callPayload.Queries["companyId"] = ExpressionConverter.Convert(companyId);
                callPayload.Headers["x-api-key"] = ExpressionConverter.Convert(xApiKey);
                callPayload.Headers["x-origin"] = ExpressionConverter.Convert(xOrigin);
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fieldequip")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateCustomer))]
        public IWorkflowAction UpdateCustomer([WorkflowExpression] Func<string> xApiKey, [WorkflowExpression] Func<string> xOrigin, [WorkflowExpression] Func<string> companyId = null, [WorkflowExpression] Func<bodyInputItem[]> body = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildUpdateCustomer(WorkflowValue<string> xApiKey, WorkflowValue<string> xOrigin, WorkflowValue<string> companyId = null, WorkflowValue<bodyInputItem[]> body = null)
        {
            WorkflowValue.Validate(xApiKey, nameof(xApiKey), required: true);
            WorkflowValue.Validate(xOrigin, nameof(xOrigin), required: true);
            WorkflowValue.Validate(companyId, nameof(companyId), required: false);
            WorkflowValue.Validate(body, nameof(body), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/api/v1/customer/update";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (companyId != null)
                    callPayload.Queries["companyId"] = ExpressionConverter.Convert(companyId);
                callPayload.Headers["x-api-key"] = ExpressionConverter.Convert(xApiKey);
                callPayload.Headers["x-origin"] = ExpressionConverter.Convert(xOrigin);
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fieldequip")]
        [WorkflowExpressionFactory(nameof(__BuildCreateWorkOrders))]
        public IWorkflowAction CreateWorkOrders([WorkflowExpression] Func<string> xApiKey, [WorkflowExpression] Func<string> xOrigin, [WorkflowExpression] Func<string> companyId = null, [WorkflowExpression] Func<bodyInputItem2[]> body = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildCreateWorkOrders(WorkflowValue<string> xApiKey, WorkflowValue<string> xOrigin, WorkflowValue<string> companyId = null, WorkflowValue<bodyInputItem2[]> body = null)
        {
            WorkflowValue.Validate(xApiKey, nameof(xApiKey), required: true);
            WorkflowValue.Validate(xOrigin, nameof(xOrigin), required: true);
            WorkflowValue.Validate(companyId, nameof(companyId), required: false);
            WorkflowValue.Validate(body, nameof(body), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/api/v3/workorder/create";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (companyId != null)
                    callPayload.Queries["companyId"] = ExpressionConverter.Convert(companyId);
                callPayload.Headers["x-api-key"] = ExpressionConverter.Convert(xApiKey);
                callPayload.Headers["x-origin"] = ExpressionConverter.Convert(xOrigin);
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fieldequip")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateWorkOrders))]
        public IWorkflowAction UpdateWorkOrders([WorkflowExpression] Func<string> xApiKey, [WorkflowExpression] Func<string> xOrigin, [WorkflowExpression] Func<string> companyId = null, [WorkflowExpression] Func<bodyInputItem2[]> body = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildUpdateWorkOrders(WorkflowValue<string> xApiKey, WorkflowValue<string> xOrigin, WorkflowValue<string> companyId = null, WorkflowValue<bodyInputItem2[]> body = null)
        {
            WorkflowValue.Validate(xApiKey, nameof(xApiKey), required: true);
            WorkflowValue.Validate(xOrigin, nameof(xOrigin), required: true);
            WorkflowValue.Validate(companyId, nameof(companyId), required: false);
            WorkflowValue.Validate(body, nameof(body), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/api/v3/workorder/update";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (companyId != null)
                    callPayload.Queries["companyId"] = ExpressionConverter.Convert(companyId);
                callPayload.Headers["x-api-key"] = ExpressionConverter.Convert(xApiKey);
                callPayload.Headers["x-origin"] = ExpressionConverter.Convert(xOrigin);
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fieldequip")]
        [WorkflowExpressionFactory(nameof(__BuildCreateItems))]
        public IWorkflowAction CreateItems([WorkflowExpression] Func<string> xApiKey, [WorkflowExpression] Func<string> xOrigin, [WorkflowExpression] Func<string> companyId = null, [WorkflowExpression] Func<bodyInputItem22[]> body = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildCreateItems(WorkflowValue<string> xApiKey, WorkflowValue<string> xOrigin, WorkflowValue<string> companyId = null, WorkflowValue<bodyInputItem22[]> body = null)
        {
            WorkflowValue.Validate(xApiKey, nameof(xApiKey), required: true);
            WorkflowValue.Validate(xOrigin, nameof(xOrigin), required: true);
            WorkflowValue.Validate(companyId, nameof(companyId), required: false);
            WorkflowValue.Validate(body, nameof(body), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/api/v1/item/create";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (companyId != null)
                    callPayload.Queries["companyId"] = ExpressionConverter.Convert(companyId);
                callPayload.Headers["x-api-key"] = ExpressionConverter.Convert(xApiKey);
                callPayload.Headers["x-origin"] = ExpressionConverter.Convert(xOrigin);
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fieldequip")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateItems))]
        public IWorkflowAction UpdateItems([WorkflowExpression] Func<string> xApiKey, [WorkflowExpression] Func<string> xOrigin, [WorkflowExpression] Func<string> companyId = null, [WorkflowExpression] Func<bodyInputItem22[]> body = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildUpdateItems(WorkflowValue<string> xApiKey, WorkflowValue<string> xOrigin, WorkflowValue<string> companyId = null, WorkflowValue<bodyInputItem22[]> body = null)
        {
            WorkflowValue.Validate(xApiKey, nameof(xApiKey), required: true);
            WorkflowValue.Validate(xOrigin, nameof(xOrigin), required: true);
            WorkflowValue.Validate(companyId, nameof(companyId), required: false);
            WorkflowValue.Validate(body, nameof(body), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/api/v1/item/update";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (companyId != null)
                    callPayload.Queries["companyId"] = ExpressionConverter.Convert(companyId);
                callPayload.Headers["x-api-key"] = ExpressionConverter.Convert(xApiKey);
                callPayload.Headers["x-origin"] = ExpressionConverter.Convert(xOrigin);
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fieldequip")]
        [WorkflowExpressionFactory(nameof(__BuildCreateInventory))]
        public IWorkflowAction CreateInventory([WorkflowExpression] Func<string> xApiKey, [WorkflowExpression] Func<string> xOrigin, [WorkflowExpression] Func<string> companyId = null, [WorkflowExpression] Func<string> warehouseRefNum = null, [WorkflowExpression] Func<bodyInputItem222[]> body = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildCreateInventory(WorkflowValue<string> xApiKey, WorkflowValue<string> xOrigin, WorkflowValue<string> companyId = null, WorkflowValue<string> warehouseRefNum = null, WorkflowValue<bodyInputItem222[]> body = null)
        {
            WorkflowValue.Validate(xApiKey, nameof(xApiKey), required: true);
            WorkflowValue.Validate(xOrigin, nameof(xOrigin), required: true);
            WorkflowValue.Validate(companyId, nameof(companyId), required: false);
            WorkflowValue.Validate(warehouseRefNum, nameof(warehouseRefNum), required: false);
            WorkflowValue.Validate(body, nameof(body), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/api/v1/warehouse/inventory";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (companyId != null)
                    callPayload.Queries["companyId"] = ExpressionConverter.Convert(companyId);
                if (warehouseRefNum != null)
                    callPayload.Queries["warehouseRefNum"] = ExpressionConverter.Convert(warehouseRefNum);
                callPayload.Headers["x-api-key"] = ExpressionConverter.Convert(xApiKey);
                callPayload.Headers["x-origin"] = ExpressionConverter.Convert(xOrigin);
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fieldequip")]
        [WorkflowExpressionFactory(nameof(__BuildCreateItemAdjustment))]
        public IWorkflowAction CreateItemAdjustment([WorkflowExpression] Func<string> xApiKey, [WorkflowExpression] Func<string> xOrigin, [WorkflowExpression] Func<string> companyId = null, [WorkflowExpression] Func<string> warehouseRefNum = null, [WorkflowExpression] Func<bodyInputItem2222[]> body = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildCreateItemAdjustment(WorkflowValue<string> xApiKey, WorkflowValue<string> xOrigin, WorkflowValue<string> companyId = null, WorkflowValue<string> warehouseRefNum = null, WorkflowValue<bodyInputItem2222[]> body = null)
        {
            WorkflowValue.Validate(xApiKey, nameof(xApiKey), required: true);
            WorkflowValue.Validate(xOrigin, nameof(xOrigin), required: true);
            WorkflowValue.Validate(companyId, nameof(companyId), required: false);
            WorkflowValue.Validate(warehouseRefNum, nameof(warehouseRefNum), required: false);
            WorkflowValue.Validate(body, nameof(body), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/api/v1/warehouse/inventory/adjustment";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (companyId != null)
                    callPayload.Queries["companyId"] = ExpressionConverter.Convert(companyId);
                if (warehouseRefNum != null)
                    callPayload.Queries["warehouseRefNum"] = ExpressionConverter.Convert(warehouseRefNum);
                callPayload.Headers["x-api-key"] = ExpressionConverter.Convert(xApiKey);
                callPayload.Headers["x-origin"] = ExpressionConverter.Convert(xOrigin);
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fieldequip")]
        [WorkflowExpressionFactory(nameof(__BuildCreateLocations))]
        public IWorkflowAction CreateLocations([WorkflowExpression] Func<string> companyId, [WorkflowExpression] Func<string> xApiKey, [WorkflowExpression] Func<string> xOrigin, [WorkflowExpression] Func<bodyInputItem22222[]> body = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildCreateLocations(WorkflowValue<string> companyId, WorkflowValue<string> xApiKey, WorkflowValue<string> xOrigin, WorkflowValue<bodyInputItem22222[]> body = null)
        {
            WorkflowValue.Validate(companyId, nameof(companyId), required: true);
            WorkflowValue.Validate(xApiKey, nameof(xApiKey), required: true);
            WorkflowValue.Validate(xOrigin, nameof(xOrigin), required: true);
            WorkflowValue.Validate(body, nameof(body), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/api/v1/location/create";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["companyId"] = ExpressionConverter.Convert(companyId);
                callPayload.Headers["x-api-key"] = ExpressionConverter.Convert(xApiKey);
                callPayload.Headers["x-origin"] = ExpressionConverter.Convert(xOrigin);
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fieldequip")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateLocations))]
        public IWorkflowAction UpdateLocations([WorkflowExpression] Func<string> companyId, [WorkflowExpression] Func<string> xApiKey, [WorkflowExpression] Func<string> xOrigin, [WorkflowExpression] Func<bodyInputItem22222[]> body = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildUpdateLocations(WorkflowValue<string> companyId, WorkflowValue<string> xApiKey, WorkflowValue<string> xOrigin, WorkflowValue<bodyInputItem22222[]> body = null)
        {
            WorkflowValue.Validate(companyId, nameof(companyId), required: true);
            WorkflowValue.Validate(xApiKey, nameof(xApiKey), required: true);
            WorkflowValue.Validate(xOrigin, nameof(xOrigin), required: true);
            WorkflowValue.Validate(body, nameof(body), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/api/v1/location/update";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["companyId"] = ExpressionConverter.Convert(companyId);
                callPayload.Headers["x-api-key"] = ExpressionConverter.Convert(xApiKey);
                callPayload.Headers["x-origin"] = ExpressionConverter.Convert(xOrigin);
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fieldequip")]
        [WorkflowExpressionFactory(nameof(__BuildCreateUsers))]
        public IWorkflowAction CreateUsers([WorkflowExpression] Func<string> companyId, [WorkflowExpression] Func<string> xApiKey, [WorkflowExpression] Func<string> xOrigin, [WorkflowExpression] Func<bodyInputItem222222[]> body = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildCreateUsers(WorkflowValue<string> companyId, WorkflowValue<string> xApiKey, WorkflowValue<string> xOrigin, WorkflowValue<bodyInputItem222222[]> body = null)
        {
            WorkflowValue.Validate(companyId, nameof(companyId), required: true);
            WorkflowValue.Validate(xApiKey, nameof(xApiKey), required: true);
            WorkflowValue.Validate(xOrigin, nameof(xOrigin), required: true);
            WorkflowValue.Validate(body, nameof(body), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/api/v1/user/create";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["companyId"] = ExpressionConverter.Convert(companyId);
                callPayload.Headers["x-api-key"] = ExpressionConverter.Convert(xApiKey);
                callPayload.Headers["x-origin"] = ExpressionConverter.Convert(xOrigin);
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fieldequip")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateUsers))]
        public IWorkflowAction UpdateUsers([WorkflowExpression] Func<string> companyId, [WorkflowExpression] Func<string> xApiKey, [WorkflowExpression] Func<string> xOrigin, [WorkflowExpression] Func<string> bodycompanyId = null, [WorkflowExpression] Func<string> bodyfirstName = null, [WorkflowExpression] Func<string> bodylastName = null, [WorkflowExpression] Func<string> bodyemail = null, [WorkflowExpression] Func<string> bodybusinessUnitCode = null, [WorkflowExpression] Func<string> bodydepartmentCode = null, [WorkflowExpression] Func<string> bodypayrollCode = null, [WorkflowExpression] Func<string> bodyplantId = null, [WorkflowExpression] Func<string> bodyempId = null, [WorkflowExpression] Func<string> bodymobileNumber = null, [WorkflowExpression] Func<string> bodyreportingManager = null, [WorkflowExpression] Func<string> bodyempType = null, [WorkflowExpression] Func<string> bodystateCode = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildUpdateUsers(WorkflowValue<string> companyId, WorkflowValue<string> xApiKey, WorkflowValue<string> xOrigin, WorkflowValue<string> bodycompanyId = null, WorkflowValue<string> bodyfirstName = null, WorkflowValue<string> bodylastName = null, WorkflowValue<string> bodyemail = null, WorkflowValue<string> bodybusinessUnitCode = null, WorkflowValue<string> bodydepartmentCode = null, WorkflowValue<string> bodypayrollCode = null, WorkflowValue<string> bodyplantId = null, WorkflowValue<string> bodyempId = null, WorkflowValue<string> bodymobileNumber = null, WorkflowValue<string> bodyreportingManager = null, WorkflowValue<string> bodyempType = null, WorkflowValue<string> bodystateCode = null)
        {
            WorkflowValue.Validate(companyId, nameof(companyId), required: true);
            WorkflowValue.Validate(xApiKey, nameof(xApiKey), required: true);
            WorkflowValue.Validate(xOrigin, nameof(xOrigin), required: true);
            WorkflowValue.Validate(bodycompanyId, nameof(bodycompanyId), required: false);
            WorkflowValue.Validate(bodyfirstName, nameof(bodyfirstName), required: false);
            WorkflowValue.Validate(bodylastName, nameof(bodylastName), required: false);
            WorkflowValue.Validate(bodyemail, nameof(bodyemail), required: false);
            WorkflowValue.Validate(bodybusinessUnitCode, nameof(bodybusinessUnitCode), required: false);
            WorkflowValue.Validate(bodydepartmentCode, nameof(bodydepartmentCode), required: false);
            WorkflowValue.Validate(bodypayrollCode, nameof(bodypayrollCode), required: false);
            WorkflowValue.Validate(bodyplantId, nameof(bodyplantId), required: false);
            WorkflowValue.Validate(bodyempId, nameof(bodyempId), required: false);
            WorkflowValue.Validate(bodymobileNumber, nameof(bodymobileNumber), required: false);
            WorkflowValue.Validate(bodyreportingManager, nameof(bodyreportingManager), required: false);
            WorkflowValue.Validate(bodyempType, nameof(bodyempType), required: false);
            WorkflowValue.Validate(bodystateCode, nameof(bodystateCode), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/api/v1/user/update";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["companyId"] = ExpressionConverter.Convert(companyId);
                callPayload.Headers["x-api-key"] = ExpressionConverter.Convert(xApiKey);
                callPayload.Headers["x-origin"] = ExpressionConverter.Convert(xOrigin);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodycompanyId != null)
                {
                    body["companyId"] = ExpressionConverter.ConvertO(bodycompanyId);
                    bodypropCount++;
                }

                if (bodyfirstName != null)
                {
                    body["firstName"] = ExpressionConverter.ConvertO(bodyfirstName);
                    bodypropCount++;
                }

                if (bodylastName != null)
                {
                    body["lastName"] = ExpressionConverter.ConvertO(bodylastName);
                    bodypropCount++;
                }

                if (bodyemail != null)
                {
                    body["email"] = ExpressionConverter.ConvertO(bodyemail);
                    bodypropCount++;
                }

                if (bodybusinessUnitCode != null)
                {
                    body["businessUnitCode"] = ExpressionConverter.ConvertO(bodybusinessUnitCode);
                    bodypropCount++;
                }

                if (bodydepartmentCode != null)
                {
                    body["departmentCode"] = ExpressionConverter.ConvertO(bodydepartmentCode);
                    bodypropCount++;
                }

                if (bodypayrollCode != null)
                {
                    body["payrollCode"] = ExpressionConverter.ConvertO(bodypayrollCode);
                    bodypropCount++;
                }

                if (bodyplantId != null)
                {
                    body["plantId"] = ExpressionConverter.ConvertO(bodyplantId);
                    bodypropCount++;
                }

                if (bodyempId != null)
                {
                    body["empId"] = ExpressionConverter.ConvertO(bodyempId);
                    bodypropCount++;
                }

                if (bodymobileNumber != null)
                {
                    body["mobileNumber"] = ExpressionConverter.ConvertO(bodymobileNumber);
                    bodypropCount++;
                }

                if (bodyreportingManager != null)
                {
                    body["reportingManager"] = ExpressionConverter.ConvertO(bodyreportingManager);
                    bodypropCount++;
                }

                if (bodyempType != null)
                {
                    body["empType"] = ExpressionConverter.ConvertO(bodyempType);
                    bodypropCount++;
                }

                if (bodystateCode != null)
                {
                    body["stateCode"] = ExpressionConverter.ConvertO(bodystateCode);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class FieldequipTriggers([ConnectionName] string connectionId)
    {
    }

    public class bodyInputItem
    {
        [JsonProperty("companyId")]
        public string CompanyId { get; set; }

        [JsonProperty("customerId")]
        public string CustomerId { get; set; }

        [JsonProperty("customerName")]
        public string CustomerName { get; set; }

        [JsonProperty("businessUnitCode")]
        public string BusinessUnitCode { get; set; }

        [JsonProperty("extCustomerRefNum")]
        public string ExtCustomerRefNum { get; set; }

        [JsonProperty("billingAddress1")]
        public string BillingAddress1 { get; set; }

        [JsonProperty("billingAddress2")]
        public string BillingAddress2 { get; set; }

        [JsonProperty("billingCity")]
        public string BillingCity { get; set; }

        [JsonProperty("billingState")]
        public string BillingState { get; set; }

        [JsonProperty("billingZipCode")]
        public string BillingZipCode { get; set; }

        [JsonProperty("billingCountryCode")]
        public string BillingCountryCode { get; set; }

        [JsonProperty("customerPhone")]
        public string CustomerPhone { get; set; }

        [JsonProperty("customerStatus")]
        public string CustomerStatus { get; set; }

        [JsonProperty("contactId")]
        public string ContactId { get; set; }

        [JsonProperty("contactName")]
        public string ContactName { get; set; }

        [JsonProperty("contactEmail")]
        public string ContactEmail { get; set; }

        [JsonProperty("contactPhone")]
        public string ContactPhone { get; set; }

        [JsonProperty("shipToName")]
        public string ShipToName { get; set; }

        [JsonProperty("shipToAddress1")]
        public string ShipToAddress1 { get; set; }

        [JsonProperty("shipToAddress2")]
        public string ShipToAddress2 { get; set; }

        [JsonProperty("shipToCity")]
        public string ShipToCity { get; set; }

        [JsonProperty("shipToState")]
        public string ShipToState { get; set; }

        [JsonProperty("shipToZipCode")]
        public string ShipToZipCode { get; set; }

        [JsonProperty("shipToCountryCode")]
        public string ShipToCountryCode { get; set; }
    }

    public class bodyInputItem2
    {
        [JsonProperty("companyId")]
        public string CompanyId { get; set; }

        [JsonProperty("orderId")]
        public string OrderId { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("priority")]
        public string Priority { get; set; }

        [JsonProperty("criticality")]
        public string Criticality { get; set; }

        [JsonProperty("alarming")]
        public bool Alarming { get; set; }

        [JsonProperty("reportedTime")]
        public string ReportedTime { get; set; }

        [JsonProperty("sourceSys")]
        public string SourceSys { get; set; }

        [JsonProperty("sourceKey")]
        public string SourceKey { get; set; }

        [JsonProperty("sparse")]
        public bool Sparse { get; set; }
    }

    public class bodyInputItem22
    {
        [JsonProperty("companyId")]
        public string CompanyId { get; set; }

        [JsonProperty("itemId")]
        public string ItemId { get; set; }

        [JsonProperty("itemName")]
        public string ItemName { get; set; }

        [JsonProperty("itemDescription")]
        public string ItemDescription { get; set; }

        [JsonProperty("itemType")]
        public string ItemType { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("costPrice")]
        public string CostPrice { get; set; }

        [JsonProperty("listPrice")]
        public string ListPrice { get; set; }

        [JsonProperty("uomCode")]
        public string UomCode { get; set; }

        [JsonProperty("itemStatus")]
        public string ItemStatus { get; set; }

        [JsonProperty("inventoryItem")]
        public bool InventoryItem { get; set; }

        [JsonProperty("manufacturer")]
        public string Manufacturer { get; set; }

        [JsonProperty("modelNumber")]
        public string ModelNumber { get; set; }

        [JsonProperty("warrantyPeriod")]
        public string WarrantyPeriod { get; set; }

        [JsonProperty("supplier")]
        public string Supplier { get; set; }

        [JsonProperty("isSerialized")]
        public bool IsSerialized { get; set; }

        [JsonProperty("taxCode")]
        public string TaxCode { get; set; }
    }

    public class bodyInputItem222
    {
        [JsonProperty("companyId")]
        public string CompanyId { get; set; }

        [JsonProperty("warehouseRefNum")]
        public string WarehouseRefNum { get; set; }

        [JsonProperty("warehouseName")]
        public string WarehouseName { get; set; }

        [JsonProperty("items")]
        public bodyInputItemItemsTypeItem[] Items { get; set; }
    }

    public class bodyInputItemItemsTypeItem
    {
        [JsonProperty("itemId")]
        public string ItemId { get; set; }

        [JsonProperty("itemName")]
        public string ItemName { get; set; }

        [JsonProperty("unitCostPrice")]
        public string UnitCostPrice { get; set; }

        [JsonProperty("unitListPrice")]
        public string UnitListPrice { get; set; }

        [JsonProperty("qtyOnHand")]
        public double QtyOnHand { get; set; }

        [JsonProperty("qtyAvailable")]
        public double QtyAvailable { get; set; }

        [JsonProperty("qtyThreshold")]
        public double QtyThreshold { get; set; }
    }

    public class bodyInputItem2222
    {
        [JsonProperty("companyId")]
        public string CompanyId { get; set; }

        [JsonProperty("warehouseRefNum")]
        public string WarehouseRefNum { get; set; }

        [JsonProperty("warehouseName")]
        public string WarehouseName { get; set; }

        [JsonProperty("items")]
        public bodyInputItemItemsTypeItem2[] Items { get; set; }
    }

    public class bodyInputItemItemsTypeItem2
    {
        [JsonProperty("itemId")]
        public string ItemId { get; set; }

        [JsonProperty("itemName")]
        public string ItemName { get; set; }

        [JsonProperty("unitListPrice")]
        public string UnitListPrice { get; set; }

        [JsonProperty("unitCostPrice")]
        public string UnitCostPrice { get; set; }

        [JsonProperty("qty")]
        public double Qty { get; set; }

        [JsonProperty("purchaseOrder")]
        public string PurchaseOrder { get; set; }
        public string ReceiptDate { get; set; }
    }

    public class bodyInputItem22222
    {
        [JsonProperty("companyId")]
        public string CompanyId { get; set; }

        [JsonProperty("locationId")]
        public string LocationId { get; set; }

        [JsonProperty("locationName")]
        public string LocationName { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("customerId")]
        public string CustomerId { get; set; }

        [JsonProperty("customerName")]
        public string CustomerName { get; set; }

        [JsonProperty("shipToAddress1")]
        public string ShipToAddress1 { get; set; }

        [JsonProperty("shipToAddress2")]
        public string ShipToAddress2 { get; set; }

        [JsonProperty("shipToCity")]
        public string ShipToCity { get; set; }

        [JsonProperty("shipToState")]
        public string ShipToState { get; set; }

        [JsonProperty("shipToZipCode")]
        public string ShipToZipCode { get; set; }

        [JsonProperty("shipToCountryCode")]
        public string ShipToCountryCode { get; set; }

        [JsonProperty("locationStatus")]
        public string LocationStatus { get; set; }

        [JsonProperty("latitude")]
        public string Latitude { get; set; }

        [JsonProperty("longitude")]
        public string Longitude { get; set; }

        [JsonProperty("contactName")]
        public string ContactName { get; set; }

        [JsonProperty("contactEmail")]
        public string ContactEmail { get; set; }

        [JsonProperty("contactPhone")]
        public string ContactPhone { get; set; }
    }

    public class bodyInputItem222222
    {
        [JsonProperty("companyId")]
        public string CompanyId { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("businessUnitCode")]
        public string BusinessUnitCode { get; set; }

        [JsonProperty("departmentCode")]
        public string DepartmentCode { get; set; }

        [JsonProperty("payrollCode")]
        public string PayrollCode { get; set; }

        [JsonProperty("plantId")]
        public string PlantId { get; set; }

        [JsonProperty("empId")]
        public string EmpId { get; set; }

        [JsonProperty("mobileNumber")]
        public string MobileNumber { get; set; }

        [JsonProperty("reportingManager")]
        public string ReportingManager { get; set; }

        [JsonProperty("empType")]
        public string EmpType { get; set; }

        [JsonProperty("stateCode")]
        public string StateCode { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Fieldequip;

    public partial class WorkflowManagedActions
    {
        public FieldequipActions Fieldequip(string connectionId) => new FieldequipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public FieldequipTriggers Fieldequip(string connectionId) => new FieldequipTriggers(connectionId);
    }
}
