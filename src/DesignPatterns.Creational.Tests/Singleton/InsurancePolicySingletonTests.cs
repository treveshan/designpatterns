using DesignPatterns.Creational.Singleton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;

namespace DesignPatterns.Creational.Tests.Singleton
{
    public class InsurancePolicySingletonTests
    {
        [Test]
        public void ShouldReturnSameInstance()
        {
            // Arrange & Act
            var instance1 = InsurancePolicySingleton.Instance;
            var instance2 = InsurancePolicySingleton.Instance;

            // Assert
            instance1.Should().BeSameAs(instance2);
        }

        [Test]
        public void ShouldMaintainStateAcrossInstances()
        {
            // Arrange
            var instance1 = InsurancePolicySingleton.Instance;
            instance1.PolicyType = "Comprehensive";
            instance1.Premium = 1500.00;
            instance1.CoverAmount = 500000.00;

            // Act
            var instance2 = InsurancePolicySingleton.Instance;

            // Assert
            instance2.PolicyType.Should().Be("Comprehensive");
            instance2.Premium.Should().Be(1500.00);
            instance2.CoverAmount.Should().Be(500000.00);

            // Verify ToString output
            instance2.ToString().Should().Be("Policy Type: Comprehensive, Premium: 1500, Cover Amount: 500000");
        }

        [Test]
        public void ShouldReturnSameInstanceAcrossMultipleThreads()
        {
            // Arrange
            var instances = new InsurancePolicySingleton[10];
            var tasks = new Task[10];

            // Act
            for (int i = 0; i < 10; i++)
            {
                int index = i;
                tasks[i] = Task.Run(() =>
                {
                    instances[index] = InsurancePolicySingleton.Instance;
                });
            }

            Task.WaitAll(tasks);

            // Assert
            for (int i = 0; i < instances.Length; i++)
            {
                instances[i].Should().BeSameAs(InsurancePolicySingleton.Instance);
            }
        }

        [Test]
        public void ShouldMaintainStateAcrossMultipleThreads()
        {
            // Arrange
            InsurancePolicySingleton.Instance.PolicyType = "Initial";
            InsurancePolicySingleton.Instance.Premium = 1000.00;
            InsurancePolicySingleton.Instance.CoverAmount = 200000.00;

            Task[] tasks = new Task[10];

            // Act
            for (int i = 0; i < 10; i++)
            {
                tasks[i] = Task.Run(() =>
                {
                    // Access and modify the singleton instance
                    var instance = InsurancePolicySingleton.Instance;
                    instance.PolicyType = "Modified";
                    instance.Premium = 2000.00;
                    instance.CoverAmount = 400000.00;
                });
            }

            Task.WaitAll(tasks);

            // Assert
            var singletonInstance = InsurancePolicySingleton.Instance;
            singletonInstance.PolicyType.Should().Be("Modified");
            singletonInstance.Premium.Should().Be(2000.00);
            singletonInstance.CoverAmount.Should().Be(400000.00);
        }
    }
}

