var groupOfPeople = new GroupOfPeople();
groupOfPeople.Add(new Person { Name = "John" });
groupOfPeople.Add(new Person { Name = "Jane" });
groupOfPeople.Add(new Person { Name = "Joe" });
foreach (var person in groupOfPeople)
{
  Console.WriteLine(person.Name);
}

public class GroupOfPeople
{
  private List<Person> _people = new ();

  public void Add(Person person)
  {
    _people.Add(person);
  }

  public IEnumerator<Person> GetEnumerator()
  {
    return _people.GetEnumerator();
  }
}
public class Person
{
  public string Name { get; set; }
}