namespace Generic_Collections_Datastructure
{
    public abstract class Product
    {
        //  Product abstrakt class
        //- Id - qıraqdan set etmək olmayacaq yalnız get etmək olacaq və hər dəfə yeni bir Book obyekt yaradıldıqda avtomatik bir vahid artacaq.
        //- Name
        //- Price
        //- Count
        //- TotalInCome - book satışlarından alınan gəlir sadəcə Productın miras verdiyi class-larda set etmək olar
        //- Sell() - abstrakt method olacaq
        //- ShowInfo() - abstrakt method olacaq
        public int Id { get; set; }
        private static int _id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public static int Count { get; set; }
        protected static double TotalInCome { get; set; }


        public Product()
        {
            Count++;
            _id++;
            Id = _id;
        }
        public abstract void Sell();
        public abstract void ShowInfo();



    }
}
