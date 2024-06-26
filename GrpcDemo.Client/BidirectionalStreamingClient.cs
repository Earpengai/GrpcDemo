using Grpc.Core;
using Grpc.Net.Client;

namespace GrpcDemo.Client;

internal class BidirectionalStreamingClient
{
    public async Task SendMessage() 
    {
        using var channel = GrpcChannel.ForAddress(@"https://localhost:7179");
        var client = new Chat.ChatClient(channel);

        // Create Streaming request
        using var streamingCall = client.SendMessage();
        Console.WriteLine("Starting a background task to receive message ...");
        var responseReaderTask = Task.Run(async () => {
            await foreach (var response in streamingCall.ResponseStream.ReadAllAsync())
            {
                Console.WriteLine(response.Message);
            }
        });
        Console.WriteLine("Starting to send message...");
        Console.WriteLine("Input your message then press enter to send it.");
        while (true)
        {
            var message = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(message)) {break;}

            await streamingCall.RequestStream.WriteAsync(new ChatMessage
            {
                Sender = "Client",
                Message = message
            });
        }
        Console.WriteLine("Disconnecting...");
        await streamingCall.RequestStream.CompleteAsync();
        await responseReaderTask;
    }
}