namespace Library {
    public class InfoPaciente {
        private string Name {get; set;}
        private string Id {get; set;}
        private string PhoneNumber {get; set;}
        public InfoPaciente(string name, string id, string phoneNumber) {
            this.Name = name;
            this.Id = id;
            this.PhoneNumber = phoneNumber;
        }

        public string GetName() {
            return this.Name;
        }
        public string GetId() {
            return this.Id;
        }
        public string GetPhoneNumber() {
            return this.PhoneNumber;
        }

        public void SetName(string name) {
            if (!string.IsNullOrEmpty(name)) {
                this.Name = name;
            }
        }
        public void SetId(string id) {
            if (!string.IsNullOrEmpty(id)) {
                this.Id = id;
            }
        }
        public void SetPhoneNumber(string phone) {
            if (!string.IsNullOrEmpty(phone)) {
                this.PhoneNumber = phone;
            }           
        }
    }
}
