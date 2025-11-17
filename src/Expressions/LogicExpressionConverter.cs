//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Expressions
{
    using System.Diagnostics;
    using System.Linq.Expressions;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    internal class LogicConverter : VisitorBase<LogicAppExpressionNode, object>
    {
        private object GetMemberValue(MemberInfo member, object instance)
        {
            return member switch
            {
                PropertyInfo prop => prop.GetValue(instance),
                FieldInfo field => field.GetValue(instance),
                _ => throw new ArgumentException($"Member type {member.GetType()} not supported", nameof(member))
            };
        }


        // Helper method to check if an object implements a generic interface
        private static bool ImplementsGenericInterface(Type type, Type genericInterfaceType)
        { 
            Console.WriteLine($"TYPETYPE {type.Name} {genericInterfaceType.Name}");
            // Check if the type itself is the generic interface
            if (type.IsGenericType && type.GetGenericTypeDefinition() == genericInterfaceType)
                return true;
            return type.GetInterfaces().Any(i =>
                i.IsGenericType && i.GetGenericTypeDefinition() == genericInterfaceType);
        }

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
            Console.WriteLine($"Property name: {name}");

            return name;
        }

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

        public override LogicAppExpressionNode Visit(ParameterExpression e, object p)
        {
            // Custom logic for ParameterExpression
            Console.WriteLine($"Visiting ParameterExpression: {e.Name} ({e.Type})");

            return new LiteralNode
            {
                Type = e.Type,
                Value = null
            };
        }

        public override LogicAppExpressionNode Visit(NewArrayExpression e, object p)
        {
            Console.WriteLine($"Visiting NewArrayExpression: ({e.Type})");

            return new ArrayNode
            {
                Items = e.Expressions.Select(expr => expr.Visit(this, p)).ToArray()
            };
        }

        public override LogicAppExpressionNode Visit(MemberExpression e, object p)
        {
            if (e.Expression == null && e.Member is PropertyInfo propertyInfo)
            {
                object instance = null;

                var value = propertyInfo.GetValue(instance);
                Console.WriteLine($"Property value: {value}");
                return new LiteralNode
                {
                    Type = value?.GetType() ?? propertyInfo.PropertyType,
                    Value = value
                };
            }

            // Custom logic for MemberExpression
            var obj = e.Expression.Visit(this, p);
            Console.WriteLine($"Visiting MemberExpression: {e.Member.Name} -> {e.Member.DeclaringType?.Name} ({obj.Type})");

            var litNode = obj as LiteralNode;

            if (litNode != null && IsClosureType(obj.Type))
            {
                Console.WriteLine($"Detected closure type: {obj.Type.Name}");
                var value = this.GetMemberValue(e.Member, litNode.Value);
                return new LiteralNode
                {
                    Type = value.GetType(),
                    Value = value
                };
            }
            else if (litNode != null && obj.Type.GetInterfaces().Any( type => type == typeof(IWorkflowBuilder)))
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
            else if (litNode != null && ImplementsGenericInterface(obj.Type, typeof(IOutputWorkflowAction<>)))
            {
                if (e.Member.Name != "Body")
                {
                    throw new NotImplementedException();
                }
                var actionName = ((IWorkflowAction)litNode.Value).Name;
                Console.WriteLine("^^^^ Action Name: " + actionName);

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
            else if (litNode != null && ImplementsGenericInterface(obj.Type, typeof(IAgentToolBuilder<>)))
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
                    Console.WriteLine($"Detected partial function call: {partialCall.FunctionName}");
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

        public override LogicAppExpressionNode Visit(ConstantExpression e, object p)
        {
            // Custom logic for ConstantExpression
            Console.WriteLine($"Visiting ConstantExpression: {e.Value}");

            return new LiteralNode
            {
                Type = e.Type,
                Value = e.Value
            };
        }

        public override LogicAppExpressionNode Visit(BinaryExpression e, object p)
        {
            // Custom logic for BinaryExpression
            Console.WriteLine($"Visiting BinaryExpression: {e.NodeType}");
            var left = e.Left.Visit(this, p);
            var right = e.Right.Visit(this, p);
            Console.WriteLine($"Left: {left.Type}, Right: {right.Type}");

            if (e.NodeType == ExpressionType.ArrayIndex)
            {
                if (!left.Type.IsArray)
                {
                    throw new NotImplementedException();
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

        public override LogicAppExpressionNode Visit(UnaryExpression e, object p)
        {
            // Custom logic for UnaryExpression
            Console.WriteLine($"Visiting UnaryExpression: {e.NodeType}");
            var operand = e.Operand.Visit(this, p);
            Console.WriteLine($"Operand: {operand.Type}");

            switch (e.NodeType)
            {
                case ExpressionType.Convert:
                    return operand; // No conversion needed, just return the operand

                default:
                    throw new NotImplementedException($"Unary operation {e.NodeType} not implemented for type {operand.Type.Name} -> {e.Type.Name}");
            }
        }

        public override LogicAppExpressionNode Visit(MethodCallExpression e, object p)
        {
            // Custom logic for MethodCallExpression
            Console.WriteLine($"Visiting MethodCallExpression: {e.Method.Name} ({e.Method.DeclaringType?.Name})");
            var instance = e.Object?.Visit(this, p);
            var args = e.Arguments.Select(arg => arg.Visit(this, p)).ToArray();

            var concat = typeof(string).GetMethod("Concat", [ typeof(string), typeof(string) ]);
            var concat3 = typeof(string).GetMethod("Concat", [ typeof(string), typeof(string), typeof(string) ]);
            var concatArray = typeof(string).GetMethod("Concat", new[] { typeof(string[]) });

            var format1 = typeof(string).GetMethod("Format", [ typeof(string), typeof(object) ]);
            var format2 = typeof(string).GetMethod("Format", [ typeof(string), typeof(object), typeof(object) ]);
            var format3 = typeof(string).GetMethod("Format", [ typeof(string), typeof(object), typeof(object), typeof(object) ]);
            var formatArray = typeof(string).GetMethod("Format", new[] { typeof(string), typeof(object[]) });

            var toString = typeof(object).GetMethod("ToString", Type.EmptyTypes);

            if (e.Method == concat || e.Method == concat3)
            {
                return new FunctionCallNode
                {
                    FunctionName = "concat",
                    Arguments = args
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
                return instance;
            }
            else
            {
                throw new NotImplementedException($"Can't convert call to method {e.Method}");
            }
        }

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

                Console.WriteLine($"Format portion: {beforePortion} {argIndex} {args[argIndex]}");

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

        private static string SelectBinaryFunction(ExpressionType nodeType, MethodInfo method, Type left, Type right)
        {
            Console.WriteLine($"Selecting binary function for {nodeType} with method {method?.Name} and types {left?.Name}, {right?.Name}");

            if ((nodeType, left, right) == (ExpressionType.Add, typeof(int), typeof(int)))
            {
                return "add";
            }
            else if ((nodeType, method.Name) == (ExpressionType.Add, "Concat"))
            {
                // LA Expressions are pretty loose with typing, as long as it's concat we'll concatenate it come hell or high water
                return "concat";
            }
            throw new NotImplementedException($"Binary operation {nodeType} not implemented for types {left.Name} and {right.Name} ({method})");
        }

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
    }
}
