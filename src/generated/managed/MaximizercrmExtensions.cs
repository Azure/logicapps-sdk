//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Maximizercrm
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class MaximizercrmActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "maximizercrm")]
        [WorkflowExpressionFactory(nameof(__BuildActionAbEntryFind))]
        public IBodyWorkflowAction<AbEntryFindSchema> ActionAbEntryFind([WorkflowExpression] Func<string> udf1 = null, [WorkflowExpression] Func<string> udf2 = null, [WorkflowExpression] Func<string> udf3 = null, [WorkflowExpression] Func<string> udf4 = null, [WorkflowExpression] Func<string> udf5 = null, [WorkflowExpression] Func<object> body = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AbEntryFindSchema> __BuildActionAbEntryFind(WorkflowValue<string> udf1 = null, WorkflowValue<string> udf2 = null, WorkflowValue<string> udf3 = null, WorkflowValue<string> udf4 = null, WorkflowValue<string> udf5 = null, WorkflowValue<object> body = null)
        {
            WorkflowValue.Validate(udf1, nameof(udf1), required: false);
            WorkflowValue.Validate(udf2, nameof(udf2), required: false);
            WorkflowValue.Validate(udf3, nameof(udf3), required: false);
            WorkflowValue.Validate(udf4, nameof(udf4), required: false);
            WorkflowValue.Validate(udf5, nameof(udf5), required: false);
            WorkflowValue.Validate(body, nameof(body), required: false);
            return new DeferredBodyAction<AbEntryFindSchema>(() =>
            {
                var apiCallPath = "/api/AbEntry/action/find";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (udf1 != null)
                    callPayload.Queries["udf1"] = ExpressionConverter.Convert(udf1);
                if (udf2 != null)
                    callPayload.Queries["udf2"] = ExpressionConverter.Convert(udf2);
                if (udf3 != null)
                    callPayload.Queries["udf3"] = ExpressionConverter.Convert(udf3);
                if (udf4 != null)
                    callPayload.Queries["udf4"] = ExpressionConverter.Convert(udf4);
                if (udf5 != null)
                    callPayload.Queries["udf5"] = ExpressionConverter.Convert(udf5);
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionAction<AbEntryFindSchema>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "maximizercrm")]
        [WorkflowExpressionFactory(nameof(__BuildActionAbEntryCreate))]
        public IBodyWorkflowAction<AbEntryCreateSchema> ActionAbEntryCreate([WorkflowExpression] Func<applyActionToInput> applyActionTo, [WorkflowExpression] Func<object> body = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AbEntryCreateSchema> __BuildActionAbEntryCreate(WorkflowValue<applyActionToInput> applyActionTo, WorkflowValue<object> body = null)
        {
            WorkflowValue.Validate(applyActionTo, nameof(applyActionTo), required: true);
            WorkflowValue.Validate(body, nameof(body), required: false);
            return new DeferredBodyAction<AbEntryCreateSchema>(() =>
            {
                var apiCallPath = "/api/AbEntry/action/create";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["applyActionTo"] = ExpressionConverter.Convert(applyActionTo);
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionAction<AbEntryCreateSchema>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "maximizercrm")]
        [WorkflowExpressionFactory(nameof(__BuildActionAbEntryUpdate))]
        public IBodyWorkflowAction<AbEntryUpdateSchema> ActionAbEntryUpdate([WorkflowExpression] Func<applyActionToInput> applyActionTo, [WorkflowExpression] Func<string> udf1 = null, [WorkflowExpression] Func<string> udf2 = null, [WorkflowExpression] Func<string> udf3 = null, [WorkflowExpression] Func<string> udf4 = null, [WorkflowExpression] Func<string> udf5 = null, [WorkflowExpression] Func<object> body = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AbEntryUpdateSchema> __BuildActionAbEntryUpdate(WorkflowValue<applyActionToInput> applyActionTo, WorkflowValue<string> udf1 = null, WorkflowValue<string> udf2 = null, WorkflowValue<string> udf3 = null, WorkflowValue<string> udf4 = null, WorkflowValue<string> udf5 = null, WorkflowValue<object> body = null)
        {
            WorkflowValue.Validate(applyActionTo, nameof(applyActionTo), required: true);
            WorkflowValue.Validate(udf1, nameof(udf1), required: false);
            WorkflowValue.Validate(udf2, nameof(udf2), required: false);
            WorkflowValue.Validate(udf3, nameof(udf3), required: false);
            WorkflowValue.Validate(udf4, nameof(udf4), required: false);
            WorkflowValue.Validate(udf5, nameof(udf5), required: false);
            WorkflowValue.Validate(body, nameof(body), required: false);
            return new DeferredBodyAction<AbEntryUpdateSchema>(() =>
            {
                var apiCallPath = "/api/AbEntry/action/update";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["applyActionTo"] = ExpressionConverter.Convert(applyActionTo);
                if (udf1 != null)
                    callPayload.Queries["udf1"] = ExpressionConverter.Convert(udf1);
                if (udf2 != null)
                    callPayload.Queries["udf2"] = ExpressionConverter.Convert(udf2);
                if (udf3 != null)
                    callPayload.Queries["udf3"] = ExpressionConverter.Convert(udf3);
                if (udf4 != null)
                    callPayload.Queries["udf4"] = ExpressionConverter.Convert(udf4);
                if (udf5 != null)
                    callPayload.Queries["udf5"] = ExpressionConverter.Convert(udf5);
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionAction<AbEntryUpdateSchema>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "maximizercrm")]
        [WorkflowExpressionFactory(nameof(__BuildActionAbEntryFindOrCreate))]
        public IBodyWorkflowAction<AbEntryFindSchema> ActionAbEntryFindOrCreate([WorkflowExpression] Func<applyActionToInput> applyActionTo, [WorkflowExpression] Func<string> udf1 = null, [WorkflowExpression] Func<string> udf2 = null, [WorkflowExpression] Func<string> udf3 = null, [WorkflowExpression] Func<string> udf4 = null, [WorkflowExpression] Func<string> udf5 = null, [WorkflowExpression] Func<object> body = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AbEntryFindSchema> __BuildActionAbEntryFindOrCreate(WorkflowValue<applyActionToInput> applyActionTo, WorkflowValue<string> udf1 = null, WorkflowValue<string> udf2 = null, WorkflowValue<string> udf3 = null, WorkflowValue<string> udf4 = null, WorkflowValue<string> udf5 = null, WorkflowValue<object> body = null)
        {
            WorkflowValue.Validate(applyActionTo, nameof(applyActionTo), required: true);
            WorkflowValue.Validate(udf1, nameof(udf1), required: false);
            WorkflowValue.Validate(udf2, nameof(udf2), required: false);
            WorkflowValue.Validate(udf3, nameof(udf3), required: false);
            WorkflowValue.Validate(udf4, nameof(udf4), required: false);
            WorkflowValue.Validate(udf5, nameof(udf5), required: false);
            WorkflowValue.Validate(body, nameof(body), required: false);
            return new DeferredBodyAction<AbEntryFindSchema>(() =>
            {
                var apiCallPath = "/api/AbEntry/action/findOrCreate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["applyActionTo"] = ExpressionConverter.Convert(applyActionTo);
                if (udf1 != null)
                    callPayload.Queries["udf1"] = ExpressionConverter.Convert(udf1);
                if (udf2 != null)
                    callPayload.Queries["udf2"] = ExpressionConverter.Convert(udf2);
                if (udf3 != null)
                    callPayload.Queries["udf3"] = ExpressionConverter.Convert(udf3);
                if (udf4 != null)
                    callPayload.Queries["udf4"] = ExpressionConverter.Convert(udf4);
                if (udf5 != null)
                    callPayload.Queries["udf5"] = ExpressionConverter.Convert(udf5);
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionAction<AbEntryFindSchema>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "maximizercrm")]
        [WorkflowExpressionFactory(nameof(__BuildActionAppointmentCreate))]
        public IBodyWorkflowAction<AppointmentCreateSchema> ActionAppointmentCreate([WorkflowExpression] Func<linkWithTypeInput> linkWithType = null, [WorkflowExpression] Func<object> body = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AppointmentCreateSchema> __BuildActionAppointmentCreate(WorkflowValue<linkWithTypeInput> linkWithType = null, WorkflowValue<object> body = null)
        {
            WorkflowValue.Validate(linkWithType, nameof(linkWithType), required: false);
            WorkflowValue.Validate(body, nameof(body), required: false);
            return new DeferredBodyAction<AppointmentCreateSchema>(() =>
            {
                var apiCallPath = "/api/Appointment/action/create";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (linkWithType != null)
                    callPayload.Queries["linkWithType"] = ExpressionConverter.Convert(linkWithType);
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionAction<AppointmentCreateSchema>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "maximizercrm")]
        [WorkflowExpressionFactory(nameof(__BuildActionAppointmentUpdate))]
        public IBodyWorkflowAction<AppointmentUpdateSchema> ActionAppointmentUpdate([WorkflowExpression] Func<object> body = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AppointmentUpdateSchema> __BuildActionAppointmentUpdate(WorkflowValue<object> body = null)
        {
            WorkflowValue.Validate(body, nameof(body), required: false);
            return new DeferredBodyAction<AppointmentUpdateSchema>(() =>
            {
                var apiCallPath = "/api/Appointment/action/update";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionAction<AppointmentUpdateSchema>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "maximizercrm")]
        [WorkflowExpressionFactory(nameof(__BuildActionAppointmentFind))]
        public IBodyWorkflowAction<AppointmentCreateSchema> ActionAppointmentFind([WorkflowExpression] Func<object> body = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AppointmentCreateSchema> __BuildActionAppointmentFind(WorkflowValue<object> body = null)
        {
            WorkflowValue.Validate(body, nameof(body), required: false);
            return new DeferredBodyAction<AppointmentCreateSchema>(() =>
            {
                var apiCallPath = "/api/Appointment/action/find";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionAction<AppointmentCreateSchema>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "maximizercrm")]
        [WorkflowExpressionFactory(nameof(__BuildActionAppointmentDelete))]
        public IBodyWorkflowAction<AppointmentCreateSchema> ActionAppointmentDelete([WorkflowExpression] Func<object> body = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AppointmentCreateSchema> __BuildActionAppointmentDelete(WorkflowValue<object> body = null)
        {
            WorkflowValue.Validate(body, nameof(body), required: false);
            return new DeferredBodyAction<AppointmentCreateSchema>(() =>
            {
                var apiCallPath = "/api/Appointment/action/delete";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionAction<AppointmentCreateSchema>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "maximizercrm")]
        [WorkflowExpressionFactory(nameof(__BuildActionCaseCreate))]
        public IBodyWorkflowAction<PACaseView> ActionCaseCreate([WorkflowExpression] Func<object> body = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PACaseView> __BuildActionCaseCreate(WorkflowValue<object> body = null)
        {
            WorkflowValue.Validate(body, nameof(body), required: false);
            return new DeferredBodyAction<PACaseView>(() =>
            {
                var apiCallPath = "/api/Case/action/create";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionAction<PACaseView>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "maximizercrm")]
        [WorkflowExpressionFactory(nameof(__BuildActionCaseUpdate))]
        public IBodyWorkflowAction<PACaseView> ActionCaseUpdate([WorkflowExpression] Func<object> body = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PACaseView> __BuildActionCaseUpdate(WorkflowValue<object> body = null)
        {
            WorkflowValue.Validate(body, nameof(body), required: false);
            return new DeferredBodyAction<PACaseView>(() =>
            {
                var apiCallPath = "/api/Case/action/update";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionAction<PACaseView>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "maximizercrm")]
        [WorkflowExpressionFactory(nameof(__BuildActionCaseFindOrCreate))]
        public IBodyWorkflowAction<CaseFindOrCreateSchema> ActionCaseFindOrCreate([WorkflowExpression] Func<string> udf1 = null, [WorkflowExpression] Func<string> udf2 = null, [WorkflowExpression] Func<string> udf3 = null, [WorkflowExpression] Func<string> udf4 = null, [WorkflowExpression] Func<string> udf5 = null, [WorkflowExpression] Func<object> body = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CaseFindOrCreateSchema> __BuildActionCaseFindOrCreate(WorkflowValue<string> udf1 = null, WorkflowValue<string> udf2 = null, WorkflowValue<string> udf3 = null, WorkflowValue<string> udf4 = null, WorkflowValue<string> udf5 = null, WorkflowValue<object> body = null)
        {
            WorkflowValue.Validate(udf1, nameof(udf1), required: false);
            WorkflowValue.Validate(udf2, nameof(udf2), required: false);
            WorkflowValue.Validate(udf3, nameof(udf3), required: false);
            WorkflowValue.Validate(udf4, nameof(udf4), required: false);
            WorkflowValue.Validate(udf5, nameof(udf5), required: false);
            WorkflowValue.Validate(body, nameof(body), required: false);
            return new DeferredBodyAction<CaseFindOrCreateSchema>(() =>
            {
                var apiCallPath = "/api/Case/api/Case/action/findOrCreate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (udf1 != null)
                    callPayload.Queries["udf1"] = ExpressionConverter.Convert(udf1);
                if (udf2 != null)
                    callPayload.Queries["udf2"] = ExpressionConverter.Convert(udf2);
                if (udf3 != null)
                    callPayload.Queries["udf3"] = ExpressionConverter.Convert(udf3);
                if (udf4 != null)
                    callPayload.Queries["udf4"] = ExpressionConverter.Convert(udf4);
                if (udf5 != null)
                    callPayload.Queries["udf5"] = ExpressionConverter.Convert(udf5);
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionAction<CaseFindOrCreateSchema>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "maximizercrm")]
        [WorkflowExpressionFactory(nameof(__BuildActionHTaskCreate))]
        public IBodyWorkflowAction<HotlistTaskCreateSchema> ActionHTaskCreate([WorkflowExpression] Func<parentTypeInput> parentType, [WorkflowExpression] Func<object> body = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<HotlistTaskCreateSchema> __BuildActionHTaskCreate(WorkflowValue<parentTypeInput> parentType, WorkflowValue<object> body = null)
        {
            WorkflowValue.Validate(parentType, nameof(parentType), required: true);
            WorkflowValue.Validate(body, nameof(body), required: false);
            return new DeferredBodyAction<HotlistTaskCreateSchema>(() =>
            {
                var apiCallPath = "/api/HTask/action/create";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["parentType"] = ExpressionConverter.Convert(parentType);
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionAction<HotlistTaskCreateSchema>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "maximizercrm")]
        [WorkflowExpressionFactory(nameof(__BuildActionInteractionCreate))]
        public IBodyWorkflowAction<InteractionLogCreateSchema> ActionInteractionCreate([WorkflowExpression] Func<object> body = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<InteractionLogCreateSchema> __BuildActionInteractionCreate(WorkflowValue<object> body = null)
        {
            WorkflowValue.Validate(body, nameof(body), required: false);
            return new DeferredBodyAction<InteractionLogCreateSchema>(() =>
            {
                var apiCallPath = "/api/Interaction/action/create";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionAction<InteractionLogCreateSchema>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "maximizercrm")]
        [WorkflowExpressionFactory(nameof(__BuildActionLeadFind))]
        public IBodyWorkflowAction<LeadFindSchema> ActionLeadFind([WorkflowExpression] Func<string> udf1 = null, [WorkflowExpression] Func<string> udf2 = null, [WorkflowExpression] Func<string> udf3 = null, [WorkflowExpression] Func<string> udf4 = null, [WorkflowExpression] Func<string> udf5 = null, [WorkflowExpression] Func<object> body = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<LeadFindSchema> __BuildActionLeadFind(WorkflowValue<string> udf1 = null, WorkflowValue<string> udf2 = null, WorkflowValue<string> udf3 = null, WorkflowValue<string> udf4 = null, WorkflowValue<string> udf5 = null, WorkflowValue<object> body = null)
        {
            WorkflowValue.Validate(udf1, nameof(udf1), required: false);
            WorkflowValue.Validate(udf2, nameof(udf2), required: false);
            WorkflowValue.Validate(udf3, nameof(udf3), required: false);
            WorkflowValue.Validate(udf4, nameof(udf4), required: false);
            WorkflowValue.Validate(udf5, nameof(udf5), required: false);
            WorkflowValue.Validate(body, nameof(body), required: false);
            return new DeferredBodyAction<LeadFindSchema>(() =>
            {
                var apiCallPath = "/api/Lead/action/find";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (udf1 != null)
                    callPayload.Queries["udf1"] = ExpressionConverter.Convert(udf1);
                if (udf2 != null)
                    callPayload.Queries["udf2"] = ExpressionConverter.Convert(udf2);
                if (udf3 != null)
                    callPayload.Queries["udf3"] = ExpressionConverter.Convert(udf3);
                if (udf4 != null)
                    callPayload.Queries["udf4"] = ExpressionConverter.Convert(udf4);
                if (udf5 != null)
                    callPayload.Queries["udf5"] = ExpressionConverter.Convert(udf5);
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionAction<LeadFindSchema>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "maximizercrm")]
        [WorkflowExpressionFactory(nameof(__BuildActionLeadCreate))]
        public IBodyWorkflowAction<LeadCreateSchema> ActionLeadCreate([WorkflowExpression] Func<object> body = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<LeadCreateSchema> __BuildActionLeadCreate(WorkflowValue<object> body = null)
        {
            WorkflowValue.Validate(body, nameof(body), required: false);
            return new DeferredBodyAction<LeadCreateSchema>(() =>
            {
                var apiCallPath = "/api/Lead/action/create";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionAction<LeadCreateSchema>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "maximizercrm")]
        [WorkflowExpressionFactory(nameof(__BuildActionLeadUpdate))]
        public IBodyWorkflowAction<LeadUpdateSchema> ActionLeadUpdate([WorkflowExpression] Func<string> udf1 = null, [WorkflowExpression] Func<string> udf2 = null, [WorkflowExpression] Func<string> udf3 = null, [WorkflowExpression] Func<string> udf4 = null, [WorkflowExpression] Func<string> udf5 = null, [WorkflowExpression] Func<object> body = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<LeadUpdateSchema> __BuildActionLeadUpdate(WorkflowValue<string> udf1 = null, WorkflowValue<string> udf2 = null, WorkflowValue<string> udf3 = null, WorkflowValue<string> udf4 = null, WorkflowValue<string> udf5 = null, WorkflowValue<object> body = null)
        {
            WorkflowValue.Validate(udf1, nameof(udf1), required: false);
            WorkflowValue.Validate(udf2, nameof(udf2), required: false);
            WorkflowValue.Validate(udf3, nameof(udf3), required: false);
            WorkflowValue.Validate(udf4, nameof(udf4), required: false);
            WorkflowValue.Validate(udf5, nameof(udf5), required: false);
            WorkflowValue.Validate(body, nameof(body), required: false);
            return new DeferredBodyAction<LeadUpdateSchema>(() =>
            {
                var apiCallPath = "/api/Lead/action/update";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (udf1 != null)
                    callPayload.Queries["udf1"] = ExpressionConverter.Convert(udf1);
                if (udf2 != null)
                    callPayload.Queries["udf2"] = ExpressionConverter.Convert(udf2);
                if (udf3 != null)
                    callPayload.Queries["udf3"] = ExpressionConverter.Convert(udf3);
                if (udf4 != null)
                    callPayload.Queries["udf4"] = ExpressionConverter.Convert(udf4);
                if (udf5 != null)
                    callPayload.Queries["udf5"] = ExpressionConverter.Convert(udf5);
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionAction<LeadUpdateSchema>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "maximizercrm")]
        [WorkflowExpressionFactory(nameof(__BuildActionLeadFindOrCreate))]
        public IBodyWorkflowAction<LeadFindOrCreateSchema> ActionLeadFindOrCreate([WorkflowExpression] Func<string> udf1 = null, [WorkflowExpression] Func<string> udf2 = null, [WorkflowExpression] Func<string> udf3 = null, [WorkflowExpression] Func<string> udf4 = null, [WorkflowExpression] Func<string> udf5 = null, [WorkflowExpression] Func<object> body = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<LeadFindOrCreateSchema> __BuildActionLeadFindOrCreate(WorkflowValue<string> udf1 = null, WorkflowValue<string> udf2 = null, WorkflowValue<string> udf3 = null, WorkflowValue<string> udf4 = null, WorkflowValue<string> udf5 = null, WorkflowValue<object> body = null)
        {
            WorkflowValue.Validate(udf1, nameof(udf1), required: false);
            WorkflowValue.Validate(udf2, nameof(udf2), required: false);
            WorkflowValue.Validate(udf3, nameof(udf3), required: false);
            WorkflowValue.Validate(udf4, nameof(udf4), required: false);
            WorkflowValue.Validate(udf5, nameof(udf5), required: false);
            WorkflowValue.Validate(body, nameof(body), required: false);
            return new DeferredBodyAction<LeadFindOrCreateSchema>(() =>
            {
                var apiCallPath = "/api/Lead/action/findOrCreate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (udf1 != null)
                    callPayload.Queries["udf1"] = ExpressionConverter.Convert(udf1);
                if (udf2 != null)
                    callPayload.Queries["udf2"] = ExpressionConverter.Convert(udf2);
                if (udf3 != null)
                    callPayload.Queries["udf3"] = ExpressionConverter.Convert(udf3);
                if (udf4 != null)
                    callPayload.Queries["udf4"] = ExpressionConverter.Convert(udf4);
                if (udf5 != null)
                    callPayload.Queries["udf5"] = ExpressionConverter.Convert(udf5);
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionAction<LeadFindOrCreateSchema>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "maximizercrm")]
        [WorkflowExpressionFactory(nameof(__BuildActionLeadConvert))]
        public IBodyWorkflowAction<LeadConvertSchema> ActionLeadConvert([WorkflowExpression] Func<convertOptionInput> convertOption = null, [WorkflowExpression] Func<doNotCreateAContactInput> doNotCreateAContact = null, [WorkflowExpression] Func<doNotCreateAnOpportunityInput> doNotCreateAnOpportunity = null, [WorkflowExpression] Func<object> body = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<LeadConvertSchema> __BuildActionLeadConvert(WorkflowValue<convertOptionInput> convertOption = null, WorkflowValue<doNotCreateAContactInput> doNotCreateAContact = null, WorkflowValue<doNotCreateAnOpportunityInput> doNotCreateAnOpportunity = null, WorkflowValue<object> body = null)
        {
            WorkflowValue.Validate(convertOption, nameof(convertOption), required: false);
            WorkflowValue.Validate(doNotCreateAContact, nameof(doNotCreateAContact), required: false);
            WorkflowValue.Validate(doNotCreateAnOpportunity, nameof(doNotCreateAnOpportunity), required: false);
            WorkflowValue.Validate(body, nameof(body), required: false);
            return new DeferredBodyAction<LeadConvertSchema>(() =>
            {
                var apiCallPath = "/api/Lead/action/convert";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["convertOption"] = Convert.ToString("newIndividual");
                if (convertOption != null)
                    callPayload.Queries["convertOption"] = ExpressionConverter.Convert(convertOption);
                callPayload.Queries["doNotCreateAContact"] = Convert.ToString("false");
                if (doNotCreateAContact != null)
                    callPayload.Queries["doNotCreateAContact"] = ExpressionConverter.Convert(doNotCreateAContact);
                callPayload.Queries["doNotCreateAnOpportunity"] = Convert.ToString("false");
                if (doNotCreateAnOpportunity != null)
                    callPayload.Queries["doNotCreateAnOpportunity"] = ExpressionConverter.Convert(doNotCreateAnOpportunity);
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionAction<LeadConvertSchema>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "maximizercrm")]
        [WorkflowExpressionFactory(nameof(__BuildActionNoteCreate))]
        public IBodyWorkflowAction<NoteCreateSchema> ActionNoteCreate([WorkflowExpression] Func<parentTypeInput> parentType, [WorkflowExpression] Func<object> body = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<NoteCreateSchema> __BuildActionNoteCreate(WorkflowValue<parentTypeInput> parentType, WorkflowValue<object> body = null)
        {
            WorkflowValue.Validate(parentType, nameof(parentType), required: true);
            WorkflowValue.Validate(body, nameof(body), required: false);
            return new DeferredBodyAction<NoteCreateSchema>(() =>
            {
                var apiCallPath = "/api/Note/action/create";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["parentType"] = ExpressionConverter.Convert(parentType);
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionAction<NoteCreateSchema>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "maximizercrm")]
        [WorkflowExpressionFactory(nameof(__BuildActionOpportunityFind))]
        public IBodyWorkflowAction<OpportunityFindSchema> ActionOpportunityFind([WorkflowExpression] Func<string> udf1 = null, [WorkflowExpression] Func<string> udf2 = null, [WorkflowExpression] Func<string> udf3 = null, [WorkflowExpression] Func<string> udf4 = null, [WorkflowExpression] Func<string> udf5 = null, [WorkflowExpression] Func<object> body = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<OpportunityFindSchema> __BuildActionOpportunityFind(WorkflowValue<string> udf1 = null, WorkflowValue<string> udf2 = null, WorkflowValue<string> udf3 = null, WorkflowValue<string> udf4 = null, WorkflowValue<string> udf5 = null, WorkflowValue<object> body = null)
        {
            WorkflowValue.Validate(udf1, nameof(udf1), required: false);
            WorkflowValue.Validate(udf2, nameof(udf2), required: false);
            WorkflowValue.Validate(udf3, nameof(udf3), required: false);
            WorkflowValue.Validate(udf4, nameof(udf4), required: false);
            WorkflowValue.Validate(udf5, nameof(udf5), required: false);
            WorkflowValue.Validate(body, nameof(body), required: false);
            return new DeferredBodyAction<OpportunityFindSchema>(() =>
            {
                var apiCallPath = "/api/Opportunity/action/find";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (udf1 != null)
                    callPayload.Queries["udf1"] = ExpressionConverter.Convert(udf1);
                if (udf2 != null)
                    callPayload.Queries["udf2"] = ExpressionConverter.Convert(udf2);
                if (udf3 != null)
                    callPayload.Queries["udf3"] = ExpressionConverter.Convert(udf3);
                if (udf4 != null)
                    callPayload.Queries["udf4"] = ExpressionConverter.Convert(udf4);
                if (udf5 != null)
                    callPayload.Queries["udf5"] = ExpressionConverter.Convert(udf5);
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionAction<OpportunityFindSchema>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "maximizercrm")]
        [WorkflowExpressionFactory(nameof(__BuildActionOpportunityCreate))]
        public IBodyWorkflowAction<OpportunityCreateSchema> ActionOpportunityCreate([WorkflowExpression] Func<object> body = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<OpportunityCreateSchema> __BuildActionOpportunityCreate(WorkflowValue<object> body = null)
        {
            WorkflowValue.Validate(body, nameof(body), required: false);
            return new DeferredBodyAction<OpportunityCreateSchema>(() =>
            {
                var apiCallPath = "/api/Opportunity/action/create";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionAction<OpportunityCreateSchema>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "maximizercrm")]
        [WorkflowExpressionFactory(nameof(__BuildActionOpportunityFindOrCreate))]
        public IBodyWorkflowAction<OpportunityFindOrCreateSchema> ActionOpportunityFindOrCreate([WorkflowExpression] Func<string> udf1 = null, [WorkflowExpression] Func<string> udf2 = null, [WorkflowExpression] Func<string> udf3 = null, [WorkflowExpression] Func<string> udf4 = null, [WorkflowExpression] Func<string> udf5 = null, [WorkflowExpression] Func<object> body = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<OpportunityFindOrCreateSchema> __BuildActionOpportunityFindOrCreate(WorkflowValue<string> udf1 = null, WorkflowValue<string> udf2 = null, WorkflowValue<string> udf3 = null, WorkflowValue<string> udf4 = null, WorkflowValue<string> udf5 = null, WorkflowValue<object> body = null)
        {
            WorkflowValue.Validate(udf1, nameof(udf1), required: false);
            WorkflowValue.Validate(udf2, nameof(udf2), required: false);
            WorkflowValue.Validate(udf3, nameof(udf3), required: false);
            WorkflowValue.Validate(udf4, nameof(udf4), required: false);
            WorkflowValue.Validate(udf5, nameof(udf5), required: false);
            WorkflowValue.Validate(body, nameof(body), required: false);
            return new DeferredBodyAction<OpportunityFindOrCreateSchema>(() =>
            {
                var apiCallPath = "/api/Opportunity/action/findOrCreate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (udf1 != null)
                    callPayload.Queries["udf1"] = ExpressionConverter.Convert(udf1);
                if (udf2 != null)
                    callPayload.Queries["udf2"] = ExpressionConverter.Convert(udf2);
                if (udf3 != null)
                    callPayload.Queries["udf3"] = ExpressionConverter.Convert(udf3);
                if (udf4 != null)
                    callPayload.Queries["udf4"] = ExpressionConverter.Convert(udf4);
                if (udf5 != null)
                    callPayload.Queries["udf5"] = ExpressionConverter.Convert(udf5);
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionAction<OpportunityFindOrCreateSchema>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "maximizercrm")]
        [WorkflowExpressionFactory(nameof(__BuildActionOpportunityUpdate))]
        public IBodyWorkflowAction<OpportunityUpdateSchema> ActionOpportunityUpdate([WorkflowExpression] Func<object> body = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<OpportunityUpdateSchema> __BuildActionOpportunityUpdate(WorkflowValue<object> body = null)
        {
            WorkflowValue.Validate(body, nameof(body), required: false);
            return new DeferredBodyAction<OpportunityUpdateSchema>(() =>
            {
                var apiCallPath = "/api/Opportunity/action/update";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionAction<OpportunityUpdateSchema>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "maximizercrm")]
        [WorkflowExpressionFactory(nameof(__BuildActionPTaskCreate))]
        public IBodyWorkflowAction<PersonalTaskCreateSchema> ActionPTaskCreate([WorkflowExpression] Func<object> body = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PersonalTaskCreateSchema> __BuildActionPTaskCreate(WorkflowValue<object> body = null)
        {
            WorkflowValue.Validate(body, nameof(body), required: false);
            return new DeferredBodyAction<PersonalTaskCreateSchema>(() =>
            {
                var apiCallPath = "/api/PTask/action/create";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionAction<PersonalTaskCreateSchema>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "maximizercrm")]
        [WorkflowExpressionFactory(nameof(__BuildActionUserFind))]
        public IBodyWorkflowAction<UserFindSchema> ActionUserFind([WorkflowExpression] Func<object> body = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<UserFindSchema> __BuildActionUserFind(WorkflowValue<object> body = null)
        {
            WorkflowValue.Validate(body, nameof(body), required: false);
            return new DeferredBodyAction<UserFindSchema>(() =>
            {
                var apiCallPath = "/api/User/action/find";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionAction<UserFindSchema>(callPayload);
            });
        }
    }

    public class MaximizercrmTriggers([ConnectionName] string connectionId)
    {
        [WorkflowExpressionFactory(nameof(__BuildTriggerAbEntryUpdated))]
        public IBodyWorkflowTrigger<AbEntryTriggerSchema> TriggerAbEntryUpdated([WorkflowExpression] Func<object> body = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<AbEntryTriggerSchema> __BuildTriggerAbEntryUpdated(WorkflowValue<object> body = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(body, nameof(body), required: false);
            return new DeferredBodyTrigger<AbEntryTriggerSchema>(() =>
            {
                var apiCallPath = "/api/AbEntry/trigger/updated";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionTrigger<AbEntryTriggerSchema>(callPayload, triggerName, recurrence);
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildTriggerAbEntryCreated))]
        public IBodyWorkflowTrigger<AbEntryTriggerSchema> TriggerAbEntryCreated([WorkflowExpression] Func<object> body = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<AbEntryTriggerSchema> __BuildTriggerAbEntryCreated(WorkflowValue<object> body = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(body, nameof(body), required: false);
            return new DeferredBodyTrigger<AbEntryTriggerSchema>(() =>
            {
                var apiCallPath = "/api/AbEntry/trigger/created";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionTrigger<AbEntryTriggerSchema>(callPayload, triggerName, recurrence);
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildTriggerAbEntryDateNotification))]
        public IBodyWorkflowTrigger<AbEntryTriggerSchema> TriggerAbEntryDateNotification([WorkflowExpression] Func<object> body = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<AbEntryTriggerSchema> __BuildTriggerAbEntryDateNotification(WorkflowValue<object> body = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(body, nameof(body), required: false);
            return new DeferredBodyTrigger<AbEntryTriggerSchema>(() =>
            {
                var apiCallPath = "/api/AbEntry/trigger/DateNotification";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionTrigger<AbEntryTriggerSchema>(callPayload, triggerName, recurrence);
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildTriggerAppointmentUpdated))]
        public IBodyWorkflowTrigger<AppointmentTriggerSchema> TriggerAppointmentUpdated([WorkflowExpression] Func<object> body = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<AppointmentTriggerSchema> __BuildTriggerAppointmentUpdated(WorkflowValue<object> body = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(body, nameof(body), required: false);
            return new DeferredBodyTrigger<AppointmentTriggerSchema>(() =>
            {
                var apiCallPath = "/api/Appointment/trigger/Updated";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionTrigger<AppointmentTriggerSchema>(callPayload, triggerName, recurrence);
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildTriggerAppointmentCreated))]
        public IBodyWorkflowTrigger<AppointmentTriggerSchema> TriggerAppointmentCreated([WorkflowExpression] Func<object> body = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<AppointmentTriggerSchema> __BuildTriggerAppointmentCreated(WorkflowValue<object> body = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(body, nameof(body), required: false);
            return new DeferredBodyTrigger<AppointmentTriggerSchema>(() =>
            {
                var apiCallPath = "/api/Appointment/trigger/created";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionTrigger<AppointmentTriggerSchema>(callPayload, triggerName, recurrence);
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildTriggerAppointmentDateNotification))]
        public IBodyWorkflowTrigger<AppointmentTriggerSchema> TriggerAppointmentDateNotification([WorkflowExpression] Func<object> body = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<AppointmentTriggerSchema> __BuildTriggerAppointmentDateNotification(WorkflowValue<object> body = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(body, nameof(body), required: false);
            return new DeferredBodyTrigger<AppointmentTriggerSchema>(() =>
            {
                var apiCallPath = "/api/Appointment/trigger/DateNotification";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionTrigger<AppointmentTriggerSchema>(callPayload, triggerName, recurrence);
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildTriggerCaseUpdated))]
        public IBodyWorkflowTrigger<CaseTriggerSchema> TriggerCaseUpdated([WorkflowExpression] Func<object> body = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<CaseTriggerSchema> __BuildTriggerCaseUpdated(WorkflowValue<object> body = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(body, nameof(body), required: false);
            return new DeferredBodyTrigger<CaseTriggerSchema>(() =>
            {
                var apiCallPath = "/api/Case/api/Case/trigger/Updated";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionTrigger<CaseTriggerSchema>(callPayload, triggerName, recurrence);
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildTriggerCaseDateNotification))]
        public IBodyWorkflowTrigger<CaseTriggerSchema> TriggerCaseDateNotification([WorkflowExpression] Func<object> body = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<CaseTriggerSchema> __BuildTriggerCaseDateNotification(WorkflowValue<object> body = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(body, nameof(body), required: false);
            return new DeferredBodyTrigger<CaseTriggerSchema>(() =>
            {
                var apiCallPath = "/api/Case/trigger/DateNotification";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionTrigger<CaseTriggerSchema>(callPayload, triggerName, recurrence);
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildTriggerCaseCreated))]
        public IBodyWorkflowTrigger<CaseTriggerSchema> TriggerCaseCreated([WorkflowExpression] Func<object> body = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<CaseTriggerSchema> __BuildTriggerCaseCreated(WorkflowValue<object> body = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(body, nameof(body), required: false);
            return new DeferredBodyTrigger<CaseTriggerSchema>(() =>
            {
                var apiCallPath = "/api/Case/api/Case/trigger/Created";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionTrigger<CaseTriggerSchema>(callPayload, triggerName, recurrence);
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildTriggerHTaskCreated))]
        public IBodyWorkflowTrigger<HotlistTaskTriggerSchema> TriggerHTaskCreated([WorkflowExpression] Func<object> body = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<HotlistTaskTriggerSchema> __BuildTriggerHTaskCreated(WorkflowValue<object> body = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(body, nameof(body), required: false);
            return new DeferredBodyTrigger<HotlistTaskTriggerSchema>(() =>
            {
                var apiCallPath = "/api/HotlistTask/trigger/created";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionTrigger<HotlistTaskTriggerSchema>(callPayload, triggerName, recurrence);
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildTriggerLeadDateNotification))]
        public IBodyWorkflowTrigger<LeadTriggerSchema> TriggerLeadDateNotification([WorkflowExpression] Func<object> body = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<LeadTriggerSchema> __BuildTriggerLeadDateNotification(WorkflowValue<object> body = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(body, nameof(body), required: false);
            return new DeferredBodyTrigger<LeadTriggerSchema>(() =>
            {
                var apiCallPath = "/api/Lead/trigger/DateNotification";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionTrigger<LeadTriggerSchema>(callPayload, triggerName, recurrence);
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildTriggerLeadUpdated))]
        public IBodyWorkflowTrigger<LeadTriggerSchema> TriggerLeadUpdated([WorkflowExpression] Func<object> body = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<LeadTriggerSchema> __BuildTriggerLeadUpdated(WorkflowValue<object> body = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(body, nameof(body), required: false);
            return new DeferredBodyTrigger<LeadTriggerSchema>(() =>
            {
                var apiCallPath = "/api/Lead/trigger/updated";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionTrigger<LeadTriggerSchema>(callPayload, triggerName, recurrence);
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildTriggerLeadCreated))]
        public IBodyWorkflowTrigger<LeadTriggerSchema> TriggerLeadCreated([WorkflowExpression] Func<object> body = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<LeadTriggerSchema> __BuildTriggerLeadCreated(WorkflowValue<object> body = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(body, nameof(body), required: false);
            return new DeferredBodyTrigger<LeadTriggerSchema>(() =>
            {
                var apiCallPath = "/api/Lead/trigger/created";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionTrigger<LeadTriggerSchema>(callPayload, triggerName, recurrence);
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildWebhookOppStageChanged))]
        public IBodyWorkflowTrigger<WebhookCreated> WebhookOppStageChanged([WorkflowExpression] Func<object> body = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<WebhookCreated> __BuildWebhookOppStageChanged(WorkflowValue<object> body = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(body, nameof(body), required: false);
            return new DeferredBodyTrigger<WebhookCreated>(() =>
            {
                var apiCallPath = "/api/Opportunity/webhook/OpportunityStageChanged";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionTrigger<WebhookCreated>(callPayload, triggerName, recurrence);
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildTriggerOppCreated))]
        public IBodyWorkflowTrigger<OpportunityTriggerSchema> TriggerOppCreated([WorkflowExpression] Func<object> body = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<OpportunityTriggerSchema> __BuildTriggerOppCreated(WorkflowValue<object> body = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(body, nameof(body), required: false);
            return new DeferredBodyTrigger<OpportunityTriggerSchema>(() =>
            {
                var apiCallPath = "/api/Opportunity/trigger/Created";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionTrigger<OpportunityTriggerSchema>(callPayload, triggerName, recurrence);
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildTriggerOppUpdated))]
        public IBodyWorkflowTrigger<OpportunityTriggerSchema> TriggerOppUpdated([WorkflowExpression] Func<object> body = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<OpportunityTriggerSchema> __BuildTriggerOppUpdated(WorkflowValue<object> body = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(body, nameof(body), required: false);
            return new DeferredBodyTrigger<OpportunityTriggerSchema>(() =>
            {
                var apiCallPath = "/api/Opportunity/trigger/Updated";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionTrigger<OpportunityTriggerSchema>(callPayload, triggerName, recurrence);
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildTriggerOpportunityDateNotification))]
        public IBodyWorkflowTrigger<OpportunityTriggerSchema> TriggerOpportunityDateNotification([WorkflowExpression] Func<object> body = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<OpportunityTriggerSchema> __BuildTriggerOpportunityDateNotification(WorkflowValue<object> body = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(body, nameof(body), required: false);
            return new DeferredBodyTrigger<OpportunityTriggerSchema>(() =>
            {
                var apiCallPath = "/api/Opportunity/trigger/DateNotification";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionTrigger<OpportunityTriggerSchema>(callPayload, triggerName, recurrence);
            }, triggerName);
        }
    }

    public class AbEntryFindSchema
    {
        [JsonProperty("abEntries")]
        public PaAbEntryView[] AbEntries { get; set; }
    }

    public class PaAbEntryView
    {
        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("company")]
        public string Company { get; set; }

        [JsonProperty("mrMs")]
        public string MrMs { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("middleName")]
        public string MiddleName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("fullName")]
        public string FullName { get; set; }

        [JsonProperty("position")]
        public string Position { get; set; }

        [JsonProperty("salutation")]
        public string Salutation { get; set; }

        [JsonProperty("department")]
        public string Department { get; set; }

        [JsonProperty("division")]
        public string Division { get; set; }

        [JsonProperty("phone1Description")]
        public string Phone1Description { get; set; }

        [JsonProperty("phone1Number")]
        public string Phone1Number { get; set; }

        [JsonProperty("phone1Extension")]
        public string Phone1Extension { get; set; }

        [JsonProperty("phone2Description")]
        public string Phone2Description { get; set; }

        [JsonProperty("phone2Number")]
        public string Phone2Number { get; set; }

        [JsonProperty("phone2Extension")]
        public string Phone2Extension { get; set; }

        [JsonProperty("phone3Description")]
        public string Phone3Description { get; set; }

        [JsonProperty("phone3Number")]
        public string Phone3Number { get; set; }

        [JsonProperty("phone3Extension")]
        public string Phone3Extension { get; set; }

        [JsonProperty("phone4Description")]
        public string Phone4Description { get; set; }

        [JsonProperty("phone4Number")]
        public string Phone4Number { get; set; }

        [JsonProperty("phone4Extension")]
        public string Phone4Extension { get; set; }

        [JsonProperty("addressLine1")]
        public string AddressLine1 { get; set; }

        [JsonProperty("addressLine2")]
        public string AddressLine2 { get; set; }

        [JsonProperty("cityTown")]
        public string CityTown { get; set; }

        [JsonProperty("stateProvince")]
        public string StateProvince { get; set; }

        [JsonProperty("zipCode")]
        public string ZipCode { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("territoryKey")]
        public string TerritoryKey { get; set; }

        [JsonProperty("territory")]
        public string Territory { get; set; }

        [JsonProperty("territoryStatusKey")]
        public int TerritoryStatusKey { get; set; }

        [JsonProperty("territoryStatusValue")]
        public string TerritoryStatusValue { get; set; }

        [JsonProperty("partnersKey")]
        public string PartnersKey { get; set; }

        [JsonProperty("partnersEmail")]
        public string PartnersEmail { get; set; }

        [JsonProperty("partnersType")]
        public string PartnersType { get; set; }

        [JsonProperty("partnersCompany")]
        public string PartnersCompany { get; set; }

        [JsonProperty("partnersMrMs")]
        public string PartnersMrMs { get; set; }

        [JsonProperty("partnersFirstName")]
        public string PartnersFirstName { get; set; }

        [JsonProperty("partnersMiddleName")]
        public string PartnersMiddleName { get; set; }

        [JsonProperty("partnersLastName")]
        public string PartnersLastName { get; set; }

        [JsonProperty("partnersFullName")]
        public string PartnersFullName { get; set; }

        [JsonProperty("creationDate")]
        public string CreationDate { get; set; }

        [JsonProperty("lastModifiedDate")]
        public string LastModifiedDate { get; set; }

        [JsonProperty("email1Description")]
        public string Email1Description { get; set; }

        [JsonProperty("email1")]
        public string Email1 { get; set; }

        [JsonProperty("website")]
        public string Website { get; set; }

        [JsonProperty("email2Description")]
        public string Email2Description { get; set; }

        [JsonProperty("email2")]
        public string Email2 { get; set; }

        [JsonProperty("email3Description")]
        public string Email3Description { get; set; }

        [JsonProperty("email3")]
        public string Email3 { get; set; }

        [JsonProperty("lastContactedDate")]
        public string LastContactedDate { get; set; }

        [JsonProperty("phone1DefaultStatus")]
        public bool Phone1DefaultStatus { get; set; }

        [JsonProperty("phone2DefaultStatus")]
        public bool Phone2DefaultStatus { get; set; }

        [JsonProperty("phone3DefaultStatus")]
        public bool Phone3DefaultStatus { get; set; }

        [JsonProperty("phone4DefaultStatus")]
        public bool Phone4DefaultStatus { get; set; }

        [JsonProperty("email1DefaultStatus")]
        public bool Email1DefaultStatus { get; set; }

        [JsonProperty("email2DefaultStatus")]
        public bool Email2DefaultStatus { get; set; }

        [JsonProperty("email3DefaultStatus")]
        public bool Email3DefaultStatus { get; set; }

        [JsonProperty("userDefinedFields")]
        public JToken UserDefinedFields { get; set; }
    }

    public class AbEntryCreateSchema
    {
        [JsonProperty("abEntries")]
        public PaAbEntryView[] AbEntries { get; set; }
    }

    public enum applyActionToInput
    {
        Individual,
        Company,
        Contact
    }

    public class AbEntryUpdateSchema
    {
        [JsonProperty("abEntries")]
        public PaAbEntryView[] AbEntries { get; set; }
    }

    public class AppointmentCreateSchema
    {
        [JsonProperty("appointments")]
        public PAAppointmentView[] Appointments { get; set; }
    }

    public class PAAppointmentView
    {
        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("startDate")]
        public string StartDate { get; set; }

        [JsonProperty("endDate")]
        public string EndDate { get; set; }

        [JsonProperty("organizerUid")]
        public string OrganizerUid { get; set; }

        [JsonProperty("organizerValue")]
        public string OrganizerValue { get; set; }

        [JsonProperty("private")]
        public bool Private { get; set; }

        [JsonProperty("users")]
        public AppointmentUser[] Users { get; set; }

        [JsonProperty("abEntries")]
        public AppointmentAbEntry[] AbEntries { get; set; }

        [JsonProperty("locationKey")]
        public string LocationKey { get; set; }

        [JsonProperty("locationName")]
        public string LocationName { get; set; }

        [JsonProperty("resourcesItems")]
        public AppointmentResourcesItem[] ResourcesItems { get; set; }

        [JsonProperty("recurringPatternKey")]
        public string RecurringPatternKey { get; set; }

        [JsonProperty("recurringPatternStartDate")]
        public string RecurringPatternStartDate { get; set; }

        [JsonProperty("recurringPatternEndDate")]
        public string RecurringPatternEndDate { get; set; }

        [JsonProperty("recurringPatternFrequency")]
        public int RecurringPatternFrequency { get; set; }

        [JsonProperty("recurringPatternOccurence")]
        public int RecurringPatternOccurence { get; set; }

        [JsonProperty("recurringPatternDayOfWeek")]
        public int RecurringPatternDayOfWeek { get; set; }

        [JsonProperty("recurringPatternSkipWeekend")]
        public bool RecurringPatternSkipWeekend { get; set; }

        [JsonProperty("recurringPatternMoveToWeekday")]
        public bool RecurringPatternMoveToWeekday { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("actionPlan")]
        public string ActionPlan { get; set; }

        [JsonProperty("categoryItems")]
        public AppointmentCategoryItem[] CategoryItems { get; set; }

        [JsonProperty("interactionCategoryItems")]
        public AppointmentInteractionCategoryItem[] InteractionCategoryItems { get; set; }

        [JsonProperty("productItems")]
        public AppointmentProductItem[] ProductItems { get; set; }

        [JsonProperty("resultItems")]
        public AppointmentResultItem[] ResultItems { get; set; }

        [JsonProperty("leads")]
        public AppointmentLeadItem[] Leads { get; set; }

        [JsonProperty("priority")]
        public string Priority { get; set; }

        [JsonProperty("withKey")]
        public string WithKey { get; set; }

        [JsonProperty("withEntityType")]
        public string WithEntityType { get; set; }

        [JsonProperty("withOpportunityKeyValue")]
        public string WithOpportunityKeyValue { get; set; }

        [JsonProperty("withOpportunityKeyID")]
        public string WithOpportunityKeyID { get; set; }

        [JsonProperty("withOpportunityAbEntryKey")]
        public string WithOpportunityAbEntryKey { get; set; }

        [JsonProperty("withOpportunityAbEntryEmail")]
        public string WithOpportunityAbEntryEmail { get; set; }

        [JsonProperty("withOpportunityAbEntryType")]
        public string WithOpportunityAbEntryType { get; set; }

        [JsonProperty("withOpportunityAbEntryCompanyName")]
        public string WithOpportunityAbEntryCompanyName { get; set; }

        [JsonProperty("withOpportunityContactKey")]
        public string WithOpportunityContactKey { get; set; }

        [JsonProperty("withOpportunityContactEmail")]
        public string WithOpportunityContactEmail { get; set; }

        [JsonProperty("withOpportunityContactType")]
        public string WithOpportunityContactType { get; set; }

        [JsonProperty("withOpportunityContactCompanyName")]
        public string WithOpportunityContactCompanyName { get; set; }

        [JsonProperty("withOpportunityContactMrMs")]
        public string WithOpportunityContactMrMs { get; set; }

        [JsonProperty("withOpportunityContactFirstName")]
        public string WithOpportunityContactFirstName { get; set; }

        [JsonProperty("withOpportunityContactMiddleName")]
        public string WithOpportunityContactMiddleName { get; set; }

        [JsonProperty("withOpportunityContactLastName")]
        public string WithOpportunityContactLastName { get; set; }

        [JsonProperty("withOpportunityContactFullName")]
        public string WithOpportunityContactFullName { get; set; }

        [JsonProperty("withOpportunityObjective")]
        public string WithOpportunityObjective { get; set; }

        [JsonProperty("withOpportunityDescription")]
        public string WithOpportunityDescription { get; set; }

        [JsonProperty("withOpportunityStatusKey")]
        public string WithOpportunityStatusKey { get; set; }

        [JsonProperty("withOpportunityStatusDisplayValue")]
        public string WithOpportunityStatusDisplayValue { get; set; }

        [JsonProperty("withOpportunityCost")]
        public double WithOpportunityCost { get; set; }

        [JsonProperty("withOpportunityActualRevenue")]
        public double WithOpportunityActualRevenue { get; set; }

        [JsonProperty("withOpportunityForecastRevenue")]
        public double WithOpportunityForecastRevenue { get; set; }

        [JsonProperty("withOpportunityStartDate")]
        public string WithOpportunityStartDate { get; set; }

        [JsonProperty("withOpportunityCloseDate")]
        public string WithOpportunityCloseDate { get; set; }

        [JsonProperty("withOpportunityCreationDate")]
        public string WithOpportunityCreationDate { get; set; }

        [JsonProperty("withOpportunityLastModifyDate")]
        public string WithOpportunityLastModifyDate { get; set; }

        [JsonProperty("withOpportunityLeaderKeyValue")]
        public string WithOpportunityLeaderKeyValue { get; set; }

        [JsonProperty("withOpportunityLeaderKeyUID")]
        public string WithOpportunityLeaderKeyUID { get; set; }

        [JsonProperty("withOpportunityLeaderDisplayValue")]
        public string WithOpportunityLeaderDisplayValue { get; set; }

        [JsonProperty("withOpportunitySalesTeamKeyValue")]
        public string WithOpportunitySalesTeamKeyValue { get; set; }

        [JsonProperty("withOpportunitySalesTeamKeyID")]
        public int WithOpportunitySalesTeamKeyID { get; set; }

        [JsonProperty("withOpportunitySalesTeamDisplayValue")]
        public string WithOpportunitySalesTeamDisplayValue { get; set; }

        [JsonProperty("withOpportunityNextAction")]
        public string WithOpportunityNextAction { get; set; }

        [JsonProperty("withOpportunitySalesProcessSetupKey")]
        public string WithOpportunitySalesProcessSetupKey { get; set; }

        [JsonProperty("withOpportunitySalesProcessSetupDisplayValue")]
        public string WithOpportunitySalesProcessSetupDisplayValue { get; set; }

        [JsonProperty("withOpportunitySalesStageSetupKey")]
        public string WithOpportunitySalesStageSetupKey { get; set; }

        [JsonProperty("withOpportunitySalesStageSetupDisplayValue")]
        public string WithOpportunitySalesStageSetupDisplayValue { get; set; }

        [JsonProperty("withOpportunitySalesProcessKey")]
        public string WithOpportunitySalesProcessKey { get; set; }

        [JsonProperty("withOpportunitySalesProcessDisplayValue")]
        public string WithOpportunitySalesProcessDisplayValue { get; set; }

        [JsonProperty("withOpportunityCurrentSalesStageKey")]
        public string WithOpportunityCurrentSalesStageKey { get; set; }

        [JsonProperty("withOpportunityCurrentSalesStageDisplayValue")]
        public string WithOpportunityCurrentSalesStageDisplayValue { get; set; }

        [JsonProperty("withOpportunityPartnerKeys")]
        public string[] WithOpportunityPartnerKeys { get; set; }

        [JsonProperty("withOpportunityPartnerInfo")]
        public string[] WithOpportunityPartnerInfo { get; set; }

        [JsonProperty("withOpportunityCompetitorInfo")]
        public string[] WithOpportunityCompetitorInfo { get; set; }

        [JsonProperty("withOpportunityComment")]
        public string WithOpportunityComment { get; set; }

        [JsonProperty("withOpportunityReason")]
        public string WithOpportunityReason { get; set; }

        [JsonProperty("withOpportunityDisplayValue")]
        public string WithOpportunityDisplayValue { get; set; }

        [JsonProperty("withOpportunityCampaignKey")]
        public string WithOpportunityCampaignKey { get; set; }

        [JsonProperty("withOpportunityCampaign")]
        public string WithOpportunityCampaign { get; set; }

        [JsonProperty("withOpportunityCategory")]
        public AppointmentOpportunityCategoryItem[] WithOpportunityCategory { get; set; }

        [JsonProperty("withOpportunityProduct")]
        public AppointmentOpportunityProductItem[] WithOpportunityProduct { get; set; }

        [JsonProperty("withOpportunityRating")]
        public AppointmentOpportunityRatingItem[] WithOpportunityRating { get; set; }

        [JsonProperty("withCaseKeyValue")]
        public string WithCaseKeyValue { get; set; }

        [JsonProperty("withCaseKeyId")]
        public string WithCaseKeyId { get; set; }

        [JsonProperty("withCaseNumber")]
        public string WithCaseNumber { get; set; }

        [JsonProperty("withCaseSubject")]
        public string WithCaseSubject { get; set; }

        [JsonProperty("withCaseDescription")]
        public string WithCaseDescription { get; set; }

        [JsonProperty("withCaseAbEntryKey")]
        public string WithCaseAbEntryKey { get; set; }

        [JsonProperty("withCaseAbEntryEmail")]
        public string WithCaseAbEntryEmail { get; set; }

        [JsonProperty("withCaseAbEntryType")]
        public string WithCaseAbEntryType { get; set; }

        [JsonProperty("withCaseAbEntryCompanyName")]
        public string WithCaseAbEntryCompanyName { get; set; }

        [JsonProperty("withCaseContactKey")]
        public string WithCaseContactKey { get; set; }

        [JsonProperty("withCaseContactEmail")]
        public string WithCaseContactEmail { get; set; }

        [JsonProperty("withCaseContactType")]
        public string WithCaseContactType { get; set; }

        [JsonProperty("withCaseContactCompanyName")]
        public string WithCaseContactCompanyName { get; set; }

        [JsonProperty("withCaseContactMrMs")]
        public string WithCaseContactMrMs { get; set; }

        [JsonProperty("withCaseContactFirstName")]
        public string WithCaseContactFirstName { get; set; }

        [JsonProperty("withCaseContactMiddleName")]
        public string WithCaseContactMiddleName { get; set; }

        [JsonProperty("withCaseContactLastName")]
        public string WithCaseContactLastName { get; set; }

        [JsonProperty("withCaseContactFullName")]
        public string WithCaseContactFullName { get; set; }

        [JsonProperty("withCaseAssignedToKeyValue")]
        public string WithCaseAssignedToKeyValue { get; set; }

        [JsonProperty("withCaseAssignedToKeyUid")]
        public string WithCaseAssignedToKeyUid { get; set; }

        [JsonProperty("withCaseAssignedToDisplayValue")]
        public string WithCaseAssignedToDisplayValue { get; set; }

        [JsonProperty("withCasePriorityKey")]
        public string WithCasePriorityKey { get; set; }

        [JsonProperty("withCasePriorityDisplayValue")]
        public string WithCasePriorityDisplayValue { get; set; }

        [JsonProperty("withCaseSeverityKey")]
        public string WithCaseSeverityKey { get; set; }

        [JsonProperty("withCaseSeverityDisplayValue")]
        public string WithCaseSeverityDisplayValue { get; set; }

        [JsonProperty("withCaseResolvedDate")]
        public string WithCaseResolvedDate { get; set; }

        [JsonProperty("withCaseResolvedBy")]
        public string WithCaseResolvedBy { get; set; }

        [JsonProperty("withCaseOwnerKeyValue")]
        public string WithCaseOwnerKeyValue { get; set; }

        [JsonProperty("withCaseOwnerKeyUid")]
        public string WithCaseOwnerKeyUid { get; set; }

        [JsonProperty("withCaseOwnerDisplayValue")]
        public string WithCaseOwnerDisplayValue { get; set; }

        [JsonProperty("withCaseFollowUpDate")]
        public string WithCaseFollowUpDate { get; set; }

        [JsonProperty("withCaseLastModifyDate")]
        public string WithCaseLastModifyDate { get; set; }

        [JsonProperty("withCaseCreationDate")]
        public string WithCaseCreationDate { get; set; }

        [JsonProperty("withCaseDisplayValue")]
        public string WithCaseDisplayValue { get; set; }

        [JsonProperty("withCaseTypeKey")]
        public string WithCaseTypeKey { get; set; }

        [JsonProperty("withCaseTypeDisplayValue")]
        public string WithCaseTypeDisplayValue { get; set; }

        [JsonProperty("withCaseReasonKey")]
        public string WithCaseReasonKey { get; set; }

        [JsonProperty("withCaseReasonDisplayValue")]
        public string WithCaseReasonDisplayValue { get; set; }

        [JsonProperty("withCaseOriginKey")]
        public string WithCaseOriginKey { get; set; }

        [JsonProperty("withCaseOriginDisplayValue")]
        public string WithCaseOriginDisplayValue { get; set; }

        [JsonProperty("withCaseCategory")]
        public AppointmentCaseCategoryItem[] WithCaseCategory { get; set; }

        [JsonProperty("withCaseProduct")]
        public AppointmentCaseProductItem[] WithCaseProduct { get; set; }

        [JsonProperty("withCaseQueueKey")]
        public string WithCaseQueueKey { get; set; }

        [JsonProperty("withCaseQueueDisplayValue")]
        public string WithCaseQueueDisplayValue { get; set; }

        [JsonProperty("withCaseStatusKey")]
        public string WithCaseStatusKey { get; set; }

        [JsonProperty("withCaseStatusDisplayValue")]
        public string WithCaseStatusDisplayValue { get; set; }
    }

    public class AppointmentUser
    {
        [JsonProperty("userUid")]
        public string UserUid { get; set; }

        [JsonProperty("userRsvp")]
        public int UserRsvp { get; set; }

        [JsonProperty("userAlarmFlags")]
        public int UserAlarmFlags { get; set; }

        [JsonProperty("userAlarmLead")]
        public string UserAlarmLead { get; set; }

        [JsonProperty("userReminderFlags")]
        public int UserReminderFlags { get; set; }

        [JsonProperty("userReminderLead")]
        public string UserReminderLead { get; set; }

        [JsonProperty("userCompleted")]
        public bool UserCompleted { get; set; }

        [JsonProperty("userIcon")]
        public int UserIcon { get; set; }
    }

    public class AppointmentAbEntry
    {
        [JsonProperty("abEntryKey")]
        public string AbEntryKey { get; set; }

        [JsonProperty("abEntryEmail")]
        public string AbEntryEmail { get; set; }

        [JsonProperty("abEntryType")]
        public string AbEntryType { get; set; }

        [JsonProperty("abEntryCompanyName")]
        public string AbEntryCompanyName { get; set; }

        [JsonProperty("abEntryMrMs")]
        public string AbEntryMrMs { get; set; }

        [JsonProperty("abEntryFirstName")]
        public string AbEntryFirstName { get; set; }

        [JsonProperty("abEntryMiddleName")]
        public string AbEntryMiddleName { get; set; }

        [JsonProperty("abEntryLastName")]
        public string AbEntryLastName { get; set; }

        [JsonProperty("abEntryFullName")]
        public string AbEntryFullName { get; set; }
    }

    public class AppointmentResourcesItem
    {
        [JsonProperty("resourcesItemKey")]
        public string ResourcesItemKey { get; set; }

        [JsonProperty("resourcesItemDisplayValue")]
        public string ResourcesItemDisplayValue { get; set; }
    }

    public class AppointmentCategoryItem
    {
        [JsonProperty("categoryItemKey")]
        public string CategoryItemKey { get; set; }

        [JsonProperty("categoryItemDisplayValue")]
        public string CategoryItemDisplayValue { get; set; }
    }

    public class AppointmentInteractionCategoryItem
    {
        [JsonProperty("interactionCategoryItemKey")]
        public string InteractionCategoryItemKey { get; set; }

        [JsonProperty("interactionCategoryItemDisplayValue")]
        public string InteractionCategoryItemDisplayValue { get; set; }
    }

    public class AppointmentProductItem
    {
        [JsonProperty("productItemKey")]
        public string ProductItemKey { get; set; }

        [JsonProperty("productItemDisplayValue")]
        public string ProductItemDisplayValue { get; set; }
    }

    public class AppointmentResultItem
    {
        [JsonProperty("resultItemKey")]
        public string ResultItemKey { get; set; }

        [JsonProperty("resultItemDisplayValue")]
        public string ResultItemDisplayValue { get; set; }
    }

    public class AppointmentLeadItem
    {
        [JsonProperty("leadKey")]
        public string LeadKey { get; set; }
    }

    public class AppointmentOpportunityCategoryItem
    {
        [JsonProperty("opportunityCategoryItemKey")]
        public string OpportunityCategoryItemKey { get; set; }

        [JsonProperty("opportunityCategoryItemValue")]
        public string OpportunityCategoryItemValue { get; set; }
    }

    public class AppointmentOpportunityProductItem
    {
        [JsonProperty("opportunityProductItemKey")]
        public string OpportunityProductItemKey { get; set; }

        [JsonProperty("opportunityProductItemValue")]
        public string OpportunityProductItemValue { get; set; }
    }

    public class AppointmentOpportunityRatingItem
    {
        [JsonProperty("opportunityRatingItemKey")]
        public string OpportunityRatingItemKey { get; set; }

        [JsonProperty("opportunityRatingItemValue")]
        public string OpportunityRatingItemValue { get; set; }
    }

    public class AppointmentCaseCategoryItem
    {
        [JsonProperty("caseCategoryItemKey")]
        public string CaseCategoryItemKey { get; set; }

        [JsonProperty("caseCategoryItemValue")]
        public string CaseCategoryItemValue { get; set; }
    }

    public class AppointmentCaseProductItem
    {
        [JsonProperty("caseProductItemKey")]
        public string CaseProductItemKey { get; set; }

        [JsonProperty("caseProductItemValue")]
        public string CaseProductItemValue { get; set; }
    }

    public enum linkWithTypeInput
    {
        Case,
        Opportunity
    }

    public class AppointmentUpdateSchema
    {
        [JsonProperty("appointments")]
        public PAAppointmentView[] Appointments { get; set; }
    }

    public class PACaseView
    {
        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("caseNumber")]
        public string CaseNumber { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("caseAbEntryID")]
        public string CaseAbEntryID { get; set; }

        [JsonProperty("caseAbEntryKey")]
        public string CaseAbEntryKey { get; set; }

        [JsonProperty("caseAbEntryEmail")]
        public string CaseAbEntryEmail { get; set; }

        [JsonProperty("caseAbEntryType")]
        public string CaseAbEntryType { get; set; }

        [JsonProperty("caseAbEntryCompanyName")]
        public string CaseAbEntryCompanyName { get; set; }

        [JsonProperty("caseAbEntryMrMs")]
        public string CaseAbEntryMrMs { get; set; }

        [JsonProperty("caseAbEntryFirstName")]
        public string CaseAbEntryFirstName { get; set; }

        [JsonProperty("caseAbEntryMiddleName")]
        public string CaseAbEntryMiddleName { get; set; }

        [JsonProperty("caseAbEntryLastName")]
        public string CaseAbEntryLastName { get; set; }

        [JsonProperty("caseAbEntryFullName")]
        public string CaseAbEntryFullName { get; set; }

        [JsonProperty("caseContactID")]
        public string CaseContactID { get; set; }

        [JsonProperty("caseContactKey")]
        public string CaseContactKey { get; set; }

        [JsonProperty("caseContactEmail")]
        public string CaseContactEmail { get; set; }

        [JsonProperty("caseContactType")]
        public string CaseContactType { get; set; }

        [JsonProperty("caseContactCompanyName")]
        public string CaseContactCompanyName { get; set; }

        [JsonProperty("caseContactMrMs")]
        public string CaseContactMrMs { get; set; }

        [JsonProperty("caseContactFirstName")]
        public string CaseContactFirstName { get; set; }

        [JsonProperty("caseContactMiddleName")]
        public string CaseContactMiddleName { get; set; }

        [JsonProperty("caseContactLastName")]
        public string CaseContactLastName { get; set; }

        [JsonProperty("caseContactFullName")]
        public string CaseContactFullName { get; set; }

        [JsonProperty("assignedToUserID")]
        public string AssignedToUserID { get; set; }

        [JsonProperty("assignedToUserKey")]
        public string AssignedToUserKey { get; set; }

        [JsonProperty("assignedToUserDisplayValue")]
        public string AssignedToUserDisplayValue { get; set; }

        [JsonProperty("priorityKey")]
        public string PriorityKey { get; set; }

        [JsonProperty("priorityDisplayValue")]
        public string PriorityDisplayValue { get; set; }

        [JsonProperty("severityKey")]
        public string SeverityKey { get; set; }

        [JsonProperty("severityDisplayValue")]
        public string SeverityDisplayValue { get; set; }

        [JsonProperty("resolvedDate")]
        public string ResolvedDate { get; set; }

        [JsonProperty("resolvedByUserID")]
        public string ResolvedByUserID { get; set; }

        [JsonProperty("resolvedByUserKey")]
        public string ResolvedByUserKey { get; set; }

        [JsonProperty("resolvedByUserDisplayValue")]
        public string ResolvedByUserDisplayValue { get; set; }

        [JsonProperty("ownerUserID")]
        public string OwnerUserID { get; set; }

        [JsonProperty("ownerUserKey")]
        public string OwnerUserKey { get; set; }

        [JsonProperty("ownerUserDisplayValue")]
        public string OwnerUserDisplayValue { get; set; }

        [JsonProperty("followUpDate")]
        public string FollowUpDate { get; set; }

        [JsonProperty("lastModifyDate")]
        public string LastModifyDate { get; set; }

        [JsonProperty("creationDate")]
        public string CreationDate { get; set; }

        [JsonProperty("creatorUserID")]
        public string CreatorUserID { get; set; }

        [JsonProperty("creatorUserKey")]
        public string CreatorUserKey { get; set; }

        [JsonProperty("creatorUserDisplayValue")]
        public string CreatorUserDisplayValue { get; set; }

        [JsonProperty("displayValue")]
        public string DisplayValue { get; set; }

        [JsonProperty("typeKey")]
        public string TypeKey { get; set; }

        [JsonProperty("typeDisplayValue")]
        public string TypeDisplayValue { get; set; }

        [JsonProperty("reasonKey")]
        public string ReasonKey { get; set; }

        [JsonProperty("reasonDisplayValue")]
        public string ReasonDisplayValue { get; set; }

        [JsonProperty("originKey")]
        public string OriginKey { get; set; }

        [JsonProperty("originDisplayValue")]
        public string OriginDisplayValue { get; set; }

        [JsonProperty("category")]
        public CaseCategoryItem[] Category { get; set; }

        [JsonProperty("product")]
        public CaseProductItem[] Product { get; set; }

        [JsonProperty("queueKey")]
        public string QueueKey { get; set; }

        [JsonProperty("queueDisplayValue")]
        public string QueueDisplayValue { get; set; }

        [JsonProperty("statusKey")]
        public string StatusKey { get; set; }

        [JsonProperty("statusDisplayValue")]
        public string StatusDisplayValue { get; set; }

        [JsonProperty("userDefinedFields")]
        public JToken UserDefinedFields { get; set; }
    }

    public class CaseCategoryItem
    {
        [JsonProperty("caseCategoryItemKey")]
        public string CaseCategoryItemKey { get; set; }

        [JsonProperty("caseCategoryItemValue")]
        public string CaseCategoryItemValue { get; set; }
    }

    public class CaseProductItem
    {
        [JsonProperty("caseProductItemKey")]
        public string CaseProductItemKey { get; set; }

        [JsonProperty("caseProductItemValue")]
        public string CaseProductItemValue { get; set; }
    }

    public class CaseFindOrCreateSchema
    {
        [JsonProperty("cases")]
        public PACaseView[] Cases { get; set; }
    }

    public class HotlistTaskCreateSchema
    {
        [JsonProperty("hotlistTasks")]
        public PAHotlistTaskView[] HotlistTasks { get; set; }
    }

    public class PAHotlistTaskView
    {
        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("assignedToKeyUID")]
        public string AssignedToKeyUID { get; set; }

        [JsonProperty("assignedToKeyValue")]
        public string AssignedToKeyValue { get; set; }

        [JsonProperty("assignedToDisplayValue")]
        public string AssignedToDisplayValue { get; set; }

        [JsonProperty("dateTime")]
        public string DateTime { get; set; }

        [JsonProperty("snoozeUntil")]
        public string SnoozeUntil { get; set; }

        [JsonProperty("alarm")]
        public string Alarm { get; set; }

        [JsonProperty("priority")]
        public string Priority { get; set; }

        [JsonProperty("completed")]
        public bool Completed { get; set; }

        [JsonProperty("iconType")]
        public string IconType { get; set; }

        [JsonProperty("activity")]
        public string Activity { get; set; }

        [JsonProperty("creationDate")]
        public string CreationDate { get; set; }

        [JsonProperty("lastModifyDate")]
        public string LastModifyDate { get; set; }

        [JsonProperty("creatorKeyUID")]
        public string CreatorKeyUID { get; set; }

        [JsonProperty("creatorKeyValue")]
        public string CreatorKeyValue { get; set; }

        [JsonProperty("creatorDisplayValue")]
        public string CreatorDisplayValue { get; set; }

        [JsonProperty("modifiedByKeyUID")]
        public string ModifiedByKeyUID { get; set; }

        [JsonProperty("modifiedByKeyValue")]
        public string ModifiedByKeyValue { get; set; }

        [JsonProperty("modifiedByDisplayValue")]
        public string ModifiedByDisplayValue { get; set; }

        [JsonProperty("abEntryKey")]
        public string AbEntryKey { get; set; }

        [JsonProperty("displayValue")]
        public string DisplayValue { get; set; }

        [JsonProperty("withKey")]
        public string WithKey { get; set; }

        [JsonProperty("leadKey")]
        public string LeadKey { get; set; }

        [JsonProperty("result")]
        public string[] Result { get; set; }

        [JsonProperty("category")]
        public string[] Category { get; set; }
    }

    public enum parentTypeInput
    {
        AbEntry,
        Opportunity,
        Lead,
        Case
    }

    public class InteractionLogCreateSchema
    {
        [JsonProperty("interactionLogs")]
        public PAInteractionLogView[] InteractionLogs { get; set; }
    }

    public class PAInteractionLogView
    {
        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("startDate")]
        public string StartDate { get; set; }

        [JsonProperty("endDate")]
        public string EndDate { get; set; }

        [JsonProperty("creatorUserID")]
        public string CreatorUserID { get; set; }

        [JsonProperty("creatorUserKey")]
        public string CreatorUserKey { get; set; }

        [JsonProperty("creatorUserDisplayValue")]
        public string CreatorUserDisplayValue { get; set; }

        [JsonProperty("interactionLogAbEntryID")]
        public string InteractionLogAbEntryID { get; set; }

        [JsonProperty("interactionLogAbEntryKey")]
        public string InteractionLogAbEntryKey { get; set; }

        [JsonProperty("interactionLogAbEntryEmail")]
        public string InteractionLogAbEntryEmail { get; set; }

        [JsonProperty("interactionLogAbEntryType")]
        public string InteractionLogAbEntryType { get; set; }

        [JsonProperty("interactionLogAbEntryCompanyName")]
        public string InteractionLogAbEntryCompanyName { get; set; }

        [JsonProperty("interactionLogAbEntryMrMs")]
        public string InteractionLogAbEntryMrMs { get; set; }

        [JsonProperty("interactionLogAbEntryFirstName")]
        public string InteractionLogAbEntryFirstName { get; set; }

        [JsonProperty("interactionLogAbEntryMiddleName")]
        public string InteractionLogAbEntryMiddleName { get; set; }

        [JsonProperty("interactionLogAbEntryLastName")]
        public string InteractionLogAbEntryLastName { get; set; }

        [JsonProperty("interactionLogAbEntryFullName")]
        public string InteractionLogAbEntryFullName { get; set; }

        [JsonProperty("interactionLogLeadID")]
        public string InteractionLogLeadID { get; set; }

        [JsonProperty("interactionLogLeadKey")]
        public string InteractionLogLeadKey { get; set; }

        [JsonProperty("interactionLogLeadEmail")]
        public string InteractionLogLeadEmail { get; set; }

        [JsonProperty("interactionLogLeadCompanyName")]
        public string InteractionLogLeadCompanyName { get; set; }

        [JsonProperty("interactionLogLeadMrMs")]
        public string InteractionLogLeadMrMs { get; set; }

        [JsonProperty("interactionLogLeadFirstName")]
        public string InteractionLogLeadFirstName { get; set; }

        [JsonProperty("interactionLogLeadMiddleName")]
        public string InteractionLogLeadMiddleName { get; set; }

        [JsonProperty("interactionLogLeadLastName")]
        public string InteractionLogLeadLastName { get; set; }

        [JsonProperty("interactionLogLeadFullName")]
        public string InteractionLogLeadFullName { get; set; }

        [JsonProperty("interactionLogUserID")]
        public string InteractionLogUserID { get; set; }

        [JsonProperty("interactionLogUserKey")]
        public string InteractionLogUserKey { get; set; }

        [JsonProperty("interactionLogUserDisplayName")]
        public string InteractionLogUserDisplayName { get; set; }

        [JsonProperty("withKey")]
        public string WithKey { get; set; }

        [JsonProperty("displayValue")]
        public string DisplayValue { get; set; }

        [JsonProperty("duration")]
        public double Duration { get; set; }

        [JsonProperty("directionKey")]
        public int DirectionKey { get; set; }

        [JsonProperty("directionDisplayValue")]
        public string DirectionDisplayValue { get; set; }

        [JsonProperty("result")]
        public InteractionLogResult[] Result { get; set; }

        [JsonProperty("typeKey")]
        public string TypeKey { get; set; }

        [JsonProperty("typeDisplayValue")]
        public string TypeDisplayValue { get; set; }

        [JsonProperty("category")]
        public InteractionLogCategory[] Category { get; set; }
    }

    public class InteractionLogResult
    {
        [JsonProperty("resultKey")]
        public string ResultKey { get; set; }

        [JsonProperty("resultDisplayValue")]
        public string ResultDisplayValue { get; set; }
    }

    public class InteractionLogCategory
    {
        [JsonProperty("categoryKey")]
        public string CategoryKey { get; set; }

        [JsonProperty("categoryDisplayValue")]
        public string CategoryDisplayValue { get; set; }
    }

    public class LeadFindSchema
    {
        [JsonProperty("leads")]
        public PALeadView[] Leads { get; set; }
    }

    public class PALeadView
    {
        [JsonProperty("leadStatusValue")]
        public string LeadStatusValue { get; set; }

        [JsonProperty("leadStatusKey")]
        public string LeadStatusKey { get; set; }

        [JsonProperty("leadKey")]
        public string LeadKey { get; set; }

        [JsonProperty("leadId")]
        public string LeadId { get; set; }

        [JsonProperty("leadCompany")]
        public string LeadCompany { get; set; }

        [JsonProperty("leadMrMs")]
        public string LeadMrMs { get; set; }

        [JsonProperty("leadFirstName")]
        public string LeadFirstName { get; set; }

        [JsonProperty("leadMiddleName")]
        public string LeadMiddleName { get; set; }

        [JsonProperty("leadLastName")]
        public string LeadLastName { get; set; }

        [JsonProperty("leadName")]
        public string LeadName { get; set; }

        [JsonProperty("leadFullName")]
        public string LeadFullName { get; set; }

        [JsonProperty("leadSalutation")]
        public string LeadSalutation { get; set; }

        [JsonProperty("leadPosition")]
        public string LeadPosition { get; set; }

        [JsonProperty("leadEmailDescription")]
        public string LeadEmailDescription { get; set; }

        [JsonProperty("leadEmail")]
        public string LeadEmail { get; set; }

        [JsonProperty("leadEmailDefaultStatus")]
        public bool LeadEmailDefaultStatus { get; set; }

        [JsonProperty("leadPhone1Description")]
        public string LeadPhone1Description { get; set; }

        [JsonProperty("leadPhone1Number")]
        public string LeadPhone1Number { get; set; }

        [JsonProperty("leadPhone1Extension")]
        public string LeadPhone1Extension { get; set; }

        [JsonProperty("leadPhone1DisplayValue")]
        public string LeadPhone1DisplayValue { get; set; }

        [JsonProperty("leadPhone1DefaultStatus")]
        public bool LeadPhone1DefaultStatus { get; set; }

        [JsonProperty("leadPhone2Description")]
        public string LeadPhone2Description { get; set; }

        [JsonProperty("leadPhone2Number")]
        public string LeadPhone2Number { get; set; }

        [JsonProperty("leadPhone2Extension")]
        public string LeadPhone2Extension { get; set; }

        [JsonProperty("leadPhone2DisplayValue")]
        public string LeadPhone2DisplayValue { get; set; }

        [JsonProperty("leadPhone2DefaultStatus")]
        public bool LeadPhone2DefaultStatus { get; set; }

        [JsonProperty("leadWebsite")]
        public string LeadWebsite { get; set; }

        [JsonProperty("leadOwnerKey")]
        public string LeadOwnerKey { get; set; }

        [JsonProperty("leadOwnerUserID")]
        public string LeadOwnerUserID { get; set; }

        [JsonProperty("leadOwner")]
        public string LeadOwner { get; set; }

        [JsonProperty("leadAddressLine1")]
        public string LeadAddressLine1 { get; set; }

        [JsonProperty("leadAddressLine2")]
        public string LeadAddressLine2 { get; set; }

        [JsonProperty("leadCityTown")]
        public string LeadCityTown { get; set; }

        [JsonProperty("leadStateProvince")]
        public string LeadStateProvince { get; set; }

        [JsonProperty("leadZipPostalCode")]
        public string LeadZipPostalCode { get; set; }

        [JsonProperty("leadCountry")]
        public string LeadCountry { get; set; }

        [JsonProperty("leadCreationDate")]
        public string LeadCreationDate { get; set; }

        [JsonProperty("leadLastModifiedDate")]
        public string LeadLastModifiedDate { get; set; }

        [JsonProperty("leadPartnerKey")]
        public string LeadPartnerKey { get; set; }

        [JsonProperty("leadPartner")]
        public string LeadPartner { get; set; }

        [JsonProperty("leadProcessSetupKey")]
        public string LeadProcessSetupKey { get; set; }

        [JsonProperty("leadProcessSetup")]
        public string LeadProcessSetup { get; set; }

        [JsonProperty("leadProcessStageSetupKey")]
        public string LeadProcessStageSetupKey { get; set; }

        [JsonProperty("leadProcessStage")]
        public string LeadProcessStage { get; set; }

        [JsonProperty("leadsAbEntryId")]
        public string LeadsAbEntryId { get; set; }

        [JsonProperty("leadsAbEntryKey")]
        public string LeadsAbEntryKey { get; set; }

        [JsonProperty("leadsAbEntryType")]
        public string LeadsAbEntryType { get; set; }

        [JsonProperty("leadsAbEntryCompany")]
        public string LeadsAbEntryCompany { get; set; }

        [JsonProperty("leadsAbEntryMrMs")]
        public string LeadsAbEntryMrMs { get; set; }

        [JsonProperty("leadsAbEntryFirstName")]
        public string LeadsAbEntryFirstName { get; set; }

        [JsonProperty("leadsAbEntryMiddleName")]
        public string LeadsAbEntryMiddleName { get; set; }

        [JsonProperty("leadsAbEntryLastName")]
        public string LeadsAbEntryLastName { get; set; }

        [JsonProperty("leadsAbEntryFullName")]
        public string LeadsAbEntryFullName { get; set; }

        [JsonProperty("leadsAbEntrEmail")]
        public string LeadsAbEntrEmail { get; set; }

        [JsonProperty("leadsAbEntryPhone1Description")]
        public string LeadsAbEntryPhone1Description { get; set; }

        [JsonProperty("leadsAbEntryPhone1Number")]
        public string LeadsAbEntryPhone1Number { get; set; }

        [JsonProperty("leadsAbEntryPhone1Extension")]
        public string LeadsAbEntryPhone1Extension { get; set; }

        [JsonProperty("leadsAbEntryPhone1DisplayValue")]
        public string LeadsAbEntryPhone1DisplayValue { get; set; }

        [JsonProperty("leadsAbEntryPhone2Description")]
        public string LeadsAbEntryPhone2Description { get; set; }

        [JsonProperty("leadsAbEntryPhone2Number")]
        public string LeadsAbEntryPhone2Number { get; set; }

        [JsonProperty("leadsAbEntryPhone2Extension")]
        public string LeadsAbEntryPhone2Extension { get; set; }

        [JsonProperty("leadsAbEntryPhone2DisplayValue")]
        public string LeadsAbEntryPhone2DisplayValue { get; set; }

        [JsonProperty("opportunityCompletionReason")]
        public string OpportunityCompletionReason { get; set; }

        [JsonProperty("opportunityKey")]
        public string OpportunityKey { get; set; }

        [JsonProperty("opportunityId")]
        public string OpportunityId { get; set; }

        [JsonProperty("opportunitysAbEntryKey")]
        public string OpportunitysAbEntryKey { get; set; }

        [JsonProperty("opportunitysAbEntryEmail")]
        public string OpportunitysAbEntryEmail { get; set; }

        [JsonProperty("opportunitysAbEntryType")]
        public string OpportunitysAbEntryType { get; set; }

        [JsonProperty("opportunitysAbEntryCompany")]
        public string OpportunitysAbEntryCompany { get; set; }

        [JsonProperty("opportunitysContactKey")]
        public string OpportunitysContactKey { get; set; }

        [JsonProperty("opportunitysContactEmail")]
        public string OpportunitysContactEmail { get; set; }

        [JsonProperty("opportunitysContactType")]
        public string OpportunitysContactType { get; set; }

        [JsonProperty("opportunitysContactCompanyName")]
        public string OpportunitysContactCompanyName { get; set; }

        [JsonProperty("opportunitysContactMrMs")]
        public string OpportunitysContactMrMs { get; set; }

        [JsonProperty("opportunitysContactFirstName")]
        public string OpportunitysContactFirstName { get; set; }

        [JsonProperty("opportunitysContactMiddleName")]
        public string OpportunitysContactMiddleName { get; set; }

        [JsonProperty("opportunitysContactLastName")]
        public string OpportunitysContactLastName { get; set; }

        [JsonProperty("opportunitysContactFullName")]
        public string OpportunitysContactFullName { get; set; }

        [JsonProperty("opportunityObjective")]
        public string OpportunityObjective { get; set; }

        [JsonProperty("opportunityDescription")]
        public string OpportunityDescription { get; set; }

        [JsonProperty("opportunityStatusKey")]
        public string OpportunityStatusKey { get; set; }

        [JsonProperty("opportunityStatus")]
        public string OpportunityStatus { get; set; }

        [JsonProperty("opportunityStartDate")]
        public string OpportunityStartDate { get; set; }

        [JsonProperty("opportunityCloseDate")]
        public string OpportunityCloseDate { get; set; }

        [JsonProperty("opportunityCreationDate")]
        public string OpportunityCreationDate { get; set; }

        [JsonProperty("opportunityLastModifiedDate")]
        public string OpportunityLastModifiedDate { get; set; }

        [JsonProperty("opportunityOwnerKey")]
        public string OpportunityOwnerKey { get; set; }

        [JsonProperty("opportunityOwnerUserId")]
        public string OpportunityOwnerUserId { get; set; }

        [JsonProperty("opportunityOwner")]
        public string OpportunityOwner { get; set; }

        [JsonProperty("opportunitySalesTeamID")]
        public int OpportunitySalesTeamID { get; set; }

        [JsonProperty("opportunitySalesTeamKey")]
        public string OpportunitySalesTeamKey { get; set; }

        [JsonProperty("opportunitySalesTeam")]
        public string OpportunitySalesTeam { get; set; }

        [JsonProperty("opportunityNextAction")]
        public string OpportunityNextAction { get; set; }

        [JsonProperty("opportunitySalesProcess")]
        public string OpportunitySalesProcess { get; set; }

        [JsonProperty("opportunitySalesProcessKey")]
        public string OpportunitySalesProcessKey { get; set; }

        [JsonProperty("opportunitySalesStage")]
        public string OpportunitySalesStage { get; set; }

        [JsonProperty("opportunitySalesStageKey")]
        public string OpportunitySalesStageKey { get; set; }

        [JsonProperty("opportunityPartnerKeys")]
        public string[] OpportunityPartnerKeys { get; set; }

        [JsonProperty("opportunityPartners")]
        public string[] OpportunityPartners { get; set; }

        [JsonProperty("opportunityCompetitors")]
        public string[] OpportunityCompetitors { get; set; }

        [JsonProperty("opportunityName")]
        public string OpportunityName { get; set; }

        [JsonProperty("opportunityCampaignKey")]
        public string OpportunityCampaignKey { get; set; }

        [JsonProperty("opportunityCampaign")]
        public string OpportunityCampaign { get; set; }

        [JsonProperty("opportunityCategories")]
        public string[] OpportunityCategories { get; set; }

        [JsonProperty("opportunityProducts")]
        public string[] OpportunityProducts { get; set; }

        [JsonProperty("opportunityConfidenceRating")]
        public string[] OpportunityConfidenceRating { get; set; }

        [JsonProperty("opportunityCost")]
        public double OpportunityCost { get; set; }

        [JsonProperty("opportunityActualRevenue")]
        public double OpportunityActualRevenue { get; set; }

        [JsonProperty("opportunityForecastRevenue")]
        public double OpportunityForecastRevenue { get; set; }

        [JsonProperty("userDefinedFields")]
        public JToken UserDefinedFields { get; set; }
    }

    public class LeadCreateSchema
    {
        [JsonProperty("leads")]
        public PALeadView[] Leads { get; set; }
    }

    public class LeadUpdateSchema
    {
        [JsonProperty("leads")]
        public PALeadView[] Leads { get; set; }
    }

    public class LeadFindOrCreateSchema
    {
        [JsonProperty("leads")]
        public PALeadView[] Leads { get; set; }
    }

    public class LeadConvertSchema
    {
        [JsonProperty("entries")]
        public PALeadConvertView[] Entries { get; set; }
    }

    public class PALeadConvertView
    {
        [JsonProperty("opportunity")]
        public PAOpportunityView Opportunity { get; set; }

        [JsonProperty("individual")]
        public PAIndividualView Individual { get; set; }

        [JsonProperty("contact")]
        public PAContactView Contact { get; set; }

        [JsonProperty("company")]
        public PACompanyView Company { get; set; }
    }

    public class PAOpportunityView
    {
        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("objective")]
        public string Objective { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("statusValue")]
        public string StatusValue { get; set; }

        [JsonProperty("statusKey")]
        public string StatusKey { get; set; }

        [JsonProperty("cost")]
        public double Cost { get; set; }

        [JsonProperty("costCurrenyCode")]
        public string CostCurrenyCode { get; set; }

        [JsonProperty("actualRevenue")]
        public double ActualRevenue { get; set; }

        [JsonProperty("actualRevenueCurrenyCode")]
        public string ActualRevenueCurrenyCode { get; set; }

        [JsonProperty("forecastRevenue")]
        public double ForecastRevenue { get; set; }

        [JsonProperty("forecastRevenueCurrenyCode")]
        public string ForecastRevenueCurrenyCode { get; set; }

        [JsonProperty("startDate")]
        public string StartDate { get; set; }

        [JsonProperty("closeDate")]
        public string CloseDate { get; set; }

        [JsonProperty("creationDate")]
        public string CreationDate { get; set; }

        [JsonProperty("lastModifyDate")]
        public string LastModifyDate { get; set; }

        [JsonProperty("leaderKey")]
        public string LeaderKey { get; set; }

        [JsonProperty("leaderDisplayValue")]
        public string LeaderDisplayValue { get; set; }

        [JsonProperty("salesTeamKey")]
        public string SalesTeamKey { get; set; }

        [JsonProperty("salesTeamID")]
        public int SalesTeamID { get; set; }

        [JsonProperty("salesTeamDisplayName")]
        public string SalesTeamDisplayName { get; set; }

        [JsonProperty("salesTeamDisplayValue")]
        public string SalesTeamDisplayValue { get; set; }

        [JsonProperty("nextAction")]
        public string NextAction { get; set; }

        [JsonProperty("salesProcessSetupKey")]
        public string SalesProcessSetupKey { get; set; }

        [JsonProperty("salesProcessSetup")]
        public string SalesProcessSetup { get; set; }

        [JsonProperty("salesStageSetupKey")]
        public string SalesStageSetupKey { get; set; }

        [JsonProperty("salesStageSetup")]
        public string SalesStageSetup { get; set; }

        [JsonProperty("salesProcessKey")]
        public string SalesProcessKey { get; set; }

        [JsonProperty("salesProcess")]
        public string SalesProcess { get; set; }

        [JsonProperty("currentSalesStageKey")]
        public string CurrentSalesStageKey { get; set; }

        [JsonProperty("currentSalesStage")]
        public string CurrentSalesStage { get; set; }

        [JsonProperty("partnerKeys")]
        public string[] PartnerKeys { get; set; }

        [JsonProperty("partnerIDs")]
        public string[] PartnerIDs { get; set; }

        [JsonProperty("partnerInfo")]
        public OpportunityPartner[] PartnerInfo { get; set; }

        [JsonProperty("competitorInfo")]
        public OpportunityCompetitor[] CompetitorInfo { get; set; }

        [JsonProperty("comment")]
        public string Comment { get; set; }

        [JsonProperty("reason")]
        public string Reason { get; set; }

        [JsonProperty("reasonKey")]
        public string ReasonKey { get; set; }

        [JsonProperty("displayValue")]
        public string DisplayValue { get; set; }

        [JsonProperty("campaignKey")]
        public string CampaignKey { get; set; }

        [JsonProperty("campaign")]
        public string Campaign { get; set; }

        [JsonProperty("category")]
        public OpportunityCategoryItem[] Category { get; set; }

        [JsonProperty("product")]
        public OpportunityProductItem[] Product { get; set; }

        [JsonProperty("rating")]
        public OpportunityRatingItem[] Rating { get; set; }

        [JsonProperty("revenueType")]
        public string RevenueType { get; set; }

        [JsonProperty("opportunityAbEntryId")]
        public string OpportunityAbEntryId { get; set; }

        [JsonProperty("opportunityAbEntryKey")]
        public string OpportunityAbEntryKey { get; set; }

        [JsonProperty("opportunityAbEntryType")]
        public string OpportunityAbEntryType { get; set; }

        [JsonProperty("opportunityAbEntryCompany")]
        public string OpportunityAbEntryCompany { get; set; }

        [JsonProperty("opportunityAbEntryMrMs")]
        public string OpportunityAbEntryMrMs { get; set; }

        [JsonProperty("opportunityAbEntryFirstName")]
        public string OpportunityAbEntryFirstName { get; set; }

        [JsonProperty("opportunityAbEntryMiddleName")]
        public string OpportunityAbEntryMiddleName { get; set; }

        [JsonProperty("opportunityAbEntryLastName")]
        public string OpportunityAbEntryLastName { get; set; }

        [JsonProperty("opportunityAbEntryFullName")]
        public string OpportunityAbEntryFullName { get; set; }

        [JsonProperty("opportunityAbEntrEmail")]
        public string OpportunityAbEntrEmail { get; set; }

        [JsonProperty("opportunityAbEntryPhone1Description")]
        public string OpportunityAbEntryPhone1Description { get; set; }

        [JsonProperty("opportunityAbEntryPhone1Number")]
        public string OpportunityAbEntryPhone1Number { get; set; }

        [JsonProperty("opportunityAbEntryPhone1Extension")]
        public string OpportunityAbEntryPhone1Extension { get; set; }

        [JsonProperty("opportunityAbEntryPhone1DisplayValue")]
        public string OpportunityAbEntryPhone1DisplayValue { get; set; }

        [JsonProperty("opportunityAbEntryPhone2Description")]
        public string OpportunityAbEntryPhone2Description { get; set; }

        [JsonProperty("opportunityAbEntryPhone2Number")]
        public string OpportunityAbEntryPhone2Number { get; set; }

        [JsonProperty("opportunityAbEntryPhone2Extension")]
        public string OpportunityAbEntryPhone2Extension { get; set; }

        [JsonProperty("opportunityAbEntryPhone2DisplayValue")]
        public string OpportunityAbEntryPhone2DisplayValue { get; set; }

        [JsonProperty("opportunityContactId")]
        public string OpportunityContactId { get; set; }

        [JsonProperty("opportunityContactKey")]
        public string OpportunityContactKey { get; set; }

        [JsonProperty("opportunityContactType")]
        public string OpportunityContactType { get; set; }

        [JsonProperty("opportunityContactCompany")]
        public string OpportunityContactCompany { get; set; }

        [JsonProperty("opportunityContactMrMs")]
        public string OpportunityContactMrMs { get; set; }

        [JsonProperty("opportunityContactFirstName")]
        public string OpportunityContactFirstName { get; set; }

        [JsonProperty("opportunityContactMiddleName")]
        public string OpportunityContactMiddleName { get; set; }

        [JsonProperty("opportunityContactLastName")]
        public string OpportunityContactLastName { get; set; }

        [JsonProperty("opportunityContactFullName")]
        public string OpportunityContactFullName { get; set; }

        [JsonProperty("opportunityContactEmail")]
        public string OpportunityContactEmail { get; set; }

        [JsonProperty("opportunityContactPhone1Description")]
        public string OpportunityContactPhone1Description { get; set; }

        [JsonProperty("opportunityContactPhone1Number")]
        public string OpportunityContactPhone1Number { get; set; }

        [JsonProperty("opportunityContactPhone1Extension")]
        public string OpportunityContactPhone1Extension { get; set; }

        [JsonProperty("opportunityContactPhone1DisplayValue")]
        public string OpportunityContactPhone1DisplayValue { get; set; }

        [JsonProperty("opportunityContactPhone2Description")]
        public string OpportunityContactPhone2Description { get; set; }

        [JsonProperty("opportunityContactPhone2Number")]
        public string OpportunityContactPhone2Number { get; set; }

        [JsonProperty("opportunityContactPhone2Extension")]
        public string OpportunityContactPhone2Extension { get; set; }

        [JsonProperty("opportunityContactPhone2DisplayValue")]
        public string OpportunityContactPhone2DisplayValue { get; set; }

        [JsonProperty("userDefinedFields")]
        public JToken UserDefinedFields { get; set; }
    }

    public class OpportunityPartner
    {
        [JsonProperty("partnerKey")]
        public string PartnerKey { get; set; }

        [JsonProperty("partnerEmail")]
        public string PartnerEmail { get; set; }

        [JsonProperty("partnerType")]
        public string PartnerType { get; set; }

        [JsonProperty("partnerCompanyName")]
        public string PartnerCompanyName { get; set; }

        [JsonProperty("partnerMrMs")]
        public string PartnerMrMs { get; set; }

        [JsonProperty("partnerFirstName")]
        public string PartnerFirstName { get; set; }

        [JsonProperty("partnerMiddleName")]
        public string PartnerMiddleName { get; set; }

        [JsonProperty("partnerLastName")]
        public string PartnerLastName { get; set; }

        [JsonProperty("partnerFullName")]
        public string PartnerFullName { get; set; }
    }

    public class OpportunityCompetitor
    {
        [JsonProperty("competitorKey")]
        public string CompetitorKey { get; set; }

        [JsonProperty("competitorEmail")]
        public string CompetitorEmail { get; set; }

        [JsonProperty("competitorType")]
        public string CompetitorType { get; set; }

        [JsonProperty("competitorCompanyName")]
        public string CompetitorCompanyName { get; set; }

        [JsonProperty("competitorMrMs")]
        public string CompetitorMrMs { get; set; }

        [JsonProperty("competitorFirstName")]
        public string CompetitorFirstName { get; set; }

        [JsonProperty("competitorMiddleName")]
        public string CompetitorMiddleName { get; set; }

        [JsonProperty("competitorLastName")]
        public string CompetitorLastName { get; set; }

        [JsonProperty("competitorFullName")]
        public string CompetitorFullName { get; set; }
    }

    public class OpportunityCategoryItem
    {
        [JsonProperty("categoryItemKey")]
        public string CategoryItemKey { get; set; }

        [JsonProperty("categoryItemDisplayValue")]
        public string CategoryItemDisplayValue { get; set; }
    }

    public class OpportunityProductItem
    {
        [JsonProperty("productItemKey")]
        public string ProductItemKey { get; set; }

        [JsonProperty("productItemDisplayValue")]
        public string ProductItemDisplayValue { get; set; }
    }

    public class OpportunityRatingItem
    {
        [JsonProperty("ratingItemKey")]
        public string RatingItemKey { get; set; }

        [JsonProperty("ratingItemDisplayValue")]
        public string RatingItemDisplayValue { get; set; }
    }

    public class PAIndividualView
    {
        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("company")]
        public string Company { get; set; }

        [JsonProperty("mrMs")]
        public string MrMs { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("middleName")]
        public string MiddleName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("fullName")]
        public string FullName { get; set; }

        [JsonProperty("position")]
        public string Position { get; set; }

        [JsonProperty("salutation")]
        public string Salutation { get; set; }

        [JsonProperty("department")]
        public string Department { get; set; }

        [JsonProperty("division")]
        public string Division { get; set; }

        [JsonProperty("phone1Description")]
        public string Phone1Description { get; set; }

        [JsonProperty("phone1Number")]
        public string Phone1Number { get; set; }

        [JsonProperty("phone1Extension")]
        public string Phone1Extension { get; set; }

        [JsonProperty("phone2Description")]
        public string Phone2Description { get; set; }

        [JsonProperty("phone2Number")]
        public string Phone2Number { get; set; }

        [JsonProperty("phone2Extension")]
        public string Phone2Extension { get; set; }

        [JsonProperty("phone3Description")]
        public string Phone3Description { get; set; }

        [JsonProperty("phone3Number")]
        public string Phone3Number { get; set; }

        [JsonProperty("phone3Extension")]
        public string Phone3Extension { get; set; }

        [JsonProperty("phone4Description")]
        public string Phone4Description { get; set; }

        [JsonProperty("phone4Number")]
        public string Phone4Number { get; set; }

        [JsonProperty("phone4Extension")]
        public string Phone4Extension { get; set; }

        [JsonProperty("addressLine1")]
        public string AddressLine1 { get; set; }

        [JsonProperty("addressLine2")]
        public string AddressLine2 { get; set; }

        [JsonProperty("cityTown")]
        public string CityTown { get; set; }

        [JsonProperty("stateProvince")]
        public string StateProvince { get; set; }

        [JsonProperty("zipCode")]
        public string ZipCode { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("territoryKey")]
        public string TerritoryKey { get; set; }

        [JsonProperty("territory")]
        public string Territory { get; set; }

        [JsonProperty("territoryStatusKey")]
        public int TerritoryStatusKey { get; set; }

        [JsonProperty("territoryStatusValue")]
        public string TerritoryStatusValue { get; set; }

        [JsonProperty("partnersKey")]
        public string PartnersKey { get; set; }

        [JsonProperty("partnersEmail")]
        public string PartnersEmail { get; set; }

        [JsonProperty("partnersType")]
        public string PartnersType { get; set; }

        [JsonProperty("partnersCompany")]
        public string PartnersCompany { get; set; }

        [JsonProperty("partnersMrMs")]
        public string PartnersMrMs { get; set; }

        [JsonProperty("partnersFirstName")]
        public string PartnersFirstName { get; set; }

        [JsonProperty("partnersMiddleName")]
        public string PartnersMiddleName { get; set; }

        [JsonProperty("partnersLastName")]
        public string PartnersLastName { get; set; }

        [JsonProperty("partnersFullName")]
        public string PartnersFullName { get; set; }

        [JsonProperty("creationDate")]
        public string CreationDate { get; set; }

        [JsonProperty("lastModifiedDate")]
        public string LastModifiedDate { get; set; }

        [JsonProperty("email1Description")]
        public string Email1Description { get; set; }

        [JsonProperty("email1")]
        public string Email1 { get; set; }

        [JsonProperty("website")]
        public string Website { get; set; }

        [JsonProperty("email2Description")]
        public string Email2Description { get; set; }

        [JsonProperty("email2")]
        public string Email2 { get; set; }

        [JsonProperty("email3Description")]
        public string Email3Description { get; set; }

        [JsonProperty("email3")]
        public string Email3 { get; set; }

        [JsonProperty("lastContactedDate")]
        public string LastContactedDate { get; set; }

        [JsonProperty("phone1DefaultStatus")]
        public bool Phone1DefaultStatus { get; set; }

        [JsonProperty("phone2DefaultStatus")]
        public bool Phone2DefaultStatus { get; set; }

        [JsonProperty("phone3DefaultStatus")]
        public bool Phone3DefaultStatus { get; set; }

        [JsonProperty("phone4DefaultStatus")]
        public bool Phone4DefaultStatus { get; set; }

        [JsonProperty("email1DefaultStatus")]
        public bool Email1DefaultStatus { get; set; }

        [JsonProperty("email2DefaultStatus")]
        public bool Email2DefaultStatus { get; set; }

        [JsonProperty("email3DefaultStatus")]
        public bool Email3DefaultStatus { get; set; }

        [JsonProperty("userDefinedFields")]
        public JToken UserDefinedFields { get; set; }
    }

    public class PAContactView
    {
        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("company")]
        public string Company { get; set; }

        [JsonProperty("mrMs")]
        public string MrMs { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("middleName")]
        public string MiddleName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("fullName")]
        public string FullName { get; set; }

        [JsonProperty("position")]
        public string Position { get; set; }

        [JsonProperty("salutation")]
        public string Salutation { get; set; }

        [JsonProperty("department")]
        public string Department { get; set; }

        [JsonProperty("division")]
        public string Division { get; set; }

        [JsonProperty("phone1Description")]
        public string Phone1Description { get; set; }

        [JsonProperty("phone1Number")]
        public string Phone1Number { get; set; }

        [JsonProperty("phone1Extension")]
        public string Phone1Extension { get; set; }

        [JsonProperty("phone2Description")]
        public string Phone2Description { get; set; }

        [JsonProperty("phone2Number")]
        public string Phone2Number { get; set; }

        [JsonProperty("phone2Extension")]
        public string Phone2Extension { get; set; }

        [JsonProperty("phone3Description")]
        public string Phone3Description { get; set; }

        [JsonProperty("phone3Number")]
        public string Phone3Number { get; set; }

        [JsonProperty("phone3Extension")]
        public string Phone3Extension { get; set; }

        [JsonProperty("phone4Description")]
        public string Phone4Description { get; set; }

        [JsonProperty("phone4Number")]
        public string Phone4Number { get; set; }

        [JsonProperty("phone4Extension")]
        public string Phone4Extension { get; set; }

        [JsonProperty("addressLine1")]
        public string AddressLine1 { get; set; }

        [JsonProperty("addressLine2")]
        public string AddressLine2 { get; set; }

        [JsonProperty("cityTown")]
        public string CityTown { get; set; }

        [JsonProperty("stateProvince")]
        public string StateProvince { get; set; }

        [JsonProperty("zipCode")]
        public string ZipCode { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("territoryKey")]
        public string TerritoryKey { get; set; }

        [JsonProperty("territory")]
        public string Territory { get; set; }

        [JsonProperty("territoryStatusKey")]
        public int TerritoryStatusKey { get; set; }

        [JsonProperty("territoryStatusValue")]
        public string TerritoryStatusValue { get; set; }

        [JsonProperty("partnersKey")]
        public string PartnersKey { get; set; }

        [JsonProperty("partnersEmail")]
        public string PartnersEmail { get; set; }

        [JsonProperty("partnersType")]
        public string PartnersType { get; set; }

        [JsonProperty("partnersCompany")]
        public string PartnersCompany { get; set; }

        [JsonProperty("partnersMrMs")]
        public string PartnersMrMs { get; set; }

        [JsonProperty("partnersFirstName")]
        public string PartnersFirstName { get; set; }

        [JsonProperty("partnersMiddleName")]
        public string PartnersMiddleName { get; set; }

        [JsonProperty("partnersLastName")]
        public string PartnersLastName { get; set; }

        [JsonProperty("partnersFullName")]
        public string PartnersFullName { get; set; }

        [JsonProperty("creationDate")]
        public string CreationDate { get; set; }

        [JsonProperty("lastModifiedDate")]
        public string LastModifiedDate { get; set; }

        [JsonProperty("email1Description")]
        public string Email1Description { get; set; }

        [JsonProperty("email1")]
        public string Email1 { get; set; }

        [JsonProperty("website")]
        public string Website { get; set; }

        [JsonProperty("email2Description")]
        public string Email2Description { get; set; }

        [JsonProperty("email2")]
        public string Email2 { get; set; }

        [JsonProperty("email3Description")]
        public string Email3Description { get; set; }

        [JsonProperty("email3")]
        public string Email3 { get; set; }

        [JsonProperty("lastContactedDate")]
        public string LastContactedDate { get; set; }

        [JsonProperty("phone1DefaultStatus")]
        public bool Phone1DefaultStatus { get; set; }

        [JsonProperty("phone2DefaultStatus")]
        public bool Phone2DefaultStatus { get; set; }

        [JsonProperty("phone3DefaultStatus")]
        public bool Phone3DefaultStatus { get; set; }

        [JsonProperty("phone4DefaultStatus")]
        public bool Phone4DefaultStatus { get; set; }

        [JsonProperty("email1DefaultStatus")]
        public bool Email1DefaultStatus { get; set; }

        [JsonProperty("email2DefaultStatus")]
        public bool Email2DefaultStatus { get; set; }

        [JsonProperty("email3DefaultStatus")]
        public bool Email3DefaultStatus { get; set; }

        [JsonProperty("userDefinedFields")]
        public JToken UserDefinedFields { get; set; }
    }

    public class PACompanyView
    {
        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("company")]
        public string Company { get; set; }

        [JsonProperty("mrMs")]
        public string MrMs { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("middleName")]
        public string MiddleName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("fullName")]
        public string FullName { get; set; }

        [JsonProperty("position")]
        public string Position { get; set; }

        [JsonProperty("salutation")]
        public string Salutation { get; set; }

        [JsonProperty("department")]
        public string Department { get; set; }

        [JsonProperty("division")]
        public string Division { get; set; }

        [JsonProperty("phone1Description")]
        public string Phone1Description { get; set; }

        [JsonProperty("phone1Number")]
        public string Phone1Number { get; set; }

        [JsonProperty("phone1Extension")]
        public string Phone1Extension { get; set; }

        [JsonProperty("phone2Description")]
        public string Phone2Description { get; set; }

        [JsonProperty("phone2Number")]
        public string Phone2Number { get; set; }

        [JsonProperty("phone2Extension")]
        public string Phone2Extension { get; set; }

        [JsonProperty("phone3Description")]
        public string Phone3Description { get; set; }

        [JsonProperty("phone3Number")]
        public string Phone3Number { get; set; }

        [JsonProperty("phone3Extension")]
        public string Phone3Extension { get; set; }

        [JsonProperty("phone4Description")]
        public string Phone4Description { get; set; }

        [JsonProperty("phone4Number")]
        public string Phone4Number { get; set; }

        [JsonProperty("phone4Extension")]
        public string Phone4Extension { get; set; }

        [JsonProperty("addressLine1")]
        public string AddressLine1 { get; set; }

        [JsonProperty("addressLine2")]
        public string AddressLine2 { get; set; }

        [JsonProperty("cityTown")]
        public string CityTown { get; set; }

        [JsonProperty("stateProvince")]
        public string StateProvince { get; set; }

        [JsonProperty("zipCode")]
        public string ZipCode { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("territoryKey")]
        public string TerritoryKey { get; set; }

        [JsonProperty("territory")]
        public string Territory { get; set; }

        [JsonProperty("territoryStatusKey")]
        public int TerritoryStatusKey { get; set; }

        [JsonProperty("territoryStatusValue")]
        public string TerritoryStatusValue { get; set; }

        [JsonProperty("partnersKey")]
        public string PartnersKey { get; set; }

        [JsonProperty("partnersEmail")]
        public string PartnersEmail { get; set; }

        [JsonProperty("partnersType")]
        public string PartnersType { get; set; }

        [JsonProperty("partnersCompany")]
        public string PartnersCompany { get; set; }

        [JsonProperty("partnersMrMs")]
        public string PartnersMrMs { get; set; }

        [JsonProperty("partnersFirstName")]
        public string PartnersFirstName { get; set; }

        [JsonProperty("partnersMiddleName")]
        public string PartnersMiddleName { get; set; }

        [JsonProperty("partnersLastName")]
        public string PartnersLastName { get; set; }

        [JsonProperty("partnersFullName")]
        public string PartnersFullName { get; set; }

        [JsonProperty("creationDate")]
        public string CreationDate { get; set; }

        [JsonProperty("lastModifiedDate")]
        public string LastModifiedDate { get; set; }

        [JsonProperty("email1Description")]
        public string Email1Description { get; set; }

        [JsonProperty("email1")]
        public string Email1 { get; set; }

        [JsonProperty("website")]
        public string Website { get; set; }

        [JsonProperty("email2Description")]
        public string Email2Description { get; set; }

        [JsonProperty("email2")]
        public string Email2 { get; set; }

        [JsonProperty("email3Description")]
        public string Email3Description { get; set; }

        [JsonProperty("email3")]
        public string Email3 { get; set; }

        [JsonProperty("lastContactedDate")]
        public string LastContactedDate { get; set; }

        [JsonProperty("phone1DefaultStatus")]
        public bool Phone1DefaultStatus { get; set; }

        [JsonProperty("phone2DefaultStatus")]
        public bool Phone2DefaultStatus { get; set; }

        [JsonProperty("phone3DefaultStatus")]
        public bool Phone3DefaultStatus { get; set; }

        [JsonProperty("phone4DefaultStatus")]
        public bool Phone4DefaultStatus { get; set; }

        [JsonProperty("email1DefaultStatus")]
        public bool Email1DefaultStatus { get; set; }

        [JsonProperty("email2DefaultStatus")]
        public bool Email2DefaultStatus { get; set; }

        [JsonProperty("email3DefaultStatus")]
        public bool Email3DefaultStatus { get; set; }

        [JsonProperty("userDefinedFields")]
        public JToken UserDefinedFields { get; set; }
    }

    public enum convertOptionInput
    {
        [EnumMember(Value = "newCompany")]
        CreateNewCompany,
        [EnumMember(Value = "newIndividual")]
        CreateNewIndividual,
        [EnumMember(Value = "existingCompany")]
        ChooseExistingCompany,
        [EnumMember(Value = "existingIndividual")]
        ChooseExistingIndividual,
        [EnumMember(Value = "existingContact")]
        ChooseExistingContact
    }

    public enum doNotCreateAContactInput
    {
        [EnumMember(Value = "true")]
        Yes,
        [EnumMember(Value = "false")]
        No
    }

    public enum doNotCreateAnOpportunityInput
    {
        [EnumMember(Value = "true")]
        Yes,
        [EnumMember(Value = "false")]
        No
    }

    public class NoteCreateSchema
    {
        [JsonProperty("notes")]
        public PANoteView[] Notes { get; set; }
    }

    public class PANoteView
    {
        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("richText")]
        public string RichText { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("important")]
        public bool Important { get; set; }

        [JsonProperty("typeKey")]
        public string TypeKey { get; set; }

        [JsonProperty("typeDisplayValue")]
        public string TypeDisplayValue { get; set; }

        [JsonProperty("dateTime")]
        public string DateTime { get; set; }

        [JsonProperty("creatorKeyUID")]
        public string CreatorKeyUID { get; set; }

        [JsonProperty("creatorKeyValue")]
        public string CreatorKeyValue { get; set; }

        [JsonProperty("creatorDisplayValue")]
        public string CreatorDisplayValue { get; set; }

        [JsonProperty("displayValue")]
        public string DisplayValue { get; set; }

        [JsonProperty("parentKey")]
        public string ParentKey { get; set; }
    }

    public class OpportunityFindSchema
    {
        [JsonProperty("opportunities")]
        public PAOpportunityView[] Opportunities { get; set; }
    }

    public class OpportunityCreateSchema
    {
        [JsonProperty("opportunities")]
        public PAOpportunityView[] Opportunities { get; set; }
    }

    public class OpportunityFindOrCreateSchema
    {
        [JsonProperty("opportunities")]
        public PAOpportunityView[] Opportunities { get; set; }
    }

    public class OpportunityUpdateSchema
    {
        [JsonProperty("opportunities")]
        public PAOpportunityView[] Opportunities { get; set; }
    }

    public class PersonalTaskCreateSchema
    {
        [JsonProperty("personalTasks")]
        public PAPersonalTaskView[] PersonalTasks { get; set; }
    }

    public class PAPersonalTaskView
    {
        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("assignedToKeyUID")]
        public string AssignedToKeyUID { get; set; }

        [JsonProperty("assignedToKeyValue")]
        public string AssignedToKeyValue { get; set; }

        [JsonProperty("assignedToDisplayValue")]
        public string AssignedToDisplayValue { get; set; }

        [JsonProperty("dateTime")]
        public string DateTime { get; set; }

        [JsonProperty("snoozeUntil")]
        public string SnoozeUntil { get; set; }

        [JsonProperty("alarm")]
        public string Alarm { get; set; }

        [JsonProperty("priority")]
        public string Priority { get; set; }

        [JsonProperty("completed")]
        public bool Completed { get; set; }

        [JsonProperty("iconType")]
        public string IconType { get; set; }

        [JsonProperty("activity")]
        public string Activity { get; set; }

        [JsonProperty("creationDate")]
        public string CreationDate { get; set; }

        [JsonProperty("lastModifyDate")]
        public string LastModifyDate { get; set; }

        [JsonProperty("creatorKeyUID")]
        public string CreatorKeyUID { get; set; }

        [JsonProperty("creatorKeyValue")]
        public string CreatorKeyValue { get; set; }

        [JsonProperty("creatorDisplayValue")]
        public string CreatorDisplayValue { get; set; }

        [JsonProperty("modifiedByKeyUID")]
        public string ModifiedByKeyUID { get; set; }

        [JsonProperty("modifiedByKeyValue")]
        public string ModifiedByKeyValue { get; set; }

        [JsonProperty("modifiedByDisplayValue")]
        public string ModifiedByDisplayValue { get; set; }

        [JsonProperty("displayValue")]
        public string DisplayValue { get; set; }

        [JsonProperty("result")]
        public string[] Result { get; set; }

        [JsonProperty("category")]
        public string[] Category { get; set; }
    }

    public class UserFindSchema
    {
        [JsonProperty("users")]
        public PAUserView[] Users { get; set; }
    }

    public class PAUserView
    {
        [JsonProperty("uid")]
        public string Uid { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }
    }

    public class AbEntryTriggerSchema
    {
        [JsonProperty("triggerState")]
        public string TriggerState { get; set; }

        [JsonProperty("abEntries")]
        public AbEntryTriggerView[] AbEntries { get; set; }
    }

    public class AbEntryTriggerView
    {
        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("company")]
        public string Company { get; set; }

        [JsonProperty("mrMs")]
        public string MrMs { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("middleName")]
        public string MiddleName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("fullName")]
        public string FullName { get; set; }

        [JsonProperty("position")]
        public string Position { get; set; }

        [JsonProperty("salutation")]
        public string Salutation { get; set; }

        [JsonProperty("department")]
        public string Department { get; set; }

        [JsonProperty("division")]
        public string Division { get; set; }

        [JsonProperty("phone1Description")]
        public string Phone1Description { get; set; }

        [JsonProperty("phone1Number")]
        public string Phone1Number { get; set; }

        [JsonProperty("phone1Extension")]
        public string Phone1Extension { get; set; }

        [JsonProperty("phone2Description")]
        public string Phone2Description { get; set; }

        [JsonProperty("phone2Number")]
        public string Phone2Number { get; set; }

        [JsonProperty("phone2Extension")]
        public string Phone2Extension { get; set; }

        [JsonProperty("phone3Description")]
        public string Phone3Description { get; set; }

        [JsonProperty("phone3Number")]
        public string Phone3Number { get; set; }

        [JsonProperty("phone3Extension")]
        public string Phone3Extension { get; set; }

        [JsonProperty("phone4Description")]
        public string Phone4Description { get; set; }

        [JsonProperty("phone4Number")]
        public string Phone4Number { get; set; }

        [JsonProperty("phone4Extension")]
        public string Phone4Extension { get; set; }

        [JsonProperty("addressLine1")]
        public string AddressLine1 { get; set; }

        [JsonProperty("addressLine2")]
        public string AddressLine2 { get; set; }

        [JsonProperty("cityTown")]
        public string CityTown { get; set; }

        [JsonProperty("stateProvince")]
        public string StateProvince { get; set; }

        [JsonProperty("zipCode")]
        public string ZipCode { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("territoryKey")]
        public string TerritoryKey { get; set; }

        [JsonProperty("territory")]
        public string Territory { get; set; }

        [JsonProperty("territoryStatusKey")]
        public int TerritoryStatusKey { get; set; }

        [JsonProperty("territoryStatusValue")]
        public string TerritoryStatusValue { get; set; }

        [JsonProperty("partnersKey")]
        public string PartnersKey { get; set; }

        [JsonProperty("partnersEmail")]
        public string PartnersEmail { get; set; }

        [JsonProperty("partnersType")]
        public string PartnersType { get; set; }

        [JsonProperty("partnersCompany")]
        public string PartnersCompany { get; set; }

        [JsonProperty("partnersMrMs")]
        public string PartnersMrMs { get; set; }

        [JsonProperty("partnersFirstName")]
        public string PartnersFirstName { get; set; }

        [JsonProperty("partnersMiddleName")]
        public string PartnersMiddleName { get; set; }

        [JsonProperty("partnersLastName")]
        public string PartnersLastName { get; set; }

        [JsonProperty("partnersFullName")]
        public string PartnersFullName { get; set; }

        [JsonProperty("creationDate")]
        public string CreationDate { get; set; }

        [JsonProperty("lastModifiedDate")]
        public string LastModifiedDate { get; set; }

        [JsonProperty("email1Description")]
        public string Email1Description { get; set; }

        [JsonProperty("email1")]
        public string Email1 { get; set; }

        [JsonProperty("website")]
        public string Website { get; set; }

        [JsonProperty("email2Description")]
        public string Email2Description { get; set; }

        [JsonProperty("email2")]
        public string Email2 { get; set; }

        [JsonProperty("email3Description")]
        public string Email3Description { get; set; }

        [JsonProperty("email3")]
        public string Email3 { get; set; }

        [JsonProperty("lastContactedDate")]
        public string LastContactedDate { get; set; }

        [JsonProperty("phone1DefaultStatus")]
        public bool Phone1DefaultStatus { get; set; }

        [JsonProperty("phone2DefaultStatus")]
        public bool Phone2DefaultStatus { get; set; }

        [JsonProperty("phone3DefaultStatus")]
        public bool Phone3DefaultStatus { get; set; }

        [JsonProperty("phone4DefaultStatus")]
        public bool Phone4DefaultStatus { get; set; }

        [JsonProperty("email1DefaultStatus")]
        public bool Email1DefaultStatus { get; set; }

        [JsonProperty("email2DefaultStatus")]
        public bool Email2DefaultStatus { get; set; }

        [JsonProperty("email3DefaultStatus")]
        public bool Email3DefaultStatus { get; set; }

        [JsonProperty("userDefinedFields")]
        public JToken UserDefinedFields { get; set; }

        [JsonProperty("powerAutomateTriggerState")]
        public int PowerAutomateTriggerState { get; set; }
    }

    public class AppointmentTriggerSchema
    {
        [JsonProperty("triggerState")]
        public string TriggerState { get; set; }

        [JsonProperty("appointments")]
        public AppointmentTriggerView[] Appointments { get; set; }
    }

    public class AppointmentTriggerView
    {
        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("startDate")]
        public string StartDate { get; set; }

        [JsonProperty("endDate")]
        public string EndDate { get; set; }

        [JsonProperty("organizerUid")]
        public string OrganizerUid { get; set; }

        [JsonProperty("organizerValue")]
        public string OrganizerValue { get; set; }

        [JsonProperty("private")]
        public bool Private { get; set; }

        [JsonProperty("users")]
        public AppointmentUser[] Users { get; set; }

        [JsonProperty("abEntries")]
        public AppointmentAbEntry[] AbEntries { get; set; }

        [JsonProperty("locationKey")]
        public string LocationKey { get; set; }

        [JsonProperty("locationName")]
        public string LocationName { get; set; }

        [JsonProperty("resourcesItems")]
        public AppointmentResourcesItem[] ResourcesItems { get; set; }

        [JsonProperty("recurringPatternKey")]
        public string RecurringPatternKey { get; set; }

        [JsonProperty("recurringPatternStartDate")]
        public string RecurringPatternStartDate { get; set; }

        [JsonProperty("recurringPatternEndDate")]
        public string RecurringPatternEndDate { get; set; }

        [JsonProperty("recurringPatternFrequency")]
        public int RecurringPatternFrequency { get; set; }

        [JsonProperty("recurringPatternOccurence")]
        public int RecurringPatternOccurence { get; set; }

        [JsonProperty("recurringPatternDayOfWeek")]
        public int RecurringPatternDayOfWeek { get; set; }

        [JsonProperty("recurringPatternSkipWeekend")]
        public bool RecurringPatternSkipWeekend { get; set; }

        [JsonProperty("recurringPatternMoveToWeekday")]
        public bool RecurringPatternMoveToWeekday { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("actionPlan")]
        public string ActionPlan { get; set; }

        [JsonProperty("categoryItems")]
        public AppointmentCategoryItem[] CategoryItems { get; set; }

        [JsonProperty("interactionCategoryItems")]
        public AppointmentInteractionCategoryItem[] InteractionCategoryItems { get; set; }

        [JsonProperty("productItems")]
        public AppointmentProductItem[] ProductItems { get; set; }

        [JsonProperty("resultItems")]
        public AppointmentResultItem[] ResultItems { get; set; }

        [JsonProperty("leads")]
        public AppointmentLeadItem[] Leads { get; set; }

        [JsonProperty("priority")]
        public string Priority { get; set; }

        [JsonProperty("withKey")]
        public string WithKey { get; set; }

        [JsonProperty("withEntityType")]
        public string WithEntityType { get; set; }

        [JsonProperty("withOpportunityKeyValue")]
        public string WithOpportunityKeyValue { get; set; }

        [JsonProperty("withOpportunityKeyID")]
        public string WithOpportunityKeyID { get; set; }

        [JsonProperty("withOpportunityAbEntryKey")]
        public string WithOpportunityAbEntryKey { get; set; }

        [JsonProperty("withOpportunityAbEntryEmail")]
        public string WithOpportunityAbEntryEmail { get; set; }

        [JsonProperty("withOpportunityAbEntryType")]
        public string WithOpportunityAbEntryType { get; set; }

        [JsonProperty("withOpportunityAbEntryCompanyName")]
        public string WithOpportunityAbEntryCompanyName { get; set; }

        [JsonProperty("withOpportunityContactKey")]
        public string WithOpportunityContactKey { get; set; }

        [JsonProperty("withOpportunityContactEmail")]
        public string WithOpportunityContactEmail { get; set; }

        [JsonProperty("withOpportunityContactType")]
        public string WithOpportunityContactType { get; set; }

        [JsonProperty("withOpportunityContactCompanyName")]
        public string WithOpportunityContactCompanyName { get; set; }

        [JsonProperty("withOpportunityContactMrMs")]
        public string WithOpportunityContactMrMs { get; set; }

        [JsonProperty("withOpportunityContactFirstName")]
        public string WithOpportunityContactFirstName { get; set; }

        [JsonProperty("withOpportunityContactMiddleName")]
        public string WithOpportunityContactMiddleName { get; set; }

        [JsonProperty("withOpportunityContactLastName")]
        public string WithOpportunityContactLastName { get; set; }

        [JsonProperty("withOpportunityContactFullName")]
        public string WithOpportunityContactFullName { get; set; }

        [JsonProperty("withOpportunityObjective")]
        public string WithOpportunityObjective { get; set; }

        [JsonProperty("withOpportunityDescription")]
        public string WithOpportunityDescription { get; set; }

        [JsonProperty("withOpportunityStatusKey")]
        public string WithOpportunityStatusKey { get; set; }

        [JsonProperty("withOpportunityStatusDisplayValue")]
        public string WithOpportunityStatusDisplayValue { get; set; }

        [JsonProperty("withOpportunityCost")]
        public double WithOpportunityCost { get; set; }

        [JsonProperty("withOpportunityActualRevenue")]
        public double WithOpportunityActualRevenue { get; set; }

        [JsonProperty("withOpportunityForecastRevenue")]
        public double WithOpportunityForecastRevenue { get; set; }

        [JsonProperty("withOpportunityStartDate")]
        public string WithOpportunityStartDate { get; set; }

        [JsonProperty("withOpportunityCloseDate")]
        public string WithOpportunityCloseDate { get; set; }

        [JsonProperty("withOpportunityCreationDate")]
        public string WithOpportunityCreationDate { get; set; }

        [JsonProperty("withOpportunityLastModifyDate")]
        public string WithOpportunityLastModifyDate { get; set; }

        [JsonProperty("withOpportunityLeaderKeyValue")]
        public string WithOpportunityLeaderKeyValue { get; set; }

        [JsonProperty("withOpportunityLeaderKeyUID")]
        public string WithOpportunityLeaderKeyUID { get; set; }

        [JsonProperty("withOpportunityLeaderDisplayValue")]
        public string WithOpportunityLeaderDisplayValue { get; set; }

        [JsonProperty("withOpportunitySalesTeamKeyValue")]
        public string WithOpportunitySalesTeamKeyValue { get; set; }

        [JsonProperty("withOpportunitySalesTeamKeyID")]
        public int WithOpportunitySalesTeamKeyID { get; set; }

        [JsonProperty("withOpportunitySalesTeamDisplayValue")]
        public string WithOpportunitySalesTeamDisplayValue { get; set; }

        [JsonProperty("withOpportunityNextAction")]
        public string WithOpportunityNextAction { get; set; }

        [JsonProperty("withOpportunitySalesProcessSetupKey")]
        public string WithOpportunitySalesProcessSetupKey { get; set; }

        [JsonProperty("withOpportunitySalesProcessSetupDisplayValue")]
        public string WithOpportunitySalesProcessSetupDisplayValue { get; set; }

        [JsonProperty("withOpportunitySalesStageSetupKey")]
        public string WithOpportunitySalesStageSetupKey { get; set; }

        [JsonProperty("withOpportunitySalesStageSetupDisplayValue")]
        public string WithOpportunitySalesStageSetupDisplayValue { get; set; }

        [JsonProperty("withOpportunitySalesProcessKey")]
        public string WithOpportunitySalesProcessKey { get; set; }

        [JsonProperty("withOpportunitySalesProcessDisplayValue")]
        public string WithOpportunitySalesProcessDisplayValue { get; set; }

        [JsonProperty("withOpportunityCurrentSalesStageKey")]
        public string WithOpportunityCurrentSalesStageKey { get; set; }

        [JsonProperty("withOpportunityCurrentSalesStageDisplayValue")]
        public string WithOpportunityCurrentSalesStageDisplayValue { get; set; }

        [JsonProperty("withOpportunityPartnerKeys")]
        public string[] WithOpportunityPartnerKeys { get; set; }

        [JsonProperty("withOpportunityPartnerInfo")]
        public string[] WithOpportunityPartnerInfo { get; set; }

        [JsonProperty("withOpportunityCompetitorInfo")]
        public string[] WithOpportunityCompetitorInfo { get; set; }

        [JsonProperty("withOpportunityComment")]
        public string WithOpportunityComment { get; set; }

        [JsonProperty("withOpportunityReason")]
        public string WithOpportunityReason { get; set; }

        [JsonProperty("withOpportunityDisplayValue")]
        public string WithOpportunityDisplayValue { get; set; }

        [JsonProperty("withOpportunityCampaignKey")]
        public string WithOpportunityCampaignKey { get; set; }

        [JsonProperty("withOpportunityCampaign")]
        public string WithOpportunityCampaign { get; set; }

        [JsonProperty("withOpportunityCategory")]
        public AppointmentOpportunityCategoryItem[] WithOpportunityCategory { get; set; }

        [JsonProperty("withOpportunityProduct")]
        public AppointmentOpportunityProductItem[] WithOpportunityProduct { get; set; }

        [JsonProperty("withOpportunityRating")]
        public AppointmentOpportunityRatingItem[] WithOpportunityRating { get; set; }

        [JsonProperty("withCaseKeyValue")]
        public string WithCaseKeyValue { get; set; }

        [JsonProperty("withCaseKeyId")]
        public string WithCaseKeyId { get; set; }

        [JsonProperty("withCaseNumber")]
        public string WithCaseNumber { get; set; }

        [JsonProperty("withCaseSubject")]
        public string WithCaseSubject { get; set; }

        [JsonProperty("withCaseDescription")]
        public string WithCaseDescription { get; set; }

        [JsonProperty("withCaseAbEntryKey")]
        public string WithCaseAbEntryKey { get; set; }

        [JsonProperty("withCaseAbEntryEmail")]
        public string WithCaseAbEntryEmail { get; set; }

        [JsonProperty("withCaseAbEntryType")]
        public string WithCaseAbEntryType { get; set; }

        [JsonProperty("withCaseAbEntryCompanyName")]
        public string WithCaseAbEntryCompanyName { get; set; }

        [JsonProperty("withCaseContactKey")]
        public string WithCaseContactKey { get; set; }

        [JsonProperty("withCaseContactEmail")]
        public string WithCaseContactEmail { get; set; }

        [JsonProperty("withCaseContactType")]
        public string WithCaseContactType { get; set; }

        [JsonProperty("withCaseContactCompanyName")]
        public string WithCaseContactCompanyName { get; set; }

        [JsonProperty("withCaseContactMrMs")]
        public string WithCaseContactMrMs { get; set; }

        [JsonProperty("withCaseContactFirstName")]
        public string WithCaseContactFirstName { get; set; }

        [JsonProperty("withCaseContactMiddleName")]
        public string WithCaseContactMiddleName { get; set; }

        [JsonProperty("withCaseContactLastName")]
        public string WithCaseContactLastName { get; set; }

        [JsonProperty("withCaseContactFullName")]
        public string WithCaseContactFullName { get; set; }

        [JsonProperty("withCaseAssignedToKeyValue")]
        public string WithCaseAssignedToKeyValue { get; set; }

        [JsonProperty("withCaseAssignedToKeyUid")]
        public string WithCaseAssignedToKeyUid { get; set; }

        [JsonProperty("withCaseAssignedToDisplayValue")]
        public string WithCaseAssignedToDisplayValue { get; set; }

        [JsonProperty("withCasePriorityKey")]
        public string WithCasePriorityKey { get; set; }

        [JsonProperty("withCasePriorityDisplayValue")]
        public string WithCasePriorityDisplayValue { get; set; }

        [JsonProperty("withCaseSeverityKey")]
        public string WithCaseSeverityKey { get; set; }

        [JsonProperty("withCaseSeverityDisplayValue")]
        public string WithCaseSeverityDisplayValue { get; set; }

        [JsonProperty("withCaseResolvedDate")]
        public string WithCaseResolvedDate { get; set; }

        [JsonProperty("withCaseResolvedBy")]
        public string WithCaseResolvedBy { get; set; }

        [JsonProperty("withCaseOwnerKeyValue")]
        public string WithCaseOwnerKeyValue { get; set; }

        [JsonProperty("withCaseOwnerKeyUid")]
        public string WithCaseOwnerKeyUid { get; set; }

        [JsonProperty("withCaseOwnerDisplayValue")]
        public string WithCaseOwnerDisplayValue { get; set; }

        [JsonProperty("withCaseFollowUpDate")]
        public string WithCaseFollowUpDate { get; set; }

        [JsonProperty("withCaseLastModifyDate")]
        public string WithCaseLastModifyDate { get; set; }

        [JsonProperty("withCaseCreationDate")]
        public string WithCaseCreationDate { get; set; }

        [JsonProperty("withCaseDisplayValue")]
        public string WithCaseDisplayValue { get; set; }

        [JsonProperty("withCaseTypeKey")]
        public string WithCaseTypeKey { get; set; }

        [JsonProperty("withCaseTypeDisplayValue")]
        public string WithCaseTypeDisplayValue { get; set; }

        [JsonProperty("withCaseReasonKey")]
        public string WithCaseReasonKey { get; set; }

        [JsonProperty("withCaseReasonDisplayValue")]
        public string WithCaseReasonDisplayValue { get; set; }

        [JsonProperty("withCaseOriginKey")]
        public string WithCaseOriginKey { get; set; }

        [JsonProperty("withCaseOriginDisplayValue")]
        public string WithCaseOriginDisplayValue { get; set; }

        [JsonProperty("withCaseCategory")]
        public AppointmentCaseCategoryItem[] WithCaseCategory { get; set; }

        [JsonProperty("withCaseProduct")]
        public AppointmentCaseProductItem[] WithCaseProduct { get; set; }

        [JsonProperty("withCaseQueueKey")]
        public string WithCaseQueueKey { get; set; }

        [JsonProperty("withCaseQueueDisplayValue")]
        public string WithCaseQueueDisplayValue { get; set; }

        [JsonProperty("withCaseStatusKey")]
        public string WithCaseStatusKey { get; set; }

        [JsonProperty("withCaseStatusDisplayValue")]
        public string WithCaseStatusDisplayValue { get; set; }

        [JsonProperty("powerAutomateTriggerState")]
        public int PowerAutomateTriggerState { get; set; }
    }

    public class CaseTriggerSchema
    {
        [JsonProperty("triggerState")]
        public string TriggerState { get; set; }

        [JsonProperty("cases")]
        public CaseTriggerView[] Cases { get; set; }
    }

    public class CaseTriggerView
    {
        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("caseNumber")]
        public string CaseNumber { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("caseAbEntryID")]
        public string CaseAbEntryID { get; set; }

        [JsonProperty("caseAbEntryKey")]
        public string CaseAbEntryKey { get; set; }

        [JsonProperty("caseAbEntryEmail")]
        public string CaseAbEntryEmail { get; set; }

        [JsonProperty("caseAbEntryType")]
        public string CaseAbEntryType { get; set; }

        [JsonProperty("caseAbEntryCompanyName")]
        public string CaseAbEntryCompanyName { get; set; }

        [JsonProperty("caseAbEntryMrMs")]
        public string CaseAbEntryMrMs { get; set; }

        [JsonProperty("caseAbEntryFirstName")]
        public string CaseAbEntryFirstName { get; set; }

        [JsonProperty("caseAbEntryMiddleName")]
        public string CaseAbEntryMiddleName { get; set; }

        [JsonProperty("caseAbEntryLastName")]
        public string CaseAbEntryLastName { get; set; }

        [JsonProperty("caseAbEntryFullName")]
        public string CaseAbEntryFullName { get; set; }

        [JsonProperty("caseContactID")]
        public string CaseContactID { get; set; }

        [JsonProperty("caseContactKey")]
        public string CaseContactKey { get; set; }

        [JsonProperty("caseContactEmail")]
        public string CaseContactEmail { get; set; }

        [JsonProperty("caseContactType")]
        public string CaseContactType { get; set; }

        [JsonProperty("caseContactCompanyName")]
        public string CaseContactCompanyName { get; set; }

        [JsonProperty("caseContactMrMs")]
        public string CaseContactMrMs { get; set; }

        [JsonProperty("caseContactFirstName")]
        public string CaseContactFirstName { get; set; }

        [JsonProperty("caseContactMiddleName")]
        public string CaseContactMiddleName { get; set; }

        [JsonProperty("caseContactLastName")]
        public string CaseContactLastName { get; set; }

        [JsonProperty("caseContactFullName")]
        public string CaseContactFullName { get; set; }

        [JsonProperty("assignedToUserID")]
        public string AssignedToUserID { get; set; }

        [JsonProperty("assignedToUserKey")]
        public string AssignedToUserKey { get; set; }

        [JsonProperty("assignedToUserDisplayValue")]
        public string AssignedToUserDisplayValue { get; set; }

        [JsonProperty("priorityKey")]
        public string PriorityKey { get; set; }

        [JsonProperty("priorityDisplayValue")]
        public string PriorityDisplayValue { get; set; }

        [JsonProperty("severityKey")]
        public string SeverityKey { get; set; }

        [JsonProperty("severityDisplayValue")]
        public string SeverityDisplayValue { get; set; }

        [JsonProperty("resolvedDate")]
        public string ResolvedDate { get; set; }

        [JsonProperty("resolvedByUserID")]
        public string ResolvedByUserID { get; set; }

        [JsonProperty("resolvedByUserKey")]
        public string ResolvedByUserKey { get; set; }

        [JsonProperty("resolvedByUserDisplayValue")]
        public string ResolvedByUserDisplayValue { get; set; }

        [JsonProperty("ownerUserID")]
        public string OwnerUserID { get; set; }

        [JsonProperty("ownerUserKey")]
        public string OwnerUserKey { get; set; }

        [JsonProperty("ownerUserDisplayValue")]
        public string OwnerUserDisplayValue { get; set; }

        [JsonProperty("followUpDate")]
        public string FollowUpDate { get; set; }

        [JsonProperty("lastModifyDate")]
        public string LastModifyDate { get; set; }

        [JsonProperty("creationDate")]
        public string CreationDate { get; set; }

        [JsonProperty("creatorUserID")]
        public string CreatorUserID { get; set; }

        [JsonProperty("creatorUserKey")]
        public string CreatorUserKey { get; set; }

        [JsonProperty("creatorUserDisplayValue")]
        public string CreatorUserDisplayValue { get; set; }

        [JsonProperty("displayValue")]
        public string DisplayValue { get; set; }

        [JsonProperty("typeKey")]
        public string TypeKey { get; set; }

        [JsonProperty("typeDisplayValue")]
        public string TypeDisplayValue { get; set; }

        [JsonProperty("reasonKey")]
        public string ReasonKey { get; set; }

        [JsonProperty("reasonDisplayValue")]
        public string ReasonDisplayValue { get; set; }

        [JsonProperty("originKey")]
        public string OriginKey { get; set; }

        [JsonProperty("originDisplayValue")]
        public string OriginDisplayValue { get; set; }

        [JsonProperty("category")]
        public CaseCategoryItem[] Category { get; set; }

        [JsonProperty("product")]
        public CaseProductItem[] Product { get; set; }

        [JsonProperty("queueKey")]
        public string QueueKey { get; set; }

        [JsonProperty("queueDisplayValue")]
        public string QueueDisplayValue { get; set; }

        [JsonProperty("statusKey")]
        public string StatusKey { get; set; }

        [JsonProperty("statusDisplayValue")]
        public string StatusDisplayValue { get; set; }

        [JsonProperty("userDefinedFields")]
        public JToken UserDefinedFields { get; set; }

        [JsonProperty("powerAutomateTriggerState")]
        public int PowerAutomateTriggerState { get; set; }
    }

    public class HotlistTaskTriggerSchema
    {
        [JsonProperty("triggerState")]
        public string TriggerState { get; set; }

        [JsonProperty("hotlistTasks")]
        public HotlistTaskTriggerView[] HotlistTasks { get; set; }
    }

    public class HotlistTaskTriggerView
    {
        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("assignedToKeyUID")]
        public string AssignedToKeyUID { get; set; }

        [JsonProperty("assignedToKeyValue")]
        public string AssignedToKeyValue { get; set; }

        [JsonProperty("assignedToDisplayValue")]
        public string AssignedToDisplayValue { get; set; }

        [JsonProperty("dateTime")]
        public string DateTime { get; set; }

        [JsonProperty("snoozeUntil")]
        public string SnoozeUntil { get; set; }

        [JsonProperty("alarm")]
        public string Alarm { get; set; }

        [JsonProperty("priority")]
        public string Priority { get; set; }

        [JsonProperty("completed")]
        public bool Completed { get; set; }

        [JsonProperty("iconType")]
        public string IconType { get; set; }

        [JsonProperty("activity")]
        public string Activity { get; set; }

        [JsonProperty("creationDate")]
        public string CreationDate { get; set; }

        [JsonProperty("lastModifyDate")]
        public string LastModifyDate { get; set; }

        [JsonProperty("creatorKeyUID")]
        public string CreatorKeyUID { get; set; }

        [JsonProperty("creatorKeyValue")]
        public string CreatorKeyValue { get; set; }

        [JsonProperty("creatorDisplayValue")]
        public string CreatorDisplayValue { get; set; }

        [JsonProperty("modifiedByKeyUID")]
        public string ModifiedByKeyUID { get; set; }

        [JsonProperty("modifiedByKeyValue")]
        public string ModifiedByKeyValue { get; set; }

        [JsonProperty("modifiedByDisplayValue")]
        public string ModifiedByDisplayValue { get; set; }

        [JsonProperty("abEntryKey")]
        public string AbEntryKey { get; set; }

        [JsonProperty("displayValue")]
        public string DisplayValue { get; set; }

        [JsonProperty("withKey")]
        public string WithKey { get; set; }

        [JsonProperty("leadKey")]
        public string LeadKey { get; set; }

        [JsonProperty("result")]
        public string[] Result { get; set; }

        [JsonProperty("category")]
        public string[] Category { get; set; }

        [JsonProperty("powerAutomateTriggerState")]
        public int PowerAutomateTriggerState { get; set; }
    }

    public class LeadTriggerSchema
    {
        [JsonProperty("triggerState")]
        public string TriggerState { get; set; }

        [JsonProperty("leads")]
        public LeadTriggerView[] Leads { get; set; }
    }

    public class LeadTriggerView
    {
        [JsonProperty("leadStatusValue")]
        public string LeadStatusValue { get; set; }

        [JsonProperty("leadStatusKey")]
        public string LeadStatusKey { get; set; }

        [JsonProperty("leadKey")]
        public string LeadKey { get; set; }

        [JsonProperty("leadId")]
        public string LeadId { get; set; }

        [JsonProperty("leadCompany")]
        public string LeadCompany { get; set; }

        [JsonProperty("leadMrMs")]
        public string LeadMrMs { get; set; }

        [JsonProperty("leadFirstName")]
        public string LeadFirstName { get; set; }

        [JsonProperty("leadMiddleName")]
        public string LeadMiddleName { get; set; }

        [JsonProperty("leadLastName")]
        public string LeadLastName { get; set; }

        [JsonProperty("leadName")]
        public string LeadName { get; set; }

        [JsonProperty("leadFullName")]
        public string LeadFullName { get; set; }

        [JsonProperty("leadSalutation")]
        public string LeadSalutation { get; set; }

        [JsonProperty("leadPosition")]
        public string LeadPosition { get; set; }

        [JsonProperty("leadEmailDescription")]
        public string LeadEmailDescription { get; set; }

        [JsonProperty("leadEmail")]
        public string LeadEmail { get; set; }

        [JsonProperty("leadEmailDefaultStatus")]
        public bool LeadEmailDefaultStatus { get; set; }

        [JsonProperty("leadPhone1Description")]
        public string LeadPhone1Description { get; set; }

        [JsonProperty("leadPhone1Number")]
        public string LeadPhone1Number { get; set; }

        [JsonProperty("leadPhone1Extension")]
        public string LeadPhone1Extension { get; set; }

        [JsonProperty("leadPhone1DisplayValue")]
        public string LeadPhone1DisplayValue { get; set; }

        [JsonProperty("leadPhone1DefaultStatus")]
        public bool LeadPhone1DefaultStatus { get; set; }

        [JsonProperty("leadPhone2Description")]
        public string LeadPhone2Description { get; set; }

        [JsonProperty("leadPhone2Number")]
        public string LeadPhone2Number { get; set; }

        [JsonProperty("leadPhone2Extension")]
        public string LeadPhone2Extension { get; set; }

        [JsonProperty("leadPhone2DisplayValue")]
        public string LeadPhone2DisplayValue { get; set; }

        [JsonProperty("leadPhone2DefaultStatus")]
        public bool LeadPhone2DefaultStatus { get; set; }

        [JsonProperty("leadWebsite")]
        public string LeadWebsite { get; set; }

        [JsonProperty("leadOwnerKey")]
        public string LeadOwnerKey { get; set; }

        [JsonProperty("leadOwnerUserID")]
        public string LeadOwnerUserID { get; set; }

        [JsonProperty("leadOwner")]
        public string LeadOwner { get; set; }

        [JsonProperty("leadAddressLine1")]
        public string LeadAddressLine1 { get; set; }

        [JsonProperty("leadAddressLine2")]
        public string LeadAddressLine2 { get; set; }

        [JsonProperty("leadCityTown")]
        public string LeadCityTown { get; set; }

        [JsonProperty("leadStateProvince")]
        public string LeadStateProvince { get; set; }

        [JsonProperty("leadZipPostalCode")]
        public string LeadZipPostalCode { get; set; }

        [JsonProperty("leadCountry")]
        public string LeadCountry { get; set; }

        [JsonProperty("leadCreationDate")]
        public string LeadCreationDate { get; set; }

        [JsonProperty("leadLastModifiedDate")]
        public string LeadLastModifiedDate { get; set; }

        [JsonProperty("leadPartnerKey")]
        public string LeadPartnerKey { get; set; }

        [JsonProperty("leadPartner")]
        public string LeadPartner { get; set; }

        [JsonProperty("leadProcessSetupKey")]
        public string LeadProcessSetupKey { get; set; }

        [JsonProperty("leadProcessSetup")]
        public string LeadProcessSetup { get; set; }

        [JsonProperty("leadProcessStageSetupKey")]
        public string LeadProcessStageSetupKey { get; set; }

        [JsonProperty("leadProcessStage")]
        public string LeadProcessStage { get; set; }

        [JsonProperty("leadsAbEntryId")]
        public string LeadsAbEntryId { get; set; }

        [JsonProperty("leadsAbEntryKey")]
        public string LeadsAbEntryKey { get; set; }

        [JsonProperty("leadsAbEntryType")]
        public string LeadsAbEntryType { get; set; }

        [JsonProperty("leadsAbEntryCompany")]
        public string LeadsAbEntryCompany { get; set; }

        [JsonProperty("leadsAbEntryMrMs")]
        public string LeadsAbEntryMrMs { get; set; }

        [JsonProperty("leadsAbEntryFirstName")]
        public string LeadsAbEntryFirstName { get; set; }

        [JsonProperty("leadsAbEntryMiddleName")]
        public string LeadsAbEntryMiddleName { get; set; }

        [JsonProperty("leadsAbEntryLastName")]
        public string LeadsAbEntryLastName { get; set; }

        [JsonProperty("leadsAbEntryFullName")]
        public string LeadsAbEntryFullName { get; set; }

        [JsonProperty("leadsAbEntrEmail")]
        public string LeadsAbEntrEmail { get; set; }

        [JsonProperty("leadsAbEntryPhone1Description")]
        public string LeadsAbEntryPhone1Description { get; set; }

        [JsonProperty("leadsAbEntryPhone1Number")]
        public string LeadsAbEntryPhone1Number { get; set; }

        [JsonProperty("leadsAbEntryPhone1Extension")]
        public string LeadsAbEntryPhone1Extension { get; set; }

        [JsonProperty("leadsAbEntryPhone1DisplayValue")]
        public string LeadsAbEntryPhone1DisplayValue { get; set; }

        [JsonProperty("leadsAbEntryPhone2Description")]
        public string LeadsAbEntryPhone2Description { get; set; }

        [JsonProperty("leadsAbEntryPhone2Number")]
        public string LeadsAbEntryPhone2Number { get; set; }

        [JsonProperty("leadsAbEntryPhone2Extension")]
        public string LeadsAbEntryPhone2Extension { get; set; }

        [JsonProperty("leadsAbEntryPhone2DisplayValue")]
        public string LeadsAbEntryPhone2DisplayValue { get; set; }

        [JsonProperty("opportunityCompletionReason")]
        public string OpportunityCompletionReason { get; set; }

        [JsonProperty("opportunityKey")]
        public string OpportunityKey { get; set; }

        [JsonProperty("opportunityId")]
        public string OpportunityId { get; set; }

        [JsonProperty("opportunitysAbEntryKey")]
        public string OpportunitysAbEntryKey { get; set; }

        [JsonProperty("opportunitysAbEntryEmail")]
        public string OpportunitysAbEntryEmail { get; set; }

        [JsonProperty("opportunitysAbEntryType")]
        public string OpportunitysAbEntryType { get; set; }

        [JsonProperty("opportunitysAbEntryCompany")]
        public string OpportunitysAbEntryCompany { get; set; }

        [JsonProperty("opportunitysContactKey")]
        public string OpportunitysContactKey { get; set; }

        [JsonProperty("opportunitysContactEmail")]
        public string OpportunitysContactEmail { get; set; }

        [JsonProperty("opportunitysContactType")]
        public string OpportunitysContactType { get; set; }

        [JsonProperty("opportunitysContactCompanyName")]
        public string OpportunitysContactCompanyName { get; set; }

        [JsonProperty("opportunitysContactMrMs")]
        public string OpportunitysContactMrMs { get; set; }

        [JsonProperty("opportunitysContactFirstName")]
        public string OpportunitysContactFirstName { get; set; }

        [JsonProperty("opportunitysContactMiddleName")]
        public string OpportunitysContactMiddleName { get; set; }

        [JsonProperty("opportunitysContactLastName")]
        public string OpportunitysContactLastName { get; set; }

        [JsonProperty("opportunitysContactFullName")]
        public string OpportunitysContactFullName { get; set; }

        [JsonProperty("opportunityObjective")]
        public string OpportunityObjective { get; set; }

        [JsonProperty("opportunityDescription")]
        public string OpportunityDescription { get; set; }

        [JsonProperty("opportunityStatusKey")]
        public string OpportunityStatusKey { get; set; }

        [JsonProperty("opportunityStatus")]
        public string OpportunityStatus { get; set; }

        [JsonProperty("opportunityStartDate")]
        public string OpportunityStartDate { get; set; }

        [JsonProperty("opportunityCloseDate")]
        public string OpportunityCloseDate { get; set; }

        [JsonProperty("opportunityCreationDate")]
        public string OpportunityCreationDate { get; set; }

        [JsonProperty("opportunityLastModifiedDate")]
        public string OpportunityLastModifiedDate { get; set; }

        [JsonProperty("opportunityOwnerKey")]
        public string OpportunityOwnerKey { get; set; }

        [JsonProperty("opportunityOwnerUserId")]
        public string OpportunityOwnerUserId { get; set; }

        [JsonProperty("opportunityOwner")]
        public string OpportunityOwner { get; set; }

        [JsonProperty("opportunitySalesTeamID")]
        public int OpportunitySalesTeamID { get; set; }

        [JsonProperty("opportunitySalesTeamKey")]
        public string OpportunitySalesTeamKey { get; set; }

        [JsonProperty("opportunitySalesTeam")]
        public string OpportunitySalesTeam { get; set; }

        [JsonProperty("opportunityNextAction")]
        public string OpportunityNextAction { get; set; }

        [JsonProperty("opportunitySalesProcess")]
        public string OpportunitySalesProcess { get; set; }

        [JsonProperty("opportunitySalesProcessKey")]
        public string OpportunitySalesProcessKey { get; set; }

        [JsonProperty("opportunitySalesStage")]
        public string OpportunitySalesStage { get; set; }

        [JsonProperty("opportunitySalesStageKey")]
        public string OpportunitySalesStageKey { get; set; }

        [JsonProperty("opportunityPartnerKeys")]
        public string[] OpportunityPartnerKeys { get; set; }

        [JsonProperty("opportunityPartners")]
        public string[] OpportunityPartners { get; set; }

        [JsonProperty("opportunityCompetitors")]
        public string[] OpportunityCompetitors { get; set; }

        [JsonProperty("opportunityName")]
        public string OpportunityName { get; set; }

        [JsonProperty("opportunityCampaignKey")]
        public string OpportunityCampaignKey { get; set; }

        [JsonProperty("opportunityCampaign")]
        public string OpportunityCampaign { get; set; }

        [JsonProperty("opportunityCategories")]
        public string[] OpportunityCategories { get; set; }

        [JsonProperty("opportunityProducts")]
        public string[] OpportunityProducts { get; set; }

        [JsonProperty("opportunityConfidenceRating")]
        public string[] OpportunityConfidenceRating { get; set; }

        [JsonProperty("opportunityCost")]
        public double OpportunityCost { get; set; }

        [JsonProperty("opportunityActualRevenue")]
        public double OpportunityActualRevenue { get; set; }

        [JsonProperty("opportunityForecastRevenue")]
        public double OpportunityForecastRevenue { get; set; }

        [JsonProperty("userDefinedFields")]
        public JToken UserDefinedFields { get; set; }

        [JsonProperty("powerAutomateTriggerState")]
        public int PowerAutomateTriggerState { get; set; }
    }

    public class WebhookCreated
    {
        [JsonProperty("succeeded")]
        public bool Succeeded { get; set; }

        [JsonProperty("webhookId")]
        public string WebhookId { get; set; }
    }

    public class OpportunityTriggerSchema
    {
        [JsonProperty("triggerState")]
        public string TriggerState { get; set; }

        [JsonProperty("opportunities")]
        public OpportunityTriggerView[] Opportunities { get; set; }
    }

    public class OpportunityTriggerView
    {
        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("objective")]
        public string Objective { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("statusValue")]
        public string StatusValue { get; set; }

        [JsonProperty("statusKey")]
        public string StatusKey { get; set; }

        [JsonProperty("cost")]
        public double Cost { get; set; }

        [JsonProperty("costCurrenyCode")]
        public string CostCurrenyCode { get; set; }

        [JsonProperty("actualRevenue")]
        public double ActualRevenue { get; set; }

        [JsonProperty("actualRevenueCurrenyCode")]
        public string ActualRevenueCurrenyCode { get; set; }

        [JsonProperty("forecastRevenue")]
        public double ForecastRevenue { get; set; }

        [JsonProperty("forecastRevenueCurrenyCode")]
        public string ForecastRevenueCurrenyCode { get; set; }

        [JsonProperty("startDate")]
        public string StartDate { get; set; }

        [JsonProperty("closeDate")]
        public string CloseDate { get; set; }

        [JsonProperty("creationDate")]
        public string CreationDate { get; set; }

        [JsonProperty("lastModifyDate")]
        public string LastModifyDate { get; set; }

        [JsonProperty("leaderKey")]
        public string LeaderKey { get; set; }

        [JsonProperty("leaderDisplayValue")]
        public string LeaderDisplayValue { get; set; }

        [JsonProperty("salesTeamKey")]
        public string SalesTeamKey { get; set; }

        [JsonProperty("salesTeamID")]
        public int SalesTeamID { get; set; }

        [JsonProperty("salesTeamDisplayName")]
        public string SalesTeamDisplayName { get; set; }

        [JsonProperty("salesTeamDisplayValue")]
        public string SalesTeamDisplayValue { get; set; }

        [JsonProperty("nextAction")]
        public string NextAction { get; set; }

        [JsonProperty("salesProcessSetupKey")]
        public string SalesProcessSetupKey { get; set; }

        [JsonProperty("salesProcessSetup")]
        public string SalesProcessSetup { get; set; }

        [JsonProperty("salesStageSetupKey")]
        public string SalesStageSetupKey { get; set; }

        [JsonProperty("salesStageSetup")]
        public string SalesStageSetup { get; set; }

        [JsonProperty("salesProcessKey")]
        public string SalesProcessKey { get; set; }

        [JsonProperty("salesProcess")]
        public string SalesProcess { get; set; }

        [JsonProperty("currentSalesStageKey")]
        public string CurrentSalesStageKey { get; set; }

        [JsonProperty("currentSalesStage")]
        public string CurrentSalesStage { get; set; }

        [JsonProperty("partnerKeys")]
        public string[] PartnerKeys { get; set; }

        [JsonProperty("partnerIDs")]
        public string[] PartnerIDs { get; set; }

        [JsonProperty("partnerInfo")]
        public OpportunityPartner[] PartnerInfo { get; set; }

        [JsonProperty("competitorInfo")]
        public OpportunityCompetitor[] CompetitorInfo { get; set; }

        [JsonProperty("comment")]
        public string Comment { get; set; }

        [JsonProperty("reason")]
        public string Reason { get; set; }

        [JsonProperty("reasonKey")]
        public string ReasonKey { get; set; }

        [JsonProperty("displayValue")]
        public string DisplayValue { get; set; }

        [JsonProperty("campaignKey")]
        public string CampaignKey { get; set; }

        [JsonProperty("campaign")]
        public string Campaign { get; set; }

        [JsonProperty("category")]
        public OpportunityCategoryItem[] Category { get; set; }

        [JsonProperty("product")]
        public OpportunityProductItem[] Product { get; set; }

        [JsonProperty("rating")]
        public OpportunityRatingItem[] Rating { get; set; }

        [JsonProperty("revenueType")]
        public string RevenueType { get; set; }

        [JsonProperty("opportunityAbEntryId")]
        public string OpportunityAbEntryId { get; set; }

        [JsonProperty("opportunityAbEntryKey")]
        public string OpportunityAbEntryKey { get; set; }

        [JsonProperty("opportunityAbEntryType")]
        public string OpportunityAbEntryType { get; set; }

        [JsonProperty("opportunityAbEntryCompany")]
        public string OpportunityAbEntryCompany { get; set; }

        [JsonProperty("opportunityAbEntryMrMs")]
        public string OpportunityAbEntryMrMs { get; set; }

        [JsonProperty("opportunityAbEntryFirstName")]
        public string OpportunityAbEntryFirstName { get; set; }

        [JsonProperty("opportunityAbEntryMiddleName")]
        public string OpportunityAbEntryMiddleName { get; set; }

        [JsonProperty("opportunityAbEntryLastName")]
        public string OpportunityAbEntryLastName { get; set; }

        [JsonProperty("opportunityAbEntryFullName")]
        public string OpportunityAbEntryFullName { get; set; }

        [JsonProperty("opportunityAbEntrEmail")]
        public string OpportunityAbEntrEmail { get; set; }

        [JsonProperty("opportunityAbEntryPhone1Description")]
        public string OpportunityAbEntryPhone1Description { get; set; }

        [JsonProperty("opportunityAbEntryPhone1Number")]
        public string OpportunityAbEntryPhone1Number { get; set; }

        [JsonProperty("opportunityAbEntryPhone1Extension")]
        public string OpportunityAbEntryPhone1Extension { get; set; }

        [JsonProperty("opportunityAbEntryPhone1DisplayValue")]
        public string OpportunityAbEntryPhone1DisplayValue { get; set; }

        [JsonProperty("opportunityAbEntryPhone2Description")]
        public string OpportunityAbEntryPhone2Description { get; set; }

        [JsonProperty("opportunityAbEntryPhone2Number")]
        public string OpportunityAbEntryPhone2Number { get; set; }

        [JsonProperty("opportunityAbEntryPhone2Extension")]
        public string OpportunityAbEntryPhone2Extension { get; set; }

        [JsonProperty("opportunityAbEntryPhone2DisplayValue")]
        public string OpportunityAbEntryPhone2DisplayValue { get; set; }

        [JsonProperty("opportunityContactId")]
        public string OpportunityContactId { get; set; }

        [JsonProperty("opportunityContactKey")]
        public string OpportunityContactKey { get; set; }

        [JsonProperty("opportunityContactType")]
        public string OpportunityContactType { get; set; }

        [JsonProperty("opportunityContactCompany")]
        public string OpportunityContactCompany { get; set; }

        [JsonProperty("opportunityContactMrMs")]
        public string OpportunityContactMrMs { get; set; }

        [JsonProperty("opportunityContactFirstName")]
        public string OpportunityContactFirstName { get; set; }

        [JsonProperty("opportunityContactMiddleName")]
        public string OpportunityContactMiddleName { get; set; }

        [JsonProperty("opportunityContactLastName")]
        public string OpportunityContactLastName { get; set; }

        [JsonProperty("opportunityContactFullName")]
        public string OpportunityContactFullName { get; set; }

        [JsonProperty("opportunityContactEmail")]
        public string OpportunityContactEmail { get; set; }

        [JsonProperty("opportunityContactPhone1Description")]
        public string OpportunityContactPhone1Description { get; set; }

        [JsonProperty("opportunityContactPhone1Number")]
        public string OpportunityContactPhone1Number { get; set; }

        [JsonProperty("opportunityContactPhone1Extension")]
        public string OpportunityContactPhone1Extension { get; set; }

        [JsonProperty("opportunityContactPhone1DisplayValue")]
        public string OpportunityContactPhone1DisplayValue { get; set; }

        [JsonProperty("opportunityContactPhone2Description")]
        public string OpportunityContactPhone2Description { get; set; }

        [JsonProperty("opportunityContactPhone2Number")]
        public string OpportunityContactPhone2Number { get; set; }

        [JsonProperty("opportunityContactPhone2Extension")]
        public string OpportunityContactPhone2Extension { get; set; }

        [JsonProperty("opportunityContactPhone2DisplayValue")]
        public string OpportunityContactPhone2DisplayValue { get; set; }

        [JsonProperty("userDefinedFields")]
        public JToken UserDefinedFields { get; set; }

        [JsonProperty("powerAutomateTriggerState")]
        public int PowerAutomateTriggerState { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Maximizercrm;

    public partial class WorkflowManagedActions
    {
        public MaximizercrmActions Maximizercrm(string connectionId) => new MaximizercrmActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public MaximizercrmTriggers Maximizercrm(string connectionId) => new MaximizercrmTriggers(connectionId);
    }
}
