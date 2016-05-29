﻿using HoloLens.DevicePortal.Api.Power;
using HoloLens.DevicePortal.Api.Wpr;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HoloLens.DevicePortal.Tests.Api.Wpr
{
    [TestClass]
    public class WprTests
    {
        [TestMethod]
        public void GetStatusTests()
        {
            WprStatus status = new HoloLensHardware(TestHoloLens.Address, TestHoloLens.Credentials).Wpf.GetWprStatusAsync().Result;

            Assert.AreEqual(WprSessionType.Idle, status.State);
            Assert.AreEqual(WprStateType.Normal, status.SessionType);
        }
    }
}
