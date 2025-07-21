MyBlog � Katmanl� Mimari .NET Core Projesi
��indekiler
Tan�t�m

Kullan�lan Teknolojiler

Klas�r ve Dosya Yap�s�

Katmanlar�n G�revleri

Kurulum ve �al��t�rma

�zellikler

Notlar & Ekstra Bilgiler

Ekran G�r�nt�s�

Tan�t�m
Bu proje, modern bir blog/portf�y sistemi geli�tirmek i�in haz�rlanm��,
.NET 8, Entity Framework Core ve katmanl� mimari standartlar�n� kullanan bir full-stack web uygulamas�d�r.
Kendi portf�y�n� veya blogunu modern, s�rd�r�lebilir ve geli�tirilebilir bir yap�da bar�nd�rmak isteyenler i�in tasarlanm��t�r.

Kullan�lan Teknolojiler
Backend:

.NET 8 (ASP.NET Core MVC & Web API)

Entity Framework Core (EF Core)

SQLite (hafif dosya tabanl� veritaban�)

AutoMapper (DTO mapping)

Katmanl� mimari (BLL, DAL, Entities, DTOs)

Frontend:

HTML5, CSS3, JavaScript (MVC View�lar�nda Razor kullan�ld�)

Bootstrap 5.3

Font Awesome 6.4

Modern responsive ve dinamik aray�zler

Google Fonts (Montserrat, Poppins vb.)

Genel:

Katmanl� mimari

DI (Dependency Injection)

DTO ve ViewModel kullan�m�

Swagger/OpenAPI (iste�e ba�l�, test ama�l�)

Klas�r ve Dosya Yap�s�
A�a��daki g�rsel, projenin tam dosya yap�s�n� g�stermektedir:


�zet:

MyBlog.BusinessLayer � �� kurallar� ve servisler

MyBlog.DataAccess � DbContext, Migrations, Repository ve DB eri�im katman�

MyBlog.DTOs � Data Transfer Object�leri (DTO�lar)

MyBlog.Entities � Veritaban� modelleri (entity s�n�flar�)

MyBlog.PresentationLayer

wwwroot � Statik dosyalar (CSS, JS, g�rseller)

Controllers � MVC controller�lar�

Views � Razor view dosyalar� (Admin, Home, Shared)

Models � ViewModel�ler (�zellikle AdminPanelViewModel vb.)

Katmanlar�n G�revleri
Entities:
Veritaban� tablolar�n� temsil eden POCO s�n�flar (User, Project, Message).

DTOs:
Katmanlar aras� veri transferini sadele�tirir, d��ar�ya a��lan verileri filtreler (�r: UserDto, ProjectDto).

DataAccess:

AppDbContext ile DB ba�lant�s�

Migration ve veritaban� y�netimi

Repository desenleri (generic ve entity bazl�)

BusinessLayer:
Uygulaman�n i� mant���n�, servislerini ve kurallar�n� bar�nd�r�r.
�rne�in: Proje ekleme, mesaj g�nderme, �zel sorgular vs.

PresentationLayer:
Kullan�c� aray�z� (Views) ve uygulaman�n MVC k�sm�.
Controllers i� kurallar�yla ileti�ime ge�er ve sonu�lar� View�lara yollar.

Kurulum ve �al��t�rma
Projeyi Kopyala/Klonla

bash
Kopyala
D�zenle
git clone <repo-linki>
cd MyBlog
Gerekli NuGet Paketlerini Y�kle

EntityFrameworkCore (Sqlite, Tools, Design)

AutoMapper.Extensions.Microsoft.DependencyInjection

Di�er ba��ml�l�klar

Veritaban�n� Haz�rla

�lk kez �al��t�r�yorsan:

pgsql
Kopyala
D�zenle
dotnet ef database update
veya

pgsql
Kopyala
D�zenle
Add-Migration init
Update-Database
Veritaban� olarak MyBlogDb.db dosyas� projenin k�k�nde olu�acak.

Uygulamay� Ba�lat

arduino
Kopyala
D�zenle
dotnet run --project MyBlog.PresentationLayer
veya Visual Studio ile PresentationLayer�� �startup project� se�ip F5�e bas.

Taray�c�da A�

http://localhost:5000 veya launchsettings.json�daki porttan ula�.

�zellikler
Katmanl� mimariye tam uygun yap�

Admin panelinden projeleri ve gelen mesajlar� y�netme

Ana sayfada portf�y/proje g�sterimi, ziyaret�i mesaj� b�rakma

Responsive modern UI ve ikonlar

Kolay �zelle�tirilebilir altyap�

Veritaban� i�lemlerinde repository ve servis desenleri

DTO ile veri g�venli�i

Geli�tiriciye y�nelik sade kod yap�s�

Notlar & Ekstra Bilgiler
Veritaban� de�i�ikli�i:
Yeni tablo/alan ekledik�e migration i�lemlerini tekrarlamal�s�n (add-migration ve update-database).

Statik dosyalar:
CSS/JS ve resimleri wwwroot alt�na ekleyebilirsin.

Ba�lang��ta hata al�rsan:

Projeyi rebuild et

Ba��ml�l�klar� kontrol et

Migrations veya DB dosyas�n� silip ba�tan migration olu�turabilirsin

Giri�/auth �zelli�i:
Varsay�lan olarak basit bir mesaj ve admin y�netimi var, dilersen Identity veya JWT tabanl� login-flow ekleyebilirsin.

Ekran G�r�nt�s�
Projenin g�ncel ekran g�r�nt�s�n� ve/veya dosya yap�s� g�rselini buraya ekleyebilirsin:


Sorun ya�arsan veya katk�da bulunmak istersen
Pull Request ve Issue a�abilirsin.
Keyifli kodlamalar!