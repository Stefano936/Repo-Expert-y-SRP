using System;
using System.Text;

namespace Library
{
    public class AppointmentService
    {
        private ConsultaMedica ConsultaMedica { get; set;}
        private Paciente Pacient { get; set;}
        public AppointmentService(Paciente pacient, ConsultaMedica cm) {
            this.ConsultaMedica = cm;
            this.Pacient = pacient;
        }
        public ResultadoConsulta Schedule() {
            return this.CheckAppointment();
        }
        private ResultadoConsulta CheckAppointment() {
            StringBuilder stringBuilder = new StringBuilder("Scheduling appointment...\n");
            Boolean isValid = true;

            InfoPaciente ip = this.Pacient.GetInfoPaciente();
            string name = ip.GetName();
            string id = ip.GetId();
            string phoneNumber = ip.GetPhoneNumber();

            ConsultaMedica dm = this.ConsultaMedica;
            string appoinmentPlace = dm.GetAppointmentPlace();
            string doctorName = dm.GetDoctorName();

            if (string.IsNullOrEmpty(name))
            {
                stringBuilder.Append("Unable to schedule appointment, 'name' is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(id))
            {
                stringBuilder.Append("Unable to schedule appointment, 'id' is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(phoneNumber))
            {
                stringBuilder.Append("Unable to schedule appointment, 'phone number' is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(appoinmentPlace))
            {
                stringBuilder.Append("Unable to schedule appointment, 'appoinment place' is required\n");
                isValid = false;
            }


            if (string.IsNullOrEmpty(doctorName))
            {
                stringBuilder.Append("Unable to schedule appointment, 'doctor name' is required\n");
                isValid = false;
            }

            if (isValid)
            {
                stringBuilder.Append("Appoinment scheduled");
            }

            return new ResultadoConsulta(isValid, stringBuilder.ToString());
        }
    }
}

/*
La critica que le podemos realizar a este codigo, es que debemos dividir el codigo, en 5 clases distintas
(ConsultaMedica, ResultadosConsulta, Paciente, InfoPaciente y AppointmentService), esto debido a que en el
codigo dado, se puede observar como una misma clase tiene responsabilidades que no le corresponden, por ejemplo
el nombre del paciente, información del paciente, entre otras cosas. 
*/