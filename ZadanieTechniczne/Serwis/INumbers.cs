using ZadanieTechniczne.Model;

namespace ZadanieTechniczne.Serwis
{
    public interface INumbers
    {
        List<Numers> Get();
         void add(Numers[] numers);
    }
}
