//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Casper365
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Casper365Actions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "casper365")]
        public IBodyWorkflowAction<Course[]> CourseGet(Expression<Func<string>> course = null)
        {
            var apiCallPath = "/Course";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (course != null)
                callPayload.Queries["course"] = CSharpExpressionConverter.ConvertO(course);
            return new ApiConnectionAction<Course[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "casper365")]
        public IBodyWorkflowAction<bool> Course(Expression<Func<string>> courseaudience = null, Expression<Func<string>> coursecourseName = null, Expression<Func<string>> coursedos = null, Expression<Func<string>> courseemail = null)
        {
            var apiCallPath = "/Course";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var course = new JObject();
            var coursepropCount = 0;
            if (courseaudience != null)
            {
                course["audience"] = CSharpExpressionConverter.ConvertToken(courseaudience);
                coursepropCount++;
            }

            if (coursecourseName != null)
            {
                course["courseName"] = CSharpExpressionConverter.ConvertToken(coursecourseName);
                coursepropCount++;
            }

            if (coursedos != null)
            {
                course["dos"] = CSharpExpressionConverter.ConvertToken(coursedos);
                coursepropCount++;
            }

            if (courseemail != null)
            {
                course["email"] = CSharpExpressionConverter.ConvertToken(courseemail);
                coursepropCount++;
            }

            if (coursepropCount > 0)
            {
                callPayload.Body = course;
            }

            return new ApiConnectionAction<bool>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "casper365")]
        public IWorkflowAction LogEnd(Expression<Func<string>> identifier = null)
        {
            var apiCallPath = "/Log/End";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (identifier != null)
                callPayload.Queries["identifier"] = CSharpExpressionConverter.ConvertO(identifier);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "casper365")]
        public IWorkflowAction LogStart(Expression<Func<string>> identifier = null)
        {
            var apiCallPath = "/Log/Start";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (identifier != null)
                callPayload.Queries["identifier"] = CSharpExpressionConverter.ConvertO(identifier);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "casper365")]
        public IBodyWorkflowAction<Student> StudentGet(Expression<Func<string>> studentId = null)
        {
            var apiCallPath = "/Student";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (studentId != null)
                callPayload.Queries["studentId"] = CSharpExpressionConverter.ConvertO(studentId);
            return new ApiConnectionAction<Student>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "casper365")]
        public IWorkflowAction Student(Expression<Func<string>> studentacadCareer = null, Expression<Func<string>> studentacadOrgDescr = null, Expression<Func<string>> studentacadProgram = null, Expression<Func<string>> studentaddress1 = null, Expression<Func<string>> studentaddress2 = null, Expression<Func<string>> studentaddress3 = null, Expression<Func<string>> studentaddress4 = null, Expression<Func<string>> studentbarcode = null, Expression<Func<string>> studentbirthCountryCode = null, Expression<Func<string>> studentcellTel = null, Expression<Func<string>> studentcity = null, Expression<Func<double>> studentcollegeAccountNo = null, Expression<Func<string>> studentcountry = null, Expression<Func<string>> studentcountryCitizen = null, Expression<Func<string>> studentcountryCitizen2 = null, Expression<Func<string>> studentcrsid = null, Expression<Func<string>> studentdegree = null, Expression<Func<string>> studentdob = null, Expression<Func<string>> studentdos = null, Expression<Func<string>> studentdosEmail = null, Expression<Func<string>> studentdosEmployeeId = null, Expression<Func<string>> studentemail = null, Expression<Func<string>> studentemailAddr = null, Expression<Func<string>> studentemailPersonal = null, Expression<Func<string>> studentendDate = null, Expression<Func<string>> studentenqGrp = null, Expression<Func<string>> studentfirstNames = null, Expression<Func<string>> studentgradTutor = null, Expression<Func<string>> studentgradTutorEmail = null, Expression<Func<string>> studentgradTutorEmployeeId = null, Expression<Func<string>> studentgrp = null, Expression<Func<string>> studentgrpId = null, Expression<Func<string>> studenthomeAddress1 = null, Expression<Func<string>> studenthomeAddress2 = null, Expression<Func<string>> studenthomeAddress3 = null, Expression<Func<string>> studenthomeAddress4 = null, Expression<Func<string>> studenthomeAddress5 = null, Expression<Func<string>> studenthomeCountry = null, Expression<Func<string>> studenthomePostal = null, Expression<Func<string>> studenthomeState = null, Expression<Func<string>> studenthomeTel = null, Expression<Func<string>> studentmatriculation = null, Expression<Func<string>> studentmobileTel = null, Expression<Func<string>> studentnationality = null, Expression<Func<string>> studentpostal = null, Expression<Func<string>> studentprinSuper = null, Expression<Func<string>> studentprinSuperEmail = null, Expression<Func<string>> studentprinSuperEmployeeId = null, Expression<Func<string>> studentsex = null, Expression<Func<string>> studentstartDate = null, Expression<Func<string>> studentstudentFeesClass = null, Expression<Func<string>> studentstudyYear = null, Expression<Func<string>> studentsubject = null, Expression<Func<string>> studentsubjectDescr = null, Expression<Func<string>> studentsuperEmail = null, Expression<Func<string>> studentsurname = null, Expression<Func<string>> studenttitle = null, Expression<Func<string>> studenttutor = null, Expression<Func<string>> studenttutorEmail = null, Expression<Func<string>> studenttutorEmployeeId = null)
        {
            var apiCallPath = "/Student";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var student = new JObject();
            var studentpropCount = 0;
            if (studentacadCareer != null)
            {
                student["acadCareer"] = CSharpExpressionConverter.ConvertToken(studentacadCareer);
                studentpropCount++;
            }

            if (studentacadOrgDescr != null)
            {
                student["acadOrgDescr"] = CSharpExpressionConverter.ConvertToken(studentacadOrgDescr);
                studentpropCount++;
            }

            if (studentacadProgram != null)
            {
                student["acadProgram"] = CSharpExpressionConverter.ConvertToken(studentacadProgram);
                studentpropCount++;
            }

            if (studentaddress1 != null)
            {
                student["address1"] = CSharpExpressionConverter.ConvertToken(studentaddress1);
                studentpropCount++;
            }

            if (studentaddress2 != null)
            {
                student["address2"] = CSharpExpressionConverter.ConvertToken(studentaddress2);
                studentpropCount++;
            }

            if (studentaddress3 != null)
            {
                student["address3"] = CSharpExpressionConverter.ConvertToken(studentaddress3);
                studentpropCount++;
            }

            if (studentaddress4 != null)
            {
                student["address4"] = CSharpExpressionConverter.ConvertToken(studentaddress4);
                studentpropCount++;
            }

            if (studentbarcode != null)
            {
                student["barcode"] = CSharpExpressionConverter.ConvertToken(studentbarcode);
                studentpropCount++;
            }

            if (studentbirthCountryCode != null)
            {
                student["birthCountryCode"] = CSharpExpressionConverter.ConvertToken(studentbirthCountryCode);
                studentpropCount++;
            }

            if (studentcellTel != null)
            {
                student["cellTel"] = CSharpExpressionConverter.ConvertToken(studentcellTel);
                studentpropCount++;
            }

            if (studentcity != null)
            {
                student["city"] = CSharpExpressionConverter.ConvertToken(studentcity);
                studentpropCount++;
            }

            if (studentcollegeAccountNo != null)
            {
                student["collegeAccountNo"] = CSharpExpressionConverter.ConvertToken(studentcollegeAccountNo);
                studentpropCount++;
            }

            if (studentcountry != null)
            {
                student["country"] = CSharpExpressionConverter.ConvertToken(studentcountry);
                studentpropCount++;
            }

            if (studentcountryCitizen != null)
            {
                student["countryCitizen"] = CSharpExpressionConverter.ConvertToken(studentcountryCitizen);
                studentpropCount++;
            }

            if (studentcountryCitizen2 != null)
            {
                student["countryCitizen2"] = CSharpExpressionConverter.ConvertToken(studentcountryCitizen2);
                studentpropCount++;
            }

            if (studentcrsid != null)
            {
                student["crsid"] = CSharpExpressionConverter.ConvertToken(studentcrsid);
                studentpropCount++;
            }

            if (studentdegree != null)
            {
                student["degree"] = CSharpExpressionConverter.ConvertToken(studentdegree);
                studentpropCount++;
            }

            if (studentdob != null)
            {
                student["dob"] = CSharpExpressionConverter.ConvertToken(studentdob);
                studentpropCount++;
            }

            if (studentdos != null)
            {
                student["dos"] = CSharpExpressionConverter.ConvertToken(studentdos);
                studentpropCount++;
            }

            if (studentdosEmail != null)
            {
                student["dosEmail"] = CSharpExpressionConverter.ConvertToken(studentdosEmail);
                studentpropCount++;
            }

            if (studentdosEmployeeId != null)
            {
                student["dosEmployeeId"] = CSharpExpressionConverter.ConvertToken(studentdosEmployeeId);
                studentpropCount++;
            }

            if (studentemail != null)
            {
                student["email"] = CSharpExpressionConverter.ConvertToken(studentemail);
                studentpropCount++;
            }

            if (studentemailAddr != null)
            {
                student["emailAddr"] = CSharpExpressionConverter.ConvertToken(studentemailAddr);
                studentpropCount++;
            }

            if (studentemailPersonal != null)
            {
                student["emailPersonal"] = CSharpExpressionConverter.ConvertToken(studentemailPersonal);
                studentpropCount++;
            }

            if (studentendDate != null)
            {
                student["endDate"] = CSharpExpressionConverter.ConvertToken(studentendDate);
                studentpropCount++;
            }

            if (studentenqGrp != null)
            {
                student["enqGrp"] = CSharpExpressionConverter.ConvertToken(studentenqGrp);
                studentpropCount++;
            }

            if (studentfirstNames != null)
            {
                student["firstNames"] = CSharpExpressionConverter.ConvertToken(studentfirstNames);
                studentpropCount++;
            }

            if (studentgradTutor != null)
            {
                student["gradTutor"] = CSharpExpressionConverter.ConvertToken(studentgradTutor);
                studentpropCount++;
            }

            if (studentgradTutorEmail != null)
            {
                student["gradTutorEmail"] = CSharpExpressionConverter.ConvertToken(studentgradTutorEmail);
                studentpropCount++;
            }

            if (studentgradTutorEmployeeId != null)
            {
                student["gradTutorEmployeeId"] = CSharpExpressionConverter.ConvertToken(studentgradTutorEmployeeId);
                studentpropCount++;
            }

            if (studentgrp != null)
            {
                student["grp"] = CSharpExpressionConverter.ConvertToken(studentgrp);
                studentpropCount++;
            }

            if (studentgrpId != null)
            {
                student["grpId"] = CSharpExpressionConverter.ConvertToken(studentgrpId);
                studentpropCount++;
            }

            if (studenthomeAddress1 != null)
            {
                student["homeAddress1"] = CSharpExpressionConverter.ConvertToken(studenthomeAddress1);
                studentpropCount++;
            }

            if (studenthomeAddress2 != null)
            {
                student["homeAddress2"] = CSharpExpressionConverter.ConvertToken(studenthomeAddress2);
                studentpropCount++;
            }

            if (studenthomeAddress3 != null)
            {
                student["homeAddress3"] = CSharpExpressionConverter.ConvertToken(studenthomeAddress3);
                studentpropCount++;
            }

            if (studenthomeAddress4 != null)
            {
                student["homeAddress4"] = CSharpExpressionConverter.ConvertToken(studenthomeAddress4);
                studentpropCount++;
            }

            if (studenthomeAddress5 != null)
            {
                student["homeAddress5"] = CSharpExpressionConverter.ConvertToken(studenthomeAddress5);
                studentpropCount++;
            }

            if (studenthomeCountry != null)
            {
                student["homeCountry"] = CSharpExpressionConverter.ConvertToken(studenthomeCountry);
                studentpropCount++;
            }

            if (studenthomePostal != null)
            {
                student["homePostal"] = CSharpExpressionConverter.ConvertToken(studenthomePostal);
                studentpropCount++;
            }

            if (studenthomeState != null)
            {
                student["homeState"] = CSharpExpressionConverter.ConvertToken(studenthomeState);
                studentpropCount++;
            }

            if (studenthomeTel != null)
            {
                student["homeTel"] = CSharpExpressionConverter.ConvertToken(studenthomeTel);
                studentpropCount++;
            }

            if (studentmatriculation != null)
            {
                student["matriculation"] = CSharpExpressionConverter.ConvertToken(studentmatriculation);
                studentpropCount++;
            }

            if (studentmobileTel != null)
            {
                student["mobileTel"] = CSharpExpressionConverter.ConvertToken(studentmobileTel);
                studentpropCount++;
            }

            if (studentnationality != null)
            {
                student["nationality"] = CSharpExpressionConverter.ConvertToken(studentnationality);
                studentpropCount++;
            }

            if (studentpostal != null)
            {
                student["postal"] = CSharpExpressionConverter.ConvertToken(studentpostal);
                studentpropCount++;
            }

            if (studentprinSuper != null)
            {
                student["prinSuper"] = CSharpExpressionConverter.ConvertToken(studentprinSuper);
                studentpropCount++;
            }

            if (studentprinSuperEmail != null)
            {
                student["prinSuperEmail"] = CSharpExpressionConverter.ConvertToken(studentprinSuperEmail);
                studentpropCount++;
            }

            if (studentprinSuperEmployeeId != null)
            {
                student["prinSuperEmployeeId"] = CSharpExpressionConverter.ConvertToken(studentprinSuperEmployeeId);
                studentpropCount++;
            }

            if (studentsex != null)
            {
                student["sex"] = CSharpExpressionConverter.ConvertToken(studentsex);
                studentpropCount++;
            }

            if (studentstartDate != null)
            {
                student["startDate"] = CSharpExpressionConverter.ConvertToken(studentstartDate);
                studentpropCount++;
            }

            if (studentstudentFeesClass != null)
            {
                student["studentFeesClass"] = CSharpExpressionConverter.ConvertToken(studentstudentFeesClass);
                studentpropCount++;
            }

            if (studentstudyYear != null)
            {
                student["studyYear"] = CSharpExpressionConverter.ConvertToken(studentstudyYear);
                studentpropCount++;
            }

            if (studentsubject != null)
            {
                student["subject"] = CSharpExpressionConverter.ConvertToken(studentsubject);
                studentpropCount++;
            }

            if (studentsubjectDescr != null)
            {
                student["subjectDescr"] = CSharpExpressionConverter.ConvertToken(studentsubjectDescr);
                studentpropCount++;
            }

            if (studentsuperEmail != null)
            {
                student["superEmail"] = CSharpExpressionConverter.ConvertToken(studentsuperEmail);
                studentpropCount++;
            }

            if (studentsurname != null)
            {
                student["surname"] = CSharpExpressionConverter.ConvertToken(studentsurname);
                studentpropCount++;
            }

            if (studenttitle != null)
            {
                student["title"] = CSharpExpressionConverter.ConvertToken(studenttitle);
                studentpropCount++;
            }

            if (studenttutor != null)
            {
                student["tutor"] = CSharpExpressionConverter.ConvertToken(studenttutor);
                studentpropCount++;
            }

            if (studenttutorEmail != null)
            {
                student["tutorEmail"] = CSharpExpressionConverter.ConvertToken(studenttutorEmail);
                studentpropCount++;
            }

            if (studenttutorEmployeeId != null)
            {
                student["tutorEmployeeId"] = CSharpExpressionConverter.ConvertToken(studenttutorEmployeeId);
                studentpropCount++;
            }

            if (studentpropCount > 0)
            {
                callPayload.Body = student;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "casper365")]
        public IBodyWorkflowAction<bool> StudentIsBrowserAppGet()
        {
            var apiCallPath = "/Student/IsBrowserApp";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<bool>(callPayload);
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