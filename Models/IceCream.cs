namespace ScoopAndServe2.Models
{
    public class IceCream
    {
        public int Id { get; set; } // Unique identifier for the ice cream entry.
        public string Name { get; set; } = string.Empty;// Name of the ice cream flavor.
        public decimal Price { get; set; } = 0m; // Price of each icecream serving.
        public string Category { get; set; } = string.Empty; // Category of the ice cream (e.g., "Cone", "Cup", "Sundae").
        public bool IsAvailable { get; set; } // Availability status of the ice cream (true if available, false otherwise).
    }
}
