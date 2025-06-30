using UniVerseEvents.Application.DTOs;

namespace UniVerseEvents.Application.Interfaces
{
    public interface IFeedbackService
    {
        Task SubmitFeedbackAsync(CreateFeedbackDto createFeedbackDto);
    }
}