//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Expressions
{
    using System.Diagnostics;
    using System.Linq.Expressions;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using Microsoft.Azure.Workflows.Sdk.Expressions;

    /// <summary>
    /// Converts LINQ expressions to logic app expression nodes.
    /// </summary>
    internal class LogicConverter : VisitorBase<LogicAppExpressionNode, object>
    {
        /// <summary>
        /// Gets the value of a member from an object instance.
        /// </summary>
        /// <param name="member">The member to get the value from.</param>
        /// <param name="instance">The object instance.</param>
        private object GetMemberValue(MemberInfo member, object instance)
        {
            return member switch
            {
                PropertyInfo prop => prop.GetValue(instance),
                FieldInfo field => field.GetValue(instance),
                _ => throw new ArgumentException($"Member type {member.GetType()} not supported", nameof(member))
            };
        }

        /// <summary>
        /// Checks if an object type implements a generic interface.
        /// </summary>
        /// <param name="type">The type to check.</param>
        /// <param name="genericInterfaceType">The generic interface type to match.</param>
        private static bool ImplementsGenericInterface(Type type, Type genericInterfaceType)
        {
            // Check if the type itself is the generic interface
            if (type.IsGenericType && type.GetGenericTypeDefinition() == genericInterfaceType)
                return true;
            return type.GetInterfaces().Any(i =>
                i.IsGenericType && i.GetGenericTypeDefinition() == genericInterfaceType);
        }

        /// <summary>
        /// Gets the property name from a member, checking for JSON property attributes.
        /// </summary>
        /// <param name="obj">The object instance.</param>
        /// <param name="member">The member to get the name from.</param>
        private static string GetPropertyName(object obj, MemberInfo member)
        {
            var name = member.Name;
            var jsonPropAttr = member.GetCustomAttribute(typeof(Newtonsoft.Json.JsonPropertyAttribute));
            if (jsonPropAttr != null)
            {
                var propName = (string)jsonPropAttr.GetType().GetProperty("PropertyName")?.GetValue(jsonPropAttr);
                if (!string.IsNullOrEmpty(propName))
                    name = propName;
            }

            return name;
        }

        /// <summary>
        /// Determines if a type is a compiler-generated closure type.
        /// </summary>
        /// <param name="type">The type to check.</param>
        private static bool IsClosureType(Type type)
        {
            if (type == null) return false;

            // Check if it's compiler generated
            var isCompilerGenerated = type.GetCustomAttribute<CompilerGeneratedAttribute>() != null;

            // Check if name contains closure markers
            var hasClosureName = type.Name.Contains("<>") ||
                                type.Name.StartsWith("<>c__DisplayClass");

            // Check if it's a nested type
            var isNested = type.IsNested;

            return isCompilerGenerated && hasClosureName && isNested;
        }

        /// <summary>
        /// Gets the type of a member.
        /// </summary>
        /// <param name="member">The member to get the type from.</param>
        private static Type GetMemberType(MemberInfo member)
        {
            return member switch
            {
                PropertyInfo prop => prop.PropertyType,
                FieldInfo field => field.FieldType,
                MethodInfo method => method.ReturnType,
                EventInfo evt => evt.EventHandlerType,
                _ => throw new ArgumentException($"Member type {member.GetType()} not supported", nameof(member))
            };
        }

        /// <summary>
        /// Visits a parameter expression.
        /// </summary>
        /// <param name="e">The parameter expression to visit.</param>
        /// <param name="p">Additional parameter (not used).</param>
        public override LogicAppExpressionNode Visit(ParameterExpression e, object p)
        {
            return new LiteralNode
            {
                Type = e.Type,
                Value = null
            };
        }

        /// <summary>
        /// Visits a conditional expression.
        /// </summary>
        /// <param name="e">The conditional expression to visit.</param>
        /// <param name="p">Additional parameter (not used).</param>
        public override LogicAppExpressionNode Visit(ConditionalExpression e, object p)
        {
            var test = e.Test.Visit(this, p);
            var ifTrue = e.IfTrue.Visit(this, p);
            var ifFalse = e.IfFalse.Visit(this, p);

            return new FunctionCallNode
            {
                FunctionName = "if",
                Arguments = [test, ifTrue, ifFalse]
            };
        }

        /// <summary>
        /// Visits a new array expression.
        /// </summary>
        /// <param name="e">The new array expression to visit.</param>
        /// <param name="p">Additional parameter (not used).</param>
        public override LogicAppExpressionNode Visit(NewArrayExpression e, object p)
        {
            return new ArrayNode
            {
                Items = e.Expressions.Select(expr => expr.Visit(this, p)).ToArray()
            };
        }

        /// <summary>
        /// Visits a member expression.
        /// </summary>
        /// <param name="e">The member expression to visit.</param>
        /// <param name="p">Additional parameter (not used).</param>
        public override LogicAppExpressionNode Visit(MemberExpression e, object p)
        {
            if (e.Expression == null && e.Member is PropertyInfo propertyInfo)
            {
                object instance = null;

                var value = propertyInfo.GetValue(instance);
                return new LiteralNode
                {
                    Type = value?.GetType() ?? propertyInfo.PropertyType,
                    Value = value
                };
            }

            // Custom logic for MemberExpression
            var obj = e.Expression.Visit(this, p);

            var litNode = obj as LiteralNode;

            if (litNode != null && IsClosureType(obj.Type))
            {
                var value = this.GetMemberValue(e.Member, litNode.Value);
                return new LiteralNode
                {
                    Type = value.GetType(),
                    Value = value
                };
            }
            else if (litNode != null && ImplementsGenericInterface(obj.Type, typeof(IOutputWorkflowTrigger<>)))
            {
                if (e.Member.Name.Equals("TriggerOutput"))
                {
                    return new NullableNode
                    {
                        Inner = new FunctionCallNode
                        {
                            FunctionName = "triggerOutputs"
                        }
                    };
                }

                throw new NotImplementedException();
            }
            else if (litNode != null && ImplementsGenericInterface(obj.Type, typeof(IBodyWorkflowTrigger<>)))
            {
                if (e.Member.Name.Equals("TriggerBody"))
                {
                    return new NullableNode
                    {
                        Inner = new FunctionCallNode
                        {
                            FunctionName = "triggerBody"
                        }
                    };
                }

                throw new NotImplementedException();
            }
            else if (litNode != null && ImplementsGenericInterface(obj.Type, typeof(IBodyWorkflowAction<>)))
            {
                if (e.Member.Name != "Body")
                {
                    throw new NotImplementedException();
                }
                var actionName = ((IWorkflowAction)litNode.Value).Name;

                return new FunctionCallNode
                {
                    FunctionName = "body",
                    Arguments = [
                        new LiteralNode
                        {
                            Type = typeof(string),
                            Value = actionName
                        }
                    ]
                };
            }
            else if (litNode != null && ImplementsGenericInterface(obj.Type, typeof(IOutputWorkflowAction<>)))
            {
                if (e.Member.Name != "Output")
                {
                    throw new NotImplementedException();
                }
                var actionName = ((IWorkflowAction)litNode.Value).Name;

                return new FunctionCallNode
                {
                    FunctionName = "outputs",
                    Arguments = [
                        new LiteralNode
                        {
                            Type = typeof(string),
                            Value = actionName
                        }
                    ]
                };
            }
            else if (litNode != null && ImplementsGenericInterface(obj.Type, typeof(IAgentToolParameters<>)))
            {
                if (e.Member.Name != "Parameters")
                {
                    throw new NotImplementedException();
                }

                return new PartialFunctionCallNode
                {
                    FunctionName = "agentparameters"
                };
            }
            else if (litNode == null)
            {
                var partialCall = obj as PartialFunctionCallNode;

                if (partialCall != null)
                {
                    return new FunctionCallNode
                    {
                        FunctionName = partialCall.FunctionName,
                        Type = GetMemberType(e.Member),
                        Arguments = [
                            new LiteralNode
                            {
                                Type = typeof(string),
                                Value = GetPropertyName(litNode?.Value, e.Member)
                            }
                        ]
                    };
                }

                return new MemberAccessNode
                {
                    Target = obj,
                    Type = GetMemberType(e.Member),
                    MemberName = GetPropertyName(litNode?.Value, e.Member)
                };
            }

            throw new NotImplementedException("MemberExpression handling not implemented yet.");
        }

        /// <summary>
        /// Visits a constant expression.
        /// </summary>
        /// <param name="e">The constant expression to visit.</param>
        /// <param name="p">Additional parameter (not used).</param>
        public override LogicAppExpressionNode Visit(ConstantExpression e, object p)
        {
            return new LiteralNode
            {
                Type = e.Type,
                Value = e.Value
            };
        }

        /// <summary>
        /// Visits a binary expression.
        /// </summary>
        /// <param name="e">The binary expression to visit.</param>
        /// <param name="p">Additional parameter (not used).</param>
        public override LogicAppExpressionNode Visit(BinaryExpression e, object p)
        {
            // Custom logic for BinaryExpression
            var left = e.Left.Visit(this, p);
            var right = e.Right.Visit(this, p);

            if (e.NodeType == ExpressionType.ArrayIndex)
            {
                if (!left.Type.IsArray)
                {
                    throw new NotImplementedException();
                }

                if (right is LiteralNode n && n.Type == typeof(int) && (int)n.Value == 0)
                {
                    return new FunctionCallNode
                    {
                        FunctionName = "first",
                        Arguments = [left]
                    };
                }

                return new IndexNode
                {
                    Target = left,
                    Index = right,
                    Type = left.Type.GetElementType()
                };
            }

            var function = SelectBinaryFunction(e.NodeType, e.Method, left.Type, right.Type);
            return new FunctionCallNode
            {
                FunctionName = function,
                Arguments = [left, right]
            };
        }

        /// <summary>
        /// Visits a unary expression.
        /// </summary>
        /// <param name="e">The unary expression to visit.</param>
        /// <param name="p">Additional parameter (not used).</param>
        public override LogicAppExpressionNode Visit(UnaryExpression e, object p)
        {
            // Custom logic for UnaryExpression
            var operand = e.Operand.Visit(this, p);

            switch (e.NodeType)
            {
                case ExpressionType.Convert:
                    return operand; // No conversion needed, just return the operand

                default:
                    throw new NotImplementedException($"Unary operation {e.NodeType} not implemented for type {operand.Type.Name} -> {e.Type.Name}");
            }
        }

        /// <summary>
        /// Visits a method call expression.
        /// </summary>
        /// <param name="e">The method call expression to visit.</param>
        /// <param name="p">Additional parameter (not used).</param>
        public override LogicAppExpressionNode Visit(MethodCallExpression e, object p)
        {
            // Custom logic for MethodCallExpression
            var instance = e.Object?.Visit(this, p);
            var args = e.Arguments.Select(arg => arg.Visit(this, p)).ToArray();

            var concat = typeof(string).GetMethod("Concat", [typeof(string), typeof(string)]);
            var concat3 = typeof(string).GetMethod("Concat", [typeof(string), typeof(string), typeof(string)]);
            var concatArray = typeof(string).GetMethod("Concat", new[] { typeof(string[]) });

            var format1 = typeof(string).GetMethod("Format", [typeof(string), typeof(object)]);
            var format2 = typeof(string).GetMethod("Format", [typeof(string), typeof(object), typeof(object)]);
            var format3 = typeof(string).GetMethod("Format", [typeof(string), typeof(object), typeof(object), typeof(object)]);
            var formatArray = typeof(string).GetMethod("Format", new[] { typeof(string), typeof(object[]) });

            var toString = typeof(object).GetMethod("ToString", Type.EmptyTypes);

            // Get IDictionary<string, string> indexer (get_Item) method
            var dictType = typeof(IDictionary<string, string>);
            var getItemMethod = dictType.GetProperty("Item")?.GetGetMethod();

            if (e.Method.DeclaringType == typeof(WorkflowFunctions) && e.Method.Name == "ToJson")
            {
                return new FunctionCallNode
                {
                    FunctionName = "json",
                    Arguments = args
                };
            }

            if (e.Method == concat || e.Method == concat3)
            {
                return new FunctionCallNode
                {
                    FunctionName = "concat",
                    Arguments = args
                };
            }
            else if (e.Method.Name == "get_Item")
            {
                var memberName = args[0] as LiteralNode;
                if (memberName == null)
                {
                    throw new NotImplementedException($"Member name must be a literal");
                }

                return new MemberAccessNode
                {
                    MemberName = (string)memberName.Value,
                    Target = instance
                };
            }
            else if (e.Method == concatArray)
            {
                Debug.Assert(args.Length == 1 && args[0] is ArrayNode);

                var argArray = (ArrayNode)args[0];

                return new FunctionCallNode
                {
                    FunctionName = "concat",
                    Arguments = argArray.Items
                };
            }
            else if (e.Method == format1 || e.Method == format2 || e.Method == format3)
            {
                var formatString = args[0] as LiteralNode;
                if (formatString == null)
                {
                    throw new NotImplementedException($"Format string must be a literal");
                }

                var copiedArgs = new LogicAppExpressionNode[args.Length - 1];
                Array.Copy(args, 1, copiedArgs, 0, args.Length - 1);
                return ConvertFormat((string)formatString.Value, copiedArgs);
            }
            else if (e.Method == formatArray)
            {
                var array = (ArrayNode)args[1];

                var formatString = args[0] as LiteralNode;
                if (formatString == null)
                {
                    throw new NotImplementedException($"Format string must be a literal");
                }

                return ConvertFormat((string)formatString.Value, array.Items);
            }
            else if (e.Method == toString)
            {
                // Tostring is a noop
                return new FunctionCallNode
                {
                    FunctionName = "string",
                    Arguments = [instance]
                };
            }
            else
            {
                throw new NotImplementedException($"Can't convert call to method {e.Method.DeclaringType} {e.Method}: {e}");
            }
        }

        /// <summary>
        /// Converts a format string and arguments into a concat function call.
        /// </summary>
        /// <param name="formatString">The format string to convert.</param>
        /// <param name="args">The format arguments.</param>
        private static FunctionCallNode ConvertFormat(string formatString, LogicAppExpressionNode[] args)
        {
            var concatArgs = new List<LogicAppExpressionNode>();

            int searchStart = 0;
            while (true)
            {
                int formatStart = formatString.IndexOf("{", searchStart);
                if (formatStart < 0)
                {
                    break;
                }

                var indexEnd = formatString.IndexOf("}", formatStart);
                var formatPortion = formatString.Substring(formatStart + 1, indexEnd - formatStart - 1);
                if (!formatPortion.All(Char.IsDigit))
                {
                    throw new FormatException("The format portion must be a number, colon formatting not supported.");
                }

                var beforePortion = formatString.Substring(searchStart, formatStart - searchStart);
                var argIndex = int.Parse(formatPortion);

                if (!string.IsNullOrEmpty(beforePortion))
                {
                    concatArgs.Add(new LiteralNode
                    {
                        Type = typeof(string),
                        Value = beforePortion
                    });

                    concatArgs.Add(args[argIndex]);
                }
                else
                {
                    concatArgs.Add(args[argIndex]);
                }

                searchStart = indexEnd + 1;
            }

            var remainingStr = formatString.Substring(searchStart);
            if (!string.IsNullOrEmpty(remainingStr))
            {
                concatArgs.Add(new LiteralNode
                {
                    Type = typeof(string),
                    Value = remainingStr
                });
            }

            return new FunctionCallNode
            {
                FunctionName = "concat",
                Arguments = concatArgs.ToArray()
            };
        }

        /// <summary>
        /// Selects the appropriate binary function name based on the expression type and operand types.
        /// </summary>
        /// <param name="nodeType">The binary expression type.</param>
        /// <param name="method">The method information of the binary operation.</param>
        /// <param name="left">The left operand type.</param>
        /// <param name="right">The right operand type.</param>
        private static string SelectBinaryFunction(ExpressionType nodeType, MethodInfo method, Type left, Type right)
        {
            if ((nodeType, left, right) == (ExpressionType.Add, typeof(int), typeof(int)))
            {
                return "add";
            }
            else if ((nodeType, method.Name) == (ExpressionType.Add, "Concat"))
            {
                // LA Expressions are pretty loose with typing, as long as it's concat we'll concatenate it come hell or high water
                return "concat";
            }
            else if (nodeType == ExpressionType.Equal)
            {
                return "equals";
            }
            throw new NotImplementedException($"Binary operation {nodeType} not implemented for types {left.Name} and {right.Name} ({method})");
        }

        /// <summary>
        /// Visits a generic expression, with special handling for Uri construction.
        /// </summary>
        /// <param name="e">The expression to visit.</param>
        /// <param name="p">Additional parameter (not used).</param>
        public override LogicAppExpressionNode Visit(Expression e, object p)
        {
            // If the expression's type is Uri, try to resolve its value and return as string
            if (e is NewExpression newExpr && newExpr.Type == typeof(Uri))
            {
                // Use LINQ to evaluate constructor arguments and extract their values
                var argValues = newExpr.Arguments
                    .Select(arg =>
                    {
                        var argNode = arg.Visit(this, p);
                        if (argNode is LiteralNode literal)
                        {
                            return literal.Value;
                        }
                        throw new NotImplementedException("Only literal arguments are supported for Uri construction.");
                    })
                    .ToArray();

                // Construct the Uri using reflection
                var uri = (Uri)Activator.CreateInstance(typeof(Uri), argValues);

                // Return as string
                return new LiteralNode
                {
                    Type = typeof(string),
                    Value = uri.ToString()
                };
            }

            throw new NotImplementedException($"Visit method not implemented for expression type: {e.NodeType}");
        }

        /// <summary>
        /// Visits a member initialization expression.
        /// </summary>
        /// <param name="e">The member initialization expression to visit.</param>
        /// <param name="p">Additional parameter (not used).</param>
        public override LogicAppExpressionNode Visit(MemberInitExpression e, object p)
        {
            // Build a JSON object string using concat
            // Format: {"prop1": value1, "prop2": value2, ...}
            var concatArgs = new List<LogicAppExpressionNode>();

            concatArgs.Add(new LiteralNode
            {
                Type = typeof(string),
                Value = "{"
            });

            var bindings = e.Bindings.OfType<MemberAssignment>().ToList();
            for (int i = 0; i < bindings.Count; i++)
            {
                var binding = bindings[i];
                var propertyName = GetPropertyName(null, binding.Member);
                var valueNode = binding.Expression.Visit(this, p);

                // Add property name with quotes
                concatArgs.Add(new LiteralNode
                {
                    Type = typeof(string),
                    Value = $"\"{propertyName}\":"
                });

                // Wrap string values in quotes, others get converted directly
                var memberType = GetMemberType(binding.Member);
                if (memberType == typeof(string))
                {
                    concatArgs.Add(new LiteralNode
                    {
                        Type = typeof(string),
                        Value = "\""
                    });
                    concatArgs.Add(valueNode);
                    concatArgs.Add(new LiteralNode
                    {
                        Type = typeof(string),
                        Value = "\""
                    });
                }
                else
                {
                    concatArgs.Add(valueNode);
                }

                // Add comma separator if not the last property
                if (i < bindings.Count - 1)
                {
                    concatArgs.Add(new LiteralNode
                    {
                        Type = typeof(string),
                        Value = ","
                    });
                }
            }

            concatArgs.Add(new LiteralNode
            {
                Type = typeof(string),
                Value = "}"
            });

            return new FunctionCallNode
            {
                FunctionName = "concat",
                Type = e.Type,
                Arguments = concatArgs.ToArray()
            };
        }
    }
}
