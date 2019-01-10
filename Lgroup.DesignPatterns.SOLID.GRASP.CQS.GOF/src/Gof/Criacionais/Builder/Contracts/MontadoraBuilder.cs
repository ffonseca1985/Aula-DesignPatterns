using Builder.Model;

namespace Builder.Contracts
{
    public abstract class MontadoraBuilder
    {
        protected Carro Carro { get; set; }
        protected MontadoraBuilder()
        {
            Carro = new Carro();
        } 
        public abstract void BuildMotor(string tipo);
        public abstract void BuildAno(int ano);
        public abstract void BuildCor(string cor);
        public abstract void BuildAdiciais(bool tem);
        public abstract void BuildLicenciamento(bool tem);
        public abstract void BuildPreco(decimal preco);
        public Carro GetCarro()
        {
            return this.Carro;
        }
    }
}
