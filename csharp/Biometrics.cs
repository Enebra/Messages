// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: datatypes/biometrics.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace DataTypes {

  /// <summary>Holder for reflection information generated from datatypes/biometrics.proto</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public static partial class BiometricsReflection {

    #region Descriptor
    /// <summary>File descriptor for datatypes/biometrics.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static BiometricsReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChpkYXRhdHlwZXMvYmlvbWV0cmljcy5wcm90bxIJRGF0YVR5cGVzGhhkYXRh",
            "dHlwZXMvZ2VvbWV0cnkucHJvdG8iNQoFRmFjZXMSLAoFRmFjZXMYASADKAsy",
            "HS5EYXRhVHlwZXMuRmFjZUNoYXJhY3RlcmlzdGljInYKEkZhY2VDaGFyYWN0",
            "ZXJpc3RpYxIKCgJpZBgBIAEoAxIbCgNib3gYAiABKAsyDi5EYXRhVHlwZXMu",
            "Qm94EhIKCmNvbmZpZGVuY2UYAyABKAISEQoJcGVyc29uX2lkGAQgASgDEhAK",
            "CHBob3RvX2lkGAUgASgDIicKBU1hdGNoEg8KB2ZhY2VfaWQYAiABKAMSDQoF",
            "bWF0Y2gYAyABKAIiPQoHTWF0Y2hlcxIPCgdmYWNlX2lkGAEgASgDEiEKB21h",
            "dGNoZXMYAiADKAsyEC5EYXRhVHlwZXMuTWF0Y2gqUwoNQmlvbWV0cmljVHlw",
            "ZRISCg5VbnNwZWNpZmllZEJpbxAAEgoKBkZhY2lhbBABEg8KC0ZpbmdlcnBy",
            "aW50EAISCAoESXJpcxADEgcKA0FsbBAEKj0KB0V5ZVR5cGUSEwoPVW5zcGVj",
            "aWZpZWRfRXllEAASCAoETGVmdBABEgkKBVJpZ2h0EAISCAoEQm90aBADKr0B",
            "CgZGaW5nZXISFgoSVW5zcGVjaWZpZWRfRmluZ2VyEAASDgoKUmlnaHRUaHVt",
            "YhABEg0KCUxlZnRUaHVtYhACEg4KClJpZ2h0SW5kZXgQAxINCglMZWZ0SW5k",
            "ZXgQBBIPCgtSaWdodE1pZGRsZRAFEg4KCkxlZnRNaWRkbGUQBhINCglSaWdo",
            "dFJpbmcQBxIMCghMZWZ0UmluZxAIEg8KC1JpZ2h0TGl0dGxlEAkSDgoKTGVm",
            "dExpdHRsZRAKKo4FChtGYWNpYWxJc29Db21wbGlhbmNlVGVtcGxhdGUSGwoX",
            "VW5zcGVjaWZpZWRfSXNvVGVtcGxhdGUQABIWChJPbmx5T25lRmFjZVZpc2li",
            "bGUQARIcChhnb29kVmVydGljYWxGYWNlUG9zaXRpb24QAhIcChhob3Jpem9u",
            "dGFsbHlDZW50ZXJlZEZhY2UQAxIPCgt3aWR0aE9mSGVhZBAEEhAKDGxlbmd0",
            "aE9mSGVhZBAFEhsKF3dpZHRoT2ZIZWFkQmVzdFByYWN0aWNlEAYSHAoYbGVu",
            "Z3RoT2ZIZWFkQmVzdFByYWN0aWNlEAcSDgoKcmVzb2x1dGlvbhAIEhoKFnJl",
            "c29sdXRpb25CZXN0UHJhY3RpY2UQCRIiCh5pbWFnZVdpZHRoVG9IZWlnaHRC",
            "ZXN0UHJhY3RpY2UQChIQCgxnb29kRXhwb3N1cmUQCxIYChRnb29kR3JheVNj",
            "YWxlUHJvZmlsZRAMEhgKFGhhc05hdHVyYWxTa2luQ29sb3VyEA0SDgoKbm9I",
            "b3RTcG90cxAOEiMKH2lzQmFja2dyb3VuZFVuaWZvcm1CZXN0UHJhY3RpY2UQ",
            "DxINCglpc0Zyb250YWwQEBIZChVpc0Zyb250YWxCZXN0UHJhY3RpY2UQERIV",
            "ChFpc0xpZ2h0aW5nVW5pZm9ybRASEhgKFGV5ZXNPcGVuQmVzdFByYWN0aWNl",
            "EBMSHwobZXllc0dhemVGcm9udGFsQmVzdFByYWN0aWNlEBQSGgoWZXllc05v",
            "dFJlZEJlc3RQcmFjdGljZRAVEhMKD25vVGludGVkR2xhc3NlcxAWEgsKB2lz",
            "U2hhcnAQFxIbChdtb3V0aENsb3NlZEJlc3RQcmFjdGljZRAYQg8KB2V4Lmdy",
            "cGOiAgNSVEdiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::DataTypes.GeometryReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::DataTypes.BiometricType), typeof(global::DataTypes.EyeType), typeof(global::DataTypes.Finger), typeof(global::DataTypes.FacialIsoComplianceTemplate), }, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::DataTypes.Faces), global::DataTypes.Faces.Parser, new[]{ "Faces_" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::DataTypes.FaceCharacteristic), global::DataTypes.FaceCharacteristic.Parser, new[]{ "Id", "Box", "Confidence", "PersonId", "PhotoId" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::DataTypes.Match), global::DataTypes.Match.Parser, new[]{ "FaceId", "Match_" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::DataTypes.Matches), global::DataTypes.Matches.Parser, new[]{ "FaceId", "Matches_" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Enums
  public enum BiometricType {
    [pbr::OriginalName("UnspecifiedBio")] UnspecifiedBio = 0,
    [pbr::OriginalName("Facial")] Facial = 1,
    [pbr::OriginalName("Fingerprint")] Fingerprint = 2,
    [pbr::OriginalName("Iris")] Iris = 3,
    [pbr::OriginalName("All")] All = 4,
  }

  public enum EyeType {
    [pbr::OriginalName("Unspecified_Eye")] UnspecifiedEye = 0,
    [pbr::OriginalName("Left")] Left = 1,
    [pbr::OriginalName("Right")] Right = 2,
    [pbr::OriginalName("Both")] Both = 3,
  }

  public enum Finger {
    [pbr::OriginalName("Unspecified_Finger")] UnspecifiedFinger = 0,
    [pbr::OriginalName("RightThumb")] RightThumb = 1,
    [pbr::OriginalName("LeftThumb")] LeftThumb = 2,
    [pbr::OriginalName("RightIndex")] RightIndex = 3,
    [pbr::OriginalName("LeftIndex")] LeftIndex = 4,
    [pbr::OriginalName("RightMiddle")] RightMiddle = 5,
    [pbr::OriginalName("LeftMiddle")] LeftMiddle = 6,
    [pbr::OriginalName("RightRing")] RightRing = 7,
    [pbr::OriginalName("LeftRing")] LeftRing = 8,
    [pbr::OriginalName("RightLittle")] RightLittle = 9,
    [pbr::OriginalName("LeftLittle")] LeftLittle = 10,
  }

  public enum FacialIsoComplianceTemplate {
    [pbr::OriginalName("Unspecified_IsoTemplate")] UnspecifiedIsoTemplate = 0,
    [pbr::OriginalName("OnlyOneFaceVisible")] OnlyOneFaceVisible = 1,
    [pbr::OriginalName("goodVerticalFacePosition")] GoodVerticalFacePosition = 2,
    [pbr::OriginalName("horizontallyCenteredFace")] HorizontallyCenteredFace = 3,
    [pbr::OriginalName("widthOfHead")] WidthOfHead = 4,
    [pbr::OriginalName("lengthOfHead")] LengthOfHead = 5,
    [pbr::OriginalName("widthOfHeadBestPractice")] WidthOfHeadBestPractice = 6,
    [pbr::OriginalName("lengthOfHeadBestPractice")] LengthOfHeadBestPractice = 7,
    [pbr::OriginalName("resolution")] Resolution = 8,
    [pbr::OriginalName("resolutionBestPractice")] ResolutionBestPractice = 9,
    [pbr::OriginalName("imageWidthToHeightBestPractice")] ImageWidthToHeightBestPractice = 10,
    [pbr::OriginalName("goodExposure")] GoodExposure = 11,
    [pbr::OriginalName("goodGrayScaleProfile")] GoodGrayScaleProfile = 12,
    [pbr::OriginalName("hasNaturalSkinColour")] HasNaturalSkinColour = 13,
    [pbr::OriginalName("noHotSpots")] NoHotSpots = 14,
    [pbr::OriginalName("isBackgroundUniformBestPractice")] IsBackgroundUniformBestPractice = 15,
    [pbr::OriginalName("isFrontal")] IsFrontal = 16,
    [pbr::OriginalName("isFrontalBestPractice")] IsFrontalBestPractice = 17,
    [pbr::OriginalName("isLightingUniform")] IsLightingUniform = 18,
    [pbr::OriginalName("eyesOpenBestPractice")] EyesOpenBestPractice = 19,
    [pbr::OriginalName("eyesGazeFrontalBestPractice")] EyesGazeFrontalBestPractice = 20,
    [pbr::OriginalName("eyesNotRedBestPractice")] EyesNotRedBestPractice = 21,
    [pbr::OriginalName("noTintedGlasses")] NoTintedGlasses = 22,
    [pbr::OriginalName("isSharp")] IsSharp = 23,
    [pbr::OriginalName("mouthClosedBestPractice")] MouthClosedBestPractice = 24,
  }

  #endregion

  #region Messages
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class Faces : pb::IMessage<Faces> {
    private static readonly pb::MessageParser<Faces> _parser = new pb::MessageParser<Faces>(() => new Faces());
    public static pb::MessageParser<Faces> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::DataTypes.BiometricsReflection.Descriptor.MessageTypes[0]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public Faces() {
      OnConstruction();
    }

    partial void OnConstruction();

    public Faces(Faces other) : this() {
      faces_ = other.faces_.Clone();
    }

    public Faces Clone() {
      return new Faces(this);
    }

    /// <summary>Field number for the "Faces" field.</summary>
    public const int Faces_FieldNumber = 1;
    private static readonly pb::FieldCodec<global::DataTypes.FaceCharacteristic> _repeated_faces_codec
        = pb::FieldCodec.ForMessage(10, global::DataTypes.FaceCharacteristic.Parser);
    private readonly pbc::RepeatedField<global::DataTypes.FaceCharacteristic> faces_ = new pbc::RepeatedField<global::DataTypes.FaceCharacteristic>();
    public pbc::RepeatedField<global::DataTypes.FaceCharacteristic> Faces_ {
      get { return faces_; }
    }

    public override bool Equals(object other) {
      return Equals(other as Faces);
    }

    public bool Equals(Faces other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!faces_.Equals(other.faces_)) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      hash ^= faces_.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      faces_.WriteTo(output, _repeated_faces_codec);
    }

    public int CalculateSize() {
      int size = 0;
      size += faces_.CalculateSize(_repeated_faces_codec);
      return size;
    }

    public void MergeFrom(Faces other) {
      if (other == null) {
        return;
      }
      faces_.Add(other.faces_);
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            faces_.AddEntriesFrom(input, _repeated_faces_codec);
            break;
          }
        }
      }
    }

  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class FaceCharacteristic : pb::IMessage<FaceCharacteristic> {
    private static readonly pb::MessageParser<FaceCharacteristic> _parser = new pb::MessageParser<FaceCharacteristic>(() => new FaceCharacteristic());
    public static pb::MessageParser<FaceCharacteristic> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::DataTypes.BiometricsReflection.Descriptor.MessageTypes[1]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public FaceCharacteristic() {
      OnConstruction();
    }

    partial void OnConstruction();

    public FaceCharacteristic(FaceCharacteristic other) : this() {
      id_ = other.id_;
      Box = other.box_ != null ? other.Box.Clone() : null;
      confidence_ = other.confidence_;
      personId_ = other.personId_;
      photoId_ = other.photoId_;
    }

    public FaceCharacteristic Clone() {
      return new FaceCharacteristic(this);
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 1;
    private long id_;
    public long Id {
      get { return id_; }
      set {
        id_ = value;
      }
    }

    /// <summary>Field number for the "box" field.</summary>
    public const int BoxFieldNumber = 2;
    private global::DataTypes.Box box_;
    public global::DataTypes.Box Box {
      get { return box_; }
      set {
        box_ = value;
      }
    }

    /// <summary>Field number for the "confidence" field.</summary>
    public const int ConfidenceFieldNumber = 3;
    private float confidence_;
    public float Confidence {
      get { return confidence_; }
      set {
        confidence_ = value;
      }
    }

    /// <summary>Field number for the "person_id" field.</summary>
    public const int PersonIdFieldNumber = 4;
    private long personId_;
    public long PersonId {
      get { return personId_; }
      set {
        personId_ = value;
      }
    }

    /// <summary>Field number for the "photo_id" field.</summary>
    public const int PhotoIdFieldNumber = 5;
    private long photoId_;
    public long PhotoId {
      get { return photoId_; }
      set {
        photoId_ = value;
      }
    }

    public override bool Equals(object other) {
      return Equals(other as FaceCharacteristic);
    }

    public bool Equals(FaceCharacteristic other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (!object.Equals(Box, other.Box)) return false;
      if (Confidence != other.Confidence) return false;
      if (PersonId != other.PersonId) return false;
      if (PhotoId != other.PhotoId) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (Id != 0L) hash ^= Id.GetHashCode();
      if (box_ != null) hash ^= Box.GetHashCode();
      if (Confidence != 0F) hash ^= Confidence.GetHashCode();
      if (PersonId != 0L) hash ^= PersonId.GetHashCode();
      if (PhotoId != 0L) hash ^= PhotoId.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (Id != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(Id);
      }
      if (box_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Box);
      }
      if (Confidence != 0F) {
        output.WriteRawTag(29);
        output.WriteFloat(Confidence);
      }
      if (PersonId != 0L) {
        output.WriteRawTag(32);
        output.WriteInt64(PersonId);
      }
      if (PhotoId != 0L) {
        output.WriteRawTag(40);
        output.WriteInt64(PhotoId);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (Id != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Id);
      }
      if (box_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Box);
      }
      if (Confidence != 0F) {
        size += 1 + 4;
      }
      if (PersonId != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(PersonId);
      }
      if (PhotoId != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(PhotoId);
      }
      return size;
    }

    public void MergeFrom(FaceCharacteristic other) {
      if (other == null) {
        return;
      }
      if (other.Id != 0L) {
        Id = other.Id;
      }
      if (other.box_ != null) {
        if (box_ == null) {
          box_ = new global::DataTypes.Box();
        }
        Box.MergeFrom(other.Box);
      }
      if (other.Confidence != 0F) {
        Confidence = other.Confidence;
      }
      if (other.PersonId != 0L) {
        PersonId = other.PersonId;
      }
      if (other.PhotoId != 0L) {
        PhotoId = other.PhotoId;
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
            Id = input.ReadInt64();
            break;
          }
          case 18: {
            if (box_ == null) {
              box_ = new global::DataTypes.Box();
            }
            input.ReadMessage(box_);
            break;
          }
          case 29: {
            Confidence = input.ReadFloat();
            break;
          }
          case 32: {
            PersonId = input.ReadInt64();
            break;
          }
          case 40: {
            PhotoId = input.ReadInt64();
            break;
          }
        }
      }
    }

  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class Match : pb::IMessage<Match> {
    private static readonly pb::MessageParser<Match> _parser = new pb::MessageParser<Match>(() => new Match());
    public static pb::MessageParser<Match> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::DataTypes.BiometricsReflection.Descriptor.MessageTypes[2]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public Match() {
      OnConstruction();
    }

    partial void OnConstruction();

    public Match(Match other) : this() {
      faceId_ = other.faceId_;
      match_ = other.match_;
    }

    public Match Clone() {
      return new Match(this);
    }

    /// <summary>Field number for the "face_id" field.</summary>
    public const int FaceIdFieldNumber = 2;
    private long faceId_;
    public long FaceId {
      get { return faceId_; }
      set {
        faceId_ = value;
      }
    }

    /// <summary>Field number for the "match" field.</summary>
    public const int Match_FieldNumber = 3;
    private float match_;
    public float Match_ {
      get { return match_; }
      set {
        match_ = value;
      }
    }

    public override bool Equals(object other) {
      return Equals(other as Match);
    }

    public bool Equals(Match other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (FaceId != other.FaceId) return false;
      if (Match_ != other.Match_) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (FaceId != 0L) hash ^= FaceId.GetHashCode();
      if (Match_ != 0F) hash ^= Match_.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (FaceId != 0L) {
        output.WriteRawTag(16);
        output.WriteInt64(FaceId);
      }
      if (Match_ != 0F) {
        output.WriteRawTag(29);
        output.WriteFloat(Match_);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (FaceId != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(FaceId);
      }
      if (Match_ != 0F) {
        size += 1 + 4;
      }
      return size;
    }

    public void MergeFrom(Match other) {
      if (other == null) {
        return;
      }
      if (other.FaceId != 0L) {
        FaceId = other.FaceId;
      }
      if (other.Match_ != 0F) {
        Match_ = other.Match_;
      }
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 16: {
            FaceId = input.ReadInt64();
            break;
          }
          case 29: {
            Match_ = input.ReadFloat();
            break;
          }
        }
      }
    }

  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class Matches : pb::IMessage<Matches> {
    private static readonly pb::MessageParser<Matches> _parser = new pb::MessageParser<Matches>(() => new Matches());
    public static pb::MessageParser<Matches> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::DataTypes.BiometricsReflection.Descriptor.MessageTypes[3]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public Matches() {
      OnConstruction();
    }

    partial void OnConstruction();

    public Matches(Matches other) : this() {
      faceId_ = other.faceId_;
      matches_ = other.matches_.Clone();
    }

    public Matches Clone() {
      return new Matches(this);
    }

    /// <summary>Field number for the "face_id" field.</summary>
    public const int FaceIdFieldNumber = 1;
    private long faceId_;
    public long FaceId {
      get { return faceId_; }
      set {
        faceId_ = value;
      }
    }

    /// <summary>Field number for the "matches" field.</summary>
    public const int Matches_FieldNumber = 2;
    private static readonly pb::FieldCodec<global::DataTypes.Match> _repeated_matches_codec
        = pb::FieldCodec.ForMessage(18, global::DataTypes.Match.Parser);
    private readonly pbc::RepeatedField<global::DataTypes.Match> matches_ = new pbc::RepeatedField<global::DataTypes.Match>();
    public pbc::RepeatedField<global::DataTypes.Match> Matches_ {
      get { return matches_; }
    }

    public override bool Equals(object other) {
      return Equals(other as Matches);
    }

    public bool Equals(Matches other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (FaceId != other.FaceId) return false;
      if(!matches_.Equals(other.matches_)) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (FaceId != 0L) hash ^= FaceId.GetHashCode();
      hash ^= matches_.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (FaceId != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(FaceId);
      }
      matches_.WriteTo(output, _repeated_matches_codec);
    }

    public int CalculateSize() {
      int size = 0;
      if (FaceId != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(FaceId);
      }
      size += matches_.CalculateSize(_repeated_matches_codec);
      return size;
    }

    public void MergeFrom(Matches other) {
      if (other == null) {
        return;
      }
      if (other.FaceId != 0L) {
        FaceId = other.FaceId;
      }
      matches_.Add(other.matches_);
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            FaceId = input.ReadInt64();
            break;
          }
          case 18: {
            matches_.AddEntriesFrom(input, _repeated_matches_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
