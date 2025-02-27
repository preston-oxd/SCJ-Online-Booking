﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SCJ.OnlineBooking
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CourtFile", Namespace="http://schemas.datacontract.org/2004/07/SCSSOnlineBooking.Objects")]
    public partial class CourtFile : object
    {
        
        private string courtClassCodeField;
        
        private string courtFileNumberField;
        
        private string courtLevelCodeField;
        
        private System.Nullable<decimal> locationIdField;
        
        private System.Nullable<decimal> physicalFileIdField;
        
        private string styleOfCauseField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string courtClassCode
        {
            get
            {
                return this.courtClassCodeField;
            }
            set
            {
                this.courtClassCodeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string courtFileNumber
        {
            get
            {
                return this.courtFileNumberField;
            }
            set
            {
                this.courtFileNumberField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string courtLevelCode
        {
            get
            {
                return this.courtLevelCodeField;
            }
            set
            {
                this.courtLevelCodeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<decimal> locationId
        {
            get
            {
                return this.locationIdField;
            }
            set
            {
                this.locationIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<decimal> physicalFileId
        {
            get
            {
                return this.physicalFileIdField;
            }
            set
            {
                this.physicalFileIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string styleOfCause
        {
            get
            {
                return this.styleOfCauseField;
            }
            set
            {
                this.styleOfCauseField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Location", Namespace="http://schemas.datacontract.org/2004/07/SCSSOnlineBooking.Objects")]
    public partial class Location : object
    {
        
        private int bookingHearingTypeIDField;
        
        private int bookingLocationIDField;
        
        private string locationCodeField;
        
        private int locationIDField;
        
        private string locationNameField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int bookingHearingTypeID
        {
            get
            {
                return this.bookingHearingTypeIDField;
            }
            set
            {
                this.bookingHearingTypeIDField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int bookingLocationID
        {
            get
            {
                return this.bookingLocationIDField;
            }
            set
            {
                this.bookingLocationIDField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string locationCode
        {
            get
            {
                return this.locationCodeField;
            }
            set
            {
                this.locationCodeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int locationID
        {
            get
            {
                return this.locationIDField;
            }
            set
            {
                this.locationIDField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string locationName
        {
            get
            {
                return this.locationNameField;
            }
            set
            {
                this.locationNameField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Runtime.Serialization.DataContractAttribute(Name="AvailableDatesByLocation", Namespace="http://schemas.datacontract.org/2004/07/SCSSOnlineBooking.Objects")]
    public partial class AvailableDatesByLocation : object
    {
        
        private SCJ.OnlineBooking.ContainerInfo[] AvailableDatesField;
        
        private SCJ.OnlineBooking.BookingDetail BookingDetailsField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public SCJ.OnlineBooking.ContainerInfo[] AvailableDates
        {
            get
            {
                return this.AvailableDatesField;
            }
            set
            {
                this.AvailableDatesField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public SCJ.OnlineBooking.BookingDetail BookingDetails
        {
            get
            {
                return this.BookingDetailsField;
            }
            set
            {
                this.BookingDetailsField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Runtime.Serialization.DataContractAttribute(Name="BookingDetail", Namespace="http://schemas.datacontract.org/2004/07/SCSSOnlineBooking.Objects")]
    public partial class BookingDetail : object
    {
        
        private string bookingNotesField;
        
        private int detailBookingLengthField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string bookingNotes
        {
            get
            {
                return this.bookingNotesField;
            }
            set
            {
                this.bookingNotesField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int detailBookingLength
        {
            get
            {
                return this.detailBookingLengthField;
            }
            set
            {
                this.detailBookingLengthField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ContainerInfo", Namespace="http://schemas.datacontract.org/2004/07/SCSSOnlineBooking.Objects")]
    public partial class ContainerInfo : object
    {
        
        private int ContainerIDField;
        
        private System.DateTime Date_TimeField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ContainerID
        {
            get
            {
                return this.ContainerIDField;
            }
            set
            {
                this.ContainerIDField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Date_Time
        {
            get
            {
                return this.Date_TimeField;
            }
            set
            {
                this.Date_TimeField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Runtime.Serialization.DataContractAttribute(Name="BookHearingInfo", Namespace="http://schemas.datacontract.org/2004/07/SCSSOnlineBooking")]
    public partial class BookHearingInfo : object
    {
        
        private decimal CEIS_Physical_File_IDField;
        
        private int containerIDField;
        
        private System.DateTime dateTimeField;
        
        private int hearingLengthField;
        
        private int hearingTypeIdField;
        
        private int locationIDField;
        
        private string requestedByField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal CEIS_Physical_File_ID
        {
            get
            {
                return this.CEIS_Physical_File_IDField;
            }
            set
            {
                this.CEIS_Physical_File_IDField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int containerID
        {
            get
            {
                return this.containerIDField;
            }
            set
            {
                this.containerIDField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime dateTime
        {
            get
            {
                return this.dateTimeField;
            }
            set
            {
                this.dateTimeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int hearingLength
        {
            get
            {
                return this.hearingLengthField;
            }
            set
            {
                this.hearingLengthField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int hearingTypeId
        {
            get
            {
                return this.hearingTypeIdField;
            }
            set
            {
                this.hearingTypeIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int locationID
        {
            get
            {
                return this.locationIDField;
            }
            set
            {
                this.locationIDField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string requestedBy
        {
            get
            {
                return this.requestedByField;
            }
            set
            {
                this.requestedByField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Runtime.Serialization.DataContractAttribute(Name="BookingHearingResult", Namespace="http://schemas.datacontract.org/2004/07/SCSSOnlineBooking")]
    public partial class BookingHearingResult : object
    {
        
        private string bookingResultField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string bookingResult
        {
            get
            {
                return this.bookingResultField;
            }
            set
            {
                this.bookingResultField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Runtime.Serialization.DataContractAttribute(Name="COACaseList", Namespace="http://schemas.datacontract.org/2004/07/SCSSOnlineBooking.Objects")]
    public partial class COACaseList : object
    {
        
        private SCJ.OnlineBooking.CoAClassInfo[] CaseListField;
        
        private string CaseTypeField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public SCJ.OnlineBooking.CoAClassInfo[] CaseList
        {
            get
            {
                return this.CaseListField;
            }
            set
            {
                this.CaseListField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CaseType
        {
            get
            {
                return this.CaseTypeField;
            }
            set
            {
                this.CaseTypeField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CoAClassInfo", Namespace="http://schemas.datacontract.org/2004/07/SCSSOnlineBooking.Objects")]
    public partial class CoAClassInfo : object
    {
        
        private int CaseIdField;
        
        private string Case_NumField;
        
        private bool MainField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int CaseId
        {
            get
            {
                return this.CaseIdField;
            }
            set
            {
                this.CaseIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Case_Num
        {
            get
            {
                return this.Case_NumField;
            }
            set
            {
                this.Case_NumField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Main
        {
            get
            {
                return this.MainField;
            }
            set
            {
                this.MainField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CoAAvailableDates", Namespace="http://schemas.datacontract.org/2004/07/SCSSOnlineBooking.Objects")]
    public partial class CoAAvailableDates : object
    {
        
        private SCJ.OnlineBooking.ShedulesInfo[] AvailableDatesField;
        
        private string BookingNotesField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public SCJ.OnlineBooking.ShedulesInfo[] AvailableDates
        {
            get
            {
                return this.AvailableDatesField;
            }
            set
            {
                this.AvailableDatesField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string BookingNotes
        {
            get
            {
                return this.BookingNotesField;
            }
            set
            {
                this.BookingNotesField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ShedulesInfo", Namespace="http://schemas.datacontract.org/2004/07/SCSSOnlineBooking.Objects")]
    public partial class ShedulesInfo : object
    {
        
        private string availabilityField;
        
        private System.DateTime scheduleDateField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string availability
        {
            get
            {
                return this.availabilityField;
            }
            set
            {
                this.availabilityField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime scheduleDate
        {
            get
            {
                return this.scheduleDateField;
            }
            set
            {
                this.scheduleDateField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CoABookingHearingInfo", Namespace="http://schemas.datacontract.org/2004/07/SCSSOnlineBooking")]
    public partial class CoABookingHearingInfo : object
    {
        
        private bool MainCaseField;
        
        private string RelatedCasesField;
        
        private int caseIDField;
        
        private string emailField;
        
        private System.DateTime hearingDateField;
        
        private string hearingLengthField;
        
        private int hearingTypeIdField;
        
        private string phoneField;
        
        private string requestedByField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool MainCase
        {
            get
            {
                return this.MainCaseField;
            }
            set
            {
                this.MainCaseField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string RelatedCases
        {
            get
            {
                return this.RelatedCasesField;
            }
            set
            {
                this.RelatedCasesField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int caseID
        {
            get
            {
                return this.caseIDField;
            }
            set
            {
                this.caseIDField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string email
        {
            get
            {
                return this.emailField;
            }
            set
            {
                this.emailField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime hearingDate
        {
            get
            {
                return this.hearingDateField;
            }
            set
            {
                this.hearingDateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string hearingLength
        {
            get
            {
                return this.hearingLengthField;
            }
            set
            {
                this.hearingLengthField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int hearingTypeId
        {
            get
            {
                return this.hearingTypeIdField;
            }
            set
            {
                this.hearingTypeIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string phone
        {
            get
            {
                return this.phoneField;
            }
            set
            {
                this.phoneField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string requestedBy
        {
            get
            {
                return this.requestedByField;
            }
            set
            {
                this.requestedByField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SCJ.OnlineBooking.IOnlineBooking")]
    public interface IOnlineBooking
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOnlineBooking/caseNumberValid", ReplyAction="http://tempuri.org/IOnlineBooking/caseNumberValidResponse")]
        System.Threading.Tasks.Task<SCJ.OnlineBooking.CourtFile[]> caseNumberValidAsync(string caseNum);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOnlineBooking/getLocations", ReplyAction="http://tempuri.org/IOnlineBooking/getLocationsResponse")]
        System.Threading.Tasks.Task<SCJ.OnlineBooking.Location[]> getLocationsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOnlineBooking/AvailableDatesByLocation", ReplyAction="http://tempuri.org/IOnlineBooking/AvailableDatesByLocationResponse")]
        System.Threading.Tasks.Task<SCJ.OnlineBooking.AvailableDatesByLocation> AvailableDatesByLocationAsync(int locationID, int hearingTypeID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOnlineBooking/BookingHearing", ReplyAction="http://tempuri.org/IOnlineBooking/BookingHearingResponse")]
        System.Threading.Tasks.Task<SCJ.OnlineBooking.BookingHearingResult> BookingHearingAsync(SCJ.OnlineBooking.BookHearingInfo bookInfo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOnlineBooking/CoACaseNumberValid", ReplyAction="http://tempuri.org/IOnlineBooking/CoACaseNumberValidResponse")]
        System.Threading.Tasks.Task<SCJ.OnlineBooking.COACaseList> CoACaseNumberValidAsync(string caseNum);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOnlineBooking/COAAvailableDates", ReplyAction="http://tempuri.org/IOnlineBooking/COAAvailableDatesResponse")]
        System.Threading.Tasks.Task<SCJ.OnlineBooking.CoAAvailableDates> COAAvailableDatesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOnlineBooking/CoAQueueHearing", ReplyAction="http://tempuri.org/IOnlineBooking/CoAQueueHearingResponse")]
        System.Threading.Tasks.Task<SCJ.OnlineBooking.BookingHearingResult> CoAQueueHearingAsync(SCJ.OnlineBooking.CoABookingHearingInfo bookingInfo);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public interface IOnlineBookingChannel : SCJ.OnlineBooking.IOnlineBooking, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public partial class OnlineBookingClient : System.ServiceModel.ClientBase<SCJ.OnlineBooking.IOnlineBooking>, SCJ.OnlineBooking.IOnlineBooking
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public OnlineBookingClient() : 
                base(OnlineBookingClient.GetDefaultBinding(), OnlineBookingClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_IOnlineBooking.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public OnlineBookingClient(EndpointConfiguration endpointConfiguration) : 
                base(OnlineBookingClient.GetBindingForEndpoint(endpointConfiguration), OnlineBookingClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public OnlineBookingClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(OnlineBookingClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public OnlineBookingClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(OnlineBookingClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public OnlineBookingClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task<SCJ.OnlineBooking.CourtFile[]> caseNumberValidAsync(string caseNum)
        {
            return base.Channel.caseNumberValidAsync(caseNum);
        }
        
        public System.Threading.Tasks.Task<SCJ.OnlineBooking.Location[]> getLocationsAsync()
        {
            return base.Channel.getLocationsAsync();
        }
        
        public System.Threading.Tasks.Task<SCJ.OnlineBooking.AvailableDatesByLocation> AvailableDatesByLocationAsync(int locationID, int hearingTypeID)
        {
            return base.Channel.AvailableDatesByLocationAsync(locationID, hearingTypeID);
        }
        
        public System.Threading.Tasks.Task<SCJ.OnlineBooking.BookingHearingResult> BookingHearingAsync(SCJ.OnlineBooking.BookHearingInfo bookInfo)
        {
            return base.Channel.BookingHearingAsync(bookInfo);
        }
        
        public System.Threading.Tasks.Task<SCJ.OnlineBooking.COACaseList> CoACaseNumberValidAsync(string caseNum)
        {
            return base.Channel.CoACaseNumberValidAsync(caseNum);
        }
        
        public System.Threading.Tasks.Task<SCJ.OnlineBooking.CoAAvailableDates> COAAvailableDatesAsync()
        {
            return base.Channel.COAAvailableDatesAsync();
        }
        
        public System.Threading.Tasks.Task<SCJ.OnlineBooking.BookingHearingResult> CoAQueueHearingAsync(SCJ.OnlineBooking.CoABookingHearingInfo bookingInfo)
        {
            return base.Channel.CoAQueueHearingAsync(bookingInfo);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IOnlineBooking))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                result.Security.Mode = System.ServiceModel.BasicHttpSecurityMode.Transport;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IOnlineBooking))
            {
                return new System.ServiceModel.EndpointAddress("https://localhost:8092/OnlineBooking.svc");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return OnlineBookingClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_IOnlineBooking);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return OnlineBookingClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_IOnlineBooking);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_IOnlineBooking,
        }
    }
}
