// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: services/client_service.proto
#region Designer generated code

using System;
using System.Threading;
using System.Threading.Tasks;
using Grpc.Core;

namespace Services {
  public static class ClientService
  {
    static readonly string __ServiceName = "Services.ClientService";

    static readonly Marshaller<global::DataTypes.VisitRecords> __Marshaller_VisitRecords = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::DataTypes.VisitRecords.Parser.ParseFrom);
    static readonly Marshaller<global::Google.Protobuf.WellKnownTypes.Empty> __Marshaller_Empty = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Protobuf.WellKnownTypes.Empty.Parser.ParseFrom);
    static readonly Marshaller<global::DataTypes.UpdatedUnit> __Marshaller_UpdatedUnit = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::DataTypes.UpdatedUnit.Parser.ParseFrom);
    static readonly Marshaller<global::DataTypes.Location> __Marshaller_Location = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::DataTypes.Location.Parser.ParseFrom);
    static readonly Marshaller<global::DataTypes.DeviceUpdate> __Marshaller_DeviceUpdate = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::DataTypes.DeviceUpdate.Parser.ParseFrom);

    static readonly Method<global::DataTypes.VisitRecords, global::Google.Protobuf.WellKnownTypes.Empty> __Method_UpdateVisitRecords = new Method<global::DataTypes.VisitRecords, global::Google.Protobuf.WellKnownTypes.Empty>(
        MethodType.Unary,
        __ServiceName,
        "UpdateVisitRecords",
        __Marshaller_VisitRecords,
        __Marshaller_Empty);

    static readonly Method<global::DataTypes.UpdatedUnit, global::Google.Protobuf.WellKnownTypes.Empty> __Method_UpdateUnits = new Method<global::DataTypes.UpdatedUnit, global::Google.Protobuf.WellKnownTypes.Empty>(
        MethodType.Unary,
        __ServiceName,
        "UpdateUnits",
        __Marshaller_UpdatedUnit,
        __Marshaller_Empty);

    static readonly Method<global::DataTypes.Location, global::Google.Protobuf.WellKnownTypes.Empty> __Method_UpdateLocation = new Method<global::DataTypes.Location, global::Google.Protobuf.WellKnownTypes.Empty>(
        MethodType.Unary,
        __ServiceName,
        "UpdateLocation",
        __Marshaller_Location,
        __Marshaller_Empty);

    static readonly Method<global::DataTypes.DeviceUpdate, global::Google.Protobuf.WellKnownTypes.Empty> __Method_PushUpdates = new Method<global::DataTypes.DeviceUpdate, global::Google.Protobuf.WellKnownTypes.Empty>(
        MethodType.Unary,
        __ServiceName,
        "PushUpdates",
        __Marshaller_DeviceUpdate,
        __Marshaller_Empty);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Services.ClientServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of ClientService</summary>
    public abstract class ClientServiceBase
    {
      public virtual global::System.Threading.Tasks.Task<global::Google.Protobuf.WellKnownTypes.Empty> UpdateVisitRecords(global::DataTypes.VisitRecords request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Google.Protobuf.WellKnownTypes.Empty> UpdateUnits(global::DataTypes.UpdatedUnit request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Google.Protobuf.WellKnownTypes.Empty> UpdateLocation(global::DataTypes.Location request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Google.Protobuf.WellKnownTypes.Empty> PushUpdates(global::DataTypes.DeviceUpdate request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for ClientService</summary>
    public class ClientServiceClient : ClientBase<ClientServiceClient>
    {
      /// <summary>Creates a new client for ClientService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public ClientServiceClient(Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for ClientService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public ClientServiceClient(CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected ClientServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected ClientServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::Google.Protobuf.WellKnownTypes.Empty UpdateVisitRecords(global::DataTypes.VisitRecords request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return UpdateVisitRecords(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Google.Protobuf.WellKnownTypes.Empty UpdateVisitRecords(global::DataTypes.VisitRecords request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_UpdateVisitRecords, null, options, request);
      }
      public virtual AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> UpdateVisitRecordsAsync(global::DataTypes.VisitRecords request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return UpdateVisitRecordsAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> UpdateVisitRecordsAsync(global::DataTypes.VisitRecords request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_UpdateVisitRecords, null, options, request);
      }
      public virtual global::Google.Protobuf.WellKnownTypes.Empty UpdateUnits(global::DataTypes.UpdatedUnit request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return UpdateUnits(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Google.Protobuf.WellKnownTypes.Empty UpdateUnits(global::DataTypes.UpdatedUnit request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_UpdateUnits, null, options, request);
      }
      public virtual AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> UpdateUnitsAsync(global::DataTypes.UpdatedUnit request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return UpdateUnitsAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> UpdateUnitsAsync(global::DataTypes.UpdatedUnit request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_UpdateUnits, null, options, request);
      }
      public virtual global::Google.Protobuf.WellKnownTypes.Empty UpdateLocation(global::DataTypes.Location request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return UpdateLocation(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Google.Protobuf.WellKnownTypes.Empty UpdateLocation(global::DataTypes.Location request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_UpdateLocation, null, options, request);
      }
      public virtual AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> UpdateLocationAsync(global::DataTypes.Location request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return UpdateLocationAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> UpdateLocationAsync(global::DataTypes.Location request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_UpdateLocation, null, options, request);
      }
      public virtual global::Google.Protobuf.WellKnownTypes.Empty PushUpdates(global::DataTypes.DeviceUpdate request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return PushUpdates(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Google.Protobuf.WellKnownTypes.Empty PushUpdates(global::DataTypes.DeviceUpdate request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_PushUpdates, null, options, request);
      }
      public virtual AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> PushUpdatesAsync(global::DataTypes.DeviceUpdate request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return PushUpdatesAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> PushUpdatesAsync(global::DataTypes.DeviceUpdate request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_PushUpdates, null, options, request);
      }
      protected override ClientServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new ClientServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    public static ServerServiceDefinition BindService(ClientServiceBase serviceImpl)
    {
      return ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_UpdateVisitRecords, serviceImpl.UpdateVisitRecords)
          .AddMethod(__Method_UpdateUnits, serviceImpl.UpdateUnits)
          .AddMethod(__Method_UpdateLocation, serviceImpl.UpdateLocation)
          .AddMethod(__Method_PushUpdates, serviceImpl.PushUpdates).Build();
    }

  }
}
#endregion