using System;

namespace Struct_vs_Class {
  class Program {
    static void Run() {
      // struct 
      Rectangle R = new Rectangle(2, 3);
      Console.WriteLine(R.AreaSize);

      Rectangle R2 = R;
      R2.AreaSize = 10;
      Console.WriteLine(R.AreaSize); // not affected by SET
      Console.WriteLine(R2.AreaSize);

      // class
      RectangleC RC = new RectangleC(2, 3);
      Console.WriteLine(RC.AreaSize);

      RectangleC RC2 = RC;
      RC2.AreaSize = 10;
      Console.WriteLine(RC.AreaSize);
      Console.WriteLine(RC2.AreaSize);
    }
    static void Main(string[] args) {
      Console.WriteLine("Hello Struct!");
      Run();
    }
  }
}
