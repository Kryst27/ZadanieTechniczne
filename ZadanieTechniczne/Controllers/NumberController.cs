using Microsoft.AspNetCore.Mvc;
using ZadanieTechniczne.Model;
using ZadanieTechniczne.Serwis;

namespace ZadanieTechniczne.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NumberController : ControllerBase
    {
        public  List<Numers> Numerss = new List<Numers>();
        Numers numb;
        List<Numers> d;
        private readonly INumbers Numbers;
        public NumberController(INumbers Numbers)
        {
            this.Numbers = Numbers;
            //for (int i = 0; i < 500; i++)
            //{
            //    numb=new Numers() 
            //    { 
            //        Numbers = i,
                    
            //    };
            //    Numerss.Add(numb);
            //};
        }
        [HttpGet("/numbers")]
        public List<Numers> NumersGet()
        {
            var d = Numbers.Get();
            return d;
        }
        [HttpGet]
        [Route("/numbers/sorted")]
        public List<Numers> NumersGetWithSort([FromQuery] string sort ="acs")
        {
            var lista = Numbers.Get();
            lista = sort.ToLower() == "desc"
                ? lista.OrderByDescending(x => x.Numbers).ToList()
                : lista.OrderBy(x => x.Numbers).ToList();
            return lista;
        }
        
        [HttpGet]
        [Route("/numbers/search")]
        public Dictionary<int,bool> NumerbsGetByValue([FromQuery] int value)
        {
            Dictionary<int, bool> wynik = new Dictionary<int, bool>();
            var lista = Numbers.Get();
           var wyn= lista.FirstOrDefault(x => x.Numbers==value);
            if (wyn.Numbers == value)
            {
                wynik.Add(wyn.Numbers, true);
            }
            else
            {
                wynik.Add(wyn.Numbers, false);

            }
            return wynik;
        }
        [HttpPost("/numbers")]
        public void PostNumber(Numers[] numbers)
        {
            Numbers.add(numbers);
        }
        [HttpGet]
        [Route("/numers/stats")]
        public Tuple<double,double> GetStatNumbers() 
        {
            Tuple<double, double> parawynikowa;
            var list = Numbers.Get();
            int sum =0;
            foreach (var number in list) 
            { 
                
                 sum += number.Numbers;

            }
           var srednia = sum / list.Count();
            var pol = list.Count() / 2;
            int mediana = 0;
            foreach (var item in list)
            {
                pol--;
                if (pol==0)
                {
                     mediana = item.Numbers;
                }
            }
                
            parawynikowa = new Tuple<double,double>(srednia, mediana);


            return parawynikowa;
        }
    }
}
