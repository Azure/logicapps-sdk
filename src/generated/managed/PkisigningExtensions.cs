//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Pkisigning
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class PkisigningActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pkisigning")]
        [WorkflowExpressionFactory(nameof(__BuildActorsList))]
        public IBodyWorkflowAction<ExtendedSignerModel[]> ActorsList([WorkflowExpression] Func<string> requestId, [WorkflowExpression] Func<string> documentId, [WorkflowExpression] Func<bool> hasActed = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ExtendedSignerModel[]> __BuildActorsList(WorkflowExpression<string> requestId, WorkflowExpression<string> documentId, WorkflowExpression<bool> hasActed = null)
        {
            WorkflowExpression.Validate(requestId, nameof(requestId), required: true);
            WorkflowExpression.Validate(documentId, nameof(documentId), required: true);
            WorkflowExpression.Validate(hasActed, nameof(hasActed), required: false);
            return new DeferredBodyAction<ExtendedSignerModel[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/requests/{0}/documents/{1}/Actors", ExpressionConverter.ConvertWithUrlEncoding(requestId, 1), ExpressionConverter.ConvertWithUrlEncoding(documentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (hasActed != null)
                    callPayload.Queries["hasActed"] = ExpressionConverter.Convert(hasActed);
                return new ApiConnectionAction<ExtendedSignerModel[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pkisigning")]
        [WorkflowExpressionFactory(nameof(__BuildActorsCreate))]
        public IBodyWorkflowAction<ExtendedSignerModel> ActorsCreate([WorkflowExpression] Func<string> requestId, [WorkflowExpression] Func<string> documentId, [WorkflowExpression] Func<actorModelactionInput> actorModelaction, [WorkflowExpression] Func<string> actorModelfirstname, [WorkflowExpression] Func<string> actorModellastname, [WorkflowExpression] Func<string> actorModelemail, [WorkflowExpression] Func<string> actorModelmobile, [WorkflowExpression] Func<string> actorModeldeadline, [WorkflowExpression] Func<actorModellanguageInput> actorModellanguage, [WorkflowExpression] Func<bool> actorModelvalidateRealIdentity, [WorkflowExpression] Func<string> actorModelprefix = null, [WorkflowExpression] Func<int> actorModeldossierPersonId = null, [WorkflowExpression] Func<string> actorModelmessage = null, [WorkflowExpression] Func<string> actorModelfieldName = null, [WorkflowExpression] Func<string> actorModelplaceholder = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ExtendedSignerModel> __BuildActorsCreate(WorkflowExpression<string> requestId, WorkflowExpression<string> documentId, WorkflowExpression<actorModelactionInput> actorModelaction, WorkflowExpression<string> actorModelfirstname, WorkflowExpression<string> actorModellastname, WorkflowExpression<string> actorModelemail, WorkflowExpression<string> actorModelmobile, WorkflowExpression<string> actorModeldeadline, WorkflowExpression<actorModellanguageInput> actorModellanguage, WorkflowExpression<bool> actorModelvalidateRealIdentity, WorkflowExpression<string> actorModelprefix = null, WorkflowExpression<int> actorModeldossierPersonId = null, WorkflowExpression<string> actorModelmessage = null, WorkflowExpression<string> actorModelfieldName = null, WorkflowExpression<string> actorModelplaceholder = null)
        {
            WorkflowExpression.Validate(requestId, nameof(requestId), required: true);
            WorkflowExpression.Validate(documentId, nameof(documentId), required: true);
            WorkflowExpression.Validate(actorModelaction, nameof(actorModelaction), required: true);
            WorkflowExpression.Validate(actorModelfirstname, nameof(actorModelfirstname), required: true);
            WorkflowExpression.Validate(actorModellastname, nameof(actorModellastname), required: true);
            WorkflowExpression.Validate(actorModelemail, nameof(actorModelemail), required: true);
            WorkflowExpression.Validate(actorModelmobile, nameof(actorModelmobile), required: true);
            WorkflowExpression.Validate(actorModeldeadline, nameof(actorModeldeadline), required: true);
            WorkflowExpression.Validate(actorModellanguage, nameof(actorModellanguage), required: true);
            WorkflowExpression.Validate(actorModelvalidateRealIdentity, nameof(actorModelvalidateRealIdentity), required: true);
            WorkflowExpression.Validate(actorModelprefix, nameof(actorModelprefix), required: false);
            WorkflowExpression.Validate(actorModeldossierPersonId, nameof(actorModeldossierPersonId), required: false);
            WorkflowExpression.Validate(actorModelmessage, nameof(actorModelmessage), required: false);
            WorkflowExpression.Validate(actorModelfieldName, nameof(actorModelfieldName), required: false);
            WorkflowExpression.Validate(actorModelplaceholder, nameof(actorModelplaceholder), required: false);
            return new DeferredBodyAction<ExtendedSignerModel>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/requests/{0}/documents/{1}/Actors", ExpressionConverter.ConvertWithUrlEncoding(requestId, 1), ExpressionConverter.ConvertWithUrlEncoding(documentId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var actorModel = new JObject();
                var actorModelpropCount = 0;
                actorModelpropCount++;
                actorModel["action"] = ExpressionConverter.ConvertO(actorModelaction);
                actorModelpropCount++;
                actorModel["firstname"] = ExpressionConverter.ConvertO(actorModelfirstname);
                if (actorModelprefix != null)
                {
                    actorModel["prefix"] = ExpressionConverter.ConvertO(actorModelprefix);
                    actorModelpropCount++;
                }

                actorModelpropCount++;
                actorModel["lastname"] = ExpressionConverter.ConvertO(actorModellastname);
                actorModelpropCount++;
                actorModel["email"] = ExpressionConverter.ConvertO(actorModelemail);
                actorModelpropCount++;
                actorModel["mobile"] = ExpressionConverter.ConvertO(actorModelmobile);
                actorModelpropCount++;
                actorModel["deadline"] = ExpressionConverter.ConvertO(actorModeldeadline);
                actorModelpropCount++;
                actorModel["language"] = ExpressionConverter.ConvertO(actorModellanguage);
                actorModelpropCount++;
                actorModel["validateRealIdentity"] = ExpressionConverter.ConvertO(actorModelvalidateRealIdentity);
                if (actorModeldossierPersonId != null)
                {
                    actorModel["dossierPersonId"] = ExpressionConverter.ConvertO(actorModeldossierPersonId);
                    actorModelpropCount++;
                }

                if (actorModelmessage != null)
                {
                    actorModel["message"] = ExpressionConverter.ConvertO(actorModelmessage);
                    actorModelpropCount++;
                }

                if (actorModelfieldName != null)
                {
                    actorModel["fieldName"] = ExpressionConverter.ConvertO(actorModelfieldName);
                    actorModelpropCount++;
                }

                if (actorModelplaceholder != null)
                {
                    actorModel["placeholder"] = ExpressionConverter.ConvertO(actorModelplaceholder);
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
        [WorkflowExpressionFactory(nameof(__BuildActorsUpdate))]
        public IBodyWorkflowAction<ExtendedSignerModel> ActorsUpdate([WorkflowExpression] Func<string> requestId, [WorkflowExpression] Func<string> documentId, [WorkflowExpression] Func<string> actorId, [WorkflowExpression] Func<actorModelModelactionInput> actorModelModelaction, [WorkflowExpression] Func<string> actorModelModelfirstname, [WorkflowExpression] Func<string> actorModelModellastname, [WorkflowExpression] Func<string> actorModelModelemail, [WorkflowExpression] Func<string> actorModelModelmobile, [WorkflowExpression] Func<string> actorModelModeldeadline, [WorkflowExpression] Func<actorModelModellanguageInput> actorModelModellanguage, [WorkflowExpression] Func<bool> actorModelModelvalidateRealIdentity, [WorkflowExpression] Func<string> actorModelModelprefix = null, [WorkflowExpression] Func<int> actorModelModeldossierPersonId = null, [WorkflowExpression] Func<string> actorModelModelmessage = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ExtendedSignerModel> __BuildActorsUpdate(WorkflowExpression<string> requestId, WorkflowExpression<string> documentId, WorkflowExpression<string> actorId, WorkflowExpression<actorModelModelactionInput> actorModelModelaction, WorkflowExpression<string> actorModelModelfirstname, WorkflowExpression<string> actorModelModellastname, WorkflowExpression<string> actorModelModelemail, WorkflowExpression<string> actorModelModelmobile, WorkflowExpression<string> actorModelModeldeadline, WorkflowExpression<actorModelModellanguageInput> actorModelModellanguage, WorkflowExpression<bool> actorModelModelvalidateRealIdentity, WorkflowExpression<string> actorModelModelprefix = null, WorkflowExpression<int> actorModelModeldossierPersonId = null, WorkflowExpression<string> actorModelModelmessage = null)
        {
            WorkflowExpression.Validate(requestId, nameof(requestId), required: true);
            WorkflowExpression.Validate(documentId, nameof(documentId), required: true);
            WorkflowExpression.Validate(actorId, nameof(actorId), required: true);
            WorkflowExpression.Validate(actorModelModelaction, nameof(actorModelModelaction), required: true);
            WorkflowExpression.Validate(actorModelModelfirstname, nameof(actorModelModelfirstname), required: true);
            WorkflowExpression.Validate(actorModelModellastname, nameof(actorModelModellastname), required: true);
            WorkflowExpression.Validate(actorModelModelemail, nameof(actorModelModelemail), required: true);
            WorkflowExpression.Validate(actorModelModelmobile, nameof(actorModelModelmobile), required: true);
            WorkflowExpression.Validate(actorModelModeldeadline, nameof(actorModelModeldeadline), required: true);
            WorkflowExpression.Validate(actorModelModellanguage, nameof(actorModelModellanguage), required: true);
            WorkflowExpression.Validate(actorModelModelvalidateRealIdentity, nameof(actorModelModelvalidateRealIdentity), required: true);
            WorkflowExpression.Validate(actorModelModelprefix, nameof(actorModelModelprefix), required: false);
            WorkflowExpression.Validate(actorModelModeldossierPersonId, nameof(actorModelModeldossierPersonId), required: false);
            WorkflowExpression.Validate(actorModelModelmessage, nameof(actorModelModelmessage), required: false);
            return new DeferredBodyAction<ExtendedSignerModel>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/requests/{0}/documents/{1}/Actors/{2}", ExpressionConverter.ConvertWithUrlEncoding(requestId, 1), ExpressionConverter.ConvertWithUrlEncoding(documentId, 1), ExpressionConverter.ConvertWithUrlEncoding(actorId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var actorModelModel = new JObject();
                var actorModelModelpropCount = 0;
                actorModelModelpropCount++;
                actorModelModel["action"] = ExpressionConverter.ConvertO(actorModelModelaction);
                actorModelModelpropCount++;
                actorModelModel["firstname"] = ExpressionConverter.ConvertO(actorModelModelfirstname);
                if (actorModelModelprefix != null)
                {
                    actorModelModel["prefix"] = ExpressionConverter.ConvertO(actorModelModelprefix);
                    actorModelModelpropCount++;
                }

                actorModelModelpropCount++;
                actorModelModel["lastname"] = ExpressionConverter.ConvertO(actorModelModellastname);
                actorModelModelpropCount++;
                actorModelModel["email"] = ExpressionConverter.ConvertO(actorModelModelemail);
                actorModelModelpropCount++;
                actorModelModel["mobile"] = ExpressionConverter.ConvertO(actorModelModelmobile);
                actorModelModelpropCount++;
                actorModelModel["deadline"] = ExpressionConverter.ConvertO(actorModelModeldeadline);
                actorModelModelpropCount++;
                actorModelModel["language"] = ExpressionConverter.ConvertO(actorModelModellanguage);
                actorModelModelpropCount++;
                actorModelModel["validateRealIdentity"] = ExpressionConverter.ConvertO(actorModelModelvalidateRealIdentity);
                if (actorModelModeldossierPersonId != null)
                {
                    actorModelModel["dossierPersonId"] = ExpressionConverter.ConvertO(actorModelModeldossierPersonId);
                    actorModelModelpropCount++;
                }

                if (actorModelModelmessage != null)
                {
                    actorModelModel["message"] = ExpressionConverter.ConvertO(actorModelModelmessage);
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
        [WorkflowExpressionFactory(nameof(__BuildActorsGet))]
        public IBodyWorkflowAction<ExtendedSignerModel> ActorsGet([WorkflowExpression] Func<string> requestId, [WorkflowExpression] Func<string> documentId, [WorkflowExpression] Func<string> actorId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ExtendedSignerModel> __BuildActorsGet(WorkflowExpression<string> requestId, WorkflowExpression<string> documentId, WorkflowExpression<string> actorId)
        {
            WorkflowExpression.Validate(requestId, nameof(requestId), required: true);
            WorkflowExpression.Validate(documentId, nameof(documentId), required: true);
            WorkflowExpression.Validate(actorId, nameof(actorId), required: true);
            return new DeferredBodyAction<ExtendedSignerModel>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/requests/{0}/documents/{1}/Actors/{2}", ExpressionConverter.ConvertWithUrlEncoding(requestId, 1), ExpressionConverter.ConvertWithUrlEncoding(documentId, 1), ExpressionConverter.ConvertWithUrlEncoding(actorId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ExtendedSignerModel>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pkisigning")]
        [WorkflowExpressionFactory(nameof(__BuildActorsDelete))]
        public IWorkflowAction ActorsDelete([WorkflowExpression] Func<string> requestId, [WorkflowExpression] Func<string> documentId, [WorkflowExpression] Func<string> actorId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildActorsDelete(WorkflowExpression<string> requestId, WorkflowExpression<string> documentId, WorkflowExpression<string> actorId)
        {
            WorkflowExpression.Validate(requestId, nameof(requestId), required: true);
            WorkflowExpression.Validate(documentId, nameof(documentId), required: true);
            WorkflowExpression.Validate(actorId, nameof(actorId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/requests/{0}/documents/{1}/Actors/{2}", ExpressionConverter.ConvertWithUrlEncoding(requestId, 1), ExpressionConverter.ConvertWithUrlEncoding(documentId, 1), ExpressionConverter.ConvertWithUrlEncoding(actorId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pkisigning")]
        [WorkflowExpressionFactory(nameof(__BuildActorsRequestActors))]
        public IBodyWorkflowAction<ExtendedSignerModel[]> ActorsRequestActors([WorkflowExpression] Func<string> requestId, [WorkflowExpression] Func<bool> hasActed = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ExtendedSignerModel[]> __BuildActorsRequestActors(WorkflowExpression<string> requestId, WorkflowExpression<bool> hasActed = null)
        {
            WorkflowExpression.Validate(requestId, nameof(requestId), required: true);
            WorkflowExpression.Validate(hasActed, nameof(hasActed), required: false);
            return new DeferredBodyAction<ExtendedSignerModel[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/requests/{0}/Actors", ExpressionConverter.ConvertWithUrlEncoding(requestId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (hasActed != null)
                    callPayload.Queries["hasActed"] = ExpressionConverter.Convert(hasActed);
                return new ApiConnectionAction<ExtendedSignerModel[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pkisigning")]
        [WorkflowExpressionFactory(nameof(__BuildActorsResendCurrentInvite))]
        public IWorkflowAction ActorsResendCurrentInvite([WorkflowExpression] Func<string> requestId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildActorsResendCurrentInvite(WorkflowExpression<string> requestId)
        {
            WorkflowExpression.Validate(requestId, nameof(requestId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/requests/{0}/Actors/ResendCurrentInvite", ExpressionConverter.ConvertWithUrlEncoding(requestId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pkisigning")]
        [WorkflowExpressionFactory(nameof(__BuildActorsWithdrawCurrentInvite))]
        public IWorkflowAction ActorsWithdrawCurrentInvite([WorkflowExpression] Func<string> requestId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildActorsWithdrawCurrentInvite(WorkflowExpression<string> requestId)
        {
            WorkflowExpression.Validate(requestId, nameof(requestId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/requests/{0}/Actors/WithdrawCurrentInvite", ExpressionConverter.ConvertWithUrlEncoding(requestId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pkisigning")]
        [WorkflowExpressionFactory(nameof(__BuildDocumentsGet))]
        public IBodyWorkflowAction<DocumentMetaDataModel> DocumentsGet([WorkflowExpression] Func<string> requestId, [WorkflowExpression] Func<string> documentId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DocumentMetaDataModel> __BuildDocumentsGet(WorkflowExpression<string> requestId, WorkflowExpression<string> documentId)
        {
            WorkflowExpression.Validate(requestId, nameof(requestId), required: true);
            WorkflowExpression.Validate(documentId, nameof(documentId), required: true);
            return new DeferredBodyAction<DocumentMetaDataModel>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/requests/{0}/documents/{1}", ExpressionConverter.ConvertWithUrlEncoding(requestId, 1), ExpressionConverter.ConvertWithUrlEncoding(documentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<DocumentMetaDataModel>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pkisigning")]
        [WorkflowExpressionFactory(nameof(__BuildDocumentsUpdate))]
        public IBodyWorkflowAction<DocumentMetaDataModel> DocumentsUpdate([WorkflowExpression] Func<string> requestId, [WorkflowExpression] Func<string> documentId, [WorkflowExpression] Func<metadatadocumentTypeInput> metadatadocumentType, [WorkflowExpression] Func<string> metadataname = null, [WorkflowExpression] Func<string> metadatafilename = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DocumentMetaDataModel> __BuildDocumentsUpdate(WorkflowExpression<string> requestId, WorkflowExpression<string> documentId, WorkflowExpression<metadatadocumentTypeInput> metadatadocumentType, WorkflowExpression<string> metadataname = null, WorkflowExpression<string> metadatafilename = null)
        {
            WorkflowExpression.Validate(requestId, nameof(requestId), required: true);
            WorkflowExpression.Validate(documentId, nameof(documentId), required: true);
            WorkflowExpression.Validate(metadatadocumentType, nameof(metadatadocumentType), required: true);
            WorkflowExpression.Validate(metadataname, nameof(metadataname), required: false);
            WorkflowExpression.Validate(metadatafilename, nameof(metadatafilename), required: false);
            return new DeferredBodyAction<DocumentMetaDataModel>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/requests/{0}/documents/{1}", ExpressionConverter.ConvertWithUrlEncoding(requestId, 1), ExpressionConverter.ConvertWithUrlEncoding(documentId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var metadata = new JObject();
                var metadatapropCount = 0;
                if (metadataname != null)
                {
                    metadata["name"] = ExpressionConverter.ConvertO(metadataname);
                    metadatapropCount++;
                }

                if (metadatafilename != null)
                {
                    metadata["filename"] = ExpressionConverter.ConvertO(metadatafilename);
                    metadatapropCount++;
                }

                metadatapropCount++;
                metadata["documentType"] = ExpressionConverter.ConvertO(metadatadocumentType);
                if (metadatapropCount > 0)
                {
                    callPayload.Body = metadata;
                }

                return new ApiConnectionAction<DocumentMetaDataModel>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pkisigning")]
        [WorkflowExpressionFactory(nameof(__BuildDocumentsDelete))]
        public IWorkflowAction DocumentsDelete([WorkflowExpression] Func<string> requestId, [WorkflowExpression] Func<string> documentId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDocumentsDelete(WorkflowExpression<string> requestId, WorkflowExpression<string> documentId)
        {
            WorkflowExpression.Validate(requestId, nameof(requestId), required: true);
            WorkflowExpression.Validate(documentId, nameof(documentId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/requests/{0}/documents/{1}", ExpressionConverter.ConvertWithUrlEncoding(requestId, 1), ExpressionConverter.ConvertWithUrlEncoding(documentId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pkisigning")]
        [WorkflowExpressionFactory(nameof(__BuildOrganisationsGetWorkgroups))]
        public IBodyWorkflowAction<OrganisationWorkgroup[]> OrganisationsGetWorkgroups([WorkflowExpression] Func<string> organisationId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<OrganisationWorkgroup[]> __BuildOrganisationsGetWorkgroups(WorkflowExpression<string> organisationId)
        {
            WorkflowExpression.Validate(organisationId, nameof(organisationId), required: true);
            return new DeferredBodyAction<OrganisationWorkgroup[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/Organisations/{0}/workgroups", ExpressionConverter.ConvertWithUrlEncoding(organisationId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<OrganisationWorkgroup[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pkisigning")]
        [WorkflowExpressionFactory(nameof(__BuildOrganisationsGetWorkgroupsByUser))]
        public IBodyWorkflowAction<OrganisationWorkgroup[]> OrganisationsGetWorkgroupsByUser([WorkflowExpression] Func<string> organisationId, [WorkflowExpression] Func<string> modelusername)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<OrganisationWorkgroup[]> __BuildOrganisationsGetWorkgroupsByUser(WorkflowExpression<string> organisationId, WorkflowExpression<string> modelusername)
        {
            WorkflowExpression.Validate(organisationId, nameof(organisationId), required: true);
            WorkflowExpression.Validate(modelusername, nameof(modelusername), required: true);
            return new DeferredBodyAction<OrganisationWorkgroup[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/Organisations/{0}/workgroups", ExpressionConverter.ConvertWithUrlEncoding(organisationId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var model = new JObject();
                var modelpropCount = 0;
                modelpropCount++;
                model["username"] = ExpressionConverter.ConvertO(modelusername);
                if (modelpropCount > 0)
                {
                    callPayload.Body = model;
                }

                return new ApiConnectionAction<OrganisationWorkgroup[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pkisigning")]
        [WorkflowExpressionFactory(nameof(__BuildRequestsCreate))]
        public IBodyWorkflowAction<RequestModel> RequestsCreate([WorkflowExpression] Func<string> modelname, [WorkflowExpression] Func<int> modelclearancelevel, [WorkflowExpression] Func<string> modelworkgroupId = null, [WorkflowExpression] Func<string> modelowner = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<RequestModel> __BuildRequestsCreate(WorkflowExpression<string> modelname, WorkflowExpression<int> modelclearancelevel, WorkflowExpression<string> modelworkgroupId = null, WorkflowExpression<string> modelowner = null)
        {
            WorkflowExpression.Validate(modelname, nameof(modelname), required: true);
            WorkflowExpression.Validate(modelclearancelevel, nameof(modelclearancelevel), required: true);
            WorkflowExpression.Validate(modelworkgroupId, nameof(modelworkgroupId), required: false);
            WorkflowExpression.Validate(modelowner, nameof(modelowner), required: false);
            return new DeferredBodyAction<RequestModel>(() =>
            {
                var apiCallPath = "/requests";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var model = new JObject();
                var modelpropCount = 0;
                modelpropCount++;
                model["name"] = ExpressionConverter.ConvertO(modelname);
                if (modelworkgroupId != null)
                {
                    model["workgroupId"] = ExpressionConverter.ConvertO(modelworkgroupId);
                    modelpropCount++;
                }

                modelpropCount++;
                model["clearancelevel"] = ExpressionConverter.ConvertO(modelclearancelevel);
                if (modelowner != null)
                {
                    model["owner"] = ExpressionConverter.ConvertO(modelowner);
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
        [WorkflowExpressionFactory(nameof(__BuildRequestsGet))]
        public IBodyWorkflowAction<RequestModel> RequestsGet([WorkflowExpression] Func<string> requestId, [WorkflowExpression] Func<string> callbackAuthenticationKey = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<RequestModel> __BuildRequestsGet(WorkflowExpression<string> requestId, WorkflowExpression<string> callbackAuthenticationKey = null)
        {
            WorkflowExpression.Validate(requestId, nameof(requestId), required: true);
            WorkflowExpression.Validate(callbackAuthenticationKey, nameof(callbackAuthenticationKey), required: false);
            return new DeferredBodyAction<RequestModel>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/requests/{0}", ExpressionConverter.ConvertWithUrlEncoding(requestId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (callbackAuthenticationKey != null)
                    callPayload.Queries["callbackAuthenticationKey"] = ExpressionConverter.Convert(callbackAuthenticationKey);
                return new ApiConnectionAction<RequestModel>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pkisigning")]
        [WorkflowExpressionFactory(nameof(__BuildRequestsUpdate))]
        public IBodyWorkflowAction<RequestModel> RequestsUpdate([WorkflowExpression] Func<string> requestId, [WorkflowExpression] Func<string> modelname, [WorkflowExpression] Func<int> modelclearancelevel, [WorkflowExpression] Func<string> modelworkgroupId = null, [WorkflowExpression] Func<string> modelowner = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<RequestModel> __BuildRequestsUpdate(WorkflowExpression<string> requestId, WorkflowExpression<string> modelname, WorkflowExpression<int> modelclearancelevel, WorkflowExpression<string> modelworkgroupId = null, WorkflowExpression<string> modelowner = null)
        {
            WorkflowExpression.Validate(requestId, nameof(requestId), required: true);
            WorkflowExpression.Validate(modelname, nameof(modelname), required: true);
            WorkflowExpression.Validate(modelclearancelevel, nameof(modelclearancelevel), required: true);
            WorkflowExpression.Validate(modelworkgroupId, nameof(modelworkgroupId), required: false);
            WorkflowExpression.Validate(modelowner, nameof(modelowner), required: false);
            return new DeferredBodyAction<RequestModel>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/requests/{0}", ExpressionConverter.ConvertWithUrlEncoding(requestId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var model = new JObject();
                var modelpropCount = 0;
                modelpropCount++;
                model["name"] = ExpressionConverter.ConvertO(modelname);
                if (modelworkgroupId != null)
                {
                    model["workgroupId"] = ExpressionConverter.ConvertO(modelworkgroupId);
                    modelpropCount++;
                }

                modelpropCount++;
                model["clearancelevel"] = ExpressionConverter.ConvertO(modelclearancelevel);
                if (modelowner != null)
                {
                    model["owner"] = ExpressionConverter.ConvertO(modelowner);
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
        [WorkflowExpressionFactory(nameof(__BuildRequestsDelete))]
        public IWorkflowAction RequestsDelete([WorkflowExpression] Func<string> requestId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildRequestsDelete(WorkflowExpression<string> requestId)
        {
            WorkflowExpression.Validate(requestId, nameof(requestId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/requests/{0}", ExpressionConverter.ConvertWithUrlEncoding(requestId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pkisigning")]
        [WorkflowExpressionFactory(nameof(__BuildRequestsDownload))]
        public IBodyWorkflowAction<object> RequestsDownload([WorkflowExpression] Func<string> requestId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<object> __BuildRequestsDownload(WorkflowExpression<string> requestId)
        {
            WorkflowExpression.Validate(requestId, nameof(requestId), required: true);
            return new DeferredBodyAction<object>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/requests/{0}/Download", ExpressionConverter.ConvertWithUrlEncoding(requestId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<object>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pkisigning")]
        [WorkflowExpressionFactory(nameof(__BuildRequestsSend))]
        public IWorkflowAction RequestsSend([WorkflowExpression] Func<string> requestId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildRequestsSend(WorkflowExpression<string> requestId)
        {
            WorkflowExpression.Validate(requestId, nameof(requestId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/requests/{0}/Send", ExpressionConverter.ConvertWithUrlEncoding(requestId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class PkisigningTriggers([ConnectionName] string connectionId)
    {

        [WorkflowExpressionFactory(nameof(__BuildWebhooksCreateWebhook))]
        public IBodyWorkflowTrigger<WebhookResponseModel> WebhooksCreateWebhook([WorkflowExpression] Func<string[]> modelevents,[WorkflowExpression] Func<string> organisationId,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<WebhookResponseModel> __BuildWebhooksCreateWebhook(WorkflowExpression<string[]> modelevents,WorkflowExpression<string> organisationId,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(modelevents, nameof(modelevents), required: true);
            WorkflowExpression.Validate(organisationId, nameof(organisationId), required: true);
            return new DeferredBodyTrigger<WebhookResponseModel>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/organisations/{0}/webhooks", ExpressionConverter.ConvertWithUrlEncoding(organisationId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var model = new JObject();
                var modelpropCount = 0;
                modelpropCount++;
                model["Events"] = ExpressionConverter.ConvertO(modelevents);
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