﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18010
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TravelTime.WashingtonDot {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TravelTimeRoute", Namespace="http://schemas.datacontract.org/2004/07/")]
    [System.SerializableAttribute()]
    public partial class TravelTimeRoute : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int AverageTimeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CurrentTimeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal DistanceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private TravelTime.WashingtonDot.RoadwayLocation EndPointField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private TravelTime.WashingtonDot.RoadwayLocation StartPointField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime TimeUpdatedField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int TravelTimeIDField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int AverageTime {
            get {
                return this.AverageTimeField;
            }
            set {
                if ((this.AverageTimeField.Equals(value) != true)) {
                    this.AverageTimeField = value;
                    this.RaisePropertyChanged("AverageTime");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int CurrentTime {
            get {
                return this.CurrentTimeField;
            }
            set {
                if ((this.CurrentTimeField.Equals(value) != true)) {
                    this.CurrentTimeField = value;
                    this.RaisePropertyChanged("CurrentTime");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Description {
            get {
                return this.DescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescriptionField, value) != true)) {
                    this.DescriptionField = value;
                    this.RaisePropertyChanged("Description");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal Distance {
            get {
                return this.DistanceField;
            }
            set {
                if ((this.DistanceField.Equals(value) != true)) {
                    this.DistanceField = value;
                    this.RaisePropertyChanged("Distance");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public TravelTime.WashingtonDot.RoadwayLocation EndPoint {
            get {
                return this.EndPointField;
            }
            set {
                if ((object.ReferenceEquals(this.EndPointField, value) != true)) {
                    this.EndPointField = value;
                    this.RaisePropertyChanged("EndPoint");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public TravelTime.WashingtonDot.RoadwayLocation StartPoint {
            get {
                return this.StartPointField;
            }
            set {
                if ((object.ReferenceEquals(this.StartPointField, value) != true)) {
                    this.StartPointField = value;
                    this.RaisePropertyChanged("StartPoint");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime TimeUpdated {
            get {
                return this.TimeUpdatedField;
            }
            set {
                if ((this.TimeUpdatedField.Equals(value) != true)) {
                    this.TimeUpdatedField = value;
                    this.RaisePropertyChanged("TimeUpdated");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int TravelTimeID {
            get {
                return this.TravelTimeIDField;
            }
            set {
                if ((this.TravelTimeIDField.Equals(value) != true)) {
                    this.TravelTimeIDField = value;
                    this.RaisePropertyChanged("TravelTimeID");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="RoadwayLocation", Namespace="http://schemas.datacontract.org/2004/07/")]
    [System.SerializableAttribute()]
    public partial class RoadwayLocation : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DirectionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal LatitudeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal LongitudeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal MilePostField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string RoadNameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Description {
            get {
                return this.DescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescriptionField, value) != true)) {
                    this.DescriptionField = value;
                    this.RaisePropertyChanged("Description");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Direction {
            get {
                return this.DirectionField;
            }
            set {
                if ((object.ReferenceEquals(this.DirectionField, value) != true)) {
                    this.DirectionField = value;
                    this.RaisePropertyChanged("Direction");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal Latitude {
            get {
                return this.LatitudeField;
            }
            set {
                if ((this.LatitudeField.Equals(value) != true)) {
                    this.LatitudeField = value;
                    this.RaisePropertyChanged("Latitude");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal Longitude {
            get {
                return this.LongitudeField;
            }
            set {
                if ((this.LongitudeField.Equals(value) != true)) {
                    this.LongitudeField = value;
                    this.RaisePropertyChanged("Longitude");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal MilePost {
            get {
                return this.MilePostField;
            }
            set {
                if ((this.MilePostField.Equals(value) != true)) {
                    this.MilePostField = value;
                    this.RaisePropertyChanged("MilePost");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string RoadName {
            get {
                return this.RoadNameField;
            }
            set {
                if ((object.ReferenceEquals(this.RoadNameField, value) != true)) {
                    this.RoadNameField = value;
                    this.RaisePropertyChanged("RoadName");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WashingtonDot.ITravelTimes")]
    public interface ITravelTimes {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITravelTimes/GetTravelTimes", ReplyAction="http://tempuri.org/ITravelTimes/GetTravelTimesResponse")]
        TravelTime.WashingtonDot.TravelTimeRoute[] GetTravelTimes(string AccessCode);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITravelTimes/GetTravelTimes", ReplyAction="http://tempuri.org/ITravelTimes/GetTravelTimesResponse")]
        System.Threading.Tasks.Task<TravelTime.WashingtonDot.TravelTimeRoute[]> GetTravelTimesAsync(string AccessCode);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITravelTimes/GetTravelTime", ReplyAction="http://tempuri.org/ITravelTimes/GetTravelTimeResponse")]
        TravelTime.WashingtonDot.TravelTimeRoute GetTravelTime(string AccessCode, int TravelTimeID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITravelTimes/GetTravelTime", ReplyAction="http://tempuri.org/ITravelTimes/GetTravelTimeResponse")]
        System.Threading.Tasks.Task<TravelTime.WashingtonDot.TravelTimeRoute> GetTravelTimeAsync(string AccessCode, int TravelTimeID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITravelTimes/GetTravelTimesAsDataSet", ReplyAction="http://tempuri.org/ITravelTimes/GetTravelTimesAsDataSetResponse")]
        System.Data.DataSet GetTravelTimesAsDataSet(string AccessCode);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITravelTimes/GetTravelTimesAsDataSet", ReplyAction="http://tempuri.org/ITravelTimes/GetTravelTimesAsDataSetResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> GetTravelTimesAsDataSetAsync(string AccessCode);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ITravelTimesChannel : TravelTime.WashingtonDot.ITravelTimes, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class TravelTimesClient : System.ServiceModel.ClientBase<TravelTime.WashingtonDot.ITravelTimes>, TravelTime.WashingtonDot.ITravelTimes {
        
        public TravelTimesClient() {
        }
        
        public TravelTimesClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public TravelTimesClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TravelTimesClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TravelTimesClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public TravelTime.WashingtonDot.TravelTimeRoute[] GetTravelTimes(string AccessCode) {
            return base.Channel.GetTravelTimes(AccessCode);
        }
        
        public System.Threading.Tasks.Task<TravelTime.WashingtonDot.TravelTimeRoute[]> GetTravelTimesAsync(string AccessCode) {
            return base.Channel.GetTravelTimesAsync(AccessCode);
        }
        
        public TravelTime.WashingtonDot.TravelTimeRoute GetTravelTime(string AccessCode, int TravelTimeID) {
            return base.Channel.GetTravelTime(AccessCode, TravelTimeID);
        }
        
        public System.Threading.Tasks.Task<TravelTime.WashingtonDot.TravelTimeRoute> GetTravelTimeAsync(string AccessCode, int TravelTimeID) {
            return base.Channel.GetTravelTimeAsync(AccessCode, TravelTimeID);
        }
        
        public System.Data.DataSet GetTravelTimesAsDataSet(string AccessCode) {
            return base.Channel.GetTravelTimesAsDataSet(AccessCode);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> GetTravelTimesAsDataSetAsync(string AccessCode) {
            return base.Channel.GetTravelTimesAsDataSetAsync(AccessCode);
        }
    }
}
