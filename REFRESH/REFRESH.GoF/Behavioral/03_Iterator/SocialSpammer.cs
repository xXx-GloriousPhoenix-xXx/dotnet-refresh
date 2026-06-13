namespace REFRESH.GoF.Behavioral._03_Iterator;

public class SocialSpammer
{
    public void Send(IProfileIterator iterator, string message)
    {
        while (iterator.HasNext())
        {
            var profile = iterator.GetNext();
            Console.WriteLine($"Sending message to {profile.Email}: '{message}'");
        }
    }
}
