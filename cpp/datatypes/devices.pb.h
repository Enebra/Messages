// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: datatypes/devices.proto

#ifndef PROTOBUF_datatypes_2fdevices_2eproto__INCLUDED
#define PROTOBUF_datatypes_2fdevices_2eproto__INCLUDED

#include <string>

#include <google/protobuf/stubs/common.h>

#if GOOGLE_PROTOBUF_VERSION < 3000000
#error This file was generated by a newer version of protoc which is
#error incompatible with your Protocol Buffer headers.  Please update
#error your headers.
#endif
#if 3000000 < GOOGLE_PROTOBUF_MIN_PROTOC_VERSION
#error This file was generated by an older version of protoc which is
#error incompatible with your Protocol Buffer headers.  Please
#error regenerate this file with a newer version of protoc.
#endif

#include <google/protobuf/arena.h>
#include <google/protobuf/arenastring.h>
#include <google/protobuf/generated_message_util.h>
#include <google/protobuf/metadata.h>
#include <google/protobuf/message.h>
#include <google/protobuf/repeated_field.h>
#include <google/protobuf/extension_set.h>
#include <google/protobuf/unknown_field_set.h>
// @@protoc_insertion_point(includes)

namespace DataTypes {

// Internal implementation detail -- do not call these.
void protobuf_AddDesc_datatypes_2fdevices_2eproto();
void protobuf_AssignDesc_datatypes_2fdevices_2eproto();
void protobuf_ShutdownFile_datatypes_2fdevices_2eproto();

class AccessDevice;

// ===================================================================

class AccessDevice : public ::google::protobuf::Message {
 public:
  AccessDevice();
  virtual ~AccessDevice();

  AccessDevice(const AccessDevice& from);

  inline AccessDevice& operator=(const AccessDevice& from) {
    CopyFrom(from);
    return *this;
  }

  static const ::google::protobuf::Descriptor* descriptor();
  static const AccessDevice& default_instance();

  void Swap(AccessDevice* other);

  // implements Message ----------------------------------------------

  inline AccessDevice* New() const { return New(NULL); }

  AccessDevice* New(::google::protobuf::Arena* arena) const;
  void CopyFrom(const ::google::protobuf::Message& from);
  void MergeFrom(const ::google::protobuf::Message& from);
  void CopyFrom(const AccessDevice& from);
  void MergeFrom(const AccessDevice& from);
  void Clear();
  bool IsInitialized() const;

  int ByteSize() const;
  bool MergePartialFromCodedStream(
      ::google::protobuf::io::CodedInputStream* input);
  void SerializeWithCachedSizes(
      ::google::protobuf::io::CodedOutputStream* output) const;
  ::google::protobuf::uint8* SerializeWithCachedSizesToArray(::google::protobuf::uint8* output) const;
  int GetCachedSize() const { return _cached_size_; }
  private:
  void SharedCtor();
  void SharedDtor();
  void SetCachedSize(int size) const;
  void InternalSwap(AccessDevice* other);
  private:
  inline ::google::protobuf::Arena* GetArenaNoVirtual() const {
    return _internal_metadata_.arena();
  }
  inline void* MaybeArenaPtr() const {
    return _internal_metadata_.raw_arena_ptr();
  }
  public:

  ::google::protobuf::Metadata GetMetadata() const;

  // nested types ----------------------------------------------------

  // accessors -------------------------------------------------------

  // optional string name = 1;
  void clear_name();
  static const int kNameFieldNumber = 1;
  const ::std::string& name() const;
  void set_name(const ::std::string& value);
  void set_name(const char* value);
  void set_name(const char* value, size_t size);
  ::std::string* mutable_name();
  ::std::string* release_name();
  void set_allocated_name(::std::string* name);

  // optional fixed64 serial_number = 2;
  void clear_serial_number();
  static const int kSerialNumberFieldNumber = 2;
  ::google::protobuf::uint64 serial_number() const;
  void set_serial_number(::google::protobuf::uint64 value);

