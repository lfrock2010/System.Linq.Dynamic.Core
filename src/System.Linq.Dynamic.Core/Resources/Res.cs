 
using System.Reflection;

namespace System.Linq.Dynamic.Core;

/// <summary>
/// Custom strongly-typed resource class with compatibility with .netstandard 1.3 and uap, for looking up localized strings
/// </summary>
internal static partial class Res 
{        
    private static global::System.Resources.ResourceManager? resourceManager;
    
    /// <summary>
    ///   Returns the cached ResourceManager instance used by this class.
    /// </summary>  
    [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
    public static global::System.Resources.ResourceManager ResourceManager 
    {
        get 
        {
            if (resourceManager is null) 
            {
#if !EF && !EFCORE
                //Note: Important, typeof(Res).GetTypeInfo().Assembly is used instead of typeof(Res).Assembly for compatibility with .netstandard 1.3 and uap
                resourceManager = new global::System.Resources.ResourceManager("System.Linq.Dynamic.Core.Resources.Res", typeof(Res).GetTypeInfo().Assembly);
#else                
                Assembly dynamicCoreAssembly = typeof(DynamicClass).GetTypeInfo().Assembly;
                Type resType = dynamicCoreAssembly.GetType($"{typeof(Res).Namespace}.{nameof(Res)}");

                PropertyInfo propertyInfo = resType.GetProperty(nameof(ResourceManager), BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static);                
                resourceManager = (global::System.Resources.ResourceManager)propertyInfo.GetValue(null, new object[0]);
#endif
            }

            return resourceManager;
        }
    }
    
    /// <summary>
    ///   Overrides the current thread's CurrentUICulture property for all
    ///   resource lookups using this strongly typed resource class.
    /// </summary>        
    [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
    public static global::System.Globalization.CultureInfo? Culture 
    {
        get;
        set;
    }
    
    /// <summary>
    /// Looks up a localized string similar to "Ambiguous invocation of Ambiguous invocation of '{0}' constructor".
    /// </summary>
    public static string AmbiguousConstructorInvocation => ResourceManager.GetString("AmbiguousConstructorInvocation", Culture);
    
    /// <summary>
    /// Looks up a localized string similar to "Ambiguous invocation of Ambiguous invocation of indexer in type '{0}'".
    /// </summary>
    public static string AmbiguousIndexerInvocation => ResourceManager.GetString("AmbiguousIndexerInvocation", Culture);
    
    /// <summary>
    /// Looks up a localized string similar to "Ambiguous invocation of Ambiguous invocation of method '{0}' in type '{1}'".
    /// </summary>
    public static string AmbiguousMethodInvocation => ResourceManager.GetString("AmbiguousMethodInvocation", Culture);
    
    /// <summary>
    /// Looks up a localized string similar to "Ambiguous invocation of Argument list incompatible with lambda expression".
    /// </summary>
    public static string ArgsIncompatibleWithLambda => ResourceManager.GetString("ArgsIncompatibleWithLambda", Culture);
    
    /// <summary>
    /// Looks up a localized string similar to "Ambiguous invocation of Binary character expected".
    /// </summary>
    public static string BinaryCharExpected => ResourceManager.GetString("BinaryCharExpected", Culture);
    
    /// <summary>
    /// Looks up a localized string similar to "Ambiguous invocation of Both of the types '{0}' and '{1}' convert to the other".
    /// </summary>
    public static string BothTypesConvertToOther => ResourceManager.GetString("BothTypesConvertToOther", Culture);
    
    /// <summary>
    /// Looks up a localized string similar to "Ambiguous invocation of A value of type '{0}' cannot be converted to type '{1}'".
    /// </summary>
    public static string CannotConvertValue => ResourceManager.GetString("CannotConvertValue", Culture);
    
    /// <summary>
    /// Looks up a localized string similar to "Ambiguous invocation of Indexing of multi-dimensional arrays is not supported".
    /// </summary>
    public static string CannotIndexMultiDimArray => ResourceManager.GetString("CannotIndexMultiDimArray", Culture);
    
    /// <summary>
    /// Looks up a localized string similar to "Ambiguous invocation of ']' expected".
    /// </summary>
    public static string CloseBracketExpected => ResourceManager.GetString("CloseBracketExpected", Culture);
    
    /// <summary>
    /// Looks up a localized string similar to "Ambiguous invocation of ']' or ',' expected".
    /// </summary>
    public static string CloseBracketOrCommaExpected => ResourceManager.GetString("CloseBracketOrCommaExpected", Culture);
    
    /// <summary>
    /// Looks up a localized string similar to "Ambiguous invocation of ')' or ',' expected".
    /// </summary>
    public static string CloseParenOrCommaExpected => ResourceManager.GetString("CloseParenOrCommaExpected", Culture);
    
    /// <summary>
    /// Looks up a localized string similar to "Ambiguous invocation of ')' or operator expected".
    /// </summary>
    public static string CloseParenOrOperatorExpected => ResourceManager.GetString("CloseParenOrOperatorExpected", Culture);
    
    /// <summary>
    /// Looks up a localized string similar to "Ambiguous invocation of ':' expected".
    /// </summary>
    public static string ColonExpected => ResourceManager.GetString("ColonExpected", Culture);
    
    /// <summary>
    /// Looks up a localized string similar to "Ambiguous invocation of Digit expected".
    /// </summary>
    public static string DigitExpected => ResourceManager.GetString("DigitExpected", Culture);
    
    /// <summary>
    /// Looks up a localized string similar to "Ambiguous invocation of '.' expected".
    /// </summary>
    public static string DotExpected => ResourceManager.GetString("DotExpected", Culture);
    
    /// <summary>
    /// Looks up a localized string similar to "Ambiguous invocation of '.' or '(' expected".
    /// </summary>
    public static string DotOrOpenParenExpected => ResourceManager.GetString("DotOrOpenParenExpected", Culture);
    
    /// <summary>
    /// Looks up a localized string similar to "Ambiguous invocation of '.' or '(' or string literal expected".
    /// </summary>
    public static string DotOrOpenParenOrStringLiteralExpected => ResourceManager.GetString("DotOrOpenParenOrStringLiteralExpected", Culture);
    
    /// <summary>
    /// Looks up a localized string similar to "Ambiguous invocation of The identifier '{0}' was defined more than once".
    /// </summary>
    public static string DuplicateIdentifier => ResourceManager.GetString("DuplicateIdentifier", Culture);
    
    /// <summary>
    /// Looks up a localized string similar to "Ambiguous invocation of Dynamic / ExpandoObject is not supported in .NET 3.5, UAP and .NETStandard 1.3".
    /// </summary>
    public static string DynamicExpandoObjectIsNotSupported => ResourceManager.GetString("DynamicExpandoObjectIsNotSupported", Culture);
    
    /// <summary>
    /// Looks up a localized string similar to "Ambiguous invocation of Enum type '{0}' not found".
    /// </summary>
    public static string EnumTypeNotFound => ResourceManager.GetString("EnumTypeNotFound", Culture);
    
    /// <summary>
    /// Looks up a localized string similar to "Ambiguous invocation of Enum value expected".
    /// </summary>
    public static string EnumValueExpected => ResourceManager.GetString("EnumValueExpected", Culture);
    
    /// <summary>
    /// Looks up a localized string similar to "Ambiguous invocation of Enum value '{0}' is not defined in enum type '{1}'".
    /// </summary>
    public static string EnumValueNotDefined => ResourceManager.GetString("EnumValueNotDefined", Culture);
    
    /// <summary>
    /// Looks up a localized string similar to "Ambiguous invocation of Expression expected".
    /// </summary>
    public static string ExpressionExpected => ResourceManager.GetString("ExpressionExpected", Culture);
    
    /// <summary>
    /// Looks up a localized string similar to "Ambiguous invocation of Expression of type '{0}' expected".
    /// </summary>
    public static string ExpressionTypeMismatch => ResourceManager.GetString("ExpressionTypeMismatch", Culture);
    
    /// <summary>
    /// Looks up a localized string similar to "Ambiguous invocation of The first expression must be of type 'Boolean'".
    /// </summary>
    public static string FirstExprMustBeBool => ResourceManager.GetString("FirstExprMustBeBool", Culture);
    
    /// <summary>
    /// Looks up a localized string similar to "Ambiguous invocation of The '{0}' function requires the {1}argument to be not null and of type {2}.".
    /// </summary>
    public static string FunctionRequiresNotNullArgOfType => ResourceManager.GetString("FunctionRequiresNotNullArgOfType", Culture);
    
    /// <summary>
    /// Looks up a localized string similar to "Ambiguous invocation of The '{0}' function requires one argument".
    /// </summary>
    public static string FunctionRequiresOneArg => ResourceManager.GetString("FunctionRequiresOneArg", Culture);
    
    /// <summary>
    /// Looks up a localized string similar to "Ambiguous invocation of The '{0}' function requires one argument which is not null.".
    /// </summary>
    public static string FunctionRequiresOneNotNullArg => ResourceManager.GetString("FunctionRequiresOneNotNullArg", Culture);
    
    /// <summary>
    /// Looks up a localized string similar to "Ambiguous invocation of The '{0}' function requires 1 or 2 arguments".
    /// </summary>
    public static string FunctionRequiresOneOrTwoArgs => ResourceManager.GetString("FunctionRequiresOneOrTwoArgs", Culture);
    
    /// <summary>
    /// Looks up a localized string similar to "Ambiguous invocation of Hexadecimal character expected".
    /// </summary>
    public static string HexCharExpected => ResourceManager.GetString("HexCharExpected", Culture);
    
    /// <summary>
    /// Looks up a localized string similar to "Ambiguous invocation of Identifier expected".
    /// </summary>
    public static string IdentifierExpected => ResourceManager.GetString("IdentifierExpected", Culture);
    
    /// <summary>
    /// Looks up a localized string similar to "Ambiguous invocation of Identifier implementing interface '{0}' expected".
    /// </summary>
    public static string IdentifierImplementingInterfaceExpected => ResourceManager.GetString("IdentifierImplementingInterfaceExpected", Culture);
    
    /// <summary>
    /// Looks up a localized string similar to "Ambiguous invocation of The 'iif' function requires three arguments".
    /// </summary>
    public static string IifRequiresThreeArgs => ResourceManager.GetString("IifRequiresThreeArgs", Culture);
    
    /// <summary>
    /// Looks up a localized string similar to "Ambiguous invocation of Operator '{0}' incompatible with operand type '{1}'".
    /// </summary>
    public static string IncompatibleOperand => ResourceManager.GetString("IncompatibleOperand", Culture);
    
    /// <summary>
    /// Looks up a localized string similar to "Ambiguous invocation of Operator '{0}' incompatible with operand types '{1}' and '{2}'".
    /// </summary>
    public static string IncompatibleOperands => ResourceManager.GetString("IncompatibleOperands", Culture);
    
    /// <summary>
    /// Looks up a localized string similar to "Ambiguous invocation of Types '{0}' and '{1}' are incompatible".
    /// </summary>
    public static string IncompatibleTypes => ResourceManager.GetString("IncompatibleTypes", Culture);
    
    /// <summary>
    /// Looks up a localized string similar to "Ambiguous invocation of Invalid binary integer literal '{0}'".
    /// </summary>
    public static string InvalidBinaryIntegerLiteral => ResourceManager.GetString("InvalidBinaryIntegerLiteral", Culture);
    
    /// <summary>
    /// Looks up a localized string similar to "Ambiguous invocation of Syntax error '{0}'".
    /// </summary>
    public static string InvalidCharacter => ResourceManager.GetString("InvalidCharacter", Culture);
    
    /// <summary>
    /// Looks up a localized string similar to "Ambiguous invocation of Character literal must contain exactly one character".
    /// </summary>
    public static string InvalidCharacterLiteral => ResourceManager.GetString("InvalidCharacterLiteral", Culture);
    
    /// <summary>
    /// Looks up a localized string similar to "Ambiguous invocation of Array index must be an integer expression".
    /// </summary>
    public static string InvalidIndex => ResourceManager.GetString("InvalidIndex", Culture);
    
    /// <summary>
    /// Looks up a localized string similar to "Ambiguous invocation of Invalid integer literal '{0}'".
    /// </summary>
    public static string InvalidIntegerLiteral => ResourceManager.GetString("InvalidIntegerLiteral", Culture);
    
    /// <summary>
    /// Looks up a localized string similar to "Ambiguous invocation of Invalid integer literal qualifier '{0}'".
    /// </summary>
    public static string InvalidIntegerQualifier => ResourceManager.GetString("InvalidIntegerQualifier", Culture);
    
    /// <summary>
    /// Looks up a localized string similar to "Ambiguous invocation of Invalid real literal '{0}'".
    /// </summary>
    public static string InvalidRealLiteral => ResourceManager.GetString("InvalidRealLiteral", Culture);
    
    /// <summary>
    /// Looks up a localized string similar to "Ambiguous invocation of String '{0}' should have at least {1} characters.".
    /// </summary>
    public static string InvalidStringLength => ResourceManager.GetString("InvalidStringLength", Culture);
    
    /// <summary>
    /// Looks up a localized string similar to "Ambiguous invocation of An escaped string should start with a double (\") or a single (') quote.".
    /// </summary>
    public static string InvalidStringQuoteCharacter => ResourceManager.GetString("InvalidStringQuoteCharacter", Culture);
    
    /// <summary>
    /// Looks up a localized string similar to "Ambiguous invocation of The provider for the source IQueryable doesn't implement IAsyncQueryProvider/IDbAsyncQueryProvider. Only providers that implement IAsyncQueryProvider/IDbAsyncQueryProvider can be used for Entity Framework asynchronous operations.".
    /// </summary>
    public static string IQueryableProviderNotAsync => ResourceManager.GetString("IQueryableProviderNotAsync", Culture);
    
    /// <summary>
    /// Looks up a localized string similar to "Ambiguous invocation of The 'isnull' function requires two arguments".
    /// </summary>
    public static string IsNullRequiresTwoArgs => ResourceManager.GetString("IsNullRequiresTwoArgs", Culture);
    
    /// <summary>
    /// Looks up a localized string similar to "Ambiguous invocation of Method '{0}' in type '{1}' does not return a value".
    /// </summary>
    public static string MethodIsVoid => ResourceManager.GetString("MethodIsVoid", Culture);
    
    /// <summary>
    /// Looks up a localized string similar to "Ambiguous invocation of Methods on type '{0}' are not accessible".
    /// </summary>
    public static string MethodsAreInaccessible => ResourceManager.GetString("MethodsAreInaccessible", Culture);
    
    /// <summary>
    /// Looks up a localized string similar to "Ambiguous invocation of '-' cannot be applied to unsigned integers.".
    /// </summary>
    public static string MinusCannotBeAppliedToUnsignedInteger => ResourceManager.GetString("MinusCannotBeAppliedToUnsignedInteger", Culture);
    
    /// <summary>
    /// Looks up a localized string similar to "Ambiguous invocation of Expression is missing an 'as' clause".
    /// </summary>
    public static string MissingAsClause => ResourceManager.GetString("MissingAsClause", Culture);
    
    /// <summary>
    /// Looks up a localized string similar to "Ambiguous invocation of Neither of the types '{0}' and '{1}' converts to the other".
    /// </summary>
    public static string NeitherTypeConvertsToOther => ResourceManager.GetString("NeitherTypeConvertsToOther", Culture);
    
    /// <summary>
    /// Looks up a localized string similar to "Ambiguous invocation of Using the new operator is not allowed via the ParsingConfig.".
    /// </summary>
    public static string NewOperatorIsNotAllowed => ResourceManager.GetString("NewOperatorIsNotAllowed", Culture);
    
    /// <summary>
    /// Looks up a localized string similar to "Ambiguous invocation of No applicable aggregate method '{0}({1})' exists".
    /// </summary>
    public static string NoApplicableAggregate => ResourceManager.GetString("NoApplicableAggregate", Culture);
    
    /// <summary>
    /// Looks up a localized string similar to "Ambiguous invocation of No applicable indexer exists in type '{0}'".
    /// </summary>
    public static string NoApplicableIndexer => ResourceManager.GetString("NoApplicableIndexer", Culture);
    
    /// <summary>
    /// Looks up a localized string similar to "Ambiguous invocation of No applicable method '{0}' exists in type '{1}'".
    /// </summary>
    public static string NoApplicableMethod => ResourceManager.GetString("NoApplicableMethod", Culture);
    
    /// <summary>
    /// Looks up a localized string similar to "Ambiguous invocation of No 'it' is in scope".
    /// </summary>
    public static string NoItInScope => ResourceManager.GetString("NoItInScope", Culture);
    
    /// <summary>
    /// Looks up a localized string similar to "Ambiguous invocation of No matching constructor in type '{0}'".
    /// </summary>
    public static string NoMatchingConstructor => ResourceManager.GetString("NoMatchingConstructor", Culture);
    
    /// <summary>
    /// Looks up a localized string similar to "Ambiguous invocation of No 'parent' is in scope".
    /// </summary>
    public static string NoParentInScope => ResourceManager.GetString("NoParentInScope", Culture);
    
    /// <summary>
    /// Looks up a localized string similar to "Ambiguous invocation of No 'root' is in scope".
    /// </summary>
    public static string NoRootInScope => ResourceManager.GetString("NoRootInScope", Culture);
    
    /// <summary>
    /// Looks up a localized string similar to "Ambiguous invocation of The 'np' (null-propagation) function requires 1 or 2 arguments".
    /// </summary>
    public static string NullPropagationRequiresCorrectArgs => ResourceManager.GetString("NullPropagationRequiresCorrectArgs", Culture);
    
    /// <summary>
    /// Looks up a localized string similar to "Ambiguous invocation of The 'np' (null-propagation) function requires the first argument to be a MemberExpression, ParameterExpression or MethodCallExpression".
    /// </summary>
    public static string NullPropagationRequiresValidExpression => ResourceManager.GetString("NullPropagationRequiresValidExpression", Culture);
    
    /// <summary>
    /// Looks up a localized string similar to "Ambiguous invocation of '[' expected".
    /// </summary>
    public static string OpenBracketExpected => ResourceManager.GetString("OpenBracketExpected", Culture);
    
    /// <summary>
    /// Looks up a localized string similar to "Ambiguous invocation of '{' expected".
    /// </summary>
    public static string OpenCurlyParenExpected => ResourceManager.GetString("OpenCurlyParenExpected", Culture);
    
    /// <summary>
    /// Looks up a localized string similar to "Ambiguous invocation of '(' expected".
    /// </summary>
    public static string OpenParenExpected => ResourceManager.GetString("OpenParenExpected", Culture);
    
    /// <summary>
    /// Looks up a localized string similar to "Ambiguous invocation of '(' or Identifier expected".
    /// </summary>
    public static string OpenParenOrIdentifierExpected => ResourceManager.GetString("OpenParenOrIdentifierExpected", Culture);
    
    /// <summary>
    /// Looks up a localized string similar to "Ambiguous invocation of When using an out variable, a discard '_' is required.".
    /// </summary>
    public static string OutKeywordRequiresDiscard => ResourceManager.GetString("OutKeywordRequiresDiscard", Culture);
    
    /// <summary>
    /// Looks up a localized string similar to "Ambiguous invocation of {0} (at index {1})".
    /// </summary>
    public static string ParseExceptionFormat => ResourceManager.GetString("ParseExceptionFormat", Culture);
    
    /// <summary>
    /// Looks up a localized string similar to "Ambiguous invocation of Syntax error".
    /// </summary>
    public static string SyntaxError => ResourceManager.GetString("SyntaxError", Culture);
    
    /// <summary>
    /// Looks up a localized string similar to "Ambiguous invocation of {0} expected".
    /// </summary>
    public static string TokenExpected => ResourceManager.GetString("TokenExpected", Culture);
    
    /// <summary>
    /// Looks up a localized string similar to "Ambiguous invocation of Type '{0}' has no nullable form".
    /// </summary>
    public static string TypeHasNoNullableForm => ResourceManager.GetString("TypeHasNoNullableForm", Culture);
    
    /// <summary>
    /// Looks up a localized string similar to "Ambiguous invocation of Type '{0}' not found".
    /// </summary>
    public static string TypeNotFound => ResourceManager.GetString("TypeNotFound", Culture);
    
    /// <summary>
    /// Looks up a localized string similar to "Ambiguous invocation of Unexpected end of string with unclosed string at position {0} near '{1}'.".
    /// </summary>
    public static string UnexpectedUnclosedString => ResourceManager.GetString("UnexpectedUnclosedString", Culture);
    
    /// <summary>
    /// Looks up a localized string similar to "Ambiguous invocation of Unexpected unrecognized escape sequence at position {0} near '{1}'.".
    /// </summary>
    public static string UnexpectedUnrecognizedEscapeSequence => ResourceManager.GetString("UnexpectedUnrecognizedEscapeSequence", Culture);
    
    /// <summary>
    /// Looks up a localized string similar to "Ambiguous invocation of Unknown identifier '{0}'".
    /// </summary>
    public static string UnknownIdentifier => ResourceManager.GetString("UnknownIdentifier", Culture);
    
    /// <summary>
    /// Looks up a localized string similar to "Ambiguous invocation of No property or field '{0}' exists in type '{1}'".
    /// </summary>
    public static string UnknownPropertyOrField => ResourceManager.GetString("UnknownPropertyOrField", Culture);
    
    /// <summary>
    /// Looks up a localized string similar to "Ambiguous invocation of Unterminated string literal".
    /// </summary>
    public static string UnterminatedStringLiteral => ResourceManager.GetString("UnterminatedStringLiteral", Culture);
       
}

