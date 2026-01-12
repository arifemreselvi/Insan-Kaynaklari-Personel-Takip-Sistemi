# 🏢 Human Resources (Personel Takip) Sistemi

Bu proje, bir işletmedeki tüm kaosu profesyonelliğe dönüştüren, C# WinForms ve MySQL tabanlı bir yönetim sistemidir 🚀.

## 🌟 Proje Özeti
İnsan kaynakları süreçlerini dijitalleştirip her şeyi raporlanabilir hale getiren bu uygulama, kolaylık sağlayan bir kurumsal çözüm sunuyor 💼. 

## 🛠️ Kullanulan Teknikler
* **Dil:** C# (WinForms) - klasik ama etkili 💻.
* **Veritabanı:** MySQL / phpMyAdmin - Data akışı çok smooth 📊.
* **Mimari:** N-Tier Architecture (DAL, BLL, UI) - Sorumluluklar tam yerinde 🏗️.

## 🏗️ Proje Yapısı (N-Katmanlı)
1.  **DAL (Veri Erişim Katmanı):** MySQL ile bağlantıyı bu katman hallediyor 🔗.
2.  **BLL (İş Katmanı):** "Yıllık izin 14 günü geçemez" gibi kurallar burada dönüyor 🧠.
3.  **UI (Sunum Katmanı):** Kullanıcının gördüğü o yakışıklı ekranlar burada 🖥️.

## 👥 Kullanıcı Rolleri
* **Admin:** Her şeyi gören, sistemin yöneticisi olan rol 👑.
* **İK Personeli:** Personel ekleyen, izinleri yöneten profesyonel ekip 📋.
* **Normal Kullanıcı:** Sadece kendi iznine bakan masum eleman 👤.

---

## 📸 Görseller (Diagramlar & UI)

### 📊 Veritabanı ve Mantık

#### ER Diyagramı
![ER Diyagramı](https://raw.githubusercontent.com/arifemreselvi/Insan-Kaynaklari-Personel-Takip-Sistemi/0ee6a2dad248a0b7a8c354b0223f57895eaf139d/Personel/g%C3%B6rseller/ER%20diyagramu.png)

#### Class Diyagramı
![Class Diyagramı](https://raw.githubusercontent.com/arifemreselvi/Insan-Kaynaklari-Personel-Takip-Sistemi/0ee6a2dad248a0b7a8c354b0223f57895eaf139d/Personel/g%C3%B6rseller/class%20diyagramu.png)

#### Use-Case Diyagramı
![Use-Case](https://raw.githubusercontent.com/arifemreselvi/Insan-Kaynaklari-Personel-Takip-Sistemi/0ee6a2dad248a0b7a8c354b0223f57895eaf139d/Personel/g%C3%B6rseller/use-case%20diyagramu.png)

### 🖼️ Uygulama Ekranları

#### Giriş Ekranı
![Login](https://raw.githubusercontent.com/arifemreselvi/Insan-Kaynaklari-Personel-Takip-Sistemi/0ee6a2dad248a0b7a8c354b0223f57895eaf139d/Personel/g%C3%B6rseller/giri%C5%9F%20men%C3%BC.png)

#### Ana Menü
![Ana Menü](https://raw.githubusercontent.com/arifemreselvi/Insan-Kaynaklari-Personel-Takip-Sistemi/0ee6a2dad248a0b7a8c354b0223f57895eaf139d/Personel/g%C3%B6rseller/ana%20men%C3%BC.png)

#### Kod Düzeni
![Kod Düzeni](https://raw.githubusercontent.com/arifemreselvi/Insan-Kaynaklari-Personel-Takip-Sistemi/0ee6a2dad248a0b7a8c354b0223f57895eaf139d/Personel/g%C3%B6rseller/kod%20d%C3%BCzeni.png)

---

## 💎 Uygulanan OOP İlkeleri
* **Kalıtım (Inheritance):** `BaseEntity` sayesinde ortak alanlar her yerde 🧬.
* **Encapsulation:** Property kullanımıyla veriler güvende 🛡️.
* **Polymorphism:** Raporlama servislerinde farklı filtrelerin uygulanması 🌈.
* **Interface:** `IRepository` gibi yapılarla kod esnek tutuldu 🔗.

## 🚀 Kurulum
1. Veritabanı tablolarını phpMyAdmin üzerinden import et 📥.
2. `DAL` katmanındaki connection string ayarlarını kendi localine göre güncelle ⚙️.
3. Build al ve sistemin tadını çıkar ☕.

---

## 📺 Video Rehber
#### Proje Tanıtım ve Kullanım Rehberi
[![Proje Rehberi](https://img.youtube.com/vi/iQaygWBDKAw/0.jpg)](https://www.youtube.com/watch?v=iQaygWBDKAw)
Sistemin nasıl lowkey aktığını izlemek için görsele veya [buraya](https://www.youtube.com/watch?v=iQaygWBDKAw) tıkla 🎥.

---
