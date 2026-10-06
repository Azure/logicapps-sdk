//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Aftershipip
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AftershipipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aftershipip")]
        public IBodyWorkflowAction<GetUserActivatedCouriersResponse> GetUserActivatedCouriers()
        {
            var apiCallPath = "/couriers";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            return new ApiConnectionAction<GetUserActivatedCouriersResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aftershipip")]
        [WorkflowExpressionFactory(nameof(__BuildDetectCourier))]
        public IBodyWorkflowAction<DetectCourierResponse> DetectCourier([WorkflowExpression] Func<string> bodytrackingtrackingNumber = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aftershipip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DetectCourierResponse> __BuildDetectCourier(WorkflowExpression<string> bodytrackingtrackingNumber = null)
        {
            WorkflowExpression.Validate(bodytrackingtrackingNumber, nameof(bodytrackingtrackingNumber), required: false);
            return new DeferredBodyAction<DetectCourierResponse>(() =>
            {
                var apiCallPath = "/couriers/detect";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                var trackingObject = new JObject();
                var trackingObjectpropCount = 0;
                if (bodytrackingtrackingNumber != null)
                {
                    trackingObject["tracking_number"] = ExpressionConverter.ConvertO(bodytrackingtrackingNumber);
                    trackingObjectpropCount++;
                }

                if (trackingObjectpropCount > 0)
                {
                    body["tracking"] = trackingObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<DetectCourierResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aftershipip")]
        public IBodyWorkflowAction<GetAllCouriersResponse> GetAllCouriers()
        {
            var apiCallPath = "/couriers/all";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            return new ApiConnectionAction<GetAllCouriersResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aftershipip")]
        public IBodyWorkflowAction<GetTrackingsResponse> GetTrackings()
        {
            var apiCallPath = "/trackings";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            return new ApiConnectionAction<GetTrackingsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aftershipip")]
        [WorkflowExpressionFactory(nameof(__BuildCreateTracking))]
        public IBodyWorkflowAction<CreateTrackingResponse> CreateTracking([WorkflowExpression] Func<string> bodytrackingslug = null, [WorkflowExpression] Func<string> bodytrackingtrackingNumber = null, [WorkflowExpression] Func<string> bodytrackingtitle = null, [WorkflowExpression] Func<JToken[]> bodytrackingsmses = null, [WorkflowExpression] Func<JToken[]> bodytrackingemails = null, [WorkflowExpression] Func<string> bodytrackingorderId = null, [WorkflowExpression] Func<string> bodytrackingorderIdPath = null, [WorkflowExpression] Func<string> bodytrackingcustomFieldsproductName = null, [WorkflowExpression] Func<string> bodytrackingcustomFieldsproductPrice = null, [WorkflowExpression] Func<string> bodytrackinglanguage = null, [WorkflowExpression] Func<string> bodytrackingorderPromisedDeliveryDate = null, [WorkflowExpression] Func<string> bodytrackingdeliveryType = null, [WorkflowExpression] Func<string> bodytrackingpickupLocation = null, [WorkflowExpression] Func<string> bodytrackingpickupNote = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aftershipip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateTrackingResponse> __BuildCreateTracking(WorkflowExpression<string> bodytrackingslug = null, WorkflowExpression<string> bodytrackingtrackingNumber = null, WorkflowExpression<string> bodytrackingtitle = null, WorkflowExpression<JToken[]> bodytrackingsmses = null, WorkflowExpression<JToken[]> bodytrackingemails = null, WorkflowExpression<string> bodytrackingorderId = null, WorkflowExpression<string> bodytrackingorderIdPath = null, WorkflowExpression<string> bodytrackingcustomFieldsproductName = null, WorkflowExpression<string> bodytrackingcustomFieldsproductPrice = null, WorkflowExpression<string> bodytrackinglanguage = null, WorkflowExpression<string> bodytrackingorderPromisedDeliveryDate = null, WorkflowExpression<string> bodytrackingdeliveryType = null, WorkflowExpression<string> bodytrackingpickupLocation = null, WorkflowExpression<string> bodytrackingpickupNote = null)
        {
            WorkflowExpression.Validate(bodytrackingslug, nameof(bodytrackingslug), required: false);
            WorkflowExpression.Validate(bodytrackingtrackingNumber, nameof(bodytrackingtrackingNumber), required: false);
            WorkflowExpression.Validate(bodytrackingtitle, nameof(bodytrackingtitle), required: false);
            WorkflowExpression.Validate(bodytrackingsmses, nameof(bodytrackingsmses), required: false);
            WorkflowExpression.Validate(bodytrackingemails, nameof(bodytrackingemails), required: false);
            WorkflowExpression.Validate(bodytrackingorderId, nameof(bodytrackingorderId), required: false);
            WorkflowExpression.Validate(bodytrackingorderIdPath, nameof(bodytrackingorderIdPath), required: false);
            WorkflowExpression.Validate(bodytrackingcustomFieldsproductName, nameof(bodytrackingcustomFieldsproductName), required: false);
            WorkflowExpression.Validate(bodytrackingcustomFieldsproductPrice, nameof(bodytrackingcustomFieldsproductPrice), required: false);
            WorkflowExpression.Validate(bodytrackinglanguage, nameof(bodytrackinglanguage), required: false);
            WorkflowExpression.Validate(bodytrackingorderPromisedDeliveryDate, nameof(bodytrackingorderPromisedDeliveryDate), required: false);
            WorkflowExpression.Validate(bodytrackingdeliveryType, nameof(bodytrackingdeliveryType), required: false);
            WorkflowExpression.Validate(bodytrackingpickupLocation, nameof(bodytrackingpickupLocation), required: false);
            WorkflowExpression.Validate(bodytrackingpickupNote, nameof(bodytrackingpickupNote), required: false);
            return new DeferredBodyAction<CreateTrackingResponse>(() =>
            {
                var apiCallPath = "/trackings";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                var trackingObject = new JObject();
                var trackingObjectpropCount = 0;
                if (bodytrackingslug != null)
                {
                    trackingObject["slug"] = ExpressionConverter.ConvertO(bodytrackingslug);
                    trackingObjectpropCount++;
                }

                if (bodytrackingtrackingNumber != null)
                {
                    trackingObject["tracking_number"] = ExpressionConverter.ConvertO(bodytrackingtrackingNumber);
                    trackingObjectpropCount++;
                }

                if (bodytrackingtitle != null)
                {
                    trackingObject["title"] = ExpressionConverter.ConvertO(bodytrackingtitle);
                    trackingObjectpropCount++;
                }

                if (bodytrackingsmses != null)
                {
                    trackingObject["smses"] = ExpressionConverter.ConvertO(bodytrackingsmses);
                    trackingObjectpropCount++;
                }

                if (bodytrackingemails != null)
                {
                    trackingObject["emails"] = ExpressionConverter.ConvertO(bodytrackingemails);
                    trackingObjectpropCount++;
                }

                if (bodytrackingorderId != null)
                {
                    trackingObject["order_id"] = ExpressionConverter.ConvertO(bodytrackingorderId);
                    trackingObjectpropCount++;
                }

                if (bodytrackingorderIdPath != null)
                {
                    trackingObject["order_id_path"] = ExpressionConverter.ConvertO(bodytrackingorderIdPath);
                    trackingObjectpropCount++;
                }

                var customFieldsObject = new JObject();
                var customFieldsObjectpropCount = 0;
                if (bodytrackingcustomFieldsproductName != null)
                {
                    customFieldsObject["product_name"] = ExpressionConverter.ConvertO(bodytrackingcustomFieldsproductName);
                    customFieldsObjectpropCount++;
                }

                if (bodytrackingcustomFieldsproductPrice != null)
                {
                    customFieldsObject["product_price"] = ExpressionConverter.ConvertO(bodytrackingcustomFieldsproductPrice);
                    customFieldsObjectpropCount++;
                }

                if (customFieldsObjectpropCount > 0)
                {
                    trackingObject["custom_fields"] = customFieldsObject;
                    trackingObjectpropCount++;
                }

                if (bodytrackinglanguage != null)
                {
                    trackingObject["language"] = ExpressionConverter.ConvertO(bodytrackinglanguage);
                    trackingObjectpropCount++;
                }

                if (bodytrackingorderPromisedDeliveryDate != null)
                {
                    trackingObject["order_promised_delivery_date"] = ExpressionConverter.ConvertO(bodytrackingorderPromisedDeliveryDate);
                    trackingObjectpropCount++;
                }

                if (bodytrackingdeliveryType != null)
                {
                    trackingObject["delivery_type"] = ExpressionConverter.ConvertO(bodytrackingdeliveryType);
                    trackingObjectpropCount++;
                }

                if (bodytrackingpickupLocation != null)
                {
                    trackingObject["pickup_location"] = ExpressionConverter.ConvertO(bodytrackingpickupLocation);
                    trackingObjectpropCount++;
                }

                if (bodytrackingpickupNote != null)
                {
                    trackingObject["pickup_note"] = ExpressionConverter.ConvertO(bodytrackingpickupNote);
                    trackingObjectpropCount++;
                }

                if (trackingObjectpropCount > 0)
                {
                    body["tracking"] = trackingObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateTrackingResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aftershipip")]
        [WorkflowExpressionFactory(nameof(__BuildGetATracking))]
        public IBodyWorkflowAction<GetATrackingResponse> GetATracking([WorkflowExpression] Func<string> slug, [WorkflowExpression] Func<string> trackingNumber)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aftershipip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetATrackingResponse> __BuildGetATracking(WorkflowExpression<string> slug, WorkflowExpression<string> trackingNumber)
        {
            WorkflowExpression.Validate(slug, nameof(slug), required: true);
            WorkflowExpression.Validate(trackingNumber, nameof(trackingNumber), required: true);
            return new DeferredBodyAction<GetATrackingResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/trackings/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(slug, 1), ExpressionConverter.ConvertWithUrlEncoding(trackingNumber, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return new ApiConnectionAction<GetATrackingResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aftershipip")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteATracking))]
        public IBodyWorkflowAction<DeleteATrackingResponse> DeleteATracking([WorkflowExpression] Func<string> slug, [WorkflowExpression] Func<string> trackingNumber)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aftershipip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DeleteATrackingResponse> __BuildDeleteATracking(WorkflowExpression<string> slug, WorkflowExpression<string> trackingNumber)
        {
            WorkflowExpression.Validate(slug, nameof(slug), required: true);
            WorkflowExpression.Validate(trackingNumber, nameof(trackingNumber), required: true);
            return new DeferredBodyAction<DeleteATrackingResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/trackings/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(slug, 1), ExpressionConverter.ConvertWithUrlEncoding(trackingNumber, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return new ApiConnectionAction<DeleteATrackingResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aftershipip")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateATracking))]
        public IBodyWorkflowAction<UpdateATrackingResponse> UpdateATracking([WorkflowExpression] Func<string> slug, [WorkflowExpression] Func<string> trackingNumber, [WorkflowExpression] Func<string> bodytrackingtitle = null, [WorkflowExpression] Func<string> bodytrackingnote = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aftershipip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<UpdateATrackingResponse> __BuildUpdateATracking(WorkflowExpression<string> slug, WorkflowExpression<string> trackingNumber, WorkflowExpression<string> bodytrackingtitle = null, WorkflowExpression<string> bodytrackingnote = null)
        {
            WorkflowExpression.Validate(slug, nameof(slug), required: true);
            WorkflowExpression.Validate(trackingNumber, nameof(trackingNumber), required: true);
            WorkflowExpression.Validate(bodytrackingtitle, nameof(bodytrackingtitle), required: false);
            WorkflowExpression.Validate(bodytrackingnote, nameof(bodytrackingnote), required: false);
            return new DeferredBodyAction<UpdateATrackingResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/trackings/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(slug, 1), ExpressionConverter.ConvertWithUrlEncoding(trackingNumber, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                var trackingObject = new JObject();
                var trackingObjectpropCount = 0;
                if (bodytrackingtitle != null)
                {
                    trackingObject["title"] = ExpressionConverter.ConvertO(bodytrackingtitle);
                    trackingObjectpropCount++;
                }

                if (bodytrackingnote != null)
                {
                    trackingObject["note"] = ExpressionConverter.ConvertO(bodytrackingnote);
                    trackingObjectpropCount++;
                }

                if (trackingObjectpropCount > 0)
                {
                    body["tracking"] = trackingObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<UpdateATrackingResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aftershipip")]
        [WorkflowExpressionFactory(nameof(__BuildRetrackAnExpiredTracking))]
        public IBodyWorkflowAction<RetrackAnExpiredTrackingResponse> RetrackAnExpiredTracking([WorkflowExpression] Func<string> slug, [WorkflowExpression] Func<string> trackingNumber)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aftershipip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<RetrackAnExpiredTrackingResponse> __BuildRetrackAnExpiredTracking(WorkflowExpression<string> slug, WorkflowExpression<string> trackingNumber)
        {
            WorkflowExpression.Validate(slug, nameof(slug), required: true);
            WorkflowExpression.Validate(trackingNumber, nameof(trackingNumber), required: true);
            return new DeferredBodyAction<RetrackAnExpiredTrackingResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/trackings/{0}/{1}/retrack", ExpressionConverter.ConvertWithUrlEncoding(slug, 1), ExpressionConverter.ConvertWithUrlEncoding(trackingNumber, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return new ApiConnectionAction<RetrackAnExpiredTrackingResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aftershipip")]
        [WorkflowExpressionFactory(nameof(__BuildMarkTrackingAsCompleted))]
        public IBodyWorkflowAction<MarkTrackingAsCompletedResponse> MarkTrackingAsCompleted([WorkflowExpression] Func<string> slug, [WorkflowExpression] Func<string> trackingNumber, [WorkflowExpression] Func<bodyreasonInput> bodyreason = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aftershipip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MarkTrackingAsCompletedResponse> __BuildMarkTrackingAsCompleted(WorkflowExpression<string> slug, WorkflowExpression<string> trackingNumber, WorkflowExpression<bodyreasonInput> bodyreason = null)
        {
            WorkflowExpression.Validate(slug, nameof(slug), required: true);
            WorkflowExpression.Validate(trackingNumber, nameof(trackingNumber), required: true);
            WorkflowExpression.Validate(bodyreason, nameof(bodyreason), required: false);
            return new DeferredBodyAction<MarkTrackingAsCompletedResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/trackings/{0}/{1}/mark-as-completed", ExpressionConverter.ConvertWithUrlEncoding(slug, 1), ExpressionConverter.ConvertWithUrlEncoding(trackingNumber, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyreason != null)
                {
                    body["reason"] = ExpressionConverter.ConvertO(bodyreason);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<MarkTrackingAsCompletedResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aftershipip")]
        [WorkflowExpressionFactory(nameof(__BuildGetTrackingNotification))]
        public IBodyWorkflowAction<GetTrackingNotificationResponse> GetTrackingNotification([WorkflowExpression] Func<string> slug, [WorkflowExpression] Func<string> trackingNumber)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aftershipip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetTrackingNotificationResponse> __BuildGetTrackingNotification(WorkflowExpression<string> slug, WorkflowExpression<string> trackingNumber)
        {
            WorkflowExpression.Validate(slug, nameof(slug), required: true);
            WorkflowExpression.Validate(trackingNumber, nameof(trackingNumber), required: true);
            return new DeferredBodyAction<GetTrackingNotificationResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/notifications/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(slug, 1), ExpressionConverter.ConvertWithUrlEncoding(trackingNumber, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return new ApiConnectionAction<GetTrackingNotificationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aftershipip")]
        [WorkflowExpressionFactory(nameof(__BuildAddANotification))]
        public IBodyWorkflowAction<AddANotificationResponse> AddANotification([WorkflowExpression] Func<string> slug, [WorkflowExpression] Func<string> trackingNumber)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aftershipip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AddANotificationResponse> __BuildAddANotification(WorkflowExpression<string> slug, WorkflowExpression<string> trackingNumber)
        {
            WorkflowExpression.Validate(slug, nameof(slug), required: true);
            WorkflowExpression.Validate(trackingNumber, nameof(trackingNumber), required: true);
            return new DeferredBodyAction<AddANotificationResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/notifications/{0}/{1}/add", ExpressionConverter.ConvertWithUrlEncoding(slug, 1), ExpressionConverter.ConvertWithUrlEncoding(trackingNumber, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                var notificationObject = new JObject();
                var notificationObjectpropCount = 0;
                var emailsObject = new JObject();
                var emailsObjectpropCount = 0;
                if (emailsObjectpropCount > 0)
                {
                    notificationObject["emails"] = emailsObject;
                    notificationObjectpropCount++;
                }

                var smsesObject = new JObject();
                var smsesObjectpropCount = 0;
                if (smsesObjectpropCount > 0)
                {
                    notificationObject["smses"] = smsesObject;
                    notificationObjectpropCount++;
                }

                if (notificationObjectpropCount > 0)
                {
                    body["notification"] = notificationObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<AddANotificationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aftershipip")]
        [WorkflowExpressionFactory(nameof(__BuildRemoveANotification))]
        public IBodyWorkflowAction<RemoveANotificationResponse> RemoveANotification([WorkflowExpression] Func<string> slug, [WorkflowExpression] Func<string> trackingNumber)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aftershipip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<RemoveANotificationResponse> __BuildRemoveANotification(WorkflowExpression<string> slug, WorkflowExpression<string> trackingNumber)
        {
            WorkflowExpression.Validate(slug, nameof(slug), required: true);
            WorkflowExpression.Validate(trackingNumber, nameof(trackingNumber), required: true);
            return new DeferredBodyAction<RemoveANotificationResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/notifications/{0}/{1}/remove", ExpressionConverter.ConvertWithUrlEncoding(slug, 1), ExpressionConverter.ConvertWithUrlEncoding(trackingNumber, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                var notificationObject = new JObject();
                var notificationObjectpropCount = 0;
                var emailsObject = new JObject();
                var emailsObjectpropCount = 0;
                if (emailsObjectpropCount > 0)
                {
                    notificationObject["emails"] = emailsObject;
                    notificationObjectpropCount++;
                }

                var smsesObject = new JObject();
                var smsesObjectpropCount = 0;
                if (smsesObjectpropCount > 0)
                {
                    notificationObject["smses"] = smsesObject;
                    notificationObjectpropCount++;
                }

                if (notificationObjectpropCount > 0)
                {
                    body["notification"] = notificationObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<RemoveANotificationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aftershipip")]
        [WorkflowExpressionFactory(nameof(__BuildGetLastCheckpoint))]
        public IBodyWorkflowAction<GetLastCheckpointResponse> GetLastCheckpoint([WorkflowExpression] Func<string> slug, [WorkflowExpression] Func<string> trackingNumber)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aftershipip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetLastCheckpointResponse> __BuildGetLastCheckpoint(WorkflowExpression<string> slug, WorkflowExpression<string> trackingNumber)
        {
            WorkflowExpression.Validate(slug, nameof(slug), required: true);
            WorkflowExpression.Validate(trackingNumber, nameof(trackingNumber), required: true);
            return new DeferredBodyAction<GetLastCheckpointResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/last_checkpoint/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(slug, 1), ExpressionConverter.ConvertWithUrlEncoding(trackingNumber, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return new ApiConnectionAction<GetLastCheckpointResponse>(callPayload);
            });
        }
    }

    public class AftershipipTriggers([ConnectionName] string connectionId)
    {
    }

    public class GetUserActivatedCouriersResponse
    {
        [JsonProperty("meta")]
        public GetUserActivatedCouriersResponseMetaType Meta { get; set; }

        [JsonProperty("data")]
        public GetUserActivatedCouriersResponseDataType Data { get; set; }
    }

    public class GetUserActivatedCouriersResponseMetaType
    {
        [JsonProperty("code")]
        public int Code { get; set; }
    }

    public class GetUserActivatedCouriersResponseDataType
    {
        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("couriers")]
        public GetUserActivatedCouriersResponseDataTypeCouriersTypeItem[] Couriers { get; set; }
    }

    public class GetUserActivatedCouriersResponseDataTypeCouriersTypeItem
    {
        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("other_name")]
        public string OtherName { get; set; }

        [JsonProperty("web_url")]
        public string WebUrl { get; set; }

        [JsonProperty("required_fields")]
        public string[] RequiredFields { get; set; }

        [JsonProperty("optional_fields")]
        public string[] OptionalFields { get; set; }

        [JsonProperty("default_language")]
        public string DefaultLanguage { get; set; }

        [JsonProperty("support_languages")]
        public string[] SupportLanguages { get; set; }

        [JsonProperty("service_from_country_iso3")]
        public string[] ServiceFromCountryIso3 { get; set; }
    }

    public class DetectCourierResponse
    {
        [JsonProperty("meta")]
        public DetectCourierResponseMetaType Meta { get; set; }

        [JsonProperty("data")]
        public DetectCourierResponseDataType Data { get; set; }
    }

    public class DetectCourierResponseMetaType
    {
        [JsonProperty("code")]
        public int Code { get; set; }
    }

    public class DetectCourierResponseDataType
    {
        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("couriers")]
        public DetectCourierResponseDataTypeCouriersTypeItem[] Couriers { get; set; }
    }

    public class DetectCourierResponseDataTypeCouriersTypeItem
    {
        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("other_name")]
        public string OtherName { get; set; }

        [JsonProperty("web_url")]
        public string WebUrl { get; set; }

        [JsonProperty("required_fields")]
        public string[] RequiredFields { get; set; }

        [JsonProperty("optional_fields")]
        public string[] OptionalFields { get; set; }

        [JsonProperty("default_language")]
        public string DefaultLanguage { get; set; }

        [JsonProperty("support_languages")]
        public string[] SupportLanguages { get; set; }

        [JsonProperty("service_from_country_iso3")]
        public string[] ServiceFromCountryIso3 { get; set; }
    }

    public class GetAllCouriersResponse
    {
        [JsonProperty("meta")]
        public GetAllCouriersResponseMetaType Meta { get; set; }

        [JsonProperty("data")]
        public GetAllCouriersResponseDataType Data { get; set; }
    }

    public class GetAllCouriersResponseMetaType
    {
        [JsonProperty("code")]
        public int Code { get; set; }
    }

    public class GetAllCouriersResponseDataType
    {
        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("couriers")]
        public GetAllCouriersResponseDataTypeCouriersTypeItem[] Couriers { get; set; }
    }

    public class GetAllCouriersResponseDataTypeCouriersTypeItem
    {
        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("other_name")]
        public string OtherName { get; set; }

        [JsonProperty("web_url")]
        public string WebUrl { get; set; }

        [JsonProperty("required_fields")]
        public JToken[] RequiredFields { get; set; }

        [JsonProperty("optional_fields")]
        public JToken[] OptionalFields { get; set; }
    }

    public class GetTrackingsResponse
    {
        [JsonProperty("meta")]
        public GetTrackingsResponseMetaType Meta { get; set; }

        [JsonProperty("data")]
        public GetTrackingsResponseDataType Data { get; set; }
    }

    public class GetTrackingsResponseMetaType
    {
        [JsonProperty("code")]
        public int Code { get; set; }
    }

    public class GetTrackingsResponseDataType
    {
        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("limit")]
        public int Limit { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("keyword")]
        public string Keyword { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("origin")]
        public JToken[] Origin { get; set; }

        [JsonProperty("destination")]
        public JToken[] Destination { get; set; }

        [JsonProperty("tag")]
        public string Tag { get; set; }

        [JsonProperty("fields")]
        public string Fields { get; set; }

        [JsonProperty("created_at_min")]
        public string CreatedAtMin { get; set; }

        [JsonProperty("created_at_max")]
        public string CreatedAtMax { get; set; }

        [JsonProperty("last_updated_at")]
        public string LastUpdatedAt { get; set; }

        [JsonProperty("return_to_sender")]
        public JToken[] ReturnToSender { get; set; }

        [JsonProperty("courier_destination_country_iso3")]
        public JToken[] CourierDestinationCountryIso3 { get; set; }

        [JsonProperty("trackings")]
        public GetTrackingsResponseDataTypeTrackingsTypeItem[] Trackings { get; set; }
    }

    public class GetTrackingsResponseDataTypeTrackingsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("last_updated_at")]
        public string LastUpdatedAt { get; set; }

        [JsonProperty("tracking_number")]
        public string TrackingNumber { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("android")]
        public JToken[] Android { get; set; }

        [JsonProperty("custom_fields")]
        public string CustomFields { get; set; }

        [JsonProperty("customer_name")]
        public string CustomerName { get; set; }

        [JsonProperty("delivery_time")]
        public int DeliveryTime { get; set; }

        [JsonProperty("destination_country_iso3")]
        public string DestinationCountryIso3 { get; set; }

        [JsonProperty("courier_destination_country_iso3")]
        public string CourierDestinationCountryIso3 { get; set; }

        [JsonProperty("emails")]
        public string[] Emails { get; set; }

        [JsonProperty("expected_delivery")]
        public string ExpectedDelivery { get; set; }

        [JsonProperty("ios")]
        public JToken[] Ios { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("order_id")]
        public string OrderId { get; set; }

        [JsonProperty("order_id_path")]
        public string OrderIdPath { get; set; }

        [JsonProperty("origin_country_iso3")]
        public string OriginCountryIso3 { get; set; }

        [JsonProperty("shipment_package_count")]
        public int ShipmentPackageCount { get; set; }

        [JsonProperty("shipment_pickup_date")]
        public string ShipmentPickupDate { get; set; }

        [JsonProperty("shipment_delivery_date")]
        public string ShipmentDeliveryDate { get; set; }

        [JsonProperty("shipment_type")]
        public string ShipmentType { get; set; }

        [JsonProperty("shipment_weight")]
        public string ShipmentWeight { get; set; }

        [JsonProperty("shipment_weight_unit")]
        public string ShipmentWeightUnit { get; set; }

        [JsonProperty("signed_by")]
        public string SignedBy { get; set; }

        [JsonProperty("smses")]
        public string[] Smses { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("tag")]
        public string Tag { get; set; }

        [JsonProperty("subtag")]
        public string Subtag { get; set; }

        [JsonProperty("subtag_message")]
        public string SubtagMessage { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("tracked_count")]
        public int TrackedCount { get; set; }

        [JsonProperty("last_mile_tracking_supported")]
        public string LastMileTrackingSupported { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("unique_token")]
        public string UniqueToken { get; set; }

        [JsonProperty("checkpoints")]
        public GetTrackingsResponseDataTypeTrackingsTypeItemCheckpointsTypeItem[] Checkpoints { get; set; }

        [JsonProperty("subscribed_smses")]
        public string[] SubscribedSmses { get; set; }

        [JsonProperty("subscribed_emails")]
        public string[] SubscribedEmails { get; set; }

        [JsonProperty("return_to_sender")]
        public bool ReturnToSender { get; set; }

        [JsonProperty("tracking_account_number")]
        public string TrackingAccountNumber { get; set; }

        [JsonProperty("tracking_origin_country")]
        public string TrackingOriginCountry { get; set; }

        [JsonProperty("tracking_destination_country")]
        public string TrackingDestinationCountry { get; set; }

        [JsonProperty("tracking_key")]
        public string TrackingKey { get; set; }

        [JsonProperty("tracking_postal_code")]
        public string TrackingPostalCode { get; set; }

        [JsonProperty("tracking_ship_date")]
        public string TrackingShipDate { get; set; }

        [JsonProperty("tracking_state")]
        public string TrackingState { get; set; }

        [JsonProperty("order_promised_delivery_date")]
        public string OrderPromisedDeliveryDate { get; set; }

        [JsonProperty("delivery_type")]
        public string DeliveryType { get; set; }

        [JsonProperty("pickup_location")]
        public string PickupLocation { get; set; }

        [JsonProperty("pickup_note")]
        public string PickupNote { get; set; }

        [JsonProperty("courier_tracking_link")]
        public string CourierTrackingLink { get; set; }

        [JsonProperty("courier_redirect_link")]
        public string CourierRedirectLink { get; set; }

        [JsonProperty("first_attempted_at")]
        public string FirstAttemptedAt { get; set; }
    }

    public class GetTrackingsResponseDataTypeTrackingsTypeItemCheckpointsTypeItem
    {
        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("country_name")]
        public string CountryName { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("country_iso3")]
        public string CountryIso3 { get; set; }

        [JsonProperty("tag")]
        public string Tag { get; set; }

        [JsonProperty("subtag")]
        public string Subtag { get; set; }

        [JsonProperty("subtag_message")]
        public string SubtagMessage { get; set; }

        [JsonProperty("checkpoint_time")]
        public string CheckpointTime { get; set; }

        [JsonProperty("coordinates")]
        public JToken[] Coordinates { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("zip")]
        public string Zip { get; set; }

        [JsonProperty("raw_tag")]
        public string RawTag { get; set; }
    }

    public class CreateTrackingResponse
    {
        [JsonProperty("meta")]
        public CreateTrackingResponseMetaType Meta { get; set; }

        [JsonProperty("data")]
        public CreateTrackingResponseDataType Data { get; set; }
    }

    public class CreateTrackingResponseMetaType
    {
        [JsonProperty("code")]
        public int Code { get; set; }
    }

    public class CreateTrackingResponseDataType
    {
        [JsonProperty("tracking")]
        public CreateTrackingResponseDataTypeTrackingType Tracking { get; set; }
    }

    public class CreateTrackingResponseDataTypeTrackingType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("last_updated_at")]
        public string LastUpdatedAt { get; set; }

        [JsonProperty("tracking_number")]
        public string TrackingNumber { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("android")]
        public JToken[] Android { get; set; }

        [JsonProperty("custom_fields")]
        public string CustomFields { get; set; }

        [JsonProperty("customer_name")]
        public string CustomerName { get; set; }

        [JsonProperty("delivery_time")]
        public int DeliveryTime { get; set; }

        [JsonProperty("destination_country_iso3")]
        public string DestinationCountryIso3 { get; set; }

        [JsonProperty("courier_destination_country_iso3")]
        public string CourierDestinationCountryIso3 { get; set; }

        [JsonProperty("emails")]
        public JToken[] Emails { get; set; }

        [JsonProperty("expected_delivery")]
        public string ExpectedDelivery { get; set; }

        [JsonProperty("ios")]
        public JToken[] Ios { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("order_id")]
        public string OrderId { get; set; }

        [JsonProperty("order_id_path")]
        public string OrderIdPath { get; set; }

        [JsonProperty("origin_country_iso3")]
        public string OriginCountryIso3 { get; set; }

        [JsonProperty("shipment_package_count")]
        public int ShipmentPackageCount { get; set; }

        [JsonProperty("shipment_pickup_date")]
        public string ShipmentPickupDate { get; set; }

        [JsonProperty("shipment_delivery_date")]
        public string ShipmentDeliveryDate { get; set; }

        [JsonProperty("shipment_type")]
        public string ShipmentType { get; set; }

        [JsonProperty("shipment_weight")]
        public int ShipmentWeight { get; set; }

        [JsonProperty("shipment_weight_unit")]
        public string ShipmentWeightUnit { get; set; }

        [JsonProperty("signed_by")]
        public string SignedBy { get; set; }

        [JsonProperty("smses")]
        public JToken[] Smses { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("tag")]
        public string Tag { get; set; }

        [JsonProperty("subtag")]
        public string Subtag { get; set; }

        [JsonProperty("subtag_message")]
        public string SubtagMessage { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("tracked_count")]
        public int TrackedCount { get; set; }

        [JsonProperty("last_mile_tracking_supported")]
        public bool LastMileTrackingSupported { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("unique_token")]
        public string UniqueToken { get; set; }

        [JsonProperty("checkpoints")]
        public JToken[] Checkpoints { get; set; }

        [JsonProperty("subscribed_smses")]
        public JToken[] SubscribedSmses { get; set; }

        [JsonProperty("subscribed_emails")]
        public JToken[] SubscribedEmails { get; set; }

        [JsonProperty("return_to_sender")]
        public bool ReturnToSender { get; set; }

        [JsonProperty("tracking_account_number")]
        public string TrackingAccountNumber { get; set; }

        [JsonProperty("tracking_origin_country")]
        public string TrackingOriginCountry { get; set; }

        [JsonProperty("tracking_destination_country")]
        public string TrackingDestinationCountry { get; set; }

        [JsonProperty("tracking_key")]
        public string TrackingKey { get; set; }

        [JsonProperty("tracking_postal_code")]
        public string TrackingPostalCode { get; set; }

        [JsonProperty("tracking_ship_date")]
        public string TrackingShipDate { get; set; }

        [JsonProperty("tracking_state")]
        public string TrackingState { get; set; }

        [JsonProperty("order_promised_delivery_date")]
        public string OrderPromisedDeliveryDate { get; set; }

        [JsonProperty("delivery_type")]
        public string DeliveryType { get; set; }

        [JsonProperty("pickup_location")]
        public string PickupLocation { get; set; }

        [JsonProperty("pickup_note")]
        public string PickupNote { get; set; }

        [JsonProperty("courier_tracking_link")]
        public string CourierTrackingLink { get; set; }

        [JsonProperty("courier_redirect_link")]
        public string CourierRedirectLink { get; set; }

        [JsonProperty("first_attempted_at")]
        public string FirstAttemptedAt { get; set; }
    }

    public class GetATrackingResponse
    {
        [JsonProperty("meta")]
        public GetATrackingResponseMetaType Meta { get; set; }

        [JsonProperty("data")]
        public GetATrackingResponseDataType Data { get; set; }
    }

    public class GetATrackingResponseMetaType
    {
        [JsonProperty("code")]
        public int Code { get; set; }
    }

    public class GetATrackingResponseDataType
    {
        [JsonProperty("tracking")]
        public GetATrackingResponseDataTypeTrackingType Tracking { get; set; }
    }

    public class GetATrackingResponseDataTypeTrackingType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("last_updated_at")]
        public string LastUpdatedAt { get; set; }

        [JsonProperty("tracking_number")]
        public string TrackingNumber { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("android")]
        public JToken[] Android { get; set; }

        [JsonProperty("custom_fields")]
        public string CustomFields { get; set; }

        [JsonProperty("customer_name")]
        public string CustomerName { get; set; }

        [JsonProperty("delivery_time")]
        public int DeliveryTime { get; set; }

        [JsonProperty("destination_country_iso3")]
        public string DestinationCountryIso3 { get; set; }

        [JsonProperty("courier_destination_country_iso3")]
        public string CourierDestinationCountryIso3 { get; set; }

        [JsonProperty("emails")]
        public JToken[] Emails { get; set; }

        [JsonProperty("expected_delivery")]
        public string ExpectedDelivery { get; set; }

        [JsonProperty("ios")]
        public JToken[] Ios { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("order_id")]
        public string OrderId { get; set; }

        [JsonProperty("order_id_path")]
        public string OrderIdPath { get; set; }

        [JsonProperty("origin_country_iso3")]
        public string OriginCountryIso3 { get; set; }

        [JsonProperty("shipment_package_count")]
        public int ShipmentPackageCount { get; set; }

        [JsonProperty("shipment_pickup_date")]
        public string ShipmentPickupDate { get; set; }

        [JsonProperty("shipment_delivery_date")]
        public string ShipmentDeliveryDate { get; set; }

        [JsonProperty("shipment_type")]
        public string ShipmentType { get; set; }

        [JsonProperty("shipment_weight")]
        public int ShipmentWeight { get; set; }

        [JsonProperty("shipment_weight_unit")]
        public string ShipmentWeightUnit { get; set; }

        [JsonProperty("signed_by")]
        public string SignedBy { get; set; }

        [JsonProperty("smses")]
        public JToken[] Smses { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("tag")]
        public string Tag { get; set; }

        [JsonProperty("subtag")]
        public string Subtag { get; set; }

        [JsonProperty("subtag_message")]
        public string SubtagMessage { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("tracked_count")]
        public int TrackedCount { get; set; }

        [JsonProperty("last_mile_tracking_supported")]
        public string LastMileTrackingSupported { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("unique_token")]
        public string UniqueToken { get; set; }

        [JsonProperty("checkpoints")]
        public GetATrackingResponseDataTypeTrackingTypeCheckpointsTypeItem[] Checkpoints { get; set; }

        [JsonProperty("subscribed_smses")]
        public JToken[] SubscribedSmses { get; set; }

        [JsonProperty("subscribed_emails")]
        public JToken[] SubscribedEmails { get; set; }

        [JsonProperty("return_to_sender")]
        public bool ReturnToSender { get; set; }

        [JsonProperty("tracking_account_number")]
        public string TrackingAccountNumber { get; set; }

        [JsonProperty("tracking_origin_country")]
        public string TrackingOriginCountry { get; set; }

        [JsonProperty("tracking_destination_country")]
        public string TrackingDestinationCountry { get; set; }

        [JsonProperty("tracking_key")]
        public string TrackingKey { get; set; }

        [JsonProperty("tracking_postal_code")]
        public string TrackingPostalCode { get; set; }

        [JsonProperty("tracking_ship_date")]
        public string TrackingShipDate { get; set; }

        [JsonProperty("tracking_state")]
        public string TrackingState { get; set; }

        [JsonProperty("order_promised_delivery_date")]
        public string OrderPromisedDeliveryDate { get; set; }

        [JsonProperty("delivery_type")]
        public string DeliveryType { get; set; }

        [JsonProperty("pickup_location")]
        public string PickupLocation { get; set; }

        [JsonProperty("pickup_note")]
        public string PickupNote { get; set; }

        [JsonProperty("courier_tracking_link")]
        public string CourierTrackingLink { get; set; }

        [JsonProperty("courier_redirect_link")]
        public string CourierRedirectLink { get; set; }

        [JsonProperty("first_attempted_at")]
        public string FirstAttemptedAt { get; set; }
    }

    public class GetATrackingResponseDataTypeTrackingTypeCheckpointsTypeItem
    {
        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("country_name")]
        public string CountryName { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("country_iso3")]
        public string CountryIso3 { get; set; }

        [JsonProperty("tag")]
        public string Tag { get; set; }

        [JsonProperty("subtag")]
        public string Subtag { get; set; }

        [JsonProperty("subtag_message")]
        public string SubtagMessage { get; set; }

        [JsonProperty("checkpoint_time")]
        public string CheckpointTime { get; set; }

        [JsonProperty("coordinates")]
        public JToken[] Coordinates { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("zip")]
        public string Zip { get; set; }

        [JsonProperty("raw_tag")]
        public string RawTag { get; set; }
    }

    public class DeleteATrackingResponse
    {
        [JsonProperty("meta")]
        public DeleteATrackingResponseMetaType Meta { get; set; }

        [JsonProperty("data")]
        public DeleteATrackingResponseDataType Data { get; set; }
    }

    public class DeleteATrackingResponseMetaType
    {
        [JsonProperty("code")]
        public int Code { get; set; }
    }

    public class DeleteATrackingResponseDataType
    {
        [JsonProperty("tracking")]
        public DeleteATrackingResponseDataTypeTrackingType Tracking { get; set; }
    }

    public class DeleteATrackingResponseDataTypeTrackingType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("tracking_number")]
        public string TrackingNumber { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("tracking_account_number")]
        public string TrackingAccountNumber { get; set; }

        [JsonProperty("tracking_origin_country")]
        public string TrackingOriginCountry { get; set; }

        [JsonProperty("tracking_destination_country")]
        public string TrackingDestinationCountry { get; set; }

        [JsonProperty("tracking_key")]
        public string TrackingKey { get; set; }

        [JsonProperty("tracking_postal_code")]
        public string TrackingPostalCode { get; set; }

        [JsonProperty("tracking_ship_date")]
        public string TrackingShipDate { get; set; }

        [JsonProperty("tracking_state")]
        public string TrackingState { get; set; }
    }

    public class UpdateATrackingResponse
    {
        [JsonProperty("meta")]
        public UpdateATrackingResponseMetaType Meta { get; set; }

        [JsonProperty("data")]
        public UpdateATrackingResponseDataType Data { get; set; }
    }

    public class UpdateATrackingResponseMetaType
    {
        [JsonProperty("code")]
        public int Code { get; set; }
    }

    public class UpdateATrackingResponseDataType
    {
        [JsonProperty("tracking")]
        public UpdateATrackingResponseDataTypeTrackingType Tracking { get; set; }
    }

    public class UpdateATrackingResponseDataTypeTrackingType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("last_updated_at")]
        public string LastUpdatedAt { get; set; }

        [JsonProperty("tracking_number")]
        public string TrackingNumber { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("android")]
        public JToken[] Android { get; set; }

        [JsonProperty("custom_fields")]
        public string CustomFields { get; set; }

        [JsonProperty("customer_name")]
        public string CustomerName { get; set; }

        [JsonProperty("delivery_time")]
        public int DeliveryTime { get; set; }

        [JsonProperty("destination_country_iso3")]
        public string DestinationCountryIso3 { get; set; }

        [JsonProperty("courier_destination_country_iso3")]
        public string CourierDestinationCountryIso3 { get; set; }

        [JsonProperty("emails")]
        public JToken[] Emails { get; set; }

        [JsonProperty("expected_delivery")]
        public string ExpectedDelivery { get; set; }

        [JsonProperty("ios")]
        public JToken[] Ios { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("order_id")]
        public string OrderId { get; set; }

        [JsonProperty("order_id_path")]
        public string OrderIdPath { get; set; }

        [JsonProperty("origin_country_iso3")]
        public string OriginCountryIso3 { get; set; }

        [JsonProperty("shipment_package_count")]
        public int ShipmentPackageCount { get; set; }

        [JsonProperty("shipment_pickup_date")]
        public string ShipmentPickupDate { get; set; }

        [JsonProperty("shipment_delivery_date")]
        public string ShipmentDeliveryDate { get; set; }

        [JsonProperty("shipment_type")]
        public string ShipmentType { get; set; }

        [JsonProperty("shipment_weight")]
        public int ShipmentWeight { get; set; }

        [JsonProperty("shipment_weight_unit")]
        public string ShipmentWeightUnit { get; set; }

        [JsonProperty("signed_by")]
        public string SignedBy { get; set; }

        [JsonProperty("smses")]
        public JToken[] Smses { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("tag")]
        public string Tag { get; set; }

        [JsonProperty("subtag")]
        public string Subtag { get; set; }

        [JsonProperty("subtag_message")]
        public string SubtagMessage { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("tracked_count")]
        public int TrackedCount { get; set; }

        [JsonProperty("last_mile_tracking_supported")]
        public string LastMileTrackingSupported { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("unique_token")]
        public string UniqueToken { get; set; }

        [JsonProperty("checkpoints")]
        public UpdateATrackingResponseDataTypeTrackingTypeCheckpointsTypeItem[] Checkpoints { get; set; }

        [JsonProperty("subscribed_smses")]
        public JToken[] SubscribedSmses { get; set; }

        [JsonProperty("subscribed_emails")]
        public JToken[] SubscribedEmails { get; set; }

        [JsonProperty("return_to_sender")]
        public bool ReturnToSender { get; set; }

        [JsonProperty("tracking_account_number")]
        public string TrackingAccountNumber { get; set; }

        [JsonProperty("tracking_origin_country")]
        public string TrackingOriginCountry { get; set; }

        [JsonProperty("tracking_destination_country")]
        public string TrackingDestinationCountry { get; set; }

        [JsonProperty("tracking_key")]
        public string TrackingKey { get; set; }

        [JsonProperty("tracking_postal_code")]
        public string TrackingPostalCode { get; set; }

        [JsonProperty("tracking_ship_date")]
        public string TrackingShipDate { get; set; }

        [JsonProperty("tracking_state")]
        public string TrackingState { get; set; }

        [JsonProperty("order_promised_delivery_date")]
        public string OrderPromisedDeliveryDate { get; set; }

        [JsonProperty("delivery_type")]
        public string DeliveryType { get; set; }

        [JsonProperty("pickup_location")]
        public string PickupLocation { get; set; }

        [JsonProperty("pickup_note")]
        public string PickupNote { get; set; }

        [JsonProperty("courier_tracking_link")]
        public string CourierTrackingLink { get; set; }

        [JsonProperty("courier_redirect_link")]
        public string CourierRedirectLink { get; set; }

        [JsonProperty("first_attempted_at")]
        public string FirstAttemptedAt { get; set; }
    }

    public class UpdateATrackingResponseDataTypeTrackingTypeCheckpointsTypeItem
    {
        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("country_name")]
        public string CountryName { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("country_iso3")]
        public string CountryIso3 { get; set; }

        [JsonProperty("tag")]
        public string Tag { get; set; }

        [JsonProperty("subtag")]
        public string Subtag { get; set; }

        [JsonProperty("subtag_message")]
        public string SubtagMessage { get; set; }

        [JsonProperty("checkpoint_time")]
        public string CheckpointTime { get; set; }

        [JsonProperty("coordinates")]
        public JToken[] Coordinates { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("zip")]
        public string Zip { get; set; }

        [JsonProperty("raw_tag")]
        public string RawTag { get; set; }
    }

    public class RetrackAnExpiredTrackingResponse
    {
        [JsonProperty("meta")]
        public RetrackAnExpiredTrackingResponseMetaType Meta { get; set; }

        [JsonProperty("data")]
        public RetrackAnExpiredTrackingResponseDataType Data { get; set; }
    }

    public class RetrackAnExpiredTrackingResponseMetaType
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class RetrackAnExpiredTrackingResponseDataType
    {
        [JsonProperty("tracking")]
        public RetrackAnExpiredTrackingResponseDataTypeTrackingType Tracking { get; set; }
    }

    public class RetrackAnExpiredTrackingResponseDataTypeTrackingType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("tracking_number")]
        public string TrackingNumber { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("tracking_account_number")]
        public string TrackingAccountNumber { get; set; }

        [JsonProperty("tracking_origin_country")]
        public string TrackingOriginCountry { get; set; }

        [JsonProperty("tracking_destination_country")]
        public string TrackingDestinationCountry { get; set; }

        [JsonProperty("tracking_key")]
        public string TrackingKey { get; set; }

        [JsonProperty("tracking_postal_code")]
        public string TrackingPostalCode { get; set; }

        [JsonProperty("tracking_ship_date")]
        public string TrackingShipDate { get; set; }

        [JsonProperty("tracking_state")]
        public string TrackingState { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }
    }

    public class MarkTrackingAsCompletedResponse
    {
        [JsonProperty("meta")]
        public MarkTrackingAsCompletedResponseMetaType Meta { get; set; }

        [JsonProperty("data")]
        public JToken Data { get; set; }
    }

    public class MarkTrackingAsCompletedResponseMetaType
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public enum bodyreasonInput
    {
        DELIVERED,
        LOST,
        [EnumMember(Value = "RETURNED_TO_SENDER")]
        RETURNEDTOSENDER
    }

    public class GetTrackingNotificationResponse
    {
        [JsonProperty("meta")]
        public GetTrackingNotificationResponseMetaType Meta { get; set; }

        [JsonProperty("data")]
        public GetTrackingNotificationResponseDataType Data { get; set; }
    }

    public class GetTrackingNotificationResponseMetaType
    {
        [JsonProperty("code")]
        public int Code { get; set; }
    }

    public class GetTrackingNotificationResponseDataType
    {
        [JsonProperty("notification")]
        public GetTrackingNotificationResponseDataTypeNotificationType Notification { get; set; }
    }

    public class GetTrackingNotificationResponseDataTypeNotificationType
    {
        [JsonProperty("emails")]
        public JToken[] Emails { get; set; }

        [JsonProperty("smses")]
        public string[] Smses { get; set; }
    }

    public class AddANotificationResponse
    {
        [JsonProperty("meta")]
        public AddANotificationResponseMetaType Meta { get; set; }

        [JsonProperty("data")]
        public AddANotificationResponseDataType Data { get; set; }
    }

    public class AddANotificationResponseMetaType
    {
        [JsonProperty("code")]
        public int Code { get; set; }
    }

    public class AddANotificationResponseDataType
    {
        [JsonProperty("notification")]
        public AddANotificationResponseDataTypeNotificationType Notification { get; set; }
    }

    public class AddANotificationResponseDataTypeNotificationType
    {
        [JsonProperty("emails")]
        public JToken[] Emails { get; set; }

        [JsonProperty("smses")]
        public string[] Smses { get; set; }
    }

    public class RemoveANotificationResponse
    {
        [JsonProperty("meta")]
        public RemoveANotificationResponseMetaType Meta { get; set; }

        [JsonProperty("data")]
        public RemoveANotificationResponseDataType Data { get; set; }
    }

    public class RemoveANotificationResponseMetaType
    {
        [JsonProperty("code")]
        public int Code { get; set; }
    }

    public class RemoveANotificationResponseDataType
    {
        [JsonProperty("notification")]
        public RemoveANotificationResponseDataTypeNotificationType Notification { get; set; }
    }

    public class RemoveANotificationResponseDataTypeNotificationType
    {
        [JsonProperty("emails")]
        public JToken[] Emails { get; set; }

        [JsonProperty("smses")]
        public string[] Smses { get; set; }
    }

    public class GetLastCheckpointResponse
    {
        [JsonProperty("meta")]
        public GetLastCheckpointResponseMetaType Meta { get; set; }

        [JsonProperty("data")]
        public GetLastCheckpointResponseDataType Data { get; set; }
    }

    public class GetLastCheckpointResponseMetaType
    {
        [JsonProperty("code")]
        public int Code { get; set; }
    }

    public class GetLastCheckpointResponseDataType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("tracking_number")]
        public string TrackingNumber { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("tag")]
        public string Tag { get; set; }

        [JsonProperty("subtag")]
        public string Subtag { get; set; }

        [JsonProperty("subtag_message")]
        public string SubtagMessage { get; set; }

        [JsonProperty("checkpoint")]
        public GetLastCheckpointResponseDataTypeCheckpointType Checkpoint { get; set; }
    }

    public class GetLastCheckpointResponseDataTypeCheckpointType
    {
        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("checkpoint_time")]
        public string CheckpointTime { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("coordinates")]
        public JToken[] Coordinates { get; set; }

        [JsonProperty("country_iso3")]
        public string CountryIso3 { get; set; }

        [JsonProperty("country_name")]
        public string CountryName { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("tag")]
        public string Tag { get; set; }

        [JsonProperty("subtag")]
        public string Subtag { get; set; }

        [JsonProperty("subtag_message")]
        public string SubtagMessage { get; set; }

        [JsonProperty("zip")]
        public string Zip { get; set; }

        [JsonProperty("raw_tag")]
        public string RawTag { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Aftershipip;

    public partial class WorkflowManagedActions
    {
        public AftershipipActions Aftershipip(string connectionId) => new AftershipipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AftershipipTriggers Aftershipip(string connectionId) => new AftershipipTriggers(connectionId);
    }
}