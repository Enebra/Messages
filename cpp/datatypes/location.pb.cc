// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: datatypes/location.proto

#define INTERNAL_SUPPRESS_PROTOBUF_FIELD_DEPRECATION
#include "datatypes/location.pb.h"

#include <algorithm>

#include <google/protobuf/stubs/common.h>
#include <google/protobuf/stubs/port.h>
#include <google/protobuf/stubs/once.h>
#include <google/protobuf/io/coded_stream.h>
#include <google/protobuf/wire_format_lite_inl.h>
#include <google/protobuf/descriptor.h>
#include <google/protobuf/generated_message_reflection.h>
#include <google/protobuf/reflection_ops.h>
#include <google/protobuf/wire_format.h>
// @@protoc_insertion_point(includes)

namespace DataTypes {

namespace {

const ::google::protobuf::Descriptor* Location_descriptor_ = NULL;
const ::google::protobuf::internal::GeneratedMessageReflection*
  Location_reflection_ = NULL;
const ::google::protobuf::Descriptor* Locations_descriptor_ = NULL;
const ::google::protobuf::internal::GeneratedMessageReflection*
  Locations_reflection_ = NULL;
const ::google::protobuf::EnumDescriptor* LocationState_descriptor_ = NULL;

}  // namespace


void protobuf_AssignDesc_datatypes_2flocation_2eproto() {
  protobuf_AddDesc_datatypes_2flocation_2eproto();
  const ::google::protobuf::FileDescriptor* file =
    ::google::protobuf::DescriptorPool::generated_pool()->FindFileByName(
      "datatypes/location.proto");
  GOOGLE_CHECK(file != NULL);
  Location_descriptor_ = file->message_type(0);
  static const int Location_offsets_[5] = {
    GOOGLE_PROTOBUF_GENERATED_MESSAGE_FIELD_OFFSET(Location, id_),
    GOOGLE_PROTOBUF_GENERATED_MESSAGE_FIELD_OFFSET(Location, name_),
    GOOGLE_PROTOBUF_GENERATED_MESSAGE_FIELD_OFFSET(Location, description_),
    GOOGLE_PROTOBUF_GENERATED_MESSAGE_FIELD_OFFSET(Location, unit_mac_address_),
    GOOGLE_PROTOBUF_GENERATED_MESSAGE_FIELD_OFFSET(Location, access_device_),
  };
  Location_reflection_ =
    ::google::protobuf::internal::GeneratedMessageReflection::NewGeneratedMessageReflection(
      Location_descriptor_,
      Location::default_instance_,
      Location_offsets_,
      -1,
      -1,
      -1,
      sizeof(Location),
      GOOGLE_PROTOBUF_GENERATED_MESSAGE_FIELD_OFFSET(Location, _internal_metadata_),
      GOOGLE_PROTOBUF_GENERATED_MESSAGE_FIELD_OFFSET(Location, _is_default_instance_));
  Locations_descriptor_ = file->message_type(1);
  static const int Locations_offsets_[2] = {
    GOOGLE_PROTOBUF_GENERATED_MESSAGE_FIELD_OFFSET(Locations, items_),
    GOOGLE_PROTOBUF_GENERATED_MESSAGE_FIELD_OFFSET(Locations, count_),
  };
  Locations_reflection_ =
    ::google::protobuf::internal::GeneratedMessageReflection::NewGeneratedMessageReflection(
      Locations_descriptor_,
      Locations::default_instance_,
      Locations_offsets_,
      -1,
      -1,
      -1,
      sizeof(Locations),
      GOOGLE_PROTOBUF_GENERATED_MESSAGE_FIELD_OFFSET(Locations, _internal_metadata_),
      GOOGLE_PROTOBUF_GENERATED_MESSAGE_FIELD_OFFSET(Locations, _is_default_instance_));
  LocationState_descriptor_ = file->enum_type(0);
}

namespace {

GOOGLE_PROTOBUF_DECLARE_ONCE(protobuf_AssignDescriptors_once_);
inline void protobuf_AssignDescriptorsOnce() {
  ::google::protobuf::GoogleOnceInit(&protobuf_AssignDescriptors_once_,
                 &protobuf_AssignDesc_datatypes_2flocation_2eproto);
}

void protobuf_RegisterTypes(const ::std::string&) {
  protobuf_AssignDescriptorsOnce();
  ::google::protobuf::MessageFactory::InternalRegisterGeneratedMessage(
      Location_descriptor_, &Location::default_instance());
  ::google::protobuf::MessageFactory::InternalRegisterGeneratedMessage(
      Locations_descriptor_, &Locations::default_instance());
}

}  // namespace

void protobuf_ShutdownFile_datatypes_2flocation_2eproto() {
  delete Location::default_instance_;
  delete Location_reflection_;
  delete Locations::default_instance_;
  delete Locations_reflection_;
}

void protobuf_AddDesc_datatypes_2flocation_2eproto() {
  static bool already_here = false;
  if (already_here) return;
  already_here = true;
  GOOGLE_PROTOBUF_VERIFY_VERSION;

  ::DataTypes::protobuf_AddDesc_datatypes_2fdevices_2eproto();
  ::DataTypes::protobuf_AddDesc_datatypes_2fdata_2eproto();
  ::google::protobuf::DescriptorPool::InternalAddGeneratedFile(
    "\n\030datatypes/location.proto\022\tDataTypes\032\027d"
    "atatypes/devices.proto\032\024datatypes/data.p"
    "roto\"\223\001\n\010Location\022\032\n\002id\030\001 \001(\0132\016.DataType"
    "s.Key\022\014\n\004name\030\002 \001(\t\022\023\n\013description\030\003 \001(\t"
    "\022\030\n\020unit_mac_address\030\004 \001(\t\022.\n\raccess_dev"
    "ice\030\005 \001(\0132\027.DataTypes.AccessDevice\">\n\tLo"
    "cations\022\"\n\005items\030\001 \003(\0132\023.DataTypes.Locat"
    "ion\022\r\n\005count\030\002 \001(\003*K\n\rLocationState\022\025\n\021U"
    "nspecified_State\020\000\022\n\n\006Opened\020\001\022\n\n\006Closed"
    "\020\002\022\013\n\007Failure\020\003BM\n\007ex.grpcZ<github.com/E"
    "nebra/ServiceCoordinator/grpc/datatypes/"
    "location\242\002\003RTGb\006proto3", 462);
  ::google::protobuf::MessageFactory::InternalRegisterGeneratedFile(
    "datatypes/location.proto", &protobuf_RegisterTypes);
  Location::default_instance_ = new Location();
  Locations::default_instance_ = new Locations();
  Location::default_instance_->InitAsDefaultInstance();
  Locations::default_instance_->InitAsDefaultInstance();
  ::google::protobuf::internal::OnShutdown(&protobuf_ShutdownFile_datatypes_2flocation_2eproto);
}

// Force AddDescriptors() to be called at static initialization time.
struct StaticDescriptorInitializer_datatypes_2flocation_2eproto {
  StaticDescriptorInitializer_datatypes_2flocation_2eproto() {
    protobuf_AddDesc_datatypes_2flocation_2eproto();
  }
} static_descriptor_initializer_datatypes_2flocation_2eproto_;
const ::google::protobuf::EnumDescriptor* LocationState_descriptor() {
  protobuf_AssignDescriptorsOnce();
  return LocationState_descriptor_;
}
bool LocationState_IsValid(int value) {
  switch(value) {
    case 0:
    case 1:
    case 2:
    case 3:
      return true;
    default:
      return false;
  }
}


namespace {

static void MergeFromFail(int line) GOOGLE_ATTRIBUTE_COLD;
static void MergeFromFail(int line) {
  GOOGLE_CHECK(false) << __FILE__ << ":" << line;
}

}  // namespace


// ===================================================================

#if !defined(_MSC_VER) || _MSC_VER >= 1900
const int Location::kIdFieldNumber;
const int Location::kNameFieldNumber;
const int Location::kDescriptionFieldNumber;
const int Location::kUnitMacAddressFieldNumber;
const int Location::kAccessDeviceFieldNumber;
#endif  // !defined(_MSC_VER) || _MSC_VER >= 1900

Location::Location()
  : ::google::protobuf::Message(), _internal_metadata_(NULL) {
  SharedCtor();
  // @@protoc_insertion_point(constructor:DataTypes.Location)
}

void Location::InitAsDefaultInstance() {
  _is_default_instance_ = true;
  id_ = const_cast< ::DataTypes::Key*>(&::DataTypes::Key::default_instance());
  access_device_ = const_cast< ::DataTypes::AccessDevice*>(&::DataTypes::AccessDevice::default_instance());
}

Location::Location(const Location& from)
  : ::google::protobuf::Message(),
    _internal_metadata_(NULL) {
  SharedCtor();
  MergeFrom(from);
  // @@protoc_insertion_point(copy_constructor:DataTypes.Location)
}

void Location::SharedCtor() {
    _is_default_instance_ = false;
  ::google::protobuf::internal::GetEmptyString();
  _cached_size_ = 0;
  id_ = NULL;
  name_.UnsafeSetDefault(&::google::protobuf::internal::GetEmptyStringAlreadyInited());
  description_.UnsafeSetDefault(&::google::protobuf::internal::GetEmptyStringAlreadyInited());
  unit_mac_address_.UnsafeSetDefault(&::google::protobuf::internal::GetEmptyStringAlreadyInited());
  access_device_ = NULL;
}

Location::~Location() {
  // @@protoc_insertion_point(destructor:DataTypes.Location)
  SharedDtor();
}

void Location::SharedDtor() {
  name_.DestroyNoArena(&::google::protobuf::internal::GetEmptyStringAlreadyInited());
  description_.DestroyNoArena(&::google::protobuf::internal::GetEmptyStringAlreadyInited());
  unit_mac_address_.DestroyNoArena(&::google::protobuf::internal::GetEmptyStringAlreadyInited());
  if (this != default_instance_) {
    delete id_;
    delete access_device_;
  }
}

void Location::SetCachedSize(int size) const {
  GOOGLE_SAFE_CONCURRENT_WRITES_BEGIN();
  _cached_size_ = size;
  GOOGLE_SAFE_CONCURRENT_WRITES_END();
}
const ::google::protobuf::Descriptor* Location::descriptor() {
  protobuf_AssignDescriptorsOnce();
  return Location_descriptor_;
}

const Location& Location::default_instance() {
  if (default_instance_ == NULL) protobuf_AddDesc_datatypes_2flocation_2eproto();
  return *default_instance_;
}

Location* Location::default_instance_ = NULL;

Location* Location::New(::google::protobuf::Arena* arena) const {
  Location* n = new Location;
  if (arena != NULL) {
    arena->Own(n);
  }
  return n;
}

void Location::Clear() {
// @@protoc_insertion_point(message_clear_start:DataTypes.Location)
  if (GetArenaNoVirtual() == NULL && id_ != NULL) delete id_;
  id_ = NULL;
  name_.ClearToEmptyNoArena(&::google::protobuf::internal::GetEmptyStringAlreadyInited());
  description_.ClearToEmptyNoArena(&::google::protobuf::internal::GetEmptyStringAlreadyInited());
  unit_mac_address_.ClearToEmptyNoArena(&::google::protobuf::internal::GetEmptyStringAlreadyInited());
  if (GetArenaNoVirtual() == NULL && access_device_ != NULL) delete access_device_;
  access_device_ = NULL;
}

bool Location::MergePartialFromCodedStream(
    ::google::protobuf::io::CodedInputStream* input) {
#define DO_(EXPRESSION) if (!GOOGLE_PREDICT_TRUE(EXPRESSION)) goto failure
  ::google::protobuf::uint32 tag;
  // @@protoc_insertion_point(parse_start:DataTypes.Location)
  for (;;) {
    ::std::pair< ::google::protobuf::uint32, bool> p = input->ReadTagWithCutoff(127);
    tag = p.first;
    if (!p.second) goto handle_unusual;
    switch (::google::protobuf::internal::WireFormatLite::GetTagFieldNumber(tag)) {
      // optional .DataTypes.Key id = 1;
      case 1: {
        if (tag == 10) {
          DO_(::google::protobuf::internal::WireFormatLite::ReadMessageNoVirtual(
               input, mutable_id()));
        } else {
          goto handle_unusual;
        }
        if (input->ExpectTag(18)) goto parse_name;
        break;
      }

      // optional string name = 2;
      case 2: {
        if (tag == 18) {
         parse_name:
          DO_(::google::protobuf::internal::WireFormatLite::ReadString(
                input, this->mutable_name()));
          DO_(::google::protobuf::internal::WireFormatLite::VerifyUtf8String(
            this->name().data(), this->name().length(),
            ::google::protobuf::internal::WireFormatLite::PARSE,
            "DataTypes.Location.name"));
        } else {
          goto handle_unusual;
        }
        if (input->ExpectTag(26)) goto parse_description;
        break;
      }

      // optional string description = 3;
      case 3: {
        if (tag == 26) {
         parse_description:
          DO_(::google::protobuf::internal::WireFormatLite::ReadString(
                input, this->mutable_description()));
          DO_(::google::protobuf::internal::WireFormatLite::VerifyUtf8String(
            this->description().data(), this->description().length(),
            ::google::protobuf::internal::WireFormatLite::PARSE,
            "DataTypes.Location.description"));
        } else {
          goto handle_unusual;
        }
        if (input->ExpectTag(34)) goto parse_unit_mac_address;
        break;
      }

      // optional string unit_mac_address = 4;
      case 4: {
        if (tag == 34) {
         parse_unit_mac_address:
          DO_(::google::protobuf::internal::WireFormatLite::ReadString(
                input, this->mutable_unit_mac_address()));
          DO_(::google::protobuf::internal::WireFormatLite::VerifyUtf8String(
            this->unit_mac_address().data(), this->unit_mac_address().length(),
            ::google::protobuf::internal::WireFormatLite::PARSE,
            "DataTypes.Location.unit_mac_address"));
        } else {
          goto handle_unusual;
        }
        if (input->ExpectTag(42)) goto parse_access_device;
        break;
      }

      // optional .DataTypes.AccessDevice access_device = 5;
      case 5: {
        if (tag == 42) {
         parse_access_device:
          DO_(::google::protobuf::internal::WireFormatLite::ReadMessageNoVirtual(
               input, mutable_access_device()));
        } else {
          goto handle_unusual;
        }
        if (input->ExpectAtEnd()) goto success;
        break;
      }

      default: {
      handle_unusual:
        if (tag == 0 ||
            ::google::protobuf::internal::WireFormatLite::GetTagWireType(tag) ==
            ::google::protobuf::internal::WireFormatLite::WIRETYPE_END_GROUP) {
          goto success;
        }
        DO_(::google::protobuf::internal::WireFormatLite::SkipField(input, tag));
        break;
      }
    }
  }
success:
  // @@protoc_insertion_point(parse_success:DataTypes.Location)
  return true;
failure:
  // @@protoc_insertion_point(parse_failure:DataTypes.Location)
  return false;
#undef DO_
}

void Location::SerializeWithCachedSizes(
    ::google::protobuf::io::CodedOutputStream* output) const {
  // @@protoc_insertion_point(serialize_start:DataTypes.Location)
  // optional .DataTypes.Key id = 1;
  if (this->has_id()) {
    ::google::protobuf::internal::WireFormatLite::WriteMessageMaybeToArray(
      1, *this->id_, output);
  }

  // optional string name = 2;
  if (this->name().size() > 0) {
    ::google::protobuf::internal::WireFormatLite::VerifyUtf8String(
      this->name().data(), this->name().length(),
      ::google::protobuf::internal::WireFormatLite::SERIALIZE,
      "DataTypes.Location.name");
    ::google::protobuf::internal::WireFormatLite::WriteStringMaybeAliased(
      2, this->name(), output);
  }

  // optional string description = 3;
  if (this->description().size() > 0) {
    ::google::protobuf::internal::WireFormatLite::VerifyUtf8String(
      this->description().data(), this->description().length(),
      ::google::protobuf::internal::WireFormatLite::SERIALIZE,
      "DataTypes.Location.description");
    ::google::protobuf::internal::WireFormatLite::WriteStringMaybeAliased(
      3, this->description(), output);
  }

  // optional string unit_mac_address = 4;
  if (this->unit_mac_address().size() > 0) {
    ::google::protobuf::internal::WireFormatLite::VerifyUtf8String(
      this->unit_mac_address().data(), this->unit_mac_address().length(),
      ::google::protobuf::internal::WireFormatLite::SERIALIZE,
      "DataTypes.Location.unit_mac_address");
    ::google::protobuf::internal::WireFormatLite::WriteStringMaybeAliased(
      4, this->unit_mac_address(), output);
  }

  // optional .DataTypes.AccessDevice access_device = 5;
  if (this->has_access_device()) {
    ::google::protobuf::internal::WireFormatLite::WriteMessageMaybeToArray(
      5, *this->access_device_, output);
  }

  // @@protoc_insertion_point(serialize_end:DataTypes.Location)
}

::google::protobuf::uint8* Location::SerializeWithCachedSizesToArray(
    ::google::protobuf::uint8* target) const {
  // @@protoc_insertion_point(serialize_to_array_start:DataTypes.Location)
  // optional .DataTypes.Key id = 1;
  if (this->has_id()) {
    target = ::google::protobuf::internal::WireFormatLite::
      WriteMessageNoVirtualToArray(
        1, *this->id_, target);
  }

  // optional string name = 2;
  if (this->name().size() > 0) {
    ::google::protobuf::internal::WireFormatLite::VerifyUtf8String(
      this->name().data(), this->name().length(),
      ::google::protobuf::internal::WireFormatLite::SERIALIZE,
      "DataTypes.Location.name");
    target =
      ::google::protobuf::internal::WireFormatLite::WriteStringToArray(
        2, this->name(), target);
  }

  // optional string description = 3;
  if (this->description().size() > 0) {
    ::google::protobuf::internal::WireFormatLite::VerifyUtf8String(
      this->description().data(), this->description().length(),
      ::google::protobuf::internal::WireFormatLite::SERIALIZE,
      "DataTypes.Location.description");
    target =
      ::google::protobuf::internal::WireFormatLite::WriteStringToArray(
        3, this->description(), target);
  }

  // optional string unit_mac_address = 4;
  if (this->unit_mac_address().size() > 0) {
    ::google::protobuf::internal::WireFormatLite::VerifyUtf8String(
      this->unit_mac_address().data(), this->unit_mac_address().length(),
      ::google::protobuf::internal::WireFormatLite::SERIALIZE,
      "DataTypes.Location.unit_mac_address");
    target =
      ::google::protobuf::internal::WireFormatLite::WriteStringToArray(
        4, this->unit_mac_address(), target);
  }

  // optional .DataTypes.AccessDevice access_device = 5;
  if (this->has_access_device()) {
    target = ::google::protobuf::internal::WireFormatLite::
      WriteMessageNoVirtualToArray(
        5, *this->access_device_, target);
  }

  // @@protoc_insertion_point(serialize_to_array_end:DataTypes.Location)
  return target;
}

int Location::ByteSize() const {
// @@protoc_insertion_point(message_byte_size_start:DataTypes.Location)
  int total_size = 0;

  // optional .DataTypes.Key id = 1;
  if (this->has_id()) {
    total_size += 1 +
      ::google::protobuf::internal::WireFormatLite::MessageSizeNoVirtual(
        *this->id_);
  }

  // optional string name = 2;
  if (this->name().size() > 0) {
    total_size += 1 +
      ::google::protobuf::internal::WireFormatLite::StringSize(
        this->name());
  }

  // optional string description = 3;
  if (this->description().size() > 0) {
    total_size += 1 +
      ::google::protobuf::internal::WireFormatLite::StringSize(
        this->description());
  }

  // optional string unit_mac_address = 4;
  if (this->unit_mac_address().size() > 0) {
    total_size += 1 +
      ::google::protobuf::internal::WireFormatLite::StringSize(
        this->unit_mac_address());
  }

  // optional .DataTypes.AccessDevice access_device = 5;
  if (this->has_access_device()) {
    total_size += 1 +
      ::google::protobuf::internal::WireFormatLite::MessageSizeNoVirtual(
        *this->access_device_);
  }

  GOOGLE_SAFE_CONCURRENT_WRITES_BEGIN();
  _cached_size_ = total_size;
  GOOGLE_SAFE_CONCURRENT_WRITES_END();
  return total_size;
}

void Location::MergeFrom(const ::google::protobuf::Message& from) {
// @@protoc_insertion_point(generalized_merge_from_start:DataTypes.Location)
  if (GOOGLE_PREDICT_FALSE(&from == this)) MergeFromFail(__LINE__);
  const Location* source = 
      ::google::protobuf::internal::DynamicCastToGenerated<const Location>(
          &from);
  if (source == NULL) {
  // @@protoc_insertion_point(generalized_merge_from_cast_fail:DataTypes.Location)
    ::google::protobuf::internal::ReflectionOps::Merge(from, this);
  } else {
  // @@protoc_insertion_point(generalized_merge_from_cast_success:DataTypes.Location)
    MergeFrom(*source);
  }
}

void Location::MergeFrom(const Location& from) {
// @@protoc_insertion_point(class_specific_merge_from_start:DataTypes.Location)
  if (GOOGLE_PREDICT_FALSE(&from == this)) MergeFromFail(__LINE__);
  if (from.has_id()) {
    mutable_id()->::DataTypes::Key::MergeFrom(from.id());
  }
  if (from.name().size() > 0) {

    name_.AssignWithDefault(&::google::protobuf::internal::GetEmptyStringAlreadyInited(), from.name_);
  }
  if (from.description().size() > 0) {

    description_.AssignWithDefault(&::google::protobuf::internal::GetEmptyStringAlreadyInited(), from.description_);
  }
  if (from.unit_mac_address().size() > 0) {

    unit_mac_address_.AssignWithDefault(&::google::protobuf::internal::GetEmptyStringAlreadyInited(), from.unit_mac_address_);
  }
  if (from.has_access_device()) {
    mutable_access_device()->::DataTypes::AccessDevice::MergeFrom(from.access_device());
  }
}

void Location::CopyFrom(const ::google::protobuf::Message& from) {
// @@protoc_insertion_point(generalized_copy_from_start:DataTypes.Location)
  if (&from == this) return;
  Clear();
  MergeFrom(from);
}

void Location::CopyFrom(const Location& from) {
// @@protoc_insertion_point(class_specific_copy_from_start:DataTypes.Location)
  if (&from == this) return;
  Clear();
  MergeFrom(from);
}

bool Location::IsInitialized() const {

  return true;
}

void Location::Swap(Location* other) {
  if (other == this) return;
  InternalSwap(other);
}
void Location::InternalSwap(Location* other) {
  std::swap(id_, other->id_);
  name_.Swap(&other->name_);
  description_.Swap(&other->description_);
  unit_mac_address_.Swap(&other->unit_mac_address_);
  std::swap(access_device_, other->access_device_);
  _internal_metadata_.Swap(&other->_internal_metadata_);
  std::swap(_cached_size_, other->_cached_size_);
}

::google::protobuf::Metadata Location::GetMetadata() const {
  protobuf_AssignDescriptorsOnce();
  ::google::protobuf::Metadata metadata;
  metadata.descriptor = Location_descriptor_;
  metadata.reflection = Location_reflection_;
  return metadata;
}

#if PROTOBUF_INLINE_NOT_IN_HEADERS
// Location

// optional .DataTypes.Key id = 1;
bool Location::has_id() const {
  return !_is_default_instance_ && id_ != NULL;
}
void Location::clear_id() {
  if (GetArenaNoVirtual() == NULL && id_ != NULL) delete id_;
  id_ = NULL;
}
const ::DataTypes::Key& Location::id() const {
  // @@protoc_insertion_point(field_get:DataTypes.Location.id)
  return id_ != NULL ? *id_ : *default_instance_->id_;
}
::DataTypes::Key* Location::mutable_id() {
  
  if (id_ == NULL) {
    id_ = new ::DataTypes::Key;
  }
  // @@protoc_insertion_point(field_mutable:DataTypes.Location.id)
  return id_;
}
::DataTypes::Key* Location::release_id() {
  // @@protoc_insertion_point(field_release:DataTypes.Location.id)
  
  ::DataTypes::Key* temp = id_;
  id_ = NULL;
  return temp;
}
void Location::set_allocated_id(::DataTypes::Key* id) {
  delete id_;
  id_ = id;
  if (id) {
    
  } else {
    
  }
  // @@protoc_insertion_point(field_set_allocated:DataTypes.Location.id)
}

// optional string name = 2;
void Location::clear_name() {
  name_.ClearToEmptyNoArena(&::google::protobuf::internal::GetEmptyStringAlreadyInited());
}
 const ::std::string& Location::name() const {
  // @@protoc_insertion_point(field_get:DataTypes.Location.name)
  return name_.GetNoArena(&::google::protobuf::internal::GetEmptyStringAlreadyInited());
}
 void Location::set_name(const ::std::string& value) {
  
  name_.SetNoArena(&::google::protobuf::internal::GetEmptyStringAlreadyInited(), value);
  // @@protoc_insertion_point(field_set:DataTypes.Location.name)
}
 void Location::set_name(const char* value) {
  
  name_.SetNoArena(&::google::protobuf::internal::GetEmptyStringAlreadyInited(), ::std::string(value));
  // @@protoc_insertion_point(field_set_char:DataTypes.Location.name)
}
 void Location::set_name(const char* value, size_t size) {
  
  name_.SetNoArena(&::google::protobuf::internal::GetEmptyStringAlreadyInited(),
      ::std::string(reinterpret_cast<const char*>(value), size));
  // @@protoc_insertion_point(field_set_pointer:DataTypes.Location.name)
}
 ::std::string* Location::mutable_name() {
  
  // @@protoc_insertion_point(field_mutable:DataTypes.Location.name)
  return name_.MutableNoArena(&::google::protobuf::internal::GetEmptyStringAlreadyInited());
}
 ::std::string* Location::release_name() {
  // @@protoc_insertion_point(field_release:DataTypes.Location.name)
  
  return name_.ReleaseNoArena(&::google::protobuf::internal::GetEmptyStringAlreadyInited());
}
 void Location::set_allocated_name(::std::string* name) {
  if (name != NULL) {
    
  } else {
    
  }
  name_.SetAllocatedNoArena(&::google::protobuf::internal::GetEmptyStringAlreadyInited(), name);
  // @@protoc_insertion_point(field_set_allocated:DataTypes.Location.name)
}

// optional string description = 3;
void Location::clear_description() {
  description_.ClearToEmptyNoArena(&::google::protobuf::internal::GetEmptyStringAlreadyInited());
}
 const ::std::string& Location::description() const {
  // @@protoc_insertion_point(field_get:DataTypes.Location.description)
  return description_.GetNoArena(&::google::protobuf::internal::GetEmptyStringAlreadyInited());
}
 void Location::set_description(const ::std::string& value) {
  
  description_.SetNoArena(&::google::protobuf::internal::GetEmptyStringAlreadyInited(), value);
  // @@protoc_insertion_point(field_set:DataTypes.Location.description)
}
 void Location::set_description(const char* value) {
  
  description_.SetNoArena(&::google::protobuf::internal::GetEmptyStringAlreadyInited(), ::std::string(value));
  // @@protoc_insertion_point(field_set_char:DataTypes.Location.description)
}
 void Location::set_description(const char* value, size_t size) {
  
  description_.SetNoArena(&::google::protobuf::internal::GetEmptyStringAlreadyInited(),
      ::std::string(reinterpret_cast<const char*>(value), size));
  // @@protoc_insertion_point(field_set_pointer:DataTypes.Location.description)
}
 ::std::string* Location::mutable_description() {
  
  // @@protoc_insertion_point(field_mutable:DataTypes.Location.description)
  return description_.MutableNoArena(&::google::protobuf::internal::GetEmptyStringAlreadyInited());
}
 ::std::string* Location::release_description() {
  // @@protoc_insertion_point(field_release:DataTypes.Location.description)
  
  return description_.ReleaseNoArena(&::google::protobuf::internal::GetEmptyStringAlreadyInited());
}
 void Location::set_allocated_description(::std::string* description) {
  if (description != NULL) {
    
  } else {
    
  }
  description_.SetAllocatedNoArena(&::google::protobuf::internal::GetEmptyStringAlreadyInited(), description);
  // @@protoc_insertion_point(field_set_allocated:DataTypes.Location.description)
}

// optional string unit_mac_address = 4;
void Location::clear_unit_mac_address() {
  unit_mac_address_.ClearToEmptyNoArena(&::google::protobuf::internal::GetEmptyStringAlreadyInited());
}
 const ::std::string& Location::unit_mac_address() const {
  // @@protoc_insertion_point(field_get:DataTypes.Location.unit_mac_address)
  return unit_mac_address_.GetNoArena(&::google::protobuf::internal::GetEmptyStringAlreadyInited());
}
 void Location::set_unit_mac_address(const ::std::string& value) {
  
  unit_mac_address_.SetNoArena(&::google::protobuf::internal::GetEmptyStringAlreadyInited(), value);
  // @@protoc_insertion_point(field_set:DataTypes.Location.unit_mac_address)
}
 void Location::set_unit_mac_address(const char* value) {
  
  unit_mac_address_.SetNoArena(&::google::protobuf::internal::GetEmptyStringAlreadyInited(), ::std::string(value));
  // @@protoc_insertion_point(field_set_char:DataTypes.Location.unit_mac_address)
}
 void Location::set_unit_mac_address(const char* value, size_t size) {
  
  unit_mac_address_.SetNoArena(&::google::protobuf::internal::GetEmptyStringAlreadyInited(),
      ::std::string(reinterpret_cast<const char*>(value), size));
  // @@protoc_insertion_point(field_set_pointer:DataTypes.Location.unit_mac_address)
}
 ::std::string* Location::mutable_unit_mac_address() {
  
  // @@protoc_insertion_point(field_mutable:DataTypes.Location.unit_mac_address)
  return unit_mac_address_.MutableNoArena(&::google::protobuf::internal::GetEmptyStringAlreadyInited());
}
 ::std::string* Location::release_unit_mac_address() {
  // @@protoc_insertion_point(field_release:DataTypes.Location.unit_mac_address)
  
  return unit_mac_address_.ReleaseNoArena(&::google::protobuf::internal::GetEmptyStringAlreadyInited());
}
 void Location::set_allocated_unit_mac_address(::std::string* unit_mac_address) {
  if (unit_mac_address != NULL) {
    
  } else {
    
  }
  unit_mac_address_.SetAllocatedNoArena(&::google::protobuf::internal::GetEmptyStringAlreadyInited(), unit_mac_address);
  // @@protoc_insertion_point(field_set_allocated:DataTypes.Location.unit_mac_address)
}

// optional .DataTypes.AccessDevice access_device = 5;
bool Location::has_access_device() const {
  return !_is_default_instance_ && access_device_ != NULL;
}
void Location::clear_access_device() {
  if (GetArenaNoVirtual() == NULL && access_device_ != NULL) delete access_device_;
  access_device_ = NULL;
}
const ::DataTypes::AccessDevice& Location::access_device() const {
  // @@protoc_insertion_point(field_get:DataTypes.Location.access_device)
  return access_device_ != NULL ? *access_device_ : *default_instance_->access_device_;
}
::DataTypes::AccessDevice* Location::mutable_access_device() {
  
  if (access_device_ == NULL) {
    access_device_ = new ::DataTypes::AccessDevice;
  }
  // @@protoc_insertion_point(field_mutable:DataTypes.Location.access_device)
  return access_device_;
}
::DataTypes::AccessDevice* Location::release_access_device() {
  // @@protoc_insertion_point(field_release:DataTypes.Location.access_device)
  
  ::DataTypes::AccessDevice* temp = access_device_;
  access_device_ = NULL;
  return temp;
}
void Location::set_allocated_access_device(::DataTypes::AccessDevice* access_device) {
  delete access_device_;
  access_device_ = access_device;
  if (access_device) {
    
  } else {
    
  }
  // @@protoc_insertion_point(field_set_allocated:DataTypes.Location.access_device)
}

#endif  // PROTOBUF_INLINE_NOT_IN_HEADERS

// ===================================================================

#if !defined(_MSC_VER) || _MSC_VER >= 1900
const int Locations::kItemsFieldNumber;
const int Locations::kCountFieldNumber;
#endif  // !defined(_MSC_VER) || _MSC_VER >= 1900

Locations::Locations()
  : ::google::protobuf::Message(), _internal_metadata_(NULL) {
  SharedCtor();
  // @@protoc_insertion_point(constructor:DataTypes.Locations)
}

void Locations::InitAsDefaultInstance() {
  _is_default_instance_ = true;
}

Locations::Locations(const Locations& from)
  : ::google::protobuf::Message(),
    _internal_metadata_(NULL) {
  SharedCtor();
  MergeFrom(from);
  // @@protoc_insertion_point(copy_constructor:DataTypes.Locations)
}

void Locations::SharedCtor() {
    _is_default_instance_ = false;
  _cached_size_ = 0;
  count_ = GOOGLE_LONGLONG(0);
}

Locations::~Locations() {
  // @@protoc_insertion_point(destructor:DataTypes.Locations)
  SharedDtor();
}

void Locations::SharedDtor() {
  if (this != default_instance_) {
  }
}

void Locations::SetCachedSize(int size) const {
  GOOGLE_SAFE_CONCURRENT_WRITES_BEGIN();
  _cached_size_ = size;
  GOOGLE_SAFE_CONCURRENT_WRITES_END();
}
const ::google::protobuf::Descriptor* Locations::descriptor() {
  protobuf_AssignDescriptorsOnce();
  return Locations_descriptor_;
}

const Locations& Locations::default_instance() {
  if (default_instance_ == NULL) protobuf_AddDesc_datatypes_2flocation_2eproto();
  return *default_instance_;
}

Locations* Locations::default_instance_ = NULL;

Locations* Locations::New(::google::protobuf::Arena* arena) const {
  Locations* n = new Locations;
  if (arena != NULL) {
    arena->Own(n);
  }
  return n;
}

void Locations::Clear() {
// @@protoc_insertion_point(message_clear_start:DataTypes.Locations)
  count_ = GOOGLE_LONGLONG(0);
  items_.Clear();
}

bool Locations::MergePartialFromCodedStream(
    ::google::protobuf::io::CodedInputStream* input) {
#define DO_(EXPRESSION) if (!GOOGLE_PREDICT_TRUE(EXPRESSION)) goto failure
  ::google::protobuf::uint32 tag;
  // @@protoc_insertion_point(parse_start:DataTypes.Locations)
  for (;;) {
    ::std::pair< ::google::protobuf::uint32, bool> p = input->ReadTagWithCutoff(127);
    tag = p.first;
    if (!p.second) goto handle_unusual;
    switch (::google::protobuf::internal::WireFormatLite::GetTagFieldNumber(tag)) {
      // repeated .DataTypes.Location items = 1;
      case 1: {
        if (tag == 10) {
          DO_(input->IncrementRecursionDepth());
         parse_loop_items:
          DO_(::google::protobuf::internal::WireFormatLite::ReadMessageNoVirtualNoRecursionDepth(
                input, add_items()));
        } else {
          goto handle_unusual;
        }
        if (input->ExpectTag(10)) goto parse_loop_items;
        input->UnsafeDecrementRecursionDepth();
        if (input->ExpectTag(16)) goto parse_count;
        break;
      }

      // optional int64 count = 2;
      case 2: {
        if (tag == 16) {
         parse_count:
          DO_((::google::protobuf::internal::WireFormatLite::ReadPrimitive<
                   ::google::protobuf::int64, ::google::protobuf::internal::WireFormatLite::TYPE_INT64>(
                 input, &count_)));

        } else {
          goto handle_unusual;
        }
        if (input->ExpectAtEnd()) goto success;
        break;
      }

      default: {
      handle_unusual:
        if (tag == 0 ||
            ::google::protobuf::internal::WireFormatLite::GetTagWireType(tag) ==
            ::google::protobuf::internal::WireFormatLite::WIRETYPE_END_GROUP) {
          goto success;
        }
        DO_(::google::protobuf::internal::WireFormatLite::SkipField(input, tag));
        break;
      }
    }
  }
success:
  // @@protoc_insertion_point(parse_success:DataTypes.Locations)
  return true;
failure:
  // @@protoc_insertion_point(parse_failure:DataTypes.Locations)
  return false;
#undef DO_
}

void Locations::SerializeWithCachedSizes(
    ::google::protobuf::io::CodedOutputStream* output) const {
  // @@protoc_insertion_point(serialize_start:DataTypes.Locations)
  // repeated .DataTypes.Location items = 1;
  for (unsigned int i = 0, n = this->items_size(); i < n; i++) {
    ::google::protobuf::internal::WireFormatLite::WriteMessageMaybeToArray(
      1, this->items(i), output);
  }

  // optional int64 count = 2;
  if (this->count() != 0) {
    ::google::protobuf::internal::WireFormatLite::WriteInt64(2, this->count(), output);
  }

  // @@protoc_insertion_point(serialize_end:DataTypes.Locations)
}

::google::protobuf::uint8* Locations::SerializeWithCachedSizesToArray(
    ::google::protobuf::uint8* target) const {
  // @@protoc_insertion_point(serialize_to_array_start:DataTypes.Locations)
  // repeated .DataTypes.Location items = 1;
  for (unsigned int i = 0, n = this->items_size(); i < n; i++) {
    target = ::google::protobuf::internal::WireFormatLite::
      WriteMessageNoVirtualToArray(
        1, this->items(i), target);
  }

  // optional int64 count = 2;
  if (this->count() != 0) {
    target = ::google::protobuf::internal::WireFormatLite::WriteInt64ToArray(2, this->count(), target);
  }

  // @@protoc_insertion_point(serialize_to_array_end:DataTypes.Locations)
  return target;
}

int Locations::ByteSize() const {
// @@protoc_insertion_point(message_byte_size_start:DataTypes.Locations)
  int total_size = 0;

  // optional int64 count = 2;
  if (this->count() != 0) {
    total_size += 1 +
      ::google::protobuf::internal::WireFormatLite::Int64Size(
        this->count());
  }

  // repeated .DataTypes.Location items = 1;
  total_size += 1 * this->items_size();
  for (int i = 0; i < this->items_size(); i++) {
    total_size +=
      ::google::protobuf::internal::WireFormatLite::MessageSizeNoVirtual(
        this->items(i));
  }

  GOOGLE_SAFE_CONCURRENT_WRITES_BEGIN();
  _cached_size_ = total_size;
  GOOGLE_SAFE_CONCURRENT_WRITES_END();
  return total_size;
}

void Locations::MergeFrom(const ::google::protobuf::Message& from) {
// @@protoc_insertion_point(generalized_merge_from_start:DataTypes.Locations)
  if (GOOGLE_PREDICT_FALSE(&from == this)) MergeFromFail(__LINE__);
  const Locations* source = 
      ::google::protobuf::internal::DynamicCastToGenerated<const Locations>(
          &from);
  if (source == NULL) {
  // @@protoc_insertion_point(generalized_merge_from_cast_fail:DataTypes.Locations)
    ::google::protobuf::internal::ReflectionOps::Merge(from, this);
  } else {
  // @@protoc_insertion_point(generalized_merge_from_cast_success:DataTypes.Locations)
    MergeFrom(*source);
  }
}

void Locations::MergeFrom(const Locations& from) {
// @@protoc_insertion_point(class_specific_merge_from_start:DataTypes.Locations)
  if (GOOGLE_PREDICT_FALSE(&from == this)) MergeFromFail(__LINE__);
  items_.MergeFrom(from.items_);
  if (from.count() != 0) {
    set_count(from.count());
  }
}

void Locations::CopyFrom(const ::google::protobuf::Message& from) {
// @@protoc_insertion_point(generalized_copy_from_start:DataTypes.Locations)
  if (&from == this) return;
  Clear();
  MergeFrom(from);
}

void Locations::CopyFrom(const Locations& from) {
// @@protoc_insertion_point(class_specific_copy_from_start:DataTypes.Locations)
  if (&from == this) return;
  Clear();
  MergeFrom(from);
}

bool Locations::IsInitialized() const {

  return true;
}

void Locations::Swap(Locations* other) {
  if (other == this) return;
  InternalSwap(other);
}
void Locations::InternalSwap(Locations* other) {
  items_.UnsafeArenaSwap(&other->items_);
  std::swap(count_, other->count_);
  _internal_metadata_.Swap(&other->_internal_metadata_);
  std::swap(_cached_size_, other->_cached_size_);
}

::google::protobuf::Metadata Locations::GetMetadata() const {
  protobuf_AssignDescriptorsOnce();
  ::google::protobuf::Metadata metadata;
  metadata.descriptor = Locations_descriptor_;
  metadata.reflection = Locations_reflection_;
  return metadata;
}

#if PROTOBUF_INLINE_NOT_IN_HEADERS
// Locations

// repeated .DataTypes.Location items = 1;
int Locations::items_size() const {
  return items_.size();
}
void Locations::clear_items() {
  items_.Clear();
}
const ::DataTypes::Location& Locations::items(int index) const {
  // @@protoc_insertion_point(field_get:DataTypes.Locations.items)
  return items_.Get(index);
}
::DataTypes::Location* Locations::mutable_items(int index) {
  // @@protoc_insertion_point(field_mutable:DataTypes.Locations.items)
  return items_.Mutable(index);
}
::DataTypes::Location* Locations::add_items() {
  // @@protoc_insertion_point(field_add:DataTypes.Locations.items)
  return items_.Add();
}
::google::protobuf::RepeatedPtrField< ::DataTypes::Location >*
Locations::mutable_items() {
  // @@protoc_insertion_point(field_mutable_list:DataTypes.Locations.items)
  return &items_;
}
const ::google::protobuf::RepeatedPtrField< ::DataTypes::Location >&
Locations::items() const {
  // @@protoc_insertion_point(field_list:DataTypes.Locations.items)
  return items_;
}

// optional int64 count = 2;
void Locations::clear_count() {
  count_ = GOOGLE_LONGLONG(0);
}
 ::google::protobuf::int64 Locations::count() const {
  // @@protoc_insertion_point(field_get:DataTypes.Locations.count)
  return count_;
}
 void Locations::set_count(::google::protobuf::int64 value) {
  
  count_ = value;
  // @@protoc_insertion_point(field_set:DataTypes.Locations.count)
}

#endif  // PROTOBUF_INLINE_NOT_IN_HEADERS

// @@protoc_insertion_point(namespace_scope)

}  // namespace DataTypes

// @@protoc_insertion_point(global_scope)
