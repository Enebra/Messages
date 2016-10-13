// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: datatypes/group.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace DataTypes {

  /// <summary>Holder for reflection information generated from datatypes/group.proto</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public static partial class GroupReflection {

    #region Descriptor
    /// <summary>File descriptor for datatypes/group.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GroupReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChVkYXRhdHlwZXMvZ3JvdXAucHJvdG8SCURhdGFUeXBlcxocZGF0YXR5cGVz",
            "L3Zpc2l0X3JlY29yZC5wcm90bxoTZGF0YXR5cGVzL2tleS5wcm90byKyAQoF",
            "R3JvdXASGgoCaWQYASABKAsyDi5EYXRhVHlwZXMuS2V5EgwKBG5hbWUYAiAB",
            "KAkSEwoLZGVzY3JpcHRpb24YAyABKAkSJgoGYWNjZXNzGAQgASgOMhYuRGF0",
            "YVR5cGVzLkFjY2Vzc1N0YXRlEh8KB3BlcnNvbnMYBSADKAsyDi5EYXRhVHlw",
            "ZXMuS2V5EiEKCWxvY2F0aW9ucxgGIAMoCzIOLkRhdGFUeXBlcy5LZXkiOAoG",
            "R3JvdXBzEh8KBWl0ZW1zGAEgAygLMhAuRGF0YVR5cGVzLkdyb3VwEg0KBWNv",
            "dW50GAIgASgDQkoKB2V4LmdycGNaOWdpdGh1Yi5jb20vRW5lYnJhL1NlcnZp",
            "Y2VDb29yZGluYXRvci9ncnBjL2RhdGF0eXBlcy9ncm91cKICA1JUR2IGcHJv",
            "dG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::DataTypes.VisitRecordReflection.Descriptor, global::DataTypes.KeyReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::DataTypes.Group), global::DataTypes.Group.Parser, new[]{ "Id", "Name", "Description", "Access", "Persons", "Locations" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::DataTypes.Groups), global::DataTypes.Groups.Parser, new[]{ "Items", "Count" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class Group : pb::IMessage<Group> {
    private static readonly pb::MessageParser<Group> _parser = new pb::MessageParser<Group>(() => new Group());
    public static pb::MessageParser<Group> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::DataTypes.GroupReflection.Descriptor.MessageTypes[0]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public Group() {
      OnConstruction();
    }

    partial void OnConstruction();

    public Group(Group other) : this() {
      Id = other.id_ != null ? other.Id.Clone() : null;
      name_ = other.name_;
      description_ = other.description_;
      access_ = other.access_;
      persons_ = other.persons_.Clone();
      locations_ = other.locations_.Clone();
    }

    public Group Clone() {
      return new Group(this);
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 1;
    private global::DataTypes.Key id_;
    public global::DataTypes.Key Id {
      get { return id_; }
      set {
        id_ = value;
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

    /// <summary>Field number for the "description" field.</summary>
    public const int DescriptionFieldNumber = 3;
    private string description_ = "";
    public string Description {
      get { return description_; }
      set {
        description_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "access" field.</summary>
    public const int AccessFieldNumber = 4;
    private global::DataTypes.AccessState access_ = 0;
    public global::DataTypes.AccessState Access {
      get { return access_; }
      set {
        access_ = value;
      }
    }

    /// <summary>Field number for the "persons" field.</summary>
    public const int PersonsFieldNumber = 5;
    private static readonly pb::FieldCodec<global::DataTypes.Key> _repeated_persons_codec
        = pb::FieldCodec.ForMessage(42, global::DataTypes.Key.Parser);
    private readonly pbc::RepeatedField<global::DataTypes.Key> persons_ = new pbc::RepeatedField<global::DataTypes.Key>();
    public pbc::RepeatedField<global::DataTypes.Key> Persons {
      get { return persons_; }
    }

    /// <summary>Field number for the "locations" field.</summary>
    public const int LocationsFieldNumber = 6;
    private static readonly pb::FieldCodec<global::DataTypes.Key> _repeated_locations_codec
        = pb::FieldCodec.ForMessage(50, global::DataTypes.Key.Parser);
    private readonly pbc::RepeatedField<global::DataTypes.Key> locations_ = new pbc::RepeatedField<global::DataTypes.Key>();
    public pbc::RepeatedField<global::DataTypes.Key> Locations {
      get { return locations_; }
    }

    public override bool Equals(object other) {
      return Equals(other as Group);
    }

    public bool Equals(Group other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Id, other.Id)) return false;
      if (Name != other.Name) return false;
      if (Description != other.Description) return false;
      if (Access != other.Access) return false;
      if(!persons_.Equals(other.persons_)) return false;
      if(!locations_.Equals(other.locations_)) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (id_ != null) hash ^= Id.GetHashCode();
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (Description.Length != 0) hash ^= Description.GetHashCode();
      if (Access != 0) hash ^= Access.GetHashCode();
      hash ^= persons_.GetHashCode();
      hash ^= locations_.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (id_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Id);
      }
      if (Name.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Name);
      }
      if (Description.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Description);
      }
      if (Access != 0) {
        output.WriteRawTag(32);
        output.WriteEnum((int) Access);
      }
      persons_.WriteTo(output, _repeated_persons_codec);
      locations_.WriteTo(output, _repeated_locations_codec);
    }

    public int CalculateSize() {
      int size = 0;
      if (id_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Id);
      }
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (Description.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Description);
      }
      if (Access != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Access);
      }
      size += persons_.CalculateSize(_repeated_persons_codec);
      size += locations_.CalculateSize(_repeated_locations_codec);
      return size;
    }

    public void MergeFrom(Group other) {
      if (other == null) {
        return;
      }
      if (other.id_ != null) {
        if (id_ == null) {
          id_ = new global::DataTypes.Key();
        }
        Id.MergeFrom(other.Id);
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.Description.Length != 0) {
        Description = other.Description;
      }
      if (other.Access != 0) {
        Access = other.Access;
      }
      persons_.Add(other.persons_);
      locations_.Add(other.locations_);
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            if (id_ == null) {
              id_ = new global::DataTypes.Key();
            }
            input.ReadMessage(id_);
            break;
          }
          case 18: {
            Name = input.ReadString();
            break;
          }
          case 26: {
            Description = input.ReadString();
            break;
          }
          case 32: {
            access_ = (global::DataTypes.AccessState) input.ReadEnum();
            break;
          }
          case 42: {
            persons_.AddEntriesFrom(input, _repeated_persons_codec);
            break;
          }
          case 50: {
            locations_.AddEntriesFrom(input, _repeated_locations_codec);
            break;
          }
        }
      }
    }

  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class Groups : pb::IMessage<Groups> {
    private static readonly pb::MessageParser<Groups> _parser = new pb::MessageParser<Groups>(() => new Groups());
    public static pb::MessageParser<Groups> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::DataTypes.GroupReflection.Descriptor.MessageTypes[1]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public Groups() {
      OnConstruction();
    }

    partial void OnConstruction();

    public Groups(Groups other) : this() {
      items_ = other.items_.Clone();
      count_ = other.count_;
    }

    public Groups Clone() {
      return new Groups(this);
    }

    /// <summary>Field number for the "items" field.</summary>
    public const int ItemsFieldNumber = 1;
    private static readonly pb::FieldCodec<global::DataTypes.Group> _repeated_items_codec
        = pb::FieldCodec.ForMessage(10, global::DataTypes.Group.Parser);
    private readonly pbc::RepeatedField<global::DataTypes.Group> items_ = new pbc::RepeatedField<global::DataTypes.Group>();
    public pbc::RepeatedField<global::DataTypes.Group> Items {
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
      return Equals(other as Groups);
    }

    public bool Equals(Groups other) {
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

    public void MergeFrom(Groups other) {
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
