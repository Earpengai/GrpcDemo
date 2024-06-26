using GrpcDemo.Client;

var contactClient = new InvoiceClient();
await contactClient.CreateContactAsync();