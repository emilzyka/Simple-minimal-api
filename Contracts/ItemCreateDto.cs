using MinimalAPI.Models;

namespace MinimalAPI.Contracts
{
    public class ItemCreateDto
    {
        public string? Title { get; set; }

        public string? Description { get; set; }

        public string? Developer { get; set; }

        public string? Publisher { get; set; }

        public string? Platform { get; set; }

        public string? Genre { get; set; }

        public string? Mode { get; set; }

        public string? Release { get; set; }
    }
}
