﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SentryOne.UnitTestGenerator.Core.Tests {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class TestClasses {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal TestClasses() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("SentryOne.UnitTestGenerator.Core.Tests.TestClasses", typeof(TestClasses).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to using System.IO;
        ///using System.Windows;
        ///
        ///namespace TestNamespace {
        ///
        ///	public abstract class TestClass1
        ///	{
        ///		protected TestClass1()
        ///		{
        ///
        ///		}
        /// 
        ///		public abstract int SomeMethodShouldNot();
        ///
        ///		public abstract int SomeMethodMaybe(int i);
        ///
        ///		public abstract int SomeMethodMaybe(int i, int j);
        ///
        ///		public abstract int SomeMethodMaybe&lt;T&gt;(int i);
        ///
        ///		public abstract int SomeMethodMaybe&lt;T&gt;(int i, int j);
        ///
        ///	}
        ///
        ///	public abstract class TestClass2 : TestClass1
        ///	{
        ///		protected TestClass2()
        ///		{
        ///
        ///		}
        /// [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string AbstractChainTextFile {
            get {
                return ResourceManager.GetString("AbstractChainTextFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to using System.IO;
        ///using System.Windows;
        ///
        ///namespace TestNamespace {
        ///
        ///
        ///	public abstract class TestClass
        ///	{
        ///		protected TestClass(int intProperty, string value, Stream targetStream)
        ///		{
        ///
        ///		}
        /// 
        ///		public abstract int SomeMethod();
        ///
        ///		public abstract void SomeVoidMethod();
        ///
        ///		protected abstract void SomeProtectedAbstractMethod();
        ///
        ///		public int IntProperty { get; set; }
        ///
        ///		protected int IntGetOnlyProperty { get; private set; }
        ///
        ///		protected string Value { get; set; }
        ///
        ///		protected string Valu [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string AbstractClassTestFile {
            get {
                return ResourceManager.GetString("AbstractClassTestFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to using System.IO;
        ///using System.Windows;
        ///
        ///namespace TestNamespace {
        ///	public abstract class TestClass
        ///	{
        ///		public abstract int SomeMethod();
        ///
        ///		public int IntProperty { get; set; }
        ///
        ///		public abstract string SomePublicAbstractMethod(int p, int r);
        ///	}
        ///}.
        /// </summary>
        internal static string AbstractImplicitConstructor {
            get {
                return ResourceManager.GetString("AbstractImplicitConstructor", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to namespace SentryOne.Document.Web.Services.Workflow.BackgroundTaskExecutors.AzureFunctions
        ///{
        ///    using System;
        ///
        ///    public abstract class AzureFunctionsBackgroundTaskExecutor
        ///    {
        ///        public AzureFunctionsBackgroundTaskExecutor()
        ///        {
        ///        }
        ///
        ///        public abstract string SupportedStage { get; }
        ///
        ///        public abstract string SupportedStage2 { get; }
        ///
        ///		protected abstract string PropectedProperty { get; }
        ///
        ///        public abstract string CreateMessage(string item, long tenantId) [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string AbstractProperty {
            get {
                return ResourceManager.GetString("AbstractProperty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to using System;
        ///using System.Collections.Generic;
        ///using System.Linq;
        ///using System.Text;
        ///using System.Threading.Tasks;
        ///
        ///namespace BasicProject
        ///{
        ///    public abstract class AbsTest
        ///    {
        ///        protected static string GetString()
        ///        {
        ///            return &quot;string&quot;;
        ///        }
        ///
        ///        public AbsTest(IEnumerable&lt;AbsTest&gt; childSelectors)
        ///        {
        ///        }
        ///    }
        ///
        ///    public class AbsTestThing : AbsTest
        ///    {
        ///        public AbsTestThing() : base(Enumerable.Empty&lt;AbsTest&gt;())
        ///        {
        ///    [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string AbstractSelfReferencingClass {
            get {
                return ResourceManager.GetString("AbstractSelfReferencingClass", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to public class TestClass
        ///    {
        ///		string _str1;
        ///
        ///        public TestClass(string str1)
        ///        {
        ///			_str1 = str1;
        ///        }
        ///
        ///        public string Str1 =&gt; _str1;
        ///    }.
        /// </summary>
        internal static string ArrowPropertyGetter {
            get {
                return ResourceManager.GetString("ArrowPropertyGetter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to namespace TestApp1
        ///{
        ///    using System.Threading.Tasks;
        ///
        ///    public class InputClass
        ///    {
        ///        public int ID { get; }
        ///        public string SomeProperty { get; }
        ///        public string SomeOtherProperty { get; set; }
        ///        public string WriteOnlyProperty { set { } }
        ///    }
        ///
        ///    public class OutputClass
        ///    {
        ///        public string SomeProperty { get; set; }
        ///        public string SomeOtherProperty { get; set; }
        ///        public string WriteOnlyProperty { get; set; }
        ///    }
        ///    public class C [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string AsyncMappingMethod {
            get {
                return ResourceManager.GetString("AsyncMappingMethod", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to namespace TestNamespace.SubNameSpace
        ///{
        ///    public class TestClass
        ///    {
        ///	    public System.Threading.Tasks.Task ThisIsAnAsyncMethod(string methodName, int methodValue)
        ///	    {
        ///		    System.Console.WriteLine(&quot;Testing this&quot;);
        ///			return System.Threading.Tasks.Task.CompletedTask;
        ///	    }
        ///
        ///	    public System.Threading.Tasks.Task&lt;int&gt; ThisIsAnAsyncMethodWithReturnType(string methodName, int methodValue)
        ///	    {
        ///		    System.Console.WriteLine(&quot;Testing this&quot;);
        ///			return System.Threading.Tasks.Task.FromRes [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string AsyncMethod {
            get {
                return ResourceManager.GetString("AsyncMethod", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to namespace TestNamespace
        ///{
        ///    public class TestClass
        ///    {
        ///        public TestClass(byte[] array, ulong unsignedLong, uint unsignedInt, decimal dec, short sh, ushort ush, byte b, sbyte s, double d, float f, bool boo)
        ///        {
        ///			Array = array;
        ///        }
        ///
        ///        public byte[] Array { get; set; }
        ///    }
        ///}.
        /// </summary>
        internal static string ByteArray {
            get {
                return ResourceManager.GetString("ByteArray", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 
        ///using System.Drawing;
        ///using System.Linq;
        ///using System.Text;
        ///using System.Threading.Tasks;
        ///using System.Windows.Forms;
        ///using System.Data.SqlClient;
        ///
        ///namespace TestApp1
        ///{
        ///    public class C1
        ///    {
        ///        public C1(C2 other)
        ///        {
        ///             
        ///        }
        ///    }
        ///    public class C2
        ///    {
        ///        public C2(C3 other)
        ///        {
        ///             
        ///        }
        ///    }
        ///    public class C3
        ///    {
        ///        public C3(SqlBulkCopy other)
        ///        {
        ///             
        ///        }
        ///    }
        ///}.
        /// </summary>
        internal static string ChainedClassesTestFile {
            get {
                return ResourceManager.GetString("ChainedClassesTestFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to namespace AssemblyCore
        ///{
        ///    public class ConstructorGereric &lt;T,U&gt;
        ///    {
        ///        public T T1 { get; }
        ///        public U U1 { get; }
        ///        public T T2 { get; }
        ///
        ///
        ///        public ConstructorGereric(T t1)
        ///        {
        ///            T1 = t1;
        ///        }
        ///
        ///        public ConstructorGereric(T t1, U u1)
        ///        {
        ///            T1 = t1;
        ///            U1 = u1;
        ///        }
        ///    }
        ///}
        ///.
        /// </summary>
        internal static string ConstructorGenericTestFile {
            get {
                return ResourceManager.GetString("ConstructorGenericTestFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to using System;
        ///using System.Collections.Generic;
        ///using System.Text;
        ///
        ///namespace AssemblyCore
        ///{
        ///    public class ConstructorSamples
        ///    {
        ///        public string ArgumentOne { get; }
        ///        public string ArgumentTwo { get; }
        ///        public string NamedArgument { get; }
        ///        public string OptionalArgument { get; }
        ///        public string[] Args { get; }
        ///        public int[] ArgInt { get; }
        ///        public string ArguemntOne { get; }
        ///        public string ArguemntPrivateSet { get;private set; }
        ///
        /// [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string ConstructorSamplesTestFile {
            get {
                return ResourceManager.GetString("ConstructorSamplesTestFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to using System.Drawing;
        ///using System.Collections.Generic;
        ///
        ///namespace WindowsFormsApp1
        ///{
        ///    public partial class Form1
        ///    {
        ///        public Form1(IEnumerable&lt;Brush&gt; brushes)
        ///        {
        ///             
        ///        }
        ///    }
        ///}.
        /// </summary>
        internal static string DefaultParameterRequiresUsing {
            get {
                return ResourceManager.GetString("DefaultParameterRequiresUsing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 
        ///using System.Drawing;
        ///using System.Linq;
        ///using System.Text;
        ///using System.Threading.Tasks;
        ///using System.Windows;
        ///
        ///namespace WindowsFormsApp1
        ///{
        ///    public class Form1 : Window
        ///    {
        ///        public Form1()
        ///        {
        ///             
        ///        }
        ///    }
        ///}.
        /// </summary>
        internal static string DependencyObjectTestFile {
            get {
                return ResourceManager.GetString("DependencyObjectTestFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 
        ///using System;
        ///using System.Drawing;
        ///using System.Linq;
        ///using System.Text;
        ///using System.Threading.Tasks;
        ///using System.Windows;
        ///using System.Collections;
        ///using System.Collections.Generic;
        ///
        ///namespace WindowsFormsApp1
        ///{
        ///    public static class Form1 
        ///    {
        ///		public static string ToOther(this string source)
        ///        {
        ///            return source;
        ///        }
        ///
        ///		public static T ToOther&lt;T&gt;(this List&lt;T&gt; source)
        ///        {
        ///            return source.FirstOrDefault();
        ///        } 
        ///    }
        ///}.
        /// </summary>
        internal static string ExtensionMethod {
            get {
                return ResourceManager.GetString("ExtensionMethod", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to namespace Helpers
        ///{
        ///	using System;
        ///	using System.Collections.Generic;
        ///	using System.Linq;
        ///
        ///    public static class Generate
        ///    {
        ///        public static IList&lt;string&gt; Arguments(params string[] expressions)
        ///        {
        ///            return ArgumentList(expressions);
        ///        }
        ///
        ///        public static IList&lt;string&gt; Arguments(IEnumerable&lt;string&gt; expressions)
        ///        {
        ///            return ArgumentList(expressions);
        ///        }
        ///
        ///        private static IList&lt;string&gt; ArgumentList(params string[] expression [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Generate {
            get {
                return ResourceManager.GetString("Generate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to .
        /// </summary>
        internal static string GenericCollection {
            get {
                return ResourceManager.GetString("GenericCollection", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 
        ///using System;
        ///using System.Drawing;
        ///using System.Linq;
        ///using System.Text;
        ///using System.Threading.Tasks;
        ///using System.Windows.Forms;
        ///
        ///namespace WindowsFormsApp1
        ///{
        ///    public class GTest
        ///    {
        ///        public void DoStuff&lt;T&gt;(Guid g, DateTime dtParam, T theThing, int? thing2)
        ///        {
        ///             
        ///        }
        ///    }
        ///}.
        /// </summary>
        internal static string GenericMethodTestFile {
            get {
                return ResourceManager.GetString("GenericMethodTestFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to using System;
        ///
        ///namespace AssemblyCore
        ///{
        ///    public class TestComparableGeneric : IComparable&lt;TestComparableGeneric&gt;, IComparable&lt;int&gt;, IComparable
        ///    {
        ///        public TestComparableGeneric(int value)
        ///        {
        ///            Value = value;
        ///        }
        ///
        ///        public int Value { get; }
        ///
        ///        public int CompareTo(TestComparableGeneric obj)
        ///        {
        ///            if (obj == null)
        ///            {
        ///                throw new ArgumentNullException();
        ///            }
        ///
        ///            return Value.CompareT [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string IComparableTestFile {
            get {
                return ResourceManager.GetString("IComparableTestFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 
        ///using System.Drawing;
        ///using System.Linq;
        ///using System.Text;
        ///using System.Threading.Tasks;
        ///using System.Windows;
        ///using System.Collections;
        ///using System.Collections.Generic;
        ///
        ///namespace WindowsFormsApp1
        ///{
        ///    public class Form1 : IEnumerable&lt;int&gt;
        ///    {
        ///        public Form1()
        ///        {
        ///             
        ///        }
        ///		
        ///		public IEnumerator&lt;int&gt; GetEnumerator()
        ///        {
        ///            return Enumerable.Empty&lt;int&gt;().GetEnumerator();
        ///        }
        ///
        ///        IEnumerator IEnumerable.GetEnumerator()
        ///       [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string IEnumerableClass {
            get {
                return ResourceManager.GetString("IEnumerableClass", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 
        ///using System;
        ///using System.Drawing;
        ///using System.Linq;
        ///using System.Text;
        ///using System.Threading.Tasks;
        ///using System.Windows;
        ///using System.Collections;
        ///using System.Collections.Generic;
        ///
        ///namespace WindowsFormsApp1
        ///{
        ///    public class Form1 
        ///    {
        ///		public string this[string cookieName, Guid cookieValue, DateTime cookieExpirationTime]
        ///        {
        ///            set
        ///            {
        ///            }
        ///        } 
        ///
        ///        public string this[string cookieName]
        ///        {
        ///            get {
        ///             [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string IndexerTestFile {
            get {
                return ResourceManager.GetString("IndexerTestFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to using System.Threading.Tasks;
        ///
        ///namespace AssemblyCore
        ///{
        ///	public interface IDummyService { }
        ///
        ///    public class InterfaceImplementation : IDummyService
        ///    {
        ///        public Task&lt;string&gt; AsyncMethod()
        ///        {
        ///            return Task.FromResult(&quot;str&quot;);
        ///        }
        ///
        ///        public async Task&lt;int&gt; AsyncReturIntAsync()
        ///        {
        ///            await Task.Delay(500);
        ///            return 300;
        ///        }
        ///
        ///        public async Task&lt;string&gt; AsyncReturnStringAsync()
        ///        {
        ///            await Task.Delay [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string InterfaceImplementationTestFile {
            get {
                return ResourceManager.GetString("InterfaceImplementationTestFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to using System.Threading.Tasks;
        ///
        ///namespace AssemblyCore
        ///{
        ///	public interface IDummyService
        ///	{
        ///	    void NoReturnMethod();
        ///
        ///        int ReturnMetod();
        ///
        ///        Task&lt;string&gt; AsyncMethod(); 
        ///
        ///        Task  AsyncReturnTaskAsync();
        ///
        ///        Task&lt;int&gt; AsyncReturIntAsync();
        ///
        ///        Task&lt;string&gt; AsyncReturnStringAsync();
        ///	}
        ///
        ///    public class InterfaceSample
        ///    {
        ///        private IDummyService _dummyService;
        ///
        ///        public InterfaceSample(IDummyService dummyService)
        ///        {
        ///            _dum [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string InterfaceSampleTestFile {
            get {
                return ResourceManager.GetString("InterfaceSampleTestFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to namespace TestApp1
        ///{
        ///    public class InputClass
        ///    {
        ///        public string SomeProperty { get; }
        ///        public string SomeOtherProperty { get; set; }
        ///        public string WriteOnlyProperty { set { } }
        ///    }
        ///
        ///    public class OutputClass
        ///    {
        ///        public string SomeProperty { get; set; }
        ///        public string SomeOtherProperty { get; set; }
        ///        public string WriteOnlyProperty { get; set; }
        ///    }
        ///    public class C3
        ///    {
        ///        public OutputClass Map(InputClass inputClass)
        ///     [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string MappingMethod {
            get {
                return ResourceManager.GetString("MappingMethod", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to namespace SentryOne.Document.Web.Services.Workflow
        ///{
        ///	using System;
        ///    using System.Collections.Generic;
        ///    using System.Linq;	
        ///	
        ///	public enum WorkflowStage
        ///    {
        ///        Snapshot = 0,
        ///        SnapshotFinalization = 125,
        ///        LineageGeneration = 250,
        ///        DocumentGeneration = 500,
        ///        DocumentFinalization = 1000,
        ///        LineageFinalization = 1250,
        ///        CleanupItemsData = 2000,
        ///        CleanupSolutionData = 20100,
        ///    }
        ///
        ///	public static class WorkflowConstraintProviderFactory [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string MultipleOverloads {
            get {
                return ResourceManager.GetString("MultipleOverloads", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to using System;
        ///
        ///namespace AssemblyCore
        ///{
        ///    public class NestedClass
        ///    {
        ///        public InnerPublicClass innerPubClass { get; }
        ///        public InnerPublicClass InnerPubliClassOne { get; }
        ///        public InnerPublicClass InnerPublicClassTwo { get; }
        ///
        ///        public NestedClass()
        ///        {
        ///
        ///        }
        ///
        ///        public NestedClass(InnerPublicClass innerPublicClass)
        ///        {
        ///            innerPubClass = innerPublicClass;
        ///        }
        ///        public NestedClass(InnerPublicClass innerPubliClassOne [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string NestedClassTestFile {
            get {
                return ResourceManager.GetString("NestedClassTestFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to namespace TestNamespace.SubNameSpace
        ///{
        ///	using System;
        ///
        ///	class Calculator { 
        ///      
        ///		public int number = 0; 
        ///      
        ///		// parameterized constructor 
        ///		public Calculator(int n) 
        ///		{ 
        ///			number = n; 
        ///		} 
        ///      
        ///		public static Calculator operator + (Calculator Calc1,  
        ///											 Calculator Calc2) 
        ///		{ 
        ///			Calculator Calc3 = new Calculator(0); 
        ///			Calc3.number = Calc2.number + Calc1.number; 
        ///			return Calc3; 
        ///		} 
        ///
        ///		public static Calculator operator - (Calculator Calc1,  
        ///											  [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string OperatorOverloading {
            get {
                return ResourceManager.GetString("OperatorOverloading", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to namespace TestNamespace.SubNameSpace
        ///{
        ///    public static class TestClass
        ///    {
        ///	    public static void ThisIsAMethod&lt;TInput&gt;(string methodName)
        ///	    {
        ///		    System.Console.WriteLine(&quot;Testing this&quot;);
        ///	    }
        ///
        ///	    public static void ThisIsAMethod&lt;TInput, TOutput&gt;(string methodName)
        ///	    {
        ///		    System.Console.WriteLine(&quot;Testing this&quot;);
        ///	    }
        ///
        ///	    public static void ThisIsAMethod&lt;TInput&gt;(string methodName, int methodValue)
        ///	    {
        ///		    System.Console.WriteLine(&quot;Testing this&quot;);
        ///	    }
        ///
        ///	    [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string OverloadGenericDisambiguation {
            get {
                return ResourceManager.GetString("OverloadGenericDisambiguation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to namespace TestNamespace.SubNameSpace
        ///{
        ///	using System;
        ///
        ///    public class SomePoco
        ///    {
        ///        public int ThisIsAProperty {get;set;}
        ///        public string ThisIsAProperty2 {get;set;}
        ///        public Guid ThisIsAProperty3 {get;set;}
        ///        public Guid? ThisIsAProperty4 {get;set;}
        ///        public int ThisIsAProperty5 {get;private set;}
        ///		private int ThisIsAProperty6 {get;set;}
        ///        public Guid ThisIsAProperty7 {get;set;}
        ///        public Guid ThisIsAProperty8 {get;set;}
        ///        public Guid ThisI [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string PocoInitialization {
            get {
                return ResourceManager.GetString("PocoInitialization", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to using System.ComponentModel;
        ///using System.Windows.Media;
        ///
        ///namespace AssemblyCore
        ///{
        ///    public class PropertyChange : INotifyPropertyChanged
        ///    {
        ///        private string name;
        ///
        ///        public string Name
        ///        {
        ///            get { return name; }
        ///            set
        ///            {
        ///                name = value;
        ///                OnPropertChanged(&quot;Name&quot;);
        ///                OnPropertChanged(&quot;FullName&quot;);
        ///            }
        ///        }
        ///
        ///        private string lastname;
        ///
        ///        public string LastName
        ///      [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string PropertyChangeTestFile {
            get {
                return ResourceManager.GetString("PropertyChangeTestFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to namespace TestNamespace.SubNameSpace
        ///{
        ///    public class TestClass
        ///    {
        ///        public void RefParamMethodString(string stringProp, ref string refParam)
        ///        {
        ///
        ///        }
        /// 
        ///        public void OutParamMethodString(string stringProp, out string outParam)
        ///        {
        ///			outParam = &quot;&quot;;
        ///        }
        ///
        ///        public void RefParamMethodClass(string stringProp, ref TestClass refParam)
        ///        {
        ///
        ///        }
        /// 
        ///        public void OutParamMethodClass(string stringProp, out TestClass outParam)
        ///        [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string RefAndOutParameters {
            get {
                return ResourceManager.GetString("RefAndOutParameters", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to namespace TestNamespace.SubNameSpace
        ///{
        ///    public class InnerClass
        ///    {
        ///        public InnerClass(int intParam1, int intParam2, int intParam3, string stringParam1, string stringParam2, string stringParam3)
        ///        {
        ///
        ///        }
        ///    }
        ///
        ///    public class OuterClass
        ///    {
        ///        public OuterClass(InnerClass innerClass)
        ///        {
        ///
        ///        }
        ///    }
        ///}.
        /// </summary>
        internal static string RepeatedValueTypeParameters {
            get {
                return ResourceManager.GetString("RepeatedValueTypeParameters", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to namespace TestNamespace.SubNameSpace
        ///{
        ///
        ///    public interface ITest
        ///    {
        ///        int ThisIsAProperty {get;set;}
        ///    }
        ///
        ///    public class TestClass
        ///    {
        ///        public TestClass(string stringProp, ITest iTest)
        ///        {
        ///
        ///        }
        /// 
        ///        public TestClass(int? nullableIntProp, ITest iTest)
        ///        {
        ///
        ///        }
        /// 
        ///        public TestClass(int thisIsAProperty, ITest iTest)
        ///        {
        ///
        ///        }
        /// 
        ///	    public void ThisIsAMethod(string methodName, int methodValue)
        ///	    {
        ///		    System.C [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string SampleClassTestFile {
            get {
                return ResourceManager.GetString("SampleClassTestFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to namespace SentryOne.UnitTestGenerator.Core.Models
        ///{
        ///    using System;
        ///    using System.Text.RegularExpressions;
        ///
        ///    public class SemanticVersion
        ///    {
        ///        private const RegexOptions Flags = RegexOptions.Compiled | RegexOptions.IgnoreCase | RegexOptions.ExplicitCapture;
        ///        private static readonly Regex SemanticVersionRegex = new Regex(@&quot;^(?&lt;Version&gt;\d+(\s*\.\s*\d+){0,3})(?&lt;Release&gt;-[a-z][0-9a-z-]*)?$&quot;, Flags);
        ///
        ///        private SemanticVersion(Version version, string specialVersion)
        ///      [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string SemanticVersion {
            get {
                return ResourceManager.GetString("SemanticVersion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to namespace WindowsFormsApp1
        ///{
        ///	using System;
        ///
        ///	public class TenantSharedTableProvider
        ///	{
        ///		static TenantSharedTableProvider()
        ///		{
        ///			Instance = new TenantSharedTableProvider();
        ///		}
        ///
        ///		private TenantSharedTableProvider()
        ///		{
        ///		}
        ///
        ///		public static TenantSharedTableProvider Instance { get; }
        ///
        ///		public bool IsShared =&gt; true;
        ///
        ///		public string GetTableName(string baseName, long tenantId)
        ///		{
        ///			if (string.IsNullOrWhiteSpace(baseName))
        ///			{
        ///				throw new ArgumentNullException(nameof(baseName)) [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Singleton {
            get {
                return ResourceManager.GetString("Singleton", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to namespace TestNamespace.SubNameSpace
        ///{
        ///	using System.Globalization;
        ///
        ///    public static class TestClass
        ///    {
        ///        public static void ThisIsAMethod(string methodName, CultureInfo methodValue)
        ///	    {
        ///		    System.Console.WriteLine(&quot;Testing this&quot;);
        ///	    }
        ///
        ///        public static string WillReturnAString()
        ///        {
        ///            return &quot;Hello&quot;;
        ///        }
        ///
        ///        public static int ThisIsAProperty { get; set; }
        ///
        ///        public static string GetITest { get; }
        ///    }
        ///}.
        /// </summary>
        internal static string StaticTestFile {
            get {
                return ResourceManager.GetString("StaticTestFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to namespace TestNamespace.SubNameSpace
        ///{
        ///    public class TestClass&lt;T&gt;
        ///    {
        ///	    public void ThisIsAMethod(string methodName)
        ///	    {
        ///		    System.Console.WriteLine(&quot;Testing this&quot;);
        ///	    }
        ///    }
        ///
        ///    public class TestClass&lt;TIn, TOut&gt;
        ///    {
        ///	    public void ThisIsAMethod(string methodName)
        ///	    {
        ///		    System.Console.WriteLine(&quot;Testing this&quot;);
        ///	    }
        ///    }
        ///}.
        /// </summary>
        internal static string TypeGenericDisambiguation {
            get {
                return ResourceManager.GetString("TypeGenericDisambiguation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 
        ///using System.Drawing;
        ///using System.Linq;
        ///using System.Text;
        ///using System.Threading.Tasks;
        ///using System.Windows.Forms;
        ///
        ///namespace WindowsFormsApp1
        ///{
        ///    public partial class Form1 : Form
        ///    {
        ///        public Form1(Color c, Brush b)
        ///        {
        ///             
        ///        }
        ///    }
        ///}.
        /// </summary>
        internal static string WinformTestFile {
            get {
                return ResourceManager.GetString("WinformTestFile", resourceCulture);
            }
        }
    }
}
