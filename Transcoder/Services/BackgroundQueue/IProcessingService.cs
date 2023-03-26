using Transcoder.Model;

namespace Transcoder.Services.BackgroundQueue;

public interface IProcessingService
{
    Task Run(BaseProcessingJob transcodeProcessingJob);
}