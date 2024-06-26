using Grpc.Net.Client;

namespace GrpcDemo.Client;

internal class InvoiceClient
{
    public async Task CreateContactAsync() 
    {
        using var channel = GrpcChannel.ForAddress(@"https://localhost:7179");
        var client = new Contact.ContactClient(channel);
        var reply = await client.CreateContactAsync(new CreateContactRequest()
        {
            Email = "vannda@example.com",
            FristName = "Man",
            LastName = "Vanna",
            IsActive = true,
            Phone = "012 111 111",
            YearOfBirth = 1998
        });
        Console.WriteLine("Created Contact: " + reply.ContactId);
        Console.ReadKey();
    }
}