using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tangent.CeviriDukkani.Domain.Dto.System
{
    public class MailDataDto
    {
        public class AdminTestOnayla
        {
            public string adsoyad { get; set; }
            public string kaynakdil { get; set; }
            public string hedefdil { get; set; }
            public string kaynakDokuman { get; set; }
            public string tercumesi { get; set; }
            public string tarih { get; set; }
            public string testcevapid { get; set; }
        }
        public class BireyselRegistration
        {
            public string adsoyad { get; set; }
        }
        public class CeviriTamamlandi
        {
            public string KurumAdi { get; set; }
            public string adsoyad { get; set; }
            public string ceviri { get; set; }
            public string TerminolojiDosyasi { get; set; }
        }
        public class Dekont
        {
            public DateTime odemeTarihi { get; set; }
            public int orderid { get; set; }
            public string alacakliAdSoyad { get; set; }
            public string alacakliIBAN { get; set; }
            public decimal odenmisTutar { get; set; }
        }
        public class EditorKontrolleriBitirdi
        {
            public string adsoyad { get; set; }
            public string orderid { get; set; }
        }
        public class EmailConfirmation
        {
            public string adsoyad { get; set; }
            public string userid { get; set; }
        }
        public class IhaleAlindi
        {
            public string adsoyad { get; set; }
            public decimal tutar { get; set; }
            public int ihaleid { get; set; }
            public int tid { get; set; }
            public string KaynakDil { get; set; }
            public string HedefDil { get; set; }
            public string alan { get; set; }
            public int ceviriId { get; set; }
            public string cevirinumarasi { get; set; }
            public DateTime teslimTarihi { get; set; }
            public string dokuman { get; set; }
            public int karakterSayisi { get; set; }
            public string siparisNotu { get; set; }
            public string TercumanOzelNot { get; set; }
            public bool YeminliMi { get; set; }
            public string TerminolojiDosyasi { get; set; }
        }
        public class IhaleyeIsAc
        {
            public string tutar { get; set; }
            public int ihaleid { get; set; }
            public int tid { get; set; }
            public string KaynakDil { get; set; }
            public string HedefDil { get; set; }
            public string alan { get; set; }
            public int ceviriId { get; set; }
            public string cevirinumarasi { get; set; }
            public DateTime teslimTarihi { get; set; }
            public string dokuman { get; set; }
            public int karakterSayisi { get; set; }
            public string siparisNotu { get; set; }
            public string TercumanOzelNot { get; set; }
            public bool yeminliTercume { get; set; }
            public string TerminolojiDosyasi { get; set; }
        }
        public class InsanKaynaklari
        {
            public string KurumAdi { get; set; }
            public string adsoyad { get; set; }
            public string KaynakDil { get; set; }
            public string HedefDil { get; set; }
            public bool yeminliTercume { get; set; }
            public int KarakterSayisi { get; set; }
            public string alan { get; set; }
            public int ceviriId { get; set; }
            public DateTime islemTarihi { get; set; }
            public DateTime teslimTarihi { get; set; }
            public string dokuman { get; set; }
            public string siparisNotu { get; set; }
            public string TerminolojiDosyasi { get; set; }
        }
        public class KontrolBekleyenDosyalar
        {
           
        }
        public class KurumsalRegistration
        {
            public string adsoyad { get; set; }
            public string sirketAdi { get; set; }
            public string kurumkodu { get; set; }
        }
        public class MusteriRevizeGonder
        {
            public string KurumAdi { get; set; }
            public string adsoyad { get; set; }
            public string tabloYukle { get; set; }
            public string ceviritipi { get; set; }
            public string KaynakDil { get; set; }
            public string HedefDil { get; set; }
            public string alan { get; set; }
            public int ceviriId { get; set; }
            public string siparisNotu { get; set; }
            public DateTime RevizeTarihi { get; set; }
            public string RevizeYorumu { get; set; }
        }
        public class OdemeAlindi
        {
            public string KurumAdi { get; set; }
            public string adsoyad { get; set; }
            public bool yeminliTercume { get; set; }
            public string ceviritipi { get; set; }
            public string KaynakDil { get; set; }
            public string HedefDil { get; set; }
            public int KarakterSayisi { get; set; }
            public string alan { get; set; }
            public int ceviriId { get; set; }
            public DateTime islemTarihi { get; set; }
            public DateTime teslimTarihi { get; set; }
            public decimal tutar { get; set; }
            public decimal kdv { get; set; }
            public decimal ucret { get; set; }
            public string odemeSekli { get; set; }
            public bool odemeYapildiMi { get; set; }
            public string dokuman { get; set; }
            public string siparisNotu { get; set; }
            public string MusteriNotu { get; set; }
            public string TerminolojiDosyasi { get; set; }
        }
        public class RevizeFinal
        {
            public string KurumAdi { get; set; }
            public string adsoyad { get; set; }
            public string tabloYukle { get; set; }
            public string ceviritipi { get; set; }
            public string KaynakDil { get; set; }
            public string HedefDil { get; set; }
            public string alan { get; set; }
            public int ceviriId { get; set; }
            public string siparisNotu { get; set; }
            public DateTime RevizeTarihi { get; set; }
            public string RevizeYorumu { get; set; }
        }
        public class SiparisIptal
        {
            public string ceviritipi { get; set; }
            public string KaynakDil { get; set; }
            public string HedefDil { get; set; }
            public string alan { get; set; }
            public int ceviriId { get; set; }
            public DateTime iptalTarihi { get; set; }
            public string dokuman { get; set; }
            public string siparisNotu { get; set; }
        }
        public class SiparisTamamlandi
        {
            public string KurumAdi { get; set; }
            public string adsoyad { get; set; }
            public string Dosyaindirlinki { get; set; }
            public string tabloYukle { get; set; }
            public bool yeminliTercume { get; set; }
            public string ceviritipi { get; set; }
            public string KaynakDil { get; set; }
            public string HedefDil { get; set; }            
            public int KarakterSayisi { get; set; }
            public string alan { get; set; }
            public int ceviriId { get; set; }
            public DateTime islemTarihi { get; set; }
            public DateTime teslimTarihi { get; set; }
            public decimal tutar { get; set; }
            public decimal kdv { get; set; }
            public decimal ucret { get; set; }
            public string odemeSekli { get; set; }
            public bool odemeYapildiMi { get; set; }
            public string siparisNotu { get; set; }
            public string MusteriNotu { get; set; }
            public string TerminolojiDosyasi { get; set; }
        }
        public class Siparis
        {
            public string KurumAdi { get; set; }
            public string adsoyad { get; set; }
            public bool yeminliTercume { get; set; }
            public string ceviritipi { get; set; }
            public string KaynakDil { get; set; }
            public string HedefDil { get; set; }
            public int KarakterSayisi { get; set; }
            public string alan { get; set; }
            public int ceviriId { get; set; }
            public DateTime islemTarihi { get; set; }
            public DateTime teslimTarihi { get; set; }
            public decimal tutar { get; set; }
            public decimal kdv { get; set; }
            public decimal ucret { get; set; }
            public string odemeSekli { get; set; }
            public bool odemeYapildiMi { get; set; }
            public string dokuman { get; set; }
            public string siparisNotu { get; set; }
            public string MusteriNotu { get; set; }
            public string TerminolojiDosyasi { get; set; }
        }
        public class TeklifCevabi
        {
            public string KurumAdi { get; set; }
            public string adsoyad { get; set; }
            public int userid { get; set; }
            public string teklifAciklamasi { get; set; }
            public bool yeminliTercume { get; set; }
            public string ceviritipi { get; set; }
            public string KaynakDil { get; set; }
            public string HedefDil { get; set; }
            public int KarakterSayisi { get; set; }
            public string alan { get; set; }
            public decimal fiyat { get; set; }
            public decimal kdv { get; set; }
            public decimal ucret { get; set; }
            public int teklifId { get; set; }
            public DateTime teslimTarihi { get; set; }
            public string dokuman { get; set; }
            public string siparisNotu { get; set; }
        }
        public class TeklifRedAciklamasi
        {
            public string KurumAdi { get; set; }
            public string adsoyad { get; set; }
            public int userid { get; set; }
            public string teklifAciklamasi { get; set; }
            public string teklifRedAciklamasi { get; set; }
            public bool yeminliTercume { get; set; }
            public string ceviritipi { get; set; }
            public string KaynakDil { get; set; }
            public string HedefDil { get; set; }
            public int KarakterSayisi { get; set; }
            public string alan { get; set; }
            public decimal fiyat { get; set; }
            public decimal kdv { get; set; }
            public decimal ucret { get; set; }
            public int teklifId { get; set; }
            public DateTime teslimTarihi { get; set; }
            public string dokuman { get; set; }
            public string siparisNotu { get; set; }
        }
        public class TeklifRededildi
        {
            public string KurumAdi { get; set; }
            public string adsoyad { get; set; }
            public int userid { get; set; }
            public string teklifAciklamasi { get; set; }
            public bool yeminliTercume { get; set; }
            public string ceviritipi { get; set; }
            public string KaynakDil { get; set; }
            public string HedefDil { get; set; }
            public int KarakterSayisi { get; set; }
            public string alan { get; set; }
            public decimal fiyat { get; set; }
            public decimal kdv { get; set; }
            public decimal ucret { get; set; }
            public int teklifId { get; set; }
            public DateTime teslimTarihi { get; set; }
            public string dokuman { get; set; }
            public string siparisNotu { get; set; }
        }
        public class TeklifTalebi
        {
            public string KurumAdi { get; set; }
            public string adsoyad { get; set; }
            public int userid { get; set; }
            public string teklifAciklamasi { get; set; }
            public bool yeminliTercume { get; set; }
            public string ceviritipi { get; set; }
            public string KaynakDil { get; set; }
            public string HedefDil { get; set; }
            public int KarakterSayisi { get; set; }
            public string alan { get; set; }
            public decimal fiyat { get; set; }
            public decimal kdv { get; set; }
            public decimal ucret { get; set; }
            public int teklifId { get; set; }
            public DateTime teslimTarihi { get; set; }
            public string dokuman { get; set; }
            public string siparisNotu { get; set; }
        }
        public class TercumanIsGonder
        {
            public string UserName { get; set; }
        }
        public class TercumanSiparisIptal
        {
            public string UserName { get; set; }
        }
        public class TercumeyiBitirdim
        {
            public string UserName { get; set; }
        }
        public class TestGonder
        {
            public string UserName { get; set; }
        }
        public class TestTercumeOnaylandi
        {
            public string UserName { get; set; }
        }
        public class TestTercumeRedEdildi
        {
            public string UserName { get; set; }
        }
        public class TranslatorWelcomingMail
        {
            public string UserName { get; set; }
        }

        public class Register
        {
            public string UserName { get; set; }
            public string EMail { get; set; }
            public string Pass { get; set; }
        }

        public class ResetPassword
        {
            public string UserName { get; set; }
            public string ResetLink { get; set; }

        }

        public class ForgetPassword
        {
            public string UserName { get; set; }
            public string EMail { get; set; }
            public string Pass { get; set; }
        }

        public class UserActivation
        {
            public string UserName { get; set; }
            public string RegisterLink { get; set; }
            public string Comment { get; set; }
        }
    }
}
