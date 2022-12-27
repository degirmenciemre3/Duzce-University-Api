using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DuzceUniversityWebApi.Model
{
    public interface IYayinRepository
    {
        IQueryable<Yayin> Yayinlars { get; }
        void SaveYayin(Yayin y);
        void CreateYayin(Yayin y);
        void DeleteYayin(Yayin y);
    }
}
