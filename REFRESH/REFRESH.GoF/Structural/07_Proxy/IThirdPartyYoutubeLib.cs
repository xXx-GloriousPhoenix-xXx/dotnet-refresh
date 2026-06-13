namespace REFRESH.GoF.Structural._07_Proxy;

public interface IThirdPartyYoutubeLib
{
    Task<List<Video>> ListVideosAsync();
    Task<Video> GetVideoInfoAsync(Guid id);
    Task DownloadVideoAsync(Guid id, StreamWriter sw);
}
