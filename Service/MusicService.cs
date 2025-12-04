using ivosWebsite.Models;

namespace ivosWebsite.Service
{
    public class MusicService
    {
        public List<Music> GetMusics()
        {
            return new List<Music>
            {
                new Music
                {
                    Title = "Andalucia",
                    ReleaseDate = DateTime.Parse("2025-11-05"),
                    Photo = "/images/music/andalucia.jpg",
                    Type = "album"
                },
                new Music
                {
                    Title = "CLAPCLAPCLAP!",
                    ReleaseDate = DateTime.Parse("2019-01-18"),
                    Photo = "/images/music/clapclapclap.jpg",
                    Type = "album"
                },
                new Music
                {
                    Title = "Suliranin",
                    ReleaseDate = DateTime.Parse("2025-10-08"),
                    Photo = "/images/music/suliranin.jpg",
                    Type = "single"
                },
                new Music
                {
                    Title = "Konsensya",
                    ReleaseDate = DateTime.Parse("2025-09-10"),
                    Photo = "/images/music/konsensya.jpg",
                    Type = "single"
                },
                new Music
                {
                    Title = "Nanaman",
                    ReleaseDate = DateTime.Parse("2025-08-13"),
                    Photo = "/images/music/nanaman.jpg",
                    Type = "single"
                },
                new Music
                {
                    Title = "Aura",
                    ReleaseDate = DateTime.Parse("2025-07-16"),
                    Photo = "/images/music/aura.jpg",
                    Type = "single"
                },
                new Music
                {
                    Title = "Sariling Multo (Sa Panaginip)",
                    ReleaseDate = DateTime.Parse("2020-04-17"),
                    Photo = "/images/music/sariling_multo.jpg",
                    Type = "single"
                },
                new Music
                {
                    Title = "Ang Pinagmulan",
                    ReleaseDate = DateTime.Parse("2020-02-07"),
                    Photo = "/images/music/ang_pinagmulan.jpg",
                    Type = "single"
                },
                new Music
                {
                    Title = "Come Inside of My Heart",
                    ReleaseDate = DateTime.Parse("2019-02-24"),
                    Photo = "/images/music/ciomh.jpg",
                    Type = "single"
                },
                new Music
                {
                    Title = "Take That Man",
                    ReleaseDate = DateTime.Parse("2018-12-28"),
                    Photo = "/images/music/take_that_man.jpg",
                    Type = "single"
                },
                new Music
                {
                    Title = "Namamasko Po",
                    ReleaseDate = DateTime.Parse("2018-12-02"),
                    Photo = "/images/music/namamasko_po.jpg",
                    Type = "single"
                },
                new Music
                {
                    Title = "Sa Kahapon",
                    ReleaseDate = DateTime.Parse("2018-11-05"),
                    Photo = "/images/music/sa_kahapon.jpg",
                    Type = "single"
                },
                new Music
                {
                    Title = "Bata, Dahan-Dahan x Nadarang",
                    ReleaseDate = DateTime.Parse("2018-10-03"),
                    Photo = "/images/music/bdd_x_nadarang.jpg",
                    Type = "single"
                },
                new Music
                {
                    Title = "Bata, Dahan-Dahan",
                    ReleaseDate = DateTime.Parse("2018-09-14"),
                    Photo = "/images/music/bata_dahan_dahan.jpg",
                    Type = "single"
                },
                new Music
                {
                    Title = "In My Prison",
                    ReleaseDate = DateTime.Parse("2018-07-13"),
                    Photo = "/images/music/in_my_prison.jpg",
                    Type = "single"
                },
                new Music
                {
                    Title = "Mundo",
                    ReleaseDate = DateTime.Parse("2018-02-14"),
                    Photo = "/images/music/mundo.jpg",
                    Type = "single"
                },
                new Music
                {
                    Title = "Where Have You Been, My Disco?",
                    ReleaseDate = DateTime.Parse("2017-10-20"),
                    Photo = "/images/music/whybmd.jpg",
                    Type = "single"
                },
                new Music
                {
                    Title = "Hey Barbara",
                    ReleaseDate = DateTime.Parse("2017-07-14"),
                    Photo = "/images/music/hey_barbara.jpg",
                    Type = "single"
                },
                new Music
                {
                    Title = "Ilaw sa Daan",
                    ReleaseDate = DateTime.Parse("2016-10-07"),
                    Photo = "/images/music/ilaw_sa_daan.jpg",
                    Type = "single"
                },
                new Music
                {
                    Title = "Nagbabalik",
                    ReleaseDate = DateTime.Parse("2019-07-03"),
                    Photo = "/images/music/nagbabalik.jpg",
                    Type = "featured"
                },
            };
        }
    }
}
