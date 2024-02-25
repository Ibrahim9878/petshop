namespace petshop;

abstract class Animal
{
    private string _nickname;
    public string Nickname
    {
        get { return _nickname; }
        set
        {

            if (value.Length < 3 && value.Length > 18)
            {
                throw new Exception("Length is wrong");
            }
            _nickname = value; 

        }
    }

    private int _age;
    public int Age { get { return _age; } set { if (value < 0 && value > 50) throw new Exception("age is wrong"); _age = value; } 
     }

    public bool Gender { get; set; }

    public int _energy = 100;

    private int _price;
    public int Price { get { return _price; } set { if (value < 0) throw new Exception("Prce is wrong"); _price = value; } }

    public int _mealquantity = 0;

    public Animal()
    {
        _nickname = "";
        _age = 0;
        Gender = false;
        _price = 0;    
    }
    public Animal(string name,int age,bool Gender,int price)
    {
        _nickname=name;
        _age = age;
        this.Gender = Gender;
        this._price = price;
    }
    public virtual void Eat()
    {
        _mealquantity++;
        Console.WriteLine("Nam Nam");
        Thread.Sleep(1000);
        Console.WriteLine("Nam Nam");
        Thread.Sleep(1000);
        Console.WriteLine("I m done");
        Thread.Sleep(1000);
        _energy += 10;
        Console.Clear();
    }
    public virtual void Sleep()
    {
        Console.WriteLine("I m sleeping");
        Thread.Sleep(10000);
        Console.Clear();
        _energy += 10;
    }
    public virtual void Play()
    {
        Console.WriteLine("Im playingg");
        Thread.Sleep(1000);
        _energy -= 10;
    }

    public void Print()
    {
        Console.WriteLine($"Nickname: {_nickname}");
        Console.WriteLine($"Age: {_age}");
        Console.WriteLine($"Gender: {Gender}");
        Console.WriteLine($"Energy: {_energy}");
        Console.WriteLine($"MealQuantıty: {_mealquantity}");
    }
}

internal class Cat : Animal
{
    public string EyeColor { get; set; }
    public Cat():base()
    {
        EyeColor = "";
    }
    public Cat(string name, int age, bool Gender, int price,string eyecolor):base(name,age,Gender,price)
    {
        EyeColor = eyecolor;
    }

    public override void Eat()
    {
        _mealquantity++;
        Console.WriteLine("Nam Nam Cat");
        Thread.Sleep(1000);
        Console.WriteLine("Nam Nam");
        Thread.Sleep(1000);
        Console.WriteLine("I m done");
        Thread.Sleep(1000);
        _energy += 10;
        Console.Clear();
    }
    public virtual void Sleep()
    {
        Console.WriteLine("I m sleeping Cat");
        Thread.Sleep(10000);
        Console.Clear();
        _energy += 10;
    }
    public virtual void Play()
    {
        Console.WriteLine("Im playingg, Cat");
        Thread.Sleep(1000);
        _energy -= 10;
    }

    public void Print()
    {
        base.Print();
        Console.WriteLine($"EyeColor: {EyeColor}");
        Console.WriteLine("================================================");
    }
}

internal class Dog : Animal
{
    public string NoseColor { get; set; }
    public Dog() : base()
    {
        NoseColor = "";
    }
    public Dog(string name, int age, bool Gender, int price, string nosecolor) : base(name, age, Gender, price)
    {
        NoseColor = nosecolor;
    }

    public override void Eat()
    {
        _mealquantity++;
        Console.WriteLine("Nam Nam Dog");
        Thread.Sleep(1000);
        Console.WriteLine("Nam Nam");
        Thread.Sleep(1000);
        Console.WriteLine("I m done");
        Thread.Sleep(1000);
        _energy += 10;
        Console.Clear();
    }
    public virtual void Sleep()
    {
        Console.WriteLine("I m sleeping Dog");
        Thread.Sleep(10000);
        Console.Clear();
        _energy += 10;
    }
    public virtual void Play()
    {
        Console.WriteLine("Im playingg, Dog");
        Thread.Sleep(1000);
        _energy -= 10;
    }

    public void Print()
    {
        base.Print();
        Console.WriteLine($"NoseColor: {NoseColor}");
        Console.WriteLine("================================================");
    }
}

internal class Bird : Animal
{
    public string WingColor { get; set; }
    public Bird() : base()
    {
        WingColor = "";
    }
    public Bird(string name, int age, bool Gender, int price, string wingcolor) : base(name, age, Gender, price)
    {
        WingColor = wingcolor;
    }

    public override void Eat()
    {
        _mealquantity++;
        Console.WriteLine("Nam Nam Bird");
        Thread.Sleep(1000);
        Console.WriteLine("Nam Nam");
        Thread.Sleep(1000);
        Console.WriteLine("I m done");
        Thread.Sleep(1000);
        _energy += 10;
        Console.Clear();
    }
    public virtual void Sleep()
    {
        Console.WriteLine("I m sleeping Bird");
        Thread.Sleep(10000);
        Console.Clear();
        _energy += 10;
    }
    public virtual void Play()
    {
        Console.WriteLine("Im playingg, Bird");
        Thread.Sleep(1000);
        _energy -= 10;
    }

