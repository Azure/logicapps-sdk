//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Servicedeskpluscloud
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ServicedeskpluscloudActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "servicedeskpluscloud")]
        [WorkflowExpressionFactory(nameof(__BuildCreateRequest))]
        public IBodyWorkflowAction<CreateRequestResponse> CreateRequest([WorkflowExpression] Func<string> serviceDeskInstance, [WorkflowExpression] Func<string> bodyinputDatarequestsubject, [WorkflowExpression] Func<string> bodyinputDatarequesttemplatename = null, [WorkflowExpression] Func<string> bodyinputDatarequestrequestTypename = null, [WorkflowExpression] Func<string> bodyinputDatarequestrequestername = null, [WorkflowExpression] Func<string> bodyinputDatarequeststatusname = null, [WorkflowExpression] Func<string> bodyinputDatarequesttechnicianemailId = null, [WorkflowExpression] Func<string> bodyinputDatarequestsitename = null, [WorkflowExpression] Func<string> bodyinputDatarequestgroupname = null, [WorkflowExpression] Func<string> bodyinputDatarequestdescription = null, [WorkflowExpression] Func<string> bodyinputDatarequestpriorityname = null, [WorkflowExpression] Func<string> bodyinputDatarequesturgencyname = null, [WorkflowExpression] Func<string> bodyinputDatarequestimpactname = null, [WorkflowExpression] Func<string> bodyinputDatarequestmodename = null, [WorkflowExpression] Func<string> bodyinputDatarequestcategoryname = null, [WorkflowExpression] Func<string> bodyinputDatarequestsubcategoryname = null, [WorkflowExpression] Func<string> bodyinputDatarequestitemname = null, [WorkflowExpression] Func<bodyinputDatarequestassetsInputItem[]> bodyinputDatarequestassets = null, [WorkflowExpression] Func<string> bodyinputDatarequestudfFields = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateRequestResponse> __BuildCreateRequest(WorkflowExpression<string> serviceDeskInstance, WorkflowExpression<string> bodyinputDatarequestsubject, WorkflowExpression<string> bodyinputDatarequesttemplatename = null, WorkflowExpression<string> bodyinputDatarequestrequestTypename = null, WorkflowExpression<string> bodyinputDatarequestrequestername = null, WorkflowExpression<string> bodyinputDatarequeststatusname = null, WorkflowExpression<string> bodyinputDatarequesttechnicianemailId = null, WorkflowExpression<string> bodyinputDatarequestsitename = null, WorkflowExpression<string> bodyinputDatarequestgroupname = null, WorkflowExpression<string> bodyinputDatarequestdescription = null, WorkflowExpression<string> bodyinputDatarequestpriorityname = null, WorkflowExpression<string> bodyinputDatarequesturgencyname = null, WorkflowExpression<string> bodyinputDatarequestimpactname = null, WorkflowExpression<string> bodyinputDatarequestmodename = null, WorkflowExpression<string> bodyinputDatarequestcategoryname = null, WorkflowExpression<string> bodyinputDatarequestsubcategoryname = null, WorkflowExpression<string> bodyinputDatarequestitemname = null, WorkflowExpression<bodyinputDatarequestassetsInputItem[]> bodyinputDatarequestassets = null, WorkflowExpression<string> bodyinputDatarequestudfFields = null)
        {
            WorkflowExpression.Validate(serviceDeskInstance, nameof(serviceDeskInstance), required: true);
            WorkflowExpression.Validate(bodyinputDatarequestsubject, nameof(bodyinputDatarequestsubject), required: true);
            WorkflowExpression.Validate(bodyinputDatarequesttemplatename, nameof(bodyinputDatarequesttemplatename), required: false);
            WorkflowExpression.Validate(bodyinputDatarequestrequestTypename, nameof(bodyinputDatarequestrequestTypename), required: false);
            WorkflowExpression.Validate(bodyinputDatarequestrequestername, nameof(bodyinputDatarequestrequestername), required: false);
            WorkflowExpression.Validate(bodyinputDatarequeststatusname, nameof(bodyinputDatarequeststatusname), required: false);
            WorkflowExpression.Validate(bodyinputDatarequesttechnicianemailId, nameof(bodyinputDatarequesttechnicianemailId), required: false);
            WorkflowExpression.Validate(bodyinputDatarequestsitename, nameof(bodyinputDatarequestsitename), required: false);
            WorkflowExpression.Validate(bodyinputDatarequestgroupname, nameof(bodyinputDatarequestgroupname), required: false);
            WorkflowExpression.Validate(bodyinputDatarequestdescription, nameof(bodyinputDatarequestdescription), required: false);
            WorkflowExpression.Validate(bodyinputDatarequestpriorityname, nameof(bodyinputDatarequestpriorityname), required: false);
            WorkflowExpression.Validate(bodyinputDatarequesturgencyname, nameof(bodyinputDatarequesturgencyname), required: false);
            WorkflowExpression.Validate(bodyinputDatarequestimpactname, nameof(bodyinputDatarequestimpactname), required: false);
            WorkflowExpression.Validate(bodyinputDatarequestmodename, nameof(bodyinputDatarequestmodename), required: false);
            WorkflowExpression.Validate(bodyinputDatarequestcategoryname, nameof(bodyinputDatarequestcategoryname), required: false);
            WorkflowExpression.Validate(bodyinputDatarequestsubcategoryname, nameof(bodyinputDatarequestsubcategoryname), required: false);
            WorkflowExpression.Validate(bodyinputDatarequestitemname, nameof(bodyinputDatarequestitemname), required: false);
            WorkflowExpression.Validate(bodyinputDatarequestassets, nameof(bodyinputDatarequestassets), required: false);
            WorkflowExpression.Validate(bodyinputDatarequestudfFields, nameof(bodyinputDatarequestudfFields), required: false);
            return new DeferredBodyAction<CreateRequestResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/app/{0}/api/v3/requests", ExpressionConverter.ConvertWithUrlEncoding(serviceDeskInstance, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var inputDataObject = new JObject();
                var inputDataObjectpropCount = 0;
                var requestObject = new JObject();
                var requestObjectpropCount = 0;
                requestObjectpropCount++;
                requestObject["subject"] = ExpressionConverter.ConvertO(bodyinputDatarequestsubject);
                var templateObject = new JObject();
                var templateObjectpropCount = 0;
                if (bodyinputDatarequesttemplatename != null)
                {
                    templateObject["name"] = ExpressionConverter.ConvertO(bodyinputDatarequesttemplatename);
                    templateObjectpropCount++;
                }

                if (templateObjectpropCount > 0)
                {
                    requestObject["template"] = templateObject;
                    requestObjectpropCount++;
                }

                var requestTypeObject = new JObject();
                var requestTypeObjectpropCount = 0;
                if (bodyinputDatarequestrequestTypename != null)
                {
                    requestTypeObject["name"] = ExpressionConverter.ConvertO(bodyinputDatarequestrequestTypename);
                    requestTypeObjectpropCount++;
                }

                if (requestTypeObjectpropCount > 0)
                {
                    requestObject["request_type"] = requestTypeObject;
                    requestObjectpropCount++;
                }

                var requesterObject = new JObject();
                var requesterObjectpropCount = 0;
                if (bodyinputDatarequestrequestername != null)
                {
                    requesterObject["name"] = ExpressionConverter.ConvertO(bodyinputDatarequestrequestername);
                    requesterObjectpropCount++;
                }

                if (requesterObjectpropCount > 0)
                {
                    requestObject["requester"] = requesterObject;
                    requestObjectpropCount++;
                }

                var statusObject = new JObject();
                var statusObjectpropCount = 0;
                if (bodyinputDatarequeststatusname != null)
                {
                    statusObject["name"] = ExpressionConverter.ConvertO(bodyinputDatarequeststatusname);
                    statusObjectpropCount++;
                }

                if (statusObjectpropCount > 0)
                {
                    requestObject["status"] = statusObject;
                    requestObjectpropCount++;
                }

                var technicianObject = new JObject();
                var technicianObjectpropCount = 0;
                if (bodyinputDatarequesttechnicianemailId != null)
                {
                    technicianObject["email_id"] = ExpressionConverter.ConvertO(bodyinputDatarequesttechnicianemailId);
                    technicianObjectpropCount++;
                }

                if (technicianObjectpropCount > 0)
                {
                    requestObject["technician"] = technicianObject;
                    requestObjectpropCount++;
                }

                var siteObject = new JObject();
                var siteObjectpropCount = 0;
                if (bodyinputDatarequestsitename != null)
                {
                    siteObject["name"] = ExpressionConverter.ConvertO(bodyinputDatarequestsitename);
                    siteObjectpropCount++;
                }

                if (siteObjectpropCount > 0)
                {
                    requestObject["site"] = siteObject;
                    requestObjectpropCount++;
                }

                var groupObject = new JObject();
                var groupObjectpropCount = 0;
                if (bodyinputDatarequestgroupname != null)
                {
                    groupObject["name"] = ExpressionConverter.ConvertO(bodyinputDatarequestgroupname);
                    groupObjectpropCount++;
                }

                if (groupObjectpropCount > 0)
                {
                    requestObject["group"] = groupObject;
                    requestObjectpropCount++;
                }

                if (bodyinputDatarequestdescription != null)
                {
                    requestObject["description"] = ExpressionConverter.ConvertO(bodyinputDatarequestdescription);
                    requestObjectpropCount++;
                }

                var priorityObject = new JObject();
                var priorityObjectpropCount = 0;
                if (bodyinputDatarequestpriorityname != null)
                {
                    priorityObject["name"] = ExpressionConverter.ConvertO(bodyinputDatarequestpriorityname);
                    priorityObjectpropCount++;
                }

                if (priorityObjectpropCount > 0)
                {
                    requestObject["priority"] = priorityObject;
                    requestObjectpropCount++;
                }

                var urgencyObject = new JObject();
                var urgencyObjectpropCount = 0;
                if (bodyinputDatarequesturgencyname != null)
                {
                    urgencyObject["name"] = ExpressionConverter.ConvertO(bodyinputDatarequesturgencyname);
                    urgencyObjectpropCount++;
                }

                if (urgencyObjectpropCount > 0)
                {
                    requestObject["urgency"] = urgencyObject;
                    requestObjectpropCount++;
                }

                var impactObject = new JObject();
                var impactObjectpropCount = 0;
                if (bodyinputDatarequestimpactname != null)
                {
                    impactObject["name"] = ExpressionConverter.ConvertO(bodyinputDatarequestimpactname);
                    impactObjectpropCount++;
                }

                if (impactObjectpropCount > 0)
                {
                    requestObject["impact"] = impactObject;
                    requestObjectpropCount++;
                }

                var modeObject = new JObject();
                var modeObjectpropCount = 0;
                if (bodyinputDatarequestmodename != null)
                {
                    modeObject["name"] = ExpressionConverter.ConvertO(bodyinputDatarequestmodename);
                    modeObjectpropCount++;
                }

                if (modeObjectpropCount > 0)
                {
                    requestObject["mode"] = modeObject;
                    requestObjectpropCount++;
                }

                var categoryObject = new JObject();
                var categoryObjectpropCount = 0;
                if (bodyinputDatarequestcategoryname != null)
                {
                    categoryObject["name"] = ExpressionConverter.ConvertO(bodyinputDatarequestcategoryname);
                    categoryObjectpropCount++;
                }

                if (categoryObjectpropCount > 0)
                {
                    requestObject["category"] = categoryObject;
                    requestObjectpropCount++;
                }

                var subcategoryObject = new JObject();
                var subcategoryObjectpropCount = 0;
                if (bodyinputDatarequestsubcategoryname != null)
                {
                    subcategoryObject["name"] = ExpressionConverter.ConvertO(bodyinputDatarequestsubcategoryname);
                    subcategoryObjectpropCount++;
                }

                if (subcategoryObjectpropCount > 0)
                {
                    requestObject["subcategory"] = subcategoryObject;
                    requestObjectpropCount++;
                }

                var itemObject = new JObject();
                var itemObjectpropCount = 0;
                if (bodyinputDatarequestitemname != null)
                {
                    itemObject["name"] = ExpressionConverter.ConvertO(bodyinputDatarequestitemname);
                    itemObjectpropCount++;
                }

                if (itemObjectpropCount > 0)
                {
                    requestObject["item"] = itemObject;
                    requestObjectpropCount++;
                }

                if (bodyinputDatarequestassets != null)
                {
                    requestObject["assets"] = ExpressionConverter.ConvertO(bodyinputDatarequestassets);
                    requestObjectpropCount++;
                }

                if (bodyinputDatarequestudfFields != null)
                {
                    requestObject["udf_fields"] = ExpressionConverter.ConvertO(bodyinputDatarequestudfFields);
                    requestObjectpropCount++;
                }

                if (requestObjectpropCount > 0)
                {
                    inputDataObject["request"] = requestObject;
                    inputDataObjectpropCount++;
                }

                if (inputDataObjectpropCount > 0)
                {
                    body["input_data"] = inputDataObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateRequestResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "servicedeskpluscloud")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateRequest))]
        public IBodyWorkflowAction<UpdateRequestResponse> UpdateRequest([WorkflowExpression] Func<string> serviceDeskInstance, [WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodyinputDatarequestsubject = null, [WorkflowExpression] Func<string> bodyinputDatarequesttemplatename = null, [WorkflowExpression] Func<string> bodyinputDatarequestrequestTypename = null, [WorkflowExpression] Func<string> bodyinputDatarequestrequestername = null, [WorkflowExpression] Func<string> bodyinputDatarequeststatusname = null, [WorkflowExpression] Func<string> bodyinputDatarequesttechnicianemailId = null, [WorkflowExpression] Func<string> bodyinputDatarequestsitename = null, [WorkflowExpression] Func<string> bodyinputDatarequestgroupname = null, [WorkflowExpression] Func<string> bodyinputDatarequestdescription = null, [WorkflowExpression] Func<string> bodyinputDatarequestpriorityname = null, [WorkflowExpression] Func<string> bodyinputDatarequesturgencyname = null, [WorkflowExpression] Func<string> bodyinputDatarequestimpactname = null, [WorkflowExpression] Func<string> bodyinputDatarequestmodename = null, [WorkflowExpression] Func<string> bodyinputDatarequestcategoryname = null, [WorkflowExpression] Func<string> bodyinputDatarequestsubcategoryname = null, [WorkflowExpression] Func<string> bodyinputDatarequestitemname = null, [WorkflowExpression] Func<bodyinputDatarequestassetsInputItem[]> bodyinputDatarequestassets = null, [WorkflowExpression] Func<string> bodyinputDatarequestudfFields = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<UpdateRequestResponse> __BuildUpdateRequest(WorkflowExpression<string> serviceDeskInstance, WorkflowExpression<string> id, WorkflowExpression<string> bodyinputDatarequestsubject = null, WorkflowExpression<string> bodyinputDatarequesttemplatename = null, WorkflowExpression<string> bodyinputDatarequestrequestTypename = null, WorkflowExpression<string> bodyinputDatarequestrequestername = null, WorkflowExpression<string> bodyinputDatarequeststatusname = null, WorkflowExpression<string> bodyinputDatarequesttechnicianemailId = null, WorkflowExpression<string> bodyinputDatarequestsitename = null, WorkflowExpression<string> bodyinputDatarequestgroupname = null, WorkflowExpression<string> bodyinputDatarequestdescription = null, WorkflowExpression<string> bodyinputDatarequestpriorityname = null, WorkflowExpression<string> bodyinputDatarequesturgencyname = null, WorkflowExpression<string> bodyinputDatarequestimpactname = null, WorkflowExpression<string> bodyinputDatarequestmodename = null, WorkflowExpression<string> bodyinputDatarequestcategoryname = null, WorkflowExpression<string> bodyinputDatarequestsubcategoryname = null, WorkflowExpression<string> bodyinputDatarequestitemname = null, WorkflowExpression<bodyinputDatarequestassetsInputItem[]> bodyinputDatarequestassets = null, WorkflowExpression<string> bodyinputDatarequestudfFields = null)
        {
            WorkflowExpression.Validate(serviceDeskInstance, nameof(serviceDeskInstance), required: true);
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(bodyinputDatarequestsubject, nameof(bodyinputDatarequestsubject), required: false);
            WorkflowExpression.Validate(bodyinputDatarequesttemplatename, nameof(bodyinputDatarequesttemplatename), required: false);
            WorkflowExpression.Validate(bodyinputDatarequestrequestTypename, nameof(bodyinputDatarequestrequestTypename), required: false);
            WorkflowExpression.Validate(bodyinputDatarequestrequestername, nameof(bodyinputDatarequestrequestername), required: false);
            WorkflowExpression.Validate(bodyinputDatarequeststatusname, nameof(bodyinputDatarequeststatusname), required: false);
            WorkflowExpression.Validate(bodyinputDatarequesttechnicianemailId, nameof(bodyinputDatarequesttechnicianemailId), required: false);
            WorkflowExpression.Validate(bodyinputDatarequestsitename, nameof(bodyinputDatarequestsitename), required: false);
            WorkflowExpression.Validate(bodyinputDatarequestgroupname, nameof(bodyinputDatarequestgroupname), required: false);
            WorkflowExpression.Validate(bodyinputDatarequestdescription, nameof(bodyinputDatarequestdescription), required: false);
            WorkflowExpression.Validate(bodyinputDatarequestpriorityname, nameof(bodyinputDatarequestpriorityname), required: false);
            WorkflowExpression.Validate(bodyinputDatarequesturgencyname, nameof(bodyinputDatarequesturgencyname), required: false);
            WorkflowExpression.Validate(bodyinputDatarequestimpactname, nameof(bodyinputDatarequestimpactname), required: false);
            WorkflowExpression.Validate(bodyinputDatarequestmodename, nameof(bodyinputDatarequestmodename), required: false);
            WorkflowExpression.Validate(bodyinputDatarequestcategoryname, nameof(bodyinputDatarequestcategoryname), required: false);
            WorkflowExpression.Validate(bodyinputDatarequestsubcategoryname, nameof(bodyinputDatarequestsubcategoryname), required: false);
            WorkflowExpression.Validate(bodyinputDatarequestitemname, nameof(bodyinputDatarequestitemname), required: false);
            WorkflowExpression.Validate(bodyinputDatarequestassets, nameof(bodyinputDatarequestassets), required: false);
            WorkflowExpression.Validate(bodyinputDatarequestudfFields, nameof(bodyinputDatarequestudfFields), required: false);
            return new DeferredBodyAction<UpdateRequestResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/app/{0}/api/v3/requests/{1}", ExpressionConverter.ConvertWithUrlEncoding(serviceDeskInstance, 1), ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var inputDataObject = new JObject();
                var inputDataObjectpropCount = 0;
                var requestObject = new JObject();
                var requestObjectpropCount = 0;
                if (bodyinputDatarequestsubject != null)
                {
                    requestObject["subject"] = ExpressionConverter.ConvertO(bodyinputDatarequestsubject);
                    requestObjectpropCount++;
                }

                var templateObject = new JObject();
                var templateObjectpropCount = 0;
                if (bodyinputDatarequesttemplatename != null)
                {
                    templateObject["name"] = ExpressionConverter.ConvertO(bodyinputDatarequesttemplatename);
                    templateObjectpropCount++;
                }

                if (templateObjectpropCount > 0)
                {
                    requestObject["template"] = templateObject;
                    requestObjectpropCount++;
                }

                var requestTypeObject = new JObject();
                var requestTypeObjectpropCount = 0;
                if (bodyinputDatarequestrequestTypename != null)
                {
                    requestTypeObject["name"] = ExpressionConverter.ConvertO(bodyinputDatarequestrequestTypename);
                    requestTypeObjectpropCount++;
                }

                if (requestTypeObjectpropCount > 0)
                {
                    requestObject["request_type"] = requestTypeObject;
                    requestObjectpropCount++;
                }

                var requesterObject = new JObject();
                var requesterObjectpropCount = 0;
                if (bodyinputDatarequestrequestername != null)
                {
                    requesterObject["name"] = ExpressionConverter.ConvertO(bodyinputDatarequestrequestername);
                    requesterObjectpropCount++;
                }

                if (requesterObjectpropCount > 0)
                {
                    requestObject["requester"] = requesterObject;
                    requestObjectpropCount++;
                }

                var statusObject = new JObject();
                var statusObjectpropCount = 0;
                if (bodyinputDatarequeststatusname != null)
                {
                    statusObject["name"] = ExpressionConverter.ConvertO(bodyinputDatarequeststatusname);
                    statusObjectpropCount++;
                }

                if (statusObjectpropCount > 0)
                {
                    requestObject["status"] = statusObject;
                    requestObjectpropCount++;
                }

                var technicianObject = new JObject();
                var technicianObjectpropCount = 0;
                if (bodyinputDatarequesttechnicianemailId != null)
                {
                    technicianObject["email_id"] = ExpressionConverter.ConvertO(bodyinputDatarequesttechnicianemailId);
                    technicianObjectpropCount++;
                }

                if (technicianObjectpropCount > 0)
                {
                    requestObject["technician"] = technicianObject;
                    requestObjectpropCount++;
                }

                var siteObject = new JObject();
                var siteObjectpropCount = 0;
                if (bodyinputDatarequestsitename != null)
                {
                    siteObject["name"] = ExpressionConverter.ConvertO(bodyinputDatarequestsitename);
                    siteObjectpropCount++;
                }

                if (siteObjectpropCount > 0)
                {
                    requestObject["site"] = siteObject;
                    requestObjectpropCount++;
                }

                var groupObject = new JObject();
                var groupObjectpropCount = 0;
                if (bodyinputDatarequestgroupname != null)
                {
                    groupObject["name"] = ExpressionConverter.ConvertO(bodyinputDatarequestgroupname);
                    groupObjectpropCount++;
                }

                if (groupObjectpropCount > 0)
                {
                    requestObject["group"] = groupObject;
                    requestObjectpropCount++;
                }

                if (bodyinputDatarequestdescription != null)
                {
                    requestObject["description"] = ExpressionConverter.ConvertO(bodyinputDatarequestdescription);
                    requestObjectpropCount++;
                }

                var priorityObject = new JObject();
                var priorityObjectpropCount = 0;
                if (bodyinputDatarequestpriorityname != null)
                {
                    priorityObject["name"] = ExpressionConverter.ConvertO(bodyinputDatarequestpriorityname);
                    priorityObjectpropCount++;
                }

                if (priorityObjectpropCount > 0)
                {
                    requestObject["priority"] = priorityObject;
                    requestObjectpropCount++;
                }

                var urgencyObject = new JObject();
                var urgencyObjectpropCount = 0;
                if (bodyinputDatarequesturgencyname != null)
                {
                    urgencyObject["name"] = ExpressionConverter.ConvertO(bodyinputDatarequesturgencyname);
                    urgencyObjectpropCount++;
                }

                if (urgencyObjectpropCount > 0)
                {
                    requestObject["urgency"] = urgencyObject;
                    requestObjectpropCount++;
                }

                var impactObject = new JObject();
                var impactObjectpropCount = 0;
                if (bodyinputDatarequestimpactname != null)
                {
                    impactObject["name"] = ExpressionConverter.ConvertO(bodyinputDatarequestimpactname);
                    impactObjectpropCount++;
                }

                if (impactObjectpropCount > 0)
                {
                    requestObject["impact"] = impactObject;
                    requestObjectpropCount++;
                }

                var modeObject = new JObject();
                var modeObjectpropCount = 0;
                if (bodyinputDatarequestmodename != null)
                {
                    modeObject["name"] = ExpressionConverter.ConvertO(bodyinputDatarequestmodename);
                    modeObjectpropCount++;
                }

                if (modeObjectpropCount > 0)
                {
                    requestObject["mode"] = modeObject;
                    requestObjectpropCount++;
                }

                var categoryObject = new JObject();
                var categoryObjectpropCount = 0;
                if (bodyinputDatarequestcategoryname != null)
                {
                    categoryObject["name"] = ExpressionConverter.ConvertO(bodyinputDatarequestcategoryname);
                    categoryObjectpropCount++;
                }

                if (categoryObjectpropCount > 0)
                {
                    requestObject["category"] = categoryObject;
                    requestObjectpropCount++;
                }

                var subcategoryObject = new JObject();
                var subcategoryObjectpropCount = 0;
                if (bodyinputDatarequestsubcategoryname != null)
                {
                    subcategoryObject["name"] = ExpressionConverter.ConvertO(bodyinputDatarequestsubcategoryname);
                    subcategoryObjectpropCount++;
                }

                if (subcategoryObjectpropCount > 0)
                {
                    requestObject["subcategory"] = subcategoryObject;
                    requestObjectpropCount++;
                }

                var itemObject = new JObject();
                var itemObjectpropCount = 0;
                if (bodyinputDatarequestitemname != null)
                {
                    itemObject["name"] = ExpressionConverter.ConvertO(bodyinputDatarequestitemname);
                    itemObjectpropCount++;
                }

                if (itemObjectpropCount > 0)
                {
                    requestObject["item"] = itemObject;
                    requestObjectpropCount++;
                }

                if (bodyinputDatarequestassets != null)
                {
                    requestObject["assets"] = ExpressionConverter.ConvertO(bodyinputDatarequestassets);
                    requestObjectpropCount++;
                }

                if (bodyinputDatarequestudfFields != null)
                {
                    requestObject["udf_fields"] = ExpressionConverter.ConvertO(bodyinputDatarequestudfFields);
                    requestObjectpropCount++;
                }

                if (requestObjectpropCount > 0)
                {
                    inputDataObject["request"] = requestObject;
                    inputDataObjectpropCount++;
                }

                if (inputDataObjectpropCount > 0)
                {
                    body["input_data"] = inputDataObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<UpdateRequestResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "servicedeskpluscloud")]
        [WorkflowExpressionFactory(nameof(__BuildCreateChange))]
        public IBodyWorkflowAction<CreateChangeResponse> CreateChange([WorkflowExpression] Func<string> serviceDeskInstance, [WorkflowExpression] Func<string> bodyinputDatachangetitle, [WorkflowExpression] Func<string> bodyinputDatachangecomment = null, [WorkflowExpression] Func<string> bodyinputDatachangetemplatename = null, [WorkflowExpression] Func<string> bodyinputDatachangechangeRequestername = null, [WorkflowExpression] Func<string> bodyinputDatachangesitename = null, [WorkflowExpression] Func<string> bodyinputDatachangegroupname = null, [WorkflowExpression] Func<string> bodyinputDatachangedescription = null, [WorkflowExpression] Func<string> bodyinputDatachangechangeOwneremailId = null, [WorkflowExpression] Func<string> bodyinputDatachangechangeTypename = null, [WorkflowExpression] Func<string> bodyinputDatachangepriorityname = null, [WorkflowExpression] Func<string> bodyinputDatachangeurgencyname = null, [WorkflowExpression] Func<string> bodyinputDatachangeimpactname = null, [WorkflowExpression] Func<string> bodyinputDatachangeriskname = null, [WorkflowExpression] Func<string> bodyinputDatachangereasonForChangename = null, [WorkflowExpression] Func<string> bodyinputDatachangecategoryname = null, [WorkflowExpression] Func<string> bodyinputDatachangesubcategoryname = null, [WorkflowExpression] Func<string> bodyinputDatachangeitemname = null, [WorkflowExpression] Func<bodyinputDatachangeassetsInputItem[]> bodyinputDatachangeassets = null, [WorkflowExpression] Func<string> bodyinputDatachangeudfFields = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateChangeResponse> __BuildCreateChange(WorkflowExpression<string> serviceDeskInstance, WorkflowExpression<string> bodyinputDatachangetitle, WorkflowExpression<string> bodyinputDatachangecomment = null, WorkflowExpression<string> bodyinputDatachangetemplatename = null, WorkflowExpression<string> bodyinputDatachangechangeRequestername = null, WorkflowExpression<string> bodyinputDatachangesitename = null, WorkflowExpression<string> bodyinputDatachangegroupname = null, WorkflowExpression<string> bodyinputDatachangedescription = null, WorkflowExpression<string> bodyinputDatachangechangeOwneremailId = null, WorkflowExpression<string> bodyinputDatachangechangeTypename = null, WorkflowExpression<string> bodyinputDatachangepriorityname = null, WorkflowExpression<string> bodyinputDatachangeurgencyname = null, WorkflowExpression<string> bodyinputDatachangeimpactname = null, WorkflowExpression<string> bodyinputDatachangeriskname = null, WorkflowExpression<string> bodyinputDatachangereasonForChangename = null, WorkflowExpression<string> bodyinputDatachangecategoryname = null, WorkflowExpression<string> bodyinputDatachangesubcategoryname = null, WorkflowExpression<string> bodyinputDatachangeitemname = null, WorkflowExpression<bodyinputDatachangeassetsInputItem[]> bodyinputDatachangeassets = null, WorkflowExpression<string> bodyinputDatachangeudfFields = null)
        {
            WorkflowExpression.Validate(serviceDeskInstance, nameof(serviceDeskInstance), required: true);
            WorkflowExpression.Validate(bodyinputDatachangetitle, nameof(bodyinputDatachangetitle), required: true);
            WorkflowExpression.Validate(bodyinputDatachangecomment, nameof(bodyinputDatachangecomment), required: false);
            WorkflowExpression.Validate(bodyinputDatachangetemplatename, nameof(bodyinputDatachangetemplatename), required: false);
            WorkflowExpression.Validate(bodyinputDatachangechangeRequestername, nameof(bodyinputDatachangechangeRequestername), required: false);
            WorkflowExpression.Validate(bodyinputDatachangesitename, nameof(bodyinputDatachangesitename), required: false);
            WorkflowExpression.Validate(bodyinputDatachangegroupname, nameof(bodyinputDatachangegroupname), required: false);
            WorkflowExpression.Validate(bodyinputDatachangedescription, nameof(bodyinputDatachangedescription), required: false);
            WorkflowExpression.Validate(bodyinputDatachangechangeOwneremailId, nameof(bodyinputDatachangechangeOwneremailId), required: false);
            WorkflowExpression.Validate(bodyinputDatachangechangeTypename, nameof(bodyinputDatachangechangeTypename), required: false);
            WorkflowExpression.Validate(bodyinputDatachangepriorityname, nameof(bodyinputDatachangepriorityname), required: false);
            WorkflowExpression.Validate(bodyinputDatachangeurgencyname, nameof(bodyinputDatachangeurgencyname), required: false);
            WorkflowExpression.Validate(bodyinputDatachangeimpactname, nameof(bodyinputDatachangeimpactname), required: false);
            WorkflowExpression.Validate(bodyinputDatachangeriskname, nameof(bodyinputDatachangeriskname), required: false);
            WorkflowExpression.Validate(bodyinputDatachangereasonForChangename, nameof(bodyinputDatachangereasonForChangename), required: false);
            WorkflowExpression.Validate(bodyinputDatachangecategoryname, nameof(bodyinputDatachangecategoryname), required: false);
            WorkflowExpression.Validate(bodyinputDatachangesubcategoryname, nameof(bodyinputDatachangesubcategoryname), required: false);
            WorkflowExpression.Validate(bodyinputDatachangeitemname, nameof(bodyinputDatachangeitemname), required: false);
            WorkflowExpression.Validate(bodyinputDatachangeassets, nameof(bodyinputDatachangeassets), required: false);
            WorkflowExpression.Validate(bodyinputDatachangeudfFields, nameof(bodyinputDatachangeudfFields), required: false);
            return new DeferredBodyAction<CreateChangeResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/app/{0}/api/v3/changes", ExpressionConverter.ConvertWithUrlEncoding(serviceDeskInstance, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var inputDataObject = new JObject();
                var inputDataObjectpropCount = 0;
                var changeObject = new JObject();
                var changeObjectpropCount = 0;
                changeObjectpropCount++;
                changeObject["title"] = ExpressionConverter.ConvertO(bodyinputDatachangetitle);
                if (bodyinputDatachangecomment != null)
                {
                    changeObject["comment"] = ExpressionConverter.ConvertO(bodyinputDatachangecomment);
                    changeObjectpropCount++;
                }

                var templateObject = new JObject();
                var templateObjectpropCount = 0;
                if (bodyinputDatachangetemplatename != null)
                {
                    templateObject["name"] = ExpressionConverter.ConvertO(bodyinputDatachangetemplatename);
                    templateObjectpropCount++;
                }

                if (templateObjectpropCount > 0)
                {
                    changeObject["template"] = templateObject;
                    changeObjectpropCount++;
                }

                var changeRequesterObject = new JObject();
                var changeRequesterObjectpropCount = 0;
                if (bodyinputDatachangechangeRequestername != null)
                {
                    changeRequesterObject["name"] = ExpressionConverter.ConvertO(bodyinputDatachangechangeRequestername);
                    changeRequesterObjectpropCount++;
                }

                if (changeRequesterObjectpropCount > 0)
                {
                    changeObject["change_requester"] = changeRequesterObject;
                    changeObjectpropCount++;
                }

                var siteObject = new JObject();
                var siteObjectpropCount = 0;
                if (bodyinputDatachangesitename != null)
                {
                    siteObject["name"] = ExpressionConverter.ConvertO(bodyinputDatachangesitename);
                    siteObjectpropCount++;
                }

                if (siteObjectpropCount > 0)
                {
                    changeObject["site"] = siteObject;
                    changeObjectpropCount++;
                }

                var groupObject = new JObject();
                var groupObjectpropCount = 0;
                if (bodyinputDatachangegroupname != null)
                {
                    groupObject["name"] = ExpressionConverter.ConvertO(bodyinputDatachangegroupname);
                    groupObjectpropCount++;
                }

                if (groupObjectpropCount > 0)
                {
                    changeObject["group"] = groupObject;
                    changeObjectpropCount++;
                }

                if (bodyinputDatachangedescription != null)
                {
                    changeObject["description"] = ExpressionConverter.ConvertO(bodyinputDatachangedescription);
                    changeObjectpropCount++;
                }

                var changeOwnerObject = new JObject();
                var changeOwnerObjectpropCount = 0;
                if (bodyinputDatachangechangeOwneremailId != null)
                {
                    changeOwnerObject["email_id"] = ExpressionConverter.ConvertO(bodyinputDatachangechangeOwneremailId);
                    changeOwnerObjectpropCount++;
                }

                if (changeOwnerObjectpropCount > 0)
                {
                    changeObject["change_owner"] = changeOwnerObject;
                    changeObjectpropCount++;
                }

                var changeTypeObject = new JObject();
                var changeTypeObjectpropCount = 0;
                if (bodyinputDatachangechangeTypename != null)
                {
                    changeTypeObject["name"] = ExpressionConverter.ConvertO(bodyinputDatachangechangeTypename);
                    changeTypeObjectpropCount++;
                }

                if (changeTypeObjectpropCount > 0)
                {
                    changeObject["change_type"] = changeTypeObject;
                    changeObjectpropCount++;
                }

                var priorityObject = new JObject();
                var priorityObjectpropCount = 0;
                if (bodyinputDatachangepriorityname != null)
                {
                    priorityObject["name"] = ExpressionConverter.ConvertO(bodyinputDatachangepriorityname);
                    priorityObjectpropCount++;
                }

                if (priorityObjectpropCount > 0)
                {
                    changeObject["priority"] = priorityObject;
                    changeObjectpropCount++;
                }

                var urgencyObject = new JObject();
                var urgencyObjectpropCount = 0;
                if (bodyinputDatachangeurgencyname != null)
                {
                    urgencyObject["name"] = ExpressionConverter.ConvertO(bodyinputDatachangeurgencyname);
                    urgencyObjectpropCount++;
                }

                if (urgencyObjectpropCount > 0)
                {
                    changeObject["urgency"] = urgencyObject;
                    changeObjectpropCount++;
                }

                var impactObject = new JObject();
                var impactObjectpropCount = 0;
                if (bodyinputDatachangeimpactname != null)
                {
                    impactObject["name"] = ExpressionConverter.ConvertO(bodyinputDatachangeimpactname);
                    impactObjectpropCount++;
                }

                if (impactObjectpropCount > 0)
                {
                    changeObject["impact"] = impactObject;
                    changeObjectpropCount++;
                }

                var riskObject = new JObject();
                var riskObjectpropCount = 0;
                if (bodyinputDatachangeriskname != null)
                {
                    riskObject["name"] = ExpressionConverter.ConvertO(bodyinputDatachangeriskname);
                    riskObjectpropCount++;
                }

                if (riskObjectpropCount > 0)
                {
                    changeObject["risk"] = riskObject;
                    changeObjectpropCount++;
                }

                var reasonForChangeObject = new JObject();
                var reasonForChangeObjectpropCount = 0;
                if (bodyinputDatachangereasonForChangename != null)
                {
                    reasonForChangeObject["name"] = ExpressionConverter.ConvertO(bodyinputDatachangereasonForChangename);
                    reasonForChangeObjectpropCount++;
                }

                if (reasonForChangeObjectpropCount > 0)
                {
                    changeObject["reason_for_change"] = reasonForChangeObject;
                    changeObjectpropCount++;
                }

                var categoryObject = new JObject();
                var categoryObjectpropCount = 0;
                if (bodyinputDatachangecategoryname != null)
                {
                    categoryObject["name"] = ExpressionConverter.ConvertO(bodyinputDatachangecategoryname);
                    categoryObjectpropCount++;
                }

                if (categoryObjectpropCount > 0)
                {
                    changeObject["category"] = categoryObject;
                    changeObjectpropCount++;
                }

                var subcategoryObject = new JObject();
                var subcategoryObjectpropCount = 0;
                if (bodyinputDatachangesubcategoryname != null)
                {
                    subcategoryObject["name"] = ExpressionConverter.ConvertO(bodyinputDatachangesubcategoryname);
                    subcategoryObjectpropCount++;
                }

                if (subcategoryObjectpropCount > 0)
                {
                    changeObject["subcategory"] = subcategoryObject;
                    changeObjectpropCount++;
                }

                var itemObject = new JObject();
                var itemObjectpropCount = 0;
                if (bodyinputDatachangeitemname != null)
                {
                    itemObject["name"] = ExpressionConverter.ConvertO(bodyinputDatachangeitemname);
                    itemObjectpropCount++;
                }

                if (itemObjectpropCount > 0)
                {
                    changeObject["item"] = itemObject;
                    changeObjectpropCount++;
                }

                if (bodyinputDatachangeassets != null)
                {
                    changeObject["assets"] = ExpressionConverter.ConvertO(bodyinputDatachangeassets);
                    changeObjectpropCount++;
                }

                if (bodyinputDatachangeudfFields != null)
                {
                    changeObject["udf_fields"] = ExpressionConverter.ConvertO(bodyinputDatachangeudfFields);
                    changeObjectpropCount++;
                }

                if (changeObjectpropCount > 0)
                {
                    inputDataObject["change"] = changeObject;
                    inputDataObjectpropCount++;
                }

                if (inputDataObjectpropCount > 0)
                {
                    body["input_data"] = inputDataObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateChangeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "servicedeskpluscloud")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateChange))]
        public IBodyWorkflowAction<UpdateChangeResponse> UpdateChange([WorkflowExpression] Func<string> serviceDeskInstance, [WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodyinputDatachangetitle = null, [WorkflowExpression] Func<string> bodyinputDatachangecomment = null, [WorkflowExpression] Func<string> bodyinputDatachangetemplatename = null, [WorkflowExpression] Func<string> bodyinputDatachangechangeRequestername = null, [WorkflowExpression] Func<string> bodyinputDatachangesitename = null, [WorkflowExpression] Func<string> bodyinputDatachangegroupname = null, [WorkflowExpression] Func<string> bodyinputDatachangedescription = null, [WorkflowExpression] Func<string> bodyinputDatachangechangeOwneremailId = null, [WorkflowExpression] Func<string> bodyinputDatachangechangeTypename = null, [WorkflowExpression] Func<string> bodyinputDatachangepriorityname = null, [WorkflowExpression] Func<string> bodyinputDatachangeurgencyname = null, [WorkflowExpression] Func<string> bodyinputDatachangeimpactname = null, [WorkflowExpression] Func<string> bodyinputDatachangeriskname = null, [WorkflowExpression] Func<string> bodyinputDatachangereasonForChangename = null, [WorkflowExpression] Func<string> bodyinputDatachangecategoryname = null, [WorkflowExpression] Func<string> bodyinputDatachangesubcategoryname = null, [WorkflowExpression] Func<string> bodyinputDatachangeitemname = null, [WorkflowExpression] Func<bodyinputDatachangeassetsInputItem[]> bodyinputDatachangeassets = null, [WorkflowExpression] Func<string> bodyinputDatachangeudfFields = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<UpdateChangeResponse> __BuildUpdateChange(WorkflowExpression<string> serviceDeskInstance, WorkflowExpression<string> id, WorkflowExpression<string> bodyinputDatachangetitle = null, WorkflowExpression<string> bodyinputDatachangecomment = null, WorkflowExpression<string> bodyinputDatachangetemplatename = null, WorkflowExpression<string> bodyinputDatachangechangeRequestername = null, WorkflowExpression<string> bodyinputDatachangesitename = null, WorkflowExpression<string> bodyinputDatachangegroupname = null, WorkflowExpression<string> bodyinputDatachangedescription = null, WorkflowExpression<string> bodyinputDatachangechangeOwneremailId = null, WorkflowExpression<string> bodyinputDatachangechangeTypename = null, WorkflowExpression<string> bodyinputDatachangepriorityname = null, WorkflowExpression<string> bodyinputDatachangeurgencyname = null, WorkflowExpression<string> bodyinputDatachangeimpactname = null, WorkflowExpression<string> bodyinputDatachangeriskname = null, WorkflowExpression<string> bodyinputDatachangereasonForChangename = null, WorkflowExpression<string> bodyinputDatachangecategoryname = null, WorkflowExpression<string> bodyinputDatachangesubcategoryname = null, WorkflowExpression<string> bodyinputDatachangeitemname = null, WorkflowExpression<bodyinputDatachangeassetsInputItem[]> bodyinputDatachangeassets = null, WorkflowExpression<string> bodyinputDatachangeudfFields = null)
        {
            WorkflowExpression.Validate(serviceDeskInstance, nameof(serviceDeskInstance), required: true);
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(bodyinputDatachangetitle, nameof(bodyinputDatachangetitle), required: false);
            WorkflowExpression.Validate(bodyinputDatachangecomment, nameof(bodyinputDatachangecomment), required: false);
            WorkflowExpression.Validate(bodyinputDatachangetemplatename, nameof(bodyinputDatachangetemplatename), required: false);
            WorkflowExpression.Validate(bodyinputDatachangechangeRequestername, nameof(bodyinputDatachangechangeRequestername), required: false);
            WorkflowExpression.Validate(bodyinputDatachangesitename, nameof(bodyinputDatachangesitename), required: false);
            WorkflowExpression.Validate(bodyinputDatachangegroupname, nameof(bodyinputDatachangegroupname), required: false);
            WorkflowExpression.Validate(bodyinputDatachangedescription, nameof(bodyinputDatachangedescription), required: false);
            WorkflowExpression.Validate(bodyinputDatachangechangeOwneremailId, nameof(bodyinputDatachangechangeOwneremailId), required: false);
            WorkflowExpression.Validate(bodyinputDatachangechangeTypename, nameof(bodyinputDatachangechangeTypename), required: false);
            WorkflowExpression.Validate(bodyinputDatachangepriorityname, nameof(bodyinputDatachangepriorityname), required: false);
            WorkflowExpression.Validate(bodyinputDatachangeurgencyname, nameof(bodyinputDatachangeurgencyname), required: false);
            WorkflowExpression.Validate(bodyinputDatachangeimpactname, nameof(bodyinputDatachangeimpactname), required: false);
            WorkflowExpression.Validate(bodyinputDatachangeriskname, nameof(bodyinputDatachangeriskname), required: false);
            WorkflowExpression.Validate(bodyinputDatachangereasonForChangename, nameof(bodyinputDatachangereasonForChangename), required: false);
            WorkflowExpression.Validate(bodyinputDatachangecategoryname, nameof(bodyinputDatachangecategoryname), required: false);
            WorkflowExpression.Validate(bodyinputDatachangesubcategoryname, nameof(bodyinputDatachangesubcategoryname), required: false);
            WorkflowExpression.Validate(bodyinputDatachangeitemname, nameof(bodyinputDatachangeitemname), required: false);
            WorkflowExpression.Validate(bodyinputDatachangeassets, nameof(bodyinputDatachangeassets), required: false);
            WorkflowExpression.Validate(bodyinputDatachangeudfFields, nameof(bodyinputDatachangeudfFields), required: false);
            return new DeferredBodyAction<UpdateChangeResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/app/{0}/api/v3/changes/{1}", ExpressionConverter.ConvertWithUrlEncoding(serviceDeskInstance, 1), ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var inputDataObject = new JObject();
                var inputDataObjectpropCount = 0;
                var changeObject = new JObject();
                var changeObjectpropCount = 0;
                if (bodyinputDatachangetitle != null)
                {
                    changeObject["title"] = ExpressionConverter.ConvertO(bodyinputDatachangetitle);
                    changeObjectpropCount++;
                }

                if (bodyinputDatachangecomment != null)
                {
                    changeObject["comment"] = ExpressionConverter.ConvertO(bodyinputDatachangecomment);
                    changeObjectpropCount++;
                }

                var templateObject = new JObject();
                var templateObjectpropCount = 0;
                if (bodyinputDatachangetemplatename != null)
                {
                    templateObject["name"] = ExpressionConverter.ConvertO(bodyinputDatachangetemplatename);
                    templateObjectpropCount++;
                }

                if (templateObjectpropCount > 0)
                {
                    changeObject["template"] = templateObject;
                    changeObjectpropCount++;
                }

                var changeRequesterObject = new JObject();
                var changeRequesterObjectpropCount = 0;
                if (bodyinputDatachangechangeRequestername != null)
                {
                    changeRequesterObject["name"] = ExpressionConverter.ConvertO(bodyinputDatachangechangeRequestername);
                    changeRequesterObjectpropCount++;
                }

                if (changeRequesterObjectpropCount > 0)
                {
                    changeObject["change_requester"] = changeRequesterObject;
                    changeObjectpropCount++;
                }

                var siteObject = new JObject();
                var siteObjectpropCount = 0;
                if (bodyinputDatachangesitename != null)
                {
                    siteObject["name"] = ExpressionConverter.ConvertO(bodyinputDatachangesitename);
                    siteObjectpropCount++;
                }

                if (siteObjectpropCount > 0)
                {
                    changeObject["site"] = siteObject;
                    changeObjectpropCount++;
                }

                var groupObject = new JObject();
                var groupObjectpropCount = 0;
                if (bodyinputDatachangegroupname != null)
                {
                    groupObject["name"] = ExpressionConverter.ConvertO(bodyinputDatachangegroupname);
                    groupObjectpropCount++;
                }

                if (groupObjectpropCount > 0)
                {
                    changeObject["group"] = groupObject;
                    changeObjectpropCount++;
                }

                if (bodyinputDatachangedescription != null)
                {
                    changeObject["description"] = ExpressionConverter.ConvertO(bodyinputDatachangedescription);
                    changeObjectpropCount++;
                }

                var changeOwnerObject = new JObject();
                var changeOwnerObjectpropCount = 0;
                if (bodyinputDatachangechangeOwneremailId != null)
                {
                    changeOwnerObject["email_id"] = ExpressionConverter.ConvertO(bodyinputDatachangechangeOwneremailId);
                    changeOwnerObjectpropCount++;
                }

                if (changeOwnerObjectpropCount > 0)
                {
                    changeObject["change_owner"] = changeOwnerObject;
                    changeObjectpropCount++;
                }

                var changeTypeObject = new JObject();
                var changeTypeObjectpropCount = 0;
                if (bodyinputDatachangechangeTypename != null)
                {
                    changeTypeObject["name"] = ExpressionConverter.ConvertO(bodyinputDatachangechangeTypename);
                    changeTypeObjectpropCount++;
                }

                if (changeTypeObjectpropCount > 0)
                {
                    changeObject["change_type"] = changeTypeObject;
                    changeObjectpropCount++;
                }

                var priorityObject = new JObject();
                var priorityObjectpropCount = 0;
                if (bodyinputDatachangepriorityname != null)
                {
                    priorityObject["name"] = ExpressionConverter.ConvertO(bodyinputDatachangepriorityname);
                    priorityObjectpropCount++;
                }

                if (priorityObjectpropCount > 0)
                {
                    changeObject["priority"] = priorityObject;
                    changeObjectpropCount++;
                }

                var urgencyObject = new JObject();
                var urgencyObjectpropCount = 0;
                if (bodyinputDatachangeurgencyname != null)
                {
                    urgencyObject["name"] = ExpressionConverter.ConvertO(bodyinputDatachangeurgencyname);
                    urgencyObjectpropCount++;
                }

                if (urgencyObjectpropCount > 0)
                {
                    changeObject["urgency"] = urgencyObject;
                    changeObjectpropCount++;
                }

                var impactObject = new JObject();
                var impactObjectpropCount = 0;
                if (bodyinputDatachangeimpactname != null)
                {
                    impactObject["name"] = ExpressionConverter.ConvertO(bodyinputDatachangeimpactname);
                    impactObjectpropCount++;
                }

                if (impactObjectpropCount > 0)
                {
                    changeObject["impact"] = impactObject;
                    changeObjectpropCount++;
                }

                var riskObject = new JObject();
                var riskObjectpropCount = 0;
                if (bodyinputDatachangeriskname != null)
                {
                    riskObject["name"] = ExpressionConverter.ConvertO(bodyinputDatachangeriskname);
                    riskObjectpropCount++;
                }

                if (riskObjectpropCount > 0)
                {
                    changeObject["risk"] = riskObject;
                    changeObjectpropCount++;
                }

                var reasonForChangeObject = new JObject();
                var reasonForChangeObjectpropCount = 0;
                if (bodyinputDatachangereasonForChangename != null)
                {
                    reasonForChangeObject["name"] = ExpressionConverter.ConvertO(bodyinputDatachangereasonForChangename);
                    reasonForChangeObjectpropCount++;
                }

                if (reasonForChangeObjectpropCount > 0)
                {
                    changeObject["reason_for_change"] = reasonForChangeObject;
                    changeObjectpropCount++;
                }

                var categoryObject = new JObject();
                var categoryObjectpropCount = 0;
                if (bodyinputDatachangecategoryname != null)
                {
                    categoryObject["name"] = ExpressionConverter.ConvertO(bodyinputDatachangecategoryname);
                    categoryObjectpropCount++;
                }

                if (categoryObjectpropCount > 0)
                {
                    changeObject["category"] = categoryObject;
                    changeObjectpropCount++;
                }

                var subcategoryObject = new JObject();
                var subcategoryObjectpropCount = 0;
                if (bodyinputDatachangesubcategoryname != null)
                {
                    subcategoryObject["name"] = ExpressionConverter.ConvertO(bodyinputDatachangesubcategoryname);
                    subcategoryObjectpropCount++;
                }

                if (subcategoryObjectpropCount > 0)
                {
                    changeObject["subcategory"] = subcategoryObject;
                    changeObjectpropCount++;
                }

                var itemObject = new JObject();
                var itemObjectpropCount = 0;
                if (bodyinputDatachangeitemname != null)
                {
                    itemObject["name"] = ExpressionConverter.ConvertO(bodyinputDatachangeitemname);
                    itemObjectpropCount++;
                }

                if (itemObjectpropCount > 0)
                {
                    changeObject["item"] = itemObject;
                    changeObjectpropCount++;
                }

                if (bodyinputDatachangeassets != null)
                {
                    changeObject["assets"] = ExpressionConverter.ConvertO(bodyinputDatachangeassets);
                    changeObjectpropCount++;
                }

                if (bodyinputDatachangeudfFields != null)
                {
                    changeObject["udf_fields"] = ExpressionConverter.ConvertO(bodyinputDatachangeudfFields);
                    changeObjectpropCount++;
                }

                if (changeObjectpropCount > 0)
                {
                    inputDataObject["change"] = changeObject;
                    inputDataObjectpropCount++;
                }

                if (inputDataObjectpropCount > 0)
                {
                    body["input_data"] = inputDataObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<UpdateChangeResponse>(callPayload);
            });
        }
    }

    public class ServicedeskpluscloudTriggers([ConnectionName] string connectionId)
    {
    }

    public class CreateRequestResponse
    {
        [JsonProperty("request")]
        public CreateRequestResponseRequestType Request { get; set; }
    }

    public class CreateRequestResponseRequestType
    {
        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("project")]
        public CreateRequestResponseRequestTypeProjectType Project { get; set; }

        [JsonProperty("resolution")]
        public CreateRequestResponseRequestTypeResolutionType Resolution { get; set; }

        [JsonProperty("linked_to_request")]
        public CreateRequestResponseRequestTypeLinkedToRequestType LinkedToRequest { get; set; }

        [JsonProperty("mode")]
        public CreateRequestResponseRequestTypeModeType Mode { get; set; }

        [JsonProperty("lifecycle")]
        public JToken Lifecycle { get; set; }

        [JsonProperty("is_read")]
        public bool IsRead { get; set; }

        [JsonProperty("assets")]
        public CreateRequestResponseRequestTypeAssetsTypeItem[] Assets { get; set; }

        [JsonProperty("cancellation_requested")]
        public bool CancellationRequested { get; set; }

        [JsonProperty("is_trashed")]
        public bool IsTrashed { get; set; }

        [JsonProperty("has_change_initiated_request")]
        public bool HasChangeInitiatedRequest { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("assigned_time")]
        public CreateRequestResponseRequestTypeAssignedTimeType AssignedTime { get; set; }

        [JsonProperty("group")]
        public CreateRequestResponseRequestTypeGroupType Group { get; set; }

        [JsonProperty("requester")]
        public CreateRequestResponseRequestTypeRequesterType Requester { get; set; }

        [JsonProperty("email_to")]
        public JToken[] EmailTo { get; set; }

        [JsonProperty("created_time")]
        public CreateRequestResponseRequestTypeCreatedTimeType CreatedTime { get; set; }

        [JsonProperty("item")]
        public CreateRequestResponseRequestTypeItemType Item { get; set; }

        [JsonProperty("cancel_flag_comments")]
        public JToken CancelFlagComments { get; set; }

        [JsonProperty("level")]
        public CreateRequestResponseRequestTypeLevelType Level { get; set; }

        [JsonProperty("approval_status")]
        public JToken ApprovalStatus { get; set; }

        [JsonProperty("impact")]
        public CreateRequestResponseRequestTypeImpactType Impact { get; set; }

        [JsonProperty("service_category")]
        public CreateRequestResponseRequestTypeServiceCategoryType ServiceCategory { get; set; }

        [JsonProperty("sla")]
        public CreateRequestResponseRequestTypeSlaType Sla { get; set; }

        [JsonProperty("resolved_time")]
        public JToken ResolvedTime { get; set; }

        [JsonProperty("priority")]
        public CreateRequestResponseRequestTypePriorityType Priority { get; set; }

        [JsonProperty("created_by")]
        public CreateRequestResponseRequestTypeCreatedByType CreatedBy { get; set; }

        [JsonProperty("scheduled_end_time")]
        public CreateRequestResponseRequestTypeScheduledEndTimeType ScheduledEndTime { get; set; }

        [JsonProperty("first_response_due_by_time")]
        public CreateRequestResponseRequestTypeFirstResponseDueByTimeType FirstResponseDueByTime { get; set; }

        [JsonProperty("is_escalated")]
        public bool IsEscalated { get; set; }

        [JsonProperty("last_updated_time")]
        public CreateRequestResponseRequestTypeLastUpdatedTimeType LastUpdatedTime { get; set; }

        [JsonProperty("has_notes")]
        public bool HasNotes { get; set; }

        [JsonProperty("udf_fields")]
        public JToken UdfFields { get; set; }

        [JsonProperty("impact_details")]
        public string ImpactDetails { get; set; }

        [JsonProperty("subcategory")]
        public CreateRequestResponseRequestTypeSubcategoryType Subcategory { get; set; }

        [JsonProperty("deleted_time")]
        public JToken DeletedTime { get; set; }

        [JsonProperty("email_cc")]
        public string[] EmailCc { get; set; }

        [JsonProperty("onhold_scheduler")]
        public JToken OnholdScheduler { get; set; }

        [JsonProperty("status")]
        public CreateRequestResponseRequestTypeStatusType Status { get; set; }

        [JsonProperty("scheduled_start_time")]
        public CreateRequestResponseRequestTypeScheduledStartTimeType ScheduledStartTime { get; set; }

        [JsonProperty("template")]
        public CreateRequestResponseRequestTypeTemplateType Template { get; set; }

        [JsonProperty("email_ids_to_notify")]
        public string[] EmailIdsToNotify { get; set; }

        [JsonProperty("attachments")]
        public JToken[] Attachments { get; set; }

        [JsonProperty("request_type")]
        public CreateRequestResponseRequestTypeRequestTypeType RequestType { get; set; }

        [JsonProperty("completed_by_denial")]
        public bool CompletedByDenial { get; set; }

        [JsonProperty("display_id")]
        public string DisplayId { get; set; }

        [JsonProperty("time_elapsed")]
        public string TimeElapsed { get; set; }

        [JsonProperty("notification_status")]
        public JToken NotificationStatus { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("responded_time")]
        public string RespondedTime { get; set; }

        [JsonProperty("is_service_request")]
        public bool IsServiceRequest { get; set; }

        [JsonProperty("deleted_assets")]
        public JToken[] DeletedAssets { get; set; }

        [JsonProperty("urgency")]
        public CreateRequestResponseRequestTypeUrgencyType Urgency { get; set; }

        [JsonProperty("has_request_initiated_change")]
        public bool HasRequestInitiatedChange { get; set; }

        [JsonProperty("request_template_task_ids")]
        public CreateRequestResponseRequestTypeRequestTemplateTaskIdsTypeItem[] RequestTemplateTaskIds { get; set; }

        [JsonProperty("department")]
        public JToken Department { get; set; }

        [JsonProperty("is_reopened")]
        public bool IsReopened { get; set; }

        [JsonProperty("has_draft")]
        public bool HasDraft { get; set; }

        [JsonProperty("has_attachments")]
        public bool HasAttachments { get; set; }

        [JsonProperty("has_linked_requests")]
        public bool HasLinkedRequests { get; set; }

        [JsonProperty("is_overdue")]
        public bool IsOverdue { get; set; }

        [JsonProperty("technician")]
        public CreateRequestResponseRequestTypeTechnicianType Technician { get; set; }

        [JsonProperty("has_problem")]
        public bool HasProblem { get; set; }

        [JsonProperty("due_by_time")]
        public CreateRequestResponseRequestTypeDueByTimeType DueByTime { get; set; }

        [JsonProperty("is_fcr")]
        public bool IsFcr { get; set; }

        [JsonProperty("has_project")]
        public bool HasProject { get; set; }

        [JsonProperty("site")]
        public CreateRequestResponseRequestTypeSiteType Site { get; set; }

        [JsonProperty("is_first_response_overdue")]
        public bool IsFirstResponseOverdue { get; set; }

        [JsonProperty("completed_time")]
        public JToken CompletedTime { get; set; }

        [JsonProperty("unreplied_count")]
        public int UnrepliedCount { get; set; }

        [JsonProperty("email_bcc")]
        public JToken[] EmailBcc { get; set; }

        [JsonProperty("category")]
        public CreateRequestResponseRequestTypeCategoryType Category { get; set; }

        [JsonProperty("maintenance")]
        public JToken Maintenance { get; set; }
    }

    public class CreateRequestResponseRequestTypeProjectType
    {
        [JsonProperty("display_id")]
        public CreateRequestResponseRequestTypeProjectTypeDisplayIdType DisplayId { get; set; }

        [JsonProperty("project_code")]
        public JToken ProjectCode { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }

    public class CreateRequestResponseRequestTypeProjectTypeDisplayIdType
    {
        [JsonProperty("display_value")]
        public string DisplayValue { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class CreateRequestResponseRequestTypeResolutionType
    {
        [JsonProperty("content")]
        public string Content { get; set; }
    }

    public class CreateRequestResponseRequestTypeLinkedToRequestType
    {
        [JsonProperty("request")]
        public CreateRequestResponseRequestTypeLinkedToRequestTypeRequestType Request { get; set; }

        [JsonProperty("comments")]
        public string Comments { get; set; }
    }

    public class CreateRequestResponseRequestTypeLinkedToRequestTypeRequestType
    {
        [JsonProperty("display_id")]
        public int DisplayId { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateRequestResponseRequestTypeModeType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateRequestResponseRequestTypeAssetsTypeItem
    {
        [JsonProperty("site")]
        public JToken Site { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateRequestResponseRequestTypeAssignedTimeType
    {
        [JsonProperty("display_value")]
        public string DisplayValue { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class CreateRequestResponseRequestTypeGroupType
    {
        [JsonProperty("site")]
        public JToken Site { get; set; }

        [JsonProperty("deleted")]
        public bool Deleted { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateRequestResponseRequestTypeRequesterType
    {
        [JsonProperty("email_id")]
        public string EmailId { get; set; }

        [JsonProperty("is_technician")]
        public bool IsTechnician { get; set; }

        [JsonProperty("sms_mail")]
        public string SmsMail { get; set; }

        [JsonProperty("mobile")]
        public string Mobile { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("user_scope")]
        public string UserScope { get; set; }

        [JsonProperty("sms_mail_id")]
        public string SmsMailId { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("photo_url")]
        public string PhotoUrl { get; set; }

        [JsonProperty("is_vip_user")]
        public bool IsVipUser { get; set; }

        [JsonProperty("department")]
        public JToken Department { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("job_title")]
        public string JobTitle { get; set; }
    }

    public class CreateRequestResponseRequestTypeCreatedTimeType
    {
        [JsonProperty("display_value")]
        public string DisplayValue { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class CreateRequestResponseRequestTypeItemType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateRequestResponseRequestTypeLevelType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateRequestResponseRequestTypeImpactType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateRequestResponseRequestTypeServiceCategoryType
    {
        [JsonProperty("inactive")]
        public bool Inactive { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("sort_index")]
        public int SortIndex { get; set; }
    }

    public class CreateRequestResponseRequestTypeSlaType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateRequestResponseRequestTypePriorityType
    {
        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateRequestResponseRequestTypeCreatedByType
    {
        [JsonProperty("email_id")]
        public string EmailId { get; set; }

        [JsonProperty("is_technician")]
        public bool IsTechnician { get; set; }

        [JsonProperty("sms_mail")]
        public string SmsMail { get; set; }

        [JsonProperty("mobile")]
        public string Mobile { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("user_scope")]
        public string UserScope { get; set; }

        [JsonProperty("sms_mail_id")]
        public string SmsMailId { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("photo_url")]
        public string PhotoUrl { get; set; }

        [JsonProperty("is_vip_user")]
        public bool IsVipUser { get; set; }

        [JsonProperty("department")]
        public JToken Department { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("job_title")]
        public string JobTitle { get; set; }
    }

    public class CreateRequestResponseRequestTypeScheduledEndTimeType
    {
        [JsonProperty("display_value")]
        public string DisplayValue { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class CreateRequestResponseRequestTypeFirstResponseDueByTimeType
    {
        [JsonProperty("display_value")]
        public string DisplayValue { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class CreateRequestResponseRequestTypeLastUpdatedTimeType
    {
        [JsonProperty("display_value")]
        public string DisplayValue { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class CreateRequestResponseRequestTypeSubcategoryType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateRequestResponseRequestTypeStatusType
    {
        [JsonProperty("in_progress")]
        public bool InProgress { get; set; }

        [JsonProperty("internal_name")]
        public string InternalName { get; set; }

        [JsonProperty("stop_timer")]
        public bool StopTimer { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateRequestResponseRequestTypeScheduledStartTimeType
    {
        [JsonProperty("display_value")]
        public string DisplayValue { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class CreateRequestResponseRequestTypeTemplateType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateRequestResponseRequestTypeRequestTypeType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateRequestResponseRequestTypeUrgencyType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateRequestResponseRequestTypeRequestTemplateTaskIdsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateRequestResponseRequestTypeTechnicianType
    {
        [JsonProperty("email_id")]
        public string EmailId { get; set; }

        [JsonProperty("is_technician")]
        public bool IsTechnician { get; set; }

        [JsonProperty("sms_mail")]
        public string SmsMail { get; set; }

        [JsonProperty("mobile")]
        public string Mobile { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("user_scope")]
        public string UserScope { get; set; }

        [JsonProperty("sms_mail_id")]
        public string SmsMailId { get; set; }

        [JsonProperty("cost_per_hour")]
        public string CostPerHour { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("photo_url")]
        public string PhotoUrl { get; set; }

        [JsonProperty("is_vip_user")]
        public bool IsVipUser { get; set; }

        [JsonProperty("department")]
        public CreateRequestResponseRequestTypeTechnicianTypeDepartmentType Department { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("job_title")]
        public string JobTitle { get; set; }
    }

    public class CreateRequestResponseRequestTypeTechnicianTypeDepartmentType
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateRequestResponseRequestTypeDueByTimeType
    {
        [JsonProperty("display_value")]
        public string DisplayValue { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class CreateRequestResponseRequestTypeSiteType
    {
        [JsonProperty("deleted")]
        public bool Deleted { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateRequestResponseRequestTypeCategoryType
    {
        [JsonProperty("deleted")]
        public bool Deleted { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class bodyinputDatarequestassetsInputItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class UpdateRequestResponse
    {
        [JsonProperty("request")]
        public UpdateRequestResponseRequestType Request { get; set; }
    }

    public class UpdateRequestResponseRequestType
    {
        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("project")]
        public UpdateRequestResponseRequestTypeProjectType Project { get; set; }

        [JsonProperty("resolution")]
        public UpdateRequestResponseRequestTypeResolutionType Resolution { get; set; }

        [JsonProperty("linked_to_request")]
        public UpdateRequestResponseRequestTypeLinkedToRequestType LinkedToRequest { get; set; }

        [JsonProperty("mode")]
        public UpdateRequestResponseRequestTypeModeType Mode { get; set; }

        [JsonProperty("lifecycle")]
        public JToken Lifecycle { get; set; }

        [JsonProperty("is_read")]
        public bool IsRead { get; set; }

        [JsonProperty("assets")]
        public UpdateRequestResponseRequestTypeAssetsTypeItem[] Assets { get; set; }

        [JsonProperty("cancellation_requested")]
        public bool CancellationRequested { get; set; }

        [JsonProperty("is_trashed")]
        public bool IsTrashed { get; set; }

        [JsonProperty("has_change_initiated_request")]
        public bool HasChangeInitiatedRequest { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("assigned_time")]
        public UpdateRequestResponseRequestTypeAssignedTimeType AssignedTime { get; set; }

        [JsonProperty("group")]
        public UpdateRequestResponseRequestTypeGroupType Group { get; set; }

        [JsonProperty("requester")]
        public UpdateRequestResponseRequestTypeRequesterType Requester { get; set; }

        [JsonProperty("email_to")]
        public JToken[] EmailTo { get; set; }

        [JsonProperty("created_time")]
        public UpdateRequestResponseRequestTypeCreatedTimeType CreatedTime { get; set; }

        [JsonProperty("item")]
        public UpdateRequestResponseRequestTypeItemType Item { get; set; }

        [JsonProperty("cancel_flag_comments")]
        public JToken CancelFlagComments { get; set; }

        [JsonProperty("level")]
        public UpdateRequestResponseRequestTypeLevelType Level { get; set; }

        [JsonProperty("approval_status")]
        public JToken ApprovalStatus { get; set; }

        [JsonProperty("impact")]
        public UpdateRequestResponseRequestTypeImpactType Impact { get; set; }

        [JsonProperty("service_category")]
        public UpdateRequestResponseRequestTypeServiceCategoryType ServiceCategory { get; set; }

        [JsonProperty("sla")]
        public UpdateRequestResponseRequestTypeSlaType Sla { get; set; }

        [JsonProperty("resolved_time")]
        public JToken ResolvedTime { get; set; }

        [JsonProperty("priority")]
        public UpdateRequestResponseRequestTypePriorityType Priority { get; set; }

        [JsonProperty("created_by")]
        public UpdateRequestResponseRequestTypeCreatedByType CreatedBy { get; set; }

        [JsonProperty("scheduled_end_time")]
        public UpdateRequestResponseRequestTypeScheduledEndTimeType ScheduledEndTime { get; set; }

        [JsonProperty("first_response_due_by_time")]
        public UpdateRequestResponseRequestTypeFirstResponseDueByTimeType FirstResponseDueByTime { get; set; }

        [JsonProperty("is_escalated")]
        public bool IsEscalated { get; set; }

        [JsonProperty("last_updated_time")]
        public UpdateRequestResponseRequestTypeLastUpdatedTimeType LastUpdatedTime { get; set; }

        [JsonProperty("has_notes")]
        public bool HasNotes { get; set; }

        [JsonProperty("udf_fields")]
        public JToken UdfFields { get; set; }

        [JsonProperty("impact_details")]
        public string ImpactDetails { get; set; }

        [JsonProperty("subcategory")]
        public UpdateRequestResponseRequestTypeSubcategoryType Subcategory { get; set; }

        [JsonProperty("deleted_time")]
        public JToken DeletedTime { get; set; }

        [JsonProperty("email_cc")]
        public string[] EmailCc { get; set; }

        [JsonProperty("onhold_scheduler")]
        public JToken OnholdScheduler { get; set; }

        [JsonProperty("status")]
        public UpdateRequestResponseRequestTypeStatusType Status { get; set; }

        [JsonProperty("scheduled_start_time")]
        public UpdateRequestResponseRequestTypeScheduledStartTimeType ScheduledStartTime { get; set; }

        [JsonProperty("template")]
        public UpdateRequestResponseRequestTypeTemplateType Template { get; set; }

        [JsonProperty("email_ids_to_notify")]
        public string[] EmailIdsToNotify { get; set; }

        [JsonProperty("attachments")]
        public JToken[] Attachments { get; set; }

        [JsonProperty("request_type")]
        public UpdateRequestResponseRequestTypeRequestTypeType RequestType { get; set; }

        [JsonProperty("completed_by_denial")]
        public bool CompletedByDenial { get; set; }

        [JsonProperty("display_id")]
        public string DisplayId { get; set; }

        [JsonProperty("time_elapsed")]
        public string TimeElapsed { get; set; }

        [JsonProperty("notification_status")]
        public JToken NotificationStatus { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("responded_time")]
        public string RespondedTime { get; set; }

        [JsonProperty("is_service_request")]
        public bool IsServiceRequest { get; set; }

        [JsonProperty("deleted_assets")]
        public JToken[] DeletedAssets { get; set; }

        [JsonProperty("urgency")]
        public UpdateRequestResponseRequestTypeUrgencyType Urgency { get; set; }

        [JsonProperty("has_request_initiated_change")]
        public bool HasRequestInitiatedChange { get; set; }

        [JsonProperty("request_template_task_ids")]
        public UpdateRequestResponseRequestTypeRequestTemplateTaskIdsTypeItem[] RequestTemplateTaskIds { get; set; }

        [JsonProperty("department")]
        public JToken Department { get; set; }

        [JsonProperty("is_reopened")]
        public bool IsReopened { get; set; }

        [JsonProperty("has_draft")]
        public bool HasDraft { get; set; }

        [JsonProperty("has_attachments")]
        public bool HasAttachments { get; set; }

        [JsonProperty("has_linked_requests")]
        public bool HasLinkedRequests { get; set; }

        [JsonProperty("is_overdue")]
        public bool IsOverdue { get; set; }

        [JsonProperty("technician")]
        public UpdateRequestResponseRequestTypeTechnicianType Technician { get; set; }

        [JsonProperty("has_problem")]
        public bool HasProblem { get; set; }

        [JsonProperty("due_by_time")]
        public UpdateRequestResponseRequestTypeDueByTimeType DueByTime { get; set; }

        [JsonProperty("is_fcr")]
        public bool IsFcr { get; set; }

        [JsonProperty("has_project")]
        public bool HasProject { get; set; }

        [JsonProperty("site")]
        public UpdateRequestResponseRequestTypeSiteType Site { get; set; }

        [JsonProperty("is_first_response_overdue")]
        public bool IsFirstResponseOverdue { get; set; }

        [JsonProperty("completed_time")]
        public JToken CompletedTime { get; set; }

        [JsonProperty("unreplied_count")]
        public int UnrepliedCount { get; set; }

        [JsonProperty("email_bcc")]
        public JToken[] EmailBcc { get; set; }

        [JsonProperty("category")]
        public UpdateRequestResponseRequestTypeCategoryType Category { get; set; }

        [JsonProperty("maintenance")]
        public JToken Maintenance { get; set; }
    }

    public class UpdateRequestResponseRequestTypeProjectType
    {
        [JsonProperty("display_id")]
        public UpdateRequestResponseRequestTypeProjectTypeDisplayIdType DisplayId { get; set; }

        [JsonProperty("project_code")]
        public JToken ProjectCode { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }

    public class UpdateRequestResponseRequestTypeProjectTypeDisplayIdType
    {
        [JsonProperty("display_value")]
        public string DisplayValue { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class UpdateRequestResponseRequestTypeResolutionType
    {
        [JsonProperty("content")]
        public string Content { get; set; }
    }

    public class UpdateRequestResponseRequestTypeLinkedToRequestType
    {
        [JsonProperty("request")]
        public UpdateRequestResponseRequestTypeLinkedToRequestTypeRequestType Request { get; set; }

        [JsonProperty("comments")]
        public string Comments { get; set; }
    }

    public class UpdateRequestResponseRequestTypeLinkedToRequestTypeRequestType
    {
        [JsonProperty("display_id")]
        public int DisplayId { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class UpdateRequestResponseRequestTypeModeType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class UpdateRequestResponseRequestTypeAssetsTypeItem
    {
        [JsonProperty("site")]
        public JToken Site { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class UpdateRequestResponseRequestTypeAssignedTimeType
    {
        [JsonProperty("display_value")]
        public string DisplayValue { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class UpdateRequestResponseRequestTypeGroupType
    {
        [JsonProperty("site")]
        public JToken Site { get; set; }

        [JsonProperty("deleted")]
        public bool Deleted { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class UpdateRequestResponseRequestTypeRequesterType
    {
        [JsonProperty("email_id")]
        public string EmailId { get; set; }

        [JsonProperty("is_technician")]
        public bool IsTechnician { get; set; }

        [JsonProperty("sms_mail")]
        public string SmsMail { get; set; }

        [JsonProperty("mobile")]
        public string Mobile { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("user_scope")]
        public string UserScope { get; set; }

        [JsonProperty("sms_mail_id")]
        public string SmsMailId { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("photo_url")]
        public string PhotoUrl { get; set; }

        [JsonProperty("is_vip_user")]
        public bool IsVipUser { get; set; }

        [JsonProperty("department")]
        public JToken Department { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("job_title")]
        public string JobTitle { get; set; }
    }

    public class UpdateRequestResponseRequestTypeCreatedTimeType
    {
        [JsonProperty("display_value")]
        public string DisplayValue { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class UpdateRequestResponseRequestTypeItemType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class UpdateRequestResponseRequestTypeLevelType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class UpdateRequestResponseRequestTypeImpactType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class UpdateRequestResponseRequestTypeServiceCategoryType
    {
        [JsonProperty("inactive")]
        public bool Inactive { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("sort_index")]
        public int SortIndex { get; set; }
    }

    public class UpdateRequestResponseRequestTypeSlaType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class UpdateRequestResponseRequestTypePriorityType
    {
        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class UpdateRequestResponseRequestTypeCreatedByType
    {
        [JsonProperty("email_id")]
        public string EmailId { get; set; }

        [JsonProperty("is_technician")]
        public bool IsTechnician { get; set; }

        [JsonProperty("sms_mail")]
        public string SmsMail { get; set; }

        [JsonProperty("mobile")]
        public string Mobile { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("user_scope")]
        public string UserScope { get; set; }

        [JsonProperty("sms_mail_id")]
        public string SmsMailId { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("photo_url")]
        public string PhotoUrl { get; set; }

        [JsonProperty("is_vip_user")]
        public bool IsVipUser { get; set; }

        [JsonProperty("department")]
        public JToken Department { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("job_title")]
        public string JobTitle { get; set; }
    }

    public class UpdateRequestResponseRequestTypeScheduledEndTimeType
    {
        [JsonProperty("display_value")]
        public string DisplayValue { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class UpdateRequestResponseRequestTypeFirstResponseDueByTimeType
    {
        [JsonProperty("display_value")]
        public string DisplayValue { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class UpdateRequestResponseRequestTypeLastUpdatedTimeType
    {
        [JsonProperty("display_value")]
        public string DisplayValue { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class UpdateRequestResponseRequestTypeSubcategoryType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class UpdateRequestResponseRequestTypeStatusType
    {
        [JsonProperty("in_progress")]
        public bool InProgress { get; set; }

        [JsonProperty("internal_name")]
        public string InternalName { get; set; }

        [JsonProperty("stop_timer")]
        public bool StopTimer { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class UpdateRequestResponseRequestTypeScheduledStartTimeType
    {
        [JsonProperty("display_value")]
        public string DisplayValue { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class UpdateRequestResponseRequestTypeTemplateType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class UpdateRequestResponseRequestTypeRequestTypeType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class UpdateRequestResponseRequestTypeUrgencyType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class UpdateRequestResponseRequestTypeRequestTemplateTaskIdsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class UpdateRequestResponseRequestTypeTechnicianType
    {
        [JsonProperty("email_id")]
        public string EmailId { get; set; }

        [JsonProperty("is_technician")]
        public bool IsTechnician { get; set; }

        [JsonProperty("sms_mail")]
        public string SmsMail { get; set; }

        [JsonProperty("mobile")]
        public string Mobile { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("user_scope")]
        public string UserScope { get; set; }

        [JsonProperty("sms_mail_id")]
        public string SmsMailId { get; set; }

        [JsonProperty("cost_per_hour")]
        public string CostPerHour { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("photo_url")]
        public string PhotoUrl { get; set; }

        [JsonProperty("is_vip_user")]
        public bool IsVipUser { get; set; }

        [JsonProperty("department")]
        public UpdateRequestResponseRequestTypeTechnicianTypeDepartmentType Department { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("job_title")]
        public string JobTitle { get; set; }
    }

    public class UpdateRequestResponseRequestTypeTechnicianTypeDepartmentType
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class UpdateRequestResponseRequestTypeDueByTimeType
    {
        [JsonProperty("display_value")]
        public string DisplayValue { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class UpdateRequestResponseRequestTypeSiteType
    {
        [JsonProperty("deleted")]
        public bool Deleted { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class UpdateRequestResponseRequestTypeCategoryType
    {
        [JsonProperty("deleted")]
        public bool Deleted { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateChangeResponse
    {
        [JsonProperty("response_status")]
        public CreateChangeResponseResponseStatusType ResponseStatus { get; set; }

        [JsonProperty("change")]
        public CreateChangeResponseChangeType Change { get; set; }
    }

    public class CreateChangeResponseResponseStatusType
    {
        [JsonProperty("status_code")]
        public int StatusCode { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class CreateChangeResponseChangeType
    {
        [JsonProperty("roll_out_plan")]
        public CreateChangeResponseChangeTypeRollOutPlanType RollOutPlan { get; set; }

        [JsonProperty("emergency")]
        public bool Emergency { get; set; }

        [JsonProperty("change_type")]
        public CreateChangeResponseChangeTypeChangeTypeType ChangeType { get; set; }

        [JsonProperty("review_details")]
        public CreateChangeResponseChangeTypeReviewDetailsType ReviewDetails { get; set; }

        [JsonProperty("assets")]
        public CreateChangeResponseChangeTypeAssetsTypeItem[] Assets { get; set; }

        [JsonProperty("configuration_items")]
        public JToken[] ConfigurationItems { get; set; }

        [JsonProperty("workflow_instance_details")]
        public CreateChangeResponseChangeTypeWorkflowInstanceDetailsType WorkflowInstanceDetails { get; set; }

        [JsonProperty("rel")]
        public CreateChangeResponseChangeTypeRelType Rel { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("change_requester")]
        public CreateChangeResponseChangeTypeChangeRequesterType ChangeRequester { get; set; }

        [JsonProperty("group")]
        public CreateChangeResponseChangeTypeGroupType Group { get; set; }

        [JsonProperty("created_time")]
        public CreateChangeResponseChangeTypeCreatedTimeType CreatedTime { get; set; }

        [JsonProperty("item")]
        public CreateChangeResponseChangeTypeItemType Item { get; set; }

        [JsonProperty("workflow")]
        public CreateChangeResponseChangeTypeWorkflowType Workflow { get; set; }

        [JsonProperty("approval_status")]
        public string ApprovalStatus { get; set; }

        [JsonProperty("impact")]
        public CreateChangeResponseChangeTypeImpactType Impact { get; set; }

        [JsonProperty("release_details")]
        public CreateChangeResponseChangeTypeReleaseDetailsType ReleaseDetails { get; set; }

        [JsonProperty("priority")]
        public CreateChangeResponseChangeTypePriorityType Priority { get; set; }

        [JsonProperty("scheduled_end_time")]
        public CreateChangeResponseChangeTypeScheduledEndTimeType ScheduledEndTime { get; set; }

        [JsonProperty("uat_details")]
        public CreateChangeResponseChangeTypeUatDetailsType UatDetails { get; set; }

        [JsonProperty("reason_for_change")]
        public CreateChangeResponseChangeTypeReasonForChangeType ReasonForChange { get; set; }

        [JsonProperty("udf_fields")]
        public JToken UdfFields { get; set; }

        [JsonProperty("impact_details")]
        public CreateChangeResponseChangeTypeImpactDetailsType ImpactDetails { get; set; }

        [JsonProperty("subcategory")]
        public CreateChangeResponseChangeTypeSubcategoryType Subcategory { get; set; }

        [JsonProperty("deleted_time")]
        public JToken DeletedTime { get; set; }

        [JsonProperty("is_freeze_conflicted")]
        public bool IsFreezeConflicted { get; set; }

        [JsonProperty("status")]
        public CreateChangeResponseChangeTypeStatusType Status { get; set; }

        [JsonProperty("scheduled_start_time")]
        public CreateChangeResponseChangeTypeScheduledStartTimeType ScheduledStartTime { get; set; }

        [JsonProperty("template")]
        public CreateChangeResponseChangeTypeTemplateType Template { get; set; }

        [JsonProperty("has_release_association")]
        public bool HasReleaseAssociation { get; set; }

        [JsonProperty("attachments")]
        public JToken[] Attachments { get; set; }

        [JsonProperty("display_id")]
        public CreateChangeResponseChangeTypeDisplayIdType DisplayId { get; set; }

        [JsonProperty("roles")]
        public CreateChangeResponseChangeTypeRolesTypeItem[] Roles { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("change_owner")]
        public CreateChangeResponseChangeTypeChangeOwnerType ChangeOwner { get; set; }

        [JsonProperty("urgency")]
        public CreateChangeResponseChangeTypeUrgencyType Urgency { get; set; }

        [JsonProperty("close_details")]
        public CreateChangeResponseChangeTypeCloseDetailsType CloseDetails { get; set; }

        [JsonProperty("change_manager")]
        public string ChangeManager { get; set; }

        [JsonProperty("is_freezed")]
        public bool IsFreezed { get; set; }

        [JsonProperty("retrospective")]
        public bool Retrospective { get; set; }

        [JsonProperty("checklist")]
        public CreateChangeResponseChangeTypeChecklistType Checklist { get; set; }

        [JsonProperty("services")]
        public CreateChangeResponseChangeTypeServicesTypeItem[] Services { get; set; }

        [JsonProperty("back_out_plan")]
        public CreateChangeResponseChangeTypeBackOutPlanType BackOutPlan { get; set; }

        [JsonProperty("site")]
        public CreateChangeResponseChangeTypeSiteType Site { get; set; }

        [JsonProperty("stage")]
        public CreateChangeResponseChangeTypeStageType Stage { get; set; }

        [JsonProperty("completed_time")]
        public CreateChangeResponseChangeTypeCompletedTimeType CompletedTime { get; set; }

        [JsonProperty("risk")]
        public CreateChangeResponseChangeTypeRiskType Risk { get; set; }

        [JsonProperty("category")]
        public CreateChangeResponseChangeTypeCategoryType Category { get; set; }

        [JsonProperty("notes_present")]
        public bool NotesPresent { get; set; }
    }

    public class CreateChangeResponseChangeTypeRollOutPlanType
    {
        [JsonProperty("roll_out_plan_updated_on")]
        public CreateChangeResponseChangeTypeRollOutPlanTypeRollOutPlanUpdatedOnType RollOutPlanUpdatedOn { get; set; }

        [JsonProperty("roll_out_plan_updated_by")]
        public CreateChangeResponseChangeTypeRollOutPlanTypeRollOutPlanUpdatedByType RollOutPlanUpdatedBy { get; set; }

        [JsonProperty("roll_out_plan_description")]
        public string RollOutPlanDescription { get; set; }
    }

    public class CreateChangeResponseChangeTypeRollOutPlanTypeRollOutPlanUpdatedOnType
    {
        [JsonProperty("display_value")]
        public string DisplayValue { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class CreateChangeResponseChangeTypeRollOutPlanTypeRollOutPlanUpdatedByType
    {
        [JsonProperty("email_id")]
        public string EmailId { get; set; }

        [JsonProperty("is_technician")]
        public bool IsTechnician { get; set; }

        [JsonProperty("sms_mail")]
        public string SmsMail { get; set; }

        [JsonProperty("mobile")]
        public string Mobile { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("user_scope")]
        public string UserScope { get; set; }

        [JsonProperty("sms_mail_id")]
        public string SmsMailId { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("photo_url")]
        public string PhotoUrl { get; set; }

        [JsonProperty("is_vip_user")]
        public bool IsVipUser { get; set; }

        [JsonProperty("department")]
        public string Department { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("job_title")]
        public string JobTitle { get; set; }
    }

    public class CreateChangeResponseChangeTypeChangeTypeType
    {
        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("pre_approved")]
        public bool PreApproved { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateChangeResponseChangeTypeReviewDetailsType
    {
        [JsonProperty("next_review_on")]
        public JToken NextReviewOn { get; set; }

        [JsonProperty("review_details_updated_by")]
        public JToken ReviewDetailsUpdatedBy { get; set; }

        [JsonProperty("review_details_updated_on")]
        public JToken ReviewDetailsUpdatedOn { get; set; }

        [JsonProperty("review_details_description")]
        public JToken ReviewDetailsDescription { get; set; }
    }

    public class CreateChangeResponseChangeTypeAssetsTypeItem
    {
        [JsonProperty("site")]
        public JToken Site { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateChangeResponseChangeTypeWorkflowInstanceDetailsType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("status")]
        public CreateChangeResponseChangeTypeWorkflowInstanceDetailsTypeStatusType Status { get; set; }
    }

    public class CreateChangeResponseChangeTypeWorkflowInstanceDetailsTypeStatusType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateChangeResponseChangeTypeRelType
    {
        [JsonProperty("releases")]
        public JToken Releases { get; set; }
    }

    public class CreateChangeResponseChangeTypeChangeRequesterType
    {
        [JsonProperty("email_id")]
        public string EmailId { get; set; }

        [JsonProperty("is_technician")]
        public bool IsTechnician { get; set; }

        [JsonProperty("sms_mail")]
        public string SmsMail { get; set; }

        [JsonProperty("mobile")]
        public string Mobile { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("user_scope")]
        public string UserScope { get; set; }

        [JsonProperty("sms_mail_id")]
        public string SmsMailId { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("photo_url")]
        public string PhotoUrl { get; set; }

        [JsonProperty("is_vip_user")]
        public bool IsVipUser { get; set; }

        [JsonProperty("department")]
        public string Department { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("job_title")]
        public string JobTitle { get; set; }
    }

    public class CreateChangeResponseChangeTypeGroupType
    {
        [JsonProperty("site")]
        public JToken Site { get; set; }

        [JsonProperty("deleted")]
        public bool Deleted { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateChangeResponseChangeTypeCreatedTimeType
    {
        [JsonProperty("display_value")]
        public string DisplayValue { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class CreateChangeResponseChangeTypeItemType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateChangeResponseChangeTypeWorkflowType
    {
        [JsonProperty("validated")]
        public bool Validated { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateChangeResponseChangeTypeImpactType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateChangeResponseChangeTypeReleaseDetailsType
    {
        [JsonProperty("release_actual_start")]
        public JToken ReleaseActualStart { get; set; }

        [JsonProperty("release_actual_end")]
        public JToken ReleaseActualEnd { get; set; }

        [JsonProperty("release_details_description")]
        public string ReleaseDetailsDescription { get; set; }

        [JsonProperty("release_scheduled_end")]
        public CreateChangeResponseChangeTypeReleaseDetailsTypeReleaseScheduledEndType ReleaseScheduledEnd { get; set; }

        [JsonProperty("release_details_updated_on")]
        public CreateChangeResponseChangeTypeReleaseDetailsTypeReleaseDetailsUpdatedOnType ReleaseDetailsUpdatedOn { get; set; }

        [JsonProperty("release_scheduled_start")]
        public CreateChangeResponseChangeTypeReleaseDetailsTypeReleaseScheduledStartType ReleaseScheduledStart { get; set; }

        [JsonProperty("release_details_updated_by")]
        public CreateChangeResponseChangeTypeReleaseDetailsTypeReleaseDetailsUpdatedByType ReleaseDetailsUpdatedBy { get; set; }
    }

    public class CreateChangeResponseChangeTypeReleaseDetailsTypeReleaseScheduledEndType
    {
        [JsonProperty("display_value")]
        public string DisplayValue { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class CreateChangeResponseChangeTypeReleaseDetailsTypeReleaseDetailsUpdatedOnType
    {
        [JsonProperty("display_value")]
        public string DisplayValue { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class CreateChangeResponseChangeTypeReleaseDetailsTypeReleaseScheduledStartType
    {
        [JsonProperty("display_value")]
        public string DisplayValue { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class CreateChangeResponseChangeTypeReleaseDetailsTypeReleaseDetailsUpdatedByType
    {
        [JsonProperty("email_id")]
        public string EmailId { get; set; }

        [JsonProperty("is_technician")]
        public bool IsTechnician { get; set; }

        [JsonProperty("sms_mail")]
        public string SmsMail { get; set; }

        [JsonProperty("mobile")]
        public string Mobile { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("user_scope")]
        public string UserScope { get; set; }

        [JsonProperty("sms_mail_id")]
        public string SmsMailId { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("photo_url")]
        public string PhotoUrl { get; set; }

        [JsonProperty("is_vip_user")]
        public bool IsVipUser { get; set; }

        [JsonProperty("department")]
        public string Department { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("job_title")]
        public string JobTitle { get; set; }
    }

    public class CreateChangeResponseChangeTypePriorityType
    {
        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateChangeResponseChangeTypeScheduledEndTimeType
    {
        [JsonProperty("display_value")]
        public string DisplayValue { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class CreateChangeResponseChangeTypeUatDetailsType
    {
        [JsonProperty("uat_scheduled_start")]
        public JToken UatScheduledStart { get; set; }

        [JsonProperty("uat_actual_end")]
        public JToken UatActualEnd { get; set; }

        [JsonProperty("uat_details_updated_by")]
        public CreateChangeResponseChangeTypeUatDetailsTypeUatDetailsUpdatedByType UatDetailsUpdatedBy { get; set; }

        [JsonProperty("uat_details_description")]
        public string UatDetailsDescription { get; set; }

        [JsonProperty("uat_details_updated_on")]
        public CreateChangeResponseChangeTypeUatDetailsTypeUatDetailsUpdatedOnType UatDetailsUpdatedOn { get; set; }

        [JsonProperty("uat_scheduled_end")]
        public JToken UatScheduledEnd { get; set; }

        [JsonProperty("uat_actual_start")]
        public JToken UatActualStart { get; set; }
    }

    public class CreateChangeResponseChangeTypeUatDetailsTypeUatDetailsUpdatedByType
    {
        [JsonProperty("email_id")]
        public string EmailId { get; set; }

        [JsonProperty("is_technician")]
        public bool IsTechnician { get; set; }

        [JsonProperty("sms_mail")]
        public string SmsMail { get; set; }

        [JsonProperty("mobile")]
        public string Mobile { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("user_scope")]
        public string UserScope { get; set; }

        [JsonProperty("sms_mail_id")]
        public string SmsMailId { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("photo_url")]
        public string PhotoUrl { get; set; }

        [JsonProperty("is_vip_user")]
        public bool IsVipUser { get; set; }

        [JsonProperty("department")]
        public string Department { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("job_title")]
        public string JobTitle { get; set; }
    }

    public class CreateChangeResponseChangeTypeUatDetailsTypeUatDetailsUpdatedOnType
    {
        [JsonProperty("display_value")]
        public string DisplayValue { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class CreateChangeResponseChangeTypeReasonForChangeType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateChangeResponseChangeTypeImpactDetailsType
    {
        [JsonProperty("impact_details_updated_on")]
        public CreateChangeResponseChangeTypeImpactDetailsTypeImpactDetailsUpdatedOnType ImpactDetailsUpdatedOn { get; set; }

        [JsonProperty("impact_details_updated_by")]
        public CreateChangeResponseChangeTypeImpactDetailsTypeImpactDetailsUpdatedByType ImpactDetailsUpdatedBy { get; set; }

        [JsonProperty("impact_details_description")]
        public string ImpactDetailsDescription { get; set; }
    }

    public class CreateChangeResponseChangeTypeImpactDetailsTypeImpactDetailsUpdatedOnType
    {
        [JsonProperty("display_value")]
        public string DisplayValue { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class CreateChangeResponseChangeTypeImpactDetailsTypeImpactDetailsUpdatedByType
    {
        [JsonProperty("email_id")]
        public string EmailId { get; set; }

        [JsonProperty("is_technician")]
        public bool IsTechnician { get; set; }

        [JsonProperty("sms_mail")]
        public string SmsMail { get; set; }

        [JsonProperty("mobile")]
        public string Mobile { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("user_scope")]
        public string UserScope { get; set; }

        [JsonProperty("sms_mail_id")]
        public string SmsMailId { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("photo_url")]
        public string PhotoUrl { get; set; }

        [JsonProperty("is_vip_user")]
        public bool IsVipUser { get; set; }

        [JsonProperty("department")]
        public string Department { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("job_title")]
        public string JobTitle { get; set; }
    }

    public class CreateChangeResponseChangeTypeSubcategoryType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateChangeResponseChangeTypeStatusType
    {
        [JsonProperty("internal_name")]
        public string InternalName { get; set; }

        [JsonProperty("stage")]
        public CreateChangeResponseChangeTypeStatusTypeStageType Stage { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateChangeResponseChangeTypeStatusTypeStageType
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateChangeResponseChangeTypeScheduledStartTimeType
    {
        [JsonProperty("display_value")]
        public string DisplayValue { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class CreateChangeResponseChangeTypeTemplateType
    {
        [JsonProperty("inactive")]
        public bool Inactive { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateChangeResponseChangeTypeDisplayIdType
    {
        [JsonProperty("display_value")]
        public string DisplayValue { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class CreateChangeResponseChangeTypeRolesTypeItem
    {
        [JsonProperty("role")]
        public CreateChangeResponseChangeTypeRolesTypeItemRoleType Role { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("user")]
        public CreateChangeResponseChangeTypeRolesTypeItemUserType User { get; set; }
    }

    public class CreateChangeResponseChangeTypeRolesTypeItemRoleType
    {
        [JsonProperty("internal_name")]
        public string InternalName { get; set; }

        [JsonProperty("user_type")]
        public string UserType { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateChangeResponseChangeTypeRolesTypeItemUserType
    {
        [JsonProperty("email_id")]
        public string EmailId { get; set; }

        [JsonProperty("is_technician")]
        public bool IsTechnician { get; set; }

        [JsonProperty("sms_mail")]
        public string SmsMail { get; set; }

        [JsonProperty("mobile")]
        public string Mobile { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("user_scope")]
        public string UserScope { get; set; }

        [JsonProperty("sms_mail_id")]
        public string SmsMailId { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("photo_url")]
        public string PhotoUrl { get; set; }

        [JsonProperty("is_vip_user")]
        public bool IsVipUser { get; set; }

        [JsonProperty("department")]
        public CreateChangeResponseChangeTypeRolesTypeItemUserTypeDepartmentType Department { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("job_title")]
        public string JobTitle { get; set; }
    }

    public class CreateChangeResponseChangeTypeRolesTypeItemUserTypeDepartmentType
    {
        [JsonProperty("site")]
        public CreateChangeResponseChangeTypeRolesTypeItemUserTypeDepartmentTypeSiteType Site { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateChangeResponseChangeTypeRolesTypeItemUserTypeDepartmentTypeSiteType
    {
        [JsonProperty("deleted")]
        public bool Deleted { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateChangeResponseChangeTypeChangeOwnerType
    {
        [JsonProperty("email_id")]
        public string EmailId { get; set; }

        [JsonProperty("is_technician")]
        public bool IsTechnician { get; set; }

        [JsonProperty("sms_mail")]
        public string SmsMail { get; set; }

        [JsonProperty("mobile")]
        public string Mobile { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("user_scope")]
        public string UserScope { get; set; }

        [JsonProperty("sms_mail_id")]
        public string SmsMailId { get; set; }

        [JsonProperty("cost_per_hour")]
        public string CostPerHour { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("photo_url")]
        public string PhotoUrl { get; set; }

        [JsonProperty("is_vip_user")]
        public bool IsVipUser { get; set; }

        [JsonProperty("department")]
        public string Department { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("job_title")]
        public string JobTitle { get; set; }
    }

    public class CreateChangeResponseChangeTypeUrgencyType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateChangeResponseChangeTypeCloseDetailsType
    {
        [JsonProperty("close_details_updated_on")]
        public CreateChangeResponseChangeTypeCloseDetailsTypeCloseDetailsUpdatedOnType CloseDetailsUpdatedOn { get; set; }

        [JsonProperty("close_details_description")]
        public string CloseDetailsDescription { get; set; }

        [JsonProperty("closure_code")]
        public CreateChangeResponseChangeTypeCloseDetailsTypeClosureCodeType ClosureCode { get; set; }

        [JsonProperty("close_details_updated_by")]
        public CreateChangeResponseChangeTypeCloseDetailsTypeCloseDetailsUpdatedByType CloseDetailsUpdatedBy { get; set; }
    }

    public class CreateChangeResponseChangeTypeCloseDetailsTypeCloseDetailsUpdatedOnType
    {
        [JsonProperty("display_value")]
        public string DisplayValue { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class CreateChangeResponseChangeTypeCloseDetailsTypeClosureCodeType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateChangeResponseChangeTypeCloseDetailsTypeCloseDetailsUpdatedByType
    {
        [JsonProperty("email_id")]
        public string EmailId { get; set; }

        [JsonProperty("is_technician")]
        public bool IsTechnician { get; set; }

        [JsonProperty("sms_mail")]
        public string SmsMail { get; set; }

        [JsonProperty("mobile")]
        public string Mobile { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("user_scope")]
        public string UserScope { get; set; }

        [JsonProperty("sms_mail_id")]
        public string SmsMailId { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("photo_url")]
        public string PhotoUrl { get; set; }

        [JsonProperty("is_vip_user")]
        public bool IsVipUser { get; set; }

        [JsonProperty("department")]
        public string Department { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("job_title")]
        public string JobTitle { get; set; }
    }

    public class CreateChangeResponseChangeTypeChecklistType
    {
        [JsonProperty("checklist_description")]
        public string ChecklistDescription { get; set; }

        [JsonProperty("checklist_updated_on")]
        public CreateChangeResponseChangeTypeChecklistTypeChecklistUpdatedOnType ChecklistUpdatedOn { get; set; }

        [JsonProperty("checklist_updated_by")]
        public CreateChangeResponseChangeTypeChecklistTypeChecklistUpdatedByType ChecklistUpdatedBy { get; set; }
    }

    public class CreateChangeResponseChangeTypeChecklistTypeChecklistUpdatedOnType
    {
        [JsonProperty("display_value")]
        public string DisplayValue { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class CreateChangeResponseChangeTypeChecklistTypeChecklistUpdatedByType
    {
        [JsonProperty("email_id")]
        public string EmailId { get; set; }

        [JsonProperty("is_technician")]
        public bool IsTechnician { get; set; }

        [JsonProperty("sms_mail")]
        public string SmsMail { get; set; }

        [JsonProperty("mobile")]
        public string Mobile { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("user_scope")]
        public string UserScope { get; set; }

        [JsonProperty("sms_mail_id")]
        public string SmsMailId { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("photo_url")]
        public string PhotoUrl { get; set; }

        [JsonProperty("is_vip_user")]
        public bool IsVipUser { get; set; }

        [JsonProperty("department")]
        public string Department { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("job_title")]
        public string JobTitle { get; set; }
    }

    public class CreateChangeResponseChangeTypeServicesTypeItem
    {
        [JsonProperty("inactive")]
        public bool Inactive { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("sort_index")]
        public int SortIndex { get; set; }
    }

    public class CreateChangeResponseChangeTypeBackOutPlanType
    {
        [JsonProperty("back_out_plan_updated_by")]
        public CreateChangeResponseChangeTypeBackOutPlanTypeBackOutPlanUpdatedByType BackOutPlanUpdatedBy { get; set; }

        [JsonProperty("back_out_plan_updated_on")]
        public CreateChangeResponseChangeTypeBackOutPlanTypeBackOutPlanUpdatedOnType BackOutPlanUpdatedOn { get; set; }

        [JsonProperty("back_out_plan_description")]
        public string BackOutPlanDescription { get; set; }
    }

    public class CreateChangeResponseChangeTypeBackOutPlanTypeBackOutPlanUpdatedByType
    {
        [JsonProperty("email_id")]
        public string EmailId { get; set; }

        [JsonProperty("is_technician")]
        public bool IsTechnician { get; set; }

        [JsonProperty("sms_mail")]
        public string SmsMail { get; set; }

        [JsonProperty("mobile")]
        public string Mobile { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("user_scope")]
        public string UserScope { get; set; }

        [JsonProperty("sms_mail_id")]
        public string SmsMailId { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("photo_url")]
        public string PhotoUrl { get; set; }

        [JsonProperty("is_vip_user")]
        public bool IsVipUser { get; set; }

        [JsonProperty("department")]
        public string Department { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("job_title")]
        public string JobTitle { get; set; }
    }

    public class CreateChangeResponseChangeTypeBackOutPlanTypeBackOutPlanUpdatedOnType
    {
        [JsonProperty("display_value")]
        public string DisplayValue { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class CreateChangeResponseChangeTypeSiteType
    {
        [JsonProperty("deleted")]
        public bool Deleted { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateChangeResponseChangeTypeStageType
    {
        [JsonProperty("internal_name")]
        public string InternalName { get; set; }

        [JsonProperty("stage_index")]
        public int StageIndex { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateChangeResponseChangeTypeCompletedTimeType
    {
        [JsonProperty("display_value")]
        public string DisplayValue { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class CreateChangeResponseChangeTypeRiskType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateChangeResponseChangeTypeCategoryType
    {
        [JsonProperty("deleted")]
        public bool Deleted { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class bodyinputDatachangeassetsInputItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class UpdateChangeResponse
    {
        [JsonProperty("response_status")]
        public UpdateChangeResponseResponseStatusType ResponseStatus { get; set; }

        [JsonProperty("change")]
        public UpdateChangeResponseChangeType Change { get; set; }
    }

    public class UpdateChangeResponseResponseStatusType
    {
        [JsonProperty("status_code")]
        public int StatusCode { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class UpdateChangeResponseChangeType
    {
        [JsonProperty("roll_out_plan")]
        public UpdateChangeResponseChangeTypeRollOutPlanType RollOutPlan { get; set; }

        [JsonProperty("emergency")]
        public bool Emergency { get; set; }

        [JsonProperty("change_type")]
        public UpdateChangeResponseChangeTypeChangeTypeType ChangeType { get; set; }

        [JsonProperty("review_details")]
        public UpdateChangeResponseChangeTypeReviewDetailsType ReviewDetails { get; set; }

        [JsonProperty("assets")]
        public UpdateChangeResponseChangeTypeAssetsTypeItem[] Assets { get; set; }

        [JsonProperty("configuration_items")]
        public JToken[] ConfigurationItems { get; set; }

        [JsonProperty("workflow_instance_details")]
        public UpdateChangeResponseChangeTypeWorkflowInstanceDetailsType WorkflowInstanceDetails { get; set; }

        [JsonProperty("rel")]
        public UpdateChangeResponseChangeTypeRelType Rel { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("change_requester")]
        public UpdateChangeResponseChangeTypeChangeRequesterType ChangeRequester { get; set; }

        [JsonProperty("group")]
        public UpdateChangeResponseChangeTypeGroupType Group { get; set; }

        [JsonProperty("created_time")]
        public UpdateChangeResponseChangeTypeCreatedTimeType CreatedTime { get; set; }

        [JsonProperty("item")]
        public UpdateChangeResponseChangeTypeItemType Item { get; set; }

        [JsonProperty("workflow")]
        public UpdateChangeResponseChangeTypeWorkflowType Workflow { get; set; }

        [JsonProperty("approval_status")]
        public string ApprovalStatus { get; set; }

        [JsonProperty("impact")]
        public UpdateChangeResponseChangeTypeImpactType Impact { get; set; }

        [JsonProperty("release_details")]
        public UpdateChangeResponseChangeTypeReleaseDetailsType ReleaseDetails { get; set; }

        [JsonProperty("priority")]
        public UpdateChangeResponseChangeTypePriorityType Priority { get; set; }

        [JsonProperty("scheduled_end_time")]
        public UpdateChangeResponseChangeTypeScheduledEndTimeType ScheduledEndTime { get; set; }

        [JsonProperty("uat_details")]
        public UpdateChangeResponseChangeTypeUatDetailsType UatDetails { get; set; }

        [JsonProperty("reason_for_change")]
        public UpdateChangeResponseChangeTypeReasonForChangeType ReasonForChange { get; set; }

        [JsonProperty("udf_fields")]
        public JToken UdfFields { get; set; }

        [JsonProperty("impact_details")]
        public UpdateChangeResponseChangeTypeImpactDetailsType ImpactDetails { get; set; }

        [JsonProperty("subcategory")]
        public UpdateChangeResponseChangeTypeSubcategoryType Subcategory { get; set; }

        [JsonProperty("deleted_time")]
        public JToken DeletedTime { get; set; }

        [JsonProperty("is_freeze_conflicted")]
        public bool IsFreezeConflicted { get; set; }

        [JsonProperty("status")]
        public UpdateChangeResponseChangeTypeStatusType Status { get; set; }

        [JsonProperty("scheduled_start_time")]
        public UpdateChangeResponseChangeTypeScheduledStartTimeType ScheduledStartTime { get; set; }

        [JsonProperty("template")]
        public UpdateChangeResponseChangeTypeTemplateType Template { get; set; }

        [JsonProperty("has_release_association")]
        public bool HasReleaseAssociation { get; set; }

        [JsonProperty("attachments")]
        public JToken[] Attachments { get; set; }

        [JsonProperty("display_id")]
        public UpdateChangeResponseChangeTypeDisplayIdType DisplayId { get; set; }

        [JsonProperty("roles")]
        public UpdateChangeResponseChangeTypeRolesTypeItem[] Roles { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("change_owner")]
        public UpdateChangeResponseChangeTypeChangeOwnerType ChangeOwner { get; set; }

        [JsonProperty("urgency")]
        public UpdateChangeResponseChangeTypeUrgencyType Urgency { get; set; }

        [JsonProperty("close_details")]
        public UpdateChangeResponseChangeTypeCloseDetailsType CloseDetails { get; set; }

        [JsonProperty("change_manager")]
        public string ChangeManager { get; set; }

        [JsonProperty("is_freezed")]
        public bool IsFreezed { get; set; }

        [JsonProperty("retrospective")]
        public bool Retrospective { get; set; }

        [JsonProperty("checklist")]
        public UpdateChangeResponseChangeTypeChecklistType Checklist { get; set; }

        [JsonProperty("services")]
        public UpdateChangeResponseChangeTypeServicesTypeItem[] Services { get; set; }

        [JsonProperty("back_out_plan")]
        public UpdateChangeResponseChangeTypeBackOutPlanType BackOutPlan { get; set; }

        [JsonProperty("site")]
        public UpdateChangeResponseChangeTypeSiteType Site { get; set; }

        [JsonProperty("stage")]
        public UpdateChangeResponseChangeTypeStageType Stage { get; set; }

        [JsonProperty("completed_time")]
        public UpdateChangeResponseChangeTypeCompletedTimeType CompletedTime { get; set; }

        [JsonProperty("risk")]
        public UpdateChangeResponseChangeTypeRiskType Risk { get; set; }

        [JsonProperty("category")]
        public UpdateChangeResponseChangeTypeCategoryType Category { get; set; }

        [JsonProperty("notes_present")]
        public bool NotesPresent { get; set; }
    }

    public class UpdateChangeResponseChangeTypeRollOutPlanType
    {
        [JsonProperty("roll_out_plan_updated_on")]
        public UpdateChangeResponseChangeTypeRollOutPlanTypeRollOutPlanUpdatedOnType RollOutPlanUpdatedOn { get; set; }

        [JsonProperty("roll_out_plan_updated_by")]
        public UpdateChangeResponseChangeTypeRollOutPlanTypeRollOutPlanUpdatedByType RollOutPlanUpdatedBy { get; set; }

        [JsonProperty("roll_out_plan_description")]
        public string RollOutPlanDescription { get; set; }
    }

    public class UpdateChangeResponseChangeTypeRollOutPlanTypeRollOutPlanUpdatedOnType
    {
        [JsonProperty("display_value")]
        public string DisplayValue { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class UpdateChangeResponseChangeTypeRollOutPlanTypeRollOutPlanUpdatedByType
    {
        [JsonProperty("email_id")]
        public string EmailId { get; set; }

        [JsonProperty("is_technician")]
        public bool IsTechnician { get; set; }

        [JsonProperty("sms_mail")]
        public string SmsMail { get; set; }

        [JsonProperty("mobile")]
        public string Mobile { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("user_scope")]
        public string UserScope { get; set; }

        [JsonProperty("sms_mail_id")]
        public string SmsMailId { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("photo_url")]
        public string PhotoUrl { get; set; }

        [JsonProperty("is_vip_user")]
        public bool IsVipUser { get; set; }

        [JsonProperty("department")]
        public string Department { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("job_title")]
        public string JobTitle { get; set; }
    }

    public class UpdateChangeResponseChangeTypeChangeTypeType
    {
        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("pre_approved")]
        public bool PreApproved { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class UpdateChangeResponseChangeTypeReviewDetailsType
    {
        [JsonProperty("next_review_on")]
        public JToken NextReviewOn { get; set; }

        [JsonProperty("review_details_updated_by")]
        public JToken ReviewDetailsUpdatedBy { get; set; }

        [JsonProperty("review_details_updated_on")]
        public JToken ReviewDetailsUpdatedOn { get; set; }

        [JsonProperty("review_details_description")]
        public JToken ReviewDetailsDescription { get; set; }
    }

    public class UpdateChangeResponseChangeTypeAssetsTypeItem
    {
        [JsonProperty("site")]
        public JToken Site { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class UpdateChangeResponseChangeTypeWorkflowInstanceDetailsType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("status")]
        public UpdateChangeResponseChangeTypeWorkflowInstanceDetailsTypeStatusType Status { get; set; }
    }

    public class UpdateChangeResponseChangeTypeWorkflowInstanceDetailsTypeStatusType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class UpdateChangeResponseChangeTypeRelType
    {
        [JsonProperty("releases")]
        public JToken Releases { get; set; }
    }

    public class UpdateChangeResponseChangeTypeChangeRequesterType
    {
        [JsonProperty("email_id")]
        public string EmailId { get; set; }

        [JsonProperty("is_technician")]
        public bool IsTechnician { get; set; }

        [JsonProperty("sms_mail")]
        public string SmsMail { get; set; }

        [JsonProperty("mobile")]
        public string Mobile { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("user_scope")]
        public string UserScope { get; set; }

        [JsonProperty("sms_mail_id")]
        public string SmsMailId { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("photo_url")]
        public string PhotoUrl { get; set; }

        [JsonProperty("is_vip_user")]
        public bool IsVipUser { get; set; }

        [JsonProperty("department")]
        public string Department { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("job_title")]
        public string JobTitle { get; set; }
    }

    public class UpdateChangeResponseChangeTypeGroupType
    {
        [JsonProperty("site")]
        public JToken Site { get; set; }

        [JsonProperty("deleted")]
        public bool Deleted { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class UpdateChangeResponseChangeTypeCreatedTimeType
    {
        [JsonProperty("display_value")]
        public string DisplayValue { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class UpdateChangeResponseChangeTypeItemType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class UpdateChangeResponseChangeTypeWorkflowType
    {
        [JsonProperty("validated")]
        public bool Validated { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class UpdateChangeResponseChangeTypeImpactType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class UpdateChangeResponseChangeTypeReleaseDetailsType
    {
        [JsonProperty("release_actual_start")]
        public JToken ReleaseActualStart { get; set; }

        [JsonProperty("release_actual_end")]
        public JToken ReleaseActualEnd { get; set; }

        [JsonProperty("release_details_description")]
        public string ReleaseDetailsDescription { get; set; }

        [JsonProperty("release_scheduled_end")]
        public UpdateChangeResponseChangeTypeReleaseDetailsTypeReleaseScheduledEndType ReleaseScheduledEnd { get; set; }

        [JsonProperty("release_details_updated_on")]
        public UpdateChangeResponseChangeTypeReleaseDetailsTypeReleaseDetailsUpdatedOnType ReleaseDetailsUpdatedOn { get; set; }

        [JsonProperty("release_scheduled_start")]
        public UpdateChangeResponseChangeTypeReleaseDetailsTypeReleaseScheduledStartType ReleaseScheduledStart { get; set; }

        [JsonProperty("release_details_updated_by")]
        public UpdateChangeResponseChangeTypeReleaseDetailsTypeReleaseDetailsUpdatedByType ReleaseDetailsUpdatedBy { get; set; }
    }

    public class UpdateChangeResponseChangeTypeReleaseDetailsTypeReleaseScheduledEndType
    {
        [JsonProperty("display_value")]
        public string DisplayValue { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class UpdateChangeResponseChangeTypeReleaseDetailsTypeReleaseDetailsUpdatedOnType
    {
        [JsonProperty("display_value")]
        public string DisplayValue { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class UpdateChangeResponseChangeTypeReleaseDetailsTypeReleaseScheduledStartType
    {
        [JsonProperty("display_value")]
        public string DisplayValue { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class UpdateChangeResponseChangeTypeReleaseDetailsTypeReleaseDetailsUpdatedByType
    {
        [JsonProperty("email_id")]
        public string EmailId { get; set; }

        [JsonProperty("is_technician")]
        public bool IsTechnician { get; set; }

        [JsonProperty("sms_mail")]
        public string SmsMail { get; set; }

        [JsonProperty("mobile")]
        public string Mobile { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("user_scope")]
        public string UserScope { get; set; }

        [JsonProperty("sms_mail_id")]
        public string SmsMailId { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("photo_url")]
        public string PhotoUrl { get; set; }

        [JsonProperty("is_vip_user")]
        public bool IsVipUser { get; set; }

        [JsonProperty("department")]
        public string Department { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("job_title")]
        public string JobTitle { get; set; }
    }

    public class UpdateChangeResponseChangeTypePriorityType
    {
        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class UpdateChangeResponseChangeTypeScheduledEndTimeType
    {
        [JsonProperty("display_value")]
        public string DisplayValue { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class UpdateChangeResponseChangeTypeUatDetailsType
    {
        [JsonProperty("uat_scheduled_start")]
        public JToken UatScheduledStart { get; set; }

        [JsonProperty("uat_actual_end")]
        public JToken UatActualEnd { get; set; }

        [JsonProperty("uat_details_updated_by")]
        public UpdateChangeResponseChangeTypeUatDetailsTypeUatDetailsUpdatedByType UatDetailsUpdatedBy { get; set; }

        [JsonProperty("uat_details_description")]
        public string UatDetailsDescription { get; set; }

        [JsonProperty("uat_details_updated_on")]
        public UpdateChangeResponseChangeTypeUatDetailsTypeUatDetailsUpdatedOnType UatDetailsUpdatedOn { get; set; }

        [JsonProperty("uat_scheduled_end")]
        public JToken UatScheduledEnd { get; set; }

        [JsonProperty("uat_actual_start")]
        public JToken UatActualStart { get; set; }
    }

    public class UpdateChangeResponseChangeTypeUatDetailsTypeUatDetailsUpdatedByType
    {
        [JsonProperty("email_id")]
        public string EmailId { get; set; }

        [JsonProperty("is_technician")]
        public bool IsTechnician { get; set; }

        [JsonProperty("sms_mail")]
        public string SmsMail { get; set; }

        [JsonProperty("mobile")]
        public string Mobile { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("user_scope")]
        public string UserScope { get; set; }

        [JsonProperty("sms_mail_id")]
        public string SmsMailId { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("photo_url")]
        public string PhotoUrl { get; set; }

        [JsonProperty("is_vip_user")]
        public bool IsVipUser { get; set; }

        [JsonProperty("department")]
        public string Department { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("job_title")]
        public string JobTitle { get; set; }
    }

    public class UpdateChangeResponseChangeTypeUatDetailsTypeUatDetailsUpdatedOnType
    {
        [JsonProperty("display_value")]
        public string DisplayValue { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class UpdateChangeResponseChangeTypeReasonForChangeType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class UpdateChangeResponseChangeTypeImpactDetailsType
    {
        [JsonProperty("impact_details_updated_on")]
        public UpdateChangeResponseChangeTypeImpactDetailsTypeImpactDetailsUpdatedOnType ImpactDetailsUpdatedOn { get; set; }

        [JsonProperty("impact_details_updated_by")]
        public UpdateChangeResponseChangeTypeImpactDetailsTypeImpactDetailsUpdatedByType ImpactDetailsUpdatedBy { get; set; }

        [JsonProperty("impact_details_description")]
        public string ImpactDetailsDescription { get; set; }
    }

    public class UpdateChangeResponseChangeTypeImpactDetailsTypeImpactDetailsUpdatedOnType
    {
        [JsonProperty("display_value")]
        public string DisplayValue { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class UpdateChangeResponseChangeTypeImpactDetailsTypeImpactDetailsUpdatedByType
    {
        [JsonProperty("email_id")]
        public string EmailId { get; set; }

        [JsonProperty("is_technician")]
        public bool IsTechnician { get; set; }

        [JsonProperty("sms_mail")]
        public string SmsMail { get; set; }

        [JsonProperty("mobile")]
        public string Mobile { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("user_scope")]
        public string UserScope { get; set; }

        [JsonProperty("sms_mail_id")]
        public string SmsMailId { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("photo_url")]
        public string PhotoUrl { get; set; }

        [JsonProperty("is_vip_user")]
        public bool IsVipUser { get; set; }

        [JsonProperty("department")]
        public string Department { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("job_title")]
        public string JobTitle { get; set; }
    }

    public class UpdateChangeResponseChangeTypeSubcategoryType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class UpdateChangeResponseChangeTypeStatusType
    {
        [JsonProperty("internal_name")]
        public string InternalName { get; set; }

        [JsonProperty("stage")]
        public UpdateChangeResponseChangeTypeStatusTypeStageType Stage { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class UpdateChangeResponseChangeTypeStatusTypeStageType
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class UpdateChangeResponseChangeTypeScheduledStartTimeType
    {
        [JsonProperty("display_value")]
        public string DisplayValue { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class UpdateChangeResponseChangeTypeTemplateType
    {
        [JsonProperty("inactive")]
        public bool Inactive { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class UpdateChangeResponseChangeTypeDisplayIdType
    {
        [JsonProperty("display_value")]
        public string DisplayValue { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class UpdateChangeResponseChangeTypeRolesTypeItem
    {
        [JsonProperty("role")]
        public UpdateChangeResponseChangeTypeRolesTypeItemRoleType Role { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("user")]
        public UpdateChangeResponseChangeTypeRolesTypeItemUserType User { get; set; }
    }

    public class UpdateChangeResponseChangeTypeRolesTypeItemRoleType
    {
        [JsonProperty("internal_name")]
        public string InternalName { get; set; }

        [JsonProperty("user_type")]
        public string UserType { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class UpdateChangeResponseChangeTypeRolesTypeItemUserType
    {
        [JsonProperty("email_id")]
        public string EmailId { get; set; }

        [JsonProperty("is_technician")]
        public bool IsTechnician { get; set; }

        [JsonProperty("sms_mail")]
        public string SmsMail { get; set; }

        [JsonProperty("mobile")]
        public string Mobile { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("user_scope")]
        public string UserScope { get; set; }

        [JsonProperty("sms_mail_id")]
        public string SmsMailId { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("photo_url")]
        public string PhotoUrl { get; set; }

        [JsonProperty("is_vip_user")]
        public bool IsVipUser { get; set; }

        [JsonProperty("department")]
        public UpdateChangeResponseChangeTypeRolesTypeItemUserTypeDepartmentType Department { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("job_title")]
        public string JobTitle { get; set; }
    }

    public class UpdateChangeResponseChangeTypeRolesTypeItemUserTypeDepartmentType
    {
        [JsonProperty("site")]
        public UpdateChangeResponseChangeTypeRolesTypeItemUserTypeDepartmentTypeSiteType Site { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class UpdateChangeResponseChangeTypeRolesTypeItemUserTypeDepartmentTypeSiteType
    {
        [JsonProperty("deleted")]
        public bool Deleted { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class UpdateChangeResponseChangeTypeChangeOwnerType
    {
        [JsonProperty("email_id")]
        public string EmailId { get; set; }

        [JsonProperty("is_technician")]
        public bool IsTechnician { get; set; }

        [JsonProperty("sms_mail")]
        public string SmsMail { get; set; }

        [JsonProperty("mobile")]
        public string Mobile { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("user_scope")]
        public string UserScope { get; set; }

        [JsonProperty("sms_mail_id")]
        public string SmsMailId { get; set; }

        [JsonProperty("cost_per_hour")]
        public string CostPerHour { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("photo_url")]
        public string PhotoUrl { get; set; }

        [JsonProperty("is_vip_user")]
        public bool IsVipUser { get; set; }

        [JsonProperty("department")]
        public string Department { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("job_title")]
        public string JobTitle { get; set; }
    }

    public class UpdateChangeResponseChangeTypeUrgencyType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class UpdateChangeResponseChangeTypeCloseDetailsType
    {
        [JsonProperty("close_details_updated_on")]
        public UpdateChangeResponseChangeTypeCloseDetailsTypeCloseDetailsUpdatedOnType CloseDetailsUpdatedOn { get; set; }

        [JsonProperty("close_details_description")]
        public string CloseDetailsDescription { get; set; }

        [JsonProperty("closure_code")]
        public UpdateChangeResponseChangeTypeCloseDetailsTypeClosureCodeType ClosureCode { get; set; }

        [JsonProperty("close_details_updated_by")]
        public UpdateChangeResponseChangeTypeCloseDetailsTypeCloseDetailsUpdatedByType CloseDetailsUpdatedBy { get; set; }
    }

    public class UpdateChangeResponseChangeTypeCloseDetailsTypeCloseDetailsUpdatedOnType
    {
        [JsonProperty("display_value")]
        public string DisplayValue { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class UpdateChangeResponseChangeTypeCloseDetailsTypeClosureCodeType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class UpdateChangeResponseChangeTypeCloseDetailsTypeCloseDetailsUpdatedByType
    {
        [JsonProperty("email_id")]
        public string EmailId { get; set; }

        [JsonProperty("is_technician")]
        public bool IsTechnician { get; set; }

        [JsonProperty("sms_mail")]
        public string SmsMail { get; set; }

        [JsonProperty("mobile")]
        public string Mobile { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("user_scope")]
        public string UserScope { get; set; }

        [JsonProperty("sms_mail_id")]
        public string SmsMailId { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("photo_url")]
        public string PhotoUrl { get; set; }

        [JsonProperty("is_vip_user")]
        public bool IsVipUser { get; set; }

        [JsonProperty("department")]
        public string Department { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("job_title")]
        public string JobTitle { get; set; }
    }

    public class UpdateChangeResponseChangeTypeChecklistType
    {
        [JsonProperty("checklist_description")]
        public string ChecklistDescription { get; set; }

        [JsonProperty("checklist_updated_on")]
        public UpdateChangeResponseChangeTypeChecklistTypeChecklistUpdatedOnType ChecklistUpdatedOn { get; set; }

        [JsonProperty("checklist_updated_by")]
        public UpdateChangeResponseChangeTypeChecklistTypeChecklistUpdatedByType ChecklistUpdatedBy { get; set; }
    }

    public class UpdateChangeResponseChangeTypeChecklistTypeChecklistUpdatedOnType
    {
        [JsonProperty("display_value")]
        public string DisplayValue { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class UpdateChangeResponseChangeTypeChecklistTypeChecklistUpdatedByType
    {
        [JsonProperty("email_id")]
        public string EmailId { get; set; }

        [JsonProperty("is_technician")]
        public bool IsTechnician { get; set; }

        [JsonProperty("sms_mail")]
        public string SmsMail { get; set; }

        [JsonProperty("mobile")]
        public string Mobile { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("user_scope")]
        public string UserScope { get; set; }

        [JsonProperty("sms_mail_id")]
        public string SmsMailId { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("photo_url")]
        public string PhotoUrl { get; set; }

        [JsonProperty("is_vip_user")]
        public bool IsVipUser { get; set; }

        [JsonProperty("department")]
        public string Department { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("job_title")]
        public string JobTitle { get; set; }
    }

    public class UpdateChangeResponseChangeTypeServicesTypeItem
    {
        [JsonProperty("inactive")]
        public bool Inactive { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("sort_index")]
        public int SortIndex { get; set; }
    }

    public class UpdateChangeResponseChangeTypeBackOutPlanType
    {
        [JsonProperty("back_out_plan_updated_by")]
        public UpdateChangeResponseChangeTypeBackOutPlanTypeBackOutPlanUpdatedByType BackOutPlanUpdatedBy { get; set; }

        [JsonProperty("back_out_plan_updated_on")]
        public UpdateChangeResponseChangeTypeBackOutPlanTypeBackOutPlanUpdatedOnType BackOutPlanUpdatedOn { get; set; }

        [JsonProperty("back_out_plan_description")]
        public string BackOutPlanDescription { get; set; }
    }

    public class UpdateChangeResponseChangeTypeBackOutPlanTypeBackOutPlanUpdatedByType
    {
        [JsonProperty("email_id")]
        public string EmailId { get; set; }

        [JsonProperty("is_technician")]
        public bool IsTechnician { get; set; }

        [JsonProperty("sms_mail")]
        public string SmsMail { get; set; }

        [JsonProperty("mobile")]
        public string Mobile { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("user_scope")]
        public string UserScope { get; set; }

        [JsonProperty("sms_mail_id")]
        public string SmsMailId { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("photo_url")]
        public string PhotoUrl { get; set; }

        [JsonProperty("is_vip_user")]
        public bool IsVipUser { get; set; }

        [JsonProperty("department")]
        public string Department { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("job_title")]
        public string JobTitle { get; set; }
    }

    public class UpdateChangeResponseChangeTypeBackOutPlanTypeBackOutPlanUpdatedOnType
    {
        [JsonProperty("display_value")]
        public string DisplayValue { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class UpdateChangeResponseChangeTypeSiteType
    {
        [JsonProperty("deleted")]
        public bool Deleted { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class UpdateChangeResponseChangeTypeStageType
    {
        [JsonProperty("internal_name")]
        public string InternalName { get; set; }

        [JsonProperty("stage_index")]
        public int StageIndex { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class UpdateChangeResponseChangeTypeCompletedTimeType
    {
        [JsonProperty("display_value")]
        public string DisplayValue { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class UpdateChangeResponseChangeTypeRiskType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class UpdateChangeResponseChangeTypeCategoryType
    {
        [JsonProperty("deleted")]
        public bool Deleted { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Servicedeskpluscloud;

    public partial class WorkflowManagedActions
    {
        public ServicedeskpluscloudActions Servicedeskpluscloud(string connectionId) => new ServicedeskpluscloudActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ServicedeskpluscloudTriggers Servicedeskpluscloud(string connectionId) => new ServicedeskpluscloudTriggers(connectionId);
    }
}