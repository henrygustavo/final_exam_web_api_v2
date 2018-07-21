namespace Exam.Application.Service.Students
{
    using System.Collections.Generic;
    using AutoMapper;
    using Exam.Application.Dto.Students;
    using Exam.Domain.Repository.Common;

    public class StudentPreGradoApplicationService : IStudentPreGradoApplicationService
    {
        private readonly IUnitOfWork _unitOfWork;

        public StudentPreGradoApplicationService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public List<StudentPreGradoDto> GetAll()
        {
            return Mapper.Map<List<StudentPreGradoDto>>(_unitOfWork.StudentsPreGrado.GetAll());
        }
    }
}
