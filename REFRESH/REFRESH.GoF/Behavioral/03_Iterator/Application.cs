namespace REFRESH.GoF.Behavioral._03_Iterator;

public class Application(SocialSpammer spammer, ISocialNetwork network)
{
    private readonly SocialSpammer _spammer = spammer;
    private readonly ISocialNetwork _network = network;
    public void SendSpamToFriends(Profile profile, string message)
    {
        var iterator = _network.CreateFriendsIterator(profile.Id);
        _spammer.Send(iterator, message);
    }

    public void SendSpamToCoworker(Profile profile, string message)
    {
        var iterator = _network.CreateCoworkerIterator(profile.Id);
        _spammer.Send(iterator, message);
    }
}