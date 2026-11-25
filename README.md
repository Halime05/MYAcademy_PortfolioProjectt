# MYAcademy_PortfolioProjectt

Bu depo, ASP.NET Core MVC ve Entity Framework Core (Code First) kullanılarak geliştirilen kişisel portfolyo web projesinin **1. Ders** adımlarını içermektedir.

## 1. Ders Kapsamında Yapılan Adımlar

* **Proje Altyapısı ve Mimari Kurulumu:** ASP.NET Core MVC projesi oluşturuldu; `Context`, `Entities`, `Controllers`, `Views` ve `ViewComponents` klasör hiyerarşisi yapılandırıldı.
* **Veritabanı ve Entity Tasarımı:** `About`, `Contact`, `Education`, `Experience`, `HeroSection` ve `Message` varlık (entity) sınıfları oluşturuldu.
* **Entity Framework Core & Migration:** `PortfolioContext` sınıfı yapılandırılarak MS SQL Server (`PortfolioDbNight`) bağlantısı sağlandı. İlk migration işlemleri (`mig1`, `mig2`) uygulanarak veritabanı tabloları oluşturuldu.
* **Controller ve View Yapılandırması:** Ana sayfa yönlendirmeleri için `DefaultController` ve `Views/Default/Index.cshtml` yapısı oluşturuldu.
* **ViewComponent Altyapısı:** Ana sayfa bileşenlerini (Hakkımda, Eğitim, Deneyim, Hero Alanı ve Stil dosyaları) modüler olarak yönetmek amacıyla `DefaultViewComponents` sınıfları tanımlandı.
