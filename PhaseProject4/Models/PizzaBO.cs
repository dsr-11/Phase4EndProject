using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PhaseProject4.Models;

namespace PhaseProject4.Models
{
    public class PizzaBO
    {
        public static List<Pizza> p_list;
        public PizzaBO()
        {
            p_list = new List<Pizza>
            {
                new Pizza{ pid=1, pname="Golden Corn", crust="Regular", desc="Sweet golden corn for taste", price=85,
                    image_url= "https://www.dominos.co.in/files/items/Corn_&_Cheese.jpg"
                },
                new Pizza{ pid=2, pname="Farmhouse", crust="Medium", 
                    desc="Delightful combination of onion, capsicum & mushroom", price=399,
                    image_url="https://www.dominos.co.in/files/items/Farmhouse.jpg"
                },
                new Pizza{ pid=3, pname="Peppy Paneer", crust="Large",
                    desc="Flavorful trio of juicy paneer with spicy red paprika", price=599,
                    image_url="https://www.dominos.co.in//files/items/Peppy_Paneer.jpg"
                },
                new Pizza{ pid=4, pname="Veggie Paradise", crust="Medium",
                    desc="Golden corn, black olives, capsicum, red paprika",price=399,
                    image_url="https://www.dominos.co.in/files/items/Digital_Veggie_Paradise_olo_266x265.jpg"
                },
                new Pizza{pid=5, pname="Margherita", crust="Large",
                    desc="Classic delight with 100% real mozzarella cheese", price=399,
                    image_url="https://www.dominos.co.in/files/items/Margherit.jpg"
                },
                new Pizza{ pid=6, pname="Veg Extravaganza", crust="Large",
                    desc="Black olives, capsicum, onion, corn, jalapeno & extra cheese", price=599,
                    image_url="https://www.dominos.co.in/files/items/Veg_Extravaganz.jpg"
                },
                  new Pizza{ pid=7, pname="Mexican Green Wave", crust="Medium", 
                      desc="Mexicam herbs sprinkled on onion & jalapeno", price=399,
                    image_url="https://www.dominos.co.in/files/items/Mexican_Green_Wave.jpg"
                },
                  new Pizza{ pid=8, pname="Indi Tandoori Paneer", crust="Large",
                    desc="Tandoori paneer with capsicum, red paprika & mint mayo", price=599,
                    image_url="https://www.dominos.co.in/files/items/IndianTandooriPaneer.jpg"
                }
            };

        }
        public List<Pizza> GetItems()
        {
            return p_list;
        }
        public Pizza GetItemById(int id)
        {
            return p_list.Find(x => x.pid == id);
        }
        public string GetItemByName(int id)
        {
            var key = p_list.Find(x => x.pid == id);
            return key.pname;
        }
    }
}
