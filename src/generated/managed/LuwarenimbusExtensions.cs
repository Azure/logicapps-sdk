//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Luwarenimbus
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class LuwarenimbusActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "luwarenimbus")]
        public IWorkflowAction UpdateTask(Expression<Func<string>> taskId, Expression<Func<string>> taskInformationcustomercustomerFirstName = null, Expression<Func<string>> taskInformationcustomercustomerLastName = null, Expression<Func<string>> taskInformationcustomercustomerDisplayName = null, Expression<Func<string>> taskInformationcustomercustomerCompany = null, Expression<Func<string>> taskInformationcustomercustomerJobTitle = null, Expression<Func<string>> taskInformationcustomercustomerDepartment = null, Expression<Func<string>> taskInformationcustomercustomerStreetAddress = null, Expression<Func<string>> taskInformationcustomercustomerPostcode = null, Expression<Func<string>> taskInformationcustomercustomerCity = null, Expression<Func<string>> taskInformationcustomercustomerState = null, Expression<Func<string>> taskInformationcustomercustomerCountry = null, Expression<Func<string>> taskInformationcustomercustomerPrimaryTelephoneNumber = null, Expression<Func<TelNumber[]>> taskInformationcustomertelephoneNumbers = null, Expression<Func<string>> taskInformationcustomercustomerUPN = null, Expression<Func<string>> taskInformationcustomercustomerIMAddress = null, Expression<Func<string>> taskInformationcustomercustomerEmail = null, Expression<Func<CustomField[]>> taskInformationcustomercustomFields = null, Expression<Func<CustomContextParameter[]>> taskInformationcustomContextParameters = null, Expression<Func<PreferredUser[]>> taskInformationpreferredUsers = null, Expression<Func<string>> serviceSessionId = null, Expression<Func<string>> userSessionId = null)
        {
            var apiCallPath = String.Format("/v1/tasks/{0}", ExpressionConverter.ConvertWithUrlEncoding(taskId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (serviceSessionId != null)
                callPayload.Queries["serviceSessionId"] = ExpressionConverter.Convert(serviceSessionId);
            if (userSessionId != null)
                callPayload.Queries["userSessionId"] = ExpressionConverter.Convert(userSessionId);
            var taskInformation = new JObject();
            var taskInformationpropCount = 0;
            var customerObject = new JObject();
            var customerObjectpropCount = 0;
            if (taskInformationcustomercustomerFirstName != null)
            {
                customerObject["firstName"] = ExpressionConverter.ConvertO(taskInformationcustomercustomerFirstName);
                customerObjectpropCount++;
            }

            if (taskInformationcustomercustomerLastName != null)
            {
                customerObject["lastName"] = ExpressionConverter.ConvertO(taskInformationcustomercustomerLastName);
                customerObjectpropCount++;
            }

            if (taskInformationcustomercustomerDisplayName != null)
            {
                customerObject["displayName"] = ExpressionConverter.ConvertO(taskInformationcustomercustomerDisplayName);
                customerObjectpropCount++;
            }

            if (taskInformationcustomercustomerCompany != null)
            {
                customerObject["company"] = ExpressionConverter.ConvertO(taskInformationcustomercustomerCompany);
                customerObjectpropCount++;
            }

            if (taskInformationcustomercustomerJobTitle != null)
            {
                customerObject["jobTitle"] = ExpressionConverter.ConvertO(taskInformationcustomercustomerJobTitle);
                customerObjectpropCount++;
            }

            if (taskInformationcustomercustomerDepartment != null)
            {
                customerObject["department"] = ExpressionConverter.ConvertO(taskInformationcustomercustomerDepartment);
                customerObjectpropCount++;
            }

            if (taskInformationcustomercustomerStreetAddress != null)
            {
                customerObject["streetAddress"] = ExpressionConverter.ConvertO(taskInformationcustomercustomerStreetAddress);
                customerObjectpropCount++;
            }

            if (taskInformationcustomercustomerPostcode != null)
            {
                customerObject["postCode"] = ExpressionConverter.ConvertO(taskInformationcustomercustomerPostcode);
                customerObjectpropCount++;
            }

            if (taskInformationcustomercustomerCity != null)
            {
                customerObject["city"] = ExpressionConverter.ConvertO(taskInformationcustomercustomerCity);
                customerObjectpropCount++;
            }

            if (taskInformationcustomercustomerState != null)
            {
                customerObject["state"] = ExpressionConverter.ConvertO(taskInformationcustomercustomerState);
                customerObjectpropCount++;
            }

            if (taskInformationcustomercustomerCountry != null)
            {
                customerObject["country"] = ExpressionConverter.ConvertO(taskInformationcustomercustomerCountry);
                customerObjectpropCount++;
            }

            if (taskInformationcustomercustomerPrimaryTelephoneNumber != null)
            {
                customerObject["primaryTelNumber"] = ExpressionConverter.ConvertO(taskInformationcustomercustomerPrimaryTelephoneNumber);
                customerObjectpropCount++;
            }

            if (taskInformationcustomertelephoneNumbers != null)
            {
                customerObject["telNumbers"] = ExpressionConverter.ConvertO(taskInformationcustomertelephoneNumbers);
                customerObjectpropCount++;
            }

            if (taskInformationcustomercustomerUPN != null)
            {
                customerObject["UPN"] = ExpressionConverter.ConvertO(taskInformationcustomercustomerUPN);
                customerObjectpropCount++;
            }

            if (taskInformationcustomercustomerIMAddress != null)
            {
                customerObject["imAddress"] = ExpressionConverter.ConvertO(taskInformationcustomercustomerIMAddress);
                customerObjectpropCount++;
            }

            if (taskInformationcustomercustomerEmail != null)
            {
                customerObject["email"] = ExpressionConverter.ConvertO(taskInformationcustomercustomerEmail);
                customerObjectpropCount++;
            }

            if (taskInformationcustomercustomFields != null)
            {
                customerObject["customFields"] = ExpressionConverter.ConvertO(taskInformationcustomercustomFields);
                customerObjectpropCount++;
            }

            if (customerObjectpropCount > 0)
            {
                taskInformation["customer"] = customerObject;
                taskInformationpropCount++;
            }

            if (taskInformationcustomContextParameters != null)
            {
                taskInformation["customContextParameters"] = ExpressionConverter.ConvertO(taskInformationcustomContextParameters);
                taskInformationpropCount++;
            }

            if (taskInformationpreferredUsers != null)
            {
                taskInformation["preferredUsers"] = ExpressionConverter.ConvertO(taskInformationpreferredUsers);
                taskInformationpropCount++;
            }

            if (taskInformationpropCount > 0)
            {
                callPayload.Body = taskInformation;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "luwarenimbus")]
        public IBodyWorkflowAction<OutboundCallWithWorkflowSchedulerEntryEventData> CreateOutboundCallWithWorkflowSchedulerEntry(Expression<Func<string>> schedulerEntrydestination, Expression<Func<string>> schedulerEntrydueDateTimeUTC, Expression<Func<string>> schedulerEntryserviceUPN, Expression<Func<string>> schedulerEntryreferenceID = null, Expression<Func<int>> schedulerEntrymaximumAttempts = null, Expression<Func<int>> schedulerEntryattemptTimeoutInSeconds = null, Expression<Func<CustomContextParameter[]>> schedulerEntrycustomContextParameters = null, Expression<Func<string>> schedulerEntrycustomercustomerFirstName = null, Expression<Func<string>> schedulerEntrycustomercustomerLastName = null, Expression<Func<string>> schedulerEntrycustomercustomerDisplayName = null, Expression<Func<string>> schedulerEntrycustomercustomerCompany = null, Expression<Func<string>> schedulerEntrycustomercustomerJobTitle = null, Expression<Func<string>> schedulerEntrycustomercustomerDepartment = null, Expression<Func<string>> schedulerEntrycustomercustomerStreetAddress = null, Expression<Func<string>> schedulerEntrycustomercustomerPostcode = null, Expression<Func<string>> schedulerEntrycustomercustomerCity = null, Expression<Func<string>> schedulerEntrycustomercustomerState = null, Expression<Func<string>> schedulerEntrycustomercustomerCountry = null, Expression<Func<string>> schedulerEntrycustomercustomerPrimaryTelephoneNumber = null, Expression<Func<TelNumber[]>> schedulerEntrycustomertelephoneNumbers = null, Expression<Func<string>> schedulerEntrycustomercustomerUPN = null, Expression<Func<string>> schedulerEntrycustomercustomerIMAddress = null, Expression<Func<string>> schedulerEntrycustomercustomerEmail = null, Expression<Func<CustomField[]>> schedulerEntrycustomercustomFields = null)
        {
            var apiCallPath = "/v1/outbound-call-with-workflow/scheduler-entries";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var schedulerEntry = new JObject();
            var schedulerEntrypropCount = 0;
            if (schedulerEntryreferenceID != null)
            {
                schedulerEntry["ReferenceId"] = ExpressionConverter.ConvertO(schedulerEntryreferenceID);
                schedulerEntrypropCount++;
            }

            schedulerEntrypropCount++;
            schedulerEntry["destination"] = ExpressionConverter.ConvertO(schedulerEntrydestination);
            schedulerEntrypropCount++;
            schedulerEntry["dueDateTimeUtc"] = ExpressionConverter.ConvertO(schedulerEntrydueDateTimeUTC);
            schedulerEntrypropCount++;
            schedulerEntry["serviceUpn"] = ExpressionConverter.ConvertO(schedulerEntryserviceUPN);
            if (schedulerEntrymaximumAttempts != null)
            {
                schedulerEntry["maxAttempts"] = ExpressionConverter.ConvertO(schedulerEntrymaximumAttempts);
                schedulerEntrypropCount++;
            }

            if (schedulerEntryattemptTimeoutInSeconds != null)
            {
                schedulerEntry["attemptTimeoutInSeconds"] = ExpressionConverter.ConvertO(schedulerEntryattemptTimeoutInSeconds);
                schedulerEntrypropCount++;
            }

            if (schedulerEntrycustomContextParameters != null)
            {
                schedulerEntry["customCallContextParameters"] = ExpressionConverter.ConvertO(schedulerEntrycustomContextParameters);
                schedulerEntrypropCount++;
            }

            var customerObject = new JObject();
            var customerObjectpropCount = 0;
            if (schedulerEntrycustomercustomerFirstName != null)
            {
                customerObject["firstName"] = ExpressionConverter.ConvertO(schedulerEntrycustomercustomerFirstName);
                customerObjectpropCount++;
            }

            if (schedulerEntrycustomercustomerLastName != null)
            {
                customerObject["lastName"] = ExpressionConverter.ConvertO(schedulerEntrycustomercustomerLastName);
                customerObjectpropCount++;
            }

            if (schedulerEntrycustomercustomerDisplayName != null)
            {
                customerObject["displayName"] = ExpressionConverter.ConvertO(schedulerEntrycustomercustomerDisplayName);
                customerObjectpropCount++;
            }

            if (schedulerEntrycustomercustomerCompany != null)
            {
                customerObject["company"] = ExpressionConverter.ConvertO(schedulerEntrycustomercustomerCompany);
                customerObjectpropCount++;
            }

            if (schedulerEntrycustomercustomerJobTitle != null)
            {
                customerObject["jobTitle"] = ExpressionConverter.ConvertO(schedulerEntrycustomercustomerJobTitle);
                customerObjectpropCount++;
            }

            if (schedulerEntrycustomercustomerDepartment != null)
            {
                customerObject["department"] = ExpressionConverter.ConvertO(schedulerEntrycustomercustomerDepartment);
                customerObjectpropCount++;
            }

            if (schedulerEntrycustomercustomerStreetAddress != null)
            {
                customerObject["streetAddress"] = ExpressionConverter.ConvertO(schedulerEntrycustomercustomerStreetAddress);
                customerObjectpropCount++;
            }

            if (schedulerEntrycustomercustomerPostcode != null)
            {
                customerObject["postCode"] = ExpressionConverter.ConvertO(schedulerEntrycustomercustomerPostcode);
                customerObjectpropCount++;
            }

            if (schedulerEntrycustomercustomerCity != null)
            {
                customerObject["city"] = ExpressionConverter.ConvertO(schedulerEntrycustomercustomerCity);
                customerObjectpropCount++;
            }

            if (schedulerEntrycustomercustomerState != null)
            {
                customerObject["state"] = ExpressionConverter.ConvertO(schedulerEntrycustomercustomerState);
                customerObjectpropCount++;
            }

            if (schedulerEntrycustomercustomerCountry != null)
            {
                customerObject["country"] = ExpressionConverter.ConvertO(schedulerEntrycustomercustomerCountry);
                customerObjectpropCount++;
            }

            if (schedulerEntrycustomercustomerPrimaryTelephoneNumber != null)
            {
                customerObject["primaryTelNumber"] = ExpressionConverter.ConvertO(schedulerEntrycustomercustomerPrimaryTelephoneNumber);
                customerObjectpropCount++;
            }

            if (schedulerEntrycustomertelephoneNumbers != null)
            {
                customerObject["telNumbers"] = ExpressionConverter.ConvertO(schedulerEntrycustomertelephoneNumbers);
                customerObjectpropCount++;
            }

            if (schedulerEntrycustomercustomerUPN != null)
            {
                customerObject["UPN"] = ExpressionConverter.ConvertO(schedulerEntrycustomercustomerUPN);
                customerObjectpropCount++;
            }

            if (schedulerEntrycustomercustomerIMAddress != null)
            {
                customerObject["imAddress"] = ExpressionConverter.ConvertO(schedulerEntrycustomercustomerIMAddress);
                customerObjectpropCount++;
            }

            if (schedulerEntrycustomercustomerEmail != null)
            {
                customerObject["email"] = ExpressionConverter.ConvertO(schedulerEntrycustomercustomerEmail);
                customerObjectpropCount++;
            }

            if (schedulerEntrycustomercustomFields != null)
            {
                customerObject["customFields"] = ExpressionConverter.ConvertO(schedulerEntrycustomercustomFields);
                customerObjectpropCount++;
            }

            if (customerObjectpropCount > 0)
            {
                schedulerEntry["customer"] = customerObject;
                schedulerEntrypropCount++;
            }

            if (schedulerEntrypropCount > 0)
            {
                callPayload.Body = schedulerEntry;
            }

            return new ApiConnectionAction<OutboundCallWithWorkflowSchedulerEntryEventData>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "luwarenimbus")]
        public IBodyWorkflowAction<OutboundCallWithWorkflowSchedulerEntryEventData> UpdateOutboundCallWithWorkflowSchedulerEntry(Expression<Func<string>> schedulerEntryID, Expression<Func<string>> schedulerEntrydestination, Expression<Func<string>> schedulerEntrydueDateTimeUTC, Expression<Func<string>> schedulerEntryserviceUPN, Expression<Func<string>> schedulerEntryreferenceID = null, Expression<Func<int>> schedulerEntrymaximumAttempts = null, Expression<Func<int>> schedulerEntryattemptTimeoutInSeconds = null, Expression<Func<CustomContextParameter[]>> schedulerEntrycustomContextParameters = null, Expression<Func<string>> schedulerEntrycustomercustomerFirstName = null, Expression<Func<string>> schedulerEntrycustomercustomerLastName = null, Expression<Func<string>> schedulerEntrycustomercustomerDisplayName = null, Expression<Func<string>> schedulerEntrycustomercustomerCompany = null, Expression<Func<string>> schedulerEntrycustomercustomerJobTitle = null, Expression<Func<string>> schedulerEntrycustomercustomerDepartment = null, Expression<Func<string>> schedulerEntrycustomercustomerStreetAddress = null, Expression<Func<string>> schedulerEntrycustomercustomerPostcode = null, Expression<Func<string>> schedulerEntrycustomercustomerCity = null, Expression<Func<string>> schedulerEntrycustomercustomerState = null, Expression<Func<string>> schedulerEntrycustomercustomerCountry = null, Expression<Func<string>> schedulerEntrycustomercustomerPrimaryTelephoneNumber = null, Expression<Func<TelNumber[]>> schedulerEntrycustomertelephoneNumbers = null, Expression<Func<string>> schedulerEntrycustomercustomerUPN = null, Expression<Func<string>> schedulerEntrycustomercustomerIMAddress = null, Expression<Func<string>> schedulerEntrycustomercustomerEmail = null, Expression<Func<CustomField[]>> schedulerEntrycustomercustomFields = null)
        {
            var apiCallPath = String.Format("/v1/outbound-call-with-workflow/scheduler-entries/{0}", ExpressionConverter.ConvertWithUrlEncoding(schedulerEntryID, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var schedulerEntry = new JObject();
            var schedulerEntrypropCount = 0;
            if (schedulerEntryreferenceID != null)
            {
                schedulerEntry["ReferenceId"] = ExpressionConverter.ConvertO(schedulerEntryreferenceID);
                schedulerEntrypropCount++;
            }

            schedulerEntrypropCount++;
            schedulerEntry["destination"] = ExpressionConverter.ConvertO(schedulerEntrydestination);
            schedulerEntrypropCount++;
            schedulerEntry["dueDateTimeUtc"] = ExpressionConverter.ConvertO(schedulerEntrydueDateTimeUTC);
            schedulerEntrypropCount++;
            schedulerEntry["serviceUpn"] = ExpressionConverter.ConvertO(schedulerEntryserviceUPN);
            if (schedulerEntrymaximumAttempts != null)
            {
                schedulerEntry["maxAttempts"] = ExpressionConverter.ConvertO(schedulerEntrymaximumAttempts);
                schedulerEntrypropCount++;
            }

            if (schedulerEntryattemptTimeoutInSeconds != null)
            {
                schedulerEntry["attemptTimeoutInSeconds"] = ExpressionConverter.ConvertO(schedulerEntryattemptTimeoutInSeconds);
                schedulerEntrypropCount++;
            }

            if (schedulerEntrycustomContextParameters != null)
            {
                schedulerEntry["customCallContextParameters"] = ExpressionConverter.ConvertO(schedulerEntrycustomContextParameters);
                schedulerEntrypropCount++;
            }

            var customerObject = new JObject();
            var customerObjectpropCount = 0;
            if (schedulerEntrycustomercustomerFirstName != null)
            {
                customerObject["firstName"] = ExpressionConverter.ConvertO(schedulerEntrycustomercustomerFirstName);
                customerObjectpropCount++;
            }

            if (schedulerEntrycustomercustomerLastName != null)
            {
                customerObject["lastName"] = ExpressionConverter.ConvertO(schedulerEntrycustomercustomerLastName);
                customerObjectpropCount++;
            }

            if (schedulerEntrycustomercustomerDisplayName != null)
            {
                customerObject["displayName"] = ExpressionConverter.ConvertO(schedulerEntrycustomercustomerDisplayName);
                customerObjectpropCount++;
            }

            if (schedulerEntrycustomercustomerCompany != null)
            {
                customerObject["company"] = ExpressionConverter.ConvertO(schedulerEntrycustomercustomerCompany);
                customerObjectpropCount++;
            }

            if (schedulerEntrycustomercustomerJobTitle != null)
            {
                customerObject["jobTitle"] = ExpressionConverter.ConvertO(schedulerEntrycustomercustomerJobTitle);
                customerObjectpropCount++;
            }

            if (schedulerEntrycustomercustomerDepartment != null)
            {
                customerObject["department"] = ExpressionConverter.ConvertO(schedulerEntrycustomercustomerDepartment);
                customerObjectpropCount++;
            }

            if (schedulerEntrycustomercustomerStreetAddress != null)
            {
                customerObject["streetAddress"] = ExpressionConverter.ConvertO(schedulerEntrycustomercustomerStreetAddress);
                customerObjectpropCount++;
            }

            if (schedulerEntrycustomercustomerPostcode != null)
            {
                customerObject["postCode"] = ExpressionConverter.ConvertO(schedulerEntrycustomercustomerPostcode);
                customerObjectpropCount++;
            }

            if (schedulerEntrycustomercustomerCity != null)
            {
                customerObject["city"] = ExpressionConverter.ConvertO(schedulerEntrycustomercustomerCity);
                customerObjectpropCount++;
            }

            if (schedulerEntrycustomercustomerState != null)
            {
                customerObject["state"] = ExpressionConverter.ConvertO(schedulerEntrycustomercustomerState);
                customerObjectpropCount++;
            }

            if (schedulerEntrycustomercustomerCountry != null)
            {
                customerObject["country"] = ExpressionConverter.ConvertO(schedulerEntrycustomercustomerCountry);
                customerObjectpropCount++;
            }

            if (schedulerEntrycustomercustomerPrimaryTelephoneNumber != null)
            {
                customerObject["primaryTelNumber"] = ExpressionConverter.ConvertO(schedulerEntrycustomercustomerPrimaryTelephoneNumber);
                customerObjectpropCount++;
            }

            if (schedulerEntrycustomertelephoneNumbers != null)
            {
                customerObject["telNumbers"] = ExpressionConverter.ConvertO(schedulerEntrycustomertelephoneNumbers);
                customerObjectpropCount++;
            }

            if (schedulerEntrycustomercustomerUPN != null)
            {
                customerObject["UPN"] = ExpressionConverter.ConvertO(schedulerEntrycustomercustomerUPN);
                customerObjectpropCount++;
            }

            if (schedulerEntrycustomercustomerIMAddress != null)
            {
                customerObject["imAddress"] = ExpressionConverter.ConvertO(schedulerEntrycustomercustomerIMAddress);
                customerObjectpropCount++;
            }

            if (schedulerEntrycustomercustomerEmail != null)
            {
                customerObject["email"] = ExpressionConverter.ConvertO(schedulerEntrycustomercustomerEmail);
                customerObjectpropCount++;
            }

            if (schedulerEntrycustomercustomFields != null)
            {
                customerObject["customFields"] = ExpressionConverter.ConvertO(schedulerEntrycustomercustomFields);
                customerObjectpropCount++;
            }

            if (customerObjectpropCount > 0)
            {
                schedulerEntry["customer"] = customerObject;
                schedulerEntrypropCount++;
            }

            if (schedulerEntrypropCount > 0)
            {
                callPayload.Body = schedulerEntry;
            }

            return new ApiConnectionAction<OutboundCallWithWorkflowSchedulerEntryEventData>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "luwarenimbus")]
        public IBodyWorkflowAction<SchedulerEntryEventData[]> GetSchedulerEntries(Expression<Func<string>> serviceUpn)
        {
            var apiCallPath = "/v1/scheduler-entries";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["serviceUpn"] = ExpressionConverter.Convert(serviceUpn);
            return new ApiConnectionAction<SchedulerEntryEventData[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "luwarenimbus")]
        public IBodyWorkflowAction<SchedulerEntryEventData> CreateSchedulerEntry(Expression<Func<string>> schedulerEntrydestination, Expression<Func<string>> schedulerEntrydueDateTimeUTC, Expression<Func<string>> schedulerEntryserviceUPN, Expression<Func<string>> schedulerEntryreferenceID = null, Expression<Func<string>> schedulerEntrydistributionPriority = null, Expression<Func<int>> schedulerEntrymaximumAttempts = null, Expression<Func<int>> schedulerEntryattemptTimeoutInSeconds = null, Expression<Func<int>> schedulerEntrymaximumQueueTimeInSeconds = null, Expression<Func<int>> schedulerEntryrONATimeoutInSeconds = null, Expression<Func<CustomContextParameter[]>> schedulerEntrycustomContextParameters = null, Expression<Func<string>> schedulerEntrycustomercustomerFirstName = null, Expression<Func<string>> schedulerEntrycustomercustomerLastName = null, Expression<Func<string>> schedulerEntrycustomercustomerDisplayName = null, Expression<Func<string>> schedulerEntrycustomercustomerCompany = null, Expression<Func<string>> schedulerEntrycustomercustomerJobTitle = null, Expression<Func<string>> schedulerEntrycustomercustomerDepartment = null, Expression<Func<string>> schedulerEntrycustomercustomerStreetAddress = null, Expression<Func<string>> schedulerEntrycustomercustomerPostcode = null, Expression<Func<string>> schedulerEntrycustomercustomerCity = null, Expression<Func<string>> schedulerEntrycustomercustomerState = null, Expression<Func<string>> schedulerEntrycustomercustomerCountry = null, Expression<Func<string>> schedulerEntrycustomercustomerPrimaryTelephoneNumber = null, Expression<Func<TelNumber[]>> schedulerEntrycustomertelephoneNumbers = null, Expression<Func<string>> schedulerEntrycustomercustomerUPN = null, Expression<Func<string>> schedulerEntrycustomercustomerIMAddress = null, Expression<Func<string>> schedulerEntrycustomercustomerEmail = null, Expression<Func<CustomField[]>> schedulerEntrycustomercustomFields = null)
        {
            var apiCallPath = "/v1/scheduler-entries";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var schedulerEntry = new JObject();
            var schedulerEntrypropCount = 0;
            if (schedulerEntryreferenceID != null)
            {
                schedulerEntry["ReferenceId"] = ExpressionConverter.ConvertO(schedulerEntryreferenceID);
                schedulerEntrypropCount++;
            }

            schedulerEntrypropCount++;
            schedulerEntry["destination"] = ExpressionConverter.ConvertO(schedulerEntrydestination);
            if (schedulerEntrydistributionPriority != null)
            {
                schedulerEntry["distributionPriority"] = ExpressionConverter.ConvertO(schedulerEntrydistributionPriority);
                schedulerEntrypropCount++;
            }

            schedulerEntrypropCount++;
            schedulerEntry["dueDateTimeUtc"] = ExpressionConverter.ConvertO(schedulerEntrydueDateTimeUTC);
            schedulerEntrypropCount++;
            schedulerEntry["serviceUpn"] = ExpressionConverter.ConvertO(schedulerEntryserviceUPN);
            if (schedulerEntrymaximumAttempts != null)
            {
                schedulerEntry["maxAttempts"] = ExpressionConverter.ConvertO(schedulerEntrymaximumAttempts);
                schedulerEntrypropCount++;
            }

            if (schedulerEntryattemptTimeoutInSeconds != null)
            {
                schedulerEntry["attemptTimeoutInSeconds"] = ExpressionConverter.ConvertO(schedulerEntryattemptTimeoutInSeconds);
                schedulerEntrypropCount++;
            }

            if (schedulerEntrymaximumQueueTimeInSeconds != null)
            {
                schedulerEntry["maxQueueTimeInSeconds"] = ExpressionConverter.ConvertO(schedulerEntrymaximumQueueTimeInSeconds);
                schedulerEntrypropCount++;
            }

            if (schedulerEntryrONATimeoutInSeconds != null)
            {
                schedulerEntry["ronaTimeoutInSeconds"] = ExpressionConverter.ConvertO(schedulerEntryrONATimeoutInSeconds);
                schedulerEntrypropCount++;
            }

            if (schedulerEntrycustomContextParameters != null)
            {
                schedulerEntry["customCallContextParameters"] = ExpressionConverter.ConvertO(schedulerEntrycustomContextParameters);
                schedulerEntrypropCount++;
            }

            var customerObject = new JObject();
            var customerObjectpropCount = 0;
            if (schedulerEntrycustomercustomerFirstName != null)
            {
                customerObject["firstName"] = ExpressionConverter.ConvertO(schedulerEntrycustomercustomerFirstName);
                customerObjectpropCount++;
            }

            if (schedulerEntrycustomercustomerLastName != null)
            {
                customerObject["lastName"] = ExpressionConverter.ConvertO(schedulerEntrycustomercustomerLastName);
                customerObjectpropCount++;
            }

            if (schedulerEntrycustomercustomerDisplayName != null)
            {
                customerObject["displayName"] = ExpressionConverter.ConvertO(schedulerEntrycustomercustomerDisplayName);
                customerObjectpropCount++;
            }

            if (schedulerEntrycustomercustomerCompany != null)
            {
                customerObject["company"] = ExpressionConverter.ConvertO(schedulerEntrycustomercustomerCompany);
                customerObjectpropCount++;
            }

            if (schedulerEntrycustomercustomerJobTitle != null)
            {
                customerObject["jobTitle"] = ExpressionConverter.ConvertO(schedulerEntrycustomercustomerJobTitle);
                customerObjectpropCount++;
            }

            if (schedulerEntrycustomercustomerDepartment != null)
            {
                customerObject["department"] = ExpressionConverter.ConvertO(schedulerEntrycustomercustomerDepartment);
                customerObjectpropCount++;
            }

            if (schedulerEntrycustomercustomerStreetAddress != null)
            {
                customerObject["streetAddress"] = ExpressionConverter.ConvertO(schedulerEntrycustomercustomerStreetAddress);
                customerObjectpropCount++;
            }

            if (schedulerEntrycustomercustomerPostcode != null)
            {
                customerObject["postCode"] = ExpressionConverter.ConvertO(schedulerEntrycustomercustomerPostcode);
                customerObjectpropCount++;
            }

            if (schedulerEntrycustomercustomerCity != null)
            {
                customerObject["city"] = ExpressionConverter.ConvertO(schedulerEntrycustomercustomerCity);
                customerObjectpropCount++;
            }

            if (schedulerEntrycustomercustomerState != null)
            {
                customerObject["state"] = ExpressionConverter.ConvertO(schedulerEntrycustomercustomerState);
                customerObjectpropCount++;
            }

            if (schedulerEntrycustomercustomerCountry != null)
            {
                customerObject["country"] = ExpressionConverter.ConvertO(schedulerEntrycustomercustomerCountry);
                customerObjectpropCount++;
            }

            if (schedulerEntrycustomercustomerPrimaryTelephoneNumber != null)
            {
                customerObject["primaryTelNumber"] = ExpressionConverter.ConvertO(schedulerEntrycustomercustomerPrimaryTelephoneNumber);
                customerObjectpropCount++;
            }

            if (schedulerEntrycustomertelephoneNumbers != null)
            {
                customerObject["telNumbers"] = ExpressionConverter.ConvertO(schedulerEntrycustomertelephoneNumbers);
                customerObjectpropCount++;
            }

            if (schedulerEntrycustomercustomerUPN != null)
            {
                customerObject["UPN"] = ExpressionConverter.ConvertO(schedulerEntrycustomercustomerUPN);
                customerObjectpropCount++;
            }

            if (schedulerEntrycustomercustomerIMAddress != null)
            {
                customerObject["imAddress"] = ExpressionConverter.ConvertO(schedulerEntrycustomercustomerIMAddress);
                customerObjectpropCount++;
            }

            if (schedulerEntrycustomercustomerEmail != null)
            {
                customerObject["email"] = ExpressionConverter.ConvertO(schedulerEntrycustomercustomerEmail);
                customerObjectpropCount++;
            }

            if (schedulerEntrycustomercustomFields != null)
            {
                customerObject["customFields"] = ExpressionConverter.ConvertO(schedulerEntrycustomercustomFields);
                customerObjectpropCount++;
            }

            if (customerObjectpropCount > 0)
            {
                schedulerEntry["customer"] = customerObject;
                schedulerEntrypropCount++;
            }

            if (schedulerEntrypropCount > 0)
            {
                callPayload.Body = schedulerEntry;
            }

            return new ApiConnectionAction<SchedulerEntryEventData>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "luwarenimbus")]
        public IWorkflowAction DeleteSchedulerEntry(Expression<Func<string>> schedulerEntryID)
        {
            var apiCallPath = String.Format("/v1/scheduler-entries/{0}", ExpressionConverter.ConvertWithUrlEncoding(schedulerEntryID, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "luwarenimbus")]
        public IBodyWorkflowAction<SchedulerEntryEventData> UpdateSchedulerEntry(Expression<Func<string>> schedulerEntryID, Expression<Func<string>> schedulerEntrydestination, Expression<Func<string>> schedulerEntrydueDateTimeUTC, Expression<Func<string>> schedulerEntryserviceUPN, Expression<Func<string>> schedulerEntryreferenceID = null, Expression<Func<string>> schedulerEntrydistributionPriority = null, Expression<Func<int>> schedulerEntrymaximumAttempts = null, Expression<Func<int>> schedulerEntryattemptTimeoutInSeconds = null, Expression<Func<int>> schedulerEntrymaximumQueueTimeInSeconds = null, Expression<Func<int>> schedulerEntryrONATimeoutInSeconds = null, Expression<Func<CustomContextParameter[]>> schedulerEntrycustomContextParameters = null, Expression<Func<string>> schedulerEntrycustomercustomerFirstName = null, Expression<Func<string>> schedulerEntrycustomercustomerLastName = null, Expression<Func<string>> schedulerEntrycustomercustomerDisplayName = null, Expression<Func<string>> schedulerEntrycustomercustomerCompany = null, Expression<Func<string>> schedulerEntrycustomercustomerJobTitle = null, Expression<Func<string>> schedulerEntrycustomercustomerDepartment = null, Expression<Func<string>> schedulerEntrycustomercustomerStreetAddress = null, Expression<Func<string>> schedulerEntrycustomercustomerPostcode = null, Expression<Func<string>> schedulerEntrycustomercustomerCity = null, Expression<Func<string>> schedulerEntrycustomercustomerState = null, Expression<Func<string>> schedulerEntrycustomercustomerCountry = null, Expression<Func<string>> schedulerEntrycustomercustomerPrimaryTelephoneNumber = null, Expression<Func<TelNumber[]>> schedulerEntrycustomertelephoneNumbers = null, Expression<Func<string>> schedulerEntrycustomercustomerUPN = null, Expression<Func<string>> schedulerEntrycustomercustomerIMAddress = null, Expression<Func<string>> schedulerEntrycustomercustomerEmail = null, Expression<Func<CustomField[]>> schedulerEntrycustomercustomFields = null)
        {
            var apiCallPath = String.Format("/v1/scheduler-entries/{0}", ExpressionConverter.ConvertWithUrlEncoding(schedulerEntryID, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var schedulerEntry = new JObject();
            var schedulerEntrypropCount = 0;
            if (schedulerEntryreferenceID != null)
            {
                schedulerEntry["ReferenceId"] = ExpressionConverter.ConvertO(schedulerEntryreferenceID);
                schedulerEntrypropCount++;
            }

            schedulerEntrypropCount++;
            schedulerEntry["destination"] = ExpressionConverter.ConvertO(schedulerEntrydestination);
            if (schedulerEntrydistributionPriority != null)
            {
                schedulerEntry["distributionPriority"] = ExpressionConverter.ConvertO(schedulerEntrydistributionPriority);
                schedulerEntrypropCount++;
            }

            schedulerEntrypropCount++;
            schedulerEntry["dueDateTimeUtc"] = ExpressionConverter.ConvertO(schedulerEntrydueDateTimeUTC);
            schedulerEntrypropCount++;
            schedulerEntry["serviceUpn"] = ExpressionConverter.ConvertO(schedulerEntryserviceUPN);
            if (schedulerEntrymaximumAttempts != null)
            {
                schedulerEntry["maxAttempts"] = ExpressionConverter.ConvertO(schedulerEntrymaximumAttempts);
                schedulerEntrypropCount++;
            }

            if (schedulerEntryattemptTimeoutInSeconds != null)
            {
                schedulerEntry["attemptTimeoutInSeconds"] = ExpressionConverter.ConvertO(schedulerEntryattemptTimeoutInSeconds);
                schedulerEntrypropCount++;
            }

            if (schedulerEntrymaximumQueueTimeInSeconds != null)
            {
                schedulerEntry["maxQueueTimeInSeconds"] = ExpressionConverter.ConvertO(schedulerEntrymaximumQueueTimeInSeconds);
                schedulerEntrypropCount++;
            }

            if (schedulerEntryrONATimeoutInSeconds != null)
            {
                schedulerEntry["ronaTimeoutInSeconds"] = ExpressionConverter.ConvertO(schedulerEntryrONATimeoutInSeconds);
                schedulerEntrypropCount++;
            }

            if (schedulerEntrycustomContextParameters != null)
            {
                schedulerEntry["customCallContextParameters"] = ExpressionConverter.ConvertO(schedulerEntrycustomContextParameters);
                schedulerEntrypropCount++;
            }

            var customerObject = new JObject();
            var customerObjectpropCount = 0;
            if (schedulerEntrycustomercustomerFirstName != null)
            {
                customerObject["firstName"] = ExpressionConverter.ConvertO(schedulerEntrycustomercustomerFirstName);
                customerObjectpropCount++;
            }

            if (schedulerEntrycustomercustomerLastName != null)
            {
                customerObject["lastName"] = ExpressionConverter.ConvertO(schedulerEntrycustomercustomerLastName);
                customerObjectpropCount++;
            }

            if (schedulerEntrycustomercustomerDisplayName != null)
            {
                customerObject["displayName"] = ExpressionConverter.ConvertO(schedulerEntrycustomercustomerDisplayName);
                customerObjectpropCount++;
            }

            if (schedulerEntrycustomercustomerCompany != null)
            {
                customerObject["company"] = ExpressionConverter.ConvertO(schedulerEntrycustomercustomerCompany);
                customerObjectpropCount++;
            }

            if (schedulerEntrycustomercustomerJobTitle != null)
            {
                customerObject["jobTitle"] = ExpressionConverter.ConvertO(schedulerEntrycustomercustomerJobTitle);
                customerObjectpropCount++;
            }

            if (schedulerEntrycustomercustomerDepartment != null)
            {
                customerObject["department"] = ExpressionConverter.ConvertO(schedulerEntrycustomercustomerDepartment);
                customerObjectpropCount++;
            }

            if (schedulerEntrycustomercustomerStreetAddress != null)
            {
                customerObject["streetAddress"] = ExpressionConverter.ConvertO(schedulerEntrycustomercustomerStreetAddress);
                customerObjectpropCount++;
            }

            if (schedulerEntrycustomercustomerPostcode != null)
            {
                customerObject["postCode"] = ExpressionConverter.ConvertO(schedulerEntrycustomercustomerPostcode);
                customerObjectpropCount++;
            }

            if (schedulerEntrycustomercustomerCity != null)
            {
                customerObject["city"] = ExpressionConverter.ConvertO(schedulerEntrycustomercustomerCity);
                customerObjectpropCount++;
            }

            if (schedulerEntrycustomercustomerState != null)
            {
                customerObject["state"] = ExpressionConverter.ConvertO(schedulerEntrycustomercustomerState);
                customerObjectpropCount++;
            }

            if (schedulerEntrycustomercustomerCountry != null)
            {
                customerObject["country"] = ExpressionConverter.ConvertO(schedulerEntrycustomercustomerCountry);
                customerObjectpropCount++;
            }

            if (schedulerEntrycustomercustomerPrimaryTelephoneNumber != null)
            {
                customerObject["primaryTelNumber"] = ExpressionConverter.ConvertO(schedulerEntrycustomercustomerPrimaryTelephoneNumber);
                customerObjectpropCount++;
            }

            if (schedulerEntrycustomertelephoneNumbers != null)
            {
                customerObject["telNumbers"] = ExpressionConverter.ConvertO(schedulerEntrycustomertelephoneNumbers);
                customerObjectpropCount++;
            }

            if (schedulerEntrycustomercustomerUPN != null)
            {
                customerObject["UPN"] = ExpressionConverter.ConvertO(schedulerEntrycustomercustomerUPN);
                customerObjectpropCount++;
            }

            if (schedulerEntrycustomercustomerIMAddress != null)
            {
                customerObject["imAddress"] = ExpressionConverter.ConvertO(schedulerEntrycustomercustomerIMAddress);
                customerObjectpropCount++;
            }

            if (schedulerEntrycustomercustomerEmail != null)
            {
                customerObject["email"] = ExpressionConverter.ConvertO(schedulerEntrycustomercustomerEmail);
                customerObjectpropCount++;
            }

            if (schedulerEntrycustomercustomFields != null)
            {
                customerObject["customFields"] = ExpressionConverter.ConvertO(schedulerEntrycustomercustomFields);
                customerObjectpropCount++;
            }

            if (customerObjectpropCount > 0)
            {
                schedulerEntry["customer"] = customerObject;
                schedulerEntrypropCount++;
            }

            if (schedulerEntrypropCount > 0)
            {
                callPayload.Body = schedulerEntry;
            }

            return new ApiConnectionAction<SchedulerEntryEventData>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "luwarenimbus")]
        public IBodyWorkflowAction<JToken> GetVirtualUserAssistantData(Expression<Func<string>> serviceSessionId, Expression<Func<string>> dataType, Expression<Func<string>> userSessionId = null)
        {
            var apiCallPath = String.Format("/v1/virtual-assistant/{0}/transcriptionData/{1}", ExpressionConverter.ConvertWithUrlEncoding(serviceSessionId, 1), ExpressionConverter.ConvertWithUrlEncoding(dataType, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (userSessionId != null)
                callPayload.Queries["userSessionId"] = ExpressionConverter.Convert(userSessionId);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "luwarenimbus")]
        public IBodyWorkflowAction<ExternalTaskWriteResult> AddExternalTask(Expression<Func<string>> externalTaskserviceUPN, Expression<Func<string>> externalTaskcustomerIdentifier = null, Expression<Func<string>> externalTaskcustomercustomerFirstName = null, Expression<Func<string>> externalTaskcustomercustomerLastName = null, Expression<Func<string>> externalTaskcustomercustomerDisplayName = null, Expression<Func<string>> externalTaskcustomercustomerCompany = null, Expression<Func<string>> externalTaskcustomercustomerJobTitle = null, Expression<Func<string>> externalTaskcustomercustomerDepartment = null, Expression<Func<string>> externalTaskcustomercustomerStreetAddress = null, Expression<Func<string>> externalTaskcustomercustomerPostcode = null, Expression<Func<string>> externalTaskcustomercustomerCity = null, Expression<Func<string>> externalTaskcustomercustomerState = null, Expression<Func<string>> externalTaskcustomercustomerCountry = null, Expression<Func<string>> externalTaskcustomercustomerPrimaryTelephoneNumber = null, Expression<Func<TelNumber[]>> externalTaskcustomertelephoneNumbers = null, Expression<Func<string>> externalTaskcustomercustomerUPN = null, Expression<Func<string>> externalTaskcustomercustomerIMAddress = null, Expression<Func<string>> externalTaskcustomercustomerEmail = null, Expression<Func<CustomField[]>> externalTaskcustomercustomFields = null, Expression<Func<CustomContextParameter[]>> externalTaskcustomContextParameters = null, Expression<Func<string>> externalTaskdistributionPriority = null, Expression<Func<PreferredUser[]>> externalTaskpreferredUsers = null)
        {
            var apiCallPath = "/v1/ExternalTasks";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var externalTask = new JObject();
            var externalTaskpropCount = 0;
            externalTaskpropCount++;
            externalTask["serviceUpn"] = ExpressionConverter.ConvertO(externalTaskserviceUPN);
            if (externalTaskcustomerIdentifier != null)
            {
                externalTask["customerIdentifier"] = ExpressionConverter.ConvertO(externalTaskcustomerIdentifier);
                externalTaskpropCount++;
            }

            var customerObject = new JObject();
            var customerObjectpropCount = 0;
            if (externalTaskcustomercustomerFirstName != null)
            {
                customerObject["firstName"] = ExpressionConverter.ConvertO(externalTaskcustomercustomerFirstName);
                customerObjectpropCount++;
            }

            if (externalTaskcustomercustomerLastName != null)
            {
                customerObject["lastName"] = ExpressionConverter.ConvertO(externalTaskcustomercustomerLastName);
                customerObjectpropCount++;
            }

            if (externalTaskcustomercustomerDisplayName != null)
            {
                customerObject["displayName"] = ExpressionConverter.ConvertO(externalTaskcustomercustomerDisplayName);
                customerObjectpropCount++;
            }

            if (externalTaskcustomercustomerCompany != null)
            {
                customerObject["company"] = ExpressionConverter.ConvertO(externalTaskcustomercustomerCompany);
                customerObjectpropCount++;
            }

            if (externalTaskcustomercustomerJobTitle != null)
            {
                customerObject["jobTitle"] = ExpressionConverter.ConvertO(externalTaskcustomercustomerJobTitle);
                customerObjectpropCount++;
            }

            if (externalTaskcustomercustomerDepartment != null)
            {
                customerObject["department"] = ExpressionConverter.ConvertO(externalTaskcustomercustomerDepartment);
                customerObjectpropCount++;
            }

            if (externalTaskcustomercustomerStreetAddress != null)
            {
                customerObject["streetAddress"] = ExpressionConverter.ConvertO(externalTaskcustomercustomerStreetAddress);
                customerObjectpropCount++;
            }

            if (externalTaskcustomercustomerPostcode != null)
            {
                customerObject["postCode"] = ExpressionConverter.ConvertO(externalTaskcustomercustomerPostcode);
                customerObjectpropCount++;
            }

            if (externalTaskcustomercustomerCity != null)
            {
                customerObject["city"] = ExpressionConverter.ConvertO(externalTaskcustomercustomerCity);
                customerObjectpropCount++;
            }

            if (externalTaskcustomercustomerState != null)
            {
                customerObject["state"] = ExpressionConverter.ConvertO(externalTaskcustomercustomerState);
                customerObjectpropCount++;
            }

            if (externalTaskcustomercustomerCountry != null)
            {
                customerObject["country"] = ExpressionConverter.ConvertO(externalTaskcustomercustomerCountry);
                customerObjectpropCount++;
            }

            if (externalTaskcustomercustomerPrimaryTelephoneNumber != null)
            {
                customerObject["primaryTelNumber"] = ExpressionConverter.ConvertO(externalTaskcustomercustomerPrimaryTelephoneNumber);
                customerObjectpropCount++;
            }

            if (externalTaskcustomertelephoneNumbers != null)
            {
                customerObject["telNumbers"] = ExpressionConverter.ConvertO(externalTaskcustomertelephoneNumbers);
                customerObjectpropCount++;
            }

            if (externalTaskcustomercustomerUPN != null)
            {
                customerObject["UPN"] = ExpressionConverter.ConvertO(externalTaskcustomercustomerUPN);
                customerObjectpropCount++;
            }

            if (externalTaskcustomercustomerIMAddress != null)
            {
                customerObject["imAddress"] = ExpressionConverter.ConvertO(externalTaskcustomercustomerIMAddress);
                customerObjectpropCount++;
            }

            if (externalTaskcustomercustomerEmail != null)
            {
                customerObject["email"] = ExpressionConverter.ConvertO(externalTaskcustomercustomerEmail);
                customerObjectpropCount++;
            }

            if (externalTaskcustomercustomFields != null)
            {
                customerObject["customFields"] = ExpressionConverter.ConvertO(externalTaskcustomercustomFields);
                customerObjectpropCount++;
            }

            if (customerObjectpropCount > 0)
            {
                externalTask["customer"] = customerObject;
                externalTaskpropCount++;
            }

            if (externalTaskcustomContextParameters != null)
            {
                externalTask["customContextParameters"] = ExpressionConverter.ConvertO(externalTaskcustomContextParameters);
                externalTaskpropCount++;
            }

            if (externalTaskdistributionPriority != null)
            {
                externalTask["distributionPriority"] = ExpressionConverter.ConvertO(externalTaskdistributionPriority);
                externalTaskpropCount++;
            }

            if (externalTaskpreferredUsers != null)
            {
                externalTask["preferredUsers"] = ExpressionConverter.ConvertO(externalTaskpreferredUsers);
                externalTaskpropCount++;
            }

            if (externalTaskpropCount > 0)
            {
                callPayload.Body = externalTask;
            }

            return new ApiConnectionAction<ExternalTaskWriteResult>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "luwarenimbus")]
        public IWorkflowAction RemoveExternalTask(Expression<Func<string>> externalTaskId)
        {
            var apiCallPath = String.Format("/v1/ExternalTasks/{0}", ExpressionConverter.ConvertWithUrlEncoding(externalTaskId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "luwarenimbus")]
        public IBodyWorkflowAction<ContactReadDto[]> GetContacts(Expression<Func<string>> addressBook, Expression<Func<string[]>> externalIds = null)
        {
            var apiCallPath = String.Format("/v2/AddressBooks/{0}/contacts", ExpressionConverter.ConvertWithUrlEncoding(addressBook, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (externalIds != null)
                callPayload.Queries["externalIds"] = ExpressionConverter.Convert(externalIds);
            return new ApiConnectionAction<ContactReadDto[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "luwarenimbus")]
        public IBodyWorkflowAction<ContactReadDto> AddContact(Expression<Func<string>> addressBook, Expression<Func<string>> contactcontactExternalID, Expression<Func<string>> contactcontactFirstName = null, Expression<Func<string>> contactcontactLastName = null, Expression<Func<string>> contactcontactDisplayName = null, Expression<Func<string>> contactcontactInitials = null, Expression<Func<string>> contactcontactCompany = null, Expression<Func<string>> contactcontactDepartment = null, Expression<Func<string>> contactcontactJobTitle = null, Expression<Func<string>> contactcontactUserPrincipalName = null, Expression<Func<string[]>> contactcontactIMAddresses = null, Expression<Func<string[]>> contactcontactEmailAddresses = null, Expression<Func<string[]>> contactcontactBusinessPhones = null, Expression<Func<string[]>> contactcontactMobilePhones = null, Expression<Func<string[]>> contactcontactHomePhones = null, Expression<Func<Address[]>> contactcontactAddresses = null, Expression<Func<CustomField[]>> contactcontactCustomFields = null)
        {
            var apiCallPath = String.Format("/v2/AddressBooks/{0}/contacts", ExpressionConverter.ConvertWithUrlEncoding(addressBook, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var contact = new JObject();
            var contactpropCount = 0;
            contactpropCount++;
            contact["externalId"] = ExpressionConverter.ConvertO(contactcontactExternalID);
            if (contactcontactFirstName != null)
            {
                contact["firstName"] = ExpressionConverter.ConvertO(contactcontactFirstName);
                contactpropCount++;
            }

            if (contactcontactLastName != null)
            {
                contact["lastName"] = ExpressionConverter.ConvertO(contactcontactLastName);
                contactpropCount++;
            }

            if (contactcontactDisplayName != null)
            {
                contact["displayName"] = ExpressionConverter.ConvertO(contactcontactDisplayName);
                contactpropCount++;
            }

            if (contactcontactInitials != null)
            {
                contact["initials"] = ExpressionConverter.ConvertO(contactcontactInitials);
                contactpropCount++;
            }

            if (contactcontactCompany != null)
            {
                contact["company"] = ExpressionConverter.ConvertO(contactcontactCompany);
                contactpropCount++;
            }

            if (contactcontactDepartment != null)
            {
                contact["department"] = ExpressionConverter.ConvertO(contactcontactDepartment);
                contactpropCount++;
            }

            if (contactcontactJobTitle != null)
            {
                contact["jobTitle"] = ExpressionConverter.ConvertO(contactcontactJobTitle);
                contactpropCount++;
            }

            if (contactcontactUserPrincipalName != null)
            {
                contact["userPrincipalName"] = ExpressionConverter.ConvertO(contactcontactUserPrincipalName);
                contactpropCount++;
            }

            if (contactcontactIMAddresses != null)
            {
                contact["imAddresses"] = ExpressionConverter.ConvertO(contactcontactIMAddresses);
                contactpropCount++;
            }

            if (contactcontactEmailAddresses != null)
            {
                contact["emailAddresses"] = ExpressionConverter.ConvertO(contactcontactEmailAddresses);
                contactpropCount++;
            }

            if (contactcontactBusinessPhones != null)
            {
                contact["businessPhones"] = ExpressionConverter.ConvertO(contactcontactBusinessPhones);
                contactpropCount++;
            }

            if (contactcontactMobilePhones != null)
            {
                contact["mobilePhones"] = ExpressionConverter.ConvertO(contactcontactMobilePhones);
                contactpropCount++;
            }

            if (contactcontactHomePhones != null)
            {
                contact["homePhones"] = ExpressionConverter.ConvertO(contactcontactHomePhones);
                contactpropCount++;
            }

            if (contactcontactAddresses != null)
            {
                contact["addresses"] = ExpressionConverter.ConvertO(contactcontactAddresses);
                contactpropCount++;
            }

            if (contactcontactCustomFields != null)
            {
                contact["customFields"] = ExpressionConverter.ConvertO(contactcontactCustomFields);
                contactpropCount++;
            }

            if (contactpropCount > 0)
            {
                callPayload.Body = contact;
            }

            return new ApiConnectionAction<ContactReadDto>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "luwarenimbus")]
        public IBodyWorkflowAction<ContactReadDto> UpdateContact(Expression<Func<string>> addressBook, Expression<Func<string>> contactcontactExternalID, Expression<Func<string>> contactcontactFirstName = null, Expression<Func<string>> contactcontactLastName = null, Expression<Func<string>> contactcontactDisplayName = null, Expression<Func<string>> contactcontactInitials = null, Expression<Func<string>> contactcontactCompany = null, Expression<Func<string>> contactcontactDepartment = null, Expression<Func<string>> contactcontactJobTitle = null, Expression<Func<string>> contactcontactUserPrincipalName = null, Expression<Func<string[]>> contactcontactIMAddresses = null, Expression<Func<string[]>> contactcontactEmailAddresses = null, Expression<Func<string[]>> contactcontactBusinessPhones = null, Expression<Func<string[]>> contactcontactMobilePhones = null, Expression<Func<string[]>> contactcontactHomePhones = null, Expression<Func<Address[]>> contactcontactAddresses = null, Expression<Func<CustomField[]>> contactcontactCustomFields = null)
        {
            var apiCallPath = String.Format("/v2/AddressBooks/{0}/contacts", ExpressionConverter.ConvertWithUrlEncoding(addressBook, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var contact = new JObject();
            var contactpropCount = 0;
            contactpropCount++;
            contact["externalId"] = ExpressionConverter.ConvertO(contactcontactExternalID);
            if (contactcontactFirstName != null)
            {
                contact["firstName"] = ExpressionConverter.ConvertO(contactcontactFirstName);
                contactpropCount++;
            }

            if (contactcontactLastName != null)
            {
                contact["lastName"] = ExpressionConverter.ConvertO(contactcontactLastName);
                contactpropCount++;
            }

            if (contactcontactDisplayName != null)
            {
                contact["displayName"] = ExpressionConverter.ConvertO(contactcontactDisplayName);
                contactpropCount++;
            }

            if (contactcontactInitials != null)
            {
                contact["initials"] = ExpressionConverter.ConvertO(contactcontactInitials);
                contactpropCount++;
            }

            if (contactcontactCompany != null)
            {
                contact["company"] = ExpressionConverter.ConvertO(contactcontactCompany);
                contactpropCount++;
            }

            if (contactcontactDepartment != null)
            {
                contact["department"] = ExpressionConverter.ConvertO(contactcontactDepartment);
                contactpropCount++;
            }

            if (contactcontactJobTitle != null)
            {
                contact["jobTitle"] = ExpressionConverter.ConvertO(contactcontactJobTitle);
                contactpropCount++;
            }

            if (contactcontactUserPrincipalName != null)
            {
                contact["userPrincipalName"] = ExpressionConverter.ConvertO(contactcontactUserPrincipalName);
                contactpropCount++;
            }

            if (contactcontactIMAddresses != null)
            {
                contact["imAddresses"] = ExpressionConverter.ConvertO(contactcontactIMAddresses);
                contactpropCount++;
            }

            if (contactcontactEmailAddresses != null)
            {
                contact["emailAddresses"] = ExpressionConverter.ConvertO(contactcontactEmailAddresses);
                contactpropCount++;
            }

            if (contactcontactBusinessPhones != null)
            {
                contact["businessPhones"] = ExpressionConverter.ConvertO(contactcontactBusinessPhones);
                contactpropCount++;
            }

            if (contactcontactMobilePhones != null)
            {
                contact["mobilePhones"] = ExpressionConverter.ConvertO(contactcontactMobilePhones);
                contactpropCount++;
            }

            if (contactcontactHomePhones != null)
            {
                contact["homePhones"] = ExpressionConverter.ConvertO(contactcontactHomePhones);
                contactpropCount++;
            }

            if (contactcontactAddresses != null)
            {
                contact["addresses"] = ExpressionConverter.ConvertO(contactcontactAddresses);
                contactpropCount++;
            }

            if (contactcontactCustomFields != null)
            {
                contact["customFields"] = ExpressionConverter.ConvertO(contactcontactCustomFields);
                contactpropCount++;
            }

            if (contactpropCount > 0)
            {
                callPayload.Body = contact;
            }

            return new ApiConnectionAction<ContactReadDto>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "luwarenimbus")]
        public IWorkflowAction RemoveContacts(Expression<Func<string>> addressBook, Expression<Func<string[]>> externalIds = null)
        {
            var apiCallPath = String.Format("/v2/AddressBooks/{0}/contacts/delete", ExpressionConverter.ConvertWithUrlEncoding(addressBook, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(externalIds);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "luwarenimbus")]
        public IWorkflowAction ClearContacts(Expression<Func<string>> addressBook)
        {
            var apiCallPath = String.Format("/v2/AddressBooks/{0}/contacts/clear", ExpressionConverter.ConvertWithUrlEncoding(addressBook, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "luwarenimbus")]
        public IBodyWorkflowAction<CalendarStatus> GetOpeningHours(Expression<Func<string>> serviceUpn, Expression<Func<string>> time = null)
        {
            var apiCallPath = "/v1/service-check/opening-hours";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["serviceUpn"] = ExpressionConverter.Convert(serviceUpn);
            if (time != null)
                callPayload.Queries["time"] = ExpressionConverter.Convert(time);
            return new ApiConnectionAction<CalendarStatus>(callPayload);
        }
    }

    public class LuwarenimbusTriggers([ConnectionName] string connectionId)
    {
    }

    public class TelNumber
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class CustomField
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class CustomContextParameter
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class PreferredUser
    {
        [JsonProperty("upn")]
        public string UPN { get; set; }

        [JsonProperty("priority")]
        public int Priority { get; set; }
    }

    public class OutboundCallWithWorkflowSchedulerEntryEventData
    {
        [JsonProperty("schedulerEntryId")]
        public string SchedulerEntryID { get; set; }

        [JsonProperty("conversationType")]
        public string ConversationType { get; set; }

        [JsonProperty("event")]
        public string Event { get; set; }

        [JsonProperty("direction")]
        public string Direction { get; set; }

        [JsonProperty("modality")]
        public string Modality { get; set; }

        [JsonProperty("ReferenceId")]
        public string ReferenceID { get; set; }

        [JsonProperty("unifiedConversationId")]
        public string UnifiedConversationID { get; set; }

        [JsonProperty("completionReason")]
        public string CompletionReason { get; set; }

        [JsonProperty("destination")]
        public string Destination { get; set; }

        [JsonProperty("distributionPriority")]
        public string DistributionPriority { get; set; }

        [JsonProperty("dueDateTimeUtc")]
        public string DueDateTimeUTC { get; set; }

        [JsonProperty("serviceUpn")]
        public string ServiceUPN { get; set; }

        [JsonProperty("maxAttempts")]
        public int MaximumAttempts { get; set; }

        [JsonProperty("attemptTimeoutInSeconds")]
        public int AttemptTimeoutInSeconds { get; set; }

        [JsonProperty("customCallContextParameters")]
        public CustomContextParameter[] CustomContextParameters { get; set; }

        [JsonProperty("customer")]
        public Customer Customer { get; set; }
    }

    public class Customer
    {
        [JsonProperty("firstName")]
        public string CustomerFirstName { get; set; }

        [JsonProperty("lastName")]
        public string CustomerLastName { get; set; }

        [JsonProperty("displayName")]
        public string CustomerDisplayName { get; set; }

        [JsonProperty("company")]
        public string CustomerCompany { get; set; }

        [JsonProperty("jobTitle")]
        public string CustomerJobTitle { get; set; }

        [JsonProperty("department")]
        public string CustomerDepartment { get; set; }

        [JsonProperty("streetAddress")]
        public string CustomerStreetAddress { get; set; }

        [JsonProperty("postCode")]
        public string CustomerPostcode { get; set; }

        [JsonProperty("city")]
        public string CustomerCity { get; set; }

        [JsonProperty("state")]
        public string CustomerState { get; set; }

        [JsonProperty("country")]
        public string CustomerCountry { get; set; }

        [JsonProperty("primaryTelNumber")]
        public string CustomerPrimaryTelephoneNumber { get; set; }

        [JsonProperty("telNumbers")]
        public TelNumber[] TelephoneNumbers { get; set; }

        [JsonProperty("UPN")]
        public string CustomerUPN { get; set; }

        [JsonProperty("imAddress")]
        public string CustomerIMAddress { get; set; }

        [JsonProperty("email")]
        public string CustomerEmail { get; set; }

        [JsonProperty("customFields")]
        public CustomField[] CustomFields { get; set; }
    }

    public class SchedulerEntryEventData
    {
        [JsonProperty("schedulerEntryId")]
        public string SchedulerEntryID { get; set; }

        [JsonProperty("conversationType")]
        public string ConversationType { get; set; }

        [JsonProperty("event")]
        public string Event { get; set; }

        [JsonProperty("direction")]
        public string Direction { get; set; }

        [JsonProperty("modality")]
        public string Modality { get; set; }

        [JsonProperty("ReferenceId")]
        public string ReferenceID { get; set; }

        [JsonProperty("unifiedConversationId")]
        public string UnifiedConversationID { get; set; }

        [JsonProperty("completionReason")]
        public string CompletionReason { get; set; }

        [JsonProperty("destination")]
        public string Destination { get; set; }

        [JsonProperty("distributionPriority")]
        public string DistributionPriority { get; set; }

        [JsonProperty("dueDateTimeUtc")]
        public string DueDateTimeUTC { get; set; }

        [JsonProperty("serviceUpn")]
        public string ServiceUPN { get; set; }

        [JsonProperty("maxAttempts")]
        public int MaximumAttempts { get; set; }

        [JsonProperty("attemptTimeoutInSeconds")]
        public int AttemptTimeoutInSeconds { get; set; }

        [JsonProperty("maxQueueTimeInSeconds")]
        public int MaximumQueueTimeInSeconds { get; set; }

        [JsonProperty("ronaTimeoutInSeconds")]
        public int RONATimeoutInSeconds { get; set; }

        [JsonProperty("customCallContextParameters")]
        public CustomContextParameter[] CustomContextParameters { get; set; }

        [JsonProperty("customer")]
        public Customer Customer { get; set; }
    }

    public class ExternalTaskWriteResult
    {
        [JsonProperty("id")]
        public string ExternalTaskID { get; set; }

        [JsonProperty("modality")]
        public Modality Modality { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("isAnonymous")]
        public bool IsAnonymous { get; set; }

        [JsonProperty("serviceId")]
        public string ServiceID { get; set; }

        [JsonProperty("serviceName")]
        public string ServiceName { get; set; }

        [JsonProperty("serviceDescription")]
        public string ServiceDescription { get; set; }

        [JsonProperty("serviceDisplayName")]
        public string ServiceDisplayName { get; set; }

        [JsonProperty("serviceUPN")]
        public string ServiceUPN { get; set; }

        [JsonProperty("serviceTelNumber")]
        public string ServiceTelNumber { get; set; }

        [JsonProperty("preferredUsers")]
        public PreferredUser[] PreferredUsers { get; set; }
    }

    public enum Modality
    {
        Audio,
        InstantMessaging,
        ExternalTask
    }

    public class ContactReadDto
    {
        [JsonProperty("externalId")]
        public string ContactExternalID { get; set; }

        [JsonProperty("firstName")]
        public string ContactFirstName { get; set; }

        [JsonProperty("lastName")]
        public string ContactLastName { get; set; }

        [JsonProperty("displayName")]
        public string ContactDisplayName { get; set; }

        [JsonProperty("initials")]
        public string ContactInitials { get; set; }

        [JsonProperty("company")]
        public string ContactCompany { get; set; }

        [JsonProperty("department")]
        public string ContactDepartment { get; set; }

        [JsonProperty("jobTitle")]
        public string ContactJobTitle { get; set; }

        [JsonProperty("userPrincipalName")]
        public string ContactUserPrincipalName { get; set; }

        [JsonProperty("imAddresses")]
        public string[] ContactIMAddresses { get; set; }

        [JsonProperty("emailAddresses")]
        public string[] ContactEmailAddresses { get; set; }

        [JsonProperty("businessPhones")]
        public string[] ContactBusinessPhones { get; set; }

        [JsonProperty("mobilePhones")]
        public string[] ContactMobilePhones { get; set; }

        [JsonProperty("homePhones")]
        public string[] ContactHomePhones { get; set; }

        [JsonProperty("addresses")]
        public Address[] Addresses { get; set; }

        [JsonProperty("customFields")]
        public CustomField[] CustomFields { get; set; }
    }

    public class Address
    {
        [JsonProperty("street")]
        public string AddressStreet { get; set; }

        [JsonProperty("city")]
        public string AddressCity { get; set; }

        [JsonProperty("country")]
        public string AddressCountry { get; set; }

        [JsonProperty("state")]
        public string AddressState { get; set; }

        [JsonProperty("postalCode")]
        public string AddressPostcode { get; set; }
    }

    public enum CalendarStatus
    {
        None,
        Open,
        Closed,
        Holiday,
        Special,
        Special2,
        Special3,
        Special4
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Luwarenimbus;

    public partial class WorkflowManagedActions
    {
        public LuwarenimbusActions Luwarenimbus(string connectionId) => new LuwarenimbusActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public LuwarenimbusTriggers Luwarenimbus(string connectionId) => new LuwarenimbusTriggers(connectionId);
    }
}