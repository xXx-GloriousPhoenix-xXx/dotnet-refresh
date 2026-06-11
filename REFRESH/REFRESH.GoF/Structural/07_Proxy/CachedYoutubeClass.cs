namespace REFRESH.GoF.Structural._07_Proxy;

public class CachedYoutubeClass(IThirdPartyYoutubeLib service) : IThirdPartyYoutubeLib
{
    private readonly IThirdPartyYoutubeLib _service = service; 
    private List<Video>? _cachedVideos;
    private readonly Dictionary<Guid, Video> _videoCache = [];

    public async Task DownloadVideoAsync(Guid id, StreamWriter sw)
    {
        Console.WriteLine($"[Proxy] Starting video download {id}...");
        await _service.DownloadVideoAsync(id, sw);
    }

    public async Task<Video> GetVideoInfoAsync(Guid id)
    {
        if (!_videoCache.TryGetValue(id, out var video))
        {
            Console.WriteLine($"[Proxy] Video {id} not found in cache. Downloading from web...");
            video = await _service.GetVideoInfoAsync(id);
            _videoCache[id] = video;
        }
        else
        {
            Console.WriteLine("[Proxy] Returning info quickly from cache.");
        }

        return video;
    }

    public async Task<List<Video>> ListVideosAsync()
    {
        if (_cachedVideos is null)
        {
            Console.WriteLine("[Proxy] Cache is empty. Loading video list from web...");
            _cachedVideos = await _service.ListVideosAsync();
        }
        else
        {
            Console.WriteLine("[Proxy] Returning videos quickly from cache.");
        }

        return _cachedVideos;
    }
}