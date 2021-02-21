using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "araba eklendi";
        public static string CarNameInvalid = "ürün ismi geçersiz";
        public static string CarsListed = "arabalar listelendi";
        public static string CarDeleted = "araç silme işlemi tamamlandı";
        public static string CarUpdated = "araba güncelleme işlemi başarılı";

        public static string ColorAdded = "renk kayıt işlemi başarılı";
        public static string ColorDeleted = "renk silme işlemi başarılı";
        public static string ColorUpdated = "renk güncelleme işlemi başarılı";
        public static string ColorAddError = "istenen renk zaten mevcut";

        public static string BrandAdded = "Marka kayıt işlemi başarılı";
        public static string BrandUpdated = "Marka güncelleme işlemi başarılı";
        public static string BrandDeleted = "Marka silme işlemi başarılı";
        public static string BrandAddError = "İstenen marka zaten mevcut";
        internal static string MaintenanceTime = "sistem bakımda";
    }
}
