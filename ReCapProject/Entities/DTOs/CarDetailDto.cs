using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{// IEntity anasınıf olamaz çünkü veritabanı tablosu değil!
    public class CarDetailDto:IDto
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string colorName { get; set; }
        public string brandName { get; set; }
        public int DailyPrice { get; set; }

    }
}
