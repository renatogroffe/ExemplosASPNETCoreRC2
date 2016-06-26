using System;

namespace TesteInjDependencia
{
    public class TesteInjDependenciaA : ITesteInjDependenciaA
    {
        public Guid IdReferencia { get; }

        public TesteInjDependenciaA()
        {
            this.IdReferencia = Guid.NewGuid();
        }
    }

    public class TesteInjDependenciaB : ITesteInjDependenciaB
    {
        public Guid IdReferencia { get; }

        public TesteInjDependenciaB()
        {
            this.IdReferencia = Guid.NewGuid();
        }
    }

    public class TesteInjDependenciaC
    {
        public Guid IdReferencia { get; }

        public TesteInjDependenciaC()
        {
            this.IdReferencia = Guid.NewGuid();
        }
    }
}