using System.Text.Json;

namespace REFRESH.GoF.Structural._07_Proxy;

public class ThirdPartyYoutubeLib(List<Video> videos) : IThirdPartyYoutubeLib
{
    private readonly List<Video> _videos = videos;

    public async Task DownloadVideoAsync(Guid id, StreamWriter sw)
    {
        await Task.Delay(1500);
        var video = await GetVideoInfoAsync(id);
        var json = JsonSerializer.Serialize(video);
        await sw.WriteAsync(json);
    }

    public async Task<Video> GetVideoInfoAsync(Guid id)
    {
        await Task.Delay(500);
        return _videos.FirstOrDefault(v => v.Id == id)
            ?? throw new InvalidOperationException("Video not found");
    }

    public async Task<List<Video>> ListVideosAsync()
    {
        await Task.Delay(1000);
        return _videos;
    }
}
