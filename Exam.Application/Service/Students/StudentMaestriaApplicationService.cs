namespace Exam.Application.Service.Students
{
    using System.Collections.Generic;
    using AutoMapper;
    using Exam.Application.Dto.Students;
    using Exam.Domain.Repository.Common;

    public class StudentMaestriaApplicationService : IStudentMaestriaApplicationService
    {
        private readonly IUnitOfWork _unitOfWork;

        public StudentMaestriaApplicationService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public List<StudentMaestriaDto> GetAll()
        {
            return Mapper.Map<List<StudentMaestriaDto>>(_unitOfWork.StudentsMaestria.GetAll());
        }
    }
}
