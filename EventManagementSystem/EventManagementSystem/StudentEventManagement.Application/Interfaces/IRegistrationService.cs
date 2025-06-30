using UniVerseEvents.Application.DTOs;

namespace UniVerseEvents.Application.Interfaces
{
    public interface IRegistrationService
    {
        Task RegisterStudentForEventAsync(CreateRegistrationDto createRegistrationDto);
    }
}