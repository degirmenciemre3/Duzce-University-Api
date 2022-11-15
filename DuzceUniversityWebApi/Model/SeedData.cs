using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace DuzceUniversityWebApi.Model
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            DatabaseContext context = app.ApplicationServices
                .CreateScope().ServiceProvider.GetRequiredService<DatabaseContext>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }
            DateTime DateNow = DateTime.Now;

            if (!context.duyurulars.Any())
            {
                context.duyurulars.AddRange(
                    new Duyuru
                    {
                        Id = 1,
                        Tarih = DateNow,
                        Baslik = "Günümüzde Gençlik Sempozyumu",
                        KisaAciklama = "Üniversitemizde düzenlenecek gençlik sempozyumuna sizlerde davetlisiniz",
                        Aciklama = "Üniversitemizde düzenlenecek gençlik sempozyumuna sizlerde davetlisiniz",
                        Image = "/images/DuyuruResimleri/GunumuzdeGenclikSempozyomu.jpg"
                    },
                    new Duyuru
                    {
                        Id = 2,
                        Tarih = DateNow,
                        Baslik = "Cumhuriyetimizin 99. Yılına Özel Sergi Ziyaretçilerin Beğenisine Sunuluyor",
                        KisaAciklama = "Üniversitemiz Sanat Tasarım ve Mimarlık Fakültesi’nin Cumhuriyetimizin kuruluşunun 99’uncu yılına özel “Cumhuriyet: Geçmişten Günümüze İzler” başlıklı sergi ziyaretçilerin beğenisine sunuldu.\r\n\r\n",
                        Aciklama = "Üniversitemiz Sanat Tasarım ve Mimarlık Fakültesi’nin Cumhuriyetimizin kuruluşunun 99’uncu yılına özel “Cumhuriyet: Geçmişten Günümüze İzler” başlıklı sergi ziyaretçilerin beğenisine sunuldu.\r\n\r\nÜniversitemiz Sanat, Tasarım ve Mimarlık Fakültesi 5. Kat Mihri Müşfik Sanat Galerisi ve Müfide Kadri Sanat Galerisi’nde, isteyen herkesin ücretsiz bir şekilde ziyaret edebileceği sergi; Rektör yardımcımız Prof. Dr. İlhan Genç, Sanat, Tasarım ve Mimarlık Fakültesi Dekanı E. Yıldız Doyran, Ziraat Fakültesi Dekanı Prof. Dr. Sevcan Öztemiz, davetli misafirler, öğretim elemanlarımız ve öğrencilerimizin katılımı ile açıldı.\r\n\r\n12 Kasım tarihine kadar ziyaretçilere açık olan sergide; öğretim elemanlarımızın meydana getirdiği eserler içerisinde; Kars’ta bulunan Ani Harabeleri, eski dokuma örnekleri, savaşçı motifleri, metal ahşap işlemeleri, ebru sanatı gibi bir birinden değerli çalışmalar yer alıyor. Fiziki olarak ziyaret edebileceğiniz sergiyi aynı zamanda https://sanalsergi.duzce.edu.tr/ internet adresinden de inceleyebilirsiniz.",
                        Image = "/images/DuyuruResimleri/cumhuriyetimizin99yili.jpg"
                    },
                    new Duyuru
                    {
                        Id = 3,
                        Tarih = DateNow,
                        Baslik = "Hasta Hakları Günü’nde Hastalara Ziyaret",
                        KisaAciklama = "Üniversitemiz Hastanesi’nde “26 Ekim Hasta Hakları Günü” dolayısıyla 'hasta hakları ve sorumlulukları' ile ilgili bilgilendirme yapılarak farkındalık oluşturuldu.",
                        Aciklama = "Üniversitemiz Hastanesi’nde “26 Ekim Hasta Hakları Günü” dolayısıyla \"hasta hakları ve sorumlulukları\" ile ilgili bilgilendirme yapılarak farkındalık oluşturuldu.\r\n\r\nSağlık hizmetlerinin kalitesinin artırılması amacıyla hizmet veren Üniversitemiz Hasta Hakları Birimi, hasta hakları ihlalleri ve bunlara bağlı ortaya çıkan sorunları çözerek kişilere erişilebilir ve verimli sağlık hizmeti sunuyor.\r\n\r\n“26 Ekim Hasta Hakları Günü” dolayısıyla hasta hakları ve sorumlulukları konusunda farkındalık oluşturmak amacıyla Başhekim Yardımcısı Dr. Öğr. Üyesi Fatih Davran, Hastane Başmüdürü Fatma Şahin, Hastane Müdürü Muhammet Çelik, Hastane Müdür Yardımcısı Kadriye Şengül, Başhemşire Yardımcıları Hacer Ak Ergün, İlknur Kuzyaka ve Hasta Hakları Birim Sorumlusu Şef Selvihan Ekici, Hastanemizde yatan ve ayaktan sağlık hizmeti alan hasta ve hasta yakınlarına, \"hasta hakları ve sorumlulukları\" ile ilgili bilgilendirme gerçekleştirdi.\r\n\r\nHastalara geçmiş olsun dileklerini iletilerek Hasta Hakları Yönetmeliği’nin ilgili maddeleri doğrultusunda hazırlanan bilgilendirme broşürleri dağıtıldı.  Hasta ve hasta yakınlarına sağlık hizmetlerinden faydalanma, seçme, bilgi alma, mahremiyet, güvenlik, şikayet gibi hakları ve hastane kurallarına uyma, tedavisi ile ilgili önerilere uyma, sosyal güvenlik gibi sorumlulukları anlatıldı.  Hasta ve hasta yakınları ise yapılan ziyaret ve çalışmalardan dolayı memnuniyetlerini belirterek teşekkür etti.",
                        Image = "/images/DuyuruResimleri/hastahaklarigunu.jpg"
                    },
                    new Duyuru
                    {
                        Id = 4,
                        Tarih = DateNow,
                        Baslik = "Günümüzde Gençlik Sempozyumu",
                        KisaAciklama = "Üniversitemizde düzenlenecek gençlik sempozyumuna sizlerde davetlisiniz",
                        Aciklama = "Üniversitemizde düzenlenecek gençlik sempozyumuna sizlerde davetlisiniz",
                        Image = "/images/DuyuruResimleri/GunumuzdeGenclikSempozyomu.jpg"
                    },
                    new Duyuru
                    {   Id = 5,    
                        Tarih = DateNow,
                        Baslik = "Artvin Çoruh Üniversitesi’nden Üniversitemize İhtisaslaşma Alanında Tecrübe ve İş Birliği Ziyareti",
                        KisaAciklama = "Artvin Çoruh Üniversitesi, \"Üniversitelerimizin Bölgesel Kalkınma Odaklı Misyon Farklılaşması ve İhtisaslaşması\" programı kapsamında, ihtisaslaşma alanı olan tıbbi ve aromatik bitkiler alanında tecrübe ve iş birliği çalışmaları için Üniversitemizi ziyaret etti.",
                        Aciklama = "Artvin Çoruh Üniversitesi, \"Üniversitelerimizin Bölgesel Kalkınma Odaklı Misyon Farklılaşması ve İhtisaslaşması\" programı kapsamında, ihtisaslaşma alanı olan tıbbi ve aromatik bitkiler alanında tecrübe ve iş birliği çalışmaları için Üniversitemizi ziyaret etti.\r\n\r\nArtvin Çoruh Üniversitesi Tıbbi Aromatik Bitkiler Koordinatörlüğü akademisyenlerinden oluşan heyet, ilk olarak Rektörümüz Prof. Dr. Nedim Sözbir’i ziyaret etti. Ziyarette, bölgesel kalkınma, bilimsel araştırma ve ortak projeler başta olmak üzere birçok konu hakkında fikir alışverişinde bulunuldu.\r\n\r\nDaha sonra Rektör Danışmanımız Doç. Dr. Cengiz Tuncer eşliğinde, Üniversitemiz Arıcılık Araştırma Geliştirme ve Uygulama Merkezi (DAGEM)Müdürü Doç. Dr. Meral Kekeçoğlu’nun, DAGEM’in faaliyetleriyle ilgili sunumuna katılan konuk heyet, Üniversitemiz Bilimsel ve Teknolojik Araştırmalar Uygulama ve Araştırma Merkezi (DÜBİT) ziyaretiyle programlarına devam etti. DÜBİT Müdürü Doç. Dr. Uğur Hasırcı ve DÜBİT yetkilileri tarafından Merkezimizin nitelikli test ve analiz hizmetleri hakkında bilgilendirilen Artvin Çoruh Üniversitesi akademisyenleri, sonrasında Üniversitemiz Geleneksel ve Tamamlayıcı Tıp Merkezi’ni ziyaret etti. Ziyarette, Merkez Müdürü Prof. Dr. Ertuğrul Kaya, Türkiye’nin en büyük Geleneksel ve Tamamlayıcı Tıp Merkezi’nde alanında özel eğitim almış, akademisyen olan sertifikalı uzman hekimler tarafından akupunktur, hirudoterapi, kupa uygulaması, ozon tedavisi gibi birçok uygulamanın gerçekleştirildiğini ifade etti. Sağlık Bakanlığı tarafından ruhsatlandırılmış bir klinik araştırma merkezi olduklarını belirten Prof. Dr. Ertuğrul Kaya, Ar-Ge çalışmalarının yürütüldüğünü, bu alanda kendini geliştirmek isteyen eğitimciler için sertifika programlarının da düzenlendiğini sözlerine ekledi.\r\n\r\nSon olarak Üniversitemiz Tarımsal Atıkların Endüstriye Geri Kazanımı Uygulama ve Araştırma Merkezi’ni (DÜTAGAM) ziyaret eden konuk heyet, çevre alanında özellikle tarımsal atıkların değerlendirilmesi konusunda yaptığı çalışmalarla bölgemize rol model olan Merkezimizde incelemelerde bulundu. DÜTAGAM Müdürü Prof. Dr. Süleyman Korkut ve Merkez yetkilileri; tıbbi ve yenilebilir mantar üretimi ile tarımsal kompost gübre ve malç üretimi hakkında bilgi ve deneyimlerini anlatarak tarımsal atıkların değerlendirilmesi ve nihai ürüne dönüşmesi noktasında yapılan örnek çalışmalardan bahsettiler.\r\n\r\nArtvin Çoruh Üniversitesi heyeti; Üniversitemizin bölgesel kalkınma alanındaki deneyimlerini yerinde gözlemleyip ilerleyen zamanlarda karşılıklı iş birliği projeleri gerçekleştirmek istediklerini belirterek kendilerine yakın ilgi gösteren Üniversitemize teşekkürlerini iletti.",
                        Image = "/images/DuyuruResimleri/GunumuzdeGenclikSempozyomu.jpg"
                    },
                    new Duyuru
                    {
                        Id = 6,
                        Tarih = DateNow,
                        Baslik = "Günümüzde Gençlik Sempozyumu",
                        KisaAciklama = "Üniversitemizde düzenlenecek gençlik sempozyumuna sizlerde davetlisiniz",
                        Aciklama = "Üniversitemizde düzenlenecek gençlik sempozyumuna sizlerde davetlisiniz",
                        Image = "/images/DuyuruResimleri/artvincoruh.jpg"
                    },
                    new Duyuru
                    {
                        Id = 7,
                        Tarih = DateNow,
                        Baslik = "DAGEM Markalı Ürünler Ziyaretçilere Tanıtıldı",
                        KisaAciklama = "Üniversitemiz Arıcılık Araştırma Geliştirme ve Uygulama Merkezi (DAGEM) Üsküdar Belediyesi’nin düzenlediği “Yöresel Lezzetler Festivali” etkinliğine katıldı.",
                        Aciklama = "Üniversitemiz Arıcılık Araştırma Geliştirme ve Uygulama Merkezi (DAGEM) Üsküdar Belediyesi’nin düzenlediği “Yöresel Lezzetler Festivali” etkinliğine katıldı.\r\n\r\nÜsküdar Harem Meydanı’nda düzenlenen etkinlikte tanıtım standı açan Üniversitemiz, DAGEM’in ürettiği; kestane propolisi, propolis, polen, kestane ve çiçek balları ayrıca yeni tescillenen Yığılca bal arısı ekotipi tanıtıldı.\r\n\r\nStandımızı TBMM üyesi Av. Serken Bayram, İstanbul Düzceliler Derneği Yönetim Kurulu Başkanı İlyas Çelebi, ünlü oyuncu Muharrem Türkseven, 81 ilinin dernek başkanları, festivale katılan İstanbul halkı ve Düzceliler ziyaret etti. 180 bin kişinin katıldığı festivalde DAGEM tescilli ürünlerimiz büyük ilgi gördü.",
                        Image = "/images/DuyuruResimleri/dagem.jpg"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
