namespace REFRESH.GoF.Behavioral._03_Iterator;

public class Facebook : ISocialNetwork
{
    private readonly Dictionary<Guid, List<Profile>> _friends = [];
    private readonly Dictionary<Guid, List<Profile>> _coworkers = [];
    public void AddFriend(Guid profileId, Profile friend)
    {
        if (!_friends.ContainsKey(profileId)) _friends[profileId] = [];
        _friends[profileId].Add(friend);
    }

    public void AddCoworker(Guid profileId, Profile coworker)
    {
        if (!_coworkers.ContainsKey(profileId)) _coworkers[profileId] = [];
        _coworkers[profileId].Add(coworker);
    }
    public IProfileIterator CreateFriendsIterator(Guid profileId)
    {
        var list = _friends.GetValueOrDefault(profileId) ?? [];
        return new FacebookIterator(list);
    }

    public IProfileIterator CreateCoworkerIterator(Guid profileId)
    {
        var list = _coworkers.GetValueOrDefault(profileId) ?? [];
        return new FacebookIterator(list);
    }
}
