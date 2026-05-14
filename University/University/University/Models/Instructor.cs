using System.ComponentModel.DataAnnotations.Schema;

namespace University.Models
{
    public class Instructor
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        [Column("FirstName")]
        public string FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }

        //mis on ICollection
        // ICollection kasutatakse siis,
        // kui ühel objektil võib olla mitu seotud objekti.
        // Näiteks: ühel õpetajal võib olla mitu kursust.
        public ICollection<CourseAssigment> CourseAssigments { get; set; }

        //miks siin ei kasutata Icollection, vaid lihtsalt OfficeAssignment
        // Siin ei kasutata ICollection-i,
        // sest ühel õpetajal saab olla ainult üks kabinet.
        // Seetõttu kasutatakse ainult ühte OfficeAssignment objekti,
        // mitte tervet listi või kogumit.
        // "one-to-one" tähendab: üks õpetaja ↔ üks kabinet
        public OfficeAssigment OfficeAssignments { get; set; }
    }
}

