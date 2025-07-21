MyBlog – Katmanlý Mimari .NET Core Projesi
Ýçindekiler
Tanýtým

Kullanýlan Teknolojiler

Klasör ve Dosya Yapýsý

Katmanlarýn Görevleri

Kurulum ve Çalýþtýrma

Özellikler

Notlar & Ekstra Bilgiler

Ekran Görüntüsü

Tanýtým
Bu proje, modern bir blog/portföy sistemi geliþtirmek için hazýrlanmýþ,
.NET 8, Entity Framework Core ve katmanlý mimari standartlarýný kullanan bir full-stack web uygulamasýdýr.
Kendi portföyünü veya blogunu modern, sürdürülebilir ve geliþtirilebilir bir yapýda barýndýrmak isteyenler için tasarlanmýþtýr.

Kullanýlan Teknolojiler
Backend:

.NET 8 (ASP.NET Core MVC & Web API)

Entity Framework Core (EF Core)

SQLite (hafif dosya tabanlý veritabaný)

AutoMapper (DTO mapping)

Katmanlý mimari (BLL, DAL, Entities, DTOs)

Frontend:

HTML5, CSS3, JavaScript (MVC View’larýnda Razor kullanýldý)

Bootstrap 5.3

Font Awesome 6.4

Modern responsive ve dinamik arayüzler

Google Fonts (Montserrat, Poppins vb.)

Genel:

Katmanlý mimari

DI (Dependency Injection)

DTO ve ViewModel kullanýmý

Swagger/OpenAPI (isteðe baðlý, test amaçlý)

Klasör ve Dosya Yapýsý
Aþaðýdaki görsel, projenin tam dosya yapýsýný göstermektedir:


Özet:

MyBlog.BusinessLayer – Ýþ kurallarý ve servisler

MyBlog.DataAccess – DbContext, Migrations, Repository ve DB eriþim katmaný

MyBlog.DTOs – Data Transfer Object’leri (DTO’lar)

MyBlog.Entities – Veritabaný modelleri (entity sýnýflarý)

MyBlog.PresentationLayer

wwwroot – Statik dosyalar (CSS, JS, görseller)

Controllers – MVC controller’larý

Views – Razor view dosyalarý (Admin, Home, Shared)

Models – ViewModel’ler (özellikle AdminPanelViewModel vb.)

Katmanlarýn Görevleri
Entities:
Veritabaný tablolarýný temsil eden POCO sýnýflar (User, Project, Message).

DTOs:
Katmanlar arasý veri transferini sadeleþtirir, dýþarýya açýlan verileri filtreler (ör: UserDto, ProjectDto).

DataAccess:

AppDbContext ile DB baðlantýsý

Migration ve veritabaný yönetimi

Repository desenleri (generic ve entity bazlý)

BusinessLayer:
Uygulamanýn iþ mantýðýný, servislerini ve kurallarýný barýndýrýr.
Örneðin: Proje ekleme, mesaj gönderme, özel sorgular vs.

PresentationLayer:
Kullanýcý arayüzü (Views) ve uygulamanýn MVC kýsmý.
Controllers iþ kurallarýyla iletiþime geçer ve sonuçlarý View’lara yollar.

Kurulum ve Çalýþtýrma
Projeyi Kopyala/Klonla

bash
Kopyala
Düzenle
git clone <repo-linki>
cd MyBlog
Gerekli NuGet Paketlerini Yükle

EntityFrameworkCore (Sqlite, Tools, Design)

AutoMapper.Extensions.Microsoft.DependencyInjection

Diðer baðýmlýlýklar

Veritabanýný Hazýrla

Ýlk kez çalýþtýrýyorsan:

pgsql
Kopyala
Düzenle
dotnet ef database update
veya

pgsql
Kopyala
Düzenle
Add-Migration init
Update-Database
Veritabaný olarak MyBlogDb.db dosyasý projenin kökünde oluþacak.

Uygulamayý Baþlat

arduino
Kopyala
Düzenle
dotnet run --project MyBlog.PresentationLayer
veya Visual Studio ile PresentationLayer’ý “startup project” seçip F5’e bas.

Tarayýcýda Aç

http://localhost:5000 veya launchsettings.json’daki porttan ulaþ.

Özellikler
Katmanlý mimariye tam uygun yapý

Admin panelinden projeleri ve gelen mesajlarý yönetme

Ana sayfada portföy/proje gösterimi, ziyaretçi mesajý býrakma

Responsive modern UI ve ikonlar

Kolay özelleþtirilebilir altyapý

Veritabaný iþlemlerinde repository ve servis desenleri

DTO ile veri güvenliði

Geliþtiriciye yönelik sade kod yapýsý

Notlar & Ekstra Bilgiler
Veritabaný deðiþikliði:
Yeni tablo/alan ekledikçe migration iþlemlerini tekrarlamalýsýn (add-migration ve update-database).

Statik dosyalar:
CSS/JS ve resimleri wwwroot altýna ekleyebilirsin.

Baþlangýçta hata alýrsan:

Projeyi rebuild et

Baðýmlýlýklarý kontrol et

Migrations veya DB dosyasýný silip baþtan migration oluþturabilirsin

Giriþ/auth özelliði:
Varsayýlan olarak basit bir mesaj ve admin yönetimi var, dilersen Identity veya JWT tabanlý login-flow ekleyebilirsin.

Ekran Görüntüsü
Projenin güncel ekran görüntüsünü ve/veya dosya yapýsý görselini buraya ekleyebilirsin:


Sorun yaþarsan veya katkýda bulunmak istersen
Pull Request ve Issue açabilirsin.
Keyifli kodlamalar!