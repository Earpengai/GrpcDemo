// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/random_numbers.proto
// </auto-generated>
#pragma warning disable 0414, 1591, 8981, 0612
#region Designer generated code

using grpc = global::Grpc.Core;

namespace GrpcDemo {
  public static partial class RandomNumbers
  {
    static readonly string __ServiceName = "greet.RandomNumbers";

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static void __Helper_SerializeMessage(global::Google.Protobuf.IMessage message, grpc::SerializationContext context)
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (message is global::Google.Protobuf.IBufferMessage)
      {
        context.SetPayloadLength(message.CalculateSize());
        global::Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
        context.Complete();
        return;
      }
      #endif
      context.Complete(global::Google.Protobuf.MessageExtensions.ToByteArray(message));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static T __Helper_DeserializeMessage<T>(grpc::DeserializationContext context, global::Google.Protobuf.MessageParser<T> parser) where T : global::Google.Protobuf.IMessage<T>
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (__Helper_MessageCache<T>.IsBufferMessage)
      {
        return parser.ParseFrom(context.PayloadAsReadOnlySequence());
      }
      #endif
      return parser.ParseFrom(context.PayloadAsNewBuffer());
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::GrpcDemo.GetRandomNumbersRequest> __Marshaller_greet_GetRandomNumbersRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GrpcDemo.GetRandomNumbersRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::GrpcDemo.GetRandomNumbersResponse> __Marshaller_greet_GetRandomNumbersResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GrpcDemo.GetRandomNumbersResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::GrpcDemo.SendRandomNumbersRequest> __Marshaller_greet_SendRandomNumbersRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GrpcDemo.SendRandomNumbersRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::GrpcDemo.SendRandomNumbersResponse> __Marshaller_greet_SendRandomNumbersResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GrpcDemo.SendRandomNumbersResponse.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::GrpcDemo.GetRandomNumbersRequest, global::GrpcDemo.GetRandomNumbersResponse> __Method_GetRandomNumbers = new grpc::Method<global::GrpcDemo.GetRandomNumbersRequest, global::GrpcDemo.GetRandomNumbersResponse>(
        grpc::MethodType.ServerStreaming,
        __ServiceName,
        "GetRandomNumbers",
        __Marshaller_greet_GetRandomNumbersRequest,
        __Marshaller_greet_GetRandomNumbersResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::GrpcDemo.SendRandomNumbersRequest, global::GrpcDemo.SendRandomNumbersResponse> __Method_SendRandomNumbers = new grpc::Method<global::GrpcDemo.SendRandomNumbersRequest, global::GrpcDemo.SendRandomNumbersResponse>(
        grpc::MethodType.ClientStreaming,
        __ServiceName,
        "SendRandomNumbers",
        __Marshaller_greet_SendRandomNumbersRequest,
        __Marshaller_greet_SendRandomNumbersResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::GrpcDemo.RandomNumbersReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of RandomNumbers</summary>
    [grpc::BindServiceMethod(typeof(RandomNumbers), "BindService")]
    public abstract partial class RandomNumbersBase
    {
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task GetRandomNumbers(global::GrpcDemo.GetRandomNumbersRequest request, grpc::IServerStreamWriter<global::GrpcDemo.GetRandomNumbersResponse> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::GrpcDemo.SendRandomNumbersResponse> SendRandomNumbers(grpc::IAsyncStreamReader<global::GrpcDemo.SendRandomNumbersRequest> requestStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(RandomNumbersBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetRandomNumbers, serviceImpl.GetRandomNumbers)
          .AddMethod(__Method_SendRandomNumbers, serviceImpl.SendRandomNumbers).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, RandomNumbersBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_GetRandomNumbers, serviceImpl == null ? null : new grpc::ServerStreamingServerMethod<global::GrpcDemo.GetRandomNumbersRequest, global::GrpcDemo.GetRandomNumbersResponse>(serviceImpl.GetRandomNumbers));
      serviceBinder.AddMethod(__Method_SendRandomNumbers, serviceImpl == null ? null : new grpc::ClientStreamingServerMethod<global::GrpcDemo.SendRandomNumbersRequest, global::GrpcDemo.SendRandomNumbersResponse>(serviceImpl.SendRandomNumbers));
    }

  }
}
#endregion
