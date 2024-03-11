using Hospital.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Eventos.Web.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<TheHospital> Hospitals { get; set; }
        public DbSet<ImageTaken> ImagesTaken { get; set; }
        public DbSet<Lab> Labs { get; set; }
        public DbSet<MedicalHistory> MedicalHistorys { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<PatientDetail> PatientDetails { get; set; }
    }
}