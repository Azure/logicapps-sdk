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
        public IBodyWorkflowAction<GETAppointmentResponse> GETAppointment(Expression<Func<string>> patient = null, Expression<Func<string>> Count = null, Expression<Func<string>> Sort = null)
        {
            var apiCallPath = "/Appointment";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (patient != null)
                callPayload.Queries["patient"] = ExpressionConverter.Convert(patient);
            if (Count != null)
                callPayload.Queries["_count"] = ExpressionConverter.Convert(Count);
            if (Sort != null)
                callPayload.Queries["_sort"] = ExpressionConverter.Convert(Sort);
            return new ApiConnectionAction<GETAppointmentResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<POSTAppointmentResponse> POSTAppointment(Expression<Func<string>> bodyresourceType = null, Expression<Func<string>> bodyid = null, Expression<Func<string>> bodytextstatus = null, Expression<Func<string>> bodytextdiv = null, Expression<Func<string>> bodystatus = null, Expression<Func<bodyserviceCategoryInputItem[]>> bodyserviceCategory = null, Expression<Func<bodyserviceTypeInputItem[]>> bodyserviceType = null, Expression<Func<bodyspecialtyInputItem[]>> bodyspecialty = null, Expression<Func<bodyappointmentTypecodingInputItem[]>> bodyappointmentTypecoding = null, Expression<Func<bodyreasonReferenceInputItem[]>> bodyreasonReference = null, Expression<Func<int>> bodypriority = null, Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodystart = null, Expression<Func<string>> bodyend = null, Expression<Func<string>> bodycreated = null, Expression<Func<string>> bodycomment = null, Expression<Func<bodybasedOnInputItem[]>> bodybasedOn = null, Expression<Func<bodyparticipantInputItem[]>> bodyparticipant = null)
        {
            var apiCallPath = "/Appointment";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyresourceType != null)
            {
                body["resourceType"] = ExpressionConverter.ConvertO(bodyresourceType);
                bodypropCount++;
            }

            if (bodyid != null)
            {
                body["id"] = ExpressionConverter.ConvertO(bodyid);
                bodypropCount++;
            }

            var textObject = new JObject();
            var textObjectpropCount = 0;
            if (bodytextstatus != null)
            {
                textObject["status"] = ExpressionConverter.ConvertO(bodytextstatus);
                textObjectpropCount++;
            }

            if (bodytextdiv != null)
            {
                textObject["div"] = ExpressionConverter.ConvertO(bodytextdiv);
                textObjectpropCount++;
            }

            if (textObjectpropCount > 0)
            {
                body["text"] = textObject;
                bodypropCount++;
            }

            if (bodystatus != null)
            {
                body["status"] = ExpressionConverter.ConvertO(bodystatus);
                bodypropCount++;
            }

            if (bodyserviceCategory != null)
            {
                body["serviceCategory"] = ExpressionConverter.ConvertO(bodyserviceCategory);
                bodypropCount++;
            }

            if (bodyserviceType != null)
            {
                body["serviceType"] = ExpressionConverter.ConvertO(bodyserviceType);
                bodypropCount++;
            }

            if (bodyspecialty != null)
            {
                body["specialty"] = ExpressionConverter.ConvertO(bodyspecialty);
                bodypropCount++;
            }

            var appointmentTypeObject = new JObject();
            var appointmentTypeObjectpropCount = 0;
            if (bodyappointmentTypecoding != null)
            {
                appointmentTypeObject["coding"] = ExpressionConverter.ConvertO(bodyappointmentTypecoding);
                appointmentTypeObjectpropCount++;
            }

            if (appointmentTypeObjectpropCount > 0)
            {
                body["appointmentType"] = appointmentTypeObject;
                bodypropCount++;
            }

            if (bodyreasonReference != null)
            {
                body["reasonReference"] = ExpressionConverter.ConvertO(bodyreasonReference);
                bodypropCount++;
            }

            if (bodypriority != null)
            {
                body["priority"] = ExpressionConverter.ConvertO(bodypriority);
                bodypropCount++;
            }

            if (bodydescription != null)
            {
                body["description"] = ExpressionConverter.ConvertO(bodydescription);
                bodypropCount++;
            }

            if (bodystart != null)
            {
                body["start"] = ExpressionConverter.ConvertO(bodystart);
                bodypropCount++;
            }

            if (bodyend != null)
            {
                body["end"] = ExpressionConverter.ConvertO(bodyend);
                bodypropCount++;
            }

            if (bodycreated != null)
            {
                body["created"] = ExpressionConverter.ConvertO(bodycreated);
                bodypropCount++;
            }

            if (bodycomment != null)
            {
                body["comment"] = ExpressionConverter.ConvertO(bodycomment);
                bodypropCount++;
            }

            if (bodybasedOn != null)
            {
                body["basedOn"] = ExpressionConverter.ConvertO(bodybasedOn);
                bodypropCount++;
            }

            if (bodyparticipant != null)
            {
                body["participant"] = ExpressionConverter.ConvertO(bodyparticipant);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<POSTAppointmentResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GETAppointmentIDResponse> GETAppointmentID(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/Appointment/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GETAppointmentIDResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<DELETEAppointmentIDResponse> DELETEAppointmentID(Expression<Func<string>> id, Expression<Func<string>> bodyresourceType = null, Expression<Func<string>> bodyid = null, Expression<Func<string>> bodymetaversionId = null, Expression<Func<string>> bodymetalastUpdated = null, Expression<Func<string>> bodytextstatus = null, Expression<Func<string>> bodytextdiv = null, Expression<Func<string>> bodystatus = null, Expression<Func<bodyparticipantInputItem[]>> bodyparticipant = null)
        {
            var apiCallPath = String.Format("/Appointment/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyresourceType != null)
            {
                body["resourceType"] = ExpressionConverter.ConvertO(bodyresourceType);
                bodypropCount++;
            }

            if (bodyid != null)
            {
                body["id"] = ExpressionConverter.ConvertO(bodyid);
                bodypropCount++;
            }

            var metaObject = new JObject();
            var metaObjectpropCount = 0;
            if (bodymetaversionId != null)
            {
                metaObject["versionId"] = ExpressionConverter.ConvertO(bodymetaversionId);
                metaObjectpropCount++;
            }

            if (bodymetalastUpdated != null)
            {
                metaObject["lastUpdated"] = ExpressionConverter.ConvertO(bodymetalastUpdated);
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
                textObject["status"] = ExpressionConverter.ConvertO(bodytextstatus);
                textObjectpropCount++;
            }

            if (bodytextdiv != null)
            {
                textObject["div"] = ExpressionConverter.ConvertO(bodytextdiv);
                textObjectpropCount++;
            }

            if (textObjectpropCount > 0)
            {
                body["text"] = textObject;
                bodypropCount++;
            }

            if (bodystatus != null)
            {
                body["status"] = ExpressionConverter.ConvertO(bodystatus);
                bodypropCount++;
            }

            if (bodyparticipant != null)
            {
                body["participant"] = ExpressionConverter.ConvertO(bodyparticipant);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<DELETEAppointmentIDResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<PUTAppointmentIDResponse> PUTAppointmentID(Expression<Func<string>> id, Expression<Func<string>> bodyresourceType = null, Expression<Func<string>> bodyid = null, Expression<Func<string>> bodymetaversionId = null, Expression<Func<string>> bodymetalastUpdated = null, Expression<Func<string>> bodytextstatus = null, Expression<Func<string>> bodytextdiv = null, Expression<Func<string>> bodystatus = null, Expression<Func<bodyparticipantInputItem[]>> bodyparticipant = null)
        {
            var apiCallPath = String.Format("/Appointment/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyresourceType != null)
            {
                body["resourceType"] = ExpressionConverter.ConvertO(bodyresourceType);
                bodypropCount++;
            }

            if (bodyid != null)
            {
                body["id"] = ExpressionConverter.ConvertO(bodyid);
                bodypropCount++;
            }

            var metaObject = new JObject();
            var metaObjectpropCount = 0;
            if (bodymetaversionId != null)
            {
                metaObject["versionId"] = ExpressionConverter.ConvertO(bodymetaversionId);
                metaObjectpropCount++;
            }

            if (bodymetalastUpdated != null)
            {
                metaObject["lastUpdated"] = ExpressionConverter.ConvertO(bodymetalastUpdated);
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
                textObject["status"] = ExpressionConverter.ConvertO(bodytextstatus);
                textObjectpropCount++;
            }

            if (bodytextdiv != null)
            {
                textObject["div"] = ExpressionConverter.ConvertO(bodytextdiv);
                textObjectpropCount++;
            }

            if (textObjectpropCount > 0)
            {
                body["text"] = textObject;
                bodypropCount++;
            }

            if (bodystatus != null)
            {
                body["status"] = ExpressionConverter.ConvertO(bodystatus);
                bodypropCount++;
            }

            if (bodyparticipant != null)
            {
                body["participant"] = ExpressionConverter.ConvertO(bodyparticipant);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<PUTAppointmentIDResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GETAppointmentIDVERSIONResponse> GETAppointmentIDVERSION(Expression<Func<string>> id, Expression<Func<string>> vid)
        {
            var apiCallPath = String.Format("/Appointment/{0}/_history/{1}", ExpressionConverter.ConvertWithUrlEncoding(id, 1), ExpressionConverter.ConvertWithUrlEncoding(vid, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GETAppointmentIDVERSIONResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GETAppointmentIDHistoryResponse> GETAppointmentIDHistory(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/Appointment/{0}/_history", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GETAppointmentIDHistoryResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GETAppointmentHistoryResponse> GETAppointmentHistory(Expression<Func<string>> patient = null)
        {
            var apiCallPath = "/Appointment/_history";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (patient != null)
                callPayload.Queries["patient"] = ExpressionConverter.Convert(patient);
            return new ApiConnectionAction<GETAppointmentHistoryResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GETAppointmentResponseResponse> GETAppointmentResponse(Expression<Func<string>> Count = null, Expression<Func<string>> Sort = null, Expression<Func<string>> patient = null)
        {
            var apiCallPath = "/AppointmentResponse";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (Count != null)
                callPayload.Queries["_count"] = ExpressionConverter.Convert(Count);
            if (Sort != null)
                callPayload.Queries["_sort"] = ExpressionConverter.Convert(Sort);
            if (patient != null)
                callPayload.Queries["patient"] = ExpressionConverter.Convert(patient);
            return new ApiConnectionAction<GETAppointmentResponseResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<POSTAppointmentResponseResponse> POSTAppointmentResponse(Expression<Func<string>> bodyresourceType = null, Expression<Func<string>> bodyid = null, Expression<Func<string>> bodytextstatus = null, Expression<Func<string>> bodytextdiv = null, Expression<Func<string>> bodyappointmentreference = null, Expression<Func<string>> bodyappointmentdisplay = null, Expression<Func<string>> bodyactorreference = null, Expression<Func<string>> bodyactordisplay = null, Expression<Func<string>> bodyparticipantStatus = null)
        {
            var apiCallPath = "/AppointmentResponse";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyresourceType != null)
            {
                body["resourceType"] = ExpressionConverter.ConvertO(bodyresourceType);
                bodypropCount++;
            }

            if (bodyid != null)
            {
                body["id"] = ExpressionConverter.ConvertO(bodyid);
                bodypropCount++;
            }

            var textObject = new JObject();
            var textObjectpropCount = 0;
            if (bodytextstatus != null)
            {
                textObject["status"] = ExpressionConverter.ConvertO(bodytextstatus);
                textObjectpropCount++;
            }

            if (bodytextdiv != null)
            {
                textObject["div"] = ExpressionConverter.ConvertO(bodytextdiv);
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
                appointmentObject["reference"] = ExpressionConverter.ConvertO(bodyappointmentreference);
                appointmentObjectpropCount++;
            }

            if (bodyappointmentdisplay != null)
            {
                appointmentObject["display"] = ExpressionConverter.ConvertO(bodyappointmentdisplay);
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
                actorObject["reference"] = ExpressionConverter.ConvertO(bodyactorreference);
                actorObjectpropCount++;
            }

            if (bodyactordisplay != null)
            {
                actorObject["display"] = ExpressionConverter.ConvertO(bodyactordisplay);
                actorObjectpropCount++;
            }

            if (actorObjectpropCount > 0)
            {
                body["actor"] = actorObject;
                bodypropCount++;
            }

            if (bodyparticipantStatus != null)
            {
                body["participantStatus"] = ExpressionConverter.ConvertO(bodyparticipantStatus);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<POSTAppointmentResponseResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GETAppointmentResponseIDResponse> GETAppointmentResponseID(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/AppointmentResponse/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GETAppointmentResponseIDResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<DELETEAppointmentResponseIDResponse> DELETEAppointmentResponseID(Expression<Func<string>> id, Expression<Func<string>> bodyresourceType = null, Expression<Func<string>> bodyid = null, Expression<Func<string>> bodymetaversionId = null, Expression<Func<string>> bodymetalastUpdated = null, Expression<Func<string>> bodytextstatus = null, Expression<Func<string>> bodytextdiv = null, Expression<Func<string>> bodyappointmentreference = null, Expression<Func<string>> bodyappointmentdisplay = null, Expression<Func<string>> bodyactorreference = null, Expression<Func<string>> bodyactordisplay = null, Expression<Func<string>> bodyparticipantStatus = null)
        {
            var apiCallPath = String.Format("/AppointmentResponse/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyresourceType != null)
            {
                body["resourceType"] = ExpressionConverter.ConvertO(bodyresourceType);
                bodypropCount++;
            }

            if (bodyid != null)
            {
                body["id"] = ExpressionConverter.ConvertO(bodyid);
                bodypropCount++;
            }

            var metaObject = new JObject();
            var metaObjectpropCount = 0;
            if (bodymetaversionId != null)
            {
                metaObject["versionId"] = ExpressionConverter.ConvertO(bodymetaversionId);
                metaObjectpropCount++;
            }

            if (bodymetalastUpdated != null)
            {
                metaObject["lastUpdated"] = ExpressionConverter.ConvertO(bodymetalastUpdated);
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
                textObject["status"] = ExpressionConverter.ConvertO(bodytextstatus);
                textObjectpropCount++;
            }

            if (bodytextdiv != null)
            {
                textObject["div"] = ExpressionConverter.ConvertO(bodytextdiv);
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
                appointmentObject["reference"] = ExpressionConverter.ConvertO(bodyappointmentreference);
                appointmentObjectpropCount++;
            }

            if (bodyappointmentdisplay != null)
            {
                appointmentObject["display"] = ExpressionConverter.ConvertO(bodyappointmentdisplay);
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
                actorObject["reference"] = ExpressionConverter.ConvertO(bodyactorreference);
                actorObjectpropCount++;
            }

            if (bodyactordisplay != null)
            {
                actorObject["display"] = ExpressionConverter.ConvertO(bodyactordisplay);
                actorObjectpropCount++;
            }

            if (actorObjectpropCount > 0)
            {
                body["actor"] = actorObject;
                bodypropCount++;
            }

            if (bodyparticipantStatus != null)
            {
                body["participantStatus"] = ExpressionConverter.ConvertO(bodyparticipantStatus);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<DELETEAppointmentResponseIDResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<PUTAppointmentResponseIDResponse> PUTAppointmentResponseID(Expression<Func<string>> id, Expression<Func<string>> bodyresourceType = null, Expression<Func<string>> bodyid = null, Expression<Func<string>> bodymetaversionId = null, Expression<Func<string>> bodymetalastUpdated = null, Expression<Func<string>> bodytextstatus = null, Expression<Func<string>> bodytextdiv = null, Expression<Func<string>> bodyappointmentreference = null, Expression<Func<string>> bodyappointmentdisplay = null, Expression<Func<string>> bodyactorreference = null, Expression<Func<string>> bodyactordisplay = null, Expression<Func<string>> bodyparticipantStatus = null)
        {
            var apiCallPath = String.Format("/AppointmentResponse/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyresourceType != null)
            {
                body["resourceType"] = ExpressionConverter.ConvertO(bodyresourceType);
                bodypropCount++;
            }

            if (bodyid != null)
            {
                body["id"] = ExpressionConverter.ConvertO(bodyid);
                bodypropCount++;
            }

            var metaObject = new JObject();
            var metaObjectpropCount = 0;
            if (bodymetaversionId != null)
            {
                metaObject["versionId"] = ExpressionConverter.ConvertO(bodymetaversionId);
                metaObjectpropCount++;
            }

            if (bodymetalastUpdated != null)
            {
                metaObject["lastUpdated"] = ExpressionConverter.ConvertO(bodymetalastUpdated);
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
                textObject["status"] = ExpressionConverter.ConvertO(bodytextstatus);
                textObjectpropCount++;
            }

            if (bodytextdiv != null)
            {
                textObject["div"] = ExpressionConverter.ConvertO(bodytextdiv);
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
                appointmentObject["reference"] = ExpressionConverter.ConvertO(bodyappointmentreference);
                appointmentObjectpropCount++;
            }

            if (bodyappointmentdisplay != null)
            {
                appointmentObject["display"] = ExpressionConverter.ConvertO(bodyappointmentdisplay);
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
                actorObject["reference"] = ExpressionConverter.ConvertO(bodyactorreference);
                actorObjectpropCount++;
            }

            if (bodyactordisplay != null)
            {
                actorObject["display"] = ExpressionConverter.ConvertO(bodyactordisplay);
                actorObjectpropCount++;
            }

            if (actorObjectpropCount > 0)
            {
                body["actor"] = actorObject;
                bodypropCount++;
            }

            if (bodyparticipantStatus != null)
            {
                body["participantStatus"] = ExpressionConverter.ConvertO(bodyparticipantStatus);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<PUTAppointmentResponseIDResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GETAppointmentResponseIDVersionResponse> GETAppointmentResponseIDVersion(Expression<Func<string>> id, Expression<Func<string>> vid)
        {
            var apiCallPath = String.Format("/AppointmentResponse/{0}/_history/{1}", ExpressionConverter.ConvertWithUrlEncoding(id, 1), ExpressionConverter.ConvertWithUrlEncoding(vid, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GETAppointmentResponseIDVersionResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GETAppointmentResponseIDHistoryResponse> GETAppointmentResponseIDHistory(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/AppointmentResponse/{0}/_history", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GETAppointmentResponseIDHistoryResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GETAppointmentResponseHistoryResponse> GETAppointmentResponseHistory()
        {
            var apiCallPath = "/AppointmentResponse/_history";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GETAppointmentResponseHistoryResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GETDeviceResponse> GETDevice(Expression<Func<string>> Count = null, Expression<Func<string>> Sort = null, Expression<Func<string>> patient = null)
        {
            var apiCallPath = "/Device";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (Count != null)
                callPayload.Queries["_count"] = ExpressionConverter.Convert(Count);
            if (Sort != null)
                callPayload.Queries["_sort"] = ExpressionConverter.Convert(Sort);
            if (patient != null)
                callPayload.Queries["patient"] = ExpressionConverter.Convert(patient);
            return new ApiConnectionAction<GETDeviceResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<POSTDeviceResponse> POSTDevice(Expression<Func<string>> bodyresourceType = null, Expression<Func<string>> bodyid = null, Expression<Func<string>> bodymetaversionId = null, Expression<Func<string>> bodymetalastUpdated = null, Expression<Func<bodyudiCarrierInputItem[]>> bodyudiCarrier = null, Expression<Func<string>> bodystatus = null, Expression<Func<string>> bodydistinctIdentifier = null, Expression<Func<string>> bodymanufactureDate = null, Expression<Func<string>> bodyexpirationDate = null, Expression<Func<string>> bodylotNumber = null, Expression<Func<string>> bodyserialNumber = null, Expression<Func<bodydeviceNameInputItem[]>> bodydeviceName = null, Expression<Func<bodytypecodingInputItem[]>> bodytypecoding = null, Expression<Func<string>> bodytypetext = null, Expression<Func<string>> bodypatientreference = null)
        {
            var apiCallPath = "/Device";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyresourceType != null)
            {
                body["resourceType"] = ExpressionConverter.ConvertO(bodyresourceType);
                bodypropCount++;
            }

            if (bodyid != null)
            {
                body["id"] = ExpressionConverter.ConvertO(bodyid);
                bodypropCount++;
            }

            var metaObject = new JObject();
            var metaObjectpropCount = 0;
            if (bodymetaversionId != null)
            {
                metaObject["versionId"] = ExpressionConverter.ConvertO(bodymetaversionId);
                metaObjectpropCount++;
            }

            if (bodymetalastUpdated != null)
            {
                metaObject["lastUpdated"] = ExpressionConverter.ConvertO(bodymetalastUpdated);
                metaObjectpropCount++;
            }

            if (metaObjectpropCount > 0)
            {
                body["meta"] = metaObject;
                bodypropCount++;
            }

            if (bodyudiCarrier != null)
            {
                body["udiCarrier"] = ExpressionConverter.ConvertO(bodyudiCarrier);
                bodypropCount++;
            }

            if (bodystatus != null)
            {
                body["status"] = ExpressionConverter.ConvertO(bodystatus);
                bodypropCount++;
            }

            if (bodydistinctIdentifier != null)
            {
                body["distinctIdentifier"] = ExpressionConverter.ConvertO(bodydistinctIdentifier);
                bodypropCount++;
            }

            if (bodymanufactureDate != null)
            {
                body["manufactureDate"] = ExpressionConverter.ConvertO(bodymanufactureDate);
                bodypropCount++;
            }

            if (bodyexpirationDate != null)
            {
                body["expirationDate"] = ExpressionConverter.ConvertO(bodyexpirationDate);
                bodypropCount++;
            }

            if (bodylotNumber != null)
            {
                body["lotNumber"] = ExpressionConverter.ConvertO(bodylotNumber);
                bodypropCount++;
            }

            if (bodyserialNumber != null)
            {
                body["serialNumber"] = ExpressionConverter.ConvertO(bodyserialNumber);
                bodypropCount++;
            }

            if (bodydeviceName != null)
            {
                body["deviceName"] = ExpressionConverter.ConvertO(bodydeviceName);
                bodypropCount++;
            }

            var typeObject = new JObject();
            var typeObjectpropCount = 0;
            if (bodytypecoding != null)
            {
                typeObject["coding"] = ExpressionConverter.ConvertO(bodytypecoding);
                typeObjectpropCount++;
            }

            if (bodytypetext != null)
            {
                typeObject["text"] = ExpressionConverter.ConvertO(bodytypetext);
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
                patientObject["reference"] = ExpressionConverter.ConvertO(bodypatientreference);
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

            return new ApiConnectionAction<POSTDeviceResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GETDeviceIDResponse> GETDeviceID(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/Device/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GETDeviceIDResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<DELETEDeviceIDResponse> DELETEDeviceID(Expression<Func<string>> id, Expression<Func<string>> bodyresourceType = null, Expression<Func<string>> bodyid = null, Expression<Func<string>> bodymetaversionId = null, Expression<Func<string>> bodymetalastUpdated = null, Expression<Func<string>> bodytextstatus = null, Expression<Func<string>> bodytextdiv = null, Expression<Func<bodyidentifierInputItem[]>> bodyidentifier = null)
        {
            var apiCallPath = String.Format("/Device/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyresourceType != null)
            {
                body["resourceType"] = ExpressionConverter.ConvertO(bodyresourceType);
                bodypropCount++;
            }

            if (bodyid != null)
            {
                body["id"] = ExpressionConverter.ConvertO(bodyid);
                bodypropCount++;
            }

            var metaObject = new JObject();
            var metaObjectpropCount = 0;
            if (bodymetaversionId != null)
            {
                metaObject["versionId"] = ExpressionConverter.ConvertO(bodymetaversionId);
                metaObjectpropCount++;
            }

            if (bodymetalastUpdated != null)
            {
                metaObject["lastUpdated"] = ExpressionConverter.ConvertO(bodymetalastUpdated);
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
                textObject["status"] = ExpressionConverter.ConvertO(bodytextstatus);
                textObjectpropCount++;
            }

            if (bodytextdiv != null)
            {
                textObject["div"] = ExpressionConverter.ConvertO(bodytextdiv);
                textObjectpropCount++;
            }

            if (textObjectpropCount > 0)
            {
                body["text"] = textObject;
                bodypropCount++;
            }

            if (bodyidentifier != null)
            {
                body["identifier"] = ExpressionConverter.ConvertO(bodyidentifier);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<DELETEDeviceIDResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<PUTDeviceIDResponse> PUTDeviceID(Expression<Func<string>> id, Expression<Func<string>> bodyresourceType = null, Expression<Func<string>> bodyid = null, Expression<Func<string>> bodymetaversionId = null, Expression<Func<string>> bodymetalastUpdated = null, Expression<Func<string>> bodytextstatus = null, Expression<Func<string>> bodytextdiv = null, Expression<Func<bodyidentifierInputItem[]>> bodyidentifier = null)
        {
            var apiCallPath = String.Format("/Device/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyresourceType != null)
            {
                body["resourceType"] = ExpressionConverter.ConvertO(bodyresourceType);
                bodypropCount++;
            }

            if (bodyid != null)
            {
                body["id"] = ExpressionConverter.ConvertO(bodyid);
                bodypropCount++;
            }

            var metaObject = new JObject();
            var metaObjectpropCount = 0;
            if (bodymetaversionId != null)
            {
                metaObject["versionId"] = ExpressionConverter.ConvertO(bodymetaversionId);
                metaObjectpropCount++;
            }

            if (bodymetalastUpdated != null)
            {
                metaObject["lastUpdated"] = ExpressionConverter.ConvertO(bodymetalastUpdated);
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
                textObject["status"] = ExpressionConverter.ConvertO(bodytextstatus);
                textObjectpropCount++;
            }

            if (bodytextdiv != null)
            {
                textObject["div"] = ExpressionConverter.ConvertO(bodytextdiv);
                textObjectpropCount++;
            }

            if (textObjectpropCount > 0)
            {
                body["text"] = textObject;
                bodypropCount++;
            }

            if (bodyidentifier != null)
            {
                body["identifier"] = ExpressionConverter.ConvertO(bodyidentifier);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<PUTDeviceIDResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GETDeviceIDVERSIONResponse> GETDeviceIDVERSION(Expression<Func<string>> id, Expression<Func<string>> vid)
        {
            var apiCallPath = String.Format("/Device/{0}/_history/{1}", ExpressionConverter.ConvertWithUrlEncoding(id, 1), ExpressionConverter.ConvertWithUrlEncoding(vid, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GETDeviceIDVERSIONResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GETDeviceIDHISTORYResponse> GETDeviceIDHISTORY(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/Device/{0}/_history", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GETDeviceIDHISTORYResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GETDeviceHISTORYResponse> GETDeviceHISTORY()
        {
            var apiCallPath = "/Device/_history";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GETDeviceHISTORYResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GETEncounterResponse> GETEncounter(Expression<Func<string>> Count = null, Expression<Func<string>> Sort = null, Expression<Func<string>> patient = null)
        {
            var apiCallPath = "/Encounter";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (Count != null)
                callPayload.Queries["_count"] = ExpressionConverter.Convert(Count);
            if (Sort != null)
                callPayload.Queries["_sort"] = ExpressionConverter.Convert(Sort);
            if (patient != null)
                callPayload.Queries["patient"] = ExpressionConverter.Convert(patient);
            return new ApiConnectionAction<GETEncounterResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<POSTEncounterResponse> POSTEncounter(Expression<Func<string>> bodyresourceType = null, Expression<Func<string>> bodyid = null, Expression<Func<string>> bodymetaversionId = null, Expression<Func<string>> bodymetalastUpdated = null, Expression<Func<string>> bodystatus = null, Expression<Func<string>> bodyclasssystem = null, Expression<Func<string>> bodyclasscode = null, Expression<Func<bodytypeInputItem[]>> bodytype = null, Expression<Func<string>> bodysubjectreference = null, Expression<Func<string>> bodysubjectdisplay = null, Expression<Func<bodyparticipantInputItem2[]>> bodyparticipant = null, Expression<Func<string>> bodyperiodstart = null, Expression<Func<string>> bodyperiodend = null, Expression<Func<string>> bodyserviceProviderreference = null, Expression<Func<string>> bodyserviceProviderdisplay = null)
        {
            var apiCallPath = "/Encounter";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyresourceType != null)
            {
                body["resourceType"] = ExpressionConverter.ConvertO(bodyresourceType);
                bodypropCount++;
            }

            if (bodyid != null)
            {
                body["id"] = ExpressionConverter.ConvertO(bodyid);
                bodypropCount++;
            }

            var metaObject = new JObject();
            var metaObjectpropCount = 0;
            if (bodymetaversionId != null)
            {
                metaObject["versionId"] = ExpressionConverter.ConvertO(bodymetaversionId);
                metaObjectpropCount++;
            }

            if (bodymetalastUpdated != null)
            {
                metaObject["lastUpdated"] = ExpressionConverter.ConvertO(bodymetalastUpdated);
                metaObjectpropCount++;
            }

            if (metaObjectpropCount > 0)
            {
                body["meta"] = metaObject;
                bodypropCount++;
            }

            if (bodystatus != null)
            {
                body["status"] = ExpressionConverter.ConvertO(bodystatus);
                bodypropCount++;
            }

            var classObject = new JObject();
            var classObjectpropCount = 0;
            if (bodyclasssystem != null)
            {
                classObject["system"] = ExpressionConverter.ConvertO(bodyclasssystem);
                classObjectpropCount++;
            }

            if (bodyclasscode != null)
            {
                classObject["code"] = ExpressionConverter.ConvertO(bodyclasscode);
                classObjectpropCount++;
            }

            if (classObjectpropCount > 0)
            {
                body["class"] = classObject;
                bodypropCount++;
            }

            if (bodytype != null)
            {
                body["type"] = ExpressionConverter.ConvertO(bodytype);
                bodypropCount++;
            }

            var subjectObject = new JObject();
            var subjectObjectpropCount = 0;
            if (bodysubjectreference != null)
            {
                subjectObject["reference"] = ExpressionConverter.ConvertO(bodysubjectreference);
                subjectObjectpropCount++;
            }

            if (bodysubjectdisplay != null)
            {
                subjectObject["display"] = ExpressionConverter.ConvertO(bodysubjectdisplay);
                subjectObjectpropCount++;
            }

            if (subjectObjectpropCount > 0)
            {
                body["subject"] = subjectObject;
                bodypropCount++;
            }

            if (bodyparticipant != null)
            {
                body["participant"] = ExpressionConverter.ConvertO(bodyparticipant);
                bodypropCount++;
            }

            var periodObject = new JObject();
            var periodObjectpropCount = 0;
            if (bodyperiodstart != null)
            {
                periodObject["start"] = ExpressionConverter.ConvertO(bodyperiodstart);
                periodObjectpropCount++;
            }

            if (bodyperiodend != null)
            {
                periodObject["end"] = ExpressionConverter.ConvertO(bodyperiodend);
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
                serviceProviderObject["reference"] = ExpressionConverter.ConvertO(bodyserviceProviderreference);
                serviceProviderObjectpropCount++;
            }

            if (bodyserviceProviderdisplay != null)
            {
                serviceProviderObject["display"] = ExpressionConverter.ConvertO(bodyserviceProviderdisplay);
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

            return new ApiConnectionAction<POSTEncounterResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GETEncounterIDResponse> GETEncounterID(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/Encounter/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GETEncounterIDResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<DELETEEncounterIDResponse> DELETEEncounterID(Expression<Func<string>> id, Expression<Func<string>> bodyresourceType = null, Expression<Func<string>> bodyid = null, Expression<Func<string>> bodymetaversionId = null, Expression<Func<string>> bodymetalastUpdated = null, Expression<Func<string>> bodystatus = null, Expression<Func<string>> bodyclasssystem = null, Expression<Func<string>> bodyclasscode = null, Expression<Func<bodytypeInputItem[]>> bodytype = null, Expression<Func<string>> bodysubjectreference = null, Expression<Func<string>> bodysubjectdisplay = null, Expression<Func<bodyparticipantInputItem2[]>> bodyparticipant = null, Expression<Func<string>> bodyperiodstart = null, Expression<Func<string>> bodyperiodend = null, Expression<Func<string>> bodyserviceProviderreference = null, Expression<Func<string>> bodyserviceProviderdisplay = null)
        {
            var apiCallPath = String.Format("/Encounter/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyresourceType != null)
            {
                body["resourceType"] = ExpressionConverter.ConvertO(bodyresourceType);
                bodypropCount++;
            }

            if (bodyid != null)
            {
                body["id"] = ExpressionConverter.ConvertO(bodyid);
                bodypropCount++;
            }

            var metaObject = new JObject();
            var metaObjectpropCount = 0;
            if (bodymetaversionId != null)
            {
                metaObject["versionId"] = ExpressionConverter.ConvertO(bodymetaversionId);
                metaObjectpropCount++;
            }

            if (bodymetalastUpdated != null)
            {
                metaObject["lastUpdated"] = ExpressionConverter.ConvertO(bodymetalastUpdated);
                metaObjectpropCount++;
            }

            if (metaObjectpropCount > 0)
            {
                body["meta"] = metaObject;
                bodypropCount++;
            }

            if (bodystatus != null)
            {
                body["status"] = ExpressionConverter.ConvertO(bodystatus);
                bodypropCount++;
            }

            var classObject = new JObject();
            var classObjectpropCount = 0;
            if (bodyclasssystem != null)
            {
                classObject["system"] = ExpressionConverter.ConvertO(bodyclasssystem);
                classObjectpropCount++;
            }

            if (bodyclasscode != null)
            {
                classObject["code"] = ExpressionConverter.ConvertO(bodyclasscode);
                classObjectpropCount++;
            }

            if (classObjectpropCount > 0)
            {
                body["class"] = classObject;
                bodypropCount++;
            }

            if (bodytype != null)
            {
                body["type"] = ExpressionConverter.ConvertO(bodytype);
                bodypropCount++;
            }

            var subjectObject = new JObject();
            var subjectObjectpropCount = 0;
            if (bodysubjectreference != null)
            {
                subjectObject["reference"] = ExpressionConverter.ConvertO(bodysubjectreference);
                subjectObjectpropCount++;
            }

            if (bodysubjectdisplay != null)
            {
                subjectObject["display"] = ExpressionConverter.ConvertO(bodysubjectdisplay);
                subjectObjectpropCount++;
            }

            if (subjectObjectpropCount > 0)
            {
                body["subject"] = subjectObject;
                bodypropCount++;
            }

            if (bodyparticipant != null)
            {
                body["participant"] = ExpressionConverter.ConvertO(bodyparticipant);
                bodypropCount++;
            }

            var periodObject = new JObject();
            var periodObjectpropCount = 0;
            if (bodyperiodstart != null)
            {
                periodObject["start"] = ExpressionConverter.ConvertO(bodyperiodstart);
                periodObjectpropCount++;
            }

            if (bodyperiodend != null)
            {
                periodObject["end"] = ExpressionConverter.ConvertO(bodyperiodend);
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
                serviceProviderObject["reference"] = ExpressionConverter.ConvertO(bodyserviceProviderreference);
                serviceProviderObjectpropCount++;
            }

            if (bodyserviceProviderdisplay != null)
            {
                serviceProviderObject["display"] = ExpressionConverter.ConvertO(bodyserviceProviderdisplay);
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

            return new ApiConnectionAction<DELETEEncounterIDResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<PUTEncounterIDResponse> PUTEncounterID(Expression<Func<string>> id, Expression<Func<string>> bodyresourceType = null, Expression<Func<string>> bodyid = null, Expression<Func<string>> bodymetaversionId = null, Expression<Func<string>> bodymetalastUpdated = null, Expression<Func<string>> bodystatus = null, Expression<Func<string>> bodyclasssystem = null, Expression<Func<string>> bodyclasscode = null, Expression<Func<bodytypeInputItem[]>> bodytype = null, Expression<Func<string>> bodysubjectreference = null, Expression<Func<string>> bodysubjectdisplay = null, Expression<Func<bodyparticipantInputItem2[]>> bodyparticipant = null, Expression<Func<string>> bodyperiodstart = null, Expression<Func<string>> bodyperiodend = null, Expression<Func<string>> bodyserviceProviderreference = null, Expression<Func<string>> bodyserviceProviderdisplay = null)
        {
            var apiCallPath = String.Format("/Encounter/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyresourceType != null)
            {
                body["resourceType"] = ExpressionConverter.ConvertO(bodyresourceType);
                bodypropCount++;
            }

            if (bodyid != null)
            {
                body["id"] = ExpressionConverter.ConvertO(bodyid);
                bodypropCount++;
            }

            var metaObject = new JObject();
            var metaObjectpropCount = 0;
            if (bodymetaversionId != null)
            {
                metaObject["versionId"] = ExpressionConverter.ConvertO(bodymetaversionId);
                metaObjectpropCount++;
            }

            if (bodymetalastUpdated != null)
            {
                metaObject["lastUpdated"] = ExpressionConverter.ConvertO(bodymetalastUpdated);
                metaObjectpropCount++;
            }

            if (metaObjectpropCount > 0)
            {
                body["meta"] = metaObject;
                bodypropCount++;
            }

            if (bodystatus != null)
            {
                body["status"] = ExpressionConverter.ConvertO(bodystatus);
                bodypropCount++;
            }

            var classObject = new JObject();
            var classObjectpropCount = 0;
            if (bodyclasssystem != null)
            {
                classObject["system"] = ExpressionConverter.ConvertO(bodyclasssystem);
                classObjectpropCount++;
            }

            if (bodyclasscode != null)
            {
                classObject["code"] = ExpressionConverter.ConvertO(bodyclasscode);
                classObjectpropCount++;
            }

            if (classObjectpropCount > 0)
            {
                body["class"] = classObject;
                bodypropCount++;
            }

            if (bodytype != null)
            {
                body["type"] = ExpressionConverter.ConvertO(bodytype);
                bodypropCount++;
            }

            var subjectObject = new JObject();
            var subjectObjectpropCount = 0;
            if (bodysubjectreference != null)
            {
                subjectObject["reference"] = ExpressionConverter.ConvertO(bodysubjectreference);
                subjectObjectpropCount++;
            }

            if (bodysubjectdisplay != null)
            {
                subjectObject["display"] = ExpressionConverter.ConvertO(bodysubjectdisplay);
                subjectObjectpropCount++;
            }

            if (subjectObjectpropCount > 0)
            {
                body["subject"] = subjectObject;
                bodypropCount++;
            }

            if (bodyparticipant != null)
            {
                body["participant"] = ExpressionConverter.ConvertO(bodyparticipant);
                bodypropCount++;
            }

            var periodObject = new JObject();
            var periodObjectpropCount = 0;
            if (bodyperiodstart != null)
            {
                periodObject["start"] = ExpressionConverter.ConvertO(bodyperiodstart);
                periodObjectpropCount++;
            }

            if (bodyperiodend != null)
            {
                periodObject["end"] = ExpressionConverter.ConvertO(bodyperiodend);
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
                serviceProviderObject["reference"] = ExpressionConverter.ConvertO(bodyserviceProviderreference);
                serviceProviderObjectpropCount++;
            }

            if (bodyserviceProviderdisplay != null)
            {
                serviceProviderObject["display"] = ExpressionConverter.ConvertO(bodyserviceProviderdisplay);
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

            return new ApiConnectionAction<PUTEncounterIDResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GETEncounterIDVersionResponse> GETEncounterIDVersion(Expression<Func<string>> id, Expression<Func<string>> vid)
        {
            var apiCallPath = String.Format("/Encounter/{0}/_history/{1}", ExpressionConverter.ConvertWithUrlEncoding(id, 1), ExpressionConverter.ConvertWithUrlEncoding(vid, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GETEncounterIDVersionResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GETEncounterIDHISTORYResponse> GETEncounterIDHISTORY(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/Encounter/{0}/_history", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GETEncounterIDHISTORYResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GETEncounterHISTORYResponse> GETEncounterHISTORY()
        {
            var apiCallPath = "/Encounter/_history";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GETEncounterHISTORYResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GETFlagResponse> GETFlag(Expression<Func<string>> Count = null, Expression<Func<string>> Sort = null, Expression<Func<string>> patient = null)
        {
            var apiCallPath = "/Flag";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (Count != null)
                callPayload.Queries["_count"] = ExpressionConverter.Convert(Count);
            if (Sort != null)
                callPayload.Queries["_sort"] = ExpressionConverter.Convert(Sort);
            if (patient != null)
                callPayload.Queries["patient"] = ExpressionConverter.Convert(patient);
            return new ApiConnectionAction<GETFlagResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<POSTFLAGResponse> POSTFLAG(Expression<Func<string>> bodyresourceType = null, Expression<Func<string>> bodyid = null, Expression<Func<string>> bodytextstatus = null, Expression<Func<string>> bodytextdiv = null, Expression<Func<bodyidentifierInputItem2[]>> bodyidentifier = null, Expression<Func<string>> bodystatus = null, Expression<Func<bodycategoryInputItem[]>> bodycategory = null, Expression<Func<bodycodecodingInputItem[]>> bodycodecoding = null, Expression<Func<string>> bodycodetext = null, Expression<Func<string>> bodysubjectreference = null, Expression<Func<string>> bodysubjectdisplay = null, Expression<Func<string>> bodyperiodstart = null, Expression<Func<string>> bodyperiodend = null, Expression<Func<string>> bodyauthorreference = null, Expression<Func<string>> bodyauthordisplay = null)
        {
            var apiCallPath = "/Flag";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyresourceType != null)
            {
                body["resourceType"] = ExpressionConverter.ConvertO(bodyresourceType);
                bodypropCount++;
            }

            if (bodyid != null)
            {
                body["id"] = ExpressionConverter.ConvertO(bodyid);
                bodypropCount++;
            }

            var textObject = new JObject();
            var textObjectpropCount = 0;
            if (bodytextstatus != null)
            {
                textObject["status"] = ExpressionConverter.ConvertO(bodytextstatus);
                textObjectpropCount++;
            }

            if (bodytextdiv != null)
            {
                textObject["div"] = ExpressionConverter.ConvertO(bodytextdiv);
                textObjectpropCount++;
            }

            if (textObjectpropCount > 0)
            {
                body["text"] = textObject;
                bodypropCount++;
            }

            if (bodyidentifier != null)
            {
                body["identifier"] = ExpressionConverter.ConvertO(bodyidentifier);
                bodypropCount++;
            }

            if (bodystatus != null)
            {
                body["status"] = ExpressionConverter.ConvertO(bodystatus);
                bodypropCount++;
            }

            if (bodycategory != null)
            {
                body["category"] = ExpressionConverter.ConvertO(bodycategory);
                bodypropCount++;
            }

            var codeObject = new JObject();
            var codeObjectpropCount = 0;
            if (bodycodecoding != null)
            {
                codeObject["coding"] = ExpressionConverter.ConvertO(bodycodecoding);
                codeObjectpropCount++;
            }

            if (bodycodetext != null)
            {
                codeObject["text"] = ExpressionConverter.ConvertO(bodycodetext);
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
                subjectObject["reference"] = ExpressionConverter.ConvertO(bodysubjectreference);
                subjectObjectpropCount++;
            }

            if (bodysubjectdisplay != null)
            {
                subjectObject["display"] = ExpressionConverter.ConvertO(bodysubjectdisplay);
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
                periodObject["start"] = ExpressionConverter.ConvertO(bodyperiodstart);
                periodObjectpropCount++;
            }

            if (bodyperiodend != null)
            {
                periodObject["end"] = ExpressionConverter.ConvertO(bodyperiodend);
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
                authorObject["reference"] = ExpressionConverter.ConvertO(bodyauthorreference);
                authorObjectpropCount++;
            }

            if (bodyauthordisplay != null)
            {
                authorObject["display"] = ExpressionConverter.ConvertO(bodyauthordisplay);
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

            return new ApiConnectionAction<POSTFLAGResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GETFlagIDResponse> GETFlagID(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/Flag/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GETFlagIDResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<DELETEFlagIDResponse> DELETEFlagID(Expression<Func<string>> id, Expression<Func<string>> bodyresourceType = null, Expression<Func<string>> bodyid = null, Expression<Func<string>> bodytextstatus = null, Expression<Func<string>> bodytextdiv = null, Expression<Func<bodyidentifierInputItem2[]>> bodyidentifier = null, Expression<Func<string>> bodystatus = null, Expression<Func<bodycategoryInputItem[]>> bodycategory = null, Expression<Func<bodycodecodingInputItem[]>> bodycodecoding = null, Expression<Func<string>> bodycodetext = null, Expression<Func<string>> bodysubjectreference = null, Expression<Func<string>> bodysubjectdisplay = null, Expression<Func<string>> bodyperiodstart = null, Expression<Func<string>> bodyperiodend = null, Expression<Func<string>> bodyauthorreference = null, Expression<Func<string>> bodyauthordisplay = null)
        {
            var apiCallPath = String.Format("/Flag/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyresourceType != null)
            {
                body["resourceType"] = ExpressionConverter.ConvertO(bodyresourceType);
                bodypropCount++;
            }

            if (bodyid != null)
            {
                body["id"] = ExpressionConverter.ConvertO(bodyid);
                bodypropCount++;
            }

            var textObject = new JObject();
            var textObjectpropCount = 0;
            if (bodytextstatus != null)
            {
                textObject["status"] = ExpressionConverter.ConvertO(bodytextstatus);
                textObjectpropCount++;
            }

            if (bodytextdiv != null)
            {
                textObject["div"] = ExpressionConverter.ConvertO(bodytextdiv);
                textObjectpropCount++;
            }

            if (textObjectpropCount > 0)
            {
                body["text"] = textObject;
                bodypropCount++;
            }

            if (bodyidentifier != null)
            {
                body["identifier"] = ExpressionConverter.ConvertO(bodyidentifier);
                bodypropCount++;
            }

            if (bodystatus != null)
            {
                body["status"] = ExpressionConverter.ConvertO(bodystatus);
                bodypropCount++;
            }

            if (bodycategory != null)
            {
                body["category"] = ExpressionConverter.ConvertO(bodycategory);
                bodypropCount++;
            }

            var codeObject = new JObject();
            var codeObjectpropCount = 0;
            if (bodycodecoding != null)
            {
                codeObject["coding"] = ExpressionConverter.ConvertO(bodycodecoding);
                codeObjectpropCount++;
            }

            if (bodycodetext != null)
            {
                codeObject["text"] = ExpressionConverter.ConvertO(bodycodetext);
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
                subjectObject["reference"] = ExpressionConverter.ConvertO(bodysubjectreference);
                subjectObjectpropCount++;
            }

            if (bodysubjectdisplay != null)
            {
                subjectObject["display"] = ExpressionConverter.ConvertO(bodysubjectdisplay);
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
                periodObject["start"] = ExpressionConverter.ConvertO(bodyperiodstart);
                periodObjectpropCount++;
            }

            if (bodyperiodend != null)
            {
                periodObject["end"] = ExpressionConverter.ConvertO(bodyperiodend);
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
                authorObject["reference"] = ExpressionConverter.ConvertO(bodyauthorreference);
                authorObjectpropCount++;
            }

            if (bodyauthordisplay != null)
            {
                authorObject["display"] = ExpressionConverter.ConvertO(bodyauthordisplay);
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

            return new ApiConnectionAction<DELETEFlagIDResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<PUTFlagIDResponse> PUTFlagID(Expression<Func<string>> id, Expression<Func<string>> bodyresourceType = null, Expression<Func<string>> bodyid = null, Expression<Func<string>> bodytextstatus = null, Expression<Func<string>> bodytextdiv = null, Expression<Func<bodyidentifierInputItem2[]>> bodyidentifier = null, Expression<Func<string>> bodystatus = null, Expression<Func<bodycategoryInputItem[]>> bodycategory = null, Expression<Func<bodycodecodingInputItem[]>> bodycodecoding = null, Expression<Func<string>> bodycodetext = null, Expression<Func<string>> bodysubjectreference = null, Expression<Func<string>> bodysubjectdisplay = null, Expression<Func<string>> bodyperiodstart = null, Expression<Func<string>> bodyperiodend = null, Expression<Func<string>> bodyauthorreference = null, Expression<Func<string>> bodyauthordisplay = null)
        {
            var apiCallPath = String.Format("/Flag/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyresourceType != null)
            {
                body["resourceType"] = ExpressionConverter.ConvertO(bodyresourceType);
                bodypropCount++;
            }

            if (bodyid != null)
            {
                body["id"] = ExpressionConverter.ConvertO(bodyid);
                bodypropCount++;
            }

            var textObject = new JObject();
            var textObjectpropCount = 0;
            if (bodytextstatus != null)
            {
                textObject["status"] = ExpressionConverter.ConvertO(bodytextstatus);
                textObjectpropCount++;
            }

            if (bodytextdiv != null)
            {
                textObject["div"] = ExpressionConverter.ConvertO(bodytextdiv);
                textObjectpropCount++;
            }

            if (textObjectpropCount > 0)
            {
                body["text"] = textObject;
                bodypropCount++;
            }

            if (bodyidentifier != null)
            {
                body["identifier"] = ExpressionConverter.ConvertO(bodyidentifier);
                bodypropCount++;
            }

            if (bodystatus != null)
            {
                body["status"] = ExpressionConverter.ConvertO(bodystatus);
                bodypropCount++;
            }

            if (bodycategory != null)
            {
                body["category"] = ExpressionConverter.ConvertO(bodycategory);
                bodypropCount++;
            }

            var codeObject = new JObject();
            var codeObjectpropCount = 0;
            if (bodycodecoding != null)
            {
                codeObject["coding"] = ExpressionConverter.ConvertO(bodycodecoding);
                codeObjectpropCount++;
            }

            if (bodycodetext != null)
            {
                codeObject["text"] = ExpressionConverter.ConvertO(bodycodetext);
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
                subjectObject["reference"] = ExpressionConverter.ConvertO(bodysubjectreference);
                subjectObjectpropCount++;
            }

            if (bodysubjectdisplay != null)
            {
                subjectObject["display"] = ExpressionConverter.ConvertO(bodysubjectdisplay);
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
                periodObject["start"] = ExpressionConverter.ConvertO(bodyperiodstart);
                periodObjectpropCount++;
            }

            if (bodyperiodend != null)
            {
                periodObject["end"] = ExpressionConverter.ConvertO(bodyperiodend);
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
                authorObject["reference"] = ExpressionConverter.ConvertO(bodyauthorreference);
                authorObjectpropCount++;
            }

            if (bodyauthordisplay != null)
            {
                authorObject["display"] = ExpressionConverter.ConvertO(bodyauthordisplay);
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

            return new ApiConnectionAction<PUTFlagIDResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GETFlagIDVersionResponse> GETFlagIDVersion(Expression<Func<string>> id, Expression<Func<string>> vid)
        {
            var apiCallPath = String.Format("/Flag/{0}/_history/{1}", ExpressionConverter.ConvertWithUrlEncoding(id, 1), ExpressionConverter.ConvertWithUrlEncoding(vid, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GETFlagIDVersionResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GETFlagIDHistoryResponse> GETFlagIDHistory(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/Flag/{0}/_history", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GETFlagIDHistoryResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GETFlagHISTORYResponse> GETFlagHISTORY()
        {
            var apiCallPath = "/Flag/_history";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GETFlagHISTORYResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GETLocationResponse> GETLocation(Expression<Func<string>> Count = null, Expression<Func<string>> Sort = null, Expression<Func<string>> patient = null)
        {
            var apiCallPath = "/Location";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (Count != null)
                callPayload.Queries["_count"] = ExpressionConverter.Convert(Count);
            if (Sort != null)
                callPayload.Queries["_sort"] = ExpressionConverter.Convert(Sort);
            if (patient != null)
                callPayload.Queries["patient"] = ExpressionConverter.Convert(patient);
            return new ApiConnectionAction<GETLocationResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<POSTLocationResponse> POSTLocation(Expression<Func<string>> bodyresourceType = null, Expression<Func<string>> bodyid = null, Expression<Func<string>> bodytextstatus = null, Expression<Func<string>> bodytextdiv = null, Expression<Func<string>> bodystatus = null, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodymode = null, Expression<Func<string>> bodypartOfreference = null, Expression<Func<string>> bodypartOfdisplay = null)
        {
            var apiCallPath = "/Location";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyresourceType != null)
            {
                body["resourceType"] = ExpressionConverter.ConvertO(bodyresourceType);
                bodypropCount++;
            }

            if (bodyid != null)
            {
                body["id"] = ExpressionConverter.ConvertO(bodyid);
                bodypropCount++;
            }

            var textObject = new JObject();
            var textObjectpropCount = 0;
            if (bodytextstatus != null)
            {
                textObject["status"] = ExpressionConverter.ConvertO(bodytextstatus);
                textObjectpropCount++;
            }

            if (bodytextdiv != null)
            {
                textObject["div"] = ExpressionConverter.ConvertO(bodytextdiv);
                textObjectpropCount++;
            }

            if (textObjectpropCount > 0)
            {
                body["text"] = textObject;
                bodypropCount++;
            }

            if (bodystatus != null)
            {
                body["status"] = ExpressionConverter.ConvertO(bodystatus);
                bodypropCount++;
            }

            if (bodyname != null)
            {
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
            }

            if (bodymode != null)
            {
                body["mode"] = ExpressionConverter.ConvertO(bodymode);
                bodypropCount++;
            }

            var partOfObject = new JObject();
            var partOfObjectpropCount = 0;
            if (bodypartOfreference != null)
            {
                partOfObject["reference"] = ExpressionConverter.ConvertO(bodypartOfreference);
                partOfObjectpropCount++;
            }

            if (bodypartOfdisplay != null)
            {
                partOfObject["display"] = ExpressionConverter.ConvertO(bodypartOfdisplay);
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

            return new ApiConnectionAction<POSTLocationResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GETLocationIDResponse> GETLocationID(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/Location/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GETLocationIDResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<DELETELocationIDResponse> DELETELocationID(Expression<Func<string>> id, Expression<Func<string>> bodyresourceType = null, Expression<Func<string>> bodyid = null, Expression<Func<string>> bodytextstatus = null, Expression<Func<string>> bodytextdiv = null, Expression<Func<string>> bodystatus = null, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodymode = null, Expression<Func<string>> bodypartOfreference = null, Expression<Func<string>> bodypartOfdisplay = null)
        {
            var apiCallPath = String.Format("/Location/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyresourceType != null)
            {
                body["resourceType"] = ExpressionConverter.ConvertO(bodyresourceType);
                bodypropCount++;
            }

            if (bodyid != null)
            {
                body["id"] = ExpressionConverter.ConvertO(bodyid);
                bodypropCount++;
            }

            var textObject = new JObject();
            var textObjectpropCount = 0;
            if (bodytextstatus != null)
            {
                textObject["status"] = ExpressionConverter.ConvertO(bodytextstatus);
                textObjectpropCount++;
            }

            if (bodytextdiv != null)
            {
                textObject["div"] = ExpressionConverter.ConvertO(bodytextdiv);
                textObjectpropCount++;
            }

            if (textObjectpropCount > 0)
            {
                body["text"] = textObject;
                bodypropCount++;
            }

            if (bodystatus != null)
            {
                body["status"] = ExpressionConverter.ConvertO(bodystatus);
                bodypropCount++;
            }

            if (bodyname != null)
            {
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
            }

            if (bodymode != null)
            {
                body["mode"] = ExpressionConverter.ConvertO(bodymode);
                bodypropCount++;
            }

            var partOfObject = new JObject();
            var partOfObjectpropCount = 0;
            if (bodypartOfreference != null)
            {
                partOfObject["reference"] = ExpressionConverter.ConvertO(bodypartOfreference);
                partOfObjectpropCount++;
            }

            if (bodypartOfdisplay != null)
            {
                partOfObject["display"] = ExpressionConverter.ConvertO(bodypartOfdisplay);
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

            return new ApiConnectionAction<DELETELocationIDResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<PUTLocationIDResponse> PUTLocationID(Expression<Func<string>> id, Expression<Func<string>> bodyresourceType = null, Expression<Func<string>> bodyid = null, Expression<Func<string>> bodytextstatus = null, Expression<Func<string>> bodytextdiv = null, Expression<Func<string>> bodystatus = null, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodymode = null, Expression<Func<string>> bodypartOfreference = null, Expression<Func<string>> bodypartOfdisplay = null)
        {
            var apiCallPath = String.Format("/Location/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyresourceType != null)
            {
                body["resourceType"] = ExpressionConverter.ConvertO(bodyresourceType);
                bodypropCount++;
            }

            if (bodyid != null)
            {
                body["id"] = ExpressionConverter.ConvertO(bodyid);
                bodypropCount++;
            }

            var textObject = new JObject();
            var textObjectpropCount = 0;
            if (bodytextstatus != null)
            {
                textObject["status"] = ExpressionConverter.ConvertO(bodytextstatus);
                textObjectpropCount++;
            }

            if (bodytextdiv != null)
            {
                textObject["div"] = ExpressionConverter.ConvertO(bodytextdiv);
                textObjectpropCount++;
            }

            if (textObjectpropCount > 0)
            {
                body["text"] = textObject;
                bodypropCount++;
            }

            if (bodystatus != null)
            {
                body["status"] = ExpressionConverter.ConvertO(bodystatus);
                bodypropCount++;
            }

            if (bodyname != null)
            {
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
            }

            if (bodymode != null)
            {
                body["mode"] = ExpressionConverter.ConvertO(bodymode);
                bodypropCount++;
            }

            var partOfObject = new JObject();
            var partOfObjectpropCount = 0;
            if (bodypartOfreference != null)
            {
                partOfObject["reference"] = ExpressionConverter.ConvertO(bodypartOfreference);
                partOfObjectpropCount++;
            }

            if (bodypartOfdisplay != null)
            {
                partOfObject["display"] = ExpressionConverter.ConvertO(bodypartOfdisplay);
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

            return new ApiConnectionAction<PUTLocationIDResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GETLocationIDVersionResponse> GETLocationIDVersion(Expression<Func<string>> id, Expression<Func<string>> vid)
        {
            var apiCallPath = String.Format("/Location/{0}/_history/{1}", ExpressionConverter.ConvertWithUrlEncoding(id, 1), ExpressionConverter.ConvertWithUrlEncoding(vid, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GETLocationIDVersionResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GETLocationIDHistoryResponse> GETLocationIDHistory(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/Location/{0}/_history", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GETLocationIDHistoryResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GETLocationHistoryResponse> GETLocationHistory()
        {
            var apiCallPath = "/Location/_history";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GETLocationHistoryResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GETPatientResponse> GETPatient(Expression<Func<string>> Count = null, Expression<Func<string>> Sort = null, Expression<Func<string>> patient = null)
        {
            var apiCallPath = "/Patient";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (Count != null)
                callPayload.Queries["_count"] = ExpressionConverter.Convert(Count);
            if (Sort != null)
                callPayload.Queries["_sort"] = ExpressionConverter.Convert(Sort);
            if (patient != null)
                callPayload.Queries["patient"] = ExpressionConverter.Convert(patient);
            return new ApiConnectionAction<GETPatientResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<POSTPatientResponse> POSTPatient(Expression<Func<string>> bodyresourceType = null, Expression<Func<bool>> bodyactive = null, Expression<Func<bodynameInputItem[]>> bodyname = null, Expression<Func<bodytelecomInputItem[]>> bodytelecom = null, Expression<Func<string>> bodygender = null, Expression<Func<string>> bodybirthDate = null, Expression<Func<bool>> bodydeceasedBoolean = null, Expression<Func<bodyaddressInputItem[]>> bodyaddress = null)
        {
            var apiCallPath = "/Patient";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyresourceType != null)
            {
                body["resourceType"] = ExpressionConverter.ConvertO(bodyresourceType);
                bodypropCount++;
            }

            if (bodyactive != null)
            {
                body["active"] = ExpressionConverter.ConvertO(bodyactive);
                bodypropCount++;
            }

            if (bodyname != null)
            {
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
            }

            if (bodytelecom != null)
            {
                body["telecom"] = ExpressionConverter.ConvertO(bodytelecom);
                bodypropCount++;
            }

            if (bodygender != null)
            {
                body["gender"] = ExpressionConverter.ConvertO(bodygender);
                bodypropCount++;
            }

            if (bodybirthDate != null)
            {
                body["birthDate"] = ExpressionConverter.ConvertO(bodybirthDate);
                bodypropCount++;
            }

            if (bodydeceasedBoolean != null)
            {
                body["deceasedBoolean"] = ExpressionConverter.ConvertO(bodydeceasedBoolean);
                bodypropCount++;
            }

            if (bodyaddress != null)
            {
                body["address"] = ExpressionConverter.ConvertO(bodyaddress);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<POSTPatientResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GETPatientIDResponse> GETPatientID(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/Patient/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GETPatientIDResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<DELETEPatientIDResponse> DELETEPatientID(Expression<Func<string>> id, Expression<Func<string>> bodyresourceType = null, Expression<Func<string>> bodyid = null, Expression<Func<bool>> bodyactive = null, Expression<Func<bodynameInputItem[]>> bodyname = null, Expression<Func<bodytelecomInputItem[]>> bodytelecom = null, Expression<Func<string>> bodygender = null, Expression<Func<string>> bodybirthDate = null, Expression<Func<bool>> bodydeceasedBoolean = null, Expression<Func<bodyaddressInputItem[]>> bodyaddress = null)
        {
            var apiCallPath = String.Format("/Patient/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyresourceType != null)
            {
                body["resourceType"] = ExpressionConverter.ConvertO(bodyresourceType);
                bodypropCount++;
            }

            if (bodyid != null)
            {
                body["id"] = ExpressionConverter.ConvertO(bodyid);
                bodypropCount++;
            }

            if (bodyactive != null)
            {
                body["active"] = ExpressionConverter.ConvertO(bodyactive);
                bodypropCount++;
            }

            if (bodyname != null)
            {
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
            }

            if (bodytelecom != null)
            {
                body["telecom"] = ExpressionConverter.ConvertO(bodytelecom);
                bodypropCount++;
            }

            if (bodygender != null)
            {
                body["gender"] = ExpressionConverter.ConvertO(bodygender);
                bodypropCount++;
            }

            if (bodybirthDate != null)
            {
                body["birthDate"] = ExpressionConverter.ConvertO(bodybirthDate);
                bodypropCount++;
            }

            if (bodydeceasedBoolean != null)
            {
                body["deceasedBoolean"] = ExpressionConverter.ConvertO(bodydeceasedBoolean);
                bodypropCount++;
            }

            if (bodyaddress != null)
            {
                body["address"] = ExpressionConverter.ConvertO(bodyaddress);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<DELETEPatientIDResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<PUTPatientIDResponse> PUTPatientID(Expression<Func<string>> id, Expression<Func<string>> bodyresourceType = null, Expression<Func<string>> bodyid = null, Expression<Func<bool>> bodyactive = null, Expression<Func<bodynameInputItem[]>> bodyname = null, Expression<Func<bodytelecomInputItem[]>> bodytelecom = null, Expression<Func<string>> bodygender = null, Expression<Func<string>> bodybirthDate = null, Expression<Func<bool>> bodydeceasedBoolean = null, Expression<Func<bodyaddressInputItem[]>> bodyaddress = null)
        {
            var apiCallPath = String.Format("/Patient/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyresourceType != null)
            {
                body["resourceType"] = ExpressionConverter.ConvertO(bodyresourceType);
                bodypropCount++;
            }

            if (bodyid != null)
            {
                body["id"] = ExpressionConverter.ConvertO(bodyid);
                bodypropCount++;
            }

            if (bodyactive != null)
            {
                body["active"] = ExpressionConverter.ConvertO(bodyactive);
                bodypropCount++;
            }

            if (bodyname != null)
            {
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
            }

            if (bodytelecom != null)
            {
                body["telecom"] = ExpressionConverter.ConvertO(bodytelecom);
                bodypropCount++;
            }

            if (bodygender != null)
            {
                body["gender"] = ExpressionConverter.ConvertO(bodygender);
                bodypropCount++;
            }

            if (bodybirthDate != null)
            {
                body["birthDate"] = ExpressionConverter.ConvertO(bodybirthDate);
                bodypropCount++;
            }

            if (bodydeceasedBoolean != null)
            {
                body["deceasedBoolean"] = ExpressionConverter.ConvertO(bodydeceasedBoolean);
                bodypropCount++;
            }

            if (bodyaddress != null)
            {
                body["address"] = ExpressionConverter.ConvertO(bodyaddress);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<PUTPatientIDResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GETPatientIDVersionResponse> GETPatientIDVersion(Expression<Func<string>> id, Expression<Func<string>> vid)
        {
            var apiCallPath = String.Format("/Patient/{0}/_history/{1}", ExpressionConverter.ConvertWithUrlEncoding(id, 1), ExpressionConverter.ConvertWithUrlEncoding(vid, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GETPatientIDVersionResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GETPatientIDHistoryResponse> GETPatientIDHistory(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/Patient/{0}/_history", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GETPatientIDHistoryResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GETPatientHistoryResponse> GETPatientHistory()
        {
            var apiCallPath = "/Patient/_history";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GETPatientHistoryResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GETPersonResponse> GETPerson(Expression<Func<string>> Count = null, Expression<Func<string>> Sort = null, Expression<Func<string>> patient = null)
        {
            var apiCallPath = "/Person";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (Count != null)
                callPayload.Queries["_count"] = ExpressionConverter.Convert(Count);
            if (Sort != null)
                callPayload.Queries["_sort"] = ExpressionConverter.Convert(Sort);
            if (patient != null)
                callPayload.Queries["patient"] = ExpressionConverter.Convert(patient);
            return new ApiConnectionAction<GETPersonResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<POSTPersonResponse> POSTPerson(Expression<Func<string>> bodyresourceType = null, Expression<Func<string>> bodyid = null, Expression<Func<bodynameInputItem[]>> bodyname = null, Expression<Func<bodytelecomInputItem2[]>> bodytelecom = null, Expression<Func<string>> bodygender = null, Expression<Func<string>> bodybirthDate = null, Expression<Func<bodyaddressInputItem2[]>> bodyaddress = null, Expression<Func<string>> bodymanagingOrganizationreference = null, Expression<Func<string>> bodymanagingOrganizationdisplay = null, Expression<Func<bool>> bodyactive = null, Expression<Func<bodylinkInputItem[]>> bodylink = null)
        {
            var apiCallPath = "/Person";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyresourceType != null)
            {
                body["resourceType"] = ExpressionConverter.ConvertO(bodyresourceType);
                bodypropCount++;
            }

            if (bodyid != null)
            {
                body["id"] = ExpressionConverter.ConvertO(bodyid);
                bodypropCount++;
            }

            if (bodyname != null)
            {
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
            }

            if (bodytelecom != null)
            {
                body["telecom"] = ExpressionConverter.ConvertO(bodytelecom);
                bodypropCount++;
            }

            if (bodygender != null)
            {
                body["gender"] = ExpressionConverter.ConvertO(bodygender);
                bodypropCount++;
            }

            if (bodybirthDate != null)
            {
                body["birthDate"] = ExpressionConverter.ConvertO(bodybirthDate);
                bodypropCount++;
            }

            if (bodyaddress != null)
            {
                body["address"] = ExpressionConverter.ConvertO(bodyaddress);
                bodypropCount++;
            }

            var managingOrganizationObject = new JObject();
            var managingOrganizationObjectpropCount = 0;
            if (bodymanagingOrganizationreference != null)
            {
                managingOrganizationObject["reference"] = ExpressionConverter.ConvertO(bodymanagingOrganizationreference);
                managingOrganizationObjectpropCount++;
            }

            if (bodymanagingOrganizationdisplay != null)
            {
                managingOrganizationObject["display"] = ExpressionConverter.ConvertO(bodymanagingOrganizationdisplay);
                managingOrganizationObjectpropCount++;
            }

            if (managingOrganizationObjectpropCount > 0)
            {
                body["managingOrganization"] = managingOrganizationObject;
                bodypropCount++;
            }

            if (bodyactive != null)
            {
                body["active"] = ExpressionConverter.ConvertO(bodyactive);
                bodypropCount++;
            }

            if (bodylink != null)
            {
                body["link"] = ExpressionConverter.ConvertO(bodylink);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<POSTPersonResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GETPersonIDResponse> GETPersonID(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/Person/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GETPersonIDResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<DELETEPersonIDResponse> DELETEPersonID(Expression<Func<string>> id, Expression<Func<string>> bodyresourceType = null, Expression<Func<string>> bodyid = null, Expression<Func<bodynameInputItem[]>> bodyname = null, Expression<Func<bodytelecomInputItem2[]>> bodytelecom = null, Expression<Func<string>> bodygender = null, Expression<Func<string>> bodybirthDate = null, Expression<Func<bodyaddressInputItem2[]>> bodyaddress = null, Expression<Func<string>> bodymanagingOrganizationreference = null, Expression<Func<string>> bodymanagingOrganizationdisplay = null, Expression<Func<bool>> bodyactive = null, Expression<Func<bodylinkInputItem[]>> bodylink = null)
        {
            var apiCallPath = String.Format("/Person/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyresourceType != null)
            {
                body["resourceType"] = ExpressionConverter.ConvertO(bodyresourceType);
                bodypropCount++;
            }

            if (bodyid != null)
            {
                body["id"] = ExpressionConverter.ConvertO(bodyid);
                bodypropCount++;
            }

            if (bodyname != null)
            {
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
            }

            if (bodytelecom != null)
            {
                body["telecom"] = ExpressionConverter.ConvertO(bodytelecom);
                bodypropCount++;
            }

            if (bodygender != null)
            {
                body["gender"] = ExpressionConverter.ConvertO(bodygender);
                bodypropCount++;
            }

            if (bodybirthDate != null)
            {
                body["birthDate"] = ExpressionConverter.ConvertO(bodybirthDate);
                bodypropCount++;
            }

            if (bodyaddress != null)
            {
                body["address"] = ExpressionConverter.ConvertO(bodyaddress);
                bodypropCount++;
            }

            var managingOrganizationObject = new JObject();
            var managingOrganizationObjectpropCount = 0;
            if (bodymanagingOrganizationreference != null)
            {
                managingOrganizationObject["reference"] = ExpressionConverter.ConvertO(bodymanagingOrganizationreference);
                managingOrganizationObjectpropCount++;
            }

            if (bodymanagingOrganizationdisplay != null)
            {
                managingOrganizationObject["display"] = ExpressionConverter.ConvertO(bodymanagingOrganizationdisplay);
                managingOrganizationObjectpropCount++;
            }

            if (managingOrganizationObjectpropCount > 0)
            {
                body["managingOrganization"] = managingOrganizationObject;
                bodypropCount++;
            }

            if (bodyactive != null)
            {
                body["active"] = ExpressionConverter.ConvertO(bodyactive);
                bodypropCount++;
            }

            if (bodylink != null)
            {
                body["link"] = ExpressionConverter.ConvertO(bodylink);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<DELETEPersonIDResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<PUTPersonIDResponse> PUTPersonID(Expression<Func<string>> id, Expression<Func<string>> bodyresourceType = null, Expression<Func<string>> bodyid = null, Expression<Func<bodynameInputItem[]>> bodyname = null, Expression<Func<bodytelecomInputItem2[]>> bodytelecom = null, Expression<Func<string>> bodygender = null, Expression<Func<string>> bodybirthDate = null, Expression<Func<bodyaddressInputItem2[]>> bodyaddress = null, Expression<Func<string>> bodymanagingOrganizationreference = null, Expression<Func<string>> bodymanagingOrganizationdisplay = null, Expression<Func<bool>> bodyactive = null, Expression<Func<bodylinkInputItem[]>> bodylink = null)
        {
            var apiCallPath = String.Format("/Person/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyresourceType != null)
            {
                body["resourceType"] = ExpressionConverter.ConvertO(bodyresourceType);
                bodypropCount++;
            }

            if (bodyid != null)
            {
                body["id"] = ExpressionConverter.ConvertO(bodyid);
                bodypropCount++;
            }

            if (bodyname != null)
            {
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
            }

            if (bodytelecom != null)
            {
                body["telecom"] = ExpressionConverter.ConvertO(bodytelecom);
                bodypropCount++;
            }

            if (bodygender != null)
            {
                body["gender"] = ExpressionConverter.ConvertO(bodygender);
                bodypropCount++;
            }

            if (bodybirthDate != null)
            {
                body["birthDate"] = ExpressionConverter.ConvertO(bodybirthDate);
                bodypropCount++;
            }

            if (bodyaddress != null)
            {
                body["address"] = ExpressionConverter.ConvertO(bodyaddress);
                bodypropCount++;
            }

            var managingOrganizationObject = new JObject();
            var managingOrganizationObjectpropCount = 0;
            if (bodymanagingOrganizationreference != null)
            {
                managingOrganizationObject["reference"] = ExpressionConverter.ConvertO(bodymanagingOrganizationreference);
                managingOrganizationObjectpropCount++;
            }

            if (bodymanagingOrganizationdisplay != null)
            {
                managingOrganizationObject["display"] = ExpressionConverter.ConvertO(bodymanagingOrganizationdisplay);
                managingOrganizationObjectpropCount++;
            }

            if (managingOrganizationObjectpropCount > 0)
            {
                body["managingOrganization"] = managingOrganizationObject;
                bodypropCount++;
            }

            if (bodyactive != null)
            {
                body["active"] = ExpressionConverter.ConvertO(bodyactive);
                bodypropCount++;
            }

            if (bodylink != null)
            {
                body["link"] = ExpressionConverter.ConvertO(bodylink);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<PUTPersonIDResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GETPersonIDVersionResponse> GETPersonIDVersion(Expression<Func<string>> id, Expression<Func<string>> vid)
        {
            var apiCallPath = String.Format("/Person/{0}/_history/{1}", ExpressionConverter.ConvertWithUrlEncoding(id, 1), ExpressionConverter.ConvertWithUrlEncoding(vid, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GETPersonIDVersionResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GETPersonIDHistoryResponse> GETPersonIDHistory(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/Person/{0}/_history", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GETPersonIDHistoryResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GETPersonHistoryResponse> GETPersonHistory()
        {
            var apiCallPath = "/Person/_history";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GETPersonHistoryResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GETPractitionerResponse> GETPractitioner(Expression<Func<string>> Count = null, Expression<Func<string>> Sort = null, Expression<Func<string>> patient = null)
        {
            var apiCallPath = "/Practitioner";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (Count != null)
                callPayload.Queries["_count"] = ExpressionConverter.Convert(Count);
            if (Sort != null)
                callPayload.Queries["_sort"] = ExpressionConverter.Convert(Sort);
            if (patient != null)
                callPayload.Queries["patient"] = ExpressionConverter.Convert(patient);
            return new ApiConnectionAction<GETPractitionerResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<POSTPractitionerResponse> POSTPractitioner(Expression<Func<string>> bodyresourceType = null, Expression<Func<bodyidentifierInputItem[]>> bodyidentifier = null, Expression<Func<bool>> bodyactive = null, Expression<Func<bodynameInputItem2[]>> bodyname = null, Expression<Func<bodyaddressInputItem22[]>> bodyaddress = null, Expression<Func<bodyqualificationInputItem[]>> bodyqualification = null)
        {
            var apiCallPath = "/Practitioner";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyresourceType != null)
            {
                body["resourceType"] = ExpressionConverter.ConvertO(bodyresourceType);
                bodypropCount++;
            }

            if (bodyidentifier != null)
            {
                body["identifier"] = ExpressionConverter.ConvertO(bodyidentifier);
                bodypropCount++;
            }

            if (bodyactive != null)
            {
                body["active"] = ExpressionConverter.ConvertO(bodyactive);
                bodypropCount++;
            }

            if (bodyname != null)
            {
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
            }

            if (bodyaddress != null)
            {
                body["address"] = ExpressionConverter.ConvertO(bodyaddress);
                bodypropCount++;
            }

            if (bodyqualification != null)
            {
                body["qualification"] = ExpressionConverter.ConvertO(bodyqualification);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<POSTPractitionerResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GETPractitionerIDResponse> GETPractitionerID(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/Practitioner/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GETPractitionerIDResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<DELETEPractitionerIDResponse> DELETEPractitionerID(Expression<Func<string>> id, Expression<Func<string>> bodyresourceType = null, Expression<Func<string>> bodyid = null, Expression<Func<string>> bodymetaversionId = null, Expression<Func<string>> bodymetalastUpdated = null, Expression<Func<bodyidentifierInputItem[]>> bodyidentifier = null, Expression<Func<bool>> bodyactive = null, Expression<Func<bodynameInputItem2[]>> bodyname = null, Expression<Func<bodytelecomInputItem2[]>> bodytelecom = null, Expression<Func<bodyaddressInputItem222[]>> bodyaddress = null, Expression<Func<string>> bodygender = null)
        {
            var apiCallPath = String.Format("/Practitioner/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyresourceType != null)
            {
                body["resourceType"] = ExpressionConverter.ConvertO(bodyresourceType);
                bodypropCount++;
            }

            if (bodyid != null)
            {
                body["id"] = ExpressionConverter.ConvertO(bodyid);
                bodypropCount++;
            }

            var metaObject = new JObject();
            var metaObjectpropCount = 0;
            if (bodymetaversionId != null)
            {
                metaObject["versionId"] = ExpressionConverter.ConvertO(bodymetaversionId);
                metaObjectpropCount++;
            }

            if (bodymetalastUpdated != null)
            {
                metaObject["lastUpdated"] = ExpressionConverter.ConvertO(bodymetalastUpdated);
                metaObjectpropCount++;
            }

            if (metaObjectpropCount > 0)
            {
                body["meta"] = metaObject;
                bodypropCount++;
            }

            if (bodyidentifier != null)
            {
                body["identifier"] = ExpressionConverter.ConvertO(bodyidentifier);
                bodypropCount++;
            }

            if (bodyactive != null)
            {
                body["active"] = ExpressionConverter.ConvertO(bodyactive);
                bodypropCount++;
            }

            if (bodyname != null)
            {
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
            }

            if (bodytelecom != null)
            {
                body["telecom"] = ExpressionConverter.ConvertO(bodytelecom);
                bodypropCount++;
            }

            if (bodyaddress != null)
            {
                body["address"] = ExpressionConverter.ConvertO(bodyaddress);
                bodypropCount++;
            }

            if (bodygender != null)
            {
                body["gender"] = ExpressionConverter.ConvertO(bodygender);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<DELETEPractitionerIDResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<PUTPractitionerIDResponse> PUTPractitionerID(Expression<Func<string>> id, Expression<Func<string>> bodyresourceType = null, Expression<Func<string>> bodyid = null, Expression<Func<string>> bodymetaversionId = null, Expression<Func<string>> bodymetalastUpdated = null, Expression<Func<bodyidentifierInputItem[]>> bodyidentifier = null, Expression<Func<bool>> bodyactive = null, Expression<Func<bodynameInputItem2[]>> bodyname = null, Expression<Func<bodytelecomInputItem2[]>> bodytelecom = null, Expression<Func<bodyaddressInputItem222[]>> bodyaddress = null, Expression<Func<string>> bodygender = null)
        {
            var apiCallPath = String.Format("/Practitioner/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyresourceType != null)
            {
                body["resourceType"] = ExpressionConverter.ConvertO(bodyresourceType);
                bodypropCount++;
            }

            if (bodyid != null)
            {
                body["id"] = ExpressionConverter.ConvertO(bodyid);
                bodypropCount++;
            }

            var metaObject = new JObject();
            var metaObjectpropCount = 0;
            if (bodymetaversionId != null)
            {
                metaObject["versionId"] = ExpressionConverter.ConvertO(bodymetaversionId);
                metaObjectpropCount++;
            }

            if (bodymetalastUpdated != null)
            {
                metaObject["lastUpdated"] = ExpressionConverter.ConvertO(bodymetalastUpdated);
                metaObjectpropCount++;
            }

            if (metaObjectpropCount > 0)
            {
                body["meta"] = metaObject;
                bodypropCount++;
            }

            if (bodyidentifier != null)
            {
                body["identifier"] = ExpressionConverter.ConvertO(bodyidentifier);
                bodypropCount++;
            }

            if (bodyactive != null)
            {
                body["active"] = ExpressionConverter.ConvertO(bodyactive);
                bodypropCount++;
            }

            if (bodyname != null)
            {
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
            }

            if (bodytelecom != null)
            {
                body["telecom"] = ExpressionConverter.ConvertO(bodytelecom);
                bodypropCount++;
            }

            if (bodyaddress != null)
            {
                body["address"] = ExpressionConverter.ConvertO(bodyaddress);
                bodypropCount++;
            }

            if (bodygender != null)
            {
                body["gender"] = ExpressionConverter.ConvertO(bodygender);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<PUTPractitionerIDResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GETPractitionerIDVersionResponse> GETPractitionerIDVersion(Expression<Func<string>> id, Expression<Func<string>> vid)
        {
            var apiCallPath = String.Format("/Practitioner/{0}/_history/{1}", ExpressionConverter.ConvertWithUrlEncoding(id, 1), ExpressionConverter.ConvertWithUrlEncoding(vid, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GETPractitionerIDVersionResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GETPractitionerIDHistoryResponse> GETPractitionerIDHistory(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/Practitioner/{0}/_history", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GETPractitionerIDHistoryResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GETPractitionerHistoryResponse> GETPractitionerHistory()
        {
            var apiCallPath = "/Practitioner/_history";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GETPractitionerHistoryResponse>(callPayload);
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

    public class GETAppointmentIDResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GETAppointmentIDResponseMetaType Meta { get; set; }

        [JsonProperty("text")]
        public GETAppointmentIDResponseTextType Text { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("participant")]
        public GETAppointmentIDResponseParticipantTypeItem[] Participant { get; set; }
    }

    public class GETAppointmentIDResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GETAppointmentIDResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("div")]
        public string Div { get; set; }
    }

    public class GETAppointmentIDResponseParticipantTypeItem
    {
        [JsonProperty("actor")]
        public GETAppointmentIDResponseParticipantTypeItemActorType Actor { get; set; }

        [JsonProperty("required")]
        public string Required { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("type")]
        public GETAppointmentIDResponseParticipantTypeItemTypeTypeItem[] Type { get; set; }
    }

    public class GETAppointmentIDResponseParticipantTypeItemActorType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETAppointmentIDResponseParticipantTypeItemTypeTypeItem
    {
        [JsonProperty("coding")]
        public GETAppointmentIDResponseParticipantTypeItemTypeTypeItemCodingTypeItem[] Coding { get; set; }
    }

    public class GETAppointmentIDResponseParticipantTypeItemTypeTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class DELETEAppointmentIDResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public DELETEAppointmentIDResponseMetaType Meta { get; set; }

        [JsonProperty("text")]
        public DELETEAppointmentIDResponseTextType Text { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("participant")]
        public DELETEAppointmentIDResponseParticipantTypeItem[] Participant { get; set; }
    }

    public class DELETEAppointmentIDResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class DELETEAppointmentIDResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("div")]
        public string Div { get; set; }
    }

    public class DELETEAppointmentIDResponseParticipantTypeItem
    {
        [JsonProperty("actor")]
        public DELETEAppointmentIDResponseParticipantTypeItemActorType Actor { get; set; }

        [JsonProperty("required")]
        public string Required { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("type")]
        public DELETEAppointmentIDResponseParticipantTypeItemTypeTypeItem[] Type { get; set; }
    }

    public class DELETEAppointmentIDResponseParticipantTypeItemActorType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DELETEAppointmentIDResponseParticipantTypeItemTypeTypeItem
    {
        [JsonProperty("coding")]
        public DELETEAppointmentIDResponseParticipantTypeItemTypeTypeItemCodingTypeItem[] Coding { get; set; }
    }

    public class DELETEAppointmentIDResponseParticipantTypeItemTypeTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class PUTAppointmentIDResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public PUTAppointmentIDResponseMetaType Meta { get; set; }

        [JsonProperty("text")]
        public PUTAppointmentIDResponseTextType Text { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("participant")]
        public PUTAppointmentIDResponseParticipantTypeItem[] Participant { get; set; }
    }

    public class PUTAppointmentIDResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class PUTAppointmentIDResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("div")]
        public string Div { get; set; }
    }

    public class PUTAppointmentIDResponseParticipantTypeItem
    {
        [JsonProperty("actor")]
        public PUTAppointmentIDResponseParticipantTypeItemActorType Actor { get; set; }

        [JsonProperty("required")]
        public string Required { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("type")]
        public PUTAppointmentIDResponseParticipantTypeItemTypeTypeItem[] Type { get; set; }
    }

    public class PUTAppointmentIDResponseParticipantTypeItemActorType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PUTAppointmentIDResponseParticipantTypeItemTypeTypeItem
    {
        [JsonProperty("coding")]
        public PUTAppointmentIDResponseParticipantTypeItemTypeTypeItemCodingTypeItem[] Coding { get; set; }
    }

    public class PUTAppointmentIDResponseParticipantTypeItemTypeTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class GETAppointmentIDVERSIONResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GETAppointmentIDVERSIONResponseMetaType Meta { get; set; }

        [JsonProperty("text")]
        public GETAppointmentIDVERSIONResponseTextType Text { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("participant")]
        public GETAppointmentIDVERSIONResponseParticipantTypeItem[] Participant { get; set; }
    }

    public class GETAppointmentIDVERSIONResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GETAppointmentIDVERSIONResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("div")]
        public string Div { get; set; }
    }

    public class GETAppointmentIDVERSIONResponseParticipantTypeItem
    {
        [JsonProperty("actor")]
        public GETAppointmentIDVERSIONResponseParticipantTypeItemActorType Actor { get; set; }

        [JsonProperty("required")]
        public string Required { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("type")]
        public GETAppointmentIDVERSIONResponseParticipantTypeItemTypeTypeItem[] Type { get; set; }
    }

    public class GETAppointmentIDVERSIONResponseParticipantTypeItemActorType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETAppointmentIDVERSIONResponseParticipantTypeItemTypeTypeItem
    {
        [JsonProperty("coding")]
        public GETAppointmentIDVERSIONResponseParticipantTypeItemTypeTypeItemCodingTypeItem[] Coding { get; set; }
    }

    public class GETAppointmentIDVERSIONResponseParticipantTypeItemTypeTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class GETAppointmentIDHistoryResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GETAppointmentIDHistoryResponseMetaType Meta { get; set; }

        [JsonProperty("text")]
        public GETAppointmentIDHistoryResponseTextType Text { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("participant")]
        public GETAppointmentIDHistoryResponseParticipantTypeItem[] Participant { get; set; }
    }

    public class GETAppointmentIDHistoryResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GETAppointmentIDHistoryResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("div")]
        public string Div { get; set; }
    }

    public class GETAppointmentIDHistoryResponseParticipantTypeItem
    {
        [JsonProperty("actor")]
        public GETAppointmentIDHistoryResponseParticipantTypeItemActorType Actor { get; set; }

        [JsonProperty("required")]
        public string Required { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("type")]
        public GETAppointmentIDHistoryResponseParticipantTypeItemTypeTypeItem[] Type { get; set; }
    }

    public class GETAppointmentIDHistoryResponseParticipantTypeItemActorType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETAppointmentIDHistoryResponseParticipantTypeItemTypeTypeItem
    {
        [JsonProperty("coding")]
        public GETAppointmentIDHistoryResponseParticipantTypeItemTypeTypeItemCodingTypeItem[] Coding { get; set; }
    }

    public class GETAppointmentIDHistoryResponseParticipantTypeItemTypeTypeItemCodingTypeItem
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

    public class GETAppointmentResponseIDResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GETAppointmentResponseIDResponseMetaType Meta { get; set; }

        [JsonProperty("text")]
        public GETAppointmentResponseIDResponseTextType Text { get; set; }

        [JsonProperty("appointment")]
        public GETAppointmentResponseIDResponseAppointmentType Appointment { get; set; }

        [JsonProperty("actor")]
        public GETAppointmentResponseIDResponseActorType Actor { get; set; }

        [JsonProperty("participantStatus")]
        public string ParticipantStatus { get; set; }
    }

    public class GETAppointmentResponseIDResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GETAppointmentResponseIDResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("div")]
        public string Div { get; set; }
    }

    public class GETAppointmentResponseIDResponseAppointmentType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETAppointmentResponseIDResponseActorType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DELETEAppointmentResponseIDResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public DELETEAppointmentResponseIDResponseMetaType Meta { get; set; }

        [JsonProperty("text")]
        public DELETEAppointmentResponseIDResponseTextType Text { get; set; }

        [JsonProperty("appointment")]
        public DELETEAppointmentResponseIDResponseAppointmentType Appointment { get; set; }

        [JsonProperty("actor")]
        public DELETEAppointmentResponseIDResponseActorType Actor { get; set; }

        [JsonProperty("participantStatus")]
        public string ParticipantStatus { get; set; }
    }

    public class DELETEAppointmentResponseIDResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class DELETEAppointmentResponseIDResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("div")]
        public string Div { get; set; }
    }

    public class DELETEAppointmentResponseIDResponseAppointmentType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DELETEAppointmentResponseIDResponseActorType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PUTAppointmentResponseIDResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public PUTAppointmentResponseIDResponseMetaType Meta { get; set; }

        [JsonProperty("text")]
        public PUTAppointmentResponseIDResponseTextType Text { get; set; }

        [JsonProperty("appointment")]
        public PUTAppointmentResponseIDResponseAppointmentType Appointment { get; set; }

        [JsonProperty("actor")]
        public PUTAppointmentResponseIDResponseActorType Actor { get; set; }

        [JsonProperty("participantStatus")]
        public string ParticipantStatus { get; set; }
    }

    public class PUTAppointmentResponseIDResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class PUTAppointmentResponseIDResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("div")]
        public string Div { get; set; }
    }

    public class PUTAppointmentResponseIDResponseAppointmentType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PUTAppointmentResponseIDResponseActorType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETAppointmentResponseIDVersionResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GETAppointmentResponseIDVersionResponseMetaType Meta { get; set; }

        [JsonProperty("text")]
        public GETAppointmentResponseIDVersionResponseTextType Text { get; set; }

        [JsonProperty("appointment")]
        public GETAppointmentResponseIDVersionResponseAppointmentType Appointment { get; set; }

        [JsonProperty("actor")]
        public GETAppointmentResponseIDVersionResponseActorType Actor { get; set; }

        [JsonProperty("participantStatus")]
        public string ParticipantStatus { get; set; }
    }

    public class GETAppointmentResponseIDVersionResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GETAppointmentResponseIDVersionResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("div")]
        public string Div { get; set; }
    }

    public class GETAppointmentResponseIDVersionResponseAppointmentType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETAppointmentResponseIDVersionResponseActorType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETAppointmentResponseIDHistoryResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GETAppointmentResponseIDHistoryResponseMetaType Meta { get; set; }

        [JsonProperty("text")]
        public GETAppointmentResponseIDHistoryResponseTextType Text { get; set; }

        [JsonProperty("appointment")]
        public GETAppointmentResponseIDHistoryResponseAppointmentType Appointment { get; set; }

        [JsonProperty("actor")]
        public GETAppointmentResponseIDHistoryResponseActorType Actor { get; set; }

        [JsonProperty("participantStatus")]
        public string ParticipantStatus { get; set; }
    }

    public class GETAppointmentResponseIDHistoryResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GETAppointmentResponseIDHistoryResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("div")]
        public string Div { get; set; }
    }

    public class GETAppointmentResponseIDHistoryResponseAppointmentType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETAppointmentResponseIDHistoryResponseActorType
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

    public class GETDeviceIDResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GETDeviceIDResponseMetaType Meta { get; set; }

        [JsonProperty("udiCarrier")]
        public GETDeviceIDResponseUdiCarrierTypeItem[] UdiCarrier { get; set; }

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
        public GETDeviceIDResponseDeviceNameTypeItem[] DeviceName { get; set; }

        [JsonProperty("type")]
        public GETDeviceIDResponseTypeType Type { get; set; }

        [JsonProperty("patient")]
        public GETDeviceIDResponsePatientType Patient { get; set; }
    }

    public class GETDeviceIDResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GETDeviceIDResponseUdiCarrierTypeItem
    {
        [JsonProperty("deviceIdentifier")]
        public string DeviceIdentifier { get; set; }

        [JsonProperty("carrierHRF")]
        public string CarrierHRF { get; set; }
    }

    public class GETDeviceIDResponseDeviceNameTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class GETDeviceIDResponseTypeType
    {
        [JsonProperty("coding")]
        public GETDeviceIDResponseTypeTypeCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class GETDeviceIDResponseTypeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETDeviceIDResponsePatientType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class DELETEDeviceIDResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public DELETEDeviceIDResponseMetaType Meta { get; set; }

        [JsonProperty("text")]
        public DELETEDeviceIDResponseTextType Text { get; set; }

        [JsonProperty("identifier")]
        public DELETEDeviceIDResponseIdentifierTypeItem[] Identifier { get; set; }
    }

    public class DELETEDeviceIDResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class DELETEDeviceIDResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("div")]
        public string Div { get; set; }
    }

    public class DELETEDeviceIDResponseIdentifierTypeItem
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

    public class PUTDeviceIDResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public PUTDeviceIDResponseMetaType Meta { get; set; }

        [JsonProperty("text")]
        public PUTDeviceIDResponseTextType Text { get; set; }

        [JsonProperty("identifier")]
        public PUTDeviceIDResponseIdentifierTypeItem[] Identifier { get; set; }
    }

    public class PUTDeviceIDResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class PUTDeviceIDResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("div")]
        public string Div { get; set; }
    }

    public class PUTDeviceIDResponseIdentifierTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class GETDeviceIDVERSIONResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GETDeviceIDVERSIONResponseMetaType Meta { get; set; }

        [JsonProperty("text")]
        public GETDeviceIDVERSIONResponseTextType Text { get; set; }

        [JsonProperty("identifier")]
        public GETDeviceIDVERSIONResponseIdentifierTypeItem[] Identifier { get; set; }
    }

    public class GETDeviceIDVERSIONResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GETDeviceIDVERSIONResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("div")]
        public string Div { get; set; }
    }

    public class GETDeviceIDVERSIONResponseIdentifierTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class GETDeviceIDHISTORYResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GETDeviceIDHISTORYResponseMetaType Meta { get; set; }

        [JsonProperty("text")]
        public GETDeviceIDHISTORYResponseTextType Text { get; set; }

        [JsonProperty("identifier")]
        public GETDeviceIDHISTORYResponseIdentifierTypeItem[] Identifier { get; set; }
    }

    public class GETDeviceIDHISTORYResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GETDeviceIDHISTORYResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("div")]
        public string Div { get; set; }
    }

    public class GETDeviceIDHISTORYResponseIdentifierTypeItem
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

    public class GETEncounterIDResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GETEncounterIDResponseMetaType Meta { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("class")]
        public GETEncounterIDResponseClassType Class { get; set; }

        [JsonProperty("type")]
        public GETEncounterIDResponseTypeTypeItem[] Type { get; set; }

        [JsonProperty("subject")]
        public GETEncounterIDResponseSubjectType Subject { get; set; }

        [JsonProperty("participant")]
        public GETEncounterIDResponseParticipantTypeItem[] Participant { get; set; }

        [JsonProperty("period")]
        public GETEncounterIDResponsePeriodType Period { get; set; }

        [JsonProperty("serviceProvider")]
        public GETEncounterIDResponseServiceProviderType ServiceProvider { get; set; }
    }

    public class GETEncounterIDResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GETEncounterIDResponseClassType
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class GETEncounterIDResponseTypeTypeItem
    {
        [JsonProperty("coding")]
        public GETEncounterIDResponseTypeTypeItemCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class GETEncounterIDResponseTypeTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETEncounterIDResponseSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETEncounterIDResponseParticipantTypeItem
    {
        [JsonProperty("individual")]
        public GETEncounterIDResponseParticipantTypeItemIndividualType Individual { get; set; }
    }

    public class GETEncounterIDResponseParticipantTypeItemIndividualType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETEncounterIDResponsePeriodType
    {
        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }
    }

    public class GETEncounterIDResponseServiceProviderType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DELETEEncounterIDResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public DELETEEncounterIDResponseMetaType Meta { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("class")]
        public DELETEEncounterIDResponseClassType Class { get; set; }

        [JsonProperty("type")]
        public DELETEEncounterIDResponseTypeTypeItem[] Type { get; set; }

        [JsonProperty("subject")]
        public DELETEEncounterIDResponseSubjectType Subject { get; set; }

        [JsonProperty("participant")]
        public DELETEEncounterIDResponseParticipantTypeItem[] Participant { get; set; }

        [JsonProperty("period")]
        public DELETEEncounterIDResponsePeriodType Period { get; set; }

        [JsonProperty("serviceProvider")]
        public DELETEEncounterIDResponseServiceProviderType ServiceProvider { get; set; }
    }

    public class DELETEEncounterIDResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class DELETEEncounterIDResponseClassType
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class DELETEEncounterIDResponseTypeTypeItem
    {
        [JsonProperty("coding")]
        public DELETEEncounterIDResponseTypeTypeItemCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class DELETEEncounterIDResponseTypeTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DELETEEncounterIDResponseSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DELETEEncounterIDResponseParticipantTypeItem
    {
        [JsonProperty("individual")]
        public DELETEEncounterIDResponseParticipantTypeItemIndividualType Individual { get; set; }
    }

    public class DELETEEncounterIDResponseParticipantTypeItemIndividualType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DELETEEncounterIDResponsePeriodType
    {
        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }
    }

    public class DELETEEncounterIDResponseServiceProviderType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PUTEncounterIDResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public PUTEncounterIDResponseMetaType Meta { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("class")]
        public PUTEncounterIDResponseClassType Class { get; set; }

        [JsonProperty("type")]
        public PUTEncounterIDResponseTypeTypeItem[] Type { get; set; }

        [JsonProperty("subject")]
        public PUTEncounterIDResponseSubjectType Subject { get; set; }

        [JsonProperty("participant")]
        public PUTEncounterIDResponseParticipantTypeItem[] Participant { get; set; }

        [JsonProperty("period")]
        public PUTEncounterIDResponsePeriodType Period { get; set; }

        [JsonProperty("serviceProvider")]
        public PUTEncounterIDResponseServiceProviderType ServiceProvider { get; set; }
    }

    public class PUTEncounterIDResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class PUTEncounterIDResponseClassType
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class PUTEncounterIDResponseTypeTypeItem
    {
        [JsonProperty("coding")]
        public PUTEncounterIDResponseTypeTypeItemCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class PUTEncounterIDResponseTypeTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PUTEncounterIDResponseSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PUTEncounterIDResponseParticipantTypeItem
    {
        [JsonProperty("individual")]
        public PUTEncounterIDResponseParticipantTypeItemIndividualType Individual { get; set; }
    }

    public class PUTEncounterIDResponseParticipantTypeItemIndividualType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PUTEncounterIDResponsePeriodType
    {
        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }
    }

    public class PUTEncounterIDResponseServiceProviderType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETEncounterIDVersionResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GETEncounterIDVersionResponseMetaType Meta { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("class")]
        public GETEncounterIDVersionResponseClassType Class { get; set; }

        [JsonProperty("type")]
        public GETEncounterIDVersionResponseTypeTypeItem[] Type { get; set; }

        [JsonProperty("subject")]
        public GETEncounterIDVersionResponseSubjectType Subject { get; set; }

        [JsonProperty("participant")]
        public GETEncounterIDVersionResponseParticipantTypeItem[] Participant { get; set; }

        [JsonProperty("period")]
        public GETEncounterIDVersionResponsePeriodType Period { get; set; }

        [JsonProperty("serviceProvider")]
        public GETEncounterIDVersionResponseServiceProviderType ServiceProvider { get; set; }
    }

    public class GETEncounterIDVersionResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GETEncounterIDVersionResponseClassType
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class GETEncounterIDVersionResponseTypeTypeItem
    {
        [JsonProperty("coding")]
        public GETEncounterIDVersionResponseTypeTypeItemCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class GETEncounterIDVersionResponseTypeTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETEncounterIDVersionResponseSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETEncounterIDVersionResponseParticipantTypeItem
    {
        [JsonProperty("individual")]
        public GETEncounterIDVersionResponseParticipantTypeItemIndividualType Individual { get; set; }
    }

    public class GETEncounterIDVersionResponseParticipantTypeItemIndividualType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETEncounterIDVersionResponsePeriodType
    {
        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }
    }

    public class GETEncounterIDVersionResponseServiceProviderType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETEncounterIDHISTORYResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GETEncounterIDHISTORYResponseMetaType Meta { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("class")]
        public GETEncounterIDHISTORYResponseClassType Class { get; set; }

        [JsonProperty("type")]
        public GETEncounterIDHISTORYResponseTypeTypeItem[] Type { get; set; }

        [JsonProperty("subject")]
        public GETEncounterIDHISTORYResponseSubjectType Subject { get; set; }

        [JsonProperty("participant")]
        public GETEncounterIDHISTORYResponseParticipantTypeItem[] Participant { get; set; }

        [JsonProperty("period")]
        public GETEncounterIDHISTORYResponsePeriodType Period { get; set; }

        [JsonProperty("serviceProvider")]
        public GETEncounterIDHISTORYResponseServiceProviderType ServiceProvider { get; set; }
    }

    public class GETEncounterIDHISTORYResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GETEncounterIDHISTORYResponseClassType
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class GETEncounterIDHISTORYResponseTypeTypeItem
    {
        [JsonProperty("coding")]
        public GETEncounterIDHISTORYResponseTypeTypeItemCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class GETEncounterIDHISTORYResponseTypeTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETEncounterIDHISTORYResponseSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETEncounterIDHISTORYResponseParticipantTypeItem
    {
        [JsonProperty("individual")]
        public GETEncounterIDHISTORYResponseParticipantTypeItemIndividualType Individual { get; set; }
    }

    public class GETEncounterIDHISTORYResponseParticipantTypeItemIndividualType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETEncounterIDHISTORYResponsePeriodType
    {
        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }
    }

    public class GETEncounterIDHISTORYResponseServiceProviderType
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

    public class GETFlagIDResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("text")]
        public GETFlagIDResponseTextType Text { get; set; }

        [JsonProperty("identifier")]
        public GETFlagIDResponseIdentifierTypeItem[] Identifier { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("category")]
        public GETFlagIDResponseCategoryTypeItem[] Category { get; set; }

        [JsonProperty("code")]
        public GETFlagIDResponseCodeType Code { get; set; }

        [JsonProperty("subject")]
        public GETFlagIDResponseSubjectType Subject { get; set; }

        [JsonProperty("period")]
        public GETFlagIDResponsePeriodType Period { get; set; }

        [JsonProperty("author")]
        public GETFlagIDResponseAuthorType Author { get; set; }
    }

    public class GETFlagIDResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("div")]
        public string Div { get; set; }
    }

    public class GETFlagIDResponseIdentifierTypeItem
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class GETFlagIDResponseCategoryTypeItem
    {
        [JsonProperty("coding")]
        public GETFlagIDResponseCategoryTypeItemCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class GETFlagIDResponseCategoryTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETFlagIDResponseCodeType
    {
        [JsonProperty("coding")]
        public GETFlagIDResponseCodeTypeCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class GETFlagIDResponseCodeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETFlagIDResponseSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETFlagIDResponsePeriodType
    {
        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }
    }

    public class GETFlagIDResponseAuthorType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DELETEFlagIDResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("text")]
        public DELETEFlagIDResponseTextType Text { get; set; }

        [JsonProperty("identifier")]
        public DELETEFlagIDResponseIdentifierTypeItem[] Identifier { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("category")]
        public DELETEFlagIDResponseCategoryTypeItem[] Category { get; set; }

        [JsonProperty("code")]
        public DELETEFlagIDResponseCodeType Code { get; set; }

        [JsonProperty("subject")]
        public DELETEFlagIDResponseSubjectType Subject { get; set; }

        [JsonProperty("period")]
        public DELETEFlagIDResponsePeriodType Period { get; set; }

        [JsonProperty("author")]
        public DELETEFlagIDResponseAuthorType Author { get; set; }
    }

    public class DELETEFlagIDResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("div")]
        public string Div { get; set; }
    }

    public class DELETEFlagIDResponseIdentifierTypeItem
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class DELETEFlagIDResponseCategoryTypeItem
    {
        [JsonProperty("coding")]
        public DELETEFlagIDResponseCategoryTypeItemCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class DELETEFlagIDResponseCategoryTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DELETEFlagIDResponseCodeType
    {
        [JsonProperty("coding")]
        public DELETEFlagIDResponseCodeTypeCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class DELETEFlagIDResponseCodeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DELETEFlagIDResponseSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DELETEFlagIDResponsePeriodType
    {
        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }
    }

    public class DELETEFlagIDResponseAuthorType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PUTFlagIDResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("text")]
        public PUTFlagIDResponseTextType Text { get; set; }

        [JsonProperty("identifier")]
        public PUTFlagIDResponseIdentifierTypeItem[] Identifier { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("category")]
        public PUTFlagIDResponseCategoryTypeItem[] Category { get; set; }

        [JsonProperty("code")]
        public PUTFlagIDResponseCodeType Code { get; set; }

        [JsonProperty("subject")]
        public PUTFlagIDResponseSubjectType Subject { get; set; }

        [JsonProperty("period")]
        public PUTFlagIDResponsePeriodType Period { get; set; }

        [JsonProperty("author")]
        public PUTFlagIDResponseAuthorType Author { get; set; }
    }

    public class PUTFlagIDResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("div")]
        public string Div { get; set; }
    }

    public class PUTFlagIDResponseIdentifierTypeItem
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class PUTFlagIDResponseCategoryTypeItem
    {
        [JsonProperty("coding")]
        public PUTFlagIDResponseCategoryTypeItemCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class PUTFlagIDResponseCategoryTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PUTFlagIDResponseCodeType
    {
        [JsonProperty("coding")]
        public PUTFlagIDResponseCodeTypeCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class PUTFlagIDResponseCodeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PUTFlagIDResponseSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PUTFlagIDResponsePeriodType
    {
        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }
    }

    public class PUTFlagIDResponseAuthorType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETFlagIDVersionResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("text")]
        public GETFlagIDVersionResponseTextType Text { get; set; }

        [JsonProperty("identifier")]
        public GETFlagIDVersionResponseIdentifierTypeItem[] Identifier { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("category")]
        public GETFlagIDVersionResponseCategoryTypeItem[] Category { get; set; }

        [JsonProperty("code")]
        public GETFlagIDVersionResponseCodeType Code { get; set; }

        [JsonProperty("subject")]
        public GETFlagIDVersionResponseSubjectType Subject { get; set; }

        [JsonProperty("period")]
        public GETFlagIDVersionResponsePeriodType Period { get; set; }

        [JsonProperty("author")]
        public GETFlagIDVersionResponseAuthorType Author { get; set; }
    }

    public class GETFlagIDVersionResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("div")]
        public string Div { get; set; }
    }

    public class GETFlagIDVersionResponseIdentifierTypeItem
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class GETFlagIDVersionResponseCategoryTypeItem
    {
        [JsonProperty("coding")]
        public GETFlagIDVersionResponseCategoryTypeItemCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class GETFlagIDVersionResponseCategoryTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETFlagIDVersionResponseCodeType
    {
        [JsonProperty("coding")]
        public GETFlagIDVersionResponseCodeTypeCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class GETFlagIDVersionResponseCodeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETFlagIDVersionResponseSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETFlagIDVersionResponsePeriodType
    {
        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }
    }

    public class GETFlagIDVersionResponseAuthorType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETFlagIDHistoryResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("text")]
        public GETFlagIDHistoryResponseTextType Text { get; set; }

        [JsonProperty("identifier")]
        public GETFlagIDHistoryResponseIdentifierTypeItem[] Identifier { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("category")]
        public GETFlagIDHistoryResponseCategoryTypeItem[] Category { get; set; }

        [JsonProperty("code")]
        public GETFlagIDHistoryResponseCodeType Code { get; set; }

        [JsonProperty("subject")]
        public GETFlagIDHistoryResponseSubjectType Subject { get; set; }

        [JsonProperty("period")]
        public GETFlagIDHistoryResponsePeriodType Period { get; set; }

        [JsonProperty("author")]
        public GETFlagIDHistoryResponseAuthorType Author { get; set; }
    }

    public class GETFlagIDHistoryResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("div")]
        public string Div { get; set; }
    }

    public class GETFlagIDHistoryResponseIdentifierTypeItem
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class GETFlagIDHistoryResponseCategoryTypeItem
    {
        [JsonProperty("coding")]
        public GETFlagIDHistoryResponseCategoryTypeItemCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class GETFlagIDHistoryResponseCategoryTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETFlagIDHistoryResponseCodeType
    {
        [JsonProperty("coding")]
        public GETFlagIDHistoryResponseCodeTypeCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class GETFlagIDHistoryResponseCodeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETFlagIDHistoryResponseSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETFlagIDHistoryResponsePeriodType
    {
        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }
    }

    public class GETFlagIDHistoryResponseAuthorType
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

    public class GETLocationIDResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("text")]
        public GETLocationIDResponseTextType Text { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("mode")]
        public string Mode { get; set; }

        [JsonProperty("partOf")]
        public GETLocationIDResponsePartOfType PartOf { get; set; }
    }

    public class GETLocationIDResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("div")]
        public string Div { get; set; }
    }

    public class GETLocationIDResponsePartOfType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DELETELocationIDResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("text")]
        public DELETELocationIDResponseTextType Text { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("mode")]
        public string Mode { get; set; }

        [JsonProperty("partOf")]
        public DELETELocationIDResponsePartOfType PartOf { get; set; }
    }

    public class DELETELocationIDResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("div")]
        public string Div { get; set; }
    }

    public class DELETELocationIDResponsePartOfType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PUTLocationIDResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("text")]
        public PUTLocationIDResponseTextType Text { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("mode")]
        public string Mode { get; set; }

        [JsonProperty("partOf")]
        public PUTLocationIDResponsePartOfType PartOf { get; set; }
    }

    public class PUTLocationIDResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("div")]
        public string Div { get; set; }
    }

    public class PUTLocationIDResponsePartOfType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETLocationIDVersionResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("text")]
        public GETLocationIDVersionResponseTextType Text { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("mode")]
        public string Mode { get; set; }

        [JsonProperty("partOf")]
        public GETLocationIDVersionResponsePartOfType PartOf { get; set; }
    }

    public class GETLocationIDVersionResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("div")]
        public string Div { get; set; }
    }

    public class GETLocationIDVersionResponsePartOfType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETLocationIDHistoryResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("text")]
        public GETLocationIDHistoryResponseTextType Text { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("mode")]
        public string Mode { get; set; }

        [JsonProperty("partOf")]
        public GETLocationIDHistoryResponsePartOfType PartOf { get; set; }
    }

    public class GETLocationIDHistoryResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("div")]
        public string Div { get; set; }
    }

    public class GETLocationIDHistoryResponsePartOfType
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

    public class GETPatientIDResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GETPatientIDResponseMetaType Meta { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("link")]
        public GETPatientIDResponseLinkTypeItem[] Link { get; set; }

        [JsonProperty("entry")]
        public GETPatientIDResponseEntryTypeItem[] Entry { get; set; }
    }

    public class GETPatientIDResponseMetaType
    {
        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GETPatientIDResponseLinkTypeItem
    {
        [JsonProperty("relation")]
        public string Relation { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class GETPatientIDResponseEntryTypeItem
    {
        [JsonProperty("fullUrl")]
        public string FullUrl { get; set; }

        [JsonProperty("resource")]
        public GETPatientIDResponseEntryTypeItemResourceType Resource { get; set; }

        [JsonProperty("search")]
        public GETPatientIDResponseEntryTypeItemSearchType Search { get; set; }
    }

    public class GETPatientIDResponseEntryTypeItemResourceType
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GETPatientIDResponseEntryTypeItemResourceTypeMetaType Meta { get; set; }

        [JsonProperty("text")]
        public GETPatientIDResponseEntryTypeItemResourceTypeTextType Text { get; set; }

        [JsonProperty("extension")]
        public GETPatientIDResponseEntryTypeItemResourceTypeExtensionTypeItem[] Extension { get; set; }

        [JsonProperty("identifier")]
        public GETPatientIDResponseEntryTypeItemResourceTypeIdentifierTypeItem[] Identifier { get; set; }

        [JsonProperty("name")]
        public GETPatientIDResponseEntryTypeItemResourceTypeNameTypeItem[] Name { get; set; }

        [JsonProperty("telecom")]
        public GETPatientIDResponseEntryTypeItemResourceTypeTelecomTypeItem[] Telecom { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("birthDate")]
        public string BirthDate { get; set; }

        [JsonProperty("address")]
        public GETPatientIDResponseEntryTypeItemResourceTypeAddressTypeItem[] Address { get; set; }
    }

    public class GETPatientIDResponseEntryTypeItemResourceTypeMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GETPatientIDResponseEntryTypeItemResourceTypeTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("div")]
        public string Div { get; set; }
    }

    public class GETPatientIDResponseEntryTypeItemResourceTypeExtensionTypeItem
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("valueCodeableConcept")]
        public GETPatientIDResponseEntryTypeItemResourceTypeExtensionTypeItemValueCodeableConceptType ValueCodeableConcept { get; set; }

        [JsonProperty("valueCode")]
        public string ValueCode { get; set; }
    }

    public class GETPatientIDResponseEntryTypeItemResourceTypeExtensionTypeItemValueCodeableConceptType
    {
        [JsonProperty("coding")]
        public GETPatientIDResponseEntryTypeItemResourceTypeExtensionTypeItemValueCodeableConceptTypeCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class GETPatientIDResponseEntryTypeItemResourceTypeExtensionTypeItemValueCodeableConceptTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETPatientIDResponseEntryTypeItemResourceTypeIdentifierTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class GETPatientIDResponseEntryTypeItemResourceTypeNameTypeItem
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

    public class GETPatientIDResponseEntryTypeItemResourceTypeTelecomTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("use")]
        public string Use { get; set; }
    }

    public class GETPatientIDResponseEntryTypeItemResourceTypeAddressTypeItem
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

    public class GETPatientIDResponseEntryTypeItemSearchType
    {
        [JsonProperty("mode")]
        public string Mode { get; set; }
    }

    public class DELETEPatientIDResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("name")]
        public DELETEPatientIDResponseNameTypeItem[] Name { get; set; }

        [JsonProperty("telecom")]
        public DELETEPatientIDResponseTelecomTypeItem[] Telecom { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("birthDate")]
        public string BirthDate { get; set; }

        [JsonProperty("deceasedBoolean")]
        public bool DeceasedBoolean { get; set; }

        [JsonProperty("address")]
        public DELETEPatientIDResponseAddressTypeItem[] Address { get; set; }
    }

    public class DELETEPatientIDResponseNameTypeItem
    {
        [JsonProperty("use")]
        public string Use { get; set; }

        [JsonProperty("family")]
        public string Family { get; set; }

        [JsonProperty("given")]
        public string[] Given { get; set; }
    }

    public class DELETEPatientIDResponseTelecomTypeItem
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

    public class DELETEPatientIDResponseAddressTypeItem
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
        public DELETEPatientIDResponseAddressTypeItemPeriodType Period { get; set; }
    }

    public class DELETEPatientIDResponseAddressTypeItemPeriodType
    {
        [JsonProperty("start")]
        public string Start { get; set; }
    }

    public class PUTPatientIDResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("name")]
        public PUTPatientIDResponseNameTypeItem[] Name { get; set; }

        [JsonProperty("telecom")]
        public PUTPatientIDResponseTelecomTypeItem[] Telecom { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("birthDate")]
        public string BirthDate { get; set; }

        [JsonProperty("deceasedBoolean")]
        public bool DeceasedBoolean { get; set; }

        [JsonProperty("address")]
        public PUTPatientIDResponseAddressTypeItem[] Address { get; set; }
    }

    public class PUTPatientIDResponseNameTypeItem
    {
        [JsonProperty("use")]
        public string Use { get; set; }

        [JsonProperty("family")]
        public string Family { get; set; }

        [JsonProperty("given")]
        public string[] Given { get; set; }
    }

    public class PUTPatientIDResponseTelecomTypeItem
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

    public class PUTPatientIDResponseAddressTypeItem
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
        public PUTPatientIDResponseAddressTypeItemPeriodType Period { get; set; }
    }

    public class PUTPatientIDResponseAddressTypeItemPeriodType
    {
        [JsonProperty("start")]
        public string Start { get; set; }
    }

    public class GETPatientIDVersionResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GETPatientIDVersionResponseMetaType Meta { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("link")]
        public GETPatientIDVersionResponseLinkTypeItem[] Link { get; set; }

        [JsonProperty("entry")]
        public GETPatientIDVersionResponseEntryTypeItem[] Entry { get; set; }
    }

    public class GETPatientIDVersionResponseMetaType
    {
        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GETPatientIDVersionResponseLinkTypeItem
    {
        [JsonProperty("relation")]
        public string Relation { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class GETPatientIDVersionResponseEntryTypeItem
    {
        [JsonProperty("fullUrl")]
        public string FullUrl { get; set; }

        [JsonProperty("resource")]
        public GETPatientIDVersionResponseEntryTypeItemResourceType Resource { get; set; }

        [JsonProperty("search")]
        public GETPatientIDVersionResponseEntryTypeItemSearchType Search { get; set; }
    }

    public class GETPatientIDVersionResponseEntryTypeItemResourceType
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GETPatientIDVersionResponseEntryTypeItemResourceTypeMetaType Meta { get; set; }

        [JsonProperty("text")]
        public GETPatientIDVersionResponseEntryTypeItemResourceTypeTextType Text { get; set; }

        [JsonProperty("extension")]
        public GETPatientIDVersionResponseEntryTypeItemResourceTypeExtensionTypeItem[] Extension { get; set; }

        [JsonProperty("identifier")]
        public GETPatientIDVersionResponseEntryTypeItemResourceTypeIdentifierTypeItem[] Identifier { get; set; }

        [JsonProperty("name")]
        public GETPatientIDVersionResponseEntryTypeItemResourceTypeNameTypeItem[] Name { get; set; }

        [JsonProperty("telecom")]
        public GETPatientIDVersionResponseEntryTypeItemResourceTypeTelecomTypeItem[] Telecom { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("birthDate")]
        public string BirthDate { get; set; }

        [JsonProperty("address")]
        public GETPatientIDVersionResponseEntryTypeItemResourceTypeAddressTypeItem[] Address { get; set; }
    }

    public class GETPatientIDVersionResponseEntryTypeItemResourceTypeMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GETPatientIDVersionResponseEntryTypeItemResourceTypeTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("div")]
        public string Div { get; set; }
    }

    public class GETPatientIDVersionResponseEntryTypeItemResourceTypeExtensionTypeItem
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("valueCodeableConcept")]
        public GETPatientIDVersionResponseEntryTypeItemResourceTypeExtensionTypeItemValueCodeableConceptType ValueCodeableConcept { get; set; }

        [JsonProperty("valueCode")]
        public string ValueCode { get; set; }
    }

    public class GETPatientIDVersionResponseEntryTypeItemResourceTypeExtensionTypeItemValueCodeableConceptType
    {
        [JsonProperty("coding")]
        public GETPatientIDVersionResponseEntryTypeItemResourceTypeExtensionTypeItemValueCodeableConceptTypeCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class GETPatientIDVersionResponseEntryTypeItemResourceTypeExtensionTypeItemValueCodeableConceptTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETPatientIDVersionResponseEntryTypeItemResourceTypeIdentifierTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class GETPatientIDVersionResponseEntryTypeItemResourceTypeNameTypeItem
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

    public class GETPatientIDVersionResponseEntryTypeItemResourceTypeTelecomTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("use")]
        public string Use { get; set; }
    }

    public class GETPatientIDVersionResponseEntryTypeItemResourceTypeAddressTypeItem
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

    public class GETPatientIDVersionResponseEntryTypeItemSearchType
    {
        [JsonProperty("mode")]
        public string Mode { get; set; }
    }

    public class GETPatientIDHistoryResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GETPatientIDHistoryResponseMetaType Meta { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("link")]
        public GETPatientIDHistoryResponseLinkTypeItem[] Link { get; set; }

        [JsonProperty("entry")]
        public GETPatientIDHistoryResponseEntryTypeItem[] Entry { get; set; }
    }

    public class GETPatientIDHistoryResponseMetaType
    {
        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GETPatientIDHistoryResponseLinkTypeItem
    {
        [JsonProperty("relation")]
        public string Relation { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class GETPatientIDHistoryResponseEntryTypeItem
    {
        [JsonProperty("fullUrl")]
        public string FullUrl { get; set; }

        [JsonProperty("resource")]
        public GETPatientIDHistoryResponseEntryTypeItemResourceType Resource { get; set; }

        [JsonProperty("search")]
        public GETPatientIDHistoryResponseEntryTypeItemSearchType Search { get; set; }
    }

    public class GETPatientIDHistoryResponseEntryTypeItemResourceType
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GETPatientIDHistoryResponseEntryTypeItemResourceTypeMetaType Meta { get; set; }

        [JsonProperty("text")]
        public GETPatientIDHistoryResponseEntryTypeItemResourceTypeTextType Text { get; set; }

        [JsonProperty("extension")]
        public GETPatientIDHistoryResponseEntryTypeItemResourceTypeExtensionTypeItem[] Extension { get; set; }

        [JsonProperty("identifier")]
        public GETPatientIDHistoryResponseEntryTypeItemResourceTypeIdentifierTypeItem[] Identifier { get; set; }

        [JsonProperty("name")]
        public GETPatientIDHistoryResponseEntryTypeItemResourceTypeNameTypeItem[] Name { get; set; }

        [JsonProperty("telecom")]
        public GETPatientIDHistoryResponseEntryTypeItemResourceTypeTelecomTypeItem[] Telecom { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("birthDate")]
        public string BirthDate { get; set; }

        [JsonProperty("address")]
        public GETPatientIDHistoryResponseEntryTypeItemResourceTypeAddressTypeItem[] Address { get; set; }
    }

    public class GETPatientIDHistoryResponseEntryTypeItemResourceTypeMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GETPatientIDHistoryResponseEntryTypeItemResourceTypeTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("div")]
        public string Div { get; set; }
    }

    public class GETPatientIDHistoryResponseEntryTypeItemResourceTypeExtensionTypeItem
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("valueCodeableConcept")]
        public GETPatientIDHistoryResponseEntryTypeItemResourceTypeExtensionTypeItemValueCodeableConceptType ValueCodeableConcept { get; set; }

        [JsonProperty("valueCode")]
        public string ValueCode { get; set; }
    }

    public class GETPatientIDHistoryResponseEntryTypeItemResourceTypeExtensionTypeItemValueCodeableConceptType
    {
        [JsonProperty("coding")]
        public GETPatientIDHistoryResponseEntryTypeItemResourceTypeExtensionTypeItemValueCodeableConceptTypeCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class GETPatientIDHistoryResponseEntryTypeItemResourceTypeExtensionTypeItemValueCodeableConceptTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETPatientIDHistoryResponseEntryTypeItemResourceTypeIdentifierTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class GETPatientIDHistoryResponseEntryTypeItemResourceTypeNameTypeItem
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

    public class GETPatientIDHistoryResponseEntryTypeItemResourceTypeTelecomTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("use")]
        public string Use { get; set; }
    }

    public class GETPatientIDHistoryResponseEntryTypeItemResourceTypeAddressTypeItem
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

    public class GETPatientIDHistoryResponseEntryTypeItemSearchType
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

    public class GETPersonIDResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public GETPersonIDResponseNameTypeItem[] Name { get; set; }

        [JsonProperty("telecom")]
        public GETPersonIDResponseTelecomTypeItem[] Telecom { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("birthDate")]
        public string BirthDate { get; set; }

        [JsonProperty("address")]
        public GETPersonIDResponseAddressTypeItem[] Address { get; set; }

        [JsonProperty("managingOrganization")]
        public GETPersonIDResponseManagingOrganizationType ManagingOrganization { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("link")]
        public GETPersonIDResponseLinkTypeItem[] Link { get; set; }
    }

    public class GETPersonIDResponseNameTypeItem
    {
        [JsonProperty("use")]
        public string Use { get; set; }

        [JsonProperty("family")]
        public string Family { get; set; }

        [JsonProperty("given")]
        public string[] Given { get; set; }
    }

    public class GETPersonIDResponseTelecomTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("use")]
        public string Use { get; set; }
    }

    public class GETPersonIDResponseAddressTypeItem
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

    public class GETPersonIDResponseManagingOrganizationType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETPersonIDResponseLinkTypeItem
    {
        [JsonProperty("target")]
        public GETPersonIDResponseLinkTypeItemTargetType Target { get; set; }

        [JsonProperty("assurance")]
        public string Assurance { get; set; }
    }

    public class GETPersonIDResponseLinkTypeItemTargetType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DELETEPersonIDResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public DELETEPersonIDResponseNameTypeItem[] Name { get; set; }

        [JsonProperty("telecom")]
        public DELETEPersonIDResponseTelecomTypeItem[] Telecom { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("birthDate")]
        public string BirthDate { get; set; }

        [JsonProperty("address")]
        public DELETEPersonIDResponseAddressTypeItem[] Address { get; set; }

        [JsonProperty("managingOrganization")]
        public DELETEPersonIDResponseManagingOrganizationType ManagingOrganization { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("link")]
        public DELETEPersonIDResponseLinkTypeItem[] Link { get; set; }
    }

    public class DELETEPersonIDResponseNameTypeItem
    {
        [JsonProperty("use")]
        public string Use { get; set; }

        [JsonProperty("family")]
        public string Family { get; set; }

        [JsonProperty("given")]
        public string[] Given { get; set; }
    }

    public class DELETEPersonIDResponseTelecomTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("use")]
        public string Use { get; set; }
    }

    public class DELETEPersonIDResponseAddressTypeItem
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

    public class DELETEPersonIDResponseManagingOrganizationType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DELETEPersonIDResponseLinkTypeItem
    {
        [JsonProperty("target")]
        public DELETEPersonIDResponseLinkTypeItemTargetType Target { get; set; }

        [JsonProperty("assurance")]
        public string Assurance { get; set; }
    }

    public class DELETEPersonIDResponseLinkTypeItemTargetType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PUTPersonIDResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public PUTPersonIDResponseNameTypeItem[] Name { get; set; }

        [JsonProperty("telecom")]
        public PUTPersonIDResponseTelecomTypeItem[] Telecom { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("birthDate")]
        public string BirthDate { get; set; }

        [JsonProperty("address")]
        public PUTPersonIDResponseAddressTypeItem[] Address { get; set; }

        [JsonProperty("managingOrganization")]
        public PUTPersonIDResponseManagingOrganizationType ManagingOrganization { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("link")]
        public PUTPersonIDResponseLinkTypeItem[] Link { get; set; }
    }

    public class PUTPersonIDResponseNameTypeItem
    {
        [JsonProperty("use")]
        public string Use { get; set; }

        [JsonProperty("family")]
        public string Family { get; set; }

        [JsonProperty("given")]
        public string[] Given { get; set; }
    }

    public class PUTPersonIDResponseTelecomTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("use")]
        public string Use { get; set; }
    }

    public class PUTPersonIDResponseAddressTypeItem
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

    public class PUTPersonIDResponseManagingOrganizationType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PUTPersonIDResponseLinkTypeItem
    {
        [JsonProperty("target")]
        public PUTPersonIDResponseLinkTypeItemTargetType Target { get; set; }

        [JsonProperty("assurance")]
        public string Assurance { get; set; }
    }

    public class PUTPersonIDResponseLinkTypeItemTargetType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETPersonIDVersionResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public GETPersonIDVersionResponseNameTypeItem[] Name { get; set; }

        [JsonProperty("telecom")]
        public GETPersonIDVersionResponseTelecomTypeItem[] Telecom { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("birthDate")]
        public string BirthDate { get; set; }

        [JsonProperty("address")]
        public GETPersonIDVersionResponseAddressTypeItem[] Address { get; set; }

        [JsonProperty("managingOrganization")]
        public GETPersonIDVersionResponseManagingOrganizationType ManagingOrganization { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("link")]
        public GETPersonIDVersionResponseLinkTypeItem[] Link { get; set; }
    }

    public class GETPersonIDVersionResponseNameTypeItem
    {
        [JsonProperty("use")]
        public string Use { get; set; }

        [JsonProperty("family")]
        public string Family { get; set; }

        [JsonProperty("given")]
        public string[] Given { get; set; }
    }

    public class GETPersonIDVersionResponseTelecomTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("use")]
        public string Use { get; set; }
    }

    public class GETPersonIDVersionResponseAddressTypeItem
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

    public class GETPersonIDVersionResponseManagingOrganizationType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETPersonIDVersionResponseLinkTypeItem
    {
        [JsonProperty("target")]
        public GETPersonIDVersionResponseLinkTypeItemTargetType Target { get; set; }

        [JsonProperty("assurance")]
        public string Assurance { get; set; }
    }

    public class GETPersonIDVersionResponseLinkTypeItemTargetType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETPersonIDHistoryResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public GETPersonIDHistoryResponseNameTypeItem[] Name { get; set; }

        [JsonProperty("telecom")]
        public GETPersonIDHistoryResponseTelecomTypeItem[] Telecom { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("birthDate")]
        public string BirthDate { get; set; }

        [JsonProperty("address")]
        public GETPersonIDHistoryResponseAddressTypeItem[] Address { get; set; }

        [JsonProperty("managingOrganization")]
        public GETPersonIDHistoryResponseManagingOrganizationType ManagingOrganization { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("link")]
        public GETPersonIDHistoryResponseLinkTypeItem[] Link { get; set; }
    }

    public class GETPersonIDHistoryResponseNameTypeItem
    {
        [JsonProperty("use")]
        public string Use { get; set; }

        [JsonProperty("family")]
        public string Family { get; set; }

        [JsonProperty("given")]
        public string[] Given { get; set; }
    }

    public class GETPersonIDHistoryResponseTelecomTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("use")]
        public string Use { get; set; }
    }

    public class GETPersonIDHistoryResponseAddressTypeItem
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

    public class GETPersonIDHistoryResponseManagingOrganizationType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETPersonIDHistoryResponseLinkTypeItem
    {
        [JsonProperty("target")]
        public GETPersonIDHistoryResponseLinkTypeItemTargetType Target { get; set; }

        [JsonProperty("assurance")]
        public string Assurance { get; set; }
    }

    public class GETPersonIDHistoryResponseLinkTypeItemTargetType
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

    public class GETPractitionerIDResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GETPractitionerIDResponseMetaType Meta { get; set; }

        [JsonProperty("identifier")]
        public GETPractitionerIDResponseIdentifierTypeItem[] Identifier { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("name")]
        public GETPractitionerIDResponseNameTypeItem[] Name { get; set; }

        [JsonProperty("telecom")]
        public GETPractitionerIDResponseTelecomTypeItem[] Telecom { get; set; }

        [JsonProperty("address")]
        public GETPractitionerIDResponseAddressTypeItem[] Address { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }
    }

    public class GETPractitionerIDResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GETPractitionerIDResponseIdentifierTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class GETPractitionerIDResponseNameTypeItem
    {
        [JsonProperty("family")]
        public string Family { get; set; }

        [JsonProperty("given")]
        public string[] Given { get; set; }

        [JsonProperty("prefix")]
        public string[] Prefix { get; set; }
    }

    public class GETPractitionerIDResponseTelecomTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("use")]
        public string Use { get; set; }
    }

    public class GETPractitionerIDResponseAddressTypeItem
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

    public class DELETEPractitionerIDResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("text")]
        public DELETEPractitionerIDResponseTextType Text { get; set; }

        [JsonProperty("identifier")]
        public DELETEPractitionerIDResponseIdentifierTypeItem[] Identifier { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("name")]
        public DELETEPractitionerIDResponseNameTypeItem[] Name { get; set; }

        [JsonProperty("address")]
        public DELETEPractitionerIDResponseAddressTypeItem[] Address { get; set; }

        [JsonProperty("qualification")]
        public DELETEPractitionerIDResponseQualificationTypeItem[] Qualification { get; set; }
    }

    public class DELETEPractitionerIDResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("div")]
        public string Div { get; set; }
    }

    public class DELETEPractitionerIDResponseIdentifierTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class DELETEPractitionerIDResponseNameTypeItem
    {
        [JsonProperty("family")]
        public string Family { get; set; }

        [JsonProperty("given")]
        public string[] Given { get; set; }

        [JsonProperty("prefix")]
        public string[] Prefix { get; set; }
    }

    public class DELETEPractitionerIDResponseAddressTypeItem
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

    public class DELETEPractitionerIDResponseQualificationTypeItem
    {
        [JsonProperty("identifier")]
        public DELETEPractitionerIDResponseQualificationTypeItemIdentifierTypeItem[] Identifier { get; set; }

        [JsonProperty("code")]
        public DELETEPractitionerIDResponseQualificationTypeItemCodeType Code { get; set; }

        [JsonProperty("period")]
        public DELETEPractitionerIDResponseQualificationTypeItemPeriodType Period { get; set; }

        [JsonProperty("issuer")]
        public DELETEPractitionerIDResponseQualificationTypeItemIssuerType Issuer { get; set; }
    }

    public class DELETEPractitionerIDResponseQualificationTypeItemIdentifierTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class DELETEPractitionerIDResponseQualificationTypeItemCodeType
    {
        [JsonProperty("coding")]
        public DELETEPractitionerIDResponseQualificationTypeItemCodeTypeCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class DELETEPractitionerIDResponseQualificationTypeItemCodeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DELETEPractitionerIDResponseQualificationTypeItemPeriodType
    {
        [JsonProperty("start")]
        public string Start { get; set; }
    }

    public class DELETEPractitionerIDResponseQualificationTypeItemIssuerType
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

    public class PUTPractitionerIDResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public PUTPractitionerIDResponseMetaType Meta { get; set; }

        [JsonProperty("identifier")]
        public PUTPractitionerIDResponseIdentifierTypeItem[] Identifier { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("name")]
        public PUTPractitionerIDResponseNameTypeItem[] Name { get; set; }

        [JsonProperty("telecom")]
        public PUTPractitionerIDResponseTelecomTypeItem[] Telecom { get; set; }

        [JsonProperty("address")]
        public PUTPractitionerIDResponseAddressTypeItem[] Address { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }
    }

    public class PUTPractitionerIDResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class PUTPractitionerIDResponseIdentifierTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class PUTPractitionerIDResponseNameTypeItem
    {
        [JsonProperty("family")]
        public string Family { get; set; }

        [JsonProperty("given")]
        public string[] Given { get; set; }

        [JsonProperty("prefix")]
        public string[] Prefix { get; set; }
    }

    public class PUTPractitionerIDResponseTelecomTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("use")]
        public string Use { get; set; }
    }

    public class PUTPractitionerIDResponseAddressTypeItem
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

    public class GETPractitionerIDVersionResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GETPractitionerIDVersionResponseMetaType Meta { get; set; }

        [JsonProperty("identifier")]
        public GETPractitionerIDVersionResponseIdentifierTypeItem[] Identifier { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("name")]
        public GETPractitionerIDVersionResponseNameTypeItem[] Name { get; set; }

        [JsonProperty("telecom")]
        public GETPractitionerIDVersionResponseTelecomTypeItem[] Telecom { get; set; }

        [JsonProperty("address")]
        public GETPractitionerIDVersionResponseAddressTypeItem[] Address { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }
    }

    public class GETPractitionerIDVersionResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GETPractitionerIDVersionResponseIdentifierTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class GETPractitionerIDVersionResponseNameTypeItem
    {
        [JsonProperty("family")]
        public string Family { get; set; }

        [JsonProperty("given")]
        public string[] Given { get; set; }

        [JsonProperty("prefix")]
        public string[] Prefix { get; set; }
    }

    public class GETPractitionerIDVersionResponseTelecomTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("use")]
        public string Use { get; set; }
    }

    public class GETPractitionerIDVersionResponseAddressTypeItem
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

    public class GETPractitionerIDHistoryResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GETPractitionerIDHistoryResponseMetaType Meta { get; set; }

        [JsonProperty("identifier")]
        public GETPractitionerIDHistoryResponseIdentifierTypeItem[] Identifier { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("name")]
        public GETPractitionerIDHistoryResponseNameTypeItem[] Name { get; set; }

        [JsonProperty("telecom")]
        public GETPractitionerIDHistoryResponseTelecomTypeItem[] Telecom { get; set; }

        [JsonProperty("address")]
        public GETPractitionerIDHistoryResponseAddressTypeItem[] Address { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }
    }

    public class GETPractitionerIDHistoryResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GETPractitionerIDHistoryResponseIdentifierTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class GETPractitionerIDHistoryResponseNameTypeItem
    {
        [JsonProperty("family")]
        public string Family { get; set; }

        [JsonProperty("given")]
        public string[] Given { get; set; }

        [JsonProperty("prefix")]
        public string[] Prefix { get; set; }
    }

    public class GETPractitionerIDHistoryResponseTelecomTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("use")]
        public string Use { get; set; }
    }

    public class GETPractitionerIDHistoryResponseAddressTypeItem
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

namespace Microsoft.Azure.Workflows.Sdk.Connectors
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