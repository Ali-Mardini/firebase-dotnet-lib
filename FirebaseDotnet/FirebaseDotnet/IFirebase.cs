using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FirebaseDotnet
{
    public interface IFirebase
    {
        public Task<List<dynamic>> GetAll();

        public Task<dynamic> GetSingleOrDefault();

        public Task<dynamic> CreateRecord();
    }
}
