using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            InfoPaciente infoPaciente = new InfoPaciente("Steven Jhonson", "986782342", "5555-555-555");
            ConsultaMedica consultaMedica = new ConsultaMedica(DateTime.Now, "Wall Street", "Armand");
            Paciente paciente1 = new Paciente(infoPaciente);
            AppointmentService ass = new AppointmentService(paciente1, consultaMedica);

            Console.WriteLine(ass.Schedule().GetResultado());

            InfoPaciente InfoPaciente2 = new InfoPaciente("Ralf Manson", "", "5555-555-555");
            ConsultaMedica consultaMedica2 = new ConsultaMedica(DateTime.Now, "Queen Street", "");
            Paciente paciente2 = new Paciente(InfoPaciente2);
            AppointmentService ass2 = new AppointmentService(paciente2, consultaMedica2);

            Console.WriteLine(ass2.Schedule().GetResultado());
        }
    }
}
