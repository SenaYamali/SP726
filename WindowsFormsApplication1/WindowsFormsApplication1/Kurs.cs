namespace WindowsFormsApplication1
{
    public class Kurs
    {public int KursId { get; set; }
        public string KursAdi  { get; set; }
        public string KursAdresi { get; set; }
        public Ogrenci KursOgrenciId { get; set; }
    }
}