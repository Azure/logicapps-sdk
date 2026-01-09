namespace Microsoft.Azure.Workflows.Sdk
{
    using System;
    using System.Collections.Generic;
    using System.Reflection;

    /// <summary>
    /// Represents detailed information about a method for caching and retrieval.
    /// </summary>
    public class MethodInformationCache
    {
        /// <summary>
        /// Gets the method information.
        /// </summary>
        public MethodInfo MethodInfo { get; set; }

        /// <summary>
        /// Gets the fully qualified method name (Namespace.ClassName.MethodName).
        /// </summary>
        public string FullyQualifiedName { get; set; }

        /// <summary>
        /// Gets the method name.
        /// </summary>
        public string MethodName { get; set; }

        /// <summary>
        /// Gets the declaring type.
        /// </summary>
        public Type DeclaringType { get; set; }

        /// <summary>
        /// Gets the return type of the method.
        /// </summary>
        public Type ReturnType { get; set; }

        /// <summary>
        /// Gets the method parameters information.
        /// </summary>
        public ParameterInfo[] Parameters { get; set; }

        /// <summary>
        /// Gets a value indicating whether the method is async (returns Task or Task{T}).
        /// </summary>
        public bool IsAsync { get; set; }

        /// <summary>
        /// Gets a value indicating whether the method is static.
        /// </summary>
        public bool IsStatic { get; set; }

        /// <summary>
        /// Gets a value indicating whether the method is generic.
        /// </summary>
        public bool IsGeneric { get; set; }

        /// <summary>
        /// Gets the generic type parameters if the method is generic.
        /// </summary>
        public Type[] GenericTypeParameters { get; set; }

        /// <summary>
        /// Gets the timestamp when this method information was cached.
        /// </summary>
        public DateTime CachedDateTime { get; set; }

        /// <summary>
        /// Gets the script file path associated with this method.
        /// </summary>
        public string ScriptFilePath { get; set; }

        /// <summary>
        /// Gets the parameter type information as a dictionary for easy lookup.
        /// </summary>
        public Dictionary<string, Type> ParameterTypeMap { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="MethodInformationCache"/> class.
        /// </summary>
        /// <param name="methodInfo">The method information.</param>
        /// <param name="scriptFilePath">The script file path.</param>
        public MethodInformationCache(MethodInfo methodInfo, string scriptFilePath = null)
        {
            this.MethodInfo = methodInfo;
            this.MethodName = methodInfo.Name;
            this.DeclaringType = methodInfo.DeclaringType;
            this.ReturnType = methodInfo.ReturnType;
            this.Parameters = methodInfo.GetParameters();
            this.IsStatic = methodInfo.IsStatic;
            this.IsGeneric = methodInfo.IsGenericMethodDefinition;
            this.GenericTypeParameters = methodInfo.GetGenericArguments();
            this.ScriptFilePath = scriptFilePath;
            this.CachedDateTime = DateTime.UtcNow;

            // Build the fully qualified name
            this.FullyQualifiedName = this.BuildFullyQualifiedName();

            // Determine if the method is async
            this.IsAsync = this.DetermineIfAsync();

            // Build parameter type map
            this.ParameterTypeMap = this.BuildParameterTypeMap();
        }

        /// <summary>
        /// Builds the fully qualified name for the method.
        /// </summary>
        /// <returns>The fully qualified method name.</returns>
        private string BuildFullyQualifiedName()
        {
            if (this.DeclaringType != null)
            {
                return $"{this.DeclaringType.FullName}.{this.MethodName}";
            }

            return this.MethodName;
        }

        /// <summary>
        /// Determines if the method is async (returns Task or Task{T}).
        /// </summary>
        /// <returns>True if the method is async; otherwise, false.</returns>
        private bool DetermineIfAsync()
        {
            if (this.ReturnType == typeof(System.Threading.Tasks.Task))
            {
                return true;
            }

            if (this.ReturnType.IsGenericType &&
                this.ReturnType.GetGenericTypeDefinition() == typeof(System.Threading.Tasks.Task<>))
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Builds a map of parameter names to their types for quick lookup.
        /// </summary>
        /// <returns>A dictionary mapping parameter names to types.</returns>
        private Dictionary<string, Type> BuildParameterTypeMap()
        {
            var parameterTypeMap = new Dictionary<string, Type>(StringComparer.OrdinalIgnoreCase);

            if (this.Parameters != null && this.Parameters.Length > 0)
            {
                foreach (var parameter in this.Parameters)
                {
                    parameterTypeMap[parameter.Name] = parameter.ParameterType;
                }
            }

            return parameterTypeMap;
        }

        /// <summary>
        /// Gets a string representation of the method information.
        /// </summary>
        /// <returns>A string representation of the method information.</returns>
        public override string ToString()
        {
            var parameterString = this.Parameters != null && this.Parameters.Length > 0
                ? string.Join(", ", Array.ConvertAll(this.Parameters, p => $"{p.ParameterType.Name} {p.Name}"))
                : "no parameters";

            return $"{this.FullyQualifiedName}({parameterString}) -> {this.ReturnType.Name} [Async: {this.IsAsync}, Static: {this.IsStatic}, Cached: {this.CachedDateTime:O}]";
        }
    }
}
