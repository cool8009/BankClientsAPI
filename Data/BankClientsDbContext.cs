using Microsoft.EntityFrameworkCore;

namespace BankClientApi.Data
{
    public class BankClientsDbContext : DbContext
    {
        public BankClientsDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<City> Cities { get; set; }
        public DbSet<Client> Clients { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<City>().HasData(
            new City
            {
                Id = 967,
                Name = "אבו ג'ווייעד (שבט)"
            },
            new City
            {
                Id = 472,
                Name = "אבו גוש"
            }, 
            new City
            {
                Id = 473,
                Name = "אבו סנאן"
            }, 
            new City
            {
                Id = 935,
                Name = "אבו סריחאן (שבט)"
            }, 
            new City
            {
                Id = 958,
                Name = "אבו עבדון (שבט)"
            }, 
            new City
            {
                Id = 1042,
                Name = "אבו עמאר (שבט)"
            }, 
            new City
            {
                Id = 932,
                Name = "אבו עמרה (שבט)"
            }, 
            new City
            {
                Id = 1342,
                Name = "אבו קורינאת (יישוב)"
            }, 
            new City
            {
                Id = 968,
                Name = "אבו קורינאת (שבט)"
            }, 
            new City
            {
                Id = 966,
                Name = "אבו רובייעה (שבט)"
            }, 
            new City
            {
                Id = 961,
                Name = "אבו רוקייק (שבט)"
            }, 
            new City
            {
                Id = 1375,
                Name = "אבו תלול"
            }, 
            new City
            {
                Id = 652,
                Name = "אבטין"
            }, 
            new City
            {
                Id = 1275,
                Name = "אבטליון"
            }, 
            new City
            {
                Id = 679,
                Name = "אביאל"
            }, 
            new City
            {
                Id = 1115,
                Name = "אביבים"
            }, 
            new City
            {
                Id = 819,
                Name = "אביגדור"
            }, 
            new City
            {
                Id = 175,
                Name = "אביחיל"
            }, 
            new City
            {
                Id = 2052,
                Name = "אביטל"
            }, 
            new City
            {
                Id = 1070,
                Name = "אביעזר"
            }, 
            new City
            {
                Id = 1220,
                Name = "אבירים"
            }, 
            new City
            {
                Id = 182,
                Name = "אבן יהודה"
            }, 
            new City
            {
                Id = 1081,
                Name = "אבן מנחם"
            }, 
            new City
            {
                Id = 783,
                Name = "אבן ספיר"
            }, 
            new City
            {
                Id = 400,
                Name = "אבן שמואל"
            }, 
            new City
            {
                Id = 4011,
                Name = "אבני איתן"
            }, 
            new City
            {
                Id = 3793,
                Name = "אבני חפץ"
            }, 
            new City
            {
                Id = 3786,
                Name = "אבנת"
            }, 
            new City
            {
                Id = 1311,
                Name = "אבשלום"
            }, 
            new City
            {
                Id = 3759,
                Name = "אדורה"
            }, 
            new City
            {
                Id = 113,
                Name = "אדירים"
            }, 
            new City
            {
                Id = 1068,
                Name = "אדמית"
            }, 
            new City
            {
                Id = 1123,
                Name = "אדרת"
            }, 
            new City
            {
                Id = 446,
                Name = "אודים"
            }, 
            new City
            {
                Id = 4010,
                Name = "אודם"
            }, 
            new City
            {
                Id = 1046,
                Name = "אוהד"
            }, 
            new City
            {
                Id = 2710,
                Name = "אום אל-פחם"
            }, 
            new City
            {
                Id = 2024,
                Name = "אום אל-קוטוף"
            }, 
            new City
            {
                Id = 1358,
                Name = "אום בטין"
            }, 
            new City
            {
                Id = 1108,
                Name = "אומן"
            }, 
            new City
            {
                Id = 680,
                Name = "אומץ"
            }, 
            new City
            {
                Id = 31,
                Name = "אופקים"
            }, 
            new City
            {
                Id = 1294,
                Name = "אור הגנוז"
            }, 
            new City
            {
                Id = 67,
                Name = "אור הנר"
            }, 
            new City
            {
                Id = 2400,
                Name = "אור יהודה"
            }, 
            new City
            {
                Id = 1020,
                Name = "אור עקיבא"
            }, 
            new City
            {
                Id = 780,
                Name = "אורה"
            }, 
            new City
            {
                Id = 1771,
                Name = "אורון"
            }, 
            new City
            {
                Id = 2012,
                Name = "אורות"
            }, 
            new City
            {
                Id = 4013,
                Name = "אורטל"
            }, 
            new City
            {
                Id = 403,
                Name = "אורים"
            }, 
            new City
            {
                Id = 882,
                Name = "אורנים"
            }, 
            new City
            {
                Id = 3760,
                Name = "אורנית"
            }, 
            new City
            {
                Id = 278,
                Name = "אושה"
            }, 
            new City
            {
                Id = 565,
                Name = "אזור"
            }, 
            new City
            {
                Id = 1852,
                Name = "אזור אילון מ\"א 4"
            }, 
            new City
            {
                Id = 1851,
                Name = "אזור אילון מ\"א 52"
            }, 
            new City
            {
                Id = 1853,
                Name = "אזור אילון של\"ש"
            }, 
            new City
            {
                Id = 1922,
                Name = "אזור אשדוד מ\"א 29"
            }, 
            new City
            {
                Id = 1921,
                Name = "אזור אשדוד מ\"א 33"
            }, 
            new City
            {
                Id = 1923,
                Name = "אזור אשדוד של\"ש"
            }, 
            new City
            {
                Id = 1924,
                Name = "אזור אשקלון מ\"א 36"
            }, 
            new City
            {
                Id = 1926,
                Name = "אזור אשקלון מ\"א 37"
            }, 
            new City
            {
                Id = 1937,
                Name = "אזור באר שבע מ\"א 41"
            }, 
            new City
            {
                Id = 1938,
                Name = "אזור באר שבע מ\"א 51"
            }, 
            new City
            {
                Id = 1939,
                Name = "אזור באר שבע של\"ש"
            }, 
            new City
            {
                Id = 1933,
                Name = "אזור בשור מ\"א 38"
            }, 
            new City
            {
                Id = 1935,
                Name = "אזור בשור מ\"א 39"
            }, 
            new City
            {
                Id = 1934,
                Name = "אזור בשור מ\"א 42"
            }, 
            new City
            {
                Id = 1907,
                Name = "אזור גלילות מ\"א 19"
            }, 
            new City
            {
                Id = 1931,
                Name = "אזור גרר מ\"א 39"
            }, 
            new City
            {
                Id = 1929,
                Name = "אזור גרר מ\"א 41"
            }, 
            new City
            {
                Id = 1930,
                Name = "אזור גרר מ\"א 42"
            }, 
            new City
            {
                Id = 1866,
                Name = "אזור זכרון יעקב מ\"א 15"
            }, 
            new City
            {
                Id = 1867,
                Name = "אזור זכרון יעקב של\"ש"
            }, 
            new City
            {
                Id = 1873,
                Name = "אזור חדרה מ\"א 14"
            }, 
            new City
            {
                Id = 1872,
                Name = "אזור חדרה מ\"א 15"
            }, 
            new City
            {
                Id = 1871,
                Name = "אזור חדרה מ\"א 45"
            }, 
            new City
            {
                Id = 1874,
                Name = "אזור חדרה של\"ש"
            }, 
            new City
            {
                Id = 1909,
                Name = "אזור חולון של\"ש"
            }, 
            new City
            {
                Id = 1860,
                Name = "אזור חיפה מ\"א 12"
            }, 
            new City
            {
                Id = 1862,
                Name = "אזור חיפה של\"ש"
            }, 
            new City
            {
                Id = 1813,
                Name = "אזור חצור מ\"א 1"
            }, 
            new City
            {
                Id = 1814,
                Name = "אזור חצור מ\"א 55"
            }, 
            new City
            {
                Id = 1815,
                Name = "אזור חצור של\"ש"
            }, 
            new City
            {
                Id = 1848,
                Name = "אזור יחיעם מ\"א 2"
            }, 
            new City
            {
                Id = 1846,
                Name = "אזור יחיעם מ\"א 4"
            }, 
            new City
            {
                Id = 1847,
                Name = "אזור יחיעם מ\"א 52"
            }, 
            new City
            {
                Id = 1849,
                Name = "אזור יחיעם מ\"א 56"
            }, 
            new City
            {
                Id = 1850,
                Name = "אזור יחיעם של\"ש"
            }, 
            new City
            {
                Id = 1942,
                Name = "אזור ים המלח מ\"א 51"
            }, 
            new City
            {
                Id = 1836,
                Name = "אזור יקנעם מ\"א 13"
            }, 
            new City
            {
                Id = 1835,
                Name = "אזור יקנעם מ\"א 9"
            }, 
            new City
            {
                Id = 1805,
                Name = "אזור כינרות מ\"א 3"
            }, 
            new City
            {
                Id = 1816,
                Name = "אזור כנרות מ\"א 1"
            }, 
            new City
            {
                Id = 1817,
                Name = "אזור כנרות מ\"א 6"
            }, 
            new City
            {
                Id = 1818,
                Name = "אזור כנרות של\"ש"
            }, 
            new City
            {
                Id = 1843,
                Name = "אזור כרמיאל מ\"א 2"
            }, 
            new City
            {
                Id = 1844,
                Name = "אזור כרמיאל מ\"א 56"
            }, 
            new City
            {
                Id = 1845,
                Name = "אזור כרמיאל של\"ש"
            }, 
            new City
            {
                Id = 1919,
                Name = "אזור לכיש מ\"א 34"
            }, 
            new City
            {
                Id = 1917,
                Name = "אזור לכיש מ\"א 35"
            }, 
            new City
            {
                Id = 1920,
                Name = "אזור לכיש מ\"א 41"
            }, 
            new City
            {
                Id = 1918,
                Name = "אזור לכיש מ\"א 50"
            }, 
            new City
            {
                Id = 1887,
                Name = "אזור מודיעין מ\"א 25"
            }, 
            new City
            {
                Id = 1890,
                Name = "אזור מודיעין מ\"א 30"
            }, 
            new City
            {
                Id = 1895,
                Name = "אזור מודיעין של\"ש"
            }, 
            new City
            {
                Id = 1911,
                Name = "אזור מלאכי מ\"א 33"
            }, 
            new City
            {
                Id = 1915,
                Name = "אזור מלאכי מ\"א 34"
            }, 
            new City
            {
                Id = 1913,
                Name = "אזור מלאכי מ\"א 35"
            }, 
            new City
            {
                Id = 1914,
                Name = "אזור מלאכי מ\"א 50"
            }, 
            new City
            {
                Id = 1855,
                Name = "אזור נהרייה מ\"א 4"
            }, 
            new City
            {
                Id = 1856,
                Name = "אזור נהרייה של\"ש"
            }, 
            new City
            {
                Id = 1858,
                Name = "אזור עכו מ\"א 4"
            }, 
            new City
            {
                Id = 1857,
                Name = "אזור עכו מ\"א 56"
            }, 
            new City
            {
                Id = 1859,
                Name = "אזור עכו של\"ש"
            }, 
            new City
            {
                Id = 1888,
                Name = "אזור פתח תקווה מ\"א 20"
            }, 
            new City
            {
                Id = 1886,
                Name = "אזור פתח תקווה מ\"א 25"
            }, 
            new City
            {
                Id = 1889,
                Name = "אזור פתח תקווה של\"ש"
            }, 
            new City
            {
                Id = 1903,
                Name = "אזור ראשל\"צ מ\"א 27"
            }, 
            new City
            {
                Id = 1904,
                Name = "אזור ראשל\"צ של\"ש"
            }, 
            new City
            {
                Id = 1896,
                Name = "אזור רחובות מ\"א 28"
            }, 
            new City
            {
                Id = 1899,
                Name = "אזור רחובות מ\"א 29"
            }, 
            new City
            {
                Id = 1898,
                Name = "אזור רחובות מ\"א 30"
            }, 
            new City
            {
                Id = 1901,
                Name = "אזור רחובות מ\"א 31"
            }, 
            new City
            {
                Id = 1897,
                Name = "אזור רחובות מ\"א 32"
            }, 
            new City
            {
                Id = 1902,
                Name = "אזור רחובות של\"ש"
            }, 
            new City
            {
                Id = 1892,
                Name = "אזור רמלה מ\"א 25"
            }, 
            new City
            {
                Id = 1891,
                Name = "אזור רמלה מ\"א 30"
            }, 
            new City
            {
                Id = 1893,
                Name = "אזור רמלה מ\"א 40"
            }, 
            new City
            {
                Id = 1894,
                Name = "אזור רמלה של\"ש"
            }, 
            new City
            {
                Id = 1908,
                Name = "אזור רמת גן של\"ש"
            }, 
            new City
            {
                Id = 1841,
                Name = "אזור שפרעם מ\"א 56"
            }, 
            new City
            {
                Id = 1840,
                Name = "אזור שפרעם מ\"א 9"
            }, 
            new City
            {
                Id = 1842,
                Name = "אזור שפרעם של\"ש"
            }, 
            new City
            {
                Id = 1905,
                Name = "אזור תל אביב של\"ש"
            }, 
            new City
            {
                Id = 1794,
                Name = "אזור תעסוקה מיתרים*"
            }, 
            new City
            {
                Id = 1724,
                Name = "אזור תעסוקה משגב"
            }, 
            new City
            {
                Id = 1865,
                Name = "אזור תעשיה אכסאל מ\"א 9"
            }, 
            new City
            {
                Id = 1726,
                Name = "אזור תעשייה אכזיב (מילואות)"
            }, 
            new City
            {
                Id = 1727,
                Name = "אזור תעשייה נעמן (מילואות)"
            }, 
            new City
            {
                Id = 1157,
                Name = "אחווה"
            }, 
            new City
            {
                Id = 821,
                Name = "אחוזם"
            }, 
            new City
            {
                Id = 1330,
                Name = "אחוזת ברק"
            }, 
            new City
            {
                Id = 785,
                Name = "אחיהוד"
            }, 
            new City
            {
                Id = 850,
                Name = "אחיטוב"
            }, 
            new City
            {
                Id = 804,
                Name = "אחיסמך"
            }, 
            new City
            {
                Id = 797,
                Name = "אחיעזר"
            }, 
            new City
            {
                Id = 965,
                Name = "אטרש (שבט)"
            }, 
            new City
            {
                Id = 338,
                Name = "איבים"
            }, 
            new City
            {
                Id = 716,
                Name = "אייל"
            }, 
            new City
            {
                Id = 77,
                Name = "איילת השחר"
            }, 
            new City
            {
                Id = 294,
                Name = "אילון"
            }, 
            new City
            {
                Id = 1716,
                Name = "אילון תבור*"
            }, 
            new City
            {
                Id = 1126,
                Name = "אילות"
            }, 
            new City
            {
                Id = 49,
                Name = "אילנייה"
            }, 
            new City
            {
                Id = 2600,
                Name = "אילת"
            }, 
            new City
            {
                Id = 3762,
                Name = "איתמר"
            }, 
            new City
            {
                Id = 37,
                Name = "איתן"
            }, 
            new City
            {
                Id = 886,
                Name = "איתנים"
            }, 
            new City
            {
                Id = 478,
                Name = "אכסאל"
            }, 
            new City
            {
                Id = 1359,
                Name = "אל סייד"
            }, 
            new City
            {
                Id = 1339,
                Name = "אל -עזי"
            }, 
            new City
            {
                Id = 1316,
                Name = "אל -עריאן"
            }, 
            new City
            {
                Id = 4003,
                Name = "אל -רום"
            }, 
            new City
            {
                Id = 1145,
                Name = "אלומה"
            }, 
            new City
            {
                Id = 330,
                Name = "אלומות"
            }, 
            new City
            {
                Id = 1182,
                Name = "אלון הגליל"
            }, 
            new City
            {
                Id = 3579,
                Name = "אלון מורה"
            }, 
            new City
            {
                Id = 3604,
                Name = "אלון שבות"
            }, 
            new City
            {
                Id = 429,
                Name = "אלוני אבא"
            }, 
            new City
            {
                Id = 4017,
                Name = "אלוני הבשן"
            }, 
            new City
            {
                Id = 868,
                Name = "אלוני יצחק"
            }, 
            new City
            {
                Id = 285,
                Name = "אלונים"
            }, 
            new City
            {
                Id = 41,
                Name = "אליכין"
            }, 
            new City
            {
                Id = 4002,
                Name = "אלי-עד"
            }, 
            new City
            {
                Id = 1248,
                Name = "אליפז"
            }, 
            new City
            {
                Id = 730,
                Name = "אליפלט"
            }, 
            new City
            {
                Id = 682,
                Name = "אליקים"
            }, 
            new City
            {
                Id = 204,
                Name = "אלישיב"
            }, 
            new City
            {
                Id = 841,
                Name = "אלישמע"
            }, 
            new City
            {
                Id = 1125,
                Name = "אלמגור"
            }, 
            new City
            {
                Id = 3556,
                Name = "אלמוג"
            }, 
            new City
            {
                Id = 1309,
                Name = "אלעד"
            }, 
            new City
            {
                Id = 3618,
                Name = "אלעזר"
            }, 
            new City
            {
                Id = 3750,
                Name = "אלפי מנשה"
            }, 
            new City
            {
                Id = 603,
                Name = "אלקוש"
            }, 
            new City
            {
                Id = 3560,
                Name = "אלקנה"
            }, 
            new City
            {
                Id = 772,
                Name = "אמונים"
            }, 
            new City
            {
                Id = 1064,
                Name = "אמירים"
            }, 
            new City
            {
                Id = 1253,
                Name = "אמנון"
            }, 
            new City
            {
                Id = 23,
                Name = "אמציה"
            }, 
            new City
            {
                Id = 4012,
                Name = "אניעם"
            }, 
            new City
            {
                Id = 960,
                Name = "אסד (שבט)"
            }, 
            new City
            {
                Id = 3754,
                Name = "אספר"
            }, 
            new City
            {
                Id = 529,
                Name = "אעבלין"
            }, 
            new City
            {
                Id = 963,
                Name = "אעצם (שבט)"
            }, 
            new City
            {
                Id = 959,
                Name = "אפיניש (שבט)"
            }, 
            new City
            {
                Id = 4301,
                Name = "אפיק"
            }, 
            new City
            {
                Id = 176,
                Name = "אפיקים"
            }, 
            new City
            {
                Id = 313,
                Name = "אפק"
            }, 
            new City
            {
                Id = 3650,
                Name = "אפרתה"
            }, 
            new City
            {
                Id = 701,
                Name = "ארבל"
            }, 
            new City
            {
                Id = 3598,
                Name = "ארגמן"
            }, 
            new City
            {
                Id = 714,
                Name = "ארז"
            }, 
            new City
            {
                Id = 3570,
                Name = "אריאל"
            }, 
            new City
            {
                Id = 1324,
                Name = "ארסוף"
            }, 
            new City
            {
                Id = 71,
                Name = "אשבול"
            }, 
            new City
            {
                Id = 1276,
                Name = "אשבל"
            }, 
            new City
            {
                Id = 70,
                Name = "אשדוד"
            }, 
            new City
            {
                Id = 199,
                Name = "אשדות יעקב (איחוד)"
            }, 
            new City
            {
                Id = 188,
                Name = "אשדות יעקב (מאוחד)"
            }, 
            new City
            {
                Id = 1188,
                Name = "אשחר"
            }, 
            new City
            {
                Id = 3722,
                Name = "אשכולות"
            }, 
            new City
            {
                Id = 2021,
                Name = "אשל הנשיא"
            }, 
            new City
            {
                Id = 1152,
                Name = "אשלים"
            }, 
            new City
            {
                Id = 7100,
                Name = "אשקלון"
            }, 
            new City
            {
                Id = 1256,
                Name = "אשרת"
            }, 
            new City
            {
                Id = 740,
                Name = "אשתאול"
            }, 
            new City
            {
                Id = 6000,
                Name = "באקה אל-גרביה"
            }, 
            new City
            {
                Id = 21,
                Name = "באר אורה"
            }, 
            new City
            {
                Id = 155,
                Name = "באר טוביה"
            }, 
            new City
            {
                Id = 2530,
                Name = "באר יעקב"
            }, 
            new City
            {
                Id = 1278,
                Name = "באר מילכה"
            }, 
            new City
            {
                Id = 9000,
                Name = "באר שבע"
            }, 
            new City
            {
                Id = 450,
                Name = "בארות יצחק"
            }, 
            new City
            {
                Id = 697,
                Name = "בארותיים"
            }, 
            new City
            {
                Id = 399,
                Name = "בארי"
            }, 
            new City
            {
                Id = 559,
                Name = "בוסתן הגליל"
            }, 
            new City
            {
                Id = 482,
                Name = "בועיינה-נוג'ידאת"
            }, 
            new City
            {
                Id = 4001,
                Name = "בוקעאתא"
            }, 
            new City
            {
                Id = 698,
                Name = "בורגתה"
            }, 
            new City
            {
                Id = 2043,
                Name = "בחן"
            }, 
            new City
            {
                Id = 762,
                Name = "בטחה"
            }, 
            new City
            {
                Id = 1725,
                Name = "בי\"ס אזורי מקיף (אשר)"
            }, 
            new City
            {
                Id = 234,
                Name = "ביצרון"
            }, 
            new City
            {
                Id = 998,
                Name = "ביר אל-מכסור"
            }, 
            new City
            {
                Id = 1348,
                Name = "ביר הדאג'"
            }, 
            new City
            {
                Id = 368,
                Name = "בירייה"
            }, 
            new City
            {
                Id = 317,
                Name = "בית אורן"
            }, 
            new City
            {
                Id = 3574,
                Name = "בית אל"
            }, 
            new City
            {
                Id = 562,
                Name = "בית אלעזרי"
            }, 
            new City
            {
                Id = 95,
                Name = "בית אלפא"
            }, 
            new City
            {
                Id = 3652,
                Name = "בית אריה"
            }, 
            new City
            {
                Id = 1076,
                Name = "בית ברל"
            }, 
            new City
            {
                Id = 619,
                Name = "בית גוברין"
            }, 
            new City
            {
                Id = 571,
                Name = "בית גמליאל"
            }, 
            new City
            {
                Id = 480,
                Name = "בית ג'ן"
            }, 
            new City
            {
                Id = 466,
                Name = "בית דגן"
            }, 
            new City
            {
                Id = 723,
                Name = "בית הגדי"
            }, 
            new City
            {
                Id = 373,
                Name = "בית הלוי"
            }, 
            new City
            {
                Id = 322,
                Name = "בית הלל"
            }, 
            new City
            {
                Id = 572,
                Name = "בית העמק"
            }, 
            new City
            {
                Id = 3645,
                Name = "בית הערבה"
            }, 
            new City
            {
                Id = 242,
                Name = "בית השיטה"
            }, 
            new City
            {
                Id = 353,
                Name = "בית זיד"
            }, 
            new City
            {
                Id = 710,
                Name = "בית זית"
            }, 
            new City
            {
                Id = 143,
                Name = "בית זרע"
            }, 
            new City
            {
                Id = 1712,
                Name = "בית חולים פוריה"
            }, 
            new City
            {
                Id = 3575,
                Name = "בית חורון"
            }, 
            new City
            {
                Id = 877,
                Name = "בית חירות"
            }, 
            new City
            {
                Id = 2033,
                Name = "בית חלקיה"
            }, 
            new City
            {
                Id = 159,
                Name = "בית חנן"
            }, 
            new City
            {
                Id = 800,
                Name = "בית חנניה"
            }, 
            new City
            {
                Id = 1050,
                Name = "בית חשמונאי"
            }, 
            new City
            {
                Id = 288,
                Name = "בית יהושע"
            }, 
            new City
            {
                Id = 265,
                Name = "בית יוסף"
            }, 
            new City
            {
                Id = 200,
                Name = "בית ינאי"
            }, 
            new City
            {
                Id = 326,
                Name = "בית יצחק-שער חפר"
            }, 
            new City
            {
                Id = 430,
                Name = "בית לחם הגלילית"
            }, 
            new City
            {
                Id = 751,
                Name = "בית מאיר"
            }, 
            new City
            {
                Id = 784,
                Name = "בית נחמיה"
            }, 
            new City
            {
                Id = 16,
                Name = "בית ניר"
            }, 
            new City
            {
                Id = 672,
                Name = "בית נקופה"
            }, 
            new City
            {
                Id = 202,
                Name = "בית עובד"
            }, 
            new City
            {
                Id = 301,
                Name = "בית עוזיאל"
            }, 
            new City
            {
                Id = 756,
                Name = "בית עזרא"
            }, 
            new City
            {
                Id = 604,
                Name = "בית עריף"
            }, 
            new City
            {
                Id = 212,
                Name = "בית צבי"
            }, 
            new City
            {
                Id = 598,
                Name = "בית קמה"
            }, 
            new City
            {
                Id = 365,
                Name = "בית קשת"
            }, 
            new City
            {
                Id = 848,
                Name = "בית רבן"
            }, 
            new City
            {
                Id = 1162,
                Name = "בית רימון"
            }, 
            new City
            {
                Id = 9200,
                Name = "בית שאן"
            }, 
            new City
            {
                Id = 2610,
                Name = "בית שמש"
            }, 
            new City
            {
                Id = 248,
                Name = "בית שערים"
            }, 
            new City
            {
                Id = 747,
                Name = "בית שקמה"
            }, 
            new City
            {
                Id = 252,
                Name = "ביתן אהרן"
            }, 
            new City
            {
                Id = 3780,
                Name = "ביתר עילית"
            }, 
            new City
            {
                Id = 94,
                Name = "בלפוריה"
            }, 
            new City
            {
                Id = 760,
                Name = "בן זכאי"
            }, 
            new City
            {
                Id = 712,
                Name = "בן עמי"
            }, 
            new City
            {
                Id = 1084,
                Name = "בן שמן (כפר נוער)"
            }, 
            new City
            {
                Id = 2013,
                Name = "בן שמן (מושב)"
            }, 
            new City
            {
                Id = 6100,
                Name = "בני ברק"
            }, 
            new City
            {
                Id = 592,
                Name = "בני דרום"
            }, 
            new City
            {
                Id = 386,
                Name = "בני דרור"
            }, 
            new City
            {
                Id = 4015,
                Name = "בני יהודה"
            }, 
            new City
            {
                Id = 1363,
                Name = "בני נצרים"
            }, 
            new City
            {
                Id = 448,
                Name = "בני עטרות"
            }, 
            new City
            {
                Id = 1066,
                Name = "בני עי\"ש"
            }, 
            new City
            {
                Id = 418,
                Name = "בני ציון"
            }, 
            new City
            {
                Id = 588,
                Name = "בני ראם"
            }, 
            new City
            {
                Id = 685,
                Name = "בניה"
            }, 
            new City
            {
                Id = 9800,
                Name = "בנימינה-גבעת עדה*"
            }, 
            new City
            {
                Id = 1326,
                Name = "בסמ\"ה"
            }, 
            new City
            {
                Id = 944,
                Name = "בסמת טבעון"
            }, 
            new City
            {
                Id = 483,
                Name = "בענה"
            }, 
            new City
            {
                Id = 389,
                Name = "בצרה"
            }, 
            new City
            {
                Id = 589,
                Name = "בצת"
            }, 
            new City
            {
                Id = 864,
                Name = "בקוע"
            }, 
            new City
            {
                Id = 3612,
                Name = "בקעות"
            }, 
            new City
            {
                Id = 1854,
                Name = "בקעת נטופה מ\"א 56"
            }, 
            new City
            {
                Id = 1884,
                Name = "בקעת תירען מ\"א 3"
            }, 
            new City
            {
                Id = 823,
                Name = "בר גיורא"
            }, 
            new City
            {
                Id = 1191,
                Name = "בר יוחאי"
            }, 
            new City
            {
                Id = 428,
                Name = "ברור חיל"
            }, 
            new City
            {
                Id = 2060,
                Name = "ברוש"
            }, 
            new City
            {
                Id = 3710,
                Name = "ברכה"
            }, 
            new City
            {
                Id = 746,
                Name = "ברכיה"
            }, 
            new City
            {
                Id = 667,
                Name = "ברעם"
            }, 
            new City
            {
                Id = 141,
                Name = "ברק"
            }, 
            new City
            {
                Id = 617,
                Name = "ברקאי"
            }, 
            new City
            {
                Id = 3654,
                Name = "ברקן"
            }, 
            new City
            {
                Id = 2038,
                Name = "ברקת"
            }, 
            new City
            {
                Id = 1323,
                Name = "בת הדר"
            }, 
            new City
            {
                Id = 1361,
                Name = "בת חן"
            }, 
            new City
            {
                Id = 1319,
                Name = "בת חפר"
            }, 
            new City
            {
                Id = 6200,
                Name = "בת ים"
            }, 
            new City
            {
                Id = 3794,
                Name = "בת עין"
            }, 
            new City
            {
                Id = 33,
                Name = "בת שלמה"
            }, 
            new City
            {
                Id = 1736,
                Name = "בתי זיקוק - קישון*"
            }, 
            new City
            {
                Id = 872,
                Name = "גאולי תימן"
            }, 
            new City
            {
                Id = 379,
                Name = "גאולים"
            }, 
            new City
            {
                Id = 1963,
                Name = "גאון הירדן מ\"א 3"
            }, 
            new City
            {
                Id = 853,
                Name = "גאליה"
            }, 
            new City
            {
                Id = 352,
                Name = "גבולות"
            }, 
            new City
            {
                Id = 424,
                Name = "גבים"
            }, 
            new City
            {
                Id = 86,
                Name = "גבע"
            }, 
            new City
            {
                Id = 3763,
                Name = "גבע בנימין"
            }, 
            new City
            {
                Id = 683,
                Name = "גבע כרמל"
            }, 
            new City
            {
                Id = 2014,
                Name = "גבעולים"
            }, 
            new City
            {
                Id = 3644,
                Name = "גבעון החדשה"
            }, 
            new City
            {
                Id = 1344,
                Name = "גבעות בר"
            }, 
            new City
            {
                Id = 1293,
                Name = "גבעת אבני"
            }, 
            new City
            {
                Id = 1288,
                Name = "גבעת אלה"
            }, 
            new City
            {
                Id = 147,
                Name = "גבעת ברנר"
            }, 
            new City
            {
                Id = 870,
                Name = "גבעת השלושה"
            }, 
            new City
            {
                Id = 3730,
                Name = "גבעת זאב"
            }, 
            new City
            {
                Id = 207,
                Name = "גבעת ח\"ן"
            }, 
            new City
            {
                Id = 1740,
                Name = "גבעת חביבה"
            }, 
            new City
            {
                Id = 2018,
                Name = "גבעת חיים (איחוד)"
            }, 
            new City
            {
                Id = 173,
                Name = "גבעת חיים (מאוחד)"
            }, 
            new City
            {
                Id = 4021,
                Name = "גבעת יואב"
            }, 
            new City
            {
                Id = 787,
                Name = "גבעת יערים"
            }, 
            new City
            {
                Id = 919,
                Name = "גבעת ישעיהו"
            }, 
            new City
            {
                Id = 802,
                Name = "גבעת כ\"ח"
            }, 
            new City
            {
                Id = 360,
                Name = "גבעת ניל\"י"
            }, 
            new City
            {
                Id = 703,
                Name = "גבעת עוז"
            }, 
            new City
            {
                Id = 681,
                Name = "גבעת שמואל"
            }, 
            new City
            {
                Id = 566,
                Name = "גבעת שמש"
            }, 
            new City
            {
                Id = 1077,
                Name = "גבעת שפירא"
            }, 
            new City
            {
                Id = 793,
                Name = "גבעתי"
            }, 
            new City
            {
                Id = 6300,
                Name = "גבעתיים"
            }, 
            new City
            {
                Id = 342,
                Name = "גברעם"
            }, 
            new City
            {
                Id = 133,
                Name = "גבת"
            }, 
            new City
            {
                Id = 35,
                Name = "גדות"
            }, 
            new City
            {
                Id = 1292,
                Name = "ג'דיידה-מכר"
            }, 
            new City
            {
                Id = 145,
                Name = "גדיש"
            }, 
            new City
            {
                Id = 442,
                Name = "גדעונה"
            }, 
            new City
            {
                Id = 2550,
                Name = "גדרה"
            }, 
            new City
            {
                Id = 1966,
                Name = "גולן דרומי מ\"א 71"
            }, 
            new City
            {
                Id = 1962,
                Name = "גולן צפוני מ\"א 71"
            }, 
            new City
            {
                Id = 1964,
                Name = "גולן תיכון מ\"א 71"
            }, 
            new City
            {
                Id = 485,
                Name = "ג'ולס"
            }, 
            new City
            {
                Id = 852,
                Name = "גונן"
            }, 
            new City
            {
                Id = 755,
                Name = "גורן"
            }, 
            new City
            {
                Id = 1219,
                Name = "גורנות הגליל"
            }, 
            new City
            {
                Id = 457,
                Name = "גזית"
            }, 
            new City
            {
                Id = 370,
                Name = "גזר"
            }, 
            new City
            {
                Id = 706,
                Name = "גיאה"
            }, 
            new City
            {
                Id = 196,
                Name = "גיבתון"
            }, 
            new City
            {
                Id = 1043,
                Name = "גיזו"
            }, 
            new City
            {
                Id = 1204,
                Name = "גילון"
            }, 
            new City
            {
                Id = 736,
                Name = "גילת"
            }, 
            new City
            {
                Id = 262,
                Name = "גינוסר"
            }, 
            new City
            {
                Id = 92,
                Name = "גיניגר"
            }, 
            new City
            {
                Id = 863,
                Name = "גינתון"
            }, 
            new City
            {
                Id = 1206,
                Name = "גיתה"
            }, 
            new City
            {
                Id = 3613,
                Name = "גיתית"
            }, 
            new City
            {
                Id = 393,
                Name = "גלאון"
            }, 
            new City
            {
                Id = 627,
                Name = "ג'לג'וליה"
            }, 
            new City
            {
                Id = 3606,
                Name = "גלגל"
            }, 
            new City
            {
                Id = 346,
                Name = "גליל ים"
            }, 
            new City
            {
                Id = 1809,
                Name = "גליל עליון מז מ\"א 1"
            }, 
            new City
            {
                Id = 1811,
                Name = "גליל עליון מז מ\"א 2"
            }, 
            new City
            {
                Id = 1810,
                Name = "גליל עליון מז מ\"א 55"
            }, 
            new City
            {
                Id = 1812,
                Name = "גליל עליון מז של\"ש"
            }, 
            new City
            {
                Id = 1820,
                Name = "גליל תחתון מז מ\"א 2"
            }, 
            new City
            {
                Id = 1819,
                Name = "גליל תחתון מז מ\"א 3"
            }, 
            new City
            {
                Id = 1821,
                Name = "גליל תחתון מז מ\"א 6"
            }, 
            new City
            {
                Id = 1822,
                Name = "גליל תחתון מז של\"ש"
            }, 
            new City
            {
                Id = 369,
                Name = "גלעד (אבן יצחק)"
            }, 
            new City
            {
                Id = 1997,
                Name = "גמ\"ל מחוז דרום"
            }, 
            new City
            {
                Id = 745,
                Name = "גמזו"
            }, 
            new City
            {
                Id = 1072,
                Name = "גן הדרום"
            }, 
            new City
            {
                Id = 225,
                Name = "גן השומרון"
            }, 
            new City
            {
                Id = 239,
                Name = "גן חיים"
            }, 
            new City
            {
                Id = 734,
                Name = "גן יאשיה"
            }, 
            new City
            {
                Id = 166,
                Name = "גן יבנה"
            }, 
            new City
            {
                Id = 1274,
                Name = "גן נר"
            }, 
            new City
            {
                Id = 311,
                Name = "גן שורק"
            }, 
            new City
            {
                Id = 144,
                Name = "גן שלמה"
            }, 
            new City
            {
                Id = 72,
                Name = "גן שמואל"
            }, 
            new City
            {
                Id = 976,
                Name = "ג'נאביב (שבט)"
            }, 
            new City
            {
                Id = 836,
                Name = "גנות"
            }, 
            new City
            {
                Id = 549,
                Name = "גנות הדר"
            }, 
            new City
            {
                Id = 1103,
                Name = "גני הדר"
            }, 
            new City
            {
                Id = 1371,
                Name = "גני טל"
            }, 
            new City
            {
                Id = 862,
                Name = "גני יוחנן"
            }, 
            new City
            {
                Id = 218,
                Name = "גני עם"
            }, 
            new City
            {
                Id = 229,
                Name = "גני תקווה"
            }, 
            new City
            {
                Id = 541,
                Name = "ג'סר א-זרקא"
            }, 
            new City
            {
                Id = 842,
                Name = "געש"
            }, 
            new City
            {
                Id = 463,
                Name = "געתון"
            }, 
            new City
            {
                Id = 39,
                Name = "גפן"
            }, 
            new City
            {
                Id = 1129,
                Name = "גרופית"
            }, 
            new City
            {
                Id = 487,
                Name = "ג'ש (גוש חלב)"
            }, 
            new City
            {
                Id = 4022,
                Name = "גשור"
            }, 
            new City
            {
                Id = 305,
                Name = "גשר"
            }, 
            new City
            {
                Id = 574,
                Name = "גשר הזיו"
            }, 
            new City
            {
                Id = 628,
                Name = "ג'ת"
            }, 
            new City
            {
                Id = 340,
                Name = "גת (קיבוץ)"
            }, 
            new City
            {
                Id = 128,
                Name = "גת רימון"
            }, 
            new City
            {
                Id = 494,
                Name = "דאלית אל-כרמל"
            }, 
            new City
            {
                Id = 146,
                Name = "דבורה"
            }, 
            new City
            {
                Id = 489,
                Name = "דבורייה"
            }, 
            new City
            {
                Id = 849,
                Name = "דבירה"
            }, 
            new City
            {
                Id = 407,
                Name = "דברת"
            }, 
            new City
            {
                Id = 62,
                Name = "דגניה א'"
            }, 
            new City
            {
                Id = 79,
                Name = "דגניה ב'"
            }, 
            new City
            {
                Id = 1067,
                Name = "דוב\"ב"
            }, 
            new City
            {
                Id = 3747,
                Name = "דולב"
            }, 
            new City
            {
                Id = 738,
                Name = "דור"
            }, 
            new City
            {
                Id = 336,
                Name = "דורות"
            }, 
            new City
            {
                Id = 475,
                Name = "דחי"
            }, 
            new City
            {
                Id = 490,
                Name = "דייר אל-אסד"
            }, 
            new City
            {
                Id = 492,
                Name = "דייר חנא"
            }, 
            new City
            {
                Id = 493,
                Name = "דייר ראפאת"
            }, 
            new City
            {
                Id = 2200,
                Name = "דימונה"
            }, 
            new City
            {
                Id = 2063,
                Name = "דישון"
            }, 
            new City
            {
                Id = 300,
                Name = "דלייה"
            }, 
            new City
            {
                Id = 431,
                Name = "דלתון"
            }, 
            new City
            {
                Id = 1317,
                Name = "דמיידה"
            }, 
            new City
            {
                Id = 303,
                Name = "דן"
            }, 
            new City
            {
                Id = 302,
                Name = "דפנה"
            }, 
            new City
            {
                Id = 1241,
                Name = "דקל"
            }, 
            new City
            {
                Id = 1881,
                Name = "דרום השרון מ\"א 18"
            }, 
            new City
            {
                Id = 1882,
                Name = "דרום השרון מ\"א 20"
            }, 
            new City
            {
                Id = 1885,
                Name = "דרום השרון של\"ש"
            }, 
            new City
            {
                Id = 1998,
                Name = "דרום יהודה"
            }, 
            new City
            {
                Id = 1349,
                Name = "דריג'את"
            }, 
            new City
            {
                Id = 702,
                Name = "האון"
            }, 
            new City
            {
                Id = 675,
                Name = "הבונים"
            }, 
            new City
            {
                Id = 356,
                Name = "הגושרים"
            }, 
            new City
            {
                Id = 191,
                Name = "הדר עם"
            }, 
            new City
            {
                Id = 9700,
                Name = "הוד השרון"
            }, 
            new City
            {
                Id = 1322,
                Name = "הודיות"
            }, 
            new City
            {
                Id = 726,
                Name = "הודייה"
            }, 
            new City
            {
                Id = 1169,
                Name = "הוואשלה (שבט)"
            }, 
            new City
            {
                Id = 956,
                Name = "הוזייל (שבט)"
            }, 
            new City
            {
                Id = 1186,
                Name = "הושעיה"
            }, 
            new City
            {
                Id = 250,
                Name = "הזורע"
            }, 
            new City
            {
                Id = 307,
                Name = "הזורעים"
            }, 
            new City
            {
                Id = 434,
                Name = "החותרים"
            }, 
            new City
            {
                Id = 684,
                Name = "היוגב"
            }, 
            new City
            {
                Id = 1208,
                Name = "הילה"
            }, 
            new City
            {
                Id = 377,
                Name = "המעפיל"
            }, 
            new City
            {
                Id = 1751,
                Name = "המרכז למחקר-נחל שורק"
            }, 
            new City
            {
                Id = 677,
                Name = "הסוללים"
            }, 
            new City
            {
                Id = 423,
                Name = "העוגן"
            }, 
            new City
            {
                Id = 1944,
                Name = "הערבה מ\"א 51"
            }, 
            new City
            {
                Id = 1945,
                Name = "הערבה מ\"א 53"
            }, 
            new City
            {
                Id = 1946,
                Name = "הערבה מ\"א 54"
            }, 
            new City
            {
                Id = 3769,
                Name = "הר אדר"
            }, 
            new City
            {
                Id = 1869,
                Name = "הר אלכסנדר מ\"א 14"
            }, 
            new City
            {
                Id = 1868,
                Name = "הר אלכסנדר מ\"א 45"
            }, 
            new City
            {
                Id = 1870,
                Name = "הר אלכסנדר של\"ש"
            }, 
            new City
            {
                Id = 3603,
                Name = "הר גילה"
            }, 
            new City
            {
                Id = 1953,
                Name = "הר הנגב הדרומי מ\"א 48"
            }, 
            new City
            {
                Id = 1951,
                Name = "הר הנגב הדרומי מ\"א 53"
            }, 
            new City
            {
                Id = 1952,
                Name = "הר הנגב הדרומי מ\"א 54"
            }, 
            new City
            {
                Id = 1948,
                Name = "הר הנגב הצפוני מ\"א 48"
            }, 
            new City
            {
                Id = 1949,
                Name = "הר הנגב הצפוני מ\"א 51"
            }, 
            new City
            {
                Id = 1947,
                Name = "הר הנגב הצפוני מ\"א 53"
            }, 
            new City
            {
                Id = 1950,
                Name = "הר הנגב הצפוני מ\"א 54"
            }, 
            new City
            {
                Id = 1261,
                Name = "הר עמשא"
            }, 
            new City
            {
                Id = 464,
                Name = "הראל"
            }, 
            new City
            {
                Id = 1249,
                Name = "הרדוף"
            }, 
            new City
            {
                Id = 1801,
                Name = "הרי יהודה מ\"א 26"
            }, 
            new City
            {
                Id = 1802,
                Name = "הרי יהודה של\"ש"
            }, 
            new City
            {
                Id = 1823,
                Name = "הרי נצרת-תירען"
            }, 
            new City
            {
                Id = 1839,
                Name = "הרי נצרת-תירען מ\"א 9"
            }, 
            new City
            {
                Id = 6400,
                Name = "הרצלייה"
            }, 
            new City
            {
                Id = 1203,
                Name = "הררית"
            }, 
            new City
            {
                Id = 1999,
                Name = "השומרון"
            }, 
            new City
            {
                Id = 3639,
                Name = "ורד יריחו"
            }, 
            new City
            {
                Id = 1133,
                Name = "ורדון"
            }, 
            new City
            {
                Id = 2742,
                Name = "זבארגה (שבט)"
            }, 
            new City
            {
                Id = 815,
                Name = "זבדיאל"
            }, 
            new City
            {
                Id = 44,
                Name = "זוהר"
            }, 
            new City
            {
                Id = 584,
                Name = "זיקים"
            }, 
            new City
            {
                Id = 788,
                Name = "זיתן"
            }, 
            new City
            {
                Id = 9300,
                Name = "זכרון יעקב"
            }, 
            new City
            {
                Id = 799,
                Name = "זכריה"
            }, 
            new City
            {
                Id = 1290,
                Name = "זמר"
            }, 
            new City
            {
                Id = 1065,
                Name = "זמרת"
            }, 
            new City
            {
                Id = 816,
                Name = "זנוח"
            }, 
            new City
            {
                Id = 2064,
                Name = "זרועה"
            }, 
            new City
            {
                Id = 975,
                Name = "זרזיר"
            }, 
            new City
            {
                Id = 818,
                Name = "זרחיה"
            }, 
            new City
            {
                Id = 235,
                Name = "חבצלת השרון"
            }, 
            new City
            {
                Id = 1110,
                Name = "חבר"
            }, 
            new City
            {
                Id = 717,
                Name = "חגור"
            }, 
            new City
            {
                Id = 3764,
                Name = "חגי"
            }, 
            new City
            {
                Id = 205,
                Name = "חגלה"
            }, 
            new City
            {
                Id = 618,
                Name = "חדיד"
            }, 
            new City
            {
                Id = 4026,
                Name = "חד-נס"
            }, 
            new City
            {
                Id = 6500,
                Name = "חדרה"
            }, 
            new City
            {
                Id = 1321,
                Name = "ח'ואלד"
            }, 
            new City
            {
                Id = 986,
                Name = "ח'ואלד (שבט)"
            }, 
            new City
            {
                Id = 948,
                Name = "חוג'ייראת (ד'הרה) (שבט)"
            }, 
            new City
            {
                Id = 160,
                Name = "חולדה"
            }, 
            new City
            {
                Id = 6600,
                Name = "חולון"
            }, 
            new City
            {
                Id = 1239,
                Name = "חולית"
            }, 
            new City
            {
                Id = 253,
                Name = "חולתה"
            }, 
            new City
            {
                Id = 662,
                Name = "חוסן"
            }, 
            new City
            {
                Id = 1332,
                Name = "חוסנייה"
            }, 
            new City
            {
                Id = 1864,
                Name = "חוף הכרמל מ\"א 15"
            }, 
            new City
            {
                Id = 115,
                Name = "חופית"
            }, 
            new City
            {
                Id = 374,
                Name = "חוקוק"
            }, 
            new City
            {
                Id = 1303,
                Name = "חורה"
            }, 
            new City
            {
                Id = 496,
                Name = "חורפיש"
            }, 
            new City
            {
                Id = 355,
                Name = "חורשים"
            }, 
            new City
            {
                Id = 1047,
                Name = "חזון"
            }, 
            new City
            {
                Id = 219,
                Name = "חיבת ציון"
            }, 
            new City
            {
                Id = 3643,
                Name = "חיננית"
            }, 
            new City
            {
                Id = 4000,
                Name = "חיפה"
            }, 
            new City
            {
                Id = 162,
                Name = "חירות"
            }, 
            new City
            {
                Id = 1272,
                Name = "חלוץ"
            }, 
            new City
            {
                Id = 3573,
                Name = "חלמיש"
            }, 
            new City
            {
                Id = 820,
                Name = "חלץ"
            }, 
            new City
            {
                Id = 993,
                Name = "חמאם"
            }, 
            new City
            {
                Id = 801,
                Name = "חמד"
            }, 
            new City
            {
                Id = 343,
                Name = "חמדיה"
            }, 
            new City
            {
                Id = 3646,
                Name = "חמדת"
            }, 
            new City
            {
                Id = 3609,
                Name = "חמרה"
            }, 
            new City
            {
                Id = 807,
                Name = "חניאל"
            }, 
            new City
            {
                Id = 280,
                Name = "חניתה"
            }, 
            new City
            {
                Id = 1257,
                Name = "חנתון"
            }, 
            new City
            {
                Id = 4005,
                Name = "חספין"
            }, 
            new City
            {
                Id = 363,
                Name = "חפץ חיים"
            }, 
            new City
            {
                Id = 90,
                Name = "חפצי-בה"
            }, 
            new City
            {
                Id = 700,
                Name = "חצב"
            }, 
            new City
            {
                Id = 13,
                Name = "חצבה"
            }, 
            new City
            {
                Id = 2034,
                Name = "חצור הגלילית"
            }, 
            new City
            {
                Id = 406,
                Name = "חצור-אשדוד"
            }, 
            new City
            {
                Id = 397,
                Name = "חצרים"
            }, 
            new City
            {
                Id = 422,
                Name = "חרב לאת"
            }, 
            new City
            {
                Id = 1024,
                Name = "חרוצים"
            }, 
            new City
            {
                Id = 1960,
                Name = "חרמון מ\"א 71"
            }, 
            new City
            {
                Id = 3717,
                Name = "חרמש"
            }, 
            new City
            {
                Id = 1209,
                Name = "חרשים"
            }, 
            new City
            {
                Id = 3770,
                Name = "חשמונאים"
            }, 
            new City
            {
                Id = 6700,
                Name = "טבריה"
            }, 
            new City
            {
                Id = 962,
                Name = "טובא-זנגרייה"
            }, 
            new City
            {
                Id = 498,
                Name = "טורעאן"
            }, 
            new City
            {
                Id = 2730,
                Name = "טייבה"
            }, 
            new City
            {
                Id = 497,
                Name = "טייבה (בעמק)"
            }, 
            new City
            {
                Id = 2720,
                Name = "טירה"
            }, 
            new City
            {
                Id = 663,
                Name = "טירת יהודה"
            }, 
            new City
            {
                Id = 2100,
                Name = "טירת כרמל"
            }, 
            new City
            {
                Id = 268,
                Name = "טירת צבי"
            }, 
            new City
            {
                Id = 462,
                Name = "טל שחר"
            }, 
            new City
            {
                Id = 1181,
                Name = "טל-אל"
            }, 
            new City
            {
                Id = 1177,
                Name = "טללים"
            }, 
            new City
            {
                Id = 3788,
                Name = "טלמון"
            }, 
            new City
            {
                Id = 8900,
                Name = "טמרה"
            }, 
            new City
            {
                Id = 547,
                Name = "טמרה (יזרעאל)"
            }, 
            new City
            {
                Id = 3743,
                Name = "טנא"
            }, 
            new City
            {
                Id = 1214,
                Name = "טפחות"
            }, 
            new City
            {
                Id = 1295,
                Name = "יאנוח-ג'ת"
            }, 
            new City
            {
                Id = 1232,
                Name = "יבול"
            }, 
            new City
            {
                Id = 46,
                Name = "יבנאל"
            }, 
            new City
            {
                Id = 2660,
                Name = "יבנה"
            }, 
            new City
            {
                Id = 96,
                Name = "יגור"
            }, 
            new City
            {
                Id = 798,
                Name = "יגל"
            }, 
            new City
            {
                Id = 577,
                Name = "יד בנימין"
            }, 
            new City
            {
                Id = 1134,
                Name = "יד השמונה"
            }, 
            new City
            {
                Id = 758,
                Name = "יד חנה"
            }, 
            new City
            {
                Id = 358,
                Name = "יד מרדכי"
            }, 
            new City
            {
                Id = 775,
                Name = "יד נתן"
            }, 
            new City
            {
                Id = 64,
                Name = "יד רמב\"ם"
            }, 
            new City
            {
                Id = 1144,
                Name = "ידידה"
            }, 
            new City
            {
                Id = 9400,
                Name = "יהוד"
            }, 
            new City
            {
                Id = 1158,
                Name = "יהל"
            }, 
            new City
            {
                Id = 2009,
                Name = "יובל"
            }, 
            new City
            {
                Id = 1226,
                Name = "יובלים"
            }, 
            new City
            {
                Id = 1112,
                Name = "יודפת"
            }, 
            new City
            {
                Id = 4007,
                Name = "יונתן"
            }, 
            new City
            {
                Id = 803,
                Name = "יושיביה"
            }, 
            new City
            {
                Id = 452,
                Name = "יזרעאל"
            }, 
            new City
            {
                Id = 409,
                Name = "יחיעם"
            }, 
            new City
            {
                Id = 866,
                Name = "יטבתה"
            }, 
            new City
            {
                Id = 3607,
                Name = "ייט\"ב"
            }, 
            new City
            {
                Id = 811,
                Name = "יכיני"
            }, 
            new City
            {
                Id = 1772,
                Name = "ים המלח - בתי מלון"
            }, 
            new City
            {
                Id = 753,
                Name = "ינוב"
            }, 
            new City
            {
                Id = 2011,
                Name = "ינון"
            }, 
            new City
            {
                Id = 29,
                Name = "יסוד המעלה"
            }, 
            new City
            {
                Id = 440,
                Name = "יסודות"
            }, 
            new City
            {
                Id = 575,
                Name = "יסעור"
            }, 
            new City
            {
                Id = 1138,
                Name = "יעד"
            }, 
            new City
            {
                Id = 1117,
                Name = "יעל"
            }, 
            new City
            {
                Id = 1044,
                Name = "יעף"
            }, 
            new City
            {
                Id = 795,
                Name = "יערה"
            }, 
            new City
            {
                Id = 1863,
                Name = "יערות גבעת המורה מ\"א 9"
            }, 
            new City
            {
                Id = 499,
                Name = "יפיע"
            }, 
            new City
            {
                Id = 3566,
                Name = "יפית"
            }, 
            new City
            {
                Id = 134,
                Name = "יפעת"
            }, 
            new City
            {
                Id = 453,
                Name = "יפתח"
            }, 
            new City
            {
                Id = 3749,
                Name = "יצהר"
            }, 
            new City
            {
                Id = 759,
                Name = "יציץ"
            }, 
            new City
            {
                Id = 417,
                Name = "יקום"
            }, 
            new City
            {
                Id = 3647,
                Name = "יקיר"
            }, 
            new City
            {
                Id = 241,
                Name = "יקנעם (מושבה)"
            }, 
            new City
            {
                Id = 240,
                Name = "יקנעם עילית"
            }, 
            new City
            {
                Id = 623,
                Name = "יראון"
            }, 
            new City
            {
                Id = 2026,
                Name = "ירדנה"
            }, 
            new City
            {
                Id = 831,
                Name = "ירוחם"
            }, 
            new City
            {
                Id = 3000,
                Name = "ירושלים"
            }, 
            new City
            {
                Id = 718,
                Name = "ירחיב"
            }, 
            new City
            {
                Id = 502,
                Name = "ירכא"
            }, 
            new City
            {
                Id = 183,
                Name = "ירקונה"
            }, 
            new City
            {
                Id = 916,
                Name = "ישע"
            }, 
            new City
            {
                Id = 805,
                Name = "ישעי"
            }, 
            new City
            {
                Id = 828,
                Name = "ישרש"
            }, 
            new City
            {
                Id = 1227,
                Name = "יתד"
            }, 
            new City
            {
                Id = 504,
                Name = "כאבול"
            }, 
            new City
            {
                Id = 505,
                Name = "כאוכב אבו אל-היג'א"
            }, 
            new City
            {
                Id = 576,
                Name = "כברי"
            }, 
            new City
            {
                Id = 371,
                Name = "כדורי"
            }, 
            new City
            {
                Id = 1338,
                Name = "כדיתה"
            }, 
            new City
            {
                Id = 3564,
                Name = "כוכב השחר"
            }, 
            new City
            {
                Id = 1224,
                Name = "כוכב יאיר"
            }, 
            new City
            {
                Id = 3779,
                Name = "כוכב יעקב"
            }, 
            new City
            {
                Id = 824,
                Name = "כוכב מיכאל"
            }, 
            new City
            {
                Id = 1252,
                Name = "כורזים"
            }, 
            new City
            {
                Id = 1210,
                Name = "כחל"
            }, 
            new City
            {
                Id = 1367,
                Name = "כחלה"
            }, 
            new City
            {
                Id = 840,
                Name = "כיסופים"
            }, 
            new City
            {
                Id = 1153,
                Name = "כישור"
            }, 
            new City
            {
                Id = 1183,
                Name = "כליל"
            }, 
            new City
            {
                Id = 1229,
                Name = "כלנית"
            }, 
            new City
            {
                Id = 1331,
                Name = "כמאנה"
            }, 
            new City
            {
                Id = 1291,
                Name = "כמהין"
            }, 
            new City
            {
                Id = 1201,
                Name = "כמון"
            }, 
            new City
            {
                Id = 2006,
                Name = "כנות"
            }, 
            new City
            {
                Id = 4028,
                Name = "כנף"
            }, 
            new City
            {
                Id = 63,
                Name = "כנרת (מושבה)"
            }, 
            new City
            {
                Id = 57,
                Name = "כנרת (קבוצה)"
            }, 
            new City
            {
                Id = 1059,
                Name = "כסיפה"
            }, 
            new City
            {
                Id = 859,
                Name = "כסלון"
            }, 
            new City
            {
                Id = 1296,
                Name = "כסרא-סמיע"
            }, 
            new City
            {
                Id = 978,
                Name = "כעביה-טבאש-חג'אג'רה"
            }, 
            new City
            {
                Id = 857,
                Name = "כפר אביב"
            }, 
            new City
            {
                Id = 3638,
                Name = "כפר אדומים"
            }, 
            new City
            {
                Id = 364,
                Name = "כפר אוריה"
            }, 
            new City
            {
                Id = 690,
                Name = "כפר אחים"
            }, 
            new City
            {
                Id = 220,
                Name = "כפר ביאליק"
            }, 
            new City
            {
                Id = 177,
                Name = "כפר ביל\"ו"
            }, 
            new City
            {
                Id = 357,
                Name = "כפר בלום"
            }, 
            new City
            {
                Id = 2010,
                Name = "כפר בן נון"
            }, 
            new City
            {
                Id = 633,
                Name = "כפר ברא"
            }, 
            new City
            {
                Id = 132,
                Name = "כפר ברוך"
            }, 
            new City
            {
                Id = 106,
                Name = "כפר גדעון"
            }, 
            new City
            {
                Id = 427,
                Name = "כפר גלים"
            }, 
            new City
            {
                Id = 310,
                Name = "כפר גליקסון"
            }, 
            new City
            {
                Id = 76,
                Name = "כפר גלעדי"
            }, 
            new City
            {
                Id = 707,
                Name = "כפר דניאל"
            }, 
            new City
            {
                Id = 3796,
                Name = "כפר האורנים"
            }, 
            new City
            {
                Id = 192,
                Name = "כפר החורש"
            }, 
            new City
            {
                Id = 254,
                Name = "כפר המכבי"
            }, 
            new City
            {
                Id = 582,
                Name = "כפר הנגיד"
            }, 
            new City
            {
                Id = 890,
                Name = "כפר הנוער הדתי"
            }, 
            new City
            {
                Id = 443,
                Name = "כפר הנשיא"
            }, 
            new City
            {
                Id = 187,
                Name = "כפר הס"
            }, 
            new City
            {
                Id = 217,
                Name = "כפר הרא\"ה"
            }, 
            new City
            {
                Id = 888,
                Name = "כפר הרי\"ף"
            }, 
            new City
            {
                Id = 190,
                Name = "כפר ויתקין"
            }, 
            new City
            {
                Id = 320,
                Name = "כפר ורבורג"
            }, 
            new City
            {
                Id = 1263,
                Name = "כפר ורדים"
            }, 
            new City
            {
                Id = 1325,
                Name = "כפר זוהרים"
            }, 
            new City
            {
                Id = 786,
                Name = "כפר זיתים"
            }, 
            new City
            {
                Id = 696,
                Name = "כפר חב\"ד"
            }, 
            new City
            {
                Id = 609,
                Name = "כפר חושן"
            }, 
            new City
            {
                Id = 255,
                Name = "כפר חיטים"
            }, 
            new City
            {
                Id = 193,
                Name = "כפר חיים"
            }, 
            new City
            {
                Id = 1297,
                Name = "כפר חנניה"
            }, 
            new City
            {
                Id = 112,
                Name = "כפר חסידים א'"
            }, 
            new City
            {
                Id = 889,
                Name = "כפר חסידים ב'"
            }, 
            new City
            {
                Id = 4004,
                Name = "כפר חרוב"
            }, 
            new City
            {
                Id = 673,
                Name = "כפר טרומן"
            }, 
            new City
            {
                Id = 507,
                Name = "כפר יאסיף"
            }, 
            new City
            {
                Id = 233,
                Name = "כפר ידידיה"
            }, 
            new City
            {
                Id = 140,
                Name = "כפר יהושע"
            }, 
            new City
            {
                Id = 168,
                Name = "כפר יונה"
            }, 
            new City
            {
                Id = 85,
                Name = "כפר יחזקאל"
            }, 
            new City
            {
                Id = 170,
                Name = "כפר יעבץ"
            }, 
            new City
            {
                Id = 508,
                Name = "כפר כמא"
            }, 
            new City
            {
                Id = 509,
                Name = "כפר כנא"
            }, 
            new City
            {
                Id = 387,
                Name = "כפר מונש"
            }, 
            new City
            {
                Id = 1095,
                Name = "כפר מימון"
            }, 
            new City
            {
                Id = 98,
                Name = "כפר מל\"ל"
            }, 
            new City
            {
                Id = 510,
                Name = "כפר מנדא"
            }, 
            new City
            {
                Id = 274,
                Name = "כפר מנחם"
            }, 
            new City
            {
                Id = 297,
                Name = "כפר מסריק"
            }, 
            new City
            {
                Id = 512,
                Name = "כפר מצר"
            }, 
            new City
            {
                Id = 764,
                Name = "כפר מרדכי"
            }, 
            new City
            {
                Id = 316,
                Name = "כפר נטר"
            }, 
            new City
            {
                Id = 345,
                Name = "כפר סאלד"
            }, 
            new City
            {
                Id = 6900,
                Name = "כפר סבא"
            }, 
            new City
            {
                Id = 107,
                Name = "כפר סילבר"
            }, 
            new City
            {
                Id = 249,
                Name = "כפר סירקין"
            }, 
            new City
            {
                Id = 875,
                Name = "כפר עבודה"
            }, 
            new City
            {
                Id = 845,
                Name = "כפר עזה"
            }, 
            new City
            {
                Id = 3488,
                Name = "כפר עציון"
            }, 
            new City
            {
                Id = 189,
                Name = "כפר פינס"
            }, 
            new City
            {
                Id = 634,
                Name = "כפר קאסם"
            }, 
            new City
            {
                Id = 388,
                Name = "כפר קיש"
            }, 
            new City
            {
                Id = 654,
                Name = "כפר קרע"
            }, 
            new City
            {
                Id = 579,
                Name = "כפר ראש הנקרה"
            }, 
            new City
            {
                Id = 1130,
                Name = "כפר רוזנואלד (זרעית)"
            }, 
            new City
            {
                Id = 295,
                Name = "כפר רופין"
            }, 
            new City
            {
                Id = 1166,
                Name = "כפר רות"
            }, 
            new City
            {
                Id = 605,
                Name = "כפר שמאי"
            }, 
            new City
            {
                Id = 743,
                Name = "כפר שמואל"
            }, 
            new City
            {
                Id = 267,
                Name = "כפר שמריהו"
            }, 
            new City
            {
                Id = 47,
                Name = "כפר תבור"
            }, 
            new City
            {
                Id = 3572,
                Name = "כפר תפוח"
            }, 
            new City
            {
                Id = 1285,
                Name = "כרכום"
            }, 
            new City
            {
                Id = 664,
                Name = "כרם בן זמרה"
            }, 
            new City
            {
                Id = 88,
                Name = "כרם בן שמן"
            }, 
            new City
            {
                Id = 1094,
                Name = "כרם יבנה (ישיבה)"
            }, 
            new City
            {
                Id = 580,
                Name = "כרם מהר\"ל"
            }, 
            new City
            {
                Id = 1085,
                Name = "כרם שלום"
            }, 
            new City
            {
                Id = 1264,
                Name = "כרמי יוסף"
            }, 
            new City
            {
                Id = 3766,
                Name = "כרמי צור"
            }, 
            new City
            {
                Id = 1139,
                Name = "כרמיאל"
            }, 
            new City
            {
                Id = 768,
                Name = "כרמייה"
            }, 
            new City
            {
                Id = 1198,
                Name = "כרמים"
            }, 
            new City
            {
                Id = 3656,
                Name = "כרמל"
            }, 
            new City
            {
                Id = 1207,
                Name = "לבון"
            }, 
            new City
            {
                Id = 585,
                Name = "לביא"
            }, 
            new City
            {
                Id = 1230,
                Name = "לבנים"
            }, 
            new City
            {
                Id = 2023,
                Name = "להב"
            }, 
            new City
            {
                Id = 380,
                Name = "להבות הבשן"
            }, 
            new City
            {
                Id = 715,
                Name = "להבות חביבה"
            }, 
            new City
            {
                Id = 1271,
                Name = "להבים"
            }, 
            new City
            {
                Id = 7000,
                Name = "לוד"
            }, 
            new City
            {
                Id = 52,
                Name = "לוזית"
            }, 
            new City
            {
                Id = 595,
                Name = "לוחמי הגיטאות"
            }, 
            new City
            {
                Id = 1171,
                Name = "לוטם"
            }, 
            new City
            {
                Id = 1255,
                Name = "לוטן"
            }, 
            new City
            {
                Id = 674,
                Name = "לימן"
            }, 
            new City
            {
                Id = 24,
                Name = "לכיש"
            }, 
            new City
            {
                Id = 1310,
                Name = "לפיד"
            }, 
            new City
            {
                Id = 1173,
                Name = "לפידות"
            }, 
            new City
            {
                Id = 1060,
                Name = "לקיה"
            }, 
            new City
            {
                Id = 2055,
                Name = "מאור"
            }, 
            new City
            {
                Id = 102,
                Name = "מאיר שפיה"
            }, 
            new City
            {
                Id = 771,
                Name = "מבוא ביתר"
            }, 
            new City
            {
                Id = 3569,
                Name = "מבוא דותן"
            }, 
            new City
            {
                Id = 3709,
                Name = "מבוא חורון"
            }, 
            new City
            {
                Id = 4204,
                Name = "מבוא חמה"
            }, 
            new City
            {
                Id = 1141,
                Name = "מבוא מודיעים"
            }, 
            new City
            {
                Id = 1318,
                Name = "מבואות ים"
            }, 
            new City
            {
                Id = 1080,
                Name = "מבועים"
            }, 
            new City
            {
                Id = 829,
                Name = "מבטחים"
            }, 
            new City
            {
                Id = 573,
                Name = "מבקיעים"
            }, 
            new City
            {
                Id = 1015,
                Name = "מבשרת ציון"
            }, 
            new City
            {
                Id = 481,
                Name = "מגאר"
            }, 
            new City
            {
                Id = 516,
                Name = "מג'ד אל-כרום"
            }, 
            new City
            {
                Id = 689,
                Name = "מגדים"
            }, 
            new City
            {
                Id = 65,
                Name = "מגדל"
            }, 
            new City
            {
                Id = 874,
                Name = "מגדל העמק"
            }, 
            new City
            {
                Id = 3561,
                Name = "מגדל עוז"
            }, 
            new City
            {
                Id = 4201,
                Name = "מג'דל שמס"
            }, 
            new City
            {
                Id = 1722,
                Name = "מגדל תפן"
            }, 
            new City
            {
                Id = 3751,
                Name = "מגדלים"
            }, 
            new City
            {
                Id = 586,
                Name = "מגידו"
            }, 
            new City
            {
                Id = 375,
                Name = "מגל"
            }, 
            new City
            {
                Id = 695,
                Name = "מגן"
            }, 
            new City
            {
                Id = 1155,
                Name = "מגן שאול"
            }, 
            new City
            {
                Id = 722,
                Name = "מגשימים"
            }, 
            new City
            {
                Id = 2029,
                Name = "מדרך עוז"
            }, 
            new City
            {
                Id = 1140,
                Name = "מדרשת בן גוריון"
            }, 
            new City
            {
                Id = 897,
                Name = "מדרשת רופין"
            }, 
            new City
            {
                Id = 3797,
                Name = "מודיעין עילית"
            }, 
            new City
            {
                Id = 1200,
                Name = "מודיעין-מכבים-רעות*"
            }, 
            new City
            {
                Id = 1360,
                Name = "מולדה*"
            }, 
            new City
            {
                Id = 269,
                Name = "מולדת"
            }, 
            new City
            {
                Id = 208,
                Name = "מוצא עילית"
            }, 
            new City
            {
                Id = 635,
                Name = "מוקייבלה"
            }, 
            new City
            {
                Id = 1163,
                Name = "מורן"
            }, 
            new City
            {
                Id = 1178,
                Name = "מורשת"
            }, 
            new City
            {
                Id = 606,
                Name = "מזור"
            }, 
            new City
            {
                Id = 28,
                Name = "מזכרת בתיה"
            }, 
            new City
            {
                Id = 1879,
                Name = "מזרח השרון מ\"א 16"
            }, 
            new City
            {
                Id = 1880,
                Name = "מזרח השרון מ\"א 18"
            }, 
            new City
            {
                Id = 104,
                Name = "מזרע"
            }, 
            new City
            {
                Id = 517,
                Name = "מזרעה"
            }, 
            new City
            {
                Id = 3599,
                Name = "מחולה"
            }, 
            new City
            {
                Id = 1411,
                Name = "מחנה הילה*"
            }, 
            new City
            {
                Id = 1418,
                Name = "מחנה טלי*"
            }, 
            new City
            {
                Id = 1413,
                Name = "מחנה יהודית*"
            }, 
            new City
            {
                Id = 1416,
                Name = "מחנה יוכבד*"
            }, 
            new City
            {
                Id = 1415,
                Name = "מחנה יפה*"
            }, 
            new City
            {
                Id = 1196,
                Name = "מחנה יתיר"
            }, 
            new City
            {
                Id = 1414,
                Name = "מחנה מרים*"
            }, 
            new City
            {
                Id = 1417,
                Name = "מחנה עדי*"
            }, 
            new City
            {
                Id = 1412,
                Name = "מחנה תל נוף*"
            }, 
            new City
            {
                Id = 308,
                Name = "מחניים"
            }, 
            new City
            {
                Id = 776,
                Name = "מחסיה"
            }, 
            new City
            {
                Id = 43,
                Name = "מטולה"
            }, 
            new City
            {
                Id = 822,
                Name = "מטע"
            }, 
            new City
            {
                Id = 1128,
                Name = "מי עמי"
            }, 
            new City
            {
                Id = 2054,
                Name = "מיטב"
            }, 
            new City
            {
                Id = 649,
                Name = "מייסר"
            }, 
            new City
            {
                Id = 4019,
                Name = "מיצר"
            }, 
            new City
            {
                Id = 1282,
                Name = "מירב"
            }, 
            new City
            {
                Id = 607,
                Name = "מירון"
            }, 
            new City
            {
                Id = 731,
                Name = "מישר"
            }, 
            new City
            {
                Id = 1268,
                Name = "מיתר"
            }, 
            new City
            {
                Id = 3614,
                Name = "מכורה"
            }, 
            new City
            {
                Id = 1343,
                Name = "מכחול"
            }, 
            new City
            {
                Id = 382,
                Name = "מכמורת"
            }, 
            new City
            {
                Id = 1202,
                Name = "מכמנים"
            }, 
            new City
            {
                Id = 164,
                Name = "מלאה"
            }, 
            new City
            {
                Id = 2044,
                Name = "מלילות"
            }, 
            new City
            {
                Id = 596,
                Name = "מלכייה"
            }, 
            new City
            {
                Id = 1154,
                Name = "מלכישוע"
            }, 
            new City
            {
                Id = 2030,
                Name = "מנוחה"
            }, 
            new City
            {
                Id = 1174,
                Name = "מנוף"
            }, 
            new City
            {
                Id = 1205,
                Name = "מנות"
            }, 
            new City
            {
                Id = 48,
                Name = "מנחמיה"
            }, 
            new City
            {
                Id = 347,
                Name = "מנרה"
            }, 
            new City
            {
                Id = 994,
                Name = "מנשית זבדה"
            }, 
            new City
            {
                Id = 1258,
                Name = "מסד"
            }, 
            new City
            {
                Id = 263,
                Name = "מסדה"
            }, 
            new City
            {
                Id = 298,
                Name = "מסילות"
            }, 
            new City
            {
                Id = 742,
                Name = "מסילת ציון"
            }, 
            new City
            {
                Id = 748,
                Name = "מסלול"
            }, 
            new City
            {
                Id = 4203,
                Name = "מסעדה"
            }, 
            new City
            {
                Id = 939,
                Name = "מסעודין אל-עזאזמה (שבט)"
            }, 
            new City
            {
                Id = 197,
                Name = "מעברות"
            }, 
            new City
            {
                Id = 1082,
                Name = "מעגלים"
            }, 
            new City
            {
                Id = 678,
                Name = "מעגן"
            }, 
            new City
            {
                Id = 694,
                Name = "מעגן מיכאל"
            }, 
            new City
            {
                Id = 272,
                Name = "מעוז חיים"
            }, 
            new City
            {
                Id = 3657,
                Name = "מעון"
            }, 
            new City
            {
                Id = 570,
                Name = "מעונה"
            }, 
            new City
            {
                Id = 416,
                Name = "מעיין ברוך"
            }, 
            new City
            {
                Id = 290,
                Name = "מעיין צבי"
            }, 
            new City
            {
                Id = 518,
                Name = "מעיליא"
            }, 
            new City
            {
                Id = 3616,
                Name = "מעלה אדומים"
            }, 
            new City
            {
                Id = 3608,
                Name = "מעלה אפרים"
            }, 
            new City
            {
                Id = 1127,
                Name = "מעלה גלבוע"
            }, 
            new City
            {
                Id = 4008,
                Name = "מעלה גמלא"
            }, 
            new City
            {
                Id = 286,
                Name = "מעלה החמישה"
            }, 
            new City
            {
                Id = 3752,
                Name = "מעלה לבונה"
            }, 
            new City
            {
                Id = 3651,
                Name = "מעלה מכמש"
            }, 
            new City
            {
                Id = 1327,
                Name = "מעלה עירון"
            }, 
            new City
            {
                Id = 3653,
                Name = "מעלה עמוס"
            }, 
            new City
            {
                Id = 3637,
                Name = "מעלה שומרון"
            }, 
            new City
            {
                Id = 1063,
                Name = "מעלות-תרשיחא"
            }, 
            new City
            {
                Id = 344,
                Name = "מענית"
            }, 
            new City
            {
                Id = 1876,
                Name = "מערב השרון מ\"א 16"
            }, 
            new City
            {
                Id = 1877,
                Name = "מערב השרון מ\"א 18"
            }, 
            new City
            {
                Id = 1878,
                Name = "מערב השרון מ\"א 19"
            }, 
            new City
            {
                Id = 230,
                Name = "מעש"
            }, 
            new City
            {
                Id = 668,
                Name = "מפלסים"
            }, 
            new City
            {
                Id = 1767,
                Name = "מפעלי אבשלום"
            }, 
            new City
            {
                Id = 1791,
                Name = "מפעלי ברקן*"
            }, 
            new City
            {
                Id = 1706,
                Name = "מפעלי גליל עליון"
            }, 
            new City
            {
                Id = 1739,
                Name = "מפעלי גרנות"
            }, 
            new City
            {
                Id = 1701,
                Name = "מפעלי הר טוב*"
            }, 
            new City
            {
                Id = 1717,
                Name = "מפעלי יזרעאל* (העמק)"
            }, 
            new City
            {
                Id = 1775,
                Name = "מפעלי ים המלח(סדום)"
            }, 
            new City
            {
                Id = 1753,
                Name = "מפעלי כנות"
            }, 
            new City
            {
                Id = 1769,
                Name = "מפעלי מעון*"
            }, 
            new City
            {
                Id = 1761,
                Name = "מפעלי צומת מלאכי*"
            }, 
            new City
            {
                Id = 1776,
                Name = "מפעלי צין - ערבה"
            }, 
            new City
            {
                Id = 1711,
                Name = "מפעלי צמח"
            }, 
            new City
            {
                Id = 1773,
                Name = "מפעלי רותם"
            }, 
            new City
            {
                Id = 1719,
                Name = "מפעלי שאן*"
            }, 
            new City
            {
                Id = 3745,
                Name = "מצדות יהודה"
            }, 
            new City
            {
                Id = 325,
                Name = "מצובה"
            }, 
            new City
            {
                Id = 757,
                Name = "מצליח"
            }, 
            new City
            {
                Id = 58,
                Name = "מצפה"
            }, 
            new City
            {
                Id = 1222,
                Name = "מצפה אבי\"ב"
            }, 
            new City
            {
                Id = 1370,
                Name = "מצפה אילן"
            }, 
            new City
            {
                Id = 3576,
                Name = "מצפה יריחו"
            }, 
            new City
            {
                Id = 1190,
                Name = "מצפה נטופה"
            }, 
            new City
            {
                Id = 99,
                Name = "מצפה רמון"
            }, 
            new City
            {
                Id = 3610,
                Name = "מצפה שלם"
            }, 
            new City
            {
                Id = 648,
                Name = "מצר"
            }, 
            new City
            {
                Id = 22,
                Name = "מקווה ישראל"
            }, 
            new City
            {
                Id = 843,
                Name = "מרגליות"
            }, 
            new City
            {
                Id = 4101,
                Name = "מרום גולן"
            }, 
            new City
            {
                Id = 1340,
                Name = "מרחב עם"
            }, 
            new City
            {
                Id = 97,
                Name = "מרחביה (מושב)"
            }, 
            new City
            {
                Id = 66,
                Name = "מרחביה (קיבוץ)"
            }, 
            new City
            {
                Id = 1713,
                Name = "מרכז אזורי כדורי"
            }, 
            new City
            {
                Id = 1708,
                Name = "מרכז אזורי מרום הגליל"
            }, 
            new City
            {
                Id = 1723,
                Name = "מרכז אזורי משגב"
            }, 
            new City
            {
                Id = 1705,
                Name = "מרכז כ\"ח"
            }, 
            new City
            {
                Id = 1715,
                Name = "מרכז מיר\"ב*"
            }, 
            new City
            {
                Id = 1747,
                Name = "מרכז שוהם"
            }, 
            new City
            {
                Id = 1098,
                Name = "מרכז שפירא"
            }, 
            new City
            {
                Id = 421,
                Name = "משאבי שדה"
            }, 
            new City
            {
                Id = 765,
                Name = "משגב דב"
            }, 
            new City
            {
                Id = 378,
                Name = "משגב עם"
            }, 
            new City
            {
                Id = 520,
                Name = "משהד"
            }, 
            new City
            {
                Id = 3605,
                Name = "משואה"
            }, 
            new City
            {
                Id = 620,
                Name = "משואות יצחק"
            }, 
            new City
            {
                Id = 3785,
                Name = "משכיות"
            }, 
            new City
            {
                Id = 670,
                Name = "משמר איילון"
            }, 
            new City
            {
                Id = 563,
                Name = "משמר דוד"
            }, 
            new City
            {
                Id = 732,
                Name = "משמר הירדן"
            }, 
            new City
            {
                Id = 395,
                Name = "משמר הנגב"
            }, 
            new City
            {
                Id = 130,
                Name = "משמר העמק"
            }, 
            new City
            {
                Id = 729,
                Name = "משמר השבעה"
            }, 
            new City
            {
                Id = 194,
                Name = "משמר השרון"
            }, 
            new City
            {
                Id = 213,
                Name = "משמרות"
            }, 
            new City
            {
                Id = 425,
                Name = "משמרת"
            }, 
            new City
            {
                Id = 791,
                Name = "משען"
            }, 
            new City
            {
                Id = 1315,
                Name = "מתן"
            }, 
            new City
            {
                Id = 1184,
                Name = "מתת"
            }, 
            new City
            {
                Id = 3648,
                Name = "מתתיהו"
            }, 
            new City
            {
                Id = 4551,
                Name = "נאות גולן"
            }, 
            new City
            {
                Id = 1124,
                Name = "נאות הכיכר"
            }, 
            new City
            {
                Id = 408,
                Name = "נאות מרדכי"
            }, 
            new City
            {
                Id = 1197,
                Name = "נאות סמדר"
            }, 
            new City
            {
                Id = 524,
                Name = "נאעורה"
            }, 
            new City
            {
                Id = 396,
                Name = "נבטים"
            }, 
            new City
            {
                Id = 315,
                Name = "נגבה"
            }, 
            new City
            {
                Id = 3724,
                Name = "נגוהות"
            }, 
            new City
            {
                Id = 309,
                Name = "נהורה"
            }, 
            new City
            {
                Id = 80,
                Name = "נהלל"
            }, 
            new City
            {
                Id = 9100,
                Name = "נהרייה"
            }, 
            new City
            {
                Id = 4304,
                Name = "נוב"
            }, 
            new City
            {
                Id = 55,
                Name = "נוגה"
            }, 
            new City
            {
                Id = 1366,
                Name = "נווה"
            }, 
            new City
            {
                Id = 926,
                Name = "נווה אבות"
            }, 
            new City
            {
                Id = 590,
                Name = "נווה אור"
            }, 
            new City
            {
                Id = 4303,
                Name = "נווה אטי\"ב"
            }, 
            new City
            {
                Id = 405,
                Name = "נווה אילן"
            }, 
            new City
            {
                Id = 1702,
                Name = "נווה אילן*"
            }, 
            new City
            {
                Id = 296,
                Name = "נווה איתן"
            }, 
            new City
            {
                Id = 3725,
                Name = "נווה דניאל"
            }, 
            new City
            {
                Id = 1057,
                Name = "נווה זוהר"
            }, 
            new City
            {
                Id = 1314,
                Name = "נווה זיו"
            }, 
            new City
            {
                Id = 1279,
                Name = "נווה חריף"
            }, 
            new City
            {
                Id = 312,
                Name = "נווה ים"
            }, 
            new City
            {
                Id = 686,
                Name = "נווה ימין"
            }, 
            new City
            {
                Id = 858,
                Name = "נווה ירק"
            }, 
            new City
            {
                Id = 827,
                Name = "נווה מבטח"
            }, 
            new City
            {
                Id = 1071,
                Name = "נווה מיכאל"
            }, 
            new City
            {
                Id = 1259,
                Name = "נווה שלום"
            }, 
            new City
            {
                Id = 15,
                Name = "נועם"
            }, 
            new City
            {
                Id = 1333,
                Name = "נוף איילון"
            }, 
            new City
            {
                Id = 3790,
                Name = "נופים"
            }, 
            new City
            {
                Id = 1284,
                Name = "נופית"
            }, 
            new City
            {
                Id = 257,
                Name = "נופך"
            }, 
            new City
            {
                Id = 3726,
                Name = "נוקדים"
            }, 
            new City
            {
                Id = 447,
                Name = "נורדייה"
            }, 
            new City
            {
                Id = 833,
                Name = "נורית"
            }, 
            new City
            {
                Id = 59,
                Name = "נחושה"
            }, 
            new City
            {
                Id = 1883,
                Name = "נחל יפתחאל מ\"א 3"
            }, 
            new City
            {
                Id = 844,
                Name = "נחל עוז"
            }, 
            new City
            {
                Id = 1861,
                Name = "נחל תבור מ\"א 8"
            }, 
            new City
            {
                Id = 2045,
                Name = "נחלה"
            }, 
            new City
            {
                Id = 3767,
                Name = "נחליאל"
            }, 
            new City
            {
                Id = 449,
                Name = "נחלים"
            }, 
            new City
            {
                Id = 809,
                Name = "נחם"
            }, 
            new City
            {
                Id = 522,
                Name = "נחף"
            }, 
            new City
            {
                Id = 433,
                Name = "נחשולים"
            }, 
            new City
            {
                Id = 777,
                Name = "נחשון"
            }, 
            new City
            {
                Id = 705,
                Name = "נחשונים"
            }, 
            new City
            {
                Id = 1147,
                Name = "נטועה"
            }, 
            new City
            {
                Id = 4014,
                Name = "נטור"
            }, 
            new City
            {
                Id = 174,
                Name = "נטעים"
            }, 
            new City
            {
                Id = 1254,
                Name = "נטף"
            }, 
            new City
            {
                Id = 523,
                Name = "ניין"
            }, 
            new City
            {
                Id = 3655,
                Name = "ניל\"י"
            }, 
            new City
            {
                Id = 351,
                Name = "ניצן"
            }, 
            new City
            {
                Id = 1419,
                Name = "ניצן ב'"
            }, 
            new City
            {
                Id = 1195,
                Name = "ניצנה (קהילת חינוך)"
            }, 
            new City
            {
                Id = 1280,
                Name = "ניצני סיני"
            }, 
            new City
            {
                Id = 851,
                Name = "ניצני עוז"
            }, 
            new City
            {
                Id = 359,
                Name = "ניצנים"
            }, 
            new City
            {
                Id = 808,
                Name = "ניר אליהו"
            }, 
            new City
            {
                Id = 553,
                Name = "ניר בנים"
            }, 
            new City
            {
                Id = 720,
                Name = "ניר גלים"
            }, 
            new City
            {
                Id = 256,
                Name = "ניר דוד (תל עמל)"
            }, 
            new City
            {
                Id = 11,
                Name = "ניר ח\"ן"
            }, 
            new City
            {
                Id = 165,
                Name = "ניר יפה"
            }, 
            new City
            {
                Id = 402,
                Name = "ניר יצחק"
            }, 
            new City
            {
                Id = 699,
                Name = "ניר ישראל"
            }, 
            new City
            {
                Id = 2047,
                Name = "ניר משה"
            }, 
            new City
            {
                Id = 69,
                Name = "ניר עוז"
            }, 
            new City
            {
                Id = 348,
                Name = "ניר עם"
            }, 
            new City
            {
                Id = 769,
                Name = "ניר עציון"
            }, 
            new City
            {
                Id = 2048,
                Name = "ניר עקיבא"
            }, 
            new City
            {
                Id = 331,
                Name = "ניר צבי"
            }, 
            new City
            {
                Id = 602,
                Name = "נירים"
            }, 
            new City
            {
                Id = 1236,
                Name = "נירית"
            }, 
            new City
            {
                Id = 3620,
                Name = "נירן"
            }, 
            new City
            {
                Id = 1748,
                Name = "נמל תעופה בן-גוריון"
            }, 
            new City
            {
                Id = 825,
                Name = "נס הרים"
            }, 
            new City
            {
                Id = 1143,
                Name = "נס עמים"
            }, 
            new City
            {
                Id = 7200,
                Name = "נס ציונה"
            }, 
            new City
            {
                Id = 186,
                Name = "נעורים"
            }, 
            new City
            {
                Id = 3787,
                Name = "נעלה"
            }, 
            new City
            {
                Id = 3713,
                Name = "נעמ\"ה"
            }, 
            new City
            {
                Id = 158,
                Name = "נען"
            }, 
            new City
            {
                Id = 1982,
                Name = "נפת בית לחם"
            }, 
            new City
            {
                Id = 1981,
                Name = "נפת בית לחם מ\"א 76"
            }, 
            new City
            {
                Id = 1971,
                Name = "נפת ג'נין"
            }, 
            new City
            {
                Id = 1970,
                Name = "נפת ג'נין  מ\"א 72"
            }, 
            new City
            {
                Id = 1984,
                Name = "נפת חברון"
            }, 
            new City
            {
                Id = 1983,
                Name = "נפת חברון מ\"א 78"
            }, 
            new City
            {
                Id = 1975,
                Name = "נפת טול כרם"
            }, 
            new City
            {
                Id = 1974,
                Name = "נפת טול כרם  מ\"א 72"
            }, 
            new City
            {
                Id = 1980,
                Name = "נפת ירדן"
            }, 
            new City
            {
                Id = 1978,
                Name = "נפת ירדן מ\"א 74"
            }, 
            new City
            {
                Id = 1979,
                Name = "נפת ירדן מ\"א 75"
            }, 
            new City
            {
                Id = 1977,
                Name = "נפת ראמאללה"
            }, 
            new City
            {
                Id = 1976,
                Name = "נפת ראמאללה מ\"א  73"
            }, 
            new City
            {
                Id = 1973,
                Name = "נפת שכם"
            }, 
            new City
            {
                Id = 1972,
                Name = "נפת שכם מ\"א 72"
            }, 
            new City
            {
                Id = 1041,
                Name = "נצאצרה (שבט)"
            }, 
            new City
            {
                Id = 1372,
                Name = "נצר חזני"
            }, 
            new City
            {
                Id = 435,
                Name = "נצר סרני"
            }, 
            new City
            {
                Id = 7300,
                Name = "נצרת"
            }, 
            new City
            {
                Id = 1061,
                Name = "נצרת עילית"
            }, 
            new City
            {
                Id = 2500,
                Name = "נשר"
            }, 
            new City
            {
                Id = 3555,
                Name = "נתיב הגדוד"
            }, 
            new City
            {
                Id = 693,
                Name = "נתיב הל\"ה"
            }, 
            new City
            {
                Id = 1242,
                Name = "נתיב העשרה"
            }, 
            new City
            {
                Id = 792,
                Name = "נתיב השיירה"
            }, 
            new City
            {
                Id = 246,
                Name = "נתיבות"
            }, 
            new City
            {
                Id = 7400,
                Name = "נתניה"
            }, 
            new City
            {
                Id = 525,
                Name = "סאג'ור"
            }, 
            new City
            {
                Id = 578,
                Name = "סאסא"
            }, 
            new City
            {
                Id = 587,
                Name = "סביון*"
            }, 
            new City
            {
                Id = 2046,
                Name = "סגולה"
            }, 
            new City
            {
                Id = 942,
                Name = "סואעד (חמרייה)*"
            }, 
            new City
            {
                Id = 989,
                Name = "סואעד (כמאנה) (שבט)"
            }, 
            new City
            {
                Id = 526,
                Name = "סולם"
            }, 
            new City
            {
                Id = 3756,
                Name = "סוסיה"
            }, 
            new City
            {
                Id = 1238,
                Name = "סופה"
            }, 
            new City
            {
                Id = 7500,
                Name = "סח'נין"
            }, 
            new City
            {
                Id = 1170,
                Name = "סייד (שבט)"
            }, 
            new City
            {
                Id = 1245,
                Name = "סלמה"
            }, 
            new City
            {
                Id = 3567,
                Name = "סלעית"
            }, 
            new City
            {
                Id = 1156,
                Name = "סמר"
            }, 
            new City
            {
                Id = 1328,
                Name = "סנסנה"
            }, 
            new City
            {
                Id = 419,
                Name = "סעד"
            }, 
            new City
            {
                Id = 454,
                Name = "סער"
            }, 
            new City
            {
                Id = 1176,
                Name = "ספיר"
            }, 
            new City
            {
                Id = 610,
                Name = "סתרייה"
            }, 
            new City
            {
                Id = 892,
                Name = "עבדון"
            }, 
            new City
            {
                Id = 376,
                Name = "עברון"
            }, 
            new City
            {
                Id = 794,
                Name = "עגור"
            }, 
            new City
            {
                Id = 4501,
                Name = "ע'ג'ר"
            }, 
            new City
            {
                Id = 1762,
                Name = "עד הלום"
            }, 
            new City
            {
                Id = 1199,
                Name = "עדי"
            }, 
            new City
            {
                Id = 2035,
                Name = "עדנים"
            }, 
            new City
            {
                Id = 826,
                Name = "עוזה"
            }, 
            new City
            {
                Id = 528,
                Name = "עוזייר"
            }, 
            new City
            {
                Id = 737,
                Name = "עולש"
            }, 
            new City
            {
                Id = 666,
                Name = "עומר"
            }, 
            new City
            {
                Id = 810,
                Name = "עופר"
            }, 
            new City
            {
                Id = 32,
                Name = "עוצם"
            }, 
            new City
            {
                Id = 957,
                Name = "עוקבי (בנו עוקבה) (שבט)"
            }, 
            new City
            {
                Id = 328,
                Name = "עזוז"
            }, 
            new City
            {
                Id = 1149,
                Name = "עזר"
            }, 
            new City
            {
                Id = 837,
                Name = "עזריאל"
            }, 
            new City
            {
                Id = 711,
                Name = "עזריה"
            }, 
            new City
            {
                Id = 817,
                Name = "עזריקם"
            }, 
            new City
            {
                Id = 969,
                Name = "עטאוונה (שבט)"
            }, 
            new City
            {
                Id = 3658,
                Name = "עטרת"
            }, 
            new City
            {
                Id = 1175,
                Name = "עידן"
            }, 
            new City
            {
                Id = 530,
                Name = "עיילבון"
            }, 
            new City
            {
                Id = 156,
                Name = "עיינות"
            }, 
            new City
            {
                Id = 511,
                Name = "עילוט"
            }, 
            new City
            {
                Id = 687,
                Name = "עין איילה"
            }, 
            new City
            {
                Id = 546,
                Name = "עין אל-אסד"
            }, 
            new City
            {
                Id = 273,
                Name = "עין גב"
            }, 
            new City
            {
                Id = 2042,
                Name = "עין גדי"
            }, 
            new City
            {
                Id = 436,
                Name = "עין דור"
            }, 
            new City
            {
                Id = 1240,
                Name = "עין הבשור"
            }, 
            new City
            {
                Id = 74,
                Name = "עין הוד"
            }, 
            new City
            {
                Id = 167,
                Name = "עין החורש"
            }, 
            new City
            {
                Id = 289,
                Name = "עין המפרץ"
            }, 
            new City
            {
                Id = 383,
                Name = "עין הנצי\"ב"
            }, 
            new City
            {
                Id = 367,
                Name = "עין העמק"
            }, 
            new City
            {
                Id = 270,
                Name = "עין השופט"
            }, 
            new City
            {
                Id = 676,
                Name = "עין השלושה"
            }, 
            new City
            {
                Id = 157,
                Name = "עין ורד"
            }, 
            new City
            {
                Id = 4503,
                Name = "עין זיוון"
            }, 
            new City
            {
                Id = 1320,
                Name = "עין חוד"
            }, 
            new City
            {
                Id = 1053,
                Name = "עין חצבה"
            }, 
            new City
            {
                Id = 89,
                Name = "עין חרוד (איחוד)"
            }, 
            new City
            {
                Id = 82,
                Name = "עין חרוד (מאוחד)"
            }, 
            new City
            {
                Id = 806,
                Name = "עין יהב"
            }, 
            new City
            {
                Id = 813,
                Name = "עין יעקב"
            }, 
            new City
            {
                Id = 1056,
                Name = "עין כרם-בי\"ס חקלאי"
            }, 
            new City
            {
                Id = 426,
                Name = "עין כרמל"
            }, 
            new City
            {
                Id = 532,
                Name = "עין מאהל"
            }, 
            new City
            {
                Id = 521,
                Name = "עין נקובא"
            }, 
            new City
            {
                Id = 223,
                Name = "עין עירון"
            }, 
            new City
            {
                Id = 622,
                Name = "עין צורים"
            }, 
            new City
            {
                Id = 4502,
                Name = "עין קנייא"
            }, 
            new City
            {
                Id = 514,
                Name = "עין ראפה"
            }, 
            new City
            {
                Id = 139,
                Name = "עין שמר"
            }, 
            new City
            {
                Id = 880,
                Name = "עין שריד"
            }, 
            new City
            {
                Id = 1251,
                Name = "עין תמר"
            }, 
            new City
            {
                Id = 871,
                Name = "עינת"
            }, 
            new City
            {
                Id = 1187,
                Name = "עיר אובות"
            }, 
            new City
            {
                Id = 7600,
                Name = "עכו"
            }, 
            new City
            {
                Id = 1146,
                Name = "עלומים"
            }, 
            new City
            {
                Id = 3765,
                Name = "עלי"
            }, 
            new City
            {
                Id = 3727,
                Name = "עלי זהב"
            }, 
            new City
            {
                Id = 688,
                Name = "עלמה"
            }, 
            new City
            {
                Id = 3715,
                Name = "עלמון"
            }, 
            new City
            {
                Id = 1212,
                Name = "עמוקה"
            }, 
            new City
            {
                Id = 779,
                Name = "עמינדב"
            }, 
            new City
            {
                Id = 385,
                Name = "עמיעד"
            }, 
            new City
            {
                Id = 318,
                Name = "עמיעוז"
            }, 
            new City
            {
                Id = 773,
                Name = "עמיקם"
            }, 
            new City
            {
                Id = 319,
                Name = "עמיר"
            }, 
            new City
            {
                Id = 3660,
                Name = "עמנואל"
            }, 
            new City
            {
                Id = 1824,
                Name = "עמק בית שאן מ\"א 7"
            }, 
            new City
            {
                Id = 1825,
                Name = "עמק בית שאן של\"ש"
            }, 
            new City
            {
                Id = 1806,
                Name = "עמק חולה מ\"א 1"
            }, 
            new City
            {
                Id = 1807,
                Name = "עמק חולה מ\"א 55"
            }, 
            new City
            {
                Id = 1808,
                Name = "עמק חולה של\"ש"
            }, 
            new City
            {
                Id = 1875,
                Name = "עמק חפר מזרח מ\"א 16"
            }, 
            new City
            {
                Id = 1826,
                Name = "עמק חרוד מ\"א 8"
            }, 
            new City
            {
                Id = 1827,
                Name = "עמק חרוד של\"ש"
            }, 
            new City
            {
                Id = 1834,
                Name = "עמק יזרעאל מ\"א 13"
            }, 
            new City
            {
                Id = 1832,
                Name = "עמק יזרעאל מ\"א 8"
            }, 
            new City
            {
                Id = 1833,
                Name = "עמק יזרעאל מ\"א 9"
            }, 
            new City
            {
                Id = 708,
                Name = "עמקה"
            }, 
            new City
            {
                Id = 3712,
                Name = "ענב"
            }, 
            new City
            {
                Id = 534,
                Name = "עספיא"
            }, 
            new City
            {
                Id = 7700,
                Name = "עפולה"
            }, 
            new City
            {
                Id = 3617,
                Name = "עפרה"
            }, 
            new City
            {
                Id = 3778,
                Name = "עץ אפרים"
            }, 
            new City
            {
                Id = 917,
                Name = "עצמון שגב"
            }, 
            new City
            {
                Id = 531,
                Name = "עראבה"
            }, 
            new City
            {
                Id = 1246,
                Name = "עראמשה*"
            }, 
            new City
            {
                Id = 1335,
                Name = "ערב אל נעים"
            }, 
            new City
            {
                Id = 2560,
                Name = "ערד"
            }, 
            new City
            {
                Id = 593,
                Name = "ערוגות"
            }, 
            new City
            {
                Id = 637,
                Name = "ערערה"
            }, 
            new City
            {
                Id = 1192,
                Name = "ערערה-בנגב"
            }, 
            new City
            {
                Id = 591,
                Name = "עשרת"
            }, 
            new City
            {
                Id = 53,
                Name = "עתלית"
            }, 
            new City
            {
                Id = 3748,
                Name = "עתניאל"
            }, 
            new City
            {
                Id = 1151,
                Name = "פארן"
            }, 
            new City
            {
                Id = 1961,
                Name = "פארק הירדן מ\"א 6"
            }, 
            new City
            {
                Id = 1729,
                Name = "פארק תעשיה חבל מודיעים"
            }, 
            new City
            {
                Id = 1745,
                Name = "פארק תעשיות עמק חפר"
            }, 
            new City
            {
                Id = 3768,
                Name = "פדואל"
            }, 
            new City
            {
                Id = 750,
                Name = "פדויים"
            }, 
            new City
            {
                Id = 838,
                Name = "פדיה"
            }, 
            new City
            {
                Id = 537,
                Name = "פוריידיס"
            }, 
            new City
            {
                Id = 1104,
                Name = "פורייה - כפר עבודה"
            }, 
            new City
            {
                Id = 1105,
                Name = "פורייה - נווה עובד"
            }, 
            new City
            {
                Id = 1313,
                Name = "פורייה עילית"
            }, 
            new City
            {
                Id = 767,
                Name = "פורת"
            }, 
            new City
            {
                Id = 749,
                Name = "פטיש"
            }, 
            new City
            {
                Id = 1185,
                Name = "פלך"
            }, 
            new City
            {
                Id = 597,
                Name = "פלמחים"
            }, 
            new City
            {
                Id = 3723,
                Name = "פני חבר"
            }, 
            new City
            {
                Id = 3659,
                Name = "פסגות"
            }, 
            new City
            {
                Id = 535,
                Name = "פסוטה"
            }, 
            new City
            {
                Id = 2059,
                Name = "פעמי תש\"ז"
            }, 
            new City
            {
                Id = 3615,
                Name = "פצאל"
            }, 
            new City
            {
                Id = 536,
                Name = "פקיעין (בוקייעה)"
            }, 
            new City
            {
                Id = 281,
                Name = "פקיעין חדשה"
            }, 
            new City
            {
                Id = 7800,
                Name = "פרדס חנה-כרכור"
            }, 
            new City
            {
                Id = 171,
                Name = "פרדסייה"
            }, 
            new City
            {
                Id = 599,
                Name = "פרוד"
            }, 
            new City
            {
                Id = 2053,
                Name = "פרזון"
            }, 
            new City
            {
                Id = 1231,
                Name = "פרי גן"
            }, 
            new City
            {
                Id = 7900,
                Name = "פתח תקווה"
            }, 
            new City
            {
                Id = 839,
                Name = "פתחיה"
            }, 
            new City
            {
                Id = 413,
                Name = "צאלים"
            }, 
            new City
            {
                Id = 1180,
                Name = "צביה"
            }, 
            new City
            {
                Id = 1213,
                Name = "צבעון"
            }, 
            new City
            {
                Id = 465,
                Name = "צובה"
            }, 
            new City
            {
                Id = 1136,
                Name = "צוחר"
            }, 
            new City
            {
                Id = 1111,
                Name = "צופייה"
            }, 
            new City
            {
                Id = 3791,
                Name = "צופים"
            }, 
            new City
            {
                Id = 198,
                Name = "צופית"
            }, 
            new City
            {
                Id = 1150,
                Name = "צופר"
            }, 
            new City
            {
                Id = 1102,
                Name = "צוקי ים"
            }, 
            new City
            {
                Id = 1262,
                Name = "צוקים"
            }, 
            new City
            {
                Id = 1113,
                Name = "צור הדסה"
            }, 
            new City
            {
                Id = 1345,
                Name = "צור יצחק"
            }, 
            new City
            {
                Id = 276,
                Name = "צור משה"
            }, 
            new City
            {
                Id = 1148,
                Name = "צור נתן"
            }, 
            new City
            {
                Id = 774,
                Name = "צוריאל"
            }, 
            new City
            {
                Id = 1221,
                Name = "צורית"
            }, 
            new City
            {
                Id = 613,
                Name = "ציפורי"
            }, 
            new City
            {
                Id = 796,
                Name = "צלפון"
            }, 
            new City
            {
                Id = 636,
                Name = "צנדלה"
            }, 
            new City
            {
                Id = 594,
                Name = "צפרייה"
            }, 
            new City
            {
                Id = 1079,
                Name = "צפרירים"
            }, 
            new City
            {
                Id = 8000,
                Name = "צפת"
            }, 
            new City
            {
                Id = 612,
                Name = "צרופה"
            }, 
            new City
            {
                Id = 567,
                Name = "צרעה"
            }, 
            new City
            {
                Id = 1234,
                Name = "קבועה (שבט)"
            }, 
            new City
            {
                Id = 334,
                Name = "קבוצת יבנה"
            }, 
            new City
            {
                Id = 3557,
                Name = "קדומים"
            }, 
            new City
            {
                Id = 195,
                Name = "קדימה-צורן"
            }, 
            new City
            {
                Id = 392,
                Name = "קדמה"
            }, 
            new City
            {
                Id = 4025,
                Name = "קדמת צבי"
            }, 
            new City
            {
                Id = 3781,
                Name = "קדר"
            }, 
            new City
            {
                Id = 615,
                Name = "קדרון"
            }, 
            new City
            {
                Id = 1211,
                Name = "קדרים"
            }, 
            new City
            {
                Id = 964,
                Name = "קודייראת א-צאנע (שבט)"
            }, 
            new City
            {
                Id = 972,
                Name = "קוואעין (שבט)"
            }, 
            new City
            {
                Id = 766,
                Name = "קוממיות"
            }, 
            new City
            {
                Id = 1179,
                Name = "קורנית"
            }, 
            new City
            {
                Id = 1052,
                Name = "קטורה"
            }, 
            new City
            {
                Id = 1167,
                Name = "קיסריה"
            }, 
            new City
            {
                Id = 414,
                Name = "קלחים"
            }, 
            new City
            {
                Id = 3601,
                Name = "קליה"
            }, 
            new City
            {
                Id = 638,
                Name = "קלנסווה"
            }, 
            new City
            {
                Id = 4024,
                Name = "קלע"
            }, 
            new City
            {
                Id = 1247,
                Name = "קציר-חריש"
            }, 
            new City
            {
                Id = 1347,
                Name = "קצר א-סר"
            }, 
            new City
            {
                Id = 4100,
                Name = "קצרין"
            }, 
            new City
            {
                Id = 2620,
                Name = "קריית אונו"
            }, 
            new City
            {
                Id = 3611,
                Name = "קריית ארבע"
            }, 
            new City
            {
                Id = 6800,
                Name = "קריית אתא"
            }, 
            new City
            {
                Id = 9500,
                Name = "קריית ביאליק"
            }, 
            new City
            {
                Id = 2630,
                Name = "קריית גת"
            }, 
            new City
            {
                Id = 1768,
                Name = "קריית חינוך מרחבים"
            }, 
            new City
            {
                Id = 2300,
                Name = "קריית טבעון"
            }, 
            new City
            {
                Id = 9600,
                Name = "קריית ים"
            }, 
            new City
            {
                Id = 1137,
                Name = "קריית יערים"
            }, 
            new City
            {
                Id = 2039,
                Name = "קריית יערים (מוסד)"
            }, 
            new City
            {
                Id = 8200,
                Name = "קריית מוצקין"
            }, 
            new City
            {
                Id = 1034,
                Name = "קריית מלאכי"
            }, 
            new City
            {
                Id = 3746,
                Name = "קריית נטפים"
            }, 
            new City
            {
                Id = 78,
                Name = "קריית ענבים"
            }, 
            new City
            {
                Id = 469,
                Name = "קריית עקרון"
            }, 
            new City
            {
                Id = 412,
                Name = "קריית שלמה"
            }, 
            new City
            {
                Id = 2800,
                Name = "קריית שמונה"
            }, 
            new City
            {
                Id = 1766,
                Name = "קרית חינוך עזתה"
            }, 
            new City
            {
                Id = 1746,
                Name = "קרית תעופה"
            }, 
            new City
            {
                Id = 3640,
                Name = "קרני שומרון"
            }, 
            new City
            {
                Id = 4006,
                Name = "קשת"
            }, 
            new City
            {
                Id = 543,
                Name = "ראמה"
            }, 
            new City
            {
                Id = 1334,
                Name = "ראס אל-עין"
            }, 
            new City
            {
                Id = 990,
                Name = "ראס עלי"
            }, 
            new City
            {
                Id = 2640,
                Name = "ראש העין"
            }, 
            new City
            {
                Id = 26,
                Name = "ראש פינה"
            }, 
            new City
            {
                Id = 3602,
                Name = "ראש צורים"
            }, 
            new City
            {
                Id = 8300,
                Name = "ראשון לציון"
            }, 
            new City
            {
                Id = 3795,
                Name = "רבבה"
            }, 
            new City
            {
                Id = 564,
                Name = "רבדים"
            }, 
            new City
            {
                Id = 354,
                Name = "רביבים"
            }, 
            new City
            {
                Id = 1225,
                Name = "רביד"
            }, 
            new City
            {
                Id = 390,
                Name = "רגבה"
            }, 
            new City
            {
                Id = 444,
                Name = "רגבים"
            }, 
            new City
            {
                Id = 1161,
                Name = "רהט"
            }, 
            new City
            {
                Id = 2051,
                Name = "רווחה"
            }, 
            new City
            {
                Id = 2016,
                Name = "רוויה"
            }, 
            new City
            {
                Id = 362,
                Name = "רוחמה"
            }, 
            new City
            {
                Id = 539,
                Name = "רומאנה"
            }, 
            new City
            {
                Id = 997,
                Name = "רומת הייב"
            }, 
            new City
            {
                Id = 3619,
                Name = "רועי"
            }, 
            new City
            {
                Id = 3782,
                Name = "רותם"
            }, 
            new City
            {
                Id = 854,
                Name = "רחוב"
            }, 
            new City
            {
                Id = 8400,
                Name = "רחובות"
            }, 
            new City
            {
                Id = 540,
                Name = "ריחאנייה"
            }, 
            new City
            {
                Id = 3568,
                Name = "ריחן"
            }, 
            new City
            {
                Id = 542,
                Name = "ריינה"
            }, 
            new City
            {
                Id = 3565,
                Name = "רימונים"
            }, 
            new City
            {
                Id = 616,
                Name = "רינתיה"
            }, 
            new City
            {
                Id = 922,
                Name = "רכסים"
            }, 
            new City
            {
                Id = 1069,
                Name = "רם-און"
            }, 
            new City
            {
                Id = 4702,
                Name = "רמות"
            }, 
            new City
            {
                Id = 206,
                Name = "רמות השבים"
            }, 
            new City
            {
                Id = 735,
                Name = "רמות מאיר"
            }, 
            new City
            {
                Id = 445,
                Name = "רמות מנשה"
            }, 
            new City
            {
                Id = 372,
                Name = "רמות נפתלי"
            }, 
            new City
            {
                Id = 8500,
                Name = "רמלה"
            }, 
            new City
            {
                Id = 8600,
                Name = "רמת גן"
            }, 
            new City
            {
                Id = 135,
                Name = "רמת דוד"
            }, 
            new City
            {
                Id = 184,
                Name = "רמת הכובש"
            }, 
            new City
            {
                Id = 335,
                Name = "רמת השופט"
            }, 
            new City
            {
                Id = 2650,
                Name = "רמת השרון"
            }, 
            new City
            {
                Id = 1770,
                Name = "רמת חובב"
            }, 
            new City
            {
                Id = 178,
                Name = "רמת יוחנן"
            }, 
            new City
            {
                Id = 122,
                Name = "רמת ישי"
            }, 
            new City
            {
                Id = 1828,
                Name = "רמת כוכב מ\"א 7"
            }, 
            new City
            {
                Id = 1829,
                Name = "רמת כוכב מ\"א 8"
            }, 
            new City
            {
                Id = 1830,
                Name = "רמת כוכב מ\"א 9"
            }, 
            new City
            {
                Id = 1831,
                Name = "רמת כוכב של\"ש"
            }, 
            new City
            {
                Id = 4701,
                Name = "רמת מגשימים"
            }, 
            new City
            {
                Id = 1837,
                Name = "רמת מנשה מ\"א 13"
            }, 
            new City
            {
                Id = 1838,
                Name = "רמת מנשה של\"ש"
            }, 
            new City
            {
                Id = 339,
                Name = "רמת צבי"
            }, 
            new City
            {
                Id = 460,
                Name = "רמת רזיאל"
            }, 
            new City
            {
                Id = 127,
                Name = "רמת רחל"
            }, 
            new City
            {
                Id = 789,
                Name = "רנן"
            }, 
            new City
            {
                Id = 713,
                Name = "רעים"
            }, 
            new City
            {
                Id = 8700,
                Name = "רעננה"
            }, 
            new City
            {
                Id = 1228,
                Name = "רקפת"
            }, 
            new City
            {
                Id = 247,
                Name = "רשפון"
            }, 
            new City
            {
                Id = 437,
                Name = "רשפים"
            }, 
            new City
            {
                Id = 1260,
                Name = "רתמים"
            }, 
            new City
            {
                Id = 324,
                Name = "שאר ישוב"
            }, 
            new City
            {
                Id = 282,
                Name = "שבי ציון"
            }, 
            new City
            {
                Id = 3571,
                Name = "שבי שומרון"
            }, 
            new City
            {
                Id = 913,
                Name = "שבלי - אום אל-גנם"
            }, 
            new City
            {
                Id = 1286,
                Name = "שגב-שלום"
            }, 
            new City
            {
                Id = 721,
                Name = "שדה אילן"
            }, 
            new City
            {
                Id = 304,
                Name = "שדה אליהו"
            }, 
            new City
            {
                Id = 861,
                Name = "שדה אליעזר"
            }, 
            new City
            {
                Id = 885,
                Name = "שדה בוקר"
            }, 
            new City
            {
                Id = 36,
                Name = "שדה דוד"
            }, 
            new City
            {
                Id = 284,
                Name = "שדה ורבורג"
            }, 
            new City
            {
                Id = 293,
                Name = "שדה יואב"
            }, 
            new City
            {
                Id = 142,
                Name = "שדה יעקב"
            }, 
            new City
            {
                Id = 2008,
                Name = "שדה יצחק"
            }, 
            new City
            {
                Id = 18,
                Name = "שדה משה"
            }, 
            new City
            {
                Id = 259,
                Name = "שדה נחום"
            }, 
            new City
            {
                Id = 329,
                Name = "שדה נחמיה"
            }, 
            new City
            {
                Id = 1058,
                Name = "שדה ניצן"
            }, 
            new City
            {
                Id = 739,
                Name = "שדה עוזיהו"
            }, 
            new City
            {
                Id = 2049,
                Name = "שדה צבי"
            }, 
            new City
            {
                Id = 327,
                Name = "שדות ים"
            }, 
            new City
            {
                Id = 27,
                Name = "שדות מיכה"
            }, 
            new City
            {
                Id = 1223,
                Name = "שדי אברהם"
            }, 
            new City
            {
                Id = 2015,
                Name = "שדי חמד"
            }, 
            new City
            {
                Id = 2057,
                Name = "שדי תרומות"
            }, 
            new City
            {
                Id = 555,
                Name = "שדמה"
            }, 
            new City
            {
                Id = 306,
                Name = "שדמות דבורה"
            }, 
            new City
            {
                Id = 3578,
                Name = "שדמות מחולה"
            }, 
            new City
            {
                Id = 1031,
                Name = "שדרות"
            }, 
            new City
            {
                Id = 741,
                Name = "שואבה"
            }, 
            new City
            {
                Id = 761,
                Name = "שובה"
            }, 
            new City
            {
                Id = 394,
                Name = "שובל"
            }, 
            new City
            {
                Id = 1304,
                Name = "שוהם"
            }, 
            new City
            {
                Id = 614,
                Name = "שומרה"
            }, 
            new City
            {
                Id = 1265,
                Name = "שומרייה"
            }, 
            new City
            {
                Id = 415,
                Name = "שוקדה"
            }, 
            new City
            {
                Id = 456,
                Name = "שורש"
            }, 
            new City
            {
                Id = 1235,
                Name = "שורשים"
            }, 
            new City
            {
                Id = 224,
                Name = "שושנת העמקים"
            }, 
            new City
            {
                Id = 527,
                Name = "שזור"
            }, 
            new City
            {
                Id = 7,
                Name = "שחר"
            }, 
            new City
            {
                Id = 1266,
                Name = "שחרות"
            }, 
            new City
            {
                Id = 865,
                Name = "שיבולים"
            }, 
            new City
            {
                Id = 1267,
                Name = "שיטים"
            }, 
            new City
            {
                Id = 658,
                Name = "שייח' דנון"
            }, 
            new City
            {
                Id = 3641,
                Name = "שילה"
            }, 
            new City
            {
                Id = 1165,
                Name = "שילת"
            }, 
            new City
            {
                Id = 1160,
                Name = "שכניה"
            }, 
            new City
            {
                Id = 873,
                Name = "שלווה"
            }, 
            new City
            {
                Id = 1373,
                Name = "שלווה במדבר"
            }, 
            new City
            {
                Id = 439,
                Name = "שלוחות"
            }, 
            new City
            {
                Id = 812,
                Name = "שלומי"
            }, 
            new City
            {
                Id = 1364,
                Name = "שלומית"
            }, 
            new City
            {
                Id = 1793,
                Name = "שלומציון"
            }, 
            new City
            {
                Id = 366,
                Name = "שמיר"
            }, 
            new City
            {
                Id = 3784,
                Name = "שמעה"
            }, 
            new City
            {
                Id = 432,
                Name = "שמרת"
            }, 
            new City
            {
                Id = 1337,
                Name = "שמשית"
            }, 
            new City
            {
                Id = 1287,
                Name = "שני"
            }, 
            new City
            {
                Id = 1132,
                Name = "שניר"
            }, 
            new City
            {
                Id = 538,
                Name = "שעב"
            }, 
            new City
            {
                Id = 4009,
                Name = "שעל"
            }, 
            new City
            {
                Id = 856,
                Name = "שעלבים"
            }, 
            new City
            {
                Id = 661,
                Name = "שער אפרים"
            }, 
            new City
            {
                Id = 264,
                Name = "שער הגולן"
            }, 
            new City
            {
                Id = 237,
                Name = "שער העמקים"
            }, 
            new City
            {
                Id = 921,
                Name = "שער מנשה"
            }, 
            new City
            {
                Id = 3720,
                Name = "שערי תקווה"
            }, 
            new City
            {
                Id = 232,
                Name = "שפיים"
            }, 
            new City
            {
                Id = 692,
                Name = "שפיר"
            }, 
            new City
            {
                Id = 1803,
                Name = "שפלת יהודה מ\"א 26"
            }, 
            new City
            {
                Id = 1804,
                Name = "שפלת יהודה של\"ש"
            }, 
            new City
            {
                Id = 846,
                Name = "שפר"
            }, 
            new City
            {
                Id = 8800,
                Name = "שפרעם"
            }, 
            new City
            {
                Id = 3649,
                Name = "שקד"
            }, 
            new City
            {
                Id = 1233,
                Name = "שקף"
            }, 
            new City
            {
                Id = 292,
                Name = "שרונה"
            }, 
            new City
            {
                Id = 1114,
                Name = "שריגים (לי-און)"
            }, 
            new City
            {
                Id = 126,
                Name = "שריד"
            }, 
            new City
            {
                Id = 398,
                Name = "שרשרת"
            }, 
            new City
            {
                Id = 1045,
                Name = "שתולה"
            }, 
            new City
            {
                Id = 763,
                Name = "שתולים"
            }, 
            new City
            {
                Id = 2062,
                Name = "תאשור"
            }, 
            new City
            {
                Id = 2061,
                Name = "תדהר"
            }, 
            new City
            {
                Id = 1172,
                Name = "תובל"
            }, 
            new City
            {
                Id = 3558,
                Name = "תומר"
            }, 
            new City
            {
                Id = 1083,
                Name = "תושייה"
            }, 
            new City
            {
                Id = 163,
                Name = "תימורים"
            }, 
            new City
            {
                Id = 10,
                Name = "תירוש"
            }, 
            new City
            {
                Id = 5000,
                Name = "תל אביב -יפו"
            }, 
            new City
            {
                Id = 84,
                Name = "תל יוסף"
            }, 
            new City
            {
                Id = 287,
                Name = "תל יצחק"
            }, 
            new City
            {
                Id = 154,
                Name = "תל מונד"
            }, 
            new City
            {
                Id = 103,
                Name = "תל עדשים"
            }, 
            new City
            {
                Id = 719,
                Name = "תל קציר"
            }, 
            new City
            {
                Id = 1054,
                Name = "תל שבע"
            }, 
            new City
            {
                Id = 1283,
                Name = "תל תאומים"
            }, 
            new City
            {
                Id = 1707,
                Name = "תל-חי"
            }, 
            new City
            {
                Id = 3719,
                Name = "תלם"
            }, 
            new City
            {
                Id = 1051,
                Name = "תלמי אליהו"
            }, 
            new City
            {
                Id = 2003,
                Name = "תלמי אלעזר"
            }, 
            new City
            {
                Id = 2050,
                Name = "תלמי ביל\"ו"
            }, 
            new City
            {
                Id = 1237,
                Name = "תלמי יוסף"
            }, 
            new City
            {
                Id = 727,
                Name = "תלמי יחיאל"
            }, 
            new City
            {
                Id = 744,
                Name = "תלמי יפה"
            }, 
            new City
            {
                Id = 814,
                Name = "תלמים"
            }, 
            new City
            {
                Id = 1244,
                Name = "תמרת"
            }, 
            new City
            {
                Id = 2002,
                Name = "תנובות"
            }, 
            new City
            {
                Id = 752,
                Name = "תעוז"
            }, 
            new City
            {
                Id = 1744,
                Name = "תעשיון בינימין*"
            }, 
            new City
            {
                Id = 1728,
                Name = "תעשיון בר-לב"
            }, 
            new City
            {
                Id = 1714,
                Name = "תעשיון גליל תחתון"
            }, 
            new City
            {
                Id = 1709,
                Name = "תעשיון דלתון"
            }, 
            new City
            {
                Id = 1741,
                Name = "תעשיון השרון"
            }, 
            new City
            {
                Id = 1750,
                Name = "תעשיון חוף יבנה"
            }, 
            new City
            {
                Id = 1742,
                Name = "תעשיון חצב*"
            }, 
            new City
            {
                Id = 1754,
                Name = "תעשיון מבצע*"
            }, 
            new City
            {
                Id = 1749,
                Name = "תעשיון צריפין"
            }, 
            new City
            {
                Id = 1755,
                Name = "תעשיון ראם*"
            }, 
            new City
            {
                Id = 1792,
                Name = "תעשיון שח\"ק"
            }, 
            new City
            {
                Id = 1763,
                Name = "תעשיות ספירים"
            }, 
            new City
            {
                Id = 709,
                Name = "תפרח"
            }, 
            new City
            {
                Id = 665,
                Name = "תקומה"
            }, 
            new City
            {
                Id = 3563,
                Name = "תקוע"
            }, 
            new City
            {
                Id = 970,
                Name = "תראבין א-צאנע (שבט)"
            }, 
            new City
            {
                Id = 1346,
                Name = "תרבין א-צאנע (יישוב)*"
            }, 
            new City
            {
                Id = 778,
                Name = "תרום"
            }

            );
        }
    }
}
