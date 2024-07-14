

namespace From_HoME_wORK
{
	public class brand
	{
        public brand()
        {



        }
public class Brand
        {
            public int Id { get; set; }
            public string Name { get; set; }

            public ICollection<Model> Models { get; set; }
        }

    }
}


