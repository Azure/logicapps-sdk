//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Pkisigning
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class PkisigningActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pkisigning")]
        public IBodyWorkflowAction<ExtendedSignerModel[], ApiConnectionActionConfiguration> ActorsList(Expression<Func<string>> requestId, Expression<Func<string>> documentId, Expression<Func<bool>> hasActed = null)
        {
            var __workflow_requestId = WorkflowExpression.Compile(requestId, nameof(requestId), required: true);
            var __workflow_documentId = WorkflowExpression.Compile(documentId, nameof(documentId), required: true);
            var __workflow_hasActed = WorkflowExpression.Compile(hasActed, nameof(hasActed), required: false);
            return new DeferredBodyAction<ExtendedSignerModel[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/requests/{0}/documents/{1}/Actors", __workflow_requestId.WithUrlEncoding(1), __workflow_documentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_hasActed != null)
                    callPayload.Queries["hasActed"] = ExpressionConverter.Convert(__workflow_hasActed);
                return new ApiConnectionAction<ExtendedSignerModel[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pkisigning")]
        public IBodyWorkflowAction<ExtendedSignerModel, ApiConnectionActionConfiguration> ActorsCreate(Expression<Func<string>> requestId, Expression<Func<string>> documentId, Expression<Func<actorModelactionInput>> actorModelaction, Expression<Func<string>> actorModelfirstname, Expression<Func<string>> actorModellastname, Expression<Func<string>> actorModelemail, Expression<Func<string>> actorModelmobile, Expression<Func<string>> actorModeldeadline, Expression<Func<actorModellanguageInput>> actorModellanguage, Expression<Func<bool>> actorModelvalidateRealIdentity, Expression<Func<string>> actorModelprefix = null, Expression<Func<int>> actorModeldossierPersonId = null, Expression<Func<string>> actorModelmessage = null, Expression<Func<string>> actorModelfieldName = null, Expression<Func<string>> actorModelplaceholder = null)
        {
            var __workflow_requestId = WorkflowExpression.Compile(requestId, nameof(requestId), required: true);
            var __workflow_documentId = WorkflowExpression.Compile(documentId, nameof(documentId), required: true);
            var __workflow_actorModelaction = WorkflowExpression.Compile(actorModelaction, nameof(actorModelaction), required: true);
            var __workflow_actorModelfirstname = WorkflowExpression.Compile(actorModelfirstname, nameof(actorModelfirstname), required: true);
            var __workflow_actorModellastname = WorkflowExpression.Compile(actorModellastname, nameof(actorModellastname), required: true);
            var __workflow_actorModelemail = WorkflowExpression.Compile(actorModelemail, nameof(actorModelemail), required: true);
            var __workflow_actorModelmobile = WorkflowExpression.Compile(actorModelmobile, nameof(actorModelmobile), required: true);
            var __workflow_actorModeldeadline = WorkflowExpression.Compile(actorModeldeadline, nameof(actorModeldeadline), required: true);
            var __workflow_actorModellanguage = WorkflowExpression.Compile(actorModellanguage, nameof(actorModellanguage), required: true);
            var __workflow_actorModelvalidateRealIdentity = WorkflowExpression.Compile(actorModelvalidateRealIdentity, nameof(actorModelvalidateRealIdentity), required: true);
            var __workflow_actorModelprefix = WorkflowExpression.Compile(actorModelprefix, nameof(actorModelprefix), required: false);
            var __workflow_actorModeldossierPersonId = WorkflowExpression.Compile(actorModeldossierPersonId, nameof(actorModeldossierPersonId), required: false);
            var __workflow_actorModelmessage = WorkflowExpression.Compile(actorModelmessage, nameof(actorModelmessage), required: false);
            var __workflow_actorModelfieldName = WorkflowExpression.Compile(actorModelfieldName, nameof(actorModelfieldName), required: false);
            var __workflow_actorModelplaceholder = WorkflowExpression.Compile(actorModelplaceholder, nameof(actorModelplaceholder), required: false);
            return new DeferredBodyAction<ExtendedSignerModel, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/requests/{0}/documents/{1}/Actors", __workflow_requestId.WithUrlEncoding(1), __workflow_documentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var actorModel = new JObject();
                var actorModelpropCount = 0;
                actorModelpropCount++;
                actorModel["action"] = ExpressionConverter.ConvertO(__workflow_actorModelaction);
                actorModelpropCount++;
                actorModel["firstname"] = ExpressionConverter.ConvertO(__workflow_actorModelfirstname);
                if (__workflow_actorModelprefix != null)
                {
                    actorModel["prefix"] = ExpressionConverter.ConvertO(__workflow_actorModelprefix);
                    actorModelpropCount++;
                }

                actorModelpropCount++;
                actorModel["lastname"] = ExpressionConverter.ConvertO(__workflow_actorModellastname);
                actorModelpropCount++;
                actorModel["email"] = ExpressionConverter.ConvertO(__workflow_actorModelemail);
                actorModelpropCount++;
                actorModel["mobile"] = ExpressionConverter.ConvertO(__workflow_actorModelmobile);
                actorModelpropCount++;
                actorModel["deadline"] = ExpressionConverter.ConvertO(__workflow_actorModeldeadline);
                actorModelpropCount++;
                actorModel["language"] = ExpressionConverter.ConvertO(__workflow_actorModellanguage);
                actorModelpropCount++;
                actorModel["validateRealIdentity"] = ExpressionConverter.ConvertO(__workflow_actorModelvalidateRealIdentity);
                if (__workflow_actorModeldossierPersonId != null)
                {
                    actorModel["dossierPersonId"] = ExpressionConverter.ConvertO(__workflow_actorModeldossierPersonId);
                    actorModelpropCount++;
                }

                if (__workflow_actorModelmessage != null)
                {
                    actorModel["message"] = ExpressionConverter.ConvertO(__workflow_actorModelmessage);
                    actorModelpropCount++;
                }

                if (__workflow_actorModelfieldName != null)
                {
                    actorModel["fieldName"] = ExpressionConverter.ConvertO(__workflow_actorModelfieldName);
                    actorModelpropCount++;
                }

                if (__workflow_actorModelplaceholder != null)
                {
                    actorModel["placeholder"] = ExpressionConverter.ConvertO(__workflow_actorModelplaceholder);
                    actorModelpropCount++;
                }

                actorModel["sigFieldX"] = 0;
                actorModelpropCount++;
                actorModel["sigFieldY"] = 0;
                actorModelpropCount++;
                actorModel["sigFieldH"] = 0;
                actorModelpropCount++;
                actorModel["sigFieldW"] = 0;
                actorModelpropCount++;
                if (actorModelpropCount > 0)
                {
                    callPayload.Body = actorModel;
                }

                return new ApiConnectionAction<ExtendedSignerModel>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pkisigning")]
        public IBodyWorkflowAction<ExtendedSignerModel, ApiConnectionActionConfiguration> ActorsUpdate(Expression<Func<string>> requestId, Expression<Func<string>> documentId, Expression<Func<string>> actorId, Expression<Func<actorModelModelactionInput>> actorModelModelaction, Expression<Func<string>> actorModelModelfirstname, Expression<Func<string>> actorModelModellastname, Expression<Func<string>> actorModelModelemail, Expression<Func<string>> actorModelModelmobile, Expression<Func<string>> actorModelModeldeadline, Expression<Func<actorModelModellanguageInput>> actorModelModellanguage, Expression<Func<bool>> actorModelModelvalidateRealIdentity, Expression<Func<string>> actorModelModelprefix = null, Expression<Func<int>> actorModelModeldossierPersonId = null, Expression<Func<string>> actorModelModelmessage = null)
        {
            var __workflow_requestId = WorkflowExpression.Compile(requestId, nameof(requestId), required: true);
            var __workflow_documentId = WorkflowExpression.Compile(documentId, nameof(documentId), required: true);
            var __workflow_actorId = WorkflowExpression.Compile(actorId, nameof(actorId), required: true);
            var __workflow_actorModelModelaction = WorkflowExpression.Compile(actorModelModelaction, nameof(actorModelModelaction), required: true);
            var __workflow_actorModelModelfirstname = WorkflowExpression.Compile(actorModelModelfirstname, nameof(actorModelModelfirstname), required: true);
            var __workflow_actorModelModellastname = WorkflowExpression.Compile(actorModelModellastname, nameof(actorModelModellastname), required: true);
            var __workflow_actorModelModelemail = WorkflowExpression.Compile(actorModelModelemail, nameof(actorModelModelemail), required: true);
            var __workflow_actorModelModelmobile = WorkflowExpression.Compile(actorModelModelmobile, nameof(actorModelModelmobile), required: true);
            var __workflow_actorModelModeldeadline = WorkflowExpression.Compile(actorModelModeldeadline, nameof(actorModelModeldeadline), required: true);
            var __workflow_actorModelModellanguage = WorkflowExpression.Compile(actorModelModellanguage, nameof(actorModelModellanguage), required: true);
            var __workflow_actorModelModelvalidateRealIdentity = WorkflowExpression.Compile(actorModelModelvalidateRealIdentity, nameof(actorModelModelvalidateRealIdentity), required: true);
            var __workflow_actorModelModelprefix = WorkflowExpression.Compile(actorModelModelprefix, nameof(actorModelModelprefix), required: false);
            var __workflow_actorModelModeldossierPersonId = WorkflowExpression.Compile(actorModelModeldossierPersonId, nameof(actorModelModeldossierPersonId), required: false);
            var __workflow_actorModelModelmessage = WorkflowExpression.Compile(actorModelModelmessage, nameof(actorModelModelmessage), required: false);
            return new DeferredBodyAction<ExtendedSignerModel, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/requests/{0}/documents/{1}/Actors/{2}", __workflow_requestId.WithUrlEncoding(1), __workflow_documentId.WithUrlEncoding(1), __workflow_actorId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var actorModelModel = new JObject();
                var actorModelModelpropCount = 0;
                actorModelModelpropCount++;
                actorModelModel["action"] = ExpressionConverter.ConvertO(__workflow_actorModelModelaction);
                actorModelModelpropCount++;
                actorModelModel["firstname"] = ExpressionConverter.ConvertO(__workflow_actorModelModelfirstname);
                if (__workflow_actorModelModelprefix != null)
                {
                    actorModelModel["prefix"] = ExpressionConverter.ConvertO(__workflow_actorModelModelprefix);
                    actorModelModelpropCount++;
                }

                actorModelModelpropCount++;
                actorModelModel["lastname"] = ExpressionConverter.ConvertO(__workflow_actorModelModellastname);
                actorModelModelpropCount++;
                actorModelModel["email"] = ExpressionConverter.ConvertO(__workflow_actorModelModelemail);
                actorModelModelpropCount++;
                actorModelModel["mobile"] = ExpressionConverter.ConvertO(__workflow_actorModelModelmobile);
                actorModelModelpropCount++;
                actorModelModel["deadline"] = ExpressionConverter.ConvertO(__workflow_actorModelModeldeadline);
                actorModelModelpropCount++;
                actorModelModel["language"] = ExpressionConverter.ConvertO(__workflow_actorModelModellanguage);
                actorModelModelpropCount++;
                actorModelModel["validateRealIdentity"] = ExpressionConverter.ConvertO(__workflow_actorModelModelvalidateRealIdentity);
                if (__workflow_actorModelModeldossierPersonId != null)
                {
                    actorModelModel["dossierPersonId"] = ExpressionConverter.ConvertO(__workflow_actorModelModeldossierPersonId);
                    actorModelModelpropCount++;
                }

                if (__workflow_actorModelModelmessage != null)
                {
                    actorModelModel["message"] = ExpressionConverter.ConvertO(__workflow_actorModelModelmessage);
                    actorModelModelpropCount++;
                }

                if (actorModelModelpropCount > 0)
                {
                    callPayload.Body = actorModelModel;
                }

                return new ApiConnectionAction<ExtendedSignerModel>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pkisigning")]
        public IBodyWorkflowAction<ExtendedSignerModel, ApiConnectionActionConfiguration> ActorsGet(Expression<Func<string>> requestId, Expression<Func<string>> documentId, Expression<Func<string>> actorId)
        {
            var __workflow_requestId = WorkflowExpression.Compile(requestId, nameof(requestId), required: true);
            var __workflow_documentId = WorkflowExpression.Compile(documentId, nameof(documentId), required: true);
            var __workflow_actorId = WorkflowExpression.Compile(actorId, nameof(actorId), required: true);
            return new DeferredBodyAction<ExtendedSignerModel, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/requests/{0}/documents/{1}/Actors/{2}", __workflow_requestId.WithUrlEncoding(1), __workflow_documentId.WithUrlEncoding(1), __workflow_actorId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ExtendedSignerModel>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pkisigning")]
        public IWorkflowAction<ApiConnectionActionConfiguration> ActorsDelete(Expression<Func<string>> requestId, Expression<Func<string>> documentId, Expression<Func<string>> actorId)
        {
            var __workflow_requestId = WorkflowExpression.Compile(requestId, nameof(requestId), required: true);
            var __workflow_documentId = WorkflowExpression.Compile(documentId, nameof(documentId), required: true);
            var __workflow_actorId = WorkflowExpression.Compile(actorId, nameof(actorId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/requests/{0}/documents/{1}/Actors/{2}", __workflow_requestId.WithUrlEncoding(1), __workflow_documentId.WithUrlEncoding(1), __workflow_actorId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pkisigning")]
        public IBodyWorkflowAction<ExtendedSignerModel[], ApiConnectionActionConfiguration> ActorsRequestActors(Expression<Func<string>> requestId, Expression<Func<bool>> hasActed = null)
        {
            var __workflow_requestId = WorkflowExpression.Compile(requestId, nameof(requestId), required: true);
            var __workflow_hasActed = WorkflowExpression.Compile(hasActed, nameof(hasActed), required: false);
            return new DeferredBodyAction<ExtendedSignerModel[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/requests/{0}/Actors", __workflow_requestId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_hasActed != null)
                    callPayload.Queries["hasActed"] = ExpressionConverter.Convert(__workflow_hasActed);
                return new ApiConnectionAction<ExtendedSignerModel[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pkisigning")]
        public IWorkflowAction<ApiConnectionActionConfiguration> ActorsResendCurrentInvite(Expression<Func<string>> requestId)
        {
            var __workflow_requestId = WorkflowExpression.Compile(requestId, nameof(requestId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/requests/{0}/Actors/ResendCurrentInvite", __workflow_requestId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pkisigning")]
        public IWorkflowAction<ApiConnectionActionConfiguration> ActorsWithdrawCurrentInvite(Expression<Func<string>> requestId)
        {
            var __workflow_requestId = WorkflowExpression.Compile(requestId, nameof(requestId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/requests/{0}/Actors/WithdrawCurrentInvite", __workflow_requestId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pkisigning")]
        public IBodyWorkflowAction<DocumentMetaDataModel, ApiConnectionActionConfiguration> DocumentsGet(Expression<Func<string>> requestId, Expression<Func<string>> documentId)
        {
            var __workflow_requestId = WorkflowExpression.Compile(requestId, nameof(requestId), required: true);
            var __workflow_documentId = WorkflowExpression.Compile(documentId, nameof(documentId), required: true);
            return new DeferredBodyAction<DocumentMetaDataModel, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/requests/{0}/documents/{1}", __workflow_requestId.WithUrlEncoding(1), __workflow_documentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<DocumentMetaDataModel>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pkisigning")]
        public IBodyWorkflowAction<DocumentMetaDataModel, ApiConnectionActionConfiguration> DocumentsUpdate(Expression<Func<string>> requestId, Expression<Func<string>> documentId, Expression<Func<metadatadocumentTypeInput>> metadatadocumentType, Expression<Func<string>> metadataname = null, Expression<Func<string>> metadatafilename = null)
        {
            var __workflow_requestId = WorkflowExpression.Compile(requestId, nameof(requestId), required: true);
            var __workflow_documentId = WorkflowExpression.Compile(documentId, nameof(documentId), required: true);
            var __workflow_metadatadocumentType = WorkflowExpression.Compile(metadatadocumentType, nameof(metadatadocumentType), required: true);
            var __workflow_metadataname = WorkflowExpression.Compile(metadataname, nameof(metadataname), required: false);
            var __workflow_metadatafilename = WorkflowExpression.Compile(metadatafilename, nameof(metadatafilename), required: false);
            return new DeferredBodyAction<DocumentMetaDataModel, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/requests/{0}/documents/{1}", __workflow_requestId.WithUrlEncoding(1), __workflow_documentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var metadata = new JObject();
                var metadatapropCount = 0;
                if (__workflow_metadataname != null)
                {
                    metadata["name"] = ExpressionConverter.ConvertO(__workflow_metadataname);
                    metadatapropCount++;
                }

                if (__workflow_metadatafilename != null)
                {
                    metadata["filename"] = ExpressionConverter.ConvertO(__workflow_metadatafilename);
                    metadatapropCount++;
                }

                metadatapropCount++;
                metadata["documentType"] = ExpressionConverter.ConvertO(__workflow_metadatadocumentType);
                if (metadatapropCount > 0)
                {
                    callPayload.Body = metadata;
                }

                return new ApiConnectionAction<DocumentMetaDataModel>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pkisigning")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DocumentsDelete(Expression<Func<string>> requestId, Expression<Func<string>> documentId)
        {
            var __workflow_requestId = WorkflowExpression.Compile(requestId, nameof(requestId), required: true);
            var __workflow_documentId = WorkflowExpression.Compile(documentId, nameof(documentId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/requests/{0}/documents/{1}", __workflow_requestId.WithUrlEncoding(1), __workflow_documentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pkisigning")]
        public IBodyWorkflowAction<OrganisationWorkgroup[], ApiConnectionActionConfiguration> OrganisationsGetWorkgroups(Expression<Func<string>> organisationId)
        {
            var __workflow_organisationId = WorkflowExpression.Compile(organisationId, nameof(organisationId), required: true);
            return new DeferredBodyAction<OrganisationWorkgroup[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Organisations/{0}/workgroups", __workflow_organisationId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<OrganisationWorkgroup[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pkisigning")]
        public IBodyWorkflowAction<OrganisationWorkgroup[], ApiConnectionActionConfiguration> OrganisationsGetWorkgroupsByUser(Expression<Func<string>> organisationId, Expression<Func<string>> modelusername)
        {
            var __workflow_organisationId = WorkflowExpression.Compile(organisationId, nameof(organisationId), required: true);
            var __workflow_modelusername = WorkflowExpression.Compile(modelusername, nameof(modelusername), required: true);
            return new DeferredBodyAction<OrganisationWorkgroup[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Organisations/{0}/workgroups", __workflow_organisationId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var model = new JObject();
                var modelpropCount = 0;
                modelpropCount++;
                model["username"] = ExpressionConverter.ConvertO(__workflow_modelusername);
                if (modelpropCount > 0)
                {
                    callPayload.Body = model;
                }

                return new ApiConnectionAction<OrganisationWorkgroup[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pkisigning")]
        public IBodyWorkflowAction<RequestModel, ApiConnectionActionConfiguration> RequestsCreate(Expression<Func<string>> modelname, Expression<Func<int>> modelclearancelevel, Expression<Func<string>> modelworkgroupId = null, Expression<Func<string>> modelowner = null)
        {
            var __workflow_modelname = WorkflowExpression.Compile(modelname, nameof(modelname), required: true);
            var __workflow_modelclearancelevel = WorkflowExpression.Compile(modelclearancelevel, nameof(modelclearancelevel), required: true);
            var __workflow_modelworkgroupId = WorkflowExpression.Compile(modelworkgroupId, nameof(modelworkgroupId), required: false);
            var __workflow_modelowner = WorkflowExpression.Compile(modelowner, nameof(modelowner), required: false);
            return new DeferredBodyAction<RequestModel, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/requests";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var model = new JObject();
                var modelpropCount = 0;
                modelpropCount++;
                model["name"] = ExpressionConverter.ConvertO(__workflow_modelname);
                if (__workflow_modelworkgroupId != null)
                {
                    model["workgroupId"] = ExpressionConverter.ConvertO(__workflow_modelworkgroupId);
                    modelpropCount++;
                }

                modelpropCount++;
                model["clearancelevel"] = ExpressionConverter.ConvertO(__workflow_modelclearancelevel);
                if (__workflow_modelowner != null)
                {
                    model["owner"] = ExpressionConverter.ConvertO(__workflow_modelowner);
                    modelpropCount++;
                }

                if (modelpropCount > 0)
                {
                    callPayload.Body = model;
                }

                return new ApiConnectionAction<RequestModel>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pkisigning")]
        public IBodyWorkflowAction<RequestModel, ApiConnectionActionConfiguration> RequestsGet(Expression<Func<string>> requestId, Expression<Func<string>> callbackAuthenticationKey = null)
        {
            var __workflow_requestId = WorkflowExpression.Compile(requestId, nameof(requestId), required: true);
            var __workflow_callbackAuthenticationKey = WorkflowExpression.Compile(callbackAuthenticationKey, nameof(callbackAuthenticationKey), required: false);
            return new DeferredBodyAction<RequestModel, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/requests/{0}", __workflow_requestId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_callbackAuthenticationKey != null)
                    callPayload.Queries["callbackAuthenticationKey"] = ExpressionConverter.Convert(__workflow_callbackAuthenticationKey);
                return new ApiConnectionAction<RequestModel>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pkisigning")]
        public IBodyWorkflowAction<RequestModel, ApiConnectionActionConfiguration> RequestsUpdate(Expression<Func<string>> requestId, Expression<Func<string>> modelname, Expression<Func<int>> modelclearancelevel, Expression<Func<string>> modelworkgroupId = null, Expression<Func<string>> modelowner = null)
        {
            var __workflow_requestId = WorkflowExpression.Compile(requestId, nameof(requestId), required: true);
            var __workflow_modelname = WorkflowExpression.Compile(modelname, nameof(modelname), required: true);
            var __workflow_modelclearancelevel = WorkflowExpression.Compile(modelclearancelevel, nameof(modelclearancelevel), required: true);
            var __workflow_modelworkgroupId = WorkflowExpression.Compile(modelworkgroupId, nameof(modelworkgroupId), required: false);
            var __workflow_modelowner = WorkflowExpression.Compile(modelowner, nameof(modelowner), required: false);
            return new DeferredBodyAction<RequestModel, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/requests/{0}", __workflow_requestId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var model = new JObject();
                var modelpropCount = 0;
                modelpropCount++;
                model["name"] = ExpressionConverter.ConvertO(__workflow_modelname);
                if (__workflow_modelworkgroupId != null)
                {
                    model["workgroupId"] = ExpressionConverter.ConvertO(__workflow_modelworkgroupId);
                    modelpropCount++;
                }

                modelpropCount++;
                model["clearancelevel"] = ExpressionConverter.ConvertO(__workflow_modelclearancelevel);
                if (__workflow_modelowner != null)
                {
                    model["owner"] = ExpressionConverter.ConvertO(__workflow_modelowner);
                    modelpropCount++;
                }

                if (modelpropCount > 0)
                {
                    callPayload.Body = model;
                }

                return new ApiConnectionAction<RequestModel>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pkisigning")]
        public IWorkflowAction<ApiConnectionActionConfiguration> RequestsDelete(Expression<Func<string>> requestId)
        {
            var __workflow_requestId = WorkflowExpression.Compile(requestId, nameof(requestId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/requests/{0}", __workflow_requestId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pkisigning")]
        public IBodyWorkflowAction<object, ApiConnectionActionConfiguration> RequestsDownload(Expression<Func<string>> requestId)
        {
            var __workflow_requestId = WorkflowExpression.Compile(requestId, nameof(requestId), required: true);
            return new DeferredBodyAction<object, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/requests/{0}/Download", __workflow_requestId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<object>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pkisigning")]
        public IWorkflowAction<ApiConnectionActionConfiguration> RequestsSend(Expression<Func<string>> requestId)
        {
            var __workflow_requestId = WorkflowExpression.Compile(requestId, nameof(requestId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/requests/{0}/Send", __workflow_requestId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class PkisigningTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<WebhookResponseModel, ApiConnectionTriggerConfiguration> WebhooksCreateWebhook(Expression<Func<string[]>> modelevents, Expression<Func<string>> organisationId, FlowRecurrence recurrence = null)
        {
            var __workflow_modelevents = WorkflowExpression.Compile(modelevents, nameof(modelevents), required: true);
            var __workflow_organisationId = WorkflowExpression.Compile(organisationId, nameof(organisationId), required: true);
            return new DeferredBodyTrigger<WebhookResponseModel, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/organisations/{0}/webhooks", __workflow_organisationId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var model = new JObject();
                var modelpropCount = 0;
                modelpropCount++;
                model["Events"] = ExpressionConverter.ConvertO(__workflow_modelevents);
                var configObject = new JObject();
                var configObjectpropCount = 0;
                configObject["url"] = "#{listCallbackUrl()}";
                configObjectpropCount++;
                if (configObjectpropCount > 0)
                {
                    model["Config"] = configObject;
                    modelpropCount++;
                }

                model["Active"] = true;
                modelpropCount++;
                if (modelpropCount > 0)
                {
                    callPayload.Body = model;
                }

                return new ApiConnectionTrigger<WebhookResponseModel>(callPayload, recurrence: recurrence);
            });
        }
    }

    public class ExtendedSignerModel
    {
        [JsonProperty("fieldName")]
        public string FieldName { get; set; }

        [JsonProperty("placeholder")]
        public string Placeholder { get; set; }

        [JsonProperty("sigFieldX")]
        public double SigFieldX { get; set; }

        [JsonProperty("sigFieldY")]
        public double SigFieldY { get; set; }

        [JsonProperty("sigFieldH")]
        public double SigFieldH { get; set; }

        [JsonProperty("sigFieldW")]
        public double SigFieldW { get; set; }

        [JsonProperty("action")]
        public ExtendedSignerModelActionType Action { get; set; }

        [JsonProperty("firstname")]
        public string Firstname { get; set; }

        [JsonProperty("prefix")]
        public string Prefix { get; set; }

        [JsonProperty("lastname")]
        public string Lastname { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("mobile")]
        public string Mobile { get; set; }

        [JsonProperty("deadline")]
        public string Deadline { get; set; }

        [JsonProperty("language")]
        public ExtendedSignerModelLanguageType Language { get; set; }

        [JsonProperty("validateRealIdentity")]
        public bool ValidateRealIdentity { get; set; }

        [JsonProperty("dossierPersonId")]
        public int DossierPersonId { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("signingDate")]
        public string SigningDate { get; set; }

        [JsonProperty("hasSigned")]
        public bool HasSigned { get; set; }

        [JsonProperty("fullName")]
        public string FullName { get; set; }

        [JsonProperty("emailActivity")]
        public EmailActivity[] EmailActivity { get; set; }

        [JsonProperty("documentId")]
        public string DocumentId { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ExtendedSignerModelActionType
    {
        Sign,
        Download,
        Approve
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ExtendedSignerModelLanguageType
    {
        NL,
        EN
    }

    public class EmailActivity
    {
        [JsonProperty("event")]
        public string Event { get; set; }

        [JsonProperty("reason")]
        public string Reason { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }

        [JsonProperty("pkisMessageType")]
        public string PkisMessageType { get; set; }

        [JsonProperty("pkisInviteId")]
        public string PkisInviteId { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum actorModelactionInput
    {
        Sign,
        Download,
        Approve
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum actorModellanguageInput
    {
        NL,
        EN
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum actorModelModelactionInput
    {
        Sign,
        Download,
        Approve
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum actorModelModellanguageInput
    {
        NL,
        EN
    }

    public class DocumentMetaDataModel
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("lastUpdate")]
        public string LastUpdate { get; set; }

        [JsonProperty("pages")]
        public int Pages { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("expires")]
        public string Expires { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("status")]
        public DocumentMetaDataModelStatusType Status { get; set; }

        [JsonProperty("signed")]
        public bool Signed { get; set; }

        [JsonProperty("signatures")]
        public SignatureData[] Signatures { get; set; }

        [JsonProperty("emptySignatureFields")]
        public SignatureField[] EmptySignatureFields { get; set; }

        [JsonProperty("containsBlankSignatureFields")]
        public bool ContainsBlankSignatureFields { get; set; }

        [JsonProperty("actors")]
        public ExtendedSignerModel[] Actors { get; set; }

        [JsonProperty("requestId")]
        public string RequestId { get; set; }

        [JsonProperty("reasons")]
        public string Reasons { get; set; }

        [JsonProperty("signerNote")]
        public string SignerNote { get; set; }

        [JsonProperty("recipientNote")]
        public string RecipientNote { get; set; }

        [JsonProperty("isMyDocument")]
        public bool IsMyDocument { get; set; }

        [JsonProperty("dossierIndex")]
        public int DossierIndex { get; set; }

        [JsonProperty("documentSize")]
        public int DocumentSize { get; set; }

        [JsonProperty("documentType")]
        public DocumentMetaDataModelDocumentTypeType DocumentType { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum DocumentMetaDataModelStatusType
    {
        Active,
        Completed,
        Declined,
        Processing,
        Error,
        PendingSbrNexus,
        Withdrawn,
        PendingDigipoort,
        New,
        Filing,
        InvitationExpired,
        Elapsed,
        Expired,
        PendingApproval,
        PendingDownload,
        PendingSignature,
        PendingDetermination
    }

    public class SignatureData
    {
        [JsonProperty("subject")]
        public KeyValuePairOfStringAndString[] Subject { get; set; }

        [JsonProperty("issuer")]
        public KeyValuePairOfStringAndString[] Issuer { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("reason")]
        public string Reason { get; set; }

        [JsonProperty("euQualified")]
        public bool EuQualified { get; set; }

        [JsonProperty("advanced")]
        public bool Advanced { get; set; }

        [JsonProperty("eSeal")]
        public bool ESeal { get; set; }

        [JsonProperty("ipAddress")]
        public string IpAddress { get; set; }

        [JsonProperty("signatureField")]
        public string SignatureField { get; set; }

        [JsonProperty("signatureImage")]
        public string SignatureImage { get; set; }
    }

    public class KeyValuePairOfStringAndString
    {
        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class SignatureField
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("x")]
        public double X { get; set; }

        [JsonProperty("y")]
        public double Y { get; set; }

        [JsonProperty("height")]
        public double Height { get; set; }

        [JsonProperty("width")]
        public double Width { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum DocumentMetaDataModelDocumentTypeType
    {
        RegularPdf,
        XbrlPublicationVersionAnnualReport,
        XbrlAuditorsReport,
        DetachedSignature,
        XbrlPreparerExtension,
        PdfAudittrail,
        XbrlCompositionStatement,
        XbrlStatutoryVersionAnnualReport,
        DNBStaat,
        RegularXml,
        ReferencedDocument,
        Json,
        JsonSignature,
        GenericTextFile,
        VatDeclaration,
        VatEuRecapitulativeStatement,
        IncomeTaxDeclaration,
        CorporateTaxDeclaration,
        XbrlNexusVersionAnnualReport,
        XbrlAuditorsReportSFO,
        XbrlAssessmentStatement,
        SignatureStylesheet,
        EnvelopingSignatureData,
        PageImage,
        SHA256Hash,
        SHA256Signature,
        Unspecified
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum metadatadocumentTypeInput
    {
        RegularPdf,
        XbrlPublicationVersionAnnualReport,
        XbrlAuditorsReport,
        DetachedSignature,
        XbrlPreparerExtension,
        PdfAudittrail,
        XbrlCompositionStatement,
        XbrlStatutoryVersionAnnualReport,
        DNBStaat,
        RegularXml,
        ReferencedDocument,
        Json,
        JsonSignature,
        GenericTextFile,
        VatDeclaration,
        VatEuRecapitulativeStatement,
        IncomeTaxDeclaration,
        CorporateTaxDeclaration,
        XbrlNexusVersionAnnualReport,
        XbrlAuditorsReportSFO,
        XbrlAssessmentStatement,
        SignatureStylesheet,
        EnvelopingSignatureData,
        PageImage,
        SHA256Hash,
        SHA256Signature,
        Unspecified
    }

    public class OrganisationWorkgroup
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class RequestModel
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("dossierName")]
        public string DossierName { get; set; }

        [JsonProperty("documents")]
        public DocumentModel[] Documents { get; set; }

        [JsonProperty("status")]
        public RequestModelStatusType Status { get; set; }

        [JsonProperty("actors")]
        public ExtendedSignerModel[] Actors { get; set; }

        [JsonProperty("signed")]
        public bool Signed { get; set; }

        [JsonProperty("signatures")]
        public SignatureData[] Signatures { get; set; }

        [JsonProperty("dossierType")]
        public RequestModelDossierTypeType DossierType { get; set; }

        [JsonProperty("reasons")]
        public string Reasons { get; set; }

        [JsonProperty("signerNote")]
        public string SignerNote { get; set; }

        [JsonProperty("recipientNote")]
        public string RecipientNote { get; set; }

        [JsonProperty("accorderNote")]
        public string AccorderNote { get; set; }

        [JsonProperty("expires")]
        public string Expires { get; set; }

        [JsonProperty("emailActivity")]
        public EmailActivity[] EmailActivity { get; set; }

        [JsonProperty("myDossier")]
        public bool MyDossier { get; set; }

        [JsonProperty("taxPaymentStatus")]
        public string TaxPaymentStatus { get; set; }

        [JsonProperty("workgroup")]
        public string Workgroup { get; set; }

        [JsonProperty("clearancelevel")]
        public int Clearancelevel { get; set; }
    }

    public class DocumentModel
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("documentType")]
        public DocumentModelDocumentTypeType DocumentType { get; set; }

        [JsonProperty("dossierIndex")]
        public int DossierIndex { get; set; }

        [JsonProperty("documentstatus")]
        public DocumentModelDocumentstatusType Documentstatus { get; set; }

        [JsonProperty("actors")]
        public SignerModel[] Actors { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum DocumentModelDocumentTypeType
    {
        RegularPdf,
        XbrlPublicationVersionAnnualReport,
        XbrlAuditorsReport,
        DetachedSignature,
        XbrlPreparerExtension,
        PdfAudittrail,
        XbrlCompositionStatement,
        XbrlStatutoryVersionAnnualReport,
        DNBStaat,
        RegularXml,
        ReferencedDocument,
        Json,
        JsonSignature,
        GenericTextFile,
        VatDeclaration,
        VatEuRecapitulativeStatement,
        IncomeTaxDeclaration,
        CorporateTaxDeclaration,
        XbrlNexusVersionAnnualReport,
        XbrlAuditorsReportSFO,
        XbrlAssessmentStatement,
        SignatureStylesheet,
        EnvelopingSignatureData,
        PageImage,
        SHA256Hash,
        SHA256Signature,
        Unspecified
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum DocumentModelDocumentstatusType
    {
        Active,
        Completed,
        Declined,
        Processing,
        Error,
        PendingSbrNexus,
        Withdrawn,
        PendingDigipoort,
        New,
        Filing,
        InvitationExpired,
        Elapsed,
        Expired,
        PendingApproval,
        PendingDownload,
        PendingSignature,
        PendingDetermination
    }

    public class SignerModel
    {
        [JsonProperty("action")]
        public SignerModelActionType Action { get; set; }

        [JsonProperty("firstname")]
        public string Firstname { get; set; }

        [JsonProperty("prefix")]
        public string Prefix { get; set; }

        [JsonProperty("lastname")]
        public string Lastname { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("mobile")]
        public string Mobile { get; set; }

        [JsonProperty("deadline")]
        public string Deadline { get; set; }

        [JsonProperty("language")]
        public SignerModelLanguageType Language { get; set; }

        [JsonProperty("validateRealIdentity")]
        public bool ValidateRealIdentity { get; set; }

        [JsonProperty("dossierPersonId")]
        public int DossierPersonId { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("fieldName")]
        public string FieldName { get; set; }

        [JsonProperty("placeholder")]
        public string Placeholder { get; set; }

        [JsonProperty("sigFieldX")]
        public double SigFieldX { get; set; }

        [JsonProperty("sigFieldY")]
        public double SigFieldY { get; set; }

        [JsonProperty("sigFieldH")]
        public double SigFieldH { get; set; }

        [JsonProperty("sigFieldW")]
        public double SigFieldW { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SignerModelActionType
    {
        Sign,
        Download,
        Approve
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SignerModelLanguageType
    {
        NL,
        EN
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum RequestModelStatusType
    {
        Active,
        Completed,
        Declined,
        Processing,
        Error,
        PendingSbrNexus,
        Withdrawn,
        PendingDigipoort,
        New,
        Filing,
        InvitationExpired,
        Expired,
        PendingApproval,
        PendingDownload,
        PendingSignature
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum RequestModelDossierTypeType
    {
        IcpDeclaration,
        IncomeTaxDeclaration,
        VatDeclaration,
        Unknown,
        PDF,
        FinancialStatements,
        SbrAssurance,
        SbrNexusAssurance,
        SbrNexusAnnualReport,
        CorporateTaxDeclaration,
        Incomplete,
        AnnualFinancialFiles
    }

    public class WebhookResponseModel
    {
        [JsonProperty("events")]
        public string[] Events { get; set; }

        [JsonProperty("config")]
        public WebhookConfig Config { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("lastUpdate")]
        public string LastUpdate { get; set; }
    }

    public class WebhookConfig
    {
        [JsonProperty("url")]
        public string Url { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Pkisigning;

    public partial class WorkflowManagedActions
    {
        public PkisigningActions Pkisigning(string connectionId) => new PkisigningActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public PkisigningTriggers Pkisigning(string connectionId) => new PkisigningTriggers(connectionId);
    }
}