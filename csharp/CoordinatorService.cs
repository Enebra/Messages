// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: services/coordinator_service.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Services {

  /// <summary>Holder for reflection information generated from services/coordinator_service.proto</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public static partial class CoordinatorServiceReflection {

    #region Descriptor
    /// <summary>File descriptor for services/coordinator_service.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CoordinatorServiceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiJzZXJ2aWNlcy9jb29yZGluYXRvcl9zZXJ2aWNlLnByb3RvEghTZXJ2aWNl",
            "cxobZ29vZ2xlL3Byb3RvYnVmL2VtcHR5LnByb3RvGhRkYXRhdHlwZXMvdW5p",
            "dC5wcm90bxoUZGF0YXR5cGVzL2RhdGEucHJvdG8aF2RhdGF0eXBlcy9kZXZp",
            "Y2VzLnByb3RvIiYKEEhlYXJ0YmVhdE1lc3NhZ2USEgoKc2VydmljZV9pZBgB",
            "IAEoCSo/CgtTZXJ2aWNlVHlwZRINCglOb25lX1R5cGUQABIKCgZGYWNpYWwQ",
            "ARILCgdBcHBVbml0EAISCAoEVW5pdBADMo0EChJDb29yZGluYXRvclNlcnZp",
            "Y2USPQoHQ29ubmVjdBIYLkRhdGFUeXBlcy5Db25uZWN0ZWRVbml0GhYuZ29v",
            "Z2xlLnByb3RvYnVmLkVtcHR5IgASQQoJSGVhcnRiZWF0EhouU2VydmljZXMu",
            "SGVhcnRiZWF0TWVzc2FnZRoWLmdvb2dsZS5wcm90b2J1Zi5FbXB0eSIAEjYK",
            "CEdldFVuaXRzEhYuZ29vZ2xlLnByb3RvYnVmLkVtcHR5GhAuRGF0YVR5cGVz",
            "LlVuaXRzIgASPwoJU3Vic2NyaWJlEhguRGF0YVR5cGVzLkNvbm5lY3RlZFVu",
            "aXQaFi5nb29nbGUucHJvdG9idWYuRW1wdHkiABJBCgtVbnN1YnNjcmliZRIY",
            "LkRhdGFUeXBlcy5Db25uZWN0ZWRVbml0GhYuZ29vZ2xlLnByb3RvYnVmLkVt",
            "cHR5IgASOQoDR2V0EhcuRGF0YVR5cGVzLk1lc3NhZ2VCeXRlcxoXLkRhdGFU",
            "eXBlcy5NZXNzYWdlQnl0ZXMiABI8CgZDb21taXQSFy5EYXRhVHlwZXMuTWVz",
            "c2FnZUJ5dGVzGhcuRGF0YVR5cGVzLk1lc3NhZ2VCeXRlcyIAEkAKC1B1c2hV",
            "cGRhdGVzEhcuRGF0YVR5cGVzLkRldmljZVVwZGF0ZRoWLmdvb2dsZS5wcm90",
            "b2J1Zi5FbXB0eSIAQlYKB2V4LmdycGNaRWdpdGh1Yi5jb20vRW5lYnJhL1Nl",
            "cnZpY2VDb29yZGluYXRvci9ncnBjL3NlcnZpY2VzL2Nvb3JkaW5hdG9yc2Vy",
            "dmljZaICA1JUR2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.EmptyReflection.Descriptor, global::DataTypes.UnitReflection.Descriptor, global::DataTypes.DataReflection.Descriptor, global::DataTypes.DevicesReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Services.ServiceType), }, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Services.HeartbeatMessage), global::Services.HeartbeatMessage.Parser, new[]{ "ServiceId" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Enums
  public enum ServiceType {
    [pbr::OriginalName("None_Type")] NoneType = 0,
    [pbr::OriginalName("Facial")] Facial = 1,
    [pbr::OriginalName("AppUnit")] AppUnit = 2,
    [pbr::OriginalName("Unit")] Unit = 3,
  }

  #endregion

  #region Messages
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class HeartbeatMessage : pb::IMessage<HeartbeatMessage> {
    private static readonly pb::MessageParser<HeartbeatMessage> _parser = new pb::MessageParser<HeartbeatMessage>(() => new HeartbeatMessage());
    public static pb::MessageParser<HeartbeatMessage> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::Services.CoordinatorServiceReflection.Descriptor.MessageTypes[0]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public HeartbeatMessage() {
      OnConstruction();
    }

    partial void OnConstruction();

    public HeartbeatMessage(HeartbeatMessage other) : this() {
      serviceId_ = other.serviceId_;
    }

    public HeartbeatMessage Clone() {
      return new HeartbeatMessage(this);
    }

    /// <summary>Field number for the "service_id" field.</summary>
    public const int ServiceIdFieldNumber = 1;
    private string serviceId_ = "";
    public string ServiceId {
      get { return serviceId_; }
      set {
        serviceId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    public override bool Equals(object other) {
      return Equals(other as HeartbeatMessage);
    }

    public bool Equals(HeartbeatMessage other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ServiceId != other.ServiceId) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (ServiceId.Length != 0) hash ^= ServiceId.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (ServiceId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ServiceId);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (ServiceId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ServiceId);
      }
      return size;
    }

    public void MergeFrom(HeartbeatMessage other) {
      if (other == null) {
        return;
      }
      if (other.ServiceId.Length != 0) {
        ServiceId = other.ServiceId;
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
            ServiceId = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
