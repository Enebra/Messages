// Generated by the gRPC protobuf plugin.
// If you make any local change, they will be lost.
// source: services/unit_service.proto
#ifndef GRPC_services_2funit_5fservice_2eproto__INCLUDED
#define GRPC_services_2funit_5fservice_2eproto__INCLUDED

#include "services/unit_service.pb.h"

#include <grpc++/impl/codegen/async_stream.h>
#include <grpc++/impl/codegen/async_unary_call.h>
#include <grpc++/impl/codegen/proto_utils.h>
#include <grpc++/impl/codegen/rpc_method.h>
#include <grpc++/impl/codegen/service_type.h>
#include <grpc++/impl/codegen/status.h>
#include <grpc++/impl/codegen/stub_options.h>
#include <grpc++/impl/codegen/sync_stream.h>

namespace grpc {
class CompletionQueue;
class Channel;
class RpcService;
class ServerCompletionQueue;
class ServerContext;
}  // namespace grpc

namespace Services {

class UnitService GRPC_FINAL {
 public:
  class StubInterface {
   public:
    virtual ~StubInterface() {}
    virtual ::grpc::Status OpenDoor(::grpc::ClientContext* context, const ::DataTypes::Location& request, ::google::protobuf::Empty* response) = 0;
    std::unique_ptr< ::grpc::ClientAsyncResponseReaderInterface< ::google::protobuf::Empty>> AsyncOpenDoor(::grpc::ClientContext* context, const ::DataTypes::Location& request, ::grpc::CompletionQueue* cq) {
      return std::unique_ptr< ::grpc::ClientAsyncResponseReaderInterface< ::google::protobuf::Empty>>(AsyncOpenDoorRaw(context, request, cq));
    }
    virtual ::grpc::Status UpdateUnits(::grpc::ClientContext* context, const ::DataTypes::UpdatedUnits& request, ::google::protobuf::Empty* response) = 0;
    std::unique_ptr< ::grpc::ClientAsyncResponseReaderInterface< ::google::protobuf::Empty>> AsyncUpdateUnits(::grpc::ClientContext* context, const ::DataTypes::UpdatedUnits& request, ::grpc::CompletionQueue* cq) {
      return std::unique_ptr< ::grpc::ClientAsyncResponseReaderInterface< ::google::protobuf::Empty>>(AsyncUpdateUnitsRaw(context, request, cq));
    }
    virtual ::grpc::Status UpdateActvity(::grpc::ClientContext* context, const ::DataTypes::VisitRecords& request, ::google::protobuf::Empty* response) = 0;
    std::unique_ptr< ::grpc::ClientAsyncResponseReaderInterface< ::google::protobuf::Empty>> AsyncUpdateActvity(::grpc::ClientContext* context, const ::DataTypes::VisitRecords& request, ::grpc::CompletionQueue* cq) {
      return std::unique_ptr< ::grpc::ClientAsyncResponseReaderInterface< ::google::protobuf::Empty>>(AsyncUpdateActvityRaw(context, request, cq));
    }
  private:
    virtual ::grpc::ClientAsyncResponseReaderInterface< ::google::protobuf::Empty>* AsyncOpenDoorRaw(::grpc::ClientContext* context, const ::DataTypes::Location& request, ::grpc::CompletionQueue* cq) = 0;
    virtual ::grpc::ClientAsyncResponseReaderInterface< ::google::protobuf::Empty>* AsyncUpdateUnitsRaw(::grpc::ClientContext* context, const ::DataTypes::UpdatedUnits& request, ::grpc::CompletionQueue* cq) = 0;
    virtual ::grpc::ClientAsyncResponseReaderInterface< ::google::protobuf::Empty>* AsyncUpdateActvityRaw(::grpc::ClientContext* context, const ::DataTypes::VisitRecords& request, ::grpc::CompletionQueue* cq) = 0;
  };
  class Stub GRPC_FINAL : public StubInterface {
   public:
    Stub(const std::shared_ptr< ::grpc::ChannelInterface>& channel);
    ::grpc::Status OpenDoor(::grpc::ClientContext* context, const ::DataTypes::Location& request, ::google::protobuf::Empty* response) GRPC_OVERRIDE;
    std::unique_ptr< ::grpc::ClientAsyncResponseReader< ::google::protobuf::Empty>> AsyncOpenDoor(::grpc::ClientContext* context, const ::DataTypes::Location& request, ::grpc::CompletionQueue* cq) {
      return std::unique_ptr< ::grpc::ClientAsyncResponseReader< ::google::protobuf::Empty>>(AsyncOpenDoorRaw(context, request, cq));
    }
    ::grpc::Status UpdateUnits(::grpc::ClientContext* context, const ::DataTypes::UpdatedUnits& request, ::google::protobuf::Empty* response) GRPC_OVERRIDE;
    std::unique_ptr< ::grpc::ClientAsyncResponseReader< ::google::protobuf::Empty>> AsyncUpdateUnits(::grpc::ClientContext* context, const ::DataTypes::UpdatedUnits& request, ::grpc::CompletionQueue* cq) {
      return std::unique_ptr< ::grpc::ClientAsyncResponseReader< ::google::protobuf::Empty>>(AsyncUpdateUnitsRaw(context, request, cq));
    }
    ::grpc::Status UpdateActvity(::grpc::ClientContext* context, const ::DataTypes::VisitRecords& request, ::google::protobuf::Empty* response) GRPC_OVERRIDE;
    std::unique_ptr< ::grpc::ClientAsyncResponseReader< ::google::protobuf::Empty>> AsyncUpdateActvity(::grpc::ClientContext* context, const ::DataTypes::VisitRecords& request, ::grpc::CompletionQueue* cq) {
      return std::unique_ptr< ::grpc::ClientAsyncResponseReader< ::google::protobuf::Empty>>(AsyncUpdateActvityRaw(context, request, cq));
    }

