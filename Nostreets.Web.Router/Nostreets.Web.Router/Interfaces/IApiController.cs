using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Nostreets.Web.Router.Interfaces
{
    public interface IApiController<T, IdType>
    {
        HttpResponseMessage Get(IdType id);
        HttpResponseMessage GetAll();
        HttpResponseMessage Insert(T data);
        HttpResponseMessage Update(T data);
        HttpResponseMessage Delete(IdType id);
    }

    public interface IApiController<IdType, AddType, UpdateType>
    {
        HttpResponseMessage Get(IdType id);
        HttpResponseMessage GetAll();
        HttpResponseMessage Insert(AddType data);
        HttpResponseMessage Update(UpdateType data);
        HttpResponseMessage Delete(IdType id);
    }

}
