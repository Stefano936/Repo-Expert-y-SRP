using System.Net.NetworkInformation;

namespace Library {
    public class Paciente {
        private InfoPaciente InfoPaciente { get; set; }
        public Paciente(InfoPaciente pi) {
            this.InfoPaciente = pi;
        }

        public InfoPaciente GetInfoPaciente() {
            return this.InfoPaciente;
        }

        public void SetInfoPaciente(InfoPaciente pi) {
            if (pi != null) {
                this.InfoPaciente = pi;
            }
        }
    }
}