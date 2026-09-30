//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Fhirbase
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class FhirbaseActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GETAppointmentResponse> GETAppointment([WorkflowExpression] Func<string> patient = null, [WorkflowExpression] Func<string> Count = null, [WorkflowExpression] Func<string> Sort = null)
        {
            SourceExpression.Validate(patient, nameof(patient), required: false);
            SourceExpression.Validate(Count, nameof(Count), required: false);
            SourceExpression.Validate(Sort, nameof(Sort), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Appointment";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (patient != null)
                    callPayload.Queries["patient"] = SourceExpressionConverter.ConvertO(patient);
                if (Count != null)
                    callPayload.Queries["_count"] = SourceExpressionConverter.ConvertO(Count);
                if (Sort != null)
                    callPayload.Queries["_sort"] = SourceExpressionConverter.ConvertO(Sort);
                return callPayload;
            }

            return new ApiConnectionAction<GETAppointmentResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<POSTAppointmentResponse> POSTAppointment([WorkflowExpression] Func<string> bodyresourceType = null, [WorkflowExpression] Func<string> bodyid = null, [WorkflowExpression] Func<string> bodytextstatus = null, [WorkflowExpression] Func<string> bodytextdiv = null, [WorkflowExpression] Func<string> bodystatus = null, [WorkflowExpression] Func<bodyserviceCategoryInputItem[]> bodyserviceCategory = null, [WorkflowExpression] Func<bodyserviceTypeInputItem[]> bodyserviceType = null, [WorkflowExpression] Func<bodyspecialtyInputItem[]> bodyspecialty = null, [WorkflowExpression] Func<bodyappointmentTypecodingInputItem[]> bodyappointmentTypecoding = null, [WorkflowExpression] Func<bodyreasonReferenceInputItem[]> bodyreasonReference = null, [WorkflowExpression] Func<int> bodypriority = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<string> bodystart = null, [WorkflowExpression] Func<string> bodyend = null, [WorkflowExpression] Func<string> bodycreated = null, [WorkflowExpression] Func<string> bodycomment = null, [WorkflowExpression] Func<bodybasedOnInputItem[]> bodybasedOn = null, [WorkflowExpression] Func<bodyparticipantInputItem[]> bodyparticipant = null)
        {
            SourceExpression.Validate(bodyresourceType, nameof(bodyresourceType), required: false);
            SourceExpression.Validate(bodyid, nameof(bodyid), required: false);
            SourceExpression.Validate(bodytextstatus, nameof(bodytextstatus), required: false);
            SourceExpression.Validate(bodytextdiv, nameof(bodytextdiv), required: false);
            SourceExpression.Validate(bodystatus, nameof(bodystatus), required: false);
            SourceExpression.Validate(bodyserviceCategory, nameof(bodyserviceCategory), required: false);
            SourceExpression.Validate(bodyserviceType, nameof(bodyserviceType), required: false);
            SourceExpression.Validate(bodyspecialty, nameof(bodyspecialty), required: false);
            SourceExpression.Validate(bodyappointmentTypecoding, nameof(bodyappointmentTypecoding), required: false);
            SourceExpression.Validate(bodyreasonReference, nameof(bodyreasonReference), required: false);
            SourceExpression.Validate(bodypriority, nameof(bodypriority), required: false);
            SourceExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            SourceExpression.Validate(bodystart, nameof(bodystart), required: false);
            SourceExpression.Validate(bodyend, nameof(bodyend), required: false);
            SourceExpression.Validate(bodycreated, nameof(bodycreated), required: false);
            SourceExpression.Validate(bodycomment, nameof(bodycomment), required: false);
            SourceExpression.Validate(bodybasedOn, nameof(bodybasedOn), required: false);
            SourceExpression.Validate(bodyparticipant, nameof(bodyparticipant), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Appointment";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyresourceType != null)
                {
                    body["resourceType"] = SourceExpressionConverter.ConvertToken(bodyresourceType);
                    bodypropCount++;
                }

                if (bodyid != null)
                {
                    body["id"] = SourceExpressionConverter.ConvertToken(bodyid);
                    bodypropCount++;
                }

                var textObject = new JObject();
                var textObjectpropCount = 0;
                if (bodytextstatus != null)
                {
                    textObject["status"] = SourceExpressionConverter.ConvertToken(bodytextstatus);
                    textObjectpropCount++;
                }

                if (bodytextdiv != null)
                {
                    textObject["div"] = SourceExpressionConverter.ConvertToken(bodytextdiv);
                    textObjectpropCount++;
                }

                if (textObjectpropCount > 0)
                {
                    body["text"] = textObject;
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    body["status"] = SourceExpressionConverter.ConvertToken(bodystatus);
                    bodypropCount++;
                }

                if (bodyserviceCategory != null)
                {
                    body["serviceCategory"] = SourceExpressionConverter.ConvertToken(bodyserviceCategory);
                    bodypropCount++;
                }

                if (bodyserviceType != null)
                {
                    body["serviceType"] = SourceExpressionConverter.ConvertToken(bodyserviceType);
                    bodypropCount++;
                }

                if (bodyspecialty != null)
                {
                    body["specialty"] = SourceExpressionConverter.ConvertToken(bodyspecialty);
                    bodypropCount++;
                }

                var appointmentTypeObject = new JObject();
                var appointmentTypeObjectpropCount = 0;
                if (bodyappointmentTypecoding != null)
                {
                    appointmentTypeObject["coding"] = SourceExpressionConverter.ConvertToken(bodyappointmentTypecoding);
                    appointmentTypeObjectpropCount++;
                }

                if (appointmentTypeObjectpropCount > 0)
                {
                    body["appointmentType"] = appointmentTypeObject;
                    bodypropCount++;
                }

                if (bodyreasonReference != null)
                {
                    body["reasonReference"] = SourceExpressionConverter.ConvertToken(bodyreasonReference);
                    bodypropCount++;
                }

                if (bodypriority != null)
                {
                    body["priority"] = SourceExpressionConverter.ConvertToken(bodypriority);
                    bodypropCount++;
                }

                if (bodydescription != null)
                {
                    body["description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                    bodypropCount++;
                }

                if (bodystart != null)
                {
                    body["start"] = SourceExpressionConverter.ConvertToken(bodystart);
                    bodypropCount++;
                }

                if (bodyend != null)
                {
                    body["end"] = SourceExpressionConverter.ConvertToken(bodyend);
                    bodypropCount++;
                }

                if (bodycreated != null)
                {
                    body["created"] = SourceExpressionConverter.ConvertToken(bodycreated);
                    bodypropCount++;
                }

                if (bodycomment != null)
                {
                    body["comment"] = SourceExpressionConverter.ConvertToken(bodycomment);
                    bodypropCount++;
                }

                if (bodybasedOn != null)
                {
                    body["basedOn"] = SourceExpressionConverter.ConvertToken(bodybasedOn);
                    bodypropCount++;
                }

                if (bodyparticipant != null)
                {
                    body["participant"] = SourceExpressionConverter.ConvertToken(bodyparticipant);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<POSTAppointmentResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GETAppointmentIdResponse> GETAppointmentId([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/Appointment/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GETAppointmentIdResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<DELETEAppointmentIdResponse> DELETEAppointmentId([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodyresourceType = null, [WorkflowExpression] Func<string> bodyid = null, [WorkflowExpression] Func<string> bodymetaversionId = null, [WorkflowExpression] Func<string> bodymetalastUpdated = null, [WorkflowExpression] Func<string> bodytextstatus = null, [WorkflowExpression] Func<string> bodytextdiv = null, [WorkflowExpression] Func<string> bodystatus = null, [WorkflowExpression] Func<bodyparticipantInputItem[]> bodyparticipant = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(bodyresourceType, nameof(bodyresourceType), required: false);
            SourceExpression.Validate(bodyid, nameof(bodyid), required: false);
            SourceExpression.Validate(bodymetaversionId, nameof(bodymetaversionId), required: false);
            SourceExpression.Validate(bodymetalastUpdated, nameof(bodymetalastUpdated), required: false);
            SourceExpression.Validate(bodytextstatus, nameof(bodytextstatus), required: false);
            SourceExpression.Validate(bodytextdiv, nameof(bodytextdiv), required: false);
            SourceExpression.Validate(bodystatus, nameof(bodystatus), required: false);
            SourceExpression.Validate(bodyparticipant, nameof(bodyparticipant), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/Appointment/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyresourceType != null)
                {
                    body["resourceType"] = SourceExpressionConverter.ConvertToken(bodyresourceType);
                    bodypropCount++;
                }

                if (bodyid != null)
                {
                    body["id"] = SourceExpressionConverter.ConvertToken(bodyid);
                    bodypropCount++;
                }

                var metaObject = new JObject();
                var metaObjectpropCount = 0;
                if (bodymetaversionId != null)
                {
                    metaObject["versionId"] = SourceExpressionConverter.ConvertToken(bodymetaversionId);
                    metaObjectpropCount++;
                }

                if (bodymetalastUpdated != null)
                {
                    metaObject["lastUpdated"] = SourceExpressionConverter.ConvertToken(bodymetalastUpdated);
                    metaObjectpropCount++;
                }

                if (metaObjectpropCount > 0)
                {
                    body["meta"] = metaObject;
                    bodypropCount++;
                }

                var textObject = new JObject();
                var textObjectpropCount = 0;
                if (bodytextstatus != null)
                {
                    textObject["status"] = SourceExpressionConverter.ConvertToken(bodytextstatus);
                    textObjectpropCount++;
                }

                if (bodytextdiv != null)
                {
                    textObject["div"] = SourceExpressionConverter.ConvertToken(bodytextdiv);
                    textObjectpropCount++;
                }

                if (textObjectpropCount > 0)
                {
                    body["text"] = textObject;
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    body["status"] = SourceExpressionConverter.ConvertToken(bodystatus);
                    bodypropCount++;
                }

                if (bodyparticipant != null)
                {
                    body["participant"] = SourceExpressionConverter.ConvertToken(bodyparticipant);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DELETEAppointmentIdResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<PUTAppointmentIdResponse> PUTAppointmentId([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodyresourceType = null, [WorkflowExpression] Func<string> bodyid = null, [WorkflowExpression] Func<string> bodymetaversionId = null, [WorkflowExpression] Func<string> bodymetalastUpdated = null, [WorkflowExpression] Func<string> bodytextstatus = null, [WorkflowExpression] Func<string> bodytextdiv = null, [WorkflowExpression] Func<string> bodystatus = null, [WorkflowExpression] Func<bodyparticipantInputItem[]> bodyparticipant = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(bodyresourceType, nameof(bodyresourceType), required: false);
            SourceExpression.Validate(bodyid, nameof(bodyid), required: false);
            SourceExpression.Validate(bodymetaversionId, nameof(bodymetaversionId), required: false);
            SourceExpression.Validate(bodymetalastUpdated, nameof(bodymetalastUpdated), required: false);
            SourceExpression.Validate(bodytextstatus, nameof(bodytextstatus), required: false);
            SourceExpression.Validate(bodytextdiv, nameof(bodytextdiv), required: false);
            SourceExpression.Validate(bodystatus, nameof(bodystatus), required: false);
            SourceExpression.Validate(bodyparticipant, nameof(bodyparticipant), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/Appointment/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyresourceType != null)
                {
                    body["resourceType"] = SourceExpressionConverter.ConvertToken(bodyresourceType);
                    bodypropCount++;
                }

                if (bodyid != null)
                {
                    body["id"] = SourceExpressionConverter.ConvertToken(bodyid);
                    bodypropCount++;
                }

                var metaObject = new JObject();
                var metaObjectpropCount = 0;
                if (bodymetaversionId != null)
                {
                    metaObject["versionId"] = SourceExpressionConverter.ConvertToken(bodymetaversionId);
                    metaObjectpropCount++;
                }

                if (bodymetalastUpdated != null)
                {
                    metaObject["lastUpdated"] = SourceExpressionConverter.ConvertToken(bodymetalastUpdated);
                    metaObjectpropCount++;
                }

                if (metaObjectpropCount > 0)
                {
                    body["meta"] = metaObject;
                    bodypropCount++;
                }

                var textObject = new JObject();
                var textObjectpropCount = 0;
                if (bodytextstatus != null)
                {
                    textObject["status"] = SourceExpressionConverter.ConvertToken(bodytextstatus);
                    textObjectpropCount++;
                }

                if (bodytextdiv != null)
                {
                    textObject["div"] = SourceExpressionConverter.ConvertToken(bodytextdiv);
                    textObjectpropCount++;
                }

                if (textObjectpropCount > 0)
                {
                    body["text"] = textObject;
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    body["status"] = SourceExpressionConverter.ConvertToken(bodystatus);
                    bodypropCount++;
                }

                if (bodyparticipant != null)
                {
                    body["participant"] = SourceExpressionConverter.ConvertToken(bodyparticipant);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<PUTAppointmentIdResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GETAppointmentIdVERSIONResponse> GETAppointmentIdVERSION([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> vid)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(vid, nameof(vid), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/Appointment/{0}/_history/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(vid, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GETAppointmentIdVERSIONResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GETAppointmentIdHistoryResponse> GETAppointmentIdHistory([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/Appointment/{0}/_history", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GETAppointmentIdHistoryResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GETAppointmentHistoryResponse> GETAppointmentHistory([WorkflowExpression] Func<string> patient = null)
        {
            SourceExpression.Validate(patient, nameof(patient), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Appointment/_history";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (patient != null)
                    callPayload.Queries["patient"] = SourceExpressionConverter.ConvertO(patient);
                return callPayload;
            }

            return new ApiConnectionAction<GETAppointmentHistoryResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GETAppointmentResponseResponse> GETAppointmentResponse([WorkflowExpression] Func<string> Count = null, [WorkflowExpression] Func<string> Sort = null, [WorkflowExpression] Func<string> patient = null)
        {
            SourceExpression.Validate(Count, nameof(Count), required: false);
            SourceExpression.Validate(Sort, nameof(Sort), required: false);
            SourceExpression.Validate(patient, nameof(patient), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/AppointmentResponse";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (Count != null)
                    callPayload.Queries["_count"] = SourceExpressionConverter.ConvertO(Count);
                if (Sort != null)
                    callPayload.Queries["_sort"] = SourceExpressionConverter.ConvertO(Sort);
                if (patient != null)
                    callPayload.Queries["patient"] = SourceExpressionConverter.ConvertO(patient);
                return callPayload;
            }

            return new ApiConnectionAction<GETAppointmentResponseResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<POSTAppointmentResponseResponse> POSTAppointmentResponse([WorkflowExpression] Func<string> bodyresourceType = null, [WorkflowExpression] Func<string> bodyid = null, [WorkflowExpression] Func<string> bodytextstatus = null, [WorkflowExpression] Func<string> bodytextdiv = null, [WorkflowExpression] Func<string> bodyappointmentreference = null, [WorkflowExpression] Func<string> bodyappointmentdisplay = null, [WorkflowExpression] Func<string> bodyactorreference = null, [WorkflowExpression] Func<string> bodyactordisplay = null, [WorkflowExpression] Func<string> bodyparticipantStatus = null)
        {
            SourceExpression.Validate(bodyresourceType, nameof(bodyresourceType), required: false);
            SourceExpression.Validate(bodyid, nameof(bodyid), required: false);
            SourceExpression.Validate(bodytextstatus, nameof(bodytextstatus), required: false);
            SourceExpression.Validate(bodytextdiv, nameof(bodytextdiv), required: false);
            SourceExpression.Validate(bodyappointmentreference, nameof(bodyappointmentreference), required: false);
            SourceExpression.Validate(bodyappointmentdisplay, nameof(bodyappointmentdisplay), required: false);
            SourceExpression.Validate(bodyactorreference, nameof(bodyactorreference), required: false);
            SourceExpression.Validate(bodyactordisplay, nameof(bodyactordisplay), required: false);
            SourceExpression.Validate(bodyparticipantStatus, nameof(bodyparticipantStatus), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/AppointmentResponse";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyresourceType != null)
                {
                    body["resourceType"] = SourceExpressionConverter.ConvertToken(bodyresourceType);
                    bodypropCount++;
                }

                if (bodyid != null)
                {
                    body["id"] = SourceExpressionConverter.ConvertToken(bodyid);
                    bodypropCount++;
                }

                var textObject = new JObject();
                var textObjectpropCount = 0;
                if (bodytextstatus != null)
                {
                    textObject["status"] = SourceExpressionConverter.ConvertToken(bodytextstatus);
                    textObjectpropCount++;
                }

                if (bodytextdiv != null)
                {
                    textObject["div"] = SourceExpressionConverter.ConvertToken(bodytextdiv);
                    textObjectpropCount++;
                }

                if (textObjectpropCount > 0)
                {
                    body["text"] = textObject;
                    bodypropCount++;
                }

                var appointmentObject = new JObject();
                var appointmentObjectpropCount = 0;
                if (bodyappointmentreference != null)
                {
                    appointmentObject["reference"] = SourceExpressionConverter.ConvertToken(bodyappointmentreference);
                    appointmentObjectpropCount++;
                }

                if (bodyappointmentdisplay != null)
                {
                    appointmentObject["display"] = SourceExpressionConverter.ConvertToken(bodyappointmentdisplay);
                    appointmentObjectpropCount++;
                }

                if (appointmentObjectpropCount > 0)
                {
                    body["appointment"] = appointmentObject;
                    bodypropCount++;
                }

                var actorObject = new JObject();
                var actorObjectpropCount = 0;
                if (bodyactorreference != null)
                {
                    actorObject["reference"] = SourceExpressionConverter.ConvertToken(bodyactorreference);
                    actorObjectpropCount++;
                }

                if (bodyactordisplay != null)
                {
                    actorObject["display"] = SourceExpressionConverter.ConvertToken(bodyactordisplay);
                    actorObjectpropCount++;
                }

                if (actorObjectpropCount > 0)
                {
                    body["actor"] = actorObject;
                    bodypropCount++;
                }

                if (bodyparticipantStatus != null)
                {
                    body["participantStatus"] = SourceExpressionConverter.ConvertToken(bodyparticipantStatus);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<POSTAppointmentResponseResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GETAppointmentResponseIdResponse> GETAppointmentResponseId([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/AppointmentResponse/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GETAppointmentResponseIdResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<DELETEAppointmentResponseIdResponse> DELETEAppointmentResponseId([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodyresourceType = null, [WorkflowExpression] Func<string> bodyid = null, [WorkflowExpression] Func<string> bodymetaversionId = null, [WorkflowExpression] Func<string> bodymetalastUpdated = null, [WorkflowExpression] Func<string> bodytextstatus = null, [WorkflowExpression] Func<string> bodytextdiv = null, [WorkflowExpression] Func<string> bodyappointmentreference = null, [WorkflowExpression] Func<string> bodyappointmentdisplay = null, [WorkflowExpression] Func<string> bodyactorreference = null, [WorkflowExpression] Func<string> bodyactordisplay = null, [WorkflowExpression] Func<string> bodyparticipantStatus = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(bodyresourceType, nameof(bodyresourceType), required: false);
            SourceExpression.Validate(bodyid, nameof(bodyid), required: false);
            SourceExpression.Validate(bodymetaversionId, nameof(bodymetaversionId), required: false);
            SourceExpression.Validate(bodymetalastUpdated, nameof(bodymetalastUpdated), required: false);
            SourceExpression.Validate(bodytextstatus, nameof(bodytextstatus), required: false);
            SourceExpression.Validate(bodytextdiv, nameof(bodytextdiv), required: false);
            SourceExpression.Validate(bodyappointmentreference, nameof(bodyappointmentreference), required: false);
            SourceExpression.Validate(bodyappointmentdisplay, nameof(bodyappointmentdisplay), required: false);
            SourceExpression.Validate(bodyactorreference, nameof(bodyactorreference), required: false);
            SourceExpression.Validate(bodyactordisplay, nameof(bodyactordisplay), required: false);
            SourceExpression.Validate(bodyparticipantStatus, nameof(bodyparticipantStatus), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/AppointmentResponse/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyresourceType != null)
                {
                    body["resourceType"] = SourceExpressionConverter.ConvertToken(bodyresourceType);
                    bodypropCount++;
                }

                if (bodyid != null)
                {
                    body["id"] = SourceExpressionConverter.ConvertToken(bodyid);
                    bodypropCount++;
                }

                var metaObject = new JObject();
                var metaObjectpropCount = 0;
                if (bodymetaversionId != null)
                {
                    metaObject["versionId"] = SourceExpressionConverter.ConvertToken(bodymetaversionId);
                    metaObjectpropCount++;
                }

                if (bodymetalastUpdated != null)
                {
                    metaObject["lastUpdated"] = SourceExpressionConverter.ConvertToken(bodymetalastUpdated);
                    metaObjectpropCount++;
                }

                if (metaObjectpropCount > 0)
                {
                    body["meta"] = metaObject;
                    bodypropCount++;
                }

                var textObject = new JObject();
                var textObjectpropCount = 0;
                if (bodytextstatus != null)
                {
                    textObject["status"] = SourceExpressionConverter.ConvertToken(bodytextstatus);
                    textObjectpropCount++;
                }

                if (bodytextdiv != null)
                {
                    textObject["div"] = SourceExpressionConverter.ConvertToken(bodytextdiv);
                    textObjectpropCount++;
                }

                if (textObjectpropCount > 0)
                {
                    body["text"] = textObject;
                    bodypropCount++;
                }

                var appointmentObject = new JObject();
                var appointmentObjectpropCount = 0;
                if (bodyappointmentreference != null)
                {
                    appointmentObject["reference"] = SourceExpressionConverter.ConvertToken(bodyappointmentreference);
                    appointmentObjectpropCount++;
                }

                if (bodyappointmentdisplay != null)
                {
                    appointmentObject["display"] = SourceExpressionConverter.ConvertToken(bodyappointmentdisplay);
                    appointmentObjectpropCount++;
                }

                if (appointmentObjectpropCount > 0)
                {
                    body["appointment"] = appointmentObject;
                    bodypropCount++;
                }

                var actorObject = new JObject();
                var actorObjectpropCount = 0;
                if (bodyactorreference != null)
                {
                    actorObject["reference"] = SourceExpressionConverter.ConvertToken(bodyactorreference);
                    actorObjectpropCount++;
                }

                if (bodyactordisplay != null)
                {
                    actorObject["display"] = SourceExpressionConverter.ConvertToken(bodyactordisplay);
                    actorObjectpropCount++;
                }

                if (actorObjectpropCount > 0)
                {
                    body["actor"] = actorObject;
                    bodypropCount++;
                }

                if (bodyparticipantStatus != null)
                {
                    body["participantStatus"] = SourceExpressionConverter.ConvertToken(bodyparticipantStatus);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DELETEAppointmentResponseIdResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<PUTAppointmentResponseIdResponse> PUTAppointmentResponseId([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodyresourceType = null, [WorkflowExpression] Func<string> bodyid = null, [WorkflowExpression] Func<string> bodymetaversionId = null, [WorkflowExpression] Func<string> bodymetalastUpdated = null, [WorkflowExpression] Func<string> bodytextstatus = null, [WorkflowExpression] Func<string> bodytextdiv = null, [WorkflowExpression] Func<string> bodyappointmentreference = null, [WorkflowExpression] Func<string> bodyappointmentdisplay = null, [WorkflowExpression] Func<string> bodyactorreference = null, [WorkflowExpression] Func<string> bodyactordisplay = null, [WorkflowExpression] Func<string> bodyparticipantStatus = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(bodyresourceType, nameof(bodyresourceType), required: false);
            SourceExpression.Validate(bodyid, nameof(bodyid), required: false);
            SourceExpression.Validate(bodymetaversionId, nameof(bodymetaversionId), required: false);
            SourceExpression.Validate(bodymetalastUpdated, nameof(bodymetalastUpdated), required: false);
            SourceExpression.Validate(bodytextstatus, nameof(bodytextstatus), required: false);
            SourceExpression.Validate(bodytextdiv, nameof(bodytextdiv), required: false);
            SourceExpression.Validate(bodyappointmentreference, nameof(bodyappointmentreference), required: false);
            SourceExpression.Validate(bodyappointmentdisplay, nameof(bodyappointmentdisplay), required: false);
            SourceExpression.Validate(bodyactorreference, nameof(bodyactorreference), required: false);
            SourceExpression.Validate(bodyactordisplay, nameof(bodyactordisplay), required: false);
            SourceExpression.Validate(bodyparticipantStatus, nameof(bodyparticipantStatus), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/AppointmentResponse/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyresourceType != null)
                {
                    body["resourceType"] = SourceExpressionConverter.ConvertToken(bodyresourceType);
                    bodypropCount++;
                }

                if (bodyid != null)
                {
                    body["id"] = SourceExpressionConverter.ConvertToken(bodyid);
                    bodypropCount++;
                }

                var metaObject = new JObject();
                var metaObjectpropCount = 0;
                if (bodymetaversionId != null)
                {
                    metaObject["versionId"] = SourceExpressionConverter.ConvertToken(bodymetaversionId);
                    metaObjectpropCount++;
                }

                if (bodymetalastUpdated != null)
                {
                    metaObject["lastUpdated"] = SourceExpressionConverter.ConvertToken(bodymetalastUpdated);
                    metaObjectpropCount++;
                }

                if (metaObjectpropCount > 0)
                {
                    body["meta"] = metaObject;
                    bodypropCount++;
                }

                var textObject = new JObject();
                var textObjectpropCount = 0;
                if (bodytextstatus != null)
                {
                    textObject["status"] = SourceExpressionConverter.ConvertToken(bodytextstatus);
                    textObjectpropCount++;
                }

                if (bodytextdiv != null)
                {
                    textObject["div"] = SourceExpressionConverter.ConvertToken(bodytextdiv);
                    textObjectpropCount++;
                }

                if (textObjectpropCount > 0)
                {
                    body["text"] = textObject;
                    bodypropCount++;
                }

                var appointmentObject = new JObject();
                var appointmentObjectpropCount = 0;
                if (bodyappointmentreference != null)
                {
                    appointmentObject["reference"] = SourceExpressionConverter.ConvertToken(bodyappointmentreference);
                    appointmentObjectpropCount++;
                }

                if (bodyappointmentdisplay != null)
                {
                    appointmentObject["display"] = SourceExpressionConverter.ConvertToken(bodyappointmentdisplay);
                    appointmentObjectpropCount++;
                }

                if (appointmentObjectpropCount > 0)
                {
                    body["appointment"] = appointmentObject;
                    bodypropCount++;
                }

                var actorObject = new JObject();
                var actorObjectpropCount = 0;
                if (bodyactorreference != null)
                {
                    actorObject["reference"] = SourceExpressionConverter.ConvertToken(bodyactorreference);
                    actorObjectpropCount++;
                }

                if (bodyactordisplay != null)
                {
                    actorObject["display"] = SourceExpressionConverter.ConvertToken(bodyactordisplay);
                    actorObjectpropCount++;
                }

                if (actorObjectpropCount > 0)
                {
                    body["actor"] = actorObject;
                    bodypropCount++;
                }

                if (bodyparticipantStatus != null)
                {
                    body["participantStatus"] = SourceExpressionConverter.ConvertToken(bodyparticipantStatus);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<PUTAppointmentResponseIdResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GETAppointmentResponseIdVersionResponse> GETAppointmentResponseIdVersion([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> vid)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(vid, nameof(vid), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/AppointmentResponse/{0}/_history/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(vid, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GETAppointmentResponseIdVersionResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GETAppointmentResponseIdHistoryResponse> GETAppointmentResponseIdHistory([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/AppointmentResponse/{0}/_history", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GETAppointmentResponseIdHistoryResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GETAppointmentResponseHistoryResponse> GETAppointmentResponseHistory()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/AppointmentResponse/_history";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GETAppointmentResponseHistoryResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GETDeviceResponse> GETDevice([WorkflowExpression] Func<string> Count = null, [WorkflowExpression] Func<string> Sort = null, [WorkflowExpression] Func<string> patient = null)
        {
            SourceExpression.Validate(Count, nameof(Count), required: false);
            SourceExpression.Validate(Sort, nameof(Sort), required: false);
            SourceExpression.Validate(patient, nameof(patient), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Device";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (Count != null)
                    callPayload.Queries["_count"] = SourceExpressionConverter.ConvertO(Count);
                if (Sort != null)
                    callPayload.Queries["_sort"] = SourceExpressionConverter.ConvertO(Sort);
                if (patient != null)
                    callPayload.Queries["patient"] = SourceExpressionConverter.ConvertO(patient);
                return callPayload;
            }

            return new ApiConnectionAction<GETDeviceResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<POSTDeviceResponse> POSTDevice([WorkflowExpression] Func<string> bodyresourceType = null, [WorkflowExpression] Func<string> bodyid = null, [WorkflowExpression] Func<string> bodymetaversionId = null, [WorkflowExpression] Func<string> bodymetalastUpdated = null, [WorkflowExpression] Func<bodyudiCarrierInputItem[]> bodyudiCarrier = null, [WorkflowExpression] Func<string> bodystatus = null, [WorkflowExpression] Func<string> bodydistinctIdentifier = null, [WorkflowExpression] Func<string> bodymanufactureDate = null, [WorkflowExpression] Func<string> bodyexpirationDate = null, [WorkflowExpression] Func<string> bodylotNumber = null, [WorkflowExpression] Func<string> bodyserialNumber = null, [WorkflowExpression] Func<bodydeviceNameInputItem[]> bodydeviceName = null, [WorkflowExpression] Func<bodytypecodingInputItem[]> bodytypecoding = null, [WorkflowExpression] Func<string> bodytypetext = null, [WorkflowExpression] Func<string> bodypatientreference = null)
        {
            SourceExpression.Validate(bodyresourceType, nameof(bodyresourceType), required: false);
            SourceExpression.Validate(bodyid, nameof(bodyid), required: false);
            SourceExpression.Validate(bodymetaversionId, nameof(bodymetaversionId), required: false);
            SourceExpression.Validate(bodymetalastUpdated, nameof(bodymetalastUpdated), required: false);
            SourceExpression.Validate(bodyudiCarrier, nameof(bodyudiCarrier), required: false);
            SourceExpression.Validate(bodystatus, nameof(bodystatus), required: false);
            SourceExpression.Validate(bodydistinctIdentifier, nameof(bodydistinctIdentifier), required: false);
            SourceExpression.Validate(bodymanufactureDate, nameof(bodymanufactureDate), required: false);
            SourceExpression.Validate(bodyexpirationDate, nameof(bodyexpirationDate), required: false);
            SourceExpression.Validate(bodylotNumber, nameof(bodylotNumber), required: false);
            SourceExpression.Validate(bodyserialNumber, nameof(bodyserialNumber), required: false);
            SourceExpression.Validate(bodydeviceName, nameof(bodydeviceName), required: false);
            SourceExpression.Validate(bodytypecoding, nameof(bodytypecoding), required: false);
            SourceExpression.Validate(bodytypetext, nameof(bodytypetext), required: false);
            SourceExpression.Validate(bodypatientreference, nameof(bodypatientreference), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Device";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyresourceType != null)
                {
                    body["resourceType"] = SourceExpressionConverter.ConvertToken(bodyresourceType);
                    bodypropCount++;
                }

                if (bodyid != null)
                {
                    body["id"] = SourceExpressionConverter.ConvertToken(bodyid);
                    bodypropCount++;
                }

                var metaObject = new JObject();
                var metaObjectpropCount = 0;
                if (bodymetaversionId != null)
                {
                    metaObject["versionId"] = SourceExpressionConverter.ConvertToken(bodymetaversionId);
                    metaObjectpropCount++;
                }

                if (bodymetalastUpdated != null)
                {
                    metaObject["lastUpdated"] = SourceExpressionConverter.ConvertToken(bodymetalastUpdated);
                    metaObjectpropCount++;
                }

                if (metaObjectpropCount > 0)
                {
                    body["meta"] = metaObject;
                    bodypropCount++;
                }

                if (bodyudiCarrier != null)
                {
                    body["udiCarrier"] = SourceExpressionConverter.ConvertToken(bodyudiCarrier);
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    body["status"] = SourceExpressionConverter.ConvertToken(bodystatus);
                    bodypropCount++;
                }

                if (bodydistinctIdentifier != null)
                {
                    body["distinctIdentifier"] = SourceExpressionConverter.ConvertToken(bodydistinctIdentifier);
                    bodypropCount++;
                }

                if (bodymanufactureDate != null)
                {
                    body["manufactureDate"] = SourceExpressionConverter.ConvertToken(bodymanufactureDate);
                    bodypropCount++;
                }

                if (bodyexpirationDate != null)
                {
                    body["expirationDate"] = SourceExpressionConverter.ConvertToken(bodyexpirationDate);
                    bodypropCount++;
                }

                if (bodylotNumber != null)
                {
                    body["lotNumber"] = SourceExpressionConverter.ConvertToken(bodylotNumber);
                    bodypropCount++;
                }

                if (bodyserialNumber != null)
                {
                    body["serialNumber"] = SourceExpressionConverter.ConvertToken(bodyserialNumber);
                    bodypropCount++;
                }

                if (bodydeviceName != null)
                {
                    body["deviceName"] = SourceExpressionConverter.ConvertToken(bodydeviceName);
                    bodypropCount++;
                }

                var typeObject = new JObject();
                var typeObjectpropCount = 0;
                if (bodytypecoding != null)
                {
                    typeObject["coding"] = SourceExpressionConverter.ConvertToken(bodytypecoding);
                    typeObjectpropCount++;
                }

                if (bodytypetext != null)
                {
                    typeObject["text"] = SourceExpressionConverter.ConvertToken(bodytypetext);
                    typeObjectpropCount++;
                }

                if (typeObjectpropCount > 0)
                {
                    body["type"] = typeObject;
                    bodypropCount++;
                }

                var patientObject = new JObject();
                var patientObjectpropCount = 0;
                if (bodypatientreference != null)
                {
                    patientObject["reference"] = SourceExpressionConverter.ConvertToken(bodypatientreference);
                    patientObjectpropCount++;
                }

                if (patientObjectpropCount > 0)
                {
                    body["patient"] = patientObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<POSTDeviceResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GETDeviceIdResponse> GETDeviceId([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/Device/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GETDeviceIdResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<DELETEDeviceIdResponse> DELETEDeviceId([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodyresourceType = null, [WorkflowExpression] Func<string> bodyid = null, [WorkflowExpression] Func<string> bodymetaversionId = null, [WorkflowExpression] Func<string> bodymetalastUpdated = null, [WorkflowExpression] Func<string> bodytextstatus = null, [WorkflowExpression] Func<string> bodytextdiv = null, [WorkflowExpression] Func<bodyidentifierInputItem[]> bodyidentifier = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(bodyresourceType, nameof(bodyresourceType), required: false);
            SourceExpression.Validate(bodyid, nameof(bodyid), required: false);
            SourceExpression.Validate(bodymetaversionId, nameof(bodymetaversionId), required: false);
            SourceExpression.Validate(bodymetalastUpdated, nameof(bodymetalastUpdated), required: false);
            SourceExpression.Validate(bodytextstatus, nameof(bodytextstatus), required: false);
            SourceExpression.Validate(bodytextdiv, nameof(bodytextdiv), required: false);
            SourceExpression.Validate(bodyidentifier, nameof(bodyidentifier), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/Device/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyresourceType != null)
                {
                    body["resourceType"] = SourceExpressionConverter.ConvertToken(bodyresourceType);
                    bodypropCount++;
                }

                if (bodyid != null)
                {
                    body["id"] = SourceExpressionConverter.ConvertToken(bodyid);
                    bodypropCount++;
                }

                var metaObject = new JObject();
                var metaObjectpropCount = 0;
                if (bodymetaversionId != null)
                {
                    metaObject["versionId"] = SourceExpressionConverter.ConvertToken(bodymetaversionId);
                    metaObjectpropCount++;
                }

                if (bodymetalastUpdated != null)
                {
                    metaObject["lastUpdated"] = SourceExpressionConverter.ConvertToken(bodymetalastUpdated);
                    metaObjectpropCount++;
                }

                if (metaObjectpropCount > 0)
                {
                    body["meta"] = metaObject;
                    bodypropCount++;
                }

                var textObject = new JObject();
                var textObjectpropCount = 0;
                if (bodytextstatus != null)
                {
                    textObject["status"] = SourceExpressionConverter.ConvertToken(bodytextstatus);
                    textObjectpropCount++;
                }

                if (bodytextdiv != null)
                {
                    textObject["div"] = SourceExpressionConverter.ConvertToken(bodytextdiv);
                    textObjectpropCount++;
                }

                if (textObjectpropCount > 0)
                {
                    body["text"] = textObject;
                    bodypropCount++;
                }

                if (bodyidentifier != null)
                {
                    body["identifier"] = SourceExpressionConverter.ConvertToken(bodyidentifier);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DELETEDeviceIdResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<PUTDeviceIdResponse> PUTDeviceId([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodyresourceType = null, [WorkflowExpression] Func<string> bodyid = null, [WorkflowExpression] Func<string> bodymetaversionId = null, [WorkflowExpression] Func<string> bodymetalastUpdated = null, [WorkflowExpression] Func<string> bodytextstatus = null, [WorkflowExpression] Func<string> bodytextdiv = null, [WorkflowExpression] Func<bodyidentifierInputItem[]> bodyidentifier = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(bodyresourceType, nameof(bodyresourceType), required: false);
            SourceExpression.Validate(bodyid, nameof(bodyid), required: false);
            SourceExpression.Validate(bodymetaversionId, nameof(bodymetaversionId), required: false);
            SourceExpression.Validate(bodymetalastUpdated, nameof(bodymetalastUpdated), required: false);
            SourceExpression.Validate(bodytextstatus, nameof(bodytextstatus), required: false);
            SourceExpression.Validate(bodytextdiv, nameof(bodytextdiv), required: false);
            SourceExpression.Validate(bodyidentifier, nameof(bodyidentifier), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/Device/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyresourceType != null)
                {
                    body["resourceType"] = SourceExpressionConverter.ConvertToken(bodyresourceType);
                    bodypropCount++;
                }

                if (bodyid != null)
                {
                    body["id"] = SourceExpressionConverter.ConvertToken(bodyid);
                    bodypropCount++;
                }

                var metaObject = new JObject();
                var metaObjectpropCount = 0;
                if (bodymetaversionId != null)
                {
                    metaObject["versionId"] = SourceExpressionConverter.ConvertToken(bodymetaversionId);
                    metaObjectpropCount++;
                }

                if (bodymetalastUpdated != null)
                {
                    metaObject["lastUpdated"] = SourceExpressionConverter.ConvertToken(bodymetalastUpdated);
                    metaObjectpropCount++;
                }

                if (metaObjectpropCount > 0)
                {
                    body["meta"] = metaObject;
                    bodypropCount++;
                }

                var textObject = new JObject();
                var textObjectpropCount = 0;
                if (bodytextstatus != null)
                {
                    textObject["status"] = SourceExpressionConverter.ConvertToken(bodytextstatus);
                    textObjectpropCount++;
                }

                if (bodytextdiv != null)
                {
                    textObject["div"] = SourceExpressionConverter.ConvertToken(bodytextdiv);
                    textObjectpropCount++;
                }

                if (textObjectpropCount > 0)
                {
                    body["text"] = textObject;
                    bodypropCount++;
                }

                if (bodyidentifier != null)
                {
                    body["identifier"] = SourceExpressionConverter.ConvertToken(bodyidentifier);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<PUTDeviceIdResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GETDeviceIdVERSIONResponse> GETDeviceIdVERSION([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> vid)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(vid, nameof(vid), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/Device/{0}/_history/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(vid, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GETDeviceIdVERSIONResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GETDeviceIdHISTORYResponse> GETDeviceIdHISTORY([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/Device/{0}/_history", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GETDeviceIdHISTORYResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GETDeviceHISTORYResponse> GETDeviceHISTORY()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Device/_history";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GETDeviceHISTORYResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GETEncounterResponse> GETEncounter([WorkflowExpression] Func<string> Count = null, [WorkflowExpression] Func<string> Sort = null, [WorkflowExpression] Func<string> patient = null)
        {
            SourceExpression.Validate(Count, nameof(Count), required: false);
            SourceExpression.Validate(Sort, nameof(Sort), required: false);
            SourceExpression.Validate(patient, nameof(patient), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Encounter";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (Count != null)
                    callPayload.Queries["_count"] = SourceExpressionConverter.ConvertO(Count);
                if (Sort != null)
                    callPayload.Queries["_sort"] = SourceExpressionConverter.ConvertO(Sort);
                if (patient != null)
                    callPayload.Queries["patient"] = SourceExpressionConverter.ConvertO(patient);
                return callPayload;
            }

            return new ApiConnectionAction<GETEncounterResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<POSTEncounterResponse> POSTEncounter([WorkflowExpression] Func<string> bodyresourceType = null, [WorkflowExpression] Func<string> bodyid = null, [WorkflowExpression] Func<string> bodymetaversionId = null, [WorkflowExpression] Func<string> bodymetalastUpdated = null, [WorkflowExpression] Func<string> bodystatus = null, [WorkflowExpression] Func<string> bodyClasssystem = null, [WorkflowExpression] Func<string> bodyClasscode = null, [WorkflowExpression] Func<bodytypeInputItem[]> bodytype = null, [WorkflowExpression] Func<string> bodysubjectreference = null, [WorkflowExpression] Func<string> bodysubjectdisplay = null, [WorkflowExpression] Func<bodyparticipantInputItem2[]> bodyparticipant = null, [WorkflowExpression] Func<string> bodyperiodstart = null, [WorkflowExpression] Func<string> bodyperiodend = null, [WorkflowExpression] Func<string> bodyserviceProviderreference = null, [WorkflowExpression] Func<string> bodyserviceProviderdisplay = null)
        {
            SourceExpression.Validate(bodyresourceType, nameof(bodyresourceType), required: false);
            SourceExpression.Validate(bodyid, nameof(bodyid), required: false);
            SourceExpression.Validate(bodymetaversionId, nameof(bodymetaversionId), required: false);
            SourceExpression.Validate(bodymetalastUpdated, nameof(bodymetalastUpdated), required: false);
            SourceExpression.Validate(bodystatus, nameof(bodystatus), required: false);
            SourceExpression.Validate(bodyClasssystem, nameof(bodyClasssystem), required: false);
            SourceExpression.Validate(bodyClasscode, nameof(bodyClasscode), required: false);
            SourceExpression.Validate(bodytype, nameof(bodytype), required: false);
            SourceExpression.Validate(bodysubjectreference, nameof(bodysubjectreference), required: false);
            SourceExpression.Validate(bodysubjectdisplay, nameof(bodysubjectdisplay), required: false);
            SourceExpression.Validate(bodyparticipant, nameof(bodyparticipant), required: false);
            SourceExpression.Validate(bodyperiodstart, nameof(bodyperiodstart), required: false);
            SourceExpression.Validate(bodyperiodend, nameof(bodyperiodend), required: false);
            SourceExpression.Validate(bodyserviceProviderreference, nameof(bodyserviceProviderreference), required: false);
            SourceExpression.Validate(bodyserviceProviderdisplay, nameof(bodyserviceProviderdisplay), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Encounter";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyresourceType != null)
                {
                    body["resourceType"] = SourceExpressionConverter.ConvertToken(bodyresourceType);
                    bodypropCount++;
                }

                if (bodyid != null)
                {
                    body["id"] = SourceExpressionConverter.ConvertToken(bodyid);
                    bodypropCount++;
                }

                var metaObject = new JObject();
                var metaObjectpropCount = 0;
                if (bodymetaversionId != null)
                {
                    metaObject["versionId"] = SourceExpressionConverter.ConvertToken(bodymetaversionId);
                    metaObjectpropCount++;
                }

                if (bodymetalastUpdated != null)
                {
                    metaObject["lastUpdated"] = SourceExpressionConverter.ConvertToken(bodymetalastUpdated);
                    metaObjectpropCount++;
                }

                if (metaObjectpropCount > 0)
                {
                    body["meta"] = metaObject;
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    body["status"] = SourceExpressionConverter.ConvertToken(bodystatus);
                    bodypropCount++;
                }

                var @classObject = new JObject();
                var @classObjectpropCount = 0;
                if (bodyClasssystem != null)
                {
                    @classObject["system"] = SourceExpressionConverter.ConvertToken(bodyClasssystem);
                    @classObjectpropCount++;
                }

                if (bodyClasscode != null)
                {
                    @classObject["code"] = SourceExpressionConverter.ConvertToken(bodyClasscode);
                    @classObjectpropCount++;
                }

                if (@classObjectpropCount > 0)
                {
                    body["class"] = @classObject;
                    bodypropCount++;
                }

                if (bodytype != null)
                {
                    body["type"] = SourceExpressionConverter.ConvertToken(bodytype);
                    bodypropCount++;
                }

                var subjectObject = new JObject();
                var subjectObjectpropCount = 0;
                if (bodysubjectreference != null)
                {
                    subjectObject["reference"] = SourceExpressionConverter.ConvertToken(bodysubjectreference);
                    subjectObjectpropCount++;
                }

                if (bodysubjectdisplay != null)
                {
                    subjectObject["display"] = SourceExpressionConverter.ConvertToken(bodysubjectdisplay);
                    subjectObjectpropCount++;
                }

                if (subjectObjectpropCount > 0)
                {
                    body["subject"] = subjectObject;
                    bodypropCount++;
                }

                if (bodyparticipant != null)
                {
                    body["participant"] = SourceExpressionConverter.ConvertToken(bodyparticipant);
                    bodypropCount++;
                }

                var periodObject = new JObject();
                var periodObjectpropCount = 0;
                if (bodyperiodstart != null)
                {
                    periodObject["start"] = SourceExpressionConverter.ConvertToken(bodyperiodstart);
                    periodObjectpropCount++;
                }

                if (bodyperiodend != null)
                {
                    periodObject["end"] = SourceExpressionConverter.ConvertToken(bodyperiodend);
                    periodObjectpropCount++;
                }

                if (periodObjectpropCount > 0)
                {
                    body["period"] = periodObject;
                    bodypropCount++;
                }

                var serviceProviderObject = new JObject();
                var serviceProviderObjectpropCount = 0;
                if (bodyserviceProviderreference != null)
                {
                    serviceProviderObject["reference"] = SourceExpressionConverter.ConvertToken(bodyserviceProviderreference);
                    serviceProviderObjectpropCount++;
                }

                if (bodyserviceProviderdisplay != null)
                {
                    serviceProviderObject["display"] = SourceExpressionConverter.ConvertToken(bodyserviceProviderdisplay);
                    serviceProviderObjectpropCount++;
                }

                if (serviceProviderObjectpropCount > 0)
                {
                    body["serviceProvider"] = serviceProviderObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<POSTEncounterResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GETEncounterIdResponse> GETEncounterId([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/Encounter/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GETEncounterIdResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<DELETEEncounterIdResponse> DELETEEncounterId([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodyresourceType = null, [WorkflowExpression] Func<string> bodyid = null, [WorkflowExpression] Func<string> bodymetaversionId = null, [WorkflowExpression] Func<string> bodymetalastUpdated = null, [WorkflowExpression] Func<string> bodystatus = null, [WorkflowExpression] Func<string> bodyClasssystem = null, [WorkflowExpression] Func<string> bodyClasscode = null, [WorkflowExpression] Func<bodytypeInputItem[]> bodytype = null, [WorkflowExpression] Func<string> bodysubjectreference = null, [WorkflowExpression] Func<string> bodysubjectdisplay = null, [WorkflowExpression] Func<bodyparticipantInputItem2[]> bodyparticipant = null, [WorkflowExpression] Func<string> bodyperiodstart = null, [WorkflowExpression] Func<string> bodyperiodend = null, [WorkflowExpression] Func<string> bodyserviceProviderreference = null, [WorkflowExpression] Func<string> bodyserviceProviderdisplay = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(bodyresourceType, nameof(bodyresourceType), required: false);
            SourceExpression.Validate(bodyid, nameof(bodyid), required: false);
            SourceExpression.Validate(bodymetaversionId, nameof(bodymetaversionId), required: false);
            SourceExpression.Validate(bodymetalastUpdated, nameof(bodymetalastUpdated), required: false);
            SourceExpression.Validate(bodystatus, nameof(bodystatus), required: false);
            SourceExpression.Validate(bodyClasssystem, nameof(bodyClasssystem), required: false);
            SourceExpression.Validate(bodyClasscode, nameof(bodyClasscode), required: false);
            SourceExpression.Validate(bodytype, nameof(bodytype), required: false);
            SourceExpression.Validate(bodysubjectreference, nameof(bodysubjectreference), required: false);
            SourceExpression.Validate(bodysubjectdisplay, nameof(bodysubjectdisplay), required: false);
            SourceExpression.Validate(bodyparticipant, nameof(bodyparticipant), required: false);
            SourceExpression.Validate(bodyperiodstart, nameof(bodyperiodstart), required: false);
            SourceExpression.Validate(bodyperiodend, nameof(bodyperiodend), required: false);
            SourceExpression.Validate(bodyserviceProviderreference, nameof(bodyserviceProviderreference), required: false);
            SourceExpression.Validate(bodyserviceProviderdisplay, nameof(bodyserviceProviderdisplay), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/Encounter/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyresourceType != null)
                {
                    body["resourceType"] = SourceExpressionConverter.ConvertToken(bodyresourceType);
                    bodypropCount++;
                }

                if (bodyid != null)
                {
                    body["id"] = SourceExpressionConverter.ConvertToken(bodyid);
                    bodypropCount++;
                }

                var metaObject = new JObject();
                var metaObjectpropCount = 0;
                if (bodymetaversionId != null)
                {
                    metaObject["versionId"] = SourceExpressionConverter.ConvertToken(bodymetaversionId);
                    metaObjectpropCount++;
                }

                if (bodymetalastUpdated != null)
                {
                    metaObject["lastUpdated"] = SourceExpressionConverter.ConvertToken(bodymetalastUpdated);
                    metaObjectpropCount++;
                }

                if (metaObjectpropCount > 0)
                {
                    body["meta"] = metaObject;
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    body["status"] = SourceExpressionConverter.ConvertToken(bodystatus);
                    bodypropCount++;
                }

                var @classObject = new JObject();
                var @classObjectpropCount = 0;
                if (bodyClasssystem != null)
                {
                    @classObject["system"] = SourceExpressionConverter.ConvertToken(bodyClasssystem);
                    @classObjectpropCount++;
                }

                if (bodyClasscode != null)
                {
                    @classObject["code"] = SourceExpressionConverter.ConvertToken(bodyClasscode);
                    @classObjectpropCount++;
                }

                if (@classObjectpropCount > 0)
                {
                    body["class"] = @classObject;
                    bodypropCount++;
                }

                if (bodytype != null)
                {
                    body["type"] = SourceExpressionConverter.ConvertToken(bodytype);
                    bodypropCount++;
                }

                var subjectObject = new JObject();
                var subjectObjectpropCount = 0;
                if (bodysubjectreference != null)
                {
                    subjectObject["reference"] = SourceExpressionConverter.ConvertToken(bodysubjectreference);
                    subjectObjectpropCount++;
                }

                if (bodysubjectdisplay != null)
                {
                    subjectObject["display"] = SourceExpressionConverter.ConvertToken(bodysubjectdisplay);
                    subjectObjectpropCount++;
                }

                if (subjectObjectpropCount > 0)
                {
                    body["subject"] = subjectObject;
                    bodypropCount++;
                }

                if (bodyparticipant != null)
                {
                    body["participant"] = SourceExpressionConverter.ConvertToken(bodyparticipant);
                    bodypropCount++;
                }

                var periodObject = new JObject();
                var periodObjectpropCount = 0;
                if (bodyperiodstart != null)
                {
                    periodObject["start"] = SourceExpressionConverter.ConvertToken(bodyperiodstart);
                    periodObjectpropCount++;
                }

                if (bodyperiodend != null)
                {
                    periodObject["end"] = SourceExpressionConverter.ConvertToken(bodyperiodend);
                    periodObjectpropCount++;
                }

                if (periodObjectpropCount > 0)
                {
                    body["period"] = periodObject;
                    bodypropCount++;
                }

                var serviceProviderObject = new JObject();
                var serviceProviderObjectpropCount = 0;
                if (bodyserviceProviderreference != null)
                {
                    serviceProviderObject["reference"] = SourceExpressionConverter.ConvertToken(bodyserviceProviderreference);
                    serviceProviderObjectpropCount++;
                }

                if (bodyserviceProviderdisplay != null)
                {
                    serviceProviderObject["display"] = SourceExpressionConverter.ConvertToken(bodyserviceProviderdisplay);
                    serviceProviderObjectpropCount++;
                }

                if (serviceProviderObjectpropCount > 0)
                {
                    body["serviceProvider"] = serviceProviderObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DELETEEncounterIdResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<PUTEncounterIdResponse> PUTEncounterId([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodyresourceType = null, [WorkflowExpression] Func<string> bodyid = null, [WorkflowExpression] Func<string> bodymetaversionId = null, [WorkflowExpression] Func<string> bodymetalastUpdated = null, [WorkflowExpression] Func<string> bodystatus = null, [WorkflowExpression] Func<string> bodyClasssystem = null, [WorkflowExpression] Func<string> bodyClasscode = null, [WorkflowExpression] Func<bodytypeInputItem[]> bodytype = null, [WorkflowExpression] Func<string> bodysubjectreference = null, [WorkflowExpression] Func<string> bodysubjectdisplay = null, [WorkflowExpression] Func<bodyparticipantInputItem2[]> bodyparticipant = null, [WorkflowExpression] Func<string> bodyperiodstart = null, [WorkflowExpression] Func<string> bodyperiodend = null, [WorkflowExpression] Func<string> bodyserviceProviderreference = null, [WorkflowExpression] Func<string> bodyserviceProviderdisplay = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(bodyresourceType, nameof(bodyresourceType), required: false);
            SourceExpression.Validate(bodyid, nameof(bodyid), required: false);
            SourceExpression.Validate(bodymetaversionId, nameof(bodymetaversionId), required: false);
            SourceExpression.Validate(bodymetalastUpdated, nameof(bodymetalastUpdated), required: false);
            SourceExpression.Validate(bodystatus, nameof(bodystatus), required: false);
            SourceExpression.Validate(bodyClasssystem, nameof(bodyClasssystem), required: false);
            SourceExpression.Validate(bodyClasscode, nameof(bodyClasscode), required: false);
            SourceExpression.Validate(bodytype, nameof(bodytype), required: false);
            SourceExpression.Validate(bodysubjectreference, nameof(bodysubjectreference), required: false);
            SourceExpression.Validate(bodysubjectdisplay, nameof(bodysubjectdisplay), required: false);
            SourceExpression.Validate(bodyparticipant, nameof(bodyparticipant), required: false);
            SourceExpression.Validate(bodyperiodstart, nameof(bodyperiodstart), required: false);
            SourceExpression.Validate(bodyperiodend, nameof(bodyperiodend), required: false);
            SourceExpression.Validate(bodyserviceProviderreference, nameof(bodyserviceProviderreference), required: false);
            SourceExpression.Validate(bodyserviceProviderdisplay, nameof(bodyserviceProviderdisplay), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/Encounter/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyresourceType != null)
                {
                    body["resourceType"] = SourceExpressionConverter.ConvertToken(bodyresourceType);
                    bodypropCount++;
                }

                if (bodyid != null)
                {
                    body["id"] = SourceExpressionConverter.ConvertToken(bodyid);
                    bodypropCount++;
                }

                var metaObject = new JObject();
                var metaObjectpropCount = 0;
                if (bodymetaversionId != null)
                {
                    metaObject["versionId"] = SourceExpressionConverter.ConvertToken(bodymetaversionId);
                    metaObjectpropCount++;
                }

                if (bodymetalastUpdated != null)
                {
                    metaObject["lastUpdated"] = SourceExpressionConverter.ConvertToken(bodymetalastUpdated);
                    metaObjectpropCount++;
                }

                if (metaObjectpropCount > 0)
                {
                    body["meta"] = metaObject;
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    body["status"] = SourceExpressionConverter.ConvertToken(bodystatus);
                    bodypropCount++;
                }

                var @classObject = new JObject();
                var @classObjectpropCount = 0;
                if (bodyClasssystem != null)
                {
                    @classObject["system"] = SourceExpressionConverter.ConvertToken(bodyClasssystem);
                    @classObjectpropCount++;
                }

                if (bodyClasscode != null)
                {
                    @classObject["code"] = SourceExpressionConverter.ConvertToken(bodyClasscode);
                    @classObjectpropCount++;
                }

                if (@classObjectpropCount > 0)
                {
                    body["class"] = @classObject;
                    bodypropCount++;
                }

                if (bodytype != null)
                {
                    body["type"] = SourceExpressionConverter.ConvertToken(bodytype);
                    bodypropCount++;
                }

                var subjectObject = new JObject();
                var subjectObjectpropCount = 0;
                if (bodysubjectreference != null)
                {
                    subjectObject["reference"] = SourceExpressionConverter.ConvertToken(bodysubjectreference);
                    subjectObjectpropCount++;
                }

                if (bodysubjectdisplay != null)
                {
                    subjectObject["display"] = SourceExpressionConverter.ConvertToken(bodysubjectdisplay);
                    subjectObjectpropCount++;
                }

                if (subjectObjectpropCount > 0)
                {
                    body["subject"] = subjectObject;
                    bodypropCount++;
                }

                if (bodyparticipant != null)
                {
                    body["participant"] = SourceExpressionConverter.ConvertToken(bodyparticipant);
                    bodypropCount++;
                }

                var periodObject = new JObject();
                var periodObjectpropCount = 0;
                if (bodyperiodstart != null)
                {
                    periodObject["start"] = SourceExpressionConverter.ConvertToken(bodyperiodstart);
                    periodObjectpropCount++;
                }

                if (bodyperiodend != null)
                {
                    periodObject["end"] = SourceExpressionConverter.ConvertToken(bodyperiodend);
                    periodObjectpropCount++;
                }

                if (periodObjectpropCount > 0)
                {
                    body["period"] = periodObject;
                    bodypropCount++;
                }

                var serviceProviderObject = new JObject();
                var serviceProviderObjectpropCount = 0;
                if (bodyserviceProviderreference != null)
                {
                    serviceProviderObject["reference"] = SourceExpressionConverter.ConvertToken(bodyserviceProviderreference);
                    serviceProviderObjectpropCount++;
                }

                if (bodyserviceProviderdisplay != null)
                {
                    serviceProviderObject["display"] = SourceExpressionConverter.ConvertToken(bodyserviceProviderdisplay);
                    serviceProviderObjectpropCount++;
                }

                if (serviceProviderObjectpropCount > 0)
                {
                    body["serviceProvider"] = serviceProviderObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<PUTEncounterIdResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GETEncounterIdVersionResponse> GETEncounterIdVersion([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> vid)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(vid, nameof(vid), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/Encounter/{0}/_history/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(vid, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GETEncounterIdVersionResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GETEncounterIdHISTORYResponse> GETEncounterIdHISTORY([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/Encounter/{0}/_history", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GETEncounterIdHISTORYResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GETEncounterHISTORYResponse> GETEncounterHISTORY()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Encounter/_history";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GETEncounterHISTORYResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GETFlagResponse> GETFlag([WorkflowExpression] Func<string> Count = null, [WorkflowExpression] Func<string> Sort = null, [WorkflowExpression] Func<string> patient = null)
        {
            SourceExpression.Validate(Count, nameof(Count), required: false);
            SourceExpression.Validate(Sort, nameof(Sort), required: false);
            SourceExpression.Validate(patient, nameof(patient), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Flag";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (Count != null)
                    callPayload.Queries["_count"] = SourceExpressionConverter.ConvertO(Count);
                if (Sort != null)
                    callPayload.Queries["_sort"] = SourceExpressionConverter.ConvertO(Sort);
                if (patient != null)
                    callPayload.Queries["patient"] = SourceExpressionConverter.ConvertO(patient);
                return callPayload;
            }

            return new ApiConnectionAction<GETFlagResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<POSTFLAGResponse> POSTFLAG([WorkflowExpression] Func<string> bodyresourceType = null, [WorkflowExpression] Func<string> bodyid = null, [WorkflowExpression] Func<string> bodytextstatus = null, [WorkflowExpression] Func<string> bodytextdiv = null, [WorkflowExpression] Func<bodyidentifierInputItem2[]> bodyidentifier = null, [WorkflowExpression] Func<string> bodystatus = null, [WorkflowExpression] Func<bodycategoryInputItem[]> bodycategory = null, [WorkflowExpression] Func<bodycodecodingInputItem[]> bodycodecoding = null, [WorkflowExpression] Func<string> bodycodetext = null, [WorkflowExpression] Func<string> bodysubjectreference = null, [WorkflowExpression] Func<string> bodysubjectdisplay = null, [WorkflowExpression] Func<string> bodyperiodstart = null, [WorkflowExpression] Func<string> bodyperiodend = null, [WorkflowExpression] Func<string> bodyauthorreference = null, [WorkflowExpression] Func<string> bodyauthordisplay = null)
        {
            SourceExpression.Validate(bodyresourceType, nameof(bodyresourceType), required: false);
            SourceExpression.Validate(bodyid, nameof(bodyid), required: false);
            SourceExpression.Validate(bodytextstatus, nameof(bodytextstatus), required: false);
            SourceExpression.Validate(bodytextdiv, nameof(bodytextdiv), required: false);
            SourceExpression.Validate(bodyidentifier, nameof(bodyidentifier), required: false);
            SourceExpression.Validate(bodystatus, nameof(bodystatus), required: false);
            SourceExpression.Validate(bodycategory, nameof(bodycategory), required: false);
            SourceExpression.Validate(bodycodecoding, nameof(bodycodecoding), required: false);
            SourceExpression.Validate(bodycodetext, nameof(bodycodetext), required: false);
            SourceExpression.Validate(bodysubjectreference, nameof(bodysubjectreference), required: false);
            SourceExpression.Validate(bodysubjectdisplay, nameof(bodysubjectdisplay), required: false);
            SourceExpression.Validate(bodyperiodstart, nameof(bodyperiodstart), required: false);
            SourceExpression.Validate(bodyperiodend, nameof(bodyperiodend), required: false);
            SourceExpression.Validate(bodyauthorreference, nameof(bodyauthorreference), required: false);
            SourceExpression.Validate(bodyauthordisplay, nameof(bodyauthordisplay), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Flag";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyresourceType != null)
                {
                    body["resourceType"] = SourceExpressionConverter.ConvertToken(bodyresourceType);
                    bodypropCount++;
                }

                if (bodyid != null)
                {
                    body["id"] = SourceExpressionConverter.ConvertToken(bodyid);
                    bodypropCount++;
                }

                var textObject = new JObject();
                var textObjectpropCount = 0;
                if (bodytextstatus != null)
                {
                    textObject["status"] = SourceExpressionConverter.ConvertToken(bodytextstatus);
                    textObjectpropCount++;
                }

                if (bodytextdiv != null)
                {
                    textObject["div"] = SourceExpressionConverter.ConvertToken(bodytextdiv);
                    textObjectpropCount++;
                }

                if (textObjectpropCount > 0)
                {
                    body["text"] = textObject;
                    bodypropCount++;
                }

                if (bodyidentifier != null)
                {
                    body["identifier"] = SourceExpressionConverter.ConvertToken(bodyidentifier);
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    body["status"] = SourceExpressionConverter.ConvertToken(bodystatus);
                    bodypropCount++;
                }

                if (bodycategory != null)
                {
                    body["category"] = SourceExpressionConverter.ConvertToken(bodycategory);
                    bodypropCount++;
                }

                var codeObject = new JObject();
                var codeObjectpropCount = 0;
                if (bodycodecoding != null)
                {
                    codeObject["coding"] = SourceExpressionConverter.ConvertToken(bodycodecoding);
                    codeObjectpropCount++;
                }

                if (bodycodetext != null)
                {
                    codeObject["text"] = SourceExpressionConverter.ConvertToken(bodycodetext);
                    codeObjectpropCount++;
                }

                if (codeObjectpropCount > 0)
                {
                    body["code"] = codeObject;
                    bodypropCount++;
                }

                var subjectObject = new JObject();
                var subjectObjectpropCount = 0;
                if (bodysubjectreference != null)
                {
                    subjectObject["reference"] = SourceExpressionConverter.ConvertToken(bodysubjectreference);
                    subjectObjectpropCount++;
                }

                if (bodysubjectdisplay != null)
                {
                    subjectObject["display"] = SourceExpressionConverter.ConvertToken(bodysubjectdisplay);
                    subjectObjectpropCount++;
                }

                if (subjectObjectpropCount > 0)
                {
                    body["subject"] = subjectObject;
                    bodypropCount++;
                }

                var periodObject = new JObject();
                var periodObjectpropCount = 0;
                if (bodyperiodstart != null)
                {
                    periodObject["start"] = SourceExpressionConverter.ConvertToken(bodyperiodstart);
                    periodObjectpropCount++;
                }

                if (bodyperiodend != null)
                {
                    periodObject["end"] = SourceExpressionConverter.ConvertToken(bodyperiodend);
                    periodObjectpropCount++;
                }

                if (periodObjectpropCount > 0)
                {
                    body["period"] = periodObject;
                    bodypropCount++;
                }

                var authorObject = new JObject();
                var authorObjectpropCount = 0;
                if (bodyauthorreference != null)
                {
                    authorObject["reference"] = SourceExpressionConverter.ConvertToken(bodyauthorreference);
                    authorObjectpropCount++;
                }

                if (bodyauthordisplay != null)
                {
                    authorObject["display"] = SourceExpressionConverter.ConvertToken(bodyauthordisplay);
                    authorObjectpropCount++;
                }

                if (authorObjectpropCount > 0)
                {
                    body["author"] = authorObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<POSTFLAGResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GETFlagIdResponse> GETFlagId([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/Flag/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GETFlagIdResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<DELETEFlagIdResponse> DELETEFlagId([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodyresourceType = null, [WorkflowExpression] Func<string> bodyid = null, [WorkflowExpression] Func<string> bodytextstatus = null, [WorkflowExpression] Func<string> bodytextdiv = null, [WorkflowExpression] Func<bodyidentifierInputItem2[]> bodyidentifier = null, [WorkflowExpression] Func<string> bodystatus = null, [WorkflowExpression] Func<bodycategoryInputItem[]> bodycategory = null, [WorkflowExpression] Func<bodycodecodingInputItem[]> bodycodecoding = null, [WorkflowExpression] Func<string> bodycodetext = null, [WorkflowExpression] Func<string> bodysubjectreference = null, [WorkflowExpression] Func<string> bodysubjectdisplay = null, [WorkflowExpression] Func<string> bodyperiodstart = null, [WorkflowExpression] Func<string> bodyperiodend = null, [WorkflowExpression] Func<string> bodyauthorreference = null, [WorkflowExpression] Func<string> bodyauthordisplay = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(bodyresourceType, nameof(bodyresourceType), required: false);
            SourceExpression.Validate(bodyid, nameof(bodyid), required: false);
            SourceExpression.Validate(bodytextstatus, nameof(bodytextstatus), required: false);
            SourceExpression.Validate(bodytextdiv, nameof(bodytextdiv), required: false);
            SourceExpression.Validate(bodyidentifier, nameof(bodyidentifier), required: false);
            SourceExpression.Validate(bodystatus, nameof(bodystatus), required: false);
            SourceExpression.Validate(bodycategory, nameof(bodycategory), required: false);
            SourceExpression.Validate(bodycodecoding, nameof(bodycodecoding), required: false);
            SourceExpression.Validate(bodycodetext, nameof(bodycodetext), required: false);
            SourceExpression.Validate(bodysubjectreference, nameof(bodysubjectreference), required: false);
            SourceExpression.Validate(bodysubjectdisplay, nameof(bodysubjectdisplay), required: false);
            SourceExpression.Validate(bodyperiodstart, nameof(bodyperiodstart), required: false);
            SourceExpression.Validate(bodyperiodend, nameof(bodyperiodend), required: false);
            SourceExpression.Validate(bodyauthorreference, nameof(bodyauthorreference), required: false);
            SourceExpression.Validate(bodyauthordisplay, nameof(bodyauthordisplay), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/Flag/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyresourceType != null)
                {
                    body["resourceType"] = SourceExpressionConverter.ConvertToken(bodyresourceType);
                    bodypropCount++;
                }

                if (bodyid != null)
                {
                    body["id"] = SourceExpressionConverter.ConvertToken(bodyid);
                    bodypropCount++;
                }

                var textObject = new JObject();
                var textObjectpropCount = 0;
                if (bodytextstatus != null)
                {
                    textObject["status"] = SourceExpressionConverter.ConvertToken(bodytextstatus);
                    textObjectpropCount++;
                }

                if (bodytextdiv != null)
                {
                    textObject["div"] = SourceExpressionConverter.ConvertToken(bodytextdiv);
                    textObjectpropCount++;
                }

                if (textObjectpropCount > 0)
                {
                    body["text"] = textObject;
                    bodypropCount++;
                }

                if (bodyidentifier != null)
                {
                    body["identifier"] = SourceExpressionConverter.ConvertToken(bodyidentifier);
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    body["status"] = SourceExpressionConverter.ConvertToken(bodystatus);
                    bodypropCount++;
                }

                if (bodycategory != null)
                {
                    body["category"] = SourceExpressionConverter.ConvertToken(bodycategory);
                    bodypropCount++;
                }

                var codeObject = new JObject();
                var codeObjectpropCount = 0;
                if (bodycodecoding != null)
                {
                    codeObject["coding"] = SourceExpressionConverter.ConvertToken(bodycodecoding);
                    codeObjectpropCount++;
                }

                if (bodycodetext != null)
                {
                    codeObject["text"] = SourceExpressionConverter.ConvertToken(bodycodetext);
                    codeObjectpropCount++;
                }

                if (codeObjectpropCount > 0)
                {
                    body["code"] = codeObject;
                    bodypropCount++;
                }

                var subjectObject = new JObject();
                var subjectObjectpropCount = 0;
                if (bodysubjectreference != null)
                {
                    subjectObject["reference"] = SourceExpressionConverter.ConvertToken(bodysubjectreference);
                    subjectObjectpropCount++;
                }

                if (bodysubjectdisplay != null)
                {
                    subjectObject["display"] = SourceExpressionConverter.ConvertToken(bodysubjectdisplay);
                    subjectObjectpropCount++;
                }

                if (subjectObjectpropCount > 0)
                {
                    body["subject"] = subjectObject;
                    bodypropCount++;
                }

                var periodObject = new JObject();
                var periodObjectpropCount = 0;
                if (bodyperiodstart != null)
                {
                    periodObject["start"] = SourceExpressionConverter.ConvertToken(bodyperiodstart);
                    periodObjectpropCount++;
                }

                if (bodyperiodend != null)
                {
                    periodObject["end"] = SourceExpressionConverter.ConvertToken(bodyperiodend);
                    periodObjectpropCount++;
                }

                if (periodObjectpropCount > 0)
                {
                    body["period"] = periodObject;
                    bodypropCount++;
                }

                var authorObject = new JObject();
                var authorObjectpropCount = 0;
                if (bodyauthorreference != null)
                {
                    authorObject["reference"] = SourceExpressionConverter.ConvertToken(bodyauthorreference);
                    authorObjectpropCount++;
                }

                if (bodyauthordisplay != null)
                {
                    authorObject["display"] = SourceExpressionConverter.ConvertToken(bodyauthordisplay);
                    authorObjectpropCount++;
                }

                if (authorObjectpropCount > 0)
                {
                    body["author"] = authorObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DELETEFlagIdResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<PUTFlagIdResponse> PUTFlagId([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodyresourceType = null, [WorkflowExpression] Func<string> bodyid = null, [WorkflowExpression] Func<string> bodytextstatus = null, [WorkflowExpression] Func<string> bodytextdiv = null, [WorkflowExpression] Func<bodyidentifierInputItem2[]> bodyidentifier = null, [WorkflowExpression] Func<string> bodystatus = null, [WorkflowExpression] Func<bodycategoryInputItem[]> bodycategory = null, [WorkflowExpression] Func<bodycodecodingInputItem[]> bodycodecoding = null, [WorkflowExpression] Func<string> bodycodetext = null, [WorkflowExpression] Func<string> bodysubjectreference = null, [WorkflowExpression] Func<string> bodysubjectdisplay = null, [WorkflowExpression] Func<string> bodyperiodstart = null, [WorkflowExpression] Func<string> bodyperiodend = null, [WorkflowExpression] Func<string> bodyauthorreference = null, [WorkflowExpression] Func<string> bodyauthordisplay = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(bodyresourceType, nameof(bodyresourceType), required: false);
            SourceExpression.Validate(bodyid, nameof(bodyid), required: false);
            SourceExpression.Validate(bodytextstatus, nameof(bodytextstatus), required: false);
            SourceExpression.Validate(bodytextdiv, nameof(bodytextdiv), required: false);
            SourceExpression.Validate(bodyidentifier, nameof(bodyidentifier), required: false);
            SourceExpression.Validate(bodystatus, nameof(bodystatus), required: false);
            SourceExpression.Validate(bodycategory, nameof(bodycategory), required: false);
            SourceExpression.Validate(bodycodecoding, nameof(bodycodecoding), required: false);
            SourceExpression.Validate(bodycodetext, nameof(bodycodetext), required: false);
            SourceExpression.Validate(bodysubjectreference, nameof(bodysubjectreference), required: false);
            SourceExpression.Validate(bodysubjectdisplay, nameof(bodysubjectdisplay), required: false);
            SourceExpression.Validate(bodyperiodstart, nameof(bodyperiodstart), required: false);
            SourceExpression.Validate(bodyperiodend, nameof(bodyperiodend), required: false);
            SourceExpression.Validate(bodyauthorreference, nameof(bodyauthorreference), required: false);
            SourceExpression.Validate(bodyauthordisplay, nameof(bodyauthordisplay), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/Flag/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyresourceType != null)
                {
                    body["resourceType"] = SourceExpressionConverter.ConvertToken(bodyresourceType);
                    bodypropCount++;
                }

                if (bodyid != null)
                {
                    body["id"] = SourceExpressionConverter.ConvertToken(bodyid);
                    bodypropCount++;
                }

                var textObject = new JObject();
                var textObjectpropCount = 0;
                if (bodytextstatus != null)
                {
                    textObject["status"] = SourceExpressionConverter.ConvertToken(bodytextstatus);
                    textObjectpropCount++;
                }

                if (bodytextdiv != null)
                {
                    textObject["div"] = SourceExpressionConverter.ConvertToken(bodytextdiv);
                    textObjectpropCount++;
                }

                if (textObjectpropCount > 0)
                {
                    body["text"] = textObject;
                    bodypropCount++;
                }

                if (bodyidentifier != null)
                {
                    body["identifier"] = SourceExpressionConverter.ConvertToken(bodyidentifier);
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    body["status"] = SourceExpressionConverter.ConvertToken(bodystatus);
                    bodypropCount++;
                }

                if (bodycategory != null)
                {
                    body["category"] = SourceExpressionConverter.ConvertToken(bodycategory);
                    bodypropCount++;
                }

                var codeObject = new JObject();
                var codeObjectpropCount = 0;
                if (bodycodecoding != null)
                {
                    codeObject["coding"] = SourceExpressionConverter.ConvertToken(bodycodecoding);
                    codeObjectpropCount++;
                }

                if (bodycodetext != null)
                {
                    codeObject["text"] = SourceExpressionConverter.ConvertToken(bodycodetext);
                    codeObjectpropCount++;
                }

                if (codeObjectpropCount > 0)
                {
                    body["code"] = codeObject;
                    bodypropCount++;
                }

                var subjectObject = new JObject();
                var subjectObjectpropCount = 0;
                if (bodysubjectreference != null)
                {
                    subjectObject["reference"] = SourceExpressionConverter.ConvertToken(bodysubjectreference);
                    subjectObjectpropCount++;
                }

                if (bodysubjectdisplay != null)
                {
                    subjectObject["display"] = SourceExpressionConverter.ConvertToken(bodysubjectdisplay);
                    subjectObjectpropCount++;
                }

                if (subjectObjectpropCount > 0)
                {
                    body["subject"] = subjectObject;
                    bodypropCount++;
                }

                var periodObject = new JObject();
                var periodObjectpropCount = 0;
                if (bodyperiodstart != null)
                {
                    periodObject["start"] = SourceExpressionConverter.ConvertToken(bodyperiodstart);
                    periodObjectpropCount++;
                }

                if (bodyperiodend != null)
                {
                    periodObject["end"] = SourceExpressionConverter.ConvertToken(bodyperiodend);
                    periodObjectpropCount++;
                }

                if (periodObjectpropCount > 0)
                {
                    body["period"] = periodObject;
                    bodypropCount++;
                }

                var authorObject = new JObject();
                var authorObjectpropCount = 0;
                if (bodyauthorreference != null)
                {
                    authorObject["reference"] = SourceExpressionConverter.ConvertToken(bodyauthorreference);
                    authorObjectpropCount++;
                }

                if (bodyauthordisplay != null)
                {
                    authorObject["display"] = SourceExpressionConverter.ConvertToken(bodyauthordisplay);
                    authorObjectpropCount++;
                }

                if (authorObjectpropCount > 0)
                {
                    body["author"] = authorObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<PUTFlagIdResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GETFlagIdVersionResponse> GETFlagIdVersion([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> vid)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(vid, nameof(vid), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/Flag/{0}/_history/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(vid, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GETFlagIdVersionResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GETFlagIdHistoryResponse> GETFlagIdHistory([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/Flag/{0}/_history", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GETFlagIdHistoryResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GETFlagHISTORYResponse> GETFlagHISTORY()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Flag/_history";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GETFlagHISTORYResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GETLocationResponse> GETLocation([WorkflowExpression] Func<string> Count = null, [WorkflowExpression] Func<string> Sort = null, [WorkflowExpression] Func<string> patient = null)
        {
            SourceExpression.Validate(Count, nameof(Count), required: false);
            SourceExpression.Validate(Sort, nameof(Sort), required: false);
            SourceExpression.Validate(patient, nameof(patient), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Location";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (Count != null)
                    callPayload.Queries["_count"] = SourceExpressionConverter.ConvertO(Count);
                if (Sort != null)
                    callPayload.Queries["_sort"] = SourceExpressionConverter.ConvertO(Sort);
                if (patient != null)
                    callPayload.Queries["patient"] = SourceExpressionConverter.ConvertO(patient);
                return callPayload;
            }

            return new ApiConnectionAction<GETLocationResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<POSTLocationResponse> POSTLocation([WorkflowExpression] Func<string> bodyresourceType = null, [WorkflowExpression] Func<string> bodyid = null, [WorkflowExpression] Func<string> bodytextstatus = null, [WorkflowExpression] Func<string> bodytextdiv = null, [WorkflowExpression] Func<string> bodystatus = null, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodymode = null, [WorkflowExpression] Func<string> bodypartOfreference = null, [WorkflowExpression] Func<string> bodypartOfdisplay = null)
        {
            SourceExpression.Validate(bodyresourceType, nameof(bodyresourceType), required: false);
            SourceExpression.Validate(bodyid, nameof(bodyid), required: false);
            SourceExpression.Validate(bodytextstatus, nameof(bodytextstatus), required: false);
            SourceExpression.Validate(bodytextdiv, nameof(bodytextdiv), required: false);
            SourceExpression.Validate(bodystatus, nameof(bodystatus), required: false);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: false);
            SourceExpression.Validate(bodymode, nameof(bodymode), required: false);
            SourceExpression.Validate(bodypartOfreference, nameof(bodypartOfreference), required: false);
            SourceExpression.Validate(bodypartOfdisplay, nameof(bodypartOfdisplay), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Location";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyresourceType != null)
                {
                    body["resourceType"] = SourceExpressionConverter.ConvertToken(bodyresourceType);
                    bodypropCount++;
                }

                if (bodyid != null)
                {
                    body["id"] = SourceExpressionConverter.ConvertToken(bodyid);
                    bodypropCount++;
                }

                var textObject = new JObject();
                var textObjectpropCount = 0;
                if (bodytextstatus != null)
                {
                    textObject["status"] = SourceExpressionConverter.ConvertToken(bodytextstatus);
                    textObjectpropCount++;
                }

                if (bodytextdiv != null)
                {
                    textObject["div"] = SourceExpressionConverter.ConvertToken(bodytextdiv);
                    textObjectpropCount++;
                }

                if (textObjectpropCount > 0)
                {
                    body["text"] = textObject;
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    body["status"] = SourceExpressionConverter.ConvertToken(bodystatus);
                    bodypropCount++;
                }

                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodymode != null)
                {
                    body["mode"] = SourceExpressionConverter.ConvertToken(bodymode);
                    bodypropCount++;
                }

                var partOfObject = new JObject();
                var partOfObjectpropCount = 0;
                if (bodypartOfreference != null)
                {
                    partOfObject["reference"] = SourceExpressionConverter.ConvertToken(bodypartOfreference);
                    partOfObjectpropCount++;
                }

                if (bodypartOfdisplay != null)
                {
                    partOfObject["display"] = SourceExpressionConverter.ConvertToken(bodypartOfdisplay);
                    partOfObjectpropCount++;
                }

                if (partOfObjectpropCount > 0)
                {
                    body["partOf"] = partOfObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<POSTLocationResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GETLocationIdResponse> GETLocationId([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/Location/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GETLocationIdResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<DELETELocationIdResponse> DELETELocationId([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodyresourceType = null, [WorkflowExpression] Func<string> bodyid = null, [WorkflowExpression] Func<string> bodytextstatus = null, [WorkflowExpression] Func<string> bodytextdiv = null, [WorkflowExpression] Func<string> bodystatus = null, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodymode = null, [WorkflowExpression] Func<string> bodypartOfreference = null, [WorkflowExpression] Func<string> bodypartOfdisplay = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(bodyresourceType, nameof(bodyresourceType), required: false);
            SourceExpression.Validate(bodyid, nameof(bodyid), required: false);
            SourceExpression.Validate(bodytextstatus, nameof(bodytextstatus), required: false);
            SourceExpression.Validate(bodytextdiv, nameof(bodytextdiv), required: false);
            SourceExpression.Validate(bodystatus, nameof(bodystatus), required: false);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: false);
            SourceExpression.Validate(bodymode, nameof(bodymode), required: false);
            SourceExpression.Validate(bodypartOfreference, nameof(bodypartOfreference), required: false);
            SourceExpression.Validate(bodypartOfdisplay, nameof(bodypartOfdisplay), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/Location/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyresourceType != null)
                {
                    body["resourceType"] = SourceExpressionConverter.ConvertToken(bodyresourceType);
                    bodypropCount++;
                }

                if (bodyid != null)
                {
                    body["id"] = SourceExpressionConverter.ConvertToken(bodyid);
                    bodypropCount++;
                }

                var textObject = new JObject();
                var textObjectpropCount = 0;
                if (bodytextstatus != null)
                {
                    textObject["status"] = SourceExpressionConverter.ConvertToken(bodytextstatus);
                    textObjectpropCount++;
                }

                if (bodytextdiv != null)
                {
                    textObject["div"] = SourceExpressionConverter.ConvertToken(bodytextdiv);
                    textObjectpropCount++;
                }

                if (textObjectpropCount > 0)
                {
                    body["text"] = textObject;
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    body["status"] = SourceExpressionConverter.ConvertToken(bodystatus);
                    bodypropCount++;
                }

                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodymode != null)
                {
                    body["mode"] = SourceExpressionConverter.ConvertToken(bodymode);
                    bodypropCount++;
                }

                var partOfObject = new JObject();
                var partOfObjectpropCount = 0;
                if (bodypartOfreference != null)
                {
                    partOfObject["reference"] = SourceExpressionConverter.ConvertToken(bodypartOfreference);
                    partOfObjectpropCount++;
                }

                if (bodypartOfdisplay != null)
                {
                    partOfObject["display"] = SourceExpressionConverter.ConvertToken(bodypartOfdisplay);
                    partOfObjectpropCount++;
                }

                if (partOfObjectpropCount > 0)
                {
                    body["partOf"] = partOfObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DELETELocationIdResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<PUTLocationIdResponse> PUTLocationId([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodyresourceType = null, [WorkflowExpression] Func<string> bodyid = null, [WorkflowExpression] Func<string> bodytextstatus = null, [WorkflowExpression] Func<string> bodytextdiv = null, [WorkflowExpression] Func<string> bodystatus = null, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodymode = null, [WorkflowExpression] Func<string> bodypartOfreference = null, [WorkflowExpression] Func<string> bodypartOfdisplay = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(bodyresourceType, nameof(bodyresourceType), required: false);
            SourceExpression.Validate(bodyid, nameof(bodyid), required: false);
            SourceExpression.Validate(bodytextstatus, nameof(bodytextstatus), required: false);
            SourceExpression.Validate(bodytextdiv, nameof(bodytextdiv), required: false);
            SourceExpression.Validate(bodystatus, nameof(bodystatus), required: false);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: false);
            SourceExpression.Validate(bodymode, nameof(bodymode), required: false);
            SourceExpression.Validate(bodypartOfreference, nameof(bodypartOfreference), required: false);
            SourceExpression.Validate(bodypartOfdisplay, nameof(bodypartOfdisplay), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/Location/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyresourceType != null)
                {
                    body["resourceType"] = SourceExpressionConverter.ConvertToken(bodyresourceType);
                    bodypropCount++;
                }

                if (bodyid != null)
                {
                    body["id"] = SourceExpressionConverter.ConvertToken(bodyid);
                    bodypropCount++;
                }

                var textObject = new JObject();
                var textObjectpropCount = 0;
                if (bodytextstatus != null)
                {
                    textObject["status"] = SourceExpressionConverter.ConvertToken(bodytextstatus);
                    textObjectpropCount++;
                }

                if (bodytextdiv != null)
                {
                    textObject["div"] = SourceExpressionConverter.ConvertToken(bodytextdiv);
                    textObjectpropCount++;
                }

                if (textObjectpropCount > 0)
                {
                    body["text"] = textObject;
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    body["status"] = SourceExpressionConverter.ConvertToken(bodystatus);
                    bodypropCount++;
                }

                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodymode != null)
                {
                    body["mode"] = SourceExpressionConverter.ConvertToken(bodymode);
                    bodypropCount++;
                }

                var partOfObject = new JObject();
                var partOfObjectpropCount = 0;
                if (bodypartOfreference != null)
                {
                    partOfObject["reference"] = SourceExpressionConverter.ConvertToken(bodypartOfreference);
                    partOfObjectpropCount++;
                }

                if (bodypartOfdisplay != null)
                {
                    partOfObject["display"] = SourceExpressionConverter.ConvertToken(bodypartOfdisplay);
                    partOfObjectpropCount++;
                }

                if (partOfObjectpropCount > 0)
                {
                    body["partOf"] = partOfObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<PUTLocationIdResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GETLocationIdVersionResponse> GETLocationIdVersion([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> vid)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(vid, nameof(vid), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/Location/{0}/_history/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(vid, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GETLocationIdVersionResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GETLocationIdHistoryResponse> GETLocationIdHistory([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/Location/{0}/_history", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GETLocationIdHistoryResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GETLocationHistoryResponse> GETLocationHistory()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Location/_history";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GETLocationHistoryResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GETPatientResponse> GETPatient([WorkflowExpression] Func<string> Count = null, [WorkflowExpression] Func<string> Sort = null, [WorkflowExpression] Func<string> patient = null)
        {
            SourceExpression.Validate(Count, nameof(Count), required: false);
            SourceExpression.Validate(Sort, nameof(Sort), required: false);
            SourceExpression.Validate(patient, nameof(patient), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Patient";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (Count != null)
                    callPayload.Queries["_count"] = SourceExpressionConverter.ConvertO(Count);
                if (Sort != null)
                    callPayload.Queries["_sort"] = SourceExpressionConverter.ConvertO(Sort);
                if (patient != null)
                    callPayload.Queries["patient"] = SourceExpressionConverter.ConvertO(patient);
                return callPayload;
            }

            return new ApiConnectionAction<GETPatientResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<POSTPatientResponse> POSTPatient([WorkflowExpression] Func<string> bodyresourceType = null, [WorkflowExpression] Func<bool> bodyactive = null, [WorkflowExpression] Func<bodynameInputItem[]> bodyname = null, [WorkflowExpression] Func<bodytelecomInputItem[]> bodytelecom = null, [WorkflowExpression] Func<string> bodygender = null, [WorkflowExpression] Func<string> bodybirthDate = null, [WorkflowExpression] Func<bool> bodydeceasedBoolean = null, [WorkflowExpression] Func<bodyaddressInputItem[]> bodyaddress = null)
        {
            SourceExpression.Validate(bodyresourceType, nameof(bodyresourceType), required: false);
            SourceExpression.Validate(bodyactive, nameof(bodyactive), required: false);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: false);
            SourceExpression.Validate(bodytelecom, nameof(bodytelecom), required: false);
            SourceExpression.Validate(bodygender, nameof(bodygender), required: false);
            SourceExpression.Validate(bodybirthDate, nameof(bodybirthDate), required: false);
            SourceExpression.Validate(bodydeceasedBoolean, nameof(bodydeceasedBoolean), required: false);
            SourceExpression.Validate(bodyaddress, nameof(bodyaddress), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Patient";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyresourceType != null)
                {
                    body["resourceType"] = SourceExpressionConverter.ConvertToken(bodyresourceType);
                    bodypropCount++;
                }

                if (bodyactive != null)
                {
                    body["active"] = SourceExpressionConverter.ConvertToken(bodyactive);
                    bodypropCount++;
                }

                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodytelecom != null)
                {
                    body["telecom"] = SourceExpressionConverter.ConvertToken(bodytelecom);
                    bodypropCount++;
                }

                if (bodygender != null)
                {
                    body["gender"] = SourceExpressionConverter.ConvertToken(bodygender);
                    bodypropCount++;
                }

                if (bodybirthDate != null)
                {
                    body["birthDate"] = SourceExpressionConverter.ConvertToken(bodybirthDate);
                    bodypropCount++;
                }

                if (bodydeceasedBoolean != null)
                {
                    body["deceasedBoolean"] = SourceExpressionConverter.ConvertToken(bodydeceasedBoolean);
                    bodypropCount++;
                }

                if (bodyaddress != null)
                {
                    body["address"] = SourceExpressionConverter.ConvertToken(bodyaddress);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<POSTPatientResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GETPatientIdResponse> GETPatientId([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/Patient/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GETPatientIdResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<DELETEPatientIdResponse> DELETEPatientId([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodyresourceType = null, [WorkflowExpression] Func<string> bodyid = null, [WorkflowExpression] Func<bool> bodyactive = null, [WorkflowExpression] Func<bodynameInputItem[]> bodyname = null, [WorkflowExpression] Func<bodytelecomInputItem[]> bodytelecom = null, [WorkflowExpression] Func<string> bodygender = null, [WorkflowExpression] Func<string> bodybirthDate = null, [WorkflowExpression] Func<bool> bodydeceasedBoolean = null, [WorkflowExpression] Func<bodyaddressInputItem[]> bodyaddress = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(bodyresourceType, nameof(bodyresourceType), required: false);
            SourceExpression.Validate(bodyid, nameof(bodyid), required: false);
            SourceExpression.Validate(bodyactive, nameof(bodyactive), required: false);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: false);
            SourceExpression.Validate(bodytelecom, nameof(bodytelecom), required: false);
            SourceExpression.Validate(bodygender, nameof(bodygender), required: false);
            SourceExpression.Validate(bodybirthDate, nameof(bodybirthDate), required: false);
            SourceExpression.Validate(bodydeceasedBoolean, nameof(bodydeceasedBoolean), required: false);
            SourceExpression.Validate(bodyaddress, nameof(bodyaddress), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/Patient/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyresourceType != null)
                {
                    body["resourceType"] = SourceExpressionConverter.ConvertToken(bodyresourceType);
                    bodypropCount++;
                }

                if (bodyid != null)
                {
                    body["id"] = SourceExpressionConverter.ConvertToken(bodyid);
                    bodypropCount++;
                }

                if (bodyactive != null)
                {
                    body["active"] = SourceExpressionConverter.ConvertToken(bodyactive);
                    bodypropCount++;
                }

                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodytelecom != null)
                {
                    body["telecom"] = SourceExpressionConverter.ConvertToken(bodytelecom);
                    bodypropCount++;
                }

                if (bodygender != null)
                {
                    body["gender"] = SourceExpressionConverter.ConvertToken(bodygender);
                    bodypropCount++;
                }

                if (bodybirthDate != null)
                {
                    body["birthDate"] = SourceExpressionConverter.ConvertToken(bodybirthDate);
                    bodypropCount++;
                }

                if (bodydeceasedBoolean != null)
                {
                    body["deceasedBoolean"] = SourceExpressionConverter.ConvertToken(bodydeceasedBoolean);
                    bodypropCount++;
                }

                if (bodyaddress != null)
                {
                    body["address"] = SourceExpressionConverter.ConvertToken(bodyaddress);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DELETEPatientIdResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<PUTPatientIdResponse> PUTPatientId([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodyresourceType = null, [WorkflowExpression] Func<string> bodyid = null, [WorkflowExpression] Func<bool> bodyactive = null, [WorkflowExpression] Func<bodynameInputItem[]> bodyname = null, [WorkflowExpression] Func<bodytelecomInputItem[]> bodytelecom = null, [WorkflowExpression] Func<string> bodygender = null, [WorkflowExpression] Func<string> bodybirthDate = null, [WorkflowExpression] Func<bool> bodydeceasedBoolean = null, [WorkflowExpression] Func<bodyaddressInputItem[]> bodyaddress = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(bodyresourceType, nameof(bodyresourceType), required: false);
            SourceExpression.Validate(bodyid, nameof(bodyid), required: false);
            SourceExpression.Validate(bodyactive, nameof(bodyactive), required: false);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: false);
            SourceExpression.Validate(bodytelecom, nameof(bodytelecom), required: false);
            SourceExpression.Validate(bodygender, nameof(bodygender), required: false);
            SourceExpression.Validate(bodybirthDate, nameof(bodybirthDate), required: false);
            SourceExpression.Validate(bodydeceasedBoolean, nameof(bodydeceasedBoolean), required: false);
            SourceExpression.Validate(bodyaddress, nameof(bodyaddress), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/Patient/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyresourceType != null)
                {
                    body["resourceType"] = SourceExpressionConverter.ConvertToken(bodyresourceType);
                    bodypropCount++;
                }

                if (bodyid != null)
                {
                    body["id"] = SourceExpressionConverter.ConvertToken(bodyid);
                    bodypropCount++;
                }

                if (bodyactive != null)
                {
                    body["active"] = SourceExpressionConverter.ConvertToken(bodyactive);
                    bodypropCount++;
                }

                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodytelecom != null)
                {
                    body["telecom"] = SourceExpressionConverter.ConvertToken(bodytelecom);
                    bodypropCount++;
                }

                if (bodygender != null)
                {
                    body["gender"] = SourceExpressionConverter.ConvertToken(bodygender);
                    bodypropCount++;
                }

                if (bodybirthDate != null)
                {
                    body["birthDate"] = SourceExpressionConverter.ConvertToken(bodybirthDate);
                    bodypropCount++;
                }

                if (bodydeceasedBoolean != null)
                {
                    body["deceasedBoolean"] = SourceExpressionConverter.ConvertToken(bodydeceasedBoolean);
                    bodypropCount++;
                }

                if (bodyaddress != null)
                {
                    body["address"] = SourceExpressionConverter.ConvertToken(bodyaddress);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<PUTPatientIdResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GETPatientIdVersionResponse> GETPatientIdVersion([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> vid)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(vid, nameof(vid), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/Patient/{0}/_history/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(vid, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GETPatientIdVersionResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GETPatientIdHistoryResponse> GETPatientIdHistory([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/Patient/{0}/_history", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GETPatientIdHistoryResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GETPatientHistoryResponse> GETPatientHistory()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Patient/_history";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GETPatientHistoryResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GETPersonResponse> GETPerson([WorkflowExpression] Func<string> Count = null, [WorkflowExpression] Func<string> Sort = null, [WorkflowExpression] Func<string> patient = null)
        {
            SourceExpression.Validate(Count, nameof(Count), required: false);
            SourceExpression.Validate(Sort, nameof(Sort), required: false);
            SourceExpression.Validate(patient, nameof(patient), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Person";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (Count != null)
                    callPayload.Queries["_count"] = SourceExpressionConverter.ConvertO(Count);
                if (Sort != null)
                    callPayload.Queries["_sort"] = SourceExpressionConverter.ConvertO(Sort);
                if (patient != null)
                    callPayload.Queries["patient"] = SourceExpressionConverter.ConvertO(patient);
                return callPayload;
            }

            return new ApiConnectionAction<GETPersonResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<POSTPersonResponse> POSTPerson([WorkflowExpression] Func<string> bodyresourceType = null, [WorkflowExpression] Func<string> bodyid = null, [WorkflowExpression] Func<bodynameInputItem[]> bodyname = null, [WorkflowExpression] Func<bodytelecomInputItem2[]> bodytelecom = null, [WorkflowExpression] Func<string> bodygender = null, [WorkflowExpression] Func<string> bodybirthDate = null, [WorkflowExpression] Func<bodyaddressInputItem2[]> bodyaddress = null, [WorkflowExpression] Func<string> bodymanagingOrganizationreference = null, [WorkflowExpression] Func<string> bodymanagingOrganizationdisplay = null, [WorkflowExpression] Func<bool> bodyactive = null, [WorkflowExpression] Func<bodylinkInputItem[]> bodylink = null)
        {
            SourceExpression.Validate(bodyresourceType, nameof(bodyresourceType), required: false);
            SourceExpression.Validate(bodyid, nameof(bodyid), required: false);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: false);
            SourceExpression.Validate(bodytelecom, nameof(bodytelecom), required: false);
            SourceExpression.Validate(bodygender, nameof(bodygender), required: false);
            SourceExpression.Validate(bodybirthDate, nameof(bodybirthDate), required: false);
            SourceExpression.Validate(bodyaddress, nameof(bodyaddress), required: false);
            SourceExpression.Validate(bodymanagingOrganizationreference, nameof(bodymanagingOrganizationreference), required: false);
            SourceExpression.Validate(bodymanagingOrganizationdisplay, nameof(bodymanagingOrganizationdisplay), required: false);
            SourceExpression.Validate(bodyactive, nameof(bodyactive), required: false);
            SourceExpression.Validate(bodylink, nameof(bodylink), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Person";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyresourceType != null)
                {
                    body["resourceType"] = SourceExpressionConverter.ConvertToken(bodyresourceType);
                    bodypropCount++;
                }

                if (bodyid != null)
                {
                    body["id"] = SourceExpressionConverter.ConvertToken(bodyid);
                    bodypropCount++;
                }

                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodytelecom != null)
                {
                    body["telecom"] = SourceExpressionConverter.ConvertToken(bodytelecom);
                    bodypropCount++;
                }

                if (bodygender != null)
                {
                    body["gender"] = SourceExpressionConverter.ConvertToken(bodygender);
                    bodypropCount++;
                }

                if (bodybirthDate != null)
                {
                    body["birthDate"] = SourceExpressionConverter.ConvertToken(bodybirthDate);
                    bodypropCount++;
                }

                if (bodyaddress != null)
                {
                    body["address"] = SourceExpressionConverter.ConvertToken(bodyaddress);
                    bodypropCount++;
                }

                var managingOrganizationObject = new JObject();
                var managingOrganizationObjectpropCount = 0;
                if (bodymanagingOrganizationreference != null)
                {
                    managingOrganizationObject["reference"] = SourceExpressionConverter.ConvertToken(bodymanagingOrganizationreference);
                    managingOrganizationObjectpropCount++;
                }

                if (bodymanagingOrganizationdisplay != null)
                {
                    managingOrganizationObject["display"] = SourceExpressionConverter.ConvertToken(bodymanagingOrganizationdisplay);
                    managingOrganizationObjectpropCount++;
                }

                if (managingOrganizationObjectpropCount > 0)
                {
                    body["managingOrganization"] = managingOrganizationObject;
                    bodypropCount++;
                }

                if (bodyactive != null)
                {
                    body["active"] = SourceExpressionConverter.ConvertToken(bodyactive);
                    bodypropCount++;
                }

                if (bodylink != null)
                {
                    body["link"] = SourceExpressionConverter.ConvertToken(bodylink);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<POSTPersonResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GETPersonIdResponse> GETPersonId([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/Person/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GETPersonIdResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<DELETEPersonIdResponse> DELETEPersonId([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodyresourceType = null, [WorkflowExpression] Func<string> bodyid = null, [WorkflowExpression] Func<bodynameInputItem[]> bodyname = null, [WorkflowExpression] Func<bodytelecomInputItem2[]> bodytelecom = null, [WorkflowExpression] Func<string> bodygender = null, [WorkflowExpression] Func<string> bodybirthDate = null, [WorkflowExpression] Func<bodyaddressInputItem2[]> bodyaddress = null, [WorkflowExpression] Func<string> bodymanagingOrganizationreference = null, [WorkflowExpression] Func<string> bodymanagingOrganizationdisplay = null, [WorkflowExpression] Func<bool> bodyactive = null, [WorkflowExpression] Func<bodylinkInputItem[]> bodylink = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(bodyresourceType, nameof(bodyresourceType), required: false);
            SourceExpression.Validate(bodyid, nameof(bodyid), required: false);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: false);
            SourceExpression.Validate(bodytelecom, nameof(bodytelecom), required: false);
            SourceExpression.Validate(bodygender, nameof(bodygender), required: false);
            SourceExpression.Validate(bodybirthDate, nameof(bodybirthDate), required: false);
            SourceExpression.Validate(bodyaddress, nameof(bodyaddress), required: false);
            SourceExpression.Validate(bodymanagingOrganizationreference, nameof(bodymanagingOrganizationreference), required: false);
            SourceExpression.Validate(bodymanagingOrganizationdisplay, nameof(bodymanagingOrganizationdisplay), required: false);
            SourceExpression.Validate(bodyactive, nameof(bodyactive), required: false);
            SourceExpression.Validate(bodylink, nameof(bodylink), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/Person/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyresourceType != null)
                {
                    body["resourceType"] = SourceExpressionConverter.ConvertToken(bodyresourceType);
                    bodypropCount++;
                }

                if (bodyid != null)
                {
                    body["id"] = SourceExpressionConverter.ConvertToken(bodyid);
                    bodypropCount++;
                }

                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodytelecom != null)
                {
                    body["telecom"] = SourceExpressionConverter.ConvertToken(bodytelecom);
                    bodypropCount++;
                }

                if (bodygender != null)
                {
                    body["gender"] = SourceExpressionConverter.ConvertToken(bodygender);
                    bodypropCount++;
                }

                if (bodybirthDate != null)
                {
                    body["birthDate"] = SourceExpressionConverter.ConvertToken(bodybirthDate);
                    bodypropCount++;
                }

                if (bodyaddress != null)
                {
                    body["address"] = SourceExpressionConverter.ConvertToken(bodyaddress);
                    bodypropCount++;
                }

                var managingOrganizationObject = new JObject();
                var managingOrganizationObjectpropCount = 0;
                if (bodymanagingOrganizationreference != null)
                {
                    managingOrganizationObject["reference"] = SourceExpressionConverter.ConvertToken(bodymanagingOrganizationreference);
                    managingOrganizationObjectpropCount++;
                }

                if (bodymanagingOrganizationdisplay != null)
                {
                    managingOrganizationObject["display"] = SourceExpressionConverter.ConvertToken(bodymanagingOrganizationdisplay);
                    managingOrganizationObjectpropCount++;
                }

                if (managingOrganizationObjectpropCount > 0)
                {
                    body["managingOrganization"] = managingOrganizationObject;
                    bodypropCount++;
                }

                if (bodyactive != null)
                {
                    body["active"] = SourceExpressionConverter.ConvertToken(bodyactive);
                    bodypropCount++;
                }

                if (bodylink != null)
                {
                    body["link"] = SourceExpressionConverter.ConvertToken(bodylink);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DELETEPersonIdResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<PUTPersonIdResponse> PUTPersonId([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodyresourceType = null, [WorkflowExpression] Func<string> bodyid = null, [WorkflowExpression] Func<bodynameInputItem[]> bodyname = null, [WorkflowExpression] Func<bodytelecomInputItem2[]> bodytelecom = null, [WorkflowExpression] Func<string> bodygender = null, [WorkflowExpression] Func<string> bodybirthDate = null, [WorkflowExpression] Func<bodyaddressInputItem2[]> bodyaddress = null, [WorkflowExpression] Func<string> bodymanagingOrganizationreference = null, [WorkflowExpression] Func<string> bodymanagingOrganizationdisplay = null, [WorkflowExpression] Func<bool> bodyactive = null, [WorkflowExpression] Func<bodylinkInputItem[]> bodylink = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(bodyresourceType, nameof(bodyresourceType), required: false);
            SourceExpression.Validate(bodyid, nameof(bodyid), required: false);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: false);
            SourceExpression.Validate(bodytelecom, nameof(bodytelecom), required: false);
            SourceExpression.Validate(bodygender, nameof(bodygender), required: false);
            SourceExpression.Validate(bodybirthDate, nameof(bodybirthDate), required: false);
            SourceExpression.Validate(bodyaddress, nameof(bodyaddress), required: false);
            SourceExpression.Validate(bodymanagingOrganizationreference, nameof(bodymanagingOrganizationreference), required: false);
            SourceExpression.Validate(bodymanagingOrganizationdisplay, nameof(bodymanagingOrganizationdisplay), required: false);
            SourceExpression.Validate(bodyactive, nameof(bodyactive), required: false);
            SourceExpression.Validate(bodylink, nameof(bodylink), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/Person/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyresourceType != null)
                {
                    body["resourceType"] = SourceExpressionConverter.ConvertToken(bodyresourceType);
                    bodypropCount++;
                }

                if (bodyid != null)
                {
                    body["id"] = SourceExpressionConverter.ConvertToken(bodyid);
                    bodypropCount++;
                }

                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodytelecom != null)
                {
                    body["telecom"] = SourceExpressionConverter.ConvertToken(bodytelecom);
                    bodypropCount++;
                }

                if (bodygender != null)
                {
                    body["gender"] = SourceExpressionConverter.ConvertToken(bodygender);
                    bodypropCount++;
                }

                if (bodybirthDate != null)
                {
                    body["birthDate"] = SourceExpressionConverter.ConvertToken(bodybirthDate);
                    bodypropCount++;
                }

                if (bodyaddress != null)
                {
                    body["address"] = SourceExpressionConverter.ConvertToken(bodyaddress);
                    bodypropCount++;
                }

                var managingOrganizationObject = new JObject();
                var managingOrganizationObjectpropCount = 0;
                if (bodymanagingOrganizationreference != null)
                {
                    managingOrganizationObject["reference"] = SourceExpressionConverter.ConvertToken(bodymanagingOrganizationreference);
                    managingOrganizationObjectpropCount++;
                }

                if (bodymanagingOrganizationdisplay != null)
                {
                    managingOrganizationObject["display"] = SourceExpressionConverter.ConvertToken(bodymanagingOrganizationdisplay);
                    managingOrganizationObjectpropCount++;
                }

                if (managingOrganizationObjectpropCount > 0)
                {
                    body["managingOrganization"] = managingOrganizationObject;
                    bodypropCount++;
                }

                if (bodyactive != null)
                {
                    body["active"] = SourceExpressionConverter.ConvertToken(bodyactive);
                    bodypropCount++;
                }

                if (bodylink != null)
                {
                    body["link"] = SourceExpressionConverter.ConvertToken(bodylink);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<PUTPersonIdResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GETPersonIdVersionResponse> GETPersonIdVersion([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> vid)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(vid, nameof(vid), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/Person/{0}/_history/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(vid, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GETPersonIdVersionResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GETPersonIdHistoryResponse> GETPersonIdHistory([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/Person/{0}/_history", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GETPersonIdHistoryResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GETPersonHistoryResponse> GETPersonHistory()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Person/_history";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GETPersonHistoryResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GETPractitionerResponse> GETPractitioner([WorkflowExpression] Func<string> Count = null, [WorkflowExpression] Func<string> Sort = null, [WorkflowExpression] Func<string> patient = null)
        {
            SourceExpression.Validate(Count, nameof(Count), required: false);
            SourceExpression.Validate(Sort, nameof(Sort), required: false);
            SourceExpression.Validate(patient, nameof(patient), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Practitioner";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (Count != null)
                    callPayload.Queries["_count"] = SourceExpressionConverter.ConvertO(Count);
                if (Sort != null)
                    callPayload.Queries["_sort"] = SourceExpressionConverter.ConvertO(Sort);
                if (patient != null)
                    callPayload.Queries["patient"] = SourceExpressionConverter.ConvertO(patient);
                return callPayload;
            }

            return new ApiConnectionAction<GETPractitionerResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<POSTPractitionerResponse> POSTPractitioner([WorkflowExpression] Func<string> bodyresourceType = null, [WorkflowExpression] Func<bodyidentifierInputItem[]> bodyidentifier = null, [WorkflowExpression] Func<bool> bodyactive = null, [WorkflowExpression] Func<bodynameInputItem2[]> bodyname = null, [WorkflowExpression] Func<bodyaddressInputItem22[]> bodyaddress = null, [WorkflowExpression] Func<bodyqualificationInputItem[]> bodyqualification = null)
        {
            SourceExpression.Validate(bodyresourceType, nameof(bodyresourceType), required: false);
            SourceExpression.Validate(bodyidentifier, nameof(bodyidentifier), required: false);
            SourceExpression.Validate(bodyactive, nameof(bodyactive), required: false);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: false);
            SourceExpression.Validate(bodyaddress, nameof(bodyaddress), required: false);
            SourceExpression.Validate(bodyqualification, nameof(bodyqualification), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Practitioner";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyresourceType != null)
                {
                    body["resourceType"] = SourceExpressionConverter.ConvertToken(bodyresourceType);
                    bodypropCount++;
                }

                if (bodyidentifier != null)
                {
                    body["identifier"] = SourceExpressionConverter.ConvertToken(bodyidentifier);
                    bodypropCount++;
                }

                if (bodyactive != null)
                {
                    body["active"] = SourceExpressionConverter.ConvertToken(bodyactive);
                    bodypropCount++;
                }

                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodyaddress != null)
                {
                    body["address"] = SourceExpressionConverter.ConvertToken(bodyaddress);
                    bodypropCount++;
                }

                if (bodyqualification != null)
                {
                    body["qualification"] = SourceExpressionConverter.ConvertToken(bodyqualification);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<POSTPractitionerResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GETPractitionerIdResponse> GETPractitionerId([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/Practitioner/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GETPractitionerIdResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<DELETEPractitionerIdResponse> DELETEPractitionerId([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodyresourceType = null, [WorkflowExpression] Func<string> bodyid = null, [WorkflowExpression] Func<string> bodymetaversionId = null, [WorkflowExpression] Func<string> bodymetalastUpdated = null, [WorkflowExpression] Func<bodyidentifierInputItem[]> bodyidentifier = null, [WorkflowExpression] Func<bool> bodyactive = null, [WorkflowExpression] Func<bodynameInputItem2[]> bodyname = null, [WorkflowExpression] Func<bodytelecomInputItem2[]> bodytelecom = null, [WorkflowExpression] Func<bodyaddressInputItem222[]> bodyaddress = null, [WorkflowExpression] Func<string> bodygender = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(bodyresourceType, nameof(bodyresourceType), required: false);
            SourceExpression.Validate(bodyid, nameof(bodyid), required: false);
            SourceExpression.Validate(bodymetaversionId, nameof(bodymetaversionId), required: false);
            SourceExpression.Validate(bodymetalastUpdated, nameof(bodymetalastUpdated), required: false);
            SourceExpression.Validate(bodyidentifier, nameof(bodyidentifier), required: false);
            SourceExpression.Validate(bodyactive, nameof(bodyactive), required: false);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: false);
            SourceExpression.Validate(bodytelecom, nameof(bodytelecom), required: false);
            SourceExpression.Validate(bodyaddress, nameof(bodyaddress), required: false);
            SourceExpression.Validate(bodygender, nameof(bodygender), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/Practitioner/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyresourceType != null)
                {
                    body["resourceType"] = SourceExpressionConverter.ConvertToken(bodyresourceType);
                    bodypropCount++;
                }

                if (bodyid != null)
                {
                    body["id"] = SourceExpressionConverter.ConvertToken(bodyid);
                    bodypropCount++;
                }

                var metaObject = new JObject();
                var metaObjectpropCount = 0;
                if (bodymetaversionId != null)
                {
                    metaObject["versionId"] = SourceExpressionConverter.ConvertToken(bodymetaversionId);
                    metaObjectpropCount++;
                }

                if (bodymetalastUpdated != null)
                {
                    metaObject["lastUpdated"] = SourceExpressionConverter.ConvertToken(bodymetalastUpdated);
                    metaObjectpropCount++;
                }

                if (metaObjectpropCount > 0)
                {
                    body["meta"] = metaObject;
                    bodypropCount++;
                }

                if (bodyidentifier != null)
                {
                    body["identifier"] = SourceExpressionConverter.ConvertToken(bodyidentifier);
                    bodypropCount++;
                }

                if (bodyactive != null)
                {
                    body["active"] = SourceExpressionConverter.ConvertToken(bodyactive);
                    bodypropCount++;
                }

                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodytelecom != null)
                {
                    body["telecom"] = SourceExpressionConverter.ConvertToken(bodytelecom);
                    bodypropCount++;
                }

                if (bodyaddress != null)
                {
                    body["address"] = SourceExpressionConverter.ConvertToken(bodyaddress);
                    bodypropCount++;
                }

                if (bodygender != null)
                {
                    body["gender"] = SourceExpressionConverter.ConvertToken(bodygender);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DELETEPractitionerIdResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<PUTPractitionerIdResponse> PUTPractitionerId([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodyresourceType = null, [WorkflowExpression] Func<string> bodyid = null, [WorkflowExpression] Func<string> bodymetaversionId = null, [WorkflowExpression] Func<string> bodymetalastUpdated = null, [WorkflowExpression] Func<bodyidentifierInputItem[]> bodyidentifier = null, [WorkflowExpression] Func<bool> bodyactive = null, [WorkflowExpression] Func<bodynameInputItem2[]> bodyname = null, [WorkflowExpression] Func<bodytelecomInputItem2[]> bodytelecom = null, [WorkflowExpression] Func<bodyaddressInputItem222[]> bodyaddress = null, [WorkflowExpression] Func<string> bodygender = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(bodyresourceType, nameof(bodyresourceType), required: false);
            SourceExpression.Validate(bodyid, nameof(bodyid), required: false);
            SourceExpression.Validate(bodymetaversionId, nameof(bodymetaversionId), required: false);
            SourceExpression.Validate(bodymetalastUpdated, nameof(bodymetalastUpdated), required: false);
            SourceExpression.Validate(bodyidentifier, nameof(bodyidentifier), required: false);
            SourceExpression.Validate(bodyactive, nameof(bodyactive), required: false);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: false);
            SourceExpression.Validate(bodytelecom, nameof(bodytelecom), required: false);
            SourceExpression.Validate(bodyaddress, nameof(bodyaddress), required: false);
            SourceExpression.Validate(bodygender, nameof(bodygender), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/Practitioner/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyresourceType != null)
                {
                    body["resourceType"] = SourceExpressionConverter.ConvertToken(bodyresourceType);
                    bodypropCount++;
                }

                if (bodyid != null)
                {
                    body["id"] = SourceExpressionConverter.ConvertToken(bodyid);
                    bodypropCount++;
                }

                var metaObject = new JObject();
                var metaObjectpropCount = 0;
                if (bodymetaversionId != null)
                {
                    metaObject["versionId"] = SourceExpressionConverter.ConvertToken(bodymetaversionId);
                    metaObjectpropCount++;
                }

                if (bodymetalastUpdated != null)
                {
                    metaObject["lastUpdated"] = SourceExpressionConverter.ConvertToken(bodymetalastUpdated);
                    metaObjectpropCount++;
                }

                if (metaObjectpropCount > 0)
                {
                    body["meta"] = metaObject;
                    bodypropCount++;
                }

                if (bodyidentifier != null)
                {
                    body["identifier"] = SourceExpressionConverter.ConvertToken(bodyidentifier);
                    bodypropCount++;
                }

                if (bodyactive != null)
                {
                    body["active"] = SourceExpressionConverter.ConvertToken(bodyactive);
                    bodypropCount++;
                }

                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodytelecom != null)
                {
                    body["telecom"] = SourceExpressionConverter.ConvertToken(bodytelecom);
                    bodypropCount++;
                }

                if (bodyaddress != null)
                {
                    body["address"] = SourceExpressionConverter.ConvertToken(bodyaddress);
                    bodypropCount++;
                }

                if (bodygender != null)
                {
                    body["gender"] = SourceExpressionConverter.ConvertToken(bodygender);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<PUTPractitionerIdResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GETPractitionerIdVersionResponse> GETPractitionerIdVersion([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> vid)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(vid, nameof(vid), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/Practitioner/{0}/_history/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(vid, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GETPractitionerIdVersionResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GETPractitionerIdHistoryResponse> GETPractitionerIdHistory([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/Practitioner/{0}/_history", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GETPractitionerIdHistoryResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GETPractitionerHistoryResponse> GETPractitionerHistory()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Practitioner/_history";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GETPractitionerHistoryResponse>(BuildSourceInput);
        }
    }

    public class FhirbaseTriggers([ConnectionName] string connectionId)
    {
    }

    public class GETAppointmentResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GETAppointmentResponseMetaType Meta { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("link")]
        public GETAppointmentResponseLinkTypeItem[] Link { get; set; }

        [JsonProperty("entry")]
        public GETAppointmentResponseEntryTypeItem[] Entry { get; set; }
    }

    public class GETAppointmentResponseMetaType
    {
        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GETAppointmentResponseLinkTypeItem
    {
        [JsonProperty("relation")]
        public string Relation { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class GETAppointmentResponseEntryTypeItem
    {
        [JsonProperty("fullUrl")]
        public string FullUrl { get; set; }

        [JsonProperty("resource")]
        public GETAppointmentResponseEntryTypeItemResourceType Resource { get; set; }

        [JsonProperty("search")]
        public GETAppointmentResponseEntryTypeItemSearchType Search { get; set; }
    }

    public class GETAppointmentResponseEntryTypeItemResourceType
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GETAppointmentResponseEntryTypeItemResourceTypeMetaType Meta { get; set; }

        [JsonProperty("text")]
        public GETAppointmentResponseEntryTypeItemResourceTypeTextType Text { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("serviceCategory")]
        public GETAppointmentResponseEntryTypeItemResourceTypeServiceCategoryTypeItem[] ServiceCategory { get; set; }

        [JsonProperty("serviceType")]
        public GETAppointmentResponseEntryTypeItemResourceTypeServiceTypeTypeItem[] ServiceType { get; set; }

        [JsonProperty("specialty")]
        public GETAppointmentResponseEntryTypeItemResourceTypeSpecialtyTypeItem[] Specialty { get; set; }

        [JsonProperty("appointmentType")]
        public GETAppointmentResponseEntryTypeItemResourceTypeAppointmentTypeType AppointmentType { get; set; }

        [JsonProperty("reasonReference")]
        public GETAppointmentResponseEntryTypeItemResourceTypeReasonReferenceTypeItem[] ReasonReference { get; set; }

        [JsonProperty("priority")]
        public int Priority { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("comment")]
        public string Comment { get; set; }

        [JsonProperty("basedOn")]
        public GETAppointmentResponseEntryTypeItemResourceTypeBasedOnTypeItem[] BasedOn { get; set; }

        [JsonProperty("participant")]
        public GETAppointmentResponseEntryTypeItemResourceTypeParticipantTypeItem[] Participant { get; set; }
    }

    public class GETAppointmentResponseEntryTypeItemResourceTypeMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GETAppointmentResponseEntryTypeItemResourceTypeTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("div")]
        public string Div { get; set; }
    }

    public class GETAppointmentResponseEntryTypeItemResourceTypeServiceCategoryTypeItem
    {
        [JsonProperty("coding")]
        public GETAppointmentResponseEntryTypeItemResourceTypeServiceCategoryTypeItemCodingTypeItem[] Coding { get; set; }
    }

    public class GETAppointmentResponseEntryTypeItemResourceTypeServiceCategoryTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETAppointmentResponseEntryTypeItemResourceTypeServiceTypeTypeItem
    {
        [JsonProperty("coding")]
        public GETAppointmentResponseEntryTypeItemResourceTypeServiceTypeTypeItemCodingTypeItem[] Coding { get; set; }
    }

    public class GETAppointmentResponseEntryTypeItemResourceTypeServiceTypeTypeItemCodingTypeItem
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETAppointmentResponseEntryTypeItemResourceTypeSpecialtyTypeItem
    {
        [JsonProperty("coding")]
        public GETAppointmentResponseEntryTypeItemResourceTypeSpecialtyTypeItemCodingTypeItem[] Coding { get; set; }
    }

    public class GETAppointmentResponseEntryTypeItemResourceTypeSpecialtyTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETAppointmentResponseEntryTypeItemResourceTypeAppointmentTypeType
    {
        [JsonProperty("coding")]
        public GETAppointmentResponseEntryTypeItemResourceTypeAppointmentTypeTypeCodingTypeItem[] Coding { get; set; }
    }

    public class GETAppointmentResponseEntryTypeItemResourceTypeAppointmentTypeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETAppointmentResponseEntryTypeItemResourceTypeReasonReferenceTypeItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETAppointmentResponseEntryTypeItemResourceTypeBasedOnTypeItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class GETAppointmentResponseEntryTypeItemResourceTypeParticipantTypeItem
    {
        [JsonProperty("actor")]
        public GETAppointmentResponseEntryTypeItemResourceTypeParticipantTypeItemActorType Actor { get; set; }

        [JsonProperty("required")]
        public string Required { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("type")]
        public GETAppointmentResponseEntryTypeItemResourceTypeParticipantTypeItemTypeTypeItem[] Type { get; set; }
    }

    public class GETAppointmentResponseEntryTypeItemResourceTypeParticipantTypeItemActorType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETAppointmentResponseEntryTypeItemResourceTypeParticipantTypeItemTypeTypeItem
    {
        [JsonProperty("coding")]
        public GETAppointmentResponseEntryTypeItemResourceTypeParticipantTypeItemTypeTypeItemCodingTypeItem[] Coding { get; set; }
    }

    public class GETAppointmentResponseEntryTypeItemResourceTypeParticipantTypeItemTypeTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class GETAppointmentResponseEntryTypeItemSearchType
    {
        [JsonProperty("mode")]
        public string Mode { get; set; }
    }

    public class POSTAppointmentResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public POSTAppointmentResponseMetaType Meta { get; set; }

        [JsonProperty("text")]
        public POSTAppointmentResponseTextType Text { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("participant")]
        public POSTAppointmentResponseParticipantTypeItem[] Participant { get; set; }
    }

    public class POSTAppointmentResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class POSTAppointmentResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("div")]
        public string Div { get; set; }
    }

    public class POSTAppointmentResponseParticipantTypeItem
    {
        [JsonProperty("actor")]
        public POSTAppointmentResponseParticipantTypeItemActorType Actor { get; set; }

        [JsonProperty("required")]
        public string Required { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("type")]
        public POSTAppointmentResponseParticipantTypeItemTypeTypeItem[] Type { get; set; }
    }

    public class POSTAppointmentResponseParticipantTypeItemActorType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class POSTAppointmentResponseParticipantTypeItemTypeTypeItem
    {
        [JsonProperty("coding")]
        public POSTAppointmentResponseParticipantTypeItemTypeTypeItemCodingTypeItem[] Coding { get; set; }
    }

    public class POSTAppointmentResponseParticipantTypeItemTypeTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class bodyserviceCategoryInputItem
    {
        [JsonProperty("coding")]
        public bodyserviceCategoryInputItemCodingTypeItem[] Coding { get; set; }
    }

    public class bodyserviceCategoryInputItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class bodyserviceTypeInputItem
    {
        [JsonProperty("coding")]
        public bodyserviceTypeInputItemCodingTypeItem[] Coding { get; set; }
    }

    public class bodyserviceTypeInputItemCodingTypeItem
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class bodyspecialtyInputItem
    {
        [JsonProperty("coding")]
        public bodyspecialtyInputItemCodingTypeItem[] Coding { get; set; }
    }

    public class bodyspecialtyInputItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class bodyappointmentTypecodingInputItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class bodyreasonReferenceInputItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class bodybasedOnInputItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class bodyparticipantInputItem
    {
        [JsonProperty("actor")]
        public bodyparticipantInputItemActorType Actor { get; set; }

        [JsonProperty("required")]
        public string Required { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("type")]
        public bodyparticipantInputItemTypeTypeItem[] Type { get; set; }
    }

    public class bodyparticipantInputItemActorType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class bodyparticipantInputItemTypeTypeItem
    {
        [JsonProperty("coding")]
        public bodyparticipantInputItemTypeTypeItemCodingTypeItem[] Coding { get; set; }
    }

    public class bodyparticipantInputItemTypeTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class GETAppointmentIdResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GETAppointmentIdResponseMetaType Meta { get; set; }

        [JsonProperty("text")]
        public GETAppointmentIdResponseTextType Text { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("participant")]
        public GETAppointmentIdResponseParticipantTypeItem[] Participant { get; set; }
    }

    public class GETAppointmentIdResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GETAppointmentIdResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("div")]
        public string Div { get; set; }
    }

    public class GETAppointmentIdResponseParticipantTypeItem
    {
        [JsonProperty("actor")]
        public GETAppointmentIdResponseParticipantTypeItemActorType Actor { get; set; }

        [JsonProperty("required")]
        public string Required { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("type")]
        public GETAppointmentIdResponseParticipantTypeItemTypeTypeItem[] Type { get; set; }
    }

    public class GETAppointmentIdResponseParticipantTypeItemActorType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETAppointmentIdResponseParticipantTypeItemTypeTypeItem
    {
        [JsonProperty("coding")]
        public GETAppointmentIdResponseParticipantTypeItemTypeTypeItemCodingTypeItem[] Coding { get; set; }
    }

    public class GETAppointmentIdResponseParticipantTypeItemTypeTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class DELETEAppointmentIdResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public DELETEAppointmentIdResponseMetaType Meta { get; set; }

        [JsonProperty("text")]
        public DELETEAppointmentIdResponseTextType Text { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("participant")]
        public DELETEAppointmentIdResponseParticipantTypeItem[] Participant { get; set; }
    }

    public class DELETEAppointmentIdResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class DELETEAppointmentIdResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("div")]
        public string Div { get; set; }
    }

    public class DELETEAppointmentIdResponseParticipantTypeItem
    {
        [JsonProperty("actor")]
        public DELETEAppointmentIdResponseParticipantTypeItemActorType Actor { get; set; }

        [JsonProperty("required")]
        public string Required { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("type")]
        public DELETEAppointmentIdResponseParticipantTypeItemTypeTypeItem[] Type { get; set; }
    }

    public class DELETEAppointmentIdResponseParticipantTypeItemActorType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DELETEAppointmentIdResponseParticipantTypeItemTypeTypeItem
    {
        [JsonProperty("coding")]
        public DELETEAppointmentIdResponseParticipantTypeItemTypeTypeItemCodingTypeItem[] Coding { get; set; }
    }

    public class DELETEAppointmentIdResponseParticipantTypeItemTypeTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class PUTAppointmentIdResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public PUTAppointmentIdResponseMetaType Meta { get; set; }

        [JsonProperty("text")]
        public PUTAppointmentIdResponseTextType Text { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("participant")]
        public PUTAppointmentIdResponseParticipantTypeItem[] Participant { get; set; }
    }

    public class PUTAppointmentIdResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class PUTAppointmentIdResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("div")]
        public string Div { get; set; }
    }

    public class PUTAppointmentIdResponseParticipantTypeItem
    {
        [JsonProperty("actor")]
        public PUTAppointmentIdResponseParticipantTypeItemActorType Actor { get; set; }

        [JsonProperty("required")]
        public string Required { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("type")]
        public PUTAppointmentIdResponseParticipantTypeItemTypeTypeItem[] Type { get; set; }
    }

    public class PUTAppointmentIdResponseParticipantTypeItemActorType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PUTAppointmentIdResponseParticipantTypeItemTypeTypeItem
    {
        [JsonProperty("coding")]
        public PUTAppointmentIdResponseParticipantTypeItemTypeTypeItemCodingTypeItem[] Coding { get; set; }
    }

    public class PUTAppointmentIdResponseParticipantTypeItemTypeTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class GETAppointmentIdVERSIONResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GETAppointmentIdVERSIONResponseMetaType Meta { get; set; }

        [JsonProperty("text")]
        public GETAppointmentIdVERSIONResponseTextType Text { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("participant")]
        public GETAppointmentIdVERSIONResponseParticipantTypeItem[] Participant { get; set; }
    }

    public class GETAppointmentIdVERSIONResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GETAppointmentIdVERSIONResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("div")]
        public string Div { get; set; }
    }

    public class GETAppointmentIdVERSIONResponseParticipantTypeItem
    {
        [JsonProperty("actor")]
        public GETAppointmentIdVERSIONResponseParticipantTypeItemActorType Actor { get; set; }

        [JsonProperty("required")]
        public string Required { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("type")]
        public GETAppointmentIdVERSIONResponseParticipantTypeItemTypeTypeItem[] Type { get; set; }
    }

    public class GETAppointmentIdVERSIONResponseParticipantTypeItemActorType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETAppointmentIdVERSIONResponseParticipantTypeItemTypeTypeItem
    {
        [JsonProperty("coding")]
        public GETAppointmentIdVERSIONResponseParticipantTypeItemTypeTypeItemCodingTypeItem[] Coding { get; set; }
    }

    public class GETAppointmentIdVERSIONResponseParticipantTypeItemTypeTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class GETAppointmentIdHistoryResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GETAppointmentIdHistoryResponseMetaType Meta { get; set; }

        [JsonProperty("text")]
        public GETAppointmentIdHistoryResponseTextType Text { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("participant")]
        public GETAppointmentIdHistoryResponseParticipantTypeItem[] Participant { get; set; }
    }

    public class GETAppointmentIdHistoryResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GETAppointmentIdHistoryResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("div")]
        public string Div { get; set; }
    }

    public class GETAppointmentIdHistoryResponseParticipantTypeItem
    {
        [JsonProperty("actor")]
        public GETAppointmentIdHistoryResponseParticipantTypeItemActorType Actor { get; set; }

        [JsonProperty("required")]
        public string Required { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("type")]
        public GETAppointmentIdHistoryResponseParticipantTypeItemTypeTypeItem[] Type { get; set; }
    }

    public class GETAppointmentIdHistoryResponseParticipantTypeItemActorType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETAppointmentIdHistoryResponseParticipantTypeItemTypeTypeItem
    {
        [JsonProperty("coding")]
        public GETAppointmentIdHistoryResponseParticipantTypeItemTypeTypeItemCodingTypeItem[] Coding { get; set; }
    }

    public class GETAppointmentIdHistoryResponseParticipantTypeItemTypeTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class GETAppointmentHistoryResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GETAppointmentHistoryResponseMetaType Meta { get; set; }

        [JsonProperty("text")]
        public GETAppointmentHistoryResponseTextType Text { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("participant")]
        public GETAppointmentHistoryResponseParticipantTypeItem[] Participant { get; set; }
    }

    public class GETAppointmentHistoryResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GETAppointmentHistoryResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("div")]
        public string Div { get; set; }
    }

    public class GETAppointmentHistoryResponseParticipantTypeItem
    {
        [JsonProperty("actor")]
        public GETAppointmentHistoryResponseParticipantTypeItemActorType Actor { get; set; }

        [JsonProperty("required")]
        public string Required { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("type")]
        public GETAppointmentHistoryResponseParticipantTypeItemTypeTypeItem[] Type { get; set; }
    }

    public class GETAppointmentHistoryResponseParticipantTypeItemActorType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETAppointmentHistoryResponseParticipantTypeItemTypeTypeItem
    {
        [JsonProperty("coding")]
        public GETAppointmentHistoryResponseParticipantTypeItemTypeTypeItemCodingTypeItem[] Coding { get; set; }
    }

    public class GETAppointmentHistoryResponseParticipantTypeItemTypeTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class GETAppointmentResponseResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GETAppointmentResponseResponseMetaType Meta { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("link")]
        public GETAppointmentResponseResponseLinkTypeItem[] Link { get; set; }
    }

    public class GETAppointmentResponseResponseMetaType
    {
        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GETAppointmentResponseResponseLinkTypeItem
    {
        [JsonProperty("relation")]
        public string Relation { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class POSTAppointmentResponseResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public POSTAppointmentResponseResponseMetaType Meta { get; set; }

        [JsonProperty("text")]
        public POSTAppointmentResponseResponseTextType Text { get; set; }

        [JsonProperty("appointment")]
        public POSTAppointmentResponseResponseAppointmentType Appointment { get; set; }

        [JsonProperty("actor")]
        public POSTAppointmentResponseResponseActorType Actor { get; set; }

        [JsonProperty("participantStatus")]
        public string ParticipantStatus { get; set; }
    }

    public class POSTAppointmentResponseResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class POSTAppointmentResponseResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("div")]
        public string Div { get; set; }
    }

    public class POSTAppointmentResponseResponseAppointmentType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class POSTAppointmentResponseResponseActorType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETAppointmentResponseIdResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GETAppointmentResponseIdResponseMetaType Meta { get; set; }

        [JsonProperty("text")]
        public GETAppointmentResponseIdResponseTextType Text { get; set; }

        [JsonProperty("appointment")]
        public GETAppointmentResponseIdResponseAppointmentType Appointment { get; set; }

        [JsonProperty("actor")]
        public GETAppointmentResponseIdResponseActorType Actor { get; set; }

        [JsonProperty("participantStatus")]
        public string ParticipantStatus { get; set; }
    }

    public class GETAppointmentResponseIdResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GETAppointmentResponseIdResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("div")]
        public string Div { get; set; }
    }

    public class GETAppointmentResponseIdResponseAppointmentType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETAppointmentResponseIdResponseActorType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DELETEAppointmentResponseIdResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public DELETEAppointmentResponseIdResponseMetaType Meta { get; set; }

        [JsonProperty("text")]
        public DELETEAppointmentResponseIdResponseTextType Text { get; set; }

        [JsonProperty("appointment")]
        public DELETEAppointmentResponseIdResponseAppointmentType Appointment { get; set; }

        [JsonProperty("actor")]
        public DELETEAppointmentResponseIdResponseActorType Actor { get; set; }

        [JsonProperty("participantStatus")]
        public string ParticipantStatus { get; set; }
    }

    public class DELETEAppointmentResponseIdResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class DELETEAppointmentResponseIdResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("div")]
        public string Div { get; set; }
    }

    public class DELETEAppointmentResponseIdResponseAppointmentType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DELETEAppointmentResponseIdResponseActorType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PUTAppointmentResponseIdResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public PUTAppointmentResponseIdResponseMetaType Meta { get; set; }

        [JsonProperty("text")]
        public PUTAppointmentResponseIdResponseTextType Text { get; set; }

        [JsonProperty("appointment")]
        public PUTAppointmentResponseIdResponseAppointmentType Appointment { get; set; }

        [JsonProperty("actor")]
        public PUTAppointmentResponseIdResponseActorType Actor { get; set; }

        [JsonProperty("participantStatus")]
        public string ParticipantStatus { get; set; }
    }

    public class PUTAppointmentResponseIdResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class PUTAppointmentResponseIdResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("div")]
        public string Div { get; set; }
    }

    public class PUTAppointmentResponseIdResponseAppointmentType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PUTAppointmentResponseIdResponseActorType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETAppointmentResponseIdVersionResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GETAppointmentResponseIdVersionResponseMetaType Meta { get; set; }

        [JsonProperty("text")]
        public GETAppointmentResponseIdVersionResponseTextType Text { get; set; }

        [JsonProperty("appointment")]
        public GETAppointmentResponseIdVersionResponseAppointmentType Appointment { get; set; }

        [JsonProperty("actor")]
        public GETAppointmentResponseIdVersionResponseActorType Actor { get; set; }

        [JsonProperty("participantStatus")]
        public string ParticipantStatus { get; set; }
    }

    public class GETAppointmentResponseIdVersionResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GETAppointmentResponseIdVersionResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("div")]
        public string Div { get; set; }
    }

    public class GETAppointmentResponseIdVersionResponseAppointmentType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETAppointmentResponseIdVersionResponseActorType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETAppointmentResponseIdHistoryResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GETAppointmentResponseIdHistoryResponseMetaType Meta { get; set; }

        [JsonProperty("text")]
        public GETAppointmentResponseIdHistoryResponseTextType Text { get; set; }

        [JsonProperty("appointment")]
        public GETAppointmentResponseIdHistoryResponseAppointmentType Appointment { get; set; }

        [JsonProperty("actor")]
        public GETAppointmentResponseIdHistoryResponseActorType Actor { get; set; }

        [JsonProperty("participantStatus")]
        public string ParticipantStatus { get; set; }
    }

    public class GETAppointmentResponseIdHistoryResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GETAppointmentResponseIdHistoryResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("div")]
        public string Div { get; set; }
    }

    public class GETAppointmentResponseIdHistoryResponseAppointmentType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETAppointmentResponseIdHistoryResponseActorType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETAppointmentResponseHistoryResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GETAppointmentResponseHistoryResponseMetaType Meta { get; set; }

        [JsonProperty("text")]
        public GETAppointmentResponseHistoryResponseTextType Text { get; set; }

        [JsonProperty("appointment")]
        public GETAppointmentResponseHistoryResponseAppointmentType Appointment { get; set; }

        [JsonProperty("actor")]
        public GETAppointmentResponseHistoryResponseActorType Actor { get; set; }

        [JsonProperty("participantStatus")]
        public string ParticipantStatus { get; set; }
    }

    public class GETAppointmentResponseHistoryResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GETAppointmentResponseHistoryResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("div")]
        public string Div { get; set; }
    }

    public class GETAppointmentResponseHistoryResponseAppointmentType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETAppointmentResponseHistoryResponseActorType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETDeviceResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GETDeviceResponseMetaType Meta { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("link")]
        public GETDeviceResponseLinkTypeItem[] Link { get; set; }

        [JsonProperty("entry")]
        public GETDeviceResponseEntryTypeItem[] Entry { get; set; }
    }

    public class GETDeviceResponseMetaType
    {
        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GETDeviceResponseLinkTypeItem
    {
        [JsonProperty("relation")]
        public string Relation { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class GETDeviceResponseEntryTypeItem
    {
        [JsonProperty("fullUrl")]
        public string FullUrl { get; set; }

        [JsonProperty("resource")]
        public GETDeviceResponseEntryTypeItemResourceType Resource { get; set; }

        [JsonProperty("search")]
        public GETDeviceResponseEntryTypeItemSearchType Search { get; set; }
    }

    public class GETDeviceResponseEntryTypeItemResourceType
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GETDeviceResponseEntryTypeItemResourceTypeMetaType Meta { get; set; }

        [JsonProperty("udiCarrier")]
        public GETDeviceResponseEntryTypeItemResourceTypeUdiCarrierTypeItem[] UdiCarrier { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("distinctIdentifier")]
        public string DistinctIdentifier { get; set; }

        [JsonProperty("manufactureDate")]
        public string ManufactureDate { get; set; }

        [JsonProperty("expirationDate")]
        public string ExpirationDate { get; set; }

        [JsonProperty("lotNumber")]
        public string LotNumber { get; set; }

        [JsonProperty("serialNumber")]
        public string SerialNumber { get; set; }

        [JsonProperty("deviceName")]
        public GETDeviceResponseEntryTypeItemResourceTypeDeviceNameTypeItem[] DeviceName { get; set; }

        [JsonProperty("type")]
        public GETDeviceResponseEntryTypeItemResourceTypeTypeType Type { get; set; }

        [JsonProperty("patient")]
        public GETDeviceResponseEntryTypeItemResourceTypePatientType Patient { get; set; }

        [JsonProperty("text")]
        public GETDeviceResponseEntryTypeItemResourceTypeTextType Text { get; set; }

        [JsonProperty("identifier")]
        public GETDeviceResponseEntryTypeItemResourceTypeIdentifierTypeItem[] Identifier { get; set; }
    }

    public class GETDeviceResponseEntryTypeItemResourceTypeMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GETDeviceResponseEntryTypeItemResourceTypeUdiCarrierTypeItem
    {
        [JsonProperty("deviceIdentifier")]
        public string DeviceIdentifier { get; set; }

        [JsonProperty("carrierHRF")]
        public string CarrierHRF { get; set; }
    }

    public class GETDeviceResponseEntryTypeItemResourceTypeDeviceNameTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class GETDeviceResponseEntryTypeItemResourceTypeTypeType
    {
        [JsonProperty("coding")]
        public GETDeviceResponseEntryTypeItemResourceTypeTypeTypeCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class GETDeviceResponseEntryTypeItemResourceTypeTypeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETDeviceResponseEntryTypeItemResourceTypePatientType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class GETDeviceResponseEntryTypeItemResourceTypeTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("div")]
        public string Div { get; set; }
    }

    public class GETDeviceResponseEntryTypeItemResourceTypeIdentifierTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class GETDeviceResponseEntryTypeItemSearchType
    {
        [JsonProperty("mode")]
        public string Mode { get; set; }
    }

    public class POSTDeviceResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public POSTDeviceResponseMetaType Meta { get; set; }

        [JsonProperty("udiCarrier")]
        public POSTDeviceResponseUdiCarrierTypeItem[] UdiCarrier { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("distinctIdentifier")]
        public string DistinctIdentifier { get; set; }

        [JsonProperty("manufactureDate")]
        public string ManufactureDate { get; set; }

        [JsonProperty("expirationDate")]
        public string ExpirationDate { get; set; }

        [JsonProperty("lotNumber")]
        public string LotNumber { get; set; }

        [JsonProperty("serialNumber")]
        public string SerialNumber { get; set; }

        [JsonProperty("deviceName")]
        public POSTDeviceResponseDeviceNameTypeItem[] DeviceName { get; set; }

        [JsonProperty("type")]
        public POSTDeviceResponseTypeType Type { get; set; }

        [JsonProperty("patient")]
        public POSTDeviceResponsePatientType Patient { get; set; }
    }

    public class POSTDeviceResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class POSTDeviceResponseUdiCarrierTypeItem
    {
        [JsonProperty("deviceIdentifier")]
        public string DeviceIdentifier { get; set; }

        [JsonProperty("carrierHRF")]
        public string CarrierHRF { get; set; }
    }

    public class POSTDeviceResponseDeviceNameTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class POSTDeviceResponseTypeType
    {
        [JsonProperty("coding")]
        public POSTDeviceResponseTypeTypeCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class POSTDeviceResponseTypeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class POSTDeviceResponsePatientType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class bodyudiCarrierInputItem
    {
        [JsonProperty("deviceIdentifier")]
        public string DeviceIdentifier { get; set; }

        [JsonProperty("carrierHRF")]
        public string CarrierHRF { get; set; }
    }

    public class bodydeviceNameInputItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class bodytypecodingInputItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETDeviceIdResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GETDeviceIdResponseMetaType Meta { get; set; }

        [JsonProperty("udiCarrier")]
        public GETDeviceIdResponseUdiCarrierTypeItem[] UdiCarrier { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("distinctIdentifier")]
        public string DistinctIdentifier { get; set; }

        [JsonProperty("manufactureDate")]
        public string ManufactureDate { get; set; }

        [JsonProperty("expirationDate")]
        public string ExpirationDate { get; set; }

        [JsonProperty("lotNumber")]
        public string LotNumber { get; set; }

        [JsonProperty("serialNumber")]
        public string SerialNumber { get; set; }

        [JsonProperty("deviceName")]
        public GETDeviceIdResponseDeviceNameTypeItem[] DeviceName { get; set; }

        [JsonProperty("type")]
        public GETDeviceIdResponseTypeType Type { get; set; }

        [JsonProperty("patient")]
        public GETDeviceIdResponsePatientType Patient { get; set; }
    }

    public class GETDeviceIdResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GETDeviceIdResponseUdiCarrierTypeItem
    {
        [JsonProperty("deviceIdentifier")]
        public string DeviceIdentifier { get; set; }

        [JsonProperty("carrierHRF")]
        public string CarrierHRF { get; set; }
    }

    public class GETDeviceIdResponseDeviceNameTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class GETDeviceIdResponseTypeType
    {
        [JsonProperty("coding")]
        public GETDeviceIdResponseTypeTypeCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class GETDeviceIdResponseTypeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETDeviceIdResponsePatientType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class DELETEDeviceIdResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public DELETEDeviceIdResponseMetaType Meta { get; set; }

        [JsonProperty("text")]
        public DELETEDeviceIdResponseTextType Text { get; set; }

        [JsonProperty("identifier")]
        public DELETEDeviceIdResponseIdentifierTypeItem[] Identifier { get; set; }
    }

    public class DELETEDeviceIdResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class DELETEDeviceIdResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("div")]
        public string Div { get; set; }
    }

    public class DELETEDeviceIdResponseIdentifierTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class bodyidentifierInputItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class PUTDeviceIdResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public PUTDeviceIdResponseMetaType Meta { get; set; }

        [JsonProperty("text")]
        public PUTDeviceIdResponseTextType Text { get; set; }

        [JsonProperty("identifier")]
        public PUTDeviceIdResponseIdentifierTypeItem[] Identifier { get; set; }
    }

    public class PUTDeviceIdResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class PUTDeviceIdResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("div")]
        public string Div { get; set; }
    }

    public class PUTDeviceIdResponseIdentifierTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class GETDeviceIdVERSIONResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GETDeviceIdVERSIONResponseMetaType Meta { get; set; }

        [JsonProperty("text")]
        public GETDeviceIdVERSIONResponseTextType Text { get; set; }

        [JsonProperty("identifier")]
        public GETDeviceIdVERSIONResponseIdentifierTypeItem[] Identifier { get; set; }
    }

    public class GETDeviceIdVERSIONResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GETDeviceIdVERSIONResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("div")]
        public string Div { get; set; }
    }

    public class GETDeviceIdVERSIONResponseIdentifierTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class GETDeviceIdHISTORYResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GETDeviceIdHISTORYResponseMetaType Meta { get; set; }

        [JsonProperty("text")]
        public GETDeviceIdHISTORYResponseTextType Text { get; set; }

        [JsonProperty("identifier")]
        public GETDeviceIdHISTORYResponseIdentifierTypeItem[] Identifier { get; set; }
    }

    public class GETDeviceIdHISTORYResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GETDeviceIdHISTORYResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("div")]
        public string Div { get; set; }
    }

    public class GETDeviceIdHISTORYResponseIdentifierTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class GETDeviceHISTORYResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GETDeviceHISTORYResponseMetaType Meta { get; set; }

        [JsonProperty("text")]
        public GETDeviceHISTORYResponseTextType Text { get; set; }

        [JsonProperty("identifier")]
        public GETDeviceHISTORYResponseIdentifierTypeItem[] Identifier { get; set; }
    }

    public class GETDeviceHISTORYResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GETDeviceHISTORYResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("div")]
        public string Div { get; set; }
    }

    public class GETDeviceHISTORYResponseIdentifierTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class GETEncounterResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GETEncounterResponseMetaType Meta { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("link")]
        public GETEncounterResponseLinkTypeItem[] Link { get; set; }

        [JsonProperty("entry")]
        public GETEncounterResponseEntryTypeItem[] Entry { get; set; }
    }

    public class GETEncounterResponseMetaType
    {
        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GETEncounterResponseLinkTypeItem
    {
        [JsonProperty("relation")]
        public string Relation { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class GETEncounterResponseEntryTypeItem
    {
        [JsonProperty("fullUrl")]
        public string FullUrl { get; set; }

        [JsonProperty("resource")]
        public GETEncounterResponseEntryTypeItemResourceType Resource { get; set; }

        [JsonProperty("search")]
        public GETEncounterResponseEntryTypeItemSearchType Search { get; set; }
    }

    public class GETEncounterResponseEntryTypeItemResourceType
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GETEncounterResponseEntryTypeItemResourceTypeMetaType Meta { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("class")]
        public GETEncounterResponseEntryTypeItemResourceTypeClassType Class { get; set; }

        [JsonProperty("type")]
        public GETEncounterResponseEntryTypeItemResourceTypeTypeTypeItem[] Type { get; set; }

        [JsonProperty("subject")]
        public GETEncounterResponseEntryTypeItemResourceTypeSubjectType Subject { get; set; }

        [JsonProperty("participant")]
        public GETEncounterResponseEntryTypeItemResourceTypeParticipantTypeItem[] Participant { get; set; }

        [JsonProperty("period")]
        public GETEncounterResponseEntryTypeItemResourceTypePeriodType Period { get; set; }

        [JsonProperty("serviceProvider")]
        public GETEncounterResponseEntryTypeItemResourceTypeServiceProviderType ServiceProvider { get; set; }

        [JsonProperty("reasonCode")]
        public GETEncounterResponseEntryTypeItemResourceTypeReasonCodeTypeItem[] ReasonCode { get; set; }
    }

    public class GETEncounterResponseEntryTypeItemResourceTypeMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GETEncounterResponseEntryTypeItemResourceTypeClassType
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class GETEncounterResponseEntryTypeItemResourceTypeTypeTypeItem
    {
        [JsonProperty("coding")]
        public GETEncounterResponseEntryTypeItemResourceTypeTypeTypeItemCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class GETEncounterResponseEntryTypeItemResourceTypeTypeTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETEncounterResponseEntryTypeItemResourceTypeSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETEncounterResponseEntryTypeItemResourceTypeParticipantTypeItem
    {
        [JsonProperty("individual")]
        public GETEncounterResponseEntryTypeItemResourceTypeParticipantTypeItemIndividualType Individual { get; set; }
    }

    public class GETEncounterResponseEntryTypeItemResourceTypeParticipantTypeItemIndividualType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETEncounterResponseEntryTypeItemResourceTypePeriodType
    {
        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }
    }

    public class GETEncounterResponseEntryTypeItemResourceTypeServiceProviderType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETEncounterResponseEntryTypeItemResourceTypeReasonCodeTypeItem
    {
        [JsonProperty("coding")]
        public GETEncounterResponseEntryTypeItemResourceTypeReasonCodeTypeItemCodingTypeItem[] Coding { get; set; }
    }

    public class GETEncounterResponseEntryTypeItemResourceTypeReasonCodeTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETEncounterResponseEntryTypeItemSearchType
    {
        [JsonProperty("mode")]
        public string Mode { get; set; }
    }

    public class POSTEncounterResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public POSTEncounterResponseMetaType Meta { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("class")]
        public POSTEncounterResponseClassType Class { get; set; }

        [JsonProperty("type")]
        public POSTEncounterResponseTypeTypeItem[] Type { get; set; }

        [JsonProperty("subject")]
        public POSTEncounterResponseSubjectType Subject { get; set; }

        [JsonProperty("participant")]
        public POSTEncounterResponseParticipantTypeItem[] Participant { get; set; }

        [JsonProperty("period")]
        public POSTEncounterResponsePeriodType Period { get; set; }

        [JsonProperty("serviceProvider")]
        public POSTEncounterResponseServiceProviderType ServiceProvider { get; set; }
    }

    public class POSTEncounterResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class POSTEncounterResponseClassType
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class POSTEncounterResponseTypeTypeItem
    {
        [JsonProperty("coding")]
        public POSTEncounterResponseTypeTypeItemCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class POSTEncounterResponseTypeTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class POSTEncounterResponseSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class POSTEncounterResponseParticipantTypeItem
    {
        [JsonProperty("individual")]
        public POSTEncounterResponseParticipantTypeItemIndividualType Individual { get; set; }
    }

    public class POSTEncounterResponseParticipantTypeItemIndividualType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class POSTEncounterResponsePeriodType
    {
        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }
    }

    public class POSTEncounterResponseServiceProviderType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class bodytypeInputItem
    {
        [JsonProperty("coding")]
        public bodytypeInputItemCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class bodytypeInputItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class bodyparticipantInputItem2
    {
        [JsonProperty("individual")]
        public bodyparticipantInputItemIndividualType Individual { get; set; }
    }

    public class bodyparticipantInputItemIndividualType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETEncounterIdResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GETEncounterIdResponseMetaType Meta { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("class")]
        public GETEncounterIdResponseClassType Class { get; set; }

        [JsonProperty("type")]
        public GETEncounterIdResponseTypeTypeItem[] Type { get; set; }

        [JsonProperty("subject")]
        public GETEncounterIdResponseSubjectType Subject { get; set; }

        [JsonProperty("participant")]
        public GETEncounterIdResponseParticipantTypeItem[] Participant { get; set; }

        [JsonProperty("period")]
        public GETEncounterIdResponsePeriodType Period { get; set; }

        [JsonProperty("serviceProvider")]
        public GETEncounterIdResponseServiceProviderType ServiceProvider { get; set; }
    }

    public class GETEncounterIdResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GETEncounterIdResponseClassType
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class GETEncounterIdResponseTypeTypeItem
    {
        [JsonProperty("coding")]
        public GETEncounterIdResponseTypeTypeItemCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class GETEncounterIdResponseTypeTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETEncounterIdResponseSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETEncounterIdResponseParticipantTypeItem
    {
        [JsonProperty("individual")]
        public GETEncounterIdResponseParticipantTypeItemIndividualType Individual { get; set; }
    }

    public class GETEncounterIdResponseParticipantTypeItemIndividualType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETEncounterIdResponsePeriodType
    {
        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }
    }

    public class GETEncounterIdResponseServiceProviderType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DELETEEncounterIdResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public DELETEEncounterIdResponseMetaType Meta { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("class")]
        public DELETEEncounterIdResponseClassType Class { get; set; }

        [JsonProperty("type")]
        public DELETEEncounterIdResponseTypeTypeItem[] Type { get; set; }

        [JsonProperty("subject")]
        public DELETEEncounterIdResponseSubjectType Subject { get; set; }

        [JsonProperty("participant")]
        public DELETEEncounterIdResponseParticipantTypeItem[] Participant { get; set; }

        [JsonProperty("period")]
        public DELETEEncounterIdResponsePeriodType Period { get; set; }

        [JsonProperty("serviceProvider")]
        public DELETEEncounterIdResponseServiceProviderType ServiceProvider { get; set; }
    }

    public class DELETEEncounterIdResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class DELETEEncounterIdResponseClassType
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class DELETEEncounterIdResponseTypeTypeItem
    {
        [JsonProperty("coding")]
        public DELETEEncounterIdResponseTypeTypeItemCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class DELETEEncounterIdResponseTypeTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DELETEEncounterIdResponseSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DELETEEncounterIdResponseParticipantTypeItem
    {
        [JsonProperty("individual")]
        public DELETEEncounterIdResponseParticipantTypeItemIndividualType Individual { get; set; }
    }

    public class DELETEEncounterIdResponseParticipantTypeItemIndividualType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DELETEEncounterIdResponsePeriodType
    {
        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }
    }

    public class DELETEEncounterIdResponseServiceProviderType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PUTEncounterIdResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public PUTEncounterIdResponseMetaType Meta { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("class")]
        public PUTEncounterIdResponseClassType Class { get; set; }

        [JsonProperty("type")]
        public PUTEncounterIdResponseTypeTypeItem[] Type { get; set; }

        [JsonProperty("subject")]
        public PUTEncounterIdResponseSubjectType Subject { get; set; }

        [JsonProperty("participant")]
        public PUTEncounterIdResponseParticipantTypeItem[] Participant { get; set; }

        [JsonProperty("period")]
        public PUTEncounterIdResponsePeriodType Period { get; set; }

        [JsonProperty("serviceProvider")]
        public PUTEncounterIdResponseServiceProviderType ServiceProvider { get; set; }
    }

    public class PUTEncounterIdResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class PUTEncounterIdResponseClassType
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class PUTEncounterIdResponseTypeTypeItem
    {
        [JsonProperty("coding")]
        public PUTEncounterIdResponseTypeTypeItemCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class PUTEncounterIdResponseTypeTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PUTEncounterIdResponseSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PUTEncounterIdResponseParticipantTypeItem
    {
        [JsonProperty("individual")]
        public PUTEncounterIdResponseParticipantTypeItemIndividualType Individual { get; set; }
    }

    public class PUTEncounterIdResponseParticipantTypeItemIndividualType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PUTEncounterIdResponsePeriodType
    {
        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }
    }

    public class PUTEncounterIdResponseServiceProviderType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETEncounterIdVersionResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GETEncounterIdVersionResponseMetaType Meta { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("class")]
        public GETEncounterIdVersionResponseClassType Class { get; set; }

        [JsonProperty("type")]
        public GETEncounterIdVersionResponseTypeTypeItem[] Type { get; set; }

        [JsonProperty("subject")]
        public GETEncounterIdVersionResponseSubjectType Subject { get; set; }

        [JsonProperty("participant")]
        public GETEncounterIdVersionResponseParticipantTypeItem[] Participant { get; set; }

        [JsonProperty("period")]
        public GETEncounterIdVersionResponsePeriodType Period { get; set; }

        [JsonProperty("serviceProvider")]
        public GETEncounterIdVersionResponseServiceProviderType ServiceProvider { get; set; }
    }

    public class GETEncounterIdVersionResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GETEncounterIdVersionResponseClassType
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class GETEncounterIdVersionResponseTypeTypeItem
    {
        [JsonProperty("coding")]
        public GETEncounterIdVersionResponseTypeTypeItemCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class GETEncounterIdVersionResponseTypeTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETEncounterIdVersionResponseSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETEncounterIdVersionResponseParticipantTypeItem
    {
        [JsonProperty("individual")]
        public GETEncounterIdVersionResponseParticipantTypeItemIndividualType Individual { get; set; }
    }

    public class GETEncounterIdVersionResponseParticipantTypeItemIndividualType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETEncounterIdVersionResponsePeriodType
    {
        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }
    }

    public class GETEncounterIdVersionResponseServiceProviderType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETEncounterIdHISTORYResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GETEncounterIdHISTORYResponseMetaType Meta { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("class")]
        public GETEncounterIdHISTORYResponseClassType Class { get; set; }

        [JsonProperty("type")]
        public GETEncounterIdHISTORYResponseTypeTypeItem[] Type { get; set; }

        [JsonProperty("subject")]
        public GETEncounterIdHISTORYResponseSubjectType Subject { get; set; }

        [JsonProperty("participant")]
        public GETEncounterIdHISTORYResponseParticipantTypeItem[] Participant { get; set; }

        [JsonProperty("period")]
        public GETEncounterIdHISTORYResponsePeriodType Period { get; set; }

        [JsonProperty("serviceProvider")]
        public GETEncounterIdHISTORYResponseServiceProviderType ServiceProvider { get; set; }
    }

    public class GETEncounterIdHISTORYResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GETEncounterIdHISTORYResponseClassType
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class GETEncounterIdHISTORYResponseTypeTypeItem
    {
        [JsonProperty("coding")]
        public GETEncounterIdHISTORYResponseTypeTypeItemCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class GETEncounterIdHISTORYResponseTypeTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETEncounterIdHISTORYResponseSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETEncounterIdHISTORYResponseParticipantTypeItem
    {
        [JsonProperty("individual")]
        public GETEncounterIdHISTORYResponseParticipantTypeItemIndividualType Individual { get; set; }
    }

    public class GETEncounterIdHISTORYResponseParticipantTypeItemIndividualType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETEncounterIdHISTORYResponsePeriodType
    {
        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }
    }

    public class GETEncounterIdHISTORYResponseServiceProviderType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETEncounterHISTORYResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GETEncounterHISTORYResponseMetaType Meta { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("class")]
        public GETEncounterHISTORYResponseClassType Class { get; set; }

        [JsonProperty("type")]
        public GETEncounterHISTORYResponseTypeTypeItem[] Type { get; set; }

        [JsonProperty("subject")]
        public GETEncounterHISTORYResponseSubjectType Subject { get; set; }

        [JsonProperty("participant")]
        public GETEncounterHISTORYResponseParticipantTypeItem[] Participant { get; set; }

        [JsonProperty("period")]
        public GETEncounterHISTORYResponsePeriodType Period { get; set; }

        [JsonProperty("serviceProvider")]
        public GETEncounterHISTORYResponseServiceProviderType ServiceProvider { get; set; }
    }

    public class GETEncounterHISTORYResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GETEncounterHISTORYResponseClassType
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class GETEncounterHISTORYResponseTypeTypeItem
    {
        [JsonProperty("coding")]
        public GETEncounterHISTORYResponseTypeTypeItemCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class GETEncounterHISTORYResponseTypeTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETEncounterHISTORYResponseSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETEncounterHISTORYResponseParticipantTypeItem
    {
        [JsonProperty("individual")]
        public GETEncounterHISTORYResponseParticipantTypeItemIndividualType Individual { get; set; }
    }

    public class GETEncounterHISTORYResponseParticipantTypeItemIndividualType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETEncounterHISTORYResponsePeriodType
    {
        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }
    }

    public class GETEncounterHISTORYResponseServiceProviderType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETFlagResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("text")]
        public GETFlagResponseTextType Text { get; set; }

        [JsonProperty("identifier")]
        public GETFlagResponseIdentifierTypeItem[] Identifier { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("category")]
        public GETFlagResponseCategoryTypeItem[] Category { get; set; }

        [JsonProperty("code")]
        public GETFlagResponseCodeType Code { get; set; }

        [JsonProperty("subject")]
        public GETFlagResponseSubjectType Subject { get; set; }

        [JsonProperty("period")]
        public GETFlagResponsePeriodType Period { get; set; }

        [JsonProperty("author")]
        public GETFlagResponseAuthorType Author { get; set; }
    }

    public class GETFlagResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("div")]
        public string Div { get; set; }
    }

    public class GETFlagResponseIdentifierTypeItem
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class GETFlagResponseCategoryTypeItem
    {
        [JsonProperty("coding")]
        public GETFlagResponseCategoryTypeItemCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class GETFlagResponseCategoryTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETFlagResponseCodeType
    {
        [JsonProperty("coding")]
        public GETFlagResponseCodeTypeCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class GETFlagResponseCodeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETFlagResponseSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETFlagResponsePeriodType
    {
        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }
    }

    public class GETFlagResponseAuthorType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class POSTFLAGResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("text")]
        public POSTFLAGResponseTextType Text { get; set; }

        [JsonProperty("identifier")]
        public POSTFLAGResponseIdentifierTypeItem[] Identifier { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("category")]
        public POSTFLAGResponseCategoryTypeItem[] Category { get; set; }

        [JsonProperty("code")]
        public POSTFLAGResponseCodeType Code { get; set; }

        [JsonProperty("subject")]
        public POSTFLAGResponseSubjectType Subject { get; set; }

        [JsonProperty("period")]
        public POSTFLAGResponsePeriodType Period { get; set; }

        [JsonProperty("author")]
        public POSTFLAGResponseAuthorType Author { get; set; }
    }

    public class POSTFLAGResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("div")]
        public string Div { get; set; }
    }

    public class POSTFLAGResponseIdentifierTypeItem
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class POSTFLAGResponseCategoryTypeItem
    {
        [JsonProperty("coding")]
        public POSTFLAGResponseCategoryTypeItemCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class POSTFLAGResponseCategoryTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class POSTFLAGResponseCodeType
    {
        [JsonProperty("coding")]
        public POSTFLAGResponseCodeTypeCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class POSTFLAGResponseCodeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class POSTFLAGResponseSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class POSTFLAGResponsePeriodType
    {
        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }
    }

    public class POSTFLAGResponseAuthorType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class bodyidentifierInputItem2
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class bodycategoryInputItem
    {
        [JsonProperty("coding")]
        public bodycategoryInputItemCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class bodycategoryInputItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class bodycodecodingInputItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETFlagIdResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("text")]
        public GETFlagIdResponseTextType Text { get; set; }

        [JsonProperty("identifier")]
        public GETFlagIdResponseIdentifierTypeItem[] Identifier { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("category")]
        public GETFlagIdResponseCategoryTypeItem[] Category { get; set; }

        [JsonProperty("code")]
        public GETFlagIdResponseCodeType Code { get; set; }

        [JsonProperty("subject")]
        public GETFlagIdResponseSubjectType Subject { get; set; }

        [JsonProperty("period")]
        public GETFlagIdResponsePeriodType Period { get; set; }

        [JsonProperty("author")]
        public GETFlagIdResponseAuthorType Author { get; set; }
    }

    public class GETFlagIdResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("div")]
        public string Div { get; set; }
    }

    public class GETFlagIdResponseIdentifierTypeItem
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class GETFlagIdResponseCategoryTypeItem
    {
        [JsonProperty("coding")]
        public GETFlagIdResponseCategoryTypeItemCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class GETFlagIdResponseCategoryTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETFlagIdResponseCodeType
    {
        [JsonProperty("coding")]
        public GETFlagIdResponseCodeTypeCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class GETFlagIdResponseCodeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETFlagIdResponseSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETFlagIdResponsePeriodType
    {
        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }
    }

    public class GETFlagIdResponseAuthorType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DELETEFlagIdResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("text")]
        public DELETEFlagIdResponseTextType Text { get; set; }

        [JsonProperty("identifier")]
        public DELETEFlagIdResponseIdentifierTypeItem[] Identifier { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("category")]
        public DELETEFlagIdResponseCategoryTypeItem[] Category { get; set; }

        [JsonProperty("code")]
        public DELETEFlagIdResponseCodeType Code { get; set; }

        [JsonProperty("subject")]
        public DELETEFlagIdResponseSubjectType Subject { get; set; }

        [JsonProperty("period")]
        public DELETEFlagIdResponsePeriodType Period { get; set; }

        [JsonProperty("author")]
        public DELETEFlagIdResponseAuthorType Author { get; set; }
    }

    public class DELETEFlagIdResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("div")]
        public string Div { get; set; }
    }

    public class DELETEFlagIdResponseIdentifierTypeItem
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class DELETEFlagIdResponseCategoryTypeItem
    {
        [JsonProperty("coding")]
        public DELETEFlagIdResponseCategoryTypeItemCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class DELETEFlagIdResponseCategoryTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DELETEFlagIdResponseCodeType
    {
        [JsonProperty("coding")]
        public DELETEFlagIdResponseCodeTypeCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class DELETEFlagIdResponseCodeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DELETEFlagIdResponseSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DELETEFlagIdResponsePeriodType
    {
        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }
    }

    public class DELETEFlagIdResponseAuthorType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PUTFlagIdResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("text")]
        public PUTFlagIdResponseTextType Text { get; set; }

        [JsonProperty("identifier")]
        public PUTFlagIdResponseIdentifierTypeItem[] Identifier { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("category")]
        public PUTFlagIdResponseCategoryTypeItem[] Category { get; set; }

        [JsonProperty("code")]
        public PUTFlagIdResponseCodeType Code { get; set; }

        [JsonProperty("subject")]
        public PUTFlagIdResponseSubjectType Subject { get; set; }

        [JsonProperty("period")]
        public PUTFlagIdResponsePeriodType Period { get; set; }

        [JsonProperty("author")]
        public PUTFlagIdResponseAuthorType Author { get; set; }
    }

    public class PUTFlagIdResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("div")]
        public string Div { get; set; }
    }

    public class PUTFlagIdResponseIdentifierTypeItem
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class PUTFlagIdResponseCategoryTypeItem
    {
        [JsonProperty("coding")]
        public PUTFlagIdResponseCategoryTypeItemCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class PUTFlagIdResponseCategoryTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PUTFlagIdResponseCodeType
    {
        [JsonProperty("coding")]
        public PUTFlagIdResponseCodeTypeCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class PUTFlagIdResponseCodeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PUTFlagIdResponseSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PUTFlagIdResponsePeriodType
    {
        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }
    }

    public class PUTFlagIdResponseAuthorType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETFlagIdVersionResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("text")]
        public GETFlagIdVersionResponseTextType Text { get; set; }

        [JsonProperty("identifier")]
        public GETFlagIdVersionResponseIdentifierTypeItem[] Identifier { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("category")]
        public GETFlagIdVersionResponseCategoryTypeItem[] Category { get; set; }

        [JsonProperty("code")]
        public GETFlagIdVersionResponseCodeType Code { get; set; }

        [JsonProperty("subject")]
        public GETFlagIdVersionResponseSubjectType Subject { get; set; }

        [JsonProperty("period")]
        public GETFlagIdVersionResponsePeriodType Period { get; set; }

        [JsonProperty("author")]
        public GETFlagIdVersionResponseAuthorType Author { get; set; }
    }

    public class GETFlagIdVersionResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("div")]
        public string Div { get; set; }
    }

    public class GETFlagIdVersionResponseIdentifierTypeItem
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class GETFlagIdVersionResponseCategoryTypeItem
    {
        [JsonProperty("coding")]
        public GETFlagIdVersionResponseCategoryTypeItemCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class GETFlagIdVersionResponseCategoryTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETFlagIdVersionResponseCodeType
    {
        [JsonProperty("coding")]
        public GETFlagIdVersionResponseCodeTypeCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class GETFlagIdVersionResponseCodeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETFlagIdVersionResponseSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETFlagIdVersionResponsePeriodType
    {
        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }
    }

    public class GETFlagIdVersionResponseAuthorType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETFlagIdHistoryResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("text")]
        public GETFlagIdHistoryResponseTextType Text { get; set; }

        [JsonProperty("identifier")]
        public GETFlagIdHistoryResponseIdentifierTypeItem[] Identifier { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("category")]
        public GETFlagIdHistoryResponseCategoryTypeItem[] Category { get; set; }

        [JsonProperty("code")]
        public GETFlagIdHistoryResponseCodeType Code { get; set; }

        [JsonProperty("subject")]
        public GETFlagIdHistoryResponseSubjectType Subject { get; set; }

        [JsonProperty("period")]
        public GETFlagIdHistoryResponsePeriodType Period { get; set; }

        [JsonProperty("author")]
        public GETFlagIdHistoryResponseAuthorType Author { get; set; }
    }

    public class GETFlagIdHistoryResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("div")]
        public string Div { get; set; }
    }

    public class GETFlagIdHistoryResponseIdentifierTypeItem
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class GETFlagIdHistoryResponseCategoryTypeItem
    {
        [JsonProperty("coding")]
        public GETFlagIdHistoryResponseCategoryTypeItemCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class GETFlagIdHistoryResponseCategoryTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETFlagIdHistoryResponseCodeType
    {
        [JsonProperty("coding")]
        public GETFlagIdHistoryResponseCodeTypeCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class GETFlagIdHistoryResponseCodeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETFlagIdHistoryResponseSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETFlagIdHistoryResponsePeriodType
    {
        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }
    }

    public class GETFlagIdHistoryResponseAuthorType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETFlagHISTORYResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("text")]
        public GETFlagHISTORYResponseTextType Text { get; set; }

        [JsonProperty("identifier")]
        public GETFlagHISTORYResponseIdentifierTypeItem[] Identifier { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("category")]
        public GETFlagHISTORYResponseCategoryTypeItem[] Category { get; set; }

        [JsonProperty("code")]
        public GETFlagHISTORYResponseCodeType Code { get; set; }

        [JsonProperty("subject")]
        public GETFlagHISTORYResponseSubjectType Subject { get; set; }

        [JsonProperty("period")]
        public GETFlagHISTORYResponsePeriodType Period { get; set; }

        [JsonProperty("author")]
        public GETFlagHISTORYResponseAuthorType Author { get; set; }
    }

    public class GETFlagHISTORYResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("div")]
        public string Div { get; set; }
    }

    public class GETFlagHISTORYResponseIdentifierTypeItem
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class GETFlagHISTORYResponseCategoryTypeItem
    {
        [JsonProperty("coding")]
        public GETFlagHISTORYResponseCategoryTypeItemCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class GETFlagHISTORYResponseCategoryTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETFlagHISTORYResponseCodeType
    {
        [JsonProperty("coding")]
        public GETFlagHISTORYResponseCodeTypeCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class GETFlagHISTORYResponseCodeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETFlagHISTORYResponseSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETFlagHISTORYResponsePeriodType
    {
        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }
    }

    public class GETFlagHISTORYResponseAuthorType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETLocationResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("text")]
        public GETLocationResponseTextType Text { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("mode")]
        public string Mode { get; set; }

        [JsonProperty("partOf")]
        public GETLocationResponsePartOfType PartOf { get; set; }
    }

    public class GETLocationResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("div")]
        public string Div { get; set; }
    }

    public class GETLocationResponsePartOfType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class POSTLocationResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("text")]
        public POSTLocationResponseTextType Text { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("mode")]
        public string Mode { get; set; }

        [JsonProperty("partOf")]
        public POSTLocationResponsePartOfType PartOf { get; set; }
    }

    public class POSTLocationResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("div")]
        public string Div { get; set; }
    }

    public class POSTLocationResponsePartOfType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETLocationIdResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("text")]
        public GETLocationIdResponseTextType Text { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("mode")]
        public string Mode { get; set; }

        [JsonProperty("partOf")]
        public GETLocationIdResponsePartOfType PartOf { get; set; }
    }

    public class GETLocationIdResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("div")]
        public string Div { get; set; }
    }

    public class GETLocationIdResponsePartOfType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DELETELocationIdResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("text")]
        public DELETELocationIdResponseTextType Text { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("mode")]
        public string Mode { get; set; }

        [JsonProperty("partOf")]
        public DELETELocationIdResponsePartOfType PartOf { get; set; }
    }

    public class DELETELocationIdResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("div")]
        public string Div { get; set; }
    }

    public class DELETELocationIdResponsePartOfType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PUTLocationIdResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("text")]
        public PUTLocationIdResponseTextType Text { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("mode")]
        public string Mode { get; set; }

        [JsonProperty("partOf")]
        public PUTLocationIdResponsePartOfType PartOf { get; set; }
    }

    public class PUTLocationIdResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("div")]
        public string Div { get; set; }
    }

    public class PUTLocationIdResponsePartOfType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETLocationIdVersionResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("text")]
        public GETLocationIdVersionResponseTextType Text { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("mode")]
        public string Mode { get; set; }

        [JsonProperty("partOf")]
        public GETLocationIdVersionResponsePartOfType PartOf { get; set; }
    }

    public class GETLocationIdVersionResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("div")]
        public string Div { get; set; }
    }

    public class GETLocationIdVersionResponsePartOfType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETLocationIdHistoryResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("text")]
        public GETLocationIdHistoryResponseTextType Text { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("mode")]
        public string Mode { get; set; }

        [JsonProperty("partOf")]
        public GETLocationIdHistoryResponsePartOfType PartOf { get; set; }
    }

    public class GETLocationIdHistoryResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("div")]
        public string Div { get; set; }
    }

    public class GETLocationIdHistoryResponsePartOfType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETLocationHistoryResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("text")]
        public GETLocationHistoryResponseTextType Text { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("mode")]
        public string Mode { get; set; }

        [JsonProperty("partOf")]
        public GETLocationHistoryResponsePartOfType PartOf { get; set; }
    }

    public class GETLocationHistoryResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("div")]
        public string Div { get; set; }
    }

    public class GETLocationHistoryResponsePartOfType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETPatientResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GETPatientResponseMetaType Meta { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("link")]
        public GETPatientResponseLinkTypeItem[] Link { get; set; }

        [JsonProperty("entry")]
        public GETPatientResponseEntryTypeItem[] Entry { get; set; }
    }

    public class GETPatientResponseMetaType
    {
        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GETPatientResponseLinkTypeItem
    {
        [JsonProperty("relation")]
        public string Relation { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class GETPatientResponseEntryTypeItem
    {
        [JsonProperty("fullUrl")]
        public string FullUrl { get; set; }

        [JsonProperty("resource")]
        public GETPatientResponseEntryTypeItemResourceType Resource { get; set; }

        [JsonProperty("search")]
        public GETPatientResponseEntryTypeItemSearchType Search { get; set; }
    }

    public class GETPatientResponseEntryTypeItemResourceType
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GETPatientResponseEntryTypeItemResourceTypeMetaType Meta { get; set; }

        [JsonProperty("text")]
        public GETPatientResponseEntryTypeItemResourceTypeTextType Text { get; set; }

        [JsonProperty("extension")]
        public GETPatientResponseEntryTypeItemResourceTypeExtensionTypeItem[] Extension { get; set; }

        [JsonProperty("identifier")]
        public GETPatientResponseEntryTypeItemResourceTypeIdentifierTypeItem[] Identifier { get; set; }

        [JsonProperty("name")]
        public GETPatientResponseEntryTypeItemResourceTypeNameTypeItem[] Name { get; set; }

        [JsonProperty("telecom")]
        public GETPatientResponseEntryTypeItemResourceTypeTelecomTypeItem[] Telecom { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("birthDate")]
        public string BirthDate { get; set; }

        [JsonProperty("address")]
        public GETPatientResponseEntryTypeItemResourceTypeAddressTypeItem[] Address { get; set; }
    }

    public class GETPatientResponseEntryTypeItemResourceTypeMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GETPatientResponseEntryTypeItemResourceTypeTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("div")]
        public string Div { get; set; }
    }

    public class GETPatientResponseEntryTypeItemResourceTypeExtensionTypeItem
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("valueCodeableConcept")]
        public GETPatientResponseEntryTypeItemResourceTypeExtensionTypeItemValueCodeableConceptType ValueCodeableConcept { get; set; }

        [JsonProperty("valueCode")]
        public string ValueCode { get; set; }
    }

    public class GETPatientResponseEntryTypeItemResourceTypeExtensionTypeItemValueCodeableConceptType
    {
        [JsonProperty("coding")]
        public GETPatientResponseEntryTypeItemResourceTypeExtensionTypeItemValueCodeableConceptTypeCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class GETPatientResponseEntryTypeItemResourceTypeExtensionTypeItemValueCodeableConceptTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETPatientResponseEntryTypeItemResourceTypeIdentifierTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class GETPatientResponseEntryTypeItemResourceTypeNameTypeItem
    {
        [JsonProperty("use")]
        public string Use { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("family")]
        public string Family { get; set; }

        [JsonProperty("given")]
        public string[] Given { get; set; }
    }

    public class GETPatientResponseEntryTypeItemResourceTypeTelecomTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("use")]
        public string Use { get; set; }
    }

    public class GETPatientResponseEntryTypeItemResourceTypeAddressTypeItem
    {
        [JsonProperty("use")]
        public string Use { get; set; }

        [JsonProperty("line")]
        public string[] Line { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("postalCode")]
        public string PostalCode { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }
    }

    public class GETPatientResponseEntryTypeItemSearchType
    {
        [JsonProperty("mode")]
        public string Mode { get; set; }
    }

    public class POSTPatientResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("name")]
        public POSTPatientResponseNameTypeItem[] Name { get; set; }

        [JsonProperty("telecom")]
        public POSTPatientResponseTelecomTypeItem[] Telecom { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("birthDate")]
        public string BirthDate { get; set; }

        [JsonProperty("deceasedBoolean")]
        public bool DeceasedBoolean { get; set; }

        [JsonProperty("address")]
        public POSTPatientResponseAddressTypeItem[] Address { get; set; }
    }

    public class POSTPatientResponseNameTypeItem
    {
        [JsonProperty("use")]
        public string Use { get; set; }

        [JsonProperty("family")]
        public string Family { get; set; }

        [JsonProperty("given")]
        public string[] Given { get; set; }
    }

    public class POSTPatientResponseTelecomTypeItem
    {
        [JsonProperty("use")]
        public string Use { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("rank")]
        public int Rank { get; set; }
    }

    public class POSTPatientResponseAddressTypeItem
    {
        [JsonProperty("use")]
        public string Use { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("line")]
        public string[] Line { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("district")]
        public string District { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("postalCode")]
        public string PostalCode { get; set; }

        [JsonProperty("period")]
        public POSTPatientResponseAddressTypeItemPeriodType Period { get; set; }
    }

    public class POSTPatientResponseAddressTypeItemPeriodType
    {
        [JsonProperty("start")]
        public string Start { get; set; }
    }

    public class bodynameInputItem
    {
        [JsonProperty("use")]
        public string Use { get; set; }

        [JsonProperty("family")]
        public string Family { get; set; }

        [JsonProperty("given")]
        public string[] Given { get; set; }
    }

    public class bodytelecomInputItem
    {
        [JsonProperty("use")]
        public string Use { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("rank")]
        public int Rank { get; set; }
    }

    public class bodyaddressInputItem
    {
        [JsonProperty("use")]
        public string Use { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("line")]
        public string[] Line { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("district")]
        public string District { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("postalCode")]
        public string PostalCode { get; set; }

        [JsonProperty("period")]
        public bodyaddressInputItemPeriodType Period { get; set; }
    }

    public class bodyaddressInputItemPeriodType
    {
        [JsonProperty("start")]
        public string Start { get; set; }
    }

    public class GETPatientIdResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GETPatientIdResponseMetaType Meta { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("link")]
        public GETPatientIdResponseLinkTypeItem[] Link { get; set; }

        [JsonProperty("entry")]
        public GETPatientIdResponseEntryTypeItem[] Entry { get; set; }
    }

    public class GETPatientIdResponseMetaType
    {
        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GETPatientIdResponseLinkTypeItem
    {
        [JsonProperty("relation")]
        public string Relation { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class GETPatientIdResponseEntryTypeItem
    {
        [JsonProperty("fullUrl")]
        public string FullUrl { get; set; }

        [JsonProperty("resource")]
        public GETPatientIdResponseEntryTypeItemResourceType Resource { get; set; }

        [JsonProperty("search")]
        public GETPatientIdResponseEntryTypeItemSearchType Search { get; set; }
    }

    public class GETPatientIdResponseEntryTypeItemResourceType
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GETPatientIdResponseEntryTypeItemResourceTypeMetaType Meta { get; set; }

        [JsonProperty("text")]
        public GETPatientIdResponseEntryTypeItemResourceTypeTextType Text { get; set; }

        [JsonProperty("extension")]
        public GETPatientIdResponseEntryTypeItemResourceTypeExtensionTypeItem[] Extension { get; set; }

        [JsonProperty("identifier")]
        public GETPatientIdResponseEntryTypeItemResourceTypeIdentifierTypeItem[] Identifier { get; set; }

        [JsonProperty("name")]
        public GETPatientIdResponseEntryTypeItemResourceTypeNameTypeItem[] Name { get; set; }

        [JsonProperty("telecom")]
        public GETPatientIdResponseEntryTypeItemResourceTypeTelecomTypeItem[] Telecom { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("birthDate")]
        public string BirthDate { get; set; }

        [JsonProperty("address")]
        public GETPatientIdResponseEntryTypeItemResourceTypeAddressTypeItem[] Address { get; set; }
    }

    public class GETPatientIdResponseEntryTypeItemResourceTypeMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GETPatientIdResponseEntryTypeItemResourceTypeTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("div")]
        public string Div { get; set; }
    }

    public class GETPatientIdResponseEntryTypeItemResourceTypeExtensionTypeItem
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("valueCodeableConcept")]
        public GETPatientIdResponseEntryTypeItemResourceTypeExtensionTypeItemValueCodeableConceptType ValueCodeableConcept { get; set; }

        [JsonProperty("valueCode")]
        public string ValueCode { get; set; }
    }

    public class GETPatientIdResponseEntryTypeItemResourceTypeExtensionTypeItemValueCodeableConceptType
    {
        [JsonProperty("coding")]
        public GETPatientIdResponseEntryTypeItemResourceTypeExtensionTypeItemValueCodeableConceptTypeCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class GETPatientIdResponseEntryTypeItemResourceTypeExtensionTypeItemValueCodeableConceptTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETPatientIdResponseEntryTypeItemResourceTypeIdentifierTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class GETPatientIdResponseEntryTypeItemResourceTypeNameTypeItem
    {
        [JsonProperty("use")]
        public string Use { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("family")]
        public string Family { get; set; }

        [JsonProperty("given")]
        public string[] Given { get; set; }
    }

    public class GETPatientIdResponseEntryTypeItemResourceTypeTelecomTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("use")]
        public string Use { get; set; }
    }

    public class GETPatientIdResponseEntryTypeItemResourceTypeAddressTypeItem
    {
        [JsonProperty("use")]
        public string Use { get; set; }

        [JsonProperty("line")]
        public string[] Line { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("postalCode")]
        public string PostalCode { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }
    }

    public class GETPatientIdResponseEntryTypeItemSearchType
    {
        [JsonProperty("mode")]
        public string Mode { get; set; }
    }

    public class DELETEPatientIdResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("name")]
        public DELETEPatientIdResponseNameTypeItem[] Name { get; set; }

        [JsonProperty("telecom")]
        public DELETEPatientIdResponseTelecomTypeItem[] Telecom { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("birthDate")]
        public string BirthDate { get; set; }

        [JsonProperty("deceasedBoolean")]
        public bool DeceasedBoolean { get; set; }

        [JsonProperty("address")]
        public DELETEPatientIdResponseAddressTypeItem[] Address { get; set; }
    }

    public class DELETEPatientIdResponseNameTypeItem
    {
        [JsonProperty("use")]
        public string Use { get; set; }

        [JsonProperty("family")]
        public string Family { get; set; }

        [JsonProperty("given")]
        public string[] Given { get; set; }
    }

    public class DELETEPatientIdResponseTelecomTypeItem
    {
        [JsonProperty("use")]
        public string Use { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("rank")]
        public int Rank { get; set; }
    }

    public class DELETEPatientIdResponseAddressTypeItem
    {
        [JsonProperty("use")]
        public string Use { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("line")]
        public string[] Line { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("district")]
        public string District { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("postalCode")]
        public string PostalCode { get; set; }

        [JsonProperty("period")]
        public DELETEPatientIdResponseAddressTypeItemPeriodType Period { get; set; }
    }

    public class DELETEPatientIdResponseAddressTypeItemPeriodType
    {
        [JsonProperty("start")]
        public string Start { get; set; }
    }

    public class PUTPatientIdResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("name")]
        public PUTPatientIdResponseNameTypeItem[] Name { get; set; }

        [JsonProperty("telecom")]
        public PUTPatientIdResponseTelecomTypeItem[] Telecom { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("birthDate")]
        public string BirthDate { get; set; }

        [JsonProperty("deceasedBoolean")]
        public bool DeceasedBoolean { get; set; }

        [JsonProperty("address")]
        public PUTPatientIdResponseAddressTypeItem[] Address { get; set; }
    }

    public class PUTPatientIdResponseNameTypeItem
    {
        [JsonProperty("use")]
        public string Use { get; set; }

        [JsonProperty("family")]
        public string Family { get; set; }

        [JsonProperty("given")]
        public string[] Given { get; set; }
    }

    public class PUTPatientIdResponseTelecomTypeItem
    {
        [JsonProperty("use")]
        public string Use { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("rank")]
        public int Rank { get; set; }
    }

    public class PUTPatientIdResponseAddressTypeItem
    {
        [JsonProperty("use")]
        public string Use { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("line")]
        public string[] Line { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("district")]
        public string District { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("postalCode")]
        public string PostalCode { get; set; }

        [JsonProperty("period")]
        public PUTPatientIdResponseAddressTypeItemPeriodType Period { get; set; }
    }

    public class PUTPatientIdResponseAddressTypeItemPeriodType
    {
        [JsonProperty("start")]
        public string Start { get; set; }
    }

    public class GETPatientIdVersionResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GETPatientIdVersionResponseMetaType Meta { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("link")]
        public GETPatientIdVersionResponseLinkTypeItem[] Link { get; set; }

        [JsonProperty("entry")]
        public GETPatientIdVersionResponseEntryTypeItem[] Entry { get; set; }
    }

    public class GETPatientIdVersionResponseMetaType
    {
        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GETPatientIdVersionResponseLinkTypeItem
    {
        [JsonProperty("relation")]
        public string Relation { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class GETPatientIdVersionResponseEntryTypeItem
    {
        [JsonProperty("fullUrl")]
        public string FullUrl { get; set; }

        [JsonProperty("resource")]
        public GETPatientIdVersionResponseEntryTypeItemResourceType Resource { get; set; }

        [JsonProperty("search")]
        public GETPatientIdVersionResponseEntryTypeItemSearchType Search { get; set; }
    }

    public class GETPatientIdVersionResponseEntryTypeItemResourceType
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GETPatientIdVersionResponseEntryTypeItemResourceTypeMetaType Meta { get; set; }

        [JsonProperty("text")]
        public GETPatientIdVersionResponseEntryTypeItemResourceTypeTextType Text { get; set; }

        [JsonProperty("extension")]
        public GETPatientIdVersionResponseEntryTypeItemResourceTypeExtensionTypeItem[] Extension { get; set; }

        [JsonProperty("identifier")]
        public GETPatientIdVersionResponseEntryTypeItemResourceTypeIdentifierTypeItem[] Identifier { get; set; }

        [JsonProperty("name")]
        public GETPatientIdVersionResponseEntryTypeItemResourceTypeNameTypeItem[] Name { get; set; }

        [JsonProperty("telecom")]
        public GETPatientIdVersionResponseEntryTypeItemResourceTypeTelecomTypeItem[] Telecom { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("birthDate")]
        public string BirthDate { get; set; }

        [JsonProperty("address")]
        public GETPatientIdVersionResponseEntryTypeItemResourceTypeAddressTypeItem[] Address { get; set; }
    }

    public class GETPatientIdVersionResponseEntryTypeItemResourceTypeMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GETPatientIdVersionResponseEntryTypeItemResourceTypeTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("div")]
        public string Div { get; set; }
    }

    public class GETPatientIdVersionResponseEntryTypeItemResourceTypeExtensionTypeItem
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("valueCodeableConcept")]
        public GETPatientIdVersionResponseEntryTypeItemResourceTypeExtensionTypeItemValueCodeableConceptType ValueCodeableConcept { get; set; }

        [JsonProperty("valueCode")]
        public string ValueCode { get; set; }
    }

    public class GETPatientIdVersionResponseEntryTypeItemResourceTypeExtensionTypeItemValueCodeableConceptType
    {
        [JsonProperty("coding")]
        public GETPatientIdVersionResponseEntryTypeItemResourceTypeExtensionTypeItemValueCodeableConceptTypeCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class GETPatientIdVersionResponseEntryTypeItemResourceTypeExtensionTypeItemValueCodeableConceptTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETPatientIdVersionResponseEntryTypeItemResourceTypeIdentifierTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class GETPatientIdVersionResponseEntryTypeItemResourceTypeNameTypeItem
    {
        [JsonProperty("use")]
        public string Use { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("family")]
        public string Family { get; set; }

        [JsonProperty("given")]
        public string[] Given { get; set; }
    }

    public class GETPatientIdVersionResponseEntryTypeItemResourceTypeTelecomTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("use")]
        public string Use { get; set; }
    }

    public class GETPatientIdVersionResponseEntryTypeItemResourceTypeAddressTypeItem
    {
        [JsonProperty("use")]
        public string Use { get; set; }

        [JsonProperty("line")]
        public string[] Line { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("postalCode")]
        public string PostalCode { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }
    }

    public class GETPatientIdVersionResponseEntryTypeItemSearchType
    {
        [JsonProperty("mode")]
        public string Mode { get; set; }
    }

    public class GETPatientIdHistoryResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GETPatientIdHistoryResponseMetaType Meta { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("link")]
        public GETPatientIdHistoryResponseLinkTypeItem[] Link { get; set; }

        [JsonProperty("entry")]
        public GETPatientIdHistoryResponseEntryTypeItem[] Entry { get; set; }
    }

    public class GETPatientIdHistoryResponseMetaType
    {
        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GETPatientIdHistoryResponseLinkTypeItem
    {
        [JsonProperty("relation")]
        public string Relation { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class GETPatientIdHistoryResponseEntryTypeItem
    {
        [JsonProperty("fullUrl")]
        public string FullUrl { get; set; }

        [JsonProperty("resource")]
        public GETPatientIdHistoryResponseEntryTypeItemResourceType Resource { get; set; }

        [JsonProperty("search")]
        public GETPatientIdHistoryResponseEntryTypeItemSearchType Search { get; set; }
    }

    public class GETPatientIdHistoryResponseEntryTypeItemResourceType
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GETPatientIdHistoryResponseEntryTypeItemResourceTypeMetaType Meta { get; set; }

        [JsonProperty("text")]
        public GETPatientIdHistoryResponseEntryTypeItemResourceTypeTextType Text { get; set; }

        [JsonProperty("extension")]
        public GETPatientIdHistoryResponseEntryTypeItemResourceTypeExtensionTypeItem[] Extension { get; set; }

        [JsonProperty("identifier")]
        public GETPatientIdHistoryResponseEntryTypeItemResourceTypeIdentifierTypeItem[] Identifier { get; set; }

        [JsonProperty("name")]
        public GETPatientIdHistoryResponseEntryTypeItemResourceTypeNameTypeItem[] Name { get; set; }

        [JsonProperty("telecom")]
        public GETPatientIdHistoryResponseEntryTypeItemResourceTypeTelecomTypeItem[] Telecom { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("birthDate")]
        public string BirthDate { get; set; }

        [JsonProperty("address")]
        public GETPatientIdHistoryResponseEntryTypeItemResourceTypeAddressTypeItem[] Address { get; set; }
    }

    public class GETPatientIdHistoryResponseEntryTypeItemResourceTypeMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GETPatientIdHistoryResponseEntryTypeItemResourceTypeTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("div")]
        public string Div { get; set; }
    }

    public class GETPatientIdHistoryResponseEntryTypeItemResourceTypeExtensionTypeItem
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("valueCodeableConcept")]
        public GETPatientIdHistoryResponseEntryTypeItemResourceTypeExtensionTypeItemValueCodeableConceptType ValueCodeableConcept { get; set; }

        [JsonProperty("valueCode")]
        public string ValueCode { get; set; }
    }

    public class GETPatientIdHistoryResponseEntryTypeItemResourceTypeExtensionTypeItemValueCodeableConceptType
    {
        [JsonProperty("coding")]
        public GETPatientIdHistoryResponseEntryTypeItemResourceTypeExtensionTypeItemValueCodeableConceptTypeCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class GETPatientIdHistoryResponseEntryTypeItemResourceTypeExtensionTypeItemValueCodeableConceptTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETPatientIdHistoryResponseEntryTypeItemResourceTypeIdentifierTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class GETPatientIdHistoryResponseEntryTypeItemResourceTypeNameTypeItem
    {
        [JsonProperty("use")]
        public string Use { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("family")]
        public string Family { get; set; }

        [JsonProperty("given")]
        public string[] Given { get; set; }
    }

    public class GETPatientIdHistoryResponseEntryTypeItemResourceTypeTelecomTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("use")]
        public string Use { get; set; }
    }

    public class GETPatientIdHistoryResponseEntryTypeItemResourceTypeAddressTypeItem
    {
        [JsonProperty("use")]
        public string Use { get; set; }

        [JsonProperty("line")]
        public string[] Line { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("postalCode")]
        public string PostalCode { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }
    }

    public class GETPatientIdHistoryResponseEntryTypeItemSearchType
    {
        [JsonProperty("mode")]
        public string Mode { get; set; }
    }

    public class GETPatientHistoryResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GETPatientHistoryResponseMetaType Meta { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("link")]
        public GETPatientHistoryResponseLinkTypeItem[] Link { get; set; }

        [JsonProperty("entry")]
        public GETPatientHistoryResponseEntryTypeItem[] Entry { get; set; }
    }

    public class GETPatientHistoryResponseMetaType
    {
        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GETPatientHistoryResponseLinkTypeItem
    {
        [JsonProperty("relation")]
        public string Relation { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class GETPatientHistoryResponseEntryTypeItem
    {
        [JsonProperty("fullUrl")]
        public string FullUrl { get; set; }

        [JsonProperty("resource")]
        public GETPatientHistoryResponseEntryTypeItemResourceType Resource { get; set; }

        [JsonProperty("search")]
        public GETPatientHistoryResponseEntryTypeItemSearchType Search { get; set; }
    }

    public class GETPatientHistoryResponseEntryTypeItemResourceType
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GETPatientHistoryResponseEntryTypeItemResourceTypeMetaType Meta { get; set; }

        [JsonProperty("text")]
        public GETPatientHistoryResponseEntryTypeItemResourceTypeTextType Text { get; set; }

        [JsonProperty("extension")]
        public GETPatientHistoryResponseEntryTypeItemResourceTypeExtensionTypeItem[] Extension { get; set; }

        [JsonProperty("identifier")]
        public GETPatientHistoryResponseEntryTypeItemResourceTypeIdentifierTypeItem[] Identifier { get; set; }

        [JsonProperty("name")]
        public GETPatientHistoryResponseEntryTypeItemResourceTypeNameTypeItem[] Name { get; set; }

        [JsonProperty("telecom")]
        public GETPatientHistoryResponseEntryTypeItemResourceTypeTelecomTypeItem[] Telecom { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("birthDate")]
        public string BirthDate { get; set; }

        [JsonProperty("address")]
        public GETPatientHistoryResponseEntryTypeItemResourceTypeAddressTypeItem[] Address { get; set; }
    }

    public class GETPatientHistoryResponseEntryTypeItemResourceTypeMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GETPatientHistoryResponseEntryTypeItemResourceTypeTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("div")]
        public string Div { get; set; }
    }

    public class GETPatientHistoryResponseEntryTypeItemResourceTypeExtensionTypeItem
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("valueCodeableConcept")]
        public GETPatientHistoryResponseEntryTypeItemResourceTypeExtensionTypeItemValueCodeableConceptType ValueCodeableConcept { get; set; }

        [JsonProperty("valueCode")]
        public string ValueCode { get; set; }
    }

    public class GETPatientHistoryResponseEntryTypeItemResourceTypeExtensionTypeItemValueCodeableConceptType
    {
        [JsonProperty("coding")]
        public GETPatientHistoryResponseEntryTypeItemResourceTypeExtensionTypeItemValueCodeableConceptTypeCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class GETPatientHistoryResponseEntryTypeItemResourceTypeExtensionTypeItemValueCodeableConceptTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETPatientHistoryResponseEntryTypeItemResourceTypeIdentifierTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class GETPatientHistoryResponseEntryTypeItemResourceTypeNameTypeItem
    {
        [JsonProperty("use")]
        public string Use { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("family")]
        public string Family { get; set; }

        [JsonProperty("given")]
        public string[] Given { get; set; }
    }

    public class GETPatientHistoryResponseEntryTypeItemResourceTypeTelecomTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("use")]
        public string Use { get; set; }
    }

    public class GETPatientHistoryResponseEntryTypeItemResourceTypeAddressTypeItem
    {
        [JsonProperty("use")]
        public string Use { get; set; }

        [JsonProperty("line")]
        public string[] Line { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("postalCode")]
        public string PostalCode { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }
    }

    public class GETPatientHistoryResponseEntryTypeItemSearchType
    {
        [JsonProperty("mode")]
        public string Mode { get; set; }
    }

    public class GETPersonResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public GETPersonResponseNameTypeItem[] Name { get; set; }

        [JsonProperty("telecom")]
        public GETPersonResponseTelecomTypeItem[] Telecom { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("birthDate")]
        public string BirthDate { get; set; }

        [JsonProperty("address")]
        public GETPersonResponseAddressTypeItem[] Address { get; set; }

        [JsonProperty("managingOrganization")]
        public GETPersonResponseManagingOrganizationType ManagingOrganization { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("link")]
        public GETPersonResponseLinkTypeItem[] Link { get; set; }
    }

    public class GETPersonResponseNameTypeItem
    {
        [JsonProperty("use")]
        public string Use { get; set; }

        [JsonProperty("family")]
        public string Family { get; set; }

        [JsonProperty("given")]
        public string[] Given { get; set; }
    }

    public class GETPersonResponseTelecomTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("use")]
        public string Use { get; set; }
    }

    public class GETPersonResponseAddressTypeItem
    {
        [JsonProperty("use")]
        public string Use { get; set; }

        [JsonProperty("line")]
        public string[] Line { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }
    }

    public class GETPersonResponseManagingOrganizationType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETPersonResponseLinkTypeItem
    {
        [JsonProperty("target")]
        public GETPersonResponseLinkTypeItemTargetType Target { get; set; }

        [JsonProperty("assurance")]
        public string Assurance { get; set; }
    }

    public class GETPersonResponseLinkTypeItemTargetType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class POSTPersonResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public POSTPersonResponseNameTypeItem[] Name { get; set; }

        [JsonProperty("telecom")]
        public POSTPersonResponseTelecomTypeItem[] Telecom { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("birthDate")]
        public string BirthDate { get; set; }

        [JsonProperty("address")]
        public POSTPersonResponseAddressTypeItem[] Address { get; set; }

        [JsonProperty("managingOrganization")]
        public POSTPersonResponseManagingOrganizationType ManagingOrganization { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("link")]
        public POSTPersonResponseLinkTypeItem[] Link { get; set; }
    }

    public class POSTPersonResponseNameTypeItem
    {
        [JsonProperty("use")]
        public string Use { get; set; }

        [JsonProperty("family")]
        public string Family { get; set; }

        [JsonProperty("given")]
        public string[] Given { get; set; }
    }

    public class POSTPersonResponseTelecomTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("use")]
        public string Use { get; set; }
    }

    public class POSTPersonResponseAddressTypeItem
    {
        [JsonProperty("use")]
        public string Use { get; set; }

        [JsonProperty("line")]
        public string[] Line { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }
    }

    public class POSTPersonResponseManagingOrganizationType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class POSTPersonResponseLinkTypeItem
    {
        [JsonProperty("target")]
        public POSTPersonResponseLinkTypeItemTargetType Target { get; set; }

        [JsonProperty("assurance")]
        public string Assurance { get; set; }
    }

    public class POSTPersonResponseLinkTypeItemTargetType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class bodytelecomInputItem2
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("use")]
        public string Use { get; set; }
    }

    public class bodyaddressInputItem2
    {
        [JsonProperty("use")]
        public string Use { get; set; }

        [JsonProperty("line")]
        public string[] Line { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }
    }

    public class bodylinkInputItem
    {
        [JsonProperty("target")]
        public bodylinkInputItemTargetType Target { get; set; }

        [JsonProperty("assurance")]
        public string Assurance { get; set; }
    }

    public class bodylinkInputItemTargetType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETPersonIdResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public GETPersonIdResponseNameTypeItem[] Name { get; set; }

        [JsonProperty("telecom")]
        public GETPersonIdResponseTelecomTypeItem[] Telecom { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("birthDate")]
        public string BirthDate { get; set; }

        [JsonProperty("address")]
        public GETPersonIdResponseAddressTypeItem[] Address { get; set; }

        [JsonProperty("managingOrganization")]
        public GETPersonIdResponseManagingOrganizationType ManagingOrganization { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("link")]
        public GETPersonIdResponseLinkTypeItem[] Link { get; set; }
    }

    public class GETPersonIdResponseNameTypeItem
    {
        [JsonProperty("use")]
        public string Use { get; set; }

        [JsonProperty("family")]
        public string Family { get; set; }

        [JsonProperty("given")]
        public string[] Given { get; set; }
    }

    public class GETPersonIdResponseTelecomTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("use")]
        public string Use { get; set; }
    }

    public class GETPersonIdResponseAddressTypeItem
    {
        [JsonProperty("use")]
        public string Use { get; set; }

        [JsonProperty("line")]
        public string[] Line { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }
    }

    public class GETPersonIdResponseManagingOrganizationType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETPersonIdResponseLinkTypeItem
    {
        [JsonProperty("target")]
        public GETPersonIdResponseLinkTypeItemTargetType Target { get; set; }

        [JsonProperty("assurance")]
        public string Assurance { get; set; }
    }

    public class GETPersonIdResponseLinkTypeItemTargetType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DELETEPersonIdResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public DELETEPersonIdResponseNameTypeItem[] Name { get; set; }

        [JsonProperty("telecom")]
        public DELETEPersonIdResponseTelecomTypeItem[] Telecom { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("birthDate")]
        public string BirthDate { get; set; }

        [JsonProperty("address")]
        public DELETEPersonIdResponseAddressTypeItem[] Address { get; set; }

        [JsonProperty("managingOrganization")]
        public DELETEPersonIdResponseManagingOrganizationType ManagingOrganization { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("link")]
        public DELETEPersonIdResponseLinkTypeItem[] Link { get; set; }
    }

    public class DELETEPersonIdResponseNameTypeItem
    {
        [JsonProperty("use")]
        public string Use { get; set; }

        [JsonProperty("family")]
        public string Family { get; set; }

        [JsonProperty("given")]
        public string[] Given { get; set; }
    }

    public class DELETEPersonIdResponseTelecomTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("use")]
        public string Use { get; set; }
    }

    public class DELETEPersonIdResponseAddressTypeItem
    {
        [JsonProperty("use")]
        public string Use { get; set; }

        [JsonProperty("line")]
        public string[] Line { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }
    }

    public class DELETEPersonIdResponseManagingOrganizationType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DELETEPersonIdResponseLinkTypeItem
    {
        [JsonProperty("target")]
        public DELETEPersonIdResponseLinkTypeItemTargetType Target { get; set; }

        [JsonProperty("assurance")]
        public string Assurance { get; set; }
    }

    public class DELETEPersonIdResponseLinkTypeItemTargetType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PUTPersonIdResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public PUTPersonIdResponseNameTypeItem[] Name { get; set; }

        [JsonProperty("telecom")]
        public PUTPersonIdResponseTelecomTypeItem[] Telecom { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("birthDate")]
        public string BirthDate { get; set; }

        [JsonProperty("address")]
        public PUTPersonIdResponseAddressTypeItem[] Address { get; set; }

        [JsonProperty("managingOrganization")]
        public PUTPersonIdResponseManagingOrganizationType ManagingOrganization { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("link")]
        public PUTPersonIdResponseLinkTypeItem[] Link { get; set; }
    }

    public class PUTPersonIdResponseNameTypeItem
    {
        [JsonProperty("use")]
        public string Use { get; set; }

        [JsonProperty("family")]
        public string Family { get; set; }

        [JsonProperty("given")]
        public string[] Given { get; set; }
    }

    public class PUTPersonIdResponseTelecomTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("use")]
        public string Use { get; set; }
    }

    public class PUTPersonIdResponseAddressTypeItem
    {
        [JsonProperty("use")]
        public string Use { get; set; }

        [JsonProperty("line")]
        public string[] Line { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }
    }

    public class PUTPersonIdResponseManagingOrganizationType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PUTPersonIdResponseLinkTypeItem
    {
        [JsonProperty("target")]
        public PUTPersonIdResponseLinkTypeItemTargetType Target { get; set; }

        [JsonProperty("assurance")]
        public string Assurance { get; set; }
    }

    public class PUTPersonIdResponseLinkTypeItemTargetType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETPersonIdVersionResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public GETPersonIdVersionResponseNameTypeItem[] Name { get; set; }

        [JsonProperty("telecom")]
        public GETPersonIdVersionResponseTelecomTypeItem[] Telecom { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("birthDate")]
        public string BirthDate { get; set; }

        [JsonProperty("address")]
        public GETPersonIdVersionResponseAddressTypeItem[] Address { get; set; }

        [JsonProperty("managingOrganization")]
        public GETPersonIdVersionResponseManagingOrganizationType ManagingOrganization { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("link")]
        public GETPersonIdVersionResponseLinkTypeItem[] Link { get; set; }
    }

    public class GETPersonIdVersionResponseNameTypeItem
    {
        [JsonProperty("use")]
        public string Use { get; set; }

        [JsonProperty("family")]
        public string Family { get; set; }

        [JsonProperty("given")]
        public string[] Given { get; set; }
    }

    public class GETPersonIdVersionResponseTelecomTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("use")]
        public string Use { get; set; }
    }

    public class GETPersonIdVersionResponseAddressTypeItem
    {
        [JsonProperty("use")]
        public string Use { get; set; }

        [JsonProperty("line")]
        public string[] Line { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }
    }

    public class GETPersonIdVersionResponseManagingOrganizationType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETPersonIdVersionResponseLinkTypeItem
    {
        [JsonProperty("target")]
        public GETPersonIdVersionResponseLinkTypeItemTargetType Target { get; set; }

        [JsonProperty("assurance")]
        public string Assurance { get; set; }
    }

    public class GETPersonIdVersionResponseLinkTypeItemTargetType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETPersonIdHistoryResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public GETPersonIdHistoryResponseNameTypeItem[] Name { get; set; }

        [JsonProperty("telecom")]
        public GETPersonIdHistoryResponseTelecomTypeItem[] Telecom { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("birthDate")]
        public string BirthDate { get; set; }

        [JsonProperty("address")]
        public GETPersonIdHistoryResponseAddressTypeItem[] Address { get; set; }

        [JsonProperty("managingOrganization")]
        public GETPersonIdHistoryResponseManagingOrganizationType ManagingOrganization { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("link")]
        public GETPersonIdHistoryResponseLinkTypeItem[] Link { get; set; }
    }

    public class GETPersonIdHistoryResponseNameTypeItem
    {
        [JsonProperty("use")]
        public string Use { get; set; }

        [JsonProperty("family")]
        public string Family { get; set; }

        [JsonProperty("given")]
        public string[] Given { get; set; }
    }

    public class GETPersonIdHistoryResponseTelecomTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("use")]
        public string Use { get; set; }
    }

    public class GETPersonIdHistoryResponseAddressTypeItem
    {
        [JsonProperty("use")]
        public string Use { get; set; }

        [JsonProperty("line")]
        public string[] Line { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }
    }

    public class GETPersonIdHistoryResponseManagingOrganizationType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETPersonIdHistoryResponseLinkTypeItem
    {
        [JsonProperty("target")]
        public GETPersonIdHistoryResponseLinkTypeItemTargetType Target { get; set; }

        [JsonProperty("assurance")]
        public string Assurance { get; set; }
    }

    public class GETPersonIdHistoryResponseLinkTypeItemTargetType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETPersonHistoryResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public GETPersonHistoryResponseNameTypeItem[] Name { get; set; }

        [JsonProperty("telecom")]
        public GETPersonHistoryResponseTelecomTypeItem[] Telecom { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("birthDate")]
        public string BirthDate { get; set; }

        [JsonProperty("address")]
        public GETPersonHistoryResponseAddressTypeItem[] Address { get; set; }

        [JsonProperty("managingOrganization")]
        public GETPersonHistoryResponseManagingOrganizationType ManagingOrganization { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("link")]
        public GETPersonHistoryResponseLinkTypeItem[] Link { get; set; }
    }

    public class GETPersonHistoryResponseNameTypeItem
    {
        [JsonProperty("use")]
        public string Use { get; set; }

        [JsonProperty("family")]
        public string Family { get; set; }

        [JsonProperty("given")]
        public string[] Given { get; set; }
    }

    public class GETPersonHistoryResponseTelecomTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("use")]
        public string Use { get; set; }
    }

    public class GETPersonHistoryResponseAddressTypeItem
    {
        [JsonProperty("use")]
        public string Use { get; set; }

        [JsonProperty("line")]
        public string[] Line { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }
    }

    public class GETPersonHistoryResponseManagingOrganizationType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETPersonHistoryResponseLinkTypeItem
    {
        [JsonProperty("target")]
        public GETPersonHistoryResponseLinkTypeItemTargetType Target { get; set; }

        [JsonProperty("assurance")]
        public string Assurance { get; set; }
    }

    public class GETPersonHistoryResponseLinkTypeItemTargetType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETPractitionerResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GETPractitionerResponseMetaType Meta { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("link")]
        public GETPractitionerResponseLinkTypeItem[] Link { get; set; }

        [JsonProperty("entry")]
        public GETPractitionerResponseEntryTypeItem[] Entry { get; set; }
    }

    public class GETPractitionerResponseMetaType
    {
        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GETPractitionerResponseLinkTypeItem
    {
        [JsonProperty("relation")]
        public string Relation { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class GETPractitionerResponseEntryTypeItem
    {
        [JsonProperty("fullUrl")]
        public string FullUrl { get; set; }

        [JsonProperty("resource")]
        public GETPractitionerResponseEntryTypeItemResourceType Resource { get; set; }

        [JsonProperty("search")]
        public GETPractitionerResponseEntryTypeItemSearchType Search { get; set; }
    }

    public class GETPractitionerResponseEntryTypeItemResourceType
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GETPractitionerResponseEntryTypeItemResourceTypeMetaType Meta { get; set; }

        [JsonProperty("identifier")]
        public GETPractitionerResponseEntryTypeItemResourceTypeIdentifierTypeItem[] Identifier { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("name")]
        public GETPractitionerResponseEntryTypeItemResourceTypeNameTypeItem[] Name { get; set; }

        [JsonProperty("telecom")]
        public GETPractitionerResponseEntryTypeItemResourceTypeTelecomTypeItem[] Telecom { get; set; }

        [JsonProperty("address")]
        public GETPractitionerResponseEntryTypeItemResourceTypeAddressTypeItem[] Address { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }
    }

    public class GETPractitionerResponseEntryTypeItemResourceTypeMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GETPractitionerResponseEntryTypeItemResourceTypeIdentifierTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class GETPractitionerResponseEntryTypeItemResourceTypeNameTypeItem
    {
        [JsonProperty("family")]
        public string Family { get; set; }

        [JsonProperty("given")]
        public string[] Given { get; set; }

        [JsonProperty("prefix")]
        public string[] Prefix { get; set; }
    }

    public class GETPractitionerResponseEntryTypeItemResourceTypeTelecomTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("use")]
        public string Use { get; set; }
    }

    public class GETPractitionerResponseEntryTypeItemResourceTypeAddressTypeItem
    {
        [JsonProperty("line")]
        public string[] Line { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("postalCode")]
        public string PostalCode { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }
    }

    public class GETPractitionerResponseEntryTypeItemSearchType
    {
        [JsonProperty("mode")]
        public string Mode { get; set; }
    }

    public class POSTPractitionerResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public POSTPractitionerResponseMetaType Meta { get; set; }

        [JsonProperty("identifier")]
        public POSTPractitionerResponseIdentifierTypeItem[] Identifier { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("name")]
        public POSTPractitionerResponseNameTypeItem[] Name { get; set; }

        [JsonProperty("telecom")]
        public POSTPractitionerResponseTelecomTypeItem[] Telecom { get; set; }

        [JsonProperty("address")]
        public POSTPractitionerResponseAddressTypeItem[] Address { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }
    }

    public class POSTPractitionerResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class POSTPractitionerResponseIdentifierTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class POSTPractitionerResponseNameTypeItem
    {
        [JsonProperty("family")]
        public string Family { get; set; }

        [JsonProperty("given")]
        public string[] Given { get; set; }

        [JsonProperty("prefix")]
        public string[] Prefix { get; set; }
    }

    public class POSTPractitionerResponseTelecomTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("use")]
        public string Use { get; set; }
    }

    public class POSTPractitionerResponseAddressTypeItem
    {
        [JsonProperty("line")]
        public string[] Line { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("postalCode")]
        public string PostalCode { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }
    }

    public class bodynameInputItem2
    {
        [JsonProperty("family")]
        public string Family { get; set; }

        [JsonProperty("given")]
        public string[] Given { get; set; }

        [JsonProperty("prefix")]
        public string[] Prefix { get; set; }
    }

    public class bodyaddressInputItem22
    {
        [JsonProperty("use")]
        public string Use { get; set; }

        [JsonProperty("line")]
        public string[] Line { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("postalCode")]
        public string PostalCode { get; set; }
    }

    public class bodyqualificationInputItem
    {
        [JsonProperty("identifier")]
        public bodyqualificationInputItemIdentifierTypeItem[] Identifier { get; set; }

        [JsonProperty("code")]
        public bodyqualificationInputItemCodeType Code { get; set; }

        [JsonProperty("period")]
        public bodyqualificationInputItemPeriodType Period { get; set; }

        [JsonProperty("issuer")]
        public bodyqualificationInputItemIssuerType Issuer { get; set; }
    }

    public class bodyqualificationInputItemIdentifierTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class bodyqualificationInputItemCodeType
    {
        [JsonProperty("coding")]
        public bodyqualificationInputItemCodeTypeCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class bodyqualificationInputItemCodeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class bodyqualificationInputItemPeriodType
    {
        [JsonProperty("start")]
        public string Start { get; set; }
    }

    public class bodyqualificationInputItemIssuerType
    {
        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETPractitionerIdResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GETPractitionerIdResponseMetaType Meta { get; set; }

        [JsonProperty("identifier")]
        public GETPractitionerIdResponseIdentifierTypeItem[] Identifier { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("name")]
        public GETPractitionerIdResponseNameTypeItem[] Name { get; set; }

        [JsonProperty("telecom")]
        public GETPractitionerIdResponseTelecomTypeItem[] Telecom { get; set; }

        [JsonProperty("address")]
        public GETPractitionerIdResponseAddressTypeItem[] Address { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }
    }

    public class GETPractitionerIdResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GETPractitionerIdResponseIdentifierTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class GETPractitionerIdResponseNameTypeItem
    {
        [JsonProperty("family")]
        public string Family { get; set; }

        [JsonProperty("given")]
        public string[] Given { get; set; }

        [JsonProperty("prefix")]
        public string[] Prefix { get; set; }
    }

    public class GETPractitionerIdResponseTelecomTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("use")]
        public string Use { get; set; }
    }

    public class GETPractitionerIdResponseAddressTypeItem
    {
        [JsonProperty("line")]
        public string[] Line { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("postalCode")]
        public string PostalCode { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }
    }

    public class DELETEPractitionerIdResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("text")]
        public DELETEPractitionerIdResponseTextType Text { get; set; }

        [JsonProperty("identifier")]
        public DELETEPractitionerIdResponseIdentifierTypeItem[] Identifier { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("name")]
        public DELETEPractitionerIdResponseNameTypeItem[] Name { get; set; }

        [JsonProperty("address")]
        public DELETEPractitionerIdResponseAddressTypeItem[] Address { get; set; }

        [JsonProperty("qualification")]
        public DELETEPractitionerIdResponseQualificationTypeItem[] Qualification { get; set; }
    }

    public class DELETEPractitionerIdResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("div")]
        public string Div { get; set; }
    }

    public class DELETEPractitionerIdResponseIdentifierTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class DELETEPractitionerIdResponseNameTypeItem
    {
        [JsonProperty("family")]
        public string Family { get; set; }

        [JsonProperty("given")]
        public string[] Given { get; set; }

        [JsonProperty("prefix")]
        public string[] Prefix { get; set; }
    }

    public class DELETEPractitionerIdResponseAddressTypeItem
    {
        [JsonProperty("use")]
        public string Use { get; set; }

        [JsonProperty("line")]
        public string[] Line { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("postalCode")]
        public string PostalCode { get; set; }
    }

    public class DELETEPractitionerIdResponseQualificationTypeItem
    {
        [JsonProperty("identifier")]
        public DELETEPractitionerIdResponseQualificationTypeItemIdentifierTypeItem[] Identifier { get; set; }

        [JsonProperty("code")]
        public DELETEPractitionerIdResponseQualificationTypeItemCodeType Code { get; set; }

        [JsonProperty("period")]
        public DELETEPractitionerIdResponseQualificationTypeItemPeriodType Period { get; set; }

        [JsonProperty("issuer")]
        public DELETEPractitionerIdResponseQualificationTypeItemIssuerType Issuer { get; set; }
    }

    public class DELETEPractitionerIdResponseQualificationTypeItemIdentifierTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class DELETEPractitionerIdResponseQualificationTypeItemCodeType
    {
        [JsonProperty("coding")]
        public DELETEPractitionerIdResponseQualificationTypeItemCodeTypeCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class DELETEPractitionerIdResponseQualificationTypeItemCodeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DELETEPractitionerIdResponseQualificationTypeItemPeriodType
    {
        [JsonProperty("start")]
        public string Start { get; set; }
    }

    public class DELETEPractitionerIdResponseQualificationTypeItemIssuerType
    {
        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class bodyaddressInputItem222
    {
        [JsonProperty("line")]
        public string[] Line { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("postalCode")]
        public string PostalCode { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }
    }

    public class PUTPractitionerIdResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public PUTPractitionerIdResponseMetaType Meta { get; set; }

        [JsonProperty("identifier")]
        public PUTPractitionerIdResponseIdentifierTypeItem[] Identifier { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("name")]
        public PUTPractitionerIdResponseNameTypeItem[] Name { get; set; }

        [JsonProperty("telecom")]
        public PUTPractitionerIdResponseTelecomTypeItem[] Telecom { get; set; }

        [JsonProperty("address")]
        public PUTPractitionerIdResponseAddressTypeItem[] Address { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }
    }

    public class PUTPractitionerIdResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class PUTPractitionerIdResponseIdentifierTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class PUTPractitionerIdResponseNameTypeItem
    {
        [JsonProperty("family")]
        public string Family { get; set; }

        [JsonProperty("given")]
        public string[] Given { get; set; }

        [JsonProperty("prefix")]
        public string[] Prefix { get; set; }
    }

    public class PUTPractitionerIdResponseTelecomTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("use")]
        public string Use { get; set; }
    }

    public class PUTPractitionerIdResponseAddressTypeItem
    {
        [JsonProperty("line")]
        public string[] Line { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("postalCode")]
        public string PostalCode { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }
    }

    public class GETPractitionerIdVersionResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GETPractitionerIdVersionResponseMetaType Meta { get; set; }

        [JsonProperty("identifier")]
        public GETPractitionerIdVersionResponseIdentifierTypeItem[] Identifier { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("name")]
        public GETPractitionerIdVersionResponseNameTypeItem[] Name { get; set; }

        [JsonProperty("telecom")]
        public GETPractitionerIdVersionResponseTelecomTypeItem[] Telecom { get; set; }

        [JsonProperty("address")]
        public GETPractitionerIdVersionResponseAddressTypeItem[] Address { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }
    }

    public class GETPractitionerIdVersionResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GETPractitionerIdVersionResponseIdentifierTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class GETPractitionerIdVersionResponseNameTypeItem
    {
        [JsonProperty("family")]
        public string Family { get; set; }

        [JsonProperty("given")]
        public string[] Given { get; set; }

        [JsonProperty("prefix")]
        public string[] Prefix { get; set; }
    }

    public class GETPractitionerIdVersionResponseTelecomTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("use")]
        public string Use { get; set; }
    }

    public class GETPractitionerIdVersionResponseAddressTypeItem
    {
        [JsonProperty("line")]
        public string[] Line { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("postalCode")]
        public string PostalCode { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }
    }

    public class GETPractitionerIdHistoryResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GETPractitionerIdHistoryResponseMetaType Meta { get; set; }

        [JsonProperty("identifier")]
        public GETPractitionerIdHistoryResponseIdentifierTypeItem[] Identifier { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("name")]
        public GETPractitionerIdHistoryResponseNameTypeItem[] Name { get; set; }

        [JsonProperty("telecom")]
        public GETPractitionerIdHistoryResponseTelecomTypeItem[] Telecom { get; set; }

        [JsonProperty("address")]
        public GETPractitionerIdHistoryResponseAddressTypeItem[] Address { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }
    }

    public class GETPractitionerIdHistoryResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GETPractitionerIdHistoryResponseIdentifierTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class GETPractitionerIdHistoryResponseNameTypeItem
    {
        [JsonProperty("family")]
        public string Family { get; set; }

        [JsonProperty("given")]
        public string[] Given { get; set; }

        [JsonProperty("prefix")]
        public string[] Prefix { get; set; }
    }

    public class GETPractitionerIdHistoryResponseTelecomTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("use")]
        public string Use { get; set; }
    }

    public class GETPractitionerIdHistoryResponseAddressTypeItem
    {
        [JsonProperty("line")]
        public string[] Line { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("postalCode")]
        public string PostalCode { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }
    }

    public class GETPractitionerHistoryResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GETPractitionerHistoryResponseMetaType Meta { get; set; }

        [JsonProperty("identifier")]
        public GETPractitionerHistoryResponseIdentifierTypeItem[] Identifier { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("name")]
        public GETPractitionerHistoryResponseNameTypeItem[] Name { get; set; }

        [JsonProperty("telecom")]
        public GETPractitionerHistoryResponseTelecomTypeItem[] Telecom { get; set; }

        [JsonProperty("address")]
        public GETPractitionerHistoryResponseAddressTypeItem[] Address { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }
    }

    public class GETPractitionerHistoryResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GETPractitionerHistoryResponseIdentifierTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class GETPractitionerHistoryResponseNameTypeItem
    {
        [JsonProperty("family")]
        public string Family { get; set; }

        [JsonProperty("given")]
        public string[] Given { get; set; }

        [JsonProperty("prefix")]
        public string[] Prefix { get; set; }
    }

    public class GETPractitionerHistoryResponseTelecomTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("use")]
        public string Use { get; set; }
    }

    public class GETPractitionerHistoryResponseAddressTypeItem
    {
        [JsonProperty("line")]
        public string[] Line { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("postalCode")]
        public string PostalCode { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Fhirbase;

    public partial class WorkflowManagedActions
    {
        public FhirbaseActions Fhirbase(string connectionId) => new FhirbaseActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public FhirbaseTriggers Fhirbase(string connectionId) => new FhirbaseTriggers(connectionId);
    }
}