namespace Exam.Application.Service.Students
{

    using System.Collections.Generic;
    using AutoMapper;
    using Exam.Application.Dto.Students;
    using Exam.Domain.Repository.Common;

    public class StudentDoctoradoApplicationService : IStudentDoctoradoApplicationService
    {
        private readonly IUnitOfWork _unitOfWork;

        public StudentDoctoradoApplicationService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public List<StudentDoctoradoDto> GetAll()
        {
            return Mapper.Map<List<StudentDoctoradoDto>>(_unitOfWork.StudentsDoctorado.GetAll());
        }
    }
}
