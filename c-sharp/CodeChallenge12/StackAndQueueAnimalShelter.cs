namespace CodeChallenges
{

  public class Animal
  {
    public string Species { get; set; }
    public string Name { get; set; }

    public Animal(string species, string name) {

      Species = species;
      Name = name;
    }
  }

  public class AnimalShelter
  {
    private Queue<Animal> dogQueue;
    private Queue<Animal> catQueue;

    public AnimalShelter()
    {
      dogQueue = new Queue<Animal>();
      catQueue = new Queue<Animal>();
    }

    public void Enqueue(Animal animal)
    {
      if (animal.Species == "dog")
      {
        dogQueue.Enqueue(animal);
      }
      else if (animal.Species == "cat")
      {
        catQueue.Enqueue(animal);
      }
      // If the species is not dog or cat, ignore the animal.
    }

    public Animal Dequeue(string pref)
    {
      if (pref != "dog" && pref != "cat")
      {
        return null; // Invalid preference
      }

      if (pref == "dog" && dogQueue.Count > 0)
      {
        return dogQueue.Dequeue();
      }

      if (pref == "cat" && catQueue.Count > 0)
      {
        return catQueue.Dequeue();
      }

      // If no animals of the given preference are available, return null.
      return null;
    }
  }
}
