//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Wdatp
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class WdatpActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wdatp")]
        public IBodyWorkflowAction<AdvancedHuntingResponse> AdvancedHunting([WorkflowExpression] Func<string> bodyquery)
        {
            SourceExpression.Validate(bodyquery, nameof(bodyquery), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/advancedqueries/run";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["Query"] = SourceExpressionConverter.ConvertToken(bodyquery);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<AdvancedHuntingResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wdatp")]
        public IBodyWorkflowAction<Alert> CreateAlertByReference([WorkflowExpression] Func<string> bodymachineId, [WorkflowExpression] Func<string> bodyreportId, [WorkflowExpression] Func<string> bodyeventTime, [WorkflowExpression] Func<bodyseverityInput> bodyseverity, [WorkflowExpression] Func<bodycategoryInput> bodycategory, [WorkflowExpression] Func<string> bodytitle, [WorkflowExpression] Func<string> bodydescription, [WorkflowExpression] Func<string> bodyrecommendedAction)
        {
            SourceExpression.Validate(bodymachineId, nameof(bodymachineId), required: true);
            SourceExpression.Validate(bodyreportId, nameof(bodyreportId), required: true);
            SourceExpression.Validate(bodyeventTime, nameof(bodyeventTime), required: true);
            SourceExpression.Validate(bodyseverity, nameof(bodyseverity), required: true);
            SourceExpression.Validate(bodycategory, nameof(bodycategory), required: true);
            SourceExpression.Validate(bodytitle, nameof(bodytitle), required: true);
            SourceExpression.Validate(bodydescription, nameof(bodydescription), required: true);
            SourceExpression.Validate(bodyrecommendedAction, nameof(bodyrecommendedAction), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/alerts/createAlertByReference";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["machineId"] = SourceExpressionConverter.ConvertToken(bodymachineId);
                bodypropCount++;
                body["reportId"] = SourceExpressionConverter.ConvertToken(bodyreportId);
                bodypropCount++;
                body["eventTime"] = SourceExpressionConverter.ConvertToken(bodyeventTime);
                bodypropCount++;
                body["severity"] = SourceExpressionConverter.Convert(bodyseverity);
                bodypropCount++;
                body["category"] = SourceExpressionConverter.Convert(bodycategory);
                bodypropCount++;
                body["title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                bodypropCount++;
                body["description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                bodypropCount++;
                body["recommendedAction"] = SourceExpressionConverter.ConvertToken(bodyrecommendedAction);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<Alert>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wdatp")]
        public IBodyWorkflowAction<GetAlertsResponse> GetAlerts([WorkflowExpression] Func<string> expand = null, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> select = null, [WorkflowExpression] Func<string> orderby = null, [WorkflowExpression] Func<int> top = null, [WorkflowExpression] Func<int> skip = null, [WorkflowExpression] Func<bool> count = null)
        {
            SourceExpression.Validate(expand, nameof(expand), required: false);
            SourceExpression.Validate(filter, nameof(filter), required: false);
            SourceExpression.Validate(select, nameof(select), required: false);
            SourceExpression.Validate(orderby, nameof(orderby), required: false);
            SourceExpression.Validate(top, nameof(top), required: false);
            SourceExpression.Validate(skip, nameof(skip), required: false);
            SourceExpression.Validate(count, nameof(count), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/alerts";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (expand != null)
                    callPayload.Queries["$expand"] = SourceExpressionConverter.ConvertO(expand);
                if (filter != null)
                    callPayload.Queries["$filter"] = SourceExpressionConverter.ConvertO(filter);
                if (select != null)
                    callPayload.Queries["$select"] = SourceExpressionConverter.ConvertO(select);
                if (orderby != null)
                    callPayload.Queries["$orderby"] = SourceExpressionConverter.ConvertO(orderby);
                if (top != null)
                    callPayload.Queries["$top"] = SourceExpressionConverter.ConvertO(top);
                if (skip != null)
                    callPayload.Queries["$skip"] = SourceExpressionConverter.ConvertO(skip);
                if (count != null)
                    callPayload.Queries["$count"] = SourceExpressionConverter.ConvertO(count);
                return callPayload;
            }

            return new ApiConnectionAction<GetAlertsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wdatp")]
        public IBodyWorkflowAction<Alert> GetSingleAlert([WorkflowExpression] Func<string> alertId)
        {
            SourceExpression.Validate(alertId, nameof(alertId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/alerts/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(alertId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<Alert>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wdatp")]
        public IBodyWorkflowAction<Alert> PatchAlert([WorkflowExpression] Func<string> alertId, [WorkflowExpression] Func<bodystatusInput> bodystatus = null, [WorkflowExpression] Func<string> bodyassignedTo = null, [WorkflowExpression] Func<bodyclassificationInput> bodyclassification = null, [WorkflowExpression] Func<bodydeterminationInput> bodydetermination = null)
        {
            SourceExpression.Validate(alertId, nameof(alertId), required: true);
            SourceExpression.Validate(bodystatus, nameof(bodystatus), required: false);
            SourceExpression.Validate(bodyassignedTo, nameof(bodyassignedTo), required: false);
            SourceExpression.Validate(bodyclassification, nameof(bodyclassification), required: false);
            SourceExpression.Validate(bodydetermination, nameof(bodydetermination), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/alerts/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(alertId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodystatus != null)
                {
                    body["status"] = SourceExpressionConverter.Convert(bodystatus);
                    bodypropCount++;
                }

                if (bodyassignedTo != null)
                {
                    body["assignedTo"] = SourceExpressionConverter.ConvertToken(bodyassignedTo);
                    bodypropCount++;
                }

                if (bodyclassification != null)
                {
                    body["classification"] = SourceExpressionConverter.Convert(bodyclassification);
                    bodypropCount++;
                }

                if (bodydetermination != null)
                {
                    body["determination"] = SourceExpressionConverter.Convert(bodydetermination);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<Alert>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wdatp")]
        public IBodyWorkflowAction<InitiateInvestigationResponse> InitiateInvestigation([WorkflowExpression] Func<string> machineId, [WorkflowExpression] Func<string> bodycomment)
        {
            SourceExpression.Validate(machineId, nameof(machineId), required: true);
            SourceExpression.Validate(bodycomment, nameof(bodycomment), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/machines/{0}/initiateInvestigation", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(machineId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["Comment"] = SourceExpressionConverter.ConvertToken(bodycomment);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<InitiateInvestigationResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wdatp")]
        public IBodyWorkflowAction<Investigation> StartInvestigation([WorkflowExpression] Func<string> machineId, [WorkflowExpression] Func<string> bodycomment)
        {
            SourceExpression.Validate(machineId, nameof(machineId), required: true);
            SourceExpression.Validate(bodycomment, nameof(bodycomment), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/machines/{0}/startInvestigation", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(machineId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["Comment"] = SourceExpressionConverter.ConvertToken(bodycomment);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<Investigation>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wdatp")]
        public IBodyWorkflowAction<MachineAction> GetSingleMachineAction([WorkflowExpression] Func<string> machineActionId)
        {
            SourceExpression.Validate(machineActionId, nameof(machineActionId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/machineactions/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(machineActionId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<MachineAction>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wdatp")]
        public IBodyWorkflowAction<MachineAction> CancelSingleMachineAction([WorkflowExpression] Func<string> machineActionId, [WorkflowExpression] Func<string> bodycomment)
        {
            SourceExpression.Validate(machineActionId, nameof(machineActionId), required: true);
            SourceExpression.Validate(bodycomment, nameof(bodycomment), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/machineactions/{0}/cancel", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(machineActionId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["Comment"] = SourceExpressionConverter.ConvertToken(bodycomment);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<MachineAction>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wdatp")]
        public IBodyWorkflowAction<GetLiveResponseDownloadLinkResponse> GetLiveResponseDownloadLink([WorkflowExpression] Func<string> machineActionId, [WorkflowExpression] Func<int> commandIndex)
        {
            SourceExpression.Validate(machineActionId, nameof(machineActionId), required: true);
            SourceExpression.Validate(commandIndex, nameof(commandIndex), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/machineactions/{0}/GetLiveResponseResultDownloadLink(index={1})", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(machineActionId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(commandIndex, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetLiveResponseDownloadLinkResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wdatp")]
        public IBodyWorkflowAction<GetMachineActionsResponse> GetMachineActions([WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> select = null, [WorkflowExpression] Func<string> orderby = null, [WorkflowExpression] Func<int> top = null, [WorkflowExpression] Func<int> skip = null, [WorkflowExpression] Func<bool> count = null)
        {
            SourceExpression.Validate(filter, nameof(filter), required: false);
            SourceExpression.Validate(select, nameof(select), required: false);
            SourceExpression.Validate(orderby, nameof(orderby), required: false);
            SourceExpression.Validate(top, nameof(top), required: false);
            SourceExpression.Validate(skip, nameof(skip), required: false);
            SourceExpression.Validate(count, nameof(count), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/machineactions";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filter != null)
                    callPayload.Queries["$filter"] = SourceExpressionConverter.ConvertO(filter);
                if (select != null)
                    callPayload.Queries["$select"] = SourceExpressionConverter.ConvertO(select);
                if (orderby != null)
                    callPayload.Queries["$orderby"] = SourceExpressionConverter.ConvertO(orderby);
                if (top != null)
                    callPayload.Queries["$top"] = SourceExpressionConverter.ConvertO(top);
                if (skip != null)
                    callPayload.Queries["$skip"] = SourceExpressionConverter.ConvertO(skip);
                if (count != null)
                    callPayload.Queries["$count"] = SourceExpressionConverter.ConvertO(count);
                return callPayload;
            }

            return new ApiConnectionAction<GetMachineActionsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wdatp")]
        public IBodyWorkflowAction<FileStats> GetFileStats([WorkflowExpression] Func<string> fileId, [WorkflowExpression] Func<int> lookBackHours = null)
        {
            SourceExpression.Validate(fileId, nameof(fileId), required: true);
            SourceExpression.Validate(lookBackHours, nameof(lookBackHours), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/files/{0}/stats", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(fileId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["lookBackHours"] = Convert.ToString(24);
                if (lookBackHours != null)
                    callPayload.Queries["lookBackHours"] = SourceExpressionConverter.ConvertO(lookBackHours);
                return callPayload;
            }

            return new ApiConnectionAction<FileStats>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wdatp")]
        public IBodyWorkflowAction<DomainStats> GetDomainStats([WorkflowExpression] Func<string> domainName, [WorkflowExpression] Func<int> lookBackHours = null)
        {
            SourceExpression.Validate(domainName, nameof(domainName), required: true);
            SourceExpression.Validate(lookBackHours, nameof(lookBackHours), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/domains/{0}/stats", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(domainName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["lookBackHours"] = Convert.ToString(24);
                if (lookBackHours != null)
                    callPayload.Queries["lookBackHours"] = SourceExpressionConverter.ConvertO(lookBackHours);
                return callPayload;
            }

            return new ApiConnectionAction<DomainStats>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wdatp")]
        public IBodyWorkflowAction<IpStats> GetIpStats([WorkflowExpression] Func<string> ipAddress, [WorkflowExpression] Func<int> lookBackHours = null)
        {
            SourceExpression.Validate(ipAddress, nameof(ipAddress), required: true);
            SourceExpression.Validate(lookBackHours, nameof(lookBackHours), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/ips/{0}/stats", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(ipAddress, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["lookBackHours"] = Convert.ToString(24);
                if (lookBackHours != null)
                    callPayload.Queries["lookBackHours"] = SourceExpressionConverter.ConvertO(lookBackHours);
                return callPayload;
            }

            return new ApiConnectionAction<IpStats>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wdatp")]
        public IBodyWorkflowAction<Investigation> GetSingleInvestigation([WorkflowExpression] Func<string> investigationId)
        {
            SourceExpression.Validate(investigationId, nameof(investigationId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/investigations/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(investigationId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<Investigation>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wdatp")]
        public IBodyWorkflowAction<GetInvestigationsResponse> GetInvestigations([WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> select = null, [WorkflowExpression] Func<string> orderby = null, [WorkflowExpression] Func<int> top = null, [WorkflowExpression] Func<int> skip = null, [WorkflowExpression] Func<bool> count = null)
        {
            SourceExpression.Validate(filter, nameof(filter), required: false);
            SourceExpression.Validate(select, nameof(select), required: false);
            SourceExpression.Validate(orderby, nameof(orderby), required: false);
            SourceExpression.Validate(top, nameof(top), required: false);
            SourceExpression.Validate(skip, nameof(skip), required: false);
            SourceExpression.Validate(count, nameof(count), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/investigations";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filter != null)
                    callPayload.Queries["$filter"] = SourceExpressionConverter.ConvertO(filter);
                if (select != null)
                    callPayload.Queries["$select"] = SourceExpressionConverter.ConvertO(select);
                if (orderby != null)
                    callPayload.Queries["$orderby"] = SourceExpressionConverter.ConvertO(orderby);
                if (top != null)
                    callPayload.Queries["$top"] = SourceExpressionConverter.ConvertO(top);
                if (skip != null)
                    callPayload.Queries["$skip"] = SourceExpressionConverter.ConvertO(skip);
                if (count != null)
                    callPayload.Queries["$count"] = SourceExpressionConverter.ConvertO(count);
                return callPayload;
            }

            return new ApiConnectionAction<GetInvestigationsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wdatp")]
        public IBodyWorkflowAction<MachineAction> CollectInvestigationPackage([WorkflowExpression] Func<string> machineId, [WorkflowExpression] Func<string> bodycomment)
        {
            SourceExpression.Validate(machineId, nameof(machineId), required: true);
            SourceExpression.Validate(bodycomment, nameof(bodycomment), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/machines/{0}/collectInvestigationPackage", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(machineId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["Comment"] = SourceExpressionConverter.ConvertToken(bodycomment);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<MachineAction>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wdatp")]
        public IBodyWorkflowAction<GetInvestigationPackageUriResponse> GetInvestigationPackageUri([WorkflowExpression] Func<string> machineActionId)
        {
            SourceExpression.Validate(machineActionId, nameof(machineActionId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/machineactions/{0}/getPackageUri", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(machineActionId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetInvestigationPackageUriResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wdatp")]
        public IBodyWorkflowAction<MachineAction> IsolateMachine([WorkflowExpression] Func<string> machineId, [WorkflowExpression] Func<string> bodycomment, [WorkflowExpression] Func<bodyisolationTypeInput> bodyisolationType)
        {
            SourceExpression.Validate(machineId, nameof(machineId), required: true);
            SourceExpression.Validate(bodycomment, nameof(bodycomment), required: true);
            SourceExpression.Validate(bodyisolationType, nameof(bodyisolationType), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/machines/{0}/isolate", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(machineId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["Comment"] = SourceExpressionConverter.ConvertToken(bodycomment);
                bodypropCount++;
                body["IsolationType"] = SourceExpressionConverter.Convert(bodyisolationType);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<MachineAction>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wdatp")]
        public IBodyWorkflowAction<MachineAction> UnisolateMachine([WorkflowExpression] Func<string> machineId, [WorkflowExpression] Func<string> bodycomment)
        {
            SourceExpression.Validate(machineId, nameof(machineId), required: true);
            SourceExpression.Validate(bodycomment, nameof(bodycomment), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/machines/{0}/unisolate", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(machineId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["Comment"] = SourceExpressionConverter.ConvertToken(bodycomment);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<MachineAction>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wdatp")]
        public IBodyWorkflowAction<MachineAction> RestrictAppExecution([WorkflowExpression] Func<string> machineId, [WorkflowExpression] Func<string> bodycomment)
        {
            SourceExpression.Validate(machineId, nameof(machineId), required: true);
            SourceExpression.Validate(bodycomment, nameof(bodycomment), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/machines/{0}/restrictCodeExecution", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(machineId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["Comment"] = SourceExpressionConverter.ConvertToken(bodycomment);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<MachineAction>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wdatp")]
        public IBodyWorkflowAction<MachineAction> UnrestrictAppExecution([WorkflowExpression] Func<string> machineId, [WorkflowExpression] Func<string> bodycomment)
        {
            SourceExpression.Validate(machineId, nameof(machineId), required: true);
            SourceExpression.Validate(bodycomment, nameof(bodycomment), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/machines/{0}/unrestrictCodeExecution", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(machineId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["Comment"] = SourceExpressionConverter.ConvertToken(bodycomment);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<MachineAction>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wdatp")]
        public IBodyWorkflowAction<MachineAction> RunAntivirusScan([WorkflowExpression] Func<string> machineId, [WorkflowExpression] Func<string> bodycomment, [WorkflowExpression] Func<bodyscanTypeInput> bodyscanType)
        {
            SourceExpression.Validate(machineId, nameof(machineId), required: true);
            SourceExpression.Validate(bodycomment, nameof(bodycomment), required: true);
            SourceExpression.Validate(bodyscanType, nameof(bodyscanType), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/machines/{0}/runAntiVirusScan", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(machineId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["Comment"] = SourceExpressionConverter.ConvertToken(bodycomment);
                bodypropCount++;
                body["ScanType"] = SourceExpressionConverter.Convert(bodyscanType);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<MachineAction>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wdatp")]
        public IBodyWorkflowAction<MachineAction> RunLiveResponse([WorkflowExpression] Func<string> machineId, [WorkflowExpression] Func<string> bodycomment, [WorkflowExpression] Func<LiveResponseCommand[]> bodycommands)
        {
            SourceExpression.Validate(machineId, nameof(machineId), required: true);
            SourceExpression.Validate(bodycomment, nameof(bodycomment), required: true);
            SourceExpression.Validate(bodycommands, nameof(bodycommands), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/machines/{0}/runliveresponse", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(machineId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["Comment"] = SourceExpressionConverter.ConvertToken(bodycomment);
                bodypropCount++;
                body["Commands"] = SourceExpressionConverter.ConvertToken(bodycommands);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<MachineAction>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wdatp")]
        public IBodyWorkflowAction<GetRemediationActivitiesResponse> GetRemediationActivities([WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> select = null, [WorkflowExpression] Func<string> orderby = null, [WorkflowExpression] Func<int> top = null, [WorkflowExpression] Func<int> skip = null, [WorkflowExpression] Func<bool> count = null)
        {
            SourceExpression.Validate(filter, nameof(filter), required: false);
            SourceExpression.Validate(select, nameof(select), required: false);
            SourceExpression.Validate(orderby, nameof(orderby), required: false);
            SourceExpression.Validate(top, nameof(top), required: false);
            SourceExpression.Validate(skip, nameof(skip), required: false);
            SourceExpression.Validate(count, nameof(count), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/remediationtasks";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filter != null)
                    callPayload.Queries["$filter"] = SourceExpressionConverter.ConvertO(filter);
                if (select != null)
                    callPayload.Queries["$select"] = SourceExpressionConverter.ConvertO(select);
                if (orderby != null)
                    callPayload.Queries["$orderby"] = SourceExpressionConverter.ConvertO(orderby);
                if (top != null)
                    callPayload.Queries["$top"] = SourceExpressionConverter.ConvertO(top);
                if (skip != null)
                    callPayload.Queries["$skip"] = SourceExpressionConverter.ConvertO(skip);
                if (count != null)
                    callPayload.Queries["$count"] = SourceExpressionConverter.ConvertO(count);
                return callPayload;
            }

            return new ApiConnectionAction<GetRemediationActivitiesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wdatp")]
        public IBodyWorkflowAction<RemediationActivity> GetSingleRemediationActivity([WorkflowExpression] Func<string> remediationId)
        {
            SourceExpression.Validate(remediationId, nameof(remediationId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/remediationtasks/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(remediationId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<RemediationActivity>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wdatp")]
        public IBodyWorkflowAction<GetRemediationActivityMachineListResponse> GetRemediationActivityMachineList([WorkflowExpression] Func<string> remediationId)
        {
            SourceExpression.Validate(remediationId, nameof(remediationId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/remediationtasks/{0}/machinereferences", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(remediationId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetRemediationActivityMachineListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wdatp")]
        public IBodyWorkflowAction<GetMachinesResponse> GetMachines([WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> select = null, [WorkflowExpression] Func<string> orderby = null, [WorkflowExpression] Func<int> top = null, [WorkflowExpression] Func<int> skip = null, [WorkflowExpression] Func<bool> count = null)
        {
            SourceExpression.Validate(filter, nameof(filter), required: false);
            SourceExpression.Validate(select, nameof(select), required: false);
            SourceExpression.Validate(orderby, nameof(orderby), required: false);
            SourceExpression.Validate(top, nameof(top), required: false);
            SourceExpression.Validate(skip, nameof(skip), required: false);
            SourceExpression.Validate(count, nameof(count), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/machines";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filter != null)
                    callPayload.Queries["$filter"] = SourceExpressionConverter.ConvertO(filter);
                if (select != null)
                    callPayload.Queries["$select"] = SourceExpressionConverter.ConvertO(select);
                if (orderby != null)
                    callPayload.Queries["$orderby"] = SourceExpressionConverter.ConvertO(orderby);
                if (top != null)
                    callPayload.Queries["$top"] = SourceExpressionConverter.ConvertO(top);
                if (skip != null)
                    callPayload.Queries["$skip"] = SourceExpressionConverter.ConvertO(skip);
                if (count != null)
                    callPayload.Queries["$count"] = SourceExpressionConverter.ConvertO(count);
                return callPayload;
            }

            return new ApiConnectionAction<GetMachinesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wdatp")]
        public IBodyWorkflowAction<Machine> GetSingleMachine([WorkflowExpression] Func<string> machineId)
        {
            SourceExpression.Validate(machineId, nameof(machineId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/machines/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(machineId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<Machine>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wdatp")]
        public IBodyWorkflowAction<Machine> MachineTag([WorkflowExpression] Func<string> machineId, [WorkflowExpression] Func<string> bodyvalue, [WorkflowExpression] Func<bodyactionInput> bodyaction)
        {
            SourceExpression.Validate(machineId, nameof(machineId), required: true);
            SourceExpression.Validate(bodyvalue, nameof(bodyvalue), required: true);
            SourceExpression.Validate(bodyaction, nameof(bodyaction), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/machines/{0}/tags", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(machineId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["Value"] = SourceExpressionConverter.ConvertToken(bodyvalue);
                bodypropCount++;
                body["Action"] = SourceExpressionConverter.Convert(bodyaction);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<Machine>(BuildSourceInput);
        }
    }

    public class WdatpTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<WebHookSubscriptionTableEntity> WebHooksCreateWebHook(string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/subscriptions";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                request["clientState"] = "flow";
                requestpropCount++;
                request["changeType"] = "created";
                requestpropCount++;
                request["resource"] = "alerts";
                requestpropCount++;
                request["expirationDateTime"] = "2038-09-20T12:00:00Z";
                requestpropCount++;
                request["notificationUrl"] = "#{listCallbackUrl()}";
                requestpropCount++;
                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger<WebHookSubscriptionTableEntity>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<OnNewRemediationActivityResponse> OnNewRemediationActivity(string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/trigger/api/remediationtasks";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["$orderby"] = Convert.ToString("createdOn desc");
                return callPayload;
            }

            return new ApiConnectionTrigger<OnNewRemediationActivityResponse>(BuildSourceInput, triggerName, recurrence);
        }
    }

    public class AdvancedHuntingResponse
    {
        public AdvancedHuntingResponseStatsType Stats { get; set; }
        public JToken[] Results { get; set; }
    }

    public class AdvancedHuntingResponseStatsType
    {
        [JsonProperty("dataset_statistics")]
        public AdvancedHuntingResponseStatsTypeDatasetStatisticsTypeItem[] DatasetStatistics { get; set; }
    }

    public class AdvancedHuntingResponseStatsTypeDatasetStatisticsTypeItem
    {
        [JsonProperty("table_row_count")]
        public int TableRowCount { get; set; }
    }

    public class Alert
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("incidentId")]
        public int IncidentId { get; set; }

        [JsonProperty("investigationId")]
        public int InvestigationId { get; set; }

        [JsonProperty("severity")]
        public AlertSeverityType Severity { get; set; }

        [JsonProperty("status")]
        public AlertStatusType Status { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("alertCreationTime")]
        public string AlertCreationTime { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("threatFamilyName")]
        public string ThreatFamilyName { get; set; }

        [JsonProperty("detectionSource")]
        public string DetectionSource { get; set; }

        [JsonProperty("classification")]
        public AlertClassificationType Classification { get; set; }

        [JsonProperty("determination")]
        public AlertDeterminationType Determination { get; set; }

        [JsonProperty("assignedTo")]
        public string AssignedTo { get; set; }

        [JsonProperty("resolvedTime")]
        public string ResolvedTime { get; set; }

        [JsonProperty("lastEventTime")]
        public string LastEventTime { get; set; }

        [JsonProperty("firstEventTime")]
        public string FirstEventTime { get; set; }

        [JsonProperty("machineId")]
        public string MachineId { get; set; }
    }

    public enum AlertSeverityType
    {
        Informational,
        Low,
        Medium,
        High
    }

    public enum AlertStatusType
    {
        Unspecified,
        New,
        InProgress,
        Resolved,
        Hidden
    }

    public enum AlertClassificationType
    {
        Unknown,
        FalsePositive,
        TruePositive
    }

    public enum AlertDeterminationType
    {
        NotAvailable,
        Apt,
        Malware,
        SecurityPersonnel,
        SecurityTesting,
        UnwantedSoftware,
        Other
    }

    public enum bodyseverityInput
    {
        Low,
        Medium,
        High
    }

    public enum bodycategoryInput
    {
        General,
        CommandAndControl,
        Collection,
        CredentialAccess,
        DefenseEvasion,
        Discovery,
        Exfiltration,
        Exploit,
        Execution,
        InitialAccess,
        LateralMovement,
        Malware,
        Persistence,
        PrivilegeEscalation,
        Ransomware,
        SuspiciousActivity
    }

    public class GetAlertsResponse
    {
        [JsonProperty("@odata.count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public Alert[] Value { get; set; }

        [JsonProperty("@odata.nextLink")]
        public string NextLink { get; set; }
    }

    public enum bodystatusInput
    {
        New,
        InProgress,
        Resolved
    }

    public enum bodyclassificationInput
    {
        Unknown,
        FalsePositive,
        TruePositive
    }

    public enum bodydeterminationInput
    {
        NotAvailable,
        Apt,
        Malware,
        SecurityPersonnel,
        SecurityTesting,
        UnwantedSoftware,
        Other
    }

    public class InitiateInvestigationResponse
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class Investigation
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("state")]
        public InvestigationStateType State { get; set; }

        [JsonProperty("statusDetails")]
        public string StatusDetails { get; set; }

        [JsonProperty("computerDnsName")]
        public string ComputerDnsName { get; set; }

        [JsonProperty("machineId")]
        public string MachineId { get; set; }

        [JsonProperty("startTime")]
        public string StartTime { get; set; }

        [JsonProperty("endTime")]
        public string EndTime { get; set; }
    }

    public enum InvestigationStateType
    {
        Unknown,
        Terminated,
        TerminatedByUser,
        TerminatedBySystem,
        SuccessfullyRemediated,
        Benign,
        Failed,
        PartiallyRemediated,
        Running,
        PendingApproval,
        PendingResource,
        PartiallyInvestigated,
        Disabled,
        Queued,
        InnerFailure,
        PreexistingAlert,
        UnsupportedOs,
        UnsupportedAlertType,
        SuppressedAlert
    }

    public class MachineAction
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public MachineActionTypeType Type { get; set; }

        [JsonProperty("requestor")]
        public string Requestor { get; set; }

        [JsonProperty("requestorComment")]
        public string RequestorComment { get; set; }

        [JsonProperty("status")]
        public MachineActionStatusType Status { get; set; }

        [JsonProperty("machineId")]
        public string MachineId { get; set; }

        [JsonProperty("creationDateTimeUtc")]
        public string CreationDateTimeUtc { get; set; }

        [JsonProperty("lastUpdateDateTimeUtc")]
        public string LastUpdateDateTimeUtc { get; set; }

        [JsonProperty("relatedFileInfo")]
        public MachineActionRelatedFileInfoType RelatedFileInfo { get; set; }

        [JsonProperty("commands")]
        public LiveResponseCommandStatus[] Commands { get; set; }
    }

    public enum MachineActionTypeType
    {
        Unknown,
        RequestSample,
        RunAntiVirusScan,
        Offboard,
        CollectInvestigationPackage,
        Isolate,
        Unisolate,
        StopAndQuarantineFile,
        RestrictCodeExecution,
        UnrestrictCodeExecution,
        LiveResponse
    }

    public enum MachineActionStatusType
    {
        Pending,
        Cancelled,
        TimeOut,
        Failed,
        InProgress,
        Succeeded
    }

    public class MachineActionRelatedFileInfoType
    {
        [JsonProperty("fileIdentifier")]
        public string FileIdentifier { get; set; }

        [JsonProperty("fileIdentifierType")]
        public MachineActionRelatedFileInfoTypeFileIdentifierTypeType FileIdentifierType { get; set; }
    }

    public enum MachineActionRelatedFileInfoTypeFileIdentifierTypeType
    {
        Sha1,
        Sha256,
        Md5
    }

    public class LiveResponseCommandStatus
    {
        [JsonProperty("index")]
        public int Index { get; set; }

        [JsonProperty("startTime")]
        public string StartTime { get; set; }

        [JsonProperty("endTime")]
        public string EndTime { get; set; }

        [JsonProperty("commandStatus")]
        public LiveResponseCommandStatusCommandStatusType CommandStatus { get; set; }

        [JsonProperty("errors")]
        public string[] Errors { get; set; }

        [JsonProperty("command")]
        public JToken Command { get; set; }
    }

    public enum LiveResponseCommandStatusCommandStatusType
    {
        Executing,
        Completed,
        Failed,
        PendingResource,
        Submitted,
        Created
    }

    public class GetLiveResponseDownloadLinkResponse
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class GetMachineActionsResponse
    {
        [JsonProperty("@odata.count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public MachineAction[] Value { get; set; }

        [JsonProperty("@odata.nextLink")]
        public string NextLink { get; set; }
    }

    public class FileStats
    {
        [JsonProperty("sha1")]
        public string Sha1 { get; set; }

        [JsonProperty("globallyPrevalence")]
        public int GloballyPrevalence { get; set; }

        [JsonProperty("globalFirstObserved")]
        public string GlobalFirstObserved { get; set; }

        [JsonProperty("globalLastObserved")]
        public string GlobalLastObserved { get; set; }

        [JsonProperty("organizationPrevalence")]
        public int OrganizationPrevalence { get; set; }

        [JsonProperty("orgFirstSeen")]
        public string OrgFirstSeen { get; set; }

        [JsonProperty("orgLastSeen")]
        public string OrgLastSeen { get; set; }

        [JsonProperty("topFileNames")]
        public string[] TopFileNames { get; set; }
    }

    public class DomainStats
    {
        [JsonProperty("host")]
        public string Host { get; set; }

        [JsonProperty("organizationPrevalence")]
        public int OrganizationPrevalence { get; set; }

        [JsonProperty("orgFirstSeen")]
        public string OrgFirstSeen { get; set; }

        [JsonProperty("orgLastSeen")]
        public string OrgLastSeen { get; set; }
    }

    public class IpStats
    {
        [JsonProperty("ipAddress")]
        public string IpAddress { get; set; }

        [JsonProperty("organizationPrevalence")]
        public int OrganizationPrevalence { get; set; }

        [JsonProperty("orgFirstSeen")]
        public string OrgFirstSeen { get; set; }

        [JsonProperty("orgLastSeen")]
        public string OrgLastSeen { get; set; }
    }

    public class GetInvestigationsResponse
    {
        [JsonProperty("@odata.count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public Investigation[] Value { get; set; }

        [JsonProperty("@odata.nextLink")]
        public string NextLink { get; set; }
    }

    public class GetInvestigationPackageUriResponse
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public enum bodyisolationTypeInput
    {
        Full,
        Selective
    }

    public enum bodyscanTypeInput
    {
        Quick,
        Full
    }

    public class LiveResponseCommand
    {
        [JsonProperty("type")]
        public LiveResponseCommandTypeType Type { get; set; }

        [JsonProperty("params")]
        public LiveResponseCommandParamsTypeItem[] Params { get; set; }
    }

    public enum LiveResponseCommandTypeType
    {
        GetFile,
        RunScript,
        PutFile
    }

    public class LiveResponseCommandParamsTypeItem
    {
        [JsonProperty("key")]
        public LiveResponseCommandParamsTypeItemKeyType Key { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public enum LiveResponseCommandParamsTypeItemKeyType
    {
        FileName,
        ScriptName,
        Args,
        Path
    }

    public class GetRemediationActivitiesResponse
    {
        [JsonProperty("@odata.count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public RemediationActivity[] Value { get; set; }

        [JsonProperty("@odata.nextLink")]
        public string NextLink { get; set; }
    }

    public class RemediationActivity
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("createdOn")]
        public string CreatedOn { get; set; }

        [JsonProperty("statusLastModifiedOn")]
        public string StatusLastModifiedOn { get; set; }

        [JsonProperty("requesterId")]
        public string RequesterId { get; set; }

        [JsonProperty("requesterEmail")]
        public string RequesterEmail { get; set; }

        [JsonProperty("status")]
        public RemediationActivityStatusType Status { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("relatedComponent")]
        public string RelatedComponent { get; set; }

        [JsonProperty("targetDevices")]
        public int TargetDevices { get; set; }

        [JsonProperty("rbacGroupNames")]
        public string[] RbacGroupNames { get; set; }

        [JsonProperty("fixedDevices")]
        public int FixedDevices { get; set; }

        [JsonProperty("requesterNotes")]
        public string RequesterNotes { get; set; }

        [JsonProperty("dueOn")]
        public string DueOn { get; set; }

        [JsonProperty("category")]
        public RemediationActivityCategoryType Category { get; set; }

        [JsonProperty("productivityImpactRemediationType")]
        public RemediationActivityProductivityImpactRemediationTypeType ProductivityImpactRemediationType { get; set; }

        [JsonProperty("priority")]
        public RemediationActivityPriorityType Priority { get; set; }

        [JsonProperty("completionMethod")]
        public RemediationActivityCompletionMethodType CompletionMethod { get; set; }

        [JsonProperty("completerId")]
        public string CompleterId { get; set; }

        [JsonProperty("completerEmail")]
        public string CompleterEmail { get; set; }

        [JsonProperty("scid")]
        public string Scid { get; set; }

        [JsonProperty("type")]
        public RemediationActivityTypeType Type { get; set; }

        [JsonProperty("productId")]
        public string ProductId { get; set; }

        [JsonProperty("vendorId")]
        public string VendorId { get; set; }

        [JsonProperty("nameId")]
        public string NameId { get; set; }

        [JsonProperty("recommendedVersion")]
        public string RecommendedVersion { get; set; }

        [JsonProperty("recommendedVendor")]
        public string RecommendedVendor { get; set; }

        [JsonProperty("recommendedProgram")]
        public string RecommendedProgram { get; set; }
        public string RecommendationReference { get; set; }
    }

    public enum RemediationActivityStatusType
    {
        Active,
        Completed
    }

    public enum RemediationActivityCategoryType
    {
        Software,
        SecurityConfiguration
    }

    public enum RemediationActivityProductivityImpactRemediationTypeType
    {
        AllExposedAssets,
        NonImpactedAssets
    }

    public enum RemediationActivityPriorityType
    {
        Low,
        Medium,
        High
    }

    public enum RemediationActivityCompletionMethodType
    {
        Manual,
        Automatic
    }

    public enum RemediationActivityTypeType
    {
        Update,
        Uninstall,
        ConfigurationChange,
        AttentionRequired,
        Upgrade
    }

    public class GetRemediationActivityMachineListResponse
    {
        [JsonProperty("@odata.count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public Machine[] Value { get; set; }

        [JsonProperty("@odata.nextLink")]
        public string NextLink { get; set; }
    }

    public class Machine
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("computerDnsName")]
        public string ComputerDnsName { get; set; }

        [JsonProperty("firstSeen")]
        public string FirstSeen { get; set; }

        [JsonProperty("lastSeen")]
        public string LastSeen { get; set; }

        [JsonProperty("osPlatform")]
        public string OsPlatform { get; set; }

        [JsonProperty("osVersion")]
        public string OsVersion { get; set; }

        [JsonProperty("systemProductName")]
        public string SystemProductName { get; set; }

        [JsonProperty("lastIpAddress")]
        public string LastIpAddress { get; set; }

        [JsonProperty("lastExternalIpAddress")]
        public string LastExternalIpAddress { get; set; }

        [JsonProperty("agentVersion")]
        public string AgentVersion { get; set; }

        [JsonProperty("osBuild")]
        public int OsBuild { get; set; }

        [JsonProperty("healthStatus")]
        public MachineHealthStatusType HealthStatus { get; set; }

        [JsonProperty("isAadJoined")]
        public bool IsAadJoined { get; set; }

        [JsonProperty("machineTags")]
        public string[] MachineTags { get; set; }

        [JsonProperty("rbacGroupId")]
        public int RbacGroupId { get; set; }

        [JsonProperty("rbacGroupName")]
        public string RbacGroupName { get; set; }

        [JsonProperty("riskScore")]
        public MachineRiskScoreType RiskScore { get; set; }

        [JsonProperty("aadDeviceId")]
        public string AadDeviceId { get; set; }
    }

    public enum MachineHealthStatusType
    {
        Active,
        Inactive,
        ImpairedCommunication,
        NoSensorData,
        NoSensorDataImpairedCommunication,
        Unknown
    }

    public enum MachineRiskScoreType
    {
        None,
        Low,
        Medium,
        High
    }

    public class GetMachinesResponse
    {
        [JsonProperty("@odata.count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public Machine[] Value { get; set; }

        [JsonProperty("@odata.nextLink")]
        public string NextLink { get; set; }
    }

    public enum bodyactionInput
    {
        Add,
        Remove
    }

    public class WebHookSubscriptionTableEntity
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("notificationUrl")]
        public string NotificationUrl { get; set; }

        [JsonProperty("clientState")]
        public string ClientState { get; set; }
    }

    public class OnNewRemediationActivityResponse
    {
        [JsonProperty("@odata.count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public RemediationActivity[] Value { get; set; }

        [JsonProperty("@odata.nextLink")]
        public string NextLink { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Wdatp;

    public partial class WorkflowManagedActions
    {
        public WdatpActions Wdatp(string connectionId) => new WdatpActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public WdatpTriggers Wdatp(string connectionId) => new WdatpTriggers(connectionId);
    }
}