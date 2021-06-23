using System.Collections;

namespace indexers
{
  public class DragonCollection : IEnumerable
  {
    private ArrayList dragonArray = new();

    public Dragon GetDragon(int pos) => (Dragon)dragonArray[pos];

    public void AddDragon(Dragon d) => dragonArray.Add(d);

    public void ClearDragons() => dragonArray.Clear();

    public int Count => dragonArray.Count;

    IEnumerator IEnumerable.GetEnumerator() => dragonArray.GetEnumerator();

    public Dragon this[int pos]
    {
      get => (Dragon)dragonArray[pos];
      set => dragonArray.Insert(pos, value);
    }
  }
}