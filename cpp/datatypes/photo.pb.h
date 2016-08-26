// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: datatypes/photo.proto

#ifndef PROTOBUF_datatypes_2fphoto_2eproto__INCLUDED
#define PROTOBUF_datatypes_2fphoto_2eproto__INCLUDED

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
#include <google/protobuf/generated_enum_reflection.h>
#include <google/protobuf/unknown_field_set.h>
#include "datatypes/biometrics.pb.h"
// @@protoc_insertion_point(includes)

namespace DataTypes {

// Internal implementation detail -- do not call these.
void protobuf_AddDesc_datatypes_2fphoto_2eproto();
void protobuf_AssignDesc_datatypes_2fphoto_2eproto();
void protobuf_ShutdownFile_datatypes_2fphoto_2eproto();

class Photo;
class Photos;

enum Purpose {
  NonePurpose = 0,
  Thumbnail = 1,
  Population = 2,
  Purpose_INT_MIN_SENTINEL_DO_NOT_USE_ = ::google::protobuf::kint32min,
  Purpose_INT_MAX_SENTINEL_DO_NOT_USE_ = ::google::protobuf::kint32max
};
bool Purpose_IsValid(int value);
const Purpose Purpose_MIN = NonePurpose;
const Purpose Purpose_MAX = Population;
const int Purpose_ARRAYSIZE = Purpose_MAX + 1;

const ::google::protobuf::EnumDescriptor* Purpose_descriptor();
inline const ::std::string& Purpose_Name(Purpose value) {
  return ::google::protobuf::internal::NameOfEnum(
    Purpose_descriptor(), value);
}
inline bool Purpose_Parse(
    const ::std::string& name, Purpose* value) {
  return ::google::protobuf::internal::ParseNamedEnum<Purpose>(
    Purpose_descriptor(), name, value);
}
// ===================================================================

class Photo : public ::google::protobuf::Message {
 public:
  Photo();
  virtual ~Photo();

  Photo(const Photo& from);

  inline Photo& operator=(const Photo& from) {
    CopyFrom(from);
    return *this;
  }

  static const ::google::protobuf::Descriptor* descriptor();
  static const Photo& default_instance();

  void Swap(Photo* other);

  // implements Message ----------------------------------------------

  inline Photo* New() const { return New(NULL); }

  Photo* New(::google::protobuf::Arena* arena) const;
  void CopyFrom(const ::google::protobuf::Message& from);
  void MergeFrom(const ::google::protobuf::Message& from);
  void CopyFrom(const Photo& from);
  void MergeFrom(const Photo& from);
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
  void InternalSwap(Photo* other);
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

  // optional int64 id = 1;
  void clear_id();
  static const int kIdFieldNumber = 1;
  ::google::protobuf::int64 id() const;
  void set_id(::google::protobuf::int64 value);

  // optional string url = 2;
  void clear_url();
  static const int kUrlFieldNumber = 2;
  const ::std::string& url() const;
  void set_url(const ::std::string& value);
  void set_url(const char* value);
  void set_url(const char* value, size_t size);
  ::std::string* mutable_url();
  ::std::string* release_url();
  void set_allocated_url(::std::string* url);

  // optional int32 width = 3;
  void clear_width();
  static const int kWidthFieldNumber = 3;
  ::google::protobuf::int32 width() const;
  void set_width(::google::protobuf::int32 value);

  // optional int32 height = 4;
  void clear_height();
  static const int kHeightFieldNumber = 4;
  ::google::protobuf::int32 height() const;
  void set_height(::google::protobuf::int32 value);

  // optional .DataTypes.Purpose purpose = 5;
  void clear_purpose();
  static const int kPurposeFieldNumber = 5;
  ::DataTypes::Purpose purpose() const;
  void set_purpose(::DataTypes::Purpose value);

  // optional .DataTypes.BiometricType biotype = 6;
  void clear_biotype();
  static const int kBiotypeFieldNumber = 6;
  ::DataTypes::BiometricType biotype() const;
  void set_biotype(::DataTypes::BiometricType value);

  // optional int64 owner_id = 7;
  void clear_owner_id();
  static const int kOwnerIdFieldNumber = 7;
  ::google::protobuf::int64 owner_id() const;
  void set_owner_id(::google::protobuf::int64 value);

  // @@protoc_insertion_point(class_scope:DataTypes.Photo)
 private:

  ::google::protobuf::internal::InternalMetadataWithArena _internal_metadata_;
  bool _is_default_instance_;
  ::google::protobuf::int64 id_;
  ::google::protobuf::internal::ArenaStringPtr url_;
  ::google::protobuf::int32 width_;
  ::google::protobuf::int32 height_;
  int purpose_;
  int biotype_;
  ::google::protobuf::int64 owner_id_;
  mutable int _cached_size_;
  friend void  protobuf_AddDesc_datatypes_2fphoto_2eproto();
  friend void protobuf_AssignDesc_datatypes_2fphoto_2eproto();
  friend void protobuf_ShutdownFile_datatypes_2fphoto_2eproto();

