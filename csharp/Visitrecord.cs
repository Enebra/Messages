// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: datatypes/visit_record.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace DataTypes {

  /// <summary>Holder for reflection information generated from datatypes/visit_record.proto</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public static partial class VisitRecordReflection {

    #region Descriptor
    /// <summary>File descriptor for datatypes/visit_record.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static VisitRecordReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChxkYXRhdHlwZXMvdmlzaXRfcmVjb3JkLnByb3RvEglEYXRhVHlwZXMaFGRh",
            "dGF0eXBlcy9jYXJkLnByb3RvIpUBCgtWaXNpdFJlY29yZBIKCgJpZBgBIAEo",
            "CRIRCglwZXJzb25faWQYAiABKAkSEwoLbG9jYXRpb25faWQYAyABKAkSDAoE",
            "dGltZRgEIAEoAxIdCgRjYXJkGAUgASgLMg8uRGF0YVR5cGVzLkNhcmQSJQoF",
            "c3RhdGUYBiABKA4yFi5EYXRhVHlwZXMuQWNjZXNzU3RhdGUiRAoMVmlzaXRS",
            "ZWNvcmRzEiUKBWl0ZW1zGAEgAygLMhYuRGF0YVR5cGVzLlZpc2l0UmVjb3Jk",
            "Eg0KBWNvdW50GAIgASgDKjUKC0FjY2Vzc1N0YXRlEg0KCU5vbmVTdGF0ZRAA",
            "EgsKB0dyYW50ZWQQARIKCgZEZW5pZWQQAkIPCgdleC5ncnBjogIDUlRHYgZw",
            "cm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::DataTypes.CardReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::DataTypes.AccessState), }, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::DataTypes.VisitRecord), global::DataTypes.VisitRecord.Parser, new[]{ "Id", "PersonId", "LocationId", "Time", "Card", "State" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::DataTypes.VisitRecords), global::DataTypes.VisitRecords.Parser, new[]{ "Items", "Count" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Enums
  public enum AccessState {
    [pbr::OriginalName("NoneState")] NoneState = 0,
    [pbr::OriginalName("Granted")] Granted = 1,
    [pbr::OriginalName("Denied")] Denied = 2,
  }

  #endregion

  #region Messages
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class VisitRecord : pb::IMessage<VisitRecord> {
    private static readonly pb::MessageParser<VisitRecord> _parser = new pb::MessageParser<VisitRecord>(() => new VisitRecord());
    public static pb::MessageParser<VisitRecord> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::DataTypes.VisitRecordReflection.Descriptor.MessageTypes[0]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public VisitRecord() {
      OnConstruction();
    }

    partial void OnConstruction();

    public VisitRecord(VisitRecord other) : this() {
      id_ = other.id_;
      personId_ = other.personId_;
      locationId_ = other.locationId_;
      time_ = other.time_;
      Card = other.card_ != null ? other.Card.Clone() : null;
      state_ = other.state_;
    }

    public VisitRecord Clone() {
      return new VisitRecord(this);
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 1;
    private string id_ = "";
    public string Id {
      get { return id_; }
      set {
        id_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "person_id" field.</summary>
    public const int PersonIdFieldNumber = 2;
    private string personId_ = "";
    public string PersonId {
      get { return personId_; }
      set {
        personId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "location_id" field.</summary>
    public const int LocationIdFieldNumber = 3;
    private string locationId_ = "";
    public string LocationId {
      get { return locationId_; }
      set {
        locationId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "time" field.</summary>
    public const int TimeFieldNumber = 4;
    private long time_;
    public long Time {
      get { return time_; }
      set {
        time_ = value;
      }
    }

    /// <summary>Field number for the "card" field.</summary>
    public const int CardFieldNumber = 5;
    private global::DataTypes.Card card_;
    public global::DataTypes.Card Card {
      get { return card_; }
      set {
        card_ = value;
      }
    }

    /// <summary>Field number for the "state" field.</summary>
    public const int StateFieldNumber = 6;
    private global::DataTypes.AccessState state_ = 0;
    public global::DataTypes.AccessState State {
      get { return state_; }
      set {
        state_ = value;
      }
    }

    public override bool Equals(object other) {
      return Equals(other as VisitRecord);
    }

    public bool Equals(VisitRecord other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (PersonId != other.PersonId) return false;
      if (LocationId != other.LocationId) return false;
      if (Time != other.Time) return false;
      if (!object.Equals(Card, other.Card)) return false;
      if (State != other.State) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (Id.Length != 0) hash ^= Id.GetHashCode();
      if (PersonId.Length != 0) hash ^= PersonId.GetHashCode();
      if (LocationId.Length != 0) hash ^= LocationId.GetHashCode();
      if (Time != 0L) hash ^= Time.GetHashCode();
      if (card_ != null) hash ^= Card.GetHashCode();
      if (State != 0) hash ^= State.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (Id.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Id);
      }
      if (PersonId.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(PersonId);
      }
      if (LocationId.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(LocationId);
      }
      if (Time != 0L) {
        output.WriteRawTag(32);
        output.WriteInt64(Time);
      }
      if (card_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(Card);
      }
      if (State != 0) {
        output.WriteRawTag(48);
        output.WriteEnum((int) State);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (Id.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Id);
      }
      if (PersonId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(PersonId);
      }
      if (LocationId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(LocationId);
      }
      if (Time != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Time);
      }
      if (card_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Card);
      }
      if (State != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) State);
      }
      return size;
    }

    public void MergeFrom(VisitRecord other) {
      if (other == null) {
        return;
      }
      if (other.Id.Length != 0) {
        Id = other.Id;
      }
      if (other.PersonId.Length != 0) {
        PersonId = other.PersonId;
      }
      if (other.LocationId.Length != 0) {
        LocationId = other.LocationId;
      }
      if (other.Time != 0L) {
        Time = other.Time;
      }
      if (other.card_ != null) {
        if (card_ == null) {
          card_ = new global::DataTypes.Card();
        }
        Card.MergeFrom(other.Card);
      }
      if (other.State != 0) {
        State = other.State;
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
            Id = input.ReadString();
            break;
          }
          case 18: {
            PersonId = input.ReadString();
            break;
          }
          case 26: {
            LocationId = input.ReadString();
            break;
          }
          case 32: {
            Time = input.ReadInt64();
            break;
          }
          case 42: {
            if (card_ == null) {
              card_ = new global::DataTypes.Card();
            }
            input.ReadMessage(card_);
            break;
          }
          case 48: {
            state_ = (global::DataTypes.AccessState) input.ReadEnum();
            break;
          }
        }
      }
    }

  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class VisitRecords : pb::IMessage<VisitRecords> {
    private static readonly pb::MessageParser<VisitRecords> _parser = new pb::MessageParser<VisitRecords>(() => new VisitRecords());
    public static pb::MessageParser<VisitRecords> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::DataTypes.VisitRecordReflection.Descriptor.MessageTypes[1]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public VisitRecords() {
      OnConstruction();
    }

    partial void OnConstruction();

    public VisitRecords(VisitRecords other) : this() {
      items_ = other.items_.Clone();
      count_ = other.count_;
    }

    public VisitRecords Clone() {
      return new VisitRecords(this);
    }

    /// <summary>Field number for the "items" field.</summary>
    public const int ItemsFieldNumber = 1;
    private static readonly pb::FieldCodec<global::DataTypes.VisitRecord> _repeated_items_codec
        = pb::FieldCodec.ForMessage(10, global::DataTypes.VisitRecord.Parser);
    private readonly pbc::RepeatedField<global::DataTypes.VisitRecord> items_ = new pbc::RepeatedField<global::DataTypes.VisitRecord>();
    public pbc::RepeatedField<global::DataTypes.VisitRecord> Items {
      get { return items_; }
    }

    /// <summary>Field number for the "count" field.</summary>
    public const int CountFieldNumber = 2;
    private long count_;
    public long Count {
      get { return count_; }
      set {
        count_ = value;
      }
    }

    public override bool Equals(object other) {
      return Equals(other as VisitRecords);
    }

    public bool Equals(VisitRecords other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!items_.Equals(other.items_)) return false;
      if (Count != other.Count) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      hash ^= items_.GetHashCode();
      if (Count != 0L) hash ^= Count.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      items_.WriteTo(output, _repeated_items_codec);
      if (Count != 0L) {
        output.WriteRawTag(16);
        output.WriteInt64(Count);
      }
    }

    public int CalculateSize() {
      int size = 0;
      size += items_.CalculateSize(_repeated_items_codec);
      if (Count != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Count);
      }
      return size;
    }

    public void MergeFrom(VisitRecords other) {
      if (other == null) {
        return;
      }
      items_.Add(other.items_);
      if (other.Count != 0L) {
        Count = other.Count;
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
            items_.AddEntriesFrom(input, _repeated_items_codec);
            break;
          }
          case 16: {
            Count = input.ReadInt64();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
