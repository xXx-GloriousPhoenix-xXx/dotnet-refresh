namespace REFRESH.GoF.Behavioral._03_Iterator;

public interface IProfileIterator
{
    Profile GetNext();
    bool HasNext();
}
