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