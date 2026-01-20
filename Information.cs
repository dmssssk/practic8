namespace practic_8;


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



)
{

    public virtual void ShowInfo()
    {
        foreach (var property in GetType().GetProperties())
        {
            Console.Write($"{property.Name}: {property.GetValue(this)}");
        }
    }
};


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
    string Share,
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
)
{
    
    private void ShowSeadBoxInfo(SeadoxInfo subclass)
    {
        foreach (var property in GetType().GetProperties())
        {
            Console.Write($"\t{property.Name}: {property.GetValue(this)} \n");
        }
    }
    
    public override void ShowInfo()
    {
        foreach (var property in GetType().GetProperties())
        {
            Console.Write($"{property.Name}: {()=> {
                if (property.GetValue(this) is var value && value.GetType().IsArray)
                {
                    if (value.GetType() == typeof(SeadoxInfo[])) {
                        foreach (var seadoxInfo in value as SeadoxInfo[])
                        {
                            ShowSeadBoxInfo(seadoxInfo);
                        }
                    }

                    else {
                        for (int i = 0; i < value.GetType().GetProperties().Length; i++) {
                            Console.WriteLine($"\t{i}: {(value as Object[])[i]}\n");
                        }
                    }

                }
            }} \n");
        }
    }
};
