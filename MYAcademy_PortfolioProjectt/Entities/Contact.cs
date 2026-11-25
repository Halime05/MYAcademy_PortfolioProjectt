using Microsoft.AspNetCore.Components.Routing;

namespace MYAcademy_PortfolioProjectt.Entities
{
    public class Contact
    {
        public int ContactId { get; set; }
        public string Description { get; set; }
        public string Email { get; set; }
        public string Linkedn { get; set; }
        public string Location { get; set; }
        public string Github { get; set; }
        public string SubDescription { get; set; }
    }
}
// db frist -> hazır bir veri tabanı var. Ben oradan alıyorum verileri.
// code first -> her şeyi kendimiz sıfırdan yazıyoruz 