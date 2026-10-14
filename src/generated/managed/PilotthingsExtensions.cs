//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Pilotthings
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class PilotthingsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<PageAlertRo> GetAlerts(Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null, Expression<Func<string>> sortValues = null, Expression<Func<string>> sort = null, Expression<Func<string>> filter = null, Expression<Func<dirInput>> dir = null, Expression<Func<string>> orFilter = null, Expression<Func<int>> dateStart = null, Expression<Func<int>> dateEnd = null)
        {
            var __workflow_page = page == null ? null : WorkflowExpression.Compile(page);
            WorkflowExpression.Validate(__workflow_page, nameof(page), required: false);
            var __workflow_pageSize = pageSize == null ? null : WorkflowExpression.Compile(pageSize);
            WorkflowExpression.Validate(__workflow_pageSize, nameof(pageSize), required: false);
            var __workflow_sortValues = sortValues == null ? null : WorkflowExpression.Compile(sortValues);
            WorkflowExpression.Validate(__workflow_sortValues, nameof(sortValues), required: false);
            var __workflow_sort = sort == null ? null : WorkflowExpression.Compile(sort);
            WorkflowExpression.Validate(__workflow_sort, nameof(sort), required: false);
            var __workflow_filter = filter == null ? null : WorkflowExpression.Compile(filter);
            WorkflowExpression.Validate(__workflow_filter, nameof(filter), required: false);
            var __workflow_dir = dir == null ? null : WorkflowExpression.Compile(dir);
            WorkflowExpression.Validate(__workflow_dir, nameof(dir), required: false);
            var __workflow_orFilter = orFilter == null ? null : WorkflowExpression.Compile(orFilter);
            WorkflowExpression.Validate(__workflow_orFilter, nameof(orFilter), required: false);
            var __workflow_dateStart = dateStart == null ? null : WorkflowExpression.Compile(dateStart);
            WorkflowExpression.Validate(__workflow_dateStart, nameof(dateStart), required: false);
            var __workflow_dateEnd = dateEnd == null ? null : WorkflowExpression.Compile(dateEnd);
            WorkflowExpression.Validate(__workflow_dateEnd, nameof(dateEnd), required: false);
            return new DeferredBodyAction<PageAlertRo>(() =>
            {
                var apiCallPath = "/api/alerts";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(__workflow_pageSize);
                if (__workflow_sortValues != null)
                    callPayload.Queries["sortValues"] = ExpressionConverter.Convert(__workflow_sortValues);
                if (__workflow_sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(__workflow_sort);
                if (__workflow_filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_dir != null)
                    callPayload.Queries["dir"] = ExpressionConverter.Convert(__workflow_dir);
                if (__workflow_orFilter != null)
                    callPayload.Queries["orFilter"] = ExpressionConverter.Convert(__workflow_orFilter);
                callPayload.Queries["dateStart"] = Convert.ToString(0);
                if (__workflow_dateStart != null)
                    callPayload.Queries["dateStart"] = ExpressionConverter.Convert(__workflow_dateStart);
                callPayload.Queries["dateEnd"] = Convert.ToString(0);
                if (__workflow_dateEnd != null)
                    callPayload.Queries["dateEnd"] = ExpressionConverter.Convert(__workflow_dateEnd);
                return new ApiConnectionAction<PageAlertRo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<AlertRo> UpdateAlertState(Expression<Func<string>> id, Expression<Func<string>> paramJson = null)
        {
            var __workflow_id = id == null ? null : WorkflowExpression.Compile(id);
            WorkflowExpression.Validate(__workflow_id, nameof(id), required: true);
            var __workflow_paramJson = paramJson == null ? null : WorkflowExpression.Compile(paramJson);
            WorkflowExpression.Validate(__workflow_paramJson, nameof(paramJson), required: false);
            return new DeferredBodyAction<AlertRo>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/alerts/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_paramJson);
                return new ApiConnectionAction<AlertRo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<PageMeasureRo> GetMeasures(Expression<Func<bool>> detailed = null, Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null, Expression<Func<string>> sortValues = null, Expression<Func<string>> sort = null, Expression<Func<string>> filter = null, Expression<Func<dirInput>> dir = null, Expression<Func<string>> orFilter = null)
        {
            var __workflow_detailed = detailed == null ? null : WorkflowExpression.Compile(detailed);
            WorkflowExpression.Validate(__workflow_detailed, nameof(detailed), required: false);
            var __workflow_page = page == null ? null : WorkflowExpression.Compile(page);
            WorkflowExpression.Validate(__workflow_page, nameof(page), required: false);
            var __workflow_pageSize = pageSize == null ? null : WorkflowExpression.Compile(pageSize);
            WorkflowExpression.Validate(__workflow_pageSize, nameof(pageSize), required: false);
            var __workflow_sortValues = sortValues == null ? null : WorkflowExpression.Compile(sortValues);
            WorkflowExpression.Validate(__workflow_sortValues, nameof(sortValues), required: false);
            var __workflow_sort = sort == null ? null : WorkflowExpression.Compile(sort);
            WorkflowExpression.Validate(__workflow_sort, nameof(sort), required: false);
            var __workflow_filter = filter == null ? null : WorkflowExpression.Compile(filter);
            WorkflowExpression.Validate(__workflow_filter, nameof(filter), required: false);
            var __workflow_dir = dir == null ? null : WorkflowExpression.Compile(dir);
            WorkflowExpression.Validate(__workflow_dir, nameof(dir), required: false);
            var __workflow_orFilter = orFilter == null ? null : WorkflowExpression.Compile(orFilter);
            WorkflowExpression.Validate(__workflow_orFilter, nameof(orFilter), required: false);
            return new DeferredBodyAction<PageMeasureRo>(() =>
            {
                var apiCallPath = "/api/measures";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["detailed"] = Convert.ToString(false);
                if (__workflow_detailed != null)
                    callPayload.Queries["detailed"] = ExpressionConverter.Convert(__workflow_detailed);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(__workflow_pageSize);
                if (__workflow_sortValues != null)
                    callPayload.Queries["sortValues"] = ExpressionConverter.Convert(__workflow_sortValues);
                if (__workflow_sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(__workflow_sort);
                if (__workflow_filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_dir != null)
                    callPayload.Queries["dir"] = ExpressionConverter.Convert(__workflow_dir);
                if (__workflow_orFilter != null)
                    callPayload.Queries["orFilter"] = ExpressionConverter.Convert(__workflow_orFilter);
                return new ApiConnectionAction<PageMeasureRo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<CountRo> GetCount(Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null, Expression<Func<string>> sortValues = null, Expression<Func<string>> sort = null, Expression<Func<string>> filter = null, Expression<Func<dirInput>> dir = null, Expression<Func<string>> orFilter = null)
        {
            var __workflow_page = page == null ? null : WorkflowExpression.Compile(page);
            WorkflowExpression.Validate(__workflow_page, nameof(page), required: false);
            var __workflow_pageSize = pageSize == null ? null : WorkflowExpression.Compile(pageSize);
            WorkflowExpression.Validate(__workflow_pageSize, nameof(pageSize), required: false);
            var __workflow_sortValues = sortValues == null ? null : WorkflowExpression.Compile(sortValues);
            WorkflowExpression.Validate(__workflow_sortValues, nameof(sortValues), required: false);
            var __workflow_sort = sort == null ? null : WorkflowExpression.Compile(sort);
            WorkflowExpression.Validate(__workflow_sort, nameof(sort), required: false);
            var __workflow_filter = filter == null ? null : WorkflowExpression.Compile(filter);
            WorkflowExpression.Validate(__workflow_filter, nameof(filter), required: false);
            var __workflow_dir = dir == null ? null : WorkflowExpression.Compile(dir);
            WorkflowExpression.Validate(__workflow_dir, nameof(dir), required: false);
            var __workflow_orFilter = orFilter == null ? null : WorkflowExpression.Compile(orFilter);
            WorkflowExpression.Validate(__workflow_orFilter, nameof(orFilter), required: false);
            return new DeferredBodyAction<CountRo>(() =>
            {
                var apiCallPath = "/api/measures/count";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(__workflow_pageSize);
                if (__workflow_sortValues != null)
                    callPayload.Queries["sortValues"] = ExpressionConverter.Convert(__workflow_sortValues);
                if (__workflow_sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(__workflow_sort);
                if (__workflow_filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_dir != null)
                    callPayload.Queries["dir"] = ExpressionConverter.Convert(__workflow_dir);
                if (__workflow_orFilter != null)
                    callPayload.Queries["orFilter"] = ExpressionConverter.Convert(__workflow_orFilter);
                return new ApiConnectionAction<CountRo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<MeasureRo> GetMeasure(Expression<Func<string>> id, Expression<Func<bool>> detailed = null)
        {
            var __workflow_id = id == null ? null : WorkflowExpression.Compile(id);
            WorkflowExpression.Validate(__workflow_id, nameof(id), required: true);
            var __workflow_detailed = detailed == null ? null : WorkflowExpression.Compile(detailed);
            WorkflowExpression.Validate(__workflow_detailed, nameof(detailed), required: false);
            return new DeferredBodyAction<MeasureRo>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/measures/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["detailed"] = Convert.ToString(false);
                if (__workflow_detailed != null)
                    callPayload.Queries["detailed"] = ExpressionConverter.Convert(__workflow_detailed);
                return new ApiConnectionAction<MeasureRo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<PageMessageRo> GetMessages(Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null, Expression<Func<string>> sortValues = null, Expression<Func<string>> sort = null, Expression<Func<string>> filter = null, Expression<Func<dirInput>> dir = null, Expression<Func<string>> orFilter = null)
        {
            var __workflow_page = page == null ? null : WorkflowExpression.Compile(page);
            WorkflowExpression.Validate(__workflow_page, nameof(page), required: false);
            var __workflow_pageSize = pageSize == null ? null : WorkflowExpression.Compile(pageSize);
            WorkflowExpression.Validate(__workflow_pageSize, nameof(pageSize), required: false);
            var __workflow_sortValues = sortValues == null ? null : WorkflowExpression.Compile(sortValues);
            WorkflowExpression.Validate(__workflow_sortValues, nameof(sortValues), required: false);
            var __workflow_sort = sort == null ? null : WorkflowExpression.Compile(sort);
            WorkflowExpression.Validate(__workflow_sort, nameof(sort), required: false);
            var __workflow_filter = filter == null ? null : WorkflowExpression.Compile(filter);
            WorkflowExpression.Validate(__workflow_filter, nameof(filter), required: false);
            var __workflow_dir = dir == null ? null : WorkflowExpression.Compile(dir);
            WorkflowExpression.Validate(__workflow_dir, nameof(dir), required: false);
            var __workflow_orFilter = orFilter == null ? null : WorkflowExpression.Compile(orFilter);
            WorkflowExpression.Validate(__workflow_orFilter, nameof(orFilter), required: false);
            return new DeferredBodyAction<PageMessageRo>(() =>
            {
                var apiCallPath = "/api/messages";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(__workflow_pageSize);
                if (__workflow_sortValues != null)
                    callPayload.Queries["sortValues"] = ExpressionConverter.Convert(__workflow_sortValues);
                if (__workflow_sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(__workflow_sort);
                if (__workflow_filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_dir != null)
                    callPayload.Queries["dir"] = ExpressionConverter.Convert(__workflow_dir);
                if (__workflow_orFilter != null)
                    callPayload.Queries["orFilter"] = ExpressionConverter.Convert(__workflow_orFilter);
                return new ApiConnectionAction<PageMessageRo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<PageMessageRo> GetMessagesAndMeasurements(Expression<Func<string>> thingId, Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null, Expression<Func<string>> sortValues = null, Expression<Func<string>> sort = null, Expression<Func<string>> filter = null, Expression<Func<dirInput>> dir = null, Expression<Func<string>> orFilter = null)
        {
            var __workflow_thingId = thingId == null ? null : WorkflowExpression.Compile(thingId);
            WorkflowExpression.Validate(__workflow_thingId, nameof(thingId), required: true);
            var __workflow_page = page == null ? null : WorkflowExpression.Compile(page);
            WorkflowExpression.Validate(__workflow_page, nameof(page), required: false);
            var __workflow_pageSize = pageSize == null ? null : WorkflowExpression.Compile(pageSize);
            WorkflowExpression.Validate(__workflow_pageSize, nameof(pageSize), required: false);
            var __workflow_sortValues = sortValues == null ? null : WorkflowExpression.Compile(sortValues);
            WorkflowExpression.Validate(__workflow_sortValues, nameof(sortValues), required: false);
            var __workflow_sort = sort == null ? null : WorkflowExpression.Compile(sort);
            WorkflowExpression.Validate(__workflow_sort, nameof(sort), required: false);
            var __workflow_filter = filter == null ? null : WorkflowExpression.Compile(filter);
            WorkflowExpression.Validate(__workflow_filter, nameof(filter), required: false);
            var __workflow_dir = dir == null ? null : WorkflowExpression.Compile(dir);
            WorkflowExpression.Validate(__workflow_dir, nameof(dir), required: false);
            var __workflow_orFilter = orFilter == null ? null : WorkflowExpression.Compile(orFilter);
            WorkflowExpression.Validate(__workflow_orFilter, nameof(orFilter), required: false);
            return new DeferredBodyAction<PageMessageRo>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/messages/things/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_thingId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(__workflow_pageSize);
                if (__workflow_sortValues != null)
                    callPayload.Queries["sortValues"] = ExpressionConverter.Convert(__workflow_sortValues);
                if (__workflow_sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(__workflow_sort);
                if (__workflow_filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_dir != null)
                    callPayload.Queries["dir"] = ExpressionConverter.Convert(__workflow_dir);
                if (__workflow_orFilter != null)
                    callPayload.Queries["orFilter"] = ExpressionConverter.Convert(__workflow_orFilter);
                return new ApiConnectionAction<PageMessageRo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<MessageRo> AddMessage(Expression<Func<string>> thingId, Expression<Func<string>> messageRobody, Expression<Func<string>> messageRocreationDate, Expression<Func<string>> messageRoerrorMessage, Expression<Func<double>> messageRolatitude, Expression<Func<double>> messageRolongitude, Expression<Func<string>> messageRometadata, Expression<Func<int>> messageRonumber, Expression<Func<messageRoprocessedInput>> messageRoprocessed, Expression<Func<string>> messageRothingname, Expression<Func<string>> messageRotimestamp, Expression<Func<string>> messageRotopic, Expression<Func<string>> messageRoid = null, Expression<Func<bool>> messageRolinkabsolute = null, Expression<Func<string>> messageRolinkauthority = null, Expression<Func<string>> messageRolinkfragment = null, Expression<Func<string>> messageRolinkhost = null, Expression<Func<bool>> messageRolinkopaque = null, Expression<Func<string>> messageRolinkpath = null, Expression<Func<int>> messageRolinkport = null, Expression<Func<string>> messageRolinkquery = null, Expression<Func<string>> messageRolinkrawAuthority = null, Expression<Func<string>> messageRolinkrawFragment = null, Expression<Func<string>> messageRolinkrawPath = null, Expression<Func<string>> messageRolinkrawQuery = null, Expression<Func<string>> messageRolinkrawSchemeSpecificPart = null, Expression<Func<string>> messageRolinkrawUserInfo = null, Expression<Func<string>> messageRolinkscheme = null, Expression<Func<string>> messageRolinkschemeSpecificPart = null, Expression<Func<string>> messageRolinkuserInfo = null, Expression<Func<bool>> messageRorawMeasurementsarray = null, Expression<Func<bool>> messageRorawMeasurementsbigDecimal = null, Expression<Func<bool>> messageRorawMeasurementsbigInteger = null, Expression<Func<bool>> messageRorawMeasurementsbinary = null, Expression<Func<bool>> messageRorawMeasurementsboolean = null, Expression<Func<bool>> messageRorawMeasurementscontainerNode = null, Expression<Func<bool>> messageRorawMeasurementsdouble = null, Expression<Func<bool>> messageRorawMeasurementsfloat = null, Expression<Func<bool>> messageRorawMeasurementsfloatingPointNumber = null, Expression<Func<bool>> messageRorawMeasurementsint = null, Expression<Func<bool>> messageRorawMeasurementsintegralNumber = null, Expression<Func<bool>> messageRorawMeasurementsLong = null, Expression<Func<bool>> messageRorawMeasurementsmissingNode = null, Expression<Func<messageRorawMeasurementsnodeTypeInput>> messageRorawMeasurementsnodeType = null, Expression<Func<bool>> messageRorawMeasurementsnull = null, Expression<Func<bool>> messageRorawMeasurementsnumber = null, Expression<Func<bool>> messageRorawMeasurementsObject = null, Expression<Func<bool>> messageRorawMeasurementspojo = null, Expression<Func<bool>> messageRorawMeasurementsShort = null, Expression<Func<bool>> messageRorawMeasurementstextual = null, Expression<Func<bool>> messageRorawMeasurementsvalueNode = null, Expression<Func<string>> messageRothingdisplayName = null, Expression<Func<string>> messageRothingfixedName = null, Expression<Func<string>> messageRothingid = null, Expression<Func<int>> messageRothingnbAlerts = null, Expression<Func<ThingTagRo[]>> messageRothingtags = null)
        {
            var __workflow_thingId = thingId == null ? null : WorkflowExpression.Compile(thingId);
            WorkflowExpression.Validate(__workflow_thingId, nameof(thingId), required: true);
            var __workflow_messageRobody = messageRobody == null ? null : WorkflowExpression.Compile(messageRobody);
            WorkflowExpression.Validate(__workflow_messageRobody, nameof(messageRobody), required: true);
            var __workflow_messageRocreationDate = messageRocreationDate == null ? null : WorkflowExpression.Compile(messageRocreationDate);
            WorkflowExpression.Validate(__workflow_messageRocreationDate, nameof(messageRocreationDate), required: true);
            var __workflow_messageRoerrorMessage = messageRoerrorMessage == null ? null : WorkflowExpression.Compile(messageRoerrorMessage);
            WorkflowExpression.Validate(__workflow_messageRoerrorMessage, nameof(messageRoerrorMessage), required: true);
            var __workflow_messageRolatitude = messageRolatitude == null ? null : WorkflowExpression.Compile(messageRolatitude);
            WorkflowExpression.Validate(__workflow_messageRolatitude, nameof(messageRolatitude), required: true);
            var __workflow_messageRolongitude = messageRolongitude == null ? null : WorkflowExpression.Compile(messageRolongitude);
            WorkflowExpression.Validate(__workflow_messageRolongitude, nameof(messageRolongitude), required: true);
            var __workflow_messageRometadata = messageRometadata == null ? null : WorkflowExpression.Compile(messageRometadata);
            WorkflowExpression.Validate(__workflow_messageRometadata, nameof(messageRometadata), required: true);
            var __workflow_messageRonumber = messageRonumber == null ? null : WorkflowExpression.Compile(messageRonumber);
            WorkflowExpression.Validate(__workflow_messageRonumber, nameof(messageRonumber), required: true);
            var __workflow_messageRoprocessed = messageRoprocessed == null ? null : WorkflowExpression.Compile(messageRoprocessed);
            WorkflowExpression.Validate(__workflow_messageRoprocessed, nameof(messageRoprocessed), required: true);
            var __workflow_messageRothingname = messageRothingname == null ? null : WorkflowExpression.Compile(messageRothingname);
            WorkflowExpression.Validate(__workflow_messageRothingname, nameof(messageRothingname), required: true);
            var __workflow_messageRotimestamp = messageRotimestamp == null ? null : WorkflowExpression.Compile(messageRotimestamp);
            WorkflowExpression.Validate(__workflow_messageRotimestamp, nameof(messageRotimestamp), required: true);
            var __workflow_messageRotopic = messageRotopic == null ? null : WorkflowExpression.Compile(messageRotopic);
            WorkflowExpression.Validate(__workflow_messageRotopic, nameof(messageRotopic), required: true);
            var __workflow_messageRoid = messageRoid == null ? null : WorkflowExpression.Compile(messageRoid);
            WorkflowExpression.Validate(__workflow_messageRoid, nameof(messageRoid), required: false);
            var __workflow_messageRolinkabsolute = messageRolinkabsolute == null ? null : WorkflowExpression.Compile(messageRolinkabsolute);
            WorkflowExpression.Validate(__workflow_messageRolinkabsolute, nameof(messageRolinkabsolute), required: false);
            var __workflow_messageRolinkauthority = messageRolinkauthority == null ? null : WorkflowExpression.Compile(messageRolinkauthority);
            WorkflowExpression.Validate(__workflow_messageRolinkauthority, nameof(messageRolinkauthority), required: false);
            var __workflow_messageRolinkfragment = messageRolinkfragment == null ? null : WorkflowExpression.Compile(messageRolinkfragment);
            WorkflowExpression.Validate(__workflow_messageRolinkfragment, nameof(messageRolinkfragment), required: false);
            var __workflow_messageRolinkhost = messageRolinkhost == null ? null : WorkflowExpression.Compile(messageRolinkhost);
            WorkflowExpression.Validate(__workflow_messageRolinkhost, nameof(messageRolinkhost), required: false);
            var __workflow_messageRolinkopaque = messageRolinkopaque == null ? null : WorkflowExpression.Compile(messageRolinkopaque);
            WorkflowExpression.Validate(__workflow_messageRolinkopaque, nameof(messageRolinkopaque), required: false);
            var __workflow_messageRolinkpath = messageRolinkpath == null ? null : WorkflowExpression.Compile(messageRolinkpath);
            WorkflowExpression.Validate(__workflow_messageRolinkpath, nameof(messageRolinkpath), required: false);
            var __workflow_messageRolinkport = messageRolinkport == null ? null : WorkflowExpression.Compile(messageRolinkport);
            WorkflowExpression.Validate(__workflow_messageRolinkport, nameof(messageRolinkport), required: false);
            var __workflow_messageRolinkquery = messageRolinkquery == null ? null : WorkflowExpression.Compile(messageRolinkquery);
            WorkflowExpression.Validate(__workflow_messageRolinkquery, nameof(messageRolinkquery), required: false);
            var __workflow_messageRolinkrawAuthority = messageRolinkrawAuthority == null ? null : WorkflowExpression.Compile(messageRolinkrawAuthority);
            WorkflowExpression.Validate(__workflow_messageRolinkrawAuthority, nameof(messageRolinkrawAuthority), required: false);
            var __workflow_messageRolinkrawFragment = messageRolinkrawFragment == null ? null : WorkflowExpression.Compile(messageRolinkrawFragment);
            WorkflowExpression.Validate(__workflow_messageRolinkrawFragment, nameof(messageRolinkrawFragment), required: false);
            var __workflow_messageRolinkrawPath = messageRolinkrawPath == null ? null : WorkflowExpression.Compile(messageRolinkrawPath);
            WorkflowExpression.Validate(__workflow_messageRolinkrawPath, nameof(messageRolinkrawPath), required: false);
            var __workflow_messageRolinkrawQuery = messageRolinkrawQuery == null ? null : WorkflowExpression.Compile(messageRolinkrawQuery);
            WorkflowExpression.Validate(__workflow_messageRolinkrawQuery, nameof(messageRolinkrawQuery), required: false);
            var __workflow_messageRolinkrawSchemeSpecificPart = messageRolinkrawSchemeSpecificPart == null ? null : WorkflowExpression.Compile(messageRolinkrawSchemeSpecificPart);
            WorkflowExpression.Validate(__workflow_messageRolinkrawSchemeSpecificPart, nameof(messageRolinkrawSchemeSpecificPart), required: false);
            var __workflow_messageRolinkrawUserInfo = messageRolinkrawUserInfo == null ? null : WorkflowExpression.Compile(messageRolinkrawUserInfo);
            WorkflowExpression.Validate(__workflow_messageRolinkrawUserInfo, nameof(messageRolinkrawUserInfo), required: false);
            var __workflow_messageRolinkscheme = messageRolinkscheme == null ? null : WorkflowExpression.Compile(messageRolinkscheme);
            WorkflowExpression.Validate(__workflow_messageRolinkscheme, nameof(messageRolinkscheme), required: false);
            var __workflow_messageRolinkschemeSpecificPart = messageRolinkschemeSpecificPart == null ? null : WorkflowExpression.Compile(messageRolinkschemeSpecificPart);
            WorkflowExpression.Validate(__workflow_messageRolinkschemeSpecificPart, nameof(messageRolinkschemeSpecificPart), required: false);
            var __workflow_messageRolinkuserInfo = messageRolinkuserInfo == null ? null : WorkflowExpression.Compile(messageRolinkuserInfo);
            WorkflowExpression.Validate(__workflow_messageRolinkuserInfo, nameof(messageRolinkuserInfo), required: false);
            var __workflow_messageRorawMeasurementsarray = messageRorawMeasurementsarray == null ? null : WorkflowExpression.Compile(messageRorawMeasurementsarray);
            WorkflowExpression.Validate(__workflow_messageRorawMeasurementsarray, nameof(messageRorawMeasurementsarray), required: false);
            var __workflow_messageRorawMeasurementsbigDecimal = messageRorawMeasurementsbigDecimal == null ? null : WorkflowExpression.Compile(messageRorawMeasurementsbigDecimal);
            WorkflowExpression.Validate(__workflow_messageRorawMeasurementsbigDecimal, nameof(messageRorawMeasurementsbigDecimal), required: false);
            var __workflow_messageRorawMeasurementsbigInteger = messageRorawMeasurementsbigInteger == null ? null : WorkflowExpression.Compile(messageRorawMeasurementsbigInteger);
            WorkflowExpression.Validate(__workflow_messageRorawMeasurementsbigInteger, nameof(messageRorawMeasurementsbigInteger), required: false);
            var __workflow_messageRorawMeasurementsbinary = messageRorawMeasurementsbinary == null ? null : WorkflowExpression.Compile(messageRorawMeasurementsbinary);
            WorkflowExpression.Validate(__workflow_messageRorawMeasurementsbinary, nameof(messageRorawMeasurementsbinary), required: false);
            var __workflow_messageRorawMeasurementsboolean = messageRorawMeasurementsboolean == null ? null : WorkflowExpression.Compile(messageRorawMeasurementsboolean);
            WorkflowExpression.Validate(__workflow_messageRorawMeasurementsboolean, nameof(messageRorawMeasurementsboolean), required: false);
            var __workflow_messageRorawMeasurementscontainerNode = messageRorawMeasurementscontainerNode == null ? null : WorkflowExpression.Compile(messageRorawMeasurementscontainerNode);
            WorkflowExpression.Validate(__workflow_messageRorawMeasurementscontainerNode, nameof(messageRorawMeasurementscontainerNode), required: false);
            var __workflow_messageRorawMeasurementsdouble = messageRorawMeasurementsdouble == null ? null : WorkflowExpression.Compile(messageRorawMeasurementsdouble);
            WorkflowExpression.Validate(__workflow_messageRorawMeasurementsdouble, nameof(messageRorawMeasurementsdouble), required: false);
            var __workflow_messageRorawMeasurementsfloat = messageRorawMeasurementsfloat == null ? null : WorkflowExpression.Compile(messageRorawMeasurementsfloat);
            WorkflowExpression.Validate(__workflow_messageRorawMeasurementsfloat, nameof(messageRorawMeasurementsfloat), required: false);
            var __workflow_messageRorawMeasurementsfloatingPointNumber = messageRorawMeasurementsfloatingPointNumber == null ? null : WorkflowExpression.Compile(messageRorawMeasurementsfloatingPointNumber);
            WorkflowExpression.Validate(__workflow_messageRorawMeasurementsfloatingPointNumber, nameof(messageRorawMeasurementsfloatingPointNumber), required: false);
            var __workflow_messageRorawMeasurementsint = messageRorawMeasurementsint == null ? null : WorkflowExpression.Compile(messageRorawMeasurementsint);
            WorkflowExpression.Validate(__workflow_messageRorawMeasurementsint, nameof(messageRorawMeasurementsint), required: false);
            var __workflow_messageRorawMeasurementsintegralNumber = messageRorawMeasurementsintegralNumber == null ? null : WorkflowExpression.Compile(messageRorawMeasurementsintegralNumber);
            WorkflowExpression.Validate(__workflow_messageRorawMeasurementsintegralNumber, nameof(messageRorawMeasurementsintegralNumber), required: false);
            var __workflow_messageRorawMeasurementsLong = messageRorawMeasurementsLong == null ? null : WorkflowExpression.Compile(messageRorawMeasurementsLong);
            WorkflowExpression.Validate(__workflow_messageRorawMeasurementsLong, nameof(messageRorawMeasurementsLong), required: false);
            var __workflow_messageRorawMeasurementsmissingNode = messageRorawMeasurementsmissingNode == null ? null : WorkflowExpression.Compile(messageRorawMeasurementsmissingNode);
            WorkflowExpression.Validate(__workflow_messageRorawMeasurementsmissingNode, nameof(messageRorawMeasurementsmissingNode), required: false);
            var __workflow_messageRorawMeasurementsnodeType = messageRorawMeasurementsnodeType == null ? null : WorkflowExpression.Compile(messageRorawMeasurementsnodeType);
            WorkflowExpression.Validate(__workflow_messageRorawMeasurementsnodeType, nameof(messageRorawMeasurementsnodeType), required: false);
            var __workflow_messageRorawMeasurementsnull = messageRorawMeasurementsnull == null ? null : WorkflowExpression.Compile(messageRorawMeasurementsnull);
            WorkflowExpression.Validate(__workflow_messageRorawMeasurementsnull, nameof(messageRorawMeasurementsnull), required: false);
            var __workflow_messageRorawMeasurementsnumber = messageRorawMeasurementsnumber == null ? null : WorkflowExpression.Compile(messageRorawMeasurementsnumber);
            WorkflowExpression.Validate(__workflow_messageRorawMeasurementsnumber, nameof(messageRorawMeasurementsnumber), required: false);
            var __workflow_messageRorawMeasurementsObject = messageRorawMeasurementsObject == null ? null : WorkflowExpression.Compile(messageRorawMeasurementsObject);
            WorkflowExpression.Validate(__workflow_messageRorawMeasurementsObject, nameof(messageRorawMeasurementsObject), required: false);
            var __workflow_messageRorawMeasurementspojo = messageRorawMeasurementspojo == null ? null : WorkflowExpression.Compile(messageRorawMeasurementspojo);
            WorkflowExpression.Validate(__workflow_messageRorawMeasurementspojo, nameof(messageRorawMeasurementspojo), required: false);
            var __workflow_messageRorawMeasurementsShort = messageRorawMeasurementsShort == null ? null : WorkflowExpression.Compile(messageRorawMeasurementsShort);
            WorkflowExpression.Validate(__workflow_messageRorawMeasurementsShort, nameof(messageRorawMeasurementsShort), required: false);
            var __workflow_messageRorawMeasurementstextual = messageRorawMeasurementstextual == null ? null : WorkflowExpression.Compile(messageRorawMeasurementstextual);
            WorkflowExpression.Validate(__workflow_messageRorawMeasurementstextual, nameof(messageRorawMeasurementstextual), required: false);
            var __workflow_messageRorawMeasurementsvalueNode = messageRorawMeasurementsvalueNode == null ? null : WorkflowExpression.Compile(messageRorawMeasurementsvalueNode);
            WorkflowExpression.Validate(__workflow_messageRorawMeasurementsvalueNode, nameof(messageRorawMeasurementsvalueNode), required: false);
            var __workflow_messageRothingdisplayName = messageRothingdisplayName == null ? null : WorkflowExpression.Compile(messageRothingdisplayName);
            WorkflowExpression.Validate(__workflow_messageRothingdisplayName, nameof(messageRothingdisplayName), required: false);
            var __workflow_messageRothingfixedName = messageRothingfixedName == null ? null : WorkflowExpression.Compile(messageRothingfixedName);
            WorkflowExpression.Validate(__workflow_messageRothingfixedName, nameof(messageRothingfixedName), required: false);
            var __workflow_messageRothingid = messageRothingid == null ? null : WorkflowExpression.Compile(messageRothingid);
            WorkflowExpression.Validate(__workflow_messageRothingid, nameof(messageRothingid), required: false);
            var __workflow_messageRothingnbAlerts = messageRothingnbAlerts == null ? null : WorkflowExpression.Compile(messageRothingnbAlerts);
            WorkflowExpression.Validate(__workflow_messageRothingnbAlerts, nameof(messageRothingnbAlerts), required: false);
            var __workflow_messageRothingtags = messageRothingtags == null ? null : WorkflowExpression.Compile(messageRothingtags);
            WorkflowExpression.Validate(__workflow_messageRothingtags, nameof(messageRothingtags), required: false);
            return new DeferredBodyAction<MessageRo>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/messages/things/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_thingId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var messageRo = new JObject();
                var messageRopropCount = 0;
                messageRopropCount++;
                messageRo["body"] = ExpressionConverter.ConvertO(__workflow_messageRobody);
                messageRopropCount++;
                messageRo["creationDate"] = ExpressionConverter.ConvertO(__workflow_messageRocreationDate);
                messageRopropCount++;
                messageRo["errorMessage"] = ExpressionConverter.ConvertO(__workflow_messageRoerrorMessage);
                if (__workflow_messageRoid != null)
                {
                    messageRo["id"] = ExpressionConverter.ConvertO(__workflow_messageRoid);
                    messageRopropCount++;
                }

                messageRopropCount++;
                messageRo["latitude"] = ExpressionConverter.ConvertO(__workflow_messageRolatitude);
                var linkObject = new JObject();
                var linkObjectpropCount = 0;
                if (__workflow_messageRolinkabsolute != null)
                {
                    linkObject["absolute"] = ExpressionConverter.ConvertO(__workflow_messageRolinkabsolute);
                    linkObjectpropCount++;
                }

                if (__workflow_messageRolinkauthority != null)
                {
                    linkObject["authority"] = ExpressionConverter.ConvertO(__workflow_messageRolinkauthority);
                    linkObjectpropCount++;
                }

                if (__workflow_messageRolinkfragment != null)
                {
                    linkObject["fragment"] = ExpressionConverter.ConvertO(__workflow_messageRolinkfragment);
                    linkObjectpropCount++;
                }

                if (__workflow_messageRolinkhost != null)
                {
                    linkObject["host"] = ExpressionConverter.ConvertO(__workflow_messageRolinkhost);
                    linkObjectpropCount++;
                }

                if (__workflow_messageRolinkopaque != null)
                {
                    linkObject["opaque"] = ExpressionConverter.ConvertO(__workflow_messageRolinkopaque);
                    linkObjectpropCount++;
                }

                if (__workflow_messageRolinkpath != null)
                {
                    linkObject["path"] = ExpressionConverter.ConvertO(__workflow_messageRolinkpath);
                    linkObjectpropCount++;
                }

                if (__workflow_messageRolinkport != null)
                {
                    linkObject["port"] = ExpressionConverter.ConvertO(__workflow_messageRolinkport);
                    linkObjectpropCount++;
                }

                if (__workflow_messageRolinkquery != null)
                {
                    linkObject["query"] = ExpressionConverter.ConvertO(__workflow_messageRolinkquery);
                    linkObjectpropCount++;
                }

                if (__workflow_messageRolinkrawAuthority != null)
                {
                    linkObject["rawAuthority"] = ExpressionConverter.ConvertO(__workflow_messageRolinkrawAuthority);
                    linkObjectpropCount++;
                }

                if (__workflow_messageRolinkrawFragment != null)
                {
                    linkObject["rawFragment"] = ExpressionConverter.ConvertO(__workflow_messageRolinkrawFragment);
                    linkObjectpropCount++;
                }

                if (__workflow_messageRolinkrawPath != null)
                {
                    linkObject["rawPath"] = ExpressionConverter.ConvertO(__workflow_messageRolinkrawPath);
                    linkObjectpropCount++;
                }

                if (__workflow_messageRolinkrawQuery != null)
                {
                    linkObject["rawQuery"] = ExpressionConverter.ConvertO(__workflow_messageRolinkrawQuery);
                    linkObjectpropCount++;
                }

                if (__workflow_messageRolinkrawSchemeSpecificPart != null)
                {
                    linkObject["rawSchemeSpecificPart"] = ExpressionConverter.ConvertO(__workflow_messageRolinkrawSchemeSpecificPart);
                    linkObjectpropCount++;
                }

                if (__workflow_messageRolinkrawUserInfo != null)
                {
                    linkObject["rawUserInfo"] = ExpressionConverter.ConvertO(__workflow_messageRolinkrawUserInfo);
                    linkObjectpropCount++;
                }

                if (__workflow_messageRolinkscheme != null)
                {
                    linkObject["scheme"] = ExpressionConverter.ConvertO(__workflow_messageRolinkscheme);
                    linkObjectpropCount++;
                }

                if (__workflow_messageRolinkschemeSpecificPart != null)
                {
                    linkObject["schemeSpecificPart"] = ExpressionConverter.ConvertO(__workflow_messageRolinkschemeSpecificPart);
                    linkObjectpropCount++;
                }

                if (__workflow_messageRolinkuserInfo != null)
                {
                    linkObject["userInfo"] = ExpressionConverter.ConvertO(__workflow_messageRolinkuserInfo);
                    linkObjectpropCount++;
                }

                if (linkObjectpropCount > 0)
                {
                    messageRo["link"] = linkObject;
                    messageRopropCount++;
                }

                messageRopropCount++;
                messageRo["longitude"] = ExpressionConverter.ConvertO(__workflow_messageRolongitude);
                var measurementsObject = new JObject();
                var measurementsObjectpropCount = 0;
                if (measurementsObjectpropCount > 0)
                {
                    messageRo["measurements"] = measurementsObject;
                    messageRopropCount++;
                }

                messageRopropCount++;
                messageRo["metadata"] = ExpressionConverter.ConvertO(__workflow_messageRometadata);
                messageRopropCount++;
                messageRo["number"] = ExpressionConverter.ConvertO(__workflow_messageRonumber);
                messageRopropCount++;
                messageRo["processed"] = ExpressionConverter.ConvertO(__workflow_messageRoprocessed);
                var rawMeasurementsObject = new JObject();
                var rawMeasurementsObjectpropCount = 0;
                if (__workflow_messageRorawMeasurementsarray != null)
                {
                    rawMeasurementsObject["array"] = ExpressionConverter.ConvertO(__workflow_messageRorawMeasurementsarray);
                    rawMeasurementsObjectpropCount++;
                }

                if (__workflow_messageRorawMeasurementsbigDecimal != null)
                {
                    rawMeasurementsObject["bigDecimal"] = ExpressionConverter.ConvertO(__workflow_messageRorawMeasurementsbigDecimal);
                    rawMeasurementsObjectpropCount++;
                }

                if (__workflow_messageRorawMeasurementsbigInteger != null)
                {
                    rawMeasurementsObject["bigInteger"] = ExpressionConverter.ConvertO(__workflow_messageRorawMeasurementsbigInteger);
                    rawMeasurementsObjectpropCount++;
                }

                if (__workflow_messageRorawMeasurementsbinary != null)
                {
                    rawMeasurementsObject["binary"] = ExpressionConverter.ConvertO(__workflow_messageRorawMeasurementsbinary);
                    rawMeasurementsObjectpropCount++;
                }

                if (__workflow_messageRorawMeasurementsboolean != null)
                {
                    rawMeasurementsObject["boolean"] = ExpressionConverter.ConvertO(__workflow_messageRorawMeasurementsboolean);
                    rawMeasurementsObjectpropCount++;
                }

                if (__workflow_messageRorawMeasurementscontainerNode != null)
                {
                    rawMeasurementsObject["containerNode"] = ExpressionConverter.ConvertO(__workflow_messageRorawMeasurementscontainerNode);
                    rawMeasurementsObjectpropCount++;
                }

                if (__workflow_messageRorawMeasurementsdouble != null)
                {
                    rawMeasurementsObject["double"] = ExpressionConverter.ConvertO(__workflow_messageRorawMeasurementsdouble);
                    rawMeasurementsObjectpropCount++;
                }

                if (__workflow_messageRorawMeasurementsfloat != null)
                {
                    rawMeasurementsObject["float"] = ExpressionConverter.ConvertO(__workflow_messageRorawMeasurementsfloat);
                    rawMeasurementsObjectpropCount++;
                }

                if (__workflow_messageRorawMeasurementsfloatingPointNumber != null)
                {
                    rawMeasurementsObject["floatingPointNumber"] = ExpressionConverter.ConvertO(__workflow_messageRorawMeasurementsfloatingPointNumber);
                    rawMeasurementsObjectpropCount++;
                }

                if (__workflow_messageRorawMeasurementsint != null)
                {
                    rawMeasurementsObject["int"] = ExpressionConverter.ConvertO(__workflow_messageRorawMeasurementsint);
                    rawMeasurementsObjectpropCount++;
                }

                if (__workflow_messageRorawMeasurementsintegralNumber != null)
                {
                    rawMeasurementsObject["integralNumber"] = ExpressionConverter.ConvertO(__workflow_messageRorawMeasurementsintegralNumber);
                    rawMeasurementsObjectpropCount++;
                }

                if (__workflow_messageRorawMeasurementsLong != null)
                {
                    rawMeasurementsObject["long"] = ExpressionConverter.ConvertO(__workflow_messageRorawMeasurementsLong);
                    rawMeasurementsObjectpropCount++;
                }

                if (__workflow_messageRorawMeasurementsmissingNode != null)
                {
                    rawMeasurementsObject["missingNode"] = ExpressionConverter.ConvertO(__workflow_messageRorawMeasurementsmissingNode);
                    rawMeasurementsObjectpropCount++;
                }

                if (__workflow_messageRorawMeasurementsnodeType != null)
                {
                    rawMeasurementsObject["nodeType"] = ExpressionConverter.ConvertO(__workflow_messageRorawMeasurementsnodeType);
                    rawMeasurementsObjectpropCount++;
                }

                if (__workflow_messageRorawMeasurementsnull != null)
                {
                    rawMeasurementsObject["null"] = ExpressionConverter.ConvertO(__workflow_messageRorawMeasurementsnull);
                    rawMeasurementsObjectpropCount++;
                }

                if (__workflow_messageRorawMeasurementsnumber != null)
                {
                    rawMeasurementsObject["number"] = ExpressionConverter.ConvertO(__workflow_messageRorawMeasurementsnumber);
                    rawMeasurementsObjectpropCount++;
                }

                if (__workflow_messageRorawMeasurementsObject != null)
                {
                    rawMeasurementsObject["object"] = ExpressionConverter.ConvertO(__workflow_messageRorawMeasurementsObject);
                    rawMeasurementsObjectpropCount++;
                }

                if (__workflow_messageRorawMeasurementspojo != null)
                {
                    rawMeasurementsObject["pojo"] = ExpressionConverter.ConvertO(__workflow_messageRorawMeasurementspojo);
                    rawMeasurementsObjectpropCount++;
                }

                if (__workflow_messageRorawMeasurementsShort != null)
                {
                    rawMeasurementsObject["short"] = ExpressionConverter.ConvertO(__workflow_messageRorawMeasurementsShort);
                    rawMeasurementsObjectpropCount++;
                }

                if (__workflow_messageRorawMeasurementstextual != null)
                {
                    rawMeasurementsObject["textual"] = ExpressionConverter.ConvertO(__workflow_messageRorawMeasurementstextual);
                    rawMeasurementsObjectpropCount++;
                }

                if (__workflow_messageRorawMeasurementsvalueNode != null)
                {
                    rawMeasurementsObject["valueNode"] = ExpressionConverter.ConvertO(__workflow_messageRorawMeasurementsvalueNode);
                    rawMeasurementsObjectpropCount++;
                }

                if (rawMeasurementsObjectpropCount > 0)
                {
                    messageRo["rawMeasurements"] = rawMeasurementsObject;
                    messageRopropCount++;
                }

                var thingObject = new JObject();
                var thingObjectpropCount = 0;
                if (__workflow_messageRothingdisplayName != null)
                {
                    thingObject["displayName"] = ExpressionConverter.ConvertO(__workflow_messageRothingdisplayName);
                    thingObjectpropCount++;
                }

                if (__workflow_messageRothingfixedName != null)
                {
                    thingObject["fixedName"] = ExpressionConverter.ConvertO(__workflow_messageRothingfixedName);
                    thingObjectpropCount++;
                }

                if (__workflow_messageRothingid != null)
                {
                    thingObject["id"] = ExpressionConverter.ConvertO(__workflow_messageRothingid);
                    thingObjectpropCount++;
                }

                thingObjectpropCount++;
                thingObject["name"] = ExpressionConverter.ConvertO(__workflow_messageRothingname);
                if (__workflow_messageRothingnbAlerts != null)
                {
                    thingObject["nbAlerts"] = ExpressionConverter.ConvertO(__workflow_messageRothingnbAlerts);
                    thingObjectpropCount++;
                }

                if (__workflow_messageRothingtags != null)
                {
                    thingObject["tags"] = ExpressionConverter.ConvertO(__workflow_messageRothingtags);
                    thingObjectpropCount++;
                }

                if (thingObjectpropCount > 0)
                {
                    messageRo["thing"] = thingObject;
                    messageRopropCount++;
                }

                messageRopropCount++;
                messageRo["timestamp"] = ExpressionConverter.ConvertO(__workflow_messageRotimestamp);
                messageRopropCount++;
                messageRo["topic"] = ExpressionConverter.ConvertO(__workflow_messageRotopic);
                if (messageRopropCount > 0)
                {
                    callPayload.Body = messageRo;
                }

                return new ApiConnectionAction<MessageRo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<MessageRo> GetMessage(Expression<Func<string>> id)
        {
            var __workflow_id = id == null ? null : WorkflowExpression.Compile(id);
            WorkflowExpression.Validate(__workflow_id, nameof(id), required: true);
            return new DeferredBodyAction<MessageRo>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/messages/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<MessageRo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<MessageRo> GetPreviousMessage(Expression<Func<string>> id)
        {
            var __workflow_id = id == null ? null : WorkflowExpression.Compile(id);
            WorkflowExpression.Validate(__workflow_id, nameof(id), required: true);
            return new DeferredBodyAction<MessageRo>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/messages/{0}/previous", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<MessageRo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<PageSiteRo> GetSites(Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null, Expression<Func<string>> sortValues = null, Expression<Func<string>> sort = null, Expression<Func<string>> filter = null, Expression<Func<dirInput>> dir = null, Expression<Func<string>> orFilter = null)
        {
            var __workflow_page = page == null ? null : WorkflowExpression.Compile(page);
            WorkflowExpression.Validate(__workflow_page, nameof(page), required: false);
            var __workflow_pageSize = pageSize == null ? null : WorkflowExpression.Compile(pageSize);
            WorkflowExpression.Validate(__workflow_pageSize, nameof(pageSize), required: false);
            var __workflow_sortValues = sortValues == null ? null : WorkflowExpression.Compile(sortValues);
            WorkflowExpression.Validate(__workflow_sortValues, nameof(sortValues), required: false);
            var __workflow_sort = sort == null ? null : WorkflowExpression.Compile(sort);
            WorkflowExpression.Validate(__workflow_sort, nameof(sort), required: false);
            var __workflow_filter = filter == null ? null : WorkflowExpression.Compile(filter);
            WorkflowExpression.Validate(__workflow_filter, nameof(filter), required: false);
            var __workflow_dir = dir == null ? null : WorkflowExpression.Compile(dir);
            WorkflowExpression.Validate(__workflow_dir, nameof(dir), required: false);
            var __workflow_orFilter = orFilter == null ? null : WorkflowExpression.Compile(orFilter);
            WorkflowExpression.Validate(__workflow_orFilter, nameof(orFilter), required: false);
            return new DeferredBodyAction<PageSiteRo>(() =>
            {
                var apiCallPath = "/api/sites";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(__workflow_pageSize);
                if (__workflow_sortValues != null)
                    callPayload.Queries["sortValues"] = ExpressionConverter.Convert(__workflow_sortValues);
                if (__workflow_sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(__workflow_sort);
                if (__workflow_filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_dir != null)
                    callPayload.Queries["dir"] = ExpressionConverter.Convert(__workflow_dir);
                if (__workflow_orFilter != null)
                    callPayload.Queries["orFilter"] = ExpressionConverter.Convert(__workflow_orFilter);
                return new ApiConnectionAction<PageSiteRo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<SiteRo[]> CreateSite(Expression<Func<bool>> nodearray = null, Expression<Func<bool>> nodebigDecimal = null, Expression<Func<bool>> nodebigInteger = null, Expression<Func<bool>> nodebinary = null, Expression<Func<bool>> nodeboolean = null, Expression<Func<bool>> nodecontainerNode = null, Expression<Func<bool>> nodedouble = null, Expression<Func<bool>> nodefloat = null, Expression<Func<bool>> nodefloatingPointNumber = null, Expression<Func<bool>> nodeint = null, Expression<Func<bool>> nodeintegralNumber = null, Expression<Func<bool>> nodeLong = null, Expression<Func<bool>> nodemissingNode = null, Expression<Func<nodenodeTypeInput>> nodenodeType = null, Expression<Func<bool>> nodenull = null, Expression<Func<bool>> nodenumber = null, Expression<Func<bool>> nodeObject = null, Expression<Func<bool>> nodepojo = null, Expression<Func<bool>> nodeShort = null, Expression<Func<bool>> nodetextual = null, Expression<Func<bool>> nodevalueNode = null)
        {
            var __workflow_nodearray = nodearray == null ? null : WorkflowExpression.Compile(nodearray);
            WorkflowExpression.Validate(__workflow_nodearray, nameof(nodearray), required: false);
            var __workflow_nodebigDecimal = nodebigDecimal == null ? null : WorkflowExpression.Compile(nodebigDecimal);
            WorkflowExpression.Validate(__workflow_nodebigDecimal, nameof(nodebigDecimal), required: false);
            var __workflow_nodebigInteger = nodebigInteger == null ? null : WorkflowExpression.Compile(nodebigInteger);
            WorkflowExpression.Validate(__workflow_nodebigInteger, nameof(nodebigInteger), required: false);
            var __workflow_nodebinary = nodebinary == null ? null : WorkflowExpression.Compile(nodebinary);
            WorkflowExpression.Validate(__workflow_nodebinary, nameof(nodebinary), required: false);
            var __workflow_nodeboolean = nodeboolean == null ? null : WorkflowExpression.Compile(nodeboolean);
            WorkflowExpression.Validate(__workflow_nodeboolean, nameof(nodeboolean), required: false);
            var __workflow_nodecontainerNode = nodecontainerNode == null ? null : WorkflowExpression.Compile(nodecontainerNode);
            WorkflowExpression.Validate(__workflow_nodecontainerNode, nameof(nodecontainerNode), required: false);
            var __workflow_nodedouble = nodedouble == null ? null : WorkflowExpression.Compile(nodedouble);
            WorkflowExpression.Validate(__workflow_nodedouble, nameof(nodedouble), required: false);
            var __workflow_nodefloat = nodefloat == null ? null : WorkflowExpression.Compile(nodefloat);
            WorkflowExpression.Validate(__workflow_nodefloat, nameof(nodefloat), required: false);
            var __workflow_nodefloatingPointNumber = nodefloatingPointNumber == null ? null : WorkflowExpression.Compile(nodefloatingPointNumber);
            WorkflowExpression.Validate(__workflow_nodefloatingPointNumber, nameof(nodefloatingPointNumber), required: false);
            var __workflow_nodeint = nodeint == null ? null : WorkflowExpression.Compile(nodeint);
            WorkflowExpression.Validate(__workflow_nodeint, nameof(nodeint), required: false);
            var __workflow_nodeintegralNumber = nodeintegralNumber == null ? null : WorkflowExpression.Compile(nodeintegralNumber);
            WorkflowExpression.Validate(__workflow_nodeintegralNumber, nameof(nodeintegralNumber), required: false);
            var __workflow_nodeLong = nodeLong == null ? null : WorkflowExpression.Compile(nodeLong);
            WorkflowExpression.Validate(__workflow_nodeLong, nameof(nodeLong), required: false);
            var __workflow_nodemissingNode = nodemissingNode == null ? null : WorkflowExpression.Compile(nodemissingNode);
            WorkflowExpression.Validate(__workflow_nodemissingNode, nameof(nodemissingNode), required: false);
            var __workflow_nodenodeType = nodenodeType == null ? null : WorkflowExpression.Compile(nodenodeType);
            WorkflowExpression.Validate(__workflow_nodenodeType, nameof(nodenodeType), required: false);
            var __workflow_nodenull = nodenull == null ? null : WorkflowExpression.Compile(nodenull);
            WorkflowExpression.Validate(__workflow_nodenull, nameof(nodenull), required: false);
            var __workflow_nodenumber = nodenumber == null ? null : WorkflowExpression.Compile(nodenumber);
            WorkflowExpression.Validate(__workflow_nodenumber, nameof(nodenumber), required: false);
            var __workflow_nodeObject = nodeObject == null ? null : WorkflowExpression.Compile(nodeObject);
            WorkflowExpression.Validate(__workflow_nodeObject, nameof(nodeObject), required: false);
            var __workflow_nodepojo = nodepojo == null ? null : WorkflowExpression.Compile(nodepojo);
            WorkflowExpression.Validate(__workflow_nodepojo, nameof(nodepojo), required: false);
            var __workflow_nodeShort = nodeShort == null ? null : WorkflowExpression.Compile(nodeShort);
            WorkflowExpression.Validate(__workflow_nodeShort, nameof(nodeShort), required: false);
            var __workflow_nodetextual = nodetextual == null ? null : WorkflowExpression.Compile(nodetextual);
            WorkflowExpression.Validate(__workflow_nodetextual, nameof(nodetextual), required: false);
            var __workflow_nodevalueNode = nodevalueNode == null ? null : WorkflowExpression.Compile(nodevalueNode);
            WorkflowExpression.Validate(__workflow_nodevalueNode, nameof(nodevalueNode), required: false);
            return new DeferredBodyAction<SiteRo[]>(() =>
            {
                var apiCallPath = "/api/sites";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var node = new JObject();
                var nodepropCount = 0;
                if (__workflow_nodearray != null)
                {
                    node["array"] = ExpressionConverter.ConvertO(__workflow_nodearray);
                    nodepropCount++;
                }

                if (__workflow_nodebigDecimal != null)
                {
                    node["bigDecimal"] = ExpressionConverter.ConvertO(__workflow_nodebigDecimal);
                    nodepropCount++;
                }

                if (__workflow_nodebigInteger != null)
                {
                    node["bigInteger"] = ExpressionConverter.ConvertO(__workflow_nodebigInteger);
                    nodepropCount++;
                }

                if (__workflow_nodebinary != null)
                {
                    node["binary"] = ExpressionConverter.ConvertO(__workflow_nodebinary);
                    nodepropCount++;
                }

                if (__workflow_nodeboolean != null)
                {
                    node["boolean"] = ExpressionConverter.ConvertO(__workflow_nodeboolean);
                    nodepropCount++;
                }

                if (__workflow_nodecontainerNode != null)
                {
                    node["containerNode"] = ExpressionConverter.ConvertO(__workflow_nodecontainerNode);
                    nodepropCount++;
                }

                if (__workflow_nodedouble != null)
                {
                    node["double"] = ExpressionConverter.ConvertO(__workflow_nodedouble);
                    nodepropCount++;
                }

                if (__workflow_nodefloat != null)
                {
                    node["float"] = ExpressionConverter.ConvertO(__workflow_nodefloat);
                    nodepropCount++;
                }

                if (__workflow_nodefloatingPointNumber != null)
                {
                    node["floatingPointNumber"] = ExpressionConverter.ConvertO(__workflow_nodefloatingPointNumber);
                    nodepropCount++;
                }

                if (__workflow_nodeint != null)
                {
                    node["int"] = ExpressionConverter.ConvertO(__workflow_nodeint);
                    nodepropCount++;
                }

                if (__workflow_nodeintegralNumber != null)
                {
                    node["integralNumber"] = ExpressionConverter.ConvertO(__workflow_nodeintegralNumber);
                    nodepropCount++;
                }

                if (__workflow_nodeLong != null)
                {
                    node["long"] = ExpressionConverter.ConvertO(__workflow_nodeLong);
                    nodepropCount++;
                }

                if (__workflow_nodemissingNode != null)
                {
                    node["missingNode"] = ExpressionConverter.ConvertO(__workflow_nodemissingNode);
                    nodepropCount++;
                }

                if (__workflow_nodenodeType != null)
                {
                    node["nodeType"] = ExpressionConverter.ConvertO(__workflow_nodenodeType);
                    nodepropCount++;
                }

                if (__workflow_nodenull != null)
                {
                    node["null"] = ExpressionConverter.ConvertO(__workflow_nodenull);
                    nodepropCount++;
                }

                if (__workflow_nodenumber != null)
                {
                    node["number"] = ExpressionConverter.ConvertO(__workflow_nodenumber);
                    nodepropCount++;
                }

                if (__workflow_nodeObject != null)
                {
                    node["object"] = ExpressionConverter.ConvertO(__workflow_nodeObject);
                    nodepropCount++;
                }

                if (__workflow_nodepojo != null)
                {
                    node["pojo"] = ExpressionConverter.ConvertO(__workflow_nodepojo);
                    nodepropCount++;
                }

                if (__workflow_nodeShort != null)
                {
                    node["short"] = ExpressionConverter.ConvertO(__workflow_nodeShort);
                    nodepropCount++;
                }

                if (__workflow_nodetextual != null)
                {
                    node["textual"] = ExpressionConverter.ConvertO(__workflow_nodetextual);
                    nodepropCount++;
                }

                if (__workflow_nodevalueNode != null)
                {
                    node["valueNode"] = ExpressionConverter.ConvertO(__workflow_nodevalueNode);
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
        public IBodyWorkflowAction<SiteRo> GetSite(Expression<Func<string>> id)
        {
            var __workflow_id = id == null ? null : WorkflowExpression.Compile(id);
            WorkflowExpression.Validate(__workflow_id, nameof(id), required: true);
            return new DeferredBodyAction<SiteRo>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/sites/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SiteRo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IWorkflowAction DeleteSite(Expression<Func<string>> id)
        {
            var __workflow_id = id == null ? null : WorkflowExpression.Compile(id);
            WorkflowExpression.Validate(__workflow_id, nameof(id), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/sites/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<SiteRo> UpdateSite(Expression<Func<string>> id, Expression<Func<string>> siteRoaddress, Expression<Func<string>> siteRocity, Expression<Func<string>> siteRoname, Expression<Func<string>> siteRopostalCode, Expression<Func<string>> siteRoid = null, Expression<Func<double>> siteRolatitude = null, Expression<Func<double>> siteRolongitude = null)
        {
            var __workflow_id = id == null ? null : WorkflowExpression.Compile(id);
            WorkflowExpression.Validate(__workflow_id, nameof(id), required: true);
            var __workflow_siteRoaddress = siteRoaddress == null ? null : WorkflowExpression.Compile(siteRoaddress);
            WorkflowExpression.Validate(__workflow_siteRoaddress, nameof(siteRoaddress), required: true);
            var __workflow_siteRocity = siteRocity == null ? null : WorkflowExpression.Compile(siteRocity);
            WorkflowExpression.Validate(__workflow_siteRocity, nameof(siteRocity), required: true);
            var __workflow_siteRoname = siteRoname == null ? null : WorkflowExpression.Compile(siteRoname);
            WorkflowExpression.Validate(__workflow_siteRoname, nameof(siteRoname), required: true);
            var __workflow_siteRopostalCode = siteRopostalCode == null ? null : WorkflowExpression.Compile(siteRopostalCode);
            WorkflowExpression.Validate(__workflow_siteRopostalCode, nameof(siteRopostalCode), required: true);
            var __workflow_siteRoid = siteRoid == null ? null : WorkflowExpression.Compile(siteRoid);
            WorkflowExpression.Validate(__workflow_siteRoid, nameof(siteRoid), required: false);
            var __workflow_siteRolatitude = siteRolatitude == null ? null : WorkflowExpression.Compile(siteRolatitude);
            WorkflowExpression.Validate(__workflow_siteRolatitude, nameof(siteRolatitude), required: false);
            var __workflow_siteRolongitude = siteRolongitude == null ? null : WorkflowExpression.Compile(siteRolongitude);
            WorkflowExpression.Validate(__workflow_siteRolongitude, nameof(siteRolongitude), required: false);
            return new DeferredBodyAction<SiteRo>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/sites/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var siteRo = new JObject();
                var siteRopropCount = 0;
                siteRopropCount++;
                siteRo["address"] = ExpressionConverter.ConvertO(__workflow_siteRoaddress);
                siteRopropCount++;
                siteRo["city"] = ExpressionConverter.ConvertO(__workflow_siteRocity);
                if (__workflow_siteRoid != null)
                {
                    siteRo["id"] = ExpressionConverter.ConvertO(__workflow_siteRoid);
                    siteRopropCount++;
                }

                if (__workflow_siteRolatitude != null)
                {
                    siteRo["latitude"] = ExpressionConverter.ConvertO(__workflow_siteRolatitude);
                    siteRopropCount++;
                }

                if (__workflow_siteRolongitude != null)
                {
                    siteRo["longitude"] = ExpressionConverter.ConvertO(__workflow_siteRolongitude);
                    siteRopropCount++;
                }

                siteRopropCount++;
                siteRo["name"] = ExpressionConverter.ConvertO(__workflow_siteRoname);
                siteRopropCount++;
                siteRo["postalCode"] = ExpressionConverter.ConvertO(__workflow_siteRopostalCode);
                if (siteRopropCount > 0)
                {
                    callPayload.Body = siteRo;
                }

                return new ApiConnectionAction<SiteRo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<PageThingTagRo> GetTags(Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null, Expression<Func<string>> sortValues = null, Expression<Func<string>> sort = null, Expression<Func<string>> filter = null, Expression<Func<dirInput>> dir = null, Expression<Func<string>> orFilter = null)
        {
            var __workflow_page = page == null ? null : WorkflowExpression.Compile(page);
            WorkflowExpression.Validate(__workflow_page, nameof(page), required: false);
            var __workflow_pageSize = pageSize == null ? null : WorkflowExpression.Compile(pageSize);
            WorkflowExpression.Validate(__workflow_pageSize, nameof(pageSize), required: false);
            var __workflow_sortValues = sortValues == null ? null : WorkflowExpression.Compile(sortValues);
            WorkflowExpression.Validate(__workflow_sortValues, nameof(sortValues), required: false);
            var __workflow_sort = sort == null ? null : WorkflowExpression.Compile(sort);
            WorkflowExpression.Validate(__workflow_sort, nameof(sort), required: false);
            var __workflow_filter = filter == null ? null : WorkflowExpression.Compile(filter);
            WorkflowExpression.Validate(__workflow_filter, nameof(filter), required: false);
            var __workflow_dir = dir == null ? null : WorkflowExpression.Compile(dir);
            WorkflowExpression.Validate(__workflow_dir, nameof(dir), required: false);
            var __workflow_orFilter = orFilter == null ? null : WorkflowExpression.Compile(orFilter);
            WorkflowExpression.Validate(__workflow_orFilter, nameof(orFilter), required: false);
            return new DeferredBodyAction<PageThingTagRo>(() =>
            {
                var apiCallPath = "/api/tags";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(__workflow_pageSize);
                if (__workflow_sortValues != null)
                    callPayload.Queries["sortValues"] = ExpressionConverter.Convert(__workflow_sortValues);
                if (__workflow_sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(__workflow_sort);
                if (__workflow_filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_dir != null)
                    callPayload.Queries["dir"] = ExpressionConverter.Convert(__workflow_dir);
                if (__workflow_orFilter != null)
                    callPayload.Queries["orFilter"] = ExpressionConverter.Convert(__workflow_orFilter);
                return new ApiConnectionAction<PageThingTagRo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<TagRo> UpdateThingTag(Expression<Func<string>> thingTagRoid = null, Expression<Func<string>> thingTagRotag = null)
        {
            var __workflow_thingTagRoid = thingTagRoid == null ? null : WorkflowExpression.Compile(thingTagRoid);
            WorkflowExpression.Validate(__workflow_thingTagRoid, nameof(thingTagRoid), required: false);
            var __workflow_thingTagRotag = thingTagRotag == null ? null : WorkflowExpression.Compile(thingTagRotag);
            WorkflowExpression.Validate(__workflow_thingTagRotag, nameof(thingTagRotag), required: false);
            return new DeferredBodyAction<TagRo>(() =>
            {
                var apiCallPath = "/api/tags";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var thingTagRo = new JObject();
                var thingTagRopropCount = 0;
                if (__workflow_thingTagRoid != null)
                {
                    thingTagRo["id"] = ExpressionConverter.ConvertO(__workflow_thingTagRoid);
                    thingTagRopropCount++;
                }

                if (__workflow_thingTagRotag != null)
                {
                    thingTagRo["tag"] = ExpressionConverter.ConvertO(__workflow_thingTagRotag);
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
        public IBodyWorkflowAction<TagRo> AddThingTag(Expression<Func<string>> thingId, Expression<Func<string>> thingTagRoid = null, Expression<Func<string>> thingTagRotag = null)
        {
            var __workflow_thingId = thingId == null ? null : WorkflowExpression.Compile(thingId);
            WorkflowExpression.Validate(__workflow_thingId, nameof(thingId), required: true);
            var __workflow_thingTagRoid = thingTagRoid == null ? null : WorkflowExpression.Compile(thingTagRoid);
            WorkflowExpression.Validate(__workflow_thingTagRoid, nameof(thingTagRoid), required: false);
            var __workflow_thingTagRotag = thingTagRotag == null ? null : WorkflowExpression.Compile(thingTagRotag);
            WorkflowExpression.Validate(__workflow_thingTagRotag, nameof(thingTagRotag), required: false);
            return new DeferredBodyAction<TagRo>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/tags/thing/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_thingId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var thingTagRo = new JObject();
                var thingTagRopropCount = 0;
                if (__workflow_thingTagRoid != null)
                {
                    thingTagRo["id"] = ExpressionConverter.ConvertO(__workflow_thingTagRoid);
                    thingTagRopropCount++;
                }

                if (__workflow_thingTagRotag != null)
                {
                    thingTagRo["tag"] = ExpressionConverter.ConvertO(__workflow_thingTagRotag);
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
        public IBodyWorkflowAction<TagRo> GetThingTag(Expression<Func<string>> id)
        {
            var __workflow_id = id == null ? null : WorkflowExpression.Compile(id);
            WorkflowExpression.Validate(__workflow_id, nameof(id), required: true);
            return new DeferredBodyAction<TagRo>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/tags/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<TagRo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<PageSingleThingRo> GetThings(Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null, Expression<Func<string>> sortValues = null, Expression<Func<string>> sort = null, Expression<Func<string>> filter = null, Expression<Func<dirInput>> dir = null, Expression<Func<string>> orFilter = null, Expression<Func<bool>> detailed = null)
        {
            var __workflow_page = page == null ? null : WorkflowExpression.Compile(page);
            WorkflowExpression.Validate(__workflow_page, nameof(page), required: false);
            var __workflow_pageSize = pageSize == null ? null : WorkflowExpression.Compile(pageSize);
            WorkflowExpression.Validate(__workflow_pageSize, nameof(pageSize), required: false);
            var __workflow_sortValues = sortValues == null ? null : WorkflowExpression.Compile(sortValues);
            WorkflowExpression.Validate(__workflow_sortValues, nameof(sortValues), required: false);
            var __workflow_sort = sort == null ? null : WorkflowExpression.Compile(sort);
            WorkflowExpression.Validate(__workflow_sort, nameof(sort), required: false);
            var __workflow_filter = filter == null ? null : WorkflowExpression.Compile(filter);
            WorkflowExpression.Validate(__workflow_filter, nameof(filter), required: false);
            var __workflow_dir = dir == null ? null : WorkflowExpression.Compile(dir);
            WorkflowExpression.Validate(__workflow_dir, nameof(dir), required: false);
            var __workflow_orFilter = orFilter == null ? null : WorkflowExpression.Compile(orFilter);
            WorkflowExpression.Validate(__workflow_orFilter, nameof(orFilter), required: false);
            var __workflow_detailed = detailed == null ? null : WorkflowExpression.Compile(detailed);
            WorkflowExpression.Validate(__workflow_detailed, nameof(detailed), required: false);
            return new DeferredBodyAction<PageSingleThingRo>(() =>
            {
                var apiCallPath = "/api/things";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(__workflow_pageSize);
                if (__workflow_sortValues != null)
                    callPayload.Queries["sortValues"] = ExpressionConverter.Convert(__workflow_sortValues);
                if (__workflow_sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(__workflow_sort);
                if (__workflow_filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_dir != null)
                    callPayload.Queries["dir"] = ExpressionConverter.Convert(__workflow_dir);
                if (__workflow_orFilter != null)
                    callPayload.Queries["orFilter"] = ExpressionConverter.Convert(__workflow_orFilter);
                callPayload.Queries["detailed"] = Convert.ToString(false);
                if (__workflow_detailed != null)
                    callPayload.Queries["detailed"] = ExpressionConverter.Convert(__workflow_detailed);
                return new ApiConnectionAction<PageSingleThingRo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<ResponseEntity> AddThingsCsv(Expression<Func<object>> file)
        {
            var __workflow_file = file == null ? null : WorkflowExpression.Compile(file);
            WorkflowExpression.Validate(__workflow_file, nameof(file), required: true);
            return new DeferredBodyAction<ResponseEntity>(() =>
            {
                var apiCallPath = "/api/things";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ResponseEntity>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<SingleThingRo[]> AssociateThingsWithProduct(Expression<Func<bool>> jsonarray = null, Expression<Func<bool>> jsonbigDecimal = null, Expression<Func<bool>> jsonbigInteger = null, Expression<Func<bool>> jsonbinary = null, Expression<Func<bool>> jsonboolean = null, Expression<Func<bool>> jsoncontainerNode = null, Expression<Func<bool>> jsondouble = null, Expression<Func<bool>> jsonfloat = null, Expression<Func<bool>> jsonfloatingPointNumber = null, Expression<Func<bool>> jsonint = null, Expression<Func<bool>> jsonintegralNumber = null, Expression<Func<bool>> jsonLong = null, Expression<Func<bool>> jsonmissingNode = null, Expression<Func<jsonnodeTypeInput>> jsonnodeType = null, Expression<Func<bool>> jsonnull = null, Expression<Func<bool>> jsonnumber = null, Expression<Func<bool>> jsonObject = null, Expression<Func<bool>> jsonpojo = null, Expression<Func<bool>> jsonShort = null, Expression<Func<bool>> jsontextual = null, Expression<Func<bool>> jsonvalueNode = null)
        {
            var __workflow_jsonarray = jsonarray == null ? null : WorkflowExpression.Compile(jsonarray);
            WorkflowExpression.Validate(__workflow_jsonarray, nameof(jsonarray), required: false);
            var __workflow_jsonbigDecimal = jsonbigDecimal == null ? null : WorkflowExpression.Compile(jsonbigDecimal);
            WorkflowExpression.Validate(__workflow_jsonbigDecimal, nameof(jsonbigDecimal), required: false);
            var __workflow_jsonbigInteger = jsonbigInteger == null ? null : WorkflowExpression.Compile(jsonbigInteger);
            WorkflowExpression.Validate(__workflow_jsonbigInteger, nameof(jsonbigInteger), required: false);
            var __workflow_jsonbinary = jsonbinary == null ? null : WorkflowExpression.Compile(jsonbinary);
            WorkflowExpression.Validate(__workflow_jsonbinary, nameof(jsonbinary), required: false);
            var __workflow_jsonboolean = jsonboolean == null ? null : WorkflowExpression.Compile(jsonboolean);
            WorkflowExpression.Validate(__workflow_jsonboolean, nameof(jsonboolean), required: false);
            var __workflow_jsoncontainerNode = jsoncontainerNode == null ? null : WorkflowExpression.Compile(jsoncontainerNode);
            WorkflowExpression.Validate(__workflow_jsoncontainerNode, nameof(jsoncontainerNode), required: false);
            var __workflow_jsondouble = jsondouble == null ? null : WorkflowExpression.Compile(jsondouble);
            WorkflowExpression.Validate(__workflow_jsondouble, nameof(jsondouble), required: false);
            var __workflow_jsonfloat = jsonfloat == null ? null : WorkflowExpression.Compile(jsonfloat);
            WorkflowExpression.Validate(__workflow_jsonfloat, nameof(jsonfloat), required: false);
            var __workflow_jsonfloatingPointNumber = jsonfloatingPointNumber == null ? null : WorkflowExpression.Compile(jsonfloatingPointNumber);
            WorkflowExpression.Validate(__workflow_jsonfloatingPointNumber, nameof(jsonfloatingPointNumber), required: false);
            var __workflow_jsonint = jsonint == null ? null : WorkflowExpression.Compile(jsonint);
            WorkflowExpression.Validate(__workflow_jsonint, nameof(jsonint), required: false);
            var __workflow_jsonintegralNumber = jsonintegralNumber == null ? null : WorkflowExpression.Compile(jsonintegralNumber);
            WorkflowExpression.Validate(__workflow_jsonintegralNumber, nameof(jsonintegralNumber), required: false);
            var __workflow_jsonLong = jsonLong == null ? null : WorkflowExpression.Compile(jsonLong);
            WorkflowExpression.Validate(__workflow_jsonLong, nameof(jsonLong), required: false);
            var __workflow_jsonmissingNode = jsonmissingNode == null ? null : WorkflowExpression.Compile(jsonmissingNode);
            WorkflowExpression.Validate(__workflow_jsonmissingNode, nameof(jsonmissingNode), required: false);
            var __workflow_jsonnodeType = jsonnodeType == null ? null : WorkflowExpression.Compile(jsonnodeType);
            WorkflowExpression.Validate(__workflow_jsonnodeType, nameof(jsonnodeType), required: false);
            var __workflow_jsonnull = jsonnull == null ? null : WorkflowExpression.Compile(jsonnull);
            WorkflowExpression.Validate(__workflow_jsonnull, nameof(jsonnull), required: false);
            var __workflow_jsonnumber = jsonnumber == null ? null : WorkflowExpression.Compile(jsonnumber);
            WorkflowExpression.Validate(__workflow_jsonnumber, nameof(jsonnumber), required: false);
            var __workflow_jsonObject = jsonObject == null ? null : WorkflowExpression.Compile(jsonObject);
            WorkflowExpression.Validate(__workflow_jsonObject, nameof(jsonObject), required: false);
            var __workflow_jsonpojo = jsonpojo == null ? null : WorkflowExpression.Compile(jsonpojo);
            WorkflowExpression.Validate(__workflow_jsonpojo, nameof(jsonpojo), required: false);
            var __workflow_jsonShort = jsonShort == null ? null : WorkflowExpression.Compile(jsonShort);
            WorkflowExpression.Validate(__workflow_jsonShort, nameof(jsonShort), required: false);
            var __workflow_jsontextual = jsontextual == null ? null : WorkflowExpression.Compile(jsontextual);
            WorkflowExpression.Validate(__workflow_jsontextual, nameof(jsontextual), required: false);
            var __workflow_jsonvalueNode = jsonvalueNode == null ? null : WorkflowExpression.Compile(jsonvalueNode);
            WorkflowExpression.Validate(__workflow_jsonvalueNode, nameof(jsonvalueNode), required: false);
            return new DeferredBodyAction<SingleThingRo[]>(() =>
            {
                var apiCallPath = "/api/things";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var json = new JObject();
                var jsonpropCount = 0;
                if (__workflow_jsonarray != null)
                {
                    json["array"] = ExpressionConverter.ConvertO(__workflow_jsonarray);
                    jsonpropCount++;
                }

                if (__workflow_jsonbigDecimal != null)
                {
                    json["bigDecimal"] = ExpressionConverter.ConvertO(__workflow_jsonbigDecimal);
                    jsonpropCount++;
                }

                if (__workflow_jsonbigInteger != null)
                {
                    json["bigInteger"] = ExpressionConverter.ConvertO(__workflow_jsonbigInteger);
                    jsonpropCount++;
                }

                if (__workflow_jsonbinary != null)
                {
                    json["binary"] = ExpressionConverter.ConvertO(__workflow_jsonbinary);
                    jsonpropCount++;
                }

                if (__workflow_jsonboolean != null)
                {
                    json["boolean"] = ExpressionConverter.ConvertO(__workflow_jsonboolean);
                    jsonpropCount++;
                }

                if (__workflow_jsoncontainerNode != null)
                {
                    json["containerNode"] = ExpressionConverter.ConvertO(__workflow_jsoncontainerNode);
                    jsonpropCount++;
                }

                if (__workflow_jsondouble != null)
                {
                    json["double"] = ExpressionConverter.ConvertO(__workflow_jsondouble);
                    jsonpropCount++;
                }

                if (__workflow_jsonfloat != null)
                {
                    json["float"] = ExpressionConverter.ConvertO(__workflow_jsonfloat);
                    jsonpropCount++;
                }

                if (__workflow_jsonfloatingPointNumber != null)
                {
                    json["floatingPointNumber"] = ExpressionConverter.ConvertO(__workflow_jsonfloatingPointNumber);
                    jsonpropCount++;
                }

                if (__workflow_jsonint != null)
                {
                    json["int"] = ExpressionConverter.ConvertO(__workflow_jsonint);
                    jsonpropCount++;
                }

                if (__workflow_jsonintegralNumber != null)
                {
                    json["integralNumber"] = ExpressionConverter.ConvertO(__workflow_jsonintegralNumber);
                    jsonpropCount++;
                }

                if (__workflow_jsonLong != null)
                {
                    json["long"] = ExpressionConverter.ConvertO(__workflow_jsonLong);
                    jsonpropCount++;
                }

                if (__workflow_jsonmissingNode != null)
                {
                    json["missingNode"] = ExpressionConverter.ConvertO(__workflow_jsonmissingNode);
                    jsonpropCount++;
                }

                if (__workflow_jsonnodeType != null)
                {
                    json["nodeType"] = ExpressionConverter.ConvertO(__workflow_jsonnodeType);
                    jsonpropCount++;
                }

                if (__workflow_jsonnull != null)
                {
                    json["null"] = ExpressionConverter.ConvertO(__workflow_jsonnull);
                    jsonpropCount++;
                }

                if (__workflow_jsonnumber != null)
                {
                    json["number"] = ExpressionConverter.ConvertO(__workflow_jsonnumber);
                    jsonpropCount++;
                }

                if (__workflow_jsonObject != null)
                {
                    json["object"] = ExpressionConverter.ConvertO(__workflow_jsonObject);
                    jsonpropCount++;
                }

                if (__workflow_jsonpojo != null)
                {
                    json["pojo"] = ExpressionConverter.ConvertO(__workflow_jsonpojo);
                    jsonpropCount++;
                }

                if (__workflow_jsonShort != null)
                {
                    json["short"] = ExpressionConverter.ConvertO(__workflow_jsonShort);
                    jsonpropCount++;
                }

                if (__workflow_jsontextual != null)
                {
                    json["textual"] = ExpressionConverter.ConvertO(__workflow_jsontextual);
                    jsonpropCount++;
                }

                if (__workflow_jsonvalueNode != null)
                {
                    json["valueNode"] = ExpressionConverter.ConvertO(__workflow_jsonvalueNode);
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
        public IBodyWorkflowAction<SingleThingRo[]> GetThingList(Expression<Func<string[]>> thingIds = null)
        {
            var __workflow_thingIds = thingIds == null ? null : WorkflowExpression.Compile(thingIds);
            WorkflowExpression.Validate(__workflow_thingIds, nameof(thingIds), required: false);
            return new DeferredBodyAction<SingleThingRo[]>(() =>
            {
                var apiCallPath = "/api/things/list";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_thingIds);
                return new ApiConnectionAction<SingleThingRo[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<SingleThingRo> GetThing(Expression<Func<string>> id, Expression<Func<bool>> detailed = null)
        {
            var __workflow_id = id == null ? null : WorkflowExpression.Compile(id);
            WorkflowExpression.Validate(__workflow_id, nameof(id), required: true);
            var __workflow_detailed = detailed == null ? null : WorkflowExpression.Compile(detailed);
            WorkflowExpression.Validate(__workflow_detailed, nameof(detailed), required: false);
            return new DeferredBodyAction<SingleThingRo>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/things/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["detailed"] = Convert.ToString(false);
                if (__workflow_detailed != null)
                    callPayload.Queries["detailed"] = ExpressionConverter.Convert(__workflow_detailed);
                return new ApiConnectionAction<SingleThingRo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IWorkflowAction IgnoreThing(Expression<Func<string>> id, Expression<Func<bool>> force = null)
        {
            var __workflow_id = id == null ? null : WorkflowExpression.Compile(id);
            WorkflowExpression.Validate(__workflow_id, nameof(id), required: true);
            var __workflow_force = force == null ? null : WorkflowExpression.Compile(force);
            WorkflowExpression.Validate(__workflow_force, nameof(force), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/things/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_force != null)
                    callPayload.Queries["force"] = ExpressionConverter.Convert(__workflow_force);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<ThingRo> PutThing(Expression<Func<string>> id, Expression<Func<string>> thingRoname, Expression<Func<string>> thingRositeaddress, Expression<Func<string>> thingRositecity, Expression<Func<string>> thingRositename, Expression<Func<string>> thingRositepostalCode, Expression<Func<string>> thingRoapplicationid = null, Expression<Func<string>> thingRoapplicationlink = null, Expression<Func<string>> thingRoapplicationname = null, Expression<Func<string>> thingRoconnectivityid = null, Expression<Func<string>> thingRoconnectivityrawStatus = null, Expression<Func<thingRoconnectivitystatusInput>> thingRoconnectivitystatus = null, Expression<Func<thingRoconnectivitytypeInput>> thingRoconnectivitytype = null, Expression<Func<CustomFieldRo[]>> thingRocustomFields = null, Expression<Func<string>> thingRocustomModelcolor = null, Expression<Func<string>> thingRocustomModelicon = null, Expression<Func<string>> thingRocustomModelid = null, Expression<Func<string>> thingRocustomModellink = null, Expression<Func<string>> thingRocustomModelname = null, Expression<Func<string>> thingRodescription = null, Expression<Func<int>> thingRodevicebatteryLevel = null, Expression<Func<thingRodevicebatteryStatusInput>> thingRodevicebatteryStatus = null, Expression<Func<string>> thingRodevicedeviceType = null, Expression<Func<string>> thingRodeviceid = null, Expression<Func<string>> thingRodevicemanufacturer = null, Expression<Func<int>> thingRodevicememoryFree = null, Expression<Func<int>> thingRodevicememoryTotal = null, Expression<Func<string>> thingRodevicemodel = null, Expression<Func<string>> thingRodevicemodelNumber = null, Expression<Func<string>> thingRodevicename = null, Expression<Func<string>> thingRodeviceserialNumber = null, Expression<Func<thingRodevicestatusInput>> thingRodevicestatus = null, Expression<Func<string>> thingRodisplayName = null, Expression<Func<bool>> thingRodynamicGps = null, Expression<Func<double>> thingRofixedLatitude = null, Expression<Func<double>> thingRofixedLongitude = null, Expression<Func<string>> thingRofixedName = null, Expression<Func<string>> thingRoid = null, Expression<Func<int>> thingRolastActivityDate = null, Expression<Func<double>> thingRolastLatitude = null, Expression<Func<double>> thingRolastLongitude = null, Expression<Func<bool>> thingRolastMeasurementsarray = null, Expression<Func<bool>> thingRolastMeasurementsbigDecimal = null, Expression<Func<bool>> thingRolastMeasurementsbigInteger = null, Expression<Func<bool>> thingRolastMeasurementsbinary = null, Expression<Func<bool>> thingRolastMeasurementsboolean = null, Expression<Func<bool>> thingRolastMeasurementscontainerNode = null, Expression<Func<bool>> thingRolastMeasurementsdouble = null, Expression<Func<bool>> thingRolastMeasurementsfloat = null, Expression<Func<bool>> thingRolastMeasurementsfloatingPointNumber = null, Expression<Func<bool>> thingRolastMeasurementsint = null, Expression<Func<bool>> thingRolastMeasurementsintegralNumber = null, Expression<Func<bool>> thingRolastMeasurementsLong = null, Expression<Func<bool>> thingRolastMeasurementsmissingNode = null, Expression<Func<thingRolastMeasurementsnodeTypeInput>> thingRolastMeasurementsnodeType = null, Expression<Func<bool>> thingRolastMeasurementsnull = null, Expression<Func<bool>> thingRolastMeasurementsnumber = null, Expression<Func<bool>> thingRolastMeasurementsObject = null, Expression<Func<bool>> thingRolastMeasurementspojo = null, Expression<Func<bool>> thingRolastMeasurementsShort = null, Expression<Func<bool>> thingRolastMeasurementstextual = null, Expression<Func<bool>> thingRolastMeasurementsvalueNode = null, Expression<Func<bool>> thingRolastMeasurementsTimestampsarray = null, Expression<Func<bool>> thingRolastMeasurementsTimestampsbigDecimal = null, Expression<Func<bool>> thingRolastMeasurementsTimestampsbigInteger = null, Expression<Func<bool>> thingRolastMeasurementsTimestampsbinary = null, Expression<Func<bool>> thingRolastMeasurementsTimestampsboolean = null, Expression<Func<bool>> thingRolastMeasurementsTimestampscontainerNode = null, Expression<Func<bool>> thingRolastMeasurementsTimestampsdouble = null, Expression<Func<bool>> thingRolastMeasurementsTimestampsfloat = null, Expression<Func<bool>> thingRolastMeasurementsTimestampsfloatingPointNumber = null, Expression<Func<bool>> thingRolastMeasurementsTimestampsint = null, Expression<Func<bool>> thingRolastMeasurementsTimestampsintegralNumber = null, Expression<Func<bool>> thingRolastMeasurementsTimestampsLong = null, Expression<Func<bool>> thingRolastMeasurementsTimestampsmissingNode = null, Expression<Func<thingRolastMeasurementsTimestampsnodeTypeInput>> thingRolastMeasurementsTimestampsnodeType = null, Expression<Func<bool>> thingRolastMeasurementsTimestampsnull = null, Expression<Func<bool>> thingRolastMeasurementsTimestampsnumber = null, Expression<Func<bool>> thingRolastMeasurementsTimestampsObject = null, Expression<Func<bool>> thingRolastMeasurementsTimestampspojo = null, Expression<Func<bool>> thingRolastMeasurementsTimestampsShort = null, Expression<Func<bool>> thingRolastMeasurementsTimestampstextual = null, Expression<Func<bool>> thingRolastMeasurementsTimestampsvalueNode = null, Expression<Func<int>> thingRolastMessageDate = null, Expression<Func<int>> thingRomessageActivityTimeoutPeriod = null, Expression<Func<int>> thingRonbAlerts = null, Expression<Func<thingRoproductconnectivityTypesInputItem[]>> thingRoproductconnectivityTypes = null, Expression<Func<bool>> thingRoproductgenerateLinks = null, Expression<Func<string>> thingRoproductid = null, Expression<Func<string>> thingRoproductlink = null, Expression<Func<bool>> thingRoproductmanufacturergenerateLinks = null, Expression<Func<string>> thingRoproductmanufacturerid = null, Expression<Func<string>> thingRoproductmanufacturerlink = null, Expression<Func<string>> thingRoproductmanufacturername = null, Expression<Func<string>> thingRoproductmodelcolor = null, Expression<Func<bool>> thingRoproductmodelgenerateLinks = null, Expression<Func<string>> thingRoproductmodelicon = null, Expression<Func<string>> thingRoproductmodelid = null, Expression<Func<bool>> thingRoproductmodelisCustomModel = null, Expression<Func<bool>> thingRoproductmodellinkabsolute = null, Expression<Func<string>> thingRoproductmodellinkauthority = null, Expression<Func<string>> thingRoproductmodellinkfragment = null, Expression<Func<string>> thingRoproductmodellinkhost = null, Expression<Func<bool>> thingRoproductmodellinkopaque = null, Expression<Func<string>> thingRoproductmodellinkpath = null, Expression<Func<int>> thingRoproductmodellinkport = null, Expression<Func<string>> thingRoproductmodellinkquery = null, Expression<Func<string>> thingRoproductmodellinkrawAuthority = null, Expression<Func<string>> thingRoproductmodellinkrawFragment = null, Expression<Func<string>> thingRoproductmodellinkrawPath = null, Expression<Func<string>> thingRoproductmodellinkrawQuery = null, Expression<Func<string>> thingRoproductmodellinkrawSchemeSpecificPart = null, Expression<Func<string>> thingRoproductmodellinkrawUserInfo = null, Expression<Func<string>> thingRoproductmodellinkscheme = null, Expression<Func<string>> thingRoproductmodellinkschemeSpecificPart = null, Expression<Func<string>> thingRoproductmodellinkuserInfo = null, Expression<Func<string>> thingRoproductmodelname = null, Expression<Func<string>> thingRoproductname = null, Expression<Func<string>> thingRoproductreference = null, Expression<Func<string>> thingRositeid = null, Expression<Func<double>> thingRositelatitude = null, Expression<Func<double>> thingRositelongitude = null, Expression<Func<string>> thingRosourceId = null, Expression<Func<thingRostatusInput>> thingRostatus = null, Expression<Func<ThingTagRo[]>> thingRotags = null)
        {
            var __workflow_id = id == null ? null : WorkflowExpression.Compile(id);
            WorkflowExpression.Validate(__workflow_id, nameof(id), required: true);
            var __workflow_thingRoname = thingRoname == null ? null : WorkflowExpression.Compile(thingRoname);
            WorkflowExpression.Validate(__workflow_thingRoname, nameof(thingRoname), required: true);
            var __workflow_thingRositeaddress = thingRositeaddress == null ? null : WorkflowExpression.Compile(thingRositeaddress);
            WorkflowExpression.Validate(__workflow_thingRositeaddress, nameof(thingRositeaddress), required: true);
            var __workflow_thingRositecity = thingRositecity == null ? null : WorkflowExpression.Compile(thingRositecity);
            WorkflowExpression.Validate(__workflow_thingRositecity, nameof(thingRositecity), required: true);
            var __workflow_thingRositename = thingRositename == null ? null : WorkflowExpression.Compile(thingRositename);
            WorkflowExpression.Validate(__workflow_thingRositename, nameof(thingRositename), required: true);
            var __workflow_thingRositepostalCode = thingRositepostalCode == null ? null : WorkflowExpression.Compile(thingRositepostalCode);
            WorkflowExpression.Validate(__workflow_thingRositepostalCode, nameof(thingRositepostalCode), required: true);
            var __workflow_thingRoapplicationid = thingRoapplicationid == null ? null : WorkflowExpression.Compile(thingRoapplicationid);
            WorkflowExpression.Validate(__workflow_thingRoapplicationid, nameof(thingRoapplicationid), required: false);
            var __workflow_thingRoapplicationlink = thingRoapplicationlink == null ? null : WorkflowExpression.Compile(thingRoapplicationlink);
            WorkflowExpression.Validate(__workflow_thingRoapplicationlink, nameof(thingRoapplicationlink), required: false);
            var __workflow_thingRoapplicationname = thingRoapplicationname == null ? null : WorkflowExpression.Compile(thingRoapplicationname);
            WorkflowExpression.Validate(__workflow_thingRoapplicationname, nameof(thingRoapplicationname), required: false);
            var __workflow_thingRoconnectivityid = thingRoconnectivityid == null ? null : WorkflowExpression.Compile(thingRoconnectivityid);
            WorkflowExpression.Validate(__workflow_thingRoconnectivityid, nameof(thingRoconnectivityid), required: false);
            var __workflow_thingRoconnectivityrawStatus = thingRoconnectivityrawStatus == null ? null : WorkflowExpression.Compile(thingRoconnectivityrawStatus);
            WorkflowExpression.Validate(__workflow_thingRoconnectivityrawStatus, nameof(thingRoconnectivityrawStatus), required: false);
            var __workflow_thingRoconnectivitystatus = thingRoconnectivitystatus == null ? null : WorkflowExpression.Compile(thingRoconnectivitystatus);
            WorkflowExpression.Validate(__workflow_thingRoconnectivitystatus, nameof(thingRoconnectivitystatus), required: false);
            var __workflow_thingRoconnectivitytype = thingRoconnectivitytype == null ? null : WorkflowExpression.Compile(thingRoconnectivitytype);
            WorkflowExpression.Validate(__workflow_thingRoconnectivitytype, nameof(thingRoconnectivitytype), required: false);
            var __workflow_thingRocustomFields = thingRocustomFields == null ? null : WorkflowExpression.Compile(thingRocustomFields);
            WorkflowExpression.Validate(__workflow_thingRocustomFields, nameof(thingRocustomFields), required: false);
            var __workflow_thingRocustomModelcolor = thingRocustomModelcolor == null ? null : WorkflowExpression.Compile(thingRocustomModelcolor);
            WorkflowExpression.Validate(__workflow_thingRocustomModelcolor, nameof(thingRocustomModelcolor), required: false);
            var __workflow_thingRocustomModelicon = thingRocustomModelicon == null ? null : WorkflowExpression.Compile(thingRocustomModelicon);
            WorkflowExpression.Validate(__workflow_thingRocustomModelicon, nameof(thingRocustomModelicon), required: false);
            var __workflow_thingRocustomModelid = thingRocustomModelid == null ? null : WorkflowExpression.Compile(thingRocustomModelid);
            WorkflowExpression.Validate(__workflow_thingRocustomModelid, nameof(thingRocustomModelid), required: false);
            var __workflow_thingRocustomModellink = thingRocustomModellink == null ? null : WorkflowExpression.Compile(thingRocustomModellink);
            WorkflowExpression.Validate(__workflow_thingRocustomModellink, nameof(thingRocustomModellink), required: false);
            var __workflow_thingRocustomModelname = thingRocustomModelname == null ? null : WorkflowExpression.Compile(thingRocustomModelname);
            WorkflowExpression.Validate(__workflow_thingRocustomModelname, nameof(thingRocustomModelname), required: false);
            var __workflow_thingRodescription = thingRodescription == null ? null : WorkflowExpression.Compile(thingRodescription);
            WorkflowExpression.Validate(__workflow_thingRodescription, nameof(thingRodescription), required: false);
            var __workflow_thingRodevicebatteryLevel = thingRodevicebatteryLevel == null ? null : WorkflowExpression.Compile(thingRodevicebatteryLevel);
            WorkflowExpression.Validate(__workflow_thingRodevicebatteryLevel, nameof(thingRodevicebatteryLevel), required: false);
            var __workflow_thingRodevicebatteryStatus = thingRodevicebatteryStatus == null ? null : WorkflowExpression.Compile(thingRodevicebatteryStatus);
            WorkflowExpression.Validate(__workflow_thingRodevicebatteryStatus, nameof(thingRodevicebatteryStatus), required: false);
            var __workflow_thingRodevicedeviceType = thingRodevicedeviceType == null ? null : WorkflowExpression.Compile(thingRodevicedeviceType);
            WorkflowExpression.Validate(__workflow_thingRodevicedeviceType, nameof(thingRodevicedeviceType), required: false);
            var __workflow_thingRodeviceid = thingRodeviceid == null ? null : WorkflowExpression.Compile(thingRodeviceid);
            WorkflowExpression.Validate(__workflow_thingRodeviceid, nameof(thingRodeviceid), required: false);
            var __workflow_thingRodevicemanufacturer = thingRodevicemanufacturer == null ? null : WorkflowExpression.Compile(thingRodevicemanufacturer);
            WorkflowExpression.Validate(__workflow_thingRodevicemanufacturer, nameof(thingRodevicemanufacturer), required: false);
            var __workflow_thingRodevicememoryFree = thingRodevicememoryFree == null ? null : WorkflowExpression.Compile(thingRodevicememoryFree);
            WorkflowExpression.Validate(__workflow_thingRodevicememoryFree, nameof(thingRodevicememoryFree), required: false);
            var __workflow_thingRodevicememoryTotal = thingRodevicememoryTotal == null ? null : WorkflowExpression.Compile(thingRodevicememoryTotal);
            WorkflowExpression.Validate(__workflow_thingRodevicememoryTotal, nameof(thingRodevicememoryTotal), required: false);
            var __workflow_thingRodevicemodel = thingRodevicemodel == null ? null : WorkflowExpression.Compile(thingRodevicemodel);
            WorkflowExpression.Validate(__workflow_thingRodevicemodel, nameof(thingRodevicemodel), required: false);
            var __workflow_thingRodevicemodelNumber = thingRodevicemodelNumber == null ? null : WorkflowExpression.Compile(thingRodevicemodelNumber);
            WorkflowExpression.Validate(__workflow_thingRodevicemodelNumber, nameof(thingRodevicemodelNumber), required: false);
            var __workflow_thingRodevicename = thingRodevicename == null ? null : WorkflowExpression.Compile(thingRodevicename);
            WorkflowExpression.Validate(__workflow_thingRodevicename, nameof(thingRodevicename), required: false);
            var __workflow_thingRodeviceserialNumber = thingRodeviceserialNumber == null ? null : WorkflowExpression.Compile(thingRodeviceserialNumber);
            WorkflowExpression.Validate(__workflow_thingRodeviceserialNumber, nameof(thingRodeviceserialNumber), required: false);
            var __workflow_thingRodevicestatus = thingRodevicestatus == null ? null : WorkflowExpression.Compile(thingRodevicestatus);
            WorkflowExpression.Validate(__workflow_thingRodevicestatus, nameof(thingRodevicestatus), required: false);
            var __workflow_thingRodisplayName = thingRodisplayName == null ? null : WorkflowExpression.Compile(thingRodisplayName);
            WorkflowExpression.Validate(__workflow_thingRodisplayName, nameof(thingRodisplayName), required: false);
            var __workflow_thingRodynamicGps = thingRodynamicGps == null ? null : WorkflowExpression.Compile(thingRodynamicGps);
            WorkflowExpression.Validate(__workflow_thingRodynamicGps, nameof(thingRodynamicGps), required: false);
            var __workflow_thingRofixedLatitude = thingRofixedLatitude == null ? null : WorkflowExpression.Compile(thingRofixedLatitude);
            WorkflowExpression.Validate(__workflow_thingRofixedLatitude, nameof(thingRofixedLatitude), required: false);
            var __workflow_thingRofixedLongitude = thingRofixedLongitude == null ? null : WorkflowExpression.Compile(thingRofixedLongitude);
            WorkflowExpression.Validate(__workflow_thingRofixedLongitude, nameof(thingRofixedLongitude), required: false);
            var __workflow_thingRofixedName = thingRofixedName == null ? null : WorkflowExpression.Compile(thingRofixedName);
            WorkflowExpression.Validate(__workflow_thingRofixedName, nameof(thingRofixedName), required: false);
            var __workflow_thingRoid = thingRoid == null ? null : WorkflowExpression.Compile(thingRoid);
            WorkflowExpression.Validate(__workflow_thingRoid, nameof(thingRoid), required: false);
            var __workflow_thingRolastActivityDate = thingRolastActivityDate == null ? null : WorkflowExpression.Compile(thingRolastActivityDate);
            WorkflowExpression.Validate(__workflow_thingRolastActivityDate, nameof(thingRolastActivityDate), required: false);
            var __workflow_thingRolastLatitude = thingRolastLatitude == null ? null : WorkflowExpression.Compile(thingRolastLatitude);
            WorkflowExpression.Validate(__workflow_thingRolastLatitude, nameof(thingRolastLatitude), required: false);
            var __workflow_thingRolastLongitude = thingRolastLongitude == null ? null : WorkflowExpression.Compile(thingRolastLongitude);
            WorkflowExpression.Validate(__workflow_thingRolastLongitude, nameof(thingRolastLongitude), required: false);
            var __workflow_thingRolastMeasurementsarray = thingRolastMeasurementsarray == null ? null : WorkflowExpression.Compile(thingRolastMeasurementsarray);
            WorkflowExpression.Validate(__workflow_thingRolastMeasurementsarray, nameof(thingRolastMeasurementsarray), required: false);
            var __workflow_thingRolastMeasurementsbigDecimal = thingRolastMeasurementsbigDecimal == null ? null : WorkflowExpression.Compile(thingRolastMeasurementsbigDecimal);
            WorkflowExpression.Validate(__workflow_thingRolastMeasurementsbigDecimal, nameof(thingRolastMeasurementsbigDecimal), required: false);
            var __workflow_thingRolastMeasurementsbigInteger = thingRolastMeasurementsbigInteger == null ? null : WorkflowExpression.Compile(thingRolastMeasurementsbigInteger);
            WorkflowExpression.Validate(__workflow_thingRolastMeasurementsbigInteger, nameof(thingRolastMeasurementsbigInteger), required: false);
            var __workflow_thingRolastMeasurementsbinary = thingRolastMeasurementsbinary == null ? null : WorkflowExpression.Compile(thingRolastMeasurementsbinary);
            WorkflowExpression.Validate(__workflow_thingRolastMeasurementsbinary, nameof(thingRolastMeasurementsbinary), required: false);
            var __workflow_thingRolastMeasurementsboolean = thingRolastMeasurementsboolean == null ? null : WorkflowExpression.Compile(thingRolastMeasurementsboolean);
            WorkflowExpression.Validate(__workflow_thingRolastMeasurementsboolean, nameof(thingRolastMeasurementsboolean), required: false);
            var __workflow_thingRolastMeasurementscontainerNode = thingRolastMeasurementscontainerNode == null ? null : WorkflowExpression.Compile(thingRolastMeasurementscontainerNode);
            WorkflowExpression.Validate(__workflow_thingRolastMeasurementscontainerNode, nameof(thingRolastMeasurementscontainerNode), required: false);
            var __workflow_thingRolastMeasurementsdouble = thingRolastMeasurementsdouble == null ? null : WorkflowExpression.Compile(thingRolastMeasurementsdouble);
            WorkflowExpression.Validate(__workflow_thingRolastMeasurementsdouble, nameof(thingRolastMeasurementsdouble), required: false);
            var __workflow_thingRolastMeasurementsfloat = thingRolastMeasurementsfloat == null ? null : WorkflowExpression.Compile(thingRolastMeasurementsfloat);
            WorkflowExpression.Validate(__workflow_thingRolastMeasurementsfloat, nameof(thingRolastMeasurementsfloat), required: false);
            var __workflow_thingRolastMeasurementsfloatingPointNumber = thingRolastMeasurementsfloatingPointNumber == null ? null : WorkflowExpression.Compile(thingRolastMeasurementsfloatingPointNumber);
            WorkflowExpression.Validate(__workflow_thingRolastMeasurementsfloatingPointNumber, nameof(thingRolastMeasurementsfloatingPointNumber), required: false);
            var __workflow_thingRolastMeasurementsint = thingRolastMeasurementsint == null ? null : WorkflowExpression.Compile(thingRolastMeasurementsint);
            WorkflowExpression.Validate(__workflow_thingRolastMeasurementsint, nameof(thingRolastMeasurementsint), required: false);
            var __workflow_thingRolastMeasurementsintegralNumber = thingRolastMeasurementsintegralNumber == null ? null : WorkflowExpression.Compile(thingRolastMeasurementsintegralNumber);
            WorkflowExpression.Validate(__workflow_thingRolastMeasurementsintegralNumber, nameof(thingRolastMeasurementsintegralNumber), required: false);
            var __workflow_thingRolastMeasurementsLong = thingRolastMeasurementsLong == null ? null : WorkflowExpression.Compile(thingRolastMeasurementsLong);
            WorkflowExpression.Validate(__workflow_thingRolastMeasurementsLong, nameof(thingRolastMeasurementsLong), required: false);
            var __workflow_thingRolastMeasurementsmissingNode = thingRolastMeasurementsmissingNode == null ? null : WorkflowExpression.Compile(thingRolastMeasurementsmissingNode);
            WorkflowExpression.Validate(__workflow_thingRolastMeasurementsmissingNode, nameof(thingRolastMeasurementsmissingNode), required: false);
            var __workflow_thingRolastMeasurementsnodeType = thingRolastMeasurementsnodeType == null ? null : WorkflowExpression.Compile(thingRolastMeasurementsnodeType);
            WorkflowExpression.Validate(__workflow_thingRolastMeasurementsnodeType, nameof(thingRolastMeasurementsnodeType), required: false);
            var __workflow_thingRolastMeasurementsnull = thingRolastMeasurementsnull == null ? null : WorkflowExpression.Compile(thingRolastMeasurementsnull);
            WorkflowExpression.Validate(__workflow_thingRolastMeasurementsnull, nameof(thingRolastMeasurementsnull), required: false);
            var __workflow_thingRolastMeasurementsnumber = thingRolastMeasurementsnumber == null ? null : WorkflowExpression.Compile(thingRolastMeasurementsnumber);
            WorkflowExpression.Validate(__workflow_thingRolastMeasurementsnumber, nameof(thingRolastMeasurementsnumber), required: false);
            var __workflow_thingRolastMeasurementsObject = thingRolastMeasurementsObject == null ? null : WorkflowExpression.Compile(thingRolastMeasurementsObject);
            WorkflowExpression.Validate(__workflow_thingRolastMeasurementsObject, nameof(thingRolastMeasurementsObject), required: false);
            var __workflow_thingRolastMeasurementspojo = thingRolastMeasurementspojo == null ? null : WorkflowExpression.Compile(thingRolastMeasurementspojo);
            WorkflowExpression.Validate(__workflow_thingRolastMeasurementspojo, nameof(thingRolastMeasurementspojo), required: false);
            var __workflow_thingRolastMeasurementsShort = thingRolastMeasurementsShort == null ? null : WorkflowExpression.Compile(thingRolastMeasurementsShort);
            WorkflowExpression.Validate(__workflow_thingRolastMeasurementsShort, nameof(thingRolastMeasurementsShort), required: false);
            var __workflow_thingRolastMeasurementstextual = thingRolastMeasurementstextual == null ? null : WorkflowExpression.Compile(thingRolastMeasurementstextual);
            WorkflowExpression.Validate(__workflow_thingRolastMeasurementstextual, nameof(thingRolastMeasurementstextual), required: false);
            var __workflow_thingRolastMeasurementsvalueNode = thingRolastMeasurementsvalueNode == null ? null : WorkflowExpression.Compile(thingRolastMeasurementsvalueNode);
            WorkflowExpression.Validate(__workflow_thingRolastMeasurementsvalueNode, nameof(thingRolastMeasurementsvalueNode), required: false);
            var __workflow_thingRolastMeasurementsTimestampsarray = thingRolastMeasurementsTimestampsarray == null ? null : WorkflowExpression.Compile(thingRolastMeasurementsTimestampsarray);
            WorkflowExpression.Validate(__workflow_thingRolastMeasurementsTimestampsarray, nameof(thingRolastMeasurementsTimestampsarray), required: false);
            var __workflow_thingRolastMeasurementsTimestampsbigDecimal = thingRolastMeasurementsTimestampsbigDecimal == null ? null : WorkflowExpression.Compile(thingRolastMeasurementsTimestampsbigDecimal);
            WorkflowExpression.Validate(__workflow_thingRolastMeasurementsTimestampsbigDecimal, nameof(thingRolastMeasurementsTimestampsbigDecimal), required: false);
            var __workflow_thingRolastMeasurementsTimestampsbigInteger = thingRolastMeasurementsTimestampsbigInteger == null ? null : WorkflowExpression.Compile(thingRolastMeasurementsTimestampsbigInteger);
            WorkflowExpression.Validate(__workflow_thingRolastMeasurementsTimestampsbigInteger, nameof(thingRolastMeasurementsTimestampsbigInteger), required: false);
            var __workflow_thingRolastMeasurementsTimestampsbinary = thingRolastMeasurementsTimestampsbinary == null ? null : WorkflowExpression.Compile(thingRolastMeasurementsTimestampsbinary);
            WorkflowExpression.Validate(__workflow_thingRolastMeasurementsTimestampsbinary, nameof(thingRolastMeasurementsTimestampsbinary), required: false);
            var __workflow_thingRolastMeasurementsTimestampsboolean = thingRolastMeasurementsTimestampsboolean == null ? null : WorkflowExpression.Compile(thingRolastMeasurementsTimestampsboolean);
            WorkflowExpression.Validate(__workflow_thingRolastMeasurementsTimestampsboolean, nameof(thingRolastMeasurementsTimestampsboolean), required: false);
            var __workflow_thingRolastMeasurementsTimestampscontainerNode = thingRolastMeasurementsTimestampscontainerNode == null ? null : WorkflowExpression.Compile(thingRolastMeasurementsTimestampscontainerNode);
            WorkflowExpression.Validate(__workflow_thingRolastMeasurementsTimestampscontainerNode, nameof(thingRolastMeasurementsTimestampscontainerNode), required: false);
            var __workflow_thingRolastMeasurementsTimestampsdouble = thingRolastMeasurementsTimestampsdouble == null ? null : WorkflowExpression.Compile(thingRolastMeasurementsTimestampsdouble);
            WorkflowExpression.Validate(__workflow_thingRolastMeasurementsTimestampsdouble, nameof(thingRolastMeasurementsTimestampsdouble), required: false);
            var __workflow_thingRolastMeasurementsTimestampsfloat = thingRolastMeasurementsTimestampsfloat == null ? null : WorkflowExpression.Compile(thingRolastMeasurementsTimestampsfloat);
            WorkflowExpression.Validate(__workflow_thingRolastMeasurementsTimestampsfloat, nameof(thingRolastMeasurementsTimestampsfloat), required: false);
            var __workflow_thingRolastMeasurementsTimestampsfloatingPointNumber = thingRolastMeasurementsTimestampsfloatingPointNumber == null ? null : WorkflowExpression.Compile(thingRolastMeasurementsTimestampsfloatingPointNumber);
            WorkflowExpression.Validate(__workflow_thingRolastMeasurementsTimestampsfloatingPointNumber, nameof(thingRolastMeasurementsTimestampsfloatingPointNumber), required: false);
            var __workflow_thingRolastMeasurementsTimestampsint = thingRolastMeasurementsTimestampsint == null ? null : WorkflowExpression.Compile(thingRolastMeasurementsTimestampsint);
            WorkflowExpression.Validate(__workflow_thingRolastMeasurementsTimestampsint, nameof(thingRolastMeasurementsTimestampsint), required: false);
            var __workflow_thingRolastMeasurementsTimestampsintegralNumber = thingRolastMeasurementsTimestampsintegralNumber == null ? null : WorkflowExpression.Compile(thingRolastMeasurementsTimestampsintegralNumber);
            WorkflowExpression.Validate(__workflow_thingRolastMeasurementsTimestampsintegralNumber, nameof(thingRolastMeasurementsTimestampsintegralNumber), required: false);
            var __workflow_thingRolastMeasurementsTimestampsLong = thingRolastMeasurementsTimestampsLong == null ? null : WorkflowExpression.Compile(thingRolastMeasurementsTimestampsLong);
            WorkflowExpression.Validate(__workflow_thingRolastMeasurementsTimestampsLong, nameof(thingRolastMeasurementsTimestampsLong), required: false);
            var __workflow_thingRolastMeasurementsTimestampsmissingNode = thingRolastMeasurementsTimestampsmissingNode == null ? null : WorkflowExpression.Compile(thingRolastMeasurementsTimestampsmissingNode);
            WorkflowExpression.Validate(__workflow_thingRolastMeasurementsTimestampsmissingNode, nameof(thingRolastMeasurementsTimestampsmissingNode), required: false);
            var __workflow_thingRolastMeasurementsTimestampsnodeType = thingRolastMeasurementsTimestampsnodeType == null ? null : WorkflowExpression.Compile(thingRolastMeasurementsTimestampsnodeType);
            WorkflowExpression.Validate(__workflow_thingRolastMeasurementsTimestampsnodeType, nameof(thingRolastMeasurementsTimestampsnodeType), required: false);
            var __workflow_thingRolastMeasurementsTimestampsnull = thingRolastMeasurementsTimestampsnull == null ? null : WorkflowExpression.Compile(thingRolastMeasurementsTimestampsnull);
            WorkflowExpression.Validate(__workflow_thingRolastMeasurementsTimestampsnull, nameof(thingRolastMeasurementsTimestampsnull), required: false);
            var __workflow_thingRolastMeasurementsTimestampsnumber = thingRolastMeasurementsTimestampsnumber == null ? null : WorkflowExpression.Compile(thingRolastMeasurementsTimestampsnumber);
            WorkflowExpression.Validate(__workflow_thingRolastMeasurementsTimestampsnumber, nameof(thingRolastMeasurementsTimestampsnumber), required: false);
            var __workflow_thingRolastMeasurementsTimestampsObject = thingRolastMeasurementsTimestampsObject == null ? null : WorkflowExpression.Compile(thingRolastMeasurementsTimestampsObject);
            WorkflowExpression.Validate(__workflow_thingRolastMeasurementsTimestampsObject, nameof(thingRolastMeasurementsTimestampsObject), required: false);
            var __workflow_thingRolastMeasurementsTimestampspojo = thingRolastMeasurementsTimestampspojo == null ? null : WorkflowExpression.Compile(thingRolastMeasurementsTimestampspojo);
            WorkflowExpression.Validate(__workflow_thingRolastMeasurementsTimestampspojo, nameof(thingRolastMeasurementsTimestampspojo), required: false);
            var __workflow_thingRolastMeasurementsTimestampsShort = thingRolastMeasurementsTimestampsShort == null ? null : WorkflowExpression.Compile(thingRolastMeasurementsTimestampsShort);
            WorkflowExpression.Validate(__workflow_thingRolastMeasurementsTimestampsShort, nameof(thingRolastMeasurementsTimestampsShort), required: false);
            var __workflow_thingRolastMeasurementsTimestampstextual = thingRolastMeasurementsTimestampstextual == null ? null : WorkflowExpression.Compile(thingRolastMeasurementsTimestampstextual);
            WorkflowExpression.Validate(__workflow_thingRolastMeasurementsTimestampstextual, nameof(thingRolastMeasurementsTimestampstextual), required: false);
            var __workflow_thingRolastMeasurementsTimestampsvalueNode = thingRolastMeasurementsTimestampsvalueNode == null ? null : WorkflowExpression.Compile(thingRolastMeasurementsTimestampsvalueNode);
            WorkflowExpression.Validate(__workflow_thingRolastMeasurementsTimestampsvalueNode, nameof(thingRolastMeasurementsTimestampsvalueNode), required: false);
            var __workflow_thingRolastMessageDate = thingRolastMessageDate == null ? null : WorkflowExpression.Compile(thingRolastMessageDate);
            WorkflowExpression.Validate(__workflow_thingRolastMessageDate, nameof(thingRolastMessageDate), required: false);
            var __workflow_thingRomessageActivityTimeoutPeriod = thingRomessageActivityTimeoutPeriod == null ? null : WorkflowExpression.Compile(thingRomessageActivityTimeoutPeriod);
            WorkflowExpression.Validate(__workflow_thingRomessageActivityTimeoutPeriod, nameof(thingRomessageActivityTimeoutPeriod), required: false);
            var __workflow_thingRonbAlerts = thingRonbAlerts == null ? null : WorkflowExpression.Compile(thingRonbAlerts);
            WorkflowExpression.Validate(__workflow_thingRonbAlerts, nameof(thingRonbAlerts), required: false);
            var __workflow_thingRoproductconnectivityTypes = thingRoproductconnectivityTypes == null ? null : WorkflowExpression.Compile(thingRoproductconnectivityTypes);
            WorkflowExpression.Validate(__workflow_thingRoproductconnectivityTypes, nameof(thingRoproductconnectivityTypes), required: false);
            var __workflow_thingRoproductgenerateLinks = thingRoproductgenerateLinks == null ? null : WorkflowExpression.Compile(thingRoproductgenerateLinks);
            WorkflowExpression.Validate(__workflow_thingRoproductgenerateLinks, nameof(thingRoproductgenerateLinks), required: false);
            var __workflow_thingRoproductid = thingRoproductid == null ? null : WorkflowExpression.Compile(thingRoproductid);
            WorkflowExpression.Validate(__workflow_thingRoproductid, nameof(thingRoproductid), required: false);
            var __workflow_thingRoproductlink = thingRoproductlink == null ? null : WorkflowExpression.Compile(thingRoproductlink);
            WorkflowExpression.Validate(__workflow_thingRoproductlink, nameof(thingRoproductlink), required: false);
            var __workflow_thingRoproductmanufacturergenerateLinks = thingRoproductmanufacturergenerateLinks == null ? null : WorkflowExpression.Compile(thingRoproductmanufacturergenerateLinks);
            WorkflowExpression.Validate(__workflow_thingRoproductmanufacturergenerateLinks, nameof(thingRoproductmanufacturergenerateLinks), required: false);
            var __workflow_thingRoproductmanufacturerid = thingRoproductmanufacturerid == null ? null : WorkflowExpression.Compile(thingRoproductmanufacturerid);
            WorkflowExpression.Validate(__workflow_thingRoproductmanufacturerid, nameof(thingRoproductmanufacturerid), required: false);
            var __workflow_thingRoproductmanufacturerlink = thingRoproductmanufacturerlink == null ? null : WorkflowExpression.Compile(thingRoproductmanufacturerlink);
            WorkflowExpression.Validate(__workflow_thingRoproductmanufacturerlink, nameof(thingRoproductmanufacturerlink), required: false);
            var __workflow_thingRoproductmanufacturername = thingRoproductmanufacturername == null ? null : WorkflowExpression.Compile(thingRoproductmanufacturername);
            WorkflowExpression.Validate(__workflow_thingRoproductmanufacturername, nameof(thingRoproductmanufacturername), required: false);
            var __workflow_thingRoproductmodelcolor = thingRoproductmodelcolor == null ? null : WorkflowExpression.Compile(thingRoproductmodelcolor);
            WorkflowExpression.Validate(__workflow_thingRoproductmodelcolor, nameof(thingRoproductmodelcolor), required: false);
            var __workflow_thingRoproductmodelgenerateLinks = thingRoproductmodelgenerateLinks == null ? null : WorkflowExpression.Compile(thingRoproductmodelgenerateLinks);
            WorkflowExpression.Validate(__workflow_thingRoproductmodelgenerateLinks, nameof(thingRoproductmodelgenerateLinks), required: false);
            var __workflow_thingRoproductmodelicon = thingRoproductmodelicon == null ? null : WorkflowExpression.Compile(thingRoproductmodelicon);
            WorkflowExpression.Validate(__workflow_thingRoproductmodelicon, nameof(thingRoproductmodelicon), required: false);
            var __workflow_thingRoproductmodelid = thingRoproductmodelid == null ? null : WorkflowExpression.Compile(thingRoproductmodelid);
            WorkflowExpression.Validate(__workflow_thingRoproductmodelid, nameof(thingRoproductmodelid), required: false);
            var __workflow_thingRoproductmodelisCustomModel = thingRoproductmodelisCustomModel == null ? null : WorkflowExpression.Compile(thingRoproductmodelisCustomModel);
            WorkflowExpression.Validate(__workflow_thingRoproductmodelisCustomModel, nameof(thingRoproductmodelisCustomModel), required: false);
            var __workflow_thingRoproductmodellinkabsolute = thingRoproductmodellinkabsolute == null ? null : WorkflowExpression.Compile(thingRoproductmodellinkabsolute);
            WorkflowExpression.Validate(__workflow_thingRoproductmodellinkabsolute, nameof(thingRoproductmodellinkabsolute), required: false);
            var __workflow_thingRoproductmodellinkauthority = thingRoproductmodellinkauthority == null ? null : WorkflowExpression.Compile(thingRoproductmodellinkauthority);
            WorkflowExpression.Validate(__workflow_thingRoproductmodellinkauthority, nameof(thingRoproductmodellinkauthority), required: false);
            var __workflow_thingRoproductmodellinkfragment = thingRoproductmodellinkfragment == null ? null : WorkflowExpression.Compile(thingRoproductmodellinkfragment);
            WorkflowExpression.Validate(__workflow_thingRoproductmodellinkfragment, nameof(thingRoproductmodellinkfragment), required: false);
            var __workflow_thingRoproductmodellinkhost = thingRoproductmodellinkhost == null ? null : WorkflowExpression.Compile(thingRoproductmodellinkhost);
            WorkflowExpression.Validate(__workflow_thingRoproductmodellinkhost, nameof(thingRoproductmodellinkhost), required: false);
            var __workflow_thingRoproductmodellinkopaque = thingRoproductmodellinkopaque == null ? null : WorkflowExpression.Compile(thingRoproductmodellinkopaque);
            WorkflowExpression.Validate(__workflow_thingRoproductmodellinkopaque, nameof(thingRoproductmodellinkopaque), required: false);
            var __workflow_thingRoproductmodellinkpath = thingRoproductmodellinkpath == null ? null : WorkflowExpression.Compile(thingRoproductmodellinkpath);
            WorkflowExpression.Validate(__workflow_thingRoproductmodellinkpath, nameof(thingRoproductmodellinkpath), required: false);
            var __workflow_thingRoproductmodellinkport = thingRoproductmodellinkport == null ? null : WorkflowExpression.Compile(thingRoproductmodellinkport);
            WorkflowExpression.Validate(__workflow_thingRoproductmodellinkport, nameof(thingRoproductmodellinkport), required: false);
            var __workflow_thingRoproductmodellinkquery = thingRoproductmodellinkquery == null ? null : WorkflowExpression.Compile(thingRoproductmodellinkquery);
            WorkflowExpression.Validate(__workflow_thingRoproductmodellinkquery, nameof(thingRoproductmodellinkquery), required: false);
            var __workflow_thingRoproductmodellinkrawAuthority = thingRoproductmodellinkrawAuthority == null ? null : WorkflowExpression.Compile(thingRoproductmodellinkrawAuthority);
            WorkflowExpression.Validate(__workflow_thingRoproductmodellinkrawAuthority, nameof(thingRoproductmodellinkrawAuthority), required: false);
            var __workflow_thingRoproductmodellinkrawFragment = thingRoproductmodellinkrawFragment == null ? null : WorkflowExpression.Compile(thingRoproductmodellinkrawFragment);
            WorkflowExpression.Validate(__workflow_thingRoproductmodellinkrawFragment, nameof(thingRoproductmodellinkrawFragment), required: false);
            var __workflow_thingRoproductmodellinkrawPath = thingRoproductmodellinkrawPath == null ? null : WorkflowExpression.Compile(thingRoproductmodellinkrawPath);
            WorkflowExpression.Validate(__workflow_thingRoproductmodellinkrawPath, nameof(thingRoproductmodellinkrawPath), required: false);
            var __workflow_thingRoproductmodellinkrawQuery = thingRoproductmodellinkrawQuery == null ? null : WorkflowExpression.Compile(thingRoproductmodellinkrawQuery);
            WorkflowExpression.Validate(__workflow_thingRoproductmodellinkrawQuery, nameof(thingRoproductmodellinkrawQuery), required: false);
            var __workflow_thingRoproductmodellinkrawSchemeSpecificPart = thingRoproductmodellinkrawSchemeSpecificPart == null ? null : WorkflowExpression.Compile(thingRoproductmodellinkrawSchemeSpecificPart);
            WorkflowExpression.Validate(__workflow_thingRoproductmodellinkrawSchemeSpecificPart, nameof(thingRoproductmodellinkrawSchemeSpecificPart), required: false);
            var __workflow_thingRoproductmodellinkrawUserInfo = thingRoproductmodellinkrawUserInfo == null ? null : WorkflowExpression.Compile(thingRoproductmodellinkrawUserInfo);
            WorkflowExpression.Validate(__workflow_thingRoproductmodellinkrawUserInfo, nameof(thingRoproductmodellinkrawUserInfo), required: false);
            var __workflow_thingRoproductmodellinkscheme = thingRoproductmodellinkscheme == null ? null : WorkflowExpression.Compile(thingRoproductmodellinkscheme);
            WorkflowExpression.Validate(__workflow_thingRoproductmodellinkscheme, nameof(thingRoproductmodellinkscheme), required: false);
            var __workflow_thingRoproductmodellinkschemeSpecificPart = thingRoproductmodellinkschemeSpecificPart == null ? null : WorkflowExpression.Compile(thingRoproductmodellinkschemeSpecificPart);
            WorkflowExpression.Validate(__workflow_thingRoproductmodellinkschemeSpecificPart, nameof(thingRoproductmodellinkschemeSpecificPart), required: false);
            var __workflow_thingRoproductmodellinkuserInfo = thingRoproductmodellinkuserInfo == null ? null : WorkflowExpression.Compile(thingRoproductmodellinkuserInfo);
            WorkflowExpression.Validate(__workflow_thingRoproductmodellinkuserInfo, nameof(thingRoproductmodellinkuserInfo), required: false);
            var __workflow_thingRoproductmodelname = thingRoproductmodelname == null ? null : WorkflowExpression.Compile(thingRoproductmodelname);
            WorkflowExpression.Validate(__workflow_thingRoproductmodelname, nameof(thingRoproductmodelname), required: false);
            var __workflow_thingRoproductname = thingRoproductname == null ? null : WorkflowExpression.Compile(thingRoproductname);
            WorkflowExpression.Validate(__workflow_thingRoproductname, nameof(thingRoproductname), required: false);
            var __workflow_thingRoproductreference = thingRoproductreference == null ? null : WorkflowExpression.Compile(thingRoproductreference);
            WorkflowExpression.Validate(__workflow_thingRoproductreference, nameof(thingRoproductreference), required: false);
            var __workflow_thingRositeid = thingRositeid == null ? null : WorkflowExpression.Compile(thingRositeid);
            WorkflowExpression.Validate(__workflow_thingRositeid, nameof(thingRositeid), required: false);
            var __workflow_thingRositelatitude = thingRositelatitude == null ? null : WorkflowExpression.Compile(thingRositelatitude);
            WorkflowExpression.Validate(__workflow_thingRositelatitude, nameof(thingRositelatitude), required: false);
            var __workflow_thingRositelongitude = thingRositelongitude == null ? null : WorkflowExpression.Compile(thingRositelongitude);
            WorkflowExpression.Validate(__workflow_thingRositelongitude, nameof(thingRositelongitude), required: false);
            var __workflow_thingRosourceId = thingRosourceId == null ? null : WorkflowExpression.Compile(thingRosourceId);
            WorkflowExpression.Validate(__workflow_thingRosourceId, nameof(thingRosourceId), required: false);
            var __workflow_thingRostatus = thingRostatus == null ? null : WorkflowExpression.Compile(thingRostatus);
            WorkflowExpression.Validate(__workflow_thingRostatus, nameof(thingRostatus), required: false);
            var __workflow_thingRotags = thingRotags == null ? null : WorkflowExpression.Compile(thingRotags);
            WorkflowExpression.Validate(__workflow_thingRotags, nameof(thingRotags), required: false);
            return new DeferredBodyAction<ThingRo>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/things/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var thingRo = new JObject();
                var thingRopropCount = 0;
                var applicationObject = new JObject();
                var applicationObjectpropCount = 0;
                if (__workflow_thingRoapplicationid != null)
                {
                    applicationObject["id"] = ExpressionConverter.ConvertO(__workflow_thingRoapplicationid);
                    applicationObjectpropCount++;
                }

                if (__workflow_thingRoapplicationlink != null)
                {
                    applicationObject["link"] = ExpressionConverter.ConvertO(__workflow_thingRoapplicationlink);
                    applicationObjectpropCount++;
                }

                if (__workflow_thingRoapplicationname != null)
                {
                    applicationObject["name"] = ExpressionConverter.ConvertO(__workflow_thingRoapplicationname);
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

                if (__workflow_thingRoconnectivityid != null)
                {
                    connectivityObject["id"] = ExpressionConverter.ConvertO(__workflow_thingRoconnectivityid);
                    connectivityObjectpropCount++;
                }

                if (__workflow_thingRoconnectivityrawStatus != null)
                {
                    connectivityObject["rawStatus"] = ExpressionConverter.ConvertO(__workflow_thingRoconnectivityrawStatus);
                    connectivityObjectpropCount++;
                }

                if (__workflow_thingRoconnectivitystatus != null)
                {
                    connectivityObject["status"] = ExpressionConverter.ConvertO(__workflow_thingRoconnectivitystatus);
                    connectivityObjectpropCount++;
                }

                if (__workflow_thingRoconnectivitytype != null)
                {
                    connectivityObject["type"] = ExpressionConverter.ConvertO(__workflow_thingRoconnectivitytype);
                    connectivityObjectpropCount++;
                }

                if (connectivityObjectpropCount > 0)
                {
                    thingRo["connectivity"] = connectivityObject;
                    thingRopropCount++;
                }

                if (__workflow_thingRocustomFields != null)
                {
                    thingRo["customFields"] = ExpressionConverter.ConvertO(__workflow_thingRocustomFields);
                    thingRopropCount++;
                }

                var customModelObject = new JObject();
                var customModelObjectpropCount = 0;
                if (__workflow_thingRocustomModelcolor != null)
                {
                    customModelObject["color"] = ExpressionConverter.ConvertO(__workflow_thingRocustomModelcolor);
                    customModelObjectpropCount++;
                }

                if (__workflow_thingRocustomModelicon != null)
                {
                    customModelObject["icon"] = ExpressionConverter.ConvertO(__workflow_thingRocustomModelicon);
                    customModelObjectpropCount++;
                }

                if (__workflow_thingRocustomModelid != null)
                {
                    customModelObject["id"] = ExpressionConverter.ConvertO(__workflow_thingRocustomModelid);
                    customModelObjectpropCount++;
                }

                if (__workflow_thingRocustomModellink != null)
                {
                    customModelObject["link"] = ExpressionConverter.ConvertO(__workflow_thingRocustomModellink);
                    customModelObjectpropCount++;
                }

                if (__workflow_thingRocustomModelname != null)
                {
                    customModelObject["name"] = ExpressionConverter.ConvertO(__workflow_thingRocustomModelname);
                    customModelObjectpropCount++;
                }

                if (customModelObjectpropCount > 0)
                {
                    thingRo["customModel"] = customModelObject;
                    thingRopropCount++;
                }

                if (__workflow_thingRodescription != null)
                {
                    thingRo["description"] = ExpressionConverter.ConvertO(__workflow_thingRodescription);
                    thingRopropCount++;
                }

                var deviceObject = new JObject();
                var deviceObjectpropCount = 0;
                if (__workflow_thingRodevicebatteryLevel != null)
                {
                    deviceObject["batteryLevel"] = ExpressionConverter.ConvertO(__workflow_thingRodevicebatteryLevel);
                    deviceObjectpropCount++;
                }

                if (__workflow_thingRodevicebatteryStatus != null)
                {
                    deviceObject["batteryStatus"] = ExpressionConverter.ConvertO(__workflow_thingRodevicebatteryStatus);
                    deviceObjectpropCount++;
                }

                if (__workflow_thingRodevicedeviceType != null)
                {
                    deviceObject["deviceType"] = ExpressionConverter.ConvertO(__workflow_thingRodevicedeviceType);
                    deviceObjectpropCount++;
                }

                if (__workflow_thingRodeviceid != null)
                {
                    deviceObject["id"] = ExpressionConverter.ConvertO(__workflow_thingRodeviceid);
                    deviceObjectpropCount++;
                }

                if (__workflow_thingRodevicemanufacturer != null)
                {
                    deviceObject["manufacturer"] = ExpressionConverter.ConvertO(__workflow_thingRodevicemanufacturer);
                    deviceObjectpropCount++;
                }

                if (__workflow_thingRodevicememoryFree != null)
                {
                    deviceObject["memoryFree"] = ExpressionConverter.ConvertO(__workflow_thingRodevicememoryFree);
                    deviceObjectpropCount++;
                }

                if (__workflow_thingRodevicememoryTotal != null)
                {
                    deviceObject["memoryTotal"] = ExpressionConverter.ConvertO(__workflow_thingRodevicememoryTotal);
                    deviceObjectpropCount++;
                }

                if (__workflow_thingRodevicemodel != null)
                {
                    deviceObject["model"] = ExpressionConverter.ConvertO(__workflow_thingRodevicemodel);
                    deviceObjectpropCount++;
                }

                if (__workflow_thingRodevicemodelNumber != null)
                {
                    deviceObject["modelNumber"] = ExpressionConverter.ConvertO(__workflow_thingRodevicemodelNumber);
                    deviceObjectpropCount++;
                }

                if (__workflow_thingRodevicename != null)
                {
                    deviceObject["name"] = ExpressionConverter.ConvertO(__workflow_thingRodevicename);
                    deviceObjectpropCount++;
                }

                if (__workflow_thingRodeviceserialNumber != null)
                {
                    deviceObject["serialNumber"] = ExpressionConverter.ConvertO(__workflow_thingRodeviceserialNumber);
                    deviceObjectpropCount++;
                }

                if (__workflow_thingRodevicestatus != null)
                {
                    deviceObject["status"] = ExpressionConverter.ConvertO(__workflow_thingRodevicestatus);
                    deviceObjectpropCount++;
                }

                if (deviceObjectpropCount > 0)
                {
                    thingRo["device"] = deviceObject;
                    thingRopropCount++;
                }

                if (__workflow_thingRodisplayName != null)
                {
                    thingRo["displayName"] = ExpressionConverter.ConvertO(__workflow_thingRodisplayName);
                    thingRopropCount++;
                }

                if (__workflow_thingRodynamicGps != null)
                {
                    thingRo["dynamicGps"] = ExpressionConverter.ConvertO(__workflow_thingRodynamicGps);
                    thingRopropCount++;
                }

                if (__workflow_thingRofixedLatitude != null)
                {
                    thingRo["fixedLatitude"] = ExpressionConverter.ConvertO(__workflow_thingRofixedLatitude);
                    thingRopropCount++;
                }

                if (__workflow_thingRofixedLongitude != null)
                {
                    thingRo["fixedLongitude"] = ExpressionConverter.ConvertO(__workflow_thingRofixedLongitude);
                    thingRopropCount++;
                }

                if (__workflow_thingRofixedName != null)
                {
                    thingRo["fixedName"] = ExpressionConverter.ConvertO(__workflow_thingRofixedName);
                    thingRopropCount++;
                }

                if (__workflow_thingRoid != null)
                {
                    thingRo["id"] = ExpressionConverter.ConvertO(__workflow_thingRoid);
                    thingRopropCount++;
                }

                if (__workflow_thingRolastActivityDate != null)
                {
                    thingRo["lastActivityDate"] = ExpressionConverter.ConvertO(__workflow_thingRolastActivityDate);
                    thingRopropCount++;
                }

                if (__workflow_thingRolastLatitude != null)
                {
                    thingRo["lastLatitude"] = ExpressionConverter.ConvertO(__workflow_thingRolastLatitude);
                    thingRopropCount++;
                }

                if (__workflow_thingRolastLongitude != null)
                {
                    thingRo["lastLongitude"] = ExpressionConverter.ConvertO(__workflow_thingRolastLongitude);
                    thingRopropCount++;
                }

                var lastMeasurementsObject = new JObject();
                var lastMeasurementsObjectpropCount = 0;
                if (__workflow_thingRolastMeasurementsarray != null)
                {
                    lastMeasurementsObject["array"] = ExpressionConverter.ConvertO(__workflow_thingRolastMeasurementsarray);
                    lastMeasurementsObjectpropCount++;
                }

                if (__workflow_thingRolastMeasurementsbigDecimal != null)
                {
                    lastMeasurementsObject["bigDecimal"] = ExpressionConverter.ConvertO(__workflow_thingRolastMeasurementsbigDecimal);
                    lastMeasurementsObjectpropCount++;
                }

                if (__workflow_thingRolastMeasurementsbigInteger != null)
                {
                    lastMeasurementsObject["bigInteger"] = ExpressionConverter.ConvertO(__workflow_thingRolastMeasurementsbigInteger);
                    lastMeasurementsObjectpropCount++;
                }

                if (__workflow_thingRolastMeasurementsbinary != null)
                {
                    lastMeasurementsObject["binary"] = ExpressionConverter.ConvertO(__workflow_thingRolastMeasurementsbinary);
                    lastMeasurementsObjectpropCount++;
                }

                if (__workflow_thingRolastMeasurementsboolean != null)
                {
                    lastMeasurementsObject["boolean"] = ExpressionConverter.ConvertO(__workflow_thingRolastMeasurementsboolean);
                    lastMeasurementsObjectpropCount++;
                }

                if (__workflow_thingRolastMeasurementscontainerNode != null)
                {
                    lastMeasurementsObject["containerNode"] = ExpressionConverter.ConvertO(__workflow_thingRolastMeasurementscontainerNode);
                    lastMeasurementsObjectpropCount++;
                }

                if (__workflow_thingRolastMeasurementsdouble != null)
                {
                    lastMeasurementsObject["double"] = ExpressionConverter.ConvertO(__workflow_thingRolastMeasurementsdouble);
                    lastMeasurementsObjectpropCount++;
                }

                if (__workflow_thingRolastMeasurementsfloat != null)
                {
                    lastMeasurementsObject["float"] = ExpressionConverter.ConvertO(__workflow_thingRolastMeasurementsfloat);
                    lastMeasurementsObjectpropCount++;
                }

                if (__workflow_thingRolastMeasurementsfloatingPointNumber != null)
                {
                    lastMeasurementsObject["floatingPointNumber"] = ExpressionConverter.ConvertO(__workflow_thingRolastMeasurementsfloatingPointNumber);
                    lastMeasurementsObjectpropCount++;
                }

                if (__workflow_thingRolastMeasurementsint != null)
                {
                    lastMeasurementsObject["int"] = ExpressionConverter.ConvertO(__workflow_thingRolastMeasurementsint);
                    lastMeasurementsObjectpropCount++;
                }

                if (__workflow_thingRolastMeasurementsintegralNumber != null)
                {
                    lastMeasurementsObject["integralNumber"] = ExpressionConverter.ConvertO(__workflow_thingRolastMeasurementsintegralNumber);
                    lastMeasurementsObjectpropCount++;
                }

                if (__workflow_thingRolastMeasurementsLong != null)
                {
                    lastMeasurementsObject["long"] = ExpressionConverter.ConvertO(__workflow_thingRolastMeasurementsLong);
                    lastMeasurementsObjectpropCount++;
                }

                if (__workflow_thingRolastMeasurementsmissingNode != null)
                {
                    lastMeasurementsObject["missingNode"] = ExpressionConverter.ConvertO(__workflow_thingRolastMeasurementsmissingNode);
                    lastMeasurementsObjectpropCount++;
                }

                if (__workflow_thingRolastMeasurementsnodeType != null)
                {
                    lastMeasurementsObject["nodeType"] = ExpressionConverter.ConvertO(__workflow_thingRolastMeasurementsnodeType);
                    lastMeasurementsObjectpropCount++;
                }

                if (__workflow_thingRolastMeasurementsnull != null)
                {
                    lastMeasurementsObject["null"] = ExpressionConverter.ConvertO(__workflow_thingRolastMeasurementsnull);
                    lastMeasurementsObjectpropCount++;
                }

                if (__workflow_thingRolastMeasurementsnumber != null)
                {
                    lastMeasurementsObject["number"] = ExpressionConverter.ConvertO(__workflow_thingRolastMeasurementsnumber);
                    lastMeasurementsObjectpropCount++;
                }

                if (__workflow_thingRolastMeasurementsObject != null)
                {
                    lastMeasurementsObject["object"] = ExpressionConverter.ConvertO(__workflow_thingRolastMeasurementsObject);
                    lastMeasurementsObjectpropCount++;
                }

                if (__workflow_thingRolastMeasurementspojo != null)
                {
                    lastMeasurementsObject["pojo"] = ExpressionConverter.ConvertO(__workflow_thingRolastMeasurementspojo);
                    lastMeasurementsObjectpropCount++;
                }

                if (__workflow_thingRolastMeasurementsShort != null)
                {
                    lastMeasurementsObject["short"] = ExpressionConverter.ConvertO(__workflow_thingRolastMeasurementsShort);
                    lastMeasurementsObjectpropCount++;
                }

                if (__workflow_thingRolastMeasurementstextual != null)
                {
                    lastMeasurementsObject["textual"] = ExpressionConverter.ConvertO(__workflow_thingRolastMeasurementstextual);
                    lastMeasurementsObjectpropCount++;
                }

                if (__workflow_thingRolastMeasurementsvalueNode != null)
                {
                    lastMeasurementsObject["valueNode"] = ExpressionConverter.ConvertO(__workflow_thingRolastMeasurementsvalueNode);
                    lastMeasurementsObjectpropCount++;
                }

                if (lastMeasurementsObjectpropCount > 0)
                {
                    thingRo["lastMeasurements"] = lastMeasurementsObject;
                    thingRopropCount++;
                }

                var lastMeasurementsTimestampsObject = new JObject();
                var lastMeasurementsTimestampsObjectpropCount = 0;
                if (__workflow_thingRolastMeasurementsarray != null)
                {
                    lastMeasurementsTimestampsObject["array"] = ExpressionConverter.ConvertO(__workflow_thingRolastMeasurementsarray);
                    lastMeasurementsTimestampsObjectpropCount++;
                }

                if (__workflow_thingRolastMeasurementsbigDecimal != null)
                {
                    lastMeasurementsTimestampsObject["bigDecimal"] = ExpressionConverter.ConvertO(__workflow_thingRolastMeasurementsbigDecimal);
                    lastMeasurementsTimestampsObjectpropCount++;
                }

                if (__workflow_thingRolastMeasurementsbigInteger != null)
                {
                    lastMeasurementsTimestampsObject["bigInteger"] = ExpressionConverter.ConvertO(__workflow_thingRolastMeasurementsbigInteger);
                    lastMeasurementsTimestampsObjectpropCount++;
                }

                if (__workflow_thingRolastMeasurementsbinary != null)
                {
                    lastMeasurementsTimestampsObject["binary"] = ExpressionConverter.ConvertO(__workflow_thingRolastMeasurementsbinary);
                    lastMeasurementsTimestampsObjectpropCount++;
                }

                if (__workflow_thingRolastMeasurementsboolean != null)
                {
                    lastMeasurementsTimestampsObject["boolean"] = ExpressionConverter.ConvertO(__workflow_thingRolastMeasurementsboolean);
                    lastMeasurementsTimestampsObjectpropCount++;
                }

                if (__workflow_thingRolastMeasurementscontainerNode != null)
                {
                    lastMeasurementsTimestampsObject["containerNode"] = ExpressionConverter.ConvertO(__workflow_thingRolastMeasurementscontainerNode);
                    lastMeasurementsTimestampsObjectpropCount++;
                }

                if (__workflow_thingRolastMeasurementsdouble != null)
                {
                    lastMeasurementsTimestampsObject["double"] = ExpressionConverter.ConvertO(__workflow_thingRolastMeasurementsdouble);
                    lastMeasurementsTimestampsObjectpropCount++;
                }

                if (__workflow_thingRolastMeasurementsfloat != null)
                {
                    lastMeasurementsTimestampsObject["float"] = ExpressionConverter.ConvertO(__workflow_thingRolastMeasurementsfloat);
                    lastMeasurementsTimestampsObjectpropCount++;
                }

                if (__workflow_thingRolastMeasurementsfloatingPointNumber != null)
                {
                    lastMeasurementsTimestampsObject["floatingPointNumber"] = ExpressionConverter.ConvertO(__workflow_thingRolastMeasurementsfloatingPointNumber);
                    lastMeasurementsTimestampsObjectpropCount++;
                }

                if (__workflow_thingRolastMeasurementsint != null)
                {
                    lastMeasurementsTimestampsObject["int"] = ExpressionConverter.ConvertO(__workflow_thingRolastMeasurementsint);
                    lastMeasurementsTimestampsObjectpropCount++;
                }

                if (__workflow_thingRolastMeasurementsintegralNumber != null)
                {
                    lastMeasurementsTimestampsObject["integralNumber"] = ExpressionConverter.ConvertO(__workflow_thingRolastMeasurementsintegralNumber);
                    lastMeasurementsTimestampsObjectpropCount++;
                }

                if (__workflow_thingRolastMeasurementsLong != null)
                {
                    lastMeasurementsTimestampsObject["long"] = ExpressionConverter.ConvertO(__workflow_thingRolastMeasurementsLong);
                    lastMeasurementsTimestampsObjectpropCount++;
                }

                if (__workflow_thingRolastMeasurementsmissingNode != null)
                {
                    lastMeasurementsTimestampsObject["missingNode"] = ExpressionConverter.ConvertO(__workflow_thingRolastMeasurementsmissingNode);
                    lastMeasurementsTimestampsObjectpropCount++;
                }

                if (__workflow_thingRolastMeasurementsnodeType != null)
                {
                    lastMeasurementsTimestampsObject["nodeType"] = ExpressionConverter.ConvertO(__workflow_thingRolastMeasurementsnodeType);
                    lastMeasurementsTimestampsObjectpropCount++;
                }

                if (__workflow_thingRolastMeasurementsnull != null)
                {
                    lastMeasurementsTimestampsObject["null"] = ExpressionConverter.ConvertO(__workflow_thingRolastMeasurementsnull);
                    lastMeasurementsTimestampsObjectpropCount++;
                }

                if (__workflow_thingRolastMeasurementsnumber != null)
                {
                    lastMeasurementsTimestampsObject["number"] = ExpressionConverter.ConvertO(__workflow_thingRolastMeasurementsnumber);
                    lastMeasurementsTimestampsObjectpropCount++;
                }

                if (__workflow_thingRolastMeasurementsObject != null)
                {
                    lastMeasurementsTimestampsObject["object"] = ExpressionConverter.ConvertO(__workflow_thingRolastMeasurementsObject);
                    lastMeasurementsTimestampsObjectpropCount++;
                }

                if (__workflow_thingRolastMeasurementspojo != null)
                {
                    lastMeasurementsTimestampsObject["pojo"] = ExpressionConverter.ConvertO(__workflow_thingRolastMeasurementspojo);
                    lastMeasurementsTimestampsObjectpropCount++;
                }

                if (__workflow_thingRolastMeasurementsShort != null)
                {
                    lastMeasurementsTimestampsObject["short"] = ExpressionConverter.ConvertO(__workflow_thingRolastMeasurementsShort);
                    lastMeasurementsTimestampsObjectpropCount++;
                }

                if (__workflow_thingRolastMeasurementstextual != null)
                {
                    lastMeasurementsTimestampsObject["textual"] = ExpressionConverter.ConvertO(__workflow_thingRolastMeasurementstextual);
                    lastMeasurementsTimestampsObjectpropCount++;
                }

                if (__workflow_thingRolastMeasurementsvalueNode != null)
                {
                    lastMeasurementsTimestampsObject["valueNode"] = ExpressionConverter.ConvertO(__workflow_thingRolastMeasurementsvalueNode);
                    lastMeasurementsTimestampsObjectpropCount++;
                }

                if (lastMeasurementsTimestampsObjectpropCount > 0)
                {
                    thingRo["lastMeasurementsTimestamps"] = lastMeasurementsTimestampsObject;
                    thingRopropCount++;
                }

                if (__workflow_thingRolastMessageDate != null)
                {
                    thingRo["lastMessageDate"] = ExpressionConverter.ConvertO(__workflow_thingRolastMessageDate);
                    thingRopropCount++;
                }

                if (__workflow_thingRomessageActivityTimeoutPeriod != null)
                {
                    thingRo["messageActivityTimeoutPeriod"] = ExpressionConverter.ConvertO(__workflow_thingRomessageActivityTimeoutPeriod);
                    thingRopropCount++;
                }

                thingRopropCount++;
                thingRo["name"] = ExpressionConverter.ConvertO(__workflow_thingRoname);
                if (__workflow_thingRonbAlerts != null)
                {
                    thingRo["nbAlerts"] = ExpressionConverter.ConvertO(__workflow_thingRonbAlerts);
                    thingRopropCount++;
                }

                var productObject = new JObject();
                var productObjectpropCount = 0;
                if (__workflow_thingRoproductconnectivityTypes != null)
                {
                    productObject["connectivityTypes"] = ExpressionConverter.ConvertO(__workflow_thingRoproductconnectivityTypes);
                    productObjectpropCount++;
                }

                if (__workflow_thingRoproductgenerateLinks != null)
                {
                    productObject["generateLinks"] = ExpressionConverter.ConvertO(__workflow_thingRoproductgenerateLinks);
                    productObjectpropCount++;
                }

                if (__workflow_thingRoproductid != null)
                {
                    productObject["id"] = ExpressionConverter.ConvertO(__workflow_thingRoproductid);
                    productObjectpropCount++;
                }

                if (__workflow_thingRoproductlink != null)
                {
                    productObject["link"] = ExpressionConverter.ConvertO(__workflow_thingRoproductlink);
                    productObjectpropCount++;
                }

                var manufacturerObject = new JObject();
                var manufacturerObjectpropCount = 0;
                if (__workflow_thingRoproductmanufacturergenerateLinks != null)
                {
                    manufacturerObject["generateLinks"] = ExpressionConverter.ConvertO(__workflow_thingRoproductmanufacturergenerateLinks);
                    manufacturerObjectpropCount++;
                }

                if (__workflow_thingRoproductmanufacturerid != null)
                {
                    manufacturerObject["id"] = ExpressionConverter.ConvertO(__workflow_thingRoproductmanufacturerid);
                    manufacturerObjectpropCount++;
                }

                if (__workflow_thingRoproductmanufacturerlink != null)
                {
                    manufacturerObject["link"] = ExpressionConverter.ConvertO(__workflow_thingRoproductmanufacturerlink);
                    manufacturerObjectpropCount++;
                }

                if (__workflow_thingRoproductmanufacturername != null)
                {
                    manufacturerObject["name"] = ExpressionConverter.ConvertO(__workflow_thingRoproductmanufacturername);
                    manufacturerObjectpropCount++;
                }

                if (manufacturerObjectpropCount > 0)
                {
                    productObject["manufacturer"] = manufacturerObject;
                    productObjectpropCount++;
                }

                var modelObject = new JObject();
                var modelObjectpropCount = 0;
                if (__workflow_thingRoproductmodelcolor != null)
                {
                    modelObject["color"] = ExpressionConverter.ConvertO(__workflow_thingRoproductmodelcolor);
                    modelObjectpropCount++;
                }

                if (__workflow_thingRoproductmodelgenerateLinks != null)
                {
                    modelObject["generateLinks"] = ExpressionConverter.ConvertO(__workflow_thingRoproductmodelgenerateLinks);
                    modelObjectpropCount++;
                }

                if (__workflow_thingRoproductmodelicon != null)
                {
                    modelObject["icon"] = ExpressionConverter.ConvertO(__workflow_thingRoproductmodelicon);
                    modelObjectpropCount++;
                }

                if (__workflow_thingRoproductmodelid != null)
                {
                    modelObject["id"] = ExpressionConverter.ConvertO(__workflow_thingRoproductmodelid);
                    modelObjectpropCount++;
                }

                if (__workflow_thingRoproductmodelisCustomModel != null)
                {
                    modelObject["isCustomModel"] = ExpressionConverter.ConvertO(__workflow_thingRoproductmodelisCustomModel);
                    modelObjectpropCount++;
                }

                var linkObject = new JObject();
                var linkObjectpropCount = 0;
                if (__workflow_thingRoproductmodellinkabsolute != null)
                {
                    linkObject["absolute"] = ExpressionConverter.ConvertO(__workflow_thingRoproductmodellinkabsolute);
                    linkObjectpropCount++;
                }

                if (__workflow_thingRoproductmodellinkauthority != null)
                {
                    linkObject["authority"] = ExpressionConverter.ConvertO(__workflow_thingRoproductmodellinkauthority);
                    linkObjectpropCount++;
                }

                if (__workflow_thingRoproductmodellinkfragment != null)
                {
                    linkObject["fragment"] = ExpressionConverter.ConvertO(__workflow_thingRoproductmodellinkfragment);
                    linkObjectpropCount++;
                }

                if (__workflow_thingRoproductmodellinkhost != null)
                {
                    linkObject["host"] = ExpressionConverter.ConvertO(__workflow_thingRoproductmodellinkhost);
                    linkObjectpropCount++;
                }

                if (__workflow_thingRoproductmodellinkopaque != null)
                {
                    linkObject["opaque"] = ExpressionConverter.ConvertO(__workflow_thingRoproductmodellinkopaque);
                    linkObjectpropCount++;
                }

                if (__workflow_thingRoproductmodellinkpath != null)
                {
                    linkObject["path"] = ExpressionConverter.ConvertO(__workflow_thingRoproductmodellinkpath);
                    linkObjectpropCount++;
                }

                if (__workflow_thingRoproductmodellinkport != null)
                {
                    linkObject["port"] = ExpressionConverter.ConvertO(__workflow_thingRoproductmodellinkport);
                    linkObjectpropCount++;
                }

                if (__workflow_thingRoproductmodellinkquery != null)
                {
                    linkObject["query"] = ExpressionConverter.ConvertO(__workflow_thingRoproductmodellinkquery);
                    linkObjectpropCount++;
                }

                if (__workflow_thingRoproductmodellinkrawAuthority != null)
                {
                    linkObject["rawAuthority"] = ExpressionConverter.ConvertO(__workflow_thingRoproductmodellinkrawAuthority);
                    linkObjectpropCount++;
                }

                if (__workflow_thingRoproductmodellinkrawFragment != null)
                {
                    linkObject["rawFragment"] = ExpressionConverter.ConvertO(__workflow_thingRoproductmodellinkrawFragment);
                    linkObjectpropCount++;
                }

                if (__workflow_thingRoproductmodellinkrawPath != null)
                {
                    linkObject["rawPath"] = ExpressionConverter.ConvertO(__workflow_thingRoproductmodellinkrawPath);
                    linkObjectpropCount++;
                }

                if (__workflow_thingRoproductmodellinkrawQuery != null)
                {
                    linkObject["rawQuery"] = ExpressionConverter.ConvertO(__workflow_thingRoproductmodellinkrawQuery);
                    linkObjectpropCount++;
                }

                if (__workflow_thingRoproductmodellinkrawSchemeSpecificPart != null)
                {
                    linkObject["rawSchemeSpecificPart"] = ExpressionConverter.ConvertO(__workflow_thingRoproductmodellinkrawSchemeSpecificPart);
                    linkObjectpropCount++;
                }

                if (__workflow_thingRoproductmodellinkrawUserInfo != null)
                {
                    linkObject["rawUserInfo"] = ExpressionConverter.ConvertO(__workflow_thingRoproductmodellinkrawUserInfo);
                    linkObjectpropCount++;
                }

                if (__workflow_thingRoproductmodellinkscheme != null)
                {
                    linkObject["scheme"] = ExpressionConverter.ConvertO(__workflow_thingRoproductmodellinkscheme);
                    linkObjectpropCount++;
                }

                if (__workflow_thingRoproductmodellinkschemeSpecificPart != null)
                {
                    linkObject["schemeSpecificPart"] = ExpressionConverter.ConvertO(__workflow_thingRoproductmodellinkschemeSpecificPart);
                    linkObjectpropCount++;
                }

                if (__workflow_thingRoproductmodellinkuserInfo != null)
                {
                    linkObject["userInfo"] = ExpressionConverter.ConvertO(__workflow_thingRoproductmodellinkuserInfo);
                    linkObjectpropCount++;
                }

                if (linkObjectpropCount > 0)
                {
                    modelObject["link"] = linkObject;
                    modelObjectpropCount++;
                }

                if (__workflow_thingRoproductmodelname != null)
                {
                    modelObject["name"] = ExpressionConverter.ConvertO(__workflow_thingRoproductmodelname);
                    modelObjectpropCount++;
                }

                if (modelObjectpropCount > 0)
                {
                    productObject["model"] = modelObject;
                    productObjectpropCount++;
                }

                if (__workflow_thingRoproductname != null)
                {
                    productObject["name"] = ExpressionConverter.ConvertO(__workflow_thingRoproductname);
                    productObjectpropCount++;
                }

                if (__workflow_thingRoproductreference != null)
                {
                    productObject["reference"] = ExpressionConverter.ConvertO(__workflow_thingRoproductreference);
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
                siteObject["address"] = ExpressionConverter.ConvertO(__workflow_thingRositeaddress);
                siteObjectpropCount++;
                siteObject["city"] = ExpressionConverter.ConvertO(__workflow_thingRositecity);
                if (__workflow_thingRositeid != null)
                {
                    siteObject["id"] = ExpressionConverter.ConvertO(__workflow_thingRositeid);
                    siteObjectpropCount++;
                }

                if (__workflow_thingRositelatitude != null)
                {
                    siteObject["latitude"] = ExpressionConverter.ConvertO(__workflow_thingRositelatitude);
                    siteObjectpropCount++;
                }

                if (__workflow_thingRositelongitude != null)
                {
                    siteObject["longitude"] = ExpressionConverter.ConvertO(__workflow_thingRositelongitude);
                    siteObjectpropCount++;
                }

                siteObjectpropCount++;
                siteObject["name"] = ExpressionConverter.ConvertO(__workflow_thingRositename);
                siteObjectpropCount++;
                siteObject["postalCode"] = ExpressionConverter.ConvertO(__workflow_thingRositepostalCode);
                if (siteObjectpropCount > 0)
                {
                    thingRo["site"] = siteObject;
                    thingRopropCount++;
                }

                if (__workflow_thingRosourceId != null)
                {
                    thingRo["sourceId"] = ExpressionConverter.ConvertO(__workflow_thingRosourceId);
                    thingRopropCount++;
                }

                if (__workflow_thingRostatus != null)
                {
                    thingRo["status"] = ExpressionConverter.ConvertO(__workflow_thingRostatus);
                    thingRopropCount++;
                }

                if (__workflow_thingRotags != null)
                {
                    thingRo["tags"] = ExpressionConverter.ConvertO(__workflow_thingRotags);
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
        public IBodyWorkflowAction<ModelRo> GetThingActiveModel(Expression<Func<string>> id)
        {
            var __workflow_id = id == null ? null : WorkflowExpression.Compile(id);
            WorkflowExpression.Validate(__workflow_id, nameof(id), required: true);
            return new DeferredBodyAction<ModelRo>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/things/{0}/active_model", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ModelRo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<PageCustomFieldRo> GetCustomField(Expression<Func<string>> id)
        {
            var __workflow_id = id == null ? null : WorkflowExpression.Compile(id);
            WorkflowExpression.Validate(__workflow_id, nameof(id), required: true);
            return new DeferredBodyAction<PageCustomFieldRo>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/things/{0}/custom_fields", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<PageCustomFieldRo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<CustomFieldRo> CreateCustomField(Expression<Func<string>> id, Expression<Func<string>> customFieldRoid = null, Expression<Func<string>> customFieldRoimageLink = null, Expression<Func<string>> customFieldRolabel = null, Expression<Func<string>> customFieldRoname = null, Expression<Func<customFieldRotypeInput>> customFieldRotype = null, Expression<Func<string>> customFieldRovalue = null)
        {
            var __workflow_id = id == null ? null : WorkflowExpression.Compile(id);
            WorkflowExpression.Validate(__workflow_id, nameof(id), required: true);
            var __workflow_customFieldRoid = customFieldRoid == null ? null : WorkflowExpression.Compile(customFieldRoid);
            WorkflowExpression.Validate(__workflow_customFieldRoid, nameof(customFieldRoid), required: false);
            var __workflow_customFieldRoimageLink = customFieldRoimageLink == null ? null : WorkflowExpression.Compile(customFieldRoimageLink);
            WorkflowExpression.Validate(__workflow_customFieldRoimageLink, nameof(customFieldRoimageLink), required: false);
            var __workflow_customFieldRolabel = customFieldRolabel == null ? null : WorkflowExpression.Compile(customFieldRolabel);
            WorkflowExpression.Validate(__workflow_customFieldRolabel, nameof(customFieldRolabel), required: false);
            var __workflow_customFieldRoname = customFieldRoname == null ? null : WorkflowExpression.Compile(customFieldRoname);
            WorkflowExpression.Validate(__workflow_customFieldRoname, nameof(customFieldRoname), required: false);
            var __workflow_customFieldRotype = customFieldRotype == null ? null : WorkflowExpression.Compile(customFieldRotype);
            WorkflowExpression.Validate(__workflow_customFieldRotype, nameof(customFieldRotype), required: false);
            var __workflow_customFieldRovalue = customFieldRovalue == null ? null : WorkflowExpression.Compile(customFieldRovalue);
            WorkflowExpression.Validate(__workflow_customFieldRovalue, nameof(customFieldRovalue), required: false);
            return new DeferredBodyAction<CustomFieldRo>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/things/{0}/custom_fields", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var customFieldRo = new JObject();
                var customFieldRopropCount = 0;
                if (__workflow_customFieldRoid != null)
                {
                    customFieldRo["id"] = ExpressionConverter.ConvertO(__workflow_customFieldRoid);
                    customFieldRopropCount++;
                }

                if (__workflow_customFieldRoimageLink != null)
                {
                    customFieldRo["imageLink"] = ExpressionConverter.ConvertO(__workflow_customFieldRoimageLink);
                    customFieldRopropCount++;
                }

                if (__workflow_customFieldRolabel != null)
                {
                    customFieldRo["label"] = ExpressionConverter.ConvertO(__workflow_customFieldRolabel);
                    customFieldRopropCount++;
                }

                if (__workflow_customFieldRoname != null)
                {
                    customFieldRo["name"] = ExpressionConverter.ConvertO(__workflow_customFieldRoname);
                    customFieldRopropCount++;
                }

                if (__workflow_customFieldRotype != null)
                {
                    customFieldRo["type"] = ExpressionConverter.ConvertO(__workflow_customFieldRotype);
                    customFieldRopropCount++;
                }

                if (__workflow_customFieldRovalue != null)
                {
                    customFieldRo["value"] = ExpressionConverter.ConvertO(__workflow_customFieldRovalue);
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
        public IBodyWorkflowAction<CustomFieldRo> UpdateCustomField(Expression<Func<string>> id, Expression<Func<string>> customFieldRoid = null, Expression<Func<string>> customFieldRoimageLink = null, Expression<Func<string>> customFieldRolabel = null, Expression<Func<string>> customFieldRoname = null, Expression<Func<customFieldRotypeInput>> customFieldRotype = null, Expression<Func<string>> customFieldRovalue = null)
        {
            var __workflow_id = id == null ? null : WorkflowExpression.Compile(id);
            WorkflowExpression.Validate(__workflow_id, nameof(id), required: true);
            var __workflow_customFieldRoid = customFieldRoid == null ? null : WorkflowExpression.Compile(customFieldRoid);
            WorkflowExpression.Validate(__workflow_customFieldRoid, nameof(customFieldRoid), required: false);
            var __workflow_customFieldRoimageLink = customFieldRoimageLink == null ? null : WorkflowExpression.Compile(customFieldRoimageLink);
            WorkflowExpression.Validate(__workflow_customFieldRoimageLink, nameof(customFieldRoimageLink), required: false);
            var __workflow_customFieldRolabel = customFieldRolabel == null ? null : WorkflowExpression.Compile(customFieldRolabel);
            WorkflowExpression.Validate(__workflow_customFieldRolabel, nameof(customFieldRolabel), required: false);
            var __workflow_customFieldRoname = customFieldRoname == null ? null : WorkflowExpression.Compile(customFieldRoname);
            WorkflowExpression.Validate(__workflow_customFieldRoname, nameof(customFieldRoname), required: false);
            var __workflow_customFieldRotype = customFieldRotype == null ? null : WorkflowExpression.Compile(customFieldRotype);
            WorkflowExpression.Validate(__workflow_customFieldRotype, nameof(customFieldRotype), required: false);
            var __workflow_customFieldRovalue = customFieldRovalue == null ? null : WorkflowExpression.Compile(customFieldRovalue);
            WorkflowExpression.Validate(__workflow_customFieldRovalue, nameof(customFieldRovalue), required: false);
            return new DeferredBodyAction<CustomFieldRo>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/things/{0}/custom_fields", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var customFieldRo = new JObject();
                var customFieldRopropCount = 0;
                if (__workflow_customFieldRoid != null)
                {
                    customFieldRo["id"] = ExpressionConverter.ConvertO(__workflow_customFieldRoid);
                    customFieldRopropCount++;
                }

                if (__workflow_customFieldRoimageLink != null)
                {
                    customFieldRo["imageLink"] = ExpressionConverter.ConvertO(__workflow_customFieldRoimageLink);
                    customFieldRopropCount++;
                }

                if (__workflow_customFieldRolabel != null)
                {
                    customFieldRo["label"] = ExpressionConverter.ConvertO(__workflow_customFieldRolabel);
                    customFieldRopropCount++;
                }

                if (__workflow_customFieldRoname != null)
                {
                    customFieldRo["name"] = ExpressionConverter.ConvertO(__workflow_customFieldRoname);
                    customFieldRopropCount++;
                }

                if (__workflow_customFieldRotype != null)
                {
                    customFieldRo["type"] = ExpressionConverter.ConvertO(__workflow_customFieldRotype);
                    customFieldRopropCount++;
                }

                if (__workflow_customFieldRovalue != null)
                {
                    customFieldRo["value"] = ExpressionConverter.ConvertO(__workflow_customFieldRovalue);
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
        public IBodyWorkflowAction<ResponseEntity> DeleteCustomField(Expression<Func<string>> id, Expression<Func<string>> fieldId)
        {
            var __workflow_id = id == null ? null : WorkflowExpression.Compile(id);
            WorkflowExpression.Validate(__workflow_id, nameof(id), required: true);
            var __workflow_fieldId = fieldId == null ? null : WorkflowExpression.Compile(fieldId);
            WorkflowExpression.Validate(__workflow_fieldId, nameof(fieldId), required: true);
            return new DeferredBodyAction<ResponseEntity>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/things/{0}/custom_fields/{1}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_fieldId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ResponseEntity>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<ResponseEntity> GetCustomFieldImage(Expression<Func<string>> id, Expression<Func<string>> fieldId)
        {
            var __workflow_id = id == null ? null : WorkflowExpression.Compile(id);
            WorkflowExpression.Validate(__workflow_id, nameof(id), required: true);
            var __workflow_fieldId = fieldId == null ? null : WorkflowExpression.Compile(fieldId);
            WorkflowExpression.Validate(__workflow_fieldId, nameof(fieldId), required: true);
            return new DeferredBodyAction<ResponseEntity>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/things/{0}/custom_fields/{1}/image", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_fieldId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ResponseEntity>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<ResponseEntity> PostCustomFieldImage(Expression<Func<string>> id, Expression<Func<string>> fieldId, Expression<Func<object>> file)
        {
            var __workflow_id = id == null ? null : WorkflowExpression.Compile(id);
            WorkflowExpression.Validate(__workflow_id, nameof(id), required: true);
            var __workflow_fieldId = fieldId == null ? null : WorkflowExpression.Compile(fieldId);
            WorkflowExpression.Validate(__workflow_fieldId, nameof(fieldId), required: true);
            var __workflow_file = file == null ? null : WorkflowExpression.Compile(file);
            WorkflowExpression.Validate(__workflow_file, nameof(file), required: true);
            return new DeferredBodyAction<ResponseEntity>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/things/{0}/custom_fields/{1}/image", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_fieldId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ResponseEntity>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<ResponseEntity> GetThingImage(Expression<Func<string>> id)
        {
            var __workflow_id = id == null ? null : WorkflowExpression.Compile(id);
            WorkflowExpression.Validate(__workflow_id, nameof(id), required: true);
            return new DeferredBodyAction<ResponseEntity>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/things/{0}/image", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ResponseEntity>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<MeasureTinyRo[]> GetLastMeasures(Expression<Func<string>> id)
        {
            var __workflow_id = id == null ? null : WorkflowExpression.Compile(id);
            WorkflowExpression.Validate(__workflow_id, nameof(id), required: true);
            return new DeferredBodyAction<MeasureTinyRo[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/things/{0}/last_measurements", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<MeasureTinyRo[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<MessageTinyRo> GetLastMessage(Expression<Func<string>> id)
        {
            var __workflow_id = id == null ? null : WorkflowExpression.Compile(id);
            WorkflowExpression.Validate(__workflow_id, nameof(id), required: true);
            return new DeferredBodyAction<MessageTinyRo>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/things/{0}/last_message", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<MessageTinyRo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<PageMeasureRo> GetThingMeasures(Expression<Func<string>> id, Expression<Func<bool>> detailed = null, Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null, Expression<Func<string>> sortValues = null, Expression<Func<string>> sort = null, Expression<Func<string>> filter = null, Expression<Func<dirInput>> dir = null, Expression<Func<string>> orFilter = null)
        {
            var __workflow_id = id == null ? null : WorkflowExpression.Compile(id);
            WorkflowExpression.Validate(__workflow_id, nameof(id), required: true);
            var __workflow_detailed = detailed == null ? null : WorkflowExpression.Compile(detailed);
            WorkflowExpression.Validate(__workflow_detailed, nameof(detailed), required: false);
            var __workflow_page = page == null ? null : WorkflowExpression.Compile(page);
            WorkflowExpression.Validate(__workflow_page, nameof(page), required: false);
            var __workflow_pageSize = pageSize == null ? null : WorkflowExpression.Compile(pageSize);
            WorkflowExpression.Validate(__workflow_pageSize, nameof(pageSize), required: false);
            var __workflow_sortValues = sortValues == null ? null : WorkflowExpression.Compile(sortValues);
            WorkflowExpression.Validate(__workflow_sortValues, nameof(sortValues), required: false);
            var __workflow_sort = sort == null ? null : WorkflowExpression.Compile(sort);
            WorkflowExpression.Validate(__workflow_sort, nameof(sort), required: false);
            var __workflow_filter = filter == null ? null : WorkflowExpression.Compile(filter);
            WorkflowExpression.Validate(__workflow_filter, nameof(filter), required: false);
            var __workflow_dir = dir == null ? null : WorkflowExpression.Compile(dir);
            WorkflowExpression.Validate(__workflow_dir, nameof(dir), required: false);
            var __workflow_orFilter = orFilter == null ? null : WorkflowExpression.Compile(orFilter);
            WorkflowExpression.Validate(__workflow_orFilter, nameof(orFilter), required: false);
            return new DeferredBodyAction<PageMeasureRo>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/things/{0}/measures", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["detailed"] = Convert.ToString(false);
                if (__workflow_detailed != null)
                    callPayload.Queries["detailed"] = ExpressionConverter.Convert(__workflow_detailed);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(__workflow_pageSize);
                if (__workflow_sortValues != null)
                    callPayload.Queries["sortValues"] = ExpressionConverter.Convert(__workflow_sortValues);
                if (__workflow_sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(__workflow_sort);
                if (__workflow_filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_dir != null)
                    callPayload.Queries["dir"] = ExpressionConverter.Convert(__workflow_dir);
                if (__workflow_orFilter != null)
                    callPayload.Queries["orFilter"] = ExpressionConverter.Convert(__workflow_orFilter);
                return new ApiConnectionAction<PageMeasureRo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<PageMessageRo> GetThingMessages(Expression<Func<string>> id, Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null, Expression<Func<string>> sortValues = null, Expression<Func<string>> sort = null, Expression<Func<string>> filter = null, Expression<Func<dirInput>> dir = null, Expression<Func<string>> orFilter = null)
        {
            var __workflow_id = id == null ? null : WorkflowExpression.Compile(id);
            WorkflowExpression.Validate(__workflow_id, nameof(id), required: true);
            var __workflow_page = page == null ? null : WorkflowExpression.Compile(page);
            WorkflowExpression.Validate(__workflow_page, nameof(page), required: false);
            var __workflow_pageSize = pageSize == null ? null : WorkflowExpression.Compile(pageSize);
            WorkflowExpression.Validate(__workflow_pageSize, nameof(pageSize), required: false);
            var __workflow_sortValues = sortValues == null ? null : WorkflowExpression.Compile(sortValues);
            WorkflowExpression.Validate(__workflow_sortValues, nameof(sortValues), required: false);
            var __workflow_sort = sort == null ? null : WorkflowExpression.Compile(sort);
            WorkflowExpression.Validate(__workflow_sort, nameof(sort), required: false);
            var __workflow_filter = filter == null ? null : WorkflowExpression.Compile(filter);
            WorkflowExpression.Validate(__workflow_filter, nameof(filter), required: false);
            var __workflow_dir = dir == null ? null : WorkflowExpression.Compile(dir);
            WorkflowExpression.Validate(__workflow_dir, nameof(dir), required: false);
            var __workflow_orFilter = orFilter == null ? null : WorkflowExpression.Compile(orFilter);
            WorkflowExpression.Validate(__workflow_orFilter, nameof(orFilter), required: false);
            return new DeferredBodyAction<PageMessageRo>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/things/{0}/messages", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(__workflow_pageSize);
                if (__workflow_sortValues != null)
                    callPayload.Queries["sortValues"] = ExpressionConverter.Convert(__workflow_sortValues);
                if (__workflow_sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(__workflow_sort);
                if (__workflow_filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_dir != null)
                    callPayload.Queries["dir"] = ExpressionConverter.Convert(__workflow_dir);
                if (__workflow_orFilter != null)
                    callPayload.Queries["orFilter"] = ExpressionConverter.Convert(__workflow_orFilter);
                return new ApiConnectionAction<PageMessageRo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IWorkflowAction DeleteThingMessages(Expression<Func<string>> id)
        {
            var __workflow_id = id == null ? null : WorkflowExpression.Compile(id);
            WorkflowExpression.Validate(__workflow_id, nameof(id), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/things/{0}/messages", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<MessageRo> CreateThingMessages(Expression<Func<string>> id, Expression<Func<string>> messageRobody, Expression<Func<string>> messageRocreationDate, Expression<Func<string>> messageRoerrorMessage, Expression<Func<double>> messageRolatitude, Expression<Func<double>> messageRolongitude, Expression<Func<string>> messageRometadata, Expression<Func<int>> messageRonumber, Expression<Func<messageRoprocessedInput>> messageRoprocessed, Expression<Func<string>> messageRothingname, Expression<Func<string>> messageRotimestamp, Expression<Func<string>> messageRotopic, Expression<Func<string>> messageRoid = null, Expression<Func<bool>> messageRolinkabsolute = null, Expression<Func<string>> messageRolinkauthority = null, Expression<Func<string>> messageRolinkfragment = null, Expression<Func<string>> messageRolinkhost = null, Expression<Func<bool>> messageRolinkopaque = null, Expression<Func<string>> messageRolinkpath = null, Expression<Func<int>> messageRolinkport = null, Expression<Func<string>> messageRolinkquery = null, Expression<Func<string>> messageRolinkrawAuthority = null, Expression<Func<string>> messageRolinkrawFragment = null, Expression<Func<string>> messageRolinkrawPath = null, Expression<Func<string>> messageRolinkrawQuery = null, Expression<Func<string>> messageRolinkrawSchemeSpecificPart = null, Expression<Func<string>> messageRolinkrawUserInfo = null, Expression<Func<string>> messageRolinkscheme = null, Expression<Func<string>> messageRolinkschemeSpecificPart = null, Expression<Func<string>> messageRolinkuserInfo = null, Expression<Func<bool>> messageRomeasurementsarray = null, Expression<Func<bool>> messageRomeasurementsbigDecimal = null, Expression<Func<bool>> messageRomeasurementsbigInteger = null, Expression<Func<bool>> messageRomeasurementsbinary = null, Expression<Func<bool>> messageRomeasurementsboolean = null, Expression<Func<bool>> messageRomeasurementscontainerNode = null, Expression<Func<bool>> messageRomeasurementsdouble = null, Expression<Func<bool>> messageRomeasurementsfloat = null, Expression<Func<bool>> messageRomeasurementsfloatingPointNumber = null, Expression<Func<bool>> messageRomeasurementsint = null, Expression<Func<bool>> messageRomeasurementsintegralNumber = null, Expression<Func<bool>> messageRomeasurementsLong = null, Expression<Func<bool>> messageRomeasurementsmissingNode = null, Expression<Func<messageRomeasurementsnodeTypeInput>> messageRomeasurementsnodeType = null, Expression<Func<bool>> messageRomeasurementsnull = null, Expression<Func<bool>> messageRomeasurementsnumber = null, Expression<Func<bool>> messageRomeasurementsObject = null, Expression<Func<bool>> messageRomeasurementspojo = null, Expression<Func<bool>> messageRomeasurementsShort = null, Expression<Func<bool>> messageRomeasurementstextual = null, Expression<Func<bool>> messageRomeasurementsvalueNode = null, Expression<Func<bool>> messageRorawMeasurementsarray = null, Expression<Func<bool>> messageRorawMeasurementsbigDecimal = null, Expression<Func<bool>> messageRorawMeasurementsbigInteger = null, Expression<Func<bool>> messageRorawMeasurementsbinary = null, Expression<Func<bool>> messageRorawMeasurementsboolean = null, Expression<Func<bool>> messageRorawMeasurementscontainerNode = null, Expression<Func<bool>> messageRorawMeasurementsdouble = null, Expression<Func<bool>> messageRorawMeasurementsfloat = null, Expression<Func<bool>> messageRorawMeasurementsfloatingPointNumber = null, Expression<Func<bool>> messageRorawMeasurementsint = null, Expression<Func<bool>> messageRorawMeasurementsintegralNumber = null, Expression<Func<bool>> messageRorawMeasurementsLong = null, Expression<Func<bool>> messageRorawMeasurementsmissingNode = null, Expression<Func<messageRorawMeasurementsnodeTypeInput>> messageRorawMeasurementsnodeType = null, Expression<Func<bool>> messageRorawMeasurementsnull = null, Expression<Func<bool>> messageRorawMeasurementsnumber = null, Expression<Func<bool>> messageRorawMeasurementsObject = null, Expression<Func<bool>> messageRorawMeasurementspojo = null, Expression<Func<bool>> messageRorawMeasurementsShort = null, Expression<Func<bool>> messageRorawMeasurementstextual = null, Expression<Func<bool>> messageRorawMeasurementsvalueNode = null, Expression<Func<string>> messageRothingdisplayName = null, Expression<Func<string>> messageRothingfixedName = null, Expression<Func<string>> messageRothingid = null, Expression<Func<int>> messageRothingnbAlerts = null, Expression<Func<ThingTagRo[]>> messageRothingtags = null)
        {
            var __workflow_id = id == null ? null : WorkflowExpression.Compile(id);
            WorkflowExpression.Validate(__workflow_id, nameof(id), required: true);
            var __workflow_messageRobody = messageRobody == null ? null : WorkflowExpression.Compile(messageRobody);
            WorkflowExpression.Validate(__workflow_messageRobody, nameof(messageRobody), required: true);
            var __workflow_messageRocreationDate = messageRocreationDate == null ? null : WorkflowExpression.Compile(messageRocreationDate);
            WorkflowExpression.Validate(__workflow_messageRocreationDate, nameof(messageRocreationDate), required: true);
            var __workflow_messageRoerrorMessage = messageRoerrorMessage == null ? null : WorkflowExpression.Compile(messageRoerrorMessage);
            WorkflowExpression.Validate(__workflow_messageRoerrorMessage, nameof(messageRoerrorMessage), required: true);
            var __workflow_messageRolatitude = messageRolatitude == null ? null : WorkflowExpression.Compile(messageRolatitude);
            WorkflowExpression.Validate(__workflow_messageRolatitude, nameof(messageRolatitude), required: true);
            var __workflow_messageRolongitude = messageRolongitude == null ? null : WorkflowExpression.Compile(messageRolongitude);
            WorkflowExpression.Validate(__workflow_messageRolongitude, nameof(messageRolongitude), required: true);
            var __workflow_messageRometadata = messageRometadata == null ? null : WorkflowExpression.Compile(messageRometadata);
            WorkflowExpression.Validate(__workflow_messageRometadata, nameof(messageRometadata), required: true);
            var __workflow_messageRonumber = messageRonumber == null ? null : WorkflowExpression.Compile(messageRonumber);
            WorkflowExpression.Validate(__workflow_messageRonumber, nameof(messageRonumber), required: true);
            var __workflow_messageRoprocessed = messageRoprocessed == null ? null : WorkflowExpression.Compile(messageRoprocessed);
            WorkflowExpression.Validate(__workflow_messageRoprocessed, nameof(messageRoprocessed), required: true);
            var __workflow_messageRothingname = messageRothingname == null ? null : WorkflowExpression.Compile(messageRothingname);
            WorkflowExpression.Validate(__workflow_messageRothingname, nameof(messageRothingname), required: true);
            var __workflow_messageRotimestamp = messageRotimestamp == null ? null : WorkflowExpression.Compile(messageRotimestamp);
            WorkflowExpression.Validate(__workflow_messageRotimestamp, nameof(messageRotimestamp), required: true);
            var __workflow_messageRotopic = messageRotopic == null ? null : WorkflowExpression.Compile(messageRotopic);
            WorkflowExpression.Validate(__workflow_messageRotopic, nameof(messageRotopic), required: true);
            var __workflow_messageRoid = messageRoid == null ? null : WorkflowExpression.Compile(messageRoid);
            WorkflowExpression.Validate(__workflow_messageRoid, nameof(messageRoid), required: false);
            var __workflow_messageRolinkabsolute = messageRolinkabsolute == null ? null : WorkflowExpression.Compile(messageRolinkabsolute);
            WorkflowExpression.Validate(__workflow_messageRolinkabsolute, nameof(messageRolinkabsolute), required: false);
            var __workflow_messageRolinkauthority = messageRolinkauthority == null ? null : WorkflowExpression.Compile(messageRolinkauthority);
            WorkflowExpression.Validate(__workflow_messageRolinkauthority, nameof(messageRolinkauthority), required: false);
            var __workflow_messageRolinkfragment = messageRolinkfragment == null ? null : WorkflowExpression.Compile(messageRolinkfragment);
            WorkflowExpression.Validate(__workflow_messageRolinkfragment, nameof(messageRolinkfragment), required: false);
            var __workflow_messageRolinkhost = messageRolinkhost == null ? null : WorkflowExpression.Compile(messageRolinkhost);
            WorkflowExpression.Validate(__workflow_messageRolinkhost, nameof(messageRolinkhost), required: false);
            var __workflow_messageRolinkopaque = messageRolinkopaque == null ? null : WorkflowExpression.Compile(messageRolinkopaque);
            WorkflowExpression.Validate(__workflow_messageRolinkopaque, nameof(messageRolinkopaque), required: false);
            var __workflow_messageRolinkpath = messageRolinkpath == null ? null : WorkflowExpression.Compile(messageRolinkpath);
            WorkflowExpression.Validate(__workflow_messageRolinkpath, nameof(messageRolinkpath), required: false);
            var __workflow_messageRolinkport = messageRolinkport == null ? null : WorkflowExpression.Compile(messageRolinkport);
            WorkflowExpression.Validate(__workflow_messageRolinkport, nameof(messageRolinkport), required: false);
            var __workflow_messageRolinkquery = messageRolinkquery == null ? null : WorkflowExpression.Compile(messageRolinkquery);
            WorkflowExpression.Validate(__workflow_messageRolinkquery, nameof(messageRolinkquery), required: false);
            var __workflow_messageRolinkrawAuthority = messageRolinkrawAuthority == null ? null : WorkflowExpression.Compile(messageRolinkrawAuthority);
            WorkflowExpression.Validate(__workflow_messageRolinkrawAuthority, nameof(messageRolinkrawAuthority), required: false);
            var __workflow_messageRolinkrawFragment = messageRolinkrawFragment == null ? null : WorkflowExpression.Compile(messageRolinkrawFragment);
            WorkflowExpression.Validate(__workflow_messageRolinkrawFragment, nameof(messageRolinkrawFragment), required: false);
            var __workflow_messageRolinkrawPath = messageRolinkrawPath == null ? null : WorkflowExpression.Compile(messageRolinkrawPath);
            WorkflowExpression.Validate(__workflow_messageRolinkrawPath, nameof(messageRolinkrawPath), required: false);
            var __workflow_messageRolinkrawQuery = messageRolinkrawQuery == null ? null : WorkflowExpression.Compile(messageRolinkrawQuery);
            WorkflowExpression.Validate(__workflow_messageRolinkrawQuery, nameof(messageRolinkrawQuery), required: false);
            var __workflow_messageRolinkrawSchemeSpecificPart = messageRolinkrawSchemeSpecificPart == null ? null : WorkflowExpression.Compile(messageRolinkrawSchemeSpecificPart);
            WorkflowExpression.Validate(__workflow_messageRolinkrawSchemeSpecificPart, nameof(messageRolinkrawSchemeSpecificPart), required: false);
            var __workflow_messageRolinkrawUserInfo = messageRolinkrawUserInfo == null ? null : WorkflowExpression.Compile(messageRolinkrawUserInfo);
            WorkflowExpression.Validate(__workflow_messageRolinkrawUserInfo, nameof(messageRolinkrawUserInfo), required: false);
            var __workflow_messageRolinkscheme = messageRolinkscheme == null ? null : WorkflowExpression.Compile(messageRolinkscheme);
            WorkflowExpression.Validate(__workflow_messageRolinkscheme, nameof(messageRolinkscheme), required: false);
            var __workflow_messageRolinkschemeSpecificPart = messageRolinkschemeSpecificPart == null ? null : WorkflowExpression.Compile(messageRolinkschemeSpecificPart);
            WorkflowExpression.Validate(__workflow_messageRolinkschemeSpecificPart, nameof(messageRolinkschemeSpecificPart), required: false);
            var __workflow_messageRolinkuserInfo = messageRolinkuserInfo == null ? null : WorkflowExpression.Compile(messageRolinkuserInfo);
            WorkflowExpression.Validate(__workflow_messageRolinkuserInfo, nameof(messageRolinkuserInfo), required: false);
            var __workflow_messageRomeasurementsarray = messageRomeasurementsarray == null ? null : WorkflowExpression.Compile(messageRomeasurementsarray);
            WorkflowExpression.Validate(__workflow_messageRomeasurementsarray, nameof(messageRomeasurementsarray), required: false);
            var __workflow_messageRomeasurementsbigDecimal = messageRomeasurementsbigDecimal == null ? null : WorkflowExpression.Compile(messageRomeasurementsbigDecimal);
            WorkflowExpression.Validate(__workflow_messageRomeasurementsbigDecimal, nameof(messageRomeasurementsbigDecimal), required: false);
            var __workflow_messageRomeasurementsbigInteger = messageRomeasurementsbigInteger == null ? null : WorkflowExpression.Compile(messageRomeasurementsbigInteger);
            WorkflowExpression.Validate(__workflow_messageRomeasurementsbigInteger, nameof(messageRomeasurementsbigInteger), required: false);
            var __workflow_messageRomeasurementsbinary = messageRomeasurementsbinary == null ? null : WorkflowExpression.Compile(messageRomeasurementsbinary);
            WorkflowExpression.Validate(__workflow_messageRomeasurementsbinary, nameof(messageRomeasurementsbinary), required: false);
            var __workflow_messageRomeasurementsboolean = messageRomeasurementsboolean == null ? null : WorkflowExpression.Compile(messageRomeasurementsboolean);
            WorkflowExpression.Validate(__workflow_messageRomeasurementsboolean, nameof(messageRomeasurementsboolean), required: false);
            var __workflow_messageRomeasurementscontainerNode = messageRomeasurementscontainerNode == null ? null : WorkflowExpression.Compile(messageRomeasurementscontainerNode);
            WorkflowExpression.Validate(__workflow_messageRomeasurementscontainerNode, nameof(messageRomeasurementscontainerNode), required: false);
            var __workflow_messageRomeasurementsdouble = messageRomeasurementsdouble == null ? null : WorkflowExpression.Compile(messageRomeasurementsdouble);
            WorkflowExpression.Validate(__workflow_messageRomeasurementsdouble, nameof(messageRomeasurementsdouble), required: false);
            var __workflow_messageRomeasurementsfloat = messageRomeasurementsfloat == null ? null : WorkflowExpression.Compile(messageRomeasurementsfloat);
            WorkflowExpression.Validate(__workflow_messageRomeasurementsfloat, nameof(messageRomeasurementsfloat), required: false);
            var __workflow_messageRomeasurementsfloatingPointNumber = messageRomeasurementsfloatingPointNumber == null ? null : WorkflowExpression.Compile(messageRomeasurementsfloatingPointNumber);
            WorkflowExpression.Validate(__workflow_messageRomeasurementsfloatingPointNumber, nameof(messageRomeasurementsfloatingPointNumber), required: false);
            var __workflow_messageRomeasurementsint = messageRomeasurementsint == null ? null : WorkflowExpression.Compile(messageRomeasurementsint);
            WorkflowExpression.Validate(__workflow_messageRomeasurementsint, nameof(messageRomeasurementsint), required: false);
            var __workflow_messageRomeasurementsintegralNumber = messageRomeasurementsintegralNumber == null ? null : WorkflowExpression.Compile(messageRomeasurementsintegralNumber);
            WorkflowExpression.Validate(__workflow_messageRomeasurementsintegralNumber, nameof(messageRomeasurementsintegralNumber), required: false);
            var __workflow_messageRomeasurementsLong = messageRomeasurementsLong == null ? null : WorkflowExpression.Compile(messageRomeasurementsLong);
            WorkflowExpression.Validate(__workflow_messageRomeasurementsLong, nameof(messageRomeasurementsLong), required: false);
            var __workflow_messageRomeasurementsmissingNode = messageRomeasurementsmissingNode == null ? null : WorkflowExpression.Compile(messageRomeasurementsmissingNode);
            WorkflowExpression.Validate(__workflow_messageRomeasurementsmissingNode, nameof(messageRomeasurementsmissingNode), required: false);
            var __workflow_messageRomeasurementsnodeType = messageRomeasurementsnodeType == null ? null : WorkflowExpression.Compile(messageRomeasurementsnodeType);
            WorkflowExpression.Validate(__workflow_messageRomeasurementsnodeType, nameof(messageRomeasurementsnodeType), required: false);
            var __workflow_messageRomeasurementsnull = messageRomeasurementsnull == null ? null : WorkflowExpression.Compile(messageRomeasurementsnull);
            WorkflowExpression.Validate(__workflow_messageRomeasurementsnull, nameof(messageRomeasurementsnull), required: false);
            var __workflow_messageRomeasurementsnumber = messageRomeasurementsnumber == null ? null : WorkflowExpression.Compile(messageRomeasurementsnumber);
            WorkflowExpression.Validate(__workflow_messageRomeasurementsnumber, nameof(messageRomeasurementsnumber), required: false);
            var __workflow_messageRomeasurementsObject = messageRomeasurementsObject == null ? null : WorkflowExpression.Compile(messageRomeasurementsObject);
            WorkflowExpression.Validate(__workflow_messageRomeasurementsObject, nameof(messageRomeasurementsObject), required: false);
            var __workflow_messageRomeasurementspojo = messageRomeasurementspojo == null ? null : WorkflowExpression.Compile(messageRomeasurementspojo);
            WorkflowExpression.Validate(__workflow_messageRomeasurementspojo, nameof(messageRomeasurementspojo), required: false);
            var __workflow_messageRomeasurementsShort = messageRomeasurementsShort == null ? null : WorkflowExpression.Compile(messageRomeasurementsShort);
            WorkflowExpression.Validate(__workflow_messageRomeasurementsShort, nameof(messageRomeasurementsShort), required: false);
            var __workflow_messageRomeasurementstextual = messageRomeasurementstextual == null ? null : WorkflowExpression.Compile(messageRomeasurementstextual);
            WorkflowExpression.Validate(__workflow_messageRomeasurementstextual, nameof(messageRomeasurementstextual), required: false);
            var __workflow_messageRomeasurementsvalueNode = messageRomeasurementsvalueNode == null ? null : WorkflowExpression.Compile(messageRomeasurementsvalueNode);
            WorkflowExpression.Validate(__workflow_messageRomeasurementsvalueNode, nameof(messageRomeasurementsvalueNode), required: false);
            var __workflow_messageRorawMeasurementsarray = messageRorawMeasurementsarray == null ? null : WorkflowExpression.Compile(messageRorawMeasurementsarray);
            WorkflowExpression.Validate(__workflow_messageRorawMeasurementsarray, nameof(messageRorawMeasurementsarray), required: false);
            var __workflow_messageRorawMeasurementsbigDecimal = messageRorawMeasurementsbigDecimal == null ? null : WorkflowExpression.Compile(messageRorawMeasurementsbigDecimal);
            WorkflowExpression.Validate(__workflow_messageRorawMeasurementsbigDecimal, nameof(messageRorawMeasurementsbigDecimal), required: false);
            var __workflow_messageRorawMeasurementsbigInteger = messageRorawMeasurementsbigInteger == null ? null : WorkflowExpression.Compile(messageRorawMeasurementsbigInteger);
            WorkflowExpression.Validate(__workflow_messageRorawMeasurementsbigInteger, nameof(messageRorawMeasurementsbigInteger), required: false);
            var __workflow_messageRorawMeasurementsbinary = messageRorawMeasurementsbinary == null ? null : WorkflowExpression.Compile(messageRorawMeasurementsbinary);
            WorkflowExpression.Validate(__workflow_messageRorawMeasurementsbinary, nameof(messageRorawMeasurementsbinary), required: false);
            var __workflow_messageRorawMeasurementsboolean = messageRorawMeasurementsboolean == null ? null : WorkflowExpression.Compile(messageRorawMeasurementsboolean);
            WorkflowExpression.Validate(__workflow_messageRorawMeasurementsboolean, nameof(messageRorawMeasurementsboolean), required: false);
            var __workflow_messageRorawMeasurementscontainerNode = messageRorawMeasurementscontainerNode == null ? null : WorkflowExpression.Compile(messageRorawMeasurementscontainerNode);
            WorkflowExpression.Validate(__workflow_messageRorawMeasurementscontainerNode, nameof(messageRorawMeasurementscontainerNode), required: false);
            var __workflow_messageRorawMeasurementsdouble = messageRorawMeasurementsdouble == null ? null : WorkflowExpression.Compile(messageRorawMeasurementsdouble);
            WorkflowExpression.Validate(__workflow_messageRorawMeasurementsdouble, nameof(messageRorawMeasurementsdouble), required: false);
            var __workflow_messageRorawMeasurementsfloat = messageRorawMeasurementsfloat == null ? null : WorkflowExpression.Compile(messageRorawMeasurementsfloat);
            WorkflowExpression.Validate(__workflow_messageRorawMeasurementsfloat, nameof(messageRorawMeasurementsfloat), required: false);
            var __workflow_messageRorawMeasurementsfloatingPointNumber = messageRorawMeasurementsfloatingPointNumber == null ? null : WorkflowExpression.Compile(messageRorawMeasurementsfloatingPointNumber);
            WorkflowExpression.Validate(__workflow_messageRorawMeasurementsfloatingPointNumber, nameof(messageRorawMeasurementsfloatingPointNumber), required: false);
            var __workflow_messageRorawMeasurementsint = messageRorawMeasurementsint == null ? null : WorkflowExpression.Compile(messageRorawMeasurementsint);
            WorkflowExpression.Validate(__workflow_messageRorawMeasurementsint, nameof(messageRorawMeasurementsint), required: false);
            var __workflow_messageRorawMeasurementsintegralNumber = messageRorawMeasurementsintegralNumber == null ? null : WorkflowExpression.Compile(messageRorawMeasurementsintegralNumber);
            WorkflowExpression.Validate(__workflow_messageRorawMeasurementsintegralNumber, nameof(messageRorawMeasurementsintegralNumber), required: false);
            var __workflow_messageRorawMeasurementsLong = messageRorawMeasurementsLong == null ? null : WorkflowExpression.Compile(messageRorawMeasurementsLong);
            WorkflowExpression.Validate(__workflow_messageRorawMeasurementsLong, nameof(messageRorawMeasurementsLong), required: false);
            var __workflow_messageRorawMeasurementsmissingNode = messageRorawMeasurementsmissingNode == null ? null : WorkflowExpression.Compile(messageRorawMeasurementsmissingNode);
            WorkflowExpression.Validate(__workflow_messageRorawMeasurementsmissingNode, nameof(messageRorawMeasurementsmissingNode), required: false);
            var __workflow_messageRorawMeasurementsnodeType = messageRorawMeasurementsnodeType == null ? null : WorkflowExpression.Compile(messageRorawMeasurementsnodeType);
            WorkflowExpression.Validate(__workflow_messageRorawMeasurementsnodeType, nameof(messageRorawMeasurementsnodeType), required: false);
            var __workflow_messageRorawMeasurementsnull = messageRorawMeasurementsnull == null ? null : WorkflowExpression.Compile(messageRorawMeasurementsnull);
            WorkflowExpression.Validate(__workflow_messageRorawMeasurementsnull, nameof(messageRorawMeasurementsnull), required: false);
            var __workflow_messageRorawMeasurementsnumber = messageRorawMeasurementsnumber == null ? null : WorkflowExpression.Compile(messageRorawMeasurementsnumber);
            WorkflowExpression.Validate(__workflow_messageRorawMeasurementsnumber, nameof(messageRorawMeasurementsnumber), required: false);
            var __workflow_messageRorawMeasurementsObject = messageRorawMeasurementsObject == null ? null : WorkflowExpression.Compile(messageRorawMeasurementsObject);
            WorkflowExpression.Validate(__workflow_messageRorawMeasurementsObject, nameof(messageRorawMeasurementsObject), required: false);
            var __workflow_messageRorawMeasurementspojo = messageRorawMeasurementspojo == null ? null : WorkflowExpression.Compile(messageRorawMeasurementspojo);
            WorkflowExpression.Validate(__workflow_messageRorawMeasurementspojo, nameof(messageRorawMeasurementspojo), required: false);
            var __workflow_messageRorawMeasurementsShort = messageRorawMeasurementsShort == null ? null : WorkflowExpression.Compile(messageRorawMeasurementsShort);
            WorkflowExpression.Validate(__workflow_messageRorawMeasurementsShort, nameof(messageRorawMeasurementsShort), required: false);
            var __workflow_messageRorawMeasurementstextual = messageRorawMeasurementstextual == null ? null : WorkflowExpression.Compile(messageRorawMeasurementstextual);
            WorkflowExpression.Validate(__workflow_messageRorawMeasurementstextual, nameof(messageRorawMeasurementstextual), required: false);
            var __workflow_messageRorawMeasurementsvalueNode = messageRorawMeasurementsvalueNode == null ? null : WorkflowExpression.Compile(messageRorawMeasurementsvalueNode);
            WorkflowExpression.Validate(__workflow_messageRorawMeasurementsvalueNode, nameof(messageRorawMeasurementsvalueNode), required: false);
            var __workflow_messageRothingdisplayName = messageRothingdisplayName == null ? null : WorkflowExpression.Compile(messageRothingdisplayName);
            WorkflowExpression.Validate(__workflow_messageRothingdisplayName, nameof(messageRothingdisplayName), required: false);
            var __workflow_messageRothingfixedName = messageRothingfixedName == null ? null : WorkflowExpression.Compile(messageRothingfixedName);
            WorkflowExpression.Validate(__workflow_messageRothingfixedName, nameof(messageRothingfixedName), required: false);
            var __workflow_messageRothingid = messageRothingid == null ? null : WorkflowExpression.Compile(messageRothingid);
            WorkflowExpression.Validate(__workflow_messageRothingid, nameof(messageRothingid), required: false);
            var __workflow_messageRothingnbAlerts = messageRothingnbAlerts == null ? null : WorkflowExpression.Compile(messageRothingnbAlerts);
            WorkflowExpression.Validate(__workflow_messageRothingnbAlerts, nameof(messageRothingnbAlerts), required: false);
            var __workflow_messageRothingtags = messageRothingtags == null ? null : WorkflowExpression.Compile(messageRothingtags);
            WorkflowExpression.Validate(__workflow_messageRothingtags, nameof(messageRothingtags), required: false);
            return new DeferredBodyAction<MessageRo>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/things/{0}/messages", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var messageRo = new JObject();
                var messageRopropCount = 0;
                messageRopropCount++;
                messageRo["body"] = ExpressionConverter.ConvertO(__workflow_messageRobody);
                messageRopropCount++;
                messageRo["creationDate"] = ExpressionConverter.ConvertO(__workflow_messageRocreationDate);
                messageRopropCount++;
                messageRo["errorMessage"] = ExpressionConverter.ConvertO(__workflow_messageRoerrorMessage);
                if (__workflow_messageRoid != null)
                {
                    messageRo["id"] = ExpressionConverter.ConvertO(__workflow_messageRoid);
                    messageRopropCount++;
                }

                messageRopropCount++;
                messageRo["latitude"] = ExpressionConverter.ConvertO(__workflow_messageRolatitude);
                var linkObject = new JObject();
                var linkObjectpropCount = 0;
                if (__workflow_messageRolinkabsolute != null)
                {
                    linkObject["absolute"] = ExpressionConverter.ConvertO(__workflow_messageRolinkabsolute);
                    linkObjectpropCount++;
                }

                if (__workflow_messageRolinkauthority != null)
                {
                    linkObject["authority"] = ExpressionConverter.ConvertO(__workflow_messageRolinkauthority);
                    linkObjectpropCount++;
                }

                if (__workflow_messageRolinkfragment != null)
                {
                    linkObject["fragment"] = ExpressionConverter.ConvertO(__workflow_messageRolinkfragment);
                    linkObjectpropCount++;
                }

                if (__workflow_messageRolinkhost != null)
                {
                    linkObject["host"] = ExpressionConverter.ConvertO(__workflow_messageRolinkhost);
                    linkObjectpropCount++;
                }

                if (__workflow_messageRolinkopaque != null)
                {
                    linkObject["opaque"] = ExpressionConverter.ConvertO(__workflow_messageRolinkopaque);
                    linkObjectpropCount++;
                }

                if (__workflow_messageRolinkpath != null)
                {
                    linkObject["path"] = ExpressionConverter.ConvertO(__workflow_messageRolinkpath);
                    linkObjectpropCount++;
                }

                if (__workflow_messageRolinkport != null)
                {
                    linkObject["port"] = ExpressionConverter.ConvertO(__workflow_messageRolinkport);
                    linkObjectpropCount++;
                }

                if (__workflow_messageRolinkquery != null)
                {
                    linkObject["query"] = ExpressionConverter.ConvertO(__workflow_messageRolinkquery);
                    linkObjectpropCount++;
                }

                if (__workflow_messageRolinkrawAuthority != null)
                {
                    linkObject["rawAuthority"] = ExpressionConverter.ConvertO(__workflow_messageRolinkrawAuthority);
                    linkObjectpropCount++;
                }

                if (__workflow_messageRolinkrawFragment != null)
                {
                    linkObject["rawFragment"] = ExpressionConverter.ConvertO(__workflow_messageRolinkrawFragment);
                    linkObjectpropCount++;
                }

                if (__workflow_messageRolinkrawPath != null)
                {
                    linkObject["rawPath"] = ExpressionConverter.ConvertO(__workflow_messageRolinkrawPath);
                    linkObjectpropCount++;
                }

                if (__workflow_messageRolinkrawQuery != null)
                {
                    linkObject["rawQuery"] = ExpressionConverter.ConvertO(__workflow_messageRolinkrawQuery);
                    linkObjectpropCount++;
                }

                if (__workflow_messageRolinkrawSchemeSpecificPart != null)
                {
                    linkObject["rawSchemeSpecificPart"] = ExpressionConverter.ConvertO(__workflow_messageRolinkrawSchemeSpecificPart);
                    linkObjectpropCount++;
                }

                if (__workflow_messageRolinkrawUserInfo != null)
                {
                    linkObject["rawUserInfo"] = ExpressionConverter.ConvertO(__workflow_messageRolinkrawUserInfo);
                    linkObjectpropCount++;
                }

                if (__workflow_messageRolinkscheme != null)
                {
                    linkObject["scheme"] = ExpressionConverter.ConvertO(__workflow_messageRolinkscheme);
                    linkObjectpropCount++;
                }

                if (__workflow_messageRolinkschemeSpecificPart != null)
                {
                    linkObject["schemeSpecificPart"] = ExpressionConverter.ConvertO(__workflow_messageRolinkschemeSpecificPart);
                    linkObjectpropCount++;
                }

                if (__workflow_messageRolinkuserInfo != null)
                {
                    linkObject["userInfo"] = ExpressionConverter.ConvertO(__workflow_messageRolinkuserInfo);
                    linkObjectpropCount++;
                }

                if (linkObjectpropCount > 0)
                {
                    messageRo["link"] = linkObject;
                    messageRopropCount++;
                }

                messageRopropCount++;
                messageRo["longitude"] = ExpressionConverter.ConvertO(__workflow_messageRolongitude);
                var measurementsObject = new JObject();
                var measurementsObjectpropCount = 0;
                if (__workflow_messageRomeasurementsarray != null)
                {
                    measurementsObject["array"] = ExpressionConverter.ConvertO(__workflow_messageRomeasurementsarray);
                    measurementsObjectpropCount++;
                }

                if (__workflow_messageRomeasurementsbigDecimal != null)
                {
                    measurementsObject["bigDecimal"] = ExpressionConverter.ConvertO(__workflow_messageRomeasurementsbigDecimal);
                    measurementsObjectpropCount++;
                }

                if (__workflow_messageRomeasurementsbigInteger != null)
                {
                    measurementsObject["bigInteger"] = ExpressionConverter.ConvertO(__workflow_messageRomeasurementsbigInteger);
                    measurementsObjectpropCount++;
                }

                if (__workflow_messageRomeasurementsbinary != null)
                {
                    measurementsObject["binary"] = ExpressionConverter.ConvertO(__workflow_messageRomeasurementsbinary);
                    measurementsObjectpropCount++;
                }

                if (__workflow_messageRomeasurementsboolean != null)
                {
                    measurementsObject["boolean"] = ExpressionConverter.ConvertO(__workflow_messageRomeasurementsboolean);
                    measurementsObjectpropCount++;
                }

                if (__workflow_messageRomeasurementscontainerNode != null)
                {
                    measurementsObject["containerNode"] = ExpressionConverter.ConvertO(__workflow_messageRomeasurementscontainerNode);
                    measurementsObjectpropCount++;
                }

                if (__workflow_messageRomeasurementsdouble != null)
                {
                    measurementsObject["double"] = ExpressionConverter.ConvertO(__workflow_messageRomeasurementsdouble);
                    measurementsObjectpropCount++;
                }

                if (__workflow_messageRomeasurementsfloat != null)
                {
                    measurementsObject["float"] = ExpressionConverter.ConvertO(__workflow_messageRomeasurementsfloat);
                    measurementsObjectpropCount++;
                }

                if (__workflow_messageRomeasurementsfloatingPointNumber != null)
                {
                    measurementsObject["floatingPointNumber"] = ExpressionConverter.ConvertO(__workflow_messageRomeasurementsfloatingPointNumber);
                    measurementsObjectpropCount++;
                }

                if (__workflow_messageRomeasurementsint != null)
                {
                    measurementsObject["int"] = ExpressionConverter.ConvertO(__workflow_messageRomeasurementsint);
                    measurementsObjectpropCount++;
                }

                if (__workflow_messageRomeasurementsintegralNumber != null)
                {
                    measurementsObject["integralNumber"] = ExpressionConverter.ConvertO(__workflow_messageRomeasurementsintegralNumber);
                    measurementsObjectpropCount++;
                }

                if (__workflow_messageRomeasurementsLong != null)
                {
                    measurementsObject["long"] = ExpressionConverter.ConvertO(__workflow_messageRomeasurementsLong);
                    measurementsObjectpropCount++;
                }

                if (__workflow_messageRomeasurementsmissingNode != null)
                {
                    measurementsObject["missingNode"] = ExpressionConverter.ConvertO(__workflow_messageRomeasurementsmissingNode);
                    measurementsObjectpropCount++;
                }

                if (__workflow_messageRomeasurementsnodeType != null)
                {
                    measurementsObject["nodeType"] = ExpressionConverter.ConvertO(__workflow_messageRomeasurementsnodeType);
                    measurementsObjectpropCount++;
                }

                if (__workflow_messageRomeasurementsnull != null)
                {
                    measurementsObject["null"] = ExpressionConverter.ConvertO(__workflow_messageRomeasurementsnull);
                    measurementsObjectpropCount++;
                }

                if (__workflow_messageRomeasurementsnumber != null)
                {
                    measurementsObject["number"] = ExpressionConverter.ConvertO(__workflow_messageRomeasurementsnumber);
                    measurementsObjectpropCount++;
                }

                if (__workflow_messageRomeasurementsObject != null)
                {
                    measurementsObject["object"] = ExpressionConverter.ConvertO(__workflow_messageRomeasurementsObject);
                    measurementsObjectpropCount++;
                }

                if (__workflow_messageRomeasurementspojo != null)
                {
                    measurementsObject["pojo"] = ExpressionConverter.ConvertO(__workflow_messageRomeasurementspojo);
                    measurementsObjectpropCount++;
                }

                if (__workflow_messageRomeasurementsShort != null)
                {
                    measurementsObject["short"] = ExpressionConverter.ConvertO(__workflow_messageRomeasurementsShort);
                    measurementsObjectpropCount++;
                }

                if (__workflow_messageRomeasurementstextual != null)
                {
                    measurementsObject["textual"] = ExpressionConverter.ConvertO(__workflow_messageRomeasurementstextual);
                    measurementsObjectpropCount++;
                }

                if (__workflow_messageRomeasurementsvalueNode != null)
                {
                    measurementsObject["valueNode"] = ExpressionConverter.ConvertO(__workflow_messageRomeasurementsvalueNode);
                    measurementsObjectpropCount++;
                }

                if (measurementsObjectpropCount > 0)
                {
                    messageRo["measurements"] = measurementsObject;
                    messageRopropCount++;
                }

                messageRopropCount++;
                messageRo["metadata"] = ExpressionConverter.ConvertO(__workflow_messageRometadata);
                messageRopropCount++;
                messageRo["number"] = ExpressionConverter.ConvertO(__workflow_messageRonumber);
                messageRopropCount++;
                messageRo["processed"] = ExpressionConverter.ConvertO(__workflow_messageRoprocessed);
                var rawMeasurementsObject = new JObject();
                var rawMeasurementsObjectpropCount = 0;
                if (__workflow_messageRomeasurementsarray != null)
                {
                    rawMeasurementsObject["array"] = ExpressionConverter.ConvertO(__workflow_messageRomeasurementsarray);
                    rawMeasurementsObjectpropCount++;
                }

                if (__workflow_messageRomeasurementsbigDecimal != null)
                {
                    rawMeasurementsObject["bigDecimal"] = ExpressionConverter.ConvertO(__workflow_messageRomeasurementsbigDecimal);
                    rawMeasurementsObjectpropCount++;
                }

                if (__workflow_messageRomeasurementsbigInteger != null)
                {
                    rawMeasurementsObject["bigInteger"] = ExpressionConverter.ConvertO(__workflow_messageRomeasurementsbigInteger);
                    rawMeasurementsObjectpropCount++;
                }

                if (__workflow_messageRomeasurementsbinary != null)
                {
                    rawMeasurementsObject["binary"] = ExpressionConverter.ConvertO(__workflow_messageRomeasurementsbinary);
                    rawMeasurementsObjectpropCount++;
                }

                if (__workflow_messageRomeasurementsboolean != null)
                {
                    rawMeasurementsObject["boolean"] = ExpressionConverter.ConvertO(__workflow_messageRomeasurementsboolean);
                    rawMeasurementsObjectpropCount++;
                }

                if (__workflow_messageRomeasurementscontainerNode != null)
                {
                    rawMeasurementsObject["containerNode"] = ExpressionConverter.ConvertO(__workflow_messageRomeasurementscontainerNode);
                    rawMeasurementsObjectpropCount++;
                }

                if (__workflow_messageRomeasurementsdouble != null)
                {
                    rawMeasurementsObject["double"] = ExpressionConverter.ConvertO(__workflow_messageRomeasurementsdouble);
                    rawMeasurementsObjectpropCount++;
                }

                if (__workflow_messageRomeasurementsfloat != null)
                {
                    rawMeasurementsObject["float"] = ExpressionConverter.ConvertO(__workflow_messageRomeasurementsfloat);
                    rawMeasurementsObjectpropCount++;
                }

                if (__workflow_messageRomeasurementsfloatingPointNumber != null)
                {
                    rawMeasurementsObject["floatingPointNumber"] = ExpressionConverter.ConvertO(__workflow_messageRomeasurementsfloatingPointNumber);
                    rawMeasurementsObjectpropCount++;
                }

                if (__workflow_messageRomeasurementsint != null)
                {
                    rawMeasurementsObject["int"] = ExpressionConverter.ConvertO(__workflow_messageRomeasurementsint);
                    rawMeasurementsObjectpropCount++;
                }

                if (__workflow_messageRomeasurementsintegralNumber != null)
                {
                    rawMeasurementsObject["integralNumber"] = ExpressionConverter.ConvertO(__workflow_messageRomeasurementsintegralNumber);
                    rawMeasurementsObjectpropCount++;
                }

                if (__workflow_messageRomeasurementsLong != null)
                {
                    rawMeasurementsObject["long"] = ExpressionConverter.ConvertO(__workflow_messageRomeasurementsLong);
                    rawMeasurementsObjectpropCount++;
                }

                if (__workflow_messageRomeasurementsmissingNode != null)
                {
                    rawMeasurementsObject["missingNode"] = ExpressionConverter.ConvertO(__workflow_messageRomeasurementsmissingNode);
                    rawMeasurementsObjectpropCount++;
                }

                if (__workflow_messageRomeasurementsnodeType != null)
                {
                    rawMeasurementsObject["nodeType"] = ExpressionConverter.ConvertO(__workflow_messageRomeasurementsnodeType);
                    rawMeasurementsObjectpropCount++;
                }

                if (__workflow_messageRomeasurementsnull != null)
                {
                    rawMeasurementsObject["null"] = ExpressionConverter.ConvertO(__workflow_messageRomeasurementsnull);
                    rawMeasurementsObjectpropCount++;
                }

                if (__workflow_messageRomeasurementsnumber != null)
                {
                    rawMeasurementsObject["number"] = ExpressionConverter.ConvertO(__workflow_messageRomeasurementsnumber);
                    rawMeasurementsObjectpropCount++;
                }

                if (__workflow_messageRomeasurementsObject != null)
                {
                    rawMeasurementsObject["object"] = ExpressionConverter.ConvertO(__workflow_messageRomeasurementsObject);
                    rawMeasurementsObjectpropCount++;
                }

                if (__workflow_messageRomeasurementspojo != null)
                {
                    rawMeasurementsObject["pojo"] = ExpressionConverter.ConvertO(__workflow_messageRomeasurementspojo);
                    rawMeasurementsObjectpropCount++;
                }

                if (__workflow_messageRomeasurementsShort != null)
                {
                    rawMeasurementsObject["short"] = ExpressionConverter.ConvertO(__workflow_messageRomeasurementsShort);
                    rawMeasurementsObjectpropCount++;
                }

                if (__workflow_messageRomeasurementstextual != null)
                {
                    rawMeasurementsObject["textual"] = ExpressionConverter.ConvertO(__workflow_messageRomeasurementstextual);
                    rawMeasurementsObjectpropCount++;
                }

                if (__workflow_messageRomeasurementsvalueNode != null)
                {
                    rawMeasurementsObject["valueNode"] = ExpressionConverter.ConvertO(__workflow_messageRomeasurementsvalueNode);
                    rawMeasurementsObjectpropCount++;
                }

                if (rawMeasurementsObjectpropCount > 0)
                {
                    messageRo["rawMeasurements"] = rawMeasurementsObject;
                    messageRopropCount++;
                }

                var thingObject = new JObject();
                var thingObjectpropCount = 0;
                if (__workflow_messageRothingdisplayName != null)
                {
                    thingObject["displayName"] = ExpressionConverter.ConvertO(__workflow_messageRothingdisplayName);
                    thingObjectpropCount++;
                }

                if (__workflow_messageRothingfixedName != null)
                {
                    thingObject["fixedName"] = ExpressionConverter.ConvertO(__workflow_messageRothingfixedName);
                    thingObjectpropCount++;
                }

                if (__workflow_messageRothingid != null)
                {
                    thingObject["id"] = ExpressionConverter.ConvertO(__workflow_messageRothingid);
                    thingObjectpropCount++;
                }

                thingObjectpropCount++;
                thingObject["name"] = ExpressionConverter.ConvertO(__workflow_messageRothingname);
                if (__workflow_messageRothingnbAlerts != null)
                {
                    thingObject["nbAlerts"] = ExpressionConverter.ConvertO(__workflow_messageRothingnbAlerts);
                    thingObjectpropCount++;
                }

                if (__workflow_messageRothingtags != null)
                {
                    thingObject["tags"] = ExpressionConverter.ConvertO(__workflow_messageRothingtags);
                    thingObjectpropCount++;
                }

                if (thingObjectpropCount > 0)
                {
                    messageRo["thing"] = thingObject;
                    messageRopropCount++;
                }

                messageRopropCount++;
                messageRo["timestamp"] = ExpressionConverter.ConvertO(__workflow_messageRotimestamp);
                messageRopropCount++;
                messageRo["topic"] = ExpressionConverter.ConvertO(__workflow_messageRotopic);
                if (messageRopropCount > 0)
                {
                    callPayload.Body = messageRo;
                }

                return new ApiConnectionAction<MessageRo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<ModelRo> GetThingModel(Expression<Func<string>> id)
        {
            var __workflow_id = id == null ? null : WorkflowExpression.Compile(id);
            WorkflowExpression.Validate(__workflow_id, nameof(id), required: true);
            return new DeferredBodyAction<ModelRo>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/things/{0}/model", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ModelRo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<PageOperationRo> GetThingOperations(Expression<Func<string>> id)
        {
            var __workflow_id = id == null ? null : WorkflowExpression.Compile(id);
            WorkflowExpression.Validate(__workflow_id, nameof(id), required: true);
            return new DeferredBodyAction<PageOperationRo>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/things/{0}/operations", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<PageOperationRo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<ResponseEntity> ExecuteThingOperation(Expression<Func<string>> id, Expression<Func<string>> operationId, Expression<Func<bool>> placeholdersValuesarray = null, Expression<Func<bool>> placeholdersValuesbigDecimal = null, Expression<Func<bool>> placeholdersValuesbigInteger = null, Expression<Func<bool>> placeholdersValuesbinary = null, Expression<Func<bool>> placeholdersValuesboolean = null, Expression<Func<bool>> placeholdersValuescontainerNode = null, Expression<Func<bool>> placeholdersValuesdouble = null, Expression<Func<bool>> placeholdersValuesfloat = null, Expression<Func<bool>> placeholdersValuesfloatingPointNumber = null, Expression<Func<bool>> placeholdersValuesint = null, Expression<Func<bool>> placeholdersValuesintegralNumber = null, Expression<Func<bool>> placeholdersValuesLong = null, Expression<Func<bool>> placeholdersValuesmissingNode = null, Expression<Func<placeholdersValuesnodeTypeInput>> placeholdersValuesnodeType = null, Expression<Func<bool>> placeholdersValuesnull = null, Expression<Func<bool>> placeholdersValuesnumber = null, Expression<Func<bool>> placeholdersValuesObject = null, Expression<Func<bool>> placeholdersValuespojo = null, Expression<Func<bool>> placeholdersValuesShort = null, Expression<Func<bool>> placeholdersValuestextual = null, Expression<Func<bool>> placeholdersValuesvalueNode = null)
        {
            var __workflow_id = id == null ? null : WorkflowExpression.Compile(id);
            WorkflowExpression.Validate(__workflow_id, nameof(id), required: true);
            var __workflow_operationId = operationId == null ? null : WorkflowExpression.Compile(operationId);
            WorkflowExpression.Validate(__workflow_operationId, nameof(operationId), required: true);
            var __workflow_placeholdersValuesarray = placeholdersValuesarray == null ? null : WorkflowExpression.Compile(placeholdersValuesarray);
            WorkflowExpression.Validate(__workflow_placeholdersValuesarray, nameof(placeholdersValuesarray), required: false);
            var __workflow_placeholdersValuesbigDecimal = placeholdersValuesbigDecimal == null ? null : WorkflowExpression.Compile(placeholdersValuesbigDecimal);
            WorkflowExpression.Validate(__workflow_placeholdersValuesbigDecimal, nameof(placeholdersValuesbigDecimal), required: false);
            var __workflow_placeholdersValuesbigInteger = placeholdersValuesbigInteger == null ? null : WorkflowExpression.Compile(placeholdersValuesbigInteger);
            WorkflowExpression.Validate(__workflow_placeholdersValuesbigInteger, nameof(placeholdersValuesbigInteger), required: false);
            var __workflow_placeholdersValuesbinary = placeholdersValuesbinary == null ? null : WorkflowExpression.Compile(placeholdersValuesbinary);
            WorkflowExpression.Validate(__workflow_placeholdersValuesbinary, nameof(placeholdersValuesbinary), required: false);
            var __workflow_placeholdersValuesboolean = placeholdersValuesboolean == null ? null : WorkflowExpression.Compile(placeholdersValuesboolean);
            WorkflowExpression.Validate(__workflow_placeholdersValuesboolean, nameof(placeholdersValuesboolean), required: false);
            var __workflow_placeholdersValuescontainerNode = placeholdersValuescontainerNode == null ? null : WorkflowExpression.Compile(placeholdersValuescontainerNode);
            WorkflowExpression.Validate(__workflow_placeholdersValuescontainerNode, nameof(placeholdersValuescontainerNode), required: false);
            var __workflow_placeholdersValuesdouble = placeholdersValuesdouble == null ? null : WorkflowExpression.Compile(placeholdersValuesdouble);
            WorkflowExpression.Validate(__workflow_placeholdersValuesdouble, nameof(placeholdersValuesdouble), required: false);
            var __workflow_placeholdersValuesfloat = placeholdersValuesfloat == null ? null : WorkflowExpression.Compile(placeholdersValuesfloat);
            WorkflowExpression.Validate(__workflow_placeholdersValuesfloat, nameof(placeholdersValuesfloat), required: false);
            var __workflow_placeholdersValuesfloatingPointNumber = placeholdersValuesfloatingPointNumber == null ? null : WorkflowExpression.Compile(placeholdersValuesfloatingPointNumber);
            WorkflowExpression.Validate(__workflow_placeholdersValuesfloatingPointNumber, nameof(placeholdersValuesfloatingPointNumber), required: false);
            var __workflow_placeholdersValuesint = placeholdersValuesint == null ? null : WorkflowExpression.Compile(placeholdersValuesint);
            WorkflowExpression.Validate(__workflow_placeholdersValuesint, nameof(placeholdersValuesint), required: false);
            var __workflow_placeholdersValuesintegralNumber = placeholdersValuesintegralNumber == null ? null : WorkflowExpression.Compile(placeholdersValuesintegralNumber);
            WorkflowExpression.Validate(__workflow_placeholdersValuesintegralNumber, nameof(placeholdersValuesintegralNumber), required: false);
            var __workflow_placeholdersValuesLong = placeholdersValuesLong == null ? null : WorkflowExpression.Compile(placeholdersValuesLong);
            WorkflowExpression.Validate(__workflow_placeholdersValuesLong, nameof(placeholdersValuesLong), required: false);
            var __workflow_placeholdersValuesmissingNode = placeholdersValuesmissingNode == null ? null : WorkflowExpression.Compile(placeholdersValuesmissingNode);
            WorkflowExpression.Validate(__workflow_placeholdersValuesmissingNode, nameof(placeholdersValuesmissingNode), required: false);
            var __workflow_placeholdersValuesnodeType = placeholdersValuesnodeType == null ? null : WorkflowExpression.Compile(placeholdersValuesnodeType);
            WorkflowExpression.Validate(__workflow_placeholdersValuesnodeType, nameof(placeholdersValuesnodeType), required: false);
            var __workflow_placeholdersValuesnull = placeholdersValuesnull == null ? null : WorkflowExpression.Compile(placeholdersValuesnull);
            WorkflowExpression.Validate(__workflow_placeholdersValuesnull, nameof(placeholdersValuesnull), required: false);
            var __workflow_placeholdersValuesnumber = placeholdersValuesnumber == null ? null : WorkflowExpression.Compile(placeholdersValuesnumber);
            WorkflowExpression.Validate(__workflow_placeholdersValuesnumber, nameof(placeholdersValuesnumber), required: false);
            var __workflow_placeholdersValuesObject = placeholdersValuesObject == null ? null : WorkflowExpression.Compile(placeholdersValuesObject);
            WorkflowExpression.Validate(__workflow_placeholdersValuesObject, nameof(placeholdersValuesObject), required: false);
            var __workflow_placeholdersValuespojo = placeholdersValuespojo == null ? null : WorkflowExpression.Compile(placeholdersValuespojo);
            WorkflowExpression.Validate(__workflow_placeholdersValuespojo, nameof(placeholdersValuespojo), required: false);
            var __workflow_placeholdersValuesShort = placeholdersValuesShort == null ? null : WorkflowExpression.Compile(placeholdersValuesShort);
            WorkflowExpression.Validate(__workflow_placeholdersValuesShort, nameof(placeholdersValuesShort), required: false);
            var __workflow_placeholdersValuestextual = placeholdersValuestextual == null ? null : WorkflowExpression.Compile(placeholdersValuestextual);
            WorkflowExpression.Validate(__workflow_placeholdersValuestextual, nameof(placeholdersValuestextual), required: false);
            var __workflow_placeholdersValuesvalueNode = placeholdersValuesvalueNode == null ? null : WorkflowExpression.Compile(placeholdersValuesvalueNode);
            WorkflowExpression.Validate(__workflow_placeholdersValuesvalueNode, nameof(placeholdersValuesvalueNode), required: false);
            return new DeferredBodyAction<ResponseEntity>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/things/{0}/operations/{1}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_operationId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var placeholdersValues = new JObject();
                var placeholdersValuespropCount = 0;
                if (__workflow_placeholdersValuesarray != null)
                {
                    placeholdersValues["array"] = ExpressionConverter.ConvertO(__workflow_placeholdersValuesarray);
                    placeholdersValuespropCount++;
                }

                if (__workflow_placeholdersValuesbigDecimal != null)
                {
                    placeholdersValues["bigDecimal"] = ExpressionConverter.ConvertO(__workflow_placeholdersValuesbigDecimal);
                    placeholdersValuespropCount++;
                }

                if (__workflow_placeholdersValuesbigInteger != null)
                {
                    placeholdersValues["bigInteger"] = ExpressionConverter.ConvertO(__workflow_placeholdersValuesbigInteger);
                    placeholdersValuespropCount++;
                }

                if (__workflow_placeholdersValuesbinary != null)
                {
                    placeholdersValues["binary"] = ExpressionConverter.ConvertO(__workflow_placeholdersValuesbinary);
                    placeholdersValuespropCount++;
                }

                if (__workflow_placeholdersValuesboolean != null)
                {
                    placeholdersValues["boolean"] = ExpressionConverter.ConvertO(__workflow_placeholdersValuesboolean);
                    placeholdersValuespropCount++;
                }

                if (__workflow_placeholdersValuescontainerNode != null)
                {
                    placeholdersValues["containerNode"] = ExpressionConverter.ConvertO(__workflow_placeholdersValuescontainerNode);
                    placeholdersValuespropCount++;
                }

                if (__workflow_placeholdersValuesdouble != null)
                {
                    placeholdersValues["double"] = ExpressionConverter.ConvertO(__workflow_placeholdersValuesdouble);
                    placeholdersValuespropCount++;
                }

                if (__workflow_placeholdersValuesfloat != null)
                {
                    placeholdersValues["float"] = ExpressionConverter.ConvertO(__workflow_placeholdersValuesfloat);
                    placeholdersValuespropCount++;
                }

                if (__workflow_placeholdersValuesfloatingPointNumber != null)
                {
                    placeholdersValues["floatingPointNumber"] = ExpressionConverter.ConvertO(__workflow_placeholdersValuesfloatingPointNumber);
                    placeholdersValuespropCount++;
                }

                if (__workflow_placeholdersValuesint != null)
                {
                    placeholdersValues["int"] = ExpressionConverter.ConvertO(__workflow_placeholdersValuesint);
                    placeholdersValuespropCount++;
                }

                if (__workflow_placeholdersValuesintegralNumber != null)
                {
                    placeholdersValues["integralNumber"] = ExpressionConverter.ConvertO(__workflow_placeholdersValuesintegralNumber);
                    placeholdersValuespropCount++;
                }

                if (__workflow_placeholdersValuesLong != null)
                {
                    placeholdersValues["long"] = ExpressionConverter.ConvertO(__workflow_placeholdersValuesLong);
                    placeholdersValuespropCount++;
                }

                if (__workflow_placeholdersValuesmissingNode != null)
                {
                    placeholdersValues["missingNode"] = ExpressionConverter.ConvertO(__workflow_placeholdersValuesmissingNode);
                    placeholdersValuespropCount++;
                }

                if (__workflow_placeholdersValuesnodeType != null)
                {
                    placeholdersValues["nodeType"] = ExpressionConverter.ConvertO(__workflow_placeholdersValuesnodeType);
                    placeholdersValuespropCount++;
                }

                if (__workflow_placeholdersValuesnull != null)
                {
                    placeholdersValues["null"] = ExpressionConverter.ConvertO(__workflow_placeholdersValuesnull);
                    placeholdersValuespropCount++;
                }

                if (__workflow_placeholdersValuesnumber != null)
                {
                    placeholdersValues["number"] = ExpressionConverter.ConvertO(__workflow_placeholdersValuesnumber);
                    placeholdersValuespropCount++;
                }

                if (__workflow_placeholdersValuesObject != null)
                {
                    placeholdersValues["object"] = ExpressionConverter.ConvertO(__workflow_placeholdersValuesObject);
                    placeholdersValuespropCount++;
                }

                if (__workflow_placeholdersValuespojo != null)
                {
                    placeholdersValues["pojo"] = ExpressionConverter.ConvertO(__workflow_placeholdersValuespojo);
                    placeholdersValuespropCount++;
                }

                if (__workflow_placeholdersValuesShort != null)
                {
                    placeholdersValues["short"] = ExpressionConverter.ConvertO(__workflow_placeholdersValuesShort);
                    placeholdersValuespropCount++;
                }

                if (__workflow_placeholdersValuestextual != null)
                {
                    placeholdersValues["textual"] = ExpressionConverter.ConvertO(__workflow_placeholdersValuestextual);
                    placeholdersValuespropCount++;
                }

                if (__workflow_placeholdersValuesvalueNode != null)
                {
                    placeholdersValues["valueNode"] = ExpressionConverter.ConvertO(__workflow_placeholdersValuesvalueNode);
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
        public IBodyWorkflowAction<SingleThingRo> UpdateThingFixedPosition(Expression<Func<string>> id, Expression<Func<string>> thingRoname, Expression<Func<string>> thingRositeaddress, Expression<Func<string>> thingRositecity, Expression<Func<string>> thingRositename, Expression<Func<string>> thingRositepostalCode, Expression<Func<CustomFieldRo[]>> thingRocustomFields = null, Expression<Func<string>> thingRodescription = null, Expression<Func<string>> thingRodisplayName = null, Expression<Func<bool>> thingRodynamicGps = null, Expression<Func<double>> thingRofixedLatitude = null, Expression<Func<double>> thingRofixedLongitude = null, Expression<Func<string>> thingRofixedName = null, Expression<Func<string>> thingRoid = null, Expression<Func<int>> thingRolastActivityDate = null, Expression<Func<double>> thingRolastLatitude = null, Expression<Func<double>> thingRolastLongitude = null, Expression<Func<bool>> thingRolastMeasurementsarray = null, Expression<Func<bool>> thingRolastMeasurementsbigDecimal = null, Expression<Func<bool>> thingRolastMeasurementsbigInteger = null, Expression<Func<bool>> thingRolastMeasurementsbinary = null, Expression<Func<bool>> thingRolastMeasurementsboolean = null, Expression<Func<bool>> thingRolastMeasurementscontainerNode = null, Expression<Func<bool>> thingRolastMeasurementsdouble = null, Expression<Func<bool>> thingRolastMeasurementsfloat = null, Expression<Func<bool>> thingRolastMeasurementsfloatingPointNumber = null, Expression<Func<bool>> thingRolastMeasurementsint = null, Expression<Func<bool>> thingRolastMeasurementsintegralNumber = null, Expression<Func<bool>> thingRolastMeasurementsLong = null, Expression<Func<bool>> thingRolastMeasurementsmissingNode = null, Expression<Func<thingRolastMeasurementsnodeTypeInput>> thingRolastMeasurementsnodeType = null, Expression<Func<bool>> thingRolastMeasurementsnull = null, Expression<Func<bool>> thingRolastMeasurementsnumber = null, Expression<Func<bool>> thingRolastMeasurementsObject = null, Expression<Func<bool>> thingRolastMeasurementspojo = null, Expression<Func<bool>> thingRolastMeasurementsShort = null, Expression<Func<bool>> thingRolastMeasurementstextual = null, Expression<Func<bool>> thingRolastMeasurementsvalueNode = null, Expression<Func<bool>> thingRolastMeasurementsTimestampsarray = null, Expression<Func<bool>> thingRolastMeasurementsTimestampsbigDecimal = null, Expression<Func<bool>> thingRolastMeasurementsTimestampsbigInteger = null, Expression<Func<bool>> thingRolastMeasurementsTimestampsbinary = null, Expression<Func<bool>> thingRolastMeasurementsTimestampsboolean = null, Expression<Func<bool>> thingRolastMeasurementsTimestampscontainerNode = null, Expression<Func<bool>> thingRolastMeasurementsTimestampsdouble = null, Expression<Func<bool>> thingRolastMeasurementsTimestampsfloat = null, Expression<Func<bool>> thingRolastMeasurementsTimestampsfloatingPointNumber = null, Expression<Func<bool>> thingRolastMeasurementsTimestampsint = null, Expression<Func<bool>> thingRolastMeasurementsTimestampsintegralNumber = null, Expression<Func<bool>> thingRolastMeasurementsTimestampsLong = null, Expression<Func<bool>> thingRolastMeasurementsTimestampsmissingNode = null, Expression<Func<thingRolastMeasurementsTimestampsnodeTypeInput>> thingRolastMeasurementsTimestampsnodeType = null, Expression<Func<bool>> thingRolastMeasurementsTimestampsnull = null, Expression<Func<bool>> thingRolastMeasurementsTimestampsnumber = null, Expression<Func<bool>> thingRolastMeasurementsTimestampsObject = null, Expression<Func<bool>> thingRolastMeasurementsTimestampspojo = null, Expression<Func<bool>> thingRolastMeasurementsTimestampsShort = null, Expression<Func<bool>> thingRolastMeasurementsTimestampstextual = null, Expression<Func<bool>> thingRolastMeasurementsTimestampsvalueNode = null, Expression<Func<int>> thingRolastMessageDate = null, Expression<Func<int>> thingRomessageActivityTimeoutPeriod = null, Expression<Func<int>> thingRonbAlerts = null, Expression<Func<string>> thingRositeid = null, Expression<Func<double>> thingRositelatitude = null, Expression<Func<double>> thingRositelongitude = null, Expression<Func<thingRostatusInput>> thingRostatus = null, Expression<Func<ThingTagRo[]>> thingRotags = null)
        {
            var __workflow_id = id == null ? null : WorkflowExpression.Compile(id);
            WorkflowExpression.Validate(__workflow_id, nameof(id), required: true);
            var __workflow_thingRoname = thingRoname == null ? null : WorkflowExpression.Compile(thingRoname);
            WorkflowExpression.Validate(__workflow_thingRoname, nameof(thingRoname), required: true);
            var __workflow_thingRositeaddress = thingRositeaddress == null ? null : WorkflowExpression.Compile(thingRositeaddress);
            WorkflowExpression.Validate(__workflow_thingRositeaddress, nameof(thingRositeaddress), required: true);
            var __workflow_thingRositecity = thingRositecity == null ? null : WorkflowExpression.Compile(thingRositecity);
            WorkflowExpression.Validate(__workflow_thingRositecity, nameof(thingRositecity), required: true);
            var __workflow_thingRositename = thingRositename == null ? null : WorkflowExpression.Compile(thingRositename);
            WorkflowExpression.Validate(__workflow_thingRositename, nameof(thingRositename), required: true);
            var __workflow_thingRositepostalCode = thingRositepostalCode == null ? null : WorkflowExpression.Compile(thingRositepostalCode);
            WorkflowExpression.Validate(__workflow_thingRositepostalCode, nameof(thingRositepostalCode), required: true);
            var __workflow_thingRocustomFields = thingRocustomFields == null ? null : WorkflowExpression.Compile(thingRocustomFields);
            WorkflowExpression.Validate(__workflow_thingRocustomFields, nameof(thingRocustomFields), required: false);
            var __workflow_thingRodescription = thingRodescription == null ? null : WorkflowExpression.Compile(thingRodescription);
            WorkflowExpression.Validate(__workflow_thingRodescription, nameof(thingRodescription), required: false);
            var __workflow_thingRodisplayName = thingRodisplayName == null ? null : WorkflowExpression.Compile(thingRodisplayName);
            WorkflowExpression.Validate(__workflow_thingRodisplayName, nameof(thingRodisplayName), required: false);
            var __workflow_thingRodynamicGps = thingRodynamicGps == null ? null : WorkflowExpression.Compile(thingRodynamicGps);
            WorkflowExpression.Validate(__workflow_thingRodynamicGps, nameof(thingRodynamicGps), required: false);
            var __workflow_thingRofixedLatitude = thingRofixedLatitude == null ? null : WorkflowExpression.Compile(thingRofixedLatitude);
            WorkflowExpression.Validate(__workflow_thingRofixedLatitude, nameof(thingRofixedLatitude), required: false);
            var __workflow_thingRofixedLongitude = thingRofixedLongitude == null ? null : WorkflowExpression.Compile(thingRofixedLongitude);
            WorkflowExpression.Validate(__workflow_thingRofixedLongitude, nameof(thingRofixedLongitude), required: false);
            var __workflow_thingRofixedName = thingRofixedName == null ? null : WorkflowExpression.Compile(thingRofixedName);
            WorkflowExpression.Validate(__workflow_thingRofixedName, nameof(thingRofixedName), required: false);
            var __workflow_thingRoid = thingRoid == null ? null : WorkflowExpression.Compile(thingRoid);
            WorkflowExpression.Validate(__workflow_thingRoid, nameof(thingRoid), required: false);
            var __workflow_thingRolastActivityDate = thingRolastActivityDate == null ? null : WorkflowExpression.Compile(thingRolastActivityDate);
            WorkflowExpression.Validate(__workflow_thingRolastActivityDate, nameof(thingRolastActivityDate), required: false);
            var __workflow_thingRolastLatitude = thingRolastLatitude == null ? null : WorkflowExpression.Compile(thingRolastLatitude);
            WorkflowExpression.Validate(__workflow_thingRolastLatitude, nameof(thingRolastLatitude), required: false);
            var __workflow_thingRolastLongitude = thingRolastLongitude == null ? null : WorkflowExpression.Compile(thingRolastLongitude);
            WorkflowExpression.Validate(__workflow_thingRolastLongitude, nameof(thingRolastLongitude), required: false);
            var __workflow_thingRolastMeasurementsarray = thingRolastMeasurementsarray == null ? null : WorkflowExpression.Compile(thingRolastMeasurementsarray);
            WorkflowExpression.Validate(__workflow_thingRolastMeasurementsarray, nameof(thingRolastMeasurementsarray), required: false);
            var __workflow_thingRolastMeasurementsbigDecimal = thingRolastMeasurementsbigDecimal == null ? null : WorkflowExpression.Compile(thingRolastMeasurementsbigDecimal);
            WorkflowExpression.Validate(__workflow_thingRolastMeasurementsbigDecimal, nameof(thingRolastMeasurementsbigDecimal), required: false);
            var __workflow_thingRolastMeasurementsbigInteger = thingRolastMeasurementsbigInteger == null ? null : WorkflowExpression.Compile(thingRolastMeasurementsbigInteger);
            WorkflowExpression.Validate(__workflow_thingRolastMeasurementsbigInteger, nameof(thingRolastMeasurementsbigInteger), required: false);
            var __workflow_thingRolastMeasurementsbinary = thingRolastMeasurementsbinary == null ? null : WorkflowExpression.Compile(thingRolastMeasurementsbinary);
            WorkflowExpression.Validate(__workflow_thingRolastMeasurementsbinary, nameof(thingRolastMeasurementsbinary), required: false);
            var __workflow_thingRolastMeasurementsboolean = thingRolastMeasurementsboolean == null ? null : WorkflowExpression.Compile(thingRolastMeasurementsboolean);
            WorkflowExpression.Validate(__workflow_thingRolastMeasurementsboolean, nameof(thingRolastMeasurementsboolean), required: false);
            var __workflow_thingRolastMeasurementscontainerNode = thingRolastMeasurementscontainerNode == null ? null : WorkflowExpression.Compile(thingRolastMeasurementscontainerNode);
            WorkflowExpression.Validate(__workflow_thingRolastMeasurementscontainerNode, nameof(thingRolastMeasurementscontainerNode), required: false);
            var __workflow_thingRolastMeasurementsdouble = thingRolastMeasurementsdouble == null ? null : WorkflowExpression.Compile(thingRolastMeasurementsdouble);
            WorkflowExpression.Validate(__workflow_thingRolastMeasurementsdouble, nameof(thingRolastMeasurementsdouble), required: false);
            var __workflow_thingRolastMeasurementsfloat = thingRolastMeasurementsfloat == null ? null : WorkflowExpression.Compile(thingRolastMeasurementsfloat);
            WorkflowExpression.Validate(__workflow_thingRolastMeasurementsfloat, nameof(thingRolastMeasurementsfloat), required: false);
            var __workflow_thingRolastMeasurementsfloatingPointNumber = thingRolastMeasurementsfloatingPointNumber == null ? null : WorkflowExpression.Compile(thingRolastMeasurementsfloatingPointNumber);
            WorkflowExpression.Validate(__workflow_thingRolastMeasurementsfloatingPointNumber, nameof(thingRolastMeasurementsfloatingPointNumber), required: false);
            var __workflow_thingRolastMeasurementsint = thingRolastMeasurementsint == null ? null : WorkflowExpression.Compile(thingRolastMeasurementsint);
            WorkflowExpression.Validate(__workflow_thingRolastMeasurementsint, nameof(thingRolastMeasurementsint), required: false);
            var __workflow_thingRolastMeasurementsintegralNumber = thingRolastMeasurementsintegralNumber == null ? null : WorkflowExpression.Compile(thingRolastMeasurementsintegralNumber);
            WorkflowExpression.Validate(__workflow_thingRolastMeasurementsintegralNumber, nameof(thingRolastMeasurementsintegralNumber), required: false);
            var __workflow_thingRolastMeasurementsLong = thingRolastMeasurementsLong == null ? null : WorkflowExpression.Compile(thingRolastMeasurementsLong);
            WorkflowExpression.Validate(__workflow_thingRolastMeasurementsLong, nameof(thingRolastMeasurementsLong), required: false);
            var __workflow_thingRolastMeasurementsmissingNode = thingRolastMeasurementsmissingNode == null ? null : WorkflowExpression.Compile(thingRolastMeasurementsmissingNode);
            WorkflowExpression.Validate(__workflow_thingRolastMeasurementsmissingNode, nameof(thingRolastMeasurementsmissingNode), required: false);
            var __workflow_thingRolastMeasurementsnodeType = thingRolastMeasurementsnodeType == null ? null : WorkflowExpression.Compile(thingRolastMeasurementsnodeType);
            WorkflowExpression.Validate(__workflow_thingRolastMeasurementsnodeType, nameof(thingRolastMeasurementsnodeType), required: false);
            var __workflow_thingRolastMeasurementsnull = thingRolastMeasurementsnull == null ? null : WorkflowExpression.Compile(thingRolastMeasurementsnull);
            WorkflowExpression.Validate(__workflow_thingRolastMeasurementsnull, nameof(thingRolastMeasurementsnull), required: false);
            var __workflow_thingRolastMeasurementsnumber = thingRolastMeasurementsnumber == null ? null : WorkflowExpression.Compile(thingRolastMeasurementsnumber);
            WorkflowExpression.Validate(__workflow_thingRolastMeasurementsnumber, nameof(thingRolastMeasurementsnumber), required: false);
            var __workflow_thingRolastMeasurementsObject = thingRolastMeasurementsObject == null ? null : WorkflowExpression.Compile(thingRolastMeasurementsObject);
            WorkflowExpression.Validate(__workflow_thingRolastMeasurementsObject, nameof(thingRolastMeasurementsObject), required: false);
            var __workflow_thingRolastMeasurementspojo = thingRolastMeasurementspojo == null ? null : WorkflowExpression.Compile(thingRolastMeasurementspojo);
            WorkflowExpression.Validate(__workflow_thingRolastMeasurementspojo, nameof(thingRolastMeasurementspojo), required: false);
            var __workflow_thingRolastMeasurementsShort = thingRolastMeasurementsShort == null ? null : WorkflowExpression.Compile(thingRolastMeasurementsShort);
            WorkflowExpression.Validate(__workflow_thingRolastMeasurementsShort, nameof(thingRolastMeasurementsShort), required: false);
            var __workflow_thingRolastMeasurementstextual = thingRolastMeasurementstextual == null ? null : WorkflowExpression.Compile(thingRolastMeasurementstextual);
            WorkflowExpression.Validate(__workflow_thingRolastMeasurementstextual, nameof(thingRolastMeasurementstextual), required: false);
            var __workflow_thingRolastMeasurementsvalueNode = thingRolastMeasurementsvalueNode == null ? null : WorkflowExpression.Compile(thingRolastMeasurementsvalueNode);
            WorkflowExpression.Validate(__workflow_thingRolastMeasurementsvalueNode, nameof(thingRolastMeasurementsvalueNode), required: false);
            var __workflow_thingRolastMeasurementsTimestampsarray = thingRolastMeasurementsTimestampsarray == null ? null : WorkflowExpression.Compile(thingRolastMeasurementsTimestampsarray);
            WorkflowExpression.Validate(__workflow_thingRolastMeasurementsTimestampsarray, nameof(thingRolastMeasurementsTimestampsarray), required: false);
            var __workflow_thingRolastMeasurementsTimestampsbigDecimal = thingRolastMeasurementsTimestampsbigDecimal == null ? null : WorkflowExpression.Compile(thingRolastMeasurementsTimestampsbigDecimal);
            WorkflowExpression.Validate(__workflow_thingRolastMeasurementsTimestampsbigDecimal, nameof(thingRolastMeasurementsTimestampsbigDecimal), required: false);
            var __workflow_thingRolastMeasurementsTimestampsbigInteger = thingRolastMeasurementsTimestampsbigInteger == null ? null : WorkflowExpression.Compile(thingRolastMeasurementsTimestampsbigInteger);
            WorkflowExpression.Validate(__workflow_thingRolastMeasurementsTimestampsbigInteger, nameof(thingRolastMeasurementsTimestampsbigInteger), required: false);
            var __workflow_thingRolastMeasurementsTimestampsbinary = thingRolastMeasurementsTimestampsbinary == null ? null : WorkflowExpression.Compile(thingRolastMeasurementsTimestampsbinary);
            WorkflowExpression.Validate(__workflow_thingRolastMeasurementsTimestampsbinary, nameof(thingRolastMeasurementsTimestampsbinary), required: false);
            var __workflow_thingRolastMeasurementsTimestampsboolean = thingRolastMeasurementsTimestampsboolean == null ? null : WorkflowExpression.Compile(thingRolastMeasurementsTimestampsboolean);
            WorkflowExpression.Validate(__workflow_thingRolastMeasurementsTimestampsboolean, nameof(thingRolastMeasurementsTimestampsboolean), required: false);
            var __workflow_thingRolastMeasurementsTimestampscontainerNode = thingRolastMeasurementsTimestampscontainerNode == null ? null : WorkflowExpression.Compile(thingRolastMeasurementsTimestampscontainerNode);
            WorkflowExpression.Validate(__workflow_thingRolastMeasurementsTimestampscontainerNode, nameof(thingRolastMeasurementsTimestampscontainerNode), required: false);
            var __workflow_thingRolastMeasurementsTimestampsdouble = thingRolastMeasurementsTimestampsdouble == null ? null : WorkflowExpression.Compile(thingRolastMeasurementsTimestampsdouble);
            WorkflowExpression.Validate(__workflow_thingRolastMeasurementsTimestampsdouble, nameof(thingRolastMeasurementsTimestampsdouble), required: false);
            var __workflow_thingRolastMeasurementsTimestampsfloat = thingRolastMeasurementsTimestampsfloat == null ? null : WorkflowExpression.Compile(thingRolastMeasurementsTimestampsfloat);
            WorkflowExpression.Validate(__workflow_thingRolastMeasurementsTimestampsfloat, nameof(thingRolastMeasurementsTimestampsfloat), required: false);
            var __workflow_thingRolastMeasurementsTimestampsfloatingPointNumber = thingRolastMeasurementsTimestampsfloatingPointNumber == null ? null : WorkflowExpression.Compile(thingRolastMeasurementsTimestampsfloatingPointNumber);
            WorkflowExpression.Validate(__workflow_thingRolastMeasurementsTimestampsfloatingPointNumber, nameof(thingRolastMeasurementsTimestampsfloatingPointNumber), required: false);
            var __workflow_thingRolastMeasurementsTimestampsint = thingRolastMeasurementsTimestampsint == null ? null : WorkflowExpression.Compile(thingRolastMeasurementsTimestampsint);
            WorkflowExpression.Validate(__workflow_thingRolastMeasurementsTimestampsint, nameof(thingRolastMeasurementsTimestampsint), required: false);
            var __workflow_thingRolastMeasurementsTimestampsintegralNumber = thingRolastMeasurementsTimestampsintegralNumber == null ? null : WorkflowExpression.Compile(thingRolastMeasurementsTimestampsintegralNumber);
            WorkflowExpression.Validate(__workflow_thingRolastMeasurementsTimestampsintegralNumber, nameof(thingRolastMeasurementsTimestampsintegralNumber), required: false);
            var __workflow_thingRolastMeasurementsTimestampsLong = thingRolastMeasurementsTimestampsLong == null ? null : WorkflowExpression.Compile(thingRolastMeasurementsTimestampsLong);
            WorkflowExpression.Validate(__workflow_thingRolastMeasurementsTimestampsLong, nameof(thingRolastMeasurementsTimestampsLong), required: false);
            var __workflow_thingRolastMeasurementsTimestampsmissingNode = thingRolastMeasurementsTimestampsmissingNode == null ? null : WorkflowExpression.Compile(thingRolastMeasurementsTimestampsmissingNode);
            WorkflowExpression.Validate(__workflow_thingRolastMeasurementsTimestampsmissingNode, nameof(thingRolastMeasurementsTimestampsmissingNode), required: false);
            var __workflow_thingRolastMeasurementsTimestampsnodeType = thingRolastMeasurementsTimestampsnodeType == null ? null : WorkflowExpression.Compile(thingRolastMeasurementsTimestampsnodeType);
            WorkflowExpression.Validate(__workflow_thingRolastMeasurementsTimestampsnodeType, nameof(thingRolastMeasurementsTimestampsnodeType), required: false);
            var __workflow_thingRolastMeasurementsTimestampsnull = thingRolastMeasurementsTimestampsnull == null ? null : WorkflowExpression.Compile(thingRolastMeasurementsTimestampsnull);
            WorkflowExpression.Validate(__workflow_thingRolastMeasurementsTimestampsnull, nameof(thingRolastMeasurementsTimestampsnull), required: false);
            var __workflow_thingRolastMeasurementsTimestampsnumber = thingRolastMeasurementsTimestampsnumber == null ? null : WorkflowExpression.Compile(thingRolastMeasurementsTimestampsnumber);
            WorkflowExpression.Validate(__workflow_thingRolastMeasurementsTimestampsnumber, nameof(thingRolastMeasurementsTimestampsnumber), required: false);
            var __workflow_thingRolastMeasurementsTimestampsObject = thingRolastMeasurementsTimestampsObject == null ? null : WorkflowExpression.Compile(thingRolastMeasurementsTimestampsObject);
            WorkflowExpression.Validate(__workflow_thingRolastMeasurementsTimestampsObject, nameof(thingRolastMeasurementsTimestampsObject), required: false);
            var __workflow_thingRolastMeasurementsTimestampspojo = thingRolastMeasurementsTimestampspojo == null ? null : WorkflowExpression.Compile(thingRolastMeasurementsTimestampspojo);
            WorkflowExpression.Validate(__workflow_thingRolastMeasurementsTimestampspojo, nameof(thingRolastMeasurementsTimestampspojo), required: false);
            var __workflow_thingRolastMeasurementsTimestampsShort = thingRolastMeasurementsTimestampsShort == null ? null : WorkflowExpression.Compile(thingRolastMeasurementsTimestampsShort);
            WorkflowExpression.Validate(__workflow_thingRolastMeasurementsTimestampsShort, nameof(thingRolastMeasurementsTimestampsShort), required: false);
            var __workflow_thingRolastMeasurementsTimestampstextual = thingRolastMeasurementsTimestampstextual == null ? null : WorkflowExpression.Compile(thingRolastMeasurementsTimestampstextual);
            WorkflowExpression.Validate(__workflow_thingRolastMeasurementsTimestampstextual, nameof(thingRolastMeasurementsTimestampstextual), required: false);
            var __workflow_thingRolastMeasurementsTimestampsvalueNode = thingRolastMeasurementsTimestampsvalueNode == null ? null : WorkflowExpression.Compile(thingRolastMeasurementsTimestampsvalueNode);
            WorkflowExpression.Validate(__workflow_thingRolastMeasurementsTimestampsvalueNode, nameof(thingRolastMeasurementsTimestampsvalueNode), required: false);
            var __workflow_thingRolastMessageDate = thingRolastMessageDate == null ? null : WorkflowExpression.Compile(thingRolastMessageDate);
            WorkflowExpression.Validate(__workflow_thingRolastMessageDate, nameof(thingRolastMessageDate), required: false);
            var __workflow_thingRomessageActivityTimeoutPeriod = thingRomessageActivityTimeoutPeriod == null ? null : WorkflowExpression.Compile(thingRomessageActivityTimeoutPeriod);
            WorkflowExpression.Validate(__workflow_thingRomessageActivityTimeoutPeriod, nameof(thingRomessageActivityTimeoutPeriod), required: false);
            var __workflow_thingRonbAlerts = thingRonbAlerts == null ? null : WorkflowExpression.Compile(thingRonbAlerts);
            WorkflowExpression.Validate(__workflow_thingRonbAlerts, nameof(thingRonbAlerts), required: false);
            var __workflow_thingRositeid = thingRositeid == null ? null : WorkflowExpression.Compile(thingRositeid);
            WorkflowExpression.Validate(__workflow_thingRositeid, nameof(thingRositeid), required: false);
            var __workflow_thingRositelatitude = thingRositelatitude == null ? null : WorkflowExpression.Compile(thingRositelatitude);
            WorkflowExpression.Validate(__workflow_thingRositelatitude, nameof(thingRositelatitude), required: false);
            var __workflow_thingRositelongitude = thingRositelongitude == null ? null : WorkflowExpression.Compile(thingRositelongitude);
            WorkflowExpression.Validate(__workflow_thingRositelongitude, nameof(thingRositelongitude), required: false);
            var __workflow_thingRostatus = thingRostatus == null ? null : WorkflowExpression.Compile(thingRostatus);
            WorkflowExpression.Validate(__workflow_thingRostatus, nameof(thingRostatus), required: false);
            var __workflow_thingRotags = thingRotags == null ? null : WorkflowExpression.Compile(thingRotags);
            WorkflowExpression.Validate(__workflow_thingRotags, nameof(thingRotags), required: false);
            return new DeferredBodyAction<SingleThingRo>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/things/{0}/positions", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var thingRo = new JObject();
                var thingRopropCount = 0;
                if (__workflow_thingRocustomFields != null)
                {
                    thingRo["customFields"] = ExpressionConverter.ConvertO(__workflow_thingRocustomFields);
                    thingRopropCount++;
                }

                if (__workflow_thingRodescription != null)
                {
                    thingRo["description"] = ExpressionConverter.ConvertO(__workflow_thingRodescription);
                    thingRopropCount++;
                }

                if (__workflow_thingRodisplayName != null)
                {
                    thingRo["displayName"] = ExpressionConverter.ConvertO(__workflow_thingRodisplayName);
                    thingRopropCount++;
                }

                if (__workflow_thingRodynamicGps != null)
                {
                    thingRo["dynamicGps"] = ExpressionConverter.ConvertO(__workflow_thingRodynamicGps);
                    thingRopropCount++;
                }

                if (__workflow_thingRofixedLatitude != null)
                {
                    thingRo["fixedLatitude"] = ExpressionConverter.ConvertO(__workflow_thingRofixedLatitude);
                    thingRopropCount++;
                }

                if (__workflow_thingRofixedLongitude != null)
                {
                    thingRo["fixedLongitude"] = ExpressionConverter.ConvertO(__workflow_thingRofixedLongitude);
                    thingRopropCount++;
                }

                if (__workflow_thingRofixedName != null)
                {
                    thingRo["fixedName"] = ExpressionConverter.ConvertO(__workflow_thingRofixedName);
                    thingRopropCount++;
                }

                if (__workflow_thingRoid != null)
                {
                    thingRo["id"] = ExpressionConverter.ConvertO(__workflow_thingRoid);
                    thingRopropCount++;
                }

                if (__workflow_thingRolastActivityDate != null)
                {
                    thingRo["lastActivityDate"] = ExpressionConverter.ConvertO(__workflow_thingRolastActivityDate);
                    thingRopropCount++;
                }

                if (__workflow_thingRolastLatitude != null)
                {
                    thingRo["lastLatitude"] = ExpressionConverter.ConvertO(__workflow_thingRolastLatitude);
                    thingRopropCount++;
                }

                if (__workflow_thingRolastLongitude != null)
                {
                    thingRo["lastLongitude"] = ExpressionConverter.ConvertO(__workflow_thingRolastLongitude);
                    thingRopropCount++;
                }

                var lastMeasurementsObject = new JObject();
                var lastMeasurementsObjectpropCount = 0;
                if (__workflow_thingRolastMeasurementsarray != null)
                {
                    lastMeasurementsObject["array"] = ExpressionConverter.ConvertO(__workflow_thingRolastMeasurementsarray);
                    lastMeasurementsObjectpropCount++;
                }

                if (__workflow_thingRolastMeasurementsbigDecimal != null)
                {
                    lastMeasurementsObject["bigDecimal"] = ExpressionConverter.ConvertO(__workflow_thingRolastMeasurementsbigDecimal);
                    lastMeasurementsObjectpropCount++;
                }

                if (__workflow_thingRolastMeasurementsbigInteger != null)
                {
                    lastMeasurementsObject["bigInteger"] = ExpressionConverter.ConvertO(__workflow_thingRolastMeasurementsbigInteger);
                    lastMeasurementsObjectpropCount++;
                }

                if (__workflow_thingRolastMeasurementsbinary != null)
                {
                    lastMeasurementsObject["binary"] = ExpressionConverter.ConvertO(__workflow_thingRolastMeasurementsbinary);
                    lastMeasurementsObjectpropCount++;
                }

                if (__workflow_thingRolastMeasurementsboolean != null)
                {
                    lastMeasurementsObject["boolean"] = ExpressionConverter.ConvertO(__workflow_thingRolastMeasurementsboolean);
                    lastMeasurementsObjectpropCount++;
                }

                if (__workflow_thingRolastMeasurementscontainerNode != null)
                {
                    lastMeasurementsObject["containerNode"] = ExpressionConverter.ConvertO(__workflow_thingRolastMeasurementscontainerNode);
                    lastMeasurementsObjectpropCount++;
                }

                if (__workflow_thingRolastMeasurementsdouble != null)
                {
                    lastMeasurementsObject["double"] = ExpressionConverter.ConvertO(__workflow_thingRolastMeasurementsdouble);
                    lastMeasurementsObjectpropCount++;
                }

                if (__workflow_thingRolastMeasurementsfloat != null)
                {
                    lastMeasurementsObject["float"] = ExpressionConverter.ConvertO(__workflow_thingRolastMeasurementsfloat);
                    lastMeasurementsObjectpropCount++;
                }

                if (__workflow_thingRolastMeasurementsfloatingPointNumber != null)
                {
                    lastMeasurementsObject["floatingPointNumber"] = ExpressionConverter.ConvertO(__workflow_thingRolastMeasurementsfloatingPointNumber);
                    lastMeasurementsObjectpropCount++;
                }

                if (__workflow_thingRolastMeasurementsint != null)
                {
                    lastMeasurementsObject["int"] = ExpressionConverter.ConvertO(__workflow_thingRolastMeasurementsint);
                    lastMeasurementsObjectpropCount++;
                }

                if (__workflow_thingRolastMeasurementsintegralNumber != null)
                {
                    lastMeasurementsObject["integralNumber"] = ExpressionConverter.ConvertO(__workflow_thingRolastMeasurementsintegralNumber);
                    lastMeasurementsObjectpropCount++;
                }

                if (__workflow_thingRolastMeasurementsLong != null)
                {
                    lastMeasurementsObject["long"] = ExpressionConverter.ConvertO(__workflow_thingRolastMeasurementsLong);
                    lastMeasurementsObjectpropCount++;
                }

                if (__workflow_thingRolastMeasurementsmissingNode != null)
                {
                    lastMeasurementsObject["missingNode"] = ExpressionConverter.ConvertO(__workflow_thingRolastMeasurementsmissingNode);
                    lastMeasurementsObjectpropCount++;
                }

                if (__workflow_thingRolastMeasurementsnodeType != null)
                {
                    lastMeasurementsObject["nodeType"] = ExpressionConverter.ConvertO(__workflow_thingRolastMeasurementsnodeType);
                    lastMeasurementsObjectpropCount++;
                }

                if (__workflow_thingRolastMeasurementsnull != null)
                {
                    lastMeasurementsObject["null"] = ExpressionConverter.ConvertO(__workflow_thingRolastMeasurementsnull);
                    lastMeasurementsObjectpropCount++;
                }

                if (__workflow_thingRolastMeasurementsnumber != null)
                {
                    lastMeasurementsObject["number"] = ExpressionConverter.ConvertO(__workflow_thingRolastMeasurementsnumber);
                    lastMeasurementsObjectpropCount++;
                }

                if (__workflow_thingRolastMeasurementsObject != null)
                {
                    lastMeasurementsObject["object"] = ExpressionConverter.ConvertO(__workflow_thingRolastMeasurementsObject);
                    lastMeasurementsObjectpropCount++;
                }

                if (__workflow_thingRolastMeasurementspojo != null)
                {
                    lastMeasurementsObject["pojo"] = ExpressionConverter.ConvertO(__workflow_thingRolastMeasurementspojo);
                    lastMeasurementsObjectpropCount++;
                }

                if (__workflow_thingRolastMeasurementsShort != null)
                {
                    lastMeasurementsObject["short"] = ExpressionConverter.ConvertO(__workflow_thingRolastMeasurementsShort);
                    lastMeasurementsObjectpropCount++;
                }

                if (__workflow_thingRolastMeasurementstextual != null)
                {
                    lastMeasurementsObject["textual"] = ExpressionConverter.ConvertO(__workflow_thingRolastMeasurementstextual);
                    lastMeasurementsObjectpropCount++;
                }

                if (__workflow_thingRolastMeasurementsvalueNode != null)
                {
                    lastMeasurementsObject["valueNode"] = ExpressionConverter.ConvertO(__workflow_thingRolastMeasurementsvalueNode);
                    lastMeasurementsObjectpropCount++;
                }

                if (lastMeasurementsObjectpropCount > 0)
                {
                    thingRo["lastMeasurements"] = lastMeasurementsObject;
                    thingRopropCount++;
                }

                var lastMeasurementsTimestampsObject = new JObject();
                var lastMeasurementsTimestampsObjectpropCount = 0;
                if (__workflow_thingRolastMeasurementsarray != null)
                {
                    lastMeasurementsTimestampsObject["array"] = ExpressionConverter.ConvertO(__workflow_thingRolastMeasurementsarray);
                    lastMeasurementsTimestampsObjectpropCount++;
                }

                if (__workflow_thingRolastMeasurementsbigDecimal != null)
                {
                    lastMeasurementsTimestampsObject["bigDecimal"] = ExpressionConverter.ConvertO(__workflow_thingRolastMeasurementsbigDecimal);
                    lastMeasurementsTimestampsObjectpropCount++;
                }

                if (__workflow_thingRolastMeasurementsbigInteger != null)
                {
                    lastMeasurementsTimestampsObject["bigInteger"] = ExpressionConverter.ConvertO(__workflow_thingRolastMeasurementsbigInteger);
                    lastMeasurementsTimestampsObjectpropCount++;
                }

                if (__workflow_thingRolastMeasurementsbinary != null)
                {
                    lastMeasurementsTimestampsObject["binary"] = ExpressionConverter.ConvertO(__workflow_thingRolastMeasurementsbinary);
                    lastMeasurementsTimestampsObjectpropCount++;
                }

                if (__workflow_thingRolastMeasurementsboolean != null)
                {
                    lastMeasurementsTimestampsObject["boolean"] = ExpressionConverter.ConvertO(__workflow_thingRolastMeasurementsboolean);
                    lastMeasurementsTimestampsObjectpropCount++;
                }

                if (__workflow_thingRolastMeasurementscontainerNode != null)
                {
                    lastMeasurementsTimestampsObject["containerNode"] = ExpressionConverter.ConvertO(__workflow_thingRolastMeasurementscontainerNode);
                    lastMeasurementsTimestampsObjectpropCount++;
                }

                if (__workflow_thingRolastMeasurementsdouble != null)
                {
                    lastMeasurementsTimestampsObject["double"] = ExpressionConverter.ConvertO(__workflow_thingRolastMeasurementsdouble);
                    lastMeasurementsTimestampsObjectpropCount++;
                }

                if (__workflow_thingRolastMeasurementsfloat != null)
                {
                    lastMeasurementsTimestampsObject["float"] = ExpressionConverter.ConvertO(__workflow_thingRolastMeasurementsfloat);
                    lastMeasurementsTimestampsObjectpropCount++;
                }

                if (__workflow_thingRolastMeasurementsfloatingPointNumber != null)
                {
                    lastMeasurementsTimestampsObject["floatingPointNumber"] = ExpressionConverter.ConvertO(__workflow_thingRolastMeasurementsfloatingPointNumber);
                    lastMeasurementsTimestampsObjectpropCount++;
                }

                if (__workflow_thingRolastMeasurementsint != null)
                {
                    lastMeasurementsTimestampsObject["int"] = ExpressionConverter.ConvertO(__workflow_thingRolastMeasurementsint);
                    lastMeasurementsTimestampsObjectpropCount++;
                }

                if (__workflow_thingRolastMeasurementsintegralNumber != null)
                {
                    lastMeasurementsTimestampsObject["integralNumber"] = ExpressionConverter.ConvertO(__workflow_thingRolastMeasurementsintegralNumber);
                    lastMeasurementsTimestampsObjectpropCount++;
                }

                if (__workflow_thingRolastMeasurementsLong != null)
                {
                    lastMeasurementsTimestampsObject["long"] = ExpressionConverter.ConvertO(__workflow_thingRolastMeasurementsLong);
                    lastMeasurementsTimestampsObjectpropCount++;
                }

                if (__workflow_thingRolastMeasurementsmissingNode != null)
                {
                    lastMeasurementsTimestampsObject["missingNode"] = ExpressionConverter.ConvertO(__workflow_thingRolastMeasurementsmissingNode);
                    lastMeasurementsTimestampsObjectpropCount++;
                }

                if (__workflow_thingRolastMeasurementsnodeType != null)
                {
                    lastMeasurementsTimestampsObject["nodeType"] = ExpressionConverter.ConvertO(__workflow_thingRolastMeasurementsnodeType);
                    lastMeasurementsTimestampsObjectpropCount++;
                }

                if (__workflow_thingRolastMeasurementsnull != null)
                {
                    lastMeasurementsTimestampsObject["null"] = ExpressionConverter.ConvertO(__workflow_thingRolastMeasurementsnull);
                    lastMeasurementsTimestampsObjectpropCount++;
                }

                if (__workflow_thingRolastMeasurementsnumber != null)
                {
                    lastMeasurementsTimestampsObject["number"] = ExpressionConverter.ConvertO(__workflow_thingRolastMeasurementsnumber);
                    lastMeasurementsTimestampsObjectpropCount++;
                }

                if (__workflow_thingRolastMeasurementsObject != null)
                {
                    lastMeasurementsTimestampsObject["object"] = ExpressionConverter.ConvertO(__workflow_thingRolastMeasurementsObject);
                    lastMeasurementsTimestampsObjectpropCount++;
                }

                if (__workflow_thingRolastMeasurementspojo != null)
                {
                    lastMeasurementsTimestampsObject["pojo"] = ExpressionConverter.ConvertO(__workflow_thingRolastMeasurementspojo);
                    lastMeasurementsTimestampsObjectpropCount++;
                }

                if (__workflow_thingRolastMeasurementsShort != null)
                {
                    lastMeasurementsTimestampsObject["short"] = ExpressionConverter.ConvertO(__workflow_thingRolastMeasurementsShort);
                    lastMeasurementsTimestampsObjectpropCount++;
                }

                if (__workflow_thingRolastMeasurementstextual != null)
                {
                    lastMeasurementsTimestampsObject["textual"] = ExpressionConverter.ConvertO(__workflow_thingRolastMeasurementstextual);
                    lastMeasurementsTimestampsObjectpropCount++;
                }

                if (__workflow_thingRolastMeasurementsvalueNode != null)
                {
                    lastMeasurementsTimestampsObject["valueNode"] = ExpressionConverter.ConvertO(__workflow_thingRolastMeasurementsvalueNode);
                    lastMeasurementsTimestampsObjectpropCount++;
                }

                if (lastMeasurementsTimestampsObjectpropCount > 0)
                {
                    thingRo["lastMeasurementsTimestamps"] = lastMeasurementsTimestampsObject;
                    thingRopropCount++;
                }

                if (__workflow_thingRolastMessageDate != null)
                {
                    thingRo["lastMessageDate"] = ExpressionConverter.ConvertO(__workflow_thingRolastMessageDate);
                    thingRopropCount++;
                }

                if (__workflow_thingRomessageActivityTimeoutPeriod != null)
                {
                    thingRo["messageActivityTimeoutPeriod"] = ExpressionConverter.ConvertO(__workflow_thingRomessageActivityTimeoutPeriod);
                    thingRopropCount++;
                }

                thingRopropCount++;
                thingRo["name"] = ExpressionConverter.ConvertO(__workflow_thingRoname);
                if (__workflow_thingRonbAlerts != null)
                {
                    thingRo["nbAlerts"] = ExpressionConverter.ConvertO(__workflow_thingRonbAlerts);
                    thingRopropCount++;
                }

                var siteObject = new JObject();
                var siteObjectpropCount = 0;
                siteObjectpropCount++;
                siteObject["address"] = ExpressionConverter.ConvertO(__workflow_thingRositeaddress);
                siteObjectpropCount++;
                siteObject["city"] = ExpressionConverter.ConvertO(__workflow_thingRositecity);
                if (__workflow_thingRositeid != null)
                {
                    siteObject["id"] = ExpressionConverter.ConvertO(__workflow_thingRositeid);
                    siteObjectpropCount++;
                }

                if (__workflow_thingRositelatitude != null)
                {
                    siteObject["latitude"] = ExpressionConverter.ConvertO(__workflow_thingRositelatitude);
                    siteObjectpropCount++;
                }

                if (__workflow_thingRositelongitude != null)
                {
                    siteObject["longitude"] = ExpressionConverter.ConvertO(__workflow_thingRositelongitude);
                    siteObjectpropCount++;
                }

                siteObjectpropCount++;
                siteObject["name"] = ExpressionConverter.ConvertO(__workflow_thingRositename);
                siteObjectpropCount++;
                siteObject["postalCode"] = ExpressionConverter.ConvertO(__workflow_thingRositepostalCode);
                if (siteObjectpropCount > 0)
                {
                    thingRo["site"] = siteObject;
                    thingRopropCount++;
                }

                if (__workflow_thingRostatus != null)
                {
                    thingRo["status"] = ExpressionConverter.ConvertO(__workflow_thingRostatus);
                    thingRopropCount++;
                }

                if (__workflow_thingRotags != null)
                {
                    thingRo["tags"] = ExpressionConverter.ConvertO(__workflow_thingRotags);
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
        public IBodyWorkflowAction<ProductRo> GetThingProduct(Expression<Func<string>> id)
        {
            var __workflow_id = id == null ? null : WorkflowExpression.Compile(id);
            WorkflowExpression.Validate(__workflow_id, nameof(id), required: true);
            return new DeferredBodyAction<ProductRo>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/things/{0}/product", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ProductRo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<SingleThingRo> DissociateThingProduct(Expression<Func<string>> id)
        {
            var __workflow_id = id == null ? null : WorkflowExpression.Compile(id);
            WorkflowExpression.Validate(__workflow_id, nameof(id), required: true);
            return new DeferredBodyAction<SingleThingRo>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/things/{0}/product", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SingleThingRo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<SingleThingRo> AssociateThingProduct(Expression<Func<string>> id, Expression<Func<string>> productcertification = null, Expression<Func<productconnectivityTypesInputItem[]>> productconnectivityTypes = null, Expression<Func<string>> productdecoderid = null, Expression<Func<string>> productdecoderlink = null, Expression<Func<bool>> productdecodervisible = null, Expression<Func<string>> productdescription = null, Expression<Func<string>> productencoderid = null, Expression<Func<string>> productencoderlink = null, Expression<Func<bool>> productgenerateLinks = null, Expression<Func<bool>> producthasImage = null, Expression<Func<string>> productid = null, Expression<Func<string>> productimageLink = null, Expression<Func<string>> productinfoLink = null, Expression<Func<string>> productlink = null, Expression<Func<bool>> productmanufacturergenerateLinks = null, Expression<Func<string>> productmanufacturerid = null, Expression<Func<string>> productmanufacturerlink = null, Expression<Func<string>> productmanufacturername = null, Expression<Func<string>> productmanufacturerCategory = null, Expression<Func<string>> productmodelcolor = null, Expression<Func<bool>> productmodelgenerateLinks = null, Expression<Func<string>> productmodelicon = null, Expression<Func<string>> productmodelid = null, Expression<Func<bool>> productmodelisCustomModel = null, Expression<Func<bool>> productmodellinkabsolute = null, Expression<Func<string>> productmodellinkauthority = null, Expression<Func<string>> productmodellinkfragment = null, Expression<Func<string>> productmodellinkhost = null, Expression<Func<bool>> productmodellinkopaque = null, Expression<Func<string>> productmodellinkpath = null, Expression<Func<int>> productmodellinkport = null, Expression<Func<string>> productmodellinkquery = null, Expression<Func<string>> productmodellinkrawAuthority = null, Expression<Func<string>> productmodellinkrawFragment = null, Expression<Func<string>> productmodellinkrawPath = null, Expression<Func<string>> productmodellinkrawQuery = null, Expression<Func<string>> productmodellinkrawSchemeSpecificPart = null, Expression<Func<string>> productmodellinkrawUserInfo = null, Expression<Func<string>> productmodellinkscheme = null, Expression<Func<string>> productmodellinkschemeSpecificPart = null, Expression<Func<string>> productmodellinkuserInfo = null, Expression<Func<string>> productmodelname = null, Expression<Func<bool>> productmodelManufacturergenerateLinks = null, Expression<Func<string>> productmodelManufacturerid = null, Expression<Func<string>> productmodelManufacturerlink = null, Expression<Func<string>> productmodelManufacturername = null, Expression<Func<string>> productname = null, Expression<Func<bool>> productreadOnly = null, Expression<Func<string>> productreference = null, Expression<Func<TagRo[]>> producttags = null, Expression<Func<ThingTinyRo[]>> productthings = null)
        {
            var __workflow_id = id == null ? null : WorkflowExpression.Compile(id);
            WorkflowExpression.Validate(__workflow_id, nameof(id), required: true);
            var __workflow_productcertification = productcertification == null ? null : WorkflowExpression.Compile(productcertification);
            WorkflowExpression.Validate(__workflow_productcertification, nameof(productcertification), required: false);
            var __workflow_productconnectivityTypes = productconnectivityTypes == null ? null : WorkflowExpression.Compile(productconnectivityTypes);
            WorkflowExpression.Validate(__workflow_productconnectivityTypes, nameof(productconnectivityTypes), required: false);
            var __workflow_productdecoderid = productdecoderid == null ? null : WorkflowExpression.Compile(productdecoderid);
            WorkflowExpression.Validate(__workflow_productdecoderid, nameof(productdecoderid), required: false);
            var __workflow_productdecoderlink = productdecoderlink == null ? null : WorkflowExpression.Compile(productdecoderlink);
            WorkflowExpression.Validate(__workflow_productdecoderlink, nameof(productdecoderlink), required: false);
            var __workflow_productdecodervisible = productdecodervisible == null ? null : WorkflowExpression.Compile(productdecodervisible);
            WorkflowExpression.Validate(__workflow_productdecodervisible, nameof(productdecodervisible), required: false);
            var __workflow_productdescription = productdescription == null ? null : WorkflowExpression.Compile(productdescription);
            WorkflowExpression.Validate(__workflow_productdescription, nameof(productdescription), required: false);
            var __workflow_productencoderid = productencoderid == null ? null : WorkflowExpression.Compile(productencoderid);
            WorkflowExpression.Validate(__workflow_productencoderid, nameof(productencoderid), required: false);
            var __workflow_productencoderlink = productencoderlink == null ? null : WorkflowExpression.Compile(productencoderlink);
            WorkflowExpression.Validate(__workflow_productencoderlink, nameof(productencoderlink), required: false);
            var __workflow_productgenerateLinks = productgenerateLinks == null ? null : WorkflowExpression.Compile(productgenerateLinks);
            WorkflowExpression.Validate(__workflow_productgenerateLinks, nameof(productgenerateLinks), required: false);
            var __workflow_producthasImage = producthasImage == null ? null : WorkflowExpression.Compile(producthasImage);
            WorkflowExpression.Validate(__workflow_producthasImage, nameof(producthasImage), required: false);
            var __workflow_productid = productid == null ? null : WorkflowExpression.Compile(productid);
            WorkflowExpression.Validate(__workflow_productid, nameof(productid), required: false);
            var __workflow_productimageLink = productimageLink == null ? null : WorkflowExpression.Compile(productimageLink);
            WorkflowExpression.Validate(__workflow_productimageLink, nameof(productimageLink), required: false);
            var __workflow_productinfoLink = productinfoLink == null ? null : WorkflowExpression.Compile(productinfoLink);
            WorkflowExpression.Validate(__workflow_productinfoLink, nameof(productinfoLink), required: false);
            var __workflow_productlink = productlink == null ? null : WorkflowExpression.Compile(productlink);
            WorkflowExpression.Validate(__workflow_productlink, nameof(productlink), required: false);
            var __workflow_productmanufacturergenerateLinks = productmanufacturergenerateLinks == null ? null : WorkflowExpression.Compile(productmanufacturergenerateLinks);
            WorkflowExpression.Validate(__workflow_productmanufacturergenerateLinks, nameof(productmanufacturergenerateLinks), required: false);
            var __workflow_productmanufacturerid = productmanufacturerid == null ? null : WorkflowExpression.Compile(productmanufacturerid);
            WorkflowExpression.Validate(__workflow_productmanufacturerid, nameof(productmanufacturerid), required: false);
            var __workflow_productmanufacturerlink = productmanufacturerlink == null ? null : WorkflowExpression.Compile(productmanufacturerlink);
            WorkflowExpression.Validate(__workflow_productmanufacturerlink, nameof(productmanufacturerlink), required: false);
            var __workflow_productmanufacturername = productmanufacturername == null ? null : WorkflowExpression.Compile(productmanufacturername);
            WorkflowExpression.Validate(__workflow_productmanufacturername, nameof(productmanufacturername), required: false);
            var __workflow_productmanufacturerCategory = productmanufacturerCategory == null ? null : WorkflowExpression.Compile(productmanufacturerCategory);
            WorkflowExpression.Validate(__workflow_productmanufacturerCategory, nameof(productmanufacturerCategory), required: false);
            var __workflow_productmodelcolor = productmodelcolor == null ? null : WorkflowExpression.Compile(productmodelcolor);
            WorkflowExpression.Validate(__workflow_productmodelcolor, nameof(productmodelcolor), required: false);
            var __workflow_productmodelgenerateLinks = productmodelgenerateLinks == null ? null : WorkflowExpression.Compile(productmodelgenerateLinks);
            WorkflowExpression.Validate(__workflow_productmodelgenerateLinks, nameof(productmodelgenerateLinks), required: false);
            var __workflow_productmodelicon = productmodelicon == null ? null : WorkflowExpression.Compile(productmodelicon);
            WorkflowExpression.Validate(__workflow_productmodelicon, nameof(productmodelicon), required: false);
            var __workflow_productmodelid = productmodelid == null ? null : WorkflowExpression.Compile(productmodelid);
            WorkflowExpression.Validate(__workflow_productmodelid, nameof(productmodelid), required: false);
            var __workflow_productmodelisCustomModel = productmodelisCustomModel == null ? null : WorkflowExpression.Compile(productmodelisCustomModel);
            WorkflowExpression.Validate(__workflow_productmodelisCustomModel, nameof(productmodelisCustomModel), required: false);
            var __workflow_productmodellinkabsolute = productmodellinkabsolute == null ? null : WorkflowExpression.Compile(productmodellinkabsolute);
            WorkflowExpression.Validate(__workflow_productmodellinkabsolute, nameof(productmodellinkabsolute), required: false);
            var __workflow_productmodellinkauthority = productmodellinkauthority == null ? null : WorkflowExpression.Compile(productmodellinkauthority);
            WorkflowExpression.Validate(__workflow_productmodellinkauthority, nameof(productmodellinkauthority), required: false);
            var __workflow_productmodellinkfragment = productmodellinkfragment == null ? null : WorkflowExpression.Compile(productmodellinkfragment);
            WorkflowExpression.Validate(__workflow_productmodellinkfragment, nameof(productmodellinkfragment), required: false);
            var __workflow_productmodellinkhost = productmodellinkhost == null ? null : WorkflowExpression.Compile(productmodellinkhost);
            WorkflowExpression.Validate(__workflow_productmodellinkhost, nameof(productmodellinkhost), required: false);
            var __workflow_productmodellinkopaque = productmodellinkopaque == null ? null : WorkflowExpression.Compile(productmodellinkopaque);
            WorkflowExpression.Validate(__workflow_productmodellinkopaque, nameof(productmodellinkopaque), required: false);
            var __workflow_productmodellinkpath = productmodellinkpath == null ? null : WorkflowExpression.Compile(productmodellinkpath);
            WorkflowExpression.Validate(__workflow_productmodellinkpath, nameof(productmodellinkpath), required: false);
            var __workflow_productmodellinkport = productmodellinkport == null ? null : WorkflowExpression.Compile(productmodellinkport);
            WorkflowExpression.Validate(__workflow_productmodellinkport, nameof(productmodellinkport), required: false);
            var __workflow_productmodellinkquery = productmodellinkquery == null ? null : WorkflowExpression.Compile(productmodellinkquery);
            WorkflowExpression.Validate(__workflow_productmodellinkquery, nameof(productmodellinkquery), required: false);
            var __workflow_productmodellinkrawAuthority = productmodellinkrawAuthority == null ? null : WorkflowExpression.Compile(productmodellinkrawAuthority);
            WorkflowExpression.Validate(__workflow_productmodellinkrawAuthority, nameof(productmodellinkrawAuthority), required: false);
            var __workflow_productmodellinkrawFragment = productmodellinkrawFragment == null ? null : WorkflowExpression.Compile(productmodellinkrawFragment);
            WorkflowExpression.Validate(__workflow_productmodellinkrawFragment, nameof(productmodellinkrawFragment), required: false);
            var __workflow_productmodellinkrawPath = productmodellinkrawPath == null ? null : WorkflowExpression.Compile(productmodellinkrawPath);
            WorkflowExpression.Validate(__workflow_productmodellinkrawPath, nameof(productmodellinkrawPath), required: false);
            var __workflow_productmodellinkrawQuery = productmodellinkrawQuery == null ? null : WorkflowExpression.Compile(productmodellinkrawQuery);
            WorkflowExpression.Validate(__workflow_productmodellinkrawQuery, nameof(productmodellinkrawQuery), required: false);
            var __workflow_productmodellinkrawSchemeSpecificPart = productmodellinkrawSchemeSpecificPart == null ? null : WorkflowExpression.Compile(productmodellinkrawSchemeSpecificPart);
            WorkflowExpression.Validate(__workflow_productmodellinkrawSchemeSpecificPart, nameof(productmodellinkrawSchemeSpecificPart), required: false);
            var __workflow_productmodellinkrawUserInfo = productmodellinkrawUserInfo == null ? null : WorkflowExpression.Compile(productmodellinkrawUserInfo);
            WorkflowExpression.Validate(__workflow_productmodellinkrawUserInfo, nameof(productmodellinkrawUserInfo), required: false);
            var __workflow_productmodellinkscheme = productmodellinkscheme == null ? null : WorkflowExpression.Compile(productmodellinkscheme);
            WorkflowExpression.Validate(__workflow_productmodellinkscheme, nameof(productmodellinkscheme), required: false);
            var __workflow_productmodellinkschemeSpecificPart = productmodellinkschemeSpecificPart == null ? null : WorkflowExpression.Compile(productmodellinkschemeSpecificPart);
            WorkflowExpression.Validate(__workflow_productmodellinkschemeSpecificPart, nameof(productmodellinkschemeSpecificPart), required: false);
            var __workflow_productmodellinkuserInfo = productmodellinkuserInfo == null ? null : WorkflowExpression.Compile(productmodellinkuserInfo);
            WorkflowExpression.Validate(__workflow_productmodellinkuserInfo, nameof(productmodellinkuserInfo), required: false);
            var __workflow_productmodelname = productmodelname == null ? null : WorkflowExpression.Compile(productmodelname);
            WorkflowExpression.Validate(__workflow_productmodelname, nameof(productmodelname), required: false);
            var __workflow_productmodelManufacturergenerateLinks = productmodelManufacturergenerateLinks == null ? null : WorkflowExpression.Compile(productmodelManufacturergenerateLinks);
            WorkflowExpression.Validate(__workflow_productmodelManufacturergenerateLinks, nameof(productmodelManufacturergenerateLinks), required: false);
            var __workflow_productmodelManufacturerid = productmodelManufacturerid == null ? null : WorkflowExpression.Compile(productmodelManufacturerid);
            WorkflowExpression.Validate(__workflow_productmodelManufacturerid, nameof(productmodelManufacturerid), required: false);
            var __workflow_productmodelManufacturerlink = productmodelManufacturerlink == null ? null : WorkflowExpression.Compile(productmodelManufacturerlink);
            WorkflowExpression.Validate(__workflow_productmodelManufacturerlink, nameof(productmodelManufacturerlink), required: false);
            var __workflow_productmodelManufacturername = productmodelManufacturername == null ? null : WorkflowExpression.Compile(productmodelManufacturername);
            WorkflowExpression.Validate(__workflow_productmodelManufacturername, nameof(productmodelManufacturername), required: false);
            var __workflow_productname = productname == null ? null : WorkflowExpression.Compile(productname);
            WorkflowExpression.Validate(__workflow_productname, nameof(productname), required: false);
            var __workflow_productreadOnly = productreadOnly == null ? null : WorkflowExpression.Compile(productreadOnly);
            WorkflowExpression.Validate(__workflow_productreadOnly, nameof(productreadOnly), required: false);
            var __workflow_productreference = productreference == null ? null : WorkflowExpression.Compile(productreference);
            WorkflowExpression.Validate(__workflow_productreference, nameof(productreference), required: false);
            var __workflow_producttags = producttags == null ? null : WorkflowExpression.Compile(producttags);
            WorkflowExpression.Validate(__workflow_producttags, nameof(producttags), required: false);
            var __workflow_productthings = productthings == null ? null : WorkflowExpression.Compile(productthings);
            WorkflowExpression.Validate(__workflow_productthings, nameof(productthings), required: false);
            return new DeferredBodyAction<SingleThingRo>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/things/{0}/product", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var product = new JObject();
                var productpropCount = 0;
                if (__workflow_productcertification != null)
                {
                    product["certification"] = ExpressionConverter.ConvertO(__workflow_productcertification);
                    productpropCount++;
                }

                if (__workflow_productconnectivityTypes != null)
                {
                    product["connectivityTypes"] = ExpressionConverter.ConvertO(__workflow_productconnectivityTypes);
                    productpropCount++;
                }

                var decoderObject = new JObject();
                var decoderObjectpropCount = 0;
                if (__workflow_productdecoderid != null)
                {
                    decoderObject["id"] = ExpressionConverter.ConvertO(__workflow_productdecoderid);
                    decoderObjectpropCount++;
                }

                if (__workflow_productdecoderlink != null)
                {
                    decoderObject["link"] = ExpressionConverter.ConvertO(__workflow_productdecoderlink);
                    decoderObjectpropCount++;
                }

                if (__workflow_productdecodervisible != null)
                {
                    decoderObject["visible"] = ExpressionConverter.ConvertO(__workflow_productdecodervisible);
                    decoderObjectpropCount++;
                }

                if (decoderObjectpropCount > 0)
                {
                    product["decoder"] = decoderObject;
                    productpropCount++;
                }

                if (__workflow_productdescription != null)
                {
                    product["description"] = ExpressionConverter.ConvertO(__workflow_productdescription);
                    productpropCount++;
                }

                var encoderObject = new JObject();
                var encoderObjectpropCount = 0;
                if (__workflow_productencoderid != null)
                {
                    encoderObject["id"] = ExpressionConverter.ConvertO(__workflow_productencoderid);
                    encoderObjectpropCount++;
                }

                if (__workflow_productencoderlink != null)
                {
                    encoderObject["link"] = ExpressionConverter.ConvertO(__workflow_productencoderlink);
                    encoderObjectpropCount++;
                }

                if (encoderObjectpropCount > 0)
                {
                    product["encoder"] = encoderObject;
                    productpropCount++;
                }

                if (__workflow_productgenerateLinks != null)
                {
                    product["generateLinks"] = ExpressionConverter.ConvertO(__workflow_productgenerateLinks);
                    productpropCount++;
                }

                if (__workflow_producthasImage != null)
                {
                    product["hasImage"] = ExpressionConverter.ConvertO(__workflow_producthasImage);
                    productpropCount++;
                }

                if (__workflow_productid != null)
                {
                    product["id"] = ExpressionConverter.ConvertO(__workflow_productid);
                    productpropCount++;
                }

                if (__workflow_productimageLink != null)
                {
                    product["imageLink"] = ExpressionConverter.ConvertO(__workflow_productimageLink);
                    productpropCount++;
                }

                if (__workflow_productinfoLink != null)
                {
                    product["infoLink"] = ExpressionConverter.ConvertO(__workflow_productinfoLink);
                    productpropCount++;
                }

                if (__workflow_productlink != null)
                {
                    product["link"] = ExpressionConverter.ConvertO(__workflow_productlink);
                    productpropCount++;
                }

                var manufacturerObject = new JObject();
                var manufacturerObjectpropCount = 0;
                if (__workflow_productmanufacturergenerateLinks != null)
                {
                    manufacturerObject["generateLinks"] = ExpressionConverter.ConvertO(__workflow_productmanufacturergenerateLinks);
                    manufacturerObjectpropCount++;
                }

                if (__workflow_productmanufacturerid != null)
                {
                    manufacturerObject["id"] = ExpressionConverter.ConvertO(__workflow_productmanufacturerid);
                    manufacturerObjectpropCount++;
                }

                if (__workflow_productmanufacturerlink != null)
                {
                    manufacturerObject["link"] = ExpressionConverter.ConvertO(__workflow_productmanufacturerlink);
                    manufacturerObjectpropCount++;
                }

                if (__workflow_productmanufacturername != null)
                {
                    manufacturerObject["name"] = ExpressionConverter.ConvertO(__workflow_productmanufacturername);
                    manufacturerObjectpropCount++;
                }

                if (manufacturerObjectpropCount > 0)
                {
                    product["manufacturer"] = manufacturerObject;
                    productpropCount++;
                }

                if (__workflow_productmanufacturerCategory != null)
                {
                    product["manufacturerCategory"] = ExpressionConverter.ConvertO(__workflow_productmanufacturerCategory);
                    productpropCount++;
                }

                var modelObject = new JObject();
                var modelObjectpropCount = 0;
                if (__workflow_productmodelcolor != null)
                {
                    modelObject["color"] = ExpressionConverter.ConvertO(__workflow_productmodelcolor);
                    modelObjectpropCount++;
                }

                if (__workflow_productmodelgenerateLinks != null)
                {
                    modelObject["generateLinks"] = ExpressionConverter.ConvertO(__workflow_productmodelgenerateLinks);
                    modelObjectpropCount++;
                }

                if (__workflow_productmodelicon != null)
                {
                    modelObject["icon"] = ExpressionConverter.ConvertO(__workflow_productmodelicon);
                    modelObjectpropCount++;
                }

                if (__workflow_productmodelid != null)
                {
                    modelObject["id"] = ExpressionConverter.ConvertO(__workflow_productmodelid);
                    modelObjectpropCount++;
                }

                if (__workflow_productmodelisCustomModel != null)
                {
                    modelObject["isCustomModel"] = ExpressionConverter.ConvertO(__workflow_productmodelisCustomModel);
                    modelObjectpropCount++;
                }

                var linkObject = new JObject();
                var linkObjectpropCount = 0;
                if (__workflow_productmodellinkabsolute != null)
                {
                    linkObject["absolute"] = ExpressionConverter.ConvertO(__workflow_productmodellinkabsolute);
                    linkObjectpropCount++;
                }

                if (__workflow_productmodellinkauthority != null)
                {
                    linkObject["authority"] = ExpressionConverter.ConvertO(__workflow_productmodellinkauthority);
                    linkObjectpropCount++;
                }

                if (__workflow_productmodellinkfragment != null)
                {
                    linkObject["fragment"] = ExpressionConverter.ConvertO(__workflow_productmodellinkfragment);
                    linkObjectpropCount++;
                }

                if (__workflow_productmodellinkhost != null)
                {
                    linkObject["host"] = ExpressionConverter.ConvertO(__workflow_productmodellinkhost);
                    linkObjectpropCount++;
                }

                if (__workflow_productmodellinkopaque != null)
                {
                    linkObject["opaque"] = ExpressionConverter.ConvertO(__workflow_productmodellinkopaque);
                    linkObjectpropCount++;
                }

                if (__workflow_productmodellinkpath != null)
                {
                    linkObject["path"] = ExpressionConverter.ConvertO(__workflow_productmodellinkpath);
                    linkObjectpropCount++;
                }

                if (__workflow_productmodellinkport != null)
                {
                    linkObject["port"] = ExpressionConverter.ConvertO(__workflow_productmodellinkport);
                    linkObjectpropCount++;
                }

                if (__workflow_productmodellinkquery != null)
                {
                    linkObject["query"] = ExpressionConverter.ConvertO(__workflow_productmodellinkquery);
                    linkObjectpropCount++;
                }

                if (__workflow_productmodellinkrawAuthority != null)
                {
                    linkObject["rawAuthority"] = ExpressionConverter.ConvertO(__workflow_productmodellinkrawAuthority);
                    linkObjectpropCount++;
                }

                if (__workflow_productmodellinkrawFragment != null)
                {
                    linkObject["rawFragment"] = ExpressionConverter.ConvertO(__workflow_productmodellinkrawFragment);
                    linkObjectpropCount++;
                }

                if (__workflow_productmodellinkrawPath != null)
                {
                    linkObject["rawPath"] = ExpressionConverter.ConvertO(__workflow_productmodellinkrawPath);
                    linkObjectpropCount++;
                }

                if (__workflow_productmodellinkrawQuery != null)
                {
                    linkObject["rawQuery"] = ExpressionConverter.ConvertO(__workflow_productmodellinkrawQuery);
                    linkObjectpropCount++;
                }

                if (__workflow_productmodellinkrawSchemeSpecificPart != null)
                {
                    linkObject["rawSchemeSpecificPart"] = ExpressionConverter.ConvertO(__workflow_productmodellinkrawSchemeSpecificPart);
                    linkObjectpropCount++;
                }

                if (__workflow_productmodellinkrawUserInfo != null)
                {
                    linkObject["rawUserInfo"] = ExpressionConverter.ConvertO(__workflow_productmodellinkrawUserInfo);
                    linkObjectpropCount++;
                }

                if (__workflow_productmodellinkscheme != null)
                {
                    linkObject["scheme"] = ExpressionConverter.ConvertO(__workflow_productmodellinkscheme);
                    linkObjectpropCount++;
                }

                if (__workflow_productmodellinkschemeSpecificPart != null)
                {
                    linkObject["schemeSpecificPart"] = ExpressionConverter.ConvertO(__workflow_productmodellinkschemeSpecificPart);
                    linkObjectpropCount++;
                }

                if (__workflow_productmodellinkuserInfo != null)
                {
                    linkObject["userInfo"] = ExpressionConverter.ConvertO(__workflow_productmodellinkuserInfo);
                    linkObjectpropCount++;
                }

                if (linkObjectpropCount > 0)
                {
                    modelObject["link"] = linkObject;
                    modelObjectpropCount++;
                }

                if (__workflow_productmodelname != null)
                {
                    modelObject["name"] = ExpressionConverter.ConvertO(__workflow_productmodelname);
                    modelObjectpropCount++;
                }

                if (modelObjectpropCount > 0)
                {
                    product["model"] = modelObject;
                    productpropCount++;
                }

                var modelManufacturerObject = new JObject();
                var modelManufacturerObjectpropCount = 0;
                if (__workflow_productmanufacturergenerateLinks != null)
                {
                    modelManufacturerObject["generateLinks"] = ExpressionConverter.ConvertO(__workflow_productmanufacturergenerateLinks);
                    modelManufacturerObjectpropCount++;
                }

                if (__workflow_productmanufacturerid != null)
                {
                    modelManufacturerObject["id"] = ExpressionConverter.ConvertO(__workflow_productmanufacturerid);
                    modelManufacturerObjectpropCount++;
                }

                if (__workflow_productmanufacturerlink != null)
                {
                    modelManufacturerObject["link"] = ExpressionConverter.ConvertO(__workflow_productmanufacturerlink);
                    modelManufacturerObjectpropCount++;
                }

                if (__workflow_productmanufacturername != null)
                {
                    modelManufacturerObject["name"] = ExpressionConverter.ConvertO(__workflow_productmanufacturername);
                    modelManufacturerObjectpropCount++;
                }

                if (modelManufacturerObjectpropCount > 0)
                {
                    product["modelManufacturer"] = modelManufacturerObject;
                    productpropCount++;
                }

                if (__workflow_productname != null)
                {
                    product["name"] = ExpressionConverter.ConvertO(__workflow_productname);
                    productpropCount++;
                }

                if (__workflow_productreadOnly != null)
                {
                    product["readOnly"] = ExpressionConverter.ConvertO(__workflow_productreadOnly);
                    productpropCount++;
                }

                if (__workflow_productreference != null)
                {
                    product["reference"] = ExpressionConverter.ConvertO(__workflow_productreference);
                    productpropCount++;
                }

                if (__workflow_producttags != null)
                {
                    product["tags"] = ExpressionConverter.ConvertO(__workflow_producttags);
                    productpropCount++;
                }

                if (__workflow_productthings != null)
                {
                    product["things"] = ExpressionConverter.ConvertO(__workflow_productthings);
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
        public IBodyWorkflowAction<PageFlowRo> GetFlowsRelatedToThing(Expression<Func<string>> id)
        {
            var __workflow_id = id == null ? null : WorkflowExpression.Compile(id);
            WorkflowExpression.Validate(__workflow_id, nameof(id), required: true);
            return new DeferredBodyAction<PageFlowRo>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/things/{0}/related_flows", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<PageFlowRo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<PageThingTagRo> GetThingTags(Expression<Func<string>> id)
        {
            var __workflow_id = id == null ? null : WorkflowExpression.Compile(id);
            WorkflowExpression.Validate(__workflow_id, nameof(id), required: true);
            return new DeferredBodyAction<PageThingTagRo>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/things/{0}/tags", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<PageThingTagRo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<PageStatsMeasureRo> GetStatsAvg(Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null, Expression<Func<string>> sortValues = null, Expression<Func<string>> sort = null, Expression<Func<string>> filter = null, Expression<Func<dirInput>> dir = null, Expression<Func<string>> orFilter = null, Expression<Func<int>> start = null, Expression<Func<int>> end = null)
        {
            var __workflow_page = page == null ? null : WorkflowExpression.Compile(page);
            WorkflowExpression.Validate(__workflow_page, nameof(page), required: false);
            var __workflow_pageSize = pageSize == null ? null : WorkflowExpression.Compile(pageSize);
            WorkflowExpression.Validate(__workflow_pageSize, nameof(pageSize), required: false);
            var __workflow_sortValues = sortValues == null ? null : WorkflowExpression.Compile(sortValues);
            WorkflowExpression.Validate(__workflow_sortValues, nameof(sortValues), required: false);
            var __workflow_sort = sort == null ? null : WorkflowExpression.Compile(sort);
            WorkflowExpression.Validate(__workflow_sort, nameof(sort), required: false);
            var __workflow_filter = filter == null ? null : WorkflowExpression.Compile(filter);
            WorkflowExpression.Validate(__workflow_filter, nameof(filter), required: false);
            var __workflow_dir = dir == null ? null : WorkflowExpression.Compile(dir);
            WorkflowExpression.Validate(__workflow_dir, nameof(dir), required: false);
            var __workflow_orFilter = orFilter == null ? null : WorkflowExpression.Compile(orFilter);
            WorkflowExpression.Validate(__workflow_orFilter, nameof(orFilter), required: false);
            var __workflow_start = start == null ? null : WorkflowExpression.Compile(start);
            WorkflowExpression.Validate(__workflow_start, nameof(start), required: false);
            var __workflow_end = end == null ? null : WorkflowExpression.Compile(end);
            WorkflowExpression.Validate(__workflow_end, nameof(end), required: false);
            return new DeferredBodyAction<PageStatsMeasureRo>(() =>
            {
                var apiCallPath = "/stats/avg";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(__workflow_pageSize);
                if (__workflow_sortValues != null)
                    callPayload.Queries["sortValues"] = ExpressionConverter.Convert(__workflow_sortValues);
                if (__workflow_sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(__workflow_sort);
                if (__workflow_filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_dir != null)
                    callPayload.Queries["dir"] = ExpressionConverter.Convert(__workflow_dir);
                if (__workflow_orFilter != null)
                    callPayload.Queries["orFilter"] = ExpressionConverter.Convert(__workflow_orFilter);
                if (__workflow_start != null)
                    callPayload.Queries["start"] = ExpressionConverter.Convert(__workflow_start);
                if (__workflow_end != null)
                    callPayload.Queries["end"] = ExpressionConverter.Convert(__workflow_end);
                return new ApiConnectionAction<PageStatsMeasureRo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<StatsCountRo> GetStatsCount(Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null, Expression<Func<string>> sortValues = null, Expression<Func<string>> sort = null, Expression<Func<string>> filter = null, Expression<Func<dirInput>> dir = null, Expression<Func<string>> orFilter = null, Expression<Func<int>> start = null, Expression<Func<int>> end = null)
        {
            var __workflow_page = page == null ? null : WorkflowExpression.Compile(page);
            WorkflowExpression.Validate(__workflow_page, nameof(page), required: false);
            var __workflow_pageSize = pageSize == null ? null : WorkflowExpression.Compile(pageSize);
            WorkflowExpression.Validate(__workflow_pageSize, nameof(pageSize), required: false);
            var __workflow_sortValues = sortValues == null ? null : WorkflowExpression.Compile(sortValues);
            WorkflowExpression.Validate(__workflow_sortValues, nameof(sortValues), required: false);
            var __workflow_sort = sort == null ? null : WorkflowExpression.Compile(sort);
            WorkflowExpression.Validate(__workflow_sort, nameof(sort), required: false);
            var __workflow_filter = filter == null ? null : WorkflowExpression.Compile(filter);
            WorkflowExpression.Validate(__workflow_filter, nameof(filter), required: false);
            var __workflow_dir = dir == null ? null : WorkflowExpression.Compile(dir);
            WorkflowExpression.Validate(__workflow_dir, nameof(dir), required: false);
            var __workflow_orFilter = orFilter == null ? null : WorkflowExpression.Compile(orFilter);
            WorkflowExpression.Validate(__workflow_orFilter, nameof(orFilter), required: false);
            var __workflow_start = start == null ? null : WorkflowExpression.Compile(start);
            WorkflowExpression.Validate(__workflow_start, nameof(start), required: false);
            var __workflow_end = end == null ? null : WorkflowExpression.Compile(end);
            WorkflowExpression.Validate(__workflow_end, nameof(end), required: false);
            return new DeferredBodyAction<StatsCountRo>(() =>
            {
                var apiCallPath = "/stats/count";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(__workflow_pageSize);
                if (__workflow_sortValues != null)
                    callPayload.Queries["sortValues"] = ExpressionConverter.Convert(__workflow_sortValues);
                if (__workflow_sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(__workflow_sort);
                if (__workflow_filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_dir != null)
                    callPayload.Queries["dir"] = ExpressionConverter.Convert(__workflow_dir);
                if (__workflow_orFilter != null)
                    callPayload.Queries["orFilter"] = ExpressionConverter.Convert(__workflow_orFilter);
                if (__workflow_start != null)
                    callPayload.Queries["start"] = ExpressionConverter.Convert(__workflow_start);
                if (__workflow_end != null)
                    callPayload.Queries["end"] = ExpressionConverter.Convert(__workflow_end);
                return new ApiConnectionAction<StatsCountRo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<PageStatsMeasureRo> GetStatsLast(Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null, Expression<Func<string>> sortValues = null, Expression<Func<string>> sort = null, Expression<Func<string>> filter = null, Expression<Func<dirInput>> dir = null, Expression<Func<string>> orFilter = null)
        {
            var __workflow_page = page == null ? null : WorkflowExpression.Compile(page);
            WorkflowExpression.Validate(__workflow_page, nameof(page), required: false);
            var __workflow_pageSize = pageSize == null ? null : WorkflowExpression.Compile(pageSize);
            WorkflowExpression.Validate(__workflow_pageSize, nameof(pageSize), required: false);
            var __workflow_sortValues = sortValues == null ? null : WorkflowExpression.Compile(sortValues);
            WorkflowExpression.Validate(__workflow_sortValues, nameof(sortValues), required: false);
            var __workflow_sort = sort == null ? null : WorkflowExpression.Compile(sort);
            WorkflowExpression.Validate(__workflow_sort, nameof(sort), required: false);
            var __workflow_filter = filter == null ? null : WorkflowExpression.Compile(filter);
            WorkflowExpression.Validate(__workflow_filter, nameof(filter), required: false);
            var __workflow_dir = dir == null ? null : WorkflowExpression.Compile(dir);
            WorkflowExpression.Validate(__workflow_dir, nameof(dir), required: false);
            var __workflow_orFilter = orFilter == null ? null : WorkflowExpression.Compile(orFilter);
            WorkflowExpression.Validate(__workflow_orFilter, nameof(orFilter), required: false);
            return new DeferredBodyAction<PageStatsMeasureRo>(() =>
            {
                var apiCallPath = "/stats/last";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(__workflow_pageSize);
                if (__workflow_sortValues != null)
                    callPayload.Queries["sortValues"] = ExpressionConverter.Convert(__workflow_sortValues);
                if (__workflow_sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(__workflow_sort);
                if (__workflow_filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_dir != null)
                    callPayload.Queries["dir"] = ExpressionConverter.Convert(__workflow_dir);
                if (__workflow_orFilter != null)
                    callPayload.Queries["orFilter"] = ExpressionConverter.Convert(__workflow_orFilter);
                return new ApiConnectionAction<PageStatsMeasureRo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<PageStatsMeasureRo> GetThingStatsLast(Expression<Func<string>> thingId, Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null, Expression<Func<string>> sortValues = null, Expression<Func<string>> sort = null, Expression<Func<string>> filter = null, Expression<Func<dirInput>> dir = null, Expression<Func<string>> orFilter = null)
        {
            var __workflow_thingId = thingId == null ? null : WorkflowExpression.Compile(thingId);
            WorkflowExpression.Validate(__workflow_thingId, nameof(thingId), required: true);
            var __workflow_page = page == null ? null : WorkflowExpression.Compile(page);
            WorkflowExpression.Validate(__workflow_page, nameof(page), required: false);
            var __workflow_pageSize = pageSize == null ? null : WorkflowExpression.Compile(pageSize);
            WorkflowExpression.Validate(__workflow_pageSize, nameof(pageSize), required: false);
            var __workflow_sortValues = sortValues == null ? null : WorkflowExpression.Compile(sortValues);
            WorkflowExpression.Validate(__workflow_sortValues, nameof(sortValues), required: false);
            var __workflow_sort = sort == null ? null : WorkflowExpression.Compile(sort);
            WorkflowExpression.Validate(__workflow_sort, nameof(sort), required: false);
            var __workflow_filter = filter == null ? null : WorkflowExpression.Compile(filter);
            WorkflowExpression.Validate(__workflow_filter, nameof(filter), required: false);
            var __workflow_dir = dir == null ? null : WorkflowExpression.Compile(dir);
            WorkflowExpression.Validate(__workflow_dir, nameof(dir), required: false);
            var __workflow_orFilter = orFilter == null ? null : WorkflowExpression.Compile(orFilter);
            WorkflowExpression.Validate(__workflow_orFilter, nameof(orFilter), required: false);
            return new DeferredBodyAction<PageStatsMeasureRo>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/stats/last/things/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_thingId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(__workflow_pageSize);
                if (__workflow_sortValues != null)
                    callPayload.Queries["sortValues"] = ExpressionConverter.Convert(__workflow_sortValues);
                if (__workflow_sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(__workflow_sort);
                if (__workflow_filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_dir != null)
                    callPayload.Queries["dir"] = ExpressionConverter.Convert(__workflow_dir);
                if (__workflow_orFilter != null)
                    callPayload.Queries["orFilter"] = ExpressionConverter.Convert(__workflow_orFilter);
                return new ApiConnectionAction<PageStatsMeasureRo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<PageStatsMeasureRo> GetStatsMax(Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null, Expression<Func<string>> sortValues = null, Expression<Func<string>> sort = null, Expression<Func<string>> filter = null, Expression<Func<dirInput>> dir = null, Expression<Func<string>> orFilter = null, Expression<Func<int>> start = null, Expression<Func<int>> end = null)
        {
            var __workflow_page = page == null ? null : WorkflowExpression.Compile(page);
            WorkflowExpression.Validate(__workflow_page, nameof(page), required: false);
            var __workflow_pageSize = pageSize == null ? null : WorkflowExpression.Compile(pageSize);
            WorkflowExpression.Validate(__workflow_pageSize, nameof(pageSize), required: false);
            var __workflow_sortValues = sortValues == null ? null : WorkflowExpression.Compile(sortValues);
            WorkflowExpression.Validate(__workflow_sortValues, nameof(sortValues), required: false);
            var __workflow_sort = sort == null ? null : WorkflowExpression.Compile(sort);
            WorkflowExpression.Validate(__workflow_sort, nameof(sort), required: false);
            var __workflow_filter = filter == null ? null : WorkflowExpression.Compile(filter);
            WorkflowExpression.Validate(__workflow_filter, nameof(filter), required: false);
            var __workflow_dir = dir == null ? null : WorkflowExpression.Compile(dir);
            WorkflowExpression.Validate(__workflow_dir, nameof(dir), required: false);
            var __workflow_orFilter = orFilter == null ? null : WorkflowExpression.Compile(orFilter);
            WorkflowExpression.Validate(__workflow_orFilter, nameof(orFilter), required: false);
            var __workflow_start = start == null ? null : WorkflowExpression.Compile(start);
            WorkflowExpression.Validate(__workflow_start, nameof(start), required: false);
            var __workflow_end = end == null ? null : WorkflowExpression.Compile(end);
            WorkflowExpression.Validate(__workflow_end, nameof(end), required: false);
            return new DeferredBodyAction<PageStatsMeasureRo>(() =>
            {
                var apiCallPath = "/stats/max";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(__workflow_pageSize);
                if (__workflow_sortValues != null)
                    callPayload.Queries["sortValues"] = ExpressionConverter.Convert(__workflow_sortValues);
                if (__workflow_sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(__workflow_sort);
                if (__workflow_filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_dir != null)
                    callPayload.Queries["dir"] = ExpressionConverter.Convert(__workflow_dir);
                if (__workflow_orFilter != null)
                    callPayload.Queries["orFilter"] = ExpressionConverter.Convert(__workflow_orFilter);
                if (__workflow_start != null)
                    callPayload.Queries["start"] = ExpressionConverter.Convert(__workflow_start);
                if (__workflow_end != null)
                    callPayload.Queries["end"] = ExpressionConverter.Convert(__workflow_end);
                return new ApiConnectionAction<PageStatsMeasureRo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<StatsGraphRo[]> GetStatsMeasurements(Expression<Func<int>> start, Expression<Func<int>> end, Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null, Expression<Func<string>> sortValues = null, Expression<Func<string>> sort = null, Expression<Func<string>> filter = null, Expression<Func<dirInput>> dir = null, Expression<Func<string>> orFilter = null, Expression<Func<int>> time = null, Expression<Func<string>> interval = null)
        {
            var __workflow_start = start == null ? null : WorkflowExpression.Compile(start);
            WorkflowExpression.Validate(__workflow_start, nameof(start), required: true);
            var __workflow_end = end == null ? null : WorkflowExpression.Compile(end);
            WorkflowExpression.Validate(__workflow_end, nameof(end), required: true);
            var __workflow_page = page == null ? null : WorkflowExpression.Compile(page);
            WorkflowExpression.Validate(__workflow_page, nameof(page), required: false);
            var __workflow_pageSize = pageSize == null ? null : WorkflowExpression.Compile(pageSize);
            WorkflowExpression.Validate(__workflow_pageSize, nameof(pageSize), required: false);
            var __workflow_sortValues = sortValues == null ? null : WorkflowExpression.Compile(sortValues);
            WorkflowExpression.Validate(__workflow_sortValues, nameof(sortValues), required: false);
            var __workflow_sort = sort == null ? null : WorkflowExpression.Compile(sort);
            WorkflowExpression.Validate(__workflow_sort, nameof(sort), required: false);
            var __workflow_filter = filter == null ? null : WorkflowExpression.Compile(filter);
            WorkflowExpression.Validate(__workflow_filter, nameof(filter), required: false);
            var __workflow_dir = dir == null ? null : WorkflowExpression.Compile(dir);
            WorkflowExpression.Validate(__workflow_dir, nameof(dir), required: false);
            var __workflow_orFilter = orFilter == null ? null : WorkflowExpression.Compile(orFilter);
            WorkflowExpression.Validate(__workflow_orFilter, nameof(orFilter), required: false);
            var __workflow_time = time == null ? null : WorkflowExpression.Compile(time);
            WorkflowExpression.Validate(__workflow_time, nameof(time), required: false);
            var __workflow_interval = interval == null ? null : WorkflowExpression.Compile(interval);
            WorkflowExpression.Validate(__workflow_interval, nameof(interval), required: false);
            return new DeferredBodyAction<StatsGraphRo[]>(() =>
            {
                var apiCallPath = "/stats/measurements";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(__workflow_pageSize);
                if (__workflow_sortValues != null)
                    callPayload.Queries["sortValues"] = ExpressionConverter.Convert(__workflow_sortValues);
                if (__workflow_sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(__workflow_sort);
                if (__workflow_filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_dir != null)
                    callPayload.Queries["dir"] = ExpressionConverter.Convert(__workflow_dir);
                if (__workflow_orFilter != null)
                    callPayload.Queries["orFilter"] = ExpressionConverter.Convert(__workflow_orFilter);
                if (__workflow_time != null)
                    callPayload.Queries["time"] = ExpressionConverter.Convert(__workflow_time);
                if (__workflow_interval != null)
                    callPayload.Queries["interval"] = ExpressionConverter.Convert(__workflow_interval);
                callPayload.Queries["start"] = ExpressionConverter.Convert(__workflow_start);
                callPayload.Queries["end"] = ExpressionConverter.Convert(__workflow_end);
                return new ApiConnectionAction<StatsGraphRo[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<PageStatsMeasureRo> GetStatsMin(Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null, Expression<Func<string>> sortValues = null, Expression<Func<string>> sort = null, Expression<Func<string>> filter = null, Expression<Func<dirInput>> dir = null, Expression<Func<string>> orFilter = null, Expression<Func<int>> start = null, Expression<Func<int>> end = null)
        {
            var __workflow_page = page == null ? null : WorkflowExpression.Compile(page);
            WorkflowExpression.Validate(__workflow_page, nameof(page), required: false);
            var __workflow_pageSize = pageSize == null ? null : WorkflowExpression.Compile(pageSize);
            WorkflowExpression.Validate(__workflow_pageSize, nameof(pageSize), required: false);
            var __workflow_sortValues = sortValues == null ? null : WorkflowExpression.Compile(sortValues);
            WorkflowExpression.Validate(__workflow_sortValues, nameof(sortValues), required: false);
            var __workflow_sort = sort == null ? null : WorkflowExpression.Compile(sort);
            WorkflowExpression.Validate(__workflow_sort, nameof(sort), required: false);
            var __workflow_filter = filter == null ? null : WorkflowExpression.Compile(filter);
            WorkflowExpression.Validate(__workflow_filter, nameof(filter), required: false);
            var __workflow_dir = dir == null ? null : WorkflowExpression.Compile(dir);
            WorkflowExpression.Validate(__workflow_dir, nameof(dir), required: false);
            var __workflow_orFilter = orFilter == null ? null : WorkflowExpression.Compile(orFilter);
            WorkflowExpression.Validate(__workflow_orFilter, nameof(orFilter), required: false);
            var __workflow_start = start == null ? null : WorkflowExpression.Compile(start);
            WorkflowExpression.Validate(__workflow_start, nameof(start), required: false);
            var __workflow_end = end == null ? null : WorkflowExpression.Compile(end);
            WorkflowExpression.Validate(__workflow_end, nameof(end), required: false);
            return new DeferredBodyAction<PageStatsMeasureRo>(() =>
            {
                var apiCallPath = "/stats/min";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(__workflow_pageSize);
                if (__workflow_sortValues != null)
                    callPayload.Queries["sortValues"] = ExpressionConverter.Convert(__workflow_sortValues);
                if (__workflow_sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(__workflow_sort);
                if (__workflow_filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_dir != null)
                    callPayload.Queries["dir"] = ExpressionConverter.Convert(__workflow_dir);
                if (__workflow_orFilter != null)
                    callPayload.Queries["orFilter"] = ExpressionConverter.Convert(__workflow_orFilter);
                if (__workflow_start != null)
                    callPayload.Queries["start"] = ExpressionConverter.Convert(__workflow_start);
                if (__workflow_end != null)
                    callPayload.Queries["end"] = ExpressionConverter.Convert(__workflow_end);
                return new ApiConnectionAction<PageStatsMeasureRo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<StatsCountRo[]> GetStatsRepartition(Expression<Func<string>> attribute, Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null, Expression<Func<string>> sortValues = null, Expression<Func<string>> sort = null, Expression<Func<string>> filter = null, Expression<Func<dirInput>> dir = null, Expression<Func<string>> orFilter = null, Expression<Func<int>> start = null, Expression<Func<int>> end = null)
        {
            var __workflow_attribute = attribute == null ? null : WorkflowExpression.Compile(attribute);
            WorkflowExpression.Validate(__workflow_attribute, nameof(attribute), required: true);
            var __workflow_page = page == null ? null : WorkflowExpression.Compile(page);
            WorkflowExpression.Validate(__workflow_page, nameof(page), required: false);
            var __workflow_pageSize = pageSize == null ? null : WorkflowExpression.Compile(pageSize);
            WorkflowExpression.Validate(__workflow_pageSize, nameof(pageSize), required: false);
            var __workflow_sortValues = sortValues == null ? null : WorkflowExpression.Compile(sortValues);
            WorkflowExpression.Validate(__workflow_sortValues, nameof(sortValues), required: false);
            var __workflow_sort = sort == null ? null : WorkflowExpression.Compile(sort);
            WorkflowExpression.Validate(__workflow_sort, nameof(sort), required: false);
            var __workflow_filter = filter == null ? null : WorkflowExpression.Compile(filter);
            WorkflowExpression.Validate(__workflow_filter, nameof(filter), required: false);
            var __workflow_dir = dir == null ? null : WorkflowExpression.Compile(dir);
            WorkflowExpression.Validate(__workflow_dir, nameof(dir), required: false);
            var __workflow_orFilter = orFilter == null ? null : WorkflowExpression.Compile(orFilter);
            WorkflowExpression.Validate(__workflow_orFilter, nameof(orFilter), required: false);
            var __workflow_start = start == null ? null : WorkflowExpression.Compile(start);
            WorkflowExpression.Validate(__workflow_start, nameof(start), required: false);
            var __workflow_end = end == null ? null : WorkflowExpression.Compile(end);
            WorkflowExpression.Validate(__workflow_end, nameof(end), required: false);
            return new DeferredBodyAction<StatsCountRo[]>(() =>
            {
                var apiCallPath = "/stats/repartition";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["attribute"] = ExpressionConverter.Convert(__workflow_attribute);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(__workflow_pageSize);
                if (__workflow_sortValues != null)
                    callPayload.Queries["sortValues"] = ExpressionConverter.Convert(__workflow_sortValues);
                if (__workflow_sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(__workflow_sort);
                if (__workflow_filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_dir != null)
                    callPayload.Queries["dir"] = ExpressionConverter.Convert(__workflow_dir);
                if (__workflow_orFilter != null)
                    callPayload.Queries["orFilter"] = ExpressionConverter.Convert(__workflow_orFilter);
                if (__workflow_start != null)
                    callPayload.Queries["start"] = ExpressionConverter.Convert(__workflow_start);
                if (__workflow_end != null)
                    callPayload.Queries["end"] = ExpressionConverter.Convert(__workflow_end);
                return new ApiConnectionAction<StatsCountRo[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<StatsGraphRo[]> GetStatsSum(Expression<Func<int>> start, Expression<Func<int>> end, Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null, Expression<Func<string>> sortValues = null, Expression<Func<string>> sort = null, Expression<Func<string>> filter = null, Expression<Func<dirInput>> dir = null, Expression<Func<string>> orFilter = null, Expression<Func<int>> time = null, Expression<Func<string>> interval = null)
        {
            var __workflow_start = start == null ? null : WorkflowExpression.Compile(start);
            WorkflowExpression.Validate(__workflow_start, nameof(start), required: true);
            var __workflow_end = end == null ? null : WorkflowExpression.Compile(end);
            WorkflowExpression.Validate(__workflow_end, nameof(end), required: true);
            var __workflow_page = page == null ? null : WorkflowExpression.Compile(page);
            WorkflowExpression.Validate(__workflow_page, nameof(page), required: false);
            var __workflow_pageSize = pageSize == null ? null : WorkflowExpression.Compile(pageSize);
            WorkflowExpression.Validate(__workflow_pageSize, nameof(pageSize), required: false);
            var __workflow_sortValues = sortValues == null ? null : WorkflowExpression.Compile(sortValues);
            WorkflowExpression.Validate(__workflow_sortValues, nameof(sortValues), required: false);
            var __workflow_sort = sort == null ? null : WorkflowExpression.Compile(sort);
            WorkflowExpression.Validate(__workflow_sort, nameof(sort), required: false);
            var __workflow_filter = filter == null ? null : WorkflowExpression.Compile(filter);
            WorkflowExpression.Validate(__workflow_filter, nameof(filter), required: false);
            var __workflow_dir = dir == null ? null : WorkflowExpression.Compile(dir);
            WorkflowExpression.Validate(__workflow_dir, nameof(dir), required: false);
            var __workflow_orFilter = orFilter == null ? null : WorkflowExpression.Compile(orFilter);
            WorkflowExpression.Validate(__workflow_orFilter, nameof(orFilter), required: false);
            var __workflow_time = time == null ? null : WorkflowExpression.Compile(time);
            WorkflowExpression.Validate(__workflow_time, nameof(time), required: false);
            var __workflow_interval = interval == null ? null : WorkflowExpression.Compile(interval);
            WorkflowExpression.Validate(__workflow_interval, nameof(interval), required: false);
            return new DeferredBodyAction<StatsGraphRo[]>(() =>
            {
                var apiCallPath = "/stats/sum";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(__workflow_pageSize);
                if (__workflow_sortValues != null)
                    callPayload.Queries["sortValues"] = ExpressionConverter.Convert(__workflow_sortValues);
                if (__workflow_sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(__workflow_sort);
                if (__workflow_filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_dir != null)
                    callPayload.Queries["dir"] = ExpressionConverter.Convert(__workflow_dir);
                if (__workflow_orFilter != null)
                    callPayload.Queries["orFilter"] = ExpressionConverter.Convert(__workflow_orFilter);
                if (__workflow_time != null)
                    callPayload.Queries["time"] = ExpressionConverter.Convert(__workflow_time);
                if (__workflow_interval != null)
                    callPayload.Queries["interval"] = ExpressionConverter.Convert(__workflow_interval);
                callPayload.Queries["start"] = ExpressionConverter.Convert(__workflow_start);
                callPayload.Queries["end"] = ExpressionConverter.Convert(__workflow_end);
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
