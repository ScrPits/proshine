// Decompiled with JetBrains decompiler
// Type: PROProtocol.PokedexPokemon
// Assembly: PROProtocol, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 661A1E55-CDC5-415A-AB7E-E148E47E0F5C
// Assembly location: C:\Users\Derex\Desktop\PROShine-2.6.0.0\PROShine-2.6.1.0 - Copy - Copy\PROProtocol.dll

namespace PROProtocol
{
  public class PokedexPokemon
  {
    private int id { get; set; }

    private string name { get; set; }

    internal PokedexPokemon(int id, int pokeid)
    {
      this.id = id;
      this.name = PokemonNamesManager.Instance.Names[pokeid];
    }

    public override string ToString()
    {
      return this.name;
    }

    public bool isCaught()
    {
      if (this.id != 2)
        return this.id == 3;
      return true;
    }
  }
}
