//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Pilotthings
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class PilotthingsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<PageAlertRo> GetAlerts([WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null, [WorkflowExpression] Func<string> sortValues = null, [WorkflowExpression] Func<string> sort = null, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<dirInput> dir = null, [WorkflowExpression] Func<string> orFilter = null, [WorkflowExpression] Func<int> dateStart = null, [WorkflowExpression] Func<int> dateEnd = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/alerts";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (pageSize != null)
                    callPayload.Queries["pageSize"] = SourceExpressionConverter.ConvertO(pageSize);
                if (sortValues != null)
                    callPayload.Queries["sortValues"] = SourceExpressionConverter.ConvertO(sortValues);
                if (sort != null)
                    callPayload.Queries["sort"] = SourceExpressionConverter.ConvertO(sort);
                if (filter != null)
                    callPayload.Queries["filter"] = SourceExpressionConverter.ConvertO(filter);
                if (dir != null)
                    callPayload.Queries["dir"] = SourceExpressionConverter.Convert(dir);
                if (orFilter != null)
                    callPayload.Queries["orFilter"] = SourceExpressionConverter.ConvertO(orFilter);
                callPayload.Queries["dateStart"] = Convert.ToString(0);
                if (dateStart != null)
                    callPayload.Queries["dateStart"] = SourceExpressionConverter.ConvertO(dateStart);
                callPayload.Queries["dateEnd"] = Convert.ToString(0);
                if (dateEnd != null)
                    callPayload.Queries["dateEnd"] = SourceExpressionConverter.ConvertO(dateEnd);
                return callPayload;
            }

            return new ApiConnectionAction<PageAlertRo>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<AlertRo> UpdateAlertState([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> paramJson = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/alerts/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = SourceExpressionConverter.ConvertToken(paramJson);
                return callPayload;
            }

            return new ApiConnectionAction<AlertRo>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<PageMeasureRo> GetMeasures([WorkflowExpression] Func<bool> detailed = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null, [WorkflowExpression] Func<string> sortValues = null, [WorkflowExpression] Func<string> sort = null, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<dirInput> dir = null, [WorkflowExpression] Func<string> orFilter = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/measures";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["detailed"] = Convert.ToString(false);
                if (detailed != null)
                    callPayload.Queries["detailed"] = SourceExpressionConverter.ConvertO(detailed);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (pageSize != null)
                    callPayload.Queries["pageSize"] = SourceExpressionConverter.ConvertO(pageSize);
                if (sortValues != null)
                    callPayload.Queries["sortValues"] = SourceExpressionConverter.ConvertO(sortValues);
                if (sort != null)
                    callPayload.Queries["sort"] = SourceExpressionConverter.ConvertO(sort);
                if (filter != null)
                    callPayload.Queries["filter"] = SourceExpressionConverter.ConvertO(filter);
                if (dir != null)
                    callPayload.Queries["dir"] = SourceExpressionConverter.Convert(dir);
                if (orFilter != null)
                    callPayload.Queries["orFilter"] = SourceExpressionConverter.ConvertO(orFilter);
                return callPayload;
            }

            return new ApiConnectionAction<PageMeasureRo>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<CountRo> GetCount([WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null, [WorkflowExpression] Func<string> sortValues = null, [WorkflowExpression] Func<string> sort = null, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<dirInput> dir = null, [WorkflowExpression] Func<string> orFilter = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/measures/count";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (pageSize != null)
                    callPayload.Queries["pageSize"] = SourceExpressionConverter.ConvertO(pageSize);
                if (sortValues != null)
                    callPayload.Queries["sortValues"] = SourceExpressionConverter.ConvertO(sortValues);
                if (sort != null)
                    callPayload.Queries["sort"] = SourceExpressionConverter.ConvertO(sort);
                if (filter != null)
                    callPayload.Queries["filter"] = SourceExpressionConverter.ConvertO(filter);
                if (dir != null)
                    callPayload.Queries["dir"] = SourceExpressionConverter.Convert(dir);
                if (orFilter != null)
                    callPayload.Queries["orFilter"] = SourceExpressionConverter.ConvertO(orFilter);
                return callPayload;
            }

            return new ApiConnectionAction<CountRo>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<MeasureRo> GetMeasure([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<bool> detailed = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/measures/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["detailed"] = Convert.ToString(false);
                if (detailed != null)
                    callPayload.Queries["detailed"] = SourceExpressionConverter.ConvertO(detailed);
                return callPayload;
            }

            return new ApiConnectionAction<MeasureRo>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<PageMessageRo> GetMessages([WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null, [WorkflowExpression] Func<string> sortValues = null, [WorkflowExpression] Func<string> sort = null, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<dirInput> dir = null, [WorkflowExpression] Func<string> orFilter = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/messages";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (pageSize != null)
                    callPayload.Queries["pageSize"] = SourceExpressionConverter.ConvertO(pageSize);
                if (sortValues != null)
                    callPayload.Queries["sortValues"] = SourceExpressionConverter.ConvertO(sortValues);
                if (sort != null)
                    callPayload.Queries["sort"] = SourceExpressionConverter.ConvertO(sort);
                if (filter != null)
                    callPayload.Queries["filter"] = SourceExpressionConverter.ConvertO(filter);
                if (dir != null)
                    callPayload.Queries["dir"] = SourceExpressionConverter.Convert(dir);
                if (orFilter != null)
                    callPayload.Queries["orFilter"] = SourceExpressionConverter.ConvertO(orFilter);
                return callPayload;
            }

            return new ApiConnectionAction<PageMessageRo>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<PageMessageRo> GetMessagesAndMeasurements([WorkflowExpression] Func<string> thingId, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null, [WorkflowExpression] Func<string> sortValues = null, [WorkflowExpression] Func<string> sort = null, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<dirInput> dir = null, [WorkflowExpression] Func<string> orFilter = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/messages/things/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(thingId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (pageSize != null)
                    callPayload.Queries["pageSize"] = SourceExpressionConverter.ConvertO(pageSize);
                if (sortValues != null)
                    callPayload.Queries["sortValues"] = SourceExpressionConverter.ConvertO(sortValues);
                if (sort != null)
                    callPayload.Queries["sort"] = SourceExpressionConverter.ConvertO(sort);
                if (filter != null)
                    callPayload.Queries["filter"] = SourceExpressionConverter.ConvertO(filter);
                if (dir != null)
                    callPayload.Queries["dir"] = SourceExpressionConverter.Convert(dir);
                if (orFilter != null)
                    callPayload.Queries["orFilter"] = SourceExpressionConverter.ConvertO(orFilter);
                return callPayload;
            }

            return new ApiConnectionAction<PageMessageRo>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<MessageRo> AddMessage([WorkflowExpression] Func<string> thingId, [WorkflowExpression] Func<string> messageRobody, [WorkflowExpression] Func<string> messageRocreationDate, [WorkflowExpression] Func<string> messageRoerrorMessage, [WorkflowExpression] Func<double> messageRolatitude, [WorkflowExpression] Func<double> messageRolongitude, [WorkflowExpression] Func<string> messageRometadata, [WorkflowExpression] Func<int> messageRonumber, [WorkflowExpression] Func<messageRoprocessedInput> messageRoprocessed, [WorkflowExpression] Func<string> messageRothingname, [WorkflowExpression] Func<string> messageRotimestamp, [WorkflowExpression] Func<string> messageRotopic, [WorkflowExpression] Func<string> messageRoid = null, [WorkflowExpression] Func<bool> messageRolinkabsolute = null, [WorkflowExpression] Func<string> messageRolinkauthority = null, [WorkflowExpression] Func<string> messageRolinkfragment = null, [WorkflowExpression] Func<string> messageRolinkhost = null, [WorkflowExpression] Func<bool> messageRolinkopaque = null, [WorkflowExpression] Func<string> messageRolinkpath = null, [WorkflowExpression] Func<int> messageRolinkport = null, [WorkflowExpression] Func<string> messageRolinkquery = null, [WorkflowExpression] Func<string> messageRolinkrawAuthority = null, [WorkflowExpression] Func<string> messageRolinkrawFragment = null, [WorkflowExpression] Func<string> messageRolinkrawPath = null, [WorkflowExpression] Func<string> messageRolinkrawQuery = null, [WorkflowExpression] Func<string> messageRolinkrawSchemeSpecificPart = null, [WorkflowExpression] Func<string> messageRolinkrawUserInfo = null, [WorkflowExpression] Func<string> messageRolinkscheme = null, [WorkflowExpression] Func<string> messageRolinkschemeSpecificPart = null, [WorkflowExpression] Func<string> messageRolinkuserInfo = null, [WorkflowExpression] Func<bool> messageRorawMeasurementsarray = null, [WorkflowExpression] Func<bool> messageRorawMeasurementsbigDecimal = null, [WorkflowExpression] Func<bool> messageRorawMeasurementsbigInteger = null, [WorkflowExpression] Func<bool> messageRorawMeasurementsbinary = null, [WorkflowExpression] Func<bool> messageRorawMeasurementsboolean = null, [WorkflowExpression] Func<bool> messageRorawMeasurementscontainerNode = null, [WorkflowExpression] Func<bool> messageRorawMeasurementsDouble = null, [WorkflowExpression] Func<bool> messageRorawMeasurementsFloat = null, [WorkflowExpression] Func<bool> messageRorawMeasurementsfloatingPointNumber = null, [WorkflowExpression] Func<bool> messageRorawMeasurementsInt = null, [WorkflowExpression] Func<bool> messageRorawMeasurementsintegralNumber = null, [WorkflowExpression] Func<bool> messageRorawMeasurementsLong = null, [WorkflowExpression] Func<bool> messageRorawMeasurementsmissingNode = null, [WorkflowExpression] Func<messageRorawMeasurementsnodeTypeInput> messageRorawMeasurementsnodeType = null, [WorkflowExpression] Func<bool> messageRorawMeasurementsNull = null, [WorkflowExpression] Func<bool> messageRorawMeasurementsnumber = null, [WorkflowExpression] Func<bool> messageRorawMeasurementsObject = null, [WorkflowExpression] Func<bool> messageRorawMeasurementspojo = null, [WorkflowExpression] Func<bool> messageRorawMeasurementsShort = null, [WorkflowExpression] Func<bool> messageRorawMeasurementstextual = null, [WorkflowExpression] Func<bool> messageRorawMeasurementsvalueNode = null, [WorkflowExpression] Func<string> messageRothingdisplayName = null, [WorkflowExpression] Func<string> messageRothingfixedName = null, [WorkflowExpression] Func<string> messageRothingid = null, [WorkflowExpression] Func<int> messageRothingnbAlerts = null, [WorkflowExpression] Func<ThingTagRo[]> messageRothingtags = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/messages/things/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(thingId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var messageRo = new JObject();
                var messageRopropCount = 0;
                messageRopropCount++;
                messageRo["body"] = SourceExpressionConverter.ConvertToken(messageRobody);
                messageRopropCount++;
                messageRo["creationDate"] = SourceExpressionConverter.ConvertToken(messageRocreationDate);
                messageRopropCount++;
                messageRo["errorMessage"] = SourceExpressionConverter.ConvertToken(messageRoerrorMessage);
                if (messageRoid != null)
                {
                    messageRo["id"] = SourceExpressionConverter.ConvertToken(messageRoid);
                    messageRopropCount++;
                }

                messageRopropCount++;
                messageRo["latitude"] = SourceExpressionConverter.ConvertToken(messageRolatitude);
                var linkObject = new JObject();
                var linkObjectpropCount = 0;
                if (messageRolinkabsolute != null)
                {
                    linkObject["absolute"] = SourceExpressionConverter.ConvertToken(messageRolinkabsolute);
                    linkObjectpropCount++;
                }

                if (messageRolinkauthority != null)
                {
                    linkObject["authority"] = SourceExpressionConverter.ConvertToken(messageRolinkauthority);
                    linkObjectpropCount++;
                }

                if (messageRolinkfragment != null)
                {
                    linkObject["fragment"] = SourceExpressionConverter.ConvertToken(messageRolinkfragment);
                    linkObjectpropCount++;
                }

                if (messageRolinkhost != null)
                {
                    linkObject["host"] = SourceExpressionConverter.ConvertToken(messageRolinkhost);
                    linkObjectpropCount++;
                }

                if (messageRolinkopaque != null)
                {
                    linkObject["opaque"] = SourceExpressionConverter.ConvertToken(messageRolinkopaque);
                    linkObjectpropCount++;
                }

                if (messageRolinkpath != null)
                {
                    linkObject["path"] = SourceExpressionConverter.ConvertToken(messageRolinkpath);
                    linkObjectpropCount++;
                }

                if (messageRolinkport != null)
                {
                    linkObject["port"] = SourceExpressionConverter.ConvertToken(messageRolinkport);
                    linkObjectpropCount++;
                }

                if (messageRolinkquery != null)
                {
                    linkObject["query"] = SourceExpressionConverter.ConvertToken(messageRolinkquery);
                    linkObjectpropCount++;
                }

                if (messageRolinkrawAuthority != null)
                {
                    linkObject["rawAuthority"] = SourceExpressionConverter.ConvertToken(messageRolinkrawAuthority);
                    linkObjectpropCount++;
                }

                if (messageRolinkrawFragment != null)
                {
                    linkObject["rawFragment"] = SourceExpressionConverter.ConvertToken(messageRolinkrawFragment);
                    linkObjectpropCount++;
                }

                if (messageRolinkrawPath != null)
                {
                    linkObject["rawPath"] = SourceExpressionConverter.ConvertToken(messageRolinkrawPath);
                    linkObjectpropCount++;
                }

                if (messageRolinkrawQuery != null)
                {
                    linkObject["rawQuery"] = SourceExpressionConverter.ConvertToken(messageRolinkrawQuery);
                    linkObjectpropCount++;
                }

                if (messageRolinkrawSchemeSpecificPart != null)
                {
                    linkObject["rawSchemeSpecificPart"] = SourceExpressionConverter.ConvertToken(messageRolinkrawSchemeSpecificPart);
                    linkObjectpropCount++;
                }

                if (messageRolinkrawUserInfo != null)
                {
                    linkObject["rawUserInfo"] = SourceExpressionConverter.ConvertToken(messageRolinkrawUserInfo);
                    linkObjectpropCount++;
                }

                if (messageRolinkscheme != null)
                {
                    linkObject["scheme"] = SourceExpressionConverter.ConvertToken(messageRolinkscheme);
                    linkObjectpropCount++;
                }

                if (messageRolinkschemeSpecificPart != null)
                {
                    linkObject["schemeSpecificPart"] = SourceExpressionConverter.ConvertToken(messageRolinkschemeSpecificPart);
                    linkObjectpropCount++;
                }

                if (messageRolinkuserInfo != null)
                {
                    linkObject["userInfo"] = SourceExpressionConverter.ConvertToken(messageRolinkuserInfo);
                    linkObjectpropCount++;
                }

                if (linkObjectpropCount > 0)
                {
                    messageRo["link"] = linkObject;
                    messageRopropCount++;
                }

                messageRopropCount++;
                messageRo["longitude"] = SourceExpressionConverter.ConvertToken(messageRolongitude);
                var measurementsObject = new JObject();
                var measurementsObjectpropCount = 0;
                if (measurementsObjectpropCount > 0)
                {
                    messageRo["measurements"] = measurementsObject;
                    messageRopropCount++;
                }

                messageRopropCount++;
                messageRo["metadata"] = SourceExpressionConverter.ConvertToken(messageRometadata);
                messageRopropCount++;
                messageRo["number"] = SourceExpressionConverter.ConvertToken(messageRonumber);
                messageRopropCount++;
                messageRo["processed"] = SourceExpressionConverter.Convert(messageRoprocessed);
                var rawMeasurementsObject = new JObject();
                var rawMeasurementsObjectpropCount = 0;
                if (messageRorawMeasurementsarray != null)
                {
                    rawMeasurementsObject["array"] = SourceExpressionConverter.ConvertToken(messageRorawMeasurementsarray);
                    rawMeasurementsObjectpropCount++;
                }

                if (messageRorawMeasurementsbigDecimal != null)
                {
                    rawMeasurementsObject["bigDecimal"] = SourceExpressionConverter.ConvertToken(messageRorawMeasurementsbigDecimal);
                    rawMeasurementsObjectpropCount++;
                }

                if (messageRorawMeasurementsbigInteger != null)
                {
                    rawMeasurementsObject["bigInteger"] = SourceExpressionConverter.ConvertToken(messageRorawMeasurementsbigInteger);
                    rawMeasurementsObjectpropCount++;
                }

                if (messageRorawMeasurementsbinary != null)
                {
                    rawMeasurementsObject["binary"] = SourceExpressionConverter.ConvertToken(messageRorawMeasurementsbinary);
                    rawMeasurementsObjectpropCount++;
                }

                if (messageRorawMeasurementsboolean != null)
                {
                    rawMeasurementsObject["boolean"] = SourceExpressionConverter.ConvertToken(messageRorawMeasurementsboolean);
                    rawMeasurementsObjectpropCount++;
                }

                if (messageRorawMeasurementscontainerNode != null)
                {
                    rawMeasurementsObject["containerNode"] = SourceExpressionConverter.ConvertToken(messageRorawMeasurementscontainerNode);
                    rawMeasurementsObjectpropCount++;
                }

                if (messageRorawMeasurementsDouble != null)
                {
                    rawMeasurementsObject["double"] = SourceExpressionConverter.ConvertToken(messageRorawMeasurementsDouble);
                    rawMeasurementsObjectpropCount++;
                }

                if (messageRorawMeasurementsFloat != null)
                {
                    rawMeasurementsObject["float"] = SourceExpressionConverter.ConvertToken(messageRorawMeasurementsFloat);
                    rawMeasurementsObjectpropCount++;
                }

                if (messageRorawMeasurementsfloatingPointNumber != null)
                {
                    rawMeasurementsObject["floatingPointNumber"] = SourceExpressionConverter.ConvertToken(messageRorawMeasurementsfloatingPointNumber);
                    rawMeasurementsObjectpropCount++;
                }

                if (messageRorawMeasurementsInt != null)
                {
                    rawMeasurementsObject["int"] = SourceExpressionConverter.ConvertToken(messageRorawMeasurementsInt);
                    rawMeasurementsObjectpropCount++;
                }

                if (messageRorawMeasurementsintegralNumber != null)
                {
                    rawMeasurementsObject["integralNumber"] = SourceExpressionConverter.ConvertToken(messageRorawMeasurementsintegralNumber);
                    rawMeasurementsObjectpropCount++;
                }

                if (messageRorawMeasurementsLong != null)
                {
                    rawMeasurementsObject["long"] = SourceExpressionConverter.ConvertToken(messageRorawMeasurementsLong);
                    rawMeasurementsObjectpropCount++;
                }

                if (messageRorawMeasurementsmissingNode != null)
                {
                    rawMeasurementsObject["missingNode"] = SourceExpressionConverter.ConvertToken(messageRorawMeasurementsmissingNode);
                    rawMeasurementsObjectpropCount++;
                }

                if (messageRorawMeasurementsnodeType != null)
                {
                    rawMeasurementsObject["nodeType"] = SourceExpressionConverter.Convert(messageRorawMeasurementsnodeType);
                    rawMeasurementsObjectpropCount++;
                }

                if (messageRorawMeasurementsNull != null)
                {
                    rawMeasurementsObject["null"] = SourceExpressionConverter.ConvertToken(messageRorawMeasurementsNull);
                    rawMeasurementsObjectpropCount++;
                }

                if (messageRorawMeasurementsnumber != null)
                {
                    rawMeasurementsObject["number"] = SourceExpressionConverter.ConvertToken(messageRorawMeasurementsnumber);
                    rawMeasurementsObjectpropCount++;
                }

                if (messageRorawMeasurementsObject != null)
                {
                    rawMeasurementsObject["object"] = SourceExpressionConverter.ConvertToken(messageRorawMeasurementsObject);
                    rawMeasurementsObjectpropCount++;
                }

                if (messageRorawMeasurementspojo != null)
                {
                    rawMeasurementsObject["pojo"] = SourceExpressionConverter.ConvertToken(messageRorawMeasurementspojo);
                    rawMeasurementsObjectpropCount++;
                }

                if (messageRorawMeasurementsShort != null)
                {
                    rawMeasurementsObject["short"] = SourceExpressionConverter.ConvertToken(messageRorawMeasurementsShort);
                    rawMeasurementsObjectpropCount++;
                }

                if (messageRorawMeasurementstextual != null)
                {
                    rawMeasurementsObject["textual"] = SourceExpressionConverter.ConvertToken(messageRorawMeasurementstextual);
                    rawMeasurementsObjectpropCount++;
                }

                if (messageRorawMeasurementsvalueNode != null)
                {
                    rawMeasurementsObject["valueNode"] = SourceExpressionConverter.ConvertToken(messageRorawMeasurementsvalueNode);
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
                    thingObject["displayName"] = SourceExpressionConverter.ConvertToken(messageRothingdisplayName);
                    thingObjectpropCount++;
                }

                if (messageRothingfixedName != null)
                {
                    thingObject["fixedName"] = SourceExpressionConverter.ConvertToken(messageRothingfixedName);
                    thingObjectpropCount++;
                }

                if (messageRothingid != null)
                {
                    thingObject["id"] = SourceExpressionConverter.ConvertToken(messageRothingid);
                    thingObjectpropCount++;
                }

                thingObjectpropCount++;
                thingObject["name"] = SourceExpressionConverter.ConvertToken(messageRothingname);
                if (messageRothingnbAlerts != null)
                {
                    thingObject["nbAlerts"] = SourceExpressionConverter.ConvertToken(messageRothingnbAlerts);
                    thingObjectpropCount++;
                }

                if (messageRothingtags != null)
                {
                    thingObject["tags"] = SourceExpressionConverter.ConvertToken(messageRothingtags);
                    thingObjectpropCount++;
                }

                if (thingObjectpropCount > 0)
                {
                    messageRo["thing"] = thingObject;
                    messageRopropCount++;
                }

                messageRopropCount++;
                messageRo["timestamp"] = SourceExpressionConverter.ConvertToken(messageRotimestamp);
                messageRopropCount++;
                messageRo["topic"] = SourceExpressionConverter.ConvertToken(messageRotopic);
                if (messageRopropCount > 0)
                {
                    callPayload.Body = messageRo;
                }
                return callPayload;
            }

            return new ApiConnectionAction<MessageRo>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<MessageRo> GetMessage([WorkflowExpression] Func<string> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/messages/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<MessageRo>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<MessageRo> GetPreviousMessage([WorkflowExpression] Func<string> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/messages/{0}/previous", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<MessageRo>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<PageSiteRo> GetSites([WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null, [WorkflowExpression] Func<string> sortValues = null, [WorkflowExpression] Func<string> sort = null, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<dirInput> dir = null, [WorkflowExpression] Func<string> orFilter = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/sites";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (pageSize != null)
                    callPayload.Queries["pageSize"] = SourceExpressionConverter.ConvertO(pageSize);
                if (sortValues != null)
                    callPayload.Queries["sortValues"] = SourceExpressionConverter.ConvertO(sortValues);
                if (sort != null)
                    callPayload.Queries["sort"] = SourceExpressionConverter.ConvertO(sort);
                if (filter != null)
                    callPayload.Queries["filter"] = SourceExpressionConverter.ConvertO(filter);
                if (dir != null)
                    callPayload.Queries["dir"] = SourceExpressionConverter.Convert(dir);
                if (orFilter != null)
                    callPayload.Queries["orFilter"] = SourceExpressionConverter.ConvertO(orFilter);
                return callPayload;
            }

            return new ApiConnectionAction<PageSiteRo>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<SiteRo[]> CreateSite([WorkflowExpression] Func<bool> nodearray = null, [WorkflowExpression] Func<bool> nodebigDecimal = null, [WorkflowExpression] Func<bool> nodebigInteger = null, [WorkflowExpression] Func<bool> nodebinary = null, [WorkflowExpression] Func<bool> nodeboolean = null, [WorkflowExpression] Func<bool> nodecontainerNode = null, [WorkflowExpression] Func<bool> nodeDouble = null, [WorkflowExpression] Func<bool> nodeFloat = null, [WorkflowExpression] Func<bool> nodefloatingPointNumber = null, [WorkflowExpression] Func<bool> nodeInt = null, [WorkflowExpression] Func<bool> nodeintegralNumber = null, [WorkflowExpression] Func<bool> nodeLong = null, [WorkflowExpression] Func<bool> nodemissingNode = null, [WorkflowExpression] Func<nodenodeTypeInput> nodenodeType = null, [WorkflowExpression] Func<bool> nodeNull = null, [WorkflowExpression] Func<bool> nodenumber = null, [WorkflowExpression] Func<bool> nodeObject = null, [WorkflowExpression] Func<bool> nodepojo = null, [WorkflowExpression] Func<bool> nodeShort = null, [WorkflowExpression] Func<bool> nodetextual = null, [WorkflowExpression] Func<bool> nodevalueNode = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/sites";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var node = new JObject();
                var nodepropCount = 0;
                if (nodearray != null)
                {
                    node["array"] = SourceExpressionConverter.ConvertToken(nodearray);
                    nodepropCount++;
                }

                if (nodebigDecimal != null)
                {
                    node["bigDecimal"] = SourceExpressionConverter.ConvertToken(nodebigDecimal);
                    nodepropCount++;
                }

                if (nodebigInteger != null)
                {
                    node["bigInteger"] = SourceExpressionConverter.ConvertToken(nodebigInteger);
                    nodepropCount++;
                }

                if (nodebinary != null)
                {
                    node["binary"] = SourceExpressionConverter.ConvertToken(nodebinary);
                    nodepropCount++;
                }

                if (nodeboolean != null)
                {
                    node["boolean"] = SourceExpressionConverter.ConvertToken(nodeboolean);
                    nodepropCount++;
                }

                if (nodecontainerNode != null)
                {
                    node["containerNode"] = SourceExpressionConverter.ConvertToken(nodecontainerNode);
                    nodepropCount++;
                }

                if (nodeDouble != null)
                {
                    node["double"] = SourceExpressionConverter.ConvertToken(nodeDouble);
                    nodepropCount++;
                }

                if (nodeFloat != null)
                {
                    node["float"] = SourceExpressionConverter.ConvertToken(nodeFloat);
                    nodepropCount++;
                }

                if (nodefloatingPointNumber != null)
                {
                    node["floatingPointNumber"] = SourceExpressionConverter.ConvertToken(nodefloatingPointNumber);
                    nodepropCount++;
                }

                if (nodeInt != null)
                {
                    node["int"] = SourceExpressionConverter.ConvertToken(nodeInt);
                    nodepropCount++;
                }

                if (nodeintegralNumber != null)
                {
                    node["integralNumber"] = SourceExpressionConverter.ConvertToken(nodeintegralNumber);
                    nodepropCount++;
                }

                if (nodeLong != null)
                {
                    node["long"] = SourceExpressionConverter.ConvertToken(nodeLong);
                    nodepropCount++;
                }

                if (nodemissingNode != null)
                {
                    node["missingNode"] = SourceExpressionConverter.ConvertToken(nodemissingNode);
                    nodepropCount++;
                }

                if (nodenodeType != null)
                {
                    node["nodeType"] = SourceExpressionConverter.Convert(nodenodeType);
                    nodepropCount++;
                }

                if (nodeNull != null)
                {
                    node["null"] = SourceExpressionConverter.ConvertToken(nodeNull);
                    nodepropCount++;
                }

                if (nodenumber != null)
                {
                    node["number"] = SourceExpressionConverter.ConvertToken(nodenumber);
                    nodepropCount++;
                }

                if (nodeObject != null)
                {
                    node["object"] = SourceExpressionConverter.ConvertToken(nodeObject);
                    nodepropCount++;
                }

                if (nodepojo != null)
                {
                    node["pojo"] = SourceExpressionConverter.ConvertToken(nodepojo);
                    nodepropCount++;
                }

                if (nodeShort != null)
                {
                    node["short"] = SourceExpressionConverter.ConvertToken(nodeShort);
                    nodepropCount++;
                }

                if (nodetextual != null)
                {
                    node["textual"] = SourceExpressionConverter.ConvertToken(nodetextual);
                    nodepropCount++;
                }

                if (nodevalueNode != null)
                {
                    node["valueNode"] = SourceExpressionConverter.ConvertToken(nodevalueNode);
                    nodepropCount++;
                }

                if (nodepropCount > 0)
                {
                    callPayload.Body = node;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SiteRo[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<SiteRo> GetSite([WorkflowExpression] Func<string> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/sites/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<SiteRo>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IWorkflowAction DeleteSite([WorkflowExpression] Func<string> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/sites/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<SiteRo> UpdateSite([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> siteRoaddress, [WorkflowExpression] Func<string> siteRocity, [WorkflowExpression] Func<string> siteRoname, [WorkflowExpression] Func<string> siteRopostalCode, [WorkflowExpression] Func<string> siteRoid = null, [WorkflowExpression] Func<double> siteRolatitude = null, [WorkflowExpression] Func<double> siteRolongitude = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/sites/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var siteRo = new JObject();
                var siteRopropCount = 0;
                siteRopropCount++;
                siteRo["address"] = SourceExpressionConverter.ConvertToken(siteRoaddress);
                siteRopropCount++;
                siteRo["city"] = SourceExpressionConverter.ConvertToken(siteRocity);
                if (siteRoid != null)
                {
                    siteRo["id"] = SourceExpressionConverter.ConvertToken(siteRoid);
                    siteRopropCount++;
                }

                if (siteRolatitude != null)
                {
                    siteRo["latitude"] = SourceExpressionConverter.ConvertToken(siteRolatitude);
                    siteRopropCount++;
                }

                if (siteRolongitude != null)
                {
                    siteRo["longitude"] = SourceExpressionConverter.ConvertToken(siteRolongitude);
                    siteRopropCount++;
                }

                siteRopropCount++;
                siteRo["name"] = SourceExpressionConverter.ConvertToken(siteRoname);
                siteRopropCount++;
                siteRo["postalCode"] = SourceExpressionConverter.ConvertToken(siteRopostalCode);
                if (siteRopropCount > 0)
                {
                    callPayload.Body = siteRo;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SiteRo>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<PageThingTagRo> GetTags([WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null, [WorkflowExpression] Func<string> sortValues = null, [WorkflowExpression] Func<string> sort = null, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<dirInput> dir = null, [WorkflowExpression] Func<string> orFilter = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/tags";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (pageSize != null)
                    callPayload.Queries["pageSize"] = SourceExpressionConverter.ConvertO(pageSize);
                if (sortValues != null)
                    callPayload.Queries["sortValues"] = SourceExpressionConverter.ConvertO(sortValues);
                if (sort != null)
                    callPayload.Queries["sort"] = SourceExpressionConverter.ConvertO(sort);
                if (filter != null)
                    callPayload.Queries["filter"] = SourceExpressionConverter.ConvertO(filter);
                if (dir != null)
                    callPayload.Queries["dir"] = SourceExpressionConverter.Convert(dir);
                if (orFilter != null)
                    callPayload.Queries["orFilter"] = SourceExpressionConverter.ConvertO(orFilter);
                return callPayload;
            }

            return new ApiConnectionAction<PageThingTagRo>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<TagRo> UpdateThingTag([WorkflowExpression] Func<string> thingTagRoid = null, [WorkflowExpression] Func<string> thingTagRotag = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/tags";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var thingTagRo = new JObject();
                var thingTagRopropCount = 0;
                if (thingTagRoid != null)
                {
                    thingTagRo["id"] = SourceExpressionConverter.ConvertToken(thingTagRoid);
                    thingTagRopropCount++;
                }

                if (thingTagRotag != null)
                {
                    thingTagRo["tag"] = SourceExpressionConverter.ConvertToken(thingTagRotag);
                    thingTagRopropCount++;
                }

                if (thingTagRopropCount > 0)
                {
                    callPayload.Body = thingTagRo;
                }
                return callPayload;
            }

            return new ApiConnectionAction<TagRo>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<TagRo> AddThingTag([WorkflowExpression] Func<string> thingId, [WorkflowExpression] Func<string> thingTagRoid = null, [WorkflowExpression] Func<string> thingTagRotag = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/tags/thing/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(thingId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var thingTagRo = new JObject();
                var thingTagRopropCount = 0;
                if (thingTagRoid != null)
                {
                    thingTagRo["id"] = SourceExpressionConverter.ConvertToken(thingTagRoid);
                    thingTagRopropCount++;
                }

                if (thingTagRotag != null)
                {
                    thingTagRo["tag"] = SourceExpressionConverter.ConvertToken(thingTagRotag);
                    thingTagRopropCount++;
                }

                if (thingTagRopropCount > 0)
                {
                    callPayload.Body = thingTagRo;
                }
                return callPayload;
            }

            return new ApiConnectionAction<TagRo>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<TagRo> GetThingTag([WorkflowExpression] Func<string> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/tags/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<TagRo>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<PageSingleThingRo> GetThings([WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null, [WorkflowExpression] Func<string> sortValues = null, [WorkflowExpression] Func<string> sort = null, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<dirInput> dir = null, [WorkflowExpression] Func<string> orFilter = null, [WorkflowExpression] Func<bool> detailed = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/things";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (pageSize != null)
                    callPayload.Queries["pageSize"] = SourceExpressionConverter.ConvertO(pageSize);
                if (sortValues != null)
                    callPayload.Queries["sortValues"] = SourceExpressionConverter.ConvertO(sortValues);
                if (sort != null)
                    callPayload.Queries["sort"] = SourceExpressionConverter.ConvertO(sort);
                if (filter != null)
                    callPayload.Queries["filter"] = SourceExpressionConverter.ConvertO(filter);
                if (dir != null)
                    callPayload.Queries["dir"] = SourceExpressionConverter.Convert(dir);
                if (orFilter != null)
                    callPayload.Queries["orFilter"] = SourceExpressionConverter.ConvertO(orFilter);
                callPayload.Queries["detailed"] = Convert.ToString(false);
                if (detailed != null)
                    callPayload.Queries["detailed"] = SourceExpressionConverter.ConvertO(detailed);
                return callPayload;
            }

            return new ApiConnectionAction<PageSingleThingRo>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<SingleThingRo[]> AssociateThingsWithProduct([WorkflowExpression] Func<bool> jsonarray = null, [WorkflowExpression] Func<bool> jsonbigDecimal = null, [WorkflowExpression] Func<bool> jsonbigInteger = null, [WorkflowExpression] Func<bool> jsonbinary = null, [WorkflowExpression] Func<bool> jsonboolean = null, [WorkflowExpression] Func<bool> jsoncontainerNode = null, [WorkflowExpression] Func<bool> jsonDouble = null, [WorkflowExpression] Func<bool> jsonFloat = null, [WorkflowExpression] Func<bool> jsonfloatingPointNumber = null, [WorkflowExpression] Func<bool> jsonInt = null, [WorkflowExpression] Func<bool> jsonintegralNumber = null, [WorkflowExpression] Func<bool> jsonLong = null, [WorkflowExpression] Func<bool> jsonmissingNode = null, [WorkflowExpression] Func<jsonnodeTypeInput> jsonnodeType = null, [WorkflowExpression] Func<bool> jsonNull = null, [WorkflowExpression] Func<bool> jsonnumber = null, [WorkflowExpression] Func<bool> jsonObject = null, [WorkflowExpression] Func<bool> jsonpojo = null, [WorkflowExpression] Func<bool> jsonShort = null, [WorkflowExpression] Func<bool> jsontextual = null, [WorkflowExpression] Func<bool> jsonvalueNode = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/things";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var json = new JObject();
                var jsonpropCount = 0;
                if (jsonarray != null)
                {
                    json["array"] = SourceExpressionConverter.ConvertToken(jsonarray);
                    jsonpropCount++;
                }

                if (jsonbigDecimal != null)
                {
                    json["bigDecimal"] = SourceExpressionConverter.ConvertToken(jsonbigDecimal);
                    jsonpropCount++;
                }

                if (jsonbigInteger != null)
                {
                    json["bigInteger"] = SourceExpressionConverter.ConvertToken(jsonbigInteger);
                    jsonpropCount++;
                }

                if (jsonbinary != null)
                {
                    json["binary"] = SourceExpressionConverter.ConvertToken(jsonbinary);
                    jsonpropCount++;
                }

                if (jsonboolean != null)
                {
                    json["boolean"] = SourceExpressionConverter.ConvertToken(jsonboolean);
                    jsonpropCount++;
                }

                if (jsoncontainerNode != null)
                {
                    json["containerNode"] = SourceExpressionConverter.ConvertToken(jsoncontainerNode);
                    jsonpropCount++;
                }

                if (jsonDouble != null)
                {
                    json["double"] = SourceExpressionConverter.ConvertToken(jsonDouble);
                    jsonpropCount++;
                }

                if (jsonFloat != null)
                {
                    json["float"] = SourceExpressionConverter.ConvertToken(jsonFloat);
                    jsonpropCount++;
                }

                if (jsonfloatingPointNumber != null)
                {
                    json["floatingPointNumber"] = SourceExpressionConverter.ConvertToken(jsonfloatingPointNumber);
                    jsonpropCount++;
                }

                if (jsonInt != null)
                {
                    json["int"] = SourceExpressionConverter.ConvertToken(jsonInt);
                    jsonpropCount++;
                }

                if (jsonintegralNumber != null)
                {
                    json["integralNumber"] = SourceExpressionConverter.ConvertToken(jsonintegralNumber);
                    jsonpropCount++;
                }

                if (jsonLong != null)
                {
                    json["long"] = SourceExpressionConverter.ConvertToken(jsonLong);
                    jsonpropCount++;
                }

                if (jsonmissingNode != null)
                {
                    json["missingNode"] = SourceExpressionConverter.ConvertToken(jsonmissingNode);
                    jsonpropCount++;
                }

                if (jsonnodeType != null)
                {
                    json["nodeType"] = SourceExpressionConverter.Convert(jsonnodeType);
                    jsonpropCount++;
                }

                if (jsonNull != null)
                {
                    json["null"] = SourceExpressionConverter.ConvertToken(jsonNull);
                    jsonpropCount++;
                }

                if (jsonnumber != null)
                {
                    json["number"] = SourceExpressionConverter.ConvertToken(jsonnumber);
                    jsonpropCount++;
                }

                if (jsonObject != null)
                {
                    json["object"] = SourceExpressionConverter.ConvertToken(jsonObject);
                    jsonpropCount++;
                }

                if (jsonpojo != null)
                {
                    json["pojo"] = SourceExpressionConverter.ConvertToken(jsonpojo);
                    jsonpropCount++;
                }

                if (jsonShort != null)
                {
                    json["short"] = SourceExpressionConverter.ConvertToken(jsonShort);
                    jsonpropCount++;
                }

                if (jsontextual != null)
                {
                    json["textual"] = SourceExpressionConverter.ConvertToken(jsontextual);
                    jsonpropCount++;
                }

                if (jsonvalueNode != null)
                {
                    json["valueNode"] = SourceExpressionConverter.ConvertToken(jsonvalueNode);
                    jsonpropCount++;
                }

                if (jsonpropCount > 0)
                {
                    callPayload.Body = json;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SingleThingRo[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<SingleThingRo[]> GetThingList([WorkflowExpression] Func<string[]> thingIds = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/things/list";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = SourceExpressionConverter.ConvertToken(thingIds);
                return callPayload;
            }

            return new ApiConnectionAction<SingleThingRo[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<SingleThingRo> GetThing([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<bool> detailed = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/things/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["detailed"] = Convert.ToString(false);
                if (detailed != null)
                    callPayload.Queries["detailed"] = SourceExpressionConverter.ConvertO(detailed);
                return callPayload;
            }

            return new ApiConnectionAction<SingleThingRo>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IWorkflowAction IgnoreThing([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<bool> force = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/things/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (force != null)
                    callPayload.Queries["force"] = SourceExpressionConverter.ConvertO(force);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<ThingRo> PutThing([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> thingRoname, [WorkflowExpression] Func<string> thingRositeaddress, [WorkflowExpression] Func<string> thingRositecity, [WorkflowExpression] Func<string> thingRositename, [WorkflowExpression] Func<string> thingRositepostalCode, [WorkflowExpression] Func<string> thingRoapplicationid = null, [WorkflowExpression] Func<string> thingRoapplicationlink = null, [WorkflowExpression] Func<string> thingRoapplicationname = null, [WorkflowExpression] Func<string> thingRoconnectivityid = null, [WorkflowExpression] Func<string> thingRoconnectivityrawStatus = null, [WorkflowExpression] Func<thingRoconnectivitystatusInput> thingRoconnectivitystatus = null, [WorkflowExpression] Func<thingRoconnectivitytypeInput> thingRoconnectivitytype = null, [WorkflowExpression] Func<CustomFieldRo[]> thingRocustomFields = null, [WorkflowExpression] Func<string> thingRocustomModelcolor = null, [WorkflowExpression] Func<string> thingRocustomModelicon = null, [WorkflowExpression] Func<string> thingRocustomModelid = null, [WorkflowExpression] Func<string> thingRocustomModellink = null, [WorkflowExpression] Func<string> thingRocustomModelname = null, [WorkflowExpression] Func<string> thingRodescription = null, [WorkflowExpression] Func<int> thingRodevicebatteryLevel = null, [WorkflowExpression] Func<thingRodevicebatteryStatusInput> thingRodevicebatteryStatus = null, [WorkflowExpression] Func<string> thingRodevicedeviceType = null, [WorkflowExpression] Func<string> thingRodeviceid = null, [WorkflowExpression] Func<string> thingRodevicemanufacturer = null, [WorkflowExpression] Func<int> thingRodevicememoryFree = null, [WorkflowExpression] Func<int> thingRodevicememoryTotal = null, [WorkflowExpression] Func<string> thingRodevicemodel = null, [WorkflowExpression] Func<string> thingRodevicemodelNumber = null, [WorkflowExpression] Func<string> thingRodevicename = null, [WorkflowExpression] Func<string> thingRodeviceserialNumber = null, [WorkflowExpression] Func<thingRodevicestatusInput> thingRodevicestatus = null, [WorkflowExpression] Func<string> thingRodisplayName = null, [WorkflowExpression] Func<bool> thingRodynamicGps = null, [WorkflowExpression] Func<double> thingRofixedLatitude = null, [WorkflowExpression] Func<double> thingRofixedLongitude = null, [WorkflowExpression] Func<string> thingRofixedName = null, [WorkflowExpression] Func<string> thingRoid = null, [WorkflowExpression] Func<int> thingRolastActivityDate = null, [WorkflowExpression] Func<double> thingRolastLatitude = null, [WorkflowExpression] Func<double> thingRolastLongitude = null, [WorkflowExpression] Func<bool> thingRolastMeasurementsarray = null, [WorkflowExpression] Func<bool> thingRolastMeasurementsbigDecimal = null, [WorkflowExpression] Func<bool> thingRolastMeasurementsbigInteger = null, [WorkflowExpression] Func<bool> thingRolastMeasurementsbinary = null, [WorkflowExpression] Func<bool> thingRolastMeasurementsboolean = null, [WorkflowExpression] Func<bool> thingRolastMeasurementscontainerNode = null, [WorkflowExpression] Func<bool> thingRolastMeasurementsDouble = null, [WorkflowExpression] Func<bool> thingRolastMeasurementsFloat = null, [WorkflowExpression] Func<bool> thingRolastMeasurementsfloatingPointNumber = null, [WorkflowExpression] Func<bool> thingRolastMeasurementsInt = null, [WorkflowExpression] Func<bool> thingRolastMeasurementsintegralNumber = null, [WorkflowExpression] Func<bool> thingRolastMeasurementsLong = null, [WorkflowExpression] Func<bool> thingRolastMeasurementsmissingNode = null, [WorkflowExpression] Func<thingRolastMeasurementsnodeTypeInput> thingRolastMeasurementsnodeType = null, [WorkflowExpression] Func<bool> thingRolastMeasurementsNull = null, [WorkflowExpression] Func<bool> thingRolastMeasurementsnumber = null, [WorkflowExpression] Func<bool> thingRolastMeasurementsObject = null, [WorkflowExpression] Func<bool> thingRolastMeasurementspojo = null, [WorkflowExpression] Func<bool> thingRolastMeasurementsShort = null, [WorkflowExpression] Func<bool> thingRolastMeasurementstextual = null, [WorkflowExpression] Func<bool> thingRolastMeasurementsvalueNode = null, [WorkflowExpression] Func<bool> thingRolastMeasurementsTimestampsarray = null, [WorkflowExpression] Func<bool> thingRolastMeasurementsTimestampsbigDecimal = null, [WorkflowExpression] Func<bool> thingRolastMeasurementsTimestampsbigInteger = null, [WorkflowExpression] Func<bool> thingRolastMeasurementsTimestampsbinary = null, [WorkflowExpression] Func<bool> thingRolastMeasurementsTimestampsboolean = null, [WorkflowExpression] Func<bool> thingRolastMeasurementsTimestampscontainerNode = null, [WorkflowExpression] Func<bool> thingRolastMeasurementsTimestampsDouble = null, [WorkflowExpression] Func<bool> thingRolastMeasurementsTimestampsFloat = null, [WorkflowExpression] Func<bool> thingRolastMeasurementsTimestampsfloatingPointNumber = null, [WorkflowExpression] Func<bool> thingRolastMeasurementsTimestampsInt = null, [WorkflowExpression] Func<bool> thingRolastMeasurementsTimestampsintegralNumber = null, [WorkflowExpression] Func<bool> thingRolastMeasurementsTimestampsLong = null, [WorkflowExpression] Func<bool> thingRolastMeasurementsTimestampsmissingNode = null, [WorkflowExpression] Func<thingRolastMeasurementsTimestampsnodeTypeInput> thingRolastMeasurementsTimestampsnodeType = null, [WorkflowExpression] Func<bool> thingRolastMeasurementsTimestampsNull = null, [WorkflowExpression] Func<bool> thingRolastMeasurementsTimestampsnumber = null, [WorkflowExpression] Func<bool> thingRolastMeasurementsTimestampsObject = null, [WorkflowExpression] Func<bool> thingRolastMeasurementsTimestampspojo = null, [WorkflowExpression] Func<bool> thingRolastMeasurementsTimestampsShort = null, [WorkflowExpression] Func<bool> thingRolastMeasurementsTimestampstextual = null, [WorkflowExpression] Func<bool> thingRolastMeasurementsTimestampsvalueNode = null, [WorkflowExpression] Func<int> thingRolastMessageDate = null, [WorkflowExpression] Func<int> thingRomessageActivityTimeoutPeriod = null, [WorkflowExpression] Func<int> thingRonbAlerts = null, [WorkflowExpression] Func<thingRoproductconnectivityTypesInputItem[]> thingRoproductconnectivityTypes = null, [WorkflowExpression] Func<bool> thingRoproductgenerateLinks = null, [WorkflowExpression] Func<string> thingRoproductid = null, [WorkflowExpression] Func<string> thingRoproductlink = null, [WorkflowExpression] Func<bool> thingRoproductmanufacturergenerateLinks = null, [WorkflowExpression] Func<string> thingRoproductmanufacturerid = null, [WorkflowExpression] Func<string> thingRoproductmanufacturerlink = null, [WorkflowExpression] Func<string> thingRoproductmanufacturername = null, [WorkflowExpression] Func<string> thingRoproductmodelcolor = null, [WorkflowExpression] Func<bool> thingRoproductmodelgenerateLinks = null, [WorkflowExpression] Func<string> thingRoproductmodelicon = null, [WorkflowExpression] Func<string> thingRoproductmodelid = null, [WorkflowExpression] Func<bool> thingRoproductmodelisCustomModel = null, [WorkflowExpression] Func<bool> thingRoproductmodellinkabsolute = null, [WorkflowExpression] Func<string> thingRoproductmodellinkauthority = null, [WorkflowExpression] Func<string> thingRoproductmodellinkfragment = null, [WorkflowExpression] Func<string> thingRoproductmodellinkhost = null, [WorkflowExpression] Func<bool> thingRoproductmodellinkopaque = null, [WorkflowExpression] Func<string> thingRoproductmodellinkpath = null, [WorkflowExpression] Func<int> thingRoproductmodellinkport = null, [WorkflowExpression] Func<string> thingRoproductmodellinkquery = null, [WorkflowExpression] Func<string> thingRoproductmodellinkrawAuthority = null, [WorkflowExpression] Func<string> thingRoproductmodellinkrawFragment = null, [WorkflowExpression] Func<string> thingRoproductmodellinkrawPath = null, [WorkflowExpression] Func<string> thingRoproductmodellinkrawQuery = null, [WorkflowExpression] Func<string> thingRoproductmodellinkrawSchemeSpecificPart = null, [WorkflowExpression] Func<string> thingRoproductmodellinkrawUserInfo = null, [WorkflowExpression] Func<string> thingRoproductmodellinkscheme = null, [WorkflowExpression] Func<string> thingRoproductmodellinkschemeSpecificPart = null, [WorkflowExpression] Func<string> thingRoproductmodellinkuserInfo = null, [WorkflowExpression] Func<string> thingRoproductmodelname = null, [WorkflowExpression] Func<string> thingRoproductname = null, [WorkflowExpression] Func<string> thingRoproductreference = null, [WorkflowExpression] Func<string> thingRositeid = null, [WorkflowExpression] Func<double> thingRositelatitude = null, [WorkflowExpression] Func<double> thingRositelongitude = null, [WorkflowExpression] Func<string> thingRosourceId = null, [WorkflowExpression] Func<thingRostatusInput> thingRostatus = null, [WorkflowExpression] Func<ThingTagRo[]> thingRotags = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/things/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var thingRo = new JObject();
                var thingRopropCount = 0;
                var applicationObject = new JObject();
                var applicationObjectpropCount = 0;
                if (thingRoapplicationid != null)
                {
                    applicationObject["id"] = SourceExpressionConverter.ConvertToken(thingRoapplicationid);
                    applicationObjectpropCount++;
                }

                if (thingRoapplicationlink != null)
                {
                    applicationObject["link"] = SourceExpressionConverter.ConvertToken(thingRoapplicationlink);
                    applicationObjectpropCount++;
                }

                if (thingRoapplicationname != null)
                {
                    applicationObject["name"] = SourceExpressionConverter.ConvertToken(thingRoapplicationname);
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
                    connectivityObject["id"] = SourceExpressionConverter.ConvertToken(thingRoconnectivityid);
                    connectivityObjectpropCount++;
                }

                if (thingRoconnectivityrawStatus != null)
                {
                    connectivityObject["rawStatus"] = SourceExpressionConverter.ConvertToken(thingRoconnectivityrawStatus);
                    connectivityObjectpropCount++;
                }

                if (thingRoconnectivitystatus != null)
                {
                    connectivityObject["status"] = SourceExpressionConverter.Convert(thingRoconnectivitystatus);
                    connectivityObjectpropCount++;
                }

                if (thingRoconnectivitytype != null)
                {
                    connectivityObject["type"] = SourceExpressionConverter.Convert(thingRoconnectivitytype);
                    connectivityObjectpropCount++;
                }

                if (connectivityObjectpropCount > 0)
                {
                    thingRo["connectivity"] = connectivityObject;
                    thingRopropCount++;
                }

                if (thingRocustomFields != null)
                {
                    thingRo["customFields"] = SourceExpressionConverter.ConvertToken(thingRocustomFields);
                    thingRopropCount++;
                }

                var customModelObject = new JObject();
                var customModelObjectpropCount = 0;
                if (thingRocustomModelcolor != null)
                {
                    customModelObject["color"] = SourceExpressionConverter.ConvertToken(thingRocustomModelcolor);
                    customModelObjectpropCount++;
                }

                if (thingRocustomModelicon != null)
                {
                    customModelObject["icon"] = SourceExpressionConverter.ConvertToken(thingRocustomModelicon);
                    customModelObjectpropCount++;
                }

                if (thingRocustomModelid != null)
                {
                    customModelObject["id"] = SourceExpressionConverter.ConvertToken(thingRocustomModelid);
                    customModelObjectpropCount++;
                }

                if (thingRocustomModellink != null)
                {
                    customModelObject["link"] = SourceExpressionConverter.ConvertToken(thingRocustomModellink);
                    customModelObjectpropCount++;
                }

                if (thingRocustomModelname != null)
                {
                    customModelObject["name"] = SourceExpressionConverter.ConvertToken(thingRocustomModelname);
                    customModelObjectpropCount++;
                }

                if (customModelObjectpropCount > 0)
                {
                    thingRo["customModel"] = customModelObject;
                    thingRopropCount++;
                }

                if (thingRodescription != null)
                {
                    thingRo["description"] = SourceExpressionConverter.ConvertToken(thingRodescription);
                    thingRopropCount++;
                }

                var deviceObject = new JObject();
                var deviceObjectpropCount = 0;
                if (thingRodevicebatteryLevel != null)
                {
                    deviceObject["batteryLevel"] = SourceExpressionConverter.ConvertToken(thingRodevicebatteryLevel);
                    deviceObjectpropCount++;
                }

                if (thingRodevicebatteryStatus != null)
                {
                    deviceObject["batteryStatus"] = SourceExpressionConverter.Convert(thingRodevicebatteryStatus);
                    deviceObjectpropCount++;
                }

                if (thingRodevicedeviceType != null)
                {
                    deviceObject["deviceType"] = SourceExpressionConverter.ConvertToken(thingRodevicedeviceType);
                    deviceObjectpropCount++;
                }

                if (thingRodeviceid != null)
                {
                    deviceObject["id"] = SourceExpressionConverter.ConvertToken(thingRodeviceid);
                    deviceObjectpropCount++;
                }

                if (thingRodevicemanufacturer != null)
                {
                    deviceObject["manufacturer"] = SourceExpressionConverter.ConvertToken(thingRodevicemanufacturer);
                    deviceObjectpropCount++;
                }

                if (thingRodevicememoryFree != null)
                {
                    deviceObject["memoryFree"] = SourceExpressionConverter.ConvertToken(thingRodevicememoryFree);
                    deviceObjectpropCount++;
                }

                if (thingRodevicememoryTotal != null)
                {
                    deviceObject["memoryTotal"] = SourceExpressionConverter.ConvertToken(thingRodevicememoryTotal);
                    deviceObjectpropCount++;
                }

                if (thingRodevicemodel != null)
                {
                    deviceObject["model"] = SourceExpressionConverter.ConvertToken(thingRodevicemodel);
                    deviceObjectpropCount++;
                }

                if (thingRodevicemodelNumber != null)
                {
                    deviceObject["modelNumber"] = SourceExpressionConverter.ConvertToken(thingRodevicemodelNumber);
                    deviceObjectpropCount++;
                }

                if (thingRodevicename != null)
                {
                    deviceObject["name"] = SourceExpressionConverter.ConvertToken(thingRodevicename);
                    deviceObjectpropCount++;
                }

                if (thingRodeviceserialNumber != null)
                {
                    deviceObject["serialNumber"] = SourceExpressionConverter.ConvertToken(thingRodeviceserialNumber);
                    deviceObjectpropCount++;
                }

                if (thingRodevicestatus != null)
                {
                    deviceObject["status"] = SourceExpressionConverter.Convert(thingRodevicestatus);
                    deviceObjectpropCount++;
                }

                if (deviceObjectpropCount > 0)
                {
                    thingRo["device"] = deviceObject;
                    thingRopropCount++;
                }

                if (thingRodisplayName != null)
                {
                    thingRo["displayName"] = SourceExpressionConverter.ConvertToken(thingRodisplayName);
                    thingRopropCount++;
                }

                if (thingRodynamicGps != null)
                {
                    thingRo["dynamicGps"] = SourceExpressionConverter.ConvertToken(thingRodynamicGps);
                    thingRopropCount++;
                }

                if (thingRofixedLatitude != null)
                {
                    thingRo["fixedLatitude"] = SourceExpressionConverter.ConvertToken(thingRofixedLatitude);
                    thingRopropCount++;
                }

                if (thingRofixedLongitude != null)
                {
                    thingRo["fixedLongitude"] = SourceExpressionConverter.ConvertToken(thingRofixedLongitude);
                    thingRopropCount++;
                }

                if (thingRofixedName != null)
                {
                    thingRo["fixedName"] = SourceExpressionConverter.ConvertToken(thingRofixedName);
                    thingRopropCount++;
                }

                if (thingRoid != null)
                {
                    thingRo["id"] = SourceExpressionConverter.ConvertToken(thingRoid);
                    thingRopropCount++;
                }

                if (thingRolastActivityDate != null)
                {
                    thingRo["lastActivityDate"] = SourceExpressionConverter.ConvertToken(thingRolastActivityDate);
                    thingRopropCount++;
                }

                if (thingRolastLatitude != null)
                {
                    thingRo["lastLatitude"] = SourceExpressionConverter.ConvertToken(thingRolastLatitude);
                    thingRopropCount++;
                }

                if (thingRolastLongitude != null)
                {
                    thingRo["lastLongitude"] = SourceExpressionConverter.ConvertToken(thingRolastLongitude);
                    thingRopropCount++;
                }

                var lastMeasurementsObject = new JObject();
                var lastMeasurementsObjectpropCount = 0;
                if (thingRolastMeasurementsarray != null)
                {
                    lastMeasurementsObject["array"] = SourceExpressionConverter.ConvertToken(thingRolastMeasurementsarray);
                    lastMeasurementsObjectpropCount++;
                }

                if (thingRolastMeasurementsbigDecimal != null)
                {
                    lastMeasurementsObject["bigDecimal"] = SourceExpressionConverter.ConvertToken(thingRolastMeasurementsbigDecimal);
                    lastMeasurementsObjectpropCount++;
                }

                if (thingRolastMeasurementsbigInteger != null)
                {
                    lastMeasurementsObject["bigInteger"] = SourceExpressionConverter.ConvertToken(thingRolastMeasurementsbigInteger);
                    lastMeasurementsObjectpropCount++;
                }

                if (thingRolastMeasurementsbinary != null)
                {
                    lastMeasurementsObject["binary"] = SourceExpressionConverter.ConvertToken(thingRolastMeasurementsbinary);
                    lastMeasurementsObjectpropCount++;
                }

                if (thingRolastMeasurementsboolean != null)
                {
                    lastMeasurementsObject["boolean"] = SourceExpressionConverter.ConvertToken(thingRolastMeasurementsboolean);
                    lastMeasurementsObjectpropCount++;
                }

                if (thingRolastMeasurementscontainerNode != null)
                {
                    lastMeasurementsObject["containerNode"] = SourceExpressionConverter.ConvertToken(thingRolastMeasurementscontainerNode);
                    lastMeasurementsObjectpropCount++;
                }

                if (thingRolastMeasurementsDouble != null)
                {
                    lastMeasurementsObject["double"] = SourceExpressionConverter.ConvertToken(thingRolastMeasurementsDouble);
                    lastMeasurementsObjectpropCount++;
                }

                if (thingRolastMeasurementsFloat != null)
                {
                    lastMeasurementsObject["float"] = SourceExpressionConverter.ConvertToken(thingRolastMeasurementsFloat);
                    lastMeasurementsObjectpropCount++;
                }

                if (thingRolastMeasurementsfloatingPointNumber != null)
                {
                    lastMeasurementsObject["floatingPointNumber"] = SourceExpressionConverter.ConvertToken(thingRolastMeasurementsfloatingPointNumber);
                    lastMeasurementsObjectpropCount++;
                }

                if (thingRolastMeasurementsInt != null)
                {
                    lastMeasurementsObject["int"] = SourceExpressionConverter.ConvertToken(thingRolastMeasurementsInt);
                    lastMeasurementsObjectpropCount++;
                }

                if (thingRolastMeasurementsintegralNumber != null)
                {
                    lastMeasurementsObject["integralNumber"] = SourceExpressionConverter.ConvertToken(thingRolastMeasurementsintegralNumber);
                    lastMeasurementsObjectpropCount++;
                }

                if (thingRolastMeasurementsLong != null)
                {
                    lastMeasurementsObject["long"] = SourceExpressionConverter.ConvertToken(thingRolastMeasurementsLong);
                    lastMeasurementsObjectpropCount++;
                }

                if (thingRolastMeasurementsmissingNode != null)
                {
                    lastMeasurementsObject["missingNode"] = SourceExpressionConverter.ConvertToken(thingRolastMeasurementsmissingNode);
                    lastMeasurementsObjectpropCount++;
                }

                if (thingRolastMeasurementsnodeType != null)
                {
                    lastMeasurementsObject["nodeType"] = SourceExpressionConverter.Convert(thingRolastMeasurementsnodeType);
                    lastMeasurementsObjectpropCount++;
                }

                if (thingRolastMeasurementsNull != null)
                {
                    lastMeasurementsObject["null"] = SourceExpressionConverter.ConvertToken(thingRolastMeasurementsNull);
                    lastMeasurementsObjectpropCount++;
                }

                if (thingRolastMeasurementsnumber != null)
                {
                    lastMeasurementsObject["number"] = SourceExpressionConverter.ConvertToken(thingRolastMeasurementsnumber);
                    lastMeasurementsObjectpropCount++;
                }

                if (thingRolastMeasurementsObject != null)
                {
                    lastMeasurementsObject["object"] = SourceExpressionConverter.ConvertToken(thingRolastMeasurementsObject);
                    lastMeasurementsObjectpropCount++;
                }

                if (thingRolastMeasurementspojo != null)
                {
                    lastMeasurementsObject["pojo"] = SourceExpressionConverter.ConvertToken(thingRolastMeasurementspojo);
                    lastMeasurementsObjectpropCount++;
                }

                if (thingRolastMeasurementsShort != null)
                {
                    lastMeasurementsObject["short"] = SourceExpressionConverter.ConvertToken(thingRolastMeasurementsShort);
                    lastMeasurementsObjectpropCount++;
                }

                if (thingRolastMeasurementstextual != null)
                {
                    lastMeasurementsObject["textual"] = SourceExpressionConverter.ConvertToken(thingRolastMeasurementstextual);
                    lastMeasurementsObjectpropCount++;
                }

                if (thingRolastMeasurementsvalueNode != null)
                {
                    lastMeasurementsObject["valueNode"] = SourceExpressionConverter.ConvertToken(thingRolastMeasurementsvalueNode);
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
                    lastMeasurementsTimestampsObject["array"] = SourceExpressionConverter.ConvertToken(thingRolastMeasurementsarray);
                    lastMeasurementsTimestampsObjectpropCount++;
                }

                if (thingRolastMeasurementsbigDecimal != null)
                {
                    lastMeasurementsTimestampsObject["bigDecimal"] = SourceExpressionConverter.ConvertToken(thingRolastMeasurementsbigDecimal);
                    lastMeasurementsTimestampsObjectpropCount++;
                }

                if (thingRolastMeasurementsbigInteger != null)
                {
                    lastMeasurementsTimestampsObject["bigInteger"] = SourceExpressionConverter.ConvertToken(thingRolastMeasurementsbigInteger);
                    lastMeasurementsTimestampsObjectpropCount++;
                }

                if (thingRolastMeasurementsbinary != null)
                {
                    lastMeasurementsTimestampsObject["binary"] = SourceExpressionConverter.ConvertToken(thingRolastMeasurementsbinary);
                    lastMeasurementsTimestampsObjectpropCount++;
                }

                if (thingRolastMeasurementsboolean != null)
                {
                    lastMeasurementsTimestampsObject["boolean"] = SourceExpressionConverter.ConvertToken(thingRolastMeasurementsboolean);
                    lastMeasurementsTimestampsObjectpropCount++;
                }

                if (thingRolastMeasurementscontainerNode != null)
                {
                    lastMeasurementsTimestampsObject["containerNode"] = SourceExpressionConverter.ConvertToken(thingRolastMeasurementscontainerNode);
                    lastMeasurementsTimestampsObjectpropCount++;
                }

                if (thingRolastMeasurementsDouble != null)
                {
                    lastMeasurementsTimestampsObject["double"] = SourceExpressionConverter.ConvertToken(thingRolastMeasurementsDouble);
                    lastMeasurementsTimestampsObjectpropCount++;
                }

                if (thingRolastMeasurementsFloat != null)
                {
                    lastMeasurementsTimestampsObject["float"] = SourceExpressionConverter.ConvertToken(thingRolastMeasurementsFloat);
                    lastMeasurementsTimestampsObjectpropCount++;
                }

                if (thingRolastMeasurementsfloatingPointNumber != null)
                {
                    lastMeasurementsTimestampsObject["floatingPointNumber"] = SourceExpressionConverter.ConvertToken(thingRolastMeasurementsfloatingPointNumber);
                    lastMeasurementsTimestampsObjectpropCount++;
                }

                if (thingRolastMeasurementsInt != null)
                {
                    lastMeasurementsTimestampsObject["int"] = SourceExpressionConverter.ConvertToken(thingRolastMeasurementsInt);
                    lastMeasurementsTimestampsObjectpropCount++;
                }

                if (thingRolastMeasurementsintegralNumber != null)
                {
                    lastMeasurementsTimestampsObject["integralNumber"] = SourceExpressionConverter.ConvertToken(thingRolastMeasurementsintegralNumber);
                    lastMeasurementsTimestampsObjectpropCount++;
                }

                if (thingRolastMeasurementsLong != null)
                {
                    lastMeasurementsTimestampsObject["long"] = SourceExpressionConverter.ConvertToken(thingRolastMeasurementsLong);
                    lastMeasurementsTimestampsObjectpropCount++;
                }

                if (thingRolastMeasurementsmissingNode != null)
                {
                    lastMeasurementsTimestampsObject["missingNode"] = SourceExpressionConverter.ConvertToken(thingRolastMeasurementsmissingNode);
                    lastMeasurementsTimestampsObjectpropCount++;
                }

                if (thingRolastMeasurementsnodeType != null)
                {
                    lastMeasurementsTimestampsObject["nodeType"] = SourceExpressionConverter.Convert(thingRolastMeasurementsnodeType);
                    lastMeasurementsTimestampsObjectpropCount++;
                }

                if (thingRolastMeasurementsNull != null)
                {
                    lastMeasurementsTimestampsObject["null"] = SourceExpressionConverter.ConvertToken(thingRolastMeasurementsNull);
                    lastMeasurementsTimestampsObjectpropCount++;
                }

                if (thingRolastMeasurementsnumber != null)
                {
                    lastMeasurementsTimestampsObject["number"] = SourceExpressionConverter.ConvertToken(thingRolastMeasurementsnumber);
                    lastMeasurementsTimestampsObjectpropCount++;
                }

                if (thingRolastMeasurementsObject != null)
                {
                    lastMeasurementsTimestampsObject["object"] = SourceExpressionConverter.ConvertToken(thingRolastMeasurementsObject);
                    lastMeasurementsTimestampsObjectpropCount++;
                }

                if (thingRolastMeasurementspojo != null)
                {
                    lastMeasurementsTimestampsObject["pojo"] = SourceExpressionConverter.ConvertToken(thingRolastMeasurementspojo);
                    lastMeasurementsTimestampsObjectpropCount++;
                }

                if (thingRolastMeasurementsShort != null)
                {
                    lastMeasurementsTimestampsObject["short"] = SourceExpressionConverter.ConvertToken(thingRolastMeasurementsShort);
                    lastMeasurementsTimestampsObjectpropCount++;
                }

                if (thingRolastMeasurementstextual != null)
                {
                    lastMeasurementsTimestampsObject["textual"] = SourceExpressionConverter.ConvertToken(thingRolastMeasurementstextual);
                    lastMeasurementsTimestampsObjectpropCount++;
                }

                if (thingRolastMeasurementsvalueNode != null)
                {
                    lastMeasurementsTimestampsObject["valueNode"] = SourceExpressionConverter.ConvertToken(thingRolastMeasurementsvalueNode);
                    lastMeasurementsTimestampsObjectpropCount++;
                }

                if (lastMeasurementsTimestampsObjectpropCount > 0)
                {
                    thingRo["lastMeasurementsTimestamps"] = lastMeasurementsTimestampsObject;
                    thingRopropCount++;
                }

                if (thingRolastMessageDate != null)
                {
                    thingRo["lastMessageDate"] = SourceExpressionConverter.ConvertToken(thingRolastMessageDate);
                    thingRopropCount++;
                }

                if (thingRomessageActivityTimeoutPeriod != null)
                {
                    thingRo["messageActivityTimeoutPeriod"] = SourceExpressionConverter.ConvertToken(thingRomessageActivityTimeoutPeriod);
                    thingRopropCount++;
                }

                thingRopropCount++;
                thingRo["name"] = SourceExpressionConverter.ConvertToken(thingRoname);
                if (thingRonbAlerts != null)
                {
                    thingRo["nbAlerts"] = SourceExpressionConverter.ConvertToken(thingRonbAlerts);
                    thingRopropCount++;
                }

                var productObject = new JObject();
                var productObjectpropCount = 0;
                if (thingRoproductconnectivityTypes != null)
                {
                    productObject["connectivityTypes"] = SourceExpressionConverter.ConvertToken(thingRoproductconnectivityTypes);
                    productObjectpropCount++;
                }

                if (thingRoproductgenerateLinks != null)
                {
                    productObject["generateLinks"] = SourceExpressionConverter.ConvertToken(thingRoproductgenerateLinks);
                    productObjectpropCount++;
                }

                if (thingRoproductid != null)
                {
                    productObject["id"] = SourceExpressionConverter.ConvertToken(thingRoproductid);
                    productObjectpropCount++;
                }

                if (thingRoproductlink != null)
                {
                    productObject["link"] = SourceExpressionConverter.ConvertToken(thingRoproductlink);
                    productObjectpropCount++;
                }

                var manufacturerObject = new JObject();
                var manufacturerObjectpropCount = 0;
                if (thingRoproductmanufacturergenerateLinks != null)
                {
                    manufacturerObject["generateLinks"] = SourceExpressionConverter.ConvertToken(thingRoproductmanufacturergenerateLinks);
                    manufacturerObjectpropCount++;
                }

                if (thingRoproductmanufacturerid != null)
                {
                    manufacturerObject["id"] = SourceExpressionConverter.ConvertToken(thingRoproductmanufacturerid);
                    manufacturerObjectpropCount++;
                }

                if (thingRoproductmanufacturerlink != null)
                {
                    manufacturerObject["link"] = SourceExpressionConverter.ConvertToken(thingRoproductmanufacturerlink);
                    manufacturerObjectpropCount++;
                }

                if (thingRoproductmanufacturername != null)
                {
                    manufacturerObject["name"] = SourceExpressionConverter.ConvertToken(thingRoproductmanufacturername);
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
                    modelObject["color"] = SourceExpressionConverter.ConvertToken(thingRoproductmodelcolor);
                    modelObjectpropCount++;
                }

                if (thingRoproductmodelgenerateLinks != null)
                {
                    modelObject["generateLinks"] = SourceExpressionConverter.ConvertToken(thingRoproductmodelgenerateLinks);
                    modelObjectpropCount++;
                }

                if (thingRoproductmodelicon != null)
                {
                    modelObject["icon"] = SourceExpressionConverter.ConvertToken(thingRoproductmodelicon);
                    modelObjectpropCount++;
                }

                if (thingRoproductmodelid != null)
                {
                    modelObject["id"] = SourceExpressionConverter.ConvertToken(thingRoproductmodelid);
                    modelObjectpropCount++;
                }

                if (thingRoproductmodelisCustomModel != null)
                {
                    modelObject["isCustomModel"] = SourceExpressionConverter.ConvertToken(thingRoproductmodelisCustomModel);
                    modelObjectpropCount++;
                }

                var linkObject = new JObject();
                var linkObjectpropCount = 0;
                if (thingRoproductmodellinkabsolute != null)
                {
                    linkObject["absolute"] = SourceExpressionConverter.ConvertToken(thingRoproductmodellinkabsolute);
                    linkObjectpropCount++;
                }

                if (thingRoproductmodellinkauthority != null)
                {
                    linkObject["authority"] = SourceExpressionConverter.ConvertToken(thingRoproductmodellinkauthority);
                    linkObjectpropCount++;
                }

                if (thingRoproductmodellinkfragment != null)
                {
                    linkObject["fragment"] = SourceExpressionConverter.ConvertToken(thingRoproductmodellinkfragment);
                    linkObjectpropCount++;
                }

                if (thingRoproductmodellinkhost != null)
                {
                    linkObject["host"] = SourceExpressionConverter.ConvertToken(thingRoproductmodellinkhost);
                    linkObjectpropCount++;
                }

                if (thingRoproductmodellinkopaque != null)
                {
                    linkObject["opaque"] = SourceExpressionConverter.ConvertToken(thingRoproductmodellinkopaque);
                    linkObjectpropCount++;
                }

                if (thingRoproductmodellinkpath != null)
                {
                    linkObject["path"] = SourceExpressionConverter.ConvertToken(thingRoproductmodellinkpath);
                    linkObjectpropCount++;
                }

                if (thingRoproductmodellinkport != null)
                {
                    linkObject["port"] = SourceExpressionConverter.ConvertToken(thingRoproductmodellinkport);
                    linkObjectpropCount++;
                }

                if (thingRoproductmodellinkquery != null)
                {
                    linkObject["query"] = SourceExpressionConverter.ConvertToken(thingRoproductmodellinkquery);
                    linkObjectpropCount++;
                }

                if (thingRoproductmodellinkrawAuthority != null)
                {
                    linkObject["rawAuthority"] = SourceExpressionConverter.ConvertToken(thingRoproductmodellinkrawAuthority);
                    linkObjectpropCount++;
                }

                if (thingRoproductmodellinkrawFragment != null)
                {
                    linkObject["rawFragment"] = SourceExpressionConverter.ConvertToken(thingRoproductmodellinkrawFragment);
                    linkObjectpropCount++;
                }

                if (thingRoproductmodellinkrawPath != null)
                {
                    linkObject["rawPath"] = SourceExpressionConverter.ConvertToken(thingRoproductmodellinkrawPath);
                    linkObjectpropCount++;
                }

                if (thingRoproductmodellinkrawQuery != null)
                {
                    linkObject["rawQuery"] = SourceExpressionConverter.ConvertToken(thingRoproductmodellinkrawQuery);
                    linkObjectpropCount++;
                }

                if (thingRoproductmodellinkrawSchemeSpecificPart != null)
                {
                    linkObject["rawSchemeSpecificPart"] = SourceExpressionConverter.ConvertToken(thingRoproductmodellinkrawSchemeSpecificPart);
                    linkObjectpropCount++;
                }

                if (thingRoproductmodellinkrawUserInfo != null)
                {
                    linkObject["rawUserInfo"] = SourceExpressionConverter.ConvertToken(thingRoproductmodellinkrawUserInfo);
                    linkObjectpropCount++;
                }

                if (thingRoproductmodellinkscheme != null)
                {
                    linkObject["scheme"] = SourceExpressionConverter.ConvertToken(thingRoproductmodellinkscheme);
                    linkObjectpropCount++;
                }

                if (thingRoproductmodellinkschemeSpecificPart != null)
                {
                    linkObject["schemeSpecificPart"] = SourceExpressionConverter.ConvertToken(thingRoproductmodellinkschemeSpecificPart);
                    linkObjectpropCount++;
                }

                if (thingRoproductmodellinkuserInfo != null)
                {
                    linkObject["userInfo"] = SourceExpressionConverter.ConvertToken(thingRoproductmodellinkuserInfo);
                    linkObjectpropCount++;
                }

                if (linkObjectpropCount > 0)
                {
                    modelObject["link"] = linkObject;
                    modelObjectpropCount++;
                }

                if (thingRoproductmodelname != null)
                {
                    modelObject["name"] = SourceExpressionConverter.ConvertToken(thingRoproductmodelname);
                    modelObjectpropCount++;
                }

                if (modelObjectpropCount > 0)
                {
                    productObject["model"] = modelObject;
                    productObjectpropCount++;
                }

                if (thingRoproductname != null)
                {
                    productObject["name"] = SourceExpressionConverter.ConvertToken(thingRoproductname);
                    productObjectpropCount++;
                }

                if (thingRoproductreference != null)
                {
                    productObject["reference"] = SourceExpressionConverter.ConvertToken(thingRoproductreference);
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
                siteObject["address"] = SourceExpressionConverter.ConvertToken(thingRositeaddress);
                siteObjectpropCount++;
                siteObject["city"] = SourceExpressionConverter.ConvertToken(thingRositecity);
                if (thingRositeid != null)
                {
                    siteObject["id"] = SourceExpressionConverter.ConvertToken(thingRositeid);
                    siteObjectpropCount++;
                }

                if (thingRositelatitude != null)
                {
                    siteObject["latitude"] = SourceExpressionConverter.ConvertToken(thingRositelatitude);
                    siteObjectpropCount++;
                }

                if (thingRositelongitude != null)
                {
                    siteObject["longitude"] = SourceExpressionConverter.ConvertToken(thingRositelongitude);
                    siteObjectpropCount++;
                }

                siteObjectpropCount++;
                siteObject["name"] = SourceExpressionConverter.ConvertToken(thingRositename);
                siteObjectpropCount++;
                siteObject["postalCode"] = SourceExpressionConverter.ConvertToken(thingRositepostalCode);
                if (siteObjectpropCount > 0)
                {
                    thingRo["site"] = siteObject;
                    thingRopropCount++;
                }

                if (thingRosourceId != null)
                {
                    thingRo["sourceId"] = SourceExpressionConverter.ConvertToken(thingRosourceId);
                    thingRopropCount++;
                }

                if (thingRostatus != null)
                {
                    thingRo["status"] = SourceExpressionConverter.Convert(thingRostatus);
                    thingRopropCount++;
                }

                if (thingRotags != null)
                {
                    thingRo["tags"] = SourceExpressionConverter.ConvertToken(thingRotags);
                    thingRopropCount++;
                }

                if (thingRopropCount > 0)
                {
                    callPayload.Body = thingRo;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ThingRo>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<ModelRo> GetThingActiveModel([WorkflowExpression] Func<string> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/things/{0}/active_model", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ModelRo>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<PageCustomFieldRo> GetCustomField([WorkflowExpression] Func<string> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/things/{0}/custom_fields", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<PageCustomFieldRo>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<CustomFieldRo> CreateCustomField([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> customFieldRoid = null, [WorkflowExpression] Func<string> customFieldRoimageLink = null, [WorkflowExpression] Func<string> customFieldRolabel = null, [WorkflowExpression] Func<string> customFieldRoname = null, [WorkflowExpression] Func<customFieldRotypeInput> customFieldRotype = null, [WorkflowExpression] Func<string> customFieldRovalue = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/things/{0}/custom_fields", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var customFieldRo = new JObject();
                var customFieldRopropCount = 0;
                if (customFieldRoid != null)
                {
                    customFieldRo["id"] = SourceExpressionConverter.ConvertToken(customFieldRoid);
                    customFieldRopropCount++;
                }

                if (customFieldRoimageLink != null)
                {
                    customFieldRo["imageLink"] = SourceExpressionConverter.ConvertToken(customFieldRoimageLink);
                    customFieldRopropCount++;
                }

                if (customFieldRolabel != null)
                {
                    customFieldRo["label"] = SourceExpressionConverter.ConvertToken(customFieldRolabel);
                    customFieldRopropCount++;
                }

                if (customFieldRoname != null)
                {
                    customFieldRo["name"] = SourceExpressionConverter.ConvertToken(customFieldRoname);
                    customFieldRopropCount++;
                }

                if (customFieldRotype != null)
                {
                    customFieldRo["type"] = SourceExpressionConverter.Convert(customFieldRotype);
                    customFieldRopropCount++;
                }

                if (customFieldRovalue != null)
                {
                    customFieldRo["value"] = SourceExpressionConverter.ConvertToken(customFieldRovalue);
                    customFieldRopropCount++;
                }

                if (customFieldRopropCount > 0)
                {
                    callPayload.Body = customFieldRo;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CustomFieldRo>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<CustomFieldRo> UpdateCustomField([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> customFieldRoid = null, [WorkflowExpression] Func<string> customFieldRoimageLink = null, [WorkflowExpression] Func<string> customFieldRolabel = null, [WorkflowExpression] Func<string> customFieldRoname = null, [WorkflowExpression] Func<customFieldRotypeInput> customFieldRotype = null, [WorkflowExpression] Func<string> customFieldRovalue = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/things/{0}/custom_fields", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var customFieldRo = new JObject();
                var customFieldRopropCount = 0;
                if (customFieldRoid != null)
                {
                    customFieldRo["id"] = SourceExpressionConverter.ConvertToken(customFieldRoid);
                    customFieldRopropCount++;
                }

                if (customFieldRoimageLink != null)
                {
                    customFieldRo["imageLink"] = SourceExpressionConverter.ConvertToken(customFieldRoimageLink);
                    customFieldRopropCount++;
                }

                if (customFieldRolabel != null)
                {
                    customFieldRo["label"] = SourceExpressionConverter.ConvertToken(customFieldRolabel);
                    customFieldRopropCount++;
                }

                if (customFieldRoname != null)
                {
                    customFieldRo["name"] = SourceExpressionConverter.ConvertToken(customFieldRoname);
                    customFieldRopropCount++;
                }

                if (customFieldRotype != null)
                {
                    customFieldRo["type"] = SourceExpressionConverter.Convert(customFieldRotype);
                    customFieldRopropCount++;
                }

                if (customFieldRovalue != null)
                {
                    customFieldRo["value"] = SourceExpressionConverter.ConvertToken(customFieldRovalue);
                    customFieldRopropCount++;
                }

                if (customFieldRopropCount > 0)
                {
                    callPayload.Body = customFieldRo;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CustomFieldRo>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<ResponseEntity> DeleteCustomField([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> fieldId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/things/{0}/custom_fields/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(fieldId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ResponseEntity>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<ResponseEntity> GetCustomFieldImage([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> fieldId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/things/{0}/custom_fields/{1}/image", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(fieldId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ResponseEntity>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<ResponseEntity> GetThingImage([WorkflowExpression] Func<string> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/things/{0}/image", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ResponseEntity>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<MeasureTinyRo[]> GetLastMeasures([WorkflowExpression] Func<string> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/things/{0}/last_measurements", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<MeasureTinyRo[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<MessageTinyRo> GetLastMessage([WorkflowExpression] Func<string> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/things/{0}/last_message", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<MessageTinyRo>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<PageMeasureRo> GetThingMeasures([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<bool> detailed = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null, [WorkflowExpression] Func<string> sortValues = null, [WorkflowExpression] Func<string> sort = null, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<dirInput> dir = null, [WorkflowExpression] Func<string> orFilter = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/things/{0}/measures", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["detailed"] = Convert.ToString(false);
                if (detailed != null)
                    callPayload.Queries["detailed"] = SourceExpressionConverter.ConvertO(detailed);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (pageSize != null)
                    callPayload.Queries["pageSize"] = SourceExpressionConverter.ConvertO(pageSize);
                if (sortValues != null)
                    callPayload.Queries["sortValues"] = SourceExpressionConverter.ConvertO(sortValues);
                if (sort != null)
                    callPayload.Queries["sort"] = SourceExpressionConverter.ConvertO(sort);
                if (filter != null)
                    callPayload.Queries["filter"] = SourceExpressionConverter.ConvertO(filter);
                if (dir != null)
                    callPayload.Queries["dir"] = SourceExpressionConverter.Convert(dir);
                if (orFilter != null)
                    callPayload.Queries["orFilter"] = SourceExpressionConverter.ConvertO(orFilter);
                return callPayload;
            }

            return new ApiConnectionAction<PageMeasureRo>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<PageMessageRo> GetThingMessages([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null, [WorkflowExpression] Func<string> sortValues = null, [WorkflowExpression] Func<string> sort = null, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<dirInput> dir = null, [WorkflowExpression] Func<string> orFilter = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/things/{0}/messages", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (pageSize != null)
                    callPayload.Queries["pageSize"] = SourceExpressionConverter.ConvertO(pageSize);
                if (sortValues != null)
                    callPayload.Queries["sortValues"] = SourceExpressionConverter.ConvertO(sortValues);
                if (sort != null)
                    callPayload.Queries["sort"] = SourceExpressionConverter.ConvertO(sort);
                if (filter != null)
                    callPayload.Queries["filter"] = SourceExpressionConverter.ConvertO(filter);
                if (dir != null)
                    callPayload.Queries["dir"] = SourceExpressionConverter.Convert(dir);
                if (orFilter != null)
                    callPayload.Queries["orFilter"] = SourceExpressionConverter.ConvertO(orFilter);
                return callPayload;
            }

            return new ApiConnectionAction<PageMessageRo>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IWorkflowAction DeleteThingMessages([WorkflowExpression] Func<string> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/things/{0}/messages", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<MessageRo> CreateThingMessages([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> messageRobody, [WorkflowExpression] Func<string> messageRocreationDate, [WorkflowExpression] Func<string> messageRoerrorMessage, [WorkflowExpression] Func<double> messageRolatitude, [WorkflowExpression] Func<double> messageRolongitude, [WorkflowExpression] Func<string> messageRometadata, [WorkflowExpression] Func<int> messageRonumber, [WorkflowExpression] Func<messageRoprocessedInput> messageRoprocessed, [WorkflowExpression] Func<string> messageRothingname, [WorkflowExpression] Func<string> messageRotimestamp, [WorkflowExpression] Func<string> messageRotopic, [WorkflowExpression] Func<string> messageRoid = null, [WorkflowExpression] Func<bool> messageRolinkabsolute = null, [WorkflowExpression] Func<string> messageRolinkauthority = null, [WorkflowExpression] Func<string> messageRolinkfragment = null, [WorkflowExpression] Func<string> messageRolinkhost = null, [WorkflowExpression] Func<bool> messageRolinkopaque = null, [WorkflowExpression] Func<string> messageRolinkpath = null, [WorkflowExpression] Func<int> messageRolinkport = null, [WorkflowExpression] Func<string> messageRolinkquery = null, [WorkflowExpression] Func<string> messageRolinkrawAuthority = null, [WorkflowExpression] Func<string> messageRolinkrawFragment = null, [WorkflowExpression] Func<string> messageRolinkrawPath = null, [WorkflowExpression] Func<string> messageRolinkrawQuery = null, [WorkflowExpression] Func<string> messageRolinkrawSchemeSpecificPart = null, [WorkflowExpression] Func<string> messageRolinkrawUserInfo = null, [WorkflowExpression] Func<string> messageRolinkscheme = null, [WorkflowExpression] Func<string> messageRolinkschemeSpecificPart = null, [WorkflowExpression] Func<string> messageRolinkuserInfo = null, [WorkflowExpression] Func<bool> messageRomeasurementsarray = null, [WorkflowExpression] Func<bool> messageRomeasurementsbigDecimal = null, [WorkflowExpression] Func<bool> messageRomeasurementsbigInteger = null, [WorkflowExpression] Func<bool> messageRomeasurementsbinary = null, [WorkflowExpression] Func<bool> messageRomeasurementsboolean = null, [WorkflowExpression] Func<bool> messageRomeasurementscontainerNode = null, [WorkflowExpression] Func<bool> messageRomeasurementsDouble = null, [WorkflowExpression] Func<bool> messageRomeasurementsFloat = null, [WorkflowExpression] Func<bool> messageRomeasurementsfloatingPointNumber = null, [WorkflowExpression] Func<bool> messageRomeasurementsInt = null, [WorkflowExpression] Func<bool> messageRomeasurementsintegralNumber = null, [WorkflowExpression] Func<bool> messageRomeasurementsLong = null, [WorkflowExpression] Func<bool> messageRomeasurementsmissingNode = null, [WorkflowExpression] Func<messageRomeasurementsnodeTypeInput> messageRomeasurementsnodeType = null, [WorkflowExpression] Func<bool> messageRomeasurementsNull = null, [WorkflowExpression] Func<bool> messageRomeasurementsnumber = null, [WorkflowExpression] Func<bool> messageRomeasurementsObject = null, [WorkflowExpression] Func<bool> messageRomeasurementspojo = null, [WorkflowExpression] Func<bool> messageRomeasurementsShort = null, [WorkflowExpression] Func<bool> messageRomeasurementstextual = null, [WorkflowExpression] Func<bool> messageRomeasurementsvalueNode = null, [WorkflowExpression] Func<bool> messageRorawMeasurementsarray = null, [WorkflowExpression] Func<bool> messageRorawMeasurementsbigDecimal = null, [WorkflowExpression] Func<bool> messageRorawMeasurementsbigInteger = null, [WorkflowExpression] Func<bool> messageRorawMeasurementsbinary = null, [WorkflowExpression] Func<bool> messageRorawMeasurementsboolean = null, [WorkflowExpression] Func<bool> messageRorawMeasurementscontainerNode = null, [WorkflowExpression] Func<bool> messageRorawMeasurementsDouble = null, [WorkflowExpression] Func<bool> messageRorawMeasurementsFloat = null, [WorkflowExpression] Func<bool> messageRorawMeasurementsfloatingPointNumber = null, [WorkflowExpression] Func<bool> messageRorawMeasurementsInt = null, [WorkflowExpression] Func<bool> messageRorawMeasurementsintegralNumber = null, [WorkflowExpression] Func<bool> messageRorawMeasurementsLong = null, [WorkflowExpression] Func<bool> messageRorawMeasurementsmissingNode = null, [WorkflowExpression] Func<messageRorawMeasurementsnodeTypeInput> messageRorawMeasurementsnodeType = null, [WorkflowExpression] Func<bool> messageRorawMeasurementsNull = null, [WorkflowExpression] Func<bool> messageRorawMeasurementsnumber = null, [WorkflowExpression] Func<bool> messageRorawMeasurementsObject = null, [WorkflowExpression] Func<bool> messageRorawMeasurementspojo = null, [WorkflowExpression] Func<bool> messageRorawMeasurementsShort = null, [WorkflowExpression] Func<bool> messageRorawMeasurementstextual = null, [WorkflowExpression] Func<bool> messageRorawMeasurementsvalueNode = null, [WorkflowExpression] Func<string> messageRothingdisplayName = null, [WorkflowExpression] Func<string> messageRothingfixedName = null, [WorkflowExpression] Func<string> messageRothingid = null, [WorkflowExpression] Func<int> messageRothingnbAlerts = null, [WorkflowExpression] Func<ThingTagRo[]> messageRothingtags = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/things/{0}/messages", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var messageRo = new JObject();
                var messageRopropCount = 0;
                messageRopropCount++;
                messageRo["body"] = SourceExpressionConverter.ConvertToken(messageRobody);
                messageRopropCount++;
                messageRo["creationDate"] = SourceExpressionConverter.ConvertToken(messageRocreationDate);
                messageRopropCount++;
                messageRo["errorMessage"] = SourceExpressionConverter.ConvertToken(messageRoerrorMessage);
                if (messageRoid != null)
                {
                    messageRo["id"] = SourceExpressionConverter.ConvertToken(messageRoid);
                    messageRopropCount++;
                }

                messageRopropCount++;
                messageRo["latitude"] = SourceExpressionConverter.ConvertToken(messageRolatitude);
                var linkObject = new JObject();
                var linkObjectpropCount = 0;
                if (messageRolinkabsolute != null)
                {
                    linkObject["absolute"] = SourceExpressionConverter.ConvertToken(messageRolinkabsolute);
                    linkObjectpropCount++;
                }

                if (messageRolinkauthority != null)
                {
                    linkObject["authority"] = SourceExpressionConverter.ConvertToken(messageRolinkauthority);
                    linkObjectpropCount++;
                }

                if (messageRolinkfragment != null)
                {
                    linkObject["fragment"] = SourceExpressionConverter.ConvertToken(messageRolinkfragment);
                    linkObjectpropCount++;
                }

                if (messageRolinkhost != null)
                {
                    linkObject["host"] = SourceExpressionConverter.ConvertToken(messageRolinkhost);
                    linkObjectpropCount++;
                }

                if (messageRolinkopaque != null)
                {
                    linkObject["opaque"] = SourceExpressionConverter.ConvertToken(messageRolinkopaque);
                    linkObjectpropCount++;
                }

                if (messageRolinkpath != null)
                {
                    linkObject["path"] = SourceExpressionConverter.ConvertToken(messageRolinkpath);
                    linkObjectpropCount++;
                }

                if (messageRolinkport != null)
                {
                    linkObject["port"] = SourceExpressionConverter.ConvertToken(messageRolinkport);
                    linkObjectpropCount++;
                }

                if (messageRolinkquery != null)
                {
                    linkObject["query"] = SourceExpressionConverter.ConvertToken(messageRolinkquery);
                    linkObjectpropCount++;
                }

                if (messageRolinkrawAuthority != null)
                {
                    linkObject["rawAuthority"] = SourceExpressionConverter.ConvertToken(messageRolinkrawAuthority);
                    linkObjectpropCount++;
                }

                if (messageRolinkrawFragment != null)
                {
                    linkObject["rawFragment"] = SourceExpressionConverter.ConvertToken(messageRolinkrawFragment);
                    linkObjectpropCount++;
                }

                if (messageRolinkrawPath != null)
                {
                    linkObject["rawPath"] = SourceExpressionConverter.ConvertToken(messageRolinkrawPath);
                    linkObjectpropCount++;
                }

                if (messageRolinkrawQuery != null)
                {
                    linkObject["rawQuery"] = SourceExpressionConverter.ConvertToken(messageRolinkrawQuery);
                    linkObjectpropCount++;
                }

                if (messageRolinkrawSchemeSpecificPart != null)
                {
                    linkObject["rawSchemeSpecificPart"] = SourceExpressionConverter.ConvertToken(messageRolinkrawSchemeSpecificPart);
                    linkObjectpropCount++;
                }

                if (messageRolinkrawUserInfo != null)
                {
                    linkObject["rawUserInfo"] = SourceExpressionConverter.ConvertToken(messageRolinkrawUserInfo);
                    linkObjectpropCount++;
                }

                if (messageRolinkscheme != null)
                {
                    linkObject["scheme"] = SourceExpressionConverter.ConvertToken(messageRolinkscheme);
                    linkObjectpropCount++;
                }

                if (messageRolinkschemeSpecificPart != null)
                {
                    linkObject["schemeSpecificPart"] = SourceExpressionConverter.ConvertToken(messageRolinkschemeSpecificPart);
                    linkObjectpropCount++;
                }

                if (messageRolinkuserInfo != null)
                {
                    linkObject["userInfo"] = SourceExpressionConverter.ConvertToken(messageRolinkuserInfo);
                    linkObjectpropCount++;
                }

                if (linkObjectpropCount > 0)
                {
                    messageRo["link"] = linkObject;
                    messageRopropCount++;
                }

                messageRopropCount++;
                messageRo["longitude"] = SourceExpressionConverter.ConvertToken(messageRolongitude);
                var measurementsObject = new JObject();
                var measurementsObjectpropCount = 0;
                if (messageRomeasurementsarray != null)
                {
                    measurementsObject["array"] = SourceExpressionConverter.ConvertToken(messageRomeasurementsarray);
                    measurementsObjectpropCount++;
                }

                if (messageRomeasurementsbigDecimal != null)
                {
                    measurementsObject["bigDecimal"] = SourceExpressionConverter.ConvertToken(messageRomeasurementsbigDecimal);
                    measurementsObjectpropCount++;
                }

                if (messageRomeasurementsbigInteger != null)
                {
                    measurementsObject["bigInteger"] = SourceExpressionConverter.ConvertToken(messageRomeasurementsbigInteger);
                    measurementsObjectpropCount++;
                }

                if (messageRomeasurementsbinary != null)
                {
                    measurementsObject["binary"] = SourceExpressionConverter.ConvertToken(messageRomeasurementsbinary);
                    measurementsObjectpropCount++;
                }

                if (messageRomeasurementsboolean != null)
                {
                    measurementsObject["boolean"] = SourceExpressionConverter.ConvertToken(messageRomeasurementsboolean);
                    measurementsObjectpropCount++;
                }

                if (messageRomeasurementscontainerNode != null)
                {
                    measurementsObject["containerNode"] = SourceExpressionConverter.ConvertToken(messageRomeasurementscontainerNode);
                    measurementsObjectpropCount++;
                }

                if (messageRomeasurementsDouble != null)
                {
                    measurementsObject["double"] = SourceExpressionConverter.ConvertToken(messageRomeasurementsDouble);
                    measurementsObjectpropCount++;
                }

                if (messageRomeasurementsFloat != null)
                {
                    measurementsObject["float"] = SourceExpressionConverter.ConvertToken(messageRomeasurementsFloat);
                    measurementsObjectpropCount++;
                }

                if (messageRomeasurementsfloatingPointNumber != null)
                {
                    measurementsObject["floatingPointNumber"] = SourceExpressionConverter.ConvertToken(messageRomeasurementsfloatingPointNumber);
                    measurementsObjectpropCount++;
                }

                if (messageRomeasurementsInt != null)
                {
                    measurementsObject["int"] = SourceExpressionConverter.ConvertToken(messageRomeasurementsInt);
                    measurementsObjectpropCount++;
                }

                if (messageRomeasurementsintegralNumber != null)
                {
                    measurementsObject["integralNumber"] = SourceExpressionConverter.ConvertToken(messageRomeasurementsintegralNumber);
                    measurementsObjectpropCount++;
                }

                if (messageRomeasurementsLong != null)
                {
                    measurementsObject["long"] = SourceExpressionConverter.ConvertToken(messageRomeasurementsLong);
                    measurementsObjectpropCount++;
                }

                if (messageRomeasurementsmissingNode != null)
                {
                    measurementsObject["missingNode"] = SourceExpressionConverter.ConvertToken(messageRomeasurementsmissingNode);
                    measurementsObjectpropCount++;
                }

                if (messageRomeasurementsnodeType != null)
                {
                    measurementsObject["nodeType"] = SourceExpressionConverter.Convert(messageRomeasurementsnodeType);
                    measurementsObjectpropCount++;
                }

                if (messageRomeasurementsNull != null)
                {
                    measurementsObject["null"] = SourceExpressionConverter.ConvertToken(messageRomeasurementsNull);
                    measurementsObjectpropCount++;
                }

                if (messageRomeasurementsnumber != null)
                {
                    measurementsObject["number"] = SourceExpressionConverter.ConvertToken(messageRomeasurementsnumber);
                    measurementsObjectpropCount++;
                }

                if (messageRomeasurementsObject != null)
                {
                    measurementsObject["object"] = SourceExpressionConverter.ConvertToken(messageRomeasurementsObject);
                    measurementsObjectpropCount++;
                }

                if (messageRomeasurementspojo != null)
                {
                    measurementsObject["pojo"] = SourceExpressionConverter.ConvertToken(messageRomeasurementspojo);
                    measurementsObjectpropCount++;
                }

                if (messageRomeasurementsShort != null)
                {
                    measurementsObject["short"] = SourceExpressionConverter.ConvertToken(messageRomeasurementsShort);
                    measurementsObjectpropCount++;
                }

                if (messageRomeasurementstextual != null)
                {
                    measurementsObject["textual"] = SourceExpressionConverter.ConvertToken(messageRomeasurementstextual);
                    measurementsObjectpropCount++;
                }

                if (messageRomeasurementsvalueNode != null)
                {
                    measurementsObject["valueNode"] = SourceExpressionConverter.ConvertToken(messageRomeasurementsvalueNode);
                    measurementsObjectpropCount++;
                }

                if (measurementsObjectpropCount > 0)
                {
                    messageRo["measurements"] = measurementsObject;
                    messageRopropCount++;
                }

                messageRopropCount++;
                messageRo["metadata"] = SourceExpressionConverter.ConvertToken(messageRometadata);
                messageRopropCount++;
                messageRo["number"] = SourceExpressionConverter.ConvertToken(messageRonumber);
                messageRopropCount++;
                messageRo["processed"] = SourceExpressionConverter.Convert(messageRoprocessed);
                var rawMeasurementsObject = new JObject();
                var rawMeasurementsObjectpropCount = 0;
                if (messageRomeasurementsarray != null)
                {
                    rawMeasurementsObject["array"] = SourceExpressionConverter.ConvertToken(messageRomeasurementsarray);
                    rawMeasurementsObjectpropCount++;
                }

                if (messageRomeasurementsbigDecimal != null)
                {
                    rawMeasurementsObject["bigDecimal"] = SourceExpressionConverter.ConvertToken(messageRomeasurementsbigDecimal);
                    rawMeasurementsObjectpropCount++;
                }

                if (messageRomeasurementsbigInteger != null)
                {
                    rawMeasurementsObject["bigInteger"] = SourceExpressionConverter.ConvertToken(messageRomeasurementsbigInteger);
                    rawMeasurementsObjectpropCount++;
                }

                if (messageRomeasurementsbinary != null)
                {
                    rawMeasurementsObject["binary"] = SourceExpressionConverter.ConvertToken(messageRomeasurementsbinary);
                    rawMeasurementsObjectpropCount++;
                }

                if (messageRomeasurementsboolean != null)
                {
                    rawMeasurementsObject["boolean"] = SourceExpressionConverter.ConvertToken(messageRomeasurementsboolean);
                    rawMeasurementsObjectpropCount++;
                }

                if (messageRomeasurementscontainerNode != null)
                {
                    rawMeasurementsObject["containerNode"] = SourceExpressionConverter.ConvertToken(messageRomeasurementscontainerNode);
                    rawMeasurementsObjectpropCount++;
                }

                if (messageRomeasurementsDouble != null)
                {
                    rawMeasurementsObject["double"] = SourceExpressionConverter.ConvertToken(messageRomeasurementsDouble);
                    rawMeasurementsObjectpropCount++;
                }

                if (messageRomeasurementsFloat != null)
                {
                    rawMeasurementsObject["float"] = SourceExpressionConverter.ConvertToken(messageRomeasurementsFloat);
                    rawMeasurementsObjectpropCount++;
                }

                if (messageRomeasurementsfloatingPointNumber != null)
                {
                    rawMeasurementsObject["floatingPointNumber"] = SourceExpressionConverter.ConvertToken(messageRomeasurementsfloatingPointNumber);
                    rawMeasurementsObjectpropCount++;
                }

                if (messageRomeasurementsInt != null)
                {
                    rawMeasurementsObject["int"] = SourceExpressionConverter.ConvertToken(messageRomeasurementsInt);
                    rawMeasurementsObjectpropCount++;
                }

                if (messageRomeasurementsintegralNumber != null)
                {
                    rawMeasurementsObject["integralNumber"] = SourceExpressionConverter.ConvertToken(messageRomeasurementsintegralNumber);
                    rawMeasurementsObjectpropCount++;
                }

                if (messageRomeasurementsLong != null)
                {
                    rawMeasurementsObject["long"] = SourceExpressionConverter.ConvertToken(messageRomeasurementsLong);
                    rawMeasurementsObjectpropCount++;
                }

                if (messageRomeasurementsmissingNode != null)
                {
                    rawMeasurementsObject["missingNode"] = SourceExpressionConverter.ConvertToken(messageRomeasurementsmissingNode);
                    rawMeasurementsObjectpropCount++;
                }

                if (messageRomeasurementsnodeType != null)
                {
                    rawMeasurementsObject["nodeType"] = SourceExpressionConverter.Convert(messageRomeasurementsnodeType);
                    rawMeasurementsObjectpropCount++;
                }

                if (messageRomeasurementsNull != null)
                {
                    rawMeasurementsObject["null"] = SourceExpressionConverter.ConvertToken(messageRomeasurementsNull);
                    rawMeasurementsObjectpropCount++;
                }

                if (messageRomeasurementsnumber != null)
                {
                    rawMeasurementsObject["number"] = SourceExpressionConverter.ConvertToken(messageRomeasurementsnumber);
                    rawMeasurementsObjectpropCount++;
                }

                if (messageRomeasurementsObject != null)
                {
                    rawMeasurementsObject["object"] = SourceExpressionConverter.ConvertToken(messageRomeasurementsObject);
                    rawMeasurementsObjectpropCount++;
                }

                if (messageRomeasurementspojo != null)
                {
                    rawMeasurementsObject["pojo"] = SourceExpressionConverter.ConvertToken(messageRomeasurementspojo);
                    rawMeasurementsObjectpropCount++;
                }

                if (messageRomeasurementsShort != null)
                {
                    rawMeasurementsObject["short"] = SourceExpressionConverter.ConvertToken(messageRomeasurementsShort);
                    rawMeasurementsObjectpropCount++;
                }

                if (messageRomeasurementstextual != null)
                {
                    rawMeasurementsObject["textual"] = SourceExpressionConverter.ConvertToken(messageRomeasurementstextual);
                    rawMeasurementsObjectpropCount++;
                }

                if (messageRomeasurementsvalueNode != null)
                {
                    rawMeasurementsObject["valueNode"] = SourceExpressionConverter.ConvertToken(messageRomeasurementsvalueNode);
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
                    thingObject["displayName"] = SourceExpressionConverter.ConvertToken(messageRothingdisplayName);
                    thingObjectpropCount++;
                }

                if (messageRothingfixedName != null)
                {
                    thingObject["fixedName"] = SourceExpressionConverter.ConvertToken(messageRothingfixedName);
                    thingObjectpropCount++;
                }

                if (messageRothingid != null)
                {
                    thingObject["id"] = SourceExpressionConverter.ConvertToken(messageRothingid);
                    thingObjectpropCount++;
                }

                thingObjectpropCount++;
                thingObject["name"] = SourceExpressionConverter.ConvertToken(messageRothingname);
                if (messageRothingnbAlerts != null)
                {
                    thingObject["nbAlerts"] = SourceExpressionConverter.ConvertToken(messageRothingnbAlerts);
                    thingObjectpropCount++;
                }

                if (messageRothingtags != null)
                {
                    thingObject["tags"] = SourceExpressionConverter.ConvertToken(messageRothingtags);
                    thingObjectpropCount++;
                }

                if (thingObjectpropCount > 0)
                {
                    messageRo["thing"] = thingObject;
                    messageRopropCount++;
                }

                messageRopropCount++;
                messageRo["timestamp"] = SourceExpressionConverter.ConvertToken(messageRotimestamp);
                messageRopropCount++;
                messageRo["topic"] = SourceExpressionConverter.ConvertToken(messageRotopic);
                if (messageRopropCount > 0)
                {
                    callPayload.Body = messageRo;
                }
                return callPayload;
            }

            return new ApiConnectionAction<MessageRo>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<ModelRo> GetThingModel([WorkflowExpression] Func<string> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/things/{0}/model", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ModelRo>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<PageOperationRo> GetThingOperations([WorkflowExpression] Func<string> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/things/{0}/operations", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<PageOperationRo>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<ResponseEntity> ExecuteThingOperation([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> operationId, [WorkflowExpression] Func<bool> placeholdersValuesarray = null, [WorkflowExpression] Func<bool> placeholdersValuesbigDecimal = null, [WorkflowExpression] Func<bool> placeholdersValuesbigInteger = null, [WorkflowExpression] Func<bool> placeholdersValuesbinary = null, [WorkflowExpression] Func<bool> placeholdersValuesboolean = null, [WorkflowExpression] Func<bool> placeholdersValuescontainerNode = null, [WorkflowExpression] Func<bool> placeholdersValuesDouble = null, [WorkflowExpression] Func<bool> placeholdersValuesFloat = null, [WorkflowExpression] Func<bool> placeholdersValuesfloatingPointNumber = null, [WorkflowExpression] Func<bool> placeholdersValuesInt = null, [WorkflowExpression] Func<bool> placeholdersValuesintegralNumber = null, [WorkflowExpression] Func<bool> placeholdersValuesLong = null, [WorkflowExpression] Func<bool> placeholdersValuesmissingNode = null, [WorkflowExpression] Func<placeholdersValuesnodeTypeInput> placeholdersValuesnodeType = null, [WorkflowExpression] Func<bool> placeholdersValuesNull = null, [WorkflowExpression] Func<bool> placeholdersValuesnumber = null, [WorkflowExpression] Func<bool> placeholdersValuesObject = null, [WorkflowExpression] Func<bool> placeholdersValuespojo = null, [WorkflowExpression] Func<bool> placeholdersValuesShort = null, [WorkflowExpression] Func<bool> placeholdersValuestextual = null, [WorkflowExpression] Func<bool> placeholdersValuesvalueNode = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/things/{0}/operations/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(operationId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var placeholdersValues = new JObject();
                var placeholdersValuespropCount = 0;
                if (placeholdersValuesarray != null)
                {
                    placeholdersValues["array"] = SourceExpressionConverter.ConvertToken(placeholdersValuesarray);
                    placeholdersValuespropCount++;
                }

                if (placeholdersValuesbigDecimal != null)
                {
                    placeholdersValues["bigDecimal"] = SourceExpressionConverter.ConvertToken(placeholdersValuesbigDecimal);
                    placeholdersValuespropCount++;
                }

                if (placeholdersValuesbigInteger != null)
                {
                    placeholdersValues["bigInteger"] = SourceExpressionConverter.ConvertToken(placeholdersValuesbigInteger);
                    placeholdersValuespropCount++;
                }

                if (placeholdersValuesbinary != null)
                {
                    placeholdersValues["binary"] = SourceExpressionConverter.ConvertToken(placeholdersValuesbinary);
                    placeholdersValuespropCount++;
                }

                if (placeholdersValuesboolean != null)
                {
                    placeholdersValues["boolean"] = SourceExpressionConverter.ConvertToken(placeholdersValuesboolean);
                    placeholdersValuespropCount++;
                }

                if (placeholdersValuescontainerNode != null)
                {
                    placeholdersValues["containerNode"] = SourceExpressionConverter.ConvertToken(placeholdersValuescontainerNode);
                    placeholdersValuespropCount++;
                }

                if (placeholdersValuesDouble != null)
                {
                    placeholdersValues["double"] = SourceExpressionConverter.ConvertToken(placeholdersValuesDouble);
                    placeholdersValuespropCount++;
                }

                if (placeholdersValuesFloat != null)
                {
                    placeholdersValues["float"] = SourceExpressionConverter.ConvertToken(placeholdersValuesFloat);
                    placeholdersValuespropCount++;
                }

                if (placeholdersValuesfloatingPointNumber != null)
                {
                    placeholdersValues["floatingPointNumber"] = SourceExpressionConverter.ConvertToken(placeholdersValuesfloatingPointNumber);
                    placeholdersValuespropCount++;
                }

                if (placeholdersValuesInt != null)
                {
                    placeholdersValues["int"] = SourceExpressionConverter.ConvertToken(placeholdersValuesInt);
                    placeholdersValuespropCount++;
                }

                if (placeholdersValuesintegralNumber != null)
                {
                    placeholdersValues["integralNumber"] = SourceExpressionConverter.ConvertToken(placeholdersValuesintegralNumber);
                    placeholdersValuespropCount++;
                }

                if (placeholdersValuesLong != null)
                {
                    placeholdersValues["long"] = SourceExpressionConverter.ConvertToken(placeholdersValuesLong);
                    placeholdersValuespropCount++;
                }

                if (placeholdersValuesmissingNode != null)
                {
                    placeholdersValues["missingNode"] = SourceExpressionConverter.ConvertToken(placeholdersValuesmissingNode);
                    placeholdersValuespropCount++;
                }

                if (placeholdersValuesnodeType != null)
                {
                    placeholdersValues["nodeType"] = SourceExpressionConverter.Convert(placeholdersValuesnodeType);
                    placeholdersValuespropCount++;
                }

                if (placeholdersValuesNull != null)
                {
                    placeholdersValues["null"] = SourceExpressionConverter.ConvertToken(placeholdersValuesNull);
                    placeholdersValuespropCount++;
                }

                if (placeholdersValuesnumber != null)
                {
                    placeholdersValues["number"] = SourceExpressionConverter.ConvertToken(placeholdersValuesnumber);
                    placeholdersValuespropCount++;
                }

                if (placeholdersValuesObject != null)
                {
                    placeholdersValues["object"] = SourceExpressionConverter.ConvertToken(placeholdersValuesObject);
                    placeholdersValuespropCount++;
                }

                if (placeholdersValuespojo != null)
                {
                    placeholdersValues["pojo"] = SourceExpressionConverter.ConvertToken(placeholdersValuespojo);
                    placeholdersValuespropCount++;
                }

                if (placeholdersValuesShort != null)
                {
                    placeholdersValues["short"] = SourceExpressionConverter.ConvertToken(placeholdersValuesShort);
                    placeholdersValuespropCount++;
                }

                if (placeholdersValuestextual != null)
                {
                    placeholdersValues["textual"] = SourceExpressionConverter.ConvertToken(placeholdersValuestextual);
                    placeholdersValuespropCount++;
                }

                if (placeholdersValuesvalueNode != null)
                {
                    placeholdersValues["valueNode"] = SourceExpressionConverter.ConvertToken(placeholdersValuesvalueNode);
                    placeholdersValuespropCount++;
                }

                if (placeholdersValuespropCount > 0)
                {
                    callPayload.Body = placeholdersValues;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ResponseEntity>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<SingleThingRo> UpdateThingFixedPosition([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> thingRoname, [WorkflowExpression] Func<string> thingRositeaddress, [WorkflowExpression] Func<string> thingRositecity, [WorkflowExpression] Func<string> thingRositename, [WorkflowExpression] Func<string> thingRositepostalCode, [WorkflowExpression] Func<CustomFieldRo[]> thingRocustomFields = null, [WorkflowExpression] Func<string> thingRodescription = null, [WorkflowExpression] Func<string> thingRodisplayName = null, [WorkflowExpression] Func<bool> thingRodynamicGps = null, [WorkflowExpression] Func<double> thingRofixedLatitude = null, [WorkflowExpression] Func<double> thingRofixedLongitude = null, [WorkflowExpression] Func<string> thingRofixedName = null, [WorkflowExpression] Func<string> thingRoid = null, [WorkflowExpression] Func<int> thingRolastActivityDate = null, [WorkflowExpression] Func<double> thingRolastLatitude = null, [WorkflowExpression] Func<double> thingRolastLongitude = null, [WorkflowExpression] Func<bool> thingRolastMeasurementsarray = null, [WorkflowExpression] Func<bool> thingRolastMeasurementsbigDecimal = null, [WorkflowExpression] Func<bool> thingRolastMeasurementsbigInteger = null, [WorkflowExpression] Func<bool> thingRolastMeasurementsbinary = null, [WorkflowExpression] Func<bool> thingRolastMeasurementsboolean = null, [WorkflowExpression] Func<bool> thingRolastMeasurementscontainerNode = null, [WorkflowExpression] Func<bool> thingRolastMeasurementsDouble = null, [WorkflowExpression] Func<bool> thingRolastMeasurementsFloat = null, [WorkflowExpression] Func<bool> thingRolastMeasurementsfloatingPointNumber = null, [WorkflowExpression] Func<bool> thingRolastMeasurementsInt = null, [WorkflowExpression] Func<bool> thingRolastMeasurementsintegralNumber = null, [WorkflowExpression] Func<bool> thingRolastMeasurementsLong = null, [WorkflowExpression] Func<bool> thingRolastMeasurementsmissingNode = null, [WorkflowExpression] Func<thingRolastMeasurementsnodeTypeInput> thingRolastMeasurementsnodeType = null, [WorkflowExpression] Func<bool> thingRolastMeasurementsNull = null, [WorkflowExpression] Func<bool> thingRolastMeasurementsnumber = null, [WorkflowExpression] Func<bool> thingRolastMeasurementsObject = null, [WorkflowExpression] Func<bool> thingRolastMeasurementspojo = null, [WorkflowExpression] Func<bool> thingRolastMeasurementsShort = null, [WorkflowExpression] Func<bool> thingRolastMeasurementstextual = null, [WorkflowExpression] Func<bool> thingRolastMeasurementsvalueNode = null, [WorkflowExpression] Func<bool> thingRolastMeasurementsTimestampsarray = null, [WorkflowExpression] Func<bool> thingRolastMeasurementsTimestampsbigDecimal = null, [WorkflowExpression] Func<bool> thingRolastMeasurementsTimestampsbigInteger = null, [WorkflowExpression] Func<bool> thingRolastMeasurementsTimestampsbinary = null, [WorkflowExpression] Func<bool> thingRolastMeasurementsTimestampsboolean = null, [WorkflowExpression] Func<bool> thingRolastMeasurementsTimestampscontainerNode = null, [WorkflowExpression] Func<bool> thingRolastMeasurementsTimestampsDouble = null, [WorkflowExpression] Func<bool> thingRolastMeasurementsTimestampsFloat = null, [WorkflowExpression] Func<bool> thingRolastMeasurementsTimestampsfloatingPointNumber = null, [WorkflowExpression] Func<bool> thingRolastMeasurementsTimestampsInt = null, [WorkflowExpression] Func<bool> thingRolastMeasurementsTimestampsintegralNumber = null, [WorkflowExpression] Func<bool> thingRolastMeasurementsTimestampsLong = null, [WorkflowExpression] Func<bool> thingRolastMeasurementsTimestampsmissingNode = null, [WorkflowExpression] Func<thingRolastMeasurementsTimestampsnodeTypeInput> thingRolastMeasurementsTimestampsnodeType = null, [WorkflowExpression] Func<bool> thingRolastMeasurementsTimestampsNull = null, [WorkflowExpression] Func<bool> thingRolastMeasurementsTimestampsnumber = null, [WorkflowExpression] Func<bool> thingRolastMeasurementsTimestampsObject = null, [WorkflowExpression] Func<bool> thingRolastMeasurementsTimestampspojo = null, [WorkflowExpression] Func<bool> thingRolastMeasurementsTimestampsShort = null, [WorkflowExpression] Func<bool> thingRolastMeasurementsTimestampstextual = null, [WorkflowExpression] Func<bool> thingRolastMeasurementsTimestampsvalueNode = null, [WorkflowExpression] Func<int> thingRolastMessageDate = null, [WorkflowExpression] Func<int> thingRomessageActivityTimeoutPeriod = null, [WorkflowExpression] Func<int> thingRonbAlerts = null, [WorkflowExpression] Func<string> thingRositeid = null, [WorkflowExpression] Func<double> thingRositelatitude = null, [WorkflowExpression] Func<double> thingRositelongitude = null, [WorkflowExpression] Func<thingRostatusInput> thingRostatus = null, [WorkflowExpression] Func<ThingTagRo[]> thingRotags = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/things/{0}/positions", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var thingRo = new JObject();
                var thingRopropCount = 0;
                if (thingRocustomFields != null)
                {
                    thingRo["customFields"] = SourceExpressionConverter.ConvertToken(thingRocustomFields);
                    thingRopropCount++;
                }

                if (thingRodescription != null)
                {
                    thingRo["description"] = SourceExpressionConverter.ConvertToken(thingRodescription);
                    thingRopropCount++;
                }

                if (thingRodisplayName != null)
                {
                    thingRo["displayName"] = SourceExpressionConverter.ConvertToken(thingRodisplayName);
                    thingRopropCount++;
                }

                if (thingRodynamicGps != null)
                {
                    thingRo["dynamicGps"] = SourceExpressionConverter.ConvertToken(thingRodynamicGps);
                    thingRopropCount++;
                }

                if (thingRofixedLatitude != null)
                {
                    thingRo["fixedLatitude"] = SourceExpressionConverter.ConvertToken(thingRofixedLatitude);
                    thingRopropCount++;
                }

                if (thingRofixedLongitude != null)
                {
                    thingRo["fixedLongitude"] = SourceExpressionConverter.ConvertToken(thingRofixedLongitude);
                    thingRopropCount++;
                }

                if (thingRofixedName != null)
                {
                    thingRo["fixedName"] = SourceExpressionConverter.ConvertToken(thingRofixedName);
                    thingRopropCount++;
                }

                if (thingRoid != null)
                {
                    thingRo["id"] = SourceExpressionConverter.ConvertToken(thingRoid);
                    thingRopropCount++;
                }

                if (thingRolastActivityDate != null)
                {
                    thingRo["lastActivityDate"] = SourceExpressionConverter.ConvertToken(thingRolastActivityDate);
                    thingRopropCount++;
                }

                if (thingRolastLatitude != null)
                {
                    thingRo["lastLatitude"] = SourceExpressionConverter.ConvertToken(thingRolastLatitude);
                    thingRopropCount++;
                }

                if (thingRolastLongitude != null)
                {
                    thingRo["lastLongitude"] = SourceExpressionConverter.ConvertToken(thingRolastLongitude);
                    thingRopropCount++;
                }

                var lastMeasurementsObject = new JObject();
                var lastMeasurementsObjectpropCount = 0;
                if (thingRolastMeasurementsarray != null)
                {
                    lastMeasurementsObject["array"] = SourceExpressionConverter.ConvertToken(thingRolastMeasurementsarray);
                    lastMeasurementsObjectpropCount++;
                }

                if (thingRolastMeasurementsbigDecimal != null)
                {
                    lastMeasurementsObject["bigDecimal"] = SourceExpressionConverter.ConvertToken(thingRolastMeasurementsbigDecimal);
                    lastMeasurementsObjectpropCount++;
                }

                if (thingRolastMeasurementsbigInteger != null)
                {
                    lastMeasurementsObject["bigInteger"] = SourceExpressionConverter.ConvertToken(thingRolastMeasurementsbigInteger);
                    lastMeasurementsObjectpropCount++;
                }

                if (thingRolastMeasurementsbinary != null)
                {
                    lastMeasurementsObject["binary"] = SourceExpressionConverter.ConvertToken(thingRolastMeasurementsbinary);
                    lastMeasurementsObjectpropCount++;
                }

                if (thingRolastMeasurementsboolean != null)
                {
                    lastMeasurementsObject["boolean"] = SourceExpressionConverter.ConvertToken(thingRolastMeasurementsboolean);
                    lastMeasurementsObjectpropCount++;
                }

                if (thingRolastMeasurementscontainerNode != null)
                {
                    lastMeasurementsObject["containerNode"] = SourceExpressionConverter.ConvertToken(thingRolastMeasurementscontainerNode);
                    lastMeasurementsObjectpropCount++;
                }

                if (thingRolastMeasurementsDouble != null)
                {
                    lastMeasurementsObject["double"] = SourceExpressionConverter.ConvertToken(thingRolastMeasurementsDouble);
                    lastMeasurementsObjectpropCount++;
                }

                if (thingRolastMeasurementsFloat != null)
                {
                    lastMeasurementsObject["float"] = SourceExpressionConverter.ConvertToken(thingRolastMeasurementsFloat);
                    lastMeasurementsObjectpropCount++;
                }

                if (thingRolastMeasurementsfloatingPointNumber != null)
                {
                    lastMeasurementsObject["floatingPointNumber"] = SourceExpressionConverter.ConvertToken(thingRolastMeasurementsfloatingPointNumber);
                    lastMeasurementsObjectpropCount++;
                }

                if (thingRolastMeasurementsInt != null)
                {
                    lastMeasurementsObject["int"] = SourceExpressionConverter.ConvertToken(thingRolastMeasurementsInt);
                    lastMeasurementsObjectpropCount++;
                }

                if (thingRolastMeasurementsintegralNumber != null)
                {
                    lastMeasurementsObject["integralNumber"] = SourceExpressionConverter.ConvertToken(thingRolastMeasurementsintegralNumber);
                    lastMeasurementsObjectpropCount++;
                }

                if (thingRolastMeasurementsLong != null)
                {
                    lastMeasurementsObject["long"] = SourceExpressionConverter.ConvertToken(thingRolastMeasurementsLong);
                    lastMeasurementsObjectpropCount++;
                }

                if (thingRolastMeasurementsmissingNode != null)
                {
                    lastMeasurementsObject["missingNode"] = SourceExpressionConverter.ConvertToken(thingRolastMeasurementsmissingNode);
                    lastMeasurementsObjectpropCount++;
                }

                if (thingRolastMeasurementsnodeType != null)
                {
                    lastMeasurementsObject["nodeType"] = SourceExpressionConverter.Convert(thingRolastMeasurementsnodeType);
                    lastMeasurementsObjectpropCount++;
                }

                if (thingRolastMeasurementsNull != null)
                {
                    lastMeasurementsObject["null"] = SourceExpressionConverter.ConvertToken(thingRolastMeasurementsNull);
                    lastMeasurementsObjectpropCount++;
                }

                if (thingRolastMeasurementsnumber != null)
                {
                    lastMeasurementsObject["number"] = SourceExpressionConverter.ConvertToken(thingRolastMeasurementsnumber);
                    lastMeasurementsObjectpropCount++;
                }

                if (thingRolastMeasurementsObject != null)
                {
                    lastMeasurementsObject["object"] = SourceExpressionConverter.ConvertToken(thingRolastMeasurementsObject);
                    lastMeasurementsObjectpropCount++;
                }

                if (thingRolastMeasurementspojo != null)
                {
                    lastMeasurementsObject["pojo"] = SourceExpressionConverter.ConvertToken(thingRolastMeasurementspojo);
                    lastMeasurementsObjectpropCount++;
                }

                if (thingRolastMeasurementsShort != null)
                {
                    lastMeasurementsObject["short"] = SourceExpressionConverter.ConvertToken(thingRolastMeasurementsShort);
                    lastMeasurementsObjectpropCount++;
                }

                if (thingRolastMeasurementstextual != null)
                {
                    lastMeasurementsObject["textual"] = SourceExpressionConverter.ConvertToken(thingRolastMeasurementstextual);
                    lastMeasurementsObjectpropCount++;
                }

                if (thingRolastMeasurementsvalueNode != null)
                {
                    lastMeasurementsObject["valueNode"] = SourceExpressionConverter.ConvertToken(thingRolastMeasurementsvalueNode);
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
                    lastMeasurementsTimestampsObject["array"] = SourceExpressionConverter.ConvertToken(thingRolastMeasurementsarray);
                    lastMeasurementsTimestampsObjectpropCount++;
                }

                if (thingRolastMeasurementsbigDecimal != null)
                {
                    lastMeasurementsTimestampsObject["bigDecimal"] = SourceExpressionConverter.ConvertToken(thingRolastMeasurementsbigDecimal);
                    lastMeasurementsTimestampsObjectpropCount++;
                }

                if (thingRolastMeasurementsbigInteger != null)
                {
                    lastMeasurementsTimestampsObject["bigInteger"] = SourceExpressionConverter.ConvertToken(thingRolastMeasurementsbigInteger);
                    lastMeasurementsTimestampsObjectpropCount++;
                }

                if (thingRolastMeasurementsbinary != null)
                {
                    lastMeasurementsTimestampsObject["binary"] = SourceExpressionConverter.ConvertToken(thingRolastMeasurementsbinary);
                    lastMeasurementsTimestampsObjectpropCount++;
                }

                if (thingRolastMeasurementsboolean != null)
                {
                    lastMeasurementsTimestampsObject["boolean"] = SourceExpressionConverter.ConvertToken(thingRolastMeasurementsboolean);
                    lastMeasurementsTimestampsObjectpropCount++;
                }

                if (thingRolastMeasurementscontainerNode != null)
                {
                    lastMeasurementsTimestampsObject["containerNode"] = SourceExpressionConverter.ConvertToken(thingRolastMeasurementscontainerNode);
                    lastMeasurementsTimestampsObjectpropCount++;
                }

                if (thingRolastMeasurementsDouble != null)
                {
                    lastMeasurementsTimestampsObject["double"] = SourceExpressionConverter.ConvertToken(thingRolastMeasurementsDouble);
                    lastMeasurementsTimestampsObjectpropCount++;
                }

                if (thingRolastMeasurementsFloat != null)
                {
                    lastMeasurementsTimestampsObject["float"] = SourceExpressionConverter.ConvertToken(thingRolastMeasurementsFloat);
                    lastMeasurementsTimestampsObjectpropCount++;
                }

                if (thingRolastMeasurementsfloatingPointNumber != null)
                {
                    lastMeasurementsTimestampsObject["floatingPointNumber"] = SourceExpressionConverter.ConvertToken(thingRolastMeasurementsfloatingPointNumber);
                    lastMeasurementsTimestampsObjectpropCount++;
                }

                if (thingRolastMeasurementsInt != null)
                {
                    lastMeasurementsTimestampsObject["int"] = SourceExpressionConverter.ConvertToken(thingRolastMeasurementsInt);
                    lastMeasurementsTimestampsObjectpropCount++;
                }

                if (thingRolastMeasurementsintegralNumber != null)
                {
                    lastMeasurementsTimestampsObject["integralNumber"] = SourceExpressionConverter.ConvertToken(thingRolastMeasurementsintegralNumber);
                    lastMeasurementsTimestampsObjectpropCount++;
                }

                if (thingRolastMeasurementsLong != null)
                {
                    lastMeasurementsTimestampsObject["long"] = SourceExpressionConverter.ConvertToken(thingRolastMeasurementsLong);
                    lastMeasurementsTimestampsObjectpropCount++;
                }

                if (thingRolastMeasurementsmissingNode != null)
                {
                    lastMeasurementsTimestampsObject["missingNode"] = SourceExpressionConverter.ConvertToken(thingRolastMeasurementsmissingNode);
                    lastMeasurementsTimestampsObjectpropCount++;
                }

                if (thingRolastMeasurementsnodeType != null)
                {
                    lastMeasurementsTimestampsObject["nodeType"] = SourceExpressionConverter.Convert(thingRolastMeasurementsnodeType);
                    lastMeasurementsTimestampsObjectpropCount++;
                }

                if (thingRolastMeasurementsNull != null)
                {
                    lastMeasurementsTimestampsObject["null"] = SourceExpressionConverter.ConvertToken(thingRolastMeasurementsNull);
                    lastMeasurementsTimestampsObjectpropCount++;
                }

                if (thingRolastMeasurementsnumber != null)
                {
                    lastMeasurementsTimestampsObject["number"] = SourceExpressionConverter.ConvertToken(thingRolastMeasurementsnumber);
                    lastMeasurementsTimestampsObjectpropCount++;
                }

                if (thingRolastMeasurementsObject != null)
                {
                    lastMeasurementsTimestampsObject["object"] = SourceExpressionConverter.ConvertToken(thingRolastMeasurementsObject);
                    lastMeasurementsTimestampsObjectpropCount++;
                }

                if (thingRolastMeasurementspojo != null)
                {
                    lastMeasurementsTimestampsObject["pojo"] = SourceExpressionConverter.ConvertToken(thingRolastMeasurementspojo);
                    lastMeasurementsTimestampsObjectpropCount++;
                }

                if (thingRolastMeasurementsShort != null)
                {
                    lastMeasurementsTimestampsObject["short"] = SourceExpressionConverter.ConvertToken(thingRolastMeasurementsShort);
                    lastMeasurementsTimestampsObjectpropCount++;
                }

                if (thingRolastMeasurementstextual != null)
                {
                    lastMeasurementsTimestampsObject["textual"] = SourceExpressionConverter.ConvertToken(thingRolastMeasurementstextual);
                    lastMeasurementsTimestampsObjectpropCount++;
                }

                if (thingRolastMeasurementsvalueNode != null)
                {
                    lastMeasurementsTimestampsObject["valueNode"] = SourceExpressionConverter.ConvertToken(thingRolastMeasurementsvalueNode);
                    lastMeasurementsTimestampsObjectpropCount++;
                }

                if (lastMeasurementsTimestampsObjectpropCount > 0)
                {
                    thingRo["lastMeasurementsTimestamps"] = lastMeasurementsTimestampsObject;
                    thingRopropCount++;
                }

                if (thingRolastMessageDate != null)
                {
                    thingRo["lastMessageDate"] = SourceExpressionConverter.ConvertToken(thingRolastMessageDate);
                    thingRopropCount++;
                }

                if (thingRomessageActivityTimeoutPeriod != null)
                {
                    thingRo["messageActivityTimeoutPeriod"] = SourceExpressionConverter.ConvertToken(thingRomessageActivityTimeoutPeriod);
                    thingRopropCount++;
                }

                thingRopropCount++;
                thingRo["name"] = SourceExpressionConverter.ConvertToken(thingRoname);
                if (thingRonbAlerts != null)
                {
                    thingRo["nbAlerts"] = SourceExpressionConverter.ConvertToken(thingRonbAlerts);
                    thingRopropCount++;
                }

                var siteObject = new JObject();
                var siteObjectpropCount = 0;
                siteObjectpropCount++;
                siteObject["address"] = SourceExpressionConverter.ConvertToken(thingRositeaddress);
                siteObjectpropCount++;
                siteObject["city"] = SourceExpressionConverter.ConvertToken(thingRositecity);
                if (thingRositeid != null)
                {
                    siteObject["id"] = SourceExpressionConverter.ConvertToken(thingRositeid);
                    siteObjectpropCount++;
                }

                if (thingRositelatitude != null)
                {
                    siteObject["latitude"] = SourceExpressionConverter.ConvertToken(thingRositelatitude);
                    siteObjectpropCount++;
                }

                if (thingRositelongitude != null)
                {
                    siteObject["longitude"] = SourceExpressionConverter.ConvertToken(thingRositelongitude);
                    siteObjectpropCount++;
                }

                siteObjectpropCount++;
                siteObject["name"] = SourceExpressionConverter.ConvertToken(thingRositename);
                siteObjectpropCount++;
                siteObject["postalCode"] = SourceExpressionConverter.ConvertToken(thingRositepostalCode);
                if (siteObjectpropCount > 0)
                {
                    thingRo["site"] = siteObject;
                    thingRopropCount++;
                }

                if (thingRostatus != null)
                {
                    thingRo["status"] = SourceExpressionConverter.Convert(thingRostatus);
                    thingRopropCount++;
                }

                if (thingRotags != null)
                {
                    thingRo["tags"] = SourceExpressionConverter.ConvertToken(thingRotags);
                    thingRopropCount++;
                }

                if (thingRopropCount > 0)
                {
                    callPayload.Body = thingRo;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SingleThingRo>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<ProductRo> GetThingProduct([WorkflowExpression] Func<string> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/things/{0}/product", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ProductRo>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<SingleThingRo> DissociateThingProduct([WorkflowExpression] Func<string> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/things/{0}/product", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<SingleThingRo>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<SingleThingRo> AssociateThingProduct([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> productcertification = null, [WorkflowExpression] Func<productconnectivityTypesInputItem[]> productconnectivityTypes = null, [WorkflowExpression] Func<string> productdecoderid = null, [WorkflowExpression] Func<string> productdecoderlink = null, [WorkflowExpression] Func<bool> productdecodervisible = null, [WorkflowExpression] Func<string> productdescription = null, [WorkflowExpression] Func<string> productencoderid = null, [WorkflowExpression] Func<string> productencoderlink = null, [WorkflowExpression] Func<bool> productgenerateLinks = null, [WorkflowExpression] Func<bool> producthasImage = null, [WorkflowExpression] Func<string> productid = null, [WorkflowExpression] Func<string> productimageLink = null, [WorkflowExpression] Func<string> productinfoLink = null, [WorkflowExpression] Func<string> productlink = null, [WorkflowExpression] Func<bool> productmanufacturergenerateLinks = null, [WorkflowExpression] Func<string> productmanufacturerid = null, [WorkflowExpression] Func<string> productmanufacturerlink = null, [WorkflowExpression] Func<string> productmanufacturername = null, [WorkflowExpression] Func<string> productmanufacturerCategory = null, [WorkflowExpression] Func<string> productmodelcolor = null, [WorkflowExpression] Func<bool> productmodelgenerateLinks = null, [WorkflowExpression] Func<string> productmodelicon = null, [WorkflowExpression] Func<string> productmodelid = null, [WorkflowExpression] Func<bool> productmodelisCustomModel = null, [WorkflowExpression] Func<bool> productmodellinkabsolute = null, [WorkflowExpression] Func<string> productmodellinkauthority = null, [WorkflowExpression] Func<string> productmodellinkfragment = null, [WorkflowExpression] Func<string> productmodellinkhost = null, [WorkflowExpression] Func<bool> productmodellinkopaque = null, [WorkflowExpression] Func<string> productmodellinkpath = null, [WorkflowExpression] Func<int> productmodellinkport = null, [WorkflowExpression] Func<string> productmodellinkquery = null, [WorkflowExpression] Func<string> productmodellinkrawAuthority = null, [WorkflowExpression] Func<string> productmodellinkrawFragment = null, [WorkflowExpression] Func<string> productmodellinkrawPath = null, [WorkflowExpression] Func<string> productmodellinkrawQuery = null, [WorkflowExpression] Func<string> productmodellinkrawSchemeSpecificPart = null, [WorkflowExpression] Func<string> productmodellinkrawUserInfo = null, [WorkflowExpression] Func<string> productmodellinkscheme = null, [WorkflowExpression] Func<string> productmodellinkschemeSpecificPart = null, [WorkflowExpression] Func<string> productmodellinkuserInfo = null, [WorkflowExpression] Func<string> productmodelname = null, [WorkflowExpression] Func<bool> productmodelManufacturergenerateLinks = null, [WorkflowExpression] Func<string> productmodelManufacturerid = null, [WorkflowExpression] Func<string> productmodelManufacturerlink = null, [WorkflowExpression] Func<string> productmodelManufacturername = null, [WorkflowExpression] Func<string> productname = null, [WorkflowExpression] Func<bool> productreadOnly = null, [WorkflowExpression] Func<string> productreference = null, [WorkflowExpression] Func<TagRo[]> producttags = null, [WorkflowExpression] Func<ThingTinyRo[]> productthings = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/things/{0}/product", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var product = new JObject();
                var productpropCount = 0;
                if (productcertification != null)
                {
                    product["certification"] = SourceExpressionConverter.ConvertToken(productcertification);
                    productpropCount++;
                }

                if (productconnectivityTypes != null)
                {
                    product["connectivityTypes"] = SourceExpressionConverter.ConvertToken(productconnectivityTypes);
                    productpropCount++;
                }

                var decoderObject = new JObject();
                var decoderObjectpropCount = 0;
                if (productdecoderid != null)
                {
                    decoderObject["id"] = SourceExpressionConverter.ConvertToken(productdecoderid);
                    decoderObjectpropCount++;
                }

                if (productdecoderlink != null)
                {
                    decoderObject["link"] = SourceExpressionConverter.ConvertToken(productdecoderlink);
                    decoderObjectpropCount++;
                }

                if (productdecodervisible != null)
                {
                    decoderObject["visible"] = SourceExpressionConverter.ConvertToken(productdecodervisible);
                    decoderObjectpropCount++;
                }

                if (decoderObjectpropCount > 0)
                {
                    product["decoder"] = decoderObject;
                    productpropCount++;
                }

                if (productdescription != null)
                {
                    product["description"] = SourceExpressionConverter.ConvertToken(productdescription);
                    productpropCount++;
                }

                var encoderObject = new JObject();
                var encoderObjectpropCount = 0;
                if (productencoderid != null)
                {
                    encoderObject["id"] = SourceExpressionConverter.ConvertToken(productencoderid);
                    encoderObjectpropCount++;
                }

                if (productencoderlink != null)
                {
                    encoderObject["link"] = SourceExpressionConverter.ConvertToken(productencoderlink);
                    encoderObjectpropCount++;
                }

                if (encoderObjectpropCount > 0)
                {
                    product["encoder"] = encoderObject;
                    productpropCount++;
                }

                if (productgenerateLinks != null)
                {
                    product["generateLinks"] = SourceExpressionConverter.ConvertToken(productgenerateLinks);
                    productpropCount++;
                }

                if (producthasImage != null)
                {
                    product["hasImage"] = SourceExpressionConverter.ConvertToken(producthasImage);
                    productpropCount++;
                }

                if (productid != null)
                {
                    product["id"] = SourceExpressionConverter.ConvertToken(productid);
                    productpropCount++;
                }

                if (productimageLink != null)
                {
                    product["imageLink"] = SourceExpressionConverter.ConvertToken(productimageLink);
                    productpropCount++;
                }

                if (productinfoLink != null)
                {
                    product["infoLink"] = SourceExpressionConverter.ConvertToken(productinfoLink);
                    productpropCount++;
                }

                if (productlink != null)
                {
                    product["link"] = SourceExpressionConverter.ConvertToken(productlink);
                    productpropCount++;
                }

                var manufacturerObject = new JObject();
                var manufacturerObjectpropCount = 0;
                if (productmanufacturergenerateLinks != null)
                {
                    manufacturerObject["generateLinks"] = SourceExpressionConverter.ConvertToken(productmanufacturergenerateLinks);
                    manufacturerObjectpropCount++;
                }

                if (productmanufacturerid != null)
                {
                    manufacturerObject["id"] = SourceExpressionConverter.ConvertToken(productmanufacturerid);
                    manufacturerObjectpropCount++;
                }

                if (productmanufacturerlink != null)
                {
                    manufacturerObject["link"] = SourceExpressionConverter.ConvertToken(productmanufacturerlink);
                    manufacturerObjectpropCount++;
                }

                if (productmanufacturername != null)
                {
                    manufacturerObject["name"] = SourceExpressionConverter.ConvertToken(productmanufacturername);
                    manufacturerObjectpropCount++;
                }

                if (manufacturerObjectpropCount > 0)
                {
                    product["manufacturer"] = manufacturerObject;
                    productpropCount++;
                }

                if (productmanufacturerCategory != null)
                {
                    product["manufacturerCategory"] = SourceExpressionConverter.ConvertToken(productmanufacturerCategory);
                    productpropCount++;
                }

                var modelObject = new JObject();
                var modelObjectpropCount = 0;
                if (productmodelcolor != null)
                {
                    modelObject["color"] = SourceExpressionConverter.ConvertToken(productmodelcolor);
                    modelObjectpropCount++;
                }

                if (productmodelgenerateLinks != null)
                {
                    modelObject["generateLinks"] = SourceExpressionConverter.ConvertToken(productmodelgenerateLinks);
                    modelObjectpropCount++;
                }

                if (productmodelicon != null)
                {
                    modelObject["icon"] = SourceExpressionConverter.ConvertToken(productmodelicon);
                    modelObjectpropCount++;
                }

                if (productmodelid != null)
                {
                    modelObject["id"] = SourceExpressionConverter.ConvertToken(productmodelid);
                    modelObjectpropCount++;
                }

                if (productmodelisCustomModel != null)
                {
                    modelObject["isCustomModel"] = SourceExpressionConverter.ConvertToken(productmodelisCustomModel);
                    modelObjectpropCount++;
                }

                var linkObject = new JObject();
                var linkObjectpropCount = 0;
                if (productmodellinkabsolute != null)
                {
                    linkObject["absolute"] = SourceExpressionConverter.ConvertToken(productmodellinkabsolute);
                    linkObjectpropCount++;
                }

                if (productmodellinkauthority != null)
                {
                    linkObject["authority"] = SourceExpressionConverter.ConvertToken(productmodellinkauthority);
                    linkObjectpropCount++;
                }

                if (productmodellinkfragment != null)
                {
                    linkObject["fragment"] = SourceExpressionConverter.ConvertToken(productmodellinkfragment);
                    linkObjectpropCount++;
                }

                if (productmodellinkhost != null)
                {
                    linkObject["host"] = SourceExpressionConverter.ConvertToken(productmodellinkhost);
                    linkObjectpropCount++;
                }

                if (productmodellinkopaque != null)
                {
                    linkObject["opaque"] = SourceExpressionConverter.ConvertToken(productmodellinkopaque);
                    linkObjectpropCount++;
                }

                if (productmodellinkpath != null)
                {
                    linkObject["path"] = SourceExpressionConverter.ConvertToken(productmodellinkpath);
                    linkObjectpropCount++;
                }

                if (productmodellinkport != null)
                {
                    linkObject["port"] = SourceExpressionConverter.ConvertToken(productmodellinkport);
                    linkObjectpropCount++;
                }

                if (productmodellinkquery != null)
                {
                    linkObject["query"] = SourceExpressionConverter.ConvertToken(productmodellinkquery);
                    linkObjectpropCount++;
                }

                if (productmodellinkrawAuthority != null)
                {
                    linkObject["rawAuthority"] = SourceExpressionConverter.ConvertToken(productmodellinkrawAuthority);
                    linkObjectpropCount++;
                }

                if (productmodellinkrawFragment != null)
                {
                    linkObject["rawFragment"] = SourceExpressionConverter.ConvertToken(productmodellinkrawFragment);
                    linkObjectpropCount++;
                }

                if (productmodellinkrawPath != null)
                {
                    linkObject["rawPath"] = SourceExpressionConverter.ConvertToken(productmodellinkrawPath);
                    linkObjectpropCount++;
                }

                if (productmodellinkrawQuery != null)
                {
                    linkObject["rawQuery"] = SourceExpressionConverter.ConvertToken(productmodellinkrawQuery);
                    linkObjectpropCount++;
                }

                if (productmodellinkrawSchemeSpecificPart != null)
                {
                    linkObject["rawSchemeSpecificPart"] = SourceExpressionConverter.ConvertToken(productmodellinkrawSchemeSpecificPart);
                    linkObjectpropCount++;
                }

                if (productmodellinkrawUserInfo != null)
                {
                    linkObject["rawUserInfo"] = SourceExpressionConverter.ConvertToken(productmodellinkrawUserInfo);
                    linkObjectpropCount++;
                }

                if (productmodellinkscheme != null)
                {
                    linkObject["scheme"] = SourceExpressionConverter.ConvertToken(productmodellinkscheme);
                    linkObjectpropCount++;
                }

                if (productmodellinkschemeSpecificPart != null)
                {
                    linkObject["schemeSpecificPart"] = SourceExpressionConverter.ConvertToken(productmodellinkschemeSpecificPart);
                    linkObjectpropCount++;
                }

                if (productmodellinkuserInfo != null)
                {
                    linkObject["userInfo"] = SourceExpressionConverter.ConvertToken(productmodellinkuserInfo);
                    linkObjectpropCount++;
                }

                if (linkObjectpropCount > 0)
                {
                    modelObject["link"] = linkObject;
                    modelObjectpropCount++;
                }

                if (productmodelname != null)
                {
                    modelObject["name"] = SourceExpressionConverter.ConvertToken(productmodelname);
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
                    modelManufacturerObject["generateLinks"] = SourceExpressionConverter.ConvertToken(productmanufacturergenerateLinks);
                    modelManufacturerObjectpropCount++;
                }

                if (productmanufacturerid != null)
                {
                    modelManufacturerObject["id"] = SourceExpressionConverter.ConvertToken(productmanufacturerid);
                    modelManufacturerObjectpropCount++;
                }

                if (productmanufacturerlink != null)
                {
                    modelManufacturerObject["link"] = SourceExpressionConverter.ConvertToken(productmanufacturerlink);
                    modelManufacturerObjectpropCount++;
                }

                if (productmanufacturername != null)
                {
                    modelManufacturerObject["name"] = SourceExpressionConverter.ConvertToken(productmanufacturername);
                    modelManufacturerObjectpropCount++;
                }

                if (modelManufacturerObjectpropCount > 0)
                {
                    product["modelManufacturer"] = modelManufacturerObject;
                    productpropCount++;
                }

                if (productname != null)
                {
                    product["name"] = SourceExpressionConverter.ConvertToken(productname);
                    productpropCount++;
                }

                if (productreadOnly != null)
                {
                    product["readOnly"] = SourceExpressionConverter.ConvertToken(productreadOnly);
                    productpropCount++;
                }

                if (productreference != null)
                {
                    product["reference"] = SourceExpressionConverter.ConvertToken(productreference);
                    productpropCount++;
                }

                if (producttags != null)
                {
                    product["tags"] = SourceExpressionConverter.ConvertToken(producttags);
                    productpropCount++;
                }

                if (productthings != null)
                {
                    product["things"] = SourceExpressionConverter.ConvertToken(productthings);
                    productpropCount++;
                }

                if (productpropCount > 0)
                {
                    callPayload.Body = product;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SingleThingRo>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<PageFlowRo> GetFlowsRelatedToThing([WorkflowExpression] Func<string> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/things/{0}/related_flows", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<PageFlowRo>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<PageThingTagRo> GetThingTags([WorkflowExpression] Func<string> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/things/{0}/tags", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<PageThingTagRo>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<PageStatsMeasureRo> GetStatsAvg([WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null, [WorkflowExpression] Func<string> sortValues = null, [WorkflowExpression] Func<string> sort = null, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<dirInput> dir = null, [WorkflowExpression] Func<string> orFilter = null, [WorkflowExpression] Func<int> start = null, [WorkflowExpression] Func<int> end = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/stats/avg";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (pageSize != null)
                    callPayload.Queries["pageSize"] = SourceExpressionConverter.ConvertO(pageSize);
                if (sortValues != null)
                    callPayload.Queries["sortValues"] = SourceExpressionConverter.ConvertO(sortValues);
                if (sort != null)
                    callPayload.Queries["sort"] = SourceExpressionConverter.ConvertO(sort);
                if (filter != null)
                    callPayload.Queries["filter"] = SourceExpressionConverter.ConvertO(filter);
                if (dir != null)
                    callPayload.Queries["dir"] = SourceExpressionConverter.Convert(dir);
                if (orFilter != null)
                    callPayload.Queries["orFilter"] = SourceExpressionConverter.ConvertO(orFilter);
                if (start != null)
                    callPayload.Queries["start"] = SourceExpressionConverter.ConvertO(start);
                if (end != null)
                    callPayload.Queries["end"] = SourceExpressionConverter.ConvertO(end);
                return callPayload;
            }

            return new ApiConnectionAction<PageStatsMeasureRo>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<StatsCountRo> GetStatsCount([WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null, [WorkflowExpression] Func<string> sortValues = null, [WorkflowExpression] Func<string> sort = null, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<dirInput> dir = null, [WorkflowExpression] Func<string> orFilter = null, [WorkflowExpression] Func<int> start = null, [WorkflowExpression] Func<int> end = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/stats/count";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (pageSize != null)
                    callPayload.Queries["pageSize"] = SourceExpressionConverter.ConvertO(pageSize);
                if (sortValues != null)
                    callPayload.Queries["sortValues"] = SourceExpressionConverter.ConvertO(sortValues);
                if (sort != null)
                    callPayload.Queries["sort"] = SourceExpressionConverter.ConvertO(sort);
                if (filter != null)
                    callPayload.Queries["filter"] = SourceExpressionConverter.ConvertO(filter);
                if (dir != null)
                    callPayload.Queries["dir"] = SourceExpressionConverter.Convert(dir);
                if (orFilter != null)
                    callPayload.Queries["orFilter"] = SourceExpressionConverter.ConvertO(orFilter);
                if (start != null)
                    callPayload.Queries["start"] = SourceExpressionConverter.ConvertO(start);
                if (end != null)
                    callPayload.Queries["end"] = SourceExpressionConverter.ConvertO(end);
                return callPayload;
            }

            return new ApiConnectionAction<StatsCountRo>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<PageStatsMeasureRo> GetStatsLast([WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null, [WorkflowExpression] Func<string> sortValues = null, [WorkflowExpression] Func<string> sort = null, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<dirInput> dir = null, [WorkflowExpression] Func<string> orFilter = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/stats/last";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (pageSize != null)
                    callPayload.Queries["pageSize"] = SourceExpressionConverter.ConvertO(pageSize);
                if (sortValues != null)
                    callPayload.Queries["sortValues"] = SourceExpressionConverter.ConvertO(sortValues);
                if (sort != null)
                    callPayload.Queries["sort"] = SourceExpressionConverter.ConvertO(sort);
                if (filter != null)
                    callPayload.Queries["filter"] = SourceExpressionConverter.ConvertO(filter);
                if (dir != null)
                    callPayload.Queries["dir"] = SourceExpressionConverter.Convert(dir);
                if (orFilter != null)
                    callPayload.Queries["orFilter"] = SourceExpressionConverter.ConvertO(orFilter);
                return callPayload;
            }

            return new ApiConnectionAction<PageStatsMeasureRo>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<PageStatsMeasureRo> GetThingStatsLast([WorkflowExpression] Func<string> thingId, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null, [WorkflowExpression] Func<string> sortValues = null, [WorkflowExpression] Func<string> sort = null, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<dirInput> dir = null, [WorkflowExpression] Func<string> orFilter = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/stats/last/things/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(thingId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (pageSize != null)
                    callPayload.Queries["pageSize"] = SourceExpressionConverter.ConvertO(pageSize);
                if (sortValues != null)
                    callPayload.Queries["sortValues"] = SourceExpressionConverter.ConvertO(sortValues);
                if (sort != null)
                    callPayload.Queries["sort"] = SourceExpressionConverter.ConvertO(sort);
                if (filter != null)
                    callPayload.Queries["filter"] = SourceExpressionConverter.ConvertO(filter);
                if (dir != null)
                    callPayload.Queries["dir"] = SourceExpressionConverter.Convert(dir);
                if (orFilter != null)
                    callPayload.Queries["orFilter"] = SourceExpressionConverter.ConvertO(orFilter);
                return callPayload;
            }

            return new ApiConnectionAction<PageStatsMeasureRo>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<PageStatsMeasureRo> GetStatsMax([WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null, [WorkflowExpression] Func<string> sortValues = null, [WorkflowExpression] Func<string> sort = null, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<dirInput> dir = null, [WorkflowExpression] Func<string> orFilter = null, [WorkflowExpression] Func<int> start = null, [WorkflowExpression] Func<int> end = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/stats/max";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (pageSize != null)
                    callPayload.Queries["pageSize"] = SourceExpressionConverter.ConvertO(pageSize);
                if (sortValues != null)
                    callPayload.Queries["sortValues"] = SourceExpressionConverter.ConvertO(sortValues);
                if (sort != null)
                    callPayload.Queries["sort"] = SourceExpressionConverter.ConvertO(sort);
                if (filter != null)
                    callPayload.Queries["filter"] = SourceExpressionConverter.ConvertO(filter);
                if (dir != null)
                    callPayload.Queries["dir"] = SourceExpressionConverter.Convert(dir);
                if (orFilter != null)
                    callPayload.Queries["orFilter"] = SourceExpressionConverter.ConvertO(orFilter);
                if (start != null)
                    callPayload.Queries["start"] = SourceExpressionConverter.ConvertO(start);
                if (end != null)
                    callPayload.Queries["end"] = SourceExpressionConverter.ConvertO(end);
                return callPayload;
            }

            return new ApiConnectionAction<PageStatsMeasureRo>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<StatsGraphRo[]> GetStatsMeasurements([WorkflowExpression] Func<int> start, [WorkflowExpression] Func<int> end, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null, [WorkflowExpression] Func<string> sortValues = null, [WorkflowExpression] Func<string> sort = null, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<dirInput> dir = null, [WorkflowExpression] Func<string> orFilter = null, [WorkflowExpression] Func<int> time = null, [WorkflowExpression] Func<string> interval = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/stats/measurements";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (pageSize != null)
                    callPayload.Queries["pageSize"] = SourceExpressionConverter.ConvertO(pageSize);
                if (sortValues != null)
                    callPayload.Queries["sortValues"] = SourceExpressionConverter.ConvertO(sortValues);
                if (sort != null)
                    callPayload.Queries["sort"] = SourceExpressionConverter.ConvertO(sort);
                if (filter != null)
                    callPayload.Queries["filter"] = SourceExpressionConverter.ConvertO(filter);
                if (dir != null)
                    callPayload.Queries["dir"] = SourceExpressionConverter.Convert(dir);
                if (orFilter != null)
                    callPayload.Queries["orFilter"] = SourceExpressionConverter.ConvertO(orFilter);
                if (time != null)
                    callPayload.Queries["time"] = SourceExpressionConverter.ConvertO(time);
                if (interval != null)
                    callPayload.Queries["interval"] = SourceExpressionConverter.ConvertO(interval);
                callPayload.Queries["start"] = SourceExpressionConverter.ConvertO(start);
                callPayload.Queries["end"] = SourceExpressionConverter.ConvertO(end);
                return callPayload;
            }

            return new ApiConnectionAction<StatsGraphRo[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<PageStatsMeasureRo> GetStatsMin([WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null, [WorkflowExpression] Func<string> sortValues = null, [WorkflowExpression] Func<string> sort = null, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<dirInput> dir = null, [WorkflowExpression] Func<string> orFilter = null, [WorkflowExpression] Func<int> start = null, [WorkflowExpression] Func<int> end = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/stats/min";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (pageSize != null)
                    callPayload.Queries["pageSize"] = SourceExpressionConverter.ConvertO(pageSize);
                if (sortValues != null)
                    callPayload.Queries["sortValues"] = SourceExpressionConverter.ConvertO(sortValues);
                if (sort != null)
                    callPayload.Queries["sort"] = SourceExpressionConverter.ConvertO(sort);
                if (filter != null)
                    callPayload.Queries["filter"] = SourceExpressionConverter.ConvertO(filter);
                if (dir != null)
                    callPayload.Queries["dir"] = SourceExpressionConverter.Convert(dir);
                if (orFilter != null)
                    callPayload.Queries["orFilter"] = SourceExpressionConverter.ConvertO(orFilter);
                if (start != null)
                    callPayload.Queries["start"] = SourceExpressionConverter.ConvertO(start);
                if (end != null)
                    callPayload.Queries["end"] = SourceExpressionConverter.ConvertO(end);
                return callPayload;
            }

            return new ApiConnectionAction<PageStatsMeasureRo>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<StatsCountRo[]> GetStatsRepartition([WorkflowExpression] Func<string> attribute, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null, [WorkflowExpression] Func<string> sortValues = null, [WorkflowExpression] Func<string> sort = null, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<dirInput> dir = null, [WorkflowExpression] Func<string> orFilter = null, [WorkflowExpression] Func<int> start = null, [WorkflowExpression] Func<int> end = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/stats/repartition";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["attribute"] = SourceExpressionConverter.ConvertO(attribute);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (pageSize != null)
                    callPayload.Queries["pageSize"] = SourceExpressionConverter.ConvertO(pageSize);
                if (sortValues != null)
                    callPayload.Queries["sortValues"] = SourceExpressionConverter.ConvertO(sortValues);
                if (sort != null)
                    callPayload.Queries["sort"] = SourceExpressionConverter.ConvertO(sort);
                if (filter != null)
                    callPayload.Queries["filter"] = SourceExpressionConverter.ConvertO(filter);
                if (dir != null)
                    callPayload.Queries["dir"] = SourceExpressionConverter.Convert(dir);
                if (orFilter != null)
                    callPayload.Queries["orFilter"] = SourceExpressionConverter.ConvertO(orFilter);
                if (start != null)
                    callPayload.Queries["start"] = SourceExpressionConverter.ConvertO(start);
                if (end != null)
                    callPayload.Queries["end"] = SourceExpressionConverter.ConvertO(end);
                return callPayload;
            }

            return new ApiConnectionAction<StatsCountRo[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<StatsGraphRo[]> GetStatsSum([WorkflowExpression] Func<int> start, [WorkflowExpression] Func<int> end, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null, [WorkflowExpression] Func<string> sortValues = null, [WorkflowExpression] Func<string> sort = null, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<dirInput> dir = null, [WorkflowExpression] Func<string> orFilter = null, [WorkflowExpression] Func<int> time = null, [WorkflowExpression] Func<string> interval = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/stats/sum";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (pageSize != null)
                    callPayload.Queries["pageSize"] = SourceExpressionConverter.ConvertO(pageSize);
                if (sortValues != null)
                    callPayload.Queries["sortValues"] = SourceExpressionConverter.ConvertO(sortValues);
                if (sort != null)
                    callPayload.Queries["sort"] = SourceExpressionConverter.ConvertO(sort);
                if (filter != null)
                    callPayload.Queries["filter"] = SourceExpressionConverter.ConvertO(filter);
                if (dir != null)
                    callPayload.Queries["dir"] = SourceExpressionConverter.Convert(dir);
                if (orFilter != null)
                    callPayload.Queries["orFilter"] = SourceExpressionConverter.ConvertO(orFilter);
                if (time != null)
                    callPayload.Queries["time"] = SourceExpressionConverter.ConvertO(time);
                if (interval != null)
                    callPayload.Queries["interval"] = SourceExpressionConverter.ConvertO(interval);
                callPayload.Queries["start"] = SourceExpressionConverter.ConvertO(start);
                callPayload.Queries["end"] = SourceExpressionConverter.ConvertO(end);
                return callPayload;
            }

            return new ApiConnectionAction<StatsGraphRo[]>(BuildSourceInput);
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

    public enum AlertRoLevelType
    {
        INFO,
        WARNING,
        CRITICAL
    }

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

    public enum ConnectivityRoStatusType
    {
        INACTIVE,
        ONLINE,
        OFFLINE,
        ERROR,
        UNKNOWN
    }

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

    public enum DeviceRoStatusType
    {
        RUNNING,
        HALTED,
        ERROR,
        UNKNOWN
    }

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

    public enum thingRoconnectivitystatusInput
    {
        INACTIVE,
        ONLINE,
        OFFLINE,
        ERROR,
        UNKNOWN
    }

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

    public enum thingRodevicestatusInput
    {
        RUNNING,
        HALTED,
        ERROR,
        UNKNOWN
    }

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

    public enum customFieldRotypeInput
    {
        TEXT,
        TEXTEREA,
        FILE
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