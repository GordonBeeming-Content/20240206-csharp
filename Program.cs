var groupOfPeople = new GroupOfPeople();
groupOfPeople.Add(new Person { Name = "John" });
groupOfPeople.Add(new Person { Name = "Jane" });
groupOfPeople.Add(new Person { Name = "Joe" });
foreach (var person in groupOfPeople)
{
  if (person.Name == "Jane")
  {
    continue;
  }
  Console.WriteLine(person.Name);
}



