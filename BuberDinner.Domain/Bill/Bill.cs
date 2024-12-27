using BuberDinner.Domain.Bill.ValueObjects;
using BuberDinner.Domain.Common.Models;
using BuberDinner.Domain.Dinner.ValueObjects;
using BuberDinner.Domain.Guest.ValueObjects;
using BuberDinner.Domain.Host.ValueObjects;

namespace BuberDinner.Domain.Bill;

public class Bill : AggregateRoot<BillId>
{
    public DateTime CreatedDateTime { get; }
    public DateTime UpdatedDateTime { get; }
    public HostId HostId;
    public DinnerId DinnerId;
    public GuestId GuestId;

    private Bill(BillId id, HostId hostId, DinnerId dinnerId, GuestId guestId, DateTime createdDateTime,
        DateTime updatedDateTime) : base(id)
    {
        HostId = hostId;
        DinnerId = dinnerId;
        GuestId = guestId;
        CreatedDateTime = createdDateTime;
        UpdatedDateTime = updatedDateTime;
    }

    public static Bill Create(HostId hostId, DinnerId dinnerId, GuestId guestId)
    {
        return new Bill(
            BillId.CreateUnique(),
            hostId,
            dinnerId,
            guestId,
            DateTime.UtcNow,
            DateTime.UtcNow
        );
    }
}