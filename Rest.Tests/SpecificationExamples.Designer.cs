﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Reductech.EDR.Connectors.Rest.Tests {
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
    internal class SpecificationExamples {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal SpecificationExamples() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Reductech.EDR.Connectors.Rest.Tests.SpecificationExamples", typeof(SpecificationExamples).Assembly);
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
        ///   Looks up a localized string similar to openapi: 3.0.0
        ///info:
        ///  title: Sample API
        ///  description: Optional multiline or single-line description in [CommonMark](http://commonmark.org/help/) or HTML.
        ///  version: 0.1.9
        ///servers:
        ///  - url: http://api.example.com/v1
        ///    description: Optional server description, e.g. Main (production) server
        ///  - url: http://staging-api.example.com
        ///    description: Optional server description, e.g. Internal staging server for testing
        ///paths:
        ///  /users:
        ///    get:
        ///      summary: Returns a list of users.
        ///      descri [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Example {
            get {
                return ResourceManager.GetString("Example", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {
        ///  &quot;openapi&quot;: &quot;3.0.1&quot;,
        ///  &quot;info&quot;: {
        ///    &quot;title&quot;: &quot;Reductech.EDR.Orchestrator.ClientAPI&quot;,
        ///    &quot;version&quot;: &quot;1.0&quot;
        ///  },
        ///  &quot;paths&quot;: {
        ///    &quot;/api/v{version}/Bags&quot;: {
        ///      &quot;get&quot;: {
        ///        &quot;tags&quot;: [
        ///          &quot;Bags&quot;
        ///        ],
        ///        &quot;operationId&quot;: &quot;Bags_Get&quot;,
        ///        &quot;parameters&quot;: [
        ///          {
        ///            &quot;name&quot;: &quot;Name&quot;,
        ///            &quot;in&quot;: &quot;query&quot;,
        ///            &quot;schema&quot;: {
        ///              &quot;type&quot;: &quot;string&quot;
        ///            }
        ///          },
        ///          {
        ///            &quot;name&quot;: &quot;Custodian&quot;,
        ///            &quot;in&quot;: [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Orchestrator {
            get {
                return ResourceManager.GetString("Orchestrator", resourceCulture);
            }
        }
    }
}
