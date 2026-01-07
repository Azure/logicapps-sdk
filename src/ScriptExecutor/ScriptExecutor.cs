// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    using System.Collections.Concurrent;
    using System.Net;
    using System.Reflection;
    using System.Runtime.ExceptionServices;
    using global::Grpc.Core;
    using Microsoft.Azure.Workflows.Sdk.Grpc;
    using Microsoft.Extensions.Logging;
    using Newtonsoft.Json;

    /// <summary>
    /// Script executor.
    /// </summary>
    public class ScriptExecutor
    {
        /// <summary>
        /// The method for each script file.
        /// </summary>
        private static readonly ConcurrentDictionary<string, MethodInfo> FunctionInvokers = new ConcurrentDictionary<string, MethodInfo>();

        /// <summary>
        /// Gets or sets the session.
        /// </summary>
        private IJobSessionService.IJobSessionServiceClient Session { get; set; }

        /// <summary>
        /// Gets or sets the logger.
        /// </summary>
        public static ILogger Logger { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScriptExecutor"/> class.
        /// </summary>
        /// <param name="session">The session.</param>
        /// <param name="loggerFactory">The logger factory.</param>
        public ScriptExecutor(IJobSessionService.IJobSessionServiceClient session, ILoggerFactory loggerFactory)
        {
            this.Session = session;
            ScriptExecutor.Logger = loggerFactory.CreateLogger("scripting");
        }

        /// <summary>
        /// Runs the C# script.
        /// </summary>
        /// <param name="invocationDetails">The invocation details.</param>
        public async Task<ExecutionResult> RunScript(InvocationDetails invocationDetails)
        {
            ScriptExecutor.Logger.LogDebug($"Executing the functionc code in the worker: {invocationDetails.ScriptFileName}...");

            try
            {
                if (!ScriptExecutor.FunctionInvokers.TryGetValue(invocationDetails.ScriptFileName, out var invocator))
                {
                    ScriptExecutor.Logger.LogDebug($"Compiled script: {invocationDetails.ScriptFileName} not found to execute...");
                }

                return await this.InvokeParameters(invocationDetails, invocator).ConfigureAwait(false);
            }
            catch (RpcException rpcEx)
            {
                return new ExecutionResult
                {
                    Succeeded = false,
                    Error = new ScriptErrorResponse
                    {
                        StatusCode = HttpStatusCode.BadRequest,
                        Message = rpcEx.Status.Detail,
                        ErrorCode = rpcEx.Status.StatusCode.ToString(),
                        Callstack = ScriptExecutor.GetTruncatedStackTrace(rpcEx)
                    },
                };
            }
            catch (ScriptCompilationException scriptEx)
            {
                return new ExecutionResult
                {
                    Succeeded = false,
                    Error = new ScriptErrorResponse
                    {
                        StatusCode = HttpStatusCode.BadRequest,
                        Message = scriptEx.Message,
                        ErrorCode = HttpStatusCode.BadRequest.ToString()
                    },
                };
            }
            catch (Exception ex) when (ex != null)
            {
                return new ExecutionResult
                {
                    Succeeded = false,
                    Error = new ScriptErrorResponse
                    {
                        StatusCode = HttpStatusCode.BadRequest,
                        Message = ex.Message,
                        Callstack = ScriptExecutor.GetTruncatedStackTrace(ex),
                        ErrorCode = HttpStatusCode.BadRequest.ToString()
                    },
                };
            }
        }

        /// <summary>
        /// Saves the custom code method information.
        /// </summary>
        /// <param name="functionName">The function name.</param>
        /// <param name="callback">The callback method information.</param>
        public static void SaveCustomCodeMethodInfo(string functionName, Delegate callback)
        {
            var fileName = Path.Combine("httpRequestResponse", functionName);
            ScriptExecutor.FunctionInvokers.AddOrUpdate(fileName, callback.Method, (key, oldValue) => callback.Method);
        }

        /// <summary>
        /// Invokes parameters.
        /// </summary>
        /// <param name="invocationDetails">The invocation details.</param>
        /// <param name="invocator">The invocator.</param>
        private async Task<ExecutionResult> InvokeParameters(InvocationDetails invocationDetails, MethodInfo invocator)
        {
            object outputs = null;
            try
            {
                if (invocator.ReturnType == typeof(Task))
                {
                    await ((Task)invocator.Invoke(null, this.GetParameters(invocator, this.Session, invocationDetails, ScriptExecutor.Logger))).ConfigureAwait(continueOnCapturedContext: false);
                }
                else if (invocator.ReturnType.IsGenericType && invocator.ReturnType.GetGenericTypeDefinition() == typeof(Task<>))
                {
                    var task = ((Task)invocator.Invoke(null, this.GetParameters(invocator, this.Session, invocationDetails, ScriptExecutor.Logger)));
                    await task.ConfigureAwait(continueOnCapturedContext: false);
                    var resultProperty = task.GetType().GetProperty("Result");
                    outputs = resultProperty.GetValue(task);
                }
                else if (invocator.ReturnType == typeof(void))
                {
                    invocator.Invoke(null, this.GetParameters(invocator, this.Session, invocationDetails, ScriptExecutor.Logger));
                }
                else
                {
                    outputs = invocator.Invoke(null, this.GetParameters(invocator, this.Session, invocationDetails, ScriptExecutor.Logger));
                }
            }
            catch (TargetInvocationException ex)
            {
                ExceptionDispatchInfo.Capture(ex.InnerException).Throw();
            }

            return new ExecutionResult
            {
                Outputs = JsonConvert.SerializeObject(outputs, JsonExtensions.ObjectSerializationSettings),
                Succeeded = true
            };
        }

        /// <summary>
        /// Get the truncated stack trace of an exception.
        /// </summary>
        /// <param name="ex">The exception.</param>
        private static string GetTruncatedStackTrace(Exception ex)
        {
            return ex.StackTrace;
        }

        /// <summary>
        /// Get the parameter values.
        /// </summary>
        /// <param name="method">The method.</param>
        /// <param name="session">The session.</param>
        /// <param name="invocationDetails">The invocation details.</param>
        /// <param name="logger">The logger.</param>
        private object[] GetParameters(MethodInfo method, IJobSessionService.IJobSessionServiceClient session, InvocationDetails invocationDetails, ILogger logger)
        {
            var parameters = method.GetParameters();
            var parameterValues = new System.Collections.Generic.List<object>();
            foreach (var param in parameters)
            {
                if (param.ParameterType == typeof(WorkflowContext))
                {
                    parameterValues.Add(new WorkerWorkflowContext(session, invocationDetails.SessionId));
                }
                else if (param.ParameterType == typeof(ILogger))
                {
                    parameterValues.Add(logger);
                }
                else
                {
                    throw new ArgumentException($"Parameter of '{param.ParameterType}' type is not supported.");
                }
            }

            return parameterValues.ToArray();
        }
    }
}
