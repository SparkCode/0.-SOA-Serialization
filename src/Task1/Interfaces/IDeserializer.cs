namespace Serialization.Interfaces
{
    public interface IDeserializer<in T, out TR>
    {
        TR Deserialize(T obj);
    }
}
