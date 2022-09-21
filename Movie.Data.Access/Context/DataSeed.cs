using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Movie.Data.Model.DatabaseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie.Data.Access.Context
{
    public class DataSeed
    {
        public static void Seed(IApplicationBuilder app)
        {

            var scope = app.ApplicationServices.CreateScope();
            var context = scope.ServiceProvider.GetService<MovieDbContext>();

            if (context?.TblMovieType.Count() == 0)
            {
                context.TblMovieType.AddRange(GetMovieTypeData());
                context.SaveChanges();
            }
            if (context?.TblGeneralAudienceType.Count() == 0)
            {
                context.TblGeneralAudienceType.AddRange(GetGeneralAudienceTypeData());
                context.SaveChanges();

            }
            if (context?.TblMovie.Count() == 0)
            {
                context.TblMovie.AddRange(GetMovieData());
                context.SaveChanges();

            }
        }

        public static IList<TblMovie> GetMovieData()
        {
            List<TblMovie> list = new List<TblMovie>
            {
                new TblMovie
            {
                Name = "Canavar Ev",
                CreatedTime = DateTime.Now,
                ImageUrl ="https://occ-0-2773-778.1.nflxso.net/dnm/api/v6/X194eJsgWBDE2aQbaNdmCXGUP-Y/AAAABddcTBjW9MEJgvvbQ91yJ9rvf4fVX7Y00DvtP6H0sSlMYoQarp8kfVNV8RG30wda9CnixoYgKSryQGHw1FNI62qa-QqJYNASLa0.jpg?r=1b1",
                    Description="Mahallelerindeki boş bir evin insanları yuttuğuna ve canlı olduğuna inanan üç arkadaş, bu evin yaşattığı dehşeti açığa çıkarmak için işe koyulur.",
                    Score =8,
                 TblGeneralAudienceTypeId=1,
                TblMovieTypeId=1,
            },  new TblMovie
            {
                Name = "Yankesiciler",
                CreatedTime = DateTime.Now,
                ImageUrl ="https://occ-0-2773-778.1.nflxso.net/dnm/api/v6/X194eJsgWBDE2aQbaNdmCXGUP-Y/AAAABVJBjIIBCGvMysohG79FkiQzLQiuCrmEdzv3LPnZrLRPC7jWNQnqMQSBlByRnni47XNAT9YzDPeVqgy-pUXM4H9sOO1ZLALbMkEFHBuiHrjQF1TCpK__enBujSIB_R-hoCgm.jpg?r=eaf",
                    Description="Gelecek vadeden genç hırsızlar, Bogotá sokaklarında bir alavere dalavere sanatları ustasından başarılı birer yankesici olmayı öğrenir.",
                  Score =8,
                 TblGeneralAudienceTypeId=1,
                TblMovieTypeId=1,
            },
                new TblMovie
            {
                Name = "Bir Eksik",
                CreatedTime = DateTime.Now,
                ImageUrl ="https://occ-0-2773-778.1.nflxso.net/dnm/api/v6/X194eJsgWBDE2aQbaNdmCXGUP-Y/AAAABXVEimEjg5fmr-L4BvbfznUuDEVjgVlI-Pgg1ougVTbdDqwwWiY6xra-1gTIVcxMDn-355bKasjOpUEhgxmVqJJDTSF6teNePX_JzgpAkE8cxI0QGunmD4TfM1ZYTtSqvLod.jpg?r=a17",  Description ="Dul kalan çiçeği burnunda bir baba, kızını tek başına büyütmek için bilinmezlik, korku, üzüntü ve bebek bezleriyle dolu bir serüvene atılır. Gerçek bir öyküden esinlendi.",
                    Score =8,
                TblGeneralAudienceTypeId=1,
                TblMovieTypeId=1,
            },
                new TblMovie
            {
                Name = "Şuursuz Aşk",
                CreatedTime = DateTime.Now,
                ImageUrl ="https://occ-0-2773-778.1.nflxso.net/dnm/api/v6/X194eJsgWBDE2aQbaNdmCXGUP-Y/AAAABZ0pSufeCZPZEkZlRdb8Sfthd07bahrqJlmcOCeiQ-L0qvURI4nN_VD7RSAxxukQhP57jfmjPPZsMQNOWe9jqZsMf2weX_bE5rU.jpg?r=151",
                    Description = "1980'ler Türkiyesi'nin çalkantılı ortamında bir akıl ve ruh sağlığı rehabilitasyon merkezinde yatan genç bir adam ve bir kadın arasında masum bir aşk filizlenir.",
                    Score =7,
                TblGeneralAudienceTypeId=1,
                TblMovieTypeId=1,
            }, new TblMovie
            {
                Name = "Suçlu",
                CreatedTime = DateTime.Now,
                ImageUrl ="https://occ-0-2773-778.1.nflxso.net/dnm/api/v6/X194eJsgWBDE2aQbaNdmCXGUP-Y/AAAABd4uUTcVMQ3QQjv-dxIDexfRJjbD1GLyfaZ1PXEEQERGj-GaqN5vsisdlu8Bld2wm0cSPhFGme4GXdeRfgxNISBy5pCJmSV_zwGRfb1h-1hVkio977hq2EeqTAYX6caMQ48i.jpg?r=462",
                    Description = "911 operatörü olarak görevlendirilen sorunlu bir dedektif, çağrı merkezini arayan endişeli bir kadını kurtarmaya çalışırken bir yandan da kendi vicdanıyla baş başa kalır.",
                    Score =8,
                TblGeneralAudienceTypeId=1,
                TblMovieTypeId=1,
            },
                new TblMovie
            {
                Name = "Bird Box",
                CreatedTime = DateTime.Now,
                ImageUrl ="https://occ-0-2773-778.1.nflxso.net/dnm/api/v6/X194eJsgWBDE2aQbaNdmCXGUP-Y/AAAABUhoTqxdJSORpic-dHt3keOgOIsM1AaH0KGT7nXjXyi0vxrH6rUVdcGykLoBlXKF9Hq-ZfOeNguxoj5JT6rOH-4AuAAAjvAtTaVjqv8lJ6p5b3DZ94hKd5jl0zubpTM4B8Oq.jpg?r=13c",
                    Description = "Görünmeyen uğursuz bir varlığın toplumun büyük kısmını intihara sürüklemesinden beş yıl sonra, hayatta kalan bir kadın ve iki çocuğu güvenli bir yere ulaşmaya çabalar.",
                Score =6,
                TblGeneralAudienceTypeId=1,
                TblMovieTypeId=1,
            }
                ,
                new TblMovie
            {
                Name = "Yırtıcı Kuşlar (Ve Muhteşem Harley Quinn)",
                CreatedTime = DateTime.Now,
                ImageUrl = "https://occ-0-2773-778.1.nflxso.net/dnm/api/v6/X194eJsgWBDE2aQbaNdmCXGUP-Y/AAAABTyksH3lWTOccLJKQTy7aKhgiXGL6g1m8GwPHz4Ov5IYH6-0F7Wc6qX8HKDuZowIHAeJ-k1L_xfcnoQnD1ceyFL7oXTI-4R1SWg.jpg?r=14a",
                Description = "Joker ile bağlarını kopardıktan sonra hedef hâline gelen Harley Quinn, bir suç lideriyle mücadele etmek için kadınlardan oluşan bir süper kahraman ekibine katılır.",
                Score = 5,
                TblGeneralAudienceTypeId=1,
                TblMovieTypeId=1,
            },

                new TblMovie
            {
                Name = "Kayıp Savaş",
                CreatedTime = DateTime.Now,
                ImageUrl = "https://occ-0-2773-778.1.nflxso.net/dnm/api/v6/X194eJsgWBDE2aQbaNdmCXGUP-Y/AAAABRVBD_4xYlNM9k6UoysX8n2Pyyc6SzeO-djkTyK5ZxXW78en6GKQrWOuLj08R9rFmjboQwSZl7i0FSuLw3dvaBfCeeWlZvRYmB09uDw6IkLrowbnDOgQNtaSJwBN67q9OXzG.jpg?r=934",
                Description ="2. Dünya Savaşı'nda önemli bir yeri olan Scheldt Muharebesi sırasında bir planör pilotu, bir Nazi askeri ve gönülsüz bir Direniş askerinin hayatı trajik şekilde kesişir.",
                Score = 9,
                TblGeneralAudienceTypeId=7,
                TblMovieTypeId=6,
            },

                new TblMovie
            {
                Name = "Cennette Yaşam Savaşı: Bir Aile Masalı",
                CreatedTime = DateTime.Now,
                ImageUrl = "https://occ-0-2773-778.1.nflxso.net/dnm/api/v6/X194eJsgWBDE2aQbaNdmCXGUP-Y/AAAABZTdoLB9pc2v_0p5KJ2J2IGl3V7Qo0F38q51uwbU6Am0T2owqzAcVFrt6Yfl6CaTtU5gjo4nTw_ty3rrxB2EiUH53gCflkscj2SgK-BOzl9CNGYDQxtgU3-QV4WyhDPKx4-p.jpg?r=2da",
                Description ="Vahşi yaşamı konu alan bu dramada, Kalahari Çölü'nde kurak mevsimin uzaması, buradaki tüm hayvan sürülerini hayatta kalmak için ailenin gücüne güvenmek zorunda bırakır.",
                Score = 9,
                TblGeneralAudienceTypeId=7,
                TblMovieTypeId=6,
            },


                new TblMovie
            {
                Name = "Kaykaycı Kız",
                CreatedTime = DateTime.Now,
                ImageUrl = "https://occ-0-2773-778.1.nflxso.net/dnm/api/v6/X194eJsgWBDE2aQbaNdmCXGUP-Y/AAAABRxd1v0L9Bq-mcQlXC1WpVU9OcXX2bRdv8XdP9HtXczCxs7690ulLpa3jRAaUru8lDVgCLucImT8246jYFQZEb5mxVt9_rtlpfkTr_P48lgxjtTRLR2FBAKiEPRsdnpO-ltR.jpg?r=5db",
                Description ="Hindistan kırsalındaki bir genç, hayatını değiştirecek kaykay tutkusunu keşfeder. Yarışlara katılma hayalinin peşindeki bu genci zorlu bir yol bekliyordur.",
                Score = 8,
                TblGeneralAudienceTypeId=7,
                TblMovieTypeId=6,
            },

            };
            return list;
        }

        public static IList<TblMovieType> GetMovieTypeData()
        {
            List<TblMovieType> list = new List<TblMovieType>
            {
                new TblMovieType
            {
                Type = "Komedi"
            },
                new TblMovieType
            {
                Type = "Romantik"
            },
                new TblMovieType
            {
                Type = "Aksiyon-gerilim"
            },
                new TblMovieType
            {
                Type = "Trajedi"
            },
                new TblMovieType
            {
                Type = "Bilim Kurgu"
            },
                new TblMovieType
            {
                Type = "Aksiyon"
            }
            };
            return list;
        }


        public static IList<TblGeneralAudienceType> GetGeneralAudienceTypeData()
        {

            List<TblGeneralAudienceType> list = new List<TblGeneralAudienceType>
            {
                new TblGeneralAudienceType
            {
                Name = "7+",
                Description="Bu filmler 7 yaşında ve 7 yaşın üzerinde olanlar için uygun."
            },
                new TblGeneralAudienceType
            {
                Name = "7A",
                Description="7 yaş altı izleyici kitlesi aile eşliğinde izleyebilir."
            },
                new TblGeneralAudienceType
            {
                Name = "13+",
                Description="Bu filmler 13 yaşında ve 13 yaşın üzerinde olanlar için uygun."
            },
                new TblGeneralAudienceType
            {
                Name = "13A",
                Description="13 yaş altı izleyici kitlesi aile eşliğinde izleyebilir."
            },
                new TblGeneralAudienceType
            {
                Name = "15+",
                Description="Bu filmler 15 yaşında ve 15 yaşın üzerinde olanlar için uygun."
            },
                new TblGeneralAudienceType
            {
                Name = "15A",
                Description=" 15 yaş altı izleyici kitlesi aile eşliğinde izleyebilir."
            },
                new TblGeneralAudienceType
            {
                Name = "18+",
                Description="Bu filmler 18 yaşında ve 18 yaşın üzerinde olanlar için uygun."
            },
            };
            return list;

        }
    }
}
