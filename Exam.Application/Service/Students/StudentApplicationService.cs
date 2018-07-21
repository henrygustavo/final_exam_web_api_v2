namespace Exam.Application.Service.Students
{
    using System.Collections.Generic;
    using AutoMapper;
    using Exam.Application.Dto.Students;
    using Exam.Domain.Repository.Common;

    public class StudentApplicationService : IStudentApplicationService
    {
        private readonly IUnitOfWork _unitOfWork;

        public StudentApplicationService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public List<StudentDto> GetAll()
        {
            return Mapper.Map<List<StudentDto>>(_unitOfWork.Students.GetAll());
        }
    }
}
