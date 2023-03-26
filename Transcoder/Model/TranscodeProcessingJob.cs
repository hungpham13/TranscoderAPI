namespace Transcoder.Model;

public class TranscodeProcessingJob : BaseProcessingJob
{
    public TranscodeJob JobInfo { get; set; }
    
    public TranscodeProcessingJob(TranscodeJob jobInfo, CancellationTokenSource cancellationTokenSource)
    {
        JobInfo = jobInfo;
    }
}