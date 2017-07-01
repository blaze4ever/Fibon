using System;
using System.Collections.Generic;

namespace Fibon.Api.Repository
{
    public interface IRepository
    {
         void Add(int number, int result);
         int? Get(int number);
    }

    
}