  void InitAsDefaultInstance();
  static Photo* default_instance_;
};
// -------------------------------------------------------------------

class Photos : public ::google::protobuf::Message {
 public:
  Photos();
  virtual ~Photos();

  Photos(const Photos& from);

  inline Photos& operator=(const Photos& from) {
    CopyFrom(from);
    return *this;
  }

  static const ::google::protobuf::Descriptor* descriptor();
  static const Photos& default_instance();

  void Swap(Photos* other);

  // implements Message ----------------------------------------------

  inline Photos* New() const { return New(NULL); }

  Photos* New(::google::protobuf::Arena* arena) const;
  void CopyFrom(const ::google::protobuf::Message& from);
  void MergeFrom(const ::google::protobuf::Message& from);
  void CopyFrom(const Photos& from);
  void MergeFrom(const Photos& from);
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
  void InternalSwap(Photos* other);
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

  // repeated .DataTypes.Photo photos = 1;
  int photos_size() const;
  void clear_photos();
  static const int kPhotosFieldNumber = 1;
  const ::DataTypes::Photo& photos(int index) const;
  ::DataTypes::Photo* mutable_photos(int index);
  ::DataTypes::Photo* add_photos();
  ::google::protobuf::RepeatedPtrField< ::DataTypes::Photo >*
      mutable_photos();
  const ::google::protobuf::RepeatedPtrField< ::DataTypes::Photo >&
      photos() const;

  // @@protoc_insertion_point(class_scope:DataTypes.Photos)
 private:

  ::google::protobuf::internal::InternalMetadataWithArena _internal_metadata_;
  bool _is_default_instance_;
  ::google::protobuf::RepeatedPtrField< ::DataTypes::Photo > photos_;
  mutable int _cached_size_;
  friend void  protobuf_AddDesc_datatypes_2fphoto_2eproto();
  friend void protobuf_AssignDesc_datatypes_2fphoto_2eproto();
  friend void protobuf_ShutdownFile_datatypes_2fphoto_2eproto();

