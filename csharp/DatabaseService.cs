// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: services/database_service.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Services {

  /// <summary>Holder for reflection information generated from services/database_service.proto</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public static partial class DatabaseServiceReflection {

    #region Descriptor
    /// <summary>File descriptor for services/database_service.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DatabaseServiceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch9zZXJ2aWNlcy9kYXRhYmFzZV9zZXJ2aWNlLnByb3RvEghTZXJ2aWNlcxob",
            "Z29vZ2xlL3Byb3RvYnVmL2VtcHR5LnByb3RvGhZkYXRhdHlwZXMvcGVyc29u",
            "LnByb3RvGhRkYXRhdHlwZXMvY2FyZC5wcm90bxoYZGF0YXR5cGVzL2xvY2F0",
            "aW9uLnByb3RvGhdkYXRhdHlwZXMvdmlzaXRvci5wcm90byIWCgVRdWVyeRIN",
            "CgVxdWVyeRgBIAEoCTKxBwoORGF0YWJhc2VTZXZpY2USMgoJR2V0UGVyc29u",
            "Eg8uU2VydmljZXMuUXVlcnkaEi5EYXRhVHlwZXMuUGVyc29ucyIAEjYKDElu",
            "c2VydFBlcnNvbhIRLkRhdGFUeXBlcy5QZXJzb24aES5EYXRhVHlwZXMuUGVy",
            "c29uIgASOwoMVXBkYXRlUGVyc29uEhEuRGF0YVR5cGVzLlBlcnNvbhoWLmdv",
            "b2dsZS5wcm90b2J1Zi5FbXB0eSIAEjsKDERlbGV0ZVBlcnNvbhIRLkRhdGFU",
            "eXBlcy5QZXJzb24aFi5nb29nbGUucHJvdG9idWYuRW1wdHkiABIuCgdHZXRD",
            "YXJkEg8uU2VydmljZXMuUXVlcnkaEC5EYXRhVHlwZXMuQ2FyZHMiABIwCgpJ",
            "bnNlcnRDYXJkEg8uRGF0YVR5cGVzLkNhcmQaDy5EYXRhVHlwZXMuQ2FyZCIA",
            "EjcKClVwZGF0ZUNhcmQSDy5EYXRhVHlwZXMuQ2FyZBoWLmdvb2dsZS5wcm90",
            "b2J1Zi5FbXB0eSIAEjcKCkRlbGV0ZUNhcmQSDy5EYXRhVHlwZXMuQ2FyZBoW",
            "Lmdvb2dsZS5wcm90b2J1Zi5FbXB0eSIAEjYKC0dldExvY2F0aW9uEg8uU2Vy",
            "dmljZXMuUXVlcnkaFC5EYXRhVHlwZXMuTG9jYXRpb25zIgASPAoOSW5zZXJ0",
            "TG9jYXRpb24SEy5EYXRhVHlwZXMuTG9jYXRpb24aEy5EYXRhVHlwZXMuTG9j",
            "YXRpb24iABI/Cg5VcGRhdGVMb2NhdGlvbhITLkRhdGFUeXBlcy5Mb2NhdGlv",
            "bhoWLmdvb2dsZS5wcm90b2J1Zi5FbXB0eSIAEj8KDkRlbGV0ZUxvY2F0aW9u",
            "EhMuRGF0YVR5cGVzLkxvY2F0aW9uGhYuZ29vZ2xlLnByb3RvYnVmLkVtcHR5",
            "IgASNAoKR2V0VmlzaXRvchIPLlNlcnZpY2VzLlF1ZXJ5GhMuRGF0YVR5cGVz",
            "LlZpc2l0b3JzIgASOQoNSW5zZXJ0VmlzaXRvchISLkRhdGFUeXBlcy5WaXNp",
            "dG9yGhIuRGF0YVR5cGVzLlZpc2l0b3IiABI9Cg1VcGRhdGVWaXNpdG9yEhIu",
            "RGF0YVR5cGVzLlZpc2l0b3IaFi5nb29nbGUucHJvdG9idWYuRW1wdHkiABI9",
            "Cg1EZWxldGVWaXNpdG9yEhIuRGF0YVR5cGVzLlZpc2l0b3IaFi5nb29nbGUu",
            "cHJvdG9idWYuRW1wdHkiAEIPCgdleC5ncnBjogIDUlRHYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.EmptyReflection.Descriptor, global::DataTypes.PersonReflection.Descriptor, global::DataTypes.CardReflection.Descriptor, global::DataTypes.LocationReflection.Descriptor, global::DataTypes.VisitorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Services.Query), global::Services.Query.Parser, new[]{ "Query_" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class Query : pb::IMessage<Query> {
    private static readonly pb::MessageParser<Query> _parser = new pb::MessageParser<Query>(() => new Query());
    public static pb::MessageParser<Query> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::Services.DatabaseServiceReflection.Descriptor.MessageTypes[0]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public Query() {
      OnConstruction();
    }

    partial void OnConstruction();

    public Query(Query other) : this() {
      query_ = other.query_;
    }

    public Query Clone() {
      return new Query(this);
    }

    /// <summary>Field number for the "query" field.</summary>
    public const int Query_FieldNumber = 1;
    private string query_ = "";
    public string Query_ {
      get { return query_; }
      set {
        query_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    public override bool Equals(object other) {
      return Equals(other as Query);
    }

    public bool Equals(Query other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Query_ != other.Query_) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (Query_.Length != 0) hash ^= Query_.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (Query_.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Query_);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (Query_.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Query_);
      }
      return size;
    }

    public void MergeFrom(Query other) {
      if (other == null) {
        return;
      }
      if (other.Query_.Length != 0) {
        Query_ = other.Query_;
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
            Query_ = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
