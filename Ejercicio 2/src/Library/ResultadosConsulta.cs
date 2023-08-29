namespace Library {
    public class ResultadoConsulta {
        private bool Validar {get; set;}
        private string Resultado {get; set;}
        public ResultadoConsulta (bool valid, string result) {
            this.Validar = valid;
            this.Resultado = result;
        }

        public bool GetValidar() {
            return this.Validar;
        }
        public string GetResultado() {
            return this.Resultado;
        }

        public void SetValidar(bool validar) {
            this.Validar = validar;
        }
        public void SetResultado(string resultado) {
            if (!string.IsNullOrEmpty(resultado)) {
                this.Resultado = resultado;
            }
        }
    }
}