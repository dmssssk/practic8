namespace practic_8;

public record Share(string Access, string Type);

public record SeadoxInfo(
    string Id,
    string Name,
    string Description,
    bool IsIndexed,
    string CoverUrl,
    string OwnerId,
    string ParentId,
    DateTimeOffset CreatedAt,
    DateTimeOffset UpdatedAt



);

public record SeadoxModel(
    string Id,
    string Name,
    string Description,
    bool IsIndexed,
    string CoverUrl,
    string OwnerId,
    string ParentId,
    DateTimeOffset CreatedAt,
    DateTimeOffset UpdatedAt,

    string AccessLevel,
    Share Share,
    SeadoxInfo[] Lineage,
    SeadoxInfo[] Children
) : SeadoxInfo(
    Id,
    Name,
    Description,
    IsIndexed,
    CoverUrl,
    OwnerId,
    ParentId,
    CreatedAt,
    UpdatedAt
);
