﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Ipr.WaterSensor.Server.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Ipr.WaterSensor.Server.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to Dag.
        /// </summary>
        internal static string BatteryAlarm_body {
            get {
                return ResourceManager.GetString("BatteryAlarm_body", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Batterij regenwaterput laag! .
        /// </summary>
        internal static string BatteryAlarm_header {
            get {
                return ResourceManager.GetString("BatteryAlarm_header", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to f07b2dbeeae343528d0b9dad5a13aebf.s1.eu.hivemq.cloud.
        /// </summary>
        internal static string MQTTBroker {
            get {
                return ResourceManager.GetString("MQTTBroker", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ZEEZRrrze4235.
        /// </summary>
        internal static string MQTTPassword {
            get {
                return ResourceManager.GetString("MQTTPassword", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 8883.
        /// </summary>
        internal static string MQTTPort {
            get {
                return ResourceManager.GetString("MQTTPort", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to certificates/emqxsl-ca.crt.
        /// </summary>
        internal static string MQTTSSLCertificatePath {
            get {
                return ResourceManager.GetString("MQTTSSLCertificatePath", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to battery_level.
        /// </summary>
        internal static string MQTTTopicBatteryLevel {
            get {
                return ResourceManager.GetString("MQTTTopicBatteryLevel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to intervalReceive.
        /// </summary>
        internal static string MQTTTopicIntervalReceive {
            get {
                return ResourceManager.GetString("MQTTTopicIntervalReceive", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to intervalSend.
        /// </summary>
        internal static string MQTTTopicIntervalSend {
            get {
                return ResourceManager.GetString("MQTTTopicIntervalSend", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to watersensor_main_tank.
        /// </summary>
        internal static string MQTTTopicMainTank {
            get {
                return ResourceManager.GetString("MQTTTopicMainTank", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to watersensor_receive.
        /// </summary>
        internal static string MQTTUserName {
            get {
                return ResourceManager.GetString("MQTTUserName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to https://api.open-meteo.com/v1/forecast?latitude=51.1758&amp;longitude=2.8758&amp;daily=precipitation_sum&amp;timezone=Europe%2FBerlin&amp;forecast_days=16.
        /// </summary>
        internal static string WeatherApiAddress {
            get {
                return ResourceManager.GetString("WeatherApiAddress", resourceCulture);
            }
        }
    }
}
