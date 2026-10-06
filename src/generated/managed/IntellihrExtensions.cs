//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Intellihr
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class IntellihrActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "intellihr")]
        [WorkflowExpressionFactory(nameof(__BuildEndJob))]
        public IBodyWorkflowAction<SingleJob> EndJob([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodyendDate, [WorkflowExpression] Func<string> bodyturnoverType, [WorkflowExpression] Func<string> bodyturnoverReason = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "intellihr")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SingleJob> __BuildEndJob(WorkflowExpression<string> id, WorkflowExpression<string> bodyendDate, WorkflowExpression<string> bodyturnoverType, WorkflowExpression<string> bodyturnoverReason = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(bodyendDate, nameof(bodyendDate), required: true);
            WorkflowExpression.Validate(bodyturnoverType, nameof(bodyturnoverType), required: true);
            WorkflowExpression.Validate(bodyturnoverReason, nameof(bodyturnoverReason), required: false);
            return new DeferredBodyAction<SingleJob>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/job-end/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["endDate"] = ExpressionConverter.ConvertO(bodyendDate);
                bodypropCount++;
                body["turnoverType"] = ExpressionConverter.ConvertO(bodyturnoverType);
                if (bodyturnoverReason != null)
                {
                    body["turnoverReason"] = ExpressionConverter.ConvertO(bodyturnoverReason);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SingleJob>(callPayload);
            });
        }
    }

    public class IntellihrTriggers([ConnectionName] string connectionId)
    {
    }

    public class SingleJob
    {
        [JsonProperty("meta")]
        public Meta1 Meta { get; set; }

        [JsonProperty("data")]
        public Job Data { get; set; }
    }

    public class Meta1
    {
        [JsonProperty("asAt")]
        public string AsAt { get; set; }
    }

    public class Job
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("person")]
        public Person Person { get; set; }

        [JsonProperty("recruitment")]
        public Recruitment Recruitment { get; set; }

        [JsonProperty("location")]
        public Location Location { get; set; }

        [JsonProperty("payGrade")]
        public PayGrade PayGrade { get; set; }

        [JsonProperty("businessUnit")]
        public BusinessUnit4 BusinessUnit { get; set; }

        [JsonProperty("businessEntity")]
        public BusinessEntity2 BusinessEntity { get; set; }

        [JsonProperty("supervisorJob")]
        public SupervisorJob SupervisorJob { get; set; }

        [JsonProperty("supervisorPerson")]
        public SupervisorPerson SupervisorPerson { get; set; }

        [JsonProperty("remunerationSchedule")]
        public RemunerationSchedule RemunerationSchedule { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("fte")]
        public double Fte { get; set; }

        [JsonProperty("workClass")]
        public string WorkClass { get; set; }

        [JsonProperty("workType")]
        public string WorkType { get; set; }

        [JsonProperty("jobStatus")]
        public string JobStatus { get; set; }

        [JsonProperty("companyStartDate")]
        public string CompanyStartDate { get; set; }

        [JsonProperty("companyEndDate")]
        public string CompanyEndDate { get; set; }

        [JsonProperty("isEndDateConfirmed")]
        public bool IsEndDateConfirmed { get; set; }

        [JsonProperty("turnoverType")]
        public string TurnoverType { get; set; }

        [JsonProperty("turnoverReason")]
        public string TurnoverReason { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }
    }

    public class Person
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("employeeNumber")]
        public string EmployeeNumber { get; set; }

        [JsonProperty("autoIncrementIntellihrId")]
        public double AutoIncrementIntellihrId { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }
    }

    public class Recruitment
    {
        [JsonProperty("cost")]
        public double Cost { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("source")]
        public Source Source { get; set; }
    }

    public class Source
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }
    }

    public class Location
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }
    }

    public class PayGrade
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }
    }

    public class BusinessUnit4
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }
    }

    public class BusinessEntity2
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }
    }

    public class SupervisorJob
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("jobStatus")]
        public string JobStatus { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }
    }

    public class SupervisorPerson
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("employeeNumber")]
        public string EmployeeNumber { get; set; }

        [JsonProperty("autoIncrementIntellihrId")]
        public double AutoIncrementIntellihrId { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }
    }

    public class RemunerationSchedule
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("baseAnnualSalary")]
        public double BaseAnnualSalary { get; set; }

        [JsonProperty("baseHourlyRate")]
        public double BaseHourlyRate { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("hoursPerCycle")]
        public double HoursPerCycle { get; set; }

        [JsonProperty("payCycle")]
        public string PayCycle { get; set; }

        [JsonProperty("annualPackage")]
        public double AnnualPackage { get; set; }

        [JsonProperty("hourlyPackage")]
        public double HourlyPackage { get; set; }

        [JsonProperty("currencyConversionOccurred")]
        public bool CurrencyConversionOccurred { get; set; }

        [JsonProperty("employmentCondition")]
        public EmploymentCondition2 EmploymentCondition { get; set; }

        [JsonProperty("additions")]
        public Addition[] Additions { get; set; }

        [JsonProperty("deductions")]
        public Deduction[] Deductions { get; set; }

        [JsonProperty("additionsToTotal")]
        public AdditionsToTotal[] AdditionsToTotal { get; set; }

        [JsonProperty("breakdowns")]
        public Breakdown[] Breakdowns { get; set; }
    }

    public class EmploymentCondition2
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("awardName")]
        public string AwardName { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }
    }

    public class Addition
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("value")]
        public double Value { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class Deduction
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("value")]
        public double Value { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class AdditionsToTotal
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("value")]
        public double Value { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class Breakdown
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("value")]
        public double Value { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Intellihr;

    public partial class WorkflowManagedActions
    {
        public IntellihrActions Intellihr(string connectionId) => new IntellihrActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public IntellihrTriggers Intellihr(string connectionId) => new IntellihrTriggers(connectionId);
    }
}