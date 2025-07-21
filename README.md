MyBlog – Katmanlı Mimari .NET Core Portföy/Blog Projesi
🚀 Modern, sürdürülebilir, katmanlı mimariyle hazırlanmış tam fonksiyonel bir portföy/blog uygulaması!
.NET 8, ASP.NET Core MVC, Entity Framework Core, SQLite, Bootstrap ve AutoMapper teknolojileriyle geliştirildi.

Tanıtım
MyBlog, kurumsal standartlara uygun, tamamen katmanlı mimariye sahip, portföy/blog yönetim platformudur.
Kullanıcılar ana sayfada projelerini ve profilini sergileyebilir, ziyaretçiler mesaj bırakabilir;
admin panelinden ise tüm projeleri ve gelen mesajları kolayca yönetebilirsiniz.

Kullanılan Teknolojiler
Backend:
.NET 8 (ASP.NET Core MVC & Web API), Entity Framework Core, SQLite, AutoMapper

Frontend:
HTML5, CSS3, JavaScript, Bootstrap 5.3, Font Awesome 6.4, Google Fonts (Montserrat)

Genel:
Katmanlı mimari (Entities, DTOs, DataAccess, Business, Presentation), Repository & Service desenleri, ViewModel, DTO ve Dependency Injection kullanımı

Klasör ve Dosya Yapısı
bash
Kopyala
Düzenle
MyBlog/
│
├── MyBlog.BusinessLayer/      # İş kuralları ve servisler
├── MyBlog.DataAccess/         # DbContext, Migration, Repository
├── MyBlog.DTOs/               # Data Transfer Object’ler
├── MyBlog.Entities/           # Entity/Model sınıfları (User, Project, Message)
│
├── MyBlog.PresentationLayer/  # MVC katmanı
│   ├── wwwroot/               # Statik dosyalar (css, js, images)
│   ├── Controllers/
│   ├── Models/
│   ├── Views/
│   │   ├── Admin/
│   │   ├── Home/
│   │   └── Shared/
│   └── appsettings.json
│
├── MyBlogDb.db                # SQLite veritabanı dosyası
└── README.md
Her katman kendi sorumluluğu ile yazılmıştır:

Entities: Veritabanı tabloları için saf C# POCO sınıfları (User, Project, Message).

DTOs: Katmanlar arası veya dış dünyaya aktarımda sade/güvenli veri objeleri.

DataAccess: AppDbContext (EF Core context ve ilişkiler), Repository ve interface'ler (CRUD işlemleri merkezi), Migration (veritabanı şeması).

BusinessLayer: Servisler, iş mantığı, validasyon ve özel query’ler.

PresentationLayer: MVC controller’ları, Razor View’lar (cshtml), statik dosyalar ve ViewModel’ler.

Katmanların Görevleri
Entities katmanı veritabanı ile birebir ilişkili modelleri içerir.
DTOs katmanı katmanlar arası veya dış dünyaya açılan veri objeleriyle veri taşımada güvenli bir yol sunar.
DataAccess katmanı veritabanı erişimi ve CRUD işlemlerini Repository deseniyle merkezi şekilde yönetir,
BusinessLayer ise uygulamanın iş kurallarını ve servislerini sağlar.
PresentationLayer ise MVC controller’larıyla backend’den gelen veriyi view’lara (arayüze) aktarır, modern ve responsive sayfaları oluşturur.

Kurulum ve Çalıştırma
Projeyi Klonla:
git clone <repo-linki>
cd MyBlog

NuGet Paketlerini Yükle:
Visual Studio'da sağ tık → "Restore NuGet Packages" veya
dotnet restore

Veritabanını Kur:
dotnet ef database update --project MyBlog.DataAccess --startup-project MyBlog.PresentationLayer
veya ilk migration için:
dotnet ef migrations add init --project MyBlog.DataAccess --startup-project MyBlog.PresentationLayer
dotnet ef database update --project MyBlog.DataAccess --startup-project MyBlog.PresentationLayer

Projeyi Başlat:
dotnet run --project MyBlog.PresentationLayer
veya Visual Studio’da PresentationLayer’ı startup olarak seçip çalıştır.

Uygulamayı Tarayıcıda Aç:
http://localhost:5000 veya launchsettings.json’daki porttan ulaş.

Özellikler
Tam katmanlı mimari

Admin paneli ile proje & mesaj yönetimi (CRUD)

Responsive, modern ve şık arayüz

Profil, projeler ve iletişim formu

DTO & AutoMapper ile güvenli veri transferi

Repository & Service pattern

SQLite ile kolay taşınabilir veritabanı

Ekran Görüntüleri
Projeyi çalıştırınca Home ve Admin bölümlerine ait örnek ekran görüntülerini buraya ekleyebilirsin.


(Daha fazla ekran görüntüsü için kendi görsellerini eklemeni öneririm.)

Katkı & Lisans
Bu proje MIT lisansı ile açık kaynak olarak sunulmaktadır.
Katkıda bulunmak, hata bildirmek veya geliştirme yapmak isterseniz Pull Request veya Issue açabilirsiniz.

Keyifli kodlamalar!
Sorularınız için iletişime geçmekten çekinmeyin.

