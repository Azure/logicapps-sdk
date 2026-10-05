//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Casper365
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Casper365Actions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "casper365")]
        [WorkflowExpressionFactory(nameof(__BuildCourseGet))]
        public IBodyWorkflowAction<Course[]> CourseGet([WorkflowExpression] Func<string> course = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Course[]> __BuildCourseGet(WorkflowValue<string> course = null)
        {
            WorkflowValue.Validate(course, nameof(course), required: false);
            return new DeferredBodyAction<Course[]>(() =>
            {
                var apiCallPath = "/Course";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (course != null)
                    callPayload.Queries["course"] = ExpressionConverter.Convert(course);
                return new ApiConnectionAction<Course[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "casper365")]
        [WorkflowExpressionFactory(nameof(__BuildCourse))]
        public IBodyWorkflowAction<bool> Course([WorkflowExpression] Func<string> courseaudience = null, [WorkflowExpression] Func<string> coursecourseName = null, [WorkflowExpression] Func<string> coursedos = null, [WorkflowExpression] Func<string> courseemail = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<bool> __BuildCourse(WorkflowValue<string> courseaudience = null, WorkflowValue<string> coursecourseName = null, WorkflowValue<string> coursedos = null, WorkflowValue<string> courseemail = null)
        {
            WorkflowValue.Validate(courseaudience, nameof(courseaudience), required: false);
            WorkflowValue.Validate(coursecourseName, nameof(coursecourseName), required: false);
            WorkflowValue.Validate(coursedos, nameof(coursedos), required: false);
            WorkflowValue.Validate(courseemail, nameof(courseemail), required: false);
            return new DeferredBodyAction<bool>(() =>
            {
                var apiCallPath = "/Course";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var course = new JObject();
                var coursepropCount = 0;
                if (courseaudience != null)
                {
                    course["audience"] = ExpressionConverter.ConvertO(courseaudience);
                    coursepropCount++;
                }

                if (coursecourseName != null)
                {
                    course["courseName"] = ExpressionConverter.ConvertO(coursecourseName);
                    coursepropCount++;
                }

                if (coursedos != null)
                {
                    course["dos"] = ExpressionConverter.ConvertO(coursedos);
                    coursepropCount++;
                }

                if (courseemail != null)
                {
                    course["email"] = ExpressionConverter.ConvertO(courseemail);
                    coursepropCount++;
                }

                if (coursepropCount > 0)
                {
                    callPayload.Body = course;
                }

                return new ApiConnectionAction<bool>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "casper365")]
        [WorkflowExpressionFactory(nameof(__BuildLogEnd))]
        public IWorkflowAction LogEnd([WorkflowExpression] Func<string> identifier = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildLogEnd(WorkflowValue<string> identifier = null)
        {
            WorkflowValue.Validate(identifier, nameof(identifier), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/Log/End";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (identifier != null)
                    callPayload.Queries["identifier"] = ExpressionConverter.Convert(identifier);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "casper365")]
        [WorkflowExpressionFactory(nameof(__BuildLogStart))]
        public IWorkflowAction LogStart([WorkflowExpression] Func<string> identifier = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildLogStart(WorkflowValue<string> identifier = null)
        {
            WorkflowValue.Validate(identifier, nameof(identifier), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/Log/Start";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (identifier != null)
                    callPayload.Queries["identifier"] = ExpressionConverter.Convert(identifier);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "casper365")]
        [WorkflowExpressionFactory(nameof(__BuildStudentGet))]
        public IBodyWorkflowAction<Student> StudentGet([WorkflowExpression] Func<string> studentId = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Student> __BuildStudentGet(WorkflowValue<string> studentId = null)
        {
            WorkflowValue.Validate(studentId, nameof(studentId), required: false);
            return new DeferredBodyAction<Student>(() =>
            {
                var apiCallPath = "/Student";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (studentId != null)
                    callPayload.Queries["studentId"] = ExpressionConverter.Convert(studentId);
                return new ApiConnectionAction<Student>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "casper365")]
        [WorkflowExpressionFactory(nameof(__BuildStudent))]
        public IWorkflowAction Student([WorkflowExpression] Func<string> studentacadCareer = null, [WorkflowExpression] Func<string> studentacadOrgDescr = null, [WorkflowExpression] Func<string> studentacadProgram = null, [WorkflowExpression] Func<string> studentaddress1 = null, [WorkflowExpression] Func<string> studentaddress2 = null, [WorkflowExpression] Func<string> studentaddress3 = null, [WorkflowExpression] Func<string> studentaddress4 = null, [WorkflowExpression] Func<string> studentbarcode = null, [WorkflowExpression] Func<string> studentbirthCountryCode = null, [WorkflowExpression] Func<string> studentcellTel = null, [WorkflowExpression] Func<string> studentcity = null, [WorkflowExpression] Func<double> studentcollegeAccountNo = null, [WorkflowExpression] Func<string> studentcountry = null, [WorkflowExpression] Func<string> studentcountryCitizen = null, [WorkflowExpression] Func<string> studentcountryCitizen2 = null, [WorkflowExpression] Func<string> studentcrsid = null, [WorkflowExpression] Func<string> studentdegree = null, [WorkflowExpression] Func<string> studentdob = null, [WorkflowExpression] Func<string> studentdos = null, [WorkflowExpression] Func<string> studentdosEmail = null, [WorkflowExpression] Func<string> studentdosEmployeeId = null, [WorkflowExpression] Func<string> studentemail = null, [WorkflowExpression] Func<string> studentemailAddr = null, [WorkflowExpression] Func<string> studentemailPersonal = null, [WorkflowExpression] Func<string> studentendDate = null, [WorkflowExpression] Func<string> studentenqGrp = null, [WorkflowExpression] Func<string> studentfirstNames = null, [WorkflowExpression] Func<string> studentgradTutor = null, [WorkflowExpression] Func<string> studentgradTutorEmail = null, [WorkflowExpression] Func<string> studentgradTutorEmployeeId = null, [WorkflowExpression] Func<string> studentgrp = null, [WorkflowExpression] Func<string> studentgrpId = null, [WorkflowExpression] Func<string> studenthomeAddress1 = null, [WorkflowExpression] Func<string> studenthomeAddress2 = null, [WorkflowExpression] Func<string> studenthomeAddress3 = null, [WorkflowExpression] Func<string> studenthomeAddress4 = null, [WorkflowExpression] Func<string> studenthomeAddress5 = null, [WorkflowExpression] Func<string> studenthomeCountry = null, [WorkflowExpression] Func<string> studenthomePostal = null, [WorkflowExpression] Func<string> studenthomeState = null, [WorkflowExpression] Func<string> studenthomeTel = null, [WorkflowExpression] Func<string> studentmatriculation = null, [WorkflowExpression] Func<string> studentmobileTel = null, [WorkflowExpression] Func<string> studentnationality = null, [WorkflowExpression] Func<string> studentpostal = null, [WorkflowExpression] Func<string> studentprinSuper = null, [WorkflowExpression] Func<string> studentprinSuperEmail = null, [WorkflowExpression] Func<string> studentprinSuperEmployeeId = null, [WorkflowExpression] Func<string> studentsex = null, [WorkflowExpression] Func<string> studentstartDate = null, [WorkflowExpression] Func<string> studentstudentFeesClass = null, [WorkflowExpression] Func<string> studentstudyYear = null, [WorkflowExpression] Func<string> studentsubject = null, [WorkflowExpression] Func<string> studentsubjectDescr = null, [WorkflowExpression] Func<string> studentsuperEmail = null, [WorkflowExpression] Func<string> studentsurname = null, [WorkflowExpression] Func<string> studenttitle = null, [WorkflowExpression] Func<string> studenttutor = null, [WorkflowExpression] Func<string> studenttutorEmail = null, [WorkflowExpression] Func<string> studenttutorEmployeeId = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildStudent(WorkflowValue<string> studentacadCareer = null, WorkflowValue<string> studentacadOrgDescr = null, WorkflowValue<string> studentacadProgram = null, WorkflowValue<string> studentaddress1 = null, WorkflowValue<string> studentaddress2 = null, WorkflowValue<string> studentaddress3 = null, WorkflowValue<string> studentaddress4 = null, WorkflowValue<string> studentbarcode = null, WorkflowValue<string> studentbirthCountryCode = null, WorkflowValue<string> studentcellTel = null, WorkflowValue<string> studentcity = null, WorkflowValue<double> studentcollegeAccountNo = null, WorkflowValue<string> studentcountry = null, WorkflowValue<string> studentcountryCitizen = null, WorkflowValue<string> studentcountryCitizen2 = null, WorkflowValue<string> studentcrsid = null, WorkflowValue<string> studentdegree = null, WorkflowValue<string> studentdob = null, WorkflowValue<string> studentdos = null, WorkflowValue<string> studentdosEmail = null, WorkflowValue<string> studentdosEmployeeId = null, WorkflowValue<string> studentemail = null, WorkflowValue<string> studentemailAddr = null, WorkflowValue<string> studentemailPersonal = null, WorkflowValue<string> studentendDate = null, WorkflowValue<string> studentenqGrp = null, WorkflowValue<string> studentfirstNames = null, WorkflowValue<string> studentgradTutor = null, WorkflowValue<string> studentgradTutorEmail = null, WorkflowValue<string> studentgradTutorEmployeeId = null, WorkflowValue<string> studentgrp = null, WorkflowValue<string> studentgrpId = null, WorkflowValue<string> studenthomeAddress1 = null, WorkflowValue<string> studenthomeAddress2 = null, WorkflowValue<string> studenthomeAddress3 = null, WorkflowValue<string> studenthomeAddress4 = null, WorkflowValue<string> studenthomeAddress5 = null, WorkflowValue<string> studenthomeCountry = null, WorkflowValue<string> studenthomePostal = null, WorkflowValue<string> studenthomeState = null, WorkflowValue<string> studenthomeTel = null, WorkflowValue<string> studentmatriculation = null, WorkflowValue<string> studentmobileTel = null, WorkflowValue<string> studentnationality = null, WorkflowValue<string> studentpostal = null, WorkflowValue<string> studentprinSuper = null, WorkflowValue<string> studentprinSuperEmail = null, WorkflowValue<string> studentprinSuperEmployeeId = null, WorkflowValue<string> studentsex = null, WorkflowValue<string> studentstartDate = null, WorkflowValue<string> studentstudentFeesClass = null, WorkflowValue<string> studentstudyYear = null, WorkflowValue<string> studentsubject = null, WorkflowValue<string> studentsubjectDescr = null, WorkflowValue<string> studentsuperEmail = null, WorkflowValue<string> studentsurname = null, WorkflowValue<string> studenttitle = null, WorkflowValue<string> studenttutor = null, WorkflowValue<string> studenttutorEmail = null, WorkflowValue<string> studenttutorEmployeeId = null)
        {
            WorkflowValue.Validate(studentacadCareer, nameof(studentacadCareer), required: false);
            WorkflowValue.Validate(studentacadOrgDescr, nameof(studentacadOrgDescr), required: false);
            WorkflowValue.Validate(studentacadProgram, nameof(studentacadProgram), required: false);
            WorkflowValue.Validate(studentaddress1, nameof(studentaddress1), required: false);
            WorkflowValue.Validate(studentaddress2, nameof(studentaddress2), required: false);
            WorkflowValue.Validate(studentaddress3, nameof(studentaddress3), required: false);
            WorkflowValue.Validate(studentaddress4, nameof(studentaddress4), required: false);
            WorkflowValue.Validate(studentbarcode, nameof(studentbarcode), required: false);
            WorkflowValue.Validate(studentbirthCountryCode, nameof(studentbirthCountryCode), required: false);
            WorkflowValue.Validate(studentcellTel, nameof(studentcellTel), required: false);
            WorkflowValue.Validate(studentcity, nameof(studentcity), required: false);
            WorkflowValue.Validate(studentcollegeAccountNo, nameof(studentcollegeAccountNo), required: false);
            WorkflowValue.Validate(studentcountry, nameof(studentcountry), required: false);
            WorkflowValue.Validate(studentcountryCitizen, nameof(studentcountryCitizen), required: false);
            WorkflowValue.Validate(studentcountryCitizen2, nameof(studentcountryCitizen2), required: false);
            WorkflowValue.Validate(studentcrsid, nameof(studentcrsid), required: false);
            WorkflowValue.Validate(studentdegree, nameof(studentdegree), required: false);
            WorkflowValue.Validate(studentdob, nameof(studentdob), required: false);
            WorkflowValue.Validate(studentdos, nameof(studentdos), required: false);
            WorkflowValue.Validate(studentdosEmail, nameof(studentdosEmail), required: false);
            WorkflowValue.Validate(studentdosEmployeeId, nameof(studentdosEmployeeId), required: false);
            WorkflowValue.Validate(studentemail, nameof(studentemail), required: false);
            WorkflowValue.Validate(studentemailAddr, nameof(studentemailAddr), required: false);
            WorkflowValue.Validate(studentemailPersonal, nameof(studentemailPersonal), required: false);
            WorkflowValue.Validate(studentendDate, nameof(studentendDate), required: false);
            WorkflowValue.Validate(studentenqGrp, nameof(studentenqGrp), required: false);
            WorkflowValue.Validate(studentfirstNames, nameof(studentfirstNames), required: false);
            WorkflowValue.Validate(studentgradTutor, nameof(studentgradTutor), required: false);
            WorkflowValue.Validate(studentgradTutorEmail, nameof(studentgradTutorEmail), required: false);
            WorkflowValue.Validate(studentgradTutorEmployeeId, nameof(studentgradTutorEmployeeId), required: false);
            WorkflowValue.Validate(studentgrp, nameof(studentgrp), required: false);
            WorkflowValue.Validate(studentgrpId, nameof(studentgrpId), required: false);
            WorkflowValue.Validate(studenthomeAddress1, nameof(studenthomeAddress1), required: false);
            WorkflowValue.Validate(studenthomeAddress2, nameof(studenthomeAddress2), required: false);
            WorkflowValue.Validate(studenthomeAddress3, nameof(studenthomeAddress3), required: false);
            WorkflowValue.Validate(studenthomeAddress4, nameof(studenthomeAddress4), required: false);
            WorkflowValue.Validate(studenthomeAddress5, nameof(studenthomeAddress5), required: false);
            WorkflowValue.Validate(studenthomeCountry, nameof(studenthomeCountry), required: false);
            WorkflowValue.Validate(studenthomePostal, nameof(studenthomePostal), required: false);
            WorkflowValue.Validate(studenthomeState, nameof(studenthomeState), required: false);
            WorkflowValue.Validate(studenthomeTel, nameof(studenthomeTel), required: false);
            WorkflowValue.Validate(studentmatriculation, nameof(studentmatriculation), required: false);
            WorkflowValue.Validate(studentmobileTel, nameof(studentmobileTel), required: false);
            WorkflowValue.Validate(studentnationality, nameof(studentnationality), required: false);
            WorkflowValue.Validate(studentpostal, nameof(studentpostal), required: false);
            WorkflowValue.Validate(studentprinSuper, nameof(studentprinSuper), required: false);
            WorkflowValue.Validate(studentprinSuperEmail, nameof(studentprinSuperEmail), required: false);
            WorkflowValue.Validate(studentprinSuperEmployeeId, nameof(studentprinSuperEmployeeId), required: false);
            WorkflowValue.Validate(studentsex, nameof(studentsex), required: false);
            WorkflowValue.Validate(studentstartDate, nameof(studentstartDate), required: false);
            WorkflowValue.Validate(studentstudentFeesClass, nameof(studentstudentFeesClass), required: false);
            WorkflowValue.Validate(studentstudyYear, nameof(studentstudyYear), required: false);
            WorkflowValue.Validate(studentsubject, nameof(studentsubject), required: false);
            WorkflowValue.Validate(studentsubjectDescr, nameof(studentsubjectDescr), required: false);
            WorkflowValue.Validate(studentsuperEmail, nameof(studentsuperEmail), required: false);
            WorkflowValue.Validate(studentsurname, nameof(studentsurname), required: false);
            WorkflowValue.Validate(studenttitle, nameof(studenttitle), required: false);
            WorkflowValue.Validate(studenttutor, nameof(studenttutor), required: false);
            WorkflowValue.Validate(studenttutorEmail, nameof(studenttutorEmail), required: false);
            WorkflowValue.Validate(studenttutorEmployeeId, nameof(studenttutorEmployeeId), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/Student";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var student = new JObject();
                var studentpropCount = 0;
                if (studentacadCareer != null)
                {
                    student["acadCareer"] = ExpressionConverter.ConvertO(studentacadCareer);
                    studentpropCount++;
                }

                if (studentacadOrgDescr != null)
                {
                    student["acadOrgDescr"] = ExpressionConverter.ConvertO(studentacadOrgDescr);
                    studentpropCount++;
                }

                if (studentacadProgram != null)
                {
                    student["acadProgram"] = ExpressionConverter.ConvertO(studentacadProgram);
                    studentpropCount++;
                }

                if (studentaddress1 != null)
                {
                    student["address1"] = ExpressionConverter.ConvertO(studentaddress1);
                    studentpropCount++;
                }

                if (studentaddress2 != null)
                {
                    student["address2"] = ExpressionConverter.ConvertO(studentaddress2);
                    studentpropCount++;
                }

                if (studentaddress3 != null)
                {
                    student["address3"] = ExpressionConverter.ConvertO(studentaddress3);
                    studentpropCount++;
                }

                if (studentaddress4 != null)
                {
                    student["address4"] = ExpressionConverter.ConvertO(studentaddress4);
                    studentpropCount++;
                }

                if (studentbarcode != null)
                {
                    student["barcode"] = ExpressionConverter.ConvertO(studentbarcode);
                    studentpropCount++;
                }

                if (studentbirthCountryCode != null)
                {
                    student["birthCountryCode"] = ExpressionConverter.ConvertO(studentbirthCountryCode);
                    studentpropCount++;
                }

                if (studentcellTel != null)
                {
                    student["cellTel"] = ExpressionConverter.ConvertO(studentcellTel);
                    studentpropCount++;
                }

                if (studentcity != null)
                {
                    student["city"] = ExpressionConverter.ConvertO(studentcity);
                    studentpropCount++;
                }

                if (studentcollegeAccountNo != null)
                {
                    student["collegeAccountNo"] = ExpressionConverter.ConvertO(studentcollegeAccountNo);
                    studentpropCount++;
                }

                if (studentcountry != null)
                {
                    student["country"] = ExpressionConverter.ConvertO(studentcountry);
                    studentpropCount++;
                }

                if (studentcountryCitizen != null)
                {
                    student["countryCitizen"] = ExpressionConverter.ConvertO(studentcountryCitizen);
                    studentpropCount++;
                }

                if (studentcountryCitizen2 != null)
                {
                    student["countryCitizen2"] = ExpressionConverter.ConvertO(studentcountryCitizen2);
                    studentpropCount++;
                }

                if (studentcrsid != null)
                {
                    student["crsid"] = ExpressionConverter.ConvertO(studentcrsid);
                    studentpropCount++;
                }

                if (studentdegree != null)
                {
                    student["degree"] = ExpressionConverter.ConvertO(studentdegree);
                    studentpropCount++;
                }

                if (studentdob != null)
                {
                    student["dob"] = ExpressionConverter.ConvertO(studentdob);
                    studentpropCount++;
                }

                if (studentdos != null)
                {
                    student["dos"] = ExpressionConverter.ConvertO(studentdos);
                    studentpropCount++;
                }

                if (studentdosEmail != null)
                {
                    student["dosEmail"] = ExpressionConverter.ConvertO(studentdosEmail);
                    studentpropCount++;
                }

                if (studentdosEmployeeId != null)
                {
                    student["dosEmployeeId"] = ExpressionConverter.ConvertO(studentdosEmployeeId);
                    studentpropCount++;
                }

                if (studentemail != null)
                {
                    student["email"] = ExpressionConverter.ConvertO(studentemail);
                    studentpropCount++;
                }

                if (studentemailAddr != null)
                {
                    student["emailAddr"] = ExpressionConverter.ConvertO(studentemailAddr);
                    studentpropCount++;
                }

                if (studentemailPersonal != null)
                {
                    student["emailPersonal"] = ExpressionConverter.ConvertO(studentemailPersonal);
                    studentpropCount++;
                }

                if (studentendDate != null)
                {
                    student["endDate"] = ExpressionConverter.ConvertO(studentendDate);
                    studentpropCount++;
                }

                if (studentenqGrp != null)
                {
                    student["enqGrp"] = ExpressionConverter.ConvertO(studentenqGrp);
                    studentpropCount++;
                }

                if (studentfirstNames != null)
                {
                    student["firstNames"] = ExpressionConverter.ConvertO(studentfirstNames);
                    studentpropCount++;
                }

                if (studentgradTutor != null)
                {
                    student["gradTutor"] = ExpressionConverter.ConvertO(studentgradTutor);
                    studentpropCount++;
                }

                if (studentgradTutorEmail != null)
                {
                    student["gradTutorEmail"] = ExpressionConverter.ConvertO(studentgradTutorEmail);
                    studentpropCount++;
                }

                if (studentgradTutorEmployeeId != null)
                {
                    student["gradTutorEmployeeId"] = ExpressionConverter.ConvertO(studentgradTutorEmployeeId);
                    studentpropCount++;
                }

                if (studentgrp != null)
                {
                    student["grp"] = ExpressionConverter.ConvertO(studentgrp);
                    studentpropCount++;
                }

                if (studentgrpId != null)
                {
                    student["grpId"] = ExpressionConverter.ConvertO(studentgrpId);
                    studentpropCount++;
                }

                if (studenthomeAddress1 != null)
                {
                    student["homeAddress1"] = ExpressionConverter.ConvertO(studenthomeAddress1);
                    studentpropCount++;
                }

                if (studenthomeAddress2 != null)
                {
                    student["homeAddress2"] = ExpressionConverter.ConvertO(studenthomeAddress2);
                    studentpropCount++;
                }

                if (studenthomeAddress3 != null)
                {
                    student["homeAddress3"] = ExpressionConverter.ConvertO(studenthomeAddress3);
                    studentpropCount++;
                }

                if (studenthomeAddress4 != null)
                {
                    student["homeAddress4"] = ExpressionConverter.ConvertO(studenthomeAddress4);
                    studentpropCount++;
                }

                if (studenthomeAddress5 != null)
                {
                    student["homeAddress5"] = ExpressionConverter.ConvertO(studenthomeAddress5);
                    studentpropCount++;
                }

                if (studenthomeCountry != null)
                {
                    student["homeCountry"] = ExpressionConverter.ConvertO(studenthomeCountry);
                    studentpropCount++;
                }

                if (studenthomePostal != null)
                {
                    student["homePostal"] = ExpressionConverter.ConvertO(studenthomePostal);
                    studentpropCount++;
                }

                if (studenthomeState != null)
                {
                    student["homeState"] = ExpressionConverter.ConvertO(studenthomeState);
                    studentpropCount++;
                }

                if (studenthomeTel != null)
                {
                    student["homeTel"] = ExpressionConverter.ConvertO(studenthomeTel);
                    studentpropCount++;
                }

                if (studentmatriculation != null)
                {
                    student["matriculation"] = ExpressionConverter.ConvertO(studentmatriculation);
                    studentpropCount++;
                }

                if (studentmobileTel != null)
                {
                    student["mobileTel"] = ExpressionConverter.ConvertO(studentmobileTel);
                    studentpropCount++;
                }

                if (studentnationality != null)
                {
                    student["nationality"] = ExpressionConverter.ConvertO(studentnationality);
                    studentpropCount++;
                }

                if (studentpostal != null)
                {
                    student["postal"] = ExpressionConverter.ConvertO(studentpostal);
                    studentpropCount++;
                }

                if (studentprinSuper != null)
                {
                    student["prinSuper"] = ExpressionConverter.ConvertO(studentprinSuper);
                    studentpropCount++;
                }

                if (studentprinSuperEmail != null)
                {
                    student["prinSuperEmail"] = ExpressionConverter.ConvertO(studentprinSuperEmail);
                    studentpropCount++;
                }

                if (studentprinSuperEmployeeId != null)
                {
                    student["prinSuperEmployeeId"] = ExpressionConverter.ConvertO(studentprinSuperEmployeeId);
                    studentpropCount++;
                }

                if (studentsex != null)
                {
                    student["sex"] = ExpressionConverter.ConvertO(studentsex);
                    studentpropCount++;
                }

                if (studentstartDate != null)
                {
                    student["startDate"] = ExpressionConverter.ConvertO(studentstartDate);
                    studentpropCount++;
                }

                if (studentstudentFeesClass != null)
                {
                    student["studentFeesClass"] = ExpressionConverter.ConvertO(studentstudentFeesClass);
                    studentpropCount++;
                }

                if (studentstudyYear != null)
                {
                    student["studyYear"] = ExpressionConverter.ConvertO(studentstudyYear);
                    studentpropCount++;
                }

                if (studentsubject != null)
                {
                    student["subject"] = ExpressionConverter.ConvertO(studentsubject);
                    studentpropCount++;
                }

                if (studentsubjectDescr != null)
                {
                    student["subjectDescr"] = ExpressionConverter.ConvertO(studentsubjectDescr);
                    studentpropCount++;
                }

                if (studentsuperEmail != null)
                {
                    student["superEmail"] = ExpressionConverter.ConvertO(studentsuperEmail);
                    studentpropCount++;
                }

                if (studentsurname != null)
                {
                    student["surname"] = ExpressionConverter.ConvertO(studentsurname);
                    studentpropCount++;
                }

                if (studenttitle != null)
                {
                    student["title"] = ExpressionConverter.ConvertO(studenttitle);
                    studentpropCount++;
                }

                if (studenttutor != null)
                {
                    student["tutor"] = ExpressionConverter.ConvertO(studenttutor);
                    studentpropCount++;
                }

                if (studenttutorEmail != null)
                {
                    student["tutorEmail"] = ExpressionConverter.ConvertO(studenttutorEmail);
                    studentpropCount++;
                }

                if (studenttutorEmployeeId != null)
                {
                    student["tutorEmployeeId"] = ExpressionConverter.ConvertO(studenttutorEmployeeId);
                    studentpropCount++;
                }

                if (studentpropCount > 0)
                {
                    callPayload.Body = student;
                }

                return new ApiConnectionAction(callPayload);
            });
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
