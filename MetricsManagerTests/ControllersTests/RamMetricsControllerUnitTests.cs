using MetricsManager.Controllers;
using MetricsManager.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;
using System;
using Xunit;

namespace ControllersTests.MetricsManagerTests
{
    public class RamMetricsControllerUnitTests
    {
        private RamMetricsController _controller;
        private Mock<ILogger<RamMetricsController>> _mockLogger;
        public RamMetricsControllerUnitTests()
        {
            _mockLogger = new Mock<ILogger<RamMetricsController>>();
            _controller = new RamMetricsController(_mockLogger.Object);
        }

        [Fact]
        public void GetMetricsFromAgent_ReturnsOk()
        {
            var agentId = 1;
            var fromTime = new DateTime(2022, 5, 1, 8, 30, 52);
            var toTime = new DateTime(2023, 5, 1, 8, 30, 52);

            var result = _controller.GetMetricsFromAgent(agentId, fromTime, toTime);

            _ = Assert.IsAssignableFrom<IActionResult>(result);
        }

        [Fact]
        public void GetMetricsFromAllCluster_ReturnsOk()
        {
            var fromTime = new DateTime(2022, 5, 1, 8, 30, 52);
            var toTime = new DateTime(2023, 5, 1, 8, 30, 52);

            var result = _controller.GetMetricsFromAllCluster(fromTime, toTime);

            _ = Assert.IsAssignableFrom<IActionResult>(result);
        }
    }
}
