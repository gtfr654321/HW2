namespace HW2
{
    public partial class MainPage : ContentPage
    {
        

        public MainPage()
        {
            List<Fruit> list = new List<Fruit>()
            {
                new Fruit { Name = "Apple", Image = "apple.png", Description = "An apple is a sweet, edible fruit produced by an apple tree (Malus domestica)." },
                new Fruit { Name = "Banana", Image = "banana.png", Description = "A banana is an edible fruit – botanically a berry – produced by several kinds of large herbaceous flowering plants in the genus Musa." },
                new Fruit { Name = "Cherry", Image = "cherry.png", Description = "A cherry is the fruit of many plants of the genus Prunus, and is a fleshy drupe (stone fruit)." },
                new Fruit { Name = "Kiwi", Image = "kiwi.png", Description = "Kiwi or kiwis are flightless birds native to New Zealand, in the genus Apteryx and family Apterygidae." },
                new Fruit { Name = "Orange", Image = "orange.png", Description = "The orange is the fruit of the citrus species Citrus × sinensis in the family Rutaceae." },
                new Fruit { Name = "Pear", Image = "pear.png", Description = "The pear is any of several tree and shrub species of genus Pyrus, in the family Rosaceae." },
                new Fruit { Name = "Strawberry", Image = "strawberry.png", Description = "The garden strawberry is a widely grown hybrid species of the genus Fragaria, collectively known as the strawberries." },
                new Fruit { Name = "Watermelon", Image = "watermelon.png", Description = "Watermelon Citrullus lanatus var. lanatus is a scrambling and trailing vine in the flowering plant family Cucurbitaceae." }
             };
            InitializeComponent();
            FruitListView.ItemsSource = list;
            
        }

        private void FruitListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

            if (e.SelectedItem == null)
                return;
            var selectedItem = e.SelectedItem as Fruit;
            DisplayAlert("Selected", selectedItem.Name,"OK");
            ((ListView)sender).SelectedItem = null;
        }
    }
}