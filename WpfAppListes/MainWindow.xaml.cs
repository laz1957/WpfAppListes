using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfAppListes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Person> persons;
        public MainWindow()
        {
            InitializeComponent();

            persons= new Persons();
            persons.Add(new Person { Name = "Вася", Company = "ТАрара" });
            persons.Add(new Person { Name = "Толя", Company = "Клопня" });
            persons.Add(new Person { Name = "Петя", Company = "Полет" });
            ComboBox4.ItemsSource = new Person[]
        {
            new Person { Name = "Tom", Company = "Microsoft" },
            new Person { Name = "Bob", Company = "Google" },
            new Person { Name = "Sam", Company = "JetBrains" }
        };

            List<User> items = new List<User>();
            items.Add(new User() { Name = "John Doe", Age = 42, Mail = "john@doe-family.com" });
            items.Add(new User() { Name = "Jane Doe", Age = 39, Mail = "jane@doe-family.com" });
            items.Add(new User() { Name = "Sammy Doe", Age = 13, Mail = "sammy.doe@gmail.com" });
            lvDataBinding.ItemsSource = items;


        }
    }



    public class Person
    {
        public string Name { get; set; } = "";
        public string Company { get; set; } = "";
        public override string ToString() => $"{Name} ({Company})";
    }
    public class Persons : ObservableCollection<Person>
    {
         public Persons() { 
            Add(new Person { Name = "Вася", Company = "ТАрара" });
            Add(new Person { Name = "Толя", Company = "Клопня" });
            Add(new Person { Name = "Петя", Company = "Полет" });
        }
    }
    public class Phone
    {
        public string Title { get; set; }
        public string Company { get; set; }
        public int Price { get; set; }
    }

    public class User
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public string Mail { get; set; }
    }
}