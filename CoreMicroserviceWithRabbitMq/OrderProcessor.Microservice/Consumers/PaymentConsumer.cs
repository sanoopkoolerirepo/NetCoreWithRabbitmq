using MassTransit;
using Shared.Models;
using System.Threading.Tasks;

namespace TicketProcessor.Microservice.Consumers
{
    public class PaymentConsumer : IConsumer<Payment>
    {
        public async Task Consume(ConsumeContext<Payment> context)
        {
            var data = context.Message;
            //Validate the Ticket Data
            //Store to Database
            //Notify the user via Email / SMS
        }
    }
}
