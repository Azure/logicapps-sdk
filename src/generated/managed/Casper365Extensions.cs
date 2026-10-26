//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Casper365
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Casper365Actions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "casper365")]
        public IBodyWorkflowAction<Course[], ApiConnectionActionConfiguration> CourseGet(Expression<Func<string>> course = null)
        {
            var __workflow_course = WorkflowExpression.Compile(course, nameof(course), required: false);
            return new DeferredBodyAction<Course[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Course";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_course != null)
                    callPayload.Queries["course"] = ExpressionConverter.Convert(__workflow_course);
                return new ApiConnectionAction<Course[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "casper365")]
        public IBodyWorkflowAction<bool, ApiConnectionActionConfiguration> Course(Expression<Func<CoursePostInput>> course = null)
        {
            var __workflow_course = WorkflowExpression.Compile(course, nameof(course), required: false);
            return new DeferredBodyAction<bool, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Course";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_course != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_course);
                return new ApiConnectionAction<bool>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "casper365")]
        public IWorkflowAction<ApiConnectionActionConfiguration> LogEnd(Expression<Func<string>> identifier = null)
        {
            var __workflow_identifier = WorkflowExpression.Compile(identifier, nameof(identifier), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Log/End";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_identifier != null)
                    callPayload.Queries["identifier"] = ExpressionConverter.Convert(__workflow_identifier);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "casper365")]
        public IWorkflowAction<ApiConnectionActionConfiguration> LogStart(Expression<Func<string>> identifier = null)
        {
            var __workflow_identifier = WorkflowExpression.Compile(identifier, nameof(identifier), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Log/Start";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_identifier != null)
                    callPayload.Queries["identifier"] = ExpressionConverter.Convert(__workflow_identifier);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "casper365")]
        public IBodyWorkflowAction<Student, ApiConnectionActionConfiguration> StudentGet(Expression<Func<string>> studentId = null)
        {
            var __workflow_studentId = WorkflowExpression.Compile(studentId, nameof(studentId), required: false);
            return new DeferredBodyAction<Student, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Student";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_studentId != null)
                    callPayload.Queries["studentId"] = ExpressionConverter.Convert(__workflow_studentId);
                return new ApiConnectionAction<Student>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "casper365")]
        public IWorkflowAction<ApiConnectionActionConfiguration> Student(Expression<Func<StudentPostInput>> student = null)
        {
            var __workflow_student = WorkflowExpression.Compile(student, nameof(student), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Student";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_student != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_student);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "casper365")]
        public IBodyWorkflowAction<bool, ApiConnectionActionConfiguration> StudentIsBrowserAppGet()
        {
            return new DeferredBodyAction<bool, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Student/IsBrowserApp";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<bool>(callPayload);
            });
        }
    }

    public class Casper365Triggers([ConnectionName] string connectionId)
    {
    }

    public class Course
    {
        [JsonProperty("audience")]
        public string Audience { get; set; }

        [JsonProperty("courseName")]
        public string CourseName { get; set; }

        [JsonProperty("dos")]
        public string Dos { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }
    }

    public class CoursePostInput
    {
        [JsonProperty("audience")]
        public string Audience { get; set; }

        [JsonProperty("courseName")]
        public string CourseName { get; set; }

        [JsonProperty("dos")]
        public string Dos { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }
    }

    public class Student
    {
        [JsonProperty("acadCareer")]
        public string AcadCareer { get; set; }

        [JsonProperty("acadOrgDescr")]
        public string AcadOrgDescr { get; set; }

        [JsonProperty("acadProgram")]
        public string AcadProgram { get; set; }

        [JsonProperty("address1")]
        public string Address1 { get; set; }

        [JsonProperty("address2")]
        public string Address2 { get; set; }

        [JsonProperty("address3")]
        public string Address3 { get; set; }

        [JsonProperty("address4")]
        public string Address4 { get; set; }

        [JsonProperty("barcode")]
        public string Barcode { get; set; }

        [JsonProperty("birthCountryCode")]
        public string BirthCountryCode { get; set; }

        [JsonProperty("cellTel")]
        public string CellTel { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("collegeAccountNo")]
        public double CollegeAccountNo { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("countryCitizen")]
        public string CountryCitizen { get; set; }

        [JsonProperty("countryCitizen2")]
        public string CountryCitizen2 { get; set; }

        [JsonProperty("crsid")]
        public string Crsid { get; set; }

        [JsonProperty("degree")]
        public string Degree { get; set; }

        [JsonProperty("dob")]
        public string Dob { get; set; }

        [JsonProperty("dos")]
        public string Dos { get; set; }

        [JsonProperty("dosEmail")]
        public string DosEmail { get; set; }

        [JsonProperty("dosEmployeeId")]
        public string DosEmployeeId { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("emailAddr")]
        public string EmailAddr { get; set; }

        [JsonProperty("emailPersonal")]
        public string EmailPersonal { get; set; }

        [JsonProperty("endDate")]
        public string EndDate { get; set; }

        [JsonProperty("enqGrp")]
        public string EnqGrp { get; set; }

        [JsonProperty("firstNames")]
        public string FirstNames { get; set; }

        [JsonProperty("gradTutor")]
        public string GradTutor { get; set; }

        [JsonProperty("gradTutorEmail")]
        public string GradTutorEmail { get; set; }

        [JsonProperty("gradTutorEmployeeId")]
        public string GradTutorEmployeeId { get; set; }

        [JsonProperty("grp")]
        public string Grp { get; set; }

        [JsonProperty("grpId")]
        public string GrpId { get; set; }

        [JsonProperty("homeAddress1")]
        public string HomeAddress1 { get; set; }

        [JsonProperty("homeAddress2")]
        public string HomeAddress2 { get; set; }

        [JsonProperty("homeAddress3")]
        public string HomeAddress3 { get; set; }

        [JsonProperty("homeAddress4")]
        public string HomeAddress4 { get; set; }

        [JsonProperty("homeAddress5")]
        public string HomeAddress5 { get; set; }

        [JsonProperty("homeCountry")]
        public string HomeCountry { get; set; }

        [JsonProperty("homePostal")]
        public string HomePostal { get; set; }

        [JsonProperty("homeState")]
        public string HomeState { get; set; }

        [JsonProperty("homeTel")]
        public string HomeTel { get; set; }

        [JsonProperty("matriculation")]
        public string Matriculation { get; set; }

        [JsonProperty("mobileTel")]
        public string MobileTel { get; set; }

        [JsonProperty("nationality")]
        public string Nationality { get; set; }

        [JsonProperty("postal")]
        public string Postal { get; set; }

        [JsonProperty("prinSuper")]
        public string PrinSuper { get; set; }

        [JsonProperty("prinSuperEmail")]
        public string PrinSuperEmail { get; set; }

        [JsonProperty("prinSuperEmployeeId")]
        public string PrinSuperEmployeeId { get; set; }

        [JsonProperty("sex")]
        public string Sex { get; set; }

        [JsonProperty("startDate")]
        public string StartDate { get; set; }

        [JsonProperty("studentFeesClass")]
        public string StudentFeesClass { get; set; }

        [JsonProperty("studyYear")]
        public string StudyYear { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("subjectDescr")]
        public string SubjectDescr { get; set; }

        [JsonProperty("superEmail")]
        public string SuperEmail { get; set; }

        [JsonProperty("surname")]
        public string Surname { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("tutor")]
        public string Tutor { get; set; }

        [JsonProperty("tutorEmail")]
        public string TutorEmail { get; set; }

        [JsonProperty("tutorEmployeeId")]
        public string TutorEmployeeId { get; set; }
    }

    public class StudentPostInput
    {
        [JsonProperty("acadCareer")]
        public string AcadCareer { get; set; }

        [JsonProperty("acadOrgDescr")]
        public string AcadOrgDescr { get; set; }

        [JsonProperty("acadProgram")]
        public string AcadProgram { get; set; }

        [JsonProperty("address1")]
        public string Address1 { get; set; }

        [JsonProperty("address2")]
        public string Address2 { get; set; }

        [JsonProperty("address3")]
        public string Address3 { get; set; }

        [JsonProperty("address4")]
        public string Address4 { get; set; }

        [JsonProperty("barcode")]
        public string Barcode { get; set; }

        [JsonProperty("birthCountryCode")]
        public string BirthCountryCode { get; set; }

        [JsonProperty("cellTel")]
        public string CellTel { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("collegeAccountNo")]
        public double? CollegeAccountNo { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("countryCitizen")]
        public string CountryCitizen { get; set; }

        [JsonProperty("countryCitizen2")]
        public string CountryCitizen2 { get; set; }

        [JsonProperty("crsid")]
        public string Crsid { get; set; }

        [JsonProperty("degree")]
        public string Degree { get; set; }

        [JsonProperty("dob")]
        public string Dob { get; set; }

        [JsonProperty("dos")]
        public string Dos { get; set; }

        [JsonProperty("dosEmail")]
        public string DosEmail { get; set; }

        [JsonProperty("dosEmployeeId")]
        public string DosEmployeeId { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("emailAddr")]
        public string EmailAddr { get; set; }

        [JsonProperty("emailPersonal")]
        public string EmailPersonal { get; set; }

        [JsonProperty("endDate")]
        public string EndDate { get; set; }

        [JsonProperty("enqGrp")]
        public string EnqGrp { get; set; }

        [JsonProperty("firstNames")]
        public string FirstNames { get; set; }

        [JsonProperty("gradTutor")]
        public string GradTutor { get; set; }

        [JsonProperty("gradTutorEmail")]
        public string GradTutorEmail { get; set; }

        [JsonProperty("gradTutorEmployeeId")]
        public string GradTutorEmployeeId { get; set; }

        [JsonProperty("grp")]
        public string Grp { get; set; }

        [JsonProperty("grpId")]
        public string GrpId { get; set; }

        [JsonProperty("homeAddress1")]
        public string HomeAddress1 { get; set; }

        [JsonProperty("homeAddress2")]
        public string HomeAddress2 { get; set; }

        [JsonProperty("homeAddress3")]
        public string HomeAddress3 { get; set; }

        [JsonProperty("homeAddress4")]
        public string HomeAddress4 { get; set; }

        [JsonProperty("homeAddress5")]
        public string HomeAddress5 { get; set; }

        [JsonProperty("homeCountry")]
        public string HomeCountry { get; set; }

        [JsonProperty("homePostal")]
        public string HomePostal { get; set; }

        [JsonProperty("homeState")]
        public string HomeState { get; set; }

        [JsonProperty("homeTel")]
        public string HomeTel { get; set; }

        [JsonProperty("matriculation")]
        public string Matriculation { get; set; }

        [JsonProperty("mobileTel")]
        public string MobileTel { get; set; }

        [JsonProperty("nationality")]
        public string Nationality { get; set; }

        [JsonProperty("postal")]
        public string Postal { get; set; }

        [JsonProperty("prinSuper")]
        public string PrinSuper { get; set; }

        [JsonProperty("prinSuperEmail")]
        public string PrinSuperEmail { get; set; }

        [JsonProperty("prinSuperEmployeeId")]
        public string PrinSuperEmployeeId { get; set; }

        [JsonProperty("sex")]
        public string Sex { get; set; }

        [JsonProperty("startDate")]
        public string StartDate { get; set; }

        [JsonProperty("studentFeesClass")]
        public string StudentFeesClass { get; set; }

        [JsonProperty("studyYear")]
        public string StudyYear { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("subjectDescr")]
        public string SubjectDescr { get; set; }

        [JsonProperty("superEmail")]
        public string SuperEmail { get; set; }

        [JsonProperty("surname")]
        public string Surname { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("tutor")]
        public string Tutor { get; set; }

        [JsonProperty("tutorEmail")]
        public string TutorEmail { get; set; }

        [JsonProperty("tutorEmployeeId")]
        public string TutorEmployeeId { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Casper365;

    public partial class WorkflowManagedActions
    {
        public Casper365Actions Casper365(string connectionId) => new Casper365Actions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public Casper365Triggers Casper365(string connectionId) => new Casper365Triggers(connectionId);
    }
}