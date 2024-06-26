using Grpc.Core;

namespace GrpcDemo.Services;

public class ContactService(ILogger<ContactService> logger) : Contact.ContactBase
{
     public override Task<CreateContactResponse> CreateContact(CreateContactRequest request, ServerCallContext context)
     {
        return Task.FromResult(new CreateContactResponse{
            ContactId = Guid.NewGuid().ToString()
        });
     }
}