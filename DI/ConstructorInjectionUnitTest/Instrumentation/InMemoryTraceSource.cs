﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Diagnostics;

namespace TP.DependencyInjection.UnitTest.Instrumentation
{
  internal class InMemoryTraceSource : ITraceSource
  {
    public void TraceData(TraceEventType eventType, int id, object data)
    {
      _callStack.Add(id);
    }
    internal void CheckConsistency()
    {
      Assert.AreEqual<int>(4, _callStack.Count);
      Assert.AreEqual<int>("Alpha".GetHashCode(), _callStack[0]);
      Assert.AreEqual<int>("Bravo".GetHashCode(), _callStack[1]);
      Assert.AreEqual<int>("Charlie".GetHashCode(), _callStack[2]);
      Assert.AreEqual<int>("Delta".GetHashCode(), _callStack[3]);
    }
    internal List<int> _callStack = new List<int>();
  }
}
