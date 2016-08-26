// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: services/database_service.proto

#define INTERNAL_SUPPRESS_PROTOBUF_FIELD_DEPRECATION
#include "services/database_service.pb.h"

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


void protobuf_AssignDesc_services_2fdatabase_5fservice_2eproto() {
  protobuf_AddDesc_services_2fdatabase_5fservice_2eproto();
  const ::google::protobuf::FileDescriptor* file =
    ::google::protobuf::DescriptorPool::generated_pool()->FindFileByName(
      "services/database_service.proto");
  GOOGLE_CHECK(file != NULL);
}

namespace {

GOOGLE_PROTOBUF_DECLARE_ONCE(protobuf_AssignDescriptors_once_);
inline void protobuf_AssignDescriptorsOnce() {
  ::google::protobuf::GoogleOnceInit(&protobuf_AssignDescriptors_once_,
                 &protobuf_AssignDesc_services_2fdatabase_5fservice_2eproto);
}

void protobuf_RegisterTypes(const ::std::string&) {
  protobuf_AssignDescriptorsOnce();
}

}  // namespace

void protobuf_ShutdownFile_services_2fdatabase_5fservice_2eproto() {
}

void protobuf_AddDesc_services_2fdatabase_5fservice_2eproto() {
  static bool already_here = false;
  if (already_here) return;
  already_here = true;
  GOOGLE_PROTOBUF_VERIFY_VERSION;

  ::google::protobuf::protobuf_AddDesc_google_2fprotobuf_2fempty_2eproto();
  ::DataTypes::protobuf_AddDesc_datatypes_2fperson_2eproto();
  ::DataTypes::protobuf_AddDesc_datatypes_2fcard_2eproto();
  ::DataTypes::protobuf_AddDesc_datatypes_2fphoto_2eproto();
  ::DataTypes::protobuf_AddDesc_datatypes_2flocation_2eproto();
  ::DataTypes::protobuf_AddDesc_datatypes_2fvisitor_2eproto();
  ::Services::protobuf_AddDesc_services_2fqueries_2eproto();
  ::google::protobuf::DescriptorPool::InternalAddGeneratedFile(
    "\n\037services/database_service.proto\022\010Servi"
    "ces\032\033google/protobuf/empty.proto\032\026dataty"
    "pes/person.proto\032\024datatypes/card.proto\032\025"
    "datatypes/photo.proto\032\030datatypes/locatio"
    "n.proto\032\027datatypes/visitor.proto\032\026servic"
    "es/queries.proto2\225\010\n\016DatabaseSevice\022=\n\tG"
    "etPerson\022\032.Services.GetPersonRequest\032\022.D"
    "ataTypes.Persons\"\000\0226\n\014InsertPerson\022\021.Dat"
    "aTypes.Person\032\021.DataTypes.Person\"\000\022;\n\014Up"
    "datePerson\022\021.DataTypes.Person\032\026.google.p"
    "rotobuf.Empty\"\000\022;\n\014DeletePerson\022\021.DataTy"
    "pes.Person\032\026.google.protobuf.Empty\"\000\0220\n\n"
    "InsertCard\022\017.DataTypes.Card\032\017.DataTypes."
    "Card\"\000\0227\n\nUpdateCard\022\017.DataTypes.Card\032\026."
    "google.protobuf.Empty\"\000\0227\n\nDeleteCard\022\017."
    "DataTypes.Card\032\026.google.protobuf.Empty\"\000"
    "\022C\n\013GetLocation\022\034.Services.GetLocationRe"
    "quest\032\024.DataTypes.Locations\"\000\022<\n\016InsertL"
    "ocation\022\023.DataTypes.Location\032\023.DataTypes"
    ".Location\"\000\022\?\n\016UpdateLocation\022\023.DataType"
    "s.Location\032\026.google.protobuf.Empty\"\000\022\?\n\016"
    "DeleteLocation\022\023.DataTypes.Location\032\026.go"
    "ogle.protobuf.Empty\"\000\022@\n\nGetVisitor\022\033.Se"
    "rvices.GetVisitorRequest\032\023.DataTypes.Vis"
    "itors\"\000\0229\n\rInsertVisitor\022\022.DataTypes.Vis"
    "itor\032\022.DataTypes.Visitor\"\000\022=\n\rUpdateVisi"
    "tor\022\022.DataTypes.Visitor\032\026.google.protobu"
    "f.Empty\"\000\022=\n\rDeleteVisitor\022\022.DataTypes.V"
    "isitor\032\026.google.protobuf.Empty\"\000\0223\n\013Inse"
    "rtPhoto\022\020.DataTypes.Photo\032\020.DataTypes.Ph"
    "oto\"\000\0229\n\013DeletePhoto\022\020.DataTypes.Photo\032\026"
    ".google.protobuf.Empty\"\000B\017\n\007ex.grpc\242\002\003RT"
    "Gb\006proto3", 1289);
  ::google::protobuf::MessageFactory::InternalRegisterGeneratedFile(
    "services/database_service.proto", &protobuf_RegisterTypes);
  ::google::protobuf::internal::OnShutdown(&protobuf_ShutdownFile_services_2fdatabase_5fservice_2eproto);
}

// Force AddDescriptors() to be called at static initialization time.
struct StaticDescriptorInitializer_services_2fdatabase_5fservice_2eproto {
  StaticDescriptorInitializer_services_2fdatabase_5fservice_2eproto() {
    protobuf_AddDesc_services_2fdatabase_5fservice_2eproto();
  }
} static_descriptor_initializer_services_2fdatabase_5fservice_2eproto_;

// @@protoc_insertion_point(namespace_scope)

}  // namespace Services

// @@protoc_insertion_point(global_scope)
