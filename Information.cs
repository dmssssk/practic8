namespace practic_8;

public record Information(
    string accessLevel,
    string id,
    string name,
    string parentId,
    string ownerId,
    string[] children
)
{
    public void ShowInformation()
    {
        string childs = string.Join(", ", children);
        string information =
            $"""
             name: {name}
             id: {id}
             owner id: {ownerId}
             parent id: {parentId}
             acess level: {accessLevel}
             acess level: {accessLevel}
             childrens: {(childs == "" ? "null" :childs)}
             """;
        
     Console.Write(information);   
    }
}

