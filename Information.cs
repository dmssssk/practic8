namespace practic_8;

public record Information(
    string AccessLevel,
    string Id,
    string Name,
    string ParentId,
    string OwnerId,
    string[] Children
)
{
    public void ShowInformation()
    {
        Console.Clear();
        string childs = string.Join(", ", Children);
        string information =
            $"""
             name: {Name}
             id: {Id}
             owner id: {OwnerId}
             parent id: {ParentId}
             acess level: {AccessLevel}
             childrens: {(childs == "" ? "null" :childs)}
             """;
        
     Console.Write(information);   
    }
}

