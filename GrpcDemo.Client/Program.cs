using GrpcDemo.Client;

// var contactClient = new InvoiceClient();
// await contactClient.CreateContactAsync();

// var serverStreamingClient = new ServerStreamingClient();
// await serverStreamingClient.GetRandomNumbers();

// var clientStreamingClient = new ClientStreamingClient();
// await clientStreamingClient.SendRandomNumbers();

var bidirectionalStreamingClient = new BidirectionalStreamingClient();
await bidirectionalStreamingClient.SendMessage();