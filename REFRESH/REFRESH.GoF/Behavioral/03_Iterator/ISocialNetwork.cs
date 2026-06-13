namespace REFRESH.GoF.Behavioral._03_Iterator;
public interface ISocialNetwork
{
    IProfileIterator CreateFriendsIterator(Guid profileId);
    IProfileIterator CreateCoworkerIterator(Guid profileId);
}
