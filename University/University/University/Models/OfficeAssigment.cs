using System.ComponentModel.DataAnnotations;

namespace University.Models
{
    public class OfficeAssigment
    {
        //kui soovite konkreetselt välja tuua, et InstructorId on nii OffficeAssignmenti
        //peamine võik olla ka võõrvõti, siis saate kasutada [Key] ja [foreignKey] atribute: 
        [Key]
        public int InstructorId { get; set; }

        public string Location { get; set; } = string.Empty;

        public Instructor Instructor { get; set; }

    }
}