    public void Print()
    {
        base.Print();
        Console.WriteLine($"WingColor: {WingColor}");
        Console.WriteLine("================================================");
    }
}

internal class Fish : Animal
{
    public string QelsemeColor { get; set; }
    public Fish() : base()
    {
        QelsemeColor = "";
    }
    public Fish(string name, int age, bool Gender, int price, string qelsemecolor) : base(name, age, Gender, price)
    {
        QelsemeColor = qelsemecolor;
    }

    public override void Eat()
    {
        _mealquantity++;
        Console.WriteLine("Nam Nam Fish");
        Thread.Sleep(1000);
        Console.WriteLine("Nam Nam");
        Thread.Sleep(1000);
        Console.WriteLine("I m done");
        Thread.Sleep(1000);
        _energy += 10;
        Console.Clear();
    }
    public virtual void Sleep()
    {
        Console.WriteLine("I m sleeping Fish");
        Thread.Sleep(10000);
        Console.Clear();
        _energy += 10;
    }
    public virtual void Play()
    {
        Console.WriteLine("Im playingg, Fish");
        Thread.Sleep(1000);
        _energy -= 10;
    }

    public void Print()
    {
        base.Print();
        Console.WriteLine($"QelsemeColor: {QelsemeColor}");
        Console.WriteLine("================================================");
    }
}


internal class PetShop
{
    public List<Cat> cats { get; set; }
    public List<Dog> dogs { get; set; }
    public List<Bird> birds { get; set; }
    public List<Fish> Fishes { get; set; }

    public void RemoveByNicknameCat(string Nickname)
    {
        bool ischeck = true;
        foreach (var item in cats)
        {
            if (item.Nickname == Nickname)
            {
                cats.Remove(item);
                ischeck = false;
            }
        }
        if (ischeck)
            throw new Exception("Nickname is not found");
    }
    public void RemoveByNicknameDog(string Nickname)
    {
        bool ischeck = true;
        foreach (var item in dogs)
        {
            if (item.Nickname == Nickname)
            {
                dogs.Remove(item);
                ischeck = false;
            }
        }
        if (ischeck)
            throw new Exception("Nickname is not found");
    }
    public void RemoveByNicknameBird(string Nickname)
    {
        bool ischeck = true;
        foreach (var item in birds)
        {
            if (item.Nickname == Nickname)
            {
                birds.Remove(item);
                ischeck = false;
            }
        }
        if (ischeck)
            throw new Exception("Nickname is not found");
    }
    public void RemoveByNicknameFish(string Nickname)
    {
        bool ischeck = true;
        foreach (var item in Fishes)
        {
            if (item.Nickname == Nickname)
            {
                Fishes.Remove(item);
                ischeck = false;
            }
        }
        if (ischeck)
            throw new Exception("Nickname is not found");
    }

    public void AddByNicknameCat(string nickname)
    {
        bool ischeck = true;
        foreach (var item in cats)
        {
            if (item.Nickname == nickname)
            {
                cats.Add(item);
                ischeck = false;
            }
        }
        if (ischeck)
            throw new Exception("Nickname is not found");
    }
    public void AddByNicknameDog(string nickname)
    {
        bool ischeck = true;
        foreach (var item in dogs)
        {
            if (item.Nickname == nickname)
            {
                dogs.Add(item);
                ischeck = false;
            }
        }
        if (ischeck)
            throw new Exception("Nickname is not found");
    }
    public void AddByNicknameBirds(string nickname)
    {
        bool ischeck = true;
        foreach (var item in birds)
        {
            if (item.Nickname == nickname)
            {
                birds.Add(item);
                ischeck = false;
            }
        }
        if (ischeck)
            throw new Exception("Nickname is not found");
    }
    public void AddByNicknameFishes(string nickname)
    {
        bool ischeck = true;
        foreach (var item in Fishes)
        {
            if (item.Nickname == nickname)
            {
                Fishes.Add(item);
                ischeck = false;
            }
        }
        if (ischeck)
            throw new Exception("Nickname is not found");
    }

    public Cat SearchByNicknameCat(string nickname)
    {
        foreach (Cat item in cats)
        {
            if (item.Nickname == nickname)
            {
                return item;
            }
        }
        throw new Exception("Nickname is not found");
    }
    public Dog SearchByNicknameDog(string nickname)
    {
        foreach (Dog item in dogs)
        {
            if (item.Nickname == nickname)
            {
                return item;
            }
        }
        throw new Exception("Nickname is not found");
    }
    public Bird SearchByNicknameBird(string nickname)
    {
        foreach (Bird item in birds)
        {
            if (item.Nickname == nickname)
            {
                return item;
            }
        }
        throw new Exception("Nickname is not found");
    }
    public Fish SearchByNicknameFish(string nickname)
    {
        foreach (Fish item in Fishes)
        {
            if (item.Nickname == nickname)
            {
                return item;
            }
        }
        throw new Exception("Nickname is not found");
    }

    public void Print()
    {
        Console.WriteLine("Cats");
        foreach (var i in cats)
            i.Print();
        Console.WriteLine("Dogs");
        foreach (var i in dogs)
            i.Print();
        Console.WriteLine("Birds");
        foreach (var i in birds)
            i.Print();
        Console.WriteLine("Fihes");
        foreach (var i in Fishes)
            i.Print();
    }
}

