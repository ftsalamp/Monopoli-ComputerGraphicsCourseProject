public class Place {

	private string name;
	private int price, rent, buildPrice;
	private bool[] builtHomes;

    public string Name
    {
        get
        {
            return name;
        }

        set
        {
            name = value;
        }
    }

    public int Price
    {
        get
        {
            return price;
        }

        set
        {
            price = value;
        }
    }

    public int Rent
    {
        get
        {
            return rent;
        }

        set
        {
            rent = value;
        }
    }

    public int BuildPrice
    {
        get
        {
            return buildPrice;
        }

        set
        {
            buildPrice = value;
        }
    }

    Place(){
		builtHomes = new bool[4];
        for(int i=0;i<builtHomes.Length;i++)
        {
            builtHomes[i]= false;
        }
	}


}