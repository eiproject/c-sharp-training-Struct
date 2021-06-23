using System;

namespace Struct_vs_Class {
  struct Rectangle {
    /*int areaSize = 1; // error on struct */
    int areaSize;
    int cornerSize;
    /*internal Rectangle() { } // error on struct*/

    // error because areaSize is not implemented
    /*internal Rectangle(int p, int l) {
      this.cornerSize = p * l;
    }*/

    internal Rectangle(int p, int l) {
      this.cornerSize = p * l;
      this.areaSize = p * l;
    }
    internal int AreaSize {
      get { return areaSize; }
      set { areaSize = value; }
    }
  }

  class RectangleC {
    /*int areaSize = 1; // OK*/
    int areaSize;
    internal RectangleC(int p, int l) {
      this.areaSize = p * l;
    }
    internal int AreaSize {
      get { return areaSize; }
      set { areaSize = value; }
    }
  }
}
