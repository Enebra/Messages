// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: services/queries.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Services {

  /// <summary>Holder for reflection information generated from services/queries.proto</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public static partial class QueriesReflection {

    #region Descriptor
    /// <summary>File descriptor for services/queries.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static QueriesReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChZzZXJ2aWNlcy9xdWVyaWVzLnByb3RvEghTZXJ2aWNlcxoXZGF0YXR5cGVz",
            "L3Zpc2l0b3IucHJvdG8i1QEKD0dldFBob3RvUmVxdWVzdBI5CgR0eXBlGAEg",
            "ASgOMisuU2VydmljZXMuR2V0UGhvdG9SZXF1ZXN0LlBob3RvUmVzcG9uc2VU",
            "eXBlEg8KB3BlcnNvbnMYAiADKAMSDgoGcGhvdG9zGAMgAygDEhwKBHBhZ2UY",
            "BCABKAsyDi5TZXJ2aWNlcy5QYWdlIkgKEVBob3RvUmVzcG9uc2VUeXBlEg0K",
            "CVVuZGVmaW5lZBAAEggKBEZ1bGwQARINCglPbmx5Qnl0ZXMQAhILCgdOb0J5",
            "dGVzEAMijQEKEEdldFBlcnNvblJlcXVlc3QSEwoLc2VhcmNoX3RleHQYASAB",
            "KAkSEgoKZmlyc3RfbmFtZRgCIAEoCRIRCglsYXN0X25hbWUYAyABKAkSDAoE",
            "Y2FyZBgEIAEoCRIRCglsb2NhdGlvbnMYBSADKAMSHAoEcGFnZRgGIAEoCzIO",
            "LlNlcnZpY2VzLlBhZ2UifwoSR2V0TG9jYXRpb25SZXF1ZXN0EhMKC3NlYXJj",
            "aF90ZXh0GAEgASgJEgwKBG5hbWUYAiABKAkSEwoLbWFjX2FkZHJlc3MYAyAB",
            "KAkSEwoLZGV2aWNlX25hbWUYBCABKAkSHAoEcGFnZRgFIAEoCzIOLlNlcnZp",
            "Y2VzLlBhZ2UiywEKEUdldFZpc2l0b3JSZXF1ZXN0EhMKC3NlYXJjaF90ZXh0",
            "GAEgASgJEiUKBXN0YXRlGAIgASgOMhYuRGF0YVR5cGVzLkFjY2Vzc1N0YXRl",
            "EhEKCWxvY2F0aW9ucxgDIAMoAxIPCgdwZXJzb25zGAQgAygDEhUKDWRhdGV0",
            "aW1lX2Zyb20YBSABKAMSEwoLZGF0ZXRpbWVfdG8YBiABKAMSDAoEY2FyZBgH",
            "IAEoCRIcCgRwYWdlGAggASgLMg4uU2VydmljZXMuUGFnZSIjCgRQYWdlEg0K",
            "BWluZGV4GAEgASgFEgwKBHNpemUYAiABKAVCDwoHZXguZ3JwY6ICA1JUR2IG",
            "cHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::DataTypes.VisitorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Services.GetPhotoRequest), global::Services.GetPhotoRequest.Parser, new[]{ "Type", "Persons", "Photos", "Page" }, null, new[]{ typeof(global::Services.GetPhotoRequest.Types.PhotoResponseType) }, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Services.GetPersonRequest), global::Services.GetPersonRequest.Parser, new[]{ "SearchText", "FirstName", "LastName", "Card", "Locations", "Page" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Services.GetLocationRequest), global::Services.GetLocationRequest.Parser, new[]{ "SearchText", "Name", "MacAddress", "DeviceName", "Page" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Services.GetVisitorRequest), global::Services.GetVisitorRequest.Parser, new[]{ "SearchText", "State", "Locations", "Persons", "DatetimeFrom", "DatetimeTo", "Card", "Page" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Services.Page), global::Services.Page.Parser, new[]{ "Index", "Size" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class GetPhotoRequest : pb::IMessage<GetPhotoRequest> {
    private static readonly pb::MessageParser<GetPhotoRequest> _parser = new pb::MessageParser<GetPhotoRequest>(() => new GetPhotoRequest());
    public static pb::MessageParser<GetPhotoRequest> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::Services.QueriesReflection.Descriptor.MessageTypes[0]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public GetPhotoRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    public GetPhotoRequest(GetPhotoRequest other) : this() {
      type_ = other.type_;
      persons_ = other.persons_.Clone();
      photos_ = other.photos_.Clone();
      Page = other.page_ != null ? other.Page.Clone() : null;
    }

    public GetPhotoRequest Clone() {
      return new GetPhotoRequest(this);
    }

    /// <summary>Field number for the "type" field.</summary>
    public const int TypeFieldNumber = 1;
    private global::Services.GetPhotoRequest.Types.PhotoResponseType type_ = 0;
    public global::Services.GetPhotoRequest.Types.PhotoResponseType Type {
      get { return type_; }
      set {
        type_ = value;
      }
    }

    /// <summary>Field number for the "persons" field.</summary>
    public const int PersonsFieldNumber = 2;
    private static readonly pb::FieldCodec<long> _repeated_persons_codec
        = pb::FieldCodec.ForInt64(18);
    private readonly pbc::RepeatedField<long> persons_ = new pbc::RepeatedField<long>();
    public pbc::RepeatedField<long> Persons {
      get { return persons_; }
    }

    /// <summary>Field number for the "photos" field.</summary>
    public const int PhotosFieldNumber = 3;
    private static readonly pb::FieldCodec<long> _repeated_photos_codec
        = pb::FieldCodec.ForInt64(26);
    private readonly pbc::RepeatedField<long> photos_ = new pbc::RepeatedField<long>();
    public pbc::RepeatedField<long> Photos {
      get { return photos_; }
    }

    /// <summary>Field number for the "page" field.</summary>
    public const int PageFieldNumber = 4;
    private global::Services.Page page_;
    public global::Services.Page Page {
      get { return page_; }
      set {
        page_ = value;
      }
    }

    public override bool Equals(object other) {
      return Equals(other as GetPhotoRequest);
    }

    public bool Equals(GetPhotoRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Type != other.Type) return false;
      if(!persons_.Equals(other.persons_)) return false;
      if(!photos_.Equals(other.photos_)) return false;
      if (!object.Equals(Page, other.Page)) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (Type != 0) hash ^= Type.GetHashCode();
      hash ^= persons_.GetHashCode();
      hash ^= photos_.GetHashCode();
      if (page_ != null) hash ^= Page.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (Type != 0) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Type);
      }
      persons_.WriteTo(output, _repeated_persons_codec);
      photos_.WriteTo(output, _repeated_photos_codec);
      if (page_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(Page);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (Type != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Type);
      }
      size += persons_.CalculateSize(_repeated_persons_codec);
      size += photos_.CalculateSize(_repeated_photos_codec);
      if (page_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Page);
      }
      return size;
    }

    public void MergeFrom(GetPhotoRequest other) {
      if (other == null) {
        return;
      }
      if (other.Type != 0) {
        Type = other.Type;
      }
      persons_.Add(other.persons_);
      photos_.Add(other.photos_);
      if (other.page_ != null) {
        if (page_ == null) {
          page_ = new global::Services.Page();
        }
        Page.MergeFrom(other.Page);
      }
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            type_ = (global::Services.GetPhotoRequest.Types.PhotoResponseType) input.ReadEnum();
            break;
          }
          case 18:
          case 16: {
            persons_.AddEntriesFrom(input, _repeated_persons_codec);
            break;
          }
          case 26:
          case 24: {
            photos_.AddEntriesFrom(input, _repeated_photos_codec);
            break;
          }
          case 34: {
            if (page_ == null) {
              page_ = new global::Services.Page();
            }
            input.ReadMessage(page_);
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the GetPhotoRequest message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public static partial class Types {
      public enum PhotoResponseType {
        [pbr::OriginalName("Undefined")] Undefined = 0,
        [pbr::OriginalName("Full")] Full = 1,
        [pbr::OriginalName("OnlyBytes")] OnlyBytes = 2,
        [pbr::OriginalName("NoBytes")] NoBytes = 3,
      }

    }
    #endregion

  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class GetPersonRequest : pb::IMessage<GetPersonRequest> {
    private static readonly pb::MessageParser<GetPersonRequest> _parser = new pb::MessageParser<GetPersonRequest>(() => new GetPersonRequest());
    public static pb::MessageParser<GetPersonRequest> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::Services.QueriesReflection.Descriptor.MessageTypes[1]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public GetPersonRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    public GetPersonRequest(GetPersonRequest other) : this() {
      searchText_ = other.searchText_;
      firstName_ = other.firstName_;
      lastName_ = other.lastName_;
      card_ = other.card_;
      locations_ = other.locations_.Clone();
      Page = other.page_ != null ? other.Page.Clone() : null;
    }

    public GetPersonRequest Clone() {
      return new GetPersonRequest(this);
    }

    /// <summary>Field number for the "search_text" field.</summary>
    public const int SearchTextFieldNumber = 1;
    private string searchText_ = "";
    /// <summary>
    /// search in first name, search in surname
    /// </summary>
    public string SearchText {
      get { return searchText_; }
      set {
        searchText_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "first_name" field.</summary>
    public const int FirstNameFieldNumber = 2;
    private string firstName_ = "";
    public string FirstName {
      get { return firstName_; }
      set {
        firstName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "last_name" field.</summary>
    public const int LastNameFieldNumber = 3;
    private string lastName_ = "";
    public string LastName {
      get { return lastName_; }
      set {
        lastName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "card" field.</summary>
    public const int CardFieldNumber = 4;
    private string card_ = "";
    public string Card {
      get { return card_; }
      set {
        card_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "locations" field.</summary>
    public const int LocationsFieldNumber = 5;
    private static readonly pb::FieldCodec<long> _repeated_locations_codec
        = pb::FieldCodec.ForInt64(42);
    private readonly pbc::RepeatedField<long> locations_ = new pbc::RepeatedField<long>();
    /// <summary>
    /// TODO Photo    photo
    /// TODO Rights   rights
    /// </summary>
    public pbc::RepeatedField<long> Locations {
      get { return locations_; }
    }

    /// <summary>Field number for the "page" field.</summary>
    public const int PageFieldNumber = 6;
    private global::Services.Page page_;
    public global::Services.Page Page {
      get { return page_; }
      set {
        page_ = value;
      }
    }

    public override bool Equals(object other) {
      return Equals(other as GetPersonRequest);
    }

    public bool Equals(GetPersonRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (SearchText != other.SearchText) return false;
      if (FirstName != other.FirstName) return false;
      if (LastName != other.LastName) return false;
      if (Card != other.Card) return false;
      if(!locations_.Equals(other.locations_)) return false;
      if (!object.Equals(Page, other.Page)) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (SearchText.Length != 0) hash ^= SearchText.GetHashCode();
      if (FirstName.Length != 0) hash ^= FirstName.GetHashCode();
      if (LastName.Length != 0) hash ^= LastName.GetHashCode();
      if (Card.Length != 0) hash ^= Card.GetHashCode();
      hash ^= locations_.GetHashCode();
      if (page_ != null) hash ^= Page.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (SearchText.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(SearchText);
      }
      if (FirstName.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(FirstName);
      }
      if (LastName.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(LastName);
      }
      if (Card.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Card);
      }
      locations_.WriteTo(output, _repeated_locations_codec);
      if (page_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(Page);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (SearchText.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(SearchText);
      }
      if (FirstName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(FirstName);
      }
      if (LastName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(LastName);
      }
      if (Card.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Card);
      }
      size += locations_.CalculateSize(_repeated_locations_codec);
      if (page_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Page);
      }
      return size;
    }

    public void MergeFrom(GetPersonRequest other) {
      if (other == null) {
        return;
      }
      if (other.SearchText.Length != 0) {
        SearchText = other.SearchText;
      }
      if (other.FirstName.Length != 0) {
        FirstName = other.FirstName;
      }
      if (other.LastName.Length != 0) {
        LastName = other.LastName;
      }
      if (other.Card.Length != 0) {
        Card = other.Card;
      }
      locations_.Add(other.locations_);
      if (other.page_ != null) {
        if (page_ == null) {
          page_ = new global::Services.Page();
        }
        Page.MergeFrom(other.Page);
      }
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            SearchText = input.ReadString();
            break;
          }
          case 18: {
            FirstName = input.ReadString();
            break;
          }
          case 26: {
            LastName = input.ReadString();
            break;
          }
          case 34: {
            Card = input.ReadString();
            break;
          }
          case 42:
          case 40: {
            locations_.AddEntriesFrom(input, _repeated_locations_codec);
            break;
          }
          case 50: {
            if (page_ == null) {
              page_ = new global::Services.Page();
            }
            input.ReadMessage(page_);
            break;
          }
        }
      }
    }

  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class GetLocationRequest : pb::IMessage<GetLocationRequest> {
    private static readonly pb::MessageParser<GetLocationRequest> _parser = new pb::MessageParser<GetLocationRequest>(() => new GetLocationRequest());
    public static pb::MessageParser<GetLocationRequest> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::Services.QueriesReflection.Descriptor.MessageTypes[2]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public GetLocationRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    public GetLocationRequest(GetLocationRequest other) : this() {
      searchText_ = other.searchText_;
      name_ = other.name_;
      macAddress_ = other.macAddress_;
      deviceName_ = other.deviceName_;
      Page = other.page_ != null ? other.Page.Clone() : null;
    }

    public GetLocationRequest Clone() {
      return new GetLocationRequest(this);
    }

    /// <summary>Field number for the "search_text" field.</summary>
    public const int SearchTextFieldNumber = 1;
    private string searchText_ = "";
    /// <summary>
    /// search in name, description
    /// </summary>
    public string SearchText {
      get { return searchText_; }
      set {
        searchText_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 2;
    private string name_ = "";
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "mac_address" field.</summary>
    public const int MacAddressFieldNumber = 3;
    private string macAddress_ = "";
    public string MacAddress {
      get { return macAddress_; }
      set {
        macAddress_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "device_name" field.</summary>
    public const int DeviceNameFieldNumber = 4;
    private string deviceName_ = "";
    public string DeviceName {
      get { return deviceName_; }
      set {
        deviceName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "page" field.</summary>
    public const int PageFieldNumber = 5;
    private global::Services.Page page_;
    public global::Services.Page Page {
      get { return page_; }
      set {
        page_ = value;
      }
    }

    public override bool Equals(object other) {
      return Equals(other as GetLocationRequest);
    }

    public bool Equals(GetLocationRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (SearchText != other.SearchText) return false;
      if (Name != other.Name) return false;
      if (MacAddress != other.MacAddress) return false;
      if (DeviceName != other.DeviceName) return false;
      if (!object.Equals(Page, other.Page)) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (SearchText.Length != 0) hash ^= SearchText.GetHashCode();
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (MacAddress.Length != 0) hash ^= MacAddress.GetHashCode();
      if (DeviceName.Length != 0) hash ^= DeviceName.GetHashCode();
      if (page_ != null) hash ^= Page.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (SearchText.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(SearchText);
      }
      if (Name.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Name);
      }
      if (MacAddress.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(MacAddress);
      }
      if (DeviceName.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(DeviceName);
      }
      if (page_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(Page);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (SearchText.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(SearchText);
      }
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (MacAddress.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(MacAddress);
      }
      if (DeviceName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(DeviceName);
      }
      if (page_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Page);
      }
      return size;
    }

    public void MergeFrom(GetLocationRequest other) {
      if (other == null) {
        return;
      }
      if (other.SearchText.Length != 0) {
        SearchText = other.SearchText;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.MacAddress.Length != 0) {
        MacAddress = other.MacAddress;
      }
      if (other.DeviceName.Length != 0) {
        DeviceName = other.DeviceName;
      }
      if (other.page_ != null) {
        if (page_ == null) {
          page_ = new global::Services.Page();
        }
        Page.MergeFrom(other.Page);
      }
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            SearchText = input.ReadString();
            break;
          }
          case 18: {
            Name = input.ReadString();
            break;
          }
          case 26: {
            MacAddress = input.ReadString();
            break;
          }
          case 34: {
            DeviceName = input.ReadString();
            break;
          }
          case 42: {
            if (page_ == null) {
              page_ = new global::Services.Page();
            }
            input.ReadMessage(page_);
            break;
          }
        }
      }
    }

  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class GetVisitorRequest : pb::IMessage<GetVisitorRequest> {
    private static readonly pb::MessageParser<GetVisitorRequest> _parser = new pb::MessageParser<GetVisitorRequest>(() => new GetVisitorRequest());
    public static pb::MessageParser<GetVisitorRequest> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::Services.QueriesReflection.Descriptor.MessageTypes[3]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public GetVisitorRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    public GetVisitorRequest(GetVisitorRequest other) : this() {
      searchText_ = other.searchText_;
      state_ = other.state_;
      locations_ = other.locations_.Clone();
      persons_ = other.persons_.Clone();
      datetimeFrom_ = other.datetimeFrom_;
      datetimeTo_ = other.datetimeTo_;
      card_ = other.card_;
      Page = other.page_ != null ? other.Page.Clone() : null;
    }

    public GetVisitorRequest Clone() {
      return new GetVisitorRequest(this);
    }

    /// <summary>Field number for the "search_text" field.</summary>
    public const int SearchTextFieldNumber = 1;
    private string searchText_ = "";
    public string SearchText {
      get { return searchText_; }
      set {
        searchText_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "state" field.</summary>
    public const int StateFieldNumber = 2;
    private global::DataTypes.AccessState state_ = 0;
    public global::DataTypes.AccessState State {
      get { return state_; }
      set {
        state_ = value;
      }
    }

    /// <summary>Field number for the "locations" field.</summary>
    public const int LocationsFieldNumber = 3;
    private static readonly pb::FieldCodec<long> _repeated_locations_codec
        = pb::FieldCodec.ForInt64(26);
    private readonly pbc::RepeatedField<long> locations_ = new pbc::RepeatedField<long>();
    public pbc::RepeatedField<long> Locations {
      get { return locations_; }
    }

    /// <summary>Field number for the "persons" field.</summary>
    public const int PersonsFieldNumber = 4;
    private static readonly pb::FieldCodec<long> _repeated_persons_codec
        = pb::FieldCodec.ForInt64(34);
    private readonly pbc::RepeatedField<long> persons_ = new pbc::RepeatedField<long>();
    public pbc::RepeatedField<long> Persons {
      get { return persons_; }
    }

    /// <summary>Field number for the "datetime_from" field.</summary>
    public const int DatetimeFromFieldNumber = 5;
    private long datetimeFrom_;
    public long DatetimeFrom {
      get { return datetimeFrom_; }
      set {
        datetimeFrom_ = value;
      }
    }

    /// <summary>Field number for the "datetime_to" field.</summary>
    public const int DatetimeToFieldNumber = 6;
    private long datetimeTo_;
    public long DatetimeTo {
      get { return datetimeTo_; }
      set {
        datetimeTo_ = value;
      }
    }

    /// <summary>Field number for the "card" field.</summary>
    public const int CardFieldNumber = 7;
    private string card_ = "";
    public string Card {
      get { return card_; }
      set {
        card_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "page" field.</summary>
    public const int PageFieldNumber = 8;
    private global::Services.Page page_;
    public global::Services.Page Page {
      get { return page_; }
      set {
        page_ = value;
      }
    }

    public override bool Equals(object other) {
      return Equals(other as GetVisitorRequest);
    }

    public bool Equals(GetVisitorRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (SearchText != other.SearchText) return false;
      if (State != other.State) return false;
      if(!locations_.Equals(other.locations_)) return false;
      if(!persons_.Equals(other.persons_)) return false;
      if (DatetimeFrom != other.DatetimeFrom) return false;
      if (DatetimeTo != other.DatetimeTo) return false;
      if (Card != other.Card) return false;
      if (!object.Equals(Page, other.Page)) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (SearchText.Length != 0) hash ^= SearchText.GetHashCode();
      if (State != 0) hash ^= State.GetHashCode();
      hash ^= locations_.GetHashCode();
      hash ^= persons_.GetHashCode();
      if (DatetimeFrom != 0L) hash ^= DatetimeFrom.GetHashCode();
      if (DatetimeTo != 0L) hash ^= DatetimeTo.GetHashCode();
      if (Card.Length != 0) hash ^= Card.GetHashCode();
      if (page_ != null) hash ^= Page.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (SearchText.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(SearchText);
      }
      if (State != 0) {
        output.WriteRawTag(16);
        output.WriteEnum((int) State);
      }
      locations_.WriteTo(output, _repeated_locations_codec);
      persons_.WriteTo(output, _repeated_persons_codec);
      if (DatetimeFrom != 0L) {
        output.WriteRawTag(40);
        output.WriteInt64(DatetimeFrom);
      }
      if (DatetimeTo != 0L) {
        output.WriteRawTag(48);
        output.WriteInt64(DatetimeTo);
      }
      if (Card.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(Card);
      }
      if (page_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(Page);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (SearchText.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(SearchText);
      }
      if (State != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) State);
      }
      size += locations_.CalculateSize(_repeated_locations_codec);
      size += persons_.CalculateSize(_repeated_persons_codec);
      if (DatetimeFrom != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(DatetimeFrom);
      }
      if (DatetimeTo != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(DatetimeTo);
      }
      if (Card.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Card);
      }
      if (page_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Page);
      }
      return size;
    }

    public void MergeFrom(GetVisitorRequest other) {
      if (other == null) {
        return;
      }
      if (other.SearchText.Length != 0) {
        SearchText = other.SearchText;
      }
      if (other.State != 0) {
        State = other.State;
      }
      locations_.Add(other.locations_);
      persons_.Add(other.persons_);
      if (other.DatetimeFrom != 0L) {
        DatetimeFrom = other.DatetimeFrom;
      }
      if (other.DatetimeTo != 0L) {
        DatetimeTo = other.DatetimeTo;
      }
      if (other.Card.Length != 0) {
        Card = other.Card;
      }
      if (other.page_ != null) {
        if (page_ == null) {
          page_ = new global::Services.Page();
        }
        Page.MergeFrom(other.Page);
      }
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            SearchText = input.ReadString();
            break;
          }
          case 16: {
            state_ = (global::DataTypes.AccessState) input.ReadEnum();
            break;
          }
          case 26:
          case 24: {
            locations_.AddEntriesFrom(input, _repeated_locations_codec);
            break;
          }
          case 34:
          case 32: {
            persons_.AddEntriesFrom(input, _repeated_persons_codec);
            break;
          }
          case 40: {
            DatetimeFrom = input.ReadInt64();
            break;
          }
          case 48: {
            DatetimeTo = input.ReadInt64();
            break;
          }
          case 58: {
            Card = input.ReadString();
            break;
          }
          case 66: {
            if (page_ == null) {
              page_ = new global::Services.Page();
            }
            input.ReadMessage(page_);
            break;
          }
        }
      }
    }

  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class Page : pb::IMessage<Page> {
    private static readonly pb::MessageParser<Page> _parser = new pb::MessageParser<Page>(() => new Page());
    public static pb::MessageParser<Page> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::Services.QueriesReflection.Descriptor.MessageTypes[4]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public Page() {
      OnConstruction();
    }

    partial void OnConstruction();

    public Page(Page other) : this() {
      index_ = other.index_;
      size_ = other.size_;
    }

    public Page Clone() {
      return new Page(this);
    }

    /// <summary>Field number for the "index" field.</summary>
    public const int IndexFieldNumber = 1;
    private int index_;
    public int Index {
      get { return index_; }
      set {
        index_ = value;
      }
    }

    /// <summary>Field number for the "size" field.</summary>
    public const int SizeFieldNumber = 2;
    private int size_;
    public int Size {
      get { return size_; }
      set {
        size_ = value;
      }
    }

    public override bool Equals(object other) {
      return Equals(other as Page);
    }

    public bool Equals(Page other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Index != other.Index) return false;
      if (Size != other.Size) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (Index != 0) hash ^= Index.GetHashCode();
      if (Size != 0) hash ^= Size.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (Index != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Index);
      }
      if (Size != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(Size);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (Index != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Index);
      }
      if (Size != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Size);
      }
      return size;
    }

    public void MergeFrom(Page other) {
      if (other == null) {
        return;
      }
      if (other.Index != 0) {
        Index = other.Index;
      }
      if (other.Size != 0) {
        Size = other.Size;
      }
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            Index = input.ReadInt32();
            break;
          }
          case 16: {
            Size = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
