using ZadanieTechniczne.Model;

namespace ZadanieTechniczne.Serwis
{
    public class Numbers : INumbers
    {
        private List<Numers> list = new List<Numers>();
        //{
        //    new Numers(){Numbers =1},
        //    new Numers(){Numbers =2},
        //    new Numers(){Numbers =3},
        //    new Numers(){Numbers =4},
        //    new Numers(){Numbers =5},
        //    new Numers(){Numbers =6},
        //};

        public Numers num;
        public Numbers()
        {
            dodawanie();
        }
        public void dodawanie()
        {
            for (int i = 0; i < 50; i++)
            {
                num = new Numers()
                {
                    Numbers = i,
                };
                list.Add(num);
            }
        }
 

        public void add(Numers[] numers)
        {

            foreach (var item in numers)
            {
                list.Add(item);
            }
        }

        List<Numers> INumbers.Get()
        {
         return list;
        }
    }
}
