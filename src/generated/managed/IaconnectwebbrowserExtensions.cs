//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Iaconnectwebbrowser
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class IaconnectwebbrowserActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserGetChromeBrowserVersionFromFileResponse> BrowserGetChromeBrowserVersionFromFile(Expression<Func<string>> browserGetChromeBrowserVersionFromFileworkflow, Expression<Func<string>> browserGetChromeBrowserVersionFromFilechromeBrowserEXE = null)
        {
            var __workflow_browserGetChromeBrowserVersionFromFileworkflow = WorkflowExpression.Compile(browserGetChromeBrowserVersionFromFileworkflow, nameof(browserGetChromeBrowserVersionFromFileworkflow), required: true);
            var __workflow_browserGetChromeBrowserVersionFromFilechromeBrowserEXE = WorkflowExpression.Compile(browserGetChromeBrowserVersionFromFilechromeBrowserEXE, nameof(browserGetChromeBrowserVersionFromFilechromeBrowserEXE), required: false);
            return new DeferredBodyAction<BrowserGetChromeBrowserVersionFromFileResponse>(() =>
            {
                var apiCallPath = "/BrowserControl/GetChromeBrowserVersionFromFile";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserGetChromeBrowserVersionFromFile = new JObject();
                var browserGetChromeBrowserVersionFromFilepropCount = 0;
                if (__workflow_browserGetChromeBrowserVersionFromFilechromeBrowserEXE != null)
                {
                    browserGetChromeBrowserVersionFromFile["ChromeBrowserEXE"] = ExpressionConverter.ConvertO(__workflow_browserGetChromeBrowserVersionFromFilechromeBrowserEXE);
                    browserGetChromeBrowserVersionFromFilepropCount++;
                }

                browserGetChromeBrowserVersionFromFilepropCount++;
                browserGetChromeBrowserVersionFromFile["Workflow"] = ExpressionConverter.ConvertO(__workflow_browserGetChromeBrowserVersionFromFileworkflow);
                if (browserGetChromeBrowserVersionFromFilepropCount > 0)
                {
                    callPayload.Body = browserGetChromeBrowserVersionFromFile;
                }

                return new ApiConnectionAction<BrowserGetChromeBrowserVersionFromFileResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserGetChromeDriverFolderResponse> BrowserGetChromeDriverFolder(Expression<Func<string>> browserGetChromeDriverFolderdirectoryPath, Expression<Func<string>> browserGetChromeDriverFolderworkflow, Expression<Func<int>> browserGetChromeDriverFolderchromeMajorVersion = null, Expression<Func<string>> browserGetChromeDriverFolderchromeBrowserEXE = null)
        {
            var __workflow_browserGetChromeDriverFolderdirectoryPath = WorkflowExpression.Compile(browserGetChromeDriverFolderdirectoryPath, nameof(browserGetChromeDriverFolderdirectoryPath), required: true);
            var __workflow_browserGetChromeDriverFolderworkflow = WorkflowExpression.Compile(browserGetChromeDriverFolderworkflow, nameof(browserGetChromeDriverFolderworkflow), required: true);
            var __workflow_browserGetChromeDriverFolderchromeMajorVersion = WorkflowExpression.Compile(browserGetChromeDriverFolderchromeMajorVersion, nameof(browserGetChromeDriverFolderchromeMajorVersion), required: false);
            var __workflow_browserGetChromeDriverFolderchromeBrowserEXE = WorkflowExpression.Compile(browserGetChromeDriverFolderchromeBrowserEXE, nameof(browserGetChromeDriverFolderchromeBrowserEXE), required: false);
            return new DeferredBodyAction<BrowserGetChromeDriverFolderResponse>(() =>
            {
                var apiCallPath = "/BrowserControl/GetChromeDriverFolder";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserGetChromeDriverFolder = new JObject();
                var browserGetChromeDriverFolderpropCount = 0;
                browserGetChromeDriverFolderpropCount++;
                browserGetChromeDriverFolder["DirectoryPath"] = ExpressionConverter.ConvertO(__workflow_browserGetChromeDriverFolderdirectoryPath);
                if (__workflow_browserGetChromeDriverFolderchromeMajorVersion != null)
                {
                    browserGetChromeDriverFolder["ChromeMajorVersion"] = ExpressionConverter.ConvertO(__workflow_browserGetChromeDriverFolderchromeMajorVersion);
                    browserGetChromeDriverFolderpropCount++;
                }

                if (__workflow_browserGetChromeDriverFolderchromeBrowserEXE != null)
                {
                    browserGetChromeDriverFolder["ChromeBrowserEXE"] = ExpressionConverter.ConvertO(__workflow_browserGetChromeDriverFolderchromeBrowserEXE);
                    browserGetChromeDriverFolderpropCount++;
                }

                browserGetChromeDriverFolderpropCount++;
                browserGetChromeDriverFolder["Workflow"] = ExpressionConverter.ConvertO(__workflow_browserGetChromeDriverFolderworkflow);
                if (browserGetChromeDriverFolderpropCount > 0)
                {
                    callPayload.Body = browserGetChromeDriverFolder;
                }

                return new ApiConnectionAction<BrowserGetChromeDriverFolderResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserDownloadSuitableChromeDriverFromInternetResponse> BrowserDownloadSuitableChromeDriverFromInternet(Expression<Func<string>> browserDownloadSuitableChromeDriverFromInternetchromeDriverDownloadParentFolder, Expression<Func<string>> browserDownloadSuitableChromeDriverFromInternetworkflow, Expression<Func<string>> browserDownloadSuitableChromeDriverFromInternetchromeBrowserEXE = null, Expression<Func<bool>> browserDownloadSuitableChromeDriverFromInternetattemptToLocateChromeDriverURLViaXMLIndex = null, Expression<Func<string>> browserDownloadSuitableChromeDriverFromInternetchromeDriverRootWebPageURL = null, Expression<Func<bool>> browserDownloadSuitableChromeDriverFromInternetattemptToLocateChromeDriverURLViaJSONIndex = null, Expression<Func<string>> browserDownloadSuitableChromeDriverFromInternetchromeDriverJSONIndexWebPageURL = null, Expression<Func<bool>> browserDownloadSuitableChromeDriverFromInternetprefer64bitChromeDriver = null)
        {
            var __workflow_browserDownloadSuitableChromeDriverFromInternetchromeDriverDownloadParentFolder = WorkflowExpression.Compile(browserDownloadSuitableChromeDriverFromInternetchromeDriverDownloadParentFolder, nameof(browserDownloadSuitableChromeDriverFromInternetchromeDriverDownloadParentFolder), required: true);
            var __workflow_browserDownloadSuitableChromeDriverFromInternetworkflow = WorkflowExpression.Compile(browserDownloadSuitableChromeDriverFromInternetworkflow, nameof(browserDownloadSuitableChromeDriverFromInternetworkflow), required: true);
            var __workflow_browserDownloadSuitableChromeDriverFromInternetchromeBrowserEXE = WorkflowExpression.Compile(browserDownloadSuitableChromeDriverFromInternetchromeBrowserEXE, nameof(browserDownloadSuitableChromeDriverFromInternetchromeBrowserEXE), required: false);
            var __workflow_browserDownloadSuitableChromeDriverFromInternetattemptToLocateChromeDriverURLViaXMLIndex = WorkflowExpression.Compile(browserDownloadSuitableChromeDriverFromInternetattemptToLocateChromeDriverURLViaXMLIndex, nameof(browserDownloadSuitableChromeDriverFromInternetattemptToLocateChromeDriverURLViaXMLIndex), required: false);
            var __workflow_browserDownloadSuitableChromeDriverFromInternetchromeDriverRootWebPageURL = WorkflowExpression.Compile(browserDownloadSuitableChromeDriverFromInternetchromeDriverRootWebPageURL, nameof(browserDownloadSuitableChromeDriverFromInternetchromeDriverRootWebPageURL), required: false);
            var __workflow_browserDownloadSuitableChromeDriverFromInternetattemptToLocateChromeDriverURLViaJSONIndex = WorkflowExpression.Compile(browserDownloadSuitableChromeDriverFromInternetattemptToLocateChromeDriverURLViaJSONIndex, nameof(browserDownloadSuitableChromeDriverFromInternetattemptToLocateChromeDriverURLViaJSONIndex), required: false);
            var __workflow_browserDownloadSuitableChromeDriverFromInternetchromeDriverJSONIndexWebPageURL = WorkflowExpression.Compile(browserDownloadSuitableChromeDriverFromInternetchromeDriverJSONIndexWebPageURL, nameof(browserDownloadSuitableChromeDriverFromInternetchromeDriverJSONIndexWebPageURL), required: false);
            var __workflow_browserDownloadSuitableChromeDriverFromInternetprefer64bitChromeDriver = WorkflowExpression.Compile(browserDownloadSuitableChromeDriverFromInternetprefer64bitChromeDriver, nameof(browserDownloadSuitableChromeDriverFromInternetprefer64bitChromeDriver), required: false);
            return new DeferredBodyAction<BrowserDownloadSuitableChromeDriverFromInternetResponse>(() =>
            {
                var apiCallPath = "/BrowserControl/BrowserDownloadSuitableChromeDriverFromInternet";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserDownloadSuitableChromeDriverFromInternet = new JObject();
                var browserDownloadSuitableChromeDriverFromInternetpropCount = 0;
                if (__workflow_browserDownloadSuitableChromeDriverFromInternetchromeBrowserEXE != null)
                {
                    browserDownloadSuitableChromeDriverFromInternet["ChromeBrowserEXE"] = ExpressionConverter.ConvertO(__workflow_browserDownloadSuitableChromeDriverFromInternetchromeBrowserEXE);
                    browserDownloadSuitableChromeDriverFromInternetpropCount++;
                }

                browserDownloadSuitableChromeDriverFromInternetpropCount++;
                browserDownloadSuitableChromeDriverFromInternet["ChromeDriverDownloadParentFolder"] = ExpressionConverter.ConvertO(__workflow_browserDownloadSuitableChromeDriverFromInternetchromeDriverDownloadParentFolder);
                if (__workflow_browserDownloadSuitableChromeDriverFromInternetattemptToLocateChromeDriverURLViaXMLIndex != null)
                {
                    if (__workflow_browserDownloadSuitableChromeDriverFromInternetattemptToLocateChromeDriverURLViaXMLIndex != null)
                    {
                        browserDownloadSuitableChromeDriverFromInternet["AttemptToLocateChromeDriverURLViaXMLIndex"] = ExpressionConverter.ConvertO(__workflow_browserDownloadSuitableChromeDriverFromInternetattemptToLocateChromeDriverURLViaXMLIndex);
                        browserDownloadSuitableChromeDriverFromInternetpropCount++;
                    }

                    browserDownloadSuitableChromeDriverFromInternetpropCount++;
                }
                else
                {
                    browserDownloadSuitableChromeDriverFromInternet["AttemptToLocateChromeDriverURLViaXMLIndex"] = true;
                    browserDownloadSuitableChromeDriverFromInternetpropCount++;
                }

                if (__workflow_browserDownloadSuitableChromeDriverFromInternetchromeDriverRootWebPageURL != null)
                {
                    if (__workflow_browserDownloadSuitableChromeDriverFromInternetchromeDriverRootWebPageURL != null)
                    {
                        browserDownloadSuitableChromeDriverFromInternet["ChromeDriverRootWebPageURL"] = ExpressionConverter.ConvertO(__workflow_browserDownloadSuitableChromeDriverFromInternetchromeDriverRootWebPageURL);
                        browserDownloadSuitableChromeDriverFromInternetpropCount++;
                    }

                    browserDownloadSuitableChromeDriverFromInternetpropCount++;
                }
                else
                {
                    browserDownloadSuitableChromeDriverFromInternet["ChromeDriverRootWebPageURL"] = "https://chromedriver.storage.googleapis.com/";
                    browserDownloadSuitableChromeDriverFromInternetpropCount++;
                }

                if (__workflow_browserDownloadSuitableChromeDriverFromInternetattemptToLocateChromeDriverURLViaJSONIndex != null)
                {
                    if (__workflow_browserDownloadSuitableChromeDriverFromInternetattemptToLocateChromeDriverURLViaJSONIndex != null)
                    {
                        browserDownloadSuitableChromeDriverFromInternet["AttemptToLocateChromeDriverURLViaJSONIndex"] = ExpressionConverter.ConvertO(__workflow_browserDownloadSuitableChromeDriverFromInternetattemptToLocateChromeDriverURLViaJSONIndex);
                        browserDownloadSuitableChromeDriverFromInternetpropCount++;
                    }

                    browserDownloadSuitableChromeDriverFromInternetpropCount++;
                }
                else
                {
                    browserDownloadSuitableChromeDriverFromInternet["AttemptToLocateChromeDriverURLViaJSONIndex"] = true;
                    browserDownloadSuitableChromeDriverFromInternetpropCount++;
                }

                if (__workflow_browserDownloadSuitableChromeDriverFromInternetchromeDriverJSONIndexWebPageURL != null)
                {
                    if (__workflow_browserDownloadSuitableChromeDriverFromInternetchromeDriverJSONIndexWebPageURL != null)
                    {
                        browserDownloadSuitableChromeDriverFromInternet["ChromeDriverJSONIndexWebPageURL"] = ExpressionConverter.ConvertO(__workflow_browserDownloadSuitableChromeDriverFromInternetchromeDriverJSONIndexWebPageURL);
                        browserDownloadSuitableChromeDriverFromInternetpropCount++;
                    }

                    browserDownloadSuitableChromeDriverFromInternetpropCount++;
                }
                else
                {
                    browserDownloadSuitableChromeDriverFromInternet["ChromeDriverJSONIndexWebPageURL"] = "https://googlechromelabs.github.io/chrome-for-testing/latest-versions-per-milestone-with-downloads.json";
                    browserDownloadSuitableChromeDriverFromInternetpropCount++;
                }

                if (__workflow_browserDownloadSuitableChromeDriverFromInternetprefer64bitChromeDriver != null)
                {
                    if (__workflow_browserDownloadSuitableChromeDriverFromInternetprefer64bitChromeDriver != null)
                    {
                        browserDownloadSuitableChromeDriverFromInternet["Prefer64bitChromeDriver"] = ExpressionConverter.ConvertO(__workflow_browserDownloadSuitableChromeDriverFromInternetprefer64bitChromeDriver);
                        browserDownloadSuitableChromeDriverFromInternetpropCount++;
                    }

                    browserDownloadSuitableChromeDriverFromInternetpropCount++;
                }
                else
                {
                    browserDownloadSuitableChromeDriverFromInternet["Prefer64bitChromeDriver"] = false;
                    browserDownloadSuitableChromeDriverFromInternetpropCount++;
                }

                browserDownloadSuitableChromeDriverFromInternetpropCount++;
                browserDownloadSuitableChromeDriverFromInternet["Workflow"] = ExpressionConverter.ConvertO(__workflow_browserDownloadSuitableChromeDriverFromInternetworkflow);
                if (browserDownloadSuitableChromeDriverFromInternetpropCount > 0)
                {
                    callPayload.Body = browserDownloadSuitableChromeDriverFromInternet;
                }

                return new ApiConnectionAction<BrowserDownloadSuitableChromeDriverFromInternetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserIsSuitableChromeDriverAvailableResponse> BrowserIsSuitableChromeDriverAvailable(Expression<Func<string>> browserIsSuitableChromeDriverAvailableworkflow, Expression<Func<string>> browserIsSuitableChromeDriverAvailablechromeDriverFolder = null, Expression<Func<string>> browserIsSuitableChromeDriverAvailablechromeBrowserEXE = null)
        {
            var __workflow_browserIsSuitableChromeDriverAvailableworkflow = WorkflowExpression.Compile(browserIsSuitableChromeDriverAvailableworkflow, nameof(browserIsSuitableChromeDriverAvailableworkflow), required: true);
            var __workflow_browserIsSuitableChromeDriverAvailablechromeDriverFolder = WorkflowExpression.Compile(browserIsSuitableChromeDriverAvailablechromeDriverFolder, nameof(browserIsSuitableChromeDriverAvailablechromeDriverFolder), required: false);
            var __workflow_browserIsSuitableChromeDriverAvailablechromeBrowserEXE = WorkflowExpression.Compile(browserIsSuitableChromeDriverAvailablechromeBrowserEXE, nameof(browserIsSuitableChromeDriverAvailablechromeBrowserEXE), required: false);
            return new DeferredBodyAction<BrowserIsSuitableChromeDriverAvailableResponse>(() =>
            {
                var apiCallPath = "/BrowserControl/IsSuitableChromeDriverAvailable";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserIsSuitableChromeDriverAvailable = new JObject();
                var browserIsSuitableChromeDriverAvailablepropCount = 0;
                if (__workflow_browserIsSuitableChromeDriverAvailablechromeDriverFolder != null)
                {
                    browserIsSuitableChromeDriverAvailable["ChromeDriverFolder"] = ExpressionConverter.ConvertO(__workflow_browserIsSuitableChromeDriverAvailablechromeDriverFolder);
                    browserIsSuitableChromeDriverAvailablepropCount++;
                }

                if (__workflow_browserIsSuitableChromeDriverAvailablechromeBrowserEXE != null)
                {
                    browserIsSuitableChromeDriverAvailable["ChromeBrowserEXE"] = ExpressionConverter.ConvertO(__workflow_browserIsSuitableChromeDriverAvailablechromeBrowserEXE);
                    browserIsSuitableChromeDriverAvailablepropCount++;
                }

                browserIsSuitableChromeDriverAvailablepropCount++;
                browserIsSuitableChromeDriverAvailable["Workflow"] = ExpressionConverter.ConvertO(__workflow_browserIsSuitableChromeDriverAvailableworkflow);
                if (browserIsSuitableChromeDriverAvailablepropCount > 0)
                {
                    callPayload.Body = browserIsSuitableChromeDriverAvailable;
                }

                return new ApiConnectionAction<BrowserIsSuitableChromeDriverAvailableResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserUploadNewChromeDriver(Expression<Func<string>> browserUploadNewChromeDriverlocalChromeDriverFilePath, Expression<Func<string>> browserUploadNewChromeDriverworkflow, Expression<Func<bool>> browserUploadNewChromeDrivercompress = null, Expression<Func<int>> browserUploadNewChromeDriverchromeBrowserMajorVersion = null, Expression<Func<string>> browserUploadNewChromeDriverchromeDriverRootSaveFolder = null)
        {
            var __workflow_browserUploadNewChromeDriverlocalChromeDriverFilePath = WorkflowExpression.Compile(browserUploadNewChromeDriverlocalChromeDriverFilePath, nameof(browserUploadNewChromeDriverlocalChromeDriverFilePath), required: true);
            var __workflow_browserUploadNewChromeDriverworkflow = WorkflowExpression.Compile(browserUploadNewChromeDriverworkflow, nameof(browserUploadNewChromeDriverworkflow), required: true);
            var __workflow_browserUploadNewChromeDrivercompress = WorkflowExpression.Compile(browserUploadNewChromeDrivercompress, nameof(browserUploadNewChromeDrivercompress), required: false);
            var __workflow_browserUploadNewChromeDriverchromeBrowserMajorVersion = WorkflowExpression.Compile(browserUploadNewChromeDriverchromeBrowserMajorVersion, nameof(browserUploadNewChromeDriverchromeBrowserMajorVersion), required: false);
            var __workflow_browserUploadNewChromeDriverchromeDriverRootSaveFolder = WorkflowExpression.Compile(browserUploadNewChromeDriverchromeDriverRootSaveFolder, nameof(browserUploadNewChromeDriverchromeDriverRootSaveFolder), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/BrowserControl/UploadNewChromeDriver";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserUploadNewChromeDriver = new JObject();
                var browserUploadNewChromeDriverpropCount = 0;
                browserUploadNewChromeDriverpropCount++;
                browserUploadNewChromeDriver["LocalChromeDriverFilePath"] = ExpressionConverter.ConvertO(__workflow_browserUploadNewChromeDriverlocalChromeDriverFilePath);
                if (__workflow_browserUploadNewChromeDrivercompress != null)
                {
                    if (__workflow_browserUploadNewChromeDrivercompress != null)
                    {
                        browserUploadNewChromeDriver["Compress"] = ExpressionConverter.ConvertO(__workflow_browserUploadNewChromeDrivercompress);
                        browserUploadNewChromeDriverpropCount++;
                    }

                    browserUploadNewChromeDriverpropCount++;
                }
                else
                {
                    browserUploadNewChromeDriver["Compress"] = false;
                    browserUploadNewChromeDriverpropCount++;
                }

                if (__workflow_browserUploadNewChromeDriverchromeBrowserMajorVersion != null)
                {
                    browserUploadNewChromeDriver["ChromeBrowserMajorVersion"] = ExpressionConverter.ConvertO(__workflow_browserUploadNewChromeDriverchromeBrowserMajorVersion);
                    browserUploadNewChromeDriverpropCount++;
                }

                if (__workflow_browserUploadNewChromeDriverchromeDriverRootSaveFolder != null)
                {
                    browserUploadNewChromeDriver["ChromeDriverRootSaveFolder"] = ExpressionConverter.ConvertO(__workflow_browserUploadNewChromeDriverchromeDriverRootSaveFolder);
                    browserUploadNewChromeDriverpropCount++;
                }

                browserUploadNewChromeDriverpropCount++;
                browserUploadNewChromeDriver["Workflow"] = ExpressionConverter.ConvertO(__workflow_browserUploadNewChromeDriverworkflow);
                if (browserUploadNewChromeDriverpropCount > 0)
                {
                    callPayload.Body = browserUploadNewChromeDriver;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserOpenChromeResponse> BrowserOpenChrome(Expression<Func<string>> browserOpenChromeworkflow, Expression<Func<string>> browserOpenChromechromeDriverFolder = null, Expression<Func<bool>> browserOpenChromekillExistingChromeDriver = null, Expression<Func<string>> browserOpenChromeuserDataDir = null, Expression<Func<bool>> browserOpenChromeprintToDefaultPrinter = null, Expression<Func<string>> browserOpenChromedefaultDownloadDirectory = null, Expression<Func<bool>> browserOpenChromedownloadPDFInsteadOfOpening = null, Expression<Func<string>> browserOpenChromechromeDriverLogFilename = null, Expression<Func<string>> browserOpenChromelocalChromeDriverFolder = null, Expression<Func<string>> browserOpenChromechromeBrowserEXE = null, Expression<Func<bool>> browserOpenChromeignoreCertificateErrors = null, Expression<Func<string>> browserOpenChromeadditionalArguments = null, Expression<Func<bool>> browserOpenChromedoNothingIfChromeInstanceAlreadyOpen = null)
        {
            var __workflow_browserOpenChromeworkflow = WorkflowExpression.Compile(browserOpenChromeworkflow, nameof(browserOpenChromeworkflow), required: true);
            var __workflow_browserOpenChromechromeDriverFolder = WorkflowExpression.Compile(browserOpenChromechromeDriverFolder, nameof(browserOpenChromechromeDriverFolder), required: false);
            var __workflow_browserOpenChromekillExistingChromeDriver = WorkflowExpression.Compile(browserOpenChromekillExistingChromeDriver, nameof(browserOpenChromekillExistingChromeDriver), required: false);
            var __workflow_browserOpenChromeuserDataDir = WorkflowExpression.Compile(browserOpenChromeuserDataDir, nameof(browserOpenChromeuserDataDir), required: false);
            var __workflow_browserOpenChromeprintToDefaultPrinter = WorkflowExpression.Compile(browserOpenChromeprintToDefaultPrinter, nameof(browserOpenChromeprintToDefaultPrinter), required: false);
            var __workflow_browserOpenChromedefaultDownloadDirectory = WorkflowExpression.Compile(browserOpenChromedefaultDownloadDirectory, nameof(browserOpenChromedefaultDownloadDirectory), required: false);
            var __workflow_browserOpenChromedownloadPDFInsteadOfOpening = WorkflowExpression.Compile(browserOpenChromedownloadPDFInsteadOfOpening, nameof(browserOpenChromedownloadPDFInsteadOfOpening), required: false);
            var __workflow_browserOpenChromechromeDriverLogFilename = WorkflowExpression.Compile(browserOpenChromechromeDriverLogFilename, nameof(browserOpenChromechromeDriverLogFilename), required: false);
            var __workflow_browserOpenChromelocalChromeDriverFolder = WorkflowExpression.Compile(browserOpenChromelocalChromeDriverFolder, nameof(browserOpenChromelocalChromeDriverFolder), required: false);
            var __workflow_browserOpenChromechromeBrowserEXE = WorkflowExpression.Compile(browserOpenChromechromeBrowserEXE, nameof(browserOpenChromechromeBrowserEXE), required: false);
            var __workflow_browserOpenChromeignoreCertificateErrors = WorkflowExpression.Compile(browserOpenChromeignoreCertificateErrors, nameof(browserOpenChromeignoreCertificateErrors), required: false);
            var __workflow_browserOpenChromeadditionalArguments = WorkflowExpression.Compile(browserOpenChromeadditionalArguments, nameof(browserOpenChromeadditionalArguments), required: false);
            var __workflow_browserOpenChromedoNothingIfChromeInstanceAlreadyOpen = WorkflowExpression.Compile(browserOpenChromedoNothingIfChromeInstanceAlreadyOpen, nameof(browserOpenChromedoNothingIfChromeInstanceAlreadyOpen), required: false);
            return new DeferredBodyAction<BrowserOpenChromeResponse>(() =>
            {
                var apiCallPath = "/BrowserControl/OpenChrome";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserOpenChrome = new JObject();
                var browserOpenChromepropCount = 0;
                if (__workflow_browserOpenChromechromeDriverFolder != null)
                {
                    browserOpenChrome["ChromeDriverFolder"] = ExpressionConverter.ConvertO(__workflow_browserOpenChromechromeDriverFolder);
                    browserOpenChromepropCount++;
                }

                if (__workflow_browserOpenChromekillExistingChromeDriver != null)
                {
                    if (__workflow_browserOpenChromekillExistingChromeDriver != null)
                    {
                        browserOpenChrome["KillExistingChromeDriver"] = ExpressionConverter.ConvertO(__workflow_browserOpenChromekillExistingChromeDriver);
                        browserOpenChromepropCount++;
                    }

                    browserOpenChromepropCount++;
                }
                else
                {
                    browserOpenChrome["KillExistingChromeDriver"] = true;
                    browserOpenChromepropCount++;
                }

                if (__workflow_browserOpenChromeuserDataDir != null)
                {
                    browserOpenChrome["UserDataDir"] = ExpressionConverter.ConvertO(__workflow_browserOpenChromeuserDataDir);
                    browserOpenChromepropCount++;
                }

                if (__workflow_browserOpenChromeprintToDefaultPrinter != null)
                {
                    if (__workflow_browserOpenChromeprintToDefaultPrinter != null)
                    {
                        browserOpenChrome["PrintToDefaultPrinter"] = ExpressionConverter.ConvertO(__workflow_browserOpenChromeprintToDefaultPrinter);
                        browserOpenChromepropCount++;
                    }

                    browserOpenChromepropCount++;
                }
                else
                {
                    browserOpenChrome["PrintToDefaultPrinter"] = true;
                    browserOpenChromepropCount++;
                }

                if (__workflow_browserOpenChromedefaultDownloadDirectory != null)
                {
                    browserOpenChrome["DefaultDownloadDirectory"] = ExpressionConverter.ConvertO(__workflow_browserOpenChromedefaultDownloadDirectory);
                    browserOpenChromepropCount++;
                }

                if (__workflow_browserOpenChromedownloadPDFInsteadOfOpening != null)
                {
                    if (__workflow_browserOpenChromedownloadPDFInsteadOfOpening != null)
                    {
                        browserOpenChrome["DownloadPDFInsteadOfOpening"] = ExpressionConverter.ConvertO(__workflow_browserOpenChromedownloadPDFInsteadOfOpening);
                        browserOpenChromepropCount++;
                    }

                    browserOpenChromepropCount++;
                }
                else
                {
                    browserOpenChrome["DownloadPDFInsteadOfOpening"] = false;
                    browserOpenChromepropCount++;
                }

                if (__workflow_browserOpenChromechromeDriverLogFilename != null)
                {
                    browserOpenChrome["ChromeDriverLogFilename"] = ExpressionConverter.ConvertO(__workflow_browserOpenChromechromeDriverLogFilename);
                    browserOpenChromepropCount++;
                }

                if (__workflow_browserOpenChromelocalChromeDriverFolder != null)
                {
                    browserOpenChrome["LocalChromeDriverFolder"] = ExpressionConverter.ConvertO(__workflow_browserOpenChromelocalChromeDriverFolder);
                    browserOpenChromepropCount++;
                }

                if (__workflow_browserOpenChromechromeBrowserEXE != null)
                {
                    browserOpenChrome["ChromeBrowserEXE"] = ExpressionConverter.ConvertO(__workflow_browserOpenChromechromeBrowserEXE);
                    browserOpenChromepropCount++;
                }

                if (__workflow_browserOpenChromeignoreCertificateErrors != null)
                {
                    if (__workflow_browserOpenChromeignoreCertificateErrors != null)
                    {
                        browserOpenChrome["IgnoreCertificateErrors"] = ExpressionConverter.ConvertO(__workflow_browserOpenChromeignoreCertificateErrors);
                        browserOpenChromepropCount++;
                    }

                    browserOpenChromepropCount++;
                }
                else
                {
                    browserOpenChrome["IgnoreCertificateErrors"] = false;
                    browserOpenChromepropCount++;
                }

                if (__workflow_browserOpenChromeadditionalArguments != null)
                {
                    browserOpenChrome["AdditionalArguments"] = ExpressionConverter.ConvertO(__workflow_browserOpenChromeadditionalArguments);
                    browserOpenChromepropCount++;
                }

                if (__workflow_browserOpenChromedoNothingIfChromeInstanceAlreadyOpen != null)
                {
                    if (__workflow_browserOpenChromedoNothingIfChromeInstanceAlreadyOpen != null)
                    {
                        browserOpenChrome["DoNothingIfChromeInstanceAlreadyOpen"] = ExpressionConverter.ConvertO(__workflow_browserOpenChromedoNothingIfChromeInstanceAlreadyOpen);
                        browserOpenChromepropCount++;
                    }

                    browserOpenChromepropCount++;
                }
                else
                {
                    browserOpenChrome["DoNothingIfChromeInstanceAlreadyOpen"] = false;
                    browserOpenChromepropCount++;
                }

                browserOpenChromepropCount++;
                browserOpenChrome["Workflow"] = ExpressionConverter.ConvertO(__workflow_browserOpenChromeworkflow);
                if (browserOpenChromepropCount > 0)
                {
                    callPayload.Body = browserOpenChrome;
                }

                return new ApiConnectionAction<BrowserOpenChromeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserCloseChrome(Expression<Func<string>> browserCloseChromeworkflow, Expression<Func<bool>> browserCloseChromepurgeDynamicUserDataDir = null, Expression<Func<bool>> browserCloseChromepurgeStaticUserDataDir = null)
        {
            var __workflow_browserCloseChromeworkflow = WorkflowExpression.Compile(browserCloseChromeworkflow, nameof(browserCloseChromeworkflow), required: true);
            var __workflow_browserCloseChromepurgeDynamicUserDataDir = WorkflowExpression.Compile(browserCloseChromepurgeDynamicUserDataDir, nameof(browserCloseChromepurgeDynamicUserDataDir), required: false);
            var __workflow_browserCloseChromepurgeStaticUserDataDir = WorkflowExpression.Compile(browserCloseChromepurgeStaticUserDataDir, nameof(browserCloseChromepurgeStaticUserDataDir), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/BrowserControl/CloseChrome";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserCloseChrome = new JObject();
                var browserCloseChromepropCount = 0;
                if (__workflow_browserCloseChromepurgeDynamicUserDataDir != null)
                {
                    if (__workflow_browserCloseChromepurgeDynamicUserDataDir != null)
                    {
                        browserCloseChrome["PurgeDynamicUserDataDir"] = ExpressionConverter.ConvertO(__workflow_browserCloseChromepurgeDynamicUserDataDir);
                        browserCloseChromepropCount++;
                    }

                    browserCloseChromepropCount++;
                }
                else
                {
                    browserCloseChrome["PurgeDynamicUserDataDir"] = true;
                    browserCloseChromepropCount++;
                }

                if (__workflow_browserCloseChromepurgeStaticUserDataDir != null)
                {
                    if (__workflow_browserCloseChromepurgeStaticUserDataDir != null)
                    {
                        browserCloseChrome["PurgeStaticUserDataDir"] = ExpressionConverter.ConvertO(__workflow_browserCloseChromepurgeStaticUserDataDir);
                        browserCloseChromepropCount++;
                    }

                    browserCloseChromepropCount++;
                }
                else
                {
                    browserCloseChrome["PurgeStaticUserDataDir"] = false;
                    browserCloseChromepropCount++;
                }

                browserCloseChromepropCount++;
                browserCloseChrome["Workflow"] = ExpressionConverter.ConvertO(__workflow_browserCloseChromeworkflow);
                if (browserCloseChromepropCount > 0)
                {
                    callPayload.Body = browserCloseChrome;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserOpenInternetExplorer(Expression<Func<string>> browserOpenInternetExplorerworkflow, Expression<Func<string>> browserOpenInternetExploreriEDriverFolder = null, Expression<Func<bool>> browserOpenInternetExplorerkillExistingIEDriver = null, Expression<Func<bool>> browserOpenInternetExplorerkillExistingIE = null, Expression<Func<bool>> browserOpenInternetExplorercleanSession = null, Expression<Func<bool>> browserOpenInternetExplorerenableNativeEvents = null, Expression<Func<string>> browserOpenInternetExplorerwebDriverLogFile = null, Expression<Func<string>> browserOpenInternetExplorerwebDriverLogLevel = null, Expression<Func<bool>> browserOpenInternetExplorerdisableIEFirstRunCustomise = null, Expression<Func<string>> browserOpenInternetExploreradditionalArguments = null)
        {
            var __workflow_browserOpenInternetExplorerworkflow = WorkflowExpression.Compile(browserOpenInternetExplorerworkflow, nameof(browserOpenInternetExplorerworkflow), required: true);
            var __workflow_browserOpenInternetExploreriEDriverFolder = WorkflowExpression.Compile(browserOpenInternetExploreriEDriverFolder, nameof(browserOpenInternetExploreriEDriverFolder), required: false);
            var __workflow_browserOpenInternetExplorerkillExistingIEDriver = WorkflowExpression.Compile(browserOpenInternetExplorerkillExistingIEDriver, nameof(browserOpenInternetExplorerkillExistingIEDriver), required: false);
            var __workflow_browserOpenInternetExplorerkillExistingIE = WorkflowExpression.Compile(browserOpenInternetExplorerkillExistingIE, nameof(browserOpenInternetExplorerkillExistingIE), required: false);
            var __workflow_browserOpenInternetExplorercleanSession = WorkflowExpression.Compile(browserOpenInternetExplorercleanSession, nameof(browserOpenInternetExplorercleanSession), required: false);
            var __workflow_browserOpenInternetExplorerenableNativeEvents = WorkflowExpression.Compile(browserOpenInternetExplorerenableNativeEvents, nameof(browserOpenInternetExplorerenableNativeEvents), required: false);
            var __workflow_browserOpenInternetExplorerwebDriverLogFile = WorkflowExpression.Compile(browserOpenInternetExplorerwebDriverLogFile, nameof(browserOpenInternetExplorerwebDriverLogFile), required: false);
            var __workflow_browserOpenInternetExplorerwebDriverLogLevel = WorkflowExpression.Compile(browserOpenInternetExplorerwebDriverLogLevel, nameof(browserOpenInternetExplorerwebDriverLogLevel), required: false);
            var __workflow_browserOpenInternetExplorerdisableIEFirstRunCustomise = WorkflowExpression.Compile(browserOpenInternetExplorerdisableIEFirstRunCustomise, nameof(browserOpenInternetExplorerdisableIEFirstRunCustomise), required: false);
            var __workflow_browserOpenInternetExploreradditionalArguments = WorkflowExpression.Compile(browserOpenInternetExploreradditionalArguments, nameof(browserOpenInternetExploreradditionalArguments), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/BrowserControl/OpenInternetExplorer";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserOpenInternetExplorer = new JObject();
                var browserOpenInternetExplorerpropCount = 0;
                if (__workflow_browserOpenInternetExploreriEDriverFolder != null)
                {
                    browserOpenInternetExplorer["IEDriverFolder"] = ExpressionConverter.ConvertO(__workflow_browserOpenInternetExploreriEDriverFolder);
                    browserOpenInternetExplorerpropCount++;
                }

                if (__workflow_browserOpenInternetExplorerkillExistingIEDriver != null)
                {
                    if (__workflow_browserOpenInternetExplorerkillExistingIEDriver != null)
                    {
                        browserOpenInternetExplorer["KillExistingIEDriver"] = ExpressionConverter.ConvertO(__workflow_browserOpenInternetExplorerkillExistingIEDriver);
                        browserOpenInternetExplorerpropCount++;
                    }

                    browserOpenInternetExplorerpropCount++;
                }
                else
                {
                    browserOpenInternetExplorer["KillExistingIEDriver"] = false;
                    browserOpenInternetExplorerpropCount++;
                }

                if (__workflow_browserOpenInternetExplorerkillExistingIE != null)
                {
                    if (__workflow_browserOpenInternetExplorerkillExistingIE != null)
                    {
                        browserOpenInternetExplorer["KillExistingIE"] = ExpressionConverter.ConvertO(__workflow_browserOpenInternetExplorerkillExistingIE);
                        browserOpenInternetExplorerpropCount++;
                    }

                    browserOpenInternetExplorerpropCount++;
                }
                else
                {
                    browserOpenInternetExplorer["KillExistingIE"] = true;
                    browserOpenInternetExplorerpropCount++;
                }

                if (__workflow_browserOpenInternetExplorercleanSession != null)
                {
                    if (__workflow_browserOpenInternetExplorercleanSession != null)
                    {
                        browserOpenInternetExplorer["CleanSession"] = ExpressionConverter.ConvertO(__workflow_browserOpenInternetExplorercleanSession);
                        browserOpenInternetExplorerpropCount++;
                    }

                    browserOpenInternetExplorerpropCount++;
                }
                else
                {
                    browserOpenInternetExplorer["CleanSession"] = false;
                    browserOpenInternetExplorerpropCount++;
                }

                if (__workflow_browserOpenInternetExplorerenableNativeEvents != null)
                {
                    if (__workflow_browserOpenInternetExplorerenableNativeEvents != null)
                    {
                        browserOpenInternetExplorer["EnableNativeEvents"] = ExpressionConverter.ConvertO(__workflow_browserOpenInternetExplorerenableNativeEvents);
                        browserOpenInternetExplorerpropCount++;
                    }

                    browserOpenInternetExplorerpropCount++;
                }
                else
                {
                    browserOpenInternetExplorer["EnableNativeEvents"] = true;
                    browserOpenInternetExplorerpropCount++;
                }

                if (__workflow_browserOpenInternetExplorerwebDriverLogFile != null)
                {
                    browserOpenInternetExplorer["WebDriverLogFile"] = ExpressionConverter.ConvertO(__workflow_browserOpenInternetExplorerwebDriverLogFile);
                    browserOpenInternetExplorerpropCount++;
                }

                if (__workflow_browserOpenInternetExplorerwebDriverLogLevel != null)
                {
                    browserOpenInternetExplorer["WebDriverLogLevel"] = ExpressionConverter.ConvertO(__workflow_browserOpenInternetExplorerwebDriverLogLevel);
                    browserOpenInternetExplorerpropCount++;
                }

                if (__workflow_browserOpenInternetExplorerdisableIEFirstRunCustomise != null)
                {
                    if (__workflow_browserOpenInternetExplorerdisableIEFirstRunCustomise != null)
                    {
                        browserOpenInternetExplorer["DisableIEFirstRunCustomise"] = ExpressionConverter.ConvertO(__workflow_browserOpenInternetExplorerdisableIEFirstRunCustomise);
                        browserOpenInternetExplorerpropCount++;
                    }

                    browserOpenInternetExplorerpropCount++;
                }
                else
                {
                    browserOpenInternetExplorer["DisableIEFirstRunCustomise"] = true;
                    browserOpenInternetExplorerpropCount++;
                }

                if (__workflow_browserOpenInternetExploreradditionalArguments != null)
                {
                    browserOpenInternetExplorer["AdditionalArguments"] = ExpressionConverter.ConvertO(__workflow_browserOpenInternetExploreradditionalArguments);
                    browserOpenInternetExplorerpropCount++;
                }

                browserOpenInternetExplorerpropCount++;
                browserOpenInternetExplorer["Workflow"] = ExpressionConverter.ConvertO(__workflow_browserOpenInternetExplorerworkflow);
                if (browserOpenInternetExplorerpropCount > 0)
                {
                    callPayload.Body = browserOpenInternetExplorer;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserCloseInternetExplorer(Expression<Func<string>> browserCloseInternetExplorerworkflow, Expression<Func<bool>> browserCloseInternetExplorerunloadIEDriver = null)
        {
            var __workflow_browserCloseInternetExplorerworkflow = WorkflowExpression.Compile(browserCloseInternetExplorerworkflow, nameof(browserCloseInternetExplorerworkflow), required: true);
            var __workflow_browserCloseInternetExplorerunloadIEDriver = WorkflowExpression.Compile(browserCloseInternetExplorerunloadIEDriver, nameof(browserCloseInternetExplorerunloadIEDriver), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/BrowserControl/CloseInternetExplorer";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserCloseInternetExplorer = new JObject();
                var browserCloseInternetExplorerpropCount = 0;
                if (__workflow_browserCloseInternetExplorerunloadIEDriver != null)
                {
                    if (__workflow_browserCloseInternetExplorerunloadIEDriver != null)
                    {
                        browserCloseInternetExplorer["UnloadIEDriver"] = ExpressionConverter.ConvertO(__workflow_browserCloseInternetExplorerunloadIEDriver);
                        browserCloseInternetExplorerpropCount++;
                    }

                    browserCloseInternetExplorerpropCount++;
                }
                else
                {
                    browserCloseInternetExplorer["UnloadIEDriver"] = false;
                    browserCloseInternetExplorerpropCount++;
                }

                browserCloseInternetExplorerpropCount++;
                browserCloseInternetExplorer["Workflow"] = ExpressionConverter.ConvertO(__workflow_browserCloseInternetExplorerworkflow);
                if (browserCloseInternetExplorerpropCount > 0)
                {
                    callPayload.Body = browserCloseInternetExplorer;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserGetChromiumEdgeDriverFolderResponse> BrowserGetChromiumEdgeDriverFolder(Expression<Func<string>> browserGetChromiumEdgeDriverFolderdirectoryPath, Expression<Func<string>> browserGetChromiumEdgeDriverFolderworkflow, Expression<Func<int>> browserGetChromiumEdgeDriverFolderchromiumEdgeMajorVersion = null, Expression<Func<string>> browserGetChromiumEdgeDriverFolderchromiumEdgeBrowserEXE = null)
        {
            var __workflow_browserGetChromiumEdgeDriverFolderdirectoryPath = WorkflowExpression.Compile(browserGetChromiumEdgeDriverFolderdirectoryPath, nameof(browserGetChromiumEdgeDriverFolderdirectoryPath), required: true);
            var __workflow_browserGetChromiumEdgeDriverFolderworkflow = WorkflowExpression.Compile(browserGetChromiumEdgeDriverFolderworkflow, nameof(browserGetChromiumEdgeDriverFolderworkflow), required: true);
            var __workflow_browserGetChromiumEdgeDriverFolderchromiumEdgeMajorVersion = WorkflowExpression.Compile(browserGetChromiumEdgeDriverFolderchromiumEdgeMajorVersion, nameof(browserGetChromiumEdgeDriverFolderchromiumEdgeMajorVersion), required: false);
            var __workflow_browserGetChromiumEdgeDriverFolderchromiumEdgeBrowserEXE = WorkflowExpression.Compile(browserGetChromiumEdgeDriverFolderchromiumEdgeBrowserEXE, nameof(browserGetChromiumEdgeDriverFolderchromiumEdgeBrowserEXE), required: false);
            return new DeferredBodyAction<BrowserGetChromiumEdgeDriverFolderResponse>(() =>
            {
                var apiCallPath = "/BrowserControl/GetChromiumEdgeDriverFolder";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserGetChromiumEdgeDriverFolder = new JObject();
                var browserGetChromiumEdgeDriverFolderpropCount = 0;
                browserGetChromiumEdgeDriverFolderpropCount++;
                browserGetChromiumEdgeDriverFolder["DirectoryPath"] = ExpressionConverter.ConvertO(__workflow_browserGetChromiumEdgeDriverFolderdirectoryPath);
                if (__workflow_browserGetChromiumEdgeDriverFolderchromiumEdgeMajorVersion != null)
                {
                    browserGetChromiumEdgeDriverFolder["ChromiumEdgeMajorVersion"] = ExpressionConverter.ConvertO(__workflow_browserGetChromiumEdgeDriverFolderchromiumEdgeMajorVersion);
                    browserGetChromiumEdgeDriverFolderpropCount++;
                }

                if (__workflow_browserGetChromiumEdgeDriverFolderchromiumEdgeBrowserEXE != null)
                {
                    browserGetChromiumEdgeDriverFolder["ChromiumEdgeBrowserEXE"] = ExpressionConverter.ConvertO(__workflow_browserGetChromiumEdgeDriverFolderchromiumEdgeBrowserEXE);
                    browserGetChromiumEdgeDriverFolderpropCount++;
                }

                browserGetChromiumEdgeDriverFolderpropCount++;
                browserGetChromiumEdgeDriverFolder["Workflow"] = ExpressionConverter.ConvertO(__workflow_browserGetChromiumEdgeDriverFolderworkflow);
                if (browserGetChromiumEdgeDriverFolderpropCount > 0)
                {
                    callPayload.Body = browserGetChromiumEdgeDriverFolder;
                }

                return new ApiConnectionAction<BrowserGetChromiumEdgeDriverFolderResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserGetChromiumEdgeBrowserVersionFromFileResponse> BrowserGetChromiumEdgeBrowserVersionFromFile(Expression<Func<string>> browserGetChromiumEdgeBrowserVersionFromFileworkflow, Expression<Func<string>> browserGetChromiumEdgeBrowserVersionFromFilechromiumEdgeBrowserEXE = null)
        {
            var __workflow_browserGetChromiumEdgeBrowserVersionFromFileworkflow = WorkflowExpression.Compile(browserGetChromiumEdgeBrowserVersionFromFileworkflow, nameof(browserGetChromiumEdgeBrowserVersionFromFileworkflow), required: true);
            var __workflow_browserGetChromiumEdgeBrowserVersionFromFilechromiumEdgeBrowserEXE = WorkflowExpression.Compile(browserGetChromiumEdgeBrowserVersionFromFilechromiumEdgeBrowserEXE, nameof(browserGetChromiumEdgeBrowserVersionFromFilechromiumEdgeBrowserEXE), required: false);
            return new DeferredBodyAction<BrowserGetChromiumEdgeBrowserVersionFromFileResponse>(() =>
            {
                var apiCallPath = "/BrowserControl/GetChromiumEdgeBrowserVersionFromFile";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserGetChromiumEdgeBrowserVersionFromFile = new JObject();
                var browserGetChromiumEdgeBrowserVersionFromFilepropCount = 0;
                if (__workflow_browserGetChromiumEdgeBrowserVersionFromFilechromiumEdgeBrowserEXE != null)
                {
                    browserGetChromiumEdgeBrowserVersionFromFile["ChromiumEdgeBrowserEXE"] = ExpressionConverter.ConvertO(__workflow_browserGetChromiumEdgeBrowserVersionFromFilechromiumEdgeBrowserEXE);
                    browserGetChromiumEdgeBrowserVersionFromFilepropCount++;
                }

                browserGetChromiumEdgeBrowserVersionFromFilepropCount++;
                browserGetChromiumEdgeBrowserVersionFromFile["Workflow"] = ExpressionConverter.ConvertO(__workflow_browserGetChromiumEdgeBrowserVersionFromFileworkflow);
                if (browserGetChromiumEdgeBrowserVersionFromFilepropCount > 0)
                {
                    callPayload.Body = browserGetChromiumEdgeBrowserVersionFromFile;
                }

                return new ApiConnectionAction<BrowserGetChromiumEdgeBrowserVersionFromFileResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserDownloadSuitableChromiumEdgeDriverFromInternetResponse> BrowserDownloadSuitableChromiumEdgeDriverFromInternet(Expression<Func<string>> browserDownloadSuitableChromiumEdgeDriverFromInternetchromiumEdgeDriverDownloadParentFolder, Expression<Func<string>> browserDownloadSuitableChromiumEdgeDriverFromInternetworkflow, Expression<Func<string>> browserDownloadSuitableChromiumEdgeDriverFromInternetchromiumEdgeBrowserEXE = null, Expression<Func<string>> browserDownloadSuitableChromiumEdgeDriverFromInternetchromiumEdgeDriverRootWebPageURL = null)
        {
            var __workflow_browserDownloadSuitableChromiumEdgeDriverFromInternetchromiumEdgeDriverDownloadParentFolder = WorkflowExpression.Compile(browserDownloadSuitableChromiumEdgeDriverFromInternetchromiumEdgeDriverDownloadParentFolder, nameof(browserDownloadSuitableChromiumEdgeDriverFromInternetchromiumEdgeDriverDownloadParentFolder), required: true);
            var __workflow_browserDownloadSuitableChromiumEdgeDriverFromInternetworkflow = WorkflowExpression.Compile(browserDownloadSuitableChromiumEdgeDriverFromInternetworkflow, nameof(browserDownloadSuitableChromiumEdgeDriverFromInternetworkflow), required: true);
            var __workflow_browserDownloadSuitableChromiumEdgeDriverFromInternetchromiumEdgeBrowserEXE = WorkflowExpression.Compile(browserDownloadSuitableChromiumEdgeDriverFromInternetchromiumEdgeBrowserEXE, nameof(browserDownloadSuitableChromiumEdgeDriverFromInternetchromiumEdgeBrowserEXE), required: false);
            var __workflow_browserDownloadSuitableChromiumEdgeDriverFromInternetchromiumEdgeDriverRootWebPageURL = WorkflowExpression.Compile(browserDownloadSuitableChromiumEdgeDriverFromInternetchromiumEdgeDriverRootWebPageURL, nameof(browserDownloadSuitableChromiumEdgeDriverFromInternetchromiumEdgeDriverRootWebPageURL), required: false);
            return new DeferredBodyAction<BrowserDownloadSuitableChromiumEdgeDriverFromInternetResponse>(() =>
            {
                var apiCallPath = "/BrowserControl/BrowserDownloadSuitableChromiumEdgeDriverFromInternet";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserDownloadSuitableChromiumEdgeDriverFromInternet = new JObject();
                var browserDownloadSuitableChromiumEdgeDriverFromInternetpropCount = 0;
                if (__workflow_browserDownloadSuitableChromiumEdgeDriverFromInternetchromiumEdgeBrowserEXE != null)
                {
                    browserDownloadSuitableChromiumEdgeDriverFromInternet["ChromiumEdgeBrowserEXE"] = ExpressionConverter.ConvertO(__workflow_browserDownloadSuitableChromiumEdgeDriverFromInternetchromiumEdgeBrowserEXE);
                    browserDownloadSuitableChromiumEdgeDriverFromInternetpropCount++;
                }

                browserDownloadSuitableChromiumEdgeDriverFromInternetpropCount++;
                browserDownloadSuitableChromiumEdgeDriverFromInternet["ChromiumEdgeDriverDownloadParentFolder"] = ExpressionConverter.ConvertO(__workflow_browserDownloadSuitableChromiumEdgeDriverFromInternetchromiumEdgeDriverDownloadParentFolder);
                if (__workflow_browserDownloadSuitableChromiumEdgeDriverFromInternetchromiumEdgeDriverRootWebPageURL != null)
                {
                    if (__workflow_browserDownloadSuitableChromiumEdgeDriverFromInternetchromiumEdgeDriverRootWebPageURL != null)
                    {
                        browserDownloadSuitableChromiumEdgeDriverFromInternet["ChromiumEdgeDriverRootWebPageURL"] = ExpressionConverter.ConvertO(__workflow_browserDownloadSuitableChromiumEdgeDriverFromInternetchromiumEdgeDriverRootWebPageURL);
                        browserDownloadSuitableChromiumEdgeDriverFromInternetpropCount++;
                    }

                    browserDownloadSuitableChromiumEdgeDriverFromInternetpropCount++;
                }
                else
                {
                    browserDownloadSuitableChromiumEdgeDriverFromInternet["ChromiumEdgeDriverRootWebPageURL"] = "https://msedgewebdriverstorage.blob.core.windows.net/edgewebdriver/";
                    browserDownloadSuitableChromiumEdgeDriverFromInternetpropCount++;
                }

                browserDownloadSuitableChromiumEdgeDriverFromInternetpropCount++;
                browserDownloadSuitableChromiumEdgeDriverFromInternet["Workflow"] = ExpressionConverter.ConvertO(__workflow_browserDownloadSuitableChromiumEdgeDriverFromInternetworkflow);
                if (browserDownloadSuitableChromiumEdgeDriverFromInternetpropCount > 0)
                {
                    callPayload.Body = browserDownloadSuitableChromiumEdgeDriverFromInternet;
                }

                return new ApiConnectionAction<BrowserDownloadSuitableChromiumEdgeDriverFromInternetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserIsSuitableChromiumEdgeDriverAvailableResponse> BrowserIsSuitableChromiumEdgeDriverAvailable(Expression<Func<string>> browserIsSuitableChromiumEdgeDriverAvailableworkflow, Expression<Func<string>> browserIsSuitableChromiumEdgeDriverAvailablechromiumEdgeDriverFolder = null, Expression<Func<string>> browserIsSuitableChromiumEdgeDriverAvailablechromiumEdgeBrowserEXE = null)
        {
            var __workflow_browserIsSuitableChromiumEdgeDriverAvailableworkflow = WorkflowExpression.Compile(browserIsSuitableChromiumEdgeDriverAvailableworkflow, nameof(browserIsSuitableChromiumEdgeDriverAvailableworkflow), required: true);
            var __workflow_browserIsSuitableChromiumEdgeDriverAvailablechromiumEdgeDriverFolder = WorkflowExpression.Compile(browserIsSuitableChromiumEdgeDriverAvailablechromiumEdgeDriverFolder, nameof(browserIsSuitableChromiumEdgeDriverAvailablechromiumEdgeDriverFolder), required: false);
            var __workflow_browserIsSuitableChromiumEdgeDriverAvailablechromiumEdgeBrowserEXE = WorkflowExpression.Compile(browserIsSuitableChromiumEdgeDriverAvailablechromiumEdgeBrowserEXE, nameof(browserIsSuitableChromiumEdgeDriverAvailablechromiumEdgeBrowserEXE), required: false);
            return new DeferredBodyAction<BrowserIsSuitableChromiumEdgeDriverAvailableResponse>(() =>
            {
                var apiCallPath = "/BrowserControl/IsSuitableChromiumEdgeDriverAvailable";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserIsSuitableChromiumEdgeDriverAvailable = new JObject();
                var browserIsSuitableChromiumEdgeDriverAvailablepropCount = 0;
                if (__workflow_browserIsSuitableChromiumEdgeDriverAvailablechromiumEdgeDriverFolder != null)
                {
                    browserIsSuitableChromiumEdgeDriverAvailable["ChromiumEdgeDriverFolder"] = ExpressionConverter.ConvertO(__workflow_browserIsSuitableChromiumEdgeDriverAvailablechromiumEdgeDriverFolder);
                    browserIsSuitableChromiumEdgeDriverAvailablepropCount++;
                }

                if (__workflow_browserIsSuitableChromiumEdgeDriverAvailablechromiumEdgeBrowserEXE != null)
                {
                    browserIsSuitableChromiumEdgeDriverAvailable["ChromiumEdgeBrowserEXE"] = ExpressionConverter.ConvertO(__workflow_browserIsSuitableChromiumEdgeDriverAvailablechromiumEdgeBrowserEXE);
                    browserIsSuitableChromiumEdgeDriverAvailablepropCount++;
                }

                browserIsSuitableChromiumEdgeDriverAvailablepropCount++;
                browserIsSuitableChromiumEdgeDriverAvailable["Workflow"] = ExpressionConverter.ConvertO(__workflow_browserIsSuitableChromiumEdgeDriverAvailableworkflow);
                if (browserIsSuitableChromiumEdgeDriverAvailablepropCount > 0)
                {
                    callPayload.Body = browserIsSuitableChromiumEdgeDriverAvailable;
                }

                return new ApiConnectionAction<BrowserIsSuitableChromiumEdgeDriverAvailableResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserUploadNewChromiumEdgeDriver(Expression<Func<string>> browserUploadNewChromiumEdgeDriverlocalChromiumEdgeDriverFilePath, Expression<Func<string>> browserUploadNewChromiumEdgeDriverworkflow, Expression<Func<bool>> browserUploadNewChromiumEdgeDrivercompress = null, Expression<Func<int>> browserUploadNewChromiumEdgeDriverchromiumEdgeBrowserMajorVersion = null, Expression<Func<string>> browserUploadNewChromiumEdgeDriverchromiumEdgeDriverRootSaveFolder = null)
        {
            var __workflow_browserUploadNewChromiumEdgeDriverlocalChromiumEdgeDriverFilePath = WorkflowExpression.Compile(browserUploadNewChromiumEdgeDriverlocalChromiumEdgeDriverFilePath, nameof(browserUploadNewChromiumEdgeDriverlocalChromiumEdgeDriverFilePath), required: true);
            var __workflow_browserUploadNewChromiumEdgeDriverworkflow = WorkflowExpression.Compile(browserUploadNewChromiumEdgeDriverworkflow, nameof(browserUploadNewChromiumEdgeDriverworkflow), required: true);
            var __workflow_browserUploadNewChromiumEdgeDrivercompress = WorkflowExpression.Compile(browserUploadNewChromiumEdgeDrivercompress, nameof(browserUploadNewChromiumEdgeDrivercompress), required: false);
            var __workflow_browserUploadNewChromiumEdgeDriverchromiumEdgeBrowserMajorVersion = WorkflowExpression.Compile(browserUploadNewChromiumEdgeDriverchromiumEdgeBrowserMajorVersion, nameof(browserUploadNewChromiumEdgeDriverchromiumEdgeBrowserMajorVersion), required: false);
            var __workflow_browserUploadNewChromiumEdgeDriverchromiumEdgeDriverRootSaveFolder = WorkflowExpression.Compile(browserUploadNewChromiumEdgeDriverchromiumEdgeDriverRootSaveFolder, nameof(browserUploadNewChromiumEdgeDriverchromiumEdgeDriverRootSaveFolder), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/BrowserControl/UploadNewChromiumEdgeDriver";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserUploadNewChromiumEdgeDriver = new JObject();
                var browserUploadNewChromiumEdgeDriverpropCount = 0;
                browserUploadNewChromiumEdgeDriverpropCount++;
                browserUploadNewChromiumEdgeDriver["LocalChromiumEdgeDriverFilePath"] = ExpressionConverter.ConvertO(__workflow_browserUploadNewChromiumEdgeDriverlocalChromiumEdgeDriverFilePath);
                if (__workflow_browserUploadNewChromiumEdgeDrivercompress != null)
                {
                    if (__workflow_browserUploadNewChromiumEdgeDrivercompress != null)
                    {
                        browserUploadNewChromiumEdgeDriver["Compress"] = ExpressionConverter.ConvertO(__workflow_browserUploadNewChromiumEdgeDrivercompress);
                        browserUploadNewChromiumEdgeDriverpropCount++;
                    }

                    browserUploadNewChromiumEdgeDriverpropCount++;
                }
                else
                {
                    browserUploadNewChromiumEdgeDriver["Compress"] = false;
                    browserUploadNewChromiumEdgeDriverpropCount++;
                }

                if (__workflow_browserUploadNewChromiumEdgeDriverchromiumEdgeBrowserMajorVersion != null)
                {
                    browserUploadNewChromiumEdgeDriver["ChromiumEdgeBrowserMajorVersion"] = ExpressionConverter.ConvertO(__workflow_browserUploadNewChromiumEdgeDriverchromiumEdgeBrowserMajorVersion);
                    browserUploadNewChromiumEdgeDriverpropCount++;
                }

                if (__workflow_browserUploadNewChromiumEdgeDriverchromiumEdgeDriverRootSaveFolder != null)
                {
                    browserUploadNewChromiumEdgeDriver["ChromiumEdgeDriverRootSaveFolder"] = ExpressionConverter.ConvertO(__workflow_browserUploadNewChromiumEdgeDriverchromiumEdgeDriverRootSaveFolder);
                    browserUploadNewChromiumEdgeDriverpropCount++;
                }

                browserUploadNewChromiumEdgeDriverpropCount++;
                browserUploadNewChromiumEdgeDriver["Workflow"] = ExpressionConverter.ConvertO(__workflow_browserUploadNewChromiumEdgeDriverworkflow);
                if (browserUploadNewChromiumEdgeDriverpropCount > 0)
                {
                    callPayload.Body = browserUploadNewChromiumEdgeDriver;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserOpenChromiumEdgeResponse> BrowserOpenChromiumEdge(Expression<Func<string>> browserOpenChromiumEdgeworkflow, Expression<Func<string>> browserOpenChromiumEdgechromiumEdgeDriverFolder = null, Expression<Func<string>> browserOpenChromiumEdgeuserDataDir = null, Expression<Func<bool>> browserOpenChromiumEdgekillExistingChromiumEdgeDriver = null, Expression<Func<bool>> browserOpenChromiumEdgeprintToDefaultPrinter = null, Expression<Func<string>> browserOpenChromiumEdgedefaultDownloadDirectory = null, Expression<Func<bool>> browserOpenChromiumEdgedownloadPDFInsteadOfOpening = null, Expression<Func<string>> browserOpenChromiumEdgechromiumEdgeDriverLogFilename = null, Expression<Func<string>> browserOpenChromiumEdgelocalChromiumEdgeDriverFolder = null, Expression<Func<bool>> browserOpenChromiumEdgehideBrowserIsBeingAutomatedMessage = null, Expression<Func<string>> browserOpenChromiumEdgechromiumEdgeBrowserEXE = null, Expression<Func<bool>> browserOpenChromiumEdgeignoreCertificateErrors = null, Expression<Func<string>> browserOpenChromiumEdgeadditionalArguments = null, Expression<Func<bool>> browserOpenChromiumEdgedoNothingIfChromiumEdgeInstanceAlreadyOpen = null)
        {
            var __workflow_browserOpenChromiumEdgeworkflow = WorkflowExpression.Compile(browserOpenChromiumEdgeworkflow, nameof(browserOpenChromiumEdgeworkflow), required: true);
            var __workflow_browserOpenChromiumEdgechromiumEdgeDriverFolder = WorkflowExpression.Compile(browserOpenChromiumEdgechromiumEdgeDriverFolder, nameof(browserOpenChromiumEdgechromiumEdgeDriverFolder), required: false);
            var __workflow_browserOpenChromiumEdgeuserDataDir = WorkflowExpression.Compile(browserOpenChromiumEdgeuserDataDir, nameof(browserOpenChromiumEdgeuserDataDir), required: false);
            var __workflow_browserOpenChromiumEdgekillExistingChromiumEdgeDriver = WorkflowExpression.Compile(browserOpenChromiumEdgekillExistingChromiumEdgeDriver, nameof(browserOpenChromiumEdgekillExistingChromiumEdgeDriver), required: false);
            var __workflow_browserOpenChromiumEdgeprintToDefaultPrinter = WorkflowExpression.Compile(browserOpenChromiumEdgeprintToDefaultPrinter, nameof(browserOpenChromiumEdgeprintToDefaultPrinter), required: false);
            var __workflow_browserOpenChromiumEdgedefaultDownloadDirectory = WorkflowExpression.Compile(browserOpenChromiumEdgedefaultDownloadDirectory, nameof(browserOpenChromiumEdgedefaultDownloadDirectory), required: false);
            var __workflow_browserOpenChromiumEdgedownloadPDFInsteadOfOpening = WorkflowExpression.Compile(browserOpenChromiumEdgedownloadPDFInsteadOfOpening, nameof(browserOpenChromiumEdgedownloadPDFInsteadOfOpening), required: false);
            var __workflow_browserOpenChromiumEdgechromiumEdgeDriverLogFilename = WorkflowExpression.Compile(browserOpenChromiumEdgechromiumEdgeDriverLogFilename, nameof(browserOpenChromiumEdgechromiumEdgeDriverLogFilename), required: false);
            var __workflow_browserOpenChromiumEdgelocalChromiumEdgeDriverFolder = WorkflowExpression.Compile(browserOpenChromiumEdgelocalChromiumEdgeDriverFolder, nameof(browserOpenChromiumEdgelocalChromiumEdgeDriverFolder), required: false);
            var __workflow_browserOpenChromiumEdgehideBrowserIsBeingAutomatedMessage = WorkflowExpression.Compile(browserOpenChromiumEdgehideBrowserIsBeingAutomatedMessage, nameof(browserOpenChromiumEdgehideBrowserIsBeingAutomatedMessage), required: false);
            var __workflow_browserOpenChromiumEdgechromiumEdgeBrowserEXE = WorkflowExpression.Compile(browserOpenChromiumEdgechromiumEdgeBrowserEXE, nameof(browserOpenChromiumEdgechromiumEdgeBrowserEXE), required: false);
            var __workflow_browserOpenChromiumEdgeignoreCertificateErrors = WorkflowExpression.Compile(browserOpenChromiumEdgeignoreCertificateErrors, nameof(browserOpenChromiumEdgeignoreCertificateErrors), required: false);
            var __workflow_browserOpenChromiumEdgeadditionalArguments = WorkflowExpression.Compile(browserOpenChromiumEdgeadditionalArguments, nameof(browserOpenChromiumEdgeadditionalArguments), required: false);
            var __workflow_browserOpenChromiumEdgedoNothingIfChromiumEdgeInstanceAlreadyOpen = WorkflowExpression.Compile(browserOpenChromiumEdgedoNothingIfChromiumEdgeInstanceAlreadyOpen, nameof(browserOpenChromiumEdgedoNothingIfChromiumEdgeInstanceAlreadyOpen), required: false);
            return new DeferredBodyAction<BrowserOpenChromiumEdgeResponse>(() =>
            {
                var apiCallPath = "/BrowserControl/OpenChromiumEdge";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserOpenChromiumEdge = new JObject();
                var browserOpenChromiumEdgepropCount = 0;
                if (__workflow_browserOpenChromiumEdgechromiumEdgeDriverFolder != null)
                {
                    browserOpenChromiumEdge["ChromiumEdgeDriverFolder"] = ExpressionConverter.ConvertO(__workflow_browserOpenChromiumEdgechromiumEdgeDriverFolder);
                    browserOpenChromiumEdgepropCount++;
                }

                if (__workflow_browserOpenChromiumEdgeuserDataDir != null)
                {
                    browserOpenChromiumEdge["UserDataDir"] = ExpressionConverter.ConvertO(__workflow_browserOpenChromiumEdgeuserDataDir);
                    browserOpenChromiumEdgepropCount++;
                }

                if (__workflow_browserOpenChromiumEdgekillExistingChromiumEdgeDriver != null)
                {
                    if (__workflow_browserOpenChromiumEdgekillExistingChromiumEdgeDriver != null)
                    {
                        browserOpenChromiumEdge["KillExistingChromiumEdgeDriver"] = ExpressionConverter.ConvertO(__workflow_browserOpenChromiumEdgekillExistingChromiumEdgeDriver);
                        browserOpenChromiumEdgepropCount++;
                    }

                    browserOpenChromiumEdgepropCount++;
                }
                else
                {
                    browserOpenChromiumEdge["KillExistingChromiumEdgeDriver"] = true;
                    browserOpenChromiumEdgepropCount++;
                }

                if (__workflow_browserOpenChromiumEdgeprintToDefaultPrinter != null)
                {
                    if (__workflow_browserOpenChromiumEdgeprintToDefaultPrinter != null)
                    {
                        browserOpenChromiumEdge["PrintToDefaultPrinter"] = ExpressionConverter.ConvertO(__workflow_browserOpenChromiumEdgeprintToDefaultPrinter);
                        browserOpenChromiumEdgepropCount++;
                    }

                    browserOpenChromiumEdgepropCount++;
                }
                else
                {
                    browserOpenChromiumEdge["PrintToDefaultPrinter"] = true;
                    browserOpenChromiumEdgepropCount++;
                }

                if (__workflow_browserOpenChromiumEdgedefaultDownloadDirectory != null)
                {
                    browserOpenChromiumEdge["DefaultDownloadDirectory"] = ExpressionConverter.ConvertO(__workflow_browserOpenChromiumEdgedefaultDownloadDirectory);
                    browserOpenChromiumEdgepropCount++;
                }

                if (__workflow_browserOpenChromiumEdgedownloadPDFInsteadOfOpening != null)
                {
                    if (__workflow_browserOpenChromiumEdgedownloadPDFInsteadOfOpening != null)
                    {
                        browserOpenChromiumEdge["DownloadPDFInsteadOfOpening"] = ExpressionConverter.ConvertO(__workflow_browserOpenChromiumEdgedownloadPDFInsteadOfOpening);
                        browserOpenChromiumEdgepropCount++;
                    }

                    browserOpenChromiumEdgepropCount++;
                }
                else
                {
                    browserOpenChromiumEdge["DownloadPDFInsteadOfOpening"] = false;
                    browserOpenChromiumEdgepropCount++;
                }

                if (__workflow_browserOpenChromiumEdgechromiumEdgeDriverLogFilename != null)
                {
                    browserOpenChromiumEdge["ChromiumEdgeDriverLogFilename"] = ExpressionConverter.ConvertO(__workflow_browserOpenChromiumEdgechromiumEdgeDriverLogFilename);
                    browserOpenChromiumEdgepropCount++;
                }

                if (__workflow_browserOpenChromiumEdgelocalChromiumEdgeDriverFolder != null)
                {
                    browserOpenChromiumEdge["LocalChromiumEdgeDriverFolder"] = ExpressionConverter.ConvertO(__workflow_browserOpenChromiumEdgelocalChromiumEdgeDriverFolder);
                    browserOpenChromiumEdgepropCount++;
                }

                if (__workflow_browserOpenChromiumEdgehideBrowserIsBeingAutomatedMessage != null)
                {
                    if (__workflow_browserOpenChromiumEdgehideBrowserIsBeingAutomatedMessage != null)
                    {
                        browserOpenChromiumEdge["HideBrowserIsBeingAutomatedMessage"] = ExpressionConverter.ConvertO(__workflow_browserOpenChromiumEdgehideBrowserIsBeingAutomatedMessage);
                        browserOpenChromiumEdgepropCount++;
                    }

                    browserOpenChromiumEdgepropCount++;
                }
                else
                {
                    browserOpenChromiumEdge["HideBrowserIsBeingAutomatedMessage"] = true;
                    browserOpenChromiumEdgepropCount++;
                }

                if (__workflow_browserOpenChromiumEdgechromiumEdgeBrowserEXE != null)
                {
                    browserOpenChromiumEdge["ChromiumEdgeBrowserEXE"] = ExpressionConverter.ConvertO(__workflow_browserOpenChromiumEdgechromiumEdgeBrowserEXE);
                    browserOpenChromiumEdgepropCount++;
                }

                if (__workflow_browserOpenChromiumEdgeignoreCertificateErrors != null)
                {
                    if (__workflow_browserOpenChromiumEdgeignoreCertificateErrors != null)
                    {
                        browserOpenChromiumEdge["IgnoreCertificateErrors"] = ExpressionConverter.ConvertO(__workflow_browserOpenChromiumEdgeignoreCertificateErrors);
                        browserOpenChromiumEdgepropCount++;
                    }

                    browserOpenChromiumEdgepropCount++;
                }
                else
                {
                    browserOpenChromiumEdge["IgnoreCertificateErrors"] = false;
                    browserOpenChromiumEdgepropCount++;
                }

                if (__workflow_browserOpenChromiumEdgeadditionalArguments != null)
                {
                    browserOpenChromiumEdge["AdditionalArguments"] = ExpressionConverter.ConvertO(__workflow_browserOpenChromiumEdgeadditionalArguments);
                    browserOpenChromiumEdgepropCount++;
                }

                if (__workflow_browserOpenChromiumEdgedoNothingIfChromiumEdgeInstanceAlreadyOpen != null)
                {
                    if (__workflow_browserOpenChromiumEdgedoNothingIfChromiumEdgeInstanceAlreadyOpen != null)
                    {
                        browserOpenChromiumEdge["DoNothingIfChromiumEdgeInstanceAlreadyOpen"] = ExpressionConverter.ConvertO(__workflow_browserOpenChromiumEdgedoNothingIfChromiumEdgeInstanceAlreadyOpen);
                        browserOpenChromiumEdgepropCount++;
                    }

                    browserOpenChromiumEdgepropCount++;
                }
                else
                {
                    browserOpenChromiumEdge["DoNothingIfChromiumEdgeInstanceAlreadyOpen"] = false;
                    browserOpenChromiumEdgepropCount++;
                }

                browserOpenChromiumEdgepropCount++;
                browserOpenChromiumEdge["Workflow"] = ExpressionConverter.ConvertO(__workflow_browserOpenChromiumEdgeworkflow);
                if (browserOpenChromiumEdgepropCount > 0)
                {
                    callPayload.Body = browserOpenChromiumEdge;
                }

                return new ApiConnectionAction<BrowserOpenChromiumEdgeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserCloseChromiumEdge(Expression<Func<string>> browserCloseChromiumEdgeworkflow, Expression<Func<bool>> browserCloseChromiumEdgepurgeDynamicUserDataDir = null, Expression<Func<bool>> browserCloseChromiumEdgepurgeStaticUserDataDir = null)
        {
            var __workflow_browserCloseChromiumEdgeworkflow = WorkflowExpression.Compile(browserCloseChromiumEdgeworkflow, nameof(browserCloseChromiumEdgeworkflow), required: true);
            var __workflow_browserCloseChromiumEdgepurgeDynamicUserDataDir = WorkflowExpression.Compile(browserCloseChromiumEdgepurgeDynamicUserDataDir, nameof(browserCloseChromiumEdgepurgeDynamicUserDataDir), required: false);
            var __workflow_browserCloseChromiumEdgepurgeStaticUserDataDir = WorkflowExpression.Compile(browserCloseChromiumEdgepurgeStaticUserDataDir, nameof(browserCloseChromiumEdgepurgeStaticUserDataDir), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/BrowserControl/CloseChromiumEdge";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserCloseChromiumEdge = new JObject();
                var browserCloseChromiumEdgepropCount = 0;
                if (__workflow_browserCloseChromiumEdgepurgeDynamicUserDataDir != null)
                {
                    if (__workflow_browserCloseChromiumEdgepurgeDynamicUserDataDir != null)
                    {
                        browserCloseChromiumEdge["PurgeDynamicUserDataDir"] = ExpressionConverter.ConvertO(__workflow_browserCloseChromiumEdgepurgeDynamicUserDataDir);
                        browserCloseChromiumEdgepropCount++;
                    }

                    browserCloseChromiumEdgepropCount++;
                }
                else
                {
                    browserCloseChromiumEdge["PurgeDynamicUserDataDir"] = true;
                    browserCloseChromiumEdgepropCount++;
                }

                if (__workflow_browserCloseChromiumEdgepurgeStaticUserDataDir != null)
                {
                    if (__workflow_browserCloseChromiumEdgepurgeStaticUserDataDir != null)
                    {
                        browserCloseChromiumEdge["PurgeStaticUserDataDir"] = ExpressionConverter.ConvertO(__workflow_browserCloseChromiumEdgepurgeStaticUserDataDir);
                        browserCloseChromiumEdgepropCount++;
                    }

                    browserCloseChromiumEdgepropCount++;
                }
                else
                {
                    browserCloseChromiumEdge["PurgeStaticUserDataDir"] = false;
                    browserCloseChromiumEdgepropCount++;
                }

                browserCloseChromiumEdgepropCount++;
                browserCloseChromiumEdge["Workflow"] = ExpressionConverter.ConvertO(__workflow_browserCloseChromiumEdgeworkflow);
                if (browserCloseChromiumEdgepropCount > 0)
                {
                    callPayload.Body = browserCloseChromiumEdge;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserMaximise(Expression<Func<string>> browserMaximiseworkflow)
        {
            var __workflow_browserMaximiseworkflow = WorkflowExpression.Compile(browserMaximiseworkflow, nameof(browserMaximiseworkflow), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/BrowserControl/MaximiseBrowser";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserMaximise = new JObject();
                var browserMaximisepropCount = 0;
                browserMaximisepropCount++;
                browserMaximise["Workflow"] = ExpressionConverter.ConvertO(__workflow_browserMaximiseworkflow);
                if (browserMaximisepropCount > 0)
                {
                    callPayload.Body = browserMaximise;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserMinimise(Expression<Func<string>> browserMinimiseworkflow)
        {
            var __workflow_browserMinimiseworkflow = WorkflowExpression.Compile(browserMinimiseworkflow, nameof(browserMinimiseworkflow), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/BrowserControl/MinimiseBrowser";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserMinimise = new JObject();
                var browserMinimisepropCount = 0;
                browserMinimisepropCount++;
                browserMinimise["Workflow"] = ExpressionConverter.ConvertO(__workflow_browserMinimiseworkflow);
                if (browserMinimisepropCount > 0)
                {
                    callPayload.Body = browserMinimise;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserFullscreen(Expression<Func<string>> browserFullscreenworkflow)
        {
            var __workflow_browserFullscreenworkflow = WorkflowExpression.Compile(browserFullscreenworkflow, nameof(browserFullscreenworkflow), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/BrowserControl/FullscreenBrowser";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserFullscreen = new JObject();
                var browserFullscreenpropCount = 0;
                browserFullscreenpropCount++;
                browserFullscreen["Workflow"] = ExpressionConverter.ConvertO(__workflow_browserFullscreenworkflow);
                if (browserFullscreenpropCount > 0)
                {
                    callPayload.Body = browserFullscreen;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserNormaliseBrowser(Expression<Func<string>> browserNormaliseBrowserworkflow, Expression<Func<int>> browserNormaliseBrowserx = null, Expression<Func<int>> browserNormaliseBrowsery = null, Expression<Func<int>> browserNormaliseBrowserwidth = null, Expression<Func<int>> browserNormaliseBrowserheight = null)
        {
            var __workflow_browserNormaliseBrowserworkflow = WorkflowExpression.Compile(browserNormaliseBrowserworkflow, nameof(browserNormaliseBrowserworkflow), required: true);
            var __workflow_browserNormaliseBrowserx = WorkflowExpression.Compile(browserNormaliseBrowserx, nameof(browserNormaliseBrowserx), required: false);
            var __workflow_browserNormaliseBrowsery = WorkflowExpression.Compile(browserNormaliseBrowsery, nameof(browserNormaliseBrowsery), required: false);
            var __workflow_browserNormaliseBrowserwidth = WorkflowExpression.Compile(browserNormaliseBrowserwidth, nameof(browserNormaliseBrowserwidth), required: false);
            var __workflow_browserNormaliseBrowserheight = WorkflowExpression.Compile(browserNormaliseBrowserheight, nameof(browserNormaliseBrowserheight), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/BrowserControl/NormaliseBrowser";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserNormaliseBrowser = new JObject();
                var browserNormaliseBrowserpropCount = 0;
                if (__workflow_browserNormaliseBrowserx != null)
                {
                    if (__workflow_browserNormaliseBrowserx != null)
                    {
                        browserNormaliseBrowser["X"] = ExpressionConverter.ConvertO(__workflow_browserNormaliseBrowserx);
                        browserNormaliseBrowserpropCount++;
                    }

                    browserNormaliseBrowserpropCount++;
                }
                else
                {
                    browserNormaliseBrowser["X"] = 20;
                    browserNormaliseBrowserpropCount++;
                }

                if (__workflow_browserNormaliseBrowsery != null)
                {
                    if (__workflow_browserNormaliseBrowsery != null)
                    {
                        browserNormaliseBrowser["Y"] = ExpressionConverter.ConvertO(__workflow_browserNormaliseBrowsery);
                        browserNormaliseBrowserpropCount++;
                    }

                    browserNormaliseBrowserpropCount++;
                }
                else
                {
                    browserNormaliseBrowser["Y"] = 20;
                    browserNormaliseBrowserpropCount++;
                }

                if (__workflow_browserNormaliseBrowserwidth != null)
                {
                    if (__workflow_browserNormaliseBrowserwidth != null)
                    {
                        browserNormaliseBrowser["Width"] = ExpressionConverter.ConvertO(__workflow_browserNormaliseBrowserwidth);
                        browserNormaliseBrowserpropCount++;
                    }

                    browserNormaliseBrowserpropCount++;
                }
                else
                {
                    browserNormaliseBrowser["Width"] = -40;
                    browserNormaliseBrowserpropCount++;
                }

                if (__workflow_browserNormaliseBrowserheight != null)
                {
                    if (__workflow_browserNormaliseBrowserheight != null)
                    {
                        browserNormaliseBrowser["Height"] = ExpressionConverter.ConvertO(__workflow_browserNormaliseBrowserheight);
                        browserNormaliseBrowserpropCount++;
                    }

                    browserNormaliseBrowserpropCount++;
                }
                else
                {
                    browserNormaliseBrowser["Height"] = -40;
                    browserNormaliseBrowserpropCount++;
                }

                browserNormaliseBrowserpropCount++;
                browserNormaliseBrowser["Workflow"] = ExpressionConverter.ConvertO(__workflow_browserNormaliseBrowserworkflow);
                if (browserNormaliseBrowserpropCount > 0)
                {
                    callPayload.Body = browserNormaliseBrowser;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserSetWindowSize(Expression<Func<int>> browserSetWindowSizewidth, Expression<Func<int>> browserSetWindowSizeheight, Expression<Func<string>> browserSetWindowSizeworkflow)
        {
            var __workflow_browserSetWindowSizewidth = WorkflowExpression.Compile(browserSetWindowSizewidth, nameof(browserSetWindowSizewidth), required: true);
            var __workflow_browserSetWindowSizeheight = WorkflowExpression.Compile(browserSetWindowSizeheight, nameof(browserSetWindowSizeheight), required: true);
            var __workflow_browserSetWindowSizeworkflow = WorkflowExpression.Compile(browserSetWindowSizeworkflow, nameof(browserSetWindowSizeworkflow), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/BrowserControl/SetBrowserWindowSize";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserSetWindowSize = new JObject();
                var browserSetWindowSizepropCount = 0;
                browserSetWindowSizepropCount++;
                browserSetWindowSize["Width"] = ExpressionConverter.ConvertO(__workflow_browserSetWindowSizewidth);
                browserSetWindowSizepropCount++;
                browserSetWindowSize["Height"] = ExpressionConverter.ConvertO(__workflow_browserSetWindowSizeheight);
                browserSetWindowSizepropCount++;
                browserSetWindowSize["Workflow"] = ExpressionConverter.ConvertO(__workflow_browserSetWindowSizeworkflow);
                if (browserSetWindowSizepropCount > 0)
                {
                    callPayload.Body = browserSetWindowSize;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserSetWindowPosition(Expression<Func<int>> browserSetWindowPositionx, Expression<Func<int>> browserSetWindowPositiony, Expression<Func<string>> browserSetWindowPositionworkflow)
        {
            var __workflow_browserSetWindowPositionx = WorkflowExpression.Compile(browserSetWindowPositionx, nameof(browserSetWindowPositionx), required: true);
            var __workflow_browserSetWindowPositiony = WorkflowExpression.Compile(browserSetWindowPositiony, nameof(browserSetWindowPositiony), required: true);
            var __workflow_browserSetWindowPositionworkflow = WorkflowExpression.Compile(browserSetWindowPositionworkflow, nameof(browserSetWindowPositionworkflow), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/BrowserControl/SetBrowserWindowPosition";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserSetWindowPosition = new JObject();
                var browserSetWindowPositionpropCount = 0;
                browserSetWindowPositionpropCount++;
                browserSetWindowPosition["X"] = ExpressionConverter.ConvertO(__workflow_browserSetWindowPositionx);
                browserSetWindowPositionpropCount++;
                browserSetWindowPosition["Y"] = ExpressionConverter.ConvertO(__workflow_browserSetWindowPositiony);
                browserSetWindowPositionpropCount++;
                browserSetWindowPosition["Workflow"] = ExpressionConverter.ConvertO(__workflow_browserSetWindowPositionworkflow);
                if (browserSetWindowPositionpropCount > 0)
                {
                    callPayload.Body = browserSetWindowPosition;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserSetTimeouts(Expression<Func<string>> browserSetTimeoutsworkflow, Expression<Func<double>> browserSetTimeoutselementWaitTimeoutSeconds = null, Expression<Func<double>> browserSetTimeoutspageLoadTimeoutSeconds = null)
        {
            var __workflow_browserSetTimeoutsworkflow = WorkflowExpression.Compile(browserSetTimeoutsworkflow, nameof(browserSetTimeoutsworkflow), required: true);
            var __workflow_browserSetTimeoutselementWaitTimeoutSeconds = WorkflowExpression.Compile(browserSetTimeoutselementWaitTimeoutSeconds, nameof(browserSetTimeoutselementWaitTimeoutSeconds), required: false);
            var __workflow_browserSetTimeoutspageLoadTimeoutSeconds = WorkflowExpression.Compile(browserSetTimeoutspageLoadTimeoutSeconds, nameof(browserSetTimeoutspageLoadTimeoutSeconds), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/BrowserControl/SetTimeouts";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserSetTimeouts = new JObject();
                var browserSetTimeoutspropCount = 0;
                if (__workflow_browserSetTimeoutselementWaitTimeoutSeconds != null)
                {
                    browserSetTimeouts["ElementWaitTimeoutSeconds"] = ExpressionConverter.ConvertO(__workflow_browserSetTimeoutselementWaitTimeoutSeconds);
                    browserSetTimeoutspropCount++;
                }

                if (__workflow_browserSetTimeoutspageLoadTimeoutSeconds != null)
                {
                    browserSetTimeouts["PageLoadTimeoutSeconds"] = ExpressionConverter.ConvertO(__workflow_browserSetTimeoutspageLoadTimeoutSeconds);
                    browserSetTimeoutspropCount++;
                }

                browserSetTimeoutspropCount++;
                browserSetTimeouts["Workflow"] = ExpressionConverter.ConvertO(__workflow_browserSetTimeoutsworkflow);
                if (browserSetTimeoutspropCount > 0)
                {
                    callPayload.Body = browserSetTimeouts;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserNavigateToURLResponse> BrowserNavigateToURL(Expression<Func<string>> browserNavigateToURLuRL, Expression<Func<string>> browserNavigateToURLworkflow)
        {
            var __workflow_browserNavigateToURLuRL = WorkflowExpression.Compile(browserNavigateToURLuRL, nameof(browserNavigateToURLuRL), required: true);
            var __workflow_browserNavigateToURLworkflow = WorkflowExpression.Compile(browserNavigateToURLworkflow, nameof(browserNavigateToURLworkflow), required: true);
            return new DeferredBodyAction<BrowserNavigateToURLResponse>(() =>
            {
                var apiCallPath = "/BrowserControl/NavigateToURL";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserNavigateToURL = new JObject();
                var browserNavigateToURLpropCount = 0;
                browserNavigateToURLpropCount++;
                browserNavigateToURL["URL"] = ExpressionConverter.ConvertO(__workflow_browserNavigateToURLuRL);
                browserNavigateToURLpropCount++;
                browserNavigateToURL["Workflow"] = ExpressionConverter.ConvertO(__workflow_browserNavigateToURLworkflow);
                if (browserNavigateToURLpropCount > 0)
                {
                    callPayload.Body = browserNavigateToURL;
                }

                return new ApiConnectionAction<BrowserNavigateToURLResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserRefreshPage(Expression<Func<string>> browserRefreshPageworkflow)
        {
            var __workflow_browserRefreshPageworkflow = WorkflowExpression.Compile(browserRefreshPageworkflow, nameof(browserRefreshPageworkflow), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/BrowserControl/RefreshPage";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserRefreshPage = new JObject();
                var browserRefreshPagepropCount = 0;
                browserRefreshPagepropCount++;
                browserRefreshPage["Workflow"] = ExpressionConverter.ConvertO(__workflow_browserRefreshPageworkflow);
                if (browserRefreshPagepropCount > 0)
                {
                    callPayload.Body = browserRefreshPage;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserResetAllElementHandles(Expression<Func<string>> browserResetAllElementHandlesworkflow)
        {
            var __workflow_browserResetAllElementHandlesworkflow = WorkflowExpression.Compile(browserResetAllElementHandlesworkflow, nameof(browserResetAllElementHandlesworkflow), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/BrowserControl/ResetAllElementHandles";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserResetAllElementHandles = new JObject();
                var browserResetAllElementHandlespropCount = 0;
                browserResetAllElementHandlespropCount++;
                browserResetAllElementHandles["Workflow"] = ExpressionConverter.ConvertO(__workflow_browserResetAllElementHandlesworkflow);
                if (browserResetAllElementHandlespropCount > 0)
                {
                    callPayload.Body = browserResetAllElementHandles;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserDoesElementExistResponse> BrowserDoesElementExist(Expression<Func<string>> browserDoesElementExistworkflow, Expression<Func<double>> browserDoesElementExistparentElementHandle = null, Expression<Func<double>> browserDoesElementExistsearchElementHandle = null, Expression<Func<string>> browserDoesElementExistsearchElementName = null, Expression<Func<string>> browserDoesElementExistsearchElementID = null, Expression<Func<string>> browserDoesElementExistsearchElementTagName = null, Expression<Func<string>> browserDoesElementExistsearchElementXPath = null, Expression<Func<string>> browserDoesElementExistsearchElementClassName = null, Expression<Func<string>> browserDoesElementExistsearchElementCSSSelector = null, Expression<Func<double>> browserDoesElementExistsearchElementIndex = null, Expression<Func<string>> browserDoesElementExistsearchElementMatchValue = null, Expression<Func<string>> browserDoesElementExistsearchElementMatchText = null, Expression<Func<string>> browserDoesElementExistsearchElementType = null, Expression<Func<double>> browserDoesElementExistsearchElementMinimumWidth = null, Expression<Func<double>> browserDoesElementExistsearchElementMinimumHeight = null, Expression<Func<double>> browserDoesElementExistsearchElementBoundingBoxLeft = null, Expression<Func<double>> browserDoesElementExistsearchElementBoundingBoxRight = null, Expression<Func<double>> browserDoesElementExistsearchElementBoundingBoxTop = null, Expression<Func<double>> browserDoesElementExistsearchElementBoundingBoxBottom = null, Expression<Func<bool>> browserDoesElementExistonlyElementTopLeftNeedsToBeInBoundingBox = null)
        {
            var __workflow_browserDoesElementExistworkflow = WorkflowExpression.Compile(browserDoesElementExistworkflow, nameof(browserDoesElementExistworkflow), required: true);
            var __workflow_browserDoesElementExistparentElementHandle = WorkflowExpression.Compile(browserDoesElementExistparentElementHandle, nameof(browserDoesElementExistparentElementHandle), required: false);
            var __workflow_browserDoesElementExistsearchElementHandle = WorkflowExpression.Compile(browserDoesElementExistsearchElementHandle, nameof(browserDoesElementExistsearchElementHandle), required: false);
            var __workflow_browserDoesElementExistsearchElementName = WorkflowExpression.Compile(browserDoesElementExistsearchElementName, nameof(browserDoesElementExistsearchElementName), required: false);
            var __workflow_browserDoesElementExistsearchElementID = WorkflowExpression.Compile(browserDoesElementExistsearchElementID, nameof(browserDoesElementExistsearchElementID), required: false);
            var __workflow_browserDoesElementExistsearchElementTagName = WorkflowExpression.Compile(browserDoesElementExistsearchElementTagName, nameof(browserDoesElementExistsearchElementTagName), required: false);
            var __workflow_browserDoesElementExistsearchElementXPath = WorkflowExpression.Compile(browserDoesElementExistsearchElementXPath, nameof(browserDoesElementExistsearchElementXPath), required: false);
            var __workflow_browserDoesElementExistsearchElementClassName = WorkflowExpression.Compile(browserDoesElementExistsearchElementClassName, nameof(browserDoesElementExistsearchElementClassName), required: false);
            var __workflow_browserDoesElementExistsearchElementCSSSelector = WorkflowExpression.Compile(browserDoesElementExistsearchElementCSSSelector, nameof(browserDoesElementExistsearchElementCSSSelector), required: false);
            var __workflow_browserDoesElementExistsearchElementIndex = WorkflowExpression.Compile(browserDoesElementExistsearchElementIndex, nameof(browserDoesElementExistsearchElementIndex), required: false);
            var __workflow_browserDoesElementExistsearchElementMatchValue = WorkflowExpression.Compile(browserDoesElementExistsearchElementMatchValue, nameof(browserDoesElementExistsearchElementMatchValue), required: false);
            var __workflow_browserDoesElementExistsearchElementMatchText = WorkflowExpression.Compile(browserDoesElementExistsearchElementMatchText, nameof(browserDoesElementExistsearchElementMatchText), required: false);
            var __workflow_browserDoesElementExistsearchElementType = WorkflowExpression.Compile(browserDoesElementExistsearchElementType, nameof(browserDoesElementExistsearchElementType), required: false);
            var __workflow_browserDoesElementExistsearchElementMinimumWidth = WorkflowExpression.Compile(browserDoesElementExistsearchElementMinimumWidth, nameof(browserDoesElementExistsearchElementMinimumWidth), required: false);
            var __workflow_browserDoesElementExistsearchElementMinimumHeight = WorkflowExpression.Compile(browserDoesElementExistsearchElementMinimumHeight, nameof(browserDoesElementExistsearchElementMinimumHeight), required: false);
            var __workflow_browserDoesElementExistsearchElementBoundingBoxLeft = WorkflowExpression.Compile(browserDoesElementExistsearchElementBoundingBoxLeft, nameof(browserDoesElementExistsearchElementBoundingBoxLeft), required: false);
            var __workflow_browserDoesElementExistsearchElementBoundingBoxRight = WorkflowExpression.Compile(browserDoesElementExistsearchElementBoundingBoxRight, nameof(browserDoesElementExistsearchElementBoundingBoxRight), required: false);
            var __workflow_browserDoesElementExistsearchElementBoundingBoxTop = WorkflowExpression.Compile(browserDoesElementExistsearchElementBoundingBoxTop, nameof(browserDoesElementExistsearchElementBoundingBoxTop), required: false);
            var __workflow_browserDoesElementExistsearchElementBoundingBoxBottom = WorkflowExpression.Compile(browserDoesElementExistsearchElementBoundingBoxBottom, nameof(browserDoesElementExistsearchElementBoundingBoxBottom), required: false);
            var __workflow_browserDoesElementExistonlyElementTopLeftNeedsToBeInBoundingBox = WorkflowExpression.Compile(browserDoesElementExistonlyElementTopLeftNeedsToBeInBoundingBox, nameof(browserDoesElementExistonlyElementTopLeftNeedsToBeInBoundingBox), required: false);
            return new DeferredBodyAction<BrowserDoesElementExistResponse>(() =>
            {
                var apiCallPath = "/BrowserControl/DoesElementExist";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserDoesElementExist = new JObject();
                var browserDoesElementExistpropCount = 0;
                if (__workflow_browserDoesElementExistparentElementHandle != null)
                {
                    browserDoesElementExist["ParentElementHandle"] = ExpressionConverter.ConvertO(__workflow_browserDoesElementExistparentElementHandle);
                    browserDoesElementExistpropCount++;
                }

                if (__workflow_browserDoesElementExistsearchElementHandle != null)
                {
                    browserDoesElementExist["SearchElementHandle"] = ExpressionConverter.ConvertO(__workflow_browserDoesElementExistsearchElementHandle);
                    browserDoesElementExistpropCount++;
                }

                if (__workflow_browserDoesElementExistsearchElementName != null)
                {
                    browserDoesElementExist["SearchElementName"] = ExpressionConverter.ConvertO(__workflow_browserDoesElementExistsearchElementName);
                    browserDoesElementExistpropCount++;
                }

                if (__workflow_browserDoesElementExistsearchElementID != null)
                {
                    browserDoesElementExist["SearchElementID"] = ExpressionConverter.ConvertO(__workflow_browserDoesElementExistsearchElementID);
                    browserDoesElementExistpropCount++;
                }

                if (__workflow_browserDoesElementExistsearchElementTagName != null)
                {
                    browserDoesElementExist["SearchElementTagName"] = ExpressionConverter.ConvertO(__workflow_browserDoesElementExistsearchElementTagName);
                    browserDoesElementExistpropCount++;
                }

                if (__workflow_browserDoesElementExistsearchElementXPath != null)
                {
                    browserDoesElementExist["SearchElementXPath"] = ExpressionConverter.ConvertO(__workflow_browserDoesElementExistsearchElementXPath);
                    browserDoesElementExistpropCount++;
                }

                if (__workflow_browserDoesElementExistsearchElementClassName != null)
                {
                    browserDoesElementExist["SearchElementClassName"] = ExpressionConverter.ConvertO(__workflow_browserDoesElementExistsearchElementClassName);
                    browserDoesElementExistpropCount++;
                }

                if (__workflow_browserDoesElementExistsearchElementCSSSelector != null)
                {
                    browserDoesElementExist["SearchElementCSSSelector"] = ExpressionConverter.ConvertO(__workflow_browserDoesElementExistsearchElementCSSSelector);
                    browserDoesElementExistpropCount++;
                }

                if (__workflow_browserDoesElementExistsearchElementIndex != null)
                {
                    if (__workflow_browserDoesElementExistsearchElementIndex != null)
                    {
                        browserDoesElementExist["SearchElementIndex"] = ExpressionConverter.ConvertO(__workflow_browserDoesElementExistsearchElementIndex);
                        browserDoesElementExistpropCount++;
                    }

                    browserDoesElementExistpropCount++;
                }
                else
                {
                    browserDoesElementExist["SearchElementIndex"] = 1;
                    browserDoesElementExistpropCount++;
                }

                if (__workflow_browserDoesElementExistsearchElementMatchValue != null)
                {
                    browserDoesElementExist["SearchElementMatchValue"] = ExpressionConverter.ConvertO(__workflow_browserDoesElementExistsearchElementMatchValue);
                    browserDoesElementExistpropCount++;
                }

                if (__workflow_browserDoesElementExistsearchElementMatchText != null)
                {
                    browserDoesElementExist["SearchElementMatchText"] = ExpressionConverter.ConvertO(__workflow_browserDoesElementExistsearchElementMatchText);
                    browserDoesElementExistpropCount++;
                }

                if (__workflow_browserDoesElementExistsearchElementType != null)
                {
                    browserDoesElementExist["SearchElementType"] = ExpressionConverter.ConvertO(__workflow_browserDoesElementExistsearchElementType);
                    browserDoesElementExistpropCount++;
                }

                if (__workflow_browserDoesElementExistsearchElementMinimumWidth != null)
                {
                    if (__workflow_browserDoesElementExistsearchElementMinimumWidth != null)
                    {
                        browserDoesElementExist["SearchElementMinimumWidth"] = ExpressionConverter.ConvertO(__workflow_browserDoesElementExistsearchElementMinimumWidth);
                        browserDoesElementExistpropCount++;
                    }

                    browserDoesElementExistpropCount++;
                }
                else
                {
                    browserDoesElementExist["SearchElementMinimumWidth"] = 1;
                    browserDoesElementExistpropCount++;
                }

                if (__workflow_browserDoesElementExistsearchElementMinimumHeight != null)
                {
                    if (__workflow_browserDoesElementExistsearchElementMinimumHeight != null)
                    {
                        browserDoesElementExist["SearchElementMinimumHeight"] = ExpressionConverter.ConvertO(__workflow_browserDoesElementExistsearchElementMinimumHeight);
                        browserDoesElementExistpropCount++;
                    }

                    browserDoesElementExistpropCount++;
                }
                else
                {
                    browserDoesElementExist["SearchElementMinimumHeight"] = 1;
                    browserDoesElementExistpropCount++;
                }

                if (__workflow_browserDoesElementExistsearchElementBoundingBoxLeft != null)
                {
                    if (__workflow_browserDoesElementExistsearchElementBoundingBoxLeft != null)
                    {
                        browserDoesElementExist["SearchElementBoundingBoxLeft"] = ExpressionConverter.ConvertO(__workflow_browserDoesElementExistsearchElementBoundingBoxLeft);
                        browserDoesElementExistpropCount++;
                    }

                    browserDoesElementExistpropCount++;
                }
                else
                {
                    browserDoesElementExist["SearchElementBoundingBoxLeft"] = -99999;
                    browserDoesElementExistpropCount++;
                }

                if (__workflow_browserDoesElementExistsearchElementBoundingBoxRight != null)
                {
                    if (__workflow_browserDoesElementExistsearchElementBoundingBoxRight != null)
                    {
                        browserDoesElementExist["SearchElementBoundingBoxRight"] = ExpressionConverter.ConvertO(__workflow_browserDoesElementExistsearchElementBoundingBoxRight);
                        browserDoesElementExistpropCount++;
                    }

                    browserDoesElementExistpropCount++;
                }
                else
                {
                    browserDoesElementExist["SearchElementBoundingBoxRight"] = 99999;
                    browserDoesElementExistpropCount++;
                }

                if (__workflow_browserDoesElementExistsearchElementBoundingBoxTop != null)
                {
                    if (__workflow_browserDoesElementExistsearchElementBoundingBoxTop != null)
                    {
                        browserDoesElementExist["SearchElementBoundingBoxTop"] = ExpressionConverter.ConvertO(__workflow_browserDoesElementExistsearchElementBoundingBoxTop);
                        browserDoesElementExistpropCount++;
                    }

                    browserDoesElementExistpropCount++;
                }
                else
                {
                    browserDoesElementExist["SearchElementBoundingBoxTop"] = -99999;
                    browserDoesElementExistpropCount++;
                }

                if (__workflow_browserDoesElementExistsearchElementBoundingBoxBottom != null)
                {
                    if (__workflow_browserDoesElementExistsearchElementBoundingBoxBottom != null)
                    {
                        browserDoesElementExist["SearchElementBoundingBoxBottom"] = ExpressionConverter.ConvertO(__workflow_browserDoesElementExistsearchElementBoundingBoxBottom);
                        browserDoesElementExistpropCount++;
                    }

                    browserDoesElementExistpropCount++;
                }
                else
                {
                    browserDoesElementExist["SearchElementBoundingBoxBottom"] = 99999;
                    browserDoesElementExistpropCount++;
                }

                if (__workflow_browserDoesElementExistonlyElementTopLeftNeedsToBeInBoundingBox != null)
                {
                    if (__workflow_browserDoesElementExistonlyElementTopLeftNeedsToBeInBoundingBox != null)
                    {
                        browserDoesElementExist["OnlyElementTopLeftNeedsToBeInBoundingBox"] = ExpressionConverter.ConvertO(__workflow_browserDoesElementExistonlyElementTopLeftNeedsToBeInBoundingBox);
                        browserDoesElementExistpropCount++;
                    }

                    browserDoesElementExistpropCount++;
                }
                else
                {
                    browserDoesElementExist["OnlyElementTopLeftNeedsToBeInBoundingBox"] = false;
                    browserDoesElementExistpropCount++;
                }

                browserDoesElementExistpropCount++;
                browserDoesElementExist["Workflow"] = ExpressionConverter.ConvertO(__workflow_browserDoesElementExistworkflow);
                if (browserDoesElementExistpropCount > 0)
                {
                    callPayload.Body = browserDoesElementExist;
                }

                return new ApiConnectionAction<BrowserDoesElementExistResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserCreateHandleToElementResponse> BrowserCreateHandleToElement(Expression<Func<string>> browserCreateHandleToElementworkflow, Expression<Func<double>> browserCreateHandleToElementparentElementHandle = null, Expression<Func<double>> browserCreateHandleToElementsearchElementHandle = null, Expression<Func<string>> browserCreateHandleToElementsearchElementName = null, Expression<Func<string>> browserCreateHandleToElementsearchElementID = null, Expression<Func<string>> browserCreateHandleToElementsearchElementTagName = null, Expression<Func<string>> browserCreateHandleToElementsearchElementXPath = null, Expression<Func<string>> browserCreateHandleToElementsearchElementClassName = null, Expression<Func<string>> browserCreateHandleToElementsearchElementCSSSelector = null, Expression<Func<double>> browserCreateHandleToElementsearchElementIndex = null, Expression<Func<string>> browserCreateHandleToElementsearchElementMatchValue = null, Expression<Func<string>> browserCreateHandleToElementsearchElementMatchText = null, Expression<Func<string>> browserCreateHandleToElementsearchElementType = null, Expression<Func<double>> browserCreateHandleToElementsearchElementMinimumWidth = null, Expression<Func<double>> browserCreateHandleToElementsearchElementMinimumHeight = null, Expression<Func<double>> browserCreateHandleToElementsearchElementBoundingBoxLeft = null, Expression<Func<double>> browserCreateHandleToElementsearchElementBoundingBoxRight = null, Expression<Func<double>> browserCreateHandleToElementsearchElementBoundingBoxTop = null, Expression<Func<double>> browserCreateHandleToElementsearchElementBoundingBoxBottom = null, Expression<Func<bool>> browserCreateHandleToElementonlyElementTopLeftNeedsToBeInBoundingBox = null)
        {
            var __workflow_browserCreateHandleToElementworkflow = WorkflowExpression.Compile(browserCreateHandleToElementworkflow, nameof(browserCreateHandleToElementworkflow), required: true);
            var __workflow_browserCreateHandleToElementparentElementHandle = WorkflowExpression.Compile(browserCreateHandleToElementparentElementHandle, nameof(browserCreateHandleToElementparentElementHandle), required: false);
            var __workflow_browserCreateHandleToElementsearchElementHandle = WorkflowExpression.Compile(browserCreateHandleToElementsearchElementHandle, nameof(browserCreateHandleToElementsearchElementHandle), required: false);
            var __workflow_browserCreateHandleToElementsearchElementName = WorkflowExpression.Compile(browserCreateHandleToElementsearchElementName, nameof(browserCreateHandleToElementsearchElementName), required: false);
            var __workflow_browserCreateHandleToElementsearchElementID = WorkflowExpression.Compile(browserCreateHandleToElementsearchElementID, nameof(browserCreateHandleToElementsearchElementID), required: false);
            var __workflow_browserCreateHandleToElementsearchElementTagName = WorkflowExpression.Compile(browserCreateHandleToElementsearchElementTagName, nameof(browserCreateHandleToElementsearchElementTagName), required: false);
            var __workflow_browserCreateHandleToElementsearchElementXPath = WorkflowExpression.Compile(browserCreateHandleToElementsearchElementXPath, nameof(browserCreateHandleToElementsearchElementXPath), required: false);
            var __workflow_browserCreateHandleToElementsearchElementClassName = WorkflowExpression.Compile(browserCreateHandleToElementsearchElementClassName, nameof(browserCreateHandleToElementsearchElementClassName), required: false);
            var __workflow_browserCreateHandleToElementsearchElementCSSSelector = WorkflowExpression.Compile(browserCreateHandleToElementsearchElementCSSSelector, nameof(browserCreateHandleToElementsearchElementCSSSelector), required: false);
            var __workflow_browserCreateHandleToElementsearchElementIndex = WorkflowExpression.Compile(browserCreateHandleToElementsearchElementIndex, nameof(browserCreateHandleToElementsearchElementIndex), required: false);
            var __workflow_browserCreateHandleToElementsearchElementMatchValue = WorkflowExpression.Compile(browserCreateHandleToElementsearchElementMatchValue, nameof(browserCreateHandleToElementsearchElementMatchValue), required: false);
            var __workflow_browserCreateHandleToElementsearchElementMatchText = WorkflowExpression.Compile(browserCreateHandleToElementsearchElementMatchText, nameof(browserCreateHandleToElementsearchElementMatchText), required: false);
            var __workflow_browserCreateHandleToElementsearchElementType = WorkflowExpression.Compile(browserCreateHandleToElementsearchElementType, nameof(browserCreateHandleToElementsearchElementType), required: false);
            var __workflow_browserCreateHandleToElementsearchElementMinimumWidth = WorkflowExpression.Compile(browserCreateHandleToElementsearchElementMinimumWidth, nameof(browserCreateHandleToElementsearchElementMinimumWidth), required: false);
            var __workflow_browserCreateHandleToElementsearchElementMinimumHeight = WorkflowExpression.Compile(browserCreateHandleToElementsearchElementMinimumHeight, nameof(browserCreateHandleToElementsearchElementMinimumHeight), required: false);
            var __workflow_browserCreateHandleToElementsearchElementBoundingBoxLeft = WorkflowExpression.Compile(browserCreateHandleToElementsearchElementBoundingBoxLeft, nameof(browserCreateHandleToElementsearchElementBoundingBoxLeft), required: false);
            var __workflow_browserCreateHandleToElementsearchElementBoundingBoxRight = WorkflowExpression.Compile(browserCreateHandleToElementsearchElementBoundingBoxRight, nameof(browserCreateHandleToElementsearchElementBoundingBoxRight), required: false);
            var __workflow_browserCreateHandleToElementsearchElementBoundingBoxTop = WorkflowExpression.Compile(browserCreateHandleToElementsearchElementBoundingBoxTop, nameof(browserCreateHandleToElementsearchElementBoundingBoxTop), required: false);
            var __workflow_browserCreateHandleToElementsearchElementBoundingBoxBottom = WorkflowExpression.Compile(browserCreateHandleToElementsearchElementBoundingBoxBottom, nameof(browserCreateHandleToElementsearchElementBoundingBoxBottom), required: false);
            var __workflow_browserCreateHandleToElementonlyElementTopLeftNeedsToBeInBoundingBox = WorkflowExpression.Compile(browserCreateHandleToElementonlyElementTopLeftNeedsToBeInBoundingBox, nameof(browserCreateHandleToElementonlyElementTopLeftNeedsToBeInBoundingBox), required: false);
            return new DeferredBodyAction<BrowserCreateHandleToElementResponse>(() =>
            {
                var apiCallPath = "/BrowserControl/CreateHandleToElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserCreateHandleToElement = new JObject();
                var browserCreateHandleToElementpropCount = 0;
                if (__workflow_browserCreateHandleToElementparentElementHandle != null)
                {
                    browserCreateHandleToElement["ParentElementHandle"] = ExpressionConverter.ConvertO(__workflow_browserCreateHandleToElementparentElementHandle);
                    browserCreateHandleToElementpropCount++;
                }

                if (__workflow_browserCreateHandleToElementsearchElementHandle != null)
                {
                    browserCreateHandleToElement["SearchElementHandle"] = ExpressionConverter.ConvertO(__workflow_browserCreateHandleToElementsearchElementHandle);
                    browserCreateHandleToElementpropCount++;
                }

                if (__workflow_browserCreateHandleToElementsearchElementName != null)
                {
                    browserCreateHandleToElement["SearchElementName"] = ExpressionConverter.ConvertO(__workflow_browserCreateHandleToElementsearchElementName);
                    browserCreateHandleToElementpropCount++;
                }

                if (__workflow_browserCreateHandleToElementsearchElementID != null)
                {
                    browserCreateHandleToElement["SearchElementID"] = ExpressionConverter.ConvertO(__workflow_browserCreateHandleToElementsearchElementID);
                    browserCreateHandleToElementpropCount++;
                }

                if (__workflow_browserCreateHandleToElementsearchElementTagName != null)
                {
                    browserCreateHandleToElement["SearchElementTagName"] = ExpressionConverter.ConvertO(__workflow_browserCreateHandleToElementsearchElementTagName);
                    browserCreateHandleToElementpropCount++;
                }

                if (__workflow_browserCreateHandleToElementsearchElementXPath != null)
                {
                    browserCreateHandleToElement["SearchElementXPath"] = ExpressionConverter.ConvertO(__workflow_browserCreateHandleToElementsearchElementXPath);
                    browserCreateHandleToElementpropCount++;
                }

                if (__workflow_browserCreateHandleToElementsearchElementClassName != null)
                {
                    browserCreateHandleToElement["SearchElementClassName"] = ExpressionConverter.ConvertO(__workflow_browserCreateHandleToElementsearchElementClassName);
                    browserCreateHandleToElementpropCount++;
                }

                if (__workflow_browserCreateHandleToElementsearchElementCSSSelector != null)
                {
                    browserCreateHandleToElement["SearchElementCSSSelector"] = ExpressionConverter.ConvertO(__workflow_browserCreateHandleToElementsearchElementCSSSelector);
                    browserCreateHandleToElementpropCount++;
                }

                if (__workflow_browserCreateHandleToElementsearchElementIndex != null)
                {
                    if (__workflow_browserCreateHandleToElementsearchElementIndex != null)
                    {
                        browserCreateHandleToElement["SearchElementIndex"] = ExpressionConverter.ConvertO(__workflow_browserCreateHandleToElementsearchElementIndex);
                        browserCreateHandleToElementpropCount++;
                    }

                    browserCreateHandleToElementpropCount++;
                }
                else
                {
                    browserCreateHandleToElement["SearchElementIndex"] = 1;
                    browserCreateHandleToElementpropCount++;
                }

                if (__workflow_browserCreateHandleToElementsearchElementMatchValue != null)
                {
                    browserCreateHandleToElement["SearchElementMatchValue"] = ExpressionConverter.ConvertO(__workflow_browserCreateHandleToElementsearchElementMatchValue);
                    browserCreateHandleToElementpropCount++;
                }

                if (__workflow_browserCreateHandleToElementsearchElementMatchText != null)
                {
                    browserCreateHandleToElement["SearchElementMatchText"] = ExpressionConverter.ConvertO(__workflow_browserCreateHandleToElementsearchElementMatchText);
                    browserCreateHandleToElementpropCount++;
                }

                if (__workflow_browserCreateHandleToElementsearchElementType != null)
                {
                    browserCreateHandleToElement["SearchElementType"] = ExpressionConverter.ConvertO(__workflow_browserCreateHandleToElementsearchElementType);
                    browserCreateHandleToElementpropCount++;
                }

                if (__workflow_browserCreateHandleToElementsearchElementMinimumWidth != null)
                {
                    if (__workflow_browserCreateHandleToElementsearchElementMinimumWidth != null)
                    {
                        browserCreateHandleToElement["SearchElementMinimumWidth"] = ExpressionConverter.ConvertO(__workflow_browserCreateHandleToElementsearchElementMinimumWidth);
                        browserCreateHandleToElementpropCount++;
                    }

                    browserCreateHandleToElementpropCount++;
                }
                else
                {
                    browserCreateHandleToElement["SearchElementMinimumWidth"] = 1;
                    browserCreateHandleToElementpropCount++;
                }

                if (__workflow_browserCreateHandleToElementsearchElementMinimumHeight != null)
                {
                    if (__workflow_browserCreateHandleToElementsearchElementMinimumHeight != null)
                    {
                        browserCreateHandleToElement["SearchElementMinimumHeight"] = ExpressionConverter.ConvertO(__workflow_browserCreateHandleToElementsearchElementMinimumHeight);
                        browserCreateHandleToElementpropCount++;
                    }

                    browserCreateHandleToElementpropCount++;
                }
                else
                {
                    browserCreateHandleToElement["SearchElementMinimumHeight"] = 1;
                    browserCreateHandleToElementpropCount++;
                }

                if (__workflow_browserCreateHandleToElementsearchElementBoundingBoxLeft != null)
                {
                    if (__workflow_browserCreateHandleToElementsearchElementBoundingBoxLeft != null)
                    {
                        browserCreateHandleToElement["SearchElementBoundingBoxLeft"] = ExpressionConverter.ConvertO(__workflow_browserCreateHandleToElementsearchElementBoundingBoxLeft);
                        browserCreateHandleToElementpropCount++;
                    }

                    browserCreateHandleToElementpropCount++;
                }
                else
                {
                    browserCreateHandleToElement["SearchElementBoundingBoxLeft"] = -99999;
                    browserCreateHandleToElementpropCount++;
                }

                if (__workflow_browserCreateHandleToElementsearchElementBoundingBoxRight != null)
                {
                    if (__workflow_browserCreateHandleToElementsearchElementBoundingBoxRight != null)
                    {
                        browserCreateHandleToElement["SearchElementBoundingBoxRight"] = ExpressionConverter.ConvertO(__workflow_browserCreateHandleToElementsearchElementBoundingBoxRight);
                        browserCreateHandleToElementpropCount++;
                    }

                    browserCreateHandleToElementpropCount++;
                }
                else
                {
                    browserCreateHandleToElement["SearchElementBoundingBoxRight"] = 99999;
                    browserCreateHandleToElementpropCount++;
                }

                if (__workflow_browserCreateHandleToElementsearchElementBoundingBoxTop != null)
                {
                    if (__workflow_browserCreateHandleToElementsearchElementBoundingBoxTop != null)
                    {
                        browserCreateHandleToElement["SearchElementBoundingBoxTop"] = ExpressionConverter.ConvertO(__workflow_browserCreateHandleToElementsearchElementBoundingBoxTop);
                        browserCreateHandleToElementpropCount++;
                    }

                    browserCreateHandleToElementpropCount++;
                }
                else
                {
                    browserCreateHandleToElement["SearchElementBoundingBoxTop"] = -99999;
                    browserCreateHandleToElementpropCount++;
                }

                if (__workflow_browserCreateHandleToElementsearchElementBoundingBoxBottom != null)
                {
                    if (__workflow_browserCreateHandleToElementsearchElementBoundingBoxBottom != null)
                    {
                        browserCreateHandleToElement["SearchElementBoundingBoxBottom"] = ExpressionConverter.ConvertO(__workflow_browserCreateHandleToElementsearchElementBoundingBoxBottom);
                        browserCreateHandleToElementpropCount++;
                    }

                    browserCreateHandleToElementpropCount++;
                }
                else
                {
                    browserCreateHandleToElement["SearchElementBoundingBoxBottom"] = 99999;
                    browserCreateHandleToElementpropCount++;
                }

                if (__workflow_browserCreateHandleToElementonlyElementTopLeftNeedsToBeInBoundingBox != null)
                {
                    if (__workflow_browserCreateHandleToElementonlyElementTopLeftNeedsToBeInBoundingBox != null)
                    {
                        browserCreateHandleToElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = ExpressionConverter.ConvertO(__workflow_browserCreateHandleToElementonlyElementTopLeftNeedsToBeInBoundingBox);
                        browserCreateHandleToElementpropCount++;
                    }

                    browserCreateHandleToElementpropCount++;
                }
                else
                {
                    browserCreateHandleToElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = false;
                    browserCreateHandleToElementpropCount++;
                }

                browserCreateHandleToElementpropCount++;
                browserCreateHandleToElement["Workflow"] = ExpressionConverter.ConvertO(__workflow_browserCreateHandleToElementworkflow);
                if (browserCreateHandleToElementpropCount > 0)
                {
                    callPayload.Body = browserCreateHandleToElement;
                }

                return new ApiConnectionAction<BrowserCreateHandleToElementResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserCreateHandleToParentElementResponse> BrowserCreateHandleToParentElement(Expression<Func<string>> browserCreateHandleToParentElementworkflow, Expression<Func<double>> browserCreateHandleToParentElementparentElementHandle = null, Expression<Func<double>> browserCreateHandleToParentElementsearchElementHandle = null, Expression<Func<string>> browserCreateHandleToParentElementsearchElementName = null, Expression<Func<string>> browserCreateHandleToParentElementsearchElementID = null, Expression<Func<string>> browserCreateHandleToParentElementsearchElementTagName = null, Expression<Func<string>> browserCreateHandleToParentElementsearchElementXPath = null, Expression<Func<string>> browserCreateHandleToParentElementsearchElementClassName = null, Expression<Func<string>> browserCreateHandleToParentElementsearchElementCSSSelector = null, Expression<Func<double>> browserCreateHandleToParentElementsearchElementIndex = null, Expression<Func<string>> browserCreateHandleToParentElementsearchElementMatchValue = null, Expression<Func<string>> browserCreateHandleToParentElementsearchElementMatchText = null, Expression<Func<string>> browserCreateHandleToParentElementsearchElementType = null, Expression<Func<double>> browserCreateHandleToParentElementsearchElementMinimumWidth = null, Expression<Func<double>> browserCreateHandleToParentElementsearchElementMinimumHeight = null, Expression<Func<double>> browserCreateHandleToParentElementsearchElementBoundingBoxLeft = null, Expression<Func<double>> browserCreateHandleToParentElementsearchElementBoundingBoxRight = null, Expression<Func<double>> browserCreateHandleToParentElementsearchElementBoundingBoxTop = null, Expression<Func<double>> browserCreateHandleToParentElementsearchElementBoundingBoxBottom = null, Expression<Func<bool>> browserCreateHandleToParentElementonlyElementTopLeftNeedsToBeInBoundingBox = null)
        {
            var __workflow_browserCreateHandleToParentElementworkflow = WorkflowExpression.Compile(browserCreateHandleToParentElementworkflow, nameof(browserCreateHandleToParentElementworkflow), required: true);
            var __workflow_browserCreateHandleToParentElementparentElementHandle = WorkflowExpression.Compile(browserCreateHandleToParentElementparentElementHandle, nameof(browserCreateHandleToParentElementparentElementHandle), required: false);
            var __workflow_browserCreateHandleToParentElementsearchElementHandle = WorkflowExpression.Compile(browserCreateHandleToParentElementsearchElementHandle, nameof(browserCreateHandleToParentElementsearchElementHandle), required: false);
            var __workflow_browserCreateHandleToParentElementsearchElementName = WorkflowExpression.Compile(browserCreateHandleToParentElementsearchElementName, nameof(browserCreateHandleToParentElementsearchElementName), required: false);
            var __workflow_browserCreateHandleToParentElementsearchElementID = WorkflowExpression.Compile(browserCreateHandleToParentElementsearchElementID, nameof(browserCreateHandleToParentElementsearchElementID), required: false);
            var __workflow_browserCreateHandleToParentElementsearchElementTagName = WorkflowExpression.Compile(browserCreateHandleToParentElementsearchElementTagName, nameof(browserCreateHandleToParentElementsearchElementTagName), required: false);
            var __workflow_browserCreateHandleToParentElementsearchElementXPath = WorkflowExpression.Compile(browserCreateHandleToParentElementsearchElementXPath, nameof(browserCreateHandleToParentElementsearchElementXPath), required: false);
            var __workflow_browserCreateHandleToParentElementsearchElementClassName = WorkflowExpression.Compile(browserCreateHandleToParentElementsearchElementClassName, nameof(browserCreateHandleToParentElementsearchElementClassName), required: false);
            var __workflow_browserCreateHandleToParentElementsearchElementCSSSelector = WorkflowExpression.Compile(browserCreateHandleToParentElementsearchElementCSSSelector, nameof(browserCreateHandleToParentElementsearchElementCSSSelector), required: false);
            var __workflow_browserCreateHandleToParentElementsearchElementIndex = WorkflowExpression.Compile(browserCreateHandleToParentElementsearchElementIndex, nameof(browserCreateHandleToParentElementsearchElementIndex), required: false);
            var __workflow_browserCreateHandleToParentElementsearchElementMatchValue = WorkflowExpression.Compile(browserCreateHandleToParentElementsearchElementMatchValue, nameof(browserCreateHandleToParentElementsearchElementMatchValue), required: false);
            var __workflow_browserCreateHandleToParentElementsearchElementMatchText = WorkflowExpression.Compile(browserCreateHandleToParentElementsearchElementMatchText, nameof(browserCreateHandleToParentElementsearchElementMatchText), required: false);
            var __workflow_browserCreateHandleToParentElementsearchElementType = WorkflowExpression.Compile(browserCreateHandleToParentElementsearchElementType, nameof(browserCreateHandleToParentElementsearchElementType), required: false);
            var __workflow_browserCreateHandleToParentElementsearchElementMinimumWidth = WorkflowExpression.Compile(browserCreateHandleToParentElementsearchElementMinimumWidth, nameof(browserCreateHandleToParentElementsearchElementMinimumWidth), required: false);
            var __workflow_browserCreateHandleToParentElementsearchElementMinimumHeight = WorkflowExpression.Compile(browserCreateHandleToParentElementsearchElementMinimumHeight, nameof(browserCreateHandleToParentElementsearchElementMinimumHeight), required: false);
            var __workflow_browserCreateHandleToParentElementsearchElementBoundingBoxLeft = WorkflowExpression.Compile(browserCreateHandleToParentElementsearchElementBoundingBoxLeft, nameof(browserCreateHandleToParentElementsearchElementBoundingBoxLeft), required: false);
            var __workflow_browserCreateHandleToParentElementsearchElementBoundingBoxRight = WorkflowExpression.Compile(browserCreateHandleToParentElementsearchElementBoundingBoxRight, nameof(browserCreateHandleToParentElementsearchElementBoundingBoxRight), required: false);
            var __workflow_browserCreateHandleToParentElementsearchElementBoundingBoxTop = WorkflowExpression.Compile(browserCreateHandleToParentElementsearchElementBoundingBoxTop, nameof(browserCreateHandleToParentElementsearchElementBoundingBoxTop), required: false);
            var __workflow_browserCreateHandleToParentElementsearchElementBoundingBoxBottom = WorkflowExpression.Compile(browserCreateHandleToParentElementsearchElementBoundingBoxBottom, nameof(browserCreateHandleToParentElementsearchElementBoundingBoxBottom), required: false);
            var __workflow_browserCreateHandleToParentElementonlyElementTopLeftNeedsToBeInBoundingBox = WorkflowExpression.Compile(browserCreateHandleToParentElementonlyElementTopLeftNeedsToBeInBoundingBox, nameof(browserCreateHandleToParentElementonlyElementTopLeftNeedsToBeInBoundingBox), required: false);
            return new DeferredBodyAction<BrowserCreateHandleToParentElementResponse>(() =>
            {
                var apiCallPath = "/BrowserControl/CreateHandleToParentElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserCreateHandleToParentElement = new JObject();
                var browserCreateHandleToParentElementpropCount = 0;
                if (__workflow_browserCreateHandleToParentElementparentElementHandle != null)
                {
                    browserCreateHandleToParentElement["ParentElementHandle"] = ExpressionConverter.ConvertO(__workflow_browserCreateHandleToParentElementparentElementHandle);
                    browserCreateHandleToParentElementpropCount++;
                }

                if (__workflow_browserCreateHandleToParentElementsearchElementHandle != null)
                {
                    browserCreateHandleToParentElement["SearchElementHandle"] = ExpressionConverter.ConvertO(__workflow_browserCreateHandleToParentElementsearchElementHandle);
                    browserCreateHandleToParentElementpropCount++;
                }

                if (__workflow_browserCreateHandleToParentElementsearchElementName != null)
                {
                    browserCreateHandleToParentElement["SearchElementName"] = ExpressionConverter.ConvertO(__workflow_browserCreateHandleToParentElementsearchElementName);
                    browserCreateHandleToParentElementpropCount++;
                }

                if (__workflow_browserCreateHandleToParentElementsearchElementID != null)
                {
                    browserCreateHandleToParentElement["SearchElementID"] = ExpressionConverter.ConvertO(__workflow_browserCreateHandleToParentElementsearchElementID);
                    browserCreateHandleToParentElementpropCount++;
                }

                if (__workflow_browserCreateHandleToParentElementsearchElementTagName != null)
                {
                    browserCreateHandleToParentElement["SearchElementTagName"] = ExpressionConverter.ConvertO(__workflow_browserCreateHandleToParentElementsearchElementTagName);
                    browserCreateHandleToParentElementpropCount++;
                }

                if (__workflow_browserCreateHandleToParentElementsearchElementXPath != null)
                {
                    browserCreateHandleToParentElement["SearchElementXPath"] = ExpressionConverter.ConvertO(__workflow_browserCreateHandleToParentElementsearchElementXPath);
                    browserCreateHandleToParentElementpropCount++;
                }

                if (__workflow_browserCreateHandleToParentElementsearchElementClassName != null)
                {
                    browserCreateHandleToParentElement["SearchElementClassName"] = ExpressionConverter.ConvertO(__workflow_browserCreateHandleToParentElementsearchElementClassName);
                    browserCreateHandleToParentElementpropCount++;
                }

                if (__workflow_browserCreateHandleToParentElementsearchElementCSSSelector != null)
                {
                    browserCreateHandleToParentElement["SearchElementCSSSelector"] = ExpressionConverter.ConvertO(__workflow_browserCreateHandleToParentElementsearchElementCSSSelector);
                    browserCreateHandleToParentElementpropCount++;
                }

                if (__workflow_browserCreateHandleToParentElementsearchElementIndex != null)
                {
                    if (__workflow_browserCreateHandleToParentElementsearchElementIndex != null)
                    {
                        browserCreateHandleToParentElement["SearchElementIndex"] = ExpressionConverter.ConvertO(__workflow_browserCreateHandleToParentElementsearchElementIndex);
                        browserCreateHandleToParentElementpropCount++;
                    }

                    browserCreateHandleToParentElementpropCount++;
                }
                else
                {
                    browserCreateHandleToParentElement["SearchElementIndex"] = 1;
                    browserCreateHandleToParentElementpropCount++;
                }

                if (__workflow_browserCreateHandleToParentElementsearchElementMatchValue != null)
                {
                    browserCreateHandleToParentElement["SearchElementMatchValue"] = ExpressionConverter.ConvertO(__workflow_browserCreateHandleToParentElementsearchElementMatchValue);
                    browserCreateHandleToParentElementpropCount++;
                }

                if (__workflow_browserCreateHandleToParentElementsearchElementMatchText != null)
                {
                    browserCreateHandleToParentElement["SearchElementMatchText"] = ExpressionConverter.ConvertO(__workflow_browserCreateHandleToParentElementsearchElementMatchText);
                    browserCreateHandleToParentElementpropCount++;
                }

                if (__workflow_browserCreateHandleToParentElementsearchElementType != null)
                {
                    browserCreateHandleToParentElement["SearchElementType"] = ExpressionConverter.ConvertO(__workflow_browserCreateHandleToParentElementsearchElementType);
                    browserCreateHandleToParentElementpropCount++;
                }

                if (__workflow_browserCreateHandleToParentElementsearchElementMinimumWidth != null)
                {
                    if (__workflow_browserCreateHandleToParentElementsearchElementMinimumWidth != null)
                    {
                        browserCreateHandleToParentElement["SearchElementMinimumWidth"] = ExpressionConverter.ConvertO(__workflow_browserCreateHandleToParentElementsearchElementMinimumWidth);
                        browserCreateHandleToParentElementpropCount++;
                    }

                    browserCreateHandleToParentElementpropCount++;
                }
                else
                {
                    browserCreateHandleToParentElement["SearchElementMinimumWidth"] = 1;
                    browserCreateHandleToParentElementpropCount++;
                }

                if (__workflow_browserCreateHandleToParentElementsearchElementMinimumHeight != null)
                {
                    if (__workflow_browserCreateHandleToParentElementsearchElementMinimumHeight != null)
                    {
                        browserCreateHandleToParentElement["SearchElementMinimumHeight"] = ExpressionConverter.ConvertO(__workflow_browserCreateHandleToParentElementsearchElementMinimumHeight);
                        browserCreateHandleToParentElementpropCount++;
                    }

                    browserCreateHandleToParentElementpropCount++;
                }
                else
                {
                    browserCreateHandleToParentElement["SearchElementMinimumHeight"] = 1;
                    browserCreateHandleToParentElementpropCount++;
                }

                if (__workflow_browserCreateHandleToParentElementsearchElementBoundingBoxLeft != null)
                {
                    if (__workflow_browserCreateHandleToParentElementsearchElementBoundingBoxLeft != null)
                    {
                        browserCreateHandleToParentElement["SearchElementBoundingBoxLeft"] = ExpressionConverter.ConvertO(__workflow_browserCreateHandleToParentElementsearchElementBoundingBoxLeft);
                        browserCreateHandleToParentElementpropCount++;
                    }

                    browserCreateHandleToParentElementpropCount++;
                }
                else
                {
                    browserCreateHandleToParentElement["SearchElementBoundingBoxLeft"] = -99999;
                    browserCreateHandleToParentElementpropCount++;
                }

                if (__workflow_browserCreateHandleToParentElementsearchElementBoundingBoxRight != null)
                {
                    if (__workflow_browserCreateHandleToParentElementsearchElementBoundingBoxRight != null)
                    {
                        browserCreateHandleToParentElement["SearchElementBoundingBoxRight"] = ExpressionConverter.ConvertO(__workflow_browserCreateHandleToParentElementsearchElementBoundingBoxRight);
                        browserCreateHandleToParentElementpropCount++;
                    }

                    browserCreateHandleToParentElementpropCount++;
                }
                else
                {
                    browserCreateHandleToParentElement["SearchElementBoundingBoxRight"] = 99999;
                    browserCreateHandleToParentElementpropCount++;
                }

                if (__workflow_browserCreateHandleToParentElementsearchElementBoundingBoxTop != null)
                {
                    if (__workflow_browserCreateHandleToParentElementsearchElementBoundingBoxTop != null)
                    {
                        browserCreateHandleToParentElement["SearchElementBoundingBoxTop"] = ExpressionConverter.ConvertO(__workflow_browserCreateHandleToParentElementsearchElementBoundingBoxTop);
                        browserCreateHandleToParentElementpropCount++;
                    }

                    browserCreateHandleToParentElementpropCount++;
                }
                else
                {
                    browserCreateHandleToParentElement["SearchElementBoundingBoxTop"] = -99999;
                    browserCreateHandleToParentElementpropCount++;
                }

                if (__workflow_browserCreateHandleToParentElementsearchElementBoundingBoxBottom != null)
                {
                    if (__workflow_browserCreateHandleToParentElementsearchElementBoundingBoxBottom != null)
                    {
                        browserCreateHandleToParentElement["SearchElementBoundingBoxBottom"] = ExpressionConverter.ConvertO(__workflow_browserCreateHandleToParentElementsearchElementBoundingBoxBottom);
                        browserCreateHandleToParentElementpropCount++;
                    }

                    browserCreateHandleToParentElementpropCount++;
                }
                else
                {
                    browserCreateHandleToParentElement["SearchElementBoundingBoxBottom"] = 99999;
                    browserCreateHandleToParentElementpropCount++;
                }

                if (__workflow_browserCreateHandleToParentElementonlyElementTopLeftNeedsToBeInBoundingBox != null)
                {
                    if (__workflow_browserCreateHandleToParentElementonlyElementTopLeftNeedsToBeInBoundingBox != null)
                    {
                        browserCreateHandleToParentElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = ExpressionConverter.ConvertO(__workflow_browserCreateHandleToParentElementonlyElementTopLeftNeedsToBeInBoundingBox);
                        browserCreateHandleToParentElementpropCount++;
                    }

                    browserCreateHandleToParentElementpropCount++;
                }
                else
                {
                    browserCreateHandleToParentElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = false;
                    browserCreateHandleToParentElementpropCount++;
                }

                browserCreateHandleToParentElementpropCount++;
                browserCreateHandleToParentElement["Workflow"] = ExpressionConverter.ConvertO(__workflow_browserCreateHandleToParentElementworkflow);
                if (browserCreateHandleToParentElementpropCount > 0)
                {
                    callPayload.Body = browserCreateHandleToParentElement;
                }

                return new ApiConnectionAction<BrowserCreateHandleToParentElementResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserGetElementPropertiesResponse> BrowserGetElementProperties(Expression<Func<string>> browserGetElementPropertiesworkflow, Expression<Func<double>> browserGetElementPropertiesparentElementHandle = null, Expression<Func<double>> browserGetElementPropertiessearchElementHandle = null, Expression<Func<string>> browserGetElementPropertiessearchElementName = null, Expression<Func<string>> browserGetElementPropertiessearchElementID = null, Expression<Func<string>> browserGetElementPropertiessearchElementTagName = null, Expression<Func<string>> browserGetElementPropertiessearchElementXPath = null, Expression<Func<string>> browserGetElementPropertiessearchElementClassName = null, Expression<Func<string>> browserGetElementPropertiessearchElementCSSSelector = null, Expression<Func<double>> browserGetElementPropertiessearchElementIndex = null, Expression<Func<string>> browserGetElementPropertiessearchElementMatchValue = null, Expression<Func<string>> browserGetElementPropertiessearchElementMatchText = null, Expression<Func<string>> browserGetElementPropertiessearchElementType = null, Expression<Func<double>> browserGetElementPropertiessearchElementMinimumWidth = null, Expression<Func<double>> browserGetElementPropertiessearchElementMinimumHeight = null, Expression<Func<double>> browserGetElementPropertiessearchElementBoundingBoxLeft = null, Expression<Func<double>> browserGetElementPropertiessearchElementBoundingBoxRight = null, Expression<Func<double>> browserGetElementPropertiessearchElementBoundingBoxTop = null, Expression<Func<double>> browserGetElementPropertiessearchElementBoundingBoxBottom = null, Expression<Func<bool>> browserGetElementPropertiesonlyElementTopLeftNeedsToBeInBoundingBox = null, Expression<Func<bool>> browserGetElementPropertiesgetHTMLCode = null, Expression<Func<bool>> browserGetElementPropertiesreturnElementHandle = null)
        {
            var __workflow_browserGetElementPropertiesworkflow = WorkflowExpression.Compile(browserGetElementPropertiesworkflow, nameof(browserGetElementPropertiesworkflow), required: true);
            var __workflow_browserGetElementPropertiesparentElementHandle = WorkflowExpression.Compile(browserGetElementPropertiesparentElementHandle, nameof(browserGetElementPropertiesparentElementHandle), required: false);
            var __workflow_browserGetElementPropertiessearchElementHandle = WorkflowExpression.Compile(browserGetElementPropertiessearchElementHandle, nameof(browserGetElementPropertiessearchElementHandle), required: false);
            var __workflow_browserGetElementPropertiessearchElementName = WorkflowExpression.Compile(browserGetElementPropertiessearchElementName, nameof(browserGetElementPropertiessearchElementName), required: false);
            var __workflow_browserGetElementPropertiessearchElementID = WorkflowExpression.Compile(browserGetElementPropertiessearchElementID, nameof(browserGetElementPropertiessearchElementID), required: false);
            var __workflow_browserGetElementPropertiessearchElementTagName = WorkflowExpression.Compile(browserGetElementPropertiessearchElementTagName, nameof(browserGetElementPropertiessearchElementTagName), required: false);
            var __workflow_browserGetElementPropertiessearchElementXPath = WorkflowExpression.Compile(browserGetElementPropertiessearchElementXPath, nameof(browserGetElementPropertiessearchElementXPath), required: false);
            var __workflow_browserGetElementPropertiessearchElementClassName = WorkflowExpression.Compile(browserGetElementPropertiessearchElementClassName, nameof(browserGetElementPropertiessearchElementClassName), required: false);
            var __workflow_browserGetElementPropertiessearchElementCSSSelector = WorkflowExpression.Compile(browserGetElementPropertiessearchElementCSSSelector, nameof(browserGetElementPropertiessearchElementCSSSelector), required: false);
            var __workflow_browserGetElementPropertiessearchElementIndex = WorkflowExpression.Compile(browserGetElementPropertiessearchElementIndex, nameof(browserGetElementPropertiessearchElementIndex), required: false);
            var __workflow_browserGetElementPropertiessearchElementMatchValue = WorkflowExpression.Compile(browserGetElementPropertiessearchElementMatchValue, nameof(browserGetElementPropertiessearchElementMatchValue), required: false);
            var __workflow_browserGetElementPropertiessearchElementMatchText = WorkflowExpression.Compile(browserGetElementPropertiessearchElementMatchText, nameof(browserGetElementPropertiessearchElementMatchText), required: false);
            var __workflow_browserGetElementPropertiessearchElementType = WorkflowExpression.Compile(browserGetElementPropertiessearchElementType, nameof(browserGetElementPropertiessearchElementType), required: false);
            var __workflow_browserGetElementPropertiessearchElementMinimumWidth = WorkflowExpression.Compile(browserGetElementPropertiessearchElementMinimumWidth, nameof(browserGetElementPropertiessearchElementMinimumWidth), required: false);
            var __workflow_browserGetElementPropertiessearchElementMinimumHeight = WorkflowExpression.Compile(browserGetElementPropertiessearchElementMinimumHeight, nameof(browserGetElementPropertiessearchElementMinimumHeight), required: false);
            var __workflow_browserGetElementPropertiessearchElementBoundingBoxLeft = WorkflowExpression.Compile(browserGetElementPropertiessearchElementBoundingBoxLeft, nameof(browserGetElementPropertiessearchElementBoundingBoxLeft), required: false);
            var __workflow_browserGetElementPropertiessearchElementBoundingBoxRight = WorkflowExpression.Compile(browserGetElementPropertiessearchElementBoundingBoxRight, nameof(browserGetElementPropertiessearchElementBoundingBoxRight), required: false);
            var __workflow_browserGetElementPropertiessearchElementBoundingBoxTop = WorkflowExpression.Compile(browserGetElementPropertiessearchElementBoundingBoxTop, nameof(browserGetElementPropertiessearchElementBoundingBoxTop), required: false);
            var __workflow_browserGetElementPropertiessearchElementBoundingBoxBottom = WorkflowExpression.Compile(browserGetElementPropertiessearchElementBoundingBoxBottom, nameof(browserGetElementPropertiessearchElementBoundingBoxBottom), required: false);
            var __workflow_browserGetElementPropertiesonlyElementTopLeftNeedsToBeInBoundingBox = WorkflowExpression.Compile(browserGetElementPropertiesonlyElementTopLeftNeedsToBeInBoundingBox, nameof(browserGetElementPropertiesonlyElementTopLeftNeedsToBeInBoundingBox), required: false);
            var __workflow_browserGetElementPropertiesgetHTMLCode = WorkflowExpression.Compile(browserGetElementPropertiesgetHTMLCode, nameof(browserGetElementPropertiesgetHTMLCode), required: false);
            var __workflow_browserGetElementPropertiesreturnElementHandle = WorkflowExpression.Compile(browserGetElementPropertiesreturnElementHandle, nameof(browserGetElementPropertiesreturnElementHandle), required: false);
            return new DeferredBodyAction<BrowserGetElementPropertiesResponse>(() =>
            {
                var apiCallPath = "/BrowserControl/GetElementProperties";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserGetElementProperties = new JObject();
                var browserGetElementPropertiespropCount = 0;
                if (__workflow_browserGetElementPropertiesparentElementHandle != null)
                {
                    browserGetElementProperties["ParentElementHandle"] = ExpressionConverter.ConvertO(__workflow_browserGetElementPropertiesparentElementHandle);
                    browserGetElementPropertiespropCount++;
                }

                if (__workflow_browserGetElementPropertiessearchElementHandle != null)
                {
                    browserGetElementProperties["SearchElementHandle"] = ExpressionConverter.ConvertO(__workflow_browserGetElementPropertiessearchElementHandle);
                    browserGetElementPropertiespropCount++;
                }

                if (__workflow_browserGetElementPropertiessearchElementName != null)
                {
                    browserGetElementProperties["SearchElementName"] = ExpressionConverter.ConvertO(__workflow_browserGetElementPropertiessearchElementName);
                    browserGetElementPropertiespropCount++;
                }

                if (__workflow_browserGetElementPropertiessearchElementID != null)
                {
                    browserGetElementProperties["SearchElementID"] = ExpressionConverter.ConvertO(__workflow_browserGetElementPropertiessearchElementID);
                    browserGetElementPropertiespropCount++;
                }

                if (__workflow_browserGetElementPropertiessearchElementTagName != null)
                {
                    browserGetElementProperties["SearchElementTagName"] = ExpressionConverter.ConvertO(__workflow_browserGetElementPropertiessearchElementTagName);
                    browserGetElementPropertiespropCount++;
                }

                if (__workflow_browserGetElementPropertiessearchElementXPath != null)
                {
                    browserGetElementProperties["SearchElementXPath"] = ExpressionConverter.ConvertO(__workflow_browserGetElementPropertiessearchElementXPath);
                    browserGetElementPropertiespropCount++;
                }

                if (__workflow_browserGetElementPropertiessearchElementClassName != null)
                {
                    browserGetElementProperties["SearchElementClassName"] = ExpressionConverter.ConvertO(__workflow_browserGetElementPropertiessearchElementClassName);
                    browserGetElementPropertiespropCount++;
                }

                if (__workflow_browserGetElementPropertiessearchElementCSSSelector != null)
                {
                    browserGetElementProperties["SearchElementCSSSelector"] = ExpressionConverter.ConvertO(__workflow_browserGetElementPropertiessearchElementCSSSelector);
                    browserGetElementPropertiespropCount++;
                }

                if (__workflow_browserGetElementPropertiessearchElementIndex != null)
                {
                    if (__workflow_browserGetElementPropertiessearchElementIndex != null)
                    {
                        browserGetElementProperties["SearchElementIndex"] = ExpressionConverter.ConvertO(__workflow_browserGetElementPropertiessearchElementIndex);
                        browserGetElementPropertiespropCount++;
                    }

                    browserGetElementPropertiespropCount++;
                }
                else
                {
                    browserGetElementProperties["SearchElementIndex"] = 1;
                    browserGetElementPropertiespropCount++;
                }

                if (__workflow_browserGetElementPropertiessearchElementMatchValue != null)
                {
                    browserGetElementProperties["SearchElementMatchValue"] = ExpressionConverter.ConvertO(__workflow_browserGetElementPropertiessearchElementMatchValue);
                    browserGetElementPropertiespropCount++;
                }

                if (__workflow_browserGetElementPropertiessearchElementMatchText != null)
                {
                    browserGetElementProperties["SearchElementMatchText"] = ExpressionConverter.ConvertO(__workflow_browserGetElementPropertiessearchElementMatchText);
                    browserGetElementPropertiespropCount++;
                }

                if (__workflow_browserGetElementPropertiessearchElementType != null)
                {
                    browserGetElementProperties["SearchElementType"] = ExpressionConverter.ConvertO(__workflow_browserGetElementPropertiessearchElementType);
                    browserGetElementPropertiespropCount++;
                }

                if (__workflow_browserGetElementPropertiessearchElementMinimumWidth != null)
                {
                    if (__workflow_browserGetElementPropertiessearchElementMinimumWidth != null)
                    {
                        browserGetElementProperties["SearchElementMinimumWidth"] = ExpressionConverter.ConvertO(__workflow_browserGetElementPropertiessearchElementMinimumWidth);
                        browserGetElementPropertiespropCount++;
                    }

                    browserGetElementPropertiespropCount++;
                }
                else
                {
                    browserGetElementProperties["SearchElementMinimumWidth"] = 1;
                    browserGetElementPropertiespropCount++;
                }

                if (__workflow_browserGetElementPropertiessearchElementMinimumHeight != null)
                {
                    if (__workflow_browserGetElementPropertiessearchElementMinimumHeight != null)
                    {
                        browserGetElementProperties["SearchElementMinimumHeight"] = ExpressionConverter.ConvertO(__workflow_browserGetElementPropertiessearchElementMinimumHeight);
                        browserGetElementPropertiespropCount++;
                    }

                    browserGetElementPropertiespropCount++;
                }
                else
                {
                    browserGetElementProperties["SearchElementMinimumHeight"] = 1;
                    browserGetElementPropertiespropCount++;
                }

                if (__workflow_browserGetElementPropertiessearchElementBoundingBoxLeft != null)
                {
                    if (__workflow_browserGetElementPropertiessearchElementBoundingBoxLeft != null)
                    {
                        browserGetElementProperties["SearchElementBoundingBoxLeft"] = ExpressionConverter.ConvertO(__workflow_browserGetElementPropertiessearchElementBoundingBoxLeft);
                        browserGetElementPropertiespropCount++;
                    }

                    browserGetElementPropertiespropCount++;
                }
                else
                {
                    browserGetElementProperties["SearchElementBoundingBoxLeft"] = -99999;
                    browserGetElementPropertiespropCount++;
                }

                if (__workflow_browserGetElementPropertiessearchElementBoundingBoxRight != null)
                {
                    if (__workflow_browserGetElementPropertiessearchElementBoundingBoxRight != null)
                    {
                        browserGetElementProperties["SearchElementBoundingBoxRight"] = ExpressionConverter.ConvertO(__workflow_browserGetElementPropertiessearchElementBoundingBoxRight);
                        browserGetElementPropertiespropCount++;
                    }

                    browserGetElementPropertiespropCount++;
                }
                else
                {
                    browserGetElementProperties["SearchElementBoundingBoxRight"] = 99999;
                    browserGetElementPropertiespropCount++;
                }

                if (__workflow_browserGetElementPropertiessearchElementBoundingBoxTop != null)
                {
                    if (__workflow_browserGetElementPropertiessearchElementBoundingBoxTop != null)
                    {
                        browserGetElementProperties["SearchElementBoundingBoxTop"] = ExpressionConverter.ConvertO(__workflow_browserGetElementPropertiessearchElementBoundingBoxTop);
                        browserGetElementPropertiespropCount++;
                    }

                    browserGetElementPropertiespropCount++;
                }
                else
                {
                    browserGetElementProperties["SearchElementBoundingBoxTop"] = -99999;
                    browserGetElementPropertiespropCount++;
                }

                if (__workflow_browserGetElementPropertiessearchElementBoundingBoxBottom != null)
                {
                    if (__workflow_browserGetElementPropertiessearchElementBoundingBoxBottom != null)
                    {
                        browserGetElementProperties["SearchElementBoundingBoxBottom"] = ExpressionConverter.ConvertO(__workflow_browserGetElementPropertiessearchElementBoundingBoxBottom);
                        browserGetElementPropertiespropCount++;
                    }

                    browserGetElementPropertiespropCount++;
                }
                else
                {
                    browserGetElementProperties["SearchElementBoundingBoxBottom"] = 99999;
                    browserGetElementPropertiespropCount++;
                }

                if (__workflow_browserGetElementPropertiesonlyElementTopLeftNeedsToBeInBoundingBox != null)
                {
                    if (__workflow_browserGetElementPropertiesonlyElementTopLeftNeedsToBeInBoundingBox != null)
                    {
                        browserGetElementProperties["OnlyElementTopLeftNeedsToBeInBoundingBox"] = ExpressionConverter.ConvertO(__workflow_browserGetElementPropertiesonlyElementTopLeftNeedsToBeInBoundingBox);
                        browserGetElementPropertiespropCount++;
                    }

                    browserGetElementPropertiespropCount++;
                }
                else
                {
                    browserGetElementProperties["OnlyElementTopLeftNeedsToBeInBoundingBox"] = false;
                    browserGetElementPropertiespropCount++;
                }

                if (__workflow_browserGetElementPropertiesgetHTMLCode != null)
                {
                    if (__workflow_browserGetElementPropertiesgetHTMLCode != null)
                    {
                        browserGetElementProperties["GetHTMLCode"] = ExpressionConverter.ConvertO(__workflow_browserGetElementPropertiesgetHTMLCode);
                        browserGetElementPropertiespropCount++;
                    }

                    browserGetElementPropertiespropCount++;
                }
                else
                {
                    browserGetElementProperties["GetHTMLCode"] = false;
                    browserGetElementPropertiespropCount++;
                }

                if (__workflow_browserGetElementPropertiesreturnElementHandle != null)
                {
                    if (__workflow_browserGetElementPropertiesreturnElementHandle != null)
                    {
                        browserGetElementProperties["ReturnElementHandle"] = ExpressionConverter.ConvertO(__workflow_browserGetElementPropertiesreturnElementHandle);
                        browserGetElementPropertiespropCount++;
                    }

                    browserGetElementPropertiespropCount++;
                }
                else
                {
                    browserGetElementProperties["ReturnElementHandle"] = true;
                    browserGetElementPropertiespropCount++;
                }

                browserGetElementPropertiespropCount++;
                browserGetElementProperties["Workflow"] = ExpressionConverter.ConvertO(__workflow_browserGetElementPropertiesworkflow);
                if (browserGetElementPropertiespropCount > 0)
                {
                    callPayload.Body = browserGetElementProperties;
                }

                return new ApiConnectionAction<BrowserGetElementPropertiesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserGetMultipleElementPropertiesResponse> BrowserGetMultipleElementProperties(Expression<Func<string>> browserGetMultipleElementPropertiesworkflow, Expression<Func<double>> browserGetMultipleElementPropertiesparentElementHandle = null, Expression<Func<string>> browserGetMultipleElementPropertiessearchElementName = null, Expression<Func<string>> browserGetMultipleElementPropertiessearchElementID = null, Expression<Func<string>> browserGetMultipleElementPropertiessearchElementTagName = null, Expression<Func<string>> browserGetMultipleElementPropertiessearchElementXPath = null, Expression<Func<string>> browserGetMultipleElementPropertiessearchElementClassName = null, Expression<Func<string>> browserGetMultipleElementPropertiessearchElementCSSSelector = null, Expression<Func<string>> browserGetMultipleElementPropertiessearchElementMatchValue = null, Expression<Func<string>> browserGetMultipleElementPropertiessearchElementMatchText = null, Expression<Func<string>> browserGetMultipleElementPropertiessearchElementType = null, Expression<Func<double>> browserGetMultipleElementPropertiessearchElementMinimumWidth = null, Expression<Func<double>> browserGetMultipleElementPropertiessearchElementMinimumHeight = null, Expression<Func<double>> browserGetMultipleElementPropertiessearchElementBoundingBoxLeft = null, Expression<Func<double>> browserGetMultipleElementPropertiessearchElementBoundingBoxRight = null, Expression<Func<double>> browserGetMultipleElementPropertiessearchElementBoundingBoxTop = null, Expression<Func<double>> browserGetMultipleElementPropertiessearchElementBoundingBoxBottom = null, Expression<Func<bool>> browserGetMultipleElementPropertiesonlyElementTopLeftNeedsToBeInBoundingBox = null, Expression<Func<bool>> browserGetMultipleElementPropertiesgetHTMLCode = null, Expression<Func<bool>> browserGetMultipleElementPropertiescreateHandle = null, Expression<Func<bool>> browserGetMultipleElementPropertiesreturnValue = null, Expression<Func<bool>> browserGetMultipleElementPropertiesreturnText = null, Expression<Func<int>> browserGetMultipleElementPropertiesmaxValueLength = null, Expression<Func<int>> browserGetMultipleElementPropertiesmaxTextLength = null, Expression<Func<bool>> browserGetMultipleElementPropertiesreturnIsDisplayed = null, Expression<Func<bool>> browserGetMultipleElementPropertiesreturnCoordinates = null, Expression<Func<bool>> browserGetMultipleElementPropertiesreturnDimensions = null, Expression<Func<bool>> browserGetMultipleElementPropertiesreturnChildElementCount = null, Expression<Func<bool>> browserGetMultipleElementPropertiesreturnParentTag = null, Expression<Func<int>> browserGetMultipleElementPropertiesfirstItemToReturn = null, Expression<Func<int>> browserGetMultipleElementPropertiesmaxItemsToReturn = null)
        {
            var __workflow_browserGetMultipleElementPropertiesworkflow = WorkflowExpression.Compile(browserGetMultipleElementPropertiesworkflow, nameof(browserGetMultipleElementPropertiesworkflow), required: true);
            var __workflow_browserGetMultipleElementPropertiesparentElementHandle = WorkflowExpression.Compile(browserGetMultipleElementPropertiesparentElementHandle, nameof(browserGetMultipleElementPropertiesparentElementHandle), required: false);
            var __workflow_browserGetMultipleElementPropertiessearchElementName = WorkflowExpression.Compile(browserGetMultipleElementPropertiessearchElementName, nameof(browserGetMultipleElementPropertiessearchElementName), required: false);
            var __workflow_browserGetMultipleElementPropertiessearchElementID = WorkflowExpression.Compile(browserGetMultipleElementPropertiessearchElementID, nameof(browserGetMultipleElementPropertiessearchElementID), required: false);
            var __workflow_browserGetMultipleElementPropertiessearchElementTagName = WorkflowExpression.Compile(browserGetMultipleElementPropertiessearchElementTagName, nameof(browserGetMultipleElementPropertiessearchElementTagName), required: false);
            var __workflow_browserGetMultipleElementPropertiessearchElementXPath = WorkflowExpression.Compile(browserGetMultipleElementPropertiessearchElementXPath, nameof(browserGetMultipleElementPropertiessearchElementXPath), required: false);
            var __workflow_browserGetMultipleElementPropertiessearchElementClassName = WorkflowExpression.Compile(browserGetMultipleElementPropertiessearchElementClassName, nameof(browserGetMultipleElementPropertiessearchElementClassName), required: false);
            var __workflow_browserGetMultipleElementPropertiessearchElementCSSSelector = WorkflowExpression.Compile(browserGetMultipleElementPropertiessearchElementCSSSelector, nameof(browserGetMultipleElementPropertiessearchElementCSSSelector), required: false);
            var __workflow_browserGetMultipleElementPropertiessearchElementMatchValue = WorkflowExpression.Compile(browserGetMultipleElementPropertiessearchElementMatchValue, nameof(browserGetMultipleElementPropertiessearchElementMatchValue), required: false);
            var __workflow_browserGetMultipleElementPropertiessearchElementMatchText = WorkflowExpression.Compile(browserGetMultipleElementPropertiessearchElementMatchText, nameof(browserGetMultipleElementPropertiessearchElementMatchText), required: false);
            var __workflow_browserGetMultipleElementPropertiessearchElementType = WorkflowExpression.Compile(browserGetMultipleElementPropertiessearchElementType, nameof(browserGetMultipleElementPropertiessearchElementType), required: false);
            var __workflow_browserGetMultipleElementPropertiessearchElementMinimumWidth = WorkflowExpression.Compile(browserGetMultipleElementPropertiessearchElementMinimumWidth, nameof(browserGetMultipleElementPropertiessearchElementMinimumWidth), required: false);
            var __workflow_browserGetMultipleElementPropertiessearchElementMinimumHeight = WorkflowExpression.Compile(browserGetMultipleElementPropertiessearchElementMinimumHeight, nameof(browserGetMultipleElementPropertiessearchElementMinimumHeight), required: false);
            var __workflow_browserGetMultipleElementPropertiessearchElementBoundingBoxLeft = WorkflowExpression.Compile(browserGetMultipleElementPropertiessearchElementBoundingBoxLeft, nameof(browserGetMultipleElementPropertiessearchElementBoundingBoxLeft), required: false);
            var __workflow_browserGetMultipleElementPropertiessearchElementBoundingBoxRight = WorkflowExpression.Compile(browserGetMultipleElementPropertiessearchElementBoundingBoxRight, nameof(browserGetMultipleElementPropertiessearchElementBoundingBoxRight), required: false);
            var __workflow_browserGetMultipleElementPropertiessearchElementBoundingBoxTop = WorkflowExpression.Compile(browserGetMultipleElementPropertiessearchElementBoundingBoxTop, nameof(browserGetMultipleElementPropertiessearchElementBoundingBoxTop), required: false);
            var __workflow_browserGetMultipleElementPropertiessearchElementBoundingBoxBottom = WorkflowExpression.Compile(browserGetMultipleElementPropertiessearchElementBoundingBoxBottom, nameof(browserGetMultipleElementPropertiessearchElementBoundingBoxBottom), required: false);
            var __workflow_browserGetMultipleElementPropertiesonlyElementTopLeftNeedsToBeInBoundingBox = WorkflowExpression.Compile(browserGetMultipleElementPropertiesonlyElementTopLeftNeedsToBeInBoundingBox, nameof(browserGetMultipleElementPropertiesonlyElementTopLeftNeedsToBeInBoundingBox), required: false);
            var __workflow_browserGetMultipleElementPropertiesgetHTMLCode = WorkflowExpression.Compile(browserGetMultipleElementPropertiesgetHTMLCode, nameof(browserGetMultipleElementPropertiesgetHTMLCode), required: false);
            var __workflow_browserGetMultipleElementPropertiescreateHandle = WorkflowExpression.Compile(browserGetMultipleElementPropertiescreateHandle, nameof(browserGetMultipleElementPropertiescreateHandle), required: false);
            var __workflow_browserGetMultipleElementPropertiesreturnValue = WorkflowExpression.Compile(browserGetMultipleElementPropertiesreturnValue, nameof(browserGetMultipleElementPropertiesreturnValue), required: false);
            var __workflow_browserGetMultipleElementPropertiesreturnText = WorkflowExpression.Compile(browserGetMultipleElementPropertiesreturnText, nameof(browserGetMultipleElementPropertiesreturnText), required: false);
            var __workflow_browserGetMultipleElementPropertiesmaxValueLength = WorkflowExpression.Compile(browserGetMultipleElementPropertiesmaxValueLength, nameof(browserGetMultipleElementPropertiesmaxValueLength), required: false);
            var __workflow_browserGetMultipleElementPropertiesmaxTextLength = WorkflowExpression.Compile(browserGetMultipleElementPropertiesmaxTextLength, nameof(browserGetMultipleElementPropertiesmaxTextLength), required: false);
            var __workflow_browserGetMultipleElementPropertiesreturnIsDisplayed = WorkflowExpression.Compile(browserGetMultipleElementPropertiesreturnIsDisplayed, nameof(browserGetMultipleElementPropertiesreturnIsDisplayed), required: false);
            var __workflow_browserGetMultipleElementPropertiesreturnCoordinates = WorkflowExpression.Compile(browserGetMultipleElementPropertiesreturnCoordinates, nameof(browserGetMultipleElementPropertiesreturnCoordinates), required: false);
            var __workflow_browserGetMultipleElementPropertiesreturnDimensions = WorkflowExpression.Compile(browserGetMultipleElementPropertiesreturnDimensions, nameof(browserGetMultipleElementPropertiesreturnDimensions), required: false);
            var __workflow_browserGetMultipleElementPropertiesreturnChildElementCount = WorkflowExpression.Compile(browserGetMultipleElementPropertiesreturnChildElementCount, nameof(browserGetMultipleElementPropertiesreturnChildElementCount), required: false);
            var __workflow_browserGetMultipleElementPropertiesreturnParentTag = WorkflowExpression.Compile(browserGetMultipleElementPropertiesreturnParentTag, nameof(browserGetMultipleElementPropertiesreturnParentTag), required: false);
            var __workflow_browserGetMultipleElementPropertiesfirstItemToReturn = WorkflowExpression.Compile(browserGetMultipleElementPropertiesfirstItemToReturn, nameof(browserGetMultipleElementPropertiesfirstItemToReturn), required: false);
            var __workflow_browserGetMultipleElementPropertiesmaxItemsToReturn = WorkflowExpression.Compile(browserGetMultipleElementPropertiesmaxItemsToReturn, nameof(browserGetMultipleElementPropertiesmaxItemsToReturn), required: false);
            return new DeferredBodyAction<BrowserGetMultipleElementPropertiesResponse>(() =>
            {
                var apiCallPath = "/BrowserControl/GetMultipleElementProperties";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserGetMultipleElementProperties = new JObject();
                var browserGetMultipleElementPropertiespropCount = 0;
                if (__workflow_browserGetMultipleElementPropertiesparentElementHandle != null)
                {
                    browserGetMultipleElementProperties["ParentElementHandle"] = ExpressionConverter.ConvertO(__workflow_browserGetMultipleElementPropertiesparentElementHandle);
                    browserGetMultipleElementPropertiespropCount++;
                }

                if (__workflow_browserGetMultipleElementPropertiessearchElementName != null)
                {
                    browserGetMultipleElementProperties["SearchElementName"] = ExpressionConverter.ConvertO(__workflow_browserGetMultipleElementPropertiessearchElementName);
                    browserGetMultipleElementPropertiespropCount++;
                }

                if (__workflow_browserGetMultipleElementPropertiessearchElementID != null)
                {
                    browserGetMultipleElementProperties["SearchElementID"] = ExpressionConverter.ConvertO(__workflow_browserGetMultipleElementPropertiessearchElementID);
                    browserGetMultipleElementPropertiespropCount++;
                }

                if (__workflow_browserGetMultipleElementPropertiessearchElementTagName != null)
                {
                    browserGetMultipleElementProperties["SearchElementTagName"] = ExpressionConverter.ConvertO(__workflow_browserGetMultipleElementPropertiessearchElementTagName);
                    browserGetMultipleElementPropertiespropCount++;
                }

                if (__workflow_browserGetMultipleElementPropertiessearchElementXPath != null)
                {
                    browserGetMultipleElementProperties["SearchElementXPath"] = ExpressionConverter.ConvertO(__workflow_browserGetMultipleElementPropertiessearchElementXPath);
                    browserGetMultipleElementPropertiespropCount++;
                }

                if (__workflow_browserGetMultipleElementPropertiessearchElementClassName != null)
                {
                    browserGetMultipleElementProperties["SearchElementClassName"] = ExpressionConverter.ConvertO(__workflow_browserGetMultipleElementPropertiessearchElementClassName);
                    browserGetMultipleElementPropertiespropCount++;
                }

                if (__workflow_browserGetMultipleElementPropertiessearchElementCSSSelector != null)
                {
                    browserGetMultipleElementProperties["SearchElementCSSSelector"] = ExpressionConverter.ConvertO(__workflow_browserGetMultipleElementPropertiessearchElementCSSSelector);
                    browserGetMultipleElementPropertiespropCount++;
                }

                if (__workflow_browserGetMultipleElementPropertiessearchElementMatchValue != null)
                {
                    browserGetMultipleElementProperties["SearchElementMatchValue"] = ExpressionConverter.ConvertO(__workflow_browserGetMultipleElementPropertiessearchElementMatchValue);
                    browserGetMultipleElementPropertiespropCount++;
                }

                if (__workflow_browserGetMultipleElementPropertiessearchElementMatchText != null)
                {
                    browserGetMultipleElementProperties["SearchElementMatchText"] = ExpressionConverter.ConvertO(__workflow_browserGetMultipleElementPropertiessearchElementMatchText);
                    browserGetMultipleElementPropertiespropCount++;
                }

                if (__workflow_browserGetMultipleElementPropertiessearchElementType != null)
                {
                    browserGetMultipleElementProperties["SearchElementType"] = ExpressionConverter.ConvertO(__workflow_browserGetMultipleElementPropertiessearchElementType);
                    browserGetMultipleElementPropertiespropCount++;
                }

                if (__workflow_browserGetMultipleElementPropertiessearchElementMinimumWidth != null)
                {
                    if (__workflow_browserGetMultipleElementPropertiessearchElementMinimumWidth != null)
                    {
                        browserGetMultipleElementProperties["SearchElementMinimumWidth"] = ExpressionConverter.ConvertO(__workflow_browserGetMultipleElementPropertiessearchElementMinimumWidth);
                        browserGetMultipleElementPropertiespropCount++;
                    }

                    browserGetMultipleElementPropertiespropCount++;
                }
                else
                {
                    browserGetMultipleElementProperties["SearchElementMinimumWidth"] = 1;
                    browserGetMultipleElementPropertiespropCount++;
                }

                if (__workflow_browserGetMultipleElementPropertiessearchElementMinimumHeight != null)
                {
                    if (__workflow_browserGetMultipleElementPropertiessearchElementMinimumHeight != null)
                    {
                        browserGetMultipleElementProperties["SearchElementMinimumHeight"] = ExpressionConverter.ConvertO(__workflow_browserGetMultipleElementPropertiessearchElementMinimumHeight);
                        browserGetMultipleElementPropertiespropCount++;
                    }

                    browserGetMultipleElementPropertiespropCount++;
                }
                else
                {
                    browserGetMultipleElementProperties["SearchElementMinimumHeight"] = 1;
                    browserGetMultipleElementPropertiespropCount++;
                }

                if (__workflow_browserGetMultipleElementPropertiessearchElementBoundingBoxLeft != null)
                {
                    if (__workflow_browserGetMultipleElementPropertiessearchElementBoundingBoxLeft != null)
                    {
                        browserGetMultipleElementProperties["SearchElementBoundingBoxLeft"] = ExpressionConverter.ConvertO(__workflow_browserGetMultipleElementPropertiessearchElementBoundingBoxLeft);
                        browserGetMultipleElementPropertiespropCount++;
                    }

                    browserGetMultipleElementPropertiespropCount++;
                }
                else
                {
                    browserGetMultipleElementProperties["SearchElementBoundingBoxLeft"] = -99999;
                    browserGetMultipleElementPropertiespropCount++;
                }

                if (__workflow_browserGetMultipleElementPropertiessearchElementBoundingBoxRight != null)
                {
                    if (__workflow_browserGetMultipleElementPropertiessearchElementBoundingBoxRight != null)
                    {
                        browserGetMultipleElementProperties["SearchElementBoundingBoxRight"] = ExpressionConverter.ConvertO(__workflow_browserGetMultipleElementPropertiessearchElementBoundingBoxRight);
                        browserGetMultipleElementPropertiespropCount++;
                    }

                    browserGetMultipleElementPropertiespropCount++;
                }
                else
                {
                    browserGetMultipleElementProperties["SearchElementBoundingBoxRight"] = 99999;
                    browserGetMultipleElementPropertiespropCount++;
                }

                if (__workflow_browserGetMultipleElementPropertiessearchElementBoundingBoxTop != null)
                {
                    if (__workflow_browserGetMultipleElementPropertiessearchElementBoundingBoxTop != null)
                    {
                        browserGetMultipleElementProperties["SearchElementBoundingBoxTop"] = ExpressionConverter.ConvertO(__workflow_browserGetMultipleElementPropertiessearchElementBoundingBoxTop);
                        browserGetMultipleElementPropertiespropCount++;
                    }

                    browserGetMultipleElementPropertiespropCount++;
                }
                else
                {
                    browserGetMultipleElementProperties["SearchElementBoundingBoxTop"] = -99999;
                    browserGetMultipleElementPropertiespropCount++;
                }

                if (__workflow_browserGetMultipleElementPropertiessearchElementBoundingBoxBottom != null)
                {
                    if (__workflow_browserGetMultipleElementPropertiessearchElementBoundingBoxBottom != null)
                    {
                        browserGetMultipleElementProperties["SearchElementBoundingBoxBottom"] = ExpressionConverter.ConvertO(__workflow_browserGetMultipleElementPropertiessearchElementBoundingBoxBottom);
                        browserGetMultipleElementPropertiespropCount++;
                    }

                    browserGetMultipleElementPropertiespropCount++;
                }
                else
                {
                    browserGetMultipleElementProperties["SearchElementBoundingBoxBottom"] = 99999;
                    browserGetMultipleElementPropertiespropCount++;
                }

                if (__workflow_browserGetMultipleElementPropertiesonlyElementTopLeftNeedsToBeInBoundingBox != null)
                {
                    if (__workflow_browserGetMultipleElementPropertiesonlyElementTopLeftNeedsToBeInBoundingBox != null)
                    {
                        browserGetMultipleElementProperties["OnlyElementTopLeftNeedsToBeInBoundingBox"] = ExpressionConverter.ConvertO(__workflow_browserGetMultipleElementPropertiesonlyElementTopLeftNeedsToBeInBoundingBox);
                        browserGetMultipleElementPropertiespropCount++;
                    }

                    browserGetMultipleElementPropertiespropCount++;
                }
                else
                {
                    browserGetMultipleElementProperties["OnlyElementTopLeftNeedsToBeInBoundingBox"] = false;
                    browserGetMultipleElementPropertiespropCount++;
                }

                if (__workflow_browserGetMultipleElementPropertiesgetHTMLCode != null)
                {
                    if (__workflow_browserGetMultipleElementPropertiesgetHTMLCode != null)
                    {
                        browserGetMultipleElementProperties["GetHTMLCode"] = ExpressionConverter.ConvertO(__workflow_browserGetMultipleElementPropertiesgetHTMLCode);
                        browserGetMultipleElementPropertiespropCount++;
                    }

                    browserGetMultipleElementPropertiespropCount++;
                }
                else
                {
                    browserGetMultipleElementProperties["GetHTMLCode"] = false;
                    browserGetMultipleElementPropertiespropCount++;
                }

                if (__workflow_browserGetMultipleElementPropertiescreateHandle != null)
                {
                    if (__workflow_browserGetMultipleElementPropertiescreateHandle != null)
                    {
                        browserGetMultipleElementProperties["CreateHandle"] = ExpressionConverter.ConvertO(__workflow_browserGetMultipleElementPropertiescreateHandle);
                        browserGetMultipleElementPropertiespropCount++;
                    }

                    browserGetMultipleElementPropertiespropCount++;
                }
                else
                {
                    browserGetMultipleElementProperties["CreateHandle"] = true;
                    browserGetMultipleElementPropertiespropCount++;
                }

                if (__workflow_browserGetMultipleElementPropertiesreturnValue != null)
                {
                    if (__workflow_browserGetMultipleElementPropertiesreturnValue != null)
                    {
                        browserGetMultipleElementProperties["ReturnValue"] = ExpressionConverter.ConvertO(__workflow_browserGetMultipleElementPropertiesreturnValue);
                        browserGetMultipleElementPropertiespropCount++;
                    }

                    browserGetMultipleElementPropertiespropCount++;
                }
                else
                {
                    browserGetMultipleElementProperties["ReturnValue"] = true;
                    browserGetMultipleElementPropertiespropCount++;
                }

                if (__workflow_browserGetMultipleElementPropertiesreturnText != null)
                {
                    if (__workflow_browserGetMultipleElementPropertiesreturnText != null)
                    {
                        browserGetMultipleElementProperties["ReturnText"] = ExpressionConverter.ConvertO(__workflow_browserGetMultipleElementPropertiesreturnText);
                        browserGetMultipleElementPropertiespropCount++;
                    }

                    browserGetMultipleElementPropertiespropCount++;
                }
                else
                {
                    browserGetMultipleElementProperties["ReturnText"] = true;
                    browserGetMultipleElementPropertiespropCount++;
                }

                if (__workflow_browserGetMultipleElementPropertiesmaxValueLength != null)
                {
                    if (__workflow_browserGetMultipleElementPropertiesmaxValueLength != null)
                    {
                        browserGetMultipleElementProperties["MaxValueLength"] = ExpressionConverter.ConvertO(__workflow_browserGetMultipleElementPropertiesmaxValueLength);
                        browserGetMultipleElementPropertiespropCount++;
                    }

                    browserGetMultipleElementPropertiespropCount++;
                }
                else
                {
                    browserGetMultipleElementProperties["MaxValueLength"] = 0;
                    browserGetMultipleElementPropertiespropCount++;
                }

                if (__workflow_browserGetMultipleElementPropertiesmaxTextLength != null)
                {
                    if (__workflow_browserGetMultipleElementPropertiesmaxTextLength != null)
                    {
                        browserGetMultipleElementProperties["MaxTextLength"] = ExpressionConverter.ConvertO(__workflow_browserGetMultipleElementPropertiesmaxTextLength);
                        browserGetMultipleElementPropertiespropCount++;
                    }

                    browserGetMultipleElementPropertiespropCount++;
                }
                else
                {
                    browserGetMultipleElementProperties["MaxTextLength"] = 0;
                    browserGetMultipleElementPropertiespropCount++;
                }

                if (__workflow_browserGetMultipleElementPropertiesreturnIsDisplayed != null)
                {
                    if (__workflow_browserGetMultipleElementPropertiesreturnIsDisplayed != null)
                    {
                        browserGetMultipleElementProperties["ReturnIsDisplayed"] = ExpressionConverter.ConvertO(__workflow_browserGetMultipleElementPropertiesreturnIsDisplayed);
                        browserGetMultipleElementPropertiespropCount++;
                    }

                    browserGetMultipleElementPropertiespropCount++;
                }
                else
                {
                    browserGetMultipleElementProperties["ReturnIsDisplayed"] = true;
                    browserGetMultipleElementPropertiespropCount++;
                }

                if (__workflow_browserGetMultipleElementPropertiesreturnCoordinates != null)
                {
                    if (__workflow_browserGetMultipleElementPropertiesreturnCoordinates != null)
                    {
                        browserGetMultipleElementProperties["ReturnCoordinates"] = ExpressionConverter.ConvertO(__workflow_browserGetMultipleElementPropertiesreturnCoordinates);
                        browserGetMultipleElementPropertiespropCount++;
                    }

                    browserGetMultipleElementPropertiespropCount++;
                }
                else
                {
                    browserGetMultipleElementProperties["ReturnCoordinates"] = true;
                    browserGetMultipleElementPropertiespropCount++;
                }

                if (__workflow_browserGetMultipleElementPropertiesreturnDimensions != null)
                {
                    if (__workflow_browserGetMultipleElementPropertiesreturnDimensions != null)
                    {
                        browserGetMultipleElementProperties["ReturnDimensions"] = ExpressionConverter.ConvertO(__workflow_browserGetMultipleElementPropertiesreturnDimensions);
                        browserGetMultipleElementPropertiespropCount++;
                    }

                    browserGetMultipleElementPropertiespropCount++;
                }
                else
                {
                    browserGetMultipleElementProperties["ReturnDimensions"] = true;
                    browserGetMultipleElementPropertiespropCount++;
                }

                if (__workflow_browserGetMultipleElementPropertiesreturnChildElementCount != null)
                {
                    if (__workflow_browserGetMultipleElementPropertiesreturnChildElementCount != null)
                    {
                        browserGetMultipleElementProperties["ReturnChildElementCount"] = ExpressionConverter.ConvertO(__workflow_browserGetMultipleElementPropertiesreturnChildElementCount);
                        browserGetMultipleElementPropertiespropCount++;
                    }

                    browserGetMultipleElementPropertiespropCount++;
                }
                else
                {
                    browserGetMultipleElementProperties["ReturnChildElementCount"] = true;
                    browserGetMultipleElementPropertiespropCount++;
                }

                if (__workflow_browserGetMultipleElementPropertiesreturnParentTag != null)
                {
                    if (__workflow_browserGetMultipleElementPropertiesreturnParentTag != null)
                    {
                        browserGetMultipleElementProperties["ReturnParentTag"] = ExpressionConverter.ConvertO(__workflow_browserGetMultipleElementPropertiesreturnParentTag);
                        browserGetMultipleElementPropertiespropCount++;
                    }

                    browserGetMultipleElementPropertiespropCount++;
                }
                else
                {
                    browserGetMultipleElementProperties["ReturnParentTag"] = true;
                    browserGetMultipleElementPropertiespropCount++;
                }

                if (__workflow_browserGetMultipleElementPropertiesfirstItemToReturn != null)
                {
                    if (__workflow_browserGetMultipleElementPropertiesfirstItemToReturn != null)
                    {
                        browserGetMultipleElementProperties["FirstItemToReturn"] = ExpressionConverter.ConvertO(__workflow_browserGetMultipleElementPropertiesfirstItemToReturn);
                        browserGetMultipleElementPropertiespropCount++;
                    }

                    browserGetMultipleElementPropertiespropCount++;
                }
                else
                {
                    browserGetMultipleElementProperties["FirstItemToReturn"] = 1;
                    browserGetMultipleElementPropertiespropCount++;
                }

                if (__workflow_browserGetMultipleElementPropertiesmaxItemsToReturn != null)
                {
                    if (__workflow_browserGetMultipleElementPropertiesmaxItemsToReturn != null)
                    {
                        browserGetMultipleElementProperties["MaxItemsToReturn"] = ExpressionConverter.ConvertO(__workflow_browserGetMultipleElementPropertiesmaxItemsToReturn);
                        browserGetMultipleElementPropertiespropCount++;
                    }

                    browserGetMultipleElementPropertiespropCount++;
                }
                else
                {
                    browserGetMultipleElementProperties["MaxItemsToReturn"] = 0;
                    browserGetMultipleElementPropertiespropCount++;
                }

                browserGetMultipleElementPropertiespropCount++;
                browserGetMultipleElementProperties["Workflow"] = ExpressionConverter.ConvertO(__workflow_browserGetMultipleElementPropertiesworkflow);
                if (browserGetMultipleElementPropertiespropCount > 0)
                {
                    callPayload.Body = browserGetMultipleElementProperties;
                }

                return new ApiConnectionAction<BrowserGetMultipleElementPropertiesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserGetElementParentPropertiesResponse> BrowserGetElementParentProperties(Expression<Func<string>> browserGetElementParentPropertiesworkflow, Expression<Func<double>> browserGetElementParentPropertiesparentElementHandle = null, Expression<Func<double>> browserGetElementParentPropertiessearchElementHandle = null, Expression<Func<string>> browserGetElementParentPropertiessearchElementName = null, Expression<Func<string>> browserGetElementParentPropertiessearchElementID = null, Expression<Func<string>> browserGetElementParentPropertiessearchElementTagName = null, Expression<Func<string>> browserGetElementParentPropertiessearchElementXPath = null, Expression<Func<string>> browserGetElementParentPropertiessearchElementClassName = null, Expression<Func<string>> browserGetElementParentPropertiessearchElementCSSSelector = null, Expression<Func<double>> browserGetElementParentPropertiessearchElementIndex = null, Expression<Func<string>> browserGetElementParentPropertiessearchElementMatchValue = null, Expression<Func<string>> browserGetElementParentPropertiessearchElementMatchText = null, Expression<Func<string>> browserGetElementParentPropertiessearchElementType = null, Expression<Func<double>> browserGetElementParentPropertiessearchElementMinimumWidth = null, Expression<Func<double>> browserGetElementParentPropertiessearchElementMinimumHeight = null, Expression<Func<double>> browserGetElementParentPropertiessearchElementBoundingBoxLeft = null, Expression<Func<double>> browserGetElementParentPropertiessearchElementBoundingBoxRight = null, Expression<Func<double>> browserGetElementParentPropertiessearchElementBoundingBoxTop = null, Expression<Func<double>> browserGetElementParentPropertiessearchElementBoundingBoxBottom = null, Expression<Func<bool>> browserGetElementParentPropertiesonlyElementTopLeftNeedsToBeInBoundingBox = null, Expression<Func<bool>> browserGetElementParentPropertiesgetHTMLCode = null, Expression<Func<bool>> browserGetElementParentPropertiescreateHandle = null)
        {
            var __workflow_browserGetElementParentPropertiesworkflow = WorkflowExpression.Compile(browserGetElementParentPropertiesworkflow, nameof(browserGetElementParentPropertiesworkflow), required: true);
            var __workflow_browserGetElementParentPropertiesparentElementHandle = WorkflowExpression.Compile(browserGetElementParentPropertiesparentElementHandle, nameof(browserGetElementParentPropertiesparentElementHandle), required: false);
            var __workflow_browserGetElementParentPropertiessearchElementHandle = WorkflowExpression.Compile(browserGetElementParentPropertiessearchElementHandle, nameof(browserGetElementParentPropertiessearchElementHandle), required: false);
            var __workflow_browserGetElementParentPropertiessearchElementName = WorkflowExpression.Compile(browserGetElementParentPropertiessearchElementName, nameof(browserGetElementParentPropertiessearchElementName), required: false);
            var __workflow_browserGetElementParentPropertiessearchElementID = WorkflowExpression.Compile(browserGetElementParentPropertiessearchElementID, nameof(browserGetElementParentPropertiessearchElementID), required: false);
            var __workflow_browserGetElementParentPropertiessearchElementTagName = WorkflowExpression.Compile(browserGetElementParentPropertiessearchElementTagName, nameof(browserGetElementParentPropertiessearchElementTagName), required: false);
            var __workflow_browserGetElementParentPropertiessearchElementXPath = WorkflowExpression.Compile(browserGetElementParentPropertiessearchElementXPath, nameof(browserGetElementParentPropertiessearchElementXPath), required: false);
            var __workflow_browserGetElementParentPropertiessearchElementClassName = WorkflowExpression.Compile(browserGetElementParentPropertiessearchElementClassName, nameof(browserGetElementParentPropertiessearchElementClassName), required: false);
            var __workflow_browserGetElementParentPropertiessearchElementCSSSelector = WorkflowExpression.Compile(browserGetElementParentPropertiessearchElementCSSSelector, nameof(browserGetElementParentPropertiessearchElementCSSSelector), required: false);
            var __workflow_browserGetElementParentPropertiessearchElementIndex = WorkflowExpression.Compile(browserGetElementParentPropertiessearchElementIndex, nameof(browserGetElementParentPropertiessearchElementIndex), required: false);
            var __workflow_browserGetElementParentPropertiessearchElementMatchValue = WorkflowExpression.Compile(browserGetElementParentPropertiessearchElementMatchValue, nameof(browserGetElementParentPropertiessearchElementMatchValue), required: false);
            var __workflow_browserGetElementParentPropertiessearchElementMatchText = WorkflowExpression.Compile(browserGetElementParentPropertiessearchElementMatchText, nameof(browserGetElementParentPropertiessearchElementMatchText), required: false);
            var __workflow_browserGetElementParentPropertiessearchElementType = WorkflowExpression.Compile(browserGetElementParentPropertiessearchElementType, nameof(browserGetElementParentPropertiessearchElementType), required: false);
            var __workflow_browserGetElementParentPropertiessearchElementMinimumWidth = WorkflowExpression.Compile(browserGetElementParentPropertiessearchElementMinimumWidth, nameof(browserGetElementParentPropertiessearchElementMinimumWidth), required: false);
            var __workflow_browserGetElementParentPropertiessearchElementMinimumHeight = WorkflowExpression.Compile(browserGetElementParentPropertiessearchElementMinimumHeight, nameof(browserGetElementParentPropertiessearchElementMinimumHeight), required: false);
            var __workflow_browserGetElementParentPropertiessearchElementBoundingBoxLeft = WorkflowExpression.Compile(browserGetElementParentPropertiessearchElementBoundingBoxLeft, nameof(browserGetElementParentPropertiessearchElementBoundingBoxLeft), required: false);
            var __workflow_browserGetElementParentPropertiessearchElementBoundingBoxRight = WorkflowExpression.Compile(browserGetElementParentPropertiessearchElementBoundingBoxRight, nameof(browserGetElementParentPropertiessearchElementBoundingBoxRight), required: false);
            var __workflow_browserGetElementParentPropertiessearchElementBoundingBoxTop = WorkflowExpression.Compile(browserGetElementParentPropertiessearchElementBoundingBoxTop, nameof(browserGetElementParentPropertiessearchElementBoundingBoxTop), required: false);
            var __workflow_browserGetElementParentPropertiessearchElementBoundingBoxBottom = WorkflowExpression.Compile(browserGetElementParentPropertiessearchElementBoundingBoxBottom, nameof(browserGetElementParentPropertiessearchElementBoundingBoxBottom), required: false);
            var __workflow_browserGetElementParentPropertiesonlyElementTopLeftNeedsToBeInBoundingBox = WorkflowExpression.Compile(browserGetElementParentPropertiesonlyElementTopLeftNeedsToBeInBoundingBox, nameof(browserGetElementParentPropertiesonlyElementTopLeftNeedsToBeInBoundingBox), required: false);
            var __workflow_browserGetElementParentPropertiesgetHTMLCode = WorkflowExpression.Compile(browserGetElementParentPropertiesgetHTMLCode, nameof(browserGetElementParentPropertiesgetHTMLCode), required: false);
            var __workflow_browserGetElementParentPropertiescreateHandle = WorkflowExpression.Compile(browserGetElementParentPropertiescreateHandle, nameof(browserGetElementParentPropertiescreateHandle), required: false);
            return new DeferredBodyAction<BrowserGetElementParentPropertiesResponse>(() =>
            {
                var apiCallPath = "/BrowserControl/GetElementParentProperties";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserGetElementParentProperties = new JObject();
                var browserGetElementParentPropertiespropCount = 0;
                if (__workflow_browserGetElementParentPropertiesparentElementHandle != null)
                {
                    browserGetElementParentProperties["ParentElementHandle"] = ExpressionConverter.ConvertO(__workflow_browserGetElementParentPropertiesparentElementHandle);
                    browserGetElementParentPropertiespropCount++;
                }

                if (__workflow_browserGetElementParentPropertiessearchElementHandle != null)
                {
                    browserGetElementParentProperties["SearchElementHandle"] = ExpressionConverter.ConvertO(__workflow_browserGetElementParentPropertiessearchElementHandle);
                    browserGetElementParentPropertiespropCount++;
                }

                if (__workflow_browserGetElementParentPropertiessearchElementName != null)
                {
                    browserGetElementParentProperties["SearchElementName"] = ExpressionConverter.ConvertO(__workflow_browserGetElementParentPropertiessearchElementName);
                    browserGetElementParentPropertiespropCount++;
                }

                if (__workflow_browserGetElementParentPropertiessearchElementID != null)
                {
                    browserGetElementParentProperties["SearchElementID"] = ExpressionConverter.ConvertO(__workflow_browserGetElementParentPropertiessearchElementID);
                    browserGetElementParentPropertiespropCount++;
                }

                if (__workflow_browserGetElementParentPropertiessearchElementTagName != null)
                {
                    browserGetElementParentProperties["SearchElementTagName"] = ExpressionConverter.ConvertO(__workflow_browserGetElementParentPropertiessearchElementTagName);
                    browserGetElementParentPropertiespropCount++;
                }

                if (__workflow_browserGetElementParentPropertiessearchElementXPath != null)
                {
                    browserGetElementParentProperties["SearchElementXPath"] = ExpressionConverter.ConvertO(__workflow_browserGetElementParentPropertiessearchElementXPath);
                    browserGetElementParentPropertiespropCount++;
                }

                if (__workflow_browserGetElementParentPropertiessearchElementClassName != null)
                {
                    browserGetElementParentProperties["SearchElementClassName"] = ExpressionConverter.ConvertO(__workflow_browserGetElementParentPropertiessearchElementClassName);
                    browserGetElementParentPropertiespropCount++;
                }

                if (__workflow_browserGetElementParentPropertiessearchElementCSSSelector != null)
                {
                    browserGetElementParentProperties["SearchElementCSSSelector"] = ExpressionConverter.ConvertO(__workflow_browserGetElementParentPropertiessearchElementCSSSelector);
                    browserGetElementParentPropertiespropCount++;
                }

                if (__workflow_browserGetElementParentPropertiessearchElementIndex != null)
                {
                    if (__workflow_browserGetElementParentPropertiessearchElementIndex != null)
                    {
                        browserGetElementParentProperties["SearchElementIndex"] = ExpressionConverter.ConvertO(__workflow_browserGetElementParentPropertiessearchElementIndex);
                        browserGetElementParentPropertiespropCount++;
                    }

                    browserGetElementParentPropertiespropCount++;
                }
                else
                {
                    browserGetElementParentProperties["SearchElementIndex"] = 1;
                    browserGetElementParentPropertiespropCount++;
                }

                if (__workflow_browserGetElementParentPropertiessearchElementMatchValue != null)
                {
                    browserGetElementParentProperties["SearchElementMatchValue"] = ExpressionConverter.ConvertO(__workflow_browserGetElementParentPropertiessearchElementMatchValue);
                    browserGetElementParentPropertiespropCount++;
                }

                if (__workflow_browserGetElementParentPropertiessearchElementMatchText != null)
                {
                    browserGetElementParentProperties["SearchElementMatchText"] = ExpressionConverter.ConvertO(__workflow_browserGetElementParentPropertiessearchElementMatchText);
                    browserGetElementParentPropertiespropCount++;
                }

                if (__workflow_browserGetElementParentPropertiessearchElementType != null)
                {
                    browserGetElementParentProperties["SearchElementType"] = ExpressionConverter.ConvertO(__workflow_browserGetElementParentPropertiessearchElementType);
                    browserGetElementParentPropertiespropCount++;
                }

                if (__workflow_browserGetElementParentPropertiessearchElementMinimumWidth != null)
                {
                    if (__workflow_browserGetElementParentPropertiessearchElementMinimumWidth != null)
                    {
                        browserGetElementParentProperties["SearchElementMinimumWidth"] = ExpressionConverter.ConvertO(__workflow_browserGetElementParentPropertiessearchElementMinimumWidth);
                        browserGetElementParentPropertiespropCount++;
                    }

                    browserGetElementParentPropertiespropCount++;
                }
                else
                {
                    browserGetElementParentProperties["SearchElementMinimumWidth"] = 1;
                    browserGetElementParentPropertiespropCount++;
                }

                if (__workflow_browserGetElementParentPropertiessearchElementMinimumHeight != null)
                {
                    if (__workflow_browserGetElementParentPropertiessearchElementMinimumHeight != null)
                    {
                        browserGetElementParentProperties["SearchElementMinimumHeight"] = ExpressionConverter.ConvertO(__workflow_browserGetElementParentPropertiessearchElementMinimumHeight);
                        browserGetElementParentPropertiespropCount++;
                    }

                    browserGetElementParentPropertiespropCount++;
                }
                else
                {
                    browserGetElementParentProperties["SearchElementMinimumHeight"] = 1;
                    browserGetElementParentPropertiespropCount++;
                }

                if (__workflow_browserGetElementParentPropertiessearchElementBoundingBoxLeft != null)
                {
                    if (__workflow_browserGetElementParentPropertiessearchElementBoundingBoxLeft != null)
                    {
                        browserGetElementParentProperties["SearchElementBoundingBoxLeft"] = ExpressionConverter.ConvertO(__workflow_browserGetElementParentPropertiessearchElementBoundingBoxLeft);
                        browserGetElementParentPropertiespropCount++;
                    }

                    browserGetElementParentPropertiespropCount++;
                }
                else
                {
                    browserGetElementParentProperties["SearchElementBoundingBoxLeft"] = -99999;
                    browserGetElementParentPropertiespropCount++;
                }

                if (__workflow_browserGetElementParentPropertiessearchElementBoundingBoxRight != null)
                {
                    if (__workflow_browserGetElementParentPropertiessearchElementBoundingBoxRight != null)
                    {
                        browserGetElementParentProperties["SearchElementBoundingBoxRight"] = ExpressionConverter.ConvertO(__workflow_browserGetElementParentPropertiessearchElementBoundingBoxRight);
                        browserGetElementParentPropertiespropCount++;
                    }

                    browserGetElementParentPropertiespropCount++;
                }
                else
                {
                    browserGetElementParentProperties["SearchElementBoundingBoxRight"] = 99999;
                    browserGetElementParentPropertiespropCount++;
                }

                if (__workflow_browserGetElementParentPropertiessearchElementBoundingBoxTop != null)
                {
                    if (__workflow_browserGetElementParentPropertiessearchElementBoundingBoxTop != null)
                    {
                        browserGetElementParentProperties["SearchElementBoundingBoxTop"] = ExpressionConverter.ConvertO(__workflow_browserGetElementParentPropertiessearchElementBoundingBoxTop);
                        browserGetElementParentPropertiespropCount++;
                    }

                    browserGetElementParentPropertiespropCount++;
                }
                else
                {
                    browserGetElementParentProperties["SearchElementBoundingBoxTop"] = -99999;
                    browserGetElementParentPropertiespropCount++;
                }

                if (__workflow_browserGetElementParentPropertiessearchElementBoundingBoxBottom != null)
                {
                    if (__workflow_browserGetElementParentPropertiessearchElementBoundingBoxBottom != null)
                    {
                        browserGetElementParentProperties["SearchElementBoundingBoxBottom"] = ExpressionConverter.ConvertO(__workflow_browserGetElementParentPropertiessearchElementBoundingBoxBottom);
                        browserGetElementParentPropertiespropCount++;
                    }

                    browserGetElementParentPropertiespropCount++;
                }
                else
                {
                    browserGetElementParentProperties["SearchElementBoundingBoxBottom"] = 99999;
                    browserGetElementParentPropertiespropCount++;
                }

                if (__workflow_browserGetElementParentPropertiesonlyElementTopLeftNeedsToBeInBoundingBox != null)
                {
                    if (__workflow_browserGetElementParentPropertiesonlyElementTopLeftNeedsToBeInBoundingBox != null)
                    {
                        browserGetElementParentProperties["OnlyElementTopLeftNeedsToBeInBoundingBox"] = ExpressionConverter.ConvertO(__workflow_browserGetElementParentPropertiesonlyElementTopLeftNeedsToBeInBoundingBox);
                        browserGetElementParentPropertiespropCount++;
                    }

                    browserGetElementParentPropertiespropCount++;
                }
                else
                {
                    browserGetElementParentProperties["OnlyElementTopLeftNeedsToBeInBoundingBox"] = false;
                    browserGetElementParentPropertiespropCount++;
                }

                if (__workflow_browserGetElementParentPropertiesgetHTMLCode != null)
                {
                    if (__workflow_browserGetElementParentPropertiesgetHTMLCode != null)
                    {
                        browserGetElementParentProperties["GetHTMLCode"] = ExpressionConverter.ConvertO(__workflow_browserGetElementParentPropertiesgetHTMLCode);
                        browserGetElementParentPropertiespropCount++;
                    }

                    browserGetElementParentPropertiespropCount++;
                }
                else
                {
                    browserGetElementParentProperties["GetHTMLCode"] = false;
                    browserGetElementParentPropertiespropCount++;
                }

                if (__workflow_browserGetElementParentPropertiescreateHandle != null)
                {
                    if (__workflow_browserGetElementParentPropertiescreateHandle != null)
                    {
                        browserGetElementParentProperties["CreateHandle"] = ExpressionConverter.ConvertO(__workflow_browserGetElementParentPropertiescreateHandle);
                        browserGetElementParentPropertiespropCount++;
                    }

                    browserGetElementParentPropertiespropCount++;
                }
                else
                {
                    browserGetElementParentProperties["CreateHandle"] = true;
                    browserGetElementParentPropertiespropCount++;
                }

                browserGetElementParentPropertiespropCount++;
                browserGetElementParentProperties["Workflow"] = ExpressionConverter.ConvertO(__workflow_browserGetElementParentPropertiesworkflow);
                if (browserGetElementParentPropertiespropCount > 0)
                {
                    callPayload.Body = browserGetElementParentProperties;
                }

                return new ApiConnectionAction<BrowserGetElementParentPropertiesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserGetElementChildrenPropertiesResponse> BrowserGetElementChildrenProperties(Expression<Func<string>> browserGetElementChildrenPropertiesworkflow, Expression<Func<double>> browserGetElementChildrenPropertiesparentElementHandle = null, Expression<Func<string>> browserGetElementChildrenPropertiessearchElementName = null, Expression<Func<string>> browserGetElementChildrenPropertiessearchElementID = null, Expression<Func<string>> browserGetElementChildrenPropertiessearchElementTagName = null, Expression<Func<string>> browserGetElementChildrenPropertiessearchElementXPath = null, Expression<Func<string>> browserGetElementChildrenPropertiessearchElementClassName = null, Expression<Func<string>> browserGetElementChildrenPropertiessearchElementCSSSelector = null, Expression<Func<string>> browserGetElementChildrenPropertiessearchElementMatchValue = null, Expression<Func<string>> browserGetElementChildrenPropertiessearchElementMatchText = null, Expression<Func<string>> browserGetElementChildrenPropertiessearchElementType = null, Expression<Func<double>> browserGetElementChildrenPropertiessearchElementMinimumWidth = null, Expression<Func<double>> browserGetElementChildrenPropertiessearchElementMinimumHeight = null, Expression<Func<double>> browserGetElementChildrenPropertiessearchElementBoundingBoxLeft = null, Expression<Func<double>> browserGetElementChildrenPropertiessearchElementBoundingBoxRight = null, Expression<Func<double>> browserGetElementChildrenPropertiessearchElementBoundingBoxTop = null, Expression<Func<double>> browserGetElementChildrenPropertiessearchElementBoundingBoxBottom = null, Expression<Func<bool>> browserGetElementChildrenPropertiesonlyElementTopLeftNeedsToBeInBoundingBox = null, Expression<Func<bool>> browserGetElementChildrenPropertiesgetHTMLCode = null, Expression<Func<bool>> browserGetElementChildrenPropertiescreateHandle = null, Expression<Func<bool>> browserGetElementChildrenPropertiessearchSubTree = null, Expression<Func<bool>> browserGetElementChildrenPropertiesreturnValue = null, Expression<Func<bool>> browserGetElementChildrenPropertiesreturnText = null, Expression<Func<int>> browserGetElementChildrenPropertiesmaxValueLength = null, Expression<Func<int>> browserGetElementChildrenPropertiesmaxTextLength = null, Expression<Func<bool>> browserGetElementChildrenPropertiesreturnIsDisplayed = null, Expression<Func<bool>> browserGetElementChildrenPropertiesreturnCoordinates = null, Expression<Func<bool>> browserGetElementChildrenPropertiesreturnDimensions = null, Expression<Func<bool>> browserGetElementChildrenPropertiesreturnChildElementCount = null, Expression<Func<bool>> browserGetElementChildrenPropertiesreturnParentTag = null, Expression<Func<int>> browserGetElementChildrenPropertiesfirstItemToReturn = null, Expression<Func<int>> browserGetElementChildrenPropertiesmaxItemsToReturn = null)
        {
            var __workflow_browserGetElementChildrenPropertiesworkflow = WorkflowExpression.Compile(browserGetElementChildrenPropertiesworkflow, nameof(browserGetElementChildrenPropertiesworkflow), required: true);
            var __workflow_browserGetElementChildrenPropertiesparentElementHandle = WorkflowExpression.Compile(browserGetElementChildrenPropertiesparentElementHandle, nameof(browserGetElementChildrenPropertiesparentElementHandle), required: false);
            var __workflow_browserGetElementChildrenPropertiessearchElementName = WorkflowExpression.Compile(browserGetElementChildrenPropertiessearchElementName, nameof(browserGetElementChildrenPropertiessearchElementName), required: false);
            var __workflow_browserGetElementChildrenPropertiessearchElementID = WorkflowExpression.Compile(browserGetElementChildrenPropertiessearchElementID, nameof(browserGetElementChildrenPropertiessearchElementID), required: false);
            var __workflow_browserGetElementChildrenPropertiessearchElementTagName = WorkflowExpression.Compile(browserGetElementChildrenPropertiessearchElementTagName, nameof(browserGetElementChildrenPropertiessearchElementTagName), required: false);
            var __workflow_browserGetElementChildrenPropertiessearchElementXPath = WorkflowExpression.Compile(browserGetElementChildrenPropertiessearchElementXPath, nameof(browserGetElementChildrenPropertiessearchElementXPath), required: false);
            var __workflow_browserGetElementChildrenPropertiessearchElementClassName = WorkflowExpression.Compile(browserGetElementChildrenPropertiessearchElementClassName, nameof(browserGetElementChildrenPropertiessearchElementClassName), required: false);
            var __workflow_browserGetElementChildrenPropertiessearchElementCSSSelector = WorkflowExpression.Compile(browserGetElementChildrenPropertiessearchElementCSSSelector, nameof(browserGetElementChildrenPropertiessearchElementCSSSelector), required: false);
            var __workflow_browserGetElementChildrenPropertiessearchElementMatchValue = WorkflowExpression.Compile(browserGetElementChildrenPropertiessearchElementMatchValue, nameof(browserGetElementChildrenPropertiessearchElementMatchValue), required: false);
            var __workflow_browserGetElementChildrenPropertiessearchElementMatchText = WorkflowExpression.Compile(browserGetElementChildrenPropertiessearchElementMatchText, nameof(browserGetElementChildrenPropertiessearchElementMatchText), required: false);
            var __workflow_browserGetElementChildrenPropertiessearchElementType = WorkflowExpression.Compile(browserGetElementChildrenPropertiessearchElementType, nameof(browserGetElementChildrenPropertiessearchElementType), required: false);
            var __workflow_browserGetElementChildrenPropertiessearchElementMinimumWidth = WorkflowExpression.Compile(browserGetElementChildrenPropertiessearchElementMinimumWidth, nameof(browserGetElementChildrenPropertiessearchElementMinimumWidth), required: false);
            var __workflow_browserGetElementChildrenPropertiessearchElementMinimumHeight = WorkflowExpression.Compile(browserGetElementChildrenPropertiessearchElementMinimumHeight, nameof(browserGetElementChildrenPropertiessearchElementMinimumHeight), required: false);
            var __workflow_browserGetElementChildrenPropertiessearchElementBoundingBoxLeft = WorkflowExpression.Compile(browserGetElementChildrenPropertiessearchElementBoundingBoxLeft, nameof(browserGetElementChildrenPropertiessearchElementBoundingBoxLeft), required: false);
            var __workflow_browserGetElementChildrenPropertiessearchElementBoundingBoxRight = WorkflowExpression.Compile(browserGetElementChildrenPropertiessearchElementBoundingBoxRight, nameof(browserGetElementChildrenPropertiessearchElementBoundingBoxRight), required: false);
            var __workflow_browserGetElementChildrenPropertiessearchElementBoundingBoxTop = WorkflowExpression.Compile(browserGetElementChildrenPropertiessearchElementBoundingBoxTop, nameof(browserGetElementChildrenPropertiessearchElementBoundingBoxTop), required: false);
            var __workflow_browserGetElementChildrenPropertiessearchElementBoundingBoxBottom = WorkflowExpression.Compile(browserGetElementChildrenPropertiessearchElementBoundingBoxBottom, nameof(browserGetElementChildrenPropertiessearchElementBoundingBoxBottom), required: false);
            var __workflow_browserGetElementChildrenPropertiesonlyElementTopLeftNeedsToBeInBoundingBox = WorkflowExpression.Compile(browserGetElementChildrenPropertiesonlyElementTopLeftNeedsToBeInBoundingBox, nameof(browserGetElementChildrenPropertiesonlyElementTopLeftNeedsToBeInBoundingBox), required: false);
            var __workflow_browserGetElementChildrenPropertiesgetHTMLCode = WorkflowExpression.Compile(browserGetElementChildrenPropertiesgetHTMLCode, nameof(browserGetElementChildrenPropertiesgetHTMLCode), required: false);
            var __workflow_browserGetElementChildrenPropertiescreateHandle = WorkflowExpression.Compile(browserGetElementChildrenPropertiescreateHandle, nameof(browserGetElementChildrenPropertiescreateHandle), required: false);
            var __workflow_browserGetElementChildrenPropertiessearchSubTree = WorkflowExpression.Compile(browserGetElementChildrenPropertiessearchSubTree, nameof(browserGetElementChildrenPropertiessearchSubTree), required: false);
            var __workflow_browserGetElementChildrenPropertiesreturnValue = WorkflowExpression.Compile(browserGetElementChildrenPropertiesreturnValue, nameof(browserGetElementChildrenPropertiesreturnValue), required: false);
            var __workflow_browserGetElementChildrenPropertiesreturnText = WorkflowExpression.Compile(browserGetElementChildrenPropertiesreturnText, nameof(browserGetElementChildrenPropertiesreturnText), required: false);
            var __workflow_browserGetElementChildrenPropertiesmaxValueLength = WorkflowExpression.Compile(browserGetElementChildrenPropertiesmaxValueLength, nameof(browserGetElementChildrenPropertiesmaxValueLength), required: false);
            var __workflow_browserGetElementChildrenPropertiesmaxTextLength = WorkflowExpression.Compile(browserGetElementChildrenPropertiesmaxTextLength, nameof(browserGetElementChildrenPropertiesmaxTextLength), required: false);
            var __workflow_browserGetElementChildrenPropertiesreturnIsDisplayed = WorkflowExpression.Compile(browserGetElementChildrenPropertiesreturnIsDisplayed, nameof(browserGetElementChildrenPropertiesreturnIsDisplayed), required: false);
            var __workflow_browserGetElementChildrenPropertiesreturnCoordinates = WorkflowExpression.Compile(browserGetElementChildrenPropertiesreturnCoordinates, nameof(browserGetElementChildrenPropertiesreturnCoordinates), required: false);
            var __workflow_browserGetElementChildrenPropertiesreturnDimensions = WorkflowExpression.Compile(browserGetElementChildrenPropertiesreturnDimensions, nameof(browserGetElementChildrenPropertiesreturnDimensions), required: false);
            var __workflow_browserGetElementChildrenPropertiesreturnChildElementCount = WorkflowExpression.Compile(browserGetElementChildrenPropertiesreturnChildElementCount, nameof(browserGetElementChildrenPropertiesreturnChildElementCount), required: false);
            var __workflow_browserGetElementChildrenPropertiesreturnParentTag = WorkflowExpression.Compile(browserGetElementChildrenPropertiesreturnParentTag, nameof(browserGetElementChildrenPropertiesreturnParentTag), required: false);
            var __workflow_browserGetElementChildrenPropertiesfirstItemToReturn = WorkflowExpression.Compile(browserGetElementChildrenPropertiesfirstItemToReturn, nameof(browserGetElementChildrenPropertiesfirstItemToReturn), required: false);
            var __workflow_browserGetElementChildrenPropertiesmaxItemsToReturn = WorkflowExpression.Compile(browserGetElementChildrenPropertiesmaxItemsToReturn, nameof(browserGetElementChildrenPropertiesmaxItemsToReturn), required: false);
            return new DeferredBodyAction<BrowserGetElementChildrenPropertiesResponse>(() =>
            {
                var apiCallPath = "/BrowserControl/GetElementChildrenProperties";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserGetElementChildrenProperties = new JObject();
                var browserGetElementChildrenPropertiespropCount = 0;
                if (__workflow_browserGetElementChildrenPropertiesparentElementHandle != null)
                {
                    browserGetElementChildrenProperties["ParentElementHandle"] = ExpressionConverter.ConvertO(__workflow_browserGetElementChildrenPropertiesparentElementHandle);
                    browserGetElementChildrenPropertiespropCount++;
                }

                if (__workflow_browserGetElementChildrenPropertiessearchElementName != null)
                {
                    browserGetElementChildrenProperties["SearchElementName"] = ExpressionConverter.ConvertO(__workflow_browserGetElementChildrenPropertiessearchElementName);
                    browserGetElementChildrenPropertiespropCount++;
                }

                if (__workflow_browserGetElementChildrenPropertiessearchElementID != null)
                {
                    browserGetElementChildrenProperties["SearchElementID"] = ExpressionConverter.ConvertO(__workflow_browserGetElementChildrenPropertiessearchElementID);
                    browserGetElementChildrenPropertiespropCount++;
                }

                if (__workflow_browserGetElementChildrenPropertiessearchElementTagName != null)
                {
                    browserGetElementChildrenProperties["SearchElementTagName"] = ExpressionConverter.ConvertO(__workflow_browserGetElementChildrenPropertiessearchElementTagName);
                    browserGetElementChildrenPropertiespropCount++;
                }

                if (__workflow_browserGetElementChildrenPropertiessearchElementXPath != null)
                {
                    browserGetElementChildrenProperties["SearchElementXPath"] = ExpressionConverter.ConvertO(__workflow_browserGetElementChildrenPropertiessearchElementXPath);
                    browserGetElementChildrenPropertiespropCount++;
                }

                if (__workflow_browserGetElementChildrenPropertiessearchElementClassName != null)
                {
                    browserGetElementChildrenProperties["SearchElementClassName"] = ExpressionConverter.ConvertO(__workflow_browserGetElementChildrenPropertiessearchElementClassName);
                    browserGetElementChildrenPropertiespropCount++;
                }

                if (__workflow_browserGetElementChildrenPropertiessearchElementCSSSelector != null)
                {
                    browserGetElementChildrenProperties["SearchElementCSSSelector"] = ExpressionConverter.ConvertO(__workflow_browserGetElementChildrenPropertiessearchElementCSSSelector);
                    browserGetElementChildrenPropertiespropCount++;
                }

                if (__workflow_browserGetElementChildrenPropertiessearchElementMatchValue != null)
                {
                    browserGetElementChildrenProperties["SearchElementMatchValue"] = ExpressionConverter.ConvertO(__workflow_browserGetElementChildrenPropertiessearchElementMatchValue);
                    browserGetElementChildrenPropertiespropCount++;
                }

                if (__workflow_browserGetElementChildrenPropertiessearchElementMatchText != null)
                {
                    browserGetElementChildrenProperties["SearchElementMatchText"] = ExpressionConverter.ConvertO(__workflow_browserGetElementChildrenPropertiessearchElementMatchText);
                    browserGetElementChildrenPropertiespropCount++;
                }

                if (__workflow_browserGetElementChildrenPropertiessearchElementType != null)
                {
                    browserGetElementChildrenProperties["SearchElementType"] = ExpressionConverter.ConvertO(__workflow_browserGetElementChildrenPropertiessearchElementType);
                    browserGetElementChildrenPropertiespropCount++;
                }

                if (__workflow_browserGetElementChildrenPropertiessearchElementMinimumWidth != null)
                {
                    if (__workflow_browserGetElementChildrenPropertiessearchElementMinimumWidth != null)
                    {
                        browserGetElementChildrenProperties["SearchElementMinimumWidth"] = ExpressionConverter.ConvertO(__workflow_browserGetElementChildrenPropertiessearchElementMinimumWidth);
                        browserGetElementChildrenPropertiespropCount++;
                    }

                    browserGetElementChildrenPropertiespropCount++;
                }
                else
                {
                    browserGetElementChildrenProperties["SearchElementMinimumWidth"] = 1;
                    browserGetElementChildrenPropertiespropCount++;
                }

                if (__workflow_browserGetElementChildrenPropertiessearchElementMinimumHeight != null)
                {
                    if (__workflow_browserGetElementChildrenPropertiessearchElementMinimumHeight != null)
                    {
                        browserGetElementChildrenProperties["SearchElementMinimumHeight"] = ExpressionConverter.ConvertO(__workflow_browserGetElementChildrenPropertiessearchElementMinimumHeight);
                        browserGetElementChildrenPropertiespropCount++;
                    }

                    browserGetElementChildrenPropertiespropCount++;
                }
                else
                {
                    browserGetElementChildrenProperties["SearchElementMinimumHeight"] = 1;
                    browserGetElementChildrenPropertiespropCount++;
                }

                if (__workflow_browserGetElementChildrenPropertiessearchElementBoundingBoxLeft != null)
                {
                    if (__workflow_browserGetElementChildrenPropertiessearchElementBoundingBoxLeft != null)
                    {
                        browserGetElementChildrenProperties["SearchElementBoundingBoxLeft"] = ExpressionConverter.ConvertO(__workflow_browserGetElementChildrenPropertiessearchElementBoundingBoxLeft);
                        browserGetElementChildrenPropertiespropCount++;
                    }

                    browserGetElementChildrenPropertiespropCount++;
                }
                else
                {
                    browserGetElementChildrenProperties["SearchElementBoundingBoxLeft"] = -99999;
                    browserGetElementChildrenPropertiespropCount++;
                }

                if (__workflow_browserGetElementChildrenPropertiessearchElementBoundingBoxRight != null)
                {
                    if (__workflow_browserGetElementChildrenPropertiessearchElementBoundingBoxRight != null)
                    {
                        browserGetElementChildrenProperties["SearchElementBoundingBoxRight"] = ExpressionConverter.ConvertO(__workflow_browserGetElementChildrenPropertiessearchElementBoundingBoxRight);
                        browserGetElementChildrenPropertiespropCount++;
                    }

                    browserGetElementChildrenPropertiespropCount++;
                }
                else
                {
                    browserGetElementChildrenProperties["SearchElementBoundingBoxRight"] = 99999;
                    browserGetElementChildrenPropertiespropCount++;
                }

                if (__workflow_browserGetElementChildrenPropertiessearchElementBoundingBoxTop != null)
                {
                    if (__workflow_browserGetElementChildrenPropertiessearchElementBoundingBoxTop != null)
                    {
                        browserGetElementChildrenProperties["SearchElementBoundingBoxTop"] = ExpressionConverter.ConvertO(__workflow_browserGetElementChildrenPropertiessearchElementBoundingBoxTop);
                        browserGetElementChildrenPropertiespropCount++;
                    }

                    browserGetElementChildrenPropertiespropCount++;
                }
                else
                {
                    browserGetElementChildrenProperties["SearchElementBoundingBoxTop"] = -99999;
                    browserGetElementChildrenPropertiespropCount++;
                }

                if (__workflow_browserGetElementChildrenPropertiessearchElementBoundingBoxBottom != null)
                {
                    if (__workflow_browserGetElementChildrenPropertiessearchElementBoundingBoxBottom != null)
                    {
                        browserGetElementChildrenProperties["SearchElementBoundingBoxBottom"] = ExpressionConverter.ConvertO(__workflow_browserGetElementChildrenPropertiessearchElementBoundingBoxBottom);
                        browserGetElementChildrenPropertiespropCount++;
                    }

                    browserGetElementChildrenPropertiespropCount++;
                }
                else
                {
                    browserGetElementChildrenProperties["SearchElementBoundingBoxBottom"] = 99999;
                    browserGetElementChildrenPropertiespropCount++;
                }

                if (__workflow_browserGetElementChildrenPropertiesonlyElementTopLeftNeedsToBeInBoundingBox != null)
                {
                    if (__workflow_browserGetElementChildrenPropertiesonlyElementTopLeftNeedsToBeInBoundingBox != null)
                    {
                        browserGetElementChildrenProperties["OnlyElementTopLeftNeedsToBeInBoundingBox"] = ExpressionConverter.ConvertO(__workflow_browserGetElementChildrenPropertiesonlyElementTopLeftNeedsToBeInBoundingBox);
                        browserGetElementChildrenPropertiespropCount++;
                    }

                    browserGetElementChildrenPropertiespropCount++;
                }
                else
                {
                    browserGetElementChildrenProperties["OnlyElementTopLeftNeedsToBeInBoundingBox"] = false;
                    browserGetElementChildrenPropertiespropCount++;
                }

                if (__workflow_browserGetElementChildrenPropertiesgetHTMLCode != null)
                {
                    if (__workflow_browserGetElementChildrenPropertiesgetHTMLCode != null)
                    {
                        browserGetElementChildrenProperties["GetHTMLCode"] = ExpressionConverter.ConvertO(__workflow_browserGetElementChildrenPropertiesgetHTMLCode);
                        browserGetElementChildrenPropertiespropCount++;
                    }

                    browserGetElementChildrenPropertiespropCount++;
                }
                else
                {
                    browserGetElementChildrenProperties["GetHTMLCode"] = false;
                    browserGetElementChildrenPropertiespropCount++;
                }

                if (__workflow_browserGetElementChildrenPropertiescreateHandle != null)
                {
                    if (__workflow_browserGetElementChildrenPropertiescreateHandle != null)
                    {
                        browserGetElementChildrenProperties["CreateHandle"] = ExpressionConverter.ConvertO(__workflow_browserGetElementChildrenPropertiescreateHandle);
                        browserGetElementChildrenPropertiespropCount++;
                    }

                    browserGetElementChildrenPropertiespropCount++;
                }
                else
                {
                    browserGetElementChildrenProperties["CreateHandle"] = true;
                    browserGetElementChildrenPropertiespropCount++;
                }

                if (__workflow_browserGetElementChildrenPropertiessearchSubTree != null)
                {
                    if (__workflow_browserGetElementChildrenPropertiessearchSubTree != null)
                    {
                        browserGetElementChildrenProperties["SearchSubTree"] = ExpressionConverter.ConvertO(__workflow_browserGetElementChildrenPropertiessearchSubTree);
                        browserGetElementChildrenPropertiespropCount++;
                    }

                    browserGetElementChildrenPropertiespropCount++;
                }
                else
                {
                    browserGetElementChildrenProperties["SearchSubTree"] = false;
                    browserGetElementChildrenPropertiespropCount++;
                }

                if (__workflow_browserGetElementChildrenPropertiesreturnValue != null)
                {
                    if (__workflow_browserGetElementChildrenPropertiesreturnValue != null)
                    {
                        browserGetElementChildrenProperties["ReturnValue"] = ExpressionConverter.ConvertO(__workflow_browserGetElementChildrenPropertiesreturnValue);
                        browserGetElementChildrenPropertiespropCount++;
                    }

                    browserGetElementChildrenPropertiespropCount++;
                }
                else
                {
                    browserGetElementChildrenProperties["ReturnValue"] = true;
                    browserGetElementChildrenPropertiespropCount++;
                }

                if (__workflow_browserGetElementChildrenPropertiesreturnText != null)
                {
                    if (__workflow_browserGetElementChildrenPropertiesreturnText != null)
                    {
                        browserGetElementChildrenProperties["ReturnText"] = ExpressionConverter.ConvertO(__workflow_browserGetElementChildrenPropertiesreturnText);
                        browserGetElementChildrenPropertiespropCount++;
                    }

                    browserGetElementChildrenPropertiespropCount++;
                }
                else
                {
                    browserGetElementChildrenProperties["ReturnText"] = true;
                    browserGetElementChildrenPropertiespropCount++;
                }

                if (__workflow_browserGetElementChildrenPropertiesmaxValueLength != null)
                {
                    if (__workflow_browserGetElementChildrenPropertiesmaxValueLength != null)
                    {
                        browserGetElementChildrenProperties["MaxValueLength"] = ExpressionConverter.ConvertO(__workflow_browserGetElementChildrenPropertiesmaxValueLength);
                        browserGetElementChildrenPropertiespropCount++;
                    }

                    browserGetElementChildrenPropertiespropCount++;
                }
                else
                {
                    browserGetElementChildrenProperties["MaxValueLength"] = 0;
                    browserGetElementChildrenPropertiespropCount++;
                }

                if (__workflow_browserGetElementChildrenPropertiesmaxTextLength != null)
                {
                    if (__workflow_browserGetElementChildrenPropertiesmaxTextLength != null)
                    {
                        browserGetElementChildrenProperties["MaxTextLength"] = ExpressionConverter.ConvertO(__workflow_browserGetElementChildrenPropertiesmaxTextLength);
                        browserGetElementChildrenPropertiespropCount++;
                    }

                    browserGetElementChildrenPropertiespropCount++;
                }
                else
                {
                    browserGetElementChildrenProperties["MaxTextLength"] = 0;
                    browserGetElementChildrenPropertiespropCount++;
                }

                if (__workflow_browserGetElementChildrenPropertiesreturnIsDisplayed != null)
                {
                    if (__workflow_browserGetElementChildrenPropertiesreturnIsDisplayed != null)
                    {
                        browserGetElementChildrenProperties["ReturnIsDisplayed"] = ExpressionConverter.ConvertO(__workflow_browserGetElementChildrenPropertiesreturnIsDisplayed);
                        browserGetElementChildrenPropertiespropCount++;
                    }

                    browserGetElementChildrenPropertiespropCount++;
                }
                else
                {
                    browserGetElementChildrenProperties["ReturnIsDisplayed"] = true;
                    browserGetElementChildrenPropertiespropCount++;
                }

                if (__workflow_browserGetElementChildrenPropertiesreturnCoordinates != null)
                {
                    if (__workflow_browserGetElementChildrenPropertiesreturnCoordinates != null)
                    {
                        browserGetElementChildrenProperties["ReturnCoordinates"] = ExpressionConverter.ConvertO(__workflow_browserGetElementChildrenPropertiesreturnCoordinates);
                        browserGetElementChildrenPropertiespropCount++;
                    }

                    browserGetElementChildrenPropertiespropCount++;
                }
                else
                {
                    browserGetElementChildrenProperties["ReturnCoordinates"] = true;
                    browserGetElementChildrenPropertiespropCount++;
                }

                if (__workflow_browserGetElementChildrenPropertiesreturnDimensions != null)
                {
                    if (__workflow_browserGetElementChildrenPropertiesreturnDimensions != null)
                    {
                        browserGetElementChildrenProperties["ReturnDimensions"] = ExpressionConverter.ConvertO(__workflow_browserGetElementChildrenPropertiesreturnDimensions);
                        browserGetElementChildrenPropertiespropCount++;
                    }

                    browserGetElementChildrenPropertiespropCount++;
                }
                else
                {
                    browserGetElementChildrenProperties["ReturnDimensions"] = true;
                    browserGetElementChildrenPropertiespropCount++;
                }

                if (__workflow_browserGetElementChildrenPropertiesreturnChildElementCount != null)
                {
                    if (__workflow_browserGetElementChildrenPropertiesreturnChildElementCount != null)
                    {
                        browserGetElementChildrenProperties["ReturnChildElementCount"] = ExpressionConverter.ConvertO(__workflow_browserGetElementChildrenPropertiesreturnChildElementCount);
                        browserGetElementChildrenPropertiespropCount++;
                    }

                    browserGetElementChildrenPropertiespropCount++;
                }
                else
                {
                    browserGetElementChildrenProperties["ReturnChildElementCount"] = true;
                    browserGetElementChildrenPropertiespropCount++;
                }

                if (__workflow_browserGetElementChildrenPropertiesreturnParentTag != null)
                {
                    if (__workflow_browserGetElementChildrenPropertiesreturnParentTag != null)
                    {
                        browserGetElementChildrenProperties["ReturnParentTag"] = ExpressionConverter.ConvertO(__workflow_browserGetElementChildrenPropertiesreturnParentTag);
                        browserGetElementChildrenPropertiespropCount++;
                    }

                    browserGetElementChildrenPropertiespropCount++;
                }
                else
                {
                    browserGetElementChildrenProperties["ReturnParentTag"] = true;
                    browserGetElementChildrenPropertiespropCount++;
                }

                if (__workflow_browserGetElementChildrenPropertiesfirstItemToReturn != null)
                {
                    if (__workflow_browserGetElementChildrenPropertiesfirstItemToReturn != null)
                    {
                        browserGetElementChildrenProperties["FirstItemToReturn"] = ExpressionConverter.ConvertO(__workflow_browserGetElementChildrenPropertiesfirstItemToReturn);
                        browserGetElementChildrenPropertiespropCount++;
                    }

                    browserGetElementChildrenPropertiespropCount++;
                }
                else
                {
                    browserGetElementChildrenProperties["FirstItemToReturn"] = 1;
                    browserGetElementChildrenPropertiespropCount++;
                }

                if (__workflow_browserGetElementChildrenPropertiesmaxItemsToReturn != null)
                {
                    if (__workflow_browserGetElementChildrenPropertiesmaxItemsToReturn != null)
                    {
                        browserGetElementChildrenProperties["MaxItemsToReturn"] = ExpressionConverter.ConvertO(__workflow_browserGetElementChildrenPropertiesmaxItemsToReturn);
                        browserGetElementChildrenPropertiespropCount++;
                    }

                    browserGetElementChildrenPropertiespropCount++;
                }
                else
                {
                    browserGetElementChildrenProperties["MaxItemsToReturn"] = 0;
                    browserGetElementChildrenPropertiespropCount++;
                }

                browserGetElementChildrenPropertiespropCount++;
                browserGetElementChildrenProperties["Workflow"] = ExpressionConverter.ConvertO(__workflow_browserGetElementChildrenPropertiesworkflow);
                if (browserGetElementChildrenPropertiespropCount > 0)
                {
                    callPayload.Body = browserGetElementChildrenProperties;
                }

                return new ApiConnectionAction<BrowserGetElementChildrenPropertiesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserInputTextIntoElementResponse> BrowserInputTextIntoElement(Expression<Func<string>> browserInputTextIntoElementworkflow, Expression<Func<double>> browserInputTextIntoElementparentElementHandle = null, Expression<Func<double>> browserInputTextIntoElementsearchElementHandle = null, Expression<Func<string>> browserInputTextIntoElementsearchElementName = null, Expression<Func<string>> browserInputTextIntoElementsearchElementID = null, Expression<Func<string>> browserInputTextIntoElementsearchElementTagName = null, Expression<Func<string>> browserInputTextIntoElementsearchElementXPath = null, Expression<Func<string>> browserInputTextIntoElementsearchElementClassName = null, Expression<Func<string>> browserInputTextIntoElementsearchElementCSSSelector = null, Expression<Func<double>> browserInputTextIntoElementsearchElementIndex = null, Expression<Func<string>> browserInputTextIntoElementsearchElementMatchValue = null, Expression<Func<string>> browserInputTextIntoElementsearchElementMatchText = null, Expression<Func<string>> browserInputTextIntoElementsearchElementType = null, Expression<Func<double>> browserInputTextIntoElementsearchElementMinimumWidth = null, Expression<Func<double>> browserInputTextIntoElementsearchElementMinimumHeight = null, Expression<Func<double>> browserInputTextIntoElementsearchElementBoundingBoxLeft = null, Expression<Func<double>> browserInputTextIntoElementsearchElementBoundingBoxRight = null, Expression<Func<double>> browserInputTextIntoElementsearchElementBoundingBoxTop = null, Expression<Func<double>> browserInputTextIntoElementsearchElementBoundingBoxBottom = null, Expression<Func<bool>> browserInputTextIntoElementonlyElementTopLeftNeedsToBeInBoundingBox = null, Expression<Func<string>> browserInputTextIntoElementtextToInput = null, Expression<Func<bool>> browserInputTextIntoElementresetExistingValue = null, Expression<Func<int>> browserInputTextIntoElementinsertPosition = null)
        {
            var __workflow_browserInputTextIntoElementworkflow = WorkflowExpression.Compile(browserInputTextIntoElementworkflow, nameof(browserInputTextIntoElementworkflow), required: true);
            var __workflow_browserInputTextIntoElementparentElementHandle = WorkflowExpression.Compile(browserInputTextIntoElementparentElementHandle, nameof(browserInputTextIntoElementparentElementHandle), required: false);
            var __workflow_browserInputTextIntoElementsearchElementHandle = WorkflowExpression.Compile(browserInputTextIntoElementsearchElementHandle, nameof(browserInputTextIntoElementsearchElementHandle), required: false);
            var __workflow_browserInputTextIntoElementsearchElementName = WorkflowExpression.Compile(browserInputTextIntoElementsearchElementName, nameof(browserInputTextIntoElementsearchElementName), required: false);
            var __workflow_browserInputTextIntoElementsearchElementID = WorkflowExpression.Compile(browserInputTextIntoElementsearchElementID, nameof(browserInputTextIntoElementsearchElementID), required: false);
            var __workflow_browserInputTextIntoElementsearchElementTagName = WorkflowExpression.Compile(browserInputTextIntoElementsearchElementTagName, nameof(browserInputTextIntoElementsearchElementTagName), required: false);
            var __workflow_browserInputTextIntoElementsearchElementXPath = WorkflowExpression.Compile(browserInputTextIntoElementsearchElementXPath, nameof(browserInputTextIntoElementsearchElementXPath), required: false);
            var __workflow_browserInputTextIntoElementsearchElementClassName = WorkflowExpression.Compile(browserInputTextIntoElementsearchElementClassName, nameof(browserInputTextIntoElementsearchElementClassName), required: false);
            var __workflow_browserInputTextIntoElementsearchElementCSSSelector = WorkflowExpression.Compile(browserInputTextIntoElementsearchElementCSSSelector, nameof(browserInputTextIntoElementsearchElementCSSSelector), required: false);
            var __workflow_browserInputTextIntoElementsearchElementIndex = WorkflowExpression.Compile(browserInputTextIntoElementsearchElementIndex, nameof(browserInputTextIntoElementsearchElementIndex), required: false);
            var __workflow_browserInputTextIntoElementsearchElementMatchValue = WorkflowExpression.Compile(browserInputTextIntoElementsearchElementMatchValue, nameof(browserInputTextIntoElementsearchElementMatchValue), required: false);
            var __workflow_browserInputTextIntoElementsearchElementMatchText = WorkflowExpression.Compile(browserInputTextIntoElementsearchElementMatchText, nameof(browserInputTextIntoElementsearchElementMatchText), required: false);
            var __workflow_browserInputTextIntoElementsearchElementType = WorkflowExpression.Compile(browserInputTextIntoElementsearchElementType, nameof(browserInputTextIntoElementsearchElementType), required: false);
            var __workflow_browserInputTextIntoElementsearchElementMinimumWidth = WorkflowExpression.Compile(browserInputTextIntoElementsearchElementMinimumWidth, nameof(browserInputTextIntoElementsearchElementMinimumWidth), required: false);
            var __workflow_browserInputTextIntoElementsearchElementMinimumHeight = WorkflowExpression.Compile(browserInputTextIntoElementsearchElementMinimumHeight, nameof(browserInputTextIntoElementsearchElementMinimumHeight), required: false);
            var __workflow_browserInputTextIntoElementsearchElementBoundingBoxLeft = WorkflowExpression.Compile(browserInputTextIntoElementsearchElementBoundingBoxLeft, nameof(browserInputTextIntoElementsearchElementBoundingBoxLeft), required: false);
            var __workflow_browserInputTextIntoElementsearchElementBoundingBoxRight = WorkflowExpression.Compile(browserInputTextIntoElementsearchElementBoundingBoxRight, nameof(browserInputTextIntoElementsearchElementBoundingBoxRight), required: false);
            var __workflow_browserInputTextIntoElementsearchElementBoundingBoxTop = WorkflowExpression.Compile(browserInputTextIntoElementsearchElementBoundingBoxTop, nameof(browserInputTextIntoElementsearchElementBoundingBoxTop), required: false);
            var __workflow_browserInputTextIntoElementsearchElementBoundingBoxBottom = WorkflowExpression.Compile(browserInputTextIntoElementsearchElementBoundingBoxBottom, nameof(browserInputTextIntoElementsearchElementBoundingBoxBottom), required: false);
            var __workflow_browserInputTextIntoElementonlyElementTopLeftNeedsToBeInBoundingBox = WorkflowExpression.Compile(browserInputTextIntoElementonlyElementTopLeftNeedsToBeInBoundingBox, nameof(browserInputTextIntoElementonlyElementTopLeftNeedsToBeInBoundingBox), required: false);
            var __workflow_browserInputTextIntoElementtextToInput = WorkflowExpression.Compile(browserInputTextIntoElementtextToInput, nameof(browserInputTextIntoElementtextToInput), required: false);
            var __workflow_browserInputTextIntoElementresetExistingValue = WorkflowExpression.Compile(browserInputTextIntoElementresetExistingValue, nameof(browserInputTextIntoElementresetExistingValue), required: false);
            var __workflow_browserInputTextIntoElementinsertPosition = WorkflowExpression.Compile(browserInputTextIntoElementinsertPosition, nameof(browserInputTextIntoElementinsertPosition), required: false);
            return new DeferredBodyAction<BrowserInputTextIntoElementResponse>(() =>
            {
                var apiCallPath = "/BrowserControl/InputTextIntoElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserInputTextIntoElement = new JObject();
                var browserInputTextIntoElementpropCount = 0;
                if (__workflow_browserInputTextIntoElementparentElementHandle != null)
                {
                    browserInputTextIntoElement["ParentElementHandle"] = ExpressionConverter.ConvertO(__workflow_browserInputTextIntoElementparentElementHandle);
                    browserInputTextIntoElementpropCount++;
                }

                if (__workflow_browserInputTextIntoElementsearchElementHandle != null)
                {
                    browserInputTextIntoElement["SearchElementHandle"] = ExpressionConverter.ConvertO(__workflow_browserInputTextIntoElementsearchElementHandle);
                    browserInputTextIntoElementpropCount++;
                }

                if (__workflow_browserInputTextIntoElementsearchElementName != null)
                {
                    browserInputTextIntoElement["SearchElementName"] = ExpressionConverter.ConvertO(__workflow_browserInputTextIntoElementsearchElementName);
                    browserInputTextIntoElementpropCount++;
                }

                if (__workflow_browserInputTextIntoElementsearchElementID != null)
                {
                    browserInputTextIntoElement["SearchElementID"] = ExpressionConverter.ConvertO(__workflow_browserInputTextIntoElementsearchElementID);
                    browserInputTextIntoElementpropCount++;
                }

                if (__workflow_browserInputTextIntoElementsearchElementTagName != null)
                {
                    browserInputTextIntoElement["SearchElementTagName"] = ExpressionConverter.ConvertO(__workflow_browserInputTextIntoElementsearchElementTagName);
                    browserInputTextIntoElementpropCount++;
                }

                if (__workflow_browserInputTextIntoElementsearchElementXPath != null)
                {
                    browserInputTextIntoElement["SearchElementXPath"] = ExpressionConverter.ConvertO(__workflow_browserInputTextIntoElementsearchElementXPath);
                    browserInputTextIntoElementpropCount++;
                }

                if (__workflow_browserInputTextIntoElementsearchElementClassName != null)
                {
                    browserInputTextIntoElement["SearchElementClassName"] = ExpressionConverter.ConvertO(__workflow_browserInputTextIntoElementsearchElementClassName);
                    browserInputTextIntoElementpropCount++;
                }

                if (__workflow_browserInputTextIntoElementsearchElementCSSSelector != null)
                {
                    browserInputTextIntoElement["SearchElementCSSSelector"] = ExpressionConverter.ConvertO(__workflow_browserInputTextIntoElementsearchElementCSSSelector);
                    browserInputTextIntoElementpropCount++;
                }

                if (__workflow_browserInputTextIntoElementsearchElementIndex != null)
                {
                    if (__workflow_browserInputTextIntoElementsearchElementIndex != null)
                    {
                        browserInputTextIntoElement["SearchElementIndex"] = ExpressionConverter.ConvertO(__workflow_browserInputTextIntoElementsearchElementIndex);
                        browserInputTextIntoElementpropCount++;
                    }

                    browserInputTextIntoElementpropCount++;
                }
                else
                {
                    browserInputTextIntoElement["SearchElementIndex"] = 1;
                    browserInputTextIntoElementpropCount++;
                }

                if (__workflow_browserInputTextIntoElementsearchElementMatchValue != null)
                {
                    browserInputTextIntoElement["SearchElementMatchValue"] = ExpressionConverter.ConvertO(__workflow_browserInputTextIntoElementsearchElementMatchValue);
                    browserInputTextIntoElementpropCount++;
                }

                if (__workflow_browserInputTextIntoElementsearchElementMatchText != null)
                {
                    browserInputTextIntoElement["SearchElementMatchText"] = ExpressionConverter.ConvertO(__workflow_browserInputTextIntoElementsearchElementMatchText);
                    browserInputTextIntoElementpropCount++;
                }

                if (__workflow_browserInputTextIntoElementsearchElementType != null)
                {
                    browserInputTextIntoElement["SearchElementType"] = ExpressionConverter.ConvertO(__workflow_browserInputTextIntoElementsearchElementType);
                    browserInputTextIntoElementpropCount++;
                }

                if (__workflow_browserInputTextIntoElementsearchElementMinimumWidth != null)
                {
                    if (__workflow_browserInputTextIntoElementsearchElementMinimumWidth != null)
                    {
                        browserInputTextIntoElement["SearchElementMinimumWidth"] = ExpressionConverter.ConvertO(__workflow_browserInputTextIntoElementsearchElementMinimumWidth);
                        browserInputTextIntoElementpropCount++;
                    }

                    browserInputTextIntoElementpropCount++;
                }
                else
                {
                    browserInputTextIntoElement["SearchElementMinimumWidth"] = 1;
                    browserInputTextIntoElementpropCount++;
                }

                if (__workflow_browserInputTextIntoElementsearchElementMinimumHeight != null)
                {
                    if (__workflow_browserInputTextIntoElementsearchElementMinimumHeight != null)
                    {
                        browserInputTextIntoElement["SearchElementMinimumHeight"] = ExpressionConverter.ConvertO(__workflow_browserInputTextIntoElementsearchElementMinimumHeight);
                        browserInputTextIntoElementpropCount++;
                    }

                    browserInputTextIntoElementpropCount++;
                }
                else
                {
                    browserInputTextIntoElement["SearchElementMinimumHeight"] = 1;
                    browserInputTextIntoElementpropCount++;
                }

                if (__workflow_browserInputTextIntoElementsearchElementBoundingBoxLeft != null)
                {
                    if (__workflow_browserInputTextIntoElementsearchElementBoundingBoxLeft != null)
                    {
                        browserInputTextIntoElement["SearchElementBoundingBoxLeft"] = ExpressionConverter.ConvertO(__workflow_browserInputTextIntoElementsearchElementBoundingBoxLeft);
                        browserInputTextIntoElementpropCount++;
                    }

                    browserInputTextIntoElementpropCount++;
                }
                else
                {
                    browserInputTextIntoElement["SearchElementBoundingBoxLeft"] = -99999;
                    browserInputTextIntoElementpropCount++;
                }

                if (__workflow_browserInputTextIntoElementsearchElementBoundingBoxRight != null)
                {
                    if (__workflow_browserInputTextIntoElementsearchElementBoundingBoxRight != null)
                    {
                        browserInputTextIntoElement["SearchElementBoundingBoxRight"] = ExpressionConverter.ConvertO(__workflow_browserInputTextIntoElementsearchElementBoundingBoxRight);
                        browserInputTextIntoElementpropCount++;
                    }

                    browserInputTextIntoElementpropCount++;
                }
                else
                {
                    browserInputTextIntoElement["SearchElementBoundingBoxRight"] = 99999;
                    browserInputTextIntoElementpropCount++;
                }

                if (__workflow_browserInputTextIntoElementsearchElementBoundingBoxTop != null)
                {
                    if (__workflow_browserInputTextIntoElementsearchElementBoundingBoxTop != null)
                    {
                        browserInputTextIntoElement["SearchElementBoundingBoxTop"] = ExpressionConverter.ConvertO(__workflow_browserInputTextIntoElementsearchElementBoundingBoxTop);
                        browserInputTextIntoElementpropCount++;
                    }

                    browserInputTextIntoElementpropCount++;
                }
                else
                {
                    browserInputTextIntoElement["SearchElementBoundingBoxTop"] = -99999;
                    browserInputTextIntoElementpropCount++;
                }

                if (__workflow_browserInputTextIntoElementsearchElementBoundingBoxBottom != null)
                {
                    if (__workflow_browserInputTextIntoElementsearchElementBoundingBoxBottom != null)
                    {
                        browserInputTextIntoElement["SearchElementBoundingBoxBottom"] = ExpressionConverter.ConvertO(__workflow_browserInputTextIntoElementsearchElementBoundingBoxBottom);
                        browserInputTextIntoElementpropCount++;
                    }

                    browserInputTextIntoElementpropCount++;
                }
                else
                {
                    browserInputTextIntoElement["SearchElementBoundingBoxBottom"] = 99999;
                    browserInputTextIntoElementpropCount++;
                }

                if (__workflow_browserInputTextIntoElementonlyElementTopLeftNeedsToBeInBoundingBox != null)
                {
                    if (__workflow_browserInputTextIntoElementonlyElementTopLeftNeedsToBeInBoundingBox != null)
                    {
                        browserInputTextIntoElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = ExpressionConverter.ConvertO(__workflow_browserInputTextIntoElementonlyElementTopLeftNeedsToBeInBoundingBox);
                        browserInputTextIntoElementpropCount++;
                    }

                    browserInputTextIntoElementpropCount++;
                }
                else
                {
                    browserInputTextIntoElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = false;
                    browserInputTextIntoElementpropCount++;
                }

                if (__workflow_browserInputTextIntoElementtextToInput != null)
                {
                    browserInputTextIntoElement["TextToInput"] = ExpressionConverter.ConvertO(__workflow_browserInputTextIntoElementtextToInput);
                    browserInputTextIntoElementpropCount++;
                }

                if (__workflow_browserInputTextIntoElementresetExistingValue != null)
                {
                    if (__workflow_browserInputTextIntoElementresetExistingValue != null)
                    {
                        browserInputTextIntoElement["ResetExistingValue"] = ExpressionConverter.ConvertO(__workflow_browserInputTextIntoElementresetExistingValue);
                        browserInputTextIntoElementpropCount++;
                    }

                    browserInputTextIntoElementpropCount++;
                }
                else
                {
                    browserInputTextIntoElement["ResetExistingValue"] = true;
                    browserInputTextIntoElementpropCount++;
                }

                if (__workflow_browserInputTextIntoElementinsertPosition != null)
                {
                    if (__workflow_browserInputTextIntoElementinsertPosition != null)
                    {
                        browserInputTextIntoElement["InsertPosition"] = ExpressionConverter.ConvertO(__workflow_browserInputTextIntoElementinsertPosition);
                        browserInputTextIntoElementpropCount++;
                    }

                    browserInputTextIntoElementpropCount++;
                }
                else
                {
                    browserInputTextIntoElement["InsertPosition"] = -1;
                    browserInputTextIntoElementpropCount++;
                }

                browserInputTextIntoElementpropCount++;
                browserInputTextIntoElement["Workflow"] = ExpressionConverter.ConvertO(__workflow_browserInputTextIntoElementworkflow);
                if (browserInputTextIntoElementpropCount > 0)
                {
                    callPayload.Body = browserInputTextIntoElement;
                }

                return new ApiConnectionAction<BrowserInputTextIntoElementResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserInputTextIntoMultipleElements(Expression<Func<string>> browserInputTextIntoMultipleElementsinputElementsJSON, Expression<Func<string>> browserInputTextIntoMultipleElementsworkflow)
        {
            var __workflow_browserInputTextIntoMultipleElementsinputElementsJSON = WorkflowExpression.Compile(browserInputTextIntoMultipleElementsinputElementsJSON, nameof(browserInputTextIntoMultipleElementsinputElementsJSON), required: true);
            var __workflow_browserInputTextIntoMultipleElementsworkflow = WorkflowExpression.Compile(browserInputTextIntoMultipleElementsworkflow, nameof(browserInputTextIntoMultipleElementsworkflow), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/BrowserControl/BrowserInputTextIntoMultipleElements";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserInputTextIntoMultipleElements = new JObject();
                var browserInputTextIntoMultipleElementspropCount = 0;
                browserInputTextIntoMultipleElementspropCount++;
                browserInputTextIntoMultipleElements["InputElementsJSON"] = ExpressionConverter.ConvertO(__workflow_browserInputTextIntoMultipleElementsinputElementsJSON);
                browserInputTextIntoMultipleElementspropCount++;
                browserInputTextIntoMultipleElements["Workflow"] = ExpressionConverter.ConvertO(__workflow_browserInputTextIntoMultipleElementsworkflow);
                if (browserInputTextIntoMultipleElementspropCount > 0)
                {
                    callPayload.Body = browserInputTextIntoMultipleElements;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserPressCtrlKeyOnElement(Expression<Func<string>> browserPressCtrlKeyOnElementcontrolKey, Expression<Func<string>> browserPressCtrlKeyOnElementworkflow, Expression<Func<double>> browserPressCtrlKeyOnElementparentElementHandle = null, Expression<Func<double>> browserPressCtrlKeyOnElementsearchElementHandle = null, Expression<Func<string>> browserPressCtrlKeyOnElementsearchElementName = null, Expression<Func<string>> browserPressCtrlKeyOnElementsearchElementID = null, Expression<Func<string>> browserPressCtrlKeyOnElementsearchElementTagName = null, Expression<Func<string>> browserPressCtrlKeyOnElementsearchElementXPath = null, Expression<Func<string>> browserPressCtrlKeyOnElementsearchElementClassName = null, Expression<Func<string>> browserPressCtrlKeyOnElementsearchElementCSSSelector = null, Expression<Func<double>> browserPressCtrlKeyOnElementsearchElementIndex = null, Expression<Func<string>> browserPressCtrlKeyOnElementsearchElementMatchValue = null, Expression<Func<string>> browserPressCtrlKeyOnElementsearchElementMatchText = null, Expression<Func<string>> browserPressCtrlKeyOnElementsearchElementType = null, Expression<Func<double>> browserPressCtrlKeyOnElementsearchElementMinimumWidth = null, Expression<Func<double>> browserPressCtrlKeyOnElementsearchElementMinimumHeight = null, Expression<Func<double>> browserPressCtrlKeyOnElementsearchElementBoundingBoxLeft = null, Expression<Func<double>> browserPressCtrlKeyOnElementsearchElementBoundingBoxRight = null, Expression<Func<double>> browserPressCtrlKeyOnElementsearchElementBoundingBoxTop = null, Expression<Func<double>> browserPressCtrlKeyOnElementsearchElementBoundingBoxBottom = null, Expression<Func<bool>> browserPressCtrlKeyOnElementonlyElementTopLeftNeedsToBeInBoundingBox = null)
        {
            var __workflow_browserPressCtrlKeyOnElementcontrolKey = WorkflowExpression.Compile(browserPressCtrlKeyOnElementcontrolKey, nameof(browserPressCtrlKeyOnElementcontrolKey), required: true);
            var __workflow_browserPressCtrlKeyOnElementworkflow = WorkflowExpression.Compile(browserPressCtrlKeyOnElementworkflow, nameof(browserPressCtrlKeyOnElementworkflow), required: true);
            var __workflow_browserPressCtrlKeyOnElementparentElementHandle = WorkflowExpression.Compile(browserPressCtrlKeyOnElementparentElementHandle, nameof(browserPressCtrlKeyOnElementparentElementHandle), required: false);
            var __workflow_browserPressCtrlKeyOnElementsearchElementHandle = WorkflowExpression.Compile(browserPressCtrlKeyOnElementsearchElementHandle, nameof(browserPressCtrlKeyOnElementsearchElementHandle), required: false);
            var __workflow_browserPressCtrlKeyOnElementsearchElementName = WorkflowExpression.Compile(browserPressCtrlKeyOnElementsearchElementName, nameof(browserPressCtrlKeyOnElementsearchElementName), required: false);
            var __workflow_browserPressCtrlKeyOnElementsearchElementID = WorkflowExpression.Compile(browserPressCtrlKeyOnElementsearchElementID, nameof(browserPressCtrlKeyOnElementsearchElementID), required: false);
            var __workflow_browserPressCtrlKeyOnElementsearchElementTagName = WorkflowExpression.Compile(browserPressCtrlKeyOnElementsearchElementTagName, nameof(browserPressCtrlKeyOnElementsearchElementTagName), required: false);
            var __workflow_browserPressCtrlKeyOnElementsearchElementXPath = WorkflowExpression.Compile(browserPressCtrlKeyOnElementsearchElementXPath, nameof(browserPressCtrlKeyOnElementsearchElementXPath), required: false);
            var __workflow_browserPressCtrlKeyOnElementsearchElementClassName = WorkflowExpression.Compile(browserPressCtrlKeyOnElementsearchElementClassName, nameof(browserPressCtrlKeyOnElementsearchElementClassName), required: false);
            var __workflow_browserPressCtrlKeyOnElementsearchElementCSSSelector = WorkflowExpression.Compile(browserPressCtrlKeyOnElementsearchElementCSSSelector, nameof(browserPressCtrlKeyOnElementsearchElementCSSSelector), required: false);
            var __workflow_browserPressCtrlKeyOnElementsearchElementIndex = WorkflowExpression.Compile(browserPressCtrlKeyOnElementsearchElementIndex, nameof(browserPressCtrlKeyOnElementsearchElementIndex), required: false);
            var __workflow_browserPressCtrlKeyOnElementsearchElementMatchValue = WorkflowExpression.Compile(browserPressCtrlKeyOnElementsearchElementMatchValue, nameof(browserPressCtrlKeyOnElementsearchElementMatchValue), required: false);
            var __workflow_browserPressCtrlKeyOnElementsearchElementMatchText = WorkflowExpression.Compile(browserPressCtrlKeyOnElementsearchElementMatchText, nameof(browserPressCtrlKeyOnElementsearchElementMatchText), required: false);
            var __workflow_browserPressCtrlKeyOnElementsearchElementType = WorkflowExpression.Compile(browserPressCtrlKeyOnElementsearchElementType, nameof(browserPressCtrlKeyOnElementsearchElementType), required: false);
            var __workflow_browserPressCtrlKeyOnElementsearchElementMinimumWidth = WorkflowExpression.Compile(browserPressCtrlKeyOnElementsearchElementMinimumWidth, nameof(browserPressCtrlKeyOnElementsearchElementMinimumWidth), required: false);
            var __workflow_browserPressCtrlKeyOnElementsearchElementMinimumHeight = WorkflowExpression.Compile(browserPressCtrlKeyOnElementsearchElementMinimumHeight, nameof(browserPressCtrlKeyOnElementsearchElementMinimumHeight), required: false);
            var __workflow_browserPressCtrlKeyOnElementsearchElementBoundingBoxLeft = WorkflowExpression.Compile(browserPressCtrlKeyOnElementsearchElementBoundingBoxLeft, nameof(browserPressCtrlKeyOnElementsearchElementBoundingBoxLeft), required: false);
            var __workflow_browserPressCtrlKeyOnElementsearchElementBoundingBoxRight = WorkflowExpression.Compile(browserPressCtrlKeyOnElementsearchElementBoundingBoxRight, nameof(browserPressCtrlKeyOnElementsearchElementBoundingBoxRight), required: false);
            var __workflow_browserPressCtrlKeyOnElementsearchElementBoundingBoxTop = WorkflowExpression.Compile(browserPressCtrlKeyOnElementsearchElementBoundingBoxTop, nameof(browserPressCtrlKeyOnElementsearchElementBoundingBoxTop), required: false);
            var __workflow_browserPressCtrlKeyOnElementsearchElementBoundingBoxBottom = WorkflowExpression.Compile(browserPressCtrlKeyOnElementsearchElementBoundingBoxBottom, nameof(browserPressCtrlKeyOnElementsearchElementBoundingBoxBottom), required: false);
            var __workflow_browserPressCtrlKeyOnElementonlyElementTopLeftNeedsToBeInBoundingBox = WorkflowExpression.Compile(browserPressCtrlKeyOnElementonlyElementTopLeftNeedsToBeInBoundingBox, nameof(browserPressCtrlKeyOnElementonlyElementTopLeftNeedsToBeInBoundingBox), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/BrowserControl/PressCtrlKeyOnElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserPressCtrlKeyOnElement = new JObject();
                var browserPressCtrlKeyOnElementpropCount = 0;
                if (__workflow_browserPressCtrlKeyOnElementparentElementHandle != null)
                {
                    browserPressCtrlKeyOnElement["ParentElementHandle"] = ExpressionConverter.ConvertO(__workflow_browserPressCtrlKeyOnElementparentElementHandle);
                    browserPressCtrlKeyOnElementpropCount++;
                }

                if (__workflow_browserPressCtrlKeyOnElementsearchElementHandle != null)
                {
                    browserPressCtrlKeyOnElement["SearchElementHandle"] = ExpressionConverter.ConvertO(__workflow_browserPressCtrlKeyOnElementsearchElementHandle);
                    browserPressCtrlKeyOnElementpropCount++;
                }

                if (__workflow_browserPressCtrlKeyOnElementsearchElementName != null)
                {
                    browserPressCtrlKeyOnElement["SearchElementName"] = ExpressionConverter.ConvertO(__workflow_browserPressCtrlKeyOnElementsearchElementName);
                    browserPressCtrlKeyOnElementpropCount++;
                }

                if (__workflow_browserPressCtrlKeyOnElementsearchElementID != null)
                {
                    browserPressCtrlKeyOnElement["SearchElementID"] = ExpressionConverter.ConvertO(__workflow_browserPressCtrlKeyOnElementsearchElementID);
                    browserPressCtrlKeyOnElementpropCount++;
                }

                if (__workflow_browserPressCtrlKeyOnElementsearchElementTagName != null)
                {
                    browserPressCtrlKeyOnElement["SearchElementTagName"] = ExpressionConverter.ConvertO(__workflow_browserPressCtrlKeyOnElementsearchElementTagName);
                    browserPressCtrlKeyOnElementpropCount++;
                }

                if (__workflow_browserPressCtrlKeyOnElementsearchElementXPath != null)
                {
                    browserPressCtrlKeyOnElement["SearchElementXPath"] = ExpressionConverter.ConvertO(__workflow_browserPressCtrlKeyOnElementsearchElementXPath);
                    browserPressCtrlKeyOnElementpropCount++;
                }

                if (__workflow_browserPressCtrlKeyOnElementsearchElementClassName != null)
                {
                    browserPressCtrlKeyOnElement["SearchElementClassName"] = ExpressionConverter.ConvertO(__workflow_browserPressCtrlKeyOnElementsearchElementClassName);
                    browserPressCtrlKeyOnElementpropCount++;
                }

                if (__workflow_browserPressCtrlKeyOnElementsearchElementCSSSelector != null)
                {
                    browserPressCtrlKeyOnElement["SearchElementCSSSelector"] = ExpressionConverter.ConvertO(__workflow_browserPressCtrlKeyOnElementsearchElementCSSSelector);
                    browserPressCtrlKeyOnElementpropCount++;
                }

                if (__workflow_browserPressCtrlKeyOnElementsearchElementIndex != null)
                {
                    if (__workflow_browserPressCtrlKeyOnElementsearchElementIndex != null)
                    {
                        browserPressCtrlKeyOnElement["SearchElementIndex"] = ExpressionConverter.ConvertO(__workflow_browserPressCtrlKeyOnElementsearchElementIndex);
                        browserPressCtrlKeyOnElementpropCount++;
                    }

                    browserPressCtrlKeyOnElementpropCount++;
                }
                else
                {
                    browserPressCtrlKeyOnElement["SearchElementIndex"] = 1;
                    browserPressCtrlKeyOnElementpropCount++;
                }

                if (__workflow_browserPressCtrlKeyOnElementsearchElementMatchValue != null)
                {
                    browserPressCtrlKeyOnElement["SearchElementMatchValue"] = ExpressionConverter.ConvertO(__workflow_browserPressCtrlKeyOnElementsearchElementMatchValue);
                    browserPressCtrlKeyOnElementpropCount++;
                }

                if (__workflow_browserPressCtrlKeyOnElementsearchElementMatchText != null)
                {
                    browserPressCtrlKeyOnElement["SearchElementMatchText"] = ExpressionConverter.ConvertO(__workflow_browserPressCtrlKeyOnElementsearchElementMatchText);
                    browserPressCtrlKeyOnElementpropCount++;
                }

                if (__workflow_browserPressCtrlKeyOnElementsearchElementType != null)
                {
                    browserPressCtrlKeyOnElement["SearchElementType"] = ExpressionConverter.ConvertO(__workflow_browserPressCtrlKeyOnElementsearchElementType);
                    browserPressCtrlKeyOnElementpropCount++;
                }

                if (__workflow_browserPressCtrlKeyOnElementsearchElementMinimumWidth != null)
                {
                    if (__workflow_browserPressCtrlKeyOnElementsearchElementMinimumWidth != null)
                    {
                        browserPressCtrlKeyOnElement["SearchElementMinimumWidth"] = ExpressionConverter.ConvertO(__workflow_browserPressCtrlKeyOnElementsearchElementMinimumWidth);
                        browserPressCtrlKeyOnElementpropCount++;
                    }

                    browserPressCtrlKeyOnElementpropCount++;
                }
                else
                {
                    browserPressCtrlKeyOnElement["SearchElementMinimumWidth"] = 1;
                    browserPressCtrlKeyOnElementpropCount++;
                }

                if (__workflow_browserPressCtrlKeyOnElementsearchElementMinimumHeight != null)
                {
                    if (__workflow_browserPressCtrlKeyOnElementsearchElementMinimumHeight != null)
                    {
                        browserPressCtrlKeyOnElement["SearchElementMinimumHeight"] = ExpressionConverter.ConvertO(__workflow_browserPressCtrlKeyOnElementsearchElementMinimumHeight);
                        browserPressCtrlKeyOnElementpropCount++;
                    }

                    browserPressCtrlKeyOnElementpropCount++;
                }
                else
                {
                    browserPressCtrlKeyOnElement["SearchElementMinimumHeight"] = 1;
                    browserPressCtrlKeyOnElementpropCount++;
                }

                if (__workflow_browserPressCtrlKeyOnElementsearchElementBoundingBoxLeft != null)
                {
                    if (__workflow_browserPressCtrlKeyOnElementsearchElementBoundingBoxLeft != null)
                    {
                        browserPressCtrlKeyOnElement["SearchElementBoundingBoxLeft"] = ExpressionConverter.ConvertO(__workflow_browserPressCtrlKeyOnElementsearchElementBoundingBoxLeft);
                        browserPressCtrlKeyOnElementpropCount++;
                    }

                    browserPressCtrlKeyOnElementpropCount++;
                }
                else
                {
                    browserPressCtrlKeyOnElement["SearchElementBoundingBoxLeft"] = -99999;
                    browserPressCtrlKeyOnElementpropCount++;
                }

                if (__workflow_browserPressCtrlKeyOnElementsearchElementBoundingBoxRight != null)
                {
                    if (__workflow_browserPressCtrlKeyOnElementsearchElementBoundingBoxRight != null)
                    {
                        browserPressCtrlKeyOnElement["SearchElementBoundingBoxRight"] = ExpressionConverter.ConvertO(__workflow_browserPressCtrlKeyOnElementsearchElementBoundingBoxRight);
                        browserPressCtrlKeyOnElementpropCount++;
                    }

                    browserPressCtrlKeyOnElementpropCount++;
                }
                else
                {
                    browserPressCtrlKeyOnElement["SearchElementBoundingBoxRight"] = 99999;
                    browserPressCtrlKeyOnElementpropCount++;
                }

                if (__workflow_browserPressCtrlKeyOnElementsearchElementBoundingBoxTop != null)
                {
                    if (__workflow_browserPressCtrlKeyOnElementsearchElementBoundingBoxTop != null)
                    {
                        browserPressCtrlKeyOnElement["SearchElementBoundingBoxTop"] = ExpressionConverter.ConvertO(__workflow_browserPressCtrlKeyOnElementsearchElementBoundingBoxTop);
                        browserPressCtrlKeyOnElementpropCount++;
                    }

                    browserPressCtrlKeyOnElementpropCount++;
                }
                else
                {
                    browserPressCtrlKeyOnElement["SearchElementBoundingBoxTop"] = -99999;
                    browserPressCtrlKeyOnElementpropCount++;
                }

                if (__workflow_browserPressCtrlKeyOnElementsearchElementBoundingBoxBottom != null)
                {
                    if (__workflow_browserPressCtrlKeyOnElementsearchElementBoundingBoxBottom != null)
                    {
                        browserPressCtrlKeyOnElement["SearchElementBoundingBoxBottom"] = ExpressionConverter.ConvertO(__workflow_browserPressCtrlKeyOnElementsearchElementBoundingBoxBottom);
                        browserPressCtrlKeyOnElementpropCount++;
                    }

                    browserPressCtrlKeyOnElementpropCount++;
                }
                else
                {
                    browserPressCtrlKeyOnElement["SearchElementBoundingBoxBottom"] = 99999;
                    browserPressCtrlKeyOnElementpropCount++;
                }

                if (__workflow_browserPressCtrlKeyOnElementonlyElementTopLeftNeedsToBeInBoundingBox != null)
                {
                    if (__workflow_browserPressCtrlKeyOnElementonlyElementTopLeftNeedsToBeInBoundingBox != null)
                    {
                        browserPressCtrlKeyOnElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = ExpressionConverter.ConvertO(__workflow_browserPressCtrlKeyOnElementonlyElementTopLeftNeedsToBeInBoundingBox);
                        browserPressCtrlKeyOnElementpropCount++;
                    }

                    browserPressCtrlKeyOnElementpropCount++;
                }
                else
                {
                    browserPressCtrlKeyOnElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = false;
                    browserPressCtrlKeyOnElementpropCount++;
                }

                browserPressCtrlKeyOnElementpropCount++;
                browserPressCtrlKeyOnElement["ControlKey"] = ExpressionConverter.ConvertO(__workflow_browserPressCtrlKeyOnElementcontrolKey);
                browserPressCtrlKeyOnElementpropCount++;
                browserPressCtrlKeyOnElement["Workflow"] = ExpressionConverter.ConvertO(__workflow_browserPressCtrlKeyOnElementworkflow);
                if (browserPressCtrlKeyOnElementpropCount > 0)
                {
                    callPayload.Body = browserPressCtrlKeyOnElement;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserClickElement(Expression<Func<string>> browserClickElementworkflow, Expression<Func<double>> browserClickElementparentElementHandle = null, Expression<Func<double>> browserClickElementsearchElementHandle = null, Expression<Func<string>> browserClickElementsearchElementName = null, Expression<Func<string>> browserClickElementsearchElementID = null, Expression<Func<string>> browserClickElementsearchElementTagName = null, Expression<Func<string>> browserClickElementsearchElementXPath = null, Expression<Func<string>> browserClickElementsearchElementClassName = null, Expression<Func<string>> browserClickElementsearchElementCSSSelector = null, Expression<Func<double>> browserClickElementsearchElementIndex = null, Expression<Func<string>> browserClickElementsearchElementMatchValue = null, Expression<Func<string>> browserClickElementsearchElementMatchText = null, Expression<Func<string>> browserClickElementsearchElementType = null, Expression<Func<double>> browserClickElementsearchElementMinimumWidth = null, Expression<Func<double>> browserClickElementsearchElementMinimumHeight = null, Expression<Func<double>> browserClickElementsearchElementBoundingBoxLeft = null, Expression<Func<double>> browserClickElementsearchElementBoundingBoxRight = null, Expression<Func<double>> browserClickElementsearchElementBoundingBoxTop = null, Expression<Func<double>> browserClickElementsearchElementBoundingBoxBottom = null, Expression<Func<bool>> browserClickElementonlyElementTopLeftNeedsToBeInBoundingBox = null)
        {
            var __workflow_browserClickElementworkflow = WorkflowExpression.Compile(browserClickElementworkflow, nameof(browserClickElementworkflow), required: true);
            var __workflow_browserClickElementparentElementHandle = WorkflowExpression.Compile(browserClickElementparentElementHandle, nameof(browserClickElementparentElementHandle), required: false);
            var __workflow_browserClickElementsearchElementHandle = WorkflowExpression.Compile(browserClickElementsearchElementHandle, nameof(browserClickElementsearchElementHandle), required: false);
            var __workflow_browserClickElementsearchElementName = WorkflowExpression.Compile(browserClickElementsearchElementName, nameof(browserClickElementsearchElementName), required: false);
            var __workflow_browserClickElementsearchElementID = WorkflowExpression.Compile(browserClickElementsearchElementID, nameof(browserClickElementsearchElementID), required: false);
            var __workflow_browserClickElementsearchElementTagName = WorkflowExpression.Compile(browserClickElementsearchElementTagName, nameof(browserClickElementsearchElementTagName), required: false);
            var __workflow_browserClickElementsearchElementXPath = WorkflowExpression.Compile(browserClickElementsearchElementXPath, nameof(browserClickElementsearchElementXPath), required: false);
            var __workflow_browserClickElementsearchElementClassName = WorkflowExpression.Compile(browserClickElementsearchElementClassName, nameof(browserClickElementsearchElementClassName), required: false);
            var __workflow_browserClickElementsearchElementCSSSelector = WorkflowExpression.Compile(browserClickElementsearchElementCSSSelector, nameof(browserClickElementsearchElementCSSSelector), required: false);
            var __workflow_browserClickElementsearchElementIndex = WorkflowExpression.Compile(browserClickElementsearchElementIndex, nameof(browserClickElementsearchElementIndex), required: false);
            var __workflow_browserClickElementsearchElementMatchValue = WorkflowExpression.Compile(browserClickElementsearchElementMatchValue, nameof(browserClickElementsearchElementMatchValue), required: false);
            var __workflow_browserClickElementsearchElementMatchText = WorkflowExpression.Compile(browserClickElementsearchElementMatchText, nameof(browserClickElementsearchElementMatchText), required: false);
            var __workflow_browserClickElementsearchElementType = WorkflowExpression.Compile(browserClickElementsearchElementType, nameof(browserClickElementsearchElementType), required: false);
            var __workflow_browserClickElementsearchElementMinimumWidth = WorkflowExpression.Compile(browserClickElementsearchElementMinimumWidth, nameof(browserClickElementsearchElementMinimumWidth), required: false);
            var __workflow_browserClickElementsearchElementMinimumHeight = WorkflowExpression.Compile(browserClickElementsearchElementMinimumHeight, nameof(browserClickElementsearchElementMinimumHeight), required: false);
            var __workflow_browserClickElementsearchElementBoundingBoxLeft = WorkflowExpression.Compile(browserClickElementsearchElementBoundingBoxLeft, nameof(browserClickElementsearchElementBoundingBoxLeft), required: false);
            var __workflow_browserClickElementsearchElementBoundingBoxRight = WorkflowExpression.Compile(browserClickElementsearchElementBoundingBoxRight, nameof(browserClickElementsearchElementBoundingBoxRight), required: false);
            var __workflow_browserClickElementsearchElementBoundingBoxTop = WorkflowExpression.Compile(browserClickElementsearchElementBoundingBoxTop, nameof(browserClickElementsearchElementBoundingBoxTop), required: false);
            var __workflow_browserClickElementsearchElementBoundingBoxBottom = WorkflowExpression.Compile(browserClickElementsearchElementBoundingBoxBottom, nameof(browserClickElementsearchElementBoundingBoxBottom), required: false);
            var __workflow_browserClickElementonlyElementTopLeftNeedsToBeInBoundingBox = WorkflowExpression.Compile(browserClickElementonlyElementTopLeftNeedsToBeInBoundingBox, nameof(browserClickElementonlyElementTopLeftNeedsToBeInBoundingBox), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/BrowserControl/ClickElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserClickElement = new JObject();
                var browserClickElementpropCount = 0;
                if (__workflow_browserClickElementparentElementHandle != null)
                {
                    browserClickElement["ParentElementHandle"] = ExpressionConverter.ConvertO(__workflow_browserClickElementparentElementHandle);
                    browserClickElementpropCount++;
                }

                if (__workflow_browserClickElementsearchElementHandle != null)
                {
                    browserClickElement["SearchElementHandle"] = ExpressionConverter.ConvertO(__workflow_browserClickElementsearchElementHandle);
                    browserClickElementpropCount++;
                }

                if (__workflow_browserClickElementsearchElementName != null)
                {
                    browserClickElement["SearchElementName"] = ExpressionConverter.ConvertO(__workflow_browserClickElementsearchElementName);
                    browserClickElementpropCount++;
                }

                if (__workflow_browserClickElementsearchElementID != null)
                {
                    browserClickElement["SearchElementID"] = ExpressionConverter.ConvertO(__workflow_browserClickElementsearchElementID);
                    browserClickElementpropCount++;
                }

                if (__workflow_browserClickElementsearchElementTagName != null)
                {
                    browserClickElement["SearchElementTagName"] = ExpressionConverter.ConvertO(__workflow_browserClickElementsearchElementTagName);
                    browserClickElementpropCount++;
                }

                if (__workflow_browserClickElementsearchElementXPath != null)
                {
                    browserClickElement["SearchElementXPath"] = ExpressionConverter.ConvertO(__workflow_browserClickElementsearchElementXPath);
                    browserClickElementpropCount++;
                }

                if (__workflow_browserClickElementsearchElementClassName != null)
                {
                    browserClickElement["SearchElementClassName"] = ExpressionConverter.ConvertO(__workflow_browserClickElementsearchElementClassName);
                    browserClickElementpropCount++;
                }

                if (__workflow_browserClickElementsearchElementCSSSelector != null)
                {
                    browserClickElement["SearchElementCSSSelector"] = ExpressionConverter.ConvertO(__workflow_browserClickElementsearchElementCSSSelector);
                    browserClickElementpropCount++;
                }

                if (__workflow_browserClickElementsearchElementIndex != null)
                {
                    if (__workflow_browserClickElementsearchElementIndex != null)
                    {
                        browserClickElement["SearchElementIndex"] = ExpressionConverter.ConvertO(__workflow_browserClickElementsearchElementIndex);
                        browserClickElementpropCount++;
                    }

                    browserClickElementpropCount++;
                }
                else
                {
                    browserClickElement["SearchElementIndex"] = 1;
                    browserClickElementpropCount++;
                }

                if (__workflow_browserClickElementsearchElementMatchValue != null)
                {
                    browserClickElement["SearchElementMatchValue"] = ExpressionConverter.ConvertO(__workflow_browserClickElementsearchElementMatchValue);
                    browserClickElementpropCount++;
                }

                if (__workflow_browserClickElementsearchElementMatchText != null)
                {
                    browserClickElement["SearchElementMatchText"] = ExpressionConverter.ConvertO(__workflow_browserClickElementsearchElementMatchText);
                    browserClickElementpropCount++;
                }

                if (__workflow_browserClickElementsearchElementType != null)
                {
                    browserClickElement["SearchElementType"] = ExpressionConverter.ConvertO(__workflow_browserClickElementsearchElementType);
                    browserClickElementpropCount++;
                }

                if (__workflow_browserClickElementsearchElementMinimumWidth != null)
                {
                    if (__workflow_browserClickElementsearchElementMinimumWidth != null)
                    {
                        browserClickElement["SearchElementMinimumWidth"] = ExpressionConverter.ConvertO(__workflow_browserClickElementsearchElementMinimumWidth);
                        browserClickElementpropCount++;
                    }

                    browserClickElementpropCount++;
                }
                else
                {
                    browserClickElement["SearchElementMinimumWidth"] = 1;
                    browserClickElementpropCount++;
                }

                if (__workflow_browserClickElementsearchElementMinimumHeight != null)
                {
                    if (__workflow_browserClickElementsearchElementMinimumHeight != null)
                    {
                        browserClickElement["SearchElementMinimumHeight"] = ExpressionConverter.ConvertO(__workflow_browserClickElementsearchElementMinimumHeight);
                        browserClickElementpropCount++;
                    }

                    browserClickElementpropCount++;
                }
                else
                {
                    browserClickElement["SearchElementMinimumHeight"] = 1;
                    browserClickElementpropCount++;
                }

                if (__workflow_browserClickElementsearchElementBoundingBoxLeft != null)
                {
                    if (__workflow_browserClickElementsearchElementBoundingBoxLeft != null)
                    {
                        browserClickElement["SearchElementBoundingBoxLeft"] = ExpressionConverter.ConvertO(__workflow_browserClickElementsearchElementBoundingBoxLeft);
                        browserClickElementpropCount++;
                    }

                    browserClickElementpropCount++;
                }
                else
                {
                    browserClickElement["SearchElementBoundingBoxLeft"] = -99999;
                    browserClickElementpropCount++;
                }

                if (__workflow_browserClickElementsearchElementBoundingBoxRight != null)
                {
                    if (__workflow_browserClickElementsearchElementBoundingBoxRight != null)
                    {
                        browserClickElement["SearchElementBoundingBoxRight"] = ExpressionConverter.ConvertO(__workflow_browserClickElementsearchElementBoundingBoxRight);
                        browserClickElementpropCount++;
                    }

                    browserClickElementpropCount++;
                }
                else
                {
                    browserClickElement["SearchElementBoundingBoxRight"] = 99999;
                    browserClickElementpropCount++;
                }

                if (__workflow_browserClickElementsearchElementBoundingBoxTop != null)
                {
                    if (__workflow_browserClickElementsearchElementBoundingBoxTop != null)
                    {
                        browserClickElement["SearchElementBoundingBoxTop"] = ExpressionConverter.ConvertO(__workflow_browserClickElementsearchElementBoundingBoxTop);
                        browserClickElementpropCount++;
                    }

                    browserClickElementpropCount++;
                }
                else
                {
                    browserClickElement["SearchElementBoundingBoxTop"] = -99999;
                    browserClickElementpropCount++;
                }

                if (__workflow_browserClickElementsearchElementBoundingBoxBottom != null)
                {
                    if (__workflow_browserClickElementsearchElementBoundingBoxBottom != null)
                    {
                        browserClickElement["SearchElementBoundingBoxBottom"] = ExpressionConverter.ConvertO(__workflow_browserClickElementsearchElementBoundingBoxBottom);
                        browserClickElementpropCount++;
                    }

                    browserClickElementpropCount++;
                }
                else
                {
                    browserClickElement["SearchElementBoundingBoxBottom"] = 99999;
                    browserClickElementpropCount++;
                }

                if (__workflow_browserClickElementonlyElementTopLeftNeedsToBeInBoundingBox != null)
                {
                    if (__workflow_browserClickElementonlyElementTopLeftNeedsToBeInBoundingBox != null)
                    {
                        browserClickElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = ExpressionConverter.ConvertO(__workflow_browserClickElementonlyElementTopLeftNeedsToBeInBoundingBox);
                        browserClickElementpropCount++;
                    }

                    browserClickElementpropCount++;
                }
                else
                {
                    browserClickElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = false;
                    browserClickElementpropCount++;
                }

                browserClickElementpropCount++;
                browserClickElement["Workflow"] = ExpressionConverter.ConvertO(__workflow_browserClickElementworkflow);
                if (browserClickElementpropCount > 0)
                {
                    callPayload.Body = browserClickElement;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserSubmitElement(Expression<Func<string>> browserSubmitElementworkflow, Expression<Func<double>> browserSubmitElementparentElementHandle = null, Expression<Func<double>> browserSubmitElementsearchElementHandle = null, Expression<Func<string>> browserSubmitElementsearchElementName = null, Expression<Func<string>> browserSubmitElementsearchElementID = null, Expression<Func<string>> browserSubmitElementsearchElementTagName = null, Expression<Func<string>> browserSubmitElementsearchElementXPath = null, Expression<Func<string>> browserSubmitElementsearchElementClassName = null, Expression<Func<string>> browserSubmitElementsearchElementCSSSelector = null, Expression<Func<double>> browserSubmitElementsearchElementIndex = null, Expression<Func<string>> browserSubmitElementsearchElementMatchValue = null, Expression<Func<string>> browserSubmitElementsearchElementMatchText = null, Expression<Func<string>> browserSubmitElementsearchElementType = null, Expression<Func<double>> browserSubmitElementsearchElementMinimumWidth = null, Expression<Func<double>> browserSubmitElementsearchElementMinimumHeight = null, Expression<Func<double>> browserSubmitElementsearchElementBoundingBoxLeft = null, Expression<Func<double>> browserSubmitElementsearchElementBoundingBoxRight = null, Expression<Func<double>> browserSubmitElementsearchElementBoundingBoxTop = null, Expression<Func<double>> browserSubmitElementsearchElementBoundingBoxBottom = null, Expression<Func<bool>> browserSubmitElementonlyElementTopLeftNeedsToBeInBoundingBox = null)
        {
            var __workflow_browserSubmitElementworkflow = WorkflowExpression.Compile(browserSubmitElementworkflow, nameof(browserSubmitElementworkflow), required: true);
            var __workflow_browserSubmitElementparentElementHandle = WorkflowExpression.Compile(browserSubmitElementparentElementHandle, nameof(browserSubmitElementparentElementHandle), required: false);
            var __workflow_browserSubmitElementsearchElementHandle = WorkflowExpression.Compile(browserSubmitElementsearchElementHandle, nameof(browserSubmitElementsearchElementHandle), required: false);
            var __workflow_browserSubmitElementsearchElementName = WorkflowExpression.Compile(browserSubmitElementsearchElementName, nameof(browserSubmitElementsearchElementName), required: false);
            var __workflow_browserSubmitElementsearchElementID = WorkflowExpression.Compile(browserSubmitElementsearchElementID, nameof(browserSubmitElementsearchElementID), required: false);
            var __workflow_browserSubmitElementsearchElementTagName = WorkflowExpression.Compile(browserSubmitElementsearchElementTagName, nameof(browserSubmitElementsearchElementTagName), required: false);
            var __workflow_browserSubmitElementsearchElementXPath = WorkflowExpression.Compile(browserSubmitElementsearchElementXPath, nameof(browserSubmitElementsearchElementXPath), required: false);
            var __workflow_browserSubmitElementsearchElementClassName = WorkflowExpression.Compile(browserSubmitElementsearchElementClassName, nameof(browserSubmitElementsearchElementClassName), required: false);
            var __workflow_browserSubmitElementsearchElementCSSSelector = WorkflowExpression.Compile(browserSubmitElementsearchElementCSSSelector, nameof(browserSubmitElementsearchElementCSSSelector), required: false);
            var __workflow_browserSubmitElementsearchElementIndex = WorkflowExpression.Compile(browserSubmitElementsearchElementIndex, nameof(browserSubmitElementsearchElementIndex), required: false);
            var __workflow_browserSubmitElementsearchElementMatchValue = WorkflowExpression.Compile(browserSubmitElementsearchElementMatchValue, nameof(browserSubmitElementsearchElementMatchValue), required: false);
            var __workflow_browserSubmitElementsearchElementMatchText = WorkflowExpression.Compile(browserSubmitElementsearchElementMatchText, nameof(browserSubmitElementsearchElementMatchText), required: false);
            var __workflow_browserSubmitElementsearchElementType = WorkflowExpression.Compile(browserSubmitElementsearchElementType, nameof(browserSubmitElementsearchElementType), required: false);
            var __workflow_browserSubmitElementsearchElementMinimumWidth = WorkflowExpression.Compile(browserSubmitElementsearchElementMinimumWidth, nameof(browserSubmitElementsearchElementMinimumWidth), required: false);
            var __workflow_browserSubmitElementsearchElementMinimumHeight = WorkflowExpression.Compile(browserSubmitElementsearchElementMinimumHeight, nameof(browserSubmitElementsearchElementMinimumHeight), required: false);
            var __workflow_browserSubmitElementsearchElementBoundingBoxLeft = WorkflowExpression.Compile(browserSubmitElementsearchElementBoundingBoxLeft, nameof(browserSubmitElementsearchElementBoundingBoxLeft), required: false);
            var __workflow_browserSubmitElementsearchElementBoundingBoxRight = WorkflowExpression.Compile(browserSubmitElementsearchElementBoundingBoxRight, nameof(browserSubmitElementsearchElementBoundingBoxRight), required: false);
            var __workflow_browserSubmitElementsearchElementBoundingBoxTop = WorkflowExpression.Compile(browserSubmitElementsearchElementBoundingBoxTop, nameof(browserSubmitElementsearchElementBoundingBoxTop), required: false);
            var __workflow_browserSubmitElementsearchElementBoundingBoxBottom = WorkflowExpression.Compile(browserSubmitElementsearchElementBoundingBoxBottom, nameof(browserSubmitElementsearchElementBoundingBoxBottom), required: false);
            var __workflow_browserSubmitElementonlyElementTopLeftNeedsToBeInBoundingBox = WorkflowExpression.Compile(browserSubmitElementonlyElementTopLeftNeedsToBeInBoundingBox, nameof(browserSubmitElementonlyElementTopLeftNeedsToBeInBoundingBox), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/BrowserControl/SubmitElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserSubmitElement = new JObject();
                var browserSubmitElementpropCount = 0;
                if (__workflow_browserSubmitElementparentElementHandle != null)
                {
                    browserSubmitElement["ParentElementHandle"] = ExpressionConverter.ConvertO(__workflow_browserSubmitElementparentElementHandle);
                    browserSubmitElementpropCount++;
                }

                if (__workflow_browserSubmitElementsearchElementHandle != null)
                {
                    browserSubmitElement["SearchElementHandle"] = ExpressionConverter.ConvertO(__workflow_browserSubmitElementsearchElementHandle);
                    browserSubmitElementpropCount++;
                }

                if (__workflow_browserSubmitElementsearchElementName != null)
                {
                    browserSubmitElement["SearchElementName"] = ExpressionConverter.ConvertO(__workflow_browserSubmitElementsearchElementName);
                    browserSubmitElementpropCount++;
                }

                if (__workflow_browserSubmitElementsearchElementID != null)
                {
                    browserSubmitElement["SearchElementID"] = ExpressionConverter.ConvertO(__workflow_browserSubmitElementsearchElementID);
                    browserSubmitElementpropCount++;
                }

                if (__workflow_browserSubmitElementsearchElementTagName != null)
                {
                    browserSubmitElement["SearchElementTagName"] = ExpressionConverter.ConvertO(__workflow_browserSubmitElementsearchElementTagName);
                    browserSubmitElementpropCount++;
                }

                if (__workflow_browserSubmitElementsearchElementXPath != null)
                {
                    browserSubmitElement["SearchElementXPath"] = ExpressionConverter.ConvertO(__workflow_browserSubmitElementsearchElementXPath);
                    browserSubmitElementpropCount++;
                }

                if (__workflow_browserSubmitElementsearchElementClassName != null)
                {
                    browserSubmitElement["SearchElementClassName"] = ExpressionConverter.ConvertO(__workflow_browserSubmitElementsearchElementClassName);
                    browserSubmitElementpropCount++;
                }

                if (__workflow_browserSubmitElementsearchElementCSSSelector != null)
                {
                    browserSubmitElement["SearchElementCSSSelector"] = ExpressionConverter.ConvertO(__workflow_browserSubmitElementsearchElementCSSSelector);
                    browserSubmitElementpropCount++;
                }

                if (__workflow_browserSubmitElementsearchElementIndex != null)
                {
                    if (__workflow_browserSubmitElementsearchElementIndex != null)
                    {
                        browserSubmitElement["SearchElementIndex"] = ExpressionConverter.ConvertO(__workflow_browserSubmitElementsearchElementIndex);
                        browserSubmitElementpropCount++;
                    }

                    browserSubmitElementpropCount++;
                }
                else
                {
                    browserSubmitElement["SearchElementIndex"] = 1;
                    browserSubmitElementpropCount++;
                }

                if (__workflow_browserSubmitElementsearchElementMatchValue != null)
                {
                    browserSubmitElement["SearchElementMatchValue"] = ExpressionConverter.ConvertO(__workflow_browserSubmitElementsearchElementMatchValue);
                    browserSubmitElementpropCount++;
                }

                if (__workflow_browserSubmitElementsearchElementMatchText != null)
                {
                    browserSubmitElement["SearchElementMatchText"] = ExpressionConverter.ConvertO(__workflow_browserSubmitElementsearchElementMatchText);
                    browserSubmitElementpropCount++;
                }

                if (__workflow_browserSubmitElementsearchElementType != null)
                {
                    browserSubmitElement["SearchElementType"] = ExpressionConverter.ConvertO(__workflow_browserSubmitElementsearchElementType);
                    browserSubmitElementpropCount++;
                }

                if (__workflow_browserSubmitElementsearchElementMinimumWidth != null)
                {
                    if (__workflow_browserSubmitElementsearchElementMinimumWidth != null)
                    {
                        browserSubmitElement["SearchElementMinimumWidth"] = ExpressionConverter.ConvertO(__workflow_browserSubmitElementsearchElementMinimumWidth);
                        browserSubmitElementpropCount++;
                    }

                    browserSubmitElementpropCount++;
                }
                else
                {
                    browserSubmitElement["SearchElementMinimumWidth"] = 1;
                    browserSubmitElementpropCount++;
                }

                if (__workflow_browserSubmitElementsearchElementMinimumHeight != null)
                {
                    if (__workflow_browserSubmitElementsearchElementMinimumHeight != null)
                    {
                        browserSubmitElement["SearchElementMinimumHeight"] = ExpressionConverter.ConvertO(__workflow_browserSubmitElementsearchElementMinimumHeight);
                        browserSubmitElementpropCount++;
                    }

                    browserSubmitElementpropCount++;
                }
                else
                {
                    browserSubmitElement["SearchElementMinimumHeight"] = 1;
                    browserSubmitElementpropCount++;
                }

                if (__workflow_browserSubmitElementsearchElementBoundingBoxLeft != null)
                {
                    if (__workflow_browserSubmitElementsearchElementBoundingBoxLeft != null)
                    {
                        browserSubmitElement["SearchElementBoundingBoxLeft"] = ExpressionConverter.ConvertO(__workflow_browserSubmitElementsearchElementBoundingBoxLeft);
                        browserSubmitElementpropCount++;
                    }

                    browserSubmitElementpropCount++;
                }
                else
                {
                    browserSubmitElement["SearchElementBoundingBoxLeft"] = -99999;
                    browserSubmitElementpropCount++;
                }

                if (__workflow_browserSubmitElementsearchElementBoundingBoxRight != null)
                {
                    if (__workflow_browserSubmitElementsearchElementBoundingBoxRight != null)
                    {
                        browserSubmitElement["SearchElementBoundingBoxRight"] = ExpressionConverter.ConvertO(__workflow_browserSubmitElementsearchElementBoundingBoxRight);
                        browserSubmitElementpropCount++;
                    }

                    browserSubmitElementpropCount++;
                }
                else
                {
                    browserSubmitElement["SearchElementBoundingBoxRight"] = 99999;
                    browserSubmitElementpropCount++;
                }

                if (__workflow_browserSubmitElementsearchElementBoundingBoxTop != null)
                {
                    if (__workflow_browserSubmitElementsearchElementBoundingBoxTop != null)
                    {
                        browserSubmitElement["SearchElementBoundingBoxTop"] = ExpressionConverter.ConvertO(__workflow_browserSubmitElementsearchElementBoundingBoxTop);
                        browserSubmitElementpropCount++;
                    }

                    browserSubmitElementpropCount++;
                }
                else
                {
                    browserSubmitElement["SearchElementBoundingBoxTop"] = -99999;
                    browserSubmitElementpropCount++;
                }

                if (__workflow_browserSubmitElementsearchElementBoundingBoxBottom != null)
                {
                    if (__workflow_browserSubmitElementsearchElementBoundingBoxBottom != null)
                    {
                        browserSubmitElement["SearchElementBoundingBoxBottom"] = ExpressionConverter.ConvertO(__workflow_browserSubmitElementsearchElementBoundingBoxBottom);
                        browserSubmitElementpropCount++;
                    }

                    browserSubmitElementpropCount++;
                }
                else
                {
                    browserSubmitElement["SearchElementBoundingBoxBottom"] = 99999;
                    browserSubmitElementpropCount++;
                }

                if (__workflow_browserSubmitElementonlyElementTopLeftNeedsToBeInBoundingBox != null)
                {
                    if (__workflow_browserSubmitElementonlyElementTopLeftNeedsToBeInBoundingBox != null)
                    {
                        browserSubmitElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = ExpressionConverter.ConvertO(__workflow_browserSubmitElementonlyElementTopLeftNeedsToBeInBoundingBox);
                        browserSubmitElementpropCount++;
                    }

                    browserSubmitElementpropCount++;
                }
                else
                {
                    browserSubmitElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = false;
                    browserSubmitElementpropCount++;
                }

                browserSubmitElementpropCount++;
                browserSubmitElement["Workflow"] = ExpressionConverter.ConvertO(__workflow_browserSubmitElementworkflow);
                if (browserSubmitElementpropCount > 0)
                {
                    callPayload.Body = browserSubmitElement;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserCheckElement(Expression<Func<string>> browserCheckElementworkflow, Expression<Func<double>> browserCheckElementparentElementHandle = null, Expression<Func<double>> browserCheckElementsearchElementHandle = null, Expression<Func<string>> browserCheckElementsearchElementName = null, Expression<Func<string>> browserCheckElementsearchElementID = null, Expression<Func<string>> browserCheckElementsearchElementTagName = null, Expression<Func<string>> browserCheckElementsearchElementXPath = null, Expression<Func<string>> browserCheckElementsearchElementClassName = null, Expression<Func<string>> browserCheckElementsearchElementCSSSelector = null, Expression<Func<double>> browserCheckElementsearchElementIndex = null, Expression<Func<string>> browserCheckElementsearchElementMatchValue = null, Expression<Func<string>> browserCheckElementsearchElementMatchText = null, Expression<Func<string>> browserCheckElementsearchElementType = null, Expression<Func<double>> browserCheckElementsearchElementMinimumWidth = null, Expression<Func<double>> browserCheckElementsearchElementMinimumHeight = null, Expression<Func<double>> browserCheckElementsearchElementBoundingBoxLeft = null, Expression<Func<double>> browserCheckElementsearchElementBoundingBoxRight = null, Expression<Func<double>> browserCheckElementsearchElementBoundingBoxTop = null, Expression<Func<double>> browserCheckElementsearchElementBoundingBoxBottom = null, Expression<Func<bool>> browserCheckElementonlyElementTopLeftNeedsToBeInBoundingBox = null, Expression<Func<bool>> browserCheckElementcheckElement = null)
        {
            var __workflow_browserCheckElementworkflow = WorkflowExpression.Compile(browserCheckElementworkflow, nameof(browserCheckElementworkflow), required: true);
            var __workflow_browserCheckElementparentElementHandle = WorkflowExpression.Compile(browserCheckElementparentElementHandle, nameof(browserCheckElementparentElementHandle), required: false);
            var __workflow_browserCheckElementsearchElementHandle = WorkflowExpression.Compile(browserCheckElementsearchElementHandle, nameof(browserCheckElementsearchElementHandle), required: false);
            var __workflow_browserCheckElementsearchElementName = WorkflowExpression.Compile(browserCheckElementsearchElementName, nameof(browserCheckElementsearchElementName), required: false);
            var __workflow_browserCheckElementsearchElementID = WorkflowExpression.Compile(browserCheckElementsearchElementID, nameof(browserCheckElementsearchElementID), required: false);
            var __workflow_browserCheckElementsearchElementTagName = WorkflowExpression.Compile(browserCheckElementsearchElementTagName, nameof(browserCheckElementsearchElementTagName), required: false);
            var __workflow_browserCheckElementsearchElementXPath = WorkflowExpression.Compile(browserCheckElementsearchElementXPath, nameof(browserCheckElementsearchElementXPath), required: false);
            var __workflow_browserCheckElementsearchElementClassName = WorkflowExpression.Compile(browserCheckElementsearchElementClassName, nameof(browserCheckElementsearchElementClassName), required: false);
            var __workflow_browserCheckElementsearchElementCSSSelector = WorkflowExpression.Compile(browserCheckElementsearchElementCSSSelector, nameof(browserCheckElementsearchElementCSSSelector), required: false);
            var __workflow_browserCheckElementsearchElementIndex = WorkflowExpression.Compile(browserCheckElementsearchElementIndex, nameof(browserCheckElementsearchElementIndex), required: false);
            var __workflow_browserCheckElementsearchElementMatchValue = WorkflowExpression.Compile(browserCheckElementsearchElementMatchValue, nameof(browserCheckElementsearchElementMatchValue), required: false);
            var __workflow_browserCheckElementsearchElementMatchText = WorkflowExpression.Compile(browserCheckElementsearchElementMatchText, nameof(browserCheckElementsearchElementMatchText), required: false);
            var __workflow_browserCheckElementsearchElementType = WorkflowExpression.Compile(browserCheckElementsearchElementType, nameof(browserCheckElementsearchElementType), required: false);
            var __workflow_browserCheckElementsearchElementMinimumWidth = WorkflowExpression.Compile(browserCheckElementsearchElementMinimumWidth, nameof(browserCheckElementsearchElementMinimumWidth), required: false);
            var __workflow_browserCheckElementsearchElementMinimumHeight = WorkflowExpression.Compile(browserCheckElementsearchElementMinimumHeight, nameof(browserCheckElementsearchElementMinimumHeight), required: false);
            var __workflow_browserCheckElementsearchElementBoundingBoxLeft = WorkflowExpression.Compile(browserCheckElementsearchElementBoundingBoxLeft, nameof(browserCheckElementsearchElementBoundingBoxLeft), required: false);
            var __workflow_browserCheckElementsearchElementBoundingBoxRight = WorkflowExpression.Compile(browserCheckElementsearchElementBoundingBoxRight, nameof(browserCheckElementsearchElementBoundingBoxRight), required: false);
            var __workflow_browserCheckElementsearchElementBoundingBoxTop = WorkflowExpression.Compile(browserCheckElementsearchElementBoundingBoxTop, nameof(browserCheckElementsearchElementBoundingBoxTop), required: false);
            var __workflow_browserCheckElementsearchElementBoundingBoxBottom = WorkflowExpression.Compile(browserCheckElementsearchElementBoundingBoxBottom, nameof(browserCheckElementsearchElementBoundingBoxBottom), required: false);
            var __workflow_browserCheckElementonlyElementTopLeftNeedsToBeInBoundingBox = WorkflowExpression.Compile(browserCheckElementonlyElementTopLeftNeedsToBeInBoundingBox, nameof(browserCheckElementonlyElementTopLeftNeedsToBeInBoundingBox), required: false);
            var __workflow_browserCheckElementcheckElement = WorkflowExpression.Compile(browserCheckElementcheckElement, nameof(browserCheckElementcheckElement), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/BrowserControl/CheckElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserCheckElement = new JObject();
                var browserCheckElementpropCount = 0;
                if (__workflow_browserCheckElementparentElementHandle != null)
                {
                    browserCheckElement["ParentElementHandle"] = ExpressionConverter.ConvertO(__workflow_browserCheckElementparentElementHandle);
                    browserCheckElementpropCount++;
                }

                if (__workflow_browserCheckElementsearchElementHandle != null)
                {
                    browserCheckElement["SearchElementHandle"] = ExpressionConverter.ConvertO(__workflow_browserCheckElementsearchElementHandle);
                    browserCheckElementpropCount++;
                }

                if (__workflow_browserCheckElementsearchElementName != null)
                {
                    browserCheckElement["SearchElementName"] = ExpressionConverter.ConvertO(__workflow_browserCheckElementsearchElementName);
                    browserCheckElementpropCount++;
                }

                if (__workflow_browserCheckElementsearchElementID != null)
                {
                    browserCheckElement["SearchElementID"] = ExpressionConverter.ConvertO(__workflow_browserCheckElementsearchElementID);
                    browserCheckElementpropCount++;
                }

                if (__workflow_browserCheckElementsearchElementTagName != null)
                {
                    browserCheckElement["SearchElementTagName"] = ExpressionConverter.ConvertO(__workflow_browserCheckElementsearchElementTagName);
                    browserCheckElementpropCount++;
                }

                if (__workflow_browserCheckElementsearchElementXPath != null)
                {
                    browserCheckElement["SearchElementXPath"] = ExpressionConverter.ConvertO(__workflow_browserCheckElementsearchElementXPath);
                    browserCheckElementpropCount++;
                }

                if (__workflow_browserCheckElementsearchElementClassName != null)
                {
                    browserCheckElement["SearchElementClassName"] = ExpressionConverter.ConvertO(__workflow_browserCheckElementsearchElementClassName);
                    browserCheckElementpropCount++;
                }

                if (__workflow_browserCheckElementsearchElementCSSSelector != null)
                {
                    browserCheckElement["SearchElementCSSSelector"] = ExpressionConverter.ConvertO(__workflow_browserCheckElementsearchElementCSSSelector);
                    browserCheckElementpropCount++;
                }

                if (__workflow_browserCheckElementsearchElementIndex != null)
                {
                    if (__workflow_browserCheckElementsearchElementIndex != null)
                    {
                        browserCheckElement["SearchElementIndex"] = ExpressionConverter.ConvertO(__workflow_browserCheckElementsearchElementIndex);
                        browserCheckElementpropCount++;
                    }

                    browserCheckElementpropCount++;
                }
                else
                {
                    browserCheckElement["SearchElementIndex"] = 1;
                    browserCheckElementpropCount++;
                }

                if (__workflow_browserCheckElementsearchElementMatchValue != null)
                {
                    browserCheckElement["SearchElementMatchValue"] = ExpressionConverter.ConvertO(__workflow_browserCheckElementsearchElementMatchValue);
                    browserCheckElementpropCount++;
                }

                if (__workflow_browserCheckElementsearchElementMatchText != null)
                {
                    browserCheckElement["SearchElementMatchText"] = ExpressionConverter.ConvertO(__workflow_browserCheckElementsearchElementMatchText);
                    browserCheckElementpropCount++;
                }

                if (__workflow_browserCheckElementsearchElementType != null)
                {
                    browserCheckElement["SearchElementType"] = ExpressionConverter.ConvertO(__workflow_browserCheckElementsearchElementType);
                    browserCheckElementpropCount++;
                }

                if (__workflow_browserCheckElementsearchElementMinimumWidth != null)
                {
                    if (__workflow_browserCheckElementsearchElementMinimumWidth != null)
                    {
                        browserCheckElement["SearchElementMinimumWidth"] = ExpressionConverter.ConvertO(__workflow_browserCheckElementsearchElementMinimumWidth);
                        browserCheckElementpropCount++;
                    }

                    browserCheckElementpropCount++;
                }
                else
                {
                    browserCheckElement["SearchElementMinimumWidth"] = 1;
                    browserCheckElementpropCount++;
                }

                if (__workflow_browserCheckElementsearchElementMinimumHeight != null)
                {
                    if (__workflow_browserCheckElementsearchElementMinimumHeight != null)
                    {
                        browserCheckElement["SearchElementMinimumHeight"] = ExpressionConverter.ConvertO(__workflow_browserCheckElementsearchElementMinimumHeight);
                        browserCheckElementpropCount++;
                    }

                    browserCheckElementpropCount++;
                }
                else
                {
                    browserCheckElement["SearchElementMinimumHeight"] = 1;
                    browserCheckElementpropCount++;
                }

                if (__workflow_browserCheckElementsearchElementBoundingBoxLeft != null)
                {
                    if (__workflow_browserCheckElementsearchElementBoundingBoxLeft != null)
                    {
                        browserCheckElement["SearchElementBoundingBoxLeft"] = ExpressionConverter.ConvertO(__workflow_browserCheckElementsearchElementBoundingBoxLeft);
                        browserCheckElementpropCount++;
                    }

                    browserCheckElementpropCount++;
                }
                else
                {
                    browserCheckElement["SearchElementBoundingBoxLeft"] = -99999;
                    browserCheckElementpropCount++;
                }

                if (__workflow_browserCheckElementsearchElementBoundingBoxRight != null)
                {
                    if (__workflow_browserCheckElementsearchElementBoundingBoxRight != null)
                    {
                        browserCheckElement["SearchElementBoundingBoxRight"] = ExpressionConverter.ConvertO(__workflow_browserCheckElementsearchElementBoundingBoxRight);
                        browserCheckElementpropCount++;
                    }

                    browserCheckElementpropCount++;
                }
                else
                {
                    browserCheckElement["SearchElementBoundingBoxRight"] = 99999;
                    browserCheckElementpropCount++;
                }

                if (__workflow_browserCheckElementsearchElementBoundingBoxTop != null)
                {
                    if (__workflow_browserCheckElementsearchElementBoundingBoxTop != null)
                    {
                        browserCheckElement["SearchElementBoundingBoxTop"] = ExpressionConverter.ConvertO(__workflow_browserCheckElementsearchElementBoundingBoxTop);
                        browserCheckElementpropCount++;
                    }

                    browserCheckElementpropCount++;
                }
                else
                {
                    browserCheckElement["SearchElementBoundingBoxTop"] = -99999;
                    browserCheckElementpropCount++;
                }

                if (__workflow_browserCheckElementsearchElementBoundingBoxBottom != null)
                {
                    if (__workflow_browserCheckElementsearchElementBoundingBoxBottom != null)
                    {
                        browserCheckElement["SearchElementBoundingBoxBottom"] = ExpressionConverter.ConvertO(__workflow_browserCheckElementsearchElementBoundingBoxBottom);
                        browserCheckElementpropCount++;
                    }

                    browserCheckElementpropCount++;
                }
                else
                {
                    browserCheckElement["SearchElementBoundingBoxBottom"] = 99999;
                    browserCheckElementpropCount++;
                }

                if (__workflow_browserCheckElementonlyElementTopLeftNeedsToBeInBoundingBox != null)
                {
                    if (__workflow_browserCheckElementonlyElementTopLeftNeedsToBeInBoundingBox != null)
                    {
                        browserCheckElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = ExpressionConverter.ConvertO(__workflow_browserCheckElementonlyElementTopLeftNeedsToBeInBoundingBox);
                        browserCheckElementpropCount++;
                    }

                    browserCheckElementpropCount++;
                }
                else
                {
                    browserCheckElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = false;
                    browserCheckElementpropCount++;
                }

                if (__workflow_browserCheckElementcheckElement != null)
                {
                    if (__workflow_browserCheckElementcheckElement != null)
                    {
                        browserCheckElement["CheckElement"] = ExpressionConverter.ConvertO(__workflow_browserCheckElementcheckElement);
                        browserCheckElementpropCount++;
                    }

                    browserCheckElementpropCount++;
                }
                else
                {
                    browserCheckElement["CheckElement"] = true;
                    browserCheckElementpropCount++;
                }

                browserCheckElementpropCount++;
                browserCheckElement["Workflow"] = ExpressionConverter.ConvertO(__workflow_browserCheckElementworkflow);
                if (browserCheckElementpropCount > 0)
                {
                    callPayload.Body = browserCheckElement;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserCheckMultipleElements(Expression<Func<string>> browserCheckMultipleElementsinputElementsJSON, Expression<Func<string>> browserCheckMultipleElementsworkflow)
        {
            var __workflow_browserCheckMultipleElementsinputElementsJSON = WorkflowExpression.Compile(browserCheckMultipleElementsinputElementsJSON, nameof(browserCheckMultipleElementsinputElementsJSON), required: true);
            var __workflow_browserCheckMultipleElementsworkflow = WorkflowExpression.Compile(browserCheckMultipleElementsworkflow, nameof(browserCheckMultipleElementsworkflow), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/BrowserControl/BrowserCheckMultipleElements";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserCheckMultipleElements = new JObject();
                var browserCheckMultipleElementspropCount = 0;
                browserCheckMultipleElementspropCount++;
                browserCheckMultipleElements["InputElementsJSON"] = ExpressionConverter.ConvertO(__workflow_browserCheckMultipleElementsinputElementsJSON);
                browserCheckMultipleElementspropCount++;
                browserCheckMultipleElements["Workflow"] = ExpressionConverter.ConvertO(__workflow_browserCheckMultipleElementsworkflow);
                if (browserCheckMultipleElementspropCount > 0)
                {
                    callPayload.Body = browserCheckMultipleElements;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserGetSelectionPropertiesResponse> BrowserGetSelectionProperties(Expression<Func<string>> browserGetSelectionPropertiesworkflow, Expression<Func<double>> browserGetSelectionPropertiesparentElementHandle = null, Expression<Func<double>> browserGetSelectionPropertiessearchElementHandle = null, Expression<Func<string>> browserGetSelectionPropertiessearchElementName = null, Expression<Func<string>> browserGetSelectionPropertiessearchElementID = null, Expression<Func<string>> browserGetSelectionPropertiessearchElementTagName = null, Expression<Func<string>> browserGetSelectionPropertiessearchElementXPath = null, Expression<Func<string>> browserGetSelectionPropertiessearchElementClassName = null, Expression<Func<string>> browserGetSelectionPropertiessearchElementCSSSelector = null, Expression<Func<double>> browserGetSelectionPropertiessearchElementIndex = null, Expression<Func<string>> browserGetSelectionPropertiessearchElementMatchValue = null, Expression<Func<string>> browserGetSelectionPropertiessearchElementMatchText = null, Expression<Func<string>> browserGetSelectionPropertiessearchElementType = null, Expression<Func<double>> browserGetSelectionPropertiessearchElementMinimumWidth = null, Expression<Func<double>> browserGetSelectionPropertiessearchElementMinimumHeight = null, Expression<Func<double>> browserGetSelectionPropertiessearchElementBoundingBoxLeft = null, Expression<Func<double>> browserGetSelectionPropertiessearchElementBoundingBoxRight = null, Expression<Func<double>> browserGetSelectionPropertiessearchElementBoundingBoxTop = null, Expression<Func<double>> browserGetSelectionPropertiessearchElementBoundingBoxBottom = null, Expression<Func<bool>> browserGetSelectionPropertiesonlyElementTopLeftNeedsToBeInBoundingBox = null)
        {
            var __workflow_browserGetSelectionPropertiesworkflow = WorkflowExpression.Compile(browserGetSelectionPropertiesworkflow, nameof(browserGetSelectionPropertiesworkflow), required: true);
            var __workflow_browserGetSelectionPropertiesparentElementHandle = WorkflowExpression.Compile(browserGetSelectionPropertiesparentElementHandle, nameof(browserGetSelectionPropertiesparentElementHandle), required: false);
            var __workflow_browserGetSelectionPropertiessearchElementHandle = WorkflowExpression.Compile(browserGetSelectionPropertiessearchElementHandle, nameof(browserGetSelectionPropertiessearchElementHandle), required: false);
            var __workflow_browserGetSelectionPropertiessearchElementName = WorkflowExpression.Compile(browserGetSelectionPropertiessearchElementName, nameof(browserGetSelectionPropertiessearchElementName), required: false);
            var __workflow_browserGetSelectionPropertiessearchElementID = WorkflowExpression.Compile(browserGetSelectionPropertiessearchElementID, nameof(browserGetSelectionPropertiessearchElementID), required: false);
            var __workflow_browserGetSelectionPropertiessearchElementTagName = WorkflowExpression.Compile(browserGetSelectionPropertiessearchElementTagName, nameof(browserGetSelectionPropertiessearchElementTagName), required: false);
            var __workflow_browserGetSelectionPropertiessearchElementXPath = WorkflowExpression.Compile(browserGetSelectionPropertiessearchElementXPath, nameof(browserGetSelectionPropertiessearchElementXPath), required: false);
            var __workflow_browserGetSelectionPropertiessearchElementClassName = WorkflowExpression.Compile(browserGetSelectionPropertiessearchElementClassName, nameof(browserGetSelectionPropertiessearchElementClassName), required: false);
            var __workflow_browserGetSelectionPropertiessearchElementCSSSelector = WorkflowExpression.Compile(browserGetSelectionPropertiessearchElementCSSSelector, nameof(browserGetSelectionPropertiessearchElementCSSSelector), required: false);
            var __workflow_browserGetSelectionPropertiessearchElementIndex = WorkflowExpression.Compile(browserGetSelectionPropertiessearchElementIndex, nameof(browserGetSelectionPropertiessearchElementIndex), required: false);
            var __workflow_browserGetSelectionPropertiessearchElementMatchValue = WorkflowExpression.Compile(browserGetSelectionPropertiessearchElementMatchValue, nameof(browserGetSelectionPropertiessearchElementMatchValue), required: false);
            var __workflow_browserGetSelectionPropertiessearchElementMatchText = WorkflowExpression.Compile(browserGetSelectionPropertiessearchElementMatchText, nameof(browserGetSelectionPropertiessearchElementMatchText), required: false);
            var __workflow_browserGetSelectionPropertiessearchElementType = WorkflowExpression.Compile(browserGetSelectionPropertiessearchElementType, nameof(browserGetSelectionPropertiessearchElementType), required: false);
            var __workflow_browserGetSelectionPropertiessearchElementMinimumWidth = WorkflowExpression.Compile(browserGetSelectionPropertiessearchElementMinimumWidth, nameof(browserGetSelectionPropertiessearchElementMinimumWidth), required: false);
            var __workflow_browserGetSelectionPropertiessearchElementMinimumHeight = WorkflowExpression.Compile(browserGetSelectionPropertiessearchElementMinimumHeight, nameof(browserGetSelectionPropertiessearchElementMinimumHeight), required: false);
            var __workflow_browserGetSelectionPropertiessearchElementBoundingBoxLeft = WorkflowExpression.Compile(browserGetSelectionPropertiessearchElementBoundingBoxLeft, nameof(browserGetSelectionPropertiessearchElementBoundingBoxLeft), required: false);
            var __workflow_browserGetSelectionPropertiessearchElementBoundingBoxRight = WorkflowExpression.Compile(browserGetSelectionPropertiessearchElementBoundingBoxRight, nameof(browserGetSelectionPropertiessearchElementBoundingBoxRight), required: false);
            var __workflow_browserGetSelectionPropertiessearchElementBoundingBoxTop = WorkflowExpression.Compile(browserGetSelectionPropertiessearchElementBoundingBoxTop, nameof(browserGetSelectionPropertiessearchElementBoundingBoxTop), required: false);
            var __workflow_browserGetSelectionPropertiessearchElementBoundingBoxBottom = WorkflowExpression.Compile(browserGetSelectionPropertiessearchElementBoundingBoxBottom, nameof(browserGetSelectionPropertiessearchElementBoundingBoxBottom), required: false);
            var __workflow_browserGetSelectionPropertiesonlyElementTopLeftNeedsToBeInBoundingBox = WorkflowExpression.Compile(browserGetSelectionPropertiesonlyElementTopLeftNeedsToBeInBoundingBox, nameof(browserGetSelectionPropertiesonlyElementTopLeftNeedsToBeInBoundingBox), required: false);
            return new DeferredBodyAction<BrowserGetSelectionPropertiesResponse>(() =>
            {
                var apiCallPath = "/BrowserControl/GetSelectionProperties";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserGetSelectionProperties = new JObject();
                var browserGetSelectionPropertiespropCount = 0;
                if (__workflow_browserGetSelectionPropertiesparentElementHandle != null)
                {
                    browserGetSelectionProperties["ParentElementHandle"] = ExpressionConverter.ConvertO(__workflow_browserGetSelectionPropertiesparentElementHandle);
                    browserGetSelectionPropertiespropCount++;
                }

                if (__workflow_browserGetSelectionPropertiessearchElementHandle != null)
                {
                    browserGetSelectionProperties["SearchElementHandle"] = ExpressionConverter.ConvertO(__workflow_browserGetSelectionPropertiessearchElementHandle);
                    browserGetSelectionPropertiespropCount++;
                }

                if (__workflow_browserGetSelectionPropertiessearchElementName != null)
                {
                    browserGetSelectionProperties["SearchElementName"] = ExpressionConverter.ConvertO(__workflow_browserGetSelectionPropertiessearchElementName);
                    browserGetSelectionPropertiespropCount++;
                }

                if (__workflow_browserGetSelectionPropertiessearchElementID != null)
                {
                    browserGetSelectionProperties["SearchElementID"] = ExpressionConverter.ConvertO(__workflow_browserGetSelectionPropertiessearchElementID);
                    browserGetSelectionPropertiespropCount++;
                }

                if (__workflow_browserGetSelectionPropertiessearchElementTagName != null)
                {
                    browserGetSelectionProperties["SearchElementTagName"] = ExpressionConverter.ConvertO(__workflow_browserGetSelectionPropertiessearchElementTagName);
                    browserGetSelectionPropertiespropCount++;
                }

                if (__workflow_browserGetSelectionPropertiessearchElementXPath != null)
                {
                    browserGetSelectionProperties["SearchElementXPath"] = ExpressionConverter.ConvertO(__workflow_browserGetSelectionPropertiessearchElementXPath);
                    browserGetSelectionPropertiespropCount++;
                }

                if (__workflow_browserGetSelectionPropertiessearchElementClassName != null)
                {
                    browserGetSelectionProperties["SearchElementClassName"] = ExpressionConverter.ConvertO(__workflow_browserGetSelectionPropertiessearchElementClassName);
                    browserGetSelectionPropertiespropCount++;
                }

                if (__workflow_browserGetSelectionPropertiessearchElementCSSSelector != null)
                {
                    browserGetSelectionProperties["SearchElementCSSSelector"] = ExpressionConverter.ConvertO(__workflow_browserGetSelectionPropertiessearchElementCSSSelector);
                    browserGetSelectionPropertiespropCount++;
                }

                if (__workflow_browserGetSelectionPropertiessearchElementIndex != null)
                {
                    if (__workflow_browserGetSelectionPropertiessearchElementIndex != null)
                    {
                        browserGetSelectionProperties["SearchElementIndex"] = ExpressionConverter.ConvertO(__workflow_browserGetSelectionPropertiessearchElementIndex);
                        browserGetSelectionPropertiespropCount++;
                    }

                    browserGetSelectionPropertiespropCount++;
                }
                else
                {
                    browserGetSelectionProperties["SearchElementIndex"] = 1;
                    browserGetSelectionPropertiespropCount++;
                }

                if (__workflow_browserGetSelectionPropertiessearchElementMatchValue != null)
                {
                    browserGetSelectionProperties["SearchElementMatchValue"] = ExpressionConverter.ConvertO(__workflow_browserGetSelectionPropertiessearchElementMatchValue);
                    browserGetSelectionPropertiespropCount++;
                }

                if (__workflow_browserGetSelectionPropertiessearchElementMatchText != null)
                {
                    browserGetSelectionProperties["SearchElementMatchText"] = ExpressionConverter.ConvertO(__workflow_browserGetSelectionPropertiessearchElementMatchText);
                    browserGetSelectionPropertiespropCount++;
                }

                if (__workflow_browserGetSelectionPropertiessearchElementType != null)
                {
                    browserGetSelectionProperties["SearchElementType"] = ExpressionConverter.ConvertO(__workflow_browserGetSelectionPropertiessearchElementType);
                    browserGetSelectionPropertiespropCount++;
                }

                if (__workflow_browserGetSelectionPropertiessearchElementMinimumWidth != null)
                {
                    if (__workflow_browserGetSelectionPropertiessearchElementMinimumWidth != null)
                    {
                        browserGetSelectionProperties["SearchElementMinimumWidth"] = ExpressionConverter.ConvertO(__workflow_browserGetSelectionPropertiessearchElementMinimumWidth);
                        browserGetSelectionPropertiespropCount++;
                    }

                    browserGetSelectionPropertiespropCount++;
                }
                else
                {
                    browserGetSelectionProperties["SearchElementMinimumWidth"] = 1;
                    browserGetSelectionPropertiespropCount++;
                }

                if (__workflow_browserGetSelectionPropertiessearchElementMinimumHeight != null)
                {
                    if (__workflow_browserGetSelectionPropertiessearchElementMinimumHeight != null)
                    {
                        browserGetSelectionProperties["SearchElementMinimumHeight"] = ExpressionConverter.ConvertO(__workflow_browserGetSelectionPropertiessearchElementMinimumHeight);
                        browserGetSelectionPropertiespropCount++;
                    }

                    browserGetSelectionPropertiespropCount++;
                }
                else
                {
                    browserGetSelectionProperties["SearchElementMinimumHeight"] = 1;
                    browserGetSelectionPropertiespropCount++;
                }

                if (__workflow_browserGetSelectionPropertiessearchElementBoundingBoxLeft != null)
                {
                    if (__workflow_browserGetSelectionPropertiessearchElementBoundingBoxLeft != null)
                    {
                        browserGetSelectionProperties["SearchElementBoundingBoxLeft"] = ExpressionConverter.ConvertO(__workflow_browserGetSelectionPropertiessearchElementBoundingBoxLeft);
                        browserGetSelectionPropertiespropCount++;
                    }

                    browserGetSelectionPropertiespropCount++;
                }
                else
                {
                    browserGetSelectionProperties["SearchElementBoundingBoxLeft"] = -99999;
                    browserGetSelectionPropertiespropCount++;
                }

                if (__workflow_browserGetSelectionPropertiessearchElementBoundingBoxRight != null)
                {
                    if (__workflow_browserGetSelectionPropertiessearchElementBoundingBoxRight != null)
                    {
                        browserGetSelectionProperties["SearchElementBoundingBoxRight"] = ExpressionConverter.ConvertO(__workflow_browserGetSelectionPropertiessearchElementBoundingBoxRight);
                        browserGetSelectionPropertiespropCount++;
                    }

                    browserGetSelectionPropertiespropCount++;
                }
                else
                {
                    browserGetSelectionProperties["SearchElementBoundingBoxRight"] = 99999;
                    browserGetSelectionPropertiespropCount++;
                }

                if (__workflow_browserGetSelectionPropertiessearchElementBoundingBoxTop != null)
                {
                    if (__workflow_browserGetSelectionPropertiessearchElementBoundingBoxTop != null)
                    {
                        browserGetSelectionProperties["SearchElementBoundingBoxTop"] = ExpressionConverter.ConvertO(__workflow_browserGetSelectionPropertiessearchElementBoundingBoxTop);
                        browserGetSelectionPropertiespropCount++;
                    }

                    browserGetSelectionPropertiespropCount++;
                }
                else
                {
                    browserGetSelectionProperties["SearchElementBoundingBoxTop"] = -99999;
                    browserGetSelectionPropertiespropCount++;
                }

                if (__workflow_browserGetSelectionPropertiessearchElementBoundingBoxBottom != null)
                {
                    if (__workflow_browserGetSelectionPropertiessearchElementBoundingBoxBottom != null)
                    {
                        browserGetSelectionProperties["SearchElementBoundingBoxBottom"] = ExpressionConverter.ConvertO(__workflow_browserGetSelectionPropertiessearchElementBoundingBoxBottom);
                        browserGetSelectionPropertiespropCount++;
                    }

                    browserGetSelectionPropertiespropCount++;
                }
                else
                {
                    browserGetSelectionProperties["SearchElementBoundingBoxBottom"] = 99999;
                    browserGetSelectionPropertiespropCount++;
                }

                if (__workflow_browserGetSelectionPropertiesonlyElementTopLeftNeedsToBeInBoundingBox != null)
                {
                    if (__workflow_browserGetSelectionPropertiesonlyElementTopLeftNeedsToBeInBoundingBox != null)
                    {
                        browserGetSelectionProperties["OnlyElementTopLeftNeedsToBeInBoundingBox"] = ExpressionConverter.ConvertO(__workflow_browserGetSelectionPropertiesonlyElementTopLeftNeedsToBeInBoundingBox);
                        browserGetSelectionPropertiespropCount++;
                    }

                    browserGetSelectionPropertiespropCount++;
                }
                else
                {
                    browserGetSelectionProperties["OnlyElementTopLeftNeedsToBeInBoundingBox"] = false;
                    browserGetSelectionPropertiespropCount++;
                }

                browserGetSelectionPropertiespropCount++;
                browserGetSelectionProperties["Workflow"] = ExpressionConverter.ConvertO(__workflow_browserGetSelectionPropertiesworkflow);
                if (browserGetSelectionPropertiespropCount > 0)
                {
                    callPayload.Body = browserGetSelectionProperties;
                }

                return new ApiConnectionAction<BrowserGetSelectionPropertiesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserSelectSelection(Expression<Func<string>> browserSelectSelectionworkflow, Expression<Func<double>> browserSelectSelectionparentElementHandle = null, Expression<Func<double>> browserSelectSelectionsearchElementHandle = null, Expression<Func<string>> browserSelectSelectionsearchElementName = null, Expression<Func<string>> browserSelectSelectionsearchElementID = null, Expression<Func<string>> browserSelectSelectionsearchElementTagName = null, Expression<Func<string>> browserSelectSelectionsearchElementXPath = null, Expression<Func<string>> browserSelectSelectionsearchElementClassName = null, Expression<Func<string>> browserSelectSelectionsearchElementCSSSelector = null, Expression<Func<double>> browserSelectSelectionsearchElementIndex = null, Expression<Func<string>> browserSelectSelectionsearchElementMatchValue = null, Expression<Func<string>> browserSelectSelectionsearchElementMatchText = null, Expression<Func<string>> browserSelectSelectionsearchElementType = null, Expression<Func<double>> browserSelectSelectionsearchElementMinimumWidth = null, Expression<Func<double>> browserSelectSelectionsearchElementMinimumHeight = null, Expression<Func<double>> browserSelectSelectionsearchElementBoundingBoxLeft = null, Expression<Func<double>> browserSelectSelectionsearchElementBoundingBoxRight = null, Expression<Func<double>> browserSelectSelectionsearchElementBoundingBoxTop = null, Expression<Func<double>> browserSelectSelectionsearchElementBoundingBoxBottom = null, Expression<Func<bool>> browserSelectSelectiononlyElementTopLeftNeedsToBeInBoundingBox = null, Expression<Func<string>> browserSelectSelectionvalueToSelect = null, Expression<Func<string>> browserSelectSelectiontextToSelect = null, Expression<Func<double>> browserSelectSelectionindexToSelect = null)
        {
            var __workflow_browserSelectSelectionworkflow = WorkflowExpression.Compile(browserSelectSelectionworkflow, nameof(browserSelectSelectionworkflow), required: true);
            var __workflow_browserSelectSelectionparentElementHandle = WorkflowExpression.Compile(browserSelectSelectionparentElementHandle, nameof(browserSelectSelectionparentElementHandle), required: false);
            var __workflow_browserSelectSelectionsearchElementHandle = WorkflowExpression.Compile(browserSelectSelectionsearchElementHandle, nameof(browserSelectSelectionsearchElementHandle), required: false);
            var __workflow_browserSelectSelectionsearchElementName = WorkflowExpression.Compile(browserSelectSelectionsearchElementName, nameof(browserSelectSelectionsearchElementName), required: false);
            var __workflow_browserSelectSelectionsearchElementID = WorkflowExpression.Compile(browserSelectSelectionsearchElementID, nameof(browserSelectSelectionsearchElementID), required: false);
            var __workflow_browserSelectSelectionsearchElementTagName = WorkflowExpression.Compile(browserSelectSelectionsearchElementTagName, nameof(browserSelectSelectionsearchElementTagName), required: false);
            var __workflow_browserSelectSelectionsearchElementXPath = WorkflowExpression.Compile(browserSelectSelectionsearchElementXPath, nameof(browserSelectSelectionsearchElementXPath), required: false);
            var __workflow_browserSelectSelectionsearchElementClassName = WorkflowExpression.Compile(browserSelectSelectionsearchElementClassName, nameof(browserSelectSelectionsearchElementClassName), required: false);
            var __workflow_browserSelectSelectionsearchElementCSSSelector = WorkflowExpression.Compile(browserSelectSelectionsearchElementCSSSelector, nameof(browserSelectSelectionsearchElementCSSSelector), required: false);
            var __workflow_browserSelectSelectionsearchElementIndex = WorkflowExpression.Compile(browserSelectSelectionsearchElementIndex, nameof(browserSelectSelectionsearchElementIndex), required: false);
            var __workflow_browserSelectSelectionsearchElementMatchValue = WorkflowExpression.Compile(browserSelectSelectionsearchElementMatchValue, nameof(browserSelectSelectionsearchElementMatchValue), required: false);
            var __workflow_browserSelectSelectionsearchElementMatchText = WorkflowExpression.Compile(browserSelectSelectionsearchElementMatchText, nameof(browserSelectSelectionsearchElementMatchText), required: false);
            var __workflow_browserSelectSelectionsearchElementType = WorkflowExpression.Compile(browserSelectSelectionsearchElementType, nameof(browserSelectSelectionsearchElementType), required: false);
            var __workflow_browserSelectSelectionsearchElementMinimumWidth = WorkflowExpression.Compile(browserSelectSelectionsearchElementMinimumWidth, nameof(browserSelectSelectionsearchElementMinimumWidth), required: false);
            var __workflow_browserSelectSelectionsearchElementMinimumHeight = WorkflowExpression.Compile(browserSelectSelectionsearchElementMinimumHeight, nameof(browserSelectSelectionsearchElementMinimumHeight), required: false);
            var __workflow_browserSelectSelectionsearchElementBoundingBoxLeft = WorkflowExpression.Compile(browserSelectSelectionsearchElementBoundingBoxLeft, nameof(browserSelectSelectionsearchElementBoundingBoxLeft), required: false);
            var __workflow_browserSelectSelectionsearchElementBoundingBoxRight = WorkflowExpression.Compile(browserSelectSelectionsearchElementBoundingBoxRight, nameof(browserSelectSelectionsearchElementBoundingBoxRight), required: false);
            var __workflow_browserSelectSelectionsearchElementBoundingBoxTop = WorkflowExpression.Compile(browserSelectSelectionsearchElementBoundingBoxTop, nameof(browserSelectSelectionsearchElementBoundingBoxTop), required: false);
            var __workflow_browserSelectSelectionsearchElementBoundingBoxBottom = WorkflowExpression.Compile(browserSelectSelectionsearchElementBoundingBoxBottom, nameof(browserSelectSelectionsearchElementBoundingBoxBottom), required: false);
            var __workflow_browserSelectSelectiononlyElementTopLeftNeedsToBeInBoundingBox = WorkflowExpression.Compile(browserSelectSelectiononlyElementTopLeftNeedsToBeInBoundingBox, nameof(browserSelectSelectiononlyElementTopLeftNeedsToBeInBoundingBox), required: false);
            var __workflow_browserSelectSelectionvalueToSelect = WorkflowExpression.Compile(browserSelectSelectionvalueToSelect, nameof(browserSelectSelectionvalueToSelect), required: false);
            var __workflow_browserSelectSelectiontextToSelect = WorkflowExpression.Compile(browserSelectSelectiontextToSelect, nameof(browserSelectSelectiontextToSelect), required: false);
            var __workflow_browserSelectSelectionindexToSelect = WorkflowExpression.Compile(browserSelectSelectionindexToSelect, nameof(browserSelectSelectionindexToSelect), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/BrowserControl/SelectSelection";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserSelectSelection = new JObject();
                var browserSelectSelectionpropCount = 0;
                if (__workflow_browserSelectSelectionparentElementHandle != null)
                {
                    browserSelectSelection["ParentElementHandle"] = ExpressionConverter.ConvertO(__workflow_browserSelectSelectionparentElementHandle);
                    browserSelectSelectionpropCount++;
                }

                if (__workflow_browserSelectSelectionsearchElementHandle != null)
                {
                    browserSelectSelection["SearchElementHandle"] = ExpressionConverter.ConvertO(__workflow_browserSelectSelectionsearchElementHandle);
                    browserSelectSelectionpropCount++;
                }

                if (__workflow_browserSelectSelectionsearchElementName != null)
                {
                    browserSelectSelection["SearchElementName"] = ExpressionConverter.ConvertO(__workflow_browserSelectSelectionsearchElementName);
                    browserSelectSelectionpropCount++;
                }

                if (__workflow_browserSelectSelectionsearchElementID != null)
                {
                    browserSelectSelection["SearchElementID"] = ExpressionConverter.ConvertO(__workflow_browserSelectSelectionsearchElementID);
                    browserSelectSelectionpropCount++;
                }

                if (__workflow_browserSelectSelectionsearchElementTagName != null)
                {
                    browserSelectSelection["SearchElementTagName"] = ExpressionConverter.ConvertO(__workflow_browserSelectSelectionsearchElementTagName);
                    browserSelectSelectionpropCount++;
                }

                if (__workflow_browserSelectSelectionsearchElementXPath != null)
                {
                    browserSelectSelection["SearchElementXPath"] = ExpressionConverter.ConvertO(__workflow_browserSelectSelectionsearchElementXPath);
                    browserSelectSelectionpropCount++;
                }

                if (__workflow_browserSelectSelectionsearchElementClassName != null)
                {
                    browserSelectSelection["SearchElementClassName"] = ExpressionConverter.ConvertO(__workflow_browserSelectSelectionsearchElementClassName);
                    browserSelectSelectionpropCount++;
                }

                if (__workflow_browserSelectSelectionsearchElementCSSSelector != null)
                {
                    browserSelectSelection["SearchElementCSSSelector"] = ExpressionConverter.ConvertO(__workflow_browserSelectSelectionsearchElementCSSSelector);
                    browserSelectSelectionpropCount++;
                }

                if (__workflow_browserSelectSelectionsearchElementIndex != null)
                {
                    if (__workflow_browserSelectSelectionsearchElementIndex != null)
                    {
                        browserSelectSelection["SearchElementIndex"] = ExpressionConverter.ConvertO(__workflow_browserSelectSelectionsearchElementIndex);
                        browserSelectSelectionpropCount++;
                    }

                    browserSelectSelectionpropCount++;
                }
                else
                {
                    browserSelectSelection["SearchElementIndex"] = 1;
                    browserSelectSelectionpropCount++;
                }

                if (__workflow_browserSelectSelectionsearchElementMatchValue != null)
                {
                    browserSelectSelection["SearchElementMatchValue"] = ExpressionConverter.ConvertO(__workflow_browserSelectSelectionsearchElementMatchValue);
                    browserSelectSelectionpropCount++;
                }

                if (__workflow_browserSelectSelectionsearchElementMatchText != null)
                {
                    browserSelectSelection["SearchElementMatchText"] = ExpressionConverter.ConvertO(__workflow_browserSelectSelectionsearchElementMatchText);
                    browserSelectSelectionpropCount++;
                }

                if (__workflow_browserSelectSelectionsearchElementType != null)
                {
                    browserSelectSelection["SearchElementType"] = ExpressionConverter.ConvertO(__workflow_browserSelectSelectionsearchElementType);
                    browserSelectSelectionpropCount++;
                }

                if (__workflow_browserSelectSelectionsearchElementMinimumWidth != null)
                {
                    if (__workflow_browserSelectSelectionsearchElementMinimumWidth != null)
                    {
                        browserSelectSelection["SearchElementMinimumWidth"] = ExpressionConverter.ConvertO(__workflow_browserSelectSelectionsearchElementMinimumWidth);
                        browserSelectSelectionpropCount++;
                    }

                    browserSelectSelectionpropCount++;
                }
                else
                {
                    browserSelectSelection["SearchElementMinimumWidth"] = 1;
                    browserSelectSelectionpropCount++;
                }

                if (__workflow_browserSelectSelectionsearchElementMinimumHeight != null)
                {
                    if (__workflow_browserSelectSelectionsearchElementMinimumHeight != null)
                    {
                        browserSelectSelection["SearchElementMinimumHeight"] = ExpressionConverter.ConvertO(__workflow_browserSelectSelectionsearchElementMinimumHeight);
                        browserSelectSelectionpropCount++;
                    }

                    browserSelectSelectionpropCount++;
                }
                else
                {
                    browserSelectSelection["SearchElementMinimumHeight"] = 1;
                    browserSelectSelectionpropCount++;
                }

                if (__workflow_browserSelectSelectionsearchElementBoundingBoxLeft != null)
                {
                    if (__workflow_browserSelectSelectionsearchElementBoundingBoxLeft != null)
                    {
                        browserSelectSelection["SearchElementBoundingBoxLeft"] = ExpressionConverter.ConvertO(__workflow_browserSelectSelectionsearchElementBoundingBoxLeft);
                        browserSelectSelectionpropCount++;
                    }

                    browserSelectSelectionpropCount++;
                }
                else
                {
                    browserSelectSelection["SearchElementBoundingBoxLeft"] = -99999;
                    browserSelectSelectionpropCount++;
                }

                if (__workflow_browserSelectSelectionsearchElementBoundingBoxRight != null)
                {
                    if (__workflow_browserSelectSelectionsearchElementBoundingBoxRight != null)
                    {
                        browserSelectSelection["SearchElementBoundingBoxRight"] = ExpressionConverter.ConvertO(__workflow_browserSelectSelectionsearchElementBoundingBoxRight);
                        browserSelectSelectionpropCount++;
                    }

                    browserSelectSelectionpropCount++;
                }
                else
                {
                    browserSelectSelection["SearchElementBoundingBoxRight"] = 99999;
                    browserSelectSelectionpropCount++;
                }

                if (__workflow_browserSelectSelectionsearchElementBoundingBoxTop != null)
                {
                    if (__workflow_browserSelectSelectionsearchElementBoundingBoxTop != null)
                    {
                        browserSelectSelection["SearchElementBoundingBoxTop"] = ExpressionConverter.ConvertO(__workflow_browserSelectSelectionsearchElementBoundingBoxTop);
                        browserSelectSelectionpropCount++;
                    }

                    browserSelectSelectionpropCount++;
                }
                else
                {
                    browserSelectSelection["SearchElementBoundingBoxTop"] = -99999;
                    browserSelectSelectionpropCount++;
                }

                if (__workflow_browserSelectSelectionsearchElementBoundingBoxBottom != null)
                {
                    if (__workflow_browserSelectSelectionsearchElementBoundingBoxBottom != null)
                    {
                        browserSelectSelection["SearchElementBoundingBoxBottom"] = ExpressionConverter.ConvertO(__workflow_browserSelectSelectionsearchElementBoundingBoxBottom);
                        browserSelectSelectionpropCount++;
                    }

                    browserSelectSelectionpropCount++;
                }
                else
                {
                    browserSelectSelection["SearchElementBoundingBoxBottom"] = 99999;
                    browserSelectSelectionpropCount++;
                }

                if (__workflow_browserSelectSelectiononlyElementTopLeftNeedsToBeInBoundingBox != null)
                {
                    if (__workflow_browserSelectSelectiononlyElementTopLeftNeedsToBeInBoundingBox != null)
                    {
                        browserSelectSelection["OnlyElementTopLeftNeedsToBeInBoundingBox"] = ExpressionConverter.ConvertO(__workflow_browserSelectSelectiononlyElementTopLeftNeedsToBeInBoundingBox);
                        browserSelectSelectionpropCount++;
                    }

                    browserSelectSelectionpropCount++;
                }
                else
                {
                    browserSelectSelection["OnlyElementTopLeftNeedsToBeInBoundingBox"] = false;
                    browserSelectSelectionpropCount++;
                }

                if (__workflow_browserSelectSelectionvalueToSelect != null)
                {
                    browserSelectSelection["ValueToSelect"] = ExpressionConverter.ConvertO(__workflow_browserSelectSelectionvalueToSelect);
                    browserSelectSelectionpropCount++;
                }

                if (__workflow_browserSelectSelectiontextToSelect != null)
                {
                    browserSelectSelection["TextToSelect"] = ExpressionConverter.ConvertO(__workflow_browserSelectSelectiontextToSelect);
                    browserSelectSelectionpropCount++;
                }

                if (__workflow_browserSelectSelectionindexToSelect != null)
                {
                    if (__workflow_browserSelectSelectionindexToSelect != null)
                    {
                        browserSelectSelection["IndexToSelect"] = ExpressionConverter.ConvertO(__workflow_browserSelectSelectionindexToSelect);
                        browserSelectSelectionpropCount++;
                    }

                    browserSelectSelectionpropCount++;
                }
                else
                {
                    browserSelectSelection["IndexToSelect"] = 1;
                    browserSelectSelectionpropCount++;
                }

                browserSelectSelectionpropCount++;
                browserSelectSelection["Workflow"] = ExpressionConverter.ConvertO(__workflow_browserSelectSelectionworkflow);
                if (browserSelectSelectionpropCount > 0)
                {
                    callPayload.Body = browserSelectSelection;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserDeselectSelection(Expression<Func<string>> browserDeselectSelectionworkflow, Expression<Func<double>> browserDeselectSelectionparentElementHandle = null, Expression<Func<double>> browserDeselectSelectionsearchElementHandle = null, Expression<Func<string>> browserDeselectSelectionsearchElementName = null, Expression<Func<string>> browserDeselectSelectionsearchElementID = null, Expression<Func<string>> browserDeselectSelectionsearchElementTagName = null, Expression<Func<string>> browserDeselectSelectionsearchElementXPath = null, Expression<Func<string>> browserDeselectSelectionsearchElementClassName = null, Expression<Func<string>> browserDeselectSelectionsearchElementCSSSelector = null, Expression<Func<double>> browserDeselectSelectionsearchElementIndex = null, Expression<Func<string>> browserDeselectSelectionsearchElementMatchValue = null, Expression<Func<string>> browserDeselectSelectionsearchElementMatchText = null, Expression<Func<string>> browserDeselectSelectionsearchElementType = null, Expression<Func<double>> browserDeselectSelectionsearchElementMinimumWidth = null, Expression<Func<double>> browserDeselectSelectionsearchElementMinimumHeight = null, Expression<Func<double>> browserDeselectSelectionsearchElementBoundingBoxLeft = null, Expression<Func<double>> browserDeselectSelectionsearchElementBoundingBoxRight = null, Expression<Func<double>> browserDeselectSelectionsearchElementBoundingBoxTop = null, Expression<Func<double>> browserDeselectSelectionsearchElementBoundingBoxBottom = null, Expression<Func<bool>> browserDeselectSelectiononlyElementTopLeftNeedsToBeInBoundingBox = null, Expression<Func<string>> browserDeselectSelectionvalueToDeselect = null, Expression<Func<string>> browserDeselectSelectiontextToDeselect = null, Expression<Func<double>> browserDeselectSelectionindexToDeselect = null)
        {
            var __workflow_browserDeselectSelectionworkflow = WorkflowExpression.Compile(browserDeselectSelectionworkflow, nameof(browserDeselectSelectionworkflow), required: true);
            var __workflow_browserDeselectSelectionparentElementHandle = WorkflowExpression.Compile(browserDeselectSelectionparentElementHandle, nameof(browserDeselectSelectionparentElementHandle), required: false);
            var __workflow_browserDeselectSelectionsearchElementHandle = WorkflowExpression.Compile(browserDeselectSelectionsearchElementHandle, nameof(browserDeselectSelectionsearchElementHandle), required: false);
            var __workflow_browserDeselectSelectionsearchElementName = WorkflowExpression.Compile(browserDeselectSelectionsearchElementName, nameof(browserDeselectSelectionsearchElementName), required: false);
            var __workflow_browserDeselectSelectionsearchElementID = WorkflowExpression.Compile(browserDeselectSelectionsearchElementID, nameof(browserDeselectSelectionsearchElementID), required: false);
            var __workflow_browserDeselectSelectionsearchElementTagName = WorkflowExpression.Compile(browserDeselectSelectionsearchElementTagName, nameof(browserDeselectSelectionsearchElementTagName), required: false);
            var __workflow_browserDeselectSelectionsearchElementXPath = WorkflowExpression.Compile(browserDeselectSelectionsearchElementXPath, nameof(browserDeselectSelectionsearchElementXPath), required: false);
            var __workflow_browserDeselectSelectionsearchElementClassName = WorkflowExpression.Compile(browserDeselectSelectionsearchElementClassName, nameof(browserDeselectSelectionsearchElementClassName), required: false);
            var __workflow_browserDeselectSelectionsearchElementCSSSelector = WorkflowExpression.Compile(browserDeselectSelectionsearchElementCSSSelector, nameof(browserDeselectSelectionsearchElementCSSSelector), required: false);
            var __workflow_browserDeselectSelectionsearchElementIndex = WorkflowExpression.Compile(browserDeselectSelectionsearchElementIndex, nameof(browserDeselectSelectionsearchElementIndex), required: false);
            var __workflow_browserDeselectSelectionsearchElementMatchValue = WorkflowExpression.Compile(browserDeselectSelectionsearchElementMatchValue, nameof(browserDeselectSelectionsearchElementMatchValue), required: false);
            var __workflow_browserDeselectSelectionsearchElementMatchText = WorkflowExpression.Compile(browserDeselectSelectionsearchElementMatchText, nameof(browserDeselectSelectionsearchElementMatchText), required: false);
            var __workflow_browserDeselectSelectionsearchElementType = WorkflowExpression.Compile(browserDeselectSelectionsearchElementType, nameof(browserDeselectSelectionsearchElementType), required: false);
            var __workflow_browserDeselectSelectionsearchElementMinimumWidth = WorkflowExpression.Compile(browserDeselectSelectionsearchElementMinimumWidth, nameof(browserDeselectSelectionsearchElementMinimumWidth), required: false);
            var __workflow_browserDeselectSelectionsearchElementMinimumHeight = WorkflowExpression.Compile(browserDeselectSelectionsearchElementMinimumHeight, nameof(browserDeselectSelectionsearchElementMinimumHeight), required: false);
            var __workflow_browserDeselectSelectionsearchElementBoundingBoxLeft = WorkflowExpression.Compile(browserDeselectSelectionsearchElementBoundingBoxLeft, nameof(browserDeselectSelectionsearchElementBoundingBoxLeft), required: false);
            var __workflow_browserDeselectSelectionsearchElementBoundingBoxRight = WorkflowExpression.Compile(browserDeselectSelectionsearchElementBoundingBoxRight, nameof(browserDeselectSelectionsearchElementBoundingBoxRight), required: false);
            var __workflow_browserDeselectSelectionsearchElementBoundingBoxTop = WorkflowExpression.Compile(browserDeselectSelectionsearchElementBoundingBoxTop, nameof(browserDeselectSelectionsearchElementBoundingBoxTop), required: false);
            var __workflow_browserDeselectSelectionsearchElementBoundingBoxBottom = WorkflowExpression.Compile(browserDeselectSelectionsearchElementBoundingBoxBottom, nameof(browserDeselectSelectionsearchElementBoundingBoxBottom), required: false);
            var __workflow_browserDeselectSelectiononlyElementTopLeftNeedsToBeInBoundingBox = WorkflowExpression.Compile(browserDeselectSelectiononlyElementTopLeftNeedsToBeInBoundingBox, nameof(browserDeselectSelectiononlyElementTopLeftNeedsToBeInBoundingBox), required: false);
            var __workflow_browserDeselectSelectionvalueToDeselect = WorkflowExpression.Compile(browserDeselectSelectionvalueToDeselect, nameof(browserDeselectSelectionvalueToDeselect), required: false);
            var __workflow_browserDeselectSelectiontextToDeselect = WorkflowExpression.Compile(browserDeselectSelectiontextToDeselect, nameof(browserDeselectSelectiontextToDeselect), required: false);
            var __workflow_browserDeselectSelectionindexToDeselect = WorkflowExpression.Compile(browserDeselectSelectionindexToDeselect, nameof(browserDeselectSelectionindexToDeselect), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/BrowserControl/DeselectSelection";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserDeselectSelection = new JObject();
                var browserDeselectSelectionpropCount = 0;
                if (__workflow_browserDeselectSelectionparentElementHandle != null)
                {
                    browserDeselectSelection["ParentElementHandle"] = ExpressionConverter.ConvertO(__workflow_browserDeselectSelectionparentElementHandle);
                    browserDeselectSelectionpropCount++;
                }

                if (__workflow_browserDeselectSelectionsearchElementHandle != null)
                {
                    browserDeselectSelection["SearchElementHandle"] = ExpressionConverter.ConvertO(__workflow_browserDeselectSelectionsearchElementHandle);
                    browserDeselectSelectionpropCount++;
                }

                if (__workflow_browserDeselectSelectionsearchElementName != null)
                {
                    browserDeselectSelection["SearchElementName"] = ExpressionConverter.ConvertO(__workflow_browserDeselectSelectionsearchElementName);
                    browserDeselectSelectionpropCount++;
                }

                if (__workflow_browserDeselectSelectionsearchElementID != null)
                {
                    browserDeselectSelection["SearchElementID"] = ExpressionConverter.ConvertO(__workflow_browserDeselectSelectionsearchElementID);
                    browserDeselectSelectionpropCount++;
                }

                if (__workflow_browserDeselectSelectionsearchElementTagName != null)
                {
                    browserDeselectSelection["SearchElementTagName"] = ExpressionConverter.ConvertO(__workflow_browserDeselectSelectionsearchElementTagName);
                    browserDeselectSelectionpropCount++;
                }

                if (__workflow_browserDeselectSelectionsearchElementXPath != null)
                {
                    browserDeselectSelection["SearchElementXPath"] = ExpressionConverter.ConvertO(__workflow_browserDeselectSelectionsearchElementXPath);
                    browserDeselectSelectionpropCount++;
                }

                if (__workflow_browserDeselectSelectionsearchElementClassName != null)
                {
                    browserDeselectSelection["SearchElementClassName"] = ExpressionConverter.ConvertO(__workflow_browserDeselectSelectionsearchElementClassName);
                    browserDeselectSelectionpropCount++;
                }

                if (__workflow_browserDeselectSelectionsearchElementCSSSelector != null)
                {
                    browserDeselectSelection["SearchElementCSSSelector"] = ExpressionConverter.ConvertO(__workflow_browserDeselectSelectionsearchElementCSSSelector);
                    browserDeselectSelectionpropCount++;
                }

                if (__workflow_browserDeselectSelectionsearchElementIndex != null)
                {
                    if (__workflow_browserDeselectSelectionsearchElementIndex != null)
                    {
                        browserDeselectSelection["SearchElementIndex"] = ExpressionConverter.ConvertO(__workflow_browserDeselectSelectionsearchElementIndex);
                        browserDeselectSelectionpropCount++;
                    }

                    browserDeselectSelectionpropCount++;
                }
                else
                {
                    browserDeselectSelection["SearchElementIndex"] = 1;
                    browserDeselectSelectionpropCount++;
                }

                if (__workflow_browserDeselectSelectionsearchElementMatchValue != null)
                {
                    browserDeselectSelection["SearchElementMatchValue"] = ExpressionConverter.ConvertO(__workflow_browserDeselectSelectionsearchElementMatchValue);
                    browserDeselectSelectionpropCount++;
                }

                if (__workflow_browserDeselectSelectionsearchElementMatchText != null)
                {
                    browserDeselectSelection["SearchElementMatchText"] = ExpressionConverter.ConvertO(__workflow_browserDeselectSelectionsearchElementMatchText);
                    browserDeselectSelectionpropCount++;
                }

                if (__workflow_browserDeselectSelectionsearchElementType != null)
                {
                    browserDeselectSelection["SearchElementType"] = ExpressionConverter.ConvertO(__workflow_browserDeselectSelectionsearchElementType);
                    browserDeselectSelectionpropCount++;
                }

                if (__workflow_browserDeselectSelectionsearchElementMinimumWidth != null)
                {
                    if (__workflow_browserDeselectSelectionsearchElementMinimumWidth != null)
                    {
                        browserDeselectSelection["SearchElementMinimumWidth"] = ExpressionConverter.ConvertO(__workflow_browserDeselectSelectionsearchElementMinimumWidth);
                        browserDeselectSelectionpropCount++;
                    }

                    browserDeselectSelectionpropCount++;
                }
                else
                {
                    browserDeselectSelection["SearchElementMinimumWidth"] = 1;
                    browserDeselectSelectionpropCount++;
                }

                if (__workflow_browserDeselectSelectionsearchElementMinimumHeight != null)
                {
                    if (__workflow_browserDeselectSelectionsearchElementMinimumHeight != null)
                    {
                        browserDeselectSelection["SearchElementMinimumHeight"] = ExpressionConverter.ConvertO(__workflow_browserDeselectSelectionsearchElementMinimumHeight);
                        browserDeselectSelectionpropCount++;
                    }

                    browserDeselectSelectionpropCount++;
                }
                else
                {
                    browserDeselectSelection["SearchElementMinimumHeight"] = 1;
                    browserDeselectSelectionpropCount++;
                }

                if (__workflow_browserDeselectSelectionsearchElementBoundingBoxLeft != null)
                {
                    if (__workflow_browserDeselectSelectionsearchElementBoundingBoxLeft != null)
                    {
                        browserDeselectSelection["SearchElementBoundingBoxLeft"] = ExpressionConverter.ConvertO(__workflow_browserDeselectSelectionsearchElementBoundingBoxLeft);
                        browserDeselectSelectionpropCount++;
                    }

                    browserDeselectSelectionpropCount++;
                }
                else
                {
                    browserDeselectSelection["SearchElementBoundingBoxLeft"] = -99999;
                    browserDeselectSelectionpropCount++;
                }

                if (__workflow_browserDeselectSelectionsearchElementBoundingBoxRight != null)
                {
                    if (__workflow_browserDeselectSelectionsearchElementBoundingBoxRight != null)
                    {
                        browserDeselectSelection["SearchElementBoundingBoxRight"] = ExpressionConverter.ConvertO(__workflow_browserDeselectSelectionsearchElementBoundingBoxRight);
                        browserDeselectSelectionpropCount++;
                    }

                    browserDeselectSelectionpropCount++;
                }
                else
                {
                    browserDeselectSelection["SearchElementBoundingBoxRight"] = 99999;
                    browserDeselectSelectionpropCount++;
                }

                if (__workflow_browserDeselectSelectionsearchElementBoundingBoxTop != null)
                {
                    if (__workflow_browserDeselectSelectionsearchElementBoundingBoxTop != null)
                    {
                        browserDeselectSelection["SearchElementBoundingBoxTop"] = ExpressionConverter.ConvertO(__workflow_browserDeselectSelectionsearchElementBoundingBoxTop);
                        browserDeselectSelectionpropCount++;
                    }

                    browserDeselectSelectionpropCount++;
                }
                else
                {
                    browserDeselectSelection["SearchElementBoundingBoxTop"] = -99999;
                    browserDeselectSelectionpropCount++;
                }

                if (__workflow_browserDeselectSelectionsearchElementBoundingBoxBottom != null)
                {
                    if (__workflow_browserDeselectSelectionsearchElementBoundingBoxBottom != null)
                    {
                        browserDeselectSelection["SearchElementBoundingBoxBottom"] = ExpressionConverter.ConvertO(__workflow_browserDeselectSelectionsearchElementBoundingBoxBottom);
                        browserDeselectSelectionpropCount++;
                    }

                    browserDeselectSelectionpropCount++;
                }
                else
                {
                    browserDeselectSelection["SearchElementBoundingBoxBottom"] = 99999;
                    browserDeselectSelectionpropCount++;
                }

                if (__workflow_browserDeselectSelectiononlyElementTopLeftNeedsToBeInBoundingBox != null)
                {
                    if (__workflow_browserDeselectSelectiononlyElementTopLeftNeedsToBeInBoundingBox != null)
                    {
                        browserDeselectSelection["OnlyElementTopLeftNeedsToBeInBoundingBox"] = ExpressionConverter.ConvertO(__workflow_browserDeselectSelectiononlyElementTopLeftNeedsToBeInBoundingBox);
                        browserDeselectSelectionpropCount++;
                    }

                    browserDeselectSelectionpropCount++;
                }
                else
                {
                    browserDeselectSelection["OnlyElementTopLeftNeedsToBeInBoundingBox"] = false;
                    browserDeselectSelectionpropCount++;
                }

                if (__workflow_browserDeselectSelectionvalueToDeselect != null)
                {
                    browserDeselectSelection["ValueToDeselect"] = ExpressionConverter.ConvertO(__workflow_browserDeselectSelectionvalueToDeselect);
                    browserDeselectSelectionpropCount++;
                }

                if (__workflow_browserDeselectSelectiontextToDeselect != null)
                {
                    browserDeselectSelection["TextToDeselect"] = ExpressionConverter.ConvertO(__workflow_browserDeselectSelectiontextToDeselect);
                    browserDeselectSelectionpropCount++;
                }

                if (__workflow_browserDeselectSelectionindexToDeselect != null)
                {
                    if (__workflow_browserDeselectSelectionindexToDeselect != null)
                    {
                        browserDeselectSelection["IndexToDeselect"] = ExpressionConverter.ConvertO(__workflow_browserDeselectSelectionindexToDeselect);
                        browserDeselectSelectionpropCount++;
                    }

                    browserDeselectSelectionpropCount++;
                }
                else
                {
                    browserDeselectSelection["IndexToDeselect"] = 1;
                    browserDeselectSelectionpropCount++;
                }

                browserDeselectSelectionpropCount++;
                browserDeselectSelection["Workflow"] = ExpressionConverter.ConvertO(__workflow_browserDeselectSelectionworkflow);
                if (browserDeselectSelectionpropCount > 0)
                {
                    callPayload.Body = browserDeselectSelection;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserDeselectAllSelection(Expression<Func<string>> browserDeselectAllSelectionworkflow, Expression<Func<double>> browserDeselectAllSelectionparentElementHandle = null, Expression<Func<double>> browserDeselectAllSelectionsearchElementHandle = null, Expression<Func<string>> browserDeselectAllSelectionsearchElementName = null, Expression<Func<string>> browserDeselectAllSelectionsearchElementID = null, Expression<Func<string>> browserDeselectAllSelectionsearchElementTagName = null, Expression<Func<string>> browserDeselectAllSelectionsearchElementXPath = null, Expression<Func<string>> browserDeselectAllSelectionsearchElementClassName = null, Expression<Func<string>> browserDeselectAllSelectionsearchElementCSSSelector = null, Expression<Func<double>> browserDeselectAllSelectionsearchElementIndex = null, Expression<Func<string>> browserDeselectAllSelectionsearchElementMatchValue = null, Expression<Func<string>> browserDeselectAllSelectionsearchElementMatchText = null, Expression<Func<string>> browserDeselectAllSelectionsearchElementType = null, Expression<Func<double>> browserDeselectAllSelectionsearchElementMinimumWidth = null, Expression<Func<double>> browserDeselectAllSelectionsearchElementMinimumHeight = null, Expression<Func<double>> browserDeselectAllSelectionsearchElementBoundingBoxLeft = null, Expression<Func<double>> browserDeselectAllSelectionsearchElementBoundingBoxRight = null, Expression<Func<double>> browserDeselectAllSelectionsearchElementBoundingBoxTop = null, Expression<Func<double>> browserDeselectAllSelectionsearchElementBoundingBoxBottom = null, Expression<Func<bool>> browserDeselectAllSelectiononlyElementTopLeftNeedsToBeInBoundingBox = null)
        {
            var __workflow_browserDeselectAllSelectionworkflow = WorkflowExpression.Compile(browserDeselectAllSelectionworkflow, nameof(browserDeselectAllSelectionworkflow), required: true);
            var __workflow_browserDeselectAllSelectionparentElementHandle = WorkflowExpression.Compile(browserDeselectAllSelectionparentElementHandle, nameof(browserDeselectAllSelectionparentElementHandle), required: false);
            var __workflow_browserDeselectAllSelectionsearchElementHandle = WorkflowExpression.Compile(browserDeselectAllSelectionsearchElementHandle, nameof(browserDeselectAllSelectionsearchElementHandle), required: false);
            var __workflow_browserDeselectAllSelectionsearchElementName = WorkflowExpression.Compile(browserDeselectAllSelectionsearchElementName, nameof(browserDeselectAllSelectionsearchElementName), required: false);
            var __workflow_browserDeselectAllSelectionsearchElementID = WorkflowExpression.Compile(browserDeselectAllSelectionsearchElementID, nameof(browserDeselectAllSelectionsearchElementID), required: false);
            var __workflow_browserDeselectAllSelectionsearchElementTagName = WorkflowExpression.Compile(browserDeselectAllSelectionsearchElementTagName, nameof(browserDeselectAllSelectionsearchElementTagName), required: false);
            var __workflow_browserDeselectAllSelectionsearchElementXPath = WorkflowExpression.Compile(browserDeselectAllSelectionsearchElementXPath, nameof(browserDeselectAllSelectionsearchElementXPath), required: false);
            var __workflow_browserDeselectAllSelectionsearchElementClassName = WorkflowExpression.Compile(browserDeselectAllSelectionsearchElementClassName, nameof(browserDeselectAllSelectionsearchElementClassName), required: false);
            var __workflow_browserDeselectAllSelectionsearchElementCSSSelector = WorkflowExpression.Compile(browserDeselectAllSelectionsearchElementCSSSelector, nameof(browserDeselectAllSelectionsearchElementCSSSelector), required: false);
            var __workflow_browserDeselectAllSelectionsearchElementIndex = WorkflowExpression.Compile(browserDeselectAllSelectionsearchElementIndex, nameof(browserDeselectAllSelectionsearchElementIndex), required: false);
            var __workflow_browserDeselectAllSelectionsearchElementMatchValue = WorkflowExpression.Compile(browserDeselectAllSelectionsearchElementMatchValue, nameof(browserDeselectAllSelectionsearchElementMatchValue), required: false);
            var __workflow_browserDeselectAllSelectionsearchElementMatchText = WorkflowExpression.Compile(browserDeselectAllSelectionsearchElementMatchText, nameof(browserDeselectAllSelectionsearchElementMatchText), required: false);
            var __workflow_browserDeselectAllSelectionsearchElementType = WorkflowExpression.Compile(browserDeselectAllSelectionsearchElementType, nameof(browserDeselectAllSelectionsearchElementType), required: false);
            var __workflow_browserDeselectAllSelectionsearchElementMinimumWidth = WorkflowExpression.Compile(browserDeselectAllSelectionsearchElementMinimumWidth, nameof(browserDeselectAllSelectionsearchElementMinimumWidth), required: false);
            var __workflow_browserDeselectAllSelectionsearchElementMinimumHeight = WorkflowExpression.Compile(browserDeselectAllSelectionsearchElementMinimumHeight, nameof(browserDeselectAllSelectionsearchElementMinimumHeight), required: false);
            var __workflow_browserDeselectAllSelectionsearchElementBoundingBoxLeft = WorkflowExpression.Compile(browserDeselectAllSelectionsearchElementBoundingBoxLeft, nameof(browserDeselectAllSelectionsearchElementBoundingBoxLeft), required: false);
            var __workflow_browserDeselectAllSelectionsearchElementBoundingBoxRight = WorkflowExpression.Compile(browserDeselectAllSelectionsearchElementBoundingBoxRight, nameof(browserDeselectAllSelectionsearchElementBoundingBoxRight), required: false);
            var __workflow_browserDeselectAllSelectionsearchElementBoundingBoxTop = WorkflowExpression.Compile(browserDeselectAllSelectionsearchElementBoundingBoxTop, nameof(browserDeselectAllSelectionsearchElementBoundingBoxTop), required: false);
            var __workflow_browserDeselectAllSelectionsearchElementBoundingBoxBottom = WorkflowExpression.Compile(browserDeselectAllSelectionsearchElementBoundingBoxBottom, nameof(browserDeselectAllSelectionsearchElementBoundingBoxBottom), required: false);
            var __workflow_browserDeselectAllSelectiononlyElementTopLeftNeedsToBeInBoundingBox = WorkflowExpression.Compile(browserDeselectAllSelectiononlyElementTopLeftNeedsToBeInBoundingBox, nameof(browserDeselectAllSelectiononlyElementTopLeftNeedsToBeInBoundingBox), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/BrowserControl/DeselectAllSelection";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserDeselectAllSelection = new JObject();
                var browserDeselectAllSelectionpropCount = 0;
                if (__workflow_browserDeselectAllSelectionparentElementHandle != null)
                {
                    browserDeselectAllSelection["ParentElementHandle"] = ExpressionConverter.ConvertO(__workflow_browserDeselectAllSelectionparentElementHandle);
                    browserDeselectAllSelectionpropCount++;
                }

                if (__workflow_browserDeselectAllSelectionsearchElementHandle != null)
                {
                    browserDeselectAllSelection["SearchElementHandle"] = ExpressionConverter.ConvertO(__workflow_browserDeselectAllSelectionsearchElementHandle);
                    browserDeselectAllSelectionpropCount++;
                }

                if (__workflow_browserDeselectAllSelectionsearchElementName != null)
                {
                    browserDeselectAllSelection["SearchElementName"] = ExpressionConverter.ConvertO(__workflow_browserDeselectAllSelectionsearchElementName);
                    browserDeselectAllSelectionpropCount++;
                }

                if (__workflow_browserDeselectAllSelectionsearchElementID != null)
                {
                    browserDeselectAllSelection["SearchElementID"] = ExpressionConverter.ConvertO(__workflow_browserDeselectAllSelectionsearchElementID);
                    browserDeselectAllSelectionpropCount++;
                }

                if (__workflow_browserDeselectAllSelectionsearchElementTagName != null)
                {
                    browserDeselectAllSelection["SearchElementTagName"] = ExpressionConverter.ConvertO(__workflow_browserDeselectAllSelectionsearchElementTagName);
                    browserDeselectAllSelectionpropCount++;
                }

                if (__workflow_browserDeselectAllSelectionsearchElementXPath != null)
                {
                    browserDeselectAllSelection["SearchElementXPath"] = ExpressionConverter.ConvertO(__workflow_browserDeselectAllSelectionsearchElementXPath);
                    browserDeselectAllSelectionpropCount++;
                }

                if (__workflow_browserDeselectAllSelectionsearchElementClassName != null)
                {
                    browserDeselectAllSelection["SearchElementClassName"] = ExpressionConverter.ConvertO(__workflow_browserDeselectAllSelectionsearchElementClassName);
                    browserDeselectAllSelectionpropCount++;
                }

                if (__workflow_browserDeselectAllSelectionsearchElementCSSSelector != null)
                {
                    browserDeselectAllSelection["SearchElementCSSSelector"] = ExpressionConverter.ConvertO(__workflow_browserDeselectAllSelectionsearchElementCSSSelector);
                    browserDeselectAllSelectionpropCount++;
                }

                if (__workflow_browserDeselectAllSelectionsearchElementIndex != null)
                {
                    if (__workflow_browserDeselectAllSelectionsearchElementIndex != null)
                    {
                        browserDeselectAllSelection["SearchElementIndex"] = ExpressionConverter.ConvertO(__workflow_browserDeselectAllSelectionsearchElementIndex);
                        browserDeselectAllSelectionpropCount++;
                    }

                    browserDeselectAllSelectionpropCount++;
                }
                else
                {
                    browserDeselectAllSelection["SearchElementIndex"] = 1;
                    browserDeselectAllSelectionpropCount++;
                }

                if (__workflow_browserDeselectAllSelectionsearchElementMatchValue != null)
                {
                    browserDeselectAllSelection["SearchElementMatchValue"] = ExpressionConverter.ConvertO(__workflow_browserDeselectAllSelectionsearchElementMatchValue);
                    browserDeselectAllSelectionpropCount++;
                }

                if (__workflow_browserDeselectAllSelectionsearchElementMatchText != null)
                {
                    browserDeselectAllSelection["SearchElementMatchText"] = ExpressionConverter.ConvertO(__workflow_browserDeselectAllSelectionsearchElementMatchText);
                    browserDeselectAllSelectionpropCount++;
                }

                if (__workflow_browserDeselectAllSelectionsearchElementType != null)
                {
                    browserDeselectAllSelection["SearchElementType"] = ExpressionConverter.ConvertO(__workflow_browserDeselectAllSelectionsearchElementType);
                    browserDeselectAllSelectionpropCount++;
                }

                if (__workflow_browserDeselectAllSelectionsearchElementMinimumWidth != null)
                {
                    if (__workflow_browserDeselectAllSelectionsearchElementMinimumWidth != null)
                    {
                        browserDeselectAllSelection["SearchElementMinimumWidth"] = ExpressionConverter.ConvertO(__workflow_browserDeselectAllSelectionsearchElementMinimumWidth);
                        browserDeselectAllSelectionpropCount++;
                    }

                    browserDeselectAllSelectionpropCount++;
                }
                else
                {
                    browserDeselectAllSelection["SearchElementMinimumWidth"] = 1;
                    browserDeselectAllSelectionpropCount++;
                }

                if (__workflow_browserDeselectAllSelectionsearchElementMinimumHeight != null)
                {
                    if (__workflow_browserDeselectAllSelectionsearchElementMinimumHeight != null)
                    {
                        browserDeselectAllSelection["SearchElementMinimumHeight"] = ExpressionConverter.ConvertO(__workflow_browserDeselectAllSelectionsearchElementMinimumHeight);
                        browserDeselectAllSelectionpropCount++;
                    }

                    browserDeselectAllSelectionpropCount++;
                }
                else
                {
                    browserDeselectAllSelection["SearchElementMinimumHeight"] = 1;
                    browserDeselectAllSelectionpropCount++;
                }

                if (__workflow_browserDeselectAllSelectionsearchElementBoundingBoxLeft != null)
                {
                    if (__workflow_browserDeselectAllSelectionsearchElementBoundingBoxLeft != null)
                    {
                        browserDeselectAllSelection["SearchElementBoundingBoxLeft"] = ExpressionConverter.ConvertO(__workflow_browserDeselectAllSelectionsearchElementBoundingBoxLeft);
                        browserDeselectAllSelectionpropCount++;
                    }

                    browserDeselectAllSelectionpropCount++;
                }
                else
                {
                    browserDeselectAllSelection["SearchElementBoundingBoxLeft"] = -99999;
                    browserDeselectAllSelectionpropCount++;
                }

                if (__workflow_browserDeselectAllSelectionsearchElementBoundingBoxRight != null)
                {
                    if (__workflow_browserDeselectAllSelectionsearchElementBoundingBoxRight != null)
                    {
                        browserDeselectAllSelection["SearchElementBoundingBoxRight"] = ExpressionConverter.ConvertO(__workflow_browserDeselectAllSelectionsearchElementBoundingBoxRight);
                        browserDeselectAllSelectionpropCount++;
                    }

                    browserDeselectAllSelectionpropCount++;
                }
                else
                {
                    browserDeselectAllSelection["SearchElementBoundingBoxRight"] = 99999;
                    browserDeselectAllSelectionpropCount++;
                }

                if (__workflow_browserDeselectAllSelectionsearchElementBoundingBoxTop != null)
                {
                    if (__workflow_browserDeselectAllSelectionsearchElementBoundingBoxTop != null)
                    {
                        browserDeselectAllSelection["SearchElementBoundingBoxTop"] = ExpressionConverter.ConvertO(__workflow_browserDeselectAllSelectionsearchElementBoundingBoxTop);
                        browserDeselectAllSelectionpropCount++;
                    }

                    browserDeselectAllSelectionpropCount++;
                }
                else
                {
                    browserDeselectAllSelection["SearchElementBoundingBoxTop"] = -99999;
                    browserDeselectAllSelectionpropCount++;
                }

                if (__workflow_browserDeselectAllSelectionsearchElementBoundingBoxBottom != null)
                {
                    if (__workflow_browserDeselectAllSelectionsearchElementBoundingBoxBottom != null)
                    {
                        browserDeselectAllSelection["SearchElementBoundingBoxBottom"] = ExpressionConverter.ConvertO(__workflow_browserDeselectAllSelectionsearchElementBoundingBoxBottom);
                        browserDeselectAllSelectionpropCount++;
                    }

                    browserDeselectAllSelectionpropCount++;
                }
                else
                {
                    browserDeselectAllSelection["SearchElementBoundingBoxBottom"] = 99999;
                    browserDeselectAllSelectionpropCount++;
                }

                if (__workflow_browserDeselectAllSelectiononlyElementTopLeftNeedsToBeInBoundingBox != null)
                {
                    if (__workflow_browserDeselectAllSelectiononlyElementTopLeftNeedsToBeInBoundingBox != null)
                    {
                        browserDeselectAllSelection["OnlyElementTopLeftNeedsToBeInBoundingBox"] = ExpressionConverter.ConvertO(__workflow_browserDeselectAllSelectiononlyElementTopLeftNeedsToBeInBoundingBox);
                        browserDeselectAllSelectionpropCount++;
                    }

                    browserDeselectAllSelectionpropCount++;
                }
                else
                {
                    browserDeselectAllSelection["OnlyElementTopLeftNeedsToBeInBoundingBox"] = false;
                    browserDeselectAllSelectionpropCount++;
                }

                browserDeselectAllSelectionpropCount++;
                browserDeselectAllSelection["Workflow"] = ExpressionConverter.ConvertO(__workflow_browserDeselectAllSelectionworkflow);
                if (browserDeselectAllSelectionpropCount > 0)
                {
                    callPayload.Body = browserDeselectAllSelection;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserGetTableContentsResponse> BrowserGetTableContents(Expression<Func<string>> browserGetTableContentsworkflow, Expression<Func<double>> browserGetTableContentsparentElementHandle = null, Expression<Func<double>> browserGetTableContentssearchElementHandle = null, Expression<Func<string>> browserGetTableContentssearchElementName = null, Expression<Func<string>> browserGetTableContentssearchElementID = null, Expression<Func<string>> browserGetTableContentssearchElementTagName = null, Expression<Func<string>> browserGetTableContentssearchElementXPath = null, Expression<Func<string>> browserGetTableContentssearchElementClassName = null, Expression<Func<string>> browserGetTableContentssearchElementCSSSelector = null, Expression<Func<double>> browserGetTableContentssearchElementIndex = null, Expression<Func<string>> browserGetTableContentssearchElementMatchValue = null, Expression<Func<string>> browserGetTableContentssearchElementMatchText = null, Expression<Func<string>> browserGetTableContentssearchElementType = null, Expression<Func<double>> browserGetTableContentssearchElementMinimumWidth = null, Expression<Func<double>> browserGetTableContentssearchElementMinimumHeight = null, Expression<Func<double>> browserGetTableContentssearchElementBoundingBoxLeft = null, Expression<Func<double>> browserGetTableContentssearchElementBoundingBoxRight = null, Expression<Func<double>> browserGetTableContentssearchElementBoundingBoxTop = null, Expression<Func<double>> browserGetTableContentssearchElementBoundingBoxBottom = null, Expression<Func<bool>> browserGetTableContentsonlyElementTopLeftNeedsToBeInBoundingBox = null, Expression<Func<double>> browserGetTableContentscreateColumnNamesFromRow = null, Expression<Func<bool>> browserGetTableContentsmergeChildTables = null)
        {
            var __workflow_browserGetTableContentsworkflow = WorkflowExpression.Compile(browserGetTableContentsworkflow, nameof(browserGetTableContentsworkflow), required: true);
            var __workflow_browserGetTableContentsparentElementHandle = WorkflowExpression.Compile(browserGetTableContentsparentElementHandle, nameof(browserGetTableContentsparentElementHandle), required: false);
            var __workflow_browserGetTableContentssearchElementHandle = WorkflowExpression.Compile(browserGetTableContentssearchElementHandle, nameof(browserGetTableContentssearchElementHandle), required: false);
            var __workflow_browserGetTableContentssearchElementName = WorkflowExpression.Compile(browserGetTableContentssearchElementName, nameof(browserGetTableContentssearchElementName), required: false);
            var __workflow_browserGetTableContentssearchElementID = WorkflowExpression.Compile(browserGetTableContentssearchElementID, nameof(browserGetTableContentssearchElementID), required: false);
            var __workflow_browserGetTableContentssearchElementTagName = WorkflowExpression.Compile(browserGetTableContentssearchElementTagName, nameof(browserGetTableContentssearchElementTagName), required: false);
            var __workflow_browserGetTableContentssearchElementXPath = WorkflowExpression.Compile(browserGetTableContentssearchElementXPath, nameof(browserGetTableContentssearchElementXPath), required: false);
            var __workflow_browserGetTableContentssearchElementClassName = WorkflowExpression.Compile(browserGetTableContentssearchElementClassName, nameof(browserGetTableContentssearchElementClassName), required: false);
            var __workflow_browserGetTableContentssearchElementCSSSelector = WorkflowExpression.Compile(browserGetTableContentssearchElementCSSSelector, nameof(browserGetTableContentssearchElementCSSSelector), required: false);
            var __workflow_browserGetTableContentssearchElementIndex = WorkflowExpression.Compile(browserGetTableContentssearchElementIndex, nameof(browserGetTableContentssearchElementIndex), required: false);
            var __workflow_browserGetTableContentssearchElementMatchValue = WorkflowExpression.Compile(browserGetTableContentssearchElementMatchValue, nameof(browserGetTableContentssearchElementMatchValue), required: false);
            var __workflow_browserGetTableContentssearchElementMatchText = WorkflowExpression.Compile(browserGetTableContentssearchElementMatchText, nameof(browserGetTableContentssearchElementMatchText), required: false);
            var __workflow_browserGetTableContentssearchElementType = WorkflowExpression.Compile(browserGetTableContentssearchElementType, nameof(browserGetTableContentssearchElementType), required: false);
            var __workflow_browserGetTableContentssearchElementMinimumWidth = WorkflowExpression.Compile(browserGetTableContentssearchElementMinimumWidth, nameof(browserGetTableContentssearchElementMinimumWidth), required: false);
            var __workflow_browserGetTableContentssearchElementMinimumHeight = WorkflowExpression.Compile(browserGetTableContentssearchElementMinimumHeight, nameof(browserGetTableContentssearchElementMinimumHeight), required: false);
            var __workflow_browserGetTableContentssearchElementBoundingBoxLeft = WorkflowExpression.Compile(browserGetTableContentssearchElementBoundingBoxLeft, nameof(browserGetTableContentssearchElementBoundingBoxLeft), required: false);
            var __workflow_browserGetTableContentssearchElementBoundingBoxRight = WorkflowExpression.Compile(browserGetTableContentssearchElementBoundingBoxRight, nameof(browserGetTableContentssearchElementBoundingBoxRight), required: false);
            var __workflow_browserGetTableContentssearchElementBoundingBoxTop = WorkflowExpression.Compile(browserGetTableContentssearchElementBoundingBoxTop, nameof(browserGetTableContentssearchElementBoundingBoxTop), required: false);
            var __workflow_browserGetTableContentssearchElementBoundingBoxBottom = WorkflowExpression.Compile(browserGetTableContentssearchElementBoundingBoxBottom, nameof(browserGetTableContentssearchElementBoundingBoxBottom), required: false);
            var __workflow_browserGetTableContentsonlyElementTopLeftNeedsToBeInBoundingBox = WorkflowExpression.Compile(browserGetTableContentsonlyElementTopLeftNeedsToBeInBoundingBox, nameof(browserGetTableContentsonlyElementTopLeftNeedsToBeInBoundingBox), required: false);
            var __workflow_browserGetTableContentscreateColumnNamesFromRow = WorkflowExpression.Compile(browserGetTableContentscreateColumnNamesFromRow, nameof(browserGetTableContentscreateColumnNamesFromRow), required: false);
            var __workflow_browserGetTableContentsmergeChildTables = WorkflowExpression.Compile(browserGetTableContentsmergeChildTables, nameof(browserGetTableContentsmergeChildTables), required: false);
            return new DeferredBodyAction<BrowserGetTableContentsResponse>(() =>
            {
                var apiCallPath = "/BrowserControl/GetTableContents";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserGetTableContents = new JObject();
                var browserGetTableContentspropCount = 0;
                if (__workflow_browserGetTableContentsparentElementHandle != null)
                {
                    browserGetTableContents["ParentElementHandle"] = ExpressionConverter.ConvertO(__workflow_browserGetTableContentsparentElementHandle);
                    browserGetTableContentspropCount++;
                }

                if (__workflow_browserGetTableContentssearchElementHandle != null)
                {
                    browserGetTableContents["SearchElementHandle"] = ExpressionConverter.ConvertO(__workflow_browserGetTableContentssearchElementHandle);
                    browserGetTableContentspropCount++;
                }

                if (__workflow_browserGetTableContentssearchElementName != null)
                {
                    browserGetTableContents["SearchElementName"] = ExpressionConverter.ConvertO(__workflow_browserGetTableContentssearchElementName);
                    browserGetTableContentspropCount++;
                }

                if (__workflow_browserGetTableContentssearchElementID != null)
                {
                    browserGetTableContents["SearchElementID"] = ExpressionConverter.ConvertO(__workflow_browserGetTableContentssearchElementID);
                    browserGetTableContentspropCount++;
                }

                if (__workflow_browserGetTableContentssearchElementTagName != null)
                {
                    browserGetTableContents["SearchElementTagName"] = ExpressionConverter.ConvertO(__workflow_browserGetTableContentssearchElementTagName);
                    browserGetTableContentspropCount++;
                }

                if (__workflow_browserGetTableContentssearchElementXPath != null)
                {
                    browserGetTableContents["SearchElementXPath"] = ExpressionConverter.ConvertO(__workflow_browserGetTableContentssearchElementXPath);
                    browserGetTableContentspropCount++;
                }

                if (__workflow_browserGetTableContentssearchElementClassName != null)
                {
                    browserGetTableContents["SearchElementClassName"] = ExpressionConverter.ConvertO(__workflow_browserGetTableContentssearchElementClassName);
                    browserGetTableContentspropCount++;
                }

                if (__workflow_browserGetTableContentssearchElementCSSSelector != null)
                {
                    browserGetTableContents["SearchElementCSSSelector"] = ExpressionConverter.ConvertO(__workflow_browserGetTableContentssearchElementCSSSelector);
                    browserGetTableContentspropCount++;
                }

                if (__workflow_browserGetTableContentssearchElementIndex != null)
                {
                    if (__workflow_browserGetTableContentssearchElementIndex != null)
                    {
                        browserGetTableContents["SearchElementIndex"] = ExpressionConverter.ConvertO(__workflow_browserGetTableContentssearchElementIndex);
                        browserGetTableContentspropCount++;
                    }

                    browserGetTableContentspropCount++;
                }
                else
                {
                    browserGetTableContents["SearchElementIndex"] = 1;
                    browserGetTableContentspropCount++;
                }

                if (__workflow_browserGetTableContentssearchElementMatchValue != null)
                {
                    browserGetTableContents["SearchElementMatchValue"] = ExpressionConverter.ConvertO(__workflow_browserGetTableContentssearchElementMatchValue);
                    browserGetTableContentspropCount++;
                }

                if (__workflow_browserGetTableContentssearchElementMatchText != null)
                {
                    browserGetTableContents["SearchElementMatchText"] = ExpressionConverter.ConvertO(__workflow_browserGetTableContentssearchElementMatchText);
                    browserGetTableContentspropCount++;
                }

                if (__workflow_browserGetTableContentssearchElementType != null)
                {
                    browserGetTableContents["SearchElementType"] = ExpressionConverter.ConvertO(__workflow_browserGetTableContentssearchElementType);
                    browserGetTableContentspropCount++;
                }

                if (__workflow_browserGetTableContentssearchElementMinimumWidth != null)
                {
                    if (__workflow_browserGetTableContentssearchElementMinimumWidth != null)
                    {
                        browserGetTableContents["SearchElementMinimumWidth"] = ExpressionConverter.ConvertO(__workflow_browserGetTableContentssearchElementMinimumWidth);
                        browserGetTableContentspropCount++;
                    }

                    browserGetTableContentspropCount++;
                }
                else
                {
                    browserGetTableContents["SearchElementMinimumWidth"] = 1;
                    browserGetTableContentspropCount++;
                }

                if (__workflow_browserGetTableContentssearchElementMinimumHeight != null)
                {
                    if (__workflow_browserGetTableContentssearchElementMinimumHeight != null)
                    {
                        browserGetTableContents["SearchElementMinimumHeight"] = ExpressionConverter.ConvertO(__workflow_browserGetTableContentssearchElementMinimumHeight);
                        browserGetTableContentspropCount++;
                    }

                    browserGetTableContentspropCount++;
                }
                else
                {
                    browserGetTableContents["SearchElementMinimumHeight"] = 1;
                    browserGetTableContentspropCount++;
                }

                if (__workflow_browserGetTableContentssearchElementBoundingBoxLeft != null)
                {
                    if (__workflow_browserGetTableContentssearchElementBoundingBoxLeft != null)
                    {
                        browserGetTableContents["SearchElementBoundingBoxLeft"] = ExpressionConverter.ConvertO(__workflow_browserGetTableContentssearchElementBoundingBoxLeft);
                        browserGetTableContentspropCount++;
                    }

                    browserGetTableContentspropCount++;
                }
                else
                {
                    browserGetTableContents["SearchElementBoundingBoxLeft"] = -99999;
                    browserGetTableContentspropCount++;
                }

                if (__workflow_browserGetTableContentssearchElementBoundingBoxRight != null)
                {
                    if (__workflow_browserGetTableContentssearchElementBoundingBoxRight != null)
                    {
                        browserGetTableContents["SearchElementBoundingBoxRight"] = ExpressionConverter.ConvertO(__workflow_browserGetTableContentssearchElementBoundingBoxRight);
                        browserGetTableContentspropCount++;
                    }

                    browserGetTableContentspropCount++;
                }
                else
                {
                    browserGetTableContents["SearchElementBoundingBoxRight"] = 99999;
                    browserGetTableContentspropCount++;
                }

                if (__workflow_browserGetTableContentssearchElementBoundingBoxTop != null)
                {
                    if (__workflow_browserGetTableContentssearchElementBoundingBoxTop != null)
                    {
                        browserGetTableContents["SearchElementBoundingBoxTop"] = ExpressionConverter.ConvertO(__workflow_browserGetTableContentssearchElementBoundingBoxTop);
                        browserGetTableContentspropCount++;
                    }

                    browserGetTableContentspropCount++;
                }
                else
                {
                    browserGetTableContents["SearchElementBoundingBoxTop"] = -99999;
                    browserGetTableContentspropCount++;
                }

                if (__workflow_browserGetTableContentssearchElementBoundingBoxBottom != null)
                {
                    if (__workflow_browserGetTableContentssearchElementBoundingBoxBottom != null)
                    {
                        browserGetTableContents["SearchElementBoundingBoxBottom"] = ExpressionConverter.ConvertO(__workflow_browserGetTableContentssearchElementBoundingBoxBottom);
                        browserGetTableContentspropCount++;
                    }

                    browserGetTableContentspropCount++;
                }
                else
                {
                    browserGetTableContents["SearchElementBoundingBoxBottom"] = 99999;
                    browserGetTableContentspropCount++;
                }

                if (__workflow_browserGetTableContentsonlyElementTopLeftNeedsToBeInBoundingBox != null)
                {
                    if (__workflow_browserGetTableContentsonlyElementTopLeftNeedsToBeInBoundingBox != null)
                    {
                        browserGetTableContents["OnlyElementTopLeftNeedsToBeInBoundingBox"] = ExpressionConverter.ConvertO(__workflow_browserGetTableContentsonlyElementTopLeftNeedsToBeInBoundingBox);
                        browserGetTableContentspropCount++;
                    }

                    browserGetTableContentspropCount++;
                }
                else
                {
                    browserGetTableContents["OnlyElementTopLeftNeedsToBeInBoundingBox"] = false;
                    browserGetTableContentspropCount++;
                }

                if (__workflow_browserGetTableContentscreateColumnNamesFromRow != null)
                {
                    if (__workflow_browserGetTableContentscreateColumnNamesFromRow != null)
                    {
                        browserGetTableContents["CreateColumnNamesFromRow"] = ExpressionConverter.ConvertO(__workflow_browserGetTableContentscreateColumnNamesFromRow);
                        browserGetTableContentspropCount++;
                    }

                    browserGetTableContentspropCount++;
                }
                else
                {
                    browserGetTableContents["CreateColumnNamesFromRow"] = 0;
                    browserGetTableContentspropCount++;
                }

                if (__workflow_browserGetTableContentsmergeChildTables != null)
                {
                    if (__workflow_browserGetTableContentsmergeChildTables != null)
                    {
                        browserGetTableContents["MergeChildTables"] = ExpressionConverter.ConvertO(__workflow_browserGetTableContentsmergeChildTables);
                        browserGetTableContentspropCount++;
                    }

                    browserGetTableContentspropCount++;
                }
                else
                {
                    browserGetTableContents["MergeChildTables"] = false;
                    browserGetTableContentspropCount++;
                }

                browserGetTableContents["ReturnAsDataTable"] = true;
                browserGetTableContentspropCount++;
                browserGetTableContentspropCount++;
                browserGetTableContents["Workflow"] = ExpressionConverter.ConvertO(__workflow_browserGetTableContentsworkflow);
                if (browserGetTableContentspropCount > 0)
                {
                    callPayload.Body = browserGetTableContents;
                }

                return new ApiConnectionAction<BrowserGetTableContentsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserScrollElementIntoView(Expression<Func<string>> browserScrollElementIntoViewworkflow, Expression<Func<double>> browserScrollElementIntoViewparentElementHandle = null, Expression<Func<double>> browserScrollElementIntoViewsearchElementHandle = null, Expression<Func<string>> browserScrollElementIntoViewsearchElementName = null, Expression<Func<string>> browserScrollElementIntoViewsearchElementID = null, Expression<Func<string>> browserScrollElementIntoViewsearchElementTagName = null, Expression<Func<string>> browserScrollElementIntoViewsearchElementXPath = null, Expression<Func<string>> browserScrollElementIntoViewsearchElementClassName = null, Expression<Func<string>> browserScrollElementIntoViewsearchElementCSSSelector = null, Expression<Func<double>> browserScrollElementIntoViewsearchElementIndex = null, Expression<Func<string>> browserScrollElementIntoViewsearchElementMatchValue = null, Expression<Func<string>> browserScrollElementIntoViewsearchElementMatchText = null, Expression<Func<string>> browserScrollElementIntoViewsearchElementType = null, Expression<Func<double>> browserScrollElementIntoViewsearchElementMinimumWidth = null, Expression<Func<double>> browserScrollElementIntoViewsearchElementMinimumHeight = null, Expression<Func<double>> browserScrollElementIntoViewsearchElementBoundingBoxLeft = null, Expression<Func<double>> browserScrollElementIntoViewsearchElementBoundingBoxRight = null, Expression<Func<double>> browserScrollElementIntoViewsearchElementBoundingBoxTop = null, Expression<Func<double>> browserScrollElementIntoViewsearchElementBoundingBoxBottom = null, Expression<Func<bool>> browserScrollElementIntoViewonlyElementTopLeftNeedsToBeInBoundingBox = null)
        {
            var __workflow_browserScrollElementIntoViewworkflow = WorkflowExpression.Compile(browserScrollElementIntoViewworkflow, nameof(browserScrollElementIntoViewworkflow), required: true);
            var __workflow_browserScrollElementIntoViewparentElementHandle = WorkflowExpression.Compile(browserScrollElementIntoViewparentElementHandle, nameof(browserScrollElementIntoViewparentElementHandle), required: false);
            var __workflow_browserScrollElementIntoViewsearchElementHandle = WorkflowExpression.Compile(browserScrollElementIntoViewsearchElementHandle, nameof(browserScrollElementIntoViewsearchElementHandle), required: false);
            var __workflow_browserScrollElementIntoViewsearchElementName = WorkflowExpression.Compile(browserScrollElementIntoViewsearchElementName, nameof(browserScrollElementIntoViewsearchElementName), required: false);
            var __workflow_browserScrollElementIntoViewsearchElementID = WorkflowExpression.Compile(browserScrollElementIntoViewsearchElementID, nameof(browserScrollElementIntoViewsearchElementID), required: false);
            var __workflow_browserScrollElementIntoViewsearchElementTagName = WorkflowExpression.Compile(browserScrollElementIntoViewsearchElementTagName, nameof(browserScrollElementIntoViewsearchElementTagName), required: false);
            var __workflow_browserScrollElementIntoViewsearchElementXPath = WorkflowExpression.Compile(browserScrollElementIntoViewsearchElementXPath, nameof(browserScrollElementIntoViewsearchElementXPath), required: false);
            var __workflow_browserScrollElementIntoViewsearchElementClassName = WorkflowExpression.Compile(browserScrollElementIntoViewsearchElementClassName, nameof(browserScrollElementIntoViewsearchElementClassName), required: false);
            var __workflow_browserScrollElementIntoViewsearchElementCSSSelector = WorkflowExpression.Compile(browserScrollElementIntoViewsearchElementCSSSelector, nameof(browserScrollElementIntoViewsearchElementCSSSelector), required: false);
            var __workflow_browserScrollElementIntoViewsearchElementIndex = WorkflowExpression.Compile(browserScrollElementIntoViewsearchElementIndex, nameof(browserScrollElementIntoViewsearchElementIndex), required: false);
            var __workflow_browserScrollElementIntoViewsearchElementMatchValue = WorkflowExpression.Compile(browserScrollElementIntoViewsearchElementMatchValue, nameof(browserScrollElementIntoViewsearchElementMatchValue), required: false);
            var __workflow_browserScrollElementIntoViewsearchElementMatchText = WorkflowExpression.Compile(browserScrollElementIntoViewsearchElementMatchText, nameof(browserScrollElementIntoViewsearchElementMatchText), required: false);
            var __workflow_browserScrollElementIntoViewsearchElementType = WorkflowExpression.Compile(browserScrollElementIntoViewsearchElementType, nameof(browserScrollElementIntoViewsearchElementType), required: false);
            var __workflow_browserScrollElementIntoViewsearchElementMinimumWidth = WorkflowExpression.Compile(browserScrollElementIntoViewsearchElementMinimumWidth, nameof(browserScrollElementIntoViewsearchElementMinimumWidth), required: false);
            var __workflow_browserScrollElementIntoViewsearchElementMinimumHeight = WorkflowExpression.Compile(browserScrollElementIntoViewsearchElementMinimumHeight, nameof(browserScrollElementIntoViewsearchElementMinimumHeight), required: false);
            var __workflow_browserScrollElementIntoViewsearchElementBoundingBoxLeft = WorkflowExpression.Compile(browserScrollElementIntoViewsearchElementBoundingBoxLeft, nameof(browserScrollElementIntoViewsearchElementBoundingBoxLeft), required: false);
            var __workflow_browserScrollElementIntoViewsearchElementBoundingBoxRight = WorkflowExpression.Compile(browserScrollElementIntoViewsearchElementBoundingBoxRight, nameof(browserScrollElementIntoViewsearchElementBoundingBoxRight), required: false);
            var __workflow_browserScrollElementIntoViewsearchElementBoundingBoxTop = WorkflowExpression.Compile(browserScrollElementIntoViewsearchElementBoundingBoxTop, nameof(browserScrollElementIntoViewsearchElementBoundingBoxTop), required: false);
            var __workflow_browserScrollElementIntoViewsearchElementBoundingBoxBottom = WorkflowExpression.Compile(browserScrollElementIntoViewsearchElementBoundingBoxBottom, nameof(browserScrollElementIntoViewsearchElementBoundingBoxBottom), required: false);
            var __workflow_browserScrollElementIntoViewonlyElementTopLeftNeedsToBeInBoundingBox = WorkflowExpression.Compile(browserScrollElementIntoViewonlyElementTopLeftNeedsToBeInBoundingBox, nameof(browserScrollElementIntoViewonlyElementTopLeftNeedsToBeInBoundingBox), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/BrowserControl/ScrollElementIntoView";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserScrollElementIntoView = new JObject();
                var browserScrollElementIntoViewpropCount = 0;
                if (__workflow_browserScrollElementIntoViewparentElementHandle != null)
                {
                    browserScrollElementIntoView["ParentElementHandle"] = ExpressionConverter.ConvertO(__workflow_browserScrollElementIntoViewparentElementHandle);
                    browserScrollElementIntoViewpropCount++;
                }

                if (__workflow_browserScrollElementIntoViewsearchElementHandle != null)
                {
                    browserScrollElementIntoView["SearchElementHandle"] = ExpressionConverter.ConvertO(__workflow_browserScrollElementIntoViewsearchElementHandle);
                    browserScrollElementIntoViewpropCount++;
                }

                if (__workflow_browserScrollElementIntoViewsearchElementName != null)
                {
                    browserScrollElementIntoView["SearchElementName"] = ExpressionConverter.ConvertO(__workflow_browserScrollElementIntoViewsearchElementName);
                    browserScrollElementIntoViewpropCount++;
                }

                if (__workflow_browserScrollElementIntoViewsearchElementID != null)
                {
                    browserScrollElementIntoView["SearchElementID"] = ExpressionConverter.ConvertO(__workflow_browserScrollElementIntoViewsearchElementID);
                    browserScrollElementIntoViewpropCount++;
                }

                if (__workflow_browserScrollElementIntoViewsearchElementTagName != null)
                {
                    browserScrollElementIntoView["SearchElementTagName"] = ExpressionConverter.ConvertO(__workflow_browserScrollElementIntoViewsearchElementTagName);
                    browserScrollElementIntoViewpropCount++;
                }

                if (__workflow_browserScrollElementIntoViewsearchElementXPath != null)
                {
                    browserScrollElementIntoView["SearchElementXPath"] = ExpressionConverter.ConvertO(__workflow_browserScrollElementIntoViewsearchElementXPath);
                    browserScrollElementIntoViewpropCount++;
                }

                if (__workflow_browserScrollElementIntoViewsearchElementClassName != null)
                {
                    browserScrollElementIntoView["SearchElementClassName"] = ExpressionConverter.ConvertO(__workflow_browserScrollElementIntoViewsearchElementClassName);
                    browserScrollElementIntoViewpropCount++;
                }

                if (__workflow_browserScrollElementIntoViewsearchElementCSSSelector != null)
                {
                    browserScrollElementIntoView["SearchElementCSSSelector"] = ExpressionConverter.ConvertO(__workflow_browserScrollElementIntoViewsearchElementCSSSelector);
                    browserScrollElementIntoViewpropCount++;
                }

                if (__workflow_browserScrollElementIntoViewsearchElementIndex != null)
                {
                    if (__workflow_browserScrollElementIntoViewsearchElementIndex != null)
                    {
                        browserScrollElementIntoView["SearchElementIndex"] = ExpressionConverter.ConvertO(__workflow_browserScrollElementIntoViewsearchElementIndex);
                        browserScrollElementIntoViewpropCount++;
                    }

                    browserScrollElementIntoViewpropCount++;
                }
                else
                {
                    browserScrollElementIntoView["SearchElementIndex"] = 1;
                    browserScrollElementIntoViewpropCount++;
                }

                if (__workflow_browserScrollElementIntoViewsearchElementMatchValue != null)
                {
                    browserScrollElementIntoView["SearchElementMatchValue"] = ExpressionConverter.ConvertO(__workflow_browserScrollElementIntoViewsearchElementMatchValue);
                    browserScrollElementIntoViewpropCount++;
                }

                if (__workflow_browserScrollElementIntoViewsearchElementMatchText != null)
                {
                    browserScrollElementIntoView["SearchElementMatchText"] = ExpressionConverter.ConvertO(__workflow_browserScrollElementIntoViewsearchElementMatchText);
                    browserScrollElementIntoViewpropCount++;
                }

                if (__workflow_browserScrollElementIntoViewsearchElementType != null)
                {
                    browserScrollElementIntoView["SearchElementType"] = ExpressionConverter.ConvertO(__workflow_browserScrollElementIntoViewsearchElementType);
                    browserScrollElementIntoViewpropCount++;
                }

                if (__workflow_browserScrollElementIntoViewsearchElementMinimumWidth != null)
                {
                    if (__workflow_browserScrollElementIntoViewsearchElementMinimumWidth != null)
                    {
                        browserScrollElementIntoView["SearchElementMinimumWidth"] = ExpressionConverter.ConvertO(__workflow_browserScrollElementIntoViewsearchElementMinimumWidth);
                        browserScrollElementIntoViewpropCount++;
                    }

                    browserScrollElementIntoViewpropCount++;
                }
                else
                {
                    browserScrollElementIntoView["SearchElementMinimumWidth"] = 1;
                    browserScrollElementIntoViewpropCount++;
                }

                if (__workflow_browserScrollElementIntoViewsearchElementMinimumHeight != null)
                {
                    if (__workflow_browserScrollElementIntoViewsearchElementMinimumHeight != null)
                    {
                        browserScrollElementIntoView["SearchElementMinimumHeight"] = ExpressionConverter.ConvertO(__workflow_browserScrollElementIntoViewsearchElementMinimumHeight);
                        browserScrollElementIntoViewpropCount++;
                    }

                    browserScrollElementIntoViewpropCount++;
                }
                else
                {
                    browserScrollElementIntoView["SearchElementMinimumHeight"] = 1;
                    browserScrollElementIntoViewpropCount++;
                }

                if (__workflow_browserScrollElementIntoViewsearchElementBoundingBoxLeft != null)
                {
                    if (__workflow_browserScrollElementIntoViewsearchElementBoundingBoxLeft != null)
                    {
                        browserScrollElementIntoView["SearchElementBoundingBoxLeft"] = ExpressionConverter.ConvertO(__workflow_browserScrollElementIntoViewsearchElementBoundingBoxLeft);
                        browserScrollElementIntoViewpropCount++;
                    }

                    browserScrollElementIntoViewpropCount++;
                }
                else
                {
                    browserScrollElementIntoView["SearchElementBoundingBoxLeft"] = -99999;
                    browserScrollElementIntoViewpropCount++;
                }

                if (__workflow_browserScrollElementIntoViewsearchElementBoundingBoxRight != null)
                {
                    if (__workflow_browserScrollElementIntoViewsearchElementBoundingBoxRight != null)
                    {
                        browserScrollElementIntoView["SearchElementBoundingBoxRight"] = ExpressionConverter.ConvertO(__workflow_browserScrollElementIntoViewsearchElementBoundingBoxRight);
                        browserScrollElementIntoViewpropCount++;
                    }

                    browserScrollElementIntoViewpropCount++;
                }
                else
                {
                    browserScrollElementIntoView["SearchElementBoundingBoxRight"] = 99999;
                    browserScrollElementIntoViewpropCount++;
                }

                if (__workflow_browserScrollElementIntoViewsearchElementBoundingBoxTop != null)
                {
                    if (__workflow_browserScrollElementIntoViewsearchElementBoundingBoxTop != null)
                    {
                        browserScrollElementIntoView["SearchElementBoundingBoxTop"] = ExpressionConverter.ConvertO(__workflow_browserScrollElementIntoViewsearchElementBoundingBoxTop);
                        browserScrollElementIntoViewpropCount++;
                    }

                    browserScrollElementIntoViewpropCount++;
                }
                else
                {
                    browserScrollElementIntoView["SearchElementBoundingBoxTop"] = -99999;
                    browserScrollElementIntoViewpropCount++;
                }

                if (__workflow_browserScrollElementIntoViewsearchElementBoundingBoxBottom != null)
                {
                    if (__workflow_browserScrollElementIntoViewsearchElementBoundingBoxBottom != null)
                    {
                        browserScrollElementIntoView["SearchElementBoundingBoxBottom"] = ExpressionConverter.ConvertO(__workflow_browserScrollElementIntoViewsearchElementBoundingBoxBottom);
                        browserScrollElementIntoViewpropCount++;
                    }

                    browserScrollElementIntoViewpropCount++;
                }
                else
                {
                    browserScrollElementIntoView["SearchElementBoundingBoxBottom"] = 99999;
                    browserScrollElementIntoViewpropCount++;
                }

                if (__workflow_browserScrollElementIntoViewonlyElementTopLeftNeedsToBeInBoundingBox != null)
                {
                    if (__workflow_browserScrollElementIntoViewonlyElementTopLeftNeedsToBeInBoundingBox != null)
                    {
                        browserScrollElementIntoView["OnlyElementTopLeftNeedsToBeInBoundingBox"] = ExpressionConverter.ConvertO(__workflow_browserScrollElementIntoViewonlyElementTopLeftNeedsToBeInBoundingBox);
                        browserScrollElementIntoViewpropCount++;
                    }

                    browserScrollElementIntoViewpropCount++;
                }
                else
                {
                    browserScrollElementIntoView["OnlyElementTopLeftNeedsToBeInBoundingBox"] = false;
                    browserScrollElementIntoViewpropCount++;
                }

                browserScrollElementIntoViewpropCount++;
                browserScrollElementIntoView["Workflow"] = ExpressionConverter.ConvertO(__workflow_browserScrollElementIntoViewworkflow);
                if (browserScrollElementIntoViewpropCount > 0)
                {
                    callPayload.Body = browserScrollElementIntoView;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserExecuteJavaScriptResponse> BrowserExecuteJavaScript(Expression<Func<string>> browserExecuteJavaScriptjavaScriptCode, Expression<Func<string>> browserExecuteJavaScriptworkflow)
        {
            var __workflow_browserExecuteJavaScriptjavaScriptCode = WorkflowExpression.Compile(browserExecuteJavaScriptjavaScriptCode, nameof(browserExecuteJavaScriptjavaScriptCode), required: true);
            var __workflow_browserExecuteJavaScriptworkflow = WorkflowExpression.Compile(browserExecuteJavaScriptworkflow, nameof(browserExecuteJavaScriptworkflow), required: true);
            return new DeferredBodyAction<BrowserExecuteJavaScriptResponse>(() =>
            {
                var apiCallPath = "/BrowserControl/ExecuteJavaScript";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserExecuteJavaScript = new JObject();
                var browserExecuteJavaScriptpropCount = 0;
                browserExecuteJavaScriptpropCount++;
                browserExecuteJavaScript["JavaScriptCode"] = ExpressionConverter.ConvertO(__workflow_browserExecuteJavaScriptjavaScriptCode);
                browserExecuteJavaScriptpropCount++;
                browserExecuteJavaScript["Workflow"] = ExpressionConverter.ConvertO(__workflow_browserExecuteJavaScriptworkflow);
                if (browserExecuteJavaScriptpropCount > 0)
                {
                    callPayload.Body = browserExecuteJavaScript;
                }

                return new ApiConnectionAction<BrowserExecuteJavaScriptResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserGetElementBoundingRectResponse> BrowserGetElementBoundingRect(Expression<Func<string>> browserGetElementBoundingRectworkflow, Expression<Func<double>> browserGetElementBoundingRectparentElementHandle = null, Expression<Func<double>> browserGetElementBoundingRectsearchElementHandle = null, Expression<Func<string>> browserGetElementBoundingRectsearchElementName = null, Expression<Func<string>> browserGetElementBoundingRectsearchElementID = null, Expression<Func<string>> browserGetElementBoundingRectsearchElementTagName = null, Expression<Func<string>> browserGetElementBoundingRectsearchElementXPath = null, Expression<Func<string>> browserGetElementBoundingRectsearchElementClassName = null, Expression<Func<string>> browserGetElementBoundingRectsearchElementCSSSelector = null, Expression<Func<double>> browserGetElementBoundingRectsearchElementIndex = null, Expression<Func<string>> browserGetElementBoundingRectsearchElementMatchValue = null, Expression<Func<string>> browserGetElementBoundingRectsearchElementMatchText = null, Expression<Func<string>> browserGetElementBoundingRectsearchElementType = null, Expression<Func<double>> browserGetElementBoundingRectsearchElementMinimumWidth = null, Expression<Func<double>> browserGetElementBoundingRectsearchElementMinimumHeight = null, Expression<Func<double>> browserGetElementBoundingRectsearchElementBoundingBoxLeft = null, Expression<Func<double>> browserGetElementBoundingRectsearchElementBoundingBoxRight = null, Expression<Func<double>> browserGetElementBoundingRectsearchElementBoundingBoxTop = null, Expression<Func<double>> browserGetElementBoundingRectsearchElementBoundingBoxBottom = null, Expression<Func<bool>> browserGetElementBoundingRectonlyElementTopLeftNeedsToBeInBoundingBox = null)
        {
            var __workflow_browserGetElementBoundingRectworkflow = WorkflowExpression.Compile(browserGetElementBoundingRectworkflow, nameof(browserGetElementBoundingRectworkflow), required: true);
            var __workflow_browserGetElementBoundingRectparentElementHandle = WorkflowExpression.Compile(browserGetElementBoundingRectparentElementHandle, nameof(browserGetElementBoundingRectparentElementHandle), required: false);
            var __workflow_browserGetElementBoundingRectsearchElementHandle = WorkflowExpression.Compile(browserGetElementBoundingRectsearchElementHandle, nameof(browserGetElementBoundingRectsearchElementHandle), required: false);
            var __workflow_browserGetElementBoundingRectsearchElementName = WorkflowExpression.Compile(browserGetElementBoundingRectsearchElementName, nameof(browserGetElementBoundingRectsearchElementName), required: false);
            var __workflow_browserGetElementBoundingRectsearchElementID = WorkflowExpression.Compile(browserGetElementBoundingRectsearchElementID, nameof(browserGetElementBoundingRectsearchElementID), required: false);
            var __workflow_browserGetElementBoundingRectsearchElementTagName = WorkflowExpression.Compile(browserGetElementBoundingRectsearchElementTagName, nameof(browserGetElementBoundingRectsearchElementTagName), required: false);
            var __workflow_browserGetElementBoundingRectsearchElementXPath = WorkflowExpression.Compile(browserGetElementBoundingRectsearchElementXPath, nameof(browserGetElementBoundingRectsearchElementXPath), required: false);
            var __workflow_browserGetElementBoundingRectsearchElementClassName = WorkflowExpression.Compile(browserGetElementBoundingRectsearchElementClassName, nameof(browserGetElementBoundingRectsearchElementClassName), required: false);
            var __workflow_browserGetElementBoundingRectsearchElementCSSSelector = WorkflowExpression.Compile(browserGetElementBoundingRectsearchElementCSSSelector, nameof(browserGetElementBoundingRectsearchElementCSSSelector), required: false);
            var __workflow_browserGetElementBoundingRectsearchElementIndex = WorkflowExpression.Compile(browserGetElementBoundingRectsearchElementIndex, nameof(browserGetElementBoundingRectsearchElementIndex), required: false);
            var __workflow_browserGetElementBoundingRectsearchElementMatchValue = WorkflowExpression.Compile(browserGetElementBoundingRectsearchElementMatchValue, nameof(browserGetElementBoundingRectsearchElementMatchValue), required: false);
            var __workflow_browserGetElementBoundingRectsearchElementMatchText = WorkflowExpression.Compile(browserGetElementBoundingRectsearchElementMatchText, nameof(browserGetElementBoundingRectsearchElementMatchText), required: false);
            var __workflow_browserGetElementBoundingRectsearchElementType = WorkflowExpression.Compile(browserGetElementBoundingRectsearchElementType, nameof(browserGetElementBoundingRectsearchElementType), required: false);
            var __workflow_browserGetElementBoundingRectsearchElementMinimumWidth = WorkflowExpression.Compile(browserGetElementBoundingRectsearchElementMinimumWidth, nameof(browserGetElementBoundingRectsearchElementMinimumWidth), required: false);
            var __workflow_browserGetElementBoundingRectsearchElementMinimumHeight = WorkflowExpression.Compile(browserGetElementBoundingRectsearchElementMinimumHeight, nameof(browserGetElementBoundingRectsearchElementMinimumHeight), required: false);
            var __workflow_browserGetElementBoundingRectsearchElementBoundingBoxLeft = WorkflowExpression.Compile(browserGetElementBoundingRectsearchElementBoundingBoxLeft, nameof(browserGetElementBoundingRectsearchElementBoundingBoxLeft), required: false);
            var __workflow_browserGetElementBoundingRectsearchElementBoundingBoxRight = WorkflowExpression.Compile(browserGetElementBoundingRectsearchElementBoundingBoxRight, nameof(browserGetElementBoundingRectsearchElementBoundingBoxRight), required: false);
            var __workflow_browserGetElementBoundingRectsearchElementBoundingBoxTop = WorkflowExpression.Compile(browserGetElementBoundingRectsearchElementBoundingBoxTop, nameof(browserGetElementBoundingRectsearchElementBoundingBoxTop), required: false);
            var __workflow_browserGetElementBoundingRectsearchElementBoundingBoxBottom = WorkflowExpression.Compile(browserGetElementBoundingRectsearchElementBoundingBoxBottom, nameof(browserGetElementBoundingRectsearchElementBoundingBoxBottom), required: false);
            var __workflow_browserGetElementBoundingRectonlyElementTopLeftNeedsToBeInBoundingBox = WorkflowExpression.Compile(browserGetElementBoundingRectonlyElementTopLeftNeedsToBeInBoundingBox, nameof(browserGetElementBoundingRectonlyElementTopLeftNeedsToBeInBoundingBox), required: false);
            return new DeferredBodyAction<BrowserGetElementBoundingRectResponse>(() =>
            {
                var apiCallPath = "/BrowserControl/GetElementBoundingRect";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserGetElementBoundingRect = new JObject();
                var browserGetElementBoundingRectpropCount = 0;
                if (__workflow_browserGetElementBoundingRectparentElementHandle != null)
                {
                    browserGetElementBoundingRect["ParentElementHandle"] = ExpressionConverter.ConvertO(__workflow_browserGetElementBoundingRectparentElementHandle);
                    browserGetElementBoundingRectpropCount++;
                }

                if (__workflow_browserGetElementBoundingRectsearchElementHandle != null)
                {
                    browserGetElementBoundingRect["SearchElementHandle"] = ExpressionConverter.ConvertO(__workflow_browserGetElementBoundingRectsearchElementHandle);
                    browserGetElementBoundingRectpropCount++;
                }

                if (__workflow_browserGetElementBoundingRectsearchElementName != null)
                {
                    browserGetElementBoundingRect["SearchElementName"] = ExpressionConverter.ConvertO(__workflow_browserGetElementBoundingRectsearchElementName);
                    browserGetElementBoundingRectpropCount++;
                }

                if (__workflow_browserGetElementBoundingRectsearchElementID != null)
                {
                    browserGetElementBoundingRect["SearchElementID"] = ExpressionConverter.ConvertO(__workflow_browserGetElementBoundingRectsearchElementID);
                    browserGetElementBoundingRectpropCount++;
                }

                if (__workflow_browserGetElementBoundingRectsearchElementTagName != null)
                {
                    browserGetElementBoundingRect["SearchElementTagName"] = ExpressionConverter.ConvertO(__workflow_browserGetElementBoundingRectsearchElementTagName);
                    browserGetElementBoundingRectpropCount++;
                }

                if (__workflow_browserGetElementBoundingRectsearchElementXPath != null)
                {
                    browserGetElementBoundingRect["SearchElementXPath"] = ExpressionConverter.ConvertO(__workflow_browserGetElementBoundingRectsearchElementXPath);
                    browserGetElementBoundingRectpropCount++;
                }

                if (__workflow_browserGetElementBoundingRectsearchElementClassName != null)
                {
                    browserGetElementBoundingRect["SearchElementClassName"] = ExpressionConverter.ConvertO(__workflow_browserGetElementBoundingRectsearchElementClassName);
                    browserGetElementBoundingRectpropCount++;
                }

                if (__workflow_browserGetElementBoundingRectsearchElementCSSSelector != null)
                {
                    browserGetElementBoundingRect["SearchElementCSSSelector"] = ExpressionConverter.ConvertO(__workflow_browserGetElementBoundingRectsearchElementCSSSelector);
                    browserGetElementBoundingRectpropCount++;
                }

                if (__workflow_browserGetElementBoundingRectsearchElementIndex != null)
                {
                    if (__workflow_browserGetElementBoundingRectsearchElementIndex != null)
                    {
                        browserGetElementBoundingRect["SearchElementIndex"] = ExpressionConverter.ConvertO(__workflow_browserGetElementBoundingRectsearchElementIndex);
                        browserGetElementBoundingRectpropCount++;
                    }

                    browserGetElementBoundingRectpropCount++;
                }
                else
                {
                    browserGetElementBoundingRect["SearchElementIndex"] = 1;
                    browserGetElementBoundingRectpropCount++;
                }

                if (__workflow_browserGetElementBoundingRectsearchElementMatchValue != null)
                {
                    browserGetElementBoundingRect["SearchElementMatchValue"] = ExpressionConverter.ConvertO(__workflow_browserGetElementBoundingRectsearchElementMatchValue);
                    browserGetElementBoundingRectpropCount++;
                }

                if (__workflow_browserGetElementBoundingRectsearchElementMatchText != null)
                {
                    browserGetElementBoundingRect["SearchElementMatchText"] = ExpressionConverter.ConvertO(__workflow_browserGetElementBoundingRectsearchElementMatchText);
                    browserGetElementBoundingRectpropCount++;
                }

                if (__workflow_browserGetElementBoundingRectsearchElementType != null)
                {
                    browserGetElementBoundingRect["SearchElementType"] = ExpressionConverter.ConvertO(__workflow_browserGetElementBoundingRectsearchElementType);
                    browserGetElementBoundingRectpropCount++;
                }

                if (__workflow_browserGetElementBoundingRectsearchElementMinimumWidth != null)
                {
                    if (__workflow_browserGetElementBoundingRectsearchElementMinimumWidth != null)
                    {
                        browserGetElementBoundingRect["SearchElementMinimumWidth"] = ExpressionConverter.ConvertO(__workflow_browserGetElementBoundingRectsearchElementMinimumWidth);
                        browserGetElementBoundingRectpropCount++;
                    }

                    browserGetElementBoundingRectpropCount++;
                }
                else
                {
                    browserGetElementBoundingRect["SearchElementMinimumWidth"] = 1;
                    browserGetElementBoundingRectpropCount++;
                }

                if (__workflow_browserGetElementBoundingRectsearchElementMinimumHeight != null)
                {
                    if (__workflow_browserGetElementBoundingRectsearchElementMinimumHeight != null)
                    {
                        browserGetElementBoundingRect["SearchElementMinimumHeight"] = ExpressionConverter.ConvertO(__workflow_browserGetElementBoundingRectsearchElementMinimumHeight);
                        browserGetElementBoundingRectpropCount++;
                    }

                    browserGetElementBoundingRectpropCount++;
                }
                else
                {
                    browserGetElementBoundingRect["SearchElementMinimumHeight"] = 1;
                    browserGetElementBoundingRectpropCount++;
                }

                if (__workflow_browserGetElementBoundingRectsearchElementBoundingBoxLeft != null)
                {
                    if (__workflow_browserGetElementBoundingRectsearchElementBoundingBoxLeft != null)
                    {
                        browserGetElementBoundingRect["SearchElementBoundingBoxLeft"] = ExpressionConverter.ConvertO(__workflow_browserGetElementBoundingRectsearchElementBoundingBoxLeft);
                        browserGetElementBoundingRectpropCount++;
                    }

                    browserGetElementBoundingRectpropCount++;
                }
                else
                {
                    browserGetElementBoundingRect["SearchElementBoundingBoxLeft"] = -99999;
                    browserGetElementBoundingRectpropCount++;
                }

                if (__workflow_browserGetElementBoundingRectsearchElementBoundingBoxRight != null)
                {
                    if (__workflow_browserGetElementBoundingRectsearchElementBoundingBoxRight != null)
                    {
                        browserGetElementBoundingRect["SearchElementBoundingBoxRight"] = ExpressionConverter.ConvertO(__workflow_browserGetElementBoundingRectsearchElementBoundingBoxRight);
                        browserGetElementBoundingRectpropCount++;
                    }

                    browserGetElementBoundingRectpropCount++;
                }
                else
                {
                    browserGetElementBoundingRect["SearchElementBoundingBoxRight"] = 99999;
                    browserGetElementBoundingRectpropCount++;
                }

                if (__workflow_browserGetElementBoundingRectsearchElementBoundingBoxTop != null)
                {
                    if (__workflow_browserGetElementBoundingRectsearchElementBoundingBoxTop != null)
                    {
                        browserGetElementBoundingRect["SearchElementBoundingBoxTop"] = ExpressionConverter.ConvertO(__workflow_browserGetElementBoundingRectsearchElementBoundingBoxTop);
                        browserGetElementBoundingRectpropCount++;
                    }

                    browserGetElementBoundingRectpropCount++;
                }
                else
                {
                    browserGetElementBoundingRect["SearchElementBoundingBoxTop"] = -99999;
                    browserGetElementBoundingRectpropCount++;
                }

                if (__workflow_browserGetElementBoundingRectsearchElementBoundingBoxBottom != null)
                {
                    if (__workflow_browserGetElementBoundingRectsearchElementBoundingBoxBottom != null)
                    {
                        browserGetElementBoundingRect["SearchElementBoundingBoxBottom"] = ExpressionConverter.ConvertO(__workflow_browserGetElementBoundingRectsearchElementBoundingBoxBottom);
                        browserGetElementBoundingRectpropCount++;
                    }

                    browserGetElementBoundingRectpropCount++;
                }
                else
                {
                    browserGetElementBoundingRect["SearchElementBoundingBoxBottom"] = 99999;
                    browserGetElementBoundingRectpropCount++;
                }

                if (__workflow_browserGetElementBoundingRectonlyElementTopLeftNeedsToBeInBoundingBox != null)
                {
                    if (__workflow_browserGetElementBoundingRectonlyElementTopLeftNeedsToBeInBoundingBox != null)
                    {
                        browserGetElementBoundingRect["OnlyElementTopLeftNeedsToBeInBoundingBox"] = ExpressionConverter.ConvertO(__workflow_browserGetElementBoundingRectonlyElementTopLeftNeedsToBeInBoundingBox);
                        browserGetElementBoundingRectpropCount++;
                    }

                    browserGetElementBoundingRectpropCount++;
                }
                else
                {
                    browserGetElementBoundingRect["OnlyElementTopLeftNeedsToBeInBoundingBox"] = false;
                    browserGetElementBoundingRectpropCount++;
                }

                browserGetElementBoundingRectpropCount++;
                browserGetElementBoundingRect["Workflow"] = ExpressionConverter.ConvertO(__workflow_browserGetElementBoundingRectworkflow);
                if (browserGetElementBoundingRectpropCount > 0)
                {
                    callPayload.Body = browserGetElementBoundingRect;
                }

                return new ApiConnectionAction<BrowserGetElementBoundingRectResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserDrawRectangleAroundElement(Expression<Func<string>> browserDrawRectangleAroundElementworkflow, Expression<Func<double>> browserDrawRectangleAroundElementparentElementHandle = null, Expression<Func<double>> browserDrawRectangleAroundElementsearchElementHandle = null, Expression<Func<string>> browserDrawRectangleAroundElementsearchElementName = null, Expression<Func<string>> browserDrawRectangleAroundElementsearchElementID = null, Expression<Func<string>> browserDrawRectangleAroundElementsearchElementTagName = null, Expression<Func<string>> browserDrawRectangleAroundElementsearchElementXPath = null, Expression<Func<string>> browserDrawRectangleAroundElementsearchElementClassName = null, Expression<Func<string>> browserDrawRectangleAroundElementsearchElementCSSSelector = null, Expression<Func<double>> browserDrawRectangleAroundElementsearchElementIndex = null, Expression<Func<string>> browserDrawRectangleAroundElementsearchElementMatchValue = null, Expression<Func<string>> browserDrawRectangleAroundElementsearchElementMatchText = null, Expression<Func<string>> browserDrawRectangleAroundElementsearchElementType = null, Expression<Func<double>> browserDrawRectangleAroundElementsearchElementMinimumWidth = null, Expression<Func<double>> browserDrawRectangleAroundElementsearchElementMinimumHeight = null, Expression<Func<double>> browserDrawRectangleAroundElementsearchElementBoundingBoxLeft = null, Expression<Func<double>> browserDrawRectangleAroundElementsearchElementBoundingBoxRight = null, Expression<Func<double>> browserDrawRectangleAroundElementsearchElementBoundingBoxTop = null, Expression<Func<double>> browserDrawRectangleAroundElementsearchElementBoundingBoxBottom = null, Expression<Func<bool>> browserDrawRectangleAroundElementonlyElementTopLeftNeedsToBeInBoundingBox = null, Expression<Func<string>> browserDrawRectangleAroundElementpenColour = null, Expression<Func<int>> browserDrawRectangleAroundElementpenThicknessPixels = null)
        {
            var __workflow_browserDrawRectangleAroundElementworkflow = WorkflowExpression.Compile(browserDrawRectangleAroundElementworkflow, nameof(browserDrawRectangleAroundElementworkflow), required: true);
            var __workflow_browserDrawRectangleAroundElementparentElementHandle = WorkflowExpression.Compile(browserDrawRectangleAroundElementparentElementHandle, nameof(browserDrawRectangleAroundElementparentElementHandle), required: false);
            var __workflow_browserDrawRectangleAroundElementsearchElementHandle = WorkflowExpression.Compile(browserDrawRectangleAroundElementsearchElementHandle, nameof(browserDrawRectangleAroundElementsearchElementHandle), required: false);
            var __workflow_browserDrawRectangleAroundElementsearchElementName = WorkflowExpression.Compile(browserDrawRectangleAroundElementsearchElementName, nameof(browserDrawRectangleAroundElementsearchElementName), required: false);
            var __workflow_browserDrawRectangleAroundElementsearchElementID = WorkflowExpression.Compile(browserDrawRectangleAroundElementsearchElementID, nameof(browserDrawRectangleAroundElementsearchElementID), required: false);
            var __workflow_browserDrawRectangleAroundElementsearchElementTagName = WorkflowExpression.Compile(browserDrawRectangleAroundElementsearchElementTagName, nameof(browserDrawRectangleAroundElementsearchElementTagName), required: false);
            var __workflow_browserDrawRectangleAroundElementsearchElementXPath = WorkflowExpression.Compile(browserDrawRectangleAroundElementsearchElementXPath, nameof(browserDrawRectangleAroundElementsearchElementXPath), required: false);
            var __workflow_browserDrawRectangleAroundElementsearchElementClassName = WorkflowExpression.Compile(browserDrawRectangleAroundElementsearchElementClassName, nameof(browserDrawRectangleAroundElementsearchElementClassName), required: false);
            var __workflow_browserDrawRectangleAroundElementsearchElementCSSSelector = WorkflowExpression.Compile(browserDrawRectangleAroundElementsearchElementCSSSelector, nameof(browserDrawRectangleAroundElementsearchElementCSSSelector), required: false);
            var __workflow_browserDrawRectangleAroundElementsearchElementIndex = WorkflowExpression.Compile(browserDrawRectangleAroundElementsearchElementIndex, nameof(browserDrawRectangleAroundElementsearchElementIndex), required: false);
            var __workflow_browserDrawRectangleAroundElementsearchElementMatchValue = WorkflowExpression.Compile(browserDrawRectangleAroundElementsearchElementMatchValue, nameof(browserDrawRectangleAroundElementsearchElementMatchValue), required: false);
            var __workflow_browserDrawRectangleAroundElementsearchElementMatchText = WorkflowExpression.Compile(browserDrawRectangleAroundElementsearchElementMatchText, nameof(browserDrawRectangleAroundElementsearchElementMatchText), required: false);
            var __workflow_browserDrawRectangleAroundElementsearchElementType = WorkflowExpression.Compile(browserDrawRectangleAroundElementsearchElementType, nameof(browserDrawRectangleAroundElementsearchElementType), required: false);
            var __workflow_browserDrawRectangleAroundElementsearchElementMinimumWidth = WorkflowExpression.Compile(browserDrawRectangleAroundElementsearchElementMinimumWidth, nameof(browserDrawRectangleAroundElementsearchElementMinimumWidth), required: false);
            var __workflow_browserDrawRectangleAroundElementsearchElementMinimumHeight = WorkflowExpression.Compile(browserDrawRectangleAroundElementsearchElementMinimumHeight, nameof(browserDrawRectangleAroundElementsearchElementMinimumHeight), required: false);
            var __workflow_browserDrawRectangleAroundElementsearchElementBoundingBoxLeft = WorkflowExpression.Compile(browserDrawRectangleAroundElementsearchElementBoundingBoxLeft, nameof(browserDrawRectangleAroundElementsearchElementBoundingBoxLeft), required: false);
            var __workflow_browserDrawRectangleAroundElementsearchElementBoundingBoxRight = WorkflowExpression.Compile(browserDrawRectangleAroundElementsearchElementBoundingBoxRight, nameof(browserDrawRectangleAroundElementsearchElementBoundingBoxRight), required: false);
            var __workflow_browserDrawRectangleAroundElementsearchElementBoundingBoxTop = WorkflowExpression.Compile(browserDrawRectangleAroundElementsearchElementBoundingBoxTop, nameof(browserDrawRectangleAroundElementsearchElementBoundingBoxTop), required: false);
            var __workflow_browserDrawRectangleAroundElementsearchElementBoundingBoxBottom = WorkflowExpression.Compile(browserDrawRectangleAroundElementsearchElementBoundingBoxBottom, nameof(browserDrawRectangleAroundElementsearchElementBoundingBoxBottom), required: false);
            var __workflow_browserDrawRectangleAroundElementonlyElementTopLeftNeedsToBeInBoundingBox = WorkflowExpression.Compile(browserDrawRectangleAroundElementonlyElementTopLeftNeedsToBeInBoundingBox, nameof(browserDrawRectangleAroundElementonlyElementTopLeftNeedsToBeInBoundingBox), required: false);
            var __workflow_browserDrawRectangleAroundElementpenColour = WorkflowExpression.Compile(browserDrawRectangleAroundElementpenColour, nameof(browserDrawRectangleAroundElementpenColour), required: false);
            var __workflow_browserDrawRectangleAroundElementpenThicknessPixels = WorkflowExpression.Compile(browserDrawRectangleAroundElementpenThicknessPixels, nameof(browserDrawRectangleAroundElementpenThicknessPixels), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/BrowserControl/DrawRectangleAroundElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserDrawRectangleAroundElement = new JObject();
                var browserDrawRectangleAroundElementpropCount = 0;
                if (__workflow_browserDrawRectangleAroundElementparentElementHandle != null)
                {
                    browserDrawRectangleAroundElement["ParentElementHandle"] = ExpressionConverter.ConvertO(__workflow_browserDrawRectangleAroundElementparentElementHandle);
                    browserDrawRectangleAroundElementpropCount++;
                }

                if (__workflow_browserDrawRectangleAroundElementsearchElementHandle != null)
                {
                    browserDrawRectangleAroundElement["SearchElementHandle"] = ExpressionConverter.ConvertO(__workflow_browserDrawRectangleAroundElementsearchElementHandle);
                    browserDrawRectangleAroundElementpropCount++;
                }

                if (__workflow_browserDrawRectangleAroundElementsearchElementName != null)
                {
                    browserDrawRectangleAroundElement["SearchElementName"] = ExpressionConverter.ConvertO(__workflow_browserDrawRectangleAroundElementsearchElementName);
                    browserDrawRectangleAroundElementpropCount++;
                }

                if (__workflow_browserDrawRectangleAroundElementsearchElementID != null)
                {
                    browserDrawRectangleAroundElement["SearchElementID"] = ExpressionConverter.ConvertO(__workflow_browserDrawRectangleAroundElementsearchElementID);
                    browserDrawRectangleAroundElementpropCount++;
                }

                if (__workflow_browserDrawRectangleAroundElementsearchElementTagName != null)
                {
                    browserDrawRectangleAroundElement["SearchElementTagName"] = ExpressionConverter.ConvertO(__workflow_browserDrawRectangleAroundElementsearchElementTagName);
                    browserDrawRectangleAroundElementpropCount++;
                }

                if (__workflow_browserDrawRectangleAroundElementsearchElementXPath != null)
                {
                    browserDrawRectangleAroundElement["SearchElementXPath"] = ExpressionConverter.ConvertO(__workflow_browserDrawRectangleAroundElementsearchElementXPath);
                    browserDrawRectangleAroundElementpropCount++;
                }

                if (__workflow_browserDrawRectangleAroundElementsearchElementClassName != null)
                {
                    browserDrawRectangleAroundElement["SearchElementClassName"] = ExpressionConverter.ConvertO(__workflow_browserDrawRectangleAroundElementsearchElementClassName);
                    browserDrawRectangleAroundElementpropCount++;
                }

                if (__workflow_browserDrawRectangleAroundElementsearchElementCSSSelector != null)
                {
                    browserDrawRectangleAroundElement["SearchElementCSSSelector"] = ExpressionConverter.ConvertO(__workflow_browserDrawRectangleAroundElementsearchElementCSSSelector);
                    browserDrawRectangleAroundElementpropCount++;
                }

                if (__workflow_browserDrawRectangleAroundElementsearchElementIndex != null)
                {
                    if (__workflow_browserDrawRectangleAroundElementsearchElementIndex != null)
                    {
                        browserDrawRectangleAroundElement["SearchElementIndex"] = ExpressionConverter.ConvertO(__workflow_browserDrawRectangleAroundElementsearchElementIndex);
                        browserDrawRectangleAroundElementpropCount++;
                    }

                    browserDrawRectangleAroundElementpropCount++;
                }
                else
                {
                    browserDrawRectangleAroundElement["SearchElementIndex"] = 1;
                    browserDrawRectangleAroundElementpropCount++;
                }

                if (__workflow_browserDrawRectangleAroundElementsearchElementMatchValue != null)
                {
                    browserDrawRectangleAroundElement["SearchElementMatchValue"] = ExpressionConverter.ConvertO(__workflow_browserDrawRectangleAroundElementsearchElementMatchValue);
                    browserDrawRectangleAroundElementpropCount++;
                }

                if (__workflow_browserDrawRectangleAroundElementsearchElementMatchText != null)
                {
                    browserDrawRectangleAroundElement["SearchElementMatchText"] = ExpressionConverter.ConvertO(__workflow_browserDrawRectangleAroundElementsearchElementMatchText);
                    browserDrawRectangleAroundElementpropCount++;
                }

                if (__workflow_browserDrawRectangleAroundElementsearchElementType != null)
                {
                    browserDrawRectangleAroundElement["SearchElementType"] = ExpressionConverter.ConvertO(__workflow_browserDrawRectangleAroundElementsearchElementType);
                    browserDrawRectangleAroundElementpropCount++;
                }

                if (__workflow_browserDrawRectangleAroundElementsearchElementMinimumWidth != null)
                {
                    if (__workflow_browserDrawRectangleAroundElementsearchElementMinimumWidth != null)
                    {
                        browserDrawRectangleAroundElement["SearchElementMinimumWidth"] = ExpressionConverter.ConvertO(__workflow_browserDrawRectangleAroundElementsearchElementMinimumWidth);
                        browserDrawRectangleAroundElementpropCount++;
                    }

                    browserDrawRectangleAroundElementpropCount++;
                }
                else
                {
                    browserDrawRectangleAroundElement["SearchElementMinimumWidth"] = 1;
                    browserDrawRectangleAroundElementpropCount++;
                }

                if (__workflow_browserDrawRectangleAroundElementsearchElementMinimumHeight != null)
                {
                    if (__workflow_browserDrawRectangleAroundElementsearchElementMinimumHeight != null)
                    {
                        browserDrawRectangleAroundElement["SearchElementMinimumHeight"] = ExpressionConverter.ConvertO(__workflow_browserDrawRectangleAroundElementsearchElementMinimumHeight);
                        browserDrawRectangleAroundElementpropCount++;
                    }

                    browserDrawRectangleAroundElementpropCount++;
                }
                else
                {
                    browserDrawRectangleAroundElement["SearchElementMinimumHeight"] = 1;
                    browserDrawRectangleAroundElementpropCount++;
                }

                if (__workflow_browserDrawRectangleAroundElementsearchElementBoundingBoxLeft != null)
                {
                    if (__workflow_browserDrawRectangleAroundElementsearchElementBoundingBoxLeft != null)
                    {
                        browserDrawRectangleAroundElement["SearchElementBoundingBoxLeft"] = ExpressionConverter.ConvertO(__workflow_browserDrawRectangleAroundElementsearchElementBoundingBoxLeft);
                        browserDrawRectangleAroundElementpropCount++;
                    }

                    browserDrawRectangleAroundElementpropCount++;
                }
                else
                {
                    browserDrawRectangleAroundElement["SearchElementBoundingBoxLeft"] = -99999;
                    browserDrawRectangleAroundElementpropCount++;
                }

                if (__workflow_browserDrawRectangleAroundElementsearchElementBoundingBoxRight != null)
                {
                    if (__workflow_browserDrawRectangleAroundElementsearchElementBoundingBoxRight != null)
                    {
                        browserDrawRectangleAroundElement["SearchElementBoundingBoxRight"] = ExpressionConverter.ConvertO(__workflow_browserDrawRectangleAroundElementsearchElementBoundingBoxRight);
                        browserDrawRectangleAroundElementpropCount++;
                    }

                    browserDrawRectangleAroundElementpropCount++;
                }
                else
                {
                    browserDrawRectangleAroundElement["SearchElementBoundingBoxRight"] = 99999;
                    browserDrawRectangleAroundElementpropCount++;
                }

                if (__workflow_browserDrawRectangleAroundElementsearchElementBoundingBoxTop != null)
                {
                    if (__workflow_browserDrawRectangleAroundElementsearchElementBoundingBoxTop != null)
                    {
                        browserDrawRectangleAroundElement["SearchElementBoundingBoxTop"] = ExpressionConverter.ConvertO(__workflow_browserDrawRectangleAroundElementsearchElementBoundingBoxTop);
                        browserDrawRectangleAroundElementpropCount++;
                    }

                    browserDrawRectangleAroundElementpropCount++;
                }
                else
                {
                    browserDrawRectangleAroundElement["SearchElementBoundingBoxTop"] = -99999;
                    browserDrawRectangleAroundElementpropCount++;
                }

                if (__workflow_browserDrawRectangleAroundElementsearchElementBoundingBoxBottom != null)
                {
                    if (__workflow_browserDrawRectangleAroundElementsearchElementBoundingBoxBottom != null)
                    {
                        browserDrawRectangleAroundElement["SearchElementBoundingBoxBottom"] = ExpressionConverter.ConvertO(__workflow_browserDrawRectangleAroundElementsearchElementBoundingBoxBottom);
                        browserDrawRectangleAroundElementpropCount++;
                    }

                    browserDrawRectangleAroundElementpropCount++;
                }
                else
                {
                    browserDrawRectangleAroundElement["SearchElementBoundingBoxBottom"] = 99999;
                    browserDrawRectangleAroundElementpropCount++;
                }

                if (__workflow_browserDrawRectangleAroundElementonlyElementTopLeftNeedsToBeInBoundingBox != null)
                {
                    if (__workflow_browserDrawRectangleAroundElementonlyElementTopLeftNeedsToBeInBoundingBox != null)
                    {
                        browserDrawRectangleAroundElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = ExpressionConverter.ConvertO(__workflow_browserDrawRectangleAroundElementonlyElementTopLeftNeedsToBeInBoundingBox);
                        browserDrawRectangleAroundElementpropCount++;
                    }

                    browserDrawRectangleAroundElementpropCount++;
                }
                else
                {
                    browserDrawRectangleAroundElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = false;
                    browserDrawRectangleAroundElementpropCount++;
                }

                if (__workflow_browserDrawRectangleAroundElementpenColour != null)
                {
                    if (__workflow_browserDrawRectangleAroundElementpenColour != null)
                    {
                        browserDrawRectangleAroundElement["PenColour"] = ExpressionConverter.ConvertO(__workflow_browserDrawRectangleAroundElementpenColour);
                        browserDrawRectangleAroundElementpropCount++;
                    }

                    browserDrawRectangleAroundElementpropCount++;
                }
                else
                {
                    browserDrawRectangleAroundElement["PenColour"] = "green";
                    browserDrawRectangleAroundElementpropCount++;
                }

                if (__workflow_browserDrawRectangleAroundElementpenThicknessPixels != null)
                {
                    if (__workflow_browserDrawRectangleAroundElementpenThicknessPixels != null)
                    {
                        browserDrawRectangleAroundElement["PenThicknessPixels"] = ExpressionConverter.ConvertO(__workflow_browserDrawRectangleAroundElementpenThicknessPixels);
                        browserDrawRectangleAroundElementpropCount++;
                    }

                    browserDrawRectangleAroundElementpropCount++;
                }
                else
                {
                    browserDrawRectangleAroundElement["PenThicknessPixels"] = 4;
                    browserDrawRectangleAroundElementpropCount++;
                }

                browserDrawRectangleAroundElementpropCount++;
                browserDrawRectangleAroundElement["Workflow"] = ExpressionConverter.ConvertO(__workflow_browserDrawRectangleAroundElementworkflow);
                if (browserDrawRectangleAroundElementpropCount > 0)
                {
                    callPayload.Body = browserDrawRectangleAroundElement;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserGetBrowserParentWindowDetailsResponse> BrowserGetBrowserParentWindowDetails(Expression<Func<string>> browserGetBrowserParentWindowDetailsworkflow, Expression<Func<int>> browserGetBrowserParentWindowDetailsbrowserPID = null, Expression<Func<string>> browserGetBrowserParentWindowDetailssearchDocumentElementClassName = null)
        {
            var __workflow_browserGetBrowserParentWindowDetailsworkflow = WorkflowExpression.Compile(browserGetBrowserParentWindowDetailsworkflow, nameof(browserGetBrowserParentWindowDetailsworkflow), required: true);
            var __workflow_browserGetBrowserParentWindowDetailsbrowserPID = WorkflowExpression.Compile(browserGetBrowserParentWindowDetailsbrowserPID, nameof(browserGetBrowserParentWindowDetailsbrowserPID), required: false);
            var __workflow_browserGetBrowserParentWindowDetailssearchDocumentElementClassName = WorkflowExpression.Compile(browserGetBrowserParentWindowDetailssearchDocumentElementClassName, nameof(browserGetBrowserParentWindowDetailssearchDocumentElementClassName), required: false);
            return new DeferredBodyAction<BrowserGetBrowserParentWindowDetailsResponse>(() =>
            {
                var apiCallPath = "/BrowserControl/GetBrowserParentWindowDetails";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserGetBrowserParentWindowDetails = new JObject();
                var browserGetBrowserParentWindowDetailspropCount = 0;
                if (__workflow_browserGetBrowserParentWindowDetailsbrowserPID != null)
                {
                    browserGetBrowserParentWindowDetails["BrowserPID"] = ExpressionConverter.ConvertO(__workflow_browserGetBrowserParentWindowDetailsbrowserPID);
                    browserGetBrowserParentWindowDetailspropCount++;
                }

                if (__workflow_browserGetBrowserParentWindowDetailssearchDocumentElementClassName != null)
                {
                    browserGetBrowserParentWindowDetails["SearchDocumentElementClassName"] = ExpressionConverter.ConvertO(__workflow_browserGetBrowserParentWindowDetailssearchDocumentElementClassName);
                    browserGetBrowserParentWindowDetailspropCount++;
                }

                browserGetBrowserParentWindowDetailspropCount++;
                browserGetBrowserParentWindowDetails["Workflow"] = ExpressionConverter.ConvertO(__workflow_browserGetBrowserParentWindowDetailsworkflow);
                if (browserGetBrowserParentWindowDetailspropCount > 0)
                {
                    callPayload.Body = browserGetBrowserParentWindowDetails;
                }

                return new ApiConnectionAction<BrowserGetBrowserParentWindowDetailsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserGetElementScreenBoundingRectResponse> BrowserGetElementScreenBoundingRect(Expression<Func<string>> browserGetElementScreenBoundingRectworkflow, Expression<Func<double>> browserGetElementScreenBoundingRectparentElementHandle = null, Expression<Func<double>> browserGetElementScreenBoundingRectsearchElementHandle = null, Expression<Func<string>> browserGetElementScreenBoundingRectsearchElementName = null, Expression<Func<string>> browserGetElementScreenBoundingRectsearchElementID = null, Expression<Func<string>> browserGetElementScreenBoundingRectsearchElementTagName = null, Expression<Func<string>> browserGetElementScreenBoundingRectsearchElementXPath = null, Expression<Func<string>> browserGetElementScreenBoundingRectsearchElementClassName = null, Expression<Func<string>> browserGetElementScreenBoundingRectsearchElementCSSSelector = null, Expression<Func<double>> browserGetElementScreenBoundingRectsearchElementIndex = null, Expression<Func<string>> browserGetElementScreenBoundingRectsearchElementMatchValue = null, Expression<Func<string>> browserGetElementScreenBoundingRectsearchElementMatchText = null, Expression<Func<string>> browserGetElementScreenBoundingRectsearchElementType = null, Expression<Func<double>> browserGetElementScreenBoundingRectsearchElementMinimumWidth = null, Expression<Func<double>> browserGetElementScreenBoundingRectsearchElementMinimumHeight = null, Expression<Func<double>> browserGetElementScreenBoundingRectsearchElementBoundingBoxLeft = null, Expression<Func<double>> browserGetElementScreenBoundingRectsearchElementBoundingBoxRight = null, Expression<Func<double>> browserGetElementScreenBoundingRectsearchElementBoundingBoxTop = null, Expression<Func<double>> browserGetElementScreenBoundingRectsearchElementBoundingBoxBottom = null, Expression<Func<bool>> browserGetElementScreenBoundingRectonlyElementTopLeftNeedsToBeInBoundingBox = null)
        {
            var __workflow_browserGetElementScreenBoundingRectworkflow = WorkflowExpression.Compile(browserGetElementScreenBoundingRectworkflow, nameof(browserGetElementScreenBoundingRectworkflow), required: true);
            var __workflow_browserGetElementScreenBoundingRectparentElementHandle = WorkflowExpression.Compile(browserGetElementScreenBoundingRectparentElementHandle, nameof(browserGetElementScreenBoundingRectparentElementHandle), required: false);
            var __workflow_browserGetElementScreenBoundingRectsearchElementHandle = WorkflowExpression.Compile(browserGetElementScreenBoundingRectsearchElementHandle, nameof(browserGetElementScreenBoundingRectsearchElementHandle), required: false);
            var __workflow_browserGetElementScreenBoundingRectsearchElementName = WorkflowExpression.Compile(browserGetElementScreenBoundingRectsearchElementName, nameof(browserGetElementScreenBoundingRectsearchElementName), required: false);
            var __workflow_browserGetElementScreenBoundingRectsearchElementID = WorkflowExpression.Compile(browserGetElementScreenBoundingRectsearchElementID, nameof(browserGetElementScreenBoundingRectsearchElementID), required: false);
            var __workflow_browserGetElementScreenBoundingRectsearchElementTagName = WorkflowExpression.Compile(browserGetElementScreenBoundingRectsearchElementTagName, nameof(browserGetElementScreenBoundingRectsearchElementTagName), required: false);
            var __workflow_browserGetElementScreenBoundingRectsearchElementXPath = WorkflowExpression.Compile(browserGetElementScreenBoundingRectsearchElementXPath, nameof(browserGetElementScreenBoundingRectsearchElementXPath), required: false);
            var __workflow_browserGetElementScreenBoundingRectsearchElementClassName = WorkflowExpression.Compile(browserGetElementScreenBoundingRectsearchElementClassName, nameof(browserGetElementScreenBoundingRectsearchElementClassName), required: false);
            var __workflow_browserGetElementScreenBoundingRectsearchElementCSSSelector = WorkflowExpression.Compile(browserGetElementScreenBoundingRectsearchElementCSSSelector, nameof(browserGetElementScreenBoundingRectsearchElementCSSSelector), required: false);
            var __workflow_browserGetElementScreenBoundingRectsearchElementIndex = WorkflowExpression.Compile(browserGetElementScreenBoundingRectsearchElementIndex, nameof(browserGetElementScreenBoundingRectsearchElementIndex), required: false);
            var __workflow_browserGetElementScreenBoundingRectsearchElementMatchValue = WorkflowExpression.Compile(browserGetElementScreenBoundingRectsearchElementMatchValue, nameof(browserGetElementScreenBoundingRectsearchElementMatchValue), required: false);
            var __workflow_browserGetElementScreenBoundingRectsearchElementMatchText = WorkflowExpression.Compile(browserGetElementScreenBoundingRectsearchElementMatchText, nameof(browserGetElementScreenBoundingRectsearchElementMatchText), required: false);
            var __workflow_browserGetElementScreenBoundingRectsearchElementType = WorkflowExpression.Compile(browserGetElementScreenBoundingRectsearchElementType, nameof(browserGetElementScreenBoundingRectsearchElementType), required: false);
            var __workflow_browserGetElementScreenBoundingRectsearchElementMinimumWidth = WorkflowExpression.Compile(browserGetElementScreenBoundingRectsearchElementMinimumWidth, nameof(browserGetElementScreenBoundingRectsearchElementMinimumWidth), required: false);
            var __workflow_browserGetElementScreenBoundingRectsearchElementMinimumHeight = WorkflowExpression.Compile(browserGetElementScreenBoundingRectsearchElementMinimumHeight, nameof(browserGetElementScreenBoundingRectsearchElementMinimumHeight), required: false);
            var __workflow_browserGetElementScreenBoundingRectsearchElementBoundingBoxLeft = WorkflowExpression.Compile(browserGetElementScreenBoundingRectsearchElementBoundingBoxLeft, nameof(browserGetElementScreenBoundingRectsearchElementBoundingBoxLeft), required: false);
            var __workflow_browserGetElementScreenBoundingRectsearchElementBoundingBoxRight = WorkflowExpression.Compile(browserGetElementScreenBoundingRectsearchElementBoundingBoxRight, nameof(browserGetElementScreenBoundingRectsearchElementBoundingBoxRight), required: false);
            var __workflow_browserGetElementScreenBoundingRectsearchElementBoundingBoxTop = WorkflowExpression.Compile(browserGetElementScreenBoundingRectsearchElementBoundingBoxTop, nameof(browserGetElementScreenBoundingRectsearchElementBoundingBoxTop), required: false);
            var __workflow_browserGetElementScreenBoundingRectsearchElementBoundingBoxBottom = WorkflowExpression.Compile(browserGetElementScreenBoundingRectsearchElementBoundingBoxBottom, nameof(browserGetElementScreenBoundingRectsearchElementBoundingBoxBottom), required: false);
            var __workflow_browserGetElementScreenBoundingRectonlyElementTopLeftNeedsToBeInBoundingBox = WorkflowExpression.Compile(browserGetElementScreenBoundingRectonlyElementTopLeftNeedsToBeInBoundingBox, nameof(browserGetElementScreenBoundingRectonlyElementTopLeftNeedsToBeInBoundingBox), required: false);
            return new DeferredBodyAction<BrowserGetElementScreenBoundingRectResponse>(() =>
            {
                var apiCallPath = "/BrowserControl/GetElementScreenBoundingRect";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserGetElementScreenBoundingRect = new JObject();
                var browserGetElementScreenBoundingRectpropCount = 0;
                if (__workflow_browserGetElementScreenBoundingRectparentElementHandle != null)
                {
                    browserGetElementScreenBoundingRect["ParentElementHandle"] = ExpressionConverter.ConvertO(__workflow_browserGetElementScreenBoundingRectparentElementHandle);
                    browserGetElementScreenBoundingRectpropCount++;
                }

                if (__workflow_browserGetElementScreenBoundingRectsearchElementHandle != null)
                {
                    browserGetElementScreenBoundingRect["SearchElementHandle"] = ExpressionConverter.ConvertO(__workflow_browserGetElementScreenBoundingRectsearchElementHandle);
                    browserGetElementScreenBoundingRectpropCount++;
                }

                if (__workflow_browserGetElementScreenBoundingRectsearchElementName != null)
                {
                    browserGetElementScreenBoundingRect["SearchElementName"] = ExpressionConverter.ConvertO(__workflow_browserGetElementScreenBoundingRectsearchElementName);
                    browserGetElementScreenBoundingRectpropCount++;
                }

                if (__workflow_browserGetElementScreenBoundingRectsearchElementID != null)
                {
                    browserGetElementScreenBoundingRect["SearchElementID"] = ExpressionConverter.ConvertO(__workflow_browserGetElementScreenBoundingRectsearchElementID);
                    browserGetElementScreenBoundingRectpropCount++;
                }

                if (__workflow_browserGetElementScreenBoundingRectsearchElementTagName != null)
                {
                    browserGetElementScreenBoundingRect["SearchElementTagName"] = ExpressionConverter.ConvertO(__workflow_browserGetElementScreenBoundingRectsearchElementTagName);
                    browserGetElementScreenBoundingRectpropCount++;
                }

                if (__workflow_browserGetElementScreenBoundingRectsearchElementXPath != null)
                {
                    browserGetElementScreenBoundingRect["SearchElementXPath"] = ExpressionConverter.ConvertO(__workflow_browserGetElementScreenBoundingRectsearchElementXPath);
                    browserGetElementScreenBoundingRectpropCount++;
                }

                if (__workflow_browserGetElementScreenBoundingRectsearchElementClassName != null)
                {
                    browserGetElementScreenBoundingRect["SearchElementClassName"] = ExpressionConverter.ConvertO(__workflow_browserGetElementScreenBoundingRectsearchElementClassName);
                    browserGetElementScreenBoundingRectpropCount++;
                }

                if (__workflow_browserGetElementScreenBoundingRectsearchElementCSSSelector != null)
                {
                    browserGetElementScreenBoundingRect["SearchElementCSSSelector"] = ExpressionConverter.ConvertO(__workflow_browserGetElementScreenBoundingRectsearchElementCSSSelector);
                    browserGetElementScreenBoundingRectpropCount++;
                }

                if (__workflow_browserGetElementScreenBoundingRectsearchElementIndex != null)
                {
                    if (__workflow_browserGetElementScreenBoundingRectsearchElementIndex != null)
                    {
                        browserGetElementScreenBoundingRect["SearchElementIndex"] = ExpressionConverter.ConvertO(__workflow_browserGetElementScreenBoundingRectsearchElementIndex);
                        browserGetElementScreenBoundingRectpropCount++;
                    }

                    browserGetElementScreenBoundingRectpropCount++;
                }
                else
                {
                    browserGetElementScreenBoundingRect["SearchElementIndex"] = 1;
                    browserGetElementScreenBoundingRectpropCount++;
                }

                if (__workflow_browserGetElementScreenBoundingRectsearchElementMatchValue != null)
                {
                    browserGetElementScreenBoundingRect["SearchElementMatchValue"] = ExpressionConverter.ConvertO(__workflow_browserGetElementScreenBoundingRectsearchElementMatchValue);
                    browserGetElementScreenBoundingRectpropCount++;
                }

                if (__workflow_browserGetElementScreenBoundingRectsearchElementMatchText != null)
                {
                    browserGetElementScreenBoundingRect["SearchElementMatchText"] = ExpressionConverter.ConvertO(__workflow_browserGetElementScreenBoundingRectsearchElementMatchText);
                    browserGetElementScreenBoundingRectpropCount++;
                }

                if (__workflow_browserGetElementScreenBoundingRectsearchElementType != null)
                {
                    browserGetElementScreenBoundingRect["SearchElementType"] = ExpressionConverter.ConvertO(__workflow_browserGetElementScreenBoundingRectsearchElementType);
                    browserGetElementScreenBoundingRectpropCount++;
                }

                if (__workflow_browserGetElementScreenBoundingRectsearchElementMinimumWidth != null)
                {
                    if (__workflow_browserGetElementScreenBoundingRectsearchElementMinimumWidth != null)
                    {
                        browserGetElementScreenBoundingRect["SearchElementMinimumWidth"] = ExpressionConverter.ConvertO(__workflow_browserGetElementScreenBoundingRectsearchElementMinimumWidth);
                        browserGetElementScreenBoundingRectpropCount++;
                    }

                    browserGetElementScreenBoundingRectpropCount++;
                }
                else
                {
                    browserGetElementScreenBoundingRect["SearchElementMinimumWidth"] = 1;
                    browserGetElementScreenBoundingRectpropCount++;
                }

                if (__workflow_browserGetElementScreenBoundingRectsearchElementMinimumHeight != null)
                {
                    if (__workflow_browserGetElementScreenBoundingRectsearchElementMinimumHeight != null)
                    {
                        browserGetElementScreenBoundingRect["SearchElementMinimumHeight"] = ExpressionConverter.ConvertO(__workflow_browserGetElementScreenBoundingRectsearchElementMinimumHeight);
                        browserGetElementScreenBoundingRectpropCount++;
                    }

                    browserGetElementScreenBoundingRectpropCount++;
                }
                else
                {
                    browserGetElementScreenBoundingRect["SearchElementMinimumHeight"] = 1;
                    browserGetElementScreenBoundingRectpropCount++;
                }

                if (__workflow_browserGetElementScreenBoundingRectsearchElementBoundingBoxLeft != null)
                {
                    if (__workflow_browserGetElementScreenBoundingRectsearchElementBoundingBoxLeft != null)
                    {
                        browserGetElementScreenBoundingRect["SearchElementBoundingBoxLeft"] = ExpressionConverter.ConvertO(__workflow_browserGetElementScreenBoundingRectsearchElementBoundingBoxLeft);
                        browserGetElementScreenBoundingRectpropCount++;
                    }

                    browserGetElementScreenBoundingRectpropCount++;
                }
                else
                {
                    browserGetElementScreenBoundingRect["SearchElementBoundingBoxLeft"] = -99999;
                    browserGetElementScreenBoundingRectpropCount++;
                }

                if (__workflow_browserGetElementScreenBoundingRectsearchElementBoundingBoxRight != null)
                {
                    if (__workflow_browserGetElementScreenBoundingRectsearchElementBoundingBoxRight != null)
                    {
                        browserGetElementScreenBoundingRect["SearchElementBoundingBoxRight"] = ExpressionConverter.ConvertO(__workflow_browserGetElementScreenBoundingRectsearchElementBoundingBoxRight);
                        browserGetElementScreenBoundingRectpropCount++;
                    }

                    browserGetElementScreenBoundingRectpropCount++;
                }
                else
                {
                    browserGetElementScreenBoundingRect["SearchElementBoundingBoxRight"] = 99999;
                    browserGetElementScreenBoundingRectpropCount++;
                }

                if (__workflow_browserGetElementScreenBoundingRectsearchElementBoundingBoxTop != null)
                {
                    if (__workflow_browserGetElementScreenBoundingRectsearchElementBoundingBoxTop != null)
                    {
                        browserGetElementScreenBoundingRect["SearchElementBoundingBoxTop"] = ExpressionConverter.ConvertO(__workflow_browserGetElementScreenBoundingRectsearchElementBoundingBoxTop);
                        browserGetElementScreenBoundingRectpropCount++;
                    }

                    browserGetElementScreenBoundingRectpropCount++;
                }
                else
                {
                    browserGetElementScreenBoundingRect["SearchElementBoundingBoxTop"] = -99999;
                    browserGetElementScreenBoundingRectpropCount++;
                }

                if (__workflow_browserGetElementScreenBoundingRectsearchElementBoundingBoxBottom != null)
                {
                    if (__workflow_browserGetElementScreenBoundingRectsearchElementBoundingBoxBottom != null)
                    {
                        browserGetElementScreenBoundingRect["SearchElementBoundingBoxBottom"] = ExpressionConverter.ConvertO(__workflow_browserGetElementScreenBoundingRectsearchElementBoundingBoxBottom);
                        browserGetElementScreenBoundingRectpropCount++;
                    }

                    browserGetElementScreenBoundingRectpropCount++;
                }
                else
                {
                    browserGetElementScreenBoundingRect["SearchElementBoundingBoxBottom"] = 99999;
                    browserGetElementScreenBoundingRectpropCount++;
                }

                if (__workflow_browserGetElementScreenBoundingRectonlyElementTopLeftNeedsToBeInBoundingBox != null)
                {
                    if (__workflow_browserGetElementScreenBoundingRectonlyElementTopLeftNeedsToBeInBoundingBox != null)
                    {
                        browserGetElementScreenBoundingRect["OnlyElementTopLeftNeedsToBeInBoundingBox"] = ExpressionConverter.ConvertO(__workflow_browserGetElementScreenBoundingRectonlyElementTopLeftNeedsToBeInBoundingBox);
                        browserGetElementScreenBoundingRectpropCount++;
                    }

                    browserGetElementScreenBoundingRectpropCount++;
                }
                else
                {
                    browserGetElementScreenBoundingRect["OnlyElementTopLeftNeedsToBeInBoundingBox"] = false;
                    browserGetElementScreenBoundingRectpropCount++;
                }

                browserGetElementScreenBoundingRectpropCount++;
                browserGetElementScreenBoundingRect["Workflow"] = ExpressionConverter.ConvertO(__workflow_browserGetElementScreenBoundingRectworkflow);
                if (browserGetElementScreenBoundingRectpropCount > 0)
                {
                    callPayload.Body = browserGetElementScreenBoundingRect;
                }

                return new ApiConnectionAction<BrowserGetElementScreenBoundingRectResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserFocusElement(Expression<Func<string>> browserFocusElementworkflow, Expression<Func<double>> browserFocusElementparentElementHandle = null, Expression<Func<double>> browserFocusElementsearchElementHandle = null, Expression<Func<string>> browserFocusElementsearchElementName = null, Expression<Func<string>> browserFocusElementsearchElementID = null, Expression<Func<string>> browserFocusElementsearchElementTagName = null, Expression<Func<string>> browserFocusElementsearchElementXPath = null, Expression<Func<string>> browserFocusElementsearchElementClassName = null, Expression<Func<string>> browserFocusElementsearchElementCSSSelector = null, Expression<Func<double>> browserFocusElementsearchElementIndex = null, Expression<Func<string>> browserFocusElementsearchElementMatchValue = null, Expression<Func<string>> browserFocusElementsearchElementMatchText = null, Expression<Func<string>> browserFocusElementsearchElementType = null, Expression<Func<double>> browserFocusElementsearchElementMinimumWidth = null, Expression<Func<double>> browserFocusElementsearchElementMinimumHeight = null, Expression<Func<double>> browserFocusElementsearchElementBoundingBoxLeft = null, Expression<Func<double>> browserFocusElementsearchElementBoundingBoxRight = null, Expression<Func<double>> browserFocusElementsearchElementBoundingBoxTop = null, Expression<Func<double>> browserFocusElementsearchElementBoundingBoxBottom = null, Expression<Func<bool>> browserFocusElementonlyElementTopLeftNeedsToBeInBoundingBox = null)
        {
            var __workflow_browserFocusElementworkflow = WorkflowExpression.Compile(browserFocusElementworkflow, nameof(browserFocusElementworkflow), required: true);
            var __workflow_browserFocusElementparentElementHandle = WorkflowExpression.Compile(browserFocusElementparentElementHandle, nameof(browserFocusElementparentElementHandle), required: false);
            var __workflow_browserFocusElementsearchElementHandle = WorkflowExpression.Compile(browserFocusElementsearchElementHandle, nameof(browserFocusElementsearchElementHandle), required: false);
            var __workflow_browserFocusElementsearchElementName = WorkflowExpression.Compile(browserFocusElementsearchElementName, nameof(browserFocusElementsearchElementName), required: false);
            var __workflow_browserFocusElementsearchElementID = WorkflowExpression.Compile(browserFocusElementsearchElementID, nameof(browserFocusElementsearchElementID), required: false);
            var __workflow_browserFocusElementsearchElementTagName = WorkflowExpression.Compile(browserFocusElementsearchElementTagName, nameof(browserFocusElementsearchElementTagName), required: false);
            var __workflow_browserFocusElementsearchElementXPath = WorkflowExpression.Compile(browserFocusElementsearchElementXPath, nameof(browserFocusElementsearchElementXPath), required: false);
            var __workflow_browserFocusElementsearchElementClassName = WorkflowExpression.Compile(browserFocusElementsearchElementClassName, nameof(browserFocusElementsearchElementClassName), required: false);
            var __workflow_browserFocusElementsearchElementCSSSelector = WorkflowExpression.Compile(browserFocusElementsearchElementCSSSelector, nameof(browserFocusElementsearchElementCSSSelector), required: false);
            var __workflow_browserFocusElementsearchElementIndex = WorkflowExpression.Compile(browserFocusElementsearchElementIndex, nameof(browserFocusElementsearchElementIndex), required: false);
            var __workflow_browserFocusElementsearchElementMatchValue = WorkflowExpression.Compile(browserFocusElementsearchElementMatchValue, nameof(browserFocusElementsearchElementMatchValue), required: false);
            var __workflow_browserFocusElementsearchElementMatchText = WorkflowExpression.Compile(browserFocusElementsearchElementMatchText, nameof(browserFocusElementsearchElementMatchText), required: false);
            var __workflow_browserFocusElementsearchElementType = WorkflowExpression.Compile(browserFocusElementsearchElementType, nameof(browserFocusElementsearchElementType), required: false);
            var __workflow_browserFocusElementsearchElementMinimumWidth = WorkflowExpression.Compile(browserFocusElementsearchElementMinimumWidth, nameof(browserFocusElementsearchElementMinimumWidth), required: false);
            var __workflow_browserFocusElementsearchElementMinimumHeight = WorkflowExpression.Compile(browserFocusElementsearchElementMinimumHeight, nameof(browserFocusElementsearchElementMinimumHeight), required: false);
            var __workflow_browserFocusElementsearchElementBoundingBoxLeft = WorkflowExpression.Compile(browserFocusElementsearchElementBoundingBoxLeft, nameof(browserFocusElementsearchElementBoundingBoxLeft), required: false);
            var __workflow_browserFocusElementsearchElementBoundingBoxRight = WorkflowExpression.Compile(browserFocusElementsearchElementBoundingBoxRight, nameof(browserFocusElementsearchElementBoundingBoxRight), required: false);
            var __workflow_browserFocusElementsearchElementBoundingBoxTop = WorkflowExpression.Compile(browserFocusElementsearchElementBoundingBoxTop, nameof(browserFocusElementsearchElementBoundingBoxTop), required: false);
            var __workflow_browserFocusElementsearchElementBoundingBoxBottom = WorkflowExpression.Compile(browserFocusElementsearchElementBoundingBoxBottom, nameof(browserFocusElementsearchElementBoundingBoxBottom), required: false);
            var __workflow_browserFocusElementonlyElementTopLeftNeedsToBeInBoundingBox = WorkflowExpression.Compile(browserFocusElementonlyElementTopLeftNeedsToBeInBoundingBox, nameof(browserFocusElementonlyElementTopLeftNeedsToBeInBoundingBox), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/BrowserControl/FocusElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserFocusElement = new JObject();
                var browserFocusElementpropCount = 0;
                if (__workflow_browserFocusElementparentElementHandle != null)
                {
                    browserFocusElement["ParentElementHandle"] = ExpressionConverter.ConvertO(__workflow_browserFocusElementparentElementHandle);
                    browserFocusElementpropCount++;
                }

                if (__workflow_browserFocusElementsearchElementHandle != null)
                {
                    browserFocusElement["SearchElementHandle"] = ExpressionConverter.ConvertO(__workflow_browserFocusElementsearchElementHandle);
                    browserFocusElementpropCount++;
                }

                if (__workflow_browserFocusElementsearchElementName != null)
                {
                    browserFocusElement["SearchElementName"] = ExpressionConverter.ConvertO(__workflow_browserFocusElementsearchElementName);
                    browserFocusElementpropCount++;
                }

                if (__workflow_browserFocusElementsearchElementID != null)
                {
                    browserFocusElement["SearchElementID"] = ExpressionConverter.ConvertO(__workflow_browserFocusElementsearchElementID);
                    browserFocusElementpropCount++;
                }

                if (__workflow_browserFocusElementsearchElementTagName != null)
                {
                    browserFocusElement["SearchElementTagName"] = ExpressionConverter.ConvertO(__workflow_browserFocusElementsearchElementTagName);
                    browserFocusElementpropCount++;
                }

                if (__workflow_browserFocusElementsearchElementXPath != null)
                {
                    browserFocusElement["SearchElementXPath"] = ExpressionConverter.ConvertO(__workflow_browserFocusElementsearchElementXPath);
                    browserFocusElementpropCount++;
                }

                if (__workflow_browserFocusElementsearchElementClassName != null)
                {
                    browserFocusElement["SearchElementClassName"] = ExpressionConverter.ConvertO(__workflow_browserFocusElementsearchElementClassName);
                    browserFocusElementpropCount++;
                }

                if (__workflow_browserFocusElementsearchElementCSSSelector != null)
                {
                    browserFocusElement["SearchElementCSSSelector"] = ExpressionConverter.ConvertO(__workflow_browserFocusElementsearchElementCSSSelector);
                    browserFocusElementpropCount++;
                }

                if (__workflow_browserFocusElementsearchElementIndex != null)
                {
                    if (__workflow_browserFocusElementsearchElementIndex != null)
                    {
                        browserFocusElement["SearchElementIndex"] = ExpressionConverter.ConvertO(__workflow_browserFocusElementsearchElementIndex);
                        browserFocusElementpropCount++;
                    }

                    browserFocusElementpropCount++;
                }
                else
                {
                    browserFocusElement["SearchElementIndex"] = 1;
                    browserFocusElementpropCount++;
                }

                if (__workflow_browserFocusElementsearchElementMatchValue != null)
                {
                    browserFocusElement["SearchElementMatchValue"] = ExpressionConverter.ConvertO(__workflow_browserFocusElementsearchElementMatchValue);
                    browserFocusElementpropCount++;
                }

                if (__workflow_browserFocusElementsearchElementMatchText != null)
                {
                    browserFocusElement["SearchElementMatchText"] = ExpressionConverter.ConvertO(__workflow_browserFocusElementsearchElementMatchText);
                    browserFocusElementpropCount++;
                }

                if (__workflow_browserFocusElementsearchElementType != null)
                {
                    browserFocusElement["SearchElementType"] = ExpressionConverter.ConvertO(__workflow_browserFocusElementsearchElementType);
                    browserFocusElementpropCount++;
                }

                if (__workflow_browserFocusElementsearchElementMinimumWidth != null)
                {
                    if (__workflow_browserFocusElementsearchElementMinimumWidth != null)
                    {
                        browserFocusElement["SearchElementMinimumWidth"] = ExpressionConverter.ConvertO(__workflow_browserFocusElementsearchElementMinimumWidth);
                        browserFocusElementpropCount++;
                    }

                    browserFocusElementpropCount++;
                }
                else
                {
                    browserFocusElement["SearchElementMinimumWidth"] = 1;
                    browserFocusElementpropCount++;
                }

                if (__workflow_browserFocusElementsearchElementMinimumHeight != null)
                {
                    if (__workflow_browserFocusElementsearchElementMinimumHeight != null)
                    {
                        browserFocusElement["SearchElementMinimumHeight"] = ExpressionConverter.ConvertO(__workflow_browserFocusElementsearchElementMinimumHeight);
                        browserFocusElementpropCount++;
                    }

                    browserFocusElementpropCount++;
                }
                else
                {
                    browserFocusElement["SearchElementMinimumHeight"] = 1;
                    browserFocusElementpropCount++;
                }

                if (__workflow_browserFocusElementsearchElementBoundingBoxLeft != null)
                {
                    if (__workflow_browserFocusElementsearchElementBoundingBoxLeft != null)
                    {
                        browserFocusElement["SearchElementBoundingBoxLeft"] = ExpressionConverter.ConvertO(__workflow_browserFocusElementsearchElementBoundingBoxLeft);
                        browserFocusElementpropCount++;
                    }

                    browserFocusElementpropCount++;
                }
                else
                {
                    browserFocusElement["SearchElementBoundingBoxLeft"] = -99999;
                    browserFocusElementpropCount++;
                }

                if (__workflow_browserFocusElementsearchElementBoundingBoxRight != null)
                {
                    if (__workflow_browserFocusElementsearchElementBoundingBoxRight != null)
                    {
                        browserFocusElement["SearchElementBoundingBoxRight"] = ExpressionConverter.ConvertO(__workflow_browserFocusElementsearchElementBoundingBoxRight);
                        browserFocusElementpropCount++;
                    }

                    browserFocusElementpropCount++;
                }
                else
                {
                    browserFocusElement["SearchElementBoundingBoxRight"] = 99999;
                    browserFocusElementpropCount++;
                }

                if (__workflow_browserFocusElementsearchElementBoundingBoxTop != null)
                {
                    if (__workflow_browserFocusElementsearchElementBoundingBoxTop != null)
                    {
                        browserFocusElement["SearchElementBoundingBoxTop"] = ExpressionConverter.ConvertO(__workflow_browserFocusElementsearchElementBoundingBoxTop);
                        browserFocusElementpropCount++;
                    }

                    browserFocusElementpropCount++;
                }
                else
                {
                    browserFocusElement["SearchElementBoundingBoxTop"] = -99999;
                    browserFocusElementpropCount++;
                }

                if (__workflow_browserFocusElementsearchElementBoundingBoxBottom != null)
                {
                    if (__workflow_browserFocusElementsearchElementBoundingBoxBottom != null)
                    {
                        browserFocusElement["SearchElementBoundingBoxBottom"] = ExpressionConverter.ConvertO(__workflow_browserFocusElementsearchElementBoundingBoxBottom);
                        browserFocusElementpropCount++;
                    }

                    browserFocusElementpropCount++;
                }
                else
                {
                    browserFocusElement["SearchElementBoundingBoxBottom"] = 99999;
                    browserFocusElementpropCount++;
                }

                if (__workflow_browserFocusElementonlyElementTopLeftNeedsToBeInBoundingBox != null)
                {
                    if (__workflow_browserFocusElementonlyElementTopLeftNeedsToBeInBoundingBox != null)
                    {
                        browserFocusElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = ExpressionConverter.ConvertO(__workflow_browserFocusElementonlyElementTopLeftNeedsToBeInBoundingBox);
                        browserFocusElementpropCount++;
                    }

                    browserFocusElementpropCount++;
                }
                else
                {
                    browserFocusElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = false;
                    browserFocusElementpropCount++;
                }

                browserFocusElementpropCount++;
                browserFocusElement["Workflow"] = ExpressionConverter.ConvertO(__workflow_browserFocusElementworkflow);
                if (browserFocusElementpropCount > 0)
                {
                    callPayload.Body = browserFocusElement;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserPressEnterOnElement(Expression<Func<string>> browserPressEnterOnElementworkflow, Expression<Func<double>> browserPressEnterOnElementparentElementHandle = null, Expression<Func<double>> browserPressEnterOnElementsearchElementHandle = null, Expression<Func<string>> browserPressEnterOnElementsearchElementName = null, Expression<Func<string>> browserPressEnterOnElementsearchElementID = null, Expression<Func<string>> browserPressEnterOnElementsearchElementTagName = null, Expression<Func<string>> browserPressEnterOnElementsearchElementXPath = null, Expression<Func<string>> browserPressEnterOnElementsearchElementClassName = null, Expression<Func<string>> browserPressEnterOnElementsearchElementCSSSelector = null, Expression<Func<double>> browserPressEnterOnElementsearchElementIndex = null, Expression<Func<string>> browserPressEnterOnElementsearchElementMatchValue = null, Expression<Func<string>> browserPressEnterOnElementsearchElementMatchText = null, Expression<Func<string>> browserPressEnterOnElementsearchElementType = null, Expression<Func<double>> browserPressEnterOnElementsearchElementMinimumWidth = null, Expression<Func<double>> browserPressEnterOnElementsearchElementMinimumHeight = null, Expression<Func<double>> browserPressEnterOnElementsearchElementBoundingBoxLeft = null, Expression<Func<double>> browserPressEnterOnElementsearchElementBoundingBoxRight = null, Expression<Func<double>> browserPressEnterOnElementsearchElementBoundingBoxTop = null, Expression<Func<double>> browserPressEnterOnElementsearchElementBoundingBoxBottom = null, Expression<Func<bool>> browserPressEnterOnElementonlyElementTopLeftNeedsToBeInBoundingBox = null)
        {
            var __workflow_browserPressEnterOnElementworkflow = WorkflowExpression.Compile(browserPressEnterOnElementworkflow, nameof(browserPressEnterOnElementworkflow), required: true);
            var __workflow_browserPressEnterOnElementparentElementHandle = WorkflowExpression.Compile(browserPressEnterOnElementparentElementHandle, nameof(browserPressEnterOnElementparentElementHandle), required: false);
            var __workflow_browserPressEnterOnElementsearchElementHandle = WorkflowExpression.Compile(browserPressEnterOnElementsearchElementHandle, nameof(browserPressEnterOnElementsearchElementHandle), required: false);
            var __workflow_browserPressEnterOnElementsearchElementName = WorkflowExpression.Compile(browserPressEnterOnElementsearchElementName, nameof(browserPressEnterOnElementsearchElementName), required: false);
            var __workflow_browserPressEnterOnElementsearchElementID = WorkflowExpression.Compile(browserPressEnterOnElementsearchElementID, nameof(browserPressEnterOnElementsearchElementID), required: false);
            var __workflow_browserPressEnterOnElementsearchElementTagName = WorkflowExpression.Compile(browserPressEnterOnElementsearchElementTagName, nameof(browserPressEnterOnElementsearchElementTagName), required: false);
            var __workflow_browserPressEnterOnElementsearchElementXPath = WorkflowExpression.Compile(browserPressEnterOnElementsearchElementXPath, nameof(browserPressEnterOnElementsearchElementXPath), required: false);
            var __workflow_browserPressEnterOnElementsearchElementClassName = WorkflowExpression.Compile(browserPressEnterOnElementsearchElementClassName, nameof(browserPressEnterOnElementsearchElementClassName), required: false);
            var __workflow_browserPressEnterOnElementsearchElementCSSSelector = WorkflowExpression.Compile(browserPressEnterOnElementsearchElementCSSSelector, nameof(browserPressEnterOnElementsearchElementCSSSelector), required: false);
            var __workflow_browserPressEnterOnElementsearchElementIndex = WorkflowExpression.Compile(browserPressEnterOnElementsearchElementIndex, nameof(browserPressEnterOnElementsearchElementIndex), required: false);
            var __workflow_browserPressEnterOnElementsearchElementMatchValue = WorkflowExpression.Compile(browserPressEnterOnElementsearchElementMatchValue, nameof(browserPressEnterOnElementsearchElementMatchValue), required: false);
            var __workflow_browserPressEnterOnElementsearchElementMatchText = WorkflowExpression.Compile(browserPressEnterOnElementsearchElementMatchText, nameof(browserPressEnterOnElementsearchElementMatchText), required: false);
            var __workflow_browserPressEnterOnElementsearchElementType = WorkflowExpression.Compile(browserPressEnterOnElementsearchElementType, nameof(browserPressEnterOnElementsearchElementType), required: false);
            var __workflow_browserPressEnterOnElementsearchElementMinimumWidth = WorkflowExpression.Compile(browserPressEnterOnElementsearchElementMinimumWidth, nameof(browserPressEnterOnElementsearchElementMinimumWidth), required: false);
            var __workflow_browserPressEnterOnElementsearchElementMinimumHeight = WorkflowExpression.Compile(browserPressEnterOnElementsearchElementMinimumHeight, nameof(browserPressEnterOnElementsearchElementMinimumHeight), required: false);
            var __workflow_browserPressEnterOnElementsearchElementBoundingBoxLeft = WorkflowExpression.Compile(browserPressEnterOnElementsearchElementBoundingBoxLeft, nameof(browserPressEnterOnElementsearchElementBoundingBoxLeft), required: false);
            var __workflow_browserPressEnterOnElementsearchElementBoundingBoxRight = WorkflowExpression.Compile(browserPressEnterOnElementsearchElementBoundingBoxRight, nameof(browserPressEnterOnElementsearchElementBoundingBoxRight), required: false);
            var __workflow_browserPressEnterOnElementsearchElementBoundingBoxTop = WorkflowExpression.Compile(browserPressEnterOnElementsearchElementBoundingBoxTop, nameof(browserPressEnterOnElementsearchElementBoundingBoxTop), required: false);
            var __workflow_browserPressEnterOnElementsearchElementBoundingBoxBottom = WorkflowExpression.Compile(browserPressEnterOnElementsearchElementBoundingBoxBottom, nameof(browserPressEnterOnElementsearchElementBoundingBoxBottom), required: false);
            var __workflow_browserPressEnterOnElementonlyElementTopLeftNeedsToBeInBoundingBox = WorkflowExpression.Compile(browserPressEnterOnElementonlyElementTopLeftNeedsToBeInBoundingBox, nameof(browserPressEnterOnElementonlyElementTopLeftNeedsToBeInBoundingBox), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/BrowserControl/PressEnterOnElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserPressEnterOnElement = new JObject();
                var browserPressEnterOnElementpropCount = 0;
                if (__workflow_browserPressEnterOnElementparentElementHandle != null)
                {
                    browserPressEnterOnElement["ParentElementHandle"] = ExpressionConverter.ConvertO(__workflow_browserPressEnterOnElementparentElementHandle);
                    browserPressEnterOnElementpropCount++;
                }

                if (__workflow_browserPressEnterOnElementsearchElementHandle != null)
                {
                    browserPressEnterOnElement["SearchElementHandle"] = ExpressionConverter.ConvertO(__workflow_browserPressEnterOnElementsearchElementHandle);
                    browserPressEnterOnElementpropCount++;
                }

                if (__workflow_browserPressEnterOnElementsearchElementName != null)
                {
                    browserPressEnterOnElement["SearchElementName"] = ExpressionConverter.ConvertO(__workflow_browserPressEnterOnElementsearchElementName);
                    browserPressEnterOnElementpropCount++;
                }

                if (__workflow_browserPressEnterOnElementsearchElementID != null)
                {
                    browserPressEnterOnElement["SearchElementID"] = ExpressionConverter.ConvertO(__workflow_browserPressEnterOnElementsearchElementID);
                    browserPressEnterOnElementpropCount++;
                }

                if (__workflow_browserPressEnterOnElementsearchElementTagName != null)
                {
                    browserPressEnterOnElement["SearchElementTagName"] = ExpressionConverter.ConvertO(__workflow_browserPressEnterOnElementsearchElementTagName);
                    browserPressEnterOnElementpropCount++;
                }

                if (__workflow_browserPressEnterOnElementsearchElementXPath != null)
                {
                    browserPressEnterOnElement["SearchElementXPath"] = ExpressionConverter.ConvertO(__workflow_browserPressEnterOnElementsearchElementXPath);
                    browserPressEnterOnElementpropCount++;
                }

                if (__workflow_browserPressEnterOnElementsearchElementClassName != null)
                {
                    browserPressEnterOnElement["SearchElementClassName"] = ExpressionConverter.ConvertO(__workflow_browserPressEnterOnElementsearchElementClassName);
                    browserPressEnterOnElementpropCount++;
                }

                if (__workflow_browserPressEnterOnElementsearchElementCSSSelector != null)
                {
                    browserPressEnterOnElement["SearchElementCSSSelector"] = ExpressionConverter.ConvertO(__workflow_browserPressEnterOnElementsearchElementCSSSelector);
                    browserPressEnterOnElementpropCount++;
                }

                if (__workflow_browserPressEnterOnElementsearchElementIndex != null)
                {
                    if (__workflow_browserPressEnterOnElementsearchElementIndex != null)
                    {
                        browserPressEnterOnElement["SearchElementIndex"] = ExpressionConverter.ConvertO(__workflow_browserPressEnterOnElementsearchElementIndex);
                        browserPressEnterOnElementpropCount++;
                    }

                    browserPressEnterOnElementpropCount++;
                }
                else
                {
                    browserPressEnterOnElement["SearchElementIndex"] = 1;
                    browserPressEnterOnElementpropCount++;
                }

                if (__workflow_browserPressEnterOnElementsearchElementMatchValue != null)
                {
                    browserPressEnterOnElement["SearchElementMatchValue"] = ExpressionConverter.ConvertO(__workflow_browserPressEnterOnElementsearchElementMatchValue);
                    browserPressEnterOnElementpropCount++;
                }

                if (__workflow_browserPressEnterOnElementsearchElementMatchText != null)
                {
                    browserPressEnterOnElement["SearchElementMatchText"] = ExpressionConverter.ConvertO(__workflow_browserPressEnterOnElementsearchElementMatchText);
                    browserPressEnterOnElementpropCount++;
                }

                if (__workflow_browserPressEnterOnElementsearchElementType != null)
                {
                    browserPressEnterOnElement["SearchElementType"] = ExpressionConverter.ConvertO(__workflow_browserPressEnterOnElementsearchElementType);
                    browserPressEnterOnElementpropCount++;
                }

                if (__workflow_browserPressEnterOnElementsearchElementMinimumWidth != null)
                {
                    if (__workflow_browserPressEnterOnElementsearchElementMinimumWidth != null)
                    {
                        browserPressEnterOnElement["SearchElementMinimumWidth"] = ExpressionConverter.ConvertO(__workflow_browserPressEnterOnElementsearchElementMinimumWidth);
                        browserPressEnterOnElementpropCount++;
                    }

                    browserPressEnterOnElementpropCount++;
                }
                else
                {
                    browserPressEnterOnElement["SearchElementMinimumWidth"] = 1;
                    browserPressEnterOnElementpropCount++;
                }

                if (__workflow_browserPressEnterOnElementsearchElementMinimumHeight != null)
                {
                    if (__workflow_browserPressEnterOnElementsearchElementMinimumHeight != null)
                    {
                        browserPressEnterOnElement["SearchElementMinimumHeight"] = ExpressionConverter.ConvertO(__workflow_browserPressEnterOnElementsearchElementMinimumHeight);
                        browserPressEnterOnElementpropCount++;
                    }

                    browserPressEnterOnElementpropCount++;
                }
                else
                {
                    browserPressEnterOnElement["SearchElementMinimumHeight"] = 1;
                    browserPressEnterOnElementpropCount++;
                }

                if (__workflow_browserPressEnterOnElementsearchElementBoundingBoxLeft != null)
                {
                    if (__workflow_browserPressEnterOnElementsearchElementBoundingBoxLeft != null)
                    {
                        browserPressEnterOnElement["SearchElementBoundingBoxLeft"] = ExpressionConverter.ConvertO(__workflow_browserPressEnterOnElementsearchElementBoundingBoxLeft);
                        browserPressEnterOnElementpropCount++;
                    }

                    browserPressEnterOnElementpropCount++;
                }
                else
                {
                    browserPressEnterOnElement["SearchElementBoundingBoxLeft"] = -99999;
                    browserPressEnterOnElementpropCount++;
                }

                if (__workflow_browserPressEnterOnElementsearchElementBoundingBoxRight != null)
                {
                    if (__workflow_browserPressEnterOnElementsearchElementBoundingBoxRight != null)
                    {
                        browserPressEnterOnElement["SearchElementBoundingBoxRight"] = ExpressionConverter.ConvertO(__workflow_browserPressEnterOnElementsearchElementBoundingBoxRight);
                        browserPressEnterOnElementpropCount++;
                    }

                    browserPressEnterOnElementpropCount++;
                }
                else
                {
                    browserPressEnterOnElement["SearchElementBoundingBoxRight"] = 99999;
                    browserPressEnterOnElementpropCount++;
                }

                if (__workflow_browserPressEnterOnElementsearchElementBoundingBoxTop != null)
                {
                    if (__workflow_browserPressEnterOnElementsearchElementBoundingBoxTop != null)
                    {
                        browserPressEnterOnElement["SearchElementBoundingBoxTop"] = ExpressionConverter.ConvertO(__workflow_browserPressEnterOnElementsearchElementBoundingBoxTop);
                        browserPressEnterOnElementpropCount++;
                    }

                    browserPressEnterOnElementpropCount++;
                }
                else
                {
                    browserPressEnterOnElement["SearchElementBoundingBoxTop"] = -99999;
                    browserPressEnterOnElementpropCount++;
                }

                if (__workflow_browserPressEnterOnElementsearchElementBoundingBoxBottom != null)
                {
                    if (__workflow_browserPressEnterOnElementsearchElementBoundingBoxBottom != null)
                    {
                        browserPressEnterOnElement["SearchElementBoundingBoxBottom"] = ExpressionConverter.ConvertO(__workflow_browserPressEnterOnElementsearchElementBoundingBoxBottom);
                        browserPressEnterOnElementpropCount++;
                    }

                    browserPressEnterOnElementpropCount++;
                }
                else
                {
                    browserPressEnterOnElement["SearchElementBoundingBoxBottom"] = 99999;
                    browserPressEnterOnElementpropCount++;
                }

                if (__workflow_browserPressEnterOnElementonlyElementTopLeftNeedsToBeInBoundingBox != null)
                {
                    if (__workflow_browserPressEnterOnElementonlyElementTopLeftNeedsToBeInBoundingBox != null)
                    {
                        browserPressEnterOnElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = ExpressionConverter.ConvertO(__workflow_browserPressEnterOnElementonlyElementTopLeftNeedsToBeInBoundingBox);
                        browserPressEnterOnElementpropCount++;
                    }

                    browserPressEnterOnElementpropCount++;
                }
                else
                {
                    browserPressEnterOnElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = false;
                    browserPressEnterOnElementpropCount++;
                }

                browserPressEnterOnElementpropCount++;
                browserPressEnterOnElement["Workflow"] = ExpressionConverter.ConvertO(__workflow_browserPressEnterOnElementworkflow);
                if (browserPressEnterOnElementpropCount > 0)
                {
                    callPayload.Body = browserPressEnterOnElement;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserMouseLeftClickOnElement(Expression<Func<string>> browserMouseLeftClickOnElementworkflow, Expression<Func<double>> browserMouseLeftClickOnElementparentElementHandle = null, Expression<Func<double>> browserMouseLeftClickOnElementsearchElementHandle = null, Expression<Func<string>> browserMouseLeftClickOnElementsearchElementName = null, Expression<Func<string>> browserMouseLeftClickOnElementsearchElementID = null, Expression<Func<string>> browserMouseLeftClickOnElementsearchElementTagName = null, Expression<Func<string>> browserMouseLeftClickOnElementsearchElementXPath = null, Expression<Func<string>> browserMouseLeftClickOnElementsearchElementClassName = null, Expression<Func<string>> browserMouseLeftClickOnElementsearchElementCSSSelector = null, Expression<Func<double>> browserMouseLeftClickOnElementsearchElementIndex = null, Expression<Func<string>> browserMouseLeftClickOnElementsearchElementMatchValue = null, Expression<Func<string>> browserMouseLeftClickOnElementsearchElementMatchText = null, Expression<Func<string>> browserMouseLeftClickOnElementsearchElementType = null, Expression<Func<double>> browserMouseLeftClickOnElementsearchElementMinimumWidth = null, Expression<Func<double>> browserMouseLeftClickOnElementsearchElementMinimumHeight = null, Expression<Func<double>> browserMouseLeftClickOnElementsearchElementBoundingBoxLeft = null, Expression<Func<double>> browserMouseLeftClickOnElementsearchElementBoundingBoxRight = null, Expression<Func<double>> browserMouseLeftClickOnElementsearchElementBoundingBoxTop = null, Expression<Func<double>> browserMouseLeftClickOnElementsearchElementBoundingBoxBottom = null, Expression<Func<bool>> browserMouseLeftClickOnElementonlyElementTopLeftNeedsToBeInBoundingBox = null, Expression<Func<bool>> browserMouseLeftClickOnElementfocusFirst = null)
        {
            var __workflow_browserMouseLeftClickOnElementworkflow = WorkflowExpression.Compile(browserMouseLeftClickOnElementworkflow, nameof(browserMouseLeftClickOnElementworkflow), required: true);
            var __workflow_browserMouseLeftClickOnElementparentElementHandle = WorkflowExpression.Compile(browserMouseLeftClickOnElementparentElementHandle, nameof(browserMouseLeftClickOnElementparentElementHandle), required: false);
            var __workflow_browserMouseLeftClickOnElementsearchElementHandle = WorkflowExpression.Compile(browserMouseLeftClickOnElementsearchElementHandle, nameof(browserMouseLeftClickOnElementsearchElementHandle), required: false);
            var __workflow_browserMouseLeftClickOnElementsearchElementName = WorkflowExpression.Compile(browserMouseLeftClickOnElementsearchElementName, nameof(browserMouseLeftClickOnElementsearchElementName), required: false);
            var __workflow_browserMouseLeftClickOnElementsearchElementID = WorkflowExpression.Compile(browserMouseLeftClickOnElementsearchElementID, nameof(browserMouseLeftClickOnElementsearchElementID), required: false);
            var __workflow_browserMouseLeftClickOnElementsearchElementTagName = WorkflowExpression.Compile(browserMouseLeftClickOnElementsearchElementTagName, nameof(browserMouseLeftClickOnElementsearchElementTagName), required: false);
            var __workflow_browserMouseLeftClickOnElementsearchElementXPath = WorkflowExpression.Compile(browserMouseLeftClickOnElementsearchElementXPath, nameof(browserMouseLeftClickOnElementsearchElementXPath), required: false);
            var __workflow_browserMouseLeftClickOnElementsearchElementClassName = WorkflowExpression.Compile(browserMouseLeftClickOnElementsearchElementClassName, nameof(browserMouseLeftClickOnElementsearchElementClassName), required: false);
            var __workflow_browserMouseLeftClickOnElementsearchElementCSSSelector = WorkflowExpression.Compile(browserMouseLeftClickOnElementsearchElementCSSSelector, nameof(browserMouseLeftClickOnElementsearchElementCSSSelector), required: false);
            var __workflow_browserMouseLeftClickOnElementsearchElementIndex = WorkflowExpression.Compile(browserMouseLeftClickOnElementsearchElementIndex, nameof(browserMouseLeftClickOnElementsearchElementIndex), required: false);
            var __workflow_browserMouseLeftClickOnElementsearchElementMatchValue = WorkflowExpression.Compile(browserMouseLeftClickOnElementsearchElementMatchValue, nameof(browserMouseLeftClickOnElementsearchElementMatchValue), required: false);
            var __workflow_browserMouseLeftClickOnElementsearchElementMatchText = WorkflowExpression.Compile(browserMouseLeftClickOnElementsearchElementMatchText, nameof(browserMouseLeftClickOnElementsearchElementMatchText), required: false);
            var __workflow_browserMouseLeftClickOnElementsearchElementType = WorkflowExpression.Compile(browserMouseLeftClickOnElementsearchElementType, nameof(browserMouseLeftClickOnElementsearchElementType), required: false);
            var __workflow_browserMouseLeftClickOnElementsearchElementMinimumWidth = WorkflowExpression.Compile(browserMouseLeftClickOnElementsearchElementMinimumWidth, nameof(browserMouseLeftClickOnElementsearchElementMinimumWidth), required: false);
            var __workflow_browserMouseLeftClickOnElementsearchElementMinimumHeight = WorkflowExpression.Compile(browserMouseLeftClickOnElementsearchElementMinimumHeight, nameof(browserMouseLeftClickOnElementsearchElementMinimumHeight), required: false);
            var __workflow_browserMouseLeftClickOnElementsearchElementBoundingBoxLeft = WorkflowExpression.Compile(browserMouseLeftClickOnElementsearchElementBoundingBoxLeft, nameof(browserMouseLeftClickOnElementsearchElementBoundingBoxLeft), required: false);
            var __workflow_browserMouseLeftClickOnElementsearchElementBoundingBoxRight = WorkflowExpression.Compile(browserMouseLeftClickOnElementsearchElementBoundingBoxRight, nameof(browserMouseLeftClickOnElementsearchElementBoundingBoxRight), required: false);
            var __workflow_browserMouseLeftClickOnElementsearchElementBoundingBoxTop = WorkflowExpression.Compile(browserMouseLeftClickOnElementsearchElementBoundingBoxTop, nameof(browserMouseLeftClickOnElementsearchElementBoundingBoxTop), required: false);
            var __workflow_browserMouseLeftClickOnElementsearchElementBoundingBoxBottom = WorkflowExpression.Compile(browserMouseLeftClickOnElementsearchElementBoundingBoxBottom, nameof(browserMouseLeftClickOnElementsearchElementBoundingBoxBottom), required: false);
            var __workflow_browserMouseLeftClickOnElementonlyElementTopLeftNeedsToBeInBoundingBox = WorkflowExpression.Compile(browserMouseLeftClickOnElementonlyElementTopLeftNeedsToBeInBoundingBox, nameof(browserMouseLeftClickOnElementonlyElementTopLeftNeedsToBeInBoundingBox), required: false);
            var __workflow_browserMouseLeftClickOnElementfocusFirst = WorkflowExpression.Compile(browserMouseLeftClickOnElementfocusFirst, nameof(browserMouseLeftClickOnElementfocusFirst), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/BrowserControl/MouseLeftClickOnElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserMouseLeftClickOnElement = new JObject();
                var browserMouseLeftClickOnElementpropCount = 0;
                if (__workflow_browserMouseLeftClickOnElementparentElementHandle != null)
                {
                    browserMouseLeftClickOnElement["ParentElementHandle"] = ExpressionConverter.ConvertO(__workflow_browserMouseLeftClickOnElementparentElementHandle);
                    browserMouseLeftClickOnElementpropCount++;
                }

                if (__workflow_browserMouseLeftClickOnElementsearchElementHandle != null)
                {
                    browserMouseLeftClickOnElement["SearchElementHandle"] = ExpressionConverter.ConvertO(__workflow_browserMouseLeftClickOnElementsearchElementHandle);
                    browserMouseLeftClickOnElementpropCount++;
                }

                if (__workflow_browserMouseLeftClickOnElementsearchElementName != null)
                {
                    browserMouseLeftClickOnElement["SearchElementName"] = ExpressionConverter.ConvertO(__workflow_browserMouseLeftClickOnElementsearchElementName);
                    browserMouseLeftClickOnElementpropCount++;
                }

                if (__workflow_browserMouseLeftClickOnElementsearchElementID != null)
                {
                    browserMouseLeftClickOnElement["SearchElementID"] = ExpressionConverter.ConvertO(__workflow_browserMouseLeftClickOnElementsearchElementID);
                    browserMouseLeftClickOnElementpropCount++;
                }

                if (__workflow_browserMouseLeftClickOnElementsearchElementTagName != null)
                {
                    browserMouseLeftClickOnElement["SearchElementTagName"] = ExpressionConverter.ConvertO(__workflow_browserMouseLeftClickOnElementsearchElementTagName);
                    browserMouseLeftClickOnElementpropCount++;
                }

                if (__workflow_browserMouseLeftClickOnElementsearchElementXPath != null)
                {
                    browserMouseLeftClickOnElement["SearchElementXPath"] = ExpressionConverter.ConvertO(__workflow_browserMouseLeftClickOnElementsearchElementXPath);
                    browserMouseLeftClickOnElementpropCount++;
                }

                if (__workflow_browserMouseLeftClickOnElementsearchElementClassName != null)
                {
                    browserMouseLeftClickOnElement["SearchElementClassName"] = ExpressionConverter.ConvertO(__workflow_browserMouseLeftClickOnElementsearchElementClassName);
                    browserMouseLeftClickOnElementpropCount++;
                }

                if (__workflow_browserMouseLeftClickOnElementsearchElementCSSSelector != null)
                {
                    browserMouseLeftClickOnElement["SearchElementCSSSelector"] = ExpressionConverter.ConvertO(__workflow_browserMouseLeftClickOnElementsearchElementCSSSelector);
                    browserMouseLeftClickOnElementpropCount++;
                }

                if (__workflow_browserMouseLeftClickOnElementsearchElementIndex != null)
                {
                    if (__workflow_browserMouseLeftClickOnElementsearchElementIndex != null)
                    {
                        browserMouseLeftClickOnElement["SearchElementIndex"] = ExpressionConverter.ConvertO(__workflow_browserMouseLeftClickOnElementsearchElementIndex);
                        browserMouseLeftClickOnElementpropCount++;
                    }

                    browserMouseLeftClickOnElementpropCount++;
                }
                else
                {
                    browserMouseLeftClickOnElement["SearchElementIndex"] = 1;
                    browserMouseLeftClickOnElementpropCount++;
                }

                if (__workflow_browserMouseLeftClickOnElementsearchElementMatchValue != null)
                {
                    browserMouseLeftClickOnElement["SearchElementMatchValue"] = ExpressionConverter.ConvertO(__workflow_browserMouseLeftClickOnElementsearchElementMatchValue);
                    browserMouseLeftClickOnElementpropCount++;
                }

                if (__workflow_browserMouseLeftClickOnElementsearchElementMatchText != null)
                {
                    browserMouseLeftClickOnElement["SearchElementMatchText"] = ExpressionConverter.ConvertO(__workflow_browserMouseLeftClickOnElementsearchElementMatchText);
                    browserMouseLeftClickOnElementpropCount++;
                }

                if (__workflow_browserMouseLeftClickOnElementsearchElementType != null)
                {
                    browserMouseLeftClickOnElement["SearchElementType"] = ExpressionConverter.ConvertO(__workflow_browserMouseLeftClickOnElementsearchElementType);
                    browserMouseLeftClickOnElementpropCount++;
                }

                if (__workflow_browserMouseLeftClickOnElementsearchElementMinimumWidth != null)
                {
                    if (__workflow_browserMouseLeftClickOnElementsearchElementMinimumWidth != null)
                    {
                        browserMouseLeftClickOnElement["SearchElementMinimumWidth"] = ExpressionConverter.ConvertO(__workflow_browserMouseLeftClickOnElementsearchElementMinimumWidth);
                        browserMouseLeftClickOnElementpropCount++;
                    }

                    browserMouseLeftClickOnElementpropCount++;
                }
                else
                {
                    browserMouseLeftClickOnElement["SearchElementMinimumWidth"] = 1;
                    browserMouseLeftClickOnElementpropCount++;
                }

                if (__workflow_browserMouseLeftClickOnElementsearchElementMinimumHeight != null)
                {
                    if (__workflow_browserMouseLeftClickOnElementsearchElementMinimumHeight != null)
                    {
                        browserMouseLeftClickOnElement["SearchElementMinimumHeight"] = ExpressionConverter.ConvertO(__workflow_browserMouseLeftClickOnElementsearchElementMinimumHeight);
                        browserMouseLeftClickOnElementpropCount++;
                    }

                    browserMouseLeftClickOnElementpropCount++;
                }
                else
                {
                    browserMouseLeftClickOnElement["SearchElementMinimumHeight"] = 1;
                    browserMouseLeftClickOnElementpropCount++;
                }

                if (__workflow_browserMouseLeftClickOnElementsearchElementBoundingBoxLeft != null)
                {
                    if (__workflow_browserMouseLeftClickOnElementsearchElementBoundingBoxLeft != null)
                    {
                        browserMouseLeftClickOnElement["SearchElementBoundingBoxLeft"] = ExpressionConverter.ConvertO(__workflow_browserMouseLeftClickOnElementsearchElementBoundingBoxLeft);
                        browserMouseLeftClickOnElementpropCount++;
                    }

                    browserMouseLeftClickOnElementpropCount++;
                }
                else
                {
                    browserMouseLeftClickOnElement["SearchElementBoundingBoxLeft"] = -99999;
                    browserMouseLeftClickOnElementpropCount++;
                }

                if (__workflow_browserMouseLeftClickOnElementsearchElementBoundingBoxRight != null)
                {
                    if (__workflow_browserMouseLeftClickOnElementsearchElementBoundingBoxRight != null)
                    {
                        browserMouseLeftClickOnElement["SearchElementBoundingBoxRight"] = ExpressionConverter.ConvertO(__workflow_browserMouseLeftClickOnElementsearchElementBoundingBoxRight);
                        browserMouseLeftClickOnElementpropCount++;
                    }

                    browserMouseLeftClickOnElementpropCount++;
                }
                else
                {
                    browserMouseLeftClickOnElement["SearchElementBoundingBoxRight"] = 99999;
                    browserMouseLeftClickOnElementpropCount++;
                }

                if (__workflow_browserMouseLeftClickOnElementsearchElementBoundingBoxTop != null)
                {
                    if (__workflow_browserMouseLeftClickOnElementsearchElementBoundingBoxTop != null)
                    {
                        browserMouseLeftClickOnElement["SearchElementBoundingBoxTop"] = ExpressionConverter.ConvertO(__workflow_browserMouseLeftClickOnElementsearchElementBoundingBoxTop);
                        browserMouseLeftClickOnElementpropCount++;
                    }

                    browserMouseLeftClickOnElementpropCount++;
                }
                else
                {
                    browserMouseLeftClickOnElement["SearchElementBoundingBoxTop"] = -99999;
                    browserMouseLeftClickOnElementpropCount++;
                }

                if (__workflow_browserMouseLeftClickOnElementsearchElementBoundingBoxBottom != null)
                {
                    if (__workflow_browserMouseLeftClickOnElementsearchElementBoundingBoxBottom != null)
                    {
                        browserMouseLeftClickOnElement["SearchElementBoundingBoxBottom"] = ExpressionConverter.ConvertO(__workflow_browserMouseLeftClickOnElementsearchElementBoundingBoxBottom);
                        browserMouseLeftClickOnElementpropCount++;
                    }

                    browserMouseLeftClickOnElementpropCount++;
                }
                else
                {
                    browserMouseLeftClickOnElement["SearchElementBoundingBoxBottom"] = 99999;
                    browserMouseLeftClickOnElementpropCount++;
                }

                if (__workflow_browserMouseLeftClickOnElementonlyElementTopLeftNeedsToBeInBoundingBox != null)
                {
                    if (__workflow_browserMouseLeftClickOnElementonlyElementTopLeftNeedsToBeInBoundingBox != null)
                    {
                        browserMouseLeftClickOnElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = ExpressionConverter.ConvertO(__workflow_browserMouseLeftClickOnElementonlyElementTopLeftNeedsToBeInBoundingBox);
                        browserMouseLeftClickOnElementpropCount++;
                    }

                    browserMouseLeftClickOnElementpropCount++;
                }
                else
                {
                    browserMouseLeftClickOnElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = false;
                    browserMouseLeftClickOnElementpropCount++;
                }

                if (__workflow_browserMouseLeftClickOnElementfocusFirst != null)
                {
                    if (__workflow_browserMouseLeftClickOnElementfocusFirst != null)
                    {
                        browserMouseLeftClickOnElement["FocusFirst"] = ExpressionConverter.ConvertO(__workflow_browserMouseLeftClickOnElementfocusFirst);
                        browserMouseLeftClickOnElementpropCount++;
                    }

                    browserMouseLeftClickOnElementpropCount++;
                }
                else
                {
                    browserMouseLeftClickOnElement["FocusFirst"] = false;
                    browserMouseLeftClickOnElementpropCount++;
                }

                browserMouseLeftClickOnElementpropCount++;
                browserMouseLeftClickOnElement["Workflow"] = ExpressionConverter.ConvertO(__workflow_browserMouseLeftClickOnElementworkflow);
                if (browserMouseLeftClickOnElementpropCount > 0)
                {
                    callPayload.Body = browserMouseLeftClickOnElement;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserMouseRightClickOnElement(Expression<Func<string>> browserMouseRightClickOnElementworkflow, Expression<Func<double>> browserMouseRightClickOnElementparentElementHandle = null, Expression<Func<double>> browserMouseRightClickOnElementsearchElementHandle = null, Expression<Func<string>> browserMouseRightClickOnElementsearchElementName = null, Expression<Func<string>> browserMouseRightClickOnElementsearchElementID = null, Expression<Func<string>> browserMouseRightClickOnElementsearchElementTagName = null, Expression<Func<string>> browserMouseRightClickOnElementsearchElementXPath = null, Expression<Func<string>> browserMouseRightClickOnElementsearchElementClassName = null, Expression<Func<string>> browserMouseRightClickOnElementsearchElementCSSSelector = null, Expression<Func<double>> browserMouseRightClickOnElementsearchElementIndex = null, Expression<Func<string>> browserMouseRightClickOnElementsearchElementMatchValue = null, Expression<Func<string>> browserMouseRightClickOnElementsearchElementMatchText = null, Expression<Func<string>> browserMouseRightClickOnElementsearchElementType = null, Expression<Func<double>> browserMouseRightClickOnElementsearchElementMinimumWidth = null, Expression<Func<double>> browserMouseRightClickOnElementsearchElementMinimumHeight = null, Expression<Func<double>> browserMouseRightClickOnElementsearchElementBoundingBoxLeft = null, Expression<Func<double>> browserMouseRightClickOnElementsearchElementBoundingBoxRight = null, Expression<Func<double>> browserMouseRightClickOnElementsearchElementBoundingBoxTop = null, Expression<Func<double>> browserMouseRightClickOnElementsearchElementBoundingBoxBottom = null, Expression<Func<bool>> browserMouseRightClickOnElementonlyElementTopLeftNeedsToBeInBoundingBox = null, Expression<Func<bool>> browserMouseRightClickOnElementfocusFirst = null)
        {
            var __workflow_browserMouseRightClickOnElementworkflow = WorkflowExpression.Compile(browserMouseRightClickOnElementworkflow, nameof(browserMouseRightClickOnElementworkflow), required: true);
            var __workflow_browserMouseRightClickOnElementparentElementHandle = WorkflowExpression.Compile(browserMouseRightClickOnElementparentElementHandle, nameof(browserMouseRightClickOnElementparentElementHandle), required: false);
            var __workflow_browserMouseRightClickOnElementsearchElementHandle = WorkflowExpression.Compile(browserMouseRightClickOnElementsearchElementHandle, nameof(browserMouseRightClickOnElementsearchElementHandle), required: false);
            var __workflow_browserMouseRightClickOnElementsearchElementName = WorkflowExpression.Compile(browserMouseRightClickOnElementsearchElementName, nameof(browserMouseRightClickOnElementsearchElementName), required: false);
            var __workflow_browserMouseRightClickOnElementsearchElementID = WorkflowExpression.Compile(browserMouseRightClickOnElementsearchElementID, nameof(browserMouseRightClickOnElementsearchElementID), required: false);
            var __workflow_browserMouseRightClickOnElementsearchElementTagName = WorkflowExpression.Compile(browserMouseRightClickOnElementsearchElementTagName, nameof(browserMouseRightClickOnElementsearchElementTagName), required: false);
            var __workflow_browserMouseRightClickOnElementsearchElementXPath = WorkflowExpression.Compile(browserMouseRightClickOnElementsearchElementXPath, nameof(browserMouseRightClickOnElementsearchElementXPath), required: false);
            var __workflow_browserMouseRightClickOnElementsearchElementClassName = WorkflowExpression.Compile(browserMouseRightClickOnElementsearchElementClassName, nameof(browserMouseRightClickOnElementsearchElementClassName), required: false);
            var __workflow_browserMouseRightClickOnElementsearchElementCSSSelector = WorkflowExpression.Compile(browserMouseRightClickOnElementsearchElementCSSSelector, nameof(browserMouseRightClickOnElementsearchElementCSSSelector), required: false);
            var __workflow_browserMouseRightClickOnElementsearchElementIndex = WorkflowExpression.Compile(browserMouseRightClickOnElementsearchElementIndex, nameof(browserMouseRightClickOnElementsearchElementIndex), required: false);
            var __workflow_browserMouseRightClickOnElementsearchElementMatchValue = WorkflowExpression.Compile(browserMouseRightClickOnElementsearchElementMatchValue, nameof(browserMouseRightClickOnElementsearchElementMatchValue), required: false);
            var __workflow_browserMouseRightClickOnElementsearchElementMatchText = WorkflowExpression.Compile(browserMouseRightClickOnElementsearchElementMatchText, nameof(browserMouseRightClickOnElementsearchElementMatchText), required: false);
            var __workflow_browserMouseRightClickOnElementsearchElementType = WorkflowExpression.Compile(browserMouseRightClickOnElementsearchElementType, nameof(browserMouseRightClickOnElementsearchElementType), required: false);
            var __workflow_browserMouseRightClickOnElementsearchElementMinimumWidth = WorkflowExpression.Compile(browserMouseRightClickOnElementsearchElementMinimumWidth, nameof(browserMouseRightClickOnElementsearchElementMinimumWidth), required: false);
            var __workflow_browserMouseRightClickOnElementsearchElementMinimumHeight = WorkflowExpression.Compile(browserMouseRightClickOnElementsearchElementMinimumHeight, nameof(browserMouseRightClickOnElementsearchElementMinimumHeight), required: false);
            var __workflow_browserMouseRightClickOnElementsearchElementBoundingBoxLeft = WorkflowExpression.Compile(browserMouseRightClickOnElementsearchElementBoundingBoxLeft, nameof(browserMouseRightClickOnElementsearchElementBoundingBoxLeft), required: false);
            var __workflow_browserMouseRightClickOnElementsearchElementBoundingBoxRight = WorkflowExpression.Compile(browserMouseRightClickOnElementsearchElementBoundingBoxRight, nameof(browserMouseRightClickOnElementsearchElementBoundingBoxRight), required: false);
            var __workflow_browserMouseRightClickOnElementsearchElementBoundingBoxTop = WorkflowExpression.Compile(browserMouseRightClickOnElementsearchElementBoundingBoxTop, nameof(browserMouseRightClickOnElementsearchElementBoundingBoxTop), required: false);
            var __workflow_browserMouseRightClickOnElementsearchElementBoundingBoxBottom = WorkflowExpression.Compile(browserMouseRightClickOnElementsearchElementBoundingBoxBottom, nameof(browserMouseRightClickOnElementsearchElementBoundingBoxBottom), required: false);
            var __workflow_browserMouseRightClickOnElementonlyElementTopLeftNeedsToBeInBoundingBox = WorkflowExpression.Compile(browserMouseRightClickOnElementonlyElementTopLeftNeedsToBeInBoundingBox, nameof(browserMouseRightClickOnElementonlyElementTopLeftNeedsToBeInBoundingBox), required: false);
            var __workflow_browserMouseRightClickOnElementfocusFirst = WorkflowExpression.Compile(browserMouseRightClickOnElementfocusFirst, nameof(browserMouseRightClickOnElementfocusFirst), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/BrowserControl/MouseRightClickOnElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserMouseRightClickOnElement = new JObject();
                var browserMouseRightClickOnElementpropCount = 0;
                if (__workflow_browserMouseRightClickOnElementparentElementHandle != null)
                {
                    browserMouseRightClickOnElement["ParentElementHandle"] = ExpressionConverter.ConvertO(__workflow_browserMouseRightClickOnElementparentElementHandle);
                    browserMouseRightClickOnElementpropCount++;
                }

                if (__workflow_browserMouseRightClickOnElementsearchElementHandle != null)
                {
                    browserMouseRightClickOnElement["SearchElementHandle"] = ExpressionConverter.ConvertO(__workflow_browserMouseRightClickOnElementsearchElementHandle);
                    browserMouseRightClickOnElementpropCount++;
                }

                if (__workflow_browserMouseRightClickOnElementsearchElementName != null)
                {
                    browserMouseRightClickOnElement["SearchElementName"] = ExpressionConverter.ConvertO(__workflow_browserMouseRightClickOnElementsearchElementName);
                    browserMouseRightClickOnElementpropCount++;
                }

                if (__workflow_browserMouseRightClickOnElementsearchElementID != null)
                {
                    browserMouseRightClickOnElement["SearchElementID"] = ExpressionConverter.ConvertO(__workflow_browserMouseRightClickOnElementsearchElementID);
                    browserMouseRightClickOnElementpropCount++;
                }

                if (__workflow_browserMouseRightClickOnElementsearchElementTagName != null)
                {
                    browserMouseRightClickOnElement["SearchElementTagName"] = ExpressionConverter.ConvertO(__workflow_browserMouseRightClickOnElementsearchElementTagName);
                    browserMouseRightClickOnElementpropCount++;
                }

                if (__workflow_browserMouseRightClickOnElementsearchElementXPath != null)
                {
                    browserMouseRightClickOnElement["SearchElementXPath"] = ExpressionConverter.ConvertO(__workflow_browserMouseRightClickOnElementsearchElementXPath);
                    browserMouseRightClickOnElementpropCount++;
                }

                if (__workflow_browserMouseRightClickOnElementsearchElementClassName != null)
                {
                    browserMouseRightClickOnElement["SearchElementClassName"] = ExpressionConverter.ConvertO(__workflow_browserMouseRightClickOnElementsearchElementClassName);
                    browserMouseRightClickOnElementpropCount++;
                }

                if (__workflow_browserMouseRightClickOnElementsearchElementCSSSelector != null)
                {
                    browserMouseRightClickOnElement["SearchElementCSSSelector"] = ExpressionConverter.ConvertO(__workflow_browserMouseRightClickOnElementsearchElementCSSSelector);
                    browserMouseRightClickOnElementpropCount++;
                }

                if (__workflow_browserMouseRightClickOnElementsearchElementIndex != null)
                {
                    if (__workflow_browserMouseRightClickOnElementsearchElementIndex != null)
                    {
                        browserMouseRightClickOnElement["SearchElementIndex"] = ExpressionConverter.ConvertO(__workflow_browserMouseRightClickOnElementsearchElementIndex);
                        browserMouseRightClickOnElementpropCount++;
                    }

                    browserMouseRightClickOnElementpropCount++;
                }
                else
                {
                    browserMouseRightClickOnElement["SearchElementIndex"] = 1;
                    browserMouseRightClickOnElementpropCount++;
                }

                if (__workflow_browserMouseRightClickOnElementsearchElementMatchValue != null)
                {
                    browserMouseRightClickOnElement["SearchElementMatchValue"] = ExpressionConverter.ConvertO(__workflow_browserMouseRightClickOnElementsearchElementMatchValue);
                    browserMouseRightClickOnElementpropCount++;
                }

                if (__workflow_browserMouseRightClickOnElementsearchElementMatchText != null)
                {
                    browserMouseRightClickOnElement["SearchElementMatchText"] = ExpressionConverter.ConvertO(__workflow_browserMouseRightClickOnElementsearchElementMatchText);
                    browserMouseRightClickOnElementpropCount++;
                }

                if (__workflow_browserMouseRightClickOnElementsearchElementType != null)
                {
                    browserMouseRightClickOnElement["SearchElementType"] = ExpressionConverter.ConvertO(__workflow_browserMouseRightClickOnElementsearchElementType);
                    browserMouseRightClickOnElementpropCount++;
                }

                if (__workflow_browserMouseRightClickOnElementsearchElementMinimumWidth != null)
                {
                    if (__workflow_browserMouseRightClickOnElementsearchElementMinimumWidth != null)
                    {
                        browserMouseRightClickOnElement["SearchElementMinimumWidth"] = ExpressionConverter.ConvertO(__workflow_browserMouseRightClickOnElementsearchElementMinimumWidth);
                        browserMouseRightClickOnElementpropCount++;
                    }

                    browserMouseRightClickOnElementpropCount++;
                }
                else
                {
                    browserMouseRightClickOnElement["SearchElementMinimumWidth"] = 1;
                    browserMouseRightClickOnElementpropCount++;
                }

                if (__workflow_browserMouseRightClickOnElementsearchElementMinimumHeight != null)
                {
                    if (__workflow_browserMouseRightClickOnElementsearchElementMinimumHeight != null)
                    {
                        browserMouseRightClickOnElement["SearchElementMinimumHeight"] = ExpressionConverter.ConvertO(__workflow_browserMouseRightClickOnElementsearchElementMinimumHeight);
                        browserMouseRightClickOnElementpropCount++;
                    }

                    browserMouseRightClickOnElementpropCount++;
                }
                else
                {
                    browserMouseRightClickOnElement["SearchElementMinimumHeight"] = 1;
                    browserMouseRightClickOnElementpropCount++;
                }

                if (__workflow_browserMouseRightClickOnElementsearchElementBoundingBoxLeft != null)
                {
                    if (__workflow_browserMouseRightClickOnElementsearchElementBoundingBoxLeft != null)
                    {
                        browserMouseRightClickOnElement["SearchElementBoundingBoxLeft"] = ExpressionConverter.ConvertO(__workflow_browserMouseRightClickOnElementsearchElementBoundingBoxLeft);
                        browserMouseRightClickOnElementpropCount++;
                    }

                    browserMouseRightClickOnElementpropCount++;
                }
                else
                {
                    browserMouseRightClickOnElement["SearchElementBoundingBoxLeft"] = -99999;
                    browserMouseRightClickOnElementpropCount++;
                }

                if (__workflow_browserMouseRightClickOnElementsearchElementBoundingBoxRight != null)
                {
                    if (__workflow_browserMouseRightClickOnElementsearchElementBoundingBoxRight != null)
                    {
                        browserMouseRightClickOnElement["SearchElementBoundingBoxRight"] = ExpressionConverter.ConvertO(__workflow_browserMouseRightClickOnElementsearchElementBoundingBoxRight);
                        browserMouseRightClickOnElementpropCount++;
                    }

                    browserMouseRightClickOnElementpropCount++;
                }
                else
                {
                    browserMouseRightClickOnElement["SearchElementBoundingBoxRight"] = 99999;
                    browserMouseRightClickOnElementpropCount++;
                }

                if (__workflow_browserMouseRightClickOnElementsearchElementBoundingBoxTop != null)
                {
                    if (__workflow_browserMouseRightClickOnElementsearchElementBoundingBoxTop != null)
                    {
                        browserMouseRightClickOnElement["SearchElementBoundingBoxTop"] = ExpressionConverter.ConvertO(__workflow_browserMouseRightClickOnElementsearchElementBoundingBoxTop);
                        browserMouseRightClickOnElementpropCount++;
                    }

                    browserMouseRightClickOnElementpropCount++;
                }
                else
                {
                    browserMouseRightClickOnElement["SearchElementBoundingBoxTop"] = -99999;
                    browserMouseRightClickOnElementpropCount++;
                }

                if (__workflow_browserMouseRightClickOnElementsearchElementBoundingBoxBottom != null)
                {
                    if (__workflow_browserMouseRightClickOnElementsearchElementBoundingBoxBottom != null)
                    {
                        browserMouseRightClickOnElement["SearchElementBoundingBoxBottom"] = ExpressionConverter.ConvertO(__workflow_browserMouseRightClickOnElementsearchElementBoundingBoxBottom);
                        browserMouseRightClickOnElementpropCount++;
                    }

                    browserMouseRightClickOnElementpropCount++;
                }
                else
                {
                    browserMouseRightClickOnElement["SearchElementBoundingBoxBottom"] = 99999;
                    browserMouseRightClickOnElementpropCount++;
                }

                if (__workflow_browserMouseRightClickOnElementonlyElementTopLeftNeedsToBeInBoundingBox != null)
                {
                    if (__workflow_browserMouseRightClickOnElementonlyElementTopLeftNeedsToBeInBoundingBox != null)
                    {
                        browserMouseRightClickOnElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = ExpressionConverter.ConvertO(__workflow_browserMouseRightClickOnElementonlyElementTopLeftNeedsToBeInBoundingBox);
                        browserMouseRightClickOnElementpropCount++;
                    }

                    browserMouseRightClickOnElementpropCount++;
                }
                else
                {
                    browserMouseRightClickOnElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = false;
                    browserMouseRightClickOnElementpropCount++;
                }

                if (__workflow_browserMouseRightClickOnElementfocusFirst != null)
                {
                    if (__workflow_browserMouseRightClickOnElementfocusFirst != null)
                    {
                        browserMouseRightClickOnElement["FocusFirst"] = ExpressionConverter.ConvertO(__workflow_browserMouseRightClickOnElementfocusFirst);
                        browserMouseRightClickOnElementpropCount++;
                    }

                    browserMouseRightClickOnElementpropCount++;
                }
                else
                {
                    browserMouseRightClickOnElement["FocusFirst"] = false;
                    browserMouseRightClickOnElementpropCount++;
                }

                browserMouseRightClickOnElementpropCount++;
                browserMouseRightClickOnElement["Workflow"] = ExpressionConverter.ConvertO(__workflow_browserMouseRightClickOnElementworkflow);
                if (browserMouseRightClickOnElementpropCount > 0)
                {
                    callPayload.Body = browserMouseRightClickOnElement;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserJavaScriptClickOnElement(Expression<Func<string>> browserJavaScriptClickOnElementworkflow, Expression<Func<double>> browserJavaScriptClickOnElementparentElementHandle = null, Expression<Func<double>> browserJavaScriptClickOnElementsearchElementHandle = null, Expression<Func<string>> browserJavaScriptClickOnElementsearchElementName = null, Expression<Func<string>> browserJavaScriptClickOnElementsearchElementID = null, Expression<Func<string>> browserJavaScriptClickOnElementsearchElementTagName = null, Expression<Func<string>> browserJavaScriptClickOnElementsearchElementXPath = null, Expression<Func<string>> browserJavaScriptClickOnElementsearchElementClassName = null, Expression<Func<string>> browserJavaScriptClickOnElementsearchElementCSSSelector = null, Expression<Func<double>> browserJavaScriptClickOnElementsearchElementIndex = null, Expression<Func<string>> browserJavaScriptClickOnElementsearchElementMatchValue = null, Expression<Func<string>> browserJavaScriptClickOnElementsearchElementMatchText = null, Expression<Func<string>> browserJavaScriptClickOnElementsearchElementType = null, Expression<Func<double>> browserJavaScriptClickOnElementsearchElementMinimumWidth = null, Expression<Func<double>> browserJavaScriptClickOnElementsearchElementMinimumHeight = null, Expression<Func<double>> browserJavaScriptClickOnElementsearchElementBoundingBoxLeft = null, Expression<Func<double>> browserJavaScriptClickOnElementsearchElementBoundingBoxRight = null, Expression<Func<double>> browserJavaScriptClickOnElementsearchElementBoundingBoxTop = null, Expression<Func<double>> browserJavaScriptClickOnElementsearchElementBoundingBoxBottom = null, Expression<Func<bool>> browserJavaScriptClickOnElementonlyElementTopLeftNeedsToBeInBoundingBox = null)
        {
            var __workflow_browserJavaScriptClickOnElementworkflow = WorkflowExpression.Compile(browserJavaScriptClickOnElementworkflow, nameof(browserJavaScriptClickOnElementworkflow), required: true);
            var __workflow_browserJavaScriptClickOnElementparentElementHandle = WorkflowExpression.Compile(browserJavaScriptClickOnElementparentElementHandle, nameof(browserJavaScriptClickOnElementparentElementHandle), required: false);
            var __workflow_browserJavaScriptClickOnElementsearchElementHandle = WorkflowExpression.Compile(browserJavaScriptClickOnElementsearchElementHandle, nameof(browserJavaScriptClickOnElementsearchElementHandle), required: false);
            var __workflow_browserJavaScriptClickOnElementsearchElementName = WorkflowExpression.Compile(browserJavaScriptClickOnElementsearchElementName, nameof(browserJavaScriptClickOnElementsearchElementName), required: false);
            var __workflow_browserJavaScriptClickOnElementsearchElementID = WorkflowExpression.Compile(browserJavaScriptClickOnElementsearchElementID, nameof(browserJavaScriptClickOnElementsearchElementID), required: false);
            var __workflow_browserJavaScriptClickOnElementsearchElementTagName = WorkflowExpression.Compile(browserJavaScriptClickOnElementsearchElementTagName, nameof(browserJavaScriptClickOnElementsearchElementTagName), required: false);
            var __workflow_browserJavaScriptClickOnElementsearchElementXPath = WorkflowExpression.Compile(browserJavaScriptClickOnElementsearchElementXPath, nameof(browserJavaScriptClickOnElementsearchElementXPath), required: false);
            var __workflow_browserJavaScriptClickOnElementsearchElementClassName = WorkflowExpression.Compile(browserJavaScriptClickOnElementsearchElementClassName, nameof(browserJavaScriptClickOnElementsearchElementClassName), required: false);
            var __workflow_browserJavaScriptClickOnElementsearchElementCSSSelector = WorkflowExpression.Compile(browserJavaScriptClickOnElementsearchElementCSSSelector, nameof(browserJavaScriptClickOnElementsearchElementCSSSelector), required: false);
            var __workflow_browserJavaScriptClickOnElementsearchElementIndex = WorkflowExpression.Compile(browserJavaScriptClickOnElementsearchElementIndex, nameof(browserJavaScriptClickOnElementsearchElementIndex), required: false);
            var __workflow_browserJavaScriptClickOnElementsearchElementMatchValue = WorkflowExpression.Compile(browserJavaScriptClickOnElementsearchElementMatchValue, nameof(browserJavaScriptClickOnElementsearchElementMatchValue), required: false);
            var __workflow_browserJavaScriptClickOnElementsearchElementMatchText = WorkflowExpression.Compile(browserJavaScriptClickOnElementsearchElementMatchText, nameof(browserJavaScriptClickOnElementsearchElementMatchText), required: false);
            var __workflow_browserJavaScriptClickOnElementsearchElementType = WorkflowExpression.Compile(browserJavaScriptClickOnElementsearchElementType, nameof(browserJavaScriptClickOnElementsearchElementType), required: false);
            var __workflow_browserJavaScriptClickOnElementsearchElementMinimumWidth = WorkflowExpression.Compile(browserJavaScriptClickOnElementsearchElementMinimumWidth, nameof(browserJavaScriptClickOnElementsearchElementMinimumWidth), required: false);
            var __workflow_browserJavaScriptClickOnElementsearchElementMinimumHeight = WorkflowExpression.Compile(browserJavaScriptClickOnElementsearchElementMinimumHeight, nameof(browserJavaScriptClickOnElementsearchElementMinimumHeight), required: false);
            var __workflow_browserJavaScriptClickOnElementsearchElementBoundingBoxLeft = WorkflowExpression.Compile(browserJavaScriptClickOnElementsearchElementBoundingBoxLeft, nameof(browserJavaScriptClickOnElementsearchElementBoundingBoxLeft), required: false);
            var __workflow_browserJavaScriptClickOnElementsearchElementBoundingBoxRight = WorkflowExpression.Compile(browserJavaScriptClickOnElementsearchElementBoundingBoxRight, nameof(browserJavaScriptClickOnElementsearchElementBoundingBoxRight), required: false);
            var __workflow_browserJavaScriptClickOnElementsearchElementBoundingBoxTop = WorkflowExpression.Compile(browserJavaScriptClickOnElementsearchElementBoundingBoxTop, nameof(browserJavaScriptClickOnElementsearchElementBoundingBoxTop), required: false);
            var __workflow_browserJavaScriptClickOnElementsearchElementBoundingBoxBottom = WorkflowExpression.Compile(browserJavaScriptClickOnElementsearchElementBoundingBoxBottom, nameof(browserJavaScriptClickOnElementsearchElementBoundingBoxBottom), required: false);
            var __workflow_browserJavaScriptClickOnElementonlyElementTopLeftNeedsToBeInBoundingBox = WorkflowExpression.Compile(browserJavaScriptClickOnElementonlyElementTopLeftNeedsToBeInBoundingBox, nameof(browserJavaScriptClickOnElementonlyElementTopLeftNeedsToBeInBoundingBox), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/BrowserControl/JavaScriptClickOnElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserJavaScriptClickOnElement = new JObject();
                var browserJavaScriptClickOnElementpropCount = 0;
                if (__workflow_browserJavaScriptClickOnElementparentElementHandle != null)
                {
                    browserJavaScriptClickOnElement["ParentElementHandle"] = ExpressionConverter.ConvertO(__workflow_browserJavaScriptClickOnElementparentElementHandle);
                    browserJavaScriptClickOnElementpropCount++;
                }

                if (__workflow_browserJavaScriptClickOnElementsearchElementHandle != null)
                {
                    browserJavaScriptClickOnElement["SearchElementHandle"] = ExpressionConverter.ConvertO(__workflow_browserJavaScriptClickOnElementsearchElementHandle);
                    browserJavaScriptClickOnElementpropCount++;
                }

                if (__workflow_browserJavaScriptClickOnElementsearchElementName != null)
                {
                    browserJavaScriptClickOnElement["SearchElementName"] = ExpressionConverter.ConvertO(__workflow_browserJavaScriptClickOnElementsearchElementName);
                    browserJavaScriptClickOnElementpropCount++;
                }

                if (__workflow_browserJavaScriptClickOnElementsearchElementID != null)
                {
                    browserJavaScriptClickOnElement["SearchElementID"] = ExpressionConverter.ConvertO(__workflow_browserJavaScriptClickOnElementsearchElementID);
                    browserJavaScriptClickOnElementpropCount++;
                }

                if (__workflow_browserJavaScriptClickOnElementsearchElementTagName != null)
                {
                    browserJavaScriptClickOnElement["SearchElementTagName"] = ExpressionConverter.ConvertO(__workflow_browserJavaScriptClickOnElementsearchElementTagName);
                    browserJavaScriptClickOnElementpropCount++;
                }

                if (__workflow_browserJavaScriptClickOnElementsearchElementXPath != null)
                {
                    browserJavaScriptClickOnElement["SearchElementXPath"] = ExpressionConverter.ConvertO(__workflow_browserJavaScriptClickOnElementsearchElementXPath);
                    browserJavaScriptClickOnElementpropCount++;
                }

                if (__workflow_browserJavaScriptClickOnElementsearchElementClassName != null)
                {
                    browserJavaScriptClickOnElement["SearchElementClassName"] = ExpressionConverter.ConvertO(__workflow_browserJavaScriptClickOnElementsearchElementClassName);
                    browserJavaScriptClickOnElementpropCount++;
                }

                if (__workflow_browserJavaScriptClickOnElementsearchElementCSSSelector != null)
                {
                    browserJavaScriptClickOnElement["SearchElementCSSSelector"] = ExpressionConverter.ConvertO(__workflow_browserJavaScriptClickOnElementsearchElementCSSSelector);
                    browserJavaScriptClickOnElementpropCount++;
                }

                if (__workflow_browserJavaScriptClickOnElementsearchElementIndex != null)
                {
                    if (__workflow_browserJavaScriptClickOnElementsearchElementIndex != null)
                    {
                        browserJavaScriptClickOnElement["SearchElementIndex"] = ExpressionConverter.ConvertO(__workflow_browserJavaScriptClickOnElementsearchElementIndex);
                        browserJavaScriptClickOnElementpropCount++;
                    }

                    browserJavaScriptClickOnElementpropCount++;
                }
                else
                {
                    browserJavaScriptClickOnElement["SearchElementIndex"] = 1;
                    browserJavaScriptClickOnElementpropCount++;
                }

                if (__workflow_browserJavaScriptClickOnElementsearchElementMatchValue != null)
                {
                    browserJavaScriptClickOnElement["SearchElementMatchValue"] = ExpressionConverter.ConvertO(__workflow_browserJavaScriptClickOnElementsearchElementMatchValue);
                    browserJavaScriptClickOnElementpropCount++;
                }

                if (__workflow_browserJavaScriptClickOnElementsearchElementMatchText != null)
                {
                    browserJavaScriptClickOnElement["SearchElementMatchText"] = ExpressionConverter.ConvertO(__workflow_browserJavaScriptClickOnElementsearchElementMatchText);
                    browserJavaScriptClickOnElementpropCount++;
                }

                if (__workflow_browserJavaScriptClickOnElementsearchElementType != null)
                {
                    browserJavaScriptClickOnElement["SearchElementType"] = ExpressionConverter.ConvertO(__workflow_browserJavaScriptClickOnElementsearchElementType);
                    browserJavaScriptClickOnElementpropCount++;
                }

                if (__workflow_browserJavaScriptClickOnElementsearchElementMinimumWidth != null)
                {
                    if (__workflow_browserJavaScriptClickOnElementsearchElementMinimumWidth != null)
                    {
                        browserJavaScriptClickOnElement["SearchElementMinimumWidth"] = ExpressionConverter.ConvertO(__workflow_browserJavaScriptClickOnElementsearchElementMinimumWidth);
                        browserJavaScriptClickOnElementpropCount++;
                    }

                    browserJavaScriptClickOnElementpropCount++;
                }
                else
                {
                    browserJavaScriptClickOnElement["SearchElementMinimumWidth"] = 1;
                    browserJavaScriptClickOnElementpropCount++;
                }

                if (__workflow_browserJavaScriptClickOnElementsearchElementMinimumHeight != null)
                {
                    if (__workflow_browserJavaScriptClickOnElementsearchElementMinimumHeight != null)
                    {
                        browserJavaScriptClickOnElement["SearchElementMinimumHeight"] = ExpressionConverter.ConvertO(__workflow_browserJavaScriptClickOnElementsearchElementMinimumHeight);
                        browserJavaScriptClickOnElementpropCount++;
                    }

                    browserJavaScriptClickOnElementpropCount++;
                }
                else
                {
                    browserJavaScriptClickOnElement["SearchElementMinimumHeight"] = 1;
                    browserJavaScriptClickOnElementpropCount++;
                }

                if (__workflow_browserJavaScriptClickOnElementsearchElementBoundingBoxLeft != null)
                {
                    if (__workflow_browserJavaScriptClickOnElementsearchElementBoundingBoxLeft != null)
                    {
                        browserJavaScriptClickOnElement["SearchElementBoundingBoxLeft"] = ExpressionConverter.ConvertO(__workflow_browserJavaScriptClickOnElementsearchElementBoundingBoxLeft);
                        browserJavaScriptClickOnElementpropCount++;
                    }

                    browserJavaScriptClickOnElementpropCount++;
                }
                else
                {
                    browserJavaScriptClickOnElement["SearchElementBoundingBoxLeft"] = -99999;
                    browserJavaScriptClickOnElementpropCount++;
                }

                if (__workflow_browserJavaScriptClickOnElementsearchElementBoundingBoxRight != null)
                {
                    if (__workflow_browserJavaScriptClickOnElementsearchElementBoundingBoxRight != null)
                    {
                        browserJavaScriptClickOnElement["SearchElementBoundingBoxRight"] = ExpressionConverter.ConvertO(__workflow_browserJavaScriptClickOnElementsearchElementBoundingBoxRight);
                        browserJavaScriptClickOnElementpropCount++;
                    }

                    browserJavaScriptClickOnElementpropCount++;
                }
                else
                {
                    browserJavaScriptClickOnElement["SearchElementBoundingBoxRight"] = 99999;
                    browserJavaScriptClickOnElementpropCount++;
                }

                if (__workflow_browserJavaScriptClickOnElementsearchElementBoundingBoxTop != null)
                {
                    if (__workflow_browserJavaScriptClickOnElementsearchElementBoundingBoxTop != null)
                    {
                        browserJavaScriptClickOnElement["SearchElementBoundingBoxTop"] = ExpressionConverter.ConvertO(__workflow_browserJavaScriptClickOnElementsearchElementBoundingBoxTop);
                        browserJavaScriptClickOnElementpropCount++;
                    }

                    browserJavaScriptClickOnElementpropCount++;
                }
                else
                {
                    browserJavaScriptClickOnElement["SearchElementBoundingBoxTop"] = -99999;
                    browserJavaScriptClickOnElementpropCount++;
                }

                if (__workflow_browserJavaScriptClickOnElementsearchElementBoundingBoxBottom != null)
                {
                    if (__workflow_browserJavaScriptClickOnElementsearchElementBoundingBoxBottom != null)
                    {
                        browserJavaScriptClickOnElement["SearchElementBoundingBoxBottom"] = ExpressionConverter.ConvertO(__workflow_browserJavaScriptClickOnElementsearchElementBoundingBoxBottom);
                        browserJavaScriptClickOnElementpropCount++;
                    }

                    browserJavaScriptClickOnElementpropCount++;
                }
                else
                {
                    browserJavaScriptClickOnElement["SearchElementBoundingBoxBottom"] = 99999;
                    browserJavaScriptClickOnElementpropCount++;
                }

                if (__workflow_browserJavaScriptClickOnElementonlyElementTopLeftNeedsToBeInBoundingBox != null)
                {
                    if (__workflow_browserJavaScriptClickOnElementonlyElementTopLeftNeedsToBeInBoundingBox != null)
                    {
                        browserJavaScriptClickOnElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = ExpressionConverter.ConvertO(__workflow_browserJavaScriptClickOnElementonlyElementTopLeftNeedsToBeInBoundingBox);
                        browserJavaScriptClickOnElementpropCount++;
                    }

                    browserJavaScriptClickOnElementpropCount++;
                }
                else
                {
                    browserJavaScriptClickOnElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = false;
                    browserJavaScriptClickOnElementpropCount++;
                }

                browserJavaScriptClickOnElementpropCount++;
                browserJavaScriptClickOnElement["Workflow"] = ExpressionConverter.ConvertO(__workflow_browserJavaScriptClickOnElementworkflow);
                if (browserJavaScriptClickOnElementpropCount > 0)
                {
                    callPayload.Body = browserJavaScriptClickOnElement;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserExecuteJavaScriptOnElementResponse> BrowserExecuteJavaScriptOnElement(Expression<Func<string>> browserExecuteJavaScriptOnElementjavaScriptToExecute, Expression<Func<string>> browserExecuteJavaScriptOnElementworkflow, Expression<Func<double>> browserExecuteJavaScriptOnElementparentElementHandle = null, Expression<Func<double>> browserExecuteJavaScriptOnElementsearchElementHandle = null, Expression<Func<string>> browserExecuteJavaScriptOnElementsearchElementName = null, Expression<Func<string>> browserExecuteJavaScriptOnElementsearchElementID = null, Expression<Func<string>> browserExecuteJavaScriptOnElementsearchElementTagName = null, Expression<Func<string>> browserExecuteJavaScriptOnElementsearchElementXPath = null, Expression<Func<string>> browserExecuteJavaScriptOnElementsearchElementClassName = null, Expression<Func<string>> browserExecuteJavaScriptOnElementsearchElementCSSSelector = null, Expression<Func<double>> browserExecuteJavaScriptOnElementsearchElementIndex = null, Expression<Func<string>> browserExecuteJavaScriptOnElementsearchElementMatchValue = null, Expression<Func<string>> browserExecuteJavaScriptOnElementsearchElementMatchText = null, Expression<Func<string>> browserExecuteJavaScriptOnElementsearchElementType = null, Expression<Func<double>> browserExecuteJavaScriptOnElementsearchElementMinimumWidth = null, Expression<Func<double>> browserExecuteJavaScriptOnElementsearchElementMinimumHeight = null, Expression<Func<double>> browserExecuteJavaScriptOnElementsearchElementBoundingBoxLeft = null, Expression<Func<double>> browserExecuteJavaScriptOnElementsearchElementBoundingBoxRight = null, Expression<Func<double>> browserExecuteJavaScriptOnElementsearchElementBoundingBoxTop = null, Expression<Func<double>> browserExecuteJavaScriptOnElementsearchElementBoundingBoxBottom = null, Expression<Func<bool>> browserExecuteJavaScriptOnElementonlyElementTopLeftNeedsToBeInBoundingBox = null)
        {
            var __workflow_browserExecuteJavaScriptOnElementjavaScriptToExecute = WorkflowExpression.Compile(browserExecuteJavaScriptOnElementjavaScriptToExecute, nameof(browserExecuteJavaScriptOnElementjavaScriptToExecute), required: true);
            var __workflow_browserExecuteJavaScriptOnElementworkflow = WorkflowExpression.Compile(browserExecuteJavaScriptOnElementworkflow, nameof(browserExecuteJavaScriptOnElementworkflow), required: true);
            var __workflow_browserExecuteJavaScriptOnElementparentElementHandle = WorkflowExpression.Compile(browserExecuteJavaScriptOnElementparentElementHandle, nameof(browserExecuteJavaScriptOnElementparentElementHandle), required: false);
            var __workflow_browserExecuteJavaScriptOnElementsearchElementHandle = WorkflowExpression.Compile(browserExecuteJavaScriptOnElementsearchElementHandle, nameof(browserExecuteJavaScriptOnElementsearchElementHandle), required: false);
            var __workflow_browserExecuteJavaScriptOnElementsearchElementName = WorkflowExpression.Compile(browserExecuteJavaScriptOnElementsearchElementName, nameof(browserExecuteJavaScriptOnElementsearchElementName), required: false);
            var __workflow_browserExecuteJavaScriptOnElementsearchElementID = WorkflowExpression.Compile(browserExecuteJavaScriptOnElementsearchElementID, nameof(browserExecuteJavaScriptOnElementsearchElementID), required: false);
            var __workflow_browserExecuteJavaScriptOnElementsearchElementTagName = WorkflowExpression.Compile(browserExecuteJavaScriptOnElementsearchElementTagName, nameof(browserExecuteJavaScriptOnElementsearchElementTagName), required: false);
            var __workflow_browserExecuteJavaScriptOnElementsearchElementXPath = WorkflowExpression.Compile(browserExecuteJavaScriptOnElementsearchElementXPath, nameof(browserExecuteJavaScriptOnElementsearchElementXPath), required: false);
            var __workflow_browserExecuteJavaScriptOnElementsearchElementClassName = WorkflowExpression.Compile(browserExecuteJavaScriptOnElementsearchElementClassName, nameof(browserExecuteJavaScriptOnElementsearchElementClassName), required: false);
            var __workflow_browserExecuteJavaScriptOnElementsearchElementCSSSelector = WorkflowExpression.Compile(browserExecuteJavaScriptOnElementsearchElementCSSSelector, nameof(browserExecuteJavaScriptOnElementsearchElementCSSSelector), required: false);
            var __workflow_browserExecuteJavaScriptOnElementsearchElementIndex = WorkflowExpression.Compile(browserExecuteJavaScriptOnElementsearchElementIndex, nameof(browserExecuteJavaScriptOnElementsearchElementIndex), required: false);
            var __workflow_browserExecuteJavaScriptOnElementsearchElementMatchValue = WorkflowExpression.Compile(browserExecuteJavaScriptOnElementsearchElementMatchValue, nameof(browserExecuteJavaScriptOnElementsearchElementMatchValue), required: false);
            var __workflow_browserExecuteJavaScriptOnElementsearchElementMatchText = WorkflowExpression.Compile(browserExecuteJavaScriptOnElementsearchElementMatchText, nameof(browserExecuteJavaScriptOnElementsearchElementMatchText), required: false);
            var __workflow_browserExecuteJavaScriptOnElementsearchElementType = WorkflowExpression.Compile(browserExecuteJavaScriptOnElementsearchElementType, nameof(browserExecuteJavaScriptOnElementsearchElementType), required: false);
            var __workflow_browserExecuteJavaScriptOnElementsearchElementMinimumWidth = WorkflowExpression.Compile(browserExecuteJavaScriptOnElementsearchElementMinimumWidth, nameof(browserExecuteJavaScriptOnElementsearchElementMinimumWidth), required: false);
            var __workflow_browserExecuteJavaScriptOnElementsearchElementMinimumHeight = WorkflowExpression.Compile(browserExecuteJavaScriptOnElementsearchElementMinimumHeight, nameof(browserExecuteJavaScriptOnElementsearchElementMinimumHeight), required: false);
            var __workflow_browserExecuteJavaScriptOnElementsearchElementBoundingBoxLeft = WorkflowExpression.Compile(browserExecuteJavaScriptOnElementsearchElementBoundingBoxLeft, nameof(browserExecuteJavaScriptOnElementsearchElementBoundingBoxLeft), required: false);
            var __workflow_browserExecuteJavaScriptOnElementsearchElementBoundingBoxRight = WorkflowExpression.Compile(browserExecuteJavaScriptOnElementsearchElementBoundingBoxRight, nameof(browserExecuteJavaScriptOnElementsearchElementBoundingBoxRight), required: false);
            var __workflow_browserExecuteJavaScriptOnElementsearchElementBoundingBoxTop = WorkflowExpression.Compile(browserExecuteJavaScriptOnElementsearchElementBoundingBoxTop, nameof(browserExecuteJavaScriptOnElementsearchElementBoundingBoxTop), required: false);
            var __workflow_browserExecuteJavaScriptOnElementsearchElementBoundingBoxBottom = WorkflowExpression.Compile(browserExecuteJavaScriptOnElementsearchElementBoundingBoxBottom, nameof(browserExecuteJavaScriptOnElementsearchElementBoundingBoxBottom), required: false);
            var __workflow_browserExecuteJavaScriptOnElementonlyElementTopLeftNeedsToBeInBoundingBox = WorkflowExpression.Compile(browserExecuteJavaScriptOnElementonlyElementTopLeftNeedsToBeInBoundingBox, nameof(browserExecuteJavaScriptOnElementonlyElementTopLeftNeedsToBeInBoundingBox), required: false);
            return new DeferredBodyAction<BrowserExecuteJavaScriptOnElementResponse>(() =>
            {
                var apiCallPath = "/BrowserControl/ExecuteJavaScriptOnElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserExecuteJavaScriptOnElement = new JObject();
                var browserExecuteJavaScriptOnElementpropCount = 0;
                if (__workflow_browserExecuteJavaScriptOnElementparentElementHandle != null)
                {
                    browserExecuteJavaScriptOnElement["ParentElementHandle"] = ExpressionConverter.ConvertO(__workflow_browserExecuteJavaScriptOnElementparentElementHandle);
                    browserExecuteJavaScriptOnElementpropCount++;
                }

                if (__workflow_browserExecuteJavaScriptOnElementsearchElementHandle != null)
                {
                    browserExecuteJavaScriptOnElement["SearchElementHandle"] = ExpressionConverter.ConvertO(__workflow_browserExecuteJavaScriptOnElementsearchElementHandle);
                    browserExecuteJavaScriptOnElementpropCount++;
                }

                if (__workflow_browserExecuteJavaScriptOnElementsearchElementName != null)
                {
                    browserExecuteJavaScriptOnElement["SearchElementName"] = ExpressionConverter.ConvertO(__workflow_browserExecuteJavaScriptOnElementsearchElementName);
                    browserExecuteJavaScriptOnElementpropCount++;
                }

                if (__workflow_browserExecuteJavaScriptOnElementsearchElementID != null)
                {
                    browserExecuteJavaScriptOnElement["SearchElementID"] = ExpressionConverter.ConvertO(__workflow_browserExecuteJavaScriptOnElementsearchElementID);
                    browserExecuteJavaScriptOnElementpropCount++;
                }

                if (__workflow_browserExecuteJavaScriptOnElementsearchElementTagName != null)
                {
                    browserExecuteJavaScriptOnElement["SearchElementTagName"] = ExpressionConverter.ConvertO(__workflow_browserExecuteJavaScriptOnElementsearchElementTagName);
                    browserExecuteJavaScriptOnElementpropCount++;
                }

                if (__workflow_browserExecuteJavaScriptOnElementsearchElementXPath != null)
                {
                    browserExecuteJavaScriptOnElement["SearchElementXPath"] = ExpressionConverter.ConvertO(__workflow_browserExecuteJavaScriptOnElementsearchElementXPath);
                    browserExecuteJavaScriptOnElementpropCount++;
                }

                if (__workflow_browserExecuteJavaScriptOnElementsearchElementClassName != null)
                {
                    browserExecuteJavaScriptOnElement["SearchElementClassName"] = ExpressionConverter.ConvertO(__workflow_browserExecuteJavaScriptOnElementsearchElementClassName);
                    browserExecuteJavaScriptOnElementpropCount++;
                }

                if (__workflow_browserExecuteJavaScriptOnElementsearchElementCSSSelector != null)
                {
                    browserExecuteJavaScriptOnElement["SearchElementCSSSelector"] = ExpressionConverter.ConvertO(__workflow_browserExecuteJavaScriptOnElementsearchElementCSSSelector);
                    browserExecuteJavaScriptOnElementpropCount++;
                }

                if (__workflow_browserExecuteJavaScriptOnElementsearchElementIndex != null)
                {
                    if (__workflow_browserExecuteJavaScriptOnElementsearchElementIndex != null)
                    {
                        browserExecuteJavaScriptOnElement["SearchElementIndex"] = ExpressionConverter.ConvertO(__workflow_browserExecuteJavaScriptOnElementsearchElementIndex);
                        browserExecuteJavaScriptOnElementpropCount++;
                    }

                    browserExecuteJavaScriptOnElementpropCount++;
                }
                else
                {
                    browserExecuteJavaScriptOnElement["SearchElementIndex"] = 1;
                    browserExecuteJavaScriptOnElementpropCount++;
                }

                if (__workflow_browserExecuteJavaScriptOnElementsearchElementMatchValue != null)
                {
                    browserExecuteJavaScriptOnElement["SearchElementMatchValue"] = ExpressionConverter.ConvertO(__workflow_browserExecuteJavaScriptOnElementsearchElementMatchValue);
                    browserExecuteJavaScriptOnElementpropCount++;
                }

                if (__workflow_browserExecuteJavaScriptOnElementsearchElementMatchText != null)
                {
                    browserExecuteJavaScriptOnElement["SearchElementMatchText"] = ExpressionConverter.ConvertO(__workflow_browserExecuteJavaScriptOnElementsearchElementMatchText);
                    browserExecuteJavaScriptOnElementpropCount++;
                }

                if (__workflow_browserExecuteJavaScriptOnElementsearchElementType != null)
                {
                    browserExecuteJavaScriptOnElement["SearchElementType"] = ExpressionConverter.ConvertO(__workflow_browserExecuteJavaScriptOnElementsearchElementType);
                    browserExecuteJavaScriptOnElementpropCount++;
                }

                if (__workflow_browserExecuteJavaScriptOnElementsearchElementMinimumWidth != null)
                {
                    if (__workflow_browserExecuteJavaScriptOnElementsearchElementMinimumWidth != null)
                    {
                        browserExecuteJavaScriptOnElement["SearchElementMinimumWidth"] = ExpressionConverter.ConvertO(__workflow_browserExecuteJavaScriptOnElementsearchElementMinimumWidth);
                        browserExecuteJavaScriptOnElementpropCount++;
                    }

                    browserExecuteJavaScriptOnElementpropCount++;
                }
                else
                {
                    browserExecuteJavaScriptOnElement["SearchElementMinimumWidth"] = 1;
                    browserExecuteJavaScriptOnElementpropCount++;
                }

                if (__workflow_browserExecuteJavaScriptOnElementsearchElementMinimumHeight != null)
                {
                    if (__workflow_browserExecuteJavaScriptOnElementsearchElementMinimumHeight != null)
                    {
                        browserExecuteJavaScriptOnElement["SearchElementMinimumHeight"] = ExpressionConverter.ConvertO(__workflow_browserExecuteJavaScriptOnElementsearchElementMinimumHeight);
                        browserExecuteJavaScriptOnElementpropCount++;
                    }

                    browserExecuteJavaScriptOnElementpropCount++;
                }
                else
                {
                    browserExecuteJavaScriptOnElement["SearchElementMinimumHeight"] = 1;
                    browserExecuteJavaScriptOnElementpropCount++;
                }

                if (__workflow_browserExecuteJavaScriptOnElementsearchElementBoundingBoxLeft != null)
                {
                    if (__workflow_browserExecuteJavaScriptOnElementsearchElementBoundingBoxLeft != null)
                    {
                        browserExecuteJavaScriptOnElement["SearchElementBoundingBoxLeft"] = ExpressionConverter.ConvertO(__workflow_browserExecuteJavaScriptOnElementsearchElementBoundingBoxLeft);
                        browserExecuteJavaScriptOnElementpropCount++;
                    }

                    browserExecuteJavaScriptOnElementpropCount++;
                }
                else
                {
                    browserExecuteJavaScriptOnElement["SearchElementBoundingBoxLeft"] = -99999;
                    browserExecuteJavaScriptOnElementpropCount++;
                }

                if (__workflow_browserExecuteJavaScriptOnElementsearchElementBoundingBoxRight != null)
                {
                    if (__workflow_browserExecuteJavaScriptOnElementsearchElementBoundingBoxRight != null)
                    {
                        browserExecuteJavaScriptOnElement["SearchElementBoundingBoxRight"] = ExpressionConverter.ConvertO(__workflow_browserExecuteJavaScriptOnElementsearchElementBoundingBoxRight);
                        browserExecuteJavaScriptOnElementpropCount++;
                    }

                    browserExecuteJavaScriptOnElementpropCount++;
                }
                else
                {
                    browserExecuteJavaScriptOnElement["SearchElementBoundingBoxRight"] = 99999;
                    browserExecuteJavaScriptOnElementpropCount++;
                }

                if (__workflow_browserExecuteJavaScriptOnElementsearchElementBoundingBoxTop != null)
                {
                    if (__workflow_browserExecuteJavaScriptOnElementsearchElementBoundingBoxTop != null)
                    {
                        browserExecuteJavaScriptOnElement["SearchElementBoundingBoxTop"] = ExpressionConverter.ConvertO(__workflow_browserExecuteJavaScriptOnElementsearchElementBoundingBoxTop);
                        browserExecuteJavaScriptOnElementpropCount++;
                    }

                    browserExecuteJavaScriptOnElementpropCount++;
                }
                else
                {
                    browserExecuteJavaScriptOnElement["SearchElementBoundingBoxTop"] = -99999;
                    browserExecuteJavaScriptOnElementpropCount++;
                }

                if (__workflow_browserExecuteJavaScriptOnElementsearchElementBoundingBoxBottom != null)
                {
                    if (__workflow_browserExecuteJavaScriptOnElementsearchElementBoundingBoxBottom != null)
                    {
                        browserExecuteJavaScriptOnElement["SearchElementBoundingBoxBottom"] = ExpressionConverter.ConvertO(__workflow_browserExecuteJavaScriptOnElementsearchElementBoundingBoxBottom);
                        browserExecuteJavaScriptOnElementpropCount++;
                    }

                    browserExecuteJavaScriptOnElementpropCount++;
                }
                else
                {
                    browserExecuteJavaScriptOnElement["SearchElementBoundingBoxBottom"] = 99999;
                    browserExecuteJavaScriptOnElementpropCount++;
                }

                if (__workflow_browserExecuteJavaScriptOnElementonlyElementTopLeftNeedsToBeInBoundingBox != null)
                {
                    if (__workflow_browserExecuteJavaScriptOnElementonlyElementTopLeftNeedsToBeInBoundingBox != null)
                    {
                        browserExecuteJavaScriptOnElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = ExpressionConverter.ConvertO(__workflow_browserExecuteJavaScriptOnElementonlyElementTopLeftNeedsToBeInBoundingBox);
                        browserExecuteJavaScriptOnElementpropCount++;
                    }

                    browserExecuteJavaScriptOnElementpropCount++;
                }
                else
                {
                    browserExecuteJavaScriptOnElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = false;
                    browserExecuteJavaScriptOnElementpropCount++;
                }

                browserExecuteJavaScriptOnElementpropCount++;
                browserExecuteJavaScriptOnElement["JavaScriptToExecute"] = ExpressionConverter.ConvertO(__workflow_browserExecuteJavaScriptOnElementjavaScriptToExecute);
                browserExecuteJavaScriptOnElementpropCount++;
                browserExecuteJavaScriptOnElement["Workflow"] = ExpressionConverter.ConvertO(__workflow_browserExecuteJavaScriptOnElementworkflow);
                if (browserExecuteJavaScriptOnElementpropCount > 0)
                {
                    callPayload.Body = browserExecuteJavaScriptOnElement;
                }

                return new ApiConnectionAction<BrowserExecuteJavaScriptOnElementResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserGlobalMouseLeftClickOnElement(Expression<Func<string>> browserGlobalMouseLeftClickOnElementworkflow, Expression<Func<double>> browserGlobalMouseLeftClickOnElementparentElementHandle = null, Expression<Func<double>> browserGlobalMouseLeftClickOnElementsearchElementHandle = null, Expression<Func<string>> browserGlobalMouseLeftClickOnElementsearchElementName = null, Expression<Func<string>> browserGlobalMouseLeftClickOnElementsearchElementID = null, Expression<Func<string>> browserGlobalMouseLeftClickOnElementsearchElementTagName = null, Expression<Func<string>> browserGlobalMouseLeftClickOnElementsearchElementXPath = null, Expression<Func<string>> browserGlobalMouseLeftClickOnElementsearchElementClassName = null, Expression<Func<string>> browserGlobalMouseLeftClickOnElementsearchElementCSSSelector = null, Expression<Func<double>> browserGlobalMouseLeftClickOnElementsearchElementIndex = null, Expression<Func<string>> browserGlobalMouseLeftClickOnElementsearchElementMatchValue = null, Expression<Func<string>> browserGlobalMouseLeftClickOnElementsearchElementMatchText = null, Expression<Func<string>> browserGlobalMouseLeftClickOnElementsearchElementType = null, Expression<Func<double>> browserGlobalMouseLeftClickOnElementsearchElementMinimumWidth = null, Expression<Func<double>> browserGlobalMouseLeftClickOnElementsearchElementMinimumHeight = null, Expression<Func<double>> browserGlobalMouseLeftClickOnElementsearchElementBoundingBoxLeft = null, Expression<Func<double>> browserGlobalMouseLeftClickOnElementsearchElementBoundingBoxRight = null, Expression<Func<double>> browserGlobalMouseLeftClickOnElementsearchElementBoundingBoxTop = null, Expression<Func<double>> browserGlobalMouseLeftClickOnElementsearchElementBoundingBoxBottom = null, Expression<Func<bool>> browserGlobalMouseLeftClickOnElementonlyElementTopLeftNeedsToBeInBoundingBox = null, Expression<Func<int>> browserGlobalMouseLeftClickOnElementclickOffsetX = null, Expression<Func<int>> browserGlobalMouseLeftClickOnElementclickOffsetY = null, Expression<Func<bool>> browserGlobalMouseLeftClickOnElementfocusFirst = null)
        {
            var __workflow_browserGlobalMouseLeftClickOnElementworkflow = WorkflowExpression.Compile(browserGlobalMouseLeftClickOnElementworkflow, nameof(browserGlobalMouseLeftClickOnElementworkflow), required: true);
            var __workflow_browserGlobalMouseLeftClickOnElementparentElementHandle = WorkflowExpression.Compile(browserGlobalMouseLeftClickOnElementparentElementHandle, nameof(browserGlobalMouseLeftClickOnElementparentElementHandle), required: false);
            var __workflow_browserGlobalMouseLeftClickOnElementsearchElementHandle = WorkflowExpression.Compile(browserGlobalMouseLeftClickOnElementsearchElementHandle, nameof(browserGlobalMouseLeftClickOnElementsearchElementHandle), required: false);
            var __workflow_browserGlobalMouseLeftClickOnElementsearchElementName = WorkflowExpression.Compile(browserGlobalMouseLeftClickOnElementsearchElementName, nameof(browserGlobalMouseLeftClickOnElementsearchElementName), required: false);
            var __workflow_browserGlobalMouseLeftClickOnElementsearchElementID = WorkflowExpression.Compile(browserGlobalMouseLeftClickOnElementsearchElementID, nameof(browserGlobalMouseLeftClickOnElementsearchElementID), required: false);
            var __workflow_browserGlobalMouseLeftClickOnElementsearchElementTagName = WorkflowExpression.Compile(browserGlobalMouseLeftClickOnElementsearchElementTagName, nameof(browserGlobalMouseLeftClickOnElementsearchElementTagName), required: false);
            var __workflow_browserGlobalMouseLeftClickOnElementsearchElementXPath = WorkflowExpression.Compile(browserGlobalMouseLeftClickOnElementsearchElementXPath, nameof(browserGlobalMouseLeftClickOnElementsearchElementXPath), required: false);
            var __workflow_browserGlobalMouseLeftClickOnElementsearchElementClassName = WorkflowExpression.Compile(browserGlobalMouseLeftClickOnElementsearchElementClassName, nameof(browserGlobalMouseLeftClickOnElementsearchElementClassName), required: false);
            var __workflow_browserGlobalMouseLeftClickOnElementsearchElementCSSSelector = WorkflowExpression.Compile(browserGlobalMouseLeftClickOnElementsearchElementCSSSelector, nameof(browserGlobalMouseLeftClickOnElementsearchElementCSSSelector), required: false);
            var __workflow_browserGlobalMouseLeftClickOnElementsearchElementIndex = WorkflowExpression.Compile(browserGlobalMouseLeftClickOnElementsearchElementIndex, nameof(browserGlobalMouseLeftClickOnElementsearchElementIndex), required: false);
            var __workflow_browserGlobalMouseLeftClickOnElementsearchElementMatchValue = WorkflowExpression.Compile(browserGlobalMouseLeftClickOnElementsearchElementMatchValue, nameof(browserGlobalMouseLeftClickOnElementsearchElementMatchValue), required: false);
            var __workflow_browserGlobalMouseLeftClickOnElementsearchElementMatchText = WorkflowExpression.Compile(browserGlobalMouseLeftClickOnElementsearchElementMatchText, nameof(browserGlobalMouseLeftClickOnElementsearchElementMatchText), required: false);
            var __workflow_browserGlobalMouseLeftClickOnElementsearchElementType = WorkflowExpression.Compile(browserGlobalMouseLeftClickOnElementsearchElementType, nameof(browserGlobalMouseLeftClickOnElementsearchElementType), required: false);
            var __workflow_browserGlobalMouseLeftClickOnElementsearchElementMinimumWidth = WorkflowExpression.Compile(browserGlobalMouseLeftClickOnElementsearchElementMinimumWidth, nameof(browserGlobalMouseLeftClickOnElementsearchElementMinimumWidth), required: false);
            var __workflow_browserGlobalMouseLeftClickOnElementsearchElementMinimumHeight = WorkflowExpression.Compile(browserGlobalMouseLeftClickOnElementsearchElementMinimumHeight, nameof(browserGlobalMouseLeftClickOnElementsearchElementMinimumHeight), required: false);
            var __workflow_browserGlobalMouseLeftClickOnElementsearchElementBoundingBoxLeft = WorkflowExpression.Compile(browserGlobalMouseLeftClickOnElementsearchElementBoundingBoxLeft, nameof(browserGlobalMouseLeftClickOnElementsearchElementBoundingBoxLeft), required: false);
            var __workflow_browserGlobalMouseLeftClickOnElementsearchElementBoundingBoxRight = WorkflowExpression.Compile(browserGlobalMouseLeftClickOnElementsearchElementBoundingBoxRight, nameof(browserGlobalMouseLeftClickOnElementsearchElementBoundingBoxRight), required: false);
            var __workflow_browserGlobalMouseLeftClickOnElementsearchElementBoundingBoxTop = WorkflowExpression.Compile(browserGlobalMouseLeftClickOnElementsearchElementBoundingBoxTop, nameof(browserGlobalMouseLeftClickOnElementsearchElementBoundingBoxTop), required: false);
            var __workflow_browserGlobalMouseLeftClickOnElementsearchElementBoundingBoxBottom = WorkflowExpression.Compile(browserGlobalMouseLeftClickOnElementsearchElementBoundingBoxBottom, nameof(browserGlobalMouseLeftClickOnElementsearchElementBoundingBoxBottom), required: false);
            var __workflow_browserGlobalMouseLeftClickOnElementonlyElementTopLeftNeedsToBeInBoundingBox = WorkflowExpression.Compile(browserGlobalMouseLeftClickOnElementonlyElementTopLeftNeedsToBeInBoundingBox, nameof(browserGlobalMouseLeftClickOnElementonlyElementTopLeftNeedsToBeInBoundingBox), required: false);
            var __workflow_browserGlobalMouseLeftClickOnElementclickOffsetX = WorkflowExpression.Compile(browserGlobalMouseLeftClickOnElementclickOffsetX, nameof(browserGlobalMouseLeftClickOnElementclickOffsetX), required: false);
            var __workflow_browserGlobalMouseLeftClickOnElementclickOffsetY = WorkflowExpression.Compile(browserGlobalMouseLeftClickOnElementclickOffsetY, nameof(browserGlobalMouseLeftClickOnElementclickOffsetY), required: false);
            var __workflow_browserGlobalMouseLeftClickOnElementfocusFirst = WorkflowExpression.Compile(browserGlobalMouseLeftClickOnElementfocusFirst, nameof(browserGlobalMouseLeftClickOnElementfocusFirst), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/BrowserControl/GlobalMouseLeftClickOnElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserGlobalMouseLeftClickOnElement = new JObject();
                var browserGlobalMouseLeftClickOnElementpropCount = 0;
                if (__workflow_browserGlobalMouseLeftClickOnElementparentElementHandle != null)
                {
                    browserGlobalMouseLeftClickOnElement["ParentElementHandle"] = ExpressionConverter.ConvertO(__workflow_browserGlobalMouseLeftClickOnElementparentElementHandle);
                    browserGlobalMouseLeftClickOnElementpropCount++;
                }

                if (__workflow_browserGlobalMouseLeftClickOnElementsearchElementHandle != null)
                {
                    browserGlobalMouseLeftClickOnElement["SearchElementHandle"] = ExpressionConverter.ConvertO(__workflow_browserGlobalMouseLeftClickOnElementsearchElementHandle);
                    browserGlobalMouseLeftClickOnElementpropCount++;
                }

                if (__workflow_browserGlobalMouseLeftClickOnElementsearchElementName != null)
                {
                    browserGlobalMouseLeftClickOnElement["SearchElementName"] = ExpressionConverter.ConvertO(__workflow_browserGlobalMouseLeftClickOnElementsearchElementName);
                    browserGlobalMouseLeftClickOnElementpropCount++;
                }

                if (__workflow_browserGlobalMouseLeftClickOnElementsearchElementID != null)
                {
                    browserGlobalMouseLeftClickOnElement["SearchElementID"] = ExpressionConverter.ConvertO(__workflow_browserGlobalMouseLeftClickOnElementsearchElementID);
                    browserGlobalMouseLeftClickOnElementpropCount++;
                }

                if (__workflow_browserGlobalMouseLeftClickOnElementsearchElementTagName != null)
                {
                    browserGlobalMouseLeftClickOnElement["SearchElementTagName"] = ExpressionConverter.ConvertO(__workflow_browserGlobalMouseLeftClickOnElementsearchElementTagName);
                    browserGlobalMouseLeftClickOnElementpropCount++;
                }

                if (__workflow_browserGlobalMouseLeftClickOnElementsearchElementXPath != null)
                {
                    browserGlobalMouseLeftClickOnElement["SearchElementXPath"] = ExpressionConverter.ConvertO(__workflow_browserGlobalMouseLeftClickOnElementsearchElementXPath);
                    browserGlobalMouseLeftClickOnElementpropCount++;
                }

                if (__workflow_browserGlobalMouseLeftClickOnElementsearchElementClassName != null)
                {
                    browserGlobalMouseLeftClickOnElement["SearchElementClassName"] = ExpressionConverter.ConvertO(__workflow_browserGlobalMouseLeftClickOnElementsearchElementClassName);
                    browserGlobalMouseLeftClickOnElementpropCount++;
                }

                if (__workflow_browserGlobalMouseLeftClickOnElementsearchElementCSSSelector != null)
                {
                    browserGlobalMouseLeftClickOnElement["SearchElementCSSSelector"] = ExpressionConverter.ConvertO(__workflow_browserGlobalMouseLeftClickOnElementsearchElementCSSSelector);
                    browserGlobalMouseLeftClickOnElementpropCount++;
                }

                if (__workflow_browserGlobalMouseLeftClickOnElementsearchElementIndex != null)
                {
                    if (__workflow_browserGlobalMouseLeftClickOnElementsearchElementIndex != null)
                    {
                        browserGlobalMouseLeftClickOnElement["SearchElementIndex"] = ExpressionConverter.ConvertO(__workflow_browserGlobalMouseLeftClickOnElementsearchElementIndex);
                        browserGlobalMouseLeftClickOnElementpropCount++;
                    }

                    browserGlobalMouseLeftClickOnElementpropCount++;
                }
                else
                {
                    browserGlobalMouseLeftClickOnElement["SearchElementIndex"] = 1;
                    browserGlobalMouseLeftClickOnElementpropCount++;
                }

                if (__workflow_browserGlobalMouseLeftClickOnElementsearchElementMatchValue != null)
                {
                    browserGlobalMouseLeftClickOnElement["SearchElementMatchValue"] = ExpressionConverter.ConvertO(__workflow_browserGlobalMouseLeftClickOnElementsearchElementMatchValue);
                    browserGlobalMouseLeftClickOnElementpropCount++;
                }

                if (__workflow_browserGlobalMouseLeftClickOnElementsearchElementMatchText != null)
                {
                    browserGlobalMouseLeftClickOnElement["SearchElementMatchText"] = ExpressionConverter.ConvertO(__workflow_browserGlobalMouseLeftClickOnElementsearchElementMatchText);
                    browserGlobalMouseLeftClickOnElementpropCount++;
                }

                if (__workflow_browserGlobalMouseLeftClickOnElementsearchElementType != null)
                {
                    browserGlobalMouseLeftClickOnElement["SearchElementType"] = ExpressionConverter.ConvertO(__workflow_browserGlobalMouseLeftClickOnElementsearchElementType);
                    browserGlobalMouseLeftClickOnElementpropCount++;
                }

                if (__workflow_browserGlobalMouseLeftClickOnElementsearchElementMinimumWidth != null)
                {
                    if (__workflow_browserGlobalMouseLeftClickOnElementsearchElementMinimumWidth != null)
                    {
                        browserGlobalMouseLeftClickOnElement["SearchElementMinimumWidth"] = ExpressionConverter.ConvertO(__workflow_browserGlobalMouseLeftClickOnElementsearchElementMinimumWidth);
                        browserGlobalMouseLeftClickOnElementpropCount++;
                    }

                    browserGlobalMouseLeftClickOnElementpropCount++;
                }
                else
                {
                    browserGlobalMouseLeftClickOnElement["SearchElementMinimumWidth"] = 1;
                    browserGlobalMouseLeftClickOnElementpropCount++;
                }

                if (__workflow_browserGlobalMouseLeftClickOnElementsearchElementMinimumHeight != null)
                {
                    if (__workflow_browserGlobalMouseLeftClickOnElementsearchElementMinimumHeight != null)
                    {
                        browserGlobalMouseLeftClickOnElement["SearchElementMinimumHeight"] = ExpressionConverter.ConvertO(__workflow_browserGlobalMouseLeftClickOnElementsearchElementMinimumHeight);
                        browserGlobalMouseLeftClickOnElementpropCount++;
                    }

                    browserGlobalMouseLeftClickOnElementpropCount++;
                }
                else
                {
                    browserGlobalMouseLeftClickOnElement["SearchElementMinimumHeight"] = 1;
                    browserGlobalMouseLeftClickOnElementpropCount++;
                }

                if (__workflow_browserGlobalMouseLeftClickOnElementsearchElementBoundingBoxLeft != null)
                {
                    if (__workflow_browserGlobalMouseLeftClickOnElementsearchElementBoundingBoxLeft != null)
                    {
                        browserGlobalMouseLeftClickOnElement["SearchElementBoundingBoxLeft"] = ExpressionConverter.ConvertO(__workflow_browserGlobalMouseLeftClickOnElementsearchElementBoundingBoxLeft);
                        browserGlobalMouseLeftClickOnElementpropCount++;
                    }

                    browserGlobalMouseLeftClickOnElementpropCount++;
                }
                else
                {
                    browserGlobalMouseLeftClickOnElement["SearchElementBoundingBoxLeft"] = -99999;
                    browserGlobalMouseLeftClickOnElementpropCount++;
                }

                if (__workflow_browserGlobalMouseLeftClickOnElementsearchElementBoundingBoxRight != null)
                {
                    if (__workflow_browserGlobalMouseLeftClickOnElementsearchElementBoundingBoxRight != null)
                    {
                        browserGlobalMouseLeftClickOnElement["SearchElementBoundingBoxRight"] = ExpressionConverter.ConvertO(__workflow_browserGlobalMouseLeftClickOnElementsearchElementBoundingBoxRight);
                        browserGlobalMouseLeftClickOnElementpropCount++;
                    }

                    browserGlobalMouseLeftClickOnElementpropCount++;
                }
                else
                {
                    browserGlobalMouseLeftClickOnElement["SearchElementBoundingBoxRight"] = 99999;
                    browserGlobalMouseLeftClickOnElementpropCount++;
                }

                if (__workflow_browserGlobalMouseLeftClickOnElementsearchElementBoundingBoxTop != null)
                {
                    if (__workflow_browserGlobalMouseLeftClickOnElementsearchElementBoundingBoxTop != null)
                    {
                        browserGlobalMouseLeftClickOnElement["SearchElementBoundingBoxTop"] = ExpressionConverter.ConvertO(__workflow_browserGlobalMouseLeftClickOnElementsearchElementBoundingBoxTop);
                        browserGlobalMouseLeftClickOnElementpropCount++;
                    }

                    browserGlobalMouseLeftClickOnElementpropCount++;
                }
                else
                {
                    browserGlobalMouseLeftClickOnElement["SearchElementBoundingBoxTop"] = -99999;
                    browserGlobalMouseLeftClickOnElementpropCount++;
                }

                if (__workflow_browserGlobalMouseLeftClickOnElementsearchElementBoundingBoxBottom != null)
                {
                    if (__workflow_browserGlobalMouseLeftClickOnElementsearchElementBoundingBoxBottom != null)
                    {
                        browserGlobalMouseLeftClickOnElement["SearchElementBoundingBoxBottom"] = ExpressionConverter.ConvertO(__workflow_browserGlobalMouseLeftClickOnElementsearchElementBoundingBoxBottom);
                        browserGlobalMouseLeftClickOnElementpropCount++;
                    }

                    browserGlobalMouseLeftClickOnElementpropCount++;
                }
                else
                {
                    browserGlobalMouseLeftClickOnElement["SearchElementBoundingBoxBottom"] = 99999;
                    browserGlobalMouseLeftClickOnElementpropCount++;
                }

                if (__workflow_browserGlobalMouseLeftClickOnElementonlyElementTopLeftNeedsToBeInBoundingBox != null)
                {
                    if (__workflow_browserGlobalMouseLeftClickOnElementonlyElementTopLeftNeedsToBeInBoundingBox != null)
                    {
                        browserGlobalMouseLeftClickOnElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = ExpressionConverter.ConvertO(__workflow_browserGlobalMouseLeftClickOnElementonlyElementTopLeftNeedsToBeInBoundingBox);
                        browserGlobalMouseLeftClickOnElementpropCount++;
                    }

                    browserGlobalMouseLeftClickOnElementpropCount++;
                }
                else
                {
                    browserGlobalMouseLeftClickOnElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = false;
                    browserGlobalMouseLeftClickOnElementpropCount++;
                }

                if (__workflow_browserGlobalMouseLeftClickOnElementclickOffsetX != null)
                {
                    browserGlobalMouseLeftClickOnElement["ClickOffsetX"] = ExpressionConverter.ConvertO(__workflow_browserGlobalMouseLeftClickOnElementclickOffsetX);
                    browserGlobalMouseLeftClickOnElementpropCount++;
                }

                if (__workflow_browserGlobalMouseLeftClickOnElementclickOffsetY != null)
                {
                    browserGlobalMouseLeftClickOnElement["ClickOffsetY"] = ExpressionConverter.ConvertO(__workflow_browserGlobalMouseLeftClickOnElementclickOffsetY);
                    browserGlobalMouseLeftClickOnElementpropCount++;
                }

                if (__workflow_browserGlobalMouseLeftClickOnElementfocusFirst != null)
                {
                    if (__workflow_browserGlobalMouseLeftClickOnElementfocusFirst != null)
                    {
                        browserGlobalMouseLeftClickOnElement["FocusFirst"] = ExpressionConverter.ConvertO(__workflow_browserGlobalMouseLeftClickOnElementfocusFirst);
                        browserGlobalMouseLeftClickOnElementpropCount++;
                    }

                    browserGlobalMouseLeftClickOnElementpropCount++;
                }
                else
                {
                    browserGlobalMouseLeftClickOnElement["FocusFirst"] = false;
                    browserGlobalMouseLeftClickOnElementpropCount++;
                }

                browserGlobalMouseLeftClickOnElementpropCount++;
                browserGlobalMouseLeftClickOnElement["Workflow"] = ExpressionConverter.ConvertO(__workflow_browserGlobalMouseLeftClickOnElementworkflow);
                if (browserGlobalMouseLeftClickOnElementpropCount > 0)
                {
                    callPayload.Body = browserGlobalMouseLeftClickOnElement;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserGlobalMouseRightClickOnElement(Expression<Func<string>> browserGlobalMouseRightClickOnElementworkflow, Expression<Func<double>> browserGlobalMouseRightClickOnElementparentElementHandle = null, Expression<Func<double>> browserGlobalMouseRightClickOnElementsearchElementHandle = null, Expression<Func<string>> browserGlobalMouseRightClickOnElementsearchElementName = null, Expression<Func<string>> browserGlobalMouseRightClickOnElementsearchElementID = null, Expression<Func<string>> browserGlobalMouseRightClickOnElementsearchElementTagName = null, Expression<Func<string>> browserGlobalMouseRightClickOnElementsearchElementXPath = null, Expression<Func<string>> browserGlobalMouseRightClickOnElementsearchElementClassName = null, Expression<Func<string>> browserGlobalMouseRightClickOnElementsearchElementCSSSelector = null, Expression<Func<double>> browserGlobalMouseRightClickOnElementsearchElementIndex = null, Expression<Func<string>> browserGlobalMouseRightClickOnElementsearchElementMatchValue = null, Expression<Func<string>> browserGlobalMouseRightClickOnElementsearchElementMatchText = null, Expression<Func<string>> browserGlobalMouseRightClickOnElementsearchElementType = null, Expression<Func<double>> browserGlobalMouseRightClickOnElementsearchElementMinimumWidth = null, Expression<Func<double>> browserGlobalMouseRightClickOnElementsearchElementMinimumHeight = null, Expression<Func<double>> browserGlobalMouseRightClickOnElementsearchElementBoundingBoxLeft = null, Expression<Func<double>> browserGlobalMouseRightClickOnElementsearchElementBoundingBoxRight = null, Expression<Func<double>> browserGlobalMouseRightClickOnElementsearchElementBoundingBoxTop = null, Expression<Func<double>> browserGlobalMouseRightClickOnElementsearchElementBoundingBoxBottom = null, Expression<Func<bool>> browserGlobalMouseRightClickOnElementonlyElementTopLeftNeedsToBeInBoundingBox = null, Expression<Func<int>> browserGlobalMouseRightClickOnElementclickOffsetX = null, Expression<Func<int>> browserGlobalMouseRightClickOnElementclickOffsetY = null, Expression<Func<bool>> browserGlobalMouseRightClickOnElementfocusFirst = null)
        {
            var __workflow_browserGlobalMouseRightClickOnElementworkflow = WorkflowExpression.Compile(browserGlobalMouseRightClickOnElementworkflow, nameof(browserGlobalMouseRightClickOnElementworkflow), required: true);
            var __workflow_browserGlobalMouseRightClickOnElementparentElementHandle = WorkflowExpression.Compile(browserGlobalMouseRightClickOnElementparentElementHandle, nameof(browserGlobalMouseRightClickOnElementparentElementHandle), required: false);
            var __workflow_browserGlobalMouseRightClickOnElementsearchElementHandle = WorkflowExpression.Compile(browserGlobalMouseRightClickOnElementsearchElementHandle, nameof(browserGlobalMouseRightClickOnElementsearchElementHandle), required: false);
            var __workflow_browserGlobalMouseRightClickOnElementsearchElementName = WorkflowExpression.Compile(browserGlobalMouseRightClickOnElementsearchElementName, nameof(browserGlobalMouseRightClickOnElementsearchElementName), required: false);
            var __workflow_browserGlobalMouseRightClickOnElementsearchElementID = WorkflowExpression.Compile(browserGlobalMouseRightClickOnElementsearchElementID, nameof(browserGlobalMouseRightClickOnElementsearchElementID), required: false);
            var __workflow_browserGlobalMouseRightClickOnElementsearchElementTagName = WorkflowExpression.Compile(browserGlobalMouseRightClickOnElementsearchElementTagName, nameof(browserGlobalMouseRightClickOnElementsearchElementTagName), required: false);
            var __workflow_browserGlobalMouseRightClickOnElementsearchElementXPath = WorkflowExpression.Compile(browserGlobalMouseRightClickOnElementsearchElementXPath, nameof(browserGlobalMouseRightClickOnElementsearchElementXPath), required: false);
            var __workflow_browserGlobalMouseRightClickOnElementsearchElementClassName = WorkflowExpression.Compile(browserGlobalMouseRightClickOnElementsearchElementClassName, nameof(browserGlobalMouseRightClickOnElementsearchElementClassName), required: false);
            var __workflow_browserGlobalMouseRightClickOnElementsearchElementCSSSelector = WorkflowExpression.Compile(browserGlobalMouseRightClickOnElementsearchElementCSSSelector, nameof(browserGlobalMouseRightClickOnElementsearchElementCSSSelector), required: false);
            var __workflow_browserGlobalMouseRightClickOnElementsearchElementIndex = WorkflowExpression.Compile(browserGlobalMouseRightClickOnElementsearchElementIndex, nameof(browserGlobalMouseRightClickOnElementsearchElementIndex), required: false);
            var __workflow_browserGlobalMouseRightClickOnElementsearchElementMatchValue = WorkflowExpression.Compile(browserGlobalMouseRightClickOnElementsearchElementMatchValue, nameof(browserGlobalMouseRightClickOnElementsearchElementMatchValue), required: false);
            var __workflow_browserGlobalMouseRightClickOnElementsearchElementMatchText = WorkflowExpression.Compile(browserGlobalMouseRightClickOnElementsearchElementMatchText, nameof(browserGlobalMouseRightClickOnElementsearchElementMatchText), required: false);
            var __workflow_browserGlobalMouseRightClickOnElementsearchElementType = WorkflowExpression.Compile(browserGlobalMouseRightClickOnElementsearchElementType, nameof(browserGlobalMouseRightClickOnElementsearchElementType), required: false);
            var __workflow_browserGlobalMouseRightClickOnElementsearchElementMinimumWidth = WorkflowExpression.Compile(browserGlobalMouseRightClickOnElementsearchElementMinimumWidth, nameof(browserGlobalMouseRightClickOnElementsearchElementMinimumWidth), required: false);
            var __workflow_browserGlobalMouseRightClickOnElementsearchElementMinimumHeight = WorkflowExpression.Compile(browserGlobalMouseRightClickOnElementsearchElementMinimumHeight, nameof(browserGlobalMouseRightClickOnElementsearchElementMinimumHeight), required: false);
            var __workflow_browserGlobalMouseRightClickOnElementsearchElementBoundingBoxLeft = WorkflowExpression.Compile(browserGlobalMouseRightClickOnElementsearchElementBoundingBoxLeft, nameof(browserGlobalMouseRightClickOnElementsearchElementBoundingBoxLeft), required: false);
            var __workflow_browserGlobalMouseRightClickOnElementsearchElementBoundingBoxRight = WorkflowExpression.Compile(browserGlobalMouseRightClickOnElementsearchElementBoundingBoxRight, nameof(browserGlobalMouseRightClickOnElementsearchElementBoundingBoxRight), required: false);
            var __workflow_browserGlobalMouseRightClickOnElementsearchElementBoundingBoxTop = WorkflowExpression.Compile(browserGlobalMouseRightClickOnElementsearchElementBoundingBoxTop, nameof(browserGlobalMouseRightClickOnElementsearchElementBoundingBoxTop), required: false);
            var __workflow_browserGlobalMouseRightClickOnElementsearchElementBoundingBoxBottom = WorkflowExpression.Compile(browserGlobalMouseRightClickOnElementsearchElementBoundingBoxBottom, nameof(browserGlobalMouseRightClickOnElementsearchElementBoundingBoxBottom), required: false);
            var __workflow_browserGlobalMouseRightClickOnElementonlyElementTopLeftNeedsToBeInBoundingBox = WorkflowExpression.Compile(browserGlobalMouseRightClickOnElementonlyElementTopLeftNeedsToBeInBoundingBox, nameof(browserGlobalMouseRightClickOnElementonlyElementTopLeftNeedsToBeInBoundingBox), required: false);
            var __workflow_browserGlobalMouseRightClickOnElementclickOffsetX = WorkflowExpression.Compile(browserGlobalMouseRightClickOnElementclickOffsetX, nameof(browserGlobalMouseRightClickOnElementclickOffsetX), required: false);
            var __workflow_browserGlobalMouseRightClickOnElementclickOffsetY = WorkflowExpression.Compile(browserGlobalMouseRightClickOnElementclickOffsetY, nameof(browserGlobalMouseRightClickOnElementclickOffsetY), required: false);
            var __workflow_browserGlobalMouseRightClickOnElementfocusFirst = WorkflowExpression.Compile(browserGlobalMouseRightClickOnElementfocusFirst, nameof(browserGlobalMouseRightClickOnElementfocusFirst), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/BrowserControl/GlobalMouseRightClickOnElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserGlobalMouseRightClickOnElement = new JObject();
                var browserGlobalMouseRightClickOnElementpropCount = 0;
                if (__workflow_browserGlobalMouseRightClickOnElementparentElementHandle != null)
                {
                    browserGlobalMouseRightClickOnElement["ParentElementHandle"] = ExpressionConverter.ConvertO(__workflow_browserGlobalMouseRightClickOnElementparentElementHandle);
                    browserGlobalMouseRightClickOnElementpropCount++;
                }

                if (__workflow_browserGlobalMouseRightClickOnElementsearchElementHandle != null)
                {
                    browserGlobalMouseRightClickOnElement["SearchElementHandle"] = ExpressionConverter.ConvertO(__workflow_browserGlobalMouseRightClickOnElementsearchElementHandle);
                    browserGlobalMouseRightClickOnElementpropCount++;
                }

                if (__workflow_browserGlobalMouseRightClickOnElementsearchElementName != null)
                {
                    browserGlobalMouseRightClickOnElement["SearchElementName"] = ExpressionConverter.ConvertO(__workflow_browserGlobalMouseRightClickOnElementsearchElementName);
                    browserGlobalMouseRightClickOnElementpropCount++;
                }

                if (__workflow_browserGlobalMouseRightClickOnElementsearchElementID != null)
                {
                    browserGlobalMouseRightClickOnElement["SearchElementID"] = ExpressionConverter.ConvertO(__workflow_browserGlobalMouseRightClickOnElementsearchElementID);
                    browserGlobalMouseRightClickOnElementpropCount++;
                }

                if (__workflow_browserGlobalMouseRightClickOnElementsearchElementTagName != null)
                {
                    browserGlobalMouseRightClickOnElement["SearchElementTagName"] = ExpressionConverter.ConvertO(__workflow_browserGlobalMouseRightClickOnElementsearchElementTagName);
                    browserGlobalMouseRightClickOnElementpropCount++;
                }

                if (__workflow_browserGlobalMouseRightClickOnElementsearchElementXPath != null)
                {
                    browserGlobalMouseRightClickOnElement["SearchElementXPath"] = ExpressionConverter.ConvertO(__workflow_browserGlobalMouseRightClickOnElementsearchElementXPath);
                    browserGlobalMouseRightClickOnElementpropCount++;
                }

                if (__workflow_browserGlobalMouseRightClickOnElementsearchElementClassName != null)
                {
                    browserGlobalMouseRightClickOnElement["SearchElementClassName"] = ExpressionConverter.ConvertO(__workflow_browserGlobalMouseRightClickOnElementsearchElementClassName);
                    browserGlobalMouseRightClickOnElementpropCount++;
                }

                if (__workflow_browserGlobalMouseRightClickOnElementsearchElementCSSSelector != null)
                {
                    browserGlobalMouseRightClickOnElement["SearchElementCSSSelector"] = ExpressionConverter.ConvertO(__workflow_browserGlobalMouseRightClickOnElementsearchElementCSSSelector);
                    browserGlobalMouseRightClickOnElementpropCount++;
                }

                if (__workflow_browserGlobalMouseRightClickOnElementsearchElementIndex != null)
                {
                    if (__workflow_browserGlobalMouseRightClickOnElementsearchElementIndex != null)
                    {
                        browserGlobalMouseRightClickOnElement["SearchElementIndex"] = ExpressionConverter.ConvertO(__workflow_browserGlobalMouseRightClickOnElementsearchElementIndex);
                        browserGlobalMouseRightClickOnElementpropCount++;
                    }

                    browserGlobalMouseRightClickOnElementpropCount++;
                }
                else
                {
                    browserGlobalMouseRightClickOnElement["SearchElementIndex"] = 1;
                    browserGlobalMouseRightClickOnElementpropCount++;
                }

                if (__workflow_browserGlobalMouseRightClickOnElementsearchElementMatchValue != null)
                {
                    browserGlobalMouseRightClickOnElement["SearchElementMatchValue"] = ExpressionConverter.ConvertO(__workflow_browserGlobalMouseRightClickOnElementsearchElementMatchValue);
                    browserGlobalMouseRightClickOnElementpropCount++;
                }

                if (__workflow_browserGlobalMouseRightClickOnElementsearchElementMatchText != null)
                {
                    browserGlobalMouseRightClickOnElement["SearchElementMatchText"] = ExpressionConverter.ConvertO(__workflow_browserGlobalMouseRightClickOnElementsearchElementMatchText);
                    browserGlobalMouseRightClickOnElementpropCount++;
                }

                if (__workflow_browserGlobalMouseRightClickOnElementsearchElementType != null)
                {
                    browserGlobalMouseRightClickOnElement["SearchElementType"] = ExpressionConverter.ConvertO(__workflow_browserGlobalMouseRightClickOnElementsearchElementType);
                    browserGlobalMouseRightClickOnElementpropCount++;
                }

                if (__workflow_browserGlobalMouseRightClickOnElementsearchElementMinimumWidth != null)
                {
                    if (__workflow_browserGlobalMouseRightClickOnElementsearchElementMinimumWidth != null)
                    {
                        browserGlobalMouseRightClickOnElement["SearchElementMinimumWidth"] = ExpressionConverter.ConvertO(__workflow_browserGlobalMouseRightClickOnElementsearchElementMinimumWidth);
                        browserGlobalMouseRightClickOnElementpropCount++;
                    }

                    browserGlobalMouseRightClickOnElementpropCount++;
                }
                else
                {
                    browserGlobalMouseRightClickOnElement["SearchElementMinimumWidth"] = 1;
                    browserGlobalMouseRightClickOnElementpropCount++;
                }

                if (__workflow_browserGlobalMouseRightClickOnElementsearchElementMinimumHeight != null)
                {
                    if (__workflow_browserGlobalMouseRightClickOnElementsearchElementMinimumHeight != null)
                    {
                        browserGlobalMouseRightClickOnElement["SearchElementMinimumHeight"] = ExpressionConverter.ConvertO(__workflow_browserGlobalMouseRightClickOnElementsearchElementMinimumHeight);
                        browserGlobalMouseRightClickOnElementpropCount++;
                    }

                    browserGlobalMouseRightClickOnElementpropCount++;
                }
                else
                {
                    browserGlobalMouseRightClickOnElement["SearchElementMinimumHeight"] = 1;
                    browserGlobalMouseRightClickOnElementpropCount++;
                }

                if (__workflow_browserGlobalMouseRightClickOnElementsearchElementBoundingBoxLeft != null)
                {
                    if (__workflow_browserGlobalMouseRightClickOnElementsearchElementBoundingBoxLeft != null)
                    {
                        browserGlobalMouseRightClickOnElement["SearchElementBoundingBoxLeft"] = ExpressionConverter.ConvertO(__workflow_browserGlobalMouseRightClickOnElementsearchElementBoundingBoxLeft);
                        browserGlobalMouseRightClickOnElementpropCount++;
                    }

                    browserGlobalMouseRightClickOnElementpropCount++;
                }
                else
                {
                    browserGlobalMouseRightClickOnElement["SearchElementBoundingBoxLeft"] = -99999;
                    browserGlobalMouseRightClickOnElementpropCount++;
                }

                if (__workflow_browserGlobalMouseRightClickOnElementsearchElementBoundingBoxRight != null)
                {
                    if (__workflow_browserGlobalMouseRightClickOnElementsearchElementBoundingBoxRight != null)
                    {
                        browserGlobalMouseRightClickOnElement["SearchElementBoundingBoxRight"] = ExpressionConverter.ConvertO(__workflow_browserGlobalMouseRightClickOnElementsearchElementBoundingBoxRight);
                        browserGlobalMouseRightClickOnElementpropCount++;
                    }

                    browserGlobalMouseRightClickOnElementpropCount++;
                }
                else
                {
                    browserGlobalMouseRightClickOnElement["SearchElementBoundingBoxRight"] = 99999;
                    browserGlobalMouseRightClickOnElementpropCount++;
                }

                if (__workflow_browserGlobalMouseRightClickOnElementsearchElementBoundingBoxTop != null)
                {
                    if (__workflow_browserGlobalMouseRightClickOnElementsearchElementBoundingBoxTop != null)
                    {
                        browserGlobalMouseRightClickOnElement["SearchElementBoundingBoxTop"] = ExpressionConverter.ConvertO(__workflow_browserGlobalMouseRightClickOnElementsearchElementBoundingBoxTop);
                        browserGlobalMouseRightClickOnElementpropCount++;
                    }

                    browserGlobalMouseRightClickOnElementpropCount++;
                }
                else
                {
                    browserGlobalMouseRightClickOnElement["SearchElementBoundingBoxTop"] = -99999;
                    browserGlobalMouseRightClickOnElementpropCount++;
                }

                if (__workflow_browserGlobalMouseRightClickOnElementsearchElementBoundingBoxBottom != null)
                {
                    if (__workflow_browserGlobalMouseRightClickOnElementsearchElementBoundingBoxBottom != null)
                    {
                        browserGlobalMouseRightClickOnElement["SearchElementBoundingBoxBottom"] = ExpressionConverter.ConvertO(__workflow_browserGlobalMouseRightClickOnElementsearchElementBoundingBoxBottom);
                        browserGlobalMouseRightClickOnElementpropCount++;
                    }

                    browserGlobalMouseRightClickOnElementpropCount++;
                }
                else
                {
                    browserGlobalMouseRightClickOnElement["SearchElementBoundingBoxBottom"] = 99999;
                    browserGlobalMouseRightClickOnElementpropCount++;
                }

                if (__workflow_browserGlobalMouseRightClickOnElementonlyElementTopLeftNeedsToBeInBoundingBox != null)
                {
                    if (__workflow_browserGlobalMouseRightClickOnElementonlyElementTopLeftNeedsToBeInBoundingBox != null)
                    {
                        browserGlobalMouseRightClickOnElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = ExpressionConverter.ConvertO(__workflow_browserGlobalMouseRightClickOnElementonlyElementTopLeftNeedsToBeInBoundingBox);
                        browserGlobalMouseRightClickOnElementpropCount++;
                    }

                    browserGlobalMouseRightClickOnElementpropCount++;
                }
                else
                {
                    browserGlobalMouseRightClickOnElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = false;
                    browserGlobalMouseRightClickOnElementpropCount++;
                }

                if (__workflow_browserGlobalMouseRightClickOnElementclickOffsetX != null)
                {
                    browserGlobalMouseRightClickOnElement["ClickOffsetX"] = ExpressionConverter.ConvertO(__workflow_browserGlobalMouseRightClickOnElementclickOffsetX);
                    browserGlobalMouseRightClickOnElementpropCount++;
                }

                if (__workflow_browserGlobalMouseRightClickOnElementclickOffsetY != null)
                {
                    browserGlobalMouseRightClickOnElement["ClickOffsetY"] = ExpressionConverter.ConvertO(__workflow_browserGlobalMouseRightClickOnElementclickOffsetY);
                    browserGlobalMouseRightClickOnElementpropCount++;
                }

                if (__workflow_browserGlobalMouseRightClickOnElementfocusFirst != null)
                {
                    if (__workflow_browserGlobalMouseRightClickOnElementfocusFirst != null)
                    {
                        browserGlobalMouseRightClickOnElement["FocusFirst"] = ExpressionConverter.ConvertO(__workflow_browserGlobalMouseRightClickOnElementfocusFirst);
                        browserGlobalMouseRightClickOnElementpropCount++;
                    }

                    browserGlobalMouseRightClickOnElementpropCount++;
                }
                else
                {
                    browserGlobalMouseRightClickOnElement["FocusFirst"] = false;
                    browserGlobalMouseRightClickOnElementpropCount++;
                }

                browserGlobalMouseRightClickOnElementpropCount++;
                browserGlobalMouseRightClickOnElement["Workflow"] = ExpressionConverter.ConvertO(__workflow_browserGlobalMouseRightClickOnElementworkflow);
                if (browserGlobalMouseRightClickOnElementpropCount > 0)
                {
                    callPayload.Body = browserGlobalMouseRightClickOnElement;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserOpenNewTabResponse> BrowserOpenNewTab(Expression<Func<string>> browserOpenNewTabworkflow, Expression<Func<string>> browserOpenNewTabuRL = null, Expression<Func<bool>> browserOpenNewTabswitchControlToNewTab = null)
        {
            var __workflow_browserOpenNewTabworkflow = WorkflowExpression.Compile(browserOpenNewTabworkflow, nameof(browserOpenNewTabworkflow), required: true);
            var __workflow_browserOpenNewTabuRL = WorkflowExpression.Compile(browserOpenNewTabuRL, nameof(browserOpenNewTabuRL), required: false);
            var __workflow_browserOpenNewTabswitchControlToNewTab = WorkflowExpression.Compile(browserOpenNewTabswitchControlToNewTab, nameof(browserOpenNewTabswitchControlToNewTab), required: false);
            return new DeferredBodyAction<BrowserOpenNewTabResponse>(() =>
            {
                var apiCallPath = "/BrowserControl/OpenNewTab";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserOpenNewTab = new JObject();
                var browserOpenNewTabpropCount = 0;
                if (__workflow_browserOpenNewTabuRL != null)
                {
                    browserOpenNewTab["URL"] = ExpressionConverter.ConvertO(__workflow_browserOpenNewTabuRL);
                    browserOpenNewTabpropCount++;
                }

                if (__workflow_browserOpenNewTabswitchControlToNewTab != null)
                {
                    if (__workflow_browserOpenNewTabswitchControlToNewTab != null)
                    {
                        browserOpenNewTab["SwitchControlToNewTab"] = ExpressionConverter.ConvertO(__workflow_browserOpenNewTabswitchControlToNewTab);
                        browserOpenNewTabpropCount++;
                    }

                    browserOpenNewTabpropCount++;
                }
                else
                {
                    browserOpenNewTab["SwitchControlToNewTab"] = true;
                    browserOpenNewTabpropCount++;
                }

                browserOpenNewTabpropCount++;
                browserOpenNewTab["Workflow"] = ExpressionConverter.ConvertO(__workflow_browserOpenNewTabworkflow);
                if (browserOpenNewTabpropCount > 0)
                {
                    callPayload.Body = browserOpenNewTab;
                }

                return new ApiConnectionAction<BrowserOpenNewTabResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserGetTabsResponse> BrowserGetTabs(Expression<Func<string>> browserGetTabsworkflow)
        {
            var __workflow_browserGetTabsworkflow = WorkflowExpression.Compile(browserGetTabsworkflow, nameof(browserGetTabsworkflow), required: true);
            return new DeferredBodyAction<BrowserGetTabsResponse>(() =>
            {
                var apiCallPath = "/BrowserControl/GetTabs";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserGetTabs = new JObject();
                var browserGetTabspropCount = 0;
                browserGetTabspropCount++;
                browserGetTabs["Workflow"] = ExpressionConverter.ConvertO(__workflow_browserGetTabsworkflow);
                if (browserGetTabspropCount > 0)
                {
                    callPayload.Body = browserGetTabs;
                }

                return new ApiConnectionAction<BrowserGetTabsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserSetTab(Expression<Func<string>> browserSetTabworkflow, Expression<Func<string>> browserSetTabtabName = null, Expression<Func<int>> browserSetTabtabIndex = null)
        {
            var __workflow_browserSetTabworkflow = WorkflowExpression.Compile(browserSetTabworkflow, nameof(browserSetTabworkflow), required: true);
            var __workflow_browserSetTabtabName = WorkflowExpression.Compile(browserSetTabtabName, nameof(browserSetTabtabName), required: false);
            var __workflow_browserSetTabtabIndex = WorkflowExpression.Compile(browserSetTabtabIndex, nameof(browserSetTabtabIndex), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/BrowserControl/SetTab";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserSetTab = new JObject();
                var browserSetTabpropCount = 0;
                if (__workflow_browserSetTabtabName != null)
                {
                    browserSetTab["TabName"] = ExpressionConverter.ConvertO(__workflow_browserSetTabtabName);
                    browserSetTabpropCount++;
                }

                if (__workflow_browserSetTabtabIndex != null)
                {
                    browserSetTab["TabIndex"] = ExpressionConverter.ConvertO(__workflow_browserSetTabtabIndex);
                    browserSetTabpropCount++;
                }

                browserSetTabpropCount++;
                browserSetTab["Workflow"] = ExpressionConverter.ConvertO(__workflow_browserSetTabworkflow);
                if (browserSetTabpropCount > 0)
                {
                    callPayload.Body = browserSetTab;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserCloseActiveTab(Expression<Func<string>> browserCloseActiveTabworkflow)
        {
            var __workflow_browserCloseActiveTabworkflow = WorkflowExpression.Compile(browserCloseActiveTabworkflow, nameof(browserCloseActiveTabworkflow), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/BrowserControl/CloseActiveTab";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserCloseActiveTab = new JObject();
                var browserCloseActiveTabpropCount = 0;
                browserCloseActiveTabpropCount++;
                browserCloseActiveTab["Workflow"] = ExpressionConverter.ConvertO(__workflow_browserCloseActiveTabworkflow);
                if (browserCloseActiveTabpropCount > 0)
                {
                    callPayload.Body = browserCloseActiveTab;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserSavePageToFile(Expression<Func<string>> browserSavePageToFilesaveFilename, Expression<Func<string>> browserSavePageToFileworkflow)
        {
            var __workflow_browserSavePageToFilesaveFilename = WorkflowExpression.Compile(browserSavePageToFilesaveFilename, nameof(browserSavePageToFilesaveFilename), required: true);
            var __workflow_browserSavePageToFileworkflow = WorkflowExpression.Compile(browserSavePageToFileworkflow, nameof(browserSavePageToFileworkflow), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/BrowserControl/SavePageToFile";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserSavePageToFile = new JObject();
                var browserSavePageToFilepropCount = 0;
                browserSavePageToFilepropCount++;
                browserSavePageToFile["SaveFilename"] = ExpressionConverter.ConvertO(__workflow_browserSavePageToFilesaveFilename);
                browserSavePageToFilepropCount++;
                browserSavePageToFile["Workflow"] = ExpressionConverter.ConvertO(__workflow_browserSavePageToFileworkflow);
                if (browserSavePageToFilepropCount > 0)
                {
                    callPayload.Body = browserSavePageToFile;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserGetPageTextResponse> BrowserGetPageText(Expression<Func<string>> browserGetPageTextworkflow)
        {
            var __workflow_browserGetPageTextworkflow = WorkflowExpression.Compile(browserGetPageTextworkflow, nameof(browserGetPageTextworkflow), required: true);
            return new DeferredBodyAction<BrowserGetPageTextResponse>(() =>
            {
                var apiCallPath = "/BrowserControl/GetPageText";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserGetPageText = new JObject();
                var browserGetPageTextpropCount = 0;
                browserGetPageTextpropCount++;
                browserGetPageText["Workflow"] = ExpressionConverter.ConvertO(__workflow_browserGetPageTextworkflow);
                if (browserGetPageTextpropCount > 0)
                {
                    callPayload.Body = browserGetPageText;
                }

                return new ApiConnectionAction<BrowserGetPageTextResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserSwitchToFrameElement(Expression<Func<string>> browserSwitchToFrameElementworkflow, Expression<Func<double>> browserSwitchToFrameElementparentElementHandle = null, Expression<Func<double>> browserSwitchToFrameElementsearchElementHandle = null, Expression<Func<string>> browserSwitchToFrameElementsearchElementName = null, Expression<Func<string>> browserSwitchToFrameElementsearchElementID = null, Expression<Func<string>> browserSwitchToFrameElementsearchElementTagName = null, Expression<Func<string>> browserSwitchToFrameElementsearchElementXPath = null, Expression<Func<string>> browserSwitchToFrameElementsearchElementClassName = null, Expression<Func<string>> browserSwitchToFrameElementsearchElementCSSSelector = null, Expression<Func<double>> browserSwitchToFrameElementsearchElementIndex = null, Expression<Func<string>> browserSwitchToFrameElementsearchElementMatchValue = null, Expression<Func<string>> browserSwitchToFrameElementsearchElementMatchText = null, Expression<Func<string>> browserSwitchToFrameElementsearchElementType = null, Expression<Func<double>> browserSwitchToFrameElementsearchElementMinimumWidth = null, Expression<Func<double>> browserSwitchToFrameElementsearchElementMinimumHeight = null, Expression<Func<double>> browserSwitchToFrameElementsearchElementBoundingBoxLeft = null, Expression<Func<double>> browserSwitchToFrameElementsearchElementBoundingBoxRight = null, Expression<Func<double>> browserSwitchToFrameElementsearchElementBoundingBoxTop = null, Expression<Func<double>> browserSwitchToFrameElementsearchElementBoundingBoxBottom = null, Expression<Func<bool>> browserSwitchToFrameElementonlyElementTopLeftNeedsToBeInBoundingBox = null)
        {
            var __workflow_browserSwitchToFrameElementworkflow = WorkflowExpression.Compile(browserSwitchToFrameElementworkflow, nameof(browserSwitchToFrameElementworkflow), required: true);
            var __workflow_browserSwitchToFrameElementparentElementHandle = WorkflowExpression.Compile(browserSwitchToFrameElementparentElementHandle, nameof(browserSwitchToFrameElementparentElementHandle), required: false);
            var __workflow_browserSwitchToFrameElementsearchElementHandle = WorkflowExpression.Compile(browserSwitchToFrameElementsearchElementHandle, nameof(browserSwitchToFrameElementsearchElementHandle), required: false);
            var __workflow_browserSwitchToFrameElementsearchElementName = WorkflowExpression.Compile(browserSwitchToFrameElementsearchElementName, nameof(browserSwitchToFrameElementsearchElementName), required: false);
            var __workflow_browserSwitchToFrameElementsearchElementID = WorkflowExpression.Compile(browserSwitchToFrameElementsearchElementID, nameof(browserSwitchToFrameElementsearchElementID), required: false);
            var __workflow_browserSwitchToFrameElementsearchElementTagName = WorkflowExpression.Compile(browserSwitchToFrameElementsearchElementTagName, nameof(browserSwitchToFrameElementsearchElementTagName), required: false);
            var __workflow_browserSwitchToFrameElementsearchElementXPath = WorkflowExpression.Compile(browserSwitchToFrameElementsearchElementXPath, nameof(browserSwitchToFrameElementsearchElementXPath), required: false);
            var __workflow_browserSwitchToFrameElementsearchElementClassName = WorkflowExpression.Compile(browserSwitchToFrameElementsearchElementClassName, nameof(browserSwitchToFrameElementsearchElementClassName), required: false);
            var __workflow_browserSwitchToFrameElementsearchElementCSSSelector = WorkflowExpression.Compile(browserSwitchToFrameElementsearchElementCSSSelector, nameof(browserSwitchToFrameElementsearchElementCSSSelector), required: false);
            var __workflow_browserSwitchToFrameElementsearchElementIndex = WorkflowExpression.Compile(browserSwitchToFrameElementsearchElementIndex, nameof(browserSwitchToFrameElementsearchElementIndex), required: false);
            var __workflow_browserSwitchToFrameElementsearchElementMatchValue = WorkflowExpression.Compile(browserSwitchToFrameElementsearchElementMatchValue, nameof(browserSwitchToFrameElementsearchElementMatchValue), required: false);
            var __workflow_browserSwitchToFrameElementsearchElementMatchText = WorkflowExpression.Compile(browserSwitchToFrameElementsearchElementMatchText, nameof(browserSwitchToFrameElementsearchElementMatchText), required: false);
            var __workflow_browserSwitchToFrameElementsearchElementType = WorkflowExpression.Compile(browserSwitchToFrameElementsearchElementType, nameof(browserSwitchToFrameElementsearchElementType), required: false);
            var __workflow_browserSwitchToFrameElementsearchElementMinimumWidth = WorkflowExpression.Compile(browserSwitchToFrameElementsearchElementMinimumWidth, nameof(browserSwitchToFrameElementsearchElementMinimumWidth), required: false);
            var __workflow_browserSwitchToFrameElementsearchElementMinimumHeight = WorkflowExpression.Compile(browserSwitchToFrameElementsearchElementMinimumHeight, nameof(browserSwitchToFrameElementsearchElementMinimumHeight), required: false);
            var __workflow_browserSwitchToFrameElementsearchElementBoundingBoxLeft = WorkflowExpression.Compile(browserSwitchToFrameElementsearchElementBoundingBoxLeft, nameof(browserSwitchToFrameElementsearchElementBoundingBoxLeft), required: false);
            var __workflow_browserSwitchToFrameElementsearchElementBoundingBoxRight = WorkflowExpression.Compile(browserSwitchToFrameElementsearchElementBoundingBoxRight, nameof(browserSwitchToFrameElementsearchElementBoundingBoxRight), required: false);
            var __workflow_browserSwitchToFrameElementsearchElementBoundingBoxTop = WorkflowExpression.Compile(browserSwitchToFrameElementsearchElementBoundingBoxTop, nameof(browserSwitchToFrameElementsearchElementBoundingBoxTop), required: false);
            var __workflow_browserSwitchToFrameElementsearchElementBoundingBoxBottom = WorkflowExpression.Compile(browserSwitchToFrameElementsearchElementBoundingBoxBottom, nameof(browserSwitchToFrameElementsearchElementBoundingBoxBottom), required: false);
            var __workflow_browserSwitchToFrameElementonlyElementTopLeftNeedsToBeInBoundingBox = WorkflowExpression.Compile(browserSwitchToFrameElementonlyElementTopLeftNeedsToBeInBoundingBox, nameof(browserSwitchToFrameElementonlyElementTopLeftNeedsToBeInBoundingBox), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/BrowserControl/SwitchToFrameElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserSwitchToFrameElement = new JObject();
                var browserSwitchToFrameElementpropCount = 0;
                if (__workflow_browserSwitchToFrameElementparentElementHandle != null)
                {
                    browserSwitchToFrameElement["ParentElementHandle"] = ExpressionConverter.ConvertO(__workflow_browserSwitchToFrameElementparentElementHandle);
                    browserSwitchToFrameElementpropCount++;
                }

                if (__workflow_browserSwitchToFrameElementsearchElementHandle != null)
                {
                    browserSwitchToFrameElement["SearchElementHandle"] = ExpressionConverter.ConvertO(__workflow_browserSwitchToFrameElementsearchElementHandle);
                    browserSwitchToFrameElementpropCount++;
                }

                if (__workflow_browserSwitchToFrameElementsearchElementName != null)
                {
                    browserSwitchToFrameElement["SearchElementName"] = ExpressionConverter.ConvertO(__workflow_browserSwitchToFrameElementsearchElementName);
                    browserSwitchToFrameElementpropCount++;
                }

                if (__workflow_browserSwitchToFrameElementsearchElementID != null)
                {
                    browserSwitchToFrameElement["SearchElementID"] = ExpressionConverter.ConvertO(__workflow_browserSwitchToFrameElementsearchElementID);
                    browserSwitchToFrameElementpropCount++;
                }

                if (__workflow_browserSwitchToFrameElementsearchElementTagName != null)
                {
                    browserSwitchToFrameElement["SearchElementTagName"] = ExpressionConverter.ConvertO(__workflow_browserSwitchToFrameElementsearchElementTagName);
                    browserSwitchToFrameElementpropCount++;
                }

                if (__workflow_browserSwitchToFrameElementsearchElementXPath != null)
                {
                    browserSwitchToFrameElement["SearchElementXPath"] = ExpressionConverter.ConvertO(__workflow_browserSwitchToFrameElementsearchElementXPath);
                    browserSwitchToFrameElementpropCount++;
                }

                if (__workflow_browserSwitchToFrameElementsearchElementClassName != null)
                {
                    browserSwitchToFrameElement["SearchElementClassName"] = ExpressionConverter.ConvertO(__workflow_browserSwitchToFrameElementsearchElementClassName);
                    browserSwitchToFrameElementpropCount++;
                }

                if (__workflow_browserSwitchToFrameElementsearchElementCSSSelector != null)
                {
                    browserSwitchToFrameElement["SearchElementCSSSelector"] = ExpressionConverter.ConvertO(__workflow_browserSwitchToFrameElementsearchElementCSSSelector);
                    browserSwitchToFrameElementpropCount++;
                }

                if (__workflow_browserSwitchToFrameElementsearchElementIndex != null)
                {
                    if (__workflow_browserSwitchToFrameElementsearchElementIndex != null)
                    {
                        browserSwitchToFrameElement["SearchElementIndex"] = ExpressionConverter.ConvertO(__workflow_browserSwitchToFrameElementsearchElementIndex);
                        browserSwitchToFrameElementpropCount++;
                    }

                    browserSwitchToFrameElementpropCount++;
                }
                else
                {
                    browserSwitchToFrameElement["SearchElementIndex"] = 1;
                    browserSwitchToFrameElementpropCount++;
                }

                if (__workflow_browserSwitchToFrameElementsearchElementMatchValue != null)
                {
                    browserSwitchToFrameElement["SearchElementMatchValue"] = ExpressionConverter.ConvertO(__workflow_browserSwitchToFrameElementsearchElementMatchValue);
                    browserSwitchToFrameElementpropCount++;
                }

                if (__workflow_browserSwitchToFrameElementsearchElementMatchText != null)
                {
                    browserSwitchToFrameElement["SearchElementMatchText"] = ExpressionConverter.ConvertO(__workflow_browserSwitchToFrameElementsearchElementMatchText);
                    browserSwitchToFrameElementpropCount++;
                }

                if (__workflow_browserSwitchToFrameElementsearchElementType != null)
                {
                    browserSwitchToFrameElement["SearchElementType"] = ExpressionConverter.ConvertO(__workflow_browserSwitchToFrameElementsearchElementType);
                    browserSwitchToFrameElementpropCount++;
                }

                if (__workflow_browserSwitchToFrameElementsearchElementMinimumWidth != null)
                {
                    if (__workflow_browserSwitchToFrameElementsearchElementMinimumWidth != null)
                    {
                        browserSwitchToFrameElement["SearchElementMinimumWidth"] = ExpressionConverter.ConvertO(__workflow_browserSwitchToFrameElementsearchElementMinimumWidth);
                        browserSwitchToFrameElementpropCount++;
                    }

                    browserSwitchToFrameElementpropCount++;
                }
                else
                {
                    browserSwitchToFrameElement["SearchElementMinimumWidth"] = 1;
                    browserSwitchToFrameElementpropCount++;
                }

                if (__workflow_browserSwitchToFrameElementsearchElementMinimumHeight != null)
                {
                    if (__workflow_browserSwitchToFrameElementsearchElementMinimumHeight != null)
                    {
                        browserSwitchToFrameElement["SearchElementMinimumHeight"] = ExpressionConverter.ConvertO(__workflow_browserSwitchToFrameElementsearchElementMinimumHeight);
                        browserSwitchToFrameElementpropCount++;
                    }

                    browserSwitchToFrameElementpropCount++;
                }
                else
                {
                    browserSwitchToFrameElement["SearchElementMinimumHeight"] = 1;
                    browserSwitchToFrameElementpropCount++;
                }

                if (__workflow_browserSwitchToFrameElementsearchElementBoundingBoxLeft != null)
                {
                    if (__workflow_browserSwitchToFrameElementsearchElementBoundingBoxLeft != null)
                    {
                        browserSwitchToFrameElement["SearchElementBoundingBoxLeft"] = ExpressionConverter.ConvertO(__workflow_browserSwitchToFrameElementsearchElementBoundingBoxLeft);
                        browserSwitchToFrameElementpropCount++;
                    }

                    browserSwitchToFrameElementpropCount++;
                }
                else
                {
                    browserSwitchToFrameElement["SearchElementBoundingBoxLeft"] = -99999;
                    browserSwitchToFrameElementpropCount++;
                }

                if (__workflow_browserSwitchToFrameElementsearchElementBoundingBoxRight != null)
                {
                    if (__workflow_browserSwitchToFrameElementsearchElementBoundingBoxRight != null)
                    {
                        browserSwitchToFrameElement["SearchElementBoundingBoxRight"] = ExpressionConverter.ConvertO(__workflow_browserSwitchToFrameElementsearchElementBoundingBoxRight);
                        browserSwitchToFrameElementpropCount++;
                    }

                    browserSwitchToFrameElementpropCount++;
                }
                else
                {
                    browserSwitchToFrameElement["SearchElementBoundingBoxRight"] = 99999;
                    browserSwitchToFrameElementpropCount++;
                }

                if (__workflow_browserSwitchToFrameElementsearchElementBoundingBoxTop != null)
                {
                    if (__workflow_browserSwitchToFrameElementsearchElementBoundingBoxTop != null)
                    {
                        browserSwitchToFrameElement["SearchElementBoundingBoxTop"] = ExpressionConverter.ConvertO(__workflow_browserSwitchToFrameElementsearchElementBoundingBoxTop);
                        browserSwitchToFrameElementpropCount++;
                    }

                    browserSwitchToFrameElementpropCount++;
                }
                else
                {
                    browserSwitchToFrameElement["SearchElementBoundingBoxTop"] = -99999;
                    browserSwitchToFrameElementpropCount++;
                }

                if (__workflow_browserSwitchToFrameElementsearchElementBoundingBoxBottom != null)
                {
                    if (__workflow_browserSwitchToFrameElementsearchElementBoundingBoxBottom != null)
                    {
                        browserSwitchToFrameElement["SearchElementBoundingBoxBottom"] = ExpressionConverter.ConvertO(__workflow_browserSwitchToFrameElementsearchElementBoundingBoxBottom);
                        browserSwitchToFrameElementpropCount++;
                    }

                    browserSwitchToFrameElementpropCount++;
                }
                else
                {
                    browserSwitchToFrameElement["SearchElementBoundingBoxBottom"] = 99999;
                    browserSwitchToFrameElementpropCount++;
                }

                if (__workflow_browserSwitchToFrameElementonlyElementTopLeftNeedsToBeInBoundingBox != null)
                {
                    if (__workflow_browserSwitchToFrameElementonlyElementTopLeftNeedsToBeInBoundingBox != null)
                    {
                        browserSwitchToFrameElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = ExpressionConverter.ConvertO(__workflow_browserSwitchToFrameElementonlyElementTopLeftNeedsToBeInBoundingBox);
                        browserSwitchToFrameElementpropCount++;
                    }

                    browserSwitchToFrameElementpropCount++;
                }
                else
                {
                    browserSwitchToFrameElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = false;
                    browserSwitchToFrameElementpropCount++;
                }

                browserSwitchToFrameElementpropCount++;
                browserSwitchToFrameElement["Workflow"] = ExpressionConverter.ConvertO(__workflow_browserSwitchToFrameElementworkflow);
                if (browserSwitchToFrameElementpropCount > 0)
                {
                    callPayload.Body = browserSwitchToFrameElement;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserGetCurrentFrameWindowPixelCoordinateResponse> BrowserGetCurrentFrameWindowPixelCoordinate(Expression<Func<string>> browserGetCurrentFrameWindowPixelCoordinateworkflow)
        {
            var __workflow_browserGetCurrentFrameWindowPixelCoordinateworkflow = WorkflowExpression.Compile(browserGetCurrentFrameWindowPixelCoordinateworkflow, nameof(browserGetCurrentFrameWindowPixelCoordinateworkflow), required: true);
            return new DeferredBodyAction<BrowserGetCurrentFrameWindowPixelCoordinateResponse>(() =>
            {
                var apiCallPath = "/BrowserControl/GetCurrentFrameWindowPixelCoordinate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserGetCurrentFrameWindowPixelCoordinate = new JObject();
                var browserGetCurrentFrameWindowPixelCoordinatepropCount = 0;
                browserGetCurrentFrameWindowPixelCoordinatepropCount++;
                browserGetCurrentFrameWindowPixelCoordinate["Workflow"] = ExpressionConverter.ConvertO(__workflow_browserGetCurrentFrameWindowPixelCoordinateworkflow);
                if (browserGetCurrentFrameWindowPixelCoordinatepropCount > 0)
                {
                    callPayload.Body = browserGetCurrentFrameWindowPixelCoordinate;
                }

                return new ApiConnectionAction<BrowserGetCurrentFrameWindowPixelCoordinateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserSwitchToParentFrameElement(Expression<Func<string>> browserSwitchToParentFrameElementworkflow)
        {
            var __workflow_browserSwitchToParentFrameElementworkflow = WorkflowExpression.Compile(browserSwitchToParentFrameElementworkflow, nameof(browserSwitchToParentFrameElementworkflow), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/BrowserControl/SwitchToParentFrameElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserSwitchToParentFrameElement = new JObject();
                var browserSwitchToParentFrameElementpropCount = 0;
                browserSwitchToParentFrameElementpropCount++;
                browserSwitchToParentFrameElement["Workflow"] = ExpressionConverter.ConvertO(__workflow_browserSwitchToParentFrameElementworkflow);
                if (browserSwitchToParentFrameElementpropCount > 0)
                {
                    callPayload.Body = browserSwitchToParentFrameElement;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserSwitchToRootFrameElement(Expression<Func<string>> browserSwitchToRootFrameElementworkflow)
        {
            var __workflow_browserSwitchToRootFrameElementworkflow = WorkflowExpression.Compile(browserSwitchToRootFrameElementworkflow, nameof(browserSwitchToRootFrameElementworkflow), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/BrowserControl/SwitchToRootFrameElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserSwitchToRootFrameElement = new JObject();
                var browserSwitchToRootFrameElementpropCount = 0;
                browserSwitchToRootFrameElementpropCount++;
                browserSwitchToRootFrameElement["Workflow"] = ExpressionConverter.ConvertO(__workflow_browserSwitchToRootFrameElementworkflow);
                if (browserSwitchToRootFrameElementpropCount > 0)
                {
                    callPayload.Body = browserSwitchToRootFrameElement;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserResetFrameStack(Expression<Func<string>> browserResetFrameStackworkflow)
        {
            var __workflow_browserResetFrameStackworkflow = WorkflowExpression.Compile(browserResetFrameStackworkflow, nameof(browserResetFrameStackworkflow), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/BrowserControl/ResetFrameStack";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserResetFrameStack = new JObject();
                var browserResetFrameStackpropCount = 0;
                browserResetFrameStackpropCount++;
                browserResetFrameStack["Workflow"] = ExpressionConverter.ConvertO(__workflow_browserResetFrameStackworkflow);
                if (browserResetFrameStackpropCount > 0)
                {
                    callPayload.Body = browserResetFrameStack;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserClearElementTextResponse> BrowserClearElementText(Expression<Func<string>> browserClearElementTextworkflow, Expression<Func<double>> browserClearElementTextparentElementHandle = null, Expression<Func<double>> browserClearElementTextsearchElementHandle = null, Expression<Func<string>> browserClearElementTextsearchElementName = null, Expression<Func<string>> browserClearElementTextsearchElementID = null, Expression<Func<string>> browserClearElementTextsearchElementTagName = null, Expression<Func<string>> browserClearElementTextsearchElementXPath = null, Expression<Func<string>> browserClearElementTextsearchElementClassName = null, Expression<Func<string>> browserClearElementTextsearchElementCSSSelector = null, Expression<Func<double>> browserClearElementTextsearchElementIndex = null, Expression<Func<string>> browserClearElementTextsearchElementMatchValue = null, Expression<Func<string>> browserClearElementTextsearchElementMatchText = null, Expression<Func<string>> browserClearElementTextsearchElementType = null, Expression<Func<double>> browserClearElementTextsearchElementMinimumWidth = null, Expression<Func<double>> browserClearElementTextsearchElementMinimumHeight = null, Expression<Func<double>> browserClearElementTextsearchElementBoundingBoxLeft = null, Expression<Func<double>> browserClearElementTextsearchElementBoundingBoxRight = null, Expression<Func<double>> browserClearElementTextsearchElementBoundingBoxTop = null, Expression<Func<double>> browserClearElementTextsearchElementBoundingBoxBottom = null, Expression<Func<bool>> browserClearElementTextonlyElementTopLeftNeedsToBeInBoundingBox = null)
        {
            var __workflow_browserClearElementTextworkflow = WorkflowExpression.Compile(browserClearElementTextworkflow, nameof(browserClearElementTextworkflow), required: true);
            var __workflow_browserClearElementTextparentElementHandle = WorkflowExpression.Compile(browserClearElementTextparentElementHandle, nameof(browserClearElementTextparentElementHandle), required: false);
            var __workflow_browserClearElementTextsearchElementHandle = WorkflowExpression.Compile(browserClearElementTextsearchElementHandle, nameof(browserClearElementTextsearchElementHandle), required: false);
            var __workflow_browserClearElementTextsearchElementName = WorkflowExpression.Compile(browserClearElementTextsearchElementName, nameof(browserClearElementTextsearchElementName), required: false);
            var __workflow_browserClearElementTextsearchElementID = WorkflowExpression.Compile(browserClearElementTextsearchElementID, nameof(browserClearElementTextsearchElementID), required: false);
            var __workflow_browserClearElementTextsearchElementTagName = WorkflowExpression.Compile(browserClearElementTextsearchElementTagName, nameof(browserClearElementTextsearchElementTagName), required: false);
            var __workflow_browserClearElementTextsearchElementXPath = WorkflowExpression.Compile(browserClearElementTextsearchElementXPath, nameof(browserClearElementTextsearchElementXPath), required: false);
            var __workflow_browserClearElementTextsearchElementClassName = WorkflowExpression.Compile(browserClearElementTextsearchElementClassName, nameof(browserClearElementTextsearchElementClassName), required: false);
            var __workflow_browserClearElementTextsearchElementCSSSelector = WorkflowExpression.Compile(browserClearElementTextsearchElementCSSSelector, nameof(browserClearElementTextsearchElementCSSSelector), required: false);
            var __workflow_browserClearElementTextsearchElementIndex = WorkflowExpression.Compile(browserClearElementTextsearchElementIndex, nameof(browserClearElementTextsearchElementIndex), required: false);
            var __workflow_browserClearElementTextsearchElementMatchValue = WorkflowExpression.Compile(browserClearElementTextsearchElementMatchValue, nameof(browserClearElementTextsearchElementMatchValue), required: false);
            var __workflow_browserClearElementTextsearchElementMatchText = WorkflowExpression.Compile(browserClearElementTextsearchElementMatchText, nameof(browserClearElementTextsearchElementMatchText), required: false);
            var __workflow_browserClearElementTextsearchElementType = WorkflowExpression.Compile(browserClearElementTextsearchElementType, nameof(browserClearElementTextsearchElementType), required: false);
            var __workflow_browserClearElementTextsearchElementMinimumWidth = WorkflowExpression.Compile(browserClearElementTextsearchElementMinimumWidth, nameof(browserClearElementTextsearchElementMinimumWidth), required: false);
            var __workflow_browserClearElementTextsearchElementMinimumHeight = WorkflowExpression.Compile(browserClearElementTextsearchElementMinimumHeight, nameof(browserClearElementTextsearchElementMinimumHeight), required: false);
            var __workflow_browserClearElementTextsearchElementBoundingBoxLeft = WorkflowExpression.Compile(browserClearElementTextsearchElementBoundingBoxLeft, nameof(browserClearElementTextsearchElementBoundingBoxLeft), required: false);
            var __workflow_browserClearElementTextsearchElementBoundingBoxRight = WorkflowExpression.Compile(browserClearElementTextsearchElementBoundingBoxRight, nameof(browserClearElementTextsearchElementBoundingBoxRight), required: false);
            var __workflow_browserClearElementTextsearchElementBoundingBoxTop = WorkflowExpression.Compile(browserClearElementTextsearchElementBoundingBoxTop, nameof(browserClearElementTextsearchElementBoundingBoxTop), required: false);
            var __workflow_browserClearElementTextsearchElementBoundingBoxBottom = WorkflowExpression.Compile(browserClearElementTextsearchElementBoundingBoxBottom, nameof(browserClearElementTextsearchElementBoundingBoxBottom), required: false);
            var __workflow_browserClearElementTextonlyElementTopLeftNeedsToBeInBoundingBox = WorkflowExpression.Compile(browserClearElementTextonlyElementTopLeftNeedsToBeInBoundingBox, nameof(browserClearElementTextonlyElementTopLeftNeedsToBeInBoundingBox), required: false);
            return new DeferredBodyAction<BrowserClearElementTextResponse>(() =>
            {
                var apiCallPath = "/BrowserControl/ClearElementText";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserClearElementText = new JObject();
                var browserClearElementTextpropCount = 0;
                if (__workflow_browserClearElementTextparentElementHandle != null)
                {
                    browserClearElementText["ParentElementHandle"] = ExpressionConverter.ConvertO(__workflow_browserClearElementTextparentElementHandle);
                    browserClearElementTextpropCount++;
                }

                if (__workflow_browserClearElementTextsearchElementHandle != null)
                {
                    browserClearElementText["SearchElementHandle"] = ExpressionConverter.ConvertO(__workflow_browserClearElementTextsearchElementHandle);
                    browserClearElementTextpropCount++;
                }

                if (__workflow_browserClearElementTextsearchElementName != null)
                {
                    browserClearElementText["SearchElementName"] = ExpressionConverter.ConvertO(__workflow_browserClearElementTextsearchElementName);
                    browserClearElementTextpropCount++;
                }

                if (__workflow_browserClearElementTextsearchElementID != null)
                {
                    browserClearElementText["SearchElementID"] = ExpressionConverter.ConvertO(__workflow_browserClearElementTextsearchElementID);
                    browserClearElementTextpropCount++;
                }

                if (__workflow_browserClearElementTextsearchElementTagName != null)
                {
                    browserClearElementText["SearchElementTagName"] = ExpressionConverter.ConvertO(__workflow_browserClearElementTextsearchElementTagName);
                    browserClearElementTextpropCount++;
                }

                if (__workflow_browserClearElementTextsearchElementXPath != null)
                {
                    browserClearElementText["SearchElementXPath"] = ExpressionConverter.ConvertO(__workflow_browserClearElementTextsearchElementXPath);
                    browserClearElementTextpropCount++;
                }

                if (__workflow_browserClearElementTextsearchElementClassName != null)
                {
                    browserClearElementText["SearchElementClassName"] = ExpressionConverter.ConvertO(__workflow_browserClearElementTextsearchElementClassName);
                    browserClearElementTextpropCount++;
                }

                if (__workflow_browserClearElementTextsearchElementCSSSelector != null)
                {
                    browserClearElementText["SearchElementCSSSelector"] = ExpressionConverter.ConvertO(__workflow_browserClearElementTextsearchElementCSSSelector);
                    browserClearElementTextpropCount++;
                }

                if (__workflow_browserClearElementTextsearchElementIndex != null)
                {
                    if (__workflow_browserClearElementTextsearchElementIndex != null)
                    {
                        browserClearElementText["SearchElementIndex"] = ExpressionConverter.ConvertO(__workflow_browserClearElementTextsearchElementIndex);
                        browserClearElementTextpropCount++;
                    }

                    browserClearElementTextpropCount++;
                }
                else
                {
                    browserClearElementText["SearchElementIndex"] = 1;
                    browserClearElementTextpropCount++;
                }

                if (__workflow_browserClearElementTextsearchElementMatchValue != null)
                {
                    browserClearElementText["SearchElementMatchValue"] = ExpressionConverter.ConvertO(__workflow_browserClearElementTextsearchElementMatchValue);
                    browserClearElementTextpropCount++;
                }

                if (__workflow_browserClearElementTextsearchElementMatchText != null)
                {
                    browserClearElementText["SearchElementMatchText"] = ExpressionConverter.ConvertO(__workflow_browserClearElementTextsearchElementMatchText);
                    browserClearElementTextpropCount++;
                }

                if (__workflow_browserClearElementTextsearchElementType != null)
                {
                    browserClearElementText["SearchElementType"] = ExpressionConverter.ConvertO(__workflow_browserClearElementTextsearchElementType);
                    browserClearElementTextpropCount++;
                }

                if (__workflow_browserClearElementTextsearchElementMinimumWidth != null)
                {
                    if (__workflow_browserClearElementTextsearchElementMinimumWidth != null)
                    {
                        browserClearElementText["SearchElementMinimumWidth"] = ExpressionConverter.ConvertO(__workflow_browserClearElementTextsearchElementMinimumWidth);
                        browserClearElementTextpropCount++;
                    }

                    browserClearElementTextpropCount++;
                }
                else
                {
                    browserClearElementText["SearchElementMinimumWidth"] = 1;
                    browserClearElementTextpropCount++;
                }

                if (__workflow_browserClearElementTextsearchElementMinimumHeight != null)
                {
                    if (__workflow_browserClearElementTextsearchElementMinimumHeight != null)
                    {
                        browserClearElementText["SearchElementMinimumHeight"] = ExpressionConverter.ConvertO(__workflow_browserClearElementTextsearchElementMinimumHeight);
                        browserClearElementTextpropCount++;
                    }

                    browserClearElementTextpropCount++;
                }
                else
                {
                    browserClearElementText["SearchElementMinimumHeight"] = 1;
                    browserClearElementTextpropCount++;
                }

                if (__workflow_browserClearElementTextsearchElementBoundingBoxLeft != null)
                {
                    if (__workflow_browserClearElementTextsearchElementBoundingBoxLeft != null)
                    {
                        browserClearElementText["SearchElementBoundingBoxLeft"] = ExpressionConverter.ConvertO(__workflow_browserClearElementTextsearchElementBoundingBoxLeft);
                        browserClearElementTextpropCount++;
                    }

                    browserClearElementTextpropCount++;
                }
                else
                {
                    browserClearElementText["SearchElementBoundingBoxLeft"] = -99999;
                    browserClearElementTextpropCount++;
                }

                if (__workflow_browserClearElementTextsearchElementBoundingBoxRight != null)
                {
                    if (__workflow_browserClearElementTextsearchElementBoundingBoxRight != null)
                    {
                        browserClearElementText["SearchElementBoundingBoxRight"] = ExpressionConverter.ConvertO(__workflow_browserClearElementTextsearchElementBoundingBoxRight);
                        browserClearElementTextpropCount++;
                    }

                    browserClearElementTextpropCount++;
                }
                else
                {
                    browserClearElementText["SearchElementBoundingBoxRight"] = 99999;
                    browserClearElementTextpropCount++;
                }

                if (__workflow_browserClearElementTextsearchElementBoundingBoxTop != null)
                {
                    if (__workflow_browserClearElementTextsearchElementBoundingBoxTop != null)
                    {
                        browserClearElementText["SearchElementBoundingBoxTop"] = ExpressionConverter.ConvertO(__workflow_browserClearElementTextsearchElementBoundingBoxTop);
                        browserClearElementTextpropCount++;
                    }

                    browserClearElementTextpropCount++;
                }
                else
                {
                    browserClearElementText["SearchElementBoundingBoxTop"] = -99999;
                    browserClearElementTextpropCount++;
                }

                if (__workflow_browserClearElementTextsearchElementBoundingBoxBottom != null)
                {
                    if (__workflow_browserClearElementTextsearchElementBoundingBoxBottom != null)
                    {
                        browserClearElementText["SearchElementBoundingBoxBottom"] = ExpressionConverter.ConvertO(__workflow_browserClearElementTextsearchElementBoundingBoxBottom);
                        browserClearElementTextpropCount++;
                    }

                    browserClearElementTextpropCount++;
                }
                else
                {
                    browserClearElementText["SearchElementBoundingBoxBottom"] = 99999;
                    browserClearElementTextpropCount++;
                }

                if (__workflow_browserClearElementTextonlyElementTopLeftNeedsToBeInBoundingBox != null)
                {
                    if (__workflow_browserClearElementTextonlyElementTopLeftNeedsToBeInBoundingBox != null)
                    {
                        browserClearElementText["OnlyElementTopLeftNeedsToBeInBoundingBox"] = ExpressionConverter.ConvertO(__workflow_browserClearElementTextonlyElementTopLeftNeedsToBeInBoundingBox);
                        browserClearElementTextpropCount++;
                    }

                    browserClearElementTextpropCount++;
                }
                else
                {
                    browserClearElementText["OnlyElementTopLeftNeedsToBeInBoundingBox"] = false;
                    browserClearElementTextpropCount++;
                }

                browserClearElementTextpropCount++;
                browserClearElementText["Workflow"] = ExpressionConverter.ConvertO(__workflow_browserClearElementTextworkflow);
                if (browserClearElementTextpropCount > 0)
                {
                    callPayload.Body = browserClearElementText;
                }

                return new ApiConnectionAction<BrowserClearElementTextResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserCopySelectedTextOnElement(Expression<Func<string>> browserCopySelectedTextOnElementworkflow, Expression<Func<double>> browserCopySelectedTextOnElementparentElementHandle = null, Expression<Func<double>> browserCopySelectedTextOnElementsearchElementHandle = null, Expression<Func<string>> browserCopySelectedTextOnElementsearchElementName = null, Expression<Func<string>> browserCopySelectedTextOnElementsearchElementID = null, Expression<Func<string>> browserCopySelectedTextOnElementsearchElementTagName = null, Expression<Func<string>> browserCopySelectedTextOnElementsearchElementXPath = null, Expression<Func<string>> browserCopySelectedTextOnElementsearchElementClassName = null, Expression<Func<string>> browserCopySelectedTextOnElementsearchElementCSSSelector = null, Expression<Func<double>> browserCopySelectedTextOnElementsearchElementIndex = null, Expression<Func<string>> browserCopySelectedTextOnElementsearchElementMatchValue = null, Expression<Func<string>> browserCopySelectedTextOnElementsearchElementMatchText = null, Expression<Func<string>> browserCopySelectedTextOnElementsearchElementType = null, Expression<Func<double>> browserCopySelectedTextOnElementsearchElementMinimumWidth = null, Expression<Func<double>> browserCopySelectedTextOnElementsearchElementMinimumHeight = null, Expression<Func<double>> browserCopySelectedTextOnElementsearchElementBoundingBoxLeft = null, Expression<Func<double>> browserCopySelectedTextOnElementsearchElementBoundingBoxRight = null, Expression<Func<double>> browserCopySelectedTextOnElementsearchElementBoundingBoxTop = null, Expression<Func<double>> browserCopySelectedTextOnElementsearchElementBoundingBoxBottom = null, Expression<Func<bool>> browserCopySelectedTextOnElementonlyElementTopLeftNeedsToBeInBoundingBox = null)
        {
            var __workflow_browserCopySelectedTextOnElementworkflow = WorkflowExpression.Compile(browserCopySelectedTextOnElementworkflow, nameof(browserCopySelectedTextOnElementworkflow), required: true);
            var __workflow_browserCopySelectedTextOnElementparentElementHandle = WorkflowExpression.Compile(browserCopySelectedTextOnElementparentElementHandle, nameof(browserCopySelectedTextOnElementparentElementHandle), required: false);
            var __workflow_browserCopySelectedTextOnElementsearchElementHandle = WorkflowExpression.Compile(browserCopySelectedTextOnElementsearchElementHandle, nameof(browserCopySelectedTextOnElementsearchElementHandle), required: false);
            var __workflow_browserCopySelectedTextOnElementsearchElementName = WorkflowExpression.Compile(browserCopySelectedTextOnElementsearchElementName, nameof(browserCopySelectedTextOnElementsearchElementName), required: false);
            var __workflow_browserCopySelectedTextOnElementsearchElementID = WorkflowExpression.Compile(browserCopySelectedTextOnElementsearchElementID, nameof(browserCopySelectedTextOnElementsearchElementID), required: false);
            var __workflow_browserCopySelectedTextOnElementsearchElementTagName = WorkflowExpression.Compile(browserCopySelectedTextOnElementsearchElementTagName, nameof(browserCopySelectedTextOnElementsearchElementTagName), required: false);
            var __workflow_browserCopySelectedTextOnElementsearchElementXPath = WorkflowExpression.Compile(browserCopySelectedTextOnElementsearchElementXPath, nameof(browserCopySelectedTextOnElementsearchElementXPath), required: false);
            var __workflow_browserCopySelectedTextOnElementsearchElementClassName = WorkflowExpression.Compile(browserCopySelectedTextOnElementsearchElementClassName, nameof(browserCopySelectedTextOnElementsearchElementClassName), required: false);
            var __workflow_browserCopySelectedTextOnElementsearchElementCSSSelector = WorkflowExpression.Compile(browserCopySelectedTextOnElementsearchElementCSSSelector, nameof(browserCopySelectedTextOnElementsearchElementCSSSelector), required: false);
            var __workflow_browserCopySelectedTextOnElementsearchElementIndex = WorkflowExpression.Compile(browserCopySelectedTextOnElementsearchElementIndex, nameof(browserCopySelectedTextOnElementsearchElementIndex), required: false);
            var __workflow_browserCopySelectedTextOnElementsearchElementMatchValue = WorkflowExpression.Compile(browserCopySelectedTextOnElementsearchElementMatchValue, nameof(browserCopySelectedTextOnElementsearchElementMatchValue), required: false);
            var __workflow_browserCopySelectedTextOnElementsearchElementMatchText = WorkflowExpression.Compile(browserCopySelectedTextOnElementsearchElementMatchText, nameof(browserCopySelectedTextOnElementsearchElementMatchText), required: false);
            var __workflow_browserCopySelectedTextOnElementsearchElementType = WorkflowExpression.Compile(browserCopySelectedTextOnElementsearchElementType, nameof(browserCopySelectedTextOnElementsearchElementType), required: false);
            var __workflow_browserCopySelectedTextOnElementsearchElementMinimumWidth = WorkflowExpression.Compile(browserCopySelectedTextOnElementsearchElementMinimumWidth, nameof(browserCopySelectedTextOnElementsearchElementMinimumWidth), required: false);
            var __workflow_browserCopySelectedTextOnElementsearchElementMinimumHeight = WorkflowExpression.Compile(browserCopySelectedTextOnElementsearchElementMinimumHeight, nameof(browserCopySelectedTextOnElementsearchElementMinimumHeight), required: false);
            var __workflow_browserCopySelectedTextOnElementsearchElementBoundingBoxLeft = WorkflowExpression.Compile(browserCopySelectedTextOnElementsearchElementBoundingBoxLeft, nameof(browserCopySelectedTextOnElementsearchElementBoundingBoxLeft), required: false);
            var __workflow_browserCopySelectedTextOnElementsearchElementBoundingBoxRight = WorkflowExpression.Compile(browserCopySelectedTextOnElementsearchElementBoundingBoxRight, nameof(browserCopySelectedTextOnElementsearchElementBoundingBoxRight), required: false);
            var __workflow_browserCopySelectedTextOnElementsearchElementBoundingBoxTop = WorkflowExpression.Compile(browserCopySelectedTextOnElementsearchElementBoundingBoxTop, nameof(browserCopySelectedTextOnElementsearchElementBoundingBoxTop), required: false);
            var __workflow_browserCopySelectedTextOnElementsearchElementBoundingBoxBottom = WorkflowExpression.Compile(browserCopySelectedTextOnElementsearchElementBoundingBoxBottom, nameof(browserCopySelectedTextOnElementsearchElementBoundingBoxBottom), required: false);
            var __workflow_browserCopySelectedTextOnElementonlyElementTopLeftNeedsToBeInBoundingBox = WorkflowExpression.Compile(browserCopySelectedTextOnElementonlyElementTopLeftNeedsToBeInBoundingBox, nameof(browserCopySelectedTextOnElementonlyElementTopLeftNeedsToBeInBoundingBox), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/BrowserControl/CopySelectedTextOnElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserCopySelectedTextOnElement = new JObject();
                var browserCopySelectedTextOnElementpropCount = 0;
                if (__workflow_browserCopySelectedTextOnElementparentElementHandle != null)
                {
                    browserCopySelectedTextOnElement["ParentElementHandle"] = ExpressionConverter.ConvertO(__workflow_browserCopySelectedTextOnElementparentElementHandle);
                    browserCopySelectedTextOnElementpropCount++;
                }

                if (__workflow_browserCopySelectedTextOnElementsearchElementHandle != null)
                {
                    browserCopySelectedTextOnElement["SearchElementHandle"] = ExpressionConverter.ConvertO(__workflow_browserCopySelectedTextOnElementsearchElementHandle);
                    browserCopySelectedTextOnElementpropCount++;
                }

                if (__workflow_browserCopySelectedTextOnElementsearchElementName != null)
                {
                    browserCopySelectedTextOnElement["SearchElementName"] = ExpressionConverter.ConvertO(__workflow_browserCopySelectedTextOnElementsearchElementName);
                    browserCopySelectedTextOnElementpropCount++;
                }

                if (__workflow_browserCopySelectedTextOnElementsearchElementID != null)
                {
                    browserCopySelectedTextOnElement["SearchElementID"] = ExpressionConverter.ConvertO(__workflow_browserCopySelectedTextOnElementsearchElementID);
                    browserCopySelectedTextOnElementpropCount++;
                }

                if (__workflow_browserCopySelectedTextOnElementsearchElementTagName != null)
                {
                    browserCopySelectedTextOnElement["SearchElementTagName"] = ExpressionConverter.ConvertO(__workflow_browserCopySelectedTextOnElementsearchElementTagName);
                    browserCopySelectedTextOnElementpropCount++;
                }

                if (__workflow_browserCopySelectedTextOnElementsearchElementXPath != null)
                {
                    browserCopySelectedTextOnElement["SearchElementXPath"] = ExpressionConverter.ConvertO(__workflow_browserCopySelectedTextOnElementsearchElementXPath);
                    browserCopySelectedTextOnElementpropCount++;
                }

                if (__workflow_browserCopySelectedTextOnElementsearchElementClassName != null)
                {
                    browserCopySelectedTextOnElement["SearchElementClassName"] = ExpressionConverter.ConvertO(__workflow_browserCopySelectedTextOnElementsearchElementClassName);
                    browserCopySelectedTextOnElementpropCount++;
                }

                if (__workflow_browserCopySelectedTextOnElementsearchElementCSSSelector != null)
                {
                    browserCopySelectedTextOnElement["SearchElementCSSSelector"] = ExpressionConverter.ConvertO(__workflow_browserCopySelectedTextOnElementsearchElementCSSSelector);
                    browserCopySelectedTextOnElementpropCount++;
                }

                if (__workflow_browserCopySelectedTextOnElementsearchElementIndex != null)
                {
                    if (__workflow_browserCopySelectedTextOnElementsearchElementIndex != null)
                    {
                        browserCopySelectedTextOnElement["SearchElementIndex"] = ExpressionConverter.ConvertO(__workflow_browserCopySelectedTextOnElementsearchElementIndex);
                        browserCopySelectedTextOnElementpropCount++;
                    }

                    browserCopySelectedTextOnElementpropCount++;
                }
                else
                {
                    browserCopySelectedTextOnElement["SearchElementIndex"] = 1;
                    browserCopySelectedTextOnElementpropCount++;
                }

                if (__workflow_browserCopySelectedTextOnElementsearchElementMatchValue != null)
                {
                    browserCopySelectedTextOnElement["SearchElementMatchValue"] = ExpressionConverter.ConvertO(__workflow_browserCopySelectedTextOnElementsearchElementMatchValue);
                    browserCopySelectedTextOnElementpropCount++;
                }

                if (__workflow_browserCopySelectedTextOnElementsearchElementMatchText != null)
                {
                    browserCopySelectedTextOnElement["SearchElementMatchText"] = ExpressionConverter.ConvertO(__workflow_browserCopySelectedTextOnElementsearchElementMatchText);
                    browserCopySelectedTextOnElementpropCount++;
                }

                if (__workflow_browserCopySelectedTextOnElementsearchElementType != null)
                {
                    browserCopySelectedTextOnElement["SearchElementType"] = ExpressionConverter.ConvertO(__workflow_browserCopySelectedTextOnElementsearchElementType);
                    browserCopySelectedTextOnElementpropCount++;
                }

                if (__workflow_browserCopySelectedTextOnElementsearchElementMinimumWidth != null)
                {
                    if (__workflow_browserCopySelectedTextOnElementsearchElementMinimumWidth != null)
                    {
                        browserCopySelectedTextOnElement["SearchElementMinimumWidth"] = ExpressionConverter.ConvertO(__workflow_browserCopySelectedTextOnElementsearchElementMinimumWidth);
                        browserCopySelectedTextOnElementpropCount++;
                    }

                    browserCopySelectedTextOnElementpropCount++;
                }
                else
                {
                    browserCopySelectedTextOnElement["SearchElementMinimumWidth"] = 1;
                    browserCopySelectedTextOnElementpropCount++;
                }

                if (__workflow_browserCopySelectedTextOnElementsearchElementMinimumHeight != null)
                {
                    if (__workflow_browserCopySelectedTextOnElementsearchElementMinimumHeight != null)
                    {
                        browserCopySelectedTextOnElement["SearchElementMinimumHeight"] = ExpressionConverter.ConvertO(__workflow_browserCopySelectedTextOnElementsearchElementMinimumHeight);
                        browserCopySelectedTextOnElementpropCount++;
                    }

                    browserCopySelectedTextOnElementpropCount++;
                }
                else
                {
                    browserCopySelectedTextOnElement["SearchElementMinimumHeight"] = 1;
                    browserCopySelectedTextOnElementpropCount++;
                }

                if (__workflow_browserCopySelectedTextOnElementsearchElementBoundingBoxLeft != null)
                {
                    if (__workflow_browserCopySelectedTextOnElementsearchElementBoundingBoxLeft != null)
                    {
                        browserCopySelectedTextOnElement["SearchElementBoundingBoxLeft"] = ExpressionConverter.ConvertO(__workflow_browserCopySelectedTextOnElementsearchElementBoundingBoxLeft);
                        browserCopySelectedTextOnElementpropCount++;
                    }

                    browserCopySelectedTextOnElementpropCount++;
                }
                else
                {
                    browserCopySelectedTextOnElement["SearchElementBoundingBoxLeft"] = -99999;
                    browserCopySelectedTextOnElementpropCount++;
                }

                if (__workflow_browserCopySelectedTextOnElementsearchElementBoundingBoxRight != null)
                {
                    if (__workflow_browserCopySelectedTextOnElementsearchElementBoundingBoxRight != null)
                    {
                        browserCopySelectedTextOnElement["SearchElementBoundingBoxRight"] = ExpressionConverter.ConvertO(__workflow_browserCopySelectedTextOnElementsearchElementBoundingBoxRight);
                        browserCopySelectedTextOnElementpropCount++;
                    }

                    browserCopySelectedTextOnElementpropCount++;
                }
                else
                {
                    browserCopySelectedTextOnElement["SearchElementBoundingBoxRight"] = 99999;
                    browserCopySelectedTextOnElementpropCount++;
                }

                if (__workflow_browserCopySelectedTextOnElementsearchElementBoundingBoxTop != null)
                {
                    if (__workflow_browserCopySelectedTextOnElementsearchElementBoundingBoxTop != null)
                    {
                        browserCopySelectedTextOnElement["SearchElementBoundingBoxTop"] = ExpressionConverter.ConvertO(__workflow_browserCopySelectedTextOnElementsearchElementBoundingBoxTop);
                        browserCopySelectedTextOnElementpropCount++;
                    }

                    browserCopySelectedTextOnElementpropCount++;
                }
                else
                {
                    browserCopySelectedTextOnElement["SearchElementBoundingBoxTop"] = -99999;
                    browserCopySelectedTextOnElementpropCount++;
                }

                if (__workflow_browserCopySelectedTextOnElementsearchElementBoundingBoxBottom != null)
                {
                    if (__workflow_browserCopySelectedTextOnElementsearchElementBoundingBoxBottom != null)
                    {
                        browserCopySelectedTextOnElement["SearchElementBoundingBoxBottom"] = ExpressionConverter.ConvertO(__workflow_browserCopySelectedTextOnElementsearchElementBoundingBoxBottom);
                        browserCopySelectedTextOnElementpropCount++;
                    }

                    browserCopySelectedTextOnElementpropCount++;
                }
                else
                {
                    browserCopySelectedTextOnElement["SearchElementBoundingBoxBottom"] = 99999;
                    browserCopySelectedTextOnElementpropCount++;
                }

                if (__workflow_browserCopySelectedTextOnElementonlyElementTopLeftNeedsToBeInBoundingBox != null)
                {
                    if (__workflow_browserCopySelectedTextOnElementonlyElementTopLeftNeedsToBeInBoundingBox != null)
                    {
                        browserCopySelectedTextOnElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = ExpressionConverter.ConvertO(__workflow_browserCopySelectedTextOnElementonlyElementTopLeftNeedsToBeInBoundingBox);
                        browserCopySelectedTextOnElementpropCount++;
                    }

                    browserCopySelectedTextOnElementpropCount++;
                }
                else
                {
                    browserCopySelectedTextOnElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = false;
                    browserCopySelectedTextOnElementpropCount++;
                }

                browserCopySelectedTextOnElementpropCount++;
                browserCopySelectedTextOnElement["Workflow"] = ExpressionConverter.ConvertO(__workflow_browserCopySelectedTextOnElementworkflow);
                if (browserCopySelectedTextOnElementpropCount > 0)
                {
                    callPayload.Body = browserCopySelectedTextOnElement;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserInputPasswordIntoElement(Expression<Func<string>> browserInputPasswordIntoElementpasswordToInput, Expression<Func<string>> browserInputPasswordIntoElementworkflow, Expression<Func<double>> browserInputPasswordIntoElementparentElementHandle = null, Expression<Func<double>> browserInputPasswordIntoElementsearchElementHandle = null, Expression<Func<string>> browserInputPasswordIntoElementsearchElementName = null, Expression<Func<string>> browserInputPasswordIntoElementsearchElementID = null, Expression<Func<string>> browserInputPasswordIntoElementsearchElementTagName = null, Expression<Func<string>> browserInputPasswordIntoElementsearchElementXPath = null, Expression<Func<string>> browserInputPasswordIntoElementsearchElementClassName = null, Expression<Func<string>> browserInputPasswordIntoElementsearchElementCSSSelector = null, Expression<Func<double>> browserInputPasswordIntoElementsearchElementIndex = null, Expression<Func<string>> browserInputPasswordIntoElementsearchElementMatchValue = null, Expression<Func<string>> browserInputPasswordIntoElementsearchElementMatchText = null, Expression<Func<string>> browserInputPasswordIntoElementsearchElementType = null, Expression<Func<double>> browserInputPasswordIntoElementsearchElementMinimumWidth = null, Expression<Func<double>> browserInputPasswordIntoElementsearchElementMinimumHeight = null, Expression<Func<double>> browserInputPasswordIntoElementsearchElementBoundingBoxLeft = null, Expression<Func<double>> browserInputPasswordIntoElementsearchElementBoundingBoxRight = null, Expression<Func<double>> browserInputPasswordIntoElementsearchElementBoundingBoxTop = null, Expression<Func<double>> browserInputPasswordIntoElementsearchElementBoundingBoxBottom = null, Expression<Func<bool>> browserInputPasswordIntoElementonlyElementTopLeftNeedsToBeInBoundingBox = null, Expression<Func<bool>> browserInputPasswordIntoElementresetExistingValue = null, Expression<Func<bool>> browserInputPasswordIntoElementpasswordContainsStoredPassword = null)
        {
            var __workflow_browserInputPasswordIntoElementpasswordToInput = WorkflowExpression.Compile(browserInputPasswordIntoElementpasswordToInput, nameof(browserInputPasswordIntoElementpasswordToInput), required: true);
            var __workflow_browserInputPasswordIntoElementworkflow = WorkflowExpression.Compile(browserInputPasswordIntoElementworkflow, nameof(browserInputPasswordIntoElementworkflow), required: true);
            var __workflow_browserInputPasswordIntoElementparentElementHandle = WorkflowExpression.Compile(browserInputPasswordIntoElementparentElementHandle, nameof(browserInputPasswordIntoElementparentElementHandle), required: false);
            var __workflow_browserInputPasswordIntoElementsearchElementHandle = WorkflowExpression.Compile(browserInputPasswordIntoElementsearchElementHandle, nameof(browserInputPasswordIntoElementsearchElementHandle), required: false);
            var __workflow_browserInputPasswordIntoElementsearchElementName = WorkflowExpression.Compile(browserInputPasswordIntoElementsearchElementName, nameof(browserInputPasswordIntoElementsearchElementName), required: false);
            var __workflow_browserInputPasswordIntoElementsearchElementID = WorkflowExpression.Compile(browserInputPasswordIntoElementsearchElementID, nameof(browserInputPasswordIntoElementsearchElementID), required: false);
            var __workflow_browserInputPasswordIntoElementsearchElementTagName = WorkflowExpression.Compile(browserInputPasswordIntoElementsearchElementTagName, nameof(browserInputPasswordIntoElementsearchElementTagName), required: false);
            var __workflow_browserInputPasswordIntoElementsearchElementXPath = WorkflowExpression.Compile(browserInputPasswordIntoElementsearchElementXPath, nameof(browserInputPasswordIntoElementsearchElementXPath), required: false);
            var __workflow_browserInputPasswordIntoElementsearchElementClassName = WorkflowExpression.Compile(browserInputPasswordIntoElementsearchElementClassName, nameof(browserInputPasswordIntoElementsearchElementClassName), required: false);
            var __workflow_browserInputPasswordIntoElementsearchElementCSSSelector = WorkflowExpression.Compile(browserInputPasswordIntoElementsearchElementCSSSelector, nameof(browserInputPasswordIntoElementsearchElementCSSSelector), required: false);
            var __workflow_browserInputPasswordIntoElementsearchElementIndex = WorkflowExpression.Compile(browserInputPasswordIntoElementsearchElementIndex, nameof(browserInputPasswordIntoElementsearchElementIndex), required: false);
            var __workflow_browserInputPasswordIntoElementsearchElementMatchValue = WorkflowExpression.Compile(browserInputPasswordIntoElementsearchElementMatchValue, nameof(browserInputPasswordIntoElementsearchElementMatchValue), required: false);
            var __workflow_browserInputPasswordIntoElementsearchElementMatchText = WorkflowExpression.Compile(browserInputPasswordIntoElementsearchElementMatchText, nameof(browserInputPasswordIntoElementsearchElementMatchText), required: false);
            var __workflow_browserInputPasswordIntoElementsearchElementType = WorkflowExpression.Compile(browserInputPasswordIntoElementsearchElementType, nameof(browserInputPasswordIntoElementsearchElementType), required: false);
            var __workflow_browserInputPasswordIntoElementsearchElementMinimumWidth = WorkflowExpression.Compile(browserInputPasswordIntoElementsearchElementMinimumWidth, nameof(browserInputPasswordIntoElementsearchElementMinimumWidth), required: false);
            var __workflow_browserInputPasswordIntoElementsearchElementMinimumHeight = WorkflowExpression.Compile(browserInputPasswordIntoElementsearchElementMinimumHeight, nameof(browserInputPasswordIntoElementsearchElementMinimumHeight), required: false);
            var __workflow_browserInputPasswordIntoElementsearchElementBoundingBoxLeft = WorkflowExpression.Compile(browserInputPasswordIntoElementsearchElementBoundingBoxLeft, nameof(browserInputPasswordIntoElementsearchElementBoundingBoxLeft), required: false);
            var __workflow_browserInputPasswordIntoElementsearchElementBoundingBoxRight = WorkflowExpression.Compile(browserInputPasswordIntoElementsearchElementBoundingBoxRight, nameof(browserInputPasswordIntoElementsearchElementBoundingBoxRight), required: false);
            var __workflow_browserInputPasswordIntoElementsearchElementBoundingBoxTop = WorkflowExpression.Compile(browserInputPasswordIntoElementsearchElementBoundingBoxTop, nameof(browserInputPasswordIntoElementsearchElementBoundingBoxTop), required: false);
            var __workflow_browserInputPasswordIntoElementsearchElementBoundingBoxBottom = WorkflowExpression.Compile(browserInputPasswordIntoElementsearchElementBoundingBoxBottom, nameof(browserInputPasswordIntoElementsearchElementBoundingBoxBottom), required: false);
            var __workflow_browserInputPasswordIntoElementonlyElementTopLeftNeedsToBeInBoundingBox = WorkflowExpression.Compile(browserInputPasswordIntoElementonlyElementTopLeftNeedsToBeInBoundingBox, nameof(browserInputPasswordIntoElementonlyElementTopLeftNeedsToBeInBoundingBox), required: false);
            var __workflow_browserInputPasswordIntoElementresetExistingValue = WorkflowExpression.Compile(browserInputPasswordIntoElementresetExistingValue, nameof(browserInputPasswordIntoElementresetExistingValue), required: false);
            var __workflow_browserInputPasswordIntoElementpasswordContainsStoredPassword = WorkflowExpression.Compile(browserInputPasswordIntoElementpasswordContainsStoredPassword, nameof(browserInputPasswordIntoElementpasswordContainsStoredPassword), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/BrowserControl/InputPasswordIntoElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserInputPasswordIntoElement = new JObject();
                var browserInputPasswordIntoElementpropCount = 0;
                if (__workflow_browserInputPasswordIntoElementparentElementHandle != null)
                {
                    browserInputPasswordIntoElement["ParentElementHandle"] = ExpressionConverter.ConvertO(__workflow_browserInputPasswordIntoElementparentElementHandle);
                    browserInputPasswordIntoElementpropCount++;
                }

                if (__workflow_browserInputPasswordIntoElementsearchElementHandle != null)
                {
                    browserInputPasswordIntoElement["SearchElementHandle"] = ExpressionConverter.ConvertO(__workflow_browserInputPasswordIntoElementsearchElementHandle);
                    browserInputPasswordIntoElementpropCount++;
                }

                if (__workflow_browserInputPasswordIntoElementsearchElementName != null)
                {
                    browserInputPasswordIntoElement["SearchElementName"] = ExpressionConverter.ConvertO(__workflow_browserInputPasswordIntoElementsearchElementName);
                    browserInputPasswordIntoElementpropCount++;
                }

                if (__workflow_browserInputPasswordIntoElementsearchElementID != null)
                {
                    browserInputPasswordIntoElement["SearchElementID"] = ExpressionConverter.ConvertO(__workflow_browserInputPasswordIntoElementsearchElementID);
                    browserInputPasswordIntoElementpropCount++;
                }

                if (__workflow_browserInputPasswordIntoElementsearchElementTagName != null)
                {
                    browserInputPasswordIntoElement["SearchElementTagName"] = ExpressionConverter.ConvertO(__workflow_browserInputPasswordIntoElementsearchElementTagName);
                    browserInputPasswordIntoElementpropCount++;
                }

                if (__workflow_browserInputPasswordIntoElementsearchElementXPath != null)
                {
                    browserInputPasswordIntoElement["SearchElementXPath"] = ExpressionConverter.ConvertO(__workflow_browserInputPasswordIntoElementsearchElementXPath);
                    browserInputPasswordIntoElementpropCount++;
                }

                if (__workflow_browserInputPasswordIntoElementsearchElementClassName != null)
                {
                    browserInputPasswordIntoElement["SearchElementClassName"] = ExpressionConverter.ConvertO(__workflow_browserInputPasswordIntoElementsearchElementClassName);
                    browserInputPasswordIntoElementpropCount++;
                }

                if (__workflow_browserInputPasswordIntoElementsearchElementCSSSelector != null)
                {
                    browserInputPasswordIntoElement["SearchElementCSSSelector"] = ExpressionConverter.ConvertO(__workflow_browserInputPasswordIntoElementsearchElementCSSSelector);
                    browserInputPasswordIntoElementpropCount++;
                }

                if (__workflow_browserInputPasswordIntoElementsearchElementIndex != null)
                {
                    if (__workflow_browserInputPasswordIntoElementsearchElementIndex != null)
                    {
                        browserInputPasswordIntoElement["SearchElementIndex"] = ExpressionConverter.ConvertO(__workflow_browserInputPasswordIntoElementsearchElementIndex);
                        browserInputPasswordIntoElementpropCount++;
                    }

                    browserInputPasswordIntoElementpropCount++;
                }
                else
                {
                    browserInputPasswordIntoElement["SearchElementIndex"] = 1;
                    browserInputPasswordIntoElementpropCount++;
                }

                if (__workflow_browserInputPasswordIntoElementsearchElementMatchValue != null)
                {
                    browserInputPasswordIntoElement["SearchElementMatchValue"] = ExpressionConverter.ConvertO(__workflow_browserInputPasswordIntoElementsearchElementMatchValue);
                    browserInputPasswordIntoElementpropCount++;
                }

                if (__workflow_browserInputPasswordIntoElementsearchElementMatchText != null)
                {
                    browserInputPasswordIntoElement["SearchElementMatchText"] = ExpressionConverter.ConvertO(__workflow_browserInputPasswordIntoElementsearchElementMatchText);
                    browserInputPasswordIntoElementpropCount++;
                }

                if (__workflow_browserInputPasswordIntoElementsearchElementType != null)
                {
                    browserInputPasswordIntoElement["SearchElementType"] = ExpressionConverter.ConvertO(__workflow_browserInputPasswordIntoElementsearchElementType);
                    browserInputPasswordIntoElementpropCount++;
                }

                if (__workflow_browserInputPasswordIntoElementsearchElementMinimumWidth != null)
                {
                    if (__workflow_browserInputPasswordIntoElementsearchElementMinimumWidth != null)
                    {
                        browserInputPasswordIntoElement["SearchElementMinimumWidth"] = ExpressionConverter.ConvertO(__workflow_browserInputPasswordIntoElementsearchElementMinimumWidth);
                        browserInputPasswordIntoElementpropCount++;
                    }

                    browserInputPasswordIntoElementpropCount++;
                }
                else
                {
                    browserInputPasswordIntoElement["SearchElementMinimumWidth"] = 1;
                    browserInputPasswordIntoElementpropCount++;
                }

                if (__workflow_browserInputPasswordIntoElementsearchElementMinimumHeight != null)
                {
                    if (__workflow_browserInputPasswordIntoElementsearchElementMinimumHeight != null)
                    {
                        browserInputPasswordIntoElement["SearchElementMinimumHeight"] = ExpressionConverter.ConvertO(__workflow_browserInputPasswordIntoElementsearchElementMinimumHeight);
                        browserInputPasswordIntoElementpropCount++;
                    }

                    browserInputPasswordIntoElementpropCount++;
                }
                else
                {
                    browserInputPasswordIntoElement["SearchElementMinimumHeight"] = 1;
                    browserInputPasswordIntoElementpropCount++;
                }

                if (__workflow_browserInputPasswordIntoElementsearchElementBoundingBoxLeft != null)
                {
                    if (__workflow_browserInputPasswordIntoElementsearchElementBoundingBoxLeft != null)
                    {
                        browserInputPasswordIntoElement["SearchElementBoundingBoxLeft"] = ExpressionConverter.ConvertO(__workflow_browserInputPasswordIntoElementsearchElementBoundingBoxLeft);
                        browserInputPasswordIntoElementpropCount++;
                    }

                    browserInputPasswordIntoElementpropCount++;
                }
                else
                {
                    browserInputPasswordIntoElement["SearchElementBoundingBoxLeft"] = -99999;
                    browserInputPasswordIntoElementpropCount++;
                }

                if (__workflow_browserInputPasswordIntoElementsearchElementBoundingBoxRight != null)
                {
                    if (__workflow_browserInputPasswordIntoElementsearchElementBoundingBoxRight != null)
                    {
                        browserInputPasswordIntoElement["SearchElementBoundingBoxRight"] = ExpressionConverter.ConvertO(__workflow_browserInputPasswordIntoElementsearchElementBoundingBoxRight);
                        browserInputPasswordIntoElementpropCount++;
                    }

                    browserInputPasswordIntoElementpropCount++;
                }
                else
                {
                    browserInputPasswordIntoElement["SearchElementBoundingBoxRight"] = 99999;
                    browserInputPasswordIntoElementpropCount++;
                }

                if (__workflow_browserInputPasswordIntoElementsearchElementBoundingBoxTop != null)
                {
                    if (__workflow_browserInputPasswordIntoElementsearchElementBoundingBoxTop != null)
                    {
                        browserInputPasswordIntoElement["SearchElementBoundingBoxTop"] = ExpressionConverter.ConvertO(__workflow_browserInputPasswordIntoElementsearchElementBoundingBoxTop);
                        browserInputPasswordIntoElementpropCount++;
                    }

                    browserInputPasswordIntoElementpropCount++;
                }
                else
                {
                    browserInputPasswordIntoElement["SearchElementBoundingBoxTop"] = -99999;
                    browserInputPasswordIntoElementpropCount++;
                }

                if (__workflow_browserInputPasswordIntoElementsearchElementBoundingBoxBottom != null)
                {
                    if (__workflow_browserInputPasswordIntoElementsearchElementBoundingBoxBottom != null)
                    {
                        browserInputPasswordIntoElement["SearchElementBoundingBoxBottom"] = ExpressionConverter.ConvertO(__workflow_browserInputPasswordIntoElementsearchElementBoundingBoxBottom);
                        browserInputPasswordIntoElementpropCount++;
                    }

                    browserInputPasswordIntoElementpropCount++;
                }
                else
                {
                    browserInputPasswordIntoElement["SearchElementBoundingBoxBottom"] = 99999;
                    browserInputPasswordIntoElementpropCount++;
                }

                if (__workflow_browserInputPasswordIntoElementonlyElementTopLeftNeedsToBeInBoundingBox != null)
                {
                    if (__workflow_browserInputPasswordIntoElementonlyElementTopLeftNeedsToBeInBoundingBox != null)
                    {
                        browserInputPasswordIntoElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = ExpressionConverter.ConvertO(__workflow_browserInputPasswordIntoElementonlyElementTopLeftNeedsToBeInBoundingBox);
                        browserInputPasswordIntoElementpropCount++;
                    }

                    browserInputPasswordIntoElementpropCount++;
                }
                else
                {
                    browserInputPasswordIntoElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = false;
                    browserInputPasswordIntoElementpropCount++;
                }

                browserInputPasswordIntoElementpropCount++;
                browserInputPasswordIntoElement["PasswordToInput"] = ExpressionConverter.ConvertO(__workflow_browserInputPasswordIntoElementpasswordToInput);
                if (__workflow_browserInputPasswordIntoElementresetExistingValue != null)
                {
                    if (__workflow_browserInputPasswordIntoElementresetExistingValue != null)
                    {
                        browserInputPasswordIntoElement["ResetExistingValue"] = ExpressionConverter.ConvertO(__workflow_browserInputPasswordIntoElementresetExistingValue);
                        browserInputPasswordIntoElementpropCount++;
                    }

                    browserInputPasswordIntoElementpropCount++;
                }
                else
                {
                    browserInputPasswordIntoElement["ResetExistingValue"] = true;
                    browserInputPasswordIntoElementpropCount++;
                }

                if (__workflow_browserInputPasswordIntoElementpasswordContainsStoredPassword != null)
                {
                    if (__workflow_browserInputPasswordIntoElementpasswordContainsStoredPassword != null)
                    {
                        browserInputPasswordIntoElement["PasswordContainsStoredPassword"] = ExpressionConverter.ConvertO(__workflow_browserInputPasswordIntoElementpasswordContainsStoredPassword);
                        browserInputPasswordIntoElementpropCount++;
                    }

                    browserInputPasswordIntoElementpropCount++;
                }
                else
                {
                    browserInputPasswordIntoElement["PasswordContainsStoredPassword"] = false;
                    browserInputPasswordIntoElementpropCount++;
                }

                browserInputPasswordIntoElementpropCount++;
                browserInputPasswordIntoElement["Workflow"] = ExpressionConverter.ConvertO(__workflow_browserInputPasswordIntoElementworkflow);
                if (browserInputPasswordIntoElementpropCount > 0)
                {
                    callPayload.Body = browserInputPasswordIntoElement;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserPasteIntoElement(Expression<Func<string>> browserPasteIntoElementworkflow, Expression<Func<double>> browserPasteIntoElementparentElementHandle = null, Expression<Func<double>> browserPasteIntoElementsearchElementHandle = null, Expression<Func<string>> browserPasteIntoElementsearchElementName = null, Expression<Func<string>> browserPasteIntoElementsearchElementID = null, Expression<Func<string>> browserPasteIntoElementsearchElementTagName = null, Expression<Func<string>> browserPasteIntoElementsearchElementXPath = null, Expression<Func<string>> browserPasteIntoElementsearchElementClassName = null, Expression<Func<string>> browserPasteIntoElementsearchElementCSSSelector = null, Expression<Func<double>> browserPasteIntoElementsearchElementIndex = null, Expression<Func<string>> browserPasteIntoElementsearchElementMatchValue = null, Expression<Func<string>> browserPasteIntoElementsearchElementMatchText = null, Expression<Func<string>> browserPasteIntoElementsearchElementType = null, Expression<Func<double>> browserPasteIntoElementsearchElementMinimumWidth = null, Expression<Func<double>> browserPasteIntoElementsearchElementMinimumHeight = null, Expression<Func<double>> browserPasteIntoElementsearchElementBoundingBoxLeft = null, Expression<Func<double>> browserPasteIntoElementsearchElementBoundingBoxRight = null, Expression<Func<double>> browserPasteIntoElementsearchElementBoundingBoxTop = null, Expression<Func<double>> browserPasteIntoElementsearchElementBoundingBoxBottom = null, Expression<Func<bool>> browserPasteIntoElementonlyElementTopLeftNeedsToBeInBoundingBox = null)
        {
            var __workflow_browserPasteIntoElementworkflow = WorkflowExpression.Compile(browserPasteIntoElementworkflow, nameof(browserPasteIntoElementworkflow), required: true);
            var __workflow_browserPasteIntoElementparentElementHandle = WorkflowExpression.Compile(browserPasteIntoElementparentElementHandle, nameof(browserPasteIntoElementparentElementHandle), required: false);
            var __workflow_browserPasteIntoElementsearchElementHandle = WorkflowExpression.Compile(browserPasteIntoElementsearchElementHandle, nameof(browserPasteIntoElementsearchElementHandle), required: false);
            var __workflow_browserPasteIntoElementsearchElementName = WorkflowExpression.Compile(browserPasteIntoElementsearchElementName, nameof(browserPasteIntoElementsearchElementName), required: false);
            var __workflow_browserPasteIntoElementsearchElementID = WorkflowExpression.Compile(browserPasteIntoElementsearchElementID, nameof(browserPasteIntoElementsearchElementID), required: false);
            var __workflow_browserPasteIntoElementsearchElementTagName = WorkflowExpression.Compile(browserPasteIntoElementsearchElementTagName, nameof(browserPasteIntoElementsearchElementTagName), required: false);
            var __workflow_browserPasteIntoElementsearchElementXPath = WorkflowExpression.Compile(browserPasteIntoElementsearchElementXPath, nameof(browserPasteIntoElementsearchElementXPath), required: false);
            var __workflow_browserPasteIntoElementsearchElementClassName = WorkflowExpression.Compile(browserPasteIntoElementsearchElementClassName, nameof(browserPasteIntoElementsearchElementClassName), required: false);
            var __workflow_browserPasteIntoElementsearchElementCSSSelector = WorkflowExpression.Compile(browserPasteIntoElementsearchElementCSSSelector, nameof(browserPasteIntoElementsearchElementCSSSelector), required: false);
            var __workflow_browserPasteIntoElementsearchElementIndex = WorkflowExpression.Compile(browserPasteIntoElementsearchElementIndex, nameof(browserPasteIntoElementsearchElementIndex), required: false);
            var __workflow_browserPasteIntoElementsearchElementMatchValue = WorkflowExpression.Compile(browserPasteIntoElementsearchElementMatchValue, nameof(browserPasteIntoElementsearchElementMatchValue), required: false);
            var __workflow_browserPasteIntoElementsearchElementMatchText = WorkflowExpression.Compile(browserPasteIntoElementsearchElementMatchText, nameof(browserPasteIntoElementsearchElementMatchText), required: false);
            var __workflow_browserPasteIntoElementsearchElementType = WorkflowExpression.Compile(browserPasteIntoElementsearchElementType, nameof(browserPasteIntoElementsearchElementType), required: false);
            var __workflow_browserPasteIntoElementsearchElementMinimumWidth = WorkflowExpression.Compile(browserPasteIntoElementsearchElementMinimumWidth, nameof(browserPasteIntoElementsearchElementMinimumWidth), required: false);
            var __workflow_browserPasteIntoElementsearchElementMinimumHeight = WorkflowExpression.Compile(browserPasteIntoElementsearchElementMinimumHeight, nameof(browserPasteIntoElementsearchElementMinimumHeight), required: false);
            var __workflow_browserPasteIntoElementsearchElementBoundingBoxLeft = WorkflowExpression.Compile(browserPasteIntoElementsearchElementBoundingBoxLeft, nameof(browserPasteIntoElementsearchElementBoundingBoxLeft), required: false);
            var __workflow_browserPasteIntoElementsearchElementBoundingBoxRight = WorkflowExpression.Compile(browserPasteIntoElementsearchElementBoundingBoxRight, nameof(browserPasteIntoElementsearchElementBoundingBoxRight), required: false);
            var __workflow_browserPasteIntoElementsearchElementBoundingBoxTop = WorkflowExpression.Compile(browserPasteIntoElementsearchElementBoundingBoxTop, nameof(browserPasteIntoElementsearchElementBoundingBoxTop), required: false);
            var __workflow_browserPasteIntoElementsearchElementBoundingBoxBottom = WorkflowExpression.Compile(browserPasteIntoElementsearchElementBoundingBoxBottom, nameof(browserPasteIntoElementsearchElementBoundingBoxBottom), required: false);
            var __workflow_browserPasteIntoElementonlyElementTopLeftNeedsToBeInBoundingBox = WorkflowExpression.Compile(browserPasteIntoElementonlyElementTopLeftNeedsToBeInBoundingBox, nameof(browserPasteIntoElementonlyElementTopLeftNeedsToBeInBoundingBox), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/BrowserControl/PasteIntoElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserPasteIntoElement = new JObject();
                var browserPasteIntoElementpropCount = 0;
                if (__workflow_browserPasteIntoElementparentElementHandle != null)
                {
                    browserPasteIntoElement["ParentElementHandle"] = ExpressionConverter.ConvertO(__workflow_browserPasteIntoElementparentElementHandle);
                    browserPasteIntoElementpropCount++;
                }

                if (__workflow_browserPasteIntoElementsearchElementHandle != null)
                {
                    browserPasteIntoElement["SearchElementHandle"] = ExpressionConverter.ConvertO(__workflow_browserPasteIntoElementsearchElementHandle);
                    browserPasteIntoElementpropCount++;
                }

                if (__workflow_browserPasteIntoElementsearchElementName != null)
                {
                    browserPasteIntoElement["SearchElementName"] = ExpressionConverter.ConvertO(__workflow_browserPasteIntoElementsearchElementName);
                    browserPasteIntoElementpropCount++;
                }

                if (__workflow_browserPasteIntoElementsearchElementID != null)
                {
                    browserPasteIntoElement["SearchElementID"] = ExpressionConverter.ConvertO(__workflow_browserPasteIntoElementsearchElementID);
                    browserPasteIntoElementpropCount++;
                }

                if (__workflow_browserPasteIntoElementsearchElementTagName != null)
                {
                    browserPasteIntoElement["SearchElementTagName"] = ExpressionConverter.ConvertO(__workflow_browserPasteIntoElementsearchElementTagName);
                    browserPasteIntoElementpropCount++;
                }

                if (__workflow_browserPasteIntoElementsearchElementXPath != null)
                {
                    browserPasteIntoElement["SearchElementXPath"] = ExpressionConverter.ConvertO(__workflow_browserPasteIntoElementsearchElementXPath);
                    browserPasteIntoElementpropCount++;
                }

                if (__workflow_browserPasteIntoElementsearchElementClassName != null)
                {
                    browserPasteIntoElement["SearchElementClassName"] = ExpressionConverter.ConvertO(__workflow_browserPasteIntoElementsearchElementClassName);
                    browserPasteIntoElementpropCount++;
                }

                if (__workflow_browserPasteIntoElementsearchElementCSSSelector != null)
                {
                    browserPasteIntoElement["SearchElementCSSSelector"] = ExpressionConverter.ConvertO(__workflow_browserPasteIntoElementsearchElementCSSSelector);
                    browserPasteIntoElementpropCount++;
                }

                if (__workflow_browserPasteIntoElementsearchElementIndex != null)
                {
                    if (__workflow_browserPasteIntoElementsearchElementIndex != null)
                    {
                        browserPasteIntoElement["SearchElementIndex"] = ExpressionConverter.ConvertO(__workflow_browserPasteIntoElementsearchElementIndex);
                        browserPasteIntoElementpropCount++;
                    }

                    browserPasteIntoElementpropCount++;
                }
                else
                {
                    browserPasteIntoElement["SearchElementIndex"] = 1;
                    browserPasteIntoElementpropCount++;
                }

                if (__workflow_browserPasteIntoElementsearchElementMatchValue != null)
                {
                    browserPasteIntoElement["SearchElementMatchValue"] = ExpressionConverter.ConvertO(__workflow_browserPasteIntoElementsearchElementMatchValue);
                    browserPasteIntoElementpropCount++;
                }

                if (__workflow_browserPasteIntoElementsearchElementMatchText != null)
                {
                    browserPasteIntoElement["SearchElementMatchText"] = ExpressionConverter.ConvertO(__workflow_browserPasteIntoElementsearchElementMatchText);
                    browserPasteIntoElementpropCount++;
                }

                if (__workflow_browserPasteIntoElementsearchElementType != null)
                {
                    browserPasteIntoElement["SearchElementType"] = ExpressionConverter.ConvertO(__workflow_browserPasteIntoElementsearchElementType);
                    browserPasteIntoElementpropCount++;
                }

                if (__workflow_browserPasteIntoElementsearchElementMinimumWidth != null)
                {
                    if (__workflow_browserPasteIntoElementsearchElementMinimumWidth != null)
                    {
                        browserPasteIntoElement["SearchElementMinimumWidth"] = ExpressionConverter.ConvertO(__workflow_browserPasteIntoElementsearchElementMinimumWidth);
                        browserPasteIntoElementpropCount++;
                    }

                    browserPasteIntoElementpropCount++;
                }
                else
                {
                    browserPasteIntoElement["SearchElementMinimumWidth"] = 1;
                    browserPasteIntoElementpropCount++;
                }

                if (__workflow_browserPasteIntoElementsearchElementMinimumHeight != null)
                {
                    if (__workflow_browserPasteIntoElementsearchElementMinimumHeight != null)
                    {
                        browserPasteIntoElement["SearchElementMinimumHeight"] = ExpressionConverter.ConvertO(__workflow_browserPasteIntoElementsearchElementMinimumHeight);
                        browserPasteIntoElementpropCount++;
                    }

                    browserPasteIntoElementpropCount++;
                }
                else
                {
                    browserPasteIntoElement["SearchElementMinimumHeight"] = 1;
                    browserPasteIntoElementpropCount++;
                }

                if (__workflow_browserPasteIntoElementsearchElementBoundingBoxLeft != null)
                {
                    if (__workflow_browserPasteIntoElementsearchElementBoundingBoxLeft != null)
                    {
                        browserPasteIntoElement["SearchElementBoundingBoxLeft"] = ExpressionConverter.ConvertO(__workflow_browserPasteIntoElementsearchElementBoundingBoxLeft);
                        browserPasteIntoElementpropCount++;
                    }

                    browserPasteIntoElementpropCount++;
                }
                else
                {
                    browserPasteIntoElement["SearchElementBoundingBoxLeft"] = -99999;
                    browserPasteIntoElementpropCount++;
                }

                if (__workflow_browserPasteIntoElementsearchElementBoundingBoxRight != null)
                {
                    if (__workflow_browserPasteIntoElementsearchElementBoundingBoxRight != null)
                    {
                        browserPasteIntoElement["SearchElementBoundingBoxRight"] = ExpressionConverter.ConvertO(__workflow_browserPasteIntoElementsearchElementBoundingBoxRight);
                        browserPasteIntoElementpropCount++;
                    }

                    browserPasteIntoElementpropCount++;
                }
                else
                {
                    browserPasteIntoElement["SearchElementBoundingBoxRight"] = 99999;
                    browserPasteIntoElementpropCount++;
                }

                if (__workflow_browserPasteIntoElementsearchElementBoundingBoxTop != null)
                {
                    if (__workflow_browserPasteIntoElementsearchElementBoundingBoxTop != null)
                    {
                        browserPasteIntoElement["SearchElementBoundingBoxTop"] = ExpressionConverter.ConvertO(__workflow_browserPasteIntoElementsearchElementBoundingBoxTop);
                        browserPasteIntoElementpropCount++;
                    }

                    browserPasteIntoElementpropCount++;
                }
                else
                {
                    browserPasteIntoElement["SearchElementBoundingBoxTop"] = -99999;
                    browserPasteIntoElementpropCount++;
                }

                if (__workflow_browserPasteIntoElementsearchElementBoundingBoxBottom != null)
                {
                    if (__workflow_browserPasteIntoElementsearchElementBoundingBoxBottom != null)
                    {
                        browserPasteIntoElement["SearchElementBoundingBoxBottom"] = ExpressionConverter.ConvertO(__workflow_browserPasteIntoElementsearchElementBoundingBoxBottom);
                        browserPasteIntoElementpropCount++;
                    }

                    browserPasteIntoElementpropCount++;
                }
                else
                {
                    browserPasteIntoElement["SearchElementBoundingBoxBottom"] = 99999;
                    browserPasteIntoElementpropCount++;
                }

                if (__workflow_browserPasteIntoElementonlyElementTopLeftNeedsToBeInBoundingBox != null)
                {
                    if (__workflow_browserPasteIntoElementonlyElementTopLeftNeedsToBeInBoundingBox != null)
                    {
                        browserPasteIntoElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = ExpressionConverter.ConvertO(__workflow_browserPasteIntoElementonlyElementTopLeftNeedsToBeInBoundingBox);
                        browserPasteIntoElementpropCount++;
                    }

                    browserPasteIntoElementpropCount++;
                }
                else
                {
                    browserPasteIntoElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = false;
                    browserPasteIntoElementpropCount++;
                }

                browserPasteIntoElementpropCount++;
                browserPasteIntoElement["Workflow"] = ExpressionConverter.ConvertO(__workflow_browserPasteIntoElementworkflow);
                if (browserPasteIntoElementpropCount > 0)
                {
                    callPayload.Body = browserPasteIntoElement;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserPrintCurrentPage(Expression<Func<string>> browserPrintCurrentPageworkflow)
        {
            var __workflow_browserPrintCurrentPageworkflow = WorkflowExpression.Compile(browserPrintCurrentPageworkflow, nameof(browserPrintCurrentPageworkflow), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/BrowserControl/PrintCurrentPage";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserPrintCurrentPage = new JObject();
                var browserPrintCurrentPagepropCount = 0;
                browserPrintCurrentPagepropCount++;
                browserPrintCurrentPage["Workflow"] = ExpressionConverter.ConvertO(__workflow_browserPrintCurrentPageworkflow);
                if (browserPrintCurrentPagepropCount > 0)
                {
                    callPayload.Body = browserPrintCurrentPage;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserScrollWindowByPixels(Expression<Func<string>> browserScrollWindowByPixelsworkflow, Expression<Func<double>> browserScrollWindowByPixelsx = null, Expression<Func<double>> browserScrollWindowByPixelsy = null)
        {
            var __workflow_browserScrollWindowByPixelsworkflow = WorkflowExpression.Compile(browserScrollWindowByPixelsworkflow, nameof(browserScrollWindowByPixelsworkflow), required: true);
            var __workflow_browserScrollWindowByPixelsx = WorkflowExpression.Compile(browserScrollWindowByPixelsx, nameof(browserScrollWindowByPixelsx), required: false);
            var __workflow_browserScrollWindowByPixelsy = WorkflowExpression.Compile(browserScrollWindowByPixelsy, nameof(browserScrollWindowByPixelsy), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/BrowserControl/ScrollWindowByPixels";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserScrollWindowByPixels = new JObject();
                var browserScrollWindowByPixelspropCount = 0;
                if (__workflow_browserScrollWindowByPixelsx != null)
                {
                    browserScrollWindowByPixels["X"] = ExpressionConverter.ConvertO(__workflow_browserScrollWindowByPixelsx);
                    browserScrollWindowByPixelspropCount++;
                }

                if (__workflow_browserScrollWindowByPixelsy != null)
                {
                    browserScrollWindowByPixels["Y"] = ExpressionConverter.ConvertO(__workflow_browserScrollWindowByPixelsy);
                    browserScrollWindowByPixelspropCount++;
                }

                browserScrollWindowByPixelspropCount++;
                browserScrollWindowByPixels["Workflow"] = ExpressionConverter.ConvertO(__workflow_browserScrollWindowByPixelsworkflow);
                if (browserScrollWindowByPixelspropCount > 0)
                {
                    callPayload.Body = browserScrollWindowByPixels;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserScrollWindowToPixels(Expression<Func<string>> browserScrollWindowToPixelsworkflow, Expression<Func<double>> browserScrollWindowToPixelsx = null, Expression<Func<double>> browserScrollWindowToPixelsy = null)
        {
            var __workflow_browserScrollWindowToPixelsworkflow = WorkflowExpression.Compile(browserScrollWindowToPixelsworkflow, nameof(browserScrollWindowToPixelsworkflow), required: true);
            var __workflow_browserScrollWindowToPixelsx = WorkflowExpression.Compile(browserScrollWindowToPixelsx, nameof(browserScrollWindowToPixelsx), required: false);
            var __workflow_browserScrollWindowToPixelsy = WorkflowExpression.Compile(browserScrollWindowToPixelsy, nameof(browserScrollWindowToPixelsy), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/BrowserControl/ScrollWindowToPixels";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserScrollWindowToPixels = new JObject();
                var browserScrollWindowToPixelspropCount = 0;
                if (__workflow_browserScrollWindowToPixelsx != null)
                {
                    browserScrollWindowToPixels["X"] = ExpressionConverter.ConvertO(__workflow_browserScrollWindowToPixelsx);
                    browserScrollWindowToPixelspropCount++;
                }

                if (__workflow_browserScrollWindowToPixelsy != null)
                {
                    browserScrollWindowToPixels["Y"] = ExpressionConverter.ConvertO(__workflow_browserScrollWindowToPixelsy);
                    browserScrollWindowToPixelspropCount++;
                }

                browserScrollWindowToPixelspropCount++;
                browserScrollWindowToPixels["Workflow"] = ExpressionConverter.ConvertO(__workflow_browserScrollWindowToPixelsworkflow);
                if (browserScrollWindowToPixelspropCount > 0)
                {
                    callPayload.Body = browserScrollWindowToPixels;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserSelectAllOnElement(Expression<Func<string>> browserSelectAllOnElementworkflow, Expression<Func<double>> browserSelectAllOnElementparentElementHandle = null, Expression<Func<double>> browserSelectAllOnElementsearchElementHandle = null, Expression<Func<string>> browserSelectAllOnElementsearchElementName = null, Expression<Func<string>> browserSelectAllOnElementsearchElementID = null, Expression<Func<string>> browserSelectAllOnElementsearchElementTagName = null, Expression<Func<string>> browserSelectAllOnElementsearchElementXPath = null, Expression<Func<string>> browserSelectAllOnElementsearchElementClassName = null, Expression<Func<string>> browserSelectAllOnElementsearchElementCSSSelector = null, Expression<Func<double>> browserSelectAllOnElementsearchElementIndex = null, Expression<Func<string>> browserSelectAllOnElementsearchElementMatchValue = null, Expression<Func<string>> browserSelectAllOnElementsearchElementMatchText = null, Expression<Func<string>> browserSelectAllOnElementsearchElementType = null, Expression<Func<double>> browserSelectAllOnElementsearchElementMinimumWidth = null, Expression<Func<double>> browserSelectAllOnElementsearchElementMinimumHeight = null, Expression<Func<double>> browserSelectAllOnElementsearchElementBoundingBoxLeft = null, Expression<Func<double>> browserSelectAllOnElementsearchElementBoundingBoxRight = null, Expression<Func<double>> browserSelectAllOnElementsearchElementBoundingBoxTop = null, Expression<Func<double>> browserSelectAllOnElementsearchElementBoundingBoxBottom = null, Expression<Func<bool>> browserSelectAllOnElementonlyElementTopLeftNeedsToBeInBoundingBox = null)
        {
            var __workflow_browserSelectAllOnElementworkflow = WorkflowExpression.Compile(browserSelectAllOnElementworkflow, nameof(browserSelectAllOnElementworkflow), required: true);
            var __workflow_browserSelectAllOnElementparentElementHandle = WorkflowExpression.Compile(browserSelectAllOnElementparentElementHandle, nameof(browserSelectAllOnElementparentElementHandle), required: false);
            var __workflow_browserSelectAllOnElementsearchElementHandle = WorkflowExpression.Compile(browserSelectAllOnElementsearchElementHandle, nameof(browserSelectAllOnElementsearchElementHandle), required: false);
            var __workflow_browserSelectAllOnElementsearchElementName = WorkflowExpression.Compile(browserSelectAllOnElementsearchElementName, nameof(browserSelectAllOnElementsearchElementName), required: false);
            var __workflow_browserSelectAllOnElementsearchElementID = WorkflowExpression.Compile(browserSelectAllOnElementsearchElementID, nameof(browserSelectAllOnElementsearchElementID), required: false);
            var __workflow_browserSelectAllOnElementsearchElementTagName = WorkflowExpression.Compile(browserSelectAllOnElementsearchElementTagName, nameof(browserSelectAllOnElementsearchElementTagName), required: false);
            var __workflow_browserSelectAllOnElementsearchElementXPath = WorkflowExpression.Compile(browserSelectAllOnElementsearchElementXPath, nameof(browserSelectAllOnElementsearchElementXPath), required: false);
            var __workflow_browserSelectAllOnElementsearchElementClassName = WorkflowExpression.Compile(browserSelectAllOnElementsearchElementClassName, nameof(browserSelectAllOnElementsearchElementClassName), required: false);
            var __workflow_browserSelectAllOnElementsearchElementCSSSelector = WorkflowExpression.Compile(browserSelectAllOnElementsearchElementCSSSelector, nameof(browserSelectAllOnElementsearchElementCSSSelector), required: false);
            var __workflow_browserSelectAllOnElementsearchElementIndex = WorkflowExpression.Compile(browserSelectAllOnElementsearchElementIndex, nameof(browserSelectAllOnElementsearchElementIndex), required: false);
            var __workflow_browserSelectAllOnElementsearchElementMatchValue = WorkflowExpression.Compile(browserSelectAllOnElementsearchElementMatchValue, nameof(browserSelectAllOnElementsearchElementMatchValue), required: false);
            var __workflow_browserSelectAllOnElementsearchElementMatchText = WorkflowExpression.Compile(browserSelectAllOnElementsearchElementMatchText, nameof(browserSelectAllOnElementsearchElementMatchText), required: false);
            var __workflow_browserSelectAllOnElementsearchElementType = WorkflowExpression.Compile(browserSelectAllOnElementsearchElementType, nameof(browserSelectAllOnElementsearchElementType), required: false);
            var __workflow_browserSelectAllOnElementsearchElementMinimumWidth = WorkflowExpression.Compile(browserSelectAllOnElementsearchElementMinimumWidth, nameof(browserSelectAllOnElementsearchElementMinimumWidth), required: false);
            var __workflow_browserSelectAllOnElementsearchElementMinimumHeight = WorkflowExpression.Compile(browserSelectAllOnElementsearchElementMinimumHeight, nameof(browserSelectAllOnElementsearchElementMinimumHeight), required: false);
            var __workflow_browserSelectAllOnElementsearchElementBoundingBoxLeft = WorkflowExpression.Compile(browserSelectAllOnElementsearchElementBoundingBoxLeft, nameof(browserSelectAllOnElementsearchElementBoundingBoxLeft), required: false);
            var __workflow_browserSelectAllOnElementsearchElementBoundingBoxRight = WorkflowExpression.Compile(browserSelectAllOnElementsearchElementBoundingBoxRight, nameof(browserSelectAllOnElementsearchElementBoundingBoxRight), required: false);
            var __workflow_browserSelectAllOnElementsearchElementBoundingBoxTop = WorkflowExpression.Compile(browserSelectAllOnElementsearchElementBoundingBoxTop, nameof(browserSelectAllOnElementsearchElementBoundingBoxTop), required: false);
            var __workflow_browserSelectAllOnElementsearchElementBoundingBoxBottom = WorkflowExpression.Compile(browserSelectAllOnElementsearchElementBoundingBoxBottom, nameof(browserSelectAllOnElementsearchElementBoundingBoxBottom), required: false);
            var __workflow_browserSelectAllOnElementonlyElementTopLeftNeedsToBeInBoundingBox = WorkflowExpression.Compile(browserSelectAllOnElementonlyElementTopLeftNeedsToBeInBoundingBox, nameof(browserSelectAllOnElementonlyElementTopLeftNeedsToBeInBoundingBox), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/BrowserControl/SelectAllOnElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserSelectAllOnElement = new JObject();
                var browserSelectAllOnElementpropCount = 0;
                if (__workflow_browserSelectAllOnElementparentElementHandle != null)
                {
                    browserSelectAllOnElement["ParentElementHandle"] = ExpressionConverter.ConvertO(__workflow_browserSelectAllOnElementparentElementHandle);
                    browserSelectAllOnElementpropCount++;
                }

                if (__workflow_browserSelectAllOnElementsearchElementHandle != null)
                {
                    browserSelectAllOnElement["SearchElementHandle"] = ExpressionConverter.ConvertO(__workflow_browserSelectAllOnElementsearchElementHandle);
                    browserSelectAllOnElementpropCount++;
                }

                if (__workflow_browserSelectAllOnElementsearchElementName != null)
                {
                    browserSelectAllOnElement["SearchElementName"] = ExpressionConverter.ConvertO(__workflow_browserSelectAllOnElementsearchElementName);
                    browserSelectAllOnElementpropCount++;
                }

                if (__workflow_browserSelectAllOnElementsearchElementID != null)
                {
                    browserSelectAllOnElement["SearchElementID"] = ExpressionConverter.ConvertO(__workflow_browserSelectAllOnElementsearchElementID);
                    browserSelectAllOnElementpropCount++;
                }

                if (__workflow_browserSelectAllOnElementsearchElementTagName != null)
                {
                    browserSelectAllOnElement["SearchElementTagName"] = ExpressionConverter.ConvertO(__workflow_browserSelectAllOnElementsearchElementTagName);
                    browserSelectAllOnElementpropCount++;
                }

                if (__workflow_browserSelectAllOnElementsearchElementXPath != null)
                {
                    browserSelectAllOnElement["SearchElementXPath"] = ExpressionConverter.ConvertO(__workflow_browserSelectAllOnElementsearchElementXPath);
                    browserSelectAllOnElementpropCount++;
                }

                if (__workflow_browserSelectAllOnElementsearchElementClassName != null)
                {
                    browserSelectAllOnElement["SearchElementClassName"] = ExpressionConverter.ConvertO(__workflow_browserSelectAllOnElementsearchElementClassName);
                    browserSelectAllOnElementpropCount++;
                }

                if (__workflow_browserSelectAllOnElementsearchElementCSSSelector != null)
                {
                    browserSelectAllOnElement["SearchElementCSSSelector"] = ExpressionConverter.ConvertO(__workflow_browserSelectAllOnElementsearchElementCSSSelector);
                    browserSelectAllOnElementpropCount++;
                }

                if (__workflow_browserSelectAllOnElementsearchElementIndex != null)
                {
                    if (__workflow_browserSelectAllOnElementsearchElementIndex != null)
                    {
                        browserSelectAllOnElement["SearchElementIndex"] = ExpressionConverter.ConvertO(__workflow_browserSelectAllOnElementsearchElementIndex);
                        browserSelectAllOnElementpropCount++;
                    }

                    browserSelectAllOnElementpropCount++;
                }
                else
                {
                    browserSelectAllOnElement["SearchElementIndex"] = 1;
                    browserSelectAllOnElementpropCount++;
                }

                if (__workflow_browserSelectAllOnElementsearchElementMatchValue != null)
                {
                    browserSelectAllOnElement["SearchElementMatchValue"] = ExpressionConverter.ConvertO(__workflow_browserSelectAllOnElementsearchElementMatchValue);
                    browserSelectAllOnElementpropCount++;
                }

                if (__workflow_browserSelectAllOnElementsearchElementMatchText != null)
                {
                    browserSelectAllOnElement["SearchElementMatchText"] = ExpressionConverter.ConvertO(__workflow_browserSelectAllOnElementsearchElementMatchText);
                    browserSelectAllOnElementpropCount++;
                }

                if (__workflow_browserSelectAllOnElementsearchElementType != null)
                {
                    browserSelectAllOnElement["SearchElementType"] = ExpressionConverter.ConvertO(__workflow_browserSelectAllOnElementsearchElementType);
                    browserSelectAllOnElementpropCount++;
                }

                if (__workflow_browserSelectAllOnElementsearchElementMinimumWidth != null)
                {
                    if (__workflow_browserSelectAllOnElementsearchElementMinimumWidth != null)
                    {
                        browserSelectAllOnElement["SearchElementMinimumWidth"] = ExpressionConverter.ConvertO(__workflow_browserSelectAllOnElementsearchElementMinimumWidth);
                        browserSelectAllOnElementpropCount++;
                    }

                    browserSelectAllOnElementpropCount++;
                }
                else
                {
                    browserSelectAllOnElement["SearchElementMinimumWidth"] = 1;
                    browserSelectAllOnElementpropCount++;
                }

                if (__workflow_browserSelectAllOnElementsearchElementMinimumHeight != null)
                {
                    if (__workflow_browserSelectAllOnElementsearchElementMinimumHeight != null)
                    {
                        browserSelectAllOnElement["SearchElementMinimumHeight"] = ExpressionConverter.ConvertO(__workflow_browserSelectAllOnElementsearchElementMinimumHeight);
                        browserSelectAllOnElementpropCount++;
                    }

                    browserSelectAllOnElementpropCount++;
                }
                else
                {
                    browserSelectAllOnElement["SearchElementMinimumHeight"] = 1;
                    browserSelectAllOnElementpropCount++;
                }

                if (__workflow_browserSelectAllOnElementsearchElementBoundingBoxLeft != null)
                {
                    if (__workflow_browserSelectAllOnElementsearchElementBoundingBoxLeft != null)
                    {
                        browserSelectAllOnElement["SearchElementBoundingBoxLeft"] = ExpressionConverter.ConvertO(__workflow_browserSelectAllOnElementsearchElementBoundingBoxLeft);
                        browserSelectAllOnElementpropCount++;
                    }

                    browserSelectAllOnElementpropCount++;
                }
                else
                {
                    browserSelectAllOnElement["SearchElementBoundingBoxLeft"] = -99999;
                    browserSelectAllOnElementpropCount++;
                }

                if (__workflow_browserSelectAllOnElementsearchElementBoundingBoxRight != null)
                {
                    if (__workflow_browserSelectAllOnElementsearchElementBoundingBoxRight != null)
                    {
                        browserSelectAllOnElement["SearchElementBoundingBoxRight"] = ExpressionConverter.ConvertO(__workflow_browserSelectAllOnElementsearchElementBoundingBoxRight);
                        browserSelectAllOnElementpropCount++;
                    }

                    browserSelectAllOnElementpropCount++;
                }
                else
                {
                    browserSelectAllOnElement["SearchElementBoundingBoxRight"] = 99999;
                    browserSelectAllOnElementpropCount++;
                }

                if (__workflow_browserSelectAllOnElementsearchElementBoundingBoxTop != null)
                {
                    if (__workflow_browserSelectAllOnElementsearchElementBoundingBoxTop != null)
                    {
                        browserSelectAllOnElement["SearchElementBoundingBoxTop"] = ExpressionConverter.ConvertO(__workflow_browserSelectAllOnElementsearchElementBoundingBoxTop);
                        browserSelectAllOnElementpropCount++;
                    }

                    browserSelectAllOnElementpropCount++;
                }
                else
                {
                    browserSelectAllOnElement["SearchElementBoundingBoxTop"] = -99999;
                    browserSelectAllOnElementpropCount++;
                }

                if (__workflow_browserSelectAllOnElementsearchElementBoundingBoxBottom != null)
                {
                    if (__workflow_browserSelectAllOnElementsearchElementBoundingBoxBottom != null)
                    {
                        browserSelectAllOnElement["SearchElementBoundingBoxBottom"] = ExpressionConverter.ConvertO(__workflow_browserSelectAllOnElementsearchElementBoundingBoxBottom);
                        browserSelectAllOnElementpropCount++;
                    }

                    browserSelectAllOnElementpropCount++;
                }
                else
                {
                    browserSelectAllOnElement["SearchElementBoundingBoxBottom"] = 99999;
                    browserSelectAllOnElementpropCount++;
                }

                if (__workflow_browserSelectAllOnElementonlyElementTopLeftNeedsToBeInBoundingBox != null)
                {
                    if (__workflow_browserSelectAllOnElementonlyElementTopLeftNeedsToBeInBoundingBox != null)
                    {
                        browserSelectAllOnElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = ExpressionConverter.ConvertO(__workflow_browserSelectAllOnElementonlyElementTopLeftNeedsToBeInBoundingBox);
                        browserSelectAllOnElementpropCount++;
                    }

                    browserSelectAllOnElementpropCount++;
                }
                else
                {
                    browserSelectAllOnElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = false;
                    browserSelectAllOnElementpropCount++;
                }

                browserSelectAllOnElementpropCount++;
                browserSelectAllOnElement["Workflow"] = ExpressionConverter.ConvertO(__workflow_browserSelectAllOnElementworkflow);
                if (browserSelectAllOnElementpropCount > 0)
                {
                    callPayload.Body = browserSelectAllOnElement;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserWaitForElementToExistResponse> BrowserWaitForElementToExist(Expression<Func<int>> browserWaitForElementToExistsecondsToWait, Expression<Func<string>> browserWaitForElementToExistworkflow, Expression<Func<double>> browserWaitForElementToExistparentElementHandle = null, Expression<Func<string>> browserWaitForElementToExistsearchElementName = null, Expression<Func<string>> browserWaitForElementToExistsearchElementID = null, Expression<Func<string>> browserWaitForElementToExistsearchElementTagName = null, Expression<Func<string>> browserWaitForElementToExistsearchElementXPath = null, Expression<Func<string>> browserWaitForElementToExistsearchElementClassName = null, Expression<Func<string>> browserWaitForElementToExistsearchElementCSSSelector = null, Expression<Func<double>> browserWaitForElementToExistsearchElementIndex = null, Expression<Func<string>> browserWaitForElementToExistsearchElementMatchValue = null, Expression<Func<string>> browserWaitForElementToExistsearchElementMatchText = null, Expression<Func<string>> browserWaitForElementToExistsearchElementType = null, Expression<Func<double>> browserWaitForElementToExistsearchElementMinimumWidth = null, Expression<Func<double>> browserWaitForElementToExistsearchElementMinimumHeight = null, Expression<Func<double>> browserWaitForElementToExistsearchElementBoundingBoxLeft = null, Expression<Func<double>> browserWaitForElementToExistsearchElementBoundingBoxRight = null, Expression<Func<double>> browserWaitForElementToExistsearchElementBoundingBoxTop = null, Expression<Func<double>> browserWaitForElementToExistsearchElementBoundingBoxBottom = null, Expression<Func<bool>> browserWaitForElementToExistonlyElementTopLeftNeedsToBeInBoundingBox = null, Expression<Func<bool>> browserWaitForElementToExistraiseExceptionIfElementNotFound = null, Expression<Func<bool>> browserWaitForElementToExistuseExplicitWaitConditionsIfPossible = null, Expression<Func<bool>> browserWaitForElementToExistwaitForSearchElementToBeDisplayed = null)
        {
            var __workflow_browserWaitForElementToExistsecondsToWait = WorkflowExpression.Compile(browserWaitForElementToExistsecondsToWait, nameof(browserWaitForElementToExistsecondsToWait), required: true);
            var __workflow_browserWaitForElementToExistworkflow = WorkflowExpression.Compile(browserWaitForElementToExistworkflow, nameof(browserWaitForElementToExistworkflow), required: true);
            var __workflow_browserWaitForElementToExistparentElementHandle = WorkflowExpression.Compile(browserWaitForElementToExistparentElementHandle, nameof(browserWaitForElementToExistparentElementHandle), required: false);
            var __workflow_browserWaitForElementToExistsearchElementName = WorkflowExpression.Compile(browserWaitForElementToExistsearchElementName, nameof(browserWaitForElementToExistsearchElementName), required: false);
            var __workflow_browserWaitForElementToExistsearchElementID = WorkflowExpression.Compile(browserWaitForElementToExistsearchElementID, nameof(browserWaitForElementToExistsearchElementID), required: false);
            var __workflow_browserWaitForElementToExistsearchElementTagName = WorkflowExpression.Compile(browserWaitForElementToExistsearchElementTagName, nameof(browserWaitForElementToExistsearchElementTagName), required: false);
            var __workflow_browserWaitForElementToExistsearchElementXPath = WorkflowExpression.Compile(browserWaitForElementToExistsearchElementXPath, nameof(browserWaitForElementToExistsearchElementXPath), required: false);
            var __workflow_browserWaitForElementToExistsearchElementClassName = WorkflowExpression.Compile(browserWaitForElementToExistsearchElementClassName, nameof(browserWaitForElementToExistsearchElementClassName), required: false);
            var __workflow_browserWaitForElementToExistsearchElementCSSSelector = WorkflowExpression.Compile(browserWaitForElementToExistsearchElementCSSSelector, nameof(browserWaitForElementToExistsearchElementCSSSelector), required: false);
            var __workflow_browserWaitForElementToExistsearchElementIndex = WorkflowExpression.Compile(browserWaitForElementToExistsearchElementIndex, nameof(browserWaitForElementToExistsearchElementIndex), required: false);
            var __workflow_browserWaitForElementToExistsearchElementMatchValue = WorkflowExpression.Compile(browserWaitForElementToExistsearchElementMatchValue, nameof(browserWaitForElementToExistsearchElementMatchValue), required: false);
            var __workflow_browserWaitForElementToExistsearchElementMatchText = WorkflowExpression.Compile(browserWaitForElementToExistsearchElementMatchText, nameof(browserWaitForElementToExistsearchElementMatchText), required: false);
            var __workflow_browserWaitForElementToExistsearchElementType = WorkflowExpression.Compile(browserWaitForElementToExistsearchElementType, nameof(browserWaitForElementToExistsearchElementType), required: false);
            var __workflow_browserWaitForElementToExistsearchElementMinimumWidth = WorkflowExpression.Compile(browserWaitForElementToExistsearchElementMinimumWidth, nameof(browserWaitForElementToExistsearchElementMinimumWidth), required: false);
            var __workflow_browserWaitForElementToExistsearchElementMinimumHeight = WorkflowExpression.Compile(browserWaitForElementToExistsearchElementMinimumHeight, nameof(browserWaitForElementToExistsearchElementMinimumHeight), required: false);
            var __workflow_browserWaitForElementToExistsearchElementBoundingBoxLeft = WorkflowExpression.Compile(browserWaitForElementToExistsearchElementBoundingBoxLeft, nameof(browserWaitForElementToExistsearchElementBoundingBoxLeft), required: false);
            var __workflow_browserWaitForElementToExistsearchElementBoundingBoxRight = WorkflowExpression.Compile(browserWaitForElementToExistsearchElementBoundingBoxRight, nameof(browserWaitForElementToExistsearchElementBoundingBoxRight), required: false);
            var __workflow_browserWaitForElementToExistsearchElementBoundingBoxTop = WorkflowExpression.Compile(browserWaitForElementToExistsearchElementBoundingBoxTop, nameof(browserWaitForElementToExistsearchElementBoundingBoxTop), required: false);
            var __workflow_browserWaitForElementToExistsearchElementBoundingBoxBottom = WorkflowExpression.Compile(browserWaitForElementToExistsearchElementBoundingBoxBottom, nameof(browserWaitForElementToExistsearchElementBoundingBoxBottom), required: false);
            var __workflow_browserWaitForElementToExistonlyElementTopLeftNeedsToBeInBoundingBox = WorkflowExpression.Compile(browserWaitForElementToExistonlyElementTopLeftNeedsToBeInBoundingBox, nameof(browserWaitForElementToExistonlyElementTopLeftNeedsToBeInBoundingBox), required: false);
            var __workflow_browserWaitForElementToExistraiseExceptionIfElementNotFound = WorkflowExpression.Compile(browserWaitForElementToExistraiseExceptionIfElementNotFound, nameof(browserWaitForElementToExistraiseExceptionIfElementNotFound), required: false);
            var __workflow_browserWaitForElementToExistuseExplicitWaitConditionsIfPossible = WorkflowExpression.Compile(browserWaitForElementToExistuseExplicitWaitConditionsIfPossible, nameof(browserWaitForElementToExistuseExplicitWaitConditionsIfPossible), required: false);
            var __workflow_browserWaitForElementToExistwaitForSearchElementToBeDisplayed = WorkflowExpression.Compile(browserWaitForElementToExistwaitForSearchElementToBeDisplayed, nameof(browserWaitForElementToExistwaitForSearchElementToBeDisplayed), required: false);
            return new DeferredBodyAction<BrowserWaitForElementToExistResponse>(() =>
            {
                var apiCallPath = "/BrowserControl/WaitForElementToExist";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserWaitForElementToExist = new JObject();
                var browserWaitForElementToExistpropCount = 0;
                if (__workflow_browserWaitForElementToExistparentElementHandle != null)
                {
                    browserWaitForElementToExist["ParentElementHandle"] = ExpressionConverter.ConvertO(__workflow_browserWaitForElementToExistparentElementHandle);
                    browserWaitForElementToExistpropCount++;
                }

                if (__workflow_browserWaitForElementToExistsearchElementName != null)
                {
                    browserWaitForElementToExist["SearchElementName"] = ExpressionConverter.ConvertO(__workflow_browserWaitForElementToExistsearchElementName);
                    browserWaitForElementToExistpropCount++;
                }

                if (__workflow_browserWaitForElementToExistsearchElementID != null)
                {
                    browserWaitForElementToExist["SearchElementID"] = ExpressionConverter.ConvertO(__workflow_browserWaitForElementToExistsearchElementID);
                    browserWaitForElementToExistpropCount++;
                }

                if (__workflow_browserWaitForElementToExistsearchElementTagName != null)
                {
                    browserWaitForElementToExist["SearchElementTagName"] = ExpressionConverter.ConvertO(__workflow_browserWaitForElementToExistsearchElementTagName);
                    browserWaitForElementToExistpropCount++;
                }

                if (__workflow_browserWaitForElementToExistsearchElementXPath != null)
                {
                    browserWaitForElementToExist["SearchElementXPath"] = ExpressionConverter.ConvertO(__workflow_browserWaitForElementToExistsearchElementXPath);
                    browserWaitForElementToExistpropCount++;
                }

                if (__workflow_browserWaitForElementToExistsearchElementClassName != null)
                {
                    browserWaitForElementToExist["SearchElementClassName"] = ExpressionConverter.ConvertO(__workflow_browserWaitForElementToExistsearchElementClassName);
                    browserWaitForElementToExistpropCount++;
                }

                if (__workflow_browserWaitForElementToExistsearchElementCSSSelector != null)
                {
                    browserWaitForElementToExist["SearchElementCSSSelector"] = ExpressionConverter.ConvertO(__workflow_browserWaitForElementToExistsearchElementCSSSelector);
                    browserWaitForElementToExistpropCount++;
                }

                if (__workflow_browserWaitForElementToExistsearchElementIndex != null)
                {
                    if (__workflow_browserWaitForElementToExistsearchElementIndex != null)
                    {
                        browserWaitForElementToExist["SearchElementIndex"] = ExpressionConverter.ConvertO(__workflow_browserWaitForElementToExistsearchElementIndex);
                        browserWaitForElementToExistpropCount++;
                    }

                    browserWaitForElementToExistpropCount++;
                }
                else
                {
                    browserWaitForElementToExist["SearchElementIndex"] = 1;
                    browserWaitForElementToExistpropCount++;
                }

                if (__workflow_browserWaitForElementToExistsearchElementMatchValue != null)
                {
                    browserWaitForElementToExist["SearchElementMatchValue"] = ExpressionConverter.ConvertO(__workflow_browserWaitForElementToExistsearchElementMatchValue);
                    browserWaitForElementToExistpropCount++;
                }

                if (__workflow_browserWaitForElementToExistsearchElementMatchText != null)
                {
                    browserWaitForElementToExist["SearchElementMatchText"] = ExpressionConverter.ConvertO(__workflow_browserWaitForElementToExistsearchElementMatchText);
                    browserWaitForElementToExistpropCount++;
                }

                if (__workflow_browserWaitForElementToExistsearchElementType != null)
                {
                    browserWaitForElementToExist["SearchElementType"] = ExpressionConverter.ConvertO(__workflow_browserWaitForElementToExistsearchElementType);
                    browserWaitForElementToExistpropCount++;
                }

                if (__workflow_browserWaitForElementToExistsearchElementMinimumWidth != null)
                {
                    if (__workflow_browserWaitForElementToExistsearchElementMinimumWidth != null)
                    {
                        browserWaitForElementToExist["SearchElementMinimumWidth"] = ExpressionConverter.ConvertO(__workflow_browserWaitForElementToExistsearchElementMinimumWidth);
                        browserWaitForElementToExistpropCount++;
                    }

                    browserWaitForElementToExistpropCount++;
                }
                else
                {
                    browserWaitForElementToExist["SearchElementMinimumWidth"] = 1;
                    browserWaitForElementToExistpropCount++;
                }

                if (__workflow_browserWaitForElementToExistsearchElementMinimumHeight != null)
                {
                    if (__workflow_browserWaitForElementToExistsearchElementMinimumHeight != null)
                    {
                        browserWaitForElementToExist["SearchElementMinimumHeight"] = ExpressionConverter.ConvertO(__workflow_browserWaitForElementToExistsearchElementMinimumHeight);
                        browserWaitForElementToExistpropCount++;
                    }

                    browserWaitForElementToExistpropCount++;
                }
                else
                {
                    browserWaitForElementToExist["SearchElementMinimumHeight"] = 1;
                    browserWaitForElementToExistpropCount++;
                }

                if (__workflow_browserWaitForElementToExistsearchElementBoundingBoxLeft != null)
                {
                    if (__workflow_browserWaitForElementToExistsearchElementBoundingBoxLeft != null)
                    {
                        browserWaitForElementToExist["SearchElementBoundingBoxLeft"] = ExpressionConverter.ConvertO(__workflow_browserWaitForElementToExistsearchElementBoundingBoxLeft);
                        browserWaitForElementToExistpropCount++;
                    }

                    browserWaitForElementToExistpropCount++;
                }
                else
                {
                    browserWaitForElementToExist["SearchElementBoundingBoxLeft"] = -99999;
                    browserWaitForElementToExistpropCount++;
                }

                if (__workflow_browserWaitForElementToExistsearchElementBoundingBoxRight != null)
                {
                    if (__workflow_browserWaitForElementToExistsearchElementBoundingBoxRight != null)
                    {
                        browserWaitForElementToExist["SearchElementBoundingBoxRight"] = ExpressionConverter.ConvertO(__workflow_browserWaitForElementToExistsearchElementBoundingBoxRight);
                        browserWaitForElementToExistpropCount++;
                    }

                    browserWaitForElementToExistpropCount++;
                }
                else
                {
                    browserWaitForElementToExist["SearchElementBoundingBoxRight"] = 99999;
                    browserWaitForElementToExistpropCount++;
                }

                if (__workflow_browserWaitForElementToExistsearchElementBoundingBoxTop != null)
                {
                    if (__workflow_browserWaitForElementToExistsearchElementBoundingBoxTop != null)
                    {
                        browserWaitForElementToExist["SearchElementBoundingBoxTop"] = ExpressionConverter.ConvertO(__workflow_browserWaitForElementToExistsearchElementBoundingBoxTop);
                        browserWaitForElementToExistpropCount++;
                    }

                    browserWaitForElementToExistpropCount++;
                }
                else
                {
                    browserWaitForElementToExist["SearchElementBoundingBoxTop"] = -99999;
                    browserWaitForElementToExistpropCount++;
                }

                if (__workflow_browserWaitForElementToExistsearchElementBoundingBoxBottom != null)
                {
                    if (__workflow_browserWaitForElementToExistsearchElementBoundingBoxBottom != null)
                    {
                        browserWaitForElementToExist["SearchElementBoundingBoxBottom"] = ExpressionConverter.ConvertO(__workflow_browserWaitForElementToExistsearchElementBoundingBoxBottom);
                        browserWaitForElementToExistpropCount++;
                    }

                    browserWaitForElementToExistpropCount++;
                }
                else
                {
                    browserWaitForElementToExist["SearchElementBoundingBoxBottom"] = 99999;
                    browserWaitForElementToExistpropCount++;
                }

                if (__workflow_browserWaitForElementToExistonlyElementTopLeftNeedsToBeInBoundingBox != null)
                {
                    if (__workflow_browserWaitForElementToExistonlyElementTopLeftNeedsToBeInBoundingBox != null)
                    {
                        browserWaitForElementToExist["OnlyElementTopLeftNeedsToBeInBoundingBox"] = ExpressionConverter.ConvertO(__workflow_browserWaitForElementToExistonlyElementTopLeftNeedsToBeInBoundingBox);
                        browserWaitForElementToExistpropCount++;
                    }

                    browserWaitForElementToExistpropCount++;
                }
                else
                {
                    browserWaitForElementToExist["OnlyElementTopLeftNeedsToBeInBoundingBox"] = false;
                    browserWaitForElementToExistpropCount++;
                }

                browserWaitForElementToExistpropCount++;
                browserWaitForElementToExist["SecondsToWait"] = ExpressionConverter.ConvertO(__workflow_browserWaitForElementToExistsecondsToWait);
                if (__workflow_browserWaitForElementToExistraiseExceptionIfElementNotFound != null)
                {
                    if (__workflow_browserWaitForElementToExistraiseExceptionIfElementNotFound != null)
                    {
                        browserWaitForElementToExist["RaiseExceptionIfElementNotFound"] = ExpressionConverter.ConvertO(__workflow_browserWaitForElementToExistraiseExceptionIfElementNotFound);
                        browserWaitForElementToExistpropCount++;
                    }

                    browserWaitForElementToExistpropCount++;
                }
                else
                {
                    browserWaitForElementToExist["RaiseExceptionIfElementNotFound"] = false;
                    browserWaitForElementToExistpropCount++;
                }

                if (__workflow_browserWaitForElementToExistuseExplicitWaitConditionsIfPossible != null)
                {
                    if (__workflow_browserWaitForElementToExistuseExplicitWaitConditionsIfPossible != null)
                    {
                        browserWaitForElementToExist["UseExplicitWaitConditionsIfPossible"] = ExpressionConverter.ConvertO(__workflow_browserWaitForElementToExistuseExplicitWaitConditionsIfPossible);
                        browserWaitForElementToExistpropCount++;
                    }

                    browserWaitForElementToExistpropCount++;
                }
                else
                {
                    browserWaitForElementToExist["UseExplicitWaitConditionsIfPossible"] = true;
                    browserWaitForElementToExistpropCount++;
                }

                if (__workflow_browserWaitForElementToExistwaitForSearchElementToBeDisplayed != null)
                {
                    if (__workflow_browserWaitForElementToExistwaitForSearchElementToBeDisplayed != null)
                    {
                        browserWaitForElementToExist["WaitForSearchElementToBeDisplayed"] = ExpressionConverter.ConvertO(__workflow_browserWaitForElementToExistwaitForSearchElementToBeDisplayed);
                        browserWaitForElementToExistpropCount++;
                    }

                    browserWaitForElementToExistpropCount++;
                }
                else
                {
                    browserWaitForElementToExist["WaitForSearchElementToBeDisplayed"] = false;
                    browserWaitForElementToExistpropCount++;
                }

                browserWaitForElementToExistpropCount++;
                browserWaitForElementToExist["Workflow"] = ExpressionConverter.ConvertO(__workflow_browserWaitForElementToExistworkflow);
                if (browserWaitForElementToExistpropCount > 0)
                {
                    callPayload.Body = browserWaitForElementToExist;
                }

                return new ApiConnectionAction<BrowserWaitForElementToExistResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserWaitForElementToNotExistResponse> BrowserWaitForElementToNotExist(Expression<Func<int>> browserWaitForElementToNotExistsecondsToWait, Expression<Func<string>> browserWaitForElementToNotExistworkflow, Expression<Func<double>> browserWaitForElementToNotExistparentElementHandle = null, Expression<Func<double>> browserWaitForElementToNotExistsearchElementHandle = null, Expression<Func<string>> browserWaitForElementToNotExistsearchElementName = null, Expression<Func<string>> browserWaitForElementToNotExistsearchElementID = null, Expression<Func<string>> browserWaitForElementToNotExistsearchElementTagName = null, Expression<Func<string>> browserWaitForElementToNotExistsearchElementXPath = null, Expression<Func<string>> browserWaitForElementToNotExistsearchElementClassName = null, Expression<Func<string>> browserWaitForElementToNotExistsearchElementCSSSelector = null, Expression<Func<double>> browserWaitForElementToNotExistsearchElementIndex = null, Expression<Func<string>> browserWaitForElementToNotExistsearchElementMatchValue = null, Expression<Func<string>> browserWaitForElementToNotExistsearchElementMatchText = null, Expression<Func<string>> browserWaitForElementToNotExistsearchElementType = null, Expression<Func<double>> browserWaitForElementToNotExistsearchElementMinimumWidth = null, Expression<Func<double>> browserWaitForElementToNotExistsearchElementMinimumHeight = null, Expression<Func<double>> browserWaitForElementToNotExistsearchElementBoundingBoxLeft = null, Expression<Func<double>> browserWaitForElementToNotExistsearchElementBoundingBoxRight = null, Expression<Func<double>> browserWaitForElementToNotExistsearchElementBoundingBoxTop = null, Expression<Func<double>> browserWaitForElementToNotExistsearchElementBoundingBoxBottom = null, Expression<Func<bool>> browserWaitForElementToNotExistonlyElementTopLeftNeedsToBeInBoundingBox = null, Expression<Func<bool>> browserWaitForElementToNotExistraiseExceptionIfElementStillExists = null, Expression<Func<bool>> browserWaitForElementToNotExistsearchElementMustBeDisplayed = null)
        {
            var __workflow_browserWaitForElementToNotExistsecondsToWait = WorkflowExpression.Compile(browserWaitForElementToNotExistsecondsToWait, nameof(browserWaitForElementToNotExistsecondsToWait), required: true);
            var __workflow_browserWaitForElementToNotExistworkflow = WorkflowExpression.Compile(browserWaitForElementToNotExistworkflow, nameof(browserWaitForElementToNotExistworkflow), required: true);
            var __workflow_browserWaitForElementToNotExistparentElementHandle = WorkflowExpression.Compile(browserWaitForElementToNotExistparentElementHandle, nameof(browserWaitForElementToNotExistparentElementHandle), required: false);
            var __workflow_browserWaitForElementToNotExistsearchElementHandle = WorkflowExpression.Compile(browserWaitForElementToNotExistsearchElementHandle, nameof(browserWaitForElementToNotExistsearchElementHandle), required: false);
            var __workflow_browserWaitForElementToNotExistsearchElementName = WorkflowExpression.Compile(browserWaitForElementToNotExistsearchElementName, nameof(browserWaitForElementToNotExistsearchElementName), required: false);
            var __workflow_browserWaitForElementToNotExistsearchElementID = WorkflowExpression.Compile(browserWaitForElementToNotExistsearchElementID, nameof(browserWaitForElementToNotExistsearchElementID), required: false);
            var __workflow_browserWaitForElementToNotExistsearchElementTagName = WorkflowExpression.Compile(browserWaitForElementToNotExistsearchElementTagName, nameof(browserWaitForElementToNotExistsearchElementTagName), required: false);
            var __workflow_browserWaitForElementToNotExistsearchElementXPath = WorkflowExpression.Compile(browserWaitForElementToNotExistsearchElementXPath, nameof(browserWaitForElementToNotExistsearchElementXPath), required: false);
            var __workflow_browserWaitForElementToNotExistsearchElementClassName = WorkflowExpression.Compile(browserWaitForElementToNotExistsearchElementClassName, nameof(browserWaitForElementToNotExistsearchElementClassName), required: false);
            var __workflow_browserWaitForElementToNotExistsearchElementCSSSelector = WorkflowExpression.Compile(browserWaitForElementToNotExistsearchElementCSSSelector, nameof(browserWaitForElementToNotExistsearchElementCSSSelector), required: false);
            var __workflow_browserWaitForElementToNotExistsearchElementIndex = WorkflowExpression.Compile(browserWaitForElementToNotExistsearchElementIndex, nameof(browserWaitForElementToNotExistsearchElementIndex), required: false);
            var __workflow_browserWaitForElementToNotExistsearchElementMatchValue = WorkflowExpression.Compile(browserWaitForElementToNotExistsearchElementMatchValue, nameof(browserWaitForElementToNotExistsearchElementMatchValue), required: false);
            var __workflow_browserWaitForElementToNotExistsearchElementMatchText = WorkflowExpression.Compile(browserWaitForElementToNotExistsearchElementMatchText, nameof(browserWaitForElementToNotExistsearchElementMatchText), required: false);
            var __workflow_browserWaitForElementToNotExistsearchElementType = WorkflowExpression.Compile(browserWaitForElementToNotExistsearchElementType, nameof(browserWaitForElementToNotExistsearchElementType), required: false);
            var __workflow_browserWaitForElementToNotExistsearchElementMinimumWidth = WorkflowExpression.Compile(browserWaitForElementToNotExistsearchElementMinimumWidth, nameof(browserWaitForElementToNotExistsearchElementMinimumWidth), required: false);
            var __workflow_browserWaitForElementToNotExistsearchElementMinimumHeight = WorkflowExpression.Compile(browserWaitForElementToNotExistsearchElementMinimumHeight, nameof(browserWaitForElementToNotExistsearchElementMinimumHeight), required: false);
            var __workflow_browserWaitForElementToNotExistsearchElementBoundingBoxLeft = WorkflowExpression.Compile(browserWaitForElementToNotExistsearchElementBoundingBoxLeft, nameof(browserWaitForElementToNotExistsearchElementBoundingBoxLeft), required: false);
            var __workflow_browserWaitForElementToNotExistsearchElementBoundingBoxRight = WorkflowExpression.Compile(browserWaitForElementToNotExistsearchElementBoundingBoxRight, nameof(browserWaitForElementToNotExistsearchElementBoundingBoxRight), required: false);
            var __workflow_browserWaitForElementToNotExistsearchElementBoundingBoxTop = WorkflowExpression.Compile(browserWaitForElementToNotExistsearchElementBoundingBoxTop, nameof(browserWaitForElementToNotExistsearchElementBoundingBoxTop), required: false);
            var __workflow_browserWaitForElementToNotExistsearchElementBoundingBoxBottom = WorkflowExpression.Compile(browserWaitForElementToNotExistsearchElementBoundingBoxBottom, nameof(browserWaitForElementToNotExistsearchElementBoundingBoxBottom), required: false);
            var __workflow_browserWaitForElementToNotExistonlyElementTopLeftNeedsToBeInBoundingBox = WorkflowExpression.Compile(browserWaitForElementToNotExistonlyElementTopLeftNeedsToBeInBoundingBox, nameof(browserWaitForElementToNotExistonlyElementTopLeftNeedsToBeInBoundingBox), required: false);
            var __workflow_browserWaitForElementToNotExistraiseExceptionIfElementStillExists = WorkflowExpression.Compile(browserWaitForElementToNotExistraiseExceptionIfElementStillExists, nameof(browserWaitForElementToNotExistraiseExceptionIfElementStillExists), required: false);
            var __workflow_browserWaitForElementToNotExistsearchElementMustBeDisplayed = WorkflowExpression.Compile(browserWaitForElementToNotExistsearchElementMustBeDisplayed, nameof(browserWaitForElementToNotExistsearchElementMustBeDisplayed), required: false);
            return new DeferredBodyAction<BrowserWaitForElementToNotExistResponse>(() =>
            {
                var apiCallPath = "/BrowserControl/WaitForElementToNotExist";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserWaitForElementToNotExist = new JObject();
                var browserWaitForElementToNotExistpropCount = 0;
                if (__workflow_browserWaitForElementToNotExistparentElementHandle != null)
                {
                    browserWaitForElementToNotExist["ParentElementHandle"] = ExpressionConverter.ConvertO(__workflow_browserWaitForElementToNotExistparentElementHandle);
                    browserWaitForElementToNotExistpropCount++;
                }

                if (__workflow_browserWaitForElementToNotExistsearchElementHandle != null)
                {
                    browserWaitForElementToNotExist["SearchElementHandle"] = ExpressionConverter.ConvertO(__workflow_browserWaitForElementToNotExistsearchElementHandle);
                    browserWaitForElementToNotExistpropCount++;
                }

                if (__workflow_browserWaitForElementToNotExistsearchElementName != null)
                {
                    browserWaitForElementToNotExist["SearchElementName"] = ExpressionConverter.ConvertO(__workflow_browserWaitForElementToNotExistsearchElementName);
                    browserWaitForElementToNotExistpropCount++;
                }

                if (__workflow_browserWaitForElementToNotExistsearchElementID != null)
                {
                    browserWaitForElementToNotExist["SearchElementID"] = ExpressionConverter.ConvertO(__workflow_browserWaitForElementToNotExistsearchElementID);
                    browserWaitForElementToNotExistpropCount++;
                }

                if (__workflow_browserWaitForElementToNotExistsearchElementTagName != null)
                {
                    browserWaitForElementToNotExist["SearchElementTagName"] = ExpressionConverter.ConvertO(__workflow_browserWaitForElementToNotExistsearchElementTagName);
                    browserWaitForElementToNotExistpropCount++;
                }

                if (__workflow_browserWaitForElementToNotExistsearchElementXPath != null)
                {
                    browserWaitForElementToNotExist["SearchElementXPath"] = ExpressionConverter.ConvertO(__workflow_browserWaitForElementToNotExistsearchElementXPath);
                    browserWaitForElementToNotExistpropCount++;
                }

                if (__workflow_browserWaitForElementToNotExistsearchElementClassName != null)
                {
                    browserWaitForElementToNotExist["SearchElementClassName"] = ExpressionConverter.ConvertO(__workflow_browserWaitForElementToNotExistsearchElementClassName);
                    browserWaitForElementToNotExistpropCount++;
                }

                if (__workflow_browserWaitForElementToNotExistsearchElementCSSSelector != null)
                {
                    browserWaitForElementToNotExist["SearchElementCSSSelector"] = ExpressionConverter.ConvertO(__workflow_browserWaitForElementToNotExistsearchElementCSSSelector);
                    browserWaitForElementToNotExistpropCount++;
                }

                if (__workflow_browserWaitForElementToNotExistsearchElementIndex != null)
                {
                    if (__workflow_browserWaitForElementToNotExistsearchElementIndex != null)
                    {
                        browserWaitForElementToNotExist["SearchElementIndex"] = ExpressionConverter.ConvertO(__workflow_browserWaitForElementToNotExistsearchElementIndex);
                        browserWaitForElementToNotExistpropCount++;
                    }

                    browserWaitForElementToNotExistpropCount++;
                }
                else
                {
                    browserWaitForElementToNotExist["SearchElementIndex"] = 1;
                    browserWaitForElementToNotExistpropCount++;
                }

                if (__workflow_browserWaitForElementToNotExistsearchElementMatchValue != null)
                {
                    browserWaitForElementToNotExist["SearchElementMatchValue"] = ExpressionConverter.ConvertO(__workflow_browserWaitForElementToNotExistsearchElementMatchValue);
                    browserWaitForElementToNotExistpropCount++;
                }

                if (__workflow_browserWaitForElementToNotExistsearchElementMatchText != null)
                {
                    browserWaitForElementToNotExist["SearchElementMatchText"] = ExpressionConverter.ConvertO(__workflow_browserWaitForElementToNotExistsearchElementMatchText);
                    browserWaitForElementToNotExistpropCount++;
                }

                if (__workflow_browserWaitForElementToNotExistsearchElementType != null)
                {
                    browserWaitForElementToNotExist["SearchElementType"] = ExpressionConverter.ConvertO(__workflow_browserWaitForElementToNotExistsearchElementType);
                    browserWaitForElementToNotExistpropCount++;
                }

                if (__workflow_browserWaitForElementToNotExistsearchElementMinimumWidth != null)
                {
                    if (__workflow_browserWaitForElementToNotExistsearchElementMinimumWidth != null)
                    {
                        browserWaitForElementToNotExist["SearchElementMinimumWidth"] = ExpressionConverter.ConvertO(__workflow_browserWaitForElementToNotExistsearchElementMinimumWidth);
                        browserWaitForElementToNotExistpropCount++;
                    }

                    browserWaitForElementToNotExistpropCount++;
                }
                else
                {
                    browserWaitForElementToNotExist["SearchElementMinimumWidth"] = 1;
                    browserWaitForElementToNotExistpropCount++;
                }

                if (__workflow_browserWaitForElementToNotExistsearchElementMinimumHeight != null)
                {
                    if (__workflow_browserWaitForElementToNotExistsearchElementMinimumHeight != null)
                    {
                        browserWaitForElementToNotExist["SearchElementMinimumHeight"] = ExpressionConverter.ConvertO(__workflow_browserWaitForElementToNotExistsearchElementMinimumHeight);
                        browserWaitForElementToNotExistpropCount++;
                    }

                    browserWaitForElementToNotExistpropCount++;
                }
                else
                {
                    browserWaitForElementToNotExist["SearchElementMinimumHeight"] = 1;
                    browserWaitForElementToNotExistpropCount++;
                }

                if (__workflow_browserWaitForElementToNotExistsearchElementBoundingBoxLeft != null)
                {
                    if (__workflow_browserWaitForElementToNotExistsearchElementBoundingBoxLeft != null)
                    {
                        browserWaitForElementToNotExist["SearchElementBoundingBoxLeft"] = ExpressionConverter.ConvertO(__workflow_browserWaitForElementToNotExistsearchElementBoundingBoxLeft);
                        browserWaitForElementToNotExistpropCount++;
                    }

                    browserWaitForElementToNotExistpropCount++;
                }
                else
                {
                    browserWaitForElementToNotExist["SearchElementBoundingBoxLeft"] = -99999;
                    browserWaitForElementToNotExistpropCount++;
                }

                if (__workflow_browserWaitForElementToNotExistsearchElementBoundingBoxRight != null)
                {
                    if (__workflow_browserWaitForElementToNotExistsearchElementBoundingBoxRight != null)
                    {
                        browserWaitForElementToNotExist["SearchElementBoundingBoxRight"] = ExpressionConverter.ConvertO(__workflow_browserWaitForElementToNotExistsearchElementBoundingBoxRight);
                        browserWaitForElementToNotExistpropCount++;
                    }

                    browserWaitForElementToNotExistpropCount++;
                }
                else
                {
                    browserWaitForElementToNotExist["SearchElementBoundingBoxRight"] = 99999;
                    browserWaitForElementToNotExistpropCount++;
                }

                if (__workflow_browserWaitForElementToNotExistsearchElementBoundingBoxTop != null)
                {
                    if (__workflow_browserWaitForElementToNotExistsearchElementBoundingBoxTop != null)
                    {
                        browserWaitForElementToNotExist["SearchElementBoundingBoxTop"] = ExpressionConverter.ConvertO(__workflow_browserWaitForElementToNotExistsearchElementBoundingBoxTop);
                        browserWaitForElementToNotExistpropCount++;
                    }

                    browserWaitForElementToNotExistpropCount++;
                }
                else
                {
                    browserWaitForElementToNotExist["SearchElementBoundingBoxTop"] = -99999;
                    browserWaitForElementToNotExistpropCount++;
                }

                if (__workflow_browserWaitForElementToNotExistsearchElementBoundingBoxBottom != null)
                {
                    if (__workflow_browserWaitForElementToNotExistsearchElementBoundingBoxBottom != null)
                    {
                        browserWaitForElementToNotExist["SearchElementBoundingBoxBottom"] = ExpressionConverter.ConvertO(__workflow_browserWaitForElementToNotExistsearchElementBoundingBoxBottom);
                        browserWaitForElementToNotExistpropCount++;
                    }

                    browserWaitForElementToNotExistpropCount++;
                }
                else
                {
                    browserWaitForElementToNotExist["SearchElementBoundingBoxBottom"] = 99999;
                    browserWaitForElementToNotExistpropCount++;
                }

                if (__workflow_browserWaitForElementToNotExistonlyElementTopLeftNeedsToBeInBoundingBox != null)
                {
                    if (__workflow_browserWaitForElementToNotExistonlyElementTopLeftNeedsToBeInBoundingBox != null)
                    {
                        browserWaitForElementToNotExist["OnlyElementTopLeftNeedsToBeInBoundingBox"] = ExpressionConverter.ConvertO(__workflow_browserWaitForElementToNotExistonlyElementTopLeftNeedsToBeInBoundingBox);
                        browserWaitForElementToNotExistpropCount++;
                    }

                    browserWaitForElementToNotExistpropCount++;
                }
                else
                {
                    browserWaitForElementToNotExist["OnlyElementTopLeftNeedsToBeInBoundingBox"] = false;
                    browserWaitForElementToNotExistpropCount++;
                }

                browserWaitForElementToNotExistpropCount++;
                browserWaitForElementToNotExist["SecondsToWait"] = ExpressionConverter.ConvertO(__workflow_browserWaitForElementToNotExistsecondsToWait);
                if (__workflow_browserWaitForElementToNotExistraiseExceptionIfElementStillExists != null)
                {
                    if (__workflow_browserWaitForElementToNotExistraiseExceptionIfElementStillExists != null)
                    {
                        browserWaitForElementToNotExist["RaiseExceptionIfElementStillExists"] = ExpressionConverter.ConvertO(__workflow_browserWaitForElementToNotExistraiseExceptionIfElementStillExists);
                        browserWaitForElementToNotExistpropCount++;
                    }

                    browserWaitForElementToNotExistpropCount++;
                }
                else
                {
                    browserWaitForElementToNotExist["RaiseExceptionIfElementStillExists"] = false;
                    browserWaitForElementToNotExistpropCount++;
                }

                if (__workflow_browserWaitForElementToNotExistsearchElementMustBeDisplayed != null)
                {
                    if (__workflow_browserWaitForElementToNotExistsearchElementMustBeDisplayed != null)
                    {
                        browserWaitForElementToNotExist["SearchElementMustBeDisplayed"] = ExpressionConverter.ConvertO(__workflow_browserWaitForElementToNotExistsearchElementMustBeDisplayed);
                        browserWaitForElementToNotExistpropCount++;
                    }

                    browserWaitForElementToNotExistpropCount++;
                }
                else
                {
                    browserWaitForElementToNotExist["SearchElementMustBeDisplayed"] = false;
                    browserWaitForElementToNotExistpropCount++;
                }

                browserWaitForElementToNotExistpropCount++;
                browserWaitForElementToNotExist["Workflow"] = ExpressionConverter.ConvertO(__workflow_browserWaitForElementToNotExistworkflow);
                if (browserWaitForElementToNotExistpropCount > 0)
                {
                    callPayload.Body = browserWaitForElementToNotExist;
                }

                return new ApiConnectionAction<BrowserWaitForElementToNotExistResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserGetWebElementAtScreenCoordinatesResponse> BrowserGetWebElementAtScreenCoordinates(Expression<Func<string>> browserGetWebElementAtScreenCoordinatesworkflow, Expression<Func<int>> browserGetWebElementAtScreenCoordinatesxCoord = null, Expression<Func<int>> browserGetWebElementAtScreenCoordinatesyCoord = null, Expression<Func<bool>> browserGetWebElementAtScreenCoordinatesraiseExceptionIfElementNotFound = null)
        {
            var __workflow_browserGetWebElementAtScreenCoordinatesworkflow = WorkflowExpression.Compile(browserGetWebElementAtScreenCoordinatesworkflow, nameof(browserGetWebElementAtScreenCoordinatesworkflow), required: true);
            var __workflow_browserGetWebElementAtScreenCoordinatesxCoord = WorkflowExpression.Compile(browserGetWebElementAtScreenCoordinatesxCoord, nameof(browserGetWebElementAtScreenCoordinatesxCoord), required: false);
            var __workflow_browserGetWebElementAtScreenCoordinatesyCoord = WorkflowExpression.Compile(browserGetWebElementAtScreenCoordinatesyCoord, nameof(browserGetWebElementAtScreenCoordinatesyCoord), required: false);
            var __workflow_browserGetWebElementAtScreenCoordinatesraiseExceptionIfElementNotFound = WorkflowExpression.Compile(browserGetWebElementAtScreenCoordinatesraiseExceptionIfElementNotFound, nameof(browserGetWebElementAtScreenCoordinatesraiseExceptionIfElementNotFound), required: false);
            return new DeferredBodyAction<BrowserGetWebElementAtScreenCoordinatesResponse>(() =>
            {
                var apiCallPath = "/BrowserControl/GetWebElementAtScreenCoordinates";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserGetWebElementAtScreenCoordinates = new JObject();
                var browserGetWebElementAtScreenCoordinatespropCount = 0;
                if (__workflow_browserGetWebElementAtScreenCoordinatesxCoord != null)
                {
                    if (__workflow_browserGetWebElementAtScreenCoordinatesxCoord != null)
                    {
                        browserGetWebElementAtScreenCoordinates["XCoord"] = ExpressionConverter.ConvertO(__workflow_browserGetWebElementAtScreenCoordinatesxCoord);
                        browserGetWebElementAtScreenCoordinatespropCount++;
                    }

                    browserGetWebElementAtScreenCoordinatespropCount++;
                }
                else
                {
                    browserGetWebElementAtScreenCoordinates["XCoord"] = 0;
                    browserGetWebElementAtScreenCoordinatespropCount++;
                }

                if (__workflow_browserGetWebElementAtScreenCoordinatesyCoord != null)
                {
                    if (__workflow_browserGetWebElementAtScreenCoordinatesyCoord != null)
                    {
                        browserGetWebElementAtScreenCoordinates["YCoord"] = ExpressionConverter.ConvertO(__workflow_browserGetWebElementAtScreenCoordinatesyCoord);
                        browserGetWebElementAtScreenCoordinatespropCount++;
                    }

                    browserGetWebElementAtScreenCoordinatespropCount++;
                }
                else
                {
                    browserGetWebElementAtScreenCoordinates["YCoord"] = 0;
                    browserGetWebElementAtScreenCoordinatespropCount++;
                }

                if (__workflow_browserGetWebElementAtScreenCoordinatesraiseExceptionIfElementNotFound != null)
                {
                    if (__workflow_browserGetWebElementAtScreenCoordinatesraiseExceptionIfElementNotFound != null)
                    {
                        browserGetWebElementAtScreenCoordinates["RaiseExceptionIfElementNotFound"] = ExpressionConverter.ConvertO(__workflow_browserGetWebElementAtScreenCoordinatesraiseExceptionIfElementNotFound);
                        browserGetWebElementAtScreenCoordinatespropCount++;
                    }

                    browserGetWebElementAtScreenCoordinatespropCount++;
                }
                else
                {
                    browserGetWebElementAtScreenCoordinates["RaiseExceptionIfElementNotFound"] = false;
                    browserGetWebElementAtScreenCoordinatespropCount++;
                }

                browserGetWebElementAtScreenCoordinatespropCount++;
                browserGetWebElementAtScreenCoordinates["Workflow"] = ExpressionConverter.ConvertO(__workflow_browserGetWebElementAtScreenCoordinatesworkflow);
                if (browserGetWebElementAtScreenCoordinatespropCount > 0)
                {
                    callPayload.Body = browserGetWebElementAtScreenCoordinates;
                }

                return new ApiConnectionAction<BrowserGetWebElementAtScreenCoordinatesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserGetWebElementAtBrowserDocumentWindowCoordinatesResponse> BrowserGetWebElementAtBrowserDocumentWindowCoordinates(Expression<Func<string>> browserGetWebElementAtBrowserDocumentWindowCoordinatesworkflow, Expression<Func<int>> browserGetWebElementAtBrowserDocumentWindowCoordinatesxCoord = null, Expression<Func<int>> browserGetWebElementAtBrowserDocumentWindowCoordinatesyCoord = null, Expression<Func<bool>> browserGetWebElementAtBrowserDocumentWindowCoordinatesraiseExceptionIfElementNotFound = null)
        {
            var __workflow_browserGetWebElementAtBrowserDocumentWindowCoordinatesworkflow = WorkflowExpression.Compile(browserGetWebElementAtBrowserDocumentWindowCoordinatesworkflow, nameof(browserGetWebElementAtBrowserDocumentWindowCoordinatesworkflow), required: true);
            var __workflow_browserGetWebElementAtBrowserDocumentWindowCoordinatesxCoord = WorkflowExpression.Compile(browserGetWebElementAtBrowserDocumentWindowCoordinatesxCoord, nameof(browserGetWebElementAtBrowserDocumentWindowCoordinatesxCoord), required: false);
            var __workflow_browserGetWebElementAtBrowserDocumentWindowCoordinatesyCoord = WorkflowExpression.Compile(browserGetWebElementAtBrowserDocumentWindowCoordinatesyCoord, nameof(browserGetWebElementAtBrowserDocumentWindowCoordinatesyCoord), required: false);
            var __workflow_browserGetWebElementAtBrowserDocumentWindowCoordinatesraiseExceptionIfElementNotFound = WorkflowExpression.Compile(browserGetWebElementAtBrowserDocumentWindowCoordinatesraiseExceptionIfElementNotFound, nameof(browserGetWebElementAtBrowserDocumentWindowCoordinatesraiseExceptionIfElementNotFound), required: false);
            return new DeferredBodyAction<BrowserGetWebElementAtBrowserDocumentWindowCoordinatesResponse>(() =>
            {
                var apiCallPath = "/BrowserControl/GetWebElementAtBrowserDocumentWindowCoordinates";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserGetWebElementAtBrowserDocumentWindowCoordinates = new JObject();
                var browserGetWebElementAtBrowserDocumentWindowCoordinatespropCount = 0;
                if (__workflow_browserGetWebElementAtBrowserDocumentWindowCoordinatesxCoord != null)
                {
                    if (__workflow_browserGetWebElementAtBrowserDocumentWindowCoordinatesxCoord != null)
                    {
                        browserGetWebElementAtBrowserDocumentWindowCoordinates["XCoord"] = ExpressionConverter.ConvertO(__workflow_browserGetWebElementAtBrowserDocumentWindowCoordinatesxCoord);
                        browserGetWebElementAtBrowserDocumentWindowCoordinatespropCount++;
                    }

                    browserGetWebElementAtBrowserDocumentWindowCoordinatespropCount++;
                }
                else
                {
                    browserGetWebElementAtBrowserDocumentWindowCoordinates["XCoord"] = 0;
                    browserGetWebElementAtBrowserDocumentWindowCoordinatespropCount++;
                }

                if (__workflow_browserGetWebElementAtBrowserDocumentWindowCoordinatesyCoord != null)
                {
                    if (__workflow_browserGetWebElementAtBrowserDocumentWindowCoordinatesyCoord != null)
                    {
                        browserGetWebElementAtBrowserDocumentWindowCoordinates["YCoord"] = ExpressionConverter.ConvertO(__workflow_browserGetWebElementAtBrowserDocumentWindowCoordinatesyCoord);
                        browserGetWebElementAtBrowserDocumentWindowCoordinatespropCount++;
                    }

                    browserGetWebElementAtBrowserDocumentWindowCoordinatespropCount++;
                }
                else
                {
                    browserGetWebElementAtBrowserDocumentWindowCoordinates["YCoord"] = 0;
                    browserGetWebElementAtBrowserDocumentWindowCoordinatespropCount++;
                }

                if (__workflow_browserGetWebElementAtBrowserDocumentWindowCoordinatesraiseExceptionIfElementNotFound != null)
                {
                    if (__workflow_browserGetWebElementAtBrowserDocumentWindowCoordinatesraiseExceptionIfElementNotFound != null)
                    {
                        browserGetWebElementAtBrowserDocumentWindowCoordinates["RaiseExceptionIfElementNotFound"] = ExpressionConverter.ConvertO(__workflow_browserGetWebElementAtBrowserDocumentWindowCoordinatesraiseExceptionIfElementNotFound);
                        browserGetWebElementAtBrowserDocumentWindowCoordinatespropCount++;
                    }

                    browserGetWebElementAtBrowserDocumentWindowCoordinatespropCount++;
                }
                else
                {
                    browserGetWebElementAtBrowserDocumentWindowCoordinates["RaiseExceptionIfElementNotFound"] = false;
                    browserGetWebElementAtBrowserDocumentWindowCoordinatespropCount++;
                }

                browserGetWebElementAtBrowserDocumentWindowCoordinatespropCount++;
                browserGetWebElementAtBrowserDocumentWindowCoordinates["Workflow"] = ExpressionConverter.ConvertO(__workflow_browserGetWebElementAtBrowserDocumentWindowCoordinatesworkflow);
                if (browserGetWebElementAtBrowserDocumentWindowCoordinatespropCount > 0)
                {
                    callPayload.Body = browserGetWebElementAtBrowserDocumentWindowCoordinates;
                }

                return new ApiConnectionAction<BrowserGetWebElementAtBrowserDocumentWindowCoordinatesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserGetWebElementPropertiesAsListResponse> BrowserGetWebElementPropertiesAsList(Expression<Func<int>> browserGetWebElementPropertiesAsListelementHandle, Expression<Func<string>> browserGetWebElementPropertiesAsListworkflow, Expression<Func<bool>> browserGetWebElementPropertiesAsListgetHTMLCode = null, Expression<Func<bool>> browserGetWebElementPropertiesAsListreturnValue = null, Expression<Func<bool>> browserGetWebElementPropertiesAsListreturnText = null, Expression<Func<int>> browserGetWebElementPropertiesAsListmaxValueLength = null, Expression<Func<int>> browserGetWebElementPropertiesAsListmaxTextLength = null, Expression<Func<bool>> browserGetWebElementPropertiesAsListreturnCoordinates = null, Expression<Func<bool>> browserGetWebElementPropertiesAsListreturnParentTag = null)
        {
            var __workflow_browserGetWebElementPropertiesAsListelementHandle = WorkflowExpression.Compile(browserGetWebElementPropertiesAsListelementHandle, nameof(browserGetWebElementPropertiesAsListelementHandle), required: true);
            var __workflow_browserGetWebElementPropertiesAsListworkflow = WorkflowExpression.Compile(browserGetWebElementPropertiesAsListworkflow, nameof(browserGetWebElementPropertiesAsListworkflow), required: true);
            var __workflow_browserGetWebElementPropertiesAsListgetHTMLCode = WorkflowExpression.Compile(browserGetWebElementPropertiesAsListgetHTMLCode, nameof(browserGetWebElementPropertiesAsListgetHTMLCode), required: false);
            var __workflow_browserGetWebElementPropertiesAsListreturnValue = WorkflowExpression.Compile(browserGetWebElementPropertiesAsListreturnValue, nameof(browserGetWebElementPropertiesAsListreturnValue), required: false);
            var __workflow_browserGetWebElementPropertiesAsListreturnText = WorkflowExpression.Compile(browserGetWebElementPropertiesAsListreturnText, nameof(browserGetWebElementPropertiesAsListreturnText), required: false);
            var __workflow_browserGetWebElementPropertiesAsListmaxValueLength = WorkflowExpression.Compile(browserGetWebElementPropertiesAsListmaxValueLength, nameof(browserGetWebElementPropertiesAsListmaxValueLength), required: false);
            var __workflow_browserGetWebElementPropertiesAsListmaxTextLength = WorkflowExpression.Compile(browserGetWebElementPropertiesAsListmaxTextLength, nameof(browserGetWebElementPropertiesAsListmaxTextLength), required: false);
            var __workflow_browserGetWebElementPropertiesAsListreturnCoordinates = WorkflowExpression.Compile(browserGetWebElementPropertiesAsListreturnCoordinates, nameof(browserGetWebElementPropertiesAsListreturnCoordinates), required: false);
            var __workflow_browserGetWebElementPropertiesAsListreturnParentTag = WorkflowExpression.Compile(browserGetWebElementPropertiesAsListreturnParentTag, nameof(browserGetWebElementPropertiesAsListreturnParentTag), required: false);
            return new DeferredBodyAction<BrowserGetWebElementPropertiesAsListResponse>(() =>
            {
                var apiCallPath = "/BrowserControl/BrowserGetWebElementPropertiesAsList";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var browserGetWebElementPropertiesAsList = new JObject();
                var browserGetWebElementPropertiesAsListpropCount = 0;
                browserGetWebElementPropertiesAsListpropCount++;
                browserGetWebElementPropertiesAsList["ElementHandle"] = ExpressionConverter.ConvertO(__workflow_browserGetWebElementPropertiesAsListelementHandle);
                if (__workflow_browserGetWebElementPropertiesAsListgetHTMLCode != null)
                {
                    if (__workflow_browserGetWebElementPropertiesAsListgetHTMLCode != null)
                    {
                        browserGetWebElementPropertiesAsList["GetHTMLCode"] = ExpressionConverter.ConvertO(__workflow_browserGetWebElementPropertiesAsListgetHTMLCode);
                        browserGetWebElementPropertiesAsListpropCount++;
                    }

                    browserGetWebElementPropertiesAsListpropCount++;
                }
                else
                {
                    browserGetWebElementPropertiesAsList["GetHTMLCode"] = false;
                    browserGetWebElementPropertiesAsListpropCount++;
                }

                if (__workflow_browserGetWebElementPropertiesAsListreturnValue != null)
                {
                    if (__workflow_browserGetWebElementPropertiesAsListreturnValue != null)
                    {
                        browserGetWebElementPropertiesAsList["ReturnValue"] = ExpressionConverter.ConvertO(__workflow_browserGetWebElementPropertiesAsListreturnValue);
                        browserGetWebElementPropertiesAsListpropCount++;
                    }

                    browserGetWebElementPropertiesAsListpropCount++;
                }
                else
                {
                    browserGetWebElementPropertiesAsList["ReturnValue"] = true;
                    browserGetWebElementPropertiesAsListpropCount++;
                }

                if (__workflow_browserGetWebElementPropertiesAsListreturnText != null)
                {
                    if (__workflow_browserGetWebElementPropertiesAsListreturnText != null)
                    {
                        browserGetWebElementPropertiesAsList["ReturnText"] = ExpressionConverter.ConvertO(__workflow_browserGetWebElementPropertiesAsListreturnText);
                        browserGetWebElementPropertiesAsListpropCount++;
                    }

                    browserGetWebElementPropertiesAsListpropCount++;
                }
                else
                {
                    browserGetWebElementPropertiesAsList["ReturnText"] = true;
                    browserGetWebElementPropertiesAsListpropCount++;
                }

                if (__workflow_browserGetWebElementPropertiesAsListmaxValueLength != null)
                {
                    if (__workflow_browserGetWebElementPropertiesAsListmaxValueLength != null)
                    {
                        browserGetWebElementPropertiesAsList["MaxValueLength"] = ExpressionConverter.ConvertO(__workflow_browserGetWebElementPropertiesAsListmaxValueLength);
                        browserGetWebElementPropertiesAsListpropCount++;
                    }

                    browserGetWebElementPropertiesAsListpropCount++;
                }
                else
                {
                    browserGetWebElementPropertiesAsList["MaxValueLength"] = 0;
                    browserGetWebElementPropertiesAsListpropCount++;
                }

                if (__workflow_browserGetWebElementPropertiesAsListmaxTextLength != null)
                {
                    if (__workflow_browserGetWebElementPropertiesAsListmaxTextLength != null)
                    {
                        browserGetWebElementPropertiesAsList["MaxTextLength"] = ExpressionConverter.ConvertO(__workflow_browserGetWebElementPropertiesAsListmaxTextLength);
                        browserGetWebElementPropertiesAsListpropCount++;
                    }

                    browserGetWebElementPropertiesAsListpropCount++;
                }
                else
                {
                    browserGetWebElementPropertiesAsList["MaxTextLength"] = 0;
                    browserGetWebElementPropertiesAsListpropCount++;
                }

                if (__workflow_browserGetWebElementPropertiesAsListreturnCoordinates != null)
                {
                    if (__workflow_browserGetWebElementPropertiesAsListreturnCoordinates != null)
                    {
                        browserGetWebElementPropertiesAsList["ReturnCoordinates"] = ExpressionConverter.ConvertO(__workflow_browserGetWebElementPropertiesAsListreturnCoordinates);
                        browserGetWebElementPropertiesAsListpropCount++;
                    }

                    browserGetWebElementPropertiesAsListpropCount++;
                }
                else
                {
                    browserGetWebElementPropertiesAsList["ReturnCoordinates"] = true;
                    browserGetWebElementPropertiesAsListpropCount++;
                }

                if (__workflow_browserGetWebElementPropertiesAsListreturnParentTag != null)
                {
                    if (__workflow_browserGetWebElementPropertiesAsListreturnParentTag != null)
                    {
                        browserGetWebElementPropertiesAsList["ReturnParentTag"] = ExpressionConverter.ConvertO(__workflow_browserGetWebElementPropertiesAsListreturnParentTag);
                        browserGetWebElementPropertiesAsListpropCount++;
                    }

                    browserGetWebElementPropertiesAsListpropCount++;
                }
                else
                {
                    browserGetWebElementPropertiesAsList["ReturnParentTag"] = true;
                    browserGetWebElementPropertiesAsListpropCount++;
                }

                browserGetWebElementPropertiesAsListpropCount++;
                browserGetWebElementPropertiesAsList["Workflow"] = ExpressionConverter.ConvertO(__workflow_browserGetWebElementPropertiesAsListworkflow);
                if (browserGetWebElementPropertiesAsListpropCount > 0)
                {
                    callPayload.Body = browserGetWebElementPropertiesAsList;
                }

                return new ApiConnectionAction<BrowserGetWebElementPropertiesAsListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<IsBrowserInstanceOpenResponse> IsBrowserInstanceOpen(Expression<Func<string>> isBrowserInstanceOpenworkflow)
        {
            var __workflow_isBrowserInstanceOpenworkflow = WorkflowExpression.Compile(isBrowserInstanceOpenworkflow, nameof(isBrowserInstanceOpenworkflow), required: true);
            return new DeferredBodyAction<IsBrowserInstanceOpenResponse>(() =>
            {
                var apiCallPath = "/BrowserControl/IsBrowserInstanceOpen";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var isBrowserInstanceOpen = new JObject();
                var isBrowserInstanceOpenpropCount = 0;
                isBrowserInstanceOpenpropCount++;
                isBrowserInstanceOpen["Workflow"] = ExpressionConverter.ConvertO(__workflow_isBrowserInstanceOpenworkflow);
                if (isBrowserInstanceOpenpropCount > 0)
                {
                    callPayload.Body = isBrowserInstanceOpen;
                }

                return new ApiConnectionAction<IsBrowserInstanceOpenResponse>(callPayload);
            });
        }
    }

    public class IaconnectwebbrowserTriggers([ConnectionName] string connectionId)
    {
    }

    public class BrowserGetChromeBrowserVersionFromFileResponse
    {
        public string ChromeBrowserFileVersion { get; set; }
        public int ChromeBrowserMajorVersion { get; set; }
    }

    public class BrowserGetChromeDriverFolderResponse
    {
        public string ChromeDriverFolder { get; set; }
    }

    public class BrowserDownloadSuitableChromeDriverFromInternetResponse
    {
        public string SuitableChromeDriverPath { get; set; }
    }

    public class BrowserIsSuitableChromeDriverAvailableResponse
    {
        public string ChromeBrowserFileVersion { get; set; }
        public int ChromeBrowserMajorVersion { get; set; }
        public bool SuitableChromeDriverAvailable { get; set; }
        public string SuitableChromeDriverPath { get; set; }
    }

    public class BrowserOpenChromeResponse
    {
        public int ChromeDriverPID { get; set; }
        public int ChromeDriverTCPPort { get; set; }
        public int ChromePID { get; set; }
        public int ChromeTCPPort { get; set; }
        public string ChromeInstanceUserDataDir { get; set; }
        public bool ChromeInstanceAlreadyOpen { get; set; }
    }

    public class BrowserGetChromiumEdgeDriverFolderResponse
    {
        public string ChromiumEdgeDriverFolder { get; set; }
    }

    public class BrowserGetChromiumEdgeBrowserVersionFromFileResponse
    {
        public string ChromiumEdgeBrowserFileVersion { get; set; }
        public int ChromiumEdgeBrowserMajorVersion { get; set; }
    }

    public class BrowserDownloadSuitableChromiumEdgeDriverFromInternetResponse
    {
        public string SuitableChromiumEdgeDriverPath { get; set; }
    }

    public class BrowserIsSuitableChromiumEdgeDriverAvailableResponse
    {
        public string ChromiumEdgeBrowserFileVersion { get; set; }
        public int ChromiumEdgeBrowserMajorVersion { get; set; }
        public bool SuitableChromiumEdgeDriverAvailable { get; set; }
        public string SuitableChromiumEdgeDriverPath { get; set; }
    }

    public class BrowserOpenChromiumEdgeResponse
    {
        public int ChromiumEdgeDriverPID { get; set; }
        public int ChromiumEdgeDriverTCPPort { get; set; }
        public int ChromiumEdgePID { get; set; }
        public int ChromiumEdgeTCPPort { get; set; }
        public string ChromiumEdgeInstanceUserDataDir { get; set; }
        public bool ChromiumEdgeInstanceAlreadyOpen { get; set; }
    }

    public class BrowserNavigateToURLResponse
    {
        public string PageTitle { get; set; }
        public string PageURL { get; set; }
    }

    public class BrowserDoesElementExistResponse
    {
        public bool ElementExists { get; set; }
    }

    public class BrowserCreateHandleToElementResponse
    {
        public double ElementHandle { get; set; }
        public string ElementTagName { get; set; }
    }

    public class BrowserCreateHandleToParentElementResponse
    {
        public double ElementHandle { get; set; }
        public string ElementTagName { get; set; }
    }

    public class BrowserGetElementPropertiesResponse
    {
        public string ElementName { get; set; }
        public string ElementID { get; set; }
        public string ElementTagName { get; set; }
        public string ElementClassName { get; set; }
        public string ElementValue { get; set; }
        public string ElementText { get; set; }
        public bool ElementEnabled { get; set; }
        public bool ElementDisplayed { get; set; }
        public double ElementXCoordinate { get; set; }
        public double ElementYCoordinate { get; set; }
        public double ElementWidth { get; set; }
        public double ElementHeight { get; set; }
        public bool ElementSelected { get; set; }
        public string ElementType { get; set; }
        public string InnerHTML { get; set; }
        public string OuterHTML { get; set; }
        public double ChildElementCount { get; set; }
        public string ParentTagName { get; set; }
        public double ElementHandle { get; set; }
    }

    public class BrowserGetMultipleElementPropertiesResponse
    {
        public double NumberOfElementsFound { get; set; }
        public JToken[] ElementProperties { get; set; }
        public bool MoreElementsAvailable { get; set; }
    }

    public class BrowserGetElementParentPropertiesResponse
    {
        public double NumberOfElementsFound { get; set; }
        public JToken[] ElementProperties { get; set; }
    }

    public class BrowserGetElementChildrenPropertiesResponse
    {
        public double NumberOfElementsFound { get; set; }
        public JToken[] ElementProperties { get; set; }
        public bool MoreElementsAvailable { get; set; }
    }

    public class BrowserInputTextIntoElementResponse
    {
        public string PreviousValue { get; set; }
    }

    public class BrowserGetSelectionPropertiesResponse
    {
        public string SelectedOptionText { get; set; }
        public string SelectedOptionValue { get; set; }
        public double NumberOfOptions { get; set; }
        public JToken[] SelectionOptions { get; set; }
    }

    public class BrowserGetTableContentsResponse
    {
        public double NumberOfRows { get; set; }
        public double NumberOfColumns { get; set; }
        public string TableContentsJSON { get; set; }
    }

    public class BrowserExecuteJavaScriptResponse
    {
        public string JavaScriptResponse { get; set; }
    }

    public class BrowserGetElementBoundingRectResponse
    {
        public double ElementLeftPixels { get; set; }
        public double ElementRightPixels { get; set; }
        public double ElementTopPixels { get; set; }
        public double ElementBottomPixels { get; set; }
        public double ElementCenterXPixels { get; set; }
        public double ElementCenterYPixels { get; set; }
    }

    public class BrowserGetBrowserParentWindowDetailsResponse
    {
        public string MainWindowElementName { get; set; }
        public string MainWindowElementClassName { get; set; }
        public int MainWindowLeftXPixels { get; set; }
        public int MainWindowTopYPixels { get; set; }
        public int MainWindowWidthPixels { get; set; }
        public int MainWindowHeightPixels { get; set; }
        public string DocumentElementName { get; set; }
        public string DocumentElementClassName { get; set; }
        public int DocumentLeftXPixels { get; set; }
        public int DocumentTopYPixels { get; set; }
        public int DocumentWidthPixels { get; set; }
        public int DocumentHeightPixels { get; set; }
    }

    public class BrowserGetElementScreenBoundingRectResponse
    {
        public double ElementScreenLeftPixels { get; set; }
        public double ElementScreenRightPixels { get; set; }
        public double ElementScreenTopPixels { get; set; }
        public double ElementScreenBottomPixels { get; set; }
        public double ElementScreenCenterXPixels { get; set; }
        public double ElementScreenCenterYPixels { get; set; }
        public bool ElementIsOnscreen { get; set; }
        public string OffscreenDirection { get; set; }
    }

    public class BrowserExecuteJavaScriptOnElementResponse
    {
        public string JavaScriptResponse { get; set; }
    }

    public class BrowserOpenNewTabResponse
    {
        public string NewTabName { get; set; }
        public int NewTabIndex { get; set; }
    }

    public class BrowserGetTabsResponse
    {
        public int NumberOfTabs { get; set; }
        public string CurrentTabHandle { get; set; }
        public string BrowserTabsJSON { get; set; }
    }

    public class BrowserGetPageTextResponse
    {
        public string PageText { get; set; }
    }

    public class BrowserGetCurrentFrameWindowPixelCoordinateResponse
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
    }

    public class BrowserClearElementTextResponse
    {
        public string PreviousValue { get; set; }
    }

    public class BrowserWaitForElementToExistResponse
    {
        public bool ElementExists { get; set; }
        public double ElementHandle { get; set; }
    }

    public class BrowserWaitForElementToNotExistResponse
    {
        public bool ElementExistsBeforeWait { get; set; }
        public bool ElementExistsAfterWait { get; set; }
    }

    public class BrowserGetWebElementAtScreenCoordinatesResponse
    {
        public bool ElementExists { get; set; }
        public double ElementHandle { get; set; }
        public string ElementTagName { get; set; }
    }

    public class BrowserGetWebElementAtBrowserDocumentWindowCoordinatesResponse
    {
        public bool ElementExists { get; set; }
        public double ElementHandle { get; set; }
        public string ElementTagName { get; set; }
    }

    public class BrowserGetWebElementPropertiesAsListResponse
    {
        public int NumberOfElementsFound { get; set; }
        public int NumberOfElementsReturned { get; set; }
        public string ElementPropertiesJSON { get; set; }
    }

    public class IsBrowserInstanceOpenResponse
    {
        public bool IsBrowserInstanceOpen { get; set; }
        public string BrowserName { get; set; }
        public int BrowserMajorVersion { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Iaconnectwebbrowser;

    public partial class WorkflowManagedActions
    {
        public IaconnectwebbrowserActions Iaconnectwebbrowser(string connectionId) => new IaconnectwebbrowserActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public IaconnectwebbrowserTriggers Iaconnectwebbrowser(string connectionId) => new IaconnectwebbrowserTriggers(connectionId);
    }
}
