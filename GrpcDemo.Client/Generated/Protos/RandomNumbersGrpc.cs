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

    /// <summary>Client for RandomNumbers</summary>
    public partial class RandomNumbersClient : grpc::ClientBase<RandomNumbersClient>
    {
      /// <summary>Creates a new client for RandomNumbers</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public RandomNumbersClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for RandomNumbers that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public RandomNumbersClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected RandomNumbersClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected RandomNumbersClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncServerStreamingCall<global::GrpcDemo.GetRandomNumbersResponse> GetRandomNumbers(global::GrpcDemo.GetRandomNumbersRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetRandomNumbers(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncServerStreamingCall<global::GrpcDemo.GetRandomNumbersResponse> GetRandomNumbers(global::GrpcDemo.GetRandomNumbersRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncServerStreamingCall(__Method_GetRandomNumbers, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncClientStreamingCall<global::GrpcDemo.SendRandomNumbersRequest, global::GrpcDemo.SendRandomNumbersResponse> SendRandomNumbers(grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SendRandomNumbers(new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncClientStreamingCall<global::GrpcDemo.SendRandomNumbersRequest, global::GrpcDemo.SendRandomNumbersResponse> SendRandomNumbers(grpc::CallOptions options)
      {
        return CallInvoker.AsyncClientStreamingCall(__Method_SendRandomNumbers, null, options);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected override RandomNumbersClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new RandomNumbersClient(configuration);
      }
    }

  }
}
#endregion
