//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Optiapi
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class OptiapiActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "optiapi")]
        [WorkflowExpressionFactory(nameof(__BuildCalculateAverage))]
        public IBodyWorkflowAction<CalculateAverageResponse> CalculateAverage([WorkflowExpression] Func<string[]> bodyarray, [WorkflowExpression] Func<string> bodykey)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "optiapi")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CalculateAverageResponse> __BuildCalculateAverage(WorkflowExpression<string[]> bodyarray, WorkflowExpression<string> bodykey)
        {
            WorkflowExpression.Validate(bodyarray, nameof(bodyarray), required: true);
            WorkflowExpression.Validate(bodykey, nameof(bodykey), required: true);
            return new DeferredBodyAction<CalculateAverageResponse>(() =>
            {
                var apiCallPath = "/array/calculate-average";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["array"] = ExpressionConverter.ConvertO(bodyarray);
                bodypropCount++;
                body["key"] = ExpressionConverter.ConvertO(bodykey);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CalculateAverageResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "optiapi")]
        [WorkflowExpressionFactory(nameof(__BuildChunkAnArray))]
        public IBodyWorkflowAction<ChunkAnArrayResponse> ChunkAnArray([WorkflowExpression] Func<string[]> bodyarray, [WorkflowExpression] Func<int> bodysize)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "optiapi")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ChunkAnArrayResponse> __BuildChunkAnArray(WorkflowExpression<string[]> bodyarray, WorkflowExpression<int> bodysize)
        {
            WorkflowExpression.Validate(bodyarray, nameof(bodyarray), required: true);
            WorkflowExpression.Validate(bodysize, nameof(bodysize), required: true);
            return new DeferredBodyAction<ChunkAnArrayResponse>(() =>
            {
                var apiCallPath = "/array/chunk";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString(" application/json");
                callPayload.Headers["Accept"] = Convert.ToString(" application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["array"] = ExpressionConverter.ConvertO(bodyarray);
                bodypropCount++;
                body["size"] = ExpressionConverter.ConvertO(bodysize);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ChunkAnArrayResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "optiapi")]
        [WorkflowExpressionFactory(nameof(__BuildCombineArray))]
        public IBodyWorkflowAction<CombineArrayResponse> CombineArray([WorkflowExpression] Func<string> contentType, [WorkflowExpression] Func<string> accept, [WorkflowExpression] Func<string[]> bodykeys, [WorkflowExpression] Func<string[]> bodyvalues)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "optiapi")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CombineArrayResponse> __BuildCombineArray(WorkflowExpression<string> contentType, WorkflowExpression<string> accept, WorkflowExpression<string[]> bodykeys, WorkflowExpression<string[]> bodyvalues)
        {
            WorkflowExpression.Validate(contentType, nameof(contentType), required: true);
            WorkflowExpression.Validate(accept, nameof(accept), required: true);
            WorkflowExpression.Validate(bodykeys, nameof(bodykeys), required: true);
            WorkflowExpression.Validate(bodyvalues, nameof(bodyvalues), required: true);
            return new DeferredBodyAction<CombineArrayResponse>(() =>
            {
                var apiCallPath = "/array/combine";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(contentType);
                callPayload.Headers["Accept"] = ExpressionConverter.Convert(accept);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["keys"] = ExpressionConverter.ConvertO(bodykeys);
                bodypropCount++;
                body["values"] = ExpressionConverter.ConvertO(bodyvalues);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CombineArrayResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "optiapi")]
        [WorkflowExpressionFactory(nameof(__BuildCheckIfArrayContainAValue))]
        public IBodyWorkflowAction<CheckIfArrayContainAValueResponse> CheckIfArrayContainAValue([WorkflowExpression] Func<string[]> bodyarray, [WorkflowExpression] Func<string> bodykey, [WorkflowExpression] Func<string> bodysearch)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "optiapi")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CheckIfArrayContainAValueResponse> __BuildCheckIfArrayContainAValue(WorkflowExpression<string[]> bodyarray, WorkflowExpression<string> bodykey, WorkflowExpression<string> bodysearch)
        {
            WorkflowExpression.Validate(bodyarray, nameof(bodyarray), required: true);
            WorkflowExpression.Validate(bodykey, nameof(bodykey), required: true);
            WorkflowExpression.Validate(bodysearch, nameof(bodysearch), required: true);
            return new DeferredBodyAction<CheckIfArrayContainAValueResponse>(() =>
            {
                var apiCallPath = "/array/contains";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["array"] = ExpressionConverter.ConvertO(bodyarray);
                bodypropCount++;
                body["key"] = ExpressionConverter.ConvertO(bodykey);
                bodypropCount++;
                body["search"] = ExpressionConverter.ConvertO(bodysearch);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CheckIfArrayContainAValueResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "optiapi")]
        [WorkflowExpressionFactory(nameof(__BuildFindDifferenceBetweenArrays))]
        public IBodyWorkflowAction<FindDifferenceBetweenArraysResponse> FindDifferenceBetweenArrays([WorkflowExpression] Func<string[]> bodyarray, [WorkflowExpression] Func<string[]> bodycompare)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "optiapi")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<FindDifferenceBetweenArraysResponse> __BuildFindDifferenceBetweenArrays(WorkflowExpression<string[]> bodyarray, WorkflowExpression<string[]> bodycompare)
        {
            WorkflowExpression.Validate(bodyarray, nameof(bodyarray), required: true);
            WorkflowExpression.Validate(bodycompare, nameof(bodycompare), required: true);
            return new DeferredBodyAction<FindDifferenceBetweenArraysResponse>(() =>
            {
                var apiCallPath = "/array/difference";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString(" application/json");
                callPayload.Headers["Accept"] = Convert.ToString(" application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["array"] = ExpressionConverter.ConvertO(bodyarray);
                bodypropCount++;
                body["compare"] = ExpressionConverter.ConvertO(bodycompare);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<FindDifferenceBetweenArraysResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "optiapi")]
        [WorkflowExpressionFactory(nameof(__BuildFindDuplicatesInArrays))]
        public IBodyWorkflowAction<FindDuplicatesInArraysResponse> FindDuplicatesInArrays([WorkflowExpression] Func<string[]> bodyarray, [WorkflowExpression] Func<string> bodykey = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "optiapi")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<FindDuplicatesInArraysResponse> __BuildFindDuplicatesInArrays(WorkflowExpression<string[]> bodyarray, WorkflowExpression<string> bodykey = null)
        {
            WorkflowExpression.Validate(bodyarray, nameof(bodyarray), required: true);
            WorkflowExpression.Validate(bodykey, nameof(bodykey), required: false);
            return new DeferredBodyAction<FindDuplicatesInArraysResponse>(() =>
            {
                var apiCallPath = "/array/duplicate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["array"] = ExpressionConverter.ConvertO(bodyarray);
                if (bodykey != null)
                {
                    body["key"] = ExpressionConverter.ConvertO(bodykey);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<FindDuplicatesInArraysResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "optiapi")]
        [WorkflowExpressionFactory(nameof(__BuildFilterAnArray))]
        public IBodyWorkflowAction<FilterAnArrayResponse> FilterAnArray([WorkflowExpression] Func<string[]> bodyarray, [WorkflowExpression] Func<bool> bodypreserveKeys)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "optiapi")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<FilterAnArrayResponse> __BuildFilterAnArray(WorkflowExpression<string[]> bodyarray, WorkflowExpression<bool> bodypreserveKeys)
        {
            WorkflowExpression.Validate(bodyarray, nameof(bodyarray), required: true);
            WorkflowExpression.Validate(bodypreserveKeys, nameof(bodypreserveKeys), required: true);
            return new DeferredBodyAction<FilterAnArrayResponse>(() =>
            {
                var apiCallPath = "/array/filter";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString(" application/json");
                callPayload.Headers["Accept"] = Convert.ToString(" application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["array"] = ExpressionConverter.ConvertO(bodyarray);
                bodypropCount++;
                body["preserveKeys"] = ExpressionConverter.ConvertO(bodypreserveKeys);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<FilterAnArrayResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "optiapi")]
        [WorkflowExpressionFactory(nameof(__BuildFirstWhereWithinAnArray))]
        public IBodyWorkflowAction<FirstWhereWithinAnArrayResponse> FirstWhereWithinAnArray([WorkflowExpression] Func<string[]> bodyarray, [WorkflowExpression] Func<string> bodykey, [WorkflowExpression] Func<string> bodyvalue, [WorkflowExpression] Func<bodyOperatorInput> bodyOperator = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "optiapi")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<FirstWhereWithinAnArrayResponse> __BuildFirstWhereWithinAnArray(WorkflowExpression<string[]> bodyarray, WorkflowExpression<string> bodykey, WorkflowExpression<string> bodyvalue, WorkflowExpression<bodyOperatorInput> bodyOperator = null)
        {
            WorkflowExpression.Validate(bodyarray, nameof(bodyarray), required: true);
            WorkflowExpression.Validate(bodykey, nameof(bodykey), required: true);
            WorkflowExpression.Validate(bodyvalue, nameof(bodyvalue), required: true);
            WorkflowExpression.Validate(bodyOperator, nameof(bodyOperator), required: false);
            return new DeferredBodyAction<FirstWhereWithinAnArrayResponse>(() =>
            {
                var apiCallPath = "/array/first-where";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["array"] = ExpressionConverter.ConvertO(bodyarray);
                bodypropCount++;
                body["key"] = ExpressionConverter.ConvertO(bodykey);
                if (bodyOperator != null)
                {
                    body["operator"] = ExpressionConverter.ConvertO(bodyOperator);
                    bodypropCount++;
                }

                bodypropCount++;
                body["value"] = ExpressionConverter.ConvertO(bodyvalue);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<FirstWhereWithinAnArrayResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "optiapi")]
        [WorkflowExpressionFactory(nameof(__BuildFlattenAnArray))]
        public IBodyWorkflowAction<FlattenAnArrayResponse> FlattenAnArray([WorkflowExpression] Func<string[]> bodyarray, [WorkflowExpression] Func<int> bodydepth = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "optiapi")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<FlattenAnArrayResponse> __BuildFlattenAnArray(WorkflowExpression<string[]> bodyarray, WorkflowExpression<int> bodydepth = null)
        {
            WorkflowExpression.Validate(bodyarray, nameof(bodyarray), required: true);
            WorkflowExpression.Validate(bodydepth, nameof(bodydepth), required: false);
            return new DeferredBodyAction<FlattenAnArrayResponse>(() =>
            {
                var apiCallPath = "/array/flatten";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["array"] = ExpressionConverter.ConvertO(bodyarray);
                if (bodydepth != null)
                {
                    body["depth"] = ExpressionConverter.ConvertO(bodydepth);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<FlattenAnArrayResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "optiapi")]
        [WorkflowExpressionFactory(nameof(__BuildRemoveItemFromArray))]
        public IBodyWorkflowAction<RemoveItemFromArrayResponse> RemoveItemFromArray([WorkflowExpression] Func<string[]> bodyarray, [WorkflowExpression] Func<string> bodykey)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "optiapi")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<RemoveItemFromArrayResponse> __BuildRemoveItemFromArray(WorkflowExpression<string[]> bodyarray, WorkflowExpression<string> bodykey)
        {
            WorkflowExpression.Validate(bodyarray, nameof(bodyarray), required: true);
            WorkflowExpression.Validate(bodykey, nameof(bodykey), required: true);
            return new DeferredBodyAction<RemoveItemFromArrayResponse>(() =>
            {
                var apiCallPath = "/array/forget";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["array"] = ExpressionConverter.ConvertO(bodyarray);
                bodypropCount++;
                body["key"] = ExpressionConverter.ConvertO(bodykey);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<RemoveItemFromArrayResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "optiapi")]
        [WorkflowExpressionFactory(nameof(__BuildGroupByAnArrayKey))]
        public IBodyWorkflowAction<GroupByAnArrayKeyResponse> GroupByAnArrayKey([WorkflowExpression] Func<string[]> bodyarray, [WorkflowExpression] Func<string> bodykey)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "optiapi")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GroupByAnArrayKeyResponse> __BuildGroupByAnArrayKey(WorkflowExpression<string[]> bodyarray, WorkflowExpression<string> bodykey)
        {
            WorkflowExpression.Validate(bodyarray, nameof(bodyarray), required: true);
            WorkflowExpression.Validate(bodykey, nameof(bodykey), required: true);
            return new DeferredBodyAction<GroupByAnArrayKeyResponse>(() =>
            {
                var apiCallPath = "/array/group-by";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["array"] = ExpressionConverter.ConvertO(bodyarray);
                bodypropCount++;
                body["key"] = ExpressionConverter.ConvertO(bodykey);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<GroupByAnArrayKeyResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "optiapi")]
        [WorkflowExpressionFactory(nameof(__BuildSortAnArray))]
        public IBodyWorkflowAction<StandardArrayResponse> SortAnArray([WorkflowExpression] Func<string[]> bodyarray, [WorkflowExpression] Func<bodysortInput> bodysort)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "optiapi")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<StandardArrayResponse> __BuildSortAnArray(WorkflowExpression<string[]> bodyarray, WorkflowExpression<bodysortInput> bodysort)
        {
            WorkflowExpression.Validate(bodyarray, nameof(bodyarray), required: true);
            WorkflowExpression.Validate(bodysort, nameof(bodysort), required: true);
            return new DeferredBodyAction<StandardArrayResponse>(() =>
            {
                var apiCallPath = "/array/sort";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString(" application/json");
                callPayload.Headers["Accept"] = Convert.ToString(" application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["array"] = ExpressionConverter.ConvertO(bodyarray);
                bodypropCount++;
                body["sort"] = ExpressionConverter.ConvertO(bodysort);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<StandardArrayResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "optiapi")]
        [WorkflowExpressionFactory(nameof(__BuildGetUniqueItemsInAnArray))]
        public IBodyWorkflowAction<GetUniqueItemsInAnArrayResponse> GetUniqueItemsInAnArray([WorkflowExpression] Func<string[]> bodyarray, [WorkflowExpression] Func<string> bodykey = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "optiapi")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetUniqueItemsInAnArrayResponse> __BuildGetUniqueItemsInAnArray(WorkflowExpression<string[]> bodyarray, WorkflowExpression<string> bodykey = null)
        {
            WorkflowExpression.Validate(bodyarray, nameof(bodyarray), required: true);
            WorkflowExpression.Validate(bodykey, nameof(bodykey), required: false);
            return new DeferredBodyAction<GetUniqueItemsInAnArrayResponse>(() =>
            {
                var apiCallPath = "/array/unique";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["array"] = ExpressionConverter.ConvertO(bodyarray);
                if (bodykey != null)
                {
                    body["key"] = ExpressionConverter.ConvertO(bodykey);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<GetUniqueItemsInAnArrayResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "optiapi")]
        [WorkflowExpressionFactory(nameof(__BuildAddOrSubtractFromTimeOrDates))]
        public IBodyWorkflowAction<AddOrSubtractFromTimeOrDatesResponse> AddOrSubtractFromTimeOrDates([WorkflowExpression] Func<bodyactionInput> bodyaction, [WorkflowExpression] Func<string> bodydatetime, [WorkflowExpression] Func<bodyOperatorInput> bodyOperator, [WorkflowExpression] Func<int> bodyvalue, [WorkflowExpression] Func<string> bodyoutputFormat = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "optiapi")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AddOrSubtractFromTimeOrDatesResponse> __BuildAddOrSubtractFromTimeOrDates(WorkflowExpression<bodyactionInput> bodyaction, WorkflowExpression<string> bodydatetime, WorkflowExpression<bodyOperatorInput> bodyOperator, WorkflowExpression<int> bodyvalue, WorkflowExpression<string> bodyoutputFormat = null)
        {
            WorkflowExpression.Validate(bodyaction, nameof(bodyaction), required: true);
            WorkflowExpression.Validate(bodydatetime, nameof(bodydatetime), required: true);
            WorkflowExpression.Validate(bodyOperator, nameof(bodyOperator), required: true);
            WorkflowExpression.Validate(bodyvalue, nameof(bodyvalue), required: true);
            WorkflowExpression.Validate(bodyoutputFormat, nameof(bodyoutputFormat), required: false);
            return new DeferredBodyAction<AddOrSubtractFromTimeOrDatesResponse>(() =>
            {
                var apiCallPath = "/datetime/add-or-subtract";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString(" application/json");
                callPayload.Headers["Accept"] = Convert.ToString(" application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["action"] = ExpressionConverter.ConvertO(bodyaction);
                bodypropCount++;
                body["datetime"] = ExpressionConverter.ConvertO(bodydatetime);
                bodypropCount++;
                body["operator"] = ExpressionConverter.ConvertO(bodyOperator);
                if (bodyoutputFormat != null)
                {
                    body["outputFormat"] = ExpressionConverter.ConvertO(bodyoutputFormat);
                    bodypropCount++;
                }

                bodypropCount++;
                body["value"] = ExpressionConverter.ConvertO(bodyvalue);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<AddOrSubtractFromTimeOrDatesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "optiapi")]
        [WorkflowExpressionFactory(nameof(__BuildConvertAStringToADatetimeObject))]
        public IBodyWorkflowAction<ConvertAStringToADatetimeObjectResponse> ConvertAStringToADatetimeObject([WorkflowExpression] Func<string> contentType, [WorkflowExpression] Func<string> accept, [WorkflowExpression] Func<string> bodyinputFormat, [WorkflowExpression] Func<string> bodyoutputFormat, [WorkflowExpression] Func<string> bodystring, [WorkflowExpression] Func<string> bodytimezone = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "optiapi")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ConvertAStringToADatetimeObjectResponse> __BuildConvertAStringToADatetimeObject(WorkflowExpression<string> contentType, WorkflowExpression<string> accept, WorkflowExpression<string> bodyinputFormat, WorkflowExpression<string> bodyoutputFormat, WorkflowExpression<string> bodystring, WorkflowExpression<string> bodytimezone = null)
        {
            WorkflowExpression.Validate(contentType, nameof(contentType), required: true);
            WorkflowExpression.Validate(accept, nameof(accept), required: true);
            WorkflowExpression.Validate(bodyinputFormat, nameof(bodyinputFormat), required: true);
            WorkflowExpression.Validate(bodyoutputFormat, nameof(bodyoutputFormat), required: true);
            WorkflowExpression.Validate(bodystring, nameof(bodystring), required: true);
            WorkflowExpression.Validate(bodytimezone, nameof(bodytimezone), required: false);
            return new DeferredBodyAction<ConvertAStringToADatetimeObjectResponse>(() =>
            {
                var apiCallPath = "/datetime/string-to-datetime";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(contentType);
                callPayload.Headers["Accept"] = ExpressionConverter.Convert(accept);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["inputFormat"] = ExpressionConverter.ConvertO(bodyinputFormat);
                bodypropCount++;
                body["outputFormat"] = ExpressionConverter.ConvertO(bodyoutputFormat);
                bodypropCount++;
                body["string"] = ExpressionConverter.ConvertO(bodystring);
                if (bodytimezone != null)
                {
                    body["timezone"] = ExpressionConverter.ConvertO(bodytimezone);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ConvertAStringToADatetimeObjectResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "optiapi")]
        [WorkflowExpressionFactory(nameof(__BuildPerformOcrOnAScannedPdfOrImageFile))]
        public IBodyWorkflowAction<PerformOcrOnAScannedPdfOrImageFileResponse> PerformOcrOnAScannedPdfOrImageFile([WorkflowExpression] Func<string> bodyfile, [WorkflowExpression] Func<bodyoemInput> bodyoem, [WorkflowExpression] Func<bodypsmInput> bodypsm, [WorkflowExpression] Func<bool> bodytrim, [WorkflowExpression] Func<bodytypeInput> bodytype, [WorkflowExpression] Func<string> bodylanguage = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "optiapi")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PerformOcrOnAScannedPdfOrImageFileResponse> __BuildPerformOcrOnAScannedPdfOrImageFile(WorkflowExpression<string> bodyfile, WorkflowExpression<bodyoemInput> bodyoem, WorkflowExpression<bodypsmInput> bodypsm, WorkflowExpression<bool> bodytrim, WorkflowExpression<bodytypeInput> bodytype, WorkflowExpression<string> bodylanguage = null)
        {
            WorkflowExpression.Validate(bodyfile, nameof(bodyfile), required: true);
            WorkflowExpression.Validate(bodyoem, nameof(bodyoem), required: true);
            WorkflowExpression.Validate(bodypsm, nameof(bodypsm), required: true);
            WorkflowExpression.Validate(bodytrim, nameof(bodytrim), required: true);
            WorkflowExpression.Validate(bodytype, nameof(bodytype), required: true);
            WorkflowExpression.Validate(bodylanguage, nameof(bodylanguage), required: false);
            return new DeferredBodyAction<PerformOcrOnAScannedPdfOrImageFileResponse>(() =>
            {
                var apiCallPath = "/ocr/perform-ocr";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString(" application/json");
                callPayload.Headers["Accept"] = Convert.ToString(" application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["file"] = ExpressionConverter.ConvertO(bodyfile);
                if (bodylanguage != null)
                {
                    if (bodylanguage != null)
                    {
                        body["language"] = ExpressionConverter.ConvertO(bodylanguage);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["language"] = "eng";
                    bodypropCount++;
                }

                bodypropCount++;
                body["oem"] = ExpressionConverter.ConvertO(bodyoem);
                bodypropCount++;
                body["psm"] = ExpressionConverter.ConvertO(bodypsm);
                bodypropCount++;
                body["trim"] = ExpressionConverter.ConvertO(bodytrim);
                bodypropCount++;
                body["type"] = ExpressionConverter.ConvertO(bodytype);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<PerformOcrOnAScannedPdfOrImageFileResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "optiapi")]
        [WorkflowExpressionFactory(nameof(__BuildCombineMultiplePdfFiles))]
        public IBodyWorkflowAction<CombineMultiplePdfFilesResponse> CombineMultiplePdfFiles([WorkflowExpression] Func<string[]> bodypdfs)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "optiapi")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CombineMultiplePdfFilesResponse> __BuildCombineMultiplePdfFiles(WorkflowExpression<string[]> bodypdfs)
        {
            WorkflowExpression.Validate(bodypdfs, nameof(bodypdfs), required: true);
            return new DeferredBodyAction<CombineMultiplePdfFilesResponse>(() =>
            {
                var apiCallPath = "/pdf/combine-pdf";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString(" application/json");
                callPayload.Headers["Accept"] = Convert.ToString(" application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["pdfs"] = ExpressionConverter.ConvertO(bodypdfs);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CombineMultiplePdfFilesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "optiapi")]
        [WorkflowExpressionFactory(nameof(__BuildGetPdfMetadataInformation))]
        public IBodyWorkflowAction<GetPdfMetadataInformationResponse> GetPdfMetadataInformation([WorkflowExpression] Func<string> bodypdf)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "optiapi")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetPdfMetadataInformationResponse> __BuildGetPdfMetadataInformation(WorkflowExpression<string> bodypdf)
        {
            WorkflowExpression.Validate(bodypdf, nameof(bodypdf), required: true);
            return new DeferredBodyAction<GetPdfMetadataInformationResponse>(() =>
            {
                var apiCallPath = "/pdf/pdf-metadata";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString(" application/json");
                callPayload.Headers["Accept"] = Convert.ToString(" application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["pdf"] = ExpressionConverter.ConvertO(bodypdf);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<GetPdfMetadataInformationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "optiapi")]
        [WorkflowExpressionFactory(nameof(__BuildConvertAPdfFileToText))]
        public IBodyWorkflowAction<StandardArrayResponse> ConvertAPdfFileToText([WorkflowExpression] Func<bodylayoutInput> bodylayout, [WorkflowExpression] Func<string> bodypdf, [WorkflowExpression] Func<int> bodyendPage = null, [WorkflowExpression] Func<int> bodystartPage = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "optiapi")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<StandardArrayResponse> __BuildConvertAPdfFileToText(WorkflowExpression<bodylayoutInput> bodylayout, WorkflowExpression<string> bodypdf, WorkflowExpression<int> bodyendPage = null, WorkflowExpression<int> bodystartPage = null)
        {
            WorkflowExpression.Validate(bodylayout, nameof(bodylayout), required: true);
            WorkflowExpression.Validate(bodypdf, nameof(bodypdf), required: true);
            WorkflowExpression.Validate(bodyendPage, nameof(bodyendPage), required: false);
            WorkflowExpression.Validate(bodystartPage, nameof(bodystartPage), required: false);
            return new DeferredBodyAction<StandardArrayResponse>(() =>
            {
                var apiCallPath = "/pdf/pdf-to-text";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString(" application/json");
                callPayload.Headers["Accept"] = Convert.ToString(" application/json");
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyendPage != null)
                {
                    body["endPage"] = ExpressionConverter.ConvertO(bodyendPage);
                    bodypropCount++;
                }

                bodypropCount++;
                body["layout"] = ExpressionConverter.ConvertO(bodylayout);
                bodypropCount++;
                body["pdf"] = ExpressionConverter.ConvertO(bodypdf);
                if (bodystartPage != null)
                {
                    body["startPage"] = ExpressionConverter.ConvertO(bodystartPage);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<StandardArrayResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "optiapi")]
        [WorkflowExpressionFactory(nameof(__BuildSetPasswordOnAPdfFile))]
        public IBodyWorkflowAction<SetPasswordOnAPdfFileResponse> SetPasswordOnAPdfFile([WorkflowExpression] Func<string> contentType, [WorkflowExpression] Func<string> accept, [WorkflowExpression] Func<string> bodypassword, [WorkflowExpression] Func<string> bodypdf)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "optiapi")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SetPasswordOnAPdfFileResponse> __BuildSetPasswordOnAPdfFile(WorkflowExpression<string> contentType, WorkflowExpression<string> accept, WorkflowExpression<string> bodypassword, WorkflowExpression<string> bodypdf)
        {
            WorkflowExpression.Validate(contentType, nameof(contentType), required: true);
            WorkflowExpression.Validate(accept, nameof(accept), required: true);
            WorkflowExpression.Validate(bodypassword, nameof(bodypassword), required: true);
            WorkflowExpression.Validate(bodypdf, nameof(bodypdf), required: true);
            return new DeferredBodyAction<SetPasswordOnAPdfFileResponse>(() =>
            {
                var apiCallPath = "/pdf/set-password";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(contentType);
                callPayload.Headers["Accept"] = ExpressionConverter.Convert(accept);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["password"] = ExpressionConverter.ConvertO(bodypassword);
                bodypropCount++;
                body["pdf"] = ExpressionConverter.ConvertO(bodypdf);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SetPasswordOnAPdfFileResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "optiapi")]
        [WorkflowExpressionFactory(nameof(__BuildReplaceTextInStringBasedOnARegularExpression))]
        public IBodyWorkflowAction<ReplaceTextInStringBasedOnARegularExpressionResponse> ReplaceTextInStringBasedOnARegularExpression([WorkflowExpression] Func<string> bodypattern, [WorkflowExpression] Func<string> bodyreplacement, [WorkflowExpression] Func<string> bodytext)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "optiapi")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ReplaceTextInStringBasedOnARegularExpressionResponse> __BuildReplaceTextInStringBasedOnARegularExpression(WorkflowExpression<string> bodypattern, WorkflowExpression<string> bodyreplacement, WorkflowExpression<string> bodytext)
        {
            WorkflowExpression.Validate(bodypattern, nameof(bodypattern), required: true);
            WorkflowExpression.Validate(bodyreplacement, nameof(bodyreplacement), required: true);
            WorkflowExpression.Validate(bodytext, nameof(bodytext), required: true);
            return new DeferredBodyAction<ReplaceTextInStringBasedOnARegularExpressionResponse>(() =>
            {
                var apiCallPath = "/regex/regex-replace";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString(" application/json");
                callPayload.Headers["Accept"] = Convert.ToString(" application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["pattern"] = ExpressionConverter.ConvertO(bodypattern);
                bodypropCount++;
                body["replacement"] = ExpressionConverter.ConvertO(bodyreplacement);
                bodypropCount++;
                body["text"] = ExpressionConverter.ConvertO(bodytext);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ReplaceTextInStringBasedOnARegularExpressionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "optiapi")]
        [WorkflowExpressionFactory(nameof(__BuildFindValuesFromAStringBasedOnARegularExpression))]
        public IBodyWorkflowAction<FindValuesFromAStringBasedOnARegularExpressionResponse> FindValuesFromAStringBasedOnARegularExpression([WorkflowExpression] Func<string> bodypattern, [WorkflowExpression] Func<string> bodytext, [WorkflowExpression] Func<int> bodygroup = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "optiapi")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<FindValuesFromAStringBasedOnARegularExpressionResponse> __BuildFindValuesFromAStringBasedOnARegularExpression(WorkflowExpression<string> bodypattern, WorkflowExpression<string> bodytext, WorkflowExpression<int> bodygroup = null)
        {
            WorkflowExpression.Validate(bodypattern, nameof(bodypattern), required: true);
            WorkflowExpression.Validate(bodytext, nameof(bodytext), required: true);
            WorkflowExpression.Validate(bodygroup, nameof(bodygroup), required: false);
            return new DeferredBodyAction<FindValuesFromAStringBasedOnARegularExpressionResponse>(() =>
            {
                var apiCallPath = "/regex/regex-search";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString(" application/json");
                callPayload.Headers["Accept"] = Convert.ToString(" application/json");
                var body = new JObject();
                var bodypropCount = 0;
                if (bodygroup != null)
                {
                    body["group"] = ExpressionConverter.ConvertO(bodygroup);
                    bodypropCount++;
                }

                bodypropCount++;
                body["pattern"] = ExpressionConverter.ConvertO(bodypattern);
                bodypropCount++;
                body["text"] = ExpressionConverter.ConvertO(bodytext);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<FindValuesFromAStringBasedOnARegularExpressionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "optiapi")]
        [WorkflowExpressionFactory(nameof(__BuildReplaceTextInString))]
        public IBodyWorkflowAction<ReplaceTextInStringResponse> ReplaceTextInString([WorkflowExpression] Func<string> contentType, [WorkflowExpression] Func<string> accept, [WorkflowExpression] Func<string> bodyreplace, [WorkflowExpression] Func<string> bodysearch, [WorkflowExpression] Func<string> bodytext)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "optiapi")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ReplaceTextInStringResponse> __BuildReplaceTextInString(WorkflowExpression<string> contentType, WorkflowExpression<string> accept, WorkflowExpression<string> bodyreplace, WorkflowExpression<string> bodysearch, WorkflowExpression<string> bodytext)
        {
            WorkflowExpression.Validate(contentType, nameof(contentType), required: true);
            WorkflowExpression.Validate(accept, nameof(accept), required: true);
            WorkflowExpression.Validate(bodyreplace, nameof(bodyreplace), required: true);
            WorkflowExpression.Validate(bodysearch, nameof(bodysearch), required: true);
            WorkflowExpression.Validate(bodytext, nameof(bodytext), required: true);
            return new DeferredBodyAction<ReplaceTextInStringResponse>(() =>
            {
                var apiCallPath = "/text/text-replace";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(contentType);
                callPayload.Headers["Accept"] = ExpressionConverter.Convert(accept);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["replace"] = ExpressionConverter.ConvertO(bodyreplace);
                bodypropCount++;
                body["search"] = ExpressionConverter.ConvertO(bodysearch);
                bodypropCount++;
                body["text"] = ExpressionConverter.ConvertO(bodytext);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ReplaceTextInStringResponse>(callPayload);
            });
        }
    }

    public class OptiapiTriggers([ConnectionName] string connectionId)
    {
    }

    public class CalculateAverageResponse
    {
        [JsonProperty("average")]
        public int Average { get; set; }
    }

    public class ChunkAnArrayResponse
    {
        [JsonProperty("array")]
        public string[] Array { get; set; }
    }

    public class CombineArrayResponse
    {
        [JsonProperty("array")]
        public string[] Array { get; set; }
    }

    public class CheckIfArrayContainAValueResponse
    {
        [JsonProperty("contains")]
        public bool Contains { get; set; }
    }

    public class FindDifferenceBetweenArraysResponse
    {
        [JsonProperty("array")]
        public string[] Array { get; set; }
    }

    public class FindDuplicatesInArraysResponse
    {
        [JsonProperty("array")]
        public string[] Array { get; set; }
    }

    public class FilterAnArrayResponse
    {
        [JsonProperty("array")]
        public string[] Array { get; set; }
    }

    public class FirstWhereWithinAnArrayResponse
    {
        [JsonProperty("array")]
        public string[] Array { get; set; }
    }

    public enum bodyOperatorInput
    {
        Add,
        Subtract
    }

    public class FlattenAnArrayResponse
    {
        [JsonProperty("array")]
        public string[] Array { get; set; }
    }

    public class RemoveItemFromArrayResponse
    {
        [JsonProperty("array")]
        public string[] Array { get; set; }
    }

    public class GroupByAnArrayKeyResponse
    {
        [JsonProperty("array")]
        public string[] Array { get; set; }
    }

    public class StandardArrayResponse
    {
        [JsonProperty("array")]
        public string[] ResultArray { get; set; }
    }

    public enum bodysortInput
    {
        Ascending,
        Descending
    }

    public class GetUniqueItemsInAnArrayResponse
    {
        [JsonProperty("array")]
        public string[] Array { get; set; }
    }

    public class AddOrSubtractFromTimeOrDatesResponse
    {
        [JsonProperty("datetime")]
        public string Datetime { get; set; }
    }

    public enum bodyactionInput
    {
        Year,
        Quarter,
        Month,
        Week,
        Weekday,
        Day,
        Hour,
        Minute,
        Second
    }

    public class ConvertAStringToADatetimeObjectResponse
    {
        [JsonProperty("datetime")]
        public string Datetime { get; set; }
    }

    public class PerformOcrOnAScannedPdfOrImageFileResponse
    {
        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public enum bodyoemInput
    {
        [EnumMember(Value = "0")]
        _0,
        [EnumMember(Value = "1")]
        _1
    }

    public enum bodypsmInput
    {
        [EnumMember(Value = "0")]
        _0,
        [EnumMember(Value = "1")]
        _1,
        [EnumMember(Value = "2")]
        _2,
        [EnumMember(Value = "3")]
        _3,
        [EnumMember(Value = "4")]
        _4,
        [EnumMember(Value = "5")]
        _5,
        [EnumMember(Value = "6")]
        _6,
        [EnumMember(Value = "7")]
        _7,
        [EnumMember(Value = "8")]
        _8,
        [EnumMember(Value = "9")]
        _9,
        [EnumMember(Value = "10")]
        _10,
        [EnumMember(Value = "11")]
        _11,
        [EnumMember(Value = "12")]
        _12,
        [EnumMember(Value = "13")]
        _13
    }

    public enum bodytypeInput
    {
        [EnumMember(Value = "pdf")]
        Pdf,
        [EnumMember(Value = "jpg")]
        Jpg,
        [EnumMember(Value = "jpeg")]
        Jpeg,
        [EnumMember(Value = "png")]
        Png,
        [EnumMember(Value = "gif")]
        Gif
    }

    public class CombineMultiplePdfFilesResponse
    {
        [JsonProperty("content")]
        public string Content { get; set; }
    }

    public class GetPdfMetadataInformationResponse
    {
        [JsonProperty("metadata")]
        public GetPdfMetadataInformationResponseMetadataType Metadata { get; set; }
    }

    public class GetPdfMetadataInformationResponseMetadataType
    {
        public string PDFVersion { get; set; }

        [JsonProperty("author")]
        public string Author { get; set; }

        [JsonProperty("creationDate")]
        public string CreationDate { get; set; }

        [JsonProperty("creator")]
        public string Creator { get; set; }

        [JsonProperty("encrypted")]
        public string Encrypted { get; set; }

        [JsonProperty("fileSize")]
        public string FileSize { get; set; }

        [JsonProperty("form")]
        public string Form { get; set; }

        [JsonProperty("modDate")]
        public string ModDate { get; set; }

        [JsonProperty("optimized")]
        public string Optimized { get; set; }

        [JsonProperty("output")]
        public string[] Output { get; set; }

        [JsonProperty("pageRot")]
        public string PageRot { get; set; }

        [JsonProperty("pageSize")]
        public string PageSize { get; set; }

        [JsonProperty("pages")]
        public string Pages { get; set; }

        [JsonProperty("producer")]
        public string Producer { get; set; }

        [JsonProperty("tagged")]
        public string Tagged { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }

    public enum bodylayoutInput
    {
        [EnumMember(Value = "raw")]
        Raw,
        [EnumMember(Value = "original")]
        Original
    }

    public class SetPasswordOnAPdfFileResponse
    {
        [JsonProperty("content")]
        public string Content { get; set; }
    }

    public class ReplaceTextInStringBasedOnARegularExpressionResponse
    {
        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class FindValuesFromAStringBasedOnARegularExpressionResponse
    {
        [JsonProperty("values")]
        public string[] Values { get; set; }
    }

    public class ReplaceTextInStringResponse
    {
        [JsonProperty("text")]
        public string Text { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Optiapi;

    public partial class WorkflowManagedActions
    {
        public OptiapiActions Optiapi(string connectionId) => new OptiapiActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public OptiapiTriggers Optiapi(string connectionId) => new OptiapiTriggers(connectionId);
    }
}