   private:
    std::shared_ptr< ::grpc::ChannelInterface> channel_;
    ::grpc::ClientAsyncResponseReader< ::google::protobuf::Empty>* AsyncOpenDoorRaw(::grpc::ClientContext* context, const ::DataTypes::Location& request, ::grpc::CompletionQueue* cq) GRPC_OVERRIDE;
    ::grpc::ClientAsyncResponseReader< ::google::protobuf::Empty>* AsyncUpdateUnitsRaw(::grpc::ClientContext* context, const ::DataTypes::UpdatedUnits& request, ::grpc::CompletionQueue* cq) GRPC_OVERRIDE;
    ::grpc::ClientAsyncResponseReader< ::google::protobuf::Empty>* AsyncUpdateActvityRaw(::grpc::ClientContext* context, const ::DataTypes::VisitRecords& request, ::grpc::CompletionQueue* cq) GRPC_OVERRIDE;
    const ::grpc::RpcMethod rpcmethod_OpenDoor_;
    const ::grpc::RpcMethod rpcmethod_UpdateUnits_;
    const ::grpc::RpcMethod rpcmethod_UpdateActvity_;
  };
  static std::unique_ptr<Stub> NewStub(const std::shared_ptr< ::grpc::ChannelInterface>& channel, const ::grpc::StubOptions& options = ::grpc::StubOptions());

