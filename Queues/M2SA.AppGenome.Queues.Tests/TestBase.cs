﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace M2SA.AppGenome.Queues.Tests
{
    [TestFixture]
    public abstract class TestBase
    {
        [TestFixtureSetUp]
        public virtual void Start()
        {
            ApplicationHost.GetInstance().Start();
        }

        [TestFixtureTearDown]
        public virtual void Stop()
        {
            ApplicationHost.GetInstance().Stop();
        }
    }
}
