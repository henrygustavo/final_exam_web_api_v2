namespace Exam.Domain.Repository.Common
{
    using Exam.Domain.Repository.Students;
    using System;
    public interface IUnitOfWork : IDisposable
    {
        IStudentRepository Students { get; }

        IStudentPreGradoRepository StudentsPreGrado { get; }

        IStudentMaestriaRepository StudentsMaestria { get; }

        IStudentDoctoradoRepository StudentsDoctorado { get; }

        int Complete();
    }
}