  class Service : public ::grpc::Service {
   public:
    Service();
    virtual ~Service();
    virtual ::grpc::Status OpenDoor(::grpc::ServerContext* context, const ::DataTypes::Location* request, ::google::protobuf::Empty* response);
    virtual ::grpc::Status UpdateUnits(::grpc::ServerContext* context, const ::DataTypes::UpdatedUnits* request, ::google::protobuf::Empty* response);
    virtual ::grpc::Status UpdateActvity(::grpc::ServerContext* context, const ::DataTypes::VisitRecords* request, ::google::protobuf::Empty* response);
  };
  template <class BaseClass>
  class WithAsyncMethod_OpenDoor : public BaseClass {
   private:
    void BaseClassMustBeDerivedFromService(const Service *service) {}
   public:
    WithAsyncMethod_OpenDoor() {
      ::grpc::Service::MarkMethodAsync(0);
    }
    ~WithAsyncMethod_OpenDoor() GRPC_OVERRIDE {
      BaseClassMustBeDerivedFromService(this);
    }
    // disable synchronous version of this method
    ::grpc::Status OpenDoor(::grpc::ServerContext* context, const ::DataTypes::Location* request, ::google::protobuf::Empty* response) GRPC_FINAL GRPC_OVERRIDE {
      abort();
      return ::grpc::Status(::grpc::StatusCode::UNIMPLEMENTED, "");
    }
    void RequestOpenDoor(::grpc::ServerContext* context, ::DataTypes::Location* request, ::grpc::ServerAsyncResponseWriter< ::google::protobuf::Empty>* response, ::grpc::CompletionQueue* new_call_cq, ::grpc::ServerCompletionQueue* notification_cq, void *tag) {
      ::grpc::Service::RequestAsyncUnary(0, context, request, response, new_call_cq, notification_cq, tag);
    }
  };
  template <class BaseClass>
  class WithAsyncMethod_UpdateUnits : public BaseClass {
   private:
    void BaseClassMustBeDerivedFromService(const Service *service) {}
   public:
    WithAsyncMethod_UpdateUnits() {
      ::grpc::Service::MarkMethodAsync(1);
    }
    ~WithAsyncMethod_UpdateUnits() GRPC_OVERRIDE {
      BaseClassMustBeDerivedFromService(this);
    }
    // disable synchronous version of this method
    ::grpc::Status UpdateUnits(::grpc::ServerContext* context, const ::DataTypes::UpdatedUnits* request, ::google::protobuf::Empty* response) GRPC_FINAL GRPC_OVERRIDE {
      abort();
      return ::grpc::Status(::grpc::StatusCode::UNIMPLEMENTED, "");
    }
    void RequestUpdateUnits(::grpc::ServerContext* context, ::DataTypes::UpdatedUnits* request, ::grpc::ServerAsyncResponseWriter< ::google::protobuf::Empty>* response, ::grpc::CompletionQueue* new_call_cq, ::grpc::ServerCompletionQueue* notification_cq, void *tag) {
      ::grpc::Service::RequestAsyncUnary(1, context, request, response, new_call_cq, notification_cq, tag);
    }
  };
  template <class BaseClass>
  class WithAsyncMethod_UpdateActvity : public BaseClass {
   private:
    void BaseClassMustBeDerivedFromService(const Service *service) {}
   public:
    WithAsyncMethod_UpdateActvity() {
      ::grpc::Service::MarkMethodAsync(2);
    }
    ~WithAsyncMethod_UpdateActvity() GRPC_OVERRIDE {
      BaseClassMustBeDerivedFromService(this);
    }
    // disable synchronous version of this method
    ::grpc::Status UpdateActvity(::grpc::ServerContext* context, const ::DataTypes::VisitRecords* request, ::google::protobuf::Empty* response) GRPC_FINAL GRPC_OVERRIDE {
      abort();
      return ::grpc::Status(::grpc::StatusCode::UNIMPLEMENTED, "");
    }
    void RequestUpdateActvity(::grpc::ServerContext* context, ::DataTypes::VisitRecords* request, ::grpc::ServerAsyncResponseWriter< ::google::protobuf::Empty>* response, ::grpc::CompletionQueue* new_call_cq, ::grpc::ServerCompletionQueue* notification_cq, void *tag) {
      ::grpc::Service::RequestAsyncUnary(2, context, request, response, new_call_cq, notification_cq, tag);
    }
  };
  typedef WithAsyncMethod_OpenDoor<WithAsyncMethod_UpdateUnits<WithAsyncMethod_UpdateActvity<Service > > > AsyncService;
  template <class BaseClass>
  class WithGenericMethod_OpenDoor : public BaseClass {
   private:
    void BaseClassMustBeDerivedFromService(const Service *service) {}
   public:
    WithGenericMethod_OpenDoor() {
      ::grpc::Service::MarkMethodGeneric(0);
    }
    ~WithGenericMethod_OpenDoor() GRPC_OVERRIDE {
      BaseClassMustBeDerivedFromService(this);
    }
    // disable synchronous version of this method
    ::grpc::Status OpenDoor(::grpc::ServerContext* context, const ::DataTypes::Location* request, ::google::protobuf::Empty* response) GRPC_FINAL GRPC_OVERRIDE {
      abort();
      return ::grpc::Status(::grpc::StatusCode::UNIMPLEMENTED, "");
    }
  };
  template <class BaseClass>
  class WithGenericMethod_UpdateUnits : public BaseClass {
   private:
    void BaseClassMustBeDerivedFromService(const Service *service) {}
   public:
    WithGenericMethod_UpdateUnits() {
      ::grpc::Service::MarkMethodGeneric(1);
    }
    ~WithGenericMethod_UpdateUnits() GRPC_OVERRIDE {
      BaseClassMustBeDerivedFromService(this);
    }
    // disable synchronous version of this method
    ::grpc::Status UpdateUnits(::grpc::ServerContext* context, const ::DataTypes::UpdatedUnits* request, ::google::protobuf::Empty* response) GRPC_FINAL GRPC_OVERRIDE {
      abort();
      return ::grpc::Status(::grpc::StatusCode::UNIMPLEMENTED, "");
    }
  };
  template <class BaseClass>
  class WithGenericMethod_UpdateActvity : public BaseClass {
   private:
    void BaseClassMustBeDerivedFromService(const Service *service) {}
   public:
    WithGenericMethod_UpdateActvity() {
      ::grpc::Service::MarkMethodGeneric(2);
    }
    ~WithGenericMethod_UpdateActvity() GRPC_OVERRIDE {
      BaseClassMustBeDerivedFromService(this);
    }
    // disable synchronous version of this method
    ::grpc::Status UpdateActvity(::grpc::ServerContext* context, const ::DataTypes::VisitRecords* request, ::google::protobuf::Empty* response) GRPC_FINAL GRPC_OVERRIDE {
      abort();
      return ::grpc::Status(::grpc::StatusCode::UNIMPLEMENTED, "");
    }
  };
};

}  // namespace Services


#endif  // GRPC_services_2funit_5fservice_2eproto__INCLUDED
