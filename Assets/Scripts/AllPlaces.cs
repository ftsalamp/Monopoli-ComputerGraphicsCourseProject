using UnityEngine;
public class AllPlaces : MonoBehaviour {
    Place[] places;

    AllPlaces()
    {
        places = new Place[12];
        places[0].Name = "Αφετερία";
        places[0].Price = 0;
        places[0].Rent = 0;
        places[0].BuildPrice = 0;

        places[1].Name = "Φαλιράκι";
        places[1].Price = 2000;
        places[1].Rent = 300;
        places[1].BuildPrice = 180;

        places[2].Name = "Λευκός Πύργος";
        places[2].Price = 2500;
        places[2].Rent = 320;
        places[2].BuildPrice = 200;

        places[3].Name = "Πήγαινε στην Φυλακή";
        places[3].Price = 0;
        places[3].Rent = 0;
        places[3].BuildPrice = 0;

        places[4].Name = "Εντόλή";
        places[4].Price = 0;
        places[4].Rent = 0;
        places[4].BuildPrice = 0;

        places[5].Name = "Αεροδρόμιο Ρόδου";
        places[5].Price = 3500;
        places[5].Rent = 420;
        places[5].BuildPrice = 300;

        places[6].Name = "Ελεύθερη Στάθμευση";
        places[6].Price = 0;
        places[6].Rent = 0;
        places[6].BuildPrice = 0;

        places[7].Name = "Τσιμισκή";
        places[7].Price = 1500;
        places[7].Rent = 220;
        places[7].BuildPrice = 100;

        places[8].Name = "Κολοσσός";
        places[8].Price = 3000;
        places[8].Rent = 400;
        places[8].BuildPrice = 280;

        places[9].Name = "Φυλακή";
        places[9].Price = 0;
        places[9].Rent = 0;
        places[9].BuildPrice = 0;

        places[10].Name = "Απόφαση";
        places[10].Price = 0;
        places[10].Rent = 0;
        places[10].BuildPrice = 0;

        places[11].Name = "Αεροδρόμιο Θεσσαλονίκης";
        places[11].Price = 0;
        places[11].Rent = 0;
        places[11].BuildPrice = 0;
    }
    // Use this for initialization
    void Start () {
        //AllPlaces();
    }

    // Update is called once per frame
    void Update () {
	
	}
}
