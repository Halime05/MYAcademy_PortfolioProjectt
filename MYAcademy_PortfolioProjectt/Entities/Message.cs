namespace MYAcademy_PortfolioProjectt.Entities
{
    public class Message
    {
        public int MessageId { get; set; } // id'ler her zaman int olmalı mmı?
        // hayır, guid olarak da yazılabilir.attribute olarak geçiyor.
        public string NameSurname { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }
        public string MessageDetail { get; set; }
        public DateTime SendDate { get; set; }
        public bool IsRead { get; set; }
    }
}
