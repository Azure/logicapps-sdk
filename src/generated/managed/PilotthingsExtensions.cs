//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Pilotthings
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class PilotthingsActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        [WorkflowExpressionFactory(nameof(__BuildGetAlerts))]
        public IBodyWorkflowAction<PageAlertRo> GetAlerts([WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null, [WorkflowExpression] Func<string> sortValues = null, [WorkflowExpression] Func<string> sort = null, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<dirInput> dir = null, [WorkflowExpression] Func<string> orFilter = null, [WorkflowExpression] Func<int> dateStart = null, [WorkflowExpression] Func<int> dateEnd = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PageAlertRo> __BuildGetAlerts(WorkflowExpression<int> page = null, WorkflowExpression<int> pageSize = null, WorkflowExpression<string> sortValues = null, WorkflowExpression<string> sort = null, WorkflowExpression<string> filter = null, WorkflowExpression<dirInput> dir = null, WorkflowExpression<string> orFilter = null, WorkflowExpression<int> dateStart = null, WorkflowExpression<int> dateEnd = null)
        {
            WorkflowExpression.Validate(page, nameof(page), required: false);
            WorkflowExpression.Validate(pageSize, nameof(pageSize), required: false);
            WorkflowExpression.Validate(sortValues, nameof(sortValues), required: false);
            WorkflowExpression.Validate(sort, nameof(sort), required: false);
            WorkflowExpression.Validate(filter, nameof(filter), required: false);
            WorkflowExpression.Validate(dir, nameof(dir), required: false);
            WorkflowExpression.Validate(orFilter, nameof(orFilter), required: false);
            WorkflowExpression.Validate(dateStart, nameof(dateStart), required: false);
            WorkflowExpression.Validate(dateEnd, nameof(dateEnd), required: false);
            return new DeferredBodyAction<PageAlertRo>(() =>
            {
                var apiCallPath = "/api/alerts";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(page);
                if (pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(pageSize);
                if (sortValues != null)
                    callPayload.Queries["sortValues"] = ExpressionConverter.Convert(sortValues);
                if (sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(sort);
                if (filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(filter);
                if (dir != null)
                    callPayload.Queries["dir"] = ExpressionConverter.Convert(dir);
                if (orFilter != null)
                    callPayload.Queries["orFilter"] = ExpressionConverter.Convert(orFilter);
                callPayload.Queries["dateStart"] = Convert.ToString(0);
                if (dateStart != null)
                    callPayload.Queries["dateStart"] = ExpressionConverter.Convert(dateStart);
                callPayload.Queries["dateEnd"] = Convert.ToString(0);
                if (dateEnd != null)
                    callPayload.Queries["dateEnd"] = ExpressionConverter.Convert(dateEnd);
                return new ApiConnectionAction<PageAlertRo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateAlertState))]
        public IBodyWorkflowAction<AlertRo> UpdateAlertState([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> paramJson = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AlertRo> __BuildUpdateAlertState(WorkflowExpression<string> id, WorkflowExpression<string> paramJson = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(paramJson, nameof(paramJson), required: false);
            return new DeferredBodyAction<AlertRo>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/alerts/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(paramJson);
                return new ApiConnectionAction<AlertRo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        [WorkflowExpressionFactory(nameof(__BuildGetMeasures))]
        public IBodyWorkflowAction<PageMeasureRo> GetMeasures([WorkflowExpression] Func<bool> detailed = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null, [WorkflowExpression] Func<string> sortValues = null, [WorkflowExpression] Func<string> sort = null, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<dirInput> dir = null, [WorkflowExpression] Func<string> orFilter = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PageMeasureRo> __BuildGetMeasures(WorkflowExpression<bool> detailed = null, WorkflowExpression<int> page = null, WorkflowExpression<int> pageSize = null, WorkflowExpression<string> sortValues = null, WorkflowExpression<string> sort = null, WorkflowExpression<string> filter = null, WorkflowExpression<dirInput> dir = null, WorkflowExpression<string> orFilter = null)
        {
            WorkflowExpression.Validate(detailed, nameof(detailed), required: false);
            WorkflowExpression.Validate(page, nameof(page), required: false);
            WorkflowExpression.Validate(pageSize, nameof(pageSize), required: false);
            WorkflowExpression.Validate(sortValues, nameof(sortValues), required: false);
            WorkflowExpression.Validate(sort, nameof(sort), required: false);
            WorkflowExpression.Validate(filter, nameof(filter), required: false);
            WorkflowExpression.Validate(dir, nameof(dir), required: false);
            WorkflowExpression.Validate(orFilter, nameof(orFilter), required: false);
            return new DeferredBodyAction<PageMeasureRo>(() =>
            {
                var apiCallPath = "/api/measures";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["detailed"] = Convert.ToString(false);
                if (detailed != null)
                    callPayload.Queries["detailed"] = ExpressionConverter.Convert(detailed);
                if (page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(page);
                if (pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(pageSize);
                if (sortValues != null)
                    callPayload.Queries["sortValues"] = ExpressionConverter.Convert(sortValues);
                if (sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(sort);
                if (filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(filter);
                if (dir != null)
                    callPayload.Queries["dir"] = ExpressionConverter.Convert(dir);
                if (orFilter != null)
                    callPayload.Queries["orFilter"] = ExpressionConverter.Convert(orFilter);
                return new ApiConnectionAction<PageMeasureRo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        [WorkflowExpressionFactory(nameof(__BuildGetCount))]
        public IBodyWorkflowAction<CountRo> GetCount([WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null, [WorkflowExpression] Func<string> sortValues = null, [WorkflowExpression] Func<string> sort = null, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<dirInput> dir = null, [WorkflowExpression] Func<string> orFilter = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CountRo> __BuildGetCount(WorkflowExpression<int> page = null, WorkflowExpression<int> pageSize = null, WorkflowExpression<string> sortValues = null, WorkflowExpression<string> sort = null, WorkflowExpression<string> filter = null, WorkflowExpression<dirInput> dir = null, WorkflowExpression<string> orFilter = null)
        {
            WorkflowExpression.Validate(page, nameof(page), required: false);
            WorkflowExpression.Validate(pageSize, nameof(pageSize), required: false);
            WorkflowExpression.Validate(sortValues, nameof(sortValues), required: false);
            WorkflowExpression.Validate(sort, nameof(sort), required: false);
            WorkflowExpression.Validate(filter, nameof(filter), required: false);
            WorkflowExpression.Validate(dir, nameof(dir), required: false);
            WorkflowExpression.Validate(orFilter, nameof(orFilter), required: false);
            return new DeferredBodyAction<CountRo>(() =>
            {
                var apiCallPath = "/api/measures/count";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(page);
                if (pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(pageSize);
                if (sortValues != null)
                    callPayload.Queries["sortValues"] = ExpressionConverter.Convert(sortValues);
                if (sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(sort);
                if (filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(filter);
                if (dir != null)
                    callPayload.Queries["dir"] = ExpressionConverter.Convert(dir);
                if (orFilter != null)
                    callPayload.Queries["orFilter"] = ExpressionConverter.Convert(orFilter);
                return new ApiConnectionAction<CountRo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        [WorkflowExpressionFactory(nameof(__BuildGetMeasure))]
        public IBodyWorkflowAction<MeasureRo> GetMeasure([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<bool> detailed = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MeasureRo> __BuildGetMeasure(WorkflowExpression<string> id, WorkflowExpression<bool> detailed = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(detailed, nameof(detailed), required: false);
            return new DeferredBodyAction<MeasureRo>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/measures/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["detailed"] = Convert.ToString(false);
                if (detailed != null)
                    callPayload.Queries["detailed"] = ExpressionConverter.Convert(detailed);
                return new ApiConnectionAction<MeasureRo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        [WorkflowExpressionFactory(nameof(__BuildGetMessages))]
        public IBodyWorkflowAction<PageMessageRo> GetMessages([WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null, [WorkflowExpression] Func<string> sortValues = null, [WorkflowExpression] Func<string> sort = null, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<dirInput> dir = null, [WorkflowExpression] Func<string> orFilter = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PageMessageRo> __BuildGetMessages(WorkflowExpression<int> page = null, WorkflowExpression<int> pageSize = null, WorkflowExpression<string> sortValues = null, WorkflowExpression<string> sort = null, WorkflowExpression<string> filter = null, WorkflowExpression<dirInput> dir = null, WorkflowExpression<string> orFilter = null)
        {
            WorkflowExpression.Validate(page, nameof(page), required: false);
            WorkflowExpression.Validate(pageSize, nameof(pageSize), required: false);
            WorkflowExpression.Validate(sortValues, nameof(sortValues), required: false);
            WorkflowExpression.Validate(sort, nameof(sort), required: false);
            WorkflowExpression.Validate(filter, nameof(filter), required: false);
            WorkflowExpression.Validate(dir, nameof(dir), required: false);
            WorkflowExpression.Validate(orFilter, nameof(orFilter), required: false);
            return new DeferredBodyAction<PageMessageRo>(() =>
            {
                var apiCallPath = "/api/messages";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(page);
                if (pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(pageSize);
                if (sortValues != null)
                    callPayload.Queries["sortValues"] = ExpressionConverter.Convert(sortValues);
                if (sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(sort);
                if (filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(filter);
                if (dir != null)
                    callPayload.Queries["dir"] = ExpressionConverter.Convert(dir);
                if (orFilter != null)
                    callPayload.Queries["orFilter"] = ExpressionConverter.Convert(orFilter);
                return new ApiConnectionAction<PageMessageRo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        [WorkflowExpressionFactory(nameof(__BuildGetMessagesAndMeasurements))]
        public IBodyWorkflowAction<PageMessageRo> GetMessagesAndMeasurements([WorkflowExpression] Func<string> thingId, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null, [WorkflowExpression] Func<string> sortValues = null, [WorkflowExpression] Func<string> sort = null, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<dirInput> dir = null, [WorkflowExpression] Func<string> orFilter = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PageMessageRo> __BuildGetMessagesAndMeasurements(WorkflowExpression<string> thingId, WorkflowExpression<int> page = null, WorkflowExpression<int> pageSize = null, WorkflowExpression<string> sortValues = null, WorkflowExpression<string> sort = null, WorkflowExpression<string> filter = null, WorkflowExpression<dirInput> dir = null, WorkflowExpression<string> orFilter = null)
        {
            WorkflowExpression.Validate(thingId, nameof(thingId), required: true);
            WorkflowExpression.Validate(page, nameof(page), required: false);
            WorkflowExpression.Validate(pageSize, nameof(pageSize), required: false);
            WorkflowExpression.Validate(sortValues, nameof(sortValues), required: false);
            WorkflowExpression.Validate(sort, nameof(sort), required: false);
            WorkflowExpression.Validate(filter, nameof(filter), required: false);
            WorkflowExpression.Validate(dir, nameof(dir), required: false);
            WorkflowExpression.Validate(orFilter, nameof(orFilter), required: false);
            return new DeferredBodyAction<PageMessageRo>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/messages/things/{0}", ExpressionConverter.ConvertWithUrlEncoding(thingId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(page);
                if (pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(pageSize);
                if (sortValues != null)
                    callPayload.Queries["sortValues"] = ExpressionConverter.Convert(sortValues);
                if (sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(sort);
                if (filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(filter);
                if (dir != null)
                    callPayload.Queries["dir"] = ExpressionConverter.Convert(dir);
                if (orFilter != null)
                    callPayload.Queries["orFilter"] = ExpressionConverter.Convert(orFilter);
                return new ApiConnectionAction<PageMessageRo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        [WorkflowExpressionFactory(nameof(__BuildAddMessage))]
        public IBodyWorkflowAction<MessageRo> AddMessage([WorkflowExpression] Func<string> thingId, [WorkflowExpression] Func<string> messageRobody, [WorkflowExpression] Func<string> messageRocreationDate, [WorkflowExpression] Func<string> messageRoerrorMessage, [WorkflowExpression] Func<double> messageRolatitude, [WorkflowExpression] Func<double> messageRolongitude, [WorkflowExpression] Func<string> messageRometadata, [WorkflowExpression] Func<int> messageRonumber, [WorkflowExpression] Func<messageRoprocessedInput> messageRoprocessed, [WorkflowExpression] Func<string> messageRothingname, [WorkflowExpression] Func<string> messageRotimestamp, [WorkflowExpression] Func<string> messageRotopic, [WorkflowExpression] Func<string> messageRoid = null, [WorkflowExpression] Func<bool> messageRolinkabsolute = null, [WorkflowExpression] Func<string> messageRolinkauthority = null, [WorkflowExpression] Func<string> messageRolinkfragment = null, [WorkflowExpression] Func<string> messageRolinkhost = null, [WorkflowExpression] Func<bool> messageRolinkopaque = null, [WorkflowExpression] Func<string> messageRolinkpath = null, [WorkflowExpression] Func<int> messageRolinkport = null, [WorkflowExpression] Func<string> messageRolinkquery = null, [WorkflowExpression] Func<string> messageRolinkrawAuthority = null, [WorkflowExpression] Func<string> messageRolinkrawFragment = null, [WorkflowExpression] Func<string> messageRolinkrawPath = null, [WorkflowExpression] Func<string> messageRolinkrawQuery = null, [WorkflowExpression] Func<string> messageRolinkrawSchemeSpecificPart = null, [WorkflowExpression] Func<string> messageRolinkrawUserInfo = null, [WorkflowExpression] Func<string> messageRolinkscheme = null, [WorkflowExpression] Func<string> messageRolinkschemeSpecificPart = null, [WorkflowExpression] Func<string> messageRolinkuserInfo = null, [WorkflowExpression] Func<bool> messageRorawMeasurementsarray = null, [WorkflowExpression] Func<bool> messageRorawMeasurementsbigDecimal = null, [WorkflowExpression] Func<bool> messageRorawMeasurementsbigInteger = null, [WorkflowExpression] Func<bool> messageRorawMeasurementsbinary = null, [WorkflowExpression] Func<bool> messageRorawMeasurementsboolean = null, [WorkflowExpression] Func<bool> messageRorawMeasurementscontainerNode = null, [WorkflowExpression] Func<bool> messageRorawMeasurementsdouble = null, [WorkflowExpression] Func<bool> messageRorawMeasurementsfloat = null, [WorkflowExpression] Func<bool> messageRorawMeasurementsfloatingPointNumber = null, [WorkflowExpression] Func<bool> messageRorawMeasurementsint = null, [WorkflowExpression] Func<bool> messageRorawMeasurementsintegralNumber = null, [WorkflowExpression] Func<bool> messageRorawMeasurementsLong = null, [WorkflowExpression] Func<bool> messageRorawMeasurementsmissingNode = null, [WorkflowExpression] Func<messageRorawMeasurementsnodeTypeInput> messageRorawMeasurementsnodeType = null, [WorkflowExpression] Func<bool> messageRorawMeasurementsnull = null, [WorkflowExpression] Func<bool> messageRorawMeasurementsnumber = null, [WorkflowExpression] Func<bool> messageRorawMeasurementsObject = null, [WorkflowExpression] Func<bool> messageRorawMeasurementspojo = null, [WorkflowExpression] Func<bool> messageRorawMeasurementsShort = null, [WorkflowExpression] Func<bool> messageRorawMeasurementstextual = null, [WorkflowExpression] Func<bool> messageRorawMeasurementsvalueNode = null, [WorkflowExpression] Func<string> messageRothingdisplayName = null, [WorkflowExpression] Func<string> messageRothingfixedName = null, [WorkflowExpression] Func<string> messageRothingid = null, [WorkflowExpression] Func<int> messageRothingnbAlerts = null, [WorkflowExpression] Func<ThingTagRo[]> messageRothingtags = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MessageRo> __BuildAddMessage(WorkflowExpression<string> thingId, WorkflowExpression<string> messageRobody, WorkflowExpression<string> messageRocreationDate, WorkflowExpression<string> messageRoerrorMessage, WorkflowExpression<double> messageRolatitude, WorkflowExpression<double> messageRolongitude, WorkflowExpression<string> messageRometadata, WorkflowExpression<int> messageRonumber, WorkflowExpression<messageRoprocessedInput> messageRoprocessed, WorkflowExpression<string> messageRothingname, WorkflowExpression<string> messageRotimestamp, WorkflowExpression<string> messageRotopic, WorkflowExpression<string> messageRoid = null, WorkflowExpression<bool> messageRolinkabsolute = null, WorkflowExpression<string> messageRolinkauthority = null, WorkflowExpression<string> messageRolinkfragment = null, WorkflowExpression<string> messageRolinkhost = null, WorkflowExpression<bool> messageRolinkopaque = null, WorkflowExpression<string> messageRolinkpath = null, WorkflowExpression<int> messageRolinkport = null, WorkflowExpression<string> messageRolinkquery = null, WorkflowExpression<string> messageRolinkrawAuthority = null, WorkflowExpression<string> messageRolinkrawFragment = null, WorkflowExpression<string> messageRolinkrawPath = null, WorkflowExpression<string> messageRolinkrawQuery = null, WorkflowExpression<string> messageRolinkrawSchemeSpecificPart = null, WorkflowExpression<string> messageRolinkrawUserInfo = null, WorkflowExpression<string> messageRolinkscheme = null, WorkflowExpression<string> messageRolinkschemeSpecificPart = null, WorkflowExpression<string> messageRolinkuserInfo = null, WorkflowExpression<bool> messageRorawMeasurementsarray = null, WorkflowExpression<bool> messageRorawMeasurementsbigDecimal = null, WorkflowExpression<bool> messageRorawMeasurementsbigInteger = null, WorkflowExpression<bool> messageRorawMeasurementsbinary = null, WorkflowExpression<bool> messageRorawMeasurementsboolean = null, WorkflowExpression<bool> messageRorawMeasurementscontainerNode = null, WorkflowExpression<bool> messageRorawMeasurementsdouble = null, WorkflowExpression<bool> messageRorawMeasurementsfloat = null, WorkflowExpression<bool> messageRorawMeasurementsfloatingPointNumber = null, WorkflowExpression<bool> messageRorawMeasurementsint = null, WorkflowExpression<bool> messageRorawMeasurementsintegralNumber = null, WorkflowExpression<bool> messageRorawMeasurementsLong = null, WorkflowExpression<bool> messageRorawMeasurementsmissingNode = null, WorkflowExpression<messageRorawMeasurementsnodeTypeInput> messageRorawMeasurementsnodeType = null, WorkflowExpression<bool> messageRorawMeasurementsnull = null, WorkflowExpression<bool> messageRorawMeasurementsnumber = null, WorkflowExpression<bool> messageRorawMeasurementsObject = null, WorkflowExpression<bool> messageRorawMeasurementspojo = null, WorkflowExpression<bool> messageRorawMeasurementsShort = null, WorkflowExpression<bool> messageRorawMeasurementstextual = null, WorkflowExpression<bool> messageRorawMeasurementsvalueNode = null, WorkflowExpression<string> messageRothingdisplayName = null, WorkflowExpression<string> messageRothingfixedName = null, WorkflowExpression<string> messageRothingid = null, WorkflowExpression<int> messageRothingnbAlerts = null, WorkflowExpression<ThingTagRo[]> messageRothingtags = null)
        {
            WorkflowExpression.Validate(thingId, nameof(thingId), required: true);
            WorkflowExpression.Validate(messageRobody, nameof(messageRobody), required: true);
            WorkflowExpression.Validate(messageRocreationDate, nameof(messageRocreationDate), required: true);
            WorkflowExpression.Validate(messageRoerrorMessage, nameof(messageRoerrorMessage), required: true);
            WorkflowExpression.Validate(messageRolatitude, nameof(messageRolatitude), required: true);
            WorkflowExpression.Validate(messageRolongitude, nameof(messageRolongitude), required: true);
            WorkflowExpression.Validate(messageRometadata, nameof(messageRometadata), required: true);
            WorkflowExpression.Validate(messageRonumber, nameof(messageRonumber), required: true);
            WorkflowExpression.Validate(messageRoprocessed, nameof(messageRoprocessed), required: true);
            WorkflowExpression.Validate(messageRothingname, nameof(messageRothingname), required: true);
            WorkflowExpression.Validate(messageRotimestamp, nameof(messageRotimestamp), required: true);
            WorkflowExpression.Validate(messageRotopic, nameof(messageRotopic), required: true);
            WorkflowExpression.Validate(messageRoid, nameof(messageRoid), required: false);
            WorkflowExpression.Validate(messageRolinkabsolute, nameof(messageRolinkabsolute), required: false);
            WorkflowExpression.Validate(messageRolinkauthority, nameof(messageRolinkauthority), required: false);
            WorkflowExpression.Validate(messageRolinkfragment, nameof(messageRolinkfragment), required: false);
            WorkflowExpression.Validate(messageRolinkhost, nameof(messageRolinkhost), required: false);
            WorkflowExpression.Validate(messageRolinkopaque, nameof(messageRolinkopaque), required: false);
            WorkflowExpression.Validate(messageRolinkpath, nameof(messageRolinkpath), required: false);
            WorkflowExpression.Validate(messageRolinkport, nameof(messageRolinkport), required: false);
            WorkflowExpression.Validate(messageRolinkquery, nameof(messageRolinkquery), required: false);
            WorkflowExpression.Validate(messageRolinkrawAuthority, nameof(messageRolinkrawAuthority), required: false);
            WorkflowExpression.Validate(messageRolinkrawFragment, nameof(messageRolinkrawFragment), required: false);
            WorkflowExpression.Validate(messageRolinkrawPath, nameof(messageRolinkrawPath), required: false);
            WorkflowExpression.Validate(messageRolinkrawQuery, nameof(messageRolinkrawQuery), required: false);
            WorkflowExpression.Validate(messageRolinkrawSchemeSpecificPart, nameof(messageRolinkrawSchemeSpecificPart), required: false);
            WorkflowExpression.Validate(messageRolinkrawUserInfo, nameof(messageRolinkrawUserInfo), required: false);
            WorkflowExpression.Validate(messageRolinkscheme, nameof(messageRolinkscheme), required: false);
            WorkflowExpression.Validate(messageRolinkschemeSpecificPart, nameof(messageRolinkschemeSpecificPart), required: false);
            WorkflowExpression.Validate(messageRolinkuserInfo, nameof(messageRolinkuserInfo), required: false);
            WorkflowExpression.Validate(messageRorawMeasurementsarray, nameof(messageRorawMeasurementsarray), required: false);
            WorkflowExpression.Validate(messageRorawMeasurementsbigDecimal, nameof(messageRorawMeasurementsbigDecimal), required: false);
            WorkflowExpression.Validate(messageRorawMeasurementsbigInteger, nameof(messageRorawMeasurementsbigInteger), required: false);
            WorkflowExpression.Validate(messageRorawMeasurementsbinary, nameof(messageRorawMeasurementsbinary), required: false);
            WorkflowExpression.Validate(messageRorawMeasurementsboolean, nameof(messageRorawMeasurementsboolean), required: false);
            WorkflowExpression.Validate(messageRorawMeasurementscontainerNode, nameof(messageRorawMeasurementscontainerNode), required: false);
            WorkflowExpression.Validate(messageRorawMeasurementsdouble, nameof(messageRorawMeasurementsdouble), required: false);
            WorkflowExpression.Validate(messageRorawMeasurementsfloat, nameof(messageRorawMeasurementsfloat), required: false);
            WorkflowExpression.Validate(messageRorawMeasurementsfloatingPointNumber, nameof(messageRorawMeasurementsfloatingPointNumber), required: false);
            WorkflowExpression.Validate(messageRorawMeasurementsint, nameof(messageRorawMeasurementsint), required: false);
            WorkflowExpression.Validate(messageRorawMeasurementsintegralNumber, nameof(messageRorawMeasurementsintegralNumber), required: false);
            WorkflowExpression.Validate(messageRorawMeasurementsLong, nameof(messageRorawMeasurementsLong), required: false);
            WorkflowExpression.Validate(messageRorawMeasurementsmissingNode, nameof(messageRorawMeasurementsmissingNode), required: false);
            WorkflowExpression.Validate(messageRorawMeasurementsnodeType, nameof(messageRorawMeasurementsnodeType), required: false);
            WorkflowExpression.Validate(messageRorawMeasurementsnull, nameof(messageRorawMeasurementsnull), required: false);
            WorkflowExpression.Validate(messageRorawMeasurementsnumber, nameof(messageRorawMeasurementsnumber), required: false);
            WorkflowExpression.Validate(messageRorawMeasurementsObject, nameof(messageRorawMeasurementsObject), required: false);
            WorkflowExpression.Validate(messageRorawMeasurementspojo, nameof(messageRorawMeasurementspojo), required: false);
            WorkflowExpression.Validate(messageRorawMeasurementsShort, nameof(messageRorawMeasurementsShort), required: false);
            WorkflowExpression.Validate(messageRorawMeasurementstextual, nameof(messageRorawMeasurementstextual), required: false);
            WorkflowExpression.Validate(messageRorawMeasurementsvalueNode, nameof(messageRorawMeasurementsvalueNode), required: false);
            WorkflowExpression.Validate(messageRothingdisplayName, nameof(messageRothingdisplayName), required: false);
            WorkflowExpression.Validate(messageRothingfixedName, nameof(messageRothingfixedName), required: false);
            WorkflowExpression.Validate(messageRothingid, nameof(messageRothingid), required: false);
            WorkflowExpression.Validate(messageRothingnbAlerts, nameof(messageRothingnbAlerts), required: false);
            WorkflowExpression.Validate(messageRothingtags, nameof(messageRothingtags), required: false);
            return new DeferredBodyAction<MessageRo>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/messages/things/{0}", ExpressionConverter.ConvertWithUrlEncoding(thingId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var messageRo = new JObject();
                var messageRopropCount = 0;
                messageRopropCount++;
                messageRo["body"] = ExpressionConverter.ConvertO(messageRobody);
                messageRopropCount++;
                messageRo["creationDate"] = ExpressionConverter.ConvertO(messageRocreationDate);
                messageRopropCount++;
                messageRo["errorMessage"] = ExpressionConverter.ConvertO(messageRoerrorMessage);
                if (messageRoid != null)
                {
                    messageRo["id"] = ExpressionConverter.ConvertO(messageRoid);
                    messageRopropCount++;
                }

                messageRopropCount++;
                messageRo["latitude"] = ExpressionConverter.ConvertO(messageRolatitude);
                var linkObject = new JObject();
                var linkObjectpropCount = 0;
                if (messageRolinkabsolute != null)
                {
                    linkObject["absolute"] = ExpressionConverter.ConvertO(messageRolinkabsolute);
                    linkObjectpropCount++;
                }

                if (messageRolinkauthority != null)
                {
                    linkObject["authority"] = ExpressionConverter.ConvertO(messageRolinkauthority);
                    linkObjectpropCount++;
                }

                if (messageRolinkfragment != null)
                {
                    linkObject["fragment"] = ExpressionConverter.ConvertO(messageRolinkfragment);
                    linkObjectpropCount++;
                }

                if (messageRolinkhost != null)
                {
                    linkObject["host"] = ExpressionConverter.ConvertO(messageRolinkhost);
                    linkObjectpropCount++;
                }

                if (messageRolinkopaque != null)
                {
                    linkObject["opaque"] = ExpressionConverter.ConvertO(messageRolinkopaque);
                    linkObjectpropCount++;
                }

                if (messageRolinkpath != null)
                {
                    linkObject["path"] = ExpressionConverter.ConvertO(messageRolinkpath);
                    linkObjectpropCount++;
                }

                if (messageRolinkport != null)
                {
                    linkObject["port"] = ExpressionConverter.ConvertO(messageRolinkport);
                    linkObjectpropCount++;
                }

                if (messageRolinkquery != null)
                {
                    linkObject["query"] = ExpressionConverter.ConvertO(messageRolinkquery);
                    linkObjectpropCount++;
                }

                if (messageRolinkrawAuthority != null)
                {
                    linkObject["rawAuthority"] = ExpressionConverter.ConvertO(messageRolinkrawAuthority);
                    linkObjectpropCount++;
                }

                if (messageRolinkrawFragment != null)
                {
                    linkObject["rawFragment"] = ExpressionConverter.ConvertO(messageRolinkrawFragment);
                    linkObjectpropCount++;
                }

                if (messageRolinkrawPath != null)
                {
                    linkObject["rawPath"] = ExpressionConverter.ConvertO(messageRolinkrawPath);
                    linkObjectpropCount++;
                }

                if (messageRolinkrawQuery != null)
                {
                    linkObject["rawQuery"] = ExpressionConverter.ConvertO(messageRolinkrawQuery);
                    linkObjectpropCount++;
                }

                if (messageRolinkrawSchemeSpecificPart != null)
                {
                    linkObject["rawSchemeSpecificPart"] = ExpressionConverter.ConvertO(messageRolinkrawSchemeSpecificPart);
                    linkObjectpropCount++;
                }

                if (messageRolinkrawUserInfo != null)
                {
                    linkObject["rawUserInfo"] = ExpressionConverter.ConvertO(messageRolinkrawUserInfo);
                    linkObjectpropCount++;
                }

                if (messageRolinkscheme != null)
                {
                    linkObject["scheme"] = ExpressionConverter.ConvertO(messageRolinkscheme);
                    linkObjectpropCount++;
                }

                if (messageRolinkschemeSpecificPart != null)
                {
                    linkObject["schemeSpecificPart"] = ExpressionConverter.ConvertO(messageRolinkschemeSpecificPart);
                    linkObjectpropCount++;
                }

                if (messageRolinkuserInfo != null)
                {
                    linkObject["userInfo"] = ExpressionConverter.ConvertO(messageRolinkuserInfo);
                    linkObjectpropCount++;
                }

                if (linkObjectpropCount > 0)
                {
                    messageRo["link"] = linkObject;
                    messageRopropCount++;
                }

                messageRopropCount++;
                messageRo["longitude"] = ExpressionConverter.ConvertO(messageRolongitude);
                var measurementsObject = new JObject();
                var measurementsObjectpropCount = 0;
                if (measurementsObjectpropCount > 0)
                {
                    messageRo["measurements"] = measurementsObject;
                    messageRopropCount++;
                }

                messageRopropCount++;
                messageRo["metadata"] = ExpressionConverter.ConvertO(messageRometadata);
                messageRopropCount++;
                messageRo["number"] = ExpressionConverter.ConvertO(messageRonumber);
                messageRopropCount++;
                messageRo["processed"] = ExpressionConverter.ConvertO(messageRoprocessed);
                var rawMeasurementsObject = new JObject();
                var rawMeasurementsObjectpropCount = 0;
                if (messageRorawMeasurementsarray != null)
                {
                    rawMeasurementsObject["array"] = ExpressionConverter.ConvertO(messageRorawMeasurementsarray);
                    rawMeasurementsObjectpropCount++;
                }

                if (messageRorawMeasurementsbigDecimal != null)
                {
                    rawMeasurementsObject["bigDecimal"] = ExpressionConverter.ConvertO(messageRorawMeasurementsbigDecimal);
                    rawMeasurementsObjectpropCount++;
                }

                if (messageRorawMeasurementsbigInteger != null)
                {
                    rawMeasurementsObject["bigInteger"] = ExpressionConverter.ConvertO(messageRorawMeasurementsbigInteger);
                    rawMeasurementsObjectpropCount++;
                }

                if (messageRorawMeasurementsbinary != null)
                {
                    rawMeasurementsObject["binary"] = ExpressionConverter.ConvertO(messageRorawMeasurementsbinary);
                    rawMeasurementsObjectpropCount++;
                }

                if (messageRorawMeasurementsboolean != null)
                {
                    rawMeasurementsObject["boolean"] = ExpressionConverter.ConvertO(messageRorawMeasurementsboolean);
                    rawMeasurementsObjectpropCount++;
                }

                if (messageRorawMeasurementscontainerNode != null)
                {
                    rawMeasurementsObject["containerNode"] = ExpressionConverter.ConvertO(messageRorawMeasurementscontainerNode);
                    rawMeasurementsObjectpropCount++;
                }

                if (messageRorawMeasurementsdouble != null)
                {
                    rawMeasurementsObject["double"] = ExpressionConverter.ConvertO(messageRorawMeasurementsdouble);
                    rawMeasurementsObjectpropCount++;
                }

                if (messageRorawMeasurementsfloat != null)
                {
                    rawMeasurementsObject["float"] = ExpressionConverter.ConvertO(messageRorawMeasurementsfloat);
                    rawMeasurementsObjectpropCount++;
                }

                if (messageRorawMeasurementsfloatingPointNumber != null)
                {
                    rawMeasurementsObject["floatingPointNumber"] = ExpressionConverter.ConvertO(messageRorawMeasurementsfloatingPointNumber);
                    rawMeasurementsObjectpropCount++;
                }

                if (messageRorawMeasurementsint != null)
                {
                    rawMeasurementsObject["int"] = ExpressionConverter.ConvertO(messageRorawMeasurementsint);
                    rawMeasurementsObjectpropCount++;
                }

                if (messageRorawMeasurementsintegralNumber != null)
                {
                    rawMeasurementsObject["integralNumber"] = ExpressionConverter.ConvertO(messageRorawMeasurementsintegralNumber);
                    rawMeasurementsObjectpropCount++;
                }

                if (messageRorawMeasurementsLong != null)
                {
                    rawMeasurementsObject["long"] = ExpressionConverter.ConvertO(messageRorawMeasurementsLong);
                    rawMeasurementsObjectpropCount++;
                }

                if (messageRorawMeasurementsmissingNode != null)
                {
                    rawMeasurementsObject["missingNode"] = ExpressionConverter.ConvertO(messageRorawMeasurementsmissingNode);
                    rawMeasurementsObjectpropCount++;
                }

                if (messageRorawMeasurementsnodeType != null)
                {
                    rawMeasurementsObject["nodeType"] = ExpressionConverter.ConvertO(messageRorawMeasurementsnodeType);
                    rawMeasurementsObjectpropCount++;
                }

                if (messageRorawMeasurementsnull != null)
                {
                    rawMeasurementsObject["null"] = ExpressionConverter.ConvertO(messageRorawMeasurementsnull);
                    rawMeasurementsObjectpropCount++;
                }

                if (messageRorawMeasurementsnumber != null)
                {
                    rawMeasurementsObject["number"] = ExpressionConverter.ConvertO(messageRorawMeasurementsnumber);
                    rawMeasurementsObjectpropCount++;
                }

                if (messageRorawMeasurementsObject != null)
                {
                    rawMeasurementsObject["object"] = ExpressionConverter.ConvertO(messageRorawMeasurementsObject);
                    rawMeasurementsObjectpropCount++;
                }

                if (messageRorawMeasurementspojo != null)
                {
                    rawMeasurementsObject["pojo"] = ExpressionConverter.ConvertO(messageRorawMeasurementspojo);
                    rawMeasurementsObjectpropCount++;
                }

                if (messageRorawMeasurementsShort != null)
                {
                    rawMeasurementsObject["short"] = ExpressionConverter.ConvertO(messageRorawMeasurementsShort);
                    rawMeasurementsObjectpropCount++;
                }

                if (messageRorawMeasurementstextual != null)
                {
                    rawMeasurementsObject["textual"] = ExpressionConverter.ConvertO(messageRorawMeasurementstextual);
                    rawMeasurementsObjectpropCount++;
                }

                if (messageRorawMeasurementsvalueNode != null)
                {
                    rawMeasurementsObject["valueNode"] = ExpressionConverter.ConvertO(messageRorawMeasurementsvalueNode);
                    rawMeasurementsObjectpropCount++;
                }

                if (rawMeasurementsObjectpropCount > 0)
                {
                    messageRo["rawMeasurements"] = rawMeasurementsObject;
                    messageRopropCount++;
                }

                var thingObject = new JObject();
                var thingObjectpropCount = 0;
                if (messageRothingdisplayName != null)
                {
                    thingObject["displayName"] = ExpressionConverter.ConvertO(messageRothingdisplayName);
                    thingObjectpropCount++;
                }

                if (messageRothingfixedName != null)
                {
                    thingObject["fixedName"] = ExpressionConverter.ConvertO(messageRothingfixedName);
                    thingObjectpropCount++;
                }

                if (messageRothingid != null)
                {
                    thingObject["id"] = ExpressionConverter.ConvertO(messageRothingid);
                    thingObjectpropCount++;
                }

                thingObjectpropCount++;
                thingObject["name"] = ExpressionConverter.ConvertO(messageRothingname);
                if (messageRothingnbAlerts != null)
                {
                    thingObject["nbAlerts"] = ExpressionConverter.ConvertO(messageRothingnbAlerts);
                    thingObjectpropCount++;
                }

                if (messageRothingtags != null)
                {
                    thingObject["tags"] = ExpressionConverter.ConvertO(messageRothingtags);
                    thingObjectpropCount++;
                }

                if (thingObjectpropCount > 0)
                {
                    messageRo["thing"] = thingObject;
                    messageRopropCount++;
                }

                messageRopropCount++;
                messageRo["timestamp"] = ExpressionConverter.ConvertO(messageRotimestamp);
                messageRopropCount++;
                messageRo["topic"] = ExpressionConverter.ConvertO(messageRotopic);
                if (messageRopropCount > 0)
                {
                    callPayload.Body = messageRo;
                }

                return new ApiConnectionAction<MessageRo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        [WorkflowExpressionFactory(nameof(__BuildGetMessage))]
        public IBodyWorkflowAction<MessageRo> GetMessage([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MessageRo> __BuildGetMessage(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<MessageRo>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/messages/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<MessageRo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        [WorkflowExpressionFactory(nameof(__BuildGetPreviousMessage))]
        public IBodyWorkflowAction<MessageRo> GetPreviousMessage([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MessageRo> __BuildGetPreviousMessage(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<MessageRo>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/messages/{0}/previous", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<MessageRo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        [WorkflowExpressionFactory(nameof(__BuildGetSites))]
        public IBodyWorkflowAction<PageSiteRo> GetSites([WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null, [WorkflowExpression] Func<string> sortValues = null, [WorkflowExpression] Func<string> sort = null, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<dirInput> dir = null, [WorkflowExpression] Func<string> orFilter = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PageSiteRo> __BuildGetSites(WorkflowExpression<int> page = null, WorkflowExpression<int> pageSize = null, WorkflowExpression<string> sortValues = null, WorkflowExpression<string> sort = null, WorkflowExpression<string> filter = null, WorkflowExpression<dirInput> dir = null, WorkflowExpression<string> orFilter = null)
        {
            WorkflowExpression.Validate(page, nameof(page), required: false);
            WorkflowExpression.Validate(pageSize, nameof(pageSize), required: false);
            WorkflowExpression.Validate(sortValues, nameof(sortValues), required: false);
            WorkflowExpression.Validate(sort, nameof(sort), required: false);
            WorkflowExpression.Validate(filter, nameof(filter), required: false);
            WorkflowExpression.Validate(dir, nameof(dir), required: false);
            WorkflowExpression.Validate(orFilter, nameof(orFilter), required: false);
            return new DeferredBodyAction<PageSiteRo>(() =>
            {
                var apiCallPath = "/api/sites";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(page);
                if (pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(pageSize);
                if (sortValues != null)
                    callPayload.Queries["sortValues"] = ExpressionConverter.Convert(sortValues);
                if (sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(sort);
                if (filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(filter);
                if (dir != null)
                    callPayload.Queries["dir"] = ExpressionConverter.Convert(dir);
                if (orFilter != null)
                    callPayload.Queries["orFilter"] = ExpressionConverter.Convert(orFilter);
                return new ApiConnectionAction<PageSiteRo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        [WorkflowExpressionFactory(nameof(__BuildCreateSite))]
        public IBodyWorkflowAction<SiteRo[]> CreateSite([WorkflowExpression] Func<bool> nodearray = null, [WorkflowExpression] Func<bool> nodebigDecimal = null, [WorkflowExpression] Func<bool> nodebigInteger = null, [WorkflowExpression] Func<bool> nodebinary = null, [WorkflowExpression] Func<bool> nodeboolean = null, [WorkflowExpression] Func<bool> nodecontainerNode = null, [WorkflowExpression] Func<bool> nodedouble = null, [WorkflowExpression] Func<bool> nodefloat = null, [WorkflowExpression] Func<bool> nodefloatingPointNumber = null, [WorkflowExpression] Func<bool> nodeint = null, [WorkflowExpression] Func<bool> nodeintegralNumber = null, [WorkflowExpression] Func<bool> nodeLong = null, [WorkflowExpression] Func<bool> nodemissingNode = null, [WorkflowExpression] Func<nodenodeTypeInput> nodenodeType = null, [WorkflowExpression] Func<bool> nodenull = null, [WorkflowExpression] Func<bool> nodenumber = null, [WorkflowExpression] Func<bool> nodeObject = null, [WorkflowExpression] Func<bool> nodepojo = null, [WorkflowExpression] Func<bool> nodeShort = null, [WorkflowExpression] Func<bool> nodetextual = null, [WorkflowExpression] Func<bool> nodevalueNode = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SiteRo[]> __BuildCreateSite(WorkflowExpression<bool> nodearray = null, WorkflowExpression<bool> nodebigDecimal = null, WorkflowExpression<bool> nodebigInteger = null, WorkflowExpression<bool> nodebinary = null, WorkflowExpression<bool> nodeboolean = null, WorkflowExpression<bool> nodecontainerNode = null, WorkflowExpression<bool> nodedouble = null, WorkflowExpression<bool> nodefloat = null, WorkflowExpression<bool> nodefloatingPointNumber = null, WorkflowExpression<bool> nodeint = null, WorkflowExpression<bool> nodeintegralNumber = null, WorkflowExpression<bool> nodeLong = null, WorkflowExpression<bool> nodemissingNode = null, WorkflowExpression<nodenodeTypeInput> nodenodeType = null, WorkflowExpression<bool> nodenull = null, WorkflowExpression<bool> nodenumber = null, WorkflowExpression<bool> nodeObject = null, WorkflowExpression<bool> nodepojo = null, WorkflowExpression<bool> nodeShort = null, WorkflowExpression<bool> nodetextual = null, WorkflowExpression<bool> nodevalueNode = null)
        {
            WorkflowExpression.Validate(nodearray, nameof(nodearray), required: false);
            WorkflowExpression.Validate(nodebigDecimal, nameof(nodebigDecimal), required: false);
            WorkflowExpression.Validate(nodebigInteger, nameof(nodebigInteger), required: false);
            WorkflowExpression.Validate(nodebinary, nameof(nodebinary), required: false);
            WorkflowExpression.Validate(nodeboolean, nameof(nodeboolean), required: false);
            WorkflowExpression.Validate(nodecontainerNode, nameof(nodecontainerNode), required: false);
            WorkflowExpression.Validate(nodedouble, nameof(nodedouble), required: false);
            WorkflowExpression.Validate(nodefloat, nameof(nodefloat), required: false);
            WorkflowExpression.Validate(nodefloatingPointNumber, nameof(nodefloatingPointNumber), required: false);
            WorkflowExpression.Validate(nodeint, nameof(nodeint), required: false);
            WorkflowExpression.Validate(nodeintegralNumber, nameof(nodeintegralNumber), required: false);
            WorkflowExpression.Validate(nodeLong, nameof(nodeLong), required: false);
            WorkflowExpression.Validate(nodemissingNode, nameof(nodemissingNode), required: false);
            WorkflowExpression.Validate(nodenodeType, nameof(nodenodeType), required: false);
            WorkflowExpression.Validate(nodenull, nameof(nodenull), required: false);
            WorkflowExpression.Validate(nodenumber, nameof(nodenumber), required: false);
            WorkflowExpression.Validate(nodeObject, nameof(nodeObject), required: false);
            WorkflowExpression.Validate(nodepojo, nameof(nodepojo), required: false);
            WorkflowExpression.Validate(nodeShort, nameof(nodeShort), required: false);
            WorkflowExpression.Validate(nodetextual, nameof(nodetextual), required: false);
            WorkflowExpression.Validate(nodevalueNode, nameof(nodevalueNode), required: false);
            return new DeferredBodyAction<SiteRo[]>(() =>
            {
                var apiCallPath = "/api/sites";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var node = new JObject();
                var nodepropCount = 0;
                if (nodearray != null)
                {
                    node["array"] = ExpressionConverter.ConvertO(nodearray);
                    nodepropCount++;
                }

                if (nodebigDecimal != null)
                {
                    node["bigDecimal"] = ExpressionConverter.ConvertO(nodebigDecimal);
                    nodepropCount++;
                }

                if (nodebigInteger != null)
                {
                    node["bigInteger"] = ExpressionConverter.ConvertO(nodebigInteger);
                    nodepropCount++;
                }

                if (nodebinary != null)
                {
                    node["binary"] = ExpressionConverter.ConvertO(nodebinary);
                    nodepropCount++;
                }

                if (nodeboolean != null)
                {
                    node["boolean"] = ExpressionConverter.ConvertO(nodeboolean);
                    nodepropCount++;
                }

                if (nodecontainerNode != null)
                {
                    node["containerNode"] = ExpressionConverter.ConvertO(nodecontainerNode);
                    nodepropCount++;
                }

                if (nodedouble != null)
                {
                    node["double"] = ExpressionConverter.ConvertO(nodedouble);
                    nodepropCount++;
                }

                if (nodefloat != null)
                {
                    node["float"] = ExpressionConverter.ConvertO(nodefloat);
                    nodepropCount++;
                }

                if (nodefloatingPointNumber != null)
                {
                    node["floatingPointNumber"] = ExpressionConverter.ConvertO(nodefloatingPointNumber);
                    nodepropCount++;
                }

                if (nodeint != null)
                {
                    node["int"] = ExpressionConverter.ConvertO(nodeint);
                    nodepropCount++;
                }

                if (nodeintegralNumber != null)
                {
                    node["integralNumber"] = ExpressionConverter.ConvertO(nodeintegralNumber);
                    nodepropCount++;
                }

                if (nodeLong != null)
                {
                    node["long"] = ExpressionConverter.ConvertO(nodeLong);
                    nodepropCount++;
                }

                if (nodemissingNode != null)
                {
                    node["missingNode"] = ExpressionConverter.ConvertO(nodemissingNode);
                    nodepropCount++;
                }

                if (nodenodeType != null)
                {
                    node["nodeType"] = ExpressionConverter.ConvertO(nodenodeType);
                    nodepropCount++;
                }

                if (nodenull != null)
                {
                    node["null"] = ExpressionConverter.ConvertO(nodenull);
                    nodepropCount++;
                }

                if (nodenumber != null)
                {
                    node["number"] = ExpressionConverter.ConvertO(nodenumber);
                    nodepropCount++;
                }

                if (nodeObject != null)
                {
                    node["object"] = ExpressionConverter.ConvertO(nodeObject);
                    nodepropCount++;
                }

                if (nodepojo != null)
                {
                    node["pojo"] = ExpressionConverter.ConvertO(nodepojo);
                    nodepropCount++;
                }

                if (nodeShort != null)
                {
                    node["short"] = ExpressionConverter.ConvertO(nodeShort);
                    nodepropCount++;
                }

                if (nodetextual != null)
                {
                    node["textual"] = ExpressionConverter.ConvertO(nodetextual);
                    nodepropCount++;
                }

                if (nodevalueNode != null)
                {
                    node["valueNode"] = ExpressionConverter.ConvertO(nodevalueNode);
                    nodepropCount++;
                }

                if (nodepropCount > 0)
                {
                    callPayload.Body = node;
                }

                return new ApiConnectionAction<SiteRo[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        [WorkflowExpressionFactory(nameof(__BuildGetSite))]
        public IBodyWorkflowAction<SiteRo> GetSite([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SiteRo> __BuildGetSite(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<SiteRo>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/sites/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SiteRo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteSite))]
        public IWorkflowAction DeleteSite([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeleteSite(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/sites/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateSite))]
        public IBodyWorkflowAction<SiteRo> UpdateSite([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> siteRoaddress, [WorkflowExpression] Func<string> siteRocity, [WorkflowExpression] Func<string> siteRoname, [WorkflowExpression] Func<string> siteRopostalCode, [WorkflowExpression] Func<string> siteRoid = null, [WorkflowExpression] Func<double> siteRolatitude = null, [WorkflowExpression] Func<double> siteRolongitude = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SiteRo> __BuildUpdateSite(WorkflowExpression<string> id, WorkflowExpression<string> siteRoaddress, WorkflowExpression<string> siteRocity, WorkflowExpression<string> siteRoname, WorkflowExpression<string> siteRopostalCode, WorkflowExpression<string> siteRoid = null, WorkflowExpression<double> siteRolatitude = null, WorkflowExpression<double> siteRolongitude = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(siteRoaddress, nameof(siteRoaddress), required: true);
            WorkflowExpression.Validate(siteRocity, nameof(siteRocity), required: true);
            WorkflowExpression.Validate(siteRoname, nameof(siteRoname), required: true);
            WorkflowExpression.Validate(siteRopostalCode, nameof(siteRopostalCode), required: true);
            WorkflowExpression.Validate(siteRoid, nameof(siteRoid), required: false);
            WorkflowExpression.Validate(siteRolatitude, nameof(siteRolatitude), required: false);
            WorkflowExpression.Validate(siteRolongitude, nameof(siteRolongitude), required: false);
            return new DeferredBodyAction<SiteRo>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/sites/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var siteRo = new JObject();
                var siteRopropCount = 0;
                siteRopropCount++;
                siteRo["address"] = ExpressionConverter.ConvertO(siteRoaddress);
                siteRopropCount++;
                siteRo["city"] = ExpressionConverter.ConvertO(siteRocity);
                if (siteRoid != null)
                {
                    siteRo["id"] = ExpressionConverter.ConvertO(siteRoid);
                    siteRopropCount++;
                }

                if (siteRolatitude != null)
                {
                    siteRo["latitude"] = ExpressionConverter.ConvertO(siteRolatitude);
                    siteRopropCount++;
                }

                if (siteRolongitude != null)
                {
                    siteRo["longitude"] = ExpressionConverter.ConvertO(siteRolongitude);
                    siteRopropCount++;
                }

                siteRopropCount++;
                siteRo["name"] = ExpressionConverter.ConvertO(siteRoname);
                siteRopropCount++;
                siteRo["postalCode"] = ExpressionConverter.ConvertO(siteRopostalCode);
                if (siteRopropCount > 0)
                {
                    callPayload.Body = siteRo;
                }

                return new ApiConnectionAction<SiteRo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        [WorkflowExpressionFactory(nameof(__BuildGetTags))]
        public IBodyWorkflowAction<PageThingTagRo> GetTags([WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null, [WorkflowExpression] Func<string> sortValues = null, [WorkflowExpression] Func<string> sort = null, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<dirInput> dir = null, [WorkflowExpression] Func<string> orFilter = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PageThingTagRo> __BuildGetTags(WorkflowExpression<int> page = null, WorkflowExpression<int> pageSize = null, WorkflowExpression<string> sortValues = null, WorkflowExpression<string> sort = null, WorkflowExpression<string> filter = null, WorkflowExpression<dirInput> dir = null, WorkflowExpression<string> orFilter = null)
        {
            WorkflowExpression.Validate(page, nameof(page), required: false);
            WorkflowExpression.Validate(pageSize, nameof(pageSize), required: false);
            WorkflowExpression.Validate(sortValues, nameof(sortValues), required: false);
            WorkflowExpression.Validate(sort, nameof(sort), required: false);
            WorkflowExpression.Validate(filter, nameof(filter), required: false);
            WorkflowExpression.Validate(dir, nameof(dir), required: false);
            WorkflowExpression.Validate(orFilter, nameof(orFilter), required: false);
            return new DeferredBodyAction<PageThingTagRo>(() =>
            {
                var apiCallPath = "/api/tags";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(page);
                if (pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(pageSize);
                if (sortValues != null)
                    callPayload.Queries["sortValues"] = ExpressionConverter.Convert(sortValues);
                if (sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(sort);
                if (filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(filter);
                if (dir != null)
                    callPayload.Queries["dir"] = ExpressionConverter.Convert(dir);
                if (orFilter != null)
                    callPayload.Queries["orFilter"] = ExpressionConverter.Convert(orFilter);
                return new ApiConnectionAction<PageThingTagRo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateThingTag))]
        public IBodyWorkflowAction<TagRo> UpdateThingTag([WorkflowExpression] Func<string> thingTagRoid = null, [WorkflowExpression] Func<string> thingTagRotag = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TagRo> __BuildUpdateThingTag(WorkflowExpression<string> thingTagRoid = null, WorkflowExpression<string> thingTagRotag = null)
        {
            WorkflowExpression.Validate(thingTagRoid, nameof(thingTagRoid), required: false);
            WorkflowExpression.Validate(thingTagRotag, nameof(thingTagRotag), required: false);
            return new DeferredBodyAction<TagRo>(() =>
            {
                var apiCallPath = "/api/tags";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var thingTagRo = new JObject();
                var thingTagRopropCount = 0;
                if (thingTagRoid != null)
                {
                    thingTagRo["id"] = ExpressionConverter.ConvertO(thingTagRoid);
                    thingTagRopropCount++;
                }

                if (thingTagRotag != null)
                {
                    thingTagRo["tag"] = ExpressionConverter.ConvertO(thingTagRotag);
                    thingTagRopropCount++;
                }

                if (thingTagRopropCount > 0)
                {
                    callPayload.Body = thingTagRo;
                }

                return new ApiConnectionAction<TagRo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        [WorkflowExpressionFactory(nameof(__BuildAddThingTag))]
        public IBodyWorkflowAction<TagRo> AddThingTag([WorkflowExpression] Func<string> thingId, [WorkflowExpression] Func<string> thingTagRoid = null, [WorkflowExpression] Func<string> thingTagRotag = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TagRo> __BuildAddThingTag(WorkflowExpression<string> thingId, WorkflowExpression<string> thingTagRoid = null, WorkflowExpression<string> thingTagRotag = null)
        {
            WorkflowExpression.Validate(thingId, nameof(thingId), required: true);
            WorkflowExpression.Validate(thingTagRoid, nameof(thingTagRoid), required: false);
            WorkflowExpression.Validate(thingTagRotag, nameof(thingTagRotag), required: false);
            return new DeferredBodyAction<TagRo>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/tags/thing/{0}", ExpressionConverter.ConvertWithUrlEncoding(thingId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var thingTagRo = new JObject();
                var thingTagRopropCount = 0;
                if (thingTagRoid != null)
                {
                    thingTagRo["id"] = ExpressionConverter.ConvertO(thingTagRoid);
                    thingTagRopropCount++;
                }

                if (thingTagRotag != null)
                {
                    thingTagRo["tag"] = ExpressionConverter.ConvertO(thingTagRotag);
                    thingTagRopropCount++;
                }

                if (thingTagRopropCount > 0)
                {
                    callPayload.Body = thingTagRo;
                }

                return new ApiConnectionAction<TagRo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        [WorkflowExpressionFactory(nameof(__BuildGetThingTag))]
        public IBodyWorkflowAction<TagRo> GetThingTag([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TagRo> __BuildGetThingTag(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<TagRo>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/tags/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<TagRo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        [WorkflowExpressionFactory(nameof(__BuildGetThings))]
        public IBodyWorkflowAction<PageSingleThingRo> GetThings([WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null, [WorkflowExpression] Func<string> sortValues = null, [WorkflowExpression] Func<string> sort = null, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<dirInput> dir = null, [WorkflowExpression] Func<string> orFilter = null, [WorkflowExpression] Func<bool> detailed = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PageSingleThingRo> __BuildGetThings(WorkflowExpression<int> page = null, WorkflowExpression<int> pageSize = null, WorkflowExpression<string> sortValues = null, WorkflowExpression<string> sort = null, WorkflowExpression<string> filter = null, WorkflowExpression<dirInput> dir = null, WorkflowExpression<string> orFilter = null, WorkflowExpression<bool> detailed = null)
        {
            WorkflowExpression.Validate(page, nameof(page), required: false);
            WorkflowExpression.Validate(pageSize, nameof(pageSize), required: false);
            WorkflowExpression.Validate(sortValues, nameof(sortValues), required: false);
            WorkflowExpression.Validate(sort, nameof(sort), required: false);
            WorkflowExpression.Validate(filter, nameof(filter), required: false);
            WorkflowExpression.Validate(dir, nameof(dir), required: false);
            WorkflowExpression.Validate(orFilter, nameof(orFilter), required: false);
            WorkflowExpression.Validate(detailed, nameof(detailed), required: false);
            return new DeferredBodyAction<PageSingleThingRo>(() =>
            {
                var apiCallPath = "/api/things";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(page);
                if (pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(pageSize);
                if (sortValues != null)
                    callPayload.Queries["sortValues"] = ExpressionConverter.Convert(sortValues);
                if (sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(sort);
                if (filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(filter);
                if (dir != null)
                    callPayload.Queries["dir"] = ExpressionConverter.Convert(dir);
                if (orFilter != null)
                    callPayload.Queries["orFilter"] = ExpressionConverter.Convert(orFilter);
                callPayload.Queries["detailed"] = Convert.ToString(false);
                if (detailed != null)
                    callPayload.Queries["detailed"] = ExpressionConverter.Convert(detailed);
                return new ApiConnectionAction<PageSingleThingRo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        [WorkflowExpressionFactory(nameof(__BuildAddThingsCsv))]
        public IBodyWorkflowAction<ResponseEntity> AddThingsCsv([WorkflowExpression] Func<object> file)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResponseEntity> __BuildAddThingsCsv(WorkflowExpression<object> file)
        {
            WorkflowExpression.Validate(file, nameof(file), required: true);
            return new DeferredBodyAction<ResponseEntity>(() =>
            {
                var apiCallPath = "/api/things";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ResponseEntity>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        [WorkflowExpressionFactory(nameof(__BuildAssociateThingsWithProduct))]
        public IBodyWorkflowAction<SingleThingRo[]> AssociateThingsWithProduct([WorkflowExpression] Func<bool> jsonarray = null, [WorkflowExpression] Func<bool> jsonbigDecimal = null, [WorkflowExpression] Func<bool> jsonbigInteger = null, [WorkflowExpression] Func<bool> jsonbinary = null, [WorkflowExpression] Func<bool> jsonboolean = null, [WorkflowExpression] Func<bool> jsoncontainerNode = null, [WorkflowExpression] Func<bool> jsondouble = null, [WorkflowExpression] Func<bool> jsonfloat = null, [WorkflowExpression] Func<bool> jsonfloatingPointNumber = null, [WorkflowExpression] Func<bool> jsonint = null, [WorkflowExpression] Func<bool> jsonintegralNumber = null, [WorkflowExpression] Func<bool> jsonLong = null, [WorkflowExpression] Func<bool> jsonmissingNode = null, [WorkflowExpression] Func<jsonnodeTypeInput> jsonnodeType = null, [WorkflowExpression] Func<bool> jsonnull = null, [WorkflowExpression] Func<bool> jsonnumber = null, [WorkflowExpression] Func<bool> jsonObject = null, [WorkflowExpression] Func<bool> jsonpojo = null, [WorkflowExpression] Func<bool> jsonShort = null, [WorkflowExpression] Func<bool> jsontextual = null, [WorkflowExpression] Func<bool> jsonvalueNode = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SingleThingRo[]> __BuildAssociateThingsWithProduct(WorkflowExpression<bool> jsonarray = null, WorkflowExpression<bool> jsonbigDecimal = null, WorkflowExpression<bool> jsonbigInteger = null, WorkflowExpression<bool> jsonbinary = null, WorkflowExpression<bool> jsonboolean = null, WorkflowExpression<bool> jsoncontainerNode = null, WorkflowExpression<bool> jsondouble = null, WorkflowExpression<bool> jsonfloat = null, WorkflowExpression<bool> jsonfloatingPointNumber = null, WorkflowExpression<bool> jsonint = null, WorkflowExpression<bool> jsonintegralNumber = null, WorkflowExpression<bool> jsonLong = null, WorkflowExpression<bool> jsonmissingNode = null, WorkflowExpression<jsonnodeTypeInput> jsonnodeType = null, WorkflowExpression<bool> jsonnull = null, WorkflowExpression<bool> jsonnumber = null, WorkflowExpression<bool> jsonObject = null, WorkflowExpression<bool> jsonpojo = null, WorkflowExpression<bool> jsonShort = null, WorkflowExpression<bool> jsontextual = null, WorkflowExpression<bool> jsonvalueNode = null)
        {
            WorkflowExpression.Validate(jsonarray, nameof(jsonarray), required: false);
            WorkflowExpression.Validate(jsonbigDecimal, nameof(jsonbigDecimal), required: false);
            WorkflowExpression.Validate(jsonbigInteger, nameof(jsonbigInteger), required: false);
            WorkflowExpression.Validate(jsonbinary, nameof(jsonbinary), required: false);
            WorkflowExpression.Validate(jsonboolean, nameof(jsonboolean), required: false);
            WorkflowExpression.Validate(jsoncontainerNode, nameof(jsoncontainerNode), required: false);
            WorkflowExpression.Validate(jsondouble, nameof(jsondouble), required: false);
            WorkflowExpression.Validate(jsonfloat, nameof(jsonfloat), required: false);
            WorkflowExpression.Validate(jsonfloatingPointNumber, nameof(jsonfloatingPointNumber), required: false);
            WorkflowExpression.Validate(jsonint, nameof(jsonint), required: false);
            WorkflowExpression.Validate(jsonintegralNumber, nameof(jsonintegralNumber), required: false);
            WorkflowExpression.Validate(jsonLong, nameof(jsonLong), required: false);
            WorkflowExpression.Validate(jsonmissingNode, nameof(jsonmissingNode), required: false);
            WorkflowExpression.Validate(jsonnodeType, nameof(jsonnodeType), required: false);
            WorkflowExpression.Validate(jsonnull, nameof(jsonnull), required: false);
            WorkflowExpression.Validate(jsonnumber, nameof(jsonnumber), required: false);
            WorkflowExpression.Validate(jsonObject, nameof(jsonObject), required: false);
            WorkflowExpression.Validate(jsonpojo, nameof(jsonpojo), required: false);
            WorkflowExpression.Validate(jsonShort, nameof(jsonShort), required: false);
            WorkflowExpression.Validate(jsontextual, nameof(jsontextual), required: false);
            WorkflowExpression.Validate(jsonvalueNode, nameof(jsonvalueNode), required: false);
            return new DeferredBodyAction<SingleThingRo[]>(() =>
            {
                var apiCallPath = "/api/things";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var json = new JObject();
                var jsonpropCount = 0;
                if (jsonarray != null)
                {
                    json["array"] = ExpressionConverter.ConvertO(jsonarray);
                    jsonpropCount++;
                }

                if (jsonbigDecimal != null)
                {
                    json["bigDecimal"] = ExpressionConverter.ConvertO(jsonbigDecimal);
                    jsonpropCount++;
                }

                if (jsonbigInteger != null)
                {
                    json["bigInteger"] = ExpressionConverter.ConvertO(jsonbigInteger);
                    jsonpropCount++;
                }

                if (jsonbinary != null)
                {
                    json["binary"] = ExpressionConverter.ConvertO(jsonbinary);
                    jsonpropCount++;
                }

                if (jsonboolean != null)
                {
                    json["boolean"] = ExpressionConverter.ConvertO(jsonboolean);
                    jsonpropCount++;
                }

                if (jsoncontainerNode != null)
                {
                    json["containerNode"] = ExpressionConverter.ConvertO(jsoncontainerNode);
                    jsonpropCount++;
                }

                if (jsondouble != null)
                {
                    json["double"] = ExpressionConverter.ConvertO(jsondouble);
                    jsonpropCount++;
                }

                if (jsonfloat != null)
                {
                    json["float"] = ExpressionConverter.ConvertO(jsonfloat);
                    jsonpropCount++;
                }

                if (jsonfloatingPointNumber != null)
                {
                    json["floatingPointNumber"] = ExpressionConverter.ConvertO(jsonfloatingPointNumber);
                    jsonpropCount++;
                }

                if (jsonint != null)
                {
                    json["int"] = ExpressionConverter.ConvertO(jsonint);
                    jsonpropCount++;
                }

                if (jsonintegralNumber != null)
                {
                    json["integralNumber"] = ExpressionConverter.ConvertO(jsonintegralNumber);
                    jsonpropCount++;
                }

                if (jsonLong != null)
                {
                    json["long"] = ExpressionConverter.ConvertO(jsonLong);
                    jsonpropCount++;
                }

                if (jsonmissingNode != null)
                {
                    json["missingNode"] = ExpressionConverter.ConvertO(jsonmissingNode);
                    jsonpropCount++;
                }

                if (jsonnodeType != null)
                {
                    json["nodeType"] = ExpressionConverter.ConvertO(jsonnodeType);
                    jsonpropCount++;
                }

                if (jsonnull != null)
                {
                    json["null"] = ExpressionConverter.ConvertO(jsonnull);
                    jsonpropCount++;
                }

                if (jsonnumber != null)
                {
                    json["number"] = ExpressionConverter.ConvertO(jsonnumber);
                    jsonpropCount++;
                }

                if (jsonObject != null)
                {
                    json["object"] = ExpressionConverter.ConvertO(jsonObject);
                    jsonpropCount++;
                }

                if (jsonpojo != null)
                {
                    json["pojo"] = ExpressionConverter.ConvertO(jsonpojo);
                    jsonpropCount++;
                }

                if (jsonShort != null)
                {
                    json["short"] = ExpressionConverter.ConvertO(jsonShort);
                    jsonpropCount++;
                }

                if (jsontextual != null)
                {
                    json["textual"] = ExpressionConverter.ConvertO(jsontextual);
                    jsonpropCount++;
                }

                if (jsonvalueNode != null)
                {
                    json["valueNode"] = ExpressionConverter.ConvertO(jsonvalueNode);
                    jsonpropCount++;
                }

                if (jsonpropCount > 0)
                {
                    callPayload.Body = json;
                }

                return new ApiConnectionAction<SingleThingRo[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        [WorkflowExpressionFactory(nameof(__BuildGetThingList))]
        public IBodyWorkflowAction<SingleThingRo[]> GetThingList([WorkflowExpression] Func<string[]> thingIds = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SingleThingRo[]> __BuildGetThingList(WorkflowExpression<string[]> thingIds = null)
        {
            WorkflowExpression.Validate(thingIds, nameof(thingIds), required: false);
            return new DeferredBodyAction<SingleThingRo[]>(() =>
            {
                var apiCallPath = "/api/things/list";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(thingIds);
                return new ApiConnectionAction<SingleThingRo[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        [WorkflowExpressionFactory(nameof(__BuildGetThing))]
        public IBodyWorkflowAction<SingleThingRo> GetThing([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<bool> detailed = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SingleThingRo> __BuildGetThing(WorkflowExpression<string> id, WorkflowExpression<bool> detailed = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(detailed, nameof(detailed), required: false);
            return new DeferredBodyAction<SingleThingRo>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/things/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["detailed"] = Convert.ToString(false);
                if (detailed != null)
                    callPayload.Queries["detailed"] = ExpressionConverter.Convert(detailed);
                return new ApiConnectionAction<SingleThingRo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        [WorkflowExpressionFactory(nameof(__BuildIgnoreThing))]
        public IWorkflowAction IgnoreThing([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<bool> force = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildIgnoreThing(WorkflowExpression<string> id, WorkflowExpression<bool> force = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(force, nameof(force), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/things/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (force != null)
                    callPayload.Queries["force"] = ExpressionConverter.Convert(force);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        [WorkflowExpressionFactory(nameof(__BuildPutThing))]
        public IBodyWorkflowAction<ThingRo> PutThing([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> thingRoname, [WorkflowExpression] Func<string> thingRositeaddress, [WorkflowExpression] Func<string> thingRositecity, [WorkflowExpression] Func<string> thingRositename, [WorkflowExpression] Func<string> thingRositepostalCode, [WorkflowExpression] Func<string> thingRoapplicationid = null, [WorkflowExpression] Func<string> thingRoapplicationlink = null, [WorkflowExpression] Func<string> thingRoapplicationname = null, [WorkflowExpression] Func<string> thingRoconnectivityid = null, [WorkflowExpression] Func<string> thingRoconnectivityrawStatus = null, [WorkflowExpression] Func<thingRoconnectivitystatusInput> thingRoconnectivitystatus = null, [WorkflowExpression] Func<thingRoconnectivitytypeInput> thingRoconnectivitytype = null, [WorkflowExpression] Func<CustomFieldRo[]> thingRocustomFields = null, [WorkflowExpression] Func<string> thingRocustomModelcolor = null, [WorkflowExpression] Func<string> thingRocustomModelicon = null, [WorkflowExpression] Func<string> thingRocustomModelid = null, [WorkflowExpression] Func<string> thingRocustomModellink = null, [WorkflowExpression] Func<string> thingRocustomModelname = null, [WorkflowExpression] Func<string> thingRodescription = null, [WorkflowExpression] Func<int> thingRodevicebatteryLevel = null, [WorkflowExpression] Func<thingRodevicebatteryStatusInput> thingRodevicebatteryStatus = null, [WorkflowExpression] Func<string> thingRodevicedeviceType = null, [WorkflowExpression] Func<string> thingRodeviceid = null, [WorkflowExpression] Func<string> thingRodevicemanufacturer = null, [WorkflowExpression] Func<int> thingRodevicememoryFree = null, [WorkflowExpression] Func<int> thingRodevicememoryTotal = null, [WorkflowExpression] Func<string> thingRodevicemodel = null, [WorkflowExpression] Func<string> thingRodevicemodelNumber = null, [WorkflowExpression] Func<string> thingRodevicename = null, [WorkflowExpression] Func<string> thingRodeviceserialNumber = null, [WorkflowExpression] Func<thingRodevicestatusInput> thingRodevicestatus = null, [WorkflowExpression] Func<string> thingRodisplayName = null, [WorkflowExpression] Func<bool> thingRodynamicGps = null, [WorkflowExpression] Func<double> thingRofixedLatitude = null, [WorkflowExpression] Func<double> thingRofixedLongitude = null, [WorkflowExpression] Func<string> thingRofixedName = null, [WorkflowExpression] Func<string> thingRoid = null, [WorkflowExpression] Func<int> thingRolastActivityDate = null, [WorkflowExpression] Func<double> thingRolastLatitude = null, [WorkflowExpression] Func<double> thingRolastLongitude = null, [WorkflowExpression] Func<bool> thingRolastMeasurementsarray = null, [WorkflowExpression] Func<bool> thingRolastMeasurementsbigDecimal = null, [WorkflowExpression] Func<bool> thingRolastMeasurementsbigInteger = null, [WorkflowExpression] Func<bool> thingRolastMeasurementsbinary = null, [WorkflowExpression] Func<bool> thingRolastMeasurementsboolean = null, [WorkflowExpression] Func<bool> thingRolastMeasurementscontainerNode = null, [WorkflowExpression] Func<bool> thingRolastMeasurementsdouble = null, [WorkflowExpression] Func<bool> thingRolastMeasurementsfloat = null, [WorkflowExpression] Func<bool> thingRolastMeasurementsfloatingPointNumber = null, [WorkflowExpression] Func<bool> thingRolastMeasurementsint = null, [WorkflowExpression] Func<bool> thingRolastMeasurementsintegralNumber = null, [WorkflowExpression] Func<bool> thingRolastMeasurementsLong = null, [WorkflowExpression] Func<bool> thingRolastMeasurementsmissingNode = null, [WorkflowExpression] Func<thingRolastMeasurementsnodeTypeInput> thingRolastMeasurementsnodeType = null, [WorkflowExpression] Func<bool> thingRolastMeasurementsnull = null, [WorkflowExpression] Func<bool> thingRolastMeasurementsnumber = null, [WorkflowExpression] Func<bool> thingRolastMeasurementsObject = null, [WorkflowExpression] Func<bool> thingRolastMeasurementspojo = null, [WorkflowExpression] Func<bool> thingRolastMeasurementsShort = null, [WorkflowExpression] Func<bool> thingRolastMeasurementstextual = null, [WorkflowExpression] Func<bool> thingRolastMeasurementsvalueNode = null, [WorkflowExpression] Func<bool> thingRolastMeasurementsTimestampsarray = null, [WorkflowExpression] Func<bool> thingRolastMeasurementsTimestampsbigDecimal = null, [WorkflowExpression] Func<bool> thingRolastMeasurementsTimestampsbigInteger = null, [WorkflowExpression] Func<bool> thingRolastMeasurementsTimestampsbinary = null, [WorkflowExpression] Func<bool> thingRolastMeasurementsTimestampsboolean = null, [WorkflowExpression] Func<bool> thingRolastMeasurementsTimestampscontainerNode = null, [WorkflowExpression] Func<bool> thingRolastMeasurementsTimestampsdouble = null, [WorkflowExpression] Func<bool> thingRolastMeasurementsTimestampsfloat = null, [WorkflowExpression] Func<bool> thingRolastMeasurementsTimestampsfloatingPointNumber = null, [WorkflowExpression] Func<bool> thingRolastMeasurementsTimestampsint = null, [WorkflowExpression] Func<bool> thingRolastMeasurementsTimestampsintegralNumber = null, [WorkflowExpression] Func<bool> thingRolastMeasurementsTimestampsLong = null, [WorkflowExpression] Func<bool> thingRolastMeasurementsTimestampsmissingNode = null, [WorkflowExpression] Func<thingRolastMeasurementsTimestampsnodeTypeInput> thingRolastMeasurementsTimestampsnodeType = null, [WorkflowExpression] Func<bool> thingRolastMeasurementsTimestampsnull = null, [WorkflowExpression] Func<bool> thingRolastMeasurementsTimestampsnumber = null, [WorkflowExpression] Func<bool> thingRolastMeasurementsTimestampsObject = null, [WorkflowExpression] Func<bool> thingRolastMeasurementsTimestampspojo = null, [WorkflowExpression] Func<bool> thingRolastMeasurementsTimestampsShort = null, [WorkflowExpression] Func<bool> thingRolastMeasurementsTimestampstextual = null, [WorkflowExpression] Func<bool> thingRolastMeasurementsTimestampsvalueNode = null, [WorkflowExpression] Func<int> thingRolastMessageDate = null, [WorkflowExpression] Func<int> thingRomessageActivityTimeoutPeriod = null, [WorkflowExpression] Func<int> thingRonbAlerts = null, [WorkflowExpression] Func<thingRoproductconnectivityTypesInputItem[]> thingRoproductconnectivityTypes = null, [WorkflowExpression] Func<bool> thingRoproductgenerateLinks = null, [WorkflowExpression] Func<string> thingRoproductid = null, [WorkflowExpression] Func<string> thingRoproductlink = null, [WorkflowExpression] Func<bool> thingRoproductmanufacturergenerateLinks = null, [WorkflowExpression] Func<string> thingRoproductmanufacturerid = null, [WorkflowExpression] Func<string> thingRoproductmanufacturerlink = null, [WorkflowExpression] Func<string> thingRoproductmanufacturername = null, [WorkflowExpression] Func<string> thingRoproductmodelcolor = null, [WorkflowExpression] Func<bool> thingRoproductmodelgenerateLinks = null, [WorkflowExpression] Func<string> thingRoproductmodelicon = null, [WorkflowExpression] Func<string> thingRoproductmodelid = null, [WorkflowExpression] Func<bool> thingRoproductmodelisCustomModel = null, [WorkflowExpression] Func<bool> thingRoproductmodellinkabsolute = null, [WorkflowExpression] Func<string> thingRoproductmodellinkauthority = null, [WorkflowExpression] Func<string> thingRoproductmodellinkfragment = null, [WorkflowExpression] Func<string> thingRoproductmodellinkhost = null, [WorkflowExpression] Func<bool> thingRoproductmodellinkopaque = null, [WorkflowExpression] Func<string> thingRoproductmodellinkpath = null, [WorkflowExpression] Func<int> thingRoproductmodellinkport = null, [WorkflowExpression] Func<string> thingRoproductmodellinkquery = null, [WorkflowExpression] Func<string> thingRoproductmodellinkrawAuthority = null, [WorkflowExpression] Func<string> thingRoproductmodellinkrawFragment = null, [WorkflowExpression] Func<string> thingRoproductmodellinkrawPath = null, [WorkflowExpression] Func<string> thingRoproductmodellinkrawQuery = null, [WorkflowExpression] Func<string> thingRoproductmodellinkrawSchemeSpecificPart = null, [WorkflowExpression] Func<string> thingRoproductmodellinkrawUserInfo = null, [WorkflowExpression] Func<string> thingRoproductmodellinkscheme = null, [WorkflowExpression] Func<string> thingRoproductmodellinkschemeSpecificPart = null, [WorkflowExpression] Func<string> thingRoproductmodellinkuserInfo = null, [WorkflowExpression] Func<string> thingRoproductmodelname = null, [WorkflowExpression] Func<string> thingRoproductname = null, [WorkflowExpression] Func<string> thingRoproductreference = null, [WorkflowExpression] Func<string> thingRositeid = null, [WorkflowExpression] Func<double> thingRositelatitude = null, [WorkflowExpression] Func<double> thingRositelongitude = null, [WorkflowExpression] Func<string> thingRosourceId = null, [WorkflowExpression] Func<thingRostatusInput> thingRostatus = null, [WorkflowExpression] Func<ThingTagRo[]> thingRotags = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ThingRo> __BuildPutThing(WorkflowExpression<string> id, WorkflowExpression<string> thingRoname, WorkflowExpression<string> thingRositeaddress, WorkflowExpression<string> thingRositecity, WorkflowExpression<string> thingRositename, WorkflowExpression<string> thingRositepostalCode, WorkflowExpression<string> thingRoapplicationid = null, WorkflowExpression<string> thingRoapplicationlink = null, WorkflowExpression<string> thingRoapplicationname = null, WorkflowExpression<string> thingRoconnectivityid = null, WorkflowExpression<string> thingRoconnectivityrawStatus = null, WorkflowExpression<thingRoconnectivitystatusInput> thingRoconnectivitystatus = null, WorkflowExpression<thingRoconnectivitytypeInput> thingRoconnectivitytype = null, WorkflowExpression<CustomFieldRo[]> thingRocustomFields = null, WorkflowExpression<string> thingRocustomModelcolor = null, WorkflowExpression<string> thingRocustomModelicon = null, WorkflowExpression<string> thingRocustomModelid = null, WorkflowExpression<string> thingRocustomModellink = null, WorkflowExpression<string> thingRocustomModelname = null, WorkflowExpression<string> thingRodescription = null, WorkflowExpression<int> thingRodevicebatteryLevel = null, WorkflowExpression<thingRodevicebatteryStatusInput> thingRodevicebatteryStatus = null, WorkflowExpression<string> thingRodevicedeviceType = null, WorkflowExpression<string> thingRodeviceid = null, WorkflowExpression<string> thingRodevicemanufacturer = null, WorkflowExpression<int> thingRodevicememoryFree = null, WorkflowExpression<int> thingRodevicememoryTotal = null, WorkflowExpression<string> thingRodevicemodel = null, WorkflowExpression<string> thingRodevicemodelNumber = null, WorkflowExpression<string> thingRodevicename = null, WorkflowExpression<string> thingRodeviceserialNumber = null, WorkflowExpression<thingRodevicestatusInput> thingRodevicestatus = null, WorkflowExpression<string> thingRodisplayName = null, WorkflowExpression<bool> thingRodynamicGps = null, WorkflowExpression<double> thingRofixedLatitude = null, WorkflowExpression<double> thingRofixedLongitude = null, WorkflowExpression<string> thingRofixedName = null, WorkflowExpression<string> thingRoid = null, WorkflowExpression<int> thingRolastActivityDate = null, WorkflowExpression<double> thingRolastLatitude = null, WorkflowExpression<double> thingRolastLongitude = null, WorkflowExpression<bool> thingRolastMeasurementsarray = null, WorkflowExpression<bool> thingRolastMeasurementsbigDecimal = null, WorkflowExpression<bool> thingRolastMeasurementsbigInteger = null, WorkflowExpression<bool> thingRolastMeasurementsbinary = null, WorkflowExpression<bool> thingRolastMeasurementsboolean = null, WorkflowExpression<bool> thingRolastMeasurementscontainerNode = null, WorkflowExpression<bool> thingRolastMeasurementsdouble = null, WorkflowExpression<bool> thingRolastMeasurementsfloat = null, WorkflowExpression<bool> thingRolastMeasurementsfloatingPointNumber = null, WorkflowExpression<bool> thingRolastMeasurementsint = null, WorkflowExpression<bool> thingRolastMeasurementsintegralNumber = null, WorkflowExpression<bool> thingRolastMeasurementsLong = null, WorkflowExpression<bool> thingRolastMeasurementsmissingNode = null, WorkflowExpression<thingRolastMeasurementsnodeTypeInput> thingRolastMeasurementsnodeType = null, WorkflowExpression<bool> thingRolastMeasurementsnull = null, WorkflowExpression<bool> thingRolastMeasurementsnumber = null, WorkflowExpression<bool> thingRolastMeasurementsObject = null, WorkflowExpression<bool> thingRolastMeasurementspojo = null, WorkflowExpression<bool> thingRolastMeasurementsShort = null, WorkflowExpression<bool> thingRolastMeasurementstextual = null, WorkflowExpression<bool> thingRolastMeasurementsvalueNode = null, WorkflowExpression<bool> thingRolastMeasurementsTimestampsarray = null, WorkflowExpression<bool> thingRolastMeasurementsTimestampsbigDecimal = null, WorkflowExpression<bool> thingRolastMeasurementsTimestampsbigInteger = null, WorkflowExpression<bool> thingRolastMeasurementsTimestampsbinary = null, WorkflowExpression<bool> thingRolastMeasurementsTimestampsboolean = null, WorkflowExpression<bool> thingRolastMeasurementsTimestampscontainerNode = null, WorkflowExpression<bool> thingRolastMeasurementsTimestampsdouble = null, WorkflowExpression<bool> thingRolastMeasurementsTimestampsfloat = null, WorkflowExpression<bool> thingRolastMeasurementsTimestampsfloatingPointNumber = null, WorkflowExpression<bool> thingRolastMeasurementsTimestampsint = null, WorkflowExpression<bool> thingRolastMeasurementsTimestampsintegralNumber = null, WorkflowExpression<bool> thingRolastMeasurementsTimestampsLong = null, WorkflowExpression<bool> thingRolastMeasurementsTimestampsmissingNode = null, WorkflowExpression<thingRolastMeasurementsTimestampsnodeTypeInput> thingRolastMeasurementsTimestampsnodeType = null, WorkflowExpression<bool> thingRolastMeasurementsTimestampsnull = null, WorkflowExpression<bool> thingRolastMeasurementsTimestampsnumber = null, WorkflowExpression<bool> thingRolastMeasurementsTimestampsObject = null, WorkflowExpression<bool> thingRolastMeasurementsTimestampspojo = null, WorkflowExpression<bool> thingRolastMeasurementsTimestampsShort = null, WorkflowExpression<bool> thingRolastMeasurementsTimestampstextual = null, WorkflowExpression<bool> thingRolastMeasurementsTimestampsvalueNode = null, WorkflowExpression<int> thingRolastMessageDate = null, WorkflowExpression<int> thingRomessageActivityTimeoutPeriod = null, WorkflowExpression<int> thingRonbAlerts = null, WorkflowExpression<thingRoproductconnectivityTypesInputItem[]> thingRoproductconnectivityTypes = null, WorkflowExpression<bool> thingRoproductgenerateLinks = null, WorkflowExpression<string> thingRoproductid = null, WorkflowExpression<string> thingRoproductlink = null, WorkflowExpression<bool> thingRoproductmanufacturergenerateLinks = null, WorkflowExpression<string> thingRoproductmanufacturerid = null, WorkflowExpression<string> thingRoproductmanufacturerlink = null, WorkflowExpression<string> thingRoproductmanufacturername = null, WorkflowExpression<string> thingRoproductmodelcolor = null, WorkflowExpression<bool> thingRoproductmodelgenerateLinks = null, WorkflowExpression<string> thingRoproductmodelicon = null, WorkflowExpression<string> thingRoproductmodelid = null, WorkflowExpression<bool> thingRoproductmodelisCustomModel = null, WorkflowExpression<bool> thingRoproductmodellinkabsolute = null, WorkflowExpression<string> thingRoproductmodellinkauthority = null, WorkflowExpression<string> thingRoproductmodellinkfragment = null, WorkflowExpression<string> thingRoproductmodellinkhost = null, WorkflowExpression<bool> thingRoproductmodellinkopaque = null, WorkflowExpression<string> thingRoproductmodellinkpath = null, WorkflowExpression<int> thingRoproductmodellinkport = null, WorkflowExpression<string> thingRoproductmodellinkquery = null, WorkflowExpression<string> thingRoproductmodellinkrawAuthority = null, WorkflowExpression<string> thingRoproductmodellinkrawFragment = null, WorkflowExpression<string> thingRoproductmodellinkrawPath = null, WorkflowExpression<string> thingRoproductmodellinkrawQuery = null, WorkflowExpression<string> thingRoproductmodellinkrawSchemeSpecificPart = null, WorkflowExpression<string> thingRoproductmodellinkrawUserInfo = null, WorkflowExpression<string> thingRoproductmodellinkscheme = null, WorkflowExpression<string> thingRoproductmodellinkschemeSpecificPart = null, WorkflowExpression<string> thingRoproductmodellinkuserInfo = null, WorkflowExpression<string> thingRoproductmodelname = null, WorkflowExpression<string> thingRoproductname = null, WorkflowExpression<string> thingRoproductreference = null, WorkflowExpression<string> thingRositeid = null, WorkflowExpression<double> thingRositelatitude = null, WorkflowExpression<double> thingRositelongitude = null, WorkflowExpression<string> thingRosourceId = null, WorkflowExpression<thingRostatusInput> thingRostatus = null, WorkflowExpression<ThingTagRo[]> thingRotags = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(thingRoname, nameof(thingRoname), required: true);
            WorkflowExpression.Validate(thingRositeaddress, nameof(thingRositeaddress), required: true);
            WorkflowExpression.Validate(thingRositecity, nameof(thingRositecity), required: true);
            WorkflowExpression.Validate(thingRositename, nameof(thingRositename), required: true);
            WorkflowExpression.Validate(thingRositepostalCode, nameof(thingRositepostalCode), required: true);
            WorkflowExpression.Validate(thingRoapplicationid, nameof(thingRoapplicationid), required: false);
            WorkflowExpression.Validate(thingRoapplicationlink, nameof(thingRoapplicationlink), required: false);
            WorkflowExpression.Validate(thingRoapplicationname, nameof(thingRoapplicationname), required: false);
            WorkflowExpression.Validate(thingRoconnectivityid, nameof(thingRoconnectivityid), required: false);
            WorkflowExpression.Validate(thingRoconnectivityrawStatus, nameof(thingRoconnectivityrawStatus), required: false);
            WorkflowExpression.Validate(thingRoconnectivitystatus, nameof(thingRoconnectivitystatus), required: false);
            WorkflowExpression.Validate(thingRoconnectivitytype, nameof(thingRoconnectivitytype), required: false);
            WorkflowExpression.Validate(thingRocustomFields, nameof(thingRocustomFields), required: false);
            WorkflowExpression.Validate(thingRocustomModelcolor, nameof(thingRocustomModelcolor), required: false);
            WorkflowExpression.Validate(thingRocustomModelicon, nameof(thingRocustomModelicon), required: false);
            WorkflowExpression.Validate(thingRocustomModelid, nameof(thingRocustomModelid), required: false);
            WorkflowExpression.Validate(thingRocustomModellink, nameof(thingRocustomModellink), required: false);
            WorkflowExpression.Validate(thingRocustomModelname, nameof(thingRocustomModelname), required: false);
            WorkflowExpression.Validate(thingRodescription, nameof(thingRodescription), required: false);
            WorkflowExpression.Validate(thingRodevicebatteryLevel, nameof(thingRodevicebatteryLevel), required: false);
            WorkflowExpression.Validate(thingRodevicebatteryStatus, nameof(thingRodevicebatteryStatus), required: false);
            WorkflowExpression.Validate(thingRodevicedeviceType, nameof(thingRodevicedeviceType), required: false);
            WorkflowExpression.Validate(thingRodeviceid, nameof(thingRodeviceid), required: false);
            WorkflowExpression.Validate(thingRodevicemanufacturer, nameof(thingRodevicemanufacturer), required: false);
            WorkflowExpression.Validate(thingRodevicememoryFree, nameof(thingRodevicememoryFree), required: false);
            WorkflowExpression.Validate(thingRodevicememoryTotal, nameof(thingRodevicememoryTotal), required: false);
            WorkflowExpression.Validate(thingRodevicemodel, nameof(thingRodevicemodel), required: false);
            WorkflowExpression.Validate(thingRodevicemodelNumber, nameof(thingRodevicemodelNumber), required: false);
            WorkflowExpression.Validate(thingRodevicename, nameof(thingRodevicename), required: false);
            WorkflowExpression.Validate(thingRodeviceserialNumber, nameof(thingRodeviceserialNumber), required: false);
            WorkflowExpression.Validate(thingRodevicestatus, nameof(thingRodevicestatus), required: false);
            WorkflowExpression.Validate(thingRodisplayName, nameof(thingRodisplayName), required: false);
            WorkflowExpression.Validate(thingRodynamicGps, nameof(thingRodynamicGps), required: false);
            WorkflowExpression.Validate(thingRofixedLatitude, nameof(thingRofixedLatitude), required: false);
            WorkflowExpression.Validate(thingRofixedLongitude, nameof(thingRofixedLongitude), required: false);
            WorkflowExpression.Validate(thingRofixedName, nameof(thingRofixedName), required: false);
            WorkflowExpression.Validate(thingRoid, nameof(thingRoid), required: false);
            WorkflowExpression.Validate(thingRolastActivityDate, nameof(thingRolastActivityDate), required: false);
            WorkflowExpression.Validate(thingRolastLatitude, nameof(thingRolastLatitude), required: false);
            WorkflowExpression.Validate(thingRolastLongitude, nameof(thingRolastLongitude), required: false);
            WorkflowExpression.Validate(thingRolastMeasurementsarray, nameof(thingRolastMeasurementsarray), required: false);
            WorkflowExpression.Validate(thingRolastMeasurementsbigDecimal, nameof(thingRolastMeasurementsbigDecimal), required: false);
            WorkflowExpression.Validate(thingRolastMeasurementsbigInteger, nameof(thingRolastMeasurementsbigInteger), required: false);
            WorkflowExpression.Validate(thingRolastMeasurementsbinary, nameof(thingRolastMeasurementsbinary), required: false);
            WorkflowExpression.Validate(thingRolastMeasurementsboolean, nameof(thingRolastMeasurementsboolean), required: false);
            WorkflowExpression.Validate(thingRolastMeasurementscontainerNode, nameof(thingRolastMeasurementscontainerNode), required: false);
            WorkflowExpression.Validate(thingRolastMeasurementsdouble, nameof(thingRolastMeasurementsdouble), required: false);
            WorkflowExpression.Validate(thingRolastMeasurementsfloat, nameof(thingRolastMeasurementsfloat), required: false);
            WorkflowExpression.Validate(thingRolastMeasurementsfloatingPointNumber, nameof(thingRolastMeasurementsfloatingPointNumber), required: false);
            WorkflowExpression.Validate(thingRolastMeasurementsint, nameof(thingRolastMeasurementsint), required: false);
            WorkflowExpression.Validate(thingRolastMeasurementsintegralNumber, nameof(thingRolastMeasurementsintegralNumber), required: false);
            WorkflowExpression.Validate(thingRolastMeasurementsLong, nameof(thingRolastMeasurementsLong), required: false);
            WorkflowExpression.Validate(thingRolastMeasurementsmissingNode, nameof(thingRolastMeasurementsmissingNode), required: false);
            WorkflowExpression.Validate(thingRolastMeasurementsnodeType, nameof(thingRolastMeasurementsnodeType), required: false);
            WorkflowExpression.Validate(thingRolastMeasurementsnull, nameof(thingRolastMeasurementsnull), required: false);
            WorkflowExpression.Validate(thingRolastMeasurementsnumber, nameof(thingRolastMeasurementsnumber), required: false);
            WorkflowExpression.Validate(thingRolastMeasurementsObject, nameof(thingRolastMeasurementsObject), required: false);
            WorkflowExpression.Validate(thingRolastMeasurementspojo, nameof(thingRolastMeasurementspojo), required: false);
            WorkflowExpression.Validate(thingRolastMeasurementsShort, nameof(thingRolastMeasurementsShort), required: false);
            WorkflowExpression.Validate(thingRolastMeasurementstextual, nameof(thingRolastMeasurementstextual), required: false);
            WorkflowExpression.Validate(thingRolastMeasurementsvalueNode, nameof(thingRolastMeasurementsvalueNode), required: false);
            WorkflowExpression.Validate(thingRolastMeasurementsTimestampsarray, nameof(thingRolastMeasurementsTimestampsarray), required: false);
            WorkflowExpression.Validate(thingRolastMeasurementsTimestampsbigDecimal, nameof(thingRolastMeasurementsTimestampsbigDecimal), required: false);
            WorkflowExpression.Validate(thingRolastMeasurementsTimestampsbigInteger, nameof(thingRolastMeasurementsTimestampsbigInteger), required: false);
            WorkflowExpression.Validate(thingRolastMeasurementsTimestampsbinary, nameof(thingRolastMeasurementsTimestampsbinary), required: false);
            WorkflowExpression.Validate(thingRolastMeasurementsTimestampsboolean, nameof(thingRolastMeasurementsTimestampsboolean), required: false);
            WorkflowExpression.Validate(thingRolastMeasurementsTimestampscontainerNode, nameof(thingRolastMeasurementsTimestampscontainerNode), required: false);
            WorkflowExpression.Validate(thingRolastMeasurementsTimestampsdouble, nameof(thingRolastMeasurementsTimestampsdouble), required: false);
            WorkflowExpression.Validate(thingRolastMeasurementsTimestampsfloat, nameof(thingRolastMeasurementsTimestampsfloat), required: false);
            WorkflowExpression.Validate(thingRolastMeasurementsTimestampsfloatingPointNumber, nameof(thingRolastMeasurementsTimestampsfloatingPointNumber), required: false);
            WorkflowExpression.Validate(thingRolastMeasurementsTimestampsint, nameof(thingRolastMeasurementsTimestampsint), required: false);
            WorkflowExpression.Validate(thingRolastMeasurementsTimestampsintegralNumber, nameof(thingRolastMeasurementsTimestampsintegralNumber), required: false);
            WorkflowExpression.Validate(thingRolastMeasurementsTimestampsLong, nameof(thingRolastMeasurementsTimestampsLong), required: false);
            WorkflowExpression.Validate(thingRolastMeasurementsTimestampsmissingNode, nameof(thingRolastMeasurementsTimestampsmissingNode), required: false);
            WorkflowExpression.Validate(thingRolastMeasurementsTimestampsnodeType, nameof(thingRolastMeasurementsTimestampsnodeType), required: false);
            WorkflowExpression.Validate(thingRolastMeasurementsTimestampsnull, nameof(thingRolastMeasurementsTimestampsnull), required: false);
            WorkflowExpression.Validate(thingRolastMeasurementsTimestampsnumber, nameof(thingRolastMeasurementsTimestampsnumber), required: false);
            WorkflowExpression.Validate(thingRolastMeasurementsTimestampsObject, nameof(thingRolastMeasurementsTimestampsObject), required: false);
            WorkflowExpression.Validate(thingRolastMeasurementsTimestampspojo, nameof(thingRolastMeasurementsTimestampspojo), required: false);
            WorkflowExpression.Validate(thingRolastMeasurementsTimestampsShort, nameof(thingRolastMeasurementsTimestampsShort), required: false);
            WorkflowExpression.Validate(thingRolastMeasurementsTimestampstextual, nameof(thingRolastMeasurementsTimestampstextual), required: false);
            WorkflowExpression.Validate(thingRolastMeasurementsTimestampsvalueNode, nameof(thingRolastMeasurementsTimestampsvalueNode), required: false);
            WorkflowExpression.Validate(thingRolastMessageDate, nameof(thingRolastMessageDate), required: false);
            WorkflowExpression.Validate(thingRomessageActivityTimeoutPeriod, nameof(thingRomessageActivityTimeoutPeriod), required: false);
            WorkflowExpression.Validate(thingRonbAlerts, nameof(thingRonbAlerts), required: false);
            WorkflowExpression.Validate(thingRoproductconnectivityTypes, nameof(thingRoproductconnectivityTypes), required: false);
            WorkflowExpression.Validate(thingRoproductgenerateLinks, nameof(thingRoproductgenerateLinks), required: false);
            WorkflowExpression.Validate(thingRoproductid, nameof(thingRoproductid), required: false);
            WorkflowExpression.Validate(thingRoproductlink, nameof(thingRoproductlink), required: false);
            WorkflowExpression.Validate(thingRoproductmanufacturergenerateLinks, nameof(thingRoproductmanufacturergenerateLinks), required: false);
            WorkflowExpression.Validate(thingRoproductmanufacturerid, nameof(thingRoproductmanufacturerid), required: false);
            WorkflowExpression.Validate(thingRoproductmanufacturerlink, nameof(thingRoproductmanufacturerlink), required: false);
            WorkflowExpression.Validate(thingRoproductmanufacturername, nameof(thingRoproductmanufacturername), required: false);
            WorkflowExpression.Validate(thingRoproductmodelcolor, nameof(thingRoproductmodelcolor), required: false);
            WorkflowExpression.Validate(thingRoproductmodelgenerateLinks, nameof(thingRoproductmodelgenerateLinks), required: false);
            WorkflowExpression.Validate(thingRoproductmodelicon, nameof(thingRoproductmodelicon), required: false);
            WorkflowExpression.Validate(thingRoproductmodelid, nameof(thingRoproductmodelid), required: false);
            WorkflowExpression.Validate(thingRoproductmodelisCustomModel, nameof(thingRoproductmodelisCustomModel), required: false);
            WorkflowExpression.Validate(thingRoproductmodellinkabsolute, nameof(thingRoproductmodellinkabsolute), required: false);
            WorkflowExpression.Validate(thingRoproductmodellinkauthority, nameof(thingRoproductmodellinkauthority), required: false);
            WorkflowExpression.Validate(thingRoproductmodellinkfragment, nameof(thingRoproductmodellinkfragment), required: false);
            WorkflowExpression.Validate(thingRoproductmodellinkhost, nameof(thingRoproductmodellinkhost), required: false);
            WorkflowExpression.Validate(thingRoproductmodellinkopaque, nameof(thingRoproductmodellinkopaque), required: false);
            WorkflowExpression.Validate(thingRoproductmodellinkpath, nameof(thingRoproductmodellinkpath), required: false);
            WorkflowExpression.Validate(thingRoproductmodellinkport, nameof(thingRoproductmodellinkport), required: false);
            WorkflowExpression.Validate(thingRoproductmodellinkquery, nameof(thingRoproductmodellinkquery), required: false);
            WorkflowExpression.Validate(thingRoproductmodellinkrawAuthority, nameof(thingRoproductmodellinkrawAuthority), required: false);
            WorkflowExpression.Validate(thingRoproductmodellinkrawFragment, nameof(thingRoproductmodellinkrawFragment), required: false);
            WorkflowExpression.Validate(thingRoproductmodellinkrawPath, nameof(thingRoproductmodellinkrawPath), required: false);
            WorkflowExpression.Validate(thingRoproductmodellinkrawQuery, nameof(thingRoproductmodellinkrawQuery), required: false);
            WorkflowExpression.Validate(thingRoproductmodellinkrawSchemeSpecificPart, nameof(thingRoproductmodellinkrawSchemeSpecificPart), required: false);
            WorkflowExpression.Validate(thingRoproductmodellinkrawUserInfo, nameof(thingRoproductmodellinkrawUserInfo), required: false);
            WorkflowExpression.Validate(thingRoproductmodellinkscheme, nameof(thingRoproductmodellinkscheme), required: false);
            WorkflowExpression.Validate(thingRoproductmodellinkschemeSpecificPart, nameof(thingRoproductmodellinkschemeSpecificPart), required: false);
            WorkflowExpression.Validate(thingRoproductmodellinkuserInfo, nameof(thingRoproductmodellinkuserInfo), required: false);
            WorkflowExpression.Validate(thingRoproductmodelname, nameof(thingRoproductmodelname), required: false);
            WorkflowExpression.Validate(thingRoproductname, nameof(thingRoproductname), required: false);
            WorkflowExpression.Validate(thingRoproductreference, nameof(thingRoproductreference), required: false);
            WorkflowExpression.Validate(thingRositeid, nameof(thingRositeid), required: false);
            WorkflowExpression.Validate(thingRositelatitude, nameof(thingRositelatitude), required: false);
            WorkflowExpression.Validate(thingRositelongitude, nameof(thingRositelongitude), required: false);
            WorkflowExpression.Validate(thingRosourceId, nameof(thingRosourceId), required: false);
            WorkflowExpression.Validate(thingRostatus, nameof(thingRostatus), required: false);
            WorkflowExpression.Validate(thingRotags, nameof(thingRotags), required: false);
            return new DeferredBodyAction<ThingRo>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/things/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var thingRo = new JObject();
                var thingRopropCount = 0;
                var applicationObject = new JObject();
                var applicationObjectpropCount = 0;
                if (thingRoapplicationid != null)
                {
                    applicationObject["id"] = ExpressionConverter.ConvertO(thingRoapplicationid);
                    applicationObjectpropCount++;
                }

                if (thingRoapplicationlink != null)
                {
                    applicationObject["link"] = ExpressionConverter.ConvertO(thingRoapplicationlink);
                    applicationObjectpropCount++;
                }

                if (thingRoapplicationname != null)
                {
                    applicationObject["name"] = ExpressionConverter.ConvertO(thingRoapplicationname);
                    applicationObjectpropCount++;
                }

                if (applicationObjectpropCount > 0)
                {
                    thingRo["application"] = applicationObject;
                    thingRopropCount++;
                }

                var connectivityObject = new JObject();
                var connectivityObjectpropCount = 0;
                var additionalPropertiesObject = new JObject();
                var additionalPropertiesObjectpropCount = 0;
                if (additionalPropertiesObjectpropCount > 0)
                {
                    connectivityObject["additionalProperties"] = additionalPropertiesObject;
                    connectivityObjectpropCount++;
                }

                if (thingRoconnectivityid != null)
                {
                    connectivityObject["id"] = ExpressionConverter.ConvertO(thingRoconnectivityid);
                    connectivityObjectpropCount++;
                }

                if (thingRoconnectivityrawStatus != null)
                {
                    connectivityObject["rawStatus"] = ExpressionConverter.ConvertO(thingRoconnectivityrawStatus);
                    connectivityObjectpropCount++;
                }

                if (thingRoconnectivitystatus != null)
                {
                    connectivityObject["status"] = ExpressionConverter.ConvertO(thingRoconnectivitystatus);
                    connectivityObjectpropCount++;
                }

                if (thingRoconnectivitytype != null)
                {
                    connectivityObject["type"] = ExpressionConverter.ConvertO(thingRoconnectivitytype);
                    connectivityObjectpropCount++;
                }

                if (connectivityObjectpropCount > 0)
                {
                    thingRo["connectivity"] = connectivityObject;
                    thingRopropCount++;
                }

                if (thingRocustomFields != null)
                {
                    thingRo["customFields"] = ExpressionConverter.ConvertO(thingRocustomFields);
                    thingRopropCount++;
                }

                var customModelObject = new JObject();
                var customModelObjectpropCount = 0;
                if (thingRocustomModelcolor != null)
                {
                    customModelObject["color"] = ExpressionConverter.ConvertO(thingRocustomModelcolor);
                    customModelObjectpropCount++;
                }

                if (thingRocustomModelicon != null)
                {
                    customModelObject["icon"] = ExpressionConverter.ConvertO(thingRocustomModelicon);
                    customModelObjectpropCount++;
                }

                if (thingRocustomModelid != null)
                {
                    customModelObject["id"] = ExpressionConverter.ConvertO(thingRocustomModelid);
                    customModelObjectpropCount++;
                }

                if (thingRocustomModellink != null)
                {
                    customModelObject["link"] = ExpressionConverter.ConvertO(thingRocustomModellink);
                    customModelObjectpropCount++;
                }

                if (thingRocustomModelname != null)
                {
                    customModelObject["name"] = ExpressionConverter.ConvertO(thingRocustomModelname);
                    customModelObjectpropCount++;
                }

                if (customModelObjectpropCount > 0)
                {
                    thingRo["customModel"] = customModelObject;
                    thingRopropCount++;
                }

                if (thingRodescription != null)
                {
                    thingRo["description"] = ExpressionConverter.ConvertO(thingRodescription);
                    thingRopropCount++;
                }

                var deviceObject = new JObject();
                var deviceObjectpropCount = 0;
                if (thingRodevicebatteryLevel != null)
                {
                    deviceObject["batteryLevel"] = ExpressionConverter.ConvertO(thingRodevicebatteryLevel);
                    deviceObjectpropCount++;
                }

                if (thingRodevicebatteryStatus != null)
                {
                    deviceObject["batteryStatus"] = ExpressionConverter.ConvertO(thingRodevicebatteryStatus);
                    deviceObjectpropCount++;
                }

                if (thingRodevicedeviceType != null)
                {
                    deviceObject["deviceType"] = ExpressionConverter.ConvertO(thingRodevicedeviceType);
                    deviceObjectpropCount++;
                }

                if (thingRodeviceid != null)
                {
                    deviceObject["id"] = ExpressionConverter.ConvertO(thingRodeviceid);
                    deviceObjectpropCount++;
                }

                if (thingRodevicemanufacturer != null)
                {
                    deviceObject["manufacturer"] = ExpressionConverter.ConvertO(thingRodevicemanufacturer);
                    deviceObjectpropCount++;
                }

                if (thingRodevicememoryFree != null)
                {
                    deviceObject["memoryFree"] = ExpressionConverter.ConvertO(thingRodevicememoryFree);
                    deviceObjectpropCount++;
                }

                if (thingRodevicememoryTotal != null)
                {
                    deviceObject["memoryTotal"] = ExpressionConverter.ConvertO(thingRodevicememoryTotal);
                    deviceObjectpropCount++;
                }

                if (thingRodevicemodel != null)
                {
                    deviceObject["model"] = ExpressionConverter.ConvertO(thingRodevicemodel);
                    deviceObjectpropCount++;
                }

                if (thingRodevicemodelNumber != null)
                {
                    deviceObject["modelNumber"] = ExpressionConverter.ConvertO(thingRodevicemodelNumber);
                    deviceObjectpropCount++;
                }

                if (thingRodevicename != null)
                {
                    deviceObject["name"] = ExpressionConverter.ConvertO(thingRodevicename);
                    deviceObjectpropCount++;
                }

                if (thingRodeviceserialNumber != null)
                {
                    deviceObject["serialNumber"] = ExpressionConverter.ConvertO(thingRodeviceserialNumber);
                    deviceObjectpropCount++;
                }

                if (thingRodevicestatus != null)
                {
                    deviceObject["status"] = ExpressionConverter.ConvertO(thingRodevicestatus);
                    deviceObjectpropCount++;
                }

                if (deviceObjectpropCount > 0)
                {
                    thingRo["device"] = deviceObject;
                    thingRopropCount++;
                }

                if (thingRodisplayName != null)
                {
                    thingRo["displayName"] = ExpressionConverter.ConvertO(thingRodisplayName);
                    thingRopropCount++;
                }

                if (thingRodynamicGps != null)
                {
                    thingRo["dynamicGps"] = ExpressionConverter.ConvertO(thingRodynamicGps);
                    thingRopropCount++;
                }

                if (thingRofixedLatitude != null)
                {
                    thingRo["fixedLatitude"] = ExpressionConverter.ConvertO(thingRofixedLatitude);
                    thingRopropCount++;
                }

                if (thingRofixedLongitude != null)
                {
                    thingRo["fixedLongitude"] = ExpressionConverter.ConvertO(thingRofixedLongitude);
                    thingRopropCount++;
                }

                if (thingRofixedName != null)
                {
                    thingRo["fixedName"] = ExpressionConverter.ConvertO(thingRofixedName);
                    thingRopropCount++;
                }

                if (thingRoid != null)
                {
                    thingRo["id"] = ExpressionConverter.ConvertO(thingRoid);
                    thingRopropCount++;
                }

                if (thingRolastActivityDate != null)
                {
                    thingRo["lastActivityDate"] = ExpressionConverter.ConvertO(thingRolastActivityDate);
                    thingRopropCount++;
                }

                if (thingRolastLatitude != null)
                {
                    thingRo["lastLatitude"] = ExpressionConverter.ConvertO(thingRolastLatitude);
                    thingRopropCount++;
                }

                if (thingRolastLongitude != null)
                {
                    thingRo["lastLongitude"] = ExpressionConverter.ConvertO(thingRolastLongitude);
                    thingRopropCount++;
                }

                var lastMeasurementsObject = new JObject();
                var lastMeasurementsObjectpropCount = 0;
                if (thingRolastMeasurementsarray != null)
                {
                    lastMeasurementsObject["array"] = ExpressionConverter.ConvertO(thingRolastMeasurementsarray);
                    lastMeasurementsObjectpropCount++;
                }

                if (thingRolastMeasurementsbigDecimal != null)
                {
                    lastMeasurementsObject["bigDecimal"] = ExpressionConverter.ConvertO(thingRolastMeasurementsbigDecimal);
                    lastMeasurementsObjectpropCount++;
                }

                if (thingRolastMeasurementsbigInteger != null)
                {
                    lastMeasurementsObject["bigInteger"] = ExpressionConverter.ConvertO(thingRolastMeasurementsbigInteger);
                    lastMeasurementsObjectpropCount++;
                }

                if (thingRolastMeasurementsbinary != null)
                {
                    lastMeasurementsObject["binary"] = ExpressionConverter.ConvertO(thingRolastMeasurementsbinary);
                    lastMeasurementsObjectpropCount++;
                }

                if (thingRolastMeasurementsboolean != null)
                {
                    lastMeasurementsObject["boolean"] = ExpressionConverter.ConvertO(thingRolastMeasurementsboolean);
                    lastMeasurementsObjectpropCount++;
                }

                if (thingRolastMeasurementscontainerNode != null)
                {
                    lastMeasurementsObject["containerNode"] = ExpressionConverter.ConvertO(thingRolastMeasurementscontainerNode);
                    lastMeasurementsObjectpropCount++;
                }

                if (thingRolastMeasurementsdouble != null)
                {
                    lastMeasurementsObject["double"] = ExpressionConverter.ConvertO(thingRolastMeasurementsdouble);
                    lastMeasurementsObjectpropCount++;
                }

                if (thingRolastMeasurementsfloat != null)
                {
                    lastMeasurementsObject["float"] = ExpressionConverter.ConvertO(thingRolastMeasurementsfloat);
                    lastMeasurementsObjectpropCount++;
                }

                if (thingRolastMeasurementsfloatingPointNumber != null)
                {
                    lastMeasurementsObject["floatingPointNumber"] = ExpressionConverter.ConvertO(thingRolastMeasurementsfloatingPointNumber);
                    lastMeasurementsObjectpropCount++;
                }

                if (thingRolastMeasurementsint != null)
                {
                    lastMeasurementsObject["int"] = ExpressionConverter.ConvertO(thingRolastMeasurementsint);
                    lastMeasurementsObjectpropCount++;
                }

                if (thingRolastMeasurementsintegralNumber != null)
                {
                    lastMeasurementsObject["integralNumber"] = ExpressionConverter.ConvertO(thingRolastMeasurementsintegralNumber);
                    lastMeasurementsObjectpropCount++;
                }

                if (thingRolastMeasurementsLong != null)
                {
                    lastMeasurementsObject["long"] = ExpressionConverter.ConvertO(thingRolastMeasurementsLong);
                    lastMeasurementsObjectpropCount++;
                }

                if (thingRolastMeasurementsmissingNode != null)
                {
                    lastMeasurementsObject["missingNode"] = ExpressionConverter.ConvertO(thingRolastMeasurementsmissingNode);
                    lastMeasurementsObjectpropCount++;
                }

                if (thingRolastMeasurementsnodeType != null)
                {
                    lastMeasurementsObject["nodeType"] = ExpressionConverter.ConvertO(thingRolastMeasurementsnodeType);
                    lastMeasurementsObjectpropCount++;
                }

                if (thingRolastMeasurementsnull != null)
                {
                    lastMeasurementsObject["null"] = ExpressionConverter.ConvertO(thingRolastMeasurementsnull);
                    lastMeasurementsObjectpropCount++;
                }

                if (thingRolastMeasurementsnumber != null)
                {
                    lastMeasurementsObject["number"] = ExpressionConverter.ConvertO(thingRolastMeasurementsnumber);
                    lastMeasurementsObjectpropCount++;
                }

                if (thingRolastMeasurementsObject != null)
                {
                    lastMeasurementsObject["object"] = ExpressionConverter.ConvertO(thingRolastMeasurementsObject);
                    lastMeasurementsObjectpropCount++;
                }

                if (thingRolastMeasurementspojo != null)
                {
                    lastMeasurementsObject["pojo"] = ExpressionConverter.ConvertO(thingRolastMeasurementspojo);
                    lastMeasurementsObjectpropCount++;
                }

                if (thingRolastMeasurementsShort != null)
                {
                    lastMeasurementsObject["short"] = ExpressionConverter.ConvertO(thingRolastMeasurementsShort);
                    lastMeasurementsObjectpropCount++;
                }

                if (thingRolastMeasurementstextual != null)
                {
                    lastMeasurementsObject["textual"] = ExpressionConverter.ConvertO(thingRolastMeasurementstextual);
                    lastMeasurementsObjectpropCount++;
                }

                if (thingRolastMeasurementsvalueNode != null)
                {
                    lastMeasurementsObject["valueNode"] = ExpressionConverter.ConvertO(thingRolastMeasurementsvalueNode);
                    lastMeasurementsObjectpropCount++;
                }

                if (lastMeasurementsObjectpropCount > 0)
                {
                    thingRo["lastMeasurements"] = lastMeasurementsObject;
                    thingRopropCount++;
                }

                var lastMeasurementsTimestampsObject = new JObject();
                var lastMeasurementsTimestampsObjectpropCount = 0;
                if (thingRolastMeasurementsarray != null)
                {
                    lastMeasurementsTimestampsObject["array"] = ExpressionConverter.ConvertO(thingRolastMeasurementsarray);
                    lastMeasurementsTimestampsObjectpropCount++;
                }

                if (thingRolastMeasurementsbigDecimal != null)
                {
                    lastMeasurementsTimestampsObject["bigDecimal"] = ExpressionConverter.ConvertO(thingRolastMeasurementsbigDecimal);
                    lastMeasurementsTimestampsObjectpropCount++;
                }

                if (thingRolastMeasurementsbigInteger != null)
                {
                    lastMeasurementsTimestampsObject["bigInteger"] = ExpressionConverter.ConvertO(thingRolastMeasurementsbigInteger);
                    lastMeasurementsTimestampsObjectpropCount++;
                }

                if (thingRolastMeasurementsbinary != null)
                {
                    lastMeasurementsTimestampsObject["binary"] = ExpressionConverter.ConvertO(thingRolastMeasurementsbinary);
                    lastMeasurementsTimestampsObjectpropCount++;
                }

                if (thingRolastMeasurementsboolean != null)
                {
                    lastMeasurementsTimestampsObject["boolean"] = ExpressionConverter.ConvertO(thingRolastMeasurementsboolean);
                    lastMeasurementsTimestampsObjectpropCount++;
                }

                if (thingRolastMeasurementscontainerNode != null)
                {
                    lastMeasurementsTimestampsObject["containerNode"] = ExpressionConverter.ConvertO(thingRolastMeasurementscontainerNode);
                    lastMeasurementsTimestampsObjectpropCount++;
                }

                if (thingRolastMeasurementsdouble != null)
                {
                    lastMeasurementsTimestampsObject["double"] = ExpressionConverter.ConvertO(thingRolastMeasurementsdouble);
                    lastMeasurementsTimestampsObjectpropCount++;
                }

                if (thingRolastMeasurementsfloat != null)
                {
                    lastMeasurementsTimestampsObject["float"] = ExpressionConverter.ConvertO(thingRolastMeasurementsfloat);
                    lastMeasurementsTimestampsObjectpropCount++;
                }

                if (thingRolastMeasurementsfloatingPointNumber != null)
                {
                    lastMeasurementsTimestampsObject["floatingPointNumber"] = ExpressionConverter.ConvertO(thingRolastMeasurementsfloatingPointNumber);
                    lastMeasurementsTimestampsObjectpropCount++;
                }

                if (thingRolastMeasurementsint != null)
                {
                    lastMeasurementsTimestampsObject["int"] = ExpressionConverter.ConvertO(thingRolastMeasurementsint);
                    lastMeasurementsTimestampsObjectpropCount++;
                }

                if (thingRolastMeasurementsintegralNumber != null)
                {
                    lastMeasurementsTimestampsObject["integralNumber"] = ExpressionConverter.ConvertO(thingRolastMeasurementsintegralNumber);
                    lastMeasurementsTimestampsObjectpropCount++;
                }

                if (thingRolastMeasurementsLong != null)
                {
                    lastMeasurementsTimestampsObject["long"] = ExpressionConverter.ConvertO(thingRolastMeasurementsLong);
                    lastMeasurementsTimestampsObjectpropCount++;
                }

                if (thingRolastMeasurementsmissingNode != null)
                {
                    lastMeasurementsTimestampsObject["missingNode"] = ExpressionConverter.ConvertO(thingRolastMeasurementsmissingNode);
                    lastMeasurementsTimestampsObjectpropCount++;
                }

                if (thingRolastMeasurementsnodeType != null)
                {
                    lastMeasurementsTimestampsObject["nodeType"] = ExpressionConverter.ConvertO(thingRolastMeasurementsnodeType);
                    lastMeasurementsTimestampsObjectpropCount++;
                }

                if (thingRolastMeasurementsnull != null)
                {
                    lastMeasurementsTimestampsObject["null"] = ExpressionConverter.ConvertO(thingRolastMeasurementsnull);
                    lastMeasurementsTimestampsObjectpropCount++;
                }

                if (thingRolastMeasurementsnumber != null)
                {
                    lastMeasurementsTimestampsObject["number"] = ExpressionConverter.ConvertO(thingRolastMeasurementsnumber);
                    lastMeasurementsTimestampsObjectpropCount++;
                }

                if (thingRolastMeasurementsObject != null)
                {
                    lastMeasurementsTimestampsObject["object"] = ExpressionConverter.ConvertO(thingRolastMeasurementsObject);
                    lastMeasurementsTimestampsObjectpropCount++;
                }

                if (thingRolastMeasurementspojo != null)
                {
                    lastMeasurementsTimestampsObject["pojo"] = ExpressionConverter.ConvertO(thingRolastMeasurementspojo);
                    lastMeasurementsTimestampsObjectpropCount++;
                }

                if (thingRolastMeasurementsShort != null)
                {
                    lastMeasurementsTimestampsObject["short"] = ExpressionConverter.ConvertO(thingRolastMeasurementsShort);
                    lastMeasurementsTimestampsObjectpropCount++;
                }

                if (thingRolastMeasurementstextual != null)
                {
                    lastMeasurementsTimestampsObject["textual"] = ExpressionConverter.ConvertO(thingRolastMeasurementstextual);
                    lastMeasurementsTimestampsObjectpropCount++;
                }

                if (thingRolastMeasurementsvalueNode != null)
                {
                    lastMeasurementsTimestampsObject["valueNode"] = ExpressionConverter.ConvertO(thingRolastMeasurementsvalueNode);
                    lastMeasurementsTimestampsObjectpropCount++;
                }

                if (lastMeasurementsTimestampsObjectpropCount > 0)
                {
                    thingRo["lastMeasurementsTimestamps"] = lastMeasurementsTimestampsObject;
                    thingRopropCount++;
                }

                if (thingRolastMessageDate != null)
                {
                    thingRo["lastMessageDate"] = ExpressionConverter.ConvertO(thingRolastMessageDate);
                    thingRopropCount++;
                }

                if (thingRomessageActivityTimeoutPeriod != null)
                {
                    thingRo["messageActivityTimeoutPeriod"] = ExpressionConverter.ConvertO(thingRomessageActivityTimeoutPeriod);
                    thingRopropCount++;
                }

                thingRopropCount++;
                thingRo["name"] = ExpressionConverter.ConvertO(thingRoname);
                if (thingRonbAlerts != null)
                {
                    thingRo["nbAlerts"] = ExpressionConverter.ConvertO(thingRonbAlerts);
                    thingRopropCount++;
                }

                var productObject = new JObject();
                var productObjectpropCount = 0;
                if (thingRoproductconnectivityTypes != null)
                {
                    productObject["connectivityTypes"] = ExpressionConverter.ConvertO(thingRoproductconnectivityTypes);
                    productObjectpropCount++;
                }

                if (thingRoproductgenerateLinks != null)
                {
                    productObject["generateLinks"] = ExpressionConverter.ConvertO(thingRoproductgenerateLinks);
                    productObjectpropCount++;
                }

                if (thingRoproductid != null)
                {
                    productObject["id"] = ExpressionConverter.ConvertO(thingRoproductid);
                    productObjectpropCount++;
                }

                if (thingRoproductlink != null)
                {
                    productObject["link"] = ExpressionConverter.ConvertO(thingRoproductlink);
                    productObjectpropCount++;
                }

                var manufacturerObject = new JObject();
                var manufacturerObjectpropCount = 0;
                if (thingRoproductmanufacturergenerateLinks != null)
                {
                    manufacturerObject["generateLinks"] = ExpressionConverter.ConvertO(thingRoproductmanufacturergenerateLinks);
                    manufacturerObjectpropCount++;
                }

                if (thingRoproductmanufacturerid != null)
                {
                    manufacturerObject["id"] = ExpressionConverter.ConvertO(thingRoproductmanufacturerid);
                    manufacturerObjectpropCount++;
                }

                if (thingRoproductmanufacturerlink != null)
                {
                    manufacturerObject["link"] = ExpressionConverter.ConvertO(thingRoproductmanufacturerlink);
                    manufacturerObjectpropCount++;
                }

                if (thingRoproductmanufacturername != null)
                {
                    manufacturerObject["name"] = ExpressionConverter.ConvertO(thingRoproductmanufacturername);
                    manufacturerObjectpropCount++;
                }

                if (manufacturerObjectpropCount > 0)
                {
                    productObject["manufacturer"] = manufacturerObject;
                    productObjectpropCount++;
                }

                var modelObject = new JObject();
                var modelObjectpropCount = 0;
                if (thingRoproductmodelcolor != null)
                {
                    modelObject["color"] = ExpressionConverter.ConvertO(thingRoproductmodelcolor);
                    modelObjectpropCount++;
                }

                if (thingRoproductmodelgenerateLinks != null)
                {
                    modelObject["generateLinks"] = ExpressionConverter.ConvertO(thingRoproductmodelgenerateLinks);
                    modelObjectpropCount++;
                }

                if (thingRoproductmodelicon != null)
                {
                    modelObject["icon"] = ExpressionConverter.ConvertO(thingRoproductmodelicon);
                    modelObjectpropCount++;
                }

                if (thingRoproductmodelid != null)
                {
                    modelObject["id"] = ExpressionConverter.ConvertO(thingRoproductmodelid);
                    modelObjectpropCount++;
                }

                if (thingRoproductmodelisCustomModel != null)
                {
                    modelObject["isCustomModel"] = ExpressionConverter.ConvertO(thingRoproductmodelisCustomModel);
                    modelObjectpropCount++;
                }

                var linkObject = new JObject();
                var linkObjectpropCount = 0;
                if (thingRoproductmodellinkabsolute != null)
                {
                    linkObject["absolute"] = ExpressionConverter.ConvertO(thingRoproductmodellinkabsolute);
                    linkObjectpropCount++;
                }

                if (thingRoproductmodellinkauthority != null)
                {
                    linkObject["authority"] = ExpressionConverter.ConvertO(thingRoproductmodellinkauthority);
                    linkObjectpropCount++;
                }

                if (thingRoproductmodellinkfragment != null)
                {
                    linkObject["fragment"] = ExpressionConverter.ConvertO(thingRoproductmodellinkfragment);
                    linkObjectpropCount++;
                }

                if (thingRoproductmodellinkhost != null)
                {
                    linkObject["host"] = ExpressionConverter.ConvertO(thingRoproductmodellinkhost);
                    linkObjectpropCount++;
                }

                if (thingRoproductmodellinkopaque != null)
                {
                    linkObject["opaque"] = ExpressionConverter.ConvertO(thingRoproductmodellinkopaque);
                    linkObjectpropCount++;
                }

                if (thingRoproductmodellinkpath != null)
                {
                    linkObject["path"] = ExpressionConverter.ConvertO(thingRoproductmodellinkpath);
                    linkObjectpropCount++;
                }

                if (thingRoproductmodellinkport != null)
                {
                    linkObject["port"] = ExpressionConverter.ConvertO(thingRoproductmodellinkport);
                    linkObjectpropCount++;
                }

                if (thingRoproductmodellinkquery != null)
                {
                    linkObject["query"] = ExpressionConverter.ConvertO(thingRoproductmodellinkquery);
                    linkObjectpropCount++;
                }

                if (thingRoproductmodellinkrawAuthority != null)
                {
                    linkObject["rawAuthority"] = ExpressionConverter.ConvertO(thingRoproductmodellinkrawAuthority);
                    linkObjectpropCount++;
                }

                if (thingRoproductmodellinkrawFragment != null)
                {
                    linkObject["rawFragment"] = ExpressionConverter.ConvertO(thingRoproductmodellinkrawFragment);
                    linkObjectpropCount++;
                }

                if (thingRoproductmodellinkrawPath != null)
                {
                    linkObject["rawPath"] = ExpressionConverter.ConvertO(thingRoproductmodellinkrawPath);
                    linkObjectpropCount++;
                }

                if (thingRoproductmodellinkrawQuery != null)
                {
                    linkObject["rawQuery"] = ExpressionConverter.ConvertO(thingRoproductmodellinkrawQuery);
                    linkObjectpropCount++;
                }

                if (thingRoproductmodellinkrawSchemeSpecificPart != null)
                {
                    linkObject["rawSchemeSpecificPart"] = ExpressionConverter.ConvertO(thingRoproductmodellinkrawSchemeSpecificPart);
                    linkObjectpropCount++;
                }

                if (thingRoproductmodellinkrawUserInfo != null)
                {
                    linkObject["rawUserInfo"] = ExpressionConverter.ConvertO(thingRoproductmodellinkrawUserInfo);
                    linkObjectpropCount++;
                }

                if (thingRoproductmodellinkscheme != null)
                {
                    linkObject["scheme"] = ExpressionConverter.ConvertO(thingRoproductmodellinkscheme);
                    linkObjectpropCount++;
                }

                if (thingRoproductmodellinkschemeSpecificPart != null)
                {
                    linkObject["schemeSpecificPart"] = ExpressionConverter.ConvertO(thingRoproductmodellinkschemeSpecificPart);
                    linkObjectpropCount++;
                }

                if (thingRoproductmodellinkuserInfo != null)
                {
                    linkObject["userInfo"] = ExpressionConverter.ConvertO(thingRoproductmodellinkuserInfo);
                    linkObjectpropCount++;
                }

                if (linkObjectpropCount > 0)
                {
                    modelObject["link"] = linkObject;
                    modelObjectpropCount++;
                }

                if (thingRoproductmodelname != null)
                {
                    modelObject["name"] = ExpressionConverter.ConvertO(thingRoproductmodelname);
                    modelObjectpropCount++;
                }

                if (modelObjectpropCount > 0)
                {
                    productObject["model"] = modelObject;
                    productObjectpropCount++;
                }

                if (thingRoproductname != null)
                {
                    productObject["name"] = ExpressionConverter.ConvertO(thingRoproductname);
                    productObjectpropCount++;
                }

                if (thingRoproductreference != null)
                {
                    productObject["reference"] = ExpressionConverter.ConvertO(thingRoproductreference);
                    productObjectpropCount++;
                }

                if (productObjectpropCount > 0)
                {
                    thingRo["product"] = productObject;
                    thingRopropCount++;
                }

                var siteObject = new JObject();
                var siteObjectpropCount = 0;
                siteObjectpropCount++;
                siteObject["address"] = ExpressionConverter.ConvertO(thingRositeaddress);
                siteObjectpropCount++;
                siteObject["city"] = ExpressionConverter.ConvertO(thingRositecity);
                if (thingRositeid != null)
                {
                    siteObject["id"] = ExpressionConverter.ConvertO(thingRositeid);
                    siteObjectpropCount++;
                }

                if (thingRositelatitude != null)
                {
                    siteObject["latitude"] = ExpressionConverter.ConvertO(thingRositelatitude);
                    siteObjectpropCount++;
                }

                if (thingRositelongitude != null)
                {
                    siteObject["longitude"] = ExpressionConverter.ConvertO(thingRositelongitude);
                    siteObjectpropCount++;
                }

                siteObjectpropCount++;
                siteObject["name"] = ExpressionConverter.ConvertO(thingRositename);
                siteObjectpropCount++;
                siteObject["postalCode"] = ExpressionConverter.ConvertO(thingRositepostalCode);
                if (siteObjectpropCount > 0)
                {
                    thingRo["site"] = siteObject;
                    thingRopropCount++;
                }

                if (thingRosourceId != null)
                {
                    thingRo["sourceId"] = ExpressionConverter.ConvertO(thingRosourceId);
                    thingRopropCount++;
                }

                if (thingRostatus != null)
                {
                    thingRo["status"] = ExpressionConverter.ConvertO(thingRostatus);
                    thingRopropCount++;
                }

                if (thingRotags != null)
                {
                    thingRo["tags"] = ExpressionConverter.ConvertO(thingRotags);
                    thingRopropCount++;
                }

                if (thingRopropCount > 0)
                {
                    callPayload.Body = thingRo;
                }

                return new ApiConnectionAction<ThingRo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        [WorkflowExpressionFactory(nameof(__BuildGetThingActiveModel))]
        public IBodyWorkflowAction<ModelRo> GetThingActiveModel([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ModelRo> __BuildGetThingActiveModel(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<ModelRo>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/things/{0}/active_model", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ModelRo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        [WorkflowExpressionFactory(nameof(__BuildGetCustomField))]
        public IBodyWorkflowAction<PageCustomFieldRo> GetCustomField([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PageCustomFieldRo> __BuildGetCustomField(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<PageCustomFieldRo>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/things/{0}/custom_fields", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<PageCustomFieldRo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        [WorkflowExpressionFactory(nameof(__BuildCreateCustomField))]
        public IBodyWorkflowAction<CustomFieldRo> CreateCustomField([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> customFieldRoid = null, [WorkflowExpression] Func<string> customFieldRoimageLink = null, [WorkflowExpression] Func<string> customFieldRolabel = null, [WorkflowExpression] Func<string> customFieldRoname = null, [WorkflowExpression] Func<customFieldRotypeInput> customFieldRotype = null, [WorkflowExpression] Func<string> customFieldRovalue = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CustomFieldRo> __BuildCreateCustomField(WorkflowExpression<string> id, WorkflowExpression<string> customFieldRoid = null, WorkflowExpression<string> customFieldRoimageLink = null, WorkflowExpression<string> customFieldRolabel = null, WorkflowExpression<string> customFieldRoname = null, WorkflowExpression<customFieldRotypeInput> customFieldRotype = null, WorkflowExpression<string> customFieldRovalue = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(customFieldRoid, nameof(customFieldRoid), required: false);
            WorkflowExpression.Validate(customFieldRoimageLink, nameof(customFieldRoimageLink), required: false);
            WorkflowExpression.Validate(customFieldRolabel, nameof(customFieldRolabel), required: false);
            WorkflowExpression.Validate(customFieldRoname, nameof(customFieldRoname), required: false);
            WorkflowExpression.Validate(customFieldRotype, nameof(customFieldRotype), required: false);
            WorkflowExpression.Validate(customFieldRovalue, nameof(customFieldRovalue), required: false);
            return new DeferredBodyAction<CustomFieldRo>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/things/{0}/custom_fields", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var customFieldRo = new JObject();
                var customFieldRopropCount = 0;
                if (customFieldRoid != null)
                {
                    customFieldRo["id"] = ExpressionConverter.ConvertO(customFieldRoid);
                    customFieldRopropCount++;
                }

                if (customFieldRoimageLink != null)
                {
                    customFieldRo["imageLink"] = ExpressionConverter.ConvertO(customFieldRoimageLink);
                    customFieldRopropCount++;
                }

                if (customFieldRolabel != null)
                {
                    customFieldRo["label"] = ExpressionConverter.ConvertO(customFieldRolabel);
                    customFieldRopropCount++;
                }

                if (customFieldRoname != null)
                {
                    customFieldRo["name"] = ExpressionConverter.ConvertO(customFieldRoname);
                    customFieldRopropCount++;
                }

                if (customFieldRotype != null)
                {
                    customFieldRo["type"] = ExpressionConverter.ConvertO(customFieldRotype);
                    customFieldRopropCount++;
                }

                if (customFieldRovalue != null)
                {
                    customFieldRo["value"] = ExpressionConverter.ConvertO(customFieldRovalue);
                    customFieldRopropCount++;
                }

                if (customFieldRopropCount > 0)
                {
                    callPayload.Body = customFieldRo;
                }

                return new ApiConnectionAction<CustomFieldRo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateCustomField))]
        public IBodyWorkflowAction<CustomFieldRo> UpdateCustomField([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> customFieldRoid = null, [WorkflowExpression] Func<string> customFieldRoimageLink = null, [WorkflowExpression] Func<string> customFieldRolabel = null, [WorkflowExpression] Func<string> customFieldRoname = null, [WorkflowExpression] Func<customFieldRotypeInput> customFieldRotype = null, [WorkflowExpression] Func<string> customFieldRovalue = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CustomFieldRo> __BuildUpdateCustomField(WorkflowExpression<string> id, WorkflowExpression<string> customFieldRoid = null, WorkflowExpression<string> customFieldRoimageLink = null, WorkflowExpression<string> customFieldRolabel = null, WorkflowExpression<string> customFieldRoname = null, WorkflowExpression<customFieldRotypeInput> customFieldRotype = null, WorkflowExpression<string> customFieldRovalue = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(customFieldRoid, nameof(customFieldRoid), required: false);
            WorkflowExpression.Validate(customFieldRoimageLink, nameof(customFieldRoimageLink), required: false);
            WorkflowExpression.Validate(customFieldRolabel, nameof(customFieldRolabel), required: false);
            WorkflowExpression.Validate(customFieldRoname, nameof(customFieldRoname), required: false);
            WorkflowExpression.Validate(customFieldRotype, nameof(customFieldRotype), required: false);
            WorkflowExpression.Validate(customFieldRovalue, nameof(customFieldRovalue), required: false);
            return new DeferredBodyAction<CustomFieldRo>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/things/{0}/custom_fields", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var customFieldRo = new JObject();
                var customFieldRopropCount = 0;
                if (customFieldRoid != null)
                {
                    customFieldRo["id"] = ExpressionConverter.ConvertO(customFieldRoid);
                    customFieldRopropCount++;
                }

                if (customFieldRoimageLink != null)
                {
                    customFieldRo["imageLink"] = ExpressionConverter.ConvertO(customFieldRoimageLink);
                    customFieldRopropCount++;
                }

                if (customFieldRolabel != null)
                {
                    customFieldRo["label"] = ExpressionConverter.ConvertO(customFieldRolabel);
                    customFieldRopropCount++;
                }

                if (customFieldRoname != null)
                {
                    customFieldRo["name"] = ExpressionConverter.ConvertO(customFieldRoname);
                    customFieldRopropCount++;
                }

                if (customFieldRotype != null)
                {
                    customFieldRo["type"] = ExpressionConverter.ConvertO(customFieldRotype);
                    customFieldRopropCount++;
                }

                if (customFieldRovalue != null)
                {
                    customFieldRo["value"] = ExpressionConverter.ConvertO(customFieldRovalue);
                    customFieldRopropCount++;
                }

                if (customFieldRopropCount > 0)
                {
                    callPayload.Body = customFieldRo;
                }

                return new ApiConnectionAction<CustomFieldRo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteCustomField))]
        public IBodyWorkflowAction<ResponseEntity> DeleteCustomField([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> fieldId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResponseEntity> __BuildDeleteCustomField(WorkflowExpression<string> id, WorkflowExpression<string> fieldId)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(fieldId, nameof(fieldId), required: true);
            return new DeferredBodyAction<ResponseEntity>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/things/{0}/custom_fields/{1}", ExpressionConverter.ConvertWithUrlEncoding(id, 1), ExpressionConverter.ConvertWithUrlEncoding(fieldId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ResponseEntity>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        [WorkflowExpressionFactory(nameof(__BuildGetCustomFieldImage))]
        public IBodyWorkflowAction<ResponseEntity> GetCustomFieldImage([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> fieldId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResponseEntity> __BuildGetCustomFieldImage(WorkflowExpression<string> id, WorkflowExpression<string> fieldId)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(fieldId, nameof(fieldId), required: true);
            return new DeferredBodyAction<ResponseEntity>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/things/{0}/custom_fields/{1}/image", ExpressionConverter.ConvertWithUrlEncoding(id, 1), ExpressionConverter.ConvertWithUrlEncoding(fieldId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ResponseEntity>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        [WorkflowExpressionFactory(nameof(__BuildPostCustomFieldImage))]
        public IBodyWorkflowAction<ResponseEntity> PostCustomFieldImage([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> fieldId, [WorkflowExpression] Func<object> file)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResponseEntity> __BuildPostCustomFieldImage(WorkflowExpression<string> id, WorkflowExpression<string> fieldId, WorkflowExpression<object> file)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(fieldId, nameof(fieldId), required: true);
            WorkflowExpression.Validate(file, nameof(file), required: true);
            return new DeferredBodyAction<ResponseEntity>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/things/{0}/custom_fields/{1}/image", ExpressionConverter.ConvertWithUrlEncoding(id, 1), ExpressionConverter.ConvertWithUrlEncoding(fieldId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ResponseEntity>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        [WorkflowExpressionFactory(nameof(__BuildGetThingImage))]
        public IBodyWorkflowAction<ResponseEntity> GetThingImage([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResponseEntity> __BuildGetThingImage(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<ResponseEntity>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/things/{0}/image", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ResponseEntity>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        [WorkflowExpressionFactory(nameof(__BuildGetLastMeasures))]
        public IBodyWorkflowAction<MeasureTinyRo[]> GetLastMeasures([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MeasureTinyRo[]> __BuildGetLastMeasures(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<MeasureTinyRo[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/things/{0}/last_measurements", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<MeasureTinyRo[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        [WorkflowExpressionFactory(nameof(__BuildGetLastMessage))]
        public IBodyWorkflowAction<MessageTinyRo> GetLastMessage([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MessageTinyRo> __BuildGetLastMessage(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<MessageTinyRo>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/things/{0}/last_message", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<MessageTinyRo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        [WorkflowExpressionFactory(nameof(__BuildGetThingMeasures))]
        public IBodyWorkflowAction<PageMeasureRo> GetThingMeasures([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<bool> detailed = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null, [WorkflowExpression] Func<string> sortValues = null, [WorkflowExpression] Func<string> sort = null, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<dirInput> dir = null, [WorkflowExpression] Func<string> orFilter = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PageMeasureRo> __BuildGetThingMeasures(WorkflowExpression<string> id, WorkflowExpression<bool> detailed = null, WorkflowExpression<int> page = null, WorkflowExpression<int> pageSize = null, WorkflowExpression<string> sortValues = null, WorkflowExpression<string> sort = null, WorkflowExpression<string> filter = null, WorkflowExpression<dirInput> dir = null, WorkflowExpression<string> orFilter = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(detailed, nameof(detailed), required: false);
            WorkflowExpression.Validate(page, nameof(page), required: false);
            WorkflowExpression.Validate(pageSize, nameof(pageSize), required: false);
            WorkflowExpression.Validate(sortValues, nameof(sortValues), required: false);
            WorkflowExpression.Validate(sort, nameof(sort), required: false);
            WorkflowExpression.Validate(filter, nameof(filter), required: false);
            WorkflowExpression.Validate(dir, nameof(dir), required: false);
            WorkflowExpression.Validate(orFilter, nameof(orFilter), required: false);
            return new DeferredBodyAction<PageMeasureRo>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/things/{0}/measures", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["detailed"] = Convert.ToString(false);
                if (detailed != null)
                    callPayload.Queries["detailed"] = ExpressionConverter.Convert(detailed);
                if (page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(page);
                if (pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(pageSize);
                if (sortValues != null)
                    callPayload.Queries["sortValues"] = ExpressionConverter.Convert(sortValues);
                if (sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(sort);
                if (filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(filter);
                if (dir != null)
                    callPayload.Queries["dir"] = ExpressionConverter.Convert(dir);
                if (orFilter != null)
                    callPayload.Queries["orFilter"] = ExpressionConverter.Convert(orFilter);
                return new ApiConnectionAction<PageMeasureRo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        [WorkflowExpressionFactory(nameof(__BuildGetThingMessages))]
        public IBodyWorkflowAction<PageMessageRo> GetThingMessages([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null, [WorkflowExpression] Func<string> sortValues = null, [WorkflowExpression] Func<string> sort = null, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<dirInput> dir = null, [WorkflowExpression] Func<string> orFilter = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PageMessageRo> __BuildGetThingMessages(WorkflowExpression<string> id, WorkflowExpression<int> page = null, WorkflowExpression<int> pageSize = null, WorkflowExpression<string> sortValues = null, WorkflowExpression<string> sort = null, WorkflowExpression<string> filter = null, WorkflowExpression<dirInput> dir = null, WorkflowExpression<string> orFilter = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(page, nameof(page), required: false);
            WorkflowExpression.Validate(pageSize, nameof(pageSize), required: false);
            WorkflowExpression.Validate(sortValues, nameof(sortValues), required: false);
            WorkflowExpression.Validate(sort, nameof(sort), required: false);
            WorkflowExpression.Validate(filter, nameof(filter), required: false);
            WorkflowExpression.Validate(dir, nameof(dir), required: false);
            WorkflowExpression.Validate(orFilter, nameof(orFilter), required: false);
            return new DeferredBodyAction<PageMessageRo>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/things/{0}/messages", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(page);
                if (pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(pageSize);
                if (sortValues != null)
                    callPayload.Queries["sortValues"] = ExpressionConverter.Convert(sortValues);
                if (sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(sort);
                if (filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(filter);
                if (dir != null)
                    callPayload.Queries["dir"] = ExpressionConverter.Convert(dir);
                if (orFilter != null)
                    callPayload.Queries["orFilter"] = ExpressionConverter.Convert(orFilter);
                return new ApiConnectionAction<PageMessageRo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteThingMessages))]
        public IWorkflowAction DeleteThingMessages([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeleteThingMessages(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/things/{0}/messages", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        [WorkflowExpressionFactory(nameof(__BuildCreateThingMessages))]
        public IBodyWorkflowAction<MessageRo> CreateThingMessages([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> messageRobody, [WorkflowExpression] Func<string> messageRocreationDate, [WorkflowExpression] Func<string> messageRoerrorMessage, [WorkflowExpression] Func<double> messageRolatitude, [WorkflowExpression] Func<double> messageRolongitude, [WorkflowExpression] Func<string> messageRometadata, [WorkflowExpression] Func<int> messageRonumber, [WorkflowExpression] Func<messageRoprocessedInput> messageRoprocessed, [WorkflowExpression] Func<string> messageRothingname, [WorkflowExpression] Func<string> messageRotimestamp, [WorkflowExpression] Func<string> messageRotopic, [WorkflowExpression] Func<string> messageRoid = null, [WorkflowExpression] Func<bool> messageRolinkabsolute = null, [WorkflowExpression] Func<string> messageRolinkauthority = null, [WorkflowExpression] Func<string> messageRolinkfragment = null, [WorkflowExpression] Func<string> messageRolinkhost = null, [WorkflowExpression] Func<bool> messageRolinkopaque = null, [WorkflowExpression] Func<string> messageRolinkpath = null, [WorkflowExpression] Func<int> messageRolinkport = null, [WorkflowExpression] Func<string> messageRolinkquery = null, [WorkflowExpression] Func<string> messageRolinkrawAuthority = null, [WorkflowExpression] Func<string> messageRolinkrawFragment = null, [WorkflowExpression] Func<string> messageRolinkrawPath = null, [WorkflowExpression] Func<string> messageRolinkrawQuery = null, [WorkflowExpression] Func<string> messageRolinkrawSchemeSpecificPart = null, [WorkflowExpression] Func<string> messageRolinkrawUserInfo = null, [WorkflowExpression] Func<string> messageRolinkscheme = null, [WorkflowExpression] Func<string> messageRolinkschemeSpecificPart = null, [WorkflowExpression] Func<string> messageRolinkuserInfo = null, [WorkflowExpression] Func<bool> messageRomeasurementsarray = null, [WorkflowExpression] Func<bool> messageRomeasurementsbigDecimal = null, [WorkflowExpression] Func<bool> messageRomeasurementsbigInteger = null, [WorkflowExpression] Func<bool> messageRomeasurementsbinary = null, [WorkflowExpression] Func<bool> messageRomeasurementsboolean = null, [WorkflowExpression] Func<bool> messageRomeasurementscontainerNode = null, [WorkflowExpression] Func<bool> messageRomeasurementsdouble = null, [WorkflowExpression] Func<bool> messageRomeasurementsfloat = null, [WorkflowExpression] Func<bool> messageRomeasurementsfloatingPointNumber = null, [WorkflowExpression] Func<bool> messageRomeasurementsint = null, [WorkflowExpression] Func<bool> messageRomeasurementsintegralNumber = null, [WorkflowExpression] Func<bool> messageRomeasurementsLong = null, [WorkflowExpression] Func<bool> messageRomeasurementsmissingNode = null, [WorkflowExpression] Func<messageRomeasurementsnodeTypeInput> messageRomeasurementsnodeType = null, [WorkflowExpression] Func<bool> messageRomeasurementsnull = null, [WorkflowExpression] Func<bool> messageRomeasurementsnumber = null, [WorkflowExpression] Func<bool> messageRomeasurementsObject = null, [WorkflowExpression] Func<bool> messageRomeasurementspojo = null, [WorkflowExpression] Func<bool> messageRomeasurementsShort = null, [WorkflowExpression] Func<bool> messageRomeasurementstextual = null, [WorkflowExpression] Func<bool> messageRomeasurementsvalueNode = null, [WorkflowExpression] Func<bool> messageRorawMeasurementsarray = null, [WorkflowExpression] Func<bool> messageRorawMeasurementsbigDecimal = null, [WorkflowExpression] Func<bool> messageRorawMeasurementsbigInteger = null, [WorkflowExpression] Func<bool> messageRorawMeasurementsbinary = null, [WorkflowExpression] Func<bool> messageRorawMeasurementsboolean = null, [WorkflowExpression] Func<bool> messageRorawMeasurementscontainerNode = null, [WorkflowExpression] Func<bool> messageRorawMeasurementsdouble = null, [WorkflowExpression] Func<bool> messageRorawMeasurementsfloat = null, [WorkflowExpression] Func<bool> messageRorawMeasurementsfloatingPointNumber = null, [WorkflowExpression] Func<bool> messageRorawMeasurementsint = null, [WorkflowExpression] Func<bool> messageRorawMeasurementsintegralNumber = null, [WorkflowExpression] Func<bool> messageRorawMeasurementsLong = null, [WorkflowExpression] Func<bool> messageRorawMeasurementsmissingNode = null, [WorkflowExpression] Func<messageRorawMeasurementsnodeTypeInput> messageRorawMeasurementsnodeType = null, [WorkflowExpression] Func<bool> messageRorawMeasurementsnull = null, [WorkflowExpression] Func<bool> messageRorawMeasurementsnumber = null, [WorkflowExpression] Func<bool> messageRorawMeasurementsObject = null, [WorkflowExpression] Func<bool> messageRorawMeasurementspojo = null, [WorkflowExpression] Func<bool> messageRorawMeasurementsShort = null, [WorkflowExpression] Func<bool> messageRorawMeasurementstextual = null, [WorkflowExpression] Func<bool> messageRorawMeasurementsvalueNode = null, [WorkflowExpression] Func<string> messageRothingdisplayName = null, [WorkflowExpression] Func<string> messageRothingfixedName = null, [WorkflowExpression] Func<string> messageRothingid = null, [WorkflowExpression] Func<int> messageRothingnbAlerts = null, [WorkflowExpression] Func<ThingTagRo[]> messageRothingtags = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MessageRo> __BuildCreateThingMessages(WorkflowExpression<string> id, WorkflowExpression<string> messageRobody, WorkflowExpression<string> messageRocreationDate, WorkflowExpression<string> messageRoerrorMessage, WorkflowExpression<double> messageRolatitude, WorkflowExpression<double> messageRolongitude, WorkflowExpression<string> messageRometadata, WorkflowExpression<int> messageRonumber, WorkflowExpression<messageRoprocessedInput> messageRoprocessed, WorkflowExpression<string> messageRothingname, WorkflowExpression<string> messageRotimestamp, WorkflowExpression<string> messageRotopic, WorkflowExpression<string> messageRoid = null, WorkflowExpression<bool> messageRolinkabsolute = null, WorkflowExpression<string> messageRolinkauthority = null, WorkflowExpression<string> messageRolinkfragment = null, WorkflowExpression<string> messageRolinkhost = null, WorkflowExpression<bool> messageRolinkopaque = null, WorkflowExpression<string> messageRolinkpath = null, WorkflowExpression<int> messageRolinkport = null, WorkflowExpression<string> messageRolinkquery = null, WorkflowExpression<string> messageRolinkrawAuthority = null, WorkflowExpression<string> messageRolinkrawFragment = null, WorkflowExpression<string> messageRolinkrawPath = null, WorkflowExpression<string> messageRolinkrawQuery = null, WorkflowExpression<string> messageRolinkrawSchemeSpecificPart = null, WorkflowExpression<string> messageRolinkrawUserInfo = null, WorkflowExpression<string> messageRolinkscheme = null, WorkflowExpression<string> messageRolinkschemeSpecificPart = null, WorkflowExpression<string> messageRolinkuserInfo = null, WorkflowExpression<bool> messageRomeasurementsarray = null, WorkflowExpression<bool> messageRomeasurementsbigDecimal = null, WorkflowExpression<bool> messageRomeasurementsbigInteger = null, WorkflowExpression<bool> messageRomeasurementsbinary = null, WorkflowExpression<bool> messageRomeasurementsboolean = null, WorkflowExpression<bool> messageRomeasurementscontainerNode = null, WorkflowExpression<bool> messageRomeasurementsdouble = null, WorkflowExpression<bool> messageRomeasurementsfloat = null, WorkflowExpression<bool> messageRomeasurementsfloatingPointNumber = null, WorkflowExpression<bool> messageRomeasurementsint = null, WorkflowExpression<bool> messageRomeasurementsintegralNumber = null, WorkflowExpression<bool> messageRomeasurementsLong = null, WorkflowExpression<bool> messageRomeasurementsmissingNode = null, WorkflowExpression<messageRomeasurementsnodeTypeInput> messageRomeasurementsnodeType = null, WorkflowExpression<bool> messageRomeasurementsnull = null, WorkflowExpression<bool> messageRomeasurementsnumber = null, WorkflowExpression<bool> messageRomeasurementsObject = null, WorkflowExpression<bool> messageRomeasurementspojo = null, WorkflowExpression<bool> messageRomeasurementsShort = null, WorkflowExpression<bool> messageRomeasurementstextual = null, WorkflowExpression<bool> messageRomeasurementsvalueNode = null, WorkflowExpression<bool> messageRorawMeasurementsarray = null, WorkflowExpression<bool> messageRorawMeasurementsbigDecimal = null, WorkflowExpression<bool> messageRorawMeasurementsbigInteger = null, WorkflowExpression<bool> messageRorawMeasurementsbinary = null, WorkflowExpression<bool> messageRorawMeasurementsboolean = null, WorkflowExpression<bool> messageRorawMeasurementscontainerNode = null, WorkflowExpression<bool> messageRorawMeasurementsdouble = null, WorkflowExpression<bool> messageRorawMeasurementsfloat = null, WorkflowExpression<bool> messageRorawMeasurementsfloatingPointNumber = null, WorkflowExpression<bool> messageRorawMeasurementsint = null, WorkflowExpression<bool> messageRorawMeasurementsintegralNumber = null, WorkflowExpression<bool> messageRorawMeasurementsLong = null, WorkflowExpression<bool> messageRorawMeasurementsmissingNode = null, WorkflowExpression<messageRorawMeasurementsnodeTypeInput> messageRorawMeasurementsnodeType = null, WorkflowExpression<bool> messageRorawMeasurementsnull = null, WorkflowExpression<bool> messageRorawMeasurementsnumber = null, WorkflowExpression<bool> messageRorawMeasurementsObject = null, WorkflowExpression<bool> messageRorawMeasurementspojo = null, WorkflowExpression<bool> messageRorawMeasurementsShort = null, WorkflowExpression<bool> messageRorawMeasurementstextual = null, WorkflowExpression<bool> messageRorawMeasurementsvalueNode = null, WorkflowExpression<string> messageRothingdisplayName = null, WorkflowExpression<string> messageRothingfixedName = null, WorkflowExpression<string> messageRothingid = null, WorkflowExpression<int> messageRothingnbAlerts = null, WorkflowExpression<ThingTagRo[]> messageRothingtags = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(messageRobody, nameof(messageRobody), required: true);
            WorkflowExpression.Validate(messageRocreationDate, nameof(messageRocreationDate), required: true);
            WorkflowExpression.Validate(messageRoerrorMessage, nameof(messageRoerrorMessage), required: true);
            WorkflowExpression.Validate(messageRolatitude, nameof(messageRolatitude), required: true);
            WorkflowExpression.Validate(messageRolongitude, nameof(messageRolongitude), required: true);
            WorkflowExpression.Validate(messageRometadata, nameof(messageRometadata), required: true);
            WorkflowExpression.Validate(messageRonumber, nameof(messageRonumber), required: true);
            WorkflowExpression.Validate(messageRoprocessed, nameof(messageRoprocessed), required: true);
            WorkflowExpression.Validate(messageRothingname, nameof(messageRothingname), required: true);
            WorkflowExpression.Validate(messageRotimestamp, nameof(messageRotimestamp), required: true);
            WorkflowExpression.Validate(messageRotopic, nameof(messageRotopic), required: true);
            WorkflowExpression.Validate(messageRoid, nameof(messageRoid), required: false);
            WorkflowExpression.Validate(messageRolinkabsolute, nameof(messageRolinkabsolute), required: false);
            WorkflowExpression.Validate(messageRolinkauthority, nameof(messageRolinkauthority), required: false);
            WorkflowExpression.Validate(messageRolinkfragment, nameof(messageRolinkfragment), required: false);
            WorkflowExpression.Validate(messageRolinkhost, nameof(messageRolinkhost), required: false);
            WorkflowExpression.Validate(messageRolinkopaque, nameof(messageRolinkopaque), required: false);
            WorkflowExpression.Validate(messageRolinkpath, nameof(messageRolinkpath), required: false);
            WorkflowExpression.Validate(messageRolinkport, nameof(messageRolinkport), required: false);
            WorkflowExpression.Validate(messageRolinkquery, nameof(messageRolinkquery), required: false);
            WorkflowExpression.Validate(messageRolinkrawAuthority, nameof(messageRolinkrawAuthority), required: false);
            WorkflowExpression.Validate(messageRolinkrawFragment, nameof(messageRolinkrawFragment), required: false);
            WorkflowExpression.Validate(messageRolinkrawPath, nameof(messageRolinkrawPath), required: false);
            WorkflowExpression.Validate(messageRolinkrawQuery, nameof(messageRolinkrawQuery), required: false);
            WorkflowExpression.Validate(messageRolinkrawSchemeSpecificPart, nameof(messageRolinkrawSchemeSpecificPart), required: false);
            WorkflowExpression.Validate(messageRolinkrawUserInfo, nameof(messageRolinkrawUserInfo), required: false);
            WorkflowExpression.Validate(messageRolinkscheme, nameof(messageRolinkscheme), required: false);
            WorkflowExpression.Validate(messageRolinkschemeSpecificPart, nameof(messageRolinkschemeSpecificPart), required: false);
            WorkflowExpression.Validate(messageRolinkuserInfo, nameof(messageRolinkuserInfo), required: false);
            WorkflowExpression.Validate(messageRomeasurementsarray, nameof(messageRomeasurementsarray), required: false);
            WorkflowExpression.Validate(messageRomeasurementsbigDecimal, nameof(messageRomeasurementsbigDecimal), required: false);
            WorkflowExpression.Validate(messageRomeasurementsbigInteger, nameof(messageRomeasurementsbigInteger), required: false);
            WorkflowExpression.Validate(messageRomeasurementsbinary, nameof(messageRomeasurementsbinary), required: false);
            WorkflowExpression.Validate(messageRomeasurementsboolean, nameof(messageRomeasurementsboolean), required: false);
            WorkflowExpression.Validate(messageRomeasurementscontainerNode, nameof(messageRomeasurementscontainerNode), required: false);
            WorkflowExpression.Validate(messageRomeasurementsdouble, nameof(messageRomeasurementsdouble), required: false);
            WorkflowExpression.Validate(messageRomeasurementsfloat, nameof(messageRomeasurementsfloat), required: false);
            WorkflowExpression.Validate(messageRomeasurementsfloatingPointNumber, nameof(messageRomeasurementsfloatingPointNumber), required: false);
            WorkflowExpression.Validate(messageRomeasurementsint, nameof(messageRomeasurementsint), required: false);
            WorkflowExpression.Validate(messageRomeasurementsintegralNumber, nameof(messageRomeasurementsintegralNumber), required: false);
            WorkflowExpression.Validate(messageRomeasurementsLong, nameof(messageRomeasurementsLong), required: false);
            WorkflowExpression.Validate(messageRomeasurementsmissingNode, nameof(messageRomeasurementsmissingNode), required: false);
            WorkflowExpression.Validate(messageRomeasurementsnodeType, nameof(messageRomeasurementsnodeType), required: false);
            WorkflowExpression.Validate(messageRomeasurementsnull, nameof(messageRomeasurementsnull), required: false);
            WorkflowExpression.Validate(messageRomeasurementsnumber, nameof(messageRomeasurementsnumber), required: false);
            WorkflowExpression.Validate(messageRomeasurementsObject, nameof(messageRomeasurementsObject), required: false);
            WorkflowExpression.Validate(messageRomeasurementspojo, nameof(messageRomeasurementspojo), required: false);
            WorkflowExpression.Validate(messageRomeasurementsShort, nameof(messageRomeasurementsShort), required: false);
            WorkflowExpression.Validate(messageRomeasurementstextual, nameof(messageRomeasurementstextual), required: false);
            WorkflowExpression.Validate(messageRomeasurementsvalueNode, nameof(messageRomeasurementsvalueNode), required: false);
            WorkflowExpression.Validate(messageRorawMeasurementsarray, nameof(messageRorawMeasurementsarray), required: false);
            WorkflowExpression.Validate(messageRorawMeasurementsbigDecimal, nameof(messageRorawMeasurementsbigDecimal), required: false);
            WorkflowExpression.Validate(messageRorawMeasurementsbigInteger, nameof(messageRorawMeasurementsbigInteger), required: false);
            WorkflowExpression.Validate(messageRorawMeasurementsbinary, nameof(messageRorawMeasurementsbinary), required: false);
            WorkflowExpression.Validate(messageRorawMeasurementsboolean, nameof(messageRorawMeasurementsboolean), required: false);
            WorkflowExpression.Validate(messageRorawMeasurementscontainerNode, nameof(messageRorawMeasurementscontainerNode), required: false);
            WorkflowExpression.Validate(messageRorawMeasurementsdouble, nameof(messageRorawMeasurementsdouble), required: false);
            WorkflowExpression.Validate(messageRorawMeasurementsfloat, nameof(messageRorawMeasurementsfloat), required: false);
            WorkflowExpression.Validate(messageRorawMeasurementsfloatingPointNumber, nameof(messageRorawMeasurementsfloatingPointNumber), required: false);
            WorkflowExpression.Validate(messageRorawMeasurementsint, nameof(messageRorawMeasurementsint), required: false);
            WorkflowExpression.Validate(messageRorawMeasurementsintegralNumber, nameof(messageRorawMeasurementsintegralNumber), required: false);
            WorkflowExpression.Validate(messageRorawMeasurementsLong, nameof(messageRorawMeasurementsLong), required: false);
            WorkflowExpression.Validate(messageRorawMeasurementsmissingNode, nameof(messageRorawMeasurementsmissingNode), required: false);
            WorkflowExpression.Validate(messageRorawMeasurementsnodeType, nameof(messageRorawMeasurementsnodeType), required: false);
            WorkflowExpression.Validate(messageRorawMeasurementsnull, nameof(messageRorawMeasurementsnull), required: false);
            WorkflowExpression.Validate(messageRorawMeasurementsnumber, nameof(messageRorawMeasurementsnumber), required: false);
            WorkflowExpression.Validate(messageRorawMeasurementsObject, nameof(messageRorawMeasurementsObject), required: false);
            WorkflowExpression.Validate(messageRorawMeasurementspojo, nameof(messageRorawMeasurementspojo), required: false);
            WorkflowExpression.Validate(messageRorawMeasurementsShort, nameof(messageRorawMeasurementsShort), required: false);
            WorkflowExpression.Validate(messageRorawMeasurementstextual, nameof(messageRorawMeasurementstextual), required: false);
            WorkflowExpression.Validate(messageRorawMeasurementsvalueNode, nameof(messageRorawMeasurementsvalueNode), required: false);
            WorkflowExpression.Validate(messageRothingdisplayName, nameof(messageRothingdisplayName), required: false);
            WorkflowExpression.Validate(messageRothingfixedName, nameof(messageRothingfixedName), required: false);
            WorkflowExpression.Validate(messageRothingid, nameof(messageRothingid), required: false);
            WorkflowExpression.Validate(messageRothingnbAlerts, nameof(messageRothingnbAlerts), required: false);
            WorkflowExpression.Validate(messageRothingtags, nameof(messageRothingtags), required: false);
            return new DeferredBodyAction<MessageRo>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/things/{0}/messages", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var messageRo = new JObject();
                var messageRopropCount = 0;
                messageRopropCount++;
                messageRo["body"] = ExpressionConverter.ConvertO(messageRobody);
                messageRopropCount++;
                messageRo["creationDate"] = ExpressionConverter.ConvertO(messageRocreationDate);
                messageRopropCount++;
                messageRo["errorMessage"] = ExpressionConverter.ConvertO(messageRoerrorMessage);
                if (messageRoid != null)
                {
                    messageRo["id"] = ExpressionConverter.ConvertO(messageRoid);
                    messageRopropCount++;
                }

                messageRopropCount++;
                messageRo["latitude"] = ExpressionConverter.ConvertO(messageRolatitude);
                var linkObject = new JObject();
                var linkObjectpropCount = 0;
                if (messageRolinkabsolute != null)
                {
                    linkObject["absolute"] = ExpressionConverter.ConvertO(messageRolinkabsolute);
                    linkObjectpropCount++;
                }

                if (messageRolinkauthority != null)
                {
                    linkObject["authority"] = ExpressionConverter.ConvertO(messageRolinkauthority);
                    linkObjectpropCount++;
                }

                if (messageRolinkfragment != null)
                {
                    linkObject["fragment"] = ExpressionConverter.ConvertO(messageRolinkfragment);
                    linkObjectpropCount++;
                }

                if (messageRolinkhost != null)
                {
                    linkObject["host"] = ExpressionConverter.ConvertO(messageRolinkhost);
                    linkObjectpropCount++;
                }

                if (messageRolinkopaque != null)
                {
                    linkObject["opaque"] = ExpressionConverter.ConvertO(messageRolinkopaque);
                    linkObjectpropCount++;
                }

                if (messageRolinkpath != null)
                {
                    linkObject["path"] = ExpressionConverter.ConvertO(messageRolinkpath);
                    linkObjectpropCount++;
                }

                if (messageRolinkport != null)
                {
                    linkObject["port"] = ExpressionConverter.ConvertO(messageRolinkport);
                    linkObjectpropCount++;
                }

                if (messageRolinkquery != null)
                {
                    linkObject["query"] = ExpressionConverter.ConvertO(messageRolinkquery);
                    linkObjectpropCount++;
                }

                if (messageRolinkrawAuthority != null)
                {
                    linkObject["rawAuthority"] = ExpressionConverter.ConvertO(messageRolinkrawAuthority);
                    linkObjectpropCount++;
                }

                if (messageRolinkrawFragment != null)
                {
                    linkObject["rawFragment"] = ExpressionConverter.ConvertO(messageRolinkrawFragment);
                    linkObjectpropCount++;
                }

                if (messageRolinkrawPath != null)
                {
                    linkObject["rawPath"] = ExpressionConverter.ConvertO(messageRolinkrawPath);
                    linkObjectpropCount++;
                }

                if (messageRolinkrawQuery != null)
                {
                    linkObject["rawQuery"] = ExpressionConverter.ConvertO(messageRolinkrawQuery);
                    linkObjectpropCount++;
                }

                if (messageRolinkrawSchemeSpecificPart != null)
                {
                    linkObject["rawSchemeSpecificPart"] = ExpressionConverter.ConvertO(messageRolinkrawSchemeSpecificPart);
                    linkObjectpropCount++;
                }

                if (messageRolinkrawUserInfo != null)
                {
                    linkObject["rawUserInfo"] = ExpressionConverter.ConvertO(messageRolinkrawUserInfo);
                    linkObjectpropCount++;
                }

                if (messageRolinkscheme != null)
                {
                    linkObject["scheme"] = ExpressionConverter.ConvertO(messageRolinkscheme);
                    linkObjectpropCount++;
                }

                if (messageRolinkschemeSpecificPart != null)
                {
                    linkObject["schemeSpecificPart"] = ExpressionConverter.ConvertO(messageRolinkschemeSpecificPart);
                    linkObjectpropCount++;
                }

                if (messageRolinkuserInfo != null)
                {
                    linkObject["userInfo"] = ExpressionConverter.ConvertO(messageRolinkuserInfo);
                    linkObjectpropCount++;
                }

                if (linkObjectpropCount > 0)
                {
                    messageRo["link"] = linkObject;
                    messageRopropCount++;
                }

                messageRopropCount++;
                messageRo["longitude"] = ExpressionConverter.ConvertO(messageRolongitude);
                var measurementsObject = new JObject();
                var measurementsObjectpropCount = 0;
                if (messageRomeasurementsarray != null)
                {
                    measurementsObject["array"] = ExpressionConverter.ConvertO(messageRomeasurementsarray);
                    measurementsObjectpropCount++;
                }

                if (messageRomeasurementsbigDecimal != null)
                {
                    measurementsObject["bigDecimal"] = ExpressionConverter.ConvertO(messageRomeasurementsbigDecimal);
                    measurementsObjectpropCount++;
                }

                if (messageRomeasurementsbigInteger != null)
                {
                    measurementsObject["bigInteger"] = ExpressionConverter.ConvertO(messageRomeasurementsbigInteger);
                    measurementsObjectpropCount++;
                }

                if (messageRomeasurementsbinary != null)
                {
                    measurementsObject["binary"] = ExpressionConverter.ConvertO(messageRomeasurementsbinary);
                    measurementsObjectpropCount++;
                }

                if (messageRomeasurementsboolean != null)
                {
                    measurementsObject["boolean"] = ExpressionConverter.ConvertO(messageRomeasurementsboolean);
                    measurementsObjectpropCount++;
                }

                if (messageRomeasurementscontainerNode != null)
                {
                    measurementsObject["containerNode"] = ExpressionConverter.ConvertO(messageRomeasurementscontainerNode);
                    measurementsObjectpropCount++;
                }

                if (messageRomeasurementsdouble != null)
                {
                    measurementsObject["double"] = ExpressionConverter.ConvertO(messageRomeasurementsdouble);
                    measurementsObjectpropCount++;
                }

                if (messageRomeasurementsfloat != null)
                {
                    measurementsObject["float"] = ExpressionConverter.ConvertO(messageRomeasurementsfloat);
                    measurementsObjectpropCount++;
                }

                if (messageRomeasurementsfloatingPointNumber != null)
                {
                    measurementsObject["floatingPointNumber"] = ExpressionConverter.ConvertO(messageRomeasurementsfloatingPointNumber);
                    measurementsObjectpropCount++;
                }

                if (messageRomeasurementsint != null)
                {
                    measurementsObject["int"] = ExpressionConverter.ConvertO(messageRomeasurementsint);
                    measurementsObjectpropCount++;
                }

                if (messageRomeasurementsintegralNumber != null)
                {
                    measurementsObject["integralNumber"] = ExpressionConverter.ConvertO(messageRomeasurementsintegralNumber);
                    measurementsObjectpropCount++;
                }

                if (messageRomeasurementsLong != null)
                {
                    measurementsObject["long"] = ExpressionConverter.ConvertO(messageRomeasurementsLong);
                    measurementsObjectpropCount++;
                }

                if (messageRomeasurementsmissingNode != null)
                {
                    measurementsObject["missingNode"] = ExpressionConverter.ConvertO(messageRomeasurementsmissingNode);
                    measurementsObjectpropCount++;
                }

                if (messageRomeasurementsnodeType != null)
                {
                    measurementsObject["nodeType"] = ExpressionConverter.ConvertO(messageRomeasurementsnodeType);
                    measurementsObjectpropCount++;
                }

                if (messageRomeasurementsnull != null)
                {
                    measurementsObject["null"] = ExpressionConverter.ConvertO(messageRomeasurementsnull);
                    measurementsObjectpropCount++;
                }

                if (messageRomeasurementsnumber != null)
                {
                    measurementsObject["number"] = ExpressionConverter.ConvertO(messageRomeasurementsnumber);
                    measurementsObjectpropCount++;
                }

                if (messageRomeasurementsObject != null)
                {
                    measurementsObject["object"] = ExpressionConverter.ConvertO(messageRomeasurementsObject);
                    measurementsObjectpropCount++;
                }

                if (messageRomeasurementspojo != null)
                {
                    measurementsObject["pojo"] = ExpressionConverter.ConvertO(messageRomeasurementspojo);
                    measurementsObjectpropCount++;
                }

                if (messageRomeasurementsShort != null)
                {
                    measurementsObject["short"] = ExpressionConverter.ConvertO(messageRomeasurementsShort);
                    measurementsObjectpropCount++;
                }

                if (messageRomeasurementstextual != null)
                {
                    measurementsObject["textual"] = ExpressionConverter.ConvertO(messageRomeasurementstextual);
                    measurementsObjectpropCount++;
                }

                if (messageRomeasurementsvalueNode != null)
                {
                    measurementsObject["valueNode"] = ExpressionConverter.ConvertO(messageRomeasurementsvalueNode);
                    measurementsObjectpropCount++;
                }

                if (measurementsObjectpropCount > 0)
                {
                    messageRo["measurements"] = measurementsObject;
                    messageRopropCount++;
                }

                messageRopropCount++;
                messageRo["metadata"] = ExpressionConverter.ConvertO(messageRometadata);
                messageRopropCount++;
                messageRo["number"] = ExpressionConverter.ConvertO(messageRonumber);
                messageRopropCount++;
                messageRo["processed"] = ExpressionConverter.ConvertO(messageRoprocessed);
                var rawMeasurementsObject = new JObject();
                var rawMeasurementsObjectpropCount = 0;
                if (messageRomeasurementsarray != null)
                {
                    rawMeasurementsObject["array"] = ExpressionConverter.ConvertO(messageRomeasurementsarray);
                    rawMeasurementsObjectpropCount++;
                }

                if (messageRomeasurementsbigDecimal != null)
                {
                    rawMeasurementsObject["bigDecimal"] = ExpressionConverter.ConvertO(messageRomeasurementsbigDecimal);
                    rawMeasurementsObjectpropCount++;
                }

                if (messageRomeasurementsbigInteger != null)
                {
                    rawMeasurementsObject["bigInteger"] = ExpressionConverter.ConvertO(messageRomeasurementsbigInteger);
                    rawMeasurementsObjectpropCount++;
                }

                if (messageRomeasurementsbinary != null)
                {
                    rawMeasurementsObject["binary"] = ExpressionConverter.ConvertO(messageRomeasurementsbinary);
                    rawMeasurementsObjectpropCount++;
                }

                if (messageRomeasurementsboolean != null)
                {
                    rawMeasurementsObject["boolean"] = ExpressionConverter.ConvertO(messageRomeasurementsboolean);
                    rawMeasurementsObjectpropCount++;
                }

                if (messageRomeasurementscontainerNode != null)
                {
                    rawMeasurementsObject["containerNode"] = ExpressionConverter.ConvertO(messageRomeasurementscontainerNode);
                    rawMeasurementsObjectpropCount++;
                }

                if (messageRomeasurementsdouble != null)
                {
                    rawMeasurementsObject["double"] = ExpressionConverter.ConvertO(messageRomeasurementsdouble);
                    rawMeasurementsObjectpropCount++;
                }

                if (messageRomeasurementsfloat != null)
                {
                    rawMeasurementsObject["float"] = ExpressionConverter.ConvertO(messageRomeasurementsfloat);
                    rawMeasurementsObjectpropCount++;
                }

                if (messageRomeasurementsfloatingPointNumber != null)
                {
                    rawMeasurementsObject["floatingPointNumber"] = ExpressionConverter.ConvertO(messageRomeasurementsfloatingPointNumber);
                    rawMeasurementsObjectpropCount++;
                }

                if (messageRomeasurementsint != null)
                {
                    rawMeasurementsObject["int"] = ExpressionConverter.ConvertO(messageRomeasurementsint);
                    rawMeasurementsObjectpropCount++;
                }

                if (messageRomeasurementsintegralNumber != null)
                {
                    rawMeasurementsObject["integralNumber"] = ExpressionConverter.ConvertO(messageRomeasurementsintegralNumber);
                    rawMeasurementsObjectpropCount++;
                }

                if (messageRomeasurementsLong != null)
                {
                    rawMeasurementsObject["long"] = ExpressionConverter.ConvertO(messageRomeasurementsLong);
                    rawMeasurementsObjectpropCount++;
                }

                if (messageRomeasurementsmissingNode != null)
                {
                    rawMeasurementsObject["missingNode"] = ExpressionConverter.ConvertO(messageRomeasurementsmissingNode);
                    rawMeasurementsObjectpropCount++;
                }

                if (messageRomeasurementsnodeType != null)
                {
                    rawMeasurementsObject["nodeType"] = ExpressionConverter.ConvertO(messageRomeasurementsnodeType);
                    rawMeasurementsObjectpropCount++;
                }

                if (messageRomeasurementsnull != null)
                {
                    rawMeasurementsObject["null"] = ExpressionConverter.ConvertO(messageRomeasurementsnull);
                    rawMeasurementsObjectpropCount++;
                }

                if (messageRomeasurementsnumber != null)
                {
                    rawMeasurementsObject["number"] = ExpressionConverter.ConvertO(messageRomeasurementsnumber);
                    rawMeasurementsObjectpropCount++;
                }

                if (messageRomeasurementsObject != null)
                {
                    rawMeasurementsObject["object"] = ExpressionConverter.ConvertO(messageRomeasurementsObject);
                    rawMeasurementsObjectpropCount++;
                }

                if (messageRomeasurementspojo != null)
                {
                    rawMeasurementsObject["pojo"] = ExpressionConverter.ConvertO(messageRomeasurementspojo);
                    rawMeasurementsObjectpropCount++;
                }

                if (messageRomeasurementsShort != null)
                {
                    rawMeasurementsObject["short"] = ExpressionConverter.ConvertO(messageRomeasurementsShort);
                    rawMeasurementsObjectpropCount++;
                }

                if (messageRomeasurementstextual != null)
                {
                    rawMeasurementsObject["textual"] = ExpressionConverter.ConvertO(messageRomeasurementstextual);
                    rawMeasurementsObjectpropCount++;
                }

                if (messageRomeasurementsvalueNode != null)
                {
                    rawMeasurementsObject["valueNode"] = ExpressionConverter.ConvertO(messageRomeasurementsvalueNode);
                    rawMeasurementsObjectpropCount++;
                }

                if (rawMeasurementsObjectpropCount > 0)
                {
                    messageRo["rawMeasurements"] = rawMeasurementsObject;
                    messageRopropCount++;
                }

                var thingObject = new JObject();
                var thingObjectpropCount = 0;
                if (messageRothingdisplayName != null)
                {
                    thingObject["displayName"] = ExpressionConverter.ConvertO(messageRothingdisplayName);
                    thingObjectpropCount++;
                }

                if (messageRothingfixedName != null)
                {
                    thingObject["fixedName"] = ExpressionConverter.ConvertO(messageRothingfixedName);
                    thingObjectpropCount++;
                }

                if (messageRothingid != null)
                {
                    thingObject["id"] = ExpressionConverter.ConvertO(messageRothingid);
                    thingObjectpropCount++;
                }

                thingObjectpropCount++;
                thingObject["name"] = ExpressionConverter.ConvertO(messageRothingname);
                if (messageRothingnbAlerts != null)
                {
                    thingObject["nbAlerts"] = ExpressionConverter.ConvertO(messageRothingnbAlerts);
                    thingObjectpropCount++;
                }

                if (messageRothingtags != null)
                {
                    thingObject["tags"] = ExpressionConverter.ConvertO(messageRothingtags);
                    thingObjectpropCount++;
                }

                if (thingObjectpropCount > 0)
                {
                    messageRo["thing"] = thingObject;
                    messageRopropCount++;
                }

                messageRopropCount++;
                messageRo["timestamp"] = ExpressionConverter.ConvertO(messageRotimestamp);
                messageRopropCount++;
                messageRo["topic"] = ExpressionConverter.ConvertO(messageRotopic);
                if (messageRopropCount > 0)
                {
                    callPayload.Body = messageRo;
                }

                return new ApiConnectionAction<MessageRo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        [WorkflowExpressionFactory(nameof(__BuildGetThingModel))]
        public IBodyWorkflowAction<ModelRo> GetThingModel([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ModelRo> __BuildGetThingModel(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<ModelRo>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/things/{0}/model", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ModelRo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        [WorkflowExpressionFactory(nameof(__BuildGetThingOperations))]
        public IBodyWorkflowAction<PageOperationRo> GetThingOperations([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PageOperationRo> __BuildGetThingOperations(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<PageOperationRo>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/things/{0}/operations", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<PageOperationRo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        [WorkflowExpressionFactory(nameof(__BuildExecuteThingOperation))]
        public IBodyWorkflowAction<ResponseEntity> ExecuteThingOperation([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> operationId, [WorkflowExpression] Func<bool> placeholdersValuesarray = null, [WorkflowExpression] Func<bool> placeholdersValuesbigDecimal = null, [WorkflowExpression] Func<bool> placeholdersValuesbigInteger = null, [WorkflowExpression] Func<bool> placeholdersValuesbinary = null, [WorkflowExpression] Func<bool> placeholdersValuesboolean = null, [WorkflowExpression] Func<bool> placeholdersValuescontainerNode = null, [WorkflowExpression] Func<bool> placeholdersValuesdouble = null, [WorkflowExpression] Func<bool> placeholdersValuesfloat = null, [WorkflowExpression] Func<bool> placeholdersValuesfloatingPointNumber = null, [WorkflowExpression] Func<bool> placeholdersValuesint = null, [WorkflowExpression] Func<bool> placeholdersValuesintegralNumber = null, [WorkflowExpression] Func<bool> placeholdersValuesLong = null, [WorkflowExpression] Func<bool> placeholdersValuesmissingNode = null, [WorkflowExpression] Func<placeholdersValuesnodeTypeInput> placeholdersValuesnodeType = null, [WorkflowExpression] Func<bool> placeholdersValuesnull = null, [WorkflowExpression] Func<bool> placeholdersValuesnumber = null, [WorkflowExpression] Func<bool> placeholdersValuesObject = null, [WorkflowExpression] Func<bool> placeholdersValuespojo = null, [WorkflowExpression] Func<bool> placeholdersValuesShort = null, [WorkflowExpression] Func<bool> placeholdersValuestextual = null, [WorkflowExpression] Func<bool> placeholdersValuesvalueNode = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResponseEntity> __BuildExecuteThingOperation(WorkflowExpression<string> id, WorkflowExpression<string> operationId, WorkflowExpression<bool> placeholdersValuesarray = null, WorkflowExpression<bool> placeholdersValuesbigDecimal = null, WorkflowExpression<bool> placeholdersValuesbigInteger = null, WorkflowExpression<bool> placeholdersValuesbinary = null, WorkflowExpression<bool> placeholdersValuesboolean = null, WorkflowExpression<bool> placeholdersValuescontainerNode = null, WorkflowExpression<bool> placeholdersValuesdouble = null, WorkflowExpression<bool> placeholdersValuesfloat = null, WorkflowExpression<bool> placeholdersValuesfloatingPointNumber = null, WorkflowExpression<bool> placeholdersValuesint = null, WorkflowExpression<bool> placeholdersValuesintegralNumber = null, WorkflowExpression<bool> placeholdersValuesLong = null, WorkflowExpression<bool> placeholdersValuesmissingNode = null, WorkflowExpression<placeholdersValuesnodeTypeInput> placeholdersValuesnodeType = null, WorkflowExpression<bool> placeholdersValuesnull = null, WorkflowExpression<bool> placeholdersValuesnumber = null, WorkflowExpression<bool> placeholdersValuesObject = null, WorkflowExpression<bool> placeholdersValuespojo = null, WorkflowExpression<bool> placeholdersValuesShort = null, WorkflowExpression<bool> placeholdersValuestextual = null, WorkflowExpression<bool> placeholdersValuesvalueNode = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(operationId, nameof(operationId), required: true);
            WorkflowExpression.Validate(placeholdersValuesarray, nameof(placeholdersValuesarray), required: false);
            WorkflowExpression.Validate(placeholdersValuesbigDecimal, nameof(placeholdersValuesbigDecimal), required: false);
            WorkflowExpression.Validate(placeholdersValuesbigInteger, nameof(placeholdersValuesbigInteger), required: false);
            WorkflowExpression.Validate(placeholdersValuesbinary, nameof(placeholdersValuesbinary), required: false);
            WorkflowExpression.Validate(placeholdersValuesboolean, nameof(placeholdersValuesboolean), required: false);
            WorkflowExpression.Validate(placeholdersValuescontainerNode, nameof(placeholdersValuescontainerNode), required: false);
            WorkflowExpression.Validate(placeholdersValuesdouble, nameof(placeholdersValuesdouble), required: false);
            WorkflowExpression.Validate(placeholdersValuesfloat, nameof(placeholdersValuesfloat), required: false);
            WorkflowExpression.Validate(placeholdersValuesfloatingPointNumber, nameof(placeholdersValuesfloatingPointNumber), required: false);
            WorkflowExpression.Validate(placeholdersValuesint, nameof(placeholdersValuesint), required: false);
            WorkflowExpression.Validate(placeholdersValuesintegralNumber, nameof(placeholdersValuesintegralNumber), required: false);
            WorkflowExpression.Validate(placeholdersValuesLong, nameof(placeholdersValuesLong), required: false);
            WorkflowExpression.Validate(placeholdersValuesmissingNode, nameof(placeholdersValuesmissingNode), required: false);
            WorkflowExpression.Validate(placeholdersValuesnodeType, nameof(placeholdersValuesnodeType), required: false);
            WorkflowExpression.Validate(placeholdersValuesnull, nameof(placeholdersValuesnull), required: false);
            WorkflowExpression.Validate(placeholdersValuesnumber, nameof(placeholdersValuesnumber), required: false);
            WorkflowExpression.Validate(placeholdersValuesObject, nameof(placeholdersValuesObject), required: false);
            WorkflowExpression.Validate(placeholdersValuespojo, nameof(placeholdersValuespojo), required: false);
            WorkflowExpression.Validate(placeholdersValuesShort, nameof(placeholdersValuesShort), required: false);
            WorkflowExpression.Validate(placeholdersValuestextual, nameof(placeholdersValuestextual), required: false);
            WorkflowExpression.Validate(placeholdersValuesvalueNode, nameof(placeholdersValuesvalueNode), required: false);
            return new DeferredBodyAction<ResponseEntity>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/things/{0}/operations/{1}", ExpressionConverter.ConvertWithUrlEncoding(id, 1), ExpressionConverter.ConvertWithUrlEncoding(operationId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var placeholdersValues = new JObject();
                var placeholdersValuespropCount = 0;
                if (placeholdersValuesarray != null)
                {
                    placeholdersValues["array"] = ExpressionConverter.ConvertO(placeholdersValuesarray);
                    placeholdersValuespropCount++;
                }

                if (placeholdersValuesbigDecimal != null)
                {
                    placeholdersValues["bigDecimal"] = ExpressionConverter.ConvertO(placeholdersValuesbigDecimal);
                    placeholdersValuespropCount++;
                }

                if (placeholdersValuesbigInteger != null)
                {
                    placeholdersValues["bigInteger"] = ExpressionConverter.ConvertO(placeholdersValuesbigInteger);
                    placeholdersValuespropCount++;
                }

                if (placeholdersValuesbinary != null)
                {
                    placeholdersValues["binary"] = ExpressionConverter.ConvertO(placeholdersValuesbinary);
                    placeholdersValuespropCount++;
                }

                if (placeholdersValuesboolean != null)
                {
                    placeholdersValues["boolean"] = ExpressionConverter.ConvertO(placeholdersValuesboolean);
                    placeholdersValuespropCount++;
                }

                if (placeholdersValuescontainerNode != null)
                {
                    placeholdersValues["containerNode"] = ExpressionConverter.ConvertO(placeholdersValuescontainerNode);
                    placeholdersValuespropCount++;
                }

                if (placeholdersValuesdouble != null)
                {
                    placeholdersValues["double"] = ExpressionConverter.ConvertO(placeholdersValuesdouble);
                    placeholdersValuespropCount++;
                }

                if (placeholdersValuesfloat != null)
                {
                    placeholdersValues["float"] = ExpressionConverter.ConvertO(placeholdersValuesfloat);
                    placeholdersValuespropCount++;
                }

                if (placeholdersValuesfloatingPointNumber != null)
                {
                    placeholdersValues["floatingPointNumber"] = ExpressionConverter.ConvertO(placeholdersValuesfloatingPointNumber);
                    placeholdersValuespropCount++;
                }

                if (placeholdersValuesint != null)
                {
                    placeholdersValues["int"] = ExpressionConverter.ConvertO(placeholdersValuesint);
                    placeholdersValuespropCount++;
                }

                if (placeholdersValuesintegralNumber != null)
                {
                    placeholdersValues["integralNumber"] = ExpressionConverter.ConvertO(placeholdersValuesintegralNumber);
                    placeholdersValuespropCount++;
                }

                if (placeholdersValuesLong != null)
                {
                    placeholdersValues["long"] = ExpressionConverter.ConvertO(placeholdersValuesLong);
                    placeholdersValuespropCount++;
                }

                if (placeholdersValuesmissingNode != null)
                {
                    placeholdersValues["missingNode"] = ExpressionConverter.ConvertO(placeholdersValuesmissingNode);
                    placeholdersValuespropCount++;
                }

                if (placeholdersValuesnodeType != null)
                {
                    placeholdersValues["nodeType"] = ExpressionConverter.ConvertO(placeholdersValuesnodeType);
                    placeholdersValuespropCount++;
                }

                if (placeholdersValuesnull != null)
                {
                    placeholdersValues["null"] = ExpressionConverter.ConvertO(placeholdersValuesnull);
                    placeholdersValuespropCount++;
                }

                if (placeholdersValuesnumber != null)
                {
                    placeholdersValues["number"] = ExpressionConverter.ConvertO(placeholdersValuesnumber);
                    placeholdersValuespropCount++;
                }

                if (placeholdersValuesObject != null)
                {
                    placeholdersValues["object"] = ExpressionConverter.ConvertO(placeholdersValuesObject);
                    placeholdersValuespropCount++;
                }

                if (placeholdersValuespojo != null)
                {
                    placeholdersValues["pojo"] = ExpressionConverter.ConvertO(placeholdersValuespojo);
                    placeholdersValuespropCount++;
                }

                if (placeholdersValuesShort != null)
                {
                    placeholdersValues["short"] = ExpressionConverter.ConvertO(placeholdersValuesShort);
                    placeholdersValuespropCount++;
                }

                if (placeholdersValuestextual != null)
                {
                    placeholdersValues["textual"] = ExpressionConverter.ConvertO(placeholdersValuestextual);
                    placeholdersValuespropCount++;
                }

                if (placeholdersValuesvalueNode != null)
                {
                    placeholdersValues["valueNode"] = ExpressionConverter.ConvertO(placeholdersValuesvalueNode);
                    placeholdersValuespropCount++;
                }

                if (placeholdersValuespropCount > 0)
                {
                    callPayload.Body = placeholdersValues;
                }

                return new ApiConnectionAction<ResponseEntity>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateThingFixedPosition))]
        public IBodyWorkflowAction<SingleThingRo> UpdateThingFixedPosition([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> thingRoname, [WorkflowExpression] Func<string> thingRositeaddress, [WorkflowExpression] Func<string> thingRositecity, [WorkflowExpression] Func<string> thingRositename, [WorkflowExpression] Func<string> thingRositepostalCode, [WorkflowExpression] Func<CustomFieldRo[]> thingRocustomFields = null, [WorkflowExpression] Func<string> thingRodescription = null, [WorkflowExpression] Func<string> thingRodisplayName = null, [WorkflowExpression] Func<bool> thingRodynamicGps = null, [WorkflowExpression] Func<double> thingRofixedLatitude = null, [WorkflowExpression] Func<double> thingRofixedLongitude = null, [WorkflowExpression] Func<string> thingRofixedName = null, [WorkflowExpression] Func<string> thingRoid = null, [WorkflowExpression] Func<int> thingRolastActivityDate = null, [WorkflowExpression] Func<double> thingRolastLatitude = null, [WorkflowExpression] Func<double> thingRolastLongitude = null, [WorkflowExpression] Func<bool> thingRolastMeasurementsarray = null, [WorkflowExpression] Func<bool> thingRolastMeasurementsbigDecimal = null, [WorkflowExpression] Func<bool> thingRolastMeasurementsbigInteger = null, [WorkflowExpression] Func<bool> thingRolastMeasurementsbinary = null, [WorkflowExpression] Func<bool> thingRolastMeasurementsboolean = null, [WorkflowExpression] Func<bool> thingRolastMeasurementscontainerNode = null, [WorkflowExpression] Func<bool> thingRolastMeasurementsdouble = null, [WorkflowExpression] Func<bool> thingRolastMeasurementsfloat = null, [WorkflowExpression] Func<bool> thingRolastMeasurementsfloatingPointNumber = null, [WorkflowExpression] Func<bool> thingRolastMeasurementsint = null, [WorkflowExpression] Func<bool> thingRolastMeasurementsintegralNumber = null, [WorkflowExpression] Func<bool> thingRolastMeasurementsLong = null, [WorkflowExpression] Func<bool> thingRolastMeasurementsmissingNode = null, [WorkflowExpression] Func<thingRolastMeasurementsnodeTypeInput> thingRolastMeasurementsnodeType = null, [WorkflowExpression] Func<bool> thingRolastMeasurementsnull = null, [WorkflowExpression] Func<bool> thingRolastMeasurementsnumber = null, [WorkflowExpression] Func<bool> thingRolastMeasurementsObject = null, [WorkflowExpression] Func<bool> thingRolastMeasurementspojo = null, [WorkflowExpression] Func<bool> thingRolastMeasurementsShort = null, [WorkflowExpression] Func<bool> thingRolastMeasurementstextual = null, [WorkflowExpression] Func<bool> thingRolastMeasurementsvalueNode = null, [WorkflowExpression] Func<bool> thingRolastMeasurementsTimestampsarray = null, [WorkflowExpression] Func<bool> thingRolastMeasurementsTimestampsbigDecimal = null, [WorkflowExpression] Func<bool> thingRolastMeasurementsTimestampsbigInteger = null, [WorkflowExpression] Func<bool> thingRolastMeasurementsTimestampsbinary = null, [WorkflowExpression] Func<bool> thingRolastMeasurementsTimestampsboolean = null, [WorkflowExpression] Func<bool> thingRolastMeasurementsTimestampscontainerNode = null, [WorkflowExpression] Func<bool> thingRolastMeasurementsTimestampsdouble = null, [WorkflowExpression] Func<bool> thingRolastMeasurementsTimestampsfloat = null, [WorkflowExpression] Func<bool> thingRolastMeasurementsTimestampsfloatingPointNumber = null, [WorkflowExpression] Func<bool> thingRolastMeasurementsTimestampsint = null, [WorkflowExpression] Func<bool> thingRolastMeasurementsTimestampsintegralNumber = null, [WorkflowExpression] Func<bool> thingRolastMeasurementsTimestampsLong = null, [WorkflowExpression] Func<bool> thingRolastMeasurementsTimestampsmissingNode = null, [WorkflowExpression] Func<thingRolastMeasurementsTimestampsnodeTypeInput> thingRolastMeasurementsTimestampsnodeType = null, [WorkflowExpression] Func<bool> thingRolastMeasurementsTimestampsnull = null, [WorkflowExpression] Func<bool> thingRolastMeasurementsTimestampsnumber = null, [WorkflowExpression] Func<bool> thingRolastMeasurementsTimestampsObject = null, [WorkflowExpression] Func<bool> thingRolastMeasurementsTimestampspojo = null, [WorkflowExpression] Func<bool> thingRolastMeasurementsTimestampsShort = null, [WorkflowExpression] Func<bool> thingRolastMeasurementsTimestampstextual = null, [WorkflowExpression] Func<bool> thingRolastMeasurementsTimestampsvalueNode = null, [WorkflowExpression] Func<int> thingRolastMessageDate = null, [WorkflowExpression] Func<int> thingRomessageActivityTimeoutPeriod = null, [WorkflowExpression] Func<int> thingRonbAlerts = null, [WorkflowExpression] Func<string> thingRositeid = null, [WorkflowExpression] Func<double> thingRositelatitude = null, [WorkflowExpression] Func<double> thingRositelongitude = null, [WorkflowExpression] Func<thingRostatusInput> thingRostatus = null, [WorkflowExpression] Func<ThingTagRo[]> thingRotags = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SingleThingRo> __BuildUpdateThingFixedPosition(WorkflowExpression<string> id, WorkflowExpression<string> thingRoname, WorkflowExpression<string> thingRositeaddress, WorkflowExpression<string> thingRositecity, WorkflowExpression<string> thingRositename, WorkflowExpression<string> thingRositepostalCode, WorkflowExpression<CustomFieldRo[]> thingRocustomFields = null, WorkflowExpression<string> thingRodescription = null, WorkflowExpression<string> thingRodisplayName = null, WorkflowExpression<bool> thingRodynamicGps = null, WorkflowExpression<double> thingRofixedLatitude = null, WorkflowExpression<double> thingRofixedLongitude = null, WorkflowExpression<string> thingRofixedName = null, WorkflowExpression<string> thingRoid = null, WorkflowExpression<int> thingRolastActivityDate = null, WorkflowExpression<double> thingRolastLatitude = null, WorkflowExpression<double> thingRolastLongitude = null, WorkflowExpression<bool> thingRolastMeasurementsarray = null, WorkflowExpression<bool> thingRolastMeasurementsbigDecimal = null, WorkflowExpression<bool> thingRolastMeasurementsbigInteger = null, WorkflowExpression<bool> thingRolastMeasurementsbinary = null, WorkflowExpression<bool> thingRolastMeasurementsboolean = null, WorkflowExpression<bool> thingRolastMeasurementscontainerNode = null, WorkflowExpression<bool> thingRolastMeasurementsdouble = null, WorkflowExpression<bool> thingRolastMeasurementsfloat = null, WorkflowExpression<bool> thingRolastMeasurementsfloatingPointNumber = null, WorkflowExpression<bool> thingRolastMeasurementsint = null, WorkflowExpression<bool> thingRolastMeasurementsintegralNumber = null, WorkflowExpression<bool> thingRolastMeasurementsLong = null, WorkflowExpression<bool> thingRolastMeasurementsmissingNode = null, WorkflowExpression<thingRolastMeasurementsnodeTypeInput> thingRolastMeasurementsnodeType = null, WorkflowExpression<bool> thingRolastMeasurementsnull = null, WorkflowExpression<bool> thingRolastMeasurementsnumber = null, WorkflowExpression<bool> thingRolastMeasurementsObject = null, WorkflowExpression<bool> thingRolastMeasurementspojo = null, WorkflowExpression<bool> thingRolastMeasurementsShort = null, WorkflowExpression<bool> thingRolastMeasurementstextual = null, WorkflowExpression<bool> thingRolastMeasurementsvalueNode = null, WorkflowExpression<bool> thingRolastMeasurementsTimestampsarray = null, WorkflowExpression<bool> thingRolastMeasurementsTimestampsbigDecimal = null, WorkflowExpression<bool> thingRolastMeasurementsTimestampsbigInteger = null, WorkflowExpression<bool> thingRolastMeasurementsTimestampsbinary = null, WorkflowExpression<bool> thingRolastMeasurementsTimestampsboolean = null, WorkflowExpression<bool> thingRolastMeasurementsTimestampscontainerNode = null, WorkflowExpression<bool> thingRolastMeasurementsTimestampsdouble = null, WorkflowExpression<bool> thingRolastMeasurementsTimestampsfloat = null, WorkflowExpression<bool> thingRolastMeasurementsTimestampsfloatingPointNumber = null, WorkflowExpression<bool> thingRolastMeasurementsTimestampsint = null, WorkflowExpression<bool> thingRolastMeasurementsTimestampsintegralNumber = null, WorkflowExpression<bool> thingRolastMeasurementsTimestampsLong = null, WorkflowExpression<bool> thingRolastMeasurementsTimestampsmissingNode = null, WorkflowExpression<thingRolastMeasurementsTimestampsnodeTypeInput> thingRolastMeasurementsTimestampsnodeType = null, WorkflowExpression<bool> thingRolastMeasurementsTimestampsnull = null, WorkflowExpression<bool> thingRolastMeasurementsTimestampsnumber = null, WorkflowExpression<bool> thingRolastMeasurementsTimestampsObject = null, WorkflowExpression<bool> thingRolastMeasurementsTimestampspojo = null, WorkflowExpression<bool> thingRolastMeasurementsTimestampsShort = null, WorkflowExpression<bool> thingRolastMeasurementsTimestampstextual = null, WorkflowExpression<bool> thingRolastMeasurementsTimestampsvalueNode = null, WorkflowExpression<int> thingRolastMessageDate = null, WorkflowExpression<int> thingRomessageActivityTimeoutPeriod = null, WorkflowExpression<int> thingRonbAlerts = null, WorkflowExpression<string> thingRositeid = null, WorkflowExpression<double> thingRositelatitude = null, WorkflowExpression<double> thingRositelongitude = null, WorkflowExpression<thingRostatusInput> thingRostatus = null, WorkflowExpression<ThingTagRo[]> thingRotags = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(thingRoname, nameof(thingRoname), required: true);
            WorkflowExpression.Validate(thingRositeaddress, nameof(thingRositeaddress), required: true);
            WorkflowExpression.Validate(thingRositecity, nameof(thingRositecity), required: true);
            WorkflowExpression.Validate(thingRositename, nameof(thingRositename), required: true);
            WorkflowExpression.Validate(thingRositepostalCode, nameof(thingRositepostalCode), required: true);
            WorkflowExpression.Validate(thingRocustomFields, nameof(thingRocustomFields), required: false);
            WorkflowExpression.Validate(thingRodescription, nameof(thingRodescription), required: false);
            WorkflowExpression.Validate(thingRodisplayName, nameof(thingRodisplayName), required: false);
            WorkflowExpression.Validate(thingRodynamicGps, nameof(thingRodynamicGps), required: false);
            WorkflowExpression.Validate(thingRofixedLatitude, nameof(thingRofixedLatitude), required: false);
            WorkflowExpression.Validate(thingRofixedLongitude, nameof(thingRofixedLongitude), required: false);
            WorkflowExpression.Validate(thingRofixedName, nameof(thingRofixedName), required: false);
            WorkflowExpression.Validate(thingRoid, nameof(thingRoid), required: false);
            WorkflowExpression.Validate(thingRolastActivityDate, nameof(thingRolastActivityDate), required: false);
            WorkflowExpression.Validate(thingRolastLatitude, nameof(thingRolastLatitude), required: false);
            WorkflowExpression.Validate(thingRolastLongitude, nameof(thingRolastLongitude), required: false);
            WorkflowExpression.Validate(thingRolastMeasurementsarray, nameof(thingRolastMeasurementsarray), required: false);
            WorkflowExpression.Validate(thingRolastMeasurementsbigDecimal, nameof(thingRolastMeasurementsbigDecimal), required: false);
            WorkflowExpression.Validate(thingRolastMeasurementsbigInteger, nameof(thingRolastMeasurementsbigInteger), required: false);
            WorkflowExpression.Validate(thingRolastMeasurementsbinary, nameof(thingRolastMeasurementsbinary), required: false);
            WorkflowExpression.Validate(thingRolastMeasurementsboolean, nameof(thingRolastMeasurementsboolean), required: false);
            WorkflowExpression.Validate(thingRolastMeasurementscontainerNode, nameof(thingRolastMeasurementscontainerNode), required: false);
            WorkflowExpression.Validate(thingRolastMeasurementsdouble, nameof(thingRolastMeasurementsdouble), required: false);
            WorkflowExpression.Validate(thingRolastMeasurementsfloat, nameof(thingRolastMeasurementsfloat), required: false);
            WorkflowExpression.Validate(thingRolastMeasurementsfloatingPointNumber, nameof(thingRolastMeasurementsfloatingPointNumber), required: false);
            WorkflowExpression.Validate(thingRolastMeasurementsint, nameof(thingRolastMeasurementsint), required: false);
            WorkflowExpression.Validate(thingRolastMeasurementsintegralNumber, nameof(thingRolastMeasurementsintegralNumber), required: false);
            WorkflowExpression.Validate(thingRolastMeasurementsLong, nameof(thingRolastMeasurementsLong), required: false);
            WorkflowExpression.Validate(thingRolastMeasurementsmissingNode, nameof(thingRolastMeasurementsmissingNode), required: false);
            WorkflowExpression.Validate(thingRolastMeasurementsnodeType, nameof(thingRolastMeasurementsnodeType), required: false);
            WorkflowExpression.Validate(thingRolastMeasurementsnull, nameof(thingRolastMeasurementsnull), required: false);
            WorkflowExpression.Validate(thingRolastMeasurementsnumber, nameof(thingRolastMeasurementsnumber), required: false);
            WorkflowExpression.Validate(thingRolastMeasurementsObject, nameof(thingRolastMeasurementsObject), required: false);
            WorkflowExpression.Validate(thingRolastMeasurementspojo, nameof(thingRolastMeasurementspojo), required: false);
            WorkflowExpression.Validate(thingRolastMeasurementsShort, nameof(thingRolastMeasurementsShort), required: false);
            WorkflowExpression.Validate(thingRolastMeasurementstextual, nameof(thingRolastMeasurementstextual), required: false);
            WorkflowExpression.Validate(thingRolastMeasurementsvalueNode, nameof(thingRolastMeasurementsvalueNode), required: false);
            WorkflowExpression.Validate(thingRolastMeasurementsTimestampsarray, nameof(thingRolastMeasurementsTimestampsarray), required: false);
            WorkflowExpression.Validate(thingRolastMeasurementsTimestampsbigDecimal, nameof(thingRolastMeasurementsTimestampsbigDecimal), required: false);
            WorkflowExpression.Validate(thingRolastMeasurementsTimestampsbigInteger, nameof(thingRolastMeasurementsTimestampsbigInteger), required: false);
            WorkflowExpression.Validate(thingRolastMeasurementsTimestampsbinary, nameof(thingRolastMeasurementsTimestampsbinary), required: false);
            WorkflowExpression.Validate(thingRolastMeasurementsTimestampsboolean, nameof(thingRolastMeasurementsTimestampsboolean), required: false);
            WorkflowExpression.Validate(thingRolastMeasurementsTimestampscontainerNode, nameof(thingRolastMeasurementsTimestampscontainerNode), required: false);
            WorkflowExpression.Validate(thingRolastMeasurementsTimestampsdouble, nameof(thingRolastMeasurementsTimestampsdouble), required: false);
            WorkflowExpression.Validate(thingRolastMeasurementsTimestampsfloat, nameof(thingRolastMeasurementsTimestampsfloat), required: false);
            WorkflowExpression.Validate(thingRolastMeasurementsTimestampsfloatingPointNumber, nameof(thingRolastMeasurementsTimestampsfloatingPointNumber), required: false);
            WorkflowExpression.Validate(thingRolastMeasurementsTimestampsint, nameof(thingRolastMeasurementsTimestampsint), required: false);
            WorkflowExpression.Validate(thingRolastMeasurementsTimestampsintegralNumber, nameof(thingRolastMeasurementsTimestampsintegralNumber), required: false);
            WorkflowExpression.Validate(thingRolastMeasurementsTimestampsLong, nameof(thingRolastMeasurementsTimestampsLong), required: false);
            WorkflowExpression.Validate(thingRolastMeasurementsTimestampsmissingNode, nameof(thingRolastMeasurementsTimestampsmissingNode), required: false);
            WorkflowExpression.Validate(thingRolastMeasurementsTimestampsnodeType, nameof(thingRolastMeasurementsTimestampsnodeType), required: false);
            WorkflowExpression.Validate(thingRolastMeasurementsTimestampsnull, nameof(thingRolastMeasurementsTimestampsnull), required: false);
            WorkflowExpression.Validate(thingRolastMeasurementsTimestampsnumber, nameof(thingRolastMeasurementsTimestampsnumber), required: false);
            WorkflowExpression.Validate(thingRolastMeasurementsTimestampsObject, nameof(thingRolastMeasurementsTimestampsObject), required: false);
            WorkflowExpression.Validate(thingRolastMeasurementsTimestampspojo, nameof(thingRolastMeasurementsTimestampspojo), required: false);
            WorkflowExpression.Validate(thingRolastMeasurementsTimestampsShort, nameof(thingRolastMeasurementsTimestampsShort), required: false);
            WorkflowExpression.Validate(thingRolastMeasurementsTimestampstextual, nameof(thingRolastMeasurementsTimestampstextual), required: false);
            WorkflowExpression.Validate(thingRolastMeasurementsTimestampsvalueNode, nameof(thingRolastMeasurementsTimestampsvalueNode), required: false);
            WorkflowExpression.Validate(thingRolastMessageDate, nameof(thingRolastMessageDate), required: false);
            WorkflowExpression.Validate(thingRomessageActivityTimeoutPeriod, nameof(thingRomessageActivityTimeoutPeriod), required: false);
            WorkflowExpression.Validate(thingRonbAlerts, nameof(thingRonbAlerts), required: false);
            WorkflowExpression.Validate(thingRositeid, nameof(thingRositeid), required: false);
            WorkflowExpression.Validate(thingRositelatitude, nameof(thingRositelatitude), required: false);
            WorkflowExpression.Validate(thingRositelongitude, nameof(thingRositelongitude), required: false);
            WorkflowExpression.Validate(thingRostatus, nameof(thingRostatus), required: false);
            WorkflowExpression.Validate(thingRotags, nameof(thingRotags), required: false);
            return new DeferredBodyAction<SingleThingRo>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/things/{0}/positions", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var thingRo = new JObject();
                var thingRopropCount = 0;
                if (thingRocustomFields != null)
                {
                    thingRo["customFields"] = ExpressionConverter.ConvertO(thingRocustomFields);
                    thingRopropCount++;
                }

                if (thingRodescription != null)
                {
                    thingRo["description"] = ExpressionConverter.ConvertO(thingRodescription);
                    thingRopropCount++;
                }

                if (thingRodisplayName != null)
                {
                    thingRo["displayName"] = ExpressionConverter.ConvertO(thingRodisplayName);
                    thingRopropCount++;
                }

                if (thingRodynamicGps != null)
                {
                    thingRo["dynamicGps"] = ExpressionConverter.ConvertO(thingRodynamicGps);
                    thingRopropCount++;
                }

                if (thingRofixedLatitude != null)
                {
                    thingRo["fixedLatitude"] = ExpressionConverter.ConvertO(thingRofixedLatitude);
                    thingRopropCount++;
                }

                if (thingRofixedLongitude != null)
                {
                    thingRo["fixedLongitude"] = ExpressionConverter.ConvertO(thingRofixedLongitude);
                    thingRopropCount++;
                }

                if (thingRofixedName != null)
                {
                    thingRo["fixedName"] = ExpressionConverter.ConvertO(thingRofixedName);
                    thingRopropCount++;
                }

                if (thingRoid != null)
                {
                    thingRo["id"] = ExpressionConverter.ConvertO(thingRoid);
                    thingRopropCount++;
                }

                if (thingRolastActivityDate != null)
                {
                    thingRo["lastActivityDate"] = ExpressionConverter.ConvertO(thingRolastActivityDate);
                    thingRopropCount++;
                }

                if (thingRolastLatitude != null)
                {
                    thingRo["lastLatitude"] = ExpressionConverter.ConvertO(thingRolastLatitude);
                    thingRopropCount++;
                }

                if (thingRolastLongitude != null)
                {
                    thingRo["lastLongitude"] = ExpressionConverter.ConvertO(thingRolastLongitude);
                    thingRopropCount++;
                }

                var lastMeasurementsObject = new JObject();
                var lastMeasurementsObjectpropCount = 0;
                if (thingRolastMeasurementsarray != null)
                {
                    lastMeasurementsObject["array"] = ExpressionConverter.ConvertO(thingRolastMeasurementsarray);
                    lastMeasurementsObjectpropCount++;
                }

                if (thingRolastMeasurementsbigDecimal != null)
                {
                    lastMeasurementsObject["bigDecimal"] = ExpressionConverter.ConvertO(thingRolastMeasurementsbigDecimal);
                    lastMeasurementsObjectpropCount++;
                }

                if (thingRolastMeasurementsbigInteger != null)
                {
                    lastMeasurementsObject["bigInteger"] = ExpressionConverter.ConvertO(thingRolastMeasurementsbigInteger);
                    lastMeasurementsObjectpropCount++;
                }

                if (thingRolastMeasurementsbinary != null)
                {
                    lastMeasurementsObject["binary"] = ExpressionConverter.ConvertO(thingRolastMeasurementsbinary);
                    lastMeasurementsObjectpropCount++;
                }

                if (thingRolastMeasurementsboolean != null)
                {
                    lastMeasurementsObject["boolean"] = ExpressionConverter.ConvertO(thingRolastMeasurementsboolean);
                    lastMeasurementsObjectpropCount++;
                }

                if (thingRolastMeasurementscontainerNode != null)
                {
                    lastMeasurementsObject["containerNode"] = ExpressionConverter.ConvertO(thingRolastMeasurementscontainerNode);
                    lastMeasurementsObjectpropCount++;
                }

                if (thingRolastMeasurementsdouble != null)
                {
                    lastMeasurementsObject["double"] = ExpressionConverter.ConvertO(thingRolastMeasurementsdouble);
                    lastMeasurementsObjectpropCount++;
                }

                if (thingRolastMeasurementsfloat != null)
                {
                    lastMeasurementsObject["float"] = ExpressionConverter.ConvertO(thingRolastMeasurementsfloat);
                    lastMeasurementsObjectpropCount++;
                }

                if (thingRolastMeasurementsfloatingPointNumber != null)
                {
                    lastMeasurementsObject["floatingPointNumber"] = ExpressionConverter.ConvertO(thingRolastMeasurementsfloatingPointNumber);
                    lastMeasurementsObjectpropCount++;
                }

                if (thingRolastMeasurementsint != null)
                {
                    lastMeasurementsObject["int"] = ExpressionConverter.ConvertO(thingRolastMeasurementsint);
                    lastMeasurementsObjectpropCount++;
                }

                if (thingRolastMeasurementsintegralNumber != null)
                {
                    lastMeasurementsObject["integralNumber"] = ExpressionConverter.ConvertO(thingRolastMeasurementsintegralNumber);
                    lastMeasurementsObjectpropCount++;
                }

                if (thingRolastMeasurementsLong != null)
                {
                    lastMeasurementsObject["long"] = ExpressionConverter.ConvertO(thingRolastMeasurementsLong);
                    lastMeasurementsObjectpropCount++;
                }

                if (thingRolastMeasurementsmissingNode != null)
                {
                    lastMeasurementsObject["missingNode"] = ExpressionConverter.ConvertO(thingRolastMeasurementsmissingNode);
                    lastMeasurementsObjectpropCount++;
                }

                if (thingRolastMeasurementsnodeType != null)
                {
                    lastMeasurementsObject["nodeType"] = ExpressionConverter.ConvertO(thingRolastMeasurementsnodeType);
                    lastMeasurementsObjectpropCount++;
                }

                if (thingRolastMeasurementsnull != null)
                {
                    lastMeasurementsObject["null"] = ExpressionConverter.ConvertO(thingRolastMeasurementsnull);
                    lastMeasurementsObjectpropCount++;
                }

                if (thingRolastMeasurementsnumber != null)
                {
                    lastMeasurementsObject["number"] = ExpressionConverter.ConvertO(thingRolastMeasurementsnumber);
                    lastMeasurementsObjectpropCount++;
                }

                if (thingRolastMeasurementsObject != null)
                {
                    lastMeasurementsObject["object"] = ExpressionConverter.ConvertO(thingRolastMeasurementsObject);
                    lastMeasurementsObjectpropCount++;
                }

                if (thingRolastMeasurementspojo != null)
                {
                    lastMeasurementsObject["pojo"] = ExpressionConverter.ConvertO(thingRolastMeasurementspojo);
                    lastMeasurementsObjectpropCount++;
                }

                if (thingRolastMeasurementsShort != null)
                {
                    lastMeasurementsObject["short"] = ExpressionConverter.ConvertO(thingRolastMeasurementsShort);
                    lastMeasurementsObjectpropCount++;
                }

                if (thingRolastMeasurementstextual != null)
                {
                    lastMeasurementsObject["textual"] = ExpressionConverter.ConvertO(thingRolastMeasurementstextual);
                    lastMeasurementsObjectpropCount++;
                }

                if (thingRolastMeasurementsvalueNode != null)
                {
                    lastMeasurementsObject["valueNode"] = ExpressionConverter.ConvertO(thingRolastMeasurementsvalueNode);
                    lastMeasurementsObjectpropCount++;
                }

                if (lastMeasurementsObjectpropCount > 0)
                {
                    thingRo["lastMeasurements"] = lastMeasurementsObject;
                    thingRopropCount++;
                }

                var lastMeasurementsTimestampsObject = new JObject();
                var lastMeasurementsTimestampsObjectpropCount = 0;
                if (thingRolastMeasurementsarray != null)
                {
                    lastMeasurementsTimestampsObject["array"] = ExpressionConverter.ConvertO(thingRolastMeasurementsarray);
                    lastMeasurementsTimestampsObjectpropCount++;
                }

                if (thingRolastMeasurementsbigDecimal != null)
                {
                    lastMeasurementsTimestampsObject["bigDecimal"] = ExpressionConverter.ConvertO(thingRolastMeasurementsbigDecimal);
                    lastMeasurementsTimestampsObjectpropCount++;
                }

                if (thingRolastMeasurementsbigInteger != null)
                {
                    lastMeasurementsTimestampsObject["bigInteger"] = ExpressionConverter.ConvertO(thingRolastMeasurementsbigInteger);
                    lastMeasurementsTimestampsObjectpropCount++;
                }

                if (thingRolastMeasurementsbinary != null)
                {
                    lastMeasurementsTimestampsObject["binary"] = ExpressionConverter.ConvertO(thingRolastMeasurementsbinary);
                    lastMeasurementsTimestampsObjectpropCount++;
                }

                if (thingRolastMeasurementsboolean != null)
                {
                    lastMeasurementsTimestampsObject["boolean"] = ExpressionConverter.ConvertO(thingRolastMeasurementsboolean);
                    lastMeasurementsTimestampsObjectpropCount++;
                }

                if (thingRolastMeasurementscontainerNode != null)
                {
                    lastMeasurementsTimestampsObject["containerNode"] = ExpressionConverter.ConvertO(thingRolastMeasurementscontainerNode);
                    lastMeasurementsTimestampsObjectpropCount++;
                }

                if (thingRolastMeasurementsdouble != null)
                {
                    lastMeasurementsTimestampsObject["double"] = ExpressionConverter.ConvertO(thingRolastMeasurementsdouble);
                    lastMeasurementsTimestampsObjectpropCount++;
                }

                if (thingRolastMeasurementsfloat != null)
                {
                    lastMeasurementsTimestampsObject["float"] = ExpressionConverter.ConvertO(thingRolastMeasurementsfloat);
                    lastMeasurementsTimestampsObjectpropCount++;
                }

                if (thingRolastMeasurementsfloatingPointNumber != null)
                {
                    lastMeasurementsTimestampsObject["floatingPointNumber"] = ExpressionConverter.ConvertO(thingRolastMeasurementsfloatingPointNumber);
                    lastMeasurementsTimestampsObjectpropCount++;
                }

                if (thingRolastMeasurementsint != null)
                {
                    lastMeasurementsTimestampsObject["int"] = ExpressionConverter.ConvertO(thingRolastMeasurementsint);
                    lastMeasurementsTimestampsObjectpropCount++;
                }

                if (thingRolastMeasurementsintegralNumber != null)
                {
                    lastMeasurementsTimestampsObject["integralNumber"] = ExpressionConverter.ConvertO(thingRolastMeasurementsintegralNumber);
                    lastMeasurementsTimestampsObjectpropCount++;
                }

                if (thingRolastMeasurementsLong != null)
                {
                    lastMeasurementsTimestampsObject["long"] = ExpressionConverter.ConvertO(thingRolastMeasurementsLong);
                    lastMeasurementsTimestampsObjectpropCount++;
                }

                if (thingRolastMeasurementsmissingNode != null)
                {
                    lastMeasurementsTimestampsObject["missingNode"] = ExpressionConverter.ConvertO(thingRolastMeasurementsmissingNode);
                    lastMeasurementsTimestampsObjectpropCount++;
                }

                if (thingRolastMeasurementsnodeType != null)
                {
                    lastMeasurementsTimestampsObject["nodeType"] = ExpressionConverter.ConvertO(thingRolastMeasurementsnodeType);
                    lastMeasurementsTimestampsObjectpropCount++;
                }

                if (thingRolastMeasurementsnull != null)
                {
                    lastMeasurementsTimestampsObject["null"] = ExpressionConverter.ConvertO(thingRolastMeasurementsnull);
                    lastMeasurementsTimestampsObjectpropCount++;
                }

                if (thingRolastMeasurementsnumber != null)
                {
                    lastMeasurementsTimestampsObject["number"] = ExpressionConverter.ConvertO(thingRolastMeasurementsnumber);
                    lastMeasurementsTimestampsObjectpropCount++;
                }

                if (thingRolastMeasurementsObject != null)
                {
                    lastMeasurementsTimestampsObject["object"] = ExpressionConverter.ConvertO(thingRolastMeasurementsObject);
                    lastMeasurementsTimestampsObjectpropCount++;
                }

                if (thingRolastMeasurementspojo != null)
                {
                    lastMeasurementsTimestampsObject["pojo"] = ExpressionConverter.ConvertO(thingRolastMeasurementspojo);
                    lastMeasurementsTimestampsObjectpropCount++;
                }

                if (thingRolastMeasurementsShort != null)
                {
                    lastMeasurementsTimestampsObject["short"] = ExpressionConverter.ConvertO(thingRolastMeasurementsShort);
                    lastMeasurementsTimestampsObjectpropCount++;
                }

                if (thingRolastMeasurementstextual != null)
                {
                    lastMeasurementsTimestampsObject["textual"] = ExpressionConverter.ConvertO(thingRolastMeasurementstextual);
                    lastMeasurementsTimestampsObjectpropCount++;
                }

                if (thingRolastMeasurementsvalueNode != null)
                {
                    lastMeasurementsTimestampsObject["valueNode"] = ExpressionConverter.ConvertO(thingRolastMeasurementsvalueNode);
                    lastMeasurementsTimestampsObjectpropCount++;
                }

                if (lastMeasurementsTimestampsObjectpropCount > 0)
                {
                    thingRo["lastMeasurementsTimestamps"] = lastMeasurementsTimestampsObject;
                    thingRopropCount++;
                }

                if (thingRolastMessageDate != null)
                {
                    thingRo["lastMessageDate"] = ExpressionConverter.ConvertO(thingRolastMessageDate);
                    thingRopropCount++;
                }

                if (thingRomessageActivityTimeoutPeriod != null)
                {
                    thingRo["messageActivityTimeoutPeriod"] = ExpressionConverter.ConvertO(thingRomessageActivityTimeoutPeriod);
                    thingRopropCount++;
                }

                thingRopropCount++;
                thingRo["name"] = ExpressionConverter.ConvertO(thingRoname);
                if (thingRonbAlerts != null)
                {
                    thingRo["nbAlerts"] = ExpressionConverter.ConvertO(thingRonbAlerts);
                    thingRopropCount++;
                }

                var siteObject = new JObject();
                var siteObjectpropCount = 0;
                siteObjectpropCount++;
                siteObject["address"] = ExpressionConverter.ConvertO(thingRositeaddress);
                siteObjectpropCount++;
                siteObject["city"] = ExpressionConverter.ConvertO(thingRositecity);
                if (thingRositeid != null)
                {
                    siteObject["id"] = ExpressionConverter.ConvertO(thingRositeid);
                    siteObjectpropCount++;
                }

                if (thingRositelatitude != null)
                {
                    siteObject["latitude"] = ExpressionConverter.ConvertO(thingRositelatitude);
                    siteObjectpropCount++;
                }

                if (thingRositelongitude != null)
                {
                    siteObject["longitude"] = ExpressionConverter.ConvertO(thingRositelongitude);
                    siteObjectpropCount++;
                }

                siteObjectpropCount++;
                siteObject["name"] = ExpressionConverter.ConvertO(thingRositename);
                siteObjectpropCount++;
                siteObject["postalCode"] = ExpressionConverter.ConvertO(thingRositepostalCode);
                if (siteObjectpropCount > 0)
                {
                    thingRo["site"] = siteObject;
                    thingRopropCount++;
                }

                if (thingRostatus != null)
                {
                    thingRo["status"] = ExpressionConverter.ConvertO(thingRostatus);
                    thingRopropCount++;
                }

                if (thingRotags != null)
                {
                    thingRo["tags"] = ExpressionConverter.ConvertO(thingRotags);
                    thingRopropCount++;
                }

                if (thingRopropCount > 0)
                {
                    callPayload.Body = thingRo;
                }

                return new ApiConnectionAction<SingleThingRo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        [WorkflowExpressionFactory(nameof(__BuildGetThingProduct))]
        public IBodyWorkflowAction<ProductRo> GetThingProduct([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ProductRo> __BuildGetThingProduct(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<ProductRo>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/things/{0}/product", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ProductRo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        [WorkflowExpressionFactory(nameof(__BuildDissociateThingProduct))]
        public IBodyWorkflowAction<SingleThingRo> DissociateThingProduct([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SingleThingRo> __BuildDissociateThingProduct(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<SingleThingRo>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/things/{0}/product", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SingleThingRo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        [WorkflowExpressionFactory(nameof(__BuildAssociateThingProduct))]
        public IBodyWorkflowAction<SingleThingRo> AssociateThingProduct([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> productcertification = null, [WorkflowExpression] Func<productconnectivityTypesInputItem[]> productconnectivityTypes = null, [WorkflowExpression] Func<string> productdecoderid = null, [WorkflowExpression] Func<string> productdecoderlink = null, [WorkflowExpression] Func<bool> productdecodervisible = null, [WorkflowExpression] Func<string> productdescription = null, [WorkflowExpression] Func<string> productencoderid = null, [WorkflowExpression] Func<string> productencoderlink = null, [WorkflowExpression] Func<bool> productgenerateLinks = null, [WorkflowExpression] Func<bool> producthasImage = null, [WorkflowExpression] Func<string> productid = null, [WorkflowExpression] Func<string> productimageLink = null, [WorkflowExpression] Func<string> productinfoLink = null, [WorkflowExpression] Func<string> productlink = null, [WorkflowExpression] Func<bool> productmanufacturergenerateLinks = null, [WorkflowExpression] Func<string> productmanufacturerid = null, [WorkflowExpression] Func<string> productmanufacturerlink = null, [WorkflowExpression] Func<string> productmanufacturername = null, [WorkflowExpression] Func<string> productmanufacturerCategory = null, [WorkflowExpression] Func<string> productmodelcolor = null, [WorkflowExpression] Func<bool> productmodelgenerateLinks = null, [WorkflowExpression] Func<string> productmodelicon = null, [WorkflowExpression] Func<string> productmodelid = null, [WorkflowExpression] Func<bool> productmodelisCustomModel = null, [WorkflowExpression] Func<bool> productmodellinkabsolute = null, [WorkflowExpression] Func<string> productmodellinkauthority = null, [WorkflowExpression] Func<string> productmodellinkfragment = null, [WorkflowExpression] Func<string> productmodellinkhost = null, [WorkflowExpression] Func<bool> productmodellinkopaque = null, [WorkflowExpression] Func<string> productmodellinkpath = null, [WorkflowExpression] Func<int> productmodellinkport = null, [WorkflowExpression] Func<string> productmodellinkquery = null, [WorkflowExpression] Func<string> productmodellinkrawAuthority = null, [WorkflowExpression] Func<string> productmodellinkrawFragment = null, [WorkflowExpression] Func<string> productmodellinkrawPath = null, [WorkflowExpression] Func<string> productmodellinkrawQuery = null, [WorkflowExpression] Func<string> productmodellinkrawSchemeSpecificPart = null, [WorkflowExpression] Func<string> productmodellinkrawUserInfo = null, [WorkflowExpression] Func<string> productmodellinkscheme = null, [WorkflowExpression] Func<string> productmodellinkschemeSpecificPart = null, [WorkflowExpression] Func<string> productmodellinkuserInfo = null, [WorkflowExpression] Func<string> productmodelname = null, [WorkflowExpression] Func<bool> productmodelManufacturergenerateLinks = null, [WorkflowExpression] Func<string> productmodelManufacturerid = null, [WorkflowExpression] Func<string> productmodelManufacturerlink = null, [WorkflowExpression] Func<string> productmodelManufacturername = null, [WorkflowExpression] Func<string> productname = null, [WorkflowExpression] Func<bool> productreadOnly = null, [WorkflowExpression] Func<string> productreference = null, [WorkflowExpression] Func<TagRo[]> producttags = null, [WorkflowExpression] Func<ThingTinyRo[]> productthings = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SingleThingRo> __BuildAssociateThingProduct(WorkflowExpression<string> id, WorkflowExpression<string> productcertification = null, WorkflowExpression<productconnectivityTypesInputItem[]> productconnectivityTypes = null, WorkflowExpression<string> productdecoderid = null, WorkflowExpression<string> productdecoderlink = null, WorkflowExpression<bool> productdecodervisible = null, WorkflowExpression<string> productdescription = null, WorkflowExpression<string> productencoderid = null, WorkflowExpression<string> productencoderlink = null, WorkflowExpression<bool> productgenerateLinks = null, WorkflowExpression<bool> producthasImage = null, WorkflowExpression<string> productid = null, WorkflowExpression<string> productimageLink = null, WorkflowExpression<string> productinfoLink = null, WorkflowExpression<string> productlink = null, WorkflowExpression<bool> productmanufacturergenerateLinks = null, WorkflowExpression<string> productmanufacturerid = null, WorkflowExpression<string> productmanufacturerlink = null, WorkflowExpression<string> productmanufacturername = null, WorkflowExpression<string> productmanufacturerCategory = null, WorkflowExpression<string> productmodelcolor = null, WorkflowExpression<bool> productmodelgenerateLinks = null, WorkflowExpression<string> productmodelicon = null, WorkflowExpression<string> productmodelid = null, WorkflowExpression<bool> productmodelisCustomModel = null, WorkflowExpression<bool> productmodellinkabsolute = null, WorkflowExpression<string> productmodellinkauthority = null, WorkflowExpression<string> productmodellinkfragment = null, WorkflowExpression<string> productmodellinkhost = null, WorkflowExpression<bool> productmodellinkopaque = null, WorkflowExpression<string> productmodellinkpath = null, WorkflowExpression<int> productmodellinkport = null, WorkflowExpression<string> productmodellinkquery = null, WorkflowExpression<string> productmodellinkrawAuthority = null, WorkflowExpression<string> productmodellinkrawFragment = null, WorkflowExpression<string> productmodellinkrawPath = null, WorkflowExpression<string> productmodellinkrawQuery = null, WorkflowExpression<string> productmodellinkrawSchemeSpecificPart = null, WorkflowExpression<string> productmodellinkrawUserInfo = null, WorkflowExpression<string> productmodellinkscheme = null, WorkflowExpression<string> productmodellinkschemeSpecificPart = null, WorkflowExpression<string> productmodellinkuserInfo = null, WorkflowExpression<string> productmodelname = null, WorkflowExpression<bool> productmodelManufacturergenerateLinks = null, WorkflowExpression<string> productmodelManufacturerid = null, WorkflowExpression<string> productmodelManufacturerlink = null, WorkflowExpression<string> productmodelManufacturername = null, WorkflowExpression<string> productname = null, WorkflowExpression<bool> productreadOnly = null, WorkflowExpression<string> productreference = null, WorkflowExpression<TagRo[]> producttags = null, WorkflowExpression<ThingTinyRo[]> productthings = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(productcertification, nameof(productcertification), required: false);
            WorkflowExpression.Validate(productconnectivityTypes, nameof(productconnectivityTypes), required: false);
            WorkflowExpression.Validate(productdecoderid, nameof(productdecoderid), required: false);
            WorkflowExpression.Validate(productdecoderlink, nameof(productdecoderlink), required: false);
            WorkflowExpression.Validate(productdecodervisible, nameof(productdecodervisible), required: false);
            WorkflowExpression.Validate(productdescription, nameof(productdescription), required: false);
            WorkflowExpression.Validate(productencoderid, nameof(productencoderid), required: false);
            WorkflowExpression.Validate(productencoderlink, nameof(productencoderlink), required: false);
            WorkflowExpression.Validate(productgenerateLinks, nameof(productgenerateLinks), required: false);
            WorkflowExpression.Validate(producthasImage, nameof(producthasImage), required: false);
            WorkflowExpression.Validate(productid, nameof(productid), required: false);
            WorkflowExpression.Validate(productimageLink, nameof(productimageLink), required: false);
            WorkflowExpression.Validate(productinfoLink, nameof(productinfoLink), required: false);
            WorkflowExpression.Validate(productlink, nameof(productlink), required: false);
            WorkflowExpression.Validate(productmanufacturergenerateLinks, nameof(productmanufacturergenerateLinks), required: false);
            WorkflowExpression.Validate(productmanufacturerid, nameof(productmanufacturerid), required: false);
            WorkflowExpression.Validate(productmanufacturerlink, nameof(productmanufacturerlink), required: false);
            WorkflowExpression.Validate(productmanufacturername, nameof(productmanufacturername), required: false);
            WorkflowExpression.Validate(productmanufacturerCategory, nameof(productmanufacturerCategory), required: false);
            WorkflowExpression.Validate(productmodelcolor, nameof(productmodelcolor), required: false);
            WorkflowExpression.Validate(productmodelgenerateLinks, nameof(productmodelgenerateLinks), required: false);
            WorkflowExpression.Validate(productmodelicon, nameof(productmodelicon), required: false);
            WorkflowExpression.Validate(productmodelid, nameof(productmodelid), required: false);
            WorkflowExpression.Validate(productmodelisCustomModel, nameof(productmodelisCustomModel), required: false);
            WorkflowExpression.Validate(productmodellinkabsolute, nameof(productmodellinkabsolute), required: false);
            WorkflowExpression.Validate(productmodellinkauthority, nameof(productmodellinkauthority), required: false);
            WorkflowExpression.Validate(productmodellinkfragment, nameof(productmodellinkfragment), required: false);
            WorkflowExpression.Validate(productmodellinkhost, nameof(productmodellinkhost), required: false);
            WorkflowExpression.Validate(productmodellinkopaque, nameof(productmodellinkopaque), required: false);
            WorkflowExpression.Validate(productmodellinkpath, nameof(productmodellinkpath), required: false);
            WorkflowExpression.Validate(productmodellinkport, nameof(productmodellinkport), required: false);
            WorkflowExpression.Validate(productmodellinkquery, nameof(productmodellinkquery), required: false);
            WorkflowExpression.Validate(productmodellinkrawAuthority, nameof(productmodellinkrawAuthority), required: false);
            WorkflowExpression.Validate(productmodellinkrawFragment, nameof(productmodellinkrawFragment), required: false);
            WorkflowExpression.Validate(productmodellinkrawPath, nameof(productmodellinkrawPath), required: false);
            WorkflowExpression.Validate(productmodellinkrawQuery, nameof(productmodellinkrawQuery), required: false);
            WorkflowExpression.Validate(productmodellinkrawSchemeSpecificPart, nameof(productmodellinkrawSchemeSpecificPart), required: false);
            WorkflowExpression.Validate(productmodellinkrawUserInfo, nameof(productmodellinkrawUserInfo), required: false);
            WorkflowExpression.Validate(productmodellinkscheme, nameof(productmodellinkscheme), required: false);
            WorkflowExpression.Validate(productmodellinkschemeSpecificPart, nameof(productmodellinkschemeSpecificPart), required: false);
            WorkflowExpression.Validate(productmodellinkuserInfo, nameof(productmodellinkuserInfo), required: false);
            WorkflowExpression.Validate(productmodelname, nameof(productmodelname), required: false);
            WorkflowExpression.Validate(productmodelManufacturergenerateLinks, nameof(productmodelManufacturergenerateLinks), required: false);
            WorkflowExpression.Validate(productmodelManufacturerid, nameof(productmodelManufacturerid), required: false);
            WorkflowExpression.Validate(productmodelManufacturerlink, nameof(productmodelManufacturerlink), required: false);
            WorkflowExpression.Validate(productmodelManufacturername, nameof(productmodelManufacturername), required: false);
            WorkflowExpression.Validate(productname, nameof(productname), required: false);
            WorkflowExpression.Validate(productreadOnly, nameof(productreadOnly), required: false);
            WorkflowExpression.Validate(productreference, nameof(productreference), required: false);
            WorkflowExpression.Validate(producttags, nameof(producttags), required: false);
            WorkflowExpression.Validate(productthings, nameof(productthings), required: false);
            return new DeferredBodyAction<SingleThingRo>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/things/{0}/product", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var product = new JObject();
                var productpropCount = 0;
                if (productcertification != null)
                {
                    product["certification"] = ExpressionConverter.ConvertO(productcertification);
                    productpropCount++;
                }

                if (productconnectivityTypes != null)
                {
                    product["connectivityTypes"] = ExpressionConverter.ConvertO(productconnectivityTypes);
                    productpropCount++;
                }

                var decoderObject = new JObject();
                var decoderObjectpropCount = 0;
                if (productdecoderid != null)
                {
                    decoderObject["id"] = ExpressionConverter.ConvertO(productdecoderid);
                    decoderObjectpropCount++;
                }

                if (productdecoderlink != null)
                {
                    decoderObject["link"] = ExpressionConverter.ConvertO(productdecoderlink);
                    decoderObjectpropCount++;
                }

                if (productdecodervisible != null)
                {
                    decoderObject["visible"] = ExpressionConverter.ConvertO(productdecodervisible);
                    decoderObjectpropCount++;
                }

                if (decoderObjectpropCount > 0)
                {
                    product["decoder"] = decoderObject;
                    productpropCount++;
                }

                if (productdescription != null)
                {
                    product["description"] = ExpressionConverter.ConvertO(productdescription);
                    productpropCount++;
                }

                var encoderObject = new JObject();
                var encoderObjectpropCount = 0;
                if (productencoderid != null)
                {
                    encoderObject["id"] = ExpressionConverter.ConvertO(productencoderid);
                    encoderObjectpropCount++;
                }

                if (productencoderlink != null)
                {
                    encoderObject["link"] = ExpressionConverter.ConvertO(productencoderlink);
                    encoderObjectpropCount++;
                }

                if (encoderObjectpropCount > 0)
                {
                    product["encoder"] = encoderObject;
                    productpropCount++;
                }

                if (productgenerateLinks != null)
                {
                    product["generateLinks"] = ExpressionConverter.ConvertO(productgenerateLinks);
                    productpropCount++;
                }

                if (producthasImage != null)
                {
                    product["hasImage"] = ExpressionConverter.ConvertO(producthasImage);
                    productpropCount++;
                }

                if (productid != null)
                {
                    product["id"] = ExpressionConverter.ConvertO(productid);
                    productpropCount++;
                }

                if (productimageLink != null)
                {
                    product["imageLink"] = ExpressionConverter.ConvertO(productimageLink);
                    productpropCount++;
                }

                if (productinfoLink != null)
                {
                    product["infoLink"] = ExpressionConverter.ConvertO(productinfoLink);
                    productpropCount++;
                }

                if (productlink != null)
                {
                    product["link"] = ExpressionConverter.ConvertO(productlink);
                    productpropCount++;
                }

                var manufacturerObject = new JObject();
                var manufacturerObjectpropCount = 0;
                if (productmanufacturergenerateLinks != null)
                {
                    manufacturerObject["generateLinks"] = ExpressionConverter.ConvertO(productmanufacturergenerateLinks);
                    manufacturerObjectpropCount++;
                }

                if (productmanufacturerid != null)
                {
                    manufacturerObject["id"] = ExpressionConverter.ConvertO(productmanufacturerid);
                    manufacturerObjectpropCount++;
                }

                if (productmanufacturerlink != null)
                {
                    manufacturerObject["link"] = ExpressionConverter.ConvertO(productmanufacturerlink);
                    manufacturerObjectpropCount++;
                }

                if (productmanufacturername != null)
                {
                    manufacturerObject["name"] = ExpressionConverter.ConvertO(productmanufacturername);
                    manufacturerObjectpropCount++;
                }

                if (manufacturerObjectpropCount > 0)
                {
                    product["manufacturer"] = manufacturerObject;
                    productpropCount++;
                }

                if (productmanufacturerCategory != null)
                {
                    product["manufacturerCategory"] = ExpressionConverter.ConvertO(productmanufacturerCategory);
                    productpropCount++;
                }

                var modelObject = new JObject();
                var modelObjectpropCount = 0;
                if (productmodelcolor != null)
                {
                    modelObject["color"] = ExpressionConverter.ConvertO(productmodelcolor);
                    modelObjectpropCount++;
                }

                if (productmodelgenerateLinks != null)
                {
                    modelObject["generateLinks"] = ExpressionConverter.ConvertO(productmodelgenerateLinks);
                    modelObjectpropCount++;
                }

                if (productmodelicon != null)
                {
                    modelObject["icon"] = ExpressionConverter.ConvertO(productmodelicon);
                    modelObjectpropCount++;
                }

                if (productmodelid != null)
                {
                    modelObject["id"] = ExpressionConverter.ConvertO(productmodelid);
                    modelObjectpropCount++;
                }

                if (productmodelisCustomModel != null)
                {
                    modelObject["isCustomModel"] = ExpressionConverter.ConvertO(productmodelisCustomModel);
                    modelObjectpropCount++;
                }

                var linkObject = new JObject();
                var linkObjectpropCount = 0;
                if (productmodellinkabsolute != null)
                {
                    linkObject["absolute"] = ExpressionConverter.ConvertO(productmodellinkabsolute);
                    linkObjectpropCount++;
                }

                if (productmodellinkauthority != null)
                {
                    linkObject["authority"] = ExpressionConverter.ConvertO(productmodellinkauthority);
                    linkObjectpropCount++;
                }

                if (productmodellinkfragment != null)
                {
                    linkObject["fragment"] = ExpressionConverter.ConvertO(productmodellinkfragment);
                    linkObjectpropCount++;
                }

                if (productmodellinkhost != null)
                {
                    linkObject["host"] = ExpressionConverter.ConvertO(productmodellinkhost);
                    linkObjectpropCount++;
                }

                if (productmodellinkopaque != null)
                {
                    linkObject["opaque"] = ExpressionConverter.ConvertO(productmodellinkopaque);
                    linkObjectpropCount++;
                }

                if (productmodellinkpath != null)
                {
                    linkObject["path"] = ExpressionConverter.ConvertO(productmodellinkpath);
                    linkObjectpropCount++;
                }

                if (productmodellinkport != null)
                {
                    linkObject["port"] = ExpressionConverter.ConvertO(productmodellinkport);
                    linkObjectpropCount++;
                }

                if (productmodellinkquery != null)
                {
                    linkObject["query"] = ExpressionConverter.ConvertO(productmodellinkquery);
                    linkObjectpropCount++;
                }

                if (productmodellinkrawAuthority != null)
                {
                    linkObject["rawAuthority"] = ExpressionConverter.ConvertO(productmodellinkrawAuthority);
                    linkObjectpropCount++;
                }

                if (productmodellinkrawFragment != null)
                {
                    linkObject["rawFragment"] = ExpressionConverter.ConvertO(productmodellinkrawFragment);
                    linkObjectpropCount++;
                }

                if (productmodellinkrawPath != null)
                {
                    linkObject["rawPath"] = ExpressionConverter.ConvertO(productmodellinkrawPath);
                    linkObjectpropCount++;
                }

                if (productmodellinkrawQuery != null)
                {
                    linkObject["rawQuery"] = ExpressionConverter.ConvertO(productmodellinkrawQuery);
                    linkObjectpropCount++;
                }

                if (productmodellinkrawSchemeSpecificPart != null)
                {
                    linkObject["rawSchemeSpecificPart"] = ExpressionConverter.ConvertO(productmodellinkrawSchemeSpecificPart);
                    linkObjectpropCount++;
                }

                if (productmodellinkrawUserInfo != null)
                {
                    linkObject["rawUserInfo"] = ExpressionConverter.ConvertO(productmodellinkrawUserInfo);
                    linkObjectpropCount++;
                }

                if (productmodellinkscheme != null)
                {
                    linkObject["scheme"] = ExpressionConverter.ConvertO(productmodellinkscheme);
                    linkObjectpropCount++;
                }

                if (productmodellinkschemeSpecificPart != null)
                {
                    linkObject["schemeSpecificPart"] = ExpressionConverter.ConvertO(productmodellinkschemeSpecificPart);
                    linkObjectpropCount++;
                }

                if (productmodellinkuserInfo != null)
                {
                    linkObject["userInfo"] = ExpressionConverter.ConvertO(productmodellinkuserInfo);
                    linkObjectpropCount++;
                }

                if (linkObjectpropCount > 0)
                {
                    modelObject["link"] = linkObject;
                    modelObjectpropCount++;
                }

                if (productmodelname != null)
                {
                    modelObject["name"] = ExpressionConverter.ConvertO(productmodelname);
                    modelObjectpropCount++;
                }

                if (modelObjectpropCount > 0)
                {
                    product["model"] = modelObject;
                    productpropCount++;
                }

                var modelManufacturerObject = new JObject();
                var modelManufacturerObjectpropCount = 0;
                if (productmanufacturergenerateLinks != null)
                {
                    modelManufacturerObject["generateLinks"] = ExpressionConverter.ConvertO(productmanufacturergenerateLinks);
                    modelManufacturerObjectpropCount++;
                }

                if (productmanufacturerid != null)
                {
                    modelManufacturerObject["id"] = ExpressionConverter.ConvertO(productmanufacturerid);
                    modelManufacturerObjectpropCount++;
                }

                if (productmanufacturerlink != null)
                {
                    modelManufacturerObject["link"] = ExpressionConverter.ConvertO(productmanufacturerlink);
                    modelManufacturerObjectpropCount++;
                }

                if (productmanufacturername != null)
                {
                    modelManufacturerObject["name"] = ExpressionConverter.ConvertO(productmanufacturername);
                    modelManufacturerObjectpropCount++;
                }

                if (modelManufacturerObjectpropCount > 0)
                {
                    product["modelManufacturer"] = modelManufacturerObject;
                    productpropCount++;
                }

                if (productname != null)
                {
                    product["name"] = ExpressionConverter.ConvertO(productname);
                    productpropCount++;
                }

                if (productreadOnly != null)
                {
                    product["readOnly"] = ExpressionConverter.ConvertO(productreadOnly);
                    productpropCount++;
                }

                if (productreference != null)
                {
                    product["reference"] = ExpressionConverter.ConvertO(productreference);
                    productpropCount++;
                }

                if (producttags != null)
                {
                    product["tags"] = ExpressionConverter.ConvertO(producttags);
                    productpropCount++;
                }

                if (productthings != null)
                {
                    product["things"] = ExpressionConverter.ConvertO(productthings);
                    productpropCount++;
                }

                if (productpropCount > 0)
                {
                    callPayload.Body = product;
                }

                return new ApiConnectionAction<SingleThingRo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        [WorkflowExpressionFactory(nameof(__BuildGetFlowsRelatedToThing))]
        public IBodyWorkflowAction<PageFlowRo> GetFlowsRelatedToThing([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PageFlowRo> __BuildGetFlowsRelatedToThing(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<PageFlowRo>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/things/{0}/related_flows", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<PageFlowRo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        [WorkflowExpressionFactory(nameof(__BuildGetThingTags))]
        public IBodyWorkflowAction<PageThingTagRo> GetThingTags([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PageThingTagRo> __BuildGetThingTags(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<PageThingTagRo>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/things/{0}/tags", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<PageThingTagRo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        [WorkflowExpressionFactory(nameof(__BuildGetStatsAvg))]
        public IBodyWorkflowAction<PageStatsMeasureRo> GetStatsAvg([WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null, [WorkflowExpression] Func<string> sortValues = null, [WorkflowExpression] Func<string> sort = null, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<dirInput> dir = null, [WorkflowExpression] Func<string> orFilter = null, [WorkflowExpression] Func<int> start = null, [WorkflowExpression] Func<int> end = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PageStatsMeasureRo> __BuildGetStatsAvg(WorkflowExpression<int> page = null, WorkflowExpression<int> pageSize = null, WorkflowExpression<string> sortValues = null, WorkflowExpression<string> sort = null, WorkflowExpression<string> filter = null, WorkflowExpression<dirInput> dir = null, WorkflowExpression<string> orFilter = null, WorkflowExpression<int> start = null, WorkflowExpression<int> end = null)
        {
            WorkflowExpression.Validate(page, nameof(page), required: false);
            WorkflowExpression.Validate(pageSize, nameof(pageSize), required: false);
            WorkflowExpression.Validate(sortValues, nameof(sortValues), required: false);
            WorkflowExpression.Validate(sort, nameof(sort), required: false);
            WorkflowExpression.Validate(filter, nameof(filter), required: false);
            WorkflowExpression.Validate(dir, nameof(dir), required: false);
            WorkflowExpression.Validate(orFilter, nameof(orFilter), required: false);
            WorkflowExpression.Validate(start, nameof(start), required: false);
            WorkflowExpression.Validate(end, nameof(end), required: false);
            return new DeferredBodyAction<PageStatsMeasureRo>(() =>
            {
                var apiCallPath = "/stats/avg";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(page);
                if (pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(pageSize);
                if (sortValues != null)
                    callPayload.Queries["sortValues"] = ExpressionConverter.Convert(sortValues);
                if (sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(sort);
                if (filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(filter);
                if (dir != null)
                    callPayload.Queries["dir"] = ExpressionConverter.Convert(dir);
                if (orFilter != null)
                    callPayload.Queries["orFilter"] = ExpressionConverter.Convert(orFilter);
                if (start != null)
                    callPayload.Queries["start"] = ExpressionConverter.Convert(start);
                if (end != null)
                    callPayload.Queries["end"] = ExpressionConverter.Convert(end);
                return new ApiConnectionAction<PageStatsMeasureRo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        [WorkflowExpressionFactory(nameof(__BuildGetStatsCount))]
        public IBodyWorkflowAction<StatsCountRo> GetStatsCount([WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null, [WorkflowExpression] Func<string> sortValues = null, [WorkflowExpression] Func<string> sort = null, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<dirInput> dir = null, [WorkflowExpression] Func<string> orFilter = null, [WorkflowExpression] Func<int> start = null, [WorkflowExpression] Func<int> end = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<StatsCountRo> __BuildGetStatsCount(WorkflowExpression<int> page = null, WorkflowExpression<int> pageSize = null, WorkflowExpression<string> sortValues = null, WorkflowExpression<string> sort = null, WorkflowExpression<string> filter = null, WorkflowExpression<dirInput> dir = null, WorkflowExpression<string> orFilter = null, WorkflowExpression<int> start = null, WorkflowExpression<int> end = null)
        {
            WorkflowExpression.Validate(page, nameof(page), required: false);
            WorkflowExpression.Validate(pageSize, nameof(pageSize), required: false);
            WorkflowExpression.Validate(sortValues, nameof(sortValues), required: false);
            WorkflowExpression.Validate(sort, nameof(sort), required: false);
            WorkflowExpression.Validate(filter, nameof(filter), required: false);
            WorkflowExpression.Validate(dir, nameof(dir), required: false);
            WorkflowExpression.Validate(orFilter, nameof(orFilter), required: false);
            WorkflowExpression.Validate(start, nameof(start), required: false);
            WorkflowExpression.Validate(end, nameof(end), required: false);
            return new DeferredBodyAction<StatsCountRo>(() =>
            {
                var apiCallPath = "/stats/count";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(page);
                if (pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(pageSize);
                if (sortValues != null)
                    callPayload.Queries["sortValues"] = ExpressionConverter.Convert(sortValues);
                if (sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(sort);
                if (filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(filter);
                if (dir != null)
                    callPayload.Queries["dir"] = ExpressionConverter.Convert(dir);
                if (orFilter != null)
                    callPayload.Queries["orFilter"] = ExpressionConverter.Convert(orFilter);
                if (start != null)
                    callPayload.Queries["start"] = ExpressionConverter.Convert(start);
                if (end != null)
                    callPayload.Queries["end"] = ExpressionConverter.Convert(end);
                return new ApiConnectionAction<StatsCountRo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        [WorkflowExpressionFactory(nameof(__BuildGetStatsLast))]
        public IBodyWorkflowAction<PageStatsMeasureRo> GetStatsLast([WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null, [WorkflowExpression] Func<string> sortValues = null, [WorkflowExpression] Func<string> sort = null, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<dirInput> dir = null, [WorkflowExpression] Func<string> orFilter = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PageStatsMeasureRo> __BuildGetStatsLast(WorkflowExpression<int> page = null, WorkflowExpression<int> pageSize = null, WorkflowExpression<string> sortValues = null, WorkflowExpression<string> sort = null, WorkflowExpression<string> filter = null, WorkflowExpression<dirInput> dir = null, WorkflowExpression<string> orFilter = null)
        {
            WorkflowExpression.Validate(page, nameof(page), required: false);
            WorkflowExpression.Validate(pageSize, nameof(pageSize), required: false);
            WorkflowExpression.Validate(sortValues, nameof(sortValues), required: false);
            WorkflowExpression.Validate(sort, nameof(sort), required: false);
            WorkflowExpression.Validate(filter, nameof(filter), required: false);
            WorkflowExpression.Validate(dir, nameof(dir), required: false);
            WorkflowExpression.Validate(orFilter, nameof(orFilter), required: false);
            return new DeferredBodyAction<PageStatsMeasureRo>(() =>
            {
                var apiCallPath = "/stats/last";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(page);
                if (pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(pageSize);
                if (sortValues != null)
                    callPayload.Queries["sortValues"] = ExpressionConverter.Convert(sortValues);
                if (sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(sort);
                if (filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(filter);
                if (dir != null)
                    callPayload.Queries["dir"] = ExpressionConverter.Convert(dir);
                if (orFilter != null)
                    callPayload.Queries["orFilter"] = ExpressionConverter.Convert(orFilter);
                return new ApiConnectionAction<PageStatsMeasureRo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        [WorkflowExpressionFactory(nameof(__BuildGetThingStatsLast))]
        public IBodyWorkflowAction<PageStatsMeasureRo> GetThingStatsLast([WorkflowExpression] Func<string> thingId, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null, [WorkflowExpression] Func<string> sortValues = null, [WorkflowExpression] Func<string> sort = null, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<dirInput> dir = null, [WorkflowExpression] Func<string> orFilter = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PageStatsMeasureRo> __BuildGetThingStatsLast(WorkflowExpression<string> thingId, WorkflowExpression<int> page = null, WorkflowExpression<int> pageSize = null, WorkflowExpression<string> sortValues = null, WorkflowExpression<string> sort = null, WorkflowExpression<string> filter = null, WorkflowExpression<dirInput> dir = null, WorkflowExpression<string> orFilter = null)
        {
            WorkflowExpression.Validate(thingId, nameof(thingId), required: true);
            WorkflowExpression.Validate(page, nameof(page), required: false);
            WorkflowExpression.Validate(pageSize, nameof(pageSize), required: false);
            WorkflowExpression.Validate(sortValues, nameof(sortValues), required: false);
            WorkflowExpression.Validate(sort, nameof(sort), required: false);
            WorkflowExpression.Validate(filter, nameof(filter), required: false);
            WorkflowExpression.Validate(dir, nameof(dir), required: false);
            WorkflowExpression.Validate(orFilter, nameof(orFilter), required: false);
            return new DeferredBodyAction<PageStatsMeasureRo>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/stats/last/things/{0}", ExpressionConverter.ConvertWithUrlEncoding(thingId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(page);
                if (pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(pageSize);
                if (sortValues != null)
                    callPayload.Queries["sortValues"] = ExpressionConverter.Convert(sortValues);
                if (sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(sort);
                if (filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(filter);
                if (dir != null)
                    callPayload.Queries["dir"] = ExpressionConverter.Convert(dir);
                if (orFilter != null)
                    callPayload.Queries["orFilter"] = ExpressionConverter.Convert(orFilter);
                return new ApiConnectionAction<PageStatsMeasureRo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        [WorkflowExpressionFactory(nameof(__BuildGetStatsMax))]
        public IBodyWorkflowAction<PageStatsMeasureRo> GetStatsMax([WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null, [WorkflowExpression] Func<string> sortValues = null, [WorkflowExpression] Func<string> sort = null, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<dirInput> dir = null, [WorkflowExpression] Func<string> orFilter = null, [WorkflowExpression] Func<int> start = null, [WorkflowExpression] Func<int> end = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PageStatsMeasureRo> __BuildGetStatsMax(WorkflowExpression<int> page = null, WorkflowExpression<int> pageSize = null, WorkflowExpression<string> sortValues = null, WorkflowExpression<string> sort = null, WorkflowExpression<string> filter = null, WorkflowExpression<dirInput> dir = null, WorkflowExpression<string> orFilter = null, WorkflowExpression<int> start = null, WorkflowExpression<int> end = null)
        {
            WorkflowExpression.Validate(page, nameof(page), required: false);
            WorkflowExpression.Validate(pageSize, nameof(pageSize), required: false);
            WorkflowExpression.Validate(sortValues, nameof(sortValues), required: false);
            WorkflowExpression.Validate(sort, nameof(sort), required: false);
            WorkflowExpression.Validate(filter, nameof(filter), required: false);
            WorkflowExpression.Validate(dir, nameof(dir), required: false);
            WorkflowExpression.Validate(orFilter, nameof(orFilter), required: false);
            WorkflowExpression.Validate(start, nameof(start), required: false);
            WorkflowExpression.Validate(end, nameof(end), required: false);
            return new DeferredBodyAction<PageStatsMeasureRo>(() =>
            {
                var apiCallPath = "/stats/max";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(page);
                if (pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(pageSize);
                if (sortValues != null)
                    callPayload.Queries["sortValues"] = ExpressionConverter.Convert(sortValues);
                if (sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(sort);
                if (filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(filter);
                if (dir != null)
                    callPayload.Queries["dir"] = ExpressionConverter.Convert(dir);
                if (orFilter != null)
                    callPayload.Queries["orFilter"] = ExpressionConverter.Convert(orFilter);
                if (start != null)
                    callPayload.Queries["start"] = ExpressionConverter.Convert(start);
                if (end != null)
                    callPayload.Queries["end"] = ExpressionConverter.Convert(end);
                return new ApiConnectionAction<PageStatsMeasureRo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        [WorkflowExpressionFactory(nameof(__BuildGetStatsMeasurements))]
        public IBodyWorkflowAction<StatsGraphRo[]> GetStatsMeasurements([WorkflowExpression] Func<int> start, [WorkflowExpression] Func<int> end, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null, [WorkflowExpression] Func<string> sortValues = null, [WorkflowExpression] Func<string> sort = null, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<dirInput> dir = null, [WorkflowExpression] Func<string> orFilter = null, [WorkflowExpression] Func<int> time = null, [WorkflowExpression] Func<string> interval = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<StatsGraphRo[]> __BuildGetStatsMeasurements(WorkflowExpression<int> start, WorkflowExpression<int> end, WorkflowExpression<int> page = null, WorkflowExpression<int> pageSize = null, WorkflowExpression<string> sortValues = null, WorkflowExpression<string> sort = null, WorkflowExpression<string> filter = null, WorkflowExpression<dirInput> dir = null, WorkflowExpression<string> orFilter = null, WorkflowExpression<int> time = null, WorkflowExpression<string> interval = null)
        {
            WorkflowExpression.Validate(start, nameof(start), required: true);
            WorkflowExpression.Validate(end, nameof(end), required: true);
            WorkflowExpression.Validate(page, nameof(page), required: false);
            WorkflowExpression.Validate(pageSize, nameof(pageSize), required: false);
            WorkflowExpression.Validate(sortValues, nameof(sortValues), required: false);
            WorkflowExpression.Validate(sort, nameof(sort), required: false);
            WorkflowExpression.Validate(filter, nameof(filter), required: false);
            WorkflowExpression.Validate(dir, nameof(dir), required: false);
            WorkflowExpression.Validate(orFilter, nameof(orFilter), required: false);
            WorkflowExpression.Validate(time, nameof(time), required: false);
            WorkflowExpression.Validate(interval, nameof(interval), required: false);
            return new DeferredBodyAction<StatsGraphRo[]>(() =>
            {
                var apiCallPath = "/stats/measurements";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(page);
                if (pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(pageSize);
                if (sortValues != null)
                    callPayload.Queries["sortValues"] = ExpressionConverter.Convert(sortValues);
                if (sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(sort);
                if (filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(filter);
                if (dir != null)
                    callPayload.Queries["dir"] = ExpressionConverter.Convert(dir);
                if (orFilter != null)
                    callPayload.Queries["orFilter"] = ExpressionConverter.Convert(orFilter);
                if (time != null)
                    callPayload.Queries["time"] = ExpressionConverter.Convert(time);
                if (interval != null)
                    callPayload.Queries["interval"] = ExpressionConverter.Convert(interval);
                callPayload.Queries["start"] = ExpressionConverter.Convert(start);
                callPayload.Queries["end"] = ExpressionConverter.Convert(end);
                return new ApiConnectionAction<StatsGraphRo[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        [WorkflowExpressionFactory(nameof(__BuildGetStatsMin))]
        public IBodyWorkflowAction<PageStatsMeasureRo> GetStatsMin([WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null, [WorkflowExpression] Func<string> sortValues = null, [WorkflowExpression] Func<string> sort = null, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<dirInput> dir = null, [WorkflowExpression] Func<string> orFilter = null, [WorkflowExpression] Func<int> start = null, [WorkflowExpression] Func<int> end = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PageStatsMeasureRo> __BuildGetStatsMin(WorkflowExpression<int> page = null, WorkflowExpression<int> pageSize = null, WorkflowExpression<string> sortValues = null, WorkflowExpression<string> sort = null, WorkflowExpression<string> filter = null, WorkflowExpression<dirInput> dir = null, WorkflowExpression<string> orFilter = null, WorkflowExpression<int> start = null, WorkflowExpression<int> end = null)
        {
            WorkflowExpression.Validate(page, nameof(page), required: false);
            WorkflowExpression.Validate(pageSize, nameof(pageSize), required: false);
            WorkflowExpression.Validate(sortValues, nameof(sortValues), required: false);
            WorkflowExpression.Validate(sort, nameof(sort), required: false);
            WorkflowExpression.Validate(filter, nameof(filter), required: false);
            WorkflowExpression.Validate(dir, nameof(dir), required: false);
            WorkflowExpression.Validate(orFilter, nameof(orFilter), required: false);
            WorkflowExpression.Validate(start, nameof(start), required: false);
            WorkflowExpression.Validate(end, nameof(end), required: false);
            return new DeferredBodyAction<PageStatsMeasureRo>(() =>
            {
                var apiCallPath = "/stats/min";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(page);
                if (pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(pageSize);
                if (sortValues != null)
                    callPayload.Queries["sortValues"] = ExpressionConverter.Convert(sortValues);
                if (sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(sort);
                if (filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(filter);
                if (dir != null)
                    callPayload.Queries["dir"] = ExpressionConverter.Convert(dir);
                if (orFilter != null)
                    callPayload.Queries["orFilter"] = ExpressionConverter.Convert(orFilter);
                if (start != null)
                    callPayload.Queries["start"] = ExpressionConverter.Convert(start);
                if (end != null)
                    callPayload.Queries["end"] = ExpressionConverter.Convert(end);
                return new ApiConnectionAction<PageStatsMeasureRo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        [WorkflowExpressionFactory(nameof(__BuildGetStatsRepartition))]
        public IBodyWorkflowAction<StatsCountRo[]> GetStatsRepartition([WorkflowExpression] Func<string> attribute, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null, [WorkflowExpression] Func<string> sortValues = null, [WorkflowExpression] Func<string> sort = null, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<dirInput> dir = null, [WorkflowExpression] Func<string> orFilter = null, [WorkflowExpression] Func<int> start = null, [WorkflowExpression] Func<int> end = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<StatsCountRo[]> __BuildGetStatsRepartition(WorkflowExpression<string> attribute, WorkflowExpression<int> page = null, WorkflowExpression<int> pageSize = null, WorkflowExpression<string> sortValues = null, WorkflowExpression<string> sort = null, WorkflowExpression<string> filter = null, WorkflowExpression<dirInput> dir = null, WorkflowExpression<string> orFilter = null, WorkflowExpression<int> start = null, WorkflowExpression<int> end = null)
        {
            WorkflowExpression.Validate(attribute, nameof(attribute), required: true);
            WorkflowExpression.Validate(page, nameof(page), required: false);
            WorkflowExpression.Validate(pageSize, nameof(pageSize), required: false);
            WorkflowExpression.Validate(sortValues, nameof(sortValues), required: false);
            WorkflowExpression.Validate(sort, nameof(sort), required: false);
            WorkflowExpression.Validate(filter, nameof(filter), required: false);
            WorkflowExpression.Validate(dir, nameof(dir), required: false);
            WorkflowExpression.Validate(orFilter, nameof(orFilter), required: false);
            WorkflowExpression.Validate(start, nameof(start), required: false);
            WorkflowExpression.Validate(end, nameof(end), required: false);
            return new DeferredBodyAction<StatsCountRo[]>(() =>
            {
                var apiCallPath = "/stats/repartition";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["attribute"] = ExpressionConverter.Convert(attribute);
                if (page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(page);
                if (pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(pageSize);
                if (sortValues != null)
                    callPayload.Queries["sortValues"] = ExpressionConverter.Convert(sortValues);
                if (sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(sort);
                if (filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(filter);
                if (dir != null)
                    callPayload.Queries["dir"] = ExpressionConverter.Convert(dir);
                if (orFilter != null)
                    callPayload.Queries["orFilter"] = ExpressionConverter.Convert(orFilter);
                if (start != null)
                    callPayload.Queries["start"] = ExpressionConverter.Convert(start);
                if (end != null)
                    callPayload.Queries["end"] = ExpressionConverter.Convert(end);
                return new ApiConnectionAction<StatsCountRo[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        [WorkflowExpressionFactory(nameof(__BuildGetStatsSum))]
        public IBodyWorkflowAction<StatsGraphRo[]> GetStatsSum([WorkflowExpression] Func<int> start, [WorkflowExpression] Func<int> end, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null, [WorkflowExpression] Func<string> sortValues = null, [WorkflowExpression] Func<string> sort = null, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<dirInput> dir = null, [WorkflowExpression] Func<string> orFilter = null, [WorkflowExpression] Func<int> time = null, [WorkflowExpression] Func<string> interval = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<StatsGraphRo[]> __BuildGetStatsSum(WorkflowExpression<int> start, WorkflowExpression<int> end, WorkflowExpression<int> page = null, WorkflowExpression<int> pageSize = null, WorkflowExpression<string> sortValues = null, WorkflowExpression<string> sort = null, WorkflowExpression<string> filter = null, WorkflowExpression<dirInput> dir = null, WorkflowExpression<string> orFilter = null, WorkflowExpression<int> time = null, WorkflowExpression<string> interval = null)
        {
            WorkflowExpression.Validate(start, nameof(start), required: true);
            WorkflowExpression.Validate(end, nameof(end), required: true);
            WorkflowExpression.Validate(page, nameof(page), required: false);
            WorkflowExpression.Validate(pageSize, nameof(pageSize), required: false);
            WorkflowExpression.Validate(sortValues, nameof(sortValues), required: false);
            WorkflowExpression.Validate(sort, nameof(sort), required: false);
            WorkflowExpression.Validate(filter, nameof(filter), required: false);
            WorkflowExpression.Validate(dir, nameof(dir), required: false);
            WorkflowExpression.Validate(orFilter, nameof(orFilter), required: false);
            WorkflowExpression.Validate(time, nameof(time), required: false);
            WorkflowExpression.Validate(interval, nameof(interval), required: false);
            return new DeferredBodyAction<StatsGraphRo[]>(() =>
            {
                var apiCallPath = "/stats/sum";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(page);
                if (pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(pageSize);
                if (sortValues != null)
                    callPayload.Queries["sortValues"] = ExpressionConverter.Convert(sortValues);
                if (sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(sort);
                if (filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(filter);
                if (dir != null)
                    callPayload.Queries["dir"] = ExpressionConverter.Convert(dir);
                if (orFilter != null)
                    callPayload.Queries["orFilter"] = ExpressionConverter.Convert(orFilter);
                if (time != null)
                    callPayload.Queries["time"] = ExpressionConverter.Convert(time);
                if (interval != null)
                    callPayload.Queries["interval"] = ExpressionConverter.Convert(interval);
                callPayload.Queries["start"] = ExpressionConverter.Convert(start);
                callPayload.Queries["end"] = ExpressionConverter.Convert(end);
                return new ApiConnectionAction<StatsGraphRo[]>(callPayload);
            });
        }
    }

    public class PilotthingsTriggers([ConnectionName] string connectionId)
    {
    }

    public class PageAlertRo
    {
        [JsonProperty("data")]
        public AlertRo[] Data { get; set; }

        [JsonProperty("end")]
        public int End { get; set; }

        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("pageSize")]
        public int PageSize { get; set; }

        [JsonProperty("start")]
        public int Start { get; set; }

        [JsonProperty("totalSize")]
        public int TotalSize { get; set; }
    }

    public class AlertRo
    {
        [JsonProperty("comment")]
        public string Comment { get; set; }

        [JsonProperty("creationDate")]
        public int CreationDate { get; set; }

        [JsonProperty("flowOrigin")]
        public FlowTinyRo FlowOrigin { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("lastUpdate")]
        public int LastUpdate { get; set; }

        [JsonProperty("level")]
        public AlertRoLevelType Level { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("state")]
        public AlertRoStateType State { get; set; }

        [JsonProperty("thing")]
        public ThingTinyRo Thing { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }
    }

    public class FlowTinyRo
    {
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AlertRoLevelType
    {
        INFO,
        WARNING,
        CRITICAL
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AlertRoStateType
    {
        OPENED,
        IGNORED,
        [EnumMember(Value = "IN_PROGRESS")]
        INPROGRESS,
        RESOLVED
    }

    public class ThingTinyRo
    {
        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("fixedName")]
        public string FixedName { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("nbAlerts")]
        public int NbAlerts { get; set; }

        [JsonProperty("tags")]
        public ThingTagRo[] Tags { get; set; }
    }

    public class ThingTagRo
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("tag")]
        public string Tag { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum dirInput
    {
        ASC,
        DESC
    }

    public class PageMeasureRo
    {
        [JsonProperty("data")]
        public MeasureRo[] Data { get; set; }

        [JsonProperty("end")]
        public int End { get; set; }

        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("pageSize")]
        public int PageSize { get; set; }

        [JsonProperty("start")]
        public int Start { get; set; }

        [JsonProperty("totalSize")]
        public int TotalSize { get; set; }
    }

    public class MeasureRo
    {
        [JsonProperty("attribute")]
        public AttributeTinyRo Attribute { get; set; }

        [JsonProperty("dtype")]
        public string Dtype { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("model")]
        public ModelTinyRo Model { get; set; }

        [JsonProperty("product")]
        public ProductTinyRo Product { get; set; }

        [JsonProperty("thing")]
        public ThingTinyRo Thing { get; set; }

        [JsonProperty("timestamp")]
        public int Timestamp { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class AttributeTinyRo
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public QuantityKindRo Type { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }
    }

    public class QuantityKindRo
    {
        [JsonProperty("defaultUnit")]
        public string DefaultUnit { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ModelTinyRo
    {
        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("generateLinks")]
        public bool GenerateLinks { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("isCustomModel")]
        public bool IsCustomModel { get; set; }

        [JsonProperty("link")]
        public URI Link { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class URI
    {
        [JsonProperty("absolute")]
        public bool Absolute { get; set; }

        [JsonProperty("authority")]
        public string Authority { get; set; }

        [JsonProperty("fragment")]
        public string Fragment { get; set; }

        [JsonProperty("host")]
        public string Host { get; set; }

        [JsonProperty("opaque")]
        public bool Opaque { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("port")]
        public int Port { get; set; }

        [JsonProperty("query")]
        public string Query { get; set; }

        [JsonProperty("rawAuthority")]
        public string RawAuthority { get; set; }

        [JsonProperty("rawFragment")]
        public string RawFragment { get; set; }

        [JsonProperty("rawPath")]
        public string RawPath { get; set; }

        [JsonProperty("rawQuery")]
        public string RawQuery { get; set; }

        [JsonProperty("rawSchemeSpecificPart")]
        public string RawSchemeSpecificPart { get; set; }

        [JsonProperty("rawUserInfo")]
        public string RawUserInfo { get; set; }

        [JsonProperty("scheme")]
        public string Scheme { get; set; }

        [JsonProperty("schemeSpecificPart")]
        public string SchemeSpecificPart { get; set; }

        [JsonProperty("userInfo")]
        public string UserInfo { get; set; }
    }

    public class ProductTinyRo
    {
        [JsonProperty("connectivityTypes")]
        public ProductTinyRoConnectivityTypesTypeItem[] ConnectivityTypes { get; set; }

        [JsonProperty("generateLinks")]
        public bool GenerateLinks { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("manufacturer")]
        public ManufacturerTinyRo Manufacturer { get; set; }

        [JsonProperty("model")]
        public ModelTinyRo Model { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ProductTinyRoConnectivityTypesTypeItem
    {
        LORA,
        SIGFOX,
        MQTT,
        CELLULAR,
        ETHERNET,
        WIFI,
        BLUETOOTH,
        BACNET,
        MODBUS,
        [EnumMember(Value = "IO_ANALOG")]
        IOANALOG,
        [EnumMember(Value = "IO_DIGITAL")]
        IODIGITAL,
        ENOCEAN,
        ZIGBEE,
        ZWAVE,
        NFC,
        USB,
        [EnumMember(Value = "IEEE_LR_WPAN")]
        IEEELRWPAN,
        DALI,
        UNKNOWN
    }

    public class ManufacturerTinyRo
    {
        [JsonProperty("generateLinks")]
        public bool GenerateLinks { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class CountRo
    {
        [JsonProperty("count")]
        public int Count { get; set; }
    }

    public class PageMessageRo
    {
        [JsonProperty("data")]
        public MessageRo[] Data { get; set; }

        [JsonProperty("end")]
        public int End { get; set; }

        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("pageSize")]
        public int PageSize { get; set; }

        [JsonProperty("start")]
        public int Start { get; set; }

        [JsonProperty("totalSize")]
        public int TotalSize { get; set; }
    }

    public class MessageRo
    {
        [JsonProperty("body")]
        public string Body { get; set; }

        [JsonProperty("creationDate")]
        public string CreationDate { get; set; }

        [JsonProperty("errorMessage")]
        public string ErrorMessage { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("link")]
        public URI Link { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }

        [JsonProperty("measurements")]
        public JsonNode Measurements { get; set; }

        [JsonProperty("metadata")]
        public string Metadata { get; set; }

        [JsonProperty("number")]
        public int Number { get; set; }

        [JsonProperty("processed")]
        public MessageRoProcessedType Processed { get; set; }

        [JsonProperty("rawMeasurements")]
        public JsonNode RawMeasurements { get; set; }

        [JsonProperty("thing")]
        public ThingTinyRo Thing { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }

        [JsonProperty("topic")]
        public string Topic { get; set; }
    }

    public class JsonNode
    {
        [JsonProperty("array")]
        public bool Array { get; set; }

        [JsonProperty("bigDecimal")]
        public bool BigDecimal { get; set; }

        [JsonProperty("bigInteger")]
        public bool BigInteger { get; set; }

        [JsonProperty("binary")]
        public bool Binary { get; set; }

        [JsonProperty("boolean")]
        public bool Boolean { get; set; }

        [JsonProperty("containerNode")]
        public bool ContainerNode { get; set; }

        [JsonProperty("double")]
        public bool Double { get; set; }

        [JsonProperty("float")]
        public bool Float { get; set; }

        [JsonProperty("floatingPointNumber")]
        public bool FloatingPointNumber { get; set; }

        [JsonProperty("int")]
        public bool Int { get; set; }

        [JsonProperty("integralNumber")]
        public bool IntegralNumber { get; set; }

        [JsonProperty("long")]
        public bool Long { get; set; }

        [JsonProperty("missingNode")]
        public bool MissingNode { get; set; }

        [JsonProperty("nodeType")]
        public JsonNodeNodeTypeType NodeType { get; set; }

        [JsonProperty("null")]
        public bool Null { get; set; }

        [JsonProperty("number")]
        public bool Number { get; set; }

        [JsonProperty("object")]
        public bool ObjectEntity { get; set; }

        [JsonProperty("pojo")]
        public bool Pojo { get; set; }

        [JsonProperty("short")]
        public bool Short { get; set; }

        [JsonProperty("textual")]
        public bool Textual { get; set; }

        [JsonProperty("valueNode")]
        public bool ValueNode { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum JsonNodeNodeTypeType
    {
        ARRAY,
        BINARY,
        BOOLEAN,
        MISSING,
        NULL,
        NUMBER,
        [EnumMember(Value = "OBJECT")]
        ObjectEntity,
        POJO,
        STRING
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum MessageRoProcessedType
    {
        TODO,
        DONE,
        [EnumMember(Value = "IN_PROGRESS")]
        INPROGRESS,
        ASSOCIATED,
        [EnumMember(Value = "TO_BE_FORWARDED")]
        TOBEFORWARDED,
        [EnumMember(Value = "ERROR_CUSTOM")]
        ERRORCUSTOM,
        [EnumMember(Value = "TODO_CUSTOM")]
        TODOCUSTOM,
        ERROR
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum messageRoprocessedInput
    {
        TODO,
        DONE,
        [EnumMember(Value = "IN_PROGRESS")]
        INPROGRESS,
        ASSOCIATED,
        [EnumMember(Value = "TO_BE_FORWARDED")]
        TOBEFORWARDED,
        [EnumMember(Value = "ERROR_CUSTOM")]
        ERRORCUSTOM,
        [EnumMember(Value = "TODO_CUSTOM")]
        TODOCUSTOM,
        ERROR
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum messageRorawMeasurementsnodeTypeInput
    {
        ARRAY,
        BINARY,
        BOOLEAN,
        MISSING,
        NULL,
        NUMBER,
        [EnumMember(Value = "OBJECT")]
        ObjectEntity,
        POJO,
        STRING
    }

    public class PageSiteRo
    {
        [JsonProperty("data")]
        public SiteRo[] Data { get; set; }

        [JsonProperty("end")]
        public int End { get; set; }

        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("pageSize")]
        public int PageSize { get; set; }

        [JsonProperty("start")]
        public int Start { get; set; }

        [JsonProperty("totalSize")]
        public int TotalSize { get; set; }
    }

    public class SiteRo
    {
        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("postalCode")]
        public string PostalCode { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum nodenodeTypeInput
    {
        ARRAY,
        BINARY,
        BOOLEAN,
        MISSING,
        NULL,
        NUMBER,
        [EnumMember(Value = "OBJECT")]
        ObjectEntity,
        POJO,
        STRING
    }

    public class PageThingTagRo
    {
        [JsonProperty("data")]
        public ThingTagRo[] Data { get; set; }

        [JsonProperty("end")]
        public int End { get; set; }

        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("pageSize")]
        public int PageSize { get; set; }

        [JsonProperty("start")]
        public int Start { get; set; }

        [JsonProperty("totalSize")]
        public int TotalSize { get; set; }
    }

    public class TagRo
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("tag")]
        public string Tag { get; set; }
    }

    public class PageSingleThingRo
    {
        [JsonProperty("data")]
        public SingleThingRo[] Data { get; set; }

        [JsonProperty("end")]
        public int End { get; set; }

        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("pageSize")]
        public int PageSize { get; set; }

        [JsonProperty("start")]
        public int Start { get; set; }

        [JsonProperty("totalSize")]
        public int TotalSize { get; set; }
    }

    public class SingleThingRo
    {
        [JsonProperty("application")]
        public ApplicationTinyRo Application { get; set; }

        [JsonProperty("connectivity")]
        public ConnectivityRo Connectivity { get; set; }

        [JsonProperty("customFields")]
        public CustomFieldRo[] CustomFields { get; set; }

        [JsonProperty("customModel")]
        public CustomModelTinyRo CustomModel { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("device")]
        public DeviceRo Device { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("dynamicGps")]
        public bool DynamicGps { get; set; }

        [JsonProperty("fixedLatitude")]
        public double FixedLatitude { get; set; }

        [JsonProperty("fixedLongitude")]
        public double FixedLongitude { get; set; }

        [JsonProperty("fixedName")]
        public string FixedName { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("lastActivityDate")]
        public int LastActivityDate { get; set; }

        [JsonProperty("lastLatitude")]
        public double LastLatitude { get; set; }

        [JsonProperty("lastLongitude")]
        public double LastLongitude { get; set; }

        [JsonProperty("lastMeasurements")]
        public JsonNode LastMeasurements { get; set; }

        [JsonProperty("lastMeasurementsTimestamps")]
        public JsonNode LastMeasurementsTimestamps { get; set; }

        [JsonProperty("lastMessageDate")]
        public int LastMessageDate { get; set; }

        [JsonProperty("messageActivityTimeoutPeriod")]
        public int MessageActivityTimeoutPeriod { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("nbAlerts")]
        public int NbAlerts { get; set; }

        [JsonProperty("product")]
        public ProductTinyRo Product { get; set; }

        [JsonProperty("site")]
        public SiteRo Site { get; set; }

        [JsonProperty("sourceId")]
        public string SourceId { get; set; }

        [JsonProperty("status")]
        public SingleThingRoStatusType Status { get; set; }

        [JsonProperty("tags")]
        public ThingTagRo[] Tags { get; set; }
    }

    public class ApplicationTinyRo
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class ConnectivityRo
    {
        [JsonProperty("additionalProperties")]
        public JToken AdditionalProperties { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("rawStatus")]
        public string RawStatus { get; set; }

        [JsonProperty("status")]
        public ConnectivityRoStatusType Status { get; set; }

        [JsonProperty("type")]
        public ConnectivityRoTypeType Type { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ConnectivityRoStatusType
    {
        INACTIVE,
        ONLINE,
        OFFLINE,
        ERROR,
        UNKNOWN
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ConnectivityRoTypeType
    {
        LORA,
        SIGFOX,
        MQTT,
        CELLULAR,
        ETHERNET,
        WIFI,
        BLUETOOTH,
        BACNET,
        MODBUS,
        [EnumMember(Value = "IO_ANALOG")]
        IOANALOG,
        [EnumMember(Value = "IO_DIGITAL")]
        IODIGITAL,
        ENOCEAN,
        ZIGBEE,
        ZWAVE,
        NFC,
        USB,
        [EnumMember(Value = "IEEE_LR_WPAN")]
        IEEELRWPAN,
        DALI,
        UNKNOWN
    }

    public class CustomFieldRo
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("imageLink")]
        public string ImageLink { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public CustomFieldRoTypeType Type { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CustomFieldRoTypeType
    {
        TEXT,
        TEXTEREA,
        FILE
    }

    public class CustomModelTinyRo
    {
        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class DeviceRo
    {
        [JsonProperty("batteryLevel")]
        public int BatteryLevel { get; set; }

        [JsonProperty("batteryStatus")]
        public DeviceRoBatteryStatusType BatteryStatus { get; set; }

        [JsonProperty("deviceType")]
        public string DeviceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("manufacturer")]
        public string Manufacturer { get; set; }

        [JsonProperty("memoryFree")]
        public int MemoryFree { get; set; }

        [JsonProperty("memoryTotal")]
        public int MemoryTotal { get; set; }

        [JsonProperty("model")]
        public string Model { get; set; }

        [JsonProperty("modelNumber")]
        public string ModelNumber { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("serialNumber")]
        public string SerialNumber { get; set; }

        [JsonProperty("status")]
        public DeviceRoStatusType Status { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum DeviceRoBatteryStatusType
    {
        NORMAL,
        CHARGING,
        [EnumMember(Value = "CHARGE_COMPLETE")]
        CHARGECOMPLETE,
        DAMAGED,
        [EnumMember(Value = "LOW_BATTERY")]
        LOWBATTERY,
        [EnumMember(Value = "NOT_INSTALLED")]
        NOTINSTALLED,
        UNKNOWN
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum DeviceRoStatusType
    {
        RUNNING,
        HALTED,
        ERROR,
        UNKNOWN
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SingleThingRoStatusType
    {
        PROVISIONED,
        PENDING,
        INACTIVE,
        ACTIVE,
        WARNING,
        SUSPENDED,
        DELETED,
        [EnumMember(Value = "IN_ASSOCIATION")]
        INASSOCIATION,
        [EnumMember(Value = "IN_DISSOCIATION")]
        INDISSOCIATION,
        [EnumMember(Value = "OUT_OF_ORDER")]
        OUTOFORDER,
        CREATED,
        VIRTUAL
    }

    public class ResponseEntity
    {
        [JsonProperty("body")]
        public JToken Body { get; set; }

        [JsonProperty("statusCode")]
        public ResponseEntityStatusCodeType StatusCode { get; set; }

        [JsonProperty("statusCodeValue")]
        public int StatusCodeValue { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ResponseEntityStatusCodeType
    {
        [EnumMember(Value = "100")]
        _100,
        [EnumMember(Value = "101")]
        _101,
        [EnumMember(Value = "102")]
        _102,
        [EnumMember(Value = "103")]
        _103,
        [EnumMember(Value = "200")]
        _200,
        [EnumMember(Value = "201")]
        _201,
        [EnumMember(Value = "202")]
        _202,
        [EnumMember(Value = "203")]
        _203,
        [EnumMember(Value = "204")]
        _204,
        [EnumMember(Value = "205")]
        _205,
        [EnumMember(Value = "206")]
        _206,
        [EnumMember(Value = "207")]
        _207,
        [EnumMember(Value = "208")]
        _208,
        [EnumMember(Value = "226")]
        _226,
        [EnumMember(Value = "300")]
        _300,
        [EnumMember(Value = "301")]
        _301,
        [EnumMember(Value = "302")]
        _302,
        [EnumMember(Value = "303")]
        _303,
        [EnumMember(Value = "304")]
        _304,
        [EnumMember(Value = "305")]
        _305,
        [EnumMember(Value = "307")]
        _307,
        [EnumMember(Value = "308")]
        _308,
        [EnumMember(Value = "400")]
        _400,
        [EnumMember(Value = "401")]
        _401,
        [EnumMember(Value = "402")]
        _402,
        [EnumMember(Value = "403")]
        _403,
        [EnumMember(Value = "404")]
        _404,
        [EnumMember(Value = "405")]
        _405,
        [EnumMember(Value = "406")]
        _406,
        [EnumMember(Value = "407")]
        _407,
        [EnumMember(Value = "408")]
        _408,
        [EnumMember(Value = "409")]
        _409,
        [EnumMember(Value = "410")]
        _410,
        [EnumMember(Value = "411")]
        _411,
        [EnumMember(Value = "412")]
        _412,
        [EnumMember(Value = "413")]
        _413,
        [EnumMember(Value = "414")]
        _414,
        [EnumMember(Value = "415")]
        _415,
        [EnumMember(Value = "416")]
        _416,
        [EnumMember(Value = "417")]
        _417,
        [EnumMember(Value = "418")]
        _418,
        [EnumMember(Value = "419")]
        _419,
        [EnumMember(Value = "420")]
        _420,
        [EnumMember(Value = "421")]
        _421,
        [EnumMember(Value = "422")]
        _422,
        [EnumMember(Value = "423")]
        _423,
        [EnumMember(Value = "424")]
        _424,
        [EnumMember(Value = "426")]
        _426,
        [EnumMember(Value = "428")]
        _428,
        [EnumMember(Value = "429")]
        _429,
        [EnumMember(Value = "431")]
        _431,
        [EnumMember(Value = "451")]
        _451,
        [EnumMember(Value = "500")]
        _500,
        [EnumMember(Value = "501")]
        _501,
        [EnumMember(Value = "502")]
        _502,
        [EnumMember(Value = "503")]
        _503,
        [EnumMember(Value = "504")]
        _504,
        [EnumMember(Value = "505")]
        _505,
        [EnumMember(Value = "506")]
        _506,
        [EnumMember(Value = "507")]
        _507,
        [EnumMember(Value = "508")]
        _508,
        [EnumMember(Value = "509")]
        _509,
        [EnumMember(Value = "510")]
        _510,
        [EnumMember(Value = "511")]
        _511
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum jsonnodeTypeInput
    {
        ARRAY,
        BINARY,
        BOOLEAN,
        MISSING,
        NULL,
        NUMBER,
        [EnumMember(Value = "OBJECT")]
        ObjectEntity,
        POJO,
        STRING
    }

    public class ThingRo
    {
        [JsonProperty("customFields")]
        public CustomFieldRo[] CustomFields { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("dynamicGps")]
        public bool DynamicGps { get; set; }

        [JsonProperty("fixedLatitude")]
        public double FixedLatitude { get; set; }

        [JsonProperty("fixedLongitude")]
        public double FixedLongitude { get; set; }

        [JsonProperty("fixedName")]
        public string FixedName { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("lastActivityDate")]
        public int LastActivityDate { get; set; }

        [JsonProperty("lastLatitude")]
        public double LastLatitude { get; set; }

        [JsonProperty("lastLongitude")]
        public double LastLongitude { get; set; }

        [JsonProperty("lastMeasurements")]
        public JsonNode LastMeasurements { get; set; }

        [JsonProperty("lastMeasurementsTimestamps")]
        public JsonNode LastMeasurementsTimestamps { get; set; }

        [JsonProperty("lastMessageDate")]
        public int LastMessageDate { get; set; }

        [JsonProperty("messageActivityTimeoutPeriod")]
        public int MessageActivityTimeoutPeriod { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("nbAlerts")]
        public int NbAlerts { get; set; }

        [JsonProperty("site")]
        public SiteRo Site { get; set; }

        [JsonProperty("status")]
        public ThingRoStatusType Status { get; set; }

        [JsonProperty("tags")]
        public ThingTagRo[] Tags { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ThingRoStatusType
    {
        PROVISIONED,
        PENDING,
        INACTIVE,
        ACTIVE,
        WARNING,
        SUSPENDED,
        DELETED,
        [EnumMember(Value = "IN_ASSOCIATION")]
        INASSOCIATION,
        [EnumMember(Value = "IN_DISSOCIATION")]
        INDISSOCIATION,
        [EnumMember(Value = "OUT_OF_ORDER")]
        OUTOFORDER,
        CREATED,
        VIRTUAL
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum thingRoconnectivitystatusInput
    {
        INACTIVE,
        ONLINE,
        OFFLINE,
        ERROR,
        UNKNOWN
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum thingRoconnectivitytypeInput
    {
        LORA,
        SIGFOX,
        MQTT,
        CELLULAR,
        ETHERNET,
        WIFI,
        BLUETOOTH,
        BACNET,
        MODBUS,
        [EnumMember(Value = "IO_ANALOG")]
        IOANALOG,
        [EnumMember(Value = "IO_DIGITAL")]
        IODIGITAL,
        ENOCEAN,
        ZIGBEE,
        ZWAVE,
        NFC,
        USB,
        [EnumMember(Value = "IEEE_LR_WPAN")]
        IEEELRWPAN,
        DALI,
        UNKNOWN
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum thingRodevicebatteryStatusInput
    {
        NORMAL,
        CHARGING,
        [EnumMember(Value = "CHARGE_COMPLETE")]
        CHARGECOMPLETE,
        DAMAGED,
        [EnumMember(Value = "LOW_BATTERY")]
        LOWBATTERY,
        [EnumMember(Value = "NOT_INSTALLED")]
        NOTINSTALLED,
        UNKNOWN
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum thingRodevicestatusInput
    {
        RUNNING,
        HALTED,
        ERROR,
        UNKNOWN
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum thingRolastMeasurementsnodeTypeInput
    {
        ARRAY,
        BINARY,
        BOOLEAN,
        MISSING,
        NULL,
        NUMBER,
        [EnumMember(Value = "OBJECT")]
        ObjectEntity,
        POJO,
        STRING
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum thingRolastMeasurementsTimestampsnodeTypeInput
    {
        ARRAY,
        BINARY,
        BOOLEAN,
        MISSING,
        NULL,
        NUMBER,
        [EnumMember(Value = "OBJECT")]
        ObjectEntity,
        POJO,
        STRING
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum thingRoproductconnectivityTypesInputItem
    {
        LORA,
        SIGFOX,
        MQTT,
        CELLULAR,
        ETHERNET,
        WIFI,
        BLUETOOTH,
        BACNET,
        MODBUS,
        [EnumMember(Value = "IO_ANALOG")]
        IOANALOG,
        [EnumMember(Value = "IO_DIGITAL")]
        IODIGITAL,
        ENOCEAN,
        ZIGBEE,
        ZWAVE,
        NFC,
        USB,
        [EnumMember(Value = "IEEE_LR_WPAN")]
        IEEELRWPAN,
        DALI,
        UNKNOWN
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum thingRostatusInput
    {
        PROVISIONED,
        PENDING,
        INACTIVE,
        ACTIVE,
        WARNING,
        SUSPENDED,
        DELETED,
        [EnumMember(Value = "IN_ASSOCIATION")]
        INASSOCIATION,
        [EnumMember(Value = "IN_DISSOCIATION")]
        INDISSOCIATION,
        [EnumMember(Value = "OUT_OF_ORDER")]
        OUTOFORDER,
        CREATED,
        VIRTUAL
    }

    public class ModelRo
    {
        [JsonProperty("attributes")]
        public AttributeRo[] Attributes { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("isCustomModel")]
        public bool IsCustomModel { get; set; }

        [JsonProperty("link")]
        public URI Link { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("operations")]
        public OperationRo[] Operations { get; set; }
    }

    public class AttributeRo
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public QuantityKindRo Type { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }
    }

    public class OperationRo
    {
        [JsonProperty("args")]
        public string Args { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class PageCustomFieldRo
    {
        [JsonProperty("data")]
        public PageCustomFieldRo[] Data { get; set; }

        [JsonProperty("end")]
        public int End { get; set; }

        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("pageSize")]
        public int PageSize { get; set; }

        [JsonProperty("start")]
        public int Start { get; set; }

        [JsonProperty("totalSize")]
        public int TotalSize { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum customFieldRotypeInput
    {
        TEXT,
        TEXTEREA,
        FILE
    }

    public class MeasureTinyRo
    {
        [JsonProperty("attribute")]
        public AttributeTinyRo Attribute { get; set; }

        [JsonProperty("dtype")]
        public string Dtype { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("timestamp")]
        public int Timestamp { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class MessageTinyRo
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("link")]
        public URI Link { get; set; }

        [JsonProperty("number")]
        public int Number { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum messageRomeasurementsnodeTypeInput
    {
        ARRAY,
        BINARY,
        BOOLEAN,
        MISSING,
        NULL,
        NUMBER,
        [EnumMember(Value = "OBJECT")]
        ObjectEntity,
        POJO,
        STRING
    }

    public class PageOperationRo
    {
        [JsonProperty("data")]
        public OperationRo[] Data { get; set; }

        [JsonProperty("end")]
        public int End { get; set; }

        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("pageSize")]
        public int PageSize { get; set; }

        [JsonProperty("start")]
        public int Start { get; set; }

        [JsonProperty("totalSize")]
        public int TotalSize { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum placeholdersValuesnodeTypeInput
    {
        ARRAY,
        BINARY,
        BOOLEAN,
        MISSING,
        NULL,
        NUMBER,
        [EnumMember(Value = "OBJECT")]
        ObjectEntity,
        POJO,
        STRING
    }

    public class ProductRo
    {
        [JsonProperty("certification")]
        public string Certification { get; set; }

        [JsonProperty("connectivityTypes")]
        public ProductRoConnectivityTypesTypeItem[] ConnectivityTypes { get; set; }

        [JsonProperty("decoder")]
        public DecoderTinyRo Decoder { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("encoder")]
        public EncoderTinyRo Encoder { get; set; }

        [JsonProperty("generateLinks")]
        public bool GenerateLinks { get; set; }

        [JsonProperty("hasImage")]
        public bool HasImage { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("imageLink")]
        public string ImageLink { get; set; }

        [JsonProperty("infoLink")]
        public string InfoLink { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("manufacturer")]
        public ManufacturerTinyRo Manufacturer { get; set; }

        [JsonProperty("manufacturerCategory")]
        public string ManufacturerCategory { get; set; }

        [JsonProperty("model")]
        public ModelTinyRo Model { get; set; }

        [JsonProperty("modelManufacturer")]
        public ManufacturerTinyRo ModelManufacturer { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("readOnly")]
        public bool ReadOnly { get; set; }

        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("tags")]
        public TagRo[] Tags { get; set; }

        [JsonProperty("things")]
        public ThingTinyRo[] Things { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ProductRoConnectivityTypesTypeItem
    {
        LORA,
        SIGFOX,
        MQTT,
        CELLULAR,
        ETHERNET,
        WIFI,
        BLUETOOTH,
        BACNET,
        MODBUS,
        [EnumMember(Value = "IO_ANALOG")]
        IOANALOG,
        [EnumMember(Value = "IO_DIGITAL")]
        IODIGITAL,
        ENOCEAN,
        ZIGBEE,
        ZWAVE,
        NFC,
        USB,
        [EnumMember(Value = "IEEE_LR_WPAN")]
        IEEELRWPAN,
        DALI,
        UNKNOWN
    }

    public class DecoderTinyRo
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("visible")]
        public bool Visible { get; set; }
    }

    public class EncoderTinyRo
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum productconnectivityTypesInputItem
    {
        LORA,
        SIGFOX,
        MQTT,
        CELLULAR,
        ETHERNET,
        WIFI,
        BLUETOOTH,
        BACNET,
        MODBUS,
        [EnumMember(Value = "IO_ANALOG")]
        IOANALOG,
        [EnumMember(Value = "IO_DIGITAL")]
        IODIGITAL,
        ENOCEAN,
        ZIGBEE,
        ZWAVE,
        NFC,
        USB,
        [EnumMember(Value = "IEEE_LR_WPAN")]
        IEEELRWPAN,
        DALI,
        UNKNOWN
    }

    public class PageFlowRo
    {
        [JsonProperty("data")]
        public PageFlowRo[] Data { get; set; }

        [JsonProperty("end")]
        public int End { get; set; }

        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("pageSize")]
        public int PageSize { get; set; }

        [JsonProperty("start")]
        public int Start { get; set; }

        [JsonProperty("totalSize")]
        public int TotalSize { get; set; }
    }

    public class PageStatsMeasureRo
    {
        [JsonProperty("data")]
        public StatsMeasureRo[] Data { get; set; }

        [JsonProperty("end")]
        public int End { get; set; }

        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("pageSize")]
        public int PageSize { get; set; }

        [JsonProperty("start")]
        public int Start { get; set; }

        [JsonProperty("totalSize")]
        public int TotalSize { get; set; }
    }

    public class StatsMeasureRo
    {
        [JsonProperty("attribute")]
        public AttributeRo Attribute { get; set; }

        [JsonProperty("timestamp")]
        public int Timestamp { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class StatsCountRo
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class StatsGraphRo
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("end")]
        public int End { get; set; }

        [JsonProperty("last")]
        public int Last { get; set; }

        [JsonProperty("max")]
        public double Max { get; set; }

        [JsonProperty("min")]
        public double Min { get; set; }

        [JsonProperty("start")]
        public int Start { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("value")]
        public double Value { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Pilotthings;

    public partial class WorkflowManagedActions
    {
        public PilotthingsActions Pilotthings(string connectionId) => new PilotthingsActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public PilotthingsTriggers Pilotthings(string connectionId) => new PilotthingsTriggers(connectionId);
    }
}