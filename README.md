# 🚗 CarBook - Araç Kiralama & Yönetim Platformu

**CarBook**, modern kurumsal yazılım geliştirme pratikleri baz alınarak **Onion Architecture (Soğan Mimarisi)**, **CQRS** ve **MediatR** tasarım desenleri ile geliştirilmiş kapsamlı bir araç kiralama ve filo yönetim web uygulamasıdır. 

---

## 🏗️ Mimari Yapı ve Tasarım Desenleri

Proje, bağımlılıkları merkeze doğru izole eden ve sürdürülebilirliği artıran katmanlı bir yapıda inşa edilmiştir:

* **Onion Architecture:** İş kurallarını (Core) dış bağımlılıklardan (Veritabanı, UI, 3. Parti Servisler) tamamen soyutlar.
* **CQRS (Command Query Responsibility Segregation):** Okuma (Query) ve yazma (Command) operasyonlarını birbirinden ayırarak performans ve okunabilirlik sağlar.
* **MediatR Pattern:** Katmanlar ve nesneler arası gevşek bağlı (loosely coupled) iletişim kurar.
* **Repository Design Pattern:** Veri erişim mantığını soyutlar ve merkezi hale getirir.
* **DTO (Data Transfer Object) & AutoMapper:** Katmanlar arası güvenli ve hızlı veri taşımayı sağlar.

---

## 🛠️ Kullanılan Teknolojiler ve Kütüphaneler

### Backend (Web API)
* **.NET 8.0 / ASP.NET Core Web API**
* **Entity Framework Core** (Code First Yaklaşımı)
* **MS SQL Server** (İlişkisel Veritabanı Yönetimi)
* **MediatR** (CQRS Handler Yönetimi)
* **FluentValidation** (Sunucu Taraflı Doğrulama Kuralları)
* **JWT (JSON Web Token)** (Rol Bazlı Kimlik Doğrulama ve Yetkilendirme)
* **SignalR** (Anlık Bildirim ve Canlı İstatistik Güncellemeleri)
* **Swagger / OpenAPI** (API Dokümantasyonu ve Test Arayüzü)

### Frontend (Web UI)
* **ASP.NET Core MVC**
* **HttpClientFactory** (Asenkron API Tüketimi)
* **Bootstrap 5, HTML5, CSS3, JavaScript**
* **Chart.js** (Admin Dashboard Dinamik Grafikleri)

##  Proje İle İlgili Fotoğraflar
#
<img width="1917" height="1078" alt="Anasayfa1" src="https://github.com/user-attachments/assets/9f15d80d-fbb3-43e6-85b4-5c241a9f9c77" />
#
<img width="1917" height="1078" alt="Anasayfa2" src="https://github.com/user-attachments/assets/086c28a5-4757-496b-9063-f4dc6d977628" />
#
<img width="1917" height="1078" alt="Anasayfa3" src="https://github.com/user-attachments/assets/3317fa29-4f4b-4e3e-a5cf-72d1854ded4f" />
#
<img width="1917" height="1078" alt="Anasayfa4" src="https://github.com/user-attachments/assets/a6931456-ff7d-4b87-a0a0-c077b234ded9" />
#
<img width="1917" height="1078" alt="Anasayfa5" src="https://github.com/user-attachments/assets/b0ddeaf7-e53d-45b0-b071-ec00325c0459" />
#
<img width="1917" height="1078" alt="Anasayfa6" src="https://github.com/user-attachments/assets/ec904a61-2c49-48b2-af47-9c20ecd84206" />
#
<img width="1917" height="1078" alt="Anasayfa7" src="https://github.com/user-attachments/assets/e3ccae5e-8627-4d03-9764-ccbca3793212" />
#
<img width="1917" height="1078" alt="Anasayfa8" src="https://github.com/user-attachments/assets/afc65f36-541f-41f9-baf1-f59764e48345" />
#
<img width="1917" height="1078" alt="arabadetay1" src="https://github.com/user-attachments/assets/9e3742a4-61c3-4bd0-be5f-cf6f6228bacd" />
#
<img width="1917" height="1078" alt="arabadetay2" src="https://github.com/user-attachments/assets/08e27afc-90ab-4815-bbba-1e7dbb275117" />
#
<img width="1917" height="1078" alt="Arabafiyatlandırması" src="https://github.com/user-attachments/assets/d5268579-9cbb-42c4-abc4-402bb6825c5e" />
#
<img width="1917" height="1078" alt="Arabalarlistesi" src="https://github.com/user-attachments/assets/4ce9bc53-dfdf-4125-92db-c048fea0e840" />
#
<img width="1917" height="1078" alt="blogdetail" src="https://github.com/user-attachments/assets/6c0db92a-54d2-4a61-885d-ca647ed42f26" />
#
<img width="1917" height="1078" alt="blogdetail2" src="https://github.com/user-attachments/assets/8031fc57-2db8-4e17-bf6f-9cf056278ff9" />
#
<img width="1917" height="1078" alt="bloglar" src="https://github.com/user-attachments/assets/1584562f-5267-41c9-a0ef-b093e4dd1706" />
#
<img width="1917" height="1078" alt="Dashboard1" src="https://github.com/user-attachments/assets/c3e57d15-6423-4c6e-b033-4a99bd1a270e" />
#
<img width="1917" height="1078" alt="Dashboard2" src="https://github.com/user-attachments/assets/57aea2e7-cdd9-4408-a4fc-fff3bcaccd5e" />
#
<img width="1917" height="1078" alt="statistics" src="https://github.com/user-attachments/assets/96130f9c-cd57-4982-a1d3-908a60bc3307" />


