namespace ScoopAndServe2.Models // Organizes this class inside the Models namespace.
{
    public class ErrorViewModel // Defines a class that holds information for an error page.
    {
        // Stores a request identifier. The '?' means this string can be null.
        public string? RequestId { get; set; }

        // Returns true if RequestId contains a non-empty string.
        // The '!' reverses the result of IsNullOrEmpty.
        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}