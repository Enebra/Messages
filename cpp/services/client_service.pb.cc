// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: services/client_service.proto

#define INTERNAL_SUPPRESS_PROTOBUF_FIELD_DEPRECATION
#include "services/client_service.pb.h"

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

namespace Services {

namespace {


}  // namespace


void protobuf_AssignDesc_services_2fclient_5fservice_2eproto() {
  protobuf_AddDesc_services_2fclient_5fservice_2eproto();
  const ::google::protobuf::FileDescriptor* file =
    ::google::protobuf::DescriptorPool::generated_pool()->FindFileByName(
      "services/client_service.proto");
  GOOGLE_CHECK(file != NULL);
}

namespace {

GOOGLE_PROTOBUF_DECLARE_ONCE(protobuf_AssignDescriptors_once_);
inline void protobuf_AssignDescriptorsOnce() {
  ::google::protobuf::GoogleOnceInit(&protobuf_AssignDescriptors_once_,
                 &protobuf_AssignDesc_services_2fclient_5fservice_2eproto);
}

void protobuf_RegisterTypes(const ::std::string&) {
  protobuf_AssignDescriptorsOnce();
}

}  // namespace

void protobuf_ShutdownFile_services_2fclient_5fservice_2eproto() {
}

void protobuf_AddDesc_services_2fclient_5fservice_2eproto() {
  static bool already_here = false;
  if (already_here) return;
  already_here = true;
  GOOGLE_PROTOBUF_VERIFY_VERSION;

  ::google::protobuf::protobuf_AddDesc_google_2fprotobuf_2fempty_2eproto();
  ::DataTypes::protobuf_AddDesc_datatypes_2funit_2eproto();
  ::DataTypes::protobuf_AddDesc_datatypes_2flocation_2eproto();
  ::DataTypes::protobuf_AddDesc_datatypes_2fdevices_2eproto();
  ::DataTypes::protobuf_AddDesc_datatypes_2fvisit_5frecord_2eproto();
  ::google::protobuf::DescriptorPool::InternalAddGeneratedFile(
    "\n\035services/client_service.proto\022\010Service"
    "s\032\033google/protobuf/empty.proto\032\024datatype"
    "s/unit.proto\032\030datatypes/location.proto\032\027"
    "datatypes/devices.proto\032\034datatypes/visit"
    "_record.proto2\235\002\n\rClientService\022G\n\022Updat"
    "eVisitRecords\022\027.DataTypes.VisitRecords\032\026"
    ".google.protobuf.Empty\"\000\022@\n\013UpdateUnits\022"
    "\027.DataTypes.UpdatedUnits\032\026.google.protob"
    "uf.Empty\"\000\022\?\n\016UpdateLocation\022\023.DataTypes"
    ".Location\032\026.google.protobuf.Empty\"\000\022@\n\013P"
    "ushUpdates\022\027.DataTypes.DeviceUpdate\032\026.go"
    "ogle.protobuf.Empty\"\000BQ\n\007ex.grpcZ@github"
    ".com/Enebra/ServiceCoordinator/grpc/serv"
    "ices/clientservice\242\002\003RTGb\006proto3", 552);
  ::google::protobuf::MessageFactory::InternalRegisterGeneratedFile(
    "services/client_service.proto", &protobuf_RegisterTypes);
  ::google::protobuf::internal::OnShutdown(&protobuf_ShutdownFile_services_2fclient_5fservice_2eproto);
}

// Force AddDescriptors() to be called at static initialization time.
struct StaticDescriptorInitializer_services_2fclient_5fservice_2eproto {
  StaticDescriptorInitializer_services_2fclient_5fservice_2eproto() {
    protobuf_AddDesc_services_2fclient_5fservice_2eproto();
  }
} static_descriptor_initializer_services_2fclient_5fservice_2eproto_;

// @@protoc_insertion_point(namespace_scope)

}  // namespace Services

// @@protoc_insertion_point(global_scope)
