namespace practic_8;

public class Printer
{
    public static void ShowSeadBoxInfo(SeadoxInfo subclass)
    {
        Console.Write("*\n");
        foreach (var property in subclass.GetType().GetProperties())
        {
            Console.Write($"\t{property.Name}: {property.GetValue(subclass)} \n");
        }
        Console.Write("\n");
    }
    
    public static void ShowInfo<T>(T obj)
    {
        foreach (var property in obj.GetType().GetProperties())
        {
            
            if (property.GetValue(obj) is var value && value.GetType().IsArray)
            {
                Console.Write($"{property.Name}: {value.GetType()} \n");
                
                
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

            else
            {
                Console.Write($"{property.Name}: {(value is ""?"null":value)} \n");
            }
            
        }
    }
}