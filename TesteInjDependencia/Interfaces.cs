using System;

namespace TesteInjDependencia
{
    public interface ITesteInjDependenciaA
    {
        Guid IdReferencia { get; }
    }

    public interface ITesteInjDependenciaB
    {
        Guid IdReferencia { get; }
    }
}