//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Arandaservicemanagem
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ArandaservicemanagemActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "arandaservicemanagem")]
        public IBodyWorkflowAction<CreateCIResponse> CreateCI(Expression<Func<string>> bodyname, Expression<Func<int>> bodyprojectId, Expression<Func<int>> bodycategoryId, Expression<Func<int>> bodyresponsibleId, Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodyserial = null, Expression<Func<string>> bodyassetTag = null, Expression<Func<string>> bodylicenseNumber = null, Expression<Func<int>> bodymanufacturerId = null, Expression<Func<int>> bodybrandId = null, Expression<Func<int>> bodymodelId = null, Expression<Func<int>> bodyproviderId = null, Expression<Func<int>> bodyreasonId = null, Expression<Func<double>> bodyprice = null, Expression<Func<string>> bodyrfid = null, Expression<Func<string>> bodyacceptDate = null, Expression<Func<string>> bodycheckInDate = null, Expression<Func<string>> bodyresponsibilityDate = null, Expression<Func<string>> bodybarCode = null, Expression<Func<string>> bodyunitSize = null, Expression<Func<int>> bodyunitId = null, Expression<Func<int>> bodycostCenterId = null, Expression<Func<int>> bodyimpactId = null, Expression<Func<int>> bodyriskId = null, Expression<Func<int>> bodylocationId = null, Expression<Func<bodyadditionalFieldsInputItem[]>> bodyadditionalFields = null)
        {
            var apiCallPath = "/cmdb/ci";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["name"] = ExpressionConverter.ConvertO(bodyname);
            if (bodydescription != null)
            {
                body["description"] = ExpressionConverter.ConvertO(bodydescription);
                bodypropCount++;
            }

            if (bodyserial != null)
            {
                body["serial"] = ExpressionConverter.ConvertO(bodyserial);
                bodypropCount++;
            }

            if (bodyassetTag != null)
            {
                body["assetTag"] = ExpressionConverter.ConvertO(bodyassetTag);
                bodypropCount++;
            }

            bodypropCount++;
            body["projectId"] = ExpressionConverter.ConvertO(bodyprojectId);
            bodypropCount++;
            body["categoryId"] = ExpressionConverter.ConvertO(bodycategoryId);
            bodypropCount++;
            body["responsibleId"] = ExpressionConverter.ConvertO(bodyresponsibleId);
            if (bodylicenseNumber != null)
            {
                body["licenseNumber"] = ExpressionConverter.ConvertO(bodylicenseNumber);
                bodypropCount++;
            }

            if (bodymanufacturerId != null)
            {
                body["manufacturerId"] = ExpressionConverter.ConvertO(bodymanufacturerId);
                bodypropCount++;
            }

            if (bodybrandId != null)
            {
                body["brandId"] = ExpressionConverter.ConvertO(bodybrandId);
                bodypropCount++;
            }

            if (bodymodelId != null)
            {
                body["modelId"] = ExpressionConverter.ConvertO(bodymodelId);
                bodypropCount++;
            }

            if (bodyproviderId != null)
            {
                body["providerId"] = ExpressionConverter.ConvertO(bodyproviderId);
                bodypropCount++;
            }

            if (bodyreasonId != null)
            {
                body["reasonId"] = ExpressionConverter.ConvertO(bodyreasonId);
                bodypropCount++;
            }

            if (bodyprice != null)
            {
                body["price"] = ExpressionConverter.ConvertO(bodyprice);
                bodypropCount++;
            }

            if (bodyrfid != null)
            {
                body["rfid"] = ExpressionConverter.ConvertO(bodyrfid);
                bodypropCount++;
            }

            if (bodyacceptDate != null)
            {
                body["acceptDate"] = ExpressionConverter.ConvertO(bodyacceptDate);
                bodypropCount++;
            }

            if (bodycheckInDate != null)
            {
                body["checkInDate"] = ExpressionConverter.ConvertO(bodycheckInDate);
                bodypropCount++;
            }

            if (bodyresponsibilityDate != null)
            {
                body["responsibilityDate"] = ExpressionConverter.ConvertO(bodyresponsibilityDate);
                bodypropCount++;
            }

            if (bodybarCode != null)
            {
                body["barCode"] = ExpressionConverter.ConvertO(bodybarCode);
                bodypropCount++;
            }

            if (bodyunitSize != null)
            {
                body["unitSize"] = ExpressionConverter.ConvertO(bodyunitSize);
                bodypropCount++;
            }

            if (bodyunitId != null)
            {
                body["unitId"] = ExpressionConverter.ConvertO(bodyunitId);
                bodypropCount++;
            }

            if (bodycostCenterId != null)
            {
                body["costCenterId"] = ExpressionConverter.ConvertO(bodycostCenterId);
                bodypropCount++;
            }

            if (bodyimpactId != null)
            {
                body["impactId"] = ExpressionConverter.ConvertO(bodyimpactId);
                bodypropCount++;
            }

            if (bodyriskId != null)
            {
                body["riskId"] = ExpressionConverter.ConvertO(bodyriskId);
                bodypropCount++;
            }

            if (bodylocationId != null)
            {
                body["locationId"] = ExpressionConverter.ConvertO(bodylocationId);
                bodypropCount++;
            }

            if (bodyadditionalFields != null)
            {
                body["additionalFields"] = ExpressionConverter.ConvertO(bodyadditionalFields);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<CreateCIResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "arandaservicemanagem")]
        public IBodyWorkflowAction<SearchCIsResponseItem[]> SearchCIs(Expression<Func<requestBodyspecifiesTheRelationBetweenSearchCriteriaInput>> requestBodyspecifiesTheRelationBetweenSearchCriteria, Expression<Func<requestBodyfiltersInputItem[]>> requestBodyfilters = null)
        {
            var apiCallPath = "/cmdb/ci/list";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var requestBody = new JObject();
            var requestBodypropCount = 0;
            requestBodypropCount++;
            requestBody["logicOperator"] = ExpressionConverter.ConvertO(requestBodyspecifiesTheRelationBetweenSearchCriteria);
            if (requestBodyfilters != null)
            {
                requestBody["filters"] = ExpressionConverter.ConvertO(requestBodyfilters);
                requestBodypropCount++;
            }

            if (requestBodypropCount > 0)
            {
                callPayload.Body = requestBody;
            }

            return new ApiConnectionAction<SearchCIsResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "arandaservicemanagem")]
        public IBodyWorkflowAction<GetCIResponse> GetCI(Expression<Func<string>> request)
        {
            var apiCallPath = String.Format("/cmdb/ci/{0}", ExpressionConverter.ConvertWithUrlEncoding(request, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetCIResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "arandaservicemanagem")]
        public IBodyWorkflowAction<UpdateCIResponse> UpdateCI(Expression<Func<string>> request, Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodyserial = null, Expression<Func<string>> bodyassetTag = null, Expression<Func<int>> bodycategoryId = null, Expression<Func<int>> bodyresponsibleId = null, Expression<Func<int>> bodystateId = null, Expression<Func<string>> bodylicenseNumber = null, Expression<Func<int>> bodymanufacturerId = null, Expression<Func<int>> bodybrandId = null, Expression<Func<int>> bodymodelId = null, Expression<Func<int>> bodyproviderId = null, Expression<Func<int>> bodyreasonId = null, Expression<Func<double>> bodyprice = null, Expression<Func<string>> bodyrfid = null, Expression<Func<string>> bodyacceptDate = null, Expression<Func<string>> bodycheckInDate = null, Expression<Func<string>> bodyresponsibilityDate = null, Expression<Func<string>> bodybarCode = null, Expression<Func<string>> bodyunitSize = null, Expression<Func<int>> bodyunitId = null, Expression<Func<int>> bodycostCenterId = null, Expression<Func<int>> bodyimpactId = null, Expression<Func<int>> bodyriskId = null, Expression<Func<int>> bodylocationId = null, Expression<Func<bodyadditionalFieldsInputItem[]>> bodyadditionalFields = null)
        {
            var apiCallPath = String.Format("/cmdb/ci/{0}", ExpressionConverter.ConvertWithUrlEncoding(request, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodydescription != null)
            {
                body["description"] = ExpressionConverter.ConvertO(bodydescription);
                bodypropCount++;
            }

            if (bodyserial != null)
            {
                body["serial"] = ExpressionConverter.ConvertO(bodyserial);
                bodypropCount++;
            }

            if (bodyassetTag != null)
            {
                body["assetTag"] = ExpressionConverter.ConvertO(bodyassetTag);
                bodypropCount++;
            }

            if (bodycategoryId != null)
            {
                body["categoryId"] = ExpressionConverter.ConvertO(bodycategoryId);
                bodypropCount++;
            }

            if (bodyresponsibleId != null)
            {
                body["responsibleId"] = ExpressionConverter.ConvertO(bodyresponsibleId);
                bodypropCount++;
            }

            if (bodystateId != null)
            {
                body["stateId"] = ExpressionConverter.ConvertO(bodystateId);
                bodypropCount++;
            }

            if (bodylicenseNumber != null)
            {
                body["licenseNumber"] = ExpressionConverter.ConvertO(bodylicenseNumber);
                bodypropCount++;
            }

            if (bodymanufacturerId != null)
            {
                body["manufacturerId"] = ExpressionConverter.ConvertO(bodymanufacturerId);
                bodypropCount++;
            }

            if (bodybrandId != null)
            {
                body["brandId"] = ExpressionConverter.ConvertO(bodybrandId);
                bodypropCount++;
            }

            if (bodymodelId != null)
            {
                body["modelId"] = ExpressionConverter.ConvertO(bodymodelId);
                bodypropCount++;
            }

            if (bodyproviderId != null)
            {
                body["providerId"] = ExpressionConverter.ConvertO(bodyproviderId);
                bodypropCount++;
            }

            if (bodyreasonId != null)
            {
                body["reasonId"] = ExpressionConverter.ConvertO(bodyreasonId);
                bodypropCount++;
            }

            if (bodyprice != null)
            {
                body["price"] = ExpressionConverter.ConvertO(bodyprice);
                bodypropCount++;
            }

            if (bodyrfid != null)
            {
                body["rfid"] = ExpressionConverter.ConvertO(bodyrfid);
                bodypropCount++;
            }

            if (bodyacceptDate != null)
            {
                body["acceptDate"] = ExpressionConverter.ConvertO(bodyacceptDate);
                bodypropCount++;
            }

            if (bodycheckInDate != null)
            {
                body["checkInDate"] = ExpressionConverter.ConvertO(bodycheckInDate);
                bodypropCount++;
            }

            if (bodyresponsibilityDate != null)
            {
                body["responsibilityDate"] = ExpressionConverter.ConvertO(bodyresponsibilityDate);
                bodypropCount++;
            }

            if (bodybarCode != null)
            {
                body["barCode"] = ExpressionConverter.ConvertO(bodybarCode);
                bodypropCount++;
            }

            if (bodyunitSize != null)
            {
                body["unitSize"] = ExpressionConverter.ConvertO(bodyunitSize);
                bodypropCount++;
            }

            if (bodyunitId != null)
            {
                body["unitId"] = ExpressionConverter.ConvertO(bodyunitId);
                bodypropCount++;
            }

            if (bodycostCenterId != null)
            {
                body["costCenterId"] = ExpressionConverter.ConvertO(bodycostCenterId);
                bodypropCount++;
            }

            if (bodyimpactId != null)
            {
                body["impactId"] = ExpressionConverter.ConvertO(bodyimpactId);
                bodypropCount++;
            }

            if (bodyriskId != null)
            {
                body["riskId"] = ExpressionConverter.ConvertO(bodyriskId);
                bodypropCount++;
            }

            if (bodylocationId != null)
            {
                body["locationId"] = ExpressionConverter.ConvertO(bodylocationId);
                bodypropCount++;
            }

            if (bodyadditionalFields != null)
            {
                body["additionalFields"] = ExpressionConverter.ConvertO(bodyadditionalFields);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<UpdateCIResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "arandaservicemanagem")]
        public IBodyWorkflowAction<CreateCaseResponse> CreateCase(Expression<Func<string>> requestBodysubject, Expression<Func<string>> requestBodycaseType, Expression<Func<int>> requestBodyproject, Expression<Func<int>> requestBodyservice, Expression<Func<int>> requestBodycategory, Expression<Func<string>> requestBodydescription = null, Expression<Func<int>> requestBodyreason = null, Expression<Func<int>> requestBodygroup = null, Expression<Func<int>> requestBodyresponsibleId = null, Expression<Func<int>> requestBodycompany = null, Expression<Func<int>> requestBodyproviderId = null, Expression<Func<int>> requestBodyunitId = null, Expression<Func<int>> requestBodyapplicantId = null, Expression<Func<int>> requestBodycustomerId = null, Expression<Func<int>> requestBodyciId = null, Expression<Func<int>> requestBodyregistryTypeId = null, Expression<Func<int>> requestBodyurgencyId = null, Expression<Func<int>> requestBodyimpactId = null, Expression<Func<requestBodyadditionalFieldsInputItem[]>> requestBodyadditionalFields = null)
        {
            var apiCallPath = "/asms/case";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var requestBody = new JObject();
            var requestBodypropCount = 0;
            requestBodypropCount++;
            requestBody["subject"] = ExpressionConverter.ConvertO(requestBodysubject);
            if (requestBodydescription != null)
            {
                requestBody["description"] = ExpressionConverter.ConvertO(requestBodydescription);
                requestBodypropCount++;
            }

            requestBodypropCount++;
            requestBody["itemType"] = ExpressionConverter.ConvertO(requestBodycaseType);
            requestBodypropCount++;
            requestBody["projectId"] = ExpressionConverter.ConvertO(requestBodyproject);
            requestBodypropCount++;
            requestBody["serviceId"] = ExpressionConverter.ConvertO(requestBodyservice);
            requestBodypropCount++;
            requestBody["categoryId"] = ExpressionConverter.ConvertO(requestBodycategory);
            if (requestBodyreason != null)
            {
                requestBody["reasonId"] = ExpressionConverter.ConvertO(requestBodyreason);
                requestBodypropCount++;
            }

            if (requestBodygroup != null)
            {
                requestBody["groupId"] = ExpressionConverter.ConvertO(requestBodygroup);
                requestBodypropCount++;
            }

            if (requestBodyresponsibleId != null)
            {
                requestBody["responsibleId"] = ExpressionConverter.ConvertO(requestBodyresponsibleId);
                requestBodypropCount++;
            }

            if (requestBodycompany != null)
            {
                requestBody["companyId"] = ExpressionConverter.ConvertO(requestBodycompany);
                requestBodypropCount++;
            }

            if (requestBodyproviderId != null)
            {
                requestBody["providerId"] = ExpressionConverter.ConvertO(requestBodyproviderId);
                requestBodypropCount++;
            }

            if (requestBodyunitId != null)
            {
                requestBody["unitId"] = ExpressionConverter.ConvertO(requestBodyunitId);
                requestBodypropCount++;
            }

            if (requestBodyapplicantId != null)
            {
                requestBody["applicantId"] = ExpressionConverter.ConvertO(requestBodyapplicantId);
                requestBodypropCount++;
            }

            if (requestBodycustomerId != null)
            {
                requestBody["customerId"] = ExpressionConverter.ConvertO(requestBodycustomerId);
                requestBodypropCount++;
            }

            if (requestBodyciId != null)
            {
                requestBody["ciId"] = ExpressionConverter.ConvertO(requestBodyciId);
                requestBodypropCount++;
            }

            if (requestBodyregistryTypeId != null)
            {
                requestBody["registryTypeId"] = ExpressionConverter.ConvertO(requestBodyregistryTypeId);
                requestBodypropCount++;
            }

            if (requestBodyurgencyId != null)
            {
                requestBody["urgencyId"] = ExpressionConverter.ConvertO(requestBodyurgencyId);
                requestBodypropCount++;
            }

            if (requestBodyimpactId != null)
            {
                requestBody["impactId"] = ExpressionConverter.ConvertO(requestBodyimpactId);
                requestBodypropCount++;
            }

            if (requestBodyadditionalFields != null)
            {
                requestBody["additionalFields"] = ExpressionConverter.ConvertO(requestBodyadditionalFields);
                requestBodypropCount++;
            }

            if (requestBodypropCount > 0)
            {
                callPayload.Body = requestBody;
            }

            return new ApiConnectionAction<CreateCaseResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "arandaservicemanagem")]
        public IBodyWorkflowAction<SearchTicketsResponseItem[]> SearchTickets(Expression<Func<requestBodyspecifiesTheRelationBetweenSearchCriteriaInput>> requestBodyspecifiesTheRelationBetweenSearchCriteria, Expression<Func<requestBodyfiltersInputItem2[]>> requestBodyfilters = null)
        {
            var apiCallPath = "/asms/case/list";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var requestBody = new JObject();
            var requestBodypropCount = 0;
            requestBodypropCount++;
            requestBody["logicOperator"] = ExpressionConverter.ConvertO(requestBodyspecifiesTheRelationBetweenSearchCriteria);
            if (requestBodyfilters != null)
            {
                requestBody["filters"] = ExpressionConverter.ConvertO(requestBodyfilters);
                requestBodypropCount++;
            }

            if (requestBodypropCount > 0)
            {
                callPayload.Body = requestBody;
            }

            return new ApiConnectionAction<SearchTicketsResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "arandaservicemanagem")]
        public IBodyWorkflowAction<GetCaseResponse> GetCase(Expression<Func<string>> ticketId)
        {
            var apiCallPath = String.Format("/asms/case/{0}", ExpressionConverter.ConvertWithUrlEncoding(ticketId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetCaseResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "arandaservicemanagem")]
        public IBodyWorkflowAction<UpdateCaseResponse> UpdateCase(Expression<Func<string>> ticketId, Expression<Func<string>> requestBodysubject = null, Expression<Func<string>> requestBodydescription = null, Expression<Func<string>> requestBodycommentary = null, Expression<Func<int>> requestBodyserviceId = null, Expression<Func<int>> requestBodycategoryId = null, Expression<Func<int>> requestBodystateId = null, Expression<Func<int>> requestBodyreasonId = null, Expression<Func<int>> requestBodygroupId = null, Expression<Func<int>> requestBodyresponsibleId = null, Expression<Func<int>> requestBodyapplicantId = null, Expression<Func<int>> requestBodycustomerId = null, Expression<Func<int>> requestBodycompanyId = null, Expression<Func<int>> requestBodyciId = null, Expression<Func<int>> requestBodyproviderId = null, Expression<Func<int>> requestBodyunitId = null, Expression<Func<int>> requestBodyregistryTypeId = null, Expression<Func<int>> requestBodyurgencyId = null, Expression<Func<int>> requestBodyimpactId = null, Expression<Func<string>> requestBodyinterfaceId = null, Expression<Func<requestBodyadditionalFieldsInputItem[]>> requestBodyadditionalFields = null)
        {
            var apiCallPath = String.Format("/asms/case/{0}", ExpressionConverter.ConvertWithUrlEncoding(ticketId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var requestBody = new JObject();
            var requestBodypropCount = 0;
            if (requestBodysubject != null)
            {
                requestBody["subject"] = ExpressionConverter.ConvertO(requestBodysubject);
                requestBodypropCount++;
            }

            if (requestBodydescription != null)
            {
                requestBody["description"] = ExpressionConverter.ConvertO(requestBodydescription);
                requestBodypropCount++;
            }

            if (requestBodycommentary != null)
            {
                requestBody["commentary"] = ExpressionConverter.ConvertO(requestBodycommentary);
                requestBodypropCount++;
            }

            if (requestBodyserviceId != null)
            {
                requestBody["serviceId"] = ExpressionConverter.ConvertO(requestBodyserviceId);
                requestBodypropCount++;
            }

            if (requestBodycategoryId != null)
            {
                requestBody["categoryId"] = ExpressionConverter.ConvertO(requestBodycategoryId);
                requestBodypropCount++;
            }

            if (requestBodystateId != null)
            {
                requestBody["stateId"] = ExpressionConverter.ConvertO(requestBodystateId);
                requestBodypropCount++;
            }

            if (requestBodyreasonId != null)
            {
                requestBody["reasonId"] = ExpressionConverter.ConvertO(requestBodyreasonId);
                requestBodypropCount++;
            }

            if (requestBodygroupId != null)
            {
                requestBody["groupId"] = ExpressionConverter.ConvertO(requestBodygroupId);
                requestBodypropCount++;
            }

            if (requestBodyresponsibleId != null)
            {
                requestBody["responsibleId"] = ExpressionConverter.ConvertO(requestBodyresponsibleId);
                requestBodypropCount++;
            }

            if (requestBodyapplicantId != null)
            {
                requestBody["applicantId"] = ExpressionConverter.ConvertO(requestBodyapplicantId);
                requestBodypropCount++;
            }

            if (requestBodycustomerId != null)
            {
                requestBody["customerId"] = ExpressionConverter.ConvertO(requestBodycustomerId);
                requestBodypropCount++;
            }

            if (requestBodycompanyId != null)
            {
                requestBody["companyId"] = ExpressionConverter.ConvertO(requestBodycompanyId);
                requestBodypropCount++;
            }

            if (requestBodyciId != null)
            {
                requestBody["ciId"] = ExpressionConverter.ConvertO(requestBodyciId);
                requestBodypropCount++;
            }

            if (requestBodyproviderId != null)
            {
                requestBody["providerId"] = ExpressionConverter.ConvertO(requestBodyproviderId);
                requestBodypropCount++;
            }

            if (requestBodyunitId != null)
            {
                requestBody["unitId"] = ExpressionConverter.ConvertO(requestBodyunitId);
                requestBodypropCount++;
            }

            if (requestBodyregistryTypeId != null)
            {
                requestBody["registryTypeId"] = ExpressionConverter.ConvertO(requestBodyregistryTypeId);
                requestBodypropCount++;
            }

            if (requestBodyurgencyId != null)
            {
                requestBody["urgencyId"] = ExpressionConverter.ConvertO(requestBodyurgencyId);
                requestBodypropCount++;
            }

            if (requestBodyimpactId != null)
            {
                requestBody["impactId"] = ExpressionConverter.ConvertO(requestBodyimpactId);
                requestBodypropCount++;
            }

            if (requestBodyinterfaceId != null)
            {
                requestBody["interfaceId"] = ExpressionConverter.ConvertO(requestBodyinterfaceId);
                requestBodypropCount++;
            }

            if (requestBodyadditionalFields != null)
            {
                requestBody["additionalFields"] = ExpressionConverter.ConvertO(requestBodyadditionalFields);
                requestBodypropCount++;
            }

            if (requestBodypropCount > 0)
            {
                callPayload.Body = requestBody;
            }

            return new ApiConnectionAction<UpdateCaseResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "arandaservicemanagem")]
        public IBodyWorkflowAction<CaseHistoryResponseItem[]> CaseHistory(Expression<Func<string>> ticketId, Expression<Func<addNoteInput>> addNote = null)
        {
            var apiCallPath = String.Format("/asms/case/{0}/history", ExpressionConverter.ConvertWithUrlEncoding(ticketId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (addNote != null)
                callPayload.Queries["addNote"] = ExpressionConverter.Convert(addNote);
            return new ApiConnectionAction<CaseHistoryResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "arandaservicemanagem")]
        public IWorkflowAction AttachFile(Expression<Func<string>> ticketId, Expression<Func<string>> bodyfile, Expression<Func<string>> bodyfileName)
        {
            var apiCallPath = String.Format("/asms/case/{0}/file", ExpressionConverter.ConvertWithUrlEncoding(ticketId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["file"] = ExpressionConverter.ConvertO(bodyfile);
            bodypropCount++;
            body["fileName"] = ExpressionConverter.ConvertO(bodyfileName);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "arandaservicemanagem")]
        public IBodyWorkflowAction<string> DownloadCaseFile(Expression<Func<string>> ticketId, Expression<Func<int>> fileId)
        {
            var apiCallPath = String.Format("/asms/case/{0}/file/{1}", ExpressionConverter.ConvertWithUrlEncoding(ticketId, 1), ExpressionConverter.ConvertWithUrlEncoding(fileId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "arandaservicemanagem")]
        public IWorkflowAction AttachNote(Expression<Func<string>> ticketId, Expression<Func<string>> message)
        {
            var apiCallPath = String.Format("/asms/case/{0}/note", ExpressionConverter.ConvertWithUrlEncoding(ticketId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["message"] = ExpressionConverter.Convert(message);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "arandaservicemanagem")]
        public IBodyWorkflowAction<GetArticleResponseItem[]> GetArticle(Expression<Func<int>> requestBodyprojectId, Expression<Func<string>> requestBodysearch, Expression<Func<int>> requestBodycategoryID = null, Expression<Func<int>> requestBodytypeId = null)
        {
            var apiCallPath = "/kb/article/list";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var requestBody = new JObject();
            var requestBodypropCount = 0;
            requestBodypropCount++;
            requestBody["projectId"] = ExpressionConverter.ConvertO(requestBodyprojectId);
            requestBodypropCount++;
            requestBody["search"] = ExpressionConverter.ConvertO(requestBodysearch);
            if (requestBodycategoryID != null)
            {
                requestBody["folderId"] = ExpressionConverter.ConvertO(requestBodycategoryID);
                requestBodypropCount++;
            }

            if (requestBodytypeId != null)
            {
                requestBody["typeId"] = ExpressionConverter.ConvertO(requestBodytypeId);
                requestBodypropCount++;
            }

            if (requestBodypropCount > 0)
            {
                callPayload.Body = requestBody;
            }

            return new ApiConnectionAction<GetArticleResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "arandaservicemanagem")]
        public IBodyWorkflowAction<string> DownloadArticleFile(Expression<Func<int>> articleId, Expression<Func<int>> fileId)
        {
            var apiCallPath = String.Format("/kb/article/{0}/file/{1}", ExpressionConverter.ConvertWithUrlEncoding(articleId, 1), ExpressionConverter.ConvertWithUrlEncoding(fileId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string>(callPayload);
        }
    }

    public class ArandaservicemanagemTriggers([ConnectionName] string connectionId)
    {
    }

    public class CreateCIResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }
    }

    public class bodyadditionalFieldsInputItem
    {
        [JsonProperty("fieldId")]
        public string FieldId { get; set; }

        [JsonProperty("values")]
        public string[] Values { get; set; }
    }

    public class SearchCIsResponseItem
    {
        [JsonProperty("acceptDate")]
        public string AcceptDate { get; set; }

        [JsonProperty("assetTag")]
        public string AssetTag { get; set; }

        [JsonProperty("responsibleName")]
        public string ResponsibleName { get; set; }

        [JsonProperty("category")]
        public SearchCIsResponseItemCategoryType Category { get; set; }

        [JsonProperty("checkinDate")]
        public string CheckinDate { get; set; }

        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("impact")]
        public SearchCIsResponseItemImpactType Impact { get; set; }

        [JsonProperty("modifiedDate")]
        public string ModifiedDate { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("responsibilityDate")]
        public string ResponsibilityDate { get; set; }

        [JsonProperty("serial")]
        public string Serial { get; set; }

        [JsonProperty("state")]
        public SearchCIsResponseItemStateType State { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class SearchCIsResponseItemCategoryType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class SearchCIsResponseItemImpactType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class SearchCIsResponseItemStateType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public enum requestBodyspecifiesTheRelationBetweenSearchCriteriaInput
    {
        And,
        Or
    }

    public class requestBodyfiltersInputItem
    {
        [JsonProperty("field")]
        public requestBodyfiltersInputItemFieldType Field { get; set; }

        [JsonProperty("operator")]
        public requestBodyfiltersInputItemOperatorType Operator { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public enum requestBodyfiltersInputItemFieldType
    {
        Commentary,
        Description,
        Subject,
        ApplicantName,
        AuthorName,
        CategoryName,
        CiName,
        CompanyName,
        CustomerName,
        GroupName,
        ImpactName,
        ItemTypeName,
        ModelName,
        ModifierName,
        OlaName,
        PriorityName,
        ProjectName,
        ProviderName,
        ReasonName,
        RegistryTypeName,
        ResponsibleName,
        ServiceName,
        SlaName,
        StateName,
        UcName,
        UnitName,
        UrgencyName,
        ApplicantId,
        AuthorId,
        CategoryId,
        CiId,
        CompanyId,
        ConsoleType,
        CustomerId,
        GroupId,
        ImpactId,
        InterfaceId,
        ModelId,
        ModifierId,
        OlaId,
        PriorityId,
        ProjectId,
        ProviderId,
        ReasonId,
        RegistryTypeId,
        ResponsibleId,
        ServiceId,
        SlaId,
        StateId,
        UcId,
        UnitId,
        UrgencyId,
        OpenedDate
    }

    public enum requestBodyfiltersInputItemOperatorType
    {
        EqualTo,
        NotEqualTo,
        GreaterThan,
        GreaterThanOrEqualTo,
        LessThan,
        LessThanOrEqualTo,
        Like
    }

    public class GetCIResponse
    {
        [JsonProperty("additionalFields")]
        public GetCIResponseAdditionalFieldsTypeItem[] AdditionalFields { get; set; }

        [JsonProperty("assetTag")]
        public string AssetTag { get; set; }

        [JsonProperty("barCode")]
        public string BarCode { get; set; }

        [JsonProperty("brand")]
        public GetCIResponseBrandType Brand { get; set; }

        [JsonProperty("category")]
        public GetCIResponseCategoryType Category { get; set; }

        [JsonProperty("costCenter")]
        public GetCIResponseCostCenterType CostCenter { get; set; }

        [JsonProperty("acceptDate")]
        public string AcceptDate { get; set; }

        [JsonProperty("checkinDate")]
        public string CheckinDate { get; set; }

        [JsonProperty("responsibilityDate")]
        public string ResponsibilityDate { get; set; }

        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("modifiedDate")]
        public string ModifiedDate { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("impact")]
        public GetCIResponseImpactType Impact { get; set; }

        [JsonProperty("licenseNumber")]
        public string LicenseNumber { get; set; }

        [JsonProperty("manufacturer")]
        public GetCIResponseManufacturerType Manufacturer { get; set; }

        [JsonProperty("model")]
        public GetCIResponseModelType Model { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("projects")]
        public GetCIResponseProjectsTypeItem[] Projects { get; set; }

        [JsonProperty("provider")]
        public GetCIResponseProviderType Provider { get; set; }

        [JsonProperty("reason")]
        public GetCIResponseReasonType Reason { get; set; }

        [JsonProperty("responsible")]
        public GetCIResponseResponsibleType Responsible { get; set; }

        [JsonProperty("risk")]
        public GetCIResponseRiskType Risk { get; set; }

        [JsonProperty("rfid")]
        public string Rfid { get; set; }

        [JsonProperty("serial")]
        public string Serial { get; set; }

        [JsonProperty("state")]
        public GetCIResponseStateType State { get; set; }

        [JsonProperty("tempItemId")]
        public int TempItemId { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("unit")]
        public GetCIResponseUnitType Unit { get; set; }

        [JsonProperty("unitSize")]
        public string UnitSize { get; set; }

        [JsonProperty("usefulLife")]
        public int UsefulLife { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }
    }

    public class GetCIResponseAdditionalFieldsTypeItem
    {
        [JsonProperty("fieldId")]
        public int FieldId { get; set; }

        [JsonProperty("nameField")]
        public string NameField { get; set; }

        [JsonProperty("values")]
        public string[] Values { get; set; }

        [JsonProperty("valueDetails")]
        public GetCIResponseAdditionalFieldsTypeItemDetailsType Details { get; set; }
    }

    public class GetCIResponseAdditionalFieldsTypeItemDetailsType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class GetCIResponseBrandType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class GetCIResponseCategoryType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class GetCIResponseCostCenterType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class GetCIResponseImpactType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class GetCIResponseManufacturerType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class GetCIResponseModelType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class GetCIResponseProjectsTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }
    }

    public class GetCIResponseProviderType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class GetCIResponseReasonType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class GetCIResponseResponsibleType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class GetCIResponseRiskType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class GetCIResponseStateType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class GetCIResponseUnitType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class UpdateCIResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }
    }

    public class CreateCaseResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("idByProject")]
        public string IdByProject { get; set; }
    }

    public class requestBodyadditionalFieldsInputItem
    {
        [JsonProperty("fieldId")]
        public string FieldId { get; set; }

        [JsonProperty("values")]
        public string[] Values { get; set; }
    }

    public class SearchTicketsResponseItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("idByProject")]
        public string IdByProject { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("projectId")]
        public int ProjectId { get; set; }

        [JsonProperty("projectName")]
        public string ProjectName { get; set; }

        [JsonProperty("itemTypeName")]
        public string ItemTypeName { get; set; }

        [JsonProperty("itemTypeId")]
        public int ItemTypeId { get; set; }

        [JsonProperty("serviceId")]
        public int ServiceId { get; set; }

        [JsonProperty("serviceName")]
        public string ServiceName { get; set; }

        [JsonProperty("modelId")]
        public int ModelId { get; set; }

        [JsonProperty("modelName")]
        public string ModelName { get; set; }

        [JsonProperty("categoryId")]
        public int CategoryId { get; set; }

        [JsonProperty("categoryName")]
        public string CategoryName { get; set; }

        [JsonProperty("applicantId")]
        public int ApplicantId { get; set; }

        [JsonProperty("ciId")]
        public int CiId { get; set; }

        [JsonProperty("ciName")]
        public string CiName { get; set; }

        [JsonProperty("customerId")]
        public int CustomerId { get; set; }

        [JsonProperty("customerName")]
        public string CustomerName { get; set; }

        [JsonProperty("companyId")]
        public int CompanyId { get; set; }

        [JsonProperty("companyName")]
        public string CompanyName { get; set; }

        [JsonProperty("slaId")]
        public int SlaId { get; set; }

        [JsonProperty("slaName")]
        public string SlaName { get; set; }

        [JsonProperty("stateId")]
        public int StateId { get; set; }

        [JsonProperty("stateName")]
        public string StateName { get; set; }

        [JsonProperty("reasonId")]
        public int ReasonId { get; set; }

        [JsonProperty("reasonName")]
        public string ReasonName { get; set; }

        [JsonProperty("groupId")]
        public int GroupId { get; set; }

        [JsonProperty("groupName")]
        public string GroupName { get; set; }

        [JsonProperty("responsibleId")]
        public int ResponsibleId { get; set; }

        [JsonProperty("responsibleName")]
        public string ResponsibleName { get; set; }

        [JsonProperty("impactId")]
        public int ImpactId { get; set; }

        [JsonProperty("impactName")]
        public string ImpactName { get; set; }

        [JsonProperty("openedDate")]
        public string OpenedDate { get; set; }

        [JsonProperty("authorId")]
        public int AuthorId { get; set; }

        [JsonProperty("authorName")]
        public string AuthorName { get; set; }
    }

    public class requestBodyfiltersInputItem2
    {
        [JsonProperty("field")]
        public requestBodyfiltersInputItemFieldType Field { get; set; }

        [JsonProperty("operator")]
        public requestBodyfiltersInputItemOperatorType Operator { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class GetCaseResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("idByProject")]
        public string IdByProject { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("commentary")]
        public string Commentary { get; set; }

        [JsonProperty("projectId")]
        public int ProjectId { get; set; }

        [JsonProperty("projectName")]
        public string ProjectName { get; set; }

        [JsonProperty("itemTypeName")]
        public string ItemTypeName { get; set; }

        [JsonProperty("itemTypeId")]
        public int ItemTypeId { get; set; }

        [JsonProperty("serviceId")]
        public int ServiceId { get; set; }

        [JsonProperty("serviceName")]
        public string ServiceName { get; set; }

        [JsonProperty("modelId")]
        public int ModelId { get; set; }

        [JsonProperty("modelName")]
        public string ModelName { get; set; }

        [JsonProperty("categoryId")]
        public int CategoryId { get; set; }

        [JsonProperty("categoryName")]
        public string CategoryName { get; set; }

        [JsonProperty("applicantId")]
        public int ApplicantId { get; set; }

        [JsonProperty("customerId")]
        public int CustomerId { get; set; }

        [JsonProperty("customerName")]
        public string CustomerName { get; set; }

        [JsonProperty("companyId")]
        public int CompanyId { get; set; }

        [JsonProperty("companyName")]
        public string CompanyName { get; set; }

        [JsonProperty("ciId")]
        public int CiId { get; set; }

        [JsonProperty("ciName")]
        public string CiName { get; set; }

        [JsonProperty("slaId")]
        public int SlaId { get; set; }

        [JsonProperty("slaName")]
        public string SlaName { get; set; }

        [JsonProperty("stateId")]
        public int StateId { get; set; }

        [JsonProperty("stateName")]
        public string StateName { get; set; }

        [JsonProperty("reasonId")]
        public int ReasonId { get; set; }

        [JsonProperty("reasonName")]
        public string ReasonName { get; set; }

        [JsonProperty("groupId")]
        public int GroupId { get; set; }

        [JsonProperty("groupName")]
        public string GroupName { get; set; }

        [JsonProperty("responsibleId")]
        public int ResponsibleId { get; set; }

        [JsonProperty("responsibleName")]
        public string ResponsibleName { get; set; }

        [JsonProperty("registryTypeId")]
        public int RegistryTypeId { get; set; }

        [JsonProperty("registryTypeName")]
        public string RegistryTypeName { get; set; }

        [JsonProperty("impactId")]
        public int ImpactId { get; set; }

        [JsonProperty("impactName")]
        public string ImpactName { get; set; }

        [JsonProperty("urgencyId")]
        public int UrgencyId { get; set; }

        [JsonProperty("urgencyName")]
        public string UrgencyName { get; set; }

        [JsonProperty("priorityId")]
        public int PriorityId { get; set; }

        [JsonProperty("priorityName")]
        public string PriorityName { get; set; }

        [JsonProperty("riskId")]
        public int RiskId { get; set; }

        [JsonProperty("riskName")]
        public string RiskName { get; set; }

        [JsonProperty("providerId")]
        public int ProviderId { get; set; }

        [JsonProperty("providerName")]
        public string ProviderName { get; set; }

        [JsonProperty("ucId")]
        public int UcId { get; set; }

        [JsonProperty("ucName")]
        public string UcName { get; set; }

        [JsonProperty("unitId")]
        public int UnitId { get; set; }

        [JsonProperty("unitName")]
        public string UnitName { get; set; }

        [JsonProperty("olaId")]
        public int OlaId { get; set; }

        [JsonProperty("olaName")]
        public string OlaName { get; set; }

        [JsonProperty("openedDate")]
        public string OpenedDate { get; set; }

        [JsonProperty("closedDate")]
        public string ClosedDate { get; set; }

        [JsonProperty("finalDate")]
        public string FinalDate { get; set; }

        [JsonProperty("initialDate")]
        public string InitialDate { get; set; }

        [JsonProperty("cost")]
        public double Cost { get; set; }

        [JsonProperty("realCost")]
        public double RealCost { get; set; }

        [JsonProperty("estimatedCost")]
        public double EstimatedCost { get; set; }

        [JsonProperty("price")]
        public double Price { get; set; }

        [JsonProperty("interfaceId")]
        public string InterfaceId { get; set; }

        [JsonProperty("isClosed")]
        public bool IsClosed { get; set; }

        [JsonProperty("currentProgress")]
        public double CurrentProgress { get; set; }

        [JsonProperty("realDate")]
        public string RealDate { get; set; }

        [JsonProperty("estimatedDate")]
        public string EstimatedDate { get; set; }

        [JsonProperty("authorId")]
        public int AuthorId { get; set; }

        [JsonProperty("authorName")]
        public string AuthorName { get; set; }

        [JsonProperty("attachments")]
        public GetCaseResponseAttachmentsTypeItem[] Attachments { get; set; }

        [JsonProperty("additionalFields")]
        public GetCaseResponseAdditionalFieldsTypeItem[] AdditionalFields { get; set; }
    }

    public class GetCaseResponseAttachmentsTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class GetCaseResponseAdditionalFieldsTypeItem
    {
        [JsonProperty("fieldId")]
        public int FieldId { get; set; }

        [JsonProperty("nameField")]
        public string NameField { get; set; }

        [JsonProperty("values")]
        public string[] Values { get; set; }

        [JsonProperty("valueDetails")]
        public GetCaseResponseAdditionalFieldsTypeItemDetailsType Details { get; set; }
    }

    public class GetCaseResponseAdditionalFieldsTypeItemDetailsType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class UpdateCaseResponse
    {
        [JsonProperty("result")]
        public bool Result { get; set; }
    }

    public class CaseHistoryResponseItem
    {
        [JsonProperty("actionId")]
        public string ActionId { get; set; }

        [JsonProperty("actionName")]
        public string ActionName { get; set; }

        [JsonProperty("authorId")]
        public int AuthorId { get; set; }

        [JsonProperty("authorName")]
        public string AuthorName { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("fieldName")]
        public string FieldName { get; set; }

        [JsonProperty("newValue")]
        public string NewValue { get; set; }

        [JsonProperty("oldValue")]
        public string OldValue { get; set; }

        [JsonProperty("noteType")]
        public string NoteType { get; set; }

        [JsonProperty("relatedItemId")]
        public string RelatedItemId { get; set; }
    }

    public enum addNoteInput
    {
        None,
        Public,
        Private,
        All
    }

    public class GetArticleResponseItem
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("keyword")]
        public string Keyword { get; set; }

        [JsonProperty("identifier")]
        public string Identifier { get; set; }

        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("lastModifiedDate")]
        public string LastModifiedDate { get; set; }

        [JsonProperty("classId")]
        public int ClassId { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("type")]
        public GetArticleResponseItemTypeType Type { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("attachments")]
        public GetArticleResponseItemAttachmentsTypeItem[] Attachments { get; set; }
    }

    public class GetArticleResponseItemTypeType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class GetArticleResponseItemAttachmentsTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Arandaservicemanagem;

    public partial class WorkflowManagedActions
    {
        public ArandaservicemanagemActions Arandaservicemanagem(string connectionId) => new ArandaservicemanagemActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ArandaservicemanagemTriggers Arandaservicemanagem(string connectionId) => new ArandaservicemanagemTriggers(connectionId);
    }
}