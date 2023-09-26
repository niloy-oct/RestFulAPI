using RestFulAPI.Models;

namespace RestFulAPI.Repositories
{
    public static class ShirtRepository
    {

        public static List<Shirt> defaultShirts = new List<Shirt>
        {
            new Shirt
            {
                ShirtId = 1,
                Name = "Classic White Shirt",
                Color = "White",
                Size = 42,
                Gender = "men",
                Price = 29.99M
            },
            new Shirt
            {
                ShirtId = 2,
                Name = "Casual Blue Shirt",
                Color = "Blue",
                Size = 38,
                Gender = "women",
                Price = 24.99M
            },
            new Shirt
            {
                ShirtId = 3,
                Name = "Striped Polo Shirt",
                Color = "Red/White",
                Size = 40,
                Gender = "men",
                Price = 19.99M
            }
        };

        public static List<Shirt> GetShirts()
        {
            return defaultShirts;
        }

        public static bool IsShirtExist(int id)
        {
            return defaultShirts.Any(i => i.ShirtId == id);
        }


        public static Shirt? GetShirtById(int shirtId)
        {
            return defaultShirts.FirstOrDefault(i => i.ShirtId == shirtId);
        }


        public static Shirt? GetShirtByProperties(string? name, string? color, string? gender, int? size)
        {
            return defaultShirts.FirstOrDefault(x => !string.IsNullOrWhiteSpace(name) && !string.IsNullOrWhiteSpace(x.Name) && x.Name.Equals(name, StringComparison.OrdinalIgnoreCase) &&
            !string.IsNullOrWhiteSpace(color) && !string.IsNullOrWhiteSpace(x.Color) && x.Name.Equals(color, StringComparison.OrdinalIgnoreCase) &&
            !string.IsNullOrWhiteSpace(gender) && !string.IsNullOrWhiteSpace(x.Gender) && x.Name.Equals(gender, StringComparison.OrdinalIgnoreCase) &&
           size.HasValue && x.Size.HasValue && size.Value == x.Size.Value);
        }

        public static void AddShirt(Shirt shirt)
        {
            int maxId = defaultShirts.Max(x=>x.ShirtId);
            shirt.ShirtId = maxId + 1;
            defaultShirts.Add(shirt);
        }
    }
}
