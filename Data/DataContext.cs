using Hospital.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Hospital.Data.Entities
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
        //Constructor
        public DataContext(DbContextOptions<DataContext> x): base(x)
        {

        }
        //Relacion Patient, MedicalHistory
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MedicalHistory>()
                .HasOne(mh => mh.Patient)
                .WithOne(p => p.MedicalHistory)
                .HasForeignKey<Patient>(p => p.MedicalHistoryId); // Define the foreign key property here
            
            //para medicalhistory
            modelBuilder.Entity<Patient>()
                .HasOne(p => p.MedicalHistory)
                .WithOne(mh => mh.Patient)
                .HasForeignKey<MedicalHistory>(mh => mh.PatientId);
            //para patientdetails
            modelBuilder.Entity<Patient>()
                .HasOne(p => p.PatientDetails)
                .WithOne(pd => pd.Patient)
                .HasForeignKey<PatientDetail>(pd => pd.PatientId);

            modelBuilder.Entity<PatientDetail>()
                .HasOne(pd => pd.Patient)
                .WithOne(p => p.PatientDetails)
                .HasForeignKey<Patient>(p => p.PatientDetailId);
        }
    }
}