using System;
using System.Data;

namespace PC2.Infra.Infra
{
    public interface IDB : IDisposable
    {
        IDbConnection GetConnection();
    }
}
