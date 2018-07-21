namespace Exam.Application.Service.Common
{
    using System.Collections.Generic;

    public interface IBaseApplicationService<TEntityOutPut>
    {

        List<TEntityOutPut> GetAll();

    }
}