  void InitAsDefaultInstance();
  static Photos* default_instance_;
};
// ===================================================================


// ===================================================================

#if !PROTOBUF_INLINE_NOT_IN_HEADERS
// Photo

// optional int64 id = 1;
inline void Photo::clear_id() {
  id_ = GOOGLE_LONGLONG(0);
}
inline ::google::protobuf::int64 Photo::id() const {
  // @@protoc_insertion_point(field_get:DataTypes.Photo.id)
  return id_;
}
inline void Photo::set_id(::google::protobuf::int64 value) {
  
  id_ = value;
  // @@protoc_insertion_point(field_set:DataTypes.Photo.id)
}

// optional string url = 2;
inline void Photo::clear_url() {
  url_.ClearToEmptyNoArena(&::google::protobuf::internal::GetEmptyStringAlreadyInited());
}
inline const ::std::string& Photo::url() const {
  // @@protoc_insertion_point(field_get:DataTypes.Photo.url)
  return url_.GetNoArena(&::google::protobuf::internal::GetEmptyStringAlreadyInited());
}
inline void Photo::set_url(const ::std::string& value) {
  
  url_.SetNoArena(&::google::protobuf::internal::GetEmptyStringAlreadyInited(), value);
  // @@protoc_insertion_point(field_set:DataTypes.Photo.url)
}
inline void Photo::set_url(const char* value) {
  
  url_.SetNoArena(&::google::protobuf::internal::GetEmptyStringAlreadyInited(), ::std::string(value));
  // @@protoc_insertion_point(field_set_char:DataTypes.Photo.url)
}
inline void Photo::set_url(const char* value, size_t size) {
  
  url_.SetNoArena(&::google::protobuf::internal::GetEmptyStringAlreadyInited(),
      ::std::string(reinterpret_cast<const char*>(value), size));
  // @@protoc_insertion_point(field_set_pointer:DataTypes.Photo.url)
}
inline ::std::string* Photo::mutable_url() {
  
  // @@protoc_insertion_point(field_mutable:DataTypes.Photo.url)
  return url_.MutableNoArena(&::google::protobuf::internal::GetEmptyStringAlreadyInited());
}
inline ::std::string* Photo::release_url() {
  // @@protoc_insertion_point(field_release:DataTypes.Photo.url)
  
  return url_.ReleaseNoArena(&::google::protobuf::internal::GetEmptyStringAlreadyInited());
}
inline void Photo::set_allocated_url(::std::string* url) {
  if (url != NULL) {
    
  } else {
    
  }
  url_.SetAllocatedNoArena(&::google::protobuf::internal::GetEmptyStringAlreadyInited(), url);
  // @@protoc_insertion_point(field_set_allocated:DataTypes.Photo.url)
}

// optional int32 width = 3;
inline void Photo::clear_width() {
  width_ = 0;
}
inline ::google::protobuf::int32 Photo::width() const {
  // @@protoc_insertion_point(field_get:DataTypes.Photo.width)
  return width_;
}
inline void Photo::set_width(::google::protobuf::int32 value) {
  
  width_ = value;
  // @@protoc_insertion_point(field_set:DataTypes.Photo.width)
}

// optional int32 height = 4;
inline void Photo::clear_height() {
  height_ = 0;
}
inline ::google::protobuf::int32 Photo::height() const {
  // @@protoc_insertion_point(field_get:DataTypes.Photo.height)
  return height_;
}
inline void Photo::set_height(::google::protobuf::int32 value) {
  
  height_ = value;
  // @@protoc_insertion_point(field_set:DataTypes.Photo.height)
}

// optional .DataTypes.Purpose purpose = 5;
inline void Photo::clear_purpose() {
  purpose_ = 0;
}
inline ::DataTypes::Purpose Photo::purpose() const {
  // @@protoc_insertion_point(field_get:DataTypes.Photo.purpose)
  return static_cast< ::DataTypes::Purpose >(purpose_);
}
inline void Photo::set_purpose(::DataTypes::Purpose value) {
  
  purpose_ = value;
  // @@protoc_insertion_point(field_set:DataTypes.Photo.purpose)
}

// optional .DataTypes.BiometricType biotype = 6;
inline void Photo::clear_biotype() {
  biotype_ = 0;
}
inline ::DataTypes::BiometricType Photo::biotype() const {
  // @@protoc_insertion_point(field_get:DataTypes.Photo.biotype)
  return static_cast< ::DataTypes::BiometricType >(biotype_);
}
inline void Photo::set_biotype(::DataTypes::BiometricType value) {
  
  biotype_ = value;
  // @@protoc_insertion_point(field_set:DataTypes.Photo.biotype)
}

// optional int64 owner_id = 7;
inline void Photo::clear_owner_id() {
  owner_id_ = GOOGLE_LONGLONG(0);
}
inline ::google::protobuf::int64 Photo::owner_id() const {
  // @@protoc_insertion_point(field_get:DataTypes.Photo.owner_id)
  return owner_id_;
}
inline void Photo::set_owner_id(::google::protobuf::int64 value) {
  
  owner_id_ = value;
  // @@protoc_insertion_point(field_set:DataTypes.Photo.owner_id)
}

// -------------------------------------------------------------------

// Photos

// repeated .DataTypes.Photo photos = 1;
inline int Photos::photos_size() const {
  return photos_.size();
}
inline void Photos::clear_photos() {
  photos_.Clear();
}
inline const ::DataTypes::Photo& Photos::photos(int index) const {
  // @@protoc_insertion_point(field_get:DataTypes.Photos.photos)
  return photos_.Get(index);
}
inline ::DataTypes::Photo* Photos::mutable_photos(int index) {
  // @@protoc_insertion_point(field_mutable:DataTypes.Photos.photos)
  return photos_.Mutable(index);
}
inline ::DataTypes::Photo* Photos::add_photos() {
  // @@protoc_insertion_point(field_add:DataTypes.Photos.photos)
  return photos_.Add();
}
inline ::google::protobuf::RepeatedPtrField< ::DataTypes::Photo >*
Photos::mutable_photos() {
  // @@protoc_insertion_point(field_mutable_list:DataTypes.Photos.photos)
  return &photos_;
}
inline const ::google::protobuf::RepeatedPtrField< ::DataTypes::Photo >&
Photos::photos() const {
  // @@protoc_insertion_point(field_list:DataTypes.Photos.photos)
  return photos_;
}

#endif  // !PROTOBUF_INLINE_NOT_IN_HEADERS
// -------------------------------------------------------------------


// @@protoc_insertion_point(namespace_scope)

}  // namespace DataTypes

#ifndef SWIG
namespace google {
namespace protobuf {

template <> struct is_proto_enum< ::DataTypes::Purpose> : ::google::protobuf::internal::true_type {};
template <>
inline const EnumDescriptor* GetEnumDescriptor< ::DataTypes::Purpose>() {
  return ::DataTypes::Purpose_descriptor();
}

}  // namespace protobuf
}  // namespace google
#endif  // SWIG

// @@protoc_insertion_point(global_scope)

#endif  // PROTOBUF_datatypes_2fphoto_2eproto__INCLUDED
