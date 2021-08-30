using exerc01.Classes.Enum;

namespace exerc01.Classes
{
    class Funcionario
    {

        public int Id { get; set; }
        public string Nome { get; set; }
        public TipoFuncionario TipoFunc { get; set; }

        public Funcionario()
        {

        }

        public Funcionario(int id, string nome, TipoFuncionario tipoFunc)
        {
            Id = id;
            Nome = nome;
            TipoFunc = tipoFunc;
        }

        public override string ToString()
        {
            return $"ID: {Id} Nome: {Nome} Especialização: {TipoFunc}";
        }
    }
}