  // @@protoc_insertion_point(class_scope:DataTypes.AccessDevice)
 private:

  ::google::protobuf::internal::InternalMetadataWithArena _internal_metadata_;
  bool _is_default_instance_;
  ::google::protobuf::internal::ArenaStringPtr name_;
  ::google::protobuf::uint64 serial_number_;
  mutable int _cached_size_;
  friend void  protobuf_AddDesc_datatypes_2fdevices_2eproto();
  friend void protobuf_AssignDesc_datatypes_2fdevices_2eproto();
  friend void protobuf_ShutdownFile_datatypes_2fdevices_2eproto();

  void InitAsDefaultInstance();
  static AccessDevice* default_instance_;
};
// ===================================================================


// ===================================================================

#if !PROTOBUF_INLINE_NOT_IN_HEADERS
// AccessDevice

// optional string name = 1;
inline void AccessDevice::clear_name() {
  name_.ClearToEmptyNoArena(&::google::protobuf::internal::GetEmptyStringAlreadyInited());
}
inline const ::std::string& AccessDevice::name() const {
  // @@protoc_insertion_point(field_get:DataTypes.AccessDevice.name)
  return name_.GetNoArena(&::google::protobuf::internal::GetEmptyStringAlreadyInited());
}
inline void AccessDevice::set_name(const ::std::string& value) {
  
  name_.SetNoArena(&::google::protobuf::internal::GetEmptyStringAlreadyInited(), value);
  // @@protoc_insertion_point(field_set:DataTypes.AccessDevice.name)
}
inline void AccessDevice::set_name(const char* value) {
  
  name_.SetNoArena(&::google::protobuf::internal::GetEmptyStringAlreadyInited(), ::std::string(value));
  // @@protoc_insertion_point(field_set_char:DataTypes.AccessDevice.name)
}
inline void AccessDevice::set_name(const char* value, size_t size) {
  
  name_.SetNoArena(&::google::protobuf::internal::GetEmptyStringAlreadyInited(),
      ::std::string(reinterpret_cast<const char*>(value), size));
  // @@protoc_insertion_point(field_set_pointer:DataTypes.AccessDevice.name)
}
inline ::std::string* AccessDevice::mutable_name() {
  
  // @@protoc_insertion_point(field_mutable:DataTypes.AccessDevice.name)
  return name_.MutableNoArena(&::google::protobuf::internal::GetEmptyStringAlreadyInited());
}
inline ::std::string* AccessDevice::release_name() {
  // @@protoc_insertion_point(field_release:DataTypes.AccessDevice.name)
  
  return name_.ReleaseNoArena(&::google::protobuf::internal::GetEmptyStringAlreadyInited());
}
inline void AccessDevice::set_allocated_name(::std::string* name) {
  if (name != NULL) {
    
  } else {
    
  }
  name_.SetAllocatedNoArena(&::google::protobuf::internal::GetEmptyStringAlreadyInited(), name);
  // @@protoc_insertion_point(field_set_allocated:DataTypes.AccessDevice.name)
}

// optional fixed64 serial_number = 2;
inline void AccessDevice::clear_serial_number() {
  serial_number_ = GOOGLE_ULONGLONG(0);
}
inline ::google::protobuf::uint64 AccessDevice::serial_number() const {
  // @@protoc_insertion_point(field_get:DataTypes.AccessDevice.serial_number)
  return serial_number_;
}
inline void AccessDevice::set_serial_number(::google::protobuf::uint64 value) {
  
  serial_number_ = value;
  // @@protoc_insertion_point(field_set:DataTypes.AccessDevice.serial_number)
}

#endif  // !PROTOBUF_INLINE_NOT_IN_HEADERS

// @@protoc_insertion_point(namespace_scope)

}  // namespace DataTypes

// @@protoc_insertion_point(global_scope)

#endif  // PROTOBUF_datatypes_2fdevices_2eproto__INCLUDED
