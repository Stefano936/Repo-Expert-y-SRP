using System;

namespace Library {
    public class ConsultaMedica {
        private DateTime Date {get; set;}
        private string AppointmentPlace {get; set;}
        private string DoctorName {get; set;}
        public ConsultaMedica (DateTime date, string place, string doctorName) {
            this.Date = date;
            this.AppointmentPlace = place;
            this.DoctorName = doctorName;
        }

        public DateTime GetDateTime() {
            return this.Date;
        }
        public string GetAppointmentPlace() {
            return this.AppointmentPlace;
        }
        public string GetDoctorName() {
            return this.DoctorName;
        }

        public void SetDateTime(DateTime dateTime) {
            if (dateTime != DateTime.MinValue) {
                this.Date = dateTime;
            }
        }
        public void SetAppointmentPlace(string appoinmentPlace) {
            if (!string.IsNullOrEmpty(appoinmentPlace)) {
                this.AppointmentPlace = appoinmentPlace;
            }
        }
        public void SetDoctorName(string doctorName) {
            if (!string.IsNullOrEmpty(doctorName)) {
                this.DoctorName = doctorName;
            }
        }
    }
}