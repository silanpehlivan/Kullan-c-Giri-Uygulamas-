<div align="center">

# Kullanıcı Giriş Uygulaması

### Masaüstü giriş akışını adım adım keşfet.

![C#](https://img.shields.io/badge/C%23-2563eb?style=for-the-badge)
![Windows Forms](https://img.shields.io/badge/Windows%20Forms-0891b2?style=for-the-badge)
[![MIT](https://img.shields.io/badge/MIT-16a34a?style=for-the-badge)](LICENSE)

Kullanıcı doğrulaması, hata bildirimleri ve formlar arası geçişi simüle eden eğitim amaçlı masaüstü uygulaması.

**Kimlik doğrulama akışına giriş**

[Projeyi keşfet](https://github.com/silanpehlivan/Kullan-c-Giri-Uygulamas-/tree/master) · [Kurulum ve ayrıntılar](#projeyi-çalıştırmak-ve-incelemek)

</div>

---

## İçeride neler var?

- **01** · Kullanıcı bilgileriyle giriş etkileşimi
- **02** · Formlar arasında geçiş
- **03** · Sınıf tabanlı kontrol akışı

## Projeyi çalıştırmak ve incelemek

<details>
<summary><strong>Kurulum, kod yapısı ve teknik notları aç</strong></summary>

## Öne Çıkanlar

- Kullanıcı adı ve parola kontrolü
- Başarılı giriş sonrası form yönlendirmesi
- Sınıf tabanlı iş mantığı ve veri aktarımı

## Teknolojiler

C# · Windows Forms

### Teknik yaklaşım

Formdan alınan değerler çalışan sınıfındaki kontrol akışına aktarılır; formlar arası geçişle masaüstü etkileşimi gösterilir.

### Kodu incelemeye başlayın

- [Form1.cs](Form1.cs)
- [Program.cs](Program.cs)
- [Form2.cs](Form2.cs)
- [Form3.cs](Form3.cs)

### Kapsam ve sınırlar

Eğitim simülasyonudur. Parola yönetimi, oturum güvenliği ve yetkilendirme için üretim düzeyinde doğrulama sunulduğu varsayılmamalıdır.



Bu proje, kullanıcı giriş işlemlerini, kimlik doğrulama süreçlerini ve form yönetimini simüle etmek amacıyla **C#** ve **Windows Forms (WinForms)** teknolojileri kullanılarak geliştirilmiş bir masaüstü uygulamasıdır.

Proje, temel kullanıcı doğrulama mantığını ve Nesne Yönelimli Programlama (OOP) yapısını öğretmeyi amaçlamaktadır.

---

## Proje Hakkında

Uygulama, kullanıcı adı ve şifre bilgilerini kontrol ederek kullanıcı doğrulaması yapmaktadır. Sistem, başarılı giriş işlemlerinden sonra kullanıcıyı farklı formlara yönlendirir ve temel yetkilendirme mantığını simüle eder.

Projede:

- Çoklu form yönetimi
- Kullanıcı doğrulama işlemleri
- Sınıf tabanlı yapı
- Formlar arası veri aktarımı
- Dinamik hata mesajları

gibi temel masaüstü uygulama geliştirme teknikleri kullanılmıştır.

---

## Teknik Detaylar

| Özellik | Açıklama |
|---|---|
| Dil | C# |
| Platform | .NET Framework |
| Arayüz Teknolojisi | Windows Forms (WinForms) |
| IDE | Visual Studio 2022 |
| Mimari | Nesne Yönelimli Programlama (OOP) |

---

## Kullanılan Teknolojiler

- C#
- WinForms
- OOP (Object Oriented Programming)
- Class Yapıları
- Form Yönetimi
- Event Driven Programming

---

## Temel Özellikler

## Kullanıcı Giriş Sistemi
- Kullanıcı adı doğrulama
- Şifre kontrol sistemi
- Hatalı giriş uyarıları

## Çoklu Form Yönetimi
- Formlar arası geçiş
- Veri taşıma işlemleri
- Dinamik ekran yönetimi

## Sınıf Tabanlı Yapı
- Kullanıcı kontrol mekanizması
- İş mantığının sınıflarda yönetilmesi
- Kod organizasyonu

## Hata Yönetimi
- Yanlış giriş uyarıları
- Kullanıcı bilgilendirme mesajları
- Güvenli kontrol mekanizması

---

## Kurulum ve Çalıştırma

## 1. Projeyi İndirin

```bash
git clone https://github.com/silanpehlivan/Kullan-c-Giri-Uygulamas-.git
```

veya ZIP olarak indirip çıkarın.

---

## 2. Visual Studio ile Açın

`.sln` uzantılı çözüm dosyasını Visual Studio üzerinden açın.

---

## 3. Projeyi Çalıştırın

Visual Studio içerisinde:

```bash
F5
```

tuşuna basarak projeyi çalıştırabilirsiniz.

---

## Proje Yapısı

```bash
KullaniciGirisUygulamasi/
│
├── Form1.cs
├── Form2.cs
├── Form3.cs
├── Program.cs
├── Sınıflar/
│   └── Calısanlar.cs
├── KullaniciGirisUygulamasi.csproj
├── KullaniciGirisUygulamasi.sln
└── README.md
```

| Dosya | Açıklama |
|---|---|
| `Form1.cs` | Kullanıcı giriş ekranı |
| `Form2.cs` | Kullanıcı doğrulama ekranı |
| `Form3.cs` | Başarılı giriş sonrası ekran |
| `Program.cs` | Uygulama başlangıç noktası |
| `Calısanlar.cs` | Kullanıcı kontrol işlemleri |
| `.csproj` | Proje yapılandırma dosyası |
| `.sln` | Visual Studio çözüm dosyası |

---

## Projenin Amacı

Bu proje sayesinde:

- WinForms uygulama geliştirme mantığı öğrenilir.
- Formlar arası veri aktarımı uygulanır.
- Kullanıcı giriş sistemleri geliştirilir.
- OOP prensipleri pratiğe dökülür.
- Masaüstü uygulama geliştirme deneyimi kazanılır.

---




</details>

---

<div align="center">

**© 2024 Şilan PEHLİVAN**

Bu proje MIT lisansı kapsamında sunulmaktadır. Kullanım ve dağıtım koşulları: [LICENSE](LICENSE).

</div>
