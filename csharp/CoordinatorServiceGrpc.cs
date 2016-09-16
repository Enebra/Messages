// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: services/coordinator_service.proto
#region Designer generated code

using System;
using System.Threading;
using System.Threading.Tasks;
using Grpc.Core;

namespace Services {
  public static class CoordinatorService
  {
    static readonly string __ServiceName = "Services.CoordinatorService";

    static readonly Marshaller<global::DataTypes.ConnectedUnit> __Marshaller_ConnectedUnit = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::DataTypes.ConnectedUnit.Parser.ParseFrom);
    static readonly Marshaller<global::Google.Protobuf.WellKnownTypes.Empty> __Marshaller_Empty = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Protobuf.WellKnownTypes.Empty.Parser.ParseFrom);
    static readonly Marshaller<global::Services.HeartbeatMessage> __Marshaller_HeartbeatMessage = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Services.HeartbeatMessage.Parser.ParseFrom);
    static readonly Marshaller<global::DataTypes.Units> __Marshaller_Units = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::DataTypes.Units.Parser.ParseFrom);
    static readonly Marshaller<global::DataTypes.MessageBytes> __Marshaller_MessageBytes = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::DataTypes.MessageBytes.Parser.ParseFrom);
    static readonly Marshaller<global::DataTypes.DeviceUpdate> __Marshaller_DeviceUpdate = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::DataTypes.DeviceUpdate.Parser.ParseFrom);

    static readonly Method<global::DataTypes.ConnectedUnit, global::Google.Protobuf.WellKnownTypes.Empty> __Method_Connect = new Method<global::DataTypes.ConnectedUnit, global::Google.Protobuf.WellKnownTypes.Empty>(
        MethodType.Unary,
        __ServiceName,
        "Connect",
        __Marshaller_ConnectedUnit,
        __Marshaller_Empty);

    static readonly Method<global::Services.HeartbeatMessage, global::Google.Protobuf.WellKnownTypes.Empty> __Method_Heartbeat = new Method<global::Services.HeartbeatMessage, global::Google.Protobuf.WellKnownTypes.Empty>(
        MethodType.Unary,
        __ServiceName,
        "Heartbeat",
        __Marshaller_HeartbeatMessage,
        __Marshaller_Empty);

    static readonly Method<global::Google.Protobuf.WellKnownTypes.Empty, global::DataTypes.Units> __Method_GetUnits = new Method<global::Google.Protobuf.WellKnownTypes.Empty, global::DataTypes.Units>(
        MethodType.Unary,
        __ServiceName,
        "GetUnits",
        __Marshaller_Empty,
        __Marshaller_Units);

    static readonly Method<global::DataTypes.ConnectedUnit, global::Google.Protobuf.WellKnownTypes.Empty> __Method_Subscribe = new Method<global::DataTypes.ConnectedUnit, global::Google.Protobuf.WellKnownTypes.Empty>(
        MethodType.Unary,
        __ServiceName,
        "Subscribe",
        __Marshaller_ConnectedUnit,
        __Marshaller_Empty);

    static readonly Method<global::DataTypes.ConnectedUnit, global::Google.Protobuf.WellKnownTypes.Empty> __Method_Unsubscribe = new Method<global::DataTypes.ConnectedUnit, global::Google.Protobuf.WellKnownTypes.Empty>(
        MethodType.Unary,
        __ServiceName,
        "Unsubscribe",
        __Marshaller_ConnectedUnit,
        __Marshaller_Empty);

    static readonly Method<global::DataTypes.MessageBytes, global::DataTypes.MessageBytes> __Method_Get = new Method<global::DataTypes.MessageBytes, global::DataTypes.MessageBytes>(
        MethodType.Unary,
        __ServiceName,
        "Get",
        __Marshaller_MessageBytes,
        __Marshaller_MessageBytes);

    static readonly Method<global::DataTypes.MessageBytes, global::DataTypes.MessageBytes> __Method_Commit = new Method<global::DataTypes.MessageBytes, global::DataTypes.MessageBytes>(
        MethodType.Unary,
        __ServiceName,
        "Commit",
        __Marshaller_MessageBytes,
        __Marshaller_MessageBytes);

    static readonly Method<global::DataTypes.DeviceUpdate, global::Google.Protobuf.WellKnownTypes.Empty> __Method_PushUpdates = new Method<global::DataTypes.DeviceUpdate, global::Google.Protobuf.WellKnownTypes.Empty>(
        MethodType.Unary,
        __ServiceName,
        "PushUpdates",
        __Marshaller_DeviceUpdate,
        __Marshaller_Empty);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Services.CoordinatorServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of CoordinatorService</summary>
    public abstract class CoordinatorServiceBase
    {
      public virtual global::System.Threading.Tasks.Task<global::Google.Protobuf.WellKnownTypes.Empty> Connect(global::DataTypes.ConnectedUnit request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Google.Protobuf.WellKnownTypes.Empty> Heartbeat(global::Services.HeartbeatMessage request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::DataTypes.Units> GetUnits(global::Google.Protobuf.WellKnownTypes.Empty request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Google.Protobuf.WellKnownTypes.Empty> Subscribe(global::DataTypes.ConnectedUnit request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Google.Protobuf.WellKnownTypes.Empty> Unsubscribe(global::DataTypes.ConnectedUnit request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::DataTypes.MessageBytes> Get(global::DataTypes.MessageBytes request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::DataTypes.MessageBytes> Commit(global::DataTypes.MessageBytes request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Google.Protobuf.WellKnownTypes.Empty> PushUpdates(global::DataTypes.DeviceUpdate request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for CoordinatorService</summary>
    public class CoordinatorServiceClient : ClientBase<CoordinatorServiceClient>
    {
      /// <summary>Creates a new client for CoordinatorService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public CoordinatorServiceClient(Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for CoordinatorService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public CoordinatorServiceClient(CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected CoordinatorServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected CoordinatorServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::Google.Protobuf.WellKnownTypes.Empty Connect(global::DataTypes.ConnectedUnit request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return Connect(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Google.Protobuf.WellKnownTypes.Empty Connect(global::DataTypes.ConnectedUnit request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Connect, null, options, request);
      }
      public virtual AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> ConnectAsync(global::DataTypes.ConnectedUnit request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return ConnectAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> ConnectAsync(global::DataTypes.ConnectedUnit request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Connect, null, options, request);
      }
      public virtual global::Google.Protobuf.WellKnownTypes.Empty Heartbeat(global::Services.HeartbeatMessage request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return Heartbeat(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Google.Protobuf.WellKnownTypes.Empty Heartbeat(global::Services.HeartbeatMessage request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Heartbeat, null, options, request);
      }
      public virtual AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> HeartbeatAsync(global::Services.HeartbeatMessage request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return HeartbeatAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> HeartbeatAsync(global::Services.HeartbeatMessage request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Heartbeat, null, options, request);
      }
      public virtual global::DataTypes.Units GetUnits(global::Google.Protobuf.WellKnownTypes.Empty request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetUnits(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::DataTypes.Units GetUnits(global::Google.Protobuf.WellKnownTypes.Empty request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetUnits, null, options, request);
      }
      public virtual AsyncUnaryCall<global::DataTypes.Units> GetUnitsAsync(global::Google.Protobuf.WellKnownTypes.Empty request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetUnitsAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual AsyncUnaryCall<global::DataTypes.Units> GetUnitsAsync(global::Google.Protobuf.WellKnownTypes.Empty request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetUnits, null, options, request);
      }
      public virtual global::Google.Protobuf.WellKnownTypes.Empty Subscribe(global::DataTypes.ConnectedUnit request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return Subscribe(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Google.Protobuf.WellKnownTypes.Empty Subscribe(global::DataTypes.ConnectedUnit request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Subscribe, null, options, request);
      }
      public virtual AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> SubscribeAsync(global::DataTypes.ConnectedUnit request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return SubscribeAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> SubscribeAsync(global::DataTypes.ConnectedUnit request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Subscribe, null, options, request);
      }
      public virtual global::Google.Protobuf.WellKnownTypes.Empty Unsubscribe(global::DataTypes.ConnectedUnit request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return Unsubscribe(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Google.Protobuf.WellKnownTypes.Empty Unsubscribe(global::DataTypes.ConnectedUnit request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Unsubscribe, null, options, request);
      }
      public virtual AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> UnsubscribeAsync(global::DataTypes.ConnectedUnit request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return UnsubscribeAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> UnsubscribeAsync(global::DataTypes.ConnectedUnit request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Unsubscribe, null, options, request);
      }
      public virtual global::DataTypes.MessageBytes Get(global::DataTypes.MessageBytes request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return Get(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::DataTypes.MessageBytes Get(global::DataTypes.MessageBytes request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Get, null, options, request);
      }
      public virtual AsyncUnaryCall<global::DataTypes.MessageBytes> GetAsync(global::DataTypes.MessageBytes request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual AsyncUnaryCall<global::DataTypes.MessageBytes> GetAsync(global::DataTypes.MessageBytes request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Get, null, options, request);
      }
      public virtual global::DataTypes.MessageBytes Commit(global::DataTypes.MessageBytes request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return Commit(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::DataTypes.MessageBytes Commit(global::DataTypes.MessageBytes request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Commit, null, options, request);
      }
      public virtual AsyncUnaryCall<global::DataTypes.MessageBytes> CommitAsync(global::DataTypes.MessageBytes request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return CommitAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual AsyncUnaryCall<global::DataTypes.MessageBytes> CommitAsync(global::DataTypes.MessageBytes request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Commit, null, options, request);
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
      protected override CoordinatorServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new CoordinatorServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    public static ServerServiceDefinition BindService(CoordinatorServiceBase serviceImpl)
    {
      return ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_Connect, serviceImpl.Connect)
          .AddMethod(__Method_Heartbeat, serviceImpl.Heartbeat)
          .AddMethod(__Method_GetUnits, serviceImpl.GetUnits)
          .AddMethod(__Method_Subscribe, serviceImpl.Subscribe)
          .AddMethod(__Method_Unsubscribe, serviceImpl.Unsubscribe)
          .AddMethod(__Method_Get, serviceImpl.Get)
          .AddMethod(__Method_Commit, serviceImpl.Commit)
          .AddMethod(__Method_PushUpdates, serviceImpl.PushUpdates).Build();
    }

  }
}
#endregion
