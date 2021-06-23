using System.Collections;
using System.Collections.Generic;

namespace indexers
{
  public class DragonStringCollection : IEnumerable
  {
    private Dictionary<string, Dragon> dragonList = new();

    public Dragon this[string name]
    {
      get => (Dragon)dragonList[name];
      set => dragonList[name] = value;
    }

    public void ClearDragons() => dragonList.Clear();

    public int Count => dragonList.Count;

    IEnumerator IEnumerable.GetEnumerator() => dragonList.GetEnumerator();
  }
}