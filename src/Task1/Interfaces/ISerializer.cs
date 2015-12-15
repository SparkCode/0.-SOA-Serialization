namespace Serialization.Interfaces
{
    public interface ISerializer<in T, out TR>
    {
        TR Serialize(T obj);
    }
}
