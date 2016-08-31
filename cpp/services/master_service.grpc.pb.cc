// Generated by the gRPC protobuf plugin.
// If you make any local change, they will be lost.
// source: services/master_service.proto

#include "services/master_service.pb.h"
#include "services/master_service.grpc.pb.h"

#include <grpc++/impl/codegen/async_stream.h>
#include <grpc++/impl/codegen/async_unary_call.h>
#include <grpc++/impl/codegen/channel_interface.h>
#include <grpc++/impl/codegen/client_unary_call.h>
#include <grpc++/impl/codegen/method_handler_impl.h>
#include <grpc++/impl/codegen/rpc_service_method.h>
#include <grpc++/impl/codegen/service_type.h>
#include <grpc++/impl/codegen/sync_stream.h>
namespace Services {

static const char* MasterService_method_names[] = {
  "/Services.MasterService/Connect",
  "/Services.MasterService/Heartbeat",
  "/Services.MasterService/SendLocations",
  "/Services.MasterService/SendActivity",
  "/Services.MasterService/NotifyLocationState",
  "/Services.MasterService/GetUnits",
};

std::unique_ptr< MasterService::Stub> MasterService::NewStub(const std::shared_ptr< ::grpc::ChannelInterface>& channel, const ::grpc::StubOptions& options) {
  std::unique_ptr< MasterService::Stub> stub(new MasterService::Stub(channel));
  return stub;
}

MasterService::Stub::Stub(const std::shared_ptr< ::grpc::ChannelInterface>& channel)
  : channel_(channel), rpcmethod_Connect_(MasterService_method_names[0], ::grpc::RpcMethod::NORMAL_RPC, channel)
  , rpcmethod_Heartbeat_(MasterService_method_names[1], ::grpc::RpcMethod::NORMAL_RPC, channel)
  , rpcmethod_SendLocations_(MasterService_method_names[2], ::grpc::RpcMethod::NORMAL_RPC, channel)
  , rpcmethod_SendActivity_(MasterService_method_names[3], ::grpc::RpcMethod::NORMAL_RPC, channel)
  , rpcmethod_NotifyLocationState_(MasterService_method_names[4], ::grpc::RpcMethod::NORMAL_RPC, channel)
  , rpcmethod_GetUnits_(MasterService_method_names[5], ::grpc::RpcMethod::NORMAL_RPC, channel)
  {}

::grpc::Status MasterService::Stub::Connect(::grpc::ClientContext* context, const ::DataTypes::ConnectedUnit& request, ::google::protobuf::Empty* response) {
  return ::grpc::BlockingUnaryCall(channel_.get(), rpcmethod_Connect_, context, request, response);
}

::grpc::ClientAsyncResponseReader< ::google::protobuf::Empty>* MasterService::Stub::AsyncConnectRaw(::grpc::ClientContext* context, const ::DataTypes::ConnectedUnit& request, ::grpc::CompletionQueue* cq) {
  return new ::grpc::ClientAsyncResponseReader< ::google::protobuf::Empty>(channel_.get(), cq, rpcmethod_Connect_, context, request);
}

::grpc::Status MasterService::Stub::Heartbeat(::grpc::ClientContext* context, const ::google::protobuf::Empty& request, ::google::protobuf::Empty* response) {
  return ::grpc::BlockingUnaryCall(channel_.get(), rpcmethod_Heartbeat_, context, request, response);
}

::grpc::ClientAsyncResponseReader< ::google::protobuf::Empty>* MasterService::Stub::AsyncHeartbeatRaw(::grpc::ClientContext* context, const ::google::protobuf::Empty& request, ::grpc::CompletionQueue* cq) {
  return new ::grpc::ClientAsyncResponseReader< ::google::protobuf::Empty>(channel_.get(), cq, rpcmethod_Heartbeat_, context, request);
}

::grpc::Status MasterService::Stub::SendLocations(::grpc::ClientContext* context, const ::DataTypes::Locations& request, ::google::protobuf::Empty* response) {
  return ::grpc::BlockingUnaryCall(channel_.get(), rpcmethod_SendLocations_, context, request, response);
}

::grpc::ClientAsyncResponseReader< ::google::protobuf::Empty>* MasterService::Stub::AsyncSendLocationsRaw(::grpc::ClientContext* context, const ::DataTypes::Locations& request, ::grpc::CompletionQueue* cq) {
  return new ::grpc::ClientAsyncResponseReader< ::google::protobuf::Empty>(channel_.get(), cq, rpcmethod_SendLocations_, context, request);
}

::grpc::Status MasterService::Stub::SendActivity(::grpc::ClientContext* context, const ::DataTypes::VisitRecords& request, ::google::protobuf::Empty* response) {
  return ::grpc::BlockingUnaryCall(channel_.get(), rpcmethod_SendActivity_, context, request, response);
}

::grpc::ClientAsyncResponseReader< ::google::protobuf::Empty>* MasterService::Stub::AsyncSendActivityRaw(::grpc::ClientContext* context, const ::DataTypes::VisitRecords& request, ::grpc::CompletionQueue* cq) {
  return new ::grpc::ClientAsyncResponseReader< ::google::protobuf::Empty>(channel_.get(), cq, rpcmethod_SendActivity_, context, request);
}

::grpc::Status MasterService::Stub::NotifyLocationState(::grpc::ClientContext* context, const ::DataTypes::UnitLocationState& request, ::google::protobuf::Empty* response) {
  return ::grpc::BlockingUnaryCall(channel_.get(), rpcmethod_NotifyLocationState_, context, request, response);
}

::grpc::ClientAsyncResponseReader< ::google::protobuf::Empty>* MasterService::Stub::AsyncNotifyLocationStateRaw(::grpc::ClientContext* context, const ::DataTypes::UnitLocationState& request, ::grpc::CompletionQueue* cq) {
  return new ::grpc::ClientAsyncResponseReader< ::google::protobuf::Empty>(channel_.get(), cq, rpcmethod_NotifyLocationState_, context, request);
}

::grpc::Status MasterService::Stub::GetUnits(::grpc::ClientContext* context, const ::google::protobuf::Empty& request, ::DataTypes::Units* response) {
  return ::grpc::BlockingUnaryCall(channel_.get(), rpcmethod_GetUnits_, context, request, response);
}

::grpc::ClientAsyncResponseReader< ::DataTypes::Units>* MasterService::Stub::AsyncGetUnitsRaw(::grpc::ClientContext* context, const ::google::protobuf::Empty& request, ::grpc::CompletionQueue* cq) {
  return new ::grpc::ClientAsyncResponseReader< ::DataTypes::Units>(channel_.get(), cq, rpcmethod_GetUnits_, context, request);
}

MasterService::Service::Service() {
  (void)MasterService_method_names;
  AddMethod(new ::grpc::RpcServiceMethod(
      MasterService_method_names[0],
      ::grpc::RpcMethod::NORMAL_RPC,
      new ::grpc::RpcMethodHandler< MasterService::Service, ::DataTypes::ConnectedUnit, ::google::protobuf::Empty>(
          std::mem_fn(&MasterService::Service::Connect), this)));
  AddMethod(new ::grpc::RpcServiceMethod(
      MasterService_method_names[1],
      ::grpc::RpcMethod::NORMAL_RPC,
      new ::grpc::RpcMethodHandler< MasterService::Service, ::google::protobuf::Empty, ::google::protobuf::Empty>(
          std::mem_fn(&MasterService::Service::Heartbeat), this)));
  AddMethod(new ::grpc::RpcServiceMethod(
      MasterService_method_names[2],
      ::grpc::RpcMethod::NORMAL_RPC,
      new ::grpc::RpcMethodHandler< MasterService::Service, ::DataTypes::Locations, ::google::protobuf::Empty>(
          std::mem_fn(&MasterService::Service::SendLocations), this)));
  AddMethod(new ::grpc::RpcServiceMethod(
      MasterService_method_names[3],
      ::grpc::RpcMethod::NORMAL_RPC,
      new ::grpc::RpcMethodHandler< MasterService::Service, ::DataTypes::VisitRecords, ::google::protobuf::Empty>(
          std::mem_fn(&MasterService::Service::SendActivity), this)));
  AddMethod(new ::grpc::RpcServiceMethod(
      MasterService_method_names[4],
      ::grpc::RpcMethod::NORMAL_RPC,
      new ::grpc::RpcMethodHandler< MasterService::Service, ::DataTypes::UnitLocationState, ::google::protobuf::Empty>(
          std::mem_fn(&MasterService::Service::NotifyLocationState), this)));
  AddMethod(new ::grpc::RpcServiceMethod(
      MasterService_method_names[5],
      ::grpc::RpcMethod::NORMAL_RPC,
      new ::grpc::RpcMethodHandler< MasterService::Service, ::google::protobuf::Empty, ::DataTypes::Units>(
          std::mem_fn(&MasterService::Service::GetUnits), this)));
}

MasterService::Service::~Service() {
}

::grpc::Status MasterService::Service::Connect(::grpc::ServerContext* context, const ::DataTypes::ConnectedUnit* request, ::google::protobuf::Empty* response) {
  (void) context;
  (void) request;
  (void) response;
  return ::grpc::Status(::grpc::StatusCode::UNIMPLEMENTED, "");
}

::grpc::Status MasterService::Service::Heartbeat(::grpc::ServerContext* context, const ::google::protobuf::Empty* request, ::google::protobuf::Empty* response) {
  (void) context;
  (void) request;
  (void) response;
  return ::grpc::Status(::grpc::StatusCode::UNIMPLEMENTED, "");
}

::grpc::Status MasterService::Service::SendLocations(::grpc::ServerContext* context, const ::DataTypes::Locations* request, ::google::protobuf::Empty* response) {
  (void) context;
  (void) request;
  (void) response;
  return ::grpc::Status(::grpc::StatusCode::UNIMPLEMENTED, "");
}

::grpc::Status MasterService::Service::SendActivity(::grpc::ServerContext* context, const ::DataTypes::VisitRecords* request, ::google::protobuf::Empty* response) {
  (void) context;
  (void) request;
  (void) response;
  return ::grpc::Status(::grpc::StatusCode::UNIMPLEMENTED, "");
}

::grpc::Status MasterService::Service::NotifyLocationState(::grpc::ServerContext* context, const ::DataTypes::UnitLocationState* request, ::google::protobuf::Empty* response) {
  (void) context;
  (void) request;
  (void) response;
  return ::grpc::Status(::grpc::StatusCode::UNIMPLEMENTED, "");
}

::grpc::Status MasterService::Service::GetUnits(::grpc::ServerContext* context, const ::google::protobuf::Empty* request, ::DataTypes::Units* response) {
  (void) context;
  (void) request;
  (void) response;
  return ::grpc::Status(::grpc::StatusCode::UNIMPLEMENTED, "");
}


}  // namespace Services
