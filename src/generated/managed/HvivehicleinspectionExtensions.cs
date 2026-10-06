//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Hvivehicleinspection
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class HvivehicleinspectionActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hvivehicleinspection")]
        [WorkflowExpressionFactory(nameof(__BuildInspectionPerVehicle))]
        public IBodyWorkflowAction<InspectionPerVehicleResponseItem[]> InspectionPerVehicle([WorkflowExpression] Func<string> sv, [WorkflowExpression] Func<string> bodymasterEmail, [WorkflowExpression] Func<string> bodypassword, [WorkflowExpression] Func<string> bodyvehicleNumber, [WorkflowExpression] Func<string> bodystartDate, [WorkflowExpression] Func<string> bodyendDate)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hvivehicleinspection")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<InspectionPerVehicleResponseItem[]> __BuildInspectionPerVehicle(WorkflowExpression<string> sv, WorkflowExpression<string> bodymasterEmail, WorkflowExpression<string> bodypassword, WorkflowExpression<string> bodyvehicleNumber, WorkflowExpression<string> bodystartDate, WorkflowExpression<string> bodyendDate)
        {
            WorkflowExpression.Validate(sv, nameof(sv), required: true);
            WorkflowExpression.Validate(bodymasterEmail, nameof(bodymasterEmail), required: true);
            WorkflowExpression.Validate(bodypassword, nameof(bodypassword), required: true);
            WorkflowExpression.Validate(bodyvehicleNumber, nameof(bodyvehicleNumber), required: true);
            WorkflowExpression.Validate(bodystartDate, nameof(bodystartDate), required: true);
            WorkflowExpression.Validate(bodyendDate, nameof(bodyendDate), required: true);
            return new DeferredBodyAction<InspectionPerVehicleResponseItem[]>(() =>
            {
                var apiCallPath = "/workflows/9bf21378f9924c97b16d3fed67e69200/triggers/manual/paths/invoke";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = Convert.ToString("2016-06-01");
                callPayload.Queries["sp"] = Convert.ToString("/triggers/manual/run");
                callPayload.Queries["sv"] = ExpressionConverter.Convert(sv);
                callPayload.Queries["sig"] = Convert.ToString("byht1JYW63X3X6hvP1B3cRjYvZExaWoV9BsLb_Mm_vI");
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["master_email"] = ExpressionConverter.ConvertO(bodymasterEmail);
                bodypropCount++;
                body["password"] = ExpressionConverter.ConvertO(bodypassword);
                bodypropCount++;
                body["vehicle_number"] = ExpressionConverter.ConvertO(bodyvehicleNumber);
                bodypropCount++;
                body["start_date"] = ExpressionConverter.ConvertO(bodystartDate);
                bodypropCount++;
                body["end_date"] = ExpressionConverter.ConvertO(bodyendDate);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<InspectionPerVehicleResponseItem[]>(callPayload);
            });
        }
    }

    public class HvivehicleinspectionTriggers([ConnectionName] string connectionId)
    {
    }

    public class InspectionPerVehicleResponseItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("user_name")]
        public string UserName { get; set; }

        [JsonProperty("report_no")]
        public string ReportNo { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("inspection_date")]
        public string InspectionDate { get; set; }

        [JsonProperty("inspector")]
        public string Inspector { get; set; }

        [JsonProperty("repair")]
        public string Repair { get; set; }

        [JsonProperty("replace")]
        public string Replace { get; set; }

        [JsonProperty("remark")]
        public string Remark { get; set; }

        [JsonProperty("vehicle_name")]
        public string VehicleName { get; set; }

        [JsonProperty("vehicle_serial")]
        public string VehicleSerial { get; set; }

        [JsonProperty("vehicle_vin")]
        public string VehicleVin { get; set; }

        [JsonProperty("vehicle_model")]
        public string VehicleModel { get; set; }

        [JsonProperty("pdf_file_path")]
        public string PdfFilePath { get; set; }

        [JsonProperty("custom1")]
        public string Custom1 { get; set; }

        [JsonProperty("custom2")]
        public string Custom2 { get; set; }

        [JsonProperty("vehicle_status")]
        public string VehicleStatus { get; set; }

        [JsonProperty("maintenance_required")]
        public string MaintenanceRequired { get; set; }

        [JsonProperty("maintenance_priority")]
        public string MaintenancePriority { get; set; }

        [JsonProperty("overall_condition")]
        public string OverallCondition { get; set; }

        [JsonProperty("safe_to_use")]
        public string SafeToUse { get; set; }

        [JsonProperty("user_email")]
        public string UserEmail { get; set; }

        [JsonProperty("good")]
        public string Good { get; set; }

        [JsonProperty("na")]
        public string Na { get; set; }

        [JsonProperty("field1")]
        public string Field1 { get; set; }

        [JsonProperty("field2")]
        public string Field2 { get; set; }

        [JsonProperty("field3")]
        public string Field3 { get; set; }

        [JsonProperty("field4")]
        public string Field4 { get; set; }

        [JsonProperty("field5")]
        public string Field5 { get; set; }

        [JsonProperty("meter_reading")]
        public string MeterReading { get; set; }

        [JsonProperty("uploaded")]
        public string Uploaded { get; set; }

        [JsonProperty("workorder")]
        public string Workorder { get; set; }

        [JsonProperty("vehicle_category")]
        public string VehicleCategory { get; set; }

        [JsonProperty("checklistGroup")]
        public string ChecklistGroup { get; set; }

        [JsonProperty("checklistName")]
        public string ChecklistName { get; set; }

        [JsonProperty("checklistStatus")]
        public string ChecklistStatus { get; set; }

        [JsonProperty("group_name")]
        public string GroupName { get; set; }

        [JsonProperty("operator_name")]
        public string OperatorName { get; set; }

        [JsonProperty("ios_offline_flag")]
        public string IosOfflineFlag { get; set; }

        [JsonProperty("corrective_item")]
        public string CorrectiveItem { get; set; }

        [JsonProperty("corrective_item_status")]
        public string CorrectiveItemStatus { get; set; }

        [JsonProperty("corrective_note")]
        public string CorrectiveNote { get; set; }

        [JsonProperty("corrective_date")]
        public string CorrectiveDate { get; set; }

        [JsonProperty("mechanic_name")]
        public string MechanicName { get; set; }

        [JsonProperty("dvir_type")]
        public string DvirType { get; set; }

        [JsonProperty("dvir_flag")]
        public string DvirFlag { get; set; }

        [JsonProperty("corrective_action")]
        public string CorrectiveAction { get; set; }

        [JsonProperty("corrective_vehicle_condition")]
        public string CorrectiveVehicleCondition { get; set; }

        [JsonProperty("app_version")]
        public string AppVersion { get; set; }

        [JsonProperty("lat_long")]
        public string LatLong { get; set; }

        [JsonProperty("full_location")]
        public string FullLocation { get; set; }

        [JsonProperty("action_source")]
        public string ActionSource { get; set; }

        [JsonProperty("archive")]
        public string Archive { get; set; }

        [JsonProperty("breakdown")]
        public string Breakdown { get; set; }

        [JsonProperty("sample_data_key")]
        public string SampleDataKey { get; set; }

        [JsonProperty("index_number")]
        public int IndexNumber { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("deleted")]
        public bool Deleted { get; set; }

        [JsonProperty("inspector_id")]
        public string InspectorId { get; set; }

        [JsonProperty("location_id")]
        public string LocationId { get; set; }

        [JsonProperty("form_id")]
        public string FormId { get; set; }

        [JsonProperty("inspection_time")]
        public string InspectionTime { get; set; }

        [JsonProperty("root_cause")]
        public string RootCause { get; set; }

        [JsonProperty("rca_by")]
        public string RcaBy { get; set; }

        [JsonProperty("responsible")]
        public string Responsible { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Hvivehicleinspection;

    public partial class WorkflowManagedActions
    {
        public HvivehicleinspectionActions Hvivehicleinspection(string connectionId) => new HvivehicleinspectionActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public HvivehicleinspectionTriggers Hvivehicleinspection(string connectionId) => new HvivehicleinspectionTriggers(connectionId);
    }
}