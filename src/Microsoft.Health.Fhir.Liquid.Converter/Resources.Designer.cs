﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.Health.Fhir.Liquid.Converter {
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
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.Health.Fhir.Liquid.Converter.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to MSH segment contains duplicate separators..
        /// </summary>
        internal static string DuplicateHl7v2Separators {
            get {
                return ResourceManager.GetString("DuplicateHl7v2Separators", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Syntax Error in &apos;evaluate&apos; tag - Valid syntax: evaluate [output] using [template] [inputs].
        /// </summary>
        internal static string EvaluateTagSyntaxError {
            get {
                return ResourceManager.GetString("EvaluateTagSyntaxError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The input data could not be parsed correctly: {0}.
        /// </summary>
        internal static string InputParsingError {
            get {
                return ResourceManager.GetString("InputParsingError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The code mapping file is invalid..
        /// </summary>
        internal static string InvalidCodeMapping {
            get {
                return ResourceManager.GetString("InvalidCodeMapping", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The format of Date or DateTime is invalid: {0}..
        /// </summary>
        internal static string InvalidDateTimeFormat {
            get {
                return ResourceManager.GetString("InvalidDateTimeFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The hexadecimal number is invalid: {0}..
        /// </summary>
        internal static string InvalidHexadecimalNumber {
            get {
                return ResourceManager.GetString("InvalidHexadecimalNumber", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Escape character should be backslash..
        /// </summary>
        internal static string InvalidHl7v2EscapeCharacter {
            get {
                return ResourceManager.GetString("InvalidHl7v2EscapeCharacter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The HL7 v2 message is invalid, first segment id = {0}..
        /// </summary>
        internal static string InvalidHl7v2Message {
            get {
                return ResourceManager.GetString("InvalidHl7v2Message", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The input to generate ID is invalid..
        /// </summary>
        internal static string InvalidIdGenerationInput {
            get {
                return ResourceManager.GetString("InvalidIdGenerationInput", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to TimeZoneHandling only supports &apos;local&apos;, &apos;utc&apos; and &apos;preserve&apos;..
        /// </summary>
        internal static string InvalidTimeZoneHandling {
            get {
                return ResourceManager.GetString("InvalidTimeZoneHandling", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error happened when merging JSON: {0}.
        /// </summary>
        internal static string JsonMergingError {
            get {
                return ResourceManager.GetString("JsonMergingError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid JSON generated: {0}..
        /// </summary>
        internal static string JsonParsingError {
            get {
                return ResourceManager.GetString("JsonParsingError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to MSH segment misses separators..
        /// </summary>
        internal static string MissingHl7v2Separators {
            get {
                return ResourceManager.GetString("MissingHl7v2Separators", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Root template should not be null or empty..
        /// </summary>
        internal static string NullOrEmptyRootTemplate {
            get {
                return ResourceManager.GetString("NullOrEmptyRootTemplate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The input data should not be null, empty or consists only of white-space characters..
        /// </summary>
        internal static string NullOrWhiteSpaceInput {
            get {
                return ResourceManager.GetString("NullOrWhiteSpaceInput", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to TemplateProvider should not be null..
        /// </summary>
        internal static string NullTemplateProvider {
            get {
                return ResourceManager.GetString("NullTemplateProvider", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Property &apos;{0}&apos; not found in {1}..
        /// </summary>
        internal static string PropertyNotFound {
            get {
                return ResourceManager.GetString("PropertyNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Template file system not found..
        /// </summary>
        internal static string TemplateFileSystemNotFound {
            get {
                return ResourceManager.GetString("TemplateFileSystemNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Template folder not found: {0}..
        /// </summary>
        internal static string TemplateFolderNotFound {
            get {
                return ResourceManager.GetString("TemplateFolderNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error happened when loading templates: {0}.
        /// </summary>
        internal static string TemplateLoadingError {
            get {
                return ResourceManager.GetString("TemplateLoadingError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Template &apos;{0}&apos; not found.
        /// </summary>
        internal static string TemplateNotFound {
            get {
                return ResourceManager.GetString("TemplateNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error happened when rendering templates: {0}.
        /// </summary>
        internal static string TemplateRenderingError {
            get {
                return ResourceManager.GetString("TemplateRenderingError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Syntax error in template &apos;{0}&apos;: {1}.
        /// </summary>
        internal static string TemplateSyntaxError {
            get {
                return ResourceManager.GetString("TemplateSyntaxError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Time out when rendering templates..
        /// </summary>
        internal static string TimeoutError {
            get {
                return ResourceManager.GetString("TimeoutError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error happened when processing TraceInfo: {0}.
        /// </summary>
        internal static string TraceInfoError {
            get {
                return ResourceManager.GetString("TraceInfoError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unexpected end when reading IDictionary&lt;string, object&gt;..
        /// </summary>
        internal static string UnexpectedJsonConvertEnd {
            get {
                return ResourceManager.GetString("UnexpectedJsonConvertEnd", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unexpected token when converting IDictionary&lt;string, object&gt;..
        /// </summary>
        internal static string UnexpectedJsonConvertToken {
            get {
                return ResourceManager.GetString("UnexpectedJsonConvertToken", resourceCulture);
            }
        }
    }
}
