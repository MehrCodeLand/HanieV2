using System.ComponentModel.DataAnnotations;

namespace HanieV2.Data.Model.PaintsObj
{
    public class Paint
    {
        [Key]
        public int PaintId { get; set; }
        public int MyPaintId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Created { get; set; }
        public string PaintImageName { get; set; }
    }
}
