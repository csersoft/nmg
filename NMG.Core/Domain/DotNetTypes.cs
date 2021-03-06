using System;
using System.Collections.Generic;

namespace NMG.Core.Domain
{
  public class DotNetTypes : List<string>
  {
    public DotNetTypes()
    {
      Add(typeof(String).FullName);
      Add(typeof(byte).FullName);
      Add(typeof(char).FullName);
      Add(typeof(UInt16).FullName);
      Add(typeof(Int16).FullName);
      Add(typeof(UInt32).FullName);
      Add(typeof(Int32).FullName);
      Add(typeof(UInt64).FullName);
      Add(typeof(Int64).FullName);

      Add(typeof(double).FullName);
      Add(typeof(decimal).FullName);
      Add(typeof(CUBRID.Data.CUBRIDClient.CUBRIDBlob).FullName);
      Add(typeof(CUBRID.Data.CUBRIDClient.CUBRIDClob).FullName);
      Add(typeof(object[]).FullName);

      Add(typeof(DateTime).FullName);
      Add(typeof(TimeSpan).FullName);

      Add(typeof(byte[]).FullName);

      Add(typeof(Boolean).FullName);
      Add(typeof(Single).FullName);
      Add(typeof(Guid).FullName);
    }
  }
}