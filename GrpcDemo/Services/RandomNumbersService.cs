using Grpc.Core;

namespace GrpcDemo.Services;

public class RandomNumbersService(ILogger<RandomNumbersService> logger)
    : RandomNumbers.RandomNumbersBase
{
    public override async Task GetRandomNumbers(
        GetRandomNumbersRequest request, 
        IServerStreamWriter<GetRandomNumbersResponse> responseStream,
        ServerCallContext context)
    {
        var random = new Random();
        while (!context.CancellationToken.IsCancellationRequested)
        {
            await responseStream.WriteAsync(new GetRandomNumbersResponse{
                Number = random.Next(request.Min, request.Max)
            });
            await Task.Delay(1000);
        }
    }
}