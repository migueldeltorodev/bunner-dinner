using BuberDinner.Domain.Common.Models;
using BuberDinner.Domain.Dinner.ValueObjects;
using BuberDinner.Domain.Host.ValueObjects;
using BuberDinner.Domain.Menu.Entities;
using BuberDinner.Domain.Menu.ValueObjects;
using BuberDinner.Domain.MenuReview.ValueObjects;

namespace BuberDinner.Domain.Menu;

public sealed class Menu : AggregateRoot<MenuId>
{
    // basic atributes
    public string Name { get; }
    public string Description { get; }
    public float AverageRating { get; }
    public DateTime CreatedDateTime { get; }
    public DateTime UpdatedDateTime { get; }

    // private Aggregates and MenuSection entity
    private readonly List<MenuSection> _sections = new();
    private readonly List<DinnerId> _dinners = new();
    private readonly List<MenuReviewId> _reviews = new();

    // public aggregate lists
    public HostId HostId { get; }
    public IReadOnlyList<MenuSection> Sections => _sections;
    public IReadOnlyList<DinnerId> DinnersIds => _dinners;
    public IReadOnlyList<MenuReviewId> Reviews => _reviews;

    private Menu(MenuId id,
        string name,
        string description,
        float averageRating,
        DateTime createdDateTime,
        DateTime updatedDateTime,
        HostId hostId)
        : base(id)
    {
        Name = name;
        Description = description;
        AverageRating = averageRating;
        CreatedDateTime = createdDateTime;
        UpdatedDateTime = updatedDateTime;
        HostId = hostId;
    }

    public static Menu Create(string name, string description, float averageRating, HostId hostId)
    {
        return new Menu(
            MenuId.CreateUnique(),
            name,
            description,
            averageRating,
            DateTime.UtcNow,
            DateTime.UtcNow,
            hostId);
    }
}