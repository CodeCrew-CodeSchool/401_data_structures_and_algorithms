namespace CodeChallenges
{

  public class Animal
  {
    public string Species { get; set; }
    public string Name { get; set; }

    public Animal(string species, string name)
    {
      Species = species;
      Name = name;
    }
  }


  public class AnimalShelter
  {
    public Queue<Animal> AnimalQueue = new();

    public void Enqueue(Animal animal)
    {
      AnimalQueue.Enqueue(animal);
    }

    public Animal Dequeue(string pref)
    {
      if(pref != "dog" && pref !="cat")
      {
        return null;
      }
      try
      {

      Animal next = AnimalQueue.First(a => pref == a.Species);
        if (next != null)
        {
          AnimalQueue = new Queue<Animal>(AnimalQueue.Where(a => a != next));
        }

        return next;
      }
      catch (Exception)
      {
        return null;
      }


    }
  }
}