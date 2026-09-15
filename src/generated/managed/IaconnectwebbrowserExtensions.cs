//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Iaconnectwebbrowser
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class IaconnectwebbrowserActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserGetChromeBrowserVersionFromFileResponse> BrowserGetChromeBrowserVersionFromFile(Expression<Func<string>> browserGetChromeBrowserVersionFromFileworkflow, Expression<Func<string>> browserGetChromeBrowserVersionFromFilechromeBrowserEXE = null)
        {
            var apiCallPath = "/BrowserControl/GetChromeBrowserVersionFromFile";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserGetChromeBrowserVersionFromFile = new JObject();
            var browserGetChromeBrowserVersionFromFilepropCount = 0;
            if (browserGetChromeBrowserVersionFromFilechromeBrowserEXE != null)
            {
                browserGetChromeBrowserVersionFromFile["ChromeBrowserEXE"] = CSharpExpressionConverter.ConvertToken(browserGetChromeBrowserVersionFromFilechromeBrowserEXE);
                browserGetChromeBrowserVersionFromFilepropCount++;
            }

            browserGetChromeBrowserVersionFromFilepropCount++;
            browserGetChromeBrowserVersionFromFile["Workflow"] = CSharpExpressionConverter.ConvertToken(browserGetChromeBrowserVersionFromFileworkflow);
            if (browserGetChromeBrowserVersionFromFilepropCount > 0)
            {
                callPayload.Body = browserGetChromeBrowserVersionFromFile;
            }

            return new ApiConnectionAction<BrowserGetChromeBrowserVersionFromFileResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserGetChromeDriverFolderResponse> BrowserGetChromeDriverFolder(Expression<Func<string>> browserGetChromeDriverFolderdirectoryPath, Expression<Func<string>> browserGetChromeDriverFolderworkflow, Expression<Func<int>> browserGetChromeDriverFolderchromeMajorVersion = null, Expression<Func<string>> browserGetChromeDriverFolderchromeBrowserEXE = null)
        {
            var apiCallPath = "/BrowserControl/GetChromeDriverFolder";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserGetChromeDriverFolder = new JObject();
            var browserGetChromeDriverFolderpropCount = 0;
            browserGetChromeDriverFolderpropCount++;
            browserGetChromeDriverFolder["DirectoryPath"] = CSharpExpressionConverter.ConvertToken(browserGetChromeDriverFolderdirectoryPath);
            if (browserGetChromeDriverFolderchromeMajorVersion != null)
            {
                browserGetChromeDriverFolder["ChromeMajorVersion"] = CSharpExpressionConverter.ConvertToken(browserGetChromeDriverFolderchromeMajorVersion);
                browserGetChromeDriverFolderpropCount++;
            }

            if (browserGetChromeDriverFolderchromeBrowserEXE != null)
            {
                browserGetChromeDriverFolder["ChromeBrowserEXE"] = CSharpExpressionConverter.ConvertToken(browserGetChromeDriverFolderchromeBrowserEXE);
                browserGetChromeDriverFolderpropCount++;
            }

            browserGetChromeDriverFolderpropCount++;
            browserGetChromeDriverFolder["Workflow"] = CSharpExpressionConverter.ConvertToken(browserGetChromeDriverFolderworkflow);
            if (browserGetChromeDriverFolderpropCount > 0)
            {
                callPayload.Body = browserGetChromeDriverFolder;
            }

            return new ApiConnectionAction<BrowserGetChromeDriverFolderResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserDownloadSuitableChromeDriverFromInternetResponse> BrowserDownloadSuitableChromeDriverFromInternet(Expression<Func<string>> browserDownloadSuitableChromeDriverFromInternetchromeDriverDownloadParentFolder, Expression<Func<string>> browserDownloadSuitableChromeDriverFromInternetworkflow, Expression<Func<string>> browserDownloadSuitableChromeDriverFromInternetchromeBrowserEXE = null, Expression<Func<bool>> browserDownloadSuitableChromeDriverFromInternetattemptToLocateChromeDriverURLViaXMLIndex = null, Expression<Func<string>> browserDownloadSuitableChromeDriverFromInternetchromeDriverRootWebPageURL = null, Expression<Func<bool>> browserDownloadSuitableChromeDriverFromInternetattemptToLocateChromeDriverURLViaJSONIndex = null, Expression<Func<string>> browserDownloadSuitableChromeDriverFromInternetchromeDriverJSONIndexWebPageURL = null, Expression<Func<bool>> browserDownloadSuitableChromeDriverFromInternetprefer64bitChromeDriver = null)
        {
            var apiCallPath = "/BrowserControl/BrowserDownloadSuitableChromeDriverFromInternet";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserDownloadSuitableChromeDriverFromInternet = new JObject();
            var browserDownloadSuitableChromeDriverFromInternetpropCount = 0;
            if (browserDownloadSuitableChromeDriverFromInternetchromeBrowserEXE != null)
            {
                browserDownloadSuitableChromeDriverFromInternet["ChromeBrowserEXE"] = CSharpExpressionConverter.ConvertToken(browserDownloadSuitableChromeDriverFromInternetchromeBrowserEXE);
                browserDownloadSuitableChromeDriverFromInternetpropCount++;
            }

            browserDownloadSuitableChromeDriverFromInternetpropCount++;
            browserDownloadSuitableChromeDriverFromInternet["ChromeDriverDownloadParentFolder"] = CSharpExpressionConverter.ConvertToken(browserDownloadSuitableChromeDriverFromInternetchromeDriverDownloadParentFolder);
            if (browserDownloadSuitableChromeDriverFromInternetattemptToLocateChromeDriverURLViaXMLIndex != null)
            {
                if (browserDownloadSuitableChromeDriverFromInternetattemptToLocateChromeDriverURLViaXMLIndex != null)
                {
                    browserDownloadSuitableChromeDriverFromInternet["AttemptToLocateChromeDriverURLViaXMLIndex"] = CSharpExpressionConverter.ConvertToken(browserDownloadSuitableChromeDriverFromInternetattemptToLocateChromeDriverURLViaXMLIndex);
                    browserDownloadSuitableChromeDriverFromInternetpropCount++;
                }

                browserDownloadSuitableChromeDriverFromInternetpropCount++;
            }
            else
            {
                browserDownloadSuitableChromeDriverFromInternet["AttemptToLocateChromeDriverURLViaXMLIndex"] = true;
                browserDownloadSuitableChromeDriverFromInternetpropCount++;
            }

            if (browserDownloadSuitableChromeDriverFromInternetchromeDriverRootWebPageURL != null)
            {
                if (browserDownloadSuitableChromeDriverFromInternetchromeDriverRootWebPageURL != null)
                {
                    browserDownloadSuitableChromeDriverFromInternet["ChromeDriverRootWebPageURL"] = CSharpExpressionConverter.ConvertToken(browserDownloadSuitableChromeDriverFromInternetchromeDriverRootWebPageURL);
                    browserDownloadSuitableChromeDriverFromInternetpropCount++;
                }

                browserDownloadSuitableChromeDriverFromInternetpropCount++;
            }
            else
            {
                browserDownloadSuitableChromeDriverFromInternet["ChromeDriverRootWebPageURL"] = "https://chromedriver.storage.googleapis.com/";
                browserDownloadSuitableChromeDriverFromInternetpropCount++;
            }

            if (browserDownloadSuitableChromeDriverFromInternetattemptToLocateChromeDriverURLViaJSONIndex != null)
            {
                if (browserDownloadSuitableChromeDriverFromInternetattemptToLocateChromeDriverURLViaJSONIndex != null)
                {
                    browserDownloadSuitableChromeDriverFromInternet["AttemptToLocateChromeDriverURLViaJSONIndex"] = CSharpExpressionConverter.ConvertToken(browserDownloadSuitableChromeDriverFromInternetattemptToLocateChromeDriverURLViaJSONIndex);
                    browserDownloadSuitableChromeDriverFromInternetpropCount++;
                }

                browserDownloadSuitableChromeDriverFromInternetpropCount++;
            }
            else
            {
                browserDownloadSuitableChromeDriverFromInternet["AttemptToLocateChromeDriverURLViaJSONIndex"] = true;
                browserDownloadSuitableChromeDriverFromInternetpropCount++;
            }

            if (browserDownloadSuitableChromeDriverFromInternetchromeDriverJSONIndexWebPageURL != null)
            {
                if (browserDownloadSuitableChromeDriverFromInternetchromeDriverJSONIndexWebPageURL != null)
                {
                    browserDownloadSuitableChromeDriverFromInternet["ChromeDriverJSONIndexWebPageURL"] = CSharpExpressionConverter.ConvertToken(browserDownloadSuitableChromeDriverFromInternetchromeDriverJSONIndexWebPageURL);
                    browserDownloadSuitableChromeDriverFromInternetpropCount++;
                }

                browserDownloadSuitableChromeDriverFromInternetpropCount++;
            }
            else
            {
                browserDownloadSuitableChromeDriverFromInternet["ChromeDriverJSONIndexWebPageURL"] = "https://googlechromelabs.github.io/chrome-for-testing/latest-versions-per-milestone-with-downloads.json";
                browserDownloadSuitableChromeDriverFromInternetpropCount++;
            }

            if (browserDownloadSuitableChromeDriverFromInternetprefer64bitChromeDriver != null)
            {
                if (browserDownloadSuitableChromeDriverFromInternetprefer64bitChromeDriver != null)
                {
                    browserDownloadSuitableChromeDriverFromInternet["Prefer64bitChromeDriver"] = CSharpExpressionConverter.ConvertToken(browserDownloadSuitableChromeDriverFromInternetprefer64bitChromeDriver);
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
            browserDownloadSuitableChromeDriverFromInternet["Workflow"] = CSharpExpressionConverter.ConvertToken(browserDownloadSuitableChromeDriverFromInternetworkflow);
            if (browserDownloadSuitableChromeDriverFromInternetpropCount > 0)
            {
                callPayload.Body = browserDownloadSuitableChromeDriverFromInternet;
            }

            return new ApiConnectionAction<BrowserDownloadSuitableChromeDriverFromInternetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserIsSuitableChromeDriverAvailableResponse> BrowserIsSuitableChromeDriverAvailable(Expression<Func<string>> browserIsSuitableChromeDriverAvailableworkflow, Expression<Func<string>> browserIsSuitableChromeDriverAvailablechromeDriverFolder = null, Expression<Func<string>> browserIsSuitableChromeDriverAvailablechromeBrowserEXE = null)
        {
            var apiCallPath = "/BrowserControl/IsSuitableChromeDriverAvailable";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserIsSuitableChromeDriverAvailable = new JObject();
            var browserIsSuitableChromeDriverAvailablepropCount = 0;
            if (browserIsSuitableChromeDriverAvailablechromeDriverFolder != null)
            {
                browserIsSuitableChromeDriverAvailable["ChromeDriverFolder"] = CSharpExpressionConverter.ConvertToken(browserIsSuitableChromeDriverAvailablechromeDriverFolder);
                browserIsSuitableChromeDriverAvailablepropCount++;
            }

            if (browserIsSuitableChromeDriverAvailablechromeBrowserEXE != null)
            {
                browserIsSuitableChromeDriverAvailable["ChromeBrowserEXE"] = CSharpExpressionConverter.ConvertToken(browserIsSuitableChromeDriverAvailablechromeBrowserEXE);
                browserIsSuitableChromeDriverAvailablepropCount++;
            }

            browserIsSuitableChromeDriverAvailablepropCount++;
            browserIsSuitableChromeDriverAvailable["Workflow"] = CSharpExpressionConverter.ConvertToken(browserIsSuitableChromeDriverAvailableworkflow);
            if (browserIsSuitableChromeDriverAvailablepropCount > 0)
            {
                callPayload.Body = browserIsSuitableChromeDriverAvailable;
            }

            return new ApiConnectionAction<BrowserIsSuitableChromeDriverAvailableResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserUploadNewChromeDriver(Expression<Func<string>> browserUploadNewChromeDriverlocalChromeDriverFilePath, Expression<Func<string>> browserUploadNewChromeDriverworkflow, Expression<Func<bool>> browserUploadNewChromeDrivercompress = null, Expression<Func<int>> browserUploadNewChromeDriverchromeBrowserMajorVersion = null, Expression<Func<string>> browserUploadNewChromeDriverchromeDriverRootSaveFolder = null)
        {
            var apiCallPath = "/BrowserControl/UploadNewChromeDriver";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserUploadNewChromeDriver = new JObject();
            var browserUploadNewChromeDriverpropCount = 0;
            browserUploadNewChromeDriverpropCount++;
            browserUploadNewChromeDriver["LocalChromeDriverFilePath"] = CSharpExpressionConverter.ConvertToken(browserUploadNewChromeDriverlocalChromeDriverFilePath);
            if (browserUploadNewChromeDrivercompress != null)
            {
                if (browserUploadNewChromeDrivercompress != null)
                {
                    browserUploadNewChromeDriver["Compress"] = CSharpExpressionConverter.ConvertToken(browserUploadNewChromeDrivercompress);
                    browserUploadNewChromeDriverpropCount++;
                }

                browserUploadNewChromeDriverpropCount++;
            }
            else
            {
                browserUploadNewChromeDriver["Compress"] = false;
                browserUploadNewChromeDriverpropCount++;
            }

            if (browserUploadNewChromeDriverchromeBrowserMajorVersion != null)
            {
                browserUploadNewChromeDriver["ChromeBrowserMajorVersion"] = CSharpExpressionConverter.ConvertToken(browserUploadNewChromeDriverchromeBrowserMajorVersion);
                browserUploadNewChromeDriverpropCount++;
            }

            if (browserUploadNewChromeDriverchromeDriverRootSaveFolder != null)
            {
                browserUploadNewChromeDriver["ChromeDriverRootSaveFolder"] = CSharpExpressionConverter.ConvertToken(browserUploadNewChromeDriverchromeDriverRootSaveFolder);
                browserUploadNewChromeDriverpropCount++;
            }

            browserUploadNewChromeDriverpropCount++;
            browserUploadNewChromeDriver["Workflow"] = CSharpExpressionConverter.ConvertToken(browserUploadNewChromeDriverworkflow);
            if (browserUploadNewChromeDriverpropCount > 0)
            {
                callPayload.Body = browserUploadNewChromeDriver;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserOpenChromeResponse> BrowserOpenChrome(Expression<Func<string>> browserOpenChromeworkflow, Expression<Func<string>> browserOpenChromechromeDriverFolder = null, Expression<Func<bool>> browserOpenChromekillExistingChromeDriver = null, Expression<Func<string>> browserOpenChromeuserDataDir = null, Expression<Func<bool>> browserOpenChromeprintToDefaultPrinter = null, Expression<Func<string>> browserOpenChromedefaultDownloadDirectory = null, Expression<Func<bool>> browserOpenChromedownloadPDFInsteadOfOpening = null, Expression<Func<string>> browserOpenChromechromeDriverLogFilename = null, Expression<Func<string>> browserOpenChromelocalChromeDriverFolder = null, Expression<Func<string>> browserOpenChromechromeBrowserEXE = null, Expression<Func<bool>> browserOpenChromeignoreCertificateErrors = null, Expression<Func<string>> browserOpenChromeadditionalArguments = null, Expression<Func<bool>> browserOpenChromedoNothingIfChromeInstanceAlreadyOpen = null)
        {
            var apiCallPath = "/BrowserControl/OpenChrome";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserOpenChrome = new JObject();
            var browserOpenChromepropCount = 0;
            if (browserOpenChromechromeDriverFolder != null)
            {
                browserOpenChrome["ChromeDriverFolder"] = CSharpExpressionConverter.ConvertToken(browserOpenChromechromeDriverFolder);
                browserOpenChromepropCount++;
            }

            if (browserOpenChromekillExistingChromeDriver != null)
            {
                if (browserOpenChromekillExistingChromeDriver != null)
                {
                    browserOpenChrome["KillExistingChromeDriver"] = CSharpExpressionConverter.ConvertToken(browserOpenChromekillExistingChromeDriver);
                    browserOpenChromepropCount++;
                }

                browserOpenChromepropCount++;
            }
            else
            {
                browserOpenChrome["KillExistingChromeDriver"] = true;
                browserOpenChromepropCount++;
            }

            if (browserOpenChromeuserDataDir != null)
            {
                browserOpenChrome["UserDataDir"] = CSharpExpressionConverter.ConvertToken(browserOpenChromeuserDataDir);
                browserOpenChromepropCount++;
            }

            if (browserOpenChromeprintToDefaultPrinter != null)
            {
                if (browserOpenChromeprintToDefaultPrinter != null)
                {
                    browserOpenChrome["PrintToDefaultPrinter"] = CSharpExpressionConverter.ConvertToken(browserOpenChromeprintToDefaultPrinter);
                    browserOpenChromepropCount++;
                }

                browserOpenChromepropCount++;
            }
            else
            {
                browserOpenChrome["PrintToDefaultPrinter"] = true;
                browserOpenChromepropCount++;
            }

            if (browserOpenChromedefaultDownloadDirectory != null)
            {
                browserOpenChrome["DefaultDownloadDirectory"] = CSharpExpressionConverter.ConvertToken(browserOpenChromedefaultDownloadDirectory);
                browserOpenChromepropCount++;
            }

            if (browserOpenChromedownloadPDFInsteadOfOpening != null)
            {
                if (browserOpenChromedownloadPDFInsteadOfOpening != null)
                {
                    browserOpenChrome["DownloadPDFInsteadOfOpening"] = CSharpExpressionConverter.ConvertToken(browserOpenChromedownloadPDFInsteadOfOpening);
                    browserOpenChromepropCount++;
                }

                browserOpenChromepropCount++;
            }
            else
            {
                browserOpenChrome["DownloadPDFInsteadOfOpening"] = false;
                browserOpenChromepropCount++;
            }

            if (browserOpenChromechromeDriverLogFilename != null)
            {
                browserOpenChrome["ChromeDriverLogFilename"] = CSharpExpressionConverter.ConvertToken(browserOpenChromechromeDriverLogFilename);
                browserOpenChromepropCount++;
            }

            if (browserOpenChromelocalChromeDriverFolder != null)
            {
                browserOpenChrome["LocalChromeDriverFolder"] = CSharpExpressionConverter.ConvertToken(browserOpenChromelocalChromeDriverFolder);
                browserOpenChromepropCount++;
            }

            if (browserOpenChromechromeBrowserEXE != null)
            {
                browserOpenChrome["ChromeBrowserEXE"] = CSharpExpressionConverter.ConvertToken(browserOpenChromechromeBrowserEXE);
                browserOpenChromepropCount++;
            }

            if (browserOpenChromeignoreCertificateErrors != null)
            {
                if (browserOpenChromeignoreCertificateErrors != null)
                {
                    browserOpenChrome["IgnoreCertificateErrors"] = CSharpExpressionConverter.ConvertToken(browserOpenChromeignoreCertificateErrors);
                    browserOpenChromepropCount++;
                }

                browserOpenChromepropCount++;
            }
            else
            {
                browserOpenChrome["IgnoreCertificateErrors"] = false;
                browserOpenChromepropCount++;
            }

            if (browserOpenChromeadditionalArguments != null)
            {
                browserOpenChrome["AdditionalArguments"] = CSharpExpressionConverter.ConvertToken(browserOpenChromeadditionalArguments);
                browserOpenChromepropCount++;
            }

            if (browserOpenChromedoNothingIfChromeInstanceAlreadyOpen != null)
            {
                if (browserOpenChromedoNothingIfChromeInstanceAlreadyOpen != null)
                {
                    browserOpenChrome["DoNothingIfChromeInstanceAlreadyOpen"] = CSharpExpressionConverter.ConvertToken(browserOpenChromedoNothingIfChromeInstanceAlreadyOpen);
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
            browserOpenChrome["Workflow"] = CSharpExpressionConverter.ConvertToken(browserOpenChromeworkflow);
            if (browserOpenChromepropCount > 0)
            {
                callPayload.Body = browserOpenChrome;
            }

            return new ApiConnectionAction<BrowserOpenChromeResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserCloseChrome(Expression<Func<string>> browserCloseChromeworkflow, Expression<Func<bool>> browserCloseChromepurgeDynamicUserDataDir = null, Expression<Func<bool>> browserCloseChromepurgeStaticUserDataDir = null)
        {
            var apiCallPath = "/BrowserControl/CloseChrome";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserCloseChrome = new JObject();
            var browserCloseChromepropCount = 0;
            if (browserCloseChromepurgeDynamicUserDataDir != null)
            {
                if (browserCloseChromepurgeDynamicUserDataDir != null)
                {
                    browserCloseChrome["PurgeDynamicUserDataDir"] = CSharpExpressionConverter.ConvertToken(browserCloseChromepurgeDynamicUserDataDir);
                    browserCloseChromepropCount++;
                }

                browserCloseChromepropCount++;
            }
            else
            {
                browserCloseChrome["PurgeDynamicUserDataDir"] = true;
                browserCloseChromepropCount++;
            }

            if (browserCloseChromepurgeStaticUserDataDir != null)
            {
                if (browserCloseChromepurgeStaticUserDataDir != null)
                {
                    browserCloseChrome["PurgeStaticUserDataDir"] = CSharpExpressionConverter.ConvertToken(browserCloseChromepurgeStaticUserDataDir);
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
            browserCloseChrome["Workflow"] = CSharpExpressionConverter.ConvertToken(browserCloseChromeworkflow);
            if (browserCloseChromepropCount > 0)
            {
                callPayload.Body = browserCloseChrome;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserOpenInternetExplorer(Expression<Func<string>> browserOpenInternetExplorerworkflow, Expression<Func<string>> browserOpenInternetExploreriEDriverFolder = null, Expression<Func<bool>> browserOpenInternetExplorerkillExistingIEDriver = null, Expression<Func<bool>> browserOpenInternetExplorerkillExistingIE = null, Expression<Func<bool>> browserOpenInternetExplorercleanSession = null, Expression<Func<bool>> browserOpenInternetExplorerenableNativeEvents = null, Expression<Func<string>> browserOpenInternetExplorerwebDriverLogFile = null, Expression<Func<string>> browserOpenInternetExplorerwebDriverLogLevel = null, Expression<Func<bool>> browserOpenInternetExplorerdisableIEFirstRunCustomise = null, Expression<Func<string>> browserOpenInternetExploreradditionalArguments = null)
        {
            var apiCallPath = "/BrowserControl/OpenInternetExplorer";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserOpenInternetExplorer = new JObject();
            var browserOpenInternetExplorerpropCount = 0;
            if (browserOpenInternetExploreriEDriverFolder != null)
            {
                browserOpenInternetExplorer["IEDriverFolder"] = CSharpExpressionConverter.ConvertToken(browserOpenInternetExploreriEDriverFolder);
                browserOpenInternetExplorerpropCount++;
            }

            if (browserOpenInternetExplorerkillExistingIEDriver != null)
            {
                if (browserOpenInternetExplorerkillExistingIEDriver != null)
                {
                    browserOpenInternetExplorer["KillExistingIEDriver"] = CSharpExpressionConverter.ConvertToken(browserOpenInternetExplorerkillExistingIEDriver);
                    browserOpenInternetExplorerpropCount++;
                }

                browserOpenInternetExplorerpropCount++;
            }
            else
            {
                browserOpenInternetExplorer["KillExistingIEDriver"] = false;
                browserOpenInternetExplorerpropCount++;
            }

            if (browserOpenInternetExplorerkillExistingIE != null)
            {
                if (browserOpenInternetExplorerkillExistingIE != null)
                {
                    browserOpenInternetExplorer["KillExistingIE"] = CSharpExpressionConverter.ConvertToken(browserOpenInternetExplorerkillExistingIE);
                    browserOpenInternetExplorerpropCount++;
                }

                browserOpenInternetExplorerpropCount++;
            }
            else
            {
                browserOpenInternetExplorer["KillExistingIE"] = true;
                browserOpenInternetExplorerpropCount++;
            }

            if (browserOpenInternetExplorercleanSession != null)
            {
                if (browserOpenInternetExplorercleanSession != null)
                {
                    browserOpenInternetExplorer["CleanSession"] = CSharpExpressionConverter.ConvertToken(browserOpenInternetExplorercleanSession);
                    browserOpenInternetExplorerpropCount++;
                }

                browserOpenInternetExplorerpropCount++;
            }
            else
            {
                browserOpenInternetExplorer["CleanSession"] = false;
                browserOpenInternetExplorerpropCount++;
            }

            if (browserOpenInternetExplorerenableNativeEvents != null)
            {
                if (browserOpenInternetExplorerenableNativeEvents != null)
                {
                    browserOpenInternetExplorer["EnableNativeEvents"] = CSharpExpressionConverter.ConvertToken(browserOpenInternetExplorerenableNativeEvents);
                    browserOpenInternetExplorerpropCount++;
                }

                browserOpenInternetExplorerpropCount++;
            }
            else
            {
                browserOpenInternetExplorer["EnableNativeEvents"] = true;
                browserOpenInternetExplorerpropCount++;
            }

            if (browserOpenInternetExplorerwebDriverLogFile != null)
            {
                browserOpenInternetExplorer["WebDriverLogFile"] = CSharpExpressionConverter.ConvertToken(browserOpenInternetExplorerwebDriverLogFile);
                browserOpenInternetExplorerpropCount++;
            }

            if (browserOpenInternetExplorerwebDriverLogLevel != null)
            {
                browserOpenInternetExplorer["WebDriverLogLevel"] = CSharpExpressionConverter.ConvertToken(browserOpenInternetExplorerwebDriverLogLevel);
                browserOpenInternetExplorerpropCount++;
            }

            if (browserOpenInternetExplorerdisableIEFirstRunCustomise != null)
            {
                if (browserOpenInternetExplorerdisableIEFirstRunCustomise != null)
                {
                    browserOpenInternetExplorer["DisableIEFirstRunCustomise"] = CSharpExpressionConverter.ConvertToken(browserOpenInternetExplorerdisableIEFirstRunCustomise);
                    browserOpenInternetExplorerpropCount++;
                }

                browserOpenInternetExplorerpropCount++;
            }
            else
            {
                browserOpenInternetExplorer["DisableIEFirstRunCustomise"] = true;
                browserOpenInternetExplorerpropCount++;
            }

            if (browserOpenInternetExploreradditionalArguments != null)
            {
                browserOpenInternetExplorer["AdditionalArguments"] = CSharpExpressionConverter.ConvertToken(browserOpenInternetExploreradditionalArguments);
                browserOpenInternetExplorerpropCount++;
            }

            browserOpenInternetExplorerpropCount++;
            browserOpenInternetExplorer["Workflow"] = CSharpExpressionConverter.ConvertToken(browserOpenInternetExplorerworkflow);
            if (browserOpenInternetExplorerpropCount > 0)
            {
                callPayload.Body = browserOpenInternetExplorer;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserCloseInternetExplorer(Expression<Func<string>> browserCloseInternetExplorerworkflow, Expression<Func<bool>> browserCloseInternetExplorerunloadIEDriver = null)
        {
            var apiCallPath = "/BrowserControl/CloseInternetExplorer";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserCloseInternetExplorer = new JObject();
            var browserCloseInternetExplorerpropCount = 0;
            if (browserCloseInternetExplorerunloadIEDriver != null)
            {
                if (browserCloseInternetExplorerunloadIEDriver != null)
                {
                    browserCloseInternetExplorer["UnloadIEDriver"] = CSharpExpressionConverter.ConvertToken(browserCloseInternetExplorerunloadIEDriver);
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
            browserCloseInternetExplorer["Workflow"] = CSharpExpressionConverter.ConvertToken(browserCloseInternetExplorerworkflow);
            if (browserCloseInternetExplorerpropCount > 0)
            {
                callPayload.Body = browserCloseInternetExplorer;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserGetChromiumEdgeDriverFolderResponse> BrowserGetChromiumEdgeDriverFolder(Expression<Func<string>> browserGetChromiumEdgeDriverFolderdirectoryPath, Expression<Func<string>> browserGetChromiumEdgeDriverFolderworkflow, Expression<Func<int>> browserGetChromiumEdgeDriverFolderchromiumEdgeMajorVersion = null, Expression<Func<string>> browserGetChromiumEdgeDriverFolderchromiumEdgeBrowserEXE = null)
        {
            var apiCallPath = "/BrowserControl/GetChromiumEdgeDriverFolder";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserGetChromiumEdgeDriverFolder = new JObject();
            var browserGetChromiumEdgeDriverFolderpropCount = 0;
            browserGetChromiumEdgeDriverFolderpropCount++;
            browserGetChromiumEdgeDriverFolder["DirectoryPath"] = CSharpExpressionConverter.ConvertToken(browserGetChromiumEdgeDriverFolderdirectoryPath);
            if (browserGetChromiumEdgeDriverFolderchromiumEdgeMajorVersion != null)
            {
                browserGetChromiumEdgeDriverFolder["ChromiumEdgeMajorVersion"] = CSharpExpressionConverter.ConvertToken(browserGetChromiumEdgeDriverFolderchromiumEdgeMajorVersion);
                browserGetChromiumEdgeDriverFolderpropCount++;
            }

            if (browserGetChromiumEdgeDriverFolderchromiumEdgeBrowserEXE != null)
            {
                browserGetChromiumEdgeDriverFolder["ChromiumEdgeBrowserEXE"] = CSharpExpressionConverter.ConvertToken(browserGetChromiumEdgeDriverFolderchromiumEdgeBrowserEXE);
                browserGetChromiumEdgeDriverFolderpropCount++;
            }

            browserGetChromiumEdgeDriverFolderpropCount++;
            browserGetChromiumEdgeDriverFolder["Workflow"] = CSharpExpressionConverter.ConvertToken(browserGetChromiumEdgeDriverFolderworkflow);
            if (browserGetChromiumEdgeDriverFolderpropCount > 0)
            {
                callPayload.Body = browserGetChromiumEdgeDriverFolder;
            }

            return new ApiConnectionAction<BrowserGetChromiumEdgeDriverFolderResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserGetChromiumEdgeBrowserVersionFromFileResponse> BrowserGetChromiumEdgeBrowserVersionFromFile(Expression<Func<string>> browserGetChromiumEdgeBrowserVersionFromFileworkflow, Expression<Func<string>> browserGetChromiumEdgeBrowserVersionFromFilechromiumEdgeBrowserEXE = null)
        {
            var apiCallPath = "/BrowserControl/GetChromiumEdgeBrowserVersionFromFile";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserGetChromiumEdgeBrowserVersionFromFile = new JObject();
            var browserGetChromiumEdgeBrowserVersionFromFilepropCount = 0;
            if (browserGetChromiumEdgeBrowserVersionFromFilechromiumEdgeBrowserEXE != null)
            {
                browserGetChromiumEdgeBrowserVersionFromFile["ChromiumEdgeBrowserEXE"] = CSharpExpressionConverter.ConvertToken(browserGetChromiumEdgeBrowserVersionFromFilechromiumEdgeBrowserEXE);
                browserGetChromiumEdgeBrowserVersionFromFilepropCount++;
            }

            browserGetChromiumEdgeBrowserVersionFromFilepropCount++;
            browserGetChromiumEdgeBrowserVersionFromFile["Workflow"] = CSharpExpressionConverter.ConvertToken(browserGetChromiumEdgeBrowserVersionFromFileworkflow);
            if (browserGetChromiumEdgeBrowserVersionFromFilepropCount > 0)
            {
                callPayload.Body = browserGetChromiumEdgeBrowserVersionFromFile;
            }

            return new ApiConnectionAction<BrowserGetChromiumEdgeBrowserVersionFromFileResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserDownloadSuitableChromiumEdgeDriverFromInternetResponse> BrowserDownloadSuitableChromiumEdgeDriverFromInternet(Expression<Func<string>> browserDownloadSuitableChromiumEdgeDriverFromInternetchromiumEdgeDriverDownloadParentFolder, Expression<Func<string>> browserDownloadSuitableChromiumEdgeDriverFromInternetworkflow, Expression<Func<string>> browserDownloadSuitableChromiumEdgeDriverFromInternetchromiumEdgeBrowserEXE = null, Expression<Func<string>> browserDownloadSuitableChromiumEdgeDriverFromInternetchromiumEdgeDriverRootWebPageURL = null)
        {
            var apiCallPath = "/BrowserControl/BrowserDownloadSuitableChromiumEdgeDriverFromInternet";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserDownloadSuitableChromiumEdgeDriverFromInternet = new JObject();
            var browserDownloadSuitableChromiumEdgeDriverFromInternetpropCount = 0;
            if (browserDownloadSuitableChromiumEdgeDriverFromInternetchromiumEdgeBrowserEXE != null)
            {
                browserDownloadSuitableChromiumEdgeDriverFromInternet["ChromiumEdgeBrowserEXE"] = CSharpExpressionConverter.ConvertToken(browserDownloadSuitableChromiumEdgeDriverFromInternetchromiumEdgeBrowserEXE);
                browserDownloadSuitableChromiumEdgeDriverFromInternetpropCount++;
            }

            browserDownloadSuitableChromiumEdgeDriverFromInternetpropCount++;
            browserDownloadSuitableChromiumEdgeDriverFromInternet["ChromiumEdgeDriverDownloadParentFolder"] = CSharpExpressionConverter.ConvertToken(browserDownloadSuitableChromiumEdgeDriverFromInternetchromiumEdgeDriverDownloadParentFolder);
            if (browserDownloadSuitableChromiumEdgeDriverFromInternetchromiumEdgeDriverRootWebPageURL != null)
            {
                if (browserDownloadSuitableChromiumEdgeDriverFromInternetchromiumEdgeDriverRootWebPageURL != null)
                {
                    browserDownloadSuitableChromiumEdgeDriverFromInternet["ChromiumEdgeDriverRootWebPageURL"] = CSharpExpressionConverter.ConvertToken(browserDownloadSuitableChromiumEdgeDriverFromInternetchromiumEdgeDriverRootWebPageURL);
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
            browserDownloadSuitableChromiumEdgeDriverFromInternet["Workflow"] = CSharpExpressionConverter.ConvertToken(browserDownloadSuitableChromiumEdgeDriverFromInternetworkflow);
            if (browserDownloadSuitableChromiumEdgeDriverFromInternetpropCount > 0)
            {
                callPayload.Body = browserDownloadSuitableChromiumEdgeDriverFromInternet;
            }

            return new ApiConnectionAction<BrowserDownloadSuitableChromiumEdgeDriverFromInternetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserIsSuitableChromiumEdgeDriverAvailableResponse> BrowserIsSuitableChromiumEdgeDriverAvailable(Expression<Func<string>> browserIsSuitableChromiumEdgeDriverAvailableworkflow, Expression<Func<string>> browserIsSuitableChromiumEdgeDriverAvailablechromiumEdgeDriverFolder = null, Expression<Func<string>> browserIsSuitableChromiumEdgeDriverAvailablechromiumEdgeBrowserEXE = null)
        {
            var apiCallPath = "/BrowserControl/IsSuitableChromiumEdgeDriverAvailable";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserIsSuitableChromiumEdgeDriverAvailable = new JObject();
            var browserIsSuitableChromiumEdgeDriverAvailablepropCount = 0;
            if (browserIsSuitableChromiumEdgeDriverAvailablechromiumEdgeDriverFolder != null)
            {
                browserIsSuitableChromiumEdgeDriverAvailable["ChromiumEdgeDriverFolder"] = CSharpExpressionConverter.ConvertToken(browserIsSuitableChromiumEdgeDriverAvailablechromiumEdgeDriverFolder);
                browserIsSuitableChromiumEdgeDriverAvailablepropCount++;
            }

            if (browserIsSuitableChromiumEdgeDriverAvailablechromiumEdgeBrowserEXE != null)
            {
                browserIsSuitableChromiumEdgeDriverAvailable["ChromiumEdgeBrowserEXE"] = CSharpExpressionConverter.ConvertToken(browserIsSuitableChromiumEdgeDriverAvailablechromiumEdgeBrowserEXE);
                browserIsSuitableChromiumEdgeDriverAvailablepropCount++;
            }

            browserIsSuitableChromiumEdgeDriverAvailablepropCount++;
            browserIsSuitableChromiumEdgeDriverAvailable["Workflow"] = CSharpExpressionConverter.ConvertToken(browserIsSuitableChromiumEdgeDriverAvailableworkflow);
            if (browserIsSuitableChromiumEdgeDriverAvailablepropCount > 0)
            {
                callPayload.Body = browserIsSuitableChromiumEdgeDriverAvailable;
            }

            return new ApiConnectionAction<BrowserIsSuitableChromiumEdgeDriverAvailableResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserUploadNewChromiumEdgeDriver(Expression<Func<string>> browserUploadNewChromiumEdgeDriverlocalChromiumEdgeDriverFilePath, Expression<Func<string>> browserUploadNewChromiumEdgeDriverworkflow, Expression<Func<bool>> browserUploadNewChromiumEdgeDrivercompress = null, Expression<Func<int>> browserUploadNewChromiumEdgeDriverchromiumEdgeBrowserMajorVersion = null, Expression<Func<string>> browserUploadNewChromiumEdgeDriverchromiumEdgeDriverRootSaveFolder = null)
        {
            var apiCallPath = "/BrowserControl/UploadNewChromiumEdgeDriver";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserUploadNewChromiumEdgeDriver = new JObject();
            var browserUploadNewChromiumEdgeDriverpropCount = 0;
            browserUploadNewChromiumEdgeDriverpropCount++;
            browserUploadNewChromiumEdgeDriver["LocalChromiumEdgeDriverFilePath"] = CSharpExpressionConverter.ConvertToken(browserUploadNewChromiumEdgeDriverlocalChromiumEdgeDriverFilePath);
            if (browserUploadNewChromiumEdgeDrivercompress != null)
            {
                if (browserUploadNewChromiumEdgeDrivercompress != null)
                {
                    browserUploadNewChromiumEdgeDriver["Compress"] = CSharpExpressionConverter.ConvertToken(browserUploadNewChromiumEdgeDrivercompress);
                    browserUploadNewChromiumEdgeDriverpropCount++;
                }

                browserUploadNewChromiumEdgeDriverpropCount++;
            }
            else
            {
                browserUploadNewChromiumEdgeDriver["Compress"] = false;
                browserUploadNewChromiumEdgeDriverpropCount++;
            }

            if (browserUploadNewChromiumEdgeDriverchromiumEdgeBrowserMajorVersion != null)
            {
                browserUploadNewChromiumEdgeDriver["ChromiumEdgeBrowserMajorVersion"] = CSharpExpressionConverter.ConvertToken(browserUploadNewChromiumEdgeDriverchromiumEdgeBrowserMajorVersion);
                browserUploadNewChromiumEdgeDriverpropCount++;
            }

            if (browserUploadNewChromiumEdgeDriverchromiumEdgeDriverRootSaveFolder != null)
            {
                browserUploadNewChromiumEdgeDriver["ChromiumEdgeDriverRootSaveFolder"] = CSharpExpressionConverter.ConvertToken(browserUploadNewChromiumEdgeDriverchromiumEdgeDriverRootSaveFolder);
                browserUploadNewChromiumEdgeDriverpropCount++;
            }

            browserUploadNewChromiumEdgeDriverpropCount++;
            browserUploadNewChromiumEdgeDriver["Workflow"] = CSharpExpressionConverter.ConvertToken(browserUploadNewChromiumEdgeDriverworkflow);
            if (browserUploadNewChromiumEdgeDriverpropCount > 0)
            {
                callPayload.Body = browserUploadNewChromiumEdgeDriver;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserOpenChromiumEdgeResponse> BrowserOpenChromiumEdge(Expression<Func<string>> browserOpenChromiumEdgeworkflow, Expression<Func<string>> browserOpenChromiumEdgechromiumEdgeDriverFolder = null, Expression<Func<string>> browserOpenChromiumEdgeuserDataDir = null, Expression<Func<bool>> browserOpenChromiumEdgekillExistingChromiumEdgeDriver = null, Expression<Func<bool>> browserOpenChromiumEdgeprintToDefaultPrinter = null, Expression<Func<string>> browserOpenChromiumEdgedefaultDownloadDirectory = null, Expression<Func<bool>> browserOpenChromiumEdgedownloadPDFInsteadOfOpening = null, Expression<Func<string>> browserOpenChromiumEdgechromiumEdgeDriverLogFilename = null, Expression<Func<string>> browserOpenChromiumEdgelocalChromiumEdgeDriverFolder = null, Expression<Func<bool>> browserOpenChromiumEdgehideBrowserIsBeingAutomatedMessage = null, Expression<Func<string>> browserOpenChromiumEdgechromiumEdgeBrowserEXE = null, Expression<Func<bool>> browserOpenChromiumEdgeignoreCertificateErrors = null, Expression<Func<string>> browserOpenChromiumEdgeadditionalArguments = null, Expression<Func<bool>> browserOpenChromiumEdgedoNothingIfChromiumEdgeInstanceAlreadyOpen = null)
        {
            var apiCallPath = "/BrowserControl/OpenChromiumEdge";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserOpenChromiumEdge = new JObject();
            var browserOpenChromiumEdgepropCount = 0;
            if (browserOpenChromiumEdgechromiumEdgeDriverFolder != null)
            {
                browserOpenChromiumEdge["ChromiumEdgeDriverFolder"] = CSharpExpressionConverter.ConvertToken(browserOpenChromiumEdgechromiumEdgeDriverFolder);
                browserOpenChromiumEdgepropCount++;
            }

            if (browserOpenChromiumEdgeuserDataDir != null)
            {
                browserOpenChromiumEdge["UserDataDir"] = CSharpExpressionConverter.ConvertToken(browserOpenChromiumEdgeuserDataDir);
                browserOpenChromiumEdgepropCount++;
            }

            if (browserOpenChromiumEdgekillExistingChromiumEdgeDriver != null)
            {
                if (browserOpenChromiumEdgekillExistingChromiumEdgeDriver != null)
                {
                    browserOpenChromiumEdge["KillExistingChromiumEdgeDriver"] = CSharpExpressionConverter.ConvertToken(browserOpenChromiumEdgekillExistingChromiumEdgeDriver);
                    browserOpenChromiumEdgepropCount++;
                }

                browserOpenChromiumEdgepropCount++;
            }
            else
            {
                browserOpenChromiumEdge["KillExistingChromiumEdgeDriver"] = true;
                browserOpenChromiumEdgepropCount++;
            }

            if (browserOpenChromiumEdgeprintToDefaultPrinter != null)
            {
                if (browserOpenChromiumEdgeprintToDefaultPrinter != null)
                {
                    browserOpenChromiumEdge["PrintToDefaultPrinter"] = CSharpExpressionConverter.ConvertToken(browserOpenChromiumEdgeprintToDefaultPrinter);
                    browserOpenChromiumEdgepropCount++;
                }

                browserOpenChromiumEdgepropCount++;
            }
            else
            {
                browserOpenChromiumEdge["PrintToDefaultPrinter"] = true;
                browserOpenChromiumEdgepropCount++;
            }

            if (browserOpenChromiumEdgedefaultDownloadDirectory != null)
            {
                browserOpenChromiumEdge["DefaultDownloadDirectory"] = CSharpExpressionConverter.ConvertToken(browserOpenChromiumEdgedefaultDownloadDirectory);
                browserOpenChromiumEdgepropCount++;
            }

            if (browserOpenChromiumEdgedownloadPDFInsteadOfOpening != null)
            {
                if (browserOpenChromiumEdgedownloadPDFInsteadOfOpening != null)
                {
                    browserOpenChromiumEdge["DownloadPDFInsteadOfOpening"] = CSharpExpressionConverter.ConvertToken(browserOpenChromiumEdgedownloadPDFInsteadOfOpening);
                    browserOpenChromiumEdgepropCount++;
                }

                browserOpenChromiumEdgepropCount++;
            }
            else
            {
                browserOpenChromiumEdge["DownloadPDFInsteadOfOpening"] = false;
                browserOpenChromiumEdgepropCount++;
            }

            if (browserOpenChromiumEdgechromiumEdgeDriverLogFilename != null)
            {
                browserOpenChromiumEdge["ChromiumEdgeDriverLogFilename"] = CSharpExpressionConverter.ConvertToken(browserOpenChromiumEdgechromiumEdgeDriverLogFilename);
                browserOpenChromiumEdgepropCount++;
            }

            if (browserOpenChromiumEdgelocalChromiumEdgeDriverFolder != null)
            {
                browserOpenChromiumEdge["LocalChromiumEdgeDriverFolder"] = CSharpExpressionConverter.ConvertToken(browserOpenChromiumEdgelocalChromiumEdgeDriverFolder);
                browserOpenChromiumEdgepropCount++;
            }

            if (browserOpenChromiumEdgehideBrowserIsBeingAutomatedMessage != null)
            {
                if (browserOpenChromiumEdgehideBrowserIsBeingAutomatedMessage != null)
                {
                    browserOpenChromiumEdge["HideBrowserIsBeingAutomatedMessage"] = CSharpExpressionConverter.ConvertToken(browserOpenChromiumEdgehideBrowserIsBeingAutomatedMessage);
                    browserOpenChromiumEdgepropCount++;
                }

                browserOpenChromiumEdgepropCount++;
            }
            else
            {
                browserOpenChromiumEdge["HideBrowserIsBeingAutomatedMessage"] = true;
                browserOpenChromiumEdgepropCount++;
            }

            if (browserOpenChromiumEdgechromiumEdgeBrowserEXE != null)
            {
                browserOpenChromiumEdge["ChromiumEdgeBrowserEXE"] = CSharpExpressionConverter.ConvertToken(browserOpenChromiumEdgechromiumEdgeBrowserEXE);
                browserOpenChromiumEdgepropCount++;
            }

            if (browserOpenChromiumEdgeignoreCertificateErrors != null)
            {
                if (browserOpenChromiumEdgeignoreCertificateErrors != null)
                {
                    browserOpenChromiumEdge["IgnoreCertificateErrors"] = CSharpExpressionConverter.ConvertToken(browserOpenChromiumEdgeignoreCertificateErrors);
                    browserOpenChromiumEdgepropCount++;
                }

                browserOpenChromiumEdgepropCount++;
            }
            else
            {
                browserOpenChromiumEdge["IgnoreCertificateErrors"] = false;
                browserOpenChromiumEdgepropCount++;
            }

            if (browserOpenChromiumEdgeadditionalArguments != null)
            {
                browserOpenChromiumEdge["AdditionalArguments"] = CSharpExpressionConverter.ConvertToken(browserOpenChromiumEdgeadditionalArguments);
                browserOpenChromiumEdgepropCount++;
            }

            if (browserOpenChromiumEdgedoNothingIfChromiumEdgeInstanceAlreadyOpen != null)
            {
                if (browserOpenChromiumEdgedoNothingIfChromiumEdgeInstanceAlreadyOpen != null)
                {
                    browserOpenChromiumEdge["DoNothingIfChromiumEdgeInstanceAlreadyOpen"] = CSharpExpressionConverter.ConvertToken(browserOpenChromiumEdgedoNothingIfChromiumEdgeInstanceAlreadyOpen);
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
            browserOpenChromiumEdge["Workflow"] = CSharpExpressionConverter.ConvertToken(browserOpenChromiumEdgeworkflow);
            if (browserOpenChromiumEdgepropCount > 0)
            {
                callPayload.Body = browserOpenChromiumEdge;
            }

            return new ApiConnectionAction<BrowserOpenChromiumEdgeResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserCloseChromiumEdge(Expression<Func<string>> browserCloseChromiumEdgeworkflow, Expression<Func<bool>> browserCloseChromiumEdgepurgeDynamicUserDataDir = null, Expression<Func<bool>> browserCloseChromiumEdgepurgeStaticUserDataDir = null)
        {
            var apiCallPath = "/BrowserControl/CloseChromiumEdge";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserCloseChromiumEdge = new JObject();
            var browserCloseChromiumEdgepropCount = 0;
            if (browserCloseChromiumEdgepurgeDynamicUserDataDir != null)
            {
                if (browserCloseChromiumEdgepurgeDynamicUserDataDir != null)
                {
                    browserCloseChromiumEdge["PurgeDynamicUserDataDir"] = CSharpExpressionConverter.ConvertToken(browserCloseChromiumEdgepurgeDynamicUserDataDir);
                    browserCloseChromiumEdgepropCount++;
                }

                browserCloseChromiumEdgepropCount++;
            }
            else
            {
                browserCloseChromiumEdge["PurgeDynamicUserDataDir"] = true;
                browserCloseChromiumEdgepropCount++;
            }

            if (browserCloseChromiumEdgepurgeStaticUserDataDir != null)
            {
                if (browserCloseChromiumEdgepurgeStaticUserDataDir != null)
                {
                    browserCloseChromiumEdge["PurgeStaticUserDataDir"] = CSharpExpressionConverter.ConvertToken(browserCloseChromiumEdgepurgeStaticUserDataDir);
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
            browserCloseChromiumEdge["Workflow"] = CSharpExpressionConverter.ConvertToken(browserCloseChromiumEdgeworkflow);
            if (browserCloseChromiumEdgepropCount > 0)
            {
                callPayload.Body = browserCloseChromiumEdge;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserMaximise(Expression<Func<string>> browserMaximiseworkflow)
        {
            var apiCallPath = "/BrowserControl/MaximiseBrowser";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserMaximise = new JObject();
            var browserMaximisepropCount = 0;
            browserMaximisepropCount++;
            browserMaximise["Workflow"] = CSharpExpressionConverter.ConvertToken(browserMaximiseworkflow);
            if (browserMaximisepropCount > 0)
            {
                callPayload.Body = browserMaximise;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserMinimise(Expression<Func<string>> browserMinimiseworkflow)
        {
            var apiCallPath = "/BrowserControl/MinimiseBrowser";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserMinimise = new JObject();
            var browserMinimisepropCount = 0;
            browserMinimisepropCount++;
            browserMinimise["Workflow"] = CSharpExpressionConverter.ConvertToken(browserMinimiseworkflow);
            if (browserMinimisepropCount > 0)
            {
                callPayload.Body = browserMinimise;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserFullscreen(Expression<Func<string>> browserFullscreenworkflow)
        {
            var apiCallPath = "/BrowserControl/FullscreenBrowser";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserFullscreen = new JObject();
            var browserFullscreenpropCount = 0;
            browserFullscreenpropCount++;
            browserFullscreen["Workflow"] = CSharpExpressionConverter.ConvertToken(browserFullscreenworkflow);
            if (browserFullscreenpropCount > 0)
            {
                callPayload.Body = browserFullscreen;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserNormaliseBrowser(Expression<Func<string>> browserNormaliseBrowserworkflow, Expression<Func<int>> browserNormaliseBrowserx = null, Expression<Func<int>> browserNormaliseBrowsery = null, Expression<Func<int>> browserNormaliseBrowserwidth = null, Expression<Func<int>> browserNormaliseBrowserheight = null)
        {
            var apiCallPath = "/BrowserControl/NormaliseBrowser";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserNormaliseBrowser = new JObject();
            var browserNormaliseBrowserpropCount = 0;
            if (browserNormaliseBrowserx != null)
            {
                if (browserNormaliseBrowserx != null)
                {
                    browserNormaliseBrowser["X"] = CSharpExpressionConverter.ConvertToken(browserNormaliseBrowserx);
                    browserNormaliseBrowserpropCount++;
                }

                browserNormaliseBrowserpropCount++;
            }
            else
            {
                browserNormaliseBrowser["X"] = 20;
                browserNormaliseBrowserpropCount++;
            }

            if (browserNormaliseBrowsery != null)
            {
                if (browserNormaliseBrowsery != null)
                {
                    browserNormaliseBrowser["Y"] = CSharpExpressionConverter.ConvertToken(browserNormaliseBrowsery);
                    browserNormaliseBrowserpropCount++;
                }

                browserNormaliseBrowserpropCount++;
            }
            else
            {
                browserNormaliseBrowser["Y"] = 20;
                browserNormaliseBrowserpropCount++;
            }

            if (browserNormaliseBrowserwidth != null)
            {
                if (browserNormaliseBrowserwidth != null)
                {
                    browserNormaliseBrowser["Width"] = CSharpExpressionConverter.ConvertToken(browserNormaliseBrowserwidth);
                    browserNormaliseBrowserpropCount++;
                }

                browserNormaliseBrowserpropCount++;
            }
            else
            {
                browserNormaliseBrowser["Width"] = -40;
                browserNormaliseBrowserpropCount++;
            }

            if (browserNormaliseBrowserheight != null)
            {
                if (browserNormaliseBrowserheight != null)
                {
                    browserNormaliseBrowser["Height"] = CSharpExpressionConverter.ConvertToken(browserNormaliseBrowserheight);
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
            browserNormaliseBrowser["Workflow"] = CSharpExpressionConverter.ConvertToken(browserNormaliseBrowserworkflow);
            if (browserNormaliseBrowserpropCount > 0)
            {
                callPayload.Body = browserNormaliseBrowser;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserSetWindowSize(Expression<Func<int>> browserSetWindowSizewidth, Expression<Func<int>> browserSetWindowSizeheight, Expression<Func<string>> browserSetWindowSizeworkflow)
        {
            var apiCallPath = "/BrowserControl/SetBrowserWindowSize";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserSetWindowSize = new JObject();
            var browserSetWindowSizepropCount = 0;
            browserSetWindowSizepropCount++;
            browserSetWindowSize["Width"] = CSharpExpressionConverter.ConvertToken(browserSetWindowSizewidth);
            browserSetWindowSizepropCount++;
            browserSetWindowSize["Height"] = CSharpExpressionConverter.ConvertToken(browserSetWindowSizeheight);
            browserSetWindowSizepropCount++;
            browserSetWindowSize["Workflow"] = CSharpExpressionConverter.ConvertToken(browserSetWindowSizeworkflow);
            if (browserSetWindowSizepropCount > 0)
            {
                callPayload.Body = browserSetWindowSize;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserSetWindowPosition(Expression<Func<int>> browserSetWindowPositionx, Expression<Func<int>> browserSetWindowPositiony, Expression<Func<string>> browserSetWindowPositionworkflow)
        {
            var apiCallPath = "/BrowserControl/SetBrowserWindowPosition";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserSetWindowPosition = new JObject();
            var browserSetWindowPositionpropCount = 0;
            browserSetWindowPositionpropCount++;
            browserSetWindowPosition["X"] = CSharpExpressionConverter.ConvertToken(browserSetWindowPositionx);
            browserSetWindowPositionpropCount++;
            browserSetWindowPosition["Y"] = CSharpExpressionConverter.ConvertToken(browserSetWindowPositiony);
            browserSetWindowPositionpropCount++;
            browserSetWindowPosition["Workflow"] = CSharpExpressionConverter.ConvertToken(browserSetWindowPositionworkflow);
            if (browserSetWindowPositionpropCount > 0)
            {
                callPayload.Body = browserSetWindowPosition;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserSetTimeouts(Expression<Func<string>> browserSetTimeoutsworkflow, Expression<Func<double>> browserSetTimeoutselementWaitTimeoutSeconds = null, Expression<Func<double>> browserSetTimeoutspageLoadTimeoutSeconds = null)
        {
            var apiCallPath = "/BrowserControl/SetTimeouts";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserSetTimeouts = new JObject();
            var browserSetTimeoutspropCount = 0;
            if (browserSetTimeoutselementWaitTimeoutSeconds != null)
            {
                browserSetTimeouts["ElementWaitTimeoutSeconds"] = CSharpExpressionConverter.ConvertToken(browserSetTimeoutselementWaitTimeoutSeconds);
                browserSetTimeoutspropCount++;
            }

            if (browserSetTimeoutspageLoadTimeoutSeconds != null)
            {
                browserSetTimeouts["PageLoadTimeoutSeconds"] = CSharpExpressionConverter.ConvertToken(browserSetTimeoutspageLoadTimeoutSeconds);
                browserSetTimeoutspropCount++;
            }

            browserSetTimeoutspropCount++;
            browserSetTimeouts["Workflow"] = CSharpExpressionConverter.ConvertToken(browserSetTimeoutsworkflow);
            if (browserSetTimeoutspropCount > 0)
            {
                callPayload.Body = browserSetTimeouts;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserNavigateToURLResponse> BrowserNavigateToURL(Expression<Func<string>> browserNavigateToURLuRL, Expression<Func<string>> browserNavigateToURLworkflow)
        {
            var apiCallPath = "/BrowserControl/NavigateToURL";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserNavigateToURL = new JObject();
            var browserNavigateToURLpropCount = 0;
            browserNavigateToURLpropCount++;
            browserNavigateToURL["URL"] = CSharpExpressionConverter.ConvertToken(browserNavigateToURLuRL);
            browserNavigateToURLpropCount++;
            browserNavigateToURL["Workflow"] = CSharpExpressionConverter.ConvertToken(browserNavigateToURLworkflow);
            if (browserNavigateToURLpropCount > 0)
            {
                callPayload.Body = browserNavigateToURL;
            }

            return new ApiConnectionAction<BrowserNavigateToURLResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserRefreshPage(Expression<Func<string>> browserRefreshPageworkflow)
        {
            var apiCallPath = "/BrowserControl/RefreshPage";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserRefreshPage = new JObject();
            var browserRefreshPagepropCount = 0;
            browserRefreshPagepropCount++;
            browserRefreshPage["Workflow"] = CSharpExpressionConverter.ConvertToken(browserRefreshPageworkflow);
            if (browserRefreshPagepropCount > 0)
            {
                callPayload.Body = browserRefreshPage;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserResetAllElementHandles(Expression<Func<string>> browserResetAllElementHandlesworkflow)
        {
            var apiCallPath = "/BrowserControl/ResetAllElementHandles";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserResetAllElementHandles = new JObject();
            var browserResetAllElementHandlespropCount = 0;
            browserResetAllElementHandlespropCount++;
            browserResetAllElementHandles["Workflow"] = CSharpExpressionConverter.ConvertToken(browserResetAllElementHandlesworkflow);
            if (browserResetAllElementHandlespropCount > 0)
            {
                callPayload.Body = browserResetAllElementHandles;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserDoesElementExistResponse> BrowserDoesElementExist(Expression<Func<string>> browserDoesElementExistworkflow, Expression<Func<double>> browserDoesElementExistparentElementHandle = null, Expression<Func<double>> browserDoesElementExistsearchElementHandle = null, Expression<Func<string>> browserDoesElementExistsearchElementName = null, Expression<Func<string>> browserDoesElementExistsearchElementID = null, Expression<Func<string>> browserDoesElementExistsearchElementTagName = null, Expression<Func<string>> browserDoesElementExistsearchElementXPath = null, Expression<Func<string>> browserDoesElementExistsearchElementClassName = null, Expression<Func<string>> browserDoesElementExistsearchElementCSSSelector = null, Expression<Func<double>> browserDoesElementExistsearchElementIndex = null, Expression<Func<string>> browserDoesElementExistsearchElementMatchValue = null, Expression<Func<string>> browserDoesElementExistsearchElementMatchText = null, Expression<Func<string>> browserDoesElementExistsearchElementType = null, Expression<Func<double>> browserDoesElementExistsearchElementMinimumWidth = null, Expression<Func<double>> browserDoesElementExistsearchElementMinimumHeight = null, Expression<Func<double>> browserDoesElementExistsearchElementBoundingBoxLeft = null, Expression<Func<double>> browserDoesElementExistsearchElementBoundingBoxRight = null, Expression<Func<double>> browserDoesElementExistsearchElementBoundingBoxTop = null, Expression<Func<double>> browserDoesElementExistsearchElementBoundingBoxBottom = null, Expression<Func<bool>> browserDoesElementExistonlyElementTopLeftNeedsToBeInBoundingBox = null)
        {
            var apiCallPath = "/BrowserControl/DoesElementExist";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserDoesElementExist = new JObject();
            var browserDoesElementExistpropCount = 0;
            if (browserDoesElementExistparentElementHandle != null)
            {
                browserDoesElementExist["ParentElementHandle"] = CSharpExpressionConverter.ConvertToken(browserDoesElementExistparentElementHandle);
                browserDoesElementExistpropCount++;
            }

            if (browserDoesElementExistsearchElementHandle != null)
            {
                browserDoesElementExist["SearchElementHandle"] = CSharpExpressionConverter.ConvertToken(browserDoesElementExistsearchElementHandle);
                browserDoesElementExistpropCount++;
            }

            if (browserDoesElementExistsearchElementName != null)
            {
                browserDoesElementExist["SearchElementName"] = CSharpExpressionConverter.ConvertToken(browserDoesElementExistsearchElementName);
                browserDoesElementExistpropCount++;
            }

            if (browserDoesElementExistsearchElementID != null)
            {
                browserDoesElementExist["SearchElementID"] = CSharpExpressionConverter.ConvertToken(browserDoesElementExistsearchElementID);
                browserDoesElementExistpropCount++;
            }

            if (browserDoesElementExistsearchElementTagName != null)
            {
                browserDoesElementExist["SearchElementTagName"] = CSharpExpressionConverter.ConvertToken(browserDoesElementExistsearchElementTagName);
                browserDoesElementExistpropCount++;
            }

            if (browserDoesElementExistsearchElementXPath != null)
            {
                browserDoesElementExist["SearchElementXPath"] = CSharpExpressionConverter.ConvertToken(browserDoesElementExistsearchElementXPath);
                browserDoesElementExistpropCount++;
            }

            if (browserDoesElementExistsearchElementClassName != null)
            {
                browserDoesElementExist["SearchElementClassName"] = CSharpExpressionConverter.ConvertToken(browserDoesElementExistsearchElementClassName);
                browserDoesElementExistpropCount++;
            }

            if (browserDoesElementExistsearchElementCSSSelector != null)
            {
                browserDoesElementExist["SearchElementCSSSelector"] = CSharpExpressionConverter.ConvertToken(browserDoesElementExistsearchElementCSSSelector);
                browserDoesElementExistpropCount++;
            }

            if (browserDoesElementExistsearchElementIndex != null)
            {
                if (browserDoesElementExistsearchElementIndex != null)
                {
                    browserDoesElementExist["SearchElementIndex"] = CSharpExpressionConverter.ConvertToken(browserDoesElementExistsearchElementIndex);
                    browserDoesElementExistpropCount++;
                }

                browserDoesElementExistpropCount++;
            }
            else
            {
                browserDoesElementExist["SearchElementIndex"] = 1;
                browserDoesElementExistpropCount++;
            }

            if (browserDoesElementExistsearchElementMatchValue != null)
            {
                browserDoesElementExist["SearchElementMatchValue"] = CSharpExpressionConverter.ConvertToken(browserDoesElementExistsearchElementMatchValue);
                browserDoesElementExistpropCount++;
            }

            if (browserDoesElementExistsearchElementMatchText != null)
            {
                browserDoesElementExist["SearchElementMatchText"] = CSharpExpressionConverter.ConvertToken(browserDoesElementExistsearchElementMatchText);
                browserDoesElementExistpropCount++;
            }

            if (browserDoesElementExistsearchElementType != null)
            {
                browserDoesElementExist["SearchElementType"] = CSharpExpressionConverter.ConvertToken(browserDoesElementExistsearchElementType);
                browserDoesElementExistpropCount++;
            }

            if (browserDoesElementExistsearchElementMinimumWidth != null)
            {
                if (browserDoesElementExistsearchElementMinimumWidth != null)
                {
                    browserDoesElementExist["SearchElementMinimumWidth"] = CSharpExpressionConverter.ConvertToken(browserDoesElementExistsearchElementMinimumWidth);
                    browserDoesElementExistpropCount++;
                }

                browserDoesElementExistpropCount++;
            }
            else
            {
                browserDoesElementExist["SearchElementMinimumWidth"] = 1;
                browserDoesElementExistpropCount++;
            }

            if (browserDoesElementExistsearchElementMinimumHeight != null)
            {
                if (browserDoesElementExistsearchElementMinimumHeight != null)
                {
                    browserDoesElementExist["SearchElementMinimumHeight"] = CSharpExpressionConverter.ConvertToken(browserDoesElementExistsearchElementMinimumHeight);
                    browserDoesElementExistpropCount++;
                }

                browserDoesElementExistpropCount++;
            }
            else
            {
                browserDoesElementExist["SearchElementMinimumHeight"] = 1;
                browserDoesElementExistpropCount++;
            }

            if (browserDoesElementExistsearchElementBoundingBoxLeft != null)
            {
                if (browserDoesElementExistsearchElementBoundingBoxLeft != null)
                {
                    browserDoesElementExist["SearchElementBoundingBoxLeft"] = CSharpExpressionConverter.ConvertToken(browserDoesElementExistsearchElementBoundingBoxLeft);
                    browserDoesElementExistpropCount++;
                }

                browserDoesElementExistpropCount++;
            }
            else
            {
                browserDoesElementExist["SearchElementBoundingBoxLeft"] = -99999;
                browserDoesElementExistpropCount++;
            }

            if (browserDoesElementExistsearchElementBoundingBoxRight != null)
            {
                if (browserDoesElementExistsearchElementBoundingBoxRight != null)
                {
                    browserDoesElementExist["SearchElementBoundingBoxRight"] = CSharpExpressionConverter.ConvertToken(browserDoesElementExistsearchElementBoundingBoxRight);
                    browserDoesElementExistpropCount++;
                }

                browserDoesElementExistpropCount++;
            }
            else
            {
                browserDoesElementExist["SearchElementBoundingBoxRight"] = 99999;
                browserDoesElementExistpropCount++;
            }

            if (browserDoesElementExistsearchElementBoundingBoxTop != null)
            {
                if (browserDoesElementExistsearchElementBoundingBoxTop != null)
                {
                    browserDoesElementExist["SearchElementBoundingBoxTop"] = CSharpExpressionConverter.ConvertToken(browserDoesElementExistsearchElementBoundingBoxTop);
                    browserDoesElementExistpropCount++;
                }

                browserDoesElementExistpropCount++;
            }
            else
            {
                browserDoesElementExist["SearchElementBoundingBoxTop"] = -99999;
                browserDoesElementExistpropCount++;
            }

            if (browserDoesElementExistsearchElementBoundingBoxBottom != null)
            {
                if (browserDoesElementExistsearchElementBoundingBoxBottom != null)
                {
                    browserDoesElementExist["SearchElementBoundingBoxBottom"] = CSharpExpressionConverter.ConvertToken(browserDoesElementExistsearchElementBoundingBoxBottom);
                    browserDoesElementExistpropCount++;
                }

                browserDoesElementExistpropCount++;
            }
            else
            {
                browserDoesElementExist["SearchElementBoundingBoxBottom"] = 99999;
                browserDoesElementExistpropCount++;
            }

            if (browserDoesElementExistonlyElementTopLeftNeedsToBeInBoundingBox != null)
            {
                if (browserDoesElementExistonlyElementTopLeftNeedsToBeInBoundingBox != null)
                {
                    browserDoesElementExist["OnlyElementTopLeftNeedsToBeInBoundingBox"] = CSharpExpressionConverter.ConvertToken(browserDoesElementExistonlyElementTopLeftNeedsToBeInBoundingBox);
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
            browserDoesElementExist["Workflow"] = CSharpExpressionConverter.ConvertToken(browserDoesElementExistworkflow);
            if (browserDoesElementExistpropCount > 0)
            {
                callPayload.Body = browserDoesElementExist;
            }

            return new ApiConnectionAction<BrowserDoesElementExistResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserCreateHandleToElementResponse> BrowserCreateHandleToElement(Expression<Func<string>> browserCreateHandleToElementworkflow, Expression<Func<double>> browserCreateHandleToElementparentElementHandle = null, Expression<Func<double>> browserCreateHandleToElementsearchElementHandle = null, Expression<Func<string>> browserCreateHandleToElementsearchElementName = null, Expression<Func<string>> browserCreateHandleToElementsearchElementID = null, Expression<Func<string>> browserCreateHandleToElementsearchElementTagName = null, Expression<Func<string>> browserCreateHandleToElementsearchElementXPath = null, Expression<Func<string>> browserCreateHandleToElementsearchElementClassName = null, Expression<Func<string>> browserCreateHandleToElementsearchElementCSSSelector = null, Expression<Func<double>> browserCreateHandleToElementsearchElementIndex = null, Expression<Func<string>> browserCreateHandleToElementsearchElementMatchValue = null, Expression<Func<string>> browserCreateHandleToElementsearchElementMatchText = null, Expression<Func<string>> browserCreateHandleToElementsearchElementType = null, Expression<Func<double>> browserCreateHandleToElementsearchElementMinimumWidth = null, Expression<Func<double>> browserCreateHandleToElementsearchElementMinimumHeight = null, Expression<Func<double>> browserCreateHandleToElementsearchElementBoundingBoxLeft = null, Expression<Func<double>> browserCreateHandleToElementsearchElementBoundingBoxRight = null, Expression<Func<double>> browserCreateHandleToElementsearchElementBoundingBoxTop = null, Expression<Func<double>> browserCreateHandleToElementsearchElementBoundingBoxBottom = null, Expression<Func<bool>> browserCreateHandleToElementonlyElementTopLeftNeedsToBeInBoundingBox = null)
        {
            var apiCallPath = "/BrowserControl/CreateHandleToElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserCreateHandleToElement = new JObject();
            var browserCreateHandleToElementpropCount = 0;
            if (browserCreateHandleToElementparentElementHandle != null)
            {
                browserCreateHandleToElement["ParentElementHandle"] = CSharpExpressionConverter.ConvertToken(browserCreateHandleToElementparentElementHandle);
                browserCreateHandleToElementpropCount++;
            }

            if (browserCreateHandleToElementsearchElementHandle != null)
            {
                browserCreateHandleToElement["SearchElementHandle"] = CSharpExpressionConverter.ConvertToken(browserCreateHandleToElementsearchElementHandle);
                browserCreateHandleToElementpropCount++;
            }

            if (browserCreateHandleToElementsearchElementName != null)
            {
                browserCreateHandleToElement["SearchElementName"] = CSharpExpressionConverter.ConvertToken(browserCreateHandleToElementsearchElementName);
                browserCreateHandleToElementpropCount++;
            }

            if (browserCreateHandleToElementsearchElementID != null)
            {
                browserCreateHandleToElement["SearchElementID"] = CSharpExpressionConverter.ConvertToken(browserCreateHandleToElementsearchElementID);
                browserCreateHandleToElementpropCount++;
            }

            if (browserCreateHandleToElementsearchElementTagName != null)
            {
                browserCreateHandleToElement["SearchElementTagName"] = CSharpExpressionConverter.ConvertToken(browserCreateHandleToElementsearchElementTagName);
                browserCreateHandleToElementpropCount++;
            }

            if (browserCreateHandleToElementsearchElementXPath != null)
            {
                browserCreateHandleToElement["SearchElementXPath"] = CSharpExpressionConverter.ConvertToken(browserCreateHandleToElementsearchElementXPath);
                browserCreateHandleToElementpropCount++;
            }

            if (browserCreateHandleToElementsearchElementClassName != null)
            {
                browserCreateHandleToElement["SearchElementClassName"] = CSharpExpressionConverter.ConvertToken(browserCreateHandleToElementsearchElementClassName);
                browserCreateHandleToElementpropCount++;
            }

            if (browserCreateHandleToElementsearchElementCSSSelector != null)
            {
                browserCreateHandleToElement["SearchElementCSSSelector"] = CSharpExpressionConverter.ConvertToken(browserCreateHandleToElementsearchElementCSSSelector);
                browserCreateHandleToElementpropCount++;
            }

            if (browserCreateHandleToElementsearchElementIndex != null)
            {
                if (browserCreateHandleToElementsearchElementIndex != null)
                {
                    browserCreateHandleToElement["SearchElementIndex"] = CSharpExpressionConverter.ConvertToken(browserCreateHandleToElementsearchElementIndex);
                    browserCreateHandleToElementpropCount++;
                }

                browserCreateHandleToElementpropCount++;
            }
            else
            {
                browserCreateHandleToElement["SearchElementIndex"] = 1;
                browserCreateHandleToElementpropCount++;
            }

            if (browserCreateHandleToElementsearchElementMatchValue != null)
            {
                browserCreateHandleToElement["SearchElementMatchValue"] = CSharpExpressionConverter.ConvertToken(browserCreateHandleToElementsearchElementMatchValue);
                browserCreateHandleToElementpropCount++;
            }

            if (browserCreateHandleToElementsearchElementMatchText != null)
            {
                browserCreateHandleToElement["SearchElementMatchText"] = CSharpExpressionConverter.ConvertToken(browserCreateHandleToElementsearchElementMatchText);
                browserCreateHandleToElementpropCount++;
            }

            if (browserCreateHandleToElementsearchElementType != null)
            {
                browserCreateHandleToElement["SearchElementType"] = CSharpExpressionConverter.ConvertToken(browserCreateHandleToElementsearchElementType);
                browserCreateHandleToElementpropCount++;
            }

            if (browserCreateHandleToElementsearchElementMinimumWidth != null)
            {
                if (browserCreateHandleToElementsearchElementMinimumWidth != null)
                {
                    browserCreateHandleToElement["SearchElementMinimumWidth"] = CSharpExpressionConverter.ConvertToken(browserCreateHandleToElementsearchElementMinimumWidth);
                    browserCreateHandleToElementpropCount++;
                }

                browserCreateHandleToElementpropCount++;
            }
            else
            {
                browserCreateHandleToElement["SearchElementMinimumWidth"] = 1;
                browserCreateHandleToElementpropCount++;
            }

            if (browserCreateHandleToElementsearchElementMinimumHeight != null)
            {
                if (browserCreateHandleToElementsearchElementMinimumHeight != null)
                {
                    browserCreateHandleToElement["SearchElementMinimumHeight"] = CSharpExpressionConverter.ConvertToken(browserCreateHandleToElementsearchElementMinimumHeight);
                    browserCreateHandleToElementpropCount++;
                }

                browserCreateHandleToElementpropCount++;
            }
            else
            {
                browserCreateHandleToElement["SearchElementMinimumHeight"] = 1;
                browserCreateHandleToElementpropCount++;
            }

            if (browserCreateHandleToElementsearchElementBoundingBoxLeft != null)
            {
                if (browserCreateHandleToElementsearchElementBoundingBoxLeft != null)
                {
                    browserCreateHandleToElement["SearchElementBoundingBoxLeft"] = CSharpExpressionConverter.ConvertToken(browserCreateHandleToElementsearchElementBoundingBoxLeft);
                    browserCreateHandleToElementpropCount++;
                }

                browserCreateHandleToElementpropCount++;
            }
            else
            {
                browserCreateHandleToElement["SearchElementBoundingBoxLeft"] = -99999;
                browserCreateHandleToElementpropCount++;
            }

            if (browserCreateHandleToElementsearchElementBoundingBoxRight != null)
            {
                if (browserCreateHandleToElementsearchElementBoundingBoxRight != null)
                {
                    browserCreateHandleToElement["SearchElementBoundingBoxRight"] = CSharpExpressionConverter.ConvertToken(browserCreateHandleToElementsearchElementBoundingBoxRight);
                    browserCreateHandleToElementpropCount++;
                }

                browserCreateHandleToElementpropCount++;
            }
            else
            {
                browserCreateHandleToElement["SearchElementBoundingBoxRight"] = 99999;
                browserCreateHandleToElementpropCount++;
            }

            if (browserCreateHandleToElementsearchElementBoundingBoxTop != null)
            {
                if (browserCreateHandleToElementsearchElementBoundingBoxTop != null)
                {
                    browserCreateHandleToElement["SearchElementBoundingBoxTop"] = CSharpExpressionConverter.ConvertToken(browserCreateHandleToElementsearchElementBoundingBoxTop);
                    browserCreateHandleToElementpropCount++;
                }

                browserCreateHandleToElementpropCount++;
            }
            else
            {
                browserCreateHandleToElement["SearchElementBoundingBoxTop"] = -99999;
                browserCreateHandleToElementpropCount++;
            }

            if (browserCreateHandleToElementsearchElementBoundingBoxBottom != null)
            {
                if (browserCreateHandleToElementsearchElementBoundingBoxBottom != null)
                {
                    browserCreateHandleToElement["SearchElementBoundingBoxBottom"] = CSharpExpressionConverter.ConvertToken(browserCreateHandleToElementsearchElementBoundingBoxBottom);
                    browserCreateHandleToElementpropCount++;
                }

                browserCreateHandleToElementpropCount++;
            }
            else
            {
                browserCreateHandleToElement["SearchElementBoundingBoxBottom"] = 99999;
                browserCreateHandleToElementpropCount++;
            }

            if (browserCreateHandleToElementonlyElementTopLeftNeedsToBeInBoundingBox != null)
            {
                if (browserCreateHandleToElementonlyElementTopLeftNeedsToBeInBoundingBox != null)
                {
                    browserCreateHandleToElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = CSharpExpressionConverter.ConvertToken(browserCreateHandleToElementonlyElementTopLeftNeedsToBeInBoundingBox);
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
            browserCreateHandleToElement["Workflow"] = CSharpExpressionConverter.ConvertToken(browserCreateHandleToElementworkflow);
            if (browserCreateHandleToElementpropCount > 0)
            {
                callPayload.Body = browserCreateHandleToElement;
            }

            return new ApiConnectionAction<BrowserCreateHandleToElementResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserCreateHandleToParentElementResponse> BrowserCreateHandleToParentElement(Expression<Func<string>> browserCreateHandleToParentElementworkflow, Expression<Func<double>> browserCreateHandleToParentElementparentElementHandle = null, Expression<Func<double>> browserCreateHandleToParentElementsearchElementHandle = null, Expression<Func<string>> browserCreateHandleToParentElementsearchElementName = null, Expression<Func<string>> browserCreateHandleToParentElementsearchElementID = null, Expression<Func<string>> browserCreateHandleToParentElementsearchElementTagName = null, Expression<Func<string>> browserCreateHandleToParentElementsearchElementXPath = null, Expression<Func<string>> browserCreateHandleToParentElementsearchElementClassName = null, Expression<Func<string>> browserCreateHandleToParentElementsearchElementCSSSelector = null, Expression<Func<double>> browserCreateHandleToParentElementsearchElementIndex = null, Expression<Func<string>> browserCreateHandleToParentElementsearchElementMatchValue = null, Expression<Func<string>> browserCreateHandleToParentElementsearchElementMatchText = null, Expression<Func<string>> browserCreateHandleToParentElementsearchElementType = null, Expression<Func<double>> browserCreateHandleToParentElementsearchElementMinimumWidth = null, Expression<Func<double>> browserCreateHandleToParentElementsearchElementMinimumHeight = null, Expression<Func<double>> browserCreateHandleToParentElementsearchElementBoundingBoxLeft = null, Expression<Func<double>> browserCreateHandleToParentElementsearchElementBoundingBoxRight = null, Expression<Func<double>> browserCreateHandleToParentElementsearchElementBoundingBoxTop = null, Expression<Func<double>> browserCreateHandleToParentElementsearchElementBoundingBoxBottom = null, Expression<Func<bool>> browserCreateHandleToParentElementonlyElementTopLeftNeedsToBeInBoundingBox = null)
        {
            var apiCallPath = "/BrowserControl/CreateHandleToParentElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserCreateHandleToParentElement = new JObject();
            var browserCreateHandleToParentElementpropCount = 0;
            if (browserCreateHandleToParentElementparentElementHandle != null)
            {
                browserCreateHandleToParentElement["ParentElementHandle"] = CSharpExpressionConverter.ConvertToken(browserCreateHandleToParentElementparentElementHandle);
                browserCreateHandleToParentElementpropCount++;
            }

            if (browserCreateHandleToParentElementsearchElementHandle != null)
            {
                browserCreateHandleToParentElement["SearchElementHandle"] = CSharpExpressionConverter.ConvertToken(browserCreateHandleToParentElementsearchElementHandle);
                browserCreateHandleToParentElementpropCount++;
            }

            if (browserCreateHandleToParentElementsearchElementName != null)
            {
                browserCreateHandleToParentElement["SearchElementName"] = CSharpExpressionConverter.ConvertToken(browserCreateHandleToParentElementsearchElementName);
                browserCreateHandleToParentElementpropCount++;
            }

            if (browserCreateHandleToParentElementsearchElementID != null)
            {
                browserCreateHandleToParentElement["SearchElementID"] = CSharpExpressionConverter.ConvertToken(browserCreateHandleToParentElementsearchElementID);
                browserCreateHandleToParentElementpropCount++;
            }

            if (browserCreateHandleToParentElementsearchElementTagName != null)
            {
                browserCreateHandleToParentElement["SearchElementTagName"] = CSharpExpressionConverter.ConvertToken(browserCreateHandleToParentElementsearchElementTagName);
                browserCreateHandleToParentElementpropCount++;
            }

            if (browserCreateHandleToParentElementsearchElementXPath != null)
            {
                browserCreateHandleToParentElement["SearchElementXPath"] = CSharpExpressionConverter.ConvertToken(browserCreateHandleToParentElementsearchElementXPath);
                browserCreateHandleToParentElementpropCount++;
            }

            if (browserCreateHandleToParentElementsearchElementClassName != null)
            {
                browserCreateHandleToParentElement["SearchElementClassName"] = CSharpExpressionConverter.ConvertToken(browserCreateHandleToParentElementsearchElementClassName);
                browserCreateHandleToParentElementpropCount++;
            }

            if (browserCreateHandleToParentElementsearchElementCSSSelector != null)
            {
                browserCreateHandleToParentElement["SearchElementCSSSelector"] = CSharpExpressionConverter.ConvertToken(browserCreateHandleToParentElementsearchElementCSSSelector);
                browserCreateHandleToParentElementpropCount++;
            }

            if (browserCreateHandleToParentElementsearchElementIndex != null)
            {
                if (browserCreateHandleToParentElementsearchElementIndex != null)
                {
                    browserCreateHandleToParentElement["SearchElementIndex"] = CSharpExpressionConverter.ConvertToken(browserCreateHandleToParentElementsearchElementIndex);
                    browserCreateHandleToParentElementpropCount++;
                }

                browserCreateHandleToParentElementpropCount++;
            }
            else
            {
                browserCreateHandleToParentElement["SearchElementIndex"] = 1;
                browserCreateHandleToParentElementpropCount++;
            }

            if (browserCreateHandleToParentElementsearchElementMatchValue != null)
            {
                browserCreateHandleToParentElement["SearchElementMatchValue"] = CSharpExpressionConverter.ConvertToken(browserCreateHandleToParentElementsearchElementMatchValue);
                browserCreateHandleToParentElementpropCount++;
            }

            if (browserCreateHandleToParentElementsearchElementMatchText != null)
            {
                browserCreateHandleToParentElement["SearchElementMatchText"] = CSharpExpressionConverter.ConvertToken(browserCreateHandleToParentElementsearchElementMatchText);
                browserCreateHandleToParentElementpropCount++;
            }

            if (browserCreateHandleToParentElementsearchElementType != null)
            {
                browserCreateHandleToParentElement["SearchElementType"] = CSharpExpressionConverter.ConvertToken(browserCreateHandleToParentElementsearchElementType);
                browserCreateHandleToParentElementpropCount++;
            }

            if (browserCreateHandleToParentElementsearchElementMinimumWidth != null)
            {
                if (browserCreateHandleToParentElementsearchElementMinimumWidth != null)
                {
                    browserCreateHandleToParentElement["SearchElementMinimumWidth"] = CSharpExpressionConverter.ConvertToken(browserCreateHandleToParentElementsearchElementMinimumWidth);
                    browserCreateHandleToParentElementpropCount++;
                }

                browserCreateHandleToParentElementpropCount++;
            }
            else
            {
                browserCreateHandleToParentElement["SearchElementMinimumWidth"] = 1;
                browserCreateHandleToParentElementpropCount++;
            }

            if (browserCreateHandleToParentElementsearchElementMinimumHeight != null)
            {
                if (browserCreateHandleToParentElementsearchElementMinimumHeight != null)
                {
                    browserCreateHandleToParentElement["SearchElementMinimumHeight"] = CSharpExpressionConverter.ConvertToken(browserCreateHandleToParentElementsearchElementMinimumHeight);
                    browserCreateHandleToParentElementpropCount++;
                }

                browserCreateHandleToParentElementpropCount++;
            }
            else
            {
                browserCreateHandleToParentElement["SearchElementMinimumHeight"] = 1;
                browserCreateHandleToParentElementpropCount++;
            }

            if (browserCreateHandleToParentElementsearchElementBoundingBoxLeft != null)
            {
                if (browserCreateHandleToParentElementsearchElementBoundingBoxLeft != null)
                {
                    browserCreateHandleToParentElement["SearchElementBoundingBoxLeft"] = CSharpExpressionConverter.ConvertToken(browserCreateHandleToParentElementsearchElementBoundingBoxLeft);
                    browserCreateHandleToParentElementpropCount++;
                }

                browserCreateHandleToParentElementpropCount++;
            }
            else
            {
                browserCreateHandleToParentElement["SearchElementBoundingBoxLeft"] = -99999;
                browserCreateHandleToParentElementpropCount++;
            }

            if (browserCreateHandleToParentElementsearchElementBoundingBoxRight != null)
            {
                if (browserCreateHandleToParentElementsearchElementBoundingBoxRight != null)
                {
                    browserCreateHandleToParentElement["SearchElementBoundingBoxRight"] = CSharpExpressionConverter.ConvertToken(browserCreateHandleToParentElementsearchElementBoundingBoxRight);
                    browserCreateHandleToParentElementpropCount++;
                }

                browserCreateHandleToParentElementpropCount++;
            }
            else
            {
                browserCreateHandleToParentElement["SearchElementBoundingBoxRight"] = 99999;
                browserCreateHandleToParentElementpropCount++;
            }

            if (browserCreateHandleToParentElementsearchElementBoundingBoxTop != null)
            {
                if (browserCreateHandleToParentElementsearchElementBoundingBoxTop != null)
                {
                    browserCreateHandleToParentElement["SearchElementBoundingBoxTop"] = CSharpExpressionConverter.ConvertToken(browserCreateHandleToParentElementsearchElementBoundingBoxTop);
                    browserCreateHandleToParentElementpropCount++;
                }

                browserCreateHandleToParentElementpropCount++;
            }
            else
            {
                browserCreateHandleToParentElement["SearchElementBoundingBoxTop"] = -99999;
                browserCreateHandleToParentElementpropCount++;
            }

            if (browserCreateHandleToParentElementsearchElementBoundingBoxBottom != null)
            {
                if (browserCreateHandleToParentElementsearchElementBoundingBoxBottom != null)
                {
                    browserCreateHandleToParentElement["SearchElementBoundingBoxBottom"] = CSharpExpressionConverter.ConvertToken(browserCreateHandleToParentElementsearchElementBoundingBoxBottom);
                    browserCreateHandleToParentElementpropCount++;
                }

                browserCreateHandleToParentElementpropCount++;
            }
            else
            {
                browserCreateHandleToParentElement["SearchElementBoundingBoxBottom"] = 99999;
                browserCreateHandleToParentElementpropCount++;
            }

            if (browserCreateHandleToParentElementonlyElementTopLeftNeedsToBeInBoundingBox != null)
            {
                if (browserCreateHandleToParentElementonlyElementTopLeftNeedsToBeInBoundingBox != null)
                {
                    browserCreateHandleToParentElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = CSharpExpressionConverter.ConvertToken(browserCreateHandleToParentElementonlyElementTopLeftNeedsToBeInBoundingBox);
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
            browserCreateHandleToParentElement["Workflow"] = CSharpExpressionConverter.ConvertToken(browserCreateHandleToParentElementworkflow);
            if (browserCreateHandleToParentElementpropCount > 0)
            {
                callPayload.Body = browserCreateHandleToParentElement;
            }

            return new ApiConnectionAction<BrowserCreateHandleToParentElementResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserGetElementPropertiesResponse> BrowserGetElementProperties(Expression<Func<string>> browserGetElementPropertiesworkflow, Expression<Func<double>> browserGetElementPropertiesparentElementHandle = null, Expression<Func<double>> browserGetElementPropertiessearchElementHandle = null, Expression<Func<string>> browserGetElementPropertiessearchElementName = null, Expression<Func<string>> browserGetElementPropertiessearchElementID = null, Expression<Func<string>> browserGetElementPropertiessearchElementTagName = null, Expression<Func<string>> browserGetElementPropertiessearchElementXPath = null, Expression<Func<string>> browserGetElementPropertiessearchElementClassName = null, Expression<Func<string>> browserGetElementPropertiessearchElementCSSSelector = null, Expression<Func<double>> browserGetElementPropertiessearchElementIndex = null, Expression<Func<string>> browserGetElementPropertiessearchElementMatchValue = null, Expression<Func<string>> browserGetElementPropertiessearchElementMatchText = null, Expression<Func<string>> browserGetElementPropertiessearchElementType = null, Expression<Func<double>> browserGetElementPropertiessearchElementMinimumWidth = null, Expression<Func<double>> browserGetElementPropertiessearchElementMinimumHeight = null, Expression<Func<double>> browserGetElementPropertiessearchElementBoundingBoxLeft = null, Expression<Func<double>> browserGetElementPropertiessearchElementBoundingBoxRight = null, Expression<Func<double>> browserGetElementPropertiessearchElementBoundingBoxTop = null, Expression<Func<double>> browserGetElementPropertiessearchElementBoundingBoxBottom = null, Expression<Func<bool>> browserGetElementPropertiesonlyElementTopLeftNeedsToBeInBoundingBox = null, Expression<Func<bool>> browserGetElementPropertiesgetHTMLCode = null, Expression<Func<bool>> browserGetElementPropertiesreturnElementHandle = null)
        {
            var apiCallPath = "/BrowserControl/GetElementProperties";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserGetElementProperties = new JObject();
            var browserGetElementPropertiespropCount = 0;
            if (browserGetElementPropertiesparentElementHandle != null)
            {
                browserGetElementProperties["ParentElementHandle"] = CSharpExpressionConverter.ConvertToken(browserGetElementPropertiesparentElementHandle);
                browserGetElementPropertiespropCount++;
            }

            if (browserGetElementPropertiessearchElementHandle != null)
            {
                browserGetElementProperties["SearchElementHandle"] = CSharpExpressionConverter.ConvertToken(browserGetElementPropertiessearchElementHandle);
                browserGetElementPropertiespropCount++;
            }

            if (browserGetElementPropertiessearchElementName != null)
            {
                browserGetElementProperties["SearchElementName"] = CSharpExpressionConverter.ConvertToken(browserGetElementPropertiessearchElementName);
                browserGetElementPropertiespropCount++;
            }

            if (browserGetElementPropertiessearchElementID != null)
            {
                browserGetElementProperties["SearchElementID"] = CSharpExpressionConverter.ConvertToken(browserGetElementPropertiessearchElementID);
                browserGetElementPropertiespropCount++;
            }

            if (browserGetElementPropertiessearchElementTagName != null)
            {
                browserGetElementProperties["SearchElementTagName"] = CSharpExpressionConverter.ConvertToken(browserGetElementPropertiessearchElementTagName);
                browserGetElementPropertiespropCount++;
            }

            if (browserGetElementPropertiessearchElementXPath != null)
            {
                browserGetElementProperties["SearchElementXPath"] = CSharpExpressionConverter.ConvertToken(browserGetElementPropertiessearchElementXPath);
                browserGetElementPropertiespropCount++;
            }

            if (browserGetElementPropertiessearchElementClassName != null)
            {
                browserGetElementProperties["SearchElementClassName"] = CSharpExpressionConverter.ConvertToken(browserGetElementPropertiessearchElementClassName);
                browserGetElementPropertiespropCount++;
            }

            if (browserGetElementPropertiessearchElementCSSSelector != null)
            {
                browserGetElementProperties["SearchElementCSSSelector"] = CSharpExpressionConverter.ConvertToken(browserGetElementPropertiessearchElementCSSSelector);
                browserGetElementPropertiespropCount++;
            }

            if (browserGetElementPropertiessearchElementIndex != null)
            {
                if (browserGetElementPropertiessearchElementIndex != null)
                {
                    browserGetElementProperties["SearchElementIndex"] = CSharpExpressionConverter.ConvertToken(browserGetElementPropertiessearchElementIndex);
                    browserGetElementPropertiespropCount++;
                }

                browserGetElementPropertiespropCount++;
            }
            else
            {
                browserGetElementProperties["SearchElementIndex"] = 1;
                browserGetElementPropertiespropCount++;
            }

            if (browserGetElementPropertiessearchElementMatchValue != null)
            {
                browserGetElementProperties["SearchElementMatchValue"] = CSharpExpressionConverter.ConvertToken(browserGetElementPropertiessearchElementMatchValue);
                browserGetElementPropertiespropCount++;
            }

            if (browserGetElementPropertiessearchElementMatchText != null)
            {
                browserGetElementProperties["SearchElementMatchText"] = CSharpExpressionConverter.ConvertToken(browserGetElementPropertiessearchElementMatchText);
                browserGetElementPropertiespropCount++;
            }

            if (browserGetElementPropertiessearchElementType != null)
            {
                browserGetElementProperties["SearchElementType"] = CSharpExpressionConverter.ConvertToken(browserGetElementPropertiessearchElementType);
                browserGetElementPropertiespropCount++;
            }

            if (browserGetElementPropertiessearchElementMinimumWidth != null)
            {
                if (browserGetElementPropertiessearchElementMinimumWidth != null)
                {
                    browserGetElementProperties["SearchElementMinimumWidth"] = CSharpExpressionConverter.ConvertToken(browserGetElementPropertiessearchElementMinimumWidth);
                    browserGetElementPropertiespropCount++;
                }

                browserGetElementPropertiespropCount++;
            }
            else
            {
                browserGetElementProperties["SearchElementMinimumWidth"] = 1;
                browserGetElementPropertiespropCount++;
            }

            if (browserGetElementPropertiessearchElementMinimumHeight != null)
            {
                if (browserGetElementPropertiessearchElementMinimumHeight != null)
                {
                    browserGetElementProperties["SearchElementMinimumHeight"] = CSharpExpressionConverter.ConvertToken(browserGetElementPropertiessearchElementMinimumHeight);
                    browserGetElementPropertiespropCount++;
                }

                browserGetElementPropertiespropCount++;
            }
            else
            {
                browserGetElementProperties["SearchElementMinimumHeight"] = 1;
                browserGetElementPropertiespropCount++;
            }

            if (browserGetElementPropertiessearchElementBoundingBoxLeft != null)
            {
                if (browserGetElementPropertiessearchElementBoundingBoxLeft != null)
                {
                    browserGetElementProperties["SearchElementBoundingBoxLeft"] = CSharpExpressionConverter.ConvertToken(browserGetElementPropertiessearchElementBoundingBoxLeft);
                    browserGetElementPropertiespropCount++;
                }

                browserGetElementPropertiespropCount++;
            }
            else
            {
                browserGetElementProperties["SearchElementBoundingBoxLeft"] = -99999;
                browserGetElementPropertiespropCount++;
            }

            if (browserGetElementPropertiessearchElementBoundingBoxRight != null)
            {
                if (browserGetElementPropertiessearchElementBoundingBoxRight != null)
                {
                    browserGetElementProperties["SearchElementBoundingBoxRight"] = CSharpExpressionConverter.ConvertToken(browserGetElementPropertiessearchElementBoundingBoxRight);
                    browserGetElementPropertiespropCount++;
                }

                browserGetElementPropertiespropCount++;
            }
            else
            {
                browserGetElementProperties["SearchElementBoundingBoxRight"] = 99999;
                browserGetElementPropertiespropCount++;
            }

            if (browserGetElementPropertiessearchElementBoundingBoxTop != null)
            {
                if (browserGetElementPropertiessearchElementBoundingBoxTop != null)
                {
                    browserGetElementProperties["SearchElementBoundingBoxTop"] = CSharpExpressionConverter.ConvertToken(browserGetElementPropertiessearchElementBoundingBoxTop);
                    browserGetElementPropertiespropCount++;
                }

                browserGetElementPropertiespropCount++;
            }
            else
            {
                browserGetElementProperties["SearchElementBoundingBoxTop"] = -99999;
                browserGetElementPropertiespropCount++;
            }

            if (browserGetElementPropertiessearchElementBoundingBoxBottom != null)
            {
                if (browserGetElementPropertiessearchElementBoundingBoxBottom != null)
                {
                    browserGetElementProperties["SearchElementBoundingBoxBottom"] = CSharpExpressionConverter.ConvertToken(browserGetElementPropertiessearchElementBoundingBoxBottom);
                    browserGetElementPropertiespropCount++;
                }

                browserGetElementPropertiespropCount++;
            }
            else
            {
                browserGetElementProperties["SearchElementBoundingBoxBottom"] = 99999;
                browserGetElementPropertiespropCount++;
            }

            if (browserGetElementPropertiesonlyElementTopLeftNeedsToBeInBoundingBox != null)
            {
                if (browserGetElementPropertiesonlyElementTopLeftNeedsToBeInBoundingBox != null)
                {
                    browserGetElementProperties["OnlyElementTopLeftNeedsToBeInBoundingBox"] = CSharpExpressionConverter.ConvertToken(browserGetElementPropertiesonlyElementTopLeftNeedsToBeInBoundingBox);
                    browserGetElementPropertiespropCount++;
                }

                browserGetElementPropertiespropCount++;
            }
            else
            {
                browserGetElementProperties["OnlyElementTopLeftNeedsToBeInBoundingBox"] = false;
                browserGetElementPropertiespropCount++;
            }

            if (browserGetElementPropertiesgetHTMLCode != null)
            {
                if (browserGetElementPropertiesgetHTMLCode != null)
                {
                    browserGetElementProperties["GetHTMLCode"] = CSharpExpressionConverter.ConvertToken(browserGetElementPropertiesgetHTMLCode);
                    browserGetElementPropertiespropCount++;
                }

                browserGetElementPropertiespropCount++;
            }
            else
            {
                browserGetElementProperties["GetHTMLCode"] = false;
                browserGetElementPropertiespropCount++;
            }

            if (browserGetElementPropertiesreturnElementHandle != null)
            {
                if (browserGetElementPropertiesreturnElementHandle != null)
                {
                    browserGetElementProperties["ReturnElementHandle"] = CSharpExpressionConverter.ConvertToken(browserGetElementPropertiesreturnElementHandle);
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
            browserGetElementProperties["Workflow"] = CSharpExpressionConverter.ConvertToken(browserGetElementPropertiesworkflow);
            if (browserGetElementPropertiespropCount > 0)
            {
                callPayload.Body = browserGetElementProperties;
            }

            return new ApiConnectionAction<BrowserGetElementPropertiesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserGetMultipleElementPropertiesResponse> BrowserGetMultipleElementProperties(Expression<Func<string>> browserGetMultipleElementPropertiesworkflow, Expression<Func<double>> browserGetMultipleElementPropertiesparentElementHandle = null, Expression<Func<string>> browserGetMultipleElementPropertiessearchElementName = null, Expression<Func<string>> browserGetMultipleElementPropertiessearchElementID = null, Expression<Func<string>> browserGetMultipleElementPropertiessearchElementTagName = null, Expression<Func<string>> browserGetMultipleElementPropertiessearchElementXPath = null, Expression<Func<string>> browserGetMultipleElementPropertiessearchElementClassName = null, Expression<Func<string>> browserGetMultipleElementPropertiessearchElementCSSSelector = null, Expression<Func<string>> browserGetMultipleElementPropertiessearchElementMatchValue = null, Expression<Func<string>> browserGetMultipleElementPropertiessearchElementMatchText = null, Expression<Func<string>> browserGetMultipleElementPropertiessearchElementType = null, Expression<Func<double>> browserGetMultipleElementPropertiessearchElementMinimumWidth = null, Expression<Func<double>> browserGetMultipleElementPropertiessearchElementMinimumHeight = null, Expression<Func<double>> browserGetMultipleElementPropertiessearchElementBoundingBoxLeft = null, Expression<Func<double>> browserGetMultipleElementPropertiessearchElementBoundingBoxRight = null, Expression<Func<double>> browserGetMultipleElementPropertiessearchElementBoundingBoxTop = null, Expression<Func<double>> browserGetMultipleElementPropertiessearchElementBoundingBoxBottom = null, Expression<Func<bool>> browserGetMultipleElementPropertiesonlyElementTopLeftNeedsToBeInBoundingBox = null, Expression<Func<bool>> browserGetMultipleElementPropertiesgetHTMLCode = null, Expression<Func<bool>> browserGetMultipleElementPropertiescreateHandle = null, Expression<Func<bool>> browserGetMultipleElementPropertiesreturnValue = null, Expression<Func<bool>> browserGetMultipleElementPropertiesreturnText = null, Expression<Func<int>> browserGetMultipleElementPropertiesmaxValueLength = null, Expression<Func<int>> browserGetMultipleElementPropertiesmaxTextLength = null, Expression<Func<bool>> browserGetMultipleElementPropertiesreturnIsDisplayed = null, Expression<Func<bool>> browserGetMultipleElementPropertiesreturnCoordinates = null, Expression<Func<bool>> browserGetMultipleElementPropertiesreturnDimensions = null, Expression<Func<bool>> browserGetMultipleElementPropertiesreturnChildElementCount = null, Expression<Func<bool>> browserGetMultipleElementPropertiesreturnParentTag = null, Expression<Func<int>> browserGetMultipleElementPropertiesfirstItemToReturn = null, Expression<Func<int>> browserGetMultipleElementPropertiesmaxItemsToReturn = null)
        {
            var apiCallPath = "/BrowserControl/GetMultipleElementProperties";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserGetMultipleElementProperties = new JObject();
            var browserGetMultipleElementPropertiespropCount = 0;
            if (browserGetMultipleElementPropertiesparentElementHandle != null)
            {
                browserGetMultipleElementProperties["ParentElementHandle"] = CSharpExpressionConverter.ConvertToken(browserGetMultipleElementPropertiesparentElementHandle);
                browserGetMultipleElementPropertiespropCount++;
            }

            if (browserGetMultipleElementPropertiessearchElementName != null)
            {
                browserGetMultipleElementProperties["SearchElementName"] = CSharpExpressionConverter.ConvertToken(browserGetMultipleElementPropertiessearchElementName);
                browserGetMultipleElementPropertiespropCount++;
            }

            if (browserGetMultipleElementPropertiessearchElementID != null)
            {
                browserGetMultipleElementProperties["SearchElementID"] = CSharpExpressionConverter.ConvertToken(browserGetMultipleElementPropertiessearchElementID);
                browserGetMultipleElementPropertiespropCount++;
            }

            if (browserGetMultipleElementPropertiessearchElementTagName != null)
            {
                browserGetMultipleElementProperties["SearchElementTagName"] = CSharpExpressionConverter.ConvertToken(browserGetMultipleElementPropertiessearchElementTagName);
                browserGetMultipleElementPropertiespropCount++;
            }

            if (browserGetMultipleElementPropertiessearchElementXPath != null)
            {
                browserGetMultipleElementProperties["SearchElementXPath"] = CSharpExpressionConverter.ConvertToken(browserGetMultipleElementPropertiessearchElementXPath);
                browserGetMultipleElementPropertiespropCount++;
            }

            if (browserGetMultipleElementPropertiessearchElementClassName != null)
            {
                browserGetMultipleElementProperties["SearchElementClassName"] = CSharpExpressionConverter.ConvertToken(browserGetMultipleElementPropertiessearchElementClassName);
                browserGetMultipleElementPropertiespropCount++;
            }

            if (browserGetMultipleElementPropertiessearchElementCSSSelector != null)
            {
                browserGetMultipleElementProperties["SearchElementCSSSelector"] = CSharpExpressionConverter.ConvertToken(browserGetMultipleElementPropertiessearchElementCSSSelector);
                browserGetMultipleElementPropertiespropCount++;
            }

            if (browserGetMultipleElementPropertiessearchElementMatchValue != null)
            {
                browserGetMultipleElementProperties["SearchElementMatchValue"] = CSharpExpressionConverter.ConvertToken(browserGetMultipleElementPropertiessearchElementMatchValue);
                browserGetMultipleElementPropertiespropCount++;
            }

            if (browserGetMultipleElementPropertiessearchElementMatchText != null)
            {
                browserGetMultipleElementProperties["SearchElementMatchText"] = CSharpExpressionConverter.ConvertToken(browserGetMultipleElementPropertiessearchElementMatchText);
                browserGetMultipleElementPropertiespropCount++;
            }

            if (browserGetMultipleElementPropertiessearchElementType != null)
            {
                browserGetMultipleElementProperties["SearchElementType"] = CSharpExpressionConverter.ConvertToken(browserGetMultipleElementPropertiessearchElementType);
                browserGetMultipleElementPropertiespropCount++;
            }

            if (browserGetMultipleElementPropertiessearchElementMinimumWidth != null)
            {
                if (browserGetMultipleElementPropertiessearchElementMinimumWidth != null)
                {
                    browserGetMultipleElementProperties["SearchElementMinimumWidth"] = CSharpExpressionConverter.ConvertToken(browserGetMultipleElementPropertiessearchElementMinimumWidth);
                    browserGetMultipleElementPropertiespropCount++;
                }

                browserGetMultipleElementPropertiespropCount++;
            }
            else
            {
                browserGetMultipleElementProperties["SearchElementMinimumWidth"] = 1;
                browserGetMultipleElementPropertiespropCount++;
            }

            if (browserGetMultipleElementPropertiessearchElementMinimumHeight != null)
            {
                if (browserGetMultipleElementPropertiessearchElementMinimumHeight != null)
                {
                    browserGetMultipleElementProperties["SearchElementMinimumHeight"] = CSharpExpressionConverter.ConvertToken(browserGetMultipleElementPropertiessearchElementMinimumHeight);
                    browserGetMultipleElementPropertiespropCount++;
                }

                browserGetMultipleElementPropertiespropCount++;
            }
            else
            {
                browserGetMultipleElementProperties["SearchElementMinimumHeight"] = 1;
                browserGetMultipleElementPropertiespropCount++;
            }

            if (browserGetMultipleElementPropertiessearchElementBoundingBoxLeft != null)
            {
                if (browserGetMultipleElementPropertiessearchElementBoundingBoxLeft != null)
                {
                    browserGetMultipleElementProperties["SearchElementBoundingBoxLeft"] = CSharpExpressionConverter.ConvertToken(browserGetMultipleElementPropertiessearchElementBoundingBoxLeft);
                    browserGetMultipleElementPropertiespropCount++;
                }

                browserGetMultipleElementPropertiespropCount++;
            }
            else
            {
                browserGetMultipleElementProperties["SearchElementBoundingBoxLeft"] = -99999;
                browserGetMultipleElementPropertiespropCount++;
            }

            if (browserGetMultipleElementPropertiessearchElementBoundingBoxRight != null)
            {
                if (browserGetMultipleElementPropertiessearchElementBoundingBoxRight != null)
                {
                    browserGetMultipleElementProperties["SearchElementBoundingBoxRight"] = CSharpExpressionConverter.ConvertToken(browserGetMultipleElementPropertiessearchElementBoundingBoxRight);
                    browserGetMultipleElementPropertiespropCount++;
                }

                browserGetMultipleElementPropertiespropCount++;
            }
            else
            {
                browserGetMultipleElementProperties["SearchElementBoundingBoxRight"] = 99999;
                browserGetMultipleElementPropertiespropCount++;
            }

            if (browserGetMultipleElementPropertiessearchElementBoundingBoxTop != null)
            {
                if (browserGetMultipleElementPropertiessearchElementBoundingBoxTop != null)
                {
                    browserGetMultipleElementProperties["SearchElementBoundingBoxTop"] = CSharpExpressionConverter.ConvertToken(browserGetMultipleElementPropertiessearchElementBoundingBoxTop);
                    browserGetMultipleElementPropertiespropCount++;
                }

                browserGetMultipleElementPropertiespropCount++;
            }
            else
            {
                browserGetMultipleElementProperties["SearchElementBoundingBoxTop"] = -99999;
                browserGetMultipleElementPropertiespropCount++;
            }

            if (browserGetMultipleElementPropertiessearchElementBoundingBoxBottom != null)
            {
                if (browserGetMultipleElementPropertiessearchElementBoundingBoxBottom != null)
                {
                    browserGetMultipleElementProperties["SearchElementBoundingBoxBottom"] = CSharpExpressionConverter.ConvertToken(browserGetMultipleElementPropertiessearchElementBoundingBoxBottom);
                    browserGetMultipleElementPropertiespropCount++;
                }

                browserGetMultipleElementPropertiespropCount++;
            }
            else
            {
                browserGetMultipleElementProperties["SearchElementBoundingBoxBottom"] = 99999;
                browserGetMultipleElementPropertiespropCount++;
            }

            if (browserGetMultipleElementPropertiesonlyElementTopLeftNeedsToBeInBoundingBox != null)
            {
                if (browserGetMultipleElementPropertiesonlyElementTopLeftNeedsToBeInBoundingBox != null)
                {
                    browserGetMultipleElementProperties["OnlyElementTopLeftNeedsToBeInBoundingBox"] = CSharpExpressionConverter.ConvertToken(browserGetMultipleElementPropertiesonlyElementTopLeftNeedsToBeInBoundingBox);
                    browserGetMultipleElementPropertiespropCount++;
                }

                browserGetMultipleElementPropertiespropCount++;
            }
            else
            {
                browserGetMultipleElementProperties["OnlyElementTopLeftNeedsToBeInBoundingBox"] = false;
                browserGetMultipleElementPropertiespropCount++;
            }

            if (browserGetMultipleElementPropertiesgetHTMLCode != null)
            {
                if (browserGetMultipleElementPropertiesgetHTMLCode != null)
                {
                    browserGetMultipleElementProperties["GetHTMLCode"] = CSharpExpressionConverter.ConvertToken(browserGetMultipleElementPropertiesgetHTMLCode);
                    browserGetMultipleElementPropertiespropCount++;
                }

                browserGetMultipleElementPropertiespropCount++;
            }
            else
            {
                browserGetMultipleElementProperties["GetHTMLCode"] = false;
                browserGetMultipleElementPropertiespropCount++;
            }

            if (browserGetMultipleElementPropertiescreateHandle != null)
            {
                if (browserGetMultipleElementPropertiescreateHandle != null)
                {
                    browserGetMultipleElementProperties["CreateHandle"] = CSharpExpressionConverter.ConvertToken(browserGetMultipleElementPropertiescreateHandle);
                    browserGetMultipleElementPropertiespropCount++;
                }

                browserGetMultipleElementPropertiespropCount++;
            }
            else
            {
                browserGetMultipleElementProperties["CreateHandle"] = true;
                browserGetMultipleElementPropertiespropCount++;
            }

            if (browserGetMultipleElementPropertiesreturnValue != null)
            {
                if (browserGetMultipleElementPropertiesreturnValue != null)
                {
                    browserGetMultipleElementProperties["ReturnValue"] = CSharpExpressionConverter.ConvertToken(browserGetMultipleElementPropertiesreturnValue);
                    browserGetMultipleElementPropertiespropCount++;
                }

                browserGetMultipleElementPropertiespropCount++;
            }
            else
            {
                browserGetMultipleElementProperties["ReturnValue"] = true;
                browserGetMultipleElementPropertiespropCount++;
            }

            if (browserGetMultipleElementPropertiesreturnText != null)
            {
                if (browserGetMultipleElementPropertiesreturnText != null)
                {
                    browserGetMultipleElementProperties["ReturnText"] = CSharpExpressionConverter.ConvertToken(browserGetMultipleElementPropertiesreturnText);
                    browserGetMultipleElementPropertiespropCount++;
                }

                browserGetMultipleElementPropertiespropCount++;
            }
            else
            {
                browserGetMultipleElementProperties["ReturnText"] = true;
                browserGetMultipleElementPropertiespropCount++;
            }

            if (browserGetMultipleElementPropertiesmaxValueLength != null)
            {
                if (browserGetMultipleElementPropertiesmaxValueLength != null)
                {
                    browserGetMultipleElementProperties["MaxValueLength"] = CSharpExpressionConverter.ConvertToken(browserGetMultipleElementPropertiesmaxValueLength);
                    browserGetMultipleElementPropertiespropCount++;
                }

                browserGetMultipleElementPropertiespropCount++;
            }
            else
            {
                browserGetMultipleElementProperties["MaxValueLength"] = 0;
                browserGetMultipleElementPropertiespropCount++;
            }

            if (browserGetMultipleElementPropertiesmaxTextLength != null)
            {
                if (browserGetMultipleElementPropertiesmaxTextLength != null)
                {
                    browserGetMultipleElementProperties["MaxTextLength"] = CSharpExpressionConverter.ConvertToken(browserGetMultipleElementPropertiesmaxTextLength);
                    browserGetMultipleElementPropertiespropCount++;
                }

                browserGetMultipleElementPropertiespropCount++;
            }
            else
            {
                browserGetMultipleElementProperties["MaxTextLength"] = 0;
                browserGetMultipleElementPropertiespropCount++;
            }

            if (browserGetMultipleElementPropertiesreturnIsDisplayed != null)
            {
                if (browserGetMultipleElementPropertiesreturnIsDisplayed != null)
                {
                    browserGetMultipleElementProperties["ReturnIsDisplayed"] = CSharpExpressionConverter.ConvertToken(browserGetMultipleElementPropertiesreturnIsDisplayed);
                    browserGetMultipleElementPropertiespropCount++;
                }

                browserGetMultipleElementPropertiespropCount++;
            }
            else
            {
                browserGetMultipleElementProperties["ReturnIsDisplayed"] = true;
                browserGetMultipleElementPropertiespropCount++;
            }

            if (browserGetMultipleElementPropertiesreturnCoordinates != null)
            {
                if (browserGetMultipleElementPropertiesreturnCoordinates != null)
                {
                    browserGetMultipleElementProperties["ReturnCoordinates"] = CSharpExpressionConverter.ConvertToken(browserGetMultipleElementPropertiesreturnCoordinates);
                    browserGetMultipleElementPropertiespropCount++;
                }

                browserGetMultipleElementPropertiespropCount++;
            }
            else
            {
                browserGetMultipleElementProperties["ReturnCoordinates"] = true;
                browserGetMultipleElementPropertiespropCount++;
            }

            if (browserGetMultipleElementPropertiesreturnDimensions != null)
            {
                if (browserGetMultipleElementPropertiesreturnDimensions != null)
                {
                    browserGetMultipleElementProperties["ReturnDimensions"] = CSharpExpressionConverter.ConvertToken(browserGetMultipleElementPropertiesreturnDimensions);
                    browserGetMultipleElementPropertiespropCount++;
                }

                browserGetMultipleElementPropertiespropCount++;
            }
            else
            {
                browserGetMultipleElementProperties["ReturnDimensions"] = true;
                browserGetMultipleElementPropertiespropCount++;
            }

            if (browserGetMultipleElementPropertiesreturnChildElementCount != null)
            {
                if (browserGetMultipleElementPropertiesreturnChildElementCount != null)
                {
                    browserGetMultipleElementProperties["ReturnChildElementCount"] = CSharpExpressionConverter.ConvertToken(browserGetMultipleElementPropertiesreturnChildElementCount);
                    browserGetMultipleElementPropertiespropCount++;
                }

                browserGetMultipleElementPropertiespropCount++;
            }
            else
            {
                browserGetMultipleElementProperties["ReturnChildElementCount"] = true;
                browserGetMultipleElementPropertiespropCount++;
            }

            if (browserGetMultipleElementPropertiesreturnParentTag != null)
            {
                if (browserGetMultipleElementPropertiesreturnParentTag != null)
                {
                    browserGetMultipleElementProperties["ReturnParentTag"] = CSharpExpressionConverter.ConvertToken(browserGetMultipleElementPropertiesreturnParentTag);
                    browserGetMultipleElementPropertiespropCount++;
                }

                browserGetMultipleElementPropertiespropCount++;
            }
            else
            {
                browserGetMultipleElementProperties["ReturnParentTag"] = true;
                browserGetMultipleElementPropertiespropCount++;
            }

            if (browserGetMultipleElementPropertiesfirstItemToReturn != null)
            {
                if (browserGetMultipleElementPropertiesfirstItemToReturn != null)
                {
                    browserGetMultipleElementProperties["FirstItemToReturn"] = CSharpExpressionConverter.ConvertToken(browserGetMultipleElementPropertiesfirstItemToReturn);
                    browserGetMultipleElementPropertiespropCount++;
                }

                browserGetMultipleElementPropertiespropCount++;
            }
            else
            {
                browserGetMultipleElementProperties["FirstItemToReturn"] = 1;
                browserGetMultipleElementPropertiespropCount++;
            }

            if (browserGetMultipleElementPropertiesmaxItemsToReturn != null)
            {
                if (browserGetMultipleElementPropertiesmaxItemsToReturn != null)
                {
                    browserGetMultipleElementProperties["MaxItemsToReturn"] = CSharpExpressionConverter.ConvertToken(browserGetMultipleElementPropertiesmaxItemsToReturn);
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
            browserGetMultipleElementProperties["Workflow"] = CSharpExpressionConverter.ConvertToken(browserGetMultipleElementPropertiesworkflow);
            if (browserGetMultipleElementPropertiespropCount > 0)
            {
                callPayload.Body = browserGetMultipleElementProperties;
            }

            return new ApiConnectionAction<BrowserGetMultipleElementPropertiesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserGetElementParentPropertiesResponse> BrowserGetElementParentProperties(Expression<Func<string>> browserGetElementParentPropertiesworkflow, Expression<Func<double>> browserGetElementParentPropertiesparentElementHandle = null, Expression<Func<double>> browserGetElementParentPropertiessearchElementHandle = null, Expression<Func<string>> browserGetElementParentPropertiessearchElementName = null, Expression<Func<string>> browserGetElementParentPropertiessearchElementID = null, Expression<Func<string>> browserGetElementParentPropertiessearchElementTagName = null, Expression<Func<string>> browserGetElementParentPropertiessearchElementXPath = null, Expression<Func<string>> browserGetElementParentPropertiessearchElementClassName = null, Expression<Func<string>> browserGetElementParentPropertiessearchElementCSSSelector = null, Expression<Func<double>> browserGetElementParentPropertiessearchElementIndex = null, Expression<Func<string>> browserGetElementParentPropertiessearchElementMatchValue = null, Expression<Func<string>> browserGetElementParentPropertiessearchElementMatchText = null, Expression<Func<string>> browserGetElementParentPropertiessearchElementType = null, Expression<Func<double>> browserGetElementParentPropertiessearchElementMinimumWidth = null, Expression<Func<double>> browserGetElementParentPropertiessearchElementMinimumHeight = null, Expression<Func<double>> browserGetElementParentPropertiessearchElementBoundingBoxLeft = null, Expression<Func<double>> browserGetElementParentPropertiessearchElementBoundingBoxRight = null, Expression<Func<double>> browserGetElementParentPropertiessearchElementBoundingBoxTop = null, Expression<Func<double>> browserGetElementParentPropertiessearchElementBoundingBoxBottom = null, Expression<Func<bool>> browserGetElementParentPropertiesonlyElementTopLeftNeedsToBeInBoundingBox = null, Expression<Func<bool>> browserGetElementParentPropertiesgetHTMLCode = null, Expression<Func<bool>> browserGetElementParentPropertiescreateHandle = null)
        {
            var apiCallPath = "/BrowserControl/GetElementParentProperties";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserGetElementParentProperties = new JObject();
            var browserGetElementParentPropertiespropCount = 0;
            if (browserGetElementParentPropertiesparentElementHandle != null)
            {
                browserGetElementParentProperties["ParentElementHandle"] = CSharpExpressionConverter.ConvertToken(browserGetElementParentPropertiesparentElementHandle);
                browserGetElementParentPropertiespropCount++;
            }

            if (browserGetElementParentPropertiessearchElementHandle != null)
            {
                browserGetElementParentProperties["SearchElementHandle"] = CSharpExpressionConverter.ConvertToken(browserGetElementParentPropertiessearchElementHandle);
                browserGetElementParentPropertiespropCount++;
            }

            if (browserGetElementParentPropertiessearchElementName != null)
            {
                browserGetElementParentProperties["SearchElementName"] = CSharpExpressionConverter.ConvertToken(browserGetElementParentPropertiessearchElementName);
                browserGetElementParentPropertiespropCount++;
            }

            if (browserGetElementParentPropertiessearchElementID != null)
            {
                browserGetElementParentProperties["SearchElementID"] = CSharpExpressionConverter.ConvertToken(browserGetElementParentPropertiessearchElementID);
                browserGetElementParentPropertiespropCount++;
            }

            if (browserGetElementParentPropertiessearchElementTagName != null)
            {
                browserGetElementParentProperties["SearchElementTagName"] = CSharpExpressionConverter.ConvertToken(browserGetElementParentPropertiessearchElementTagName);
                browserGetElementParentPropertiespropCount++;
            }

            if (browserGetElementParentPropertiessearchElementXPath != null)
            {
                browserGetElementParentProperties["SearchElementXPath"] = CSharpExpressionConverter.ConvertToken(browserGetElementParentPropertiessearchElementXPath);
                browserGetElementParentPropertiespropCount++;
            }

            if (browserGetElementParentPropertiessearchElementClassName != null)
            {
                browserGetElementParentProperties["SearchElementClassName"] = CSharpExpressionConverter.ConvertToken(browserGetElementParentPropertiessearchElementClassName);
                browserGetElementParentPropertiespropCount++;
            }

            if (browserGetElementParentPropertiessearchElementCSSSelector != null)
            {
                browserGetElementParentProperties["SearchElementCSSSelector"] = CSharpExpressionConverter.ConvertToken(browserGetElementParentPropertiessearchElementCSSSelector);
                browserGetElementParentPropertiespropCount++;
            }

            if (browserGetElementParentPropertiessearchElementIndex != null)
            {
                if (browserGetElementParentPropertiessearchElementIndex != null)
                {
                    browserGetElementParentProperties["SearchElementIndex"] = CSharpExpressionConverter.ConvertToken(browserGetElementParentPropertiessearchElementIndex);
                    browserGetElementParentPropertiespropCount++;
                }

                browserGetElementParentPropertiespropCount++;
            }
            else
            {
                browserGetElementParentProperties["SearchElementIndex"] = 1;
                browserGetElementParentPropertiespropCount++;
            }

            if (browserGetElementParentPropertiessearchElementMatchValue != null)
            {
                browserGetElementParentProperties["SearchElementMatchValue"] = CSharpExpressionConverter.ConvertToken(browserGetElementParentPropertiessearchElementMatchValue);
                browserGetElementParentPropertiespropCount++;
            }

            if (browserGetElementParentPropertiessearchElementMatchText != null)
            {
                browserGetElementParentProperties["SearchElementMatchText"] = CSharpExpressionConverter.ConvertToken(browserGetElementParentPropertiessearchElementMatchText);
                browserGetElementParentPropertiespropCount++;
            }

            if (browserGetElementParentPropertiessearchElementType != null)
            {
                browserGetElementParentProperties["SearchElementType"] = CSharpExpressionConverter.ConvertToken(browserGetElementParentPropertiessearchElementType);
                browserGetElementParentPropertiespropCount++;
            }

            if (browserGetElementParentPropertiessearchElementMinimumWidth != null)
            {
                if (browserGetElementParentPropertiessearchElementMinimumWidth != null)
                {
                    browserGetElementParentProperties["SearchElementMinimumWidth"] = CSharpExpressionConverter.ConvertToken(browserGetElementParentPropertiessearchElementMinimumWidth);
                    browserGetElementParentPropertiespropCount++;
                }

                browserGetElementParentPropertiespropCount++;
            }
            else
            {
                browserGetElementParentProperties["SearchElementMinimumWidth"] = 1;
                browserGetElementParentPropertiespropCount++;
            }

            if (browserGetElementParentPropertiessearchElementMinimumHeight != null)
            {
                if (browserGetElementParentPropertiessearchElementMinimumHeight != null)
                {
                    browserGetElementParentProperties["SearchElementMinimumHeight"] = CSharpExpressionConverter.ConvertToken(browserGetElementParentPropertiessearchElementMinimumHeight);
                    browserGetElementParentPropertiespropCount++;
                }

                browserGetElementParentPropertiespropCount++;
            }
            else
            {
                browserGetElementParentProperties["SearchElementMinimumHeight"] = 1;
                browserGetElementParentPropertiespropCount++;
            }

            if (browserGetElementParentPropertiessearchElementBoundingBoxLeft != null)
            {
                if (browserGetElementParentPropertiessearchElementBoundingBoxLeft != null)
                {
                    browserGetElementParentProperties["SearchElementBoundingBoxLeft"] = CSharpExpressionConverter.ConvertToken(browserGetElementParentPropertiessearchElementBoundingBoxLeft);
                    browserGetElementParentPropertiespropCount++;
                }

                browserGetElementParentPropertiespropCount++;
            }
            else
            {
                browserGetElementParentProperties["SearchElementBoundingBoxLeft"] = -99999;
                browserGetElementParentPropertiespropCount++;
            }

            if (browserGetElementParentPropertiessearchElementBoundingBoxRight != null)
            {
                if (browserGetElementParentPropertiessearchElementBoundingBoxRight != null)
                {
                    browserGetElementParentProperties["SearchElementBoundingBoxRight"] = CSharpExpressionConverter.ConvertToken(browserGetElementParentPropertiessearchElementBoundingBoxRight);
                    browserGetElementParentPropertiespropCount++;
                }

                browserGetElementParentPropertiespropCount++;
            }
            else
            {
                browserGetElementParentProperties["SearchElementBoundingBoxRight"] = 99999;
                browserGetElementParentPropertiespropCount++;
            }

            if (browserGetElementParentPropertiessearchElementBoundingBoxTop != null)
            {
                if (browserGetElementParentPropertiessearchElementBoundingBoxTop != null)
                {
                    browserGetElementParentProperties["SearchElementBoundingBoxTop"] = CSharpExpressionConverter.ConvertToken(browserGetElementParentPropertiessearchElementBoundingBoxTop);
                    browserGetElementParentPropertiespropCount++;
                }

                browserGetElementParentPropertiespropCount++;
            }
            else
            {
                browserGetElementParentProperties["SearchElementBoundingBoxTop"] = -99999;
                browserGetElementParentPropertiespropCount++;
            }

            if (browserGetElementParentPropertiessearchElementBoundingBoxBottom != null)
            {
                if (browserGetElementParentPropertiessearchElementBoundingBoxBottom != null)
                {
                    browserGetElementParentProperties["SearchElementBoundingBoxBottom"] = CSharpExpressionConverter.ConvertToken(browserGetElementParentPropertiessearchElementBoundingBoxBottom);
                    browserGetElementParentPropertiespropCount++;
                }

                browserGetElementParentPropertiespropCount++;
            }
            else
            {
                browserGetElementParentProperties["SearchElementBoundingBoxBottom"] = 99999;
                browserGetElementParentPropertiespropCount++;
            }

            if (browserGetElementParentPropertiesonlyElementTopLeftNeedsToBeInBoundingBox != null)
            {
                if (browserGetElementParentPropertiesonlyElementTopLeftNeedsToBeInBoundingBox != null)
                {
                    browserGetElementParentProperties["OnlyElementTopLeftNeedsToBeInBoundingBox"] = CSharpExpressionConverter.ConvertToken(browserGetElementParentPropertiesonlyElementTopLeftNeedsToBeInBoundingBox);
                    browserGetElementParentPropertiespropCount++;
                }

                browserGetElementParentPropertiespropCount++;
            }
            else
            {
                browserGetElementParentProperties["OnlyElementTopLeftNeedsToBeInBoundingBox"] = false;
                browserGetElementParentPropertiespropCount++;
            }

            if (browserGetElementParentPropertiesgetHTMLCode != null)
            {
                if (browserGetElementParentPropertiesgetHTMLCode != null)
                {
                    browserGetElementParentProperties["GetHTMLCode"] = CSharpExpressionConverter.ConvertToken(browserGetElementParentPropertiesgetHTMLCode);
                    browserGetElementParentPropertiespropCount++;
                }

                browserGetElementParentPropertiespropCount++;
            }
            else
            {
                browserGetElementParentProperties["GetHTMLCode"] = false;
                browserGetElementParentPropertiespropCount++;
            }

            if (browserGetElementParentPropertiescreateHandle != null)
            {
                if (browserGetElementParentPropertiescreateHandle != null)
                {
                    browserGetElementParentProperties["CreateHandle"] = CSharpExpressionConverter.ConvertToken(browserGetElementParentPropertiescreateHandle);
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
            browserGetElementParentProperties["Workflow"] = CSharpExpressionConverter.ConvertToken(browserGetElementParentPropertiesworkflow);
            if (browserGetElementParentPropertiespropCount > 0)
            {
                callPayload.Body = browserGetElementParentProperties;
            }

            return new ApiConnectionAction<BrowserGetElementParentPropertiesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserGetElementChildrenPropertiesResponse> BrowserGetElementChildrenProperties(Expression<Func<string>> browserGetElementChildrenPropertiesworkflow, Expression<Func<double>> browserGetElementChildrenPropertiesparentElementHandle = null, Expression<Func<string>> browserGetElementChildrenPropertiessearchElementName = null, Expression<Func<string>> browserGetElementChildrenPropertiessearchElementID = null, Expression<Func<string>> browserGetElementChildrenPropertiessearchElementTagName = null, Expression<Func<string>> browserGetElementChildrenPropertiessearchElementXPath = null, Expression<Func<string>> browserGetElementChildrenPropertiessearchElementClassName = null, Expression<Func<string>> browserGetElementChildrenPropertiessearchElementCSSSelector = null, Expression<Func<string>> browserGetElementChildrenPropertiessearchElementMatchValue = null, Expression<Func<string>> browserGetElementChildrenPropertiessearchElementMatchText = null, Expression<Func<string>> browserGetElementChildrenPropertiessearchElementType = null, Expression<Func<double>> browserGetElementChildrenPropertiessearchElementMinimumWidth = null, Expression<Func<double>> browserGetElementChildrenPropertiessearchElementMinimumHeight = null, Expression<Func<double>> browserGetElementChildrenPropertiessearchElementBoundingBoxLeft = null, Expression<Func<double>> browserGetElementChildrenPropertiessearchElementBoundingBoxRight = null, Expression<Func<double>> browserGetElementChildrenPropertiessearchElementBoundingBoxTop = null, Expression<Func<double>> browserGetElementChildrenPropertiessearchElementBoundingBoxBottom = null, Expression<Func<bool>> browserGetElementChildrenPropertiesonlyElementTopLeftNeedsToBeInBoundingBox = null, Expression<Func<bool>> browserGetElementChildrenPropertiesgetHTMLCode = null, Expression<Func<bool>> browserGetElementChildrenPropertiescreateHandle = null, Expression<Func<bool>> browserGetElementChildrenPropertiessearchSubTree = null, Expression<Func<bool>> browserGetElementChildrenPropertiesreturnValue = null, Expression<Func<bool>> browserGetElementChildrenPropertiesreturnText = null, Expression<Func<int>> browserGetElementChildrenPropertiesmaxValueLength = null, Expression<Func<int>> browserGetElementChildrenPropertiesmaxTextLength = null, Expression<Func<bool>> browserGetElementChildrenPropertiesreturnIsDisplayed = null, Expression<Func<bool>> browserGetElementChildrenPropertiesreturnCoordinates = null, Expression<Func<bool>> browserGetElementChildrenPropertiesreturnDimensions = null, Expression<Func<bool>> browserGetElementChildrenPropertiesreturnChildElementCount = null, Expression<Func<bool>> browserGetElementChildrenPropertiesreturnParentTag = null, Expression<Func<int>> browserGetElementChildrenPropertiesfirstItemToReturn = null, Expression<Func<int>> browserGetElementChildrenPropertiesmaxItemsToReturn = null)
        {
            var apiCallPath = "/BrowserControl/GetElementChildrenProperties";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserGetElementChildrenProperties = new JObject();
            var browserGetElementChildrenPropertiespropCount = 0;
            if (browserGetElementChildrenPropertiesparentElementHandle != null)
            {
                browserGetElementChildrenProperties["ParentElementHandle"] = CSharpExpressionConverter.ConvertToken(browserGetElementChildrenPropertiesparentElementHandle);
                browserGetElementChildrenPropertiespropCount++;
            }

            if (browserGetElementChildrenPropertiessearchElementName != null)
            {
                browserGetElementChildrenProperties["SearchElementName"] = CSharpExpressionConverter.ConvertToken(browserGetElementChildrenPropertiessearchElementName);
                browserGetElementChildrenPropertiespropCount++;
            }

            if (browserGetElementChildrenPropertiessearchElementID != null)
            {
                browserGetElementChildrenProperties["SearchElementID"] = CSharpExpressionConverter.ConvertToken(browserGetElementChildrenPropertiessearchElementID);
                browserGetElementChildrenPropertiespropCount++;
            }

            if (browserGetElementChildrenPropertiessearchElementTagName != null)
            {
                browserGetElementChildrenProperties["SearchElementTagName"] = CSharpExpressionConverter.ConvertToken(browserGetElementChildrenPropertiessearchElementTagName);
                browserGetElementChildrenPropertiespropCount++;
            }

            if (browserGetElementChildrenPropertiessearchElementXPath != null)
            {
                browserGetElementChildrenProperties["SearchElementXPath"] = CSharpExpressionConverter.ConvertToken(browserGetElementChildrenPropertiessearchElementXPath);
                browserGetElementChildrenPropertiespropCount++;
            }

            if (browserGetElementChildrenPropertiessearchElementClassName != null)
            {
                browserGetElementChildrenProperties["SearchElementClassName"] = CSharpExpressionConverter.ConvertToken(browserGetElementChildrenPropertiessearchElementClassName);
                browserGetElementChildrenPropertiespropCount++;
            }

            if (browserGetElementChildrenPropertiessearchElementCSSSelector != null)
            {
                browserGetElementChildrenProperties["SearchElementCSSSelector"] = CSharpExpressionConverter.ConvertToken(browserGetElementChildrenPropertiessearchElementCSSSelector);
                browserGetElementChildrenPropertiespropCount++;
            }

            if (browserGetElementChildrenPropertiessearchElementMatchValue != null)
            {
                browserGetElementChildrenProperties["SearchElementMatchValue"] = CSharpExpressionConverter.ConvertToken(browserGetElementChildrenPropertiessearchElementMatchValue);
                browserGetElementChildrenPropertiespropCount++;
            }

            if (browserGetElementChildrenPropertiessearchElementMatchText != null)
            {
                browserGetElementChildrenProperties["SearchElementMatchText"] = CSharpExpressionConverter.ConvertToken(browserGetElementChildrenPropertiessearchElementMatchText);
                browserGetElementChildrenPropertiespropCount++;
            }

            if (browserGetElementChildrenPropertiessearchElementType != null)
            {
                browserGetElementChildrenProperties["SearchElementType"] = CSharpExpressionConverter.ConvertToken(browserGetElementChildrenPropertiessearchElementType);
                browserGetElementChildrenPropertiespropCount++;
            }

            if (browserGetElementChildrenPropertiessearchElementMinimumWidth != null)
            {
                if (browserGetElementChildrenPropertiessearchElementMinimumWidth != null)
                {
                    browserGetElementChildrenProperties["SearchElementMinimumWidth"] = CSharpExpressionConverter.ConvertToken(browserGetElementChildrenPropertiessearchElementMinimumWidth);
                    browserGetElementChildrenPropertiespropCount++;
                }

                browserGetElementChildrenPropertiespropCount++;
            }
            else
            {
                browserGetElementChildrenProperties["SearchElementMinimumWidth"] = 1;
                browserGetElementChildrenPropertiespropCount++;
            }

            if (browserGetElementChildrenPropertiessearchElementMinimumHeight != null)
            {
                if (browserGetElementChildrenPropertiessearchElementMinimumHeight != null)
                {
                    browserGetElementChildrenProperties["SearchElementMinimumHeight"] = CSharpExpressionConverter.ConvertToken(browserGetElementChildrenPropertiessearchElementMinimumHeight);
                    browserGetElementChildrenPropertiespropCount++;
                }

                browserGetElementChildrenPropertiespropCount++;
            }
            else
            {
                browserGetElementChildrenProperties["SearchElementMinimumHeight"] = 1;
                browserGetElementChildrenPropertiespropCount++;
            }

            if (browserGetElementChildrenPropertiessearchElementBoundingBoxLeft != null)
            {
                if (browserGetElementChildrenPropertiessearchElementBoundingBoxLeft != null)
                {
                    browserGetElementChildrenProperties["SearchElementBoundingBoxLeft"] = CSharpExpressionConverter.ConvertToken(browserGetElementChildrenPropertiessearchElementBoundingBoxLeft);
                    browserGetElementChildrenPropertiespropCount++;
                }

                browserGetElementChildrenPropertiespropCount++;
            }
            else
            {
                browserGetElementChildrenProperties["SearchElementBoundingBoxLeft"] = -99999;
                browserGetElementChildrenPropertiespropCount++;
            }

            if (browserGetElementChildrenPropertiessearchElementBoundingBoxRight != null)
            {
                if (browserGetElementChildrenPropertiessearchElementBoundingBoxRight != null)
                {
                    browserGetElementChildrenProperties["SearchElementBoundingBoxRight"] = CSharpExpressionConverter.ConvertToken(browserGetElementChildrenPropertiessearchElementBoundingBoxRight);
                    browserGetElementChildrenPropertiespropCount++;
                }

                browserGetElementChildrenPropertiespropCount++;
            }
            else
            {
                browserGetElementChildrenProperties["SearchElementBoundingBoxRight"] = 99999;
                browserGetElementChildrenPropertiespropCount++;
            }

            if (browserGetElementChildrenPropertiessearchElementBoundingBoxTop != null)
            {
                if (browserGetElementChildrenPropertiessearchElementBoundingBoxTop != null)
                {
                    browserGetElementChildrenProperties["SearchElementBoundingBoxTop"] = CSharpExpressionConverter.ConvertToken(browserGetElementChildrenPropertiessearchElementBoundingBoxTop);
                    browserGetElementChildrenPropertiespropCount++;
                }

                browserGetElementChildrenPropertiespropCount++;
            }
            else
            {
                browserGetElementChildrenProperties["SearchElementBoundingBoxTop"] = -99999;
                browserGetElementChildrenPropertiespropCount++;
            }

            if (browserGetElementChildrenPropertiessearchElementBoundingBoxBottom != null)
            {
                if (browserGetElementChildrenPropertiessearchElementBoundingBoxBottom != null)
                {
                    browserGetElementChildrenProperties["SearchElementBoundingBoxBottom"] = CSharpExpressionConverter.ConvertToken(browserGetElementChildrenPropertiessearchElementBoundingBoxBottom);
                    browserGetElementChildrenPropertiespropCount++;
                }

                browserGetElementChildrenPropertiespropCount++;
            }
            else
            {
                browserGetElementChildrenProperties["SearchElementBoundingBoxBottom"] = 99999;
                browserGetElementChildrenPropertiespropCount++;
            }

            if (browserGetElementChildrenPropertiesonlyElementTopLeftNeedsToBeInBoundingBox != null)
            {
                if (browserGetElementChildrenPropertiesonlyElementTopLeftNeedsToBeInBoundingBox != null)
                {
                    browserGetElementChildrenProperties["OnlyElementTopLeftNeedsToBeInBoundingBox"] = CSharpExpressionConverter.ConvertToken(browserGetElementChildrenPropertiesonlyElementTopLeftNeedsToBeInBoundingBox);
                    browserGetElementChildrenPropertiespropCount++;
                }

                browserGetElementChildrenPropertiespropCount++;
            }
            else
            {
                browserGetElementChildrenProperties["OnlyElementTopLeftNeedsToBeInBoundingBox"] = false;
                browserGetElementChildrenPropertiespropCount++;
            }

            if (browserGetElementChildrenPropertiesgetHTMLCode != null)
            {
                if (browserGetElementChildrenPropertiesgetHTMLCode != null)
                {
                    browserGetElementChildrenProperties["GetHTMLCode"] = CSharpExpressionConverter.ConvertToken(browserGetElementChildrenPropertiesgetHTMLCode);
                    browserGetElementChildrenPropertiespropCount++;
                }

                browserGetElementChildrenPropertiespropCount++;
            }
            else
            {
                browserGetElementChildrenProperties["GetHTMLCode"] = false;
                browserGetElementChildrenPropertiespropCount++;
            }

            if (browserGetElementChildrenPropertiescreateHandle != null)
            {
                if (browserGetElementChildrenPropertiescreateHandle != null)
                {
                    browserGetElementChildrenProperties["CreateHandle"] = CSharpExpressionConverter.ConvertToken(browserGetElementChildrenPropertiescreateHandle);
                    browserGetElementChildrenPropertiespropCount++;
                }

                browserGetElementChildrenPropertiespropCount++;
            }
            else
            {
                browserGetElementChildrenProperties["CreateHandle"] = true;
                browserGetElementChildrenPropertiespropCount++;
            }

            if (browserGetElementChildrenPropertiessearchSubTree != null)
            {
                if (browserGetElementChildrenPropertiessearchSubTree != null)
                {
                    browserGetElementChildrenProperties["SearchSubTree"] = CSharpExpressionConverter.ConvertToken(browserGetElementChildrenPropertiessearchSubTree);
                    browserGetElementChildrenPropertiespropCount++;
                }

                browserGetElementChildrenPropertiespropCount++;
            }
            else
            {
                browserGetElementChildrenProperties["SearchSubTree"] = false;
                browserGetElementChildrenPropertiespropCount++;
            }

            if (browserGetElementChildrenPropertiesreturnValue != null)
            {
                if (browserGetElementChildrenPropertiesreturnValue != null)
                {
                    browserGetElementChildrenProperties["ReturnValue"] = CSharpExpressionConverter.ConvertToken(browserGetElementChildrenPropertiesreturnValue);
                    browserGetElementChildrenPropertiespropCount++;
                }

                browserGetElementChildrenPropertiespropCount++;
            }
            else
            {
                browserGetElementChildrenProperties["ReturnValue"] = true;
                browserGetElementChildrenPropertiespropCount++;
            }

            if (browserGetElementChildrenPropertiesreturnText != null)
            {
                if (browserGetElementChildrenPropertiesreturnText != null)
                {
                    browserGetElementChildrenProperties["ReturnText"] = CSharpExpressionConverter.ConvertToken(browserGetElementChildrenPropertiesreturnText);
                    browserGetElementChildrenPropertiespropCount++;
                }

                browserGetElementChildrenPropertiespropCount++;
            }
            else
            {
                browserGetElementChildrenProperties["ReturnText"] = true;
                browserGetElementChildrenPropertiespropCount++;
            }

            if (browserGetElementChildrenPropertiesmaxValueLength != null)
            {
                if (browserGetElementChildrenPropertiesmaxValueLength != null)
                {
                    browserGetElementChildrenProperties["MaxValueLength"] = CSharpExpressionConverter.ConvertToken(browserGetElementChildrenPropertiesmaxValueLength);
                    browserGetElementChildrenPropertiespropCount++;
                }

                browserGetElementChildrenPropertiespropCount++;
            }
            else
            {
                browserGetElementChildrenProperties["MaxValueLength"] = 0;
                browserGetElementChildrenPropertiespropCount++;
            }

            if (browserGetElementChildrenPropertiesmaxTextLength != null)
            {
                if (browserGetElementChildrenPropertiesmaxTextLength != null)
                {
                    browserGetElementChildrenProperties["MaxTextLength"] = CSharpExpressionConverter.ConvertToken(browserGetElementChildrenPropertiesmaxTextLength);
                    browserGetElementChildrenPropertiespropCount++;
                }

                browserGetElementChildrenPropertiespropCount++;
            }
            else
            {
                browserGetElementChildrenProperties["MaxTextLength"] = 0;
                browserGetElementChildrenPropertiespropCount++;
            }

            if (browserGetElementChildrenPropertiesreturnIsDisplayed != null)
            {
                if (browserGetElementChildrenPropertiesreturnIsDisplayed != null)
                {
                    browserGetElementChildrenProperties["ReturnIsDisplayed"] = CSharpExpressionConverter.ConvertToken(browserGetElementChildrenPropertiesreturnIsDisplayed);
                    browserGetElementChildrenPropertiespropCount++;
                }

                browserGetElementChildrenPropertiespropCount++;
            }
            else
            {
                browserGetElementChildrenProperties["ReturnIsDisplayed"] = true;
                browserGetElementChildrenPropertiespropCount++;
            }

            if (browserGetElementChildrenPropertiesreturnCoordinates != null)
            {
                if (browserGetElementChildrenPropertiesreturnCoordinates != null)
                {
                    browserGetElementChildrenProperties["ReturnCoordinates"] = CSharpExpressionConverter.ConvertToken(browserGetElementChildrenPropertiesreturnCoordinates);
                    browserGetElementChildrenPropertiespropCount++;
                }

                browserGetElementChildrenPropertiespropCount++;
            }
            else
            {
                browserGetElementChildrenProperties["ReturnCoordinates"] = true;
                browserGetElementChildrenPropertiespropCount++;
            }

            if (browserGetElementChildrenPropertiesreturnDimensions != null)
            {
                if (browserGetElementChildrenPropertiesreturnDimensions != null)
                {
                    browserGetElementChildrenProperties["ReturnDimensions"] = CSharpExpressionConverter.ConvertToken(browserGetElementChildrenPropertiesreturnDimensions);
                    browserGetElementChildrenPropertiespropCount++;
                }

                browserGetElementChildrenPropertiespropCount++;
            }
            else
            {
                browserGetElementChildrenProperties["ReturnDimensions"] = true;
                browserGetElementChildrenPropertiespropCount++;
            }

            if (browserGetElementChildrenPropertiesreturnChildElementCount != null)
            {
                if (browserGetElementChildrenPropertiesreturnChildElementCount != null)
                {
                    browserGetElementChildrenProperties["ReturnChildElementCount"] = CSharpExpressionConverter.ConvertToken(browserGetElementChildrenPropertiesreturnChildElementCount);
                    browserGetElementChildrenPropertiespropCount++;
                }

                browserGetElementChildrenPropertiespropCount++;
            }
            else
            {
                browserGetElementChildrenProperties["ReturnChildElementCount"] = true;
                browserGetElementChildrenPropertiespropCount++;
            }

            if (browserGetElementChildrenPropertiesreturnParentTag != null)
            {
                if (browserGetElementChildrenPropertiesreturnParentTag != null)
                {
                    browserGetElementChildrenProperties["ReturnParentTag"] = CSharpExpressionConverter.ConvertToken(browserGetElementChildrenPropertiesreturnParentTag);
                    browserGetElementChildrenPropertiespropCount++;
                }

                browserGetElementChildrenPropertiespropCount++;
            }
            else
            {
                browserGetElementChildrenProperties["ReturnParentTag"] = true;
                browserGetElementChildrenPropertiespropCount++;
            }

            if (browserGetElementChildrenPropertiesfirstItemToReturn != null)
            {
                if (browserGetElementChildrenPropertiesfirstItemToReturn != null)
                {
                    browserGetElementChildrenProperties["FirstItemToReturn"] = CSharpExpressionConverter.ConvertToken(browserGetElementChildrenPropertiesfirstItemToReturn);
                    browserGetElementChildrenPropertiespropCount++;
                }

                browserGetElementChildrenPropertiespropCount++;
            }
            else
            {
                browserGetElementChildrenProperties["FirstItemToReturn"] = 1;
                browserGetElementChildrenPropertiespropCount++;
            }

            if (browserGetElementChildrenPropertiesmaxItemsToReturn != null)
            {
                if (browserGetElementChildrenPropertiesmaxItemsToReturn != null)
                {
                    browserGetElementChildrenProperties["MaxItemsToReturn"] = CSharpExpressionConverter.ConvertToken(browserGetElementChildrenPropertiesmaxItemsToReturn);
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
            browserGetElementChildrenProperties["Workflow"] = CSharpExpressionConverter.ConvertToken(browserGetElementChildrenPropertiesworkflow);
            if (browserGetElementChildrenPropertiespropCount > 0)
            {
                callPayload.Body = browserGetElementChildrenProperties;
            }

            return new ApiConnectionAction<BrowserGetElementChildrenPropertiesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserInputTextIntoElementResponse> BrowserInputTextIntoElement(Expression<Func<string>> browserInputTextIntoElementworkflow, Expression<Func<double>> browserInputTextIntoElementparentElementHandle = null, Expression<Func<double>> browserInputTextIntoElementsearchElementHandle = null, Expression<Func<string>> browserInputTextIntoElementsearchElementName = null, Expression<Func<string>> browserInputTextIntoElementsearchElementID = null, Expression<Func<string>> browserInputTextIntoElementsearchElementTagName = null, Expression<Func<string>> browserInputTextIntoElementsearchElementXPath = null, Expression<Func<string>> browserInputTextIntoElementsearchElementClassName = null, Expression<Func<string>> browserInputTextIntoElementsearchElementCSSSelector = null, Expression<Func<double>> browserInputTextIntoElementsearchElementIndex = null, Expression<Func<string>> browserInputTextIntoElementsearchElementMatchValue = null, Expression<Func<string>> browserInputTextIntoElementsearchElementMatchText = null, Expression<Func<string>> browserInputTextIntoElementsearchElementType = null, Expression<Func<double>> browserInputTextIntoElementsearchElementMinimumWidth = null, Expression<Func<double>> browserInputTextIntoElementsearchElementMinimumHeight = null, Expression<Func<double>> browserInputTextIntoElementsearchElementBoundingBoxLeft = null, Expression<Func<double>> browserInputTextIntoElementsearchElementBoundingBoxRight = null, Expression<Func<double>> browserInputTextIntoElementsearchElementBoundingBoxTop = null, Expression<Func<double>> browserInputTextIntoElementsearchElementBoundingBoxBottom = null, Expression<Func<bool>> browserInputTextIntoElementonlyElementTopLeftNeedsToBeInBoundingBox = null, Expression<Func<string>> browserInputTextIntoElementtextToInput = null, Expression<Func<bool>> browserInputTextIntoElementresetExistingValue = null, Expression<Func<int>> browserInputTextIntoElementinsertPosition = null)
        {
            var apiCallPath = "/BrowserControl/InputTextIntoElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserInputTextIntoElement = new JObject();
            var browserInputTextIntoElementpropCount = 0;
            if (browserInputTextIntoElementparentElementHandle != null)
            {
                browserInputTextIntoElement["ParentElementHandle"] = CSharpExpressionConverter.ConvertToken(browserInputTextIntoElementparentElementHandle);
                browserInputTextIntoElementpropCount++;
            }

            if (browserInputTextIntoElementsearchElementHandle != null)
            {
                browserInputTextIntoElement["SearchElementHandle"] = CSharpExpressionConverter.ConvertToken(browserInputTextIntoElementsearchElementHandle);
                browserInputTextIntoElementpropCount++;
            }

            if (browserInputTextIntoElementsearchElementName != null)
            {
                browserInputTextIntoElement["SearchElementName"] = CSharpExpressionConverter.ConvertToken(browserInputTextIntoElementsearchElementName);
                browserInputTextIntoElementpropCount++;
            }

            if (browserInputTextIntoElementsearchElementID != null)
            {
                browserInputTextIntoElement["SearchElementID"] = CSharpExpressionConverter.ConvertToken(browserInputTextIntoElementsearchElementID);
                browserInputTextIntoElementpropCount++;
            }

            if (browserInputTextIntoElementsearchElementTagName != null)
            {
                browserInputTextIntoElement["SearchElementTagName"] = CSharpExpressionConverter.ConvertToken(browserInputTextIntoElementsearchElementTagName);
                browserInputTextIntoElementpropCount++;
            }

            if (browserInputTextIntoElementsearchElementXPath != null)
            {
                browserInputTextIntoElement["SearchElementXPath"] = CSharpExpressionConverter.ConvertToken(browserInputTextIntoElementsearchElementXPath);
                browserInputTextIntoElementpropCount++;
            }

            if (browserInputTextIntoElementsearchElementClassName != null)
            {
                browserInputTextIntoElement["SearchElementClassName"] = CSharpExpressionConverter.ConvertToken(browserInputTextIntoElementsearchElementClassName);
                browserInputTextIntoElementpropCount++;
            }

            if (browserInputTextIntoElementsearchElementCSSSelector != null)
            {
                browserInputTextIntoElement["SearchElementCSSSelector"] = CSharpExpressionConverter.ConvertToken(browserInputTextIntoElementsearchElementCSSSelector);
                browserInputTextIntoElementpropCount++;
            }

            if (browserInputTextIntoElementsearchElementIndex != null)
            {
                if (browserInputTextIntoElementsearchElementIndex != null)
                {
                    browserInputTextIntoElement["SearchElementIndex"] = CSharpExpressionConverter.ConvertToken(browserInputTextIntoElementsearchElementIndex);
                    browserInputTextIntoElementpropCount++;
                }

                browserInputTextIntoElementpropCount++;
            }
            else
            {
                browserInputTextIntoElement["SearchElementIndex"] = 1;
                browserInputTextIntoElementpropCount++;
            }

            if (browserInputTextIntoElementsearchElementMatchValue != null)
            {
                browserInputTextIntoElement["SearchElementMatchValue"] = CSharpExpressionConverter.ConvertToken(browserInputTextIntoElementsearchElementMatchValue);
                browserInputTextIntoElementpropCount++;
            }

            if (browserInputTextIntoElementsearchElementMatchText != null)
            {
                browserInputTextIntoElement["SearchElementMatchText"] = CSharpExpressionConverter.ConvertToken(browserInputTextIntoElementsearchElementMatchText);
                browserInputTextIntoElementpropCount++;
            }

            if (browserInputTextIntoElementsearchElementType != null)
            {
                browserInputTextIntoElement["SearchElementType"] = CSharpExpressionConverter.ConvertToken(browserInputTextIntoElementsearchElementType);
                browserInputTextIntoElementpropCount++;
            }

            if (browserInputTextIntoElementsearchElementMinimumWidth != null)
            {
                if (browserInputTextIntoElementsearchElementMinimumWidth != null)
                {
                    browserInputTextIntoElement["SearchElementMinimumWidth"] = CSharpExpressionConverter.ConvertToken(browserInputTextIntoElementsearchElementMinimumWidth);
                    browserInputTextIntoElementpropCount++;
                }

                browserInputTextIntoElementpropCount++;
            }
            else
            {
                browserInputTextIntoElement["SearchElementMinimumWidth"] = 1;
                browserInputTextIntoElementpropCount++;
            }

            if (browserInputTextIntoElementsearchElementMinimumHeight != null)
            {
                if (browserInputTextIntoElementsearchElementMinimumHeight != null)
                {
                    browserInputTextIntoElement["SearchElementMinimumHeight"] = CSharpExpressionConverter.ConvertToken(browserInputTextIntoElementsearchElementMinimumHeight);
                    browserInputTextIntoElementpropCount++;
                }

                browserInputTextIntoElementpropCount++;
            }
            else
            {
                browserInputTextIntoElement["SearchElementMinimumHeight"] = 1;
                browserInputTextIntoElementpropCount++;
            }

            if (browserInputTextIntoElementsearchElementBoundingBoxLeft != null)
            {
                if (browserInputTextIntoElementsearchElementBoundingBoxLeft != null)
                {
                    browserInputTextIntoElement["SearchElementBoundingBoxLeft"] = CSharpExpressionConverter.ConvertToken(browserInputTextIntoElementsearchElementBoundingBoxLeft);
                    browserInputTextIntoElementpropCount++;
                }

                browserInputTextIntoElementpropCount++;
            }
            else
            {
                browserInputTextIntoElement["SearchElementBoundingBoxLeft"] = -99999;
                browserInputTextIntoElementpropCount++;
            }

            if (browserInputTextIntoElementsearchElementBoundingBoxRight != null)
            {
                if (browserInputTextIntoElementsearchElementBoundingBoxRight != null)
                {
                    browserInputTextIntoElement["SearchElementBoundingBoxRight"] = CSharpExpressionConverter.ConvertToken(browserInputTextIntoElementsearchElementBoundingBoxRight);
                    browserInputTextIntoElementpropCount++;
                }

                browserInputTextIntoElementpropCount++;
            }
            else
            {
                browserInputTextIntoElement["SearchElementBoundingBoxRight"] = 99999;
                browserInputTextIntoElementpropCount++;
            }

            if (browserInputTextIntoElementsearchElementBoundingBoxTop != null)
            {
                if (browserInputTextIntoElementsearchElementBoundingBoxTop != null)
                {
                    browserInputTextIntoElement["SearchElementBoundingBoxTop"] = CSharpExpressionConverter.ConvertToken(browserInputTextIntoElementsearchElementBoundingBoxTop);
                    browserInputTextIntoElementpropCount++;
                }

                browserInputTextIntoElementpropCount++;
            }
            else
            {
                browserInputTextIntoElement["SearchElementBoundingBoxTop"] = -99999;
                browserInputTextIntoElementpropCount++;
            }

            if (browserInputTextIntoElementsearchElementBoundingBoxBottom != null)
            {
                if (browserInputTextIntoElementsearchElementBoundingBoxBottom != null)
                {
                    browserInputTextIntoElement["SearchElementBoundingBoxBottom"] = CSharpExpressionConverter.ConvertToken(browserInputTextIntoElementsearchElementBoundingBoxBottom);
                    browserInputTextIntoElementpropCount++;
                }

                browserInputTextIntoElementpropCount++;
            }
            else
            {
                browserInputTextIntoElement["SearchElementBoundingBoxBottom"] = 99999;
                browserInputTextIntoElementpropCount++;
            }

            if (browserInputTextIntoElementonlyElementTopLeftNeedsToBeInBoundingBox != null)
            {
                if (browserInputTextIntoElementonlyElementTopLeftNeedsToBeInBoundingBox != null)
                {
                    browserInputTextIntoElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = CSharpExpressionConverter.ConvertToken(browserInputTextIntoElementonlyElementTopLeftNeedsToBeInBoundingBox);
                    browserInputTextIntoElementpropCount++;
                }

                browserInputTextIntoElementpropCount++;
            }
            else
            {
                browserInputTextIntoElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = false;
                browserInputTextIntoElementpropCount++;
            }

            if (browserInputTextIntoElementtextToInput != null)
            {
                browserInputTextIntoElement["TextToInput"] = CSharpExpressionConverter.ConvertToken(browserInputTextIntoElementtextToInput);
                browserInputTextIntoElementpropCount++;
            }

            if (browserInputTextIntoElementresetExistingValue != null)
            {
                if (browserInputTextIntoElementresetExistingValue != null)
                {
                    browserInputTextIntoElement["ResetExistingValue"] = CSharpExpressionConverter.ConvertToken(browserInputTextIntoElementresetExistingValue);
                    browserInputTextIntoElementpropCount++;
                }

                browserInputTextIntoElementpropCount++;
            }
            else
            {
                browserInputTextIntoElement["ResetExistingValue"] = true;
                browserInputTextIntoElementpropCount++;
            }

            if (browserInputTextIntoElementinsertPosition != null)
            {
                if (browserInputTextIntoElementinsertPosition != null)
                {
                    browserInputTextIntoElement["InsertPosition"] = CSharpExpressionConverter.ConvertToken(browserInputTextIntoElementinsertPosition);
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
            browserInputTextIntoElement["Workflow"] = CSharpExpressionConverter.ConvertToken(browserInputTextIntoElementworkflow);
            if (browserInputTextIntoElementpropCount > 0)
            {
                callPayload.Body = browserInputTextIntoElement;
            }

            return new ApiConnectionAction<BrowserInputTextIntoElementResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserInputTextIntoMultipleElements(Expression<Func<string>> browserInputTextIntoMultipleElementsinputElementsJSON, Expression<Func<string>> browserInputTextIntoMultipleElementsworkflow)
        {
            var apiCallPath = "/BrowserControl/BrowserInputTextIntoMultipleElements";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserInputTextIntoMultipleElements = new JObject();
            var browserInputTextIntoMultipleElementspropCount = 0;
            browserInputTextIntoMultipleElementspropCount++;
            browserInputTextIntoMultipleElements["InputElementsJSON"] = CSharpExpressionConverter.ConvertToken(browserInputTextIntoMultipleElementsinputElementsJSON);
            browserInputTextIntoMultipleElementspropCount++;
            browserInputTextIntoMultipleElements["Workflow"] = CSharpExpressionConverter.ConvertToken(browserInputTextIntoMultipleElementsworkflow);
            if (browserInputTextIntoMultipleElementspropCount > 0)
            {
                callPayload.Body = browserInputTextIntoMultipleElements;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserPressCtrlKeyOnElement(Expression<Func<string>> browserPressCtrlKeyOnElementcontrolKey, Expression<Func<string>> browserPressCtrlKeyOnElementworkflow, Expression<Func<double>> browserPressCtrlKeyOnElementparentElementHandle = null, Expression<Func<double>> browserPressCtrlKeyOnElementsearchElementHandle = null, Expression<Func<string>> browserPressCtrlKeyOnElementsearchElementName = null, Expression<Func<string>> browserPressCtrlKeyOnElementsearchElementID = null, Expression<Func<string>> browserPressCtrlKeyOnElementsearchElementTagName = null, Expression<Func<string>> browserPressCtrlKeyOnElementsearchElementXPath = null, Expression<Func<string>> browserPressCtrlKeyOnElementsearchElementClassName = null, Expression<Func<string>> browserPressCtrlKeyOnElementsearchElementCSSSelector = null, Expression<Func<double>> browserPressCtrlKeyOnElementsearchElementIndex = null, Expression<Func<string>> browserPressCtrlKeyOnElementsearchElementMatchValue = null, Expression<Func<string>> browserPressCtrlKeyOnElementsearchElementMatchText = null, Expression<Func<string>> browserPressCtrlKeyOnElementsearchElementType = null, Expression<Func<double>> browserPressCtrlKeyOnElementsearchElementMinimumWidth = null, Expression<Func<double>> browserPressCtrlKeyOnElementsearchElementMinimumHeight = null, Expression<Func<double>> browserPressCtrlKeyOnElementsearchElementBoundingBoxLeft = null, Expression<Func<double>> browserPressCtrlKeyOnElementsearchElementBoundingBoxRight = null, Expression<Func<double>> browserPressCtrlKeyOnElementsearchElementBoundingBoxTop = null, Expression<Func<double>> browserPressCtrlKeyOnElementsearchElementBoundingBoxBottom = null, Expression<Func<bool>> browserPressCtrlKeyOnElementonlyElementTopLeftNeedsToBeInBoundingBox = null)
        {
            var apiCallPath = "/BrowserControl/PressCtrlKeyOnElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserPressCtrlKeyOnElement = new JObject();
            var browserPressCtrlKeyOnElementpropCount = 0;
            if (browserPressCtrlKeyOnElementparentElementHandle != null)
            {
                browserPressCtrlKeyOnElement["ParentElementHandle"] = CSharpExpressionConverter.ConvertToken(browserPressCtrlKeyOnElementparentElementHandle);
                browserPressCtrlKeyOnElementpropCount++;
            }

            if (browserPressCtrlKeyOnElementsearchElementHandle != null)
            {
                browserPressCtrlKeyOnElement["SearchElementHandle"] = CSharpExpressionConverter.ConvertToken(browserPressCtrlKeyOnElementsearchElementHandle);
                browserPressCtrlKeyOnElementpropCount++;
            }

            if (browserPressCtrlKeyOnElementsearchElementName != null)
            {
                browserPressCtrlKeyOnElement["SearchElementName"] = CSharpExpressionConverter.ConvertToken(browserPressCtrlKeyOnElementsearchElementName);
                browserPressCtrlKeyOnElementpropCount++;
            }

            if (browserPressCtrlKeyOnElementsearchElementID != null)
            {
                browserPressCtrlKeyOnElement["SearchElementID"] = CSharpExpressionConverter.ConvertToken(browserPressCtrlKeyOnElementsearchElementID);
                browserPressCtrlKeyOnElementpropCount++;
            }

            if (browserPressCtrlKeyOnElementsearchElementTagName != null)
            {
                browserPressCtrlKeyOnElement["SearchElementTagName"] = CSharpExpressionConverter.ConvertToken(browserPressCtrlKeyOnElementsearchElementTagName);
                browserPressCtrlKeyOnElementpropCount++;
            }

            if (browserPressCtrlKeyOnElementsearchElementXPath != null)
            {
                browserPressCtrlKeyOnElement["SearchElementXPath"] = CSharpExpressionConverter.ConvertToken(browserPressCtrlKeyOnElementsearchElementXPath);
                browserPressCtrlKeyOnElementpropCount++;
            }

            if (browserPressCtrlKeyOnElementsearchElementClassName != null)
            {
                browserPressCtrlKeyOnElement["SearchElementClassName"] = CSharpExpressionConverter.ConvertToken(browserPressCtrlKeyOnElementsearchElementClassName);
                browserPressCtrlKeyOnElementpropCount++;
            }

            if (browserPressCtrlKeyOnElementsearchElementCSSSelector != null)
            {
                browserPressCtrlKeyOnElement["SearchElementCSSSelector"] = CSharpExpressionConverter.ConvertToken(browserPressCtrlKeyOnElementsearchElementCSSSelector);
                browserPressCtrlKeyOnElementpropCount++;
            }

            if (browserPressCtrlKeyOnElementsearchElementIndex != null)
            {
                if (browserPressCtrlKeyOnElementsearchElementIndex != null)
                {
                    browserPressCtrlKeyOnElement["SearchElementIndex"] = CSharpExpressionConverter.ConvertToken(browserPressCtrlKeyOnElementsearchElementIndex);
                    browserPressCtrlKeyOnElementpropCount++;
                }

                browserPressCtrlKeyOnElementpropCount++;
            }
            else
            {
                browserPressCtrlKeyOnElement["SearchElementIndex"] = 1;
                browserPressCtrlKeyOnElementpropCount++;
            }

            if (browserPressCtrlKeyOnElementsearchElementMatchValue != null)
            {
                browserPressCtrlKeyOnElement["SearchElementMatchValue"] = CSharpExpressionConverter.ConvertToken(browserPressCtrlKeyOnElementsearchElementMatchValue);
                browserPressCtrlKeyOnElementpropCount++;
            }

            if (browserPressCtrlKeyOnElementsearchElementMatchText != null)
            {
                browserPressCtrlKeyOnElement["SearchElementMatchText"] = CSharpExpressionConverter.ConvertToken(browserPressCtrlKeyOnElementsearchElementMatchText);
                browserPressCtrlKeyOnElementpropCount++;
            }

            if (browserPressCtrlKeyOnElementsearchElementType != null)
            {
                browserPressCtrlKeyOnElement["SearchElementType"] = CSharpExpressionConverter.ConvertToken(browserPressCtrlKeyOnElementsearchElementType);
                browserPressCtrlKeyOnElementpropCount++;
            }

            if (browserPressCtrlKeyOnElementsearchElementMinimumWidth != null)
            {
                if (browserPressCtrlKeyOnElementsearchElementMinimumWidth != null)
                {
                    browserPressCtrlKeyOnElement["SearchElementMinimumWidth"] = CSharpExpressionConverter.ConvertToken(browserPressCtrlKeyOnElementsearchElementMinimumWidth);
                    browserPressCtrlKeyOnElementpropCount++;
                }

                browserPressCtrlKeyOnElementpropCount++;
            }
            else
            {
                browserPressCtrlKeyOnElement["SearchElementMinimumWidth"] = 1;
                browserPressCtrlKeyOnElementpropCount++;
            }

            if (browserPressCtrlKeyOnElementsearchElementMinimumHeight != null)
            {
                if (browserPressCtrlKeyOnElementsearchElementMinimumHeight != null)
                {
                    browserPressCtrlKeyOnElement["SearchElementMinimumHeight"] = CSharpExpressionConverter.ConvertToken(browserPressCtrlKeyOnElementsearchElementMinimumHeight);
                    browserPressCtrlKeyOnElementpropCount++;
                }

                browserPressCtrlKeyOnElementpropCount++;
            }
            else
            {
                browserPressCtrlKeyOnElement["SearchElementMinimumHeight"] = 1;
                browserPressCtrlKeyOnElementpropCount++;
            }

            if (browserPressCtrlKeyOnElementsearchElementBoundingBoxLeft != null)
            {
                if (browserPressCtrlKeyOnElementsearchElementBoundingBoxLeft != null)
                {
                    browserPressCtrlKeyOnElement["SearchElementBoundingBoxLeft"] = CSharpExpressionConverter.ConvertToken(browserPressCtrlKeyOnElementsearchElementBoundingBoxLeft);
                    browserPressCtrlKeyOnElementpropCount++;
                }

                browserPressCtrlKeyOnElementpropCount++;
            }
            else
            {
                browserPressCtrlKeyOnElement["SearchElementBoundingBoxLeft"] = -99999;
                browserPressCtrlKeyOnElementpropCount++;
            }

            if (browserPressCtrlKeyOnElementsearchElementBoundingBoxRight != null)
            {
                if (browserPressCtrlKeyOnElementsearchElementBoundingBoxRight != null)
                {
                    browserPressCtrlKeyOnElement["SearchElementBoundingBoxRight"] = CSharpExpressionConverter.ConvertToken(browserPressCtrlKeyOnElementsearchElementBoundingBoxRight);
                    browserPressCtrlKeyOnElementpropCount++;
                }

                browserPressCtrlKeyOnElementpropCount++;
            }
            else
            {
                browserPressCtrlKeyOnElement["SearchElementBoundingBoxRight"] = 99999;
                browserPressCtrlKeyOnElementpropCount++;
            }

            if (browserPressCtrlKeyOnElementsearchElementBoundingBoxTop != null)
            {
                if (browserPressCtrlKeyOnElementsearchElementBoundingBoxTop != null)
                {
                    browserPressCtrlKeyOnElement["SearchElementBoundingBoxTop"] = CSharpExpressionConverter.ConvertToken(browserPressCtrlKeyOnElementsearchElementBoundingBoxTop);
                    browserPressCtrlKeyOnElementpropCount++;
                }

                browserPressCtrlKeyOnElementpropCount++;
            }
            else
            {
                browserPressCtrlKeyOnElement["SearchElementBoundingBoxTop"] = -99999;
                browserPressCtrlKeyOnElementpropCount++;
            }

            if (browserPressCtrlKeyOnElementsearchElementBoundingBoxBottom != null)
            {
                if (browserPressCtrlKeyOnElementsearchElementBoundingBoxBottom != null)
                {
                    browserPressCtrlKeyOnElement["SearchElementBoundingBoxBottom"] = CSharpExpressionConverter.ConvertToken(browserPressCtrlKeyOnElementsearchElementBoundingBoxBottom);
                    browserPressCtrlKeyOnElementpropCount++;
                }

                browserPressCtrlKeyOnElementpropCount++;
            }
            else
            {
                browserPressCtrlKeyOnElement["SearchElementBoundingBoxBottom"] = 99999;
                browserPressCtrlKeyOnElementpropCount++;
            }

            if (browserPressCtrlKeyOnElementonlyElementTopLeftNeedsToBeInBoundingBox != null)
            {
                if (browserPressCtrlKeyOnElementonlyElementTopLeftNeedsToBeInBoundingBox != null)
                {
                    browserPressCtrlKeyOnElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = CSharpExpressionConverter.ConvertToken(browserPressCtrlKeyOnElementonlyElementTopLeftNeedsToBeInBoundingBox);
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
            browserPressCtrlKeyOnElement["ControlKey"] = CSharpExpressionConverter.ConvertToken(browserPressCtrlKeyOnElementcontrolKey);
            browserPressCtrlKeyOnElementpropCount++;
            browserPressCtrlKeyOnElement["Workflow"] = CSharpExpressionConverter.ConvertToken(browserPressCtrlKeyOnElementworkflow);
            if (browserPressCtrlKeyOnElementpropCount > 0)
            {
                callPayload.Body = browserPressCtrlKeyOnElement;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserClickElement(Expression<Func<string>> browserClickElementworkflow, Expression<Func<double>> browserClickElementparentElementHandle = null, Expression<Func<double>> browserClickElementsearchElementHandle = null, Expression<Func<string>> browserClickElementsearchElementName = null, Expression<Func<string>> browserClickElementsearchElementID = null, Expression<Func<string>> browserClickElementsearchElementTagName = null, Expression<Func<string>> browserClickElementsearchElementXPath = null, Expression<Func<string>> browserClickElementsearchElementClassName = null, Expression<Func<string>> browserClickElementsearchElementCSSSelector = null, Expression<Func<double>> browserClickElementsearchElementIndex = null, Expression<Func<string>> browserClickElementsearchElementMatchValue = null, Expression<Func<string>> browserClickElementsearchElementMatchText = null, Expression<Func<string>> browserClickElementsearchElementType = null, Expression<Func<double>> browserClickElementsearchElementMinimumWidth = null, Expression<Func<double>> browserClickElementsearchElementMinimumHeight = null, Expression<Func<double>> browserClickElementsearchElementBoundingBoxLeft = null, Expression<Func<double>> browserClickElementsearchElementBoundingBoxRight = null, Expression<Func<double>> browserClickElementsearchElementBoundingBoxTop = null, Expression<Func<double>> browserClickElementsearchElementBoundingBoxBottom = null, Expression<Func<bool>> browserClickElementonlyElementTopLeftNeedsToBeInBoundingBox = null)
        {
            var apiCallPath = "/BrowserControl/ClickElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserClickElement = new JObject();
            var browserClickElementpropCount = 0;
            if (browserClickElementparentElementHandle != null)
            {
                browserClickElement["ParentElementHandle"] = CSharpExpressionConverter.ConvertToken(browserClickElementparentElementHandle);
                browserClickElementpropCount++;
            }

            if (browserClickElementsearchElementHandle != null)
            {
                browserClickElement["SearchElementHandle"] = CSharpExpressionConverter.ConvertToken(browserClickElementsearchElementHandle);
                browserClickElementpropCount++;
            }

            if (browserClickElementsearchElementName != null)
            {
                browserClickElement["SearchElementName"] = CSharpExpressionConverter.ConvertToken(browserClickElementsearchElementName);
                browserClickElementpropCount++;
            }

            if (browserClickElementsearchElementID != null)
            {
                browserClickElement["SearchElementID"] = CSharpExpressionConverter.ConvertToken(browserClickElementsearchElementID);
                browserClickElementpropCount++;
            }

            if (browserClickElementsearchElementTagName != null)
            {
                browserClickElement["SearchElementTagName"] = CSharpExpressionConverter.ConvertToken(browserClickElementsearchElementTagName);
                browserClickElementpropCount++;
            }

            if (browserClickElementsearchElementXPath != null)
            {
                browserClickElement["SearchElementXPath"] = CSharpExpressionConverter.ConvertToken(browserClickElementsearchElementXPath);
                browserClickElementpropCount++;
            }

            if (browserClickElementsearchElementClassName != null)
            {
                browserClickElement["SearchElementClassName"] = CSharpExpressionConverter.ConvertToken(browserClickElementsearchElementClassName);
                browserClickElementpropCount++;
            }

            if (browserClickElementsearchElementCSSSelector != null)
            {
                browserClickElement["SearchElementCSSSelector"] = CSharpExpressionConverter.ConvertToken(browserClickElementsearchElementCSSSelector);
                browserClickElementpropCount++;
            }

            if (browserClickElementsearchElementIndex != null)
            {
                if (browserClickElementsearchElementIndex != null)
                {
                    browserClickElement["SearchElementIndex"] = CSharpExpressionConverter.ConvertToken(browserClickElementsearchElementIndex);
                    browserClickElementpropCount++;
                }

                browserClickElementpropCount++;
            }
            else
            {
                browserClickElement["SearchElementIndex"] = 1;
                browserClickElementpropCount++;
            }

            if (browserClickElementsearchElementMatchValue != null)
            {
                browserClickElement["SearchElementMatchValue"] = CSharpExpressionConverter.ConvertToken(browserClickElementsearchElementMatchValue);
                browserClickElementpropCount++;
            }

            if (browserClickElementsearchElementMatchText != null)
            {
                browserClickElement["SearchElementMatchText"] = CSharpExpressionConverter.ConvertToken(browserClickElementsearchElementMatchText);
                browserClickElementpropCount++;
            }

            if (browserClickElementsearchElementType != null)
            {
                browserClickElement["SearchElementType"] = CSharpExpressionConverter.ConvertToken(browserClickElementsearchElementType);
                browserClickElementpropCount++;
            }

            if (browserClickElementsearchElementMinimumWidth != null)
            {
                if (browserClickElementsearchElementMinimumWidth != null)
                {
                    browserClickElement["SearchElementMinimumWidth"] = CSharpExpressionConverter.ConvertToken(browserClickElementsearchElementMinimumWidth);
                    browserClickElementpropCount++;
                }

                browserClickElementpropCount++;
            }
            else
            {
                browserClickElement["SearchElementMinimumWidth"] = 1;
                browserClickElementpropCount++;
            }

            if (browserClickElementsearchElementMinimumHeight != null)
            {
                if (browserClickElementsearchElementMinimumHeight != null)
                {
                    browserClickElement["SearchElementMinimumHeight"] = CSharpExpressionConverter.ConvertToken(browserClickElementsearchElementMinimumHeight);
                    browserClickElementpropCount++;
                }

                browserClickElementpropCount++;
            }
            else
            {
                browserClickElement["SearchElementMinimumHeight"] = 1;
                browserClickElementpropCount++;
            }

            if (browserClickElementsearchElementBoundingBoxLeft != null)
            {
                if (browserClickElementsearchElementBoundingBoxLeft != null)
                {
                    browserClickElement["SearchElementBoundingBoxLeft"] = CSharpExpressionConverter.ConvertToken(browserClickElementsearchElementBoundingBoxLeft);
                    browserClickElementpropCount++;
                }

                browserClickElementpropCount++;
            }
            else
            {
                browserClickElement["SearchElementBoundingBoxLeft"] = -99999;
                browserClickElementpropCount++;
            }

            if (browserClickElementsearchElementBoundingBoxRight != null)
            {
                if (browserClickElementsearchElementBoundingBoxRight != null)
                {
                    browserClickElement["SearchElementBoundingBoxRight"] = CSharpExpressionConverter.ConvertToken(browserClickElementsearchElementBoundingBoxRight);
                    browserClickElementpropCount++;
                }

                browserClickElementpropCount++;
            }
            else
            {
                browserClickElement["SearchElementBoundingBoxRight"] = 99999;
                browserClickElementpropCount++;
            }

            if (browserClickElementsearchElementBoundingBoxTop != null)
            {
                if (browserClickElementsearchElementBoundingBoxTop != null)
                {
                    browserClickElement["SearchElementBoundingBoxTop"] = CSharpExpressionConverter.ConvertToken(browserClickElementsearchElementBoundingBoxTop);
                    browserClickElementpropCount++;
                }

                browserClickElementpropCount++;
            }
            else
            {
                browserClickElement["SearchElementBoundingBoxTop"] = -99999;
                browserClickElementpropCount++;
            }

            if (browserClickElementsearchElementBoundingBoxBottom != null)
            {
                if (browserClickElementsearchElementBoundingBoxBottom != null)
                {
                    browserClickElement["SearchElementBoundingBoxBottom"] = CSharpExpressionConverter.ConvertToken(browserClickElementsearchElementBoundingBoxBottom);
                    browserClickElementpropCount++;
                }

                browserClickElementpropCount++;
            }
            else
            {
                browserClickElement["SearchElementBoundingBoxBottom"] = 99999;
                browserClickElementpropCount++;
            }

            if (browserClickElementonlyElementTopLeftNeedsToBeInBoundingBox != null)
            {
                if (browserClickElementonlyElementTopLeftNeedsToBeInBoundingBox != null)
                {
                    browserClickElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = CSharpExpressionConverter.ConvertToken(browserClickElementonlyElementTopLeftNeedsToBeInBoundingBox);
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
            browserClickElement["Workflow"] = CSharpExpressionConverter.ConvertToken(browserClickElementworkflow);
            if (browserClickElementpropCount > 0)
            {
                callPayload.Body = browserClickElement;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserSubmitElement(Expression<Func<string>> browserSubmitElementworkflow, Expression<Func<double>> browserSubmitElementparentElementHandle = null, Expression<Func<double>> browserSubmitElementsearchElementHandle = null, Expression<Func<string>> browserSubmitElementsearchElementName = null, Expression<Func<string>> browserSubmitElementsearchElementID = null, Expression<Func<string>> browserSubmitElementsearchElementTagName = null, Expression<Func<string>> browserSubmitElementsearchElementXPath = null, Expression<Func<string>> browserSubmitElementsearchElementClassName = null, Expression<Func<string>> browserSubmitElementsearchElementCSSSelector = null, Expression<Func<double>> browserSubmitElementsearchElementIndex = null, Expression<Func<string>> browserSubmitElementsearchElementMatchValue = null, Expression<Func<string>> browserSubmitElementsearchElementMatchText = null, Expression<Func<string>> browserSubmitElementsearchElementType = null, Expression<Func<double>> browserSubmitElementsearchElementMinimumWidth = null, Expression<Func<double>> browserSubmitElementsearchElementMinimumHeight = null, Expression<Func<double>> browserSubmitElementsearchElementBoundingBoxLeft = null, Expression<Func<double>> browserSubmitElementsearchElementBoundingBoxRight = null, Expression<Func<double>> browserSubmitElementsearchElementBoundingBoxTop = null, Expression<Func<double>> browserSubmitElementsearchElementBoundingBoxBottom = null, Expression<Func<bool>> browserSubmitElementonlyElementTopLeftNeedsToBeInBoundingBox = null)
        {
            var apiCallPath = "/BrowserControl/SubmitElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserSubmitElement = new JObject();
            var browserSubmitElementpropCount = 0;
            if (browserSubmitElementparentElementHandle != null)
            {
                browserSubmitElement["ParentElementHandle"] = CSharpExpressionConverter.ConvertToken(browserSubmitElementparentElementHandle);
                browserSubmitElementpropCount++;
            }

            if (browserSubmitElementsearchElementHandle != null)
            {
                browserSubmitElement["SearchElementHandle"] = CSharpExpressionConverter.ConvertToken(browserSubmitElementsearchElementHandle);
                browserSubmitElementpropCount++;
            }

            if (browserSubmitElementsearchElementName != null)
            {
                browserSubmitElement["SearchElementName"] = CSharpExpressionConverter.ConvertToken(browserSubmitElementsearchElementName);
                browserSubmitElementpropCount++;
            }

            if (browserSubmitElementsearchElementID != null)
            {
                browserSubmitElement["SearchElementID"] = CSharpExpressionConverter.ConvertToken(browserSubmitElementsearchElementID);
                browserSubmitElementpropCount++;
            }

            if (browserSubmitElementsearchElementTagName != null)
            {
                browserSubmitElement["SearchElementTagName"] = CSharpExpressionConverter.ConvertToken(browserSubmitElementsearchElementTagName);
                browserSubmitElementpropCount++;
            }

            if (browserSubmitElementsearchElementXPath != null)
            {
                browserSubmitElement["SearchElementXPath"] = CSharpExpressionConverter.ConvertToken(browserSubmitElementsearchElementXPath);
                browserSubmitElementpropCount++;
            }

            if (browserSubmitElementsearchElementClassName != null)
            {
                browserSubmitElement["SearchElementClassName"] = CSharpExpressionConverter.ConvertToken(browserSubmitElementsearchElementClassName);
                browserSubmitElementpropCount++;
            }

            if (browserSubmitElementsearchElementCSSSelector != null)
            {
                browserSubmitElement["SearchElementCSSSelector"] = CSharpExpressionConverter.ConvertToken(browserSubmitElementsearchElementCSSSelector);
                browserSubmitElementpropCount++;
            }

            if (browserSubmitElementsearchElementIndex != null)
            {
                if (browserSubmitElementsearchElementIndex != null)
                {
                    browserSubmitElement["SearchElementIndex"] = CSharpExpressionConverter.ConvertToken(browserSubmitElementsearchElementIndex);
                    browserSubmitElementpropCount++;
                }

                browserSubmitElementpropCount++;
            }
            else
            {
                browserSubmitElement["SearchElementIndex"] = 1;
                browserSubmitElementpropCount++;
            }

            if (browserSubmitElementsearchElementMatchValue != null)
            {
                browserSubmitElement["SearchElementMatchValue"] = CSharpExpressionConverter.ConvertToken(browserSubmitElementsearchElementMatchValue);
                browserSubmitElementpropCount++;
            }

            if (browserSubmitElementsearchElementMatchText != null)
            {
                browserSubmitElement["SearchElementMatchText"] = CSharpExpressionConverter.ConvertToken(browserSubmitElementsearchElementMatchText);
                browserSubmitElementpropCount++;
            }

            if (browserSubmitElementsearchElementType != null)
            {
                browserSubmitElement["SearchElementType"] = CSharpExpressionConverter.ConvertToken(browserSubmitElementsearchElementType);
                browserSubmitElementpropCount++;
            }

            if (browserSubmitElementsearchElementMinimumWidth != null)
            {
                if (browserSubmitElementsearchElementMinimumWidth != null)
                {
                    browserSubmitElement["SearchElementMinimumWidth"] = CSharpExpressionConverter.ConvertToken(browserSubmitElementsearchElementMinimumWidth);
                    browserSubmitElementpropCount++;
                }

                browserSubmitElementpropCount++;
            }
            else
            {
                browserSubmitElement["SearchElementMinimumWidth"] = 1;
                browserSubmitElementpropCount++;
            }

            if (browserSubmitElementsearchElementMinimumHeight != null)
            {
                if (browserSubmitElementsearchElementMinimumHeight != null)
                {
                    browserSubmitElement["SearchElementMinimumHeight"] = CSharpExpressionConverter.ConvertToken(browserSubmitElementsearchElementMinimumHeight);
                    browserSubmitElementpropCount++;
                }

                browserSubmitElementpropCount++;
            }
            else
            {
                browserSubmitElement["SearchElementMinimumHeight"] = 1;
                browserSubmitElementpropCount++;
            }

            if (browserSubmitElementsearchElementBoundingBoxLeft != null)
            {
                if (browserSubmitElementsearchElementBoundingBoxLeft != null)
                {
                    browserSubmitElement["SearchElementBoundingBoxLeft"] = CSharpExpressionConverter.ConvertToken(browserSubmitElementsearchElementBoundingBoxLeft);
                    browserSubmitElementpropCount++;
                }

                browserSubmitElementpropCount++;
            }
            else
            {
                browserSubmitElement["SearchElementBoundingBoxLeft"] = -99999;
                browserSubmitElementpropCount++;
            }

            if (browserSubmitElementsearchElementBoundingBoxRight != null)
            {
                if (browserSubmitElementsearchElementBoundingBoxRight != null)
                {
                    browserSubmitElement["SearchElementBoundingBoxRight"] = CSharpExpressionConverter.ConvertToken(browserSubmitElementsearchElementBoundingBoxRight);
                    browserSubmitElementpropCount++;
                }

                browserSubmitElementpropCount++;
            }
            else
            {
                browserSubmitElement["SearchElementBoundingBoxRight"] = 99999;
                browserSubmitElementpropCount++;
            }

            if (browserSubmitElementsearchElementBoundingBoxTop != null)
            {
                if (browserSubmitElementsearchElementBoundingBoxTop != null)
                {
                    browserSubmitElement["SearchElementBoundingBoxTop"] = CSharpExpressionConverter.ConvertToken(browserSubmitElementsearchElementBoundingBoxTop);
                    browserSubmitElementpropCount++;
                }

                browserSubmitElementpropCount++;
            }
            else
            {
                browserSubmitElement["SearchElementBoundingBoxTop"] = -99999;
                browserSubmitElementpropCount++;
            }

            if (browserSubmitElementsearchElementBoundingBoxBottom != null)
            {
                if (browserSubmitElementsearchElementBoundingBoxBottom != null)
                {
                    browserSubmitElement["SearchElementBoundingBoxBottom"] = CSharpExpressionConverter.ConvertToken(browserSubmitElementsearchElementBoundingBoxBottom);
                    browserSubmitElementpropCount++;
                }

                browserSubmitElementpropCount++;
            }
            else
            {
                browserSubmitElement["SearchElementBoundingBoxBottom"] = 99999;
                browserSubmitElementpropCount++;
            }

            if (browserSubmitElementonlyElementTopLeftNeedsToBeInBoundingBox != null)
            {
                if (browserSubmitElementonlyElementTopLeftNeedsToBeInBoundingBox != null)
                {
                    browserSubmitElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = CSharpExpressionConverter.ConvertToken(browserSubmitElementonlyElementTopLeftNeedsToBeInBoundingBox);
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
            browserSubmitElement["Workflow"] = CSharpExpressionConverter.ConvertToken(browserSubmitElementworkflow);
            if (browserSubmitElementpropCount > 0)
            {
                callPayload.Body = browserSubmitElement;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserCheckElement(Expression<Func<string>> browserCheckElementworkflow, Expression<Func<double>> browserCheckElementparentElementHandle = null, Expression<Func<double>> browserCheckElementsearchElementHandle = null, Expression<Func<string>> browserCheckElementsearchElementName = null, Expression<Func<string>> browserCheckElementsearchElementID = null, Expression<Func<string>> browserCheckElementsearchElementTagName = null, Expression<Func<string>> browserCheckElementsearchElementXPath = null, Expression<Func<string>> browserCheckElementsearchElementClassName = null, Expression<Func<string>> browserCheckElementsearchElementCSSSelector = null, Expression<Func<double>> browserCheckElementsearchElementIndex = null, Expression<Func<string>> browserCheckElementsearchElementMatchValue = null, Expression<Func<string>> browserCheckElementsearchElementMatchText = null, Expression<Func<string>> browserCheckElementsearchElementType = null, Expression<Func<double>> browserCheckElementsearchElementMinimumWidth = null, Expression<Func<double>> browserCheckElementsearchElementMinimumHeight = null, Expression<Func<double>> browserCheckElementsearchElementBoundingBoxLeft = null, Expression<Func<double>> browserCheckElementsearchElementBoundingBoxRight = null, Expression<Func<double>> browserCheckElementsearchElementBoundingBoxTop = null, Expression<Func<double>> browserCheckElementsearchElementBoundingBoxBottom = null, Expression<Func<bool>> browserCheckElementonlyElementTopLeftNeedsToBeInBoundingBox = null, Expression<Func<bool>> browserCheckElementcheckElement = null)
        {
            var apiCallPath = "/BrowserControl/CheckElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserCheckElement = new JObject();
            var browserCheckElementpropCount = 0;
            if (browserCheckElementparentElementHandle != null)
            {
                browserCheckElement["ParentElementHandle"] = CSharpExpressionConverter.ConvertToken(browserCheckElementparentElementHandle);
                browserCheckElementpropCount++;
            }

            if (browserCheckElementsearchElementHandle != null)
            {
                browserCheckElement["SearchElementHandle"] = CSharpExpressionConverter.ConvertToken(browserCheckElementsearchElementHandle);
                browserCheckElementpropCount++;
            }

            if (browserCheckElementsearchElementName != null)
            {
                browserCheckElement["SearchElementName"] = CSharpExpressionConverter.ConvertToken(browserCheckElementsearchElementName);
                browserCheckElementpropCount++;
            }

            if (browserCheckElementsearchElementID != null)
            {
                browserCheckElement["SearchElementID"] = CSharpExpressionConverter.ConvertToken(browserCheckElementsearchElementID);
                browserCheckElementpropCount++;
            }

            if (browserCheckElementsearchElementTagName != null)
            {
                browserCheckElement["SearchElementTagName"] = CSharpExpressionConverter.ConvertToken(browserCheckElementsearchElementTagName);
                browserCheckElementpropCount++;
            }

            if (browserCheckElementsearchElementXPath != null)
            {
                browserCheckElement["SearchElementXPath"] = CSharpExpressionConverter.ConvertToken(browserCheckElementsearchElementXPath);
                browserCheckElementpropCount++;
            }

            if (browserCheckElementsearchElementClassName != null)
            {
                browserCheckElement["SearchElementClassName"] = CSharpExpressionConverter.ConvertToken(browserCheckElementsearchElementClassName);
                browserCheckElementpropCount++;
            }

            if (browserCheckElementsearchElementCSSSelector != null)
            {
                browserCheckElement["SearchElementCSSSelector"] = CSharpExpressionConverter.ConvertToken(browserCheckElementsearchElementCSSSelector);
                browserCheckElementpropCount++;
            }

            if (browserCheckElementsearchElementIndex != null)
            {
                if (browserCheckElementsearchElementIndex != null)
                {
                    browserCheckElement["SearchElementIndex"] = CSharpExpressionConverter.ConvertToken(browserCheckElementsearchElementIndex);
                    browserCheckElementpropCount++;
                }

                browserCheckElementpropCount++;
            }
            else
            {
                browserCheckElement["SearchElementIndex"] = 1;
                browserCheckElementpropCount++;
            }

            if (browserCheckElementsearchElementMatchValue != null)
            {
                browserCheckElement["SearchElementMatchValue"] = CSharpExpressionConverter.ConvertToken(browserCheckElementsearchElementMatchValue);
                browserCheckElementpropCount++;
            }

            if (browserCheckElementsearchElementMatchText != null)
            {
                browserCheckElement["SearchElementMatchText"] = CSharpExpressionConverter.ConvertToken(browserCheckElementsearchElementMatchText);
                browserCheckElementpropCount++;
            }

            if (browserCheckElementsearchElementType != null)
            {
                browserCheckElement["SearchElementType"] = CSharpExpressionConverter.ConvertToken(browserCheckElementsearchElementType);
                browserCheckElementpropCount++;
            }

            if (browserCheckElementsearchElementMinimumWidth != null)
            {
                if (browserCheckElementsearchElementMinimumWidth != null)
                {
                    browserCheckElement["SearchElementMinimumWidth"] = CSharpExpressionConverter.ConvertToken(browserCheckElementsearchElementMinimumWidth);
                    browserCheckElementpropCount++;
                }

                browserCheckElementpropCount++;
            }
            else
            {
                browserCheckElement["SearchElementMinimumWidth"] = 1;
                browserCheckElementpropCount++;
            }

            if (browserCheckElementsearchElementMinimumHeight != null)
            {
                if (browserCheckElementsearchElementMinimumHeight != null)
                {
                    browserCheckElement["SearchElementMinimumHeight"] = CSharpExpressionConverter.ConvertToken(browserCheckElementsearchElementMinimumHeight);
                    browserCheckElementpropCount++;
                }

                browserCheckElementpropCount++;
            }
            else
            {
                browserCheckElement["SearchElementMinimumHeight"] = 1;
                browserCheckElementpropCount++;
            }

            if (browserCheckElementsearchElementBoundingBoxLeft != null)
            {
                if (browserCheckElementsearchElementBoundingBoxLeft != null)
                {
                    browserCheckElement["SearchElementBoundingBoxLeft"] = CSharpExpressionConverter.ConvertToken(browserCheckElementsearchElementBoundingBoxLeft);
                    browserCheckElementpropCount++;
                }

                browserCheckElementpropCount++;
            }
            else
            {
                browserCheckElement["SearchElementBoundingBoxLeft"] = -99999;
                browserCheckElementpropCount++;
            }

            if (browserCheckElementsearchElementBoundingBoxRight != null)
            {
                if (browserCheckElementsearchElementBoundingBoxRight != null)
                {
                    browserCheckElement["SearchElementBoundingBoxRight"] = CSharpExpressionConverter.ConvertToken(browserCheckElementsearchElementBoundingBoxRight);
                    browserCheckElementpropCount++;
                }

                browserCheckElementpropCount++;
            }
            else
            {
                browserCheckElement["SearchElementBoundingBoxRight"] = 99999;
                browserCheckElementpropCount++;
            }

            if (browserCheckElementsearchElementBoundingBoxTop != null)
            {
                if (browserCheckElementsearchElementBoundingBoxTop != null)
                {
                    browserCheckElement["SearchElementBoundingBoxTop"] = CSharpExpressionConverter.ConvertToken(browserCheckElementsearchElementBoundingBoxTop);
                    browserCheckElementpropCount++;
                }

                browserCheckElementpropCount++;
            }
            else
            {
                browserCheckElement["SearchElementBoundingBoxTop"] = -99999;
                browserCheckElementpropCount++;
            }

            if (browserCheckElementsearchElementBoundingBoxBottom != null)
            {
                if (browserCheckElementsearchElementBoundingBoxBottom != null)
                {
                    browserCheckElement["SearchElementBoundingBoxBottom"] = CSharpExpressionConverter.ConvertToken(browserCheckElementsearchElementBoundingBoxBottom);
                    browserCheckElementpropCount++;
                }

                browserCheckElementpropCount++;
            }
            else
            {
                browserCheckElement["SearchElementBoundingBoxBottom"] = 99999;
                browserCheckElementpropCount++;
            }

            if (browserCheckElementonlyElementTopLeftNeedsToBeInBoundingBox != null)
            {
                if (browserCheckElementonlyElementTopLeftNeedsToBeInBoundingBox != null)
                {
                    browserCheckElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = CSharpExpressionConverter.ConvertToken(browserCheckElementonlyElementTopLeftNeedsToBeInBoundingBox);
                    browserCheckElementpropCount++;
                }

                browserCheckElementpropCount++;
            }
            else
            {
                browserCheckElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = false;
                browserCheckElementpropCount++;
            }

            if (browserCheckElementcheckElement != null)
            {
                if (browserCheckElementcheckElement != null)
                {
                    browserCheckElement["CheckElement"] = CSharpExpressionConverter.ConvertToken(browserCheckElementcheckElement);
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
            browserCheckElement["Workflow"] = CSharpExpressionConverter.ConvertToken(browserCheckElementworkflow);
            if (browserCheckElementpropCount > 0)
            {
                callPayload.Body = browserCheckElement;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserCheckMultipleElements(Expression<Func<string>> browserCheckMultipleElementsinputElementsJSON, Expression<Func<string>> browserCheckMultipleElementsworkflow)
        {
            var apiCallPath = "/BrowserControl/BrowserCheckMultipleElements";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserCheckMultipleElements = new JObject();
            var browserCheckMultipleElementspropCount = 0;
            browserCheckMultipleElementspropCount++;
            browserCheckMultipleElements["InputElementsJSON"] = CSharpExpressionConverter.ConvertToken(browserCheckMultipleElementsinputElementsJSON);
            browserCheckMultipleElementspropCount++;
            browserCheckMultipleElements["Workflow"] = CSharpExpressionConverter.ConvertToken(browserCheckMultipleElementsworkflow);
            if (browserCheckMultipleElementspropCount > 0)
            {
                callPayload.Body = browserCheckMultipleElements;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserGetSelectionPropertiesResponse> BrowserGetSelectionProperties(Expression<Func<string>> browserGetSelectionPropertiesworkflow, Expression<Func<double>> browserGetSelectionPropertiesparentElementHandle = null, Expression<Func<double>> browserGetSelectionPropertiessearchElementHandle = null, Expression<Func<string>> browserGetSelectionPropertiessearchElementName = null, Expression<Func<string>> browserGetSelectionPropertiessearchElementID = null, Expression<Func<string>> browserGetSelectionPropertiessearchElementTagName = null, Expression<Func<string>> browserGetSelectionPropertiessearchElementXPath = null, Expression<Func<string>> browserGetSelectionPropertiessearchElementClassName = null, Expression<Func<string>> browserGetSelectionPropertiessearchElementCSSSelector = null, Expression<Func<double>> browserGetSelectionPropertiessearchElementIndex = null, Expression<Func<string>> browserGetSelectionPropertiessearchElementMatchValue = null, Expression<Func<string>> browserGetSelectionPropertiessearchElementMatchText = null, Expression<Func<string>> browserGetSelectionPropertiessearchElementType = null, Expression<Func<double>> browserGetSelectionPropertiessearchElementMinimumWidth = null, Expression<Func<double>> browserGetSelectionPropertiessearchElementMinimumHeight = null, Expression<Func<double>> browserGetSelectionPropertiessearchElementBoundingBoxLeft = null, Expression<Func<double>> browserGetSelectionPropertiessearchElementBoundingBoxRight = null, Expression<Func<double>> browserGetSelectionPropertiessearchElementBoundingBoxTop = null, Expression<Func<double>> browserGetSelectionPropertiessearchElementBoundingBoxBottom = null, Expression<Func<bool>> browserGetSelectionPropertiesonlyElementTopLeftNeedsToBeInBoundingBox = null)
        {
            var apiCallPath = "/BrowserControl/GetSelectionProperties";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserGetSelectionProperties = new JObject();
            var browserGetSelectionPropertiespropCount = 0;
            if (browserGetSelectionPropertiesparentElementHandle != null)
            {
                browserGetSelectionProperties["ParentElementHandle"] = CSharpExpressionConverter.ConvertToken(browserGetSelectionPropertiesparentElementHandle);
                browserGetSelectionPropertiespropCount++;
            }

            if (browserGetSelectionPropertiessearchElementHandle != null)
            {
                browserGetSelectionProperties["SearchElementHandle"] = CSharpExpressionConverter.ConvertToken(browserGetSelectionPropertiessearchElementHandle);
                browserGetSelectionPropertiespropCount++;
            }

            if (browserGetSelectionPropertiessearchElementName != null)
            {
                browserGetSelectionProperties["SearchElementName"] = CSharpExpressionConverter.ConvertToken(browserGetSelectionPropertiessearchElementName);
                browserGetSelectionPropertiespropCount++;
            }

            if (browserGetSelectionPropertiessearchElementID != null)
            {
                browserGetSelectionProperties["SearchElementID"] = CSharpExpressionConverter.ConvertToken(browserGetSelectionPropertiessearchElementID);
                browserGetSelectionPropertiespropCount++;
            }

            if (browserGetSelectionPropertiessearchElementTagName != null)
            {
                browserGetSelectionProperties["SearchElementTagName"] = CSharpExpressionConverter.ConvertToken(browserGetSelectionPropertiessearchElementTagName);
                browserGetSelectionPropertiespropCount++;
            }

            if (browserGetSelectionPropertiessearchElementXPath != null)
            {
                browserGetSelectionProperties["SearchElementXPath"] = CSharpExpressionConverter.ConvertToken(browserGetSelectionPropertiessearchElementXPath);
                browserGetSelectionPropertiespropCount++;
            }

            if (browserGetSelectionPropertiessearchElementClassName != null)
            {
                browserGetSelectionProperties["SearchElementClassName"] = CSharpExpressionConverter.ConvertToken(browserGetSelectionPropertiessearchElementClassName);
                browserGetSelectionPropertiespropCount++;
            }

            if (browserGetSelectionPropertiessearchElementCSSSelector != null)
            {
                browserGetSelectionProperties["SearchElementCSSSelector"] = CSharpExpressionConverter.ConvertToken(browserGetSelectionPropertiessearchElementCSSSelector);
                browserGetSelectionPropertiespropCount++;
            }

            if (browserGetSelectionPropertiessearchElementIndex != null)
            {
                if (browserGetSelectionPropertiessearchElementIndex != null)
                {
                    browserGetSelectionProperties["SearchElementIndex"] = CSharpExpressionConverter.ConvertToken(browserGetSelectionPropertiessearchElementIndex);
                    browserGetSelectionPropertiespropCount++;
                }

                browserGetSelectionPropertiespropCount++;
            }
            else
            {
                browserGetSelectionProperties["SearchElementIndex"] = 1;
                browserGetSelectionPropertiespropCount++;
            }

            if (browserGetSelectionPropertiessearchElementMatchValue != null)
            {
                browserGetSelectionProperties["SearchElementMatchValue"] = CSharpExpressionConverter.ConvertToken(browserGetSelectionPropertiessearchElementMatchValue);
                browserGetSelectionPropertiespropCount++;
            }

            if (browserGetSelectionPropertiessearchElementMatchText != null)
            {
                browserGetSelectionProperties["SearchElementMatchText"] = CSharpExpressionConverter.ConvertToken(browserGetSelectionPropertiessearchElementMatchText);
                browserGetSelectionPropertiespropCount++;
            }

            if (browserGetSelectionPropertiessearchElementType != null)
            {
                browserGetSelectionProperties["SearchElementType"] = CSharpExpressionConverter.ConvertToken(browserGetSelectionPropertiessearchElementType);
                browserGetSelectionPropertiespropCount++;
            }

            if (browserGetSelectionPropertiessearchElementMinimumWidth != null)
            {
                if (browserGetSelectionPropertiessearchElementMinimumWidth != null)
                {
                    browserGetSelectionProperties["SearchElementMinimumWidth"] = CSharpExpressionConverter.ConvertToken(browserGetSelectionPropertiessearchElementMinimumWidth);
                    browserGetSelectionPropertiespropCount++;
                }

                browserGetSelectionPropertiespropCount++;
            }
            else
            {
                browserGetSelectionProperties["SearchElementMinimumWidth"] = 1;
                browserGetSelectionPropertiespropCount++;
            }

            if (browserGetSelectionPropertiessearchElementMinimumHeight != null)
            {
                if (browserGetSelectionPropertiessearchElementMinimumHeight != null)
                {
                    browserGetSelectionProperties["SearchElementMinimumHeight"] = CSharpExpressionConverter.ConvertToken(browserGetSelectionPropertiessearchElementMinimumHeight);
                    browserGetSelectionPropertiespropCount++;
                }

                browserGetSelectionPropertiespropCount++;
            }
            else
            {
                browserGetSelectionProperties["SearchElementMinimumHeight"] = 1;
                browserGetSelectionPropertiespropCount++;
            }

            if (browserGetSelectionPropertiessearchElementBoundingBoxLeft != null)
            {
                if (browserGetSelectionPropertiessearchElementBoundingBoxLeft != null)
                {
                    browserGetSelectionProperties["SearchElementBoundingBoxLeft"] = CSharpExpressionConverter.ConvertToken(browserGetSelectionPropertiessearchElementBoundingBoxLeft);
                    browserGetSelectionPropertiespropCount++;
                }

                browserGetSelectionPropertiespropCount++;
            }
            else
            {
                browserGetSelectionProperties["SearchElementBoundingBoxLeft"] = -99999;
                browserGetSelectionPropertiespropCount++;
            }

            if (browserGetSelectionPropertiessearchElementBoundingBoxRight != null)
            {
                if (browserGetSelectionPropertiessearchElementBoundingBoxRight != null)
                {
                    browserGetSelectionProperties["SearchElementBoundingBoxRight"] = CSharpExpressionConverter.ConvertToken(browserGetSelectionPropertiessearchElementBoundingBoxRight);
                    browserGetSelectionPropertiespropCount++;
                }

                browserGetSelectionPropertiespropCount++;
            }
            else
            {
                browserGetSelectionProperties["SearchElementBoundingBoxRight"] = 99999;
                browserGetSelectionPropertiespropCount++;
            }

            if (browserGetSelectionPropertiessearchElementBoundingBoxTop != null)
            {
                if (browserGetSelectionPropertiessearchElementBoundingBoxTop != null)
                {
                    browserGetSelectionProperties["SearchElementBoundingBoxTop"] = CSharpExpressionConverter.ConvertToken(browserGetSelectionPropertiessearchElementBoundingBoxTop);
                    browserGetSelectionPropertiespropCount++;
                }

                browserGetSelectionPropertiespropCount++;
            }
            else
            {
                browserGetSelectionProperties["SearchElementBoundingBoxTop"] = -99999;
                browserGetSelectionPropertiespropCount++;
            }

            if (browserGetSelectionPropertiessearchElementBoundingBoxBottom != null)
            {
                if (browserGetSelectionPropertiessearchElementBoundingBoxBottom != null)
                {
                    browserGetSelectionProperties["SearchElementBoundingBoxBottom"] = CSharpExpressionConverter.ConvertToken(browserGetSelectionPropertiessearchElementBoundingBoxBottom);
                    browserGetSelectionPropertiespropCount++;
                }

                browserGetSelectionPropertiespropCount++;
            }
            else
            {
                browserGetSelectionProperties["SearchElementBoundingBoxBottom"] = 99999;
                browserGetSelectionPropertiespropCount++;
            }

            if (browserGetSelectionPropertiesonlyElementTopLeftNeedsToBeInBoundingBox != null)
            {
                if (browserGetSelectionPropertiesonlyElementTopLeftNeedsToBeInBoundingBox != null)
                {
                    browserGetSelectionProperties["OnlyElementTopLeftNeedsToBeInBoundingBox"] = CSharpExpressionConverter.ConvertToken(browserGetSelectionPropertiesonlyElementTopLeftNeedsToBeInBoundingBox);
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
            browserGetSelectionProperties["Workflow"] = CSharpExpressionConverter.ConvertToken(browserGetSelectionPropertiesworkflow);
            if (browserGetSelectionPropertiespropCount > 0)
            {
                callPayload.Body = browserGetSelectionProperties;
            }

            return new ApiConnectionAction<BrowserGetSelectionPropertiesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserSelectSelection(Expression<Func<string>> browserSelectSelectionworkflow, Expression<Func<double>> browserSelectSelectionparentElementHandle = null, Expression<Func<double>> browserSelectSelectionsearchElementHandle = null, Expression<Func<string>> browserSelectSelectionsearchElementName = null, Expression<Func<string>> browserSelectSelectionsearchElementID = null, Expression<Func<string>> browserSelectSelectionsearchElementTagName = null, Expression<Func<string>> browserSelectSelectionsearchElementXPath = null, Expression<Func<string>> browserSelectSelectionsearchElementClassName = null, Expression<Func<string>> browserSelectSelectionsearchElementCSSSelector = null, Expression<Func<double>> browserSelectSelectionsearchElementIndex = null, Expression<Func<string>> browserSelectSelectionsearchElementMatchValue = null, Expression<Func<string>> browserSelectSelectionsearchElementMatchText = null, Expression<Func<string>> browserSelectSelectionsearchElementType = null, Expression<Func<double>> browserSelectSelectionsearchElementMinimumWidth = null, Expression<Func<double>> browserSelectSelectionsearchElementMinimumHeight = null, Expression<Func<double>> browserSelectSelectionsearchElementBoundingBoxLeft = null, Expression<Func<double>> browserSelectSelectionsearchElementBoundingBoxRight = null, Expression<Func<double>> browserSelectSelectionsearchElementBoundingBoxTop = null, Expression<Func<double>> browserSelectSelectionsearchElementBoundingBoxBottom = null, Expression<Func<bool>> browserSelectSelectiononlyElementTopLeftNeedsToBeInBoundingBox = null, Expression<Func<string>> browserSelectSelectionvalueToSelect = null, Expression<Func<string>> browserSelectSelectiontextToSelect = null, Expression<Func<double>> browserSelectSelectionindexToSelect = null)
        {
            var apiCallPath = "/BrowserControl/SelectSelection";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserSelectSelection = new JObject();
            var browserSelectSelectionpropCount = 0;
            if (browserSelectSelectionparentElementHandle != null)
            {
                browserSelectSelection["ParentElementHandle"] = CSharpExpressionConverter.ConvertToken(browserSelectSelectionparentElementHandle);
                browserSelectSelectionpropCount++;
            }

            if (browserSelectSelectionsearchElementHandle != null)
            {
                browserSelectSelection["SearchElementHandle"] = CSharpExpressionConverter.ConvertToken(browserSelectSelectionsearchElementHandle);
                browserSelectSelectionpropCount++;
            }

            if (browserSelectSelectionsearchElementName != null)
            {
                browserSelectSelection["SearchElementName"] = CSharpExpressionConverter.ConvertToken(browserSelectSelectionsearchElementName);
                browserSelectSelectionpropCount++;
            }

            if (browserSelectSelectionsearchElementID != null)
            {
                browserSelectSelection["SearchElementID"] = CSharpExpressionConverter.ConvertToken(browserSelectSelectionsearchElementID);
                browserSelectSelectionpropCount++;
            }

            if (browserSelectSelectionsearchElementTagName != null)
            {
                browserSelectSelection["SearchElementTagName"] = CSharpExpressionConverter.ConvertToken(browserSelectSelectionsearchElementTagName);
                browserSelectSelectionpropCount++;
            }

            if (browserSelectSelectionsearchElementXPath != null)
            {
                browserSelectSelection["SearchElementXPath"] = CSharpExpressionConverter.ConvertToken(browserSelectSelectionsearchElementXPath);
                browserSelectSelectionpropCount++;
            }

            if (browserSelectSelectionsearchElementClassName != null)
            {
                browserSelectSelection["SearchElementClassName"] = CSharpExpressionConverter.ConvertToken(browserSelectSelectionsearchElementClassName);
                browserSelectSelectionpropCount++;
            }

            if (browserSelectSelectionsearchElementCSSSelector != null)
            {
                browserSelectSelection["SearchElementCSSSelector"] = CSharpExpressionConverter.ConvertToken(browserSelectSelectionsearchElementCSSSelector);
                browserSelectSelectionpropCount++;
            }

            if (browserSelectSelectionsearchElementIndex != null)
            {
                if (browserSelectSelectionsearchElementIndex != null)
                {
                    browserSelectSelection["SearchElementIndex"] = CSharpExpressionConverter.ConvertToken(browserSelectSelectionsearchElementIndex);
                    browserSelectSelectionpropCount++;
                }

                browserSelectSelectionpropCount++;
            }
            else
            {
                browserSelectSelection["SearchElementIndex"] = 1;
                browserSelectSelectionpropCount++;
            }

            if (browserSelectSelectionsearchElementMatchValue != null)
            {
                browserSelectSelection["SearchElementMatchValue"] = CSharpExpressionConverter.ConvertToken(browserSelectSelectionsearchElementMatchValue);
                browserSelectSelectionpropCount++;
            }

            if (browserSelectSelectionsearchElementMatchText != null)
            {
                browserSelectSelection["SearchElementMatchText"] = CSharpExpressionConverter.ConvertToken(browserSelectSelectionsearchElementMatchText);
                browserSelectSelectionpropCount++;
            }

            if (browserSelectSelectionsearchElementType != null)
            {
                browserSelectSelection["SearchElementType"] = CSharpExpressionConverter.ConvertToken(browserSelectSelectionsearchElementType);
                browserSelectSelectionpropCount++;
            }

            if (browserSelectSelectionsearchElementMinimumWidth != null)
            {
                if (browserSelectSelectionsearchElementMinimumWidth != null)
                {
                    browserSelectSelection["SearchElementMinimumWidth"] = CSharpExpressionConverter.ConvertToken(browserSelectSelectionsearchElementMinimumWidth);
                    browserSelectSelectionpropCount++;
                }

                browserSelectSelectionpropCount++;
            }
            else
            {
                browserSelectSelection["SearchElementMinimumWidth"] = 1;
                browserSelectSelectionpropCount++;
            }

            if (browserSelectSelectionsearchElementMinimumHeight != null)
            {
                if (browserSelectSelectionsearchElementMinimumHeight != null)
                {
                    browserSelectSelection["SearchElementMinimumHeight"] = CSharpExpressionConverter.ConvertToken(browserSelectSelectionsearchElementMinimumHeight);
                    browserSelectSelectionpropCount++;
                }

                browserSelectSelectionpropCount++;
            }
            else
            {
                browserSelectSelection["SearchElementMinimumHeight"] = 1;
                browserSelectSelectionpropCount++;
            }

            if (browserSelectSelectionsearchElementBoundingBoxLeft != null)
            {
                if (browserSelectSelectionsearchElementBoundingBoxLeft != null)
                {
                    browserSelectSelection["SearchElementBoundingBoxLeft"] = CSharpExpressionConverter.ConvertToken(browserSelectSelectionsearchElementBoundingBoxLeft);
                    browserSelectSelectionpropCount++;
                }

                browserSelectSelectionpropCount++;
            }
            else
            {
                browserSelectSelection["SearchElementBoundingBoxLeft"] = -99999;
                browserSelectSelectionpropCount++;
            }

            if (browserSelectSelectionsearchElementBoundingBoxRight != null)
            {
                if (browserSelectSelectionsearchElementBoundingBoxRight != null)
                {
                    browserSelectSelection["SearchElementBoundingBoxRight"] = CSharpExpressionConverter.ConvertToken(browserSelectSelectionsearchElementBoundingBoxRight);
                    browserSelectSelectionpropCount++;
                }

                browserSelectSelectionpropCount++;
            }
            else
            {
                browserSelectSelection["SearchElementBoundingBoxRight"] = 99999;
                browserSelectSelectionpropCount++;
            }

            if (browserSelectSelectionsearchElementBoundingBoxTop != null)
            {
                if (browserSelectSelectionsearchElementBoundingBoxTop != null)
                {
                    browserSelectSelection["SearchElementBoundingBoxTop"] = CSharpExpressionConverter.ConvertToken(browserSelectSelectionsearchElementBoundingBoxTop);
                    browserSelectSelectionpropCount++;
                }

                browserSelectSelectionpropCount++;
            }
            else
            {
                browserSelectSelection["SearchElementBoundingBoxTop"] = -99999;
                browserSelectSelectionpropCount++;
            }

            if (browserSelectSelectionsearchElementBoundingBoxBottom != null)
            {
                if (browserSelectSelectionsearchElementBoundingBoxBottom != null)
                {
                    browserSelectSelection["SearchElementBoundingBoxBottom"] = CSharpExpressionConverter.ConvertToken(browserSelectSelectionsearchElementBoundingBoxBottom);
                    browserSelectSelectionpropCount++;
                }

                browserSelectSelectionpropCount++;
            }
            else
            {
                browserSelectSelection["SearchElementBoundingBoxBottom"] = 99999;
                browserSelectSelectionpropCount++;
            }

            if (browserSelectSelectiononlyElementTopLeftNeedsToBeInBoundingBox != null)
            {
                if (browserSelectSelectiononlyElementTopLeftNeedsToBeInBoundingBox != null)
                {
                    browserSelectSelection["OnlyElementTopLeftNeedsToBeInBoundingBox"] = CSharpExpressionConverter.ConvertToken(browserSelectSelectiononlyElementTopLeftNeedsToBeInBoundingBox);
                    browserSelectSelectionpropCount++;
                }

                browserSelectSelectionpropCount++;
            }
            else
            {
                browserSelectSelection["OnlyElementTopLeftNeedsToBeInBoundingBox"] = false;
                browserSelectSelectionpropCount++;
            }

            if (browserSelectSelectionvalueToSelect != null)
            {
                browserSelectSelection["ValueToSelect"] = CSharpExpressionConverter.ConvertToken(browserSelectSelectionvalueToSelect);
                browserSelectSelectionpropCount++;
            }

            if (browserSelectSelectiontextToSelect != null)
            {
                browserSelectSelection["TextToSelect"] = CSharpExpressionConverter.ConvertToken(browserSelectSelectiontextToSelect);
                browserSelectSelectionpropCount++;
            }

            if (browserSelectSelectionindexToSelect != null)
            {
                if (browserSelectSelectionindexToSelect != null)
                {
                    browserSelectSelection["IndexToSelect"] = CSharpExpressionConverter.ConvertToken(browserSelectSelectionindexToSelect);
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
            browserSelectSelection["Workflow"] = CSharpExpressionConverter.ConvertToken(browserSelectSelectionworkflow);
            if (browserSelectSelectionpropCount > 0)
            {
                callPayload.Body = browserSelectSelection;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserDeselectSelection(Expression<Func<string>> browserDeselectSelectionworkflow, Expression<Func<double>> browserDeselectSelectionparentElementHandle = null, Expression<Func<double>> browserDeselectSelectionsearchElementHandle = null, Expression<Func<string>> browserDeselectSelectionsearchElementName = null, Expression<Func<string>> browserDeselectSelectionsearchElementID = null, Expression<Func<string>> browserDeselectSelectionsearchElementTagName = null, Expression<Func<string>> browserDeselectSelectionsearchElementXPath = null, Expression<Func<string>> browserDeselectSelectionsearchElementClassName = null, Expression<Func<string>> browserDeselectSelectionsearchElementCSSSelector = null, Expression<Func<double>> browserDeselectSelectionsearchElementIndex = null, Expression<Func<string>> browserDeselectSelectionsearchElementMatchValue = null, Expression<Func<string>> browserDeselectSelectionsearchElementMatchText = null, Expression<Func<string>> browserDeselectSelectionsearchElementType = null, Expression<Func<double>> browserDeselectSelectionsearchElementMinimumWidth = null, Expression<Func<double>> browserDeselectSelectionsearchElementMinimumHeight = null, Expression<Func<double>> browserDeselectSelectionsearchElementBoundingBoxLeft = null, Expression<Func<double>> browserDeselectSelectionsearchElementBoundingBoxRight = null, Expression<Func<double>> browserDeselectSelectionsearchElementBoundingBoxTop = null, Expression<Func<double>> browserDeselectSelectionsearchElementBoundingBoxBottom = null, Expression<Func<bool>> browserDeselectSelectiononlyElementTopLeftNeedsToBeInBoundingBox = null, Expression<Func<string>> browserDeselectSelectionvalueToDeselect = null, Expression<Func<string>> browserDeselectSelectiontextToDeselect = null, Expression<Func<double>> browserDeselectSelectionindexToDeselect = null)
        {
            var apiCallPath = "/BrowserControl/DeselectSelection";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserDeselectSelection = new JObject();
            var browserDeselectSelectionpropCount = 0;
            if (browserDeselectSelectionparentElementHandle != null)
            {
                browserDeselectSelection["ParentElementHandle"] = CSharpExpressionConverter.ConvertToken(browserDeselectSelectionparentElementHandle);
                browserDeselectSelectionpropCount++;
            }

            if (browserDeselectSelectionsearchElementHandle != null)
            {
                browserDeselectSelection["SearchElementHandle"] = CSharpExpressionConverter.ConvertToken(browserDeselectSelectionsearchElementHandle);
                browserDeselectSelectionpropCount++;
            }

            if (browserDeselectSelectionsearchElementName != null)
            {
                browserDeselectSelection["SearchElementName"] = CSharpExpressionConverter.ConvertToken(browserDeselectSelectionsearchElementName);
                browserDeselectSelectionpropCount++;
            }

            if (browserDeselectSelectionsearchElementID != null)
            {
                browserDeselectSelection["SearchElementID"] = CSharpExpressionConverter.ConvertToken(browserDeselectSelectionsearchElementID);
                browserDeselectSelectionpropCount++;
            }

            if (browserDeselectSelectionsearchElementTagName != null)
            {
                browserDeselectSelection["SearchElementTagName"] = CSharpExpressionConverter.ConvertToken(browserDeselectSelectionsearchElementTagName);
                browserDeselectSelectionpropCount++;
            }

            if (browserDeselectSelectionsearchElementXPath != null)
            {
                browserDeselectSelection["SearchElementXPath"] = CSharpExpressionConverter.ConvertToken(browserDeselectSelectionsearchElementXPath);
                browserDeselectSelectionpropCount++;
            }

            if (browserDeselectSelectionsearchElementClassName != null)
            {
                browserDeselectSelection["SearchElementClassName"] = CSharpExpressionConverter.ConvertToken(browserDeselectSelectionsearchElementClassName);
                browserDeselectSelectionpropCount++;
            }

            if (browserDeselectSelectionsearchElementCSSSelector != null)
            {
                browserDeselectSelection["SearchElementCSSSelector"] = CSharpExpressionConverter.ConvertToken(browserDeselectSelectionsearchElementCSSSelector);
                browserDeselectSelectionpropCount++;
            }

            if (browserDeselectSelectionsearchElementIndex != null)
            {
                if (browserDeselectSelectionsearchElementIndex != null)
                {
                    browserDeselectSelection["SearchElementIndex"] = CSharpExpressionConverter.ConvertToken(browserDeselectSelectionsearchElementIndex);
                    browserDeselectSelectionpropCount++;
                }

                browserDeselectSelectionpropCount++;
            }
            else
            {
                browserDeselectSelection["SearchElementIndex"] = 1;
                browserDeselectSelectionpropCount++;
            }

            if (browserDeselectSelectionsearchElementMatchValue != null)
            {
                browserDeselectSelection["SearchElementMatchValue"] = CSharpExpressionConverter.ConvertToken(browserDeselectSelectionsearchElementMatchValue);
                browserDeselectSelectionpropCount++;
            }

            if (browserDeselectSelectionsearchElementMatchText != null)
            {
                browserDeselectSelection["SearchElementMatchText"] = CSharpExpressionConverter.ConvertToken(browserDeselectSelectionsearchElementMatchText);
                browserDeselectSelectionpropCount++;
            }

            if (browserDeselectSelectionsearchElementType != null)
            {
                browserDeselectSelection["SearchElementType"] = CSharpExpressionConverter.ConvertToken(browserDeselectSelectionsearchElementType);
                browserDeselectSelectionpropCount++;
            }

            if (browserDeselectSelectionsearchElementMinimumWidth != null)
            {
                if (browserDeselectSelectionsearchElementMinimumWidth != null)
                {
                    browserDeselectSelection["SearchElementMinimumWidth"] = CSharpExpressionConverter.ConvertToken(browserDeselectSelectionsearchElementMinimumWidth);
                    browserDeselectSelectionpropCount++;
                }

                browserDeselectSelectionpropCount++;
            }
            else
            {
                browserDeselectSelection["SearchElementMinimumWidth"] = 1;
                browserDeselectSelectionpropCount++;
            }

            if (browserDeselectSelectionsearchElementMinimumHeight != null)
            {
                if (browserDeselectSelectionsearchElementMinimumHeight != null)
                {
                    browserDeselectSelection["SearchElementMinimumHeight"] = CSharpExpressionConverter.ConvertToken(browserDeselectSelectionsearchElementMinimumHeight);
                    browserDeselectSelectionpropCount++;
                }

                browserDeselectSelectionpropCount++;
            }
            else
            {
                browserDeselectSelection["SearchElementMinimumHeight"] = 1;
                browserDeselectSelectionpropCount++;
            }

            if (browserDeselectSelectionsearchElementBoundingBoxLeft != null)
            {
                if (browserDeselectSelectionsearchElementBoundingBoxLeft != null)
                {
                    browserDeselectSelection["SearchElementBoundingBoxLeft"] = CSharpExpressionConverter.ConvertToken(browserDeselectSelectionsearchElementBoundingBoxLeft);
                    browserDeselectSelectionpropCount++;
                }

                browserDeselectSelectionpropCount++;
            }
            else
            {
                browserDeselectSelection["SearchElementBoundingBoxLeft"] = -99999;
                browserDeselectSelectionpropCount++;
            }

            if (browserDeselectSelectionsearchElementBoundingBoxRight != null)
            {
                if (browserDeselectSelectionsearchElementBoundingBoxRight != null)
                {
                    browserDeselectSelection["SearchElementBoundingBoxRight"] = CSharpExpressionConverter.ConvertToken(browserDeselectSelectionsearchElementBoundingBoxRight);
                    browserDeselectSelectionpropCount++;
                }

                browserDeselectSelectionpropCount++;
            }
            else
            {
                browserDeselectSelection["SearchElementBoundingBoxRight"] = 99999;
                browserDeselectSelectionpropCount++;
            }

            if (browserDeselectSelectionsearchElementBoundingBoxTop != null)
            {
                if (browserDeselectSelectionsearchElementBoundingBoxTop != null)
                {
                    browserDeselectSelection["SearchElementBoundingBoxTop"] = CSharpExpressionConverter.ConvertToken(browserDeselectSelectionsearchElementBoundingBoxTop);
                    browserDeselectSelectionpropCount++;
                }

                browserDeselectSelectionpropCount++;
            }
            else
            {
                browserDeselectSelection["SearchElementBoundingBoxTop"] = -99999;
                browserDeselectSelectionpropCount++;
            }

            if (browserDeselectSelectionsearchElementBoundingBoxBottom != null)
            {
                if (browserDeselectSelectionsearchElementBoundingBoxBottom != null)
                {
                    browserDeselectSelection["SearchElementBoundingBoxBottom"] = CSharpExpressionConverter.ConvertToken(browserDeselectSelectionsearchElementBoundingBoxBottom);
                    browserDeselectSelectionpropCount++;
                }

                browserDeselectSelectionpropCount++;
            }
            else
            {
                browserDeselectSelection["SearchElementBoundingBoxBottom"] = 99999;
                browserDeselectSelectionpropCount++;
            }

            if (browserDeselectSelectiononlyElementTopLeftNeedsToBeInBoundingBox != null)
            {
                if (browserDeselectSelectiononlyElementTopLeftNeedsToBeInBoundingBox != null)
                {
                    browserDeselectSelection["OnlyElementTopLeftNeedsToBeInBoundingBox"] = CSharpExpressionConverter.ConvertToken(browserDeselectSelectiononlyElementTopLeftNeedsToBeInBoundingBox);
                    browserDeselectSelectionpropCount++;
                }

                browserDeselectSelectionpropCount++;
            }
            else
            {
                browserDeselectSelection["OnlyElementTopLeftNeedsToBeInBoundingBox"] = false;
                browserDeselectSelectionpropCount++;
            }

            if (browserDeselectSelectionvalueToDeselect != null)
            {
                browserDeselectSelection["ValueToDeselect"] = CSharpExpressionConverter.ConvertToken(browserDeselectSelectionvalueToDeselect);
                browserDeselectSelectionpropCount++;
            }

            if (browserDeselectSelectiontextToDeselect != null)
            {
                browserDeselectSelection["TextToDeselect"] = CSharpExpressionConverter.ConvertToken(browserDeselectSelectiontextToDeselect);
                browserDeselectSelectionpropCount++;
            }

            if (browserDeselectSelectionindexToDeselect != null)
            {
                if (browserDeselectSelectionindexToDeselect != null)
                {
                    browserDeselectSelection["IndexToDeselect"] = CSharpExpressionConverter.ConvertToken(browserDeselectSelectionindexToDeselect);
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
            browserDeselectSelection["Workflow"] = CSharpExpressionConverter.ConvertToken(browserDeselectSelectionworkflow);
            if (browserDeselectSelectionpropCount > 0)
            {
                callPayload.Body = browserDeselectSelection;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserDeselectAllSelection(Expression<Func<string>> browserDeselectAllSelectionworkflow, Expression<Func<double>> browserDeselectAllSelectionparentElementHandle = null, Expression<Func<double>> browserDeselectAllSelectionsearchElementHandle = null, Expression<Func<string>> browserDeselectAllSelectionsearchElementName = null, Expression<Func<string>> browserDeselectAllSelectionsearchElementID = null, Expression<Func<string>> browserDeselectAllSelectionsearchElementTagName = null, Expression<Func<string>> browserDeselectAllSelectionsearchElementXPath = null, Expression<Func<string>> browserDeselectAllSelectionsearchElementClassName = null, Expression<Func<string>> browserDeselectAllSelectionsearchElementCSSSelector = null, Expression<Func<double>> browserDeselectAllSelectionsearchElementIndex = null, Expression<Func<string>> browserDeselectAllSelectionsearchElementMatchValue = null, Expression<Func<string>> browserDeselectAllSelectionsearchElementMatchText = null, Expression<Func<string>> browserDeselectAllSelectionsearchElementType = null, Expression<Func<double>> browserDeselectAllSelectionsearchElementMinimumWidth = null, Expression<Func<double>> browserDeselectAllSelectionsearchElementMinimumHeight = null, Expression<Func<double>> browserDeselectAllSelectionsearchElementBoundingBoxLeft = null, Expression<Func<double>> browserDeselectAllSelectionsearchElementBoundingBoxRight = null, Expression<Func<double>> browserDeselectAllSelectionsearchElementBoundingBoxTop = null, Expression<Func<double>> browserDeselectAllSelectionsearchElementBoundingBoxBottom = null, Expression<Func<bool>> browserDeselectAllSelectiononlyElementTopLeftNeedsToBeInBoundingBox = null)
        {
            var apiCallPath = "/BrowserControl/DeselectAllSelection";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserDeselectAllSelection = new JObject();
            var browserDeselectAllSelectionpropCount = 0;
            if (browserDeselectAllSelectionparentElementHandle != null)
            {
                browserDeselectAllSelection["ParentElementHandle"] = CSharpExpressionConverter.ConvertToken(browserDeselectAllSelectionparentElementHandle);
                browserDeselectAllSelectionpropCount++;
            }

            if (browserDeselectAllSelectionsearchElementHandle != null)
            {
                browserDeselectAllSelection["SearchElementHandle"] = CSharpExpressionConverter.ConvertToken(browserDeselectAllSelectionsearchElementHandle);
                browserDeselectAllSelectionpropCount++;
            }

            if (browserDeselectAllSelectionsearchElementName != null)
            {
                browserDeselectAllSelection["SearchElementName"] = CSharpExpressionConverter.ConvertToken(browserDeselectAllSelectionsearchElementName);
                browserDeselectAllSelectionpropCount++;
            }

            if (browserDeselectAllSelectionsearchElementID != null)
            {
                browserDeselectAllSelection["SearchElementID"] = CSharpExpressionConverter.ConvertToken(browserDeselectAllSelectionsearchElementID);
                browserDeselectAllSelectionpropCount++;
            }

            if (browserDeselectAllSelectionsearchElementTagName != null)
            {
                browserDeselectAllSelection["SearchElementTagName"] = CSharpExpressionConverter.ConvertToken(browserDeselectAllSelectionsearchElementTagName);
                browserDeselectAllSelectionpropCount++;
            }

            if (browserDeselectAllSelectionsearchElementXPath != null)
            {
                browserDeselectAllSelection["SearchElementXPath"] = CSharpExpressionConverter.ConvertToken(browserDeselectAllSelectionsearchElementXPath);
                browserDeselectAllSelectionpropCount++;
            }

            if (browserDeselectAllSelectionsearchElementClassName != null)
            {
                browserDeselectAllSelection["SearchElementClassName"] = CSharpExpressionConverter.ConvertToken(browserDeselectAllSelectionsearchElementClassName);
                browserDeselectAllSelectionpropCount++;
            }

            if (browserDeselectAllSelectionsearchElementCSSSelector != null)
            {
                browserDeselectAllSelection["SearchElementCSSSelector"] = CSharpExpressionConverter.ConvertToken(browserDeselectAllSelectionsearchElementCSSSelector);
                browserDeselectAllSelectionpropCount++;
            }

            if (browserDeselectAllSelectionsearchElementIndex != null)
            {
                if (browserDeselectAllSelectionsearchElementIndex != null)
                {
                    browserDeselectAllSelection["SearchElementIndex"] = CSharpExpressionConverter.ConvertToken(browserDeselectAllSelectionsearchElementIndex);
                    browserDeselectAllSelectionpropCount++;
                }

                browserDeselectAllSelectionpropCount++;
            }
            else
            {
                browserDeselectAllSelection["SearchElementIndex"] = 1;
                browserDeselectAllSelectionpropCount++;
            }

            if (browserDeselectAllSelectionsearchElementMatchValue != null)
            {
                browserDeselectAllSelection["SearchElementMatchValue"] = CSharpExpressionConverter.ConvertToken(browserDeselectAllSelectionsearchElementMatchValue);
                browserDeselectAllSelectionpropCount++;
            }

            if (browserDeselectAllSelectionsearchElementMatchText != null)
            {
                browserDeselectAllSelection["SearchElementMatchText"] = CSharpExpressionConverter.ConvertToken(browserDeselectAllSelectionsearchElementMatchText);
                browserDeselectAllSelectionpropCount++;
            }

            if (browserDeselectAllSelectionsearchElementType != null)
            {
                browserDeselectAllSelection["SearchElementType"] = CSharpExpressionConverter.ConvertToken(browserDeselectAllSelectionsearchElementType);
                browserDeselectAllSelectionpropCount++;
            }

            if (browserDeselectAllSelectionsearchElementMinimumWidth != null)
            {
                if (browserDeselectAllSelectionsearchElementMinimumWidth != null)
                {
                    browserDeselectAllSelection["SearchElementMinimumWidth"] = CSharpExpressionConverter.ConvertToken(browserDeselectAllSelectionsearchElementMinimumWidth);
                    browserDeselectAllSelectionpropCount++;
                }

                browserDeselectAllSelectionpropCount++;
            }
            else
            {
                browserDeselectAllSelection["SearchElementMinimumWidth"] = 1;
                browserDeselectAllSelectionpropCount++;
            }

            if (browserDeselectAllSelectionsearchElementMinimumHeight != null)
            {
                if (browserDeselectAllSelectionsearchElementMinimumHeight != null)
                {
                    browserDeselectAllSelection["SearchElementMinimumHeight"] = CSharpExpressionConverter.ConvertToken(browserDeselectAllSelectionsearchElementMinimumHeight);
                    browserDeselectAllSelectionpropCount++;
                }

                browserDeselectAllSelectionpropCount++;
            }
            else
            {
                browserDeselectAllSelection["SearchElementMinimumHeight"] = 1;
                browserDeselectAllSelectionpropCount++;
            }

            if (browserDeselectAllSelectionsearchElementBoundingBoxLeft != null)
            {
                if (browserDeselectAllSelectionsearchElementBoundingBoxLeft != null)
                {
                    browserDeselectAllSelection["SearchElementBoundingBoxLeft"] = CSharpExpressionConverter.ConvertToken(browserDeselectAllSelectionsearchElementBoundingBoxLeft);
                    browserDeselectAllSelectionpropCount++;
                }

                browserDeselectAllSelectionpropCount++;
            }
            else
            {
                browserDeselectAllSelection["SearchElementBoundingBoxLeft"] = -99999;
                browserDeselectAllSelectionpropCount++;
            }

            if (browserDeselectAllSelectionsearchElementBoundingBoxRight != null)
            {
                if (browserDeselectAllSelectionsearchElementBoundingBoxRight != null)
                {
                    browserDeselectAllSelection["SearchElementBoundingBoxRight"] = CSharpExpressionConverter.ConvertToken(browserDeselectAllSelectionsearchElementBoundingBoxRight);
                    browserDeselectAllSelectionpropCount++;
                }

                browserDeselectAllSelectionpropCount++;
            }
            else
            {
                browserDeselectAllSelection["SearchElementBoundingBoxRight"] = 99999;
                browserDeselectAllSelectionpropCount++;
            }

            if (browserDeselectAllSelectionsearchElementBoundingBoxTop != null)
            {
                if (browserDeselectAllSelectionsearchElementBoundingBoxTop != null)
                {
                    browserDeselectAllSelection["SearchElementBoundingBoxTop"] = CSharpExpressionConverter.ConvertToken(browserDeselectAllSelectionsearchElementBoundingBoxTop);
                    browserDeselectAllSelectionpropCount++;
                }

                browserDeselectAllSelectionpropCount++;
            }
            else
            {
                browserDeselectAllSelection["SearchElementBoundingBoxTop"] = -99999;
                browserDeselectAllSelectionpropCount++;
            }

            if (browserDeselectAllSelectionsearchElementBoundingBoxBottom != null)
            {
                if (browserDeselectAllSelectionsearchElementBoundingBoxBottom != null)
                {
                    browserDeselectAllSelection["SearchElementBoundingBoxBottom"] = CSharpExpressionConverter.ConvertToken(browserDeselectAllSelectionsearchElementBoundingBoxBottom);
                    browserDeselectAllSelectionpropCount++;
                }

                browserDeselectAllSelectionpropCount++;
            }
            else
            {
                browserDeselectAllSelection["SearchElementBoundingBoxBottom"] = 99999;
                browserDeselectAllSelectionpropCount++;
            }

            if (browserDeselectAllSelectiononlyElementTopLeftNeedsToBeInBoundingBox != null)
            {
                if (browserDeselectAllSelectiononlyElementTopLeftNeedsToBeInBoundingBox != null)
                {
                    browserDeselectAllSelection["OnlyElementTopLeftNeedsToBeInBoundingBox"] = CSharpExpressionConverter.ConvertToken(browserDeselectAllSelectiononlyElementTopLeftNeedsToBeInBoundingBox);
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
            browserDeselectAllSelection["Workflow"] = CSharpExpressionConverter.ConvertToken(browserDeselectAllSelectionworkflow);
            if (browserDeselectAllSelectionpropCount > 0)
            {
                callPayload.Body = browserDeselectAllSelection;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserGetTableContentsResponse> BrowserGetTableContents(Expression<Func<string>> browserGetTableContentsworkflow, Expression<Func<double>> browserGetTableContentsparentElementHandle = null, Expression<Func<double>> browserGetTableContentssearchElementHandle = null, Expression<Func<string>> browserGetTableContentssearchElementName = null, Expression<Func<string>> browserGetTableContentssearchElementID = null, Expression<Func<string>> browserGetTableContentssearchElementTagName = null, Expression<Func<string>> browserGetTableContentssearchElementXPath = null, Expression<Func<string>> browserGetTableContentssearchElementClassName = null, Expression<Func<string>> browserGetTableContentssearchElementCSSSelector = null, Expression<Func<double>> browserGetTableContentssearchElementIndex = null, Expression<Func<string>> browserGetTableContentssearchElementMatchValue = null, Expression<Func<string>> browserGetTableContentssearchElementMatchText = null, Expression<Func<string>> browserGetTableContentssearchElementType = null, Expression<Func<double>> browserGetTableContentssearchElementMinimumWidth = null, Expression<Func<double>> browserGetTableContentssearchElementMinimumHeight = null, Expression<Func<double>> browserGetTableContentssearchElementBoundingBoxLeft = null, Expression<Func<double>> browserGetTableContentssearchElementBoundingBoxRight = null, Expression<Func<double>> browserGetTableContentssearchElementBoundingBoxTop = null, Expression<Func<double>> browserGetTableContentssearchElementBoundingBoxBottom = null, Expression<Func<bool>> browserGetTableContentsonlyElementTopLeftNeedsToBeInBoundingBox = null, Expression<Func<double>> browserGetTableContentscreateColumnNamesFromRow = null, Expression<Func<bool>> browserGetTableContentsmergeChildTables = null)
        {
            var apiCallPath = "/BrowserControl/GetTableContents";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserGetTableContents = new JObject();
            var browserGetTableContentspropCount = 0;
            if (browserGetTableContentsparentElementHandle != null)
            {
                browserGetTableContents["ParentElementHandle"] = CSharpExpressionConverter.ConvertToken(browserGetTableContentsparentElementHandle);
                browserGetTableContentspropCount++;
            }

            if (browserGetTableContentssearchElementHandle != null)
            {
                browserGetTableContents["SearchElementHandle"] = CSharpExpressionConverter.ConvertToken(browserGetTableContentssearchElementHandle);
                browserGetTableContentspropCount++;
            }

            if (browserGetTableContentssearchElementName != null)
            {
                browserGetTableContents["SearchElementName"] = CSharpExpressionConverter.ConvertToken(browserGetTableContentssearchElementName);
                browserGetTableContentspropCount++;
            }

            if (browserGetTableContentssearchElementID != null)
            {
                browserGetTableContents["SearchElementID"] = CSharpExpressionConverter.ConvertToken(browserGetTableContentssearchElementID);
                browserGetTableContentspropCount++;
            }

            if (browserGetTableContentssearchElementTagName != null)
            {
                browserGetTableContents["SearchElementTagName"] = CSharpExpressionConverter.ConvertToken(browserGetTableContentssearchElementTagName);
                browserGetTableContentspropCount++;
            }

            if (browserGetTableContentssearchElementXPath != null)
            {
                browserGetTableContents["SearchElementXPath"] = CSharpExpressionConverter.ConvertToken(browserGetTableContentssearchElementXPath);
                browserGetTableContentspropCount++;
            }

            if (browserGetTableContentssearchElementClassName != null)
            {
                browserGetTableContents["SearchElementClassName"] = CSharpExpressionConverter.ConvertToken(browserGetTableContentssearchElementClassName);
                browserGetTableContentspropCount++;
            }

            if (browserGetTableContentssearchElementCSSSelector != null)
            {
                browserGetTableContents["SearchElementCSSSelector"] = CSharpExpressionConverter.ConvertToken(browserGetTableContentssearchElementCSSSelector);
                browserGetTableContentspropCount++;
            }

            if (browserGetTableContentssearchElementIndex != null)
            {
                if (browserGetTableContentssearchElementIndex != null)
                {
                    browserGetTableContents["SearchElementIndex"] = CSharpExpressionConverter.ConvertToken(browserGetTableContentssearchElementIndex);
                    browserGetTableContentspropCount++;
                }

                browserGetTableContentspropCount++;
            }
            else
            {
                browserGetTableContents["SearchElementIndex"] = 1;
                browserGetTableContentspropCount++;
            }

            if (browserGetTableContentssearchElementMatchValue != null)
            {
                browserGetTableContents["SearchElementMatchValue"] = CSharpExpressionConverter.ConvertToken(browserGetTableContentssearchElementMatchValue);
                browserGetTableContentspropCount++;
            }

            if (browserGetTableContentssearchElementMatchText != null)
            {
                browserGetTableContents["SearchElementMatchText"] = CSharpExpressionConverter.ConvertToken(browserGetTableContentssearchElementMatchText);
                browserGetTableContentspropCount++;
            }

            if (browserGetTableContentssearchElementType != null)
            {
                browserGetTableContents["SearchElementType"] = CSharpExpressionConverter.ConvertToken(browserGetTableContentssearchElementType);
                browserGetTableContentspropCount++;
            }

            if (browserGetTableContentssearchElementMinimumWidth != null)
            {
                if (browserGetTableContentssearchElementMinimumWidth != null)
                {
                    browserGetTableContents["SearchElementMinimumWidth"] = CSharpExpressionConverter.ConvertToken(browserGetTableContentssearchElementMinimumWidth);
                    browserGetTableContentspropCount++;
                }

                browserGetTableContentspropCount++;
            }
            else
            {
                browserGetTableContents["SearchElementMinimumWidth"] = 1;
                browserGetTableContentspropCount++;
            }

            if (browserGetTableContentssearchElementMinimumHeight != null)
            {
                if (browserGetTableContentssearchElementMinimumHeight != null)
                {
                    browserGetTableContents["SearchElementMinimumHeight"] = CSharpExpressionConverter.ConvertToken(browserGetTableContentssearchElementMinimumHeight);
                    browserGetTableContentspropCount++;
                }

                browserGetTableContentspropCount++;
            }
            else
            {
                browserGetTableContents["SearchElementMinimumHeight"] = 1;
                browserGetTableContentspropCount++;
            }

            if (browserGetTableContentssearchElementBoundingBoxLeft != null)
            {
                if (browserGetTableContentssearchElementBoundingBoxLeft != null)
                {
                    browserGetTableContents["SearchElementBoundingBoxLeft"] = CSharpExpressionConverter.ConvertToken(browserGetTableContentssearchElementBoundingBoxLeft);
                    browserGetTableContentspropCount++;
                }

                browserGetTableContentspropCount++;
            }
            else
            {
                browserGetTableContents["SearchElementBoundingBoxLeft"] = -99999;
                browserGetTableContentspropCount++;
            }

            if (browserGetTableContentssearchElementBoundingBoxRight != null)
            {
                if (browserGetTableContentssearchElementBoundingBoxRight != null)
                {
                    browserGetTableContents["SearchElementBoundingBoxRight"] = CSharpExpressionConverter.ConvertToken(browserGetTableContentssearchElementBoundingBoxRight);
                    browserGetTableContentspropCount++;
                }

                browserGetTableContentspropCount++;
            }
            else
            {
                browserGetTableContents["SearchElementBoundingBoxRight"] = 99999;
                browserGetTableContentspropCount++;
            }

            if (browserGetTableContentssearchElementBoundingBoxTop != null)
            {
                if (browserGetTableContentssearchElementBoundingBoxTop != null)
                {
                    browserGetTableContents["SearchElementBoundingBoxTop"] = CSharpExpressionConverter.ConvertToken(browserGetTableContentssearchElementBoundingBoxTop);
                    browserGetTableContentspropCount++;
                }

                browserGetTableContentspropCount++;
            }
            else
            {
                browserGetTableContents["SearchElementBoundingBoxTop"] = -99999;
                browserGetTableContentspropCount++;
            }

            if (browserGetTableContentssearchElementBoundingBoxBottom != null)
            {
                if (browserGetTableContentssearchElementBoundingBoxBottom != null)
                {
                    browserGetTableContents["SearchElementBoundingBoxBottom"] = CSharpExpressionConverter.ConvertToken(browserGetTableContentssearchElementBoundingBoxBottom);
                    browserGetTableContentspropCount++;
                }

                browserGetTableContentspropCount++;
            }
            else
            {
                browserGetTableContents["SearchElementBoundingBoxBottom"] = 99999;
                browserGetTableContentspropCount++;
            }

            if (browserGetTableContentsonlyElementTopLeftNeedsToBeInBoundingBox != null)
            {
                if (browserGetTableContentsonlyElementTopLeftNeedsToBeInBoundingBox != null)
                {
                    browserGetTableContents["OnlyElementTopLeftNeedsToBeInBoundingBox"] = CSharpExpressionConverter.ConvertToken(browserGetTableContentsonlyElementTopLeftNeedsToBeInBoundingBox);
                    browserGetTableContentspropCount++;
                }

                browserGetTableContentspropCount++;
            }
            else
            {
                browserGetTableContents["OnlyElementTopLeftNeedsToBeInBoundingBox"] = false;
                browserGetTableContentspropCount++;
            }

            if (browserGetTableContentscreateColumnNamesFromRow != null)
            {
                if (browserGetTableContentscreateColumnNamesFromRow != null)
                {
                    browserGetTableContents["CreateColumnNamesFromRow"] = CSharpExpressionConverter.ConvertToken(browserGetTableContentscreateColumnNamesFromRow);
                    browserGetTableContentspropCount++;
                }

                browserGetTableContentspropCount++;
            }
            else
            {
                browserGetTableContents["CreateColumnNamesFromRow"] = 0;
                browserGetTableContentspropCount++;
            }

            if (browserGetTableContentsmergeChildTables != null)
            {
                if (browserGetTableContentsmergeChildTables != null)
                {
                    browserGetTableContents["MergeChildTables"] = CSharpExpressionConverter.ConvertToken(browserGetTableContentsmergeChildTables);
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
            browserGetTableContents["Workflow"] = CSharpExpressionConverter.ConvertToken(browserGetTableContentsworkflow);
            if (browserGetTableContentspropCount > 0)
            {
                callPayload.Body = browserGetTableContents;
            }

            return new ApiConnectionAction<BrowserGetTableContentsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserScrollElementIntoView(Expression<Func<string>> browserScrollElementIntoViewworkflow, Expression<Func<double>> browserScrollElementIntoViewparentElementHandle = null, Expression<Func<double>> browserScrollElementIntoViewsearchElementHandle = null, Expression<Func<string>> browserScrollElementIntoViewsearchElementName = null, Expression<Func<string>> browserScrollElementIntoViewsearchElementID = null, Expression<Func<string>> browserScrollElementIntoViewsearchElementTagName = null, Expression<Func<string>> browserScrollElementIntoViewsearchElementXPath = null, Expression<Func<string>> browserScrollElementIntoViewsearchElementClassName = null, Expression<Func<string>> browserScrollElementIntoViewsearchElementCSSSelector = null, Expression<Func<double>> browserScrollElementIntoViewsearchElementIndex = null, Expression<Func<string>> browserScrollElementIntoViewsearchElementMatchValue = null, Expression<Func<string>> browserScrollElementIntoViewsearchElementMatchText = null, Expression<Func<string>> browserScrollElementIntoViewsearchElementType = null, Expression<Func<double>> browserScrollElementIntoViewsearchElementMinimumWidth = null, Expression<Func<double>> browserScrollElementIntoViewsearchElementMinimumHeight = null, Expression<Func<double>> browserScrollElementIntoViewsearchElementBoundingBoxLeft = null, Expression<Func<double>> browserScrollElementIntoViewsearchElementBoundingBoxRight = null, Expression<Func<double>> browserScrollElementIntoViewsearchElementBoundingBoxTop = null, Expression<Func<double>> browserScrollElementIntoViewsearchElementBoundingBoxBottom = null, Expression<Func<bool>> browserScrollElementIntoViewonlyElementTopLeftNeedsToBeInBoundingBox = null)
        {
            var apiCallPath = "/BrowserControl/ScrollElementIntoView";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserScrollElementIntoView = new JObject();
            var browserScrollElementIntoViewpropCount = 0;
            if (browserScrollElementIntoViewparentElementHandle != null)
            {
                browserScrollElementIntoView["ParentElementHandle"] = CSharpExpressionConverter.ConvertToken(browserScrollElementIntoViewparentElementHandle);
                browserScrollElementIntoViewpropCount++;
            }

            if (browserScrollElementIntoViewsearchElementHandle != null)
            {
                browserScrollElementIntoView["SearchElementHandle"] = CSharpExpressionConverter.ConvertToken(browserScrollElementIntoViewsearchElementHandle);
                browserScrollElementIntoViewpropCount++;
            }

            if (browserScrollElementIntoViewsearchElementName != null)
            {
                browserScrollElementIntoView["SearchElementName"] = CSharpExpressionConverter.ConvertToken(browserScrollElementIntoViewsearchElementName);
                browserScrollElementIntoViewpropCount++;
            }

            if (browserScrollElementIntoViewsearchElementID != null)
            {
                browserScrollElementIntoView["SearchElementID"] = CSharpExpressionConverter.ConvertToken(browserScrollElementIntoViewsearchElementID);
                browserScrollElementIntoViewpropCount++;
            }

            if (browserScrollElementIntoViewsearchElementTagName != null)
            {
                browserScrollElementIntoView["SearchElementTagName"] = CSharpExpressionConverter.ConvertToken(browserScrollElementIntoViewsearchElementTagName);
                browserScrollElementIntoViewpropCount++;
            }

            if (browserScrollElementIntoViewsearchElementXPath != null)
            {
                browserScrollElementIntoView["SearchElementXPath"] = CSharpExpressionConverter.ConvertToken(browserScrollElementIntoViewsearchElementXPath);
                browserScrollElementIntoViewpropCount++;
            }

            if (browserScrollElementIntoViewsearchElementClassName != null)
            {
                browserScrollElementIntoView["SearchElementClassName"] = CSharpExpressionConverter.ConvertToken(browserScrollElementIntoViewsearchElementClassName);
                browserScrollElementIntoViewpropCount++;
            }

            if (browserScrollElementIntoViewsearchElementCSSSelector != null)
            {
                browserScrollElementIntoView["SearchElementCSSSelector"] = CSharpExpressionConverter.ConvertToken(browserScrollElementIntoViewsearchElementCSSSelector);
                browserScrollElementIntoViewpropCount++;
            }

            if (browserScrollElementIntoViewsearchElementIndex != null)
            {
                if (browserScrollElementIntoViewsearchElementIndex != null)
                {
                    browserScrollElementIntoView["SearchElementIndex"] = CSharpExpressionConverter.ConvertToken(browserScrollElementIntoViewsearchElementIndex);
                    browserScrollElementIntoViewpropCount++;
                }

                browserScrollElementIntoViewpropCount++;
            }
            else
            {
                browserScrollElementIntoView["SearchElementIndex"] = 1;
                browserScrollElementIntoViewpropCount++;
            }

            if (browserScrollElementIntoViewsearchElementMatchValue != null)
            {
                browserScrollElementIntoView["SearchElementMatchValue"] = CSharpExpressionConverter.ConvertToken(browserScrollElementIntoViewsearchElementMatchValue);
                browserScrollElementIntoViewpropCount++;
            }

            if (browserScrollElementIntoViewsearchElementMatchText != null)
            {
                browserScrollElementIntoView["SearchElementMatchText"] = CSharpExpressionConverter.ConvertToken(browserScrollElementIntoViewsearchElementMatchText);
                browserScrollElementIntoViewpropCount++;
            }

            if (browserScrollElementIntoViewsearchElementType != null)
            {
                browserScrollElementIntoView["SearchElementType"] = CSharpExpressionConverter.ConvertToken(browserScrollElementIntoViewsearchElementType);
                browserScrollElementIntoViewpropCount++;
            }

            if (browserScrollElementIntoViewsearchElementMinimumWidth != null)
            {
                if (browserScrollElementIntoViewsearchElementMinimumWidth != null)
                {
                    browserScrollElementIntoView["SearchElementMinimumWidth"] = CSharpExpressionConverter.ConvertToken(browserScrollElementIntoViewsearchElementMinimumWidth);
                    browserScrollElementIntoViewpropCount++;
                }

                browserScrollElementIntoViewpropCount++;
            }
            else
            {
                browserScrollElementIntoView["SearchElementMinimumWidth"] = 1;
                browserScrollElementIntoViewpropCount++;
            }

            if (browserScrollElementIntoViewsearchElementMinimumHeight != null)
            {
                if (browserScrollElementIntoViewsearchElementMinimumHeight != null)
                {
                    browserScrollElementIntoView["SearchElementMinimumHeight"] = CSharpExpressionConverter.ConvertToken(browserScrollElementIntoViewsearchElementMinimumHeight);
                    browserScrollElementIntoViewpropCount++;
                }

                browserScrollElementIntoViewpropCount++;
            }
            else
            {
                browserScrollElementIntoView["SearchElementMinimumHeight"] = 1;
                browserScrollElementIntoViewpropCount++;
            }

            if (browserScrollElementIntoViewsearchElementBoundingBoxLeft != null)
            {
                if (browserScrollElementIntoViewsearchElementBoundingBoxLeft != null)
                {
                    browserScrollElementIntoView["SearchElementBoundingBoxLeft"] = CSharpExpressionConverter.ConvertToken(browserScrollElementIntoViewsearchElementBoundingBoxLeft);
                    browserScrollElementIntoViewpropCount++;
                }

                browserScrollElementIntoViewpropCount++;
            }
            else
            {
                browserScrollElementIntoView["SearchElementBoundingBoxLeft"] = -99999;
                browserScrollElementIntoViewpropCount++;
            }

            if (browserScrollElementIntoViewsearchElementBoundingBoxRight != null)
            {
                if (browserScrollElementIntoViewsearchElementBoundingBoxRight != null)
                {
                    browserScrollElementIntoView["SearchElementBoundingBoxRight"] = CSharpExpressionConverter.ConvertToken(browserScrollElementIntoViewsearchElementBoundingBoxRight);
                    browserScrollElementIntoViewpropCount++;
                }

                browserScrollElementIntoViewpropCount++;
            }
            else
            {
                browserScrollElementIntoView["SearchElementBoundingBoxRight"] = 99999;
                browserScrollElementIntoViewpropCount++;
            }

            if (browserScrollElementIntoViewsearchElementBoundingBoxTop != null)
            {
                if (browserScrollElementIntoViewsearchElementBoundingBoxTop != null)
                {
                    browserScrollElementIntoView["SearchElementBoundingBoxTop"] = CSharpExpressionConverter.ConvertToken(browserScrollElementIntoViewsearchElementBoundingBoxTop);
                    browserScrollElementIntoViewpropCount++;
                }

                browserScrollElementIntoViewpropCount++;
            }
            else
            {
                browserScrollElementIntoView["SearchElementBoundingBoxTop"] = -99999;
                browserScrollElementIntoViewpropCount++;
            }

            if (browserScrollElementIntoViewsearchElementBoundingBoxBottom != null)
            {
                if (browserScrollElementIntoViewsearchElementBoundingBoxBottom != null)
                {
                    browserScrollElementIntoView["SearchElementBoundingBoxBottom"] = CSharpExpressionConverter.ConvertToken(browserScrollElementIntoViewsearchElementBoundingBoxBottom);
                    browserScrollElementIntoViewpropCount++;
                }

                browserScrollElementIntoViewpropCount++;
            }
            else
            {
                browserScrollElementIntoView["SearchElementBoundingBoxBottom"] = 99999;
                browserScrollElementIntoViewpropCount++;
            }

            if (browserScrollElementIntoViewonlyElementTopLeftNeedsToBeInBoundingBox != null)
            {
                if (browserScrollElementIntoViewonlyElementTopLeftNeedsToBeInBoundingBox != null)
                {
                    browserScrollElementIntoView["OnlyElementTopLeftNeedsToBeInBoundingBox"] = CSharpExpressionConverter.ConvertToken(browserScrollElementIntoViewonlyElementTopLeftNeedsToBeInBoundingBox);
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
            browserScrollElementIntoView["Workflow"] = CSharpExpressionConverter.ConvertToken(browserScrollElementIntoViewworkflow);
            if (browserScrollElementIntoViewpropCount > 0)
            {
                callPayload.Body = browserScrollElementIntoView;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserExecuteJavaScriptResponse> BrowserExecuteJavaScript(Expression<Func<string>> browserExecuteJavaScriptjavaScriptCode, Expression<Func<string>> browserExecuteJavaScriptworkflow)
        {
            var apiCallPath = "/BrowserControl/ExecuteJavaScript";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserExecuteJavaScript = new JObject();
            var browserExecuteJavaScriptpropCount = 0;
            browserExecuteJavaScriptpropCount++;
            browserExecuteJavaScript["JavaScriptCode"] = CSharpExpressionConverter.ConvertToken(browserExecuteJavaScriptjavaScriptCode);
            browserExecuteJavaScriptpropCount++;
            browserExecuteJavaScript["Workflow"] = CSharpExpressionConverter.ConvertToken(browserExecuteJavaScriptworkflow);
            if (browserExecuteJavaScriptpropCount > 0)
            {
                callPayload.Body = browserExecuteJavaScript;
            }

            return new ApiConnectionAction<BrowserExecuteJavaScriptResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserGetElementBoundingRectResponse> BrowserGetElementBoundingRect(Expression<Func<string>> browserGetElementBoundingRectworkflow, Expression<Func<double>> browserGetElementBoundingRectparentElementHandle = null, Expression<Func<double>> browserGetElementBoundingRectsearchElementHandle = null, Expression<Func<string>> browserGetElementBoundingRectsearchElementName = null, Expression<Func<string>> browserGetElementBoundingRectsearchElementID = null, Expression<Func<string>> browserGetElementBoundingRectsearchElementTagName = null, Expression<Func<string>> browserGetElementBoundingRectsearchElementXPath = null, Expression<Func<string>> browserGetElementBoundingRectsearchElementClassName = null, Expression<Func<string>> browserGetElementBoundingRectsearchElementCSSSelector = null, Expression<Func<double>> browserGetElementBoundingRectsearchElementIndex = null, Expression<Func<string>> browserGetElementBoundingRectsearchElementMatchValue = null, Expression<Func<string>> browserGetElementBoundingRectsearchElementMatchText = null, Expression<Func<string>> browserGetElementBoundingRectsearchElementType = null, Expression<Func<double>> browserGetElementBoundingRectsearchElementMinimumWidth = null, Expression<Func<double>> browserGetElementBoundingRectsearchElementMinimumHeight = null, Expression<Func<double>> browserGetElementBoundingRectsearchElementBoundingBoxLeft = null, Expression<Func<double>> browserGetElementBoundingRectsearchElementBoundingBoxRight = null, Expression<Func<double>> browserGetElementBoundingRectsearchElementBoundingBoxTop = null, Expression<Func<double>> browserGetElementBoundingRectsearchElementBoundingBoxBottom = null, Expression<Func<bool>> browserGetElementBoundingRectonlyElementTopLeftNeedsToBeInBoundingBox = null)
        {
            var apiCallPath = "/BrowserControl/GetElementBoundingRect";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserGetElementBoundingRect = new JObject();
            var browserGetElementBoundingRectpropCount = 0;
            if (browserGetElementBoundingRectparentElementHandle != null)
            {
                browserGetElementBoundingRect["ParentElementHandle"] = CSharpExpressionConverter.ConvertToken(browserGetElementBoundingRectparentElementHandle);
                browserGetElementBoundingRectpropCount++;
            }

            if (browserGetElementBoundingRectsearchElementHandle != null)
            {
                browserGetElementBoundingRect["SearchElementHandle"] = CSharpExpressionConverter.ConvertToken(browserGetElementBoundingRectsearchElementHandle);
                browserGetElementBoundingRectpropCount++;
            }

            if (browserGetElementBoundingRectsearchElementName != null)
            {
                browserGetElementBoundingRect["SearchElementName"] = CSharpExpressionConverter.ConvertToken(browserGetElementBoundingRectsearchElementName);
                browserGetElementBoundingRectpropCount++;
            }

            if (browserGetElementBoundingRectsearchElementID != null)
            {
                browserGetElementBoundingRect["SearchElementID"] = CSharpExpressionConverter.ConvertToken(browserGetElementBoundingRectsearchElementID);
                browserGetElementBoundingRectpropCount++;
            }

            if (browserGetElementBoundingRectsearchElementTagName != null)
            {
                browserGetElementBoundingRect["SearchElementTagName"] = CSharpExpressionConverter.ConvertToken(browserGetElementBoundingRectsearchElementTagName);
                browserGetElementBoundingRectpropCount++;
            }

            if (browserGetElementBoundingRectsearchElementXPath != null)
            {
                browserGetElementBoundingRect["SearchElementXPath"] = CSharpExpressionConverter.ConvertToken(browserGetElementBoundingRectsearchElementXPath);
                browserGetElementBoundingRectpropCount++;
            }

            if (browserGetElementBoundingRectsearchElementClassName != null)
            {
                browserGetElementBoundingRect["SearchElementClassName"] = CSharpExpressionConverter.ConvertToken(browserGetElementBoundingRectsearchElementClassName);
                browserGetElementBoundingRectpropCount++;
            }

            if (browserGetElementBoundingRectsearchElementCSSSelector != null)
            {
                browserGetElementBoundingRect["SearchElementCSSSelector"] = CSharpExpressionConverter.ConvertToken(browserGetElementBoundingRectsearchElementCSSSelector);
                browserGetElementBoundingRectpropCount++;
            }

            if (browserGetElementBoundingRectsearchElementIndex != null)
            {
                if (browserGetElementBoundingRectsearchElementIndex != null)
                {
                    browserGetElementBoundingRect["SearchElementIndex"] = CSharpExpressionConverter.ConvertToken(browserGetElementBoundingRectsearchElementIndex);
                    browserGetElementBoundingRectpropCount++;
                }

                browserGetElementBoundingRectpropCount++;
            }
            else
            {
                browserGetElementBoundingRect["SearchElementIndex"] = 1;
                browserGetElementBoundingRectpropCount++;
            }

            if (browserGetElementBoundingRectsearchElementMatchValue != null)
            {
                browserGetElementBoundingRect["SearchElementMatchValue"] = CSharpExpressionConverter.ConvertToken(browserGetElementBoundingRectsearchElementMatchValue);
                browserGetElementBoundingRectpropCount++;
            }

            if (browserGetElementBoundingRectsearchElementMatchText != null)
            {
                browserGetElementBoundingRect["SearchElementMatchText"] = CSharpExpressionConverter.ConvertToken(browserGetElementBoundingRectsearchElementMatchText);
                browserGetElementBoundingRectpropCount++;
            }

            if (browserGetElementBoundingRectsearchElementType != null)
            {
                browserGetElementBoundingRect["SearchElementType"] = CSharpExpressionConverter.ConvertToken(browserGetElementBoundingRectsearchElementType);
                browserGetElementBoundingRectpropCount++;
            }

            if (browserGetElementBoundingRectsearchElementMinimumWidth != null)
            {
                if (browserGetElementBoundingRectsearchElementMinimumWidth != null)
                {
                    browserGetElementBoundingRect["SearchElementMinimumWidth"] = CSharpExpressionConverter.ConvertToken(browserGetElementBoundingRectsearchElementMinimumWidth);
                    browserGetElementBoundingRectpropCount++;
                }

                browserGetElementBoundingRectpropCount++;
            }
            else
            {
                browserGetElementBoundingRect["SearchElementMinimumWidth"] = 1;
                browserGetElementBoundingRectpropCount++;
            }

            if (browserGetElementBoundingRectsearchElementMinimumHeight != null)
            {
                if (browserGetElementBoundingRectsearchElementMinimumHeight != null)
                {
                    browserGetElementBoundingRect["SearchElementMinimumHeight"] = CSharpExpressionConverter.ConvertToken(browserGetElementBoundingRectsearchElementMinimumHeight);
                    browserGetElementBoundingRectpropCount++;
                }

                browserGetElementBoundingRectpropCount++;
            }
            else
            {
                browserGetElementBoundingRect["SearchElementMinimumHeight"] = 1;
                browserGetElementBoundingRectpropCount++;
            }

            if (browserGetElementBoundingRectsearchElementBoundingBoxLeft != null)
            {
                if (browserGetElementBoundingRectsearchElementBoundingBoxLeft != null)
                {
                    browserGetElementBoundingRect["SearchElementBoundingBoxLeft"] = CSharpExpressionConverter.ConvertToken(browserGetElementBoundingRectsearchElementBoundingBoxLeft);
                    browserGetElementBoundingRectpropCount++;
                }

                browserGetElementBoundingRectpropCount++;
            }
            else
            {
                browserGetElementBoundingRect["SearchElementBoundingBoxLeft"] = -99999;
                browserGetElementBoundingRectpropCount++;
            }

            if (browserGetElementBoundingRectsearchElementBoundingBoxRight != null)
            {
                if (browserGetElementBoundingRectsearchElementBoundingBoxRight != null)
                {
                    browserGetElementBoundingRect["SearchElementBoundingBoxRight"] = CSharpExpressionConverter.ConvertToken(browserGetElementBoundingRectsearchElementBoundingBoxRight);
                    browserGetElementBoundingRectpropCount++;
                }

                browserGetElementBoundingRectpropCount++;
            }
            else
            {
                browserGetElementBoundingRect["SearchElementBoundingBoxRight"] = 99999;
                browserGetElementBoundingRectpropCount++;
            }

            if (browserGetElementBoundingRectsearchElementBoundingBoxTop != null)
            {
                if (browserGetElementBoundingRectsearchElementBoundingBoxTop != null)
                {
                    browserGetElementBoundingRect["SearchElementBoundingBoxTop"] = CSharpExpressionConverter.ConvertToken(browserGetElementBoundingRectsearchElementBoundingBoxTop);
                    browserGetElementBoundingRectpropCount++;
                }

                browserGetElementBoundingRectpropCount++;
            }
            else
            {
                browserGetElementBoundingRect["SearchElementBoundingBoxTop"] = -99999;
                browserGetElementBoundingRectpropCount++;
            }

            if (browserGetElementBoundingRectsearchElementBoundingBoxBottom != null)
            {
                if (browserGetElementBoundingRectsearchElementBoundingBoxBottom != null)
                {
                    browserGetElementBoundingRect["SearchElementBoundingBoxBottom"] = CSharpExpressionConverter.ConvertToken(browserGetElementBoundingRectsearchElementBoundingBoxBottom);
                    browserGetElementBoundingRectpropCount++;
                }

                browserGetElementBoundingRectpropCount++;
            }
            else
            {
                browserGetElementBoundingRect["SearchElementBoundingBoxBottom"] = 99999;
                browserGetElementBoundingRectpropCount++;
            }

            if (browserGetElementBoundingRectonlyElementTopLeftNeedsToBeInBoundingBox != null)
            {
                if (browserGetElementBoundingRectonlyElementTopLeftNeedsToBeInBoundingBox != null)
                {
                    browserGetElementBoundingRect["OnlyElementTopLeftNeedsToBeInBoundingBox"] = CSharpExpressionConverter.ConvertToken(browserGetElementBoundingRectonlyElementTopLeftNeedsToBeInBoundingBox);
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
            browserGetElementBoundingRect["Workflow"] = CSharpExpressionConverter.ConvertToken(browserGetElementBoundingRectworkflow);
            if (browserGetElementBoundingRectpropCount > 0)
            {
                callPayload.Body = browserGetElementBoundingRect;
            }

            return new ApiConnectionAction<BrowserGetElementBoundingRectResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserDrawRectangleAroundElement(Expression<Func<string>> browserDrawRectangleAroundElementworkflow, Expression<Func<double>> browserDrawRectangleAroundElementparentElementHandle = null, Expression<Func<double>> browserDrawRectangleAroundElementsearchElementHandle = null, Expression<Func<string>> browserDrawRectangleAroundElementsearchElementName = null, Expression<Func<string>> browserDrawRectangleAroundElementsearchElementID = null, Expression<Func<string>> browserDrawRectangleAroundElementsearchElementTagName = null, Expression<Func<string>> browserDrawRectangleAroundElementsearchElementXPath = null, Expression<Func<string>> browserDrawRectangleAroundElementsearchElementClassName = null, Expression<Func<string>> browserDrawRectangleAroundElementsearchElementCSSSelector = null, Expression<Func<double>> browserDrawRectangleAroundElementsearchElementIndex = null, Expression<Func<string>> browserDrawRectangleAroundElementsearchElementMatchValue = null, Expression<Func<string>> browserDrawRectangleAroundElementsearchElementMatchText = null, Expression<Func<string>> browserDrawRectangleAroundElementsearchElementType = null, Expression<Func<double>> browserDrawRectangleAroundElementsearchElementMinimumWidth = null, Expression<Func<double>> browserDrawRectangleAroundElementsearchElementMinimumHeight = null, Expression<Func<double>> browserDrawRectangleAroundElementsearchElementBoundingBoxLeft = null, Expression<Func<double>> browserDrawRectangleAroundElementsearchElementBoundingBoxRight = null, Expression<Func<double>> browserDrawRectangleAroundElementsearchElementBoundingBoxTop = null, Expression<Func<double>> browserDrawRectangleAroundElementsearchElementBoundingBoxBottom = null, Expression<Func<bool>> browserDrawRectangleAroundElementonlyElementTopLeftNeedsToBeInBoundingBox = null, Expression<Func<string>> browserDrawRectangleAroundElementpenColour = null, Expression<Func<int>> browserDrawRectangleAroundElementpenThicknessPixels = null)
        {
            var apiCallPath = "/BrowserControl/DrawRectangleAroundElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserDrawRectangleAroundElement = new JObject();
            var browserDrawRectangleAroundElementpropCount = 0;
            if (browserDrawRectangleAroundElementparentElementHandle != null)
            {
                browserDrawRectangleAroundElement["ParentElementHandle"] = CSharpExpressionConverter.ConvertToken(browserDrawRectangleAroundElementparentElementHandle);
                browserDrawRectangleAroundElementpropCount++;
            }

            if (browserDrawRectangleAroundElementsearchElementHandle != null)
            {
                browserDrawRectangleAroundElement["SearchElementHandle"] = CSharpExpressionConverter.ConvertToken(browserDrawRectangleAroundElementsearchElementHandle);
                browserDrawRectangleAroundElementpropCount++;
            }

            if (browserDrawRectangleAroundElementsearchElementName != null)
            {
                browserDrawRectangleAroundElement["SearchElementName"] = CSharpExpressionConverter.ConvertToken(browserDrawRectangleAroundElementsearchElementName);
                browserDrawRectangleAroundElementpropCount++;
            }

            if (browserDrawRectangleAroundElementsearchElementID != null)
            {
                browserDrawRectangleAroundElement["SearchElementID"] = CSharpExpressionConverter.ConvertToken(browserDrawRectangleAroundElementsearchElementID);
                browserDrawRectangleAroundElementpropCount++;
            }

            if (browserDrawRectangleAroundElementsearchElementTagName != null)
            {
                browserDrawRectangleAroundElement["SearchElementTagName"] = CSharpExpressionConverter.ConvertToken(browserDrawRectangleAroundElementsearchElementTagName);
                browserDrawRectangleAroundElementpropCount++;
            }

            if (browserDrawRectangleAroundElementsearchElementXPath != null)
            {
                browserDrawRectangleAroundElement["SearchElementXPath"] = CSharpExpressionConverter.ConvertToken(browserDrawRectangleAroundElementsearchElementXPath);
                browserDrawRectangleAroundElementpropCount++;
            }

            if (browserDrawRectangleAroundElementsearchElementClassName != null)
            {
                browserDrawRectangleAroundElement["SearchElementClassName"] = CSharpExpressionConverter.ConvertToken(browserDrawRectangleAroundElementsearchElementClassName);
                browserDrawRectangleAroundElementpropCount++;
            }

            if (browserDrawRectangleAroundElementsearchElementCSSSelector != null)
            {
                browserDrawRectangleAroundElement["SearchElementCSSSelector"] = CSharpExpressionConverter.ConvertToken(browserDrawRectangleAroundElementsearchElementCSSSelector);
                browserDrawRectangleAroundElementpropCount++;
            }

            if (browserDrawRectangleAroundElementsearchElementIndex != null)
            {
                if (browserDrawRectangleAroundElementsearchElementIndex != null)
                {
                    browserDrawRectangleAroundElement["SearchElementIndex"] = CSharpExpressionConverter.ConvertToken(browserDrawRectangleAroundElementsearchElementIndex);
                    browserDrawRectangleAroundElementpropCount++;
                }

                browserDrawRectangleAroundElementpropCount++;
            }
            else
            {
                browserDrawRectangleAroundElement["SearchElementIndex"] = 1;
                browserDrawRectangleAroundElementpropCount++;
            }

            if (browserDrawRectangleAroundElementsearchElementMatchValue != null)
            {
                browserDrawRectangleAroundElement["SearchElementMatchValue"] = CSharpExpressionConverter.ConvertToken(browserDrawRectangleAroundElementsearchElementMatchValue);
                browserDrawRectangleAroundElementpropCount++;
            }

            if (browserDrawRectangleAroundElementsearchElementMatchText != null)
            {
                browserDrawRectangleAroundElement["SearchElementMatchText"] = CSharpExpressionConverter.ConvertToken(browserDrawRectangleAroundElementsearchElementMatchText);
                browserDrawRectangleAroundElementpropCount++;
            }

            if (browserDrawRectangleAroundElementsearchElementType != null)
            {
                browserDrawRectangleAroundElement["SearchElementType"] = CSharpExpressionConverter.ConvertToken(browserDrawRectangleAroundElementsearchElementType);
                browserDrawRectangleAroundElementpropCount++;
            }

            if (browserDrawRectangleAroundElementsearchElementMinimumWidth != null)
            {
                if (browserDrawRectangleAroundElementsearchElementMinimumWidth != null)
                {
                    browserDrawRectangleAroundElement["SearchElementMinimumWidth"] = CSharpExpressionConverter.ConvertToken(browserDrawRectangleAroundElementsearchElementMinimumWidth);
                    browserDrawRectangleAroundElementpropCount++;
                }

                browserDrawRectangleAroundElementpropCount++;
            }
            else
            {
                browserDrawRectangleAroundElement["SearchElementMinimumWidth"] = 1;
                browserDrawRectangleAroundElementpropCount++;
            }

            if (browserDrawRectangleAroundElementsearchElementMinimumHeight != null)
            {
                if (browserDrawRectangleAroundElementsearchElementMinimumHeight != null)
                {
                    browserDrawRectangleAroundElement["SearchElementMinimumHeight"] = CSharpExpressionConverter.ConvertToken(browserDrawRectangleAroundElementsearchElementMinimumHeight);
                    browserDrawRectangleAroundElementpropCount++;
                }

                browserDrawRectangleAroundElementpropCount++;
            }
            else
            {
                browserDrawRectangleAroundElement["SearchElementMinimumHeight"] = 1;
                browserDrawRectangleAroundElementpropCount++;
            }

            if (browserDrawRectangleAroundElementsearchElementBoundingBoxLeft != null)
            {
                if (browserDrawRectangleAroundElementsearchElementBoundingBoxLeft != null)
                {
                    browserDrawRectangleAroundElement["SearchElementBoundingBoxLeft"] = CSharpExpressionConverter.ConvertToken(browserDrawRectangleAroundElementsearchElementBoundingBoxLeft);
                    browserDrawRectangleAroundElementpropCount++;
                }

                browserDrawRectangleAroundElementpropCount++;
            }
            else
            {
                browserDrawRectangleAroundElement["SearchElementBoundingBoxLeft"] = -99999;
                browserDrawRectangleAroundElementpropCount++;
            }

            if (browserDrawRectangleAroundElementsearchElementBoundingBoxRight != null)
            {
                if (browserDrawRectangleAroundElementsearchElementBoundingBoxRight != null)
                {
                    browserDrawRectangleAroundElement["SearchElementBoundingBoxRight"] = CSharpExpressionConverter.ConvertToken(browserDrawRectangleAroundElementsearchElementBoundingBoxRight);
                    browserDrawRectangleAroundElementpropCount++;
                }

                browserDrawRectangleAroundElementpropCount++;
            }
            else
            {
                browserDrawRectangleAroundElement["SearchElementBoundingBoxRight"] = 99999;
                browserDrawRectangleAroundElementpropCount++;
            }

            if (browserDrawRectangleAroundElementsearchElementBoundingBoxTop != null)
            {
                if (browserDrawRectangleAroundElementsearchElementBoundingBoxTop != null)
                {
                    browserDrawRectangleAroundElement["SearchElementBoundingBoxTop"] = CSharpExpressionConverter.ConvertToken(browserDrawRectangleAroundElementsearchElementBoundingBoxTop);
                    browserDrawRectangleAroundElementpropCount++;
                }

                browserDrawRectangleAroundElementpropCount++;
            }
            else
            {
                browserDrawRectangleAroundElement["SearchElementBoundingBoxTop"] = -99999;
                browserDrawRectangleAroundElementpropCount++;
            }

            if (browserDrawRectangleAroundElementsearchElementBoundingBoxBottom != null)
            {
                if (browserDrawRectangleAroundElementsearchElementBoundingBoxBottom != null)
                {
                    browserDrawRectangleAroundElement["SearchElementBoundingBoxBottom"] = CSharpExpressionConverter.ConvertToken(browserDrawRectangleAroundElementsearchElementBoundingBoxBottom);
                    browserDrawRectangleAroundElementpropCount++;
                }

                browserDrawRectangleAroundElementpropCount++;
            }
            else
            {
                browserDrawRectangleAroundElement["SearchElementBoundingBoxBottom"] = 99999;
                browserDrawRectangleAroundElementpropCount++;
            }

            if (browserDrawRectangleAroundElementonlyElementTopLeftNeedsToBeInBoundingBox != null)
            {
                if (browserDrawRectangleAroundElementonlyElementTopLeftNeedsToBeInBoundingBox != null)
                {
                    browserDrawRectangleAroundElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = CSharpExpressionConverter.ConvertToken(browserDrawRectangleAroundElementonlyElementTopLeftNeedsToBeInBoundingBox);
                    browserDrawRectangleAroundElementpropCount++;
                }

                browserDrawRectangleAroundElementpropCount++;
            }
            else
            {
                browserDrawRectangleAroundElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = false;
                browserDrawRectangleAroundElementpropCount++;
            }

            if (browserDrawRectangleAroundElementpenColour != null)
            {
                if (browserDrawRectangleAroundElementpenColour != null)
                {
                    browserDrawRectangleAroundElement["PenColour"] = CSharpExpressionConverter.ConvertToken(browserDrawRectangleAroundElementpenColour);
                    browserDrawRectangleAroundElementpropCount++;
                }

                browserDrawRectangleAroundElementpropCount++;
            }
            else
            {
                browserDrawRectangleAroundElement["PenColour"] = "green";
                browserDrawRectangleAroundElementpropCount++;
            }

            if (browserDrawRectangleAroundElementpenThicknessPixels != null)
            {
                if (browserDrawRectangleAroundElementpenThicknessPixels != null)
                {
                    browserDrawRectangleAroundElement["PenThicknessPixels"] = CSharpExpressionConverter.ConvertToken(browserDrawRectangleAroundElementpenThicknessPixels);
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
            browserDrawRectangleAroundElement["Workflow"] = CSharpExpressionConverter.ConvertToken(browserDrawRectangleAroundElementworkflow);
            if (browserDrawRectangleAroundElementpropCount > 0)
            {
                callPayload.Body = browserDrawRectangleAroundElement;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserGetBrowserParentWindowDetailsResponse> BrowserGetBrowserParentWindowDetails(Expression<Func<string>> browserGetBrowserParentWindowDetailsworkflow, Expression<Func<int>> browserGetBrowserParentWindowDetailsbrowserPID = null, Expression<Func<string>> browserGetBrowserParentWindowDetailssearchDocumentElementClassName = null)
        {
            var apiCallPath = "/BrowserControl/GetBrowserParentWindowDetails";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserGetBrowserParentWindowDetails = new JObject();
            var browserGetBrowserParentWindowDetailspropCount = 0;
            if (browserGetBrowserParentWindowDetailsbrowserPID != null)
            {
                browserGetBrowserParentWindowDetails["BrowserPID"] = CSharpExpressionConverter.ConvertToken(browserGetBrowserParentWindowDetailsbrowserPID);
                browserGetBrowserParentWindowDetailspropCount++;
            }

            if (browserGetBrowserParentWindowDetailssearchDocumentElementClassName != null)
            {
                browserGetBrowserParentWindowDetails["SearchDocumentElementClassName"] = CSharpExpressionConverter.ConvertToken(browserGetBrowserParentWindowDetailssearchDocumentElementClassName);
                browserGetBrowserParentWindowDetailspropCount++;
            }

            browserGetBrowserParentWindowDetailspropCount++;
            browserGetBrowserParentWindowDetails["Workflow"] = CSharpExpressionConverter.ConvertToken(browserGetBrowserParentWindowDetailsworkflow);
            if (browserGetBrowserParentWindowDetailspropCount > 0)
            {
                callPayload.Body = browserGetBrowserParentWindowDetails;
            }

            return new ApiConnectionAction<BrowserGetBrowserParentWindowDetailsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserGetElementScreenBoundingRectResponse> BrowserGetElementScreenBoundingRect(Expression<Func<string>> browserGetElementScreenBoundingRectworkflow, Expression<Func<double>> browserGetElementScreenBoundingRectparentElementHandle = null, Expression<Func<double>> browserGetElementScreenBoundingRectsearchElementHandle = null, Expression<Func<string>> browserGetElementScreenBoundingRectsearchElementName = null, Expression<Func<string>> browserGetElementScreenBoundingRectsearchElementID = null, Expression<Func<string>> browserGetElementScreenBoundingRectsearchElementTagName = null, Expression<Func<string>> browserGetElementScreenBoundingRectsearchElementXPath = null, Expression<Func<string>> browserGetElementScreenBoundingRectsearchElementClassName = null, Expression<Func<string>> browserGetElementScreenBoundingRectsearchElementCSSSelector = null, Expression<Func<double>> browserGetElementScreenBoundingRectsearchElementIndex = null, Expression<Func<string>> browserGetElementScreenBoundingRectsearchElementMatchValue = null, Expression<Func<string>> browserGetElementScreenBoundingRectsearchElementMatchText = null, Expression<Func<string>> browserGetElementScreenBoundingRectsearchElementType = null, Expression<Func<double>> browserGetElementScreenBoundingRectsearchElementMinimumWidth = null, Expression<Func<double>> browserGetElementScreenBoundingRectsearchElementMinimumHeight = null, Expression<Func<double>> browserGetElementScreenBoundingRectsearchElementBoundingBoxLeft = null, Expression<Func<double>> browserGetElementScreenBoundingRectsearchElementBoundingBoxRight = null, Expression<Func<double>> browserGetElementScreenBoundingRectsearchElementBoundingBoxTop = null, Expression<Func<double>> browserGetElementScreenBoundingRectsearchElementBoundingBoxBottom = null, Expression<Func<bool>> browserGetElementScreenBoundingRectonlyElementTopLeftNeedsToBeInBoundingBox = null)
        {
            var apiCallPath = "/BrowserControl/GetElementScreenBoundingRect";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserGetElementScreenBoundingRect = new JObject();
            var browserGetElementScreenBoundingRectpropCount = 0;
            if (browserGetElementScreenBoundingRectparentElementHandle != null)
            {
                browserGetElementScreenBoundingRect["ParentElementHandle"] = CSharpExpressionConverter.ConvertToken(browserGetElementScreenBoundingRectparentElementHandle);
                browserGetElementScreenBoundingRectpropCount++;
            }

            if (browserGetElementScreenBoundingRectsearchElementHandle != null)
            {
                browserGetElementScreenBoundingRect["SearchElementHandle"] = CSharpExpressionConverter.ConvertToken(browserGetElementScreenBoundingRectsearchElementHandle);
                browserGetElementScreenBoundingRectpropCount++;
            }

            if (browserGetElementScreenBoundingRectsearchElementName != null)
            {
                browserGetElementScreenBoundingRect["SearchElementName"] = CSharpExpressionConverter.ConvertToken(browserGetElementScreenBoundingRectsearchElementName);
                browserGetElementScreenBoundingRectpropCount++;
            }

            if (browserGetElementScreenBoundingRectsearchElementID != null)
            {
                browserGetElementScreenBoundingRect["SearchElementID"] = CSharpExpressionConverter.ConvertToken(browserGetElementScreenBoundingRectsearchElementID);
                browserGetElementScreenBoundingRectpropCount++;
            }

            if (browserGetElementScreenBoundingRectsearchElementTagName != null)
            {
                browserGetElementScreenBoundingRect["SearchElementTagName"] = CSharpExpressionConverter.ConvertToken(browserGetElementScreenBoundingRectsearchElementTagName);
                browserGetElementScreenBoundingRectpropCount++;
            }

            if (browserGetElementScreenBoundingRectsearchElementXPath != null)
            {
                browserGetElementScreenBoundingRect["SearchElementXPath"] = CSharpExpressionConverter.ConvertToken(browserGetElementScreenBoundingRectsearchElementXPath);
                browserGetElementScreenBoundingRectpropCount++;
            }

            if (browserGetElementScreenBoundingRectsearchElementClassName != null)
            {
                browserGetElementScreenBoundingRect["SearchElementClassName"] = CSharpExpressionConverter.ConvertToken(browserGetElementScreenBoundingRectsearchElementClassName);
                browserGetElementScreenBoundingRectpropCount++;
            }

            if (browserGetElementScreenBoundingRectsearchElementCSSSelector != null)
            {
                browserGetElementScreenBoundingRect["SearchElementCSSSelector"] = CSharpExpressionConverter.ConvertToken(browserGetElementScreenBoundingRectsearchElementCSSSelector);
                browserGetElementScreenBoundingRectpropCount++;
            }

            if (browserGetElementScreenBoundingRectsearchElementIndex != null)
            {
                if (browserGetElementScreenBoundingRectsearchElementIndex != null)
                {
                    browserGetElementScreenBoundingRect["SearchElementIndex"] = CSharpExpressionConverter.ConvertToken(browserGetElementScreenBoundingRectsearchElementIndex);
                    browserGetElementScreenBoundingRectpropCount++;
                }

                browserGetElementScreenBoundingRectpropCount++;
            }
            else
            {
                browserGetElementScreenBoundingRect["SearchElementIndex"] = 1;
                browserGetElementScreenBoundingRectpropCount++;
            }

            if (browserGetElementScreenBoundingRectsearchElementMatchValue != null)
            {
                browserGetElementScreenBoundingRect["SearchElementMatchValue"] = CSharpExpressionConverter.ConvertToken(browserGetElementScreenBoundingRectsearchElementMatchValue);
                browserGetElementScreenBoundingRectpropCount++;
            }

            if (browserGetElementScreenBoundingRectsearchElementMatchText != null)
            {
                browserGetElementScreenBoundingRect["SearchElementMatchText"] = CSharpExpressionConverter.ConvertToken(browserGetElementScreenBoundingRectsearchElementMatchText);
                browserGetElementScreenBoundingRectpropCount++;
            }

            if (browserGetElementScreenBoundingRectsearchElementType != null)
            {
                browserGetElementScreenBoundingRect["SearchElementType"] = CSharpExpressionConverter.ConvertToken(browserGetElementScreenBoundingRectsearchElementType);
                browserGetElementScreenBoundingRectpropCount++;
            }

            if (browserGetElementScreenBoundingRectsearchElementMinimumWidth != null)
            {
                if (browserGetElementScreenBoundingRectsearchElementMinimumWidth != null)
                {
                    browserGetElementScreenBoundingRect["SearchElementMinimumWidth"] = CSharpExpressionConverter.ConvertToken(browserGetElementScreenBoundingRectsearchElementMinimumWidth);
                    browserGetElementScreenBoundingRectpropCount++;
                }

                browserGetElementScreenBoundingRectpropCount++;
            }
            else
            {
                browserGetElementScreenBoundingRect["SearchElementMinimumWidth"] = 1;
                browserGetElementScreenBoundingRectpropCount++;
            }

            if (browserGetElementScreenBoundingRectsearchElementMinimumHeight != null)
            {
                if (browserGetElementScreenBoundingRectsearchElementMinimumHeight != null)
                {
                    browserGetElementScreenBoundingRect["SearchElementMinimumHeight"] = CSharpExpressionConverter.ConvertToken(browserGetElementScreenBoundingRectsearchElementMinimumHeight);
                    browserGetElementScreenBoundingRectpropCount++;
                }

                browserGetElementScreenBoundingRectpropCount++;
            }
            else
            {
                browserGetElementScreenBoundingRect["SearchElementMinimumHeight"] = 1;
                browserGetElementScreenBoundingRectpropCount++;
            }

            if (browserGetElementScreenBoundingRectsearchElementBoundingBoxLeft != null)
            {
                if (browserGetElementScreenBoundingRectsearchElementBoundingBoxLeft != null)
                {
                    browserGetElementScreenBoundingRect["SearchElementBoundingBoxLeft"] = CSharpExpressionConverter.ConvertToken(browserGetElementScreenBoundingRectsearchElementBoundingBoxLeft);
                    browserGetElementScreenBoundingRectpropCount++;
                }

                browserGetElementScreenBoundingRectpropCount++;
            }
            else
            {
                browserGetElementScreenBoundingRect["SearchElementBoundingBoxLeft"] = -99999;
                browserGetElementScreenBoundingRectpropCount++;
            }

            if (browserGetElementScreenBoundingRectsearchElementBoundingBoxRight != null)
            {
                if (browserGetElementScreenBoundingRectsearchElementBoundingBoxRight != null)
                {
                    browserGetElementScreenBoundingRect["SearchElementBoundingBoxRight"] = CSharpExpressionConverter.ConvertToken(browserGetElementScreenBoundingRectsearchElementBoundingBoxRight);
                    browserGetElementScreenBoundingRectpropCount++;
                }

                browserGetElementScreenBoundingRectpropCount++;
            }
            else
            {
                browserGetElementScreenBoundingRect["SearchElementBoundingBoxRight"] = 99999;
                browserGetElementScreenBoundingRectpropCount++;
            }

            if (browserGetElementScreenBoundingRectsearchElementBoundingBoxTop != null)
            {
                if (browserGetElementScreenBoundingRectsearchElementBoundingBoxTop != null)
                {
                    browserGetElementScreenBoundingRect["SearchElementBoundingBoxTop"] = CSharpExpressionConverter.ConvertToken(browserGetElementScreenBoundingRectsearchElementBoundingBoxTop);
                    browserGetElementScreenBoundingRectpropCount++;
                }

                browserGetElementScreenBoundingRectpropCount++;
            }
            else
            {
                browserGetElementScreenBoundingRect["SearchElementBoundingBoxTop"] = -99999;
                browserGetElementScreenBoundingRectpropCount++;
            }

            if (browserGetElementScreenBoundingRectsearchElementBoundingBoxBottom != null)
            {
                if (browserGetElementScreenBoundingRectsearchElementBoundingBoxBottom != null)
                {
                    browserGetElementScreenBoundingRect["SearchElementBoundingBoxBottom"] = CSharpExpressionConverter.ConvertToken(browserGetElementScreenBoundingRectsearchElementBoundingBoxBottom);
                    browserGetElementScreenBoundingRectpropCount++;
                }

                browserGetElementScreenBoundingRectpropCount++;
            }
            else
            {
                browserGetElementScreenBoundingRect["SearchElementBoundingBoxBottom"] = 99999;
                browserGetElementScreenBoundingRectpropCount++;
            }

            if (browserGetElementScreenBoundingRectonlyElementTopLeftNeedsToBeInBoundingBox != null)
            {
                if (browserGetElementScreenBoundingRectonlyElementTopLeftNeedsToBeInBoundingBox != null)
                {
                    browserGetElementScreenBoundingRect["OnlyElementTopLeftNeedsToBeInBoundingBox"] = CSharpExpressionConverter.ConvertToken(browserGetElementScreenBoundingRectonlyElementTopLeftNeedsToBeInBoundingBox);
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
            browserGetElementScreenBoundingRect["Workflow"] = CSharpExpressionConverter.ConvertToken(browserGetElementScreenBoundingRectworkflow);
            if (browserGetElementScreenBoundingRectpropCount > 0)
            {
                callPayload.Body = browserGetElementScreenBoundingRect;
            }

            return new ApiConnectionAction<BrowserGetElementScreenBoundingRectResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserFocusElement(Expression<Func<string>> browserFocusElementworkflow, Expression<Func<double>> browserFocusElementparentElementHandle = null, Expression<Func<double>> browserFocusElementsearchElementHandle = null, Expression<Func<string>> browserFocusElementsearchElementName = null, Expression<Func<string>> browserFocusElementsearchElementID = null, Expression<Func<string>> browserFocusElementsearchElementTagName = null, Expression<Func<string>> browserFocusElementsearchElementXPath = null, Expression<Func<string>> browserFocusElementsearchElementClassName = null, Expression<Func<string>> browserFocusElementsearchElementCSSSelector = null, Expression<Func<double>> browserFocusElementsearchElementIndex = null, Expression<Func<string>> browserFocusElementsearchElementMatchValue = null, Expression<Func<string>> browserFocusElementsearchElementMatchText = null, Expression<Func<string>> browserFocusElementsearchElementType = null, Expression<Func<double>> browserFocusElementsearchElementMinimumWidth = null, Expression<Func<double>> browserFocusElementsearchElementMinimumHeight = null, Expression<Func<double>> browserFocusElementsearchElementBoundingBoxLeft = null, Expression<Func<double>> browserFocusElementsearchElementBoundingBoxRight = null, Expression<Func<double>> browserFocusElementsearchElementBoundingBoxTop = null, Expression<Func<double>> browserFocusElementsearchElementBoundingBoxBottom = null, Expression<Func<bool>> browserFocusElementonlyElementTopLeftNeedsToBeInBoundingBox = null)
        {
            var apiCallPath = "/BrowserControl/FocusElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserFocusElement = new JObject();
            var browserFocusElementpropCount = 0;
            if (browserFocusElementparentElementHandle != null)
            {
                browserFocusElement["ParentElementHandle"] = CSharpExpressionConverter.ConvertToken(browserFocusElementparentElementHandle);
                browserFocusElementpropCount++;
            }

            if (browserFocusElementsearchElementHandle != null)
            {
                browserFocusElement["SearchElementHandle"] = CSharpExpressionConverter.ConvertToken(browserFocusElementsearchElementHandle);
                browserFocusElementpropCount++;
            }

            if (browserFocusElementsearchElementName != null)
            {
                browserFocusElement["SearchElementName"] = CSharpExpressionConverter.ConvertToken(browserFocusElementsearchElementName);
                browserFocusElementpropCount++;
            }

            if (browserFocusElementsearchElementID != null)
            {
                browserFocusElement["SearchElementID"] = CSharpExpressionConverter.ConvertToken(browserFocusElementsearchElementID);
                browserFocusElementpropCount++;
            }

            if (browserFocusElementsearchElementTagName != null)
            {
                browserFocusElement["SearchElementTagName"] = CSharpExpressionConverter.ConvertToken(browserFocusElementsearchElementTagName);
                browserFocusElementpropCount++;
            }

            if (browserFocusElementsearchElementXPath != null)
            {
                browserFocusElement["SearchElementXPath"] = CSharpExpressionConverter.ConvertToken(browserFocusElementsearchElementXPath);
                browserFocusElementpropCount++;
            }

            if (browserFocusElementsearchElementClassName != null)
            {
                browserFocusElement["SearchElementClassName"] = CSharpExpressionConverter.ConvertToken(browserFocusElementsearchElementClassName);
                browserFocusElementpropCount++;
            }

            if (browserFocusElementsearchElementCSSSelector != null)
            {
                browserFocusElement["SearchElementCSSSelector"] = CSharpExpressionConverter.ConvertToken(browserFocusElementsearchElementCSSSelector);
                browserFocusElementpropCount++;
            }

            if (browserFocusElementsearchElementIndex != null)
            {
                if (browserFocusElementsearchElementIndex != null)
                {
                    browserFocusElement["SearchElementIndex"] = CSharpExpressionConverter.ConvertToken(browserFocusElementsearchElementIndex);
                    browserFocusElementpropCount++;
                }

                browserFocusElementpropCount++;
            }
            else
            {
                browserFocusElement["SearchElementIndex"] = 1;
                browserFocusElementpropCount++;
            }

            if (browserFocusElementsearchElementMatchValue != null)
            {
                browserFocusElement["SearchElementMatchValue"] = CSharpExpressionConverter.ConvertToken(browserFocusElementsearchElementMatchValue);
                browserFocusElementpropCount++;
            }

            if (browserFocusElementsearchElementMatchText != null)
            {
                browserFocusElement["SearchElementMatchText"] = CSharpExpressionConverter.ConvertToken(browserFocusElementsearchElementMatchText);
                browserFocusElementpropCount++;
            }

            if (browserFocusElementsearchElementType != null)
            {
                browserFocusElement["SearchElementType"] = CSharpExpressionConverter.ConvertToken(browserFocusElementsearchElementType);
                browserFocusElementpropCount++;
            }

            if (browserFocusElementsearchElementMinimumWidth != null)
            {
                if (browserFocusElementsearchElementMinimumWidth != null)
                {
                    browserFocusElement["SearchElementMinimumWidth"] = CSharpExpressionConverter.ConvertToken(browserFocusElementsearchElementMinimumWidth);
                    browserFocusElementpropCount++;
                }

                browserFocusElementpropCount++;
            }
            else
            {
                browserFocusElement["SearchElementMinimumWidth"] = 1;
                browserFocusElementpropCount++;
            }

            if (browserFocusElementsearchElementMinimumHeight != null)
            {
                if (browserFocusElementsearchElementMinimumHeight != null)
                {
                    browserFocusElement["SearchElementMinimumHeight"] = CSharpExpressionConverter.ConvertToken(browserFocusElementsearchElementMinimumHeight);
                    browserFocusElementpropCount++;
                }

                browserFocusElementpropCount++;
            }
            else
            {
                browserFocusElement["SearchElementMinimumHeight"] = 1;
                browserFocusElementpropCount++;
            }

            if (browserFocusElementsearchElementBoundingBoxLeft != null)
            {
                if (browserFocusElementsearchElementBoundingBoxLeft != null)
                {
                    browserFocusElement["SearchElementBoundingBoxLeft"] = CSharpExpressionConverter.ConvertToken(browserFocusElementsearchElementBoundingBoxLeft);
                    browserFocusElementpropCount++;
                }

                browserFocusElementpropCount++;
            }
            else
            {
                browserFocusElement["SearchElementBoundingBoxLeft"] = -99999;
                browserFocusElementpropCount++;
            }

            if (browserFocusElementsearchElementBoundingBoxRight != null)
            {
                if (browserFocusElementsearchElementBoundingBoxRight != null)
                {
                    browserFocusElement["SearchElementBoundingBoxRight"] = CSharpExpressionConverter.ConvertToken(browserFocusElementsearchElementBoundingBoxRight);
                    browserFocusElementpropCount++;
                }

                browserFocusElementpropCount++;
            }
            else
            {
                browserFocusElement["SearchElementBoundingBoxRight"] = 99999;
                browserFocusElementpropCount++;
            }

            if (browserFocusElementsearchElementBoundingBoxTop != null)
            {
                if (browserFocusElementsearchElementBoundingBoxTop != null)
                {
                    browserFocusElement["SearchElementBoundingBoxTop"] = CSharpExpressionConverter.ConvertToken(browserFocusElementsearchElementBoundingBoxTop);
                    browserFocusElementpropCount++;
                }

                browserFocusElementpropCount++;
            }
            else
            {
                browserFocusElement["SearchElementBoundingBoxTop"] = -99999;
                browserFocusElementpropCount++;
            }

            if (browserFocusElementsearchElementBoundingBoxBottom != null)
            {
                if (browserFocusElementsearchElementBoundingBoxBottom != null)
                {
                    browserFocusElement["SearchElementBoundingBoxBottom"] = CSharpExpressionConverter.ConvertToken(browserFocusElementsearchElementBoundingBoxBottom);
                    browserFocusElementpropCount++;
                }

                browserFocusElementpropCount++;
            }
            else
            {
                browserFocusElement["SearchElementBoundingBoxBottom"] = 99999;
                browserFocusElementpropCount++;
            }

            if (browserFocusElementonlyElementTopLeftNeedsToBeInBoundingBox != null)
            {
                if (browserFocusElementonlyElementTopLeftNeedsToBeInBoundingBox != null)
                {
                    browserFocusElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = CSharpExpressionConverter.ConvertToken(browserFocusElementonlyElementTopLeftNeedsToBeInBoundingBox);
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
            browserFocusElement["Workflow"] = CSharpExpressionConverter.ConvertToken(browserFocusElementworkflow);
            if (browserFocusElementpropCount > 0)
            {
                callPayload.Body = browserFocusElement;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserPressEnterOnElement(Expression<Func<string>> browserPressEnterOnElementworkflow, Expression<Func<double>> browserPressEnterOnElementparentElementHandle = null, Expression<Func<double>> browserPressEnterOnElementsearchElementHandle = null, Expression<Func<string>> browserPressEnterOnElementsearchElementName = null, Expression<Func<string>> browserPressEnterOnElementsearchElementID = null, Expression<Func<string>> browserPressEnterOnElementsearchElementTagName = null, Expression<Func<string>> browserPressEnterOnElementsearchElementXPath = null, Expression<Func<string>> browserPressEnterOnElementsearchElementClassName = null, Expression<Func<string>> browserPressEnterOnElementsearchElementCSSSelector = null, Expression<Func<double>> browserPressEnterOnElementsearchElementIndex = null, Expression<Func<string>> browserPressEnterOnElementsearchElementMatchValue = null, Expression<Func<string>> browserPressEnterOnElementsearchElementMatchText = null, Expression<Func<string>> browserPressEnterOnElementsearchElementType = null, Expression<Func<double>> browserPressEnterOnElementsearchElementMinimumWidth = null, Expression<Func<double>> browserPressEnterOnElementsearchElementMinimumHeight = null, Expression<Func<double>> browserPressEnterOnElementsearchElementBoundingBoxLeft = null, Expression<Func<double>> browserPressEnterOnElementsearchElementBoundingBoxRight = null, Expression<Func<double>> browserPressEnterOnElementsearchElementBoundingBoxTop = null, Expression<Func<double>> browserPressEnterOnElementsearchElementBoundingBoxBottom = null, Expression<Func<bool>> browserPressEnterOnElementonlyElementTopLeftNeedsToBeInBoundingBox = null)
        {
            var apiCallPath = "/BrowserControl/PressEnterOnElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserPressEnterOnElement = new JObject();
            var browserPressEnterOnElementpropCount = 0;
            if (browserPressEnterOnElementparentElementHandle != null)
            {
                browserPressEnterOnElement["ParentElementHandle"] = CSharpExpressionConverter.ConvertToken(browserPressEnterOnElementparentElementHandle);
                browserPressEnterOnElementpropCount++;
            }

            if (browserPressEnterOnElementsearchElementHandle != null)
            {
                browserPressEnterOnElement["SearchElementHandle"] = CSharpExpressionConverter.ConvertToken(browserPressEnterOnElementsearchElementHandle);
                browserPressEnterOnElementpropCount++;
            }

            if (browserPressEnterOnElementsearchElementName != null)
            {
                browserPressEnterOnElement["SearchElementName"] = CSharpExpressionConverter.ConvertToken(browserPressEnterOnElementsearchElementName);
                browserPressEnterOnElementpropCount++;
            }

            if (browserPressEnterOnElementsearchElementID != null)
            {
                browserPressEnterOnElement["SearchElementID"] = CSharpExpressionConverter.ConvertToken(browserPressEnterOnElementsearchElementID);
                browserPressEnterOnElementpropCount++;
            }

            if (browserPressEnterOnElementsearchElementTagName != null)
            {
                browserPressEnterOnElement["SearchElementTagName"] = CSharpExpressionConverter.ConvertToken(browserPressEnterOnElementsearchElementTagName);
                browserPressEnterOnElementpropCount++;
            }

            if (browserPressEnterOnElementsearchElementXPath != null)
            {
                browserPressEnterOnElement["SearchElementXPath"] = CSharpExpressionConverter.ConvertToken(browserPressEnterOnElementsearchElementXPath);
                browserPressEnterOnElementpropCount++;
            }

            if (browserPressEnterOnElementsearchElementClassName != null)
            {
                browserPressEnterOnElement["SearchElementClassName"] = CSharpExpressionConverter.ConvertToken(browserPressEnterOnElementsearchElementClassName);
                browserPressEnterOnElementpropCount++;
            }

            if (browserPressEnterOnElementsearchElementCSSSelector != null)
            {
                browserPressEnterOnElement["SearchElementCSSSelector"] = CSharpExpressionConverter.ConvertToken(browserPressEnterOnElementsearchElementCSSSelector);
                browserPressEnterOnElementpropCount++;
            }

            if (browserPressEnterOnElementsearchElementIndex != null)
            {
                if (browserPressEnterOnElementsearchElementIndex != null)
                {
                    browserPressEnterOnElement["SearchElementIndex"] = CSharpExpressionConverter.ConvertToken(browserPressEnterOnElementsearchElementIndex);
                    browserPressEnterOnElementpropCount++;
                }

                browserPressEnterOnElementpropCount++;
            }
            else
            {
                browserPressEnterOnElement["SearchElementIndex"] = 1;
                browserPressEnterOnElementpropCount++;
            }

            if (browserPressEnterOnElementsearchElementMatchValue != null)
            {
                browserPressEnterOnElement["SearchElementMatchValue"] = CSharpExpressionConverter.ConvertToken(browserPressEnterOnElementsearchElementMatchValue);
                browserPressEnterOnElementpropCount++;
            }

            if (browserPressEnterOnElementsearchElementMatchText != null)
            {
                browserPressEnterOnElement["SearchElementMatchText"] = CSharpExpressionConverter.ConvertToken(browserPressEnterOnElementsearchElementMatchText);
                browserPressEnterOnElementpropCount++;
            }

            if (browserPressEnterOnElementsearchElementType != null)
            {
                browserPressEnterOnElement["SearchElementType"] = CSharpExpressionConverter.ConvertToken(browserPressEnterOnElementsearchElementType);
                browserPressEnterOnElementpropCount++;
            }

            if (browserPressEnterOnElementsearchElementMinimumWidth != null)
            {
                if (browserPressEnterOnElementsearchElementMinimumWidth != null)
                {
                    browserPressEnterOnElement["SearchElementMinimumWidth"] = CSharpExpressionConverter.ConvertToken(browserPressEnterOnElementsearchElementMinimumWidth);
                    browserPressEnterOnElementpropCount++;
                }

                browserPressEnterOnElementpropCount++;
            }
            else
            {
                browserPressEnterOnElement["SearchElementMinimumWidth"] = 1;
                browserPressEnterOnElementpropCount++;
            }

            if (browserPressEnterOnElementsearchElementMinimumHeight != null)
            {
                if (browserPressEnterOnElementsearchElementMinimumHeight != null)
                {
                    browserPressEnterOnElement["SearchElementMinimumHeight"] = CSharpExpressionConverter.ConvertToken(browserPressEnterOnElementsearchElementMinimumHeight);
                    browserPressEnterOnElementpropCount++;
                }

                browserPressEnterOnElementpropCount++;
            }
            else
            {
                browserPressEnterOnElement["SearchElementMinimumHeight"] = 1;
                browserPressEnterOnElementpropCount++;
            }

            if (browserPressEnterOnElementsearchElementBoundingBoxLeft != null)
            {
                if (browserPressEnterOnElementsearchElementBoundingBoxLeft != null)
                {
                    browserPressEnterOnElement["SearchElementBoundingBoxLeft"] = CSharpExpressionConverter.ConvertToken(browserPressEnterOnElementsearchElementBoundingBoxLeft);
                    browserPressEnterOnElementpropCount++;
                }

                browserPressEnterOnElementpropCount++;
            }
            else
            {
                browserPressEnterOnElement["SearchElementBoundingBoxLeft"] = -99999;
                browserPressEnterOnElementpropCount++;
            }

            if (browserPressEnterOnElementsearchElementBoundingBoxRight != null)
            {
                if (browserPressEnterOnElementsearchElementBoundingBoxRight != null)
                {
                    browserPressEnterOnElement["SearchElementBoundingBoxRight"] = CSharpExpressionConverter.ConvertToken(browserPressEnterOnElementsearchElementBoundingBoxRight);
                    browserPressEnterOnElementpropCount++;
                }

                browserPressEnterOnElementpropCount++;
            }
            else
            {
                browserPressEnterOnElement["SearchElementBoundingBoxRight"] = 99999;
                browserPressEnterOnElementpropCount++;
            }

            if (browserPressEnterOnElementsearchElementBoundingBoxTop != null)
            {
                if (browserPressEnterOnElementsearchElementBoundingBoxTop != null)
                {
                    browserPressEnterOnElement["SearchElementBoundingBoxTop"] = CSharpExpressionConverter.ConvertToken(browserPressEnterOnElementsearchElementBoundingBoxTop);
                    browserPressEnterOnElementpropCount++;
                }

                browserPressEnterOnElementpropCount++;
            }
            else
            {
                browserPressEnterOnElement["SearchElementBoundingBoxTop"] = -99999;
                browserPressEnterOnElementpropCount++;
            }

            if (browserPressEnterOnElementsearchElementBoundingBoxBottom != null)
            {
                if (browserPressEnterOnElementsearchElementBoundingBoxBottom != null)
                {
                    browserPressEnterOnElement["SearchElementBoundingBoxBottom"] = CSharpExpressionConverter.ConvertToken(browserPressEnterOnElementsearchElementBoundingBoxBottom);
                    browserPressEnterOnElementpropCount++;
                }

                browserPressEnterOnElementpropCount++;
            }
            else
            {
                browserPressEnterOnElement["SearchElementBoundingBoxBottom"] = 99999;
                browserPressEnterOnElementpropCount++;
            }

            if (browserPressEnterOnElementonlyElementTopLeftNeedsToBeInBoundingBox != null)
            {
                if (browserPressEnterOnElementonlyElementTopLeftNeedsToBeInBoundingBox != null)
                {
                    browserPressEnterOnElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = CSharpExpressionConverter.ConvertToken(browserPressEnterOnElementonlyElementTopLeftNeedsToBeInBoundingBox);
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
            browserPressEnterOnElement["Workflow"] = CSharpExpressionConverter.ConvertToken(browserPressEnterOnElementworkflow);
            if (browserPressEnterOnElementpropCount > 0)
            {
                callPayload.Body = browserPressEnterOnElement;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserMouseLeftClickOnElement(Expression<Func<string>> browserMouseLeftClickOnElementworkflow, Expression<Func<double>> browserMouseLeftClickOnElementparentElementHandle = null, Expression<Func<double>> browserMouseLeftClickOnElementsearchElementHandle = null, Expression<Func<string>> browserMouseLeftClickOnElementsearchElementName = null, Expression<Func<string>> browserMouseLeftClickOnElementsearchElementID = null, Expression<Func<string>> browserMouseLeftClickOnElementsearchElementTagName = null, Expression<Func<string>> browserMouseLeftClickOnElementsearchElementXPath = null, Expression<Func<string>> browserMouseLeftClickOnElementsearchElementClassName = null, Expression<Func<string>> browserMouseLeftClickOnElementsearchElementCSSSelector = null, Expression<Func<double>> browserMouseLeftClickOnElementsearchElementIndex = null, Expression<Func<string>> browserMouseLeftClickOnElementsearchElementMatchValue = null, Expression<Func<string>> browserMouseLeftClickOnElementsearchElementMatchText = null, Expression<Func<string>> browserMouseLeftClickOnElementsearchElementType = null, Expression<Func<double>> browserMouseLeftClickOnElementsearchElementMinimumWidth = null, Expression<Func<double>> browserMouseLeftClickOnElementsearchElementMinimumHeight = null, Expression<Func<double>> browserMouseLeftClickOnElementsearchElementBoundingBoxLeft = null, Expression<Func<double>> browserMouseLeftClickOnElementsearchElementBoundingBoxRight = null, Expression<Func<double>> browserMouseLeftClickOnElementsearchElementBoundingBoxTop = null, Expression<Func<double>> browserMouseLeftClickOnElementsearchElementBoundingBoxBottom = null, Expression<Func<bool>> browserMouseLeftClickOnElementonlyElementTopLeftNeedsToBeInBoundingBox = null, Expression<Func<bool>> browserMouseLeftClickOnElementfocusFirst = null)
        {
            var apiCallPath = "/BrowserControl/MouseLeftClickOnElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserMouseLeftClickOnElement = new JObject();
            var browserMouseLeftClickOnElementpropCount = 0;
            if (browserMouseLeftClickOnElementparentElementHandle != null)
            {
                browserMouseLeftClickOnElement["ParentElementHandle"] = CSharpExpressionConverter.ConvertToken(browserMouseLeftClickOnElementparentElementHandle);
                browserMouseLeftClickOnElementpropCount++;
            }

            if (browserMouseLeftClickOnElementsearchElementHandle != null)
            {
                browserMouseLeftClickOnElement["SearchElementHandle"] = CSharpExpressionConverter.ConvertToken(browserMouseLeftClickOnElementsearchElementHandle);
                browserMouseLeftClickOnElementpropCount++;
            }

            if (browserMouseLeftClickOnElementsearchElementName != null)
            {
                browserMouseLeftClickOnElement["SearchElementName"] = CSharpExpressionConverter.ConvertToken(browserMouseLeftClickOnElementsearchElementName);
                browserMouseLeftClickOnElementpropCount++;
            }

            if (browserMouseLeftClickOnElementsearchElementID != null)
            {
                browserMouseLeftClickOnElement["SearchElementID"] = CSharpExpressionConverter.ConvertToken(browserMouseLeftClickOnElementsearchElementID);
                browserMouseLeftClickOnElementpropCount++;
            }

            if (browserMouseLeftClickOnElementsearchElementTagName != null)
            {
                browserMouseLeftClickOnElement["SearchElementTagName"] = CSharpExpressionConverter.ConvertToken(browserMouseLeftClickOnElementsearchElementTagName);
                browserMouseLeftClickOnElementpropCount++;
            }

            if (browserMouseLeftClickOnElementsearchElementXPath != null)
            {
                browserMouseLeftClickOnElement["SearchElementXPath"] = CSharpExpressionConverter.ConvertToken(browserMouseLeftClickOnElementsearchElementXPath);
                browserMouseLeftClickOnElementpropCount++;
            }

            if (browserMouseLeftClickOnElementsearchElementClassName != null)
            {
                browserMouseLeftClickOnElement["SearchElementClassName"] = CSharpExpressionConverter.ConvertToken(browserMouseLeftClickOnElementsearchElementClassName);
                browserMouseLeftClickOnElementpropCount++;
            }

            if (browserMouseLeftClickOnElementsearchElementCSSSelector != null)
            {
                browserMouseLeftClickOnElement["SearchElementCSSSelector"] = CSharpExpressionConverter.ConvertToken(browserMouseLeftClickOnElementsearchElementCSSSelector);
                browserMouseLeftClickOnElementpropCount++;
            }

            if (browserMouseLeftClickOnElementsearchElementIndex != null)
            {
                if (browserMouseLeftClickOnElementsearchElementIndex != null)
                {
                    browserMouseLeftClickOnElement["SearchElementIndex"] = CSharpExpressionConverter.ConvertToken(browserMouseLeftClickOnElementsearchElementIndex);
                    browserMouseLeftClickOnElementpropCount++;
                }

                browserMouseLeftClickOnElementpropCount++;
            }
            else
            {
                browserMouseLeftClickOnElement["SearchElementIndex"] = 1;
                browserMouseLeftClickOnElementpropCount++;
            }

            if (browserMouseLeftClickOnElementsearchElementMatchValue != null)
            {
                browserMouseLeftClickOnElement["SearchElementMatchValue"] = CSharpExpressionConverter.ConvertToken(browserMouseLeftClickOnElementsearchElementMatchValue);
                browserMouseLeftClickOnElementpropCount++;
            }

            if (browserMouseLeftClickOnElementsearchElementMatchText != null)
            {
                browserMouseLeftClickOnElement["SearchElementMatchText"] = CSharpExpressionConverter.ConvertToken(browserMouseLeftClickOnElementsearchElementMatchText);
                browserMouseLeftClickOnElementpropCount++;
            }

            if (browserMouseLeftClickOnElementsearchElementType != null)
            {
                browserMouseLeftClickOnElement["SearchElementType"] = CSharpExpressionConverter.ConvertToken(browserMouseLeftClickOnElementsearchElementType);
                browserMouseLeftClickOnElementpropCount++;
            }

            if (browserMouseLeftClickOnElementsearchElementMinimumWidth != null)
            {
                if (browserMouseLeftClickOnElementsearchElementMinimumWidth != null)
                {
                    browserMouseLeftClickOnElement["SearchElementMinimumWidth"] = CSharpExpressionConverter.ConvertToken(browserMouseLeftClickOnElementsearchElementMinimumWidth);
                    browserMouseLeftClickOnElementpropCount++;
                }

                browserMouseLeftClickOnElementpropCount++;
            }
            else
            {
                browserMouseLeftClickOnElement["SearchElementMinimumWidth"] = 1;
                browserMouseLeftClickOnElementpropCount++;
            }

            if (browserMouseLeftClickOnElementsearchElementMinimumHeight != null)
            {
                if (browserMouseLeftClickOnElementsearchElementMinimumHeight != null)
                {
                    browserMouseLeftClickOnElement["SearchElementMinimumHeight"] = CSharpExpressionConverter.ConvertToken(browserMouseLeftClickOnElementsearchElementMinimumHeight);
                    browserMouseLeftClickOnElementpropCount++;
                }

                browserMouseLeftClickOnElementpropCount++;
            }
            else
            {
                browserMouseLeftClickOnElement["SearchElementMinimumHeight"] = 1;
                browserMouseLeftClickOnElementpropCount++;
            }

            if (browserMouseLeftClickOnElementsearchElementBoundingBoxLeft != null)
            {
                if (browserMouseLeftClickOnElementsearchElementBoundingBoxLeft != null)
                {
                    browserMouseLeftClickOnElement["SearchElementBoundingBoxLeft"] = CSharpExpressionConverter.ConvertToken(browserMouseLeftClickOnElementsearchElementBoundingBoxLeft);
                    browserMouseLeftClickOnElementpropCount++;
                }

                browserMouseLeftClickOnElementpropCount++;
            }
            else
            {
                browserMouseLeftClickOnElement["SearchElementBoundingBoxLeft"] = -99999;
                browserMouseLeftClickOnElementpropCount++;
            }

            if (browserMouseLeftClickOnElementsearchElementBoundingBoxRight != null)
            {
                if (browserMouseLeftClickOnElementsearchElementBoundingBoxRight != null)
                {
                    browserMouseLeftClickOnElement["SearchElementBoundingBoxRight"] = CSharpExpressionConverter.ConvertToken(browserMouseLeftClickOnElementsearchElementBoundingBoxRight);
                    browserMouseLeftClickOnElementpropCount++;
                }

                browserMouseLeftClickOnElementpropCount++;
            }
            else
            {
                browserMouseLeftClickOnElement["SearchElementBoundingBoxRight"] = 99999;
                browserMouseLeftClickOnElementpropCount++;
            }

            if (browserMouseLeftClickOnElementsearchElementBoundingBoxTop != null)
            {
                if (browserMouseLeftClickOnElementsearchElementBoundingBoxTop != null)
                {
                    browserMouseLeftClickOnElement["SearchElementBoundingBoxTop"] = CSharpExpressionConverter.ConvertToken(browserMouseLeftClickOnElementsearchElementBoundingBoxTop);
                    browserMouseLeftClickOnElementpropCount++;
                }

                browserMouseLeftClickOnElementpropCount++;
            }
            else
            {
                browserMouseLeftClickOnElement["SearchElementBoundingBoxTop"] = -99999;
                browserMouseLeftClickOnElementpropCount++;
            }

            if (browserMouseLeftClickOnElementsearchElementBoundingBoxBottom != null)
            {
                if (browserMouseLeftClickOnElementsearchElementBoundingBoxBottom != null)
                {
                    browserMouseLeftClickOnElement["SearchElementBoundingBoxBottom"] = CSharpExpressionConverter.ConvertToken(browserMouseLeftClickOnElementsearchElementBoundingBoxBottom);
                    browserMouseLeftClickOnElementpropCount++;
                }

                browserMouseLeftClickOnElementpropCount++;
            }
            else
            {
                browserMouseLeftClickOnElement["SearchElementBoundingBoxBottom"] = 99999;
                browserMouseLeftClickOnElementpropCount++;
            }

            if (browserMouseLeftClickOnElementonlyElementTopLeftNeedsToBeInBoundingBox != null)
            {
                if (browserMouseLeftClickOnElementonlyElementTopLeftNeedsToBeInBoundingBox != null)
                {
                    browserMouseLeftClickOnElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = CSharpExpressionConverter.ConvertToken(browserMouseLeftClickOnElementonlyElementTopLeftNeedsToBeInBoundingBox);
                    browserMouseLeftClickOnElementpropCount++;
                }

                browserMouseLeftClickOnElementpropCount++;
            }
            else
            {
                browserMouseLeftClickOnElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = false;
                browserMouseLeftClickOnElementpropCount++;
            }

            if (browserMouseLeftClickOnElementfocusFirst != null)
            {
                if (browserMouseLeftClickOnElementfocusFirst != null)
                {
                    browserMouseLeftClickOnElement["FocusFirst"] = CSharpExpressionConverter.ConvertToken(browserMouseLeftClickOnElementfocusFirst);
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
            browserMouseLeftClickOnElement["Workflow"] = CSharpExpressionConverter.ConvertToken(browserMouseLeftClickOnElementworkflow);
            if (browserMouseLeftClickOnElementpropCount > 0)
            {
                callPayload.Body = browserMouseLeftClickOnElement;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserMouseRightClickOnElement(Expression<Func<string>> browserMouseRightClickOnElementworkflow, Expression<Func<double>> browserMouseRightClickOnElementparentElementHandle = null, Expression<Func<double>> browserMouseRightClickOnElementsearchElementHandle = null, Expression<Func<string>> browserMouseRightClickOnElementsearchElementName = null, Expression<Func<string>> browserMouseRightClickOnElementsearchElementID = null, Expression<Func<string>> browserMouseRightClickOnElementsearchElementTagName = null, Expression<Func<string>> browserMouseRightClickOnElementsearchElementXPath = null, Expression<Func<string>> browserMouseRightClickOnElementsearchElementClassName = null, Expression<Func<string>> browserMouseRightClickOnElementsearchElementCSSSelector = null, Expression<Func<double>> browserMouseRightClickOnElementsearchElementIndex = null, Expression<Func<string>> browserMouseRightClickOnElementsearchElementMatchValue = null, Expression<Func<string>> browserMouseRightClickOnElementsearchElementMatchText = null, Expression<Func<string>> browserMouseRightClickOnElementsearchElementType = null, Expression<Func<double>> browserMouseRightClickOnElementsearchElementMinimumWidth = null, Expression<Func<double>> browserMouseRightClickOnElementsearchElementMinimumHeight = null, Expression<Func<double>> browserMouseRightClickOnElementsearchElementBoundingBoxLeft = null, Expression<Func<double>> browserMouseRightClickOnElementsearchElementBoundingBoxRight = null, Expression<Func<double>> browserMouseRightClickOnElementsearchElementBoundingBoxTop = null, Expression<Func<double>> browserMouseRightClickOnElementsearchElementBoundingBoxBottom = null, Expression<Func<bool>> browserMouseRightClickOnElementonlyElementTopLeftNeedsToBeInBoundingBox = null, Expression<Func<bool>> browserMouseRightClickOnElementfocusFirst = null)
        {
            var apiCallPath = "/BrowserControl/MouseRightClickOnElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserMouseRightClickOnElement = new JObject();
            var browserMouseRightClickOnElementpropCount = 0;
            if (browserMouseRightClickOnElementparentElementHandle != null)
            {
                browserMouseRightClickOnElement["ParentElementHandle"] = CSharpExpressionConverter.ConvertToken(browserMouseRightClickOnElementparentElementHandle);
                browserMouseRightClickOnElementpropCount++;
            }

            if (browserMouseRightClickOnElementsearchElementHandle != null)
            {
                browserMouseRightClickOnElement["SearchElementHandle"] = CSharpExpressionConverter.ConvertToken(browserMouseRightClickOnElementsearchElementHandle);
                browserMouseRightClickOnElementpropCount++;
            }

            if (browserMouseRightClickOnElementsearchElementName != null)
            {
                browserMouseRightClickOnElement["SearchElementName"] = CSharpExpressionConverter.ConvertToken(browserMouseRightClickOnElementsearchElementName);
                browserMouseRightClickOnElementpropCount++;
            }

            if (browserMouseRightClickOnElementsearchElementID != null)
            {
                browserMouseRightClickOnElement["SearchElementID"] = CSharpExpressionConverter.ConvertToken(browserMouseRightClickOnElementsearchElementID);
                browserMouseRightClickOnElementpropCount++;
            }

            if (browserMouseRightClickOnElementsearchElementTagName != null)
            {
                browserMouseRightClickOnElement["SearchElementTagName"] = CSharpExpressionConverter.ConvertToken(browserMouseRightClickOnElementsearchElementTagName);
                browserMouseRightClickOnElementpropCount++;
            }

            if (browserMouseRightClickOnElementsearchElementXPath != null)
            {
                browserMouseRightClickOnElement["SearchElementXPath"] = CSharpExpressionConverter.ConvertToken(browserMouseRightClickOnElementsearchElementXPath);
                browserMouseRightClickOnElementpropCount++;
            }

            if (browserMouseRightClickOnElementsearchElementClassName != null)
            {
                browserMouseRightClickOnElement["SearchElementClassName"] = CSharpExpressionConverter.ConvertToken(browserMouseRightClickOnElementsearchElementClassName);
                browserMouseRightClickOnElementpropCount++;
            }

            if (browserMouseRightClickOnElementsearchElementCSSSelector != null)
            {
                browserMouseRightClickOnElement["SearchElementCSSSelector"] = CSharpExpressionConverter.ConvertToken(browserMouseRightClickOnElementsearchElementCSSSelector);
                browserMouseRightClickOnElementpropCount++;
            }

            if (browserMouseRightClickOnElementsearchElementIndex != null)
            {
                if (browserMouseRightClickOnElementsearchElementIndex != null)
                {
                    browserMouseRightClickOnElement["SearchElementIndex"] = CSharpExpressionConverter.ConvertToken(browserMouseRightClickOnElementsearchElementIndex);
                    browserMouseRightClickOnElementpropCount++;
                }

                browserMouseRightClickOnElementpropCount++;
            }
            else
            {
                browserMouseRightClickOnElement["SearchElementIndex"] = 1;
                browserMouseRightClickOnElementpropCount++;
            }

            if (browserMouseRightClickOnElementsearchElementMatchValue != null)
            {
                browserMouseRightClickOnElement["SearchElementMatchValue"] = CSharpExpressionConverter.ConvertToken(browserMouseRightClickOnElementsearchElementMatchValue);
                browserMouseRightClickOnElementpropCount++;
            }

            if (browserMouseRightClickOnElementsearchElementMatchText != null)
            {
                browserMouseRightClickOnElement["SearchElementMatchText"] = CSharpExpressionConverter.ConvertToken(browserMouseRightClickOnElementsearchElementMatchText);
                browserMouseRightClickOnElementpropCount++;
            }

            if (browserMouseRightClickOnElementsearchElementType != null)
            {
                browserMouseRightClickOnElement["SearchElementType"] = CSharpExpressionConverter.ConvertToken(browserMouseRightClickOnElementsearchElementType);
                browserMouseRightClickOnElementpropCount++;
            }

            if (browserMouseRightClickOnElementsearchElementMinimumWidth != null)
            {
                if (browserMouseRightClickOnElementsearchElementMinimumWidth != null)
                {
                    browserMouseRightClickOnElement["SearchElementMinimumWidth"] = CSharpExpressionConverter.ConvertToken(browserMouseRightClickOnElementsearchElementMinimumWidth);
                    browserMouseRightClickOnElementpropCount++;
                }

                browserMouseRightClickOnElementpropCount++;
            }
            else
            {
                browserMouseRightClickOnElement["SearchElementMinimumWidth"] = 1;
                browserMouseRightClickOnElementpropCount++;
            }

            if (browserMouseRightClickOnElementsearchElementMinimumHeight != null)
            {
                if (browserMouseRightClickOnElementsearchElementMinimumHeight != null)
                {
                    browserMouseRightClickOnElement["SearchElementMinimumHeight"] = CSharpExpressionConverter.ConvertToken(browserMouseRightClickOnElementsearchElementMinimumHeight);
                    browserMouseRightClickOnElementpropCount++;
                }

                browserMouseRightClickOnElementpropCount++;
            }
            else
            {
                browserMouseRightClickOnElement["SearchElementMinimumHeight"] = 1;
                browserMouseRightClickOnElementpropCount++;
            }

            if (browserMouseRightClickOnElementsearchElementBoundingBoxLeft != null)
            {
                if (browserMouseRightClickOnElementsearchElementBoundingBoxLeft != null)
                {
                    browserMouseRightClickOnElement["SearchElementBoundingBoxLeft"] = CSharpExpressionConverter.ConvertToken(browserMouseRightClickOnElementsearchElementBoundingBoxLeft);
                    browserMouseRightClickOnElementpropCount++;
                }

                browserMouseRightClickOnElementpropCount++;
            }
            else
            {
                browserMouseRightClickOnElement["SearchElementBoundingBoxLeft"] = -99999;
                browserMouseRightClickOnElementpropCount++;
            }

            if (browserMouseRightClickOnElementsearchElementBoundingBoxRight != null)
            {
                if (browserMouseRightClickOnElementsearchElementBoundingBoxRight != null)
                {
                    browserMouseRightClickOnElement["SearchElementBoundingBoxRight"] = CSharpExpressionConverter.ConvertToken(browserMouseRightClickOnElementsearchElementBoundingBoxRight);
                    browserMouseRightClickOnElementpropCount++;
                }

                browserMouseRightClickOnElementpropCount++;
            }
            else
            {
                browserMouseRightClickOnElement["SearchElementBoundingBoxRight"] = 99999;
                browserMouseRightClickOnElementpropCount++;
            }

            if (browserMouseRightClickOnElementsearchElementBoundingBoxTop != null)
            {
                if (browserMouseRightClickOnElementsearchElementBoundingBoxTop != null)
                {
                    browserMouseRightClickOnElement["SearchElementBoundingBoxTop"] = CSharpExpressionConverter.ConvertToken(browserMouseRightClickOnElementsearchElementBoundingBoxTop);
                    browserMouseRightClickOnElementpropCount++;
                }

                browserMouseRightClickOnElementpropCount++;
            }
            else
            {
                browserMouseRightClickOnElement["SearchElementBoundingBoxTop"] = -99999;
                browserMouseRightClickOnElementpropCount++;
            }

            if (browserMouseRightClickOnElementsearchElementBoundingBoxBottom != null)
            {
                if (browserMouseRightClickOnElementsearchElementBoundingBoxBottom != null)
                {
                    browserMouseRightClickOnElement["SearchElementBoundingBoxBottom"] = CSharpExpressionConverter.ConvertToken(browserMouseRightClickOnElementsearchElementBoundingBoxBottom);
                    browserMouseRightClickOnElementpropCount++;
                }

                browserMouseRightClickOnElementpropCount++;
            }
            else
            {
                browserMouseRightClickOnElement["SearchElementBoundingBoxBottom"] = 99999;
                browserMouseRightClickOnElementpropCount++;
            }

            if (browserMouseRightClickOnElementonlyElementTopLeftNeedsToBeInBoundingBox != null)
            {
                if (browserMouseRightClickOnElementonlyElementTopLeftNeedsToBeInBoundingBox != null)
                {
                    browserMouseRightClickOnElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = CSharpExpressionConverter.ConvertToken(browserMouseRightClickOnElementonlyElementTopLeftNeedsToBeInBoundingBox);
                    browserMouseRightClickOnElementpropCount++;
                }

                browserMouseRightClickOnElementpropCount++;
            }
            else
            {
                browserMouseRightClickOnElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = false;
                browserMouseRightClickOnElementpropCount++;
            }

            if (browserMouseRightClickOnElementfocusFirst != null)
            {
                if (browserMouseRightClickOnElementfocusFirst != null)
                {
                    browserMouseRightClickOnElement["FocusFirst"] = CSharpExpressionConverter.ConvertToken(browserMouseRightClickOnElementfocusFirst);
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
            browserMouseRightClickOnElement["Workflow"] = CSharpExpressionConverter.ConvertToken(browserMouseRightClickOnElementworkflow);
            if (browserMouseRightClickOnElementpropCount > 0)
            {
                callPayload.Body = browserMouseRightClickOnElement;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserJavaScriptClickOnElement(Expression<Func<string>> browserJavaScriptClickOnElementworkflow, Expression<Func<double>> browserJavaScriptClickOnElementparentElementHandle = null, Expression<Func<double>> browserJavaScriptClickOnElementsearchElementHandle = null, Expression<Func<string>> browserJavaScriptClickOnElementsearchElementName = null, Expression<Func<string>> browserJavaScriptClickOnElementsearchElementID = null, Expression<Func<string>> browserJavaScriptClickOnElementsearchElementTagName = null, Expression<Func<string>> browserJavaScriptClickOnElementsearchElementXPath = null, Expression<Func<string>> browserJavaScriptClickOnElementsearchElementClassName = null, Expression<Func<string>> browserJavaScriptClickOnElementsearchElementCSSSelector = null, Expression<Func<double>> browserJavaScriptClickOnElementsearchElementIndex = null, Expression<Func<string>> browserJavaScriptClickOnElementsearchElementMatchValue = null, Expression<Func<string>> browserJavaScriptClickOnElementsearchElementMatchText = null, Expression<Func<string>> browserJavaScriptClickOnElementsearchElementType = null, Expression<Func<double>> browserJavaScriptClickOnElementsearchElementMinimumWidth = null, Expression<Func<double>> browserJavaScriptClickOnElementsearchElementMinimumHeight = null, Expression<Func<double>> browserJavaScriptClickOnElementsearchElementBoundingBoxLeft = null, Expression<Func<double>> browserJavaScriptClickOnElementsearchElementBoundingBoxRight = null, Expression<Func<double>> browserJavaScriptClickOnElementsearchElementBoundingBoxTop = null, Expression<Func<double>> browserJavaScriptClickOnElementsearchElementBoundingBoxBottom = null, Expression<Func<bool>> browserJavaScriptClickOnElementonlyElementTopLeftNeedsToBeInBoundingBox = null)
        {
            var apiCallPath = "/BrowserControl/JavaScriptClickOnElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserJavaScriptClickOnElement = new JObject();
            var browserJavaScriptClickOnElementpropCount = 0;
            if (browserJavaScriptClickOnElementparentElementHandle != null)
            {
                browserJavaScriptClickOnElement["ParentElementHandle"] = CSharpExpressionConverter.ConvertToken(browserJavaScriptClickOnElementparentElementHandle);
                browserJavaScriptClickOnElementpropCount++;
            }

            if (browserJavaScriptClickOnElementsearchElementHandle != null)
            {
                browserJavaScriptClickOnElement["SearchElementHandle"] = CSharpExpressionConverter.ConvertToken(browserJavaScriptClickOnElementsearchElementHandle);
                browserJavaScriptClickOnElementpropCount++;
            }

            if (browserJavaScriptClickOnElementsearchElementName != null)
            {
                browserJavaScriptClickOnElement["SearchElementName"] = CSharpExpressionConverter.ConvertToken(browserJavaScriptClickOnElementsearchElementName);
                browserJavaScriptClickOnElementpropCount++;
            }

            if (browserJavaScriptClickOnElementsearchElementID != null)
            {
                browserJavaScriptClickOnElement["SearchElementID"] = CSharpExpressionConverter.ConvertToken(browserJavaScriptClickOnElementsearchElementID);
                browserJavaScriptClickOnElementpropCount++;
            }

            if (browserJavaScriptClickOnElementsearchElementTagName != null)
            {
                browserJavaScriptClickOnElement["SearchElementTagName"] = CSharpExpressionConverter.ConvertToken(browserJavaScriptClickOnElementsearchElementTagName);
                browserJavaScriptClickOnElementpropCount++;
            }

            if (browserJavaScriptClickOnElementsearchElementXPath != null)
            {
                browserJavaScriptClickOnElement["SearchElementXPath"] = CSharpExpressionConverter.ConvertToken(browserJavaScriptClickOnElementsearchElementXPath);
                browserJavaScriptClickOnElementpropCount++;
            }

            if (browserJavaScriptClickOnElementsearchElementClassName != null)
            {
                browserJavaScriptClickOnElement["SearchElementClassName"] = CSharpExpressionConverter.ConvertToken(browserJavaScriptClickOnElementsearchElementClassName);
                browserJavaScriptClickOnElementpropCount++;
            }

            if (browserJavaScriptClickOnElementsearchElementCSSSelector != null)
            {
                browserJavaScriptClickOnElement["SearchElementCSSSelector"] = CSharpExpressionConverter.ConvertToken(browserJavaScriptClickOnElementsearchElementCSSSelector);
                browserJavaScriptClickOnElementpropCount++;
            }

            if (browserJavaScriptClickOnElementsearchElementIndex != null)
            {
                if (browserJavaScriptClickOnElementsearchElementIndex != null)
                {
                    browserJavaScriptClickOnElement["SearchElementIndex"] = CSharpExpressionConverter.ConvertToken(browserJavaScriptClickOnElementsearchElementIndex);
                    browserJavaScriptClickOnElementpropCount++;
                }

                browserJavaScriptClickOnElementpropCount++;
            }
            else
            {
                browserJavaScriptClickOnElement["SearchElementIndex"] = 1;
                browserJavaScriptClickOnElementpropCount++;
            }

            if (browserJavaScriptClickOnElementsearchElementMatchValue != null)
            {
                browserJavaScriptClickOnElement["SearchElementMatchValue"] = CSharpExpressionConverter.ConvertToken(browserJavaScriptClickOnElementsearchElementMatchValue);
                browserJavaScriptClickOnElementpropCount++;
            }

            if (browserJavaScriptClickOnElementsearchElementMatchText != null)
            {
                browserJavaScriptClickOnElement["SearchElementMatchText"] = CSharpExpressionConverter.ConvertToken(browserJavaScriptClickOnElementsearchElementMatchText);
                browserJavaScriptClickOnElementpropCount++;
            }

            if (browserJavaScriptClickOnElementsearchElementType != null)
            {
                browserJavaScriptClickOnElement["SearchElementType"] = CSharpExpressionConverter.ConvertToken(browserJavaScriptClickOnElementsearchElementType);
                browserJavaScriptClickOnElementpropCount++;
            }

            if (browserJavaScriptClickOnElementsearchElementMinimumWidth != null)
            {
                if (browserJavaScriptClickOnElementsearchElementMinimumWidth != null)
                {
                    browserJavaScriptClickOnElement["SearchElementMinimumWidth"] = CSharpExpressionConverter.ConvertToken(browserJavaScriptClickOnElementsearchElementMinimumWidth);
                    browserJavaScriptClickOnElementpropCount++;
                }

                browserJavaScriptClickOnElementpropCount++;
            }
            else
            {
                browserJavaScriptClickOnElement["SearchElementMinimumWidth"] = 1;
                browserJavaScriptClickOnElementpropCount++;
            }

            if (browserJavaScriptClickOnElementsearchElementMinimumHeight != null)
            {
                if (browserJavaScriptClickOnElementsearchElementMinimumHeight != null)
                {
                    browserJavaScriptClickOnElement["SearchElementMinimumHeight"] = CSharpExpressionConverter.ConvertToken(browserJavaScriptClickOnElementsearchElementMinimumHeight);
                    browserJavaScriptClickOnElementpropCount++;
                }

                browserJavaScriptClickOnElementpropCount++;
            }
            else
            {
                browserJavaScriptClickOnElement["SearchElementMinimumHeight"] = 1;
                browserJavaScriptClickOnElementpropCount++;
            }

            if (browserJavaScriptClickOnElementsearchElementBoundingBoxLeft != null)
            {
                if (browserJavaScriptClickOnElementsearchElementBoundingBoxLeft != null)
                {
                    browserJavaScriptClickOnElement["SearchElementBoundingBoxLeft"] = CSharpExpressionConverter.ConvertToken(browserJavaScriptClickOnElementsearchElementBoundingBoxLeft);
                    browserJavaScriptClickOnElementpropCount++;
                }

                browserJavaScriptClickOnElementpropCount++;
            }
            else
            {
                browserJavaScriptClickOnElement["SearchElementBoundingBoxLeft"] = -99999;
                browserJavaScriptClickOnElementpropCount++;
            }

            if (browserJavaScriptClickOnElementsearchElementBoundingBoxRight != null)
            {
                if (browserJavaScriptClickOnElementsearchElementBoundingBoxRight != null)
                {
                    browserJavaScriptClickOnElement["SearchElementBoundingBoxRight"] = CSharpExpressionConverter.ConvertToken(browserJavaScriptClickOnElementsearchElementBoundingBoxRight);
                    browserJavaScriptClickOnElementpropCount++;
                }

                browserJavaScriptClickOnElementpropCount++;
            }
            else
            {
                browserJavaScriptClickOnElement["SearchElementBoundingBoxRight"] = 99999;
                browserJavaScriptClickOnElementpropCount++;
            }

            if (browserJavaScriptClickOnElementsearchElementBoundingBoxTop != null)
            {
                if (browserJavaScriptClickOnElementsearchElementBoundingBoxTop != null)
                {
                    browserJavaScriptClickOnElement["SearchElementBoundingBoxTop"] = CSharpExpressionConverter.ConvertToken(browserJavaScriptClickOnElementsearchElementBoundingBoxTop);
                    browserJavaScriptClickOnElementpropCount++;
                }

                browserJavaScriptClickOnElementpropCount++;
            }
            else
            {
                browserJavaScriptClickOnElement["SearchElementBoundingBoxTop"] = -99999;
                browserJavaScriptClickOnElementpropCount++;
            }

            if (browserJavaScriptClickOnElementsearchElementBoundingBoxBottom != null)
            {
                if (browserJavaScriptClickOnElementsearchElementBoundingBoxBottom != null)
                {
                    browserJavaScriptClickOnElement["SearchElementBoundingBoxBottom"] = CSharpExpressionConverter.ConvertToken(browserJavaScriptClickOnElementsearchElementBoundingBoxBottom);
                    browserJavaScriptClickOnElementpropCount++;
                }

                browserJavaScriptClickOnElementpropCount++;
            }
            else
            {
                browserJavaScriptClickOnElement["SearchElementBoundingBoxBottom"] = 99999;
                browserJavaScriptClickOnElementpropCount++;
            }

            if (browserJavaScriptClickOnElementonlyElementTopLeftNeedsToBeInBoundingBox != null)
            {
                if (browserJavaScriptClickOnElementonlyElementTopLeftNeedsToBeInBoundingBox != null)
                {
                    browserJavaScriptClickOnElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = CSharpExpressionConverter.ConvertToken(browserJavaScriptClickOnElementonlyElementTopLeftNeedsToBeInBoundingBox);
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
            browserJavaScriptClickOnElement["Workflow"] = CSharpExpressionConverter.ConvertToken(browserJavaScriptClickOnElementworkflow);
            if (browserJavaScriptClickOnElementpropCount > 0)
            {
                callPayload.Body = browserJavaScriptClickOnElement;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserExecuteJavaScriptOnElementResponse> BrowserExecuteJavaScriptOnElement(Expression<Func<string>> browserExecuteJavaScriptOnElementjavaScriptToExecute, Expression<Func<string>> browserExecuteJavaScriptOnElementworkflow, Expression<Func<double>> browserExecuteJavaScriptOnElementparentElementHandle = null, Expression<Func<double>> browserExecuteJavaScriptOnElementsearchElementHandle = null, Expression<Func<string>> browserExecuteJavaScriptOnElementsearchElementName = null, Expression<Func<string>> browserExecuteJavaScriptOnElementsearchElementID = null, Expression<Func<string>> browserExecuteJavaScriptOnElementsearchElementTagName = null, Expression<Func<string>> browserExecuteJavaScriptOnElementsearchElementXPath = null, Expression<Func<string>> browserExecuteJavaScriptOnElementsearchElementClassName = null, Expression<Func<string>> browserExecuteJavaScriptOnElementsearchElementCSSSelector = null, Expression<Func<double>> browserExecuteJavaScriptOnElementsearchElementIndex = null, Expression<Func<string>> browserExecuteJavaScriptOnElementsearchElementMatchValue = null, Expression<Func<string>> browserExecuteJavaScriptOnElementsearchElementMatchText = null, Expression<Func<string>> browserExecuteJavaScriptOnElementsearchElementType = null, Expression<Func<double>> browserExecuteJavaScriptOnElementsearchElementMinimumWidth = null, Expression<Func<double>> browserExecuteJavaScriptOnElementsearchElementMinimumHeight = null, Expression<Func<double>> browserExecuteJavaScriptOnElementsearchElementBoundingBoxLeft = null, Expression<Func<double>> browserExecuteJavaScriptOnElementsearchElementBoundingBoxRight = null, Expression<Func<double>> browserExecuteJavaScriptOnElementsearchElementBoundingBoxTop = null, Expression<Func<double>> browserExecuteJavaScriptOnElementsearchElementBoundingBoxBottom = null, Expression<Func<bool>> browserExecuteJavaScriptOnElementonlyElementTopLeftNeedsToBeInBoundingBox = null)
        {
            var apiCallPath = "/BrowserControl/ExecuteJavaScriptOnElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserExecuteJavaScriptOnElement = new JObject();
            var browserExecuteJavaScriptOnElementpropCount = 0;
            if (browserExecuteJavaScriptOnElementparentElementHandle != null)
            {
                browserExecuteJavaScriptOnElement["ParentElementHandle"] = CSharpExpressionConverter.ConvertToken(browserExecuteJavaScriptOnElementparentElementHandle);
                browserExecuteJavaScriptOnElementpropCount++;
            }

            if (browserExecuteJavaScriptOnElementsearchElementHandle != null)
            {
                browserExecuteJavaScriptOnElement["SearchElementHandle"] = CSharpExpressionConverter.ConvertToken(browserExecuteJavaScriptOnElementsearchElementHandle);
                browserExecuteJavaScriptOnElementpropCount++;
            }

            if (browserExecuteJavaScriptOnElementsearchElementName != null)
            {
                browserExecuteJavaScriptOnElement["SearchElementName"] = CSharpExpressionConverter.ConvertToken(browserExecuteJavaScriptOnElementsearchElementName);
                browserExecuteJavaScriptOnElementpropCount++;
            }

            if (browserExecuteJavaScriptOnElementsearchElementID != null)
            {
                browserExecuteJavaScriptOnElement["SearchElementID"] = CSharpExpressionConverter.ConvertToken(browserExecuteJavaScriptOnElementsearchElementID);
                browserExecuteJavaScriptOnElementpropCount++;
            }

            if (browserExecuteJavaScriptOnElementsearchElementTagName != null)
            {
                browserExecuteJavaScriptOnElement["SearchElementTagName"] = CSharpExpressionConverter.ConvertToken(browserExecuteJavaScriptOnElementsearchElementTagName);
                browserExecuteJavaScriptOnElementpropCount++;
            }

            if (browserExecuteJavaScriptOnElementsearchElementXPath != null)
            {
                browserExecuteJavaScriptOnElement["SearchElementXPath"] = CSharpExpressionConverter.ConvertToken(browserExecuteJavaScriptOnElementsearchElementXPath);
                browserExecuteJavaScriptOnElementpropCount++;
            }

            if (browserExecuteJavaScriptOnElementsearchElementClassName != null)
            {
                browserExecuteJavaScriptOnElement["SearchElementClassName"] = CSharpExpressionConverter.ConvertToken(browserExecuteJavaScriptOnElementsearchElementClassName);
                browserExecuteJavaScriptOnElementpropCount++;
            }

            if (browserExecuteJavaScriptOnElementsearchElementCSSSelector != null)
            {
                browserExecuteJavaScriptOnElement["SearchElementCSSSelector"] = CSharpExpressionConverter.ConvertToken(browserExecuteJavaScriptOnElementsearchElementCSSSelector);
                browserExecuteJavaScriptOnElementpropCount++;
            }

            if (browserExecuteJavaScriptOnElementsearchElementIndex != null)
            {
                if (browserExecuteJavaScriptOnElementsearchElementIndex != null)
                {
                    browserExecuteJavaScriptOnElement["SearchElementIndex"] = CSharpExpressionConverter.ConvertToken(browserExecuteJavaScriptOnElementsearchElementIndex);
                    browserExecuteJavaScriptOnElementpropCount++;
                }

                browserExecuteJavaScriptOnElementpropCount++;
            }
            else
            {
                browserExecuteJavaScriptOnElement["SearchElementIndex"] = 1;
                browserExecuteJavaScriptOnElementpropCount++;
            }

            if (browserExecuteJavaScriptOnElementsearchElementMatchValue != null)
            {
                browserExecuteJavaScriptOnElement["SearchElementMatchValue"] = CSharpExpressionConverter.ConvertToken(browserExecuteJavaScriptOnElementsearchElementMatchValue);
                browserExecuteJavaScriptOnElementpropCount++;
            }

            if (browserExecuteJavaScriptOnElementsearchElementMatchText != null)
            {
                browserExecuteJavaScriptOnElement["SearchElementMatchText"] = CSharpExpressionConverter.ConvertToken(browserExecuteJavaScriptOnElementsearchElementMatchText);
                browserExecuteJavaScriptOnElementpropCount++;
            }

            if (browserExecuteJavaScriptOnElementsearchElementType != null)
            {
                browserExecuteJavaScriptOnElement["SearchElementType"] = CSharpExpressionConverter.ConvertToken(browserExecuteJavaScriptOnElementsearchElementType);
                browserExecuteJavaScriptOnElementpropCount++;
            }

            if (browserExecuteJavaScriptOnElementsearchElementMinimumWidth != null)
            {
                if (browserExecuteJavaScriptOnElementsearchElementMinimumWidth != null)
                {
                    browserExecuteJavaScriptOnElement["SearchElementMinimumWidth"] = CSharpExpressionConverter.ConvertToken(browserExecuteJavaScriptOnElementsearchElementMinimumWidth);
                    browserExecuteJavaScriptOnElementpropCount++;
                }

                browserExecuteJavaScriptOnElementpropCount++;
            }
            else
            {
                browserExecuteJavaScriptOnElement["SearchElementMinimumWidth"] = 1;
                browserExecuteJavaScriptOnElementpropCount++;
            }

            if (browserExecuteJavaScriptOnElementsearchElementMinimumHeight != null)
            {
                if (browserExecuteJavaScriptOnElementsearchElementMinimumHeight != null)
                {
                    browserExecuteJavaScriptOnElement["SearchElementMinimumHeight"] = CSharpExpressionConverter.ConvertToken(browserExecuteJavaScriptOnElementsearchElementMinimumHeight);
                    browserExecuteJavaScriptOnElementpropCount++;
                }

                browserExecuteJavaScriptOnElementpropCount++;
            }
            else
            {
                browserExecuteJavaScriptOnElement["SearchElementMinimumHeight"] = 1;
                browserExecuteJavaScriptOnElementpropCount++;
            }

            if (browserExecuteJavaScriptOnElementsearchElementBoundingBoxLeft != null)
            {
                if (browserExecuteJavaScriptOnElementsearchElementBoundingBoxLeft != null)
                {
                    browserExecuteJavaScriptOnElement["SearchElementBoundingBoxLeft"] = CSharpExpressionConverter.ConvertToken(browserExecuteJavaScriptOnElementsearchElementBoundingBoxLeft);
                    browserExecuteJavaScriptOnElementpropCount++;
                }

                browserExecuteJavaScriptOnElementpropCount++;
            }
            else
            {
                browserExecuteJavaScriptOnElement["SearchElementBoundingBoxLeft"] = -99999;
                browserExecuteJavaScriptOnElementpropCount++;
            }

            if (browserExecuteJavaScriptOnElementsearchElementBoundingBoxRight != null)
            {
                if (browserExecuteJavaScriptOnElementsearchElementBoundingBoxRight != null)
                {
                    browserExecuteJavaScriptOnElement["SearchElementBoundingBoxRight"] = CSharpExpressionConverter.ConvertToken(browserExecuteJavaScriptOnElementsearchElementBoundingBoxRight);
                    browserExecuteJavaScriptOnElementpropCount++;
                }

                browserExecuteJavaScriptOnElementpropCount++;
            }
            else
            {
                browserExecuteJavaScriptOnElement["SearchElementBoundingBoxRight"] = 99999;
                browserExecuteJavaScriptOnElementpropCount++;
            }

            if (browserExecuteJavaScriptOnElementsearchElementBoundingBoxTop != null)
            {
                if (browserExecuteJavaScriptOnElementsearchElementBoundingBoxTop != null)
                {
                    browserExecuteJavaScriptOnElement["SearchElementBoundingBoxTop"] = CSharpExpressionConverter.ConvertToken(browserExecuteJavaScriptOnElementsearchElementBoundingBoxTop);
                    browserExecuteJavaScriptOnElementpropCount++;
                }

                browserExecuteJavaScriptOnElementpropCount++;
            }
            else
            {
                browserExecuteJavaScriptOnElement["SearchElementBoundingBoxTop"] = -99999;
                browserExecuteJavaScriptOnElementpropCount++;
            }

            if (browserExecuteJavaScriptOnElementsearchElementBoundingBoxBottom != null)
            {
                if (browserExecuteJavaScriptOnElementsearchElementBoundingBoxBottom != null)
                {
                    browserExecuteJavaScriptOnElement["SearchElementBoundingBoxBottom"] = CSharpExpressionConverter.ConvertToken(browserExecuteJavaScriptOnElementsearchElementBoundingBoxBottom);
                    browserExecuteJavaScriptOnElementpropCount++;
                }

                browserExecuteJavaScriptOnElementpropCount++;
            }
            else
            {
                browserExecuteJavaScriptOnElement["SearchElementBoundingBoxBottom"] = 99999;
                browserExecuteJavaScriptOnElementpropCount++;
            }

            if (browserExecuteJavaScriptOnElementonlyElementTopLeftNeedsToBeInBoundingBox != null)
            {
                if (browserExecuteJavaScriptOnElementonlyElementTopLeftNeedsToBeInBoundingBox != null)
                {
                    browserExecuteJavaScriptOnElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = CSharpExpressionConverter.ConvertToken(browserExecuteJavaScriptOnElementonlyElementTopLeftNeedsToBeInBoundingBox);
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
            browserExecuteJavaScriptOnElement["JavaScriptToExecute"] = CSharpExpressionConverter.ConvertToken(browserExecuteJavaScriptOnElementjavaScriptToExecute);
            browserExecuteJavaScriptOnElementpropCount++;
            browserExecuteJavaScriptOnElement["Workflow"] = CSharpExpressionConverter.ConvertToken(browserExecuteJavaScriptOnElementworkflow);
            if (browserExecuteJavaScriptOnElementpropCount > 0)
            {
                callPayload.Body = browserExecuteJavaScriptOnElement;
            }

            return new ApiConnectionAction<BrowserExecuteJavaScriptOnElementResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserGlobalMouseLeftClickOnElement(Expression<Func<string>> browserGlobalMouseLeftClickOnElementworkflow, Expression<Func<double>> browserGlobalMouseLeftClickOnElementparentElementHandle = null, Expression<Func<double>> browserGlobalMouseLeftClickOnElementsearchElementHandle = null, Expression<Func<string>> browserGlobalMouseLeftClickOnElementsearchElementName = null, Expression<Func<string>> browserGlobalMouseLeftClickOnElementsearchElementID = null, Expression<Func<string>> browserGlobalMouseLeftClickOnElementsearchElementTagName = null, Expression<Func<string>> browserGlobalMouseLeftClickOnElementsearchElementXPath = null, Expression<Func<string>> browserGlobalMouseLeftClickOnElementsearchElementClassName = null, Expression<Func<string>> browserGlobalMouseLeftClickOnElementsearchElementCSSSelector = null, Expression<Func<double>> browserGlobalMouseLeftClickOnElementsearchElementIndex = null, Expression<Func<string>> browserGlobalMouseLeftClickOnElementsearchElementMatchValue = null, Expression<Func<string>> browserGlobalMouseLeftClickOnElementsearchElementMatchText = null, Expression<Func<string>> browserGlobalMouseLeftClickOnElementsearchElementType = null, Expression<Func<double>> browserGlobalMouseLeftClickOnElementsearchElementMinimumWidth = null, Expression<Func<double>> browserGlobalMouseLeftClickOnElementsearchElementMinimumHeight = null, Expression<Func<double>> browserGlobalMouseLeftClickOnElementsearchElementBoundingBoxLeft = null, Expression<Func<double>> browserGlobalMouseLeftClickOnElementsearchElementBoundingBoxRight = null, Expression<Func<double>> browserGlobalMouseLeftClickOnElementsearchElementBoundingBoxTop = null, Expression<Func<double>> browserGlobalMouseLeftClickOnElementsearchElementBoundingBoxBottom = null, Expression<Func<bool>> browserGlobalMouseLeftClickOnElementonlyElementTopLeftNeedsToBeInBoundingBox = null, Expression<Func<int>> browserGlobalMouseLeftClickOnElementclickOffsetX = null, Expression<Func<int>> browserGlobalMouseLeftClickOnElementclickOffsetY = null, Expression<Func<bool>> browserGlobalMouseLeftClickOnElementfocusFirst = null)
        {
            var apiCallPath = "/BrowserControl/GlobalMouseLeftClickOnElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserGlobalMouseLeftClickOnElement = new JObject();
            var browserGlobalMouseLeftClickOnElementpropCount = 0;
            if (browserGlobalMouseLeftClickOnElementparentElementHandle != null)
            {
                browserGlobalMouseLeftClickOnElement["ParentElementHandle"] = CSharpExpressionConverter.ConvertToken(browserGlobalMouseLeftClickOnElementparentElementHandle);
                browserGlobalMouseLeftClickOnElementpropCount++;
            }

            if (browserGlobalMouseLeftClickOnElementsearchElementHandle != null)
            {
                browserGlobalMouseLeftClickOnElement["SearchElementHandle"] = CSharpExpressionConverter.ConvertToken(browserGlobalMouseLeftClickOnElementsearchElementHandle);
                browserGlobalMouseLeftClickOnElementpropCount++;
            }

            if (browserGlobalMouseLeftClickOnElementsearchElementName != null)
            {
                browserGlobalMouseLeftClickOnElement["SearchElementName"] = CSharpExpressionConverter.ConvertToken(browserGlobalMouseLeftClickOnElementsearchElementName);
                browserGlobalMouseLeftClickOnElementpropCount++;
            }

            if (browserGlobalMouseLeftClickOnElementsearchElementID != null)
            {
                browserGlobalMouseLeftClickOnElement["SearchElementID"] = CSharpExpressionConverter.ConvertToken(browserGlobalMouseLeftClickOnElementsearchElementID);
                browserGlobalMouseLeftClickOnElementpropCount++;
            }

            if (browserGlobalMouseLeftClickOnElementsearchElementTagName != null)
            {
                browserGlobalMouseLeftClickOnElement["SearchElementTagName"] = CSharpExpressionConverter.ConvertToken(browserGlobalMouseLeftClickOnElementsearchElementTagName);
                browserGlobalMouseLeftClickOnElementpropCount++;
            }

            if (browserGlobalMouseLeftClickOnElementsearchElementXPath != null)
            {
                browserGlobalMouseLeftClickOnElement["SearchElementXPath"] = CSharpExpressionConverter.ConvertToken(browserGlobalMouseLeftClickOnElementsearchElementXPath);
                browserGlobalMouseLeftClickOnElementpropCount++;
            }

            if (browserGlobalMouseLeftClickOnElementsearchElementClassName != null)
            {
                browserGlobalMouseLeftClickOnElement["SearchElementClassName"] = CSharpExpressionConverter.ConvertToken(browserGlobalMouseLeftClickOnElementsearchElementClassName);
                browserGlobalMouseLeftClickOnElementpropCount++;
            }

            if (browserGlobalMouseLeftClickOnElementsearchElementCSSSelector != null)
            {
                browserGlobalMouseLeftClickOnElement["SearchElementCSSSelector"] = CSharpExpressionConverter.ConvertToken(browserGlobalMouseLeftClickOnElementsearchElementCSSSelector);
                browserGlobalMouseLeftClickOnElementpropCount++;
            }

            if (browserGlobalMouseLeftClickOnElementsearchElementIndex != null)
            {
                if (browserGlobalMouseLeftClickOnElementsearchElementIndex != null)
                {
                    browserGlobalMouseLeftClickOnElement["SearchElementIndex"] = CSharpExpressionConverter.ConvertToken(browserGlobalMouseLeftClickOnElementsearchElementIndex);
                    browserGlobalMouseLeftClickOnElementpropCount++;
                }

                browserGlobalMouseLeftClickOnElementpropCount++;
            }
            else
            {
                browserGlobalMouseLeftClickOnElement["SearchElementIndex"] = 1;
                browserGlobalMouseLeftClickOnElementpropCount++;
            }

            if (browserGlobalMouseLeftClickOnElementsearchElementMatchValue != null)
            {
                browserGlobalMouseLeftClickOnElement["SearchElementMatchValue"] = CSharpExpressionConverter.ConvertToken(browserGlobalMouseLeftClickOnElementsearchElementMatchValue);
                browserGlobalMouseLeftClickOnElementpropCount++;
            }

            if (browserGlobalMouseLeftClickOnElementsearchElementMatchText != null)
            {
                browserGlobalMouseLeftClickOnElement["SearchElementMatchText"] = CSharpExpressionConverter.ConvertToken(browserGlobalMouseLeftClickOnElementsearchElementMatchText);
                browserGlobalMouseLeftClickOnElementpropCount++;
            }

            if (browserGlobalMouseLeftClickOnElementsearchElementType != null)
            {
                browserGlobalMouseLeftClickOnElement["SearchElementType"] = CSharpExpressionConverter.ConvertToken(browserGlobalMouseLeftClickOnElementsearchElementType);
                browserGlobalMouseLeftClickOnElementpropCount++;
            }

            if (browserGlobalMouseLeftClickOnElementsearchElementMinimumWidth != null)
            {
                if (browserGlobalMouseLeftClickOnElementsearchElementMinimumWidth != null)
                {
                    browserGlobalMouseLeftClickOnElement["SearchElementMinimumWidth"] = CSharpExpressionConverter.ConvertToken(browserGlobalMouseLeftClickOnElementsearchElementMinimumWidth);
                    browserGlobalMouseLeftClickOnElementpropCount++;
                }

                browserGlobalMouseLeftClickOnElementpropCount++;
            }
            else
            {
                browserGlobalMouseLeftClickOnElement["SearchElementMinimumWidth"] = 1;
                browserGlobalMouseLeftClickOnElementpropCount++;
            }

            if (browserGlobalMouseLeftClickOnElementsearchElementMinimumHeight != null)
            {
                if (browserGlobalMouseLeftClickOnElementsearchElementMinimumHeight != null)
                {
                    browserGlobalMouseLeftClickOnElement["SearchElementMinimumHeight"] = CSharpExpressionConverter.ConvertToken(browserGlobalMouseLeftClickOnElementsearchElementMinimumHeight);
                    browserGlobalMouseLeftClickOnElementpropCount++;
                }

                browserGlobalMouseLeftClickOnElementpropCount++;
            }
            else
            {
                browserGlobalMouseLeftClickOnElement["SearchElementMinimumHeight"] = 1;
                browserGlobalMouseLeftClickOnElementpropCount++;
            }

            if (browserGlobalMouseLeftClickOnElementsearchElementBoundingBoxLeft != null)
            {
                if (browserGlobalMouseLeftClickOnElementsearchElementBoundingBoxLeft != null)
                {
                    browserGlobalMouseLeftClickOnElement["SearchElementBoundingBoxLeft"] = CSharpExpressionConverter.ConvertToken(browserGlobalMouseLeftClickOnElementsearchElementBoundingBoxLeft);
                    browserGlobalMouseLeftClickOnElementpropCount++;
                }

                browserGlobalMouseLeftClickOnElementpropCount++;
            }
            else
            {
                browserGlobalMouseLeftClickOnElement["SearchElementBoundingBoxLeft"] = -99999;
                browserGlobalMouseLeftClickOnElementpropCount++;
            }

            if (browserGlobalMouseLeftClickOnElementsearchElementBoundingBoxRight != null)
            {
                if (browserGlobalMouseLeftClickOnElementsearchElementBoundingBoxRight != null)
                {
                    browserGlobalMouseLeftClickOnElement["SearchElementBoundingBoxRight"] = CSharpExpressionConverter.ConvertToken(browserGlobalMouseLeftClickOnElementsearchElementBoundingBoxRight);
                    browserGlobalMouseLeftClickOnElementpropCount++;
                }

                browserGlobalMouseLeftClickOnElementpropCount++;
            }
            else
            {
                browserGlobalMouseLeftClickOnElement["SearchElementBoundingBoxRight"] = 99999;
                browserGlobalMouseLeftClickOnElementpropCount++;
            }

            if (browserGlobalMouseLeftClickOnElementsearchElementBoundingBoxTop != null)
            {
                if (browserGlobalMouseLeftClickOnElementsearchElementBoundingBoxTop != null)
                {
                    browserGlobalMouseLeftClickOnElement["SearchElementBoundingBoxTop"] = CSharpExpressionConverter.ConvertToken(browserGlobalMouseLeftClickOnElementsearchElementBoundingBoxTop);
                    browserGlobalMouseLeftClickOnElementpropCount++;
                }

                browserGlobalMouseLeftClickOnElementpropCount++;
            }
            else
            {
                browserGlobalMouseLeftClickOnElement["SearchElementBoundingBoxTop"] = -99999;
                browserGlobalMouseLeftClickOnElementpropCount++;
            }

            if (browserGlobalMouseLeftClickOnElementsearchElementBoundingBoxBottom != null)
            {
                if (browserGlobalMouseLeftClickOnElementsearchElementBoundingBoxBottom != null)
                {
                    browserGlobalMouseLeftClickOnElement["SearchElementBoundingBoxBottom"] = CSharpExpressionConverter.ConvertToken(browserGlobalMouseLeftClickOnElementsearchElementBoundingBoxBottom);
                    browserGlobalMouseLeftClickOnElementpropCount++;
                }

                browserGlobalMouseLeftClickOnElementpropCount++;
            }
            else
            {
                browserGlobalMouseLeftClickOnElement["SearchElementBoundingBoxBottom"] = 99999;
                browserGlobalMouseLeftClickOnElementpropCount++;
            }

            if (browserGlobalMouseLeftClickOnElementonlyElementTopLeftNeedsToBeInBoundingBox != null)
            {
                if (browserGlobalMouseLeftClickOnElementonlyElementTopLeftNeedsToBeInBoundingBox != null)
                {
                    browserGlobalMouseLeftClickOnElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = CSharpExpressionConverter.ConvertToken(browserGlobalMouseLeftClickOnElementonlyElementTopLeftNeedsToBeInBoundingBox);
                    browserGlobalMouseLeftClickOnElementpropCount++;
                }

                browserGlobalMouseLeftClickOnElementpropCount++;
            }
            else
            {
                browserGlobalMouseLeftClickOnElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = false;
                browserGlobalMouseLeftClickOnElementpropCount++;
            }

            if (browserGlobalMouseLeftClickOnElementclickOffsetX != null)
            {
                browserGlobalMouseLeftClickOnElement["ClickOffsetX"] = CSharpExpressionConverter.ConvertToken(browserGlobalMouseLeftClickOnElementclickOffsetX);
                browserGlobalMouseLeftClickOnElementpropCount++;
            }

            if (browserGlobalMouseLeftClickOnElementclickOffsetY != null)
            {
                browserGlobalMouseLeftClickOnElement["ClickOffsetY"] = CSharpExpressionConverter.ConvertToken(browserGlobalMouseLeftClickOnElementclickOffsetY);
                browserGlobalMouseLeftClickOnElementpropCount++;
            }

            if (browserGlobalMouseLeftClickOnElementfocusFirst != null)
            {
                if (browserGlobalMouseLeftClickOnElementfocusFirst != null)
                {
                    browserGlobalMouseLeftClickOnElement["FocusFirst"] = CSharpExpressionConverter.ConvertToken(browserGlobalMouseLeftClickOnElementfocusFirst);
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
            browserGlobalMouseLeftClickOnElement["Workflow"] = CSharpExpressionConverter.ConvertToken(browserGlobalMouseLeftClickOnElementworkflow);
            if (browserGlobalMouseLeftClickOnElementpropCount > 0)
            {
                callPayload.Body = browserGlobalMouseLeftClickOnElement;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserGlobalMouseRightClickOnElement(Expression<Func<string>> browserGlobalMouseRightClickOnElementworkflow, Expression<Func<double>> browserGlobalMouseRightClickOnElementparentElementHandle = null, Expression<Func<double>> browserGlobalMouseRightClickOnElementsearchElementHandle = null, Expression<Func<string>> browserGlobalMouseRightClickOnElementsearchElementName = null, Expression<Func<string>> browserGlobalMouseRightClickOnElementsearchElementID = null, Expression<Func<string>> browserGlobalMouseRightClickOnElementsearchElementTagName = null, Expression<Func<string>> browserGlobalMouseRightClickOnElementsearchElementXPath = null, Expression<Func<string>> browserGlobalMouseRightClickOnElementsearchElementClassName = null, Expression<Func<string>> browserGlobalMouseRightClickOnElementsearchElementCSSSelector = null, Expression<Func<double>> browserGlobalMouseRightClickOnElementsearchElementIndex = null, Expression<Func<string>> browserGlobalMouseRightClickOnElementsearchElementMatchValue = null, Expression<Func<string>> browserGlobalMouseRightClickOnElementsearchElementMatchText = null, Expression<Func<string>> browserGlobalMouseRightClickOnElementsearchElementType = null, Expression<Func<double>> browserGlobalMouseRightClickOnElementsearchElementMinimumWidth = null, Expression<Func<double>> browserGlobalMouseRightClickOnElementsearchElementMinimumHeight = null, Expression<Func<double>> browserGlobalMouseRightClickOnElementsearchElementBoundingBoxLeft = null, Expression<Func<double>> browserGlobalMouseRightClickOnElementsearchElementBoundingBoxRight = null, Expression<Func<double>> browserGlobalMouseRightClickOnElementsearchElementBoundingBoxTop = null, Expression<Func<double>> browserGlobalMouseRightClickOnElementsearchElementBoundingBoxBottom = null, Expression<Func<bool>> browserGlobalMouseRightClickOnElementonlyElementTopLeftNeedsToBeInBoundingBox = null, Expression<Func<int>> browserGlobalMouseRightClickOnElementclickOffsetX = null, Expression<Func<int>> browserGlobalMouseRightClickOnElementclickOffsetY = null, Expression<Func<bool>> browserGlobalMouseRightClickOnElementfocusFirst = null)
        {
            var apiCallPath = "/BrowserControl/GlobalMouseRightClickOnElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserGlobalMouseRightClickOnElement = new JObject();
            var browserGlobalMouseRightClickOnElementpropCount = 0;
            if (browserGlobalMouseRightClickOnElementparentElementHandle != null)
            {
                browserGlobalMouseRightClickOnElement["ParentElementHandle"] = CSharpExpressionConverter.ConvertToken(browserGlobalMouseRightClickOnElementparentElementHandle);
                browserGlobalMouseRightClickOnElementpropCount++;
            }

            if (browserGlobalMouseRightClickOnElementsearchElementHandle != null)
            {
                browserGlobalMouseRightClickOnElement["SearchElementHandle"] = CSharpExpressionConverter.ConvertToken(browserGlobalMouseRightClickOnElementsearchElementHandle);
                browserGlobalMouseRightClickOnElementpropCount++;
            }

            if (browserGlobalMouseRightClickOnElementsearchElementName != null)
            {
                browserGlobalMouseRightClickOnElement["SearchElementName"] = CSharpExpressionConverter.ConvertToken(browserGlobalMouseRightClickOnElementsearchElementName);
                browserGlobalMouseRightClickOnElementpropCount++;
            }

            if (browserGlobalMouseRightClickOnElementsearchElementID != null)
            {
                browserGlobalMouseRightClickOnElement["SearchElementID"] = CSharpExpressionConverter.ConvertToken(browserGlobalMouseRightClickOnElementsearchElementID);
                browserGlobalMouseRightClickOnElementpropCount++;
            }

            if (browserGlobalMouseRightClickOnElementsearchElementTagName != null)
            {
                browserGlobalMouseRightClickOnElement["SearchElementTagName"] = CSharpExpressionConverter.ConvertToken(browserGlobalMouseRightClickOnElementsearchElementTagName);
                browserGlobalMouseRightClickOnElementpropCount++;
            }

            if (browserGlobalMouseRightClickOnElementsearchElementXPath != null)
            {
                browserGlobalMouseRightClickOnElement["SearchElementXPath"] = CSharpExpressionConverter.ConvertToken(browserGlobalMouseRightClickOnElementsearchElementXPath);
                browserGlobalMouseRightClickOnElementpropCount++;
            }

            if (browserGlobalMouseRightClickOnElementsearchElementClassName != null)
            {
                browserGlobalMouseRightClickOnElement["SearchElementClassName"] = CSharpExpressionConverter.ConvertToken(browserGlobalMouseRightClickOnElementsearchElementClassName);
                browserGlobalMouseRightClickOnElementpropCount++;
            }

            if (browserGlobalMouseRightClickOnElementsearchElementCSSSelector != null)
            {
                browserGlobalMouseRightClickOnElement["SearchElementCSSSelector"] = CSharpExpressionConverter.ConvertToken(browserGlobalMouseRightClickOnElementsearchElementCSSSelector);
                browserGlobalMouseRightClickOnElementpropCount++;
            }

            if (browserGlobalMouseRightClickOnElementsearchElementIndex != null)
            {
                if (browserGlobalMouseRightClickOnElementsearchElementIndex != null)
                {
                    browserGlobalMouseRightClickOnElement["SearchElementIndex"] = CSharpExpressionConverter.ConvertToken(browserGlobalMouseRightClickOnElementsearchElementIndex);
                    browserGlobalMouseRightClickOnElementpropCount++;
                }

                browserGlobalMouseRightClickOnElementpropCount++;
            }
            else
            {
                browserGlobalMouseRightClickOnElement["SearchElementIndex"] = 1;
                browserGlobalMouseRightClickOnElementpropCount++;
            }

            if (browserGlobalMouseRightClickOnElementsearchElementMatchValue != null)
            {
                browserGlobalMouseRightClickOnElement["SearchElementMatchValue"] = CSharpExpressionConverter.ConvertToken(browserGlobalMouseRightClickOnElementsearchElementMatchValue);
                browserGlobalMouseRightClickOnElementpropCount++;
            }

            if (browserGlobalMouseRightClickOnElementsearchElementMatchText != null)
            {
                browserGlobalMouseRightClickOnElement["SearchElementMatchText"] = CSharpExpressionConverter.ConvertToken(browserGlobalMouseRightClickOnElementsearchElementMatchText);
                browserGlobalMouseRightClickOnElementpropCount++;
            }

            if (browserGlobalMouseRightClickOnElementsearchElementType != null)
            {
                browserGlobalMouseRightClickOnElement["SearchElementType"] = CSharpExpressionConverter.ConvertToken(browserGlobalMouseRightClickOnElementsearchElementType);
                browserGlobalMouseRightClickOnElementpropCount++;
            }

            if (browserGlobalMouseRightClickOnElementsearchElementMinimumWidth != null)
            {
                if (browserGlobalMouseRightClickOnElementsearchElementMinimumWidth != null)
                {
                    browserGlobalMouseRightClickOnElement["SearchElementMinimumWidth"] = CSharpExpressionConverter.ConvertToken(browserGlobalMouseRightClickOnElementsearchElementMinimumWidth);
                    browserGlobalMouseRightClickOnElementpropCount++;
                }

                browserGlobalMouseRightClickOnElementpropCount++;
            }
            else
            {
                browserGlobalMouseRightClickOnElement["SearchElementMinimumWidth"] = 1;
                browserGlobalMouseRightClickOnElementpropCount++;
            }

            if (browserGlobalMouseRightClickOnElementsearchElementMinimumHeight != null)
            {
                if (browserGlobalMouseRightClickOnElementsearchElementMinimumHeight != null)
                {
                    browserGlobalMouseRightClickOnElement["SearchElementMinimumHeight"] = CSharpExpressionConverter.ConvertToken(browserGlobalMouseRightClickOnElementsearchElementMinimumHeight);
                    browserGlobalMouseRightClickOnElementpropCount++;
                }

                browserGlobalMouseRightClickOnElementpropCount++;
            }
            else
            {
                browserGlobalMouseRightClickOnElement["SearchElementMinimumHeight"] = 1;
                browserGlobalMouseRightClickOnElementpropCount++;
            }

            if (browserGlobalMouseRightClickOnElementsearchElementBoundingBoxLeft != null)
            {
                if (browserGlobalMouseRightClickOnElementsearchElementBoundingBoxLeft != null)
                {
                    browserGlobalMouseRightClickOnElement["SearchElementBoundingBoxLeft"] = CSharpExpressionConverter.ConvertToken(browserGlobalMouseRightClickOnElementsearchElementBoundingBoxLeft);
                    browserGlobalMouseRightClickOnElementpropCount++;
                }

                browserGlobalMouseRightClickOnElementpropCount++;
            }
            else
            {
                browserGlobalMouseRightClickOnElement["SearchElementBoundingBoxLeft"] = -99999;
                browserGlobalMouseRightClickOnElementpropCount++;
            }

            if (browserGlobalMouseRightClickOnElementsearchElementBoundingBoxRight != null)
            {
                if (browserGlobalMouseRightClickOnElementsearchElementBoundingBoxRight != null)
                {
                    browserGlobalMouseRightClickOnElement["SearchElementBoundingBoxRight"] = CSharpExpressionConverter.ConvertToken(browserGlobalMouseRightClickOnElementsearchElementBoundingBoxRight);
                    browserGlobalMouseRightClickOnElementpropCount++;
                }

                browserGlobalMouseRightClickOnElementpropCount++;
            }
            else
            {
                browserGlobalMouseRightClickOnElement["SearchElementBoundingBoxRight"] = 99999;
                browserGlobalMouseRightClickOnElementpropCount++;
            }

            if (browserGlobalMouseRightClickOnElementsearchElementBoundingBoxTop != null)
            {
                if (browserGlobalMouseRightClickOnElementsearchElementBoundingBoxTop != null)
                {
                    browserGlobalMouseRightClickOnElement["SearchElementBoundingBoxTop"] = CSharpExpressionConverter.ConvertToken(browserGlobalMouseRightClickOnElementsearchElementBoundingBoxTop);
                    browserGlobalMouseRightClickOnElementpropCount++;
                }

                browserGlobalMouseRightClickOnElementpropCount++;
            }
            else
            {
                browserGlobalMouseRightClickOnElement["SearchElementBoundingBoxTop"] = -99999;
                browserGlobalMouseRightClickOnElementpropCount++;
            }

            if (browserGlobalMouseRightClickOnElementsearchElementBoundingBoxBottom != null)
            {
                if (browserGlobalMouseRightClickOnElementsearchElementBoundingBoxBottom != null)
                {
                    browserGlobalMouseRightClickOnElement["SearchElementBoundingBoxBottom"] = CSharpExpressionConverter.ConvertToken(browserGlobalMouseRightClickOnElementsearchElementBoundingBoxBottom);
                    browserGlobalMouseRightClickOnElementpropCount++;
                }

                browserGlobalMouseRightClickOnElementpropCount++;
            }
            else
            {
                browserGlobalMouseRightClickOnElement["SearchElementBoundingBoxBottom"] = 99999;
                browserGlobalMouseRightClickOnElementpropCount++;
            }

            if (browserGlobalMouseRightClickOnElementonlyElementTopLeftNeedsToBeInBoundingBox != null)
            {
                if (browserGlobalMouseRightClickOnElementonlyElementTopLeftNeedsToBeInBoundingBox != null)
                {
                    browserGlobalMouseRightClickOnElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = CSharpExpressionConverter.ConvertToken(browserGlobalMouseRightClickOnElementonlyElementTopLeftNeedsToBeInBoundingBox);
                    browserGlobalMouseRightClickOnElementpropCount++;
                }

                browserGlobalMouseRightClickOnElementpropCount++;
            }
            else
            {
                browserGlobalMouseRightClickOnElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = false;
                browserGlobalMouseRightClickOnElementpropCount++;
            }

            if (browserGlobalMouseRightClickOnElementclickOffsetX != null)
            {
                browserGlobalMouseRightClickOnElement["ClickOffsetX"] = CSharpExpressionConverter.ConvertToken(browserGlobalMouseRightClickOnElementclickOffsetX);
                browserGlobalMouseRightClickOnElementpropCount++;
            }

            if (browserGlobalMouseRightClickOnElementclickOffsetY != null)
            {
                browserGlobalMouseRightClickOnElement["ClickOffsetY"] = CSharpExpressionConverter.ConvertToken(browserGlobalMouseRightClickOnElementclickOffsetY);
                browserGlobalMouseRightClickOnElementpropCount++;
            }

            if (browserGlobalMouseRightClickOnElementfocusFirst != null)
            {
                if (browserGlobalMouseRightClickOnElementfocusFirst != null)
                {
                    browserGlobalMouseRightClickOnElement["FocusFirst"] = CSharpExpressionConverter.ConvertToken(browserGlobalMouseRightClickOnElementfocusFirst);
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
            browserGlobalMouseRightClickOnElement["Workflow"] = CSharpExpressionConverter.ConvertToken(browserGlobalMouseRightClickOnElementworkflow);
            if (browserGlobalMouseRightClickOnElementpropCount > 0)
            {
                callPayload.Body = browserGlobalMouseRightClickOnElement;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserOpenNewTabResponse> BrowserOpenNewTab(Expression<Func<string>> browserOpenNewTabworkflow, Expression<Func<string>> browserOpenNewTabuRL = null, Expression<Func<bool>> browserOpenNewTabswitchControlToNewTab = null)
        {
            var apiCallPath = "/BrowserControl/OpenNewTab";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserOpenNewTab = new JObject();
            var browserOpenNewTabpropCount = 0;
            if (browserOpenNewTabuRL != null)
            {
                browserOpenNewTab["URL"] = CSharpExpressionConverter.ConvertToken(browserOpenNewTabuRL);
                browserOpenNewTabpropCount++;
            }

            if (browserOpenNewTabswitchControlToNewTab != null)
            {
                if (browserOpenNewTabswitchControlToNewTab != null)
                {
                    browserOpenNewTab["SwitchControlToNewTab"] = CSharpExpressionConverter.ConvertToken(browserOpenNewTabswitchControlToNewTab);
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
            browserOpenNewTab["Workflow"] = CSharpExpressionConverter.ConvertToken(browserOpenNewTabworkflow);
            if (browserOpenNewTabpropCount > 0)
            {
                callPayload.Body = browserOpenNewTab;
            }

            return new ApiConnectionAction<BrowserOpenNewTabResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserGetTabsResponse> BrowserGetTabs(Expression<Func<string>> browserGetTabsworkflow)
        {
            var apiCallPath = "/BrowserControl/GetTabs";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserGetTabs = new JObject();
            var browserGetTabspropCount = 0;
            browserGetTabspropCount++;
            browserGetTabs["Workflow"] = CSharpExpressionConverter.ConvertToken(browserGetTabsworkflow);
            if (browserGetTabspropCount > 0)
            {
                callPayload.Body = browserGetTabs;
            }

            return new ApiConnectionAction<BrowserGetTabsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserSetTab(Expression<Func<string>> browserSetTabworkflow, Expression<Func<string>> browserSetTabtabName = null, Expression<Func<int>> browserSetTabtabIndex = null)
        {
            var apiCallPath = "/BrowserControl/SetTab";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserSetTab = new JObject();
            var browserSetTabpropCount = 0;
            if (browserSetTabtabName != null)
            {
                browserSetTab["TabName"] = CSharpExpressionConverter.ConvertToken(browserSetTabtabName);
                browserSetTabpropCount++;
            }

            if (browserSetTabtabIndex != null)
            {
                browserSetTab["TabIndex"] = CSharpExpressionConverter.ConvertToken(browserSetTabtabIndex);
                browserSetTabpropCount++;
            }

            browserSetTabpropCount++;
            browserSetTab["Workflow"] = CSharpExpressionConverter.ConvertToken(browserSetTabworkflow);
            if (browserSetTabpropCount > 0)
            {
                callPayload.Body = browserSetTab;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserCloseActiveTab(Expression<Func<string>> browserCloseActiveTabworkflow)
        {
            var apiCallPath = "/BrowserControl/CloseActiveTab";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserCloseActiveTab = new JObject();
            var browserCloseActiveTabpropCount = 0;
            browserCloseActiveTabpropCount++;
            browserCloseActiveTab["Workflow"] = CSharpExpressionConverter.ConvertToken(browserCloseActiveTabworkflow);
            if (browserCloseActiveTabpropCount > 0)
            {
                callPayload.Body = browserCloseActiveTab;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserSavePageToFile(Expression<Func<string>> browserSavePageToFilesaveFilename, Expression<Func<string>> browserSavePageToFileworkflow)
        {
            var apiCallPath = "/BrowserControl/SavePageToFile";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserSavePageToFile = new JObject();
            var browserSavePageToFilepropCount = 0;
            browserSavePageToFilepropCount++;
            browserSavePageToFile["SaveFilename"] = CSharpExpressionConverter.ConvertToken(browserSavePageToFilesaveFilename);
            browserSavePageToFilepropCount++;
            browserSavePageToFile["Workflow"] = CSharpExpressionConverter.ConvertToken(browserSavePageToFileworkflow);
            if (browserSavePageToFilepropCount > 0)
            {
                callPayload.Body = browserSavePageToFile;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserGetPageTextResponse> BrowserGetPageText(Expression<Func<string>> browserGetPageTextworkflow)
        {
            var apiCallPath = "/BrowserControl/GetPageText";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserGetPageText = new JObject();
            var browserGetPageTextpropCount = 0;
            browserGetPageTextpropCount++;
            browserGetPageText["Workflow"] = CSharpExpressionConverter.ConvertToken(browserGetPageTextworkflow);
            if (browserGetPageTextpropCount > 0)
            {
                callPayload.Body = browserGetPageText;
            }

            return new ApiConnectionAction<BrowserGetPageTextResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserSwitchToFrameElement(Expression<Func<string>> browserSwitchToFrameElementworkflow, Expression<Func<double>> browserSwitchToFrameElementparentElementHandle = null, Expression<Func<double>> browserSwitchToFrameElementsearchElementHandle = null, Expression<Func<string>> browserSwitchToFrameElementsearchElementName = null, Expression<Func<string>> browserSwitchToFrameElementsearchElementID = null, Expression<Func<string>> browserSwitchToFrameElementsearchElementTagName = null, Expression<Func<string>> browserSwitchToFrameElementsearchElementXPath = null, Expression<Func<string>> browserSwitchToFrameElementsearchElementClassName = null, Expression<Func<string>> browserSwitchToFrameElementsearchElementCSSSelector = null, Expression<Func<double>> browserSwitchToFrameElementsearchElementIndex = null, Expression<Func<string>> browserSwitchToFrameElementsearchElementMatchValue = null, Expression<Func<string>> browserSwitchToFrameElementsearchElementMatchText = null, Expression<Func<string>> browserSwitchToFrameElementsearchElementType = null, Expression<Func<double>> browserSwitchToFrameElementsearchElementMinimumWidth = null, Expression<Func<double>> browserSwitchToFrameElementsearchElementMinimumHeight = null, Expression<Func<double>> browserSwitchToFrameElementsearchElementBoundingBoxLeft = null, Expression<Func<double>> browserSwitchToFrameElementsearchElementBoundingBoxRight = null, Expression<Func<double>> browserSwitchToFrameElementsearchElementBoundingBoxTop = null, Expression<Func<double>> browserSwitchToFrameElementsearchElementBoundingBoxBottom = null, Expression<Func<bool>> browserSwitchToFrameElementonlyElementTopLeftNeedsToBeInBoundingBox = null)
        {
            var apiCallPath = "/BrowserControl/SwitchToFrameElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserSwitchToFrameElement = new JObject();
            var browserSwitchToFrameElementpropCount = 0;
            if (browserSwitchToFrameElementparentElementHandle != null)
            {
                browserSwitchToFrameElement["ParentElementHandle"] = CSharpExpressionConverter.ConvertToken(browserSwitchToFrameElementparentElementHandle);
                browserSwitchToFrameElementpropCount++;
            }

            if (browserSwitchToFrameElementsearchElementHandle != null)
            {
                browserSwitchToFrameElement["SearchElementHandle"] = CSharpExpressionConverter.ConvertToken(browserSwitchToFrameElementsearchElementHandle);
                browserSwitchToFrameElementpropCount++;
            }

            if (browserSwitchToFrameElementsearchElementName != null)
            {
                browserSwitchToFrameElement["SearchElementName"] = CSharpExpressionConverter.ConvertToken(browserSwitchToFrameElementsearchElementName);
                browserSwitchToFrameElementpropCount++;
            }

            if (browserSwitchToFrameElementsearchElementID != null)
            {
                browserSwitchToFrameElement["SearchElementID"] = CSharpExpressionConverter.ConvertToken(browserSwitchToFrameElementsearchElementID);
                browserSwitchToFrameElementpropCount++;
            }

            if (browserSwitchToFrameElementsearchElementTagName != null)
            {
                browserSwitchToFrameElement["SearchElementTagName"] = CSharpExpressionConverter.ConvertToken(browserSwitchToFrameElementsearchElementTagName);
                browserSwitchToFrameElementpropCount++;
            }

            if (browserSwitchToFrameElementsearchElementXPath != null)
            {
                browserSwitchToFrameElement["SearchElementXPath"] = CSharpExpressionConverter.ConvertToken(browserSwitchToFrameElementsearchElementXPath);
                browserSwitchToFrameElementpropCount++;
            }

            if (browserSwitchToFrameElementsearchElementClassName != null)
            {
                browserSwitchToFrameElement["SearchElementClassName"] = CSharpExpressionConverter.ConvertToken(browserSwitchToFrameElementsearchElementClassName);
                browserSwitchToFrameElementpropCount++;
            }

            if (browserSwitchToFrameElementsearchElementCSSSelector != null)
            {
                browserSwitchToFrameElement["SearchElementCSSSelector"] = CSharpExpressionConverter.ConvertToken(browserSwitchToFrameElementsearchElementCSSSelector);
                browserSwitchToFrameElementpropCount++;
            }

            if (browserSwitchToFrameElementsearchElementIndex != null)
            {
                if (browserSwitchToFrameElementsearchElementIndex != null)
                {
                    browserSwitchToFrameElement["SearchElementIndex"] = CSharpExpressionConverter.ConvertToken(browserSwitchToFrameElementsearchElementIndex);
                    browserSwitchToFrameElementpropCount++;
                }

                browserSwitchToFrameElementpropCount++;
            }
            else
            {
                browserSwitchToFrameElement["SearchElementIndex"] = 1;
                browserSwitchToFrameElementpropCount++;
            }

            if (browserSwitchToFrameElementsearchElementMatchValue != null)
            {
                browserSwitchToFrameElement["SearchElementMatchValue"] = CSharpExpressionConverter.ConvertToken(browserSwitchToFrameElementsearchElementMatchValue);
                browserSwitchToFrameElementpropCount++;
            }

            if (browserSwitchToFrameElementsearchElementMatchText != null)
            {
                browserSwitchToFrameElement["SearchElementMatchText"] = CSharpExpressionConverter.ConvertToken(browserSwitchToFrameElementsearchElementMatchText);
                browserSwitchToFrameElementpropCount++;
            }

            if (browserSwitchToFrameElementsearchElementType != null)
            {
                browserSwitchToFrameElement["SearchElementType"] = CSharpExpressionConverter.ConvertToken(browserSwitchToFrameElementsearchElementType);
                browserSwitchToFrameElementpropCount++;
            }

            if (browserSwitchToFrameElementsearchElementMinimumWidth != null)
            {
                if (browserSwitchToFrameElementsearchElementMinimumWidth != null)
                {
                    browserSwitchToFrameElement["SearchElementMinimumWidth"] = CSharpExpressionConverter.ConvertToken(browserSwitchToFrameElementsearchElementMinimumWidth);
                    browserSwitchToFrameElementpropCount++;
                }

                browserSwitchToFrameElementpropCount++;
            }
            else
            {
                browserSwitchToFrameElement["SearchElementMinimumWidth"] = 1;
                browserSwitchToFrameElementpropCount++;
            }

            if (browserSwitchToFrameElementsearchElementMinimumHeight != null)
            {
                if (browserSwitchToFrameElementsearchElementMinimumHeight != null)
                {
                    browserSwitchToFrameElement["SearchElementMinimumHeight"] = CSharpExpressionConverter.ConvertToken(browserSwitchToFrameElementsearchElementMinimumHeight);
                    browserSwitchToFrameElementpropCount++;
                }

                browserSwitchToFrameElementpropCount++;
            }
            else
            {
                browserSwitchToFrameElement["SearchElementMinimumHeight"] = 1;
                browserSwitchToFrameElementpropCount++;
            }

            if (browserSwitchToFrameElementsearchElementBoundingBoxLeft != null)
            {
                if (browserSwitchToFrameElementsearchElementBoundingBoxLeft != null)
                {
                    browserSwitchToFrameElement["SearchElementBoundingBoxLeft"] = CSharpExpressionConverter.ConvertToken(browserSwitchToFrameElementsearchElementBoundingBoxLeft);
                    browserSwitchToFrameElementpropCount++;
                }

                browserSwitchToFrameElementpropCount++;
            }
            else
            {
                browserSwitchToFrameElement["SearchElementBoundingBoxLeft"] = -99999;
                browserSwitchToFrameElementpropCount++;
            }

            if (browserSwitchToFrameElementsearchElementBoundingBoxRight != null)
            {
                if (browserSwitchToFrameElementsearchElementBoundingBoxRight != null)
                {
                    browserSwitchToFrameElement["SearchElementBoundingBoxRight"] = CSharpExpressionConverter.ConvertToken(browserSwitchToFrameElementsearchElementBoundingBoxRight);
                    browserSwitchToFrameElementpropCount++;
                }

                browserSwitchToFrameElementpropCount++;
            }
            else
            {
                browserSwitchToFrameElement["SearchElementBoundingBoxRight"] = 99999;
                browserSwitchToFrameElementpropCount++;
            }

            if (browserSwitchToFrameElementsearchElementBoundingBoxTop != null)
            {
                if (browserSwitchToFrameElementsearchElementBoundingBoxTop != null)
                {
                    browserSwitchToFrameElement["SearchElementBoundingBoxTop"] = CSharpExpressionConverter.ConvertToken(browserSwitchToFrameElementsearchElementBoundingBoxTop);
                    browserSwitchToFrameElementpropCount++;
                }

                browserSwitchToFrameElementpropCount++;
            }
            else
            {
                browserSwitchToFrameElement["SearchElementBoundingBoxTop"] = -99999;
                browserSwitchToFrameElementpropCount++;
            }

            if (browserSwitchToFrameElementsearchElementBoundingBoxBottom != null)
            {
                if (browserSwitchToFrameElementsearchElementBoundingBoxBottom != null)
                {
                    browserSwitchToFrameElement["SearchElementBoundingBoxBottom"] = CSharpExpressionConverter.ConvertToken(browserSwitchToFrameElementsearchElementBoundingBoxBottom);
                    browserSwitchToFrameElementpropCount++;
                }

                browserSwitchToFrameElementpropCount++;
            }
            else
            {
                browserSwitchToFrameElement["SearchElementBoundingBoxBottom"] = 99999;
                browserSwitchToFrameElementpropCount++;
            }

            if (browserSwitchToFrameElementonlyElementTopLeftNeedsToBeInBoundingBox != null)
            {
                if (browserSwitchToFrameElementonlyElementTopLeftNeedsToBeInBoundingBox != null)
                {
                    browserSwitchToFrameElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = CSharpExpressionConverter.ConvertToken(browserSwitchToFrameElementonlyElementTopLeftNeedsToBeInBoundingBox);
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
            browserSwitchToFrameElement["Workflow"] = CSharpExpressionConverter.ConvertToken(browserSwitchToFrameElementworkflow);
            if (browserSwitchToFrameElementpropCount > 0)
            {
                callPayload.Body = browserSwitchToFrameElement;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserGetCurrentFrameWindowPixelCoordinateResponse> BrowserGetCurrentFrameWindowPixelCoordinate(Expression<Func<string>> browserGetCurrentFrameWindowPixelCoordinateworkflow)
        {
            var apiCallPath = "/BrowserControl/GetCurrentFrameWindowPixelCoordinate";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserGetCurrentFrameWindowPixelCoordinate = new JObject();
            var browserGetCurrentFrameWindowPixelCoordinatepropCount = 0;
            browserGetCurrentFrameWindowPixelCoordinatepropCount++;
            browserGetCurrentFrameWindowPixelCoordinate["Workflow"] = CSharpExpressionConverter.ConvertToken(browserGetCurrentFrameWindowPixelCoordinateworkflow);
            if (browserGetCurrentFrameWindowPixelCoordinatepropCount > 0)
            {
                callPayload.Body = browserGetCurrentFrameWindowPixelCoordinate;
            }

            return new ApiConnectionAction<BrowserGetCurrentFrameWindowPixelCoordinateResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserSwitchToParentFrameElement(Expression<Func<string>> browserSwitchToParentFrameElementworkflow)
        {
            var apiCallPath = "/BrowserControl/SwitchToParentFrameElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserSwitchToParentFrameElement = new JObject();
            var browserSwitchToParentFrameElementpropCount = 0;
            browserSwitchToParentFrameElementpropCount++;
            browserSwitchToParentFrameElement["Workflow"] = CSharpExpressionConverter.ConvertToken(browserSwitchToParentFrameElementworkflow);
            if (browserSwitchToParentFrameElementpropCount > 0)
            {
                callPayload.Body = browserSwitchToParentFrameElement;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserSwitchToRootFrameElement(Expression<Func<string>> browserSwitchToRootFrameElementworkflow)
        {
            var apiCallPath = "/BrowserControl/SwitchToRootFrameElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserSwitchToRootFrameElement = new JObject();
            var browserSwitchToRootFrameElementpropCount = 0;
            browserSwitchToRootFrameElementpropCount++;
            browserSwitchToRootFrameElement["Workflow"] = CSharpExpressionConverter.ConvertToken(browserSwitchToRootFrameElementworkflow);
            if (browserSwitchToRootFrameElementpropCount > 0)
            {
                callPayload.Body = browserSwitchToRootFrameElement;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserResetFrameStack(Expression<Func<string>> browserResetFrameStackworkflow)
        {
            var apiCallPath = "/BrowserControl/ResetFrameStack";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserResetFrameStack = new JObject();
            var browserResetFrameStackpropCount = 0;
            browserResetFrameStackpropCount++;
            browserResetFrameStack["Workflow"] = CSharpExpressionConverter.ConvertToken(browserResetFrameStackworkflow);
            if (browserResetFrameStackpropCount > 0)
            {
                callPayload.Body = browserResetFrameStack;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserClearElementTextResponse> BrowserClearElementText(Expression<Func<string>> browserClearElementTextworkflow, Expression<Func<double>> browserClearElementTextparentElementHandle = null, Expression<Func<double>> browserClearElementTextsearchElementHandle = null, Expression<Func<string>> browserClearElementTextsearchElementName = null, Expression<Func<string>> browserClearElementTextsearchElementID = null, Expression<Func<string>> browserClearElementTextsearchElementTagName = null, Expression<Func<string>> browserClearElementTextsearchElementXPath = null, Expression<Func<string>> browserClearElementTextsearchElementClassName = null, Expression<Func<string>> browserClearElementTextsearchElementCSSSelector = null, Expression<Func<double>> browserClearElementTextsearchElementIndex = null, Expression<Func<string>> browserClearElementTextsearchElementMatchValue = null, Expression<Func<string>> browserClearElementTextsearchElementMatchText = null, Expression<Func<string>> browserClearElementTextsearchElementType = null, Expression<Func<double>> browserClearElementTextsearchElementMinimumWidth = null, Expression<Func<double>> browserClearElementTextsearchElementMinimumHeight = null, Expression<Func<double>> browserClearElementTextsearchElementBoundingBoxLeft = null, Expression<Func<double>> browserClearElementTextsearchElementBoundingBoxRight = null, Expression<Func<double>> browserClearElementTextsearchElementBoundingBoxTop = null, Expression<Func<double>> browserClearElementTextsearchElementBoundingBoxBottom = null, Expression<Func<bool>> browserClearElementTextonlyElementTopLeftNeedsToBeInBoundingBox = null)
        {
            var apiCallPath = "/BrowserControl/ClearElementText";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserClearElementText = new JObject();
            var browserClearElementTextpropCount = 0;
            if (browserClearElementTextparentElementHandle != null)
            {
                browserClearElementText["ParentElementHandle"] = CSharpExpressionConverter.ConvertToken(browserClearElementTextparentElementHandle);
                browserClearElementTextpropCount++;
            }

            if (browserClearElementTextsearchElementHandle != null)
            {
                browserClearElementText["SearchElementHandle"] = CSharpExpressionConverter.ConvertToken(browserClearElementTextsearchElementHandle);
                browserClearElementTextpropCount++;
            }

            if (browserClearElementTextsearchElementName != null)
            {
                browserClearElementText["SearchElementName"] = CSharpExpressionConverter.ConvertToken(browserClearElementTextsearchElementName);
                browserClearElementTextpropCount++;
            }

            if (browserClearElementTextsearchElementID != null)
            {
                browserClearElementText["SearchElementID"] = CSharpExpressionConverter.ConvertToken(browserClearElementTextsearchElementID);
                browserClearElementTextpropCount++;
            }

            if (browserClearElementTextsearchElementTagName != null)
            {
                browserClearElementText["SearchElementTagName"] = CSharpExpressionConverter.ConvertToken(browserClearElementTextsearchElementTagName);
                browserClearElementTextpropCount++;
            }

            if (browserClearElementTextsearchElementXPath != null)
            {
                browserClearElementText["SearchElementXPath"] = CSharpExpressionConverter.ConvertToken(browserClearElementTextsearchElementXPath);
                browserClearElementTextpropCount++;
            }

            if (browserClearElementTextsearchElementClassName != null)
            {
                browserClearElementText["SearchElementClassName"] = CSharpExpressionConverter.ConvertToken(browserClearElementTextsearchElementClassName);
                browserClearElementTextpropCount++;
            }

            if (browserClearElementTextsearchElementCSSSelector != null)
            {
                browserClearElementText["SearchElementCSSSelector"] = CSharpExpressionConverter.ConvertToken(browserClearElementTextsearchElementCSSSelector);
                browserClearElementTextpropCount++;
            }

            if (browserClearElementTextsearchElementIndex != null)
            {
                if (browserClearElementTextsearchElementIndex != null)
                {
                    browserClearElementText["SearchElementIndex"] = CSharpExpressionConverter.ConvertToken(browserClearElementTextsearchElementIndex);
                    browserClearElementTextpropCount++;
                }

                browserClearElementTextpropCount++;
            }
            else
            {
                browserClearElementText["SearchElementIndex"] = 1;
                browserClearElementTextpropCount++;
            }

            if (browserClearElementTextsearchElementMatchValue != null)
            {
                browserClearElementText["SearchElementMatchValue"] = CSharpExpressionConverter.ConvertToken(browserClearElementTextsearchElementMatchValue);
                browserClearElementTextpropCount++;
            }

            if (browserClearElementTextsearchElementMatchText != null)
            {
                browserClearElementText["SearchElementMatchText"] = CSharpExpressionConverter.ConvertToken(browserClearElementTextsearchElementMatchText);
                browserClearElementTextpropCount++;
            }

            if (browserClearElementTextsearchElementType != null)
            {
                browserClearElementText["SearchElementType"] = CSharpExpressionConverter.ConvertToken(browserClearElementTextsearchElementType);
                browserClearElementTextpropCount++;
            }

            if (browserClearElementTextsearchElementMinimumWidth != null)
            {
                if (browserClearElementTextsearchElementMinimumWidth != null)
                {
                    browserClearElementText["SearchElementMinimumWidth"] = CSharpExpressionConverter.ConvertToken(browserClearElementTextsearchElementMinimumWidth);
                    browserClearElementTextpropCount++;
                }

                browserClearElementTextpropCount++;
            }
            else
            {
                browserClearElementText["SearchElementMinimumWidth"] = 1;
                browserClearElementTextpropCount++;
            }

            if (browserClearElementTextsearchElementMinimumHeight != null)
            {
                if (browserClearElementTextsearchElementMinimumHeight != null)
                {
                    browserClearElementText["SearchElementMinimumHeight"] = CSharpExpressionConverter.ConvertToken(browserClearElementTextsearchElementMinimumHeight);
                    browserClearElementTextpropCount++;
                }

                browserClearElementTextpropCount++;
            }
            else
            {
                browserClearElementText["SearchElementMinimumHeight"] = 1;
                browserClearElementTextpropCount++;
            }

            if (browserClearElementTextsearchElementBoundingBoxLeft != null)
            {
                if (browserClearElementTextsearchElementBoundingBoxLeft != null)
                {
                    browserClearElementText["SearchElementBoundingBoxLeft"] = CSharpExpressionConverter.ConvertToken(browserClearElementTextsearchElementBoundingBoxLeft);
                    browserClearElementTextpropCount++;
                }

                browserClearElementTextpropCount++;
            }
            else
            {
                browserClearElementText["SearchElementBoundingBoxLeft"] = -99999;
                browserClearElementTextpropCount++;
            }

            if (browserClearElementTextsearchElementBoundingBoxRight != null)
            {
                if (browserClearElementTextsearchElementBoundingBoxRight != null)
                {
                    browserClearElementText["SearchElementBoundingBoxRight"] = CSharpExpressionConverter.ConvertToken(browserClearElementTextsearchElementBoundingBoxRight);
                    browserClearElementTextpropCount++;
                }

                browserClearElementTextpropCount++;
            }
            else
            {
                browserClearElementText["SearchElementBoundingBoxRight"] = 99999;
                browserClearElementTextpropCount++;
            }

            if (browserClearElementTextsearchElementBoundingBoxTop != null)
            {
                if (browserClearElementTextsearchElementBoundingBoxTop != null)
                {
                    browserClearElementText["SearchElementBoundingBoxTop"] = CSharpExpressionConverter.ConvertToken(browserClearElementTextsearchElementBoundingBoxTop);
                    browserClearElementTextpropCount++;
                }

                browserClearElementTextpropCount++;
            }
            else
            {
                browserClearElementText["SearchElementBoundingBoxTop"] = -99999;
                browserClearElementTextpropCount++;
            }

            if (browserClearElementTextsearchElementBoundingBoxBottom != null)
            {
                if (browserClearElementTextsearchElementBoundingBoxBottom != null)
                {
                    browserClearElementText["SearchElementBoundingBoxBottom"] = CSharpExpressionConverter.ConvertToken(browserClearElementTextsearchElementBoundingBoxBottom);
                    browserClearElementTextpropCount++;
                }

                browserClearElementTextpropCount++;
            }
            else
            {
                browserClearElementText["SearchElementBoundingBoxBottom"] = 99999;
                browserClearElementTextpropCount++;
            }

            if (browserClearElementTextonlyElementTopLeftNeedsToBeInBoundingBox != null)
            {
                if (browserClearElementTextonlyElementTopLeftNeedsToBeInBoundingBox != null)
                {
                    browserClearElementText["OnlyElementTopLeftNeedsToBeInBoundingBox"] = CSharpExpressionConverter.ConvertToken(browserClearElementTextonlyElementTopLeftNeedsToBeInBoundingBox);
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
            browserClearElementText["Workflow"] = CSharpExpressionConverter.ConvertToken(browserClearElementTextworkflow);
            if (browserClearElementTextpropCount > 0)
            {
                callPayload.Body = browserClearElementText;
            }

            return new ApiConnectionAction<BrowserClearElementTextResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserCopySelectedTextOnElement(Expression<Func<string>> browserCopySelectedTextOnElementworkflow, Expression<Func<double>> browserCopySelectedTextOnElementparentElementHandle = null, Expression<Func<double>> browserCopySelectedTextOnElementsearchElementHandle = null, Expression<Func<string>> browserCopySelectedTextOnElementsearchElementName = null, Expression<Func<string>> browserCopySelectedTextOnElementsearchElementID = null, Expression<Func<string>> browserCopySelectedTextOnElementsearchElementTagName = null, Expression<Func<string>> browserCopySelectedTextOnElementsearchElementXPath = null, Expression<Func<string>> browserCopySelectedTextOnElementsearchElementClassName = null, Expression<Func<string>> browserCopySelectedTextOnElementsearchElementCSSSelector = null, Expression<Func<double>> browserCopySelectedTextOnElementsearchElementIndex = null, Expression<Func<string>> browserCopySelectedTextOnElementsearchElementMatchValue = null, Expression<Func<string>> browserCopySelectedTextOnElementsearchElementMatchText = null, Expression<Func<string>> browserCopySelectedTextOnElementsearchElementType = null, Expression<Func<double>> browserCopySelectedTextOnElementsearchElementMinimumWidth = null, Expression<Func<double>> browserCopySelectedTextOnElementsearchElementMinimumHeight = null, Expression<Func<double>> browserCopySelectedTextOnElementsearchElementBoundingBoxLeft = null, Expression<Func<double>> browserCopySelectedTextOnElementsearchElementBoundingBoxRight = null, Expression<Func<double>> browserCopySelectedTextOnElementsearchElementBoundingBoxTop = null, Expression<Func<double>> browserCopySelectedTextOnElementsearchElementBoundingBoxBottom = null, Expression<Func<bool>> browserCopySelectedTextOnElementonlyElementTopLeftNeedsToBeInBoundingBox = null)
        {
            var apiCallPath = "/BrowserControl/CopySelectedTextOnElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserCopySelectedTextOnElement = new JObject();
            var browserCopySelectedTextOnElementpropCount = 0;
            if (browserCopySelectedTextOnElementparentElementHandle != null)
            {
                browserCopySelectedTextOnElement["ParentElementHandle"] = CSharpExpressionConverter.ConvertToken(browserCopySelectedTextOnElementparentElementHandle);
                browserCopySelectedTextOnElementpropCount++;
            }

            if (browserCopySelectedTextOnElementsearchElementHandle != null)
            {
                browserCopySelectedTextOnElement["SearchElementHandle"] = CSharpExpressionConverter.ConvertToken(browserCopySelectedTextOnElementsearchElementHandle);
                browserCopySelectedTextOnElementpropCount++;
            }

            if (browserCopySelectedTextOnElementsearchElementName != null)
            {
                browserCopySelectedTextOnElement["SearchElementName"] = CSharpExpressionConverter.ConvertToken(browserCopySelectedTextOnElementsearchElementName);
                browserCopySelectedTextOnElementpropCount++;
            }

            if (browserCopySelectedTextOnElementsearchElementID != null)
            {
                browserCopySelectedTextOnElement["SearchElementID"] = CSharpExpressionConverter.ConvertToken(browserCopySelectedTextOnElementsearchElementID);
                browserCopySelectedTextOnElementpropCount++;
            }

            if (browserCopySelectedTextOnElementsearchElementTagName != null)
            {
                browserCopySelectedTextOnElement["SearchElementTagName"] = CSharpExpressionConverter.ConvertToken(browserCopySelectedTextOnElementsearchElementTagName);
                browserCopySelectedTextOnElementpropCount++;
            }

            if (browserCopySelectedTextOnElementsearchElementXPath != null)
            {
                browserCopySelectedTextOnElement["SearchElementXPath"] = CSharpExpressionConverter.ConvertToken(browserCopySelectedTextOnElementsearchElementXPath);
                browserCopySelectedTextOnElementpropCount++;
            }

            if (browserCopySelectedTextOnElementsearchElementClassName != null)
            {
                browserCopySelectedTextOnElement["SearchElementClassName"] = CSharpExpressionConverter.ConvertToken(browserCopySelectedTextOnElementsearchElementClassName);
                browserCopySelectedTextOnElementpropCount++;
            }

            if (browserCopySelectedTextOnElementsearchElementCSSSelector != null)
            {
                browserCopySelectedTextOnElement["SearchElementCSSSelector"] = CSharpExpressionConverter.ConvertToken(browserCopySelectedTextOnElementsearchElementCSSSelector);
                browserCopySelectedTextOnElementpropCount++;
            }

            if (browserCopySelectedTextOnElementsearchElementIndex != null)
            {
                if (browserCopySelectedTextOnElementsearchElementIndex != null)
                {
                    browserCopySelectedTextOnElement["SearchElementIndex"] = CSharpExpressionConverter.ConvertToken(browserCopySelectedTextOnElementsearchElementIndex);
                    browserCopySelectedTextOnElementpropCount++;
                }

                browserCopySelectedTextOnElementpropCount++;
            }
            else
            {
                browserCopySelectedTextOnElement["SearchElementIndex"] = 1;
                browserCopySelectedTextOnElementpropCount++;
            }

            if (browserCopySelectedTextOnElementsearchElementMatchValue != null)
            {
                browserCopySelectedTextOnElement["SearchElementMatchValue"] = CSharpExpressionConverter.ConvertToken(browserCopySelectedTextOnElementsearchElementMatchValue);
                browserCopySelectedTextOnElementpropCount++;
            }

            if (browserCopySelectedTextOnElementsearchElementMatchText != null)
            {
                browserCopySelectedTextOnElement["SearchElementMatchText"] = CSharpExpressionConverter.ConvertToken(browserCopySelectedTextOnElementsearchElementMatchText);
                browserCopySelectedTextOnElementpropCount++;
            }

            if (browserCopySelectedTextOnElementsearchElementType != null)
            {
                browserCopySelectedTextOnElement["SearchElementType"] = CSharpExpressionConverter.ConvertToken(browserCopySelectedTextOnElementsearchElementType);
                browserCopySelectedTextOnElementpropCount++;
            }

            if (browserCopySelectedTextOnElementsearchElementMinimumWidth != null)
            {
                if (browserCopySelectedTextOnElementsearchElementMinimumWidth != null)
                {
                    browserCopySelectedTextOnElement["SearchElementMinimumWidth"] = CSharpExpressionConverter.ConvertToken(browserCopySelectedTextOnElementsearchElementMinimumWidth);
                    browserCopySelectedTextOnElementpropCount++;
                }

                browserCopySelectedTextOnElementpropCount++;
            }
            else
            {
                browserCopySelectedTextOnElement["SearchElementMinimumWidth"] = 1;
                browserCopySelectedTextOnElementpropCount++;
            }

            if (browserCopySelectedTextOnElementsearchElementMinimumHeight != null)
            {
                if (browserCopySelectedTextOnElementsearchElementMinimumHeight != null)
                {
                    browserCopySelectedTextOnElement["SearchElementMinimumHeight"] = CSharpExpressionConverter.ConvertToken(browserCopySelectedTextOnElementsearchElementMinimumHeight);
                    browserCopySelectedTextOnElementpropCount++;
                }

                browserCopySelectedTextOnElementpropCount++;
            }
            else
            {
                browserCopySelectedTextOnElement["SearchElementMinimumHeight"] = 1;
                browserCopySelectedTextOnElementpropCount++;
            }

            if (browserCopySelectedTextOnElementsearchElementBoundingBoxLeft != null)
            {
                if (browserCopySelectedTextOnElementsearchElementBoundingBoxLeft != null)
                {
                    browserCopySelectedTextOnElement["SearchElementBoundingBoxLeft"] = CSharpExpressionConverter.ConvertToken(browserCopySelectedTextOnElementsearchElementBoundingBoxLeft);
                    browserCopySelectedTextOnElementpropCount++;
                }

                browserCopySelectedTextOnElementpropCount++;
            }
            else
            {
                browserCopySelectedTextOnElement["SearchElementBoundingBoxLeft"] = -99999;
                browserCopySelectedTextOnElementpropCount++;
            }

            if (browserCopySelectedTextOnElementsearchElementBoundingBoxRight != null)
            {
                if (browserCopySelectedTextOnElementsearchElementBoundingBoxRight != null)
                {
                    browserCopySelectedTextOnElement["SearchElementBoundingBoxRight"] = CSharpExpressionConverter.ConvertToken(browserCopySelectedTextOnElementsearchElementBoundingBoxRight);
                    browserCopySelectedTextOnElementpropCount++;
                }

                browserCopySelectedTextOnElementpropCount++;
            }
            else
            {
                browserCopySelectedTextOnElement["SearchElementBoundingBoxRight"] = 99999;
                browserCopySelectedTextOnElementpropCount++;
            }

            if (browserCopySelectedTextOnElementsearchElementBoundingBoxTop != null)
            {
                if (browserCopySelectedTextOnElementsearchElementBoundingBoxTop != null)
                {
                    browserCopySelectedTextOnElement["SearchElementBoundingBoxTop"] = CSharpExpressionConverter.ConvertToken(browserCopySelectedTextOnElementsearchElementBoundingBoxTop);
                    browserCopySelectedTextOnElementpropCount++;
                }

                browserCopySelectedTextOnElementpropCount++;
            }
            else
            {
                browserCopySelectedTextOnElement["SearchElementBoundingBoxTop"] = -99999;
                browserCopySelectedTextOnElementpropCount++;
            }

            if (browserCopySelectedTextOnElementsearchElementBoundingBoxBottom != null)
            {
                if (browserCopySelectedTextOnElementsearchElementBoundingBoxBottom != null)
                {
                    browserCopySelectedTextOnElement["SearchElementBoundingBoxBottom"] = CSharpExpressionConverter.ConvertToken(browserCopySelectedTextOnElementsearchElementBoundingBoxBottom);
                    browserCopySelectedTextOnElementpropCount++;
                }

                browserCopySelectedTextOnElementpropCount++;
            }
            else
            {
                browserCopySelectedTextOnElement["SearchElementBoundingBoxBottom"] = 99999;
                browserCopySelectedTextOnElementpropCount++;
            }

            if (browserCopySelectedTextOnElementonlyElementTopLeftNeedsToBeInBoundingBox != null)
            {
                if (browserCopySelectedTextOnElementonlyElementTopLeftNeedsToBeInBoundingBox != null)
                {
                    browserCopySelectedTextOnElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = CSharpExpressionConverter.ConvertToken(browserCopySelectedTextOnElementonlyElementTopLeftNeedsToBeInBoundingBox);
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
            browserCopySelectedTextOnElement["Workflow"] = CSharpExpressionConverter.ConvertToken(browserCopySelectedTextOnElementworkflow);
            if (browserCopySelectedTextOnElementpropCount > 0)
            {
                callPayload.Body = browserCopySelectedTextOnElement;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserInputPasswordIntoElement(Expression<Func<string>> browserInputPasswordIntoElementpasswordToInput, Expression<Func<string>> browserInputPasswordIntoElementworkflow, Expression<Func<double>> browserInputPasswordIntoElementparentElementHandle = null, Expression<Func<double>> browserInputPasswordIntoElementsearchElementHandle = null, Expression<Func<string>> browserInputPasswordIntoElementsearchElementName = null, Expression<Func<string>> browserInputPasswordIntoElementsearchElementID = null, Expression<Func<string>> browserInputPasswordIntoElementsearchElementTagName = null, Expression<Func<string>> browserInputPasswordIntoElementsearchElementXPath = null, Expression<Func<string>> browserInputPasswordIntoElementsearchElementClassName = null, Expression<Func<string>> browserInputPasswordIntoElementsearchElementCSSSelector = null, Expression<Func<double>> browserInputPasswordIntoElementsearchElementIndex = null, Expression<Func<string>> browserInputPasswordIntoElementsearchElementMatchValue = null, Expression<Func<string>> browserInputPasswordIntoElementsearchElementMatchText = null, Expression<Func<string>> browserInputPasswordIntoElementsearchElementType = null, Expression<Func<double>> browserInputPasswordIntoElementsearchElementMinimumWidth = null, Expression<Func<double>> browserInputPasswordIntoElementsearchElementMinimumHeight = null, Expression<Func<double>> browserInputPasswordIntoElementsearchElementBoundingBoxLeft = null, Expression<Func<double>> browserInputPasswordIntoElementsearchElementBoundingBoxRight = null, Expression<Func<double>> browserInputPasswordIntoElementsearchElementBoundingBoxTop = null, Expression<Func<double>> browserInputPasswordIntoElementsearchElementBoundingBoxBottom = null, Expression<Func<bool>> browserInputPasswordIntoElementonlyElementTopLeftNeedsToBeInBoundingBox = null, Expression<Func<bool>> browserInputPasswordIntoElementresetExistingValue = null, Expression<Func<bool>> browserInputPasswordIntoElementpasswordContainsStoredPassword = null)
        {
            var apiCallPath = "/BrowserControl/InputPasswordIntoElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserInputPasswordIntoElement = new JObject();
            var browserInputPasswordIntoElementpropCount = 0;
            if (browserInputPasswordIntoElementparentElementHandle != null)
            {
                browserInputPasswordIntoElement["ParentElementHandle"] = CSharpExpressionConverter.ConvertToken(browserInputPasswordIntoElementparentElementHandle);
                browserInputPasswordIntoElementpropCount++;
            }

            if (browserInputPasswordIntoElementsearchElementHandle != null)
            {
                browserInputPasswordIntoElement["SearchElementHandle"] = CSharpExpressionConverter.ConvertToken(browserInputPasswordIntoElementsearchElementHandle);
                browserInputPasswordIntoElementpropCount++;
            }

            if (browserInputPasswordIntoElementsearchElementName != null)
            {
                browserInputPasswordIntoElement["SearchElementName"] = CSharpExpressionConverter.ConvertToken(browserInputPasswordIntoElementsearchElementName);
                browserInputPasswordIntoElementpropCount++;
            }

            if (browserInputPasswordIntoElementsearchElementID != null)
            {
                browserInputPasswordIntoElement["SearchElementID"] = CSharpExpressionConverter.ConvertToken(browserInputPasswordIntoElementsearchElementID);
                browserInputPasswordIntoElementpropCount++;
            }

            if (browserInputPasswordIntoElementsearchElementTagName != null)
            {
                browserInputPasswordIntoElement["SearchElementTagName"] = CSharpExpressionConverter.ConvertToken(browserInputPasswordIntoElementsearchElementTagName);
                browserInputPasswordIntoElementpropCount++;
            }

            if (browserInputPasswordIntoElementsearchElementXPath != null)
            {
                browserInputPasswordIntoElement["SearchElementXPath"] = CSharpExpressionConverter.ConvertToken(browserInputPasswordIntoElementsearchElementXPath);
                browserInputPasswordIntoElementpropCount++;
            }

            if (browserInputPasswordIntoElementsearchElementClassName != null)
            {
                browserInputPasswordIntoElement["SearchElementClassName"] = CSharpExpressionConverter.ConvertToken(browserInputPasswordIntoElementsearchElementClassName);
                browserInputPasswordIntoElementpropCount++;
            }

            if (browserInputPasswordIntoElementsearchElementCSSSelector != null)
            {
                browserInputPasswordIntoElement["SearchElementCSSSelector"] = CSharpExpressionConverter.ConvertToken(browserInputPasswordIntoElementsearchElementCSSSelector);
                browserInputPasswordIntoElementpropCount++;
            }

            if (browserInputPasswordIntoElementsearchElementIndex != null)
            {
                if (browserInputPasswordIntoElementsearchElementIndex != null)
                {
                    browserInputPasswordIntoElement["SearchElementIndex"] = CSharpExpressionConverter.ConvertToken(browserInputPasswordIntoElementsearchElementIndex);
                    browserInputPasswordIntoElementpropCount++;
                }

                browserInputPasswordIntoElementpropCount++;
            }
            else
            {
                browserInputPasswordIntoElement["SearchElementIndex"] = 1;
                browserInputPasswordIntoElementpropCount++;
            }

            if (browserInputPasswordIntoElementsearchElementMatchValue != null)
            {
                browserInputPasswordIntoElement["SearchElementMatchValue"] = CSharpExpressionConverter.ConvertToken(browserInputPasswordIntoElementsearchElementMatchValue);
                browserInputPasswordIntoElementpropCount++;
            }

            if (browserInputPasswordIntoElementsearchElementMatchText != null)
            {
                browserInputPasswordIntoElement["SearchElementMatchText"] = CSharpExpressionConverter.ConvertToken(browserInputPasswordIntoElementsearchElementMatchText);
                browserInputPasswordIntoElementpropCount++;
            }

            if (browserInputPasswordIntoElementsearchElementType != null)
            {
                browserInputPasswordIntoElement["SearchElementType"] = CSharpExpressionConverter.ConvertToken(browserInputPasswordIntoElementsearchElementType);
                browserInputPasswordIntoElementpropCount++;
            }

            if (browserInputPasswordIntoElementsearchElementMinimumWidth != null)
            {
                if (browserInputPasswordIntoElementsearchElementMinimumWidth != null)
                {
                    browserInputPasswordIntoElement["SearchElementMinimumWidth"] = CSharpExpressionConverter.ConvertToken(browserInputPasswordIntoElementsearchElementMinimumWidth);
                    browserInputPasswordIntoElementpropCount++;
                }

                browserInputPasswordIntoElementpropCount++;
            }
            else
            {
                browserInputPasswordIntoElement["SearchElementMinimumWidth"] = 1;
                browserInputPasswordIntoElementpropCount++;
            }

            if (browserInputPasswordIntoElementsearchElementMinimumHeight != null)
            {
                if (browserInputPasswordIntoElementsearchElementMinimumHeight != null)
                {
                    browserInputPasswordIntoElement["SearchElementMinimumHeight"] = CSharpExpressionConverter.ConvertToken(browserInputPasswordIntoElementsearchElementMinimumHeight);
                    browserInputPasswordIntoElementpropCount++;
                }

                browserInputPasswordIntoElementpropCount++;
            }
            else
            {
                browserInputPasswordIntoElement["SearchElementMinimumHeight"] = 1;
                browserInputPasswordIntoElementpropCount++;
            }

            if (browserInputPasswordIntoElementsearchElementBoundingBoxLeft != null)
            {
                if (browserInputPasswordIntoElementsearchElementBoundingBoxLeft != null)
                {
                    browserInputPasswordIntoElement["SearchElementBoundingBoxLeft"] = CSharpExpressionConverter.ConvertToken(browserInputPasswordIntoElementsearchElementBoundingBoxLeft);
                    browserInputPasswordIntoElementpropCount++;
                }

                browserInputPasswordIntoElementpropCount++;
            }
            else
            {
                browserInputPasswordIntoElement["SearchElementBoundingBoxLeft"] = -99999;
                browserInputPasswordIntoElementpropCount++;
            }

            if (browserInputPasswordIntoElementsearchElementBoundingBoxRight != null)
            {
                if (browserInputPasswordIntoElementsearchElementBoundingBoxRight != null)
                {
                    browserInputPasswordIntoElement["SearchElementBoundingBoxRight"] = CSharpExpressionConverter.ConvertToken(browserInputPasswordIntoElementsearchElementBoundingBoxRight);
                    browserInputPasswordIntoElementpropCount++;
                }

                browserInputPasswordIntoElementpropCount++;
            }
            else
            {
                browserInputPasswordIntoElement["SearchElementBoundingBoxRight"] = 99999;
                browserInputPasswordIntoElementpropCount++;
            }

            if (browserInputPasswordIntoElementsearchElementBoundingBoxTop != null)
            {
                if (browserInputPasswordIntoElementsearchElementBoundingBoxTop != null)
                {
                    browserInputPasswordIntoElement["SearchElementBoundingBoxTop"] = CSharpExpressionConverter.ConvertToken(browserInputPasswordIntoElementsearchElementBoundingBoxTop);
                    browserInputPasswordIntoElementpropCount++;
                }

                browserInputPasswordIntoElementpropCount++;
            }
            else
            {
                browserInputPasswordIntoElement["SearchElementBoundingBoxTop"] = -99999;
                browserInputPasswordIntoElementpropCount++;
            }

            if (browserInputPasswordIntoElementsearchElementBoundingBoxBottom != null)
            {
                if (browserInputPasswordIntoElementsearchElementBoundingBoxBottom != null)
                {
                    browserInputPasswordIntoElement["SearchElementBoundingBoxBottom"] = CSharpExpressionConverter.ConvertToken(browserInputPasswordIntoElementsearchElementBoundingBoxBottom);
                    browserInputPasswordIntoElementpropCount++;
                }

                browserInputPasswordIntoElementpropCount++;
            }
            else
            {
                browserInputPasswordIntoElement["SearchElementBoundingBoxBottom"] = 99999;
                browserInputPasswordIntoElementpropCount++;
            }

            if (browserInputPasswordIntoElementonlyElementTopLeftNeedsToBeInBoundingBox != null)
            {
                if (browserInputPasswordIntoElementonlyElementTopLeftNeedsToBeInBoundingBox != null)
                {
                    browserInputPasswordIntoElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = CSharpExpressionConverter.ConvertToken(browserInputPasswordIntoElementonlyElementTopLeftNeedsToBeInBoundingBox);
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
            browserInputPasswordIntoElement["PasswordToInput"] = CSharpExpressionConverter.ConvertToken(browserInputPasswordIntoElementpasswordToInput);
            if (browserInputPasswordIntoElementresetExistingValue != null)
            {
                if (browserInputPasswordIntoElementresetExistingValue != null)
                {
                    browserInputPasswordIntoElement["ResetExistingValue"] = CSharpExpressionConverter.ConvertToken(browserInputPasswordIntoElementresetExistingValue);
                    browserInputPasswordIntoElementpropCount++;
                }

                browserInputPasswordIntoElementpropCount++;
            }
            else
            {
                browserInputPasswordIntoElement["ResetExistingValue"] = true;
                browserInputPasswordIntoElementpropCount++;
            }

            if (browserInputPasswordIntoElementpasswordContainsStoredPassword != null)
            {
                if (browserInputPasswordIntoElementpasswordContainsStoredPassword != null)
                {
                    browserInputPasswordIntoElement["PasswordContainsStoredPassword"] = CSharpExpressionConverter.ConvertToken(browserInputPasswordIntoElementpasswordContainsStoredPassword);
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
            browserInputPasswordIntoElement["Workflow"] = CSharpExpressionConverter.ConvertToken(browserInputPasswordIntoElementworkflow);
            if (browserInputPasswordIntoElementpropCount > 0)
            {
                callPayload.Body = browserInputPasswordIntoElement;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserPasteIntoElement(Expression<Func<string>> browserPasteIntoElementworkflow, Expression<Func<double>> browserPasteIntoElementparentElementHandle = null, Expression<Func<double>> browserPasteIntoElementsearchElementHandle = null, Expression<Func<string>> browserPasteIntoElementsearchElementName = null, Expression<Func<string>> browserPasteIntoElementsearchElementID = null, Expression<Func<string>> browserPasteIntoElementsearchElementTagName = null, Expression<Func<string>> browserPasteIntoElementsearchElementXPath = null, Expression<Func<string>> browserPasteIntoElementsearchElementClassName = null, Expression<Func<string>> browserPasteIntoElementsearchElementCSSSelector = null, Expression<Func<double>> browserPasteIntoElementsearchElementIndex = null, Expression<Func<string>> browserPasteIntoElementsearchElementMatchValue = null, Expression<Func<string>> browserPasteIntoElementsearchElementMatchText = null, Expression<Func<string>> browserPasteIntoElementsearchElementType = null, Expression<Func<double>> browserPasteIntoElementsearchElementMinimumWidth = null, Expression<Func<double>> browserPasteIntoElementsearchElementMinimumHeight = null, Expression<Func<double>> browserPasteIntoElementsearchElementBoundingBoxLeft = null, Expression<Func<double>> browserPasteIntoElementsearchElementBoundingBoxRight = null, Expression<Func<double>> browserPasteIntoElementsearchElementBoundingBoxTop = null, Expression<Func<double>> browserPasteIntoElementsearchElementBoundingBoxBottom = null, Expression<Func<bool>> browserPasteIntoElementonlyElementTopLeftNeedsToBeInBoundingBox = null)
        {
            var apiCallPath = "/BrowserControl/PasteIntoElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserPasteIntoElement = new JObject();
            var browserPasteIntoElementpropCount = 0;
            if (browserPasteIntoElementparentElementHandle != null)
            {
                browserPasteIntoElement["ParentElementHandle"] = CSharpExpressionConverter.ConvertToken(browserPasteIntoElementparentElementHandle);
                browserPasteIntoElementpropCount++;
            }

            if (browserPasteIntoElementsearchElementHandle != null)
            {
                browserPasteIntoElement["SearchElementHandle"] = CSharpExpressionConverter.ConvertToken(browserPasteIntoElementsearchElementHandle);
                browserPasteIntoElementpropCount++;
            }

            if (browserPasteIntoElementsearchElementName != null)
            {
                browserPasteIntoElement["SearchElementName"] = CSharpExpressionConverter.ConvertToken(browserPasteIntoElementsearchElementName);
                browserPasteIntoElementpropCount++;
            }

            if (browserPasteIntoElementsearchElementID != null)
            {
                browserPasteIntoElement["SearchElementID"] = CSharpExpressionConverter.ConvertToken(browserPasteIntoElementsearchElementID);
                browserPasteIntoElementpropCount++;
            }

            if (browserPasteIntoElementsearchElementTagName != null)
            {
                browserPasteIntoElement["SearchElementTagName"] = CSharpExpressionConverter.ConvertToken(browserPasteIntoElementsearchElementTagName);
                browserPasteIntoElementpropCount++;
            }

            if (browserPasteIntoElementsearchElementXPath != null)
            {
                browserPasteIntoElement["SearchElementXPath"] = CSharpExpressionConverter.ConvertToken(browserPasteIntoElementsearchElementXPath);
                browserPasteIntoElementpropCount++;
            }

            if (browserPasteIntoElementsearchElementClassName != null)
            {
                browserPasteIntoElement["SearchElementClassName"] = CSharpExpressionConverter.ConvertToken(browserPasteIntoElementsearchElementClassName);
                browserPasteIntoElementpropCount++;
            }

            if (browserPasteIntoElementsearchElementCSSSelector != null)
            {
                browserPasteIntoElement["SearchElementCSSSelector"] = CSharpExpressionConverter.ConvertToken(browserPasteIntoElementsearchElementCSSSelector);
                browserPasteIntoElementpropCount++;
            }

            if (browserPasteIntoElementsearchElementIndex != null)
            {
                if (browserPasteIntoElementsearchElementIndex != null)
                {
                    browserPasteIntoElement["SearchElementIndex"] = CSharpExpressionConverter.ConvertToken(browserPasteIntoElementsearchElementIndex);
                    browserPasteIntoElementpropCount++;
                }

                browserPasteIntoElementpropCount++;
            }
            else
            {
                browserPasteIntoElement["SearchElementIndex"] = 1;
                browserPasteIntoElementpropCount++;
            }

            if (browserPasteIntoElementsearchElementMatchValue != null)
            {
                browserPasteIntoElement["SearchElementMatchValue"] = CSharpExpressionConverter.ConvertToken(browserPasteIntoElementsearchElementMatchValue);
                browserPasteIntoElementpropCount++;
            }

            if (browserPasteIntoElementsearchElementMatchText != null)
            {
                browserPasteIntoElement["SearchElementMatchText"] = CSharpExpressionConverter.ConvertToken(browserPasteIntoElementsearchElementMatchText);
                browserPasteIntoElementpropCount++;
            }

            if (browserPasteIntoElementsearchElementType != null)
            {
                browserPasteIntoElement["SearchElementType"] = CSharpExpressionConverter.ConvertToken(browserPasteIntoElementsearchElementType);
                browserPasteIntoElementpropCount++;
            }

            if (browserPasteIntoElementsearchElementMinimumWidth != null)
            {
                if (browserPasteIntoElementsearchElementMinimumWidth != null)
                {
                    browserPasteIntoElement["SearchElementMinimumWidth"] = CSharpExpressionConverter.ConvertToken(browserPasteIntoElementsearchElementMinimumWidth);
                    browserPasteIntoElementpropCount++;
                }

                browserPasteIntoElementpropCount++;
            }
            else
            {
                browserPasteIntoElement["SearchElementMinimumWidth"] = 1;
                browserPasteIntoElementpropCount++;
            }

            if (browserPasteIntoElementsearchElementMinimumHeight != null)
            {
                if (browserPasteIntoElementsearchElementMinimumHeight != null)
                {
                    browserPasteIntoElement["SearchElementMinimumHeight"] = CSharpExpressionConverter.ConvertToken(browserPasteIntoElementsearchElementMinimumHeight);
                    browserPasteIntoElementpropCount++;
                }

                browserPasteIntoElementpropCount++;
            }
            else
            {
                browserPasteIntoElement["SearchElementMinimumHeight"] = 1;
                browserPasteIntoElementpropCount++;
            }

            if (browserPasteIntoElementsearchElementBoundingBoxLeft != null)
            {
                if (browserPasteIntoElementsearchElementBoundingBoxLeft != null)
                {
                    browserPasteIntoElement["SearchElementBoundingBoxLeft"] = CSharpExpressionConverter.ConvertToken(browserPasteIntoElementsearchElementBoundingBoxLeft);
                    browserPasteIntoElementpropCount++;
                }

                browserPasteIntoElementpropCount++;
            }
            else
            {
                browserPasteIntoElement["SearchElementBoundingBoxLeft"] = -99999;
                browserPasteIntoElementpropCount++;
            }

            if (browserPasteIntoElementsearchElementBoundingBoxRight != null)
            {
                if (browserPasteIntoElementsearchElementBoundingBoxRight != null)
                {
                    browserPasteIntoElement["SearchElementBoundingBoxRight"] = CSharpExpressionConverter.ConvertToken(browserPasteIntoElementsearchElementBoundingBoxRight);
                    browserPasteIntoElementpropCount++;
                }

                browserPasteIntoElementpropCount++;
            }
            else
            {
                browserPasteIntoElement["SearchElementBoundingBoxRight"] = 99999;
                browserPasteIntoElementpropCount++;
            }

            if (browserPasteIntoElementsearchElementBoundingBoxTop != null)
            {
                if (browserPasteIntoElementsearchElementBoundingBoxTop != null)
                {
                    browserPasteIntoElement["SearchElementBoundingBoxTop"] = CSharpExpressionConverter.ConvertToken(browserPasteIntoElementsearchElementBoundingBoxTop);
                    browserPasteIntoElementpropCount++;
                }

                browserPasteIntoElementpropCount++;
            }
            else
            {
                browserPasteIntoElement["SearchElementBoundingBoxTop"] = -99999;
                browserPasteIntoElementpropCount++;
            }

            if (browserPasteIntoElementsearchElementBoundingBoxBottom != null)
            {
                if (browserPasteIntoElementsearchElementBoundingBoxBottom != null)
                {
                    browserPasteIntoElement["SearchElementBoundingBoxBottom"] = CSharpExpressionConverter.ConvertToken(browserPasteIntoElementsearchElementBoundingBoxBottom);
                    browserPasteIntoElementpropCount++;
                }

                browserPasteIntoElementpropCount++;
            }
            else
            {
                browserPasteIntoElement["SearchElementBoundingBoxBottom"] = 99999;
                browserPasteIntoElementpropCount++;
            }

            if (browserPasteIntoElementonlyElementTopLeftNeedsToBeInBoundingBox != null)
            {
                if (browserPasteIntoElementonlyElementTopLeftNeedsToBeInBoundingBox != null)
                {
                    browserPasteIntoElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = CSharpExpressionConverter.ConvertToken(browserPasteIntoElementonlyElementTopLeftNeedsToBeInBoundingBox);
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
            browserPasteIntoElement["Workflow"] = CSharpExpressionConverter.ConvertToken(browserPasteIntoElementworkflow);
            if (browserPasteIntoElementpropCount > 0)
            {
                callPayload.Body = browserPasteIntoElement;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserPrintCurrentPage(Expression<Func<string>> browserPrintCurrentPageworkflow)
        {
            var apiCallPath = "/BrowserControl/PrintCurrentPage";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserPrintCurrentPage = new JObject();
            var browserPrintCurrentPagepropCount = 0;
            browserPrintCurrentPagepropCount++;
            browserPrintCurrentPage["Workflow"] = CSharpExpressionConverter.ConvertToken(browserPrintCurrentPageworkflow);
            if (browserPrintCurrentPagepropCount > 0)
            {
                callPayload.Body = browserPrintCurrentPage;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserScrollWindowByPixels(Expression<Func<string>> browserScrollWindowByPixelsworkflow, Expression<Func<double>> browserScrollWindowByPixelsx = null, Expression<Func<double>> browserScrollWindowByPixelsy = null)
        {
            var apiCallPath = "/BrowserControl/ScrollWindowByPixels";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserScrollWindowByPixels = new JObject();
            var browserScrollWindowByPixelspropCount = 0;
            if (browserScrollWindowByPixelsx != null)
            {
                browserScrollWindowByPixels["X"] = CSharpExpressionConverter.ConvertToken(browserScrollWindowByPixelsx);
                browserScrollWindowByPixelspropCount++;
            }

            if (browserScrollWindowByPixelsy != null)
            {
                browserScrollWindowByPixels["Y"] = CSharpExpressionConverter.ConvertToken(browserScrollWindowByPixelsy);
                browserScrollWindowByPixelspropCount++;
            }

            browserScrollWindowByPixelspropCount++;
            browserScrollWindowByPixels["Workflow"] = CSharpExpressionConverter.ConvertToken(browserScrollWindowByPixelsworkflow);
            if (browserScrollWindowByPixelspropCount > 0)
            {
                callPayload.Body = browserScrollWindowByPixels;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserScrollWindowToPixels(Expression<Func<string>> browserScrollWindowToPixelsworkflow, Expression<Func<double>> browserScrollWindowToPixelsx = null, Expression<Func<double>> browserScrollWindowToPixelsy = null)
        {
            var apiCallPath = "/BrowserControl/ScrollWindowToPixels";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserScrollWindowToPixels = new JObject();
            var browserScrollWindowToPixelspropCount = 0;
            if (browserScrollWindowToPixelsx != null)
            {
                browserScrollWindowToPixels["X"] = CSharpExpressionConverter.ConvertToken(browserScrollWindowToPixelsx);
                browserScrollWindowToPixelspropCount++;
            }

            if (browserScrollWindowToPixelsy != null)
            {
                browserScrollWindowToPixels["Y"] = CSharpExpressionConverter.ConvertToken(browserScrollWindowToPixelsy);
                browserScrollWindowToPixelspropCount++;
            }

            browserScrollWindowToPixelspropCount++;
            browserScrollWindowToPixels["Workflow"] = CSharpExpressionConverter.ConvertToken(browserScrollWindowToPixelsworkflow);
            if (browserScrollWindowToPixelspropCount > 0)
            {
                callPayload.Body = browserScrollWindowToPixels;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserSelectAllOnElement(Expression<Func<string>> browserSelectAllOnElementworkflow, Expression<Func<double>> browserSelectAllOnElementparentElementHandle = null, Expression<Func<double>> browserSelectAllOnElementsearchElementHandle = null, Expression<Func<string>> browserSelectAllOnElementsearchElementName = null, Expression<Func<string>> browserSelectAllOnElementsearchElementID = null, Expression<Func<string>> browserSelectAllOnElementsearchElementTagName = null, Expression<Func<string>> browserSelectAllOnElementsearchElementXPath = null, Expression<Func<string>> browserSelectAllOnElementsearchElementClassName = null, Expression<Func<string>> browserSelectAllOnElementsearchElementCSSSelector = null, Expression<Func<double>> browserSelectAllOnElementsearchElementIndex = null, Expression<Func<string>> browserSelectAllOnElementsearchElementMatchValue = null, Expression<Func<string>> browserSelectAllOnElementsearchElementMatchText = null, Expression<Func<string>> browserSelectAllOnElementsearchElementType = null, Expression<Func<double>> browserSelectAllOnElementsearchElementMinimumWidth = null, Expression<Func<double>> browserSelectAllOnElementsearchElementMinimumHeight = null, Expression<Func<double>> browserSelectAllOnElementsearchElementBoundingBoxLeft = null, Expression<Func<double>> browserSelectAllOnElementsearchElementBoundingBoxRight = null, Expression<Func<double>> browserSelectAllOnElementsearchElementBoundingBoxTop = null, Expression<Func<double>> browserSelectAllOnElementsearchElementBoundingBoxBottom = null, Expression<Func<bool>> browserSelectAllOnElementonlyElementTopLeftNeedsToBeInBoundingBox = null)
        {
            var apiCallPath = "/BrowserControl/SelectAllOnElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserSelectAllOnElement = new JObject();
            var browserSelectAllOnElementpropCount = 0;
            if (browserSelectAllOnElementparentElementHandle != null)
            {
                browserSelectAllOnElement["ParentElementHandle"] = CSharpExpressionConverter.ConvertToken(browserSelectAllOnElementparentElementHandle);
                browserSelectAllOnElementpropCount++;
            }

            if (browserSelectAllOnElementsearchElementHandle != null)
            {
                browserSelectAllOnElement["SearchElementHandle"] = CSharpExpressionConverter.ConvertToken(browserSelectAllOnElementsearchElementHandle);
                browserSelectAllOnElementpropCount++;
            }

            if (browserSelectAllOnElementsearchElementName != null)
            {
                browserSelectAllOnElement["SearchElementName"] = CSharpExpressionConverter.ConvertToken(browserSelectAllOnElementsearchElementName);
                browserSelectAllOnElementpropCount++;
            }

            if (browserSelectAllOnElementsearchElementID != null)
            {
                browserSelectAllOnElement["SearchElementID"] = CSharpExpressionConverter.ConvertToken(browserSelectAllOnElementsearchElementID);
                browserSelectAllOnElementpropCount++;
            }

            if (browserSelectAllOnElementsearchElementTagName != null)
            {
                browserSelectAllOnElement["SearchElementTagName"] = CSharpExpressionConverter.ConvertToken(browserSelectAllOnElementsearchElementTagName);
                browserSelectAllOnElementpropCount++;
            }

            if (browserSelectAllOnElementsearchElementXPath != null)
            {
                browserSelectAllOnElement["SearchElementXPath"] = CSharpExpressionConverter.ConvertToken(browserSelectAllOnElementsearchElementXPath);
                browserSelectAllOnElementpropCount++;
            }

            if (browserSelectAllOnElementsearchElementClassName != null)
            {
                browserSelectAllOnElement["SearchElementClassName"] = CSharpExpressionConverter.ConvertToken(browserSelectAllOnElementsearchElementClassName);
                browserSelectAllOnElementpropCount++;
            }

            if (browserSelectAllOnElementsearchElementCSSSelector != null)
            {
                browserSelectAllOnElement["SearchElementCSSSelector"] = CSharpExpressionConverter.ConvertToken(browserSelectAllOnElementsearchElementCSSSelector);
                browserSelectAllOnElementpropCount++;
            }

            if (browserSelectAllOnElementsearchElementIndex != null)
            {
                if (browserSelectAllOnElementsearchElementIndex != null)
                {
                    browserSelectAllOnElement["SearchElementIndex"] = CSharpExpressionConverter.ConvertToken(browserSelectAllOnElementsearchElementIndex);
                    browserSelectAllOnElementpropCount++;
                }

                browserSelectAllOnElementpropCount++;
            }
            else
            {
                browserSelectAllOnElement["SearchElementIndex"] = 1;
                browserSelectAllOnElementpropCount++;
            }

            if (browserSelectAllOnElementsearchElementMatchValue != null)
            {
                browserSelectAllOnElement["SearchElementMatchValue"] = CSharpExpressionConverter.ConvertToken(browserSelectAllOnElementsearchElementMatchValue);
                browserSelectAllOnElementpropCount++;
            }

            if (browserSelectAllOnElementsearchElementMatchText != null)
            {
                browserSelectAllOnElement["SearchElementMatchText"] = CSharpExpressionConverter.ConvertToken(browserSelectAllOnElementsearchElementMatchText);
                browserSelectAllOnElementpropCount++;
            }

            if (browserSelectAllOnElementsearchElementType != null)
            {
                browserSelectAllOnElement["SearchElementType"] = CSharpExpressionConverter.ConvertToken(browserSelectAllOnElementsearchElementType);
                browserSelectAllOnElementpropCount++;
            }

            if (browserSelectAllOnElementsearchElementMinimumWidth != null)
            {
                if (browserSelectAllOnElementsearchElementMinimumWidth != null)
                {
                    browserSelectAllOnElement["SearchElementMinimumWidth"] = CSharpExpressionConverter.ConvertToken(browserSelectAllOnElementsearchElementMinimumWidth);
                    browserSelectAllOnElementpropCount++;
                }

                browserSelectAllOnElementpropCount++;
            }
            else
            {
                browserSelectAllOnElement["SearchElementMinimumWidth"] = 1;
                browserSelectAllOnElementpropCount++;
            }

            if (browserSelectAllOnElementsearchElementMinimumHeight != null)
            {
                if (browserSelectAllOnElementsearchElementMinimumHeight != null)
                {
                    browserSelectAllOnElement["SearchElementMinimumHeight"] = CSharpExpressionConverter.ConvertToken(browserSelectAllOnElementsearchElementMinimumHeight);
                    browserSelectAllOnElementpropCount++;
                }

                browserSelectAllOnElementpropCount++;
            }
            else
            {
                browserSelectAllOnElement["SearchElementMinimumHeight"] = 1;
                browserSelectAllOnElementpropCount++;
            }

            if (browserSelectAllOnElementsearchElementBoundingBoxLeft != null)
            {
                if (browserSelectAllOnElementsearchElementBoundingBoxLeft != null)
                {
                    browserSelectAllOnElement["SearchElementBoundingBoxLeft"] = CSharpExpressionConverter.ConvertToken(browserSelectAllOnElementsearchElementBoundingBoxLeft);
                    browserSelectAllOnElementpropCount++;
                }

                browserSelectAllOnElementpropCount++;
            }
            else
            {
                browserSelectAllOnElement["SearchElementBoundingBoxLeft"] = -99999;
                browserSelectAllOnElementpropCount++;
            }

            if (browserSelectAllOnElementsearchElementBoundingBoxRight != null)
            {
                if (browserSelectAllOnElementsearchElementBoundingBoxRight != null)
                {
                    browserSelectAllOnElement["SearchElementBoundingBoxRight"] = CSharpExpressionConverter.ConvertToken(browserSelectAllOnElementsearchElementBoundingBoxRight);
                    browserSelectAllOnElementpropCount++;
                }

                browserSelectAllOnElementpropCount++;
            }
            else
            {
                browserSelectAllOnElement["SearchElementBoundingBoxRight"] = 99999;
                browserSelectAllOnElementpropCount++;
            }

            if (browserSelectAllOnElementsearchElementBoundingBoxTop != null)
            {
                if (browserSelectAllOnElementsearchElementBoundingBoxTop != null)
                {
                    browserSelectAllOnElement["SearchElementBoundingBoxTop"] = CSharpExpressionConverter.ConvertToken(browserSelectAllOnElementsearchElementBoundingBoxTop);
                    browserSelectAllOnElementpropCount++;
                }

                browserSelectAllOnElementpropCount++;
            }
            else
            {
                browserSelectAllOnElement["SearchElementBoundingBoxTop"] = -99999;
                browserSelectAllOnElementpropCount++;
            }

            if (browserSelectAllOnElementsearchElementBoundingBoxBottom != null)
            {
                if (browserSelectAllOnElementsearchElementBoundingBoxBottom != null)
                {
                    browserSelectAllOnElement["SearchElementBoundingBoxBottom"] = CSharpExpressionConverter.ConvertToken(browserSelectAllOnElementsearchElementBoundingBoxBottom);
                    browserSelectAllOnElementpropCount++;
                }

                browserSelectAllOnElementpropCount++;
            }
            else
            {
                browserSelectAllOnElement["SearchElementBoundingBoxBottom"] = 99999;
                browserSelectAllOnElementpropCount++;
            }

            if (browserSelectAllOnElementonlyElementTopLeftNeedsToBeInBoundingBox != null)
            {
                if (browserSelectAllOnElementonlyElementTopLeftNeedsToBeInBoundingBox != null)
                {
                    browserSelectAllOnElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = CSharpExpressionConverter.ConvertToken(browserSelectAllOnElementonlyElementTopLeftNeedsToBeInBoundingBox);
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
            browserSelectAllOnElement["Workflow"] = CSharpExpressionConverter.ConvertToken(browserSelectAllOnElementworkflow);
            if (browserSelectAllOnElementpropCount > 0)
            {
                callPayload.Body = browserSelectAllOnElement;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserWaitForElementToExistResponse> BrowserWaitForElementToExist(Expression<Func<int>> browserWaitForElementToExistsecondsToWait, Expression<Func<string>> browserWaitForElementToExistworkflow, Expression<Func<double>> browserWaitForElementToExistparentElementHandle = null, Expression<Func<string>> browserWaitForElementToExistsearchElementName = null, Expression<Func<string>> browserWaitForElementToExistsearchElementID = null, Expression<Func<string>> browserWaitForElementToExistsearchElementTagName = null, Expression<Func<string>> browserWaitForElementToExistsearchElementXPath = null, Expression<Func<string>> browserWaitForElementToExistsearchElementClassName = null, Expression<Func<string>> browserWaitForElementToExistsearchElementCSSSelector = null, Expression<Func<double>> browserWaitForElementToExistsearchElementIndex = null, Expression<Func<string>> browserWaitForElementToExistsearchElementMatchValue = null, Expression<Func<string>> browserWaitForElementToExistsearchElementMatchText = null, Expression<Func<string>> browserWaitForElementToExistsearchElementType = null, Expression<Func<double>> browserWaitForElementToExistsearchElementMinimumWidth = null, Expression<Func<double>> browserWaitForElementToExistsearchElementMinimumHeight = null, Expression<Func<double>> browserWaitForElementToExistsearchElementBoundingBoxLeft = null, Expression<Func<double>> browserWaitForElementToExistsearchElementBoundingBoxRight = null, Expression<Func<double>> browserWaitForElementToExistsearchElementBoundingBoxTop = null, Expression<Func<double>> browserWaitForElementToExistsearchElementBoundingBoxBottom = null, Expression<Func<bool>> browserWaitForElementToExistonlyElementTopLeftNeedsToBeInBoundingBox = null, Expression<Func<bool>> browserWaitForElementToExistraiseExceptionIfElementNotFound = null, Expression<Func<bool>> browserWaitForElementToExistuseExplicitWaitConditionsIfPossible = null, Expression<Func<bool>> browserWaitForElementToExistwaitForSearchElementToBeDisplayed = null)
        {
            var apiCallPath = "/BrowserControl/WaitForElementToExist";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserWaitForElementToExist = new JObject();
            var browserWaitForElementToExistpropCount = 0;
            if (browserWaitForElementToExistparentElementHandle != null)
            {
                browserWaitForElementToExist["ParentElementHandle"] = CSharpExpressionConverter.ConvertToken(browserWaitForElementToExistparentElementHandle);
                browserWaitForElementToExistpropCount++;
            }

            if (browserWaitForElementToExistsearchElementName != null)
            {
                browserWaitForElementToExist["SearchElementName"] = CSharpExpressionConverter.ConvertToken(browserWaitForElementToExistsearchElementName);
                browserWaitForElementToExistpropCount++;
            }

            if (browserWaitForElementToExistsearchElementID != null)
            {
                browserWaitForElementToExist["SearchElementID"] = CSharpExpressionConverter.ConvertToken(browserWaitForElementToExistsearchElementID);
                browserWaitForElementToExistpropCount++;
            }

            if (browserWaitForElementToExistsearchElementTagName != null)
            {
                browserWaitForElementToExist["SearchElementTagName"] = CSharpExpressionConverter.ConvertToken(browserWaitForElementToExistsearchElementTagName);
                browserWaitForElementToExistpropCount++;
            }

            if (browserWaitForElementToExistsearchElementXPath != null)
            {
                browserWaitForElementToExist["SearchElementXPath"] = CSharpExpressionConverter.ConvertToken(browserWaitForElementToExistsearchElementXPath);
                browserWaitForElementToExistpropCount++;
            }

            if (browserWaitForElementToExistsearchElementClassName != null)
            {
                browserWaitForElementToExist["SearchElementClassName"] = CSharpExpressionConverter.ConvertToken(browserWaitForElementToExistsearchElementClassName);
                browserWaitForElementToExistpropCount++;
            }

            if (browserWaitForElementToExistsearchElementCSSSelector != null)
            {
                browserWaitForElementToExist["SearchElementCSSSelector"] = CSharpExpressionConverter.ConvertToken(browserWaitForElementToExistsearchElementCSSSelector);
                browserWaitForElementToExistpropCount++;
            }

            if (browserWaitForElementToExistsearchElementIndex != null)
            {
                if (browserWaitForElementToExistsearchElementIndex != null)
                {
                    browserWaitForElementToExist["SearchElementIndex"] = CSharpExpressionConverter.ConvertToken(browserWaitForElementToExistsearchElementIndex);
                    browserWaitForElementToExistpropCount++;
                }

                browserWaitForElementToExistpropCount++;
            }
            else
            {
                browserWaitForElementToExist["SearchElementIndex"] = 1;
                browserWaitForElementToExistpropCount++;
            }

            if (browserWaitForElementToExistsearchElementMatchValue != null)
            {
                browserWaitForElementToExist["SearchElementMatchValue"] = CSharpExpressionConverter.ConvertToken(browserWaitForElementToExistsearchElementMatchValue);
                browserWaitForElementToExistpropCount++;
            }

            if (browserWaitForElementToExistsearchElementMatchText != null)
            {
                browserWaitForElementToExist["SearchElementMatchText"] = CSharpExpressionConverter.ConvertToken(browserWaitForElementToExistsearchElementMatchText);
                browserWaitForElementToExistpropCount++;
            }

            if (browserWaitForElementToExistsearchElementType != null)
            {
                browserWaitForElementToExist["SearchElementType"] = CSharpExpressionConverter.ConvertToken(browserWaitForElementToExistsearchElementType);
                browserWaitForElementToExistpropCount++;
            }

            if (browserWaitForElementToExistsearchElementMinimumWidth != null)
            {
                if (browserWaitForElementToExistsearchElementMinimumWidth != null)
                {
                    browserWaitForElementToExist["SearchElementMinimumWidth"] = CSharpExpressionConverter.ConvertToken(browserWaitForElementToExistsearchElementMinimumWidth);
                    browserWaitForElementToExistpropCount++;
                }

                browserWaitForElementToExistpropCount++;
            }
            else
            {
                browserWaitForElementToExist["SearchElementMinimumWidth"] = 1;
                browserWaitForElementToExistpropCount++;
            }

            if (browserWaitForElementToExistsearchElementMinimumHeight != null)
            {
                if (browserWaitForElementToExistsearchElementMinimumHeight != null)
                {
                    browserWaitForElementToExist["SearchElementMinimumHeight"] = CSharpExpressionConverter.ConvertToken(browserWaitForElementToExistsearchElementMinimumHeight);
                    browserWaitForElementToExistpropCount++;
                }

                browserWaitForElementToExistpropCount++;
            }
            else
            {
                browserWaitForElementToExist["SearchElementMinimumHeight"] = 1;
                browserWaitForElementToExistpropCount++;
            }

            if (browserWaitForElementToExistsearchElementBoundingBoxLeft != null)
            {
                if (browserWaitForElementToExistsearchElementBoundingBoxLeft != null)
                {
                    browserWaitForElementToExist["SearchElementBoundingBoxLeft"] = CSharpExpressionConverter.ConvertToken(browserWaitForElementToExistsearchElementBoundingBoxLeft);
                    browserWaitForElementToExistpropCount++;
                }

                browserWaitForElementToExistpropCount++;
            }
            else
            {
                browserWaitForElementToExist["SearchElementBoundingBoxLeft"] = -99999;
                browserWaitForElementToExistpropCount++;
            }

            if (browserWaitForElementToExistsearchElementBoundingBoxRight != null)
            {
                if (browserWaitForElementToExistsearchElementBoundingBoxRight != null)
                {
                    browserWaitForElementToExist["SearchElementBoundingBoxRight"] = CSharpExpressionConverter.ConvertToken(browserWaitForElementToExistsearchElementBoundingBoxRight);
                    browserWaitForElementToExistpropCount++;
                }

                browserWaitForElementToExistpropCount++;
            }
            else
            {
                browserWaitForElementToExist["SearchElementBoundingBoxRight"] = 99999;
                browserWaitForElementToExistpropCount++;
            }

            if (browserWaitForElementToExistsearchElementBoundingBoxTop != null)
            {
                if (browserWaitForElementToExistsearchElementBoundingBoxTop != null)
                {
                    browserWaitForElementToExist["SearchElementBoundingBoxTop"] = CSharpExpressionConverter.ConvertToken(browserWaitForElementToExistsearchElementBoundingBoxTop);
                    browserWaitForElementToExistpropCount++;
                }

                browserWaitForElementToExistpropCount++;
            }
            else
            {
                browserWaitForElementToExist["SearchElementBoundingBoxTop"] = -99999;
                browserWaitForElementToExistpropCount++;
            }

            if (browserWaitForElementToExistsearchElementBoundingBoxBottom != null)
            {
                if (browserWaitForElementToExistsearchElementBoundingBoxBottom != null)
                {
                    browserWaitForElementToExist["SearchElementBoundingBoxBottom"] = CSharpExpressionConverter.ConvertToken(browserWaitForElementToExistsearchElementBoundingBoxBottom);
                    browserWaitForElementToExistpropCount++;
                }

                browserWaitForElementToExistpropCount++;
            }
            else
            {
                browserWaitForElementToExist["SearchElementBoundingBoxBottom"] = 99999;
                browserWaitForElementToExistpropCount++;
            }

            if (browserWaitForElementToExistonlyElementTopLeftNeedsToBeInBoundingBox != null)
            {
                if (browserWaitForElementToExistonlyElementTopLeftNeedsToBeInBoundingBox != null)
                {
                    browserWaitForElementToExist["OnlyElementTopLeftNeedsToBeInBoundingBox"] = CSharpExpressionConverter.ConvertToken(browserWaitForElementToExistonlyElementTopLeftNeedsToBeInBoundingBox);
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
            browserWaitForElementToExist["SecondsToWait"] = CSharpExpressionConverter.ConvertToken(browserWaitForElementToExistsecondsToWait);
            if (browserWaitForElementToExistraiseExceptionIfElementNotFound != null)
            {
                if (browserWaitForElementToExistraiseExceptionIfElementNotFound != null)
                {
                    browserWaitForElementToExist["RaiseExceptionIfElementNotFound"] = CSharpExpressionConverter.ConvertToken(browserWaitForElementToExistraiseExceptionIfElementNotFound);
                    browserWaitForElementToExistpropCount++;
                }

                browserWaitForElementToExistpropCount++;
            }
            else
            {
                browserWaitForElementToExist["RaiseExceptionIfElementNotFound"] = false;
                browserWaitForElementToExistpropCount++;
            }

            if (browserWaitForElementToExistuseExplicitWaitConditionsIfPossible != null)
            {
                if (browserWaitForElementToExistuseExplicitWaitConditionsIfPossible != null)
                {
                    browserWaitForElementToExist["UseExplicitWaitConditionsIfPossible"] = CSharpExpressionConverter.ConvertToken(browserWaitForElementToExistuseExplicitWaitConditionsIfPossible);
                    browserWaitForElementToExistpropCount++;
                }

                browserWaitForElementToExistpropCount++;
            }
            else
            {
                browserWaitForElementToExist["UseExplicitWaitConditionsIfPossible"] = true;
                browserWaitForElementToExistpropCount++;
            }

            if (browserWaitForElementToExistwaitForSearchElementToBeDisplayed != null)
            {
                if (browserWaitForElementToExistwaitForSearchElementToBeDisplayed != null)
                {
                    browserWaitForElementToExist["WaitForSearchElementToBeDisplayed"] = CSharpExpressionConverter.ConvertToken(browserWaitForElementToExistwaitForSearchElementToBeDisplayed);
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
            browserWaitForElementToExist["Workflow"] = CSharpExpressionConverter.ConvertToken(browserWaitForElementToExistworkflow);
            if (browserWaitForElementToExistpropCount > 0)
            {
                callPayload.Body = browserWaitForElementToExist;
            }

            return new ApiConnectionAction<BrowserWaitForElementToExistResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserWaitForElementToNotExistResponse> BrowserWaitForElementToNotExist(Expression<Func<int>> browserWaitForElementToNotExistsecondsToWait, Expression<Func<string>> browserWaitForElementToNotExistworkflow, Expression<Func<double>> browserWaitForElementToNotExistparentElementHandle = null, Expression<Func<double>> browserWaitForElementToNotExistsearchElementHandle = null, Expression<Func<string>> browserWaitForElementToNotExistsearchElementName = null, Expression<Func<string>> browserWaitForElementToNotExistsearchElementID = null, Expression<Func<string>> browserWaitForElementToNotExistsearchElementTagName = null, Expression<Func<string>> browserWaitForElementToNotExistsearchElementXPath = null, Expression<Func<string>> browserWaitForElementToNotExistsearchElementClassName = null, Expression<Func<string>> browserWaitForElementToNotExistsearchElementCSSSelector = null, Expression<Func<double>> browserWaitForElementToNotExistsearchElementIndex = null, Expression<Func<string>> browserWaitForElementToNotExistsearchElementMatchValue = null, Expression<Func<string>> browserWaitForElementToNotExistsearchElementMatchText = null, Expression<Func<string>> browserWaitForElementToNotExistsearchElementType = null, Expression<Func<double>> browserWaitForElementToNotExistsearchElementMinimumWidth = null, Expression<Func<double>> browserWaitForElementToNotExistsearchElementMinimumHeight = null, Expression<Func<double>> browserWaitForElementToNotExistsearchElementBoundingBoxLeft = null, Expression<Func<double>> browserWaitForElementToNotExistsearchElementBoundingBoxRight = null, Expression<Func<double>> browserWaitForElementToNotExistsearchElementBoundingBoxTop = null, Expression<Func<double>> browserWaitForElementToNotExistsearchElementBoundingBoxBottom = null, Expression<Func<bool>> browserWaitForElementToNotExistonlyElementTopLeftNeedsToBeInBoundingBox = null, Expression<Func<bool>> browserWaitForElementToNotExistraiseExceptionIfElementStillExists = null, Expression<Func<bool>> browserWaitForElementToNotExistsearchElementMustBeDisplayed = null)
        {
            var apiCallPath = "/BrowserControl/WaitForElementToNotExist";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserWaitForElementToNotExist = new JObject();
            var browserWaitForElementToNotExistpropCount = 0;
            if (browserWaitForElementToNotExistparentElementHandle != null)
            {
                browserWaitForElementToNotExist["ParentElementHandle"] = CSharpExpressionConverter.ConvertToken(browserWaitForElementToNotExistparentElementHandle);
                browserWaitForElementToNotExistpropCount++;
            }

            if (browserWaitForElementToNotExistsearchElementHandle != null)
            {
                browserWaitForElementToNotExist["SearchElementHandle"] = CSharpExpressionConverter.ConvertToken(browserWaitForElementToNotExistsearchElementHandle);
                browserWaitForElementToNotExistpropCount++;
            }

            if (browserWaitForElementToNotExistsearchElementName != null)
            {
                browserWaitForElementToNotExist["SearchElementName"] = CSharpExpressionConverter.ConvertToken(browserWaitForElementToNotExistsearchElementName);
                browserWaitForElementToNotExistpropCount++;
            }

            if (browserWaitForElementToNotExistsearchElementID != null)
            {
                browserWaitForElementToNotExist["SearchElementID"] = CSharpExpressionConverter.ConvertToken(browserWaitForElementToNotExistsearchElementID);
                browserWaitForElementToNotExistpropCount++;
            }

            if (browserWaitForElementToNotExistsearchElementTagName != null)
            {
                browserWaitForElementToNotExist["SearchElementTagName"] = CSharpExpressionConverter.ConvertToken(browserWaitForElementToNotExistsearchElementTagName);
                browserWaitForElementToNotExistpropCount++;
            }

            if (browserWaitForElementToNotExistsearchElementXPath != null)
            {
                browserWaitForElementToNotExist["SearchElementXPath"] = CSharpExpressionConverter.ConvertToken(browserWaitForElementToNotExistsearchElementXPath);
                browserWaitForElementToNotExistpropCount++;
            }

            if (browserWaitForElementToNotExistsearchElementClassName != null)
            {
                browserWaitForElementToNotExist["SearchElementClassName"] = CSharpExpressionConverter.ConvertToken(browserWaitForElementToNotExistsearchElementClassName);
                browserWaitForElementToNotExistpropCount++;
            }

            if (browserWaitForElementToNotExistsearchElementCSSSelector != null)
            {
                browserWaitForElementToNotExist["SearchElementCSSSelector"] = CSharpExpressionConverter.ConvertToken(browserWaitForElementToNotExistsearchElementCSSSelector);
                browserWaitForElementToNotExistpropCount++;
            }

            if (browserWaitForElementToNotExistsearchElementIndex != null)
            {
                if (browserWaitForElementToNotExistsearchElementIndex != null)
                {
                    browserWaitForElementToNotExist["SearchElementIndex"] = CSharpExpressionConverter.ConvertToken(browserWaitForElementToNotExistsearchElementIndex);
                    browserWaitForElementToNotExistpropCount++;
                }

                browserWaitForElementToNotExistpropCount++;
            }
            else
            {
                browserWaitForElementToNotExist["SearchElementIndex"] = 1;
                browserWaitForElementToNotExistpropCount++;
            }

            if (browserWaitForElementToNotExistsearchElementMatchValue != null)
            {
                browserWaitForElementToNotExist["SearchElementMatchValue"] = CSharpExpressionConverter.ConvertToken(browserWaitForElementToNotExistsearchElementMatchValue);
                browserWaitForElementToNotExistpropCount++;
            }

            if (browserWaitForElementToNotExistsearchElementMatchText != null)
            {
                browserWaitForElementToNotExist["SearchElementMatchText"] = CSharpExpressionConverter.ConvertToken(browserWaitForElementToNotExistsearchElementMatchText);
                browserWaitForElementToNotExistpropCount++;
            }

            if (browserWaitForElementToNotExistsearchElementType != null)
            {
                browserWaitForElementToNotExist["SearchElementType"] = CSharpExpressionConverter.ConvertToken(browserWaitForElementToNotExistsearchElementType);
                browserWaitForElementToNotExistpropCount++;
            }

            if (browserWaitForElementToNotExistsearchElementMinimumWidth != null)
            {
                if (browserWaitForElementToNotExistsearchElementMinimumWidth != null)
                {
                    browserWaitForElementToNotExist["SearchElementMinimumWidth"] = CSharpExpressionConverter.ConvertToken(browserWaitForElementToNotExistsearchElementMinimumWidth);
                    browserWaitForElementToNotExistpropCount++;
                }

                browserWaitForElementToNotExistpropCount++;
            }
            else
            {
                browserWaitForElementToNotExist["SearchElementMinimumWidth"] = 1;
                browserWaitForElementToNotExistpropCount++;
            }

            if (browserWaitForElementToNotExistsearchElementMinimumHeight != null)
            {
                if (browserWaitForElementToNotExistsearchElementMinimumHeight != null)
                {
                    browserWaitForElementToNotExist["SearchElementMinimumHeight"] = CSharpExpressionConverter.ConvertToken(browserWaitForElementToNotExistsearchElementMinimumHeight);
                    browserWaitForElementToNotExistpropCount++;
                }

                browserWaitForElementToNotExistpropCount++;
            }
            else
            {
                browserWaitForElementToNotExist["SearchElementMinimumHeight"] = 1;
                browserWaitForElementToNotExistpropCount++;
            }

            if (browserWaitForElementToNotExistsearchElementBoundingBoxLeft != null)
            {
                if (browserWaitForElementToNotExistsearchElementBoundingBoxLeft != null)
                {
                    browserWaitForElementToNotExist["SearchElementBoundingBoxLeft"] = CSharpExpressionConverter.ConvertToken(browserWaitForElementToNotExistsearchElementBoundingBoxLeft);
                    browserWaitForElementToNotExistpropCount++;
                }

                browserWaitForElementToNotExistpropCount++;
            }
            else
            {
                browserWaitForElementToNotExist["SearchElementBoundingBoxLeft"] = -99999;
                browserWaitForElementToNotExistpropCount++;
            }

            if (browserWaitForElementToNotExistsearchElementBoundingBoxRight != null)
            {
                if (browserWaitForElementToNotExistsearchElementBoundingBoxRight != null)
                {
                    browserWaitForElementToNotExist["SearchElementBoundingBoxRight"] = CSharpExpressionConverter.ConvertToken(browserWaitForElementToNotExistsearchElementBoundingBoxRight);
                    browserWaitForElementToNotExistpropCount++;
                }

                browserWaitForElementToNotExistpropCount++;
            }
            else
            {
                browserWaitForElementToNotExist["SearchElementBoundingBoxRight"] = 99999;
                browserWaitForElementToNotExistpropCount++;
            }

            if (browserWaitForElementToNotExistsearchElementBoundingBoxTop != null)
            {
                if (browserWaitForElementToNotExistsearchElementBoundingBoxTop != null)
                {
                    browserWaitForElementToNotExist["SearchElementBoundingBoxTop"] = CSharpExpressionConverter.ConvertToken(browserWaitForElementToNotExistsearchElementBoundingBoxTop);
                    browserWaitForElementToNotExistpropCount++;
                }

                browserWaitForElementToNotExistpropCount++;
            }
            else
            {
                browserWaitForElementToNotExist["SearchElementBoundingBoxTop"] = -99999;
                browserWaitForElementToNotExistpropCount++;
            }

            if (browserWaitForElementToNotExistsearchElementBoundingBoxBottom != null)
            {
                if (browserWaitForElementToNotExistsearchElementBoundingBoxBottom != null)
                {
                    browserWaitForElementToNotExist["SearchElementBoundingBoxBottom"] = CSharpExpressionConverter.ConvertToken(browserWaitForElementToNotExistsearchElementBoundingBoxBottom);
                    browserWaitForElementToNotExistpropCount++;
                }

                browserWaitForElementToNotExistpropCount++;
            }
            else
            {
                browserWaitForElementToNotExist["SearchElementBoundingBoxBottom"] = 99999;
                browserWaitForElementToNotExistpropCount++;
            }

            if (browserWaitForElementToNotExistonlyElementTopLeftNeedsToBeInBoundingBox != null)
            {
                if (browserWaitForElementToNotExistonlyElementTopLeftNeedsToBeInBoundingBox != null)
                {
                    browserWaitForElementToNotExist["OnlyElementTopLeftNeedsToBeInBoundingBox"] = CSharpExpressionConverter.ConvertToken(browserWaitForElementToNotExistonlyElementTopLeftNeedsToBeInBoundingBox);
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
            browserWaitForElementToNotExist["SecondsToWait"] = CSharpExpressionConverter.ConvertToken(browserWaitForElementToNotExistsecondsToWait);
            if (browserWaitForElementToNotExistraiseExceptionIfElementStillExists != null)
            {
                if (browserWaitForElementToNotExistraiseExceptionIfElementStillExists != null)
                {
                    browserWaitForElementToNotExist["RaiseExceptionIfElementStillExists"] = CSharpExpressionConverter.ConvertToken(browserWaitForElementToNotExistraiseExceptionIfElementStillExists);
                    browserWaitForElementToNotExistpropCount++;
                }

                browserWaitForElementToNotExistpropCount++;
            }
            else
            {
                browserWaitForElementToNotExist["RaiseExceptionIfElementStillExists"] = false;
                browserWaitForElementToNotExistpropCount++;
            }

            if (browserWaitForElementToNotExistsearchElementMustBeDisplayed != null)
            {
                if (browserWaitForElementToNotExistsearchElementMustBeDisplayed != null)
                {
                    browserWaitForElementToNotExist["SearchElementMustBeDisplayed"] = CSharpExpressionConverter.ConvertToken(browserWaitForElementToNotExistsearchElementMustBeDisplayed);
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
            browserWaitForElementToNotExist["Workflow"] = CSharpExpressionConverter.ConvertToken(browserWaitForElementToNotExistworkflow);
            if (browserWaitForElementToNotExistpropCount > 0)
            {
                callPayload.Body = browserWaitForElementToNotExist;
            }

            return new ApiConnectionAction<BrowserWaitForElementToNotExistResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserGetWebElementAtScreenCoordinatesResponse> BrowserGetWebElementAtScreenCoordinates(Expression<Func<string>> browserGetWebElementAtScreenCoordinatesworkflow, Expression<Func<int>> browserGetWebElementAtScreenCoordinatesxCoord = null, Expression<Func<int>> browserGetWebElementAtScreenCoordinatesyCoord = null, Expression<Func<bool>> browserGetWebElementAtScreenCoordinatesraiseExceptionIfElementNotFound = null)
        {
            var apiCallPath = "/BrowserControl/GetWebElementAtScreenCoordinates";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserGetWebElementAtScreenCoordinates = new JObject();
            var browserGetWebElementAtScreenCoordinatespropCount = 0;
            if (browserGetWebElementAtScreenCoordinatesxCoord != null)
            {
                if (browserGetWebElementAtScreenCoordinatesxCoord != null)
                {
                    browserGetWebElementAtScreenCoordinates["XCoord"] = CSharpExpressionConverter.ConvertToken(browserGetWebElementAtScreenCoordinatesxCoord);
                    browserGetWebElementAtScreenCoordinatespropCount++;
                }

                browserGetWebElementAtScreenCoordinatespropCount++;
            }
            else
            {
                browserGetWebElementAtScreenCoordinates["XCoord"] = 0;
                browserGetWebElementAtScreenCoordinatespropCount++;
            }

            if (browserGetWebElementAtScreenCoordinatesyCoord != null)
            {
                if (browserGetWebElementAtScreenCoordinatesyCoord != null)
                {
                    browserGetWebElementAtScreenCoordinates["YCoord"] = CSharpExpressionConverter.ConvertToken(browserGetWebElementAtScreenCoordinatesyCoord);
                    browserGetWebElementAtScreenCoordinatespropCount++;
                }

                browserGetWebElementAtScreenCoordinatespropCount++;
            }
            else
            {
                browserGetWebElementAtScreenCoordinates["YCoord"] = 0;
                browserGetWebElementAtScreenCoordinatespropCount++;
            }

            if (browserGetWebElementAtScreenCoordinatesraiseExceptionIfElementNotFound != null)
            {
                if (browserGetWebElementAtScreenCoordinatesraiseExceptionIfElementNotFound != null)
                {
                    browserGetWebElementAtScreenCoordinates["RaiseExceptionIfElementNotFound"] = CSharpExpressionConverter.ConvertToken(browserGetWebElementAtScreenCoordinatesraiseExceptionIfElementNotFound);
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
            browserGetWebElementAtScreenCoordinates["Workflow"] = CSharpExpressionConverter.ConvertToken(browserGetWebElementAtScreenCoordinatesworkflow);
            if (browserGetWebElementAtScreenCoordinatespropCount > 0)
            {
                callPayload.Body = browserGetWebElementAtScreenCoordinates;
            }

            return new ApiConnectionAction<BrowserGetWebElementAtScreenCoordinatesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserGetWebElementAtBrowserDocumentWindowCoordinatesResponse> BrowserGetWebElementAtBrowserDocumentWindowCoordinates(Expression<Func<string>> browserGetWebElementAtBrowserDocumentWindowCoordinatesworkflow, Expression<Func<int>> browserGetWebElementAtBrowserDocumentWindowCoordinatesxCoord = null, Expression<Func<int>> browserGetWebElementAtBrowserDocumentWindowCoordinatesyCoord = null, Expression<Func<bool>> browserGetWebElementAtBrowserDocumentWindowCoordinatesraiseExceptionIfElementNotFound = null)
        {
            var apiCallPath = "/BrowserControl/GetWebElementAtBrowserDocumentWindowCoordinates";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserGetWebElementAtBrowserDocumentWindowCoordinates = new JObject();
            var browserGetWebElementAtBrowserDocumentWindowCoordinatespropCount = 0;
            if (browserGetWebElementAtBrowserDocumentWindowCoordinatesxCoord != null)
            {
                if (browserGetWebElementAtBrowserDocumentWindowCoordinatesxCoord != null)
                {
                    browserGetWebElementAtBrowserDocumentWindowCoordinates["XCoord"] = CSharpExpressionConverter.ConvertToken(browserGetWebElementAtBrowserDocumentWindowCoordinatesxCoord);
                    browserGetWebElementAtBrowserDocumentWindowCoordinatespropCount++;
                }

                browserGetWebElementAtBrowserDocumentWindowCoordinatespropCount++;
            }
            else
            {
                browserGetWebElementAtBrowserDocumentWindowCoordinates["XCoord"] = 0;
                browserGetWebElementAtBrowserDocumentWindowCoordinatespropCount++;
            }

            if (browserGetWebElementAtBrowserDocumentWindowCoordinatesyCoord != null)
            {
                if (browserGetWebElementAtBrowserDocumentWindowCoordinatesyCoord != null)
                {
                    browserGetWebElementAtBrowserDocumentWindowCoordinates["YCoord"] = CSharpExpressionConverter.ConvertToken(browserGetWebElementAtBrowserDocumentWindowCoordinatesyCoord);
                    browserGetWebElementAtBrowserDocumentWindowCoordinatespropCount++;
                }

                browserGetWebElementAtBrowserDocumentWindowCoordinatespropCount++;
            }
            else
            {
                browserGetWebElementAtBrowserDocumentWindowCoordinates["YCoord"] = 0;
                browserGetWebElementAtBrowserDocumentWindowCoordinatespropCount++;
            }

            if (browserGetWebElementAtBrowserDocumentWindowCoordinatesraiseExceptionIfElementNotFound != null)
            {
                if (browserGetWebElementAtBrowserDocumentWindowCoordinatesraiseExceptionIfElementNotFound != null)
                {
                    browserGetWebElementAtBrowserDocumentWindowCoordinates["RaiseExceptionIfElementNotFound"] = CSharpExpressionConverter.ConvertToken(browserGetWebElementAtBrowserDocumentWindowCoordinatesraiseExceptionIfElementNotFound);
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
            browserGetWebElementAtBrowserDocumentWindowCoordinates["Workflow"] = CSharpExpressionConverter.ConvertToken(browserGetWebElementAtBrowserDocumentWindowCoordinatesworkflow);
            if (browserGetWebElementAtBrowserDocumentWindowCoordinatespropCount > 0)
            {
                callPayload.Body = browserGetWebElementAtBrowserDocumentWindowCoordinates;
            }

            return new ApiConnectionAction<BrowserGetWebElementAtBrowserDocumentWindowCoordinatesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserGetWebElementPropertiesAsListResponse> BrowserGetWebElementPropertiesAsList(Expression<Func<int>> browserGetWebElementPropertiesAsListelementHandle, Expression<Func<string>> browserGetWebElementPropertiesAsListworkflow, Expression<Func<bool>> browserGetWebElementPropertiesAsListgetHTMLCode = null, Expression<Func<bool>> browserGetWebElementPropertiesAsListreturnValue = null, Expression<Func<bool>> browserGetWebElementPropertiesAsListreturnText = null, Expression<Func<int>> browserGetWebElementPropertiesAsListmaxValueLength = null, Expression<Func<int>> browserGetWebElementPropertiesAsListmaxTextLength = null, Expression<Func<bool>> browserGetWebElementPropertiesAsListreturnCoordinates = null, Expression<Func<bool>> browserGetWebElementPropertiesAsListreturnParentTag = null)
        {
            var apiCallPath = "/BrowserControl/BrowserGetWebElementPropertiesAsList";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserGetWebElementPropertiesAsList = new JObject();
            var browserGetWebElementPropertiesAsListpropCount = 0;
            browserGetWebElementPropertiesAsListpropCount++;
            browserGetWebElementPropertiesAsList["ElementHandle"] = CSharpExpressionConverter.ConvertToken(browserGetWebElementPropertiesAsListelementHandle);
            if (browserGetWebElementPropertiesAsListgetHTMLCode != null)
            {
                if (browserGetWebElementPropertiesAsListgetHTMLCode != null)
                {
                    browserGetWebElementPropertiesAsList["GetHTMLCode"] = CSharpExpressionConverter.ConvertToken(browserGetWebElementPropertiesAsListgetHTMLCode);
                    browserGetWebElementPropertiesAsListpropCount++;
                }

                browserGetWebElementPropertiesAsListpropCount++;
            }
            else
            {
                browserGetWebElementPropertiesAsList["GetHTMLCode"] = false;
                browserGetWebElementPropertiesAsListpropCount++;
            }

            if (browserGetWebElementPropertiesAsListreturnValue != null)
            {
                if (browserGetWebElementPropertiesAsListreturnValue != null)
                {
                    browserGetWebElementPropertiesAsList["ReturnValue"] = CSharpExpressionConverter.ConvertToken(browserGetWebElementPropertiesAsListreturnValue);
                    browserGetWebElementPropertiesAsListpropCount++;
                }

                browserGetWebElementPropertiesAsListpropCount++;
            }
            else
            {
                browserGetWebElementPropertiesAsList["ReturnValue"] = true;
                browserGetWebElementPropertiesAsListpropCount++;
            }

            if (browserGetWebElementPropertiesAsListreturnText != null)
            {
                if (browserGetWebElementPropertiesAsListreturnText != null)
                {
                    browserGetWebElementPropertiesAsList["ReturnText"] = CSharpExpressionConverter.ConvertToken(browserGetWebElementPropertiesAsListreturnText);
                    browserGetWebElementPropertiesAsListpropCount++;
                }

                browserGetWebElementPropertiesAsListpropCount++;
            }
            else
            {
                browserGetWebElementPropertiesAsList["ReturnText"] = true;
                browserGetWebElementPropertiesAsListpropCount++;
            }

            if (browserGetWebElementPropertiesAsListmaxValueLength != null)
            {
                if (browserGetWebElementPropertiesAsListmaxValueLength != null)
                {
                    browserGetWebElementPropertiesAsList["MaxValueLength"] = CSharpExpressionConverter.ConvertToken(browserGetWebElementPropertiesAsListmaxValueLength);
                    browserGetWebElementPropertiesAsListpropCount++;
                }

                browserGetWebElementPropertiesAsListpropCount++;
            }
            else
            {
                browserGetWebElementPropertiesAsList["MaxValueLength"] = 0;
                browserGetWebElementPropertiesAsListpropCount++;
            }

            if (browserGetWebElementPropertiesAsListmaxTextLength != null)
            {
                if (browserGetWebElementPropertiesAsListmaxTextLength != null)
                {
                    browserGetWebElementPropertiesAsList["MaxTextLength"] = CSharpExpressionConverter.ConvertToken(browserGetWebElementPropertiesAsListmaxTextLength);
                    browserGetWebElementPropertiesAsListpropCount++;
                }

                browserGetWebElementPropertiesAsListpropCount++;
            }
            else
            {
                browserGetWebElementPropertiesAsList["MaxTextLength"] = 0;
                browserGetWebElementPropertiesAsListpropCount++;
            }

            if (browserGetWebElementPropertiesAsListreturnCoordinates != null)
            {
                if (browserGetWebElementPropertiesAsListreturnCoordinates != null)
                {
                    browserGetWebElementPropertiesAsList["ReturnCoordinates"] = CSharpExpressionConverter.ConvertToken(browserGetWebElementPropertiesAsListreturnCoordinates);
                    browserGetWebElementPropertiesAsListpropCount++;
                }

                browserGetWebElementPropertiesAsListpropCount++;
            }
            else
            {
                browserGetWebElementPropertiesAsList["ReturnCoordinates"] = true;
                browserGetWebElementPropertiesAsListpropCount++;
            }

            if (browserGetWebElementPropertiesAsListreturnParentTag != null)
            {
                if (browserGetWebElementPropertiesAsListreturnParentTag != null)
                {
                    browserGetWebElementPropertiesAsList["ReturnParentTag"] = CSharpExpressionConverter.ConvertToken(browserGetWebElementPropertiesAsListreturnParentTag);
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
            browserGetWebElementPropertiesAsList["Workflow"] = CSharpExpressionConverter.ConvertToken(browserGetWebElementPropertiesAsListworkflow);
            if (browserGetWebElementPropertiesAsListpropCount > 0)
            {
                callPayload.Body = browserGetWebElementPropertiesAsList;
            }

            return new ApiConnectionAction<BrowserGetWebElementPropertiesAsListResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<IsBrowserInstanceOpenResponse> IsBrowserInstanceOpen(Expression<Func<string>> isBrowserInstanceOpenworkflow)
        {
            var apiCallPath = "/BrowserControl/IsBrowserInstanceOpen";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var isBrowserInstanceOpen = new JObject();
            var isBrowserInstanceOpenpropCount = 0;
            isBrowserInstanceOpenpropCount++;
            isBrowserInstanceOpen["Workflow"] = CSharpExpressionConverter.ConvertToken(isBrowserInstanceOpenworkflow);
            if (isBrowserInstanceOpenpropCount > 0)
            {
                callPayload.Body = isBrowserInstanceOpen;
            }

            return new ApiConnectionAction<IsBrowserInstanceOpenResponse>(callPayload);
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