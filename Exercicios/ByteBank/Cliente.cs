namespace ByteBank 
{
    public class Cliente 
    {
        //Propriedades da classe cliente
        public string Nome;
        public string CPF;
        public string Email; 
        private string _Senha; 

        public string Senha
        {
            get {return _Senha;}
        }

        //Construtor, inicializa as propriedades da classe
        public Cliente (string Nome, string CPF, string Email) {
            this.Nome = Nome;
            this.CPF = CPF;
            this.Email = Email;
        }

        //Métodos de acesso
        public bool TrocaSenha (string senha) {
            if((senha.Length > 6) && (senha.Length < 16)){
                this._Senha = senha;
                return true;
            } else {
                return false;
            }
        }
    }
}