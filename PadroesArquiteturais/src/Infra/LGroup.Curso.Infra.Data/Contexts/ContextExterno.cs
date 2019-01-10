namespace LGroup.Curso.Infra.Data.Contexts
{
    public class ContextExterno 
        : ContextBase<ContextExterno>
    {
        public ContextExterno() 
            : base("strcon1")
        {}
    }
}
