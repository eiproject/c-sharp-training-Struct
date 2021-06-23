using System;

namespace Struct_vs_Class
{
  struct Rectangle
  {
    int areaSize;
    internal Rectangle(int p, int l)
    {
      this.areaSize = p * l;
    }
    internal int AreaSize { 
      get { return areaSize; } 
      set { areaSize = value; } 
    }
  }

  class RectangleC
  {
    int areaSize;
    internal RectangleC(int p, int l)
    {
      this.areaSize = p * l;
    }
    internal int AreaSize { 
      get { return areaSize; } 
      set { areaSize = value; } 
    }
  }
}
