namespace CatchUpPlatform.API.shared.domain.model;

public interface IAuditable_Entity
{
    DateTimeOffset CreatedAt { get; set; }
    DateTimeOffset UpdatedAt { get; set; }
}