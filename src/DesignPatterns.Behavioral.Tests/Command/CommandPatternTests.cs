using DesignPatterns.Behavioral.Command;
using FluentAssertions;

namespace DesignPatterns.Behavioral.Tests.Command;

public class CommandPatternTests
{
    [Test]
    public void TurnOnCommand_ShouldTurnLightOn()
    {
        // Arrange
        var light = new Light();
        var remote = new RemoteControl();
        remote.SetCommand(new TurnOnCommand(light));

        // Act
        remote.PressButton();

        // Assert
        light.IsOn.Should().BeTrue();
    }

    [Test]
    public void TurnOffCommand_ShouldTurnLightOff()
    {
        // Arrange
        var light = new Light();
        light.TurnOn();
        var remote = new RemoteControl();
        remote.SetCommand(new TurnOffCommand(light));

        // Act
        remote.PressButton();

        // Assert
        light.IsOn.Should().BeFalse();
    }

    [Test]
    public void RemoteControl_ShouldSwitchCommands()
    {
        // Arrange
        var light = new Light();
        var remote = new RemoteControl();
        remote.SetCommand(new TurnOnCommand(light));

        // Act
        remote.PressButton();
        remote.SetCommand(new TurnOffCommand(light));
        remote.PressButton();

        // Assert
        light.IsOn.Should().BeFalse();
    }
}
